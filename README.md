# Monke Mod Manager

![{63A06F0B-5859-4D62-A23C-8F0415E4B5F7}](https://github.com/user-attachments/assets/aced1789-7aaf-4958-b40b-3db3c03c923e)


This program will install custom mods into Gorilla Tag automatically, and can be re-run in order to update the mods

This uses the github api to get the latest release of all these mods, so you know you'll always be getting the latest version!
(If you've made a mod that you want added to the installer, send me a message on Discord! `the.graze`)

## To have your modded added
DM me:
* The Github repository of the mod you want added 
* Any dependencies

Or fork => [this](https://github.com/The-Graze/MonkeModInfo) <= repository and add it yourself with a PullRequest

Mod submission is likely subject to change in the future.

### Ensure that
* your mod is built in the monke mod manager compatible format through `MakeRelease.ps1` (replace `netstandard2.0` with `netstandard2.1` in the code) or you use just a DLL in your release
* you list the correct dependencies
* your mod is fully working
