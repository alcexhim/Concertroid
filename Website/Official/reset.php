<?php
	require("include/system.inc.php");
	page_begin();
	
	function maint_log_entry_begin($action_title, $object_title = null)
	{
		$successful = (mysql_errno() == 0);
		
		echo("<div class=\"MaintenanceLogEntry" . ($successful ? " MaintenanceLogEntrySuccessful" : " MaintenanceLogEntryFailure") . "\">");
		echo("<div class=\"MaintenanceLogEntryAction\">" . $action_title . ($object_title != null ? (" <span class=\"MaintenanceLogEntryObject\">" . $object_title . "</span>") : "") . "</div>");
		echo("<table class=\"MaintenanceLogEntryParameterList\">");
	}
	function maint_log_entry_parameter($name, $value)
	{
		echo("<tr class=\"MaintenanceLogEntryParameter\">");
		echo("<td class=\"MaintenanceLogEntryParameterName\">" . $name . "</span>");
		echo("<td class=\"MaintenanceLogEntryParameterValue\">" . $value . "</span>");
		echo("</tr>");
	}
	function maint_log_entry_end()
	{
		if (mysql_errno() != 0)
		{
			maint_log_entry_end2(mysql_errno() . ": " . mysql_error());
		}
		else
		{
			maint_log_entry_end2();
		}
	}
	function maint_log_entry_end2($errorMessage = null)
	{
		echo("</table>");
		if ($errorMessage != null)
		{
			echo("<div class=\"MaintenanceLogEntryErrorMessage\">" . $errorMessage . "</div>");
		}
		echo("</div>");
	}
	function maint_log_entry_begin_skipped($action_title, $object_title = null)
	{
		$successful = (mysql_errno() == 0);
		
		echo("<div class=\"MaintenanceLogEntry MaintenanceLogEntrySkipped\">");
		echo("<div class=\"MaintenanceLogEntryAction\">" . $action_title . ($object_title != null ? (" <span class=\"MaintenanceLogEntryObject\">" . $object_title . "</span>") : "") . "</div>");
		echo("<table class=\"MaintenanceLogEntryParameterList\">");
	}
	function maint_log_entry_begin_failure($action_title, $object_title = null)
	{
		$successful = (mysql_errno() == 0);
		
		echo("<div class=\"MaintenanceLogEntry MaintenanceLogEntryFailure\">");
		echo("<div class=\"MaintenanceLogEntryAction\">" . $action_title . ($object_title != null ? (" <span class=\"MaintenanceLogEntryObject\">" . $object_title . "</span>") : "") . "</div>");
		echo("<table class=\"MaintenanceLogEntryParameterList\">");
	}
	
	function drop_table($table_name)
	{
		mysql_query("DROP TABLE IF EXISTS " . $table_name);
		
		maint_log_entry_begin("Dropping table", $table_name);
		maint_log_entry_end();
	}

	function bounce_cr_organizers()
	{
		drop_table("cr_organizers");
		
		mysql_query("CREATE TABLE cr_organizers (cro_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, cro_title VARCHAR(100) NOT NULL, cro_website VARCHAR(100), cro_date_created VARCHAR(10));");
		
		maint_log_entry_begin("Creating table", "cr_organizers");
		maint_log_entry_end();
	}
	function insert_cr_organizers($cro_title, $cro_website, $cro_date_created = NULL)
	{
		mysql_query("INSERT INTO cr_organizers (cro_title, cro_website, cro_date_created) VALUES (" .
			"'" . mysql_real_escape_string($cro_title) . "'," .
			"'" . mysql_real_escape_string($cro_website) . "'," .
			(($cro_date_created == NULL) ? "NULL" : "'" . mysql_real_escape_string($cro_date_created) . "'") .
			")");
		
		maint_log_entry_begin("Populating table", "cr_organizers");
		maint_log_entry_parameter("cro_title", $cro_title);
		maint_log_entry_parameter("cro_website", $cro_website);
		maint_log_entry_parameter("cro_date_created", $cro_date_created);
		maint_log_entry_end();
	}

	function bounce_cr_partners()
	{
		drop_table("cr_partners");
		
		mysql_query("CREATE TABLE cr_partners (crp_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, crp_name VARCHAR(20) NOT NULL, crp_title VARCHAR(100), crp_website VARCHAR(100));");
		
		maint_log_entry_begin("Creating table", "cr_partners");
		maint_log_entry_end();
	}
	function insert_cr_partners($crp_name, $crp_title, $crp_website)
	{
		mysql_query("INSERT INTO cr_partners (crp_name, crp_title, crp_website) VALUES (" .
			"'" . mysql_real_escape_string($crp_name) . "'," .
			"'" . mysql_real_escape_string($crp_title) . "'," .
			"'" . mysql_real_escape_string($crp_website) . "'" .
			")");
		
		maint_log_entry_begin("Populating table", "cr_partners");
		maint_log_entry_parameter("crp_name", $crp_name);
		maint_log_entry_parameter("crp_title", $crp_title);
		maint_log_entry_parameter("crp_website", $crp_website);
		maint_log_entry_end();
	}

	function bounce_cr_locations()
	{
		drop_table("cr_locations");
		
		mysql_query("CREATE TABLE cr_locations (crl_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, crl_street VARCHAR(100), crl_city VARCHAR(100), crl_state VARCHAR(100), crl_country VARCHAR(100));");
		
		maint_log_entry_begin("Creating table", "cr_locations");
		maint_log_entry_end();
	}
	function insert_cr_locations($crl_street, $crl_city, $crl_state, $crl_country)
	{
		mysql_query("INSERT INTO cr_locations (crl_street, crl_city, crl_state, crl_country) VALUES (" .
			"'" . mysql_real_escape_string($crl_street) . "'," .
			"'" . mysql_real_escape_string($crl_city) . "'," .
			"'" . mysql_real_escape_string($crl_state) . "'," .
			"'" . mysql_real_escape_string($crl_country) . "'" .
			");");
		
		maint_log_entry_begin("Populating table", "cr_organizers");
		maint_log_entry_parameter("crl_street", $crl_street);
		maint_log_entry_parameter("crl_city", $crl_city);
		maint_log_entry_parameter("crl_state", $crl_state);
		maint_log_entry_parameter("crl_country", $crl_country);
		maint_log_entry_end();
	}
	function bounce_cr_software()
	{
		drop_table("cr_software");
		
		mysql_query("CREATE TABLE cr_software (crs_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, crs_name VARCHAR(20) NOT NULL, crs_title VARCHAR(100) NOT NULL, crs_author VARCHAR(100), crs_website VARCHAR(100), crs_description VARCHAR(500));");
		
		maint_log_entry_begin("Creating table", "cr_software");
		maint_log_entry_end();
	}
	function insert_cr_software($crs_name, $crs_title, $crs_author, $crs_website, $crs_description)
	{
		mysql_query("INSERT INTO cr_software (crs_name, crs_title, crs_author, crs_website, crs_description) VALUES (" .
		"'" . mysql_real_escape_string($crs_name) . "', " .
		"'" . mysql_real_escape_string($crs_title) . "', " .
		"'" . mysql_real_escape_string($crs_author) . "', " .
		"'" . mysql_real_escape_string($crs_website) . "', " .
		"'" . mysql_real_escape_string($crs_description) .
		"');");
		
		maint_log_entry_begin("Populating table", "cr_software");
		maint_log_entry_parameter("crs_name", $crs_name);
		maint_log_entry_parameter("crs_title", $crs_title);
		maint_log_entry_parameter("crs_author", $crs_author);
		maint_log_entry_parameter("crs_website", $crs_website);
		maint_log_entry_parameter("crs_description", $crs_description);
		maint_log_entry_end();
	}
	function bounce_cr_software_releases()
	{
		drop_table("cr_software_releases");
		
		mysql_query("CREATE TABLE cr_software_releases (crr_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, crr_software_id INT NOT NULL, crr_version VARCHAR(10) NOT NULL, crr_description VARCHAR(1000), crr_date_released VARCHAR(8), crr_download_url VARCHAR(1000), crr_platform VARCHAR(20));");
		
		maint_log_entry_begin("Creating table", "cr_software_releases");
		maint_log_entry_end();
	}
	function insert_cr_software_releases($crr_software_id, $crr_version, $crr_description, $crr_date_released = NULL, $crr_download_url = NULL, $crr_platform = NULL)
	{
		mysql_query("INSERT INTO cr_software_releases (crr_software_id, crr_version, crr_description, crr_date_released, crr_download_url, crr_platform) VALUES(" .
		$crr_software_id . ", " .
		"'" . mysql_real_escape_string($crr_version) . "', " .
		"'" . mysql_real_escape_string($crr_description) . "', " .
		(($crr_date_released == null) ? "NULL" : "'" . mysql_real_escape_string($crr_date_released) . "'") . ", " .
		(($crr_download_url == null) ? "NULL" : "'" . mysql_real_escape_string($crr_download_url) . "'") . ", " .
		(($crr_platform == null) ? "NULL" : "'" . mysql_real_escape_string($crr_platform) . "'") .
		");");
		
		maint_log_entry_begin("Populating table", "cr_software_releases");
		maint_log_entry_parameter("Software ID", $crr_software_id);
		maint_log_entry_parameter("Version", $crr_version);
		maint_log_entry_parameter("Description", $crr_description);
		maint_log_entry_parameter("Date released", $crr_date_released);
		maint_log_entry_parameter("Download URL", $crr_download_url);
		maint_log_entry_parameter("Platform", $crr_platform);
		maint_log_entry_end();
	}
	function bounce_cr_events()
	{
		drop_table("cr_events");
		
		mysql_query("CREATE TABLE cr_events (cre_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, cre_name VARCHAR(20) NOT NULL, cre_title VARCHAR(100) NOT NULL, cre_website VARCHAR(100), cre_advert_text VARCHAR(500), cre_description LONGTEXT, cre_stream VARCHAR(200), cre_date_open DATETIME, cre_date_begin DATETIME, cre_date_end DATETIME, cre_location_id INT, cre_visible INT DEFAULT 1);");
		
		maint_log_entry_begin("Creating table", "cr_events");
		maint_log_entry_end();
	}
	function insert_cr_events($cre_name, $cre_title, $cre_website, $cre_advert_text, $cre_description, $cre_stream, $cre_date_open, $cre_date_begin, $cre_date_end, $cre_location_id = null, $cre_visible = true)
	{
		mysql_query("INSERT INTO cr_events (cre_name, cre_title, cre_website, cre_advert_text, cre_description, cre_stream, cre_date_open, cre_date_begin, cre_date_end, cre_location_id, cre_visible) VALUES (" .
		"'" . mysql_real_escape_string($cre_name) . "', " .
		"'" . mysql_real_escape_string($cre_title) . "', " .
		"'" . mysql_real_escape_string($cre_website) . "', " .
		"'" . mysql_real_escape_string($cre_advert_text) . "', " .
		"'" . mysql_real_escape_string($cre_description) . "', " .
		"'" . mysql_real_escape_string($cre_stream) . "', " .
		"'" . mysql_real_escape_string($cre_date_open) . "', " .
		"'" . mysql_real_escape_string($cre_date_begin) . "', " .
		"'" . mysql_real_escape_string($cre_date_end) . "', " .
		(($cre_location_id == null) ? "NULL" : $cre_location_id) . ", " .
		($cre_visible ? "1" : "0") . ");");
		
		maint_log_entry_begin("Populating table", "cr_events");
		maint_log_entry_parameter("Event name", $cre_name);
		maint_log_entry_parameter("Event title", $cre_title);
		maint_log_entry_parameter("Web site URL", $cre_website);
		maint_log_entry_parameter("Advertisement text", $cre_advert_text);
		maint_log_entry_parameter("Description", $cre_description);
		maint_log_entry_parameter("Live stream URL", $cre_stream);
		maint_log_entry_parameter("Date open", $cre_date_open);
		maint_log_entry_parameter("Date begin", $cre_date_begin);
		maint_log_entry_parameter("Date end", $cre_date_end);
		maint_log_entry_parameter("Location ID", $cre_location_id);
		maint_log_entry_parameter("Visible", $cre_visible);
		maint_log_entry_end();
	}
	function bounce_cr_songs()
	{
		drop_table("cr_songs");
		
		mysql_query("CREATE TABLE cr_songs (song_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, song_title VARCHAR(100) NOT NULL);");
		
		maint_log_entry_begin("Creating table", "cr_songs");
		maint_log_entry_end();
	}
	function insert_cr_songs($song_title)
	{
		mysql_query("INSERT INTO cr_songs (song_title) VALUES ('" . mysql_real_escape_string($song_title) . "');");
		
		maint_log_entry_begin("Populating table", "cr_songs");
		maint_log_entry_parameter("Song title", $song_title);
		maint_log_entry_end();
	}
	
	function bounce_cr_performers()
	{
		drop_table("cr_performers");
		mysql_query("CREATE TABLE cr_performers (performer_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, performer_name_first VARCHAR(100) NOT NULL, performer_name_last VARCHAR(100), performer_color VARCHAR(50), performer_color_alternate VARCHAR(50));");
		
		maint_log_entry_begin("Creating table", "cr_performers");
		maint_log_entry_end();
	}
	function insert_cr_performers($performer_name_first, $performer_name_last = NULL, $color = NULL, $color_alternate = NULL)
	{
		mysql_query("INSERT INTO cr_performers (performer_name_first, performer_name_last, performer_color, performer_color_alternate) VALUES (".
		("'" . mysql_real_escape_string($performer_name_first) . "'") . ", " .
		($performer_name_last == NULL ? "NULL" : ("'" . mysql_real_escape_string($performer_name_last) . "'")) . ", " .
		($color == NULL ? "NULL" : ("'" . mysql_real_escape_string($color) . "'")) . ", " .
		($color_alternate == NULL ? "NULL" : ("'" . mysql_real_escape_string($color_alternate) . "'")) .
		");");
		
		maint_log_entry_begin("Populating table", "cr_performers");
		maint_log_entry_parameter("Performer first name", $performer_name_first);
		maint_log_entry_parameter("Performer last name", $performer_name_last);
		maint_log_entry_parameter("Color", $color);
		maint_log_entry_parameter("AlternateColor", $color_alternate);
		maint_log_entry_end();
	}
	
	function bounce_cr_song_performers()
	{
		drop_table("cr_song_performers");
		
		mysql_query("CREATE TABLE cr_song_performers (song_id INT, performer_id INT);");
		
		
		maint_log_entry_begin("Creating table", "cr_song_performers");
		maint_log_entry_end();
	}
	function insert_cr_song_performers($song_id, $performer_id)
	{
		mysql_query("INSERT INTO cr_song_performers (song_id, performer_id) VALUES (" . $song_id . ", " . $performer_id . ");");
		
		maint_log_entry_begin("Populating table", "cr_song_performers");
		maint_log_entry_parameter("Song ID", $song_id);
		maint_log_entry_parameter("Performer ID", $performer_id);
		maint_log_entry_end();
	}
	
	function bounce_cr_event_organizers()
	{
		drop_table("cr_event_organizers");
		
		mysql_query("CREATE TABLE cr_event_organizers (event_id INT NOT NULL, organizer_id INT NOT NULL);");
		
		maint_log_entry_begin("Creating table", "cr_event_organizers");
		maint_log_entry_end();
	}
	function insert_cr_event_organizers($event_id, $organizer_id)
	{
		mysql_query("INSERT INTO cr_event_organizers (event_id, organizer_id) VALUES (" . mysql_real_escape_string($event_id) . ", " . $organizer_id . ")");
		
		maint_log_entry_begin("Populating table", "cr_event_organizers");
		maint_log_entry_parameter("Event ID", $event_id);
		maint_log_entry_parameter("Organizer ID", $organizer_id);
		maint_log_entry_end();
	}
	function bounce_cr_event_songs()
	{
		drop_table("cr_event_songs");
		mysql_query("CREATE TABLE cr_event_songs (event_id INT NOT NULL, song_id INT NOT NULL);");
		
		maint_log_entry_begin("Creating table", "cr_event_songs");
		maint_log_entry_end();
	}
	function insert_cr_event_songs($event_id, $song_id)
	{
		mysql_query("INSERT INTO cr_event_songs (event_id, song_id) VALUES (" . $event_id . ", " . $song_id . ")");
		
		maint_log_entry_begin("Populating table", "cr_event_songs");
		maint_log_entry_parameter("Event ID", $event_id);
		maint_log_entry_parameter("Song ID", $song_id);
		maint_log_entry_end();
	}
	
	function bounce_cr_users()
	{
		drop_table("cr_users");
		mysql_query("CREATE TABLE cr_users (user_id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, user_username VARCHAR(50) NOT NULL, user_password VARCHAR(50) NOT NULL, user_displayname VARCHAR(50) NOT NULL, user_fullname VARCHAR(50) NOT NULL, user_email VARCHAR(50) NOT NULL, user_enabled BIT NOT NULL, user_visible BIT NOT NULL, user_emailcode VARCHAR(16), user_activatecode VARCHAR(32), user_comments VARCHAR(1000));");
		
		maint_log_entry_begin("Creating table", "cr_users");
		maint_log_entry_end();
	}
	function insert_cr_users($user_username, $user_password, $user_displayname, $user_fullname, $user_email, $user_enabled = true, $user_visible = true, $user_emailcode = NULL, $user_activatecode = NULL)
	{
		mysql_query("INSERT INTO cr_users (user_username, user_password, user_displayname, user_fullname, user_email, user_enabled, user_visible, user_emailcode, user_activatecode) VALUES (" .
			"'" . mysql_real_escape_string($user_username) . "', " .
			"'" . mysql_real_escape_string($user_password) . "', " .
			"'" . mysql_real_escape_string($user_displayname) . "', " .
			"'" . mysql_real_escape_string($user_fullname) . "', " .
			"'" . mysql_real_escape_string($user_email) . "', " .
			($user_enabled ? "1" : "0") . ", " .
			($user_visible ? "1" : "0") . ", " .
			($user_emailcode == NULL ? "NULL" : "'" . mysql_real_escape_string($user_emailcode) . "'") . ", " .
			($user_activatecode == NULL ? "NULL" : "'" . mysql_real_escape_string($user_activatecode) . "'") .
		");");
		
		maint_log_entry_begin("Populating table", "cr_users");
		maint_log_entry_parameter("User name", $user_username);
		maint_log_entry_parameter("Password", $user_password);
		maint_log_entry_parameter("Display name", $user_displayname);
		maint_log_entry_parameter("Full name", $user_fullname);
		maint_log_entry_parameter("E-mail address", $user_email);
		maint_log_entry_parameter("Enabled", $user_enabled);
		maint_log_entry_parameter("Visible", $user_visible);
		maint_log_entry_parameter("E-mail code", $user_emailcode);
		maint_log_entry_parameter("Activation code", $user_activatecode);
		maint_log_entry_end();
	}
	
	function bounce_cr_permissions()
	{
		drop_table("cr_permissions");
		mysql_query("CREATE TABLE cr_permissions (permission_id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, permission_name VARCHAR(50) NOT NULL);");
		
		maint_log_entry_begin("Creating table", "cr_permissions");
		maint_log_entry_end();
	}
	function insert_cr_permissions($permission_name)
	{
		mysql_query("INSERT INTO cr_permissions (permission_name) VALUES ('" . mysql_real_escape_string($permission_name) . "')");
		
		maint_log_entry_begin("Populating table", "cr_permissions");
		maint_log_entry_parameter("Permission name", $permission_name);
		maint_log_entry_end();
	}
	
	function bounce_cr_user_permissions()
	{
		drop_table("cr_user_permissions");
		mysql_query("CREATE TABLE cr_user_permissions (user_id INT NOT NULL, permission_id INT NOT NULL);");
		
		maint_log_entry_begin("Creating table", "cr_user_permissions");
		maint_log_entry_end();
	}
	function insert_cr_user_permissions($user_id, $permission_id)
	{
		mysql_query("INSERT INTO cr_user_permissions (user_id, permission_id) VALUES (" . $user_id . ", " . $permission_id . ")");
		
		maint_log_entry_begin("Populating table", "cr_user_permissions");
		maint_log_entry_parameter("User ID", $user_id);
		maint_log_entry_parameter("Permission ID", $permission_id);
		maint_log_entry_end();
	}
	
	function bounce_cr_capabilities()
	{
		drop_table("cr_capabilities");
		mysql_query("CREATE TABLE cr_capabilities (capability_id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, capability_title VARCHAR(50) NOT NULL);");
		
		maint_log_entry_begin("Creating table", "cr_capabilities");
		maint_log_entry_end();
	}
	function insert_cr_capabilities($capability_title)
	{
		mysql_query("INSERT INTO cr_capabilities (capability_title) VALUES ('" . mysql_real_escape_string($capability_title) . "');");
		
		maint_log_entry_begin("Populating table", "cr_capabilities");
		maint_log_entry_parameter("Capability title", $capability_title);
		maint_log_entry_end();
	}
	
	function bounce_cr_messages()
	{
		drop_table("cr_messages");
		mysql_query("CREATE TABLE cr_messages (message_id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, message_sender INT NOT NULL, message_receiver INT NOT NULL, message_subject VARCHAR(50) NOT NULL, message_content VARCHAR(5000) NOT NULL, message_timestamp VARCHAR(8), message_status INT NOT NULL);");
		
		maint_log_entry_begin("Creating table", "cr_messages");
		maint_log_entry_end();
	}
	function insert_cr_messages($message_sender, $message_receiver, $message_subject, $message_content, $message_timestamp = null, $message_status = true)
	{
		mysql_query("INSERT INTO cr_messages (message_sender, message_receiver, message_subject, message_content, message_timestamp, message_status) VALUES (" .
		"'" . mysql_real_escape_string($message_sender) . "', " .
		"'" . mysql_real_escape_string($message_receiver) . "', " .
		"'" . mysql_real_escape_string($message_subject) . "', " .
		"'" . mysql_real_escape_string($message_content) . "', " .
		($message_timestamp == null ? "NULL" : "'" . mysql_real_escape_string($message_timestamp) . "'") . ", " .
		($message_status ? "1" : "0") .
		");");
		
		maint_log_entry_begin("Populating table", "cr_messages");
		maint_log_entry_parameter("Sender", $message_sender);
		maint_log_entry_parameter("Receiver", $message_receiver);
		maint_log_entry_parameter("Subject", $message_subject);
		maint_log_entry_parameter("Content", $message_content);
		maint_log_entry_parameter("Timestamp", $message_timestamp);
		maint_log_entry_parameter("Status", $message_status);
		maint_log_entry_end();
	}
	
	function bounce_cr_message_attachments()
	{
		drop_table("cr_message_attachments");
		mysql_query("CREATE TABLE cr_message_attachments (attachment_id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, message_id INT NOT NULL, attachment_title VARCHAR(50) NOT NULL, attachment_url VARCHAR(200) NOT NULL);");
		
		maint_log_entry_begin("Creating table", "cr_message_attachments");
		maint_log_entry_end();
	}
	function insert_cr_message_attachments($message_id, $attachment_title, $attachment_url)
	{
		mysql_query("INSERT INTO cr_message_attachments (message_id, attachment_title, attachment_url) VALUES (" .
		$message_id . ", " .
		"'" . mysql_real_escape_string($attachment_title) . "', " .
		"'" . mysql_real_escape_string($attachment_url) . "'" .
		");");
		
		maint_log_entry_begin("Populating table", "cr_message_attachments");
		maint_log_entry_parameter("Message ID", $message_id);
		maint_log_entry_parameter("Title", $attachment_title);
		maint_log_entry_parameter("URL", "<a target=\"_blank\" href=\"" . $attachment_url . "\">" . $attachment_url . "</a>");
		maint_log_entry_end();
	}
	
	function bounce_cr_user_capabilities()
	{
		drop_table("cr_user_capabilities");
		mysql_query("CREATE TABLE cr_user_capabilities (user_id INT NOT NULL, capability_id INT NOT NULL);");
		
		maint_log_entry_begin("Creating table", "cr_user_capabilities");
		maint_log_entry_end();
	}
	function insert_cr_user_capabilities($user_id, $capability_id)
	{
		mysql_query("INSERT INTO cr_user_capabilities (user_id, capability_id) VALUES (" . $user_id . ", " . $capability_id . ")");
		
		maint_log_entry_begin("Populating table", "cr_user_capabilities");
		maint_log_entry_parameter("User ID", $user_id);
		maint_log_entry_parameter("Capability ID", $capability_id);
		maint_log_entry_end();
	}
	
	/// <summary>
	/// Drops and re-creates the cr_features table.
	/// </summary>
	function bounce_cr_features()
	{
		drop_table("cr_features");
		mysql_query("CREATE TABLE cr_features (feature_id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, feature_title VARCHAR(50), feature_description VARCHAR(1000));");
		
		maint_log_entry_begin("Creating table", "cr_features");
		maint_log_entry_end();
	}
	function insert_cr_features($feature_title, $feature_description = null)
	{
		mysql_query("INSERT INTO cr_features (feature_title, feature_description) VALUES (" .
			("\"" . mysql_real_escape_string($feature_title) . "\"") . ", " .
			($feature_description == null ? "NULL" : ("\"" . mysql_real_escape_string($feature_description) . "\"")) .
		");");
		
		maint_log_entry_begin("Populating table", "cr_features");
		maint_log_entry_parameter("Title", $feature_title);
		maint_log_entry_parameter("Description", $feature_description);
		maint_log_entry_end();
	}
	
	/// <summary>
	/// Drops and re-creates the cr_software_features table.
	/// </summary>
	function bounce_cr_software_features()
	{
		drop_table("cr_software_features");
		mysql_query("CREATE TABLE cr_software_features (software_id INT NOT NULL, feature_id INT NOT NULL, version_start VARCHAR(10), version_end VARCHAR(10), description VARCHAR(1000));");
		
		maint_log_entry_begin("Creating table", "cr_software_features");
		maint_log_entry_end();
	}
	
	/// <summary>
	/// Inserts the specified entry into the cr_software_features table.
	/// </summary>
	/// <param name="software_id">The ID number of the software.</param>
	/// <param name="feature_id">The ID number of the feature.</param>
	/// <param name="version_start">The version of the software when the feature was introduced, or null if not applicable.</param>
	/// <param name="version_end">The version of the software when the feature was discontinued, or null if not applicable.</param>
	/// <param name="description">Additional software-specific description of the feature beyond the original feature description.</param>
	function insert_cr_software_features($software_id, $feature_id, $version_start = null, $version_end = null, $description = null)
	{
		mysql_query("INSERT INTO cr_software_features (software_id, feature_id, version_start, version_end, description) VALUES (" .
			$software_id . ", " .
			$feature_id . ", " .
			($version_start == null ? "NULL" : ("\"" . mysql_real_escape_string($version_start) . "\"")) . ", " .
			($version_end == null ? "NULL" : ("\"" . mysql_real_escape_string($version_end) . "\"")) . ", " .
			($description == null ? "NULL" : ("\"" . mysql_real_escape_string($description) . "\"")) .
		");");
		
		maint_log_entry_begin("Populating table", "cr_software_features");
		maint_log_entry_parameter("Software ID", $software_id);
		maint_log_entry_parameter("Feature ID", $feature_id);
		maint_log_entry_parameter("Introducing version", $version_start);
		maint_log_entry_parameter("Deprecating version", $version_end);
		maint_log_entry_parameter("Description", $description);
		maint_log_entry_end();
	}
	
	// insert_cr_messages(1, 4, "This is a test message", "<p>Hey, what do you think? It's not much, but at least it works with no bugs!</p><p>Later you will have the ability to reply to messages, and send other people messages, all through the database. Perhaps with the added functionality of being notified by e-mail when you receive messages or replies!</p>", "20120723");
	// return;
	
	if ($UserInfo->ID != 1)
	{
		maint_log_entry_begin_failure("The operation failed because ", "you are not logged in");
		echo("<p>Please log into the system before performing this action.  You must have root permission to perform this action.</p>");
		maint_log_entry_end();
		return;
	}
	
	echo("<table style=\"width: 100%\" id=\"progressIndicator\"><tr><td style=\"width: 32px;\"><img src=\"/images/maint.gif\" /></td><td>Please wait while the operations are being executed</td></tr></table>");
	
	mysql_connect($mysql_host, $mysql_user, $mysql_password);
	mysql_select_db($mysql_database);
	
	maint_log_entry_begin("Connecting to database");
	maint_log_entry_parameter("Host name", $mysql_host);
	maint_log_entry_parameter("User name", $mysql_user);
	maint_log_entry_parameter("Password", $mysql_password);
	maint_log_entry_parameter("Database", $mysql_database);
	maint_log_entry_end();
	
	// ****************** BEGIN:	SONGS	****************** //
	bounce_cr_songs();
	
	// Songs used in PolyMo
	insert_cr_songs("Mikulantica");
	insert_cr_songs("Astro");
	insert_cr_songs("White Letter");
	insert_cr_songs("Rain of Lamentation");
	insert_cr_songs("White and Black");
	insert_cr_songs("Toosenbō");
	insert_cr_songs("Monochrome∞Blue Sky");
	insert_cr_songs("Happy Synthesizer");
	insert_cr_songs("Double Lariat");
	insert_cr_songs("Sing for the Moment");
	insert_cr_songs("Toeto");
	insert_cr_songs("Blue Dream");
	insert_cr_songs("MIDI Master");
	insert_cr_songs("Normalize");
	insert_cr_songs("The Cursed Glasses");
	insert_cr_songs("Paradichlorobenzene");
	insert_cr_songs("Antichlorobenzene");
	insert_cr_songs("I Like You, I Love You");
	insert_cr_songs("Discotheque★Love");
	insert_cr_songs("Summer Idol");
	insert_cr_songs("Po Pi Po");
	insert_cr_songs("Cute Cute Cat");
	insert_cr_songs("Fukkireta");
	insert_cr_songs("Do You Koto Na No?");
	insert_cr_songs("World Is Mine");
	insert_cr_songs("1925");
	insert_cr_songs("Sweet's Beast");
	insert_cr_songs("Cantarella");
	insert_cr_songs("Hikyō Sentai Urotandā");
	insert_cr_songs("Tautology");
	insert_cr_songs("Millenia");
	insert_cr_songs("Aurora");
	insert_cr_songs("MELT");
	insert_cr_songs("Cipher");
	insert_cr_songs("Yūhi-zaka");
	insert_cr_songs("Odds &amp; Ends");
	insert_cr_songs("Last Night, Good Night");
	
	// Other songs
	insert_cr_songs("Hajimete no Oto");
	insert_cr_songs("Project DIVA desu.");
	insert_cr_songs("World Is Mine");
	insert_cr_songs("Sound");
	insert_cr_songs("The Secret Garden");
	insert_cr_songs("Stargazer");
	insert_cr_songs("Ai Kotoba");
	
	// ****************** BEGIN:	PERFORMERS	****************** //
	bounce_cr_performers();
	// Crypton Future Media performers
	insert_cr_performers("Miku", "Hatsune", "#00DCFF", "#00CCCC");
	insert_cr_performers("Len", "Kagamine", "#E6FF00", "#FFFF99");
	insert_cr_performers("Rin", "Kagamine", "#E6FF00", "#FFFF99");
	insert_cr_performers("Luka", "Megurine", "#FF3366", "#FF8080");
	insert_cr_performers("KAITO", NULL, "#0047FF", "#0066CC");
	insert_cr_performers("MEIKO", NULL, NULL, NULL);
	insert_cr_performers("GUMI", NULL, "#33FF66", "#80FF80");
	
	bounce_cr_song_performers();
	insert_cr_song_performers(1, 1);
	insert_cr_song_performers(2, 1);
	insert_cr_song_performers(3, 1);
	insert_cr_song_performers(4, 1);
	insert_cr_song_performers(5, 1);
	insert_cr_song_performers(6, 1);
	
	// insert_cr_song_performers(7, 7);
	insert_cr_song_performers(7, 1);
	// insert_cr_song_performers(8, 7);
	insert_cr_song_performers(8, 4);
	
	insert_cr_song_performers(9, 4);
	insert_cr_song_performers(10, 4);
	insert_cr_song_performers(11, 4);
	insert_cr_song_performers(12, 4);
	insert_cr_song_performers(13, 2);
	insert_cr_song_performers(13, 3);
	insert_cr_song_performers(14, 3);
	insert_cr_song_performers(15, 3);
	insert_cr_song_performers(16, 2);
	insert_cr_song_performers(17, 3);
	insert_cr_song_performers(18, 2);
	insert_cr_song_performers(19, 2);
	insert_cr_song_performers(20, 3);
	insert_cr_song_performers(20, 1);
	insert_cr_song_performers(21, 1);
	insert_cr_song_performers(22, 1);
	insert_cr_song_performers(23, 1);
	insert_cr_song_performers(24, 1);
	insert_cr_song_performers(25, 1);
	insert_cr_song_performers(26, 1);
	insert_cr_song_performers(27, 5);
	insert_cr_song_performers(28, 5);
	insert_cr_song_performers(28, 1);
	insert_cr_song_performers(29, 5);
	insert_cr_song_performers(29, 1);
	
	insert_cr_song_performers(30, 1);
	insert_cr_song_performers(31, 1);
	insert_cr_song_performers(32, 1);
	insert_cr_song_performers(33, 1);
	insert_cr_song_performers(34, 1);
	insert_cr_song_performers(35, 1);
	insert_cr_song_performers(36, 1);
	insert_cr_song_performers(37, 1);
	
	// ****************** BEGIN:	ORGANIZERS	****************** //
	bounce_cr_organizers();
	insert_cr_organizers("Crypton Future Media", "http://www.crypton.co.jp");
	insert_cr_organizers("SEGA", "http://www.sega.com/");
	insert_cr_organizers("5pb.", "http://5pb.jp/");
	insert_cr_organizers("MAGES", "");
	
	insert_cr_organizers("AniMiku", "http://www.animiku.net/");
	insert_cr_organizers("Vocalekt Visions", "http://www.vocalektvisions.com/");
	insert_cr_organizers("NicoNicoDouga", "http://www.nicovideo.jp/");
	insert_cr_organizers("Miku-UK", "http://www.miku-uk.com/");
	insert_cr_organizers("ALCEproject", "http://www.alceproject.net/");



	// ****************** BEGIN:	LOCATIONS	****************** //
	bounce_cr_locations();
	insert_cr_locations(null, "Hampton", "Virginia", "United States of America");




	
	
	
	
	
	
	
	// ****************** BEGIN:	SOFTWARE	****************** //
	bounce_cr_software();
	insert_cr_software('mikudance', 'MikuMikuDance', 'Yu Higuchi', 'http://www.geocities.jp/higuchuu4/index_e.htm', 'Simple and easy-to-use 3D animation software for animating pre-made models.');
	insert_cr_software('mikumoving', 'MikuMikuMoving', 'Mogg', 'https://sites.google.com/site/moggproject/mmm', '3D animation software compatible with the community standard MikuMikuDance model, motion, and pose formats.');
	insert_cr_software('animiku', 'AniMiku', 'Re:VB-P', 'http://www.animiku.net/', 'The first live rendering concert animation software ever released, based on the MMDAgent codebase.');
	insert_cr_software('concertroid', 'Concertroid!', 'ALCEXHIM', 'http://www.alceproject.net/', 'An attempt to make a fully-free-software virtual concert live animation and management system.');
	
	bounce_cr_features();
	insert_cr_features("Playlist Editor", "Allows you to pre-arrange songs in a playlist and play them back in sequence during showtime.");
	insert_cr_features("Multiple Characters", "Display and separately configure more than one animated character on the screen at a time.");
	insert_cr_features("Character Positioning", "Control the position of the character in 3D space.");
	insert_cr_features("Local Remote Control", "Play, pause, and stop the show, switch characters, and receive feedback via a control panel on a separate window.");
	insert_cr_features("Network Remote Control", "Control the show via a control panel on another computer over the Internet or a local network.");
	insert_cr_features("Character Transitions", "Transition between the current character and the next character while playing a short transition animation.");
	insert_cr_features("Load and Save Set List", "Save your entire set list to disk and load it in at a later time.");
	insert_cr_features("Load and Save Individual Song", "Save the configuration for a certain song to a separate file.");
	insert_cr_features("Polygon Movie Maker Compatibility", "Supports Polygon Movie Maker model (PMD), pose (VPD), and motion (VMD) data, as well as Microsoft Waveform Audio (WAV) sound format for playback.");
	insert_cr_features("Universal Editor Compatibility", "Support any model, pose, motion, or sound file format via Universal Editor plugins.");
	insert_cr_features("Bullet Physics Engine Compatibility", "Physics for the animation are provided by the Bullet Physics engine used in Polygon Movie Maker.");
	insert_cr_features("Live Model Switching", "Swap out the current model for the next model without missing a beat, while the current song and motion are playing.");
	insert_cr_features("OpenGL Rendering", "Uses the OpenGL rendering subsystem to display the graphics.");
	insert_cr_features("Direct3D Rendering", "Uses the Direct3D rendering subsystem to display the graphics.");
	insert_cr_features("Windows Compatibility", "The software runs on Microsoft&reg; Windows&trade;.");
	insert_cr_features("Linux Compatibility", "The software runs on Linux.");
	insert_cr_features("Mac OS X Compatibility", "The software runs on Mac OS X.");
	
	bounce_cr_software_features();
	insert_cr_software_features(1, 2, "7.39e");
	insert_cr_software_features(1, 3);
	insert_cr_software_features(1, 8);
	insert_cr_software_features(1, 9);
	insert_cr_software_features(1, 11);
	insert_cr_software_features(1, 14);
	insert_cr_software_features(1, 15);
	
	insert_cr_software_features(2, 1, "3.0");
	insert_cr_software_features(2, 2, "3.0");
	insert_cr_software_features(2, 3);
	insert_cr_software_features(2, 4);
	insert_cr_software_features(2, 7);
	insert_cr_software_features(2, 8);
	insert_cr_software_features(2, 9);
	insert_cr_software_features(2, 11);
	insert_cr_software_features(2, 12);
	insert_cr_software_features(2, 14);
	insert_cr_software_features(2, 15);
	
	insert_cr_software_features(3, 1);
	insert_cr_software_features(3, 2);
	insert_cr_software_features(3, 3);
	insert_cr_software_features(3, 4);
	insert_cr_software_features(3, 5);
	insert_cr_software_features(3, 6);
	insert_cr_software_features(3, 7);
	insert_cr_software_features(3, 8);
	insert_cr_software_features(3, 9);
	insert_cr_software_features(3, 10);
	insert_cr_software_features(3, 11);
	insert_cr_software_features(3, 12);
	insert_cr_software_features(3, 13);
	insert_cr_software_features(3, 15);
	insert_cr_software_features(3, 16);
	insert_cr_software_features(3, 17);
	
	bounce_cr_software_releases();
	
	// Releases for MikuMikuDance
	insert_cr_software_releases(1, "1.39e", "Tool for choreography of 3D Miku Model. (It is possible to output AVI file by this tool.) English version.", "20111025", "http://www.geocities.jp/higuchuu4/pict/MikuMikuDance_e.zip", "Windows");
	insert_cr_software_releases(1, "5.24e", "This edition can move two or more models, and can be moved by <a href=\"http://www.bulletphysics.com/wordpress/\">bullet physical engine</a>. English version.", "20111025", "http://www.geocities.jp/higuchuu4/pict/MikuMikuDanceE_v524.zip", "Windows");
	insert_cr_software_releases(1, "7.39e", "This ver. is programed by DirectX9 for recent PC. (<a href=\"http://www.nvidia.com/object/3d-vision-main.html\">NVIDIA 3D Vision</a> can use, if you have.) English version.", "20111025", "http://www.geocities.jp/higuchuu4/pict/MikuMikuDanceE_v739dot.zip", "Windows");
	// Releases for AniMiku
	insert_cr_software_releases(2, "1.13RTC", "This is the community version of the AniMiku software. It is a very stripped-down version of AniMiku Exhibition, only contains the ability to play 1 animation and sound at a time, and is not as stable as Exhibition. This version does not allow exhibition or event use.", "2011", "http://www.animiku.net/cms/download-animiku/", "Windows");
	insert_cr_software_releases(2, "3.0", "This is the full version of AniMiku. It contains many more features than AniMiku Non-Exhibition, and is aimed toward use in an event or concert. AniMiku Exhibition requires activation to use, but remains free-of-charge for non-commercial usage. This version contains many stability and performance improvements from the previous versions, and many bugfixes. It also includes a brand-new sound engine implementation, replacing one that prevented the software from being used commercially.", "20120104", "http://www.animiku.net/cms/blog-2/version-3-0-has-been-released/", "Windows");
	insert_cr_software_releases(2, "3.0.1", "This version contains a new set of bugfixes and updates.", "20120130", "http://www.animiku.net/cms/blog-2/animiku-version-3-0-1-released/", "Windows");
	insert_cr_software_releases(2, "3.0.2", "Fixes the issue where the program would skip over a chapter sometimes when the &quot;Reload Models...&quot; checkbox in the player window was not checked.", "20120305", "http://www.animiku.net/cms/blog-2/animiku-version-3-0-2-released/", "Windows");
	insert_cr_software_releases(2, "3.1", "There have been some major improvements to the transition engine as well as the overall program to improve performance.", "20120602", "http://www.animiku.net/cms/blog-2/animiku-version-3-1-released/", "Windows");
	insert_cr_software_releases(2, "3.1.1", "Fixes a huge issue (pointed out by <a href=\"/d/1\">ALCEXHIM</a>) with amss, the sound engine, where it would eat up all the resources of the processor core it's using, even when it's not doing anything. This caused sound sync issues, where if you were on a lower-end system the audio had lag time (this is what happened at Vocalekt Visions's show at AnimeLA). Also introduces a new save file format structure.", "20120612", "http://www.animiku.net/cms/blog-2/animiku-version-3-1-1-quickrelease/", "Windows");
	// Releases for Concertroid!
	// insert_cr_software_releases(3, "0.1a", "Initial alpha release for the community to test.", "20120722", "http://fetch.alceproject.net/files/CREngine-0.6a-201206061153.zip", null);
	
	
	// ****************** BEGIN:	EVENTS		****************** //
	bounce_cr_events();
	/*
	insert_cr_events("mikufes", "MikuFES 2009", "http://miku.sega.jp/39", "First official VOCALOID concert featuring CV01 Hatsune Miku", "", "2009-03-09 19:00:00", "2009-03-09 20:00:00", "2009-03-09 22:00:00", false);
	insert_cr_events("39s2010", "39's Giving Day 2010", "http://miku.sega.jp/39", "Second official VOCALOID concert featuring all four Crypton Future Media Character VOCALOID", "", "2010-03-09 19:00:00", "2010-03-09 20:00:00", "2010-03-09 22:00:00", false);
	insert_cr_events("mkp2011", "MikuPa 2011 in Tokyo", "http://miku.sega.jp/39", "Third official VOCALOID concert featuring all four Crypton Future Media Character VOCALOID", "", "2011-03-09 19:00:00", "2011-03-09 20:00:00", "2011-03-09 22:00:00", false);
	insert_cr_events("39s2011", "Mikunopolis in Los Angeles", "http://miku.sega.jp/39", "Re-imagining of the 2010 concert with a slightly altered set list", "", "2011-08-01 19:00:00", "2011-08-01 20:00:00", "2011-08-01 22:00:00", false);
	insert_cr_events("mkpsapporo", "MikuPa 2011 in Sapporo", "http://miku.sega.jp/39", "Re-imagining of the 2011 concert with a slightly altered set list", "", "2011", false);
	insert_cr_events("mkpsingapore", "MikuPa 2011 in Singapore", "http://miku.sega.jp/39", "Building on the 2011 Sapporo concert with a slightly altered set list", "", "2011", false);
	insert_cr_events("mkp2012", "MikuPa 2012 in Tokyo", "http://miku.sega.jp/39", "Presenting songs from 2011 Singapore for the first time in Tokyo", "", "2012-03-08", false);
	insert_cr_events("39s2012", "Many 39's Giving Day 2012", "http://miku.sega.jp/39", "Presenting songs from 2011 Mikunopolis for the first time in Tokyo", "", "2012-03-09", false);
	insert_cr_events("amlive", "AniMiku Live 2011", "http://www.animiku.net", "A demonstration of Re:VB-P's AniMiku software. Live event (no band).", "", "2011");
	insert_cr_events("vvpmx", "Vocalekt Visions 2012 at Pacific Media Expo", "http://www.vocalektvisions.com/", "A live event (no band) featuring Vocalekt Visions music and the AniMiku software.", "", "2012");
	insert_cr_events("vvala", "Vocalekt Visions 2012 at Anime LA", "http://www.vocalektvisions.com/", "A live event (no band) featuring Vocalekt Visions music and the AniMiku software.", "", "2012");
	insert_cr_events("amtoracon", "AniMiku 2012 at RIT Toracon", "http://www.animiku.net/", "Demonstration of Re:VB-P's AniMiku software using music from Vocalekt Visions and other VOCALOID producers. Live event (no band).", "", "2012");
	insert_cr_events("niconico", "NicoNico 2012 Live Concert", "http://www.nicovideo.jp/", "A concert produced using the MikuMikuDance engine and featuring VOCALOID and UTAU singers.", "", "2012");
	insert_cr_events("vocafarre", "Vocafarre 2011", "Vocafarre", "A live event featuring augmented reality special effects. No projected singers.", "", "2011");
	
	*/
	
	// banner image and small image taken out of the database
	// the system should already know how to get these images
	// - use "/events/youreventname/images/small" and "/events/youreventname/images/banner"
	//   to retrieve these images
	insert_cr_events("nekocon", "AniMiku Live at NekoCon!", "http://www.animiku.net/", "Re: VB brings his famous AniMiku animation system to NekoCon in Virginia for VocaNoIro... a must-see event!",
	
	"This is a series of events taking place November 2-4. The name is short for &quot;Vocaloid no Iro&quot; or &quot;Colors of Vocaloid&quot;. Events include the AniMiku-powered virtual singer performance, as well as two panels featuring Western producers Tempo-P of <a href=\"http://www.vocalektvisions.com/\">Vocalekt Visions</a> and Empath-P (<a href=\"http://empathp.bandcamp.com/\">Aki Glancy</a>).</p>" .
	"<p>The concert itself just might be the most impressive AniMiku one to date and is said to feature a real stage, opening up options for lighting, rigging, and getting the best hologram effects possible. The setlist also has many new additions, along with new Vocaloids, one never before seen, and another that has only been on stage on one other occasion.</p>" .
	"<p>Seating capacity for the main event has also been increased, but space is limited so it is probably best to arrive early as a full house is expected. Free commemorative glow-sticks will be given out to the first 1,000 people in the door. VocaNoIro will also have a booth in the dealer’s hall selling the latest Vocalekt Visions album, as well as answering any questions you may have concerning the technology powering this event.</p>", null, "2012-11-01 09:00", "2012-11-01 10:00", "2012-11-01 11:00", 1);
	insert_cr_events("miktober", "Miktoberfest", "http://www.animiku.net/", "Using MikuMikuDance, Hatsune Miku and other VOCALOID perform live for the Mikutoberfest!", "", null, "2012-10-24", "2012-10-24", "2012-10-24");
	insert_cr_events("polymo", "PolyMo Live! Fanmade Virtual Singer Concert", "http://www.alceproject.net/", "ALCEproject presents the Concertroid! Virtual Entertainment system for a venue near you!", "", "http://www.ustream.tv/channel/polymolive/", "2013-03-09", "2013-03-09", "2013-03-09");
	
	
	// ****************** BEGIN:	EVENT SONGS	****************** //
	bounce_cr_event_songs();
	insert_cr_event_songs(3, 1);			// Mikulantica
	insert_cr_event_songs(3, 2);			// Astro
	insert_cr_event_songs(3, 3);			// White Letter
	// insert_cr_event_songs(3, 4);			// Rain of Lamentation
	// insert_cr_event_songs(3, 5);			// White and Black
	insert_cr_event_songs(3, 6);			// Toosenbo
	insert_cr_event_songs(3, 7);			// Monochrome Blue Sky
	insert_cr_event_songs(3, 8);			// Happy Synthesizer
	insert_cr_event_songs(3, 9);			// Double Lariat
	insert_cr_event_songs(3, 10);			// Sing for the Moment
	insert_cr_event_songs(3, 11);			// Toeto
	insert_cr_event_songs(3, 12);			// Blue Dream
	insert_cr_event_songs(3, 13);			// MIDI Master
	insert_cr_event_songs(3, 14);			// Normalize
	insert_cr_event_songs(3, 15);			// The Cursed Glasses
	insert_cr_event_songs(3, 16);			// Paradichlorobenzene
	insert_cr_event_songs(3, 17);			// Antichlorobenzene
	insert_cr_event_songs(3, 18);			// I Like You, I Love You
	insert_cr_event_songs(3, 19);			// Discotheque Love
	// insert_cr_event_songs(3, 20);			// Summer Idol
	insert_cr_event_songs(3, 21);			// Po Pi Po
	insert_cr_event_songs(3, 22);			// Cute Cute Cat
	insert_cr_event_songs(3, 23);			// Fukkireta
	insert_cr_event_songs(3, 24);			// Do You Koto Na No
	// insert_cr_event_songs(3, 25);			// World is Mine
	insert_cr_event_songs(3, 26);			// 1925
	insert_cr_event_songs(3, 27);			// Sweet's Beast
	insert_cr_event_songs(3, 28);			// Cantarella
	insert_cr_event_songs(3, 29);			// Hikyo Sentai Urotanda
	insert_cr_event_songs(3, 30);			// Tautology
	insert_cr_event_songs(3, 31);			// Millenia
	insert_cr_event_songs(3, 32);			// Aurora
	insert_cr_event_songs(3, 33);			// MELT
	insert_cr_event_songs(3, 34);			// Cipher
	insert_cr_event_songs(3, 35);			// Yuhi zaka
	insert_cr_event_songs(3, 36);			// Odds & Ends
	insert_cr_event_songs(3, 37);			// Last Night, Good Night
	
	// ****************** BEGIN:	EVENT ORGANIZERS	****************** //
	bounce_cr_event_organizers();
	
	// Events: 		0 = MikuFES 2009, 1 = 39s day, 2 = Mikupa 2011 Tokyo, 3 = Mikunopolis, 4 = Mikupa 2011 Sapporo, 5 = Mikupa 2011 Singapore, 6 = Mikupa 2012 Tokyo, 7 = 39s 2012
	// Organizers:	0 = Crypton, 1 = SEGA, 2 = 5pb., 3 = MAGES, 4 = AniMiku, 5 = Vocalekt Visions, 6 = NicoNicoDouga, 7 = Miku-UK, 8 = ALCEproject
	// insert_cr_event_organizers(event_id, organizer_id )
	
	insert_cr_event_organizers(1, 5);
	insert_cr_event_organizers(1, 6);
	
	// ****************** BEGIN:	MEMBERS				****************** //
	if ($_GET["bounce_cr_users"] == "1")
	{
		bounce_cr_users();
		insert_cr_users("alcekuro1041", "Solty/AyanamiREI^^96274", "alcexhim", "Michael Becker", "alcexhim@gmail.com");
		insert_cr_users("akidark20", "hamster20", "Yuki Chan", "Carina Nicholas", "carina.nicholas20@gmail.com", false, true, null, "B8cCohLfjj3y4HhUKWEzVyb3wDfZTe32");
	}
	else
	{
		maint_log_entry_begin_skipped("Skipping table", "cr_users");
		maint_log_entry_end();
	}
	
	bounce_cr_permissions();
	insert_cr_permissions("Login");
	
	bounce_cr_user_permissions();
	insert_cr_user_permissions(1, 1);
	
	bounce_cr_capabilities();
	insert_cr_capabilities("Artwork");
	insert_cr_capabilities("Software Development");
	insert_cr_capabilities("Web Development");
	insert_cr_capabilities("Modeling");
	insert_cr_capabilities("Animation");
	insert_cr_capabilities("Hardware Configuration");
	insert_cr_capabilities("Electronics");
	insert_cr_capabilities("Music");
	insert_cr_capabilities("Concert Coordination");
	
	bounce_cr_user_capabilities();
	insert_cr_user_capabilities(1, 2);
	insert_cr_user_capabilities(1, 3);
	insert_cr_user_capabilities(1, 8);
	insert_cr_user_capabilities(1, 9);
	
	bounce_cr_partners();
	// insert_cr_partners("animiku", "AniMiku", "http://www.animiku.net/");
	// insert_cr_partners("vocalekt", "Vocalekt Visions", "http://www.vocalektvisions.com/");
	insert_cr_partners("projectvfe", "Project VOCALOID for Everyone", "http://projectvfe.site50.net/");
	
	// bounce_cr_messages();
	// insert_cr_messages(1, 1, "Welcome to Concertroid!", "This is a welcome e-mail.", "20120720");
	// insert_cr_messages(2, 1, "Membership Request", "<p>This person would like to become a member.</p><table><tr><td>Full name:</td><td>Carina Nicholas</td></tr><tr><td>Comments:</td><td>Please authorize me!</td></tr></table><p><a href=\"/register.php?approve=B8cCohLfjj3y4HhUKWEzVyb3wDfZTe32\">Approve</a> or <a href=\"/register.php?reject=B8cCohLfjj3y4HhUKWEzVyb3wDfZTe32\">reject</a> the request.</p>", "20120723");
	
	echo("<script type=\"text/javascript\">document.getElementById('progressIndicator').style.display = 'none';</script>");
	
	page_end();
?>