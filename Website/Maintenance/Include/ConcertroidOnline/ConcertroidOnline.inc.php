<?php
	namespace Concertroid\Online;
	
	require("Objects/Client.inc.php");
	require("Objects/User.inc.php");
	
	require("Controls/COHeaderControl.inc.php");
	require("Controls/COTaskListControl.inc.php");
	require("Controls/COSongDetailPanelControl.inc.php");
	
	require("COWebPage.inc.php");
	
	// Message and Error pages
	require("Pages/COMessagePage.inc.php");
	require("Pages/COErrorPage.inc.php");
	
	// List page
	require("Pages/COListPage.inc.php");
	
	// Login page
	require("Pages/COLoginPage.inc.php");
	
	// All other pages
	require("Pages/COMainPage.inc.php");
	require("Pages/COMusicianPage.inc.php");
	require("Pages/COEntryPointPage.inc.php");
	require("Pages/COLibraryPage.inc.php");
	require("Pages/COCharacterPage.inc.php");
	require("Pages/COCostumePage.inc.php");
	require("Pages/COSongPage.inc.php");
?>