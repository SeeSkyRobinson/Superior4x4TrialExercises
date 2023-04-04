<?php
// Database connection details
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "testDb";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Prepare and bind
$stmt = $conn->prepare("SELECT * FROM users WHERE username = ?");
$stmt->bind_param("s", $input_username);

// Set parameters and execute
$input_username = $_POST['username'];
$input_password = $_POST['password'];
$stmt->execute();

// Get result
$result = $stmt->get_result();
$row = $result->fetch_assoc();

// Check if the user exists and the password is correct
if ($row && password_verify($input_password, $row['password'])) {
    // Output successful logins
    $query = "SELECT * FROM successful_logins";
    $result = $conn->query($query);

    echo "Past successful logins:<br>";
    while ($row = $result->fetch_assoc()) {
        echo "Username: " . $row["username"] . " - Login Time: " . $row["login_time"] . "<br>";
    }

    // Insert new successful login
    $stmt2 = $conn->prepare("INSERT INTO successful_logins (username) VALUES (?)");
    $stmt2->bind_param("s", $input_username);
    $stmt2->execute();
    $stmt2->close();

} else {
    echo "Invalid username or password.";
}

// Close statement and connection
$stmt->close();
$conn->close();
?>
