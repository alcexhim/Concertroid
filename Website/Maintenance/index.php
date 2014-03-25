<?php
	namespace Concertroid\Online;
	
	use System;
	
	use Concertroid\Objects\Character;
	use Concertroid\Objects\Costume;
	use Concertroid\Objects\Musician;
	use Concertroid\Objects\Song;
	use Concertroid\Objects\Library;
	
	use Concertroid\Online\Objects\Client;
	use Concertroid\Online\Objects\User;
	
	use Concertroid\Online\Pages\COMainPage;
	use Concertroid\Online\Pages\COLoginPage;
	use Concertroid\Online\Pages\COEntryPointPage;
	use Concertroid\Online\Pages\COErrorPage;
	
	use Concertroid\Online\Pages\COCharacterDetailPage;
	use Concertroid\Online\Pages\COCharacterListPage;
	use Concertroid\Online\Pages\COCostumeDetailPage;
	use Concertroid\Online\Pages\COCostumeListPage;
	use Concertroid\Online\Pages\COMusicianDetailPage;
	use Concertroid\Online\Pages\COMusicianListPage;
	use Concertroid\Online\Pages\COSongDetailPage;
	use Concertroid\Online\Pages\COSongListPage;
	use Concertroid\Online\Pages\COLibraryDetailPage;
	use Concertroid\Online\Pages\COLibraryListPage;
	
	require("Include/System.inc.php");
	
	if ($_SERVER["REQUEST_METHOD"] == "POST")
	{
		if ($_POST["UserName"] != null && $_POST["Password"] != null)
		{
			$_SESSION["UserName"] = $_POST["UserName"];
			$_SESSION["Password"] = $_POST["Password"];
		}
	}
	
	$client = Client::GetCurrent();
	$user = User::GetCurrent();
	
	$page = null;
	if ($client != null)
	{
		if ($user != null)
		{
			switch ($path[0])
			{
				case "Characters":
				{
					if (count($path) > 1 && $path[1] != null)
					{
						$page = new COCharacterDetailPage();
						$page->Character = Character::GetByIDOrName($path[1]);
					}
					else
					{
						$page = new COCharacterListPage();
					}
					break;
				}
				case "Costumes":
				{
					if (count($path) > 1 && $path[1] != null)
					{
						$page = new COCostumeDetailPage();
						$page->Costume = Costume::GetByIDOrName($path[1]);
					}
					else
					{
						$page = new COCostumeListPage();
					}
					break;
				}
				case "Musicians":
				{
					if (count($path) > 1 && $path[1] != null)
					{
						$page = new COMusicianDetailPage();
						$page->Musician = Musician::GetByIDOrName($path[1]);
					}
					else
					{
						$page = new COMusicianListPage();
					}
					break;
				}
				case "Songs":
				{
					if (count($path) > 1 && $path[1] != null)
					{
						$page = new COSongDetailPage();
						$page->Song = Song::GetByIDOrName($path[1]);
					}
					else
					{
						$page = new COSongListPage();
					}
					break;
				}
				case "Libraries":
				{
					if (count($path) < 1 || $path[1] == "")
					{
						$page = new COLibraryListPage();
					}
					else
					{
						$library = Library::GetByIDOrName($path[1]);
						if ($library == null)
						{
							$page = new COErrorPage();
							$page->Message = "Could not access the library";
							$page->Description = "The library you are trying to access (" . $path[1] . ") does not exist or you do not have permission to access it.<br /><br />Please ensure that you have permission to access this library and that you have spelled the name correctly, and then try again.";
							$page->ReturnButtonURL = "~/Libraries";
							$page->ReturnButtonText = "Return to Libraries";
							break;
						}
						if (count($path) > 2 && $path[2] != "")
						{
							System::Redirect("~/Libraries/" . $path[1]);
						}
						else
						{
							$page = new COLibraryDetailPage();
							$page->Item = $library;
							break;
						}
					}
					break;
				}
				case "":
				{
					$page = new COMainPage();
					break;
				}
				default:
				{
					System::Redirect("~/");
					return;
				}
			}
		}
		else
		{
			$page = new COLoginPage();
		}
	}
	else
	{
		// user is at top level / location
		$page = new COEntryPointPage();
	}
	
	if ($page == null)
	{
		System::Redirect("~/");
	}
	else
	{
		$page->Render();
	}
?>