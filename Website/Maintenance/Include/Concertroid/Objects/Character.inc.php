<?php
	namespace Concertroid\Objects;
	
	class Character
	{
		public $ID;
		public $Name;
		public $Title;
		public $License;
		
		public static function GetByAssoc($values)
		{
			$item = new Character();
			$item->ID = $values["ID"];
			$item->Name = $values["Name"];
			$item->Title = $values["Title"];
			$item->License = License::GetByID($values["LicenseID"]);
			return $item;
		}
		public static function Get($max = null)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Characters";
			if (is_numeric($max)) $query .= " LIMIT " . $max;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			$retval = array();
			for ($i = 0; $i < $count; $i++)
			{
				$values = $result->fetch_assoc();
				$retval[] = Character::GetByAssoc($values);
			}
			return $retval;
		}
		public static function GetByIDOrName($idOrName)
		{
			if (is_numeric($idOrName)) return Character::GetByID($idOrName);
			return Character::GetByName($idOrName);
		}
		public static function GetByID($id)
		{
			$client = Client::GetCurrent();
			if ($client == null) return null;
			
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Characters WHERE ID = " . $id . " AND ClientID = " . $client->ID;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Character::GetByAssoc($values);
		}
		public static function GetByName($name)
		{
			$client = Client::GetCurrent();
			if ($client == null) return null;
			
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Characters WHERE Name = '" . $MySQL->real_escape_string($name) . "'";
			
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Character::GetByAssoc($values);
		}
		
		public function GetCostumes()
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "CharacterCostumes, " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Costumes WHERE " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "CharacterCostumes.CharacterID = " . $this->ID . " AND " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "CharacterCostumes.CostumeID = " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Costumes.ID";
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
	}
?>