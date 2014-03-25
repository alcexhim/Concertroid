<?php 
	require("include/system.inc.php");
	
	page_begin(null);
	
	$path = getpath();
	if ($path == null)
	{
		header("Location: /");
		return;
	}
?>
	<br /><br />
<?php
	switch ($path[0])
	{
		case "about":
		{
		?>
			<h1>who we are</h1>
			<p>
				We develop professional virtual entertainment solutions as a single community dedicated to the creation
				and promotion of community-made virtual singer concerts. We develop our own software to facilitate concert
				production, as well as promote other software whose aims are similar to ours. Our goal is to make it easy
				for everyone who wants to perform a virtual singer concert to be able to do so even under a limited budget
				and a small team.
			</p>
			<h1>quality assurance</h1>
			<p>
				We provide a <a href="/content/specification">specification</a> for virtual singer concert production, recommending
				best practices and features so that every virtual concert produced by adherents to the specification will be of the
				utmost quality. Fan-made does not necessarily have to mean low-quality!
			</p>
			<h1>promoting the community</h1>
			<p>
				This new era of technology and high-speed information sharing has brought upon a new way of thinking about the
				entertainment industry. No longer are productions limited to using a single team of people in one central location to
				perform. No longer is creation of visual effects reliant upon costly physical apparatus and technicians with
				specialized knowledge.
			</p>
			<p>
				People from all over the world, who share their creations via YouTube, DeviantART, NicoNicoDouga, and Pixiv, among
				others, can now gather as one community, developing and showcasing their content simultaneously throughout the world.
				We believe that is a goal worth aspiring to.
			</p>
			<p>
				We would love to hear about your activities in the virtual singer community. Please
				<a href="register.php">register</a> with us! You can manage your event using Concertroid! Online's event management
				service. This will automatically feature your event on the front page when it is one of the top 3 events that will be
				presented next!
			</p>
		<?php
			break;
		}
		case "specification":
		{
		?>
			<p>
				
			</p>
		<?php
			break;
		}
		default:
		{
		?>
			<p>
				We're sorry, but the document you requested could not be found. Check to make sure you spelled the name correctly.
				If you were brought to this page via a link on our Web site, please <a href="mailto:webmaster@concertroid.com">contact
				us</a> about it, and we will do our best to fix it. If you see this error because of a link on someone else's Web
				site, the link is probably outdated and we cannot do anything about it. In this case please contact the webmaster
				of the referring site.
			</p>
		<?php
			break;
		}
	}
	page_end();
	
	/*
<h1>The Software</h1>
<p>
	<strong>Concertroid!</strong> is a software product which is the
	reference implementation for the specification. We strive to implement
	every detail of the specification, as well as throwing in our own
	unique twists and special features. <strong>Concertroid!</strong> was the
	first Polygon Movie Maker-compatible rendering engine to support
	<em>lights-off mode</em> and <em>animated textures</em>, which were later
	incorporated into other software. You can read more about
	<strong>Concertroid!</strong> and related software on the
	<a href="/a">Software</a> community page.
</p>
<p>
	All of my software is licensed under the <a href="http://www.gnu.org/copyleft/gpl.html">GNU
	General Public License</a>, meaning that it is free software - anyone can use, modify,
	and redistribute it without restriction, as long as they adhere to the terms of the license.
	The included extra content is licensed under the
	<a href="http://www.creativecommons.org/">Creative Commons Attribution-ShareAlike</a> license.
</p>
<?php
	page_end();
?>
	*/
?>