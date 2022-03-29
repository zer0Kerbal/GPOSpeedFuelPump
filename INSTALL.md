# Goodspeed Automatic Fuel Pump /L Unleashed

Allows you to automatically transfer or balance fuel.

[Unleashed](https://ksp.lisias.net/add-ons-unleashed/) fork by Lisias.


## Installation Instructions

To install, place the GameData folder inside your Kerbal Space Program folder. Optionally, you can also do the same for the PluginData (be careful to do not overwrite your custom settings):

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
	+ Delete `<KSP_ROOT>/GameData/net.lisias.ksp/GPOSpeedPump`
	+ Delete `<KSP_ROOT>/GameData/GPOSpeedPump`
* Extract the package's `GameData` folder into your KSP's root:
	+ `<PACKAGE>/GameData/*` --> `<KSP_ROOT>/GameData`
* Extract the package's `PluginData` folder (if available) into your KSP's root, taking precautions to do not overwrite your custom settings if this is not what you want to.
	+ `<PACKAGE>/PluginData/*` --> `<KSP_ROOT>/PluginData`
	+ You can safely ignore this step if you already had installed it previously and didn't deleted your custom configurable files.

The following file layout must be present after installation:

```
<KSP_ROOT>
	[GameData]
		[net.lisias.ksp]
			[GPOSpeedPump]
				...
				CHANGE_LOG.md
				LICENSE
				NOTICE
				README.md
				GPOSpeedPump.dll
				GPOSpeedPump
		000_KSPe.dll
		ModuleManager.dll
		...
	[PluginData]
		[net.lisias.ksp]
			[GPOSpeedPump]
				...
	KSP.log
	PartDatabase.cfg
	...
```


### Dependencies

* [KSP API Extensions/L](https://github.com/net-lisias-ksp/KSPAPIExtensions)
	+ Not Included
* [Module Manager](https://github.com/sarnet-lisias-kspu/ModuleManager)
	+ Not Included
