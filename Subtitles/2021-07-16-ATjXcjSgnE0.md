[YouTube Video](https://youtu.be/ATjXcjSgnE0)



[hello everyone welcome back](https://youtu.be/ATjXcjSgnE0?t=00h00m03s)

[uh we are going to continue on with what](https://youtu.be/ATjXcjSgnE0?t=00h00m05s)

[we did last time with uh material design](https://youtu.be/ATjXcjSgnE0?t=00h00m08s)

[and xaml i'm figuring more bug bashing](https://youtu.be/ATjXcjSgnE0?t=00h00m10s)

[tonight](https://youtu.be/ATjXcjSgnE0?t=00h00m12s)

[and uh see how far along we can get](https://youtu.be/ATjXcjSgnE0?t=00h00m13s)

[there is one other thing](https://youtu.be/ATjXcjSgnE0?t=00h00m15s)

[uh one of the uh i'll say past](https://youtu.be/ATjXcjSgnE0?t=00h00m17s)

[contributors who's done a bunch of work](https://youtu.be/ATjXcjSgnE0?t=00h00m20s)

[on the library has a new pr](https://youtu.be/ATjXcjSgnE0?t=00h00m22s)

[open um specifically for enhancing the](https://youtu.be/ATjXcjSgnE0?t=00h00m23s)

[demo application so i figured i would](https://youtu.be/ATjXcjSgnE0?t=00h00m26s)

[start there uh and see the the](https://youtu.be/ATjXcjSgnE0?t=00h00m28s)

[screenshots that he's posted of it](https://youtu.be/ATjXcjSgnE0?t=00h00m31s)

[looked pretty cool](https://youtu.be/ATjXcjSgnE0?t=00h00m32s)

[so i figured we would take a look at](https://youtu.be/ATjXcjSgnE0?t=00h00m33s)

[that get it merged and then i want to](https://youtu.be/ATjXcjSgnE0?t=00h00m34s)

[continue](https://youtu.be/ATjXcjSgnE0?t=00h00m36s)

[hacking away on some of the bugs for the](https://youtu.be/ATjXcjSgnE0?t=00h00m37s)

[current milestone just to try and get](https://youtu.be/ATjXcjSgnE0?t=00h00m38s)

[those things done and out the door so](https://youtu.be/ATjXcjSgnE0?t=00h00m41s)

[let's take a look](https://youtu.be/ATjXcjSgnE0?t=00h00m43s)

[poof so for anybody who is playing along](https://youtu.be/ATjXcjSgnE0?t=00h00m46s)

[at home](https://youtu.be/ATjXcjSgnE0?t=00h00m49s)

[uh the material design repository](https://youtu.be/ATjXcjSgnE0?t=00h00m51s)

[and then so this guy here there's](https://youtu.be/ATjXcjSgnE0?t=00h00m55s)

[um a couple things kind of being bundled](https://youtu.be/ATjXcjSgnE0?t=00h00m59s)

[into here and i haven't spent much time](https://youtu.be/ATjXcjSgnE0?t=00h01m01s)

[looking at it i gave it a cursory glance](https://youtu.be/ATjXcjSgnE0?t=00h01m03s)

[a little bit earlier today and said](https://youtu.be/ATjXcjSgnE0?t=00h01m05s)

[that's cool and then moved right along](https://youtu.be/ATjXcjSgnE0?t=00h01m07s)

[so it's kind of cool the the layout here](https://youtu.be/ATjXcjSgnE0?t=00h01m09s)

[there's a bit of a theme picker i'm](https://youtu.be/ATjXcjSgnE0?t=00h01m12s)

[almost](https://youtu.be/ATjXcjSgnE0?t=00h01m14s)

[we'll get into my thoughts on it i'll](https://youtu.be/ATjXcjSgnE0?t=00h01m15s)

[get into my thoughts on it in just a](https://youtu.be/ATjXcjSgnE0?t=00h01m17s)

[minute](https://youtu.be/ATjXcjSgnE0?t=00h01m18s)

[um but there's a a couple changes here](https://youtu.be/ATjXcjSgnE0?t=00h01m19s)

[so this is the demo app so don't care](https://youtu.be/ATjXcjSgnE0?t=00h01m24s)

[the more interesting one is this guy](https://youtu.be/ATjXcjSgnE0?t=00h01m27s)

[here so this](https://youtu.be/ATjXcjSgnE0?t=00h01m29s)

[is actually doing a a rename of the](https://youtu.be/ATjXcjSgnE0?t=00h01m30s)

[of the brush and i think what i want to](https://youtu.be/ATjXcjSgnE0?t=00h01m35s)

[do](https://youtu.be/ATjXcjSgnE0?t=00h01m38s)

[i think what i want to do is actually](https://youtu.be/ATjXcjSgnE0?t=00h01m41s)

[propose that we](https://youtu.be/ATjXcjSgnE0?t=00h01m43s)

[so let's start with this um can we](https://youtu.be/ATjXcjSgnE0?t=00h01m45s)

[put back um this style](https://youtu.be/ATjXcjSgnE0?t=00h01m50s)

[uh how about we do it this way just to](https://youtu.be/ATjXcjSgnE0?t=00h01m56s)

[avoid breaking](https://youtu.be/ATjXcjSgnE0?t=00h01m59s)

[backwards compatibility](https://youtu.be/ATjXcjSgnE0?t=00h02m03s)

[can we put back the](https://youtu.be/ATjXcjSgnE0?t=00h02m06s)

[old style key as well](https://youtu.be/ATjXcjSgnE0?t=00h02m09s)

[and i will flag it to be](https://youtu.be/ATjXcjSgnE0?t=00h02m14s)

[removed in the 5.0 release](https://youtu.be/ATjXcjSgnE0?t=00h02m18s)

[just because it uh my next release is](https://youtu.be/ATjXcjSgnE0?t=00h02m22s)

[going to be an](https://youtu.be/ATjXcjSgnE0?t=00h02m25s)

[um a minor revision not a major revision](https://youtu.be/ATjXcjSgnE0?t=00h02m26s)

[and deleting a style](https://youtu.be/ATjXcjSgnE0?t=00h02m29s)

[is definitely a breaking a breaking](https://youtu.be/ATjXcjSgnE0?t=00h02m30s)

[change](https://youtu.be/ATjXcjSgnE0?t=00h02m33s)

[so and then just to be clear what i am](https://youtu.be/ATjXcjSgnE0?t=00h02m34s)

[proposing](https://youtu.be/ATjXcjSgnE0?t=00h02m36s)

[because sometimes pictures worth a](https://youtu.be/ATjXcjSgnE0?t=00h02m37s)

[thousand words](https://youtu.be/ATjXcjSgnE0?t=00h02m39s)

[we're gonna suggest that we put](https://youtu.be/ATjXcjSgnE0?t=00h02m40s)

[this guy back in but we're actually](https://youtu.be/ATjXcjSgnE0?t=00h02m44s)

[going to](https://youtu.be/ATjXcjSgnE0?t=00h02m47s)

[base it on this and just be done](https://youtu.be/ATjXcjSgnE0?t=00h02m49s)

[so i'll start a review](https://youtu.be/ATjXcjSgnE0?t=00h02m55s)

[so this will leave oh hang on that](https://youtu.be/ATjXcjSgnE0?t=00h02m59s)

[didn't indent very nicely](https://youtu.be/ATjXcjSgnE0?t=00h03m01s)

[let's put the same indent i when i put](https://youtu.be/ATjXcjSgnE0?t=00h03m04s)

[in suggestions i try to make them](https://youtu.be/ATjXcjSgnE0?t=00h03m06s)

[such that um the author can just hit the](https://youtu.be/ATjXcjSgnE0?t=00h03m08s)

[accept and be done with it](https://youtu.be/ATjXcjSgnE0?t=00h03m11s)

[so that's pretty cool um material design](https://youtu.be/ATjXcjSgnE0?t=00h03m12s)

[raise secondary light button](https://youtu.be/ATjXcjSgnE0?t=00h03m15s)

[so let's see secondary light](https://youtu.be/ATjXcjSgnE0?t=00h03m17s)

[raised accent button oh hang on](https://youtu.be/ATjXcjSgnE0?t=00h03m22s)

[is that the exact](https://youtu.be/ATjXcjSgnE0?t=00h03m27s)

[to design raised accent button there's](https://youtu.be/ATjXcjSgnE0?t=00h03m33s)

[the accent button oh it's already there](https://youtu.be/ATjXcjSgnE0?t=00h03m35s)

[my comment is meaningless so we are](https://youtu.be/ATjXcjSgnE0?t=00h03m38s)

[going to delete that](https://youtu.be/ATjXcjSgnE0?t=00h03m40s)

[because there it is right there and it](https://youtu.be/ATjXcjSgnE0?t=00h03m42s)

[looks pretty much identical to what i](https://youtu.be/ATjXcjSgnE0?t=00h03m44s)

[would expect that's perfect](https://youtu.be/ATjXcjSgnE0?t=00h03m45s)

[um](https://youtu.be/ATjXcjSgnE0?t=00h03m47s)

[so i just want to make sure on all these](https://youtu.be/ATjXcjSgnE0?t=00h03m53s)

[ones that are deleted that](https://youtu.be/ATjXcjSgnE0?t=00h03m55s)

[it's only showing a deletion because](https://youtu.be/ATjXcjSgnE0?t=00h03m56s)

[they got moved yeah so that one just got](https://youtu.be/ATjXcjSgnE0?t=00h03m58s)

[moved let's check this one](https://youtu.be/ATjXcjSgnE0?t=00h04m00s)

[make that a little bigger for everybody](https://youtu.be/ATjXcjSgnE0?t=00h04m03s)

[so there's that one there](https://youtu.be/ATjXcjSgnE0?t=00h04m05s)

[so cool so so no styles are actually](https://youtu.be/ATjXcjSgnE0?t=00h04m07s)

[being removed they just kind of got](https://youtu.be/ATjXcjSgnE0?t=00h04m09s)

[reorganized which is fine](https://youtu.be/ATjXcjSgnE0?t=00h04m10s)

[that is perfect](https://youtu.be/ATjXcjSgnE0?t=00h04m13s)

[um i think what i'm going to do though](https://youtu.be/ATjXcjSgnE0?t=00h04m16s)

[is um](https://youtu.be/ATjXcjSgnE0?t=00h04m20s)

[thanks for keeping the old](https://youtu.be/ATjXcjSgnE0?t=00h04m24s)

[keys in there](https://youtu.be/ATjXcjSgnE0?t=00h04m28s)

[going to flag these for removal](https://youtu.be/ATjXcjSgnE0?t=00h04m31s)

[in the release](https://youtu.be/ATjXcjSgnE0?t=00h04m35s)

[uh spell check or fail](https://youtu.be/ATjXcjSgnE0?t=00h04m44s)

[okay we'll leave that in there](https://youtu.be/ATjXcjSgnE0?t=00h04m47s)

[it's not really a comment of things to](https://youtu.be/ATjXcjSgnE0?t=00h04m50s)

[fix](https://youtu.be/ATjXcjSgnE0?t=00h04m52s)

[[Music]](https://youtu.be/ATjXcjSgnE0?t=00h04m56s)

[so this is really just building out all](https://youtu.be/ATjXcjSgnE0?t=00h04m59s)

[of the ones](https://youtu.be/ATjXcjSgnE0?t=00h05m01s)

[there so this is something that i've](https://youtu.be/ATjXcjSgnE0?t=00h05m05s)

[been considering and i don't think i'm](https://youtu.be/ATjXcjSgnE0?t=00h05m07s)

[to change it here this is perfectly fine](https://youtu.be/ATjXcjSgnE0?t=00h05m09s)

[this matches the naming scheme](https://youtu.be/ATjXcjSgnE0?t=00h05m10s)

[but something for the 5.0 release that](https://youtu.be/ATjXcjSgnE0?t=00h05m12s)

[i've been](https://youtu.be/ATjXcjSgnE0?t=00h05m15s)

[wanting to consider is a a slightly](https://youtu.be/ATjXcjSgnE0?t=00h05m16s)

[different naming scheme](https://youtu.be/ATjXcjSgnE0?t=00h05m18s)

[to all of these things for example right](https://youtu.be/ATjXcjSgnE0?t=00h05m19s)

[now](https://youtu.be/ATjXcjSgnE0?t=00h05m22s)

[all of the styles start with material](https://youtu.be/ATjXcjSgnE0?t=00h05m23s)

[design and then there's not necessarily](https://youtu.be/ATjXcjSgnE0?t=00h05m25s)

[a](https://youtu.be/ATjXcjSgnE0?t=00h05m28s)

[very um prescriptive or intuitive naming](https://youtu.be/ATjXcjSgnE0?t=00h05m29s)

[scheme for everything else after this](https://youtu.be/ATjXcjSgnE0?t=00h05m32s)

[i'm sort of envisioning something akin](https://youtu.be/ATjXcjSgnE0?t=00h05m34s)

[to ma apps where it's very clear what](https://youtu.be/ATjXcjSgnE0?t=00h05m37s)

[the naming scheme is](https://youtu.be/ATjXcjSgnE0?t=00h05m39s)

[that way it's a little bit easier for](https://youtu.be/ATjXcjSgnE0?t=00h05m40s)

[discovery as well when people](https://youtu.be/ATjXcjSgnE0?t=00h05m42s)

[want to find out hey what are all of the](https://youtu.be/ATjXcjSgnE0?t=00h05m44s)

[button styles that you have right](https://youtu.be/ATjXcjSgnE0?t=00h05m46s)

[you material design dot and again](https://youtu.be/ATjXcjSgnE0?t=00h05m48s)

[spitball on this](https://youtu.be/ATjXcjSgnE0?t=00h05m51s)

[don't know for sure material design dot](https://youtu.be/ATjXcjSgnE0?t=00h05m52s)

[control name dot](https://youtu.be/ATjXcjSgnE0?t=00h05m55s)

[control name or something something to](https://youtu.be/ATjXcjSgnE0?t=00h05m56s)

[that effect such that they are](https://youtu.be/ATjXcjSgnE0?t=00h05m58s)

[um a little bit more easier to to find](https://youtu.be/ATjXcjSgnE0?t=00h06m01s)

[rather than just typing them](https://youtu.be/ATjXcjSgnE0?t=00h06m04s)

[in intellisense goes a long way to kind](https://youtu.be/ATjXcjSgnE0?t=00h06m06s)

[of mitigate this because you](https://youtu.be/ATjXcjSgnE0?t=00h06m08s)

[you know just do your static resource](https://youtu.be/ATjXcjSgnE0?t=00h06m09s)

[type in the word button and find all the](https://youtu.be/ATjXcjSgnE0?t=00h06m11s)

[things that button in the name](https://youtu.be/ATjXcjSgnE0?t=00h06m13s)

[okay not great right if there was a](https://youtu.be/ATjXcjSgnE0?t=00h06m15s)

[little bit more organization](https://youtu.be/ATjXcjSgnE0?t=00h06m18s)

[to it now obviously that's going to](https://youtu.be/ATjXcjSgnE0?t=00h06m20s)

[change all the keys](https://youtu.be/ATjXcjSgnE0?t=00h06m22s)

[of all the styles and be a major](https://youtu.be/ATjXcjSgnE0?t=00h06m23s)

[breaking change](https://youtu.be/ATjXcjSgnE0?t=00h06m25s)

[and before doing that i kind of want to](https://youtu.be/ATjXcjSgnE0?t=00h06m27s)

[kind of want to offer people an option](https://youtu.be/ATjXcjSgnE0?t=00h06m32s)

[and if i go through and do that](https://youtu.be/ATjXcjSgnE0?t=00h06m33s)

[i might offer a um](https://youtu.be/ATjXcjSgnE0?t=00h06m35s)

[a resource dictionary uh not necessarily](https://youtu.be/ATjXcjSgnE0?t=00h06m38s)

[distributed with the nuget package](https://youtu.be/ATjXcjSgnE0?t=00h06m40s)

[but just as a shim that people could um](https://youtu.be/ATjXcjSgnE0?t=00h06m42s)

[choose to incorporate so that way if you](https://youtu.be/ATjXcjSgnE0?t=00h06m45s)

[want to](https://youtu.be/ATjXcjSgnE0?t=00h06m48s)

[pull that into your package so that you](https://youtu.be/ATjXcjSgnE0?t=00h06m50s)

[could just get up and running quick with](https://youtu.be/ATjXcjSgnE0?t=00h06m52s)

[the latest 5.0 release without needing](https://youtu.be/ATjXcjSgnE0?t=00h06m54s)

[to worry about those braking changes](https://youtu.be/ATjXcjSgnE0?t=00h06m56s)

[and have a shim that just kind of](https://youtu.be/ATjXcjSgnE0?t=00h06m57s)

[forwards everything appropriately](https://youtu.be/ATjXcjSgnE0?t=00h06m59s)

[that would be one option](https://youtu.be/ATjXcjSgnE0?t=00h07m01s)

[i think that would be a nice touch](https://youtu.be/ATjXcjSgnE0?t=00h07m07s)

[okay so the what this paper button](https://youtu.be/ATjXcjSgnE0?t=00h07m16s)

[so the fact that the cursor is being set](https://youtu.be/ATjXcjSgnE0?t=00h07m21s)

[is a little interesting to me](https://youtu.be/ATjXcjSgnE0?t=00h07m23s)

[i'm gonna just do that as a note to come](https://youtu.be/ATjXcjSgnE0?t=00h07m25s)

[back and look at it](https://youtu.be/ATjXcjSgnE0?t=00h07m27s)

[um](https://youtu.be/ATjXcjSgnE0?t=00h07m29s)

[[Music]](https://youtu.be/ATjXcjSgnE0?t=00h07m29s)

[all of those look fine the only reason i](https://youtu.be/ATjXcjSgnE0?t=00h07m33s)

[say cursor is interesting is usually](https://youtu.be/ATjXcjSgnE0?t=00h07m36s)

[it's best](https://youtu.be/ATjXcjSgnE0?t=00h07m38s)

[this is one of those things that within](https://youtu.be/ATjXcjSgnE0?t=00h07m39s)

[the theming library](https://youtu.be/ATjXcjSgnE0?t=00h07m40s)

[in many cases setting the cursor is](https://youtu.be/ATjXcjSgnE0?t=00h07m44s)

[unexpected behavior](https://youtu.be/ATjXcjSgnE0?t=00h07m46s)

[typically people expect that to follow](https://youtu.be/ATjXcjSgnE0?t=00h07m48s)

[whatever they've said in their app and](https://youtu.be/ATjXcjSgnE0?t=00h07m53s)

[so my](https://youtu.be/ATjXcjSgnE0?t=00h07m55s)

[usual principle has been the library](https://youtu.be/ATjXcjSgnE0?t=00h07m56s)

[should be hands off and say](https://youtu.be/ATjXcjSgnE0?t=00h07m59s)

[cursors curse is not our domain have at](https://youtu.be/ATjXcjSgnE0?t=00h08m01s)

[it](https://youtu.be/ATjXcjSgnE0?t=00h08m03s)

[um](https://youtu.be/ATjXcjSgnE0?t=00h08m04s)

[i think these ones here oh it didn't](https://youtu.be/ATjXcjSgnE0?t=00h08m11s)

[grab the i got to select it by like this](https://youtu.be/ATjXcjSgnE0?t=00h08m13s)

[way](https://youtu.be/ATjXcjSgnE0?t=00h08m16s)

[this one's a sl uh let's see text](https://youtu.be/ATjXcjSgnE0?t=00h08m16s)

[element so the only the only](https://youtu.be/ATjXcjSgnE0?t=00h08m21s)

[very subtle difference here](https://youtu.be/ATjXcjSgnE0?t=00h08m24s)

[is this is using the](https://youtu.be/ATjXcjSgnE0?t=00h08m28s)

[[Music]](https://youtu.be/ATjXcjSgnE0?t=00h08m29s)

[the base type rather than the drive type](https://youtu.be/ATjXcjSgnE0?t=00h08m31s)

[so we can look at that here in the code](https://youtu.be/ATjXcjSgnE0?t=00h08m34s)

[here in just a second](https://youtu.be/ATjXcjSgnE0?t=00h08m36s)

[i'm just gonna go through and check some](https://youtu.be/ATjXcjSgnE0?t=00h08m38s)

[of these things out](https://youtu.be/ATjXcjSgnE0?t=00h08m40s)

[this is also one thing that i've wanted](https://youtu.be/ATjXcjSgnE0?t=00h08m43s)

[to standardize on is](https://youtu.be/ATjXcjSgnE0?t=00h08m45s)

[um because the library uses multiple](https://youtu.be/ATjXcjSgnE0?t=00h08m47s)

[methods for specifying thicknesses](https://youtu.be/ATjXcjSgnE0?t=00h08m51s)

[whether they be spaces or commas i'm a](https://youtu.be/ATjXcjSgnE0?t=00h08m53s)

[comma guy myself](https://youtu.be/ATjXcjSgnE0?t=00h08m56s)

[the original author of this library is a](https://youtu.be/ATjXcjSgnE0?t=00h08m57s)

[space guy](https://youtu.be/ATjXcjSgnE0?t=00h08m59s)

[to each his own i just feel like the](https://youtu.be/ATjXcjSgnE0?t=00h09m02s)

[library should have one and stick with](https://youtu.be/ATjXcjSgnE0?t=00h09m04s)

[it](https://youtu.be/ATjXcjSgnE0?t=00h09m05s)

[i i would be willing to change my](https://youtu.be/ATjXcjSgnE0?t=00h09m07s)

[preferences in exchange for the library](https://youtu.be/ATjXcjSgnE0?t=00h09m09s)

[to be consistent](https://youtu.be/ATjXcjSgnE0?t=00h09m10s)

[really what that comes down to is](https://youtu.be/ATjXcjSgnE0?t=00h09m12s)

[there's some xaml formatter extensions](https://youtu.be/ATjXcjSgnE0?t=00h09m14s)

[we can pull in](https://youtu.be/ATjXcjSgnE0?t=00h09m16s)

[that will ensure that like for example](https://youtu.be/ATjXcjSgnE0?t=00h09m17s)

[all your xaml elements](https://youtu.be/ATjXcjSgnE0?t=00h09m20s)

[are properly indented everything is um](https://youtu.be/ATjXcjSgnE0?t=00h09m21s)

[like attribute aligned and whatnot so](https://youtu.be/ATjXcjSgnE0?t=00h09m25s)

[little things like that just to make it](https://youtu.be/ATjXcjSgnE0?t=00h09m28s)

[a little bit nicer](https://youtu.be/ATjXcjSgnE0?t=00h09m30s)

[and i think that would be a worthwhile a](https://youtu.be/ATjXcjSgnE0?t=00h09m33s)

[worthwhile investment](https://youtu.be/ATjXcjSgnE0?t=00h09m35s)

[okay so](https://youtu.be/ATjXcjSgnE0?t=00h09m39s)

[it's pretty simple](https://youtu.be/ATjXcjSgnE0?t=00h09m42s)

[so i want to look up um](https://youtu.be/ATjXcjSgnE0?t=00h09m49s)

[uh i've been using the material design](https://youtu.be/ATjXcjSgnE0?t=00h09m53s)

[icons for a ton of stuff](https://youtu.be/ATjXcjSgnE0?t=00h09m57s)

[but what i want to do here is look](https://youtu.be/ATjXcjSgnE0?t=00h09m59s)

[specifically at this because](https://youtu.be/ATjXcjSgnE0?t=00h10m01s)

[it's using the name paper button and i'm](https://youtu.be/ATjXcjSgnE0?t=00h10m03s)

[wondering if that's](https://youtu.be/ATjXcjSgnE0?t=00h10m05s)

[i'm wondering if that's the right right](https://youtu.be/ATjXcjSgnE0?t=00h10m12s)

[methodology to it](https://youtu.be/ATjXcjSgnE0?t=00h10m15s)

[i know that that was explicitly called](https://youtu.be/ATjXcjSgnE0?t=00h10m17s)

[out in the description](https://youtu.be/ATjXcjSgnE0?t=00h10m19s)

[so this isn't this isn't bad](https://youtu.be/ATjXcjSgnE0?t=00h10m20s)

[these are all just paper buttons the](https://youtu.be/ATjXcjSgnE0?t=00h10m24s)

[paper button has some beat](https://youtu.be/ATjXcjSgnE0?t=00h10m26s)

[default styles it has](https://youtu.be/ATjXcjSgnE0?t=00h10m27s)

[the the paper and the body brush](https://youtu.be/ATjXcjSgnE0?t=00h10m30s)

[i'm just wondering if there is a](https://youtu.be/ATjXcjSgnE0?t=00h10m38s)

[a better name for this um](https://youtu.be/ATjXcjSgnE0?t=00h10m42s)

[let's see here anatomy](https://youtu.be/ATjXcjSgnE0?t=00h10m47s)

[it does it's not it's not likely to call](https://youtu.be/ATjXcjSgnE0?t=00h10m51s)

[out](https://youtu.be/ATjXcjSgnE0?t=00h10m53s)

[that kind of a thing](https://youtu.be/ATjXcjSgnE0?t=00h10m55s)

[se because all of the](https://youtu.be/ATjXcjSgnE0?t=00h11m00s)

[types of buttons that they call out](https://youtu.be/ATjXcjSgnE0?t=00h11m03s)

[there's the contained button the outline](https://youtu.be/ATjXcjSgnE0?t=00h11m05s)

[button and the text button](https://youtu.be/ATjXcjSgnE0?t=00h11m07s)

[which our names for buttons in this](https://youtu.be/ATjXcjSgnE0?t=00h11m08s)

[library line up with the previous](https://youtu.be/ATjXcjSgnE0?t=00h11m10s)

[version material design not the latest](https://youtu.be/ATjXcjSgnE0?t=00h11m12s)

[and that's something else i'd like to](https://youtu.be/ATjXcjSgnE0?t=00h11m14s)

[change again](https://youtu.be/ATjXcjSgnE0?t=00h11m15s)

[total breaking change for everybody it's](https://youtu.be/ATjXcjSgnE0?t=00h11m17s)

[it's going to be brutal](https://youtu.be/ATjXcjSgnE0?t=00h11m20s)

[but i would like to get this library's](https://youtu.be/ATjXcjSgnE0?t=00h11m22s)

[identifiers in sync with the latest](https://youtu.be/ATjXcjSgnE0?t=00h11m25s)

[material design one](https://youtu.be/ATjXcjSgnE0?t=00h11m27s)

[i think that would make things go a lot](https://youtu.be/ATjXcjSgnE0?t=00h11m32s)

[smoother](https://youtu.be/ATjXcjSgnE0?t=00h11m33s)

[see i don't think this is even gonna](https://youtu.be/ATjXcjSgnE0?t=00h11m40s)

[if i search for paper because i'm pretty](https://youtu.be/ATjXcjSgnE0?t=00h11m47s)

[sure paper is one of those](https://youtu.be/ATjXcjSgnE0?t=00h11m50s)

[um one of those pieces that is](https://youtu.be/ATjXcjSgnE0?t=00h11m54s)

[not uh](https://youtu.be/ATjXcjSgnE0?t=00h12m05s)

[how paper works not something i ever](https://youtu.be/ATjXcjSgnE0?t=00h12m08s)

[thought i would need to have explained](https://youtu.be/ATjXcjSgnE0?t=00h12m11s)

[to me](https://youtu.be/ATjXcjSgnE0?t=00h12m12s)

[uh physical properties opinion](https://youtu.be/ATjXcjSgnE0?t=00h12m13s)

[are not treated as material](https://youtu.be/ATjXcjSgnE0?t=00h12m23s)

[yeah so this is really a color type](https://youtu.be/ATjXcjSgnE0?t=00h12m36s)

[thing for the button](https://youtu.be/ATjXcjSgnE0?t=00h12m38s)

[so it really is a contained button with](https://youtu.be/ATjXcjSgnE0?t=00h12m39s)

[a different color](https://youtu.be/ATjXcjSgnE0?t=00h12m42s)

[and this is why i kind of want to get](https://youtu.be/ATjXcjSgnE0?t=00h12m43s)

[around to having a defined naming scheme](https://youtu.be/ATjXcjSgnE0?t=00h12m45s)

[for the styles this will work](https://youtu.be/ATjXcjSgnE0?t=00h12m48s)

[because this lines up um](https://youtu.be/ATjXcjSgnE0?t=00h12m52s)

[with how the rest of the um](https://youtu.be/ATjXcjSgnE0?t=00h12m58s)

[the rest of the styles are named i just](https://youtu.be/ATjXcjSgnE0?t=00h13m02s)

[don't like it](https://youtu.be/ATjXcjSgnE0?t=00h13m04s)

[okay so let's go](https://youtu.be/ATjXcjSgnE0?t=00h13m05s)

[all my other projects uh okay so i want](https://youtu.be/ATjXcjSgnE0?t=00h13m09s)

[to go](https://youtu.be/ATjXcjSgnE0?t=00h13m12s)

[the pull request show me pull request](https://youtu.be/ATjXcjSgnE0?t=00h13m13s)

[oh yes also case anyone missed it](https://youtu.be/ATjXcjSgnE0?t=00h13m16s)

[version 77 of get kraken has dropped](https://youtu.be/ATjXcjSgnE0?t=00h13m19s)

[so get cracking fans more importantly](https://youtu.be/ATjXcjSgnE0?t=00h13m24s)

[one of the cool new features search pull](https://youtu.be/ATjXcjSgnE0?t=00h13m28s)

[requests](https://youtu.be/ATjXcjSgnE0?t=00h13m30s)

[love it love it love it love it love it](https://youtu.be/ATjXcjSgnE0?t=00h13m32s)

[for example](https://youtu.be/ATjXcjSgnE0?t=00h13m35s)

[boom find the one for the demo app](https://youtu.be/ATjXcjSgnE0?t=00h13m36s)

[no thinking involved no thinking](https://youtu.be/ATjXcjSgnE0?t=00h13m39s)

[involved](https://youtu.be/ATjXcjSgnE0?t=00h13m41s)

[uh let's see add remote and check out](https://youtu.be/ATjXcjSgnE0?t=00h13m42s)

[it's probably going to be let's see rs](https://youtu.be/ATjXcjSgnE0?t=00h13m47s)

[master because i've already got a local](https://youtu.be/ATjXcjSgnE0?t=00h13m51s)

[master branch when i](https://youtu.be/ATjXcjSgnE0?t=00h13m52s)

[check out um the master from his remote](https://youtu.be/ATjXcjSgnE0?t=00h13m54s)

[i need to make sure that i](https://youtu.be/ATjXcjSgnE0?t=00h13m57s)

[give it a different name so it doesn't](https://youtu.be/ATjXcjSgnE0?t=00h13m59s)

[conflict with the master branch that i](https://youtu.be/ATjXcjSgnE0?t=00h14m00s)

[have locally](https://youtu.be/ATjXcjSgnE0?t=00h14m02s)

[but there it is so let's fire this guy](https://youtu.be/ATjXcjSgnE0?t=00h14m04s)

[up and i am interested in taking a look](https://youtu.be/ATjXcjSgnE0?t=00h14m06s)

[at](https://youtu.be/ATjXcjSgnE0?t=00h14m08s)

[because i didn't review the code for the](https://youtu.be/ATjXcjSgnE0?t=00h14m09s)

[demo app per se](https://youtu.be/ATjXcjSgnE0?t=00h14m11s)

[um because this is one of those things](https://youtu.be/ATjXcjSgnE0?t=00h14m13s)

[that's easier to review](https://youtu.be/ATjXcjSgnE0?t=00h14m16s)

[while running it](https://youtu.be/ATjXcjSgnE0?t=00h14m18s)

[there were builders of course there were](https://youtu.be/ATjXcjSgnE0?t=00h14m31s)

[what did i do wrong](https://youtu.be/ATjXcjSgnE0?t=00h14m33s)

[um](https://youtu.be/ATjXcjSgnE0?t=00h14m35s)

[i'm sorry what](https://youtu.be/ATjXcjSgnE0?t=00h14m39s)

[well that's just embarrassing](https://youtu.be/ATjXcjSgnE0?t=00h14m45s)

[so this will be fun uh apparently i do](https://youtu.be/ATjXcjSgnE0?t=00h14m50s)

[not have](https://youtu.be/ATjXcjSgnE0?t=00h14m54s)

[the.net framework sdk installed anymore](https://youtu.be/ATjXcjSgnE0?t=00h14m55s)

[um i will i will mention something on my](https://youtu.be/ATjXcjSgnE0?t=00h14m58s)

[visual studio installer](https://youtu.be/ATjXcjSgnE0?t=00h15m01s)

[uh you will note i am down to just the](https://youtu.be/ATjXcjSgnE0?t=00h15m03s)

[2022 preview on this machine](https://youtu.be/ATjXcjSgnE0?t=00h15m05s)

[so i have i have gone all in on vs](https://youtu.be/ATjXcjSgnE0?t=00h15m08s)

[2022 it is awesome i'm loving it](https://youtu.be/ATjXcjSgnE0?t=00h15m11s)

[um so much so that i uninstalled 2019](https://youtu.be/ATjXcjSgnE0?t=00h15m15s)

[and apparently when i did so i killed](https://youtu.be/ATjXcjSgnE0?t=00h15m18s)

[the](https://youtu.be/ATjXcjSgnE0?t=00h15m20s)

[so it was the 452 sdk that i need right](https://youtu.be/ATjXcjSgnE0?t=00h15m21s)

[yeah uh](https://youtu.be/ATjXcjSgnE0?t=00h15m24s)

[452 targeting pack that's what i want](https://youtu.be/ATjXcjSgnE0?t=00h15m29s)

[pretty please install and i'm just going](https://youtu.be/ATjXcjSgnE0?t=00h15m35s)

[to shut this guy down](https://youtu.be/ATjXcjSgnE0?t=00h15m38s)

[real quick while that installs and we](https://youtu.be/ATjXcjSgnE0?t=00h15m39s)

[will circle back over](https://youtu.be/ATjXcjSgnE0?t=00h15m41s)

[here for just a moment and we'll look at](https://youtu.be/ATjXcjSgnE0?t=00h15m43s)

[well that's why that's going](https://youtu.be/ATjXcjSgnE0?t=00h15m47s)

[i wanna put you off where i can keep an](https://youtu.be/ATjXcjSgnE0?t=00h15m50s)

[eye on you](https://youtu.be/ATjXcjSgnE0?t=00h15m54s)

[and let's just take a look at this so](https://youtu.be/ATjXcjSgnE0?t=00h15m54s)

[designer height change not a big deal](https://youtu.be/ATjXcjSgnE0?t=00h15m57s)

[and so toggle button](https://youtu.be/ATjXcjSgnE0?t=00h16m03s)

[what is this doing is checked true](https://youtu.be/ATjXcjSgnE0?t=00h16m08s)

[oh buttons enabled ah so you can test](https://youtu.be/ATjXcjSgnE0?t=00h16m20s)

[the disabled state got it](https://youtu.be/ATjXcjSgnE0?t=00h16m23s)

[that is rather convenient](https://youtu.be/ATjXcjSgnE0?t=00h16m26s)

[that was easy](https://youtu.be/ATjXcjSgnE0?t=00h16m29s)

[let's let's go let's do it](https://youtu.be/ATjXcjSgnE0?t=00h16m33s)

[um i actually really like having that i](https://youtu.be/ATjXcjSgnE0?t=00h16m38s)

[do](https://youtu.be/ATjXcjSgnE0?t=00h16m40s)

[i do wonder if some of these things need](https://youtu.be/ATjXcjSgnE0?t=00h16m41s)

[to be](https://youtu.be/ATjXcjSgnE0?t=00h16m43s)

[refactored on the demo app to be a](https://youtu.be/ATjXcjSgnE0?t=00h16m44s)

[little bit more global](https://youtu.be/ATjXcjSgnE0?t=00h16m46s)

[because some of these things like having](https://youtu.be/ATjXcjSgnE0?t=00h16m47s)

[this nice little enable feature](https://youtu.be/ATjXcjSgnE0?t=00h16m49s)

[kind of nice to have across all of them](https://youtu.be/ATjXcjSgnE0?t=00h16m52s)

[okay so let's try this again](https://youtu.be/ATjXcjSgnE0?t=00h16m56s)

[conveniently you'll note how fast that](https://youtu.be/ATjXcjSgnE0?t=00h17m02s)

[installer was](https://youtu.be/ATjXcjSgnE0?t=00h17m03s)

[there's been a lot of performance work](https://youtu.be/ATjXcjSgnE0?t=00h17m05s)

[that has gone into](https://youtu.be/ATjXcjSgnE0?t=00h17m07s)

[the vs 2022 stuff it is awesome](https://youtu.be/ATjXcjSgnE0?t=00h17m09s)

[uh one thing i'll point out to people if](https://youtu.be/ATjXcjSgnE0?t=00h17m12s)

[you install 2022](https://youtu.be/ATjXcjSgnE0?t=00h17m15s)

[you don't have all the preview features](https://youtu.be/ATjXcjSgnE0?t=00h17m16s)

[on by default you do need to go tools](https://youtu.be/ATjXcjSgnE0?t=00h17m18s)

[options and come into these preview](https://youtu.be/ATjXcjSgnE0?t=00h17m20s)

[features](https://youtu.be/ATjXcjSgnE0?t=00h17m22s)

[and tick the boxes next to all the cool](https://youtu.be/ATjXcjSgnE0?t=00h17m23s)

[stuff that you want](https://youtu.be/ATjXcjSgnE0?t=00h17m25s)

[um i turn so](https://youtu.be/ATjXcjSgnE0?t=00h17m27s)

[key ones that i would recommend for](https://youtu.be/ATjXcjSgnE0?t=00h17m30s)

[people um](https://youtu.be/ATjXcjSgnE0?t=00h17m32s)

[right out the gate new icons i'm loving](https://youtu.be/ATjXcjSgnE0?t=00h17m34s)

[them](https://youtu.be/ATjXcjSgnE0?t=00h17m37s)

[go for it um the live preview is awesome](https://youtu.be/ATjXcjSgnE0?t=00h17m38s)

[xaml preview features absolutely awesome](https://youtu.be/ATjXcjSgnE0?t=00h17m41s)

[the added intellisense and the auto](https://youtu.be/ATjXcjSgnE0?t=00h17m43s)

[generating of commands and view models](https://youtu.be/ATjXcjSgnE0?t=00h17m45s)

[install right away um i think i like the](https://youtu.be/ATjXcjSgnE0?t=00h17m48s)

[new dark theme](https://youtu.be/ATjXcjSgnE0?t=00h17m52s)

[it's cosmetic i think i like it](https://youtu.be/ATjXcjSgnE0?t=00h17m53s)

[hard to tell it's little stuff but it's](https://youtu.be/ATjXcjSgnE0?t=00h17m57s)

[it's kind of nice um the rich code](https://youtu.be/ATjXcjSgnE0?t=00h18m00s)

[navigation](https://youtu.be/ATjXcjSgnE0?t=00h18m02s)

[absolutely love that um same with the go](https://youtu.be/ATjXcjSgnE0?t=00h18m03s)

[to and the vs search](https://youtu.be/ATjXcjSgnE0?t=00h18m06s)

[right up here awesome love that very](https://youtu.be/ATjXcjSgnE0?t=00h18m08s)

[much love these two performance ones for](https://youtu.be/ATjXcjSgnE0?t=00h18m10s)

[prioritized performance and load](https://youtu.be/ATjXcjSgnE0?t=00h18m13s)

[projects faster](https://youtu.be/ATjXcjSgnE0?t=00h18m14s)

[absolutely amazing the speed at which](https://youtu.be/ATjXcjSgnE0?t=00h18m16s)

[some of the bigger projects that i pull](https://youtu.be/ATjXcjSgnE0?t=00h18m19s)

[open load up is incredibly noticeable](https://youtu.be/ATjXcjSgnE0?t=00h18m21s)

[for example my material design examples](https://youtu.be/ATjXcjSgnE0?t=00h18m26s)

[repo where there's something like 80](https://youtu.be/ATjXcjSgnE0?t=00h18m28s)

[some odd projects](https://youtu.be/ATjXcjSgnE0?t=00h18m29s)

[you want to see it load a bunch of](https://youtu.be/ATjXcjSgnE0?t=00h18m31s)

[projects really fast](https://youtu.be/ATjXcjSgnE0?t=00h18m32s)

[clone that solution and fire it up it is](https://youtu.be/ATjXcjSgnE0?t=00h18m34s)

[noticeably faster](https://youtu.be/ATjXcjSgnE0?t=00h18m37s)

[significantly noticeably faster on that](https://youtu.be/ATjXcjSgnE0?t=00h18m38s)

[repo](https://youtu.be/ATjXcjSgnE0?t=00h18m41s)

[so that's awesome](https://youtu.be/ATjXcjSgnE0?t=00h18m42s)

[so and then there's then there's other](https://youtu.be/ATjXcjSgnE0?t=00h18m45s)

[stuff oh intellicode](https://youtu.be/ATjXcjSgnE0?t=00h18m46s)

[love love intellicode so have to turn](https://youtu.be/ATjXcjSgnE0?t=00h18m49s)

[that one on](https://youtu.be/ATjXcjSgnE0?t=00h18m52s)

[um and then this out of process load for](https://youtu.be/ATjXcjSgnE0?t=00h18m53s)

[the most part](https://youtu.be/ATjXcjSgnE0?t=00h18m56s)

[this seems to work really well the only](https://youtu.be/ATjXcjSgnE0?t=00h18m56s)

[thing i've noticed is it's a little](https://youtu.be/ATjXcjSgnE0?t=00h18m59s)

[too fast at times um it seems to allow](https://youtu.be/ATjXcjSgnE0?t=00h19m00s)

[you to](https://youtu.be/ATjXcjSgnE0?t=00h19m03s)

[fire up a solution hit f5](https://youtu.be/ATjXcjSgnE0?t=00h19m05s)

[and then f5 um when it goes to launch](https://youtu.be/ATjXcjSgnE0?t=00h19m08s)

[fails because the dependency hasn't been](https://youtu.be/ATjXcjSgnE0?t=00h19m11s)

[uh loaded and built yet](https://youtu.be/ATjXcjSgnE0?t=00h19m13s)

[so it seems like there's some timing](https://youtu.be/ATjXcjSgnE0?t=00h19m15s)

[thing with maybe like](https://youtu.be/ATjXcjSgnE0?t=00h19m17s)

[previously built dlls something but](https://youtu.be/ATjXcjSgnE0?t=00h19m18s)

[it's not big you just press f5 a second](https://youtu.be/ATjXcjSgnE0?t=00h19m22s)

[time](https://youtu.be/ATjXcjSgnE0?t=00h19m24s)

[i'm okay with that okay back to what](https://youtu.be/ATjXcjSgnE0?t=00h19m26s)

[we're doing](https://youtu.be/ATjXcjSgnE0?t=00h19m28s)

[buttons page something like that](https://youtu.be/ATjXcjSgnE0?t=00h19m30s)

[okay so this guy here](https://youtu.be/ATjXcjSgnE0?t=00h19m34s)

[oh i like this i like these](https://youtu.be/ATjXcjSgnE0?t=00h19m40s)

[buttons](https://youtu.be/ATjXcjSgnE0?t=00h19m44s)

[oh i like this the little outline around](https://youtu.be/ATjXcjSgnE0?t=00h19m47s)

[it](https://youtu.be/ATjXcjSgnE0?t=00h19m50s)

[oh i like that](https://youtu.be/ATjXcjSgnE0?t=00h19m52s)

[so standard so this is standard because](https://youtu.be/ATjXcjSgnE0?t=00h19m55s)

[um](https://youtu.be/ATjXcjSgnE0?t=00h19m59s)

[by default this is going to follow um](https://youtu.be/ATjXcjSgnE0?t=00h19m59s)

[my system theme and my system is in](https://youtu.be/ATjXcjSgnE0?t=00h20m05s)

[um dark theme](https://youtu.be/ATjXcjSgnE0?t=00h20m08s)

[the magical incantation for anybody](https://youtu.be/ATjXcjSgnE0?t=00h20m12s)

[wanting to know how to do this](https://youtu.be/ATjXcjSgnE0?t=00h20m14s)

[um if it's not apparent is on the your](https://youtu.be/ATjXcjSgnE0?t=00h20m16s)

[theming resource dictionary](https://youtu.be/ATjXcjSgnE0?t=00h20m18s)

[that you bring in the base theme can](https://youtu.be/ATjXcjSgnE0?t=00h20m20s)

[either be set to dark theme](https://youtu.be/ATjXcjSgnE0?t=00h20m22s)

[light theme or inherit system](https://youtu.be/ATjXcjSgnE0?t=00h20m23s)

[so if you set it to inherit just make](https://youtu.be/ATjXcjSgnE0?t=00h20m27s)

[sure that you test your app both in dark](https://youtu.be/ATjXcjSgnE0?t=00h20m29s)

[and light theme to make sure everything](https://youtu.be/ATjXcjSgnE0?t=00h20m31s)

[looks good](https://youtu.be/ATjXcjSgnE0?t=00h20m32s)

[um and that you've got proper contrast](https://youtu.be/ATjXcjSgnE0?t=00h20m33s)

[and whatnot because that does mean that](https://youtu.be/ATjXcjSgnE0?t=00h20m35s)

[you are giving up that control to your](https://youtu.be/ATjXcjSgnE0?t=00h20m37s)

[end user](https://youtu.be/ATjXcjSgnE0?t=00h20m39s)

[which is great for the end user but it](https://youtu.be/ATjXcjSgnE0?t=00h20m40s)

[also means that you](https://youtu.be/ATjXcjSgnE0?t=00h20m42s)

[now have to make sure your colors look](https://youtu.be/ATjXcjSgnE0?t=00h20m43s)

[good two ways not just one](https://youtu.be/ATjXcjSgnE0?t=00h20m44s)

[so but i like that](https://youtu.be/ATjXcjSgnE0?t=00h20m46s)

[i like these so what's the difference](https://youtu.be/ATjXcjSgnE0?t=00h20m54s)

[here outline secondary button](https://youtu.be/ATjXcjSgnE0?t=00h20m56s)

[paper secondary ah so that's the big](https://youtu.be/ATjXcjSgnE0?t=00h21m00s)

[difference](https://youtu.be/ATjXcjSgnE0?t=00h21m02s)

[the big difference is whether this uses](https://youtu.be/ATjXcjSgnE0?t=00h21m04s)

[the paper brush here](https://youtu.be/ATjXcjSgnE0?t=00h21m05s)

[versus not](https://youtu.be/ATjXcjSgnE0?t=00h21m07s)

[okay i can get on board with that and](https://youtu.be/ATjXcjSgnE0?t=00h21m10s)

[then inverted](https://youtu.be/ATjXcjSgnE0?t=00h21m12s)

[i'm wondering why those don't change](https://youtu.be/ATjXcjSgnE0?t=00h21m18s)

[oh because those are using the same](https://youtu.be/ATjXcjSgnE0?t=00h21m24s)

[the same brush there interesting okay](https://youtu.be/ATjXcjSgnE0?t=00h21m30s)

[um](https://youtu.be/ATjXcjSgnE0?t=00h21m37s)

[so you'll note i just flipped my thing](https://youtu.be/ATjXcjSgnE0?t=00h21m40s)

[to to light theme](https://youtu.be/ATjXcjSgnE0?t=00h21m42s)

[right and so these things are now going](https://youtu.be/ATjXcjSgnE0?t=00h21m44s)

[to track light theme and so now i want](https://youtu.be/ATjXcjSgnE0?t=00h21m46s)

[to look at them in standard](https://youtu.be/ATjXcjSgnE0?t=00h21m47s)

[it's interesting that they default to](https://youtu.be/ATjXcjSgnE0?t=00h21m55s)

[having just a hair of a shadow](https://youtu.be/ATjXcjSgnE0?t=00h21m57s)

[given that there's not a lot of](https://youtu.be/ATjXcjSgnE0?t=00h22m00s)

[precedence](https://youtu.be/ATjXcjSgnE0?t=00h22m01s)

[i think that shadow aligns with this](https://youtu.be/ATjXcjSgnE0?t=00h22m03s)

[button here](https://youtu.be/ATjXcjSgnE0?t=00h22m05s)

[which is fine i think that works](https://youtu.be/ATjXcjSgnE0?t=00h22m07s)

[um it just caught me off guard because i](https://youtu.be/ATjXcjSgnE0?t=00h22m11s)

[was tracking them with these ones down](https://youtu.be/ATjXcjSgnE0?t=00h22m13s)

[below that have none](https://youtu.be/ATjXcjSgnE0?t=00h22m14s)

[but i kind of like it so wait what is](https://youtu.be/ATjXcjSgnE0?t=00h22m19s)

[flat oh i got you](https://youtu.be/ATjXcjSgnE0?t=00h22m24s)

[raised okay so they track with the](https://youtu.be/ATjXcjSgnE0?t=00h22m27s)

[raised ones okay](https://youtu.be/ATjXcjSgnE0?t=00h22m30s)

[cool cool cool cool](https://youtu.be/ATjXcjSgnE0?t=00h22m31s)

[i don't expect that to do much](https://youtu.be/ATjXcjSgnE0?t=00h22m36s)

[um i think we probably want to drop](https://youtu.be/ATjXcjSgnE0?t=00h22m40s)

[i don't know how useful this is](https://youtu.be/ATjXcjSgnE0?t=00h22m49s)

[curious what this what this code behind](https://youtu.be/ATjXcjSgnE0?t=00h22m55s)

[the scenes is doing so let's](https://youtu.be/ATjXcjSgnE0?t=00h22m57s)

[let's take a quick look](https://youtu.be/ATjXcjSgnE0?t=00h22m59s)

[um well that's right this is pure xaml](https://youtu.be/ATjXcjSgnE0?t=00h23m05s)

[so what is that thing bound to](https://youtu.be/ATjXcjSgnE0?t=00h23m09s)

[color zone mode](https://youtu.be/ATjXcjSgnE0?t=00h23m13s)

[uh let's see](https://youtu.be/ATjXcjSgnE0?t=00h23m16s)

[oh that's clever so he's using the](https://youtu.be/ATjXcjSgnE0?t=00h23m22s)

[object data provider to just call enum](https://youtu.be/ATjXcjSgnE0?t=00h23m24s)

[get values](https://youtu.be/ATjXcjSgnE0?t=00h23m26s)

[i got you i got you](https://youtu.be/ATjXcjSgnE0?t=00h23m28s)

[get color zone modes and then this is](https://youtu.be/ATjXcjSgnE0?t=00h23m33s)

[setting](https://youtu.be/ATjXcjSgnE0?t=00h23m36s)

[that guy there is being bound into the](https://youtu.be/ATjXcjSgnE0?t=00h23m38s)

[combo box](https://youtu.be/ATjXcjSgnE0?t=00h23m41s)

[and then there's got to be somewhere](https://youtu.be/ATjXcjSgnE0?t=00h23m42s)

[else for that](https://youtu.be/ATjXcjSgnE0?t=00h23m43s)

[somebody else has got to be using that](https://youtu.be/ATjXcjSgnE0?t=00h23m48s)

[oh unless it's bound directly to the](https://youtu.be/ATjXcjSgnE0?t=00h23m51s)

[combo box](https://youtu.be/ATjXcjSgnE0?t=00h23m54s)

[ah look at that there it is okay so it's](https://youtu.be/ATjXcjSgnE0?t=00h23m56s)

[so there's a color zone here](https://youtu.be/ATjXcjSgnE0?t=00h23m59s)

[being bound into that](https://youtu.be/ATjXcjSgnE0?t=00h24m01s)

[trying to decide how useful that is](https://youtu.be/ATjXcjSgnE0?t=00h24m09s)

[trying to decide if that's useful or](https://youtu.be/ATjXcjSgnE0?t=00h24m17s)

[just](https://youtu.be/ATjXcjSgnE0?t=00h24m20s)

[adding noise to the screen because is it](https://youtu.be/ATjXcjSgnE0?t=00h24m21s)

[worth checking](https://youtu.be/ATjXcjSgnE0?t=00h24m23s)

[all of these i think it's good to check](https://youtu.be/ATjXcjSgnE0?t=00h24m24s)

[inverted in standard which is](https://youtu.be/ATjXcjSgnE0?t=00h24m30s)

[effectively light and dark](https://youtu.be/ATjXcjSgnE0?t=00h24m33s)

[but i've already got that light dark](https://youtu.be/ATjXcjSgnE0?t=00h24m36s)

[toggle here](https://youtu.be/ATjXcjSgnE0?t=00h24m38s)

[so i'm not sure how valuable it is](https://youtu.be/ATjXcjSgnE0?t=00h24m41s)

[elsewhere](https://youtu.be/ATjXcjSgnE0?t=00h24m44s)

[i think](https://youtu.be/ATjXcjSgnE0?t=00h24m49s)

[um i think i i'm gonna suggest that we](https://youtu.be/ATjXcjSgnE0?t=00h24m55s)

[sack it](https://youtu.be/ATjXcjSgnE0?t=00h24m58s)

[and actually i wanted to test the enable](https://youtu.be/ATjXcjSgnE0?t=00h25m06s)

[too](https://youtu.be/ATjXcjSgnE0?t=00h25m08s)

[this is great i do](https://youtu.be/ATjXcjSgnE0?t=00h25m12s)

[wonder if this would be nice to be](https://youtu.be/ATjXcjSgnE0?t=00h25m15s)

[something that got included higher up](https://youtu.be/ATjXcjSgnE0?t=00h25m16s)

[um](https://youtu.be/ATjXcjSgnE0?t=00h25m26s)

[uh](https://youtu.be/ATjXcjSgnE0?t=00h25m29s)

[test let's see dark and light theme](https://youtu.be/ATjXcjSgnE0?t=00h25m35s)

[um](https://youtu.be/ATjXcjSgnE0?t=00h25m40s)

[let's see and then i want to call out](https://youtu.be/ATjXcjSgnE0?t=00h26m01s)

[that](https://youtu.be/ATjXcjSgnE0?t=00h26m03s)

[toggle that was up here](https://youtu.be/ATjXcjSgnE0?t=00h26m05s)

[uh](https://youtu.be/ATjXcjSgnE0?t=00h26m22s)

[up under the](https://youtu.be/ATjXcjSgnE0?t=00h26m37s)

[toggle](https://youtu.be/ATjXcjSgnE0?t=00h26m50s)

[i think we'll leave that in the rest of](https://youtu.be/ATjXcjSgnE0?t=00h26m57s)

[this i'm](https://youtu.be/ATjXcjSgnE0?t=00h27m00s)

[pretty okay with this is this is awesome](https://youtu.be/ATjXcjSgnE0?t=00h27m01s)

[work](https://youtu.be/ATjXcjSgnE0?t=00h27m05s)

[i i see no reason to i mean some of this](https://youtu.be/ATjXcjSgnE0?t=00h27m08s)

[indentation could be a little prettier](https://youtu.be/ATjXcjSgnE0?t=00h27m11s)

[but](https://youtu.be/ATjXcjSgnE0?t=00h27m12s)

[that's one of those things that i would](https://youtu.be/ATjXcjSgnE0?t=00h27m14s)

[rather fix with um](https://youtu.be/ATjXcjSgnE0?t=00h27m15s)

[scripting and tooling that way that way](https://youtu.be/ATjXcjSgnE0?t=00h27m17s)

[people don't have to worry about it i](https://youtu.be/ATjXcjSgnE0?t=00h27m20s)

[want this library to be as easy for](https://youtu.be/ATjXcjSgnE0?t=00h27m21s)

[contributors to get involved with as](https://youtu.be/ATjXcjSgnE0?t=00h27m23s)

[possible](https://youtu.be/ATjXcjSgnE0?t=00h27m25s)

[um just so that it's it's easy to grow i](https://youtu.be/ATjXcjSgnE0?t=00h27m26s)

[i've](https://youtu.be/ATjXcjSgnE0?t=00h27m30s)

[i've really tried to go as far as i can](https://youtu.be/ATjXcjSgnE0?t=00h27m31s)

[to make things be](https://youtu.be/ATjXcjSgnE0?t=00h27m33s)

[oh that's what i want to look at](https://youtu.be/ATjXcjSgnE0?t=00h27m35s)

[i'll do the other ones all set cursor as](https://youtu.be/ATjXcjSgnE0?t=00h27m38s)

[well](https://youtu.be/ATjXcjSgnE0?t=00h27m41s)

[really i'm surprised at that i thought](https://youtu.be/ATjXcjSgnE0?t=00h27m45s)

[we had turned off](https://youtu.be/ATjXcjSgnE0?t=00h27m49s)

[cursor on most of those maybe i could be](https://youtu.be/ATjXcjSgnE0?t=00h27m50s)

[wrong if that if that is feature parody](https://youtu.be/ATjXcjSgnE0?t=00h27m54s)

[with the other buttons then i'm not](https://youtu.be/ATjXcjSgnE0?t=00h27m56s)

[gonna](https://youtu.be/ATjXcjSgnE0?t=00h27m57s)

[i'm not gonna complain but do we](https://youtu.be/ATjXcjSgnE0?t=00h27m59s)

[seriously set it](https://youtu.be/ATjXcjSgnE0?t=00h28m01s)

[look at that raise button has it set](https://youtu.be/ATjXcjSgnE0?t=00h28m04s)

[flat button has a set yeah okay that's](https://youtu.be/ATjXcjSgnE0?t=00h28m07s)

[okay so that's feature parody so i'm not](https://youtu.be/ATjXcjSgnE0?t=00h28m10s)

[gonna](https://youtu.be/ATjXcjSgnE0?t=00h28m12s)

[i'm not gonna squawk there](https://youtu.be/ATjXcjSgnE0?t=00h28m14s)

[oh the the comment here on text block](https://youtu.be/ATjXcjSgnE0?t=00h28m20s)

[versus text element](https://youtu.be/ATjXcjSgnE0?t=00h28m23s)

[so if we go and look at let's see 6 11](https://youtu.be/ATjXcjSgnE0?t=00h28m24s)

[and 6 12.](https://youtu.be/ATjXcjSgnE0?t=00h28m27s)

[so if we come here this thing's quickly](https://youtu.be/ATjXcjSgnE0?t=00h28m28s)

[getting out of hand](https://youtu.be/ATjXcjSgnE0?t=00h28m32s)

[uh 6 11](https://youtu.be/ATjXcjSgnE0?t=00h28m33s)

[oh that is not the right this is the one](https://youtu.be/ATjXcjSgnE0?t=00h28m37s)

[we want](https://youtu.be/ATjXcjSgnE0?t=00h28m39s)

[g611 so if we come in here if we look at](https://youtu.be/ATjXcjSgnE0?t=00h28m41s)

[and i should be able to f12 on this](https://youtu.be/ATjXcjSgnE0?t=00h28m44s)

[yes oh so for those people curious what](https://youtu.be/ATjXcjSgnE0?t=00h28m46s)

[um that pop-up was let me show you so if](https://youtu.be/ATjXcjSgnE0?t=00h28m51s)

[you come into](https://youtu.be/ATjXcjSgnE0?t=00h28m54s)

[your tools options and you search for](https://youtu.be/ATjXcjSgnE0?t=00h28m55s)

[decompile](https://youtu.be/ATjXcjSgnE0?t=00h28m57s)

[there's an option in here](https://youtu.be/ATjXcjSgnE0?t=00h28m58s)

[so uh under the advanced options](https://youtu.be/ATjXcjSgnE0?t=00h29m06s)

[enable navigation to decompile sources](https://youtu.be/ATjXcjSgnE0?t=00h29m09s)

[experimental](https://youtu.be/ATjXcjSgnE0?t=00h29m12s)

[so this is yet one more](https://youtu.be/ATjXcjSgnE0?t=00h29m14s)

[um awesome little thing that you can get](https://youtu.be/ATjXcjSgnE0?t=00h29m18s)

[that pop-up that comes up at the](https://youtu.be/ATjXcjSgnE0?t=00h29m21s)

[beginning is just sitting there telling](https://youtu.be/ATjXcjSgnE0?t=00h29m23s)

[you](https://youtu.be/ATjXcjSgnE0?t=00h29m24s)

[hey i promise to not do anything bad](https://youtu.be/ATjXcjSgnE0?t=00h29m25s)

[while decompiling somebody else's code](https://youtu.be/ATjXcjSgnE0?t=00h29m27s)

[but it can be really really handy to](https://youtu.be/ATjXcjSgnE0?t=00h29m29s)

[jump into decompiled sources so](https://youtu.be/ATjXcjSgnE0?t=00h29m32s)

[for people unfamiliar with decompiled](https://youtu.be/ATjXcjSgnE0?t=00h29m34s)

[code](https://youtu.be/ATjXcjSgnE0?t=00h29m36s)

[with c sharp and any of the.net](https://youtu.be/ATjXcjSgnE0?t=00h29m37s)

[languages they compile down to something](https://youtu.be/ATjXcjSgnE0?t=00h29m39s)

[called intermediate languages or il](https://youtu.be/ATjXcjSgnE0?t=00h29m41s)

[you'll see a lot of documentation](https://youtu.be/ATjXcjSgnE0?t=00h29m43s)

[reference either](https://youtu.be/ATjXcjSgnE0?t=00h29m45s)

[cil common intermediate language or msil](https://youtu.be/ATjXcjSgnE0?t=00h29m47s)

[microsoft intermediate language](https://youtu.be/ATjXcjSgnE0?t=00h29m50s)

[uh effectively if you go to look at it](https://youtu.be/ATjXcjSgnE0?t=00h29m52s)

[it looks like](https://youtu.be/ATjXcjSgnE0?t=00h29m55s)

[assembly code or or something very close](https://youtu.be/ATjXcjSgnE0?t=00h29m56s)

[to assembly code](https://youtu.be/ATjXcjSgnE0?t=00h29m59s)

[but it's not and the key difference](https://youtu.be/ATjXcjSgnE0?t=00h30m00s)

[there is that it's not](https://youtu.be/ATjXcjSgnE0?t=00h30m02s)

[unlike normal assembly that's tied to a](https://youtu.be/ATjXcjSgnE0?t=00h30m03s)

[particular process or architecture](https://youtu.be/ATjXcjSgnE0?t=00h30m04s)

[il is not tied to a particular process](https://youtu.be/ATjXcjSgnE0?t=00h30m06s)

[architecture and it allows the runtime](https://youtu.be/ATjXcjSgnE0?t=00h30m09s)

[to quickly interpret it](https://youtu.be/ATjXcjSgnE0?t=00h30m11s)

[and execute it on the appropriate](https://youtu.be/ATjXcjSgnE0?t=00h30m12s)

[architecture but because il has already](https://youtu.be/ATjXcjSgnE0?t=00h30m15s)

[kind of gotten](https://youtu.be/ATjXcjSgnE0?t=00h30m17s)

[that big translation hurdle down to](https://youtu.be/ATjXcjSgnE0?t=00h30m18s)

[something that's really close to it](https://youtu.be/ATjXcjSgnE0?t=00h30m20s)

[it's pretty easy to do that that](https://youtu.be/ATjXcjSgnE0?t=00h30m22s)

[translations at the runtime](https://youtu.be/ATjXcjSgnE0?t=00h30m24s)

[when you do decompiled sources it's](https://youtu.be/ATjXcjSgnE0?t=00h30m26s)

[important to note that when you load up](https://youtu.be/ATjXcjSgnE0?t=00h30m29s)

[that dll](https://youtu.be/ATjXcjSgnE0?t=00h30m30s)

[what you are what you are getting is a](https://youtu.be/ATjXcjSgnE0?t=00h30m31s)

[dll is a bunch of il](https://youtu.be/ATjXcjSgnE0?t=00h30m34s)

[operations and there's there's extra](https://youtu.be/ATjXcjSgnE0?t=00h30m36s)

[metadata and what not in there for the](https://youtu.be/ATjXcjSgnE0?t=00h30m38s)

[object structures and that kind of thing](https://youtu.be/ATjXcjSgnE0?t=00h30m39s)

[but to actually get like method contents](https://youtu.be/ATjXcjSgnE0?t=00h30m42s)

[and whatnot out](https://youtu.be/ATjXcjSgnE0?t=00h30m44s)

[all all it has to work with is il](https://youtu.be/ATjXcjSgnE0?t=00h30m45s)

[instructions and so](https://youtu.be/ATjXcjSgnE0?t=00h30m47s)

[the decompiler has to try to reverse](https://youtu.be/ATjXcjSgnE0?t=00h30m49s)

[engineer](https://youtu.be/ATjXcjSgnE0?t=00h30m51s)

[what the compiler generated and try to](https://youtu.be/ATjXcjSgnE0?t=00h30m52s)

[almost guess in some cases](https://youtu.be/ATjXcjSgnE0?t=00h30m54s)

[what the original c-sharp code looked](https://youtu.be/ATjXcjSgnE0?t=00h30m56s)

[like in order to get to that original il](https://youtu.be/ATjXcjSgnE0?t=00h30m58s)

[which is not an easy problem in some](https://youtu.be/ATjXcjSgnE0?t=00h31m00s)

[cases in some cases](https://youtu.be/ATjXcjSgnE0?t=00h31m02s)

[it's pretty obvious what the original](https://youtu.be/ATjXcjSgnE0?t=00h31m04s)

[code was in other cases it's like well](https://youtu.be/ATjXcjSgnE0?t=00h31m05s)

[this is not necessarily you know a](https://youtu.be/ATjXcjSgnE0?t=00h31m07s)

[simple one-to-one](https://youtu.be/ATjXcjSgnE0?t=00h31m10s)

[operation there's a lot of things that a](https://youtu.be/ATjXcjSgnE0?t=00h31m11s)

[compiler can do to especially optimize](https://youtu.be/ATjXcjSgnE0?t=00h31m13s)

[code](https://youtu.be/ATjXcjSgnE0?t=00h31m15s)

[not necessarily attempting to obfuscate](https://youtu.be/ATjXcjSgnE0?t=00h31m16s)

[it but some of it gets a little](https://youtu.be/ATjXcjSgnE0?t=00h31m18s)

[obfuscated in the process](https://youtu.be/ATjXcjSgnE0?t=00h31m19s)

[so to be aware when you're looking at](https://youtu.be/ATjXcjSgnE0?t=00h31m20s)

[this c-sharp code from that](https://youtu.be/ATjXcjSgnE0?t=00h31m23s)

[um what this is is the decompiler's best](https://youtu.be/ATjXcjSgnE0?t=00h31m24s)

[guess](https://youtu.be/ATjXcjSgnE0?t=00h31m28s)

[of what that original c-sharp code](https://youtu.be/ATjXcjSgnE0?t=00h31m29s)

[probably look like](https://youtu.be/ATjXcjSgnE0?t=00h31m31s)

[so just be aware that all of that to say](https://youtu.be/ATjXcjSgnE0?t=00h31m33s)

[let's go look at that um](https://youtu.be/ATjXcjSgnE0?t=00h31m36s)

[so if we go we can test this text](https://youtu.be/ATjXcjSgnE0?t=00h31m40s)

[element](https://youtu.be/ATjXcjSgnE0?t=00h31m44s)

[so if we drive here](https://youtu.be/ATjXcjSgnE0?t=00h31m50s)

[you know this guy gets us down into the](https://youtu.be/ATjXcjSgnE0?t=00h31m54s)

[the abstract base class](https://youtu.be/ATjXcjSgnE0?t=00h31m57s)

[was this guy here](https://youtu.be/ATjXcjSgnE0?t=00h31m59s)

[oh it's actually going on textblock](https://youtu.be/ATjXcjSgnE0?t=00h32m04s)

[framework element interesting](https://youtu.be/ATjXcjSgnE0?t=00h32m06s)

[however text element is the one that](https://youtu.be/ATjXcjSgnE0?t=00h32m09s)

[should get picked up in both cases](https://youtu.be/ATjXcjSgnE0?t=00h32m12s)

[we will we will just test this](https://youtu.be/ATjXcjSgnE0?t=00h32m14s)

[suggestion](https://youtu.be/ATjXcjSgnE0?t=00h32m16s)

[before making before making it we will](https://youtu.be/ATjXcjSgnE0?t=00h32m18s)

[we will confirm that it does in fact](https://youtu.be/ATjXcjSgnE0?t=00h32m20s)

[work](https://youtu.be/ATjXcjSgnE0?t=00h32m26s)

[this would actually be a beautiful time](https://youtu.be/ATjXcjSgnE0?t=00h32m28s)

[for a ui test](https://youtu.be/ATjXcjSgnE0?t=00h32m30s)

[spin up a little ui test with all of the](https://youtu.be/ATjXcjSgnE0?t=00h32m32s)

[button types](https://youtu.be/ATjXcjSgnE0?t=00h32m34s)

[set the font size on them and make sure](https://youtu.be/ATjXcjSgnE0?t=00h32m36s)

[that that gets properly inherited](https://youtu.be/ATjXcjSgnE0?t=00h32m38s)

[those are the types of things that are](https://youtu.be/ATjXcjSgnE0?t=00h32m39s)

[really really hard to unit test](https://youtu.be/ATjXcjSgnE0?t=00h32m42s)

[but can be very effective ui tests to](https://youtu.be/ATjXcjSgnE0?t=00h32m46s)

[catch it](https://youtu.be/ATjXcjSgnE0?t=00h32m50s)

[the pull requests that i did at the very](https://youtu.be/ATjXcjSgnE0?t=00h32m51s)

[end of the stream last week](https://youtu.be/ATjXcjSgnE0?t=00h32m53s)

[that one ended up failing because one of](https://youtu.be/ATjXcjSgnE0?t=00h32m55s)

[my ui tests flagged it](https://youtu.be/ATjXcjSgnE0?t=00h32m57s)

[because the change that i made to the](https://youtu.be/ATjXcjSgnE0?t=00h32m59s)

[structure caused the height of the combo](https://youtu.be/ATjXcjSgnE0?t=00h33m00s)

[box to change and it no longer matched](https://youtu.be/ATjXcjSgnE0?t=00h33m02s)

[the other fields](https://youtu.be/ATjXcjSgnE0?t=00h33m04s)

[which was wonderful that's exactly why](https://youtu.be/ATjXcjSgnE0?t=00h33m05s)

[we wrote that test to make sure that](https://youtu.be/ATjXcjSgnE0?t=00h33m07s)

[those types of changes didn't](https://youtu.be/ATjXcjSgnE0?t=00h33m08s)

[accidentally creep in anymore because](https://youtu.be/ATjXcjSgnE0?t=00h33m10s)

[people oftentimes](https://youtu.be/ATjXcjSgnE0?t=00h33m12s)

[build input forms and it's very nice](https://youtu.be/ATjXcjSgnE0?t=00h33m13s)

[when your forms have this nice symmetry](https://youtu.be/ATjXcjSgnE0?t=00h33m15s)

[and everything lines up and it gets very](https://youtu.be/ATjXcjSgnE0?t=00h33m17s)

[jarring when those](https://youtu.be/ATjXcjSgnE0?t=00h33m19s)

[measurements don't match so we don't](https://youtu.be/ATjXcjSgnE0?t=00h33m20s)

[want that okay it certainly looks like a](https://youtu.be/ATjXcjSgnE0?t=00h33m24s)

[14 but](https://youtu.be/ATjXcjSgnE0?t=00h33m29s)

[let's let's just confirm that real quick](https://youtu.be/ATjXcjSgnE0?t=00h33m30s)

[and actually here rather than snoop](https://youtu.be/ATjXcjSgnE0?t=00h33m32s)

[i'm gonna i'm gonna try to do it here](https://youtu.be/ATjXcjSgnE0?t=00h33m35s)

[boom](https://youtu.be/ATjXcjSgnE0?t=00h33m37s)

[and then show live visual tree](https://youtu.be/ATjXcjSgnE0?t=00h33m38s)

[boom so we'll use we'll try to use the](https://youtu.be/ATjXcjSgnE0?t=00h33m44s)

[visual studio ones and see how well i do](https://youtu.be/ATjXcjSgnE0?t=00h33m46s)

[um wow that's not](https://youtu.be/ATjXcjSgnE0?t=00h33m50s)

[okay and that's as far as i'm gonna get](https://youtu.be/ATjXcjSgnE0?t=00h34m04s)

[something is horribly wrong i don't know](https://youtu.be/ATjXcjSgnE0?t=00h34m07s)

[what and](https://youtu.be/ATjXcjSgnE0?t=00h34m09s)

[visual studio appears to be losing its](https://youtu.be/ATjXcjSgnE0?t=00h34m11s)

[mind so that's](https://youtu.be/ATjXcjSgnE0?t=00h34m13s)

[that's exciting](https://youtu.be/ATjXcjSgnE0?t=00h34m15s)

[okay so we're just gonna put you to](https://youtu.be/ATjXcjSgnE0?t=00h34m18s)

[sleep](https://youtu.be/ATjXcjSgnE0?t=00h34m20s)

[and not use you anymore um okay snoop](https://youtu.be/ATjXcjSgnE0?t=00h34m22s)

[go and grab it because you just work](https://youtu.be/ATjXcjSgnE0?t=00h34m26s)

[okay so really what i want to do is dive](https://youtu.be/ATjXcjSgnE0?t=00h34m31s)

[in here text block](https://youtu.be/ATjXcjSgnE0?t=00h34m33s)

[and i want to just confirm that font](https://youtu.be/ATjXcjSgnE0?t=00h34m36s)

[size](https://youtu.be/ATjXcjSgnE0?t=00h34m38s)

[is in fact 14. see that's all we wanted](https://youtu.be/ATjXcjSgnE0?t=00h34m39s)

[to do we just wanted to confirm my](https://youtu.be/ATjXcjSgnE0?t=00h34m42s)

[suggestion before i made it](https://youtu.be/ATjXcjSgnE0?t=00h34m44s)

[everything else looks good we'll just do](https://youtu.be/ATjXcjSgnE0?t=00h34m46s)

[comment for now](https://youtu.be/ATjXcjSgnE0?t=00h34m49s)

[but i think this this pr is looking](https://youtu.be/ATjXcjSgnE0?t=00h34m51s)

[really really good](https://youtu.be/ATjXcjSgnE0?t=00h34m53s)

[and this should make it in in plenty of](https://youtu.be/ATjXcjSgnE0?t=00h34m55s)

[time for the release](https://youtu.be/ATjXcjSgnE0?t=00h34m57s)

[okay so let's go back](https://youtu.be/ATjXcjSgnE0?t=00h34m58s)

[i think i'm gonna avoid this for the](https://youtu.be/ATjXcjSgnE0?t=00h35m02s)

[moment it's exciting as some of these](https://youtu.be/ATjXcjSgnE0?t=00h35m03s)

[pull requests are i want to go back here](https://youtu.be/ATjXcjSgnE0?t=00h35m07s)

[i don't know what this is](https://youtu.be/ATjXcjSgnE0?t=00h35m11s)

[i might need to look at that um](https://youtu.be/ATjXcjSgnE0?t=00h35m15s)

[[Music]](https://youtu.be/ATjXcjSgnE0?t=00h35m18s)

[uh is it possible to this](https://youtu.be/ATjXcjSgnE0?t=00h35m22s)

[uh](https://youtu.be/ATjXcjSgnE0?t=00h35m30s)

[i'll come back to this that's that's an](https://youtu.be/ATjXcjSgnE0?t=00h35m34s)

[interesting one and this is not the](https://youtu.be/ATjXcjSgnE0?t=00h35m36s)

[first time this has come up](https://youtu.be/ATjXcjSgnE0?t=00h35m37s)

[this is not the first time that has come](https://youtu.be/ATjXcjSgnE0?t=00h35m40s)

[up](https://youtu.be/ATjXcjSgnE0?t=00h35m42s)

[and it is hard to say what the](https://youtu.be/ATjXcjSgnE0?t=00h35m45s)

[appropriate thing is okay](https://youtu.be/ATjXcjSgnE0?t=00h35m47s)

[um let's look at this one i guess we'll](https://youtu.be/ATjXcjSgnE0?t=00h35m48s)

[just start top down](https://youtu.be/ATjXcjSgnE0?t=00h35m53s)

[uh data grid demo code selecting unit](https://youtu.be/ATjXcjSgnE0?t=00h35m55s)

[doesn't work](https://youtu.be/ATjXcjSgnE0?t=00h35m57s)

[okay so this is certainly a bug so let's](https://youtu.be/ATjXcjSgnE0?t=00h36m00s)

[let's take a look at this](https://youtu.be/ATjXcjSgnE0?t=00h36m03s)

[so step one throw away all current work](https://youtu.be/ATjXcjSgnE0?t=00h36m05s)

[reset to latest so](https://youtu.be/ATjXcjSgnE0?t=00h36m08s)

[um if for anybody who's interested in](https://youtu.be/ATjXcjSgnE0?t=00h36m11s)

[working on this library i'm going to go](https://youtu.be/ATjXcjSgnE0?t=00h36m13s)

[through this process a little slower](https://youtu.be/ATjXcjSgnE0?t=00h36m14s)

[because this is probably](https://youtu.be/ATjXcjSgnE0?t=00h36m16s)

[worth doing so what you do is](https://youtu.be/ATjXcjSgnE0?t=00h36m17s)

[when you get your your local clone](https://youtu.be/ATjXcjSgnE0?t=00h36m20s)

[obviously you open it with get cracking](https://youtu.be/ATjXcjSgnE0?t=00h36m23s)

[because it's just awesome](https://youtu.be/ATjXcjSgnE0?t=00h36m25s)

[uh no get kraken does not pay me to say](https://youtu.be/ATjXcjSgnE0?t=00h36m27s)

[that i just love it](https://youtu.be/ATjXcjSgnE0?t=00h36m29s)

[uh what you'll do is you'll click uh up](https://youtu.be/ATjXcjSgnE0?t=00h36m31s)

[on](https://youtu.be/ATjXcjSgnE0?t=00h36m34s)

[let's just do let's just walk through](https://youtu.be/ATjXcjSgnE0?t=00h36m35s)

[this real quick this is probably worth](https://youtu.be/ATjXcjSgnE0?t=00h36m37s)

[worthwhile](https://youtu.be/ATjXcjSgnE0?t=00h36m38s)

[showing so when you get to the main](https://youtu.be/ATjXcjSgnE0?t=00h36m39s)

[repository page](https://youtu.be/ATjXcjSgnE0?t=00h36m41s)

[you'll see this little fork button and](https://youtu.be/ATjXcjSgnE0?t=00h36m42s)

[you'll click the fork](https://youtu.be/ATjXcjSgnE0?t=00h36m44s)

[and i'm in a bunch of orgs um and](https://youtu.be/ATjXcjSgnE0?t=00h36m45s)

[normally you'll see your personal](https://youtu.be/ATjXcjSgnE0?t=00h36m49s)

[account right at the top you'll click on](https://youtu.be/ATjXcjSgnE0?t=00h36m50s)

[that and say](https://youtu.be/ATjXcjSgnE0?t=00h36m52s)

[make me a fork once that's done](https://youtu.be/ATjXcjSgnE0?t=00h36m53s)

[i'm i'm assuming you've already got get](https://youtu.be/ATjXcjSgnE0?t=00h36m56s)

[cracking installed and connected to your](https://youtu.be/ATjXcjSgnE0?t=00h36m58s)

[github account](https://youtu.be/ATjXcjSgnE0?t=00h37m00s)

[you come over here you'll type in you](https://youtu.be/ATjXcjSgnE0?t=00h37m02s)

[know material design](https://youtu.be/ATjXcjSgnE0?t=00h37m04s)

[in xaml toolkit you'll give it a path](https://youtu.be/ATjXcjSgnE0?t=00h37m06s)

[you'll clone the repo](https://youtu.be/ATjXcjSgnE0?t=00h37m08s)

[and then you'll end up with something](https://youtu.be/ATjXcjSgnE0?t=00h37m09s)

[that looks kind of like this albeit with](https://youtu.be/ATjXcjSgnE0?t=00h37m10s)

[a lot fewer things on the side here](https://youtu.be/ATjXcjSgnE0?t=00h37m12s)

[i've just made a mess with my locals](https://youtu.be/ATjXcjSgnE0?t=00h37m14s)

[and what you'll do is you will actually](https://youtu.be/ATjXcjSgnE0?t=00h37m17s)

[be on the master branch when you first](https://youtu.be/ATjXcjSgnE0?t=00h37m19s)

[start because that is what is said as](https://youtu.be/ATjXcjSgnE0?t=00h37m21s)

[the default branch](https://youtu.be/ATjXcjSgnE0?t=00h37m22s)

[what you'll want to do is then right](https://youtu.be/ATjXcjSgnE0?t=00h37m24s)

[click on this and hit create branch and](https://youtu.be/ATjXcjSgnE0?t=00h37m26s)

[i just usually call it](https://youtu.be/ATjXcjSgnE0?t=00h37m28s)

[fix and then i i reference](https://youtu.be/ATjXcjSgnE0?t=00h37m29s)

[um the issue number you can name it](https://youtu.be/ATjXcjSgnE0?t=00h37m32s)

[whatever you want](https://youtu.be/ATjXcjSgnE0?t=00h37m35s)

[it's usually best though you can do pr's](https://youtu.be/ATjXcjSgnE0?t=00h37m36s)

[from your master branch](https://youtu.be/ATjXcjSgnE0?t=00h37m38s)

[in general it's best to create a new](https://youtu.be/ATjXcjSgnE0?t=00h37m40s)

[branch for every bit of work that you](https://youtu.be/ATjXcjSgnE0?t=00h37m42s)

[want to work on](https://youtu.be/ATjXcjSgnE0?t=00h37m44s)

[um effectively leaving your master](https://youtu.be/ATjXcjSgnE0?t=00h37m45s)

[branch free of euro](https://youtu.be/ATjXcjSgnE0?t=00h37m47s)

[of your custom changes and putting those](https://youtu.be/ATjXcjSgnE0?t=00h37m49s)

[on extra branches that way it's easier](https://youtu.be/ATjXcjSgnE0?t=00h37m51s)

[to create pull requests later to merge](https://youtu.be/ATjXcjSgnE0?t=00h37m53s)

[them in](https://youtu.be/ATjXcjSgnE0?t=00h37m54s)

[now that we've got our branch and right](https://youtu.be/ATjXcjSgnE0?t=00h37m56s)

[now we're currently perfectly in sync](https://youtu.be/ATjXcjSgnE0?t=00h37m58s)

[with master on this commit](https://youtu.be/ATjXcjSgnE0?t=00h37m59s)

[we are then going to do go and see if we](https://youtu.be/ATjXcjSgnE0?t=00h38m01s)

[can fix this](https://youtu.be/ATjXcjSgnE0?t=00h38m04s)

[this sounds like something that needs to](https://youtu.be/ATjXcjSgnE0?t=00h38m07s)

[be fixed](https://youtu.be/ATjXcjSgnE0?t=00h38m09s)

[hello visual studio](https://youtu.be/ATjXcjSgnE0?t=00h38m11s)

[what are you doing wake up for me thank](https://youtu.be/ATjXcjSgnE0?t=00h38m15s)

[you okay](https://youtu.be/ATjXcjSgnE0?t=00h38m17s)

[step one let's reproduce the bug](https://youtu.be/ATjXcjSgnE0?t=00h38m19s)

[because i think that's that is probably](https://youtu.be/ATjXcjSgnE0?t=00h38m22s)

[the most important step](https://youtu.be/ATjXcjSgnE0?t=00h38m25s)

[in any bug is making sure it accurately](https://youtu.be/ATjXcjSgnE0?t=00h38m26s)

[reproduces](https://youtu.be/ATjXcjSgnE0?t=00h38m30s)

[or at least knowing what to do to](https://youtu.be/ATjXcjSgnE0?t=00h38m32s)

[reproduce especially in this library](https://youtu.be/ATjXcjSgnE0?t=00h38m33s)

[sometimes that is not always trivial](https://youtu.be/ATjXcjSgnE0?t=00h38m35s)

[but i looked at this bug when it came in](https://youtu.be/ATjXcjSgnE0?t=00h38m38s)

[and it was pretty trivial to reproduce](https://youtu.be/ATjXcjSgnE0?t=00h38m40s)

[as i recall](https://youtu.be/ATjXcjSgnE0?t=00h38m42s)

[so i'm gonna go here](https://youtu.be/ATjXcjSgnE0?t=00h38m46s)

[because i think this this one accurately](https://youtu.be/ATjXcjSgnE0?t=00h38m49s)

[reproduces](https://youtu.be/ATjXcjSgnE0?t=00h38m51s)

[so selection unit cell and i think this](https://youtu.be/ATjXcjSgnE0?t=00h38m53s)

[is where i had done it before](https://youtu.be/ATjXcjSgnE0?t=00h38m55s)

[so let's go to the grids one and i'm](https://youtu.be/ATjXcjSgnE0?t=00h38m58s)

[gonna just close live visual tree](https://youtu.be/ATjXcjSgnE0?t=00h39m00s)

[because it is](https://youtu.be/ATjXcjSgnE0?t=00h39m01s)

[and i'm gonna close youtube because you](https://youtu.be/ATjXcjSgnE0?t=00h39m03s)

[are both just getting in my way](https://youtu.be/ATjXcjSgnE0?t=00h39m05s)

[okay and we are going to come down here](https://youtu.be/ATjXcjSgnE0?t=00h39m07s)

[and actually i'm gonna close the](https://youtu.be/ATjXcjSgnE0?t=00h39m09s)

[diagnostic tools because i am not doing](https://youtu.be/ATjXcjSgnE0?t=00h39m10s)

[diagnostics right now](https://youtu.be/ATjXcjSgnE0?t=00h39m12s)

[just i will i will open you when i need](https://youtu.be/ATjXcjSgnE0?t=00h39m15s)

[you](https://youtu.be/ATjXcjSgnE0?t=00h39m18s)

[okay data grids okay and let's go down](https://youtu.be/ATjXcjSgnE0?t=00h39m19s)

[and find the auto generated columns one](https://youtu.be/ATjXcjSgnE0?t=00h39m21s)

[so not the first grid neurodues](https://youtu.be/ATjXcjSgnE0?t=00h39m25s)

[okay so selection unit](https://youtu.be/ATjXcjSgnE0?t=00h39m29s)

[full row okay so we come over here and](https://youtu.be/ATjXcjSgnE0?t=00h39m33s)

[we go](https://youtu.be/ATjXcjSgnE0?t=00h39m37s)

[boom](https://youtu.be/ATjXcjSgnE0?t=00h39m40s)

[this bug might be very easy](https://youtu.be/ATjXcjSgnE0?t=00h39m45s)

[it is interesting that it's letting me](https://youtu.be/ATjXcjSgnE0?t=00h39m52s)

[do](https://youtu.be/ATjXcjSgnE0?t=00h39m54s)

[that's letting me select in](https://youtu.be/ATjXcjSgnE0?t=00h39m59s)

[i am a little interested in that so](https://youtu.be/ATjXcjSgnE0?t=00h40m16s)

[let's compare this against](https://youtu.be/ATjXcjSgnE0?t=00h40m18s)

[the behavior of the previous one so i](https://youtu.be/ATjXcjSgnE0?t=00h40m20s)

[believe that issue](https://youtu.be/ATjXcjSgnE0?t=00h40m23s)

[called out three one three](https://youtu.be/ATjXcjSgnE0?t=00h40m25s)

[demo works well with three one three so](https://youtu.be/ATjXcjSgnE0?t=00h40m28s)

[let's go grab three one three's demo app](https://youtu.be/ATjXcjSgnE0?t=00h40m30s)

[so if we come over here releases](https://youtu.be/ATjXcjSgnE0?t=00h40m32s)

[and we can come down here three two](https://youtu.be/ATjXcjSgnE0?t=00h40m39s)

[three one three assets demo app](https://youtu.be/ATjXcjSgnE0?t=00h40m42s)

[so we can just go and download it and we](https://youtu.be/ATjXcjSgnE0?t=00h40m45s)

[can try it out so i will say](https://youtu.be/ATjXcjSgnE0?t=00h40m47s)

[the the pipelines are really good at](https://youtu.be/ATjXcjSgnE0?t=00h40m49s)

[putting in most of this stuff](https://youtu.be/ATjXcjSgnE0?t=00h40m51s)

[it doesn't do the demo app automatically](https://youtu.be/ATjXcjSgnE0?t=00h40m53s)

[for me i apologize the number of times](https://youtu.be/ATjXcjSgnE0?t=00h40m55s)

[i've had a release go out where i have](https://youtu.be/ATjXcjSgnE0?t=00h40m57s)

[not uploaded the demo app](https://youtu.be/ATjXcjSgnE0?t=00h40m59s)

[very very sorry so if if you see me do a](https://youtu.be/ATjXcjSgnE0?t=00h41m02s)

[release and you don't see the demo app](https://youtu.be/ATjXcjSgnE0?t=00h41m05s)

[um attached to it feel free to poke me](https://youtu.be/ATjXcjSgnE0?t=00h41m07s)

[and um](https://youtu.be/ATjXcjSgnE0?t=00h41m09s)

[ask for it because it should get](https://youtu.be/ATjXcjSgnE0?t=00h41m10s)

[attached there's no reason not to](https://youtu.be/ATjXcjSgnE0?t=00h41m13s)

[include it](https://youtu.be/ATjXcjSgnE0?t=00h41m14s)

[it's just it's a manual step so it](https://youtu.be/ATjXcjSgnE0?t=00h41m18s)

[it often times with as as with many](https://youtu.be/ATjXcjSgnE0?t=00h41m22s)

[manual steps](https://youtu.be/ATjXcjSgnE0?t=00h41m24s)

[gets forgotten because it was mildly](https://youtu.be/ATjXcjSgnE0?t=00h41m26s)

[difficult i want to change that](https://youtu.be/ATjXcjSgnE0?t=00h41m28s)

[um but at the same time i also want to](https://youtu.be/ATjXcjSgnE0?t=00h41m29s)

[switch from azure devops pipelines into](https://youtu.be/ATjXcjSgnE0?t=00h41m31s)

[github](https://youtu.be/ATjXcjSgnE0?t=00h41m33s)

[actions i need to](https://youtu.be/ATjXcjSgnE0?t=00h41m34s)

[poke the original author to get the](https://youtu.be/ATjXcjSgnE0?t=00h41m39s)

[appropriate secrets created for me](https://youtu.be/ATjXcjSgnE0?t=00h41m41s)

[though](https://youtu.be/ATjXcjSgnE0?t=00h41m42s)

[because we all of the secrets that i](https://youtu.be/ATjXcjSgnE0?t=00h41m43s)

[need for like uploading nuget packages](https://youtu.be/ATjXcjSgnE0?t=00h41m45s)

[have not been created in the repo](https://youtu.be/ATjXcjSgnE0?t=00h41m46s)

[so that's i know we are doing grids now](https://youtu.be/ATjXcjSgnE0?t=00h41m48s)

[so there is](https://youtu.be/ATjXcjSgnE0?t=00h41m55s)

[oh this one doesn't have the selection](https://youtu.be/ATjXcjSgnE0?t=00h41m58s)

[mode set](https://youtu.be/ATjXcjSgnE0?t=00h42m01s)

[well that's fine we can change that](https://youtu.be/ATjXcjSgnE0?t=00h42m02s)

[yay snoop okay so come in here](https://youtu.be/ATjXcjSgnE0?t=00h42m05s)

[and i want to go up to the data grid](https://youtu.be/ATjXcjSgnE0?t=00h42m09s)

[we're going to come over here we're](https://youtu.be/ATjXcjSgnE0?t=00h42m12s)

[going to go with selection mode](https://youtu.be/ATjXcjSgnE0?t=00h42m13s)

[and or selection unit full row](https://youtu.be/ATjXcjSgnE0?t=00h42m16s)

[oh and it could be the selection mode](https://youtu.be/ATjXcjSgnE0?t=00h42m22s)

[that's messing with me](https://youtu.be/ATjXcjSgnE0?t=00h42m23s)

[yeah so that is one interesting](https://youtu.be/ATjXcjSgnE0?t=00h42m39s)

[interesting bit](https://youtu.be/ATjXcjSgnE0?t=00h42m42s)

[so just putting these things here and](https://youtu.be/ATjXcjSgnE0?t=00h42m44s)

[let's make it light mode](https://youtu.be/ATjXcjSgnE0?t=00h42m46s)

[or actually dark mode is the new one](https://youtu.be/ATjXcjSgnE0?t=00h42m48s)

[light mode is the old one](https://youtu.be/ATjXcjSgnE0?t=00h42m49s)

[we'll just put those on](https://youtu.be/ATjXcjSgnE0?t=00h42m51s)

[so just comparing these guys a little](https://youtu.be/ATjXcjSgnE0?t=00h42m55s)

[bit this one](https://youtu.be/ATjXcjSgnE0?t=00h42m57s)

[you click and it immediately puts you in](https://youtu.be/ATjXcjSgnE0?t=00h42m58s)

[edit mode](https://youtu.be/ATjXcjSgnE0?t=00h43m00s)

[which is convenient but doesn't mean it](https://youtu.be/ATjXcjSgnE0?t=00h43m02s)

[takes a second click to get the row](https://youtu.be/ATjXcjSgnE0?t=00h43m04s)

[selected](https://youtu.be/ATjXcjSgnE0?t=00h43m10s)

[so if you click on an editable text](https://youtu.be/ATjXcjSgnE0?t=00h43m19s)

[field](https://youtu.be/ATjXcjSgnE0?t=00h43m24s)

[because it does feel weird that you can](https://youtu.be/ATjXcjSgnE0?t=00h43m28s)

[go into edit mode on one](https://youtu.be/ATjXcjSgnE0?t=00h43m29s)

[now i do wonder though if](https://youtu.be/ATjXcjSgnE0?t=00h43m31s)

[so let's let's change that too or](https://youtu.be/ATjXcjSgnE0?t=00h43m35s)

[actually we can change this one in](https://youtu.be/ATjXcjSgnE0?t=00h43m38s)

[visual studio](https://youtu.be/ATjXcjSgnE0?t=00h43m39s)

[um selection mode](https://youtu.be/ATjXcjSgnE0?t=00h43m41s)

[single i wonder if that extended mode is](https://youtu.be/ATjXcjSgnE0?t=00h43m45s)

[what's giving us that behavior](https://youtu.be/ATjXcjSgnE0?t=00h43m48s)

[fact set in](https://youtu.be/ATjXcjSgnE0?t=00h44m03s)

[normally you should be able to hold down](https://youtu.be/ATjXcjSgnE0?t=00h44m08s)

[control](https://youtu.be/ATjXcjSgnE0?t=00h44m09s)

[okay so we've got some selection issues](https://youtu.be/ATjXcjSgnE0?t=00h44m13s)

[going on](https://youtu.be/ATjXcjSgnE0?t=00h44m15s)

[because i should be able to hold down](https://youtu.be/ATjXcjSgnE0?t=00h44m16s)

[control and get multiple selected](https://youtu.be/ATjXcjSgnE0?t=00h44m18s)

[or even if the first one is selected](https://youtu.be/ATjXcjSgnE0?t=00h44m22s)

[like here right i should be able to go](https://youtu.be/ATjXcjSgnE0?t=00h44m23s)

[shift](https://youtu.be/ATjXcjSgnE0?t=00h44m25s)

[click and get them all so this guy here](https://youtu.be/ATjXcjSgnE0?t=00h44m26s)

[shift click and i don't get them all](https://youtu.be/ATjXcjSgnE0?t=00h44m29s)

[um oh but i set this back to single so](https://youtu.be/ATjXcjSgnE0?t=00h44m33s)

[back to extended all right so](https://youtu.be/ATjXcjSgnE0?t=00h44m37s)

[here shift click](https://youtu.be/ATjXcjSgnE0?t=00h44m40s)

[oh yeah i guess it does work just turns](https://youtu.be/ATjXcjSgnE0?t=00h44m45s)

[out if you turn it off it behaves as](https://youtu.be/ATjXcjSgnE0?t=00h44m49s)

[designed](https://youtu.be/ATjXcjSgnE0?t=00h44m50s)

[it's just weird that i can get into here](https://youtu.be/ATjXcjSgnE0?t=00h44m53s)

[and get this guy](https://youtu.be/ATjXcjSgnE0?t=00h44m54s)

[there without being selected](https://youtu.be/ATjXcjSgnE0?t=00h44m56s)

[so i think that bit there it's so the](https://youtu.be/ATjXcjSgnE0?t=00h45m01s)

[bug has slightly changed since it was](https://youtu.be/ATjXcjSgnE0?t=00h45m04s)

[posted](https://youtu.be/ATjXcjSgnE0?t=00h45m05s)

[but it is it is still relevant so](https://youtu.be/ATjXcjSgnE0?t=00h45m10s)

[see if we can find what's doing that](https://youtu.be/ATjXcjSgnE0?t=00h45m14s)

[so let's go](https://youtu.be/ATjXcjSgnE0?t=00h45m22s)

[wpf theme themes](https://youtu.be/ATjXcjSgnE0?t=00h45m25s)

[data grid and it's probably going to be](https://youtu.be/ATjXcjSgnE0?t=00h45m29s)

[something like the text box or something](https://youtu.be/ATjXcjSgnE0?t=00h45m33s)

[this is the style so what triggers you](https://youtu.be/ATjXcjSgnE0?t=00h45m37s)

[data grid assist auto generated editing](https://youtu.be/ATjXcjSgnE0?t=00h45m44s)

[text style](https://youtu.be/ATjXcjSgnE0?t=00h45m47s)

[so that that](https://youtu.be/ATjXcjSgnE0?t=00h45m48s)

[is probably what's doing this is what it](https://youtu.be/ATjXcjSgnE0?t=00h45m53s)

[one of these attached properties](https://youtu.be/ATjXcjSgnE0?t=00h45m57s)

[so i'm going to go with we're hitting a](https://youtu.be/ATjXcjSgnE0?t=00h46m07s)

[begin edit call](https://youtu.be/ATjXcjSgnE0?t=00h46m10s)

[somewhere in here so let's just grab](https://youtu.be/ATjXcjSgnE0?t=00h46m12s)

[break points on all of them](https://youtu.be/ATjXcjSgnE0?t=00h46m14s)

[oh so there's two excellent](https://youtu.be/ATjXcjSgnE0?t=00h46m17s)

[that one](https://youtu.be/ATjXcjSgnE0?t=00h46m23s)

[okay so i would like to](https://youtu.be/ATjXcjSgnE0?t=00h46m36s)

[i think what this is as simple as](https://youtu.be/ATjXcjSgnE0?t=00h46m40s)

[um](https://youtu.be/ATjXcjSgnE0?t=00h46m44s)

[hoping for a](https://youtu.be/ATjXcjSgnE0?t=00h46m52s)

[and i was kind of hoping to](https://youtu.be/ATjXcjSgnE0?t=00h47m00s)

[um so let's see this does a begin edit](https://youtu.be/ATjXcjSgnE0?t=00h47m05s)

[this sends that](https://youtu.be/ATjXcjSgnE0?t=00h47m10s)

[what is the entry point here allow](https://youtu.be/ATjXcjSgnE0?t=00h47m14s)

[direct edit without](https://youtu.be/ATjXcjSgnE0?t=00h47m17s)

[focus](https://youtu.be/ATjXcjSgnE0?t=00h47m22s)

[uh so what if find all references](https://youtu.be/ATjXcjSgnE0?t=00h47m25s)

[so this definitely does that](https://youtu.be/ATjXcjSgnE0?t=00h47m35s)

[but should it](https://youtu.be/ATjXcjSgnE0?t=00h47m39s)

[element render size](https://youtu.be/ATjXcjSgnE0?t=00h47m50s)

[so that's what's doing it](https://youtu.be/ATjXcjSgnE0?t=00h48m08s)

[okay and](https://youtu.be/ATjXcjSgnE0?t=00h48m14s)

[i'm thinking](https://youtu.be/ATjXcjSgnE0?t=00h48m18s)

[let's let's look at the annotate on this](https://youtu.be/ATjXcjSgnE0?t=00h48m22s)

[real quick because i'm curious](https://youtu.be/ATjXcjSgnE0?t=00h48m26s)

[i i remember an issue coming through](https://youtu.be/ATjXcjSgnE0?t=00h48m28s)

[about this](https://youtu.be/ATjXcjSgnE0?t=00h48m30s)

[um and i have a sinking suspicion this](https://youtu.be/ATjXcjSgnE0?t=00h48m32s)

[was](https://youtu.be/ATjXcjSgnE0?t=00h48m35s)

[uh see 1954.](https://youtu.be/ATjXcjSgnE0?t=00h48m37s)

[yeah let's go before we before we go and](https://youtu.be/ATjXcjSgnE0?t=00h48m43s)

[just break this](https://youtu.be/ATjXcjSgnE0?t=00h48m46s)

[let's look at what the](https://youtu.be/ATjXcjSgnE0?t=00h48m47s)

[let's look at what this one used to be](https://youtu.be/ATjXcjSgnE0?t=00h48m50s)

[uh let's see following refactoring](https://youtu.be/ATjXcjSgnE0?t=00h48m59s)

[so i'm curious why it doesn't allow](https://youtu.be/ATjXcjSgnE0?t=00h49m32s)

[okay so we're gonna we're gonna try some](https://youtu.be/ATjXcjSgnE0?t=00h49m37s)

[things i'm not](https://youtu.be/ATjXcjSgnE0?t=00h49m39s)

[sure](https://youtu.be/ATjXcjSgnE0?t=00h49m42s)

[new mouse event args](https://youtu.be/ATjXcjSgnE0?t=00h49m48s)

[i kind of want to do this for](https://youtu.be/ATjXcjSgnE0?t=00h49m55s)

[just a moment and see if this is what's](https://youtu.be/ATjXcjSgnE0?t=00h49m58s)

[causing the change in behavior](https://youtu.be/ATjXcjSgnE0?t=00h50m00s)

[now obviously the click isn't going to](https://youtu.be/ATjXcjSgnE0?t=00h50m04s)

[work](https://youtu.be/ATjXcjSgnE0?t=00h50m07s)

[but i am curious if it is in relation to](https://youtu.be/ATjXcjSgnE0?t=00h50m08s)

[this toggle occurring](https://youtu.be/ATjXcjSgnE0?t=00h50m11s)

[or something else](https://youtu.be/ATjXcjSgnE0?t=00h50m16s)

[turn you off](https://youtu.be/ATjXcjSgnE0?t=00h50m23s)

[okay so that seems to be what's doing it](https://youtu.be/ATjXcjSgnE0?t=00h50m33s)

[and i kind of want to chase the mouse](https://youtu.be/ATjXcjSgnE0?t=00h50m36s)

[events here real quick](https://youtu.be/ATjXcjSgnE0?t=00h50m38s)

[so if i go click](https://youtu.be/ATjXcjSgnE0?t=00h50m40s)

[so preview mouse down goes and then](https://youtu.be/ATjXcjSgnE0?t=00h50m45s)

[mouse down](https://youtu.be/ATjXcjSgnE0?t=00h50m48s)

[gets handled by the data grid cell and](https://youtu.be/ATjXcjSgnE0?t=00h50m50s)

[that's what ultimately does this](https://youtu.be/ATjXcjSgnE0?t=00h50m52s)

[okay so now i want to put the code back](https://youtu.be/ATjXcjSgnE0?t=00h50m54s)

[and see what change to that event](https://youtu.be/ATjXcjSgnE0?t=00h51m00s)

[hierarchy happens](https://youtu.be/ATjXcjSgnE0?t=00h51m01s)

[i have a sinking suspicion that](https://youtu.be/ATjXcjSgnE0?t=00h51m05s)

[this because this guy is now in an edit](https://youtu.be/ATjXcjSgnE0?t=00h51m08s)

[mode](https://youtu.be/ATjXcjSgnE0?t=00h51m10s)

[and it that was triggered from a preview](https://youtu.be/ATjXcjSgnE0?t=00h51m11s)

[event which is tunneling not bubbling](https://youtu.be/ATjXcjSgnE0?t=00h51m13s)

[that the bubbling event now gets handled](https://youtu.be/ATjXcjSgnE0?t=00h51m16s)

[differently](https://youtu.be/ATjXcjSgnE0?t=00h51m18s)

[that is my working theory](https://youtu.be/ATjXcjSgnE0?t=00h51m19s)

[oh i gotta put this back](https://youtu.be/ATjXcjSgnE0?t=00h51m27s)

[events](https://youtu.be/ATjXcjSgnE0?t=00h51m34s)

[yeah see very](https://youtu.be/ATjXcjSgnE0?t=00h51m43s)

[different event pattern because of that](https://youtu.be/ATjXcjSgnE0?t=00h51m46s)

[because of that](https://youtu.be/ATjXcjSgnE0?t=00h51m51s)

[i'm wondering if i defer them](https://youtu.be/ATjXcjSgnE0?t=00h52m08s)

[if that will make a difference](https://youtu.be/ATjXcjSgnE0?t=00h52m18s)

[uh](https://youtu.be/ATjXcjSgnE0?t=00h52m21s)

[see if that does anything and](https://youtu.be/ATjXcjSgnE0?t=00h52m28s)

[auto code button apply code](https://youtu.be/ATjXcjSgnE0?t=00h52m31s)

[oh boo stop so](https://youtu.be/ATjXcjSgnE0?t=00h52m35s)

[in case people didn't missed it that](https://youtu.be/ATjXcjSgnE0?t=00h52m38s)

[little fire icon](https://youtu.be/ATjXcjSgnE0?t=00h52m40s)

[is what used to be the edit and continue](https://youtu.be/ATjXcjSgnE0?t=00h52m41s)

[from uh previous versions](https://youtu.be/ATjXcjSgnE0?t=00h52m45s)

[so it has made a resurgence and](https://youtu.be/ATjXcjSgnE0?t=00h52m49s)

[quite often times depending on what](https://youtu.be/ATjXcjSgnE0?t=00h52m52s)

[you're editing and where](https://youtu.be/ATjXcjSgnE0?t=00h52m54s)

[before the restriction was you had to](https://youtu.be/ATjXcjSgnE0?t=00h52m56s)

[hit a breakpoint pause execution make](https://youtu.be/ATjXcjSgnE0?t=00h52m58s)

[your changes and then it would try](https://youtu.be/ATjXcjSgnE0?t=00h53m00s)

[because you were already stopped the ide](https://youtu.be/ATjXcjSgnE0?t=00h53m01s)

[would attempt to](https://youtu.be/ATjXcjSgnE0?t=00h53m04s)

[update and inject the changes for you](https://youtu.be/ATjXcjSgnE0?t=00h53m06s)

[now you don't have any of that you just](https://youtu.be/ATjXcjSgnE0?t=00h53m08s)

[write your changes and click the little](https://youtu.be/ATjXcjSgnE0?t=00h53m10s)

[fire button](https://youtu.be/ATjXcjSgnE0?t=00h53m12s)

[and if he can apply him it will which is](https://youtu.be/ATjXcjSgnE0?t=00h53m14s)

[great](https://youtu.be/ATjXcjSgnE0?t=00h53m16s)

[just great great great great great](https://youtu.be/ATjXcjSgnE0?t=00h53m17s)

[exactly what we love](https://youtu.be/ATjXcjSgnE0?t=00h53m20s)

[so that's](https://youtu.be/ATjXcjSgnE0?t=00h53m35s)

[so that's now very worse](https://youtu.be/ATjXcjSgnE0?t=00h53m40s)

[okay so that's that's definitely not a](https://youtu.be/ATjXcjSgnE0?t=00h53m52s)

[good good solution](https://youtu.be/ATjXcjSgnE0?t=00h53m54s)

[so what if we do](https://youtu.be/ATjXcjSgnE0?t=00h53m56s)

[data grid selected cells](https://youtu.be/ATjXcjSgnE0?t=00h54m00s)

[and i'm so i'm a little hesitant to do](https://youtu.be/ATjXcjSgnE0?t=00h54m04s)

[this](https://youtu.be/ATjXcjSgnE0?t=00h54m08s)

[and just blindly add it](https://youtu.be/ATjXcjSgnE0?t=00h54m10s)

[i'm worried that will you apply no](https://youtu.be/ATjXcjSgnE0?t=00h54m16s)

[yeah depending on where what method](https://youtu.be/ATjXcjSgnE0?t=00h54m20s)

[you're in i've noticed that the the](https://youtu.be/ATjXcjSgnE0?t=00h54m22s)

[fire button works it's very conditional](https://youtu.be/ATjXcjSgnE0?t=00h54m24s)

[on the method and](https://youtu.be/ATjXcjSgnE0?t=00h54m26s)

[where um that method is so certain](https://youtu.be/ATjXcjSgnE0?t=00h54m27s)

[methods and areas it works great on](https://youtu.be/ATjXcjSgnE0?t=00h54m30s)

[other ones it just falls over](https://youtu.be/ATjXcjSgnE0?t=00h54m31s)

[so i'm a little concerned with this](https://youtu.be/ATjXcjSgnE0?t=00h54m34s)

[[Music]](https://youtu.be/ATjXcjSgnE0?t=00h54m40s)

[simply because the just](https://youtu.be/ATjXcjSgnE0?t=00h54m43s)

[blindly adding to the selection](https://youtu.be/ATjXcjSgnE0?t=00h54m47s)

[i assume needs to be excuse me more](https://youtu.be/ATjXcjSgnE0?t=00h54m50s)

[intelligent](https://youtu.be/ATjXcjSgnE0?t=00h54m54s)

[uh can i](https://youtu.be/ATjXcjSgnE0?t=00h54m57s)

[yeah um](https://youtu.be/ATjXcjSgnE0?t=00h55m02s)

[yeah i'm kind of thinking that](https://youtu.be/ATjXcjSgnE0?t=00h55m37s)

[okay so we want to get the thing in](https://youtu.be/ATjXcjSgnE0?t=00h55m42s)

[to edit mode but we want to get the](https://youtu.be/ATjXcjSgnE0?t=00h55m45s)

[selection to change as well](https://youtu.be/ATjXcjSgnE0?t=00h55m48s)

[where does this data grid cell come from](https://youtu.be/ATjXcjSgnE0?t=00h56m13s)

[because the possible selection modes](https://youtu.be/ATjXcjSgnE0?t=00h56m27s)

[that we have](https://youtu.be/ATjXcjSgnE0?t=00h56m29s)

[i'm just a little hesitant to go through](https://youtu.be/ATjXcjSgnE0?t=00h56m41s)

[and and do this based on selection when](https://youtu.be/ATjXcjSgnE0?t=00h56m43s)

[i don't know for certain that that](https://youtu.be/ATjXcjSgnE0?t=00h56m45s)

[is](https://youtu.be/ATjXcjSgnE0?t=00h56m47s)

[man i just wish i could defer this until](https://youtu.be/ATjXcjSgnE0?t=00h56m57s)

[i knew that the](https://youtu.be/ATjXcjSgnE0?t=00h56m59s)

[so let me let's go let's go and look at](https://youtu.be/ATjXcjSgnE0?t=00h57m05s)

[this because this guy apparently handled](https://youtu.be/ATjXcjSgnE0?t=00h57m07s)

[the](https://youtu.be/ATjXcjSgnE0?t=00h57m09s)

[the mouse click which means it's](https://youtu.be/ATjXcjSgnE0?t=00h57m11s)

[probably registering for](https://youtu.be/ATjXcjSgnE0?t=00h57m13s)

[the mouse event somewhere or this](https://youtu.be/ATjXcjSgnE0?t=00h57m19s)

[container tracking dude might do it](https://youtu.be/ATjXcjSgnE0?t=00h57m21s)

[what do you do container tracking start](https://youtu.be/ATjXcjSgnE0?t=00h57m24s)

[tracking](https://youtu.be/ATjXcjSgnE0?t=00h57m28s)

[that is not quite what i anticipated you](https://youtu.be/ATjXcjSgnE0?t=00h57m30s)

[being](https://youtu.be/ATjXcjSgnE0?t=00h57m33s)

[never mind let's go back data grid cell](https://youtu.be/ATjXcjSgnE0?t=00h57m34s)

[so there's got to be something in here](https://youtu.be/ATjXcjSgnE0?t=00h57m40s)

[about mouse](https://youtu.be/ATjXcjSgnE0?t=00h57m41s)

[something another because you handled](https://youtu.be/ATjXcjSgnE0?t=00h57m43s)

[on any mouse button down thunk](https://youtu.be/ATjXcjSgnE0?t=00h57m46s)

[let me guess you're an internal method](https://youtu.be/ATjXcjSgnE0?t=00h58m01s)

[handle selection for cell input](https://youtu.be/ATjXcjSgnE0?t=00h58m06s)

[yeah that's](https://youtu.be/ATjXcjSgnE0?t=00h58m10s)

[oh interesting so if keyboard focus is](https://youtu.be/ATjXcjSgnE0?t=00h58m33s)

[already there](https://youtu.be/ATjXcjSgnE0?t=00h58m35s)

[ah ah](https://youtu.be/ATjXcjSgnE0?t=00h58m38s)

[okay okay i got you i got you](https://youtu.be/ATjXcjSgnE0?t=00h58m42s)

[uh data grid cell](https://youtu.be/ATjXcjSgnE0?t=00h58m49s)

[focus](https://youtu.be/ATjXcjSgnE0?t=00h58m53s)

[because i'm wondering](https://youtu.be/ATjXcjSgnE0?t=00h58m56s)

[yeah because it just calls focus on the](https://youtu.be/ATjXcjSgnE0?t=00h59m02s)

[cell](https://youtu.be/ATjXcjSgnE0?t=00h59m04s)

[ah i wonder if we can cheat it let's try](https://youtu.be/ATjXcjSgnE0?t=00h59m06s)

[this](https://youtu.be/ATjXcjSgnE0?t=00h59m09s)

[this might be a slightly sneakier fix](https://youtu.be/ATjXcjSgnE0?t=00h59m15s)

[so my thought is that if we focus on the](https://youtu.be/ATjXcjSgnE0?t=00h59m19s)

[preview event](https://youtu.be/ATjXcjSgnE0?t=00h59m22s)

[so the tunneling event when the bubbling](https://youtu.be/ATjXcjSgnE0?t=00h59m24s)

[event starts working its way back](https://youtu.be/ATjXcjSgnE0?t=00h59m27s)

[up it'll already have keyboard focus and](https://youtu.be/ATjXcjSgnE0?t=00h59m28s)

[therefore toggle and edit mode](https://youtu.be/ATjXcjSgnE0?t=00h59m32s)

[giving the same behavior but now](https://youtu.be/ATjXcjSgnE0?t=00h59m33s)

[appropriately allowing the](https://youtu.be/ATjXcjSgnE0?t=00h59m36s)

[data grid to handle the right events for](https://youtu.be/ATjXcjSgnE0?t=00h59m37s)

[selection](https://youtu.be/ATjXcjSgnE0?t=00h59m40s)

[for us that's the theory](https://youtu.be/ATjXcjSgnE0?t=00h59m41s)

[let's test there](https://youtu.be/ATjXcjSgnE0?t=00h59m45s)

[i mean it puts us back to previous](https://youtu.be/ATjXcjSgnE0?t=00h59m56s)

[behavior](https://youtu.be/ATjXcjSgnE0?t=00h59m58s)

[which is good](https://youtu.be/ATjXcjSgnE0?t=01h00m00s)

[but i mean i could have gotten that with](https://youtu.be/ATjXcjSgnE0?t=01h00m09s)

[without that](https://youtu.be/ATjXcjSgnE0?t=01h00m12s)

[if i go here](https://youtu.be/ATjXcjSgnE0?t=01h00m24s)

[so let's see so the let's start with](https://youtu.be/ATjXcjSgnE0?t=01h00m34s)

[this](https://youtu.be/ATjXcjSgnE0?t=01h00m40s)

[okay so clear all that out so if i do](https://youtu.be/ATjXcjSgnE0?t=01h00m43s)

[click](https://youtu.be/ATjXcjSgnE0?t=01h00m47s)

[mouse down on text blocks handled by](https://youtu.be/ATjXcjSgnE0?t=01h00m50s)

[data grid cell](https://youtu.be/ATjXcjSgnE0?t=01h00m52s)

[i click again mouse left down on text](https://youtu.be/ATjXcjSgnE0?t=01h00m53s)

[blocks handle by data grid cell](https://youtu.be/ATjXcjSgnE0?t=01h00m58s)

[begin edit by data grid cell](https://youtu.be/ATjXcjSgnE0?t=01h01m05s)

[so](https://youtu.be/ATjXcjSgnE0?t=01h01m22s)

[just gonna relaunch i am curious if i](https://youtu.be/ATjXcjSgnE0?t=01h01m41s)

[can](https://youtu.be/ATjXcjSgnE0?t=01h01m45s)

[get it](https://youtu.be/ATjXcjSgnE0?t=01h01m45s)

[to work here](https://youtu.be/ATjXcjSgnE0?t=01h01m50s)

[okay](https://youtu.be/ATjXcjSgnE0?t=01h01m59s)

[data grid](https://youtu.be/ATjXcjSgnE0?t=01h02m04s)

[no so](https://youtu.be/ATjXcjSgnE0?t=01h02m08s)

[i guess what i really want to see is](https://youtu.be/ATjXcjSgnE0?t=01h02m11s)

[right here](https://youtu.be/ATjXcjSgnE0?t=01h02m12s)

[because it's reliant on is keyboard](https://youtu.be/ATjXcjSgnE0?t=01h02m15s)

[focus within](https://youtu.be/ATjXcjSgnE0?t=01h02m18s)

[so let's just uh](https://youtu.be/ATjXcjSgnE0?t=01h02m28s)

[thinks that's true](https://youtu.be/ATjXcjSgnE0?t=01h02m40s)

[oh but is is it selected](https://youtu.be/ATjXcjSgnE0?t=01h02m47s)

[is it selected](https://youtu.be/ATjXcjSgnE0?t=01h02m56s)

[false](https://youtu.be/ATjXcjSgnE0?t=01h03m14s)

[let's try this one more time one more](https://youtu.be/ATjXcjSgnE0?t=01h03m18s)

[time](https://youtu.be/ATjXcjSgnE0?t=01h03m21s)

[i don't again i i'm not 100 confident](https://youtu.be/ATjXcjSgnE0?t=01h03m24s)

[exactly how this is going to work but](https://youtu.be/ATjXcjSgnE0?t=01h03m26s)

[we can see that the mouse button down](https://youtu.be/ATjXcjSgnE0?t=01h03m29s)

[handler here](https://youtu.be/ATjXcjSgnE0?t=01h03m31s)

[the conditions that cause it to call](https://youtu.be/ATjXcjSgnE0?t=01h03m33s)

[begin](https://youtu.be/ATjXcjSgnE0?t=01h03m35s)

[edit are reliant upon keyboard focus](https://youtu.be/ATjXcjSgnE0?t=01h03m36s)

[being within](https://youtu.be/ATjXcjSgnE0?t=01h03m39s)

[and is selected being true](https://youtu.be/ATjXcjSgnE0?t=01h03m40s)

[so those are the conditions we are](https://youtu.be/ATjXcjSgnE0?t=01h03m45s)

[attempting to replicate](https://youtu.be/ATjXcjSgnE0?t=01h03m46s)

[okay so there](https://youtu.be/ATjXcjSgnE0?t=01h03m48s)

[okay so this getter and the setter of](https://youtu.be/ATjXcjSgnE0?t=01h03m54s)

[this must be different values](https://youtu.be/ATjXcjSgnE0?t=01h03m56s)

[get set](https://youtu.be/ATjXcjSgnE0?t=01h04m02s)

[where okay](https://youtu.be/ATjXcjSgnE0?t=01h04m06s)

[huh what is the](https://youtu.be/ATjXcjSgnE0?t=01h04m10s)

[call stack that got me here](https://youtu.be/ATjXcjSgnE0?t=01h04m14s)

[uh datagrid on selected](https://youtu.be/ATjXcjSgnE0?t=01h04m18s)

[cells changed](https://youtu.be/ATjXcjSgnE0?t=01h04m21s)

[data grid on is selected change so it's](https://youtu.be/ATjXcjSgnE0?t=01h04m25s)

[watching for the property changed on](https://youtu.be/ATjXcjSgnE0?t=01h04m29s)

[that okay](https://youtu.be/ATjXcjSgnE0?t=01h04m31s)

[so](https://youtu.be/ATjXcjSgnE0?t=01h04m52s)

[select all okay so data grids sell](https://youtu.be/ATjXcjSgnE0?t=01h04m56s)

[the fact that this method is not exposed](https://youtu.be/ATjXcjSgnE0?t=01h05m15s)

[is really annoying me](https://youtu.be/ATjXcjSgnE0?t=01h05m17s)

[is there another option here](https://youtu.be/ATjXcjSgnE0?t=01h05m36s)

[is it bad](https://youtu.be/ATjXcjSgnE0?t=01h05m43s)

[i really prefer to fix it i'd really](https://youtu.be/ATjXcjSgnE0?t=01h05m48s)

[prefer to](https://youtu.be/ATjXcjSgnE0?t=01h05m51s)

[if it would work because i wanted to go](https://youtu.be/ATjXcjSgnE0?t=01h05m52s)

[into](https://youtu.be/ATjXcjSgnE0?t=01h05m55s)

[so so what's the end goal here so on](https://youtu.be/ATjXcjSgnE0?t=01h05m56s)

[this click](https://youtu.be/ATjXcjSgnE0?t=01h05m58s)

[what we would like to do is we would](https://youtu.be/ATjXcjSgnE0?t=01h06m00s)

[like begin edit to be invoked on it](https://youtu.be/ATjXcjSgnE0?t=01h06m02s)

[we would like it to be selected](https://youtu.be/ATjXcjSgnE0?t=01h06m10s)

[and we would like keyboard focus move to](https://youtu.be/ATjXcjSgnE0?t=01h06m14s)

[it](https://youtu.be/ATjXcjSgnE0?t=01h06m16s)

[we cannot directly set is selected](https://youtu.be/ATjXcjSgnE0?t=01h06m19s)

[selected value yeah because i don't want](https://youtu.be/ATjXcjSgnE0?t=01h06m39s)

[to get into a](https://youtu.be/ATjXcjSgnE0?t=01h06m43s)

[something where i'm managing the](https://youtu.be/ATjXcjSgnE0?t=01h06m45s)

[selection mode](https://youtu.be/ATjXcjSgnE0?t=01h06m46s)

[that just sounds yucky](https://youtu.be/ATjXcjSgnE0?t=01h06m49s)

[that just sounds really really yucky](https://youtu.be/ATjXcjSgnE0?t=01h06m54s)

[i assume you're just something simple in](https://youtu.be/ATjXcjSgnE0?t=01h06m58s)

[the asher](https://youtu.be/ATjXcjSgnE0?t=01h07m00s)

[where do you get used show me your](https://youtu.be/ATjXcjSgnE0?t=01h07m02s)

[usages](https://youtu.be/ATjXcjSgnE0?t=01h07m03s)

[on selected cells changed well that just](https://youtu.be/ATjXcjSgnE0?t=01h07m09s)

[so yeah so this is the invalid off that](https://youtu.be/ATjXcjSgnE0?t=01h07m22s)

[we're hitting right here](https://youtu.be/ATjXcjSgnE0?t=01h07m23s)

[i guess the condition is really only](https://youtu.be/ATjXcjSgnE0?t=01h07m26s)

[selected row](https://youtu.be/ATjXcjSgnE0?t=01h07m28s)

[but how do i get](https://youtu.be/ATjXcjSgnE0?t=01h07m31s)

[um this guy does a lot of work in here](https://youtu.be/ATjXcjSgnE0?t=01h07m40s)

[a lot of work](https://youtu.be/ATjXcjSgnE0?t=01h07m46s)

[so the tunneling event comes down](https://youtu.be/ATjXcjSgnE0?t=01h08m03s)

[let's go back i'm wondering if maybe we](https://youtu.be/ATjXcjSgnE0?t=01h08m06s)

[can bounce the event](https://youtu.be/ATjXcjSgnE0?t=01h08m08s)

[let's let's go back so](https://youtu.be/ATjXcjSgnE0?t=01h08m11s)

[ultimately the difference in behavior](https://youtu.be/ATjXcjSgnE0?t=01h08m15s)

[comes from](https://youtu.be/ATjXcjSgnE0?t=01h08m17s)

[calling begin edit which changes out](https://youtu.be/ATjXcjSgnE0?t=01h08m19s)

[the visual tree on us](https://youtu.be/ATjXcjSgnE0?t=01h08m23s)

[because data grid cells have both an](https://youtu.be/ATjXcjSgnE0?t=01h08m27s)

[editing mode and a not editing mode or a](https://youtu.be/ATjXcjSgnE0?t=01h08m29s)

[read mode](https://youtu.be/ATjXcjSgnE0?t=01h08m31s)

[and i think some of this is coming by](https://youtu.be/ATjXcjSgnE0?t=01h08m35s)

[the fact that we are handling a preview](https://youtu.be/ATjXcjSgnE0?t=01h08m36s)

[tunneling event so i've used those terms](https://youtu.be/ATjXcjSgnE0?t=01h08m39s)

[a couple times now but just](https://youtu.be/ATjXcjSgnE0?t=01h08m42s)

[to make sure everybody's on the same](https://youtu.be/ATjXcjSgnE0?t=01h08m44s)

[page in wpf there are routed events](https://youtu.be/ATjXcjSgnE0?t=01h08m45s)

[that come in a variety of forms there's](https://youtu.be/ATjXcjSgnE0?t=01h08m48s)

[three routing modes](https://youtu.be/ATjXcjSgnE0?t=01h08m50s)

[functionally two that get used](https://youtu.be/ATjXcjSgnE0?t=01h08m51s)

[everywhere called tunneling and bubbling](https://youtu.be/ATjXcjSgnE0?t=01h08m53s)

[tunneling starts at the top typically](https://youtu.be/ATjXcjSgnE0?t=01h08m55s)

[your window](https://youtu.be/ATjXcjSgnE0?t=01h08m58s)

[and works its way down through your](https://youtu.be/ATjXcjSgnE0?t=01h08m59s)

[visual tree until it finds the target](https://youtu.be/ATjXcjSgnE0?t=01h09m00s)

[element](https://youtu.be/ATjXcjSgnE0?t=01h09m03s)

[bubbling events then turn around and](https://youtu.be/ATjXcjSgnE0?t=01h09m04s)

[bubble from that target element](https://youtu.be/ATjXcjSgnE0?t=01h09m06s)

[back up through the visual tree until](https://youtu.be/ATjXcjSgnE0?t=01h09m08s)

[they find somebody who's going to](https://youtu.be/ATjXcjSgnE0?t=01h09m10s)

[handle them so typically your tunnel](https://youtu.be/ATjXcjSgnE0?t=01h09m11s)

[leading events are going to be the](https://youtu.be/ATjXcjSgnE0?t=01h09m14s)

[preview events right](https://youtu.be/ATjXcjSgnE0?t=01h09m15s)

[so in this case preview mouse down or](https://youtu.be/ATjXcjSgnE0?t=01h09m17s)

[preview left mouse button down](https://youtu.be/ATjXcjSgnE0?t=01h09m19s)

[and then the bubbling event is going to](https://youtu.be/ATjXcjSgnE0?t=01h09m21s)

[be the mouse down event so preview](https://youtu.be/ATjXcjSgnE0?t=01h09m23s)

[events](https://youtu.be/ATjXcjSgnE0?t=01h09m25s)

[are expected to be tunneling uh regular](https://youtu.be/ATjXcjSgnE0?t=01h09m26s)

[events are expected to be bubbling](https://youtu.be/ATjXcjSgnE0?t=01h09m29s)

[and it kind of makes intuitive sense](https://youtu.be/ATjXcjSgnE0?t=01h09m32s)

[once you play around with it for a](https://youtu.be/ATjXcjSgnE0?t=01h09m34s)

[little bit](https://youtu.be/ATjXcjSgnE0?t=01h09m35s)

[so if we look at this guy here](https://youtu.be/ATjXcjSgnE0?t=01h09m40s)

[if we go events and i go click](https://youtu.be/ATjXcjSgnE0?t=01h09m44s)

[so](https://youtu.be/ATjXcjSgnE0?t=01h09m48s)

[commit edit begin](https://youtu.be/ATjXcjSgnE0?t=01h09m53s)

[edit routed command on data grid cell](https://youtu.be/ATjXcjSgnE0?t=01h09m57s)

[preview left mouse button down](https://youtu.be/ATjXcjSgnE0?t=01h10m04s)

[goes all the way down to the text block](https://youtu.be/ATjXcjSgnE0?t=01h10m07s)

[we then get a mouse down](https://youtu.be/ATjXcjSgnE0?t=01h10m14s)

[on a text block](https://youtu.be/ATjXcjSgnE0?t=01h10m20s)

[which is very very interesting so if we](https://youtu.be/ATjXcjSgnE0?t=01h10m28s)

[go and look at](https://youtu.be/ATjXcjSgnE0?t=01h10m31s)

[see this one here should have this guy](https://youtu.be/ATjXcjSgnE0?t=01h10m39s)

[if we look at our events i'm just going](https://youtu.be/ATjXcjSgnE0?t=01h10m44s)

[to clear them when i go](https://youtu.be/ATjXcjSgnE0?t=01h10m47s)

[click mouse down on text block and then](https://youtu.be/ATjXcjSgnE0?t=01h10m49s)

[it bubbles](https://youtu.be/ATjXcjSgnE0?t=01h10m53s)

[up see that](https://youtu.be/ATjXcjSgnE0?t=01h10m53s)

[i'm wondering](https://youtu.be/ATjXcjSgnE0?t=01h11m03s)

[because this one here had the mouse down](https://youtu.be/ATjXcjSgnE0?t=01h11m07s)

[event trigger](https://youtu.be/ATjXcjSgnE0?t=01h11m10s)

[but for whatever reason did not bubble](https://youtu.be/ATjXcjSgnE0?t=01h11m12s)

[up](https://youtu.be/ATjXcjSgnE0?t=01h11m14s)

[the only one who saw it was the text](https://youtu.be/ATjXcjSgnE0?t=01h11m16s)

[block](https://youtu.be/ATjXcjSgnE0?t=01h11m18s)

[and i have to believe it's because the](https://youtu.be/ATjXcjSgnE0?t=01h11m23s)

[visual tree got swapped out on them](https://youtu.be/ATjXcjSgnE0?t=01h11m24s)

[yeah it changed the visual tree so it's](https://youtu.be/ATjXcjSgnE0?t=01h11m56s)

[not there](https://youtu.be/ATjXcjSgnE0?t=01h11m59s)

[i'm wondering if we should manually](https://youtu.be/ATjXcjSgnE0?t=01h12m08s)

[trigger that event](https://youtu.be/ATjXcjSgnE0?t=01h12m11s)

[similar to like what we did here](https://youtu.be/ATjXcjSgnE0?t=01h12m26s)

[but i'm wondering if we go up](https://youtu.be/ATjXcjSgnE0?t=01h12m30s)

[that's meant to be a copy not a cut](https://youtu.be/ATjXcjSgnE0?t=01h12m34s)

[try this again uh](https://youtu.be/ATjXcjSgnE0?t=01h12m37s)

[test event](https://youtu.be/ATjXcjSgnE0?t=01h12m41s)

[but we do it on the data grid cell](https://youtu.be/ATjXcjSgnE0?t=01h12m44s)

[test event drop the break statement we](https://youtu.be/ATjXcjSgnE0?t=01h12m49s)

[don't need that](https://youtu.be/ATjXcjSgnE0?t=01h12m52s)

[and i'm wondering](https://youtu.be/ATjXcjSgnE0?t=01h12m55s)

[uh let's see mouse args](https://youtu.be/ATjXcjSgnE0?t=01h13m13s)

[source](https://youtu.be/ATjXcjSgnE0?t=01h13m17s)

[i'm curious if we do the mouse down](https://youtu.be/ATjXcjSgnE0?t=01h13m22s)

[event on the](https://youtu.be/ATjXcjSgnE0?t=01h13m25s)

[cell](https://youtu.be/ATjXcjSgnE0?t=01h13m26s)

[because i can't get to this condition](https://youtu.be/ATjXcjSgnE0?t=01h13m29s)

[but i'm wondering if i can trick it](https://youtu.be/ATjXcjSgnE0?t=01h13m35s)

[by faking the extra event that i know](https://youtu.be/ATjXcjSgnE0?t=01h13m38s)

[needs to be there](https://youtu.be/ATjXcjSgnE0?t=01h13m40s)

[hey that's looking better](https://youtu.be/ATjXcjSgnE0?t=01h13m50s)

[okay let's check the events](https://youtu.be/ATjXcjSgnE0?t=01h13m55s)

[i think that may have that may have](https://youtu.be/ATjXcjSgnE0?t=01h13m58s)

[gotten us there let's find out let's](https://youtu.be/ATjXcjSgnE0?t=01h14m00s)

[find out](https://youtu.be/ATjXcjSgnE0?t=01h14m02s)

[okay so we come and we click here](https://youtu.be/ATjXcjSgnE0?t=01h14m03s)

[okay so these are these first two we](https://youtu.be/ATjXcjSgnE0?t=01h14m07s)

[already know about mouse down on data](https://youtu.be/ATjXcjSgnE0?t=01h14m08s)

[grid](https://youtu.be/ATjXcjSgnE0?t=01h14m11s)

[handled by data grid mouse down on text](https://youtu.be/ATjXcjSgnE0?t=01h14m12s)

[box view](https://youtu.be/ATjXcjSgnE0?t=01h14m14s)

[got passed all the way in mouse up](https://youtu.be/ATjXcjSgnE0?t=01h14m18s)

[yeah this is better this is better](https://youtu.be/ATjXcjSgnE0?t=01h14m24s)

[okay so let's do one more thing let's](https://youtu.be/ATjXcjSgnE0?t=01h14m28s)

[not](https://youtu.be/ATjXcjSgnE0?t=01h14m30s)

[change](https://youtu.be/ATjXcjSgnE0?t=01h14m31s)

[um again edit](https://youtu.be/ATjXcjSgnE0?t=01h14m38s)

[likely changes the visual](https://youtu.be/ATjXcjSgnE0?t=01h14m42s)

[tree restart event](https://youtu.be/ATjXcjSgnE0?t=01h14m45s)

[back at the cell because i'm thinking](https://youtu.be/ATjXcjSgnE0?t=01h14m48s)

[rather than doing](https://youtu.be/ATjXcjSgnE0?t=01h14m51s)

[this gonna come over here and do](https://youtu.be/ATjXcjSgnE0?t=01h14m54s)

[mouse args](https://youtu.be/ATjXcjSgnE0?t=01h14m58s)

[boy i'm wondering if i need to do any of](https://youtu.be/ATjXcjSgnE0?t=01h15m08s)

[this or if i can](https://youtu.be/ATjXcjSgnE0?t=01h15m09s)

[just re-pass mouse args](https://youtu.be/ATjXcjSgnE0?t=01h15m12s)

[let's try this because i'm thinking](https://youtu.be/ATjXcjSgnE0?t=01h15m23s)

[so the the tunneling event comes down](https://youtu.be/ATjXcjSgnE0?t=01h15m26s)

[we get into this handler which is inside](https://youtu.be/ATjXcjSgnE0?t=01h15m30s)

[of the cell](https://youtu.be/ATjXcjSgnE0?t=01h15m32s)

[we call begin edit on the cell which](https://youtu.be/ATjXcjSgnE0?t=01h15m34s)

[changes our visual tree effectively](https://youtu.be/ATjXcjSgnE0?t=01h15m36s)

[removing us](https://youtu.be/ATjXcjSgnE0?t=01h15m38s)

[from the the cell's visual tree content](https://youtu.be/ATjXcjSgnE0?t=01h15m40s)

[i'm thinking if we just re-cue the event](https://youtu.be/ATjXcjSgnE0?t=01h15m43s)

[and send it back down](https://youtu.be/ATjXcjSgnE0?t=01h15m46s)

[we might stack overflow](https://youtu.be/ATjXcjSgnE0?t=01h15m48s)

[we might stack overflow this is a this](https://youtu.be/ATjXcjSgnE0?t=01h15m52s)

[this type of logic is a great way to](https://youtu.be/ATjXcjSgnE0?t=01h15m54s)

[stack overflow yourself](https://youtu.be/ATjXcjSgnE0?t=01h15m56s)

[we're going to try it](https://youtu.be/ATjXcjSgnE0?t=01h15m58s)

[no so that one didn't do it](https://youtu.be/ATjXcjSgnE0?t=01h16m01s)

[okay so that no bueno](https://youtu.be/ATjXcjSgnE0?t=01h16m06s)

[okay so let's go back to what works](https://youtu.be/ATjXcjSgnE0?t=01h16m09s)

[okay um what is that](https://youtu.be/ATjXcjSgnE0?t=01h16m12s)

[timestamp](https://youtu.be/ATjXcjSgnE0?t=01h16m18s)

[uh let's pass that in and i want to see](https://youtu.be/ATjXcjSgnE0?t=01h16m22s)

[if i change this up to](https://youtu.be/ATjXcjSgnE0?t=01h16m26s)

[preview mouse down event](https://youtu.be/ATjXcjSgnE0?t=01h16m31s)

[because that's how we got into here](https://youtu.be/ATjXcjSgnE0?t=01h16m35s)

[right is a preview mouse down](https://youtu.be/ATjXcjSgnE0?t=01h16m37s)

[preview mouse left button down](https://youtu.be/ATjXcjSgnE0?t=01h16m39s)

[i don't think left is actually an option](https://youtu.be/ATjXcjSgnE0?t=01h16m44s)

[i think](https://youtu.be/ATjXcjSgnE0?t=01h16m46s)

[yeah mouse down event i believe is the](https://youtu.be/ATjXcjSgnE0?t=01h16m56s)

[routed event that's been triggered](https://youtu.be/ATjXcjSgnE0?t=01h16m58s)

[so let's see if it's the fact that i](https://youtu.be/ATjXcjSgnE0?t=01h17m00s)

[sent the same instance](https://youtu.be/ATjXcjSgnE0?t=01h17m02s)

[or the same event](https://youtu.be/ATjXcjSgnE0?t=01h17m04s)

[because we know if we send the mouse](https://youtu.be/ATjXcjSgnE0?t=01h17m13s)

[down event that works](https://youtu.be/ATjXcjSgnE0?t=01h17m14s)

[but it's weird to send a bubbling event](https://youtu.be/ATjXcjSgnE0?t=01h17m16s)

[higher up in the tree](https://youtu.be/ATjXcjSgnE0?t=01h17m18s)

[from a tunneling event that got down to](https://youtu.be/ATjXcjSgnE0?t=01h17m20s)

[us it's a little weird](https://youtu.be/ATjXcjSgnE0?t=01h17m21s)

[okay so that does not work](https://youtu.be/ATjXcjSgnE0?t=01h17m28s)

[but we do know that mouse down event](https://youtu.be/ATjXcjSgnE0?t=01h17m38s)

[works](https://youtu.be/ATjXcjSgnE0?t=01h17m42s)

[um](https://youtu.be/ATjXcjSgnE0?t=01h17m46s)

[trigger the mouse down event](https://youtu.be/ATjXcjSgnE0?t=01h17m49s)

[to cause the data grid](https://youtu.be/ATjXcjSgnE0?t=01h17m52s)

[to adjust selection](https://youtu.be/ATjXcjSgnE0?t=01h17m56s)

[so i think we are going](https://youtu.be/ATjXcjSgnE0?t=01h18m02s)

[to do that probably rename this event](https://youtu.be/ATjXcjSgnE0?t=01h18m05s)

[but i think this might be our fix](https://youtu.be/ATjXcjSgnE0?t=01h18m09s)

[oh it looks like we](https://youtu.be/ATjXcjSgnE0?t=01h18m20s)

[okay looks like we got](https://youtu.be/ATjXcjSgnE0?t=01h18m36s)

[uh interesting sorry i just saw](https://youtu.be/ATjXcjSgnE0?t=01h18m44s)

[a new](https://youtu.be/ATjXcjSgnE0?t=01h18m48s)

[uh let's see users once one of those](https://youtu.be/ATjXcjSgnE0?t=01h18m52s)

[shows are not safe for us](https://youtu.be/ATjXcjSgnE0?t=01h18m56s)

[[Music]](https://youtu.be/ATjXcjSgnE0?t=01h19m16s)

[this is](https://youtu.be/ATjXcjSgnE0?t=01h19m19s)

[got it so](https://youtu.be/ATjXcjSgnE0?t=01h19m30s)

[we're gonna hold on to this sign myself](https://youtu.be/ATjXcjSgnE0?t=01h19m36s)

[uh because i want to review that okay](https://youtu.be/ATjXcjSgnE0?t=01h19m40s)

[back to what not to get distracted not](https://youtu.be/ATjXcjSgnE0?t=01h19m43s)

[to get distracted we are](https://youtu.be/ATjXcjSgnE0?t=01h19m45s)

[fixing bugs boom boom](https://youtu.be/ATjXcjSgnE0?t=01h19m46s)

[boom if i control click i get both](https://youtu.be/ATjXcjSgnE0?t=01h19m50s)

[highlighted](https://youtu.be/ATjXcjSgnE0?t=01h19m53s)

[excellent full row selected four row](https://youtu.be/ATjXcjSgnE0?t=01h19m54s)

[selected four rows selected](https://youtu.be/ATjXcjSgnE0?t=01h19m58s)

[boom that looks wonderful](https://youtu.be/ATjXcjSgnE0?t=01h20m00s)

[okay so i want to come over here](https://youtu.be/ATjXcjSgnE0?t=01h20m04s)

[um i want to check actually i just want](https://youtu.be/ATjXcjSgnE0?t=01h20m07s)

[to check on each of these what are the](https://youtu.be/ATjXcjSgnE0?t=01h20m10s)

[selection modes set](https://youtu.be/ATjXcjSgnE0?t=01h20m11s)

[you are you are also full row so i kind](https://youtu.be/ATjXcjSgnE0?t=01h20m14s)

[of want to put you back](https://youtu.be/ATjXcjSgnE0?t=01h20m18s)

[to](https://youtu.be/ATjXcjSgnE0?t=01h20m20s)

[okay so i want to reset my change to the](https://youtu.be/ATjXcjSgnE0?t=01h20m24s)

[demo app](https://youtu.be/ATjXcjSgnE0?t=01h20m27s)

[uh let's see here so we have](https://youtu.be/ATjXcjSgnE0?t=01h20m29s)

[the demo app change i want to put you](https://youtu.be/ATjXcjSgnE0?t=01h20m33s)

[back](https://youtu.be/ATjXcjSgnE0?t=01h20m35s)

[and let's see here we want to discard](https://youtu.be/ATjXcjSgnE0?t=01h20m42s)

[discard](https://youtu.be/ATjXcjSgnE0?t=01h20m46s)

[discard and it's just a white space](https://youtu.be/ATjXcjSgnE0?t=01h20m50s)

[change we want to keep all of that we](https://youtu.be/ATjXcjSgnE0?t=01h20m54s)

[want to rename that from test um](https://youtu.be/ATjXcjSgnE0?t=01h20m56s)

[let's call this](https://youtu.be/ATjXcjSgnE0?t=01h21m01s)

[that seems better one last test](https://youtu.be/ATjXcjSgnE0?t=01h21m08s)

[great](https://youtu.be/ATjXcjSgnE0?t=01h21m42s)

[great it's exactly what we want](https://youtu.be/ATjXcjSgnE0?t=01h21m48s)

[boom that is](https://youtu.be/ATjXcjSgnE0?t=01h21m52s)

[what we want perfect we're gonna ship it](https://youtu.be/ATjXcjSgnE0?t=01h21m55s)

[okay so](https://youtu.be/ATjXcjSgnE0?t=01h21m59s)

[[Music]](https://youtu.be/ATjXcjSgnE0?t=01h22m00s)

[fixing let's go back to](https://youtu.be/ATjXcjSgnE0?t=01h22m02s)

[uh let's see](https://youtu.be/ATjXcjSgnE0?t=01h22m06s)

[two three six three](https://youtu.be/ATjXcjSgnE0?t=01h22m09s)

[let's see data grid](https://youtu.be/ATjXcjSgnE0?t=01h22m13s)

[selection should now](https://youtu.be/ATjXcjSgnE0?t=01h22m16s)

[properly select items](https://youtu.be/ATjXcjSgnE0?t=01h22m20s)

[now i have the click to](https://youtu.be/ATjXcjSgnE0?t=01h22m26s)

[edit and the selection](https://youtu.be/ATjXcjSgnE0?t=01h22m30s)

[let's see fixes pound](https://youtu.be/ATjXcjSgnE0?t=01h22m34s)

[and issue number so for those people not](https://youtu.be/ATjXcjSgnE0?t=01h22m38s)

[familiar with it there's a](https://youtu.be/ATjXcjSgnE0?t=01h22m40s)

[there's a few magical words in uh github](https://youtu.be/ATjXcjSgnE0?t=01h22m41s)

[so if you open a pull request with](https://youtu.be/ATjXcjSgnE0?t=01h22m45s)

[things like i think it's](https://youtu.be/ATjXcjSgnE0?t=01h22m47s)

[fixes resolves](https://youtu.be/ATjXcjSgnE0?t=01h22m48s)

[i'd have to look there's there's a few](https://youtu.be/ATjXcjSgnE0?t=01h22m51s)

[of them but those types of words](https://youtu.be/ATjXcjSgnE0?t=01h22m52s)

[followed by pound and issue number uh](https://youtu.be/ATjXcjSgnE0?t=01h22m54s)

[github will automatically link those and](https://youtu.be/ATjXcjSgnE0?t=01h22m57s)

[then when the](https://youtu.be/ATjXcjSgnE0?t=01h22m59s)

[uh pull request uh merges it will end up](https://youtu.be/ATjXcjSgnE0?t=01h23m00s)

[automatically uh closing the issue for](https://youtu.be/ATjXcjSgnE0?t=01h23m05s)

[you which is](https://youtu.be/ATjXcjSgnE0?t=01h23m07s)

[incredibly helpful so create pr](https://youtu.be/ATjXcjSgnE0?t=01h23m09s)

[let that guy dance okay so](https://youtu.be/ATjXcjSgnE0?t=01h23m13s)

[you are there close new let's go back to](https://youtu.be/ATjXcjSgnE0?t=01h23m18s)

[the milestone](https://youtu.be/ATjXcjSgnE0?t=01h23m20s)

[uh let's see floating hint offset not](https://youtu.be/ATjXcjSgnE0?t=01h23m23s)

[working](https://youtu.be/ATjXcjSgnE0?t=01h23m25s)

[we fixed that already um](https://youtu.be/ATjXcjSgnE0?t=01h23m27s)

[expand hittable area reduced](https://youtu.be/ATjXcjSgnE0?t=01h23m33s)

[this bug here](https://youtu.be/ATjXcjSgnE0?t=01h23m39s)

[uh this one](https://youtu.be/ATjXcjSgnE0?t=01h23m45s)

[okay so let's start so once again](https://youtu.be/ATjXcjSgnE0?t=01h23m51s)

[going back to to the starting point so i](https://youtu.be/ATjXcjSgnE0?t=01h23m54s)

[go back to my master branch](https://youtu.be/ATjXcjSgnE0?t=01h23m56s)

[uh create a branch fix and then i will](https://youtu.be/ATjXcjSgnE0?t=01h23m59s)

[put in](https://youtu.be/ATjXcjSgnE0?t=01h24m02s)

[the issue number boom](https://youtu.be/ATjXcjSgnE0?t=01h24m03s)

[and then step one make sure the problem](https://youtu.be/ATjXcjSgnE0?t=01h24m08s)

[reproduces so we're going to close all](https://youtu.be/ATjXcjSgnE0?t=01h24m11s)

[these out](https://youtu.be/ATjXcjSgnE0?t=01h24m12s)

[always make sure we can reproduce the](https://youtu.be/ATjXcjSgnE0?t=01h24m14s)

[problem first](https://youtu.be/ATjXcjSgnE0?t=01h24m16s)

[and then we will go from there](https://youtu.be/ATjXcjSgnE0?t=01h24m21s)

[okay so let's see expander](https://youtu.be/ATjXcjSgnE0?t=01h24m27s)

[so that is correct so right wrong or](https://youtu.be/ATjXcjSgnE0?t=01h24m34s)

[indifferent](https://youtu.be/ATjXcjSgnE0?t=01h24m38s)

[this used to be clickable and now it's](https://youtu.be/ATjXcjSgnE0?t=01h24m42s)

[only down here so](https://youtu.be/ATjXcjSgnE0?t=01h24m43s)

[let's start with actually let's just](https://youtu.be/ATjXcjSgnE0?t=01h24m46s)

[grab snoop again](https://youtu.be/ATjXcjSgnE0?t=01h24m49s)

[well let's just grab snoop because this](https://youtu.be/ATjXcjSgnE0?t=01h24m51s)

[is probably just as easy to find in](https://youtu.be/ATjXcjSgnE0?t=01h24m53s)

[snoop as anything](https://youtu.be/ATjXcjSgnE0?t=01h24m54s)

[okay so and i think so you'll note that](https://youtu.be/ATjXcjSgnE0?t=01h24m56s)

[when i'm hovering over this](https://youtu.be/ATjXcjSgnE0?t=01h25m00s)

[my cursor's changing to the hand so that](https://youtu.be/ATjXcjSgnE0?t=01h25m01s)

[gives me a very strong hint](https://youtu.be/ATjXcjSgnE0?t=01h25m04s)

[that i'm just hunting for whichever one](https://youtu.be/ATjXcjSgnE0?t=01h25m06s)

[of these elements as i go up through the](https://youtu.be/ATjXcjSgnE0?t=01h25m08s)

[tree](https://youtu.be/ATjXcjSgnE0?t=01h25m10s)

[has hands set on it](https://youtu.be/ATjXcjSgnE0?t=01h25m10s)

[interesting so that has cursor handset](https://youtu.be/ATjXcjSgnE0?t=01h25m18s)

[on it](https://youtu.be/ATjXcjSgnE0?t=01h25m20s)

[so that's the toggle button oh is this](https://youtu.be/ATjXcjSgnE0?t=01h25m22s)

[just a stupid case of background](https://youtu.be/ATjXcjSgnE0?t=01h25m24s)

[well that's an easy fix okay](https://youtu.be/ATjXcjSgnE0?t=01h25m37s)

[so this is this is very worthwhile](https://youtu.be/ATjXcjSgnE0?t=01h25m40s)

[noting](https://youtu.be/ATjXcjSgnE0?t=01h25m43s)

[um so in wpf there are](https://youtu.be/ATjXcjSgnE0?t=01h25m44s)

[there is the default value of a property](https://youtu.be/ATjXcjSgnE0?t=01h25m47s)

[and](https://youtu.be/ATjXcjSgnE0?t=01h25m49s)

[for um background the default](https://youtu.be/ATjXcjSgnE0?t=01h25m50s)

[is unset so there's actually a static](https://youtu.be/ATjXcjSgnE0?t=01h25m54s)

[property](https://youtu.be/ATjXcjSgnE0?t=01h25m56s)

[on dependency property called unset](https://youtu.be/ATjXcjSgnE0?t=01h25m57s)

[value](https://youtu.be/ATjXcjSgnE0?t=01h25m59s)

[unset value and transparent when it](https://youtu.be/ATjXcjSgnE0?t=01h26m01s)

[comes time to render an element](https://youtu.be/ATjXcjSgnE0?t=01h26m03s)

[look identical they are invisible they](https://youtu.be/ATjXcjSgnE0?t=01h26m05s)

[are transparent there's nothing there](https://youtu.be/ATjXcjSgnE0?t=01h26m08s)

[but there's a slight behavior change](https://youtu.be/ATjXcjSgnE0?t=01h26m09s)

[between unset](https://youtu.be/ATjXcjSgnE0?t=01h26m11s)

[and transparent and the difference comes](https://youtu.be/ATjXcjSgnE0?t=01h26m13s)

[with what is called hit testing](https://youtu.be/ATjXcjSgnE0?t=01h26m15s)

[so hit testing is the process by which](https://youtu.be/ATjXcjSgnE0?t=01h26m17s)

[wps](https://youtu.be/ATjXcjSgnE0?t=01h26m20s)

[takes your mouse cursor and goes looking](https://youtu.be/ATjXcjSgnE0?t=01h26m21s)

[to see exactly which element is](https://youtu.be/ATjXcjSgnE0?t=01h26m23s)

[under that point because that's not](https://youtu.be/ATjXcjSgnE0?t=01h26m25s)

[always a trivial thing to](https://youtu.be/ATjXcjSgnE0?t=01h26m27s)

[to figure out there could be transforms](https://youtu.be/ATjXcjSgnE0?t=01h26m28s)

[and weird layout things going on and so](https://youtu.be/ATjXcjSgnE0?t=01h26m31s)

[it has to figure out okay](https://youtu.be/ATjXcjSgnE0?t=01h26m33s)

[which one of your elements is really on](https://youtu.be/ATjXcjSgnE0?t=01h26m35s)

[top of the stack](https://youtu.be/ATjXcjSgnE0?t=01h26m37s)

[and underneath the cursor and trying to](https://youtu.be/ATjXcjSgnE0?t=01h26m38s)

[figure out you know if i were to drop](https://youtu.be/ATjXcjSgnE0?t=01h26m41s)

[the cursor](https://youtu.be/ATjXcjSgnE0?t=01h26m42s)

[straight down right here what is it](https://youtu.be/ATjXcjSgnE0?t=01h26m43s)

[going to hit](https://youtu.be/ATjXcjSgnE0?t=01h26m45s)

[with unset it ignores the element and](https://youtu.be/ATjXcjSgnE0?t=01h26m47s)

[says](https://youtu.be/ATjXcjSgnE0?t=01h26m50s)

[that one doesn't have it let's let it](https://youtu.be/ATjXcjSgnE0?t=01h26m51s)

[fall through to the next element below](https://youtu.be/ATjXcjSgnE0?t=01h26m52s)

[it](https://youtu.be/ATjXcjSgnE0?t=01h26m54s)

[whereas if it's transparent the cursor](https://youtu.be/ATjXcjSgnE0?t=01h26m55s)

[stops and get and hits that element and](https://youtu.be/ATjXcjSgnE0?t=01h26m58s)

[determines it's on top and based on this](https://youtu.be/ATjXcjSgnE0?t=01h27m00s)

[it looks like the header site of the](https://youtu.be/ATjXcjSgnE0?t=01h27m03s)

[toggle button needs a background of](https://youtu.be/ATjXcjSgnE0?t=01h27m04s)

[transparent](https://youtu.be/ATjXcjSgnE0?t=01h27m06s)

[show this might be a stupid simple fix](https://youtu.be/ATjXcjSgnE0?t=01h27m07s)

[um because i think i can just search for](https://youtu.be/ATjXcjSgnE0?t=01h27m12s)

[header what what's the name of that](https://youtu.be/ATjXcjSgnE0?t=01h27m18s)

[thing](https://youtu.be/ATjXcjSgnE0?t=01h27m21s)

[header site yeah inside expander](https://youtu.be/ATjXcjSgnE0?t=01h27m24s)

[my inside of expander toggle button](https://youtu.be/ATjXcjSgnE0?t=01h27m30s)

[hang on this is the toggle button](https://youtu.be/ATjXcjSgnE0?t=01h27m33s)

[template](https://youtu.be/ATjXcjSgnE0?t=01h27m35s)

[header style template control template](https://youtu.be/ATjXcjSgnE0?t=01h27m42s)

[for the toggle button](https://youtu.be/ATjXcjSgnE0?t=01h27m46s)

[so hold on here's two toggle buttons](https://youtu.be/ATjXcjSgnE0?t=01h27m56s)

[one has this](https://youtu.be/ATjXcjSgnE0?t=01h28m02s)

[oh did we just miss one of the setters](https://youtu.be/ATjXcjSgnE0?t=01h28m06s)

[i wonder if we just missed one of the](https://youtu.be/ATjXcjSgnE0?t=01h28m19s)

[setters](https://youtu.be/ATjXcjSgnE0?t=01h28m21s)

[collapse the visual tree okay there's](https://youtu.be/ATjXcjSgnE0?t=01h28m26s)

[header site](https://youtu.be/ATjXcjSgnE0?t=01h28m29s)

[see there it is boom um](https://youtu.be/ATjXcjSgnE0?t=01h28m30s)

[there's header site where does its style](https://youtu.be/ATjXcjSgnE0?t=01h28m38s)

[get set let's](https://youtu.be/ATjXcjSgnE0?t=01h28m40s)

[clean up that extra white space on the](https://youtu.be/ATjXcjSgnE0?t=01h28m42s)

[end um](https://youtu.be/ATjXcjSgnE0?t=01h28m43s)

[horizontal header style let's do this](https://youtu.be/ATjXcjSgnE0?t=01h28m45s)

[it should only be a handful of places](https://youtu.be/ATjXcjSgnE0?t=01h28m51s)

[yeah and it gets toggled](https://youtu.be/ATjXcjSgnE0?t=01h28m54s)

[it gets toggled](https://youtu.be/ATjXcjSgnE0?t=01h28m58s)

[[Music]](https://youtu.be/ATjXcjSgnE0?t=01h29m01s)

[so it gets toggled from](https://youtu.be/ATjXcjSgnE0?t=01h29m05s)

[vertical to horizontal](https://youtu.be/ATjXcjSgnE0?t=01h29m09s)

[but both of those](https://youtu.be/ATjXcjSgnE0?t=01h29m13s)

[both of those had a background set on](https://youtu.be/ATjXcjSgnE0?t=01h29m18s)

[them](https://youtu.be/ATjXcjSgnE0?t=01h29m20s)

[right](https://youtu.be/ATjXcjSgnE0?t=01h29m22s)

[horizontal center background transparent](https://youtu.be/ATjXcjSgnE0?t=01h29m27s)

[wait what i am confused](https://youtu.be/ATjXcjSgnE0?t=01h29m38s)

[header oh but](https://youtu.be/ATjXcjSgnE0?t=01h29m45s)

[even though the style is set here the](https://youtu.be/ATjXcjSgnE0?t=01h29m48s)

[content template is](https://youtu.be/ATjXcjSgnE0?t=01h29m50s)

[set here wait that shouldn't matter](https://youtu.be/ATjXcjSgnE0?t=01h29m52s)

[because this is setting the template](https://youtu.be/ATjXcjSgnE0?t=01h29m55s)

[property](https://youtu.be/ATjXcjSgnE0?t=01h29m57s)

[not the content template property](https://youtu.be/ATjXcjSgnE0?t=01h29m58s)

[something's off something's off the](https://youtu.be/ATjXcjSgnE0?t=01h30m07s)

[the running code and the um](https://youtu.be/ATjXcjSgnE0?t=01h30m10s)

[other code are not lining up what style](https://youtu.be/ATjXcjSgnE0?t=01h30m13s)

[has been applied here](https://youtu.be/ATjXcjSgnE0?t=01h30m16s)

[horizontal header style that is the](https://youtu.be/ATjXcjSgnE0?t=01h30m21s)

[style being applied here](https://youtu.be/ATjXcjSgnE0?t=01h30m23s)

[but if i look at the background of](https://youtu.be/ATjXcjSgnE0?t=01h30m29s)

[if i look at the background being set on](https://youtu.be/ATjXcjSgnE0?t=01h30m36s)

[this element](https://youtu.be/ATjXcjSgnE0?t=01h30m39s)

[oh the value source comes from parent](https://youtu.be/ATjXcjSgnE0?t=01h30m42s)

[template oh](https://youtu.be/ATjXcjSgnE0?t=01h30m44s)

[oh somebody in here is mucking with the](https://youtu.be/ATjXcjSgnE0?t=01h30m48s)

[background](https://youtu.be/ATjXcjSgnE0?t=01h30m52s)

[oh look at that](https://youtu.be/ATjXcjSgnE0?t=01h30m54s)

[look at that so it doesn't matter what's](https://youtu.be/ATjXcjSgnE0?t=01h30m57s)

[in the style because this is being set](https://youtu.be/ATjXcjSgnE0?t=01h31m00s)

[directly](https://youtu.be/ATjXcjSgnE0?t=01h31m02s)

[that's the bug so](https://youtu.be/ATjXcjSgnE0?t=01h31m03s)

[to be clear in wpf when you're doing](https://youtu.be/ATjXcjSgnE0?t=01h31m07s)

[styles there is an](https://youtu.be/ATjXcjSgnE0?t=01h31m10s)

[in basically an inheritance hierarchy of](https://youtu.be/ATjXcjSgnE0?t=01h31m11s)

[um how styles relate to one another so](https://youtu.be/ATjXcjSgnE0?t=01h31m14s)

[for example if we look at](https://youtu.be/ATjXcjSgnE0?t=01h31m17s)

[um uh do any of these have a based on](https://youtu.be/ATjXcjSgnE0?t=01h31m19s)

[you don't have a based on you don't have](https://youtu.be/ATjXcjSgnE0?t=01h31m24s)

[it based on](https://youtu.be/ATjXcjSgnE0?t=01h31m26s)

[bad example go over to the buttons real](https://youtu.be/ATjXcjSgnE0?t=01h31m27s)

[quick because buttons show this](https://youtu.be/ATjXcjSgnE0?t=01h31m30s)

[much better let's see target type](https://youtu.be/ATjXcjSgnE0?t=01h31m31s)

[so for example these styles here this](https://youtu.be/ATjXcjSgnE0?t=01h31m34s)

[style](https://youtu.be/ATjXcjSgnE0?t=01h31m37s)

[is based on this other material design](https://youtu.be/ATjXcjSgnE0?t=01h31m37s)

[raised button style](https://youtu.be/ATjXcjSgnE0?t=01h31m41s)

[and so because there's this uh](https://youtu.be/ATjXcjSgnE0?t=01h31m43s)

[inheritance hierarchy](https://youtu.be/ATjXcjSgnE0?t=01h31m45s)

[for a lack of better words the](https://youtu.be/ATjXcjSgnE0?t=01h31m46s)

[the assignment to a property that is](https://youtu.be/ATjXcjSgnE0?t=01h31m50s)

[closest to the element](https://youtu.be/ATjXcjSgnE0?t=01h31m52s)

[wins so in this case these ones](https://youtu.be/ATjXcjSgnE0?t=01h31m53s)

[are closer to the actual assignment](https://youtu.be/ATjXcjSgnE0?t=01h31m56s)

[than the ones in the base style so they](https://youtu.be/ATjXcjSgnE0?t=01h32m00s)

[get to](https://youtu.be/ATjXcjSgnE0?t=01h32m02s)

[effectively override however](https://youtu.be/ATjXcjSgnE0?t=01h32m03s)

[if there is an assignment directly on](https://youtu.be/ATjXcjSgnE0?t=01h32m06s)

[the element this is always going to be](https://youtu.be/ATjXcjSgnE0?t=01h32m08s)

[closest so](https://youtu.be/ATjXcjSgnE0?t=01h32m10s)

[this one wins the only time where that](https://youtu.be/ATjXcjSgnE0?t=01h32m12s)

[closest gets a little weird](https://youtu.be/ATjXcjSgnE0?t=01h32m14s)

[is when you start looking at triggers](https://youtu.be/ATjXcjSgnE0?t=01h32m16s)

[inside of templates](https://youtu.be/ATjXcjSgnE0?t=01h32m18s)

[because triggers down here](https://youtu.be/ATjXcjSgnE0?t=01h32m19s)

[these things don't care where that](https://youtu.be/ATjXcjSgnE0?t=01h32m23s)

[assignment occurred](https://youtu.be/ATjXcjSgnE0?t=01h32m25s)

[they don't care whether it's directly on](https://youtu.be/ATjXcjSgnE0?t=01h32m26s)

[the element or design of style on the](https://youtu.be/ATjXcjSgnE0?t=01h32m28s)

[element](https://youtu.be/ATjXcjSgnE0?t=01h32m30s)

[when those triggers fire these things](https://youtu.be/ATjXcjSgnE0?t=01h32m30s)

[darn it they are setting that property](https://youtu.be/ATjXcjSgnE0?t=01h32m32s)

[whether they whether you like it or not](https://youtu.be/ATjXcjSgnE0?t=01h32m35s)

[they are going to change it](https://youtu.be/ATjXcjSgnE0?t=01h32m36s)

[which can make uh control template](https://youtu.be/ATjXcjSgnE0?t=01h32m38s)

[triggers](https://youtu.be/ATjXcjSgnE0?t=01h32m41s)

[a real pain in the neck to override](https://youtu.be/ATjXcjSgnE0?t=01h32m42s)

[because they don't really have a good](https://youtu.be/ATjXcjSgnE0?t=01h32m44s)

[mechanism for doing so](https://youtu.be/ATjXcjSgnE0?t=01h32m45s)

[you can either dump them or keep them](https://youtu.be/ATjXcjSgnE0?t=01h32m46s)

[there's not really a mix and match type](https://youtu.be/ATjXcjSgnE0?t=01h32m49s)

[scenario](https://youtu.be/ATjXcjSgnE0?t=01h32m51s)

[um or at least not an easy way to do it](https://youtu.be/ATjXcjSgnE0?t=01h32m53s)

[there's plenty of](https://youtu.be/ATjXcjSgnE0?t=01h32m55s)

[there's plenty of ways to manipulate the](https://youtu.be/ATjXcjSgnE0?t=01h32m56s)

[template at runtime](https://youtu.be/ATjXcjSgnE0?t=01h32m57s)

[just not great so what we have here](https://youtu.be/ATjXcjSgnE0?t=01h32m59s)

[though](https://youtu.be/ATjXcjSgnE0?t=01h33m02s)

[is we've got this background here this](https://youtu.be/ATjXcjSgnE0?t=01h33m03s)

[header background that was added a](https://youtu.be/ATjXcjSgnE0?t=01h33m05s)

[seemingly benign change](https://youtu.be/ATjXcjSgnE0?t=01h33m08s)

[but because previously this style was](https://youtu.be/ATjXcjSgnE0?t=01h33m10s)

[doing it](https://youtu.be/ATjXcjSgnE0?t=01h33m13s)

[when we added this header background](https://youtu.be/ATjXcjSgnE0?t=01h33m14s)

[attached property](https://youtu.be/ATjXcjSgnE0?t=01h33m16s)

[it ended up uh causing problems](https://youtu.be/ATjXcjSgnE0?t=01h33m18s)

[for us so what really needs to change](https://youtu.be/ATjXcjSgnE0?t=01h33m21s)

[i'm going to leave these styles here](https://youtu.be/ATjXcjSgnE0?t=01h33m25s)

[no i should drop these](https://youtu.be/ATjXcjSgnE0?t=01h33m28s)

[yeah we should drop these these are not](https://youtu.be/ATjXcjSgnE0?t=01h33m31s)

[well if anybody's using them](https://youtu.be/ATjXcjSgnE0?t=01h33m33s)

[elsewhere what are the odds people are](https://youtu.be/ATjXcjSgnE0?t=01h33m35s)

[using these styles](https://youtu.be/ATjXcjSgnE0?t=01h33m38s)

[elsewhere we'll leave them for now](https://youtu.be/ATjXcjSgnE0?t=01h33m39s)

[is this being used anywhere](https://youtu.be/ATjXcjSgnE0?t=01h33m47s)

[it is okay so we'll let that slide too](https://youtu.be/ATjXcjSgnE0?t=01h33m55s)

[okay so regardless though what we would](https://youtu.be/ATjXcjSgnE0?t=01h33m59s)

[like to do](https://youtu.be/ATjXcjSgnE0?t=01h34m02s)

[is not rely on that](https://youtu.be/ATjXcjSgnE0?t=01h34m03s)

[so i think the problem is this guy](https://youtu.be/ATjXcjSgnE0?t=01h34m08s)

[this guy really just needs a default so](https://youtu.be/ATjXcjSgnE0?t=01h34m12s)

[setter property and then what we're](https://youtu.be/ATjXcjSgnE0?t=01h34m15s)

[going to do is we're just going to grab](https://youtu.be/ATjXcjSgnE0?t=01h34m18s)

[this little guy](https://youtu.be/ATjXcjSgnE0?t=01h34m19s)

[um value gets](https://youtu.be/ATjXcjSgnE0?t=01h34m24s)

[transparent okay](https://youtu.be/ATjXcjSgnE0?t=01h34m28s)

[so adding that little guy in broken](https://youtu.be/ATjXcjSgnE0?t=01h34m32s)

[but putting this back in should give it](https://youtu.be/ATjXcjSgnE0?t=01h34m39s)

[an appropriate default and if somebody](https://youtu.be/ATjXcjSgnE0?t=01h34m41s)

[wants to override the header background](https://youtu.be/ATjXcjSgnE0?t=01h34m42s)

[to put in something else](https://youtu.be/ATjXcjSgnE0?t=01h34m44s)

[you are welcome to do so i would just](https://youtu.be/ATjXcjSgnE0?t=01h34m46s)

[advise you not to put it into](https://youtu.be/ATjXcjSgnE0?t=01h34m48s)

[onset that would be a bad choice](https://youtu.be/ATjXcjSgnE0?t=01h34m51s)

[uh expanders are what we're doing now](https://youtu.be/ATjXcjSgnE0?t=01h34m55s)

[there we go now you can click the whole](https://youtu.be/ATjXcjSgnE0?t=01h35m00s)

[thing](https://youtu.be/ATjXcjSgnE0?t=01h35m03s)

[perfect perfect](https://youtu.be/ATjXcjSgnE0?t=01h35m05s)

[uh let's see fixing](https://youtu.be/ATjXcjSgnE0?t=01h35m11s)

[clickable area of the expander](https://youtu.be/ATjXcjSgnE0?t=01h35m14s)

[that is not how you spell clickable](https://youtu.be/ATjXcjSgnE0?t=01h35m19s)

[that's not how you spell expander](https://youtu.be/ATjXcjSgnE0?t=01h35m21s)

[uh actually it is](https://youtu.be/ATjXcjSgnE0?t=01h35m23s)

[fixes pound what branch are we on](https://youtu.be/ATjXcjSgnE0?t=01h35m26s)

[uh two three six four so branch name is](https://youtu.be/ATjXcjSgnE0?t=01h35m30s)

[right up here](https://youtu.be/ATjXcjSgnE0?t=01h35m33s)

[and we'll push that beast and](https://youtu.be/ATjXcjSgnE0?t=01h35m35s)

[oh i suppose we could just do uh](https://youtu.be/ATjXcjSgnE0?t=01h35m40s)

[is there a nice easy right click create](https://youtu.be/ATjXcjSgnE0?t=01h35m45s)

[pull request from here start pull](https://youtu.be/ATjXcjSgnE0?t=01h35m48s)

[request](https://youtu.be/ATjXcjSgnE0?t=01h35m50s)

[the only thing is i like the i like the](https://youtu.be/ATjXcjSgnE0?t=01h35m55s)

[github flow](https://youtu.be/ATjXcjSgnE0?t=01h35m58s)

[so the one nice thing is you can come](https://youtu.be/ATjXcjSgnE0?t=01h35m59s)

[down here and just go whoop](https://youtu.be/ATjXcjSgnE0?t=01h36m00s)

[then we'll slap this guy in the](https://youtu.be/ATjXcjSgnE0?t=01h36m07s)

[milestone create pull request](https://youtu.be/ATjXcjSgnE0?t=01h36m09s)

[and this guy now fixes so we will squash](https://youtu.be/ATjXcjSgnE0?t=01h36m12s)

[merge that guy in](https://youtu.be/ATjXcjSgnE0?t=01h36m14s)

[delete our source branch which is great](https://youtu.be/ATjXcjSgnE0?t=01h36m17s)

[which is also why doing it on your](https://youtu.be/ATjXcjSgnE0?t=01h36m22s)

[master branch isn't great because if you](https://youtu.be/ATjXcjSgnE0?t=01h36m23s)

[do it there you probably don't want to](https://youtu.be/ATjXcjSgnE0?t=01h36m25s)

[click delete source branch](https://youtu.be/ATjXcjSgnE0?t=01h36m26s)

[okay so this guy is going to kick off](https://youtu.be/ATjXcjSgnE0?t=01h36m28s)

[and then that will](https://youtu.be/ATjXcjSgnE0?t=01h36m30s)

[hopefully merge okay so i think we're](https://youtu.be/ATjXcjSgnE0?t=01h36m31s)

[starting to get down to just](https://youtu.be/ATjXcjSgnE0?t=01h36m34s)

[fixing the other wadi bits](https://youtu.be/ATjXcjSgnE0?t=01h36m35s)

[so this one here that one we just did](https://youtu.be/ATjXcjSgnE0?t=01h36m40s)

[so i'm gonna show show this one off this](https://youtu.be/ATjXcjSgnE0?t=01h36m44s)

[is one i've been](https://youtu.be/ATjXcjSgnE0?t=01h36m47s)

[working on so i've been trying to get](https://youtu.be/ATjXcjSgnE0?t=01h36m48s)

[the my latest version of xaml test in](https://youtu.be/ATjXcjSgnE0?t=01h36m49s)

[and working](https://youtu.be/ATjXcjSgnE0?t=01h36m52s)

[and for an unknown reason](https://youtu.be/ATjXcjSgnE0?t=01h36m53s)

[it's failing on the pipeline and i'm not](https://youtu.be/ATjXcjSgnE0?t=01h36m58s)

[clear why so for what it's worth](https://youtu.be/ATjXcjSgnE0?t=01h37m01s)

[um something is not](https://youtu.be/ATjXcjSgnE0?t=01h37m06s)

[quite working this guy here](https://youtu.be/ATjXcjSgnE0?t=01h37m09s)

[is just dumb um there is a window that](https://youtu.be/ATjXcjSgnE0?t=01h37m13s)

[is](https://youtu.be/ATjXcjSgnE0?t=01h37m17s)

[getting popped on the build agent from](https://youtu.be/ATjXcjSgnE0?t=01h37m18s)

[some provisioner process](https://youtu.be/ATjXcjSgnE0?t=01h37m20s)

[that is hovering over my window](https://youtu.be/ATjXcjSgnE0?t=01h37m23s)

[preventing my mouse hover cursor](https://youtu.be/ATjXcjSgnE0?t=01h37m26s)

[which very annoying](https://youtu.be/ATjXcjSgnE0?t=01h37m32s)

[very very annoying](https://youtu.be/ATjXcjSgnE0?t=01h37m36s)

[um](https://youtu.be/ATjXcjSgnE0?t=01h37m40s)

[we might work on this one next because](https://youtu.be/ATjXcjSgnE0?t=01h37m47s)

[we're quickly running out of ones to](https://youtu.be/ATjXcjSgnE0?t=01h37m49s)

[work on](https://youtu.be/ATjXcjSgnE0?t=01h37m50s)

[and i kind of want this this xaml test](https://youtu.be/ATjXcjSgnE0?t=01h37m51s)

[update is](https://youtu.be/ATjXcjSgnE0?t=01h37m55s)

[blocking this one um](https://youtu.be/ATjXcjSgnE0?t=01h37m55s)

[and the the the testing for this one so](https://youtu.be/ATjXcjSgnE0?t=01h37m59s)

[this might be the next priority to do](https://youtu.be/ATjXcjSgnE0?t=01h38m01s)

[so we'll wait we'll let this guy let](https://youtu.be/ATjXcjSgnE0?t=01h38m11s)

[this guy roll i think we're going to](https://youtu.be/ATjXcjSgnE0?t=01h38m14s)

[take a crack at this](https://youtu.be/ATjXcjSgnE0?t=01h38m15s)

[i thought about trying to fix it in the](https://youtu.be/ATjXcjSgnE0?t=01h38m17s)

[xaml library or the xaml test library](https://youtu.be/ATjXcjSgnE0?t=01h38m19s)

[and i think i'm just going to go around](https://youtu.be/ATjXcjSgnE0?t=01h38m21s)

[the library](https://youtu.be/ATjXcjSgnE0?t=01h38m23s)

[so so let me show you what i mean let me](https://youtu.be/ATjXcjSgnE0?t=01h38m25s)

[show you what i mean](https://youtu.be/ATjXcjSgnE0?t=01h38m28s)

[so the nice part is when this guy runs](https://youtu.be/ATjXcjSgnE0?t=01h38m32s)

[or when my ui tests run](https://youtu.be/ATjXcjSgnE0?t=01h38m35s)

[on a test failure it takes a screenshot](https://youtu.be/ATjXcjSgnE0?t=01h38m37s)

[which when you're doing ui testing](https://youtu.be/ATjXcjSgnE0?t=01h38m41s)

[that's gold](https://youtu.be/ATjXcjSgnE0?t=01h38m43s)

[because then you can actually see what](https://youtu.be/ATjXcjSgnE0?t=01h38m44s)

[was the point of it](https://youtu.be/ATjXcjSgnE0?t=01h38m47s)

[so in this case the test that failed was](https://youtu.be/ATjXcjSgnE0?t=01h38m48s)

[it's trying to test](https://youtu.be/ATjXcjSgnE0?t=01h38m50s)

[that when you hover the mouse over a](https://youtu.be/ATjXcjSgnE0?t=01h38m52s)

[button that the button appropriately](https://youtu.be/ATjXcjSgnE0?t=01h38m53s)

[changes](https://youtu.be/ATjXcjSgnE0?t=01h38m55s)

[and here is the screenshot of the](https://youtu.be/ATjXcjSgnE0?t=01h38m56s)

[failure](https://youtu.be/ATjXcjSgnE0?t=01h38m58s)

[does not make me happy this guy took](https://youtu.be/ATjXcjSgnE0?t=01h39m06s)

[focus](https://youtu.be/ATjXcjSgnE0?t=01h39m09s)

[sat on top](https://youtu.be/ATjXcjSgnE0?t=01h39m10s)

[jerk jerk so in the interest of fixing](https://youtu.be/ATjXcjSgnE0?t=01h39m16s)

[this](https://youtu.be/ATjXcjSgnE0?t=01h39m20s)

[i i believe what i'm going to do is so](https://youtu.be/ATjXcjSgnE0?t=01h39m20s)

[let's let's switch back over to this](https://youtu.be/ATjXcjSgnE0?t=01h39m23s)

[branch because i've been i've been](https://youtu.be/ATjXcjSgnE0?t=01h39m24s)

[hacking on this branch for a while so](https://youtu.be/ATjXcjSgnE0?t=01h39m26s)

[update sample test so let's go back to](https://youtu.be/ATjXcjSgnE0?t=01h39m28s)

[update xaml test](https://youtu.be/ATjXcjSgnE0?t=01h39m32s)

[we'll jump back here we'll pull up our](https://youtu.be/ATjXcjSgnE0?t=01h39m35s)

[master to get the latest on there](https://youtu.be/ATjXcjSgnE0?t=01h39m38s)

[okay so there was a bunch of changes](https://youtu.be/ATjXcjSgnE0?t=01h39m42s)

[all around breaking changes i did in my](https://youtu.be/ATjXcjSgnE0?t=01h39m45s)

[xaml test library so](https://youtu.be/ATjXcjSgnE0?t=01h39m47s)

[i figured it's always good to be your](https://youtu.be/ATjXcjSgnE0?t=01h39m49s)

[own first user](https://youtu.be/ATjXcjSgnE0?t=01h39m51s)

[that way you can feel the pain of all](https://youtu.be/ATjXcjSgnE0?t=01h39m53s)

[the upgrades and if it's painful for me](https://youtu.be/ATjXcjSgnE0?t=01h39m54s)

[it means it's gonna be painful for](https://youtu.be/ATjXcjSgnE0?t=01h39m57s)

[people who didn't write the library](https://youtu.be/ATjXcjSgnE0?t=01h39m58s)

[so my my initial thought here is inside](https://youtu.be/ATjXcjSgnE0?t=01h40m01s)

[of this i have a test base](https://youtu.be/ATjXcjSgnE0?t=01h40m05s)

[where on a lot of these things it goes](https://youtu.be/ATjXcjSgnE0?t=01h40m07s)

[through](https://youtu.be/ATjXcjSgnE0?t=01h40m10s)

[and does things like create window with](https://youtu.be/ATjXcjSgnE0?t=01h40m11s)

[or create window with user control or](https://youtu.be/ATjXcjSgnE0?t=01h40m14s)

[similar](https://youtu.be/ATjXcjSgnE0?t=01h40m16s)

[and you'll note that it does all of this](https://youtu.be/ATjXcjSgnE0?t=01h40m17s)

[and i'm kind of thinking i'm just going](https://youtu.be/ATjXcjSgnE0?t=01h40m19s)

[to go](https://youtu.be/ATjXcjSgnE0?t=01h40m21s)

[and cheat a little bit and do something](https://youtu.be/ATjXcjSgnE0?t=01h40m22s)

[like](https://youtu.be/ATjXcjSgnE0?t=01h40m24s)

[topmost gets true](https://youtu.be/ATjXcjSgnE0?t=01h40m25s)

[so if if people are unfamiliar with that](https://youtu.be/ATjXcjSgnE0?t=01h40m31s)

[property what this ends up doing so if](https://youtu.be/ATjXcjSgnE0?t=01h40m33s)

[we come over here to this](https://youtu.be/ATjXcjSgnE0?t=01h40m35s)

[and we just do it with the demo app real](https://youtu.be/ATjXcjSgnE0?t=01h40m38s)

[quick as a](https://youtu.be/ATjXcjSgnE0?t=01h40m40s)

[quick demonstration so if we go top most](https://youtu.be/ATjXcjSgnE0?t=01h40m41s)

[oh it's lower case](https://youtu.be/ATjXcjSgnE0?t=01h40m44s)

[m should fix that top](https://youtu.be/ATjXcjSgnE0?t=01h40m45s)

[my my library will blow up on that](https://youtu.be/ATjXcjSgnE0?t=01h40m49s)

[now if you relaunch this what's going to](https://youtu.be/ATjXcjSgnE0?t=01h40m54s)

[end up happening is this is](https://youtu.be/ATjXcjSgnE0?t=01h40m56s)

[um very similar to how i'm trying to](https://youtu.be/ATjXcjSgnE0?t=01h40m58s)

[think of a good example](https://youtu.be/ATjXcjSgnE0?t=01h41m01s)

[old school task manager](https://youtu.be/ATjXcjSgnE0?t=01h41m04s)

[how that's effectively working so inside](https://youtu.be/ATjXcjSgnE0?t=01h41m07s)

[of the desktop window manager](https://youtu.be/ATjXcjSgnE0?t=01h41m09s)

[there is sort of similar to the wpf](https://youtu.be/ATjXcjSgnE0?t=01h41m12s)

[adorner layer where there's always a](https://youtu.be/ATjXcjSgnE0?t=01h41m15s)

[layer of things that can](https://youtu.be/ATjXcjSgnE0?t=01h41m17s)

[sit on top of everything else so there's](https://youtu.be/ATjXcjSgnE0?t=01h41m18s)

[kind of this](https://youtu.be/ATjXcjSgnE0?t=01h41m20s)

[this two-tiered hierarchy if you will of](https://youtu.be/ATjXcjSgnE0?t=01h41m21s)

[your windows you've got](https://youtu.be/ATjXcjSgnE0?t=01h41m24s)

[you've got your topmost windows and then](https://youtu.be/ATjXcjSgnE0?t=01h41m25s)

[you've got all the peon windows beneath](https://youtu.be/ATjXcjSgnE0?t=01h41m28s)

[that](https://youtu.be/ATjXcjSgnE0?t=01h41m29s)

[right so those things are all floating](https://youtu.be/ATjXcjSgnE0?t=01h41m30s)

[so even though this window](https://youtu.be/ATjXcjSgnE0?t=01h41m32s)

[the visual studio window has focus now](https://youtu.be/ATjXcjSgnE0?t=01h41m34s)

[the demo app](https://youtu.be/ATjXcjSgnE0?t=01h41m37s)

[because it's top most gets to win](https://youtu.be/ATjXcjSgnE0?t=01h41m38s)

[and i think rather than trying to have](https://youtu.be/ATjXcjSgnE0?t=01h41m42s)

[xaml test work around this i think this](https://youtu.be/ATjXcjSgnE0?t=01h41m43s)

[is going to be a case of](https://youtu.be/ATjXcjSgnE0?t=01h41m46s)

[domain knowledge and i'm just going to](https://youtu.be/ATjXcjSgnE0?t=01h41m47s)

[step top most on my window and be done](https://youtu.be/ATjXcjSgnE0?t=01h41m50s)

[with it](https://youtu.be/ATjXcjSgnE0?t=01h41m52s)

[which seems like the simplest fix](https://youtu.be/ATjXcjSgnE0?t=01h41m54s)

[overall so we're gonna do that](https://youtu.be/ATjXcjSgnE0?t=01h41m57s)

[and then we're gonna come up here](https://youtu.be/ATjXcjSgnE0?t=01h42m01s)

[because there's two create window](https://youtu.be/ATjXcjSgnE0?t=01h42m04s)

[yeah we're gonna do this](https://youtu.be/ATjXcjSgnE0?t=01h42m08s)

[we're just gonna always run those in](https://youtu.be/ATjXcjSgnE0?t=01h42m11s)

[topmost actually i guess we've got one](https://youtu.be/ATjXcjSgnE0?t=01h42m13s)

[down more down here](https://youtu.be/ATjXcjSgnE0?t=01h42m15s)

[set all of those to topmost now i have](https://youtu.be/ATjXcjSgnE0?t=01h42m19s)

[edited both the demo app and i would](https://youtu.be/ATjXcjSgnE0?t=01h42m22s)

[like to not include that change so we'll](https://youtu.be/ATjXcjSgnE0?t=01h42m24s)

[discard that](https://youtu.be/ATjXcjSgnE0?t=01h42m26s)

[stage the rest check the changes](https://youtu.be/ATjXcjSgnE0?t=01h42m27s)

[true true true](https://youtu.be/ATjXcjSgnE0?t=01h42m31s)

[setting topmost on windows](https://youtu.be/ATjXcjSgnE0?t=01h42m34s)

[to prevent adio](https://youtu.be/ATjXcjSgnE0?t=01h42m39s)

[provisioner from getting](https://youtu.be/ATjXcjSgnE0?t=01h42m43s)

[on top because](https://youtu.be/ATjXcjSgnE0?t=01h42m46s)

[big](https://youtu.be/ATjXcjSgnE0?t=01h42m54s)

[i want you to know i i had to take a um](https://youtu.be/ATjXcjSgnE0?t=01h42m57s)

[a test the other day that claimed that](https://youtu.be/ATjXcjSgnE0?t=01h43m01s)

[uh in terms of intelligence my spelling](https://youtu.be/ATjXcjSgnE0?t=01h43m05s)

[skill is average i](https://youtu.be/ATjXcjSgnE0?t=01h43m07s)

[significantly doubted the quality of the](https://youtu.be/ATjXcjSgnE0?t=01h43m10s)

[test because for me to be an average](https://youtu.be/ATjXcjSgnE0?t=01h43m12s)

[speller means that there has to be](https://youtu.be/ATjXcjSgnE0?t=01h43m14s)

[people out there worse than me](https://youtu.be/ATjXcjSgnE0?t=01h43m15s)

[and i haven't met very many of those](https://youtu.be/ATjXcjSgnE0?t=01h43m18s)

[people](https://youtu.be/ATjXcjSgnE0?t=01h43m20s)

[and the few that i have are all](https://youtu.be/ATjXcjSgnE0?t=01h43m21s)

[developers](https://youtu.be/ATjXcjSgnE0?t=01h43m23s)

[developers overall are really not great](https://youtu.be/ATjXcjSgnE0?t=01h43m26s)

[spellers we're pretty bad at it](https://youtu.be/ATjXcjSgnE0?t=01h43m27s)

[okay so we're gonna let this guy go](https://youtu.be/ATjXcjSgnE0?t=01h43m30s)

[so this one pipeline passed huzzah](https://youtu.be/ATjXcjSgnE0?t=01h43m34s)

[okay so there's there is more](https://youtu.be/ATjXcjSgnE0?t=01h43m43s)

[fixes in and done okay so this guy is](https://youtu.be/ATjXcjSgnE0?t=01h43m46s)

[now going to chug and we're going to see](https://youtu.be/ATjXcjSgnE0?t=01h43m48s)

[what](https://youtu.be/ATjXcjSgnE0?t=01h43m50s)

[what goes on i do wonder because there](https://youtu.be/ATjXcjSgnE0?t=01h43m50s)

[was a](https://youtu.be/ATjXcjSgnE0?t=01h43m53s)

[there was a commit here](https://youtu.be/ATjXcjSgnE0?t=01h43m54s)

[maybe it was a test that i ran](https://youtu.be/ATjXcjSgnE0?t=01h44m01s)

[where i know there are a few in here](https://youtu.be/ATjXcjSgnE0?t=01h44m04s)

[where i intentionally disabled some](https://youtu.be/ATjXcjSgnE0?t=01h44m08s)

[problematic tests](https://youtu.be/ATjXcjSgnE0?t=01h44m09s)

[we might need to go back and re-enable](https://youtu.be/ATjXcjSgnE0?t=01h44m12s)

[these if this works](https://youtu.be/ATjXcjSgnE0?t=01h44m14s)

[um i don't need that anymore go away](https://youtu.be/ATjXcjSgnE0?t=01h44m15s)

[so if this ends up working that will fix](https://youtu.be/ATjXcjSgnE0?t=01h44m19s)

[that so we're going to let](https://youtu.be/ATjXcjSgnE0?t=01h44m21s)

[let that guy run for now and let's check](https://youtu.be/ATjXcjSgnE0?t=01h44m23s)

[what else is still](https://youtu.be/ATjXcjSgnE0?t=01h44m26s)

[outstanding](https://youtu.be/ATjXcjSgnE0?t=01h44m27s)

[uh](https://youtu.be/ATjXcjSgnE0?t=01h44m32s)

[wait what oh this is not milestone](https://youtu.be/ATjXcjSgnE0?t=01h44m38s)

[limited](https://youtu.be/ATjXcjSgnE0?t=01h44m41s)

[okay it's like there's there is stuff](https://youtu.be/ATjXcjSgnE0?t=01h44m42s)

[here that i am not expecting](https://youtu.be/ATjXcjSgnE0?t=01h44m44s)

[okay and so this one here](https://youtu.be/ATjXcjSgnE0?t=01h44m49s)

[this is expected to be built on top](https://youtu.be/ATjXcjSgnE0?t=01h44m53s)

[of the other changes](https://youtu.be/ATjXcjSgnE0?t=01h44m56s)

[uh or no this is not this is just](https://youtu.be/ATjXcjSgnE0?t=01h45m00s)

[straight up broken](https://youtu.be/ATjXcjSgnE0?t=01h45m03s)

[this is legitimately broken](https://youtu.be/ATjXcjSgnE0?t=01h45m08s)

[and we need to address this but i wanted](https://youtu.be/ATjXcjSgnE0?t=01h45m14s)

[to address this on top of the other](https://youtu.be/ATjXcjSgnE0?t=01h45m17s)

[changes](https://youtu.be/ATjXcjSgnE0?t=01h45m19s)

[so let's come back over here](https://youtu.be/ATjXcjSgnE0?t=01h45m19s)

[what was the](https://youtu.be/ATjXcjSgnE0?t=01h45m23s)

[uh fix 2362 so let's](https://youtu.be/ATjXcjSgnE0?t=01h45m27s)

[find that branch 2362 so this](https://youtu.be/ATjXcjSgnE0?t=01h45m30s)

[is](https://youtu.be/ATjXcjSgnE0?t=01h45m34s)

[oh so this one i already did rebase but](https://youtu.be/ATjXcjSgnE0?t=01h45m39s)

[i just didn't push the change because](https://youtu.be/ATjXcjSgnE0?t=01h45m41s)

[this](https://youtu.be/ATjXcjSgnE0?t=01h45m43s)

[failed so let's take](https://youtu.be/ATjXcjSgnE0?t=01h45m44s)

[we let's take my local 2362](https://youtu.be/ATjXcjSgnE0?t=01h45m47s)

[rebase it on this](https://youtu.be/ATjXcjSgnE0?t=01h45m52s)

[okay that should be a little bit cleaner](https://youtu.be/ATjXcjSgnE0?t=01h45m57s)

[that's the fix for it](https://youtu.be/ATjXcjSgnE0?t=01h46m05s)

[um but we want to](https://youtu.be/ATjXcjSgnE0?t=01h46m08s)

[wait to push until we confirm that the](https://youtu.be/ATjXcjSgnE0?t=01h46m12s)

[xaml test change is in fact](https://youtu.be/ATjXcjSgnE0?t=01h46m14s)

[good because you'll note the fix for](https://youtu.be/ATjXcjSgnE0?t=01h46m15s)

[this](https://youtu.be/ATjXcjSgnE0?t=01h46m18s)

[is](https://youtu.be/ATjXcjSgnE0?t=01h46m19s)

[included inside of that](https://youtu.be/ATjXcjSgnE0?t=01h46m24s)

[one of my co-workers was being](https://youtu.be/ATjXcjSgnE0?t=01h46m32s)

[hysterical and i was asking what kind of](https://youtu.be/ATjXcjSgnE0?t=01h46m33s)

[stream deck](https://youtu.be/ATjXcjSgnE0?t=01h46m35s)

[is everyone purchasing](https://youtu.be/ATjXcjSgnE0?t=01h46m37s)

[um i i may actually go through](https://youtu.be/ATjXcjSgnE0?t=01h46m40s)

[do i have it with me](https://youtu.be/ATjXcjSgnE0?t=01h46m43s)

[i do okay show and tell time](https://youtu.be/ATjXcjSgnE0?t=01h46m48s)

[so i actually made my own](https://youtu.be/ATjXcjSgnE0?t=01h46m53s)

[so i got one of these um that's really](https://youtu.be/ATjXcjSgnE0?t=01h46m58s)

[funny because my green screen is making](https://youtu.be/ATjXcjSgnE0?t=01h47m01s)

[so those transparent buttons yeah those](https://youtu.be/ATjXcjSgnE0?t=01h47m03s)

[are actually painted green so you can](https://youtu.be/ATjXcjSgnE0?t=01h47m05s)

[only kind of read it so i i purchased](https://youtu.be/ATjXcjSgnE0?t=01h47m08s)

[this programmable nine key](https://youtu.be/ATjXcjSgnE0?t=01h47m11s)

[and then i took my 3d printer and](https://youtu.be/ATjXcjSgnE0?t=01h47m13s)

[printed custom keycaps because that was](https://youtu.be/ATjXcjSgnE0?t=01h47m15s)

[just fun](https://youtu.be/ATjXcjSgnE0?t=01h47m17s)

[and the initial intent with this was um](https://youtu.be/ATjXcjSgnE0?t=01h47m18s)

[through my work we use uh toggle to](https://youtu.be/ATjXcjSgnE0?t=01h47m22s)

[manage our our timesheets and keeping](https://youtu.be/ATjXcjSgnE0?t=01h47m25s)

[track of our](https://youtu.be/ATjXcjSgnE0?t=01h47m27s)

[our billable hours um and there](https://youtu.be/ATjXcjSgnE0?t=01h47m27s)

[now i know there are apps out there for](https://youtu.be/ATjXcjSgnE0?t=01h47m31s)

[toggle](https://youtu.be/ATjXcjSgnE0?t=01h47m33s)

[and i am sure any of those would have](https://youtu.be/ATjXcjSgnE0?t=01h47m34s)

[been much easier options than what i did](https://youtu.be/ATjXcjSgnE0?t=01h47m36s)

[um i i arguably took the hardest](https://youtu.be/ATjXcjSgnE0?t=01h47m39s)

[possible](https://youtu.be/ATjXcjSgnE0?t=01h47m42s)

[thing uh well which one uh let me grab](https://youtu.be/ATjXcjSgnE0?t=01h47m43s)

[let me grab a link if anybody is](https://youtu.be/ATjXcjSgnE0?t=01h47m46s)

[interested](https://youtu.be/ATjXcjSgnE0?t=01h47m48s)

[um so](https://youtu.be/ATjXcjSgnE0?t=01h47m49s)

[there are i got to go back to my old](https://youtu.be/ATjXcjSgnE0?t=01h47m52s)

[amazon orders](https://youtu.be/ATjXcjSgnE0?t=01h47m54s)

[and i'll find it so what i ended up](https://youtu.be/ATjXcjSgnE0?t=01h47m56s)

[doing was writing](https://youtu.be/ATjXcjSgnE0?t=01h47m58s)

[a little cli app which](https://youtu.be/ATjXcjSgnE0?t=01h47m59s)

[i published so i can show that to you](https://youtu.be/ATjXcjSgnE0?t=01h48m03s)

[here but](https://youtu.be/ATjXcjSgnE0?t=01h48m05s)

[this is this is what i ended up getting](https://youtu.be/ATjXcjSgnE0?t=01h48m06s)

[is one of these little suckers and i was](https://youtu.be/ATjXcjSgnE0?t=01h48m11s)

[contemplating writing a blog post on i](https://youtu.be/ATjXcjSgnE0?t=01h48m14s)

[don't know if people will find this](https://youtu.be/ATjXcjSgnE0?t=01h48m16s)

[interesting](https://youtu.be/ATjXcjSgnE0?t=01h48m17s)

[because most of the effort in doing this](https://youtu.be/ATjXcjSgnE0?t=01h48m18s)

[was somewhat of a learning experience](https://youtu.be/ATjXcjSgnE0?t=01h48m20s)

[for me](https://youtu.be/ATjXcjSgnE0?t=01h48m22s)

[and it was again probably the hardest](https://youtu.be/ATjXcjSgnE0?t=01h48m23s)

[way to solve](https://youtu.be/ATjXcjSgnE0?t=01h48m27s)

[the the issue of how do you start and](https://youtu.be/ATjXcjSgnE0?t=01h48m28s)

[stop your time](https://youtu.be/ATjXcjSgnE0?t=01h48m30s)

[on an online timer there there are](https://youtu.be/ATjXcjSgnE0?t=01h48m31s)

[definitely easier options](https://youtu.be/ATjXcjSgnE0?t=01h48m33s)

[um so i programmable nine key](https://youtu.be/ATjXcjSgnE0?t=01h48m36s)

[custom keycaps and then i programmed](https://youtu.be/ATjXcjSgnE0?t=01h48m39s)

[each of these](https://youtu.be/ATjXcjSgnE0?t=01h48m42s)

[keys to the upper level function keys so](https://youtu.be/ATjXcjSgnE0?t=01h48m44s)

[like um](https://youtu.be/ATjXcjSgnE0?t=01h48m46s)

[f13 on up and you'll note that on some](https://youtu.be/ATjXcjSgnE0?t=01h48m47s)

[of the buttons there's like multiple](https://youtu.be/ATjXcjSgnE0?t=01h48m50s)

[little icons on them](https://youtu.be/ATjXcjSgnE0?t=01h48m52s)

[and the intent there was these bottom](https://youtu.be/ATjXcjSgnE0?t=01h48m54s)

[little two and three toggles](https://youtu.be/ATjXcjSgnE0?t=01h48m56s)

[this little programmable nine key has](https://youtu.be/ATjXcjSgnE0?t=01h48m59s)

[three layers on it and so i programmed](https://youtu.be/ATjXcjSgnE0?t=01h49m01s)

[those two and threes to toggle between](https://youtu.be/ATjXcjSgnE0?t=01h49m03s)

[the different layers](https://youtu.be/ATjXcjSgnE0?t=01h49m05s)

[and so i have one layer um to do obs](https://youtu.be/ATjXcjSgnE0?t=01h49m06s)

[streaming and toggle my](https://youtu.be/ATjXcjSgnE0?t=01h49m09s)

[my scenes and whatnot i have another](https://youtu.be/ATjXcjSgnE0?t=01h49m11s)

[layer to do my](https://youtu.be/ATjXcjSgnE0?t=01h49m13s)

[my toggle time timesheet stuff and then](https://youtu.be/ATjXcjSgnE0?t=01h49m14s)

[i've got another layer](https://youtu.be/ATjXcjSgnE0?t=01h49m17s)

[for doing my music because when you're](https://youtu.be/ATjXcjSgnE0?t=01h49m18s)

[programming you gotta listen to music](https://youtu.be/ATjXcjSgnE0?t=01h49m21s)

[and sometimes it's important to](https://youtu.be/ATjXcjSgnE0?t=01h49m22s)

[you know skip to the next song or mute](https://youtu.be/ATjXcjSgnE0?t=01h49m24s)

[or whatever](https://youtu.be/ATjXcjSgnE0?t=01h49m26s)

[and so i i programmed all of those](https://youtu.be/ATjXcjSgnE0?t=01h49m27s)

[things together](https://youtu.be/ATjXcjSgnE0?t=01h49m29s)

[and then i took um auto hotkey](https://youtu.be/ATjXcjSgnE0?t=01h49m30s)

[um is what is listening for the upper](https://youtu.be/ATjXcjSgnE0?t=01h49m35s)

[level](https://youtu.be/ATjXcjSgnE0?t=01h49m38s)

[um function key codes and then it's just](https://youtu.be/ATjXcjSgnE0?t=01h49m39s)

[invoking my cli app](https://youtu.be/ATjXcjSgnE0?t=01h49m41s)

[so if people are interested i don't](https://youtu.be/ATjXcjSgnE0?t=01h49m44s)

[uh what did i call it](https://youtu.be/ATjXcjSgnE0?t=01h49m47s)

[uh time logger that's yeah](https://youtu.be/ATjXcjSgnE0?t=01h49m53s)

[so if anybody is interested this is the](https://youtu.be/ATjXcjSgnE0?t=01h49m56s)

[little cli app for interacting with](https://youtu.be/ATjXcjSgnE0?t=01h49m59s)

[toggle](https://youtu.be/ATjXcjSgnE0?t=01h50m01s)

[this is not an advanced thingy](https://youtu.be/ATjXcjSgnE0?t=01h50m01s)

[and i should probably rename this](https://youtu.be/ATjXcjSgnE0?t=01h50m05s)

[because when it came time to publish it](https://youtu.be/ATjXcjSgnE0?t=01h50m07s)

[as a](https://youtu.be/ATjXcjSgnE0?t=01h50m09s)

[net global tool um i had to poke around](https://youtu.be/ATjXcjSgnE0?t=01h50m09s)

[for available names](https://youtu.be/ATjXcjSgnE0?t=01h50m13s)

[and one of my co-workers suggested the](https://youtu.be/ATjXcjSgnE0?t=01h50m15s)

[name cadence](https://youtu.be/ATjXcjSgnE0?t=01h50m18s)

[which worked rather nicely so it's](https://youtu.be/ATjXcjSgnE0?t=01h50m19s)

[this is really one of those this tool](https://youtu.be/ATjXcjSgnE0?t=01h50m24s)

[was built](https://youtu.be/ATjXcjSgnE0?t=01h50m25s)

[for me for one specific purpose pull](https://youtu.be/ATjXcjSgnE0?t=01h50m27s)

[request welcome](https://youtu.be/ATjXcjSgnE0?t=01h50m30s)

[i'm happy to accept him one of my other](https://youtu.be/ATjXcjSgnE0?t=01h50m30s)

[co-workers was playing around with it](https://youtu.be/ATjXcjSgnE0?t=01h50m32s)

[um and submitted a few things to go](https://youtu.be/ATjXcjSgnE0?t=01h50m34s)

[through and do it but](https://youtu.be/ATjXcjSgnE0?t=01h50m37s)

[it it accepts time entries and i can](https://youtu.be/ATjXcjSgnE0?t=01h50m38s)

[then manage my](https://youtu.be/ATjXcjSgnE0?t=01h50m40s)

[my toggle timesheet oh look at that the](https://youtu.be/ATjXcjSgnE0?t=01h50m41s)

[pipeline worked](https://youtu.be/ATjXcjSgnE0?t=01h50m44s)

[yes okay so topmost may have been](https://youtu.be/ATjXcjSgnE0?t=01h50m45s)

[what was biting me on all of those past](https://youtu.be/ATjXcjSgnE0?t=01h50m50s)

[runs](https://youtu.be/ATjXcjSgnE0?t=01h50m52s)

[okay so i would like to go back and look](https://youtu.be/ATjXcjSgnE0?t=01h50m53s)

[at the skip](https://youtu.be/ATjXcjSgnE0?t=01h50m57s)

[one so let's let's take a look](https://youtu.be/ATjXcjSgnE0?t=01h50m57s)

[skip skip skip skip skip skip skip so i](https://youtu.be/ATjXcjSgnE0?t=01h51m02s)

[disabled a few tests because they were](https://youtu.be/ATjXcjSgnE0?t=01h51m06s)

[they were causing failures and i wasn't](https://youtu.be/ATjXcjSgnE0?t=01h51m09s)

[sure whether they were related to](https://youtu.be/ATjXcjSgnE0?t=01h51m11s)

[i wasn't sure what was causing them and](https://youtu.be/ATjXcjSgnE0?t=01h51m16s)

[i was](https://youtu.be/ATjXcjSgnE0?t=01h51m19s)

[annoyed and so i started doing bad](https://youtu.be/ATjXcjSgnE0?t=01h51m20s)

[things and i think that](https://youtu.be/ATjXcjSgnE0?t=01h51m23s)

[the doing bad things part was](https://youtu.be/ATjXcjSgnE0?t=01h51m24s)

[probably what was problematic](https://youtu.be/ATjXcjSgnE0?t=01h51m28s)

[because all of these tests worked on the](https://youtu.be/ATjXcjSgnE0?t=01h51m31s)

[previous version of xaml test](https://youtu.be/ATjXcjSgnE0?t=01h51m32s)

[and i didn't make any major changes okay](https://youtu.be/ATjXcjSgnE0?t=01h51m34s)

[those are just icon bits](https://youtu.be/ATjXcjSgnE0?t=01h51m37s)

[those are link calls yeah](https://youtu.be/ATjXcjSgnE0?t=01h51m39s)

[i think it was just those three tests so](https://youtu.be/ATjXcjSgnE0?t=01h51m42s)

[let's see](https://youtu.be/ATjXcjSgnE0?t=01h51m44s)

[re-enabling skip](https://youtu.be/ATjXcjSgnE0?t=01h51m48s)

[tests perfect re-enable](https://youtu.be/ATjXcjSgnE0?t=01h51m51s)

[push uh](https://youtu.be/ATjXcjSgnE0?t=01h51m55s)

[oh cancel](https://youtu.be/ATjXcjSgnE0?t=01h51m58s)

[this is a good lesson so i just did this](https://youtu.be/ATjXcjSgnE0?t=01h52m01s)

[change](https://youtu.be/ATjXcjSgnE0?t=01h52m04s)

[and i did it on my change that is](https://youtu.be/ATjXcjSgnE0?t=01h52m05s)

[designed to fix the floating offset](https://youtu.be/ATjXcjSgnE0?t=01h52m07s)

[not on my update xaml test branch](https://youtu.be/ATjXcjSgnE0?t=01h52m09s)

[which is where i want it so this is a](https://youtu.be/ATjXcjSgnE0?t=01h52m12s)

[great example](https://youtu.be/ATjXcjSgnE0?t=01h52m15s)

[of when you mess up in git how should](https://youtu.be/ATjXcjSgnE0?t=01h52m16s)

[you fix it](https://youtu.be/ATjXcjSgnE0?t=01h52m18s)

[so in this case what i really want to do](https://youtu.be/ATjXcjSgnE0?t=01h52m19s)

[is take this commit right here](https://youtu.be/ATjXcjSgnE0?t=01h52m20s)

[and put it over on this branch so what](https://youtu.be/ATjXcjSgnE0?t=01h52m22s)

[i'm going to do is switch to the branch](https://youtu.be/ATjXcjSgnE0?t=01h52m24s)

[that i want to be on first](https://youtu.be/ATjXcjSgnE0?t=01h52m26s)

[and then i'm going to come up here and](https://youtu.be/ATjXcjSgnE0?t=01h52m28s)

[i'm going to just cherry-pick this](https://youtu.be/ATjXcjSgnE0?t=01h52m29s)

[commit](https://youtu.be/ATjXcjSgnE0?t=01h52m31s)

[and then does it says do you want to](https://youtu.be/ATjXcjSgnE0?t=01h52m32s)

[immediately commit it yes please](https://youtu.be/ATjXcjSgnE0?t=01h52m33s)

[so uh in terms of git the cherry pick](https://youtu.be/ATjXcjSgnE0?t=01h52m36s)

[command](https://youtu.be/ATjXcjSgnE0?t=01h52m39s)

[just goes through and says make me a new](https://youtu.be/ATjXcjSgnE0?t=01h52m40s)

[commit with these](https://youtu.be/ATjXcjSgnE0?t=01h52m43s)

[exact same deltas because a commit is](https://youtu.be/ATjXcjSgnE0?t=01h52m44s)

[just a set of deltas or changes that](https://youtu.be/ATjXcjSgnE0?t=01h52m46s)

[you've made to various files](https://youtu.be/ATjXcjSgnE0?t=01h52m48s)

[so when you cherry pick it says okay](https://youtu.be/ATjXcjSgnE0?t=01h52m50s)

[reach over there grab those deltas and](https://youtu.be/ATjXcjSgnE0?t=01h52m52s)

[then just replay those on my current](https://youtu.be/ATjXcjSgnE0?t=01h52m54s)

[branch](https://youtu.be/ATjXcjSgnE0?t=01h52m55s)

[and automatically create a commit for me](https://youtu.be/ATjXcjSgnE0?t=01h52m56s)

[and in this case you know recreate with](https://youtu.be/ATjXcjSgnE0?t=01h52m58s)

[the exact same message and all that jazz](https://youtu.be/ATjXcjSgnE0?t=01h53m00s)

[these two commits are completely](https://youtu.be/ATjXcjSgnE0?t=01h53m02s)

[different different ids](https://youtu.be/ATjXcjSgnE0?t=01h53m04s)

[you can see the um the commit hash here](https://youtu.be/ATjXcjSgnE0?t=01h53m06s)

[so two different commits they just](https://youtu.be/ATjXcjSgnE0?t=01h53m10s)

[happen to contain](https://youtu.be/ATjXcjSgnE0?t=01h53m12s)

[the exact same deltas so we're going to](https://youtu.be/ATjXcjSgnE0?t=01h53m14s)

[push this up](https://youtu.be/ATjXcjSgnE0?t=01h53m16s)

[and let that go and now the question is](https://youtu.be/ATjXcjSgnE0?t=01h53m18s)

[i've still got this bad commit back on](https://youtu.be/ATjXcjSgnE0?t=01h53m20s)

[this other branch](https://youtu.be/ATjXcjSgnE0?t=01h53m22s)

[this guy here and so what we're going to](https://youtu.be/ATjXcjSgnE0?t=01h53m23s)

[do is we're just going to take this](https://youtu.be/ATjXcjSgnE0?t=01h53m24s)

[branch](https://youtu.be/ATjXcjSgnE0?t=01h53m26s)

[and reset back one commit](https://youtu.be/ATjXcjSgnE0?t=01h53m27s)

[and in git you'll note that the commit](https://youtu.be/ATjXcjSgnE0?t=01h53m31s)

[just disappeared so this is sort of like](https://youtu.be/ATjXcjSgnE0?t=01h53m32s)

[pruning a tree](https://youtu.be/ATjXcjSgnE0?t=01h53m34s)

[uh when you move your your branch](https://youtu.be/ATjXcjSgnE0?t=01h53m36s)

[pointer back](https://youtu.be/ATjXcjSgnE0?t=01h53m38s)

[anything that no that doesn't have](https://youtu.be/ATjXcjSgnE0?t=01h53m39s)

[anything else pointed to it just gets](https://youtu.be/ATjXcjSgnE0?t=01h53m41s)

[dropped](https://youtu.be/ATjXcjSgnE0?t=01h53m42s)

[so you can imagine if you're trimming a](https://youtu.be/ATjXcjSgnE0?t=01h53m43s)

[tree and you're standing on a branch](https://youtu.be/ATjXcjSgnE0?t=01h53m45s)

[and you cut off the branch you're](https://youtu.be/ATjXcjSgnE0?t=01h53m46s)

[standing on you fall in this case if you](https://youtu.be/ATjXcjSgnE0?t=01h53m48s)

[are](https://youtu.be/ATjXcjSgnE0?t=01h53m50s)

[moving cutting your trimming your your](https://youtu.be/ATjXcjSgnE0?t=01h53m51s)

[get branch back](https://youtu.be/ATjXcjSgnE0?t=01h53m54s)

[um anything that's not held up by any](https://youtu.be/ATjXcjSgnE0?t=01h53m55s)

[other branches it just gets default](https://youtu.be/ATjXcjSgnE0?t=01h53m57s)

[okay so that should get that going and](https://youtu.be/ATjXcjSgnE0?t=01h54m03s)

[hopefully](https://youtu.be/ATjXcjSgnE0?t=01h54m06s)

[hopefully oh and actually let's go back](https://youtu.be/ATjXcjSgnE0?t=01h54m08s)

[here and i would like to](https://youtu.be/ATjXcjSgnE0?t=01h54m10s)

[because now my fix 2362 is based on](https://youtu.be/ATjXcjSgnE0?t=01h54m12s)

[an old commit not on the new commit and](https://youtu.be/ATjXcjSgnE0?t=01h54m15s)

[i want it to include this change i just](https://youtu.be/ATjXcjSgnE0?t=01h54m17s)

[don't want that change](https://youtu.be/ATjXcjSgnE0?t=01h54m19s)

[on this branch directly so what we will](https://youtu.be/ATjXcjSgnE0?t=01h54m20s)

[do is we will right click](https://youtu.be/ATjXcjSgnE0?t=01h54m23s)

[and rebase so rebase is definitely one](https://youtu.be/ATjXcjSgnE0?t=01h54m24s)

[of my](https://youtu.be/ATjXcjSgnE0?t=01h54m28s)

[preferred ways of doing this some people](https://youtu.be/ATjXcjSgnE0?t=01h54m29s)

[like to do](https://youtu.be/ATjXcjSgnE0?t=01h54m31s)

[merges i just find the rebase leaves me](https://youtu.be/ATjXcjSgnE0?t=01h54m32s)

[with a nice prettier tree so if you can](https://youtu.be/ATjXcjSgnE0?t=01h54m36s)

[wrap your head around it](https://youtu.be/ATjXcjSgnE0?t=01h54m37s)

[um i prefer it so and get the base](https://youtu.be/ATjXcjSgnE0?t=01h54m39s)

[commit](https://youtu.be/ATjXcjSgnE0?t=01h54m42s)

[is if you follow this line down it's the](https://youtu.be/ATjXcjSgnE0?t=01h54m43s)

[one at the bottom](https://youtu.be/ATjXcjSgnE0?t=01h54m45s)

[right the base of the foundation of](https://youtu.be/ATjXcjSgnE0?t=01h54m47s)

[anything is the one at the bottom](https://youtu.be/ATjXcjSgnE0?t=01h54m48s)

[so in this case if we just follow the](https://youtu.be/ATjXcjSgnE0?t=01h54m50s)

[blue line down this guy down here is my](https://youtu.be/ATjXcjSgnE0?t=01h54m51s)

[base command](https://youtu.be/ATjXcjSgnE0?t=01h54m54s)

[i would like the base of these three](https://youtu.be/ATjXcjSgnE0?t=01h54m55s)

[commits to be this one](https://youtu.be/ATjXcjSgnE0?t=01h54m56s)

[which is conveniently where this guy is](https://youtu.be/ATjXcjSgnE0?t=01h54m58s)

[so if i just right click on him](https://youtu.be/ATjXcjSgnE0?t=01h55m01s)

[and say read base my fix 2362](https://youtu.be/ATjXcjSgnE0?t=01h55m03s)

[onto update xaml test it's going to](https://youtu.be/ATjXcjSgnE0?t=01h55m06s)

[change the base and do it](https://youtu.be/ATjXcjSgnE0?t=01h55m09s)

[and when you run the rebase command what](https://youtu.be/ATjXcjSgnE0?t=01h55m13s)

[git um](https://youtu.be/ATjXcjSgnE0?t=01h55m15s)

[ends up doing is it takes all of your](https://youtu.be/ATjXcjSgnE0?t=01h55m17s)

[commits](https://youtu.be/ATjXcjSgnE0?t=01h55m19s)

[because git knows the relationship](https://youtu.be/ATjXcjSgnE0?t=01h55m20s)

[between all of your branches](https://youtu.be/ATjXcjSgnE0?t=01h55m22s)

[or at least it can derive the](https://youtu.be/ATjXcjSgnE0?t=01h55m23s)

[relationship between all your branches](https://youtu.be/ATjXcjSgnE0?t=01h55m25s)

[and it will replay your commits one at a](https://youtu.be/ATjXcjSgnE0?t=01h55m27s)

[time](https://youtu.be/ATjXcjSgnE0?t=01h55m29s)

[because if we go and look at these](https://youtu.be/ATjXcjSgnE0?t=01h55m30s)

[commits um](https://youtu.be/ATjXcjSgnE0?t=01h55m31s)

[the this thing shows let's see uh](https://youtu.be/ATjXcjSgnE0?t=01h55m34s)

[authored](https://youtu.be/ATjXcjSgnE0?t=01h55m36s)

[oh i guess get cracking doesn't show it](https://youtu.be/ATjXcjSgnE0?t=01h55m38s)

[if you look at the commit on the command](https://youtu.be/ATjXcjSgnE0?t=01h55m40s)

[line you'll end up seeing the modified](https://youtu.be/ATjXcjSgnE0?t=01h55m42s)

[date](https://youtu.be/ATjXcjSgnE0?t=01h55m44s)

[um as today which starts to get a little](https://youtu.be/ATjXcjSgnE0?t=01h55m45s)

[weird for](https://youtu.be/ATjXcjSgnE0?t=01h55m49s)

[for some people because the the dates on](https://youtu.be/ATjXcjSgnE0?t=01h55m50s)

[a git commit](https://youtu.be/ATjXcjSgnE0?t=01h55m52s)

[are probably when they happened it's](https://youtu.be/ATjXcjSgnE0?t=01h55m54s)

[just with git](https://youtu.be/ATjXcjSgnE0?t=01h55m56s)

[we get to be time travelers and we can](https://youtu.be/ATjXcjSgnE0?t=01h55m57s)

[make time be whatever we want](https://youtu.be/ATjXcjSgnE0?t=01h56m01s)

[which is awesome awesome](https://youtu.be/ATjXcjSgnE0?t=01h56m03s)

[i use git when i teach at the the local](https://youtu.be/ATjXcjSgnE0?t=01h56m06s)

[university](https://youtu.be/ATjXcjSgnE0?t=01h56m09s)

[and one of the things that we discussed](https://youtu.be/ATjXcjSgnE0?t=01h56m10s)

[while doing that is well what happens if](https://youtu.be/ATjXcjSgnE0?t=01h56m12s)

[a student you know tries to cheat a](https://youtu.be/ATjXcjSgnE0?t=01h56m14s)

[deadline](https://youtu.be/ATjXcjSgnE0?t=01h56m16s)

[by adjusting the the time stamps on](https://youtu.be/ATjXcjSgnE0?t=01h56m16s)

[their git commit and ultimately what we](https://youtu.be/ATjXcjSgnE0?t=01h56m18s)

[came to the conclusion of is](https://youtu.be/ATjXcjSgnE0?t=01h56m20s)

[if students spend enough time to learn](https://youtu.be/ATjXcjSgnE0?t=01h56m22s)

[git to figure out how to do that](https://youtu.be/ATjXcjSgnE0?t=01h56m23s)

[they deserve it so don't tell my](https://youtu.be/ATjXcjSgnE0?t=01h56m25s)

[students that that would be bad](https://youtu.be/ATjXcjSgnE0?t=01h56m28s)

[uh but it's one of those](https://youtu.be/ATjXcjSgnE0?t=01h56m30s)

[if they if they want to learn get well](https://youtu.be/ATjXcjSgnE0?t=01h56m33s)

[enough to understand you know rebases](https://youtu.be/ATjXcjSgnE0?t=01h56m35s)

[and](https://youtu.be/ATjXcjSgnE0?t=01h56m37s)

[and mucking with the timestamps and](https://youtu.be/ATjXcjSgnE0?t=01h56m38s)

[changing authors and all that](https://youtu.be/ATjXcjSgnE0?t=01h56m40s)

[kind of fun stuff um more power to them](https://youtu.be/ATjXcjSgnE0?t=01h56m41s)

[there's also a here fun tool fun tool](https://youtu.be/ATjXcjSgnE0?t=01h56m45s)

[don't recommend using this](https://youtu.be/ATjXcjSgnE0?t=01h56m48s)

[in any production environment but get](https://youtu.be/ATjXcjSgnE0?t=01h56m49s)

[blame](https://youtu.be/ATjXcjSgnE0?t=01h56m52s)

[someone else](https://youtu.be/ATjXcjSgnE0?t=01h56m53s)

[uh yes](https://youtu.be/ATjXcjSgnE0?t=01h56m58s)

[do they get bonus points if one of the](https://youtu.be/ATjXcjSgnE0?t=01h57m04s)

[instructors authors to commit](https://youtu.be/ATjXcjSgnE0?t=01h57m05s)

[oh oh](https://youtu.be/ATjXcjSgnE0?t=01h57m07s)

[haven't had that happen](https://youtu.be/ATjXcjSgnE0?t=01h57m11s)

[but that might be kind of cool](https://youtu.be/ATjXcjSgnE0?t=01h57m15s)

[i i will say every quarter there's](https://youtu.be/ATjXcjSgnE0?t=01h57m18s)

[always at least one student that does](https://youtu.be/ATjXcjSgnE0?t=01h57m21s)

[something that absolutely](https://youtu.be/ATjXcjSgnE0?t=01h57m23s)

[amazes me where i end up looking at it](https://youtu.be/ATjXcjSgnE0?t=01h57m24s)

[and going huh](https://youtu.be/ATjXcjSgnE0?t=01h57m26s)

[didn't know i could do that so students](https://youtu.be/ATjXcjSgnE0?t=01h57m28s)

[are remarkably ingenious](https://youtu.be/ATjXcjSgnE0?t=01h57m31s)

[doesn't always work out in their favor](https://youtu.be/ATjXcjSgnE0?t=01h57m33s)

[but they're remarkably ingenious](https://youtu.be/ATjXcjSgnE0?t=01h57m34s)

[so if you are interested](https://youtu.be/ATjXcjSgnE0?t=01h57m36s)

[this this lovely lovely little tool here](https://youtu.be/ATjXcjSgnE0?t=01h57m40s)

[of](https://youtu.be/ATjXcjSgnE0?t=01h57m43s)

[uh going through and saying i would like](https://youtu.be/ATjXcjSgnE0?t=01h57m45s)

[to change this](https://youtu.be/ATjXcjSgnE0?t=01h57m48s)

[yes i think that i think that's what](https://youtu.be/ATjXcjSgnE0?t=01h57m54s)

[should happen](https://youtu.be/ATjXcjSgnE0?t=01h57m58s)

[i think that's exactly what should](https://youtu.be/ATjXcjSgnE0?t=01h58m00s)

[happen](https://youtu.be/ATjXcjSgnE0?t=01h58m04s)

[yeah so if if hypothetically you would](https://youtu.be/ATjXcjSgnE0?t=01h58m06s)

[like](https://youtu.be/ATjXcjSgnE0?t=01h58m09s)

[a convenience tool you can also do so](https://youtu.be/ATjXcjSgnE0?t=01h58m09s)

[this get blame someone else](https://youtu.be/ATjXcjSgnE0?t=01h58m12s)

[is actually you can do it with just](https://youtu.be/ATjXcjSgnE0?t=01h58m14s)

[straight git commands](https://youtu.be/ATjXcjSgnE0?t=01h58m16s)

[as well you can go through find a commit](https://youtu.be/ATjXcjSgnE0?t=01h58m17s)

[go through um adjust all of the data in](https://youtu.be/ATjXcjSgnE0?t=01h58m21s)

[the commit if you want and then force](https://youtu.be/ATjXcjSgnE0?t=01h58m24s)

[push](https://youtu.be/ATjXcjSgnE0?t=01h58m25s)

[that's all it takes um all this tool](https://youtu.be/ATjXcjSgnE0?t=01h58m26s)

[does is automate](https://youtu.be/ATjXcjSgnE0?t=01h58m30s)

[automate away all of that and making it](https://youtu.be/ATjXcjSgnE0?t=01h58m31s)

[very easy](https://youtu.be/ATjXcjSgnE0?t=01h58m33s)

[so that](https://youtu.be/ATjXcjSgnE0?t=01h58m34s)

[so that it works rather easy](https://youtu.be/ATjXcjSgnE0?t=01h58m38s)

[just fake commit here oh](https://youtu.be/ATjXcjSgnE0?t=01h58m44s)

[this is just this is also so this tool](https://youtu.be/ATjXcjSgnE0?t=01h58m47s)

[here is an](https://youtu.be/ATjXcjSgnE0?t=01h58m51s)

[excellent reason why um](https://youtu.be/ATjXcjSgnE0?t=01h58m51s)

[[Music]](https://youtu.be/ATjXcjSgnE0?t=01h58m54s)

[yes uh this tool is also a reason why](https://youtu.be/ATjXcjSgnE0?t=01h58m59s)

[you should um set your get up with](https://youtu.be/ATjXcjSgnE0?t=01h59m03s)

[uh pgp keys so that your commits can be](https://youtu.be/ATjXcjSgnE0?t=01h59m06s)

[signed](https://youtu.be/ATjXcjSgnE0?t=01h59m09s)

[because then it's very hard for somebody](https://youtu.be/ATjXcjSgnE0?t=01h59m10s)

[to just fake that it was you](https://youtu.be/ATjXcjSgnE0?t=01h59m12s)

[because they would have to be able to](https://youtu.be/ATjXcjSgnE0?t=01h59m14s)

[sign the commit as you](https://youtu.be/ATjXcjSgnE0?t=01h59m15s)

[now how often is that important](https://youtu.be/ATjXcjSgnE0?t=01h59m17s)

[that's that that's the level of](https://youtu.be/ATjXcjSgnE0?t=01h59m23s)

[importance it's good if you want to](https://youtu.be/ATjXcjSgnE0?t=01h59m25s)

[ensure](https://youtu.be/ATjXcjSgnE0?t=01h59m27s)

[authorship this pass already](https://youtu.be/ATjXcjSgnE0?t=01h59m28s)

[i was gonna say that that was gonna be](https://youtu.be/ATjXcjSgnE0?t=01h59m33s)

[remarkably fast if it did](https://youtu.be/ATjXcjSgnE0?t=01h59m34s)

[let's go and pop this guy open](https://youtu.be/ATjXcjSgnE0?t=01h59m36s)

[it's chugging right along](https://youtu.be/ATjXcjSgnE0?t=01h59m44s)

[i may have to circle back onto some of](https://youtu.be/ATjXcjSgnE0?t=01h59m47s)

[the xaml test stuff i'm very close to](https://youtu.be/ATjXcjSgnE0?t=01h59m49s)

[actually being done with](https://youtu.be/ATjXcjSgnE0?t=01h59m51s)

[a full release of it i don't know how](https://youtu.be/ATjXcjSgnE0?t=01h59m54s)

[much is left](https://youtu.be/ATjXcjSgnE0?t=01h59m56s)

[yeah so this is the only thing that i](https://youtu.be/ATjXcjSgnE0?t=02h00m00s)

[had tagged left to do](https://youtu.be/ATjXcjSgnE0?t=02h00m02s)

[and i'm not entirely sure](https://youtu.be/ATjXcjSgnE0?t=02h00m04s)

[i'm not entirely sure if this is](https://youtu.be/ATjXcjSgnE0?t=02h00m07s)

[actually an issue that i care to solve](https://youtu.be/ATjXcjSgnE0?t=02h00m09s)

[or not](https://youtu.be/ATjXcjSgnE0?t=02h00m11s)

[so right now the the safe screenshot](https://youtu.be/ATjXcjSgnE0?t=02h00m12s)

[method](https://youtu.be/ATjXcjSgnE0?t=02h00m15s)

[always just screenshots the the primary](https://youtu.be/ATjXcjSgnE0?t=02h00m16s)

[monitor](https://youtu.be/ATjXcjSgnE0?t=02h00m18s)

[which for build agents and pipelines is](https://youtu.be/ATjXcjSgnE0?t=02h00m19s)

[fine because](https://youtu.be/ATjXcjSgnE0?t=02h00m22s)

[those things aren't going to have](https://youtu.be/ATjXcjSgnE0?t=02h00m23s)

[multiple screens](https://youtu.be/ATjXcjSgnE0?t=02h00m24s)

[not a big deal but when testing locally](https://youtu.be/ATjXcjSgnE0?t=02h00m27s)

[if like me you have multiple screens](https://youtu.be/ATjXcjSgnE0?t=02h00m31s)

[always screenshotting the primary](https://youtu.be/ATjXcjSgnE0?t=02h00m34s)

[monitor is not helpful if the app is](https://youtu.be/ATjXcjSgnE0?t=02h00m35s)

[running on](https://youtu.be/ATjXcjSgnE0?t=02h00m37s)

[monitor 2. so](https://youtu.be/ATjXcjSgnE0?t=02h00m38s)

[i think this is the last thing i want to](https://youtu.be/ATjXcjSgnE0?t=02h00m41s)

[do is actually look up](https://youtu.be/ATjXcjSgnE0?t=02h00m43s)

[what screen the app is running on and](https://youtu.be/ATjXcjSgnE0?t=02h00m45s)

[maybe screenshot that instead](https://youtu.be/ATjXcjSgnE0?t=02h00m47s)

[that might be a little better the](https://youtu.be/ATjXcjSgnE0?t=02h00m50s)

[alternative is screenshot all the things](https://youtu.be/ATjXcjSgnE0?t=02h00m52s)

[and i don't know that just feels yucky](https://youtu.be/ATjXcjSgnE0?t=02h00m56s)

[um just blindly capturing a screenshot](https://youtu.be/ATjXcjSgnE0?t=02h00m59s)

[of all the](https://youtu.be/ATjXcjSgnE0?t=02h01m03s)

[all the monitors because some apps do](https://youtu.be/ATjXcjSgnE0?t=02h01m04s)

[that where you take a screenshot](https://youtu.be/ATjXcjSgnE0?t=02h01m06s)

[heck your print screen button in windows](https://youtu.be/ATjXcjSgnE0?t=02h01m08s)

[you you take a screenshot and it just](https://youtu.be/ATjXcjSgnE0?t=02h01m10s)

[captures](https://youtu.be/ATjXcjSgnE0?t=02h01m12s)

[all the windows all the places and you](https://youtu.be/ATjXcjSgnE0?t=02h01m13s)

[get way more than you need oh look at](https://youtu.be/ATjXcjSgnE0?t=02h01m15s)

[that](https://youtu.be/ATjXcjSgnE0?t=02h01m16s)

[look at that it passed hallelujah okay](https://youtu.be/ATjXcjSgnE0?t=02h01m17s)

[we can start merging](https://youtu.be/ATjXcjSgnE0?t=02h01m21s)

[some stuff booyah okay](https://youtu.be/ATjXcjSgnE0?t=02h01m22s)

[let's get some of this growing so squash](https://youtu.be/ATjXcjSgnE0?t=02h01m26s)

[merge squash merge](https://youtu.be/ATjXcjSgnE0?t=02h01m28s)

[and then we're gonna come over here come](https://youtu.be/ATjXcjSgnE0?t=02h01m30s)

[over here](https://youtu.be/ATjXcjSgnE0?t=02h01m32s)

[this fix 262 let's pull up on master](https://youtu.be/ATjXcjSgnE0?t=02h01m33s)

[and then we're going to rebase you over](https://youtu.be/ATjXcjSgnE0?t=02h01m38s)

[here onto master now](https://youtu.be/ATjXcjSgnE0?t=02h01m39s)

[so you can go here](https://youtu.be/ATjXcjSgnE0?t=02h01m42s)

[uh what abort rebase what happened](https://youtu.be/ATjXcjSgnE0?t=02h01m46s)

[uh let's see here](https://youtu.be/ATjXcjSgnE0?t=02h01m50s)

[oh so now we're going to delete the](https://youtu.be/ATjXcjSgnE0?t=02h01m54s)

[files that i aborted](https://youtu.be/ATjXcjSgnE0?t=02h01m56s)

[to do i apparently did not get my master](https://youtu.be/ATjXcjSgnE0?t=02h01m59s)

[pulled up](https://youtu.be/ATjXcjSgnE0?t=02h02m02s)

[all the way before rebasing okay](https://youtu.be/ATjXcjSgnE0?t=02h02m02s)

[now rebase](https://youtu.be/ATjXcjSgnE0?t=02h02m08s)

[uh why am i now getting conflicts](https://youtu.be/ATjXcjSgnE0?t=02h02m15s)

[that's the one i want save](https://youtu.be/ATjXcjSgnE0?t=02h02m19s)

[uh let's see one of these is going to](https://youtu.be/ATjXcjSgnE0?t=02h02m24s)

[have topmost](https://youtu.be/ATjXcjSgnE0?t=02h02m26s)

[that one oh it's because of the order](https://youtu.be/ATjXcjSgnE0?t=02h02m28s)

[that commits](https://youtu.be/ATjXcjSgnE0?t=02h02m31s)

[oh yuck](https://youtu.be/ATjXcjSgnE0?t=02h02m32s)

[well this is easy always just take the](https://youtu.be/ATjXcjSgnE0?t=02h02m36s)

[side from master](https://youtu.be/ATjXcjSgnE0?t=02h02m38s)

[that's that's how we're going to resolve](https://youtu.be/ATjXcjSgnE0?t=02h02m40s)

[the commits](https://youtu.be/ATjXcjSgnE0?t=02h02m42s)

[so you'll note it ends up saying skip](https://youtu.be/ATjXcjSgnE0?t=02h02m45s)

[because](https://youtu.be/ATjXcjSgnE0?t=02h02m47s)

[uh](https://youtu.be/ATjXcjSgnE0?t=02h02m49s)

[rebase conflicted what okay](https://youtu.be/ATjXcjSgnE0?t=02h02m55s)

[abort rebase um](https://youtu.be/ATjXcjSgnE0?t=02h02m59s)

[okay so let's do some fancy stuff while](https://youtu.be/ATjXcjSgnE0?t=02h03m02s)

[we're in here](https://youtu.be/ATjXcjSgnE0?t=02h03m06s)

[so squash you three down](https://youtu.be/ATjXcjSgnE0?t=02h03m07s)

[i really would like to oh okay so here's](https://youtu.be/ATjXcjSgnE0?t=02h03m19s)

[what we'll do so i've got these guys](https://youtu.be/ATjXcjSgnE0?t=02h03m21s)

[down into a single commit now](https://youtu.be/ATjXcjSgnE0?t=02h03m23s)

[um i just need to create branch](https://youtu.be/ATjXcjSgnE0?t=02h03m25s)

[temp you'll work great okay so now what](https://youtu.be/ATjXcjSgnE0?t=02h03m29s)

[i'm going to do](https://youtu.be/ATjXcjSgnE0?t=02h03m32s)

[is grab my fix 2362-2362](https://youtu.be/ATjXcjSgnE0?t=02h03m33s)

[oh stop it visual studio go away for a](https://youtu.be/ATjXcjSgnE0?t=02h03m40s)

[minute](https://youtu.be/ATjXcjSgnE0?t=02h03m42s)

[i know you're gonna be unhappy with me](https://youtu.be/ATjXcjSgnE0?t=02h03m43s)

[two three six two](https://youtu.be/ATjXcjSgnE0?t=02h03m45s)

[there's that branch and i want its base](https://youtu.be/ATjXcjSgnE0?t=02h03m46s)

[over here so i'm going to](https://youtu.be/ATjXcjSgnE0?t=02h03m48s)

[right click reset hard which says just](https://youtu.be/ATjXcjSgnE0?t=02h03m49s)

[move the branch](https://youtu.be/ATjXcjSgnE0?t=02h03m52s)

[which is a great way to saw the branch](https://youtu.be/ATjXcjSgnE0?t=02h03m53s)

[off that you're standing on](https://youtu.be/ATjXcjSgnE0?t=02h03m55s)

[not a not a great experience um but i](https://youtu.be/ATjXcjSgnE0?t=02h03m57s)

[because i left this temp branch or temp](https://youtu.be/ATjXcjSgnE0?t=02h04m00s)

[branch pointed at it](https://youtu.be/ATjXcjSgnE0?t=02h04m03s)

[the this commit doesn't fall off there's](https://youtu.be/ATjXcjSgnE0?t=02h04m04s)

[still something pointed to it](https://youtu.be/ATjXcjSgnE0?t=02h04m07s)

[which means i can then reach back across](https://youtu.be/ATjXcjSgnE0?t=02h04m09s)

[and say](https://youtu.be/ATjXcjSgnE0?t=02h04m11s)

[cherry pick that guy right on across](https://youtu.be/ATjXcjSgnE0?t=02h04m12s)

[now my 262 branch is exactly where i](https://youtu.be/ATjXcjSgnE0?t=02h04m16s)

[want it to be](https://youtu.be/ATjXcjSgnE0?t=02h04m18s)

[force push force push](https://youtu.be/ATjXcjSgnE0?t=02h04m21s)

[and it should be all the things that i](https://youtu.be/ATjXcjSgnE0?t=02h04m24s)

[hope it to be okay](https://youtu.be/ATjXcjSgnE0?t=02h04m26s)

[now that i'm happy delete the temp](https://youtu.be/ATjXcjSgnE0?t=02h04m27s)

[branch and let that commit fall off](https://youtu.be/ATjXcjSgnE0?t=02h04m29s)

[the update xaml test branch is local](https://youtu.be/ATjXcjSgnE0?t=02h04m32s)

[only which is what the little computer](https://youtu.be/ATjXcjSgnE0?t=02h04m35s)

[symbol means](https://youtu.be/ATjXcjSgnE0?t=02h04m36s)

[this little other icon up here indicates](https://youtu.be/ATjXcjSgnE0?t=02h04m38s)

[the various remotes so because this is](https://youtu.be/ATjXcjSgnE0?t=02h04m40s)

[only the computer symbol i know it's a](https://youtu.be/ATjXcjSgnE0?t=02h04m42s)

[local only branch](https://youtu.be/ATjXcjSgnE0?t=02h04m43s)

[which is usually when i you'll note](https://youtu.be/ATjXcjSgnE0?t=02h04m45s)

[sometimes i](https://youtu.be/ATjXcjSgnE0?t=02h04m48s)

[leave myself backup branches down here](https://youtu.be/ATjXcjSgnE0?t=02h04m49s)

[which is no longer necessary](https://youtu.be/ATjXcjSgnE0?t=02h04m50s)

[okay and in fact we can start to clean](https://youtu.be/ATjXcjSgnE0?t=02h04m54s)

[up a lot of these](https://youtu.be/ATjXcjSgnE0?t=02h04m56s)

[um](https://youtu.be/ATjXcjSgnE0?t=02h04m57s)

[actually i don't think i need any local](https://youtu.be/ATjXcjSgnE0?t=02h05m01s)

[uh delete all the local branches](https://youtu.be/ATjXcjSgnE0?t=02h05m04s)

[occasionally i just have to declare](https://youtu.be/ATjXcjSgnE0?t=02h05m06s)

[bankruptcy and throw away all my local](https://youtu.be/ATjXcjSgnE0?t=02h05m08s)

[branches if it was valuable](https://youtu.be/ATjXcjSgnE0?t=02h05m09s)

[i pushed it somewhere and i won't lose](https://youtu.be/ATjXcjSgnE0?t=02h05m11s)

[it](https://youtu.be/ATjXcjSgnE0?t=02h05m14s)

[but if i didn't push it it couldn't have](https://youtu.be/ATjXcjSgnE0?t=02h05m15s)

[been that valuable okay](https://youtu.be/ATjXcjSgnE0?t=02h05m17s)

[so that guy goes there](https://youtu.be/ATjXcjSgnE0?t=02h05m19s)

[okay and then this guy is building](https://youtu.be/ATjXcjSgnE0?t=02h05m25s)

[this is not the milestone again i am an](https://youtu.be/ATjXcjSgnE0?t=02h05m29s)

[idiot there we go](https://youtu.be/ATjXcjSgnE0?t=02h05m32s)

[okay so this guy is building this guy](https://youtu.be/ATjXcjSgnE0?t=02h05m34s)

[is just a couple demo lap things so he](https://youtu.be/ATjXcjSgnE0?t=02h05m38s)

[can kind of go whenever](https://youtu.be/ATjXcjSgnE0?t=02h05m40s)

[this floating offset will get resolved](https://youtu.be/ATjXcjSgnE0?t=02h05m43s)

[by this which means this combo box thing](https://youtu.be/ATjXcjSgnE0?t=02h05m44s)

[is the last one](https://youtu.be/ATjXcjSgnE0?t=02h05m47s)

[out there and there is an existing](https://youtu.be/ATjXcjSgnE0?t=02h05m48s)

[branch for this uh](https://youtu.be/ATjXcjSgnE0?t=02h05m51s)

[two three four oh](https://youtu.be/ATjXcjSgnE0?t=02h05m54s)

[let's see where did i put it two three](https://youtu.be/ATjXcjSgnE0?t=02h05m58s)

[four oh](https://youtu.be/ATjXcjSgnE0?t=02h06m00s)

[this guy down here was this relevant](https://youtu.be/ATjXcjSgnE0?t=02h06m01s)

[yeah so let's go to this two three four](https://youtu.be/ATjXcjSgnE0?t=02h06m08s)

[oh and i kinda wanna](https://youtu.be/ATjXcjSgnE0?t=02h06m10s)

[i i left a stash for it so we're just](https://youtu.be/ATjXcjSgnE0?t=02h06m13s)

[going to pop that stash onto it](https://youtu.be/ATjXcjSgnE0?t=02h06m15s)

[uh](https://youtu.be/ATjXcjSgnE0?t=02h06m18s)

[ui test i think this test](https://youtu.be/ATjXcjSgnE0?t=02h06m22s)

[is relevant but i was holding off until](https://youtu.be/ATjXcjSgnE0?t=02h06m26s)

[i had some of the xaml](https://youtu.be/ATjXcjSgnE0?t=02h06m29s)

[test stuff fixed because this was](https://youtu.be/ATjXcjSgnE0?t=02h06m30s)

[reliant on some mouse interaction that](https://youtu.be/ATjXcjSgnE0?t=02h06m32s)

[didn't previously exist](https://youtu.be/ATjXcjSgnE0?t=02h06m34s)

[but i want to take this branch](https://youtu.be/ATjXcjSgnE0?t=02h06m36s)

[and rebase it on master so let's](https://youtu.be/ATjXcjSgnE0?t=02h06m39s)

[bring him up to speed where's the rebase](https://youtu.be/ATjXcjSgnE0?t=02h06m43s)

[button](https://youtu.be/ATjXcjSgnE0?t=02h06m45s)

[there we go boom so now we got](https://youtu.be/ATjXcjSgnE0?t=02h06m46s)

[this push](https://youtu.be/ATjXcjSgnE0?t=02h06m50s)

[force push force push okay so now latest](https://youtu.be/ATjXcjSgnE0?t=02h06m53s)

[stuff is out there on](https://youtu.be/ATjXcjSgnE0?t=02h06m56s)

[origin we should be](https://youtu.be/ATjXcjSgnE0?t=02h06m58s)

[good and i think that's going to be the](https://youtu.be/ATjXcjSgnE0?t=02h07m01s)

[last thing remaining to go through and](https://youtu.be/ATjXcjSgnE0?t=02h07m02s)

[fix](https://youtu.be/ATjXcjSgnE0?t=02h07m05s)

[yeah and this is kind of a weird setup](https://youtu.be/ATjXcjSgnE0?t=02h07m09s)

[to begin with because it's a combo box](https://youtu.be/ATjXcjSgnE0?t=02h07m13s)

[embedded in a menu which is](https://youtu.be/ATjXcjSgnE0?t=02h07m15s)

[not exactly common but it is a](https://youtu.be/ATjXcjSgnE0?t=02h07m17s)

[legitimate bug](https://youtu.be/ATjXcjSgnE0?t=02h07m20s)

[so as soon as this guy finishes which](https://youtu.be/ATjXcjSgnE0?t=02h07m22s)

[i'm assuming he will](https://youtu.be/ATjXcjSgnE0?t=02h07m24s)

[now should be that hard](https://youtu.be/ATjXcjSgnE0?t=02h07m26s)

[i think i may wrap it up for the night](https://youtu.be/ATjXcjSgnE0?t=02h07m32s)

[this is since i am](https://youtu.be/ATjXcjSgnE0?t=02h07m33s)

[at my two hour mark](https://youtu.be/ATjXcjSgnE0?t=02h07m35s)

[um i don't know if people are interested](https://youtu.be/ATjXcjSgnE0?t=02h07m43s)

[either so](https://youtu.be/ATjXcjSgnE0?t=02h07m45s)

[uh another one of my interests that i](https://youtu.be/ATjXcjSgnE0?t=02h07m49s)

[don't know if i've talked about much on](https://youtu.be/ATjXcjSgnE0?t=02h07m51s)

[stream is i very much enjoy board games](https://youtu.be/ATjXcjSgnE0?t=02h07m53s)

[so i've been contemplating dragging my](https://youtu.be/ATjXcjSgnE0?t=02h07m56s)

[computer into my gaming room and](https://youtu.be/ATjXcjSgnE0?t=02h07m58s)

[streaming either board game playthroughs](https://youtu.be/ATjXcjSgnE0?t=02h08m01s)

[or i've been dabbling in](https://youtu.be/ATjXcjSgnE0?t=02h08m04s)

[designing my own board games so i don't](https://youtu.be/ATjXcjSgnE0?t=02h08m06s)

[know if if that kind of content is](https://youtu.be/ATjXcjSgnE0?t=02h08m08s)

[something people are interested in](https://youtu.be/ATjXcjSgnE0?t=02h08m10s)

[uh drop me a comment let me know uh](https://youtu.be/ATjXcjSgnE0?t=02h08m12s)

[it's a bit of an effort to drag my](https://youtu.be/ATjXcjSgnE0?t=02h08m16s)

[machines around because i've](https://youtu.be/ATjXcjSgnE0?t=02h08m17s)

[i've only got the one machine that's](https://youtu.be/ATjXcjSgnE0?t=02h08m19s)

[really capable of streaming and i don't](https://youtu.be/ATjXcjSgnE0?t=02h08m20s)

[really have](https://youtu.be/ATjXcjSgnE0?t=02h08m22s)

[a network cable line set up for my](https://youtu.be/ATjXcjSgnE0?t=02h08m24s)

[gaming room yet](https://youtu.be/ATjXcjSgnE0?t=02h08m26s)

[but if it's but it's something i've](https://youtu.be/ATjXcjSgnE0?t=02h08m27s)

[contemplated doing](https://youtu.be/ATjXcjSgnE0?t=02h08m30s)

[it might be interesting you might be](https://youtu.be/ATjXcjSgnE0?t=02h08m32s)

[forced to actually watch me interact](https://youtu.be/ATjXcjSgnE0?t=02h08m34s)

[with the rest of my](https://youtu.be/ATjXcjSgnE0?t=02h08m36s)

[gaming group and see what that is like](https://youtu.be/ATjXcjSgnE0?t=02h08m37s)

[could be good could be boring i have fun](https://youtu.be/ATjXcjSgnE0?t=02h08m41s)

[and that's usually how i measure how](https://youtu.be/ATjXcjSgnE0?t=02h08m44s)

[good a stream is if i have fun](https://youtu.be/ATjXcjSgnE0?t=02h08m47s)

[then it couldn't have been that bad of a](https://youtu.be/ATjXcjSgnE0?t=02h08m48s)

[stream even if it's just me talking to](https://youtu.be/ATjXcjSgnE0?t=02h08m50s)

[myself for a couple hours](https://youtu.be/ATjXcjSgnE0?t=02h08m52s)

[if as long as i had fun that that's](https://youtu.be/ATjXcjSgnE0?t=02h08m54s)

[what's important](https://youtu.be/ATjXcjSgnE0?t=02h08m56s)

[okay come on go go devops go](https://youtu.be/ATjXcjSgnE0?t=02h08m58s)

[run the tests do all the things make me](https://youtu.be/ATjXcjSgnE0?t=02h09m03s)

[happy](https://youtu.be/ATjXcjSgnE0?t=02h09m05s)

[um as part of doing that one of the](https://youtu.be/ATjXcjSgnE0?t=02h09m14s)

[things i was playing with over the](https://youtu.be/ATjXcjSgnE0?t=02h09m15s)

[weekend](https://youtu.be/ATjXcjSgnE0?t=02h09m16s)

[so this complete derail has nothing to](https://youtu.be/ATjXcjSgnE0?t=02h09m17s)

[do with this i'm just waiting for the pr](https://youtu.be/ATjXcjSgnE0?t=02h09m20s)

[to finish](https://youtu.be/ATjXcjSgnE0?t=02h09m22s)

[uh but uh tabletop simulator](https://youtu.be/ATjXcjSgnE0?t=02h09m22s)

[so if people haven't seen this](https://youtu.be/ATjXcjSgnE0?t=02h09m26s)

[this guy this guy yeah](https://youtu.be/ATjXcjSgnE0?t=02h09m29s)

[so this is a uh](https://youtu.be/ATjXcjSgnE0?t=02h09m33s)

[a game on steam game i i put it in](https://youtu.be/ATjXcjSgnE0?t=02h09m37s)

[quotes](https://youtu.be/ATjXcjSgnE0?t=02h09m40s)

[because it's more or less um a physics](https://youtu.be/ATjXcjSgnE0?t=02h09m40s)

[engine for](https://youtu.be/ATjXcjSgnE0?t=02h09m44s)

[for tabletop gaming and you can go](https://youtu.be/ATjXcjSgnE0?t=02h09m45s)

[through and build out](https://youtu.be/ATjXcjSgnE0?t=02h09m48s)

[various games and depending on the](https://youtu.be/ATjXcjSgnE0?t=02h09m50s)

[amount of effort you want to put into it](https://youtu.be/ATjXcjSgnE0?t=02h09m51s)

[quite advanced um stuff can be done in](https://youtu.be/ATjXcjSgnE0?t=02h09m54s)

[there so i was](https://youtu.be/ATjXcjSgnE0?t=02h09m57s)

[i was trying to figure out how much of](https://youtu.be/ATjXcjSgnE0?t=02h09m58s)

[a like the the games i was designing how](https://youtu.be/ATjXcjSgnE0?t=02h10m01s)

[much i could](https://youtu.be/ATjXcjSgnE0?t=02h10m04s)

[write a script to convert from my source](https://youtu.be/ATjXcjSgnE0?t=02h10m05s)

[files](https://youtu.be/ATjXcjSgnE0?t=02h10m07s)

[into um tabletop simulator stuff so](https://youtu.be/ATjXcjSgnE0?t=02h10m08s)

[generating images with decks and and](https://youtu.be/ATjXcjSgnE0?t=02h10m12s)

[hosting those things on azure and all of](https://youtu.be/ATjXcjSgnE0?t=02h10m15s)

[that](https://youtu.be/ATjXcjSgnE0?t=02h10m17s)

[that fun jazz that goes around with it](https://youtu.be/ATjXcjSgnE0?t=02h10m17s)

[because most of the directions online](https://youtu.be/ATjXcjSgnE0?t=02h10m19s)

[are like oh yeah you just need to host](https://youtu.be/ATjXcjSgnE0?t=02h10m22s)

[the files online you know get dropbox or](https://youtu.be/ATjXcjSgnE0?t=02h10m24s)

[whatnot i'm like no](https://youtu.be/ATjXcjSgnE0?t=02h10m26s)

[no i'm a developer i have azure at my](https://youtu.be/ATjXcjSgnE0?t=02h10m27s)

[disposal](https://youtu.be/ATjXcjSgnE0?t=02h10m29s)

[we're using azure so](https://youtu.be/ATjXcjSgnE0?t=02h10m30s)

[simple storage account and have some fun](https://youtu.be/ATjXcjSgnE0?t=02h10m34s)

[so spent a lot of time](https://youtu.be/ATjXcjSgnE0?t=02h10m36s)

[we'll say learning and still very much](https://youtu.be/ATjXcjSgnE0?t=02h10m39s)

[learning i've been](https://youtu.be/ATjXcjSgnE0?t=02h10m41s)

[trying to figure out um custom models](https://youtu.be/ATjXcjSgnE0?t=02h10m43s)

[and how to get those things working](https://youtu.be/ATjXcjSgnE0?t=02h10m46s)

[because i am i am not great at it](https://youtu.be/ATjXcjSgnE0?t=02h10m48s)

[uh tinkercad is my my skill level at the](https://youtu.be/ATjXcjSgnE0?t=02h10m51s)

[moment though i've been](https://youtu.be/ATjXcjSgnE0?t=02h10m54s)

[messing with fusion 3d and opencad](https://youtu.be/ATjXcjSgnE0?t=02h10m55s)

[trying to to learn as best i can and](https://youtu.be/ATjXcjSgnE0?t=02h10m59s)

[there's there's a wealth of information](https://youtu.be/ATjXcjSgnE0?t=02h11m01s)

[it's just](https://youtu.be/ATjXcjSgnE0?t=02h11m03s)

[there's a wealth of information look at](https://youtu.be/ATjXcjSgnE0?t=02h11m04s)

[that](https://youtu.be/ATjXcjSgnE0?t=02h11m07s)

[goes green goes green](https://youtu.be/ATjXcjSgnE0?t=02h11m07s)

[boom](https://youtu.be/ATjXcjSgnE0?t=02h11m12s)

[um yeah](https://youtu.be/ATjXcjSgnE0?t=02h11m22s)

[interesting that you listen but listed](https://youtu.be/ATjXcjSgnE0?t=02h11m27s)

[betrayal at house on the hill](https://youtu.be/ATjXcjSgnE0?t=02h11m29s)

[where the the game fans out so my gaming](https://youtu.be/ATjXcjSgnE0?t=02h11m31s)

[group](https://youtu.be/ATjXcjSgnE0?t=02h11m34s)

[has mixed opinions of tabletop simulator](https://youtu.be/ATjXcjSgnE0?t=02h11m36s)

[um](https://youtu.be/ATjXcjSgnE0?t=02h11m39s)

[specifically so it's really great for](https://youtu.be/ATjXcjSgnE0?t=02h11m40s)

[games](https://youtu.be/ATjXcjSgnE0?t=02h11m43s)

[that have large setups and complicated](https://youtu.be/ATjXcjSgnE0?t=02h11m44s)

[setups because](https://youtu.be/ATjXcjSgnE0?t=02h11m46s)

[a lot of that you can just kind of](https://youtu.be/ATjXcjSgnE0?t=02h11m47s)

[automate away a lot of the bookkeeping](https://youtu.be/ATjXcjSgnE0?t=02h11m48s)

[which is great um](https://youtu.be/ATjXcjSgnE0?t=02h11m50s)

[the one thing we found that doesn't work](https://youtu.be/ATjXcjSgnE0?t=02h11m53s)

[well that we didn't like about it](https://youtu.be/ATjXcjSgnE0?t=02h11m55s)

[was games that heavily rely on social](https://youtu.be/ATjXcjSgnE0?t=02h11m57s)

[interaction](https://youtu.be/ATjXcjSgnE0?t=02h12m00s)

[such as uh for we play um](https://youtu.be/ATjXcjSgnE0?t=02h12m02s)

[twilight imperium a lot and so](https://youtu.be/ATjXcjSgnE0?t=02h12m05s)

[there's a lot of negotiating and you](https://youtu.be/ATjXcjSgnE0?t=02h12m08s)

[know](https://youtu.be/ATjXcjSgnE0?t=02h12m10s)

[it will say um social backstabbing that](https://youtu.be/ATjXcjSgnE0?t=02h12m11s)

[that goes along with that game](https://youtu.be/ATjXcjSgnE0?t=02h12m14s)

[and it gets it gets a little weird](https://youtu.be/ATjXcjSgnE0?t=02h12m16s)

[because when you're playing in person](https://youtu.be/ATjXcjSgnE0?t=02h12m19s)

[i mean you can kind of lean over and](https://youtu.be/ATjXcjSgnE0?t=02h12m20s)

[kind of try to have a private](https://youtu.be/ATjXcjSgnE0?t=02h12m22s)

[conversation with the person next to you](https://youtu.be/ATjXcjSgnE0?t=02h12m24s)

[but ultimately everyone can see that](https://youtu.be/ATjXcjSgnE0?t=02h12m25s)

[you're doing that](https://youtu.be/ATjXcjSgnE0?t=02h12m28s)

[um and so it changes the dynamic a](https://youtu.be/ATjXcjSgnE0?t=02h12m29s)

[little bit when you can kind of just](https://youtu.be/ATjXcjSgnE0?t=02h12m31s)

[start](https://youtu.be/ATjXcjSgnE0?t=02h12m32s)

[private messaging somebody um on you](https://youtu.be/ATjXcjSgnE0?t=02h12m33s)

[know whatever](https://youtu.be/ATjXcjSgnE0?t=02h12m36s)

[chat service you're using discord team](https://youtu.be/ATjXcjSgnE0?t=02h12m37s)

[skype whatever](https://youtu.be/ATjXcjSgnE0?t=02h12m40s)

[um and so you can kind of start to get](https://youtu.be/ATjXcjSgnE0?t=02h12m42s)

[those weird side chats](https://youtu.be/ATjXcjSgnE0?t=02h12m44s)

[and we found that it for better or worse](https://youtu.be/ATjXcjSgnE0?t=02h12m45s)

[it](https://youtu.be/ATjXcjSgnE0?t=02h12m48s)

[changes that dynamic of the game and so](https://youtu.be/ATjXcjSgnE0?t=02h12m49s)

[games](https://youtu.be/ATjXcjSgnE0?t=02h12m52s)

[feel different on tabletop simulator](https://youtu.be/ATjXcjSgnE0?t=02h12m52s)

[versus](https://youtu.be/ATjXcjSgnE0?t=02h12m55s)

[versus in person whether good or bad is](https://youtu.be/ATjXcjSgnE0?t=02h12m55s)

[it kind of depends on the game](https://youtu.be/ATjXcjSgnE0?t=02h12m58s)

[but we did find that that social](https://youtu.be/ATjXcjSgnE0?t=02h13m00s)

[interaction piece was a](https://youtu.be/ATjXcjSgnE0?t=02h13m01s)

[very very different feel online so](https://youtu.be/ATjXcjSgnE0?t=02h13m03s)

[and at least for for twilight imperium](https://youtu.be/ATjXcjSgnE0?t=02h13m08s)

[we very much](https://youtu.be/ATjXcjSgnE0?t=02h13m10s)

[liked in person it feels better in](https://youtu.be/ATjXcjSgnE0?t=02h13m11s)

[person](https://youtu.be/ATjXcjSgnE0?t=02h13m15s)

[um yeah](https://youtu.be/ATjXcjSgnE0?t=02h13m16s)

[so for what it's worth okay so i think](https://youtu.be/ATjXcjSgnE0?t=02h13m20s)

[the good news is](https://youtu.be/ATjXcjSgnE0?t=02h13m23s)

[that means most of this is done](https://youtu.be/ATjXcjSgnE0?t=02h13m27s)

[excuse me okay so the 4-2 release](https://youtu.be/ATjXcjSgnE0?t=02h13m33s)

[is close to being done very very close](https://youtu.be/ATjXcjSgnE0?t=02h13m36s)

[i want to get this last bug wrapped up](https://youtu.be/ATjXcjSgnE0?t=02h13m40s)

[and i don't know if anybody wants to](https://youtu.be/ATjXcjSgnE0?t=02h13m43s)

[take my branch and roll with it](https://youtu.be/ATjXcjSgnE0?t=02h13m45s)

[feel free to do so um it's just a matter](https://youtu.be/ATjXcjSgnE0?t=02h13m46s)

[of making sure](https://youtu.be/ATjXcjSgnE0?t=02h13m49s)

[that this thing actually works](https://youtu.be/ATjXcjSgnE0?t=02h13m52s)

[i'm trying i'm trying to remember](https://youtu.be/ATjXcjSgnE0?t=02h13m56s)

[exactly it's been it's](https://youtu.be/ATjXcjSgnE0?t=02h13m57s)

[now been oh and i hang on let me pull](https://youtu.be/ATjXcjSgnE0?t=02h13m59s)

[master i'll rebase it one more time](https://youtu.be/ATjXcjSgnE0?t=02h14m02s)

[because i'm getting really good at this](https://youtu.be/ATjXcjSgnE0?t=02h14m04s)

[boom force push force push](https://youtu.be/ATjXcjSgnE0?t=02h14m09s)

[there we go um because on the theme that](https://youtu.be/ATjXcjSgnE0?t=02h14m14s)

[i started doing](https://youtu.be/ATjXcjSgnE0?t=02h14m18s)

[the the there's sort of this weird back](https://youtu.be/ATjXcjSgnE0?t=02h14m22s)

[and forth](https://youtu.be/ATjXcjSgnE0?t=02h14m25s)

[with the combo box and it's i don't know](https://youtu.be/ATjXcjSgnE0?t=02h14m26s)

[the best way to](https://youtu.be/ATjXcjSgnE0?t=02h14m29s)

[address some of the issues because](https://youtu.be/ATjXcjSgnE0?t=02h14m30s)

[there's both the regular combo box where](https://youtu.be/ATjXcjSgnE0?t=02h14m33s)

[you click](https://youtu.be/ATjXcjSgnE0?t=02h14m35s)

[pick a drop down item and then there's](https://youtu.be/ATjXcjSgnE0?t=02h14m35s)

[the editable combo box which makes](https://youtu.be/ATjXcjSgnE0?t=02h14m37s)

[makes this layout a little bit different](https://youtu.be/ATjXcjSgnE0?t=02h14m40s)

[and so the change here](https://youtu.be/ATjXcjSgnE0?t=02h14m43s)

[um changes that that](https://youtu.be/ATjXcjSgnE0?t=02h14m45s)

[layout of whether something's in the](https://youtu.be/ATjXcjSgnE0?t=02h14m48s)

[visual hierarchy or not and so it](https://youtu.be/ATjXcjSgnE0?t=02h14m51s)

[makes it makes those routed events like](https://youtu.be/ATjXcjSgnE0?t=02h14m53s)

[what i was mentioning earlier different](https://youtu.be/ATjXcjSgnE0?t=02h14m56s)

[for better or worse it makes them](https://youtu.be/ATjXcjSgnE0?t=02h14m59s)

[different and changes the behavior](https://youtu.be/ATjXcjSgnE0?t=02h15m01s)

[so that is the root cause the bug there](https://youtu.be/ATjXcjSgnE0?t=02h15m03s)

[is a test that is](https://youtu.be/ATjXcjSgnE0?t=02h15m06s)

[pretty close to being being what we want](https://youtu.be/ATjXcjSgnE0?t=02h15m08s)

[um and this here was all this commented](https://youtu.be/ATjXcjSgnE0?t=02h15m12s)

[stuff all these task delays should be](https://youtu.be/ATjXcjSgnE0?t=02h15m15s)

[able to go away now](https://youtu.be/ATjXcjSgnE0?t=02h15m17s)

[uh there was a bunch of stuff in there](https://youtu.be/ATjXcjSgnE0?t=02h15m18s)

[about animations and tries and all that](https://youtu.be/ATjXcjSgnE0?t=02h15m20s)

[garbage i i believe xaml test is now](https://youtu.be/ATjXcjSgnE0?t=02h15m23s)

[handled most of that](https://youtu.be/ATjXcjSgnE0?t=02h15m25s)

[with appropriate logic so should take](https://youtu.be/ATjXcjSgnE0?t=02h15m27s)

[care of that](https://youtu.be/ATjXcjSgnE0?t=02h15m30s)

[but i do want to get that guy fixed and](https://youtu.be/ATjXcjSgnE0?t=02h15m31s)

[then this one will probably get wrapped](https://youtu.be/ATjXcjSgnE0?t=02h15m33s)

[up fairly quick](https://youtu.be/ATjXcjSgnE0?t=02h15m35s)

[uh the the comments on here were pretty](https://youtu.be/ATjXcjSgnE0?t=02h15m36s)

[benign](https://youtu.be/ATjXcjSgnE0?t=02h15m39s)

[plus i think this these buttons look](https://youtu.be/ATjXcjSgnE0?t=02h15m40s)

[really nice](https://youtu.be/ATjXcjSgnE0?t=02h15m43s)

[in my opinion so these will make a](https://youtu.be/ATjXcjSgnE0?t=02h15m44s)

[a nice addition a nice addition to the](https://youtu.be/ATjXcjSgnE0?t=02h15m47s)

[library](https://youtu.be/ATjXcjSgnE0?t=02h15m50s)

[so i think with that i am probably going](https://youtu.be/ATjXcjSgnE0?t=02h15m51s)

[to say](https://youtu.be/ATjXcjSgnE0?t=02h15m54s)

[thank you for joining happy cody and](https://youtu.be/ATjXcjSgnE0?t=02h15m56s)

[i'll see everyone next time](https://youtu.be/ATjXcjSgnE0?t=02h15m58s)

[you](https://youtu.be/ATjXcjSgnE0?t=02h16m33s)

