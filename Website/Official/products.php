<?php	
	require("include/System.inc.php");
	
	$pathCount = count($path);
	if ($path != null)
	{
	}
	else
	{
		$result = Product::Get();
	}
?>
<?php
	$page = new ConcertroidWebPage("Products and Services");
	$page->BeginContent();
?>
<?php
?>
	<h1>Get started with building your concert</h1>
	
	<p>
		Presentation software is one of the key components in putting on any kind of concert. The software must be able to keep the animations in sync with the music, as well as allowing for smooth transition between each of the songs on your set list. 
	</p>
	<h1>Make a lasting first impression</h1>
	<p>
		When you choose a Concertroid solution, we guarantee quality animation and smooth rendering for all your virtual
		performance needs.
	</p>
<?php
	$page->EndContent();
?>