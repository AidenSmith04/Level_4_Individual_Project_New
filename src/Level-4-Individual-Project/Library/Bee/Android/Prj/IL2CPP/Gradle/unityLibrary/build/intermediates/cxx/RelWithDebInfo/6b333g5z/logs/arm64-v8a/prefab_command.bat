@echo off
"C:\\Program Files\\Unity\\Hub\\Editor\\6000.0.26f1\\Editor\\Data\\PlaybackEngines\\AndroidPlayer\\OpenJDK\\bin\\java" ^
  --class-path ^
  "C:\\Users\\User\\.gradle\\caches\\modules-2\\files-2.1\\com.google.prefab\\cli\\2.0.0\\f2702b5ca13df54e3ca92f29d6b403fb6285d8df\\cli-2.0.0-all.jar" ^
  com.google.prefab.cli.AppKt ^
  --build-system ^
  cmake ^
  --platform ^
  android ^
  --abi ^
  arm64-v8a ^
  --os-version ^
  29 ^
  --stl ^
  c++_shared ^
  --ndk-version ^
  23 ^
  --output ^
  "C:\\Users\\User\\AppData\\Local\\Temp\\agp-prefab-staging800881151722695450\\staged-cli-output" ^
  "C:\\Users\\User\\.gradle\\caches\\transforms-3\\4533d298259fc52a43021fce53f5e4a9\\transformed\\jetified-games-activity-3.0.5\\prefab" ^
  "C:\\Users\\User\\.gradle\\caches\\transforms-3\\268849a49ea9eb2bba6f4e0ac95bfd63\\transformed\\jetified-games-frame-pacing-1.10.0\\prefab"
