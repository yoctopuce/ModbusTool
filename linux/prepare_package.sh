#!/bin/bash
## builds linux binary for local platform
## requires installation of
## mono-devel   (sudo apt-get install mono-devel)
## monodevelop  (sudo apt-get install monodevelop)


sudo rm -rf modbustool

mkdir --mode=755 modbustool/
mkdir --mode=755 modbustool/usr/
mkdir --mode=755 modbustool/usr/lib/
mkdir --mode=755 modbustool/usr/lib/ModbusTool

mkdir --mode=755 modbustool/usr/bin/

mkdir --mode=755 modbustool/usr/share/
mkdir --mode=755 modbustool/usr/share/applications
mkdir --mode=755 modbustool/usr/share/pixmaps
mkdir --mode=755 modbustool/DEBIAN

mkdir --mode=755 modbustool/usr/share/icons
mkdir --mode=755 modbustool/usr/share/icons/hicolor/
mkdir --mode=755 modbustool/usr/share/icons/hicolor/16x16
mkdir --mode=755 modbustool/usr/share/icons/hicolor/16x16/apps
mkdir --mode=755 modbustool/usr/share/icons/hicolor/32x32
mkdir --mode=755 modbustool/usr/share/icons/hicolor/32x32/apps
mkdir --mode=755 modbustool/usr/share/icons/hicolor/48x48
mkdir --mode=755 modbustool/usr/share/icons/hicolor/48x48/apps
mkdir --mode=755 modbustool/usr/share/icons/hicolor//128x128
mkdir --mode=755 modbustool/usr/share/icons/hicolor//128x128/apps
mkdir --mode=755 modbustool/usr/share/icons/hicolor/256x256
mkdir --mode=755 modbustool/usr/share/icons/hicolor/256x256/apps
mkdir --mode=755 modbustool/usr/share/icons/hicolor/scalable
mkdir --mode=755 modbustool/usr/share/icons/hicolor/scalable/apps

mkdir --mode=755 modbustool/usr/share/doc
mkdir --mode=755 modbustool/usr/share/doc/modbustool


#mkdir modbustool/etc
#mkdir ModbusTool/etc/udev
#mkdir ModbusTool/etc/rules.d

#cp 51-yoctopuce_all.rules ModbusTool/etc/udev/rules.d
#chmod -R 644 ModbusTool/etc


#copy copyright
cp copyright modbustool/usr/share/doc/modbustool
chmod 644 modbustool/usr/share/doc/modbustool/copyright
cp changelog modbustool/usr/share/doc/modbustool
gzip -n -9 modbustool/usr/share/doc/modbustool/changelog
chmod 644 modbustool/usr/share/doc/modbustool/changelog.gz

#copy debian control filE
cp control modbustool/DEBIAN
#cp conffiles modbustool/DEBIAN
chmod 644 modbustool/DEBIAN/*

#copy freedesktop stuff
cp modbustool.desktop modbustool/usr/share/applications
chmod 644 modbustool/usr/share/applications/ModbusTool.desktop
cp ../artwork/icon.svg modbustool/usr/share/icons/hicolor/scalable/apps/ModbusTool.svg
chmod 644 modbustool/usr/share/icons/hicolor/scalable/apps/ModbusTool.svg
cp icon_16.png modbustool/usr/share/icons/hicolor/16x16/apps/ModbusTool.png
chmod 644 modbustool/usr/share/icons/hicolor/16x16/apps/ModbusTool.png
cp icon_32.png modbustool/usr/share/icons/hicolor/32x32/apps/ModbusTool.png
chmod 644 modbustool/usr/share/icons/hicolor/32x32/apps/ModbusTool.png
cp icon_48.png modbustool/usr/share/icons/hicolor/48x48/apps/ModbusTool.png
chmod 644 modbustool/usr/share/icons/hicolor/48x48/apps/ModbusTool.png
cp icon_128.png modbustool/usr/share/icons/hicolor//128x128/apps/ModbusTool.png
chmod 644 modbustool/usr/share/icons/hicolor//128x128/apps/ModbusTool.png
cp icon_256.png modbustool/usr/share/icons/hicolor/256x256/apps/ModbusTool.png
chmod 644 modbustool/usr/share/icons/hicolor/256x256/apps/ModbusTool.png
cp icon_48.png modbustool/usr/share/pixmaps/ModbusTool.png
chmod 644 modbustool/usr/share/pixmaps/ModbusTool.png



# copy shell script in the path
cp ModbusTool modbustool/usr/bin
chmod 755 modbustool/usr/bin/ModbusTool

#copy linux libs
cp ../libyapi-amd64.so modbustool/usr/lib/ModbusTool
chmod 0644 modbustool/usr/lib/ModbusTool/libyapi-amd64.so
cp ../libyapi-armhf.so modbustool/usr/lib/ModbusTool/libyapi-armhf.so
chmod 0644 modbustool/usr/lib/ModbusTool/libyapi-armhf.so
cp ../libyapi-i386.so modbustool/usr/lib/ModbusTool
chmod 0644 modbustool/usr/lib/ModbusTool/libyapi-i386.so
cp ../libyapi-aarch64.so modbustool/usr/lib/ModbusTool
chmod 0644 modbustool/usr/lib/ModbusTool/libyapi-aarch64.so

#copy binary
cp  ../bin/Release/modbustool.exe modbustool/usr/lib/ModbusTool
#cp  modbustool.exe.config modbustool/usr/lib/ModbusTool
chmod 755 modbustool/usr/lib/ModbusTool/modbustool.exe
#chmod 644 modbustool/usr/lib/ModbusTool/modbustool.exe.config

#set all file to root user
sudo chown -R root:root modbustool


dpkg-deb --build modbustool


lintian modbustool.deb