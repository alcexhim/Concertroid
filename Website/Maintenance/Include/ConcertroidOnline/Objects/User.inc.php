<?php
	namespace Concertroid\Online\Objects;
	
	class User
	{
		public $ID;
		public $UserName;
		public $Title;
		
		public static function GetCurrent()
		{
			if (isset($_SESSION["UserName"]) && isset($_SESSION["Password"]))
			{
				$username = $_SESSION["UserName"];
				$password = $_SESSION["Password"];
				return User::GetByCredentials($username, $password);
			}
			return null;
		}
		public static function GetByAssoc($values)
		{
			$user = new User();
			$user->ID = $values["ID"];
			$user->Name = $values["UserName"];
			$user->Title = $values["Title"];
			return $user;
		}
		public static function GetByCredentials($username, $password)
		{
			global $MySQL;
			
			$client = Client::GetCurrent();
			if ($client == null) return null;
			
			$query = "SELECT * FROM " . \System::$Configuration["Database.DatabaseName"] . "." . \System::$Configuration["Database.TablePrefix"] . "Users WHERE UserName = '" . $MySQL->real_escape_string($username) . "' AND Password = '" . hash("sha512", $password) . "' AND ClientID = " . $client->ID;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return User::GetByAssoc($values);
		}
		public static function GetByIDOrName($idOrName)
		{
			if (is_numeric($idOrName)) return User::GetByID($idOrName);
			return User::GetByName($idOrName);
		}
		public static function GetByID($id)
		{
			global $MySQL;
			$query = "SELECT * FROM " . \System::$Configuration["Database.DatabaseName"] . "." . \System::$Configuration["Database.TablePrefix"] . "Users WHERE ID = " . $id;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return User::GetByAssoc($values);
		}
		public static function GetByName($name)
		{
			global $MySQL;
			$query = "SELECT * FROM " . \System::$Configuration["Database.DatabaseName"] . "." . \System::$Configuration["Database.TablePrefix"] . "Users where UserName = '" . $MySQL->real_escape_string($name) . "'";
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return User::GetByAssoc($values);
		}
	}
?>