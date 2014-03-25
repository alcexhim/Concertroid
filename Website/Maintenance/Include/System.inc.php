<?php
	class System
	{
		public static $Configuration;
		
		public static function Redirect($path)
		{
			header("Location: " . System::ExpandRelativePath($path));
			return;
		}
		public static function ExpandRelativePath($path)
		{
			return str_replace("~/", System::$Configuration["Application.BasePath"] . "/", $path);
		}
		public static function GetVirtualPath()
		{
			if (isset($_GET["virtualpath"]))
			{
				if ($_GET["virtualpath"] != null) return explode("/", $_GET["virtualpath"]);
			}
			return null;
		}
		
		public static function IsSuperAdmin()
		{
			// determine if the currently logged-in user is a super administrator (i.e. hosted accounts admin)
			$username = $_SESSION["username"];
			$password = $_SESSION["password"];
			return (($username == System::$Configuration["Security.Administrator.UserName"]) && (hash("sha256", $password) == System::$Configuration["Security.Administrator.Password"]));
		}
	}
	require("Configuration.inc.php");
	$path = System::GetVirtualPath();
	
	// UUID
	require("UUID.inc.php");
	
	// Web Framework
	require("WebFramework/WebFramework.inc.php");
	
	global $MySQL;
	$MySQL = new mysqli(System::$Configuration["Database.ServerName"], System::$Configuration["Database.UserName"], System::$Configuration["Database.Password"], System::$Configuration["Database.DatabaseName"]);
	$MySQL->set_charset("utf8");
	
	// Concertroid-specific
	require("Concertroid/Concertroid.inc.php");
	require("ConcertroidOnline/ConcertroidOnline.inc.php");
	
	session_start();
?>