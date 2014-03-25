<?php
	namespace Concertroid\Online\Objects;
	
	class Client
	{
		public $ID;
		public $Name;
		public $Title;
		
		public static function GetCurrent()
		{
			$host = explode(".", $_SERVER["HTTP_HOST"]);
			$clientName = $host[count($host) - 3];
			
			return Client::GetByName($clientName);
		}
		public static function GetByAssoc($values)
		{
			$client = new Client();
			$client->ID = $values["ID"];
			$client->Name = $values["Name"];
			$client->Title = $values["Title"];
			return $client;
		}
		public static function GetByIDOrName($idOrName)
		{
			if (is_numeric($idOrName)) return Client::GetByID($idOrName);
			return Client::GetByName($idOrName);
		}
		public static function GetByID($id)
		{
			global $MySQL;
			$query = "SELECT * FROM " . \System::$Configuration["Database.DatabaseName"] . "." . \System::$Configuration["Database.TablePrefix"] . "Clients where ID = " . $id;
			$result = $MySQL->query($query);
			$values = $result->fetch_assoc();
			return Client::GetByAssoc($values);
		}
		public static function GetByName($name)
		{
			global $MySQL;
			$query = "SELECT * FROM " . \System::$Configuration["Database.DatabaseName"] . "." . \System::$Configuration["Database.TablePrefix"] . "Clients where Name = '" . $MySQL->real_escape_string($name) . "'";
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Client::GetByAssoc($values);
		}
	}
?>