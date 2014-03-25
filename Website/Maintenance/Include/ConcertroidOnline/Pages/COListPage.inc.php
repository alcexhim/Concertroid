<?php
	namespace Concertroid\Online\Pages;
	
	class COListColumn
	{
		public $Name;
		public $Title;
		public $ImageURL;
		public $Width;
		
		public function __construct($name, $title, $imageURL = null, $width = null)
		{
			$this->Name = $name;
			$this->Title = $title;
			$this->ImageURL = $imageURL;
			$this->Width = $width;
		}
	}
	class COListItem
	{
		public $Columns;
		public $Selected;
		
		public function __construct($columns = null, $selected = false)
		{
			if ($columns != null)
			{
				$this->Columns = $columns;
			}
			$this->Selected = $selected;
		}
	}
	class COListItemColumn
	{
		public $Name;
		public $Text;
		public $Content;
		public $OnRetrieveContent;
		public $UserData;
		
		public function __construct($name, $content, $text = null, $onRetrieveContent = null, $userData = null)
		{
			$this->Name = $name;
			$this->Content = $content;
			if ($text == null) $text = $content;
			$this->Text = $text;
			$this->OnRetrieveContent = $onRetrieveContent;
			$this->UserData = $userData;
		}
	}
	class COListPage extends \Concertroid\Online\COWebPage
	{
		public $AllowFiltering;
		
		public $Columns;
		public $Items;
		
		public function __construct()
		{
			parent::__construct();
			$this->Columns = array();
			$this->Items = array();
		}
		
		protected function RenderContent()
		{
			if (count($this->Items) <= 0)
			{
?>
<div class="ListView" style="display: table; margin-left: auto; margin-right: auto;">
	There are no items
</div>
<?php
			}
			else
			{
?>
<table class="ListView" style="margin-left: auto; margin-right: auto;">
	<thead>
		<tr>
		<?php
			foreach ($this->Columns as $column)
			{
		?>
			<th<?php if ($column->Width != null) { echo (" style=\"width: " . $column->Width . ";\""); } ?>><a href="#" onclick="lvListView.Sort('<?php echo($column->Name); ?>'); return false;"><?php echo($column->Title); ?></a></th>
		<?php
			}
		?>
		</tr>
	<?php
		if ($this->AllowFiltering)
		{
	?>
	<tr class="Filter">
	<?php
		foreach ($this->Columns as $column)
		{
	?>
		<td>
			<form method="POST">
				<input class="Filter" type="text" name="filter_<?php echo($column->Name); ?>" placeholder="Filter by <?php echo($column->Title); ?>" value="<?php echo($_POST["filter_" . $column->Name]); ?>" />
			</form>
		</td>
	<?php
		}
	?>
	</tr>
	<?php
		}
	?>
	</thead>
	<tbody>
	<?php
		$alternate = false;
		foreach ($this->Items as $item)
		{
			foreach ($item->Columns as $column)
			{
				if ($this->AllowFiltering && $_POST["filter_" . $column->Name] != null)
				{
					if (mb_stripos($column->Text, $_POST["filter_" . $column->Name]) === false) continue;
				}
			}
	?>
		<tr<?php
		if ($alternate)
		{
			if ($item->Selected)
			{
				echo(" class=\"Alternate Selected\"");
			}
			else
			{
				echo(" class=\"Alternate\"");
			}
		}
		else
		{
			if ($item->Selected)
			{
				echo(" class=\"Selected\"");
			}
			else
			{
			}
		}
		?>>
		<?php
		foreach ($item->Columns as $column)
		{
		?>
			<td><?php
				if ($column->OnRetrieveContent != null)
				{
					call_user_func($column->OnRetrieveContent, $column->UserData);
				}
				else
				{
					echo($column->Content);
				}
			?></td>
		<?php
		}
		?>
		</tr>
	<?php
			$alternate = !$alternate;
		}
	?>
	</tbody>
</table>
<?php
/*
	$characters = Character::Get();
	$alternate = false;
	foreach ($characters as $character)
	{
		if ($_POST["filter_character"] != null)
		{
			if (mb_stripos($character->Title, $_POST["filter_character"]) === false) continue;
		}
		if ($_POST["filter_costume"] != null)
		{
			$xerxes = false;
			$costumes = $character->GetCostumes();
			foreach ($costumes as $costume)
			{
				if (mb_stripos($costume->Title, $_POST["filter_costume"]) === false)
				{
					$xerxes = true;
					break;
				}
			}
			if ($xerxes) continue;
		}
		if ($_POST["filter_license"] != null)
		{
			if (mb_stripos($character->License->Title, $_POST["filter_license"]) === false) continue;
		}
?>
	<tr<?php if ($alternate) echo(" class=\"Alternate\""); ?>>
		<td>
		<?php
			$wmlc = new WebMenuLinkControl("wmlcCharacter" . $character->ID, $character->Title, "~/Characters/" . $character->Name, null, array
			(
				new WebMenuItemHeader($character->Title, "Character"),
				new WebMenuItemCommand("Add to concert characters"),
				new WebMenuItemCommand("Edit character details")
			));
			$wmlc->Render();
		?>
		</td>
		<td>
		<?php
			$costumes = $character->GetCostumes();
			$i = 0; $c = count($costumes);
			foreach ($costumes as $costume)
			{
				$wmlc = new WebMenuLinkControl("wmlcCostume" . $character->ID . "_" . $costume->ID, $costume->Title, null, null, array
				(
					new WebMenuItemHeader($costume->Title, "Costume"),
					new WebMenuItemCommand("Search for characters who wear this costume")
				));
				$wmlc->Render();
				
				if ($i < $c - 1) echo("<br />");
				$i++;
			}
		?>
		</td>
		<td>
		<?php
			$license = $character->License;
			if ($license == null)
			{
				echo("(unspecified)");
			}
			else
			{
				$wmlc = new WebMenuLinkControl("wmlcLicense" . $character->ID . "_", $license->Title, null, null, array
				(
					new WebMenuItemHeader($license->Title, "License"),
					new WebMenuItemCommand("View full text of this license"),
					new WebMenuItemCommand("Modify this license")
				));
				$wmlc->Render();
			}
		?>
		</td>
	</tr>
<?php
		$alternate = !$alternate;
	}
?>
</table>
<?php
*/
			}
		}
	}
?>