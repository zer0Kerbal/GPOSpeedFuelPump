# Goodspeed Automatic Fuel Pump /L Unleashed :: Change Log

* 2016-0303: 1.6 (hab136) for KSP 16
	+ Add exception handling
	+ Fix some MM configs (particularly the Interstellar fuel switch)
* 2016-0124: 1.5 (hab136) for KSP 16
	+ Respect resource lock
	+ Don't operate on NO_FLOW resources.
	+ Break up config file, add support for CRP resources, fuel switch, procedural tanks
	+ Updated to 16 pump levels (my game already had this, but source code had 8?)
* 2015-????: 2.14.1 (Gaius) for KSP 0.23.5
	+ Fixed (hopefully) compatibility issue with Modular Fuels/Real Fuels, or other mods that modify which resources a tank contains after loading, and added a sanity check to prevent pumping of antifuel in impossible circumstances that apparently occasionally happen anyway.
* 2014-????: 1.29.1 (Gaius) for KSP 0.23.5
	+ Added ability to selectively disable pumping or balancing of one or more resources on parts that have multiple kinds of resources in them, either from the options window or in the config files.
* 2014-????: 1.24.1 (Gaius) for KSP 0.23.5
	+ First public release.
