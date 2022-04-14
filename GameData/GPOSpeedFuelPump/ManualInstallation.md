---
permalink: /ManualInstallation.html
title: ManualInstallation
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
# layout: bare
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,Lisias,zedK
---

<!-- ManualInstallation.md v1.1.5.0
GPOSpeedFuelPump (GPO)
created: 01 Oct 2019
updated: 11 Apr 2022 -->

<!-- based upon work by Lisias -->

# GPOSpeedFuelPump (GPO)

[Home](./index.md)

Allows you to automatically transfer or balance fuel.

## Installation Instructions

### Using CurseForge/OverWolf app or CKAN

You should be all good! (check for latest version on CurseForge)

### If Downloaded from CurseForge/OverWolf manual download

To install, place the GPOSpeedFuelPump folder inside your Kerbal Space Program's GameData folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
  * Delete `<KSP_ROOT>/GameData/GPOSpeedFuelPump`
* Extract the package's `GPOSpeedFuelPump/` folder into your KSP's GameData folder as follows:
  * `<PACKAGE>/GPOSpeedFuelPump` --> `<KSP_ROOT>/GameData/GPOSpeedFuelPump`
    * Overwrite any preexisting folder/file(s).

### If Downloaded from SpaceDock / GitHub / other

To install, place the GameData folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
  * Delete `<KSP_ROOT>/GameData/GPOSpeedFuelPump`
* Extract the package's `GameData/GPOSpeedFuelPump` folder into your KSP's root folder as follows:
  * `<PACKAGE>/GameData/GPOSpeedFuelPump` --> `<KSP_ROOT>/GameData`
    * Overwrite any preexisting file.

## The following file layout must be present after installation

```markdown
<KSP_ROOT>
  + [PluginData]
    + [GPOSpeedFuelPump]
      ...
    ...
  + [GameData]
    + GPOSpeedFuelPump]
      + [Localization]
        ...
      + [Plugins]
        * [GPOSpeedFuelPump.dll]
        ...
      * #.#.#.#.htm
      * changelog.md
      * License.txt
      * readme.htm
      * GPOSpeedFuelPump.version
    ...
    * 000_KSPe.dll
    * ModuleManager.dll
  * KSP.log
  ...
```

### Dependencies

* [Module Manager /L][mm]
* [KSPAPIExtensions][kspe]

[kspe]: https://github.com/net-lisias-ksp/KSPAPIExtensions "KSPAPIExtensions"
[mm]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"
