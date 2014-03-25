<?php
	namespace Concertroid\Objects;
	
	class Song
	{
		public $ID;
		public $URL;
		public $Title;
		public $PermissionStatus;
		
		public static function GetByAssoc($values)
		{
			$item = new Song();
			$item->ID = $values["ID"];
			
			$url = $values["Title"];
			$url = str_replace(" ", "_", $url);
			$url = str_replace(array("/", "*", "&", "?", "\\", "#"), "", $url);
			
			$item->URL = $url;
			$item->Title = $values["Title"];
			$item->PermissionStatus = $values["PermissionStatus"];
			return $item;
		}
		public static function GetByID($id)
		{
			$client = Client::GetCurrent();
			if ($client == null) return null;
			
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Songs WHERE ID = " . $id . " AND ClientID = " . $client->ID;
			$result = $MySQL->query($query);
			$values = $result->fetch_assoc();
			return Song::GetByAssoc($values);
		}
		public static function GetUnauthorized()
		{
			$client = Client::GetCurrent();
			if ($client == null) return null;
			
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Songs WHERE (PermissionStatus = 0 OR PermissionStatus = 2) AND ClientID = " . $client->ID;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			$retval = array();
			for ($i = 0; $i < $count; $i++)
			{
				$values = $result->fetch_assoc();
				$retval[] = Song::GetByAssoc($values);
			}
			return $retval;
		}
	}
?>