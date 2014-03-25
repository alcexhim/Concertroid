<?php
	namespace Concertroid\Objects;
	
	use System;
	
	class Musician
	{
		public $ID;
		public $Name;
		public $Title;
		
		public static function Get($max = null)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Musicians";
			if (is_numeric($max)) $query .= " LIMIT " . $max;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			$retval = array();
			for ($i = 0; $i < $count; $i++)
			{
				$values = $result->fetch_assoc();
				$retval[] = Musician::GetByAssoc($values);
			}
			return $retval;
		}
		public static function GetByAssoc($values)
		{
			$item = new Musician();
			$item->ID = $values["ID"];
			$item->Name = $values["Name"];
			$item->Title = $values["Title"];
			return $item;
		}
		public static function GetByIDOrName($idOrName)
		{
			if (is_numeric($idOrName)) return Musician::GetByID($idOrName);
			return Musician::GetByName($idOrName);
		}
		public static function GetByID($id)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Musicians WHERE ID = " . $id;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Musician::GetByAssoc($values);
		}
		public static function GetByName($name)
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Musicians where Name = '" . $MySQL->real_escape_string($name) . "'";
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return Musician::GetByAssoc($values);
		}
		
		public function GetInstruments()
		{
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "MusicianInstruments, " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Instruments WHERE " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "MusicianInstruments.InstrumentID = " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Instruments.ID AND " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "MusicianInstruments.MusicianID = " . $this->ID;
			
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			$retval = array();
			for ($i = 0; $i < $count; $i++)
			{
				$values = $result->fetch_assoc();
				$retval[] = Instrument::GetByAssoc($values);
			}
			return $retval;
		}
	}
?>