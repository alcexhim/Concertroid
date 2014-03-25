<?php
	namespace Concertroid\Objects;
	
	use System;
	use Concertroid\Online\Objects\Client;
	use Concertroid\Online\Objects\User;
	
	class Library
	{
		public $ID;
		public $Name;
		public $Title;
		public $Description;
		public $CreationUser;
		public $CreationTimestamp;
		public $LocalIdentifier;
		
		public static function GetByAssoc($values)
		{
			$item = new Library();
			$item->ID = $values["ID"];
			$item->Name = $values["Name"];
			$item->Title = $values["Title"];
			$item->Description = $values["Description"];
			$item->CreationUser = User::GetByID($values["CreationUserID"]);
			$item->CreationTimestamp = $values["CreationTimestamp"];
			$item->LocalIdentifier = $values["LocalIdentifier"];
			return $item;
		}
		public static function Get($max = null)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Libraries WHERE ClientID = 0";
			$client = Client::GetCurrent();
			if ($client != null)
			{
				$query .= " OR ClientID = " . $client->ID;
			}
			if (is_numeric($max)) $query .= " LIMIT " . $max;
			
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			$retval = array();
			for ($i = 0; $i < $count; $i++)
			{
				$values = $result->fetch_assoc();
				$retval[] = Library::GetByAssoc($values);
			}
			return $retval;
		}
		public static function GetByID($id)
		{
			if (!is_numeric($id)) return null;
			
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Libraries WHERE ID = " . $id . " AND (ClientID = 0";
			$client = Client::GetCurrent();
			if ($client != null)
			{
				$query .= " OR ClientID = " . $client->ID;
			}
			$query .= ")";
			
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Library::GetByAssoc($values);
		}
		public static function GetByName($name)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Libraries WHERE Name = '" . $MySQL->real_escape_string($name) . "'";
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Library::GetByAssoc($values);
		}
		public static function GetByIDOrName($idOrName)
		{
			if (is_numeric($idOrName)) return Library::GetByID($idOrName);
			return Library::GetByName($idOrName);
		}
	}
?>