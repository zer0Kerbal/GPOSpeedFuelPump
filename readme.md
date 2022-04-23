<!-- readme.md v1.6.6.2
GPOSpeedPump (GPO)
created: 01 Oct 2019
updated: 04 Apr 2022 -->

<!--this file: CC BY-ND 4.0 unported by zer0Kerbal -->

[![GPOSpeedPump (GPO)][MOD:shd:latest]][MOD:forum] [![KSP version][KSP:shd]][KSP:url]  [![License][LIC:shd]][LIC:url]  
[![Curseforge][CURSFG:shd]][CURSFG:url] [![CKAN][CKAN:shd]][CKAN:url] [![GitHub][GITHUB:shd]][GITHUB:url] [![SpaceDock][SPCDCK:shd]][SPCDCK:url]  
![Code][CODE:shd]

[![GitHub Pages][MOD:pages:shd]][MOD:pages]



# Goo Pumps & Oils' Speed Pump(GPO)

Allows you to automatically transfer or balance fuel.



## By [`Lisias`][lisias] and [`zer0Kerbal`][zer0Kerbal], previously by [`hab136`][hab136], then previously by [`Geordiepigeonowner`][geordiepigeonowner], and originally by [`Gaius`][gaius]  

<img src="https://github.com/zer0Kerbal/GPOSpeedPump/blob/master/img/HeroLogo_1920x1920.png?raw=true" alt="HeroLogo_1920x1920.png" style="zoom:25%;" />

## Description

Ever undock from your space station, only to realize you forgot to top off your fuel or RCS tanks? Want to have tanks that automatically pump fuel where it's needed, without having to bring up windows and manually move fuel around? Want to set up fuel balancing in the SPH or VAB as a "tweakable" and have it saved with your vessel? Simultaneously balance different groups of tanks on the same vessel independently of one-another? Just generally mess around with fuel routing, and have these settings persistent? Then **Goo Pumps & Oils** has the tool for you!

The **Goo Pumps & Oils'** *Speed Pump*, once installed in your fuel tanks, allows you to set up a "pump level" for each tank, either as a "tweakable" while building your vehicle, or while in flight. You can set tanks to automatically pump fuel to lower level tanks whenever possible, or balance between tanks at the same level. Uses include refuelling tanks at space stations that automatically top off the tanks of any vessels as soon as they dock with the station, refuelling vessels with higher level pumps that automatically refuel the space station as soon as they dock, setting up fuel balancing while building a plane and having it saved with the plane and done completely automatically in flight, setting up more complicated fuel flow patterns for asparagus-like situations without fuel lines for fuel types that don't normally flow that way (e.g. monopropellant and xenon gas), and many other uses!

Right-click a tank while in the assembly building, or while in flight. Set the pump level as desired, and turn on "Auto Pump" and/or "Balance". "Auto Pump" will automatically pump fuel from this tank to any lower level tanks (water flows downhill) when they have room. The "Balance" function will keep the percentage of fuel in this tank identical to any other tanks with the same pump level and "Balance" on. Note that this allows different sets of tanks to be balanced within their own set but independently of the other sets.

### Pictures, or it didn't happened!

The first pic shows a fuel station that automatically refuels any ship that docks with it. In this setup, the top two tanks remain left/right balanced while draining first, then the next two down, and so on, with the two on the bottom draining last. Why would you want to do this? Because... reasons.

![HERO-01][](https://i.imgur.com/2pChN3Q.png)

The second pic just shows that the pump settings appear in the assembly building as "tweakables" as well as in-flight. These settings are saved with your craft.

![HERO-01](https://i.imgur.com/JnfmO7C.png)

The third pic just shows the pumps keeping three tanks balanced in-flight.

![HERO-01](https://i.imgur.com/Bxmxd6d.png)

The fourth pic shows the "Pump Options" window that allows you to turn off the pumping of some resources while leaving it enabled for others.

![HERO-01](https://i.imgur.com/G1kAfqy.png)

### Help Wanted

> * Compatibility patches are always welcome  
> * Have a request? Glad to have them, kindly submit through [GitHub][MOD:issue].

---

### Localization

>* ![English][EN] English
>* ***your translation here***
>
> HELP WANTED - See the [README in the Localization folder][MOD:local] for instructions for adding or improving translations. [GitHub][GitHub:url] push is the best way to contribute. *Additions and corrections welcome!*

---

### See More

* Discussions and news on this mod: See [Discussions][MOD:discu] or [KSP Forums][MOD:forum]
* Changelog Summary for more details of changes : See [ChangeLog][MOD:chlog]
* Known Issues for more details of feature requests and known issues : See [Known Issues][MOD:issue]
* GitHub Pages : See [Pages][MOD:pages]

---

### Installation Directions

***Use***
  CurseForge/OverWolf App (currently does not install dependencies) [^1]  

  <a href="https://download.curseforge.com/">
    <img src="https://www.overwolf.com/brand-guidelines/img/logo2.svg" alt="CurseForge/OverWolf App" width="15%" height="15%">
</a>

or [![CKAN][CKAN:img]][CKAN:url] [^1]  

### Dependencies

* [Kerbal Space Program][KSP:url] [![Kerbal Space Program][KSP:shd]][KSP:url] [^2]
* either [Module Manager][mm] [^3]
  * [Module Manager]  
  or  
  * [Module Manager /L][mml] [^3]
  * with [KSPAPIExtensions][kspe]

### Supports

* [Community Resource Pack][crp]
* [Procedural Parts][pt]
* [SimpleConstruction! (SCON!)][SCON]
* [Station Science][ss]
* [The Gold Standard! (TGS)][TGS]]

#### Fuel Switchers

*alphabetically*

* [B9PartSwitch][b9ps]
* [Firespitter][fs]
* [Interstellar Fuel Switch][ifs]
* [Interstellar Fuel Switch Core][ifsc]
* [Modular Fuel Tanks][mft]
* [SimpleFuelSwitch][sfs]

<div style="border:0.5px solid #BADA55; background-color: #white; color: #FF0000; text-align:center">
<p><b>*red box below is a link to forum post on how to get support*</p>  
<a href = "https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*">
  <p><img src = "https://i.postimg.cc/vHP6zmrw/image.png" alt="How to get support"></p></a><small style="color: #BADA55"><i>Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date</i></small></div>

### Credits and Special Thanks

* [Gaius][gaius] for creating this glorious mod!
* [Geordiepigeonowner][geordiepigeonowner] for maintaining this mod after Gaius was kidnapped by Space Worms
* [hab136][hab136] for taking over after Geordiepigeonowner, who was also kidnapped by Space Worms
* see [Attribution.md][MOD:attr] for more comprehensive list

### Legal Mumbo Jumbo (License *provenance*)

#### Current (1) - [`zer0Kerbal`][zer0Kerbal]

> Forum: [Thread][MOD:forum] - Source: [GitHub][GITHUB:url]  
> License: [![License][LIC:shd]][LIC:url] ![License][LIC:log]
>
> ##### Disclaimer(s)
>
> ***All bundled mods are distributed under their own licenses***  
> ***All art assets (textures, models, animations, sounds) are distributed under their own licenses***

#### Previous (2) - Author: [`hab136`][hab136]

> Forum: [Thread][MOD:2:thread] - Download: [CurseForge][MOD:2:download] - Source: [GitHub][MOD:2:source]  
> [SpaceDock](http://spacedock.info/mod/546/GPOSpeedPump)
> License: [![License][LIC:2:shd]][LIC:2:url] ![License][LIC:2:log]

#### Previous (1) - Author: [`Geordiepigeonowner`][geordiepigeonowner]

> Forum: [Thread][MOD:1:thread] - Download: [KerbalStuff][MOD:1:download] - Source: [Wayback Machine][MOD:1:source]  
> License: [![License][LIC:1:shd]][LIC:1:url] ![License][LIC:1:log]

#### Original (ROOT) (0) - Author: [`Gaius`][gaius]

> Forum: [Thread][MOD:0:thread] - Download: [Dropbox][MOD:0:download] - Source: [Dropbox][MOD:0:source]  
> License: [![License][LIC:0:shd]][LIC:0:url] ![License][LIC:0:log]
> [Imgur](https://imgur.com/a/ilLes)

This work is licensed under the [![License][LIC:shd]][LIC:url] ![License][LIC:log].

* You are free to:
  * Use : unpack and use the material in any computer or device
  * Redistribute : redistribute the original package in any medium
  * Adapt : Reuse, modify or incorporate source code into your works (and redistribute it!)
* Under the following terms:
  * You retain any copyright notices
  * You recognise and respect any trademarks
  * You don't impersonate the authors, neither redistribute a derivative that could be misrepresented as theirs.
  * You credit the author and republish the copyright notices on your works where the code is used.
  * You relicense (and fully comply) your works using GPL 3.0
    * Please note that upgrading the license to any future license version  **IS NOT ALLOWED** for this work, as the author **DID NOT** added the "or (at your option) any later version" on the license
  * You don't mix your work with GPL incompatible works.

Please note the copyrights and trademarks in [NOTICE](MOD:notic).
<!-- mod links -->
[MOD:attr]: https://raw.githubusercontent.com/zer0Kerbal/GPOSpeedPump/master/Attribution.md "Attribution"

[MOD:chlog]: https://github.com/net-lisias-ksp/GPOSpeedPump/blob/master/CHANGE_LOG.md  "Changelog"
[MOD:discu]: https://github.com/net-lisias-ksp/GPOSpeedPump/discussions "Discussions"
[MOD:forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/207732-*/ "GPOSpeedPump Forum Thread"
[MOD:issue]: https://github.com/net-lisias-ksp/GPOSpeedPump/issues "GitHub Issues"
[MOD:licns]: https://github.com/net-lisias-ksp/GPOSpeedPump/blob/master/LICENSE "Github License"
[MOD:local]: https://github.com/net-lisias-ksp/GPOSpeedPump/blob/master/GameData/GPOSpeedPump/Localization/readme.md "Localization"
[MOD:pages]: https://net-lisias-ksp.github.io/GPOSpeedPump/ "GitHub Pages"
[MOD:notic]: https://net-lisias-ksp.github.io/GPOSpeedPump/Notices "Notices"

<!--- mod -->
[MOD:shd:latest]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/GPOSpeedPump/master/json/mod.json
[CODE:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/GPOSpeedPump/master/json/code.json

<!--- mod provenance -->
[MOD:0:source]: https://archive.org/details/Goodspeed-0.90 "Wayback Machine"
[MOD:0:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/60992-*/ "KSP Forum"
[MOD:0:download]: https://archive.org/details/Goodspeed-0.90 "Wayback Machine"

[MOD:1:source]: https://archive.org/details/Goodspeed-v1.8.16 "Wayback Machine"
[MOD:1:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/106448-*/ "KSP Forum"
[MOD:1:download]: https://web.archive.org/web/20151129192243/https://kerbalstuff.com/mod/722/GPOSpeedPump "KerbalStuff"

[MOD:2:source]: https://github.com/henrybauer/GPOSpeedPump "GitHub"
[MOD:2:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/64520-*/ "KSP Forum"
[MOD:2:download]: https://www.curseforge.com/kerbal/ksp-mods/GPOSpeedPump-continued "CurseForge"

<!--- license provenance-->
[LIC:0:url]: https://www.gnu.org/licenses/gpl-3.0-standalone.html "GPLv3"
[LIC:0:log]: https://i.postimg.cc/9FrwMgK6/GPL-17x17.png "GPLv3"
[LIC:0:shd]: https://img.shields.io/badge/License-GPLv3-A42E2B?style=plastic&labelColor=white&logoColor=A42E2B&logo=gnu "GPLv3"

[LIC:1:url]: https://www.gnu.org/licenses/gpl-3.0-standalone.html "GPLv3"
[LIC:1:log]: https://i.postimg.cc/9FrwMgK6/GPL-17x17.png "GPLv3"
[LIC:1:shd]: https://img.shields.io/badge/License-GPLv3-A42E2B?style=plastic&labelColor=white&logoColor=A42E2B&logo=gnu "GPLv3"

[LIC:2:url]: https://www.gnu.org/licenses/gpl-3.0-standalone.html "GPLv3"
[LIC:2:log]: https://i.postimg.cc/9FrwMgK6/GPL-17x17.png "GPLv3"
[LIC:2:shd]: https://img.shields.io/badge/License-GPLv3-A42E2B?style=plastic&labelColor=white&logoColor=A42E2B&logo=gnu "GPLv3"

[LIC:url]: https://www.gnu.org/licenses/gpl-3.0-standalone.html "GPLv3"
[LIC:log]: https://i.postimg.cc/9FrwMgK6/GPL-17x17.png "GPLv3"
[LIC:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/GPOSpeedPump/master/json/license.json "GPLv3"

<!--- CKAN -->
[CKAN:img]: https://i.postimg.cc/x8XSVg4R/sj507JC.png "CKAN"
[CKAN:url]: http://forum.kerbalspaceprogram.com/index.php?/topic/197082-*/ "CKAN"
[CKAN:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/GPOSpeedPump/master/json/ckan.json "CKAN"

<!--- release links -->
[CURSFG:url]: https://www.curseforge.com/kerbal/ksp-mods/GPOSpeedFuelPump "Curseforge"
[CURSFG:shd]: https://img.shields.io/badge/CurseForge-Link-CCFF00.svg?labelColor=6441A4&style=plastic&logo=curseforge "Curseforge"

[GITHUB:url]: https://github.com/zer0Kerbal/GPOSpeedFuelPump/ "GitHub"
[GITHUB:shd]: https://img.shields.io/badge/Github-Link-CCFF00.svg?labelColor=181717&style=plastic&logo=github "GitHub"

[SPCDCK:url]: http://spacedock.info/mod/546 "SpaceDock"
[SPCDCK:shd]: https://img.shields.io/badge/SpaceDock-Link-CCFF00.svg?labelColor=181717&style=plastic&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPgo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkxheWVyXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IgoJIHZpZXdCb3g9IjAgMCA1MDAgNTAwIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MDAgNTAwOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6IzFBMUExQTt9Cgkuc3Qxe2ZpbGw6IzA1Nzg5Mzt9Cgkuc3Qye2ZpbGw6IzA3QUNEMjt9Cjwvc3R5bGU+CjxwYXRoIGlkPSJYTUxJRF8xXyIgY2xhc3M9InN0MCIgZD0iTTQwMCwwLjZIMTAwYy01NSwwLTEwMCw0NS0xMDAsMTAwVjQwMGMwLDU1LDQ1LDEwMCwxMDAsMTAwaDMwMGM1NSwwLDEwMC00NSwxMDAtMTAwVjEwMC42CglDNTAwLDQ1LjYsNDU1LDAuNiw0MDAsMC42eiIvPgo8ZyBpZD0iWE1MSURfNl8iPgoJPGcgaWQ9IlhNTElEXzlfIj4KCQk8cGF0aCBpZD0iWE1MSURfMTdfIiBjbGFzcz0ic3QxIiBkPSJNMTgzLjMsMTY1LjljNi40LTMuNiwxNi45LTMuNiwyMy4zLDBMNDY3LjQsMzE0YzYuNCwzLjYsNi40LDkuNiwwLDEzLjJMMjA2LjYsNDc0LjQKCQkJYy02LjQsMy42LTE3LjcsNi42LTI1LDYuNmgtNDQuOGMtNy40LDAtOC4xLTMtMS43LTYuNmwyNjEtMTQ3LjJjNi40LTMuNiw2LjQtOS42LDAtMTMuMkwxNzEsMTg2Yy02LjQtMy42LTYuNC05LjYsMC0xMy4yCgkJCUwxODMuMywxNjUuOXoiLz4KCTwvZz4KCTxnIGlkPSJYTUxJRF84XyI+CgkJPHBhdGggaWQ9IlhNTElEXzE2XyIgY2xhc3M9InN0MiIgZD0iTTMxOC44LDE5Yy03LjQsMC0xOC42LDIuOC0yNSw2LjRMMzMsMTczLjRjLTYuNCwzLjYtNi40LDkuNSwwLDEzLjFsMjYwLjcsMTQ3LjEKCQkJYzYuNCwzLjYsMTYuOSwzLjYsMjMuMywwbDEyLjMtN2M2LjQtMy42LDYuNC05LjUsMC0xMy4ybC0yMjUuMS0xMjdjLTYuNC0zLjYtNi40LTkuNSwwLTEzLjJMMzY1LjYsMjUuNGM2LjQtMy42LDUuNi02LjQtMS43LTYuNAoJCQlIMzE4Ljh6Ii8+Cgk8L2c+CjwvZz4KPC9zdmc+Cg==  "SpaceDock"

<!-- Kerbal Space Program -->
[KSP:url]: https://kerbalspaceprogram.com/ "Kerbal Space Program"
[KSP:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/GPOSpeedPump/master/json/ksp.json&logo=data:image/webp;base64,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 "Kerbal Space Program"

<!-- links to add-ons/mods -->  

[mm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"
[mml]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"
[kspe]: https://github.com/net-lisias-ksp/KSPAPIExtensions "KSPAPIExtensions"

[twk]: https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*/ "TweakScale"
[ckan]: https://forum.kerbalspaceprogram.com/index.php?/topic/154922-*/ "CKAN"

[b9ps]: http://forum.kerbalspaceprogram.com/index.php?showtopic=140541 "B9PartSwitch"
[fs]: https://github.com/snjo/Firespitter "Firespitter"
[ifs]: http://forum.kerbalspaceprogram.com/index.php?/topic/106243-*/ "Interstellar Fuel Switch"
[ifsc]: http://forum.kerbalspaceprogram.com/index.php?/topic/106243-*/ "Interstellar Fuel Switch Core"
[mft]: http://forum.kerbalspaceprogram.com/index.php?/topic/58235-*/ "Modular Fuel Tanks"
[sfs]: https://forum.kerbalspaceprogram.com/index.php?/topic/181274-*/ "SimpleFuelSwitch"

[crp]: http://umbraspaceindustries.github.io/UmbraSpaceIndustries/ "Community Resource Pack"
[pt]: https://forum.kerbalspaceprogram.com/index.php?/topic/96402-*/ "Procedural Parts"
[ss]: http://forum.kerbalspaceprogram.com/index.php?/topic/50145-*/ "Station Science"

[SCON]: https://forum.kerbalspaceprogram.com/index.php?/topic/191424-*/ "SimpleConstruction! (SCON!"
[TGS]: https://forum.kerbalspaceprogram.com/index.php?/topic/203990-*/ "The Gold Standard! (TGS)"

[EN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/American-flag-sm.png "English"
[BR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Brazilian-flag-sm.png "Brasil"
[CN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Chinese-flag-sm.png "中文"
[DE]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/German-flag-sm.png "Deutsch"
[ES]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Spanish-flag-sm.png "Español"
[FR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/French-flag-sm.png "Français"
[IT]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Italian-flag-sm.png "Italiano"
[JA]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Japanese-flag-sm.png "日本語"
[KO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/South-Korean-flag-sm.png "한국어"
[ME]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Mexican-flag-sm.png "Español Mexicano"
[NL]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Dutch-flag-sm.png "Dutch"
[NO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Norwegian-flag-sm.png "Norsk"
[PO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Polish-flag-sm.png "Polski"
[RU]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Russian-flag-sm.png "Русский"
[SW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Swedish-flag-sm.png "Svenska"
[TW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Taiwanese-flag-sm.png "国语"

[gaius]: https://forum.kerbalspaceprogram.com/index.php?/profile/66495-*/ "Gaius"
[geordiepigeonowner]:https://forum.kerbalspaceprogram.com/index.php?/profile/116764-*/ "Geordiepigeonowner"
[hab136]: https://forum.kerbalspaceprogram.com/index.php?/profile/75997-*/ "hab136"
[lisias]: https://forum.kerbalspaceprogram.com/index.php?/profile/187168-*/ "Lisias"
[zer0Kerbal]: https://forum.kerbalspaceprogram.com/index.php?/profile/190933-*/ "zer0Kerbal"
