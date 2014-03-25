<?php
	namespace Concertroid\Objects;
	
	class Costume
	{
		public $ID;
		public $Name;
		public $Title;
		
		public static function GetByAssoc($values)
		{
			$item = new Costume();
			$item->ID = $values["ID"];
			$item->Name = $values["Name"];
			$item->Title = $values["Title"];
			return $item;
		}
		public static function GetByIDOrName($idOrName)
		{
			if (is_numeric($idOrName)) return Costume::GetByID($idOrName);
			return Costume::GetByName($idOrName);
		}
		public static function GetByID($id)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Costumes WHERE ID = " . $id;
			$result = $MySQL->query($query);
			$values = $result->fetch_assoc();
			return Costume::GetByAssoc($values);
		}
		/*
		public static function GetByStatus($status)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Costumes WHERE Status = " . $status;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			$retval = array();
			for ($i = 0; $i < $count; $i++)
			{
				$values = $result->fetch_assoc();
				$retval[] = Costume::GetByAssoc($values);
			}
			return $retval;
		}
		public static function GetIncomplete()
		{
			$items0 = Costume::GetByStatus(0);
			$items1 = Costume::GetByStatus(1);
			$items = array_merge($items0, $items1);
			return $items;
		}
		*/
		public static function GetByName($name)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Costumes WHERE Name = '" . $MySQL->real_escape_string($name) . "'";
			
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Costume::GetByAssoc($values);
		}
		
		public function GetProducers()
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "CostumeProducers, " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Producers WHERE " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "CostumeProducers.CostumeID = " . $this->ID . " AND " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "CostumeProducers.ProducerID = " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Producers.ID";
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			$retval = array();
			for ($i = 0; $i < $count; $i++)
			{
				$values = $result->fetch_assoc();
				$retval[] = Producer::GetByAssoc($values);
			}
			return $retval;
		}
	}
?>