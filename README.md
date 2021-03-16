# Engarde Synthesis Patcher
### [Original mod](https://www.nexusmods.com/skyrimspecialedition/mods/25673)
This is a port of Engarde patcher to Synthesis/Mutagen Framework, which allows to bypass 255 plugin limit,<br>
(not completely though, you still must have < 254 esp/esm plugins).

_Note_: if you want to use prerelease versions of Mutagen and Synthesis, in "Versioning" tab change target branch to "dev"
But I strongly advice you against doing this, because prerelease versions is unstable and in active development

# Credits:
- [tudoru](https://www.nexusmods.com/skyrimspecialedition/users/2327661), the author of Engarde;
- [Noggog](https://github.com/Noggog), the author of Mutagen and Synthesis.

## How to use:
First, you need to install Engarde main files as usual, but instead of running zPatch you need to do the following:
  1. Install [Synthesis](https://github.com/Mutagen-Modding/Synthesis) (in the releases tab download "Synthesis.zip")
     1) Unpack zip file in to separate folder (somewhere near your modding tools);
     2) Add Synthesis.exe as executable in your mod manager;
  2. Launch Synthesis through your mod manager;
  3. In the top left corner select "Git repository"
  4. Find this patcher in the list and add it;
  5. Open settings tab, it should look like this:<br>
![image](https://user-images.githubusercontent.com/62331215/109416842-ccc98880-79ea-11eb-82d6-0d79228eae50.png)
  7. Customize your settings;
  8. When you ready, launch patchers by using button in the bottom left corner.
