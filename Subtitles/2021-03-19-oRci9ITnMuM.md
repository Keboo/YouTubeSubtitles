[YouTube Video](https://youtu.be/oRci9ITnMuM)



[okay welcome back everyone](https://youtu.be/oRci9ITnMuM?t=00h00m02s)

[tonight i am going to circle back to](https://youtu.be/oRci9ITnMuM?t=00h00m04s)

[material design in xaml](https://youtu.be/oRci9ITnMuM?t=00h00m06s)

[uh the last couple weeks i was off uh](https://youtu.be/oRci9ITnMuM?t=00h00m07s)

[playing on the system command line](https://youtu.be/oRci9ITnMuM?t=00h00m09s)

[library you can check out the](https://youtu.be/oRci9ITnMuM?t=00h00m11s)

[uh previous recordings if you're](https://youtu.be/oRci9ITnMuM?t=00h00m13s)

[interested in that working on the help](https://youtu.be/oRci9ITnMuM?t=00h00m14s)

[output](https://youtu.be/oRci9ITnMuM?t=00h00m16s)

[but the pull request for that is now](https://youtu.be/oRci9ITnMuM?t=00h00m16s)

[open there's probably a little bit more](https://youtu.be/oRci9ITnMuM?t=00h00m18s)

[cleanup to do](https://youtu.be/oRci9ITnMuM?t=00h00m20s)

[but i wanted to get it open to get](https://youtu.be/oRci9ITnMuM?t=00h00m21s)

[feedback and get that rolling](https://youtu.be/oRci9ITnMuM?t=00h00m22s)

[so tonight uh after the the day i've had](https://youtu.be/oRci9ITnMuM?t=00h00m24s)

[i figured i would circle back](https://youtu.be/oRci9ITnMuM?t=00h00m27s)

[and i would do more material design and](https://youtu.be/oRci9ITnMuM?t=00h00m29s)

[xaml work](https://youtu.be/oRci9ITnMuM?t=00h00m31s)

[uh which was sort of where i was hoping](https://youtu.be/oRci9ITnMuM?t=00h00m32s)

[to land so](https://youtu.be/oRci9ITnMuM?t=00h00m34s)

[um i had a couple thoughts on where to](https://youtu.be/oRci9ITnMuM?t=00h00m35s)

[go and the most](https://youtu.be/oRci9ITnMuM?t=00h00m37s)

[obvious one let's flip over here to the](https://youtu.be/oRci9ITnMuM?t=00h00m38s)

[code is](https://youtu.be/oRci9ITnMuM?t=00h00m40s)

[icons so let's let's fire this up and](https://youtu.be/oRci9ITnMuM?t=00h00m42s)

[i'll explain what i mean](https://youtu.be/oRci9ITnMuM?t=00h00m44s)

[so i've been trying to think through](https://youtu.be/oRci9ITnMuM?t=00h00m46s)

[what are the biggest pain points that](https://youtu.be/oRci9ITnMuM?t=00h00m49s)

[at least i run into while building apps](https://youtu.be/oRci9ITnMuM?t=00h00m51s)

[with this library](https://youtu.be/oRci9ITnMuM?t=00h00m54s)

[and i've done a little bit of work in](https://youtu.be/oRci9ITnMuM?t=00h00m56s)

[the past to try to smooth over](https://youtu.be/oRci9ITnMuM?t=00h00m58s)

[um the common the common pitfalls where](https://youtu.be/oRci9ITnMuM?t=00h01m00s)

[you know you haven't included all the](https://youtu.be/oRci9ITnMuM?t=00h01m03s)

[right resource dictionaries in your](https://youtu.be/oRci9ITnMuM?t=00h01m04s)

[app.xaml or setting up the style in your](https://youtu.be/oRci9ITnMuM?t=00h01m06s)

[base window and that kind of thing](https://youtu.be/oRci9ITnMuM?t=00h01m08s)

[um but the next problem that i that i](https://youtu.be/oRci9ITnMuM?t=00h01m10s)

[typically run into is](https://youtu.be/oRci9ITnMuM?t=00h01m12s)

[in a brand new wpf app you have to set](https://youtu.be/oRci9ITnMuM?t=00h01m14s)

[this little icon](https://youtu.be/oRci9ITnMuM?t=00h01m16s)

[file and icon files are kind of a pain](https://youtu.be/oRci9ITnMuM?t=00h01m18s)

[in the neck to build](https://youtu.be/oRci9ITnMuM?t=00h01m21s)

[and i got to thinking a little bit that](https://youtu.be/oRci9ITnMuM?t=00h01m22s)

[it might be](https://youtu.be/oRci9ITnMuM?t=00h01m25s)

[nice if rather than being forced to go](https://youtu.be/oRci9ITnMuM?t=00h01m26s)

[through and come up with your own](https://youtu.be/oRci9ITnMuM?t=00h01m29s)

[icon file if you could come over to this](https://youtu.be/oRci9ITnMuM?t=00h01m30s)

[icon pack file here right because we've](https://youtu.be/oRci9ITnMuM?t=00h01m33s)

[already got this nice little option for](https://youtu.be/oRci9ITnMuM?t=00h01m36s)

[you know find find the icon that you're](https://youtu.be/oRci9ITnMuM?t=00h01m38s)

[looking for right you can search through](https://youtu.be/oRci9ITnMuM?t=00h01m40s)

[there's](https://youtu.be/oRci9ITnMuM?t=00h01m42s)

[way too many icons in here right all the](https://youtu.be/oRci9ITnMuM?t=00h01m43s)

[ones from the material design](https://youtu.be/oRci9ITnMuM?t=00h01m45s)

[uh library but in addition to this copy](https://youtu.be/oRci9ITnMuM?t=00h01m48s)

[to clipboard it might be nice if there](https://youtu.be/oRci9ITnMuM?t=00h01m51s)

[was a](https://youtu.be/oRci9ITnMuM?t=00h01m53s)

[an option to export these icons](https://youtu.be/oRci9ITnMuM?t=00h01m55s)

[as uh or yeah export these icons as an](https://youtu.be/oRci9ITnMuM?t=00h01m58s)

[ico file](https://youtu.be/oRci9ITnMuM?t=00h02m01s)

[right and maybe more importantly slap a](https://youtu.be/oRci9ITnMuM?t=00h02m03s)

[little](https://youtu.be/oRci9ITnMuM?t=00h02m06s)

[color on there and bippity boppity away](https://youtu.be/oRci9ITnMuM?t=00h02m07s)

[you go](https://youtu.be/oRci9ITnMuM?t=00h02m09s)

[so what is that going to take so](https://youtu.be/oRci9ITnMuM?t=00h02m10s)

[this is one thing that shocks me so](https://youtu.be/oRci9ITnMuM?t=00h02m14s)

[the icon file format itself is fairly](https://youtu.be/oRci9ITnMuM?t=00h02m17s)

[fairly simple and straightforward and](https://youtu.be/oRci9ITnMuM?t=00h02m22s)

[we'll just we'll just grab this guy here](https://youtu.be/oRci9ITnMuM?t=00h02m24s)

[so if anybody's](https://youtu.be/oRci9ITnMuM?t=00h02m26s)

[if anybody's interested there's there's](https://youtu.be/oRci9ITnMuM?t=00h02m27s)

[a few things here](https://youtu.be/oRci9ITnMuM?t=00h02m30s)

[and there's there's some key details in](https://youtu.be/oRci9ITnMuM?t=00h02m31s)

[this whole](https://youtu.be/oRci9ITnMuM?t=00h02m33s)

[format bit here right the the format](https://youtu.be/oRci9ITnMuM?t=00h02m34s)

[itself is fairly simple](https://youtu.be/oRci9ITnMuM?t=00h02m38s)

[there's a header you then write a bunch](https://youtu.be/oRci9ITnMuM?t=00h02m39s)

[of image entries](https://youtu.be/oRci9ITnMuM?t=00h02m42s)

[this is the spec for your image entries](https://youtu.be/oRci9ITnMuM?t=00h02m43s)

[and you just dump](https://youtu.be/oRci9ITnMuM?t=00h02m45s)

[out the data and i've been poking around](https://youtu.be/oRci9ITnMuM?t=00h02m46s)

[to see](https://youtu.be/oRci9ITnMuM?t=00h02m49s)

[to try to find reasonable libraries to](https://youtu.be/oRci9ITnMuM?t=00h02m50s)

[work with this](https://youtu.be/oRci9ITnMuM?t=00h02m53s)

[and there's a few things that i've run](https://youtu.be/oRci9ITnMuM?t=00h02m54s)

[into so the the](https://youtu.be/oRci9ITnMuM?t=00h02m55s)

[icon object that lives in the system](https://youtu.be/oRci9ITnMuM?t=00h02m57s)

[drawing namespace](https://youtu.be/oRci9ITnMuM?t=00h03m00s)

[doesn't allow for creation of ico files](https://youtu.be/oRci9ITnMuM?t=00h03m02s)

[and multiple resolutions](https://youtu.be/oRci9ITnMuM?t=00h03m05s)

[so typically with an ico file let's see](https://youtu.be/oRci9ITnMuM?t=00h03m07s)

[and i believe we can just go in here](https://youtu.be/oRci9ITnMuM?t=00h03m09s)

[i didn't actually check this ahead of](https://youtu.be/oRci9ITnMuM?t=00h03m11s)

[time so we're going to find out](https://youtu.be/oRci9ITnMuM?t=00h03m12s)

[nope this has just got a single](https://youtu.be/oRci9ITnMuM?t=00h03m16s)

[resolution uh but the key thing to note](https://youtu.be/oRci9ITnMuM?t=00h03m18s)

[is this can be filled with a whole bunch](https://youtu.be/oRci9ITnMuM?t=00h03m20s)

[of resolutions](https://youtu.be/oRci9ITnMuM?t=00h03m22s)

[right um and so my thought is why not go](https://youtu.be/oRci9ITnMuM?t=00h03m23s)

[through and do this and one of the](https://youtu.be/oRci9ITnMuM?t=00h03m26s)

[things that](https://youtu.be/oRci9ITnMuM?t=00h03m28s)

[really really frustrates me is there's](https://youtu.be/oRci9ITnMuM?t=00h03m28s)

[quite a few libraries that if you feed](https://youtu.be/oRci9ITnMuM?t=00h03m31s)

[it an svg file](https://youtu.be/oRci9ITnMuM?t=00h03m33s)

[it will rasterize the svg file once](https://youtu.be/oRci9ITnMuM?t=00h03m35s)

[at like the largest resolution and then](https://youtu.be/oRci9ITnMuM?t=00h03m39s)

[resize](https://youtu.be/oRci9ITnMuM?t=00h03m41s)

[that rather than re-rasterizing the svg](https://youtu.be/oRci9ITnMuM?t=00h03m42s)

[so what do what](https://youtu.be/oRci9ITnMuM?t=00h03m45s)

[does that mean right so an svg is a](https://youtu.be/oRci9ITnMuM?t=00h03m46s)

[scalar](https://youtu.be/oRci9ITnMuM?t=00h03m48s)

[image so rather than encoding every](https://youtu.be/oRci9ITnMuM?t=00h03m49s)

[pixel at what it's supposed to be what](https://youtu.be/oRci9ITnMuM?t=00h03m52s)

[it does is it encodes](https://youtu.be/oRci9ITnMuM?t=00h03m54s)

[um effectively you can imagine like the](https://youtu.be/oRci9ITnMuM?t=00h03m55s)

[equation of a line right](https://youtu.be/oRci9ITnMuM?t=00h03m57s)

[y equals mx plus b you could](https://youtu.be/oRci9ITnMuM?t=00h03m59s)

[encode that equation or you could encode](https://youtu.be/oRci9ITnMuM?t=00h04m02s)

[every single pixel](https://youtu.be/oRci9ITnMuM?t=00h04m04s)

[pixel but by encoding the equation you](https://youtu.be/oRci9ITnMuM?t=00h04m06s)

[can then scale that up and down to](https://youtu.be/oRci9ITnMuM?t=00h04m08s)

[whatever size you need](https://youtu.be/oRci9ITnMuM?t=00h04m09s)

[that's effectively the underlying](https://youtu.be/oRci9ITnMuM?t=00h04m10s)

[principle on how vector art works with](https://youtu.be/oRci9ITnMuM?t=00h04m12s)

[svgs](https://youtu.be/oRci9ITnMuM?t=00h04m14s)

[and why they're preferable because they](https://youtu.be/oRci9ITnMuM?t=00h04m15s)

[can scale to different resolutions](https://youtu.be/oRci9ITnMuM?t=00h04m16s)

[nicely and they don't pixelate and that](https://youtu.be/oRci9ITnMuM?t=00h04m18s)

[kind of thing](https://youtu.be/oRci9ITnMuM?t=00h04m20s)

[so ideally what i'd love to do is to get](https://youtu.be/oRci9ITnMuM?t=00h04m22s)

[something like that put in and i was](https://youtu.be/oRci9ITnMuM?t=00h04m26s)

[thinking](https://youtu.be/oRci9ITnMuM?t=00h04m28s)

[i was trying to poke around a little bit](https://youtu.be/oRci9ITnMuM?t=00h04m30s)

[before the stream started to see if](https://youtu.be/oRci9ITnMuM?t=00h04m32s)

[there was a](https://youtu.be/oRci9ITnMuM?t=00h04m34s)

[um c sharp](https://youtu.be/oRci9ITnMuM?t=00h04m36s)

[on uh to see if there's a nice c sharp](https://youtu.be/oRci9ITnMuM?t=00h04m42s)

[library thing](https://youtu.be/oRci9ITnMuM?t=00h04m44s)

[for manipulating it and this is probably](https://youtu.be/oRci9ITnMuM?t=00h04m46s)

[one of the closest ones i've seen](https://youtu.be/oRci9ITnMuM?t=00h04m49s)

[it seems pretty simple and](https://youtu.be/oRci9ITnMuM?t=00h04m53s)

[straightforward](https://youtu.be/oRci9ITnMuM?t=00h04m55s)

[and so we may just take a we may just](https://youtu.be/oRci9ITnMuM?t=00h04m57s)

[take a crack at this and see how this](https://youtu.be/oRci9ITnMuM?t=00h05m00s)

[goes because i think this would be a](https://youtu.be/oRci9ITnMuM?t=00h05m01s)

[nice](https://youtu.be/oRci9ITnMuM?t=00h05m03s)

[a nice little addition to come in and in](https://youtu.be/oRci9ITnMuM?t=00h05m04s)

[general](https://youtu.be/oRci9ITnMuM?t=00h05m06s)

[um we've resisted taking uh](https://youtu.be/oRci9ITnMuM?t=00h05m07s)

[additional dependencies in the library](https://youtu.be/oRci9ITnMuM?t=00h05m10s)

[but this is going to be in the demo](https://youtu.be/oRci9ITnMuM?t=00h05m12s)

[app right so one more thing to make the](https://youtu.be/oRci9ITnMuM?t=00h05m14s)

[demo app](https://youtu.be/oRci9ITnMuM?t=00h05m16s)

[just a little bit cooler all right and](https://youtu.be/oRci9ITnMuM?t=00h05m17s)

[if the and if this works maybe we'll](https://youtu.be/oRci9ITnMuM?t=00h05m20s)

[submit a](https://youtu.be/oRci9ITnMuM?t=00h05m21s)

[a poll request to to the ma apps icon](https://youtu.be/oRci9ITnMuM?t=00h05m22s)

[library because](https://youtu.be/oRci9ITnMuM?t=00h05m25s)

[they've got a pretty cool icon library](https://youtu.be/oRci9ITnMuM?t=00h05m26s)

[too and it would just make it that much](https://youtu.be/oRci9ITnMuM?t=00h05m28s)

[better](https://youtu.be/oRci9ITnMuM?t=00h05m30s)

[so let's let's take a crack at this and](https://youtu.be/oRci9ITnMuM?t=00h05m31s)

[see what it's going to take so](https://youtu.be/oRci9ITnMuM?t=00h05m34s)

[because what i'm imagining is we is we](https://youtu.be/oRci9ITnMuM?t=00h05m36s)

[slap something in down here perhaps](https://youtu.be/oRci9ITnMuM?t=00h05m38s)

[so after you've selected one you can](https://youtu.be/oRci9ITnMuM?t=00h05m41s)

[click something because i imagine you](https://youtu.be/oRci9ITnMuM?t=00h05m44s)

[click something here](https://youtu.be/oRci9ITnMuM?t=00h05m45s)

[check a box for the various resolutions](https://youtu.be/oRci9ITnMuM?t=00h05m47s)

[that you might want](https://youtu.be/oRci9ITnMuM?t=00h05m49s)

[and then from there i](https://youtu.be/oRci9ITnMuM?t=00h05m51s)

[think you just that in a color picker](https://youtu.be/oRci9ITnMuM?t=00h05m55s)

[do we need anything else i think that's](https://youtu.be/oRci9ITnMuM?t=00h05m58s)

[about it](https://youtu.be/oRci9ITnMuM?t=00h06m00s)

[i think that's about it so let's see](https://youtu.be/oRci9ITnMuM?t=00h06m01s)

[let's let's actually use this library to](https://youtu.be/oRci9ITnMuM?t=00h06m04s)

[build something today](https://youtu.be/oRci9ITnMuM?t=00h06m06s)

[that's what i'm thinking that's that's](https://youtu.be/oRci9ITnMuM?t=00h06m07s)

[what i'm thinking we're gonna do we're](https://youtu.be/oRci9ITnMuM?t=00h06m08s)

[gonna build something](https://youtu.be/oRci9ITnMuM?t=00h06m09s)

[okay so step one i'm gonna come here i'm](https://youtu.be/oRci9ITnMuM?t=00h06m11s)

[gonna get on my master](https://youtu.be/oRci9ITnMuM?t=00h06m14s)

[branch and we're going to droop](https://youtu.be/oRci9ITnMuM?t=00h06m15s)

[jump over here create branch uh](https://youtu.be/oRci9ITnMuM?t=00h06m18s)

[ico generator great](https://youtu.be/oRci9ITnMuM?t=00h06m22s)

[and off to the races we go okay so let's](https://youtu.be/oRci9ITnMuM?t=00h06m26s)

[come down here](https://youtu.be/oRci9ITnMuM?t=00h06m30s)

[icon pack.xml so this is this is the](https://youtu.be/oRci9ITnMuM?t=00h06m31s)

[xaml](https://youtu.be/oRci9ITnMuM?t=00h06m35s)

[for that ui](https://youtu.be/oRci9ITnMuM?t=00h06m35s)

[so we've got our list box and then this](https://youtu.be/oRci9ITnMuM?t=00h06m40s)

[is the part down at the bottom so we've](https://youtu.be/oRci9ITnMuM?t=00h06m42s)

[got our color](https://youtu.be/oRci9ITnMuM?t=00h06m44s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=00h06m45s)

[zone panel](https://youtu.be/oRci9ITnMuM?t=00h06m46s)

[text box color zone pack icon](https://youtu.be/oRci9ITnMuM?t=00h06m48s)

[button and so we probably want to go](https://youtu.be/oRci9ITnMuM?t=00h06m52s)

[just to the right of the button and i'm](https://youtu.be/oRci9ITnMuM?t=00h06m53s)

[sort of thinking that what we end up](https://youtu.be/oRci9ITnMuM?t=00h06m55s)

[doing here](https://youtu.be/oRci9ITnMuM?t=00h06m56s)

[is and i'm going to actually control f5](https://youtu.be/oRci9ITnMuM?t=00h06m57s)

[because i'd like to use the demo app to](https://youtu.be/oRci9ITnMuM?t=00h07m00s)

[build the demo app](https://youtu.be/oRci9ITnMuM?t=00h07m02s)

[i'm sort of thinking a simple pop-up box](https://youtu.be/oRci9ITnMuM?t=00h07m06s)

[so oh uh](https://youtu.be/oRci9ITnMuM?t=00h07m10s)

[pop-up are under buttons](https://youtu.be/oRci9ITnMuM?t=00h07m13s)

[right so i'm kind of i'm kind of](https://youtu.be/oRci9ITnMuM?t=00h07m16s)

[picturing one of these](https://youtu.be/oRci9ITnMuM?t=00h07m19s)

[one of these kind of thingies here right](https://youtu.be/oRci9ITnMuM?t=00h07m21s)

[where](https://youtu.be/oRci9ITnMuM?t=00h07m23s)

[you get your icon set you've got some](https://youtu.be/oRci9ITnMuM?t=00h07m24s)

[sort of](https://youtu.be/oRci9ITnMuM?t=00h07m27s)

[uh box list for for sizes](https://youtu.be/oRci9ITnMuM?t=00h07m27s)

[right and then a a generate button that](https://youtu.be/oRci9ITnMuM?t=00h07m32s)

[pops a save dialogue and](https://youtu.be/oRci9ITnMuM?t=00h07m34s)

[and off to the race as you go](https://youtu.be/oRci9ITnMuM?t=00h07m36s)

[i'm thinking something like that so let](https://youtu.be/oRci9ITnMuM?t=00h07m40s)

[me let's let's just grab](https://youtu.be/oRci9ITnMuM?t=00h07m41s)

[let's just grab this so i kind of want](https://youtu.be/oRci9ITnMuM?t=00h07m43s)

[to grab](https://youtu.be/oRci9ITnMuM?t=00h07m45s)

[here's the pop-up box in all its glory](https://youtu.be/oRci9ITnMuM?t=00h07m47s)

[uh let's just grab all of that](https://youtu.be/oRci9ITnMuM?t=00h07m51s)

[and we'll come back over here and we'll](https://youtu.be/oRci9ITnMuM?t=00h07m55s)

[just we'll just slap that guy in](https://youtu.be/oRci9ITnMuM?t=00h07m56s)

[okay so that's that's a lot of stuff and](https://youtu.be/oRci9ITnMuM?t=00h07m59s)

[we don't want](https://youtu.be/oRci9ITnMuM?t=00h08m01s)

[a lot of it but that at least gets us](https://youtu.be/oRci9ITnMuM?t=00h08m02s)

[gets us going so](https://youtu.be/oRci9ITnMuM?t=00h08m05s)

[first off we want stays open true we](https://youtu.be/oRci9ITnMuM?t=00h08m06s)

[don't need the enabled flag](https://youtu.be/oRci9ITnMuM?t=00h08m08s)

[put that back we'll build that out](https://youtu.be/oRci9ITnMuM?t=00h08m11s)

[build that out okay so we probably do](https://youtu.be/oRci9ITnMuM?t=00h08m15s)

[want a grid](https://youtu.be/oRci9ITnMuM?t=00h08m17s)

[we probably do want the grid to have a](https://youtu.be/oRci9ITnMuM?t=00h08m18s)

[fixed width](https://youtu.be/oRci9ITnMuM?t=00h08m20s)

[and that 300 looked good for now we](https://youtu.be/oRci9ITnMuM?t=00h08m22s)

[don't care about resources in the grid](https://youtu.be/oRci9ITnMuM?t=00h08m25s)

[for now so we'll get rid of that](https://youtu.be/oRci9ITnMuM?t=00h08m27s)

[column definitions and row definitions i](https://youtu.be/oRci9ITnMuM?t=00h08m29s)

[think i'm just going to whack for now](https://youtu.be/oRci9ITnMuM?t=00h08m31s)

[until we figure out what we want](https://youtu.be/oRci9ITnMuM?t=00h08m33s)

[and then i think all of the content in](https://youtu.be/oRci9ITnMuM?t=00h08m35s)

[here i can probably just get rid of](https://youtu.be/oRci9ITnMuM?t=00h08m37s)

[because ultimately i'm just looking to](https://youtu.be/oRci9ITnMuM?t=00h08m40s)

[have sort of a blank grid to play with](https://youtu.be/oRci9ITnMuM?t=00h08m41s)

[so all you yeah so all this goes away](https://youtu.be/oRci9ITnMuM?t=00h08m44s)

[okay so then if we come back over here](https://youtu.be/oRci9ITnMuM?t=00h08m50s)

[oh we aren't debugging so i don't have](https://youtu.be/oRci9ITnMuM?t=00h08m52s)

[access to that](https://youtu.be/oRci9ITnMuM?t=00h08m53s)

[okay so inside of this grid what what](https://youtu.be/oRci9ITnMuM?t=00h08m55s)

[all do we need so at the bottom](https://youtu.be/oRci9ITnMuM?t=00h08m58s)

[actually i guess i i do realize i do](https://youtu.be/oRci9ITnMuM?t=00h09m00s)

[want something i kind of want those save](https://youtu.be/oRci9ITnMuM?t=00h09m02s)

[buttons at the bottom](https://youtu.be/oRci9ITnMuM?t=00h09m04s)

[uh so let's leave let's leave the stack](https://youtu.be/oRci9ITnMuM?t=00h09m05s)

[panel down there for now and then we](https://youtu.be/oRci9ITnMuM?t=00h09m09s)

[will](https://youtu.be/oRci9ITnMuM?t=00h09m11s)

[get rid of this because i kind of want](https://youtu.be/oRci9ITnMuM?t=00h09m13s)

[to keep the save button](https://youtu.be/oRci9ITnMuM?t=00h09m16s)

[uh we're going to redo the way that](https://youtu.be/oRci9ITnMuM?t=00h09m19s)

[works we're going to redo the way that](https://youtu.be/oRci9ITnMuM?t=00h09m21s)

[works](https://youtu.be/oRci9ITnMuM?t=00h09m23s)

[and get rid of you get rid of all this](https://youtu.be/oRci9ITnMuM?t=00h09m25s)

[so we'll keep the save button we'll](https://youtu.be/oRci9ITnMuM?t=00h09m26s)

[unbind the command because that's not](https://youtu.be/oRci9ITnMuM?t=00h09m28s)

[what we want](https://youtu.be/oRci9ITnMuM?t=00h09m29s)

[we will format this because that copy](https://youtu.be/oRci9ITnMuM?t=00h09m31s)

[and paste did not do me any favors](https://youtu.be/oRci9ITnMuM?t=00h09m33s)

[and get rid of that](https://youtu.be/oRci9ITnMuM?t=00h09m37s)

[get rid of that there now we're talking](https://youtu.be/oRci9ITnMuM?t=00h09m40s)

[now we're back down to something same](https://youtu.be/oRci9ITnMuM?t=00h09m43s)

[so inside of here we're going to have a](https://youtu.be/oRci9ITnMuM?t=00h09m45s)

[selected](https://youtu.be/oRci9ITnMuM?t=00h09m47s)

[button we probably want to grab](https://youtu.be/oRci9ITnMuM?t=00h09m49s)

[let's see so pack icon kind let's see](https://youtu.be/oRci9ITnMuM?t=00h09m56s)

[this is bound](https://youtu.be/oRci9ITnMuM?t=00h09m59s)

[so this will be our enum so let's](https://youtu.be/oRci9ITnMuM?t=00h10m01s)

[let's go through and we can just](https://youtu.be/oRci9ITnMuM?t=00h10m05s)

[leverage that a little bit](https://youtu.be/oRci9ITnMuM?t=00h10m07s)

[because i'm i'm sort of thinking that i](https://youtu.be/oRci9ITnMuM?t=00h10m08s)

[probably want](https://youtu.be/oRci9ITnMuM?t=00h10m10s)

[i probably want this thing here again so](https://youtu.be/oRci9ITnMuM?t=00h10m13s)

[i'm thinking i'm gonna have the icon at](https://youtu.be/oRci9ITnMuM?t=00h10m16s)

[the top](https://youtu.be/oRci9ITnMuM?t=00h10m18s)

[and i realize i haven't set up my my](https://youtu.be/oRci9ITnMuM?t=00h10m19s)

[grid yet so we'll do that in a minute](https://youtu.be/oRci9ITnMuM?t=00h10m21s)

[um](https://youtu.be/oRci9ITnMuM?t=00h10m23s)

[yeah that's fine vertical alignment](https://youtu.be/oRci9ITnMuM?t=00h10m28s)

[center isn't going to matter](https://youtu.be/oRci9ITnMuM?t=00h10m30s)

[because i'm sort of picturing a](https://youtu.be/oRci9ITnMuM?t=00h10m32s)

[hierarchy here](https://youtu.be/oRci9ITnMuM?t=00h10m34s)

[um i'm kind of envisioning](https://youtu.be/oRci9ITnMuM?t=00h10m36s)

[because our color picker let's look at](https://youtu.be/oRci9ITnMuM?t=00h10m40s)

[our color](https://youtu.be/oRci9ITnMuM?t=00h10m42s)

[picker](https://youtu.be/oRci9ITnMuM?t=00h10m44s)

[where did this guy go so we have](https://youtu.be/oRci9ITnMuM?t=00h10m46s)

[uh let's see](https://youtu.be/oRci9ITnMuM?t=00h10m50s)

[oh what is it called we have a pretty](https://youtu.be/oRci9ITnMuM?t=00h10m56s)

[color picker](https://youtu.be/oRci9ITnMuM?t=00h10m59s)

[palette](https://youtu.be/oRci9ITnMuM?t=00h11m01s)

[it's not under pickers it's under the](https://youtu.be/oRci9ITnMuM?t=00h11m05s)

[it's under the pretty](https://youtu.be/oRci9ITnMuM?t=00h11m07s)

[the theming stuff home buttons](https://youtu.be/oRci9ITnMuM?t=00h11m10s)

[cards color tool there we go](https://youtu.be/oRci9ITnMuM?t=00h11m14s)

[um](https://youtu.be/oRci9ITnMuM?t=00h11m17s)

[make this a little bigger uh we've got](https://youtu.be/oRci9ITnMuM?t=00h11m25s)

[this custom one here](https://youtu.be/oRci9ITnMuM?t=00h11m28s)

[this is more the one that i was hoping](https://youtu.be/oRci9ITnMuM?t=00h11m32s)

[to to bring in right](https://youtu.be/oRci9ITnMuM?t=00h11m33s)

[let let something let something change](https://youtu.be/oRci9ITnMuM?t=00h11m35s)

[about this here](https://youtu.be/oRci9ITnMuM?t=00h11m38s)

[because i'm also thinking that you](https://youtu.be/oRci9ITnMuM?t=00h11m40s)

[probably](https://youtu.be/oRci9ITnMuM?t=00h11m43s)

[like there's two colors in question that](https://youtu.be/oRci9ITnMuM?t=00h11m43s)

[you might want to set](https://youtu.be/oRci9ITnMuM?t=00h11m45s)

[the foreground and the background](https://youtu.be/oRci9ITnMuM?t=00h11m47s)

[might allow for changing both](https://youtu.be/oRci9ITnMuM?t=00h11m51s)

[that would seem reasonable right um](https://youtu.be/oRci9ITnMuM?t=00h11m57s)

[the only thing that's weird is this](https://youtu.be/oRci9ITnMuM?t=00h12m02s)

[color picker doesn't allow for](https://youtu.be/oRci9ITnMuM?t=00h12m04s)

[alpha](https://youtu.be/oRci9ITnMuM?t=00h12m08s)

[let's look i don't remember the support](https://youtu.be/oRci9ITnMuM?t=00h12m11s)

[for alpha](https://youtu.be/oRci9ITnMuM?t=00h12m13s)

[uh in here](https://youtu.be/oRci9ITnMuM?t=00h12m15s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=00h12m20s)

[um](https://youtu.be/oRci9ITnMuM?t=00h12m22s)

[uh png format](https://youtu.be/oRci9ITnMuM?t=00h12m25s)

[32 bits of color depth uh](https://youtu.be/oRci9ITnMuM?t=00h12m29s)

[i'm sort of thinking that other one](https://youtu.be/oRci9ITnMuM?t=00h12m39s)

[probably works](https://youtu.be/oRci9ITnMuM?t=00h12m41s)

[so we can get away with this there there](https://youtu.be/oRci9ITnMuM?t=00h12m43s)

[are a few notes here about like](https://youtu.be/oRci9ITnMuM?t=00h12m45s)

[backwards compatibility like png format](https://youtu.be/oRci9ITnMuM?t=00h12m47s)

[only being introduced](https://youtu.be/oRci9ITnMuM?t=00h12m49s)

[in windows vista this library doesn't](https://youtu.be/oRci9ITnMuM?t=00h12m50s)

[support stuff older than that so](https://youtu.be/oRci9ITnMuM?t=00h12m52s)

[i don't care me](https://youtu.be/oRci9ITnMuM?t=00h12m54s)

[we'll use all the things yeah let's just](https://youtu.be/oRci9ITnMuM?t=00h12m59s)

[bring let's just bring in a color picker](https://youtu.be/oRci9ITnMuM?t=00h13m01s)

[like this for now we'll worry about tr](https://youtu.be/oRci9ITnMuM?t=00h13m02s)

[we'll worry about transparency later so](https://youtu.be/oRci9ITnMuM?t=00h13m04s)

[let's go and get](https://youtu.be/oRci9ITnMuM?t=00h13m07s)

[so i guess that's the other thing so i i](https://youtu.be/oRci9ITnMuM?t=00h13m08s)

[want to have the the pack icon here](https://youtu.be/oRci9ITnMuM?t=00h13m10s)

[i probably want to have some sort of](https://youtu.be/oRci9ITnMuM?t=00h13m13s)

[color picker with a couple radio buttons](https://youtu.be/oRci9ITnMuM?t=00h13m17s)

[right so i'm going to want a radio](https://youtu.be/oRci9ITnMuM?t=00h13m19s)

[button with](https://youtu.be/oRci9ITnMuM?t=00h13m21s)

[content so something like foreground](https://youtu.be/oRci9ITnMuM?t=00h13m22s)

[right and then i'm going to want to have](https://youtu.be/oRci9ITnMuM?t=00h13m25s)

[something that has background](https://youtu.be/oRci9ITnMuM?t=00h13m28s)

[and then we probably want](https://youtu.be/oRci9ITnMuM?t=00h13m32s)

[let's see if we go to the color tool](https://youtu.be/oRci9ITnMuM?t=00h13m35s)

[here right](https://youtu.be/oRci9ITnMuM?t=00h13m36s)

[and really i want to grab](https://youtu.be/oRci9ITnMuM?t=00h13m38s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=00h13m43s)

[no i want to come down here into this](https://youtu.be/oRci9ITnMuM?t=00h13m45s)

[uh yeah this is what we want is the](https://youtu.be/oRci9ITnMuM?t=00h13m48s)

[color picker](https://youtu.be/oRci9ITnMuM?t=00h13m51s)

[so we're going to want to we want to](https://youtu.be/oRci9ITnMuM?t=00h13m55s)

[bring in a color picker](https://youtu.be/oRci9ITnMuM?t=00h13m56s)

[and we don't really need an x name](https://youtu.be/oRci9ITnMuM?t=00h14m00s)

[we're gonna need to bind this to](https://youtu.be/oRci9ITnMuM?t=00h14m03s)

[something i just don't know what yet](https://youtu.be/oRci9ITnMuM?t=00h14m04s)

[and we don't know what we're gonna do](https://youtu.be/oRci9ITnMuM?t=00h14m06s)

[with the](https://youtu.be/oRci9ITnMuM?t=00h14m08s)

[grid column so we're gonna do we're](https://youtu.be/oRci9ITnMuM?t=00h14m10s)

[gonna do something there](https://youtu.be/oRci9ITnMuM?t=00h14m12s)

[um and then i think the last thing we](https://youtu.be/oRci9ITnMuM?t=00h14m14s)

[need is a](https://youtu.be/oRci9ITnMuM?t=00h14m16s)

[a list of sizes um](https://youtu.be/oRci9ITnMuM?t=00h14m18s)

[yeah i think what i kind of want to do](https://youtu.be/oRci9ITnMuM?t=00h14m26s)

[is just have like](https://youtu.be/oRci9ITnMuM?t=00h14m28s)

[because in general you probably want all](https://youtu.be/oRci9ITnMuM?t=00h14m30s)

[the things and be done with it](https://youtu.be/oRci9ITnMuM?t=00h14m32s)

[so what is the hang on i think so in](https://youtu.be/oRci9ITnMuM?t=00h14m34s)

[paint.net i](https://youtu.be/oRci9ITnMuM?t=00h14m37s)

[installed an extension that does icos](https://youtu.be/oRci9ITnMuM?t=00h14m38s)

[file save as and i'm pretty sure if i](https://youtu.be/oRci9ITnMuM?t=00h14m45s)

[just pick](https://youtu.be/oRci9ITnMuM?t=00h14m48s)

[ico from here](https://youtu.be/oRci9ITnMuM?t=00h14m49s)

[save it pops a funky thing for me](https://youtu.be/oRci9ITnMuM?t=00h14m53s)

[i thought it had a fun dialogue to say](https://youtu.be/oRci9ITnMuM?t=00h14m59s)

[what size do you want](https://youtu.be/oRci9ITnMuM?t=00h15m01s)

[oh it does does just put it on the other](https://youtu.be/oRci9ITnMuM?t=00h15m04s)

[screen](https://youtu.be/oRci9ITnMuM?t=00h15m06s)

[so these sort of thing here um](https://youtu.be/oRci9ITnMuM?t=00h15m07s)

[i'm kind of wondering if we need to](https://youtu.be/oRci9ITnMuM?t=00h15m16s)

[support 8-bit](https://youtu.be/oRci9ITnMuM?t=00h15m18s)

[for anything like i realize there's](https://youtu.be/oRci9ITnMuM?t=00h15m20s)

[backwards compatibility deals with it](https://youtu.be/oRci9ITnMuM?t=00h15m22s)

[but i](https://youtu.be/oRci9ITnMuM?t=00h15m24s)

[i think everything we do can be 64-bit](https://youtu.be/oRci9ITnMuM?t=00h15m25s)

[let's see does this library even support](https://youtu.be/oRci9ITnMuM?t=00h15m28s)

[because if this library doesn't support](https://youtu.be/oRci9ITnMuM?t=00h15m31s)

[setting the](https://youtu.be/oRci9ITnMuM?t=00h15m33s)

[bitmap icon image so let's](https://youtu.be/oRci9ITnMuM?t=00h15m37s)

[uh bitmap icon image do you](https://youtu.be/oRci9ITnMuM?t=00h15m41s)

[do you even allow setting that or are](https://youtu.be/oRci9ITnMuM?t=00h15m44s)

[you just going to](https://youtu.be/oRci9ITnMuM?t=00h15m47s)

[control it format bits per pixel so it's](https://youtu.be/oRci9ITnMuM?t=00h15m48s)

[going to largely control it for me i](https://youtu.be/oRci9ITnMuM?t=00h15m51s)

[think we just](https://youtu.be/oRci9ITnMuM?t=00h15m53s)

[i think we just do resolutions and](https://youtu.be/oRci9ITnMuM?t=00h15m54s)

[you'll know all of these are basically](https://youtu.be/oRci9ITnMuM?t=00h15m56s)

[powers of two](https://youtu.be/oRci9ITnMuM?t=00h15m58s)

[so 16 24 32 48 64](https://youtu.be/oRci9ITnMuM?t=00h15m59s)

[00:16:08,320 --> 00:16:16,160](https://youtu.be/oRci9ITnMuM?t=00h16m06s)

and that is saying 256 is

[i wonder if there is a](https://youtu.be/oRci9ITnMuM?t=00h16m12s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=00h16m17s)

[let's see 256](https://youtu.be/oRci9ITnMuM?t=00h16m19s)

[i don't know if there's going to be any](https://youtu.be/oRci9ITnMuM?t=00h16m22s)

[obvious uh](https://youtu.be/oRci9ITnMuM?t=00h16m26s)

[see 256 color was the default so that's](https://youtu.be/oRci9ITnMuM?t=00h16m29s)

[8 bit](https://youtu.be/oRci9ITnMuM?t=00h16m32s)

[blah blah blah uh](https://youtu.be/oRci9ITnMuM?t=00h16m32s)

[let's see thus a single it could store](https://youtu.be/oRci9ITnMuM?t=00h16m36s)

[images of any size from one pixel](https://youtu.be/oRci9ITnMuM?t=00h16m38s)

[up to 256 pixels um](https://youtu.be/oRci9ITnMuM?t=00h16m40s)

[oh the notification was oh](https://youtu.be/oRci9ITnMuM?t=00h16m50s)

[until windows me again i don't care to](https://youtu.be/oRci9ITnMuM?t=00h16m53s)

[support those](https://youtu.be/oRci9ITnMuM?t=00h16m55s)

[uh 32-bit color we're gonna assume](https://youtu.be/oRci9ITnMuM?t=00h16m56s)

[everybody's running like](https://youtu.be/oRci9ITnMuM?t=00h16m59s)

[a supported version of windows for this](https://youtu.be/oRci9ITnMuM?t=00h17m00s)

[um](https://youtu.be/oRci9ITnMuM?t=00h17m03s)

[and go from there](https://youtu.be/oRci9ITnMuM?t=00h17m04s)

[yeah so i think we can just do the](https://youtu.be/oRci9ITnMuM?t=00h17m07s)

[32-bit all the way](https://youtu.be/oRci9ITnMuM?t=00h17m09s)

[and we'll just so here's what i'm here's](https://youtu.be/oRci9ITnMuM?t=00h17m10s)

[what i'm thinking](https://youtu.be/oRci9ITnMuM?t=00h17m13s)

[um i kind of wish i could screenshot](https://youtu.be/oRci9ITnMuM?t=00h17m14s)

[this list](https://youtu.be/oRci9ITnMuM?t=00h17m16s)

[uh let's just write it down real quick](https://youtu.be/oRci9ITnMuM?t=00h17m18s)

[we'll write it down real quick make a](https://youtu.be/oRci9ITnMuM?t=00h17m22s)

[quick note](https://youtu.be/oRci9ITnMuM?t=00h17m23s)

[so everybody's favorite note taking app](https://youtu.be/oRci9ITnMuM?t=00h17m25s)

[official studio code obviously](https://youtu.be/oRci9ITnMuM?t=00h17m27s)

[so let's see 256 128](https://youtu.be/oRci9ITnMuM?t=00h17m30s)

[uh let's see 64. 48](https://youtu.be/oRci9ITnMuM?t=00h17m33s)

[uh was it 32 24 16.](https://youtu.be/oRci9ITnMuM?t=00h17m36s)

[yeah so 32 24 16.](https://youtu.be/oRci9ITnMuM?t=00h17m40s)

[okay so those will be all the](https://youtu.be/oRci9ITnMuM?t=00h17m43s)

[resolutions we do](https://youtu.be/oRci9ITnMuM?t=00h17m44s)

[and i think what we're going to do just](https://youtu.be/oRci9ITnMuM?t=00h17m47s)

[put this to the side is](https://youtu.be/oRci9ITnMuM?t=00h17m49s)

[i'm kind of envisioning something like](https://youtu.be/oRci9ITnMuM?t=00h17m50s)

[an expander](https://youtu.be/oRci9ITnMuM?t=00h17m53s)

[right and i'm sort of picturing](https://youtu.be/oRci9ITnMuM?t=00h17m54s)

[something akin to so let's see a stack](https://youtu.be/oRci9ITnMuM?t=00h17m59s)

[panel](https://youtu.be/oRci9ITnMuM?t=00h18m02s)

[um](https://youtu.be/oRci9ITnMuM?t=00h18m03s)

[uh let's see how about we just do check](https://youtu.be/oRci9ITnMuM?t=00h18m09s)

[box](https://youtu.be/oRci9ITnMuM?t=00h18m11s)

[content to 56 by](https://youtu.be/oRci9ITnMuM?t=00h18m12s)

[256 right so we're going to do something](https://youtu.be/oRci9ITnMuM?t=00h18m15s)

[like that and actually you know what](https://youtu.be/oRci9ITnMuM?t=00h18m19s)

[we're going to do](https://youtu.be/oRci9ITnMuM?t=00h18m20s)

[come over here to vs code](https://youtu.be/oRci9ITnMuM?t=00h18m21s)

[we're going to search uh](https://youtu.be/oRci9ITnMuM?t=00h18m25s)

[see dot star uh turn on regex](https://youtu.be/oRci9ITnMuM?t=00h18m29s)

[uh we're gonna come down here we're](https://youtu.be/oRci9ITnMuM?t=00h18m33s)

[gonna paste this](https://youtu.be/oRci9ITnMuM?t=00h18m35s)

[we're gonna say let's see dollar sign](https://youtu.be/oRci9ITnMuM?t=00h18m36s)

[one](https://youtu.be/oRci9ITnMuM?t=00h18m40s)

[by uh dollar sign one](https://youtu.be/oRci9ITnMuM?t=00h18m40s)

[uh that isn't it what is the](https://youtu.be/oRci9ITnMuM?t=00h18m47s)

[project's match group is it zero](https://youtu.be/oRci9ITnMuM?t=00h18m51s)

[to give me the whole thing](https://youtu.be/oRci9ITnMuM?t=00h18m54s)

[there we are that's what i want boom](https://youtu.be/oRci9ITnMuM?t=00h18m58s)

[and now just like that i have converted](https://youtu.be/oRci9ITnMuM?t=00h19m02s)

[my list](https://youtu.be/oRci9ITnMuM?t=00h19m05s)

[into there so for people who are](https://youtu.be/oRci9ITnMuM?t=00h19m06s)

[unfamiliar with what just happened here](https://youtu.be/oRci9ITnMuM?t=00h19m07s)

[i'll undo and show this](https://youtu.be/oRci9ITnMuM?t=00h19m09s)

[so we made a list in here if you're](https://youtu.be/oRci9ITnMuM?t=00h19m11s)

[unfamiliar with regular expressions it](https://youtu.be/oRci9ITnMuM?t=00h19m13s)

[is definitely](https://youtu.be/oRci9ITnMuM?t=00h19m15s)

[a worthwhile thing to learn i find](https://youtu.be/oRci9ITnMuM?t=00h19m16s)

[that they can be incredibly useful the](https://youtu.be/oRci9ITnMuM?t=00h19m19s)

[running joke though is the moment you](https://youtu.be/oRci9ITnMuM?t=00h19m22s)

[solve a problem with regex now you have](https://youtu.be/oRci9ITnMuM?t=00h19m23s)

[two problems](https://youtu.be/oRci9ITnMuM?t=00h19m25s)

[but um uh red jexter](https://youtu.be/oRci9ITnMuM?t=00h19m26s)

[trying to remember this guy here this is](https://youtu.be/oRci9ITnMuM?t=00h19m31s)

[a wonderful library for](https://youtu.be/oRci9ITnMuM?t=00h19m32s)

[learning and experimenting with regexes](https://youtu.be/oRci9ITnMuM?t=00h19m34s)

[but what i did here is by default](https://youtu.be/oRci9ITnMuM?t=00h19m37s)

[this thing is going to match per line](https://youtu.be/oRci9ITnMuM?t=00h19m41s)

[it's not it's not going to span multiple](https://youtu.be/oRci9ITnMuM?t=00h19m43s)

[lines](https://youtu.be/oRci9ITnMuM?t=00h19m44s)

[and so the dot just means match any](https://youtu.be/oRci9ITnMuM?t=00h19m46s)

[character](https://youtu.be/oRci9ITnMuM?t=00h19m48s)

[and the star just says match any number](https://youtu.be/oRci9ITnMuM?t=00h19m49s)

[of characters so this just](https://youtu.be/oRci9ITnMuM?t=00h19m52s)

[swallows up each line and then in the](https://youtu.be/oRci9ITnMuM?t=00h19m53s)

[replacement pattern](https://youtu.be/oRci9ITnMuM?t=00h19m57s)

[dollar sign zero says grab the entire](https://youtu.be/oRci9ITnMuM?t=00h19m58s)

[thing that this matched](https://youtu.be/oRci9ITnMuM?t=00h20m00s)

[so let me just do a little replacement](https://youtu.be/oRci9ITnMuM?t=00h20m02s)

[and](https://youtu.be/oRci9ITnMuM?t=00h20m05s)

[poof write a bunch of code so](https://youtu.be/oRci9ITnMuM?t=00h20m07s)

[easy peasy so i'm picturing something](https://youtu.be/oRci9ITnMuM?t=00h20m11s)

[kind of like this](https://youtu.be/oRci9ITnMuM?t=00h20m13s)

[where this shows up something akin to](https://youtu.be/oRci9ITnMuM?t=00h20m17s)

[this and then we've got a save button](https://youtu.be/oRci9ITnMuM?t=00h20m19s)

[sort of what i'm thinking we got a color](https://youtu.be/oRci9ITnMuM?t=00h20m22s)

[picker we got a pack icon](https://youtu.be/oRci9ITnMuM?t=00h20m24s)

[this thing probably needs some sort of](https://youtu.be/oRci9ITnMuM?t=00h20m28s)

[like](https://youtu.be/oRci9ITnMuM?t=00h20m30s)

[i'm thinking this thing probably needs](https://youtu.be/oRci9ITnMuM?t=00h20m32s)

[some sort of like text block at the top](https://youtu.be/oRci9ITnMuM?t=00h20m33s)

[that's like uh uh](https://youtu.be/oRci9ITnMuM?t=00h20m36s)

[generate dot generate](https://youtu.be/oRci9ITnMuM?t=00h20m41s)

[icon dot ico file](https://youtu.be/oRci9ITnMuM?t=00h20m44s)

[right we'll make this obvious for people](https://youtu.be/oRci9ITnMuM?t=00h20m48s)

[um](https://youtu.be/oRci9ITnMuM?t=00h20m50s)

[just so that it's really clear what](https://youtu.be/oRci9ITnMuM?t=00h20m51s)

[we're doing here](https://youtu.be/oRci9ITnMuM?t=00h20m53s)

[and actually let's come here uh](https://youtu.be/oRci9ITnMuM?t=00h20m55s)

[typography i uh](https://youtu.be/oRci9ITnMuM?t=00h20m59s)

[let's do this in like](https://youtu.be/oRci9ITnMuM?t=00h21m02s)

[this one here](https://youtu.be/oRci9ITnMuM?t=00h21m06s)

[yeah like a medium](https://youtu.be/oRci9ITnMuM?t=00h21m14s)

[that looks that looks nice uh](https://youtu.be/oRci9ITnMuM?t=00h21m17s)

[let's see style gets boom so we'll do](https://youtu.be/oRci9ITnMuM?t=00h21m21s)

[something like that](https://youtu.be/oRci9ITnMuM?t=00h21m24s)

[uh okay so let's lay this grid out of](https://youtu.be/oRci9ITnMuM?t=00h21m26s)

[what i](https://youtu.be/oRci9ITnMuM?t=00h21m28s)

[think this is going to do i'm sort of](https://youtu.be/oRci9ITnMuM?t=00h21m29s)

[picturing](https://youtu.be/oRci9ITnMuM?t=00h21m31s)

[sort of picturing maybe this goes down](https://youtu.be/oRci9ITnMuM?t=00h21m34s)

[here](https://youtu.be/oRci9ITnMuM?t=00h21m37s)

[and maybe this doesn't need to be a grid](https://youtu.be/oRci9ITnMuM?t=00h21m39s)

[maybe this can just be a s](https://youtu.be/oRci9ITnMuM?t=00h21m40s)

[panel](https://youtu.be/oRci9ITnMuM?t=00h21m43s)

[uh what are you squawking about](https://youtu.be/oRci9ITnMuM?t=00h21m48s)

[huh that looks like a bug](https://youtu.be/oRci9ITnMuM?t=00h21m53s)

[um the fact that the expander is](https://youtu.be/oRci9ITnMuM?t=00h21m57s)

[squawking at me for](https://youtu.be/oRci9ITnMuM?t=00h21m58s)

[is not a valid value](https://youtu.be/oRci9ITnMuM?t=00h22m03s)

[i don't i can't tell if this is a](https://youtu.be/oRci9ITnMuM?t=00h22m08s)

[designer failure or if this is a](https://youtu.be/oRci9ITnMuM?t=00h22m09s)

[legitimate bug](https://youtu.be/oRci9ITnMuM?t=00h22m11s)

[but let's see so stack panel with some](https://youtu.be/oRci9ITnMuM?t=00h22m12s)

[width we got a title there](https://youtu.be/oRci9ITnMuM?t=00h22m14s)

[um we're going to put the icon right at](https://youtu.be/oRci9ITnMuM?t=00h22m16s)

[the top](https://youtu.be/oRci9ITnMuM?t=00h22m19s)

[i think and i think what we're going to](https://youtu.be/oRci9ITnMuM?t=00h22m20s)

[do here is let's do a like a height](https://youtu.be/oRci9ITnMuM?t=00h22m22s)

[of 30 a width of 30](https://youtu.be/oRci9ITnMuM?t=00h22m24s)

[and then let's just put it in the middle](https://youtu.be/oRci9ITnMuM?t=00h22m27s)

[so horizontal alignment center](https://youtu.be/oRci9ITnMuM?t=00h22m30s)

[so we'll put that guy up and i think](https://youtu.be/oRci9ITnMuM?t=00h22m32s)

[what i want to do is i want to do](https://youtu.be/oRci9ITnMuM?t=00h22m34s)

[see stack panel orientation horizontal](https://youtu.be/oRci9ITnMuM?t=00h22m36s)

[and i think i'm going to put these radio](https://youtu.be/oRci9ITnMuM?t=00h22m39s)

[buttons right next to each other](https://youtu.be/oRci9ITnMuM?t=00h22m40s)

[so that it's foreground background](https://youtu.be/oRci9ITnMuM?t=00h22m43s)

[uh this guy should start checked](https://youtu.be/oRci9ITnMuM?t=00h22m46s)

[all right this guy will come in here](https://youtu.be/oRci9ITnMuM?t=00h22m50s)

[we'll have a color picker we'll have an](https://youtu.be/oRci9ITnMuM?t=00h22m54s)

[expander](https://youtu.be/oRci9ITnMuM?t=00h22m56s)

[and all of these guys should really](https://youtu.be/oRci9ITnMuM?t=00h22m57s)

[start in their checked](https://youtu.be/oRci9ITnMuM?t=00h22m59s)

[state](https://youtu.be/oRci9ITnMuM?t=00h23m00s)

[uh so let's undo this and let's do](https://youtu.be/oRci9ITnMuM?t=00h23m03s)

[is checked gets true](https://youtu.be/oRci9ITnMuM?t=00h23m06s)

[grab that auto code for the win](https://youtu.be/oRci9ITnMuM?t=00h23m16s)

[and then a save button at the bottom but](https://youtu.be/oRci9ITnMuM?t=00h23m22s)

[i think i want a horizontal alignment](https://youtu.be/oRci9ITnMuM?t=00h23m23s)

[right i want to](https://youtu.be/oRci9ITnMuM?t=00h23m25s)

[shift that guy over okay so let's see](https://youtu.be/oRci9ITnMuM?t=00h23m26s)

[how this looks oh this is not going to](https://youtu.be/oRci9ITnMuM?t=00h23m28s)

[work with the demo app currently running](https://youtu.be/oRci9ITnMuM?t=00h23m30s)

[turn that off](https://youtu.be/oRci9ITnMuM?t=00h23m33s)

[see how this we'll see how this works](https://youtu.be/oRci9ITnMuM?t=00h23m37s)

[and let's see here so icon](https://youtu.be/oRci9ITnMuM?t=00h23m40s)

[pack](https://youtu.be/oRci9ITnMuM?t=00h23m44s)

[got this little guy here we might change](https://youtu.be/oRci9ITnMuM?t=00h23m47s)

[that at some point](https://youtu.be/oRci9ITnMuM?t=00h23m49s)

[oop let's bring you down](https://youtu.be/oRci9ITnMuM?t=00h23m52s)

[uh let's see so oh we should pick an](https://youtu.be/oRci9ITnMuM?t=00h23m58s)

[icon](https://youtu.be/oRci9ITnMuM?t=00h24m01s)

[so we should probably disable that](https://youtu.be/oRci9ITnMuM?t=00h24m03s)

[there's foreground there's background](https://youtu.be/oRci9ITnMuM?t=00h24m05s)

[this is not the color picker i thought i](https://youtu.be/oRci9ITnMuM?t=00h24m10s)

[was getting](https://youtu.be/oRci9ITnMuM?t=00h24m13s)

[my expander works the way i would expect](https://youtu.be/oRci9ITnMuM?t=00h24m15s)

[uh let's see though let's see so this](https://youtu.be/oRci9ITnMuM?t=00h24m20s)

[guy's header needs to be](https://youtu.be/oRci9ITnMuM?t=00h24m23s)

[uh resolutions sizes](https://youtu.be/oRci9ITnMuM?t=00h24m26s)

[what did the what the wikipedia page](https://youtu.be/oRci9ITnMuM?t=00h24m30s)

[call them](https://youtu.be/oRci9ITnMuM?t=00h24m32s)

[uh](https://youtu.be/oRci9ITnMuM?t=00h24m34s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=00h24m40s)

[resolutions](https://youtu.be/oRci9ITnMuM?t=00h24m42s)

[uh](https://youtu.be/oRci9ITnMuM?t=00h24m45s)

[uh image size](https://youtu.be/oRci9ITnMuM?t=00h24m48s)

[so we'll just do image sizes](https://youtu.be/oRci9ITnMuM?t=00h24m53s)

[do that](https://youtu.be/oRci9ITnMuM?t=00h24m57s)

[let's see here so](https://youtu.be/oRci9ITnMuM?t=00h25m00s)

[something something akin to that isn't](https://youtu.be/oRci9ITnMuM?t=00h25m04s)

[bad](https://youtu.be/oRci9ITnMuM?t=00h25m07s)

[and then a save button on the end that](https://youtu.be/oRci9ITnMuM?t=00h25m11s)

[should go and do something](https://youtu.be/oRci9ITnMuM?t=00h25m13s)

[so a couple of things i'm noticing i](https://youtu.be/oRci9ITnMuM?t=00h25m14s)

[want a little bit bigger size on my icon](https://youtu.be/oRci9ITnMuM?t=00h25m17s)

[i want a little spacing between those](https://youtu.be/oRci9ITnMuM?t=00h25m20s)

[radio buttons so we're going to do](https://youtu.be/oRci9ITnMuM?t=00h25m22s)

[a little bit of margin here](https://youtu.be/oRci9ITnMuM?t=00h25m24s)

[something like that](https://youtu.be/oRci9ITnMuM?t=00h25m28s)

[so that's that's pretty good spacing](https://youtu.be/oRci9ITnMuM?t=00h25m32s)

[there](https://youtu.be/oRci9ITnMuM?t=00h25m34s)

[we'll come over here we're gonna do a](https://youtu.be/oRci9ITnMuM?t=00h25m35s)

[little bit bigger here so let's do like](https://youtu.be/oRci9ITnMuM?t=00h25m38s)

[40 by 40 and see how that looks](https://youtu.be/oRci9ITnMuM?t=00h25m39s)

[and then also let's throw a little bit](https://youtu.be/oRci9ITnMuM?t=00h25m42s)

[of a](https://youtu.be/oRci9ITnMuM?t=00h25m44s)

[margin around it just to give it some](https://youtu.be/oRci9ITnMuM?t=00h25m46s)

[space](https://youtu.be/oRci9ITnMuM?t=00h25m48s)

[now that looks a little nicer though i](https://youtu.be/oRci9ITnMuM?t=00h25m51s)

[am wondering if maybe i should just kick](https://youtu.be/oRci9ITnMuM?t=00h25m54s)

[this thing](https://youtu.be/oRci9ITnMuM?t=00h25m55s)

[over to the side here we might we might](https://youtu.be/oRci9ITnMuM?t=00h25m56s)

[do that](https://youtu.be/oRci9ITnMuM?t=00h25m59s)

[we might just uh kick this icon up we'll](https://youtu.be/oRci9ITnMuM?t=00h26m00s)

[see how this goes](https://youtu.be/oRci9ITnMuM?t=00h26m03s)

[the color picker now i i clearly grabbed](https://youtu.be/oRci9ITnMuM?t=00h26m04s)

[the wrong thing](https://youtu.be/oRci9ITnMuM?t=00h26m06s)

[uh where is](https://youtu.be/oRci9ITnMuM?t=00h26m08s)

[uh radio button](https://youtu.be/oRci9ITnMuM?t=00h26m13s)

[color picker i want the](https://youtu.be/oRci9ITnMuM?t=00h26m19s)

[i don't see what i am looking for](https://youtu.be/oRci9ITnMuM?t=00h26m24s)

[uniform grid secondary selection](https://youtu.be/oRci9ITnMuM?t=00h26m34s)

[so let's just start collapsing these](https://youtu.be/oRci9ITnMuM?t=00h26m38s)

[things](https://youtu.be/oRci9ITnMuM?t=00h26m39s)

[uh primary mid selection](https://youtu.be/oRci9ITnMuM?t=00h26m41s)

[don't care about you selection controls](https://youtu.be/oRci9ITnMuM?t=00h26m46s)

[current scheme label](https://youtu.be/oRci9ITnMuM?t=00h26m50s)

[okay so these are all just the resources](https://youtu.be/oRci9ITnMuM?t=00h26m53s)

[up here](https://youtu.be/oRci9ITnMuM?t=00h26m56s)

[so where is color picker section](https://youtu.be/oRci9ITnMuM?t=00h26m57s)

[uh custom is checked boolean to](https://youtu.be/oRci9ITnMuM?t=00h27m03s)

[visibility converter so this](https://youtu.be/oRci9ITnMuM?t=00h27m06s)

[is the custom side](https://youtu.be/oRci9ITnMuM?t=00h27m07s)

[uh this is bound to color picker](https://youtu.be/oRci9ITnMuM?t=00h27m11s)

[wait](https://youtu.be/oRci9ITnMuM?t=00h27m18s)

[i am confused color tool](https://youtu.be/oRci9ITnMuM?t=00h27m22s)

[i want](https://youtu.be/oRci9ITnMuM?t=00h27m26s)

[i want this thingy not this thingy so](https://youtu.be/oRci9ITnMuM?t=00h27m32s)

[it's the thing above it](https://youtu.be/oRci9ITnMuM?t=00h27m34s)

[grid dock panel](https://youtu.be/oRci9ITnMuM?t=00h27m39s)

[uh items control swatches](https://youtu.be/oRci9ITnMuM?t=00h27m46s)

[something is](https://youtu.be/oRci9ITnMuM?t=00h27m52s)

[something is amiss why am i not finding](https://youtu.be/oRci9ITnMuM?t=00h27m55s)

[what i](https://youtu.be/oRci9ITnMuM?t=00h27m58s)

[expect to find so this guy here is the](https://youtu.be/oRci9ITnMuM?t=00h27m59s)

[color picker](https://youtu.be/oRci9ITnMuM?t=00h28m02s)

[oh is there a different style i need to](https://youtu.be/oRci9ITnMuM?t=00h28m07s)

[apply to it](https://youtu.be/oRci9ITnMuM?t=00h28m09s)

[uh that's just the](https://youtu.be/oRci9ITnMuM?t=00h28m12s)

[huh](https://youtu.be/oRci9ITnMuM?t=00h28m16s)

[color picker](https://youtu.be/oRci9ITnMuM?t=00h28m25s)

[so i have this guy i have this guy](https://youtu.be/oRci9ITnMuM?t=00h28m31s)

[both of these are](https://youtu.be/oRci9ITnMuM?t=00h28m35s)

[awesome color pickers we should probably](https://youtu.be/oRci9ITnMuM?t=00h28m39s)

[allow typing in a hex value](https://youtu.be/oRci9ITnMuM?t=00h28m42s)

[too because nothing is more frustrating](https://youtu.be/oRci9ITnMuM?t=00h28m44s)

[than having a designer](https://youtu.be/oRci9ITnMuM?t=00h28m46s)

[that has handed you ooh we got a lot of](https://youtu.be/oRci9ITnMuM?t=00h28m48s)

[bind values nothing's more frustrating](https://youtu.be/oRci9ITnMuM?t=00h28m50s)

[than when your designer gives you a hex](https://youtu.be/oRci9ITnMuM?t=00h28m52s)

[value and it's difficult to use](https://youtu.be/oRci9ITnMuM?t=00h28m53s)

[that should be easy so this is this is](https://youtu.be/oRci9ITnMuM?t=00h28m57s)

[the](https://youtu.be/oRci9ITnMuM?t=00h28m59s)

[material design palette so this is all](https://youtu.be/oRci9ITnMuM?t=00h29m01s)

[of that so this is all that is up there](https://youtu.be/oRci9ITnMuM?t=00h29m03s)

[why am i missing it](https://youtu.be/oRci9ITnMuM?t=00h29m07s)

[oh is it because it doesn't have size](https://youtu.be/oRci9ITnMuM?t=00h29m15s)

[allocated to it um](https://youtu.be/oRci9ITnMuM?t=00h29m19s)

[is that the issue that it just needs](https://youtu.be/oRci9ITnMuM?t=00h29m23s)

[more](https://youtu.be/oRci9ITnMuM?t=00h29m27s)

[uh because i slapped it into a](https://youtu.be/oRci9ITnMuM?t=00h29m27s)

[let's do this min height 100.](https://youtu.be/oRci9ITnMuM?t=00h29m32s)

[that is the problem](https://youtu.be/oRci9ITnMuM?t=00h29m43s)

[the thing needs a better minimum height](https://youtu.be/oRci9ITnMuM?t=00h29m46s)

[we might go fix that on the control i](https://youtu.be/oRci9ITnMuM?t=00h29m50s)

[think i think there should](https://youtu.be/oRci9ITnMuM?t=00h29m52s)

[probably be some](https://youtu.be/oRci9ITnMuM?t=00h29m54s)

[min height set by default so that that](https://youtu.be/oRci9ITnMuM?t=00h29m57s)

[doesn't happen](https://youtu.be/oRci9ITnMuM?t=00h29m59s)

[that also implies that now i've got this](https://youtu.be/oRci9ITnMuM?t=00h30m00s)

[little bit of an issue here](https://youtu.be/oRci9ITnMuM?t=00h30m02s)

[so let's do let's do a little bit](https://youtu.be/oRci9ITnMuM?t=00h30m04s)

[of a vertical margin so nothing there](https://youtu.be/oRci9ITnMuM?t=00h30m08s)

[but a little above and below would be](https://youtu.be/oRci9ITnMuM?t=00h30m10s)

[nice](https://youtu.be/oRci9ITnMuM?t=00h30m12s)

[see how that looks that's a little bit](https://youtu.be/oRci9ITnMuM?t=00h30m13s)

[nicer](https://youtu.be/oRci9ITnMuM?t=00h30m16s)

[yeah so now we can do now we can do this](https://youtu.be/oRci9ITnMuM?t=00h30m18s)

[maneuver here](https://youtu.be/oRci9ITnMuM?t=00h30m20s)

[right so that'll work but what we need](https://youtu.be/oRci9ITnMuM?t=00h30m22s)

[to do is actually](https://youtu.be/oRci9ITnMuM?t=00h30m25s)

[change change this](https://youtu.be/oRci9ITnMuM?t=00h30m26s)

[so](https://youtu.be/oRci9ITnMuM?t=00h30m29s)

[we how do we want to go about doing this](https://youtu.be/oRci9ITnMuM?t=00h30m34s)

[so based on which radio button is](https://youtu.be/oRci9ITnMuM?t=00h30m37s)

[selected we want to change](https://youtu.be/oRci9ITnMuM?t=00h30m38s)

[the background of this image](https://youtu.be/oRci9ITnMuM?t=00h30m41s)

[all right and i think let's see](https://youtu.be/oRci9ITnMuM?t=00h30m47s)

[so we want to be able to change that guy](https://youtu.be/oRci9ITnMuM?t=00h30m51s)

[um](https://youtu.be/oRci9ITnMuM?t=00h30m55s)

[i'm thinking we probably should set up a](https://youtu.be/oRci9ITnMuM?t=00h30m59s)

[bit of a view model to play with here](https://youtu.be/oRci9ITnMuM?t=00h31m01s)

[because we're already bound here and](https://youtu.be/oRci9ITnMuM?t=00h31m05s)

[here](https://youtu.be/oRci9ITnMuM?t=00h31m08s)

[i'm just trying to decide what the](https://youtu.be/oRci9ITnMuM?t=00h31m11s)

[easiest way is to go about doing this i](https://youtu.be/oRci9ITnMuM?t=00h31m12s)

[think setting up a style on this guy](https://youtu.be/oRci9ITnMuM?t=00h31m14s)

[with some triggers to](https://youtu.be/oRci9ITnMuM?t=00h31m16s)

[toggle the color binding](https://youtu.be/oRci9ITnMuM?t=00h31m18s)

[probably makes the most sense](https://youtu.be/oRci9ITnMuM?t=00h31m21s)

[um](https://youtu.be/oRci9ITnMuM?t=00h31m30s)

[is that true](https://youtu.be/oRci9ITnMuM?t=00h31m34s)

[probably so let's give this guy a name](https://youtu.be/oRci9ITnMuM?t=00h31m38s)

[uh let's see icon foreground](https://youtu.be/oRci9ITnMuM?t=00h31m41s)

[sure we're gonna go with that for the](https://youtu.be/oRci9ITnMuM?t=00h31m47s)

[moment um](https://youtu.be/oRci9ITnMuM?t=00h31m49s)

[so if we do that](https://youtu.be/oRci9ITnMuM?t=00h31m52s)

[yeah so let's let's expand this guy out](https://youtu.be/oRci9ITnMuM?t=00h31m58s)

[here](https://youtu.be/oRci9ITnMuM?t=00h32m01s)

[and we will do uh](https://youtu.be/oRci9ITnMuM?t=00h32m02s)

[material design color picker](https://youtu.be/oRci9ITnMuM?t=00h32m05s)

[nope and i want to set a style](https://youtu.be/oRci9ITnMuM?t=00h32m09s)

[and close that guy and we'll generate a](https://youtu.be/oRci9ITnMuM?t=00h32m13s)

[new style](https://youtu.be/oRci9ITnMuM?t=00h32m16s)

[uh let's see target type uh](https://youtu.be/oRci9ITnMuM?t=00h32m18s)

[material design](https://youtu.be/oRci9ITnMuM?t=00h32m22s)

[okay okay i can't type copy and paste](https://youtu.be/oRci9ITnMuM?t=00h32m30s)

[sounds great](https://youtu.be/oRci9ITnMuM?t=00h32m33s)

[uh and then we want to base this on](https://youtu.be/oRci9ITnMuM?t=00h32m36s)

[the default style that was being applied](https://youtu.be/oRci9ITnMuM?t=00h32m40s)

[there before](https://youtu.be/oRci9ITnMuM?t=00h32m43s)

[so by default styles always have](https://youtu.be/oRci9ITnMuM?t=00h32m43s)

[an implicit key of the target type and](https://youtu.be/oRci9ITnMuM?t=00h32m47s)

[that is getting really hard to read with](https://youtu.be/oRci9ITnMuM?t=00h32m50s)

[all of this stuff open so we're just](https://youtu.be/oRci9ITnMuM?t=00h32m52s)

[going to start collapsing some stuff](https://youtu.be/oRci9ITnMuM?t=00h32m53s)

[down](https://youtu.be/oRci9ITnMuM?t=00h32m54s)

[there we go now we can see what we're](https://youtu.be/oRci9ITnMuM?t=00h32m55s)

[doing uh let's see](https://youtu.be/oRci9ITnMuM?t=00h32m57s)

[uh format that so](https://youtu.be/oRci9ITnMuM?t=00h32m59s)

[we're gonna do some triggers now so](https://youtu.be/oRci9ITnMuM?t=00h33m03s)

[let's do a trigger](https://youtu.be/oRci9ITnMuM?t=00h33m05s)

[we will do a data trigger with a](https://youtu.be/oRci9ITnMuM?t=00h33m07s)

[binding the binding is going to look](https://youtu.be/oRci9ITnMuM?t=00h33m10s)

[at icon](https://youtu.be/oRci9ITnMuM?t=00h33m14s)

[foreground](https://youtu.be/oRci9ITnMuM?t=00h33m17s)

[uh let's see and it will look at the is](https://youtu.be/oRci9ITnMuM?t=00h33m20s)

[checked](https://youtu.be/oRci9ITnMuM?t=00h33m24s)

[property and if that value is](https://youtu.be/oRci9ITnMuM?t=00h33m25s)

[true we are going to](https://youtu.be/oRci9ITnMuM?t=00h33m29s)

[set the color property of our control](https://youtu.be/oRci9ITnMuM?t=00h33m34s)

[to a binding it looks kind of like this](https://youtu.be/oRci9ITnMuM?t=00h33m40s)

[that'll be a starting point but it's](https://youtu.be/oRci9ITnMuM?t=00h33m47s)

[actually going to change it](https://youtu.be/oRci9ITnMuM?t=00h33m50s)

[on let's see let's give this guy a name](https://youtu.be/oRci9ITnMuM?t=00h33m52s)

[x name](https://youtu.be/oRci9ITnMuM?t=00h33m55s)

[it's weird because i want to call this](https://youtu.be/oRci9ITnMuM?t=00h34m04s)

[icon but we're we're using a pack icon](https://youtu.be/oRci9ITnMuM?t=00h34m05s)

[um gener](https://youtu.be/oRci9ITnMuM?t=00h34m09s)

[uh how about](https://youtu.be/oRci9ITnMuM?t=00h34m12s)

[selected icon uh whatever](https://youtu.be/oRci9ITnMuM?t=00h34m16s)

[we'll work with it uh so let's see so](https://youtu.be/oRci9ITnMuM?t=00h34m20s)

[this is gonna be element name](https://youtu.be/oRci9ITnMuM?t=00h34m22s)

[selected icon and](https://youtu.be/oRci9ITnMuM?t=00h34m24s)

[more importantly this is going to be](https://youtu.be/oRci9ITnMuM?t=00h34m28s)

[bound to](https://youtu.be/oRci9ITnMuM?t=00h34m30s)

[foreground now we may](https://youtu.be/oRci9ITnMuM?t=00h34m33s)

[trying to remember this color property](https://youtu.be/oRci9ITnMuM?t=00h34m37s)

[if it's a color or if it's a brush](https://youtu.be/oRci9ITnMuM?t=00h34m40s)

[it's a color](https://youtu.be/oRci9ITnMuM?t=00h34m42s)

[that's exciting um](https://youtu.be/oRci9ITnMuM?t=00h34m47s)

[i think i can get away with this](https://youtu.be/oRci9ITnMuM?t=00h34m51s)

[i don't remember exactly uh but let's go](https://youtu.be/oRci9ITnMuM?t=00h34m54s)

[up here so what we also want is we now](https://youtu.be/oRci9ITnMuM?t=00h34m58s)

[want the else case as well](https://youtu.be/oRci9ITnMuM?t=00h35m00s)

[we want this to be background color](https://youtu.be/oRci9ITnMuM?t=00h35m02s)

[we may end up needing to set some](https://youtu.be/oRci9ITnMuM?t=00h35m08s)

[foregrounds and backgrounds on here](https://youtu.be/oRci9ITnMuM?t=00h35m10s)

[i don't remember so let's do that i](https://youtu.be/oRci9ITnMuM?t=00h35m12s)

[don't know if this is going to](https://youtu.be/oRci9ITnMuM?t=00h35m15s)

[if the edit and continue is going to](https://youtu.be/oRci9ITnMuM?t=00h35m16s)

[work for me here](https://youtu.be/oRci9ITnMuM?t=00h35m18s)

[if i do background](https://youtu.be/oRci9ITnMuM?t=00h35m19s)

[foreground it's not adjusting so we're](https://youtu.be/oRci9ITnMuM?t=00h35m23s)

[going to restart](https://youtu.be/oRci9ITnMuM?t=00h35m27s)

[because i don't have a lot of faith in](https://youtu.be/oRci9ITnMuM?t=00h35m29s)

[the edit and continue to keep up with](https://youtu.be/oRci9ITnMuM?t=00h35m31s)

[all those changes](https://youtu.be/oRci9ITnMuM?t=00h35m32s)

[the hot reload stuff inside of](https://youtu.be/oRci9ITnMuM?t=00h35m39s)

[xaml is really great but there is a](https://youtu.be/oRci9ITnMuM?t=00h35m43s)

[limit to how much you can keep up with](https://youtu.be/oRci9ITnMuM?t=00h35m46s)

[okay so let's go we gotta pick on one](https://youtu.be/oRci9ITnMuM?t=00h35m49s)

[right uh](https://youtu.be/oRci9ITnMuM?t=00h35m56s)

[not seeing you change seeing a lot more](https://youtu.be/oRci9ITnMuM?t=00h35m58s)

[binding failures](https://youtu.be/oRci9ITnMuM?t=00h36m01s)

[uh let's see combine duplicates](https://youtu.be/oRci9ITnMuM?t=00h36m06s)

[cannot say value back to source target](https://youtu.be/oRci9ITnMuM?t=00h36m13s)

[element is](https://youtu.be/oRci9ITnMuM?t=00h36m15s)

[color invalid operation because it is in](https://youtu.be/oRci9ITnMuM?t=00h36m17s)

[a read-only state okay](https://youtu.be/oRci9ITnMuM?t=00h36m20s)

[so it is so we're gonna have to do](https://youtu.be/oRci9ITnMuM?t=00h36m21s)

[we're gonna have to do a brush converter](https://youtu.be/oRci9ITnMuM?t=00h36m25s)

[and i let's see](https://youtu.be/oRci9ITnMuM?t=00h36m27s)

[brush color to brush converter that's](https://youtu.be/oRci9ITnMuM?t=00h36m29s)

[exactly what i want](https://youtu.be/oRci9ITnMuM?t=00h36m33s)

[one of these thingies](https://youtu.be/oRci9ITnMuM?t=00h36m34s)

[yeah it's almost like we've done this](https://youtu.be/oRci9ITnMuM?t=00h36m38s)

[before](https://youtu.be/oRci9ITnMuM?t=00h36m41s)

[so let's see do we already have this guy](https://youtu.be/oRci9ITnMuM?t=00h36m42s)

[oh we want this one do we already have](https://youtu.be/oRci9ITnMuM?t=00h36m44s)

[that guy referenced uh we](https://youtu.be/oRci9ITnMuM?t=00h36m47s)

[don't hear let me just check and see](https://youtu.be/oRci9ITnMuM?t=00h36m50s)

[because some of the converters are](https://youtu.be/oRci9ITnMuM?t=00h36m53s)

[registered globally](https://youtu.be/oRci9ITnMuM?t=00h36m54s)

[which isn't a great practice but okay](https://youtu.be/oRci9ITnMuM?t=00h36m57s)

[maybe not maybe we got rid of them all](https://youtu.be/oRci9ITnMuM?t=00h36m59s)

[cool so we will go](https://youtu.be/oRci9ITnMuM?t=00h37m03s)

[converters uh let's see color to brush](https://youtu.be/oRci9ITnMuM?t=00h37m07s)

[converter](https://youtu.be/oRci9ITnMuM?t=00h37m11s)

[i usually just name them to match](https://youtu.be/oRci9ITnMuM?t=00h37m13s)

[because](https://youtu.be/oRci9ITnMuM?t=00h37m15s)

[that keeps everything nice and simple](https://youtu.be/oRci9ITnMuM?t=00h37m16s)

[there we go so now we've got one of](https://youtu.be/oRci9ITnMuM?t=00h37m21s)

[those guys to play with](https://youtu.be/oRci9ITnMuM?t=00h37m23s)

[now we come down here uh](https://youtu.be/oRci9ITnMuM?t=00h37m24s)

[we'll put it before the delay i guess](https://youtu.be/oRci9ITnMuM?t=00h37m28s)

[converter](https://youtu.be/oRci9ITnMuM?t=00h37m31s)

[static resource](https://youtu.be/oRci9ITnMuM?t=00h37m33s)

[color to brush](https://youtu.be/oRci9ITnMuM?t=00h37m37s)

[converter](https://youtu.be/oRci9ITnMuM?t=00h37m40s)

[same thing down here slap that guy](https://youtu.be/oRci9ITnMuM?t=00h37m45s)

[in let's give that another shot](https://youtu.be/oRci9ITnMuM?t=00h37m49s)

[we are eventually going to need to bind](https://youtu.be/oRci9ITnMuM?t=00h37m59s)

[this into something in our view model](https://youtu.be/oRci9ITnMuM?t=00h38m01s)

[but this will just let us play with it](https://youtu.be/oRci9ITnMuM?t=00h38m04s)

[for now](https://youtu.be/oRci9ITnMuM?t=00h38m05s)

[icon pack](https://youtu.be/oRci9ITnMuM?t=00h38m08s)

[oh we gotta pick on one should probably](https://youtu.be/oRci9ITnMuM?t=00h38m13s)

[disable that](https://youtu.be/oRci9ITnMuM?t=00h38m16s)

[does not appear to be working grumble](https://youtu.be/oRci9ITnMuM?t=00h38m21s)

[grumble grumble grumble](https://youtu.be/oRci9ITnMuM?t=00h38m23s)

[background](https://youtu.be/oRci9ITnMuM?t=00h38m25s)

[uh let's see](https://youtu.be/oRci9ITnMuM?t=00h38m30s)

[uh i can't find my binding windows boom](https://youtu.be/oRci9ITnMuM?t=00h38m35s)

[that button](https://youtu.be/oRci9ITnMuM?t=00h38m39s)

[see it there](https://youtu.be/oRci9ITnMuM?t=00h38m46s)

[it's getting hot in my office](https://youtu.be/oRci9ITnMuM?t=00h38m49s)

[it is no longer winter time](https://youtu.be/oRci9ITnMuM?t=00h38m54s)

[okay well let's let's just bite the](https://youtu.be/oRci9ITnMuM?t=00h38m59s)

[bullet and](https://youtu.be/oRci9ITnMuM?t=00h39m01s)

[go and update this view model i guess](https://youtu.be/oRci9ITnMuM?t=00h39m02s)

[because we're gonna end up needing that](https://youtu.be/oRci9ITnMuM?t=00h39m04s)

[anyway](https://youtu.be/oRci9ITnMuM?t=00h39m05s)

[uh so let's just oh so coolest thing in](https://youtu.be/oRci9ITnMuM?t=00h39m08s)

[the world](https://youtu.be/oRci9ITnMuM?t=00h39m11s)

[so for anybody who hasn't seen this yet](https://youtu.be/oRci9ITnMuM?t=00h39m13s)

[so if you've got](https://youtu.be/oRci9ITnMuM?t=00h39m16s)

[i'm not entirely sure which version of](https://youtu.be/oRci9ITnMuM?t=00h39m18s)

[visual studio one of the latest previews](https://youtu.be/oRci9ITnMuM?t=00h39m19s)

[um if you go down into your preview](https://youtu.be/oRci9ITnMuM?t=00h39m22s)

[features if you come down in here](https://youtu.be/oRci9ITnMuM?t=00h39m24s)

[there is this](https://youtu.be/oRci9ITnMuM?t=00h39m28s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=00h39m31s)

[xaml preview features to improve mvvm](https://youtu.be/oRci9ITnMuM?t=00h39m34s)

[productivity](https://youtu.be/oRci9ITnMuM?t=00h39m37s)

[this box you want to go turn on this is](https://youtu.be/oRci9ITnMuM?t=00h39m39s)

[cool](https://youtu.be/oRci9ITnMuM?t=00h39m42s)

[let's let me show you so there's a](https://youtu.be/oRci9ITnMuM?t=00h39m42s)

[couple there's a couple magical things](https://youtu.be/oRci9ITnMuM?t=00h39m45s)

[that it does](https://youtu.be/oRci9ITnMuM?t=00h39m47s)

[so one you'll know this thing already](https://youtu.be/oRci9ITnMuM?t=00h39m48s)

[has the](https://youtu.be/oRci9ITnMuM?t=00h39m50s)

[the design time data context right so](https://youtu.be/oRci9ITnMuM?t=00h39m51s)

[we're just gonna we're gonna get rid of](https://youtu.be/oRci9ITnMuM?t=00h39m53s)

[that for a moment](https://youtu.be/oRci9ITnMuM?t=00h39m54s)

[because setting that up is kind of a](https://youtu.be/oRci9ITnMuM?t=00h39m55s)

[pain](https://youtu.be/oRci9ITnMuM?t=00h39m57s)

[so let's imagine that you don't have the](https://youtu.be/oRci9ITnMuM?t=00h39m59s)

[design time data context set you'll note](https://youtu.be/oRci9ITnMuM?t=00h40m01s)

[i got the little](https://youtu.be/oRci9ITnMuM?t=00h40m03s)

[triple dots which means light bulb or as](https://youtu.be/oRci9ITnMuM?t=00h40m04s)

[i call it the auto code button here](https://youtu.be/oRci9ITnMuM?t=00h40m07s)

[right so we come up here it will let you](https://youtu.be/oRci9ITnMuM?t=00h40m09s)

[set the design time data context right](https://youtu.be/oRci9ITnMuM?t=00h40m12s)

[from here right and you'll note it tries](https://youtu.be/oRci9ITnMuM?t=00h40m15s)

[to guess a little bit right](https://youtu.be/oRci9ITnMuM?t=00h40m16s)

[it goes hey you're in icon pack.xaml](https://youtu.be/oRci9ITnMuM?t=00h40m18s)

[maybe icon pack view model is exactly](https://youtu.be/oRci9ITnMuM?t=00h40m22s)

[what you want](https://youtu.be/oRci9ITnMuM?t=00h40m24s)

[why yes that is exactly what i would](https://youtu.be/oRci9ITnMuM?t=00h40m25s)

[like](https://youtu.be/oRci9ITnMuM?t=00h40m27s)

[boom done](https://youtu.be/oRci9ITnMuM?t=00h40m30s)

[but wait it gets better it gets better](https://youtu.be/oRci9ITnMuM?t=00h40m33s)

[okay we come down here right so](https://youtu.be/oRci9ITnMuM?t=00h40m36s)

[for example we've got these these](https://youtu.be/oRci9ITnMuM?t=00h40m40s)

[binding down here right so let's let's](https://youtu.be/oRci9ITnMuM?t=00h40m42s)

[come up with some names for these things](https://youtu.be/oRci9ITnMuM?t=00h40m43s)

[so we're going to get rid of this guy](https://youtu.be/oRci9ITnMuM?t=00h40m45s)

[because](https://youtu.be/oRci9ITnMuM?t=00h40m47s)

[that ain't working the way we want um](https://youtu.be/oRci9ITnMuM?t=00h40m48s)

[let's come down here because we are](https://youtu.be/oRci9ITnMuM?t=00h40m50s)

[gonna need to change these so rather](https://youtu.be/oRci9ITnMuM?t=00h40m52s)

[than binding it here](https://youtu.be/oRci9ITnMuM?t=00h40m53s)

[let's pretend that we're gonna bind into](https://youtu.be/oRci9ITnMuM?t=00h40m54s)

[um uh let's see uh](https://youtu.be/oRci9ITnMuM?t=00h40m58s)

[how about generated](https://youtu.be/oRci9ITnMuM?t=00h41m01s)

[icon background right so this is clearly](https://youtu.be/oRci9ITnMuM?t=00h41m05s)

[a property](https://youtu.be/oRci9ITnMuM?t=00h41m09s)

[oh is it not going to do it for me](https://youtu.be/oRci9ITnMuM?t=00h41m10s)

[where's the auto code button](https://youtu.be/oRci9ITnMuM?t=00h41m13s)

[where's my auto go button](https://youtu.be/oRci9ITnMuM?t=00h41m15s)

[hang on let's come up here let's come up](https://youtu.be/oRci9ITnMuM?t=00h41m19s)

[here and see if this will work](https://youtu.be/oRci9ITnMuM?t=00h41m20s)

[uh so let's see if i do](https://youtu.be/oRci9ITnMuM?t=00h41m22s)

[background binding](https://youtu.be/oRci9ITnMuM?t=00h41m25s)

[and i do generated thingymabobber right](https://youtu.be/oRci9ITnMuM?t=00h41m29s)

[ah so it just doesn't work in a mmm](https://youtu.be/oRci9ITnMuM?t=00h41m34s)

[it doesn't pick it up inside of a style](https://youtu.be/oRci9ITnMuM?t=00h41m38s)

[binding](https://youtu.be/oRci9ITnMuM?t=00h41m40s)

[that's disappointing um i will add](https://youtu.be/oRci9ITnMuM?t=00h41m42s)

[feedback for that](https://youtu.be/oRci9ITnMuM?t=00h41m44s)

[um but you'll note here once again](https://youtu.be/oRci9ITnMuM?t=00h41m45s)

[three see this three little dots](https://youtu.be/oRci9ITnMuM?t=00h41m49s)

[let's see hold on i gotta i gotta](https://youtu.be/oRci9ITnMuM?t=00h41m55s)

[fix the size of my](https://youtu.be/oRci9ITnMuM?t=00h41m59s)

[uh](https://youtu.be/oRci9ITnMuM?t=00h42m06s)

[something has changed the size of this](https://youtu.be/oRci9ITnMuM?t=00h42m09s)

[anyway](https://youtu.be/oRci9ITnMuM?t=00h42m12s)

[three little dots there right so if i go](https://youtu.be/oRci9ITnMuM?t=00h42m13s)

[auto code button so control period](https://youtu.be/oRci9ITnMuM?t=00h42m16s)

[generate property huh](https://youtu.be/oRci9ITnMuM?t=00h42m18s)

[you'll note if i do that](https://youtu.be/oRci9ITnMuM?t=00h42m23s)

[and then we jump over to our well](https://youtu.be/oRci9ITnMuM?t=00h42m26s)

[actually](https://youtu.be/oRci9ITnMuM?t=00h42m28s)

[shoot we can just f12 on it now boom](https://youtu.be/oRci9ITnMuM?t=00h42m29s)

[it has gone through and it has generated](https://youtu.be/oRci9ITnMuM?t=00h42m32s)

[up](https://youtu.be/oRci9ITnMuM?t=00h42m35s)

[a property for me and more importantly](https://youtu.be/oRci9ITnMuM?t=00h42m36s)

[it's even](https://youtu.be/oRci9ITnMuM?t=00h42m38s)

[figured out that this is the um](https://youtu.be/oRci9ITnMuM?t=00h42m39s)

[the appropriate way to implement the](https://youtu.be/oRci9ITnMuM?t=00h42m43s)

[setter seeing that](https://youtu.be/oRci9ITnMuM?t=00h42m44s)

[hey hang on we've got this view model](https://youtu.be/oRci9ITnMuM?t=00h42m46s)

[base class this is in](https://youtu.be/oRci9ITnMuM?t=00h42m48s)

[my project this isn't something special](https://youtu.be/oRci9ITnMuM?t=00h42m50s)

[right](https://youtu.be/oRci9ITnMuM?t=00h42m53s)

[the thing just got smart and went oh i i](https://youtu.be/oRci9ITnMuM?t=00h42m54s)

[see what it is](https://youtu.be/oRci9ITnMuM?t=00h42m57s)

[and it goes and adds it for you](https://youtu.be/oRci9ITnMuM?t=00h42m58s)

[that's pretty cool that's pretty cool um](https://youtu.be/oRci9ITnMuM?t=00h43m01s)

[it can also do the same thing for](https://youtu.be/oRci9ITnMuM?t=00h43m04s)

[commands as well though there was a](https://youtu.be/oRci9ITnMuM?t=00h43m06s)

[piece of feedback i submitted before](https://youtu.be/oRci9ITnMuM?t=00h43m08s)

[it had trouble generating commands](https://youtu.be/oRci9ITnMuM?t=00h43m10s)

[let's see if i can remember right it](https://youtu.be/oRci9ITnMuM?t=00h43m13s)

[would not generate the command](https://youtu.be/oRci9ITnMuM?t=00h43m15s)

[in your view model if the command](https://youtu.be/oRci9ITnMuM?t=00h43m17s)

[implementation](https://youtu.be/oRci9ITnMuM?t=00h43m19s)

[was inside of your project but it would](https://youtu.be/oRci9ITnMuM?t=00h43m20s)

[work](https://youtu.be/oRci9ITnMuM?t=00h43m23s)

[if your command implementation was](https://youtu.be/oRci9ITnMuM?t=00h43m23s)

[coming from say like mvvm light or](https://youtu.be/oRci9ITnMuM?t=00h43m25s)

[similar](https://youtu.be/oRci9ITnMuM?t=00h43m27s)

[it would auto generate those so totally](https://youtu.be/oRci9ITnMuM?t=00h43m27s)

[awesome](https://youtu.be/oRci9ITnMuM?t=00h43m31s)

[and now i actually want to test one more](https://youtu.be/oRci9ITnMuM?t=00h43m31s)

[thing because i'm not sure if it works](https://youtu.be/oRci9ITnMuM?t=00h43m33s)

[with converters](https://youtu.be/oRci9ITnMuM?t=00h43m34s)

[let's see if this thing works with](https://youtu.be/oRci9ITnMuM?t=00h43m35s)

[converters because i'm curious if it can](https://youtu.be/oRci9ITnMuM?t=00h43m36s)

[figure out](https://youtu.be/oRci9ITnMuM?t=00h43m39s)

[converter so if i slap a converter on](https://youtu.be/oRci9ITnMuM?t=00h43m40s)

[here](https://youtu.be/oRci9ITnMuM?t=00h43m43s)

[uh brush color to brush converter right](https://youtu.be/oRci9ITnMuM?t=00h43m44s)

[i'm wondering if this thing will](https://youtu.be/oRci9ITnMuM?t=00h43m48s)

[generate me up a brush or if it if](https://youtu.be/oRci9ITnMuM?t=00h43m49s)

[see it still wants to generate a brush](https://youtu.be/oRci9ITnMuM?t=00h43m52s)

[i'm wondering if i do](https://youtu.be/oRci9ITnMuM?t=00h43m55s)

[i'm i'm sorry now now i just got to test](https://youtu.be/oRci9ITnMuM?t=00h43m58s)

[this](https://youtu.be/oRci9ITnMuM?t=00h44m01s)

[uh value conversion right so you can](https://youtu.be/oRci9ITnMuM?t=00h44m01s)

[specify](https://youtu.be/oRci9ITnMuM?t=00h44m05s)

[source type is type of](https://youtu.be/oRci9ITnMuM?t=00h44m07s)

[color right target type](https://youtu.be/oRci9ITnMuM?t=00h44m10s)

[is type of](https://youtu.be/oRci9ITnMuM?t=00h44m13s)

[brush right and i'm wondering if that](https://youtu.be/oRci9ITnMuM?t=00h44m18s)

[will be enough](https://youtu.be/oRci9ITnMuM?t=00h44m20s)

[to have it figure it out um let's](https://youtu.be/oRci9ITnMuM?t=00h44m22s)

[compile because i want to give it the](https://youtu.be/oRci9ITnMuM?t=00h44m25s)

[best chance](https://youtu.be/oRci9ITnMuM?t=00h44m26s)

[of success because the](https://youtu.be/oRci9ITnMuM?t=00h44m28s)

[i was told that this tool isn't just](https://youtu.be/oRci9ITnMuM?t=00h44m31s)

[some some simple logic that it's](https://youtu.be/oRci9ITnMuM?t=00h44m35s)

[actually using some heuristics to look](https://youtu.be/oRci9ITnMuM?t=00h44m37s)

[at your](https://youtu.be/oRci9ITnMuM?t=00h44m39s)

[your code to figure out what the right](https://youtu.be/oRci9ITnMuM?t=00h44m39s)

[thing is](https://youtu.be/oRci9ITnMuM?t=00h44m41s)

[um and i kind of imagine that this is](https://youtu.be/oRci9ITnMuM?t=00h44m42s)

[going to be like the xaml version of](https://youtu.be/oRci9ITnMuM?t=00h44m45s)

[intellicode](https://youtu.be/oRci9ITnMuM?t=00h44m46s)

[it's going to be right most of the time](https://youtu.be/oRci9ITnMuM?t=00h44m48s)

[and when it's wrong it's going to fail](https://youtu.be/oRci9ITnMuM?t=00h44m51s)

[spectacularly](https://youtu.be/oRci9ITnMuM?t=00h44m52s)

[um but let's see i'm i'm curious so](https://youtu.be/oRci9ITnMuM?t=00h44m53s)

[will it figure out that what i actually](https://youtu.be/oRci9ITnMuM?t=00h44m57s)

[want here is](https://youtu.be/oRci9ITnMuM?t=00h45m00s)

[come on visual studio that what i](https://youtu.be/oRci9ITnMuM?t=00h45m01s)

[actually want here](https://youtu.be/oRci9ITnMuM?t=00h45m03s)

[is a color property](https://youtu.be/oRci9ITnMuM?t=00h45m04s)

[because that'd be cool if it figures](https://youtu.be/oRci9ITnMuM?t=00h45m08s)

[that out that'd make me very very happy](https://youtu.be/oRci9ITnMuM?t=00h45m09s)

[visual studio what are you doing](https://youtu.be/oRci9ITnMuM?t=00h45m12s)

[uh apparently crashing](https://youtu.be/oRci9ITnMuM?t=00h45m16s)

[hello i i know compiling's a hard](https://youtu.be/oRci9ITnMuM?t=00h45m21s)

[operation what are you](https://youtu.be/oRci9ITnMuM?t=00h45m25s)

[slack is doing something well that's](https://youtu.be/oRci9ITnMuM?t=00h45m32s)

[easy there](https://youtu.be/oRci9ITnMuM?t=00h45m34s)

[now slack's not doing anything](https://youtu.be/oRci9ITnMuM?t=00h45m35s)

[uh okay](https://youtu.be/oRci9ITnMuM?t=00h45m39s)

[this might be a case of](https://youtu.be/oRci9ITnMuM?t=00h45m43s)

[yeah let's just restart that program](https://youtu.be/oRci9ITnMuM?t=00h45m47s)

[okay](https://youtu.be/oRci9ITnMuM?t=00h45m50s)

[we'll let you report the problem](https://youtu.be/oRci9ITnMuM?t=00h45m50s)

[you will note that i am running visual](https://youtu.be/oRci9ITnMuM?t=00h45m54s)

[studio preview](https://youtu.be/oRci9ITnMuM?t=00h45m56s)

[um so occasionally bugs crop up](https://youtu.be/oRci9ITnMuM?t=00h45m58s)

[um but in general they are few and far](https://youtu.be/oRci9ITnMuM?t=00h46m02s)

[between](https://youtu.be/oRci9ITnMuM?t=00h46m04s)

[i actually find that most of the time in](https://youtu.be/oRci9ITnMuM?t=00h46m05s)

[my day-to-day work i have no issue](https://youtu.be/oRci9ITnMuM?t=00h46m07s)

[running](https://youtu.be/oRci9ITnMuM?t=00h46m09s)

[the previews i do have a secondary](https://youtu.be/oRci9ITnMuM?t=00h46m10s)

[machine that i can always switch to](https://youtu.be/oRci9ITnMuM?t=00h46m12s)

[if there is some major problem but for](https://youtu.be/oRci9ITnMuM?t=00h46m14s)

[the most part i don't have enough](https://youtu.be/oRci9ITnMuM?t=00h46m16s)

[problems that weren't switching](https://youtu.be/oRci9ITnMuM?t=00h46m18s)

[the occasional crash here and there but](https://youtu.be/oRci9ITnMuM?t=00h46m20s)

[i would like to think that the](https://youtu.be/oRci9ITnMuM?t=00h46m22s)

[getting access to some of the latest](https://youtu.be/oRci9ITnMuM?t=00h46m25s)

[stuff makes it worth it](https://youtu.be/oRci9ITnMuM?t=00h46m27s)

[okay so we were coming back down here](https://youtu.be/oRci9ITnMuM?t=00h46m28s)

[and we were going to see if the](https://youtu.be/oRci9ITnMuM?t=00h46m33s)

[awesome little light bulb button could](https://youtu.be/oRci9ITnMuM?t=00h46m36s)

[figure it out](https://youtu.be/oRci9ITnMuM?t=00h46m39s)

[gathering suggestions](https://youtu.be/oRci9ITnMuM?t=00h46m42s)

[gathering suggestions it's gotta it's](https://youtu.be/oRci9ITnMuM?t=00h46m46s)

[gotta think pretty hard](https://youtu.be/oRci9ITnMuM?t=00h46m48s)

[come on oh so you cancel the first one](https://youtu.be/oRci9ITnMuM?t=00h46m52s)

[and so then it adds a second one](https://youtu.be/oRci9ITnMuM?t=00h46m56s)

[naturally okay so that](https://youtu.be/oRci9ITnMuM?t=00h46m58s)

[that thing's got itself figured out](https://youtu.be/oRci9ITnMuM?t=00h47m02s)

[let's try this again](https://youtu.be/oRci9ITnMuM?t=00h47m05s)

[create property](https://youtu.be/oRci9ITnMuM?t=00h47m08s)

[boo i would love it i'm guessing it just](https://youtu.be/oRci9ITnMuM?t=00h47m13s)

[doesn't bother to take the converter](https://youtu.be/oRci9ITnMuM?t=00h47m17s)

[into account](https://youtu.be/oRci9ITnMuM?t=00h47m19s)

[still cool still cool](https://youtu.be/oRci9ITnMuM?t=00h47m22s)

[not as cool as it could be not as cool](https://youtu.be/oRci9ITnMuM?t=00h47m25s)

[as it could be](https://youtu.be/oRci9ITnMuM?t=00h47m27s)

[okay so we're gonna do](https://youtu.be/oRci9ITnMuM?t=00h47m28s)

[that's fine that's fine we will](https://youtu.be/oRci9ITnMuM?t=00h47m32s)

[uh we will work with it generated icon](https://youtu.be/oRci9ITnMuM?t=00h47m36s)

[foreground we'll do something like that](https://youtu.be/oRci9ITnMuM?t=00h47m41s)

[something like that](https://youtu.be/oRci9ITnMuM?t=00h47m44s)

[and then we're gonna go with generated](https://youtu.be/oRci9ITnMuM?t=00h47m45s)

[item background](https://youtu.be/oRci9ITnMuM?t=00h47m48s)

[same same with this](https://youtu.be/oRci9ITnMuM?t=00h47m51s)

[um we don't need the converter anymore](https://youtu.be/oRci9ITnMuM?t=00h47m56s)

[on this side](https://youtu.be/oRci9ITnMuM?t=00h47m59s)

[we're just going to let it write the](https://youtu.be/oRci9ITnMuM?t=00h48m00s)

[color out and then this guy can convert](https://youtu.be/oRci9ITnMuM?t=00h48m01s)

[on this side](https://youtu.be/oRci9ITnMuM?t=00h48m04s)

[so we will we will let it generate those](https://youtu.be/oRci9ITnMuM?t=00h48m05s)

[properties for us because it is that](https://youtu.be/oRci9ITnMuM?t=00h48m08s)

[level of cool](https://youtu.be/oRci9ITnMuM?t=00h48m10s)

[we will need to come and deal with](https://youtu.be/oRci9ITnMuM?t=00h48m11s)

[um this guy down here and it is](https://youtu.be/oRci9ITnMuM?t=00h48m15s)

[bothering me that i'm seeing this in the](https://youtu.be/oRci9ITnMuM?t=00h48m18s)

[designer](https://youtu.be/oRci9ITnMuM?t=00h48m20s)

[i really wish there was a better way of](https://youtu.be/oRci9ITnMuM?t=00h48m21s)

[debugging this um](https://youtu.be/oRci9ITnMuM?t=00h48m22s)

[okay and let's just no background first](https://youtu.be/oRci9ITnMuM?t=00h48m24s)

[okay so navigate to property and we're](https://youtu.be/oRci9ITnMuM?t=00h48m28s)

[going to change some stuff up step one](https://youtu.be/oRci9ITnMuM?t=00h48m30s)

[this needs to be a color](https://youtu.be/oRci9ITnMuM?t=00h48m33s)

[right uh let's see auto code button for](https://youtu.be/oRci9ITnMuM?t=00h48m36s)

[the win](https://youtu.be/oRci9ITnMuM?t=00h48m39s)

[that one and](https://youtu.be/oRci9ITnMuM?t=00h48m41s)

[this guy here](https://youtu.be/oRci9ITnMuM?t=00h48m46s)

[should also be a color](https://youtu.be/oRci9ITnMuM?t=00h48m49s)

[that should be a color](https://youtu.be/oRci9ITnMuM?t=00h48m56s)

[that should be a color and we're going](https://youtu.be/oRci9ITnMuM?t=00h49m02s)

[to do some indentation and a little](https://youtu.be/oRci9ITnMuM?t=00h49m05s)

[renaming](https://youtu.be/oRci9ITnMuM?t=00h49m07s)

[that was another piece of feedback that](https://youtu.be/oRci9ITnMuM?t=00h49m08s)

[i had mentioned to the team as well](https://youtu.be/oRci9ITnMuM?t=00h49m10s)

[is that it would be really cool if it](https://youtu.be/oRci9ITnMuM?t=00h49m12s)

[used like my settings in my editor](https://youtu.be/oRci9ITnMuM?t=00h49m14s)

[config](https://youtu.be/oRci9ITnMuM?t=00h49m15s)

[to figure out the proper naming for my](https://youtu.be/oRci9ITnMuM?t=00h49m17s)

[properties and fields](https://youtu.be/oRci9ITnMuM?t=00h49m19s)

[like not a big deal because i'm just](https://youtu.be/oRci9ITnMuM?t=00h49m22s)

[gonna go through and rename these anyway](https://youtu.be/oRci9ITnMuM?t=00h49m24s)

[but it would be nice](https://youtu.be/oRci9ITnMuM?t=00h49m25s)

[it would be nice right](https://youtu.be/oRci9ITnMuM?t=00h49m27s)

[okay so we got that](https://youtu.be/oRci9ITnMuM?t=00h49m30s)

[we got that and built those up for me](https://youtu.be/oRci9ITnMuM?t=00h49m34s)

[that's cool](https://youtu.be/oRci9ITnMuM?t=00h49m36s)

[let's generate oh i know let's actually](https://youtu.be/oRci9ITnMuM?t=00h49m38s)

[see if it'll generate](https://youtu.be/oRci9ITnMuM?t=00h49m40s)

[since i mentioned it could do it let's](https://youtu.be/oRci9ITnMuM?t=00h49m42s)

[see if it'll handle it](https://youtu.be/oRci9ITnMuM?t=00h49m44s)

[command let's see binding](https://youtu.be/oRci9ITnMuM?t=00h49m45s)

[uh save icon command](https://youtu.be/oRci9ITnMuM?t=00h49m49s)

[will you figure it out for me](https://youtu.be/oRci9ITnMuM?t=00h49m53s)

[huh it found it](https://youtu.be/oRci9ITnMuM?t=00h49m57s)

[interesting i had a sample where that](https://youtu.be/oRci9ITnMuM?t=00h50m03s)

[definitely did not work](https://youtu.be/oRci9ITnMuM?t=00h50m06s)

[and i wonder what it was um](https://youtu.be/oRci9ITnMuM?t=00h50m08s)

[okay cool so it just generated the](https://youtu.be/oRci9ITnMuM?t=00h50m12s)

[command up for me because](https://youtu.be/oRci9ITnMuM?t=00h50m14s)

[why not uh so we've got that](https://youtu.be/oRci9ITnMuM?t=00h50m16s)

[we'll eventually want to get these sizes](https://youtu.be/oRci9ITnMuM?t=00h50m20s)

[in but i kind of want to just get this](https://youtu.be/oRci9ITnMuM?t=00h50m22s)

[thing generating an icon with one size](https://youtu.be/oRci9ITnMuM?t=00h50m23s)

[to start](https://youtu.be/oRci9ITnMuM?t=00h50m25s)

[and then we'll go from there seems](https://youtu.be/oRci9ITnMuM?t=00h50m26s)

[reasonable](https://youtu.be/oRci9ITnMuM?t=00h50m29s)

[and then the other thing we need to do](https://youtu.be/oRci9ITnMuM?t=00h50m30s)

[is add nuget package](https://youtu.be/oRci9ITnMuM?t=00h50m32s)

[so we were going to take advantage of](https://youtu.be/oRci9ITnMuM?t=00h50m34s)

[this guy's icon library this blue wolf](https://youtu.be/oRci9ITnMuM?t=00h50m38s)

[icons](https://youtu.be/oRci9ITnMuM?t=00h50m41s)

[because they they look like they have](https://youtu.be/oRci9ITnMuM?t=00h50m43s)

[the api](https://youtu.be/oRci9ITnMuM?t=00h50m46s)

[that we seek so let's go here](https://youtu.be/oRci9ITnMuM?t=00h50m47s)

[uh i'm sorry we want to browse these](https://youtu.be/oRci9ITnMuM?t=00h50m52s)

[ones](https://youtu.be/oRci9ITnMuM?t=00h50m55s)

[we'll install this it does mildly](https://youtu.be/oRci9ITnMuM?t=00h50m57s)

[concern me that the](https://youtu.be/oRci9ITnMuM?t=00h51m00s)

[last updated date was 2016.](https://youtu.be/oRci9ITnMuM?t=00h51m01s)

[just another library to to uh to go and](https://youtu.be/oRci9ITnMuM?t=00h51m06s)

[update](https://youtu.be/oRci9ITnMuM?t=00h51m09s)

[uh sure we'll actually update this](https://youtu.be/oRci9ITnMuM?t=00h51m10s)

[i don't mind a minor revision rev](https://youtu.be/oRci9ITnMuM?t=00h51m14s)

[especially on something that's just](https://youtu.be/oRci9ITnMuM?t=00h51m17s)

[going into the demo application](https://youtu.be/oRci9ITnMuM?t=00h51m18s)

[uh okay so what is your](https://youtu.be/oRci9ITnMuM?t=00h51m20s)

[are you squawking at](https://youtu.be/oRci9ITnMuM?t=00h51m24s)

[really](https://youtu.be/oRci9ITnMuM?t=00h51m29s)

[what is what is this what what is this](https://youtu.be/oRci9ITnMuM?t=00h51m34s)

[you were just happy a minute ago with it](https://youtu.be/oRci9ITnMuM?t=00h51m37s)

[uh i'm also noticing that wait](https://youtu.be/oRci9ITnMuM?t=00h51m42s)

[why is it not showing me](https://youtu.be/oRci9ITnMuM?t=00h51m46s)

[did i not finish installing it](https://youtu.be/oRci9ITnMuM?t=00h51m52s)

[install did i click off before it could](https://youtu.be/oRci9ITnMuM?t=00h51m57s)

[finish](https://youtu.be/oRci9ITnMuM?t=00h52m00s)

[uh](https://youtu.be/oRci9ITnMuM?t=00h52m02s)

[uh](https://youtu.be/oRci9ITnMuM?t=00h52m08s)

[packages that use the central package](https://youtu.be/oRci9ITnMuM?t=00h52m12s)

[management should not define](https://youtu.be/oRci9ITnMuM?t=00h52m15s)

[version oh it speaks right](https://youtu.be/oRci9ITnMuM?t=00h52m16s)

[right right right right right right](https://youtu.be/oRci9ITnMuM?t=00h52m20s)

[right right so this is bad](https://youtu.be/oRci9ITnMuM?t=00h52m21s)

[so we shouldn't do this um we have](https://youtu.be/oRci9ITnMuM?t=00h52m24s)

[we are using the centralized package](https://youtu.be/oRci9ITnMuM?t=00h52m27s)

[management](https://youtu.be/oRci9ITnMuM?t=00h52m29s)

[which means we go up to](https://youtu.be/oRci9ITnMuM?t=00h52m30s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=00h52m32s)

[here and we rev the version](https://youtu.be/oRci9ITnMuM?t=00h52m34s)

[here and then that fixes it](https://youtu.be/oRci9ITnMuM?t=00h52m38s)

[so it should then go and figure itself](https://youtu.be/oRci9ITnMuM?t=00h52m44s)

[out](https://youtu.be/oRci9ITnMuM?t=00h52m47s)

[though it might have to unload and re](https://youtu.be/oRci9ITnMuM?t=00h52m48s)

[reload the](https://youtu.be/oRci9ITnMuM?t=00h52m50s)

[the thingymabobbers uh so](https://youtu.be/oRci9ITnMuM?t=00h52m51s)

[what that means though is then i want to](https://youtu.be/oRci9ITnMuM?t=00h52m55s)

[come up here](https://youtu.be/oRci9ITnMuM?t=00h52m57s)

[and put in](https://youtu.be/oRci9ITnMuM?t=00h52m59s)

[uh blue wolf icons and then i want this](https://youtu.be/oRci9ITnMuM?t=00h53m02s)

[to be](https://youtu.be/oRci9ITnMuM?t=00h53m06s)

[let's see 1.0.1](https://youtu.be/oRci9ITnMuM?t=00h53m08s)

[and then over here what i want to do is](https://youtu.be/oRci9ITnMuM?t=00h53m12s)

[copy paste and this to be blue wolf](https://youtu.be/oRci9ITnMuM?t=00h53m17s)

[icons](https://youtu.be/oRci9ITnMuM?t=00h53m21s)

[let's put you up one unindent unindent](https://youtu.be/oRci9ITnMuM?t=00h53m23s)

[everyone should be happy now uh let's](https://youtu.be/oRci9ITnMuM?t=00h53m26s)

[see](https://youtu.be/oRci9ITnMuM?t=00h53m29s)

[you seem to be losing your mind on](https://youtu.be/oRci9ITnMuM?t=00h53m31s)

[package restores](https://youtu.be/oRci9ITnMuM?t=00h53m34s)

[that's fine](https://youtu.be/oRci9ITnMuM?t=00h53m36s)

[uh and then noble reference types is](https://youtu.be/oRci9ITnMuM?t=00h53m40s)

[unhappy about the command implementation](https://youtu.be/oRci9ITnMuM?t=00h53m42s)

[i prepare okay so let's let's do a](https://youtu.be/oRci9ITnMuM?t=00h53m46s)

[little cleanup back here so we'll](https://youtu.be/oRci9ITnMuM?t=00h53m49s)

[express embody that guy](https://youtu.be/oRci9ITnMuM?t=00h53m50s)

[um let's see](https://youtu.be/oRci9ITnMuM?t=00h53m54s)

[this guy looks a little weird without](https://youtu.be/oRci9ITnMuM?t=00h53m56s)

[its curly braces](https://youtu.be/oRci9ITnMuM?t=00h53m58s)

[in general if it doesn't fit on one line](https://youtu.be/oRci9ITnMuM?t=00h54m01s)

[i don't like doing my if statements](https://youtu.be/oRci9ITnMuM?t=00h54m02s)

[without curly braces but that's](https://youtu.be/oRci9ITnMuM?t=00h54m04s)

[that's just preference okay so this guy](https://youtu.be/oRci9ITnMuM?t=00h54m06s)

[here](https://youtu.be/oRci9ITnMuM?t=00h54m09s)

[is unhappy](https://youtu.be/oRci9ITnMuM?t=00h54m10s)

[because we have notable reference types](https://youtu.be/oRci9ITnMuM?t=00h54m13s)

[turned on](https://youtu.be/oRci9ITnMuM?t=00h54m15s)

[um but it did generate this up nicely](https://youtu.be/oRci9ITnMuM?t=00h54m16s)

[for me](https://youtu.be/oRci9ITnMuM?t=00h54m19s)

[and we'll just use a discard here we](https://youtu.be/oRci9ITnMuM?t=00h54m20s)

[don't actually need it and i](https://youtu.be/oRci9ITnMuM?t=00h54m24s)

[i actually prefer if my action methods](https://youtu.be/oRci9ITnMuM?t=00h54m26s)

[are prefixed with the word on](https://youtu.be/oRci9ITnMuM?t=00h54m28s)

[again that's just personal preference](https://youtu.be/oRci9ITnMuM?t=00h54m30s)

[that's just](https://youtu.be/oRci9ITnMuM?t=00h54m32s)

[okay so let's start this thing up and](https://youtu.be/oRci9ITnMuM?t=00h54m34s)

[make sure it actually still runs and](https://youtu.be/oRci9ITnMuM?t=00h54m37s)

[that we get all the way](https://youtu.be/oRci9ITnMuM?t=00h54m39s)

[into here because i'd like to verify](https://youtu.be/oRci9ITnMuM?t=00h54m40s)

[that when we get into our](https://youtu.be/oRci9ITnMuM?t=00h54m43s)

[execution delegate why did it resolve](https://youtu.be/oRci9ITnMuM?t=00h54m45s)

[that](https://youtu.be/oRci9ITnMuM?t=00h54m48s)

[at dot 1.00](https://youtu.be/oRci9ITnMuM?t=00h54m48s)

[did we not oh because i can't type](https://youtu.be/oRci9ITnMuM?t=00h54m52s)

[because i typed 1.0](https://youtu.be/oRci9ITnMuM?t=00h54m56s)

[so if you are interested there um](https://youtu.be/oRci9ITnMuM?t=00h54m59s)

[let's see here nougat centralized](https://youtu.be/oRci9ITnMuM?t=00h55m02s)

[package management so let's see nougat](https://youtu.be/oRci9ITnMuM?t=00h55m06s)

[centralized package](https://youtu.be/oRci9ITnMuM?t=00h55m10s)

[management so this is a feature](https://youtu.be/oRci9ITnMuM?t=00h55m12s)

[let's see so this is a feature that's](https://youtu.be/oRci9ITnMuM?t=00h55m17s)

[kind of preview-esque](https://youtu.be/oRci9ITnMuM?t=00h55m20s)

[right um](https://youtu.be/oRci9ITnMuM?t=00h55m24s)

[yeah this thing here](https://youtu.be/oRci9ITnMuM?t=00h55m29s)

[yeah so this is a](https://youtu.be/oRci9ITnMuM?t=00h55m35s)

[uh](https://youtu.be/oRci9ITnMuM?t=00h55m42s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=00h55m42s)

[where is this thing](https://youtu.be/oRci9ITnMuM?t=00h55m45s)

[uh this is not quite the same there's a](https://youtu.be/oRci9ITnMuM?t=00h55m50s)

[lot of discussion here i was hoping to](https://youtu.be/oRci9ITnMuM?t=00h55m53s)

[find a better docs page for this](https://youtu.be/oRci9ITnMuM?t=00h55m55s)

[but this guy here i'll just link to the](https://youtu.be/oRci9ITnMuM?t=00h56m02s)

[the issue um this gives you a lot of the](https://youtu.be/oRci9ITnMuM?t=00h56m05s)

[same benefits](https://youtu.be/oRci9ITnMuM?t=00h56m08s)

[that we got when we were using packet in](https://youtu.be/oRci9ITnMuM?t=00h56m09s)

[terms of](https://youtu.be/oRci9ITnMuM?t=00h56m12s)

[uh managing your dependencies so the big](https://youtu.be/oRci9ITnMuM?t=00h56m13s)

[drawback here](https://youtu.be/oRci9ITnMuM?t=00h56m16s)

[is there is zero visual studio gui](https://youtu.be/oRci9ITnMuM?t=00h56m17s)

[support for this](https://youtu.be/oRci9ITnMuM?t=00h56m20s)

[at all right outside of that little](https://youtu.be/oRci9ITnMuM?t=00h56m21s)

[error message that we saw there's pretty](https://youtu.be/oRci9ITnMuM?t=00h56m23s)

[much nothing](https://youtu.be/oRci9ITnMuM?t=00h56m24s)

[but the key thing is you get this](https://youtu.be/oRci9ITnMuM?t=00h56m26s)

[directorypackage.props file that you can](https://youtu.be/oRci9ITnMuM?t=00h56m28s)

[put in all of the nuget packages that](https://youtu.be/oRci9ITnMuM?t=00h56m30s)

[you're using](https://youtu.be/oRci9ITnMuM?t=00h56m33s)

[and more importantly specify your](https://youtu.be/oRci9ITnMuM?t=00h56m34s)

[versions all in one place](https://youtu.be/oRci9ITnMuM?t=00h56m35s)

[and then inside of your projects the](https://youtu.be/oRci9ITnMuM?t=00h56m37s)

[projects just declare](https://youtu.be/oRci9ITnMuM?t=00h56m40s)

[which of those nuget packages they're](https://youtu.be/oRci9ITnMuM?t=00h56m42s)

[using](https://youtu.be/oRci9ITnMuM?t=00h56m44s)

[that's it and you're done and it just](https://youtu.be/oRci9ITnMuM?t=00h56m45s)

[works](https://youtu.be/oRci9ITnMuM?t=00h56m48s)

[it's great like i said the big drawback](https://youtu.be/oRci9ITnMuM?t=00h56m48s)

[being](https://youtu.be/oRci9ITnMuM?t=00h56m51s)

[you don't get a clean um ui](https://youtu.be/oRci9ITnMuM?t=00h56m51s)

[experience so if you're if you're really](https://youtu.be/oRci9ITnMuM?t=00h56m55s)

[attached to being able to right click](https://youtu.be/oRci9ITnMuM?t=00h56m57s)

[manage nuget packages](https://youtu.be/oRci9ITnMuM?t=00h56m58s)

[this is not the solution for you okay](https://youtu.be/oRci9ITnMuM?t=00h57m00s)

[so let's go and look and see what we did](https://youtu.be/oRci9ITnMuM?t=00h57m03s)

[icon pack](https://youtu.be/oRci9ITnMuM?t=00h57m05s)

[so we'll pick an icon hit this guy](https://youtu.be/oRci9ITnMuM?t=00h57m09s)

[well that's changing the background so](https://youtu.be/oRci9ITnMuM?t=00h57m14s)

[that tells me i did it backwards](https://youtu.be/oRci9ITnMuM?t=00h57m17s)

[uh or i bound everything to the](https://youtu.be/oRci9ITnMuM?t=00h57m21s)

[background and that's](https://youtu.be/oRci9ITnMuM?t=00h57m23s)

[exciting so if we hit save](https://youtu.be/oRci9ITnMuM?t=00h57m25s)

[i want to see generated item foreground](https://youtu.be/oRci9ITnMuM?t=00h57m28s)

[is not set](https://youtu.be/oRci9ITnMuM?t=00h57m30s)

[background clearly got a value so](https://youtu.be/oRci9ITnMuM?t=00h57m31s)

[we bound the wrong wrong stuff](https://youtu.be/oRci9ITnMuM?t=00h57m34s)

[so that's background and foreground this](https://youtu.be/oRci9ITnMuM?t=00h57m39s)

[is background and background](https://youtu.be/oRci9ITnMuM?t=00h57m41s)

[so this should really be](https://youtu.be/oRci9ITnMuM?t=00h57m43s)

[foreground so this goes](https://youtu.be/oRci9ITnMuM?t=00h57m46s)

[here oh uh](https://youtu.be/oRci9ITnMuM?t=00h57m49s)

[continue uh so this guy](https://youtu.be/oRci9ITnMuM?t=00h57m54s)

[here if i go foreground](https://youtu.be/oRci9ITnMuM?t=00h57m57s)

[so aside from needing a good default](https://youtu.be/oRci9ITnMuM?t=00h58m04s)

[value](https://youtu.be/oRci9ITnMuM?t=00h58m06s)

[looks like it's working that's pretty](https://youtu.be/oRci9ITnMuM?t=00h58m11s)

[cool](https://youtu.be/oRci9ITnMuM?t=00h58m13s)

[um i'm a little surprised](https://youtu.be/oRci9ITnMuM?t=00h58m14s)

[with horizontal alignment center that](https://youtu.be/oRci9ITnMuM?t=00h58m18s)

[the things](https://youtu.be/oRci9ITnMuM?t=00h58m21s)

[still spanned](https://youtu.be/oRci9ITnMuM?t=00h58m22s)

[the entire thing](https://youtu.be/oRci9ITnMuM?t=00h58m25s)

[see how that does yeah i'm a little](https://youtu.be/oRci9ITnMuM?t=00h58m32s)

[surprised this is spanning given that i](https://youtu.be/oRci9ITnMuM?t=00h58m35s)

[told it not to uh that's actually kind](https://youtu.be/oRci9ITnMuM?t=00h58m39s)

[of okay for the moment because i think](https://youtu.be/oRci9ITnMuM?t=00h58m43s)

[what i actually want to do is wrap this](https://youtu.be/oRci9ITnMuM?t=00h58m44s)

[guy in a](https://youtu.be/oRci9ITnMuM?t=00h58m46s)

[border um anyway](https://youtu.be/oRci9ITnMuM?t=00h58m47s)

[so we'll let the border handle the](https://youtu.be/oRci9ITnMuM?t=00h58m50s)

[positioning](https://youtu.be/oRci9ITnMuM?t=00h58m52s)

[um and also we're gonna have the border](https://youtu.be/oRci9ITnMuM?t=00h58m53s)

[handle the visibility](https://youtu.be/oRci9ITnMuM?t=00h58m56s)

[because i'd like this thing to be a](https://youtu.be/oRci9ITnMuM?t=00h58m57s)

[little more obvious when there's](https://youtu.be/oRci9ITnMuM?t=00h58m59s)

[no actually i want the visibility to](https://youtu.be/oRci9ITnMuM?t=00h59m01s)

[stay here um](https://youtu.be/oRci9ITnMuM?t=00h59m03s)

[because i'm going to do let's see border](https://youtu.be/oRci9ITnMuM?t=00h59m05s)

[thickness of one](https://youtu.be/oRci9ITnMuM?t=00h59m08s)

[border brush um](https://youtu.be/oRci9ITnMuM?t=00h59m11s)

[let's see binding](https://youtu.be/oRci9ITnMuM?t=00h59m16s)

[how do we want to go about doing this i](https://youtu.be/oRci9ITnMuM?t=00h59m20s)

[think what i want to do is just](https://youtu.be/oRci9ITnMuM?t=00h59m22s)

[bind the foreground](https://youtu.be/oRci9ITnMuM?t=00h59m24s)

[color i think is what we want](https://youtu.be/oRci9ITnMuM?t=00h59m27s)

[um and so that i don't remember the](https://youtu.be/oRci9ITnMuM?t=00h59m31s)

[theme brush that i want for that](https://youtu.be/oRci9ITnMuM?t=00h59m33s)

[but that will be under the window theme](https://youtu.be/oRci9ITnMuM?t=00h59m36s)

[so what did i set the so i want to use](https://youtu.be/oRci9ITnMuM?t=00h59m42s)

[the body brush](https://youtu.be/oRci9ITnMuM?t=00h59m45s)

[um just so that there's](https://youtu.be/oRci9ITnMuM?t=00h59m50s)

[a little bit of there and then something](https://youtu.be/oRci9ITnMuM?t=00h59m53s)

[like a corner radius of four](https://youtu.be/oRci9ITnMuM?t=00h59m55s)

[and then maybe a padding of](https://youtu.be/oRci9ITnMuM?t=00h59m58s)

[two along the inside not a lot just just](https://youtu.be/oRci9ITnMuM?t=01h00m01s)

[enough to give it](https://youtu.be/oRci9ITnMuM?t=01h00m04s)

[so that we can tell where the icon is](https://youtu.be/oRci9ITnMuM?t=01h00m06s)

[and where the icon isn't right](https://youtu.be/oRci9ITnMuM?t=01h00m08s)

[uh let's see oh and we did not](https://youtu.be/oRci9ITnMuM?t=01h00m11s)

[set any alignment on this guy so that](https://youtu.be/oRci9ITnMuM?t=01h00m15s)

[kind of makes sense](https://youtu.be/oRci9ITnMuM?t=01h00m18s)

[so let's do horizontal alignment](https://youtu.be/oRci9ITnMuM?t=01h00m20s)

[center](https://youtu.be/oRci9ITnMuM?t=01h00m26s)

[uh still a little shocked oh this guy](https://youtu.be/oRci9ITnMuM?t=01h00m30s)

[has a margin of 10 specified around him](https://youtu.be/oRci9ITnMuM?t=01h00m33s)

[this margin needs to move](https://youtu.be/oRci9ITnMuM?t=01h00m35s)

[off of here and up to here](https://youtu.be/oRci9ITnMuM?t=01h00m36s)

[all right because we do want some space](https://youtu.be/oRci9ITnMuM?t=01h00m41s)

[around the icon but we want it](https://youtu.be/oRci9ITnMuM?t=01h00m42s)

[yeah so why is that guy spanning](https://youtu.be/oRci9ITnMuM?t=01h00m46s)

[it may not matter much](https://youtu.be/oRci9ITnMuM?t=01h00m55s)

[actually i because i think what i want](https://youtu.be/oRci9ITnMuM?t=01h00m58s)

[anyway](https://youtu.be/oRci9ITnMuM?t=01h01m01s)

[is i think i'm going to move it](https://youtu.be/oRci9ITnMuM?t=01h01m02s)

[with up inside of this](https://youtu.be/oRci9ITnMuM?t=01h01m06s)

[yeah because if we put it inside of here](https://youtu.be/oRci9ITnMuM?t=01h01m21s)

[oh wait](https://youtu.be/oRci9ITnMuM?t=01h01m24s)

[oh got it uh this thing has a width of](https://youtu.be/oRci9ITnMuM?t=01h01m31s)

[01:01:35,359 --> 01:01:39,920](https://youtu.be/oRci9ITnMuM?t=01h01m34s)

not 40. that would probably make a big

[difference](https://youtu.be/oRci9ITnMuM?t=01h01m38s)

[um let's indent that so it's a little](https://youtu.be/oRci9ITnMuM?t=01h01m39s)

[more obvious where all the thingies are](https://youtu.be/oRci9ITnMuM?t=01h01m44s)

[why are you indented so far you should](https://youtu.be/oRci9ITnMuM?t=01h01m48s)

[not be indented so much](https://youtu.be/oRci9ITnMuM?t=01h01m50s)

[uh two three four uh okay so that's](https://youtu.be/oRci9ITnMuM?t=01h01m52s)

[better there](https://youtu.be/oRci9ITnMuM?t=01h01m56s)

[and then i want to bring](https://youtu.be/oRci9ITnMuM?t=01h02m00s)

[this guy down vertical alignment](https://youtu.be/oRci9ITnMuM?t=01h02m05s)

[center and](https://youtu.be/oRci9ITnMuM?t=01h02m09s)

[there that looks a little better so now](https://youtu.be/oRci9ITnMuM?t=01h02m13s)

[we can](https://youtu.be/oRci9ITnMuM?t=01h02m15s)

[adjust that i might even go a little bit](https://youtu.be/oRci9ITnMuM?t=01h02m18s)

[further](https://youtu.be/oRci9ITnMuM?t=01h02m20s)

[okay we're gonna ditch this stack panel](https://youtu.be/oRci9ITnMuM?t=01h02m23s)

[let's do a grid](https://youtu.be/oRci9ITnMuM?t=01h02m25s)

[inside of here um so let's see grid](https://youtu.be/oRci9ITnMuM?t=01h02m26s)

[column definitions let's see i want one](https://youtu.be/oRci9ITnMuM?t=01h02m31s)

[column dish](https://youtu.be/oRci9ITnMuM?t=01h02m34s)

[column to fill i want the second column](https://youtu.be/oRci9ITnMuM?t=01h02m35s)

[to be](https://youtu.be/oRci9ITnMuM?t=01h02m38s)

[auto and then i want two rows](https://youtu.be/oRci9ITnMuM?t=01h02m40s)

[uh let's see row definitions and i want](https://youtu.be/oRci9ITnMuM?t=01h02m44s)

[both of these to just](https://youtu.be/oRci9ITnMuM?t=01h02m46s)

[size to their content so we'll do auto](https://youtu.be/oRci9ITnMuM?t=01h02m48s)

[there](https://youtu.be/oRci9ITnMuM?t=01h02m51s)

[put two of those so this guy here](https://youtu.be/oRci9ITnMuM?t=01h02m53s)

[i don't think i need this quite yet so](https://youtu.be/oRci9ITnMuM?t=01h02m58s)

[grid](https://youtu.be/oRci9ITnMuM?t=01h03m00s)

[let's see so column zero will be the](https://youtu.be/oRci9ITnMuM?t=01h03m02s)

[default row zero will be the default](https://youtu.be/oRci9ITnMuM?t=01h03m03s)

[he's already where i want him to be this](https://youtu.be/oRci9ITnMuM?t=01h03m06s)

[guy here](https://youtu.be/oRci9ITnMuM?t=01h03m09s)

[is not i want him to be](https://youtu.be/oRci9ITnMuM?t=01h03m10s)

[uh let's see grid column one](https://youtu.be/oRci9ITnMuM?t=01h03m13s)

[uh and i would like him to grid](https://youtu.be/oRci9ITnMuM?t=01h03m17s)

[uh row span of two](https://youtu.be/oRci9ITnMuM?t=01h03m20s)

[right and then this guy here i would](https://youtu.be/oRci9ITnMuM?t=01h03m24s)

[like to move](https://youtu.be/oRci9ITnMuM?t=01h03m26s)

[inside of my grid and i would like this](https://youtu.be/oRci9ITnMuM?t=01h03m28s)

[stack panel to be](https://youtu.be/oRci9ITnMuM?t=01h03m31s)

[grid row one](https://youtu.be/oRci9ITnMuM?t=01h03m32s)

[grid column zero](https://youtu.be/oRci9ITnMuM?t=01h03m37s)

[all right so that now lays out a little](https://youtu.be/oRci9ITnMuM?t=01h03m40s)

[bit more like that](https://youtu.be/oRci9ITnMuM?t=01h03m42s)

[that feels a little bit nicer](https://youtu.be/oRci9ITnMuM?t=01h03m45s)

[i think i think we can now drop](https://youtu.be/oRci9ITnMuM?t=01h03m49s)

[that margin because i don't think we](https://youtu.be/oRci9ITnMuM?t=01h03m52s)

[need quite as much space around it](https://youtu.be/oRci9ITnMuM?t=01h03m55s)

[yeah i think i think i'm going to put a](https://youtu.be/oRci9ITnMuM?t=01h04m04s)

[little bit of the margin back](https://youtu.be/oRci9ITnMuM?t=01h04m06s)

[but i think i'm more interested in zero](https://youtu.be/oRci9ITnMuM?t=01h04m08s)

[so let's see left top right](https://youtu.be/oRci9ITnMuM?t=01h04m11s)

[bottom i'm just interested in pushing it](https://youtu.be/oRci9ITnMuM?t=01h04m15s)

[off the edge of that pop-up just a](https://youtu.be/oRci9ITnMuM?t=01h04m17s)

[little bit](https://youtu.be/oRci9ITnMuM?t=01h04m18s)

[that looks a little bit nicer](https://youtu.be/oRci9ITnMuM?t=01h04m20s)

[that looks a little bit nicer now we've](https://youtu.be/oRci9ITnMuM?t=01h04m25s)

[got](https://youtu.be/oRci9ITnMuM?t=01h04m27s)

[we still need to give ourselves some way](https://youtu.be/oRci9ITnMuM?t=01h04m29s)

[to type in hex codes](https://youtu.be/oRci9ITnMuM?t=01h04m30s)

[should be nice](https://youtu.be/oRci9ITnMuM?t=01h04m33s)

[but we've got we've got all the makings](https://youtu.be/oRci9ITnMuM?t=01h04m40s)

[of what we need](https://youtu.be/oRci9ITnMuM?t=01h04m43s)

[okay so let's actually build some logic](https://youtu.be/oRci9ITnMuM?t=01h04m44s)

[for this](https://youtu.be/oRci9ITnMuM?t=01h04m46s)

[so in our view model let's go back to](https://youtu.be/oRci9ITnMuM?t=01h04m48s)

[that](https://youtu.be/oRci9ITnMuM?t=01h04m50s)

[to their docs page because they have](https://youtu.be/oRci9ITnMuM?t=01h04m51s)

[very conveniently given us exactly what](https://youtu.be/oRci9ITnMuM?t=01h04m55s)

[we need](https://youtu.be/oRci9ITnMuM?t=01h04m58s)

[so step one var save dialog](https://youtu.be/oRci9ITnMuM?t=01h04m59s)

[it's new save dialogue](https://youtu.be/oRci9ITnMuM?t=01h05m03s)

[do so we need to add some stuff on there](https://youtu.be/oRci9ITnMuM?t=01h05m07s)

[but if](https://youtu.be/oRci9ITnMuM?t=01h05m10s)

[save dialogue let's see](https://youtu.be/oRci9ITnMuM?t=01h05m12s)

[uh show dialogue which is a nullable](https://youtu.be/oRci9ITnMuM?t=01h05m16s)

[boolean](https://youtu.be/oRci9ITnMuM?t=01h05m19s)

[if let's see if it's not true](https://youtu.be/oRci9ITnMuM?t=01h05m20s)

[we'll just break right so if they if](https://youtu.be/oRci9ITnMuM?t=01h05m25s)

[they cancel or or just](https://youtu.be/oRci9ITnMuM?t=01h05m27s)

[clear out of it whatever abandon abandon](https://youtu.be/oRci9ITnMuM?t=01h05m28s)

[i'll help](https://youtu.be/oRci9ITnMuM?t=01h05m32s)

[otherwise we're generating an icon okay](https://youtu.be/oRci9ITnMuM?t=01h05m32s)

[so let's](https://youtu.be/oRci9ITnMuM?t=01h05m35s)

[let's see here so we want the blue wolf](https://youtu.be/oRci9ITnMuM?t=01h05m36s)

[icon stuff](https://youtu.be/oRci9ITnMuM?t=01h05m38s)

[i would like uh let's see this is](https://youtu.be/oRci9ITnMuM?t=01h05m40s)

[windows media image](https://youtu.be/oRci9ITnMuM?t=01h05m43s)

[so we'll bring that in okay so we need](https://youtu.be/oRci9ITnMuM?t=01h05m44s)

[ourselves](https://youtu.be/oRci9ITnMuM?t=01h05m48s)

[they want a bitmap source for this](https://youtu.be/oRci9ITnMuM?t=01h05m50s)

[and i think](https://youtu.be/oRci9ITnMuM?t=01h05m53s)

[yeah so i think what we're going to do](https://youtu.be/oRci9ITnMuM?t=01h06m02s)

[is we're just going to take our visual](https://youtu.be/oRci9ITnMuM?t=01h06m03s)

[and use it so let's](https://youtu.be/oRci9ITnMuM?t=01h06m07s)

[we're going to get rid of that for a](https://youtu.be/oRci9ITnMuM?t=01h06m11s)

[moment and i think i'm going to change](https://youtu.be/oRci9ITnMuM?t=01h06m12s)

[this up](https://youtu.be/oRci9ITnMuM?t=01h06m14s)

[so this guy here i think what i what i](https://youtu.be/oRci9ITnMuM?t=01h06m15s)

[actually want to do](https://youtu.be/oRci9ITnMuM?t=01h06m18s)

[is just actually pass in this pack icon](https://youtu.be/oRci9ITnMuM?t=01h06m19s)

[no maybe we'll just create our own we've](https://youtu.be/oRci9ITnMuM?t=01h06m27s)

[already got all the data we need and](https://youtu.be/oRci9ITnMuM?t=01h06m30s)

[then i can leave then i don't have to](https://youtu.be/oRci9ITnMuM?t=01h06m31s)

[worry about this guy we'll just make our](https://youtu.be/oRci9ITnMuM?t=01h06m33s)

[own](https://youtu.be/oRci9ITnMuM?t=01h06m34s)

[so we need to uh convert](https://youtu.be/oRci9ITnMuM?t=01h06m35s)

[so for people who haven't done this](https://youtu.be/oRci9ITnMuM?t=01h06m40s)

[before i usually have to look it up](https://youtu.be/oRci9ITnMuM?t=01h06m41s)

[let's see wpf visual to](https://youtu.be/oRci9ITnMuM?t=01h06m43s)

[brush or something there's a](https://youtu.be/oRci9ITnMuM?t=01h06m47s)

[uh wpf visual to](https://youtu.be/oRci9ITnMuM?t=01h06m52s)

[bitmap because you can convert](https://youtu.be/oRci9ITnMuM?t=01h06m55s)

[create a bitmap from a visual that's](https://youtu.be/oRci9ITnMuM?t=01h06m59s)

[that's mostly what i'm wanting](https://youtu.be/oRci9ITnMuM?t=01h07m01s)

[okay so something something something](https://youtu.be/oRci9ITnMuM?t=01h07m04s)

[render target bitmap this is what i want](https://youtu.be/oRci9ITnMuM?t=01h07m08s)

[so i want to do this so render target](https://youtu.be/oRci9ITnMuM?t=01h07m11s)

[bitmap](https://youtu.be/oRci9ITnMuM?t=01h07m14s)

[let's see bitmap and it wants a visual](https://youtu.be/oRci9ITnMuM?t=01h07m19s)

[and then you'll note the this guy here](https://youtu.be/oRci9ITnMuM?t=01h07m22s)

[can be used as a bitmap source so](https://youtu.be/oRci9ITnMuM?t=01h07m24s)

[this is the magic sauce](https://youtu.be/oRci9ITnMuM?t=01h07m27s)

[that we want okay so let's grab](https://youtu.be/oRci9ITnMuM?t=01h07m30s)

[this so render target bitmap](https://youtu.be/oRci9ITnMuM?t=01h07m34s)

[we'll go with that so what we need here](https://youtu.be/oRci9ITnMuM?t=01h07m37s)

[is any bitmap source will be accepted](https://youtu.be/oRci9ITnMuM?t=01h07m40s)

[excellent that is exactly what we want](https://youtu.be/oRci9ITnMuM?t=01h07m43s)

[so we don't](https://youtu.be/oRci9ITnMuM?t=01h07m46s)

[care about any of this stuff](https://youtu.be/oRci9ITnMuM?t=01h07m46s)

[right uh we want to feed it](https://youtu.be/oRci9ITnMuM?t=01h07m50s)

[that but then more importantly we need](https://youtu.be/oRci9ITnMuM?t=01h07m54s)

[to give this guy a visual](https://youtu.be/oRci9ITnMuM?t=01h07m56s)

[so let's do target type new because](https://youtu.be/oRci9ITnMuM?t=01h07m58s)

[we've got c sharp nine](https://youtu.be/oRci9ITnMuM?t=01h08m00s)

[so var pack icon gets new](https://youtu.be/oRci9ITnMuM?t=01h08m02s)

[pack icon all right and then based on](https://youtu.be/oRci9ITnMuM?t=01h08m06s)

[what we have](https://youtu.be/oRci9ITnMuM?t=01h08m10s)

[above we know that our kind will be](https://youtu.be/oRci9ITnMuM?t=01h08m11s)

[pack icon kind so we'll just grab that](https://youtu.be/oRci9ITnMuM?t=01h08m16s)

[kind gets that](https://youtu.be/oRci9ITnMuM?t=01h08m21s)

[background gets new solid color](https://youtu.be/oRci9ITnMuM?t=01h08m25s)

[brush of generated icon background](https://youtu.be/oRci9ITnMuM?t=01h08m28s)

[let's see and foreground gets](https://youtu.be/oRci9ITnMuM?t=01h08m35s)

[new solid color brush](https://youtu.be/oRci9ITnMuM?t=01h08m38s)

[generate item foreground](https://youtu.be/oRci9ITnMuM?t=01h08m44s)

[all right so that gives us that and then](https://youtu.be/oRci9ITnMuM?t=01h08m47s)

[we need a resolution](https://youtu.be/oRci9ITnMuM?t=01h08m50s)

[size so i think for now what we're going](https://youtu.be/oRci9ITnMuM?t=01h08m52s)

[to do is we're just going to do 256](https://youtu.be/oRci9ITnMuM?t=01h08m53s)

[right so what are these things pixel](https://youtu.be/oRci9ITnMuM?t=01h08m56s)

[height pixel wick dpi](https://youtu.be/oRci9ITnMuM?t=01h08m58s)

[yeah so we're just going to go standard](https://youtu.be/oRci9ITnMuM?t=01h09m01s)

[dpi](https://youtu.be/oRci9ITnMuM?t=01h09m04s)

[256x256](https://youtu.be/oRci9ITnMuM?t=01h09m06s)

[and then we are going to render the pack](https://youtu.be/oRci9ITnMuM?t=01h09m09s)

[icon](https://youtu.be/oRci9ITnMuM?t=01h09m12s)

[into here um the last thing well we're](https://youtu.be/oRci9ITnMuM?t=01h09m12s)

[going to give this a shot here real](https://youtu.be/oRci9ITnMuM?t=01h09m15s)

[quick](https://youtu.be/oRci9ITnMuM?t=01h09m17s)

[and this guy becomes](https://youtu.be/oRci9ITnMuM?t=01h09m18s)

[see save file or](https://youtu.be/oRci9ITnMuM?t=01h09m21s)

[save dialog](https://youtu.be/oRci9ITnMuM?t=01h09m25s)

[like file path right file name](https://youtu.be/oRci9ITnMuM?t=01h09m28s)

[great something like that um](https://youtu.be/oRci9ITnMuM?t=01h09m34s)

[let's see let's set up just a](https://youtu.be/oRci9ITnMuM?t=01h09m38s)

[couple itty-bitty little things here so](https://youtu.be/oRci9ITnMuM?t=01h09m41s)

[uh let's see default extension is going](https://youtu.be/oRci9ITnMuM?t=01h09m45s)

[to be](https://youtu.be/oRci9ITnMuM?t=01h09m47s)

[dot ico let's see the](https://youtu.be/oRci9ITnMuM?t=01h09m48s)

[title will be](https://youtu.be/oRci9ITnMuM?t=01h09m51s)

[save icon](https://youtu.be/oRci9ITnMuM?t=01h09m54s)

[let's see we should probably have a](https://youtu.be/oRci9ITnMuM?t=01h10m00s)

[filter set](https://youtu.be/oRci9ITnMuM?t=01h10m03s)

[icon files and i'm doing this from](https://youtu.be/oRci9ITnMuM?t=01h10m05s)

[memory](https://youtu.be/oRci9ITnMuM?t=01h10m08s)

[dot ico so i am very likely to get this](https://youtu.be/oRci9ITnMuM?t=01h10m10s)

[wrong](https://youtu.be/oRci9ITnMuM?t=01h10m13s)

[all files star](https://youtu.be/oRci9ITnMuM?t=01h10m15s)

[um](https://youtu.be/oRci9ITnMuM?t=01h10m21s)

[trying to remember what else is](https://youtu.be/oRci9ITnMuM?t=01h10m26s)

[important to set on these things uh](https://youtu.be/oRci9ITnMuM?t=01h10m27s)

[let's see](https://youtu.be/oRci9ITnMuM?t=01h10m29s)

[like to confirm that the path exists i](https://youtu.be/oRci9ITnMuM?t=01h10m36s)

[don't want to think too hard oh](https://youtu.be/oRci9ITnMuM?t=01h10m39s)

[say oh overwrite prompt definitely we](https://youtu.be/oRci9ITnMuM?t=01h10m41s)

[want to](https://youtu.be/oRci9ITnMuM?t=01h10m44s)

[warn them of that i don't know what this](https://youtu.be/oRci9ITnMuM?t=01h10m45s)

[what this library is going to do if you](https://youtu.be/oRci9ITnMuM?t=01h10m48s)

[feed in an existing file](https://youtu.be/oRci9ITnMuM?t=01h10m49s)

[restore directory i would very much](https://youtu.be/oRci9ITnMuM?t=01h10m51s)

[appreciate if you would remember where i](https://youtu.be/oRci9ITnMuM?t=01h10m53s)

[was last time](https://youtu.be/oRci9ITnMuM?t=01h10m55s)

[uh okay something like that let's see if](https://youtu.be/oRci9ITnMuM?t=01h10m57s)

[it works](https://youtu.be/oRci9ITnMuM?t=01h10m59s)

[just like that we might have a nice way](https://youtu.be/oRci9ITnMuM?t=01h11m09s)

[of generating](https://youtu.be/oRci9ITnMuM?t=01h11m11s)

[icons for our apps](https://youtu.be/oRci9ITnMuM?t=01h11m14s)

[okay so let's see icon](https://youtu.be/oRci9ITnMuM?t=01h11m19s)

[pack something like this pop this](https://youtu.be/oRci9ITnMuM?t=01h11m22s)

[guy open so we're going to](https://youtu.be/oRci9ITnMuM?t=01h11m26s)

[set our foreground to red our background](https://youtu.be/oRci9ITnMuM?t=01h11m29s)

[to blue](https://youtu.be/oRci9ITnMuM?t=01h11m31s)

[right we should probably have some](https://youtu.be/oRci9ITnMuM?t=01h11m33s)

[better defaults but](https://youtu.be/oRci9ITnMuM?t=01h11m35s)

[that'll be good enough so here we go the](https://youtu.be/oRci9ITnMuM?t=01h11m37s)

[one thing i do wonder about if we're](https://youtu.be/oRci9ITnMuM?t=01h11m40s)

[gonna have to](https://youtu.be/oRci9ITnMuM?t=01h11m42s)

[uh sure](https://youtu.be/oRci9ITnMuM?t=01h11m44s)

[test okay i do wonder if we're gonna](https://youtu.be/oRci9ITnMuM?t=01h11m48s)

[have to force this thing to render](https://youtu.be/oRci9ITnMuM?t=01h11m51s)

[because he hasn't been measured or laid](https://youtu.be/oRci9ITnMuM?t=01h11m54s)

[out yeah i kind of wonder if we're gonna](https://youtu.be/oRci9ITnMuM?t=01h11m56s)

[have to do that](https://youtu.be/oRci9ITnMuM?t=01h11m58s)

[kind of wonder well we're gonna see what](https://youtu.be/oRci9ITnMuM?t=01h12m05s)

[it](https://youtu.be/oRci9ITnMuM?t=01h12m09s)

[we're gonna see what it does](https://youtu.be/oRci9ITnMuM?t=01h12m09s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h12m12s)

[okay so let me go grab that directory](https://youtu.be/oRci9ITnMuM?t=01h12m14s)

[let's see here where did it go](https://youtu.be/oRci9ITnMuM?t=01h12m22s)

[something documents](https://youtu.be/oRci9ITnMuM?t=01h12m26s)

[i don't remember where it went so let's](https://youtu.be/oRci9ITnMuM?t=01h12m30s)

[see here save](https://youtu.be/oRci9ITnMuM?t=01h12m32s)

[let's let's grab a break point further](https://youtu.be/oRci9ITnMuM?t=01h12m35s)

[down i don't feel like](https://youtu.be/oRci9ITnMuM?t=01h12m37s)

[i don't feel like chasing it uh](https://youtu.be/oRci9ITnMuM?t=01h12m39s)

[oh it's decolon i'm in the wrong](https://youtu.be/oRci9ITnMuM?t=01h12m42s)

[uh](https://youtu.be/oRci9ITnMuM?t=01h12m50s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h12m51s)

[there um so](https://youtu.be/oRci9ITnMuM?t=01h12m55s)

[let's see if i open this with](https://youtu.be/oRci9ITnMuM?t=01h12m58s)

[uh let's see paint.net or actually](https://youtu.be/oRci9ITnMuM?t=01h13m03s)

[visual studio can open them](https://youtu.be/oRci9ITnMuM?t=01h13m06s)

[so if i just drag you into visual studio](https://youtu.be/oRci9ITnMuM?t=01h13m09s)

[we get a large 256x256 thingy](https://youtu.be/oRci9ITnMuM?t=01h13m13s)

[but he's a bitmap okay so let's](https://youtu.be/oRci9ITnMuM?t=01h13m18s)

[let's go through and make sure that this](https://youtu.be/oRci9ITnMuM?t=01h13m22s)

[guy gets](https://youtu.be/oRci9ITnMuM?t=01h13m24s)

[measured uh](https://youtu.be/oRci9ITnMuM?t=01h13m25s)

[um](https://youtu.be/oRci9ITnMuM?t=01h13m30s)

[is it update layout or](https://youtu.be/oRci9ITnMuM?t=01h13m36s)

[uh let's see](https://youtu.be/oRci9ITnMuM?t=01h13m42s)

[measure available size](https://youtu.be/oRci9ITnMuM?t=01h13m48s)

[so i believe what we want is](https://youtu.be/oRci9ITnMuM?t=01h13m51s)

[uh let's see](https://youtu.be/oRci9ITnMuM?t=01h13m54s)

[256 256.](https://youtu.be/oRci9ITnMuM?t=01h14m00s)

[i i think measure might be sufficient so](https://youtu.be/oRci9ITnMuM?t=01h14m05s)

[let's let's restart and try this one](https://youtu.be/oRci9ITnMuM?t=01h14m08s)

[more time](https://youtu.be/oRci9ITnMuM?t=01h14m10s)

[i'm trying to remember the exact there](https://youtu.be/oRci9ITnMuM?t=01h14m11s)

[there's a special invocation when you](https://youtu.be/oRci9ITnMuM?t=01h14m12s)

[have](https://youtu.be/oRci9ITnMuM?t=01h14m15s)

[ui elements that you're creating](https://youtu.be/oRci9ITnMuM?t=01h14m15s)

[manually](https://youtu.be/oRci9ITnMuM?t=01h14m17s)

[let's see icon pack](https://youtu.be/oRci9ITnMuM?t=01h14m24s)

[pick one see there](https://youtu.be/oRci9ITnMuM?t=01h14m28s)

[background save](https://youtu.be/oRci9ITnMuM?t=01h14m32s)

[uh](https://youtu.be/oRci9ITnMuM?t=01h14m40s)

[save so i just deleted the file because](https://youtu.be/oRci9ITnMuM?t=01h14m42s)

[i didn't want to make sure i want to](https://youtu.be/oRci9ITnMuM?t=01h14m45s)

[make sure we didn't have any issues](https://youtu.be/oRci9ITnMuM?t=01h14m47s)

[now if i did that](https://youtu.be/oRci9ITnMuM?t=01h14m48s)

[have you been laid out](https://youtu.be/oRci9ITnMuM?t=01h14m52s)

[you haven't yet so let's let's just play](https://youtu.be/oRci9ITnMuM?t=01h14m55s)

[around with this so pack](https://youtu.be/oRci9ITnMuM?t=01h14m57s)

[icon if i do update layout](https://youtu.be/oRci9ITnMuM?t=01h14m59s)

[uh uh](https://youtu.be/oRci9ITnMuM?t=01h15m10s)

[pack icon](https://youtu.be/oRci9ITnMuM?t=01h15m15s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h15m18s)

[uh](https://youtu.be/oRci9ITnMuM?t=01h15m22s)

[um there's a magical incantation and i](https://youtu.be/oRci9ITnMuM?t=01h15m29s)

[don't recall what it is](https://youtu.be/oRci9ITnMuM?t=01h15m32s)

[they are not using it here uh](https://youtu.be/oRci9ITnMuM?t=01h15m33s)

[from visual to bitmap](https://youtu.be/oRci9ITnMuM?t=01h15m37s)

[render target bitmap drawing visual](https://youtu.be/oRci9ITnMuM?t=01h15m41s)

[yeah that's not quite the same](https://youtu.be/oRci9ITnMuM?t=01h15m45s)

[how to get bitmap from a visual](https://youtu.be/oRci9ITnMuM?t=01h15m51s)

[because most of the time people are](https://youtu.be/oRci9ITnMuM?t=01h15m55s)

[doing this with um](https://youtu.be/oRci9ITnMuM?t=01h15m57s)

[visuals that they've already laid out](https://youtu.be/oRci9ITnMuM?t=01h15m59s)

[right so you'll note](https://youtu.be/oRci9ITnMuM?t=01h16m07s)

[see this guy here is taking in a visual](https://youtu.be/oRci9ITnMuM?t=01h16m10s)

[but i want to](https://youtu.be/oRci9ITnMuM?t=01h16m13s)

[i want to instantiate and force](https://youtu.be/oRci9ITnMuM?t=01h16m18s)

[layout uh](https://youtu.be/oRci9ITnMuM?t=01h16m21s)

[all right so once again render target](https://youtu.be/oRci9ITnMuM?t=01h16m29s)

[bitmap](https://youtu.be/oRci9ITnMuM?t=01h16m30s)

[but in this case this is actually](https://youtu.be/oRci9ITnMuM?t=01h16m33s)

[leveraging](https://youtu.be/oRci9ITnMuM?t=01h16m35s)

[oh um if i it's sizing to zero because](https://youtu.be/oRci9ITnMuM?t=01h16m41s)

[the pack icon doesn't require a size](https://youtu.be/oRci9ITnMuM?t=01h16m46s)

[so if i do pack icon](https://youtu.be/oRci9ITnMuM?t=01h16m48s)

[dot width gets 256](https://youtu.be/oRci9ITnMuM?t=01h16m52s)

[right and then pack icon](https://youtu.be/oRci9ITnMuM?t=01h16m56s)

[height gets 256](https://youtu.be/oRci9ITnMuM?t=01h17m02s)

[right and then we check it](https://youtu.be/oRci9ITnMuM?t=01h17m06s)

[and then we do pack icon](https://youtu.be/oRci9ITnMuM?t=01h17m10s)

[update layout](https://youtu.be/oRci9ITnMuM?t=01h17m14s)

[then we check it and see](https://youtu.be/oRci9ITnMuM?t=01h17m17s)

[uh let's do this guy too](https://youtu.be/oRci9ITnMuM?t=01h17m22s)

[one of one of these things](https://youtu.be/oRci9ITnMuM?t=01h17m25s)

[uh give me another update layout](https://youtu.be/oRci9ITnMuM?t=01h17m31s)

[i'm hoping to see these actual with](https://youtu.be/oRci9ITnMuM?t=01h17m36s)

[actual size things change](https://youtu.be/oRci9ITnMuM?t=01h17m38s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h17m40s)

[um](https://youtu.be/oRci9ITnMuM?t=01h17m42s)

[that is not overly helpful](https://youtu.be/oRci9ITnMuM?t=01h17m46s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h17m49s)

[uh let's see wpf](https://youtu.be/oRci9ITnMuM?t=01h17m50s)

[render target bitmap](https://youtu.be/oRci9ITnMuM?t=01h17m55s)

[uh let's see force](https://youtu.be/oRci9ITnMuM?t=01h17m58s)

[visual layout something to that effect](https://youtu.be/oRci9ITnMuM?t=01h18m01s)

[uh yeah this looks more right](https://youtu.be/oRci9ITnMuM?t=01h18m06s)

[measure a range update layout ah](https://youtu.be/oRci9ITnMuM?t=01h18m12s)

[okay so if we do](https://youtu.be/oRci9ITnMuM?t=01h18m16s)

[uh so let's start with that](https://youtu.be/oRci9ITnMuM?t=01h18m20s)

[uh measure](https://youtu.be/oRci9ITnMuM?t=01h18m24s)

[pack icon dot](https://youtu.be/oRci9ITnMuM?t=01h18m28s)

[arrange to do](https://youtu.be/oRci9ITnMuM?t=01h18m32s)

[new rect 0 0](https://youtu.be/oRci9ITnMuM?t=01h18m35s)

[256 256 boom boom](https://youtu.be/oRci9ITnMuM?t=01h18m39s)

[like that and then we do another](https://youtu.be/oRci9ITnMuM?t=01h18m43s)

[update layout then when we investigate](https://youtu.be/oRci9ITnMuM?t=01h18m46s)

[you](https://youtu.be/oRci9ITnMuM?t=01h18m49s)

[huzzah you have a size coup so this guy](https://youtu.be/oRci9ITnMuM?t=01h18m50s)

[should](https://youtu.be/oRci9ITnMuM?t=01h18m53s)

[render now we'll let that go](https://youtu.be/oRci9ITnMuM?t=01h18m54s)

[i will come back over to my folder and i](https://youtu.be/oRci9ITnMuM?t=01h18m58s)

[will just drag it into visual studio](https://youtu.be/oRci9ITnMuM?t=01h19m01s)

[and as you can see it clearly rendered](https://youtu.be/oRci9ITnMuM?t=01h19m04s)

[an empty string](https://youtu.be/oRci9ITnMuM?t=01h19m06s)

[that is totally exciting and not quite](https://youtu.be/oRci9ITnMuM?t=01h19m08s)

[what we were going for](https://youtu.be/oRci9ITnMuM?t=01h19m11s)

[that is](https://youtu.be/oRci9ITnMuM?t=01h19m15s)

[definitely not what we were looking for](https://youtu.be/oRci9ITnMuM?t=01h19m18s)

[not black](https://youtu.be/oRci9ITnMuM?t=01h19m20s)

[um but now that we've got that so](https://youtu.be/oRci9ITnMuM?t=01h19m22s)

[let's let's add these things in because](https://youtu.be/oRci9ITnMuM?t=01h19m26s)

[we do know several things that that i](https://youtu.be/oRci9ITnMuM?t=01h19m28s)

[missed](https://youtu.be/oRci9ITnMuM?t=01h19m30s)

[so um how about](https://youtu.be/oRci9ITnMuM?t=01h19m31s)

[we wrap this guy up in a nice little](https://youtu.be/oRci9ITnMuM?t=01h19m34s)

[method um](https://youtu.be/oRci9ITnMuM?t=01h19m39s)

[render image](https://youtu.be/oRci9ITnMuM?t=01h19m42s)

[uh int size right because we're gonna](https://youtu.be/oRci9ITnMuM?t=01h19m45s)

[end up doing this in a loop for all the](https://youtu.be/oRci9ITnMuM?t=01h19m48s)

[different sizes](https://youtu.be/oRci9ITnMuM?t=01h19m50s)

[so i kind of want to do okay](https://youtu.be/oRci9ITnMuM?t=01h19m52s)

[stop stop for a minute stop for a minute](https://youtu.be/oRci9ITnMuM?t=01h19m55s)

[i'll get back to you in a minute](https://youtu.be/oRci9ITnMuM?t=01h19m57s)

[okay so width gets size](https://youtu.be/oRci9ITnMuM?t=01h19m58s)

[height get size](https://youtu.be/oRci9ITnMuM?t=01h20m02s)

[right and then](https://youtu.be/oRci9ITnMuM?t=01h20m05s)

[this guy should also be size](https://youtu.be/oRci9ITnMuM?t=01h20m09s)

[size semicolon there](https://youtu.be/oRci9ITnMuM?t=01h20m12s)

[uh let's see measure arrange](https://youtu.be/oRci9ITnMuM?t=01h20m15s)

[this becomes a rectangle start at the](https://youtu.be/oRci9ITnMuM?t=01h20m20s)

[origin](https://youtu.be/oRci9ITnMuM?t=01h20m23s)

[and arrange with size and then](https://youtu.be/oRci9ITnMuM?t=01h20m24s)

[see pack icon update layout](https://youtu.be/oRci9ITnMuM?t=01h20m28s)

[that goes like that and then i am](https://youtu.be/oRci9ITnMuM?t=01h20m34s)

[wondering if this](https://youtu.be/oRci9ITnMuM?t=01h20m37s)

[pixel format is problematic so let's see](https://youtu.be/oRci9ITnMuM?t=01h20m38s)

[so we're going to come up here](https://youtu.be/oRci9ITnMuM?t=01h20m41s)

[um var bitmap gets](https://youtu.be/oRci9ITnMuM?t=01h20m43s)

[render image at 256. right and actually](https://youtu.be/oRci9ITnMuM?t=01h20m47s)

[let's do 128](https://youtu.be/oRci9ITnMuM?t=01h20m50s)

[just to start](https://youtu.be/oRci9ITnMuM?t=01h20m52s)

[and this guy down here should return](https://youtu.be/oRci9ITnMuM?t=01h20m56s)

[the bitmap](https://youtu.be/oRci9ITnMuM?t=01h21m00s)

[and you are happy you are happy because](https://youtu.be/oRci9ITnMuM?t=01h21m04s)

[ideally we start building each of these](https://youtu.be/oRci9ITnMuM?t=01h21m06s)

[up](https://youtu.be/oRci9ITnMuM?t=01h21m08s)

[so this guy here](https://youtu.be/oRci9ITnMuM?t=01h21m09s)

[let's see what is this generate map](https://youtu.be/oRci9ITnMuM?t=01h21m14s)

[transparency map or not we're gonna](https://youtu.be/oRci9ITnMuM?t=01h21m17s)

[leave that](https://youtu.be/oRci9ITnMuM?t=01h21m20s)

[off for the moment oh it defaults to](https://youtu.be/oRci9ITnMuM?t=01h21m21s)

[true so that's](https://youtu.be/oRci9ITnMuM?t=01h21m24s)

[okay sure fine um original image gets](https://youtu.be/oRci9ITnMuM?t=01h21m25s)

[set](https://youtu.be/oRci9ITnMuM?t=01h21m29s)

[bits per pixel i do wonder what this is](https://youtu.be/oRci9ITnMuM?t=01h21m33s)

[being set to](https://youtu.be/oRci9ITnMuM?t=01h21m35s)

[i i hope 32 because if it's not](https://youtu.be/oRci9ITnMuM?t=01h21m37s)

[um uh](https://youtu.be/oRci9ITnMuM?t=01h21m42s)

[i think this might need to just be bgr](https://youtu.be/oRci9ITnMuM?t=01h21m46s)

[it doesn't uh let's see if it says](https://youtu.be/oRci9ITnMuM?t=01h21m57s)

[back on the boom file format what](https://youtu.be/oRci9ITnMuM?t=01h22m02s)

[is](https://youtu.be/oRci9ITnMuM?t=01h22m08s)

[uh 32 bits of color depth so it](https://youtu.be/oRci9ITnMuM?t=01h22m11s)

[definitely needs 32](https://youtu.be/oRci9ITnMuM?t=01h22m13s)

[bits](https://youtu.be/oRci9ITnMuM?t=01h22m15s)

[um](https://youtu.be/oRci9ITnMuM?t=01h22m22s)

[are specifically a 24-bit image with the](https://youtu.be/oRci9ITnMuM?t=01h22m24s)

[addition of an 8-bit channel for alpha](https://youtu.be/oRci9ITnMuM?t=01h22m26s)

[thus 32-bit images and the mask](https://youtu.be/oRci9ITnMuM?t=01h22m29s)

[are not required but recommended](https://youtu.be/oRci9ITnMuM?t=01h22m32s)

[um okay](https://youtu.be/oRci9ITnMuM?t=01h22m38s)

[it doesn't say](https://youtu.be/oRci9ITnMuM?t=01h22m42s)

[bmp format](https://youtu.be/oRci9ITnMuM?t=01h22m48s)

[must call that out](https://youtu.be/oRci9ITnMuM?t=01h22m52s)

[um](https://youtu.be/oRci9ITnMuM?t=01h22m57s)

[let's look real quick i was going to use](https://youtu.be/oRci9ITnMuM?t=01h23m05s)

[a bmp file format uh](https://youtu.be/oRci9ITnMuM?t=01h23m08s)

[did](https://youtu.be/oRci9ITnMuM?t=01h23m18s)

[let's let's just give this a try it's](https://youtu.be/oRci9ITnMuM?t=01h23m25s)

[probably just as easy to](https://youtu.be/oRci9ITnMuM?t=01h23m26s)

[test this out here](https://youtu.be/oRci9ITnMuM?t=01h23m29s)

[and see what happens](https://youtu.be/oRci9ITnMuM?t=01h23m32s)

[okay fire this off and i'm gonna put one](https://youtu.be/oRci9ITnMuM?t=01h23m40s)

[more](https://youtu.be/oRci9ITnMuM?t=01h23m42s)

[one more break point um](https://youtu.be/oRci9ITnMuM?t=01h23m45s)

[after this guy and i don't think we need](https://youtu.be/oRci9ITnMuM?t=01h23m50s)

[the the prior one](https://youtu.be/oRci9ITnMuM?t=01h23m53s)

[uh i do actually want to verify that](https://youtu.be/oRci9ITnMuM?t=01h23m55s)

[before we render it that this guy now is](https://youtu.be/oRci9ITnMuM?t=01h23m58s)

[appropriately showing our size icon pack](https://youtu.be/oRci9ITnMuM?t=01h24m00s)

[boom oh we gotta pick one](https://youtu.be/oRci9ITnMuM?t=01h24m05s)

[going with the cowboy again](https://youtu.be/oRci9ITnMuM?t=01h24m09s)

[and background](https://youtu.be/oRci9ITnMuM?t=01h24m12s)

[save](https://youtu.be/oRci9ITnMuM?t=01h24m17s)

[and delete file](https://youtu.be/oRci9ITnMuM?t=01h24m20s)

[save okay so pack icon](https://youtu.be/oRci9ITnMuM?t=01h24m24s)

[did you render a size you did](https://youtu.be/oRci9ITnMuM?t=01h24m27s)

[oh but we are dumb](https://youtu.be/oRci9ITnMuM?t=01h24m31s)

[and i did not finish updating all of](https://youtu.be/oRci9ITnMuM?t=01h24m35s)

[these](https://youtu.be/oRci9ITnMuM?t=01h24m37s)

[to be the appropriate size let's try](https://youtu.be/oRci9ITnMuM?t=01h24m38s)

[this one more time](https://youtu.be/oRci9ITnMuM?t=01h24m41s)

[like all of you to be the right size and](https://youtu.be/oRci9ITnMuM?t=01h24m45s)

[we went down to 128 just to make sure](https://youtu.be/oRci9ITnMuM?t=01h24m47s)

[that it's](https://youtu.be/oRci9ITnMuM?t=01h24m49s)

[not something funky with the the higher](https://youtu.be/oRci9ITnMuM?t=01h24m52s)

[01:24:55,440 --> 01:25:03,760](https://youtu.be/oRci9ITnMuM?t=01h24m54s)

value okay so cowboy

[there foreground background](https://youtu.be/oRci9ITnMuM?t=01h24m59s)

[save](https://youtu.be/oRci9ITnMuM?t=01h25m03s)

[test okay pack icon should have laid out](https://youtu.be/oRci9ITnMuM?t=01h25m08s)

[properly](https://youtu.be/oRci9ITnMuM?t=01h25m11s)

[which it did it's got stuff set on it](https://youtu.be/oRci9ITnMuM?t=01h25m13s)

[we're going to turn this off for now run](https://youtu.be/oRci9ITnMuM?t=01h25m16s)

[through here uh](https://youtu.be/oRci9ITnMuM?t=01h25m19s)

[bgr32 not supported for this operation](https://youtu.be/oRci9ITnMuM?t=01h25m23s)

[i'm sorry really](https://youtu.be/oRci9ITnMuM?t=01h25m28s)

[that is interesting](https://youtu.be/oRci9ITnMuM?t=01h25m32s)

[render target bitmap](https://youtu.be/oRci9ITnMuM?t=01h25m38s)

[uh that's interesting](https://youtu.be/oRci9ITnMuM?t=01h25m43s)

[so let's just look here and see what](https://youtu.be/oRci9ITnMuM?t=01h25m49s)

[so pretty much it's got one option](https://youtu.be/oRci9ITnMuM?t=01h25m55s)

[you can do default or](https://youtu.be/oRci9ITnMuM?t=01h26m01s)

[you can do rgb 32](https://youtu.be/oRci9ITnMuM?t=01h26m08s)

[okay so that's that is exciting](https://youtu.be/oRci9ITnMuM?t=01h26m11s)

[so that is clearly not the the answer to](https://youtu.be/oRci9ITnMuM?t=01h26m25s)

[our woes](https://youtu.be/oRci9ITnMuM?t=01h26m28s)

[so we will put that on there](https://youtu.be/oRci9ITnMuM?t=01h26m29s)

[and switch it back because that is the](https://youtu.be/oRci9ITnMuM?t=01h26m33s)

[that is the choice](https://youtu.be/oRci9ITnMuM?t=01h26m37s)

[just checking to make sure there was](https://youtu.be/oRci9ITnMuM?t=01h26m41s)

[nothing weird that i missed but it](https://youtu.be/oRci9ITnMuM?t=01h26m42s)

[doesn't look like it](https://youtu.be/oRci9ITnMuM?t=01h26m44s)

[okay so let's go here and we are going](https://youtu.be/oRci9ITnMuM?t=01h26m46s)

[to try](https://youtu.be/oRci9ITnMuM?t=01h26m48s)

[again so we'll do that save](https://youtu.be/oRci9ITnMuM?t=01h26m50s)

[okay so if we look here what is the](https://youtu.be/oRci9ITnMuM?t=01h26m59s)

[format bits per pixel is 32](https://youtu.be/oRci9ITnMuM?t=01h27m04s)

[which would appear to be](https://youtu.be/oRci9ITnMuM?t=01h27m10s)

[what we expect oh](https://youtu.be/oRci9ITnMuM?t=01h27m14s)

[i wonder so this](https://youtu.be/oRci9ITnMuM?t=01h27m19s)

[let's see what this thing does with this](https://youtu.be/oRci9ITnMuM?t=01h27m22s)

[image so it uses this to get out](https://youtu.be/oRci9ITnMuM?t=01h27m24s)

[some stuffs but i'm wondering what it](https://youtu.be/oRci9ITnMuM?t=01h27m26s)

[calls get](https://youtu.be/oRci9ITnMuM?t=01h27m30s)

[data what does it do](https://youtu.be/oRci9ITnMuM?t=01h27m31s)

[so it does do a bitmap source](https://youtu.be/oRci9ITnMuM?t=01h27m37s)

[yeah this is what i was wondering if i](https://youtu.be/oRci9ITnMuM?t=01h27m52s)

[needed to do the encoding but it](https://youtu.be/oRci9ITnMuM?t=01h27m53s)

[it appears that that might be good](https://youtu.be/oRci9ITnMuM?t=01h27m56s)

[enough](https://youtu.be/oRci9ITnMuM?t=01h27m59s)

[looks like it's going to handle it for](https://youtu.be/oRci9ITnMuM?t=01h28m03s)

[me](https://youtu.be/oRci9ITnMuM?t=01h28m05s)

[and let's see generate transparency map](https://youtu.be/oRci9ITnMuM?t=01h28m07s)

[well we're going gonna let this go and](https://youtu.be/oRci9ITnMuM?t=01h28m12s)

[if this fails again we might end up](https://youtu.be/oRci9ITnMuM?t=01h28m13s)

[okay so bring it into visual studio and](https://youtu.be/oRci9ITnMuM?t=01h28m20s)

[black square this time smaller](https://youtu.be/oRci9ITnMuM?t=01h28m25s)

[okay so i i'm kind of curious to do](https://youtu.be/oRci9ITnMuM?t=01h28m28s)

[false on this and just turn off that](https://youtu.be/oRci9ITnMuM?t=01h28m33s)

[transparency map for the moment](https://youtu.be/oRci9ITnMuM?t=01h28m37s)

[because i'm wondering if that is causing](https://youtu.be/oRci9ITnMuM?t=01h28m46s)

[me more more harm than good](https://youtu.be/oRci9ITnMuM?t=01h28m47s)

[so go here go here](https://youtu.be/oRci9ITnMuM?t=01h28m50s)

[something like that save](https://youtu.be/oRci9ITnMuM?t=01h28m54s)

[so you delete it save](https://youtu.be/oRci9ITnMuM?t=01h28m59s)

[just see what happens and then bring](https://youtu.be/oRci9ITnMuM?t=01h29m08s)

[that in](https://youtu.be/oRci9ITnMuM?t=01h29m10s)

[so it wrote it half the size](https://youtu.be/oRci9ITnMuM?t=01h29m15s)

[which is interesting and almost](https://youtu.be/oRci9ITnMuM?t=01h29m19s)

[assuredly wrong okay](https://youtu.be/oRci9ITnMuM?t=01h29m21s)

[so something is going wrong here](https://youtu.be/oRci9ITnMuM?t=01h29m22s)

[um i'm somewhat inclined to also do](https://youtu.be/oRci9ITnMuM?t=01h29m26s)

[a just just for my own sanity](https://youtu.be/oRci9ITnMuM?t=01h29m30s)

[bmp uh](https://youtu.be/oRci9ITnMuM?t=01h29m33s)

[i want to i want to write this out to](https://youtu.be/oRci9ITnMuM?t=01h29m39s)

[just a regular bitmap um](https://youtu.be/oRci9ITnMuM?t=01h29m43s)

[and if we look here they have the code](https://youtu.be/oRci9ITnMuM?t=01h29m46s)

[right down here to do it](https://youtu.be/oRci9ITnMuM?t=01h29m50s)

[so i want to look at](https://youtu.be/oRci9ITnMuM?t=01h30m00s)

[this turn that off for a minute bmp](https://youtu.be/oRci9ITnMuM?t=01h30m03s)

[do that](https://youtu.be/oRci9ITnMuM?t=01h30m07s)

[um let's see](https://youtu.be/oRci9ITnMuM?t=01h30m10s)

[uh using file gets](https://youtu.be/oRci9ITnMuM?t=01h30m14s)

[file](https://youtu.be/oRci9ITnMuM?t=01h30m18s)

[open let's see here and we want to do](https://youtu.be/oRci9ITnMuM?t=01h30m22s)

[let's do save file dialog](https://youtu.be/oRci9ITnMuM?t=01h30m26s)

[file path plus dot](https://youtu.be/oRci9ITnMuM?t=01h30m30s)

[test dot](https://youtu.be/oRci9ITnMuM?t=01h30m34s)

[bitmap right file](https://youtu.be/oRci9ITnMuM?t=01h30m38s)

[mode](https://youtu.be/oRci9ITnMuM?t=01h30m46s)

[so blow that thing away](https://youtu.be/oRci9ITnMuM?t=01h30m49s)

[write that into file all right](https://youtu.be/oRci9ITnMuM?t=01h30m52s)

[uh let's see](https://youtu.be/oRci9ITnMuM?t=01h30m55s)

[stream](https://youtu.be/oRci9ITnMuM?t=01h31m00s)

[because i do want to see if the issue is](https://youtu.be/oRci9ITnMuM?t=01h31m05s)

[around writing the icon file or around](https://youtu.be/oRci9ITnMuM?t=01h31m06s)

[the bitmap data](https://youtu.be/oRci9ITnMuM?t=01h31m08s)

[so we're gonna we're gonna just test](https://youtu.be/oRci9ITnMuM?t=01h31m12s)

[that real quick because i haven't](https://youtu.be/oRci9ITnMuM?t=01h31m14s)

[actually used this library before so i'm](https://youtu.be/oRci9ITnMuM?t=01h31m16s)

[not](https://youtu.be/oRci9ITnMuM?t=01h31m18s)

[not 100 confident that i'm not just](https://youtu.be/oRci9ITnMuM?t=01h31m20s)

[using it wrong](https://youtu.be/oRci9ITnMuM?t=01h31m21s)

[so we're going to get rid of that and](https://youtu.be/oRci9ITnMuM?t=01h31m26s)

[save we should end up with two files now](https://youtu.be/oRci9ITnMuM?t=01h31m28s)

[okay so we can bring this guy over here](https://youtu.be/oRci9ITnMuM?t=01h31m33s)

[so if we open up bitmap](https://youtu.be/oRci9ITnMuM?t=01h31m35s)

[okay so the issue is with our bitmap](https://youtu.be/oRci9ITnMuM?t=01h31m40s)

[data](https://youtu.be/oRci9ITnMuM?t=01h31m43s)

[our render target bitmap not with the](https://youtu.be/oRci9ITnMuM?t=01h31m45s)

[icon file](https://youtu.be/oRci9ITnMuM?t=01h31m47s)

[because the bitmap itself is just a](https://youtu.be/oRci9ITnMuM?t=01h31m49s)

[bunch of black data](https://youtu.be/oRci9ITnMuM?t=01h31m51s)

[right so what](https://youtu.be/oRci9ITnMuM?t=01h31m57s)

[what did i miss](https://youtu.be/oRci9ITnMuM?t=01h32m02s)

[what did i miss we set the](https://youtu.be/oRci9ITnMuM?t=01h32m05s)

[height the width the background the](https://youtu.be/oRci9ITnMuM?t=01h32m08s)

[foreground the kind right](https://youtu.be/oRci9ITnMuM?t=01h32m11s)

[all of those are set kind background](https://youtu.be/oRci9ITnMuM?t=01h32m13s)

[foreground width](https://youtu.be/oRci9ITnMuM?t=01h32m15s)

[height all of those valid](https://youtu.be/oRci9ITnMuM?t=01h32m16s)

[okay is there anything on the default](https://youtu.be/oRci9ITnMuM?t=01h32m20s)

[style that might do something](https://youtu.be/oRci9ITnMuM?t=01h32m24s)

[let's see because pack](https://youtu.be/oRci9ITnMuM?t=01h32m31s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h32m34s)

[icon](https://youtu.be/oRci9ITnMuM?t=01h32m38s)

[nothing in there strikes me as obviously](https://youtu.be/oRci9ITnMuM?t=01h32m44s)

[problematic](https://youtu.be/oRci9ITnMuM?t=01h32m53s)

[oh i forgot that i didn't need to put a](https://youtu.be/oRci9ITnMuM?t=01h33m00s)

[border around it that it's got an](https://youtu.be/oRci9ITnMuM?t=01h33m03s)

[internal border](https://youtu.be/oRci9ITnMuM?t=01h33m04s)

[totally spaced that um](https://youtu.be/oRci9ITnMuM?t=01h33m09s)

[we can go and fix that real quick so](https://youtu.be/oRci9ITnMuM?t=01h33m21s)

[come over here and do that](https://youtu.be/oRci9ITnMuM?t=01h33m27s)

[uh we can do](https://youtu.be/oRci9ITnMuM?t=01h33m30s)

[this um do you also have a](https://youtu.be/oRci9ITnMuM?t=01h33m34s)

[doesn't allow for a corner radius to be](https://youtu.be/oRci9ITnMuM?t=01h33m39s)

[set on it though yeah we'll leave it as](https://youtu.be/oRci9ITnMuM?t=01h33m41s)

[is](https://youtu.be/oRci9ITnMuM?t=01h33m43s)

[leave it as is for now](https://youtu.be/oRci9ITnMuM?t=01h33m44s)

[i do wonder how many people are actually](https://youtu.be/oRci9ITnMuM?t=01h33m49s)

[using that border on](https://youtu.be/oRci9ITnMuM?t=01h33m50s)

[it or if we should consider flattening](https://youtu.be/oRci9ITnMuM?t=01h33m52s)

[the visual tree a little bit and](https://youtu.be/oRci9ITnMuM?t=01h33m55s)

[dropping](https://youtu.be/oRci9ITnMuM?t=01h33m56s)

[that out of there](https://youtu.be/oRci9ITnMuM?t=01h33m58s)

[might be a worthwhile thing to consider](https://youtu.be/oRci9ITnMuM?t=01h34m01s)

[it'd be a nice performance](https://youtu.be/oRci9ITnMuM?t=01h34m04s)

[boost because pack icons get used](https://youtu.be/oRci9ITnMuM?t=01h34m05s)

[everywhere](https://youtu.be/oRci9ITnMuM?t=01h34m07s)

[and a simple answer of telling people](https://youtu.be/oRci9ITnMuM?t=01h34m09s)

[wrap it in a border if you want those](https://youtu.be/oRci9ITnMuM?t=01h34m11s)

[properties back](https://youtu.be/oRci9ITnMuM?t=01h34m12s)

[that's probably i'm going to log that](https://youtu.be/oRci9ITnMuM?t=01h34m16s)

[real quick there's a list of](https://youtu.be/oRci9ITnMuM?t=01h34m18s)

[potential breaking changes for 5.0 that](https://youtu.be/oRci9ITnMuM?t=01h34m19s)

[i've been documenting](https://youtu.be/oRci9ITnMuM?t=01h34m21s)

[um edit let's see](https://youtu.be/oRci9ITnMuM?t=01h34m23s)

[let's see flatten pack](https://youtu.be/oRci9ITnMuM?t=01h34m26s)

[icon let's just look at what its base](https://youtu.be/oRci9ITnMuM?t=01h34m30s)

[class is](https://youtu.be/oRci9ITnMuM?t=01h34m35s)

[um](https://youtu.be/oRci9ITnMuM?t=01h34m44s)

[um](https://youtu.be/oRci9ITnMuM?t=01h34m51s)

[that's interesting that it has](https://youtu.be/oRci9ITnMuM?t=01h34m55s)

[has it on there and yet doesn't um](https://youtu.be/oRci9ITnMuM?t=01h34m59s)

[i'll have to think about that i won't i](https://youtu.be/oRci9ITnMuM?t=01h35m02s)

[won't log that yet](https://youtu.be/oRci9ITnMuM?t=01h35m04s)

[uh that'll be worth considering](https://youtu.be/oRci9ITnMuM?t=01h35m07s)

[okay but we still have the issue of we](https://youtu.be/oRci9ITnMuM?t=01h35m10s)

[are not rendering](https://youtu.be/oRci9ITnMuM?t=01h35m12s)

[an appropriate pack icon yet](https://youtu.be/oRci9ITnMuM?t=01h35m16s)

[so despite the fact that we've clearly](https://youtu.be/oRci9ITnMuM?t=01h35m21s)

[set this](https://youtu.be/oRci9ITnMuM?t=01h35m23s)

[um i do wonder if](https://youtu.be/oRci9ITnMuM?t=01h35m28s)

[oh it's not getting the default template](https://youtu.be/oRci9ITnMuM?t=01h35m32s)

[that is a problem so the implicit the](https://youtu.be/oRci9ITnMuM?t=01h35m39s)

[the property that's not being set on](https://youtu.be/oRci9ITnMuM?t=01h35m41s)

[this](https://youtu.be/oRci9ITnMuM?t=01h35m43s)

[control here is what's coming](https://youtu.be/oRci9ITnMuM?t=01h35m44s)

[in from here](https://youtu.be/oRci9ITnMuM?t=01h35m47s)

[pack icon right that](https://youtu.be/oRci9ITnMuM?t=01h35m53s)

[that's the key property that's not being](https://youtu.be/oRci9ITnMuM?t=01h35m56s)

[set](https://youtu.be/oRci9ITnMuM?t=01h35m58s)

[uh so we need to get ourselves](https://youtu.be/oRci9ITnMuM?t=01h35m59s)

[access to one of those guys](https://youtu.be/oRci9ITnMuM?t=01h36m02s)

[or alternatively we just pass this thing](https://youtu.be/oRci9ITnMuM?t=01h36m07s)

[in](https://youtu.be/oRci9ITnMuM?t=01h36m11s)

[trying to decide the problem with](https://youtu.be/oRci9ITnMuM?t=01h36m14s)

[passing it in](https://youtu.be/oRci9ITnMuM?t=01h36m16s)

[is i actually want to go through and do](https://youtu.be/oRci9ITnMuM?t=01h36m22s)

[this at a bunch of different resolutions](https://youtu.be/oRci9ITnMuM?t=01h36m24s)

[so i kind of want to clone the thing](https://youtu.be/oRci9ITnMuM?t=01h36m26s)

[rather than passing one in every time](https://youtu.be/oRci9ITnMuM?t=01h36m28s)

[how about can i just do](https://youtu.be/oRci9ITnMuM?t=01h36m37s)

[style get this is](https://youtu.be/oRci9ITnMuM?t=01h36m40s)

[uh let's see](https://youtu.be/oRci9ITnMuM?t=01h36m44s)

[uh let's see app current](https://youtu.be/oRci9ITnMuM?t=01h36m48s)

[uh find resource](https://youtu.be/oRci9ITnMuM?t=01h36m53s)

[uh type of pack icon](https://youtu.be/oRci9ITnMuM?t=01h36m57s)

[and then hard cast to](https://youtu.be/oRci9ITnMuM?t=01h37m05s)

[style let's](https://youtu.be/oRci9ITnMuM?t=01h37m08s)

[give that a shot i don't know if that's](https://youtu.be/oRci9ITnMuM?t=01h37m12s)

[going to give me](https://youtu.be/oRci9ITnMuM?t=01h37m15s)

[quite it should work so when you do](https://youtu.be/oRci9ITnMuM?t=01h37m16s)

[a find resource call whether you do it](https://youtu.be/oRci9ITnMuM?t=01h37m20s)

[on the app or on any ui element it will](https://youtu.be/oRci9ITnMuM?t=01h37m22s)

[inherently go walking](https://youtu.be/oRci9ITnMuM?t=01h37m25s)

[up the hierarchy looking for those](https://youtu.be/oRci9ITnMuM?t=01h37m29s)

[so if we get to my break point without](https://youtu.be/oRci9ITnMuM?t=01h37m35s)

[blowing up that'll be a](https://youtu.be/oRci9ITnMuM?t=01h37m37s)

[pretty good sign i want to blow away](https://youtu.be/oRci9ITnMuM?t=01h37m39s)

[the bitmap too just make sure](https://youtu.be/oRci9ITnMuM?t=01h37m44s)

[everything's dead](https://youtu.be/oRci9ITnMuM?t=01h37m47s)

[let's see save okay so it did](https://youtu.be/oRci9ITnMuM?t=01h37m48s)

[get the style set](https://youtu.be/oRci9ITnMuM?t=01h37m52s)

[which is good i want to make sure there](https://youtu.be/oRci9ITnMuM?t=01h37m56s)

[is a](https://youtu.be/oRci9ITnMuM?t=01h38m00s)

[template being applied](https://youtu.be/oRci9ITnMuM?t=01h38m01s)

[come on scroll](https://youtu.be/oRci9ITnMuM?t=01h38m04s)

[scroll visual studio scroll scroll](https://youtu.be/oRci9ITnMuM?t=01h38m08s)

[scroll template there is a control](https://youtu.be/oRci9ITnMuM?t=01h38m11s)

[template now](https://youtu.be/oRci9ITnMuM?t=01h38m14s)

[okay so if we do that do that do that](https://youtu.be/oRci9ITnMuM?t=01h38m15s)

[okay so let's see what happens](https://youtu.be/oRci9ITnMuM?t=01h38m19s)

[if we look at our bitmap](https://youtu.be/oRci9ITnMuM?t=01h38m22s)

[ah bitmap has color now](https://youtu.be/oRci9ITnMuM?t=01h38m27s)

[ah icon file](https://youtu.be/oRci9ITnMuM?t=01h38m35s)

[boom booyah](https://youtu.be/oRci9ITnMuM?t=01h38m38s)

[okay now we're cooking with fire now](https://youtu.be/oRci9ITnMuM?t=01h38m42s)

[we are cooking with fire](https://youtu.be/oRci9ITnMuM?t=01h38m45s)

[so let's do](https://youtu.be/oRci9ITnMuM?t=01h38m49s)

[okay so that that works so that's better](https://youtu.be/oRci9ITnMuM?t=01h38m53s)

[okay so let's let's just start](https://youtu.be/oRci9ITnMuM?t=01h38m59s)

[let's just see if we can gen one of](https://youtu.be/oRci9ITnMuM?t=01h39m03s)

[these things up and](https://youtu.be/oRci9ITnMuM?t=01h39m04s)

[we need to get the we need to get the](https://youtu.be/oRci9ITnMuM?t=01h39m06s)

[sizes](https://youtu.be/oRci9ITnMuM?t=01h39m09s)

[um](https://youtu.be/oRci9ITnMuM?t=01h39m10s)

[what is going to be the easiest way to](https://youtu.be/oRci9ITnMuM?t=01h39m14s)

[get a list of sizes](https://youtu.be/oRci9ITnMuM?t=01h39m15s)

[what is the best way to do it](https://youtu.be/oRci9ITnMuM?t=01h39m17s)

[because i have a list of check boxes](https://youtu.be/oRci9ITnMuM?t=01h39m22s)

[you know what we could do](https://youtu.be/oRci9ITnMuM?t=01h39m27s)

[we could just throw away the sizes all](https://youtu.be/oRci9ITnMuM?t=01h39m30s)

[together](https://youtu.be/oRci9ITnMuM?t=01h39m33s)

[and generate yeah mvp here's here's mvp](https://youtu.be/oRci9ITnMuM?t=01h39m33s)

[right we will mvp is throw away the](https://youtu.be/oRci9ITnMuM?t=01h39m38s)

[expander all together](https://youtu.be/oRci9ITnMuM?t=01h39m42s)

[boom done um and we will hold on we do](https://youtu.be/oRci9ITnMuM?t=01h39m43s)

[want this](https://youtu.be/oRci9ITnMuM?t=01h39m46s)

[list though 250 so let's let's go and](https://youtu.be/oRci9ITnMuM?t=01h39m47s)

[write these out so](https://youtu.be/oRci9ITnMuM?t=01h39m51s)

[uh let's see](https://youtu.be/oRci9ITnMuM?t=01h39m54s)

[to do make this configurable](https://youtu.be/oRci9ITnMuM?t=01h39m59s)

[see there we go for each var size in](https://youtu.be/oRci9ITnMuM?t=01h40m03s)

[okay so we're gonna do we're just gonna](https://youtu.be/oRci9ITnMuM?t=01h40m11s)

[start the top 256](https://youtu.be/oRci9ITnMuM?t=01h40m13s)

[128 and](https://youtu.be/oRci9ITnMuM?t=01h40m15s)

[let's just grab them all 64. 48](https://youtu.be/oRci9ITnMuM?t=01h40m18s)

[32. i'm gonna just put you on the side](https://youtu.be/oRci9ITnMuM?t=01h40m22s)

[here for a moment](https://youtu.be/oRci9ITnMuM?t=01h40m25s)

[stay there uh okay so](https://youtu.be/oRci9ITnMuM?t=01h40m28s)

[i need to close that window so it's not](https://youtu.be/oRci9ITnMuM?t=01h40m31s)

[sitting on top](https://youtu.be/oRci9ITnMuM?t=01h40m33s)

[and then 64.](https://youtu.be/oRci9ITnMuM?t=01h40m35s)

[uh 48 32](https://youtu.be/oRci9ITnMuM?t=01h40m38s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h40m41s)

[24 16 right because in most cases](https://youtu.be/oRci9ITnMuM?t=01h40m43s)

[you probably just want an icon with all](https://youtu.be/oRci9ITnMuM?t=01h40m46s)

[the stuff in](https://youtu.be/oRci9ITnMuM?t=01h40m49s)

[it right the only reason why you don't](https://youtu.be/oRci9ITnMuM?t=01h40m50s)

[want all the things in it is file size](https://youtu.be/oRci9ITnMuM?t=01h40m52s)

[boom and that gives us that and if you](https://youtu.be/oRci9ITnMuM?t=01h40m59s)

[want to delete items](https://youtu.be/oRci9ITnMuM?t=01h41m02s)

[out it's very simple like visual studio](https://youtu.be/oRci9ITnMuM?t=01h41m04s)

[visual studio makes it very easy if you](https://youtu.be/oRci9ITnMuM?t=01h41m09s)

[want to go through and](https://youtu.be/oRci9ITnMuM?t=01h41m11s)

[drop one of these things right delete](https://youtu.be/oRci9ITnMuM?t=01h41m13s)

[image type](https://youtu.be/oRci9ITnMuM?t=01h41m15s)

[oh unable to delete the last image it](https://youtu.be/oRci9ITnMuM?t=01h41m19s)

[doesn't let you delete the last one it](https://youtu.be/oRci9ITnMuM?t=01h41m20s)

[wants one in there so we're going to](https://youtu.be/oRci9ITnMuM?t=01h41m22s)

[leave that for now](https://youtu.be/oRci9ITnMuM?t=01h41m23s)

[we got rid of the file rendering bits we](https://youtu.be/oRci9ITnMuM?t=01h41m25s)

[don't need this](https://youtu.be/oRci9ITnMuM?t=01h41m27s)

[um make this](https://youtu.be/oRci9ITnMuM?t=01h41m30s)

[size list we'll make we'll be a little](https://youtu.be/oRci9ITnMuM?t=01h41m33s)

[more](https://youtu.be/oRci9ITnMuM?t=01h41m35s)

[explicit we don't need that that's](https://youtu.be/oRci9ITnMuM?t=01h41m37s)

[pretty darn obvious](https://youtu.be/oRci9ITnMuM?t=01h41m38s)

[let's launch](https://youtu.be/oRci9ITnMuM?t=01h41m41s)

[and then away we go](https://youtu.be/oRci9ITnMuM?t=01h41m45s)

[the good news is the library works as](https://youtu.be/oRci9ITnMuM?t=01h41m50s)

[long as you feed it good data](https://youtu.be/oRci9ITnMuM?t=01h41m53s)

[who would have thunk okay so if we come](https://youtu.be/oRci9ITnMuM?t=01h41m55s)

[in here](https://youtu.be/oRci9ITnMuM?t=01h41m57s)

[we're going to set the foreground to red](https://youtu.be/oRci9ITnMuM?t=01h41m58s)

[background we'll go with a green](https://youtu.be/oRci9ITnMuM?t=01h42m01s)

[right bright green](https://youtu.be/oRci9ITnMuM?t=01h42m03s)

[we did not delete image sizes out of our](https://youtu.be/oRci9ITnMuM?t=01h42m06s)

[xaml because i left them there which was](https://youtu.be/oRci9ITnMuM?t=01h42m11s)

[bad](https://youtu.be/oRci9ITnMuM?t=01h42m14s)

[boom now they're gone](https://youtu.be/oRci9ITnMuM?t=01h42m15s)

[so that's there save](https://youtu.be/oRci9ITnMuM?t=01h42m19s)

[and we come in here we delete this](https://youtu.be/oRci9ITnMuM?t=01h42m25s)

[i'm just going to make sure we actually](https://youtu.be/oRci9ITnMuM?t=01h42m28s)

[get rid of all of it](https://youtu.be/oRci9ITnMuM?t=01h42m30s)

[clear that out and we will call it test](https://youtu.be/oRci9ITnMuM?t=01h42m32s)

[icon again](https://youtu.be/oRci9ITnMuM?t=01h42m34s)

[and it generates me a new test icon](https://youtu.be/oRci9ITnMuM?t=01h42m36s)

[bring this guy in](https://youtu.be/oRci9ITnMuM?t=01h42m40s)

[this is kind of a big icon file](https://youtu.be/oRci9ITnMuM?t=01h42m47s)

[i am realizing it's nearly a meg](https://youtu.be/oRci9ITnMuM?t=01h42m50s)

[uh hello visual studio](https://youtu.be/oRci9ITnMuM?t=01h42m54s)

[oh it doesn't want to open it while](https://youtu.be/oRci9ITnMuM?t=01h42m57s)

[debugging](https://youtu.be/oRci9ITnMuM?t=01h42m58s)

[which that's part of the problem](https://youtu.be/oRci9ITnMuM?t=01h43m00s)

[hello is there a](https://youtu.be/oRci9ITnMuM?t=01h43m06s)

[there a problem here visual studio](https://youtu.be/oRci9ITnMuM?t=01h43m10s)

[uh why do you not wish to](https://youtu.be/oRci9ITnMuM?t=01h43m16s)

[load my icon file for me anymore](https://youtu.be/oRci9ITnMuM?t=01h43m19s)

[oh there it goes](https://youtu.be/oRci9ITnMuM?t=01h43m28s)

[i didn't just drop it over on my file](https://youtu.be/oRci9ITnMuM?t=01h43m34s)

[list did i doesn't look like it](https://youtu.be/oRci9ITnMuM?t=01h43m35s)

[so let's see we got 128 128 128 128 128](https://youtu.be/oRci9ITnMuM?t=01h43m37s)

[128 128](https://youtu.be/oRci9ITnMuM?t=01h43m41s)

[so we generated it and this is what](https://youtu.be/oRci9ITnMuM?t=01h43m43s)

[happens when you make a](https://youtu.be/oRci9ITnMuM?t=01h43m46s)

[an iterator and then don't](https://youtu.be/oRci9ITnMuM?t=01h43m48s)

[use it appropriately](https://youtu.be/oRci9ITnMuM?t=01h43m51s)

[so we should do that so that](https://youtu.be/oRci9ITnMuM?t=01h43m54s)

[theoretically and the key part here is](https://youtu.be/oRci9ITnMuM?t=01h43m58s)

[we're](https://youtu.be/oRci9ITnMuM?t=01h44m00s)

[because we're going to generate a new](https://youtu.be/oRci9ITnMuM?t=01h44m00s)

[pack icon at a different size](https://youtu.be/oRci9ITnMuM?t=01h44m02s)

[and re-run it through the render target](https://youtu.be/oRci9ITnMuM?t=01h44m04s)

[bitmap it's going to re-rasterize it](https://youtu.be/oRci9ITnMuM?t=01h44m06s)

[at each resolution which is what you](https://youtu.be/oRci9ITnMuM?t=01h44m08s)

[want](https://youtu.be/oRci9ITnMuM?t=01h44m11s)

[that way you get your best quality](https://youtu.be/oRci9ITnMuM?t=01h44m12s)

[let's see so there okay let's do green](https://youtu.be/oRci9ITnMuM?t=01h44m16s)

[on blue go something like that](https://youtu.be/oRci9ITnMuM?t=01h44m20s)

[blue cowboy okay](https://youtu.be/oRci9ITnMuM?t=01h44m23s)

[we're gonna see what happens when we hit](https://youtu.be/oRci9ITnMuM?t=01h44m26s)

[save](https://youtu.be/oRci9ITnMuM?t=01h44m27s)

[uh no not what i wanted thank you](https://youtu.be/oRci9ITnMuM?t=01h44m32s)

[uh come over here](https://youtu.be/oRci9ITnMuM?t=01h44m36s)

[boom so now we've got a 256](https://youtu.be/oRci9ITnMuM?t=01h44m40s)

[128 64 48](https://youtu.be/oRci9ITnMuM?t=01h44m44s)

[32 16.](https://youtu.be/oRci9ITnMuM?t=01h44m47s)

[now we've got something we can use as](https://youtu.be/oRci9ITnMuM?t=01h44m52s)

[our](https://youtu.be/oRci9ITnMuM?t=01h44m54s)

[app icon that's what we were looking for](https://youtu.be/oRci9ITnMuM?t=01h44m55s)

[right there](https://youtu.be/oRci9ITnMuM?t=01h44m58s)

[oh yeah how big is this](https://youtu.be/oRci9ITnMuM?t=01h45m00s)

[700k so not tiny](https://youtu.be/oRci9ITnMuM?t=01h45m04s)

[not tiny so we may want to make that](https://youtu.be/oRci9ITnMuM?t=01h45m08s)

[less configurable but for an mvp](https://youtu.be/oRci9ITnMuM?t=01h45m10s)

[i'm rather happy with this i'm rather](https://youtu.be/oRci9ITnMuM?t=01h45m13s)

[happy with this](https://youtu.be/oRci9ITnMuM?t=01h45m16s)

[okay so we should probably change up the](https://youtu.be/oRci9ITnMuM?t=01h45m17s)

[way this looks because this does not](https://youtu.be/oRci9ITnMuM?t=01h45m20s)

[look](https://youtu.be/oRci9ITnMuM?t=01h45m22s)

[inviting uh let's do something like](https://youtu.be/oRci9ITnMuM?t=01h45m24s)

[export](https://youtu.be/oRci9ITnMuM?t=01h45m28s)

[for like the box uh](https://youtu.be/oRci9ITnMuM?t=01h45m30s)

[with an arrow or yeah file export this](https://youtu.be/oRci9ITnMuM?t=01h45m33s)

[looks good so we're going to use this](https://youtu.be/oRci9ITnMuM?t=01h45m37s)

[icon for this button here](https://youtu.be/oRci9ITnMuM?t=01h45m38s)

[right so something that often trips](https://youtu.be/oRci9ITnMuM?t=01h45m40s)

[people up is how do i](https://youtu.be/oRci9ITnMuM?t=01h45m43s)

[change that icon for my](https://youtu.be/oRci9ITnMuM?t=01h45m44s)

[for my pack icon right because all we](https://youtu.be/oRci9ITnMuM?t=01h45m47s)

[did here](https://youtu.be/oRci9ITnMuM?t=01h45m50s)

[right we just did pop-up box and what](https://youtu.be/oRci9ITnMuM?t=01h45m51s)

[you're looking for is the pop-up content](https://youtu.be/oRci9ITnMuM?t=01h45m54s)

[and what we can do is material design](https://youtu.be/oRci9ITnMuM?t=01h45m56s)

[pack icon kind of](https://youtu.be/oRci9ITnMuM?t=01h46m01s)

[file x port boom](https://youtu.be/oRci9ITnMuM?t=01h46m05s)

[and now we've got](https://youtu.be/oRci9ITnMuM?t=01h46m09s)

[we've got that thing unhappy with me](https://youtu.be/oRci9ITnMuM?t=01h46m13s)

[let's try again](https://youtu.be/oRci9ITnMuM?t=01h46m16s)

[there were builders](https://youtu.be/oRci9ITnMuM?t=01h46m21s)

[oh i set the wrong property uh it's](https://youtu.be/oRci9ITnMuM?t=01h46m24s)

[it's not the pop-up content it is the](https://youtu.be/oRci9ITnMuM?t=01h46m27s)

[what is it called the](https://youtu.be/oRci9ITnMuM?t=01h46m30s)

[uh boy i can't remember the name of it](https://youtu.be/oRci9ITnMuM?t=01h46m34s)

[uh show it to me](https://youtu.be/oRci9ITnMuM?t=01h46m38s)

[there is uh toggle content](https://youtu.be/oRci9ITnMuM?t=01h46m42s)

[something something content toggle](https://youtu.be/oRci9ITnMuM?t=01h46m46s)

[content boom let's try that](https://youtu.be/oRci9ITnMuM?t=01h46m50s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h47m02s)

[icon pack there we go](https://youtu.be/oRci9ITnMuM?t=01h47m04s)

[it's a little tiny i kind of want that](https://youtu.be/oRci9ITnMuM?t=01h47m10s)

[bigger](https://youtu.be/oRci9ITnMuM?t=01h47m12s)

[i really wish there was an automatic](https://youtu.be/oRci9ITnMuM?t=01h47m13s)

[so resharper has a cool button that will](https://youtu.be/oRci9ITnMuM?t=01h47m17s)

[automatically convert this to an element](https://youtu.be/oRci9ITnMuM?t=01h47m20s)

[and i really really wish this thing](https://youtu.be/oRci9ITnMuM?t=01h47m22s)

[would have it](https://youtu.be/oRci9ITnMuM?t=01h47m24s)

[uh let's see so we're gonna do this](https://youtu.be/oRci9ITnMuM?t=01h47m26s)

[i'm gonna go with pack icon](https://youtu.be/oRci9ITnMuM?t=01h47m29s)

[kind file export](https://youtu.be/oRci9ITnMuM?t=01h47m32s)

[all right so this is equivalent to what](https://youtu.be/oRci9ITnMuM?t=01h47m36s)

[we just had](https://youtu.be/oRci9ITnMuM?t=01h47m38s)

[but what i would really like to do is](https://youtu.be/oRci9ITnMuM?t=01h47m39s)

[start changing](https://youtu.be/oRci9ITnMuM?t=01h47m41s)

[width to be i don't know 40](https://youtu.be/oRci9ITnMuM?t=01h47m43s)

[height 40. how does that look](https://youtu.be/oRci9ITnMuM?t=01h47m46s)

[that's a little big that's a little big](https://youtu.be/oRci9ITnMuM?t=01h47m51s)

[we want it to be obvious but we don't](https://youtu.be/oRci9ITnMuM?t=01h47m53s)

[want it to be](https://youtu.be/oRci9ITnMuM?t=01h47m55s)

[we don't want to be that obvious right](https://youtu.be/oRci9ITnMuM?t=01h47m56s)

[uh and let's throw](https://youtu.be/oRci9ITnMuM?t=01h48m00s)

[a tooltip on this guy so how about tool](https://youtu.be/oRci9ITnMuM?t=01h48m04s)

[tip](https://youtu.be/oRci9ITnMuM?t=01h48m06s)

[export icon or export](https://youtu.be/oRci9ITnMuM?t=01h48m08s)

[pack icon as](https://youtu.be/oRci9ITnMuM?t=01h48m12s)

[that's icon file uh](https://youtu.be/oRci9ITnMuM?t=01h48m18s)

[dot ico boom](https://youtu.be/oRci9ITnMuM?t=01h48m21s)

[so now we've got that sweet now i think](https://youtu.be/oRci9ITnMuM?t=01h48m27s)

[the one thing i'd love to do is start it](https://youtu.be/oRci9ITnMuM?t=01h48m32s)

[off with a little bit better](https://youtu.be/oRci9ITnMuM?t=01h48m34s)

[default coloring right that would be](https://youtu.be/oRci9ITnMuM?t=01h48m36s)

[a little bit nicer](https://youtu.be/oRci9ITnMuM?t=01h48m40s)

[trying to decide the easiest way to go](https://youtu.be/oRci9ITnMuM?t=01h48m44s)

[about doing that](https://youtu.be/oRci9ITnMuM?t=01h48m46s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h49m01s)

[because right now when you open this guy](https://youtu.be/oRci9ITnMuM?t=01h49m04s)

[up it's not and it's not set it's a](https://youtu.be/oRci9ITnMuM?t=01h49m05s)

[little obnoxious because both of these](https://youtu.be/oRci9ITnMuM?t=01h49m07s)

[colors here](https://youtu.be/oRci9ITnMuM?t=01h49m08s)

[just have a default color of](https://youtu.be/oRci9ITnMuM?t=01h49m10s)

[garbage and it would be nice to get a](https://youtu.be/oRci9ITnMuM?t=01h49m14s)

[little bit](https://youtu.be/oRci9ITnMuM?t=01h49m16s)

[a little bit better stuff oh let's](https://youtu.be/oRci9ITnMuM?t=01h49m18s)

[let's clean that up a little bit to do](https://youtu.be/oRci9ITnMuM?t=01h49m21s)

[uh so let's do some theming work i think](https://youtu.be/oRci9ITnMuM?t=01h49m24s)

[this will leave at least a good example](https://youtu.be/oRci9ITnMuM?t=01h49m28s)

[for people who want to know how to do](https://youtu.be/oRci9ITnMuM?t=01h49m30s)

[theme stuff i guess](https://youtu.be/oRci9ITnMuM?t=01h49m33s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h49m36s)

[so this guy is coming in from here](https://youtu.be/oRci9ITnMuM?t=01h49m41s)

[uh let's just do it in here](https://youtu.be/oRci9ITnMuM?t=01h49m47s)

[because we really want to get ourselves](https://youtu.be/oRci9ITnMuM?t=01h49m55s)

[a theme manager](https://youtu.be/oRci9ITnMuM?t=01h49m57s)

[um](https://youtu.be/oRci9ITnMuM?t=01h50m02s)

[so there's a stat so i'll think out loud](https://youtu.be/oRci9ITnMuM?t=01h50m05s)

[here so there's a there's a static class](https://youtu.be/oRci9ITnMuM?t=01h50m07s)

[called pallet helper](https://youtu.be/oRci9ITnMuM?t=01h50m09s)

[right where you can go var](https://youtu.be/oRci9ITnMuM?t=01h50m10s)

[helper gets new pallet helper right](https://youtu.be/oRci9ITnMuM?t=01h50m13s)

[and this guy will give you access to](https://youtu.be/oRci9ITnMuM?t=01h50m17s)

[things like get](https://youtu.be/oRci9ITnMuM?t=01h50m20s)

[theme oh it also has get theme manager](https://youtu.be/oRci9ITnMuM?t=01h50m21s)

[that might be sufficient](https://youtu.be/oRci9ITnMuM?t=01h50m25s)

[yeah let's just go that route get the](https://youtu.be/oRci9ITnMuM?t=01h50m27s)

[manager](https://youtu.be/oRci9ITnMuM?t=01h50m29s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h50m30s)

[boom uh and this guy actually wants to](https://youtu.be/oRci9ITnMuM?t=01h50m34s)

[be nullable so fine whatever](https://youtu.be/oRci9ITnMuM?t=01h50m37s)

[um but the whole reason why i want to](https://youtu.be/oRci9ITnMuM?t=01h50m39s)

[get the theme](https://youtu.be/oRci9ITnMuM?t=01h50m42s)

[so how about let's](https://youtu.be/oRci9ITnMuM?t=01h50m42s)

[if uh is](https://youtu.be/oRci9ITnMuM?t=01h50m46s)

[not null theme](https://youtu.be/oRci9ITnMuM?t=01h50m50s)

[manager right because what i would](https://youtu.be/oRci9ITnMuM?t=01h50m53s)

[really like to do](https://youtu.be/oRci9ITnMuM?t=01h50m56s)

[is get a hold of the theme manager and](https://youtu.be/oRci9ITnMuM?t=01h50m57s)

[know when the theme has changed because](https://youtu.be/oRci9ITnMuM?t=01h51m00s)

[i would like to automatically set the](https://youtu.be/oRci9ITnMuM?t=01h51m02s)

[background and foreground](https://youtu.be/oRci9ITnMuM?t=01h51m04s)

[based upon theme changes right boom so](https://youtu.be/oRci9ITnMuM?t=01h51m06s)

[we're going to do that](https://youtu.be/oRci9ITnMuM?t=01h51m09s)

[apply and then i think what we're going](https://youtu.be/oRci9ITnMuM?t=01h51m10s)

[to do is](https://youtu.be/oRci9ITnMuM?t=01h51m13s)

[just give ourselves a method down here](https://youtu.be/oRci9ITnMuM?t=01h51m15s)

[that's something like](https://youtu.be/oRci9ITnMuM?t=01h51m19s)

[private void set](https://youtu.be/oRci9ITnMuM?t=01h51m23s)

[default icon colors](https://youtu.be/oRci9ITnMuM?t=01h51m28s)

[right so just just so it can look a](https://youtu.be/oRci9ITnMuM?t=01h51m33s)

[little](https://youtu.be/oRci9ITnMuM?t=01h51m35s)

[a little prettier uh](https://youtu.be/oRci9ITnMuM?t=01h51m36s)

[so then we're gonna come up here this](https://youtu.be/oRci9ITnMuM?t=01h51m40s)

[guy's sole purpose is going to be](https://youtu.be/oRci9ITnMuM?t=01h51m43s)

[when the theme changes right](https://youtu.be/oRci9ITnMuM?t=01h51m45s)

[call that method and then up here we're](https://youtu.be/oRci9ITnMuM?t=01h51m49s)

[just going to do the same thing](https://youtu.be/oRci9ITnMuM?t=01h51m51s)

[right and we're going to grab that guy](https://youtu.be/oRci9ITnMuM?t=01h51m54s)

[and yeah this will be](https://youtu.be/oRci9ITnMuM?t=01h51m58s)

[this way we can have an example because](https://youtu.be/oRci9ITnMuM?t=01h52m01s)

[people often ask how to handle](https://youtu.be/oRci9ITnMuM?t=01h52m03s)

[theming changes in their app and so this](https://youtu.be/oRci9ITnMuM?t=01h52m05s)

[will be](https://youtu.be/oRci9ITnMuM?t=01h52m07s)

[somewhat of a reasonable example in](https://youtu.be/oRci9ITnMuM?t=01h52m08s)

[general i don't necessarily like this](https://youtu.be/oRci9ITnMuM?t=01h52m10s)

[static helper i would prefer to get](https://youtu.be/oRci9ITnMuM?t=01h52m11s)

[access to the theme manager higher up](https://youtu.be/oRci9ITnMuM?t=01h52m13s)

[and use something like dependency](https://youtu.be/oRci9ITnMuM?t=01h52m15s)

[injection to pass this](https://youtu.be/oRci9ITnMuM?t=01h52m16s)

[guy around to the relevant places but](https://youtu.be/oRci9ITnMuM?t=01h52m18s)

[this will work](https://youtu.be/oRci9ITnMuM?t=01h52m20s)

[this will work for the quick and dirty](https://youtu.be/oRci9ITnMuM?t=01h52m21s)

[uh savar](https://youtu.be/oRci9ITnMuM?t=01h52m23s)

[helper gets new](https://youtu.be/oRci9ITnMuM?t=01h52m25s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=01h52m26s)

[palette helper and i just want to](https://youtu.be/oRci9ITnMuM?t=01h52m28s)

[confirm i'm pretty sure if my memory is](https://youtu.be/oRci9ITnMuM?t=01h52m30s)

[correct](https://youtu.be/oRci9ITnMuM?t=01h52m32s)

[palette helper's constructor is not](https://youtu.be/oRci9ITnMuM?t=01h52m34s)

[doing work right](https://youtu.be/oRci9ITnMuM?t=01h52m36s)

[yeah he doesn't do anything it's just](https://youtu.be/oRci9ITnMuM?t=01h52m37s)

[when you call stuff so then we want to](https://youtu.be/oRci9ITnMuM?t=01h52m39s)

[get the theme off of him](https://youtu.be/oRci9ITnMuM?t=01h52m41s)

[uh let's see uh if](https://youtu.be/oRci9ITnMuM?t=01h52m44s)

[helper get theme right](https://youtu.be/oRci9ITnMuM?t=01h52m48s)

[i believe this guy is oh he's](https://youtu.be/oRci9ITnMuM?t=01h52m51s)

[non-nullable](https://youtu.be/oRci9ITnMuM?t=01h52m56s)

[interesting](https://youtu.be/oRci9ITnMuM?t=01h52m58s)

[oh cause he's gonna instantiate a new](https://youtu.be/oRci9ITnMuM?t=01h53m02s)

[one every time excellent](https://youtu.be/oRci9ITnMuM?t=01h53m04s)

[so we will do i theme](https://youtu.be/oRci9ITnMuM?t=01h53m06s)

[theme gets helper get theme](https://youtu.be/oRci9ITnMuM?t=01h53m09s)

[excellent and then from here we're going](https://youtu.be/oRci9ITnMuM?t=01h53m14s)

[to just do something like](https://youtu.be/oRci9ITnMuM?t=01h53m17s)

[uh generated icon background](https://youtu.be/oRci9ITnMuM?t=01h53m19s)

[gets so what should the background be i](https://youtu.be/oRci9ITnMuM?t=01h53m22s)

[think the background](https://youtu.be/oRci9ITnMuM?t=01h53m25s)

[should probably just be like theme](https://youtu.be/oRci9ITnMuM?t=01h53m26s)

[the background color for the theme but](https://youtu.be/oRci9ITnMuM?t=01h53m29s)

[i'm thinking the](https://youtu.be/oRci9ITnMuM?t=01h53m31s)

[foreground should be like the primary](https://youtu.be/oRci9ITnMuM?t=01h53m32s)

[color](https://youtu.be/oRci9ITnMuM?t=01h53m34s)

[right as a default right theme](https://youtu.be/oRci9ITnMuM?t=01h53m36s)

[primary mid maybe](https://youtu.be/oRci9ITnMuM?t=01h53m39s)

[yeah let's go with that for the moment](https://youtu.be/oRci9ITnMuM?t=01h53m52s)

[see](https://youtu.be/oRci9ITnMuM?t=01h53m55s)

[see how that comes out because i think](https://youtu.be/oRci9ITnMuM?t=01h53m56s)

[that'll be a little bit nicer](https://youtu.be/oRci9ITnMuM?t=01h53m57s)

[that way you can pick up the](https://youtu.be/oRci9ITnMuM?t=01h54m00s)

[icon pack click on this guy do to do](https://youtu.be/oRci9ITnMuM?t=01h54m06s)

[yeah so that's a little bit nicer](https://youtu.be/oRci9ITnMuM?t=01h54m10s)

[surprise the background is](https://youtu.be/oRci9ITnMuM?t=01h54m15s)

[background the right brush or is it](https://youtu.be/oRci9ITnMuM?t=01h54m19s)

[paper i think paper is actually what i](https://youtu.be/oRci9ITnMuM?t=01h54m24s)

[want not background](https://youtu.be/oRci9ITnMuM?t=01h54m26s)

[i'm fairly confident background's an old](https://youtu.be/oRci9ITnMuM?t=01h54m28s)

[brush](https://youtu.be/oRci9ITnMuM?t=01h54m30s)

[it may have been deprecated i am also](https://youtu.be/oRci9ITnMuM?t=01h54m32s)

[noticing](https://youtu.be/oRci9ITnMuM?t=01h54m35s)

[that that other library is coming](https://youtu.be/oRci9ITnMuM?t=01h54m36s)

[through as](https://youtu.be/oRci9ITnMuM?t=01h54m37s)

[not necessarily core compatible clearly](https://youtu.be/oRci9ITnMuM?t=01h54m39s)

[it works](https://youtu.be/oRci9ITnMuM?t=01h54m42s)

[but i'm not overly concerned given that](https://youtu.be/oRci9ITnMuM?t=01h54m42s)

[wpf only runs under windows](https://youtu.be/oRci9ITnMuM?t=01h54m46s)

[so it's not a real big deal to me yeah](https://youtu.be/oRci9ITnMuM?t=01h54m48s)

[that will that looks a little better](https://youtu.be/oRci9ITnMuM?t=01h54m51s)

[the white border](https://youtu.be/oRci9ITnMuM?t=01h54m53s)

[right and so then if i do this](https://youtu.be/oRci9ITnMuM?t=01h54m58s)

[the theme has changed](https://youtu.be/oRci9ITnMuM?t=01h55m02s)

[all right if i go here that guy](https://youtu.be/oRci9ITnMuM?t=01h55m05s)

[automatically updated](https://youtu.be/oRci9ITnMuM?t=01h55m08s)

[right and if i go something like](https://youtu.be/oRci9ITnMuM?t=01h55m09s)

[change my palette change my primary](https://youtu.be/oRci9ITnMuM?t=01h55m14s)

[color to orange if i go back to my icons](https://youtu.be/oRci9ITnMuM?t=01h55m16s)

[now](https://youtu.be/oRci9ITnMuM?t=01h55m19s)

[right](https://youtu.be/oRci9ITnMuM?t=01h55m20s)

[icon pack right if i pop this guy open](https://youtu.be/oRci9ITnMuM?t=01h55m23s)

[he should show me show me that](https://youtu.be/oRci9ITnMuM?t=01h55m28s)

[oh i just realized oh did that oh yeah](https://youtu.be/oRci9ITnMuM?t=01h55m32s)

[good that's why we use the](https://youtu.be/oRci9ITnMuM?t=01h55m35s)

[the theme brush so that it would be](https://youtu.be/oRci9ITnMuM?t=01h55m36s)

[let me do that](https://youtu.be/oRci9ITnMuM?t=01h55m42s)

[yeah it just works](https://youtu.be/oRci9ITnMuM?t=01h55m46s)

[and then if people want to change it](https://youtu.be/oRci9ITnMuM?t=01h55m49s)

[they are free to do so](https://youtu.be/oRci9ITnMuM?t=01h55m50s)

[and i think a nice feature would be to](https://youtu.be/oRci9ITnMuM?t=01h55m52s)

[add in like an rgb](https://youtu.be/oRci9ITnMuM?t=01h55m54s)

[picker let people type it in or](https://youtu.be/oRci9ITnMuM?t=01h55m56s)

[something maybe right down here](https://youtu.be/oRci9ITnMuM?t=01h55m58s)

[whatever keep this thing nice and tight](https://youtu.be/oRci9ITnMuM?t=01h56m00s)

[and then also give uh](https://youtu.be/oRci9ITnMuM?t=01h56m02s)

[that size picker but](https://youtu.be/oRci9ITnMuM?t=01h56m03s)

[for now i think that meets mvp](https://youtu.be/oRci9ITnMuM?t=01h56m07s)

[i think that means mvp and let's take a](https://youtu.be/oRci9ITnMuM?t=01h56m11s)

[quick look at what we did](https://youtu.be/oRci9ITnMuM?t=01h56m13s)

[so a value converter on the brush makes](https://youtu.be/oRci9ITnMuM?t=01h56m15s)

[sense we did a whole bunch of changes](https://youtu.be/oRci9ITnMuM?t=01h56m17s)

[in the view model so we brought in the](https://youtu.be/oRci9ITnMuM?t=01h56m20s)

[theme manager](https://youtu.be/oRci9ITnMuM?t=01h56m22s)

[set the default icon colors right](https://youtu.be/oRci9ITnMuM?t=01h56m24s)

[fix the curly braces there lambda bodied](https://youtu.be/oRci9ITnMuM?t=01h56m27s)

[member there curly braces there](https://youtu.be/oRci9ITnMuM?t=01h56m31s)

[whole bunch of stuff here so set default](https://youtu.be/oRci9ITnMuM?t=01h56m33s)

[colors just pulls this will go bigger](https://youtu.be/oRci9ITnMuM?t=01h56m35s)

[come down here so let's see so we got](https://youtu.be/oRci9ITnMuM?t=01h56m38s)

[the properties we've got](https://youtu.be/oRci9ITnMuM?t=01h56m40s)

[the the command implementation](https://youtu.be/oRci9ITnMuM?t=01h56m42s)

[uh that looks fine our save icon](https://youtu.be/oRci9ITnMuM?t=01h56m46s)

[pretty confident in given that we've](https://youtu.be/oRci9ITnMuM?t=01h56m50s)

[done this a few times](https://youtu.be/oRci9ITnMuM?t=01h56m52s)

[that builds it up runs it through the](https://youtu.be/oRci9ITnMuM?t=01h56m55s)

[list that works](https://youtu.be/oRci9ITnMuM?t=01h56m57s)

[our xaml we did a lot of fun stuff with](https://youtu.be/oRci9ITnMuM?t=01h56m59s)

[so some white space cleanup](https://youtu.be/oRci9ITnMuM?t=01h57m02s)

[then our pop-up box which is great](https://youtu.be/oRci9ITnMuM?t=01h57m04s)

[this guy here we just brought in this](https://youtu.be/oRci9ITnMuM?t=01h57m08s)

[blue wolf icons for now](https://youtu.be/oRci9ITnMuM?t=01h57m10s)

[i may poke around to see if there's an](https://youtu.be/oRci9ITnMuM?t=01h57m12s)

[another one that's already core](https://youtu.be/oRci9ITnMuM?t=01h57m14s)

[compatible](https://youtu.be/oRci9ITnMuM?t=01h57m16s)

[it's such a simple format i'm half](https://youtu.be/oRci9ITnMuM?t=01h57m16s)

[tempted to write it myself i just don't](https://youtu.be/oRci9ITnMuM?t=01h57m19s)

[want to](https://youtu.be/oRci9ITnMuM?t=01h57m20s)

[write another nuget package when i'm](https://youtu.be/oRci9ITnMuM?t=01h57m21s)

[sure there's plenty out there](https://youtu.be/oRci9ITnMuM?t=01h57m23s)

[it's just it's really hard to search for](https://youtu.be/oRci9ITnMuM?t=01h57m24s)

[icon](https://youtu.be/oRci9ITnMuM?t=01h57m27s)

[library that doesn't end up on something](https://youtu.be/oRci9ITnMuM?t=01h57m28s)

[not](https://youtu.be/oRci9ITnMuM?t=01h57m31s)

[generating ico files so if people have a](https://youtu.be/oRci9ITnMuM?t=01h57m31s)

[nice one that they use](https://youtu.be/oRci9ITnMuM?t=01h57m33s)

[shoot me a message leave me a comment](https://youtu.be/oRci9ITnMuM?t=01h57m35s)

[would really appreciate it](https://youtu.be/oRci9ITnMuM?t=01h57m37s)

[so we also read virtualizing uh wrap](https://youtu.be/oRci9ITnMuM?t=01h57m39s)

[panel to 153](https://youtu.be/oRci9ITnMuM?t=01h57m42s)

[that's the panel that's actually used on](https://youtu.be/oRci9ITnMuM?t=01h57m44s)

[the icon page so](https://youtu.be/oRci9ITnMuM?t=01h57m45s)

[we've kind of already tested it perfect](https://youtu.be/oRci9ITnMuM?t=01h57m47s)

[so](https://youtu.be/oRci9ITnMuM?t=01h57m50s)

[adding icon generator](https://youtu.be/oRci9ITnMuM?t=01h57m51s)

[to the demo app](https://youtu.be/oRci9ITnMuM?t=01h57m55s)

[boom take that push](https://youtu.be/oRci9ITnMuM?t=01h57m59s)

[uh i'm gonna push it to my fork](https://youtu.be/oRci9ITnMuM?t=01h58m03s)

[and then pull request it](https://youtu.be/oRci9ITnMuM?t=01h58m06s)

[so we come over to pull requests](https://youtu.be/oRci9ITnMuM?t=01h58m10s)

[hello there we go i was too quick on the](https://youtu.be/oRci9ITnMuM?t=01h58m13s)

[draw](https://youtu.be/oRci9ITnMuM?t=01h58m17s)

[uh okay so we'll bring that in this is](https://youtu.be/oRci9ITnMuM?t=01h58m19s)

[gonna make the next release](https://youtu.be/oRci9ITnMuM?t=01h58m22s)

[because i deemed it so this is a demo](https://youtu.be/oRci9ITnMuM?t=01h58m24s)

[app and it's definitely an enhancement](https://youtu.be/oRci9ITnMuM?t=01h58m27s)

[and i want to make sure this gets tagged](https://youtu.be/oRci9ITnMuM?t=01h58m29s)

[in the release notes](https://youtu.be/oRci9ITnMuM?t=01h58m31s)

[so let's see adding in](https://youtu.be/oRci9ITnMuM?t=01h58m32s)

[functionality to the demo app](https://youtu.be/oRci9ITnMuM?t=01h58m37s)

[to create dot ico](https://youtu.be/oRci9ITnMuM?t=01h58m40s)

[files from the pack](https://youtu.be/oRci9ITnMuM?t=01h58m44s)

[icons](https://youtu.be/oRci9ITnMuM?t=01h58m47s)

[so that sounds great](https://youtu.be/oRci9ITnMuM?t=01h58m52s)

[and assuming that all passes the ci](https://youtu.be/oRci9ITnMuM?t=01h58m56s)

[system](https://youtu.be/oRci9ITnMuM?t=01h58m59s)

[we will let that go uh one of the other](https://youtu.be/oRci9ITnMuM?t=01h59m00s)

[things that i've been wanting to do is](https://youtu.be/oRci9ITnMuM?t=01h59m02s)

[start to convert over the azure devops](https://youtu.be/oRci9ITnMuM?t=01h59m04s)

[pipelines that i've built into github](https://youtu.be/oRci9ITnMuM?t=01h59m06s)

[actions](https://youtu.be/oRci9ITnMuM?t=01h59m08s)

[so that may end up being a stream for](https://youtu.be/oRci9ITnMuM?t=01h59m09s)

[next time as far as going through there](https://youtu.be/oRci9ITnMuM?t=01h59m11s)

[4-1-0 is starting to get a few items in](https://youtu.be/oRci9ITnMuM?t=01h59m14s)

[here so i may be looking to kick a](https://youtu.be/oRci9ITnMuM?t=01h59m17s)

[release here](https://youtu.be/oRci9ITnMuM?t=01h59m18s)

[in the not-too-distant future um there's](https://youtu.be/oRci9ITnMuM?t=01h59m20s)

[a few](https://youtu.be/oRci9ITnMuM?t=01h59m23s)

[minor things but there was a whole bunch](https://youtu.be/oRci9ITnMuM?t=01h59m23s)

[of bugs and issues that got logged this](https://youtu.be/oRci9ITnMuM?t=01h59m25s)

[week](https://youtu.be/oRci9ITnMuM?t=01h59m27s)

[um some of which should probably get](https://youtu.be/oRci9ITnMuM?t=01h59m28s)

[cleaned up](https://youtu.be/oRci9ITnMuM?t=01h59m31s)

[so i given that people are clearly now](https://youtu.be/oRci9ITnMuM?t=01h59m33s)

[playing with the 4-0 release](https://youtu.be/oRci9ITnMuM?t=01h59m36s)

[and putting it through its paces i'm](https://youtu.be/oRci9ITnMuM?t=01h59m37s)

[going to see how many of these things we](https://youtu.be/oRci9ITnMuM?t=01h59m40s)

[can](https://youtu.be/oRci9ITnMuM?t=01h59m41s)

[take care of and then probably look to](https://youtu.be/oRci9ITnMuM?t=01h59m43s)

[kick the](https://youtu.be/oRci9ITnMuM?t=01h59m45s)

[the 4-1 release the other thing that i](https://youtu.be/oRci9ITnMuM?t=01h59m46s)

[was aware of](https://youtu.be/oRci9ITnMuM?t=01h59m48s)

[um if anybody wants um some easy tasks](https://youtu.be/oRci9ITnMuM?t=01h59m49s)

[the](https://youtu.be/oRci9ITnMuM?t=01h59m52s)

[material design components](https://youtu.be/oRci9ITnMuM?t=01h59m53s)

[button i realized that if we look at the](https://youtu.be/oRci9ITnMuM?t=01h59m58s)

[buttons here](https://youtu.be/oRci9ITnMuM?t=02h00m01s)

[right](https://youtu.be/oRci9ITnMuM?t=02h00m02s)

[[Music]](https://youtu.be/oRci9ITnMuM?t=02h00m04s)

[so um they've got only a handful of](https://youtu.be/oRci9ITnMuM?t=02h00m06s)

[buttons they've got text button](https://youtu.be/oRci9ITnMuM?t=02h00m10s)

[right which is what ours calls a flat](https://youtu.be/oRci9ITnMuM?t=02h00m11s)

[button they've got](https://youtu.be/oRci9ITnMuM?t=02h00m13s)

[outline button right contained button](https://youtu.be/oRci9ITnMuM?t=02h00m14s)

[toggle button right i so](https://youtu.be/oRci9ITnMuM?t=02h00m19s)

[what i was hoping to do is go through](https://youtu.be/oRci9ITnMuM?t=02h00m22s)

[and create](https://youtu.be/oRci9ITnMuM?t=02h00m24s)

[additional styles that use](https://youtu.be/oRci9ITnMuM?t=02h00m25s)

[these names right the i don't want to](https://youtu.be/oRci9ITnMuM?t=02h00m29s)

[delete the existing ones because that](https://youtu.be/oRci9ITnMuM?t=02h00m32s)

[would be a breaking change](https://youtu.be/oRci9ITnMuM?t=02h00m33s)

[but i would like to start using styles](https://youtu.be/oRci9ITnMuM?t=02h00m34s)

[that](https://youtu.be/oRci9ITnMuM?t=02h00m38s)

[match the material design spec names](https://youtu.be/oRci9ITnMuM?t=02h00m38s)

[just to make it a little bit easier for](https://youtu.be/oRci9ITnMuM?t=02h00m40s)

[people going back and forth from](https://youtu.be/oRci9ITnMuM?t=02h00m42s)

[the material design page and this](https://youtu.be/oRci9ITnMuM?t=02h00m44s)

[library to make it a little bit easier](https://youtu.be/oRci9ITnMuM?t=02h00m47s)

[so that if you see something over here](https://youtu.be/oRci9ITnMuM?t=02h00m48s)

[same name applies and vice versa right](https://youtu.be/oRci9ITnMuM?t=02h00m50s)

[obviously that there's not a perfect one](https://youtu.be/oRci9ITnMuM?t=02h00m53s)

[to one comparison in a lot of cases](https://youtu.be/oRci9ITnMuM?t=02h00m54s)

[um just with the way the wpf controls](https://youtu.be/oRci9ITnMuM?t=02h00m57s)

[have to lay out but but](https://youtu.be/oRci9ITnMuM?t=02h01m00s)

[it's pretty simple and uh it'd be great](https://youtu.be/oRci9ITnMuM?t=02h01m01s)

[to have some styles added that just use](https://youtu.be/oRci9ITnMuM?t=02h01m04s)

[these names](https://youtu.be/oRci9ITnMuM?t=02h01m07s)

[so i'm picturing like material design](https://youtu.be/oRci9ITnMuM?t=02h01m08s)

[text button instead of what we call flat](https://youtu.be/oRci9ITnMuM?t=02h01m09s)

[button](https://youtu.be/oRci9ITnMuM?t=02h01m11s)

[or similar right so if somebody wants a](https://youtu.be/oRci9ITnMuM?t=02h01m12s)

[an easy pull request in](https://youtu.be/oRci9ITnMuM?t=02h01m14s)

[that would be something i may poke at](https://youtu.be/oRci9ITnMuM?t=02h01m16s)

[doing it](https://youtu.be/oRci9ITnMuM?t=02h01m18s)

[and once that goes in under the 5.0](https://youtu.be/oRci9ITnMuM?t=02h01m19s)

[changes i'll end up listing out](https://youtu.be/oRci9ITnMuM?t=02h01m21s)

[the the old styles that are going to get](https://youtu.be/oRci9ITnMuM?t=02h01m24s)

[obsoleted](https://youtu.be/oRci9ITnMuM?t=02h01m26s)

[right so there's certain things that](https://youtu.be/oRci9ITnMuM?t=02h01m27s)

[i've already flagged as obsolete](https://youtu.be/oRci9ITnMuM?t=02h01m28s)

[in the upcoming 410 release so just be](https://youtu.be/oRci9ITnMuM?t=02h01m31s)

[aware that those things come](https://youtu.be/oRci9ITnMuM?t=02h01m34s)

[5-0 are going to get dropped so my usual](https://youtu.be/oRci9ITnMuM?t=02h01m36s)

[way of handling this is i just leave a](https://youtu.be/oRci9ITnMuM?t=02h01m39s)

[list](https://youtu.be/oRci9ITnMuM?t=02h01m40s)

[of stuff that i know i want to break in](https://youtu.be/oRci9ITnMuM?t=02h01m41s)

[the next major rev and so when it comes](https://youtu.be/oRci9ITnMuM?t=02h01m43s)

[time to do that rev](https://youtu.be/oRci9ITnMuM?t=02h01m45s)

[i go and break it all at once but i try](https://youtu.be/oRci9ITnMuM?t=02h01m46s)

[to have a nice documented list](https://youtu.be/oRci9ITnMuM?t=02h01m48s)

[so anybody doing a migration uh](https://youtu.be/oRci9ITnMuM?t=02h01m50s)

[hopefully it makes your life a little](https://youtu.be/oRci9ITnMuM?t=02h01m52s)

[bit easier](https://youtu.be/oRci9ITnMuM?t=02h01m54s)

[uh oh it failed](https://youtu.be/oRci9ITnMuM?t=02h01m56s)

[that's sad uh check](https://youtu.be/oRci9ITnMuM?t=02h02m00s)

[failure oh so it wants nu171](https://youtu.be/oRci9ITnMuM?t=02h02m04s)

[we can go and fix this so for people](https://youtu.be/oRci9ITnMuM?t=02h02m09s)

[unfamiliar with how to](https://youtu.be/oRci9ITnMuM?t=02h02m11s)

[to deal with this case so this is the](https://youtu.be/oRci9ITnMuM?t=02h02m12s)

[situation where](https://youtu.be/oRci9ITnMuM?t=02h02m15s)

[um a nuget package](https://youtu.be/oRci9ITnMuM?t=02h02m16s)

[doesn't meet or doesn't match](https://youtu.be/oRci9ITnMuM?t=02h02m21s)

[your target framework such as what we](https://youtu.be/oRci9ITnMuM?t=02h02m25s)

[have here](https://youtu.be/oRci9ITnMuM?t=02h02m27s)

[and what we actually want to do here is](https://youtu.be/oRci9ITnMuM?t=02h02m28s)

[if we come over here](https://youtu.be/oRci9ITnMuM?t=02h02m30s)

[there's a nice little thing where you](https://youtu.be/oRci9ITnMuM?t=02h02m32s)

[can do suppress warnings](https://youtu.be/oRci9ITnMuM?t=02h02m34s)

[so all i did was right click on the](https://youtu.be/oRci9ITnMuM?t=02h02m35s)

[package in question hit properties](https://youtu.be/oRci9ITnMuM?t=02h02m37s)

[suppress warnings and use 1701 is a](https://youtu.be/oRci9ITnMuM?t=02h02m40s)

[fairly common one to say](https://youtu.be/oRci9ITnMuM?t=02h02m43s)

[trust me i'm a programmer hey](https://youtu.be/oRci9ITnMuM?t=02h02m45s)

[there and then what you should see over](https://youtu.be/oRci9ITnMuM?t=02h02m50s)

[here in](https://youtu.be/oRci9ITnMuM?t=02h02m52s)

[this guy is it'll add a little no](https://youtu.be/oRci9ITnMuM?t=02h02m53s)

[warrant attribute underneath your](https://youtu.be/oRci9ITnMuM?t=02h02m55s)

[package reference](https://youtu.be/oRci9ITnMuM?t=02h02m56s)

[so that you can see that hey this uh](https://youtu.be/oRci9ITnMuM?t=02h02m58s)

[this warning for this particular package](https://youtu.be/oRci9ITnMuM?t=02h03m01s)

[has been suppressed](https://youtu.be/oRci9ITnMuM?t=02h03m03s)

[so 1701 is just the common one that says](https://youtu.be/oRci9ITnMuM?t=02h03m05s)

[ignore the fact that it doesn't match](https://youtu.be/oRci9ITnMuM?t=02h03m08s)

[the the target framework moniker](https://youtu.be/oRci9ITnMuM?t=02h03m10s)

[uh i wonder why this thing's now showing](https://youtu.be/oRci9ITnMuM?t=02h03m13s)

[me an error](https://youtu.be/oRci9ITnMuM?t=02h03m16s)

[just rebuild and see it could this could](https://youtu.be/oRci9ITnMuM?t=02h03m18s)

[just be a designer issue again the](https://youtu.be/oRci9ITnMuM?t=02h03m20s)

[the centralized package management is](https://youtu.be/oRci9ITnMuM?t=02h03m22s)

[kind of a newish thing](https://youtu.be/oRci9ITnMuM?t=02h03m24s)

[and the visual studio ui sometimes gets](https://youtu.be/oRci9ITnMuM?t=02h03m25s)

[a little bit confused](https://youtu.be/oRci9ITnMuM?t=02h03m28s)

[it obviously works but sometimes the](https://youtu.be/oRci9ITnMuM?t=02h03m31s)

[state of it](https://youtu.be/oRci9ITnMuM?t=02h03m35s)

[doesn't seem like it's quite all there](https://youtu.be/oRci9ITnMuM?t=02h03m36s)

[do oh we actually have some warnings](https://youtu.be/oRci9ITnMuM?t=02h03m40s)

[here that i should probably address](https://youtu.be/oRci9ITnMuM?t=02h03m44s)

[oh so that needs to be changed there](https://youtu.be/oRci9ITnMuM?t=02h03m48s)

[uh let's see here uh](https://youtu.be/oRci9ITnMuM?t=02h03m55s)

[theme changed so what is this guy here](https://youtu.be/oRci9ITnMuM?t=02h04m03s)

[event handler](https://youtu.be/oRci9ITnMuM?t=02h04m06s)

[all right so this guy is nullable](https://youtu.be/oRci9ITnMuM?t=02h04m10s)

[i think that fixes it let's just](https://youtu.be/oRci9ITnMuM?t=02h04m17s)

[recompile that one more time and make](https://youtu.be/oRci9ITnMuM?t=02h04m19s)

[sure that we see](https://youtu.be/oRci9ITnMuM?t=02h04m21s)

[i just want to make sure i see all my](https://youtu.be/oRci9ITnMuM?t=02h04m22s)

[warnings go away so the](https://youtu.be/oRci9ITnMuM?t=02h04m23s)

[con it's worth noting too on the](https://youtu.be/oRci9ITnMuM?t=02h04m25s)

[pipeline](https://youtu.be/oRci9ITnMuM?t=02h04m28s)

[it turns on warnings as errors so the](https://youtu.be/oRci9ITnMuM?t=02h04m28s)

[idea being that](https://youtu.be/oRci9ITnMuM?t=02h04m31s)

[um people who want to contribute and](https://youtu.be/oRci9ITnMuM?t=02h04m33s)

[just download and play with the library](https://youtu.be/oRci9ITnMuM?t=02h04m35s)

[turning on warnings as theirs can be](https://youtu.be/oRci9ITnMuM?t=02h04m37s)

[really obnoxious for somebody it's like](https://youtu.be/oRci9ITnMuM?t=02h04m39s)

[i just want to make a quick and easy](https://youtu.be/oRci9ITnMuM?t=02h04m41s)

[change](https://youtu.be/oRci9ITnMuM?t=02h04m42s)

[i don't want to deal with all of the](https://youtu.be/oRci9ITnMuM?t=02h04m43s)

[extra stuff however by turning it on in](https://youtu.be/oRci9ITnMuM?t=02h04m44s)

[the pipeline](https://youtu.be/oRci9ITnMuM?t=02h04m47s)

[one it ensures that nobody accidentally](https://youtu.be/oRci9ITnMuM?t=02h04m48s)

[turns it off on me](https://youtu.be/oRci9ITnMuM?t=02h04m50s)

[and two it just helps maintain a](https://youtu.be/oRci9ITnMuM?t=02h04m52s)

[slightly higher quality bar for pull](https://youtu.be/oRci9ITnMuM?t=02h04m55s)

[requests so just be aware if you see](https://youtu.be/oRci9ITnMuM?t=02h04m56s)

[that happen](https://youtu.be/oRci9ITnMuM?t=02h04m59s)

[don't feel bad it happens to me all the](https://youtu.be/oRci9ITnMuM?t=02h05m00s)

[time](https://youtu.be/oRci9ITnMuM?t=02h05m03s)

[so let's see fix the nullability warning](https://youtu.be/oRci9ITnMuM?t=02h05m05s)

[fix the nu1701](https://youtu.be/oRci9ITnMuM?t=02h05m07s)

[so let's see fixing](https://youtu.be/oRci9ITnMuM?t=02h05m09s)

[build warnings](https://youtu.be/oRci9ITnMuM?t=02h05m12s)

[and we'll push that again](https://youtu.be/oRci9ITnMuM?t=02h05m16s)

[and hopefully the sky will kick off and](https://youtu.be/oRci9ITnMuM?t=02h05m20s)

[succeed](https://youtu.be/oRci9ITnMuM?t=02h05m23s)

[which would be great so we come back](https://youtu.be/oRci9ITnMuM?t=02h05m24s)

[here](https://youtu.be/oRci9ITnMuM?t=02h05m27s)

[and this guy should restart momentarily](https://youtu.be/oRci9ITnMuM?t=02h05m29s)

[once devops sees the](https://youtu.be/oRci9ITnMuM?t=02h05m33s)

[new commit that's another reason is](https://youtu.be/oRci9ITnMuM?t=02h05m36s)

[right now the](https://youtu.be/oRci9ITnMuM?t=02h05m38s)

[build pipelines are sitting off in azure](https://youtu.be/oRci9ITnMuM?t=02h05m40s)

[devops which is great except for it's a](https://youtu.be/oRci9ITnMuM?t=02h05m41s)

[little bit jarring to go from](https://youtu.be/oRci9ITnMuM?t=02h05m43s)

[github to devops and given how](https://youtu.be/oRci9ITnMuM?t=02h05m45s)

[quick and easy github actions are it](https://youtu.be/oRci9ITnMuM?t=02h05m49s)

[would be very nice to just have](https://youtu.be/oRci9ITnMuM?t=02h05m51s)

[everything in one place](https://youtu.be/oRci9ITnMuM?t=02h05m54s)

[and so that is my my ultimate end goal](https://youtu.be/oRci9ITnMuM?t=02h05m55s)

[is to](https://youtu.be/oRci9ITnMuM?t=02h05m58s)

[sneak it in there](https://youtu.be/oRci9ITnMuM?t=02h06m00s)

[this usually doesn't take too long i](https://youtu.be/oRci9ITnMuM?t=02h06m05s)

[just really want to see it get past the](https://youtu.be/oRci9ITnMuM?t=02h06m07s)

[build step](https://youtu.be/oRci9ITnMuM?t=02h06m08s)

[which usually doesn't take it but a](https://youtu.be/oRci9ITnMuM?t=02h06m11s)

[moment](https://youtu.be/oRci9ITnMuM?t=02h06m14s)

[and we'll see how](https://youtu.be/oRci9ITnMuM?t=02h06m21s)

[come on just compile that's all i want](https://youtu.be/oRci9ITnMuM?t=02h06m27s)

[to see](https://youtu.be/oRci9ITnMuM?t=02h06m29s)

[the other nice part about the](https://youtu.be/oRci9ITnMuM?t=02h06m38s)

[centralized package management is it](https://youtu.be/oRci9ITnMuM?t=02h06m39s)

[seems to restore a little quicker](https://youtu.be/oRci9ITnMuM?t=02h06m41s)

[that could just be my own perception but](https://youtu.be/oRci9ITnMuM?t=02h06m45s)

[it does seem like it goes](https://youtu.be/oRci9ITnMuM?t=02h06m47s)

[mildly faster](https://youtu.be/oRci9ITnMuM?t=02h06m49s)

[wow i wonder why the restore on that](https://youtu.be/oRci9ITnMuM?t=02h06m57s)

[project takes so long](https://youtu.be/oRci9ITnMuM?t=02h06m59s)

[or maybe that is](https://youtu.be/oRci9ITnMuM?t=02h07m02s)

[no i don't have an explanation that one](https://youtu.be/oRci9ITnMuM?t=02h07m06s)

[is slow](https://youtu.be/oRci9ITnMuM?t=02h07m10s)

[same with the test projects but the test](https://youtu.be/oRci9ITnMuM?t=02h07m13s)

[projects make a little more sense](https://youtu.be/oRci9ITnMuM?t=02h07m15s)

[because they're downloading](https://youtu.be/oRci9ITnMuM?t=02h07m17s)

[several extra nougat packages the test](https://youtu.be/oRci9ITnMuM?t=02h07m19s)

[runner](https://youtu.be/oRci9ITnMuM?t=02h07m21s)

[xaml test uh](https://youtu.be/oRci9ITnMuM?t=02h07m23s)

[x unit uh and similar so they](https://youtu.be/oRci9ITnMuM?t=02h07m26s)

[the unit test projects do have](https://youtu.be/oRci9ITnMuM?t=02h07m29s)

[significantly more dependencies](https://youtu.be/oRci9ITnMuM?t=02h07m31s)

[okay so the thing compiled so i'm gonna](https://youtu.be/oRci9ITnMuM?t=02h07m33s)

[go with this is probably going to work](https://youtu.be/oRci9ITnMuM?t=02h07m36s)

[because i can't imagine we've got any](https://youtu.be/oRci9ITnMuM?t=02h07m38s)

[tests that should break](https://youtu.be/oRci9ITnMuM?t=02h07m39s)

[on this and this will probably merge in](https://youtu.be/oRci9ITnMuM?t=02h07m41s)

[shortly](https://youtu.be/oRci9ITnMuM?t=02h07m43s)

[but with that i'm probably going to sign](https://youtu.be/oRci9ITnMuM?t=02h07m44s)

[off for the night tell everyone happy](https://youtu.be/oRci9ITnMuM?t=02h07m46s)

[coding](https://youtu.be/oRci9ITnMuM?t=02h07m48s)

[see everyone next time](https://youtu.be/oRci9ITnMuM?t=02h07m49s)

[you](https://youtu.be/oRci9ITnMuM?t=02h10m32s)

