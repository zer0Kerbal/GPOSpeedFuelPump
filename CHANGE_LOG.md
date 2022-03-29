# Goodspeed Automatic Fuel Pump /L Unleashed :: Change Log

* 2016-0502: 1.8.1 (hab136) for KSP 1.1.2
	+ Recompiled for KSP 1.1.2
	+ Added support for ModulerFuelTanks
	+ add super-everything config (disabled by default)
	+ change NEEDS to FOR in MM configs
* 2016-0420: 1.8 (hab136) for KSP 1.1
	+ Add resources for Station Science (Kibbal)
	+ Compile against KSP 1.1 release
* 2016-0401: 1.7 (hab136) for KSP 1.1 PRE-RELEASE
	+ Code updates for KSP 1.1
	+ Changed "Pump Options" window positioning because buttons are on left side of popup now
	+ Ensured "Pump Options" window doesn't go off-screen
	+ Fix MM config - extra whitespace, missing "HAS"
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
