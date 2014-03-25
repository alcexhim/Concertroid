<?php
	class Product
	{
		public static function Get($max = null)
		{
			$query = "SELECT * FROM " . System::$Configuration["Database.TablePrefix"] . "products";
			$result = mysql_query($query);
			$count = mysql_num_rows($result);
			$retval = array();
			return $retval;
		}
	}
?>