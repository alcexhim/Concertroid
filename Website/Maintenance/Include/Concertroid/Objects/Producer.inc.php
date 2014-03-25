<?php
	namespace Concertroid\Objects;
	
	class Producer
	{
		public $ID;
		public $Name;
		public $Title;
		
		public static function GetByAssoc($values)
		{
			$item = new Producer();
			$item->ID = $values["ID"];
			$item->Name = $values["Name"];
			$item->Title = $values["Title"];
			return $item;
		}
		public static function GetByIDOrName($idOrName)
		{
			if (is_numeric($idOrName)) return Producer::GetByID($idOrName);
			return Producer::GetByName($idOrName);
		}
		public static function GetByID($id)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Producers WHERE ID = " . $id;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Producer::GetByAssoc($values);
		}
		public static function GetByName($name)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Producers where Name = '" . $MySQL->real_escape_string($name) . "'";
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Producer::GetByAssoc($values);
		}
	}
?>