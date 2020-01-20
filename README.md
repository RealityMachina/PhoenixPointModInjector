# Phoenix Point Mod Loader

The Phoenix Point Mod Loader (PPML) may be used to easily patch or alter Phoenix Point (PP) game code. It is based off of the BattleTech Mod Loader (https://github.com/BattletechModders/BattleTechModLoader).

The project uses, and expects mods to use, the Harmony library (https://github.com/pardeike/Harmony) to patch game behavior. Modding in its current state consists mainly of assembly patching.

# Installation

Place the contents of the .zip file in your `PhoenixPoint\PhoenixPointWin64_Data\Managed` directory. Run the executable titled `PhoenixPointModLoaderInjector.exe`.

Run the game to have it generate the `Mods` folder for the Mod Loader. Place all mod directories/files into this folder.

# Developer Information

The mod loader will recursively search the `Mods` directory in order to obtain all DLLs it can find. It will then 

