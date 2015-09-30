
# unity-GoogleMixedTemplate

This library is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation; either version 3.0 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License along with this library; if not, write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA

## What is this?
This is the sample unity3D project implementing admob, and google play services with unity free plugins.

## Including libraries (plugins)
* https://github.com/faizann/UnityGPGPlugin 
  - I changed this plugin. 
* https://github.com/mikito/unity-admob-plugin 

Thanks a lot. 

## How to use.

### AdMob

1. You go to admob web sight and register your (Android|iOS) app.  
SS1. register your admob application  
http://gyazo.com/dda2b0d4e8952842972175f8ebaefdb2  

2. Note your publish ID  
You can select your created application and confirm it.  
http://gyazo.com/84d083f3bd80c1f82e6d624fa5fe0576  

3. Type your publish ID into AdMobManager on inspector  
http://gyazo.com/e1bf6be59f5978e8511d01fadcdfebd4  

Notice) If you debug your iphone or android device, you should write your DeviceIDs on inspector.  
If you use android device, maybe you can find your device id by command "adb logcat | grep device".  
If you use ios device, maybe you can find your device id by xcode debug log.  

### Google Play Services

#### 1. Register your new Game Services.  
Fill input and post it.  
[http://gyazo.com/5eaa9ef625711876417169e025d1831c](http://gyazo.com/5eaa9ef625711876417169e025d1831c)  

Fill Game details.  
Notice) I strongly recommend you should not vimperator(firefox) but use google chrome.  
[http://gyazo.com/048d2c7e15d182351788d715b0024c72](http://gyazo.com/048d2c7e15d182351788d715b0024c72)  

Maybe you have to create highres icon.  
This link is quite helpful.  

[Android Asset Studio](http://android-ui-utils.googlecode.com/hg/asset-studio/dist/icons-launcher.html#foreground.space.trim=1&foreground.space.pad=0&foreColor=33b5e5%2C0&crop=0&backgroundShape=none&backColor=ffffff%2C100)

You select Foreground, upload image and click GENERATE WEB ICON.  
You also need Feature Graphic. And Save it.  

#### 2. Configure your game services.  
You have to click your platform and fill input form.  
http://gyazo.com/4fb5345c3a1950fd0505a85fa0dbe841  
http://gyazo.com/bd2eed640a0219c34011689b75bdd5d8  

If you have no photo on your server, this placeholder ss will be helpful.  
[placeholder_icon](https://developers.google.com/games/services/downloads/placeholder-screenshot1-320x480.jpg)  

If you need your finger print, you can specify debug.keystore for debug.  
keytool -list -v -alias androiddebugkey -keystore debug.keystore | nkf  

create achievements at least 5, because google requires it.  
And register your leaderboard.  

In sample project, two sample leaderboard is used.  
But achievement is not used.  


#### 3. In unity 3d, fix files.  
* Assets/Editor/googleplay_eclipse.py
* Assets/Editor/googleplay_xcode.py
* Assets/Editor/PostprocessBuildPlayer

you have to fix .py files to follow your settings.  


#### 4. Build your game on debug device.  
You have to set your bundle id. take care.  

In Debug term, you can specify your debug keystore.  
cd $HOME/.android  
keytool -list -v -alias androiddebugkey -keystore debug.keystore | nkf  

When publish your android app, don't forget checking checkbox Create Eclipse project layout.  


If you open ADT(eclipse) for the first time, it's like this SS.  
[http://gyazo.com/d55a0abec724f0a45bc2d894ac626882](http://gyazo.com/d55a0abec724f0a45bc2d894ac626882)  

Notice) You first create your workspace as /Users/mac/eclipse/workspace/hogehoge  


#### 5. You have to prepare a lot of settings.  
Go to google api console, and type bundle package and fill other settings.  
If finished, you have to set those info to GooglePlayServicesManager inspector.  
You also set achievement ids and leaderboard ids.  


#### 6. Publish on debug.  
File -> New -> Project -> Android Project from ... -> Next  
[http://gyazo.com/b6597ba34ef1992c65f8f761cebf1d6c](http://gyazo.com/b6597ba34ef1992c65f8f761cebf1d6c) 

and specify your unity library.  
I specified /Users/mac/unity/GoogleMixedTemplate .  
In my case, I published to unityprojectroot/eclipse dir, so I only checked eclipse directory.  
 
Maybe error occur because google play services lib have not imported.  
[http://gyazo.com/62a9d2c9f77d38299b0123af79baf46f](http://gyazo.com/62a9d2c9f77d38299b0123af79baf46f)

So import it.  File -> Android(Existing hogehoge...) next.  
[http://gyazo.com/6b76b3cf6059f7ba8fcd61eaf1546bb6](http://gyazo.com/6b76b3cf6059f7ba8fcd61eaf1546bb6)  

Notice) in my case, libproject is this path => /usr/local/android-sdk/extras/google/google_play_services/libproject  

finished ss.  
[http://gyazo.com/4b3f53b6d656fbe7c0174675910ade40](http://gyazo.com/4b3f53b6d656fbe7c0174675910ade40)  

If you want to publish on production,  
 change your finger print and setting on console,  
 uncheck development mode,  
 restart your ADT, import lib from properties, and Androidtool -> Export Signed application package...  

#### 7. iOS  
create linked apps.  
[http://gyazo.com/7cac1f9d5527fbfd7139a06dd2add264](http://gyazo.com/7cac1f9d5527fbfd7139a06dd2add264)  
fix your manager by ios client id.  
and build it like android.  

## License
see license.txt

