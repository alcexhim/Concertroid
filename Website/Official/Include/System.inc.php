<?php
	class System
	{
		public static $Configuration;
		public static function Redirect($path)
		{
			header("Location: " . System::ExpandRelativePath($path));
			return;
		}
		public static function ExpandRelativePath($path, $includeServerInfo = false)
		{
			$retval = str_replace("~", System::$Configuration["Application.BasePath"], $path);
			if ($includeServerInfo)
			{
				// from http://stackoverflow.com/questions/6768793/php-get-the-full-url
				$sp = strtolower($_SERVER["SERVER_PROTOCOL"]);
				$protocol = substr($sp, 0, strpos($sp, "/")) . $s;
				$port = ($_SERVER["SERVER_PORT"] == "80") ? "" : (":".$_SERVER["SERVER_PORT"]);
				$serverPath = $protocol . "://" . $_SERVER["SERVER_NAME"] . $port;
				$retval = $serverPath . $retval;
			}
			return $retval;
		}
	}
	
	// Configuration
	System::$Configuration = array();
	require("Configuration.inc.php");
	
	// Classes
	require("WebFramework/WebFramework.inc.php");
	
	// Concertroid
	require("Concertroid/Concertroid.inc.php");
?>