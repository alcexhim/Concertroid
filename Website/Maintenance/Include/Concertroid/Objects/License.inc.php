<?php
	namespace Concertroid\Objects;
	
	class License
	{
		public $ID;
		public $Title;
		public $URL;
		
		public static function GetByAssoc($values)
		{
			$item = new License();
			$item->ID = $values["ID"];
			$item->Title = $values["Title"];
			$item->URL = $values["URL"];
			return $item;
		}
		public static function GetByID($id)
		{
			if (!is_numeric($id)) return null;
			
			global $MySQL;
			$query = "SELECT * FROM " . System::$Configuration["Database.DatabaseName"] . "." . System::$Configuration["Database.TablePrefix"] . "Licenses WHERE ID = " . $id;
			$result = $MySQL->query($query);
			$count = $result->num_rows;
			if ($count == 0) return null;
			
			$values = $result->fetch_assoc();
			return License::GetByAssoc($values);
		}
	}
?>