<?php 
	require("include/System.inc.php");
	
	class ConcertroidHomeWebPage extends ConcertroidWebPage
	{
		protected function RenderContent()
		{
?>
<table style="width: 100%">
	<tr>
		<td colspan="2" style="text-align: center;">
			<img style="width: 75%;" src="<?php echo(\System::ExpandRelativePath("~/images/logo.png")); ?>" />
		</td>
	</tr>
	<tr>
		<td colspan="2" style="text-align: center; color: #FFFF00; padding-bottom: 16px; text-shadow: 4px 4px 4px #CCCC00;">
			build. publish. perform.
		</td>
	</tr>
	<tr>
		<td style="width: 50%; padding-right: 8px;">
			<h1>For the creators</h1>
			<h2><span style="color: #FFFF00">Build</span> your concert</h2>
			<p><strong>Concertroid Studio</strong> is our concert creation and asset development software. You can create models, animations, set lists, and more using this all-in-one package.</p>
			<div style="text-align: right;"><a href="<?php echo(\System::ExpandRelativePath("~/products/studio")); ?>">Read more</a><!-- or <a href="/products/studio/download">download now</a> -->.</div>
			<h2><span style="color: #FFFF00">Publish</span> your event</h2>
			<p>Manage your events with <strong>Concertroid Online</strong>, our Web-based event management system.</p>
			<div style="text-align: right;"><a href="<?php echo(\System::ExpandRelativePath("~/products/online")); ?>">Read more</a></div>
			<h2><span style="color: #FFFF00">Perform</span> your show</h2>
			<p><strong>Concertroid Renderer</strong> is our rendering software. This is the actual program running the concert on the projection system.</p>
			<div style="text-align: right;"><a href="<?php echo(\System::ExpandRelativePath("~/products/renderer")); ?>">Read more</a> or <a href="http://www.youtube.com/watch?v=ITrhd22C7UA" target="_blank">watch the preview on YouTube</a>.</div>
		</td>
		<td style="padding-left: 8px;">
			<h1>For the audience</h1>
			<h2>Find a concert in your area</h2>
			<p><a href="#">Search <strong>Concertroid Community</strong></a> for details on your favorite concert producers' events.</p>
			<h2>Check out these featured events</h2>
			<div class="ViewportNavigation">
			<?php
				// TODO: get list of upcoming events
				$query = "SELECT *, DATE(cre_date_open) AS cre_date_open_date, TIME_FORMAT(cre_date_open, '%H:%i') AS cre_date_open_time, TIME_FORMAT(cre_date_begin, '%H:%i') AS cre_date_begin_time, TIME_FORMAT(cre_date_end, '%H:%i') AS cre_date_end_time FROM cr_events WHERE cre_date_open >= NOW() ORDER BY cre_date_open LIMIT 1"; // 3";
				
				$result = mysql_query($query);
				
				if ($result !== false)
				{
					$count = mysql_num_rows($result);
					if ($count == 0)
					{
						for ($i = 0; $i < $count; $i++)
						{
							$row = mysql_fetch_assoc($result);
			?>
					<span class="ViewportNavigationItem">
						<?php /*
						<span class="ViewportNavigationControlBox">
							<a href="<?php echo("/events/" . $row["cre_name"] . "/edit"); ?>">Edit</a>
						</span>
						*/
						?>
						<a href="<?php echo("/events/" . $row["cre_name"]); ?>">
							<img class="ViewportNavigationItemImage" src="/events/<?php echo($row["cre_name"]); ?>/images/small" alt="<?php echo($row["cre_title"]); ?>" title="<?php echo($row["cre_title"]); ?>" />
							<span class="ViewportNavigationItemTitle"><?php echo($row["cre_title"]); ?></span>
							<span class="ViewportNavigationItemDescription"><?php echo($row["cre_advert_text"]); ?></span>
							<span class="ViewportNavigationItemDate"><?php echo($row["cre_date_open_date"]); ?></span>
							<?php
								if ($row["cre_date_open"] != null)
								{
							?>
								<span class="ViewportNavigationItemDateOpen">OPEN </span>
								<span class="ViewportNavigationItemDate"><?php echo($row["cre_date_open_time"]); ?> </span>
							<?php
								}
							?>
							<?php
								if ($row["cre_date_begin"] != null)
								{
							?>
								<span class="ViewportNavigationItemDateBegin">START </span>
								<span class="ViewportNavigationItemDate"><?php echo($row["cre_date_begin_time"]); ?> </span>
							<?php
								}
							?>
							<?php
								if ($row["cre_date_end"] != null)
								{
							?>
								<span class="ViewportNavigationItemDateEnd">END </span>
								<span class="ViewportNavigationItemDate"><?php echo($row["cre_date_end_time"]); ?></span>
							<?php
								}
							?>
						</a>
					</span>
			<?php
						}
					}
					else
					{
			?>
				There are no events scheduled in the near future.
			<?php
					}
				}
				else
				{
			?>
				Could not load the event list.
			<?php
				}
				/*
				if (mysql_num_rows($result) > 0)
				{
					for ($i = mysql_num_rows($result); $i < 3; $i++)
					{
			?>
						<a href="#" class="ViewportNavigationItem">
							<img class="ViewportNavigationItemImage" src="/images/events/unknown.png" />
							<span class="ViewportNavigationItemTitle">Coming soon!</span>
							<span class="ViewportNavigationItemDescription">Stay tuned for the latest news on upcoming Concertroid! Virtual Entertainment events!</span>
							<span class="ViewportNavigationItemDate">&nbsp;</span>
						</a>
			<?php
					}
				}
				*/
			?>
			</div>
			<div style="text-align: right;">
			<?php
				if ($result !== false)
				{
			?>
				<a href="/events">See all events</a>
			<?php
				}
				else
				{
			?>
				<span class="Disabled">See all events</span>
			<?php
				}
			?>
			</div>
			<h2>Become a creator</h2>
			<p>Stay tuned for workshops and panels which will discuss how to put on the perfect virtual singer concert.</p>
		</td>
	</tr>
</table>


<!--
<h1>Produce your own virtual singer concert</h1>
<p>Download your favorite <a href="/software">concert production software</a> and get started! Concertroid's signature Studio software has not been released for download yet - check back soon!</p>
<h1>Don't miss these upcoming events!</h1>
<p>Find a virtual concert performance near you. The concerts are not all produced by Concertroid! Virtual Entertainment and the rights remain that of the original producers.</p>

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
-->
<br />
<?php
		}
	}
	
	$page = new ConcertroidHomeWebPage();
	$page->Render();
?>