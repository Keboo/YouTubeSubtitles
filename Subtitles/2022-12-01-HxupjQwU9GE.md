[YouTube Video](https://youtu.be/HxupjQwU9GE)



[hello everyone welcome back uh fair](https://youtu.be/HxupjQwU9GE?t=00h00m01s)

[warning tonight I got a new camera in](https://youtu.be/HxupjQwU9GE?t=00h00m04s)

[the mail today so naturally I plugged it](https://youtu.be/HxupjQwU9GE?t=00h00m07s)

[in and tried to play with it](https://youtu.be/HxupjQwU9GE?t=00h00m08s)

[I don't think I quite got everything](https://youtu.be/HxupjQwU9GE?t=00h00m10s)

[configured but we're going with it](https://youtu.be/HxupjQwU9GE?t=00h00m12s)

[because once I started unplugging the](https://youtu.be/HxupjQwU9GE?t=00h00m13s)

[old stuff and plugging in the new stuff](https://youtu.be/HxupjQwU9GE?t=00h00m15s)

[I was kind of committed and figured why](https://youtu.be/HxupjQwU9GE?t=00h00m16s)

[not let's do it](https://youtu.be/HxupjQwU9GE?t=00h00m19s)

[so uh tonight I was gonna go and kind of](https://youtu.be/HxupjQwU9GE?t=00h00m20s)

[poke at a project that I mentioned in](https://youtu.be/HxupjQwU9GE?t=00h00m23s)

[the past](https://youtu.be/HxupjQwU9GE?t=00h00m26s)

[um there's a thing called Microsoft](https://youtu.be/HxupjQwU9GE?t=00h00m27s)

[Orleans which we'll take a look at in a](https://youtu.be/HxupjQwU9GE?t=00h00m28s)

[little bit](https://youtu.be/HxupjQwU9GE?t=00h00m30s)

[um but really wanting to deploy out and](https://youtu.be/HxupjQwU9GE?t=00h00m31s)

[more importantly see what the](https://youtu.be/HxupjQwU9GE?t=00h00m34s)

[performance looks like so this is not](https://youtu.be/HxupjQwU9GE?t=00h00m36s)

[something I normally do so this is going](https://youtu.be/HxupjQwU9GE?t=00h00m38s)

[to be a learning experience for all of](https://youtu.be/HxupjQwU9GE?t=00h00m39s)

[us](https://youtu.be/HxupjQwU9GE?t=00h00m41s)

[great so let's go ahead and dive in](https://youtu.be/HxupjQwU9GE?t=00h00m42s)

[so for those people interested here is a](https://youtu.be/HxupjQwU9GE?t=00h00m48s)

[a link to Orleans](https://youtu.be/HxupjQwU9GE?t=00h00m51s)

[and I've shared this page before and](https://youtu.be/HxupjQwU9GE?t=00h00m54s)

[one of the the biggest drawbacks to](https://youtu.be/HxupjQwU9GE?t=00h00m57s)

[Orleans is I don't know if this is](https://youtu.be/HxupjQwU9GE?t=00h00m59s)

[really clear of what it is or when you](https://youtu.be/HxupjQwU9GE?t=00h01m01s)

[would use it like this is](https://youtu.be/HxupjQwU9GE?t=00h01m03s)

[kind of the the Crux of the problem with](https://youtu.be/HxupjQwU9GE?t=00h01m05s)

[a lot of the Orleans stuff is it's sorry](https://youtu.be/HxupjQwU9GE?t=00h01m07s)

[one second](https://youtu.be/HxupjQwU9GE?t=00h01m10s)

[deal with my lighting and this is the](https://youtu.be/HxupjQwU9GE?t=00h01m13s)

[drawbacks of new camera setup and not](https://youtu.be/HxupjQwU9GE?t=00h01m16s)

[having things dialed in yet](https://youtu.be/HxupjQwU9GE?t=00h01m18s)

[um](https://youtu.be/HxupjQwU9GE?t=00h01m20s)

[is it's designed to be a highly](https://youtu.be/HxupjQwU9GE?t=00h01m21s)

[distributed system and I I'm not very](https://youtu.be/HxupjQwU9GE?t=00h01m23s)

[familiar with it but my understanding is](https://youtu.be/HxupjQwU9GE?t=00h01m27s)

[it's trying to take a lot of the](https://youtu.be/HxupjQwU9GE?t=00h01m29s)

[complexity of doing large distributed](https://youtu.be/HxupjQwU9GE?t=00h01m31s)

[applications](https://youtu.be/HxupjQwU9GE?t=00h01m33s)

[um and hide that away from you so that](https://youtu.be/HxupjQwU9GE?t=00h01m35s)

[you don't have to worry about a lot of](https://youtu.be/HxupjQwU9GE?t=00h01m37s)

[it and you can focus on what is actually](https://youtu.be/HxupjQwU9GE?t=00h01m39s)

[important so the nice part though is we](https://youtu.be/HxupjQwU9GE?t=00h01m42s)

[don't actually need to know a ton about](https://youtu.be/HxupjQwU9GE?t=00h01m45s)

[uh Orleans to get up and running which](https://youtu.be/HxupjQwU9GE?t=00h01m47s)

[is great so I forked The the.net Orleans](https://youtu.be/HxupjQwU9GE?t=00h01m50s)

[repository I've made no changes in my](https://youtu.be/HxupjQwU9GE?t=00h01m53s)

[Fork I just made one of mine and you can](https://youtu.be/HxupjQwU9GE?t=00h01m56s)

[see I'm already 10 commits behind which](https://youtu.be/HxupjQwU9GE?t=00h01m58s)

[oh boy](https://youtu.be/HxupjQwU9GE?t=00h02m00s)

[um but more importantly they've got this](https://youtu.be/HxupjQwU9GE?t=00h02m02s)

[lovely samples](https://youtu.be/HxupjQwU9GE?t=00h02m04s)

[folder which is quite cool and I wanted](https://youtu.be/HxupjQwU9GE?t=00h02m06s)

[to play around with this voting sample](https://youtu.be/HxupjQwU9GE?t=00h02m08s)

[that they have so there's a couple](https://youtu.be/HxupjQwU9GE?t=00h02m11s)

[things that it goes through and does](https://youtu.be/HxupjQwU9GE?t=00h02m12s)

[it's supposed to look something like](https://youtu.be/HxupjQwU9GE?t=00h02m14s)

[this](https://youtu.be/HxupjQwU9GE?t=00h02m15s)

[um but each of these samples tries to](https://youtu.be/HxupjQwU9GE?t=00h02m17s)

[show off something a little bit](https://youtu.be/HxupjQwU9GE?t=00h02m19s)

[different I kind of wish this image of](https://youtu.be/HxupjQwU9GE?t=00h02m20s)

[the dashboard wasn't broken](https://youtu.be/HxupjQwU9GE?t=00h02m22s)

[we may go we may go see if we can figure](https://youtu.be/HxupjQwU9GE?t=00h02m24s)

[out what it was pointed dashboard.png is](https://youtu.be/HxupjQwU9GE?t=00h02m26s)

[that just missing](https://youtu.be/HxupjQwU9GE?t=00h02m29s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h02m31s)

[it might just be missing](https://youtu.be/HxupjQwU9GE?t=00h02m33s)

[because I don't see it in here](https://youtu.be/HxupjQwU9GE?t=00h02m38s)

[disappointing](https://youtu.be/HxupjQwU9GE?t=00h02m39s)

[um](https://youtu.be/HxupjQwU9GE?t=00h02m42s)

[but this one also shows off uh doing a](https://youtu.be/HxupjQwU9GE?t=00h02m43s)

[kubernetes deployment so I'm not going](https://youtu.be/HxupjQwU9GE?t=00h02m47s)

[to dive too deep into kubernetes tonight](https://youtu.be/HxupjQwU9GE?t=00h02m50s)

[though that is an area that I've often](https://youtu.be/HxupjQwU9GE?t=00h02m51s)

[contemplated doing uh some streams on so](https://youtu.be/HxupjQwU9GE?t=00h02m54s)

[containerization deploying now there's a](https://youtu.be/HxupjQwU9GE?t=00h02m57s)

[lot of fancy industry buzzwords in that](https://youtu.be/HxupjQwU9GE?t=00h02m59s)

[which](https://youtu.be/HxupjQwU9GE?t=00h03m01s)

[always gets people excited uh](https://youtu.be/HxupjQwU9GE?t=00h03m02s)

[in my mind it's not overly complex the](https://youtu.be/HxupjQwU9GE?t=00h03m05s)

[the key thing here is they've actually](https://youtu.be/HxupjQwU9GE?t=00h03m08s)

[gone to the effort of doing most of the](https://youtu.be/HxupjQwU9GE?t=00h03m12s)

[work so they've got a Powershell script](https://youtu.be/HxupjQwU9GE?t=00h03m13s)

[inside of this voting one where you just](https://youtu.be/HxupjQwU9GE?t=00h03m16s)

[need to provide out some of the](https://youtu.be/HxupjQwU9GE?t=00h03m19s)

[information and then using the Azure CLI](https://youtu.be/HxupjQwU9GE?t=00h03m20s)

[and some tools Docker Cube cuddle uh](https://youtu.be/HxupjQwU9GE?t=00h03m23s)

[it should should just work](https://youtu.be/HxupjQwU9GE?t=00h03m28s)

[we'll see how the uh should just work](https://youtu.be/HxupjQwU9GE?t=00h03m32s)

[bit goes](https://youtu.be/HxupjQwU9GE?t=00h03m34s)

[um I did go to the effort of sorry one](https://youtu.be/HxupjQwU9GE?t=00h03m35s)

[second](https://youtu.be/HxupjQwU9GE?t=00h03m39s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h03m40s)

[okay boom there we go and we'll make](https://youtu.be/HxupjQwU9GE?t=00h03m43s)

[this bigger so I did go to the effort of](https://youtu.be/HxupjQwU9GE?t=00h03m46s)

[spinning a resource Group out in Azure](https://youtu.be/HxupjQwU9GE?t=00h03m48s)

[and I spun this itty bitty little](https://youtu.be/HxupjQwU9GE?t=00h03m50s)

[cluster emphasis on itty bitty this is](https://youtu.be/HxupjQwU9GE?t=00h03m52s)

[not a big cluster these things are not](https://youtu.be/HxupjQwU9GE?t=00h03m55s)

[big so for those people who know nothing](https://youtu.be/HxupjQwU9GE?t=00h03m58s)

[of kubernetes uh brief primer it's a](https://youtu.be/HxupjQwU9GE?t=00h04m00s)

[system for managing deployment of](https://youtu.be/HxupjQwU9GE?t=00h04m04s)

[applications onto a bunch of VMS](https://youtu.be/HxupjQwU9GE?t=00h04m06s)

[they're they're I'm obviously skimming](https://youtu.be/HxupjQwU9GE?t=00h04m09s)

[over a ton of details but just assume](https://youtu.be/HxupjQwU9GE?t=00h04m11s)

[that like that's its job](https://youtu.be/HxupjQwU9GE?t=00h04m13s)

[um and the the key thing here to note is](https://youtu.be/HxupjQwU9GE?t=00h04m15s)

[underneath](https://youtu.be/HxupjQwU9GE?t=00h04m17s)

[um AKs there is what is called a VM](https://youtu.be/HxupjQwU9GE?t=00h04m19s)

[skill set or vmss and that's where these](https://youtu.be/HxupjQwU9GE?t=00h04m22s)

[agent pools come from they are](https://youtu.be/HxupjQwU9GE?t=00h04m25s)

[effectively the uh the compute power](https://youtu.be/HxupjQwU9GE?t=00h04m27s)

[behind all of these things and you can](https://youtu.be/HxupjQwU9GE?t=00h04m31s)

[see that the the size of each of these](https://youtu.be/HxupjQwU9GE?t=00h04m33s)

[itty bitty VMS that I have in my pool](https://youtu.be/HxupjQwU9GE?t=00h04m35s)

[are just b2ms these are not very big](https://youtu.be/HxupjQwU9GE?t=00h04m37s)

[uh let's see I was hoping it would show](https://youtu.be/HxupjQwU9GE?t=00h04m42s)

[me](https://youtu.be/HxupjQwU9GE?t=00h04m45s)

[I'm gonna show me what these were](https://youtu.be/HxupjQwU9GE?t=00h04m46s)

[because I don't quite remember the exact](https://youtu.be/HxupjQwU9GE?t=00h04m48s)

[well we can just search](https://youtu.be/HxupjQwU9GE?t=00h04m51s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h04m54s)

[uh yeah that'll probably work good](https://youtu.be/HxupjQwU9GE?t=00h04m56s)

[enough show me show me the sizes](https://youtu.be/HxupjQwU9GE?t=00h04m58s)

[uh key things](https://youtu.be/HxupjQwU9GE?t=00h05m02s)

[eight gigs of memory two vcpus](https://youtu.be/HxupjQwU9GE?t=00h05m05s)

[so not huge](https://youtu.be/HxupjQwU9GE?t=00h05m08s)

[um the other thing is I do have these](https://youtu.be/HxupjQwU9GE?t=00h05m11s)

[things set to Auto scale but they only](https://youtu.be/HxupjQwU9GE?t=00h05m13s)

[scale between one and two VMS](https://youtu.be/HxupjQwU9GE?t=00h05m16s)

[so they aren't very big to begin oh](https://youtu.be/HxupjQwU9GE?t=00h05m19s)

[there's the chorus and the memory](https://youtu.be/HxupjQwU9GE?t=00h05m21s)

[um they aren't very big uh to begin with](https://youtu.be/HxupjQwU9GE?t=00h05m24s)

[and there's only they're only going to](https://youtu.be/HxupjQwU9GE?t=00h05m27s)

[double in size so I don't want this](https://youtu.be/HxupjQwU9GE?t=00h05m29s)

[thing to get big I kind of want to know](https://youtu.be/HxupjQwU9GE?t=00h05m30s)

[how far I can push](https://youtu.be/HxupjQwU9GE?t=00h05m32s)

[something on a small amount of Hardware](https://youtu.be/HxupjQwU9GE?t=00h05m34s)

[that's that's kind of the goal of what](https://youtu.be/HxupjQwU9GE?t=00h05m36s)

[we're looking for](https://youtu.be/HxupjQwU9GE?t=00h05m38s)

[before we burn through all my credits so](https://youtu.be/HxupjQwU9GE?t=00h05m39s)

[that that's kind of what I want to test](https://youtu.be/HxupjQwU9GE?t=00h05m41s)

[the other thing that I was going to play](https://youtu.be/HxupjQwU9GE?t=00h05m44s)

[with is this thing called Locus which is](https://youtu.be/HxupjQwU9GE?t=00h05m45s)

[a](https://youtu.be/HxupjQwU9GE?t=00h05m48s)

[um](https://youtu.be/HxupjQwU9GE?t=00h05m50s)

[a simple way of doing some uh load](https://youtu.be/HxupjQwU9GE?t=00h05m51s)

[testing now this is a system again don't](https://youtu.be/HxupjQwU9GE?t=00h05m54s)

[have a lot of experience with it was](https://youtu.be/HxupjQwU9GE?t=00h05m58s)

[recommended and I went sure let's let's](https://youtu.be/HxupjQwU9GE?t=00h05m59s)

[give it a shot that sounds like fun so](https://youtu.be/HxupjQwU9GE?t=00h06m02s)

[we're gonna do that so we're gonna try a](https://youtu.be/HxupjQwU9GE?t=00h06m04s)

[little python but first let's see if we](https://youtu.be/HxupjQwU9GE?t=00h06m07s)

[can get this guy](https://youtu.be/HxupjQwU9GE?t=00h06m09s)

[deployed out so](https://youtu.be/HxupjQwU9GE?t=00h06m11s)

[I'm already in my Orleans repository so](https://youtu.be/HxupjQwU9GE?t=00h06m14s)

[let's go samples](https://youtu.be/HxupjQwU9GE?t=00h06m17s)

[and then let's go voting and then let's](https://youtu.be/HxupjQwU9GE?t=00h06m19s)

[go take a brief look at this script real](https://youtu.be/HxupjQwU9GE?t=00h06m23s)

[quick](https://youtu.be/HxupjQwU9GE?t=00h06m25s)

[this virtual machine is better than my](https://youtu.be/HxupjQwU9GE?t=00h06m27s)

[old laptop yeah that is one of the nice](https://youtu.be/HxupjQwU9GE?t=00h06m29s)

[Parts about playing in the cloud is you](https://youtu.be/HxupjQwU9GE?t=00h06m32s)

[can go big really fast and you can also](https://youtu.be/HxupjQwU9GE?t=00h06m35s)

[pay for it very fast](https://youtu.be/HxupjQwU9GE?t=00h06m37s)

[um which is part of why I'm playing on](https://youtu.be/HxupjQwU9GE?t=00h06m40s)

[an Azure subscription that's on a what](https://youtu.be/HxupjQwU9GE?t=00h06m42s)

[do they call it an msdn subscription](https://youtu.be/HxupjQwU9GE?t=00h06m46s)

[that has uh some free credits every](https://youtu.be/HxupjQwU9GE?t=00h06m48s)

[month because if I accidentally mess up](https://youtu.be/HxupjQwU9GE?t=00h06m50s)

[I burn through all my credits I the the](https://youtu.be/HxupjQwU9GE?t=00h06m53s)

[account just gets frozen until till the](https://youtu.be/HxupjQwU9GE?t=00h06m56s)

[month resets and then we move on so uh](https://youtu.be/HxupjQwU9GE?t=00h06m59s)

[okay so for those people I'm familiar](https://youtu.be/HxupjQwU9GE?t=00h07m02s)

[with the AZ command is the Azure CLI](https://youtu.be/HxupjQwU9GE?t=00h07m05s)

[so all this is doing is looking up the](https://youtu.be/HxupjQwU9GE?t=00h07m08s)

[ACR information](https://youtu.be/HxupjQwU9GE?t=00h07m10s)

[which is fine it's logging into the ACR](https://youtu.be/HxupjQwU9GE?t=00h07m12s)

[it's going to do a Docker build which](https://youtu.be/HxupjQwU9GE?t=00h07m15s)

[probably means I need to make sure I](https://youtu.be/HxupjQwU9GE?t=00h07m17s)

[actually have darker running so we'll](https://youtu.be/HxupjQwU9GE?t=00h07m19s)

[turn Docker on because that'll be](https://youtu.be/HxupjQwU9GE?t=00h07m21s)

[important](https://youtu.be/HxupjQwU9GE?t=00h07m22s)

[so it's going to build up a container](https://youtu.be/HxupjQwU9GE?t=00h07m23s)

[for this guy so this app which I haven't](https://youtu.be/HxupjQwU9GE?t=00h07m27s)

[hardly even looked at this application I](https://youtu.be/HxupjQwU9GE?t=00h07m29s)

[know it's an asp.net core application](https://youtu.be/HxupjQwU9GE?t=00h07m31s)

[and it references](https://youtu.be/HxupjQwU9GE?t=00h07m33s)

[or leads that that's it that's that's](https://youtu.be/HxupjQwU9GE?t=00h07m35s)

[the subtotal of what I know](https://youtu.be/HxupjQwU9GE?t=00h07m37s)

[um and you know what the readme showed](https://youtu.be/HxupjQwU9GE?t=00h07m40s)

[uh and then it uses uh Cube control or](https://youtu.be/HxupjQwU9GE?t=00h07m42s)

[as one of my colleagues once called it](https://youtu.be/HxupjQwU9GE?t=00h07m46s)

[Cube cuddle and I haven't been able to](https://youtu.be/HxupjQwU9GE?t=00h07m47s)

[unsee that since so](https://youtu.be/HxupjQwU9GE?t=00h07m50s)

[you'll probably hear me call that Cube](https://youtu.be/HxupjQwU9GE?t=00h07m52s)

[cuddle but I think they're they're the](https://youtu.be/HxupjQwU9GE?t=00h07m54s)

[real developers call it Cube control](https://youtu.be/HxupjQwU9GE?t=00h07m56s)

[um and for again just brief primer on](https://youtu.be/HxupjQwU9GE?t=00h07m59s)

[kubernetes kubernetes deploys out](https://youtu.be/HxupjQwU9GE?t=00h08m01s)

[Resources with yaml files so](https://youtu.be/HxupjQwU9GE?t=00h08m04s)

[this just declares all of the stuff that](https://youtu.be/HxupjQwU9GE?t=00h08m08s)

[needs to go out in order to make this](https://youtu.be/HxupjQwU9GE?t=00h08m11s)

[app run so there's a redis thing that](https://youtu.be/HxupjQwU9GE?t=00h08m13s)

[goes out services are kind of like your](https://youtu.be/HxupjQwU9GE?t=00h08m16s)

[uh gateways for networking and mapping](https://youtu.be/HxupjQwU9GE?t=00h08m19s)

[stuff there's the actual deployment for](https://youtu.be/HxupjQwU9GE?t=00h08m21s)

[the app itself](https://youtu.be/HxupjQwU9GE?t=00h08m23s)

[great](https://youtu.be/HxupjQwU9GE?t=00h08m25s)

[um I'm a little surprised this](https://youtu.be/HxupjQwU9GE?t=00h08m28s)

[I'm gonna have to change where this is](https://youtu.be/HxupjQwU9GE?t=00h08m33s)

[pointed won't I](https://youtu.be/HxupjQwU9GE?t=00h08m35s)

[um](https://youtu.be/HxupjQwU9GE?t=00h08m38s)

[their script doesn't change that image](https://youtu.be/HxupjQwU9GE?t=00h08m39s)

[does it](https://youtu.be/HxupjQwU9GE?t=00h08m41s)

[no](https://youtu.be/HxupjQwU9GE?t=00h08m43s)

[it's nice that they've bothered to do](https://youtu.be/HxupjQwU9GE?t=00h08m45s)

[this but I think](https://youtu.be/HxupjQwU9GE?t=00h08m47s)

[I wonder did they document that](https://youtu.be/HxupjQwU9GE?t=00h08m50s)

['d be a little disappointing if they](https://youtu.be/HxupjQwU9GE?t=00h08m52s)

[didn't](https://youtu.be/HxupjQwU9GE?t=00h08m54s)

[um the provision PS attempts to](https://youtu.be/HxupjQwU9GE?t=00h08m55s)

[automatic with some required names](https://youtu.be/HxupjQwU9GE?t=00h08m57s)

[uh also worth noting](https://youtu.be/HxupjQwU9GE?t=00h09m01s)

[this is not the same set of stuff steps](https://youtu.be/HxupjQwU9GE?t=00h09m05s)

[as what is in oh provision oh there's](https://youtu.be/HxupjQwU9GE?t=00h09m09s)

[two scripts I missed the other one hang](https://youtu.be/HxupjQwU9GE?t=00h09m12s)

[on hang on there's deploy ah there's](https://youtu.be/HxupjQwU9GE?t=00h09m14s)

[provision okay](https://youtu.be/HxupjQwU9GE?t=00h09m17s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h09m19s)

[readings op okay](https://youtu.be/HxupjQwU9GE?t=00h09m21s)

[uh defined at the top of scripts](https://youtu.be/HxupjQwU9GE?t=00h09m23s)

[backstage of the steps in a Powershell](https://youtu.be/HxupjQwU9GE?t=00h09m25s)

[terminal one by one since the script](https://youtu.be/HxupjQwU9GE?t=00h09m28s)

[performs no error handling](https://youtu.be/HxupjQwU9GE?t=00h09m30s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h09m33s)

[uh yeah we might just fire in the hole](https://youtu.be/HxupjQwU9GE?t=00h09m35s)

[uh and if it dies we'll figure it out](https://youtu.be/HxupjQwU9GE?t=00h09m37s)

[so create a resource Group oh so](https://youtu.be/HxupjQwU9GE?t=00h09m40s)

[oh we tried to do all of the AKs stuff](https://youtu.be/HxupjQwU9GE?t=00h09m43s)

[for me](https://youtu.be/HxupjQwU9GE?t=00h09m45s)

[whoopsie](https://youtu.be/HxupjQwU9GE?t=00h09m47s)

[uh yeah so we're gonna do maybe we won't](https://youtu.be/HxupjQwU9GE?t=00h09m50s)

[just run the script because I'm gonna](https://youtu.be/HxupjQwU9GE?t=00h09m53s)

[need to do some of this stuff](https://youtu.be/HxupjQwU9GE?t=00h09m54s)

[by hand](https://youtu.be/HxupjQwU9GE?t=00h09m56s)

[with those things in mind uh](https://youtu.be/HxupjQwU9GE?t=00h09m58s)

[uh look for the pound replacement](https://youtu.be/HxupjQwU9GE?t=00h10m02s)

[comments inside of here ah so that's](https://youtu.be/HxupjQwU9GE?t=00h10m04s)

[what I was missing so inside here I need](https://youtu.be/HxupjQwU9GE?t=00h10m07s)

[to search](https://youtu.be/HxupjQwU9GE?t=00h10m09s)

[found](https://youtu.be/HxupjQwU9GE?t=00h10m10s)

[oh](https://youtu.be/HxupjQwU9GE?t=00h10m12s)

[somebody](https://youtu.be/HxupjQwU9GE?t=00h10m16s)

[messed something up](https://youtu.be/HxupjQwU9GE?t=00h10m20s)

[because](https://youtu.be/HxupjQwU9GE?t=00h10m23s)

[I don't know about you but](https://youtu.be/HxupjQwU9GE?t=00h10m30s)

[I don't see replace me on the end of](https://youtu.be/HxupjQwU9GE?t=00h10m33s)

[these things](https://youtu.be/HxupjQwU9GE?t=00h10m36s)

[so somebody may have dropped the](https://youtu.be/HxupjQwU9GE?t=00h10m38s)

[replacements](https://youtu.be/HxupjQwU9GE?t=00h10m40s)

[see](https://youtu.be/HxupjQwU9GE?t=00h10m42s)

[okay and then the file is large and](https://youtu.be/HxupjQwU9GE?t=00h10m44s)

[could be intimidating and it's a big](https://youtu.be/HxupjQwU9GE?t=00h10m47s)

[block of yaml](https://youtu.be/HxupjQwU9GE?t=00h10m48s)

[um yaml's ugly but I don't know if I](https://youtu.be/HxupjQwU9GE?t=00h10m50s)

[would call it intimidating uh execute](https://youtu.be/HxupjQwU9GE?t=00h10m52s)

[the following to build and launch okay](https://youtu.be/HxupjQwU9GE?t=00h10m54s)

[okay so we got to do the provisioning](https://youtu.be/HxupjQwU9GE?t=00h10m58s)

[thing first to get some variables set up](https://youtu.be/HxupjQwU9GE?t=00h11m00s)

[and then we got to do the deploy thingy](https://youtu.be/HxupjQwU9GE?t=00h11m02s)

[to make it go](https://youtu.be/HxupjQwU9GE?t=00h11m05s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h11m06s)

[seems simple](https://youtu.be/HxupjQwU9GE?t=00h11m07s)

[um](https://youtu.be/HxupjQwU9GE?t=00h11m10s)

[one other thing that I'm noticing](https://youtu.be/HxupjQwU9GE?t=00h11m12s)

[does this do](https://youtu.be/HxupjQwU9GE?t=00h11m15s)

[kind of want to look at their Docker](https://youtu.be/HxupjQwU9GE?t=00h11m18s)

[file real quick](https://youtu.be/HxupjQwU9GE?t=00h11m20s)

[ah okay so they're going to compile](https://youtu.be/HxupjQwU9GE?t=00h11m22s)

[inside the container got it cool cool](https://youtu.be/HxupjQwU9GE?t=00h11m24s)

[I was wondering what was actually going](https://youtu.be/HxupjQwU9GE?t=00h11m26s)

[to build and publish the app](https://youtu.be/HxupjQwU9GE?t=00h11m28s)

[uh apparently their Docker file do it](https://youtu.be/HxupjQwU9GE?t=00h11m30s)

[does it themselves so uh brief brief](https://youtu.be/HxupjQwU9GE?t=00h11m33s)

[primer on darker files and](https://youtu.be/HxupjQwU9GE?t=00h11m36s)

[containerization for people unfamiliar](https://youtu.be/HxupjQwU9GE?t=00h11m37s)

[with it there's an old joke where the](https://youtu.be/HxupjQwU9GE?t=00h11m39s)

[developer uh tells his manager it works](https://youtu.be/HxupjQwU9GE?t=00h11m42s)

[on my box and the manager replies well](https://youtu.be/HxupjQwU9GE?t=00h11m44s)

[fine then we'll just ship your box out](https://youtu.be/HxupjQwU9GE?t=00h11m46s)

[to all of the clients](https://youtu.be/HxupjQwU9GE?t=00h11m48s)

[uh Docker is effectively an Enterprise](https://youtu.be/HxupjQwU9GE?t=00h11m50s)

[grade solution like that it allows the](https://youtu.be/HxupjQwU9GE?t=00h11m52s)

[the developer system because quite often](https://youtu.be/HxupjQwU9GE?t=00h11m55s)

[developers have all kinds of tools](https://youtu.be/HxupjQwU9GE?t=00h11m57s)

[installed](https://youtu.be/HxupjQwU9GE?t=00h11m59s)

[um to be to be codified and effectively](https://youtu.be/HxupjQwU9GE?t=00h12m00s)

[the operating system abstracted away](https://youtu.be/HxupjQwU9GE?t=00h12m03s)

[from the running application](https://youtu.be/HxupjQwU9GE?t=00h12m05s)

[so you can almost think of this as](https://youtu.be/HxupjQwU9GE?t=00h12m07s)

[defining the environment under which](https://youtu.be/HxupjQwU9GE?t=00h12m09s)

[your app needs to run and then codifying](https://youtu.be/HxupjQwU9GE?t=00h12m11s)

[that so you can just you know put it in](https://youtu.be/HxupjQwU9GE?t=00h12m14s)

[a box or a container as it were and you](https://youtu.be/HxupjQwU9GE?t=00h12m16s)

[know stamp that and deploy it out](https://youtu.be/HxupjQwU9GE?t=00h12m18s)

[everywhere](https://youtu.be/HxupjQwU9GE?t=00h12m20s)

[okay so let's go back and let's let's](https://youtu.be/HxupjQwU9GE?t=00h12m21s)

[execute provision so AZ login uh](https://youtu.be/HxupjQwU9GE?t=00h12m24s)

[maybe we can start there but I'm pretty](https://youtu.be/HxupjQwU9GE?t=00h12m30s)

[sure I'm already logged in](https://youtu.be/HxupjQwU9GE?t=00h12m32s)

[so two two hold that thought I'm gonna](https://youtu.be/HxupjQwU9GE?t=00h12m33s)

[just move this over to here and I'm](https://youtu.be/HxupjQwU9GE?t=00h12m36s)

[gonna just take this and just slide it](https://youtu.be/HxupjQwU9GE?t=00h12m38s)

[over here uno momento so short version](https://youtu.be/HxupjQwU9GE?t=00h12m40s)

[do the needful to log in](https://youtu.be/HxupjQwU9GE?t=00h12m43s)

[and then real quick I'm going to do one](https://youtu.be/HxupjQwU9GE?t=00h12m50s)

[extra step that they didn't call out](https://youtu.be/HxupjQwU9GE?t=00h12m53s)

[here where I just pin my subscription to](https://youtu.be/HxupjQwU9GE?t=00h12m55s)

[the right one](https://youtu.be/HxupjQwU9GE?t=00h12m59s)

[uh let's see here](https://youtu.be/HxupjQwU9GE?t=00h13m00s)

[AZ account](https://youtu.be/HxupjQwU9GE?t=00h13m03s)

[open something something I gotta](https://youtu.be/HxupjQwU9GE?t=00h13m05s)

[remember the command](https://youtu.be/HxupjQwU9GE?t=00h13m07s)

[uh the account Set uh dash s paste](https://youtu.be/HxupjQwU9GE?t=00h13m10s)

[subscription IDs](https://youtu.be/HxupjQwU9GE?t=00h13m14s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h13m20s)

[so](https://youtu.be/HxupjQwU9GE?t=00h13m21s)

[for those people curious just running](https://youtu.be/HxupjQwU9GE?t=00h13m22s)

[this because I've got multiple](https://youtu.be/HxupjQwU9GE?t=00h13m24s)

[subscriptions and I just wanted to make](https://youtu.be/HxupjQwU9GE?t=00h13m26s)

[sure it goes to the one I expect okay](https://youtu.be/HxupjQwU9GE?t=00h13m27s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h13m31s)

[step one done uh AZ group create that'll](https://youtu.be/HxupjQwU9GE?t=00h13m32s)

[make me a resource Group uh we're not](https://youtu.be/HxupjQwU9GE?t=00h13m35s)

[going to do that because we already have](https://youtu.be/HxupjQwU9GE?t=00h13m37s)

[a resource Group](https://youtu.be/HxupjQwU9GE?t=00h13m39s)

[uh let's see I called it voting](https://youtu.be/HxupjQwU9GE?t=00h13m41s)

[not voting app so we'll do that](https://youtu.be/HxupjQwU9GE?t=00h13m45s)

[and then next step uh they want to](https://youtu.be/HxupjQwU9GE?t=00h13m47s)

[create that so let's actually do a](https://youtu.be/HxupjQwU9GE?t=00h13m50s)

[couple things we're going to change this](https://youtu.be/HxupjQwU9GE?t=00h13m53s)

[to be West us3](https://youtu.be/HxupjQwU9GE?t=00h13m54s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h13m57s)

[um](https://youtu.be/HxupjQwU9GE?t=00h13m58s)

[it tells me this is actually when doing](https://youtu.be/HxupjQwU9GE?t=00h14m00s)

[it at the command line it's supposed to](https://youtu.be/HxupjQwU9GE?t=00h14m03s)

[be this I could be wrong but I'm pretty](https://youtu.be/HxupjQwU9GE?t=00h14m05s)

[sure there's a slight difference there](https://youtu.be/HxupjQwU9GE?t=00h14m08s)

[uh voting app is the cluster name](https://youtu.be/HxupjQwU9GE?t=00h14m10s)

[oh that works and then my container](https://youtu.be/HxupjQwU9GE?t=00h14m13s)

[registry which is back here](https://youtu.be/HxupjQwU9GE?t=00h14m16s)

[promoting ACR because reasons](https://youtu.be/HxupjQwU9GE?t=00h14m23s)

[uh boom okay so there's all of that](https://youtu.be/HxupjQwU9GE?t=00h14m26s)

[we've done that](https://youtu.be/HxupjQwU9GE?t=00h14m30s)

[installed the kubernetes CLI done that](https://youtu.be/HxupjQwU9GE?t=00h14m32s)

[uh so we're gonna first plug these](https://youtu.be/HxupjQwU9GE?t=00h14m36s)

[things into my my terminal so I yeah](https://youtu.be/HxupjQwU9GE?t=00h14m39s)

[paste anyway](https://youtu.be/HxupjQwU9GE?t=00h14m41s)

[there we go so we got all the variables](https://youtu.be/HxupjQwU9GE?t=00h14m42s)

[lovely uh we we need to authenticate](https://youtu.be/HxupjQwU9GE?t=00h14m44s)

[against the cluster](https://youtu.be/HxupjQwU9GE?t=00h14m48s)

[so](https://youtu.be/HxupjQwU9GE?t=00h14m50s)

[do that do that maneuver sudo go get me](https://youtu.be/HxupjQwU9GE?t=00h14m51s)

[all the things lovely](https://youtu.be/HxupjQwU9GE?t=00h14m54s)

[uh let's see](https://youtu.be/HxupjQwU9GE?t=00h14m57s)

[create a container registry account and](https://youtu.be/HxupjQwU9GE?t=00h14m59s)

[log into it well we've already got a](https://youtu.be/HxupjQwU9GE?t=00h15m01s)

[container registry](https://youtu.be/HxupjQwU9GE?t=00h15m03s)

[uh we do need to get its ID as a](https://youtu.be/HxupjQwU9GE?t=00h15m05s)

[variable so we'll do that](https://youtu.be/HxupjQwU9GE?t=00h15m08s)

[there we go](https://youtu.be/HxupjQwU9GE?t=00h15m13s)

[uh we need service principal name](https://youtu.be/HxupjQwU9GE?t=00h15m14s)

[huh](https://youtu.be/HxupjQwU9GE?t=00h15m20s)

[why naming is ACR so](https://youtu.be/HxupjQwU9GE?t=00h15m22s)

[the the name of mine why it contains ACR](https://youtu.be/HxupjQwU9GE?t=00h15m27s)

[so ACR is just shorthand for Azure](https://youtu.be/HxupjQwU9GE?t=00h15m30s)

[container registry](https://youtu.be/HxupjQwU9GE?t=00h15m32s)

[and in short when I made these things by](https://youtu.be/HxupjQwU9GE?t=00h15m38s)

[hand](https://youtu.be/HxupjQwU9GE?t=00h15m40s)

[um I picked the first name that seemed](https://youtu.be/HxupjQwU9GE?t=00h15m41s)

[reasonable that that wasn't already](https://youtu.be/HxupjQwU9GE?t=00h15m43s)

[taken](https://youtu.be/HxupjQwU9GE?t=00h15m46s)

[um container Registries are uh an Azure](https://youtu.be/HxupjQwU9GE?t=00h15m47s)

[resource that has to have a URL](https://youtu.be/HxupjQwU9GE?t=00h15m50s)

[associated with them so they must be](https://youtu.be/HxupjQwU9GE?t=00h15m52s)

[globally unique so when you're making](https://youtu.be/HxupjQwU9GE?t=00h15m54s)

[one you have to pick a name that is](https://youtu.be/HxupjQwU9GE?t=00h15m56s)

[not shared with the the rest of the](https://youtu.be/HxupjQwU9GE?t=00h15m59s)

[world](https://youtu.be/HxupjQwU9GE?t=00h16m01s)

[um](https://youtu.be/HxupjQwU9GE?t=00h16m02s)

[this is interesting](https://youtu.be/HxupjQwU9GE?t=00h16m03s)

[they're assuming a service principle](https://youtu.be/HxupjQwU9GE?t=00h16m08s)

[with that name](https://youtu.be/HxupjQwU9GE?t=00h16m10s)

[I feel like I missed a step somewhere](https://youtu.be/HxupjQwU9GE?t=00h16m11s)

[going back to the readme](https://youtu.be/HxupjQwU9GE?t=00h16m14s)

[uh we're gonna do it here just so that I](https://youtu.be/HxupjQwU9GE?t=00h16m16s)

[can keep track](https://youtu.be/HxupjQwU9GE?t=00h16m19s)

[uh uh let's see before deploying the app](https://youtu.be/HxupjQwU9GE?t=00h16m21s)

[you'll need to provision the following](https://youtu.be/HxupjQwU9GE?t=00h16m24s)

[resources](https://youtu.be/HxupjQwU9GE?t=00h16m25s)

[a resource Group](https://youtu.be/HxupjQwU9GE?t=00h16m27s)

[a service principle oh so are they about](https://youtu.be/HxupjQwU9GE?t=00h16m28s)

[to create the service principle maybe I](https://youtu.be/HxupjQwU9GE?t=00h16m31s)

[should read the rest of the script](https://youtu.be/HxupjQwU9GE?t=00h16m32s)

[uh azsp create they're going to create](https://youtu.be/HxupjQwU9GE?t=00h16m36s)

[the service principle okay Carry Fourth](https://youtu.be/HxupjQwU9GE?t=00h16m40s)

[carry forth](https://youtu.be/HxupjQwU9GE?t=00h16m42s)

[so we will declare a variable this is](https://youtu.be/HxupjQwU9GE?t=00h16m43s)

[just setting up a string variable with](https://youtu.be/HxupjQwU9GE?t=00h16m46s)

[the service principle name great](https://youtu.be/HxupjQwU9GE?t=00h16m48s)

[and then this is going to do](https://youtu.be/HxupjQwU9GE?t=00h16m50s)

[service principle create for our back](https://youtu.be/HxupjQwU9GE?t=00h16m53s)

[with Scopes and all of the things](https://youtu.be/HxupjQwU9GE?t=00h16m55s)

[which is great I am realizing that](https://youtu.be/HxupjQwU9GE?t=00h16m58s)

[I'm hoping when I created they didn't](https://youtu.be/HxupjQwU9GE?t=00h17m02s)

[set anything special here](https://youtu.be/HxupjQwU9GE?t=00h17m04s)

[I'm hoping I didn't need to set anything](https://youtu.be/HxupjQwU9GE?t=00h17m08s)

[special when I made this so worst case](https://youtu.be/HxupjQwU9GE?t=00h17m09s)

[scenario will blow away the cluster and](https://youtu.be/HxupjQwU9GE?t=00h17m12s)

[go back and create theirs from by hand](https://youtu.be/HxupjQwU9GE?t=00h17m13s)

[uh okay](https://youtu.be/HxupjQwU9GE?t=00h17m16s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h17m19s)

[the output includes credentials you](https://youtu.be/HxupjQwU9GE?t=00h17m20s)

[might want to protect blah blah blah](https://youtu.be/HxupjQwU9GE?t=00h17m22s)

[blah blah yeah](https://youtu.be/HxupjQwU9GE?t=00h17m24s)

[so query password yes](https://youtu.be/HxupjQwU9GE?t=00h17m26s)

[but we stored it in this lovely variable](https://youtu.be/HxupjQwU9GE?t=00h17m30s)

[that as long as I don't Echo we're fine](https://youtu.be/HxupjQwU9GE?t=00h17m32s)

[uh okay and then we're gonna go here](https://youtu.be/HxupjQwU9GE?t=00h17m34s)

[get the service principle ID into a](https://youtu.be/HxupjQwU9GE?t=00h17m38s)

[variable](https://youtu.be/HxupjQwU9GE?t=00h17m40s)

[points awarded for whoever made the](https://youtu.be/HxupjQwU9GE?t=00h17m44s)

[script it seems to be going swimmingly](https://youtu.be/HxupjQwU9GE?t=00h17m46s)

[grab the login server](https://youtu.be/HxupjQwU9GE?t=00h17m49s)

[okay great and then](https://youtu.be/HxupjQwU9GE?t=00h17m54s)

[what is this doing Cube cuddle creates](https://youtu.be/HxupjQwU9GE?t=00h17m58s)

[secret Docker registry](https://youtu.be/HxupjQwU9GE?t=00h18m00s)

[so this is just setting up a secret for](https://youtu.be/HxupjQwU9GE?t=00h18m04s)

[doing Authentication](https://youtu.be/HxupjQwU9GE?t=00h18m07s)

[this is interesting because](https://youtu.be/HxupjQwU9GE?t=00h18m10s)

[I'm not actually sure this is necessary](https://youtu.be/HxupjQwU9GE?t=00h18m13s)

[I did some setup to connect my ACR to my](https://youtu.be/HxupjQwU9GE?t=00h18m18s)

[cluster already which they did not do](https://youtu.be/HxupjQwU9GE?t=00h18m22s)

[using managed identity so this well](https://youtu.be/HxupjQwU9GE?t=00h18m24s)

[we're going to follow the directions for](https://youtu.be/HxupjQwU9GE?t=00h18m27s)

[the moment but may not be completely](https://youtu.be/HxupjQwU9GE?t=00h18m28s)

[necessary uh](https://youtu.be/HxupjQwU9GE?t=00h18m31s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h18m34s)

[uh let's see here what are you](https://youtu.be/HxupjQwU9GE?t=00h18m35s)

[complaining about getting credentials](https://youtu.be/HxupjQwU9GE?t=00h18m37s)

[blah blah blah Cube blog and not found](https://youtu.be/HxupjQwU9GE?t=00h18m39s)

[it looks like you're trying to use a](https://youtu.be/HxupjQwU9GE?t=00h18m41s)

[client go credential plugin that is not](https://youtu.be/HxupjQwU9GE?t=00h18m42s)

[installed](https://youtu.be/HxupjQwU9GE?t=00h18m44s)

[well then](https://youtu.be/HxupjQwU9GE?t=00h18m47s)

[we're gonna continue on without doing](https://youtu.be/HxupjQwU9GE?t=00h18m50s)

[this](https://youtu.be/HxupjQwU9GE?t=00h18m52s)

[because I if this is doing what I think](https://youtu.be/HxupjQwU9GE?t=00h18m55s)

[it's doing this is just giving an](https://youtu.be/HxupjQwU9GE?t=00h18m57s)

[authenticated user so that the cluster](https://youtu.be/HxupjQwU9GE?t=00h19m00s)

[can reach the ACR and I don't think](https://youtu.be/HxupjQwU9GE?t=00h19m02s)

[that's actually needed](https://youtu.be/HxupjQwU9GE?t=00h19m04s)

[okay next up we are going to go](https://youtu.be/HxupjQwU9GE?t=00h19m07s)

[to the readme and hunt for the pound](https://youtu.be/HxupjQwU9GE?t=00h19m12s)

[replace me](https://youtu.be/HxupjQwU9GE?t=00h19m15s)

[um](https://youtu.be/HxupjQwU9GE?t=00h19m19s)

[because yeah this is where](https://youtu.be/HxupjQwU9GE?t=00h19m20s)

[surprised they aren't passing these in](https://youtu.be/HxupjQwU9GE?t=00h19m24s)

[um especially going to all of this](https://youtu.be/HxupjQwU9GE?t=00h19m27s)

[effort for deployment stuff uh okay so](https://youtu.be/HxupjQwU9GE?t=00h19m28s)

[key thing here is](https://youtu.be/HxupjQwU9GE?t=00h19m32s)

[image name ACR](https://youtu.be/HxupjQwU9GE?t=00h19m34s)

[so or I should say election for it but](https://youtu.be/HxupjQwU9GE?t=00h19m37s)

[we just need to grab this guy here](https://youtu.be/HxupjQwU9GE?t=00h19m41s)

[and slap it in](https://youtu.be/HxupjQwU9GE?t=00h19m44s)

[uh let's see where is the other one so](https://youtu.be/HxupjQwU9GE?t=00h19m47s)

[there's the first one](https://youtu.be/HxupjQwU9GE?t=00h19m50s)

[image pull secrets](https://youtu.be/HxupjQwU9GE?t=00h19m52s)

[see and this is where they were trying](https://youtu.be/HxupjQwU9GE?t=00h19m55s)

[to create the secrets we may not care](https://youtu.be/HxupjQwU9GE?t=00h19m56s)

[we again I don't think I actually care](https://youtu.be/HxupjQwU9GE?t=00h20m00s)

[we're gonna see it we're gonna see if](https://youtu.be/HxupjQwU9GE?t=00h20m07s)

[it's able to pull without I I think the](https://youtu.be/HxupjQwU9GE?t=00h20m08s)

[okay and technically you only needed to](https://youtu.be/HxupjQwU9GE?t=00h20m13s)

[replace this image one because the](https://youtu.be/HxupjQwU9GE?t=00h20m16s)

[secret if you follow the provisioning](https://youtu.be/HxupjQwU9GE?t=00h20m17s)

[script](https://youtu.be/HxupjQwU9GE?t=00h20m19s)

[should have I think hard-coded that](https://youtu.be/HxupjQwU9GE?t=00h20m21s)

[secret didn't it](https://youtu.be/HxupjQwU9GE?t=00h20m23s)

[Maybe](https://youtu.be/HxupjQwU9GE?t=00h20m29s)

[Maybe I'm Wrong there](https://youtu.be/HxupjQwU9GE?t=00h20m32s)

[well we're gonna carry on and see what](https://youtu.be/HxupjQwU9GE?t=00h20m36s)

[happens first case scenario goes boom](https://youtu.be/HxupjQwU9GE?t=00h20m37s)

[okay deployment](https://youtu.be/HxupjQwU9GE?t=00h20m39s)

[Okay so we've already got these](https://youtu.be/HxupjQwU9GE?t=00h20m42s)

[variables and I think they already match](https://youtu.be/HxupjQwU9GE?t=00h20m44s)

[Resource Group location Cluster West us](https://youtu.be/HxupjQwU9GE?t=00h20m46s)

[yeah we've already got Acer login server](https://youtu.be/HxupjQwU9GE?t=00h20m51s)

[so that's done](https://youtu.be/HxupjQwU9GE?t=00h20m54s)

[uh we do need to log in this is actually](https://youtu.be/HxupjQwU9GE?t=00h20m57s)

[important when you're using the Azure](https://youtu.be/HxupjQwU9GE?t=00h20m59s)

[CLI you do need to log into the ACR](https://youtu.be/HxupjQwU9GE?t=00h21m01s)

[separately from logging into the Azure](https://youtu.be/HxupjQwU9GE?t=00h21m03s)

[CLI](https://youtu.be/HxupjQwU9GE?t=00h21m06s)

[do the needful](https://youtu.be/HxupjQwU9GE?t=00h21m09s)

[gracias](https://youtu.be/HxupjQwU9GE?t=00h21m12s)

[okay so now I can I can push and pull](https://youtu.be/HxupjQwU9GE?t=00h21m14s)

[stuff](https://youtu.be/HxupjQwU9GE?t=00h21m17s)

[um and they just want to do it all in](https://youtu.be/HxupjQwU9GE?t=00h21m20s)

[one swing so](https://youtu.be/HxupjQwU9GE?t=00h21m21s)

[okay I think the appropriate word is](https://youtu.be/HxupjQwU9GE?t=00h21m24s)

[send it](https://youtu.be/HxupjQwU9GE?t=00h21m27s)

[oh yeah](https://youtu.be/HxupjQwU9GE?t=00h21m28s)

[wait](https://youtu.be/HxupjQwU9GE?t=00h21m30s)

[is that supposed to work](https://youtu.be/HxupjQwU9GE?t=00h21m34s)

[I don't know if that's supposed to work](https://youtu.be/HxupjQwU9GE?t=00h21m37s)

[uh okay so we're gonna do this the the](https://youtu.be/HxupjQwU9GE?t=00h21m38s)

[slower way we're gonna go here](https://youtu.be/HxupjQwU9GE?t=00h21m41s)

[so](https://youtu.be/HxupjQwU9GE?t=00h21m49s)

[this here you'll note it's doing a ton](https://youtu.be/HxupjQwU9GE?t=00h21m51s)

[of work but under the hood all that's](https://youtu.be/HxupjQwU9GE?t=00h21m54s)

[happening uh for the docker build is](https://youtu.be/HxupjQwU9GE?t=00h21m56s)

[it's going through and Performing the](https://youtu.be/HxupjQwU9GE?t=00h21m59s)

[exact steps that are outlined here so](https://youtu.be/HxupjQwU9GE?t=00h22m01s)

[just a couple things to call out the](https://youtu.be/HxupjQwU9GE?t=00h22m03s)

[from command in your Docker file](https://youtu.be/HxupjQwU9GE?t=00h22m05s)

[specifies like a a base image or a base](https://youtu.be/HxupjQwU9GE?t=00h22m07s)

[layer for you to go through and](https://youtu.be/HxupjQwU9GE?t=00h22m10s)

[reference so in this case it's setting](https://youtu.be/HxupjQwU9GE?t=00h22m12s)

[up a a base layer with a or I should say](https://youtu.be/HxupjQwU9GE?t=00h22m13s)

[it's first setting up](https://youtu.be/HxupjQwU9GE?t=00h22m16s)

[kind of like the call stack uh you've](https://youtu.be/HxupjQwU9GE?t=00h22m19s)

[got your your asp.net core runtime](https://youtu.be/HxupjQwU9GE?t=00h22m21s)

[version six then on top of that it sets](https://youtu.be/HxupjQwU9GE?t=00h22m23s)

[up the SDK](https://youtu.be/HxupjQwU9GE?t=00h22m26s)

[where then it's going to do things](https://youtu.be/HxupjQwU9GE?t=00h22m28s)

[like.net restore.net build](https://youtu.be/HxupjQwU9GE?t=00h22m29s)

[um it then is going to do a publish or](https://youtu.be/HxupjQwU9GE?t=00h22m33s)

[publish it it takes the published bit](https://youtu.be/HxupjQwU9GE?t=00h22m37s)

[and you'll note these layers are named](https://youtu.be/HxupjQwU9GE?t=00h22m39s)

[base and build](https://youtu.be/HxupjQwU9GE?t=00h22m41s)

[and then it goes through and copies them](https://youtu.be/HxupjQwU9GE?t=00h22m43s)

[into a final so the things that were](https://youtu.be/HxupjQwU9GE?t=00h22m46s)

[copied into the app directory get copied](https://youtu.be/HxupjQwU9GE?t=00h22m48s)

[from the uh publish into app.publish and](https://youtu.be/HxupjQwU9GE?t=00h22m50s)

[then this tells it how to start the app](https://youtu.be/HxupjQwU9GE?t=00h22m55s)

[so this is very similar and darn near](https://youtu.be/HxupjQwU9GE?t=00h22m58s)

[identical if you right click on a](https://youtu.be/HxupjQwU9GE?t=00h23m02s)

[project in visual studio and you hit add](https://youtu.be/HxupjQwU9GE?t=00h23m04s)

[and then Docker support it will gen you](https://youtu.be/HxupjQwU9GE?t=00h23m07s)

[up a Docker file that looks very similar](https://youtu.be/HxupjQwU9GE?t=00h23m10s)

[to this](https://youtu.be/HxupjQwU9GE?t=00h23m12s)

[with a few difference in the ports](https://youtu.be/HxupjQwU9GE?t=00h23m14s)

[exported Okay so we've got that going](https://youtu.be/HxupjQwU9GE?t=00h23m16s)

[we now need to come back here](https://youtu.be/HxupjQwU9GE?t=00h23m21s)

[vision](https://youtu.be/HxupjQwU9GE?t=00h23m25s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h23m26s)

[okay Docker push](https://youtu.be/HxupjQwU9GE?t=00h23m31s)

[and send it](https://youtu.be/HxupjQwU9GE?t=00h23m39s)

[and part of the the nice niceness of](https://youtu.be/HxupjQwU9GE?t=00h23m50s)

[Docker in all of these layers](https://youtu.be/HxupjQwU9GE?t=00h23m53s)

[um you can kind of almost think of them](https://youtu.be/HxupjQwU9GE?t=00h23m57s)

[like nougats and dependencies not quite](https://youtu.be/HxupjQwU9GE?t=00h23m59s)

[but kind of where there's kind of these](https://youtu.be/HxupjQwU9GE?t=00h24m01s)

[dependent layers so even though I may](https://youtu.be/HxupjQwU9GE?t=00h24m03s)

[push up what is it eight things here](https://youtu.be/HxupjQwU9GE?t=00h24m06s)

[initially if in the future only one](https://youtu.be/HxupjQwU9GE?t=00h24m09s)

[layer changes I only have to push the](https://youtu.be/HxupjQwU9GE?t=00h24m12s)

[one](https://youtu.be/HxupjQwU9GE?t=00h24m14s)

[so it gets to be nice like that of it](https://youtu.be/HxupjQwU9GE?t=00h24m15s)

[your initial like Docker pull Docker](https://youtu.be/HxupjQwU9GE?t=00h24m18s)

[pushes could be a little big and then](https://youtu.be/HxupjQwU9GE?t=00h24m21s)

[after that you can kind of just do the](https://youtu.be/HxupjQwU9GE?t=00h24m22s)

[Deltas okay and we can go out real quick](https://youtu.be/HxupjQwU9GE?t=00h24m24s)

[and just validate that we see this guy](https://youtu.be/HxupjQwU9GE?t=00h24m27s)

[here](https://youtu.be/HxupjQwU9GE?t=00h24m29s)

[we go repositories we should see a thing](https://youtu.be/HxupjQwU9GE?t=00h24m31s)

[huzzah](https://youtu.be/HxupjQwU9GE?t=00h24m34s)

[we've got a voting app it's has the tag](https://youtu.be/HxupjQwU9GE?t=00h24m35s)

[of latest](https://youtu.be/HxupjQwU9GE?t=00h24m38s)

[we could confirm that our hash matches](https://youtu.be/HxupjQwU9GE?t=00h24m41s)

[but](https://youtu.be/HxupjQwU9GE?t=00h24m43s)

[we are only interested in seeing it go](https://youtu.be/HxupjQwU9GE?t=00h24m46s)

[okay so Cube cuddle apply](https://youtu.be/HxupjQwU9GE?t=00h24m48s)

[okay this will be the part where if it's](https://youtu.be/HxupjQwU9GE?t=00h24m54s)

[going to fail](https://youtu.be/HxupjQwU9GE?t=00h24m57s)

[uh uh it looks like you're](https://youtu.be/HxupjQwU9GE?t=00h25m00s)

[oh do I do I just not have the](https://youtu.be/HxupjQwU9GE?t=00h25m05s)

[CLI stuff installed](https://youtu.be/HxupjQwU9GE?t=00h25m12s)

[let's start there we may we may just be](https://youtu.be/HxupjQwU9GE?t=00h25m16s)

[missing this I I could have sworn I](https://youtu.be/HxupjQwU9GE?t=00h25m18s)

[already had all of this](https://youtu.be/HxupjQwU9GE?t=00h25m19s)

[uh uh let's see the detected](https://youtu.be/HxupjQwU9GE?t=00h25m21s)

[architecture's arm](https://youtu.be/HxupjQwU9GE?t=00h25m24s)

[okay I'm gonna go back and](https://youtu.be/HxupjQwU9GE?t=00h25m31s)

[let's actually start with this](https://youtu.be/HxupjQwU9GE?t=00h25m34s)

[can can I Cube cuddle](https://youtu.be/HxupjQwU9GE?t=00h25m37s)

[okay I can keep cuddle Okay so](https://youtu.be/HxupjQwU9GE?t=00h25m41s)

[step one complete](https://youtu.be/HxupjQwU9GE?t=00h25m45s)

[client go credential plugin that is not](https://youtu.be/HxupjQwU9GE?t=00h25m50s)

[installed why](https://youtu.be/HxupjQwU9GE?t=00h25m52s)

[um](https://youtu.be/HxupjQwU9GE?t=00h25m56s)

[did I miss something](https://youtu.be/HxupjQwU9GE?t=00h25m58s)

[I feel like I missed something something](https://youtu.be/HxupjQwU9GE?t=00h26m02s)

[important](https://youtu.be/HxupjQwU9GE?t=00h26m04s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h26m06s)

[uh to learn more](https://youtu.be/HxupjQwU9GE?t=00h26m07s)

[fine I'll click the link](https://youtu.be/HxupjQwU9GE?t=00h26m09s)

[what are you](https://youtu.be/HxupjQwU9GE?t=00h26m12s)

[you don't have dark mode](https://youtu.be/HxupjQwU9GE?t=00h26m14s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h26m16s)

[I don't see it immediately available](https://youtu.be/HxupjQwU9GE?t=00h26m25s)

[refresh to get me to the page](https://youtu.be/HxupjQwU9GE?t=00h26m28s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h26m30s)

[uh let's see](https://youtu.be/HxupjQwU9GE?t=00h26m32s)

[take me there please go credential](https://youtu.be/HxupjQwU9GE?t=00h26m37s)

[plugins](https://youtu.be/HxupjQwU9GE?t=00h26m39s)

[foreign](https://youtu.be/HxupjQwU9GE?t=00h26m40s)

[yeah this doesn't seem](https://youtu.be/HxupjQwU9GE?t=00h26m55s)

[something's something I'm missing](https://youtu.be/HxupjQwU9GE?t=00h26m59s)

[I'm wondering oh I bet you when I set up](https://youtu.be/HxupjQwU9GE?t=00h27m13s)

[my cluster](https://youtu.be/HxupjQwU9GE?t=00h27m17s)

[um I bet you when I set up my cluster I](https://youtu.be/HxupjQwU9GE?t=00h27m20s)

[I probably did Azure R back](https://youtu.be/HxupjQwU9GE?t=00h27m24s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h27m31s)

[receive user credentials](https://youtu.be/HxupjQwU9GE?t=00h27m34s)

[yes](https://youtu.be/HxupjQwU9GE?t=00h27m39s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h27m46s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h27m48s)

[looking looking looking to enable](https://youtu.be/HxupjQwU9GE?t=00h27m51s)

[uh as exciting as this is I almost](https://youtu.be/HxupjQwU9GE?t=00h27m58s)

[wonder if it's quicker to bring down and](https://youtu.be/HxupjQwU9GE?t=00h28m01s)

[recreate the cluster](https://youtu.be/HxupjQwU9GE?t=00h28m03s)

[it might be that quick](https://youtu.be/HxupjQwU9GE?t=00h28m06s)

[uh let's see here](https://youtu.be/HxupjQwU9GE?t=00h28m13s)

[because ultimately](https://youtu.be/HxupjQwU9GE?t=00h28m16s)

[uh is the AKs show me what was buried in](https://youtu.be/HxupjQwU9GE?t=00h28m22s)

[here real quick](https://youtu.be/HxupjQwU9GE?t=00h28m26s)

[oh darker you hush](https://youtu.be/HxupjQwU9GE?t=00h28m27s)

[um](https://youtu.be/HxupjQwU9GE?t=00h28m31s)

[Dev spaces](https://youtu.be/HxupjQwU9GE?t=00h28m34s)

[we can do the check ACR but I don't](https://youtu.be/HxupjQwU9GE?t=00h28m42s)

[think](https://youtu.be/HxupjQwU9GE?t=00h28m45s)

[that's what we're looking for](https://youtu.be/HxupjQwU9GE?t=00h28m48s)

[the credentials](https://youtu.be/HxupjQwU9GE?t=00h28m51s)

[show stop update update credentials](https://youtu.be/HxupjQwU9GE?t=00h28m55s)

[service principle](https://youtu.be/HxupjQwU9GE?t=00h28m59s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h29m04s)

[I'm wondering](https://youtu.be/HxupjQwU9GE?t=00h29m07s)

[see details easy KS command invoke aha](https://youtu.be/HxupjQwU9GE?t=00h29m11s)

[this is the magical](https://youtu.be/HxupjQwU9GE?t=00h29m17s)

[is this the new Magic](https://youtu.be/HxupjQwU9GE?t=00h29m20s)

[we're gonna show uh on your AKs cluster](https://youtu.be/HxupjQwU9GE?t=00h29m26s)

[ah](https://youtu.be/HxupjQwU9GE?t=00h29m30s)

[that sounds what it like what I want](https://youtu.be/HxupjQwU9GE?t=00h29m33s)

[a-z-a-k-s](https://youtu.be/HxupjQwU9GE?t=00h29m36s)

[and](https://youtu.be/HxupjQwU9GE?t=00h29m38s)

[invoke](https://youtu.be/HxupjQwU9GE?t=00h29m40s)

[uh let's see and I'm gonna need a dash C](https://youtu.be/HxupjQwU9GE?t=00h29m42s)

[tell it the command I'm going to need to](https://youtu.be/HxupjQwU9GE?t=00h29m46s)

[tell it](https://youtu.be/HxupjQwU9GE?t=00h29m49s)

[name of my cluster](https://youtu.be/HxupjQwU9GE?t=00h29m50s)

[which I've already forgotten oh uh I can](https://youtu.be/HxupjQwU9GE?t=00h29m53s)

[just use my cluster name variable](https://youtu.be/HxupjQwU9GE?t=00h29m56s)

[a whole point in doing that and then my](https://youtu.be/HxupjQwU9GE?t=00h30m00s)

[Resource Group name which](https://youtu.be/HxupjQwU9GE?t=00h30m04s)

[could have a variable for that too](https://youtu.be/HxupjQwU9GE?t=00h30m07s)

[uh bippity boppity send it](https://youtu.be/HxupjQwU9GE?t=00h30m10s)

[oh uh and invoke is spelled with a k](https://youtu.be/HxupjQwU9GE?t=00h30m19s)

[oh uh uh I'm probably gonna need to](https://youtu.be/HxupjQwU9GE?t=00h30m29s)

[attach the file](https://youtu.be/HxupjQwU9GE?t=00h30m32s)

[I'm gonna go out on a limb and guess](https://youtu.be/HxupjQwU9GE?t=00h30m35s)

[that this thing fails with some issue](https://youtu.be/HxupjQwU9GE?t=00h30m37s)

[about not being able to find](https://youtu.be/HxupjQwU9GE?t=00h30m39s)

[deployment.yaml](https://youtu.be/HxupjQwU9GE?t=00h30m40s)

[because if it's gonna run](https://youtu.be/HxupjQwU9GE?t=00h30m43s)

[the dev world needs spell check](https://youtu.be/HxupjQwU9GE?t=00h30m46s)

[this particular Dev in in particular](https://youtu.be/HxupjQwU9GE?t=00h30m48s)

[yeah the path for the file doesn't exist](https://youtu.be/HxupjQwU9GE?t=00h30m52s)

[what a shock uh okay so](https://youtu.be/HxupjQwU9GE?t=00h30m54s)

[uh send it](https://youtu.be/HxupjQwU9GE?t=00h31m01s)

[and we'll see where that goes](https://youtu.be/HxupjQwU9GE?t=00h31m03s)

[foreign](https://youtu.be/HxupjQwU9GE?t=00h31m13s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h31m25s)

[this is better uh](https://youtu.be/HxupjQwU9GE?t=00h31m27s)

[uh right so I don't have permissions](https://youtu.be/HxupjQwU9GE?t=00h31m30s)

[be okay so this is once again because I](https://youtu.be/HxupjQwU9GE?t=00h31m34s)

[set up our back and then didn't give](https://youtu.be/HxupjQwU9GE?t=00h31m37s)

[myself access right right right right](https://youtu.be/HxupjQwU9GE?t=00h31m38s)

[right right right right right right okay](https://youtu.be/HxupjQwU9GE?t=00h31m41s)

[okay back up to the resource Group into](https://youtu.be/HxupjQwU9GE?t=00h31m43s)

[AKs](https://youtu.be/HxupjQwU9GE?t=00h31m45s)

[I am](https://youtu.be/HxupjQwU9GE?t=00h31m47s)

[ad role assignments](https://youtu.be/HxupjQwU9GE?t=00h31m49s)

[okay uh let's see](https://youtu.be/HxupjQwU9GE?t=00h31m54s)

[let she manages all resources in the](https://youtu.be/HxupjQwU9GE?t=00h32m02s)

[cluster I think that's what we want I](https://youtu.be/HxupjQwU9GE?t=00h32m05s)

[would like full access](https://youtu.be/HxupjQwU9GE?t=00h32m07s)

[uh uh let's see and then I would like it](https://youtu.be/HxupjQwU9GE?t=00h32m10s)

[to be](https://youtu.be/HxupjQwU9GE?t=00h32m14s)

[sorry one second because I don't](https://youtu.be/HxupjQwU9GE?t=00h32m15s)

[remember what this is all going to show](https://youtu.be/HxupjQwU9GE?t=00h32m17s)

[so we're gonna just do that](https://youtu.be/HxupjQwU9GE?t=00h32m19s)

[there we go okay](https://youtu.be/HxupjQwU9GE?t=00h32m28s)

[I picked me viewing a sign I would like](https://youtu.be/HxupjQwU9GE?t=00h32m31s)

[to be cluster admin](https://youtu.be/HxupjQwU9GE?t=00h32m34s)

[sudo make me an admin](https://youtu.be/HxupjQwU9GE?t=00h32m36s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h32m38s)

[rinse repeat try again](https://youtu.be/HxupjQwU9GE?t=00h32m40s)

[let's see](https://youtu.be/HxupjQwU9GE?t=00h32m50s)

[to do](https://youtu.be/HxupjQwU9GE?t=00h32m53s)

[go Azure go](https://youtu.be/HxupjQwU9GE?t=00h32m55s)

[okay Air Resource V1 resource](https://youtu.be/HxupjQwU9GE?t=00h33m04s)

[deployments](https://youtu.be/HxupjQwU9GE?t=00h33m08s)

[uh name redis for server](https://youtu.be/HxupjQwU9GE?t=00h33m09s)

[uh deployments apps redis is forbidden](https://youtu.be/HxupjQwU9GE?t=00h33m13s)

[user cannot get resource](https://youtu.be/HxupjQwU9GE?t=00h33m15s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h33m19s)

[user does not have access to the](https://youtu.be/HxupjQwU9GE?t=00h33m21s)

[resource in Azure update role](https://youtu.be/HxupjQwU9GE?t=00h33m24s)

[assignments to allow](https://youtu.be/HxupjQwU9GE?t=00h33m25s)

[access is this just because you're slow](https://youtu.be/HxupjQwU9GE?t=00h33m29s)

[cluster](https://youtu.be/HxupjQwU9GE?t=00h33m33s)

[I kind of want you to go faster please](https://youtu.be/HxupjQwU9GE?t=00h33m37s)

[to do I'm going to give it a moment then](https://youtu.be/HxupjQwU9GE?t=00h33m41s)

[I'm going to just kick it one more time](https://youtu.be/HxupjQwU9GE?t=00h33m43s)

[because I suspect](https://youtu.be/HxupjQwU9GE?t=00h33m45s)

[I should have plenty of access](https://youtu.be/HxupjQwU9GE?t=00h33m47s)

[view my level of access](https://youtu.be/HxupjQwU9GE?t=00h33m49s)

[lets you manage all resources in the](https://youtu.be/HxupjQwU9GE?t=00h33m52s)

[cluster](https://youtu.be/HxupjQwU9GE?t=00h33m55s)

[I.E I should have access to deployments](https://youtu.be/HxupjQwU9GE?t=00h33m56s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h34m01s)

[uh yeah deployments apps redis is](https://youtu.be/HxupjQwU9GE?t=00h34m05s)

[forbidden cannot get resource](https://youtu.be/HxupjQwU9GE?t=00h34m07s)

[deployments so](https://youtu.be/HxupjQwU9GE?t=00h34m09s)

[we'll just call this out when you're](https://youtu.be/HxupjQwU9GE?t=00h34m11s)

[looking at these yamls for kubernetes](https://youtu.be/HxupjQwU9GE?t=00h34m12s)

[uh resources are broken up into](https://youtu.be/HxupjQwU9GE?t=00h34m15s)

[different types](https://youtu.be/HxupjQwU9GE?t=00h34m17s)

[usually specified on this kind attribute](https://youtu.be/HxupjQwU9GE?t=00h34m18s)

[here so deployments](https://youtu.be/HxupjQwU9GE?t=00h34m21s)

[so it is squawking saying that I don't](https://youtu.be/HxupjQwU9GE?t=00h34m23s)

[have access to deployments and it's](https://youtu.be/HxupjQwU9GE?t=00h34m25s)

[blowing up at redis first because that's](https://youtu.be/HxupjQwU9GE?t=00h34m27s)

[just the first file in there I assume](https://youtu.be/HxupjQwU9GE?t=00h34m28s)

[I'm getting the same thing further down](https://youtu.be/HxupjQwU9GE?t=00h34m30s)

[yeah I don't have access to service](https://youtu.be/HxupjQwU9GE?t=00h34m32s)

[this is my user I believe](https://youtu.be/HxupjQwU9GE?t=00h34m34s)

[or one for f](https://youtu.be/HxupjQwU9GE?t=00h34m38s)

[uh rule assignments](https://youtu.be/HxupjQwU9GE?t=00h34m40s)

[you go away](https://youtu.be/HxupjQwU9GE?t=00h34m43s)

[I think this is my user](https://youtu.be/HxupjQwU9GE?t=00h34m46s)

[four one four F yep so it is using me](https://youtu.be/HxupjQwU9GE?t=00h34m51s)

[okay great that's what we expect](https://youtu.be/HxupjQwU9GE?t=00h34m54s)

[we're back I'm gonna assume that the](https://youtu.be/HxupjQwU9GE?t=00h34m58s)

[permission should send propagated quick](https://youtu.be/HxupjQwU9GE?t=00h35m00s)

[enough](https://youtu.be/HxupjQwU9GE?t=00h35m01s)

[uh yeah go](https://youtu.be/HxupjQwU9GE?t=00h35m03s)

[try again](https://youtu.be/HxupjQwU9GE?t=00h35m07s)

[this time with permissions sometimes the](https://youtu.be/HxupjQwU9GE?t=00h35m09s)

[uh I am stuff in Azure does take a few](https://youtu.be/HxupjQwU9GE?t=00h35m12s)

[minutes to propagate when you make a](https://youtu.be/HxupjQwU9GE?t=00h35m15s)

[change so if you make the change in it's](https://youtu.be/HxupjQwU9GE?t=00h35m16s)

[not immediately apparent](https://youtu.be/HxupjQwU9GE?t=00h35m18s)

[sometimes give it a moment](https://youtu.be/HxupjQwU9GE?t=00h35m21s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h35m25s)

[we have deployed](https://youtu.be/HxupjQwU9GE?t=00h35m27s)

[uh now the other thing to be aware of](https://youtu.be/HxupjQwU9GE?t=00h35m29s)

[with kubernetes is when you deploy out](https://youtu.be/HxupjQwU9GE?t=00h35m32s)

[it is a desired State configuration so](https://youtu.be/HxupjQwU9GE?t=00h35m34s)

[you tell kubernetes I would like the](https://youtu.be/HxupjQwU9GE?t=00h35m36s)

[following and kubernetes is your Butler](https://youtu.be/HxupjQwU9GE?t=00h35m39s)

[and says yes sir let me go create all of](https://youtu.be/HxupjQwU9GE?t=00h35m41s)

[that stuff for you](https://youtu.be/HxupjQwU9GE?t=00h35m44s)

[that does not mean your app is working](https://youtu.be/HxupjQwU9GE?t=00h35m45s)

[it just means the butler said I'm on it](https://youtu.be/HxupjQwU9GE?t=00h35m48s)

[and is going to then go and try](https://youtu.be/HxupjQwU9GE?t=00h35m50s)

[so we're going to come over here](https://youtu.be/HxupjQwU9GE?t=00h35m53s)

[and hopefully we see some stuff](https://youtu.be/HxupjQwU9GE?t=00h35m57s)

[we see a voting app](https://youtu.be/HxupjQwU9GE?t=00h35m59s)

[I mean it shows green which kind of](https://youtu.be/HxupjQwU9GE?t=00h36m04s)

[implies it's up](https://youtu.be/HxupjQwU9GE?t=00h36m07s)

[okay](https://youtu.be/HxupjQwU9GE?t=00h36m10s)

[so that's that's a good thing let's see](https://youtu.be/HxupjQwU9GE?t=00h36m11s)

[uh deploy](https://youtu.be/HxupjQwU9GE?t=00h36m14s)

[so they want this command executed next](https://youtu.be/HxupjQwU9GE?t=00h36m16s)

[I wonder why they're wanting to do a](https://youtu.be/HxupjQwU9GE?t=00h36m19s)

[rollout restart](https://youtu.be/HxupjQwU9GE?t=00h36m22s)

[huh](https://youtu.be/HxupjQwU9GE?t=00h36m25s)

[don't know gotta run it anyway](https://youtu.be/HxupjQwU9GE?t=00h36m27s)

[uh uh let's see so we're gonna do this](https://youtu.be/HxupjQwU9GE?t=00h36m30s)

[oh I didn't get rid of enough Cube](https://youtu.be/HxupjQwU9GE?t=00h36m34s)

[cuddles and then this one doesn't](https://youtu.be/HxupjQwU9GE?t=00h36m36s)

[require the file so we'll get rid of](https://youtu.be/HxupjQwU9GE?t=00h36m37s)

[this](https://youtu.be/HxupjQwU9GE?t=00h36m39s)

[that should just go and then the](https://youtu.be/HxupjQwU9GE?t=00h36m51s)

[question will be](https://youtu.be/HxupjQwU9GE?t=00h36m53s)

[uh seeing if we can hit it and have it](https://youtu.be/HxupjQwU9GE?t=00h36m56s)

[work because that would be cool](https://youtu.be/HxupjQwU9GE?t=00h36m59s)

[see](https://youtu.be/HxupjQwU9GE?t=00h37m02s)

[well registered](https://youtu.be/HxupjQwU9GE?t=00h37m04s)

[I mean that kind of looks like success](https://youtu.be/HxupjQwU9GE?t=00h37m07s)

[to me](https://youtu.be/HxupjQwU9GE?t=00h37m09s)

[pull title](https://youtu.be/HxupjQwU9GE?t=00h37m12s)

[who is](https://youtu.be/HxupjQwU9GE?t=00h37m14s)

[uh what is your](https://youtu.be/HxupjQwU9GE?t=00h37m16s)

[favorite stream to watch](https://youtu.be/HxupjQwU9GE?t=00h37m19s)

[this is going to be a biased a biased](https://youtu.be/HxupjQwU9GE?t=00h37m23s)

[pull](https://youtu.be/HxupjQwU9GE?t=00h37m25s)

[uh option value](https://youtu.be/HxupjQwU9GE?t=00h37m26s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h37m28s)

[which](https://youtu.be/HxupjQwU9GE?t=00h37m30s)

[boot.dev](https://youtu.be/HxupjQwU9GE?t=00h37m31s)

[uh uh add](https://youtu.be/HxupjQwU9GE?t=00h37m33s)

[I'm going to create I don't know what](https://youtu.be/HxupjQwU9GE?t=00h37m38s)

[this thing is](https://youtu.be/HxupjQwU9GE?t=00h37m40s)

[hey where'd my polls go](https://youtu.be/HxupjQwU9GE?t=00h37m44s)

[how do I get to my poles is the app](https://youtu.be/HxupjQwU9GE?t=00h37m46s)

[actually working I'm very confused](https://youtu.be/HxupjQwU9GE?t=00h37m49s)

[delete delete delete okay the delete](https://youtu.be/HxupjQwU9GE?t=00h37m57s)

[button works](https://youtu.be/HxupjQwU9GE?t=00h37m59s)

[the add button](https://youtu.be/HxupjQwU9GE?t=00h38m01s)

[the add button leaves a little to be](https://youtu.be/HxupjQwU9GE?t=00h38m03s)

[desired](https://youtu.be/HxupjQwU9GE?t=00h38m05s)

[okay so there's there may be some bugs](https://youtu.be/HxupjQwU9GE?t=00h38m08s)

[in this software](https://youtu.be/HxupjQwU9GE?t=00h38m10s)

[okay if I go create on the demo](https://youtu.be/HxupjQwU9GE?t=00h38m14s)

[Okay so](https://youtu.be/HxupjQwU9GE?t=00h38m17s)

[creating a poll works](https://youtu.be/HxupjQwU9GE?t=00h38m18s)

[what is this thing's error issue](https://youtu.be/HxupjQwU9GE?t=00h38m21s)

[I really wasn't planning on debugging](https://youtu.be/HxupjQwU9GE?t=00h38m24s)

[this](https://youtu.be/HxupjQwU9GE?t=00h38m26s)

[404 404](https://youtu.be/HxupjQwU9GE?t=00h38m28s)

[yeah I'm gonna go out on a limb and](https://youtu.be/HxupjQwU9GE?t=00h38m37s)

[guess that some of this may not be all](https://youtu.be/HxupjQwU9GE?t=00h38m39s)

[the way hooked up like I'm I'm somewhat](https://youtu.be/HxupjQwU9GE?t=00h38m42s)

[wondering if](https://youtu.be/HxupjQwU9GE?t=00h38m45s)

[what ports did this thing exposed](https://youtu.be/HxupjQwU9GE?t=00h38m48s)

[several ports](https://youtu.be/HxupjQwU9GE?t=00h38m52s)

[something may not be wired correctly but](https://youtu.be/HxupjQwU9GE?t=00h38m55s)

[if I go green red yeah so something's](https://youtu.be/HxupjQwU9GE?t=00h38m58s)

[okay so this thing leaves a little bit](https://youtu.be/HxupjQwU9GE?t=00h39m02s)

[to be desired for](https://youtu.be/HxupjQwU9GE?t=00h39m03s)

[debugging and deployment](https://youtu.be/HxupjQwU9GE?t=00h39m05s)

[here you sit there you sit there](https://youtu.be/HxupjQwU9GE?t=00h39m08s)

[share this poll](https://youtu.be/HxupjQwU9GE?t=00h39m15s)

[I would love to share this poll but how](https://youtu.be/HxupjQwU9GE?t=00h39m16s)

[would somebody get to the poll](https://youtu.be/HxupjQwU9GE?t=00h39m19s)

[errors occurred reload](https://youtu.be/HxupjQwU9GE?t=00h39m23s)

[uh invocation cancel detender](https://youtu.be/HxupjQwU9GE?t=00h39m26s)

[list of component records is not valid](https://youtu.be/HxupjQwU9GE?t=00h39m31s)

[uh so we we've got some errors here](https://youtu.be/HxupjQwU9GE?t=00h39m34s)

[okay so next step](https://youtu.be/HxupjQwU9GE?t=00h39m41s)

[okay I'm happy this thing deployed and](https://youtu.be/HxupjQwU9GE?t=00h39m44s)

[I'm happy it is working](https://youtu.be/HxupjQwU9GE?t=00h39m46s)

[okay so the fact that that thing went to](https://youtu.be/HxupjQwU9GE?t=00h39m49s)

[the cluster and went green means that](https://youtu.be/HxupjQwU9GE?t=00h39m52s)

[the cluster is set up the cluster was](https://youtu.be/HxupjQwU9GE?t=00h39m54s)

[able to reach over to the ACR because](https://youtu.be/HxupjQwU9GE?t=00h39m57s)

[you'll note that the command that we ran](https://youtu.be/HxupjQwU9GE?t=00h39m59s)

[the the cube cuddle deployment](https://youtu.be/HxupjQwU9GE?t=00h40m02s)

[this guy here the deployment yaml](https://youtu.be/HxupjQwU9GE?t=00h40m07s)

[doesn't actually contain our app](https://youtu.be/HxupjQwU9GE?t=00h40m10s)

[what it contains instead is a reference](https://youtu.be/HxupjQwU9GE?t=00h40m12s)

[to the ACR where to get the app from](https://youtu.be/HxupjQwU9GE?t=00h40m15s)

[so when it fired up it reached across to](https://youtu.be/HxupjQwU9GE?t=00h40m19s)

[our ACR](https://youtu.be/HxupjQwU9GE?t=00h40m22s)

[AB the image that we deployed pulled it](https://youtu.be/HxupjQwU9GE?t=00h40m23s)

[back across and then built this whole](https://youtu.be/HxupjQwU9GE?t=00h40m27s)

[thing up](https://youtu.be/HxupjQwU9GE?t=00h40m29s)

[so](https://youtu.be/HxupjQwU9GE?t=00h40m30s)

[it was able to pull so this image pull](https://youtu.be/HxupjQwU9GE?t=00h40m32s)

[Secret's not needed the](https://youtu.be/HxupjQwU9GE?t=00h40m36s)

[stuff I set up to connect them earlier](https://youtu.be/HxupjQwU9GE?t=00h40m39s)

[works just fine](https://youtu.be/HxupjQwU9GE?t=00h40m41s)

[um because it was able to pull our app](https://youtu.be/HxupjQwU9GE?t=00h40m42s)

[and deploy it but the app apparently has](https://youtu.be/HxupjQwU9GE?t=00h40m44s)

[some problems so](https://youtu.be/HxupjQwU9GE?t=00h40m46s)

[let's fix it](https://youtu.be/HxupjQwU9GE?t=00h40m50s)

[I mean I don't know about you but that's](https://youtu.be/HxupjQwU9GE?t=00h40m53s)

[what that's that that's my thought is](https://youtu.be/HxupjQwU9GE?t=00h40m54s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h40m58s)

[uh let's let's take a peek see at this](https://youtu.be/HxupjQwU9GE?t=00h41m00s)

[app see what's going on](https://youtu.be/HxupjQwU9GE?t=00h41m02s)

[because at the end of the day I want to](https://youtu.be/HxupjQwU9GE?t=00h41m06s)

[be able to modify this app to do stuff](https://youtu.be/HxupjQwU9GE?t=00h41m08s)

[so](https://youtu.be/HxupjQwU9GE?t=00h41m09s)

[we got it deployed to kubernetes that](https://youtu.be/HxupjQwU9GE?t=00h41m10s)

[was easy](https://youtu.be/HxupjQwU9GE?t=00h41m13s)

[easy](https://youtu.be/HxupjQwU9GE?t=00h41m15s)

[um but the nice part is this thing is](https://youtu.be/HxupjQwU9GE?t=00h41m17s)

[set up such that it knows my desired](https://youtu.be/HxupjQwU9GE?t=00h41m20s)

[State and kubernetes will will scale up](https://youtu.be/HxupjQwU9GE?t=00h41m23s)

[and uh try to account uh if things come](https://youtu.be/HxupjQwU9GE?t=00h41m27s)

[under heavy load or if something crashes](https://youtu.be/HxupjQwU9GE?t=00h41m30s)

[make sure things get restarted it's very](https://youtu.be/HxupjQwU9GE?t=00h41m32s)

[convenient because we have now told it](https://youtu.be/HxupjQwU9GE?t=00h41m34s)

[what we want it to do it now just](https://youtu.be/HxupjQwU9GE?t=00h41m37s)

[actively goes and does the needful to](https://youtu.be/HxupjQwU9GE?t=00h41m40s)

[try to maintain that state](https://youtu.be/HxupjQwU9GE?t=00h41m42s)

[which is perfect okay we got an app uh](https://youtu.be/HxupjQwU9GE?t=00h41m44s)

[step one launch app](https://youtu.be/HxupjQwU9GE?t=00h41m48s)

[let's see if we see the same problem](https://youtu.be/HxupjQwU9GE?t=00h41m51s)

[locally](https://youtu.be/HxupjQwU9GE?t=00h41m52s)

[let's see if we see the same problem](https://youtu.be/HxupjQwU9GE?t=00h41m55s)

[locally I'm a little curious how this is](https://youtu.be/HxupjQwU9GE?t=00h41m57s)

[actually set up](https://youtu.be/HxupjQwU9GE?t=00h41m59s)

[so there is some custom stuff](https://youtu.be/HxupjQwU9GE?t=00h42m00s)

[defined for pulling in hosting](https://youtu.be/HxupjQwU9GE?t=00h42m04s)

[environment I am noticing that it does](https://youtu.be/HxupjQwU9GE?t=00h42m08s)

[use](https://youtu.be/HxupjQwU9GE?t=00h42m11s)

[if you're not in development it assumes](https://youtu.be/HxupjQwU9GE?t=00h42m12s)

[kubernetes](https://youtu.be/HxupjQwU9GE?t=00h42m14s)

[which is cool and pulls stuff in okay so](https://youtu.be/HxupjQwU9GE?t=00h42m17s)

[let's see how maybe this app works](https://youtu.be/HxupjQwU9GE?t=00h42m21s)

[better locally](https://youtu.be/HxupjQwU9GE?t=00h42m23s)

[so autofill](https://youtu.be/HxupjQwU9GE?t=00h42m25s)

[uh create](https://youtu.be/HxupjQwU9GE?t=00h42m27s)

[tried demo try double voting](https://youtu.be/HxupjQwU9GE?t=00h42m33s)

[you've already voted in that poll](https://youtu.be/HxupjQwU9GE?t=00h42m36s)

[got it oh I see so it's just URL based](https://youtu.be/HxupjQwU9GE?t=00h42m38s)

[right so if I go create](https://youtu.be/HxupjQwU9GE?t=00h42m43s)

[this guy here is](https://youtu.be/HxupjQwU9GE?t=00h42m45s)

[that so it's it's URL slash P slash](https://youtu.be/HxupjQwU9GE?t=00h42m48s)

[share address okay that's](https://youtu.be/HxupjQwU9GE?t=00h42m52s)

[great](https://youtu.be/HxupjQwU9GE?t=00h42m55s)

[simulate other votes](https://youtu.be/HxupjQwU9GE?t=00h42m57s)

[I mean locally it looks like it works](https://youtu.be/HxupjQwU9GE?t=00h43m05s)

[great](https://youtu.be/HxupjQwU9GE?t=00h43m07s)

[oh oh Blue's pulling ahead this is](https://youtu.be/HxupjQwU9GE?t=00h43m16s)

[actually rather entertaining just to](https://youtu.be/HxupjQwU9GE?t=00h43m18s)

[watch on its own](https://youtu.be/HxupjQwU9GE?t=00h43m20s)

[that's kind of cool](https://youtu.be/HxupjQwU9GE?t=00h43m26s)

[okay but what we would like to do is see](https://youtu.be/HxupjQwU9GE?t=00h43m30s)

[this actually working on remote server](https://youtu.be/HxupjQwU9GE?t=00h43m32s)

[right because at the end of the day we](https://youtu.be/HxupjQwU9GE?t=00h43m36s)

[would like to go whoop](https://youtu.be/HxupjQwU9GE?t=00h43m37s)

[and create pull auto create](https://youtu.be/HxupjQwU9GE?t=00h43m39s)

[so and this is where things start to](https://youtu.be/HxupjQwU9GE?t=00h43m43s)

[fall over pretty quick](https://youtu.be/HxupjQwU9GE?t=00h43m45s)

[is the it looks like the signalr stuff](https://youtu.be/HxupjQwU9GE?t=00h43m47s)

[is](https://youtu.be/HxupjQwU9GE?t=00h43m50s)

[dying](https://youtu.be/HxupjQwU9GE?t=00h43m51s)

[oh so now hold on the add button is now](https://youtu.be/HxupjQwU9GE?t=00h43m54s)

[working](https://youtu.be/HxupjQwU9GE?t=00h43m56s)

[test](https://youtu.be/HxupjQwU9GE?t=00h43m58s)

[ooh](https://youtu.be/HxupjQwU9GE?t=00h44m01s)

[bar](https://youtu.be/HxupjQwU9GE?t=00h44m03s)

[create](https://youtu.be/HxupjQwU9GE?t=00h44m05s)

[this only gave me one and then it fell](https://youtu.be/HxupjQwU9GE?t=00h44m12s)

[over](https://youtu.be/HxupjQwU9GE?t=00h44m14s)

[okay so what is going on failed to start](https://youtu.be/HxupjQwU9GE?t=00h44m15s)

[transport](https://youtu.be/HxupjQwU9GE?t=00h44m17s)

[okay so it's trying to connect to the](https://youtu.be/HxupjQwU9GE?t=00h44m23s)

[signalr endpoint and](https://youtu.be/HxupjQwU9GE?t=00h44m25s)

[excuse me](https://youtu.be/HxupjQwU9GE?t=00h44m27s)

[and just straight up blowing up okay so](https://youtu.be/HxupjQwU9GE?t=00h44m29s)

[let's](https://youtu.be/HxupjQwU9GE?t=00h44m32s)

[check it here](https://youtu.be/HxupjQwU9GE?t=00h44m35s)

[uh uh okay so we're getting some 404s on](https://youtu.be/HxupjQwU9GE?t=00h44m38s)

[here hey would you stop it stop it stop](https://youtu.be/HxupjQwU9GE?t=00h44m43s)

[it stop it I want to resize the column](https://youtu.be/HxupjQwU9GE?t=00h44m47s)

[not be dumb and let me resize](https://youtu.be/HxupjQwU9GE?t=00h44m51s)

[be big](https://youtu.be/HxupjQwU9GE?t=00h44m53s)

[uh uh okay](https://youtu.be/HxupjQwU9GE?t=00h44m55s)

[underscore](https://youtu.be/HxupjQwU9GE?t=00h45m05s)

[okay so some fetches failed](https://youtu.be/HxupjQwU9GE?t=00h45m06s)

[why would we get bitten there](https://youtu.be/HxupjQwU9GE?t=00h45m11s)

[importantly why would we get some 404s](https://youtu.be/HxupjQwU9GE?t=00h45m16s)

[there](https://youtu.be/HxupjQwU9GE?t=00h45m18s)

[and just to confirm we should not be](https://youtu.be/HxupjQwU9GE?t=00h45m20s)

[seeing the same there](https://youtu.be/HxupjQwU9GE?t=00h45m23s)

[if we just pop you open you sit on the](https://youtu.be/HxupjQwU9GE?t=00h45m30s)

[side create pull](https://youtu.be/HxupjQwU9GE?t=00h45m34s)

[all right so this guy here](https://youtu.be/HxupjQwU9GE?t=00h45m40s)

[is perfectly happy](https://youtu.be/HxupjQwU9GE?t=00h45m42s)

[so there is so there's a number of](https://youtu.be/HxupjQwU9GE?t=00h45m51s)

[things something is unhappy about](https://youtu.be/HxupjQwU9GE?t=00h45m53s)

[I might though I'm trying to I'm missing](https://youtu.be/HxupjQwU9GE?t=00h45m56s)

[the thing](https://youtu.be/HxupjQwU9GE?t=00h45m59s)

[between bright lights in my face I can't](https://youtu.be/HxupjQwU9GE?t=00h46m00s)

[see where my title bars are okay](https://youtu.be/HxupjQwU9GE?t=00h46m02s)

[so yes that works fine locally but when](https://youtu.be/HxupjQwU9GE?t=00h46m07s)

[we are](https://youtu.be/HxupjQwU9GE?t=00h46m10s)

[I don't understand what these calls are](https://youtu.be/HxupjQwU9GE?t=00h46m15s)

[for](https://youtu.be/HxupjQwU9GE?t=00h46m17s)

[that's just a fetch](https://youtu.be/HxupjQwU9GE?t=00h46m20s)

[negotiate version okay so let's look at](https://youtu.be/HxupjQwU9GE?t=00h46m25s)

[the signalr configuration see how this](https://youtu.be/HxupjQwU9GE?t=00h46m29s)

[is set up so](https://youtu.be/HxupjQwU9GE?t=00h46m32s)

[add scoped add server-side Blazer at](https://youtu.be/HxupjQwU9GE?t=00h46m35s)

[razor pages](https://youtu.be/HxupjQwU9GE?t=00h46m39s)

[uh let's see](https://youtu.be/HxupjQwU9GE?t=00h46m41s)

[add redis clustering configuration](https://youtu.be/HxupjQwU9GE?t=00h46m45s)

[redis address redis address is coming](https://youtu.be/HxupjQwU9GE?t=00h46m49s)

[from the environment variable on Port](https://youtu.be/HxupjQwU9GE?t=00h46m51s)

[6379 so let's check the deployment and](https://youtu.be/HxupjQwU9GE?t=00h46m53s)

[make sure that we actually got](https://youtu.be/HxupjQwU9GE?t=00h46m58s)

[that set up](https://youtu.be/HxupjQwU9GE?t=00h47m00s)

[so there is a service redis 6379](https://youtu.be/HxupjQwU9GE?t=00h47m04s)

[I don't think the connection to redis is](https://youtu.be/HxupjQwU9GE?t=00h47m11s)

[the problem it's the signalr setup that](https://youtu.be/HxupjQwU9GE?t=00h47m13s)

[is](https://youtu.be/HxupjQwU9GE?t=00h47m15s)

[appearing to fail](https://youtu.be/HxupjQwU9GE?t=00h47m17s)

[am I blind where is the signalr stuff](https://youtu.be/HxupjQwU9GE?t=00h47m21s)

[not buried in here is it](https://youtu.be/HxupjQwU9GE?t=00h47m28s)

[you wouldn't be hiding in here would you](https://youtu.be/HxupjQwU9GE?t=00h47m31s)

[um use kubernetes configuration](https://youtu.be/HxupjQwU9GE?t=00h47m38s)

[uh let's see typed client get required](https://youtu.be/HxupjQwU9GE?t=00h47m44s)

[service](https://youtu.be/HxupjQwU9GE?t=00h47m48s)

[you don't happen to be hiding signalr](https://youtu.be/HxupjQwU9GE?t=00h47m50s)

[under the hood do you](https://youtu.be/HxupjQwU9GE?t=00h47m53s)

[kind of think you might be](https://youtu.be/HxupjQwU9GE?t=00h47m56s)

[close Robert if by WPF you mean](https://youtu.be/HxupjQwU9GE?t=00h47m59s)

[kubernetes Microsoft Orleans](https://youtu.be/HxupjQwU9GE?t=00h48m02s)

[then yes you are spot on the mark](https://youtu.be/HxupjQwU9GE?t=00h48m06s)

[um I don't understand where this thing](https://youtu.be/HxupjQwU9GE?t=00h48m11s)

[gets its set up](https://youtu.be/HxupjQwU9GE?t=00h48m15s)

[uh configure endpoints advertise Gateway](https://youtu.be/HxupjQwU9GE?t=00h48m20s)

[listen on host](https://youtu.be/HxupjQwU9GE?t=00h48m25s)

[figure that's just uh](https://youtu.be/HxupjQwU9GE?t=00h48m27s)

[usually sorry we don't use that means we](https://youtu.be/HxupjQwU9GE?t=00h48m36s)

[use that](https://youtu.be/HxupjQwU9GE?t=00h48m40s)

[well so I tried to take their lovely](https://youtu.be/HxupjQwU9GE?t=00h48m44s)

[little demo that they've put together](https://youtu.be/HxupjQwU9GE?t=00h48m46s)

[and deploy it out to a cluster which](https://youtu.be/HxupjQwU9GE?t=00h48m48s)

[I've successfully done so and I guess to](https://youtu.be/HxupjQwU9GE?t=00h48m50s)

[be fair if anybody wants to pound on the](https://youtu.be/HxupjQwU9GE?t=00h48m53s)

[cluster](https://youtu.be/HxupjQwU9GE?t=00h48m55s)

[there you go](https://youtu.be/HxupjQwU9GE?t=00h48m56s)

[um](https://youtu.be/HxupjQwU9GE?t=00h48m58s)

[and it's obviously failing and it](https://youtu.be/HxupjQwU9GE?t=00h49m03s)

[appears to be failing due to Signal r](https://youtu.be/HxupjQwU9GE?t=00h49m05s)

[inpoints](https://youtu.be/HxupjQwU9GE?t=00h49m09s)

[and I'm just not entirely clear where](https://youtu.be/HxupjQwU9GE?t=00h49m12s)

[the heck it actually sets up its signalr](https://youtu.be/HxupjQwU9GE?t=00h49m16s)

[stuff](https://youtu.be/HxupjQwU9GE?t=00h49m18s)

[or](https://youtu.be/HxupjQwU9GE?t=00h49m20s)

[even more which calls in particular are](https://youtu.be/HxupjQwU9GE?t=00h49m22s)

[failing like I see the fetches that are](https://youtu.be/HxupjQwU9GE?t=00h49m25s)

[failing](https://youtu.be/HxupjQwU9GE?t=00h49m28s)

[I'm just not clear what the heck](https://youtu.be/HxupjQwU9GE?t=00h49m36s)

[why one of these fetches would succeed](https://youtu.be/HxupjQwU9GE?t=00h49m44s)

[and one of these fetches would fail](https://youtu.be/HxupjQwU9GE?t=00h49m46s)

[uh let's see here](https://youtu.be/HxupjQwU9GE?t=00h49m51s)

[the server is blocking web sockets](https://youtu.be/HxupjQwU9GE?t=00h49m53s)

[that then does raise the question](https://youtu.be/HxupjQwU9GE?t=00h50m03s)

[how does one unblock it](https://youtu.be/HxupjQwU9GE?t=00h50m09s)

[do because I don't know how to configure](https://youtu.be/HxupjQwU9GE?t=00h50m13s)

[Orleans](https://youtu.be/HxupjQwU9GE?t=00h50m17s)

[so maybe we asked the Googles](https://youtu.be/HxupjQwU9GE?t=00h50m19s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h50m22s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h50m26s)

[foreign](https://youtu.be/HxupjQwU9GE?t=00h50m30s)

[this might be useful](https://youtu.be/HxupjQwU9GE?t=00h50m34s)

[oh](https://youtu.be/HxupjQwU9GE?t=00h50m37s)

[kubernetes sample application](https://youtu.be/HxupjQwU9GE?t=00h50m41s)

[there](https://youtu.be/HxupjQwU9GE?t=00h50m44s)

[okay great](https://youtu.be/HxupjQwU9GE?t=00h50m46s)

[great what I'm interested in is seeing](https://youtu.be/HxupjQwU9GE?t=00h50m50s)

[your setup](https://youtu.be/HxupjQwU9GE?t=00h50m52s)

[this looks remarkably similar to what we](https://youtu.be/HxupjQwU9GE?t=00h50m54s)

[did](https://youtu.be/HxupjQwU9GE?t=00h50m57s)

[there's the redis stuff](https://youtu.be/HxupjQwU9GE?t=00h50m59s)

[there's that](https://youtu.be/HxupjQwU9GE?t=00h51m01s)

[oh did I not](https://youtu.be/HxupjQwU9GE?t=00h51m10s)

[um hang on did I not set a cluster ID on](https://youtu.be/HxupjQwU9GE?t=00h51m13s)

[ours no we did](https://youtu.be/HxupjQwU9GE?t=00h51m16s)

[cases where you're not using rolling](https://youtu.be/HxupjQwU9GE?t=00h51m20s)

[deployments blue green deployances value](https://youtu.be/HxupjQwU9GE?t=00h51m22s)

[can allow for distinct clusters do not](https://youtu.be/HxupjQwU9GE?t=00h51m24s)

[communicate with each other but which](https://youtu.be/HxupjQwU9GE?t=00h51m26s)

[still share the same storage and other](https://youtu.be/HxupjQwU9GE?t=00h51m28s)

[resources](https://youtu.be/HxupjQwU9GE?t=00h51m29s)

[this feels like I did the right thing](https://youtu.be/HxupjQwU9GE?t=00h51m35s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h51m38s)

[Define ports which Orlean uses](https://youtu.be/HxupjQwU9GE?t=00h51m41s)

[five ones thirty thousand I think we](https://youtu.be/HxupjQwU9GE?t=00h51m44s)

[Define those same ports](https://youtu.be/HxupjQwU9GE?t=00h51m47s)

[oh look at that](https://youtu.be/HxupjQwU9GE?t=00h51m50s)

[now I don't know if anybody hang on we](https://youtu.be/HxupjQwU9GE?t=00h51m58s)

[might have to check more but there's](https://youtu.be/HxupjQwU9GE?t=00h52m01s)

[asp.net core ports](https://youtu.be/HxupjQwU9GE?t=00h52m02s)

[blah blah blah](https://youtu.be/HxupjQwU9GE?t=00h52m05s)

[because they might just be mapping it on](https://youtu.be/HxupjQwU9GE?t=00h52m11s)

[the other side](https://youtu.be/HxupjQwU9GE?t=00h52m14s)

[Orleans dashboard oh](https://youtu.be/HxupjQwU9GE?t=00h52m20s)

[let's to hypothetically go take a little](https://youtu.be/HxupjQwU9GE?t=00h52m24s)

[Gander at The Orleans dashboard then](https://youtu.be/HxupjQwU9GE?t=00h52m26s)

[while we're](https://youtu.be/HxupjQwU9GE?t=00h52m29s)

[while we're while we're looking](https://youtu.be/HxupjQwU9GE?t=00h52m30s)

[might as well](https://youtu.be/HxupjQwU9GE?t=00h52m33s)

[do you have a dashboard sitting there](https://youtu.be/HxupjQwU9GE?t=00h52m35s)

[did mention it in the readme](https://youtu.be/HxupjQwU9GE?t=00h52m42s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h52m45s)

[uh lean's dashboard](https://youtu.be/HxupjQwU9GE?t=00h52m49s)

[I'm noticing the roll bindings](https://youtu.be/HxupjQwU9GE?t=00h52m54s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h52m57s)

[uh uh for our back enabled clusters the](https://youtu.be/HxupjQwU9GE?t=00h52m59s)

[kubernetes service account for the pods](https://youtu.be/HxupjQwU9GE?t=00h53m01s)

[may also need to be granted required](https://youtu.be/HxupjQwU9GE?t=00h53m03s)

[access oh](https://youtu.be/HxupjQwU9GE?t=00h53m05s)

[this](https://youtu.be/HxupjQwU9GE?t=00h53m11s)

[that would not explain a mismatch on the](https://youtu.be/HxupjQwU9GE?t=00h53m15s)

[web sockets but that is interesting](https://youtu.be/HxupjQwU9GE?t=00h53m20s)

[uh you'll need to provision a role and](https://youtu.be/HxupjQwU9GE?t=00h53m25s)

[corresponding role binding if your](https://youtu.be/HxupjQwU9GE?t=00h53m27s)

[clusters are backed enabled which it is](https://youtu.be/HxupjQwU9GE?t=00h53m29s)

[but I did our yeah](https://youtu.be/HxupjQwU9GE?t=00h53m34s)

[good I didn't even read that far but I](https://youtu.be/HxupjQwU9GE?t=00h53m38s)

[did that anyway perfect](https://youtu.be/HxupjQwU9GE?t=00h53m40s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h53m42s)

[uh execute the following you did that we](https://youtu.be/HxupjQwU9GE?t=00h53m47s)

[did that](https://youtu.be/HxupjQwU9GE?t=00h53m50s)

[get pods watch](https://youtu.be/HxupjQwU9GE?t=00h53m52s)

[get service](https://youtu.be/HxupjQwU9GE?t=00h53m55s)

[right so this is this is wanting us to](https://youtu.be/HxupjQwU9GE?t=00h53m58s)

[do the](https://youtu.be/HxupjQwU9GE?t=00h54m01s)

[this guy here](https://youtu.be/HxupjQwU9GE?t=00h54m03s)

[this run around is kind of slow](https://youtu.be/HxupjQwU9GE?t=00h54m16s)

[kind of tempted to turn that off](https://youtu.be/HxupjQwU9GE?t=00h54m19s)

[like I know it has to do the](https://youtu.be/HxupjQwU9GE?t=00h54m21s)

[authentication stuff and everything but](https://youtu.be/HxupjQwU9GE?t=00h54m23s)

[come on when I invoke a CLI](https://youtu.be/HxupjQwU9GE?t=00h54m25s)

[yeah so same IP is the one that I did](https://youtu.be/HxupjQwU9GE?t=00h54m28s)

[before there's all that](https://youtu.be/HxupjQwU9GE?t=00h54m31s)

[now the interesting part is](https://youtu.be/HxupjQwU9GE?t=00h54m36s)

[it claims there's a dashboard but I](https://youtu.be/HxupjQwU9GE?t=00h54m41s)

[don't know where](https://youtu.be/HxupjQwU9GE?t=00h54m43s)

[I don't know what the the route would be](https://youtu.be/HxupjQwU9GE?t=00h54m48s)

[to it](https://youtu.be/HxupjQwU9GE?t=00h54m51s)

[because it doesn't really say](https://youtu.be/HxupjQwU9GE?t=00h54m52s)

[well editor host air](https://youtu.be/HxupjQwU9GE?t=00h54m56s)

[it's all the Orleans data stuff](https://youtu.be/HxupjQwU9GE?t=00h55m00s)

[main layout nav menu where where do you](https://youtu.be/HxupjQwU9GE?t=00h55m04s)

[live](https://youtu.be/HxupjQwU9GE?t=00h55m07s)

[are you hosting local or Azure well so](https://youtu.be/HxupjQwU9GE?t=00h55m09s)

[when I run locally it works just fine uh](https://youtu.be/HxupjQwU9GE?t=00h55m12s)

[this one is actually in Azure in AKs](https://youtu.be/HxupjQwU9GE?t=00h55m15s)

[so I do actually have it](https://youtu.be/HxupjQwU9GE?t=00h55m20s)

[out here and again it is technically](https://youtu.be/HxupjQwU9GE?t=00h55m22s)

[deploying](https://youtu.be/HxupjQwU9GE?t=00h55m26s)

[um if anybody wants to see the code](https://youtu.be/HxupjQwU9GE?t=00h55m29s)

[uh sure this will work](https://youtu.be/HxupjQwU9GE?t=00h55m32s)

[aside from the variable names to match](https://youtu.be/HxupjQwU9GE?t=00h55m36s)

[my](https://youtu.be/HxupjQwU9GE?t=00h55m38s)

[like Resource Group and cluster and](https://youtu.be/HxupjQwU9GE?t=00h55m40s)

[whatnot I have made no changes to it](https://youtu.be/HxupjQwU9GE?t=00h55m42s)

[so it is also interesting their image](https://youtu.be/HxupjQwU9GE?t=00h55m46s)

[does not match](https://youtu.be/HxupjQwU9GE?t=00h55m49s)

[their image does not match the the](https://youtu.be/HxupjQwU9GE?t=00h55m54s)

[running app](https://youtu.be/HxupjQwU9GE?t=00h55m57s)

[that's exciting](https://youtu.be/HxupjQwU9GE?t=00h55m59s)

[um](https://youtu.be/HxupjQwU9GE?t=00h56m01s)

[the dashboard will be available here so](https://youtu.be/HxupjQwU9GE?t=00h56m03s)

[hold on let's fire this guy up I want to](https://youtu.be/HxupjQwU9GE?t=00h56m05s)

[see this dashboard](https://youtu.be/HxupjQwU9GE?t=00h56m07s)

[what is this dashboard supposed to look](https://youtu.be/HxupjQwU9GE?t=00h56m10s)

[like](https://youtu.be/HxupjQwU9GE?t=00h56m12s)

[because if locally 888 it just deploys](https://youtu.be/HxupjQwU9GE?t=00h56m14s)

[okay so is the Azure instance enabling](https://youtu.be/HxupjQwU9GE?t=00h56m18s)

[websockets is by defaults most of the](https://youtu.be/HxupjQwU9GE?t=00h56m20s)

[time website is blocked or not enabled](https://youtu.be/HxupjQwU9GE?t=00h56m22s)

[see that is a great question Robert and](https://youtu.be/HxupjQwU9GE?t=00h56m24s)

[I](https://youtu.be/HxupjQwU9GE?t=00h56m27s)

[the answer is I have no bloody idea](https://youtu.be/HxupjQwU9GE?t=00h56m29s)

[okay I'm gonna assume](https://youtu.be/HxupjQwU9GE?t=00h56m37s)

[seems to work for me](https://youtu.be/HxupjQwU9GE?t=00h56m43s)

[can you be more specific](https://youtu.be/HxupjQwU9GE?t=00h56m48s)

[hitting my site seems to work for you](https://youtu.be/HxupjQwU9GE?t=00h56m50s)

[because that would be cool](https://youtu.be/HxupjQwU9GE?t=00h56m54s)

[or when you pull it locally it's working](https://youtu.be/HxupjQwU9GE?t=00h57m00s)

[for you](https://youtu.be/HxupjQwU9GE?t=00h57m02s)

[because I've clearly done something](https://youtu.be/HxupjQwU9GE?t=00h57m05s)

[stupid](https://youtu.be/HxupjQwU9GE?t=00h57m06s)

[which is a very strong possibility](https://youtu.be/HxupjQwU9GE?t=00h57m10s)

[I will say the only the other thing that](https://youtu.be/HxupjQwU9GE?t=00h57m14s)

[I have done slightly differently](https://youtu.be/HxupjQwU9GE?t=00h57m16s)

[I haven't done anything with websock](https://youtu.be/HxupjQwU9GE?t=00h57m19s)

[it's just hitting the IP loads your site](https://youtu.be/HxupjQwU9GE?t=00h57m20s)

[um okay can you do me one more favor](https://youtu.be/HxupjQwU9GE?t=00h57m25s)

[uh](https://youtu.be/HxupjQwU9GE?t=00h57m30s)

[if hitting that works](https://youtu.be/HxupjQwU9GE?t=00h57m41s)

[check teams yeah Robert I just thought I](https://youtu.be/HxupjQwU9GE?t=00h57m44s)

[have the dev tools popped on this guy](https://youtu.be/HxupjQwU9GE?t=00h57m47s)

[and I believe I'm seeing the same](https://youtu.be/HxupjQwU9GE?t=00h57m49s)

[information](https://youtu.be/HxupjQwU9GE?t=00h57m51s)

[um](https://youtu.be/HxupjQwU9GE?t=00h57m57s)

[long pulling fallback](https://youtu.be/HxupjQwU9GE?t=00h58m02s)

[so it's so](https://youtu.be/HxupjQwU9GE?t=00h58m05s)

[the normally I would go and](https://youtu.be/HxupjQwU9GE?t=00h58m07s)

[attempt to change this normalizing](https://youtu.be/HxupjQwU9GE?t=00h58m14s)

[Blazer 2 here](https://youtu.be/HxupjQwU9GE?t=00h58m17s)

[it's failed to make a proper websockets](https://youtu.be/HxupjQwU9GE?t=00h58m20s)

[connection I'm wondering if](https://youtu.be/HxupjQwU9GE?t=00h58m22s)

[there was an error with the transport](https://youtu.be/HxupjQwU9GE?t=00h58m28s)

[I don't know what to do with that](https://youtu.be/HxupjQwU9GE?t=00h58m31s)

[nor do I actually know how to enable it](https://youtu.be/HxupjQwU9GE?t=00h58m34s)

[so](https://youtu.be/HxupjQwU9GE?t=00h58m36s)

[that's part of why I was looking at this](https://youtu.be/HxupjQwU9GE?t=00h58m38s)

[guy's other sample because I](https://youtu.be/HxupjQwU9GE?t=00h58m40s)

[apparently they turn on the appropriate](https://youtu.be/HxupjQwU9GE?t=00h58m43s)

[stuff](https://youtu.be/HxupjQwU9GE?t=00h58m45s)

[and maybe I'm just stupid but](https://youtu.be/HxupjQwU9GE?t=00h58m50s)

[something seems to be different than](https://youtu.be/HxupjQwU9GE?t=00h58m57s)

[this is what I love is everybody has](https://youtu.be/HxupjQwU9GE?t=00h59m00s)

[samples and](https://youtu.be/HxupjQwU9GE?t=00h59m02s)

[sample no workie for me](https://youtu.be/HxupjQwU9GE?t=00h59m04s)

[and not clear why because a lot of these](https://youtu.be/HxupjQwU9GE?t=00h59m06s)

[a lot of this readme appears to match](https://youtu.be/HxupjQwU9GE?t=00h59m09s)

[the default](https://youtu.be/HxupjQwU9GE?t=00h59m11s)

[Orleans one](https://youtu.be/HxupjQwU9GE?t=00h59m14s)

[um is there anything fancy that was done](https://youtu.be/HxupjQwU9GE?t=00h59m16s)

[inside of here because this guy](https://youtu.be/HxupjQwU9GE?t=00h59m19s)

[they don't do anything fancy they](https://youtu.be/HxupjQwU9GE?t=00h59m25s)

[effectively the same thing](https://youtu.be/HxupjQwU9GE?t=00h59m28s)

[I'm gonna just check his configuration](https://youtu.be/HxupjQwU9GE?t=00h59m32s)

[don't see anything that would cause](https://youtu.be/HxupjQwU9GE?t=00h59m42s)

[me any headaches](https://youtu.be/HxupjQwU9GE?t=00h59m48s)

[this one is an older net five one](https://youtu.be/HxupjQwU9GE?t=00h59m51s)

[and I a slightly older one here so](https://youtu.be/HxupjQwU9GE?t=00h59m56s)

[uh okay kubernetes hosting let's take a](https://youtu.be/HxupjQwU9GE?t=01h00m00s)

[look here](https://youtu.be/HxupjQwU9GE?t=01h00m03s)

[uh package ads integration because this](https://youtu.be/HxupjQwU9GE?t=01h00m04s)

[is this is the big difference between](https://youtu.be/HxupjQwU9GE?t=01h00m08s)

[the the local deploy the local Dev](https://youtu.be/HxupjQwU9GE?t=01h00m09s)

[environment and not is](https://youtu.be/HxupjQwU9GE?t=01h00m13s)

[these set of changes here](https://youtu.be/HxupjQwU9GE?t=01h00m16s)

[um I'm thinking](https://youtu.be/HxupjQwU9GE?t=01h00m20s)

[uh set to the Pod ID](https://youtu.be/HxupjQwU9GE?t=01h00m25s)

[so these ones here so the fact that 30](https://youtu.be/HxupjQwU9GE?t=01h00m34s)

[000 isn't exposed might be problematic](https://youtu.be/HxupjQwU9GE?t=01h00m39s)

[I'm wondering if that's the change is](https://youtu.be/HxupjQwU9GE?t=01h00m42s)

[that the kubernetes Orleans package](https://youtu.be/HxupjQwU9GE?t=01h00m44s)

[changed where it's going and the cluster](https://youtu.be/HxupjQwU9GE?t=01h00m47s)

[isn't exposing it](https://youtu.be/HxupjQwU9GE?t=01h00m50s)

[so let's see to find the ports on which](https://youtu.be/HxupjQwU9GE?t=01h00m56s)

[Orlean uses](https://youtu.be/HxupjQwU9GE?t=01h00m58s)

[uh and which pods it is running in great](https://youtu.be/HxupjQwU9GE?t=01h01m06s)

[okay so I think this is probably I'm](https://youtu.be/HxupjQwU9GE?t=01h01m13s)

[gonna assume this is probably close](https://youtu.be/HxupjQwU9GE?t=01h01m17s)

[updated March okay so let's let's start](https://youtu.be/HxupjQwU9GE?t=01h01m19s)

[here I think what we want to do is we](https://youtu.be/HxupjQwU9GE?t=01h01m22s)

[want to do these](https://youtu.be/HxupjQwU9GE?t=01h01m24s)

[all right and assume that this is going](https://youtu.be/HxupjQwU9GE?t=01h01m26s)

[to be set up there](https://youtu.be/HxupjQwU9GE?t=01h01m29s)

[I think](https://youtu.be/HxupjQwU9GE?t=01h01m31s)

[so let's go back to our deployment](https://youtu.be/HxupjQwU9GE?t=01h01m33s)

[uh let's see HTTP https](https://youtu.be/HxupjQwU9GE?t=01h01m42s)

[and we're going to do](https://youtu.be/HxupjQwU9GE?t=01h01m47s)

[yeah so if we expose those ports on the](https://youtu.be/HxupjQwU9GE?t=01h01m50s)

[container](https://youtu.be/HxupjQwU9GE?t=01h01m54s)

[though I don't know if this is going to](https://youtu.be/HxupjQwU9GE?t=01h01m58s)

[make much of a difference because the](https://youtu.be/HxupjQwU9GE?t=01h01m59s)

[issue is with the client browser trying](https://youtu.be/HxupjQwU9GE?t=01h02m01s)

[to get back](https://youtu.be/HxupjQwU9GE?t=01h02m03s)

[you know what because I don't know how](https://youtu.be/HxupjQwU9GE?t=01h02m07s)

[they're configuring this under the hood](https://youtu.be/HxupjQwU9GE?t=01h02m09s)

[we're gonna just send it](https://youtu.be/HxupjQwU9GE?t=01h02m10s)

[Okay so](https://youtu.be/HxupjQwU9GE?t=01h02m12s)

[fire in the hole](https://youtu.be/HxupjQwU9GE?t=01h02m17s)

[Cube cuddle apply](https://youtu.be/HxupjQwU9GE?t=01h02m21s)

[that out the other thing we could do is](https://youtu.be/HxupjQwU9GE?t=01h02m25s)

[we could actually pull the logs](https://youtu.be/HxupjQwU9GE?t=01h02m29s)

[I guess that's another thing I don't](https://youtu.be/HxupjQwU9GE?t=01h02m33s)

[know if there will be](https://youtu.be/HxupjQwU9GE?t=01h02m35s)

[much of interest but if we go here I](https://youtu.be/HxupjQwU9GE?t=01h02m37s)

[believe](https://youtu.be/HxupjQwU9GE?t=01h02m41s)

[oh oh hold up hold up hold up what do we](https://youtu.be/HxupjQwU9GE?t=01h02m42s)

[got going on](https://youtu.be/HxupjQwU9GE?t=01h02m46s)

[oh almost like](https://youtu.be/HxupjQwU9GE?t=01h02m48s)

[oh wait this is in the middle of a](https://youtu.be/HxupjQwU9GE?t=01h02m50s)

[deployment](https://youtu.be/HxupjQwU9GE?t=01h02m52s)

[never mind never mind so you'll note](https://youtu.be/HxupjQwU9GE?t=01h02m53s)

[unchanged unchanged unchanged](https://youtu.be/HxupjQwU9GE?t=01h02m56s)

[configured unchanged unchanged okay](https://youtu.be/HxupjQwU9GE?t=01h02m59s)

[so this thing went](https://youtu.be/HxupjQwU9GE?t=01h03m03s)

[we'll give it a moment](https://youtu.be/HxupjQwU9GE?t=01h03m05s)

[because this thing is probably in the](https://youtu.be/HxupjQwU9GE?t=01h03m09s)

[process of](https://youtu.be/HxupjQwU9GE?t=01h03m11s)

[deploying itself](https://youtu.be/HxupjQwU9GE?t=01h03m13s)

[here's a new one up and running it's](https://youtu.be/HxupjQwU9GE?t=01h03m19s)

[just](https://youtu.be/HxupjQwU9GE?t=01h03m22s)

[take a little look-see at the container](https://youtu.be/HxupjQwU9GE?t=01h03m23s)

[logs](https://youtu.be/HxupjQwU9GE?t=01h03m26s)

[uh projected volume](https://youtu.be/HxupjQwU9GE?t=01h03m28s)

[there's all the stuff](https://youtu.be/HxupjQwU9GE?t=01h03m32s)

[uh Orleans service ID cluster ID](https://youtu.be/HxupjQwU9GE?t=01h03m35s)

[and those are all sourced source source](https://youtu.be/HxupjQwU9GE?t=01h03m39s)

[great great great that](https://youtu.be/HxupjQwU9GE?t=01h03m43s)

[seems to align with the documentation](https://youtu.be/HxupjQwU9GE?t=01h03m45s)

[that we just saw live logs](https://youtu.be/HxupjQwU9GE?t=01h03m47s)

[come on give me logs logs logs](https://youtu.be/HxupjQwU9GE?t=01h03m52s)

[select a pod I thought I already did](https://youtu.be/HxupjQwU9GE?t=01h03m57s)

[come on](https://youtu.be/HxupjQwU9GE?t=01h04m00s)

[dreaming logs will appear as available](https://youtu.be/HxupjQwU9GE?t=01h04m06s)

[but one of the things that might be](https://youtu.be/HxupjQwU9GE?t=01h04m12s)

[mildly obnoxious is the scale of this](https://youtu.be/HxupjQwU9GE?t=01h04m13s)

[thing](https://youtu.be/HxupjQwU9GE?t=01h04m16s)

[um](https://youtu.be/HxupjQwU9GE?t=01h04m19s)

[we're gonna we're gonna make this easy](https://youtu.be/HxupjQwU9GE?t=01h04m24s)

[we're gonna dial this thing down to one](https://youtu.be/HxupjQwU9GE?t=01h04m26s)

[replica](https://youtu.be/HxupjQwU9GE?t=01h04m28s)

[we don't need three copies of it yet](https://youtu.be/HxupjQwU9GE?t=01h04m29s)

[we'll do one copy](https://youtu.be/HxupjQwU9GE?t=01h04m31s)

[make it work that way I don't have to](https://youtu.be/HxupjQwU9GE?t=01h04m34s)

[worry about like](https://youtu.be/HxupjQwU9GE?t=01h04m36s)

[wires getting crossed one instance](https://youtu.be/HxupjQwU9GE?t=01h04m38s)

[uh okay so](https://youtu.be/HxupjQwU9GE?t=01h04m43s)

[logs are flowing](https://youtu.be/HxupjQwU9GE?t=01h04m48s)

[za but let's wait until the deployment](https://youtu.be/HxupjQwU9GE?t=01h04m51s)

[succeeds](https://youtu.be/HxupjQwU9GE?t=01h04m55s)

[uh because this should](https://youtu.be/HxupjQwU9GE?t=01h04m57s)

[okay so now we're down to one](https://youtu.be/HxupjQwU9GE?t=01h05m01s)

[huzzah okay so now we only got one](https://youtu.be/HxupjQwU9GE?t=01h05m03s)

[instance of the app thank goodness okay](https://youtu.be/HxupjQwU9GE?t=01h05m04s)

[now when we hit it we're gonna be](https://youtu.be/HxupjQwU9GE?t=01h05m07s)

[hitting the one](https://youtu.be/HxupjQwU9GE?t=01h05m09s)

[okay so we go here](https://youtu.be/HxupjQwU9GE?t=01h05m11s)

[we go here](https://youtu.be/HxupjQwU9GE?t=01h05m14s)

[we go clicky clicky on](https://youtu.be/HxupjQwU9GE?t=01h05m16s)

[URL](https://youtu.be/HxupjQwU9GE?t=01h05m20s)

[nope nope ah stop okay](https://youtu.be/HxupjQwU9GE?t=01h05m21s)

[uh sure refresh](https://youtu.be/HxupjQwU9GE?t=01h05m26s)

[and then create poll](https://youtu.be/HxupjQwU9GE?t=01h05m31s)

[autofill](https://youtu.be/HxupjQwU9GE?t=01h05m34s)

[create](https://youtu.be/HxupjQwU9GE?t=01h05m36s)

[maybe it was just a port number](https://youtu.be/HxupjQwU9GE?t=01h05m48s)

[foreign](https://youtu.be/HxupjQwU9GE?t=01h05m52s)

[we have to test that here in a second](https://youtu.be/HxupjQwU9GE?t=01h05m58s)

[but uh that looks like success to me](https://youtu.be/HxupjQwU9GE?t=01h05m59s)

[that that definitely looks like success](https://youtu.be/HxupjQwU9GE?t=01h06m03s)

[okay back to create pull uh](https://youtu.be/HxupjQwU9GE?t=01h06m08s)

[uh is your favorite](https://youtu.be/HxupjQwU9GE?t=01h06m11s)

[stream and we're gonna go with uh](https://youtu.be/HxupjQwU9GE?t=01h06m15s)

[which](https://youtu.be/HxupjQwU9GE?t=01h06m20s)

[uh add](https://youtu.be/HxupjQwU9GE?t=01h06m23s)

[YouTube](https://youtu.be/HxupjQwU9GE?t=01h06m26s)

[add uh](https://youtu.be/HxupjQwU9GE?t=01h06m28s)

[so create obviously and then if I share](https://youtu.be/HxupjQwU9GE?t=01h06m34s)

[this pull out](https://youtu.be/HxupjQwU9GE?t=01h06m37s)

[theoretically](https://youtu.be/HxupjQwU9GE?t=01h06m39s)

[people can go to that URL](https://youtu.be/HxupjQwU9GE?t=01h06m41s)

[and then vote](https://youtu.be/HxupjQwU9GE?t=01h06m44s)

[and then with any luck](https://youtu.be/HxupjQwU9GE?t=01h06m47s)

[if someone could click a button that](https://youtu.be/HxupjQwU9GE?t=01h06m51s)

[would make me feel really good because](https://youtu.be/HxupjQwU9GE?t=01h06m52s)

[I'd like to see something come through](https://youtu.be/HxupjQwU9GE?t=01h06m54s)

[that's not me](https://youtu.be/HxupjQwU9GE?t=01h06m55s)

[and without me having to spin a VM and](https://youtu.be/HxupjQwU9GE?t=01h06m57s)

[and pseudo somebody else](https://youtu.be/HxupjQwU9GE?t=01h06m59s)

[okay so if that that seemed like it's](https://youtu.be/HxupjQwU9GE?t=01h07m04s)

[working](https://youtu.be/HxupjQwU9GE?t=01h07m08s)

[that might be okay that is](https://youtu.be/HxupjQwU9GE?t=01h07m13s)

[cool we might leave it down at one](https://youtu.be/HxupjQwU9GE?t=01h07m16s)

[replica for now](https://youtu.be/HxupjQwU9GE?t=01h07m18s)

[because the goal is to to test it and](https://youtu.be/HxupjQwU9GE?t=01h07m20s)

[push it over](https://youtu.be/HxupjQwU9GE?t=01h07m23s)

[so I'll leave it sitting there no one](https://youtu.be/HxupjQwU9GE?t=01h07m25s)

[else is clicking the button that's fine](https://youtu.be/HxupjQwU9GE?t=01h07m27s)

[that's fine](https://youtu.be/HxupjQwU9GE?t=01h07m28s)

[but](https://youtu.be/HxupjQwU9GE?t=01h07m34s)

[Okay so](https://youtu.be/HxupjQwU9GE?t=01h07m36s)

[that is sitting there](https://youtu.be/HxupjQwU9GE?t=01h07m38s)

[that is deployed okay](https://youtu.be/HxupjQwU9GE?t=01h07m41s)

[okay now on to the weirdness](https://youtu.be/HxupjQwU9GE?t=01h07m43s)

[python](https://youtu.be/HxupjQwU9GE?t=01h07m47s)

[okay so I I believe I have python](https://youtu.be/HxupjQwU9GE?t=01h07m48s)

[installed let's let's new tap new tap](https://youtu.be/HxupjQwU9GE?t=01h07m51s)

[for now](https://youtu.be/HxupjQwU9GE?t=01h07m54s)

[python](https://youtu.be/HxupjQwU9GE?t=01h07m56s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h07m57s)

[uh I I do know a small amount of python](https://youtu.be/HxupjQwU9GE?t=01h08m00s)

[emphasis on small](https://youtu.be/HxupjQwU9GE?t=01h08m04s)

[uh feel free to mock me uh okay so step](https://youtu.be/HxupjQwU9GE?t=01h08m06s)

[one install python check step two](https://youtu.be/HxupjQwU9GE?t=01h08m10s)

[install Locus](https://youtu.be/HxupjQwU9GE?t=01h08m13s)

[sentence I never thought I would need to](https://youtu.be/HxupjQwU9GE?t=01h08m16s)

[say but sure let's do that](https://youtu.be/HxupjQwU9GE?t=01h08m17s)

[again I want to see how](https://youtu.be/HxupjQwU9GE?t=01h08m25s)

[how hard I can push this little guy](https://youtu.be/HxupjQwU9GE?t=01h08m28s)

[and have it go](https://youtu.be/HxupjQwU9GE?t=01h08m31s)

[I'm guessing somebody clicked to](https://youtu.be/HxupjQwU9GE?t=01h08m38s)

[simulate other votes](https://youtu.be/HxupjQwU9GE?t=01h08m40s)

[given that I've seen vote counts that](https://youtu.be/HxupjQwU9GE?t=01h08m43s)

[are exceeding the number of viewers on](https://youtu.be/HxupjQwU9GE?t=01h08m46s)

[the stream I'm gonna guess that that](https://youtu.be/HxupjQwU9GE?t=01h08m47s)

[happened](https://youtu.be/HxupjQwU9GE?t=01h08m50s)

[though points awarded](https://youtu.be/HxupjQwU9GE?t=01h08m56s)

[I did sorry](https://youtu.be/HxupjQwU9GE?t=01h08m59s)

[I'll be sorry I find it kind of funny](https://youtu.be/HxupjQwU9GE?t=01h09m02s)

[um](https://youtu.be/HxupjQwU9GE?t=01h09m05s)

[but at least now but at least now we get](https://youtu.be/HxupjQwU9GE?t=01h09m09s)

[to see the the votes trickle in so again](https://youtu.be/HxupjQwU9GE?t=01h09m11s)

[my goal is I want to see I want to know](https://youtu.be/HxupjQwU9GE?t=01h09m14s)

[how hard I can push Orleans on a tiny](https://youtu.be/HxupjQwU9GE?t=01h09m16s)

[little VM before the thing Falls over](https://youtu.be/HxupjQwU9GE?t=01h09m20s)

[that's the goal and I don't know if this](https://youtu.be/HxupjQwU9GE?t=01h09m23s)

[code's really been optimized or if it's](https://youtu.be/HxupjQwU9GE?t=01h09m26s)

[small sample code I suspect the latter](https://youtu.be/HxupjQwU9GE?t=01h09m28s)

[but I'm still curious to know and I'm](https://youtu.be/HxupjQwU9GE?t=01h09m30s)

[also curious to to learn this Locus](https://youtu.be/HxupjQwU9GE?t=01h09m32s)

[thing a little bit so okay so that's](https://youtu.be/HxupjQwU9GE?t=01h09m34s)

[going the other thing we kind of want to](https://youtu.be/HxupjQwU9GE?t=01h09m36s)

[look at](https://youtu.be/HxupjQwU9GE?t=01h09m39s)

[is this button](https://youtu.be/HxupjQwU9GE?t=01h09m41s)

[or can we just do insights I thought](https://youtu.be/HxupjQwU9GE?t=01h09m45s)

[there was a nice one of these has a nice](https://youtu.be/HxupjQwU9GE?t=01h09m47s)

[overview](https://youtu.be/HxupjQwU9GE?t=01h09m49s)

[uh container](https://youtu.be/HxupjQwU9GE?t=01h09m51s)

[status not configured](https://youtu.be/HxupjQwU9GE?t=01h09m54s)

[uh for each node in addition you can](https://youtu.be/HxupjQwU9GE?t=01h09m56s)

[Prometheus metrics to get insights about](https://youtu.be/HxupjQwU9GE?t=01h09m59s)

[performance and health](https://youtu.be/HxupjQwU9GE?t=01h10m01s)

[you know what I don't intend to leave](https://youtu.be/HxupjQwU9GE?t=01h10m04s)

[this cluster running how much could it](https://youtu.be/HxupjQwU9GE?t=01h10m05s)

[possibly cost](https://youtu.be/HxupjQwU9GE?t=01h10m07s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h10m09s)

[um](https://youtu.be/HxupjQwU9GE?t=01h10m10s)

[managed identity preview](https://youtu.be/HxupjQwU9GE?t=01h10m13s)

[ah log analytics workspace I can](https://youtu.be/HxupjQwU9GE?t=01h10m16s)

[guarantee you that's the uh expensive](https://youtu.be/HxupjQwU9GE?t=01h10m19s)

[bit logs in Azure can get very expensive](https://youtu.be/HxupjQwU9GE?t=01h10m21s)

[very quick](https://youtu.be/HxupjQwU9GE?t=01h10m25s)

[um](https://youtu.be/HxupjQwU9GE?t=01h10m28s)

[so let's do this because I don't I don't](https://youtu.be/HxupjQwU9GE?t=01h10m30s)

[know if I necessarily need Prometheus](https://youtu.be/HxupjQwU9GE?t=01h10m32s)

[yet](https://youtu.be/HxupjQwU9GE?t=01h10m34s)

[okay you you do the needful](https://youtu.be/HxupjQwU9GE?t=01h10m37s)

[and then hopefully this thing goes](https://youtu.be/HxupjQwU9GE?t=01h10m41s)

[and I get pretty](https://youtu.be/HxupjQwU9GE?t=01h10m44s)

[pretty metrics did we not turn you on](https://youtu.be/HxupjQwU9GE?t=01h10m47s)

[are you still going](https://youtu.be/HxupjQwU9GE?t=01h10m51s)

[uh let's see](https://youtu.be/HxupjQwU9GE?t=01h10m55s)

[but uh this will be a lesson in how to](https://youtu.be/HxupjQwU9GE?t=01h10m58s)

[burn all your Azure credits in a single](https://youtu.be/HxupjQwU9GE?t=01h11m01s)

[day](https://youtu.be/HxupjQwU9GE?t=01h11m02s)

[um the other thing we could probably do](https://youtu.be/HxupjQwU9GE?t=01h11m04s)

[that might be worth note going is](https://youtu.be/HxupjQwU9GE?t=01h11m06s)

[this guy here this might be](https://youtu.be/HxupjQwU9GE?t=01h11m11s)

[this might be good enough to watch](https://youtu.be/HxupjQwU9GE?t=01h11m14s)

[um see all metrics](https://youtu.be/HxupjQwU9GE?t=01h11m20s)

[we can probably do it in here select](https://youtu.be/HxupjQwU9GE?t=01h11m21s)

[metrics](https://youtu.be/HxupjQwU9GE?t=01h11m24s)

[uh uh CPU usage percentage](https://youtu.be/HxupjQwU9GE?t=01h11m26s)

[so that's](https://youtu.be/HxupjQwU9GE?t=01h11m31s)

[probably](https://youtu.be/HxupjQwU9GE?t=01h11m33s)

[yeah I think we're going to be most](https://youtu.be/HxupjQwU9GE?t=01h11m38s)

[interested in CPU](https://youtu.be/HxupjQwU9GE?t=01h11m40s)

[and probably memory I think is going to](https://youtu.be/HxupjQwU9GE?t=01h11m42s)

[be what else I care about](https://youtu.be/HxupjQwU9GE?t=01h11m45s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h11m48s)

[um](https://youtu.be/HxupjQwU9GE?t=01h11m49s)

[memory working set bytes](https://youtu.be/HxupjQwU9GE?t=01h11m52s)

[see how this goes](https://youtu.be/HxupjQwU9GE?t=01h11m55s)

[your Azure my numbers are cut off](https://youtu.be/HxupjQwU9GE?t=01h11m58s)

[I'm I'm sure that's a tiny number but](https://youtu.be/HxupjQwU9GE?t=01h12m03s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h12m10s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h12m12s)

[that's a large time scale that is a good](https://youtu.be/HxupjQwU9GE?t=01h12m13s)

[point](https://youtu.be/HxupjQwU9GE?t=01h12m16s)

[um](https://youtu.be/HxupjQwU9GE?t=01h12m18s)

[yeah I would like to dial this in](https://youtu.be/HxupjQwU9GE?t=01h12m21s)

[smaller how do I get in closer oh local](https://youtu.be/HxupjQwU9GE?t=01h12m24s)

[time last 24 hours about last 30 minutes](https://youtu.be/HxupjQwU9GE?t=01h12m27s)

[there we go that's better that's better](https://youtu.be/HxupjQwU9GE?t=01h12m31s)

[that's better okay so let's so short](https://youtu.be/HxupjQwU9GE?t=01h12m33s)

[version the thing running on auto votes](https://youtu.be/HxupjQwU9GE?t=01h12m37s)

[is like](https://youtu.be/HxupjQwU9GE?t=01h12m41s)

[not a lot](https://youtu.be/HxupjQwU9GE?t=01h12m43s)

[it can it can handle that but I would](https://youtu.be/HxupjQwU9GE?t=01h12m45s)

[argue whatever this thing's doing to](https://youtu.be/HxupjQwU9GE?t=01h12m47s)

[simulate is probably not a ton and the](https://youtu.be/HxupjQwU9GE?t=01h12m49s)

[other thing is because this Blazer I'm](https://youtu.be/HxupjQwU9GE?t=01h12m52s)

[I'm guessing rollers you must have](https://youtu.be/HxupjQwU9GE?t=01h12m54s)

[closed your browser or migrated away](https://youtu.be/HxupjQwU9GE?t=01h12m55s)

[because it's it's not going to push it](https://youtu.be/HxupjQwU9GE?t=01h12m57s)

[that hard okay so we'll leave that there](https://youtu.be/HxupjQwU9GE?t=01h13m00s)

[because what I'd like to do](https://youtu.be/HxupjQwU9GE?t=01h13m02s)

[is write a little test that goes into](https://youtu.be/HxupjQwU9GE?t=01h13m04s)

[here and just have it click on one I](https://youtu.be/HxupjQwU9GE?t=01h13m07s)

[really don't care what uh validate your](https://youtu.be/HxupjQwU9GE?t=01h13m10s)

[installation okay we will validate our](https://youtu.be/HxupjQwU9GE?t=01h13m12s)

[installation](https://youtu.be/HxupjQwU9GE?t=01h13m15s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h13m16s)

[hang on a new release](https://youtu.be/HxupjQwU9GE?t=01h13m19s)

[so hold on what are you what are you](https://youtu.be/HxupjQwU9GE?t=01h13m24s)

[unhappy about](https://youtu.be/HxupjQwU9GE?t=01h13m26s)

[installing collected packages running Pi](https://youtu.be/HxupjQwU9GE?t=01h13m28s)

[install deprecation something something](https://youtu.be/HxupjQwU9GE?t=01h13m31s)

[something](https://youtu.be/HxupjQwU9GE?t=01h13m33s)

[you have to do a new Powershell window](https://youtu.be/HxupjQwU9GE?t=01h13m35s)

[ah thank you](https://youtu.be/HxupjQwU9GE?t=01h13m36s)

[oh I if it did I bet you I have to shut](https://youtu.be/HxupjQwU9GE?t=01h13m44s)

[the thing down](https://youtu.be/HxupjQwU9GE?t=01h13m47s)

[let's go here](https://youtu.be/HxupjQwU9GE?t=01h13m49s)

[uh uh](https://youtu.be/HxupjQwU9GE?t=01h13m57s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h14m01s)

[so let's I probably should have saved](https://youtu.be/HxupjQwU9GE?t=01h14m05s)

[that that line that I did let's just](https://youtu.be/HxupjQwU9GE?t=01h14m07s)

[kick this off again real quick because](https://youtu.be/HxupjQwU9GE?t=01h14m09s)

[I'm guessing](https://youtu.be/HxupjQwU9GE?t=01h14m11s)

[uh because it is actually like it](https://youtu.be/HxupjQwU9GE?t=01h14m15s)

[installed something](https://youtu.be/HxupjQwU9GE?t=01h14m18s)

[like python has something in here uh](https://youtu.be/HxupjQwU9GE?t=01h14m20s)

[okay so let's real quick we're gonna do](https://youtu.be/HxupjQwU9GE?t=01h14m24s)

[we're gonna do the PIP upgrade because](https://youtu.be/HxupjQwU9GE?t=01h14m29s)

[why not](https://youtu.be/HxupjQwU9GE?t=01h14m33s)

[you can access your previous commands by](https://youtu.be/HxupjQwU9GE?t=01h14m37s)

[hitting the up Arrow thank you yes I](https://youtu.be/HxupjQwU9GE?t=01h14m39s)

[often forget about that I was mostly](https://youtu.be/HxupjQwU9GE?t=01h14m41s)

[looking to get the output of from the](https://youtu.be/HxupjQwU9GE?t=01h14m42s)

[previous command but yes that would have](https://youtu.be/HxupjQwU9GE?t=01h14m45s)

[been a much easier easier option do you](https://youtu.be/HxupjQwU9GE?t=01h14m46s)

[have more than one version of python](https://youtu.be/HxupjQwU9GE?t=01h14m49s)

[installed](https://youtu.be/HxupjQwU9GE?t=01h14m50s)

[uh I certainly hope not but I did do](https://youtu.be/HxupjQwU9GE?t=01h14m52s)

[something a little unusual](https://youtu.be/HxupjQwU9GE?t=01h14m55s)

[um I did install these from](https://youtu.be/HxupjQwU9GE?t=01h14m57s)

[uh the Windows store which in retrospect](https://youtu.be/HxupjQwU9GE?t=01h15m02s)

[probably not the normal way to install](https://youtu.be/HxupjQwU9GE?t=01h15m04s)

[python](https://youtu.be/HxupjQwU9GE?t=01h15m06s)

[probably not](https://youtu.be/HxupjQwU9GE?t=01h15m09s)

[uh uh okay](https://youtu.be/HxupjQwU9GE?t=01h15m10s)

[so let's see this thing has done all of](https://youtu.be/HxupjQwU9GE?t=01h15m13s)

[the stuff](https://youtu.be/HxupjQwU9GE?t=01h15m16s)

[am I supposed to be](https://youtu.be/HxupjQwU9GE?t=01h15m19s)

[Okay so](https://youtu.be/HxupjQwU9GE?t=01h15m32s)

[as not a script file check the spelling](https://youtu.be/HxupjQwU9GE?t=01h15m38s)

[or try again](https://youtu.be/HxupjQwU9GE?t=01h15m41s)

[I am](https://youtu.be/HxupjQwU9GE?t=01h15m43s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h15m45s)

[mildly confused as to how this is](https://youtu.be/HxupjQwU9GE?t=01h15m48s)

[supposed to go](https://youtu.be/HxupjQwU9GE?t=01h15m51s)

[I'm somewhat tempted to think that it is](https://youtu.be/HxupjQwU9GE?t=01h15m54s)

[somewhat tempted to try this](https://youtu.be/HxupjQwU9GE?t=01h16m02s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h16m05s)

[um](https://youtu.be/HxupjQwU9GE?t=01h16m06s)

[this will make for a full explanation](https://youtu.be/HxupjQwU9GE?t=01h16m09s)

[right lucasfiled](https://youtu.be/HxupjQwU9GE?t=01h16m12s)

[okay so hold on let's let's do let's do](https://youtu.be/HxupjQwU9GE?t=01h16m14s)

[something](https://youtu.be/HxupjQwU9GE?t=01h16m18s)

[Orleans](https://youtu.be/HxupjQwU9GE?t=01h16m19s)

[uh let's see samples voting](https://youtu.be/HxupjQwU9GE?t=01h16m21s)

[uh make their](https://youtu.be/HxupjQwU9GE?t=01h16m26s)

[let's do that](https://youtu.be/HxupjQwU9GE?t=01h16m29s)

[let's just get ourselves into a](https://youtu.be/HxupjQwU9GE?t=01h16m30s)

[reasonable scene uh I assume this is a](https://youtu.be/HxupjQwU9GE?t=01h16m32s)

[kubernetes thing or what's the goal so](https://youtu.be/HxupjQwU9GE?t=01h16m35s)

[the goal here is](https://youtu.be/HxupjQwU9GE?t=01h16m37s)

[I've got this little voting app deployed](https://youtu.be/HxupjQwU9GE?t=01h16m40s)

[out in kubernetes](https://youtu.be/HxupjQwU9GE?t=01h16m42s)

[I would like to load test it because I](https://youtu.be/HxupjQwU9GE?t=01h16m44s)

[would like to know how many users](https://youtu.be/HxupjQwU9GE?t=01h16m47s)

[a tiny little cluster](https://youtu.be/HxupjQwU9GE?t=01h16m50s)

[can handle](https://youtu.be/HxupjQwU9GE?t=01h16m53s)

[right because if if doing the simulated](https://youtu.be/HxupjQwU9GE?t=01h16m55s)

[voting push this thing at like five](https://youtu.be/HxupjQwU9GE?t=01h16m59s)

[percent does that mean this thing's](https://youtu.be/HxupjQwU9GE?t=01h17m01s)

[gonna fall over at 100 users a thousand](https://youtu.be/HxupjQwU9GE?t=01h17m02s)

[users](https://youtu.be/HxupjQwU9GE?t=01h17m05s)

[I basically I'm wanting to try to figure](https://youtu.be/HxupjQwU9GE?t=01h17m07s)

[out](https://youtu.be/HxupjQwU9GE?t=01h17m09s)

[because I've got a couple ideas of](https://youtu.be/HxupjQwU9GE?t=01h17m11s)

[writing very similar apps to this that](https://youtu.be/HxupjQwU9GE?t=01h17m13s)

[are kind of small voting level things](https://youtu.be/HxupjQwU9GE?t=01h17m15s)

[yeah so the and Locust was recommended](https://youtu.be/HxupjQwU9GE?t=01h17m18s)

[as a reasonable load testing tool to to](https://youtu.be/HxupjQwU9GE?t=01h17m21s)

[try out so I went I don't know any](https://youtu.be/HxupjQwU9GE?t=01h17m24s)

[better let's do it](https://youtu.be/HxupjQwU9GE?t=01h17m26s)

[um](https://youtu.be/HxupjQwU9GE?t=01h17m28s)

[so the idea being that you're gonna have](https://youtu.be/HxupjQwU9GE?t=01h17m33s)

[to end up running this yeah because I](https://youtu.be/HxupjQwU9GE?t=01h17m36s)

[really want to know I I really want to](https://youtu.be/HxupjQwU9GE?t=01h17m39s)

[know](https://youtu.be/HxupjQwU9GE?t=01h17m42s)

[if I want to deploy this out what's the](https://youtu.be/HxupjQwU9GE?t=01h17m43s)

[what's the reasonable amount of load I](https://youtu.be/HxupjQwU9GE?t=01h17m46s)

[can expect a cheapo cluster to do](https://youtu.be/HxupjQwU9GE?t=01h17m48s)

[because when I when you uh do the new](https://youtu.be/HxupjQwU9GE?t=01h17m50s)

[cluster in Azure it gives you a couple](https://youtu.be/HxupjQwU9GE?t=01h17m53s)

[options and one of the options is a](https://youtu.be/HxupjQwU9GE?t=01h17m55s)

[how'd they phrase it like uh](https://youtu.be/HxupjQwU9GE?t=01h17m58s)

[a cost savings production and the](https://youtu.be/HxupjQwU9GE?t=01h18m01s)

[description on it was production](https://youtu.be/HxupjQwU9GE?t=01h18m04s)

[workloads that are willing to tolerate](https://youtu.be/HxupjQwU9GE?t=01h18m05s)

[some outages right this isn't I'm](https://youtu.be/HxupjQwU9GE?t=01h18m07s)

[wanting five nines of uptime type](https://youtu.be/HxupjQwU9GE?t=01h18m09s)

[situation this is yeah I want to run my](https://youtu.be/HxupjQwU9GE?t=01h18m11s)

[my you know small business thing or](https://youtu.be/HxupjQwU9GE?t=01h18m14s)

[maybe my personal blog or whatnot](https://youtu.be/HxupjQwU9GE?t=01h18m17s)

[outages aren't my biggest problem right](https://youtu.be/HxupjQwU9GE?t=01h18m19s)

[that's okay like if I lose if I have a](https://youtu.be/HxupjQwU9GE?t=01h18m22s)

[little down time because there's a](https://youtu.be/HxupjQwU9GE?t=01h18m25s)

[kubernetes update running or whatever](https://youtu.be/HxupjQwU9GE?t=01h18m27s)

[you know that's not the end of the world](https://youtu.be/HxupjQwU9GE?t=01h18m29s)

[for me which is kind of what I want to](https://youtu.be/HxupjQwU9GE?t=01h18m31s)

[see is what what can I do with a very](https://youtu.be/HxupjQwU9GE?t=01h18m33s)

[low end cluster](https://youtu.be/HxupjQwU9GE?t=01h18m36s)

[so that's that's the thinking](https://youtu.be/HxupjQwU9GE?t=01h18m38s)

[um but apparently I don't know how to](https://youtu.be/HxupjQwU9GE?t=01h18m42s)

[install python](https://youtu.be/HxupjQwU9GE?t=01h18m43s)

[but python is there](https://youtu.be/HxupjQwU9GE?t=01h18m46s)

[Lotus apparently](https://youtu.be/HxupjQwU9GE?t=01h18m49s)

[is there I I'm kind of wondering](https://youtu.be/HxupjQwU9GE?t=01h18m53s)

[I'm loading it in now](https://youtu.be/HxupjQwU9GE?t=01h18m56s)

[um I'm kind of wondering if](https://youtu.be/HxupjQwU9GE?t=01h19m00s)

[I should just I'm wondering if I shot](https://youtu.be/HxupjQwU9GE?t=01h19m04s)

[myself in the foot by installing python](https://youtu.be/HxupjQwU9GE?t=01h19m06s)

[via the Windows store](https://youtu.be/HxupjQwU9GE?t=01h19m08s)

[like on one hand I was a little](https://youtu.be/HxupjQwU9GE?t=01h19m10s)

[surprised](https://youtu.be/HxupjQwU9GE?t=01h19m11s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h19m13s)

[and that's an option for yeah so I do](https://youtu.be/HxupjQwU9GE?t=01h19m15s)

[also have a WSL set up with Ubuntu which](https://youtu.be/HxupjQwU9GE?t=01h19m18s)

[I could drop into as well I just try](https://youtu.be/HxupjQwU9GE?t=01h19m21s)

[uh python 2 and python 3. uh what is the](https://youtu.be/HxupjQwU9GE?t=01h19m25s)

[python version check is it](https://youtu.be/HxupjQwU9GE?t=01h19m29s)

[uh that's that's a lot of details](https://youtu.be/HxupjQwU9GE?t=01h19m32s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h19m36s)

[uh having both installed](https://youtu.be/HxupjQwU9GE?t=01h19m38s)

[um](https://youtu.be/HxupjQwU9GE?t=01h19m41s)

[uh what is the](https://youtu.be/HxupjQwU9GE?t=01h19m43s)

[python what's your what's your version](https://youtu.be/HxupjQwU9GE?t=01h19m47s)

[output thing emo bobber](https://youtu.be/HxupjQwU9GE?t=01h19m49s)

[um](https://youtu.be/HxupjQwU9GE?t=01h19m51s)

[I guess I could do this](https://youtu.be/HxupjQwU9GE?t=01h19m53s)

[python](https://youtu.be/HxupjQwU9GE?t=01h19m56s)

[so](https://youtu.be/HxupjQwU9GE?t=01h19m59s)

[the only installs I appear to have](https://youtu.be/HxupjQwU9GE?t=01h20m01s)

[are 311](https://youtu.be/HxupjQwU9GE?t=01h20m05s)

[and then apparently Visual Studio](https://youtu.be/HxupjQwU9GE?t=01h20m07s)

[decided to help me out](https://youtu.be/HxupjQwU9GE?t=01h20m09s)

[and apparently the Azure CLI brings in](https://youtu.be/HxupjQwU9GE?t=01h20m15s)

[one I'm guessing](https://youtu.be/HxupjQwU9GE?t=01h20m19s)

[um](https://youtu.be/HxupjQwU9GE?t=01h20m23s)

[trying to see one of these things this](https://youtu.be/HxupjQwU9GE?t=01h20m24s)

[is almost assured the oh Capital view](https://youtu.be/HxupjQwU9GE?t=01h20m26s)

[that's what I did wrong](https://youtu.be/HxupjQwU9GE?t=01h20m28s)

[I'm sorry python capital V so it's](https://youtu.be/HxupjQwU9GE?t=01h20m30s)

[picking up 311 oh](https://youtu.be/HxupjQwU9GE?t=01h20m33s)

[which I'm gonna go with is](https://youtu.be/HxupjQwU9GE?t=01h20m36s)

[probably these ones](https://youtu.be/HxupjQwU9GE?t=01h20m39s)

[just check what Visual Studio brought in](https://youtu.be/HxupjQwU9GE?t=01h20m42s)

[with it](https://youtu.be/HxupjQwU9GE?t=01h20m44s)

[three nine so it didn't pick up it's not](https://youtu.be/HxupjQwU9GE?t=01h20m46s)

[picking up the visual studio I'm not](https://youtu.be/HxupjQwU9GE?t=01h20m49s)

[getting like some weird crosstalk thing](https://youtu.be/HxupjQwU9GE?t=01h20m51s)

[but let me just check these](https://youtu.be/HxupjQwU9GE?t=01h20m53s)

[01:21:00,179 --> 01:21:04,920](https://youtu.be/HxupjQwU9GE?t=01h20m55s)

[so](https://youtu.be/HxupjQwU9GE?t=01h21m02s)

[yeah it's](https://youtu.be/HxupjQwU9GE?t=01h21m04s)

[it's got to be picking up my Windows](https://youtu.be/HxupjQwU9GE?t=01h21m06s)

[store installed one](https://youtu.be/HxupjQwU9GE?t=01h21m08s)

[which is cool but then that begs the](https://youtu.be/HxupjQwU9GE?t=01h21m13s)

[question where the heck did it put](https://youtu.be/HxupjQwU9GE?t=01h21m16s)

[my Locus installed](https://youtu.be/HxupjQwU9GE?t=01h21m18s)

[um and why is that not added](https://youtu.be/HxupjQwU9GE?t=01h21m22s)

[um](https://youtu.be/HxupjQwU9GE?t=01h21m26s)

[uh because at the end of the day](https://youtu.be/HxupjQwU9GE?t=01h21m32s)

[it's kind of expecting this to be in the](https://youtu.be/HxupjQwU9GE?t=01h21m39s)

[path and I'm wondering if that's just](https://youtu.be/HxupjQwU9GE?t=01h21m41s)

[the problem is this isn't added to the](https://youtu.be/HxupjQwU9GE?t=01h21m43s)

[path](https://youtu.be/HxupjQwU9GE?t=01h21m45s)

[so](https://youtu.be/HxupjQwU9GE?t=01h21m46s)

[uh and try with python I think](https://youtu.be/HxupjQwU9GE?t=01h21m52s)

[uh that is probably Fair](https://youtu.be/HxupjQwU9GE?t=01h21m56s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h22m00s)

[uh uh what is so that's the thing I](https://youtu.be/HxupjQwU9GE?t=01h22m05s)

[don't know how to do and this is](https://youtu.be/HxupjQwU9GE?t=01h22m08s)

[probably an ignorance thing on my part](https://youtu.be/HxupjQwU9GE?t=01h22m09s)

[with](https://youtu.be/HxupjQwU9GE?t=01h22m11s)

[uh figuring out how to do this](https://youtu.be/HxupjQwU9GE?t=01h22m14s)

[I decided to build a site with python](https://youtu.be/HxupjQwU9GE?t=01h22m18s)

[flat that's not the worst thing in the](https://youtu.be/HxupjQwU9GE?t=01h22m21s)

[world](https://youtu.be/HxupjQwU9GE?t=01h22m23s)

[um](https://youtu.be/HxupjQwU9GE?t=01h22m25s)

[running without the web UI](https://youtu.be/HxupjQwU9GE?t=01h22m26s)

[uh let's see](https://youtu.be/HxupjQwU9GE?t=01h22m29s)

[so this is for scripting but they all](https://youtu.be/HxupjQwU9GE?t=01h22m31s)

[still require this I might just abandon](https://youtu.be/HxupjQwU9GE?t=01h22m35s)

[hope and go and install python](https://youtu.be/HxupjQwU9GE?t=01h22m37s)

[normal per people way](https://youtu.be/HxupjQwU9GE?t=01h22m40s)

[and that will probably solve some of my](https://youtu.be/HxupjQwU9GE?t=01h22m43s)

[problems if that doesn't work I'm just](https://youtu.be/HxupjQwU9GE?t=01h22m47s)

[going to drop into WSL and call it a day](https://youtu.be/HxupjQwU9GE?t=01h22m49s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h22m51s)

[and then we should probably go and](https://youtu.be/HxupjQwU9GE?t=01h22m55s)

[I need to remove python](https://youtu.be/HxupjQwU9GE?t=01h22m59s)

[so](https://youtu.be/HxupjQwU9GE?t=01h23m01s)

[we add remove programs and let's go find](https://youtu.be/HxupjQwU9GE?t=01h23m04s)

[python](https://youtu.be/HxupjQwU9GE?t=01h23m09s)

[before we get too crazy and like install](https://youtu.be/HxupjQwU9GE?t=01h23m10s)

[it we're going to kill the old one off](https://youtu.be/HxupjQwU9GE?t=01h23m12s)

[because it looks like Locust installs](https://youtu.be/HxupjQwU9GE?t=01h23m14s)

[underneath it](https://youtu.be/HxupjQwU9GE?t=01h23m16s)

[so it should burn the whole thing to the](https://youtu.be/HxupjQwU9GE?t=01h23m18s)

[ground](https://youtu.be/HxupjQwU9GE?t=01h23m21s)

[but that is one of the only only](https://youtu.be/HxupjQwU9GE?t=01h23m23s)

[wonderful things about Windows store](https://youtu.be/HxupjQwU9GE?t=01h23m25s)

[apps which is kind of why I liked it is](https://youtu.be/HxupjQwU9GE?t=01h23m27s)

[they get all like containerized and](https://youtu.be/HxupjQwU9GE?t=01h23m29s)

[boxed into their own little area](https://youtu.be/HxupjQwU9GE?t=01h23m32s)

[I was kind of happy about that](https://youtu.be/HxupjQwU9GE?t=01h23m34s)

[oh](https://youtu.be/HxupjQwU9GE?t=01h23m36s)

[probably can't install while I'm inside](https://youtu.be/HxupjQwU9GE?t=01h23m37s)

[of it running](https://youtu.be/HxupjQwU9GE?t=01h23m41s)

[oh yeah there it goes boom](https://youtu.be/HxupjQwU9GE?t=01h23m44s)

[it roasted the whole thing there we go](https://youtu.be/HxupjQwU9GE?t=01h23m46s)

[now if I check](https://youtu.be/HxupjQwU9GE?t=01h23m49s)

[uh yeah so the only thing left is stuff](https://youtu.be/HxupjQwU9GE?t=01h23m53s)

[that's not related to this okay perfect](https://youtu.be/HxupjQwU9GE?t=01h23m57s)

[uh so let's put we'll put real person](https://youtu.be/HxupjQwU9GE?t=01h24m00s)

[python on here](https://youtu.be/HxupjQwU9GE?t=01h24m03s)

[open file](https://youtu.be/HxupjQwU9GE?t=01h24m05s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h24m08s)

[uh yeah sure we'll take the default](https://youtu.be/HxupjQwU9GE?t=01h24m11s)

[settings](https://youtu.be/HxupjQwU9GE?t=01h24m13s)

[how bad can it be](https://youtu.be/HxupjQwU9GE?t=01h24m14s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h24m19s)

[uh here prompt it feel okay I heard a](https://youtu.be/HxupjQwU9GE?t=01h24m21s)

[ding like there was a UAC prompt](https://youtu.be/HxupjQwU9GE?t=01h24m24s)

[somewhere and I'm like I don't see it](https://youtu.be/HxupjQwU9GE?t=01h24m25s)

[where is it](https://youtu.be/HxupjQwU9GE?t=01h24m27s)

[okay we're gonna shut you down](https://youtu.be/HxupjQwU9GE?t=01h24m30s)

[just before I get too carried away but](https://youtu.be/HxupjQwU9GE?t=01h24m34s)

[you want my clipboard](https://youtu.be/HxupjQwU9GE?t=01h24m37s)

[when in doubt installing python from the](https://youtu.be/HxupjQwU9GE?t=01h24m44s)

[Windows store admittedly I was kind of](https://youtu.be/HxupjQwU9GE?t=01h24m47s)

[surprised when I saw it was an option](https://youtu.be/HxupjQwU9GE?t=01h24m50s)

[that should have been a red flag](https://youtu.be/HxupjQwU9GE?t=01h24m51s)

[issues Galore](https://youtu.be/HxupjQwU9GE?t=01h24m55s)

[et cetera Etc I'm sure it's great for](https://youtu.be/HxupjQwU9GE?t=01h24m58s)

[people getting started because they](https://youtu.be/HxupjQwU9GE?t=01h25m00s)

[don't have to think too hard](https://youtu.be/HxupjQwU9GE?t=01h25m01s)

[but as somebody without](https://youtu.be/HxupjQwU9GE?t=01h25m08s)

[um](https://youtu.be/HxupjQwU9GE?t=01h25m12s)

[disable path length limit](https://youtu.be/HxupjQwU9GE?t=01h25m15s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h25m20s)

[I kind of like that limit though](https://youtu.be/HxupjQwU9GE?t=01h25m25s)

[because it means when I'm writing code](https://youtu.be/HxupjQwU9GE?t=01h25m27s)

[if I've made bad assumptions on paths I](https://youtu.be/HxupjQwU9GE?t=01h25m29s)

[get whacked upside the head okay](https://youtu.be/HxupjQwU9GE?t=01h25m31s)

[okay let's try let's try this again](https://youtu.be/HxupjQwU9GE?t=01h25m34s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h25m41s)

[um](https://youtu.be/HxupjQwU9GE?t=01h25m44s)

[let's let's start with the obvious](https://youtu.be/HxupjQwU9GE?t=01h25m45s)

[python](https://youtu.be/HxupjQwU9GE?t=01h25m46s)

[oh you've got to be joking me](https://youtu.be/HxupjQwU9GE?t=01h25m50s)

[sorry it's opening the Windows store on](https://youtu.be/HxupjQwU9GE?t=01h25m53s)

[another screen](https://youtu.be/HxupjQwU9GE?t=01h25m55s)

[no no no no no no no no no no no no no](https://youtu.be/HxupjQwU9GE?t=01h26m03s)

[you have got to be](https://youtu.be/HxupjQwU9GE?t=01h26m08s)

[who who put you in charge](https://youtu.be/HxupjQwU9GE?t=01h26m11s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h26m14s)

[um can I do it right from here no I](https://youtu.be/HxupjQwU9GE?t=01h26m27s)

[didn't I didn't think you were gonna be](https://youtu.be/HxupjQwU9GE?t=01h26m29s)

[that cool](https://youtu.be/HxupjQwU9GE?t=01h26m30s)

[so how do I do this](https://youtu.be/HxupjQwU9GE?t=01h26m33s)

[if you don't want to play nice with the](https://youtu.be/HxupjQwU9GE?t=01h26m36s)

[other children](https://youtu.be/HxupjQwU9GE?t=01h26m40s)

[uh uh python was not found run without](https://youtu.be/HxupjQwU9GE?t=01h26m42s)

[arguments to install from the Windows](https://youtu.be/HxupjQwU9GE?t=01h26m45s)

[store or disable this shortcut uh](https://youtu.be/HxupjQwU9GE?t=01h26m47s)

[settings map what the heck did you okay](https://youtu.be/HxupjQwU9GE?t=01h26m50s)

[settings](https://youtu.be/HxupjQwU9GE?t=01h26m54s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h26m58s)

[uh manage app execution aliases where is](https://youtu.be/HxupjQwU9GE?t=01h27m02s)

[that option](https://youtu.be/HxupjQwU9GE?t=01h27m05s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h27m07s)

[app execution aliases](https://youtu.be/HxupjQwU9GE?t=01h27m09s)

[did it not clean up](https://youtu.be/HxupjQwU9GE?t=01h27m12s)

[app installer off off](https://youtu.be/HxupjQwU9GE?t=01h27m20s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h27m25s)

[wondering if that may have been part of](https://youtu.be/HxupjQwU9GE?t=01h27m28s)

[the problem](https://youtu.be/HxupjQwU9GE?t=01h27m29s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h27m32s)

[hi](https://youtu.be/HxupjQwU9GE?t=01h27m34s)

[see python version](https://youtu.be/HxupjQwU9GE?t=01h27m36s)

[did we not just install you](https://youtu.be/HxupjQwU9GE?t=01h27m42s)

[close and](https://youtu.be/HxupjQwU9GE?t=01h27m46s)

[actually I'm gonna do this real quick](https://youtu.be/HxupjQwU9GE?t=01h27m49s)

[um](https://youtu.be/HxupjQwU9GE?t=01h27m53s)

[uh Windows Explorer restart](https://youtu.be/HxupjQwU9GE?t=01h27m54s)

[because I know that you have a tendency](https://youtu.be/HxupjQwU9GE?t=01h28m01s)

[to do bad things](https://youtu.be/HxupjQwU9GE?t=01h28m03s)

[python version](https://youtu.be/HxupjQwU9GE?t=01h28m06s)

[dear Evans this was not supposed to be](https://youtu.be/HxupjQwU9GE?t=01h28m09s)

[the hard part](https://youtu.be/HxupjQwU9GE?t=01h28m11s)

[okay try this again](https://youtu.be/HxupjQwU9GE?t=01h28m13s)

[is it on the path uh good question let's](https://youtu.be/HxupjQwU9GE?t=01h28m19s)

[let's go find out](https://youtu.be/HxupjQwU9GE?t=01h28m25s)

[so environment variables](https://youtu.be/HxupjQwU9GE?t=01h28m27s)

[it certainly would appear not](https://youtu.be/HxupjQwU9GE?t=01h28m35s)

[um](https://youtu.be/HxupjQwU9GE?t=01h28m42s)

[python](https://youtu.be/HxupjQwU9GE?t=01h28m48s)

[you did not](https://youtu.be/HxupjQwU9GE?t=01h28m50s)

[let's try this one more time I'm gonna](https://youtu.be/HxupjQwU9GE?t=01h28m54s)

[let it do a quick repair just to see but](https://youtu.be/HxupjQwU9GE?t=01h28m56s)

[it does appear that it is not on the](https://youtu.be/HxupjQwU9GE?t=01h28m58s)

[path](https://youtu.be/HxupjQwU9GE?t=01h29m01s)

[uh let's see](https://youtu.be/HxupjQwU9GE?t=01h29m01s)

[python.exe](https://youtu.be/HxupjQwU9GE?t=01h29m04s)

[I mean it's there it has been installed](https://youtu.be/HxupjQwU9GE?t=01h29m07s)

[but apparently](https://youtu.be/HxupjQwU9GE?t=01h29m10s)

[it no workie](https://youtu.be/HxupjQwU9GE?t=01h29m12s)

[it's where a race I would have won as I](https://youtu.be/HxupjQwU9GE?t=01h29m21s)

[have to work](https://youtu.be/HxupjQwU9GE?t=01h29m24s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h29m27s)

[yes but you probably are smarter at](https://youtu.be/HxupjQwU9GE?t=01h29m29s)

[python than me](https://youtu.be/HxupjQwU9GE?t=01h29m31s)

[foreign](https://youtu.be/HxupjQwU9GE?t=01h29m33s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h29m35s)

[when in doubt don't put your lights](https://youtu.be/HxupjQwU9GE?t=01h29m38s)

[goes poorly](https://youtu.be/HxupjQwU9GE?t=01h29m42s)

[when I let that sit there for the moment](https://youtu.be/HxupjQwU9GE?t=01h29m44s)

[it has fallen and wants to be mean to me](https://youtu.be/HxupjQwU9GE?t=01h29m48s)

[uh must be not at all](https://youtu.be/HxupjQwU9GE?t=01h29m53s)

[just never used python on this laptop](https://youtu.be/HxupjQwU9GE?t=01h29m58s)

[did you go and do it via the WSL router](https://youtu.be/HxupjQwU9GE?t=01h30m03s)

[did you do it inside of windows](https://youtu.be/HxupjQwU9GE?t=01h30m06s)

[uh WSL yeah](https://youtu.be/HxupjQwU9GE?t=01h30m12s)

[I'm I'm this close to abandoning hope](https://youtu.be/HxupjQwU9GE?t=01h30m18s)

[and just diving into WSL as well because](https://youtu.be/HxupjQwU9GE?t=01h30m20s)

[that might be the path of least](https://youtu.be/HxupjQwU9GE?t=01h30m23s)

[resistance](https://youtu.be/HxupjQwU9GE?t=01h30m24s)

[it might be the path of least resistance](https://youtu.be/HxupjQwU9GE?t=01h30m26s)

[to do](https://youtu.be/HxupjQwU9GE?t=01h30m31s)

[close](https://youtu.be/HxupjQwU9GE?t=01h30m33s)

[okay so we're gonna close](https://youtu.be/HxupjQwU9GE?t=01h30m34s)

[relaunch and it could be this may be a](https://youtu.be/HxupjQwU9GE?t=01h30m38s)

[situation where](https://youtu.be/HxupjQwU9GE?t=01h30m41s)

[it just doesn't exist](https://youtu.be/HxupjQwU9GE?t=01h30m43s)

[the path of least resistance](https://youtu.be/HxupjQwU9GE?t=01h30m45s)

[that wasn't supposed to be a pun until](https://youtu.be/HxupjQwU9GE?t=01h30m49s)

[you said that and now I think that now](https://youtu.be/HxupjQwU9GE?t=01h30m50s)

[I'm going to claim it was intentional uh](https://youtu.be/HxupjQwU9GE?t=01h30m52s)

[okay so we're just gonna we're gonna](https://youtu.be/HxupjQwU9GE?t=01h30m55s)

[save ourselves a little bit of headache](https://youtu.be/HxupjQwU9GE?t=01h30m57s)

[and I'm just gonna do this](https://youtu.be/HxupjQwU9GE?t=01h30m58s)

[copy](https://youtu.be/HxupjQwU9GE?t=01h31m00s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h31m03s)

[uh environment variables](https://youtu.be/HxupjQwU9GE?t=01h31m04s)

[and oh nope you come back come back keep](https://youtu.be/HxupjQwU9GE?t=01h31m07s)

[opening on the wrong screen environment](https://youtu.be/HxupjQwU9GE?t=01h31m11s)

[variables we're gonna go path we're](https://youtu.be/HxupjQwU9GE?t=01h31m12s)

[gonna go uh new and we're gonna go paste](https://youtu.be/HxupjQwU9GE?t=01h31m14s)

[we're gonna call it a day boom](https://youtu.be/HxupjQwU9GE?t=01h31m17s)

[dun dun dun dun](https://youtu.be/HxupjQwU9GE?t=01h31m20s)

[to install stuff like Python and node.js](https://youtu.be/HxupjQwU9GE?t=01h31m22s)

[that's a good idea I should have looked](https://youtu.be/HxupjQwU9GE?t=01h31m26s)

[I made the most I made the mistake one](https://youtu.be/HxupjQwU9GE?t=01h31m30s)

[of going to the Windows store that was](https://youtu.be/HxupjQwU9GE?t=01h31m32s)

[mistake number one](https://youtu.be/HxupjQwU9GE?t=01h31m34s)

[mistake number two was then installing](https://youtu.be/HxupjQwU9GE?t=01h31m35s)

[it from there](https://youtu.be/HxupjQwU9GE?t=01h31m38s)

[and pretty much any CLI thing yeah I on](https://youtu.be/HxupjQwU9GE?t=01h31m40s)

[Windows I tend to be chocolatey](https://youtu.be/HxupjQwU9GE?t=01h31m43s)

[for uh for all of mine but](https://youtu.be/HxupjQwU9GE?t=01h31m46s)

[the the basic premise of always using a](https://youtu.be/HxupjQwU9GE?t=01h31m50s)

[uh some sort of package manager uh](https://youtu.be/HxupjQwU9GE?t=01h31m53s)

[azza](https://youtu.be/HxupjQwU9GE?t=01h31m58s)

[okay that was that was harder than it](https://youtu.be/HxupjQwU9GE?t=01h32m00s)

[needed to be](https://youtu.be/HxupjQwU9GE?t=01h32m04s)

[uh oh my word](https://youtu.be/HxupjQwU9GE?t=01h32m05s)

[okay why am I am I just dumb](https://youtu.be/HxupjQwU9GE?t=01h32m09s)

[uh install the uh](https://youtu.be/HxupjQwU9GE?t=01h32m15s)

[check the wiki if it fails is it okay so](https://youtu.be/HxupjQwU9GE?t=01h32m17s)

[I let me guess](https://youtu.be/HxupjQwU9GE?t=01h32m21s)

[I I](https://youtu.be/HxupjQwU9GE?t=01h32m26s)

[open path](https://youtu.be/HxupjQwU9GE?t=01h32m30s)

[okay so we'll add U to the path now too](https://youtu.be/HxupjQwU9GE?t=01h32m34s)

[gonna be real good at this by the time](https://youtu.be/HxupjQwU9GE?t=01h32m38s)

[I'm done okay I'm sure there's probably](https://youtu.be/HxupjQwU9GE?t=01h32m40s)

[a](https://youtu.be/HxupjQwU9GE?t=01h32m43s)

[shortcut some oh nope](https://youtu.be/HxupjQwU9GE?t=01h32m45s)

[into path new](https://youtu.be/HxupjQwU9GE?t=01h32m47s)

[paste](https://youtu.be/HxupjQwU9GE?t=01h32m49s)

[here we go](https://youtu.be/HxupjQwU9GE?t=01h32m52s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h32m55s)

[close relaunch to make sure it gets the](https://youtu.be/HxupjQwU9GE?t=01h32m57s)

[new variables](https://youtu.be/HxupjQwU9GE?t=01h32m59s)

[there's also a new one called uh winget](https://youtu.be/HxupjQwU9GE?t=01h33m04s)

[which initially was](https://youtu.be/HxupjQwU9GE?t=01h33m07s)

[a lot of people were like why do we need](https://youtu.be/HxupjQwU9GE?t=01h33m09s)

[this we already have chocolatey and](https://youtu.be/HxupjQwU9GE?t=01h33m12s)

[they've started to improve it and I've](https://youtu.be/HxupjQwU9GE?t=01h33m14s)

[had some colleagues say that they that](https://youtu.be/HxupjQwU9GE?t=01h33m15s)

[they've started switching over because](https://youtu.be/HxupjQwU9GE?t=01h33m18s)

[previously Windgate only had a small](https://youtu.be/HxupjQwU9GE?t=01h33m20s)

[amount of things that it was able to](https://youtu.be/HxupjQwU9GE?t=01h33m22s)

[install](https://youtu.be/HxupjQwU9GE?t=01h33m24s)

[um but what I heard recently is they've](https://youtu.be/HxupjQwU9GE?t=01h33m26s)

[added a swath of new stuff to where they](https://youtu.be/HxupjQwU9GE?t=01h33m29s)

[claim you can install everything my](https://youtu.be/HxupjQwU9GE?t=01h33m32s)

[colleague was able to get all of his](https://youtu.be/HxupjQwU9GE?t=01h33m34s)

[dependencies that he needed with winget](https://youtu.be/HxupjQwU9GE?t=01h33m36s)

[just fine without needing chocolate I](https://youtu.be/HxupjQwU9GE?t=01h33m37s)

[was like oh](https://youtu.be/HxupjQwU9GE?t=01h33m39s)

[that's pretty cool](https://youtu.be/HxupjQwU9GE?t=01h33m40s)

[so I don't know exactly what they added](https://youtu.be/HxupjQwU9GE?t=01h33m42s)

[for packaging and deployment but it](https://youtu.be/HxupjQwU9GE?t=01h33m44s)

[looked interesting](https://youtu.be/HxupjQwU9GE?t=01h33m46s)

[but I will say I've only used it a](https://youtu.be/HxupjQwU9GE?t=01h33m48s)

[little bit](https://youtu.be/HxupjQwU9GE?t=01h33m50s)

[chocolatey still is by far the default](https://youtu.be/HxupjQwU9GE?t=01h33m53s)

[package manager for Windows](https://youtu.be/HxupjQwU9GE?t=01h33m55s)

[now if I remember correctly](https://youtu.be/HxupjQwU9GE?t=01h34m01s)

[this command show me a version number](https://youtu.be/HxupjQwU9GE?t=01h34m04s)

[yes](https://youtu.be/HxupjQwU9GE?t=01h34m10s)

[took way longer than it needed to way](https://youtu.be/HxupjQwU9GE?t=01h34m13s)

[longer than it needed to okay](https://youtu.be/HxupjQwU9GE?t=01h34m16s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h34m18s)

[uh Orleans samples](https://youtu.be/HxupjQwU9GE?t=01h34m20s)

[uh voting](https://youtu.be/HxupjQwU9GE?t=01h34m23s)

[uh CD there and then](https://youtu.be/HxupjQwU9GE?t=01h34m25s)

[if I'm gonna be right in Python we're](https://youtu.be/HxupjQwU9GE?t=01h34m30s)

[going to use vs code okay](https://youtu.be/HxupjQwU9GE?t=01h34m31s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h34m33s)

[we got that we got that](https://youtu.be/HxupjQwU9GE?t=01h34m35s)

[would go on to create first](https://youtu.be/HxupjQwU9GE?t=01h34m37s)

[we do something like this right and it](https://youtu.be/HxupjQwU9GE?t=01h34m39s)

[tells us to name it](https://youtu.be/HxupjQwU9GE?t=01h34m42s)

[it showed me somewhere I remember seeing](https://youtu.be/HxupjQwU9GE?t=01h34m45s)

[this](https://youtu.be/HxupjQwU9GE?t=01h34m47s)

[uh Locust file.py that was](https://youtu.be/HxupjQwU9GE?t=01h34m48s)

[I don't know if that's important but we](https://youtu.be/HxupjQwU9GE?t=01h34m53s)

[are going to follow the directions at](https://youtu.be/HxupjQwU9GE?t=01h34m55s)

[least to start boom okay Locus file py](https://youtu.be/HxupjQwU9GE?t=01h34m57s)

[we will do contents from there paste](https://youtu.be/HxupjQwU9GE?t=01h35m01s)

[boom everyone's happy](https://youtu.be/HxupjQwU9GE?t=01h35m04s)

[great we come in here we just type in](https://youtu.be/HxupjQwU9GE?t=01h35m07s)

[Locus](https://youtu.be/HxupjQwU9GE?t=01h35m10s)

[and it should do a thing](https://youtu.be/HxupjQwU9GE?t=01h35m12s)

[uh the Windows Firewall is unhappy so we](https://youtu.be/HxupjQwU9GE?t=01h35m16s)

[hit allow](https://youtu.be/HxupjQwU9GE?t=01h35m19s)

[yeah typically the Windows store isn't](https://youtu.be/HxupjQwU9GE?t=01h35m23s)

[usually problematic and I really like](https://youtu.be/HxupjQwU9GE?t=01h35m25s)

[installing with things there because](https://youtu.be/HxupjQwU9GE?t=01h35m27s)

[they like I said they get packaged up so](https://youtu.be/HxupjQwU9GE?t=01h35m29s)

[I don't have to worry as much about them](https://youtu.be/HxupjQwU9GE?t=01h35m31s)

[you know running a muck of my system](https://youtu.be/HxupjQwU9GE?t=01h35m34s)

[um the drawback then is](https://youtu.be/HxupjQwU9GE?t=01h35m37s)

[then you can run into weird pathing](https://youtu.be/HxupjQwU9GE?t=01h35m40s)

[things for apps that](https://youtu.be/HxupjQwU9GE?t=01h35m42s)

[effectively get wrapped rather than](https://youtu.be/HxupjQwU9GE?t=01h35m45s)

[written](https://youtu.be/HxupjQwU9GE?t=01h35m48s)

[so okay uh and it was localhost](https://youtu.be/HxupjQwU9GE?t=01h35m49s)

[something something something something](https://youtu.be/HxupjQwU9GE?t=01h35m52s)

[uh oh it's apparently supposed to tell](https://youtu.be/HxupjQwU9GE?t=01h35m55s)

[me the port here](https://youtu.be/HxupjQwU9GE?t=01h35m57s)

[so I want to go there](https://youtu.be/HxupjQwU9GE?t=01h35m59s)

[uh okay](https://youtu.be/HxupjQwU9GE?t=01h36m05s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h36m11s)

[number of users](https://youtu.be/HxupjQwU9GE?t=01h36m12s)

[post](https://youtu.be/HxupjQwU9GE?t=01h36m14s)

[okay this seems this this starts](https://youtu.be/HxupjQwU9GE?t=01h36m17s)

[swarming now](https://youtu.be/HxupjQwU9GE?t=01h36m20s)

[I kind of Imagine](https://youtu.be/HxupjQwU9GE?t=01h36m22s)

[this thing doesn't do much](https://youtu.be/HxupjQwU9GE?t=01h36m24s)

[uh let's see you must specify the base](https://youtu.be/HxupjQwU9GE?t=01h36m27s)

[host](https://youtu.be/HxupjQwU9GE?t=01h36m30s)

[yeah okay not surprising Okay so](https://youtu.be/HxupjQwU9GE?t=01h36m31s)

[we're gonna do this](https://youtu.be/HxupjQwU9GE?t=01h36m35s)

[uh we're gonna come over nope nope nope](https://youtu.be/HxupjQwU9GE?t=01h36m38s)

[we're obvious code instance I want this](https://youtu.be/HxupjQwU9GE?t=01h36m41s)

[one uh actually I guess we can just go](https://youtu.be/HxupjQwU9GE?t=01h36m43s)

[back](https://youtu.be/HxupjQwU9GE?t=01h36m46s)

[to our](https://youtu.be/HxupjQwU9GE?t=01h36m47s)

[uh can we do edit](https://youtu.be/HxupjQwU9GE?t=01h36m51s)

[close how do I go back](https://youtu.be/HxupjQwU9GE?t=01h36m54s)

[and there we go](https://youtu.be/HxupjQwU9GE?t=01h36m58s)

[if I do that](https://youtu.be/HxupjQwU9GE?t=01h36m59s)

[that should go and I imagine it's going](https://youtu.be/HxupjQwU9GE?t=01h37m03s)

[to start getting like](https://youtu.be/HxupjQwU9GE?t=01h37m05s)

[okay so it's cool so it starts spawning](https://youtu.be/HxupjQwU9GE?t=01h37m10s)

[requests per second](https://youtu.be/HxupjQwU9GE?t=01h37m15s)

[that's pretty good so one user](https://youtu.be/HxupjQwU9GE?t=01h37m17s)

[17 requests per second](https://youtu.be/HxupjQwU9GE?t=01h37m19s)

[one's going against hello one's going](https://youtu.be/HxupjQwU9GE?t=01h37m22s)

[against World okay so those are the base](https://youtu.be/HxupjQwU9GE?t=01h37m24s)

[URLs those aren't going to do Jack okay](https://youtu.be/HxupjQwU9GE?t=01h37m26s)

[great great great great great great](https://youtu.be/HxupjQwU9GE?t=01h37m28s)

[great](https://youtu.be/HxupjQwU9GE?t=01h37m30s)

[okay okay so now what we want to do I](https://youtu.be/HxupjQwU9GE?t=01h37m31s)

[want to make it click on a button and I](https://youtu.be/HxupjQwU9GE?t=01h37m36s)

[don't care if I have to hard cut](https://youtu.be/HxupjQwU9GE?t=01h37m39s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h37m40s)

[uh Miss stuff did the fresh install](https://youtu.be/HxupjQwU9GE?t=01h37m42s)

[fixed it](https://youtu.be/HxupjQwU9GE?t=01h37m43s)

[uh let's see so](https://youtu.be/HxupjQwU9GE?t=01h37m45s)

[that's how we start that's how we run](https://youtu.be/HxupjQwU9GE?t=01h37m48s)

[oh how do I get here oh there's charts](https://youtu.be/HxupjQwU9GE?t=01h37m51s)

[there's pretty charts](https://youtu.be/HxupjQwU9GE?t=01h37m54s)

[oh yeah oh yeah](https://youtu.be/HxupjQwU9GE?t=01h37m58s)

[yeah so this will be the interesting](https://youtu.be/HxupjQwU9GE?t=01h38m01s)

[part to watch right is comparing now](https://youtu.be/HxupjQwU9GE?t=01h38m02s)

[this isn't this isn't meaningful because](https://youtu.be/HxupjQwU9GE?t=01h38m05s)

[it's doing dumbness so](https://youtu.be/HxupjQwU9GE?t=01h38m07s)

[let's let's make it do something not](https://youtu.be/HxupjQwU9GE?t=01h38m11s)

[dumb and then](https://youtu.be/HxupjQwU9GE?t=01h38m12s)

[that'll be that'll be mildly more](https://youtu.be/HxupjQwU9GE?t=01h38m14s)

[interesting okay I need to quit changing](https://youtu.be/HxupjQwU9GE?t=01h38m16s)

[my tabs so much so I can keep track of](https://youtu.be/HxupjQwU9GE?t=01h38m19s)

[where I'm going](https://youtu.be/HxupjQwU9GE?t=01h38m21s)

[uh cool charts cool charts direct](https://youtu.be/HxupjQwU9GE?t=01h38m22s)

[command line uses headless don't care](https://youtu.be/HxupjQwU9GE?t=01h38m25s)

[don't care okay how do I make you go](https://youtu.be/HxupjQwU9GE?t=01h38m28s)

[because this is](https://youtu.be/HxupjQwU9GE?t=01h38m34s)

[task hello world client get hello client](https://youtu.be/HxupjQwU9GE?t=01h38m38s)

[get world that's great I would like more](https://youtu.be/HxupjQwU9GE?t=01h38m43s)

[control](https://youtu.be/HxupjQwU9GE?t=01h38m47s)

[uh writing a Locus file that sounds like](https://youtu.be/HxupjQwU9GE?t=01h38m49s)

[what I want](https://youtu.be/HxupjQwU9GE?t=01h38m52s)

[okay client get sleep post](https://youtu.be/HxupjQwU9GE?t=01h38m55s)

[yeah see I don't even need that I really](https://youtu.be/HxupjQwU9GE?t=01h39m02s)

[just want to know how do I interact with](https://youtu.be/HxupjQwU9GE?t=01h39m05s)

[the](https://youtu.be/HxupjQwU9GE?t=01h39m07s)

[the browser](https://youtu.be/HxupjQwU9GE?t=01h39m08s)

[or do I have to simulate everything](https://youtu.be/HxupjQwU9GE?t=01h39m11s)

[because if I can't interact with the](https://youtu.be/HxupjQwU9GE?t=01h39m13s)

[browser the fact that this is in wasm is](https://youtu.be/HxupjQwU9GE?t=01h39m15s)

[going to get real hard real fast](https://youtu.be/HxupjQwU9GE?t=01h39m17s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h39m21s)

[um on start on stop](https://youtu.be/HxupjQwU9GE?t=01h39m22s)

[so I suppose we could just go straight](https://youtu.be/HxupjQwU9GE?t=01h39m26s)

[against the](https://youtu.be/HxupjQwU9GE?t=01h39m28s)

[no that's gonna be a little harder uh](https://youtu.be/HxupjQwU9GE?t=01h39m33s)

[HTTP user class session](https://youtu.be/HxupjQwU9GE?t=01h39m36s)

[validating responses](https://youtu.be/HxupjQwU9GE?t=01h39m40s)

[rest grouping requests](https://youtu.be/HxupjQwU9GE?t=01h39m44s)

[great proxy setting connection pooling](https://youtu.be/HxupjQwU9GE?t=01h39m47s)

[task set how to structure your code yada](https://youtu.be/HxupjQwU9GE?t=01h39m50s)

[yada okay great](https://youtu.be/HxupjQwU9GE?t=01h39m52s)

[um is there not a](https://youtu.be/HxupjQwU9GE?t=01h39m54s)

[maybe I've misunderstood the the point](https://youtu.be/HxupjQwU9GE?t=01h39m58s)

[here](https://youtu.be/HxupjQwU9GE?t=01h40m00s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h40m02s)

[uh because worst case scenario I could](https://youtu.be/HxupjQwU9GE?t=01h40m04s)

[simulate it on an end point](https://youtu.be/HxupjQwU9GE?t=01h40m06s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h40m09s)

[uh because all it's going to do is Spam](https://youtu.be/HxupjQwU9GE?t=01h40m15s)

[the HTTP request it appears](https://youtu.be/HxupjQwU9GE?t=01h40m18s)

[got it okay so the question then comes](https://youtu.be/HxupjQwU9GE?t=01h40m23s)

[is there a reasonable option for doing](https://youtu.be/HxupjQwU9GE?t=01h40m26s)

[this](https://youtu.be/HxupjQwU9GE?t=01h40m28s)

[so let's move you over to here I don't](https://youtu.be/HxupjQwU9GE?t=01h40m30s)

[think there is](https://youtu.be/HxupjQwU9GE?t=01h40m33s)

[but we're gonna test](https://youtu.be/HxupjQwU9GE?t=01h40m36s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h40m38s)

[we're gonna test](https://youtu.be/HxupjQwU9GE?t=01h40m40s)

[them](https://youtu.be/HxupjQwU9GE?t=01h40m42s)

[option value](https://youtu.be/HxupjQwU9GE?t=01h40m44s)

[add create](https://youtu.be/HxupjQwU9GE?t=01h40m47s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h40m51s)

[I mean you can get the home page is it](https://youtu.be/HxupjQwU9GE?t=01h40m52s)

[Blazer server or Blazer wasm uh Blazer](https://youtu.be/HxupjQwU9GE?t=01h40m55s)

[server](https://youtu.be/HxupjQwU9GE?t=01h40m58s)

[that's so it's at least Blazer server](https://youtu.be/HxupjQwU9GE?t=01h41m04s)

[because I know I saw that in here](https://youtu.be/HxupjQwU9GE?t=01h41m07s)

[um server-side Blazer certainly](https://youtu.be/HxupjQwU9GE?t=01h41m10s)

[um and Razer pages](https://youtu.be/HxupjQwU9GE?t=01h41m14s)

[I guess that's a good point if it is](https://youtu.be/HxupjQwU9GE?t=01h41m17s)

[just a Razer page](https://youtu.be/HxupjQwU9GE?t=01h41m18s)

[so then there should be](https://youtu.be/HxupjQwU9GE?t=01h41m26s)

[um](https://youtu.be/HxupjQwU9GE?t=01h41m28s)

[yeah so both it looks like](https://youtu.be/HxupjQwU9GE?t=01h41m31s)

[yeah so we can get yeah so I can get the](https://youtu.be/HxupjQwU9GE?t=01h41m35s)

[page what I kind of want to do though is](https://youtu.be/HxupjQwU9GE?t=01h41m38s)

[I really would like to have it](https://youtu.be/HxupjQwU9GE?t=01h41m40s)

[have it actually interact](https://youtu.be/HxupjQwU9GE?t=01h41m46s)

[it's a right sorry I'm I'm very new to](https://youtu.be/HxupjQwU9GE?t=01h41m50s)

[the Blazer side uh](https://youtu.be/HxupjQwU9GE?t=01h41m55s)

[because there's not a direct](https://youtu.be/HxupjQwU9GE?t=01h42m00s)

[hmm](https://youtu.be/HxupjQwU9GE?t=01h42m04s)

[can you pass data on the route not](https://youtu.be/HxupjQwU9GE?t=01h42m06s)

[currently but I could change that](https://youtu.be/HxupjQwU9GE?t=01h42m09s)

[and I'm kind of wondering if that's the](https://youtu.be/HxupjQwU9GE?t=01h42m13s)

[solution](https://youtu.be/HxupjQwU9GE?t=01h42m15s)

[is](https://youtu.be/HxupjQwU9GE?t=01h42m17s)

[just pass something through](https://youtu.be/HxupjQwU9GE?t=01h42m19s)

[um](https://youtu.be/HxupjQwU9GE?t=01h42m23s)

[because there's nothing there's nothing](https://youtu.be/HxupjQwU9GE?t=01h42m27s)

[stopping me from passing data through](https://youtu.be/HxupjQwU9GE?t=01h42m28s)

[but currently the only thing it takes in](https://youtu.be/HxupjQwU9GE?t=01h42m31s)

[is is a pull ID](https://youtu.be/HxupjQwU9GE?t=01h42m33s)

[but again we could](https://youtu.be/HxupjQwU9GE?t=01h42m36s)

[um](https://youtu.be/HxupjQwU9GE?t=01h42m42s)

[we could go through and do that](https://youtu.be/HxupjQwU9GE?t=01h42m45s)

[yeah because then where does vote for](https://youtu.be/HxupjQwU9GE?t=01h42m52s)

[option I assume this is just invoked up](https://youtu.be/HxupjQwU9GE?t=01h42m54s)

[above on a click Handler or something](https://youtu.be/HxupjQwU9GE?t=01h42m56s)

[yeah](https://youtu.be/HxupjQwU9GE?t=01h42m59s)

[so this thing is literally](https://youtu.be/HxupjQwU9GE?t=01h43m01s)

[or just do a random yeah that could work](https://youtu.be/HxupjQwU9GE?t=01h43m03s)

[as well](https://youtu.be/HxupjQwU9GE?t=01h43m06s)

[because all this thing does is it comes](https://youtu.be/HxupjQwU9GE?t=01h43m07s)

[in on a page](https://youtu.be/HxupjQwU9GE?t=01h43m10s)

[pull ID](https://youtu.be/HxupjQwU9GE?t=01h43m18s)

[I'm kind of wondering if](https://youtu.be/HxupjQwU9GE?t=01h43m23s)

[if we do do something else on here](https://youtu.be/HxupjQwU9GE?t=01h43m28s)

[where rather than just the pull we do](https://youtu.be/HxupjQwU9GE?t=01h43m31s)

[just give it something else like uh](https://youtu.be/HxupjQwU9GE?t=01h43m34s)

[I don't know](https://youtu.be/HxupjQwU9GE?t=01h43m38s)

[vote](https://youtu.be/HxupjQwU9GE?t=01h43m40s)

[index](https://youtu.be/HxupjQwU9GE?t=01h43m42s)

[right](https://youtu.be/HxupjQwU9GE?t=01h43m44s)

[and then and then](https://youtu.be/HxupjQwU9GE?t=01h43m46s)

[get that to go through](https://youtu.be/HxupjQwU9GE?t=01h43m49s)

[let's try that real quick because that](https://youtu.be/HxupjQwU9GE?t=01h43m51s)

[might be that's probably the path of](https://youtu.be/HxupjQwU9GE?t=01h43m53s)

[least resistance](https://youtu.be/HxupjQwU9GE?t=01h43m56s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h43m57s)

[I I know I hit the button but do what I](https://youtu.be/HxupjQwU9GE?t=01h44m00s)

[mean not what I say](https://youtu.be/HxupjQwU9GE?t=01h44m01s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h44m03s)

[right and then just do that](https://youtu.be/HxupjQwU9GE?t=01h44m06s)

[and then on initialize](https://youtu.be/HxupjQwU9GE?t=01h44m10s)

[let's see](https://youtu.be/HxupjQwU9GE?t=01h44m16s)

[um this should probably be nullable](https://youtu.be/HxupjQwU9GE?t=01h44m18s)

[uh if vote](https://youtu.be/HxupjQwU9GE?t=01h44m21s)

[uh so the old way still works](https://youtu.be/HxupjQwU9GE?t=01h44m25s)

[you can create two routes](https://youtu.be/HxupjQwU9GE?t=01h44m31s)

[oh that's a good point](https://youtu.be/HxupjQwU9GE?t=01h44m34s)

[um](https://youtu.be/HxupjQwU9GE?t=01h44m37s)

[so you're proposing something like that](https://youtu.be/HxupjQwU9GE?t=01h44m41s)

[I assume](https://youtu.be/HxupjQwU9GE?t=01h44m43s)

[um](https://youtu.be/HxupjQwU9GE?t=01h44m46s)

[I think that works](https://youtu.be/HxupjQwU9GE?t=01h44m48s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h44m51s)

[what's what's terrifying me is that](https://youtu.be/HxupjQwU9GE?t=01h44m57s)

[co-pilot has already figured this out](https://youtu.be/HxupjQwU9GE?t=01h44m59s)

[thank you co-pilot is there anything](https://youtu.be/HxupjQwU9GE?t=01h45m03s)

[else you'd like to do](https://youtu.be/HxupjQwU9GE?t=01h45m04s)

[you want you want to just do it all for](https://youtu.be/HxupjQwU9GE?t=01h45m06s)

[me uh okay so](https://youtu.be/HxupjQwU9GE?t=01h45m08s)

[Let's test it locally just to make sure](https://youtu.be/HxupjQwU9GE?t=01h45m12s)

[it works and then we'll push it](https://youtu.be/HxupjQwU9GE?t=01h45m14s)

[foreign](https://youtu.be/HxupjQwU9GE?t=01h45m19s)

[okay uh test](https://youtu.be/HxupjQwU9GE?t=01h45m26s)

[uh uh option one](https://youtu.be/HxupjQwU9GE?t=01h45m29s)

[add](https://youtu.be/HxupjQwU9GE?t=01h45m33s)

[option two](https://youtu.be/HxupjQwU9GE?t=01h45m34s)

[add](https://youtu.be/HxupjQwU9GE?t=01h45m37s)

[create](https://youtu.be/HxupjQwU9GE?t=01h45m38s)

[okay so this gets me in here and then if](https://youtu.be/HxupjQwU9GE?t=01h45m40s)

[I take this](https://youtu.be/HxupjQwU9GE?t=01h45m43s)

[and I come at it and I do](https://youtu.be/HxupjQwU9GE?t=01h45m45s)

[index one so that should vote for option](https://youtu.be/HxupjQwU9GE?t=01h45m47s)

[two](https://youtu.be/HxupjQwU9GE?t=01h45m50s)

[unable to cast objective types](https://youtu.be/HxupjQwU9GE?t=01h45m55s)

[uh got it okay so you are](https://youtu.be/HxupjQwU9GE?t=01h45m59s)

[okay fine fine fine](https://youtu.be/HxupjQwU9GE?t=01h46m04s)

[do that uh so how about if it dry bars](https://youtu.be/HxupjQwU9GE?t=01h46m10s)

[uh vote index](https://youtu.be/HxupjQwU9GE?t=01h46m16s)

[out](https://youtu.be/HxupjQwU9GE?t=01h46m22s)

[and](https://youtu.be/HxupjQwU9GE?t=01h46m23s)

[there uh and maybe we should do some](https://youtu.be/HxupjQwU9GE?t=01h46m26s)

[mild amount of bounds checking perhaps](https://youtu.be/HxupjQwU9GE?t=01h46m29s)

[and vote indexes greater than or equal](https://youtu.be/HxupjQwU9GE?t=01h46m32s)

[to zero and](https://youtu.be/HxupjQwU9GE?t=01h46m36s)

[vote index is less than do we already](https://youtu.be/HxupjQwU9GE?t=01h46m39s)

[have the](https://youtu.be/HxupjQwU9GE?t=01h46m42s)

[we have the options loaded at this point](https://youtu.be/HxupjQwU9GE?t=01h46m46s)

[get pull results](https://youtu.be/HxupjQwU9GE?t=01h46m49s)

[uh res this pulse State have it on there](https://youtu.be/HxupjQwU9GE?t=01h46m52s)

[question yeah pull State options Dot](https://youtu.be/HxupjQwU9GE?t=01h46m56s)

[count](https://youtu.be/HxupjQwU9GE?t=01h47m00s)

[so I want](https://youtu.be/HxupjQwU9GE?t=01h47m02s)

[uh result dot options dot count](https://youtu.be/HxupjQwU9GE?t=01h47m04s)

[so something like that a mild amount of](https://youtu.be/HxupjQwU9GE?t=01h47m09s)

[air checking](https://youtu.be/HxupjQwU9GE?t=01h47m12s)

[okay fire this up create pull test one](https://youtu.be/HxupjQwU9GE?t=01h47m22s)

[add](https://youtu.be/HxupjQwU9GE?t=01h47m28s)

[to add](https://youtu.be/HxupjQwU9GE?t=01h47m31s)

[I'm gonna do three just so I can verify](https://youtu.be/HxupjQwU9GE?t=01h47m33s)

[we're hitting correctly create we go](https://youtu.be/HxupjQwU9GE?t=01h47m35s)

[here we go here we go here we do one we](https://youtu.be/HxupjQwU9GE?t=01h47m38s)

[go enter](https://youtu.be/HxupjQwU9GE?t=01h47m42s)

[it's interesting that it immediately](https://youtu.be/HxupjQwU9GE?t=01h47m47s)

[triggered](https://youtu.be/HxupjQwU9GE?t=01h47m49s)

[that you've already voted in this poll](https://youtu.be/HxupjQwU9GE?t=01h47m53s)

[oh probably because it sees me as the](https://youtu.be/HxupjQwU9GE?t=01h47m55s)

[same user](https://youtu.be/HxupjQwU9GE?t=01h47m57s)

[hmm oh](https://youtu.be/HxupjQwU9GE?t=01h47m58s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h48m01s)

[so interesting Theory](https://youtu.be/HxupjQwU9GE?t=01h48m03s)

[uh uh let's go back to our Locus test](https://youtu.be/HxupjQwU9GE?t=01h48m06s)

[then](https://youtu.be/HxupjQwU9GE?t=01h48m08s)

[right uh client get and](https://youtu.be/HxupjQwU9GE?t=01h48m10s)

[so this is going to be relative to this](https://youtu.be/HxupjQwU9GE?t=01h48m14s)

[all right so](https://youtu.be/HxupjQwU9GE?t=01h48m17s)

[we're gonna feed it that and I really](https://youtu.be/HxupjQwU9GE?t=01h48m21s)

[just want to have it do](https://youtu.be/HxupjQwU9GE?t=01h48m23s)

[slash one because we're going to give it](https://youtu.be/HxupjQwU9GE?t=01h48m25s)

[that for the base URL because I'm going](https://youtu.be/HxupjQwU9GE?t=01h48m27s)

[to end up feeding it into the the pull](https://youtu.be/HxupjQwU9GE?t=01h48m31s)

[and I just want it to go relative to](https://youtu.be/HxupjQwU9GE?t=01h48m34s)

[that](https://youtu.be/HxupjQwU9GE?t=01h48m36s)

[I think that's what I want](https://youtu.be/HxupjQwU9GE?t=01h48m38s)

[mm-hmm](https://youtu.be/HxupjQwU9GE?t=01h48m42s)

[and then](https://youtu.be/HxupjQwU9GE?t=01h48m44s)

[localhost](https://youtu.be/HxupjQwU9GE?t=01h48m48s)

[a number of users](https://youtu.be/HxupjQwU9GE?t=01h48m49s)

[go with](https://youtu.be/HxupjQwU9GE?t=01h48m52s)

[four](https://youtu.be/HxupjQwU9GE?t=01h48m53s)

[and then Base address there](https://youtu.be/HxupjQwU9GE?t=01h48m55s)

[start swarming](https://youtu.be/HxupjQwU9GE?t=01h48m59s)

[and then I should see](https://youtu.be/HxupjQwU9GE?t=01h49m01s)

[theory if it's able to hit it I should](https://youtu.be/HxupjQwU9GE?t=01h49m04s)

[see at least some votes come through](https://youtu.be/HxupjQwU9GE?t=01h49m06s)

[right](https://youtu.be/HxupjQwU9GE?t=01h49m09s)

[uh let's see failures 100 failure rate](https://youtu.be/HxupjQwU9GE?t=01h49m11s)

[that is excellent](https://youtu.be/HxupjQwU9GE?t=01h49m14s)

[what are the failures](https://youtu.be/HxupjQwU9GE?t=01h49m16s)

[uh oh cert verify failed](https://youtu.be/HxupjQwU9GE?t=01h49m20s)

[self-signed certificate](https://youtu.be/HxupjQwU9GE?t=01h49m25s)

[I got bad news for you this is going to](https://youtu.be/HxupjQwU9GE?t=01h49m27s)

[be](https://youtu.be/HxupjQwU9GE?t=01h49m30s)

[uh uh](https://youtu.be/HxupjQwU9GE?t=01h49m33s)

[uh okay Lucas can I tell you to ignore](https://youtu.be/HxupjQwU9GE?t=01h49m35s)

[self-signed yeah I had the same thought](https://youtu.be/HxupjQwU9GE?t=01h49m38s)

[can I tell it to not care](https://youtu.be/HxupjQwU9GE?t=01h49m41s)

[I am not the first one to want to run](https://youtu.be/HxupjQwU9GE?t=01h49m45s)

[this against localhost](https://youtu.be/HxupjQwU9GE?t=01h49m47s)

[uh let's see configuration Maybe](https://youtu.be/HxupjQwU9GE?t=01h49m49s)

[to hostname user spawn rate](https://youtu.be/HxupjQwU9GE?t=01h49m53s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h49m58s)

[uh optional path](https://youtu.be/HxupjQwU9GE?t=01h50m02s)

[worker](https://youtu.be/HxupjQwU9GE?t=01h50m10s)

[um](https://youtu.be/HxupjQwU9GE?t=01h50m15s)

[I mean I](https://youtu.be/HxupjQwU9GE?t=01h50m16s)

[could set it up I](https://youtu.be/HxupjQwU9GE?t=01h50m19s)

[guess](https://youtu.be/HxupjQwU9GE?t=01h50m21s)

[but this looks like it's TLS certificate](https://youtu.be/HxupjQwU9GE?t=01h50m25s)

[for serving up the web oh yeah web UI](https://youtu.be/HxupjQwU9GE?t=01h50m28s)

[yeah that's](https://youtu.be/HxupjQwU9GE?t=01h50m30s)

[that's not what I want I want it uh](https://youtu.be/HxupjQwU9GE?t=01h50m32s)

[config file path okay](https://youtu.be/HxupjQwU9GE?t=01h50m34s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h50m37s)

[uh available configuration options](https://youtu.be/HxupjQwU9GE?t=01h50m45s)

[let's go there](https://youtu.be/HxupjQwU9GE?t=01h50m49s)

[uh nope and nope and nope okay so](https://youtu.be/HxupjQwU9GE?t=01h50m55s)

[worthless](https://youtu.be/HxupjQwU9GE?t=01h51m00s)

[okay](https://youtu.be/HxupjQwU9GE?t=01h51m03s)

[this](https://youtu.be/HxupjQwU9GE?t=01h51m05s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h51m07s)

[uh self](https://youtu.be/HxupjQwU9GE?t=01h51m15s)

[um](https://youtu.be/HxupjQwU9GE?t=01h51m21s)

[faster HTTP client](https://youtu.be/HxupjQwU9GE?t=01h51m27s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h51m30s)

[oh](https://youtu.be/HxupjQwU9GE?t=01h51m36s)

[that looks like we may have a winner](https://youtu.be/HxupjQwU9GE?t=01h51m38s)

[you can turn off this](https://youtu.be/HxupjQwU9GE?t=01h51m42s)

[perfect that's what I wanted](https://youtu.be/HxupjQwU9GE?t=01h51m47s)

[thank you](https://youtu.be/HxupjQwU9GE?t=01h51m49s)

[we come here](https://youtu.be/HxupjQwU9GE?t=01h51m52s)

[and apparently we do that](https://youtu.be/HxupjQwU9GE?t=01h51m55s)

[do that we do that](https://youtu.be/HxupjQwU9GE?t=01h52m01s)

[and we call it a day I think](https://youtu.be/HxupjQwU9GE?t=01h52m04s)

[right uh by adding below method](https://youtu.be/HxupjQwU9GE?t=01h52m07s)

[uh using the following code](https://youtu.be/HxupjQwU9GE?t=01h52m15s)

[from Locus](https://youtu.be/HxupjQwU9GE?t=01h52m19s)

[uh this is](https://youtu.be/HxupjQwU9GE?t=01h52m22s)

[wait they](https://youtu.be/HxupjQwU9GE?t=01h52m25s)

[yeah I think we're gonna try a first](https://youtu.be/HxupjQwU9GE?t=01h52m31s)

[option this seems like a much easier](https://youtu.be/HxupjQwU9GE?t=01h52m33s)

[approach okay kill launch](https://youtu.be/HxupjQwU9GE?t=01h52m34s)

[and then back over to here](https://youtu.be/HxupjQwU9GE?t=01h52m40s)

[reload](https://youtu.be/HxupjQwU9GE?t=01h52m43s)

[one](https://youtu.be/HxupjQwU9GE?t=01h52m45s)

[uh paste](https://youtu.be/HxupjQwU9GE?t=01h52m47s)

[start](https://youtu.be/HxupjQwU9GE?t=01h52m49s)

[and then I should see](https://youtu.be/HxupjQwU9GE?t=01h52m54s)

[votes](https://youtu.be/HxupjQwU9GE?t=01h52m58s)

[in theory](https://youtu.be/HxupjQwU9GE?t=01h53m00s)

[because they are succeeding](https://youtu.be/HxupjQwU9GE?t=01h53m05s)

[no failures current ratio](https://youtu.be/HxupjQwU9GE?t=01h53m12s)

[which is so fine I am very curious](https://youtu.be/HxupjQwU9GE?t=01h53m21s)

[uh CPU yoga is overwhelmed and computer](https://youtu.be/HxupjQwU9GE?t=01h53m29s)

[crashes don't joke](https://youtu.be/HxupjQwU9GE?t=01h53m31s)

[I have had streams where I have](https://youtu.be/HxupjQwU9GE?t=01h53m34s)

[accidentally been playing around with](https://youtu.be/HxupjQwU9GE?t=01h53m37s)

[stuff and then Fork bombed my own system](https://youtu.be/HxupjQwU9GE?t=01h53m38s)

[OBS does not work when you Fork bomb](https://youtu.be/HxupjQwU9GE?t=01h53m41s)

[when you Fork bomb your system it's](https://youtu.be/HxupjQwU9GE?t=01h53m44s)

[really horrible](https://youtu.be/HxupjQwU9GE?t=01h53m46s)

[on the yeah yeah that's pretty much how](https://youtu.be/HxupjQwU9GE?t=01h53m49s)

[it goes](https://youtu.be/HxupjQwU9GE?t=01h53m52s)

[um](https://youtu.be/HxupjQwU9GE?t=01h53m53s)

[oh do I have to vote](https://youtu.be/HxupjQwU9GE?t=01h53m55s)

[oh request rate exceeded](https://youtu.be/HxupjQwU9GE?t=01h53m57s)

[this thing has requests what](https://youtu.be/HxupjQwU9GE?t=01h54m01s)

[oh](https://youtu.be/HxupjQwU9GE?t=01h54m06s)

[wait what](https://youtu.be/HxupjQwU9GE?t=01h54m08s)

[I mean](https://youtu.be/HxupjQwU9GE?t=01h54m12s)

[so basically](https://youtu.be/HxupjQwU9GE?t=01h54m16s)

[ah](https://youtu.be/HxupjQwU9GE?t=01h54m21s)

[what](https://youtu.be/HxupjQwU9GE?t=01h54m23s)

[where is that set up](https://youtu.be/HxupjQwU9GE?t=01h54m26s)

[I mean I'm impressed](https://youtu.be/HxupjQwU9GE?t=01h54m28s)

[um](https://youtu.be/HxupjQwU9GE?t=01h54m32s)

[I'm kind of curious how much uh Orleans](https://youtu.be/HxupjQwU9GE?t=01h54m35s)

[is hidden behind some of these things](https://youtu.be/HxupjQwU9GE?t=01h54m38s)

[okay what what all do you have on you](https://youtu.be/HxupjQwU9GE?t=01h54m40s)

[because actually maybe I should just](https://youtu.be/HxupjQwU9GE?t=01h54m44s)

[search Orleans request rate because](https://youtu.be/HxupjQwU9GE?t=01h54m47s)

[that's going to be a bit of a problem if](https://youtu.be/HxupjQwU9GE?t=01h54m50s)

[I'm trying to push it](https://youtu.be/HxupjQwU9GE?t=01h54m52s)

[uh okay so let's close some of these](https://youtu.be/HxupjQwU9GE?t=01h54m55s)

[things down because I don't need all of](https://youtu.be/HxupjQwU9GE?t=01h54m59s)

[you](https://youtu.be/HxupjQwU9GE?t=01h55m00s)

[yeah so we're gonna go here we're gonna](https://youtu.be/HxupjQwU9GE?t=01h55m01s)

[go here we're gonna go here](https://youtu.be/HxupjQwU9GE?t=01h55m03s)

[uh oh that's an interesting chart](https://youtu.be/HxupjQwU9GE?t=01h55m05s)

[huh](https://youtu.be/HxupjQwU9GE?t=01h55m12s)

[oh this is actually connected to the](https://youtu.be/HxupjQwU9GE?t=01h55m15s)

[same instance got it oh that's cool](https://youtu.be/HxupjQwU9GE?t=01h55m17s)

[because it was running for so long oh](https://youtu.be/HxupjQwU9GE?t=01h55m19s)

[that is clever that is clever I'm](https://youtu.be/HxupjQwU9GE?t=01h55m21s)

[closing you uh let's see](https://youtu.be/HxupjQwU9GE?t=01h55m24s)

[Orleans uh](https://youtu.be/HxupjQwU9GE?t=01h55m28s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h55m36s)

[how do I limit](https://youtu.be/HxupjQwU9GE?t=01h55m41s)

[uh rate limiting for net](https://youtu.be/HxupjQwU9GE?t=01h55m44s)

[like I I know rate limiting is a thing](https://youtu.be/HxupjQwU9GE?t=01h55m48s)

[and I know they added cool apis for it](https://youtu.be/HxupjQwU9GE?t=01h55m53s)

[yeah so this is a net seven coolness](https://youtu.be/HxupjQwU9GE?t=01h55m58s)

[that they added which is slick](https://youtu.be/HxupjQwU9GE?t=01h56m02s)

[because building rate limiting is really](https://youtu.be/HxupjQwU9GE?t=01h56m04s)

[hard to do well](https://youtu.be/HxupjQwU9GE?t=01h56m07s)

[and it's impressive that there's now a](https://youtu.be/HxupjQwU9GE?t=01h56m08s)

[nice little thing in the Box to do it](https://youtu.be/HxupjQwU9GE?t=01h56m11s)

[um but](https://youtu.be/HxupjQwU9GE?t=01h56m14s)

[so for starters this is a net](https://youtu.be/HxupjQwU9GE?t=01h56m17s)

[six project](https://youtu.be/HxupjQwU9GE?t=01h56m20s)

[it's not referencing any of the](https://youtu.be/HxupjQwU9GE?t=01h56m22s)

[as far as I'm aware](https://youtu.be/HxupjQwU9GE?t=01h56m25s)

[just make sure that Orleans package](https://youtu.be/HxupjQwU9GE?t=01h56m27s)

[didn't bring in something weird did it](https://youtu.be/HxupjQwU9GE?t=01h56m29s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h56m32s)

[uh](https://youtu.be/HxupjQwU9GE?t=01h56m33s)

[no](https://youtu.be/HxupjQwU9GE?t=01h56m35s)

[yeah there's no weird 7-0 dependencies](https://youtu.be/HxupjQwU9GE?t=01h56m39s)

[dropping in that would be that would be](https://youtu.be/HxupjQwU9GE?t=01h56m42s)

[unusual for a 6-0 to all of a sudden](https://youtu.be/HxupjQwU9GE?t=01h56m44s)

[pick up 70 dependencies okay so it's](https://youtu.be/HxupjQwU9GE?t=01h56m45s)

[it's probably not that](https://youtu.be/HxupjQwU9GE?t=01h56m48s)

[um](https://youtu.be/HxupjQwU9GE?t=01h56m52s)

[I do wonder if there's a health check](https://youtu.be/HxupjQwU9GE?t=01h56m57s)

[actually set up and running on this too](https://youtu.be/HxupjQwU9GE?t=01h56m58s)

[I should check](https://youtu.be/HxupjQwU9GE?t=01h57m00s)

[uh let's see](https://youtu.be/HxupjQwU9GE?t=01h57m03s)

[uh duplicate tab](https://youtu.be/HxupjQwU9GE?t=01h57m06s)

[oh yeah we've we've hit some sort of](https://youtu.be/HxupjQwU9GE?t=01h57m09s)

[back off](https://youtu.be/HxupjQwU9GE?t=01h57m11s)

[is there a health check](https://youtu.be/HxupjQwU9GE?t=01h57m12s)

[no so there's no health checks actually](https://youtu.be/HxupjQwU9GE?t=01h57m17s)

[set up](https://youtu.be/HxupjQwU9GE?t=01h57m19s)

[which I'm not](https://youtu.be/HxupjQwU9GE?t=01h57m22s)

[uh configure web host defaults yada yada](https://youtu.be/HxupjQwU9GE?t=01h57m24s)

[so this is just the regular health check](https://youtu.be/HxupjQwU9GE?t=01h57m27s)

[stuff oh this is a grain health check](https://youtu.be/HxupjQwU9GE?t=01h57m30s)

[um this is different](https://youtu.be/HxupjQwU9GE?t=01h57m33s)

[um](https://youtu.be/HxupjQwU9GE?t=01h57m37s)

[this is interesting Performance Health](https://youtu.be/HxupjQwU9GE?t=01h57m40s)

[check](https://youtu.be/HxupjQwU9GE?t=01h57m42s)

[well that's interesting so this thing](https://youtu.be/HxupjQwU9GE?t=01h57m47s)

[could actually end up wait](https://youtu.be/HxupjQwU9GE?t=01h57m50s)

[so in Orleans a grain is the](https://youtu.be/HxupjQwU9GE?t=01h57m53s)

[limit phrase as I understand it a grain](https://youtu.be/HxupjQwU9GE?t=01h57m57s)

[is the smallest unit of data and the](https://youtu.be/HxupjQwU9GE?t=01h58m00s)

[nice part is you interact with the](https://youtu.be/HxupjQwU9GE?t=01h58m03s)

[grains and you don't worry about](https://youtu.be/HxupjQwU9GE?t=01h58m04s)

[necessarily the backing storage](https://youtu.be/HxupjQwU9GE?t=01h58m06s)

[mechanisms or how those are being dealt](https://youtu.be/HxupjQwU9GE?t=01h58m07s)

[with you get to focus on the important](https://youtu.be/HxupjQwU9GE?t=01h58m10s)

[stuff](https://youtu.be/HxupjQwU9GE?t=01h58m12s)

[and Orleans handles the heavy lifting](https://youtu.be/HxupjQwU9GE?t=01h58m13s)

[which is perfect that's what sane people](https://youtu.be/HxupjQwU9GE?t=01h58m15s)

[would want it's just cool that you could](https://youtu.be/HxupjQwU9GE?t=01h58m18s)

[do like](https://youtu.be/HxupjQwU9GE?t=01h58m20s)

[CPU Orleans health check](https://youtu.be/HxupjQwU9GE?t=01h58m22s)

[and set those up that is](https://youtu.be/HxupjQwU9GE?t=01h58m27s)

[that is pretty cool okay so](https://youtu.be/HxupjQwU9GE?t=01h58m32s)

[okay so that that's firing off and](https://youtu.be/HxupjQwU9GE?t=01h58m39s)

[running](https://youtu.be/HxupjQwU9GE?t=01h58m41s)

[um I guess then the question that maybe](https://youtu.be/HxupjQwU9GE?t=01h58m43s)

[maybe we should test is just the loading](https://youtu.be/HxupjQwU9GE?t=01h58m45s)

[of this page](https://youtu.be/HxupjQwU9GE?t=01h58m48s)

[right is maybe I should just](https://youtu.be/HxupjQwU9GE?t=01h58m49s)

[have this guy fire off uh](https://youtu.be/HxupjQwU9GE?t=01h58m53s)

[so this would be the vote task](https://youtu.be/HxupjQwU9GE?t=01h58m57s)

[maybe we're going to turn this one off](https://youtu.be/HxupjQwU9GE?t=01h59m01s)

[for the moment and I'm gonna do a second](https://youtu.be/HxupjQwU9GE?t=01h59m03s)

[one](https://youtu.be/HxupjQwU9GE?t=01h59m07s)

[that's just](https://youtu.be/HxupjQwU9GE?t=01h59m07s)

[uh uh I don't know](https://youtu.be/HxupjQwU9GE?t=01h59m11s)

[call it load pull](https://youtu.be/HxupjQwU9GE?t=01h59m14s)

[right and it's just going to go at the](https://youtu.be/HxupjQwU9GE?t=01h59m18s)

[root](https://youtu.be/HxupjQwU9GE?t=01h59m21s)

[right and so we will go here](https://youtu.be/HxupjQwU9GE?t=01h59m23s)

[actually now that I'm realizing how that](https://youtu.be/HxupjQwU9GE?t=01h59m28s)

[works](https://youtu.be/HxupjQwU9GE?t=01h59m30s)

[I I probably need to close it and](https://youtu.be/HxupjQwU9GE?t=01h59m34s)

[relaunched](https://youtu.be/HxupjQwU9GE?t=01h59m36s)

[I don't actually know if I need to](https://youtu.be/HxupjQwU9GE?t=01h59m38s)

[but](https://youtu.be/HxupjQwU9GE?t=01h59m40s)

[that then makes me realize I could](https://youtu.be/HxupjQwU9GE?t=01h59m41s)

[probably start testing the cluster just](https://youtu.be/HxupjQwU9GE?t=01h59m44s)

[by feeding it this URL](https://youtu.be/HxupjQwU9GE?t=01h59m46s)

[we're gonna try it](https://youtu.be/HxupjQwU9GE?t=01h59m52s)

[host number users let's do a modest 10](https://youtu.be/HxupjQwU9GE?t=01h59m54s)

[start swarming](https://youtu.be/HxupjQwU9GE?t=01h59m59s)

[okay we're going to go with charts](https://youtu.be/HxupjQwU9GE?t=02h00m04s)

[and I'm most interested in response time](https://youtu.be/HxupjQwU9GE?t=02h00m07s)

[and seeing if that goes up and then I'm](https://youtu.be/HxupjQwU9GE?t=02h00m09s)

[also curious to go and look at](https://youtu.be/HxupjQwU9GE?t=02h00m11s)

[the cluster](https://youtu.be/HxupjQwU9GE?t=02h00m14s)

[and look at those metrics and see](https://youtu.be/HxupjQwU9GE?t=02h00m18s)

[what we see here uh I thought I already](https://youtu.be/HxupjQwU9GE?t=02h00m21s)

[had this open](https://youtu.be/HxupjQwU9GE?t=02h00m25s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h00m27s)

[we're gonna do](https://youtu.be/HxupjQwU9GE?t=02h00m30s)

[CPU usage percentage](https://youtu.be/HxupjQwU9GE?t=02h00m34s)

[and then we want to dial this down into](https://youtu.be/HxupjQwU9GE?t=02h00m39s)

[small](https://youtu.be/HxupjQwU9GE?t=02h00m41s)

[time range](https://youtu.be/HxupjQwU9GE?t=02h00m43s)

[and then I wanted to do](https://youtu.be/HxupjQwU9GE?t=02h00m44s)

[uh working set percentage](https://youtu.be/HxupjQwU9GE?t=02h00m48s)

[and](https://youtu.be/HxupjQwU9GE?t=02h00m55s)

[this thing isn't even noticing](https://youtu.be/HxupjQwU9GE?t=02h01m01s)

[uh that's](https://youtu.be/HxupjQwU9GE?t=02h01m09s)

[that's impressive so if I put that graph](https://youtu.be/HxupjQwU9GE?t=02h01m12s)

[over there that graph over there](https://youtu.be/HxupjQwU9GE?t=02h01m14s)

[okay so at least in terms of response](https://youtu.be/HxupjQwU9GE?t=02h01m18s)

[time](https://youtu.be/HxupjQwU9GE?t=02h01m21s)

[nothing's changed](https://youtu.be/HxupjQwU9GE?t=02h01m26s)

[okay](https://youtu.be/HxupjQwU9GE?t=02h01m28s)

[number of users](https://youtu.be/HxupjQwU9GE?t=02h01m30s)

[we're gonna just do orders of magnitude](https://youtu.be/HxupjQwU9GE?t=02h01m32s)

[and some so I'm going to apologize](https://youtu.be/HxupjQwU9GE?t=02h01m34s)

[you're slow at reporting those metrics](https://youtu.be/HxupjQwU9GE?t=02h01m38s)

[sometimes it is and it can drag behind](https://youtu.be/HxupjQwU9GE?t=02h01m40s)

[by like a minute or two](https://youtu.be/HxupjQwU9GE?t=02h01m42s)

[but](https://youtu.be/HxupjQwU9GE?t=02h01m44s)

[this is still reporting basically a](https://youtu.be/HxupjQwU9GE?t=02h01m48s)

[constant response time](https://youtu.be/HxupjQwU9GE?t=02h01m51s)

[so I'm not I'm not as concerned about](https://youtu.be/HxupjQwU9GE?t=02h01m54s)

[the Azure metrics because ultimately if](https://youtu.be/HxupjQwU9GE?t=02h01m57s)

[the thing's under too much load what I](https://youtu.be/HxupjQwU9GE?t=02h02m00s)

[would expect to happen is to see these](https://youtu.be/HxupjQwU9GE?t=02h02m02s)

[response times start to climb](https://youtu.be/HxupjQwU9GE?t=02h02m05s)

[now admittedly it's not doing a lot](https://youtu.be/HxupjQwU9GE?t=02h02m07s)

[right it's just it's just hitting the](https://youtu.be/HxupjQwU9GE?t=02h02m09s)

[page but that page initialize is doing](https://youtu.be/HxupjQwU9GE?t=02h02m12s)

[the](https://youtu.be/HxupjQwU9GE?t=02h02m15s)

[the the loading of the poll at least](https://youtu.be/HxupjQwU9GE?t=02h02m16s)

[so mild amounts of load](https://youtu.be/HxupjQwU9GE?t=02h02m19s)

[but again I am curious to see](https://youtu.be/HxupjQwU9GE?t=02h02m21s)

[how this plays out](https://youtu.be/HxupjQwU9GE?t=02h02m25s)

[and I did know uh so there is a small](https://youtu.be/HxupjQwU9GE?t=02h02m28s)

[increase here](https://youtu.be/HxupjQwU9GE?t=02h02m32s)

[small increase](https://youtu.be/HxupjQwU9GE?t=02h02m35s)

[CPU load is going up](https://youtu.be/HxupjQwU9GE?t=02h02m40s)

[but the](https://youtu.be/HxupjQwU9GE?t=02h02m49s)

[wanna wait till this thing gets capped](https://youtu.be/HxupjQwU9GE?t=02h02m54s)

[up at 100 then we'll let it sit for a](https://youtu.be/HxupjQwU9GE?t=02h02m56s)

[minute](https://youtu.be/HxupjQwU9GE?t=02h02m58s)

[the other thing that that I probably](https://youtu.be/HxupjQwU9GE?t=02h03m01s)

[need to check](https://youtu.be/HxupjQwU9GE?t=02h03m04s)

[is the sorry sign in on another tab](https://youtu.be/HxupjQwU9GE?t=02h03m06s)

[um the node pools on this cluster are](https://youtu.be/HxupjQwU9GE?t=02h03m11s)

[set to scale so remember we dialed down](https://youtu.be/HxupjQwU9GE?t=02h03m14s)

[our app to only one replica so there is](https://youtu.be/HxupjQwU9GE?t=02h03m17s)

[one instance of this application](https://youtu.be/HxupjQwU9GE?t=02h03m20s)

[we could very easily](https://youtu.be/HxupjQwU9GE?t=02h03m23s)

[scale it out](https://youtu.be/HxupjQwU9GE?t=02h03m25s)

[oh dear Heavens Microsoft](https://youtu.be/HxupjQwU9GE?t=02h03m28s)

[I have gotten myself somehow stuck in a](https://youtu.be/HxupjQwU9GE?t=02h03m30s)

[login Loop](https://youtu.be/HxupjQwU9GE?t=02h03m33s)

[let me in](https://youtu.be/HxupjQwU9GE?t=02h03m37s)

[let me in](https://youtu.be/HxupjQwU9GE?t=02h03m39s)

[wow that was](https://youtu.be/HxupjQwU9GE?t=02h03m44s)

[I don't know how many times I attempted](https://youtu.be/HxupjQwU9GE?t=02h03m46s)

[to log in on that one](https://youtu.be/HxupjQwU9GE?t=02h03m48s)

[the other thing is I kind of suspect it](https://youtu.be/HxupjQwU9GE?t=02h03m51s)

[may be hitting the rate limit cap on it](https://youtu.be/HxupjQwU9GE?t=02h03m53s)

[oh](https://youtu.be/HxupjQwU9GE?t=02h03m57s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h03m58s)

[uh where is remove from group duplicate](https://youtu.be/HxupjQwU9GE?t=02h04m00s)

[tab](https://youtu.be/HxupjQwU9GE?t=02h04m02s)

[move from group I don't want to be in a](https://youtu.be/HxupjQwU9GE?t=02h04m04s)

[group and I don't want you to be in a](https://youtu.be/HxupjQwU9GE?t=02h04m06s)

[group](https://youtu.be/HxupjQwU9GE?t=02h04m08s)

[move from group thank you okay](https://youtu.be/HxupjQwU9GE?t=02h04m08s)

[so I kind of suspect that if I try to](https://youtu.be/HxupjQwU9GE?t=02h04m17s)

[reload this page here](https://youtu.be/HxupjQwU9GE?t=02h04m19s)

[yeah so](https://youtu.be/HxupjQwU9GE?t=02h04m21s)

[whatever rate limiting is going on it is](https://youtu.be/HxupjQwU9GE?t=02h04m23s)

[definitely](https://youtu.be/HxupjQwU9GE?t=02h04m26s)

[pounded on it](https://youtu.be/HxupjQwU9GE?t=02h04m27s)

[um but I am wondering wondering if it](https://youtu.be/HxupjQwU9GE?t=02h04m31s)

[did any scaling of the node pool as well](https://youtu.be/HxupjQwU9GE?t=02h04m34s)

[let's just take a quick Gander here](https://youtu.be/HxupjQwU9GE?t=02h04m38s)

[so it hasn't even bothered to scale up](https://youtu.be/HxupjQwU9GE?t=02h04m44s)

[the node pool yet so From kubernetes](https://youtu.be/HxupjQwU9GE?t=02h04m46s)

[perspective](https://youtu.be/HxupjQwU9GE?t=02h04m49s)

[this thing isn't under much load](https://youtu.be/HxupjQwU9GE?t=02h04m51s)

[because the the memory set has remained](https://youtu.be/HxupjQwU9GE?t=02h05m00s)

[more or less constant the CPU load has](https://youtu.be/HxupjQwU9GE?t=02h05m03s)

[increased](https://youtu.be/HxupjQwU9GE?t=02h05m07s)

[and we've obviously increased our](https://youtu.be/HxupjQwU9GE?t=02h05m08s)

[response time](https://youtu.be/HxupjQwU9GE?t=02h05m12s)

[but I mean that that isn't bad](https://youtu.be/HxupjQwU9GE?t=02h05m18s)

[considering the response time is](https://youtu.be/HxupjQwU9GE?t=02h05m20s)

[gone up to](https://youtu.be/HxupjQwU9GE?t=02h05m24s)

[160 170 180](https://youtu.be/HxupjQwU9GE?t=02h05m26s)

[okay so short version is somewhere](https://youtu.be/HxupjQwU9GE?t=02h05m35s)

[between 10 and 100 we have a noticeable](https://youtu.be/HxupjQwU9GE?t=02h05m39s)

[change we go from a response time](https://youtu.be/HxupjQwU9GE?t=02h05m42s)

[an average response time in the](https://youtu.be/HxupjQwU9GE?t=02h05m45s)

[50s to a response time in the low 100s](https://youtu.be/HxupjQwU9GE?t=02h05m49s)

[ballpark](https://youtu.be/HxupjQwU9GE?t=02h05m54s)

[okay](https://youtu.be/HxupjQwU9GE?t=02h05m59s)

[sounds like a weak server oh this is a](https://youtu.be/HxupjQwU9GE?t=02h06m01s)

[very weak server](https://youtu.be/HxupjQwU9GE?t=02h06m03s)

[um I I dialed this uh I very](https://youtu.be/HxupjQwU9GE?t=02h06m05s)

[intentionally set up this kubernetes](https://youtu.be/HxupjQwU9GE?t=02h06m08s)

[cluster with a very weak](https://youtu.be/HxupjQwU9GE?t=02h06m10s)

[um](https://youtu.be/HxupjQwU9GE?t=02h06m12s)

[a very weak VM scale set underneath it](https://youtu.be/HxupjQwU9GE?t=02h06m14s)

[because I wanted to see where what kind](https://youtu.be/HxupjQwU9GE?t=02h06m17s)

[of load a weak one could handle](https://youtu.be/HxupjQwU9GE?t=02h06m20s)

[but I'm also only running one instance](https://youtu.be/HxupjQwU9GE?t=02h06m22s)

[of the application so I think that's](https://youtu.be/HxupjQwU9GE?t=02h06m24s)

[what I want to try next is let's dial](https://youtu.be/HxupjQwU9GE?t=02h06m26s)

[that](https://youtu.be/HxupjQwU9GE?t=02h06m29s)

[um](https://youtu.be/HxupjQwU9GE?t=02h06m31s)

[let's not have one instance of our app](https://youtu.be/HxupjQwU9GE?t=02h06m33s)

[let's have three](https://youtu.be/HxupjQwU9GE?t=02h06m35s)

[and oh I need to do the uh Grumble](https://youtu.be/HxupjQwU9GE?t=02h06m37s)

[Grumble Grumble Grumble uh AZ AKs](https://youtu.be/HxupjQwU9GE?t=02h06m41s)

[oh and I already forgot](https://youtu.be/HxupjQwU9GE?t=02h06m48s)

[uh Blazer user uh with ten thousand](https://youtu.be/HxupjQwU9GE?t=02h06m51s)

[requests without huge spikes so I was](https://youtu.be/HxupjQwU9GE?t=02h06m54s)

[wondering yeah so I'm guessing you're](https://youtu.be/HxupjQwU9GE?t=02h06m56s)

[probably running on a much more](https://youtu.be/HxupjQwU9GE?t=02h06m58s)

[reasonable server so this guy here if](https://youtu.be/HxupjQwU9GE?t=02h06m59s)

[you are if you are interested](https://youtu.be/HxupjQwU9GE?t=02h07m02s)

[is a boom](https://youtu.be/HxupjQwU9GE?t=02h07m05s)

[we saw it a second ago](https://youtu.be/HxupjQwU9GE?t=02h07m08s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h07m10s)

[it's a b tier](https://youtu.be/HxupjQwU9GE?t=02h07m13s)

[node dedicated with 16 cores yeah so](https://youtu.be/HxupjQwU9GE?t=02h07m16s)

[that's a little that's a little B for](https://youtu.be/HxupjQwU9GE?t=02h07m19s)

[them what would I would I dial this](https://youtu.be/HxupjQwU9GE?t=02h07m21s)

[thing up on why where am I not why am I](https://youtu.be/HxupjQwU9GE?t=02h07m23s)

[not seeing my node pool sizes](https://youtu.be/HxupjQwU9GE?t=02h07m25s)

[yes uh](https://youtu.be/HxupjQwU9GE?t=02h07m28s)

[b2ms uh isn't there a](https://youtu.be/HxupjQwU9GE?t=02h07m31s)

[where was the fly out with the](https://youtu.be/HxupjQwU9GE?t=02h07m36s)

[configuration on it](https://youtu.be/HxupjQwU9GE?t=02h07m37s)

[I'm trying to remember this thing is](https://youtu.be/HxupjQwU9GE?t=02h07m39s)

[much smaller than that](https://youtu.be/HxupjQwU9GE?t=02h07m40s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h07m47s)

[uh scale there we go](https://youtu.be/HxupjQwU9GE?t=02h07m49s)

[yeah so](https://youtu.be/HxupjQwU9GE?t=02h07m52s)

[four vcpus 16 gigs so](https://youtu.be/HxupjQwU9GE?t=02h07m53s)

[a quarter of the core well](https://youtu.be/HxupjQwU9GE?t=02h07m57s)

[significantly less](https://youtu.be/HxupjQwU9GE?t=02h08m02s)

[so a bursty four core we'll put it that](https://youtu.be/HxupjQwU9GE?t=02h08m04s)

[way](https://youtu.be/HxupjQwU9GE?t=02h08m07s)

[um](https://youtu.be/HxupjQwU9GE?t=02h08m09s)

[but it does have Auto scale on this pool](https://youtu.be/HxupjQwU9GE?t=02h08m10s)

[to rev up to a second instance if it](https://youtu.be/HxupjQwU9GE?t=02h08m12s)

[ever gets to the point where it needs it](https://youtu.be/HxupjQwU9GE?t=02h08m14s)

[but at least for now](https://youtu.be/HxupjQwU9GE?t=02h08m16s)

[I mean it it's kind of tapering off on](https://youtu.be/HxupjQwU9GE?t=02h08m19s)

[the CPU usage at 25 which I'm not](https://youtu.be/HxupjQwU9GE?t=02h08m22s)

[surprised kubernetes goes I've got](https://youtu.be/HxupjQwU9GE?t=02h08m26s)

[I've got one one instance it's only](https://youtu.be/HxupjQwU9GE?t=02h08m29s)

[being pushed at a quarter of its juice](https://youtu.be/HxupjQwU9GE?t=02h08m32s)

[I'm not spending another instance so I'm](https://youtu.be/HxupjQwU9GE?t=02h08m34s)

[not surprised](https://youtu.be/HxupjQwU9GE?t=02h08m37s)

[um](https://youtu.be/HxupjQwU9GE?t=02h08m39s)

[I would love to get it](https://youtu.be/HxupjQwU9GE?t=02h08m39s)

[I would love to find where](https://youtu.be/HxupjQwU9GE?t=02h08m42s)

[it has that rate limiting in there but I](https://youtu.be/HxupjQwU9GE?t=02h08m46s)

[also want to just push this thing up uh](https://youtu.be/HxupjQwU9GE?t=02h08m48s)

[uh AZ AKs](https://youtu.be/HxupjQwU9GE?t=02h08m51s)

[man because I lost my thingy](https://youtu.be/HxupjQwU9GE?t=02h08m53s)

[uh command there it is okay that's](https://youtu.be/HxupjQwU9GE?t=02h08m57s)

[that's the magic okay so I need the name](https://youtu.be/HxupjQwU9GE?t=02h09m00s)

[the resource Group](https://youtu.be/HxupjQwU9GE?t=02h09m03s)

[and I lost all my variables because we](https://youtu.be/HxupjQwU9GE?t=02h09m06s)

[shut down the terminal for](https://youtu.be/HxupjQwU9GE?t=02h09m09s)

[reasons so we're gonna go there](https://youtu.be/HxupjQwU9GE?t=02h09m11s)

[see name of kubernetes cluster is there](https://youtu.be/HxupjQwU9GE?t=02h09m16s)

[Resource Group is there](https://youtu.be/HxupjQwU9GE?t=02h09m19s)

[and](https://youtu.be/HxupjQwU9GE?t=02h09m25s)

[the command in question will be](https://youtu.be/HxupjQwU9GE?t=02h09m28s)

[the cube cuddle something another](https://youtu.be/HxupjQwU9GE?t=02h09m33s)

[that's provision that's deploy I want](https://youtu.be/HxupjQwU9GE?t=02h09m40s)

[this](https://youtu.be/HxupjQwU9GE?t=02h09m44s)

[and that goes there and but then I need](https://youtu.be/HxupjQwU9GE?t=02h09m47s)

[the fio hang on this ain't gonna work](https://youtu.be/HxupjQwU9GE?t=02h09m50s)

[because I'm in the wrong directory uh CD](https://youtu.be/HxupjQwU9GE?t=02h09m53s)

[uh Dev](https://youtu.be/HxupjQwU9GE?t=02h09m56s)

[Orleans samples coding](https://youtu.be/HxupjQwU9GE?t=02h09m58s)

[uh yeah deployment.yama that's where I](https://youtu.be/HxupjQwU9GE?t=02h10m03s)

[want to be](https://youtu.be/HxupjQwU9GE?t=02h10m06s)

[so now I need](https://youtu.be/HxupjQwU9GE?t=02h10m07s)

[employment.yaml to be included and](https://youtu.be/HxupjQwU9GE?t=02h10m10s)

[here we go](https://youtu.be/HxupjQwU9GE?t=02h10m16s)

[foreign](https://youtu.be/HxupjQwU9GE?t=02h10m20s)

[I deployed that but I'm now wondering](https://youtu.be/HxupjQwU9GE?t=02h10m22s)

[good I did set my replicas up to three](https://youtu.be/HxupjQwU9GE?t=02h10m24s)

[okay so that should](https://youtu.be/HxupjQwU9GE?t=02h10m27s)

[in a moment](https://youtu.be/HxupjQwU9GE?t=02h10m30s)

[come on come on AKs there we go](https://youtu.be/HxupjQwU9GE?t=02h10m33s)

[that configured](https://youtu.be/HxupjQwU9GE?t=02h10m36s)

[let's go back](https://youtu.be/HxupjQwU9GE?t=02h10m38s)

[and there](https://youtu.be/HxupjQwU9GE?t=02h10m39s)

[I want to check my workload and here in](https://youtu.be/HxupjQwU9GE?t=02h10m42s)

[a moment we should see three instances](https://youtu.be/HxupjQwU9GE?t=02h10m45s)

[huzzah](https://youtu.be/HxupjQwU9GE?t=02h10m47s)

[we are running](https://youtu.be/HxupjQwU9GE?t=02h10m49s)

[um we're gonna come back here we'll do a](https://youtu.be/HxupjQwU9GE?t=02h10m52s)

[new poll](https://youtu.be/HxupjQwU9GE?t=02h10m54s)

[uh new test option value](https://youtu.be/HxupjQwU9GE?t=02h10m55s)

[uh one](https://youtu.be/HxupjQwU9GE?t=02h10m59s)

[or I'm sorry add](https://youtu.be/HxupjQwU9GE?t=02h11m01s)

[oh](https://youtu.be/HxupjQwU9GE?t=02h11m03s)

[uh test](https://youtu.be/HxupjQwU9GE?t=02h11m06s)

[no I'm wondering something](https://youtu.be/HxupjQwU9GE?t=02h11m16s)

[oh no never mind I'm wrong](https://youtu.be/HxupjQwU9GE?t=02h11m19s)

[I just can't click](https://youtu.be/HxupjQwU9GE?t=02h11m22s)

[that's fine](https://youtu.be/HxupjQwU9GE?t=02h11m24s)

[it's interesting that this thing is now](https://youtu.be/HxupjQwU9GE?t=02h11m34s)

[failing](https://youtu.be/HxupjQwU9GE?t=02h11m36s)

[uh it's running as net seven right this](https://youtu.be/HxupjQwU9GE?t=02h11m39s)

[so I took the Orleans sample at the](https://youtu.be/HxupjQwU9GE?t=02h11m42s)

[moment](https://youtu.be/HxupjQwU9GE?t=02h11m44s)

[um so it is running as a net six app I](https://youtu.be/HxupjQwU9GE?t=02h11m45s)

[didn't bother to update it I was trying](https://youtu.be/HxupjQwU9GE?t=02h11m49s)

[to avoid touching it too much](https://youtu.be/HxupjQwU9GE?t=02h11m51s)

[I am wondering if](https://youtu.be/HxupjQwU9GE?t=02h11m53s)

[there because their sample initially had](https://youtu.be/HxupjQwU9GE?t=02h11m56s)

[it set to and actually if you're](https://youtu.be/HxupjQwU9GE?t=02h11m58s)

[interested uh this is the](https://youtu.be/HxupjQwU9GE?t=02h12m00s)

[this is the sample I'm playing with](https://youtu.be/HxupjQwU9GE?t=02h12m05s)

[um their initial setup had this thing](https://youtu.be/HxupjQwU9GE?t=02h12m10s)

[set to a replica count of three didn't](https://youtu.be/HxupjQwU9GE?t=02h12m13s)

[it yeah](https://youtu.be/HxupjQwU9GE?t=02h12m16s)

[so they had it set to three](https://youtu.be/HxupjQwU9GE?t=02h12m17s)

[but they missed the container port](https://youtu.be/HxupjQwU9GE?t=02h12m21s)

[something's weird I'm wondering if](https://youtu.be/HxupjQwU9GE?t=02h12m26s)

[I'm wondering if I need to](https://youtu.be/HxupjQwU9GE?t=02h12m33s)

[trunk my data and try this again](https://youtu.be/HxupjQwU9GE?t=02h12m36s)

[okay so that's oh it's probably because](https://youtu.be/HxupjQwU9GE?t=02h12m42s)

[Locus is still pounding on it](https://youtu.be/HxupjQwU9GE?t=02h12m45s)

[um](https://youtu.be/HxupjQwU9GE?t=02h12m48s)

[yeah so you're still pounding away on it](https://youtu.be/HxupjQwU9GE?t=02h12m55s)

[and that's not doing much but I imagine](https://youtu.be/HxupjQwU9GE?t=02h12m59s)

[if I look here](https://youtu.be/HxupjQwU9GE?t=02h13m02s)

[we're probably tapered off](https://youtu.be/HxupjQwU9GE?t=02h13m05s)

[yeah so we're still tapered off into it](https://youtu.be/HxupjQwU9GE?t=02h13m08s)

[interesting](https://youtu.be/HxupjQwU9GE?t=02h13m13s)

[so it works](https://youtu.be/HxupjQwU9GE?t=02h13m17s)

[but the rate limiting inside of Orleans](https://youtu.be/HxupjQwU9GE?t=02h13m21s)

[is](https://youtu.be/HxupjQwU9GE?t=02h13m24s)

[problematic](https://youtu.be/HxupjQwU9GE?t=02h13m26s)

[this thing is loading but](https://youtu.be/HxupjQwU9GE?t=02h13m31s)

[and it's interesting to me that this](https://youtu.be/HxupjQwU9GE?t=02h13m39s)

[thing is just](https://youtu.be/HxupjQwU9GE?t=02h13m41s)

[like it's almost dosing itself](https://youtu.be/HxupjQwU9GE?t=02h13m43s)

[and it's once again acting like the](https://youtu.be/HxupjQwU9GE?t=02h13m49s)

[websockets thing is](https://youtu.be/HxupjQwU9GE?t=02h13m51s)

[bailing out](https://youtu.be/HxupjQwU9GE?t=02h13m53s)

[so there's something interesting going](https://youtu.be/HxupjQwU9GE?t=02h13m57s)

[on here as well](https://youtu.be/HxupjQwU9GE?t=02h14m00s)

[that is that doesn't make a lot of sense](https://youtu.be/HxupjQwU9GE?t=02h14m02s)

[to me](https://youtu.be/HxupjQwU9GE?t=02h14m04s)

[um](https://youtu.be/HxupjQwU9GE?t=02h14m05s)

[but it's interesting that when](https://youtu.be/HxupjQwU9GE?t=02h14m08s)

[I'm kind of wondering if it's related to](https://youtu.be/HxupjQwU9GE?t=02h14m11s)

[the replica count I know that sounds](https://youtu.be/HxupjQwU9GE?t=02h14m14s)

[weird but](https://youtu.be/HxupjQwU9GE?t=02h14m15s)

[uh let's go here let's go here](https://youtu.be/HxupjQwU9GE?t=02h14m19s)

[let's take a look at](https://youtu.be/HxupjQwU9GE?t=02h14m29s)

[I'm curious if this thing starts to work](https://youtu.be/HxupjQwU9GE?t=02h14m34s)

[a little better going back down to one](https://youtu.be/HxupjQwU9GE?t=02h14m37s)

[replica count so the the service inside](https://youtu.be/HxupjQwU9GE?t=02h14m39s)

[of kubernetes can load balance this guy](https://youtu.be/HxupjQwU9GE?t=02h14m42s)

[and I'm wondering if having three](https://youtu.be/HxupjQwU9GE?t=02h14m47s)

[instances and load balancing them across](https://youtu.be/HxupjQwU9GE?t=02h14m49s)

[is problematic I also still have yet to](https://youtu.be/HxupjQwU9GE?t=02h14m52s)

[see this dashboard](https://youtu.be/HxupjQwU9GE?t=02h14m55s)

[I don't know where this dashboard is](https://youtu.be/HxupjQwU9GE?t=02h14m57s)

[should try to get to it](https://youtu.be/HxupjQwU9GE?t=02h15m00s)

[it's a claims](https://youtu.be/HxupjQwU9GE?t=02h15m03s)

[it claims it's sitting on 888](https://youtu.be/HxupjQwU9GE?t=02h15m06s)

[which is a nice claim but](https://youtu.be/HxupjQwU9GE?t=02h15m12s)

[I don't think we've seen it load and I'm](https://youtu.be/HxupjQwU9GE?t=02h15m15s)

[not confident what would turn it on](https://youtu.be/HxupjQwU9GE?t=02h15m17s)

[do they even so aside from the](https://youtu.be/HxupjQwU9GE?t=02h15m23s)

[aside from the readme is there any](https://youtu.be/HxupjQwU9GE?t=02h15m28s)

[references to dashboard in here program](https://youtu.be/HxupjQwU9GE?t=02h15m30s)

[oh there is a](https://youtu.be/HxupjQwU9GE?t=02h15m35s)

[well what do we have here](https://youtu.be/HxupjQwU9GE?t=02h15m41s)

[there's](https://youtu.be/HxupjQwU9GE?t=02h15m48s)

[okay](https://youtu.be/HxupjQwU9GE?t=02h15m50s)

[almost like this is needed in order to](https://youtu.be/HxupjQwU9GE?t=02h15m55s)

[get it to turn on the dashboard](https://youtu.be/HxupjQwU9GE?t=02h15m58s)

[who would have thunk](https://youtu.be/HxupjQwU9GE?t=02h16m01s)

[um I am confused as to why that is off](https://youtu.be/HxupjQwU9GE?t=02h16m04s)

[so let's see this goes inside of this](https://youtu.be/HxupjQwU9GE?t=02h16m08s)

[callback and uses the Orleans Builder](https://youtu.be/HxupjQwU9GE?t=02h16m11s)

[it's like this example got refactored at](https://youtu.be/HxupjQwU9GE?t=02h16m15s)

[some point and](https://youtu.be/HxupjQwU9GE?t=02h16m18s)

[uh let's see](https://youtu.be/HxupjQwU9GE?t=02h16m21s)

[oh so use dashboard no exist anymore](https://youtu.be/HxupjQwU9GE?t=02h16m30s)

[did it just say it was inavailable to](https://youtu.be/HxupjQwU9GE?t=02h16m41s)

[its protection level](https://youtu.be/HxupjQwU9GE?t=02h16m44s)

[interesting okay](https://youtu.be/HxupjQwU9GE?t=02h16m51s)

[so something has gone awry](https://youtu.be/HxupjQwU9GE?t=02h16m53s)

[uh with netsets they improved a lot of](https://youtu.be/HxupjQwU9GE?t=02h16m58s)

[reflection and other core functionality](https://youtu.be/HxupjQwU9GE?t=02h17m00s)

[on a huge server projects I know the](https://youtu.be/HxupjQwU9GE?t=02h17m02s)

[average low went down by 20 just for the](https://youtu.be/HxupjQwU9GE?t=02h17m03s)

[upgrade that's impressive](https://youtu.be/HxupjQwU9GE?t=02h17m05s)

[um I did a stream a couple weeks ago on](https://youtu.be/HxupjQwU9GE?t=02h17m08s)

[a lot of the Net 7 stuff it was more](https://youtu.be/HxupjQwU9GE?t=02h17m10s)

[focused on the features in C sharp](https://youtu.be/HxupjQwU9GE?t=02h17m12s)

[but at dot net comp the asp.net core](https://youtu.be/HxupjQwU9GE?t=02h17m15s)

[team was showing off some very similar](https://youtu.be/HxupjQwU9GE?t=02h17m18s)

[uh metrics on different uh projects that](https://youtu.be/HxupjQwU9GE?t=02h17m22s)

[they helped out with of what they saw](https://youtu.be/HxupjQwU9GE?t=02h17m25s)

[and it is it is insane I I am](https://youtu.be/HxupjQwU9GE?t=02h17m27s)

[continually surprised when they show the](https://youtu.be/HxupjQwU9GE?t=02h17m30s)

[graphs from like net five net six net](https://youtu.be/HxupjQwU9GE?t=02h17m33s)

[seven of the performance improvements](https://youtu.be/HxupjQwU9GE?t=02h17m35s)

[because I saw similar graphs when it was](https://youtu.be/HxupjQwU9GE?t=02h17m38s)

[like net core two netcore three one net](https://youtu.be/HxupjQwU9GE?t=02h17m40s)

[five like each time it's like they're](https://youtu.be/HxupjQwU9GE?t=02h17m43s)

[able to squeeze out all this extra](https://youtu.be/HxupjQwU9GE?t=02h17m45s)

[performances like dear Heavens that is](https://youtu.be/HxupjQwU9GE?t=02h17m47s)

[impressive](https://youtu.be/HxupjQwU9GE?t=02h17m49s)

[it is absolutely shocking to me that](https://youtu.be/HxupjQwU9GE?t=02h17m51s)

[they are able to keep doing that though](https://youtu.be/HxupjQwU9GE?t=02h17m53s)

[it seems like at a certain point they](https://youtu.be/HxupjQwU9GE?t=02h17m55s)

[have to start hitting the the](https://youtu.be/HxupjQwU9GE?t=02h17m57s)

[diminishing returns because I](https://youtu.be/HxupjQwU9GE?t=02h17m59s)

[occasionally look at the pull requests](https://youtu.be/HxupjQwU9GE?t=02h18m01s)

[that go in for some of like the c-sharp](https://youtu.be/HxupjQwU9GE?t=02h18m03s)

[improvements and they're starting to get](https://youtu.be/HxupjQwU9GE?t=02h18m05s)

[down to some micro level optimizations](https://youtu.be/HxupjQwU9GE?t=02h18m07s)

[some of them make a big difference](https://youtu.be/HxupjQwU9GE?t=02h18m10s)

[though like in certain hot paths like](https://youtu.be/HxupjQwU9GE?t=02h18m12s)

[you know a few minor tweaks to like](https://youtu.be/HxupjQwU9GE?t=02h18m15s)

[reflection or string concatenation go a](https://youtu.be/HxupjQwU9GE?t=02h18m18s)

[long way when you're talking about](https://youtu.be/HxupjQwU9GE?t=02h18m21s)

[serving up websites](https://youtu.be/HxupjQwU9GE?t=02h18m22s)

[interesting so this thing existed](https://youtu.be/HxupjQwU9GE?t=02h18m26s)

[this thing got redone](https://youtu.be/HxupjQwU9GE?t=02h18m29s)

[and the dashboard thing](https://youtu.be/HxupjQwU9GE?t=02h18m32s)

[uh we get close to Native yeah it at one](https://youtu.be/HxupjQwU9GE?t=02h18m34s)

[point in time c-sharp used to get mocked](https://youtu.be/HxupjQwU9GE?t=02h18m39s)

[for](https://youtu.be/HxupjQwU9GE?t=02h18m41s)

[um you know how how you know slow it was](https://youtu.be/HxupjQwU9GE?t=02h18m43s)

[but that is that is the C sharp of the](https://youtu.be/HxupjQwU9GE?t=02h18m46s)

[past and Net Framework days](https://youtu.be/HxupjQwU9GE?t=02h18m50s)

[I mean oftentimes there's always the uh](https://youtu.be/HxupjQwU9GE?t=02h18m54s)

[complaint that because oh you're a](https://youtu.be/HxupjQwU9GE?t=02h18m58s)

[garbage collected language and yada yada](https://youtu.be/HxupjQwU9GE?t=02h18m59s)

[yada but the](https://youtu.be/HxupjQwU9GE?t=02h19m01s)

[the fundamental benchmarks that they use](https://youtu.be/HxupjQwU9GE?t=02h19m05s)

[for grading](https://youtu.be/HxupjQwU9GE?t=02h19m07s)

[the different web servers the ASP net](https://youtu.be/HxupjQwU9GE?t=02h19m10s)

[core team I'm convinced is on a quest to](https://youtu.be/HxupjQwU9GE?t=02h19m13s)

[try to top as many of those charts as](https://youtu.be/HxupjQwU9GE?t=02h19m15s)

[they can](https://youtu.be/HxupjQwU9GE?t=02h19m16s)

[and it's it's rather impressive now](https://youtu.be/HxupjQwU9GE?t=02h19m18s)

[admittedly the the code that they write](https://youtu.be/HxupjQwU9GE?t=02h19m21s)

[for those benchmarks to get them to that](https://youtu.be/HxupjQwU9GE?t=02h19m24s)

[point](https://youtu.be/HxupjQwU9GE?t=02h19m26s)

[typically don't match like what you](https://youtu.be/HxupjQwU9GE?t=02h19m27s)

[might do in a production site like](https://youtu.be/HxupjQwU9GE?t=02h19m29s)

[there's there's a trade-off of](https://youtu.be/HxupjQwU9GE?t=02h19m31s)

[performance for functionality of how](https://youtu.be/HxupjQwU9GE?t=02h19m32s)

[much do you want it to do you can only](https://youtu.be/HxupjQwU9GE?t=02h19m35s)

[do so much and go so fast](https://youtu.be/HxupjQwU9GE?t=02h19m37s)

[um but it is it is absolutely impressive](https://youtu.be/HxupjQwU9GE?t=02h19m40s)

[okay so they have changed this dock](https://youtu.be/HxupjQwU9GE?t=02h19m43s)

[quite a bit](https://youtu.be/HxupjQwU9GE?t=02h19m46s)

[at least from where it was set up](https://youtu.be/HxupjQwU9GE?t=02h19m49s)

[this explains why the readme is](https://youtu.be/HxupjQwU9GE?t=02h19m53s)

[different](https://youtu.be/HxupjQwU9GE?t=02h19m57s)

[okay so that that at least explains why](https://youtu.be/HxupjQwU9GE?t=02h20m00s)

[it's different](https://youtu.be/HxupjQwU9GE?t=02h20m03s)

[okay I I wish I had noticed this nested](https://youtu.be/HxupjQwU9GE?t=02h20m06s)

[file down here before](https://youtu.be/HxupjQwU9GE?t=02h20m09s)

[um it's nice that they left the diff](https://youtu.be/HxupjQwU9GE?t=02h20m12s)

[file in so you can compare and contrast](https://youtu.be/HxupjQwU9GE?t=02h20m13s)

[uh but the async thread to uh can catch](https://youtu.be/HxupjQwU9GE?t=02h20m16s)

[up on multi-core systems yes yes and](https://youtu.be/HxupjQwU9GE?t=02h20m20s)

[that and that's the thing is the garbage](https://youtu.be/HxupjQwU9GE?t=02h20m23s)

[collection](https://youtu.be/HxupjQwU9GE?t=02h20m25s)

[oftentimes I think people think of it as](https://youtu.be/HxupjQwU9GE?t=02h20m27s)

[the older garbage collection that would](https://youtu.be/HxupjQwU9GE?t=02h20m29s)

[just freeze Everything clean up and then](https://youtu.be/HxupjQwU9GE?t=02h20m31s)

[run](https://youtu.be/HxupjQwU9GE?t=02h20m33s)

[but the new garbage collectors that are](https://youtu.be/HxupjQwU9GE?t=02h20m34s)

[out there](https://youtu.be/HxupjQwU9GE?t=02h20m36s)

[are much much faster than that](https://youtu.be/HxupjQwU9GE?t=02h20m37s)

[I mean oftentimes people would say that](https://youtu.be/HxupjQwU9GE?t=02h20m42s)

[in C sharp you don't have performance](https://youtu.be/HxupjQwU9GE?t=02h20m44s)

[problems you have memory problems memory](https://youtu.be/HxupjQwU9GE?t=02h20m46s)

[problems and memory problems because the](https://youtu.be/HxupjQwU9GE?t=02h20m48s)

[garbage collector is usually the biggest](https://youtu.be/HxupjQwU9GE?t=02h20m50s)

[bottleneck and that's why so many of the](https://youtu.be/HxupjQwU9GE?t=02h20m51s)

[performance improvements that they've](https://youtu.be/HxupjQwU9GE?t=02h20m54s)

[done recently have been around](https://youtu.be/HxupjQwU9GE?t=02h20m55s)

[effectively mitigating uh allocations](https://youtu.be/HxupjQwU9GE?t=02h20m57s)

[because if you don't allocate memory](https://youtu.be/HxupjQwU9GE?t=02h21m01s)

[there's nothing for the garbage](https://youtu.be/HxupjQwU9GE?t=02h21m04s)

[collector to clean up](https://youtu.be/HxupjQwU9GE?t=02h21m05s)

[and then you go really really fast](https://youtu.be/HxupjQwU9GE?t=02h21m08s)

[because you're not bothering to slow](https://youtu.be/HxupjQwU9GE?t=02h21m10s)

[down and do little things like allocate](https://youtu.be/HxupjQwU9GE?t=02h21m11s)

[some bites](https://youtu.be/HxupjQwU9GE?t=02h21m14s)

[okay](https://youtu.be/HxupjQwU9GE?t=02h21m17s)

[I think then](https://youtu.be/HxupjQwU9GE?t=02h21m18s)

[where I am Landing](https://youtu.be/HxupjQwU9GE?t=02h21m21s)

[is in order to make this reasonably](https://youtu.be/HxupjQwU9GE?t=02h21m23s)

[useful I need to get this to the point](https://youtu.be/HxupjQwU9GE?t=02h21m25s)

[where](https://youtu.be/HxupjQwU9GE?t=02h21m27s)

[where this stops happening](https://youtu.be/HxupjQwU9GE?t=02h21m30s)

[but I but I am noticing that the](https://youtu.be/HxupjQwU9GE?t=02h21m33s)

[going back down to a single instance](https://youtu.be/HxupjQwU9GE?t=02h21m37s)

[there's something there is something in](https://youtu.be/HxupjQwU9GE?t=02h21m44s)

[the setup of this app I'm willing to bet](https://youtu.be/HxupjQwU9GE?t=02h21m47s)

[the old one did it](https://youtu.be/HxupjQwU9GE?t=02h21m49s)

[with the three replicas but](https://youtu.be/HxupjQwU9GE?t=02h21m51s)

[the fact that going to three replicas I](https://youtu.be/HxupjQwU9GE?t=02h21m54s)

[start having](https://youtu.be/HxupjQwU9GE?t=02h21m56s)

[connection issues I'm willing to bet](https://youtu.be/HxupjQwU9GE?t=02h21m58s)

[there is something going on](https://youtu.be/HxupjQwU9GE?t=02h22m03s)

[where if it's not sticky sticky sessions](https://youtu.be/HxupjQwU9GE?t=02h22m07s)

[and one call hit server a and one call](https://youtu.be/HxupjQwU9GE?t=02h22m10s)

[hit server B that we're running into](https://youtu.be/HxupjQwU9GE?t=02h22m13s)

[problems](https://youtu.be/HxupjQwU9GE?t=02h22m16s)

[um very surprised it increased the](https://youtu.be/HxupjQwU9GE?t=02h22m18s)

[weight](https://youtu.be/HxupjQwU9GE?t=02h22m20s)

[and the more that you hit it yeah it's](https://youtu.be/HxupjQwU9GE?t=02h22m21s)

[I'm willing to bet it's some sort of](https://youtu.be/HxupjQwU9GE?t=02h22m23s)

[back off uh let's see](https://youtu.be/HxupjQwU9GE?t=02h22m24s)

[framework is using array pool shared](https://youtu.be/HxupjQwU9GE?t=02h22m27s)

[wherever possible the programs need to](https://youtu.be/HxupjQwU9GE?t=02h22m29s)

[adapt as well to the new high](https://youtu.be/HxupjQwU9GE?t=02h22m30s)

[performance syntaxes like span yes](https://youtu.be/HxupjQwU9GE?t=02h22m32s)

[span memory](https://youtu.be/HxupjQwU9GE?t=02h22m35s)

[um](https://youtu.be/HxupjQwU9GE?t=02h22m37s)

[even things like the there's a lot of](https://youtu.be/HxupjQwU9GE?t=02h22m38s)

[pooling stuff for like string Builders](https://youtu.be/HxupjQwU9GE?t=02h22m41s)

[as well](https://youtu.be/HxupjQwU9GE?t=02h22m43s)

[um](https://youtu.be/HxupjQwU9GE?t=02h22m46s)

[effectively when possible or really](https://youtu.be/HxupjQwU9GE?t=02h22m48s)

[c-sharp developers need to start](https://youtu.be/HxupjQwU9GE?t=02h22m51s)

[thinking in terms of](https://youtu.be/HxupjQwU9GE?t=02h22m53s)

[when performance matters review your](https://youtu.be/HxupjQwU9GE?t=02h22m56s)

[allocations](https://youtu.be/HxupjQwU9GE?t=02h22m58s)

[because two it's very common to see](https://youtu.be/HxupjQwU9GE?t=02h23m00s)

[people just you know make calls that](https://youtu.be/HxupjQwU9GE?t=02h23m02s)

[allocate tons of memory it's like please](https://youtu.be/HxupjQwU9GE?t=02h23m04s)

[don't do that](https://youtu.be/HxupjQwU9GE?t=02h23m05s)

[please don't do that that's bad](https://youtu.be/HxupjQwU9GE?t=02h23m06s)

[that's bad okay so this container Port](https://youtu.be/HxupjQwU9GE?t=02h23m09s)

[doesn't need to exist anymore](https://youtu.be/HxupjQwU9GE?t=02h23m12s)

[because the Orleans dashboard isn't](https://youtu.be/HxupjQwU9GE?t=02h23m15s)

[being registered so that doesn't need to](https://youtu.be/HxupjQwU9GE?t=02h23m17s)

[exist anymore](https://youtu.be/HxupjQwU9GE?t=02h23m18s)

[and I'm willing to bet that this is the](https://youtu.be/HxupjQwU9GE?t=02h23m21s)

[this load balancer is probably the](https://youtu.be/HxupjQwU9GE?t=02h23m25s)

[problem and something in Orleans is](https://youtu.be/HxupjQwU9GE?t=02h23m27s)

[getting bit](https://youtu.be/HxupjQwU9GE?t=02h23m30s)

[by it](https://youtu.be/HxupjQwU9GE?t=02h23m33s)

[it is nice to see though that it is](https://youtu.be/HxupjQwU9GE?t=02h23m37s)

[holding up fairly nicely](https://youtu.be/HxupjQwU9GE?t=02h23m39s)

[okay we're gonna we're gonna try](https://youtu.be/HxupjQwU9GE?t=02h23m44s)

[something bad](https://youtu.be/HxupjQwU9GE?t=02h23m45s)

[I'm gonna apologize in advance if this](https://youtu.be/HxupjQwU9GE?t=02h23m48s)

[does anything to the Stream](https://youtu.be/HxupjQwU9GE?t=02h23m50s)

[but so so far OBS has given me the green](https://youtu.be/HxupjQwU9GE?t=02h23m53s)

[light so](https://youtu.be/HxupjQwU9GE?t=02h23m56s)

[OBS still says green so I'm gonna I'm](https://youtu.be/HxupjQwU9GE?t=02h24m00s)

[gonna assume we're okay](https://youtu.be/HxupjQwU9GE?t=02h24m02s)

[but I I am curious now what because we](https://youtu.be/HxupjQwU9GE?t=02h24m05s)

[saw it go from 50s to low 100s](https://youtu.be/HxupjQwU9GE?t=02h24m08s)

[and some of these spikes we could argue](https://youtu.be/HxupjQwU9GE?t=02h24m13s)

[are potentially deployment times I am](https://youtu.be/HxupjQwU9GE?t=02h24m14s)

[curious what](https://youtu.be/HxupjQwU9GE?t=02h24m17s)

[this does](https://youtu.be/HxupjQwU9GE?t=02h24m20s)

[oh number of users oh that's cool](https://youtu.be/HxupjQwU9GE?t=02h24m25s)

[got a nice little ramp chart for me](https://youtu.be/HxupjQwU9GE?t=02h24m28s)

[here I'm gonna drag you over make you](https://youtu.be/HxupjQwU9GE?t=02h24m31s)

[big](https://youtu.be/HxupjQwU9GE?t=02h24m33s)

[because I want to see the top end of](https://youtu.be/HxupjQwU9GE?t=02h24m34s)

[these charts](https://youtu.be/HxupjQwU9GE?t=02h24m36s)

[then we'll see if this actually does](https://youtu.be/HxupjQwU9GE?t=02h24m42s)

[much](https://youtu.be/HxupjQwU9GE?t=02h24m45s)

[because we went from what is that](https://youtu.be/HxupjQwU9GE?t=02h24m46s)

[I don't know six seven percent to 30ish](https://youtu.be/HxupjQwU9GE?t=02h24m50s)

[going from](https://youtu.be/HxupjQwU9GE?t=02h24m54s)

[adding 50 users](https://youtu.be/HxupjQwU9GE?t=02h24m55s)

[and now I added 400. so theoretically](https://youtu.be/HxupjQwU9GE?t=02h24m57s)

[if this is linear which I don't think it](https://youtu.be/HxupjQwU9GE?t=02h25m01s)

[is](https://youtu.be/HxupjQwU9GE?t=02h25m03s)

[this should spike it enough to prompt](https://youtu.be/HxupjQwU9GE?t=02h25m05s)

[the](https://youtu.be/HxupjQwU9GE?t=02h25m08s)

[the node pool to go](https://youtu.be/HxupjQwU9GE?t=02h25m09s)

[so yeah so at that point](https://youtu.be/HxupjQwU9GE?t=02h25m12s)

[response times are increasing](https://youtu.be/HxupjQwU9GE?t=02h25m16s)

[the poor little server is angry with me](https://youtu.be/HxupjQwU9GE?t=02h25m21s)

[though Azure has yet to figure it out](https://youtu.be/HxupjQwU9GE?t=02h25m26s)

[uh let's check and see so this guy here](https://youtu.be/HxupjQwU9GE?t=02h25m30s)

[should show a single instance](https://youtu.be/HxupjQwU9GE?t=02h25m32s)

[this one little guy is serving up](https://youtu.be/HxupjQwU9GE?t=02h25m34s)

[everything](https://youtu.be/HxupjQwU9GE?t=02h25m37s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h25m39s)

[um let's go with the pool and take a](https://youtu.be/HxupjQwU9GE?t=02h25m40s)

[look](https://youtu.be/HxupjQwU9GE?t=02h25m42s)

[nope still just sitting at the one](https://youtu.be/HxupjQwU9GE?t=02h25m44s)

[uh is that Benchmark reusing its session](https://youtu.be/HxupjQwU9GE?t=02h25m50s)

[or acting as a unique client every time](https://youtu.be/HxupjQwU9GE?t=02h25m53s)

[that is a great question I think it](https://youtu.be/HxupjQwU9GE?t=02h25m55s)

[maintains separate sessions per user if](https://youtu.be/HxupjQwU9GE?t=02h25m59s)

[I understood the docs correctly](https://youtu.be/HxupjQwU9GE?t=02h26m02s)

[so in this case there's probably](https://youtu.be/HxupjQwU9GE?t=02h26m05s)

[230 different sessions](https://youtu.be/HxupjQwU9GE?t=02h26m08s)

[but what we also saw just hitting this](https://youtu.be/HxupjQwU9GE?t=02h26m11s)

[endpoint directly](https://youtu.be/HxupjQwU9GE?t=02h26m14s)

[is because for example if I go straight](https://youtu.be/HxupjQwU9GE?t=02h26m15s)

[here](https://youtu.be/HxupjQwU9GE?t=02h26m19s)

[um](https://youtu.be/HxupjQwU9GE?t=02h26m21s)

[Orleans has some sort of re rate](https://youtu.be/HxupjQwU9GE?t=02h26m23s)

[limiting built into it](https://youtu.be/HxupjQwU9GE?t=02h26m26s)

[and I need I would love to find where](https://youtu.be/HxupjQwU9GE?t=02h26m28s)

[that is so I could turn it off and say I](https://youtu.be/HxupjQwU9GE?t=02h26m30s)

[don't care](https://youtu.be/HxupjQwU9GE?t=02h26m32s)

[and I'm it's probably buried in this](https://youtu.be/HxupjQwU9GE?t=02h26m37s)

[Builder somewhere](https://youtu.be/HxupjQwU9GE?t=02h26m40s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h26m44s)

[uh because all I've got is use](https://youtu.be/HxupjQwU9GE?t=02h26m45s)

[kubernetes hosting](https://youtu.be/HxupjQwU9GE?t=02h26m47s)

[grain storage it could be buried under](https://youtu.be/HxupjQwU9GE?t=02h26m49s)

[one of these things too](https://youtu.be/HxupjQwU9GE?t=02h26m52s)

[it's kind of hard to say oh actually we](https://youtu.be/HxupjQwU9GE?t=02h26m54s)

[could look at the grains let's look](https://youtu.be/HxupjQwU9GE?t=02h26m56s)

[uh because pole grain is what we're](https://youtu.be/HxupjQwU9GE?t=02h26m58s)

[going for](https://youtu.be/HxupjQwU9GE?t=02h27m00s)

[uh uh this thing doesn't appear to have](https://youtu.be/HxupjQwU9GE?t=02h27m04s)

[much](https://youtu.be/HxupjQwU9GE?t=02h27m08s)

[persistent state](https://youtu.be/HxupjQwU9GE?t=02h27m10s)

[user agent grain](https://youtu.be/HxupjQwU9GE?t=02h27m12s)

[and that's the nice part here is this](https://youtu.be/HxupjQwU9GE?t=02h27m19s)

[stuff ah ah almost like almost like this](https://youtu.be/HxupjQwU9GE?t=02h27m22s)

[I have found you](https://youtu.be/HxupjQwU9GE?t=02h27m29s)

[so what I heard is off](https://youtu.be/HxupjQwU9GE?t=02h27m32s)

[off](https://youtu.be/HxupjQwU9GE?t=02h27m35s)

[there](https://youtu.be/HxupjQwU9GE?t=02h27m40s)

[yeah so to be clear this is a demo app](https://youtu.be/HxupjQwU9GE?t=02h27m45s)

[and one that I did not write this was](https://youtu.be/HxupjQwU9GE?t=02h27m51s)

[from The Orleans team and it was meant](https://youtu.be/HxupjQwU9GE?t=02h27m53s)

[to show off](https://youtu.be/HxupjQwU9GE?t=02h27m55s)

[uh well one it was supposed to be](https://youtu.be/HxupjQwU9GE?t=02h27m56s)

[showing off their dashboard and two was](https://youtu.be/HxupjQwU9GE?t=02h28m00s)

[supposed to show off their kubernetes](https://youtu.be/HxupjQwU9GE?t=02h28m02s)

[deployment but I found enough it seems](https://youtu.be/HxupjQwU9GE?t=02h28m04s)

[like this example has gone mildly stale](https://youtu.be/HxupjQwU9GE?t=02h28m07s)

[in some areas and not been updated](https://youtu.be/HxupjQwU9GE?t=02h28m11s)

[in others](https://youtu.be/HxupjQwU9GE?t=02h28m15s)

[so I if I spend too much time on this I](https://youtu.be/HxupjQwU9GE?t=02h28m17s)

[may end up submitting a pull request](https://youtu.be/HxupjQwU9GE?t=02h28m20s)

[updating the demo going now let's bump](https://youtu.be/HxupjQwU9GE?t=02h28m21s)

[some of this but I also deviated from](https://youtu.be/HxupjQwU9GE?t=02h28m24s)

[their directions when I was initially](https://youtu.be/HxupjQwU9GE?t=02h28m26s)

[provisioning I didn't provision my](https://youtu.be/HxupjQwU9GE?t=02h28m28s)

[cluster like this](https://youtu.be/HxupjQwU9GE?t=02h28m30s)

[I Did It My Way](https://youtu.be/HxupjQwU9GE?t=02h28m32s)

[so](https://youtu.be/HxupjQwU9GE?t=02h28m35s)

[I probably would update this a little](https://youtu.be/HxupjQwU9GE?t=02h28m36s)

[differently I I think the big difference](https://youtu.be/HxupjQwU9GE?t=02h28m38s)

[is this was trying to avoid preview](https://youtu.be/HxupjQwU9GE?t=02h28m40s)

[features on AKs and I don't mind using](https://youtu.be/HxupjQwU9GE?t=02h28m42s)

[preview features](https://youtu.be/HxupjQwU9GE?t=02h28m45s)

[um but](https://youtu.be/HxupjQwU9GE?t=02h28m47s)

[let's go through](https://youtu.be/HxupjQwU9GE?t=02h28m50s)

[let's build and push this guy up](https://youtu.be/HxupjQwU9GE?t=02h28m53s)

[um because or actually you know what we](https://youtu.be/HxupjQwU9GE?t=02h28m57s)

[should do we should we should test this](https://youtu.be/HxupjQwU9GE?t=02h28m59s)

[thing locally and verify I don't see](https://youtu.be/HxupjQwU9GE?t=02h29m02s)

[that same](https://youtu.be/HxupjQwU9GE?t=02h29m05s)

[load balancer problem](https://youtu.be/HxupjQwU9GE?t=02h29m06s)

[uh okay](https://youtu.be/HxupjQwU9GE?t=02h29m10s)

[did before I before I stop Locus and](https://youtu.be/HxupjQwU9GE?t=02h29m12s)

[tell it to go somewhere else let's see](https://youtu.be/HxupjQwU9GE?t=02h29m15s)

[where it's at](https://youtu.be/HxupjQwU9GE?t=02h29m17s)

[I am I am remarkably impressed that](https://youtu.be/HxupjQwU9GE?t=02h29m19s)

[with with the load balancer with that](https://youtu.be/HxupjQwU9GE?t=02h29m26s)

[throttling in place](https://youtu.be/HxupjQwU9GE?t=02h29m29s)

[I mean](https://youtu.be/HxupjQwU9GE?t=02h29m34s)

[it's obvious the the load times go or](https://youtu.be/HxupjQwU9GE?t=02h29m35s)

[the response times went up](https://youtu.be/HxupjQwU9GE?t=02h29m39s)

[by a lot](https://youtu.be/HxupjQwU9GE?t=02h29m41s)

[I guess we haven't fully capped out yet](https://youtu.be/HxupjQwU9GE?t=02h29m44s)

[that function is so bad throwing](https://youtu.be/HxupjQwU9GE?t=02h29m47s)

[exceptions to throttle](https://youtu.be/HxupjQwU9GE?t=02h29m49s)

[yeah speaking of things that are very](https://youtu.be/HxupjQwU9GE?t=02h29m52s)

[expensive that's another way to improve](https://youtu.be/HxupjQwU9GE?t=02h29m55s)

[your performance don't throw exceptions](https://youtu.be/HxupjQwU9GE?t=02h29m57s)

[if you don't have to](https://youtu.be/HxupjQwU9GE?t=02h29m59s)

[new exception is a very expensive call](https://youtu.be/HxupjQwU9GE?t=02h30m03s)

[because it has to create a stack Trace](https://youtu.be/HxupjQwU9GE?t=02h30m05s)

[don't do that exceptions are for](https://youtu.be/HxupjQwU9GE?t=02h30m08s)

[exceptional circumstances the hint is in](https://youtu.be/HxupjQwU9GE?t=02h30m10s)

[the name](https://youtu.be/HxupjQwU9GE?t=02h30m13s)

[um](https://youtu.be/HxupjQwU9GE?t=02h30m15s)

[yeah the most expensive way to count](https://youtu.be/HxupjQwU9GE?t=02h30m16s)

[more server load yes absolutely](https://youtu.be/HxupjQwU9GE?t=02h30m19s)

[absolutely](https://youtu.be/HxupjQwU9GE?t=02h30m23s)

[Okay so](https://youtu.be/HxupjQwU9GE?t=02h30m26s)

[I think what I can say is](https://youtu.be/HxupjQwU9GE?t=02h30m27s)

[it's actually a nice function](https://youtu.be/HxupjQwU9GE?t=02h30m31s)

[the the response time in milliseconds](https://youtu.be/HxupjQwU9GE?t=02h30m34s)

[seems to roughly correlate to the number](https://youtu.be/HxupjQwU9GE?t=02h30m37s)

[of user sessions I have open](https://youtu.be/HxupjQwU9GE?t=02h30m40s)

[about 100 users](https://youtu.be/HxupjQwU9GE?t=02h30m43s)

[about 100 millisecond median response](https://youtu.be/HxupjQwU9GE?t=02h30m45s)

[time](https://youtu.be/HxupjQwU9GE?t=02h30m47s)

[about 500 users](https://youtu.be/HxupjQwU9GE?t=02h30m50s)

[about 500 medium response time throw new](https://youtu.be/HxupjQwU9GE?t=02h30m53s)

[operation successful exception no](https://youtu.be/HxupjQwU9GE?t=02h30m55s)

[uh yeah](https://youtu.be/HxupjQwU9GE?t=02h31m01s)

[I I the problem is is you joke and I](https://youtu.be/HxupjQwU9GE?t=02h31m03s)

[have seen libraries that do that and it](https://youtu.be/HxupjQwU9GE?t=02h31m06s)

[just](https://youtu.be/HxupjQwU9GE?t=02h31m09s)

[ah](https://youtu.be/HxupjQwU9GE?t=02h31m10s)

[twitch twitch I start twitching](https://youtu.be/HxupjQwU9GE?t=02h31m12s)

[yeah so there's a So currently without](https://youtu.be/HxupjQwU9GE?t=02h31m16s)

[the throttle Lane in place the function](https://youtu.be/HxupjQwU9GE?t=02h31m19s)

[between users and response time is uh](https://youtu.be/HxupjQwU9GE?t=02h31m21s)

[basically one to one in terms of](https://youtu.be/HxupjQwU9GE?t=02h31m25s)

[milliseconds so that's cool okay so](https://youtu.be/HxupjQwU9GE?t=02h31m27s)

[we're going to stop you for the moment](https://youtu.be/HxupjQwU9GE?t=02h31m30s)

[we're going to stop you for the moment](https://youtu.be/HxupjQwU9GE?t=02h31m32s)

[and then I would like to there were](https://youtu.be/HxupjQwU9GE?t=02h31m35s)

[Builders what were the builders](https://youtu.be/HxupjQwU9GE?t=02h31m38s)

[uh because I can't type oh I left some](https://youtu.be/HxupjQwU9GE?t=02h31m40s)

[dead code there okay so let's do this](https://youtu.be/HxupjQwU9GE?t=02h31m42s)

[so the user grain is the one that was](https://youtu.be/HxupjQwU9GE?t=02h31m46s)

[throttling](https://youtu.be/HxupjQwU9GE?t=02h31m49s)

[okay that's fine](https://youtu.be/HxupjQwU9GE?t=02h31m52s)

[I will say I Orleans is one of those](https://youtu.be/HxupjQwU9GE?t=02h31m54s)

[Frameworks that I feel like I want to](https://youtu.be/HxupjQwU9GE?t=02h31m57s)

[play with a lot more](https://youtu.be/HxupjQwU9GE?t=02h31m58s)

[um every time they show it off they](https://youtu.be/HxupjQwU9GE?t=02h32m00s)

[usually call out the stuff that is](https://youtu.be/HxupjQwU9GE?t=02h32m02s)

[leveraging it like Xbox](https://youtu.be/HxupjQwU9GE?t=02h32m04s)

[like okay if they can handle that kind](https://youtu.be/HxupjQwU9GE?t=02h32m07s)

[of load](https://youtu.be/HxupjQwU9GE?t=02h32m10s)

[it's probably okay](https://youtu.be/HxupjQwU9GE?t=02h32m10s)

[it'll probably handle it uh test option](https://youtu.be/HxupjQwU9GE?t=02h32m13s)

[one and you know what Auto pull create](https://youtu.be/HxupjQwU9GE?t=02h32m16s)

[there it's almost like they built that](https://youtu.be/HxupjQwU9GE?t=02h32m21s)

[specifically because they got annoyed](https://youtu.be/HxupjQwU9GE?t=02h32m23s)

[typing out all of those form fields](https://youtu.be/HxupjQwU9GE?t=02h32m25s)

[almost like that uh okay so I want to do](https://youtu.be/HxupjQwU9GE?t=02h32m28s)

[a refresh](https://youtu.be/HxupjQwU9GE?t=02h32m32s)

[uh I don't want to do a new test I want](https://youtu.be/HxupjQwU9GE?t=02h32m34s)

[to change my Base address to here](https://youtu.be/HxupjQwU9GE?t=02h32m37s)

[and I'm going to do I mean we overloaded](https://youtu.be/HxupjQwU9GE?t=02h32m40s)

[the the throttling with just 10 users so](https://youtu.be/HxupjQwU9GE?t=02h32m43s)

[we're going to start swarming](https://youtu.be/HxupjQwU9GE?t=02h32m45s)

[and](https://youtu.be/HxupjQwU9GE?t=02h32m49s)

[we're gonna go to the pretty graph](https://youtu.be/HxupjQwU9GE?t=02h32m51s)

[because the pretty graph is cool](https://youtu.be/HxupjQwU9GE?t=02h32m52s)

[um oh it didn't that's cool it's got the](https://youtu.be/HxupjQwU9GE?t=02h32m56s)

[old history so these graphs are going to](https://youtu.be/HxupjQwU9GE?t=02h32m59s)

[be a little bit different](https://youtu.be/HxupjQwU9GE?t=02h33m01s)

[oh that's nice it actually separates out](https://youtu.be/HxupjQwU9GE?t=02h33m03s)

[run one and run two](https://youtu.be/HxupjQwU9GE?t=02h33m05s)

[okay so response times](https://youtu.be/HxupjQwU9GE?t=02h33m07s)

[but more importantly the](https://youtu.be/HxupjQwU9GE?t=02h33m12s)

[I should be able to still hit this](https://youtu.be/HxupjQwU9GE?t=02h33m18s)

[and it may be slow but it should load](https://youtu.be/HxupjQwU9GE?t=02h33m23s)

[loading pull](https://youtu.be/HxupjQwU9GE?t=02h33m27s)

[and if I do](https://youtu.be/HxupjQwU9GE?t=02h33m30s)

[this](https://youtu.be/HxupjQwU9GE?t=02h33m34s)

[you've already voted in that poll okay](https://youtu.be/HxupjQwU9GE?t=02h33m45s)

[so now I need to go back](https://youtu.be/HxupjQwU9GE?t=02h33m47s)

[but in theory](https://youtu.be/HxupjQwU9GE?t=02h33m49s)

[I've got that and I should be able to](https://youtu.be/HxupjQwU9GE?t=02h33m54s)

[pass](https://youtu.be/HxupjQwU9GE?t=02h33m57s)

[if I go back to my file here](https://youtu.be/HxupjQwU9GE?t=02h34m00s)

[let's do this](https://youtu.be/HxupjQwU9GE?t=02h34m06s)

[oh actually we already have one let's](https://youtu.be/HxupjQwU9GE?t=02h34m09s)

[turn this on](https://youtu.be/HxupjQwU9GE?t=02h34m12s)

[like this right and I don't know if](https://youtu.be/HxupjQwU9GE?t=02h34m14s)

[I wonder if it re so](https://youtu.be/HxupjQwU9GE?t=02h34m19s)

[okay great fine you're working uh new](https://youtu.be/HxupjQwU9GE?t=02h34m21s)

[test](https://youtu.be/HxupjQwU9GE?t=02h34m24s)

[I wonder if](https://youtu.be/HxupjQwU9GE?t=02h34m25s)

[it will start](https://youtu.be/HxupjQwU9GE?t=02h34m29s)

[I I'm I'm curious as to if it'll reread](https://youtu.be/HxupjQwU9GE?t=02h34m34s)

[the file or not](https://youtu.be/HxupjQwU9GE?t=02h34m38s)

[I'm guessing the answers it won't reread](https://youtu.be/HxupjQwU9GE?t=02h34m40s)

[the file unless you restart](https://youtu.be/HxupjQwU9GE?t=02h34m43s)

[yeah I don't see the other endpoint okay](https://youtu.be/HxupjQwU9GE?t=02h34m45s)

[so stop](https://youtu.be/HxupjQwU9GE?t=02h34m47s)

[uh come back here](https://youtu.be/HxupjQwU9GE?t=02h34m49s)

[uh that's a good question one second and](https://youtu.be/HxupjQwU9GE?t=02h34m52s)

[I will pull up perfmon and we can find](https://youtu.be/HxupjQwU9GE?t=02h34m54s)

[out](https://youtu.be/HxupjQwU9GE?t=02h34m57s)

[um](https://youtu.be/HxupjQwU9GE?t=02h35m01s)

[okay you just have to promise to not](https://youtu.be/HxupjQwU9GE?t=02h35m04s)

[make fun of my system](https://youtu.be/HxupjQwU9GE?t=02h35m06s)

[okay so we'll do](https://youtu.be/HxupjQwU9GE?t=02h35m10s)

[we'll do that so that's up and now if we](https://youtu.be/HxupjQwU9GE?t=02h35m13s)

[do](https://youtu.be/HxupjQwU9GE?t=02h35m17s)

[a new test that](https://youtu.be/HxupjQwU9GE?t=02h35m18s)

[starts swarming](https://youtu.be/HxupjQwU9GE?t=02h35m21s)

[now we have both of those](https://youtu.be/HxupjQwU9GE?t=02h35m23s)

[okay](https://youtu.be/HxupjQwU9GE?t=02h35m27s)

[my system always died before the server](https://youtu.be/HxupjQwU9GE?t=02h35m31s)

[reached any load](https://youtu.be/HxupjQwU9GE?t=02h35m33s)

[well here in a minute I'm going to push](https://youtu.be/HxupjQwU9GE?t=02h35m36s)

[it to kubernetes and then we'll because](https://youtu.be/HxupjQwU9GE?t=02h35m37s)

[right now I'm pounding on it while it's](https://youtu.be/HxupjQwU9GE?t=02h35m39s)

[debugging in Visual Studio which that's](https://youtu.be/HxupjQwU9GE?t=02h35m41s)

[that's only going to be uh mildly bad uh](https://youtu.be/HxupjQwU9GE?t=02h35m44s)

[so let's see should be near the top](https://youtu.be/HxupjQwU9GE?t=02h35m49s)

[let's put it this way visual studio and](https://youtu.be/HxupjQwU9GE?t=02h35m53s)

[OBS are both out running it](https://youtu.be/HxupjQwU9GE?t=02h35m55s)

[in terms of load so uh](https://youtu.be/HxupjQwU9GE?t=02h35m58s)

[yeah where is it](https://youtu.be/HxupjQwU9GE?t=02h36m02s)

[there's the there's the app itself](https://youtu.be/HxupjQwU9GE?t=02h36m07s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h36m11s)

[uh okay sort](https://youtu.be/HxupjQwU9GE?t=02h36m15s)

[also look at the kernel time in the CPU](https://youtu.be/HxupjQwU9GE?t=02h36m17s)

[graph](https://youtu.be/HxupjQwU9GE?t=02h36m19s)

[okay uh uh I am curious](https://youtu.be/HxupjQwU9GE?t=02h36m24s)

[sort that this way](https://youtu.be/HxupjQwU9GE?t=02h36m29s)

[um](https://youtu.be/HxupjQwU9GE?t=02h36m32s)

[okay so it's going to show up as python](https://youtu.be/HxupjQwU9GE?t=02h36m32s)

[so I actually I almost want to just what](https://youtu.be/HxupjQwU9GE?t=02h36m34s)

[is what is the operation there's a way](https://youtu.be/HxupjQwU9GE?t=02h36m37s)

[to](https://youtu.be/HxupjQwU9GE?t=02h36m39s)

[trying to remember what the way is to do](https://youtu.be/HxupjQwU9GE?t=02h36m41s)

[it to to oh you got to check it up here](https://youtu.be/HxupjQwU9GE?t=02h36m42s)

[that's right](https://youtu.be/HxupjQwU9GE?t=02h36m45s)

[to filter down to just that one process](https://youtu.be/HxupjQwU9GE?t=02h36m46s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h36m48s)

[obs python](https://youtu.be/HxupjQwU9GE?t=02h36m51s)

[you](https://youtu.be/HxupjQwU9GE?t=02h36m55s)

[okay](https://youtu.be/HxupjQwU9GE?t=02h36m56s)

[that's that's really all I care about is](https://youtu.be/HxupjQwU9GE?t=02h36m58s)

[how](https://youtu.be/HxupjQwU9GE?t=02h37m00s)

[much you're going and then to do](https://youtu.be/HxupjQwU9GE?t=02h37m01s)

[sorry kernel time in the CPU graph](https://youtu.be/HxupjQwU9GE?t=02h37m05s)

[service](https://youtu.be/HxupjQwU9GE?t=02h37m10s)

[CPU](https://youtu.be/HxupjQwU9GE?t=02h37m14s)

[uh where is my](https://youtu.be/HxupjQwU9GE?t=02h37m18s)

[trying to remember how to get to it](https://youtu.be/HxupjQwU9GE?t=02h37m24s)

[not sure if it's visible in this](https://youtu.be/HxupjQwU9GE?t=02h37m33s)

[resource manager yeah I don't recall](https://youtu.be/HxupjQwU9GE?t=02h37m35s)

[I don't recall](https://youtu.be/HxupjQwU9GE?t=02h37m40s)

[though at least from what](https://youtu.be/HxupjQwU9GE?t=02h37m45s)

[this is mildly reporting this python](https://youtu.be/HxupjQwU9GE?t=02h37m48s)

[process is not working my system at all](https://youtu.be/HxupjQwU9GE?t=02h37m51s)

[which](https://youtu.be/HxupjQwU9GE?t=02h37m57s)

[points awarded points awarded locusts](https://youtu.be/HxupjQwU9GE?t=02h38m00s)

[the like that is that is going well so](https://youtu.be/HxupjQwU9GE?t=02h38m02s)

[if I load this](https://youtu.be/HxupjQwU9GE?t=02h38m08s)

[what's interesting to me is I sort of](https://youtu.be/HxupjQwU9GE?t=02h38m11s)

[expected it to](https://youtu.be/HxupjQwU9GE?t=02h38m13s)

[trigger more votes because I have some](https://youtu.be/HxupjQwU9GE?t=02h38m17s)

[people hitting the slash one endpoint](https://youtu.be/HxupjQwU9GE?t=02h38m19s)

[and some not and I kind of want to fix](https://youtu.be/HxupjQwU9GE?t=02h38m27s)

[that end point](https://youtu.be/HxupjQwU9GE?t=02h38m31s)

[uh to figure out why it's not going](https://youtu.be/HxupjQwU9GE?t=02h38m34s)

[uh let's see pull dot razor](https://youtu.be/HxupjQwU9GE?t=02h38m38s)

[because it's basically that](https://youtu.be/HxupjQwU9GE?t=02h38m41s)

[so it's hitting](https://youtu.be/HxupjQwU9GE?t=02h38m46s)

[um](https://youtu.be/HxupjQwU9GE?t=02h38m50s)

[whole ID voted](https://youtu.be/HxupjQwU9GE?t=02h38m54s)

[voted is already true](https://youtu.be/HxupjQwU9GE?t=02h38m57s)

[oh so it may](https://youtu.be/HxupjQwU9GE?t=02h39m00s)

[uh yeah that that could be it may be](https://youtu.be/HxupjQwU9GE?t=02h39m05s)

[keeping the same one](https://youtu.be/HxupjQwU9GE?t=02h39m09s)

[um so here's the simple way to do this](https://youtu.be/HxupjQwU9GE?t=02h39m17s)

[like](https://youtu.be/HxupjQwU9GE?t=02h39m22s)

[we come down here](https://youtu.be/HxupjQwU9GE?t=02h39m23s)

[and we just don't uh we just don't care](https://youtu.be/HxupjQwU9GE?t=02h39m25s)

[if somebody's already voted](https://youtu.be/HxupjQwU9GE?t=02h39m29s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h39m31s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h39m35s)

[so we go](https://youtu.be/HxupjQwU9GE?t=02h39m36s)

[I don't care](https://youtu.be/HxupjQwU9GE?t=02h39m40s)

[and then and then the pr and then the](https://youtu.be/HxupjQwU9GE?t=02h39m43s)

[problem go the problem fixes itself](https://youtu.be/HxupjQwU9GE?t=02h39m44s)

[oh oh that nerd](https://youtu.be/HxupjQwU9GE?t=02h39m52s)

[good to see you again hopefully you had](https://youtu.be/HxupjQwU9GE?t=02h39m54s)

[a good stream](https://youtu.be/HxupjQwU9GE?t=02h39m55s)

[we are performance testing a small](https://youtu.be/HxupjQwU9GE?t=02h39m57s)

[asp.net core app](https://youtu.be/HxupjQwU9GE?t=02h40m00s)

[with uh that's running with Microsoft](https://youtu.be/HxupjQwU9GE?t=02h40m02s)

[Orleans](https://youtu.be/HxupjQwU9GE?t=02h40m06s)

[and huh what's North](https://youtu.be/HxupjQwU9GE?t=02h40m08s)

[uh sorry dot net core app running with](https://youtu.be/HxupjQwU9GE?t=02h40m15s)

[Microsoft Orleans deployed out on](https://youtu.be/HxupjQwU9GE?t=02h40m18s)

[kubernetes and](https://youtu.be/HxupjQwU9GE?t=02h40m19s)

[uh oh options dot get return null](https://youtu.be/HxupjQwU9GE?t=02h40m22s)

[really so results came back with nothing](https://youtu.be/HxupjQwU9GE?t=02h40m26s)

[huh okay](https://youtu.be/HxupjQwU9GE?t=02h40m29s)

[um](https://youtu.be/HxupjQwU9GE?t=02h40m32s)

[oh because that vote ID or that vote](https://youtu.be/HxupjQwU9GE?t=02h40m34s)

[doesn't exist so we'll just no check it](https://youtu.be/HxupjQwU9GE?t=02h40m37s)

[there that'll work](https://youtu.be/HxupjQwU9GE?t=02h40m39s)

[so](https://youtu.be/HxupjQwU9GE?t=02h40m41s)

[that nerd always signing off when I'm](https://youtu.be/HxupjQwU9GE?t=02h40m45s)

[AFA okay](https://youtu.be/HxupjQwU9GE?t=02h40m47s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h40m49s)

[yeah](https://youtu.be/HxupjQwU9GE?t=02h40m52s)

[kubernetes and asp.net core yeah](https://youtu.be/HxupjQwU9GE?t=02h40m54s)

[so and I will say this is not this is](https://youtu.be/HxupjQwU9GE?t=02h40m57s)

[not my uh usual Forte but I've been](https://youtu.be/HxupjQwU9GE?t=02h41m00s)

[inspired with Microsoft Orleans to play](https://youtu.be/HxupjQwU9GE?t=02h41m04s)

[around with it so for anybody](https://youtu.be/HxupjQwU9GE?t=02h41m08s)

[or anybody interested here is the](https://youtu.be/HxupjQwU9GE?t=02h41m10s)

[here's the little bit on here it](https://youtu.be/HxupjQwU9GE?t=02h41m14s)

[and I will say I'm new to it but I I got](https://youtu.be/HxupjQwU9GE?t=02h41m17s)

[very excited by looking at some demos of](https://youtu.be/HxupjQwU9GE?t=02h41m20s)

[it of distributed computing](https://youtu.be/HxupjQwU9GE?t=02h41m22s)

[Made Easy the the Made Easy is to you](https://youtu.be/HxupjQwU9GE?t=02h41m25s)

[know to be determined but I then had a](https://youtu.be/HxupjQwU9GE?t=02h41m29s)

[quest to try to figure out okay](https://youtu.be/HxupjQwU9GE?t=02h41m32s)

[if I can do this distributed computing](https://youtu.be/HxupjQwU9GE?t=02h41m35s)

[stuff how cheaply can I get away with it](https://youtu.be/HxupjQwU9GE?t=02h41m37s)

[oh look at this result options okay okay](https://youtu.be/HxupjQwU9GE?t=02h41m40s)

[okay Locus you need to stop you are](https://youtu.be/HxupjQwU9GE?t=02h41m44s)

[making my life miserable stop it stop it](https://youtu.be/HxupjQwU9GE?t=02h41m46s)

[stop it stop it stop it](https://youtu.be/HxupjQwU9GE?t=02h41m49s)

[um](https://youtu.be/HxupjQwU9GE?t=02h41m51s)

[so I went through and so Orleans Powers](https://youtu.be/HxupjQwU9GE?t=02h41m54s)

[a lot of fairly big systems like Xbox so](https://youtu.be/HxupjQwU9GE?t=02h41m58s)

[they can handle quite a bit of load](https://youtu.be/HxupjQwU9GE?t=02h42m02s)

[um and](https://youtu.be/HxupjQwU9GE?t=02h42m05s)

[so I was I'm curious so I know it's](https://youtu.be/HxupjQwU9GE?t=02h42m08s)

[capable of handling an insane level of](https://youtu.be/HxupjQwU9GE?t=02h42m11s)

[load but I'm curious how much load it](https://youtu.be/HxupjQwU9GE?t=02h42m13s)

[can handle uh on somebody working on a](https://youtu.be/HxupjQwU9GE?t=02h42m15s)

[budget basically let's let's say it that](https://youtu.be/HxupjQwU9GE?t=02h42m18s)

[way that's probably the better way of](https://youtu.be/HxupjQwU9GE?t=02h42m20s)

[phrasing it so I'm testing this locally](https://youtu.be/HxupjQwU9GE?t=02h42m21s)

[for the moment but here in a moment](https://youtu.be/HxupjQwU9GE?t=02h42m25s)

[we're going to kick this thing up to my](https://youtu.be/HxupjQwU9GE?t=02h42m27s)

[cluster that I will say is a tiny](https://youtu.be/HxupjQwU9GE?t=02h42m29s)

[cluster](https://youtu.be/HxupjQwU9GE?t=02h42m32s)

[and then](https://youtu.be/HxupjQwU9GE?t=02h42m33s)

[we'll see how it goes](https://youtu.be/HxupjQwU9GE?t=02h42m35s)

[yeah how much load can free tier handle](https://youtu.be/HxupjQwU9GE?t=02h42m36s)

[that's sort of what we're doing](https://youtu.be/HxupjQwU9GE?t=02h42m39s)

[okay](https://youtu.be/HxupjQwU9GE?t=02h42m41s)

[so good news my code now works we found](https://youtu.be/HxupjQwU9GE?t=02h42m43s)

[the obnoxious methods in their demo that](https://youtu.be/HxupjQwU9GE?t=02h42m45s)

[were throttling it](https://youtu.be/HxupjQwU9GE?t=02h42m48s)

[and](https://youtu.be/HxupjQwU9GE?t=02h42m49s)

[now we're going to see how this goes so](https://youtu.be/HxupjQwU9GE?t=02h42m51s)

[now now it should be counting](https://youtu.be/HxupjQwU9GE?t=02h42m53s)

[for what it's worth and okay good enough](https://youtu.be/HxupjQwU9GE?t=02h42m56s)

[yep good enough good enough ship ship](https://youtu.be/HxupjQwU9GE?t=02h42m59s)

[ship ship ship okay uh you stop you go](https://youtu.be/HxupjQwU9GE?t=02h43m02s)

[here Docker build](https://youtu.be/HxupjQwU9GE?t=02h43m06s)

[uh uh what is your problem Oh ACR login](https://youtu.be/HxupjQwU9GE?t=02h43m09s)

[server is not a defined variable](https://youtu.be/HxupjQwU9GE?t=02h43m13s)

[uh I don't feel like thinking too hard](https://youtu.be/HxupjQwU9GE?t=02h43m16s)

[so I'm just gonna go pull it up](https://youtu.be/HxupjQwU9GE?t=02h43m18s)

[uh](https://youtu.be/HxupjQwU9GE?t=02h43m23s)

[that's so cool](https://youtu.be/HxupjQwU9GE?t=02h43m27s)

[uh uh only obnoxious Edge case](https://youtu.be/HxupjQwU9GE?t=02h43m29s)

[sorry I'm not used to this many Chatters](https://youtu.be/HxupjQwU9GE?t=02h43m33s)

[welcome everyone it's great it is great](https://youtu.be/HxupjQwU9GE?t=02h43m35s)

[um](https://youtu.be/HxupjQwU9GE?t=02h43m39s)

[let's go and we're](https://youtu.be/HxupjQwU9GE?t=02h43m40s)

