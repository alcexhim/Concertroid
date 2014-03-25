<?php
	namespace Concertroid\Objects;
	
	class Animation
	{
		public $ID;
		public $URL;
		public $Title;
		public $Status;
		
		public static function GetByAssoc($values)
		{
			$item = new Animation();
			$item->ID = $values["ID"];
			
			$url = $values["Title"];
			$url = str_replace(" ", "_", $url);
			$url = str_replace(array("/", "*", "&", "?", "\\", "#"), "", $url);
			
			$item->URL = $url;
			$item->Title = $values["Title"];
			$item->Status = $values["Status"];
			return $item;
		}
		public static function GetByIDOrName($idOrName)
		{
			if (is_numeric($idOrName)) return Animation::GetByID($idOrName);
			return Animation::GetByName($idOrName);
		}
		public static function GetByID($id)
		{
			$client = Client::GetCurrent();
			if ($client == null) return null;
			
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Animations WHERE ID = " . $id . " AND ClientID = " . $client->ID;
			$result = $MySQL->query($query);
			$values = $result->fetch_assoc();
			return Animation::GetByAssoc($values);
		}
		public static function GetByStatus($status)
		{
			$client = Client::GetCurrent();
			if ($client == null) return null;
			
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Animations WHERE Status = " . $status . " AND ClientID = " . $client->ID;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			$retval = array();
			for ($i = 0; $i < $count; $i++)
			{
				$values = $result->fetch_assoc();
				$retval[] = Animation::GetByAssoc($values);
			}
			return $retval;
		}
		public static function GetIncomplete()
		{
			$items0 = Animation::GetByStatus(0);
			$items1 = Animation::GetByStatus(1);
			$items = array_merge($items0, $items1);
			return $items;
		}
		public static function GetByName($name)
		{
			$client = Client::GetCurrent();
			if ($client == null) return null;
			
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Animations WHERE Name = '" . $MySQL->real_escape_string($name) . "' AND ClientID = " . $client->ID;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Animation::GetByAssoc($values);
		}
	}
?>