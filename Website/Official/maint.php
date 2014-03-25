<?php
	
	session_start();
	
	require("include/globals.inc.php");
	include_once("include/settings.inc.php");
	
	include_once("include/qp.inc.php");
	
	include_once("include/database.inc.php");
	include_once("include/user.inc.php");
	
	include_once("include/page.inc.php");
	include_once("include/navigation.inc.php");
	
	function ToggleMaintenanceMode()
	{
		$maintenanceFile = ".maint";
		if (file_exists($maintenanceFile))
		{
			unlink($maintenanceFile);
			if (!file_exists($maintenanceFile))
			{
				echo("Success - Status: Disabled");
			}
			else
			{
				echo("Failed - Status: Enabled");
			}
		}
		else
		{
			$fh = fopen($maintenanceFile, "w");
			if ($fh == null)
			{
				echo("Failed - Status: Disabled");
			}
			else
			{
				echo("Success - Status: Enabled");
			}
			fclose($fh);
		}
	}
	function ChangeUserEmail($uid, $email)
	{
		// Changes user e-mail address
		$result = mysql_query("UPDATE cr_users SET user_email = '" . mysql_real_escape_string($email) . "' WHERE user_id = " . $uid);
		if (mysql_errno() != 0)
		{
			echo("Failed: " . mysql_errno() . " " . mysql_error());
			return false;
		}
		echo("Success");
		return true;
	}
	function ResendActivationEmail($uid)
	{
		// Re-sends the user activation e-mail
		$result = mysql_query("SELECT * FROM cr_users WHERE user_id = " . $uid);
		if (mysql_num_rows($result) == 1)
		{
			// enable the user
			$data = mysql_fetch_assoc($result);
			mail($data["user_email"], "Confirm your registration for Concertroid!", "<html><body><p>Hello, " . $data["user_fullname"] . ".</p><p>Thank you for your interest in becoming a member of the Concertroid! community. Before your request can be processed, you must first confirm your e-mail address by clicking on the link below or copying the link and pasting it into the address bar of your browser.</p><p><a href=\"http://www.concertroid.com/register.php?c=" . $data["user_emailcode"] . "\">http://www.concertroid.com/register.php?c=" . $data["user_emailcode"] . "</a></p><p>Thank you for your patience and understanding! We hope you enjoy being part of the Concertroid! community.</p></body></html>", "From: registration@concertroid.com\r\nContent-type: text/html; charset=iso-8859-1");
			echo("Success");
		}
		else
		{
			echo("Failed: " . mysql_errno() . " " . mysql_error());
		}
	}
	
	switch ($_GET["action"])
	{
		case "ToggleMaintenanceMode":
		{
			ToggleMaintenanceMode();
			break;
		}
		case "ResendActivationEmail":
		{
			ResendActivationEmail($_GET["uid"]);
			break;
		}
		case "ChangeUserEmail":
		{
			ChangeUserEmail($_GET["uid"], $_GET["email"]);
			break;
		}
	}
?>