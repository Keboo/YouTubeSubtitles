[YouTube Video](https://youtu.be/ATfuFU70Pjo)


[wrong one let's try this again](https://youtu.be/ATfuFU70Pjo?t=00h02m45s)



[there we go it's my first time hey](https://youtu.be/ATfuFU70Pjo?t=00h02m47s)



[everybody welcome tonight I'm gonna dive](https://youtu.be/ATfuFU70Pjo?t=00h02m49s)



[back into more material design and zamel](https://youtu.be/ATfuFU70Pjo?t=00h02m52s)



[stuff I unfortunately have had a crazy](https://youtu.be/ATfuFU70Pjo?t=00h02m54s)



[week and have not had a chance to get](https://youtu.be/ATfuFU70Pjo?t=00h02m57s)



[back to it since my last stream so I was](https://youtu.be/ATfuFU70Pjo?t=00h02m59s)



[planning on picking up where we left off](https://youtu.be/ATfuFU70Pjo?t=00h03m01s)



[there's a few issues and pull requests](https://youtu.be/ATfuFU70Pjo?t=00h03m03s)



[and questions and I was going to just](https://youtu.be/ATfuFU70Pjo?t=00h03m05s)



[see how much of that I can dive through](https://youtu.be/ATfuFU70Pjo?t=00h03m07s)



[and get taken care of tonight](https://youtu.be/ATfuFU70Pjo?t=00h03m08s)



[so for those people who didn't tuned in](https://youtu.be/ATfuFU70Pjo?t=00h03m09s)



[last time and I apologize I've realized](https://youtu.be/ATfuFU70Pjo?t=00h03m13s)



[I forgot to post the video to YouTube so](https://youtu.be/ATfuFU70Pjo?t=00h03m16s)



[I need to get that up soon last time](https://youtu.be/ATfuFU70Pjo?t=00h03m17s)



[where we left off is we had been](https://youtu.be/ATfuFU70Pjo?t=00h03m22s)



[cleaning up the application to use net](https://youtu.be/ATfuFU70Pjo?t=00h03m23s)



[core 3-1 so the expectation is right now](https://youtu.be/ATfuFU70Pjo?t=00h03m27s)



[the library compiles for both net core](https://youtu.be/ATfuFU70Pjo?t=00h03m31s)



[and dotnet framework but ultimately we](https://youtu.be/ATfuFU70Pjo?t=00h03m33s)



[want to move the dotnet core support to](https://youtu.be/ATfuFU70Pjo?t=00h03m36s)



[3-1 since that's the LTS version of.net](https://youtu.be/ATfuFU70Pjo?t=00h03m39s)



[core my intention with this library is](https://youtu.be/ATfuFU70Pjo?t=00h03m42s)



[to support any dotnet core version that](https://youtu.be/ATfuFU70Pjo?t=00h03m45s)



[Microsoft still supports it's worth](https://youtu.be/ATfuFU70Pjo?t=00h03m49s)



[knowing that these ones tend to iterate](https://youtu.be/ATfuFU70Pjo?t=00h03m51s)



[a little bit faster than net framework](https://youtu.be/ATfuFU70Pjo?t=00h03m52s)



[dotnet frameworks tied to the operating](https://youtu.be/ATfuFU70Pjo?t=00h03m54s)



[system that you're hooked up to so there](https://youtu.be/ATfuFU70Pjo?t=00h03m57s)



[is a little bit of a slow rep cycle with](https://youtu.be/ATfuFU70Pjo?t=00h03m59s)



[that where's dotnet core revs much](https://youtu.be/ATfuFU70Pjo?t=00h04m03s)



[quicker so there will probably be a lot](https://youtu.be/ATfuFU70Pjo?t=00h04m04s)



[of updates where those get revved so](https://youtu.be/ATfuFU70Pjo?t=00h04m06s)



[just be aware I'm prepared for that if](https://youtu.be/ATfuFU70Pjo?t=00h04m09s)



[you're building WPF against dotnet core](https://youtu.be/ATfuFU70Pjo?t=00h04m11s)



[so with that let's dive back in so the](https://youtu.be/ATfuFU70Pjo?t=00h04m14s)



[only thing I've managed to do so far is](https://youtu.be/ATfuFU70Pjo?t=00h04m18s)



[do that button there we go](https://youtu.be/ATfuFU70Pjo?t=00h04m21s)



[the only thing I've managed to do so far](https://youtu.be/ATfuFU70Pjo?t=00h04m24s)



[is to go through and I rebased](https://youtu.be/ATfuFU70Pjo?t=00h04m25s)



[the net core 3-1 branch on top of master](https://youtu.be/ATfuFU70Pjo?t=00h04m28s)



[because there was a couple fixes and](https://youtu.be/ATfuFU70Pjo?t=00h04m32s)



[whatnot that got put in the there's some](https://youtu.be/ATfuFU70Pjo?t=00h04m34s)



[breaking changes coming to the pack icon](https://youtu.be/ATfuFU70Pjo?t=00h04m38s)



[with some of the material design stuff](https://youtu.be/ATfuFU70Pjo?t=00h04m40s)



[there's some members that are just down](https://youtu.be/ATfuFU70Pjo?t=00h04m43s)



[missing so I did also clean up a little](https://youtu.be/ATfuFU70Pjo?t=00h04m46s)



[bit of the pack icon stuff so that](https://youtu.be/ATfuFU70Pjo?t=00h04m49s)



[they're sorted in a reasonable order it](https://youtu.be/ATfuFU70Pjo?t=00h04m51s)



[made for miserable merge at first](https://youtu.be/ATfuFU70Pjo?t=00h04m53s)



[but then it's hopefully going to clean](https://youtu.be/ATfuFU70Pjo?t=00h04m56s)



[things up going forward I still want to](https://youtu.be/ATfuFU70Pjo?t=00h04m58s)



[fix I don't like that I don't see my](https://youtu.be/ATfuFU70Pjo?t=00h05m00s)



[flashy cursor right there](https://youtu.be/ATfuFU70Pjo?t=00h05m03s)



[I want that to get cleaned up Oh](https://youtu.be/ATfuFU70Pjo?t=00h05m05s)



[interesting did they change the sam'l](https://youtu.be/ATfuFU70Pjo?t=00h05m09s)



[looks like they changed the sam'l icon](https://youtu.be/ATfuFU70Pjo?t=00h05m14s)



[interesting interesting uh yeah let's](https://youtu.be/ATfuFU70Pjo?t=00h05m20s)



[let's look at that real quick that](https://youtu.be/ATfuFU70Pjo?t=00h05m23s)



[actually surprises me so that is the](https://youtu.be/ATfuFU70Pjo?t=00h05m25s)



[show me the sam'l control as doing that](https://youtu.be/ATfuFU70Pjo?t=00h05m27s)



[and we've got a specifically the sam'l](https://youtu.be/ATfuFU70Pjo?t=00h05m30s)



[display control inside of the show me](https://youtu.be/ATfuFU70Pjo?t=00h05m33s)



[the sam'l library which is mine so if](https://youtu.be/ATfuFU70Pjo?t=00h05m34s)



[there's a bug in it we just go fix it](https://youtu.be/ATfuFU70Pjo?t=00h05m38s)



[but let's see here so PAC icon kind](https://youtu.be/ATfuFU70Pjo?t=00h05m39s)



[zamel oh and I think this is the one](https://youtu.be/ATfuFU70Pjo?t=00h05m43s)



[that's dropping let's double check that](https://youtu.be/ATfuFU70Pjo?t=00h05m47s)



[real quick so there was a comment](https://youtu.be/ATfuFU70Pjo?t=00h05m49s)



[normally normally people don't get a](https://youtu.be/ATfuFU70Pjo?t=00h05m53s)



[chance to comment on these pull requests](https://youtu.be/ATfuFU70Pjo?t=00h05m55s)



[yeah sam'l being dropped](https://youtu.be/ATfuFU70Pjo?t=00h05m58s)



[so this pull request here when you see](https://youtu.be/ATfuFU70Pjo?t=00h06m00s)



[this as your pipelines thing on here](https://youtu.be/ATfuFU70Pjo?t=00h06m02s)



[this means this is an auto-generated PR](https://youtu.be/ATfuFU70Pjo?t=00h06m04s)



[I've got a pipeline that runs every](https://youtu.be/ATfuFU70Pjo?t=00h06m06s)



[night it goes and checks the material](https://youtu.be/ATfuFU70Pjo?t=00h06m09s)



[design icons updates them to all the](https://youtu.be/ATfuFU70Pjo?t=00h06m11s)



[latest and greatest stuff so zamel is](https://youtu.be/ATfuFU70Pjo?t=00h06m13s)



[gone oh no sam'l isn't gone it's just](https://youtu.be/ATfuFU70Pjo?t=00h06m20s)



[they've changed it yeah so this drops](https://youtu.be/ATfuFU70Pjo?t=00h06m23s)



[but still there okay so and it's kind of](https://youtu.be/ATfuFU70Pjo?t=00h06m26s)



[hard to tell with some of these changes](https://youtu.be/ATfuFU70Pjo?t=00h06m32s)



[because this pull request gets rebranded](https://youtu.be/ATfuFU70Pjo?t=00h06m34s)



[every time or I should say it's forced](https://youtu.be/ATfuFU70Pjo?t=00h06m39s)



[pushed over the top so this comment came](https://youtu.be/ATfuFU70Pjo?t=00h06m41s)



[in two days ago and then there was an](https://youtu.be/ATfuFU70Pjo?t=00h06m44s)



[update 21 hours ago so be aware](https://youtu.be/ATfuFU70Pjo?t=00h06m45s)



[sometimes these icon changes I generally](https://youtu.be/ATfuFU70Pjo?t=00h06m49s)



[just Rev them pretty quick I give them a](https://youtu.be/ATfuFU70Pjo?t=00h06m51s)



[cursory glance to see if there's any](https://youtu.be/ATfuFU70Pjo?t=00h06m54s)



[deletions because I try to track those](https://youtu.be/ATfuFU70Pjo?t=00h06m55s)



[in the release notes but other than that](https://youtu.be/ATfuFU70Pjo?t=00h06m57s)



[I'm always just taking the latest and](https://youtu.be/ATfuFU70Pjo?t=00h06m59s)



[greatest icons I don't see a big reason](https://youtu.be/ATfuFU70Pjo?t=00h07m02s)



[to stay behind it doesn't mean that with](https://youtu.be/ATfuFU70Pjo?t=00h07m04s)



[each update it's not really](https://youtu.be/ATfuFU70Pjo?t=00h07m06s)



[feasible for me to keep track of which](https://youtu.be/ATfuFU70Pjo?t=00h07m09s)



[icons have visual changes to them so](https://youtu.be/ATfuFU70Pjo?t=00h07m11s)



[unfortunately those ones are going to be](https://youtu.be/ATfuFU70Pjo?t=00h07m15s)



[trial and error it would be nice if](https://youtu.be/ATfuFU70Pjo?t=00h07m18s)



[somebody wanted to write some sort of](https://youtu.be/ATfuFU70Pjo?t=00h07m20s)



[magical dipping tool or cleanup that](https://youtu.be/ATfuFU70Pjo?t=00h07m22s)



[generated some of this so that it was](https://youtu.be/ATfuFU70Pjo?t=00h07m25s)



[easier to look at but this is like this](https://youtu.be/ATfuFU70Pjo?t=00h07m26s)



[says a large diff so buyer beware](https://youtu.be/ATfuFU70Pjo?t=00h07m31s)



[because we could certainly clean it up](https://youtu.be/ATfuFU70Pjo?t=00h07m35s)



[to get it into a much more maintainable](https://youtu.be/ATfuFU70Pjo?t=00h07m37s)



[state and I might get around to that](https://youtu.be/ATfuFU70Pjo?t=00h07m39s)



[just so I can look at it but dipping](https://youtu.be/ATfuFU70Pjo?t=00h07m41s)



[path data it's always hard to tell when](https://youtu.be/ATfuFU70Pjo?t=00h07m43s)



[there's just a slight tweak to things so](https://youtu.be/ATfuFU70Pjo?t=00h07m45s)



[be aware that is coming but that should](https://youtu.be/ATfuFU70Pjo?t=00h07m48s)



[be fine so more importantly the app](https://youtu.be/ATfuFU70Pjo?t=00h07m51s)



[fires up and runs so that that was sort](https://youtu.be/ATfuFU70Pjo?t=00h07m56s)



[of step one to get cleaned up and in and](https://youtu.be/ATfuFU70Pjo?t=00h07m58s)



[done I really want to write some UI](https://youtu.be/ATfuFU70Pjo?t=00h08m01s)



[tests that at least just kind of walk](https://youtu.be/ATfuFU70Pjo?t=00h08m04s)



[through this thing and validate that](https://youtu.be/ATfuFU70Pjo?t=00h08m06s)



[everything works right so I think that's](https://youtu.be/ATfuFU70Pjo?t=00h08m08s)



[probably pretty good I'm just trying to](https://youtu.be/ATfuFU70Pjo?t=00h08m14s)



[check and see what all the changes work](https://youtu.be/ATfuFU70Pjo?t=00h08m16s)



[because most of this stuff was all](https://youtu.be/ATfuFU70Pjo?t=00h08m19s)



[around CS prods changes and copyrights](https://youtu.be/ATfuFU70Pjo?t=00h08m20s)



[and all of that jazz so most of it isn't](https://youtu.be/ATfuFU70Pjo?t=00h08m23s)



[too bad a lot of it was just updating](https://youtu.be/ATfuFU70Pjo?t=00h08m26s)



[packet and grabbing the latest and](https://youtu.be/ATfuFU70Pjo?t=00h08m28s)



[greatest stuff across the board so the](https://youtu.be/ATfuFU70Pjo?t=00h08m31s)



[last thing we're going to do is I want](https://youtu.be/ATfuFU70Pjo?t=00h08m33s)



[to make sure that this that all of these](https://youtu.be/ATfuFU70Pjo?t=00h08m37s)



[changes that I've done work in a clean](https://youtu.be/ATfuFU70Pjo?t=00h08m38s)



[solution so we are going to shut this](https://youtu.be/ATfuFU70Pjo?t=00h08m42s)



[down see don't need you anymore let me](https://youtu.be/ATfuFU70Pjo?t=00h08m44s)



[grab a PowerShell window here real quick](https://youtu.be/ATfuFU70Pjo?t=00h08m47s)



[and](https://youtu.be/ATfuFU70Pjo?t=00h08m51s)



[oh yes I do use transparency on my](https://youtu.be/ATfuFU70Pjo?t=00h08m54s)



[terminal windows it's weird](https://youtu.be/ATfuFU70Pjo?t=00h08m58s)



[I kind of like it so we go with it okay](https://youtu.be/ATfuFU70Pjo?t=00h09m00s)



[so first thing before doing this command](https://youtu.be/ATfuFU70Pjo?t=00h09m03s)



[always always always check to see if you](https://youtu.be/ATfuFU70Pjo?t=00h09m07s)



[have pending changes this next command](https://youtu.be/ATfuFU70Pjo?t=00h09m10s)



[is going to be highly destructive so](https://youtu.be/ATfuFU70Pjo?t=00h09m12s)



[anything you don't save will get lost](https://youtu.be/ATfuFU70Pjo?t=00h09m14s)



[so get clean D F X so D says directories](https://youtu.be/ATfuFU70Pjo?t=00h09m17s)



[to F says force and X says blow away](https://youtu.be/ATfuFU70Pjo?t=00h09m25s)



[things that aren't under source control](https://youtu.be/ATfuFU70Pjo?t=00h09m29s)



[so this will effectively reset your repo](https://youtu.be/ATfuFU70Pjo?t=00h09m30s)



[to a clean state as though you just did](https://youtu.be/ATfuFU70Pjo?t=00h09m34s)



[a fresh clone so which is great that's](https://youtu.be/ATfuFU70Pjo?t=00h09m37s)



[ultimately what we're looking to test](https://youtu.be/ATfuFU70Pjo?t=00h09m41s)



[right is we want to make sure that this](https://youtu.be/ATfuFU70Pjo?t=00h09m42s)



[guy here still works in a clean state](https://youtu.be/ATfuFU70Pjo?t=00h09m45s)



[Oh first cup of coffees down it's okay](https://youtu.be/ATfuFU70Pjo?t=00h09m56s)



[I have Mountain Dew we're good we're](https://youtu.be/ATfuFU70Pjo?t=00h10m01s)



[good](https://youtu.be/ATfuFU70Pjo?t=00h10m05s)



[plenty of caffeine okay so step one](https://youtu.be/ATfuFU70Pjo?t=00h10m06s)



[launches ctrl shift B and let's fire](https://youtu.be/ATfuFU70Pjo?t=00h10m09s)



[this off I sort of expected these show](https://youtu.be/ATfuFU70Pjo?t=00h10m12s)



[me this Amal to trigger on the first](https://youtu.be/ATfuFU70Pjo?t=00h10m15s)



[pass and cause an air that says please](https://youtu.be/ATfuFU70Pjo?t=00h10m17s)



[rebuild this is normal on your initial](https://youtu.be/ATfuFU70Pjo?t=00h10m21s)



[clone just be aware the way they show me](https://youtu.be/ATfuFU70Pjo?t=00h10m23s)



[the Sam will stuff works with packet](https://youtu.be/ATfuFU70Pjo?t=00h10m26s)



[because it injects in the middle it kind](https://youtu.be/ATfuFU70Pjo?t=00h10m27s)



[of requires a rebuild and I assume this](https://youtu.be/ATfuFU70Pjo?t=00h10m31s)



[is hiding down here at the bottom let's](https://youtu.be/ATfuFU70Pjo?t=00h10m33s)



[go down here not package manager build](https://youtu.be/ATfuFU70Pjo?t=00h10m37s)



[so claim to have problems with generated](https://youtu.be/ATfuFU70Pjo?t=00h10m42s)



[asset file claimed problems with asset](https://youtu.be/ATfuFU70Pjo?t=00h10m46s)



[file let's just rebuild one more time](https://youtu.be/ATfuFU70Pjo?t=00h10m49s)



[ctrl shift B fire this off](https://youtu.be/ATfuFU70Pjo?t=00h10m52s)



[we leave a](https://youtu.be/ATfuFU70Pjo?t=00h11m09s)



[oh yeah yeah yeah a bunch of ears that](https://youtu.be/ATfuFU70Pjo?t=00h11m15s)



[don't make a lot of sense in this](https://youtu.be/ATfuFU70Pjo?t=00h11m18s)



[context the MC heirs aren't actually](https://youtu.be/ATfuFU70Pjo?t=00h11m19s)



[compile heirs](https://youtu.be/ATfuFU70Pjo?t=00h11m22s)



[these are zamel things it's also](https://youtu.be/ATfuFU70Pjo?t=00h11m23s)



[important to note where these came from](https://youtu.be/ATfuFU70Pjo?t=00h11m27s)



[right so this one specifically is under](https://youtu.be/ATfuFU70Pjo?t=00h11m30s)



[4/7 to just gonna keep going one more](https://youtu.be/ATfuFU70Pjo?t=00h11m34s)



[time this is not you instilling me with](https://youtu.be/ATfuFU70Pjo?t=00h11m40s)



[much confidence](https://youtu.be/ATfuFU70Pjo?t=00h11m42s)



[what's going on here guys what's going](https://youtu.be/ATfuFU70Pjo?t=00h11m49s)



[on here so we blew away the packages](https://youtu.be/ATfuFU70Pjo?t=00h11m51s)



[which makes sense](https://youtu.be/ATfuFU70Pjo?t=00h11m57s)



[those aren't under source control](https://youtu.be/ATfuFU70Pjo?t=00h12m00s)



[okay well let's start figuring out what](https://youtu.be/ATfuFU70Pjo?t=00h12m17s)



[the heck's going wrong so when in doubt](https://youtu.be/ATfuFU70Pjo?t=00h12m19s)



[always go to the first error because too](https://youtu.be/ATfuFU70Pjo?t=00h12m22s)



[often the the later errors are just](https://youtu.be/ATfuFU70Pjo?t=00h12m25s)



[because something went wrong at the](https://youtu.be/ATfuFU70Pjo?t=00h12m28s)



[beginning so warning warning warning](https://youtu.be/ATfuFU70Pjo?t=00h12m30s)



[warning warning warning](https://youtu.be/ATfuFU70Pjo?t=00h12m32s)



[let's see done building project material](https://youtu.be/ATfuFU70Pjo?t=00h12m35s)



[design themes this is the generated CS](https://youtu.be/ATfuFU70Pjo?t=00h12m38s)



[proj when you compile against net core](https://youtu.be/ATfuFU70Pjo?t=00h12m41s)



[so that makes sense some more warnings](https://youtu.be/ATfuFU70Pjo?t=00h12m43s)



[in here done building the one I'm](https://youtu.be/ATfuFU70Pjo?t=00h12m47s)



[assuming against framework no net core](https://youtu.be/ATfuFU70Pjo?t=00h12m50s)



[okay done building done building there](https://youtu.be/ATfuFU70Pjo?t=00h12m54s)



[dotnet core Windows desktop is required](https://youtu.be/ATfuFU70Pjo?t=00h13m03s)



[to build desktop application so this is](https://youtu.be/ATfuFU70Pjo?t=00h13m06s)



[interesting that this one's squawking](https://youtu.be/ATfuFU70Pjo?t=00h13m11s)



[material design things WPF tests so this](https://youtu.be/ATfuFU70Pjo?t=00h13m14s)



[seems like there's an issue with our](https://youtu.be/ATfuFU70Pjo?t=00h13m17s)



[tests in here somewhere](https://youtu.be/ATfuFU70Pjo?t=00h13m19s)



[we'll go and check that in a moment okay](https://youtu.be/ATfuFU70Pjo?t=00h13m20s)



[their program does not contain a static](https://youtu.be/ATfuFU70Pjo?t=00h13m30s)



[main method didn't we run into this last](https://youtu.be/ATfuFU70Pjo?t=00h13m34s)



[time - I think we did I'm noticing this](https://youtu.be/ATfuFU70Pjo?t=00h13m38s)



[appears to be in the MA apps once so](https://youtu.be/ATfuFU70Pjo?t=00h13m42s)



[let's start with this demos when in](https://youtu.be/ATfuFU70Pjo?t=00h13m44s)



[doubt let's just unload and then we're](https://youtu.be/ATfuFU70Pjo?t=00h13m48s)



[gonna unload these unload projects okay](https://youtu.be/ATfuFU70Pjo?t=00h13m51s)



[compile and I believe this works](https://youtu.be/ATfuFU70Pjo?t=00h13m59s)



[No okay](https://youtu.be/ATfuFU70Pjo?t=00h14m06s)



[while we note it down](https://youtu.be/ATfuFU70Pjo?t=00h14m09s)



[so where did you fall apart air source](https://youtu.be/ATfuFU70Pjo?t=00h14m16s)



[file could not be found so this is the](https://youtu.be/ATfuFU70Pjo?t=00h14m23s)



[other problem is it looks like it's](https://youtu.be/ATfuFU70Pjo?t=00h14m26s)



[compiling parallel so which one names my](https://youtu.be/ATfuFU70Pjo?t=00h14m27s)



[apps](https://youtu.be/ATfuFU70Pjo?t=00h14m36s)



[so this doesn't appear to have the WPF](https://youtu.be/ATfuFU70Pjo?t=00h14m43s)



[trigger on it does it need it I think it](https://youtu.be/ATfuFU70Pjo?t=00h14m45s)



[is isn't it let's see use WPF true so I](https://youtu.be/ATfuFU70Pjo?t=00h14m48s)



[don't know how we were getting away with](https://youtu.be/ATfuFU70Pjo?t=00h14m57s)



[this before okay](https://youtu.be/ATfuFU70Pjo?t=00h14m59s)



[build just keep working through these](https://youtu.be/ATfuFU70Pjo?t=00h15m06s)



[airs hey there we go okay so that's now](https://youtu.be/ATfuFU70Pjo?t=00h15m09s)



[compiling let's reload this project and](https://youtu.be/ATfuFU70Pjo?t=00h15m15s)



[build it okay that's in a working state](https://youtu.be/ATfuFU70Pjo?t=00h15m18s)



[reload project and build it that's in a](https://youtu.be/ATfuFU70Pjo?t=00h15m26s)



[building state reload project build it](https://youtu.be/ATfuFU70Pjo?t=00h15m34s)



[be surprised if that was the only thing](https://youtu.be/ATfuFU70Pjo?t=00h15m41s)



[there that was a problem that was it](https://youtu.be/ATfuFU70Pjo?t=00h15m43s)



[okay so I'm going to just do a full](https://youtu.be/ATfuFU70Pjo?t=00h15m46s)



[rebuild real quick make sure this works](https://youtu.be/ATfuFU70Pjo?t=00h15m50s)



[and if this isn't a good working state I](https://youtu.be/ATfuFU70Pjo?t=00h15m51s)



[think I'm gonna go through that same](https://youtu.be/ATfuFU70Pjo?t=00h15m54s)



[process again commit all the changes and](https://youtu.be/ATfuFU70Pjo?t=00h15m55s)



[then we're gonna clean the repo ins and](https://youtu.be/ATfuFU70Pjo?t=00h15m58s)



[start from a fresh state just want to](https://youtu.be/ATfuFU70Pjo?t=00h16m01s)



[make sure that this works for everybody](https://youtu.be/ATfuFU70Pjo?t=00h16m03s)



[something went boom](https://youtu.be/ATfuFU70Pjo?t=00h16m10s)



[Tero design demo project failed](https://youtu.be/ATfuFU70Pjo?t=00h16m15s)



[do I have some weird dependency tree](https://youtu.be/ATfuFU70Pjo?t=00h16m24s)



[problem why did it build them all](https://youtu.be/ATfuFU70Pjo?t=00h16m26s)



[individually but then decides to blow up](https://youtu.be/ATfuFU70Pjo?t=00h16m30s)



[okay WPF is dependent on colors right my](https://youtu.be/ATfuFU70Pjo?t=00h16m33s)



[app is dependent on WPF seems mom's](https://youtu.be/ATfuFU70Pjo?t=00h16m39s)



[themes and colors okay colors has no](https://youtu.be/ATfuFU70Pjo?t=00h16m43s)



[dependencies colors tests only depends](https://youtu.be/ATfuFU70Pjo?t=00h16m48s)



[on colors demo requires colors and WPF](https://youtu.be/ATfuFU70Pjo?t=00h16m50s)



[okay that's the same one my apps](https://youtu.be/ATfuFU70Pjo?t=00h16m55s)



[requires colors themes make sense](https://youtu.be/ATfuFU70Pjo?t=00h17m00s)



[goofy F requires colors WPF test scholar](https://youtu.be/ATfuFU70Pjo?t=00h17m06s)



[themes okay so that that all makes sense](https://youtu.be/ATfuFU70Pjo?t=00h17m13s)



[to me](https://youtu.be/ATfuFU70Pjo?t=00h17m17s)



[so let's clear this build logging term](https://youtu.be/ATfuFU70Pjo?t=00h17m24s)



[build logging on build let's figure out](https://youtu.be/ATfuFU70Pjo?t=00h17m28s)



[where this is blowing up](https://youtu.be/ATfuFU70Pjo?t=00h17m33s)



[I'd say let's filter if we can let's](https://youtu.be/ATfuFU70Pjo?t=00h17m41s)



[turn off design time builds not really](https://youtu.be/ATfuFU70Pjo?t=00h17m44s)



[interested in looking at those](https://youtu.be/ATfuFU70Pjo?t=00h17m47s)



[status running running](https://youtu.be/ATfuFU70Pjo?t=00h17m59s)



[they are finished](https://youtu.be/ATfuFU70Pjo?t=00h18m04s)



[okay just make an absolute certain that](https://youtu.be/ATfuFU70Pjo?t=00h18m08s)



[it finishes](https://youtu.be/ATfuFU70Pjo?t=00h18m13s)



[okay well it appears to have finished](https://youtu.be/ATfuFU70Pjo?t=00h18m20s)



[okay so back to the same thing again](https://youtu.be/ATfuFU70Pjo?t=00h18m22s)



[let's see sixteen missing property I](https://youtu.be/ATfuFU70Pjo?t=00h18m25s)



[think we might go through and do some](https://youtu.be/ATfuFU70Pjo?t=00h18m33s)



[directory build.prop stuff I'm just](https://youtu.be/ATfuFU70Pjo?t=00h18m35s)



[pushing just in case I botched something](https://youtu.be/ATfuFU70Pjo?t=00h18m38s)



[on my local repository I always want to](https://youtu.be/ATfuFU70Pjo?t=00h18m43s)



[be able to get it back](https://youtu.be/ATfuFU70Pjo?t=00h18m44s)



[wipe the directory clean again I think](https://youtu.be/ATfuFU70Pjo?t=00h18m45s)



[we're getting close for those people who](https://youtu.be/ATfuFU70Pjo?t=00h18m52s)



[are still wondering about my apps I'm](https://youtu.be/ATfuFU70Pjo?t=00h18m56s)



[just kind of holding I don't plan on](https://youtu.be/ATfuFU70Pjo?t=00h18m59s)



[releasing the integration package and](https://youtu.be/ATfuFU70Pjo?t=00h19m02s)



[tell my ops to oh drops and on the note](https://youtu.be/ATfuFU70Pjo?t=00h19m04s)



[of nougat packages it is worth noting](https://youtu.be/ATfuFU70Pjo?t=00h19m08s)



[the preview nougat packages there's an](https://youtu.be/ATfuFU70Pjo?t=00h19m10s)



[unfortunate problem in that the way the](https://youtu.be/ATfuFU70Pjo?t=00h19m12s)



[version numbers are being done it's just](https://youtu.be/ATfuFU70Pjo?t=00h19m16s)



[dropping the build ID on the end of this](https://youtu.be/ATfuFU70Pjo?t=00h19m18s)



[- CI on the nougat package the problem](https://youtu.be/ATfuFU70Pjo?t=00h19m22s)



[is is we were in the 900s and then we](https://youtu.be/ATfuFU70Pjo?t=00h19m24s)



[hit a thousand and when you do string](https://youtu.be/ATfuFU70Pjo?t=00h19m26s)



[comparisons one thousand comes be well](https://youtu.be/ATfuFU70Pjo?t=00h19m30s)



[chronologically before nine hundred and](https://youtu.be/ATfuFU70Pjo?t=00h19m36s)



[so it's not seen as there's of there](https://youtu.be/ATfuFU70Pjo?t=00h19m39s)



[being an update so it's a little](https://youtu.be/ATfuFU70Pjo?t=00h19m41s)



[unfortunate you kind of just have to](https://youtu.be/ATfuFU70Pjo?t=00h19m43s)



[roll back I don't know of a great way of](https://youtu.be/ATfuFU70Pjo?t=00h19m45s)



[fixing it without pushing out the 3-1](https://youtu.be/ATfuFU70Pjo?t=00h19m46s)



[release so ultimately that's going to be](https://youtu.be/ATfuFU70Pjo?t=00h19m49s)



[the fix is we'll push three one out the](https://youtu.be/ATfuFU70Pjo?t=00h19m52s)



[door and then the problem will go away](https://youtu.be/ATfuFU70Pjo?t=00h19m54s)



[at least until we hit 9999 not real](https://youtu.be/ATfuFU70Pjo?t=00h19m55s)



[concerned about that yet if people have](https://youtu.be/ATfuFU70Pjo?t=00h20m03s)



[solutions on how to propose the](https://youtu.be/ATfuFU70Pjo?t=00h20m07s)



[versioning I thought about zero pre](https://youtu.be/ATfuFU70Pjo?t=00h20m09s)



[fixing it and various things but all of](https://youtu.be/ATfuFU70Pjo?t=00h20m10s)



[those problems don't they don't fix the](https://youtu.be/ATfuFU70Pjo?t=00h20m12s)



[problem until I'm ready to push out the](https://youtu.be/ATfuFU70Pjo?t=00h20m15s)



[next release so just kind of holding](https://youtu.be/ATfuFU70Pjo?t=00h20m18s)



[because anything I do I don't think](https://youtu.be/ATfuFU70Pjo?t=00h20m24s)



[fixes the the current problem of the the](https://youtu.be/ATfuFU70Pjo?t=00h20m26s)



[current release means ci9 is effectively](https://youtu.be/ATfuFU70Pjo?t=00h20m29s)



[what nougats gonna see is the latest](https://youtu.be/ATfuFU70Pjo?t=00h20m32s)



[it succeeded okay I think I am ready to](https://youtu.be/ATfuFU70Pjo?t=00h20m44s)



[push this so let's let's pull request](https://youtu.be/ATfuFU70Pjo?t=00h20m49s)



[this beast so if we go here on pull](https://youtu.be/ATfuFU70Pjo?t=00h20m53s)



[requests compare and pull requests let's](https://youtu.be/ATfuFU70Pjo?t=00h20m56s)



[take a quick quick peek](https://youtu.be/ATfuFU70Pjo?t=00h20m58s)



[we're gonna make sure that the pipeline](https://youtu.be/ATfuFU70Pjo?t=00h21m00s)



[actually runs appropriately on this](https://youtu.be/ATfuFU70Pjo?t=00h21m03s)



[before we get too carried away let's see](https://youtu.be/ATfuFU70Pjo?t=00h21m05s)



[three one zero let's just quickly scan](https://youtu.be/ATfuFU70Pjo?t=00h21m07s)



[through this so packet restore targets](https://youtu.be/ATfuFU70Pjo?t=00h21m12s)



[load diff oh this is just an update to](https://youtu.be/ATfuFU70Pjo?t=00h21m16s)



[the packet file I don't care about that](https://youtu.be/ATfuFU70Pjo?t=00h21m21s)



[packet sha don't care we revved a](https://youtu.be/ATfuFU70Pjo?t=00h21m23s)



[version of packets binary file binary](https://youtu.be/ATfuFU70Pjo?t=00h21m26s)



[file both of those got Rev not concerned](https://youtu.be/ATfuFU70Pjo?t=00h21m28s)



[packet dot targets again that's their](https://youtu.be/ATfuFU70Pjo?t=00h21m30s)



[file not ours I don't care so we went](https://youtu.be/ATfuFU70Pjo?t=00h21m34s)



[from three O 2 3 1 copy right version](https://youtu.be/ATfuFU70Pjo?t=00h21m36s)



[revved three one version Rev three one](https://youtu.be/ATfuFU70Pjo?t=00h21m39s)



[this was very important I spent way too](https://youtu.be/ATfuFU70Pjo?t=00h21m44s)



[much time last week chasing down why it](https://youtu.be/ATfuFU70Pjo?t=00h21m48s)



[claimed that this wasn't here only to](https://youtu.be/ATfuFU70Pjo?t=00h21m51s)



[realize that I had forgot to change this](https://youtu.be/ATfuFU70Pjo?t=00h21m53s)



[zero to a one](https://youtu.be/ATfuFU70Pjo?t=00h21m55s)



[let's see here twenty twenty three one](https://youtu.be/ATfuFU70Pjo?t=00h21m57s)



[three one net core at three one let's](https://youtu.be/ATfuFU70Pjo?t=00h22m01s)



[see net core app three one this is all](https://youtu.be/ATfuFU70Pjo?t=00h22m06s)



[for the nougat package stuff change that](https://youtu.be/ATfuFU70Pjo?t=00h22m09s)



[guy to do we did do some mild updates to](https://youtu.be/ATfuFU70Pjo?t=00h22m12s)



[the mah app stuff because I noticed that](https://youtu.be/ATfuFU70Pjo?t=00h22m18s)



[they had changed some of their](https://youtu.be/ATfuFU70Pjo?t=00h22m20s)



[properties and where they were located](https://youtu.be/ATfuFU70Pjo?t=00h22m21s)



[so this controls helper went away and it](https://youtu.be/ATfuFU70Pjo?t=00h22m23s)



[went to a header control helper so we](https://youtu.be/ATfuFU70Pjo?t=00h22m25s)



[fix those not directly related to this](https://youtu.be/ATfuFU70Pjo?t=00h22m28s)



[but it kind of got in my way when we](https://youtu.be/ATfuFU70Pjo?t=00h22m31s)



[grabbed all the packages so we just](https://youtu.be/ATfuFU70Pjo?t=00h22m32s)



[fixed it this is the key change here of](https://youtu.be/ATfuFU70Pjo?t=00h22m34s)



[the global JSON this means that if you](https://youtu.be/ATfuFU70Pjo?t=00h22m37s)



[load this up that you are going to be](https://youtu.be/ATfuFU70Pjo?t=00h22m39s)



[required to have the three one version](https://youtu.be/ATfuFU70Pjo?t=00h22m41s)



[of the dotnet core SDK installed to](https://youtu.be/ATfuFU70Pjo?t=00h22m44s)



[compile from source so once this merges](https://youtu.be/ATfuFU70Pjo?t=00h22m46s)



[we will go and update that this guy has](https://youtu.be/ATfuFU70Pjo?t=00h22m48s)



[target frameworks of four five four](https://youtu.be/ATfuFU70Pjo?t=00h22m54s)



[seven two](https://youtu.be/ATfuFU70Pjo?t=00h22m56s)



[net core app three oh I want to](https://youtu.be/ATfuFU70Pjo?t=00h22m57s)



[double-check that real quick because I](https://youtu.be/ATfuFU70Pjo?t=00h23m00s)



[was thinking about it and I don't think](https://youtu.be/ATfuFU70Pjo?t=00h23m01s)



[we need I don't recall what we retired](https://youtu.be/ATfuFU70Pjo?t=00h23m03s)



[no we are targeting net four five so so](https://youtu.be/ATfuFU70Pjo?t=00h23m06s)



[net four five for the library four seven](https://youtu.be/ATfuFU70Pjo?t=00h23m10s)



[two for the demo apps because we target](https://youtu.be/ATfuFU70Pjo?t=00h23m13s)



[latest stuff for those and then net core](https://youtu.be/ATfuFU70Pjo?t=00h23m15s)



[apps three one my apps i revved them up](https://youtu.be/ATfuFU70Pjo?t=00h23m19s)



[to the latest preview package not a big](https://youtu.be/ATfuFU70Pjo?t=00h23m22s)



[deal](https://youtu.be/ATfuFU70Pjo?t=00h23m24s)



[show me the sam'l we picked up the](https://youtu.be/ATfuFU70Pjo?t=00h23m25s)



[latest one as well just to fix an OL](https://youtu.be/ATfuFU70Pjo?t=00h23m26s)



[reference exception that we caused or](https://youtu.be/ATfuFU70Pjo?t=00h23m29s)



[that I caused got all of those done so](https://youtu.be/ATfuFU70Pjo?t=00h23m31s)



[let's see moving library to net core](https://youtu.be/ATfuFU70Pjo?t=00h23m35s)



[three ones since it is the LTS version](https://youtu.be/ATfuFU70Pjo?t=00h23m41s)



[LTS long term support for people who are](https://youtu.be/ATfuFU70Pjo?t=00h23m49s)



[unfamiliar with it create pull request](https://youtu.be/ATfuFU70Pjo?t=00h23m52s)



[and then I think what we're going to do](https://youtu.be/ATfuFU70Pjo?t=00h23m55s)



[is I'm gonna go close that one out there](https://youtu.be/ATfuFU70Pjo?t=00h23m57s)



[was another request where somebody tried](https://youtu.be/ATfuFU70Pjo?t=00h24m00s)



[to do the same sort of Rev but it didn't](https://youtu.be/ATfuFU70Pjo?t=00h24m01s)



[include all the packet changes 16:54](https://youtu.be/ATfuFU70Pjo?t=00h24m04s)



[let's see I think we're just gonna leave](https://youtu.be/ATfuFU70Pjo?t=00h24m09s)



[a comment fixed by 1654 close up comment](https://youtu.be/ATfuFU70Pjo?t=00h24m13s)



[okay yeah cuz this just had the global](https://youtu.be/ATfuFU70Pjo?t=00h24m21s)



[JSON and I wanted to make sure we picked](https://youtu.be/ATfuFU70Pjo?t=00h24m26s)



[up all the other changes on top of it](https://youtu.be/ATfuFU70Pjo?t=00h24m28s)



[okay so we'll let that guy fix emerge](https://youtu.be/ATfuFU70Pjo?t=00h24m30s)



[then I was trying to decide what to work](https://youtu.be/ATfuFU70Pjo?t=00h24m34s)



[on tonight I was somewhat tempted to](https://youtu.be/ATfuFU70Pjo?t=00h24m36s)



[take a stab at this filter chips alright](https://youtu.be/ATfuFU70Pjo?t=00h24m38s)



[because these look this looks pretty](https://youtu.be/ATfuFU70Pjo?t=00h24m40s)



[cool to me and I'm in the mood to do](https://youtu.be/ATfuFU70Pjo?t=00h24m42s)



[something creative and fun yeah let's do](https://youtu.be/ATfuFU70Pjo?t=00h24m46s)



[something creative have fun so let's go](https://youtu.be/ATfuFU70Pjo?t=00h24m50s)



[and pick this up so 1456](https://youtu.be/ATfuFU70Pjo?t=00h24m53s)



[alright so first of all this is the](https://youtu.be/ATfuFU70Pjo?t=00h24m57s)



[behavior to do that we're looking to get](https://youtu.be/ATfuFU70Pjo?t=00h25m01s)



[right so there's that usage](https://youtu.be/ATfuFU70Pjo?t=00h25m05s)



[come on load there you go all right okay](https://youtu.be/ATfuFU70Pjo?t=00h25m09s)



[so I don't know if people can see the](https://youtu.be/ATfuFU70Pjo?t=00h25m15s)



[animation very well or not but on here](https://youtu.be/ATfuFU70Pjo?t=00h25m17s)



[when you go through and do this it kind](https://youtu.be/ATfuFU70Pjo?t=00h25m19s)



[of has this nice slide out slide in](https://youtu.be/ATfuFU70Pjo?t=00h25m21s)



[animation and I think that's all that](https://youtu.be/ATfuFU70Pjo?t=00h25m23s)



[this is missing here right work in](https://youtu.be/ATfuFU70Pjo?t=00h25m26s)



[progress only supports light mode at the](https://youtu.be/ATfuFU70Pjo?t=00h25m28s)



[moment no fancy animations okay so we](https://youtu.be/ATfuFU70Pjo?t=00h25m30s)



[are going to we're gonna take a crack at](https://youtu.be/ATfuFU70Pjo?t=00h25m35s)



[this and because I already reviewed it a](https://youtu.be/ATfuFU70Pjo?t=00h25m40s)



[while back so we are on pull requests](https://youtu.be/ATfuFU70Pjo?t=00h25m44s)



[1456 let's go down here and grab pull](https://youtu.be/ATfuFU70Pjo?t=00h25m46s)



[requests 1456](https://youtu.be/ATfuFU70Pjo?t=00h25m50s)



[so yes go ahead and add that and yeah](https://youtu.be/ATfuFU70Pjo?t=00h25m53s)



[yeah I understand your universe just got](https://youtu.be/ATfuFU70Pjo?t=00h26m01s)



[changed out from under you ignore we're](https://youtu.be/ATfuFU70Pjo?t=00h26m03s)



[actually gonna shut you down for a](https://youtu.be/ATfuFU70Pjo?t=00h26m07s)



[minute Visual Studio because you're just](https://youtu.be/ATfuFU70Pjo?t=00h26m08s)



[gonna get in the way you're just gonna](https://youtu.be/ATfuFU70Pjo?t=00h26m09s)



[be in my way Visual Studio go away](https://youtu.be/ATfuFU70Pjo?t=00h26m13s)



[I think step one is I want to rebase](https://youtu.be/ATfuFU70Pjo?t=00h26m16s)



[this guy up on to master because he's a](https://youtu.be/ATfuFU70Pjo?t=00h26m18s)



[little far back and then we'll go from](https://youtu.be/ATfuFU70Pjo?t=00h26m21s)



[there cuz I I don't believe there should](https://youtu.be/ATfuFU70Pjo?t=00h26m24s)



[be any conflicts it should be a simple](https://youtu.be/ATfuFU70Pjo?t=00h26m26s)



[rebase great and then I don't have to](https://youtu.be/ATfuFU70Pjo?t=00h26m28s)



[deal with Visual Studio getting confused](https://youtu.be/ATfuFU70Pjo?t=00h26m32s)



[about different SDKs I kind of want this](https://youtu.be/ATfuFU70Pjo?t=00h26m33s)



[other one to hurry up and build and](https://youtu.be/ATfuFU70Pjo?t=00h26m35s)



[finish so I can rebase it on top of that](https://youtu.be/ATfuFU70Pjo?t=00h26m38s)



[- Oh build failed](https://youtu.be/ATfuFU70Pjo?t=00h26m40s)



[why did my build fail that's not a good](https://youtu.be/ATfuFU70Pjo?t=00h26m45s)



[sign did we not fix everything](https://youtu.be/ATfuFU70Pjo?t=00h26m49s)



[failed with exit code well that's not a](https://youtu.be/ATfuFU70Pjo?t=00h26m56s)



[good sign](https://youtu.be/ATfuFU70Pjo?t=00h27m02s)



[let's see did you do](https://youtu.be/ATfuFU70Pjo?t=00h27m04s)



[failed with eggs of code one build](https://youtu.be/ATfuFU70Pjo?t=00h27m08s)



[failed what was the actual failure as](https://youtu.be/ATfuFU70Pjo?t=00h27m13s)



[the question though right](https://youtu.be/ATfuFU70Pjo?t=00h27m17s)



[the.net restore failed which is kind of](https://youtu.be/ATfuFU70Pjo?t=00h27m21s)



[hysterical given that it doesn't really](https://youtu.be/ATfuFU70Pjo?t=00h27m26s)



[need to do much okay let's just go and](https://youtu.be/ATfuFU70Pjo?t=00h27m28s)



[pop open the well before we get too](https://youtu.be/ATfuFU70Pjo?t=00h27m33s)



[carried away there's that there's that](https://youtu.be/ATfuFU70Pjo?t=00h27m36s)



[we're happy let's jump back over to our](https://youtu.be/ATfuFU70Pjo?t=00h27m38s)



[branch up up up up let's go and take a](https://youtu.be/ATfuFU70Pjo?t=00h27m40s)



[quick look I'm guessing there's](https://youtu.be/ATfuFU70Pjo?t=00h27m46s)



[something in the pipeline that zamel](https://youtu.be/ATfuFU70Pjo?t=00h27m47s)



[that need to be updated too because](https://youtu.be/ATfuFU70Pjo?t=00h27m49s)



[that's the only thing that we haven't](https://youtu.be/ATfuFU70Pjo?t=00h27m51s)



[tested yet okay claps you solution items](https://youtu.be/ATfuFU70Pjo?t=00h27m52s)



[something pipelines there we go close so](https://youtu.be/ATfuFU70Pjo?t=00h27m58s)



[this guy blew up on the.net restore call](https://youtu.be/ATfuFU70Pjo?t=00h28m06s)



[the PowerShell tasks should have really](https://youtu.be/ATfuFU70Pjo?t=00h28m11s)



[taken care of almost everything because](https://youtu.be/ATfuFU70Pjo?t=00h28m14s)



[I'm unfortunately mixing packet new get](https://youtu.be/ATfuFU70Pjo?t=00h28m18s)



[in here just because the I didn't see](https://youtu.be/ATfuFU70Pjo?t=00h28m20s)



[the point of adding the complexity of](https://youtu.be/ATfuFU70Pjo?t=00h28m24s)



[the unit test projects](https://youtu.be/ATfuFU70Pjo?t=00h28m26s)



[so I really want to know what the](https://youtu.be/ATfuFU70Pjo?t=00h28m30s)



[failure is 7 Aires there the target does](https://youtu.be/ATfuFU70Pjo?t=00h28m33s)



[not support targeting either target net](https://youtu.be/ATfuFU70Pjo?t=00h28m39s)



[core 3 or lower oh so we just need Oh](https://youtu.be/ATfuFU70Pjo?t=00h28m42s)



[are using version of.net core right](https://youtu.be/ATfuFU70Pjo?t=00h28m45s)



[that'd be a problem](https://youtu.be/ATfuFU70Pjo?t=00h28m48s)



[yeah perhaps that may be yeah that](https://youtu.be/ATfuFU70Pjo?t=00h28m57s)



[probably will do it](https://youtu.be/ATfuFU70Pjo?t=00h29m01s)



[so stage C fixing pipeline version](https://youtu.be/ATfuFU70Pjo?t=00h29m03s)



[of.net cor great commit push let's try](https://youtu.be/ATfuFU70Pjo?t=00h29m11s)



[this one more time and this will go back](https://youtu.be/ATfuFU70Pjo?t=00h29m16s)



[to here back to here successfully should](https://youtu.be/ATfuFU70Pjo?t=00h29m22s)



[trigger a new build real quick](https://youtu.be/ATfuFU70Pjo?t=00h29m30s)



[at least it](https://youtu.be/ATfuFU70Pjo?t=00h29m38s)



[come on come on show me the checks I](https://youtu.be/ATfuFU70Pjo?t=00h29m41s)



[know you want to do checks](https://youtu.be/ATfuFU70Pjo?t=00h29m43s)



[there we go I just babysit this one for](https://youtu.be/ATfuFU70Pjo?t=00h29m53s)



[a minute because I really do want to get](https://youtu.be/ATfuFU70Pjo?t=00h29m56s)



[this merged in so that we can do the or](https://youtu.be/ATfuFU70Pjo?t=00h29m57s)



[other work on top of this let's see here](https://youtu.be/ATfuFU70Pjo?t=00h30m00s)



[did you go out as your pipelines let's](https://youtu.be/ATfuFU70Pjo?t=00h30m05s)



[go go look at it out here so it is worth](https://youtu.be/ATfuFU70Pjo?t=00h30m08s)



[noting I'm not actually signed in right](https://youtu.be/ATfuFU70Pjo?t=00h30m11s)



[now so all of this information that you](https://youtu.be/ATfuFU70Pjo?t=00h30m13s)



[see me looking at here everyone should](https://youtu.be/ATfuFU70Pjo?t=00h30m15s)



[have this access to all of this so this](https://youtu.be/ATfuFU70Pjo?t=00h30m17s)



[is the the wonderfulness that is as your](https://youtu.be/ATfuFU70Pjo?t=00h30m21s)



[DevOps and pipelines for those people](https://youtu.be/ATfuFU70Pjo?t=00h30m24s)



[who care there is gonna be a blog post](https://youtu.be/ATfuFU70Pjo?t=00h30m27s)



[coming out so let's see let's see](https://youtu.be/ATfuFU70Pjo?t=00h30m29s)



[blog there right and I might check it](https://youtu.be/ATfuFU70Pjo?t=00h30m31s)



[real quick I don't think it's published](https://youtu.be/ATfuFU70Pjo?t=00h30m38s)



[yet but there is one cause that's going](https://youtu.be/ATfuFU70Pjo?t=00h30m39s)



[to be coming out yeah it's it's not up](https://youtu.be/ATfuFU70Pjo?t=00h30m45s)



[here yet there will be one coming out](https://youtu.be/ATfuFU70Pjo?t=00h30m48s)



[that is all around](https://youtu.be/ATfuFU70Pjo?t=00h30m55s)



[nougat packages and how I like to go out](https://youtu.be/ATfuFU70Pjo?t=00h30m57s)



[and publish them so that's that will be](https://youtu.be/ATfuFU70Pjo?t=00h31m00s)



[hopefully coming soon it's been done for](https://youtu.be/ATfuFU70Pjo?t=00h31m03s)



[like a week or so but they were trying](https://youtu.be/ATfuFU70Pjo?t=00h31m05s)



[to time it with like the release of some](https://youtu.be/ATfuFU70Pjo?t=00h31m08s)



[newsletter something so coming soon so](https://youtu.be/ATfuFU70Pjo?t=00h31m10s)



[if you're interested in how I like to](https://youtu.be/ATfuFU70Pjo?t=00h31m15s)



[set up my projects with DevOps for](https://youtu.be/ATfuFU70Pjo?t=00h31m16s)



[releases it's a I think it's probably a](https://youtu.be/ATfuFU70Pjo?t=00h31m19s)



[useful thing it is worth noting if all](https://youtu.be/ATfuFU70Pjo?t=00h31m23s)



[you want for your project is a simple do](https://youtu.be/ATfuFU70Pjo?t=00h31m25s)



[my build release it to nougat github](https://youtu.be/ATfuFU70Pjo?t=00h31m27s)



[actions are probably a lot simpler where](https://youtu.be/ATfuFU70Pjo?t=00h31m30s)



[github actions come up short is when you](https://youtu.be/ATfuFU70Pjo?t=00h31m34s)



[want to get a little complex with your](https://youtu.be/ATfuFU70Pjo?t=00h31m37s)



[release pipelines github actions are](https://youtu.be/ATfuFU70Pjo?t=00h31m39s)



[great for really quick and simple things](https://youtu.be/ATfuFU70Pjo?t=00h31m41s)



[but for like this project where I want](https://youtu.be/ATfuFU70Pjo?t=00h31m44s)



[to nightly release or I want approvals](https://youtu.be/ATfuFU70Pjo?t=00h31m47s)



[and those types of things to flow](https://youtu.be/ATfuFU70Pjo?t=00h31m49s)



[through this this that's all built into](https://youtu.be/ATfuFU70Pjo?t=00h31m50s)



[the azure DevOps pipelines and github](https://youtu.be/ATfuFU70Pjo?t=00h31m54s)



[actions really aren't designed to do](https://youtu.be/ATfuFU70Pjo?t=00h31m55s)



[that kind of exterior dependency they're](https://youtu.be/ATfuFU70Pjo?t=00h31m58s)



[really designed to to work with stuff](https://youtu.be/ATfuFU70Pjo?t=00h32m01s)



[from your github repo and](https://youtu.be/ATfuFU70Pjo?t=00h32m04s)



[act on the repo right so if you want](https://youtu.be/ATfuFU70Pjo?t=00h32m06s)



[like outside approvals and permissions](https://youtu.be/ATfuFU70Pjo?t=00h32m09s)



[and all that kind of extra jazz that](https://youtu.be/ATfuFU70Pjo?t=00h32m11s)



[goes along with it its github actions](https://youtu.be/ATfuFU70Pjo?t=00h32m12s)



[are probably the wrong tool for the job](https://youtu.be/ATfuFU70Pjo?t=00h32m15s)



[you could probably beat it into](https://youtu.be/ATfuFU70Pjo?t=00h32m17s)



[submission but use the right tool it'll](https://youtu.be/ATfuFU70Pjo?t=00h32m19s)



[save you some trouble okay](https://youtu.be/ATfuFU70Pjo?t=00h32m22s)



[come on Kevin let's go let's go sorry I](https://youtu.be/ATfuFU70Pjo?t=00h32m25s)



[just chickens messages here](https://youtu.be/ATfuFU70Pjo?t=00h32m29s)



[okay come on run all our unit tests the](https://youtu.be/ATfuFU70Pjo?t=00h32m55s)



[other thing I'd like to do and it's](https://youtu.be/ATfuFU70Pjo?t=00h32m58s)



[probably very boring is go through and](https://youtu.be/ATfuFU70Pjo?t=00h33m00s)



[address all of these warnings](https://youtu.be/ATfuFU70Pjo?t=00h33m02s)



[I would love to terminal warnings as](https://youtu.be/ATfuFU70Pjo?t=00h33m04s)



[heirs in the project it can be a little](https://youtu.be/ATfuFU70Pjo?t=00h33m06s)



[obnoxious but it also having that level](https://youtu.be/ATfuFU70Pjo?t=00h33m09s)



[of static analysis because typically](https://youtu.be/ATfuFU70Pjo?t=00h33m12s)



[when you have a warning it's something](https://youtu.be/ATfuFU70Pjo?t=00h33m14s)



[that's probably a bug or it's probably](https://youtu.be/ATfuFU70Pjo?t=00h33m16s)



[going to become a bug soon right it's at](https://youtu.be/ATfuFU70Pjo?t=00h33m18s)



[minimum you're probably doing something](https://youtu.be/ATfuFU70Pjo?t=00h33m21s)



[in a weird way you should probably](https://youtu.be/ATfuFU70Pjo?t=00h33m23s)



[switch or it's something that's probably](https://youtu.be/ATfuFU70Pjo?t=00h33m25s)



[wrong and you really need to look at it](https://youtu.be/ATfuFU70Pjo?t=00h33m28s)



[closer the other thing is turning on](https://youtu.be/ATfuFU70Pjo?t=00h33m29s)



[null ability so the C sharp 8 knowable](https://youtu.be/ATfuFU70Pjo?t=00h33m32s)



[reference types I kind of want to get](https://youtu.be/ATfuFU70Pjo?t=00h33m35s)



[the library decorated with those I've](https://youtu.be/ATfuFU70Pjo?t=00h33m38s)



[updated a couple libraries now with it](https://youtu.be/ATfuFU70Pjo?t=00h33m40s)



[and it's I think it's worthwhile](https://youtu.be/ATfuFU70Pjo?t=00h33m42s)



[pursuing last week we did a little bit](https://youtu.be/ATfuFU70Pjo?t=00h33m44s)



[of stuff with Auto mocker or maybe that](https://youtu.be/ATfuFU70Pjo?t=00h33m47s)



[was two weeks ago might have been two](https://youtu.be/ATfuFU70Pjo?t=00h33m51s)



[weeks ago and updating it and playing](https://youtu.be/ATfuFU70Pjo?t=00h33m54s)



[around with some of those features and](https://youtu.be/ATfuFU70Pjo?t=00h33m57s)



[unfortunately ended with me getting](https://youtu.be/ATfuFU70Pjo?t=00h33m59s)



[stuck and realizing what I wanted to do](https://youtu.be/ATfuFU70Pjo?t=00h34m01s)



[was impossible but that is okay](https://youtu.be/ATfuFU70Pjo?t=00h34m02s)



[rendezvous ops what are you doing you're](https://youtu.be/ATfuFU70Pjo?t=00h34m06s)



[still thinking](https://youtu.be/ATfuFU70Pjo?t=00h34m09s)



[it's probably running the other one it's](https://youtu.be/ATfuFU70Pjo?t=00h34m12s)



[worth noting these tools sometimes don't](https://youtu.be/ATfuFU70Pjo?t=00h34m14s)



[spew their output in a stream mode they](https://youtu.be/ATfuFU70Pjo?t=00h34m16s)



[sometimes spew it all at once like](https://youtu.be/ATfuFU70Pjo?t=00h34m19s)



[you'll notice we sat here waiting](https://youtu.be/ATfuFU70Pjo?t=00h34m22s)



[because it was running 188 tests so it's](https://youtu.be/ATfuFU70Pjo?t=00h34m24s)



[nice now that this library actually has](https://youtu.be/ATfuFU70Pjo?t=00h34m28s)



[some some unit tests right the test](https://youtu.be/ATfuFU70Pjo?t=00h34m30s)



[covers numbers are still pitiful because](https://youtu.be/ATfuFU70Pjo?t=00h34m34s)



[this is a theme like theming library but](https://youtu.be/ATfuFU70Pjo?t=00h34m35s)



[ultimately it's it's nice to have some](https://youtu.be/ATfuFU70Pjo?t=00h34m39s)



[assurances when I make changes that I](https://youtu.be/ATfuFU70Pjo?t=00h34m42s)



[haven't broken everything okay since](https://youtu.be/ATfuFU70Pjo?t=00h34m43s)



[this is about to merge let's go over](https://youtu.be/ATfuFU70Pjo?t=00h34m51s)



[here and fix the wiki real quick so](https://youtu.be/ATfuFU70Pjo?t=00h34m53s)



[let's see building from source to edit](https://youtu.be/ATfuFU70Pjo?t=00h34m56s)



[so net core 3-1 SDK will be clear - Dead](https://youtu.be/ATfuFU70Pjo?t=00h34m59s)



[- Dead it did save page all right I do](https://youtu.be/ATfuFU70Pjo?t=00h35m09s)



[try to keep the wiki page up-to-date and](https://youtu.be/ATfuFU70Pjo?t=00h35m13s)



[I did put this footer on here for people](https://youtu.be/ATfuFU70Pjo?t=00h35m16s)



[if you see a mistake or want to](https://youtu.be/ATfuFU70Pjo?t=00h35m18s)



[contribute to this wiki everyone has](https://youtu.be/ATfuFU70Pjo?t=00h35m20s)



[write access so please feel free to make](https://youtu.be/ATfuFU70Pjo?t=00h35m21s)



[contributions I peruse the wiki itself](https://youtu.be/ATfuFU70Pjo?t=00h35m24s)



[is another git repo right so if there is](https://youtu.be/ATfuFU70Pjo?t=00h35m27s)



[a problem or some issue I can always](https://youtu.be/ATfuFU70Pjo?t=00h35m30s)



[revert if this privilege gets abused but](https://youtu.be/ATfuFU70Pjo?t=00h35m32s)



[so far I haven't had that problem and](https://youtu.be/ATfuFU70Pjo?t=00h35m36s)



[it's been really nice having everyone be](https://youtu.be/ATfuFU70Pjo?t=00h35m37s)



[able to contribute to it be curious to](https://youtu.be/ATfuFU70Pjo?t=00h35m40s)



[note about this restriction 16-3 I think](https://youtu.be/ATfuFU70Pjo?t=00h35m43s)



[that's still accurate](https://youtu.be/ATfuFU70Pjo?t=00h35m50s)



[because I know we're out at 16 for right](https://youtu.be/ATfuFU70Pjo?t=00h35m51s)



[now let's see because what is it 16 for](https://youtu.be/ATfuFU70Pjo?t=00h35m54s)



[4 is what I'm on but I don't think 16 4](https://youtu.be/ATfuFU70Pjo?t=00h35m57s)



[is actually required I'm pretty sure you](https://youtu.be/ATfuFU70Pjo?t=00h36m01s)



[can still compile this stuff on 16 3 so](https://youtu.be/ATfuFU70Pjo?t=00h36m02s)



[unless somebody comes and points out to](https://youtu.be/ATfuFU70Pjo?t=00h36m05s)



[me that that's not true I'm going to be](https://youtu.be/ATfuFU70Pjo?t=00h36m07s)



[assuming that that is true and it is](https://youtu.be/ATfuFU70Pjo?t=00h36m10s)



[worth noting like people ask all the](https://youtu.be/ATfuFU70Pjo?t=00h36m13s)



[time about well why does compiling from](https://youtu.be/ATfuFU70Pjo?t=00h36m14s)



[source requires so much more and the](https://youtu.be/ATfuFU70Pjo?t=00h36m16s)



[simple fact is because we're we're](https://youtu.be/ATfuFU70Pjo?t=00h36m19s)



[trying to multi target our new get](https://youtu.be/ATfuFU70Pjo?t=00h36m20s)



[package so if you want to contribute](https://youtu.be/ATfuFU70Pjo?t=00h36m22s)



[from source great if you don't](https://youtu.be/ATfuFU70Pjo?t=00h36m23s)



[install all of this stuff and you just](https://youtu.be/ATfuFU70Pjo?t=00h36m26s)



[want to work on a feature or a bug it is](https://youtu.be/ATfuFU70Pjo?t=00h36m27s)



[okay to go into these projects and just](https://youtu.be/ATfuFU70Pjo?t=00h36m30s)



[turn off whichever target framework you](https://youtu.be/ATfuFU70Pjo?t=00h36m33s)



[don't have installed and do the work](https://youtu.be/ATfuFU70Pjo?t=00h36m35s)



[that way just don't add those CS prods](https://youtu.be/ATfuFU70Pjo?t=00h36m37s)



[to your pull request right I'm I'm very](https://youtu.be/ATfuFU70Pjo?t=00h36m40s)



[okay with that just leave a comment](https://youtu.be/ATfuFU70Pjo?t=00h36m43s)



[saying that you didn't test it under the](https://youtu.be/ATfuFU70Pjo?t=00h36m45s)



[other framework and I'm I'm still happy](https://youtu.be/ATfuFU70Pjo?t=00h36m46s)



[to review other people's changes look at](https://youtu.be/ATfuFU70Pjo?t=00h36m48s)



[that there we go](https://youtu.be/ATfuFU70Pjo?t=00h36m51s)



[mervich squash merge boom let's just](https://youtu.be/ATfuFU70Pjo?t=00h36m52s)



[make sure that this this goes away this](https://youtu.be/ATfuFU70Pjo?t=00h36m58s)



[goes away this is now in this is now in](https://youtu.be/ATfuFU70Pjo?t=00h37m00s)



[fixed that's closed hey didn't I just](https://youtu.be/ATfuFU70Pjo?t=00h37m07s)



[close it come on github update there we](https://youtu.be/ATfuFU70Pjo?t=00h37m12s)



[go okay so we can delete that branch](https://youtu.be/ATfuFU70Pjo?t=00h37m17s)



[don't need that anymore don't need that](https://youtu.be/ATfuFU70Pjo?t=00h37m20s)



[anymore we'll go in here while we're](https://youtu.be/ATfuFU70Pjo?t=00h37m22s)



[having fun with stuff let's just squash](https://youtu.be/ATfuFU70Pjo?t=00h37m25s)



[merge this guy boom boom more stuff](https://youtu.be/ATfuFU70Pjo?t=00h37m27s)



[merged and actually I'm gonna put this](https://youtu.be/ATfuFU70Pjo?t=00h37m31s)



[guy in the milestone so I can keep track](https://youtu.be/ATfuFU70Pjo?t=00h37m34s)



[of which ones went in great okay so now](https://youtu.be/ATfuFU70Pjo?t=00h37m36s)



[we're gonna go do this let's see these](https://youtu.be/ATfuFU70Pjo?t=00h37m40s)



[so now our master branch has advanced a](https://youtu.be/ATfuFU70Pjo?t=00h37m43s)



[couple pull requests hang on expected to](https://youtu.be/ATfuFU70Pjo?t=00h37m46s)



[see expected to see that other one](https://youtu.be/ATfuFU70Pjo?t=00h37m53s)



[closed what did I do update as your](https://youtu.be/ATfuFU70Pjo?t=00h37m56s)



[icons didn't I just merge you you're all](https://youtu.be/ATfuFU70Pjo?t=00h38m01s)



[set](https://youtu.be/ATfuFU70Pjo?t=00h38m08s)



[there it goes my fetch was just slow](https://youtu.be/ATfuFU70Pjo?t=00h38m10s)



[okay](https://youtu.be/ATfuFU70Pjo?t=00h38m13s)



[great so we're gonna pull down master to](https://youtu.be/ATfuFU70Pjo?t=00h38m14s)



[get the latest and then we are going to](https://youtu.be/ATfuFU70Pjo?t=00h38m18s)



[switch back over to our filter chips](https://youtu.be/ATfuFU70Pjo?t=00h38m21s)



[branch and rebase it onto master great](https://youtu.be/ATfuFU70Pjo?t=00h38m23s)



[okay so now we're working from latest](https://youtu.be/ATfuFU70Pjo?t=00h38m29s)



[and greatest stuff everyone's happy](https://youtu.be/ATfuFU70Pjo?t=00h38m31s)



[delete branch don't need that no more](https://youtu.be/ATfuFU70Pjo?t=00h38m34s)



[boom boom boom ok so back to where we](https://youtu.be/ATfuFU70Pjo?t=00h38m37s)



[were going so what we're looking to do](https://youtu.be/ATfuFU70Pjo?t=00h38m40s)



[here is I think do the animations first](https://youtu.be/ATfuFU70Pjo?t=00h38m42s)



[that sounds like the fun part I think it](https://youtu.be/ATfuFU70Pjo?t=00h38m45s)



[sounds like the fun part so let's take a](https://youtu.be/ATfuFU70Pjo?t=00h38m48s)



[look at where Magnus left off here so to](https://youtu.be/ATfuFU70Pjo?t=00h38m51s)



[do so we're inside of chips zamel and](https://youtu.be/ATfuFU70Pjo?t=00h38m57s)



[it's based on the list box item and I](https://youtu.be/ATfuFU70Pjo?t=00h39m02s)



[think let's see](https://youtu.be/ATfuFU70Pjo?t=00h39m07s)



[he's got a transition to normal mouse](https://youtu.be/ATfuFU70Pjo?t=00h39m10s)



[over selection States to selected right](https://youtu.be/ATfuFU70Pjo?t=00h39m15s)



[like there's already there's already](https://youtu.be/ATfuFU70Pjo?t=00h39m18s)



[this the stuff that we need yeah so](https://youtu.be/ATfuFU70Pjo?t=00h39m21s)



[basically we want to go into list box](https://youtu.be/ATfuFU70Pjo?t=00h39m28s)



[items amyl and start there let's first](https://youtu.be/ATfuFU70Pjo?t=00h39m31s)



[just make sure that we can run the demo](https://youtu.be/ATfuFU70Pjo?t=00h39m35s)



[with it set my startup project please](https://youtu.be/ATfuFU70Pjo?t=00h39m37s)



[and let's fire you up](https://youtu.be/ATfuFU70Pjo?t=00h39m41s)



[I assume everything in it is in and](https://youtu.be/ATfuFU70Pjo?t=00h39m45s)



[working just fine but would just like to](https://youtu.be/ATfuFU70Pjo?t=00h39m48s)



[confirm that before we get off to the](https://youtu.be/ATfuFU70Pjo?t=00h39m51s)



[races and then I realized that I broke](https://youtu.be/ATfuFU70Pjo?t=00h39m54s)



[something so I'm gonna come down here](https://youtu.be/ATfuFU70Pjo?t=00h39m56s)



[and just start while it's while it's](https://youtu.be/ATfuFU70Pjo?t=00h39m58s)



[recompiling since we changed everything](https://youtu.be/ATfuFU70Pjo?t=00h40m01s)



[out on it okay so something about the](https://youtu.be/ATfuFU70Pjo?t=00h40m02s)



[chips and we can do this which is great](https://youtu.be/ATfuFU70Pjo?t=00h40m05s)



[yeah I think all I want is a nice little](https://youtu.be/ATfuFU70Pjo?t=00h40m09s)



[animation of this case sliding in and](https://youtu.be/ATfuFU70Pjo?t=00h40m12s)



[out very similar to what we've got here](https://youtu.be/ATfuFU70Pjo?t=00h40m14s)



[so just trying to look at this real](https://youtu.be/ATfuFU70Pjo?t=00h40m16s)



[quick so it's really just slide in slide](https://youtu.be/ATfuFU70Pjo?t=00h40m19s)



[out yeah](https://youtu.be/ATfuFU70Pjo?t=00h40m21s)



[so it almost seems like I'm just gonna](https://youtu.be/ATfuFU70Pjo?t=00h40m29s)



[animate the width of whatever that](https://youtu.be/ATfuFU70Pjo?t=00h40m31s)



[little thing is right there and make it](https://youtu.be/ATfuFU70Pjo?t=00h40m33s)



[go right because there was a request out](https://youtu.be/ATfuFU70Pjo?t=00h40m38s)



[on the git er chat as well to to](https://youtu.be/ATfuFU70Pjo?t=00h40m40s)



[effectively make these these things](https://youtu.be/ATfuFU70Pjo?t=00h40m43s)



[collapse and expand so we'll see we](https://youtu.be/ATfuFU70Pjo?t=00h40m45s)



[might get carried away](https://youtu.be/ATfuFU70Pjo?t=00h40m50s)



[okay so close you we need the listbox](https://youtu.be/ATfuFU70Pjo?t=00h40m51s)



[stuff so themes do little bigger a](https://youtu.be/ATfuFU70Pjo?t=00h40m54s)



[little bigger let me see what I'm doing](https://youtu.be/ATfuFU70Pjo?t=00h40m59s)



[this box just a to toggle this box item](https://youtu.be/ATfuFU70Pjo?t=00h41m01s)



[that wasn't it](https://youtu.be/ATfuFU70Pjo?t=00h41m07s)



[this box item less box item shit'll just](https://youtu.be/ATfuFU70Pjo?t=00h41m10s)



[cards this box item it's gonna bother me](https://youtu.be/ATfuFU70Pjo?t=00h41m14s)



[seeing this the trailing whitespace in](https://youtu.be/ATfuFU70Pjo?t=00h41m20s)



[the zamel hate seeing only whitespace](https://youtu.be/ATfuFU70Pjo?t=00h41m22s)



[boom clean those up okay a little more](https://youtu.be/ATfuFU70Pjo?t=00h41m25s)



[white space a little more whites yes](https://youtu.be/ATfuFU70Pjo?t=00h41m29s)



[just gotta clean that up](https://youtu.be/ATfuFU70Pjo?t=00h41m31s)



[chip list box item here we are okay so](https://youtu.be/ATfuFU70Pjo?t=00h41m32s)



[let's figure out what we're looking at](https://youtu.be/ATfuFU70Pjo?t=00h41m36s)



[so it's on Visual Studio is a little](https://youtu.be/ATfuFU70Pjo?t=00h41m38s)



[unhappy about the fact that it wants you](https://youtu.be/ATfuFU70Pjo?t=00h41m42s)



[to specify a column getter for non first](https://youtu.be/ATfuFU70Pjo?t=00h41m45s)



[items which is not it's not a horrible](https://youtu.be/ATfuFU70Pjo?t=00h41m48s)



[idea](https://youtu.be/ATfuFU70Pjo?t=00h41m50s)



[it just it's redundant because this will](https://youtu.be/ATfuFU70Pjo?t=00h41m52s)



[default to zero but it likes you to be](https://youtu.be/ATfuFU70Pjo?t=00h41m56s)



[explicit if you're doing it because it](https://youtu.be/ATfuFU70Pjo?t=00h41m58s)



[is a potential for failure right like if](https://youtu.be/ATfuFU70Pjo?t=00h42m03s)



[you don't do it it then is a bit](https://youtu.be/ATfuFU70Pjo?t=00h42m07s)



[ambiguous about did you mean to leave it](https://youtu.be/ATfuFU70Pjo?t=00h42m10s)



[off and have it default to zero or did](https://youtu.be/ATfuFU70Pjo?t=00h42m13s)



[you mess something up right so it's one](https://youtu.be/ATfuFU70Pjo?t=00h42m15s)



[of those it just wants you to be](https://youtu.be/ATfuFU70Pjo?t=00h42m18s)



[explicit okay so](https://youtu.be/ATfuFU70Pjo?t=00h42m20s)



[doo-doo-doo-doo doo-doo-doo-doo all that](https://youtu.be/ATfuFU70Pjo?t=00h42m23s)



[looks good all that looks good all that](https://youtu.be/ATfuFU70Pjo?t=00h42m26s)



[looks good okay so ultimately we got is](https://youtu.be/ATfuFU70Pjo?t=00h42m28s)



[this guy right here this trigger](https://youtu.be/ATfuFU70Pjo?t=00h42m31s)



[property is selected so when](https://youtu.be/ATfuFU70Pjo?t=00h42m33s)



[this thing becomes selected the icon](https://youtu.be/ATfuFU70Pjo?t=00h42m36s)



[control becomes visible and the text](https://youtu.be/ATfuFU70Pjo?t=00h42m39s)



[block margin slides to the side right so](https://youtu.be/ATfuFU70Pjo?t=00h42m42s)



[this adds weight I'm confused left top](https://youtu.be/ATfuFU70Pjo?t=00h42m49s)



[right the right margin weight](https://youtu.be/ATfuFU70Pjo?t=00h42m54s)



[okay I need to look at what this text](https://youtu.be/ATfuFU70Pjo?t=00h43m05s)



[block element is right so there's our](https://youtu.be/ATfuFU70Pjo?t=00h43m07s)



[pack icon we can self close them I need](https://youtu.be/ATfuFU70Pjo?t=00h43m11s)



[to be fancy with it where is our text](https://youtu.be/ATfuFU70Pjo?t=00h43m14s)



[block more importantly what thing in](https://youtu.be/ATfuFU70Pjo?t=00h43m17s)



[here Oh kind of want to rename this](https://youtu.be/ATfuFU70Pjo?t=00h43m20s)



[rather than text block I looks like](https://youtu.be/ATfuFU70Pjo?t=00h43m25s)



[that's the only how about](https://youtu.be/ATfuFU70Pjo?t=00h43m29s)



[this box item I feel like there's a](https://youtu.be/ATfuFU70Pjo?t=00h43m37s)



[template part for this isn't there](https://youtu.be/ATfuFU70Pjo?t=00h43m39s)



[let's look III feel like there's a](https://youtu.be/ATfuFU70Pjo?t=00h43m42s)



[template part for this or it's supposed](https://youtu.be/ATfuFU70Pjo?t=00h43m44s)



[to be called like so by template part in](https://youtu.be/ATfuFU70Pjo?t=00h43m47s)



[WPF there's this idea of controls can](https://youtu.be/ATfuFU70Pjo?t=00h43m50s)



[declare which pieces of their template](https://youtu.be/ATfuFU70Pjo?t=00h43m54s)



[are required versus optional usually the](https://youtu.be/ATfuFU70Pjo?t=00h43m57s)



[required template options will be called](https://youtu.be/ATfuFU70Pjo?t=00h44m00s)



[something like all caps part underscore](https://youtu.be/ATfuFU70Pjo?t=00h44m02s)



[is typically how they are they lead with](https://youtu.be/ATfuFU70Pjo?t=00h44m05s)



[default property content property so](https://youtu.be/ATfuFU70Pjo?t=00h44m09s)



[there isn't there isn't really something](https://youtu.be/ATfuFU70Pjo?t=00h44m11s)



[there but I think I still want to rename](https://youtu.be/ATfuFU70Pjo?t=00h44m14s)



[this guy from light text block content](https://youtu.be/ATfuFU70Pjo?t=00h44m16s)



[I'm a little surprised at this trigger](https://youtu.be/ATfuFU70Pjo?t=00h44m21s)



[right like that that surprises me that](https://youtu.be/ATfuFU70Pjo?t=00h44m23s)



[we add margin to the right what it's](https://youtu.be/ATfuFU70Pjo?t=00h44m28s)



[selected oh I see it's not add Jamar](https://youtu.be/ATfuFU70Pjo?t=00h44m32s)



[Junt to the right it's taking it off all](https://youtu.be/ATfuFU70Pjo?t=00h44m37s)



[right so this this guy is 12 0 12 0 when](https://youtu.be/ATfuFU70Pjo?t=00h44m40s)



[it's selected it then goes through and](https://youtu.be/ATfuFU70Pjo?t=00h44m45s)



[drops this because I'm guessing the icon](https://youtu.be/ATfuFU70Pjo?t=00h44m47s)



[control must have a little bit yeah](https://youtu.be/ATfuFU70Pjo?t=00h44m50s)



[so that's what's happening okay so let's](https://youtu.be/ATfuFU70Pjo?t=00h44m53s)



[start by moving some of these things off](https://youtu.be/ATfuFU70Pjo?t=00h44m58s)



[to visual States](https://youtu.be/ATfuFU70Pjo?t=00h45m00s)



[all right so selected visual States](https://youtu.be/ATfuFU70Pjo?t=00h45m04s)



[storyboards so we're gonna do visit](https://youtu.be/ATfuFU70Pjo?t=00h45m07s)



[object animation using keyframes and I](https://youtu.be/ATfuFU70Pjo?t=00h45m11s)



[kind of want to look at I thought we had](https://youtu.be/ATfuFU70Pjo?t=00h45m17s)



[other ones in here no more white space](https://youtu.be/ATfuFU70Pjo?t=00h45m19s)



[to clean up or white space to clean up](https://youtu.be/ATfuFU70Pjo?t=00h45m23s)



[always leave the code cleaner than you](https://youtu.be/ATfuFU70Pjo?t=00h45m26s)



[found it double animation double](https://youtu.be/ATfuFU70Pjo?t=00h45m29s)



[animation you know we don't actually](https://youtu.be/ATfuFU70Pjo?t=00h45m31s)



[need to hide it I'm realizing a zero](https://youtu.be/ATfuFU70Pjo?t=00h45m33s)



[width will work just as well as turning](https://youtu.be/ATfuFU70Pjo?t=00h45m38s)



[it invisible it's not like it's a tab](https://youtu.be/ATfuFU70Pjo?t=00h45m40s)



[stop at all I'm wondering if that's a](https://youtu.be/ATfuFU70Pjo?t=00h45m43s)



[cleaner approach to this](https://youtu.be/ATfuFU70Pjo?t=00h45m45s)



[wondering if that is a cleaner approach](https://youtu.be/ATfuFU70Pjo?t=00h45m54s)



[because the other drawback is this](https://youtu.be/ATfuFU70Pjo?t=00h46m00s)



[margin right because this margin exists](https://youtu.be/ATfuFU70Pjo?t=00h46m02s)



[here if all I do is zero out the width](https://youtu.be/ATfuFU70Pjo?t=00h46m05s)



[this guy is not going to be quite the](https://youtu.be/ATfuFU70Pjo?t=00h46m09s)



[same let's let's start with that though](https://youtu.be/ATfuFU70Pjo?t=00h46m12s)



[right let's let's let's lead into that](https://youtu.be/ATfuFU70Pjo?t=00h46m15s)



[so I see how that goes Bob uh maybe we](https://youtu.be/ATfuFU70Pjo?t=00h46m18s)



[should do it as a scale transform](https://youtu.be/ATfuFU70Pjo?t=00h46m27s)



[instead](https://youtu.be/ATfuFU70Pjo?t=00h46m29s)



[yeah I kind of like that let's do it as](https://youtu.be/ATfuFU70Pjo?t=00h46m36s)



[a scale transformer](https://youtu.be/ATfuFU70Pjo?t=00h46m38s)



[okay so we're gonna go through expand](https://youtu.be/ATfuFU70Pjo?t=00h46m39s)



[expand empty tag and now normally when](https://youtu.be/ATfuFU70Pjo?t=00h46m43s)



[you do animations you want to do render](https://youtu.be/ATfuFU70Pjo?t=00h46m47s)



[transforms the problem with render](https://youtu.be/ATfuFU70Pjo?t=00h46m49s)



[transforms is that they only affect the](https://youtu.be/ATfuFU70Pjo?t=00h46m51s)



[rendered size not the layout size and in](https://youtu.be/ATfuFU70Pjo?t=00h46m54s)



[this case we actually care about the](https://youtu.be/ATfuFU70Pjo?t=00h46m56s)



[layout size right because we are](https://youtu.be/ATfuFU70Pjo?t=00h46m58s)



[effectively changing how much space](https://youtu.be/ATfuFU70Pjo?t=00h47m00s)



[we're gonna need so let's see pack icon](https://youtu.be/ATfuFU70Pjo?t=00h47m02s)



[we're gonna do a layout transform](https://youtu.be/ATfuFU70Pjo?t=00h47m07s)



[instead and how about a scale transform](https://youtu.be/ATfuFU70Pjo?t=00h47m10s)



[give it a name about icon scale](https://youtu.be/ATfuFU70Pjo?t=00h47m14s)



[transform](https://youtu.be/ATfuFU70Pjo?t=00h47m24s)



[I think these just default to one by by](https://youtu.be/ATfuFU70Pjo?t=00h47m27s)



[default right so I think if we do this](https://youtu.be/ATfuFU70Pjo?t=00h47m31s)



[we don't do this right I kind of want to](https://youtu.be/ATfuFU70Pjo?t=00h47m35s)



[make this icon kind configurable I have](https://youtu.be/ATfuFU70Pjo?t=00h47m42s)



[a sinking suspicion the moment I](https://youtu.be/ATfuFU70Pjo?t=00h47m49s)



[released this somebody's going to want](https://youtu.be/ATfuFU70Pjo?t=00h47m51s)



[to change it](https://youtu.be/ATfuFU70Pjo?t=00h47m52s)



[okay so let's lead with that for the](https://youtu.be/ATfuFU70Pjo?t=00h47m53s)



[moment so we're going to I think I just](https://youtu.be/ATfuFU70Pjo?t=00h47m56s)



[want to comment out this trigger for the](https://youtu.be/ATfuFU70Pjo?t=00h48m01s)



[moment okay](https://youtu.be/ATfuFU70Pjo?t=00h48m02s)



[so on selected we are going to change](https://youtu.be/ATfuFU70Pjo?t=00h48m04s)



[the scale icon transform and it's not](https://youtu.be/ATfuFU70Pjo?t=00h48m07s)



[and it's less about this right because](https://youtu.be/ATfuFU70Pjo?t=00h48m12s)



[we are going to say boom scale light](https://youtu.be/ATfuFU70Pjo?t=00h48m15s)



[this is going to be scale X on selected](https://youtu.be/ATfuFU70Pjo?t=00h48m20s)



[we're going to go to one we're going to](https://youtu.be/ATfuFU70Pjo?t=00h48m24s)



[do the opposite on visual state](https://youtu.be/ATfuFU70Pjo?t=00h48m27s)



[yeah unselected I think we do the](https://youtu.be/ATfuFU70Pjo?t=00h48m40s)



[opposite on selected unfocused I think](https://youtu.be/ATfuFU70Pjo?t=00h48m43s)



[this is probably the same case because I](https://youtu.be/ATfuFU70Pjo?t=00h48m53s)



[think we're blocking focus on it so go](https://youtu.be/ATfuFU70Pjo?t=00h48m54s)



[to zero on that right and that should](https://youtu.be/ATfuFU70Pjo?t=00h48m58s)



[scale that in and out and then let's do](https://youtu.be/ATfuFU70Pjo?t=00h49m02s)



[up here](https://youtu.be/ATfuFU70Pjo?t=00h49m06s)



[so I don't know if it's worth I don't I](https://youtu.be/ATfuFU70Pjo?t=00h49m10s)



[don't know why this is using key frames](https://youtu.be/ATfuFU70Pjo?t=00h49m18s)



[this doesn't seem like it needs it](https://youtu.be/ATfuFU70Pjo?t=00h49m21s)



[so go to one their duration its take](https://youtu.be/ATfuFU70Pjo?t=00h49m24s)



[duration off for the moment well we](https://youtu.be/ATfuFU70Pjo?t=00h49m28s)



[should probably be explicit right so](https://youtu.be/ATfuFU70Pjo?t=00h49m34s)



[zero colon zero colon zero point three I](https://youtu.be/ATfuFU70Pjo?t=00h49m36s)



[think is fairly common yeah](https://youtu.be/ATfuFU70Pjo?t=00h49m40s)



[yeah I think that's that's usually about](https://youtu.be/ATfuFU70Pjo?t=00h49m49s)



[what most things are so we're gonna go](https://youtu.be/ATfuFU70Pjo?t=00h49m52s)



[there so on when we if from any state to](https://youtu.be/ATfuFU70Pjo?t=00h49m54s)



[selected we go there from any state to](https://youtu.be/ATfuFU70Pjo?t=00h49m58s)



[unselected we do all right](https://youtu.be/ATfuFU70Pjo?t=00h50m03s)



[zero and from selected to unselected](https://youtu.be/ATfuFU70Pjo?t=00h50m09s)



[we're also going to go to zero and I](https://youtu.be/ATfuFU70Pjo?t=00h50m12s)



[think we're gonna just clean up these](https://youtu.be/ATfuFU70Pjo?t=00h50m19s)



[other durations so that they properly](https://youtu.be/ATfuFU70Pjo?t=00h50m21s)



[switch right select a background border](https://youtu.be/ATfuFU70Pjo?t=00h50m24s)



[I'm not sure I need to change the](https://youtu.be/ATfuFU70Pjo?t=00h50m30s)



[durations I think having those be at](https://youtu.be/ATfuFU70Pjo?t=00h50m33s)



[zero is probably acceptable to do to do](https://youtu.be/ATfuFU70Pjo?t=00h50m34s)



[to do visual states selected I think](https://youtu.be/ATfuFU70Pjo?t=00h50m38s)



[that's probably close save](https://youtu.be/ATfuFU70Pjo?t=00h50m43s)



[yeah it's going to be surprised I was](https://youtu.be/ATfuFU70Pjo?t=00h50m50s)



[hoping that edit and continue would pick](https://youtu.be/ATfuFU70Pjo?t=00h50m53s)



[it up but that was probably a lot for it](https://youtu.be/ATfuFU70Pjo?t=00h50m54s)



[to dig Rock yeah something like this](https://youtu.be/ATfuFU70Pjo?t=00h50m56s)



[because if we can get these nice](https://youtu.be/ATfuFU70Pjo?t=00h51m03s)



[animations in place I think this will](https://youtu.be/ATfuFU70Pjo?t=00h51m04s)



[set it up set it up nicely](https://youtu.be/ATfuFU70Pjo?t=00h51m05s)



[let's eat chips](https://youtu.be/ATfuFU70Pjo?t=00h51m10s)



[so something's wrong there](https://youtu.be/ATfuFU70Pjo?t=00h51m22s)



[all right](https://youtu.be/ATfuFU70Pjo?t=00h51m27s)



[so step one we noticed our initial state](https://youtu.be/ATfuFU70Pjo?t=00h51m34s)



[was wrong so that's just bad so let's](https://youtu.be/ATfuFU70Pjo?t=00h51m38s)



[see scale X is gonna be zero right](https://youtu.be/ATfuFU70Pjo?t=00h51m42s)



[not a shock there so that was that was](https://youtu.be/ATfuFU70Pjo?t=00h51m46s)



[the first bug we had now something about](https://youtu.be/ATfuFU70Pjo?t=00h51m50s)



[this guy's state right so I'm wondering](https://youtu.be/ATfuFU70Pjo?t=00h51m52s)



[if it's unselected that needs to](https://youtu.be/ATfuFU70Pjo?t=00h51m58s)



[actually be thought out a little more](https://youtu.be/ATfuFU70Pjo?t=00h52m00s)



[expand empty tag because I'm thinking](https://youtu.be/ATfuFU70Pjo?t=00h52m02s)



[both of these states need to effectively](https://youtu.be/ATfuFU70Pjo?t=00h52m05s)



[do the exact same thing](https://youtu.be/ATfuFU70Pjo?t=00h52m08s)



[let's just check I want to see what this](https://youtu.be/ATfuFU70Pjo?t=00h52m18s)



[thing does](https://youtu.be/ATfuFU70Pjo?t=00h52m21s)



[yeah so the background yeah so select it](https://youtu.be/ATfuFU70Pjo?t=00h52m23s)



[and unselect it has no bearing on the or](https://youtu.be/ATfuFU70Pjo?t=00h52m30s)



[I should say the whether it's unselected](https://youtu.be/ATfuFU70Pjo?t=00h52m33s)



[or not has no bearing](https://youtu.be/ATfuFU70Pjo?t=00h52m36s)



[so unselected in this case based upon](https://youtu.be/ATfuFU70Pjo?t=00h52m38s)



[the list box selection state right so I](https://youtu.be/ATfuFU70Pjo?t=00h52m40s)



[think we do that let's see this goes to](https://youtu.be/ATfuFU70Pjo?t=00h52m44s)



[00:52:58,660 --> 00:53:03,059](https://youtu.be/ATfuFU70Pjo?t=00h52m51s)

selected on selected goes to zero


[yeah and let's read launch I think we're](https://youtu.be/ATfuFU70Pjo?t=00h53m10s)



[gonna have to play with those margins a](https://youtu.be/ATfuFU70Pjo?t=00h53m11s)



[little bit because I think that was](https://youtu.be/ATfuFU70Pjo?t=00h53m13s)



[exactly why he had that trigger around](https://youtu.be/ATfuFU70Pjo?t=00h53m16s)



[the margin but I think we can fix it in](https://youtu.be/ATfuFU70Pjo?t=00h53m18s)



[here kind of hoping we can find a](https://youtu.be/ATfuFU70Pjo?t=00h53m20s)



[reasonable setup with the icons margin](https://youtu.be/ATfuFU70Pjo?t=00h53m24s)



[so that we don't have to worry about it](https://youtu.be/ATfuFU70Pjo?t=00h53m26s)



[because I'm thinking if we just use a](https://youtu.be/ATfuFU70Pjo?t=00h53m29s)



[scale transform on the content and I'll](https://youtu.be/ATfuFU70Pjo?t=00h53m31s)



[probably fix it](https://youtu.be/ATfuFU70Pjo?t=00h53m34s)



[well we fixed part of it](https://youtu.be/ATfuFU70Pjo?t=00h53m41s)



[so something's off](https://youtu.be/ATfuFU70Pjo?t=00h53m58s)



[okay so let's focus just on the scale](https://youtu.be/ATfuFU70Pjo?t=00h54m04s)



[transform right we're going to selected](https://youtu.be/ATfuFU70Pjo?t=00h54m07s)



[the scale should be one we're going to](https://youtu.be/ATfuFU70Pjo?t=00h54m12s)



[select it unfocused ah this is selected](https://youtu.be/ATfuFU70Pjo?t=00h54m16s)



[this should also be a one we're going to](https://youtu.be/ATfuFU70Pjo?t=00h54m19s)



[unselected this should be a zero](https://youtu.be/ATfuFU70Pjo?t=00h54m24s)



[yeah I'm wondering if](https://youtu.be/ATfuFU70Pjo?t=00h54m32s)



[I'm wondering if this really matters](https://youtu.be/ATfuFU70Pjo?t=00h54m40s)



[right thinking this should probably be](https://youtu.be/ATfuFU70Pjo?t=00h54m42s)



[like this which I'm pretty sure yeah I'm](https://youtu.be/ATfuFU70Pjo?t=00h54m45s)



[fairly confident you can do this all](https://youtu.be/ATfuFU70Pjo?t=00h54m50s)



[right so we can do that do that](https://youtu.be/ATfuFU70Pjo?t=00h54m57s)



[I think what we need](https://youtu.be/ATfuFU70Pjo?t=00h55m09s)



[I think part of the issue here is we've](https://youtu.be/ATfuFU70Pjo?t=00h55m12s)



[got a disjoint](https://youtu.be/ATfuFU70Pjo?t=00h55m14s)



[and that needs to look like that](https://youtu.be/ATfuFU70Pjo?t=00h55m22s)



[and we could probably do a little](https://youtu.be/ATfuFU70Pjo?t=00h55m30s)



[refactoring and pull some of these](https://youtu.be/ATfuFU70Pjo?t=00h55m32s)



[storyboards around](https://youtu.be/ATfuFU70Pjo?t=00h55m34s)



[not sure if I actually want to yet or](https://youtu.be/ATfuFU70Pjo?t=00h55m42s)



[not we'll see how this goes](https://youtu.be/ATfuFU70Pjo?t=00h55m44s)



[okay let's see if that works so](https://youtu.be/ATfuFU70Pjo?t=00h55m49s)



[unselected zero unselected zero oh I'm](https://youtu.be/ATfuFU70Pjo?t=00h55m51s)



[finding more bugs](https://youtu.be/ATfuFU70Pjo?t=00h55m58s)



[selected this goes to a one right](https://youtu.be/ATfuFU70Pjo?t=00h56m08s)



[we've got a missing visual state down](https://youtu.be/ATfuFU70Pjo?t=00h56m18s)



[here right selected unfocused to do it](https://youtu.be/ATfuFU70Pjo?t=00h56m20s)



[see here so selected boom okay let's try](https://youtu.be/ATfuFU70Pjo?t=00h56m28s)



[that let's try that I think that'll get](https://youtu.be/ATfuFU70Pjo?t=00h56m35s)



[us a lot closer](https://youtu.be/ATfuFU70Pjo?t=00h56m41s)



[and then we'll have some nice fancy](https://youtu.be/ATfuFU70Pjo?t=00h56m46s)



[animated chips yay](https://youtu.be/ATfuFU70Pjo?t=00h56m48s)



[Hey look at that](https://youtu.be/ATfuFU70Pjo?t=00h56m55s)



[I'm not sure because you can see the](https://youtu.be/ATfuFU70Pjo?t=00h57m01s)



[icon get bigger and smaller in there](https://youtu.be/ATfuFU70Pjo?t=00h57m03s)



[right I might even propose speeding it](https://youtu.be/ATfuFU70Pjo?t=00h57m05s)



[up a little but let's let's look yeah](https://youtu.be/ATfuFU70Pjo?t=00h57m07s)



[because there's actually looks to slide](https://youtu.be/ATfuFU70Pjo?t=00h57m13s)



[off and slide in rather than expand](https://youtu.be/ATfuFU70Pjo?t=00h57m15s)



[that's all because we're doing this](https://youtu.be/ATfuFU70Pjo?t=00h57m24s)



[so scale transform there's a I did it](https://youtu.be/ATfuFU70Pjo?t=00h57m30s)



[rather than a scale transform there is a](https://youtu.be/ATfuFU70Pjo?t=00h57m39s)



[translate transform which probably works](https://youtu.be/ATfuFU70Pjo?t=00h57m45s)



[right I wonder does this works better](https://youtu.be/ATfuFU70Pjo?t=00h57m54s)



[not sure if it does though right because](https://youtu.be/ATfuFU70Pjo?t=00h58m05s)



[it would push it to the side but I](https://youtu.be/ATfuFU70Pjo?t=00h58m09s)



[needed to push behind](https://youtu.be/ATfuFU70Pjo?t=00h58m11s)



[because the width is gonna have the same](https://youtu.be/ATfuFU70Pjo?t=00h58m18s)



[problem as the scale transform if I just](https://youtu.be/ATfuFU70Pjo?t=00h58m20s)



[push it over well let's try it to](https://youtu.be/ATfuFU70Pjo?t=00h58m22s)



[transform X key so let's let's do this](https://youtu.be/ATfuFU70Pjo?t=00h58m31s)



[so transform group so that we can have](https://youtu.be/ATfuFU70Pjo?t=00h58m41s)



[more than one in here](https://youtu.be/ATfuFU70Pjo?t=00h58m46s)



[well right icon translate transform](https://youtu.be/ATfuFU70Pjo?t=00h58m47s)



[what are you squawking about no you need](https://youtu.be/ATfuFU70Pjo?t=00h59m03s)



[a name not a key and I can't spell the](https://youtu.be/ATfuFU70Pjo?t=00h59m07s)



[word translate okay Oh fine stop](https://youtu.be/ATfuFU70Pjo?t=00h59m10s)



[debugging right so ultimately we want to](https://youtu.be/ATfuFU70Pjo?t=00h59m15s)



[toggle between the width and not the](https://youtu.be/ATfuFU70Pjo?t=00h59m19s)



[width so I am sort of curious if if we](https://youtu.be/ATfuFU70Pjo?t=00h59m24s)



[go through and do this and just do X](https://youtu.be/ATfuFU70Pjo?t=00h59m32s)



[gets -16 and ultimately we're going to](https://youtu.be/ATfuFU70Pjo?t=00h59m38s)



[go from minus 16 to 0 right what is](https://youtu.be/ATfuFU70Pjo?t=00h59m44s)



[translate](https://youtu.be/ATfuFU70Pjo?t=00h59m54s)



[- 16 is the off see here turn you off](https://youtu.be/ATfuFU70Pjo?t=00h59m59s)



[for the moment and then we're going to](https://youtu.be/ATfuFU70Pjo?t=01h00m06s)



[just hunt all usages](https://youtu.be/ATfuFU70Pjo?t=01h00m08s)



[coppy well so this is going to be icon](https://youtu.be/ATfuFU70Pjo?t=01h00m18s)



[translate transform X this is selected](https://youtu.be/ATfuFU70Pjo?t=01h00m25s)



[so it's going to go and this is going to](https://youtu.be/ATfuFU70Pjo?t=01h00m30s)



[look weird right because we're gonna go](https://youtu.be/ATfuFU70Pjo?t=01h00m31s)



[from negative 16 to 0 effectively](https://youtu.be/ATfuFU70Pjo?t=01h00m33s)



[bringing it across because 0 will be sit](https://youtu.be/ATfuFU70Pjo?t=01h00m35s)



[where you start ok so put that there it](https://youtu.be/ATfuFU70Pjo?t=01h00m39s)



[goes there it goes like that](https://youtu.be/ATfuFU70Pjo?t=01h00m44s)



[let's see unselected so this is going to](https://youtu.be/ATfuFU70Pjo?t=01h00m50s)



[take us to the negative 16 case to do](https://youtu.be/ATfuFU70Pjo?t=01h00m52s)



[and will ultimately end up we'll fix the](https://youtu.be/ATfuFU70Pjo?t=01h01m00s)



[hard-coded values I just kind of want to](https://youtu.be/ATfuFU70Pjo?t=01h01m04s)



[see how this is gonna look first before](https://youtu.be/ATfuFU70Pjo?t=01h01m06s)



[I go through and refactor it will clean](https://youtu.be/ATfuFU70Pjo?t=01h01m07s)



[it up in a minute](https://youtu.be/ATfuFU70Pjo?t=01h01m13s)



[so we'll do that okay so back into the](https://youtu.be/ATfuFU70Pjo?t=01h01m14s)



[selected case which takes us to 0 which](https://youtu.be/ATfuFU70Pjo?t=01h01m18s)



[is great](https://youtu.be/ATfuFU70Pjo?t=01h01m21s)



[duration needs to go to 0 because now](https://youtu.be/ATfuFU70Pjo?t=01h01m23s)



[we're in the visual states not the state](https://youtu.be/ATfuFU70Pjo?t=01h01m26s)



[transitions so these are how how the](https://youtu.be/ATfuFU70Pjo?t=01h01m29s)



[objects going to be held when it reaches](https://youtu.be/ATfuFU70Pjo?t=01h01m32s)



[the state nope no that](https://youtu.be/ATfuFU70Pjo?t=01h01m34s)



[and that looks good there this is now](https://youtu.be/ATfuFU70Pjo?t=01h01m45s)



[gonna switch to the -16 case comment](https://youtu.be/ATfuFU70Pjo?t=01h01m49s)



[that out boom and this goes to the also](https://youtu.be/ATfuFU70Pjo?t=01h01m54s)



[the -16 case okay](https://youtu.be/ATfuFU70Pjo?t=01h02m05s)



[let's look at how that looks I'll see if](https://youtu.be/ATfuFU70Pjo?t=01h02m07s)



[that looks any better I think we also](https://youtu.be/ATfuFU70Pjo?t=01h02m11s)



[still have some background stuff to play](https://youtu.be/ATfuFU70Pjo?t=01h02m13s)



[with but](https://youtu.be/ATfuFU70Pjo?t=01h02m15s)



[no mount deuce Khan might have to go fix](https://youtu.be/ATfuFU70Pjo?t=01h02m21s)



[that okay let's see where was I chips](https://youtu.be/ATfuFU70Pjo?t=01h02m26s)



[chips chips that's not a good sign](https://youtu.be/ATfuFU70Pjo?t=01h02m30s)



[selected zero selected zero unselected](https://youtu.be/ATfuFU70Pjo?t=01h02m50s)



[back let's just do this as snoop real](https://youtu.be/ATfuFU70Pjo?t=01h02m54s)



[quick let's see a new let's pop this guy](https://youtu.be/ATfuFU70Pjo?t=01h02m59s)



[open and just take a quick look okay so](https://youtu.be/ATfuFU70Pjo?t=01h03m06s)



[when you fire up snoop first thing you](https://youtu.be/ATfuFU70Pjo?t=01h03m13s)



[do is you use the crosshairs to target](https://youtu.be/ATfuFU70Pjo?t=01h03m15s)



[the app that you want put your mouse](https://youtu.be/ATfuFU70Pjo?t=01h03m18s)



[over the into thing you're looking for](https://youtu.be/ATfuFU70Pjo?t=01h03m19s)



[and hold down control and shift it will](https://youtu.be/ATfuFU70Pjo?t=01h03m21s)



[zero in on your object so let's see icon](https://youtu.be/ATfuFU70Pjo?t=01h03m25s)



[control let's see it's going to be under](https://youtu.be/ATfuFU70Pjo?t=01h03m29s)



[the layout transform and then the layout](https://youtu.be/ATfuFU70Pjo?t=01h03m33s)



[transform group has a set of children](https://youtu.be/ATfuFU70Pjo?t=01h03m37s)



[should only have one item should be an](https://youtu.be/ATfuFU70Pjo?t=01h03m41s)



[index or property in here somewhere](https://youtu.be/ATfuFU70Pjo?t=01h03m46s)



[did it a transform collection or is it](https://youtu.be/ATfuFU70Pjo?t=01h03m49s)



[this that guy boom](https://youtu.be/ATfuFU70Pjo?t=01h04m01s)



[okay and then you should have an X](https://youtu.be/ATfuFU70Pjo?t=01h04m05s)



[property on here](https://youtu.be/ATfuFU70Pjo?t=01h04m08s)



[that is interesting](https://youtu.be/ATfuFU70Pjo?t=01h04m26s)



[that is interesting](https://youtu.be/ATfuFU70Pjo?t=01h04m32s)



[so I just want to watch this animation](https://youtu.be/ATfuFU70Pjo?t=01h04m42s)



[again](https://youtu.be/ATfuFU70Pjo?t=01h04m44s)



[pushes in slides in slides across](https://youtu.be/ATfuFU70Pjo?t=01h04m47s)



[maybe I'm approaching this from the](https://youtu.be/ATfuFU70Pjo?t=01h05m02s)



[wrong angle I'm wondering if perhaps the](https://youtu.be/ATfuFU70Pjo?t=01h05m04s)



[the because right now we've been going](https://youtu.be/ATfuFU70Pjo?t=01h05m08s)



[through an animating the check portion](https://youtu.be/ATfuFU70Pjo?t=01h05m11s)



[of this and I'm wondering if animating](https://youtu.be/ATfuFU70Pjo?t=01h05m14s)



[the content back over it might be](https://youtu.be/ATfuFU70Pjo?t=01h05m16s)



[cleaner the drawback being that right](https://youtu.be/ATfuFU70Pjo?t=01h05m17s)



[now this content is arbitrary and it](https://youtu.be/ATfuFU70Pjo?t=01h05m21s)



[doesn't necessarily mean that the](https://youtu.be/ATfuFU70Pjo?t=01h05m24s)



[background of it's going to be opaque](https://youtu.be/ATfuFU70Pjo?t=01h05m25s)



[which is an interesting problem to deal](https://youtu.be/ATfuFU70Pjo?t=01h05m28s)



[with](https://youtu.be/ATfuFU70Pjo?t=01h05m31s)



[right because I don't necessarily know](https://youtu.be/ATfuFU70Pjo?t=01h05m31s)



[the correct way to handle that I am](https://youtu.be/ATfuFU70Pjo?t=01h05m33s)



[interested in why this translate seems](https://youtu.be/ATfuFU70Pjo?t=01h05m36s)



[to have trouble with the X value going](https://youtu.be/ATfuFU70Pjo?t=01h05m40s)



[to negative right](https://youtu.be/ATfuFU70Pjo?t=01h05m43s)



[why would that cause a problem why would](https://youtu.be/ATfuFU70Pjo?t=01h05m49s)



[you effectively move that over oh you](https://youtu.be/ATfuFU70Pjo?t=01h05m58s)



[know what here's another thought here's](https://youtu.be/ATfuFU70Pjo?t=01h06m05s)



[a here's a thought right so I've got all](https://youtu.be/ATfuFU70Pjo?t=01h06m10s)



[of these things I believe isn't there a](https://youtu.be/ATfuFU70Pjo?t=01h06m14s)



[there is a thickness animation ahaha](https://youtu.be/ATfuFU70Pjo?t=01h06m17s)



[that gives me an idea that gives me an](https://youtu.be/ATfuFU70Pjo?t=01h06m25s)



[idea](https://youtu.be/ATfuFU70Pjo?t=01h06m30s)



[all right because part of what we were](https://youtu.be/ATfuFU70Pjo?t=01h06m31s)



[doing was manipulating these margins and](https://youtu.be/ATfuFU70Pjo?t=01h06m33s)



[both the margin and the property the](https://youtu.be/ATfuFU70Pjo?t=01h06m35s)



[margin and the padding properties are](https://youtu.be/ATfuFU70Pjo?t=01h06m39s)



[both thickness objects I'm wondering](https://youtu.be/ATfuFU70Pjo?t=01h06m41s)



[about just manipulating this](https://youtu.be/ATfuFU70Pjo?t=01h06m48s)



[because that would allow us to](https://youtu.be/ATfuFU70Pjo?t=01h06m54s)



[effectively tweet this right so clip the](https://youtu.be/ATfuFU70Pjo?t=01h06m55s)



[bounds true so I want to clip it and](https://youtu.be/ATfuFU70Pjo?t=01h07m05s)



[then what happens if I do so - 16000](https://youtu.be/ATfuFU70Pjo?t=01h07m09s)



[right what happens if we do that so](https://youtu.be/ATfuFU70Pjo?t=01h07m20s)



[let's go down here and I think what I'm](https://youtu.be/ATfuFU70Pjo?t=01h07m25s)



[going to do is I'm just going to comment](https://youtu.be/ATfuFU70Pjo?t=01h07m27s)



[out all of these animations for the](https://youtu.be/ATfuFU70Pjo?t=01h07m28s)



[moment because I think what I want to do](https://youtu.be/ATfuFU70Pjo?t=01h07m31s)



[is just manipulate the object directly](https://youtu.be/ATfuFU70Pjo?t=01h07m34s)



[in snoop and then verify my to-and-from](https://youtu.be/ATfuFU70Pjo?t=01h07m37s)



[and once I have that then I'll go and](https://youtu.be/ATfuFU70Pjo?t=01h07m41s)



[put the animation in to toggle it that](https://youtu.be/ATfuFU70Pjo?t=01h07m44s)



[way I'm not doing eight of these things](https://youtu.be/ATfuFU70Pjo?t=01h07m47s)



[every time I want to make a tweak so](https://youtu.be/ATfuFU70Pjo?t=01h07m49s)



[that'll probably speed this up a little](https://youtu.be/ATfuFU70Pjo?t=01h07m52s)



[bit](https://youtu.be/ATfuFU70Pjo?t=01h07m53s)



[control Casey okay so let's fire that up](https://youtu.be/ATfuFU70Pjo?t=01h07m57s)



[Snoop you can wait for a minute I need](https://youtu.be/ATfuFU70Pjo?t=01h08m01s)



[you but not right now let's see here](https://youtu.be/ATfuFU70Pjo?t=01h08m03s)



[yeah because what bothers me is this](https://youtu.be/ATfuFU70Pjo?t=01h08m14s)



[animation here is very much the check](https://youtu.be/ATfuFU70Pjo?t=01h08m16s)



[just slides behind right it goes right](https://youtu.be/ATfuFU70Pjo?t=01h08m19s)



[out of that content it doesn't shrink in](https://youtu.be/ATfuFU70Pjo?t=01h08m21s)



[size it just slides okay that's what](https://youtu.be/ATfuFU70Pjo?t=01h08m24s)



[we're shooting for that's our gold](https://youtu.be/ATfuFU70Pjo?t=01h08m27s)



[standard okay so that is well](https://youtu.be/ATfuFU70Pjo?t=01h08m29s)



[unfortunately correct ish but you did](https://youtu.be/ATfuFU70Pjo?t=01h08m37s)



[not get clipped so](https://youtu.be/ATfuFU70Pjo?t=01h08m44s)



[I think that and let's actually play](https://youtu.be/ATfuFU70Pjo?t=01h08m51s)



[with snoop snoop snoop snoop oh I've got](https://youtu.be/ATfuFU70Pjo?t=01h08m56s)



[multiple instances of snoop going that's](https://youtu.be/ATfuFU70Pjo?t=01h09m00s)



[what's that's what's confusing me okay](https://youtu.be/ATfuFU70Pjo?t=01h09m01s)



[so that guy let's dive into this thing](https://youtu.be/ATfuFU70Pjo?t=01h09m06s)



[and take a look at him so if we go up to](https://youtu.be/ATfuFU70Pjo?t=01h09m10s)



[hear something about clip two bounds](https://youtu.be/ATfuFU70Pjo?t=01h09m13s)



[clip it okay so that that will clip that](https://youtu.be/ATfuFU70Pjo?t=01h09m17s)



[guy and then if we come down to the icon](https://youtu.be/ATfuFU70Pjo?t=01h09m21s)



[control let's play with the margin](https://youtu.be/ATfuFU70Pjo?t=01h09m24s)



[alright so if this guy goes to zero](https://youtu.be/ATfuFU70Pjo?t=01h09m28s)



[that is intriguing and then more](https://youtu.be/ATfuFU70Pjo?t=01h09m38s)



[importantly this guy was being set to](https://youtu.be/ATfuFU70Pjo?t=01h09m42s)



[something too came to this right to give](https://youtu.be/ATfuFU70Pjo?t=01h09m44s)



[him some added added space around there](https://youtu.be/ATfuFU70Pjo?t=01h09m47s)



[I like that so you come off you come off](https://youtu.be/ATfuFU70Pjo?t=01h09m49s)



[a little confused as to why this thing](https://youtu.be/ATfuFU70Pjo?t=01h09m59s)



[appears to have gotten smaller but deal](https://youtu.be/ATfuFU70Pjo?t=01h10m03s)



[with that in a minute because his is it](https://youtu.be/ATfuFU70Pjo?t=01h10m06s)



[vertical vertical alignments Center push](https://youtu.be/ATfuFU70Pjo?t=01h10m09s)



[you down into the middle there right](https://youtu.be/ATfuFU70Pjo?t=01h10m17s)



[that looks better so let's change that](https://youtu.be/ATfuFU70Pjo?t=01h10m20s)



[up all right make sure you line up in](https://youtu.be/ATfuFU70Pjo?t=01h10m22s)



[the middle vertical alignment Center put](https://youtu.be/ATfuFU70Pjo?t=01h10m25s)



[you right where I want you and then okay](https://youtu.be/ATfuFU70Pjo?t=01h10m31s)



[so if that's gonna go there okay so then](https://youtu.be/ATfuFU70Pjo?t=01h10m36s)



[we get rid of all the layout transform](https://youtu.be/ATfuFU70Pjo?t=01h10m41s)



[stuff right that all goes away and I](https://youtu.be/ATfuFU70Pjo?t=01h10m43s)



[think what we're gonna do is we're gonna](https://youtu.be/ATfuFU70Pjo?t=01h10m49s)



[go to well let's let's see here right so](https://youtu.be/ATfuFU70Pjo?t=01h10m50s)



[this looks way too big](https://youtu.be/ATfuFU70Pjo?t=01h10m55s)



[all right I don't think we need the](https://youtu.be/ATfuFU70Pjo?t=01h10m57s)



[right margin there all right the fact](https://youtu.be/ATfuFU70Pjo?t=01h10m59s)



[I'm not even sure we need more than this](https://youtu.be/ATfuFU70Pjo?t=01h11m02s)



[is well we need a little on that side](https://youtu.be/ATfuFU70Pjo?t=01h11m05s)



[so back to my gold standard no it's](https://youtu.be/ATfuFU70Pjo?t=01h11m10s)



[still very much in said it's not much](https://youtu.be/ATfuFU70Pjo?t=01h11m14s)



[it's not much at all half it that's](https://youtu.be/ATfuFU70Pjo?t=01h11m16s)



[probably better content so what is](https://youtu.be/ATfuFU70Pjo?t=01h11m25s)



[separating you you've got a big margin](https://youtu.be/ATfuFU70Pjo?t=01h11m28s)



[there right specifically on the left](https://youtu.be/ATfuFU70Pjo?t=01h11m30s)



[that's being set to twelve needs some](https://youtu.be/ATfuFU70Pjo?t=01h11m32s)



[but not that much let's see here cuz the](https://youtu.be/ATfuFU70Pjo?t=01h11m37s)



[separation between these guys it's a](https://youtu.be/ATfuFU70Pjo?t=01h11m40s)



[little more than what's there it looks](https://youtu.be/ATfuFU70Pjo?t=01h11m43s)



[like so if that's four I'm gonna go with](https://youtu.be/ATfuFU70Pjo?t=01h11m45s)



[like a six it's probably closer alright](https://youtu.be/ATfuFU70Pjo?t=01h11m49s)



[and that slides in because then this](https://youtu.be/ATfuFU70Pjo?t=01h11m54s)



[guy's gonna go from four to negative 16](https://youtu.be/ATfuFU70Pjo?t=01h12m00s)



[about negative 12 leave that for on the](https://youtu.be/ATfuFU70Pjo?t=01h12m07s)



[edge](https://youtu.be/ATfuFU70Pjo?t=01h12m10s)



[no I think it needs to go to negative 16](https://youtu.be/ATfuFU70Pjo?t=01h12m17s)



[with a 4 on the right right](https://youtu.be/ATfuFU70Pjo?t=01h12m20s)



[something like that that way it can](https://youtu.be/ATfuFU70Pjo?t=01h12m25s)



[slide in](https://youtu.be/ATfuFU70Pjo?t=01h12m28s)



[and if I put the four here alright that](https://youtu.be/ATfuFU70Pjo?t=01h12m39s)



[means actually I don't even need the six](https://youtu.be/ATfuFU70Pjo?t=01h12m42s)



[here anymore right this goes away](https://youtu.be/ATfuFU70Pjo?t=01h12m45s)



[alright and so then this guy then if](https://youtu.be/ATfuFU70Pjo?t=01h12m47s)



[this guy's gonna have four on the right](https://youtu.be/ATfuFU70Pjo?t=01h12m51s)



[and go to -16 I then take that six and](https://youtu.be/ATfuFU70Pjo?t=01h12m53s)



[put it as ten it's just quite centered](https://youtu.be/ATfuFU70Pjo?t=01h12m59s)



[up in here which is bothering me a](https://youtu.be/ATfuFU70Pjo?t=01h13m06s)



[little bit probably because this is a](https://youtu.be/ATfuFU70Pjo?t=01h13m08s)



[twelve and I want it as a ten right](https://youtu.be/ATfuFU70Pjo?t=01h13m11s)



[because those go basically right to](https://youtu.be/ATfuFU70Pjo?t=01h13m14s)



[where that corner starts let's look yeah](https://youtu.be/ATfuFU70Pjo?t=01h13m15s)



[because the end of this R and dryer is](https://youtu.be/ATfuFU70Pjo?t=01h13m21s)



[pretty much underneath where this](https://youtu.be/ATfuFU70Pjo?t=01h13m23s)



[slightly taken inside of the circle I](https://youtu.be/ATfuFU70Pjo?t=01h13m25s)



[think I like that so that's gonna go ten](https://youtu.be/ATfuFU70Pjo?t=01h13m29s)



[okay well let's start plugging this in](https://youtu.be/ATfuFU70Pjo?t=01h13m34s)



[let's start plugging this guy in](https://youtu.be/ATfuFU70Pjo?t=01h13m36s)



[okay so thickness animation boom and am](https://youtu.be/ATfuFU70Pjo?t=01h13m38s)



[a bunch of stuff copy copy copy copy](https://youtu.be/ATfuFU70Pjo?t=01h13m47s)



[copy copy pasta so not that not that](https://youtu.be/ATfuFU70Pjo?t=01h13m50s)



[storyboard target name so we are going](https://youtu.be/ATfuFU70Pjo?t=01h13m55s)



[to go with the icon control boom that](https://youtu.be/ATfuFU70Pjo?t=01h13m58s)



[guy goes like that and I think what we](https://youtu.be/ATfuFU70Pjo?t=01h14m04s)



[said is this guy is going to become 0](https://youtu.be/ATfuFU70Pjo?t=01h14m05s)



[and a 10 all right so that goes like](https://youtu.be/ATfuFU70Pjo?t=01h14m08s)



[that](https://youtu.be/ATfuFU70Pjo?t=01h14m12s)



[target property margin and we want to go](https://youtu.be/ATfuFU70Pjo?t=01h14m14s)



[to not zero so this is selected so](https://youtu.be/ATfuFU70Pjo?t=01h14m20s)



[that's the case that we're in now right](https://youtu.be/ATfuFU70Pjo?t=01h14m25s)



[no unselected is 0 0 0 10 0 so I'm gonna](https://youtu.be/ATfuFU70Pjo?t=01h14m27s)



[just leave a comment for myself](https://youtu.be/ATfuFU70Pjo?t=01h14m34s)



[zero zero and zero so and I believe this](https://youtu.be/ATfuFU70Pjo?t=01h14m42s)



[guy then goes to nope not that one](https://youtu.be/ATfuFU70Pjo?t=01h14m48s)



[this guy here that's right so hidden is](https://youtu.be/ATfuFU70Pjo?t=01h14m55s)



[this](https://youtu.be/ATfuFU70Pjo?t=01h15m00s)



[right](https://youtu.be/ATfuFU70Pjo?t=01h15m03s)



[not enough so that's off then on goes to](https://youtu.be/ATfuFU70Pjo?t=01h15m07s)



[week four](https://youtu.be/ATfuFU70Pjo?t=01h15m14s)



[that feels a little much](https://youtu.be/ATfuFU70Pjo?t=01h15m20s)



[yeah that's a little much](https://youtu.be/ATfuFU70Pjo?t=01h15m26s)



[I think for for we're gonna do that at](https://youtu.be/ATfuFU70Pjo?t=01h15m36s)



[4-4 I think that's where we're going so](https://youtu.be/ATfuFU70Pjo?t=01h15m39s)



[this becomes fours across the board that](https://youtu.be/ATfuFU70Pjo?t=01h15m42s)



[goes like that so close that beast what](https://youtu.be/ATfuFU70Pjo?t=01h15m49s)



[did I do](https://youtu.be/ATfuFU70Pjo?t=01h15m56s)



[thickness just want that okay](https://youtu.be/ATfuFU70Pjo?t=01h15m58s)



[copy so we're gonna get rid of these](https://youtu.be/ATfuFU70Pjo?t=01h16m03s)



[don't think we need them anymore](https://youtu.be/ATfuFU70Pjo?t=01h16m06s)



[same same deal there all right selected](https://youtu.be/ATfuFU70Pjo?t=01h16m08s)



[selected then unselect it so this is now](https://youtu.be/ATfuFU70Pjo?t=01h16m16s)



[where we need our other value so this](https://youtu.be/ATfuFU70Pjo?t=01h16m19s)



[guy here that that down here do to do](https://youtu.be/ATfuFU70Pjo?t=01h16m21s)



[unselect it so you become that when you](https://youtu.be/ATfuFU70Pjo?t=01h16m29s)



[up that up](https://youtu.be/ATfuFU70Pjo?t=01h16m36s)



[okay that goes like that that goes down](https://youtu.be/ATfuFU70Pjo?t=01h16m41s)



[there both of these because for now](https://youtu.be/ATfuFU70Pjo?t=01h16m44s)



[we're calling both the old on I just](https://youtu.be/ATfuFU70Pjo?t=01h16m47s)



[jumped visual transition selected](https://youtu.be/ATfuFU70Pjo?t=01h16m53s)



[unfocused oh that's a bug](https://youtu.be/ATfuFU70Pjo?t=01h16m56s)



[you've got a duplicate uh haha watch](https://youtu.be/ATfuFU70Pjo?t=01h17m07s)



[that selected selected unfocused so](https://youtu.be/ATfuFU70Pjo?t=01h17m13s)



[selected unfocused I watched that](https://youtu.be/ATfuFU70Pjo?t=01h17m18s)



[selected selected unfocused unselected](https://youtu.be/ATfuFU70Pjo?t=01h17m23s)



[interesting I might check those visual](https://youtu.be/ATfuFU70Pjo?t=01h17m29s)



[states here in a minute but we're gonna](https://youtu.be/ATfuFU70Pjo?t=01h17m31s)



[carry out on our merry way so this is](https://youtu.be/ATfuFU70Pjo?t=01h17m33s)



[going to be selected so this is going to](https://youtu.be/ATfuFU70Pjo?t=01h17m35s)



[be the same thing here down here this is](https://youtu.be/ATfuFU70Pjo?t=01h17m38s)



[going to become a duration of zero](https://youtu.be/ATfuFU70Pjo?t=01h17m45s)



[though grab that I do the same thing](https://youtu.be/ATfuFU70Pjo?t=01h17m49s)



[here](https://youtu.be/ATfuFU70Pjo?t=01h17m55s)



[duration is zero this guy here is almost](https://youtu.be/ATfuFU70Pjo?t=01h17m57s)



[the same except for we want to change](https://youtu.be/ATfuFU70Pjo?t=01h18m02s)



[this out for our other values so multi](https://youtu.be/ATfuFU70Pjo?t=01h18m04s)



[ring clipboard that one please okay](https://youtu.be/ATfuFU70Pjo?t=01h18m07s)



[let's give that a shot](https://youtu.be/ATfuFU70Pjo?t=01h18m13s)



[see where that lands us](https://youtu.be/ATfuFU70Pjo?t=01h18m15s)



[Oh wrong window there we are okay so](https://youtu.be/ATfuFU70Pjo?t=01h18m30s)



[chips that looks much better look at](https://youtu.be/ATfuFU70Pjo?t=01h18m34s)



[that look at that almost like we planned](https://youtu.be/ATfuFU70Pjo?t=01h18m43s)



[it the background color is bothering me](https://youtu.be/ATfuFU70Pjo?t=01h18m47s)



[a little bit because it clearly means](https://youtu.be/ATfuFU70Pjo?t=01h18m54s)



[we've got somewhat pasty problem there](https://youtu.be/ATfuFU70Pjo?t=01h18m56s)



[but that looks much nicer I like it I](https://youtu.be/ATfuFU70Pjo?t=01h18m58s)



[like it it almost looks like it almost](https://youtu.be/ATfuFU70Pjo?t=01h19m02s)



[looks like the picture boom take it it](https://youtu.be/ATfuFU70Pjo?t=01h19m05s)



[seems like we might be a little big on](https://youtu.be/ATfuFU70Pjo?t=01h19m11s)



[the the margins top and bottom here but](https://youtu.be/ATfuFU70Pjo?t=01h19m13s)



[I'm a little less concerned about that](https://youtu.be/ATfuFU70Pjo?t=01h19m16s)



[at the moment okay so let's deal with](https://youtu.be/ATfuFU70Pjo?t=01h19m18s)



[that background color so we've got this](https://youtu.be/ATfuFU70Pjo?t=01h19m20s)



[weird case right so it's worth noting](https://youtu.be/ATfuFU70Pjo?t=01h19m22s)



[that we actually have one more state](https://youtu.be/ATfuFU70Pjo?t=01h19m27s)



[that their demos aren't going to have](https://youtu.be/ATfuFU70Pjo?t=01h19m29s)



[because we actually have a cursor and](https://youtu.be/ATfuFU70Pjo?t=01h19m32s)



[this is very touch heavy but unselected](https://youtu.be/ATfuFU70Pjo?t=01h19m35s)



[it definitely goes to its darker darker](https://youtu.be/ATfuFU70Pjo?t=01h19m38s)



[background and it holds that even when](https://youtu.be/ATfuFU70Pjo?t=01h19m41s)



[you move off I am wondering if we may](https://youtu.be/ATfuFU70Pjo?t=01h19m43s)



[want something additional from](https://youtu.be/ATfuFU70Pjo?t=01h19m46s)



[mouse-over maybe maybe maybe](https://youtu.be/ATfuFU70Pjo?t=01h19m47s)



[but let's let's go back down here so](https://youtu.be/ATfuFU70Pjo?t=01h19m57s)



[these storyboards here selected](https://youtu.be/ATfuFU70Pjo?t=01h19m59s)



[background border I don't know if I](https://youtu.be/ATfuFU70Pjo?t=01h20m02s)



[necessarily well they're already set I'm](https://youtu.be/ATfuFU70Pjo?t=01h20m11s)



[not gonna change it](https://youtu.be/ATfuFU70Pjo?t=01h20m13s)



[let's see common States normal](https://youtu.be/ATfuFU70Pjo?t=01h20m14s)



[mouse-over yeah so there's some stuff](https://youtu.be/ATfuFU70Pjo?t=01h20m17s)



[here and we might want to even consider](https://youtu.be/ATfuFU70Pjo?t=01h20m25s)



[the disabled state of these and what](https://youtu.be/ATfuFU70Pjo?t=01h20m27s)



[that should look like but let's come](https://youtu.be/ATfuFU70Pjo?t=01h20m29s)



[back to this so what do we got work on](https://youtu.be/ATfuFU70Pjo?t=01h20m32s)



[mouse-over border selected background](https://youtu.be/ATfuFU70Pjo?t=01h20m33s)



[border both of these start with their Oh](https://youtu.be/ATfuFU70Pjo?t=01h20m37s)



[pasty is zero and they basically have](https://youtu.be/ATfuFU70Pjo?t=01h20m41s)



[the same though I'd like to get these](https://youtu.be/ATfuFU70Pjo?t=01h20m45s)



[things to use theme brushes that's](https://youtu.be/ATfuFU70Pjo?t=01h20m46s)



[probably what Magnus meant when he said](https://youtu.be/ATfuFU70Pjo?t=01h20m48s)



[he didn't handle dark theme yet we'll](https://youtu.be/ATfuFU70Pjo?t=01h20m49s)



[get those into theme brushes in just a](https://youtu.be/ATfuFU70Pjo?t=01h20m53s)



[second so let's see here](https://youtu.be/ATfuFU70Pjo?t=01h20m54s)



[mouse-over selected something about the](https://youtu.be/ATfuFU70Pjo?t=01h20m59s)



[Z order seems backwards to me I almost](https://youtu.be/ATfuFU70Pjo?t=01h21m04s)



[want my mouse over to be on top of my](https://youtu.be/ATfuFU70Pjo?t=01h21m09s)



[selected right that way if my mouse](https://youtu.be/ATfuFU70Pjo?t=01h21m13s)



[hovers over regardless we'll come back](https://youtu.be/ATfuFU70Pjo?t=01h21m16s)



[to this this is what's being targeted](https://youtu.be/ATfuFU70Pjo?t=01h21m18s)



[right on all of these yeah selected item](https://youtu.be/ATfuFU70Pjo?t=01h21m19s)



[background border so unselected it goes](https://youtu.be/ATfuFU70Pjo?t=01h21m23s)



[backwards to zero](https://youtu.be/ATfuFU70Pjo?t=01h21m27s)



[alright selected oh wait hold on](https://youtu.be/ATfuFU70Pjo?t=01h21m28s)



[unselected it goes to 100 so this is](https://youtu.be/ATfuFU70Pjo?t=01h21m34s)



[probably the bug right here alright so](https://youtu.be/ATfuFU70Pjo?t=01h21m39s)



[unselected it should go to 0 selected](https://youtu.be/ATfuFU70Pjo?t=01h21m41s)



[unfocused it can go to one selected it](https://youtu.be/ATfuFU70Pjo?t=01h21m45s)



[goes to one unselected it goes to zero](https://youtu.be/ATfuFU70Pjo?t=01h21m47s)



[yeah I'm just not sure why we're mixing](https://youtu.be/ATfuFU70Pjo?t=01h21m52s)



[double animations and the keyframe ones](https://youtu.be/ATfuFU70Pjo?t=01h21m55s)



[so I'm gonna just bring these forward](https://youtu.be/ATfuFU70Pjo?t=01h21m59s)



[and we'll just we'll just simplify this](https://youtu.be/ATfuFU70Pjo?t=01h22m02s)



[up a little bit I don't I don't think we](https://youtu.be/ATfuFU70Pjo?t=01h22m05s)



[need this to be overly fancy alright so](https://youtu.be/ATfuFU70Pjo?t=01h22m06s)



[one](https://youtu.be/ATfuFU70Pjo?t=01h22m10s)



[duration I think I want this I think I](https://youtu.be/ATfuFU70Pjo?t=01h22m11s)



[want adoration on these like let's look](https://youtu.be/ATfuFU70Pjo?t=01h22m16s)



[let's look is there a duration on that](https://youtu.be/ATfuFU70Pjo?t=01h22m19s)



[background color change or is it just](https://youtu.be/ATfuFU70Pjo?t=01h22m21s)



[straight-up](https://youtu.be/ATfuFU70Pjo?t=01h22m23s)



[there's a very small duration let's](https://youtu.be/ATfuFU70Pjo?t=01h22m24s)



[let's put a duration on there right so](https://youtu.be/ATfuFU70Pjo?t=01h22m31s)



[that's gonna go like that this is gonna](https://youtu.be/ATfuFU70Pjo?t=01h22m34s)



[go like that and then this one becomes](https://youtu.be/ATfuFU70Pjo?t=01h22m40s)



[the exact same as this one so we just](https://youtu.be/ATfuFU70Pjo?t=01h22m43s)



[override that poof okay so these are our](https://youtu.be/ATfuFU70Pjo?t=01h22m47s)



[selection States yeah because I'm](https://youtu.be/ATfuFU70Pjo?t=01h22m53s)



[thinking that I probably probably want](https://youtu.be/ATfuFU70Pjo?t=01h22m57s)



[my mouse over effect to occur regardless](https://youtu.be/ATfuFU70Pjo?t=01h23m01s)



[maybe let's let's see here let's go](https://youtu.be/ATfuFU70Pjo?t=01h23m06s)



[chips](https://youtu.be/ATfuFU70Pjo?t=01h23m10s)



[yeah that's not bad I'm almost wondering](https://youtu.be/ATfuFU70Pjo?t=01h23m18s)



[if the timings a little slow feels a](https://youtu.be/ATfuFU70Pjo?t=01h23m20s)



[little bit slower than yeah that feels a](https://youtu.be/ATfuFU70Pjo?t=01h23m23s)



[lot quicker let's let's speed it up a](https://youtu.be/ATfuFU70Pjo?t=01h23m27s)



[little all right so let's let's go down](https://youtu.be/ATfuFU70Pjo?t=01h23m30s)



[to one one oh I guess I got to change](https://youtu.be/ATfuFU70Pjo?t=01h23m36s)



[all of these not just one of them all](https://youtu.be/ATfuFU70Pjo?t=01h23m41s)



[right](https://youtu.be/ATfuFU70Pjo?t=01h23m43s)



[so that one that one that one let's see](https://youtu.be/ATfuFU70Pjo?t=01h23m46s)



[if that looks a little better cuz that I](https://youtu.be/ATfuFU70Pjo?t=01h23m51s)



[think we're getting pretty close this at](https://youtu.be/ATfuFU70Pjo?t=01h23m53s)



[least at least animation wise this looks](https://youtu.be/ATfuFU70Pjo?t=01h23m56s)



[a lot closer to what we were shooting](https://youtu.be/ATfuFU70Pjo?t=01h23m58s)



[for](https://youtu.be/ATfuFU70Pjo?t=01h24m01s)



[okay so did you chip chip chip](https://youtu.be/ATfuFU70Pjo?t=01h24m08s)



[citizenships](https://youtu.be/ATfuFU70Pjo?t=01h24m11s)



[you've got too far the other way](https://youtu.be/ATfuFU70Pjo?t=01h24m19s)



[okay split the difference let's go down](https://youtu.be/ATfuFU70Pjo?t=01h24m27s)



[to 0.2 and ooh snack bar message cute](https://youtu.be/ATfuFU70Pjo?t=01h24m30s)



[pump async interesting not what I'm here](https://youtu.be/ATfuFU70Pjo?t=01h24m35s)



[to fix at the moment okay let's let's](https://youtu.be/ATfuFU70Pjo?t=01h24m38s)



[swap all these to 2/10 of a second see](https://youtu.be/ATfuFU70Pjo?t=01h24m41s)



[if we get a little bit better feel this](https://youtu.be/ATfuFU70Pjo?t=01h24m44s)



[is one of those areas where it would be](https://youtu.be/ATfuFU70Pjo?t=01h24m48s)



[nice I question whether it's nice to](https://youtu.be/ATfuFU70Pjo?t=01h24m49s)



[have configurability for people it's](https://youtu.be/ATfuFU70Pjo?t=01h24m52s)



[just not always the easiest thing to do](https://youtu.be/ATfuFU70Pjo?t=01h24m57s)



[I've contemplated going through and just](https://youtu.be/ATfuFU70Pjo?t=01h25m02s)



[writing sort of a helper class for a lot](https://youtu.be/ATfuFU70Pjo?t=01h25m04s)



[of these that sort of gives a generic](https://youtu.be/ATfuFU70Pjo?t=01h25m06s)



[API for mucking with durations because](https://youtu.be/ATfuFU70Pjo?t=01h25m09s)



[I've seen occasionally where people want](https://youtu.be/ATfuFU70Pjo?t=01h25m11s)



[to tweak these just slightly for](https://youtu.be/ATfuFU70Pjo?t=01h25m13s)



[different controls and there](https://youtu.be/ATfuFU70Pjo?t=01h25m16s)



[yeah I like that a lot](https://youtu.be/ATfuFU70Pjo?t=01h25m26s)



[okay so let's we're in a working state](https://youtu.be/ATfuFU70Pjo?t=01h25m33s)



[let's start with this stage all changes](https://youtu.be/ATfuFU70Pjo?t=01h25m36s)



[got animations working boom okay so](https://youtu.be/ATfuFU70Pjo?t=01h25m40s)



[let's see about dealing with theming](https://youtu.be/ATfuFU70Pjo?t=01h25m49s)



[changes right so if we fire this guy up](https://youtu.be/ATfuFU70Pjo?t=01h25m51s)



[and go into dark mode I suspect given](https://youtu.be/ATfuFU70Pjo?t=01h25m53s)



[that we've got hard-coded values this is](https://youtu.be/ATfuFU70Pjo?t=01h25m56s)



[probably not gonna look that great right](https://youtu.be/ATfuFU70Pjo?t=01h26m00s)



[so dududududu color tool flip into dark](https://youtu.be/ATfuFU70Pjo?t=01h26m02s)



[mode and then chips right](https://youtu.be/ATfuFU70Pjo?t=01h26m08s)



[yeah](https://youtu.be/ATfuFU70Pjo?t=01h26m16s)



[that is interesting](https://youtu.be/ATfuFU70Pjo?t=01h26m23s)



[yeah I don't we definitely don't want](https://youtu.be/ATfuFU70Pjo?t=01h26m28s)



[this so let's go and look at light light](https://youtu.be/ATfuFU70Pjo?t=01h26m31s)



[face theme I thought there was a nice](https://youtu.be/ATfuFU70Pjo?t=01h26m42s)



[class I could go and look at](https://youtu.be/ATfuFU70Pjo?t=01h26m45s)



[well this'll probably give me clothes](https://youtu.be/ATfuFU70Pjo?t=01h26m54s)



[right so in light mode it's using c4](https://youtu.be/ATfuFU70Pjo?t=01h26m56s)



[it's not line up with any of our](https://youtu.be/ATfuFU70Pjo?t=01h27m03s)



[convenient brushes that we're using](https://youtu.be/ATfuFU70Pjo?t=01h27m05s)



[let's see here I've got like a de](https://youtu.be/ATfuFU70Pjo?t=01h27m10s)



[I'm wondering if it's better to just do](https://youtu.be/ATfuFU70Pjo?t=01h27m21s)



[a opacity over the top all right like](https://youtu.be/ATfuFU70Pjo?t=01h27m24s)



[take the the foreground and apply it](https://youtu.be/ATfuFU70Pjo?t=01h27m34s)



[that way](https://youtu.be/ATfuFU70Pjo?t=01h27m39s)



[let's take a quick look what what is the](https://youtu.be/ATfuFU70Pjo?t=01h27m46s)



[selection states on some of these other](https://youtu.be/ATfuFU70Pjo?t=01h27m48s)



[ones look at so selected border this](https://youtu.be/ATfuFU70Pjo?t=01h27m50s)



[guy's just goes to 0.8 not that I](https://youtu.be/ATfuFU70Pjo?t=01h27m54s)



[necessarily want to use this as a](https://youtu.be/ATfuFU70Pjo?t=01h27m58s)



[perfect guideline because this guy has](https://youtu.be/ATfuFU70Pjo?t=01h28m00s)



[had plenty of problems where is](https://youtu.be/ATfuFU70Pjo?t=01h28m03s)



[selective border](https://youtu.be/ATfuFU70Pjo?t=01h28m08s)



[it's down below](https://youtu.be/ATfuFU70Pjo?t=01h28m13s)



[yeah so this is sort of what I was](https://youtu.be/ATfuFU70Pjo?t=01h28m18s)



[thinking I both like it and hate it all](https://youtu.be/ATfuFU70Pjo?t=01h28m20s)



[at the same time so this works really](https://youtu.be/ATfuFU70Pjo?t=01h28m23s)



[well because it can derive its color](https://youtu.be/ATfuFU70Pjo?t=01h28m25s)



[that it wants from the foreground but](https://youtu.be/ATfuFU70Pjo?t=01h28m28s)



[unfortunately it then tightly couples it](https://youtu.be/ATfuFU70Pjo?t=01h28m31s)



[to the foreground the the nice part](https://youtu.be/ATfuFU70Pjo?t=01h28m34s)



[about this is it easily changes it with](https://youtu.be/ATfuFU70Pjo?t=01h28m39s)



[the theme so as you go to dark to light](https://youtu.be/ATfuFU70Pjo?t=01h28m41s)



[dark to light](https://youtu.be/ATfuFU70Pjo?t=01h28m44s)



[it just works which is nice it's really](https://youtu.be/ATfuFU70Pjo?t=01h28m45s)



[convenient but I have run into cases](https://youtu.be/ATfuFU70Pjo?t=01h28m48s)



[where people want to change the](https://youtu.be/ATfuFU70Pjo?t=01h28m54s)



[selection color and we don't offer a lot](https://youtu.be/ATfuFU70Pjo?t=01h28m55s)



[of control over that so I'm kind of](https://youtu.be/ATfuFU70Pjo?t=01h29m00s)



[hesitant to go into that go down that](https://youtu.be/ATfuFU70Pjo?t=01h29m01s)



[path knowing that we've run into this](https://youtu.be/ATfuFU70Pjo?t=01h29m04s)



[problem before and a quote-unquote](https://youtu.be/ATfuFU70Pjo?t=01h29m08s)



[problem right I mean it's it's an area](https://youtu.be/ATfuFU70Pjo?t=01h29m12s)



[of extensibility that I know other](https://youtu.be/ATfuFU70Pjo?t=01h29m14s)



[people want so I'm thinking I don't](https://youtu.be/ATfuFU70Pjo?t=01h29m16s)



[build into that same problem but it does](https://youtu.be/ATfuFU70Pjo?t=01h29m18s)



[beg the question though what color](https://youtu.be/ATfuFU70Pjo?t=01h29m22s)



[should this be let's start with this do](https://youtu.be/ATfuFU70Pjo?t=01h29m25s)



[we have any sort of](https://youtu.be/ATfuFU70Pjo?t=01h29m34s)



[so the chip is our class right so we](https://youtu.be/ATfuFU70Pjo?t=01h29m38s)



[could get fancy with some of this stuff](https://youtu.be/ATfuFU70Pjo?t=01h29m43s)



[icon foreground](https://youtu.be/ATfuFU70Pjo?t=01h29m47s)



[just wondering if there's a an easy way](https://youtu.be/ATfuFU70Pjo?t=01h29m56s)



[of going about doing this I was](https://youtu.be/ATfuFU70Pjo?t=01h30m01s)



[contemplating reusing some of this stuff](https://youtu.be/ATfuFU70Pjo?t=01h30m03s)



[but I'm not sure if that's a great](https://youtu.be/ATfuFU70Pjo?t=01h30m05s)



[option list box assist what do we got on](https://youtu.be/ATfuFU70Pjo?t=01h30m09s)



[here](https://youtu.be/ATfuFU70Pjo?t=01h30m13s)



[is toggle](https://youtu.be/ATfuFU70Pjo?t=01h30m17s)



[just great it doesn't really drive home](https://youtu.be/ATfuFU70Pjo?t=01h30m20s)



[at the theming idea of this let's see so](https://youtu.be/ATfuFU70Pjo?t=01h30m25s)



[if that's not gonna play nice there look](https://youtu.be/ATfuFU70Pjo?t=01h30m29s)



[what else what else we were doing the](https://youtu.be/ATfuFU70Pjo?t=01h30m33s)



[mouse over effect with the background](https://youtu.be/ATfuFU70Pjo?t=01h30m35s)



[what's going d8 instead of c4](https://youtu.be/ATfuFU70Pjo?t=01h30m38s)



[flap button click](https://youtu.be/ATfuFU70Pjo?t=01h30m48s)



[d8 instead of c4 a little hesitated to](https://youtu.be/ATfuFU70Pjo?t=01h30m53s)



[to add more purpose-built brushes to I](https://youtu.be/ATfuFU70Pjo?t=01h30m59s)



[mean we can right](https://youtu.be/ATfuFU70Pjo?t=01h31m01s)



[we're quickly running into that case](https://youtu.be/ATfuFU70Pjo?t=01h31m04s)



[where it's similar to what my Ops ran](https://youtu.be/ATfuFU70Pjo?t=01h31m06s)



[into is they started brush a find](https://youtu.be/ATfuFU70Pjo?t=01h31m08s)



[everything and they needed to move stuff](https://youtu.be/ATfuFU70Pjo?t=01h31m10s)



[into specialized namespaces which caused](https://youtu.be/ATfuFU70Pjo?t=01h31m11s)



[a significant breakage a little hesitant](https://youtu.be/ATfuFU70Pjo?t=01h31m15s)



[to do that](https://youtu.be/ATfuFU70Pjo?t=01h31m21s)



[I don't mind starting to move new stuff](https://youtu.be/ATfuFU70Pjo?t=01h31m22s)



[that direction but I'm not sure this](https://youtu.be/ATfuFU70Pjo?t=01h31m24s)



[warrants it right now I think as much as](https://youtu.be/ATfuFU70Pjo?t=01h31m27s)



[I said I didn't like it I think in the](https://youtu.be/ATfuFU70Pjo?t=01h31m33s)



[interest of MVP and actually shipping](https://youtu.be/ATfuFU70Pjo?t=01h31m35s)



[this thing out the door all right we](https://youtu.be/ATfuFU70Pjo?t=01h31m38s)



[might just go this route](https://youtu.be/ATfuFU70Pjo?t=01h31m41s)



[might just go this route initially](https://youtu.be/ATfuFU70Pjo?t=01h31m46s)



[because this is the easiest option that](https://youtu.be/ATfuFU70Pjo?t=01h31m48s)



[gets it working so there's that](https://youtu.be/ATfuFU70Pjo?t=01h31m51s)



[that and I am curious to look at this](https://youtu.be/ATfuFU70Pjo?t=01h32m00s)



[right because this was mouse-over is](https://youtu.be/ATfuFU70Pjo?t=01h32m03s)



[behind selection but the selection was](https://youtu.be/ATfuFU70Pjo?t=01h32m06s)



[only going yeah so they change up what](https://youtu.be/ATfuFU70Pjo?t=01h32m13s)



[it is](https://youtu.be/ATfuFU70Pjo?t=01h32m20s)



[so what does this brush round converter](https://youtu.be/ATfuFU70Pjo?t=01h32m29s)



[do](https://youtu.be/ATfuFU70Pjo?t=01h32m31s)



[got it so it does a conversion to](https://youtu.be/ATfuFU70Pjo?t=01h32m36s)



[greyscale basically and then does a](https://youtu.be/ATfuFU70Pjo?t=01h32m40s)



[check to see if it's light or dark and](https://youtu.be/ATfuFU70Pjo?t=01h32m42s)



[then flips on either white or black](https://youtu.be/ATfuFU70Pjo?t=01h32m46s)



[right so this is either going to be a](https://youtu.be/ATfuFU70Pjo?t=01h32m49s)



[white brush or a black brush depending](https://youtu.be/ATfuFU70Pjo?t=01h32m50s)



[on that and then change the opacity into](https://youtu.be/ATfuFU70Pjo?t=01h32m53s)



[just down down down down down all right](https://youtu.be/ATfuFU70Pjo?t=01h33m01s)



[and then change the opacity to 0.8 or](https://youtu.be/ATfuFU70Pjo?t=01h33m08s)



[not based upon whether it's selected so](https://youtu.be/ATfuFU70Pjo?t=01h33m13s)



[I think I like that](https://youtu.be/ATfuFU70Pjo?t=01h33m16s)



[so to do keep going down keep going down](https://youtu.be/ATfuFU70Pjo?t=01h33m22s)



[keep going down so that changes these](https://youtu.be/ATfuFU70Pjo?t=01h33m25s)



[guys right so it's the chip one yeah](https://youtu.be/ATfuFU70Pjo?t=01h33m29s)



[chip listbox item so this guy rather](https://youtu.be/ATfuFU70Pjo?t=01h33m36s)



[than becoming a one goes to zero point](https://youtu.be/ATfuFU70Pjo?t=01h33m39s)



[eight zero is fine one becomes zero](https://youtu.be/ATfuFU70Pjo?t=01h33m43s)



[point eight](https://youtu.be/ATfuFU70Pjo?t=01h33m49s)



[all right so that goes like that zero is](https://youtu.be/ATfuFU70Pjo?t=01h33m53s)



[fine there let's see how that looks](https://youtu.be/ATfuFU70Pjo?t=01h33m56s)



[is mouse-over actually being used so](https://youtu.be/ATfuFU70Pjo?t=01h33m59s)



[mouse-over isn't actually being used](https://youtu.be/ATfuFU70Pjo?t=01h34m03s)



[don't know how I feel about that I](https://youtu.be/ATfuFU70Pjo?t=01h34m08s)



[should we should probably the wax of](https://youtu.be/ATfuFU70Pjo?t=01h34m11s)



[control or put something on it](https://youtu.be/ATfuFU70Pjo?t=01h34m13s)



[mouse-over is doing something](https://youtu.be/ATfuFU70Pjo?t=01h34m23s)



[oh look at that it is working](https://youtu.be/ATfuFU70Pjo?t=01h34m29s)



[how do it know how do it know](https://youtu.be/ATfuFU70Pjo?t=01h34m35s)



[mouse-over color](https://youtu.be/ATfuFU70Pjo?t=01h34m49s)



[oh it's probably in here right](https://youtu.be/ATfuFU70Pjo?t=01h34m54s)



[mouse-over border so it's adding it it](https://youtu.be/ATfuFU70Pjo?t=01h34m59s)



[okay look at that](https://youtu.be/ATfuFU70Pjo?t=01h35m02s)



[it's already done awesome great great](https://youtu.be/ATfuFU70Pjo?t=01h35m03s)



[great great great great we're gonna turn](https://youtu.be/ATfuFU70Pjo?t=01h35m11s)



[this oh and it looks like is enabled as](https://youtu.be/ATfuFU70Pjo?t=01h35m13s)



[actually being handle for us too so will](https://youtu.be/ATfuFU70Pjo?t=01h35m16s)



[won't confirm that in a moment](https://youtu.be/ATfuFU70Pjo?t=01h35m18s)



[okay so there's those let's go change](https://youtu.be/ATfuFU70Pjo?t=01h35m21s)



[flip into dark mode and go back chips](https://youtu.be/ATfuFU70Pjo?t=01h35m25s)



[yeah](https://youtu.be/ATfuFU70Pjo?t=01h35m38s)



[I could get on board with that at least](https://youtu.be/ATfuFU70Pjo?t=01h35m43s)



[for an initial MVP yeah](https://youtu.be/ATfuFU70Pjo?t=01h35m45s)



[we now have filter ships where you can](https://youtu.be/ATfuFU70Pjo?t=01h35m51s)



[get the selection on it right cool cool](https://youtu.be/ATfuFU70Pjo?t=01h35m55s)



[cool cool](https://youtu.be/ATfuFU70Pjo?t=01h36m03s)



[oh I was gonna check disabling one of](https://youtu.be/ATfuFU70Pjo?t=01h36m04s)



[those let's see here that is on the](https://youtu.be/ATfuFU70Pjo?t=01h36m07s)



[chips page well let's just turn one of](https://youtu.be/ATfuFU70Pjo?t=01h36m10s)



[those guys those people familiar with](https://youtu.be/ATfuFU70Pjo?t=01h36m14s)



[the joke](https://youtu.be/ATfuFU70Pjo?t=01h36m21s)



[will do butoh it's enabled false](https://youtu.be/ATfuFU70Pjo?t=01h36m22s)



[hopefully somebody gets the subtle humor](https://youtu.be/ATfuFU70Pjo?t=01h36m31s)



[in that](https://youtu.be/ATfuFU70Pjo?t=01h36m33s)



[it may not be that subtle but we're](https://youtu.be/ATfuFU70Pjo?t=01h36m41s)



[going with it okay](https://youtu.be/ATfuFU70Pjo?t=01h36m44s)



[come on go go oh you just opened on the](https://youtu.be/ATfuFU70Pjo?t=01h36m54s)



[wrong thing](https://youtu.be/ATfuFU70Pjo?t=01h36m58s)



[okay so chips chips chips chips good](https://youtu.be/ATfuFU70Pjo?t=01h36m59s)



[disabled checked unchecked and actually](https://youtu.be/ATfuFU70Pjo?t=01h37m04s)



[let's start one of these as is selected](https://youtu.be/ATfuFU70Pjo?t=01h37m10s)



[true right I want people to be able to](https://youtu.be/ATfuFU70Pjo?t=01h37m13s)



[immediately see the purpose of these](https://youtu.be/ATfuFU70Pjo?t=01h37m15s)



[when they hit this page that you can](https://youtu.be/ATfuFU70Pjo?t=01h37m18s)



[turn these guys on and off it will and](https://youtu.be/ATfuFU70Pjo?t=01h37m22s)



[then you've got an easy yeah choo choo](https://youtu.be/ATfuFU70Pjo?t=01h37m25s)



[choo choo choo and I think if we do](https://youtu.be/ATfuFU70Pjo?t=01h37m30s)



[let's see list box assist is toggle true](https://youtu.be/ATfuFU70Pjo?t=01h37m35s)



[right if we turn that on](https://youtu.be/ATfuFU70Pjo?t=01h37m41s)



[let's relaunch](https://youtu.be/ATfuFU70Pjo?t=01h37m44s)



[I think this all just works I think I](https://youtu.be/ATfuFU70Pjo?t=01h37m46s)



[don't know if the Edit and continue will](https://youtu.be/ATfuFU70Pjo?t=01h37m50s)



[play nice with it given that this guy](https://youtu.be/ATfuFU70Pjo?t=01h37m53s)



[has to wire up for events and whatnot](https://youtu.be/ATfuFU70Pjo?t=01h37m55s)



[but I think just nope](https://youtu.be/ATfuFU70Pjo?t=01h37m56s)



[so how do you work then set is toggle](https://youtu.be/ATfuFU70Pjo?t=01h38m03s)



[blah blah blah blah blah right so let's](https://youtu.be/ATfuFU70Pjo?t=01h38m07s)



[scrap this alright so if I go click hit](https://youtu.be/ATfuFU70Pjo?t=01h38m12s)



[test to test this box take Wow find some](https://youtu.be/ATfuFU70Pjo?t=01h38m19s)



[ripple it's not going to find a ripple](https://youtu.be/ATfuFU70Pjo?t=01h38m25s)



[so run to here](https://youtu.be/ATfuFU70Pjo?t=01h38m28s)



[alright let's box item so we're not](https://youtu.be/ATfuFU70Pjo?t=01h38m30s)



[going to hit that set current property](https://youtu.be/ATfuFU70Pjo?t=01h38m34s)



[so this box item is selected is](https://youtu.be/ATfuFU70Pjo?t=01h38m37s)



[initialized is selected false boom all](https://youtu.be/ATfuFU70Pjo?t=01h38m44s)



[right set current value](https://youtu.be/ATfuFU70Pjo?t=01h38m50s)



[interesting so how does this thing turn](https://youtu.be/ATfuFU70Pjo?t=01h39m06s)



[off the other ones mousedown timestamp](https://youtu.be/ATfuFU70Pjo?t=01h39m08s)



[Oh](https://youtu.be/ATfuFU70Pjo?t=01h39m19s)



[I got you I got you so it's not no it's](https://youtu.be/ATfuFU70Pjo?t=01h39m21s)



[not the is selection stuff that matters](https://youtu.be/ATfuFU70Pjo?t=01h39m24s)



[right it's the selection mode so if you](https://youtu.be/ATfuFU70Pjo?t=01h39m27s)



[go selection mode single I think it's](https://youtu.be/ATfuFU70Pjo?t=01h39m32s)



[the kicker](https://youtu.be/ATfuFU70Pjo?t=01h39m39s)



[right now whether you want to allow](https://youtu.be/ATfuFU70Pjo?t=01h39m39s)



[people to select multiple things or one](https://youtu.be/ATfuFU70Pjo?t=01h39m41s)



[thing now I think that that works the](https://youtu.be/ATfuFU70Pjo?t=01h39m43s)



[way I expect I think we probably just](https://youtu.be/ATfuFU70Pjo?t=01h39m49s)



[defaulted to multi selection turn you](https://youtu.be/ATfuFU70Pjo?t=01h39m50s)



[off](https://youtu.be/ATfuFU70Pjo?t=01h39m54s)



[Chuchu Chuchu](https://youtu.be/ATfuFU70Pjo?t=01h39m59s)



[there we go so I'm guessing this style](https://youtu.be/ATfuFU70Pjo?t=01h40m04s)



[that we've gotten here probably defaults](https://youtu.be/ATfuFU70Pjo?t=01h40m07s)



[to selection mode multiple yeah which is](https://youtu.be/ATfuFU70Pjo?t=01h40m11s)



[fine that's that's perfectly acceptable](https://youtu.be/ATfuFU70Pjo?t=01h40m15s)



[I accept if you don't like it you can](https://youtu.be/ATfuFU70Pjo?t=01h40m18s)



[turn it back down to single but I](https://youtu.be/ATfuFU70Pjo?t=01h40m22s)



[suspect if you're using the style multi](https://youtu.be/ATfuFU70Pjo?t=01h40m26s)



[selections probably what you're going](https://youtu.be/ATfuFU70Pjo?t=01h40m27s)



[for anyway so yeah great let's see here](https://youtu.be/ATfuFU70Pjo?t=01h40m29s)



[well that's names not used to clean that](https://youtu.be/ATfuFU70Pjo?t=01h40m35s)



[up yeah agh sorry fix that uh American](https://youtu.be/ATfuFU70Pjo?t=01h40m38s)



[spelling uh did it did it today](https://youtu.be/ATfuFU70Pjo?t=01h40m49s)



[great great great great great that all](https://youtu.be/ATfuFU70Pjo?t=01h40m54s)



[works that all works just clean this up](https://youtu.be/ATfuFU70Pjo?t=01h40m55s)



[while we're in here base class qualifier](https://youtu.be/ATfuFU70Pjo?t=01h40m59s)



[okay anything else we want to clean up](https://youtu.be/ATfuFU70Pjo?t=01h41m03s)



[in here while we're always try to leave](https://youtu.be/ATfuFU70Pjo?t=01h41m05s)



[the code in a cleaner state than when I](https://youtu.be/ATfuFU70Pjo?t=01h41m08s)



[found it just gonna scan through this](https://youtu.be/ATfuFU70Pjo?t=01h41m10s)



[file I've been trying to keep it](https://youtu.be/ATfuFU70Pjo?t=01h41m13s)



[somewhat limited at my changes so Magnus](https://youtu.be/ATfuFU70Pjo?t=01h41m15s)



[if you're watching this great job I](https://youtu.be/ATfuFU70Pjo?t=01h41m25s)



[definitely appreciate all of the help](https://youtu.be/ATfuFU70Pjo?t=01h41m29s)



[yeah I think we're good](https://youtu.be/ATfuFU70Pjo?t=01h41m32s)



[so let's see and lean Phoebe](https://youtu.be/ATfuFU70Pjo?t=01h41m34s)



[and doline they mean boom and let's just](https://youtu.be/ATfuFU70Pjo?t=01h41m50s)



[push right and this is going to require](https://youtu.be/ATfuFU70Pjo?t=01h41m56s)



[a force push because we rebased so we've](https://youtu.be/ATfuFU70Pjo?t=01h41m59s)



[effectively changed up all of these guys](https://youtu.be/ATfuFU70Pjo?t=01h42m01s)



[but once again okay so you can get out](https://youtu.be/ATfuFU70Pjo?t=01h42m04s)



[of the way come back over here we'll let](https://youtu.be/ATfuFU70Pjo?t=01h42m08s)



[the build run and then this guy should](https://youtu.be/ATfuFU70Pjo?t=01h42m11s)



[update boom lots of changes and we can](https://youtu.be/ATfuFU70Pjo?t=01h42m17s)



[edit this title this is no longer work](https://youtu.be/ATfuFU70Pjo?t=01h42m24s)



[in progress this is what I would call as](https://youtu.be/ATfuFU70Pjo?t=01h42m27s)



[done so we're going to go with](https://youtu.be/ATfuFU70Pjo?t=01h42m30s)



[enhancement let's see I did up for](https://youtu.be/ATfuFU70Pjo?t=01h42m34s)



[people who care I did add this new label](https://youtu.be/ATfuFU70Pjo?t=01h42m38s)



[here for visual breaking change so if](https://youtu.be/ATfuFU70Pjo?t=01h42m40s)



[you are interested on a release to see](https://youtu.be/ATfuFU70Pjo?t=01h42m43s)



[which things I know are going to cause](https://youtu.be/ATfuFU70Pjo?t=01h42m45s)



[visually a breaking change I put this](https://youtu.be/ATfuFU70Pjo?t=01h42m49s)



[tag and I'm going to try and be diligent](https://youtu.be/ATfuFU70Pjo?t=01h42m52s)



[about actually tagging things that way](https://youtu.be/ATfuFU70Pjo?t=01h42m53s)



[that way there is a nice easy way to go](https://youtu.be/ATfuFU70Pjo?t=01h42m57s)



[through and do this okay let's see what](https://youtu.be/ATfuFU70Pjo?t=01h42m59s)



[else is in the 300 milestone let's see](https://youtu.be/ATfuFU70Pjo?t=01h43m01s)



[that toggling light dark has no](https://youtu.be/ATfuFU70Pjo?t=01h43m05s)



[trying to decide if this is still a bug](https://youtu.be/ATfuFU70Pjo?t=01h43m21s)



[or not to do to do because I think](https://youtu.be/ATfuFU70Pjo?t=01h43m24s)



[well we might just we might just code](https://youtu.be/ATfuFU70Pjo?t=01h43m39s)



[this guy up right he may have left us](https://youtu.be/ATfuFU70Pjo?t=01h43m41s)



[some nice code let's just download this](https://youtu.be/ATfuFU70Pjo?t=01h43m45s)



[guy all right we might look at this one](https://youtu.be/ATfuFU70Pjo?t=01h43m49s)



[really quick so there's been a couple](https://youtu.be/ATfuFU70Pjo?t=01h43m51s)



[changes since this guy was or since this](https://youtu.be/ATfuFU70Pjo?t=01h43m53s)



[bug was opened right the first of which](https://youtu.be/ATfuFU70Pjo?t=01h43m56s)



[is we have the nice dark mode dialogue](https://youtu.be/ATfuFU70Pjo?t=01h43m58s)



[support right because initially when](https://youtu.be/ATfuFU70Pjo?t=01h44m02s)



[this was done dark mode dialogues](https://youtu.be/ATfuFU70Pjo?t=01h44m05s)



[weren't a thing and now they are thing](https://youtu.be/ATfuFU70Pjo?t=01h44m07s)



[just open and more importantly we've got](https://youtu.be/ATfuFU70Pjo?t=01h44m12s)



[a feature that allows the dialogues to](https://youtu.be/ATfuFU70Pjo?t=01h44m17s)



[inherit their themes and I think that](https://youtu.be/ATfuFU70Pjo?t=01h44m19s)



[might shake I I have a hunch it might](https://youtu.be/ATfuFU70Pjo?t=01h44m22s)



[actually fix fix the stuff but we're](https://youtu.be/ATfuFU70Pjo?t=01h44m26s)



[gonna we will Rev the project I think](https://youtu.be/ATfuFU70Pjo?t=01h44m33s)



[all I have to do is come on go ahead](https://youtu.be/ATfuFU70Pjo?t=01h44m37s)



[lunch I think all I have to do is Rev](https://youtu.be/ATfuFU70Pjo?t=01h44m40s)



[the project up to the latest material](https://youtu.be/ATfuFU70Pjo?t=01h44m42s)



[design in sam'l and we'll see what the](https://youtu.be/ATfuFU70Pjo?t=01h44m45s)



[fallout is okay so this will be a quick](https://youtu.be/ATfuFU70Pjo?t=01h44m47s)



[lesson in updating from whatever version](https://youtu.be/ATfuFU70Pjo?t=01h44m52s)



[this is targeting let's see probably to](https://youtu.be/ATfuFU70Pjo?t=01h44m55s)



[something yeah to to so we are going to](https://youtu.be/ATfuFU70Pjo?t=01h44m59s)



[Rev this guy up to latest and greatest](https://youtu.be/ATfuFU70Pjo?t=01h45m04s)



[as of a few minutes ago so let's see](https://youtu.be/ATfuFU70Pjo?t=01h45m06s)



[material design themes grab me the](https://youtu.be/ATfuFU70Pjo?t=01h45m10s)



[latest and more importantly I actually](https://youtu.be/ATfuFU70Pjo?t=01h45m12s)



[want to come down here and grab this one](https://youtu.be/ATfuFU70Pjo?t=01h45m16s)



[so not the 98 one but the actual one](https://youtu.be/ATfuFU70Pjo?t=01h45m21s)



[thousand something another so like I](https://youtu.be/ATfuFU70Pjo?t=01h45m24s)



[said I do apologize but I don't see an](https://youtu.be/ATfuFU70Pjo?t=01h45m27s)



[easy fix for this for this version right](https://youtu.be/ATfuFU70Pjo?t=01h45m29s)



[next version we can make changes and](https://youtu.be/ATfuFU70Pjo?t=01h45m33s)



[clean it up but I don't see an option](https://youtu.be/ATfuFU70Pjo?t=01h45m35s)



[for this oh wait what](https://youtu.be/ATfuFU70Pjo?t=01h45m39s)



[didn't I tell you to grab a different](https://youtu.be/ATfuFU70Pjo?t=01h45m43s)



[one refresh what version did you rev up](https://youtu.be/ATfuFU70Pjo?t=01h45m45s)



[into oh so](https://youtu.be/ATfuFU70Pjo?t=01h45m51s)



[oh I see it did ruff I'm just looking at](https://youtu.be/ATfuFU70Pjo?t=01h45m59s)



[the wrong one okay so there's that](https://youtu.be/ATfuFU70Pjo?t=01h46m02s)



[there's that everyone's happy let's](https://youtu.be/ATfuFU70Pjo?t=01h46m03s)



[check our app dot zamel this all](https://youtu.be/ATfuFU70Pjo?t=01h46m06s)



[technically works but I want to change](https://youtu.be/ATfuFU70Pjo?t=01h46m10s)



[this over to the new theming stuff so if](https://youtu.be/ATfuFU70Pjo?t=01h46m12s)



[we look at here here go to our demo app](https://youtu.be/ATfuFU70Pjo?t=01h46m15s)



[there's a nice example inside of this of](https://youtu.be/ATfuFU70Pjo?t=01h46m20s)



[all the stuff that you need to do so in](https://youtu.be/ATfuFU70Pjo?t=01h46m23s)



[general you can get away with most of](https://youtu.be/ATfuFU70Pjo?t=01h46m25s)



[your theming using this alright so](https://youtu.be/ATfuFU70Pjo?t=01h46m27s)



[there's a nice built in theming one that](https://youtu.be/ATfuFU70Pjo?t=01h46m30s)



[you can leverage so you still need the](https://youtu.be/ATfuFU70Pjo?t=01h46m34s)



[the default right but this guy should be](https://youtu.be/ATfuFU70Pjo?t=01h46m37s)



[able to replace most of it so he was](https://youtu.be/ATfuFU70Pjo?t=01h46m41s)



[using the light theme that's now handled](https://youtu.be/ATfuFU70Pjo?t=01h46m43s)



[so that goes away Oh apparently I missed](https://youtu.be/ATfuFU70Pjo?t=01h46m46s)



[my closing let's see what color we got](https://youtu.be/ATfuFU70Pjo?t=01h46m48s)



[down here we got ignant go for primary](https://youtu.be/ATfuFU70Pjo?t=01h46m51s)



[so if you go there secondary color of](https://youtu.be/ATfuFU70Pjo?t=01h46m54s)



[red boom that that and I'm guessing](https://youtu.be/ATfuFU70Pjo?t=01h47m02s)



[there is something in a code behind](https://youtu.be/ATfuFU70Pjo?t=01h47m09s)



[that's going to be changing these so](https://youtu.be/ATfuFU70Pjo?t=01h47m12s)



[palette helper largely gut obsoleted](https://youtu.be/ATfuFU70Pjo?t=01h47m17s)



[right so you can get theme bar theme](https://youtu.be/ATfuFU70Pjo?t=01h47m21s)



[all right and you don't necessarily even](https://youtu.be/ATfuFU70Pjo?t=01h47m30s)



[need this stuff](https://youtu.be/ATfuFU70Pjo?t=01h47m32s)



[do-do-do-do-do-do I'll see solid color](https://youtu.be/ATfuFU70Pjo?t=01h47m35s)



[brush what they should be on blah blah](https://youtu.be/ATfuFU70Pjo?t=01h47m41s)



[blah oh I see this is just trying to get](https://youtu.be/ATfuFU70Pjo?t=01h47m46s)



[the new one](https://youtu.be/ATfuFU70Pjo?t=01h47m55s)



[some of this might get a lot simpler](https://youtu.be/ATfuFU70Pjo?t=01h47m55s)



[here in a moment](https://youtu.be/ATfuFU70Pjo?t=01h47m58s)



[well I'm realizing this has asset-based](https://youtu.be/ATfuFU70Pjo?t=01h48m04s)



[theme it might be nice to be able to get](https://youtu.be/ATfuFU70Pjo?t=01h48m06s)



[get the base theme it's kinda hard to](https://youtu.be/ATfuFU70Pjo?t=01h48m08s)



[tell right because in theory people can](https://youtu.be/ATfuFU70Pjo?t=01h48m14s)



[use custom themes and so how do you tell](https://youtu.be/ATfuFU70Pjo?t=01h48m17s)



[if it's light or dark yeah](https://youtu.be/ATfuFU70Pjo?t=01h48m19s)



[we'll leave that for the moment primary](https://youtu.be/ATfuFU70Pjo?t=01h48m26s)



[toggle let's see](https://youtu.be/ATfuFU70Pjo?t=01h48m30s)



[I'm actually not really interested in](https://youtu.be/ATfuFU70Pjo?t=01h48m37s)



[setting these I'm really just interested](https://youtu.be/ATfuFU70Pjo?t=01h48m40s)



[in the light-dark toggle for now really](https://youtu.be/ATfuFU70Pjo?t=01h48m43s)



[not interested in dealing with these](https://youtu.be/ATfuFU70Pjo?t=01h48m47s)



[ones for the moment right so this is](https://youtu.be/ATfuFU70Pjo?t=01h48m49s)



[just toggling colors and I'm most](https://youtu.be/ATfuFU70Pjo?t=01h48m52s)



[interested in this so let's grab here](https://youtu.be/ATfuFU70Pjo?t=01h48m55s)



[boom that let's see](https://youtu.be/ATfuFU70Pjo?t=01h49m01s)



[so theme set theme and I think what](https://youtu.be/ATfuFU70Pjo?t=01h49m06s)



[we're gonna just do is take this bool](https://youtu.be/ATfuFU70Pjo?t=01h49m13s)



[which I think was setting is dark so](https://youtu.be/ATfuFU70Pjo?t=01h49m18s)



[untrue it should be based theme dark](https://youtu.be/ATfuFU70Pjo?t=01h49m21s)



[else base theme light so how that worked](https://youtu.be/ATfuFU70Pjo?t=01h49m27s)



[trying to remember](https://youtu.be/ATfuFU70Pjo?t=01h49m33s)



[what what is okay they might have to go](https://youtu.be/ATfuFU70Pjo?t=01h49m39s)



[back to the docks let's see here so if](https://youtu.be/ATfuFU70Pjo?t=01h49m42s)



[we go looking at the wiki sweet this](https://youtu.be/ATfuFU70Pjo?t=01h49m45s)



[thing finished squash marriage boom in](https://youtu.be/ATfuFU70Pjo?t=01h49m47s)



[and done one more bites the dust okay so](https://youtu.be/ATfuFU70Pjo?t=01h49m51s)



[if we go to the wiki and go down to](https://youtu.be/ATfuFU70Pjo?t=01h49m56s)



[advanced theming there is samples in](https://youtu.be/ATfuFU70Pjo?t=01h49m58s)



[here for how to go through and do the](https://youtu.be/ATfuFU70Pjo?t=01h50m01s)



[various themes so what I'm looking for](https://youtu.be/ATfuFU70Pjo?t=01h50m04s)



[is Oh theme dot light and theme dot dark](https://youtu.be/ATfuFU70Pjo?t=01h50m07s)



[how basically I need to stop typing so](https://youtu.be/ATfuFU70Pjo?t=01h50m12s)



[much boom done](https://youtu.be/ATfuFU70Pjo?t=01h50m16s)



[alright so that's the new way of doing](https://youtu.be/ATfuFU70Pjo?t=01h50m20s)



[it this changes the theme object right](https://youtu.be/ATfuFU70Pjo?t=01h50m24s)



[so it's worth noting on these theme](https://youtu.be/ATfuFU70Pjo?t=01h50m27s)



[objects you can go through and customize](https://youtu.be/ATfuFU70Pjo?t=01h50m28s)



[out all the stuff to your heart's desire](https://youtu.be/ATfuFU70Pjo?t=01h50m30s)



[all right but the the key part then is](https://youtu.be/ATfuFU70Pjo?t=01h50m33s)



[you have to call palette helper set at](https://youtu.be/ATfuFU70Pjo?t=01h50m36s)



[the end all right so let's just save](https://youtu.be/ATfuFU70Pjo?t=01h50m39s)



[this instance Alfred gets boom boom and](https://youtu.be/ATfuFU70Pjo?t=01h50m41s)



[helper and help her set theme pass in](https://youtu.be/ATfuFU70Pjo?t=01h50m49s)



[our new theme object that we just](https://youtu.be/ATfuFU70Pjo?t=01h50m55s)



[finished mutating and it deals with](https://youtu.be/ATfuFU70Pjo?t=01h50m57s)



[doing all the resource dictionary](https://youtu.be/ATfuFU70Pjo?t=01h50m59s)



[updates and propagation and all that](https://youtu.be/ATfuFU70Pjo?t=01h51m01s)



[jazz for us okay so let's see what this](https://youtu.be/ATfuFU70Pjo?t=01h51m02s)



[thing looks like so open color switch](https://youtu.be/ATfuFU70Pjo?t=01h51m05s)



[dialogue toggle light dark okay so](https://youtu.be/ATfuFU70Pjo?t=01h51m07s)



[there's that I think if we go back to](https://youtu.be/ATfuFU70Pjo?t=01h51m13s)



[main window to do let's see so](https://youtu.be/ATfuFU70Pjo?t=01h51m17s)



[[Music]](https://youtu.be/ATfuFU70Pjo?t=01h51m24s)



[dialogue theme inherit and I think we](https://youtu.be/ATfuFU70Pjo?t=01h51m27s)



[run all right I probably should have](https://youtu.be/ATfuFU70Pjo?t=01h51m32s)



[changed that on the 300 release to make](https://youtu.be/ATfuFU70Pjo?t=01h51m36s)



[that the default yeah so this is this is](https://youtu.be/ATfuFU70Pjo?t=01h51m39s)



[largely largely fixed right the the](https://youtu.be/ATfuFU70Pjo?t=01h51m47s)



[breaking change would be to switch it](https://youtu.be/ATfuFU70Pjo?t=01h51m50s)



[and make this the default value of](https://youtu.be/ATfuFU70Pjo?t=01h51m52s)



[dialogue theme](https://youtu.be/ATfuFU70Pjo?t=01h51m55s)



[so let's leave some comments and then we](https://youtu.be/ATfuFU70Pjo?t=01h52m02s)



[can close this issue to do it see this](https://youtu.be/ATfuFU70Pjo?t=01h52m04s)



[is done this is done that's done that's](https://youtu.be/ATfuFU70Pjo?t=01h52m08s)



[done okay so this has actually been](https://youtu.be/ATfuFU70Pjo?t=01h52m13s)



[fixed in the latest versions the changes](https://youtu.be/ATfuFU70Pjo?t=01h52m19s)



[needed to do it so one change the](https://youtu.be/ATfuFU70Pjo?t=01h52m28s)



[dialogue the I should say dialogue host](https://youtu.be/ATfuFU70Pjo?t=01h52m37s)



[dialogue the property to inherit the](https://youtu.be/ATfuFU70Pjo?t=01h52m43s)



[dialogue picks up the](https://youtu.be/ATfuFU70Pjo?t=01h52m53s)



[boom](https://youtu.be/ATfuFU70Pjo?t=01h53m02s)



[and then let's see what else do we do](https://youtu.be/ATfuFU70Pjo?t=01h53m06s)



[this is the wrong usual studio](https://youtu.be/ATfuFU70Pjo?t=01h53m14s)



[this guy here see change this](https://youtu.be/ATfuFU70Pjo?t=01h53m19s)



[copy and let's go here let's go here use](https://youtu.be/ATfuFU70Pjo?t=01h53m30s)



[the new theming API to change change](https://youtu.be/ATfuFU70Pjo?t=01h53m38s)



[alright okay and then example of what I](https://youtu.be/ATfuFU70Pjo?t=01h53m56s)



[did in your app](https://youtu.be/ATfuFU70Pjo?t=01h54m01s)



[I should probably be more explicit in](https://youtu.be/ATfuFU70Pjo?t=01h54m09s)



[the latest three one oh all right let's](https://youtu.be/ATfuFU70Pjo?t=01h54m12s)



[be clear about which version I test it](https://youtu.be/ATfuFU70Pjo?t=01h54m19s)



[in and then this thing here I want to](https://youtu.be/ATfuFU70Pjo?t=01h54m21s)



[give a link to the wiki so that to do](https://youtu.be/ATfuFU70Pjo?t=01h54m24s)



[advanced they mean so that other people](https://youtu.be/ATfuFU70Pjo?t=01h54m30s)



[can find this if they need to](https://youtu.be/ATfuFU70Pjo?t=01h54m34s)



[boom close a comment](https://youtu.be/ATfuFU70Pjo?t=01h54m40s)



[poof one more thing done from the three](https://youtu.be/ATfuFU70Pjo?t=01h54m46s)



[three Oh milestone we are cruising](https://youtu.be/ATfuFU70Pjo?t=01h54m48s)



[okay so filled combo box is missing I](https://youtu.be/ATfuFU70Pjo?t=01h54m53s)



[thought I saw a poll request for this](https://youtu.be/ATfuFU70Pjo?t=01h54m57s)



[maybe I need to go and look](https://youtu.be/ATfuFU70Pjo?t=01h54m58s)



[did you filled combo box which of these](https://youtu.be/ATfuFU70Pjo?t=01h55m00s)



[are in the three 100 was still](https://youtu.be/ATfuFU70Pjo?t=01h55m10s)



[outstanding with this one](https://youtu.be/ATfuFU70Pjo?t=01h55m13s)



[right so this I updated with it but](https://youtu.be/ATfuFU70Pjo?t=01h55m25s)



[there was a small issue with the](https://youtu.be/ATfuFU70Pjo?t=01h55m29s)



[background color because he used a](https://youtu.be/ATfuFU70Pjo?t=01h55m31s)



[transparent brush that's right so I did](https://youtu.be/ATfuFU70Pjo?t=01h55m33s)



[look it up it's a pretty simple](https://youtu.be/ATfuFU70Pjo?t=01h55m36s)



[algorithm to convert a brush with an](https://youtu.be/ATfuFU70Pjo?t=01h55m38s)



[alpha key into an equivalent RGB value](https://youtu.be/ATfuFU70Pjo?t=01h55m42s)



[which I believe is what we need here so](https://youtu.be/ATfuFU70Pjo?t=01h55m45s)



[I think the the ultimate fix for this is](https://youtu.be/ATfuFU70Pjo?t=01h55m47s)



[going to be a value converter that](https://youtu.be/ATfuFU70Pjo?t=01h55m50s)



[changes the transparent brush into a](https://youtu.be/ATfuFU70Pjo?t=01h55m52s)



[opaque brush and modifies the RGB value](https://youtu.be/ATfuFU70Pjo?t=01h55m58s)



[accordingly all right so let's see where](https://youtu.be/ATfuFU70Pjo?t=01h56m04s)



[is this guy](https://youtu.be/ATfuFU70Pjo?t=01h56m08s)



[pop-up boarder brush underline these](https://youtu.be/ATfuFU70Pjo?t=01h56m11s)



[guys here right so this is ultimately](https://youtu.be/ATfuFU70Pjo?t=01h56m17s)



[what's biting us is these things have](https://youtu.be/ATfuFU70Pjo?t=01h56m20s)



[transparency on them and we need to](https://youtu.be/ATfuFU70Pjo?t=01h56m23s)



[strip that out so I'm I'm sort of](https://youtu.be/ATfuFU70Pjo?t=01h56m25s)



[imagining a binding with a value](https://youtu.be/ATfuFU70Pjo?t=01h56m28s)



[converter where that goes through and](https://youtu.be/ATfuFU70Pjo?t=01h56m30s)



[updates obviously a binding can't have](https://youtu.be/ATfuFU70Pjo?t=01h56m35s)



[its source as a dynamic resource so the](https://youtu.be/ATfuFU70Pjo?t=01h56m38s)



[dynamic resource is going to need to get](https://youtu.be/ATfuFU70Pjo?t=01h56m41s)



[set on either like the tag property or](https://youtu.be/ATfuFU70Pjo?t=01h56m42s)



[an attached property and then the](https://youtu.be/ATfuFU70Pjo?t=01h56m46s)



[binding will have to point at that so](https://youtu.be/ATfuFU70Pjo?t=01h56m48s)



[we'll have to kind of daisy chain it](https://youtu.be/ATfuFU70Pjo?t=01h56m49s)



[across and I think that will that will](https://youtu.be/ATfuFU70Pjo?t=01h56m50s)



[address this and let this one merge](https://youtu.be/ATfuFU70Pjo?t=01h56m55s)



[what else is in what else is in here](https://youtu.be/ATfuFU70Pjo?t=01h56m57s)



[transparency one pop-up is open yeah](https://youtu.be/ATfuFU70Pjo?t=01h57m00s)



[this combo boxes have been a pain in the](https://youtu.be/ATfuFU70Pjo?t=01h57m05s)



[butt this whole time right I suspect](https://youtu.be/ATfuFU70Pjo?t=01h57m10s)



[part of the issue here is like so the](https://youtu.be/ATfuFU70Pjo?t=01h57m13s)



[classic mode one there is a margin](https://youtu.be/ATfuFU70Pjo?t=01h57m19s)



[around the pop-up which I assume is](https://youtu.be/ATfuFU70Pjo?t=01h57m22s)



[what's causing this to go up here and](https://youtu.be/ATfuFU70Pjo?t=01h57m24s)



[because this is specifically around the](https://youtu.be/ATfuFU70Pjo?t=01h57m27s)



[edge of the screen and pop-ups are](https://youtu.be/ATfuFU70Pjo?t=01h57m29s)



[forced onto the screen but we add a](https://youtu.be/ATfuFU70Pjo?t=01h57m31s)



[margin to it and I don't think the place](https://youtu.be/ATfuFU70Pjo?t=01h57m32s)



[up](https://youtu.be/ATfuFU70Pjo?t=01h57m34s)



[the placement callback takes that margin](https://youtu.be/ATfuFU70Pjo?t=01h57m35s)



[into account](https://youtu.be/ATfuFU70Pjo?t=01h57m38s)



[which i think is the the source of this](https://youtu.be/ATfuFU70Pjo?t=01h57m39s)



[bug which it makes sense](https://youtu.be/ATfuFU70Pjo?t=01h57m40s)



[I think the placement callback just](https://youtu.be/ATfuFU70Pjo?t=01h57m44s)



[needs to take the margin into effect](https://youtu.be/ATfuFU70Pjo?t=01h57m46s)



[honestly I'd really love to rewrite](https://youtu.be/ATfuFU70Pjo?t=01h57m47s)



[combo boxes this little hole thing that](https://youtu.be/ATfuFU70Pjo?t=01h57m49s)



[we did in the pop-up to let it look](https://youtu.be/ATfuFU70Pjo?t=01h57m52s)



[through to the control underneath has](https://youtu.be/ATfuFU70Pjo?t=01h57m55s)



[caused a huge number of bugs and whatnot](https://youtu.be/ATfuFU70Pjo?t=01h57m57s)



[I would rather put a rather than showing](https://youtu.be/ATfuFU70Pjo?t=01h58m01s)



[through into the text box down below I'd](https://youtu.be/ATfuFU70Pjo?t=01h58m05s)



[rather just put a text box in the pop-up](https://youtu.be/ATfuFU70Pjo?t=01h58m07s)



[that way we don't have to worry about](https://youtu.be/ATfuFU70Pjo?t=01h58m09s)



[sub-pixel rendering and getting the](https://youtu.be/ATfuFU70Pjo?t=01h58m11s)



[little lines showing through and if the](https://youtu.be/ATfuFU70Pjo?t=01h58m14s)



[the placement isn't perfectly right then](https://youtu.be/ATfuFU70Pjo?t=01h58m16s)



[at least it still looks normal to the](https://youtu.be/ATfuFU70Pjo?t=01h58m19s)



[end-user and they they don't see the bug](https://youtu.be/ATfuFU70Pjo?t=01h58m20s)



[so at some point I may get highly](https://youtu.be/ATfuFU70Pjo?t=01h58m22s)



[motivated and clear that out this one I](https://youtu.be/ATfuFU70Pjo?t=01h58m25s)



[need to go back to Andrey review](https://youtu.be/ATfuFU70Pjo?t=01h58m29s)



[this one is an interesting one yeah](https://youtu.be/ATfuFU70Pjo?t=01h58m33s)



[because this guy put a very good](https://youtu.be/ATfuFU70Pjo?t=01h58m40s)



[write-up on it](https://youtu.be/ATfuFU70Pjo?t=01h58m42s)



[and ultimately I just need to go back](https://youtu.be/ATfuFU70Pjo?t=01h58m44s)



[and and look at this especially since he](https://youtu.be/ATfuFU70Pjo?t=01h58m46s)



[was able to track down exactly where the](https://youtu.be/ATfuFU70Pjo?t=01h58m49s)



[problem was it would be good to get this](https://youtu.be/ATfuFU70Pjo?t=01h58m51s)



[evaluated and put in basically I suspect](https://youtu.be/ATfuFU70Pjo?t=01h58m53s)



[what's happening is on remote desktop](https://youtu.be/ATfuFU70Pjo?t=01h58m59s)



[Windows tends to turn off a lot of the](https://youtu.be/ATfuFU70Pjo?t=01h59m01s)



[windowing features and I'm guessing](https://youtu.be/ATfuFU70Pjo?t=01h59m03s)



[inside of our dialog again guessing I'm](https://youtu.be/ATfuFU70Pjo?t=01h59m05s)



[guessing inside of our dialog host we're](https://youtu.be/ATfuFU70Pjo?t=01h59m08s)



[making assumptions about the the order](https://youtu.be/ATfuFU70Pjo?t=01h59m10s)



[and the count that these events are](https://youtu.be/ATfuFU70Pjo?t=01h59m12s)



[going to get raised and that may not](https://youtu.be/ATfuFU70Pjo?t=01h59m14s)



[always be true if the window and events](https://youtu.be/ATfuFU70Pjo?t=01h59m15s)



[aren't flowing correctly or you know](https://youtu.be/ATfuFU70Pjo?t=01h59m18s)



[turned off right I suspect you can get a](https://youtu.be/ATfuFU70Pjo?t=01h59m21s)



[similar behavior you can go through and](https://youtu.be/ATfuFU70Pjo?t=01h59m23s)



[turn off most of the graphics animation](https://youtu.be/ATfuFU70Pjo?t=01h59m25s)



[stuff inside of normal desktop and get](https://youtu.be/ATfuFU70Pjo?t=01h59m29s)



[yourself pretty close to this and](https://youtu.be/ATfuFU70Pjo?t=01h59m31s)



[sometimes replicate remote desktop bugs](https://youtu.be/ATfuFU70Pjo?t=01h59m33s)



[don't know if that would do it here but](https://youtu.be/ATfuFU70Pjo?t=01h59m36s)



[it appears he's already done the](https://youtu.be/ATfuFU70Pjo?t=01h59m38s)



[debugging for us which is awesome so](https://youtu.be/ATfuFU70Pjo?t=01h59m39s)



[thank you very much](https://youtu.be/ATfuFU70Pjo?t=01h59m42s)



[Aubrey I think maybe](https://youtu.be/ATfuFU70Pjo?t=01h59m45s)



[so yeah so I think I think that's where](https://youtu.be/ATfuFU70Pjo?t=01h59m49s)



[we're going](https://youtu.be/ATfuFU70Pjo?t=01h59m51s)



[I'd like to evaluate the rest of these](https://youtu.be/ATfuFU70Pjo?t=01h59m52s)



[things and fonts are various sizes all](https://youtu.be/ATfuFU70Pjo?t=01h59m54s)



[over the place oh yeah this is probably](https://youtu.be/ATfuFU70Pjo?t=01h59m59s)



[something I broke and a lot of these if](https://youtu.be/ATfuFU70Pjo?t=02h00m04s)



[somebody just wants to evaluate what](https://youtu.be/ATfuFU70Pjo?t=02h00m07s)



[broken why that'd be great](https://youtu.be/ATfuFU70Pjo?t=02h00m10s)



[I do appreciate all the help I know](https://youtu.be/ATfuFU70Pjo?t=02h00m12s)



[people have been doing an amazing job](https://youtu.be/ATfuFU70Pjo?t=02h00m14s)



[coming and fixing it because I think I'm](https://youtu.be/ATfuFU70Pjo?t=02h00m16s)



[not likely to pull too many more things](https://youtu.be/ATfuFU70Pjo?t=02h00m18s)



[into the three ovary or the three one](https://youtu.be/ATfuFU70Pjo?t=02h00m21s)



[release I think I want to just get this](https://youtu.be/ATfuFU70Pjo?t=02h00m23s)



[thing stabilized and kicked out the door](https://youtu.be/ATfuFU70Pjo?t=02h00m25s)



[no point making it wait this guy here I](https://youtu.be/ATfuFU70Pjo?t=02h00m26s)



[wanted to take a look at yeah I might](https://youtu.be/ATfuFU70Pjo?t=02h00m30s)



[just need to clean some of this up](https://youtu.be/ATfuFU70Pjo?t=02h00m36s)



[because I'm guessing this was done](https://youtu.be/ATfuFU70Pjo?t=02h00m38s)



[before a lot of the reef actors which I](https://youtu.be/ATfuFU70Pjo?t=02h00m39s)



[don't think it'll be that big of a deal](https://youtu.be/ATfuFU70Pjo?t=02h00m41s)



[to merge yeah it's probably not that big](https://youtu.be/ATfuFU70Pjo?t=02h00m43s)



[of a deal to bring this in so get some](https://youtu.be/ATfuFU70Pjo?t=02h00m46s)



[of those cleaned up and get that kick](https://youtu.be/ATfuFU70Pjo?t=02h00m50s)



[through so with that I think I'm](https://youtu.be/ATfuFU70Pjo?t=02h00m51s)



[probably gonna sign off for the night](https://youtu.be/ATfuFU70Pjo?t=02h00m54s)



[I've got a bunch of stuff I need to do](https://youtu.be/ATfuFU70Pjo?t=02h00m55s)



[and things to catch up on so I will say](https://youtu.be/ATfuFU70Pjo?t=02h00m57s)



[happy coding and I'll see everyone next](https://youtu.be/ATfuFU70Pjo?t=02h00m59s)



[week thanks](https://youtu.be/ATfuFU70Pjo?t=02h01m01s)



[you](https://youtu.be/ATfuFU70Pjo?t=02h01m12s)


