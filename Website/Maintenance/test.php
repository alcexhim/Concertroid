<?php
	require("include/System.inc.php");
	
	$page = new COWebPage();
	$page->BeginContent();
?>
<table style="margin-left: auto; margin-right: auto;">
	<tr>
		<td>Event name:</td>
		<td>
		<?php
			$cboEvent = new WebDropDownControl("cboEvent");
			$cboEvent->RequireSelection = true;
			$cboEvent->Width = 200;
			$cboEvent->Items = array
			(
				new WebMenuItemCommand("39s Giving Day - Tokyo 2010"),
				new WebMenuItemCommand("39s Giving Day - Los Angeles 2011"),
				new WebMenuItemCommand("Mikupa - Tokyo 2011"),
				new WebMenuItemCommand("Mikupa - Sapporo 2011"),
				new WebMenuItemCommand("Mikupa - Singapore 2011"),
				// new WebMenuItemCommand("AniMiku - RIT Toracon 2013"),
				new WebMenuItemCommand("Mikupa - Sapporo 2013"),
				new WebMenuItemCommand("Mikupa - Kansai 2013")
			);
			$cboEvent->Render();
		?>
		</td>
	</tr>
	<tr>
		<td>Choose a venue:</td>
		<td>
		<?php
			$ttVenue = new ToolTip("ttVenue", "Choose a venue", "The venue is the location in which the concert is held.  Be sure to choose one that can support the number of people in your target audience.");
			$ttVenue->Width = 200;
			$ttVenue->BeginContent();
		
			$cboVenue = new WebDropDownControl("cboVenue");
			$cboVenue->RequireSelection = true;
			$cboVenue->Width = 200;
			$cboVenue->Items = array
			(
				new WebMenuItemCommand("Zepp Tokyo"),
				new WebMenuItemCommand("Nokia Theater Los Angeles"),
				new WebMenuItemCommand("Tokyo Dome City Hall")
			);
			$cboVenue->Render();
			
			$ttVenue->EndContent();
		?>
		</td>
	</tr>
	<tr>
		<td>What's your name?</td>
		<td>
		<?php
			$cboName = new WebDropDownControl("cboName");
			$cboName->Width = 200;
			$cboName->Items = array
			(
				new WebMenuItemCommand("Michael Becker"),
				new WebMenuItemCommand("Hatsune Miku"),
				new WebMenuItemCommand("Kagamine Rin"),
				new WebMenuItemCommand("Megurine Luka"),
				new WebMenuItemCommand("Alan Chan")
			);
			$cboName->Render();
		?>
		</td>
	</tr>
</table>
<?php
	$page->EndContent();
?>