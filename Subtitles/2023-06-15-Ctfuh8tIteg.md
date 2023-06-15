[YouTube Video](https://youtu.be/Ctfuh8tIteg)



[hello everyone welcome back tonight](https://youtu.be/Ctfuh8tIteg?t=00h00m01s)

[we're going back to the material design](https://youtu.be/Ctfuh8tIteg?t=00h00m04s)

[and xaml project we started on the 5.0](https://youtu.be/Ctfuh8tIteg?t=00h00m05s)

[pull request which was massive a couple](https://youtu.be/Ctfuh8tIteg?t=00h00m08s)

[weeks ago](https://youtu.be/Ctfuh8tIteg?t=00h00m11s)

[um thank you to the people who have been](https://youtu.be/Ctfuh8tIteg?t=00h00m12s)

[reviewing it I realized it was](https://youtu.be/Ctfuh8tIteg?t=00h00m14s)

[big is probably an understatement](https://youtu.be/Ctfuh8tIteg?t=00h00m18s)

[massive huge](https://youtu.be/Ctfuh8tIteg?t=00h00m19s)

[um and there has been a lot of great](https://youtu.be/Ctfuh8tIteg?t=00h00m21s)

[um review comments so I kind of want to](https://youtu.be/Ctfuh8tIteg?t=00h00m24s)

[work on getting it done I'm thinking the](https://youtu.be/Ctfuh8tIteg?t=00h00m26s)

[410 release isn't going to happen and](https://youtu.be/Ctfuh8tIteg?t=00h00m28s)

[everything's just 5-0](https://youtu.be/Ctfuh8tIteg?t=00h00m30s)

[I think that that may be where we're](https://youtu.be/Ctfuh8tIteg?t=00h00m32s)

[going there's there's some stuff in the](https://youtu.be/Ctfuh8tIteg?t=00h00m34s)

[410 bit that is a little](https://youtu.be/Ctfuh8tIteg?t=00h00m35s)

[maybe I should just release it really](https://youtu.be/Ctfuh8tIteg?t=00h00m37s)

[quick but I'm like I don't know I don't](https://youtu.be/Ctfuh8tIteg?t=00h00m39s)

[know so if anyone have strong](https://youtu.be/Ctfuh8tIteg?t=00h00m41s)

[preferences okay so what the heck am I](https://youtu.be/Ctfuh8tIteg?t=00h00m42s)

[talking about this pull request right](https://youtu.be/Ctfuh8tIteg?t=00h00m45s)

[here the the one that is very aptly](https://youtu.be/Ctfuh8tIteg?t=00h00m47s)

[named 5-0](https://youtu.be/Ctfuh8tIteg?t=00h00m49s)

[um yeah so](https://youtu.be/Ctfuh8tIteg?t=00h00m54s)

[um lots lots of good review comments I I](https://youtu.be/Ctfuh8tIteg?t=00h00m57s)

[won't spoil it so what is actually going](https://youtu.be/Ctfuh8tIteg?t=00h01m00s)

[on here is a major revamp of](https://youtu.be/Ctfuh8tIteg?t=00h01m03s)

[how we do theming and brushes in the](https://youtu.be/Ctfuh8tIteg?t=00h01m06s)

[library this has been one of the areas](https://youtu.be/Ctfuh8tIteg?t=00h01m09s)

[that I think in the three five release](https://youtu.be/Ctfuh8tIteg?t=00h01m11s)

[or three six release somewhere in that](https://youtu.be/Ctfuh8tIteg?t=00h01m15s)

[frame I did somewhat of a refactor of](https://youtu.be/Ctfuh8tIteg?t=00h01m16s)

[the theming code](https://youtu.be/Ctfuh8tIteg?t=00h01m19s)

[um and broke it apart got it into a nice](https://youtu.be/Ctfuh8tIteg?t=00h01m21s)

[workable state but the the problem still](https://youtu.be/Ctfuh8tIteg?t=00h01m23s)

[remained that it was a major pain in the](https://youtu.be/Ctfuh8tIteg?t=00h01m26s)

[butt every time we wanted to go and add](https://youtu.be/Ctfuh8tIteg?t=00h01m28s)

[new brushes to a theme and there was](https://youtu.be/Ctfuh8tIteg?t=00h01m30s)

[also all of these issues where one brush](https://youtu.be/Ctfuh8tIteg?t=00h01m32s)

[would be reused in multiple places and](https://youtu.be/Ctfuh8tIteg?t=00h01m35s)

[it was difficult](https://youtu.be/Ctfuh8tIteg?t=00h01m37s)

[um for people who wanted to tweet just](https://youtu.be/Ctfuh8tIteg?t=00h01m39s)

[one individual thing and there's](https://youtu.be/Ctfuh8tIteg?t=00h01m41s)

[constantly requests coming in for people](https://youtu.be/Ctfuh8tIteg?t=00h01m42s)

[saying Hey how do I change insert brush](https://youtu.be/Ctfuh8tIteg?t=00h01m44s)

[here right I want to change the color of](https://youtu.be/Ctfuh8tIteg?t=00h01m48s)

[just this one thing I don't want to](https://youtu.be/Ctfuh8tIteg?t=00h01m49s)

[change it for the whole app it's like](https://youtu.be/Ctfuh8tIteg?t=00h01m51s)

[well that gets a little more complicated](https://youtu.be/Ctfuh8tIteg?t=00h01m52s)

[so the the idea being that what we're](https://youtu.be/Ctfuh8tIteg?t=00h01m54s)

[doing is creating](https://youtu.be/Ctfuh8tIteg?t=00h01m57s)

[one most the brushes are being renamed](https://youtu.be/Ctfuh8tIteg?t=00h02m00s)

[so you can see a massive rename](https://youtu.be/Ctfuh8tIteg?t=00h02m02s)

[happening here I've tried to document](https://youtu.be/Ctfuh8tIteg?t=00h02m04s)

[them here we're going to cover out more](https://youtu.be/Ctfuh8tIteg?t=00h02m06s)

[of them](https://youtu.be/Ctfuh8tIteg?t=00h02m08s)

[um and there is going to be a shim](https://youtu.be/Ctfuh8tIteg?t=00h02m10s)

[package in so if you are currently using](https://youtu.be/Ctfuh8tIteg?t=00h02m12s)

[the for people who aren't like using](https://youtu.be/Ctfuh8tIteg?t=00h02m15s)

[these brushes too heavily uh in your app](https://youtu.be/Ctfuh8tIteg?t=00h02m17s)

[it should be a simple finder and replace](https://youtu.be/Ctfuh8tIteg?t=00h02m20s)

[that's the goal if that is a major lift](https://youtu.be/Ctfuh8tIteg?t=00h02m22s)

[for you there's going to be a shim](https://youtu.be/Ctfuh8tIteg?t=00h02m25s)

[resource dictionary you can slap in](https://youtu.be/Ctfuh8tIteg?t=00h02m26s)

[and it should take care of uh doing all](https://youtu.be/Ctfuh8tIteg?t=00h02m29s)

[of the forwarding for you so that you](https://youtu.be/Ctfuh8tIteg?t=00h02m32s)

[don't have to address it you should](https://youtu.be/Ctfuh8tIteg?t=00h02m34s)

[start migrating at some point because](https://youtu.be/Ctfuh8tIteg?t=00h02m36s)

[that shim Library isn't going to stick](https://youtu.be/Ctfuh8tIteg?t=00h02m39s)

[around forever](https://youtu.be/Ctfuh8tIteg?t=00h02m41s)

[um as the other brushes start to mutate](https://youtu.be/Ctfuh8tIteg?t=00h02m43s)

[and evolve there's going to be things](https://youtu.be/Ctfuh8tIteg?t=00h02m45s)

[that you just start missing out on and](https://youtu.be/Ctfuh8tIteg?t=00h02m46s)

[are going to be forced to update at some](https://youtu.be/Ctfuh8tIteg?t=00h02m48s)

[point anyway so just be aware this shim](https://youtu.be/Ctfuh8tIteg?t=00h02m49s)

[library is a point in time](https://youtu.be/Ctfuh8tIteg?t=00h02m52s)

[uh shim it's not expected to be full](https://youtu.be/Ctfuh8tIteg?t=00h02m55s)

[backwards compatibility for all time](https://youtu.be/Ctfuh8tIteg?t=00h02m59s)

[going forward so for what it's worth so](https://youtu.be/Ctfuh8tIteg?t=00h03m00s)

[this is just to make it easier for](https://youtu.be/Ctfuh8tIteg?t=00h03m03s)

[people to adopt 5-0 and then start](https://youtu.be/Ctfuh8tIteg?t=00h03m04s)

[migrating at a reasonable Cadence don't](https://youtu.be/Ctfuh8tIteg?t=00h03m07s)

[worry I'm not going to like delete it in](https://youtu.be/Ctfuh8tIteg?t=00h03m09s)

[the 5-1 release or anything crazy](https://youtu.be/Ctfuh8tIteg?t=00h03m10s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h03m13s)

[but what the what we have done is now](https://youtu.be/Ctfuh8tIteg?t=00h03m13s)

[built out a massive number of new theme](https://youtu.be/Ctfuh8tIteg?t=00h03m16s)

[brushes and more importantly they're](https://youtu.be/Ctfuh8tIteg?t=00h03m18s)

[generated so when we want to change one](https://youtu.be/Ctfuh8tIteg?t=00h03m21s)

[it's easy](https://youtu.be/Ctfuh8tIteg?t=00h03m23s)

[so let's take a look at that so this so](https://youtu.be/Ctfuh8tIteg?t=00h03m25s)

[so real quick just to be clear](https://youtu.be/Ctfuh8tIteg?t=00h03m29s)

[here is the here is a set of commits](https://youtu.be/Ctfuh8tIteg?t=00h03m31s)

[that have been done that are all just](https://youtu.be/Ctfuh8tIteg?t=00h03m33s)

[items off of the breaking changes list](https://youtu.be/Ctfuh8tIteg?t=00h03m35s)

[so there's a 50 breaking changes issue](https://youtu.be/Ctfuh8tIteg?t=00h03m38s)

[on the repo this is just knocking out a](https://youtu.be/Ctfuh8tIteg?t=00h03m40s)

[bunch of them this isn't necessarily all](https://youtu.be/Ctfuh8tIteg?t=00h03m42s)

[the 5.0 breaking changes but it's a lot](https://youtu.be/Ctfuh8tIteg?t=00h03m44s)

[of the easy ones this is how many](https://youtu.be/Ctfuh8tIteg?t=00h03m47s)

[I've put in on the steaming stuff](https://youtu.be/Ctfuh8tIteg?t=00h03m50s)

[this is also after I've squashed a](https://youtu.be/Ctfuh8tIteg?t=00h03m52s)

[sizable number of them as well so this](https://youtu.be/Ctfuh8tIteg?t=00h03m55s)

[theming stuff is a massive massive chunk](https://youtu.be/Ctfuh8tIteg?t=00h03m58s)

[of the five opens](https://youtu.be/Ctfuh8tIteg?t=00h04m02s)

[sorry](https://youtu.be/Ctfuh8tIteg?t=00h04m06s)

[new Mountain Dew the uh](https://youtu.be/Ctfuh8tIteg?t=00h04m07s)

[one of the summer flavors is a thrashed](https://youtu.be/Ctfuh8tIteg?t=00h04m10s)

[Apple](https://youtu.be/Ctfuh8tIteg?t=00h04m14s)

[uh for those people who have it in your](https://youtu.be/Ctfuh8tIteg?t=00h04m15s)

[area if you like the artificial Apple](https://youtu.be/Ctfuh8tIteg?t=00h04m18s)

[flavor of like a Jolly Ranchers candy](https://youtu.be/Ctfuh8tIteg?t=00h04m20s)

[it's very it's very heavy in the](https://youtu.be/Ctfuh8tIteg?t=00h04m22s)

[artifactual very heavy in the artificial](https://youtu.be/Ctfuh8tIteg?t=00h04m25s)

[Apple flavoring so if you don't like](https://youtu.be/Ctfuh8tIteg?t=00h04m28s)

[artificial Apple flavoring stay far away](https://youtu.be/Ctfuh8tIteg?t=00h04m30s)

[if you like it you'll probably love it](https://youtu.be/Ctfuh8tIteg?t=00h04m32s)

[Okay so](https://youtu.be/Ctfuh8tIteg?t=00h04m34s)

[let's go through](https://youtu.be/Ctfuh8tIteg?t=00h04m36s)

[this little and then we've got a couple](https://youtu.be/Ctfuh8tIteg?t=00h04m40s)

[of these I think a lot of these ones die](https://youtu.be/Ctfuh8tIteg?t=00h04m41s)

[with this PR as well because I think](https://youtu.be/Ctfuh8tIteg?t=00h04m43s)

[I've updated a bunch of these](https://youtu.be/Ctfuh8tIteg?t=00h04m45s)

[um trying to remember this one shows a](https://youtu.be/Ctfuh8tIteg?t=00h04m49s)

[pass but I is this still waiting on](https://youtu.be/Ctfuh8tIteg?t=00h04m51s)

[something](https://youtu.be/Ctfuh8tIteg?t=00h04m54s)

[yeah](https://youtu.be/Ctfuh8tIteg?t=00h04m54s)

[there's a handful of things in here and](https://youtu.be/Ctfuh8tIteg?t=00h04m57s)

[I don't think](https://youtu.be/Ctfuh8tIteg?t=00h04m58s)

[yeah I don't think there's been feedback](https://youtu.be/Ctfuh8tIteg?t=00h05m03s)

[that's done on this since](https://youtu.be/Ctfuh8tIteg?t=00h05m06s)

[but I should we may Circle back to this](https://youtu.be/Ctfuh8tIteg?t=00h05m08s)

[we may Circle back to this one because](https://youtu.be/Ctfuh8tIteg?t=00h05m10s)

[that would be a good one to get in as](https://youtu.be/Ctfuh8tIteg?t=00h05m12s)

[well](https://youtu.be/Ctfuh8tIteg?t=00h05m13s)

[okay and there's probably going to be a](https://youtu.be/Ctfuh8tIteg?t=00h05m14s)

[little bit of time where I let this](https://youtu.be/Ctfuh8tIteg?t=00h05m16s)

[thing bake](https://youtu.be/Ctfuh8tIteg?t=00h05m18s)

[um like 5-0 I'm not I'm not rushing to](https://youtu.be/Ctfuh8tIteg?t=00h05m20s)

[do so here's my personal favorite this](https://youtu.be/Ctfuh8tIteg?t=00h05m23s)

[file's changed right this says 260.](https://youtu.be/Ctfuh8tIteg?t=00h05m25s)

[this shows 249.](https://youtu.be/Ctfuh8tIteg?t=00h05m30s)

[and you'll note it shows that we've](https://youtu.be/Ctfuh8tIteg?t=00h05m34s)

[viewed 247 out of 249. right I only have](https://youtu.be/Ctfuh8tIteg?t=00h05m36s)

[a math minor which clearly means I can](https://youtu.be/Ctfuh8tIteg?t=00h05m41s)

[only do math on you know one hand I'm](https://youtu.be/Ctfuh8tIteg?t=00h05m44s)

[pretty sure that's what a a math minor](https://youtu.be/Ctfuh8tIteg?t=00h05m48s)

[means which means I should only see two](https://youtu.be/Ctfuh8tIteg?t=00h05m50s)

[boxes unchecked](https://youtu.be/Ctfuh8tIteg?t=00h05m52s)

[now](https://youtu.be/Ctfuh8tIteg?t=00h05m54s)

[I don't doubt this is Javascript related](https://youtu.be/Ctfuh8tIteg?t=00h05m56s)

[so one great](https://youtu.be/Ctfuh8tIteg?t=00h05m58s)

[two three four five six seven eight nine](https://youtu.be/Ctfuh8tIteg?t=00h06m00s)

[is short version GitHub can't count](https://youtu.be/Ctfuh8tIteg?t=00h06m06s)

[I I don't I don't doubt this is related](https://youtu.be/Ctfuh8tIteg?t=00h06m09s)

[to the sheer size of the pr and whatever](https://youtu.be/Ctfuh8tIteg?t=00h06m12s)

[lazy loading of this files thing is](https://youtu.be/Ctfuh8tIteg?t=00h06m14s)

[going on I I'm sure it's something like](https://youtu.be/Ctfuh8tIteg?t=00h06m17s)

[that](https://youtu.be/Ctfuh8tIteg?t=00h06m19s)

[but yeah so there's a bunch and I've](https://youtu.be/Ctfuh8tIteg?t=00h06m19s)

[been slowly trying to use these to check](https://youtu.be/Ctfuh8tIteg?t=00h06m22s)

[off as I've addressed comments so let's](https://youtu.be/Ctfuh8tIteg?t=00h06m23s)

[look at the palette helper one why is](https://youtu.be/Ctfuh8tIteg?t=00h06m26s)

[this one not closed out yet](https://youtu.be/Ctfuh8tIteg?t=00h06m28s)

[right I was leaving this one because](https://youtu.be/Ctfuh8tIteg?t=00h06m31s)

[nikolai's comment about](https://youtu.be/Ctfuh8tIteg?t=00h06m33s)

[documenting one of the readme files I](https://youtu.be/Ctfuh8tIteg?t=00h06m35s)

[agree that needs to be done I'm saving](https://youtu.be/Ctfuh8tIteg?t=00h06m38s)

[that](https://youtu.be/Ctfuh8tIteg?t=00h06m41s)

[we'll Circle back to it because that is](https://youtu.be/Ctfuh8tIteg?t=00h06m42s)

[a feature that is not](https://youtu.be/Ctfuh8tIteg?t=00h06m43s)

[Well Done Yet okay so here we got this](https://youtu.be/Ctfuh8tIteg?t=00h06m45s)

[so this so one Michael's been awesome](https://youtu.be/Ctfuh8tIteg?t=00h06m50s)

[about looking at this because when I did](https://youtu.be/Ctfuh8tIteg?t=00h06m53s)

[the rename a couple weeks ago I wrote a](https://youtu.be/Ctfuh8tIteg?t=00h06m55s)

[Powershell script](https://youtu.be/Ctfuh8tIteg?t=00h06m58s)

[that just blind find and replaced](https://youtu.be/Ctfuh8tIteg?t=00h06m59s)

[which was great it blindfinded replaced](https://youtu.be/Ctfuh8tIteg?t=00h07m03s)

[everything but it meant that it now](https://youtu.be/Ctfuh8tIteg?t=00h07m06s)

[exposed a lot of these cases where](https://youtu.be/Ctfuh8tIteg?t=00h07m08s)

[uh where things were not always the](https://youtu.be/Ctfuh8tIteg?t=00h07m12s)

[clearest so let's go and check this out](https://youtu.be/Ctfuh8tIteg?t=00h07m16s)

[282 on the combo box Style](https://youtu.be/Ctfuh8tIteg?t=00h07m17s)

[so uh that's not the right one yeah](https://youtu.be/Ctfuh8tIteg?t=00h07m20s)

[hold that thought we gotta actually open](https://youtu.be/Ctfuh8tIteg?t=00h07m25s)

[the right solution that one](https://youtu.be/Ctfuh8tIteg?t=00h07m27s)

[foreign](https://youtu.be/Ctfuh8tIteg?t=00h07m35s)

[unit test](https://youtu.be/Ctfuh8tIteg?t=00h07m37s)

[I was playing with some code earlier and](https://youtu.be/Ctfuh8tIteg?t=00h07m39s)

[I just wanted to](https://youtu.be/Ctfuh8tIteg?t=00h07m41s)

[see how it looked okay why is my test](https://youtu.be/Ctfuh8tIteg?t=00h07m43s)

[Explorer scrunched up and on a different](https://youtu.be/Ctfuh8tIteg?t=00h07m45s)

[monitor](https://youtu.be/Ctfuh8tIteg?t=00h07m47s)

[that seems wrong okay](https://youtu.be/Ctfuh8tIteg?t=00h07m48s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h07m53s)

[uh okay here we go oh](https://youtu.be/Ctfuh8tIteg?t=00h07m55s)

[I will save this for later I will save](https://youtu.be/Ctfuh8tIteg?t=00h08m00s)

[this for me I love new updates I love](https://youtu.be/Ctfuh8tIteg?t=00h08m03s)

[new updates uh let's see this is Chip](https://youtu.be/Ctfuh8tIteg?t=00h08m05s)

[this isn't combo box let's try again](https://youtu.be/Ctfuh8tIteg?t=00h08m07s)

[combo box there we go and we were on](https://youtu.be/Ctfuh8tIteg?t=00h08m10s)

[g282 okay so this is specifically around](https://youtu.be/Ctfuh8tIteg?t=00h08m13s)

[here](https://youtu.be/Ctfuh8tIteg?t=00h08m17s)

[so this is changing so if is enabled](https://youtu.be/Ctfuh8tIteg?t=00h08m18s)

[false](https://youtu.be/Ctfuh8tIteg?t=00h08m22s)

[it's using the check box disabled Style](https://youtu.be/Ctfuh8tIteg?t=00h08m24s)

[so what's the feedback here](https://youtu.be/Ctfuh8tIteg?t=00h08m29s)

[maybe I'm missing something why is this](https://youtu.be/Ctfuh8tIteg?t=00h08m32s)

[not the right](https://youtu.be/Ctfuh8tIteg?t=00h08m34s)

[because is enabled as false style name](https://youtu.be/Ctfuh8tIteg?t=00h08m36s)

[mismatch](https://youtu.be/Ctfuh8tIteg?t=00h08m38s)

[maybe we created a general disabled](https://youtu.be/Ctfuh8tIteg?t=00h08m46s)

[Style](https://youtu.be/Ctfuh8tIteg?t=00h08m49s)

[uh let's see I'm a little confused here](https://youtu.be/Ctfuh8tIteg?t=00h08m51s)

[let's see combo box toggle button](https://youtu.be/Ctfuh8tIteg?t=00h08m53s)

[this one I'm not sure makes sense](https://youtu.be/Ctfuh8tIteg?t=00h08m56s)

[uh let's see this is expected](https://youtu.be/Ctfuh8tIteg?t=00h09m05s)

[uh or I should say this is](https://youtu.be/Ctfuh8tIteg?t=00h09m09s)

[changing](https://youtu.be/Ctfuh8tIteg?t=00h09m13s)

[the color](https://youtu.be/Ctfuh8tIteg?t=00h09m15s)

[color of the uh drop down arrow](https://youtu.be/Ctfuh8tIteg?t=00h09m18s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h09m26s)

[to the](https://youtu.be/Ctfuh8tIteg?t=00h09m27s)

[disabled gray color when the](https://youtu.be/Ctfuh8tIteg?t=00h09m30s)

[button is](https://youtu.be/Ctfuh8tIteg?t=00h09m35s)

[disabled](https://youtu.be/Ctfuh8tIteg?t=00h09m37s)

[so let's let's slap that in I have been](https://youtu.be/Ctfuh8tIteg?t=00h09m40s)

[doing the add single comments because](https://youtu.be/Ctfuh8tIteg?t=00h09m42s)

[there's just so much in here uh let's](https://youtu.be/Ctfuh8tIteg?t=00h09m44s)

[see style name mismatch Target is border](https://youtu.be/Ctfuh8tIteg?t=00h09m46s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h09m51s)

[I agree that the target is the Border](https://youtu.be/Ctfuh8tIteg?t=00h09m53s)

[but this is a control template style](https://youtu.be/Ctfuh8tIteg?t=00h09m56s)

[what is the condition here](https://youtu.be/Ctfuh8tIteg?t=00h09m58s)

[foreign](https://youtu.be/Ctfuh8tIteg?t=00h10m03s)

[but this is](https://youtu.be/Ctfuh8tIteg?t=00h10m07s)

[changing the color of](https://youtu.be/Ctfuh8tIteg?t=00h10m09s)

[internal template member to be](https://youtu.be/Ctfuh8tIteg?t=00h10m13s)

[use the disabled uh brush when the](https://youtu.be/Ctfuh8tIteg?t=00h10m17s)

[uh control is disabled okay so I think](https://youtu.be/Ctfuh8tIteg?t=00h10m24s)

[both of these](https://youtu.be/Ctfuh8tIteg?t=00h10m29s)

[I'll let Michael reply back but I I](https://youtu.be/Ctfuh8tIteg?t=00h10m32s)

[suspect we may just disregard those ones](https://youtu.be/Ctfuh8tIteg?t=00h10m35s)

[are there any more in this file](https://youtu.be/Ctfuh8tIteg?t=00h10m38s)

[naming mismatch let's see here](https://youtu.be/Ctfuh8tIteg?t=00h10m41s)

[because Michael has caught a lot of](https://youtu.be/Ctfuh8tIteg?t=00h10m43s)

[styling issues specifically around](https://youtu.be/Ctfuh8tIteg?t=00h10m46s)

[things like the separator style not](https://youtu.be/Ctfuh8tIteg?t=00h10m49s)

[because previously the material design](https://youtu.be/Ctfuh8tIteg?t=00h10m52s)

[separator brush was used in like I don't](https://youtu.be/Ctfuh8tIteg?t=00h10m55s)

[know 80 places and that was one of the](https://youtu.be/Ctfuh8tIteg?t=00h10m58s)

[problematic ones because it meant that](https://youtu.be/Ctfuh8tIteg?t=00h11m01s)

[if you wanted to override the color it](https://youtu.be/Ctfuh8tIteg?t=00h11m03s)

[would affect a whole bunch of disparate](https://youtu.be/Ctfuh8tIteg?t=00h11m05s)

[things](https://youtu.be/Ctfuh8tIteg?t=00h11m06s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h11m08s)

[so this was text area border](https://youtu.be/Ctfuh8tIteg?t=00h11m10s)

[so what are we in we are in an outline](https://youtu.be/Ctfuh8tIteg?t=00h11m14s)

[combo box](https://youtu.be/Ctfuh8tIteg?t=00h11m16s)

[yeah](https://youtu.be/Ctfuh8tIteg?t=00h11m22s)

[yeah brush](https://youtu.be/Ctfuh8tIteg?t=00h11m24s)

[header foreground](https://youtu.be/Ctfuh8tIteg?t=00h11m25s)

[style naming mismatch yeah so let's look](https://youtu.be/Ctfuh8tIteg?t=00h11m28s)

[this guy here](https://youtu.be/Ctfuh8tIteg?t=00h11m31s)

[is setting the](https://youtu.be/Ctfuh8tIteg?t=00h11m33s)

[why do we have a header foreground let's](https://youtu.be/Ctfuh8tIteg?t=00h11m36s)

[I'm curious why did I do that](https://youtu.be/Ctfuh8tIteg?t=00h11m40s)

[let me rephrase I'm sure I know why I](https://youtu.be/Ctfuh8tIteg?t=00h11m45s)

[did it I probably wasn't thinking](https://youtu.be/Ctfuh8tIteg?t=00h11m47s)

[clearly so this seems like it's](https://youtu.be/Ctfuh8tIteg?t=00h11m48s)

[recreating the same problem](https://youtu.be/Ctfuh8tIteg?t=00h11m51s)

[in that it is](https://youtu.be/Ctfuh8tIteg?t=00h12m03s)

[duplicating forward a bunch of resources](https://youtu.be/Ctfuh8tIteg?t=00h12m08s)

[that we don't want](https://youtu.be/Ctfuh8tIteg?t=00h12m12s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h12m15s)

[so text area and column header were both](https://youtu.be/Ctfuh8tIteg?t=00h12m18s)

[were both forwarded to that one](https://youtu.be/Ctfuh8tIteg?t=00h12m22s)

[so this obsolete brushes is also serving](https://youtu.be/Ctfuh8tIteg?t=00h12m26s)

[as a nice](https://youtu.be/Ctfuh8tIteg?t=00h12m29s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h12m31s)

[reference point](https://youtu.be/Ctfuh8tIteg?t=00h12m31s)

[for uh](https://youtu.be/Ctfuh8tIteg?t=00h12m33s)

[what things were renamed to other things](https://youtu.be/Ctfuh8tIteg?t=00h12m36s)

[which is convenient](https://youtu.be/Ctfuh8tIteg?t=00h12m40s)

[I think in this case](https://youtu.be/Ctfuh8tIteg?t=00h12m43s)

[in this case I might want to keep it](https://youtu.be/Ctfuh8tIteg?t=00h12m48s)

[because we could create a separate one](https://youtu.be/Ctfuh8tIteg?t=00h12m52s)

[but I don't know if that makes sense](https://youtu.be/Ctfuh8tIteg?t=00h12m57s)

[outline combo box](https://youtu.be/Ctfuh8tIteg?t=00h13m03s)

[this is just setting the border on the](https://youtu.be/Ctfuh8tIteg?t=00h13m06s)

[outline combo box to use the header](https://youtu.be/Ctfuh8tIteg?t=00h13m09s)

[foreground](https://youtu.be/Ctfuh8tIteg?t=00h13m11s)

[hmm](https://youtu.be/Ctfuh8tIteg?t=00h13m12s)

[header foreground does that make sense](https://youtu.be/Ctfuh8tIteg?t=00h13m17s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h13m23s)

[because we could always do a](https://youtu.be/Ctfuh8tIteg?t=00h13m29s)

[we could always do a specific combo box](https://youtu.be/Ctfuh8tIteg?t=00h13m35s)

[brush](https://youtu.be/Ctfuh8tIteg?t=00h13m38s)

[the line number on this guy](https://youtu.be/Ctfuh8tIteg?t=00h13m40s)

[outline combo box](https://youtu.be/Ctfuh8tIteg?t=00h13m43s)

[the thing is is this is one this is one](https://youtu.be/Ctfuh8tIteg?t=00h13m47s)

[of those areas where this isn't a big](https://youtu.be/Ctfuh8tIteg?t=00h13m49s)

[issue because it's on a top level style](https://youtu.be/Ctfuh8tIteg?t=00h13m51s)

[so it's very easily overridden](https://youtu.be/Ctfuh8tIteg?t=00h13m54s)

[the more problematic ones are things](https://youtu.be/Ctfuh8tIteg?t=00h14m02s)

[like this one here which is inside of](https://youtu.be/Ctfuh8tIteg?t=00h14m04s)

[the like style triggers](https://youtu.be/Ctfuh8tIteg?t=00h14m07s)

[uh correct brush](https://youtu.be/Ctfuh8tIteg?t=00h14m19s)

[is](https://youtu.be/Ctfuh8tIteg?t=00h14m23s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h14m26s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h14m28s)

[matches the order](https://youtu.be/Ctfuh8tIteg?t=00h14m29s)

[the text box and since a](https://youtu.be/Ctfuh8tIteg?t=00h14m34s)

[is](https://youtu.be/Ctfuh8tIteg?t=00h14m38s)

[uh just a oops](https://youtu.be/Ctfuh8tIteg?t=00h14m41s)

[wrapper on that](https://youtu.be/Ctfuh8tIteg?t=00h14m44s)

[uh and this is easily overwritable](https://youtu.be/Ctfuh8tIteg?t=00h14m46s)

[I think it is](https://youtu.be/Ctfuh8tIteg?t=00h14m53s)

[fine okay so we'll do that that makes](https://youtu.be/Ctfuh8tIteg?t=00h14m56s)

[sense](https://youtu.be/Ctfuh8tIteg?t=00h14m59s)

[and then we're going to resolve that one](https://youtu.be/Ctfuh8tIteg?t=00h15m01s)

[and then we deleted a bunch of obsolete](https://youtu.be/Ctfuh8tIteg?t=00h15m05s)

[stuff okay so we're gonna collapse this](https://youtu.be/Ctfuh8tIteg?t=00h15m07s)

[one](https://youtu.be/Ctfuh8tIteg?t=00h15m09s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h15m10s)

[was it combo box what we were just](https://youtu.be/Ctfuh8tIteg?t=00h15m14s)

[looking at oh this is data grid combo](https://youtu.be/Ctfuh8tIteg?t=00h15m15s)

[box](https://youtu.be/Ctfuh8tIteg?t=00h15m17s)

[okay so let's see](https://youtu.be/Ctfuh8tIteg?t=00h15m18s)

[okay so this is going to be another](https://youtu.be/Ctfuh8tIteg?t=00h15m22s)

[interesting one these ones probably need](https://youtu.be/Ctfuh8tIteg?t=00h15m24s)

[to be](https://youtu.be/Ctfuh8tIteg?t=00h15m27s)

[yeah these ones probably need to be](https://youtu.be/Ctfuh8tIteg?t=00h15m33s)

[added](https://youtu.be/Ctfuh8tIteg?t=00h15m35s)

[yeah okay so let's go and look at these](https://youtu.be/Ctfuh8tIteg?t=00h15m40s)

[ones so text box hover background](https://youtu.be/Ctfuh8tIteg?t=00h15m42s)

[because again this is one of those cases](https://youtu.be/Ctfuh8tIteg?t=00h15m45s)

[where divider was used and divider is](https://youtu.be/Ctfuh8tIteg?t=00h15m46s)

[like not](https://youtu.be/Ctfuh8tIteg?t=00h15m49s)

[nearly specific enough okay so data grid](https://youtu.be/Ctfuh8tIteg?t=00h15m51s)

[combo box 84.](https://youtu.be/Ctfuh8tIteg?t=00h15m55s)

[there you go uh I'm not an idiot okay](https://youtu.be/Ctfuh8tIteg?t=00h15m57s)

[did a good combo box](https://youtu.be/Ctfuh8tIteg?t=00h16m02s)

[eight four boom okay so what do we what](https://youtu.be/Ctfuh8tIteg?t=00h16m05s)

[are we actually doing here so this is](https://youtu.be/Ctfuh8tIteg?t=00h16m09s)

[the combo box item so this is an](https://youtu.be/Ctfuh8tIteg?t=00h16m10s)

[individual item inside of a combo box](https://youtu.be/Ctfuh8tIteg?t=00h16m13s)

[inside of an editable data grid cell](https://youtu.be/Ctfuh8tIteg?t=00h16m15s)

[okay and here we have a couple of these](https://youtu.be/Ctfuh8tIteg?t=00h16m20s)

[that are the](https://youtu.be/Ctfuh8tIteg?t=00h16m22s)

[let's say selected false Mouse over](https://youtu.be/Ctfuh8tIteg?t=00h16m26s)

[false](https://youtu.be/Ctfuh8tIteg?t=00h16m28s)

[keyboard Focus true so this is keyboard](https://youtu.be/Ctfuh8tIteg?t=00h16m29s)

[has Focus but the mouse is not over we](https://youtu.be/Ctfuh8tIteg?t=00h16m32s)

[then have one other one down here](https://youtu.be/Ctfuh8tIteg?t=00h16m35s)

[wait](https://youtu.be/Ctfuh8tIteg?t=00h16m39s)

[these are the same brush](https://youtu.be/Ctfuh8tIteg?t=00h16m41s)

[so effectively the state of mouse over](https://youtu.be/Ctfuh8tIteg?t=00h16m46s)

[doesn't matter](https://youtu.be/Ctfuh8tIteg?t=00h16m48s)

[and we could combine these into a single](https://youtu.be/Ctfuh8tIteg?t=00h16m52s)

[trigger is that what it was like before](https://youtu.be/Ctfuh8tIteg?t=00h16m55s)

[that's what it was like before](https://youtu.be/Ctfuh8tIteg?t=00h17m01s)

[okay so I'm gonna propose that](https://youtu.be/Ctfuh8tIteg?t=00h17m03s)

[we delete is mouse over from these](https://youtu.be/Ctfuh8tIteg?t=00h17m07s)

[triggers because those don't make a lick](https://youtu.be/Ctfuh8tIteg?t=00h17m09s)

[a difference](https://youtu.be/Ctfuh8tIteg?t=00h17m11s)

[all right okay](https://youtu.be/Ctfuh8tIteg?t=00h17m14s)

[so item is selected](https://youtu.be/Ctfuh8tIteg?t=00h17m16s)

[I'm going to look at a couple of these](https://youtu.be/Ctfuh8tIteg?t=00h17m20s)

[other ones here because I kind of I'm](https://youtu.be/Ctfuh8tIteg?t=00h17m21s)

[noticing that there might be some some](https://youtu.be/Ctfuh8tIteg?t=00h17m22s)

[of these other ones that also evaluate](https://youtu.be/Ctfuh8tIteg?t=00h17m24s)

[the same so let's see false true false](https://youtu.be/Ctfuh8tIteg?t=00h17m26s)

[true false truths so we've got zero one](https://youtu.be/Ctfuh8tIteg?t=00h17m31s)

[zero one zero one](https://youtu.be/Ctfuh8tIteg?t=00h17m34s)

[uh one](https://youtu.be/Ctfuh8tIteg?t=00h17m37s)

[uh one one](https://youtu.be/Ctfuh8tIteg?t=00h17m39s)

[okay so all three of those are distinct](https://youtu.be/Ctfuh8tIteg?t=00h17m43s)

[true false](https://youtu.be/Ctfuh8tIteg?t=00h17m49s)

[false](https://youtu.be/Ctfuh8tIteg?t=00h17m53s)

[so this trigger here](https://youtu.be/Ctfuh8tIteg?t=00h17m56s)

[and this trigger here are also](https://youtu.be/Ctfuh8tIteg?t=00h18m00s)

[functionally the same](https://youtu.be/Ctfuh8tIteg?t=00h18m03s)

[just trying to look because the only](https://youtu.be/Ctfuh8tIteg?t=00h18m12s)

[thing that's important to note is when](https://youtu.be/Ctfuh8tIteg?t=00h18m13s)

[triggers are evaluated they're evaluated](https://youtu.be/Ctfuh8tIteg?t=00h18m14s)

[in order and last in wins](https://youtu.be/Ctfuh8tIteg?t=00h18m16s)

[so even though so these things these two](https://youtu.be/Ctfuh8tIteg?t=00h18m20s)

[triggers here are identical aside from](https://youtu.be/Ctfuh8tIteg?t=00h18m22s)

[the is keyboard focused that's the bull](https://youtu.be/Ctfuh8tIteg?t=00h18m24s)

[difference between them but they're both](https://youtu.be/Ctfuh8tIteg?t=00h18m27s)

[setting the exact same property on the](https://youtu.be/Ctfuh8tIteg?t=00h18m29s)

[exact same object to the exact same](https://youtu.be/Ctfuh8tIteg?t=00h18m32s)

[value](https://youtu.be/Ctfuh8tIteg?t=00h18m34s)

[which means this and this are](https://youtu.be/Ctfuh8tIteg?t=00h18m35s)

[functionally the same](https://youtu.be/Ctfuh8tIteg?t=00h18m39s)

[which means I should kill the first](https://youtu.be/Ctfuh8tIteg?t=00h18m43s)

[trigger](https://youtu.be/Ctfuh8tIteg?t=00h18m45s)

[k](https://youtu.be/Ctfuh8tIteg?t=00h18m52s)

[and now I'm noticing this and this are](https://youtu.be/Ctfuh8tIteg?t=00h18m54s)

[both setting the values](https://youtu.be/Ctfuh8tIteg?t=00h18m57s)

[which oh now that we've done that I know](https://youtu.be/Ctfuh8tIteg?t=00h19m03s)

[that these here are both setting the](https://youtu.be/Ctfuh8tIteg?t=00h19m06s)

[same thing](https://youtu.be/Ctfuh8tIteg?t=00h19m08s)

[of is selected](https://youtu.be/Ctfuh8tIteg?t=00h19m10s)

[if is selected is true whether a mouse](https://youtu.be/Ctfuh8tIteg?t=00h19m13s)

[is over or not this background property](https://youtu.be/Ctfuh8tIteg?t=00h19m15s)

[gets set which means I can eliminate](https://youtu.be/Ctfuh8tIteg?t=00h19m18s)

[this and this](https://youtu.be/Ctfuh8tIteg?t=00h19m20s)

[and then we can kill off this trigger](https://youtu.be/Ctfuh8tIteg?t=00h19m23s)

[Joshua welcome](https://youtu.be/Ctfuh8tIteg?t=00h19m30s)

[first time chat I appreciate it](https://youtu.be/Ctfuh8tIteg?t=00h19m34s)

[um brief introduction Joshua is new at](https://youtu.be/Ctfuh8tIteg?t=00h19m38s)

[intellitec with me and has the](https://youtu.be/Ctfuh8tIteg?t=00h19m41s)

[unfortunate uh sentencing of being](https://youtu.be/Ctfuh8tIteg?t=00h19m44s)

[forced to work with me](https://youtu.be/Ctfuh8tIteg?t=00h19m46s)

[so](https://youtu.be/Ctfuh8tIteg?t=00h19m48s)

[be nice to him he suffers during the day](https://youtu.be/Ctfuh8tIteg?t=00h19m49s)

[doing some WPF work on](https://youtu.be/Ctfuh8tIteg?t=00h19m55s)

[here we'll just share](https://youtu.be/Ctfuh8tIteg?t=00h19m58s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h20m01s)

[so this project here is a theming](https://youtu.be/Ctfuh8tIteg?t=00h20m03s)

[library for WPF](https://youtu.be/Ctfuh8tIteg?t=00h20m06s)

[it is actually used in the project that](https://youtu.be/Ctfuh8tIteg?t=00h20m07s)

[you may be landing on by the way](https://youtu.be/Ctfuh8tIteg?t=00h20m10s)

[um not heavily emphasis on not heavily](https://youtu.be/Ctfuh8tIteg?t=00h20m13s)

[but it is used for a handful of things](https://youtu.be/Ctfuh8tIteg?t=00h20m15s)

[so we're just cleaning some of this](https://youtu.be/Ctfuh8tIteg?t=00h20m17s)

[stuff up](https://youtu.be/Ctfuh8tIteg?t=00h20m18s)

[uh it's a blessing to be working with](https://youtu.be/Ctfuh8tIteg?t=00h20m22s)

[uh okay so the other thing now that](https://youtu.be/Ctfuh8tIteg?t=00h20m25s)

[we've gotten we've now gotten this](https://youtu.be/Ctfuh8tIteg?t=00h20m28s)

[multi-trigger down into a single](https://youtu.be/Ctfuh8tIteg?t=00h20m29s)

[multi-trigger with a single condition](https://youtu.be/Ctfuh8tIteg?t=00h20m31s)

[which that sounds a heck of a lot to me](https://youtu.be/Ctfuh8tIteg?t=00h20m33s)

[like just a regular trigger](https://youtu.be/Ctfuh8tIteg?t=00h20m35s)

[with the property if I can spell uh what](https://youtu.be/Ctfuh8tIteg?t=00h20m38s)

[were we doing is selected](https://youtu.be/Ctfuh8tIteg?t=00h20m42s)

[and a value of true](https://youtu.be/Ctfuh8tIteg?t=00h20m44s)

[and then all this dies so for](https://youtu.be/Ctfuh8tIteg?t=00h20m48s)

[um for anybody who has who isn't](https://youtu.be/Ctfuh8tIteg?t=00h20m52s)

[familiar with this um](https://youtu.be/Ctfuh8tIteg?t=00h20m54s)

[we just did a very manual version of](https://youtu.be/Ctfuh8tIteg?t=00h20m56s)

[what people would call uh k-maps or I'm](https://youtu.be/Ctfuh8tIteg?t=00h20m59s)

[going to butcher this name karnaugh like](https://youtu.be/Ctfuh8tIteg?t=00h21m02s)

[I'm not even gonna try I'm I'm horrible](https://youtu.be/Ctfuh8tIteg?t=00h21m04s)

[at this](https://youtu.be/Ctfuh8tIteg?t=00h21m07s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h21m08s)

[k-map reduction so for those people who](https://youtu.be/Ctfuh8tIteg?t=00h21m09s)

[may not be what I will call trained in](https://youtu.be/Ctfuh8tIteg?t=00h21m12s)

[University and computer science theory](https://youtu.be/Ctfuh8tIteg?t=00h21m15s)

[this is one of those things that you](https://youtu.be/Ctfuh8tIteg?t=00h21m16s)

[learn](https://youtu.be/Ctfuh8tIteg?t=00h21m18s)

[in like an algorithms class](https://youtu.be/Ctfuh8tIteg?t=00h21m19s)

[uh in school and it has a lot of really](https://youtu.be/Ctfuh8tIteg?t=00h21m23s)

[cool practical applications but I've](https://youtu.be/Ctfuh8tIteg?t=00h21m26s)

[seen a lot of people who are like](https://youtu.be/Ctfuh8tIteg?t=00h21m28s)

[self-taught programmers who don't know](https://youtu.be/Ctfuh8tIteg?t=00h21m30s)

[this and just kind of can functionally](https://youtu.be/Ctfuh8tIteg?t=00h21m32s)

[work through that same logic that we did](https://youtu.be/Ctfuh8tIteg?t=00h21m34s)

[all a k-map is is a fancy way of doing](https://youtu.be/Ctfuh8tIteg?t=00h21m37s)

[that that's it it's it's no better than](https://youtu.be/Ctfuh8tIteg?t=00h21m40s)

[that](https://youtu.be/Ctfuh8tIteg?t=00h21m42s)

[um okay so let's let's run let's keep](https://youtu.be/Ctfuh8tIteg?t=00h21m44s)

[going down this because](https://youtu.be/Ctfuh8tIteg?t=00h21m46s)

[so is selected true this is going to](https://youtu.be/Ctfuh8tIteg?t=00h21m48s)

[handle this one](https://youtu.be/Ctfuh8tIteg?t=00h21m50s)

[the other two must be a selected false](https://youtu.be/Ctfuh8tIteg?t=00h21m51s)

[which is fine so here let's do this](https://youtu.be/Ctfuh8tIteg?t=00h21m54s)

[we're going to reorder these just to](https://youtu.be/Ctfuh8tIteg?t=00h21m55s)

[make my life look looking clear right](https://youtu.be/Ctfuh8tIteg?t=00h21m57s)

[boom so in the is selected false case](https://youtu.be/Ctfuh8tIteg?t=00h21m58s)

[we then have Mouse over true keyboard](https://youtu.be/Ctfuh8tIteg?t=00h22m04s)

[Focus true so is mouse over true this is](https://youtu.be/Ctfuh8tIteg?t=00h22m07s)

[mouse over any but is slightly distinct](https://youtu.be/Ctfuh8tIteg?t=00h22m11s)

[okay](https://youtu.be/Ctfuh8tIteg?t=00h22m15s)

[um but this is setting the same](https://youtu.be/Ctfuh8tIteg?t=00h22m17s)

[background property to the same value](https://youtu.be/Ctfuh8tIteg?t=00h22m21s)

[so as long as this is selected as false](https://youtu.be/Ctfuh8tIteg?t=00h22m25s)

[if Mouse over is true](https://youtu.be/Ctfuh8tIteg?t=00h22m33s)

[it doesn't matter the set of keyboard](https://youtu.be/Ctfuh8tIteg?t=00h22m37s)

[Focus we're always going to set hover](https://youtu.be/Ctfuh8tIteg?t=00h22m39s)

[background](https://youtu.be/Ctfuh8tIteg?t=00h22m40s)

[something's off about this](https://youtu.be/Ctfuh8tIteg?t=00h22m42s)

[seems like I broke something hang on](https://youtu.be/Ctfuh8tIteg?t=00h22m49s)

[this this feels a little like Kevin's an](https://youtu.be/Ctfuh8tIteg?t=00h22m51s)

[idiot so hang on I wanna I wanna dip](https://youtu.be/Ctfuh8tIteg?t=00h22m55s)

[this real quick](https://youtu.be/Ctfuh8tIteg?t=00h22m57s)

[uh okay side by side diff](https://youtu.be/Ctfuh8tIteg?t=00h22m59s)

[yeah so Pro tip for everybody](https://youtu.be/Ctfuh8tIteg?t=00h23m02s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h23m06s)

[if you are not let's go bigger uh the](https://youtu.be/Ctfuh8tIteg?t=00h23m07s)

[buttons in your diff viewer love them](https://youtu.be/Ctfuh8tIteg?t=00h23m10s)

[learn to use them effectively they are](https://youtu.be/Ctfuh8tIteg?t=00h23m13s)

[very worthwhile so](https://youtu.be/Ctfuh8tIteg?t=00h23m15s)

[inline side by side every diff viewer](https://youtu.be/Ctfuh8tIteg?t=00h23m18s)

[Works worth its salt let me erase any](https://youtu.be/Ctfuh8tIteg?t=00h23m21s)

[diff viewer that that you should be](https://youtu.be/Ctfuh8tIteg?t=00h23m23s)

[using has these two options](https://youtu.be/Ctfuh8tIteg?t=00h23m25s)

[right this hunk view is kind of I I only](https://youtu.be/Ctfuh8tIteg?t=00h23m27s)

[see it in some tools less important but](https://youtu.be/Ctfuh8tIteg?t=00h23m30s)

[everyone has either side by side split](https://youtu.be/Ctfuh8tIteg?t=00h23m33s)

[view or inline and depending on what](https://youtu.be/Ctfuh8tIteg?t=00h23m35s)

[you're viewing](https://youtu.be/Ctfuh8tIteg?t=00h23m37s)

[one of these may be better than the](https://youtu.be/Ctfuh8tIteg?t=00h23m39s)

[other](https://youtu.be/Ctfuh8tIteg?t=00h23m40s)

[okay so I just want to look at these](https://youtu.be/Ctfuh8tIteg?t=00h23m42s)

[really quick to make sure that we](https://youtu.be/Ctfuh8tIteg?t=00h23m44s)

[haven't completely shot ourselves in the](https://youtu.be/Ctfuh8tIteg?t=00h23m45s)

[foot](https://youtu.be/Ctfuh8tIteg?t=00h23m47s)

[so is selected true](https://youtu.be/Ctfuh8tIteg?t=00h23m48s)

[what we decided is all of the is](https://youtu.be/Ctfuh8tIteg?t=00h23m50s)

[selected true cases](https://youtu.be/Ctfuh8tIteg?t=00h23m52s)

[Mouse over false Mouse over true](https://youtu.be/Ctfuh8tIteg?t=00h23m54s)

[we're both setting the same background](https://youtu.be/Ctfuh8tIteg?t=00h24m00s)

[property so those ended up being](https://youtu.be/Ctfuh8tIteg?t=00h24m02s)

[combined right selected selected](https://youtu.be/Ctfuh8tIteg?t=00h24m04s)

[selected so we haven't just worked](https://youtu.be/Ctfuh8tIteg?t=00h24m07s)

[ourselves out of this case no so](https://youtu.be/Ctfuh8tIteg?t=00h24m09s)

[we've come to the conclusion that is](https://youtu.be/Ctfuh8tIteg?t=00h24m11s)

[selected true](https://youtu.be/Ctfuh8tIteg?t=00h24m13s)

[all of the things go to selected](https://youtu.be/Ctfuh8tIteg?t=00h24m15s)

[beautiful](https://youtu.be/Ctfuh8tIteg?t=00h24m18s)

[beautiful so the other thing to remember](https://youtu.be/Ctfuh8tIteg?t=00h24m22s)

[with triggers is there's always the](https://youtu.be/Ctfuh8tIteg?t=00h24m24s)

[implicit else case right because a](https://youtu.be/Ctfuh8tIteg?t=00h24m26s)

[trigger is only if the following things](https://youtu.be/Ctfuh8tIteg?t=00h24m28s)

[are true then apply these setters](https://youtu.be/Ctfuh8tIteg?t=00h24m30s)

[I just want to make sure I didn't](https://youtu.be/Ctfuh8tIteg?t=00h24m35s)

[accidentally shoot myself in the foot](https://youtu.be/Ctfuh8tIteg?t=00h24m36s)

[you know the other thing we could do we](https://youtu.be/Ctfuh8tIteg?t=00h24m38s)

[could just fire this thing up oh this is](https://youtu.be/Ctfuh8tIteg?t=00h24m39s)

[the](https://youtu.be/Ctfuh8tIteg?t=00h24m42s)

[wrong project wrong project](https://youtu.be/Ctfuh8tIteg?t=00h24m42s)

[so if you start the wrong project you](https://youtu.be/Ctfuh8tIteg?t=00h24m45s)

[get the wrong output so let's let's try](https://youtu.be/Ctfuh8tIteg?t=00h24m48s)

[it let's try demo app again real quick](https://youtu.be/Ctfuh8tIteg?t=00h24m50s)

[foreign](https://youtu.be/Ctfuh8tIteg?t=00h24m55s)

[because this is just the background](https://youtu.be/Ctfuh8tIteg?t=00h24m57s)

[property](https://youtu.be/Ctfuh8tIteg?t=00h24m59s)

[yeah I'm trying to think](https://youtu.be/Ctfuh8tIteg?t=00h25m05s)

[ideally we should have some UI tests](https://youtu.be/Ctfuh8tIteg?t=00h25m08s)

[around this to make sure it's working](https://youtu.be/Ctfuh8tIteg?t=00h25m11s)

[properly okay so where are my drop downs](https://youtu.be/Ctfuh8tIteg?t=00h25m12s)

[those aren't drop downs those aren't](https://youtu.be/Ctfuh8tIteg?t=00h25m15s)

[drop downs these are drop downs](https://youtu.be/Ctfuh8tIteg?t=00h25m17s)

[yeah I think it's fine](https://youtu.be/Ctfuh8tIteg?t=00h25m26s)

[because it's mostly going to be handled](https://youtu.be/Ctfuh8tIteg?t=00h25m33s)

[at the](https://youtu.be/Ctfuh8tIteg?t=00h25m35s)

[outer layer](https://youtu.be/Ctfuh8tIteg?t=00h25m37s)

[I think we're fine I think we're fine](https://youtu.be/Ctfuh8tIteg?t=00h25m40s)

[okay](https://youtu.be/Ctfuh8tIteg?t=00h25m42s)

[perfect so hold on I want to look at](https://youtu.be/Ctfuh8tIteg?t=00h25m43s)

[these because these are both setting the](https://youtu.be/Ctfuh8tIteg?t=00h25m45s)

[exact same brush](https://youtu.be/Ctfuh8tIteg?t=00h25m48s)

[and they are setting it so is selected](https://youtu.be/Ctfuh8tIteg?t=00h25m51s)

[as false in both cases great is mouse](https://youtu.be/Ctfuh8tIteg?t=00h25m53s)

[over true it gets applied](https://youtu.be/Ctfuh8tIteg?t=00h25m56s)

[this will apply so this is kind of an or](https://youtu.be/Ctfuh8tIteg?t=00h25m59s)

[condition then](https://youtu.be/Ctfuh8tIteg?t=00h26m03s)

[so this is if Mouse over is true or](https://youtu.be/Ctfuh8tIteg?t=00h26m08s)

[keyboard focus is true](https://youtu.be/Ctfuh8tIteg?t=00h26m12s)

[then we set this property](https://youtu.be/Ctfuh8tIteg?t=00h26m15s)

[that's effectively what this is doing](https://youtu.be/Ctfuh8tIteg?t=00h26m19s)

[we could drop the keyboard Focus false](https://youtu.be/Ctfuh8tIteg?t=00h26m31s)

[here](https://youtu.be/Ctfuh8tIteg?t=00h26m34s)

[yeah we don't need we don't need](https://youtu.be/Ctfuh8tIteg?t=00h26m39s)

[keyboard Focus false because it doesn't](https://youtu.be/Ctfuh8tIteg?t=00h26m40s)

[matter](https://youtu.be/Ctfuh8tIteg?t=00h26m42s)

[and the re so technically I have changed](https://youtu.be/Ctfuh8tIteg?t=00h26m43s)

[Behavior here but why I say it doesn't](https://youtu.be/Ctfuh8tIteg?t=00h26m46s)

[matter is because both of these Setters](https://youtu.be/Ctfuh8tIteg?t=00h26m48s)

[are targeting the same background](https://youtu.be/Ctfuh8tIteg?t=00h26m50s)

[property with the same on the same](https://youtu.be/Ctfuh8tIteg?t=00h26m53s)

[border control with the same brush](https://youtu.be/Ctfuh8tIteg?t=00h26m55s)

[so effectively if it's selected if it's](https://youtu.be/Ctfuh8tIteg?t=00h26m57s)

[learn phrase if it's not selected](https://youtu.be/Ctfuh8tIteg?t=00h27m00s)

[if the mouse is over it or the](https://youtu.be/Ctfuh8tIteg?t=00h27m03s)

[keyboard's over it we set the background](https://youtu.be/Ctfuh8tIteg?t=00h27m05s)

[okay so now we get background to this](https://youtu.be/Ctfuh8tIteg?t=00h27m07s)

[and the whole point of this was me](https://youtu.be/Ctfuh8tIteg?t=00h27m11s)

[trying to figure out what the heck we](https://youtu.be/Ctfuh8tIteg?t=00h27m13s)

[should name this brush because what do](https://youtu.be/Ctfuh8tIteg?t=00h27m14s)

[what do we actually want to type here](https://youtu.be/Ctfuh8tIteg?t=00h27m15s)

[right so it should be data grid right](https://youtu.be/Ctfuh8tIteg?t=00h27m17s)

[and then whatever we call this because](https://youtu.be/Ctfuh8tIteg?t=00h27m20s)

[it's set in both](https://youtu.be/Ctfuh8tIteg?t=00h27m23s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=00h27m26s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h27m27s)

[Boca focused or Mouse over what is a](https://youtu.be/Ctfuh8tIteg?t=00h27m28s)

[word that means focused](https://youtu.be/Ctfuh8tIteg?t=00h27m32s)

[or Mouse over](https://youtu.be/Ctfuh8tIteg?t=00h27m34s)

[we could have separate brushes mapped to](https://youtu.be/Ctfuh8tIteg?t=00h27m38s)

[the same value](https://youtu.be/Ctfuh8tIteg?t=00h27m40s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h27m45s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=00h27m46s)

[because this is combo box](https://youtu.be/Ctfuh8tIteg?t=00h27m48s)

[selected](https://youtu.be/Ctfuh8tIteg?t=00h27m50s)

[um so let's go with](https://youtu.be/Ctfuh8tIteg?t=00h27m54s)

[uh combo box](https://youtu.be/Ctfuh8tIteg?t=00h27m57s)

[cover](https://youtu.be/Ctfuh8tIteg?t=00h27m59s)

[is it bad to do combo box hover in both](https://youtu.be/Ctfuh8tIteg?t=00h28m04s)

[cases I don't think so](https://youtu.be/Ctfuh8tIteg?t=00h28m08s)

[I don't think that's a bad idea](https://youtu.be/Ctfuh8tIteg?t=00h28m14s)

[um this is one of those cases where it](https://youtu.be/Ctfuh8tIteg?t=00h28m17s)

[gets a little awkward because there's](https://youtu.be/Ctfuh8tIteg?t=00h28m18s)

[not a clear delineate like](https://youtu.be/Ctfuh8tIteg?t=00h28m20s)

[WPF has more UI States than the material](https://youtu.be/Ctfuh8tIteg?t=00h28m22s)

[design spec defines so](https://youtu.be/Ctfuh8tIteg?t=00h28m25s)

[we get to take some Liberties okay so we](https://youtu.be/Ctfuh8tIteg?t=00h28m28s)

[want that brush we come over here](https://youtu.be/Ctfuh8tIteg?t=00h28m31s)

[this is the new way of managing all the](https://youtu.be/Ctfuh8tIteg?t=00h28m33s)

[theme colors in this Library which has](https://youtu.be/Ctfuh8tIteg?t=00h28m36s)

[made me very happy and I've alphabetized](https://youtu.be/Ctfuh8tIteg?t=00h28m38s)

[it because my OCD insists that I do so](https://youtu.be/Ctfuh8tIteg?t=00h28m40s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h28m44s)

[okay so we're gonna go here actually](https://youtu.be/Ctfuh8tIteg?t=00h28m45s)

[let's what was the old brush name](https://youtu.be/Ctfuh8tIteg?t=00h28m47s)

[old brush was](https://youtu.be/Ctfuh8tIteg?t=00h28m50s)

[text box hover background let's just go](https://youtu.be/Ctfuh8tIteg?t=00h28m54s)

[copy that one](https://youtu.be/Ctfuh8tIteg?t=00h28m57s)

[no don't auto complete uh St text box](https://youtu.be/Ctfuh8tIteg?t=00h28m59s)

[hover background because I just want to](https://youtu.be/Ctfuh8tIteg?t=00h29m04s)

[get these I want to make sure that it's](https://youtu.be/Ctfuh8tIteg?t=00h29m06s)

[mapping them to the same colors](https://youtu.be/Ctfuh8tIteg?t=00h29m08s)

[we're gonna go up here](https://youtu.be/Ctfuh8tIteg?t=00h29m10s)

[and we're gonna go data grid](https://youtu.be/Ctfuh8tIteg?t=00h29m12s)

[like a bomb paste it there and then the](https://youtu.be/Ctfuh8tIteg?t=00h29m15s)

[name that we wanted was combo box hover](https://youtu.be/Ctfuh8tIteg?t=00h29m18s)

[great](https://youtu.be/Ctfuh8tIteg?t=00h29m20s)

[uh let's see data grid](https://youtu.be/Ctfuh8tIteg?t=00h29m21s)

[combo box hover I don't want to remap](https://youtu.be/Ctfuh8tIteg?t=00h29m25s)

[the same obsolete Keys here so just oh I](https://youtu.be/Ctfuh8tIteg?t=00h29m28s)

[guess I should leave the](https://youtu.be/Ctfuh8tIteg?t=00h29m32s)

[whatever reason I](https://youtu.be/Ctfuh8tIteg?t=00h29m34s)

[left it I think my code handle is](https://youtu.be/Ctfuh8tIteg?t=00h29m36s)

[missing an empty array is the same case](https://youtu.be/Ctfuh8tIteg?t=00h29m38s)

[either way uh we go back to our resource](https://youtu.be/Ctfuh8tIteg?t=00h29m41s)

[generator we say generate all the theme](https://youtu.be/Ctfuh8tIteg?t=00h29m44s)

[brushes bippity boppity booyah](https://youtu.be/Ctfuh8tIteg?t=00h29m45s)

[and we're done and if we go and look](https://youtu.be/Ctfuh8tIteg?t=00h29m49s)

[we got a bunch of changes now](https://youtu.be/Ctfuh8tIteg?t=00h29m54s)

[wait no we don't why do we not have](https://youtu.be/Ctfuh8tIteg?t=00h29m57s)

[changes](https://youtu.be/Ctfuh8tIteg?t=00h30m00s)

[oh because](https://youtu.be/Ctfuh8tIteg?t=00h30m01s)

[you must rebuild to get the thing to](https://youtu.be/Ctfuh8tIteg?t=00h30m04s)

[copy forgot about that that is so](https://youtu.be/Ctfuh8tIteg?t=00h30m07s)

[annoying](https://youtu.be/Ctfuh8tIteg?t=00h30m09s)

[aren't you set to copy always yes](https://youtu.be/Ctfuh8tIteg?t=00h30m10s)

[the insistence that it doesn't always](https://youtu.be/Ctfuh8tIteg?t=00h30m15s)

[copy the outputs is really annoying so](https://youtu.be/Ctfuh8tIteg?t=00h30m18s)

[because Json files aren't deemed part of](https://youtu.be/Ctfuh8tIteg?t=00h30m21s)

[the compilation it doesn't copy them](https://youtu.be/Ctfuh8tIteg?t=00h30m23s)

[always and it bothers me there we go](https://youtu.be/Ctfuh8tIteg?t=00h30m25s)

[okay now we got a bunch of changes](https://youtu.be/Ctfuh8tIteg?t=00h30m27s)

[so for example you'll note the data grid](https://youtu.be/Ctfuh8tIteg?t=00h30m30s)

[class now has combo box hover generated](https://youtu.be/Ctfuh8tIteg?t=00h30m33s)

[all the theme extensions are built](https://youtu.be/Ctfuh8tIteg?t=00h30m35s)

[boom boom boom it generates out the new](https://youtu.be/Ctfuh8tIteg?t=00h30m38s)

[brush in my my dark theme my light theme](https://youtu.be/Ctfuh8tIteg?t=00h30m40s)

[and our combo box is now using the new](https://youtu.be/Ctfuh8tIteg?t=00h30m44s)

[thing perfect okay stage all changes and](https://youtu.be/Ctfuh8tIteg?t=00h30m47s)

[then we're gonna go adding](https://youtu.be/Ctfuh8tIteg?t=00h30m50s)

[what's the name of it I've already](https://youtu.be/Ctfuh8tIteg?t=00h30m53s)

[forgotten](https://youtu.be/Ctfuh8tIteg?t=00h30m54s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h30m56s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h31m00s)

[uh brush](https://youtu.be/Ctfuh8tIteg?t=00h31m02s)

[commit](https://youtu.be/Ctfuh8tIteg?t=00h31m03s)

[and push](https://youtu.be/Ctfuh8tIteg?t=00h31m04s)

[and then we'll go back to Michael's](https://youtu.be/Ctfuh8tIteg?t=00h31m07s)

[comment](https://youtu.be/Ctfuh8tIteg?t=00h31m09s)

[uh uh let's see here](https://youtu.be/Ctfuh8tIteg?t=00h31m11s)

[cleaned up and added new brush](https://youtu.be/Ctfuh8tIteg?t=00h31m16s)

[to handle this boom copy add](https://youtu.be/Ctfuh8tIteg?t=00h31m23s)

[needless to say GitHub is struggling](https://youtu.be/Ctfuh8tIteg?t=00h31m31s)

[with this PR](https://youtu.be/Ctfuh8tIteg?t=00h31m33s)

[and I can't really blame it like](https://youtu.be/Ctfuh8tIteg?t=00h31m36s)

[I'm throwing a massive amount of changes](https://youtu.be/Ctfuh8tIteg?t=00h31m39s)

[at it all at once](https://youtu.be/Ctfuh8tIteg?t=00h31m41s)

[but I don't know how to do](https://youtu.be/Ctfuh8tIteg?t=00h31m44s)

[app wide theming changes okay so this](https://youtu.be/Ctfuh8tIteg?t=00h31m48s)

[one down here](https://youtu.be/Ctfuh8tIteg?t=00h31m51s)

[this was the same text box border oh we](https://youtu.be/Ctfuh8tIteg?t=00h31m56s)

[probably should have done this one at](https://youtu.be/Ctfuh8tIteg?t=00h31m59s)

[the same time I guess I should look at](https://youtu.be/Ctfuh8tIteg?t=00h32m00s)

[all of them](https://youtu.be/Ctfuh8tIteg?t=00h32m02s)

[so 203 and 329 probably need the same](https://youtu.be/Ctfuh8tIteg?t=00h32m04s)

[brush treatment](https://youtu.be/Ctfuh8tIteg?t=00h32m07s)

[uh let's see uh](https://youtu.be/Ctfuh8tIteg?t=00h32m10s)

[oh it's going to be a different number](https://youtu.be/Ctfuh8tIteg?t=00h32m13s)

[though](https://youtu.be/Ctfuh8tIteg?t=00h32m14s)

[um because we changed](https://youtu.be/Ctfuh8tIteg?t=00h32m16s)

[I gotta now look at context](https://youtu.be/Ctfuh8tIteg?t=00h32m19s)

[uh let's see this is on the](https://youtu.be/Ctfuh8tIteg?t=00h32m22s)

[span that](https://youtu.be/Ctfuh8tIteg?t=00h32m26s)

[drop down border](https://youtu.be/Ctfuh8tIteg?t=00h32m27s)

[here](https://youtu.be/Ctfuh8tIteg?t=00h32m30s)

[this one](https://youtu.be/Ctfuh8tIteg?t=00h32m32s)

[oh](https://youtu.be/Ctfuh8tIteg?t=00h32m34s)

[let's do that](https://youtu.be/Ctfuh8tIteg?t=00h32m36s)

[and then](https://youtu.be/Ctfuh8tIteg?t=00h32m40s)

[that'll handle that one](https://youtu.be/Ctfuh8tIteg?t=00h32m42s)

[oh and the other one is](https://youtu.be/Ctfuh8tIteg?t=00h32m46s)

[oops did I change the wrong thing it](https://youtu.be/Ctfuh8tIteg?t=00h32m48s)

[shows I'm looking at the wrong one nope](https://youtu.be/Ctfuh8tIteg?t=00h32m50s)

[same control name different control](https://youtu.be/Ctfuh8tIteg?t=00h32m52s)

[three two oh thereabouts uh](https://youtu.be/Ctfuh8tIteg?t=00h32m56s)

[uh there that guy](https://youtu.be/Ctfuh8tIteg?t=00h33m03s)

[let's see](https://youtu.be/Ctfuh8tIteg?t=00h33m06s)

[and we're just gonna pretend like we](https://youtu.be/Ctfuh8tIteg?t=00h33m08s)

[didn't make a mistake amend commit](https://youtu.be/Ctfuh8tIteg?t=00h33m09s)

[Force push](https://youtu.be/Ctfuh8tIteg?t=00h33m13s)

[there were no errors history has been](https://youtu.be/Ctfuh8tIteg?t=00h33m15s)

[made right](https://youtu.be/Ctfuh8tIteg?t=00h33m18s)

[perfect okay](https://youtu.be/Ctfuh8tIteg?t=00h33m19s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=00h33m22s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h33m24s)

[let's see and](https://youtu.be/Ctfuh8tIteg?t=00h33m25s)

[add single comment](https://youtu.be/Ctfuh8tIteg?t=00h33m28s)

[resolve conversation come on there we go](https://youtu.be/Ctfuh8tIteg?t=00h33m32s)

[and](https://youtu.be/Ctfuh8tIteg?t=00h33m35s)

[come on GitHub you can do it](https://youtu.be/Ctfuh8tIteg?t=00h33m38s)

[taste](https://youtu.be/Ctfuh8tIteg?t=00h33m40s)

[add single comment I really wish there](https://youtu.be/Ctfuh8tIteg?t=00h33m43s)

[was a ad comment and resolve](https://youtu.be/Ctfuh8tIteg?t=00h33m45s)

[at once intent GitHub](https://youtu.be/Ctfuh8tIteg?t=00h33m48s)

[okay we're gonna do that](https://youtu.be/Ctfuh8tIteg?t=00h33m51s)

[and then against my better judgment](https://youtu.be/Ctfuh8tIteg?t=00h33m54s)

[uh no we're gonna I don't wanna hit the](https://youtu.be/Ctfuh8tIteg?t=00h33m57s)

[refresh button here it'll take forever](https://youtu.be/Ctfuh8tIteg?t=00h34m00s)

[for it to go](https://youtu.be/Ctfuh8tIteg?t=00h34m02s)

[okay so now we're in the data grid](https://youtu.be/Ctfuh8tIteg?t=00h34m05s)

[let's go take a look at this data grid](https://youtu.be/Ctfuh8tIteg?t=00h34m10s)

[text pop-up style so data grid 133 okay](https://youtu.be/Ctfuh8tIteg?t=00h34m12s)

[so do](https://youtu.be/Ctfuh8tIteg?t=00h34m18s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=00h34m19s)

[close you](https://youtu.be/Ctfuh8tIteg?t=00h34m21s)

[close you and I want to come here here](https://youtu.be/Ctfuh8tIteg?t=00h34m23s)

[here here here here data grid](https://youtu.be/Ctfuh8tIteg?t=00h34m26s)

[133.](https://youtu.be/Ctfuh8tIteg?t=00h34m31s)

[I'm gonna let that go for a minute](https://youtu.be/Ctfuh8tIteg?t=00h34m44s)

[my poor AC unit is firing off a bunch](https://youtu.be/Ctfuh8tIteg?t=00h34m47s)

[and annoying me Okay so](https://youtu.be/Ctfuh8tIteg?t=00h34m50s)

[what are we in here so this is the](https://youtu.be/Ctfuh8tIteg?t=00h34m54s)

[material design data grid text column](https://youtu.be/Ctfuh8tIteg?t=00h34m56s)

[pop-up editing Style](https://youtu.be/Ctfuh8tIteg?t=00h34m59s)

[okay](https://youtu.be/Ctfuh8tIteg?t=00h35m05s)

[the](https://youtu.be/Ctfuh8tIteg?t=00h35m08s)

[I have this bad idea by the way and](https://youtu.be/Ctfuh8tIteg?t=00h35m13s)

[somebody should probably talk me out of](https://youtu.be/Ctfuh8tIteg?t=00h35m15s)

[it](https://youtu.be/Ctfuh8tIteg?t=00h35m16s)

[of fixing the name of all of these style](https://youtu.be/Ctfuh8tIteg?t=00h35m17s)

[keys so that it looks more like these](https://youtu.be/Ctfuh8tIteg?t=00h35m20s)

[with the nice dots in the middle of them](https://youtu.be/Ctfuh8tIteg?t=00h35m23s)

[like there's something nicer about](https://youtu.be/Ctfuh8tIteg?t=00h35m25s)

[reading material design dot data grid](https://youtu.be/Ctfuh8tIteg?t=00h35m27s)

[dot text column editing Style](https://youtu.be/Ctfuh8tIteg?t=00h35m31s)

[right](https://youtu.be/Ctfuh8tIteg?t=00h35m35s)

[maybe like that I I don't know I don't](https://youtu.be/Ctfuh8tIteg?t=00h35m39s)

[know there's](https://youtu.be/Ctfuh8tIteg?t=00h35m41s)

[obviously a breaking change but the the](https://youtu.be/Ctfuh8tIteg?t=00h35m42s)

[only nice part is styles are a little](https://youtu.be/Ctfuh8tIteg?t=00h35m44s)

[easier to rename because you can just](https://youtu.be/Ctfuh8tIteg?t=00h35m46s)

[put in like](https://youtu.be/Ctfuh8tIteg?t=00h35m48s)

[you put in the new style and then you](https://youtu.be/Ctfuh8tIteg?t=00h35m51s)

[create a](https://youtu.be/Ctfuh8tIteg?t=00h35m53s)

[or I should say you rename the style](https://youtu.be/Ctfuh8tIteg?t=00h35m55s)

[then you put in a new style with the old](https://youtu.be/Ctfuh8tIteg?t=00h35m57s)

[style key and just base it on the new](https://youtu.be/Ctfuh8tIteg?t=00h35m59s)

[one and then poof everything forwards](https://youtu.be/Ctfuh8tIteg?t=00h36m01s)

[and everyone's happy so there's there's](https://youtu.be/Ctfuh8tIteg?t=00h36m03s)

[that](https://youtu.be/Ctfuh8tIteg?t=00h36m05s)

[so but this guy here has the hover one](https://youtu.be/Ctfuh8tIteg?t=00h36m07s)

[and this is the text column pop-up](https://youtu.be/Ctfuh8tIteg?t=00h36m12s)

[I think we probably just want to go back](https://youtu.be/Ctfuh8tIteg?t=00h36m18s)

[here](https://youtu.be/Ctfuh8tIteg?t=00h36m21s)

[because we we probably want a brush](https://youtu.be/Ctfuh8tIteg?t=00h36m23s)

[similar to this but I don't think I want](https://youtu.be/Ctfuh8tIteg?t=00h36m25s)

[to share the same brush I think I want](https://youtu.be/Ctfuh8tIteg?t=00h36m27s)

[to do a new one](https://youtu.be/Ctfuh8tIteg?t=00h36m29s)

[um I'm trying to decide what it should](https://youtu.be/Ctfuh8tIteg?t=00h36m34s)

[be though](https://youtu.be/Ctfuh8tIteg?t=00h36m36s)

[because I'm so this should probably be](https://youtu.be/Ctfuh8tIteg?t=00h36m37s)

[data grid Dot](https://youtu.be/Ctfuh8tIteg?t=00h36m42s)

[I wonder if it like pop-up background](https://youtu.be/Ctfuh8tIteg?t=00h36m46s)

[makes sense](https://youtu.be/Ctfuh8tIteg?t=00h36m49s)

[maybe we could do](https://youtu.be/Ctfuh8tIteg?t=00h36m54s)

[datagrid.popup Dot](https://youtu.be/Ctfuh8tIteg?t=00h36m55s)

[I mean we could do that does that make](https://youtu.be/Ctfuh8tIteg?t=00h37m08s)

[sense](https://youtu.be/Ctfuh8tIteg?t=00h37m10s)

[kind of works it's not](https://youtu.be/Ctfuh8tIteg?t=00h37m17s)

[it's a little awkward](https://youtu.be/Ctfuh8tIteg?t=00h37m20s)

[and it's not background it's border](https://youtu.be/Ctfuh8tIteg?t=00h37m23s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h37m34s)

[it would be more like that](https://youtu.be/Ctfuh8tIteg?t=00h37m35s)

[I think that works](https://youtu.be/Ctfuh8tIteg?t=00h37m39s)

[yeah](https://youtu.be/Ctfuh8tIteg?t=00h37m42s)

[data grid pop-up border](https://youtu.be/Ctfuh8tIteg?t=00h37m43s)

[this is the editing style in a pop-up](https://youtu.be/Ctfuh8tIteg?t=00h37m47s)

[for the thing yeah I think that works](https://youtu.be/Ctfuh8tIteg?t=00h37m49s)

[I think that works okay so we want to](https://youtu.be/Ctfuh8tIteg?t=00h37m52s)

[duplicate](https://youtu.be/Ctfuh8tIteg?t=00h37m55s)

[what exactly what we did because this](https://youtu.be/Ctfuh8tIteg?t=00h37m57s)

[one was](https://youtu.be/Ctfuh8tIteg?t=00h37m59s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h38m01s)

[this](https://youtu.be/Ctfuh8tIteg?t=00h38m06s)

[is this was the same one that we](https://youtu.be/Ctfuh8tIteg?t=00h38m09s)

[replaced here right](https://youtu.be/Ctfuh8tIteg?t=00h38m10s)

[I believe so](https://youtu.be/Ctfuh8tIteg?t=00h38m13s)

[let's see text box hover background](https://youtu.be/Ctfuh8tIteg?t=00h38m15s)

[right and that's what we're replacing on](https://youtu.be/Ctfuh8tIteg?t=00h38m20s)

[our working changes](https://youtu.be/Ctfuh8tIteg?t=00h38m22s)

[is text box hover background](https://youtu.be/Ctfuh8tIteg?t=00h38m24s)

[text box hover background yeah okay](https://youtu.be/Ctfuh8tIteg?t=00h38m27s)

[good good so we can take the same value](https://youtu.be/Ctfuh8tIteg?t=00h38m30s)

[we just did just combo box hover oh and](https://youtu.be/Ctfuh8tIteg?t=00h38m33s)

[combo box hover is out of order](https://youtu.be/Ctfuh8tIteg?t=00h38m37s)

[let's move it up](https://youtu.be/Ctfuh8tIteg?t=00h38m39s)

[alphabetizing makes me happy](https://youtu.be/Ctfuh8tIteg?t=00h38m41s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h38m45s)

[and we were going to put this in Dot](https://youtu.be/Ctfuh8tIteg?t=00h38m46s)

[pop-up.border](https://youtu.be/Ctfuh8tIteg?t=00h38m48s)

[I wonder if these should be dot](https://youtu.be/Ctfuh8tIteg?t=00h38m51s)

[combobox.hover dot](https://youtu.be/Ctfuh8tIteg?t=00h38m54s)

[huh](https://youtu.be/Ctfuh8tIteg?t=00h38m58s)

[I don't know where to break that day](https://youtu.be/Ctfuh8tIteg?t=00h39m00s)

[grid](https://youtu.be/Ctfuh8tIteg?t=00h39m02s)

[because should this be pop-up border](https://youtu.be/Ctfuh8tIteg?t=00h39m03s)

[that's probably better to be in line](https://youtu.be/Ctfuh8tIteg?t=00h39m08s)

[with the rest of them](https://youtu.be/Ctfuh8tIteg?t=00h39m10s)

[let's go that route I think I I'm trying](https://youtu.be/Ctfuh8tIteg?t=00h39m13s)

[because each level of these dots the the](https://youtu.be/Ctfuh8tIteg?t=00h39m16s)

[generator that I'm using will will do](https://youtu.be/Ctfuh8tIteg?t=00h39m19s)

[levels of nesting with inner classes to](https://youtu.be/Ctfuh8tIteg?t=00h39m21s)

[build out an object model for each of](https://youtu.be/Ctfuh8tIteg?t=00h39m23s)

[these theming brushes that way if you](https://youtu.be/Ctfuh8tIteg?t=00h39m25s)

[don't want to interact with the the](https://youtu.be/Ctfuh8tIteg?t=00h39m27s)

[theming stuff in xaml you can do it in](https://youtu.be/Ctfuh8tIteg?t=00h39m29s)

[code and get nice intellisense I just](https://youtu.be/Ctfuh8tIteg?t=00h39m32s)

[didn't want to have to write all that](https://youtu.be/Ctfuh8tIteg?t=00h39m34s)

[code it was going to be annoying to keep](https://youtu.be/Ctfuh8tIteg?t=00h39m35s)

[all that crap in sync so I did](https://youtu.be/Ctfuh8tIteg?t=00h39m37s)

[I did this instead](https://youtu.be/Ctfuh8tIteg?t=00h39m39s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=00h39m42s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h39m42s)

[yeah I think that's better so we're](https://youtu.be/Ctfuh8tIteg?t=00h39m44s)

[gonna do pop-up](https://youtu.be/Ctfuh8tIteg?t=00h39m46s)

[which is going to end up putting me here](https://youtu.be/Ctfuh8tIteg?t=00h39m48s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h39m50s)

[pop-up border](https://youtu.be/Ctfuh8tIteg?t=00h39m56s)

[black and white](https://youtu.be/Ctfuh8tIteg?t=00h39m59s)

[all right and we can just go and double](https://youtu.be/Ctfuh8tIteg?t=00h40m03s)

[check it against our original just to](https://youtu.be/Ctfuh8tIteg?t=00h40m04s)

[make sure text box hover background so](https://youtu.be/Ctfuh8tIteg?t=00h40m06s)

[if we go down here](https://youtu.be/Ctfuh8tIteg?t=00h40m08s)

[go to text box](https://youtu.be/Ctfuh8tIteg?t=00h40m10s)

[of our background black and white 100 so](https://youtu.be/Ctfuh8tIteg?t=00h40m14s)

[we're good](https://youtu.be/Ctfuh8tIteg?t=00h40m16s)

[we're good there](https://youtu.be/Ctfuh8tIteg?t=00h40m17s)

[uh there did a good pop](https://youtu.be/Ctfuh8tIteg?t=00h40m21s)

[order right](https://youtu.be/Ctfuh8tIteg?t=00h40m24s)

[okay](https://youtu.be/Ctfuh8tIteg?t=00h40m27s)

[let's check the rest of the code review](https://youtu.be/Ctfuh8tIteg?t=00h40m28s)

[and see if there's anything else in this](https://youtu.be/Ctfuh8tIteg?t=00h40m30s)

[guy that we missed](https://youtu.be/Ctfuh8tIteg?t=00h40m31s)

[uh uh let's see](https://youtu.be/Ctfuh8tIteg?t=00h40m37s)

[data grid](https://youtu.be/Ctfuh8tIteg?t=00h40m43s)

[this should definitely be its own brush](https://youtu.be/Ctfuh8tIteg?t=00h40m46s)

[this is 466.](https://youtu.be/Ctfuh8tIteg?t=00h40m49s)

[uh let's see](https://youtu.be/Ctfuh8tIteg?t=00h40m53s)

[yeah so this should definitely be](https://youtu.be/Ctfuh8tIteg?t=00h40m57s)

[data grid I can spell](https://youtu.be/Ctfuh8tIteg?t=00h41m01s)

[order](https://youtu.be/Ctfuh8tIteg?t=00h41m04s)

[order](https://youtu.be/Ctfuh8tIteg?t=00h41m12s)

[so we'll go down once again and just](https://youtu.be/Ctfuh8tIteg?t=00h41m14s)

[make sure that I'm creating the right](https://youtu.be/Ctfuh8tIteg?t=00h41m16s)

[one](https://youtu.be/Ctfuh8tIteg?t=00h41m17s)

[I guess it's going to be the same as](https://youtu.be/Ctfuh8tIteg?t=00h41m20s)

[what we did before data grid border is B](https://youtu.be/Ctfuh8tIteg?t=00h41m22s)

[o comes before bu](https://youtu.be/Ctfuh8tIteg?t=00h41m28s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h41m31s)

[uh order that goes in there that goes in](https://youtu.be/Ctfuh8tIteg?t=00h41m34s)

[there](https://youtu.be/Ctfuh8tIteg?t=00h41m37s)

[perfect](https://youtu.be/Ctfuh8tIteg?t=00h41m38s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h41m40s)

[it seems vague](https://youtu.be/Ctfuh8tIteg?t=00h41m42s)

[so selected cell border brush](https://youtu.be/Ctfuh8tIteg?t=00h41m44s)

[hmm](https://youtu.be/Ctfuh8tIteg?t=00h41m49s)

[yeah in this case](https://youtu.be/Ctfuh8tIteg?t=00h41m58s)

[foreign](https://youtu.be/Ctfuh8tIteg?t=00h42m02s)

[and easily adjusted](https://youtu.be/Ctfuh8tIteg?t=00h42m13s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h42m16s)

[if needed uh](https://youtu.be/Ctfuh8tIteg?t=00h42m18s)

[okay so I think we're gonna do](https://youtu.be/Ctfuh8tIteg?t=00h42m24s)

[this one here we're going to resolve](https://youtu.be/Ctfuh8tIteg?t=00h42m27s)

[effectively as it won't fix so I think](https://youtu.be/Ctfuh8tIteg?t=00h42m29s)

[that's probably okay](https://youtu.be/Ctfuh8tIteg?t=00h42m32s)

[the other ones though are certainly](https://youtu.be/Ctfuh8tIteg?t=00h42m34s)

[issues and we are going to](https://youtu.be/Ctfuh8tIteg?t=00h42m36s)

[fix them here so we come back in here we](https://youtu.be/Ctfuh8tIteg?t=00h42m39s)

[go Gen me some brushes we go bippity](https://youtu.be/Ctfuh8tIteg?t=00h42m42s)

[boppity](https://youtu.be/Ctfuh8tIteg?t=00h42m44s)

[Booyah and our diff gets huge](https://youtu.be/Ctfuh8tIteg?t=00h42m47s)

[my apologies that my big head is in the](https://youtu.be/Ctfuh8tIteg?t=00h42m51s)

[way](https://youtu.be/Ctfuh8tIteg?t=00h42m53s)

[oh once again I didn't do the bloody](https://youtu.be/Ctfuh8tIteg?t=00h42m55s)

[rebuild I am so annoyed at this](https://youtu.be/Ctfuh8tIteg?t=00h42m58s)

[I almost want to find a cleaner way to](https://youtu.be/Ctfuh8tIteg?t=00h43m00s)

[do this](https://youtu.be/Ctfuh8tIteg?t=00h43m02s)

[okay](https://youtu.be/Ctfuh8tIteg?t=00h43m04s)

[please send me some brushes there we go](https://youtu.be/Ctfuh8tIteg?t=00h43m09s)

[you'll note it even generates UI tests](https://youtu.be/Ctfuh8tIteg?t=00h43m11s)

[for me mwah](https://youtu.be/Ctfuh8tIteg?t=00h43m14s)

[must love the UI test](https://youtu.be/Ctfuh8tIteg?t=00h43m16s)

[um possibly somewhat worthless test](https://youtu.be/Ctfuh8tIteg?t=00h43m21s)

[given that once I know that my thing is](https://youtu.be/Ctfuh8tIteg?t=00h43m23s)

[working but](https://youtu.be/Ctfuh8tIteg?t=00h43m26s)

[it gives me a lot of confidence that](https://youtu.be/Ctfuh8tIteg?t=00h43m28s)

[my generation is working end to end so](https://youtu.be/Ctfuh8tIteg?t=00h43m31s)

[like this is what I was saying is we](https://youtu.be/Ctfuh8tIteg?t=00h43m34s)

[added a datagrid.border it gends the](https://youtu.be/Ctfuh8tIteg?t=00h43m36s)

[data grid class it adds a border](https://youtu.be/Ctfuh8tIteg?t=00h43m38s)

[property to it comes down here pop-up](https://youtu.be/Ctfuh8tIteg?t=00h43m40s)

[border](https://youtu.be/Ctfuh8tIteg?t=00h43m42s)

[I do wonder if maybe I should](https://youtu.be/Ctfuh8tIteg?t=00h43m45s)

[alphabetize these](https://youtu.be/Ctfuh8tIteg?t=00h43m46s)

[because the fact that's selected in](https://youtu.be/Ctfuh8tIteg?t=00h43m48s)

[column header foreground are down here](https://youtu.be/Ctfuh8tIteg?t=00h43m50s)

[concern me](https://youtu.be/Ctfuh8tIteg?t=00h43m52s)

[why are those out of order](https://youtu.be/Ctfuh8tIteg?t=00h43m57s)

[where are those brushes](https://youtu.be/Ctfuh8tIteg?t=00h44m09s)

[hang on](https://youtu.be/Ctfuh8tIteg?t=00h44m12s)

[column header foreground](https://youtu.be/Ctfuh8tIteg?t=00h44m14s)

[why is that one so far](https://youtu.be/Ctfuh8tIteg?t=00h44m16s)

[like I see selected here](https://youtu.be/Ctfuh8tIteg?t=00h44m21s)

[that one just not in the oh this one has](https://youtu.be/Ctfuh8tIteg?t=00h44m26s)

[alternate keys](https://youtu.be/Ctfuh8tIteg?t=00h44m29s)

[got it](https://youtu.be/Ctfuh8tIteg?t=00h44m32s)

[oh maybe that's what I should be doing](https://youtu.be/Ctfuh8tIteg?t=00h44m35s)

[well hmm](https://youtu.be/Ctfuh8tIteg?t=00h44m38s)

[should I set it up as a separate brush](https://youtu.be/Ctfuh8tIteg?t=00h44m41s)

[or should I set it up as an alternate](https://youtu.be/Ctfuh8tIteg?t=00h44m44s)

[key to the same brush](https://youtu.be/Ctfuh8tIteg?t=00h44m45s)

[or I don't know if I like these](https://youtu.be/Ctfuh8tIteg?t=00h44m52s)

[alternate key things](https://youtu.be/Ctfuh8tIteg?t=00h44m54s)

[I think I like the way I have it](https://youtu.be/Ctfuh8tIteg?t=00h44m56s)

[I think I like the way I have it we're](https://youtu.be/Ctfuh8tIteg?t=00h44m59s)

[gonna keep it for now](https://youtu.be/Ctfuh8tIteg?t=00h45m01s)

[keep it for now keep it for now keep it](https://youtu.be/Ctfuh8tIteg?t=00h45m03s)

[for now okay so](https://youtu.be/Ctfuh8tIteg?t=00h45m05s)

[uh adding uh](https://youtu.be/Ctfuh8tIteg?t=00h45m08s)

[uh let's go back and grab the brush](https://youtu.be/Ctfuh8tIteg?t=00h45m14s)

[data grid data grid](https://youtu.be/Ctfuh8tIteg?t=00h45m18s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h45m23s)

[I'm blinking which ones which ones are](https://youtu.be/Ctfuh8tIteg?t=00h45m29s)

[my new ones](https://youtu.be/Ctfuh8tIteg?t=00h45m30s)

[data grid border and data grid pop-up](https://youtu.be/Ctfuh8tIteg?t=00h45m32s)

[border](https://youtu.be/Ctfuh8tIteg?t=00h45m34s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h45m37s)

[let's see uh](https://youtu.be/Ctfuh8tIteg?t=00h45m46s)

[added](https://youtu.be/Ctfuh8tIteg?t=00h45m49s)

[oh this was meant to go in here](https://youtu.be/Ctfuh8tIteg?t=00h45m51s)

[uh pop-up border](https://youtu.be/Ctfuh8tIteg?t=00h45m54s)

[uh did you learn WPF at all of two or](https://youtu.be/Ctfuh8tIteg?t=00h45m58s)

[just randomly teach yourself great great](https://youtu.be/Ctfuh8tIteg?t=00h46m01s)

[question so for those people who are](https://youtu.be/Ctfuh8tIteg?t=00h46m03s)

[unaware uh I previously used to work for](https://youtu.be/Ctfuh8tIteg?t=00h46m06s)

[a company called Olive Tree Bible](https://youtu.be/Ctfuh8tIteg?t=00h46m08s)

[Software](https://youtu.be/Ctfuh8tIteg?t=00h46m10s)

[um they produce a](https://youtu.be/Ctfuh8tIteg?t=00h46m12s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h46m15s)

[think of it like a a Christian based uh](https://youtu.be/Ctfuh8tIteg?t=00h46m16s)

[Kindle](https://youtu.be/Ctfuh8tIteg?t=00h46m19s)

[app style thing there's libraries books](https://youtu.be/Ctfuh8tIteg?t=00h46m20s)

[primarily an e-reader I got hired on to](https://youtu.be/Ctfuh8tIteg?t=00h46m23s)

[work on their Windows team when it was](https://youtu.be/Ctfuh8tIteg?t=00h46m26s)

[first starting out because they were](https://youtu.be/Ctfuh8tIteg?t=00h46m29s)

[wanting to build a they they try to](https://youtu.be/Ctfuh8tIteg?t=00h46m30s)

[Target lots of platforms and they were](https://youtu.be/Ctfuh8tIteg?t=00h46m33s)

[looking to do Windows desktop and uh I](https://youtu.be/Ctfuh8tIteg?t=00h46m34s)

[came in I did not actually learn WPF](https://youtu.be/Ctfuh8tIteg?t=00h46m37s)

[there](https://youtu.be/Ctfuh8tIteg?t=00h46m40s)

[um I arguably got hired because of how](https://youtu.be/Ctfuh8tIteg?t=00h46m42s)

[well I knew WPF](https://youtu.be/Ctfuh8tIteg?t=00h46m44s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h46m46s)

[so when I first started](https://youtu.be/Ctfuh8tIteg?t=00h46m48s)

[ye long time ago](https://youtu.be/Ctfuh8tIteg?t=00h46m52s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h46m55s)

[I I actually started out uh at a job](https://youtu.be/Ctfuh8tIteg?t=00h46m56s)

[where](https://youtu.be/Ctfuh8tIteg?t=00h47m00s)

[well we're gonna back up even further](https://youtu.be/Ctfuh8tIteg?t=00h47m01s)

[all right we're gonna do the whole story](https://youtu.be/Ctfuh8tIteg?t=00h47m03s)

[whole story of where we go](https://youtu.be/Ctfuh8tIteg?t=00h47m05s)

[so](https://youtu.be/Ctfuh8tIteg?t=00h47m07s)

[um when I was going uh to University](https://youtu.be/Ctfuh8tIteg?t=00h47m08s)

[there was a](https://youtu.be/Ctfuh8tIteg?t=00h47m11s)

[uh Professor who at the time I thought I](https://youtu.be/Ctfuh8tIteg?t=00h47m13s)

[wanted to be a network engineer doing uh](https://youtu.be/Ctfuh8tIteg?t=00h47m16s)

[like sysadmin type work and he convinced](https://youtu.be/Ctfuh8tIteg?t=00h47m19s)

[me he's like you know why don't you try](https://youtu.be/Ctfuh8tIteg?t=00h47m23s)

[this programming thing I'm like yeah I](https://youtu.be/Ctfuh8tIteg?t=00h47m24s)

[don't know he's like you should give it](https://youtu.be/Ctfuh8tIteg?t=00h47m26s)

[a try I think you might like it I'm like](https://youtu.be/Ctfuh8tIteg?t=00h47m28s)

[ah fine whatever we'll give it a try](https://youtu.be/Ctfuh8tIteg?t=00h47m29s)

[so I went and did it and I took this](https://youtu.be/Ctfuh8tIteg?t=00h47m32s)

[class](https://youtu.be/Ctfuh8tIteg?t=00h47m34s)

[um arguably from Santa Claus](https://youtu.be/Ctfuh8tIteg?t=00h47m36s)

[uh the the professor who taught it was a](https://youtu.be/Ctfuh8tIteg?t=00h47m39s)

[much older gentleman he had a full white](https://youtu.be/Ctfuh8tIteg?t=00h47m43s)

[beard large pot belly](https://youtu.be/Ctfuh8tIteg?t=00h47m46s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h47m49s)

[he knew he looked like Santa Claus he](https://youtu.be/Ctfuh8tIteg?t=00h47m50s)

[played into looking like Santa Claus at](https://youtu.be/Ctfuh8tIteg?t=00h47m52s)

[Christmas time he great the mysterious](https://youtu.be/Ctfuh8tIteg?t=00h47m54s)

[history of Kevin great Andrew](https://youtu.be/Ctfuh8tIteg?t=00h47m58s)

[um he he played up the role like at](https://youtu.be/Ctfuh8tIteg?t=00h48m00s)

[Christmas time he came in he came into](https://youtu.be/Ctfuh8tIteg?t=00h48m03s)

[class full Santa suit on](https://youtu.be/Ctfuh8tIteg?t=00h48m05s)

[like we couldn't quite always get him to](https://youtu.be/Ctfuh8tIteg?t=00h48m07s)

[go ho ho ho for us but he he definitely](https://youtu.be/Ctfuh8tIteg?t=00h48m09s)

[played it out and looked apart](https://youtu.be/Ctfuh8tIteg?t=00h48m12s)

[Joshua thanks for the follow](https://youtu.be/Ctfuh8tIteg?t=00h48m18s)

[um the uh](https://youtu.be/Ctfuh8tIteg?t=00h48m20s)

[uh so I get into his class and it wasn't](https://youtu.be/Ctfuh8tIteg?t=00h48m23s)

[a normal introduction to programming](https://youtu.be/Ctfuh8tIteg?t=00h48m26s)

[class this guy was retired and the](https://youtu.be/Ctfuh8tIteg?t=00h48m28s)

[school was desperate to get](https://youtu.be/Ctfuh8tIteg?t=00h48m32s)

[uh instructors to come back and teach](https://youtu.be/Ctfuh8tIteg?t=00h48m34s)

[and so he kind of had carte blanche to](https://youtu.be/Ctfuh8tIteg?t=00h48m37s)

[do as he felt like because he's like](https://youtu.be/Ctfuh8tIteg?t=00h48m40s)

[what are they gonna do fire me](https://youtu.be/Ctfuh8tIteg?t=00h48m42s)

[I'm trying to retire and be gone and](https://youtu.be/Ctfuh8tIteg?t=00h48m44s)

[they keep calling me back](https://youtu.be/Ctfuh8tIteg?t=00h48m46s)

[so he he got to teach the class as he](https://youtu.be/Ctfuh8tIteg?t=00h48m48s)

[wanted which was exactly as he liked it](https://youtu.be/Ctfuh8tIteg?t=00h48m51s)

[and it was a vb.net class and I usually](https://youtu.be/Ctfuh8tIteg?t=00h48m53s)

[don't tell people that I know VB because](https://youtu.be/Ctfuh8tIteg?t=00h48m57s)

[I don't like to admit it](https://youtu.be/Ctfuh8tIteg?t=00h48m58s)

[um but it was actually my first](https://youtu.be/Ctfuh8tIteg?t=00h49m00s)

[introduction to coding and I absolutely](https://youtu.be/Ctfuh8tIteg?t=00h49m02s)

[loved it the the class was Windows forms](https://youtu.be/Ctfuh8tIteg?t=00h49m05s)

[and you got like](https://youtu.be/Ctfuh8tIteg?t=00h49m08s)

[there was a lot of like technology](https://youtu.be/Ctfuh8tIteg?t=00h49m11s)

[language shaming because right after us](https://youtu.be/Ctfuh8tIteg?t=00h49m13s)

[the uh the C-Class guys came in they](https://youtu.be/Ctfuh8tIteg?t=00h49m15s)

[were clearly the elites because they](https://youtu.be/Ctfuh8tIteg?t=00h49m18s)

[were coding in C and doing all this](https://youtu.be/Ctfuh8tIteg?t=00h49m20s)

[low-level stuff and I remember one time](https://youtu.be/Ctfuh8tIteg?t=00h49m22s)

[the professor looks over because we had](https://youtu.be/Ctfuh8tIteg?t=00h49m25s)

[built a little pong game in a 50-minute](https://youtu.be/Ctfuh8tIteg?t=00h49m26s)

[class he's like you try to do this and](https://youtu.be/Ctfuh8tIteg?t=00h49m29s)

[see](https://youtu.be/Ctfuh8tIteg?t=00h49m31s)

[he's like we built an entire pong game](https://youtu.be/Ctfuh8tIteg?t=00h49m32s)

[in 50 minutes what have you guys gotten](https://youtu.be/Ctfuh8tIteg?t=00h49m34s)

[done and it was you know kind of some](https://youtu.be/Ctfuh8tIteg?t=00h49m36s)

[some good-natured uh ribbing on each](https://youtu.be/Ctfuh8tIteg?t=00h49m39s)

[other which was hilarious but I](https://youtu.be/Ctfuh8tIteg?t=00h49m41s)

[absolutely loved it](https://youtu.be/Ctfuh8tIteg?t=00h49m45s)

[um and so when I was getting ready to](https://youtu.be/Ctfuh8tIteg?t=00h49m46s)

[graduate I applied for a job at a local](https://youtu.be/Ctfuh8tIteg?t=00h49m48s)

[company that did](https://youtu.be/Ctfuh8tIteg?t=00h49m52s)

[um uh chat Bots uh type software](https://youtu.be/Ctfuh8tIteg?t=00h49m54s)

[they it was basically when those a the](https://youtu.be/Ctfuh8tIteg?t=00h49m58s)

[little expert system AI chat with an](https://youtu.be/Ctfuh8tIteg?t=00h50m01s)

[agent bots on the website were were](https://youtu.be/Ctfuh8tIteg?t=00h50m04s)

[brand new these were these were fancy](https://youtu.be/Ctfuh8tIteg?t=00h50m06s)

[not many people had them at the time and](https://youtu.be/Ctfuh8tIteg?t=00h50m08s)

[they had come up with](https://youtu.be/Ctfuh8tIteg?t=00h50m10s)

[um a fairly good AI agent they had a](https://youtu.be/Ctfuh8tIteg?t=00h50m12s)

[couple of researchers that were amazing](https://youtu.be/Ctfuh8tIteg?t=00h50m15s)

[that were the brains behind how this](https://youtu.be/Ctfuh8tIteg?t=00h50m18s)

[whole thing worked and then there was a](https://youtu.be/Ctfuh8tIteg?t=00h50m20s)

[bunch of us peons building supporting](https://youtu.be/Ctfuh8tIteg?t=00h50m23s)

[software around this infrastructure and](https://youtu.be/Ctfuh8tIteg?t=00h50m25s)

[so I get hired on and I'm building](https://youtu.be/Ctfuh8tIteg?t=00h50m28s)

[um a Windows forms application for](https://youtu.be/Ctfuh8tIteg?t=00h50m31s)

[people who review the chats so customer](https://youtu.be/Ctfuh8tIteg?t=00h50m34s)

[would buy this big software package](https://youtu.be/Ctfuh8tIteg?t=00h50m36s)

[their AI budget bot is chatting with](https://youtu.be/Ctfuh8tIteg?t=00h50m38s)

[people and they had people that would go](https://youtu.be/Ctfuh8tIteg?t=00h50m41s)

[through and review the chats to to](https://youtu.be/Ctfuh8tIteg?t=00h50m44s)

[effectively grade the AI bot on how it's](https://youtu.be/Ctfuh8tIteg?t=00h50m45s)

[doing and go nope it clearly got that](https://youtu.be/Ctfuh8tIteg?t=00h50m48s)

[question wrong or oh yeah good job and](https://youtu.be/Ctfuh8tIteg?t=00h50m50s)

[so that way they could then start](https://youtu.be/Ctfuh8tIteg?t=00h50m52s)

[tweaking it to get its accuracy up and](https://youtu.be/Ctfuh8tIteg?t=00h50m54s)

[it was all it was all a numbers game](https://youtu.be/Ctfuh8tIteg?t=00h50m56s)

[game and so we were building out the](https://youtu.be/Ctfuh8tIteg?t=00h50m58s)

[software that was uh helping people do](https://youtu.be/Ctfuh8tIteg?t=00h51m00s)

[that](https://youtu.be/Ctfuh8tIteg?t=00h51m02s)

[and this was I think we had started in](https://youtu.be/Ctfuh8tIteg?t=00h51m04s)

[on it](https://youtu.be/Ctfuh8tIteg?t=00h51m07s)

[shortly before WPF was released so this](https://youtu.be/Ctfuh8tIteg?t=00h51m08s)

[would have been WPF came out in 2005](https://youtu.be/Ctfuh8tIteg?t=00h51m12s)

[is that what it is](https://youtu.be/Ctfuh8tIteg?t=00h51m17s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h51m19s)

[uh trying to remember what the what this](https://youtu.be/Ctfuh8tIteg?t=00h51m23s)

[was no it had to be later than that](https://youtu.be/Ctfuh8tIteg?t=00h51m25s)

[right](https://youtu.be/Ctfuh8tIteg?t=00h51m26s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h51m28s)

[uh oh if you have to spell WTF WP then f](https://youtu.be/Ctfuh8tIteg?t=00h51m30s)

[2006.](https://youtu.be/Ctfuh8tIteg?t=00h51m34s)

[2006.](https://youtu.be/Ctfuh8tIteg?t=00h51m36s)

[um so this would have probably then been](https://youtu.be/Ctfuh8tIteg?t=00h51m38s)

[2007 or 2008 because WPF had been out](https://youtu.be/Ctfuh8tIteg?t=00h51m41s)

[for like a year or two](https://youtu.be/Ctfuh8tIteg?t=00h51m44s)

[um there had been a bunch of reorgs and](https://youtu.be/Ctfuh8tIteg?t=00h51m47s)

[the the developer that I that I was](https://youtu.be/Ctfuh8tIteg?t=00h51m49s)

[working on because I was I was a junior](https://youtu.be/Ctfuh8tIteg?t=00h51m51s)

[guy and there was a senior guy there](https://youtu.be/Ctfuh8tIteg?t=00h51m53s)

[um arguably](https://youtu.be/Ctfuh8tIteg?t=00h51m56s)

[I credit him I'll usually refer to him](https://youtu.be/Ctfuh8tIteg?t=00h51m58s)

[as being my my original uh programming](https://youtu.be/Ctfuh8tIteg?t=00h52m00s)

[Mentor because he was amazing I learned](https://youtu.be/Ctfuh8tIteg?t=00h52m03s)

[a ton from him](https://youtu.be/Ctfuh8tIteg?t=00h52m05s)

[because I think I worked under him for](https://youtu.be/Ctfuh8tIteg?t=00h52m07s)

[three years](https://youtu.be/Ctfuh8tIteg?t=00h52m08s)

[and that was probably the sharpest curve](https://youtu.be/Ctfuh8tIteg?t=00h52m10s)

[in in my learning just from everything](https://youtu.be/Ctfuh8tIteg?t=00h52m12s)

[um he was very happy](https://youtu.be/Ctfuh8tIteg?t=00h52m15s)

[to just throw code away and redo it very](https://youtu.be/Ctfuh8tIteg?t=00h52m17s)

[happy to like he was not attached to any](https://youtu.be/Ctfuh8tIteg?t=00h52m21s)

[bit of code if they could be done better](https://youtu.be/Ctfuh8tIteg?t=00h52m24s)

[burn it down do it better it's like oh](https://youtu.be/Ctfuh8tIteg?t=00h52m27s)

[okay that's that's interesting like](https://youtu.be/Ctfuh8tIteg?t=00h52m30s)

[there was no he had I could critique](https://youtu.be/Ctfuh8tIteg?t=00h52m31s)

[anything he wrote and it was nothing was](https://youtu.be/Ctfuh8tIteg?t=00h52m34s)

[off limits which was cool](https://youtu.be/Ctfuh8tIteg?t=00h52m36s)

[um but one day he goes you know what](https://youtu.be/Ctfuh8tIteg?t=00h52m39s)

[I think it's time I I think we need to](https://youtu.be/Ctfuh8tIteg?t=00h52m42s)

[rebuild this app that we were that we](https://youtu.be/Ctfuh8tIteg?t=00h52m46s)

[were building in WPF he's there was](https://youtu.be/Ctfuh8tIteg?t=00h52m48s)

[there was a couple things we had done in](https://youtu.be/Ctfuh8tIteg?t=00h52m50s)

[Windows forms because Windows forms is](https://youtu.be/Ctfuh8tIteg?t=00h52m53s)

[great](https://youtu.be/Ctfuh8tIteg?t=00h52m56s)

[but some things are really really hard](https://youtu.be/Ctfuh8tIteg?t=00h52m57s)

[like for example putting an uh an image](https://youtu.be/Ctfuh8tIteg?t=00h52m59s)

[and some text inside of a button](https://youtu.be/Ctfuh8tIteg?t=00h53m02s)

[is really hard](https://youtu.be/Ctfuh8tIteg?t=00h53m05s)

[they're like Windows forms is awesome](https://youtu.be/Ctfuh8tIteg?t=00h53m08s)

[but without like extra Library support](https://youtu.be/Ctfuh8tIteg?t=00h53m11s)

[or different things certain things are](https://youtu.be/Ctfuh8tIteg?t=00h53m14s)

[just insanely difficult and the](https://youtu.be/Ctfuh8tIteg?t=00h53m15s)

[um UI customization of WPF is far](https://youtu.be/Ctfuh8tIteg?t=00h53m20s)

[superior to Windows forms now Windows](https://youtu.be/Ctfuh8tIteg?t=00h53m22s)

[forms has another Advantage but the the](https://youtu.be/Ctfuh8tIteg?t=00h53m24s)

[UI layer of of customization](https://youtu.be/Ctfuh8tIteg?t=00h53m26s)

[like I I think I backed sweat up pretty](https://youtu.be/Ctfuh8tIteg?t=00h53m29s)

[easily WPF Takes the Cake and so that](https://youtu.be/Ctfuh8tIteg?t=00h53m32s)

[that rewrite because I don't know how he](https://youtu.be/Ctfuh8tIteg?t=00h53m34s)

[conned management into it](https://youtu.be/Ctfuh8tIteg?t=00h53m38s)

[but they allocated I think a Sprint or](https://youtu.be/Ctfuh8tIteg?t=00h53m40s)

[two for us to do nothing other than](https://youtu.be/Ctfuh8tIteg?t=00h53m42s)

[rewrite this app from Windows forms into](https://youtu.be/Ctfuh8tIteg?t=00h53m44s)

[WPF and I think that was that was the a](https://youtu.be/Ctfuh8tIteg?t=00h53m47s)

[really steep learning curve because](https://youtu.be/Ctfuh8tIteg?t=00h53m51s)

[I didn't know mvvm](https://youtu.be/Ctfuh8tIteg?t=00h53m54s)

[I I we didn't really use we kind of use](https://youtu.be/Ctfuh8tIteg?t=00h53m56s)

[bindings in Windows forms but we weren't](https://youtu.be/Ctfuh8tIteg?t=00h53m59s)

[you doing them that much and windows](https://youtu.be/Ctfuh8tIteg?t=00h54m01s)

[forms bindings were weird like the is](https://youtu.be/Ctfuh8tIteg?t=00h54m03s)

[visible property the getter and Setter](https://youtu.be/Ctfuh8tIteg?t=00h54m05s)

[have slightly different meanings it just](https://youtu.be/Ctfuh8tIteg?t=00h54m07s)

[had blew up](https://youtu.be/Ctfuh8tIteg?t=00h54m10s)

[um which was always frustrating me](https://youtu.be/Ctfuh8tIteg?t=00h54m12s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h54m15s)

[so there was all of that but I think to](https://youtu.be/Ctfuh8tIteg?t=00h54m17s)

[go back to the original question of did](https://youtu.be/Ctfuh8tIteg?t=00h54m20s)

[I learn WPF and Olive Tree no I learned](https://youtu.be/Ctfuh8tIteg?t=00h54m22s)

[it at the employer just prior to that](https://youtu.be/Ctfuh8tIteg?t=00h54m25s)

[um there was a lot of](https://youtu.be/Ctfuh8tIteg?t=00h54m28s)

[self-teaching because it was one of](https://youtu.be/Ctfuh8tIteg?t=00h54m30s)

[those technologies that I fell in love](https://youtu.be/Ctfuh8tIteg?t=00h54m33s)

[with as soon as I started using it](https://youtu.be/Ctfuh8tIteg?t=00h54m35s)

[and I would then go and build apps with](https://youtu.be/Ctfuh8tIteg?t=00h54m37s)

[it](https://youtu.be/Ctfuh8tIteg?t=00h54m39s)

[and I and that was that was arguably a](https://youtu.be/Ctfuh8tIteg?t=00h54m40s)

[lot of the the learning that came from](https://youtu.be/Ctfuh8tIteg?t=00h54m43s)

[it because the general rule is once](https://youtu.be/Ctfuh8tIteg?t=00h54m45s)

[you've spent like ten thousand I think](https://youtu.be/Ctfuh8tIteg?t=00h54m48s)

[it's ten thousand hours](https://youtu.be/Ctfuh8tIteg?t=00h54m50s)

[I think that's usually like a ballpark](https://youtu.be/Ctfuh8tIteg?t=00h54m52s)

[metric of what people say is you you got](https://youtu.be/Ctfuh8tIteg?t=00h54m54s)

[to spend ten thousand hours on something](https://youtu.be/Ctfuh8tIteg?t=00h54m56s)

[before you're an expert in it and again](https://youtu.be/Ctfuh8tIteg?t=00h54m58s)

[that's](https://youtu.be/Ctfuh8tIteg?t=00h55m00s)

[take it as you will but it's it's an](https://youtu.be/Ctfuh8tIteg?t=00h55m01s)

[okay-ish metric of you know where you're](https://youtu.be/Ctfuh8tIteg?t=00h55m04s)

[at](https://youtu.be/Ctfuh8tIteg?t=00h55m06s)

[um I easily have my 10 000 hours](https://youtu.be/Ctfuh8tIteg?t=00h55m08s)

[possibly more than that](https://youtu.be/Ctfuh8tIteg?t=00h55m11s)

[because I have spent a sizable amount of](https://youtu.be/Ctfuh8tIteg?t=00h55m13s)

[time doing it so the the falling in love](https://youtu.be/Ctfuh8tIteg?t=00h55m16s)

[with it happened before Olive Tree there](https://youtu.be/Ctfuh8tIteg?t=00h55m19s)

[was a lot of learning at Olive Tree](https://youtu.be/Ctfuh8tIteg?t=00h55m21s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h55m24s)

[and one of my current colleagues was](https://youtu.be/Ctfuh8tIteg?t=00h55m25s)

[actually my team lead at Olive Tree](https://youtu.be/Ctfuh8tIteg?t=00h55m28s)

[which was fun and him and I would go](https://youtu.be/Ctfuh8tIteg?t=00h55m30s)

[back and forth uh on stuff and so](https://youtu.be/Ctfuh8tIteg?t=00h55m33s)

[uh it was one of those I I joked when he](https://youtu.be/Ctfuh8tIteg?t=00h55m37s)

[applied to work at intellitec](https://youtu.be/Ctfuh8tIteg?t=00h55m40s)

[um I had I very happily passed along his](https://youtu.be/Ctfuh8tIteg?t=00h55m42s)

[resume with a recommendation letter and](https://youtu.be/Ctfuh8tIteg?t=00h55m45s)

[I remember one of the upper management](https://youtu.be/Ctfuh8tIteg?t=00h55m47s)

[guys immediately replied to my email and](https://youtu.be/Ctfuh8tIteg?t=00h55m49s)

[went okay we need to hold off on this](https://youtu.be/Ctfuh8tIteg?t=00h55m52s)

[guy Kevin's clearly lying he's claiming](https://youtu.be/Ctfuh8tIteg?t=00h55m54s)

[that this other guy is as good at WPF as](https://youtu.be/Ctfuh8tIteg?t=00h55m56s)

[he is and there was a big joke at that](https://youtu.be/Ctfuh8tIteg?t=00h55m58s)

[so that was always fun](https://youtu.be/Ctfuh8tIteg?t=00h56m01s)

[uh](https://youtu.be/Ctfuh8tIteg?t=00h56m03s)

[uh I have completely darn you Benjamin I](https://youtu.be/Ctfuh8tIteg?t=00h56m06s)

[completely lost my train of thought good](https://youtu.be/Ctfuh8tIteg?t=00h56m09s)

[work](https://youtu.be/Ctfuh8tIteg?t=00h56m11s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h56m12s)

[but yes that is the the long history uh](https://youtu.be/Ctfuh8tIteg?t=00h56m16s)

[to cover for that uh](https://youtu.be/Ctfuh8tIteg?t=00h56m21s)

[okay so we go there add single comment](https://youtu.be/Ctfuh8tIteg?t=00h56m27s)

[Mr Kevin darkloader WPF uh yeah I](https://youtu.be/Ctfuh8tIteg?t=00h56m37s)

[definitely don't mind rabbit trailing](https://youtu.be/Ctfuh8tIteg?t=00h56m40s)

[like for anybody who hasn't been in the](https://youtu.be/Ctfuh8tIteg?t=00h56m42s)

[chat before I am very happy for](https://youtu.be/Ctfuh8tIteg?t=00h56m45s)

[questions in Rabbit Trail discussions I](https://youtu.be/Ctfuh8tIteg?t=00h56m47s)

[do them a lot](https://youtu.be/Ctfuh8tIteg?t=00h56m50s)

[it's okay](https://youtu.be/Ctfuh8tIteg?t=00h56m52s)

[next one](https://youtu.be/Ctfuh8tIteg?t=00h56m54s)

[um](https://youtu.be/Ctfuh8tIteg?t=00h56m55s)

[uh for anyone who has this oh wait did](https://youtu.be/Ctfuh8tIteg?t=00h56m57s)

[it see that's how often I go to this](https://youtu.be/Ctfuh8tIteg?t=00h56m59s)

[particular comic is it's in my](https://youtu.be/Ctfuh8tIteg?t=00h57m03s)

[autocomplete that's bad So for anybody](https://youtu.be/Ctfuh8tIteg?t=00h57m07s)

[who hasn't seen this one before this is](https://youtu.be/Ctfuh8tIteg?t=00h57m09s)

[one of those XKCD Comics that you just](https://youtu.be/Ctfuh8tIteg?t=00h57m11s)

[have to know](https://youtu.be/Ctfuh8tIteg?t=00h57m13s)

[um it's usually it's kind of like the](https://youtu.be/Ctfuh8tIteg?t=00h57m16s)

[the phrase like debugging or rubber duck](https://youtu.be/Ctfuh8tIteg?t=00h57m18s)

[debugging](https://youtu.be/Ctfuh8tIteg?t=00h57m20s)

[or what if you aren't familiar like I](https://youtu.be/Ctfuh8tIteg?t=00h57m22s)

[need to put together a small pamphlet](https://youtu.be/Ctfuh8tIteg?t=00h57m25s)

[for people for](https://youtu.be/Ctfuh8tIteg?t=00h57m26s)

[development terms that you should know](https://youtu.be/Ctfuh8tIteg?t=00h57m28s)

[that](https://youtu.be/Ctfuh8tIteg?t=00h57m31s)

[aren't really based on real things that](https://youtu.be/Ctfuh8tIteg?t=00h57m33s)

[you would be expected to learn in a book](https://youtu.be/Ctfuh8tIteg?t=00h57m36s)

[or Academia](https://youtu.be/Ctfuh8tIteg?t=00h57m38s)

[um but they're thrown around a lot nerd](https://youtu.be/Ctfuh8tIteg?t=00h57m40s)

[sniping](https://youtu.be/Ctfuh8tIteg?t=00h57m42s)

[um Randall Monroe I believe I I think](https://youtu.be/Ctfuh8tIteg?t=00h57m44s)

[gets credit for this one I I'm not aware](https://youtu.be/Ctfuh8tIteg?t=00h57m46s)

[of an earlier reference to nerd sniping](https://youtu.be/Ctfuh8tIteg?t=00h57m49s)

[before this but if there is one let me](https://youtu.be/Ctfuh8tIteg?t=00h57m50s)

[know](https://youtu.be/Ctfuh8tIteg?t=00h57m52s)

[um this is one that I that gets thrown](https://youtu.be/Ctfuh8tIteg?t=00h57m53s)

[around a lot because](https://youtu.be/Ctfuh8tIteg?t=00h57m56s)

[it's very easy to nerd snipe people but](https://youtu.be/Ctfuh8tIteg?t=00h57m58s)

[Developers](https://youtu.be/Ctfuh8tIteg?t=00h58m00s)

[at one point because typically](https://youtu.be/Ctfuh8tIteg?t=00h58m02s)

[developers have a mindset that's really](https://youtu.be/Ctfuh8tIteg?t=00h58m05s)

[easy to nerd snipe really easy](https://youtu.be/Ctfuh8tIteg?t=00h58m07s)

[so](https://youtu.be/Ctfuh8tIteg?t=00h58m11s)

[developers are probably just one point](https://youtu.be/Ctfuh8tIteg?t=00h58m13s)

[which is unfortunate](https://youtu.be/Ctfuh8tIteg?t=00h58m14s)

[for so for what it's worth okay and then](https://youtu.be/Ctfuh8tIteg?t=00h58m19s)

[this one here is going to be the other](https://youtu.be/Ctfuh8tIteg?t=00h58m22s)

[brush](https://youtu.be/Ctfuh8tIteg?t=00h58m23s)

[do](https://youtu.be/Ctfuh8tIteg?t=00h58m25s)

[and then we go](https://youtu.be/Ctfuh8tIteg?t=00h58m27s)

[edit boom to cover this case](https://youtu.be/Ctfuh8tIteg?t=00h58m30s)

[that's even comment](https://youtu.be/Ctfuh8tIteg?t=00h58m34s)

[and resolve conversation](https://youtu.be/Ctfuh8tIteg?t=00h58m37s)

[and then I think this guy goes to bed](https://youtu.be/Ctfuh8tIteg?t=00h58m40s)

[okay we left](https://youtu.be/Ctfuh8tIteg?t=00h58m45s)

[combo box for now](https://youtu.be/Ctfuh8tIteg?t=00h58m47s)

[right yeah we skipped that one grid](https://youtu.be/Ctfuh8tIteg?t=00h58m51s)

[splitter why did I not mark this one off](https://youtu.be/Ctfuh8tIteg?t=00h58m54s)

[style naming mismatch okay so this is](https://youtu.be/Ctfuh8tIteg?t=00h58m56s)

[once again a yet one more case where we](https://youtu.be/Ctfuh8tIteg?t=00h58m58s)

[probably just need to change this up so](https://youtu.be/Ctfuh8tIteg?t=00h59m02s)

[grid splitter and it's I think it's the](https://youtu.be/Ctfuh8tIteg?t=00h59m04s)

[only style even in there](https://youtu.be/Ctfuh8tIteg?t=00h59m06s)

[uh here here oh so](https://youtu.be/Ctfuh8tIteg?t=00h59m08s)

[Pro tip because I I realized some of my](https://youtu.be/Ctfuh8tIteg?t=00h59m10s)

[colleagues the other day didn't know](https://youtu.be/Ctfuh8tIteg?t=00h59m13s)

[about this button so you can have your](https://youtu.be/Ctfuh8tIteg?t=00h59m14s)

[solution Explorer say stay in sync with](https://youtu.be/Ctfuh8tIteg?t=00h59m17s)

[whatever file you have highlighted](https://youtu.be/Ctfuh8tIteg?t=00h59m20s)

[I don't like it bouncing around on me](https://youtu.be/Ctfuh8tIteg?t=00h59m23s)

[however quite often I based on the tabs](https://youtu.be/Ctfuh8tIteg?t=00h59m25s)

[that I'm on I want to move my solution](https://youtu.be/Ctfuh8tIteg?t=00h59m29s)

[Explorer these two little Annoying](https://youtu.be/Ctfuh8tIteg?t=00h59m30s)

[double arrows](https://youtu.be/Ctfuh8tIteg?t=00h59m33s)

[whoops](https://youtu.be/Ctfuh8tIteg?t=00h59m34s)

[right there](https://youtu.be/Ctfuh8tIteg?t=00h59m36s)

[that button the little](https://youtu.be/Ctfuh8tIteg?t=00h59m37s)

[right](https://youtu.be/Ctfuh8tIteg?t=00h59m40s)

[so](https://youtu.be/Ctfuh8tIteg?t=00h59m41s)

[they'll bounce you automatically and](https://youtu.be/Ctfuh8tIteg?t=00h59m42s)

[jump you to whatever tab you have so if](https://youtu.be/Ctfuh8tIteg?t=00h59m44s)

[you haven't seen that very useful](https://youtu.be/Ctfuh8tIteg?t=00h59m47s)

[function](https://youtu.be/Ctfuh8tIteg?t=00h59m48s)

[very very useful function and apparently](https://youtu.be/Ctfuh8tIteg?t=00h59m49s)

[the hotkey is control left Square brace](https://youtu.be/Ctfuh8tIteg?t=00h59m52s)

[s](https://youtu.be/Ctfuh8tIteg?t=00h59m55s)

[for for those of you who can do that](https://youtu.be/Ctfuh8tIteg?t=00h59m57s)

[maneuver with your fingers](https://youtu.be/Ctfuh8tIteg?t=01h00m00s)

[um I just click the mouse some people](https://youtu.be/Ctfuh8tIteg?t=01h00m02s)

[don't like that idea because you know](https://youtu.be/Ctfuh8tIteg?t=01h00m04s)

[developers hands on the keyboard yada](https://youtu.be/Ctfuh8tIteg?t=01h00m06s)

[yada but](https://youtu.be/Ctfuh8tIteg?t=01h00m08s)

[it's okay it's okay to use a mouse it](https://youtu.be/Ctfuh8tIteg?t=01h00m09s)

[won't it won't](https://youtu.be/Ctfuh8tIteg?t=01h00m12s)

[it won't bite yeah it's a very it's a](https://youtu.be/Ctfuh8tIteg?t=01h00m13s)

[very simple hotkey](https://youtu.be/Ctfuh8tIteg?t=01h00m16s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h00m17s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h00m19s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=01h00m19s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h00m21s)

[sorry](https://youtu.be/Ctfuh8tIteg?t=01h00m25s)

[occasionally I really should turn](https://youtu.be/Ctfuh8tIteg?t=01h00m28s)

[everything off but occasionally I get](https://youtu.be/Ctfuh8tIteg?t=01h00m31s)

[emails and notifications that come in](https://youtu.be/Ctfuh8tIteg?t=01h00m32s)

[Midstream and I just kind of have to](https://youtu.be/Ctfuh8tIteg?t=01h00m34s)

[briefly glance at them because they have](https://youtu.be/Ctfuh8tIteg?t=01h00m36s)

[titles that are terrifying](https://youtu.be/Ctfuh8tIteg?t=01h00m38s)

[this one was less terrifying once I](https://youtu.be/Ctfuh8tIteg?t=01h00m40s)

[looked closer okay so grid splitter](https://youtu.be/Ctfuh8tIteg?t=01h00m42s)

[seven](https://youtu.be/Ctfuh8tIteg?t=01h00m44s)

[and actually this one is](https://youtu.be/Ctfuh8tIteg?t=01h00m46s)

[oh this is slightly different](https://youtu.be/Ctfuh8tIteg?t=01h00m49s)

[let's look at 13. what's what's going on](https://youtu.be/Ctfuh8tIteg?t=01h00m53s)

[here](https://youtu.be/Ctfuh8tIteg?t=01h00m55s)

[so this is setting the background](https://youtu.be/Ctfuh8tIteg?t=01h00m57s)

[what's going on here okay one we gotta](https://youtu.be/Ctfuh8tIteg?t=01h01m00s)

[split these up what the heck is going on](https://youtu.be/Ctfuh8tIteg?t=01h01m02s)

[here](https://youtu.be/Ctfuh8tIteg?t=01h01m04s)

[tarot design splitter preview](https://youtu.be/Ctfuh8tIteg?t=01h01m05s)

[got it okay so for those people](https://youtu.be/Ctfuh8tIteg?t=01h01m12s)

[unfamiliar with it the grid splitter](https://youtu.be/Ctfuh8tIteg?t=01h01m15s)

[control is the one that is often not](https://youtu.be/Ctfuh8tIteg?t=01h01m17s)

[really visible to a lot of people](https://youtu.be/Ctfuh8tIteg?t=01h01m20s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h01m23s)

[it's when you're for example this little](https://youtu.be/Ctfuh8tIteg?t=01h01m23s)

[guy right here is a grid splitter all](https://youtu.be/Ctfuh8tIteg?t=01h01m27s)

[right you can see I'm kind of going back](https://youtu.be/Ctfuh8tIteg?t=01h01m29s)

[and forth a little bit](https://youtu.be/Ctfuh8tIteg?t=01h01m30s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h01m32s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h01m34s)

[yeah uh what was the title uh Ms drops](https://youtu.be/Ctfuh8tIteg?t=01h01m37s)

[WPBF in favor of new Hawaii island that](https://youtu.be/Ctfuh8tIteg?t=01h01m41s)

[it built for the purpose of calling uwp](https://youtu.be/Ctfuh8tIteg?t=01h01m44s)

[2.0](https://youtu.be/Ctfuh8tIteg?t=01h01m46s)

[.net Maui and yes that's a that's a](https://youtu.be/Ctfuh8tIteg?t=01h01m48s)

[great description it is once again](https://youtu.be/Ctfuh8tIteg?t=01h01m51s)

[claiming that it will kill off WPF](https://youtu.be/Ctfuh8tIteg?t=01h01m54s)

[um but I usually tell people I will](https://youtu.be/Ctfuh8tIteg?t=01h01m58s)

[believe it when it happens because](https://youtu.be/Ctfuh8tIteg?t=01h02m00s)

[there have been](https://youtu.be/Ctfuh8tIteg?t=01h02m03s)

[several attempts for Microsoft saying oh](https://youtu.be/Ctfuh8tIteg?t=01h02m05s)

[this latest technology is going to be](https://youtu.be/Ctfuh8tIteg?t=01h02m07s)

[the one that finally kills WPF and](https://youtu.be/Ctfuh8tIteg?t=01h02m09s)

[windows forms](https://youtu.be/Ctfuh8tIteg?t=01h02m10s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h02m12s)

[yeah I don't think they're gonna die the](https://youtu.be/Ctfuh8tIteg?t=01h02m13s)

[other thing that is keeping WPF alive](https://youtu.be/Ctfuh8tIteg?t=01h02m15s)

[it's Visual Studio itself](https://youtu.be/Ctfuh8tIteg?t=01h02m18s)

[large portions of Visual Studio are WPF](https://youtu.be/Ctfuh8tIteg?t=01h02m21s)

[which here for anybody who hasn't seen](https://youtu.be/Ctfuh8tIteg?t=01h02m25s)

[this this fun trick](https://youtu.be/Ctfuh8tIteg?t=01h02m28s)

[um I'll demonstrate](https://youtu.be/Ctfuh8tIteg?t=01h02m30s)

[there's I I will often if you so one if](https://youtu.be/Ctfuh8tIteg?t=01h02m33s)

[you find bugs in Visual Studio you](https://youtu.be/Ctfuh8tIteg?t=01h02m36s)

[should absolutely come over here to this](https://youtu.be/Ctfuh8tIteg?t=01h02m38s)

[little report button and report them I](https://youtu.be/Ctfuh8tIteg?t=01h02m41s)

[actually went through my list the other](https://youtu.be/Ctfuh8tIteg?t=01h02m44s)

[day Microsoft has actually fixed the](https://youtu.be/Ctfuh8tIteg?t=01h02m45s)

[vast majority of the issues I've](https://youtu.be/Ctfuh8tIteg?t=01h02m48s)

[reported which a lot of my issues that I](https://youtu.be/Ctfuh8tIteg?t=01h02m49s)

[report come around from the fact that I](https://youtu.be/Ctfuh8tIteg?t=01h02m51s)

[leave my font size bumped up a little a](https://youtu.be/Ctfuh8tIteg?t=01h02m53s)

[few points I think it defaults to 14 and](https://youtu.be/Ctfuh8tIteg?t=01h02m55s)

[I run it at 16 or something just because](https://youtu.be/Ctfuh8tIteg?t=01h02m57s)

[I do so much streaming and presenting](https://youtu.be/Ctfuh8tIteg?t=01h03m00s)

[I've just gotten used to the fonts all](https://youtu.be/Ctfuh8tIteg?t=01h03m02s)

[being a little bigger I'm not actually](https://youtu.be/Ctfuh8tIteg?t=01h03m04s)

[as blind as I may appear](https://youtu.be/Ctfuh8tIteg?t=01h03m05s)

[or maybe I am and it's just helpful both](https://youtu.be/Ctfuh8tIteg?t=01h03m07s)

[ways](https://youtu.be/Ctfuh8tIteg?t=01h03m09s)

[um but one of the things that I will do](https://youtu.be/Ctfuh8tIteg?t=01h03m11s)

[when I report bugs is I'll literally](https://youtu.be/Ctfuh8tIteg?t=01h03m14s)

[come in here](https://youtu.be/Ctfuh8tIteg?t=01h03m15s)

[um and uh just actually even Snoop it](https://youtu.be/Ctfuh8tIteg?t=01h03m17s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h03m22s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h03m23s)

[uh yeah sure we can go multiple app](https://youtu.be/Ctfuh8tIteg?t=01h03m26s)

[domains so yeah so for reference if it's](https://youtu.be/Ctfuh8tIteg?t=01h03m27s)

[not obvious Visual Studio is actually](https://youtu.be/Ctfuh8tIteg?t=01h03m30s)

[somewhat advanced](https://youtu.be/Ctfuh8tIteg?t=01h03m31s)

[little piece of software that you can](https://youtu.be/Ctfuh8tIteg?t=01h03m33s)

[come in here](https://youtu.be/Ctfuh8tIteg?t=01h03m37s)

[um and actually Snoop Visual Studio like](https://youtu.be/Ctfuh8tIteg?t=01h03m39s)

[this is a bug that they elected to not](https://youtu.be/Ctfuh8tIteg?t=01h03m41s)

[fix and it bothers me it bothers me](https://youtu.be/Ctfuh8tIteg?t=01h03m43s)

[because I literally found the assembly](https://youtu.be/Ctfuh8tIteg?t=01h03m46s)

[and the xaml file](https://youtu.be/Ctfuh8tIteg?t=01h03m48s)

[in my case I was looking at the the](https://youtu.be/Ctfuh8tIteg?t=01h03m51s)

[decabile but I showed them where the](https://youtu.be/Ctfuh8tIteg?t=01h03m52s)

[change needed to be made right because](https://youtu.be/Ctfuh8tIteg?t=01h03m55s)

[see this checkbox](https://youtu.be/Ctfuh8tIteg?t=01h03m57s)

[this bothers me a great deal this](https://youtu.be/Ctfuh8tIteg?t=01h03m59s)

[checkbox is aligned to the top and the](https://youtu.be/Ctfuh8tIteg?t=01h04m01s)

[content is not it is set to stretch](https://youtu.be/Ctfuh8tIteg?t=01h04m04s)

[right this bothers me a great deal and](https://youtu.be/Ctfuh8tIteg?t=01h04m07s)

[apparently I am the only one bothered by](https://youtu.be/Ctfuh8tIteg?t=01h04m11s)

[this because I right uh](https://youtu.be/Ctfuh8tIteg?t=01h04m13s)

[uh uh vertical content alignment watch](https://youtu.be/Ctfuh8tIteg?t=01h04m19s)

[this watch this there see see](https://youtu.be/Ctfuh8tIteg?t=01h04m22s)

[okay](https://youtu.be/Ctfuh8tIteg?t=01h04m26s)

[like](https://youtu.be/Ctfuh8tIteg?t=01h04m27s)

[which one of these two text boxes looks](https://youtu.be/Ctfuh8tIteg?t=01h04m28s)

[better](https://youtu.be/Ctfuh8tIteg?t=01h04m31s)

[the one that's lined up straight or the](https://youtu.be/Ctfuh8tIteg?t=01h04m32s)

[one where everything's where the box is](https://youtu.be/Ctfuh8tIteg?t=01h04m34s)

[shoved all the way to the top](https://youtu.be/Ctfuh8tIteg?t=01h04m37s)

[I submit the center looks better](https://youtu.be/Ctfuh8tIteg?t=01h04m39s)

[so far I think that's the only Visual](https://youtu.be/Ctfuh8tIteg?t=01h04m42s)

[Studio bug that I've logged](https://youtu.be/Ctfuh8tIteg?t=01h04m44s)

[and it annoyed me because I found the](https://youtu.be/Ctfuh8tIteg?t=01h04m46s)

[assembly found the line it was like this](https://youtu.be/Ctfuh8tIteg?t=01h04m48s)

[is where the style is being set change](https://youtu.be/Ctfuh8tIteg?t=01h04m50s)

[this thing here I cannot make it easier](https://youtu.be/Ctfuh8tIteg?t=01h04m53s)

[I've joked with people that I need to](https://youtu.be/Ctfuh8tIteg?t=01h04m56s)

[get a job on the visual studio team just](https://youtu.be/Ctfuh8tIteg?t=01h04m58s)

[long enough for me to fix all my bugs](https://youtu.be/Ctfuh8tIteg?t=01h05m00s)

[and quit](https://youtu.be/Ctfuh8tIteg?t=01h05m01s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h05m04s)

[uh do you know what technology word or](https://youtu.be/Ctfuh8tIteg?t=01h05m07s)

[Excel is written on I can't know for](https://youtu.be/Ctfuh8tIteg?t=01h05m10s)

[sure](https://youtu.be/Ctfuh8tIteg?t=01h05m12s)

[um I believe](https://youtu.be/Ctfuh8tIteg?t=01h05m13s)

[and take this with a grain of salt I](https://youtu.be/Ctfuh8tIteg?t=01h05m16s)

[believe a lot of The Office products are](https://youtu.be/Ctfuh8tIteg?t=01h05m19s)

[react native](https://youtu.be/Ctfuh8tIteg?t=01h05m21s)

[think but the the thing with a lot of](https://youtu.be/Ctfuh8tIteg?t=01h05m25s)

[the office stuff is it's been Rewritten](https://youtu.be/Ctfuh8tIteg?t=01h05m28s)

[so many times I don't know if there's an](https://youtu.be/Ctfuh8tIteg?t=01h05m30s)

[easy way to say](https://youtu.be/Ctfuh8tIteg?t=01h05m33s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h05m36s)

[uh where is the I wanna I just wanna](https://youtu.be/Ctfuh8tIteg?t=01h05m39s)

[look at the teach](https://youtu.be/Ctfuh8tIteg?t=01h05m42s)

[how do I look at properties](https://youtu.be/Ctfuh8tIteg?t=01h05m47s)

[there I just want to know where the heck](https://youtu.be/Ctfuh8tIteg?t=01h05m51s)

[you are located open file location](https://youtu.be/Ctfuh8tIteg?t=01h05m53s)

[because sometimes you can you can kind](https://youtu.be/Ctfuh8tIteg?t=01h05m55s)

[of grock a little bit by the assemblies](https://youtu.be/Ctfuh8tIteg?t=01h05m57s)

[that are in here](https://youtu.be/Ctfuh8tIteg?t=01h06m00s)

[so whatever's under the hood like that's](https://youtu.be/Ctfuh8tIteg?t=01h06m01s)

[the visual C plus runtime](https://youtu.be/Ctfuh8tIteg?t=01h06m04s)

[that doesn't tell me a lot](https://youtu.be/Ctfuh8tIteg?t=01h06m06s)

[tell me runtime.dll that's interesting](https://youtu.be/Ctfuh8tIteg?t=01h06m09s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h06m13s)

[just looking to see because sometimes](https://youtu.be/Ctfuh8tIteg?t=01h06m20s)

[there's some obvious Telltale dlls that](https://youtu.be/Ctfuh8tIteg?t=01h06m21s)

[will give you very strong hints as to](https://youtu.be/Ctfuh8tIteg?t=01h06m24s)

[what things were built with](https://youtu.be/Ctfuh8tIteg?t=01h06m26s)

[I think the front end is react native](https://youtu.be/Ctfuh8tIteg?t=01h06m31s)

[but again I](https://youtu.be/Ctfuh8tIteg?t=01h06m33s)

[GK word](https://youtu.be/Ctfuh8tIteg?t=01h06m37s)

[but I don't know enough about their](https://youtu.be/Ctfuh8tIteg?t=01h06m42s)

[compiled output because so here's the](https://youtu.be/Ctfuh8tIteg?t=01h06m46s)

[other thing that I'm noticing though](https://youtu.be/Ctfuh8tIteg?t=01h06m48s)

[that these ones here look to me to be](https://youtu.be/Ctfuh8tIteg?t=01h06m49s)

[the](https://youtu.be/Ctfuh8tIteg?t=01h06m53s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h06m54s)

[what is it win UI runtime assemblies or](https://youtu.be/Ctfuh8tIteg?t=01h06m56s)

[at least these are the uh and this is](https://youtu.be/Ctfuh8tIteg?t=01h07m00s)

[where things kind of get a little weird](https://youtu.be/Ctfuh8tIteg?t=01h07m02s)

[right is just like how in C sharp we can](https://youtu.be/Ctfuh8tIteg?t=01h07m04s)

[reference unmanaged assemblies and](https://youtu.be/Ctfuh8tIteg?t=01h07m07s)

[leverage them](https://youtu.be/Ctfuh8tIteg?t=01h07m09s)

[that can happen with other languages too](https://youtu.be/Ctfuh8tIteg?t=01h07m11s)

[so this this looks to me to be the](https://youtu.be/Ctfuh8tIteg?t=01h07m13s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h07m17s)

[the the window the windows SDK which is](https://youtu.be/Ctfuh8tIteg?t=01h07m18s)

[what like uh win UI and whatnot is built](https://youtu.be/Ctfuh8tIteg?t=01h07m22s)

[on](https://youtu.be/Ctfuh8tIteg?t=01h07m25s)

[but](https://youtu.be/Ctfuh8tIteg?t=01h07m25s)

[yeah I think at one point in time I read](https://youtu.be/Ctfuh8tIteg?t=01h07m27s)

[a blog post where somebody was saying](https://youtu.be/Ctfuh8tIteg?t=01h07m30s)

[that it was react native was the actual](https://youtu.be/Ctfuh8tIteg?t=01h07m32s)

[front end on top of it but again it can](https://youtu.be/Ctfuh8tIteg?t=01h07m35s)

[be shelling out to all kinds of things](https://youtu.be/Ctfuh8tIteg?t=01h07m37s)

[um it was one of those blog posts that](https://youtu.be/Ctfuh8tIteg?t=01h07m40s)

[was make trying to make Arguments for](https://youtu.be/Ctfuh8tIteg?t=01h07m42s)

[you know which what UI technology should](https://youtu.be/Ctfuh8tIteg?t=01h07m44s)

[I pick for my next app or thereabouts](https://youtu.be/Ctfuh8tIteg?t=01h07m47s)

[um okay so we want a grid splitter](https://youtu.be/Ctfuh8tIteg?t=01h07m51s)

[background brush I think and I think](https://youtu.be/Ctfuh8tIteg?t=01h07m53s)

[this is just as simple as we just need](https://youtu.be/Ctfuh8tIteg?t=01h07m56s)

[yet one more brush](https://youtu.be/Ctfuh8tIteg?t=01h07m58s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h07m59s)

[uh so we're gonna grab here](https://youtu.be/Ctfuh8tIteg?t=01h08m04s)

[uh let's see I am questioning whether I](https://youtu.be/Ctfuh8tIteg?t=01h08m07s)

[should keep the alternate keys or keep](https://youtu.be/Ctfuh8tIteg?t=01h08m10s)

[everything separate](https://youtu.be/Ctfuh8tIteg?t=01h08m11s)

[I might have to think about that I like](https://youtu.be/Ctfuh8tIteg?t=01h08m13s)

[I suspect this is why I say there's](https://youtu.be/Ctfuh8tIteg?t=01h08m14s)

[gonna probably be some um](https://youtu.be/Ctfuh8tIteg?t=01h08m16s)

[like once this merges there's probably](https://youtu.be/Ctfuh8tIteg?t=01h08m19s)

[going to be a hello why can I not enter](https://youtu.be/Ctfuh8tIteg?t=01h08m22s)

[key](https://youtu.be/Ctfuh8tIteg?t=01h08m25s)

[I can do that I can't backspace and I](https://youtu.be/Ctfuh8tIteg?t=01h08m27s)

[can't enter](https://youtu.be/Ctfuh8tIteg?t=01h08m29s)

[don't save](https://youtu.be/Ctfuh8tIteg?t=01h08m32s)

[let me edit my own file please](https://youtu.be/Ctfuh8tIteg?t=01h08m34s)

[um I I suspect that this will get merged](https://youtu.be/Ctfuh8tIteg?t=01h08m41s)

[and there may be some revamp that](https://youtu.be/Ctfuh8tIteg?t=01h08m43s)

[happens okay I don't have the ability to](https://youtu.be/Ctfuh8tIteg?t=01h08m45s)

[backspace or enter](https://youtu.be/Ctfuh8tIteg?t=01h08m47s)

[that's an interesting issue](https://youtu.be/Ctfuh8tIteg?t=01h08m49s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h08m53s)

[GPT says note](https://youtu.be/Ctfuh8tIteg?t=01h08m56s)

[well I who am I to argue with our robot](https://youtu.be/Ctfuh8tIteg?t=01h08m59s)

[overlords okay so backspace and enter](https://youtu.be/Ctfuh8tIteg?t=01h09m02s)

[work](https://youtu.be/Ctfuh8tIteg?t=01h09m04s)

[just not in Visual Studio](https://youtu.be/Ctfuh8tIteg?t=01h09m06s)

[okay I have no idea how I've gotten](https://youtu.be/Ctfuh8tIteg?t=01h09m09s)

[myself into the state we're just gonna](https://youtu.be/Ctfuh8tIteg?t=01h09m10s)

[reboot it because for whatever reason](https://youtu.be/Ctfuh8tIteg?t=01h09m12s)

[it no work](https://youtu.be/Ctfuh8tIteg?t=01h09m16s)

[there are times where when you see an](https://youtu.be/Ctfuh8tIteg?t=01h09m22s)

[app misbehave](https://youtu.be/Ctfuh8tIteg?t=01h09m25s)

[my default setting is to immediately](https://youtu.be/Ctfuh8tIteg?t=01h09m27s)

[think there must be some code in the](https://youtu.be/Ctfuh8tIteg?t=01h09m29s)

[application somewhere that is able to](https://youtu.be/Ctfuh8tIteg?t=01h09m31s)

[trigger this Behavior now](https://youtu.be/Ctfuh8tIteg?t=01h09m34s)

[possibly completely unintentional right](https://youtu.be/Ctfuh8tIteg?t=01h09m36s)

[or you know bug or whatever right but](https://youtu.be/Ctfuh8tIteg?t=01h09m39s)

[there is some bit of code that is able](https://youtu.be/Ctfuh8tIteg?t=01h09m43s)

[to trigger](https://youtu.be/Ctfuh8tIteg?t=01h09m44s)

[that obnoxious behavior that we're](https://youtu.be/Ctfuh8tIteg?t=01h09m46s)

[seeing](https://youtu.be/Ctfuh8tIteg?t=01h09m48s)

[and it just sometimes it blows my mind](https://youtu.be/Ctfuh8tIteg?t=01h09m49s)

[that it's like wait](https://youtu.be/Ctfuh8tIteg?t=01h09m52s)

[what kind of Waddy piece of garbage code](https://youtu.be/Ctfuh8tIteg?t=01h09m55s)

[is in there](https://youtu.be/Ctfuh8tIteg?t=01h09m58s)

[uh so we're gonna do](https://youtu.be/Ctfuh8tIteg?t=01h10m00s)

[see material design brush grid splitter](https://youtu.be/Ctfuh8tIteg?t=01h10m02s)

[I think we just call it background and](https://youtu.be/Ctfuh8tIteg?t=01h10m05s)

[call it a day](https://youtu.be/Ctfuh8tIteg?t=01h10m06s)

[all right I think that's](https://youtu.be/Ctfuh8tIteg?t=01h10m08s)

[I think that's all we do](https://youtu.be/Ctfuh8tIteg?t=01h10m10s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h10m13s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h10m14s)

[and then I'm going to remember to](https://youtu.be/Ctfuh8tIteg?t=01h10m20s)

[rebuild](https://youtu.be/Ctfuh8tIteg?t=01h10m21s)

[I'm going to generate](https://youtu.be/Ctfuh8tIteg?t=01h10m25s)

[and](https://youtu.be/Ctfuh8tIteg?t=01h10m29s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=01h10m30s)

[bippity boppity](https://youtu.be/Ctfuh8tIteg?t=01h10m32s)

[view changes lots of files great yeah](https://youtu.be/Ctfuh8tIteg?t=01h10m34s)

[like the fact that it wait](https://youtu.be/Ctfuh8tIteg?t=01h10m38s)

[hang on](https://youtu.be/Ctfuh8tIteg?t=01h10m40s)

[I already have a grid spitter background](https://youtu.be/Ctfuh8tIteg?t=01h10m43s)

[my source generator is not that smart](https://youtu.be/Ctfuh8tIteg?t=01h10m47s)

[apparently](https://youtu.be/Ctfuh8tIteg?t=01h10m49s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h10m50s)

[so in reality what I should do is I](https://youtu.be/Ctfuh8tIteg?t=01h10m52s)

[should burn this to the ground it's](https://youtu.be/Ctfuh8tIteg?t=01h10m54s)

[probably set in an alternate key](https://youtu.be/Ctfuh8tIteg?t=01h10m56s)

[somewhere and it just did get applied](https://youtu.be/Ctfuh8tIteg?t=01h10m58s)

[here](https://youtu.be/Ctfuh8tIteg?t=01h11m00s)

[so if this already exists where else is](https://youtu.be/Ctfuh8tIteg?t=01h11m02s)

[it being oh it's being used up here hang](https://youtu.be/Ctfuh8tIteg?t=01h11m04s)

[on](https://youtu.be/Ctfuh8tIteg?t=01h11m06s)

[hang on hang on we gotta we got a bit of](https://youtu.be/Ctfuh8tIteg?t=01h11m11s)

[an issue here](https://youtu.be/Ctfuh8tIteg?t=01h11m13s)

[okay so here's what we do we come in](https://youtu.be/Ctfuh8tIteg?t=01h11m16s)

[here and we go trash the whole thing](https://youtu.be/Ctfuh8tIteg?t=01h11m17s)

[start over](https://youtu.be/Ctfuh8tIteg?t=01h11m19s)

[okay where is this guy defined and what](https://youtu.be/Ctfuh8tIteg?t=01h11m20s)

[is the difference between that](https://youtu.be/Ctfuh8tIteg?t=01h11m23s)

[background](https://youtu.be/Ctfuh8tIteg?t=01h11m25s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h11m27s)

[uh C D E F G H oh so I just put mine in](https://youtu.be/Ctfuh8tIteg?t=01h11m32s)

[the wrong place](https://youtu.be/Ctfuh8tIteg?t=01h11m36s)

[so there is already a background](https://youtu.be/Ctfuh8tIteg?t=01h11m38s)

[oh so this should actually probably be](https://youtu.be/Ctfuh8tIteg?t=01h11m42s)

[the difference between preview](https://youtu.be/Ctfuh8tIteg?t=01h11m44s)

[background and background](https://youtu.be/Ctfuh8tIteg?t=01h11m45s)

[that so this should probably be](https://youtu.be/Ctfuh8tIteg?t=01h11m49s)

[review background right and this goes to](https://youtu.be/Ctfuh8tIteg?t=01h11m52s)

[be](https://youtu.be/Ctfuh8tIteg?t=01h11m55s)

[a preview background](https://youtu.be/Ctfuh8tIteg?t=01h11m56s)

[and then this we should](https://youtu.be/Ctfuh8tIteg?t=01h11m58s)

[do the little pacement over here Boop](https://youtu.be/Ctfuh8tIteg?t=01h12m00s)

[and this should be](https://youtu.be/Ctfuh8tIteg?t=01h12m03s)

[just background](https://youtu.be/Ctfuh8tIteg?t=01h12m05s)

[because that will make more sense uh](https://youtu.be/Ctfuh8tIteg?t=01h12m09s)

[that](https://youtu.be/Ctfuh8tIteg?t=01h12m15s)

[then we'll Regen](https://youtu.be/Ctfuh8tIteg?t=01h12m17s)

[and](https://youtu.be/Ctfuh8tIteg?t=01h12m21s)

[this guy then becomes this guy here](https://youtu.be/Ctfuh8tIteg?t=01h12m25s)

[there we go uh let's double check this](https://youtu.be/Ctfuh8tIteg?t=01h12m32s)

[there's nothing else in here I need to](https://youtu.be/Ctfuh8tIteg?t=01h12m34s)

[be concerned with these inline](https://youtu.be/Ctfuh8tIteg?t=01h12m36s)

[storyboards always make me twitch but](https://youtu.be/Ctfuh8tIteg?t=01h12m38s)

[whatever](https://youtu.be/Ctfuh8tIteg?t=01h12m40s)

[why are we doing static resource here](https://youtu.be/Ctfuh8tIteg?t=01h12m45s)

[oh is it so we can do a stop storyboard](https://youtu.be/Ctfuh8tIteg?t=01h12m49s)

[later I bet you there's a stop](https://youtu.be/Ctfuh8tIteg?t=01h12m51s)

[storyboard](https://youtu.be/Ctfuh8tIteg?t=01h12m52s)

[I bet you there's a stop storyboard or](https://youtu.be/Ctfuh8tIteg?t=01h13m00s)

[there was an intention there was a](https://youtu.be/Ctfuh8tIteg?t=01h13m02s)

[thought of doing it at one point](https://youtu.be/Ctfuh8tIteg?t=01h13m04s)

[okay](https://youtu.be/Ctfuh8tIteg?t=01h13m06s)

[uh that should](https://youtu.be/Ctfuh8tIteg?t=01h13m08s)

[oh](https://youtu.be/Ctfuh8tIteg?t=01h13m11s)

[did I rebuild already](https://youtu.be/Ctfuh8tIteg?t=01h13m12s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h13m14s)

[uh so uh let's see I'm new to publishing](https://youtu.be/Ctfuh8tIteg?t=01h13m17s)

[stuff and Windows desktop apps I want to](https://youtu.be/Ctfuh8tIteg?t=01h13m20s)

[create a signed package is it true I'm](https://youtu.be/Ctfuh8tIteg?t=01h13m22s)

[supposed to buy](https://youtu.be/Ctfuh8tIteg?t=01h13m23s)

[one of these expensive code signing](https://youtu.be/Ctfuh8tIteg?t=01h13m25s)

[certs or is that a no cost workaround](https://youtu.be/Ctfuh8tIteg?t=01h13m27s)

[you you have landed on on a very very](https://youtu.be/Ctfuh8tIteg?t=01h13m31s)

[very very very very unfortunate](https://youtu.be/Ctfuh8tIteg?t=01h13m35s)

[situation](https://youtu.be/Ctfuh8tIteg?t=01h13m38s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h13m41s)

[so there are](https://youtu.be/Ctfuh8tIteg?t=01h13m42s)

[there's both a yes and a no answer to](https://youtu.be/Ctfuh8tIteg?t=01h13m45s)

[that and it depends on on how you want](https://youtu.be/Ctfuh8tIteg?t=01h13m48s)

[to do your publishing so I think](https://youtu.be/Ctfuh8tIteg?t=01h13m51s)

[there are](https://youtu.be/Ctfuh8tIteg?t=01h13m53s)

[I think there's basically three big](https://youtu.be/Ctfuh8tIteg?t=01h13m57s)

[Alternatives uh option one is basically](https://youtu.be/Ctfuh8tIteg?t=01h13m59s)

[you do some work to generate an](https://youtu.be/Ctfuh8tIteg?t=01h14m03s)

[installer](https://youtu.be/Ctfuh8tIteg?t=01h14m06s)

[um the I would bucket things like](https://youtu.be/Ctfuh8tIteg?t=01h14m07s)

[squirrel Wicks you know there's a bunch](https://youtu.be/Ctfuh8tIteg?t=01h14m10s)

[of Technologies out there that are all](https://youtu.be/Ctfuh8tIteg?t=01h14m13s)

[around make me an installer thing](https://youtu.be/Ctfuh8tIteg?t=01h14m15s)

[there is the Windows store which kind of](https://youtu.be/Ctfuh8tIteg?t=01h14m17s)

[kind of works around this problem](https://youtu.be/Ctfuh8tIteg?t=01h14m23s)

[because then](https://youtu.be/Ctfuh8tIteg?t=01h14m24s)

[um you are effectively validating to the](https://youtu.be/Ctfuh8tIteg?t=01h14m27s)

[store and then it does the the end](https://youtu.be/Ctfuh8tIteg?t=01h14m30s)

[signing of it so it validates the](https://youtu.be/Ctfuh8tIteg?t=01h14m32s)

[authenticity of it as it were](https://youtu.be/Ctfuh8tIteg?t=01h14m35s)

[um and then there's kind of a middle](https://youtu.be/Ctfuh8tIteg?t=01h14m37s)

[ground with](https://youtu.be/Ctfuh8tIteg?t=01h14m39s)

[and maybe I should bucket click I was](https://youtu.be/Ctfuh8tIteg?t=01h14m40s)

[gonna put click once in its own bucket](https://youtu.be/Ctfuh8tIteg?t=01h14m42s)

[but](https://youtu.be/Ctfuh8tIteg?t=01h14m44s)

[you can kind of put click once by itself](https://youtu.be/Ctfuh8tIteg?t=01h14m46s)

[the short version is](https://youtu.be/Ctfuh8tIteg?t=01h14m48s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h14m51s)

[in an ideal situation](https://youtu.be/Ctfuh8tIteg?t=01h14m52s)

[buying a code signing certificate from a](https://youtu.be/Ctfuh8tIteg?t=01h14m54s)

[trusted CA is the](https://youtu.be/Ctfuh8tIteg?t=01h14m57s)

[right way to do things](https://youtu.be/Ctfuh8tIteg?t=01h15m00s)

[um that has been a situation that has](https://youtu.be/Ctfuh8tIteg?t=01h15m03s)

[repeatedly bothered me because it](https://youtu.be/Ctfuh8tIteg?t=01h15m06s)

[it is very expensive and people who do](https://youtu.be/Ctfuh8tIteg?t=01h15m09s)

[this as hobbyist or whatnot that is a](https://youtu.be/Ctfuh8tIteg?t=01h15m12s)

[very large chunk of change to swallow](https://youtu.be/Ctfuh8tIteg?t=01h15m15s)

[because I think it's a few hundred](https://youtu.be/Ctfuh8tIteg?t=01h15m17s)

[dollars](https://youtu.be/Ctfuh8tIteg?t=01h15m19s)

[to start](https://youtu.be/Ctfuh8tIteg?t=01h15m20s)

[it's been a while since I've looked](https://youtu.be/Ctfuh8tIteg?t=01h15m22s)

[don't quote me on that but they are they](https://youtu.be/Ctfuh8tIteg?t=01h15m23s)

[are not cheap](https://youtu.be/Ctfuh8tIteg?t=01h15m25s)

[um but they come with the idea that they](https://youtu.be/Ctfuh8tIteg?t=01h15m27s)

[are signed by a trusted CA](https://youtu.be/Ctfuh8tIteg?t=01h15m29s)

[uh which then allows](https://youtu.be/Ctfuh8tIteg?t=01h15m32s)

[um a lot of easy bypass for things like](https://youtu.be/Ctfuh8tIteg?t=01h15m36s)

[UAC prompts even with that it's](https://youtu.be/Ctfuh8tIteg?t=01h15m39s)

[important to understand that just being](https://youtu.be/Ctfuh8tIteg?t=01h15m42s)

[signed with a trusted certificate](https://youtu.be/Ctfuh8tIteg?t=01h15m44s)

[doesn't fully get you out of the](https://youtu.be/Ctfuh8tIteg?t=01h15m46s)

[uh the warning that a user may get that](https://youtu.be/Ctfuh8tIteg?t=01h15m49s)

[hey we don't know if this app is secure](https://youtu.be/Ctfuh8tIteg?t=01h15m52s)

[or not and the reason is because the the](https://youtu.be/Ctfuh8tIteg?t=01h15m55s)

[logic about whether a user sees that](https://youtu.be/Ctfuh8tIteg?t=01h15m58s)

[warning isn't just is this uh package](https://youtu.be/Ctfuh8tIteg?t=01h16m00s)

[signed or not the](https://youtu.be/Ctfuh8tIteg?t=01h16m04s)

[um it it comes from the idea of is the](https://youtu.be/Ctfuh8tIteg?t=01h16m07s)

[package signed from a trusted publisher](https://youtu.be/Ctfuh8tIteg?t=01h16m10s)

[and The Trusted publisher comes from](https://youtu.be/Ctfuh8tIteg?t=01h16m13s)

[building up reputation so when users](https://youtu.be/Ctfuh8tIteg?t=01h16m15s)

[install apps that are signed with a](https://youtu.be/Ctfuh8tIteg?t=01h16m18s)

[particular certificate Microsoft tracks](https://youtu.be/Ctfuh8tIteg?t=01h16m20s)

[that](https://youtu.be/Ctfuh8tIteg?t=01h16m22s)

[and if your certificate is known to be](https://youtu.be/Ctfuh8tIteg?t=01h16m23s)

[used on apps that are installed and](https://youtu.be/Ctfuh8tIteg?t=01h16m25s)

[there it isn't found to like contain](https://youtu.be/Ctfuh8tIteg?t=01h16m27s)

[malware or whatnot you build rep and](https://youtu.be/Ctfuh8tIteg?t=01h16m29s)

[then eventually that dialogue goes away](https://youtu.be/Ctfuh8tIteg?t=01h16m32s)

[but it takes time and users in order to](https://youtu.be/Ctfuh8tIteg?t=01h16m34s)

[trigger that case](https://youtu.be/Ctfuh8tIteg?t=01h16m38s)

[and it's not something that just buying](https://youtu.be/Ctfuh8tIteg?t=01h16m39s)

[a cert gets you out of](https://youtu.be/Ctfuh8tIteg?t=01h16m41s)

[the other thing that you can do is](https://youtu.be/Ctfuh8tIteg?t=01h16m43s)

[you can do a self-signed cert and just](https://youtu.be/Ctfuh8tIteg?t=01h16m46s)

[accept the fact that users are going to](https://youtu.be/Ctfuh8tIteg?t=01h16m49s)

[see that prompt](https://youtu.be/Ctfuh8tIteg?t=01h16m52s)

[and for a lot of like hobbyist level](https://youtu.be/Ctfuh8tIteg?t=01h16m54s)

[stuff that's probably good enough](https://youtu.be/Ctfuh8tIteg?t=01h16m57s)

[um in terms of of signing it where they](https://youtu.be/Ctfuh8tIteg?t=01h17m01s)

[get the little you know hey they have to](https://youtu.be/Ctfuh8tIteg?t=01h17m04s)

[hit I'm trying to remember what the name](https://youtu.be/Ctfuh8tIteg?t=01h17m06s)

[of the button is is it like](https://youtu.be/Ctfuh8tIteg?t=01h17m07s)

[they get the warning that says this is](https://youtu.be/Ctfuh8tIteg?t=01h17m09s)

[an untrusted app or whatever the prompt](https://youtu.be/Ctfuh8tIteg?t=01h17m11s)

[is and the the default button is](https://youtu.be/Ctfuh8tIteg?t=01h17m14s)

[canceled because Microsoft's like I](https://youtu.be/Ctfuh8tIteg?t=01h17m16s)

[don't want to I don't want to scare them](https://youtu.be/Ctfuh8tIteg?t=01h17m17s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h17m20s)

[and so you can sign with a self-signed](https://youtu.be/Ctfuh8tIteg?t=01h17m21s)

[cert and that actually comes up in the](https://youtu.be/Ctfuh8tIteg?t=01h17m24s)

[Microsoft docs I think around like msix](https://youtu.be/Ctfuh8tIteg?t=01h17m26s)

[docs they'll talk about the self-signed](https://youtu.be/Ctfuh8tIteg?t=01h17m29s)

[cert path and they'll comment that the](https://youtu.be/Ctfuh8tIteg?t=01h17m32s)

[self-signed cert is](https://youtu.be/Ctfuh8tIteg?t=01h17m34s)

[for like debug and testing scenarios](https://youtu.be/Ctfuh8tIteg?t=01h17m36s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h17m41s)

[uh is there not also a mark of the web](https://youtu.be/Ctfuh8tIteg?t=01h17m43s)

[that influences The Prompt is shown that](https://youtu.be/Ctfuh8tIteg?t=01h17m45s)

[could be a thing that goes into it so](https://youtu.be/Ctfuh8tIteg?t=01h17m48s)

[the actual uh Mark of the web that](https://youtu.be/Ctfuh8tIteg?t=01h17m50s)

[usually shows up](https://youtu.be/Ctfuh8tIteg?t=01h17m53s)

[um is actually added by web browsers](https://youtu.be/Ctfuh8tIteg?t=01h17m55s)

[when a download occurs so](https://youtu.be/Ctfuh8tIteg?t=01h17m58s)

[um when you like download a zip file or](https://youtu.be/Ctfuh8tIteg?t=01h18m01s)

[similar uh or even like a](https://youtu.be/Ctfuh8tIteg?t=01h18m04s)

[um an Office document the you'll get the](https://youtu.be/Ctfuh8tIteg?t=01h18m07s)

[here I'll just uh](https://youtu.be/Ctfuh8tIteg?t=01h18m10s)

[open containing folder this will work](https://youtu.be/Ctfuh8tIteg?t=01h18m13s)

[right so if you look at the properties](https://youtu.be/Ctfuh8tIteg?t=01h18m14s)

[on a](https://youtu.be/Ctfuh8tIteg?t=01h18m16s)

[on a file there'll be a little thing](https://youtu.be/Ctfuh8tIteg?t=01h18m18s)

[down here](https://youtu.be/Ctfuh8tIteg?t=01h18m20s)

[um that says something like untrusted](https://youtu.be/Ctfuh8tIteg?t=01h18m22s)

[file and there's like an unblock button](https://youtu.be/Ctfuh8tIteg?t=01h18m23s)

[um what actually is occurring there is](https://youtu.be/Ctfuh8tIteg?t=01h18m27s)

[when the browser downloads one of those](https://youtu.be/Ctfuh8tIteg?t=01h18m30s)

[files](https://youtu.be/Ctfuh8tIteg?t=01h18m32s)

[um on Windows Windows uses What's called](https://youtu.be/Ctfuh8tIteg?t=01h18m33s)

[the NTFS file system](https://youtu.be/Ctfuh8tIteg?t=01h18m35s)

[and files on the NTFS file system can](https://youtu.be/Ctfuh8tIteg?t=01h18m37s)

[have multiple streams right so we all](https://youtu.be/Ctfuh8tIteg?t=01h18m41s)

[familiar with the the apis for file.open](https://youtu.be/Ctfuh8tIteg?t=01h18m43s)

[right you get a file stream back you can](https://youtu.be/Ctfuh8tIteg?t=01h18m46s)

[interact with the stream that's the](https://youtu.be/Ctfuh8tIteg?t=01h18m48s)

[mainstream but there can be other](https://youtu.be/Ctfuh8tIteg?t=01h18m50s)

[streams on that same exact file and](https://youtu.be/Ctfuh8tIteg?t=01h18m52s)

[browsers tack in an extra stream that](https://youtu.be/Ctfuh8tIteg?t=01h18m54s)

[indicates whether it was which is where](https://youtu.be/Ctfuh8tIteg?t=01h18m58s)

[it gets that Mark of the web so you can](https://youtu.be/Ctfuh8tIteg?t=01h19m00s)

[actually Dodge getting that added to](https://youtu.be/Ctfuh8tIteg?t=01h19m02s)

[your files if a you don't download via a](https://youtu.be/Ctfuh8tIteg?t=01h19m04s)

[browser so you pull it with Powershell](https://youtu.be/Ctfuh8tIteg?t=01h19m07s)

[or whatever](https://youtu.be/Ctfuh8tIteg?t=01h19m09s)

[um or you can bypass it](https://youtu.be/Ctfuh8tIteg?t=01h19m10s)

[um by putting the file on a FAT32 file](https://youtu.be/Ctfuh8tIteg?t=01h19m13s)

[system](https://youtu.be/Ctfuh8tIteg?t=01h19m15s)

[because FAT32 is not NTFS and doesn't](https://youtu.be/Ctfuh8tIteg?t=01h19m16s)

[have the file Stream So it loses the](https://youtu.be/Ctfuh8tIteg?t=01h19m19s)

[mark of the web at that point so if you](https://youtu.be/Ctfuh8tIteg?t=01h19m21s)

[download it like a thumb drive or an SD](https://youtu.be/Ctfuh8tIteg?t=01h19m23s)

[card or something that's formatted FAT32](https://youtu.be/Ctfuh8tIteg?t=01h19m25s)

[it bypasses that same check](https://youtu.be/Ctfuh8tIteg?t=01h19m27s)

[don't abuse this](https://youtu.be/Ctfuh8tIteg?t=01h19m30s)

[for what it's worth or can you can](https://youtu.be/Ctfuh8tIteg?t=01h19m32s)

[manipulate the alternate file streams](https://youtu.be/Ctfuh8tIteg?t=01h19m34s)

[with Powershell or c-sharp or other](https://youtu.be/Ctfuh8tIteg?t=01h19m36s)

[things to have fun with them](https://youtu.be/Ctfuh8tIteg?t=01h19m38s)

[um so it so whether that Mark of the web](https://youtu.be/Ctfuh8tIteg?t=01h19m42s)

[influences the prompt](https://youtu.be/Ctfuh8tIteg?t=01h19m44s)

[I I don't know for certain I](https://youtu.be/Ctfuh8tIteg?t=01h19m48s)

[my gut reaction says is it doesn't](https://youtu.be/Ctfuh8tIteg?t=01h19m53s)

[but I could be wrong I don't know that](https://youtu.be/Ctfuh8tIteg?t=01h19m57s)

[for a fact](https://youtu.be/Ctfuh8tIteg?t=01h20m00s)

[but I as far as I'm aware Microsoft](https://youtu.be/Ctfuh8tIteg?t=01h20m02s)

[hasn't fully published like](https://youtu.be/Ctfuh8tIteg?t=01h20m05s)

[the algorithm that it goes by like they](https://youtu.be/Ctfuh8tIteg?t=01h20m07s)

[always every time I've heard them speak](https://youtu.be/Ctfuh8tIteg?t=01h20m10s)

[about it it's always more of general](https://youtu.be/Ctfuh8tIteg?t=01h20m12s)

[terms of hey these are the things that](https://youtu.be/Ctfuh8tIteg?t=01h20m14s)

[go into it and then we make a](https://youtu.be/Ctfuh8tIteg?t=01h20m16s)

[determination it's like great and how do](https://youtu.be/Ctfuh8tIteg?t=01h20m17s)

[you make the determination yes](https://youtu.be/Ctfuh8tIteg?t=01h20m19s)

[not helpful](https://youtu.be/Ctfuh8tIteg?t=01h20m22s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h20m24s)

[so it could be one of the inputs I have](https://youtu.be/Ctfuh8tIteg?t=01h20m25s)

[no idea](https://youtu.be/Ctfuh8tIteg?t=01h20m28s)

[so](https://youtu.be/Ctfuh8tIteg?t=01h20m34s)

[um that's actually one of the things so](https://youtu.be/Ctfuh8tIteg?t=01h20m36s)

[I've been playing around with my](https://youtu.be/Ctfuh8tIteg?t=01h20m38s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h20m41s)

[Scurry Day project as well okay](https://youtu.be/Ctfuh8tIteg?t=01h20m42s)

[Shameless self-promotion time](https://youtu.be/Ctfuh8tIteg?t=01h20m44s)

[close Snoop you're in my way uh let's](https://youtu.be/Ctfuh8tIteg?t=01h20m48s)

[see](https://youtu.be/Ctfuh8tIteg?t=01h20m51s)

[Okay so](https://youtu.be/Ctfuh8tIteg?t=01h20m52s)

[those people who aren't familiar with](https://youtu.be/Ctfuh8tIteg?t=01h20m54s)

[the scientific word for a squirrel it](https://youtu.be/Ctfuh8tIteg?t=01h20m55s)

[would be skirting](https://youtu.be/Ctfuh8tIteg?t=01h20m58s)

[um this is built on the idea of and](https://youtu.be/Ctfuh8tIteg?t=01h21m00s)

[actually I should oh what am I doing uh](https://youtu.be/Ctfuh8tIteg?t=01h21m03s)

[uh Cloud squirrel so depending if you](https://youtu.be/Ctfuh8tIteg?t=01h21m06s)

[haven't already settled on an installer](https://youtu.be/Ctfuh8tIteg?t=01h21m10s)

[technology](https://youtu.be/Ctfuh8tIteg?t=01h21m12s)

[uh deflux you may take a brief Gander at](https://youtu.be/Ctfuh8tIteg?t=01h21m13s)

[Cloud squirrel](https://youtu.be/Ctfuh8tIteg?t=01h21m17s)

[um because it's got a lot of nicety](https://youtu.be/Ctfuh8tIteg?t=01h21m20s)

[things in it you might also even take a](https://youtu.be/Ctfuh8tIteg?t=01h21m22s)

[run at the the V3 stuff so this is still](https://youtu.be/Ctfuh8tIteg?t=01h21m25s)

[in preview still subject to change but](https://youtu.be/Ctfuh8tIteg?t=01h21m30s)

[the V3 stuff](https://youtu.be/Ctfuh8tIteg?t=01h21m32s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h21m35s)

[at least in terms of windows](https://youtu.be/Ctfuh8tIteg?t=01h21m36s)

[is fairly stable and isn't expected to](https://youtu.be/Ctfuh8tIteg?t=01h21m39s)

[have any major changes going into it](https://youtu.be/Ctfuh8tIteg?t=01h21m42s)

[um it's the max side of things that are](https://youtu.be/Ctfuh8tIteg?t=01h21m45s)

[that's in a little bit more of a flux](https://youtu.be/Ctfuh8tIteg?t=01h21m48s)

[but if you're building a a desktop app](https://youtu.be/Ctfuh8tIteg?t=01h21m50s)

[this is](https://youtu.be/Ctfuh8tIteg?t=01h21m53s)

[um so Cloud scroll came from the regular](https://youtu.be/Ctfuh8tIteg?t=01h21m55s)

[squirrel project the problem is is the](https://youtu.be/Ctfuh8tIteg?t=01h21m59s)

[squirrel project](https://youtu.be/Ctfuh8tIteg?t=01h22m01s)

[is really slow to update](https://youtu.be/Ctfuh8tIteg?t=01h22m03s)

[you'll note September 27th 2020.](https://youtu.be/Ctfuh8tIteg?t=01h22m06s)

[right and there's been a handful of](https://youtu.be/Ctfuh8tIteg?t=01h22m10s)

[things where it's like guys there's](https://youtu.be/Ctfuh8tIteg?t=01h22m13s)

[known vulnerabilities please fix this](https://youtu.be/Ctfuh8tIteg?t=01h22m16s)

[and I think where is it there's a](https://youtu.be/Ctfuh8tIteg?t=01h22m17s)

[yeah there's a there's a comparison](https://youtu.be/Ctfuh8tIteg?t=01h22m20s)

[chart back and forth between](https://youtu.be/Ctfuh8tIteg?t=01h22m22s)

[uh what what you get and what you don't](https://youtu.be/Ctfuh8tIteg?t=01h22m25s)

[get right so](https://youtu.be/Ctfuh8tIteg?t=01h22m27s)

[Cloud squirrel is a little bit bigger](https://youtu.be/Ctfuh8tIteg?t=01h22m29s)

[but better compatibility right better](https://youtu.be/Ctfuh8tIteg?t=01h22m32s)

[comments it fixes the sharp compressed](https://youtu.be/Ctfuh8tIteg?t=01h22m35s)

[dependency it doesn't take dependencies](https://youtu.be/Ctfuh8tIteg?t=01h22m38s)

[on all this other stuff right so there's](https://youtu.be/Ctfuh8tIteg?t=01h22m39s)

[there's a lot of cleanup and if you want](https://youtu.be/Ctfuh8tIteg?t=01h22m42s)

[to compare and contrast them I I really](https://youtu.be/Ctfuh8tIteg?t=01h22m43s)

[like using this for](https://youtu.be/Ctfuh8tIteg?t=01h22m46s)

[my WPF apps my skirt Day project a](https://youtu.be/Ctfuh8tIteg?t=01h22m48s)

[assuming I can get it all the way](https://youtu.be/Ctfuh8tIteg?t=01h22m52s)

[working because I was struggling with it](https://youtu.be/Ctfuh8tIteg?t=01h22m54s)

[the other day](https://youtu.be/Ctfuh8tIteg?t=01h22m55s)

[um the whole idea with this is that it](https://youtu.be/Ctfuh8tIteg?t=01h22m57s)

[is a turnkey solution for WPF app](https://youtu.be/Ctfuh8tIteg?t=01h22m59s)

[probably others but I'm starting with](https://youtu.be/Ctfuh8tIteg?t=01h23m04s)

[WPF as my focus because that's what I](https://youtu.be/Ctfuh8tIteg?t=01h23m06s)

[care about](https://youtu.be/Ctfuh8tIteg?t=01h23m08s)

[um do I have a sample](https://youtu.be/Ctfuh8tIteg?t=01h23m10s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h23m15s)

[let me look at my commit history I can't](https://youtu.be/Ctfuh8tIteg?t=01h23m16s)

[remember did I push](https://youtu.be/Ctfuh8tIteg?t=01h23m19s)

[I must not have pushed my branch](https://youtu.be/Ctfuh8tIteg?t=01h23m22s)

[well that's terrifying I may have lost](https://youtu.be/Ctfuh8tIteg?t=01h23m25s)

[work](https://youtu.be/Ctfuh8tIteg?t=01h23m27s)

[that would be really disappointing if I](https://youtu.be/Ctfuh8tIteg?t=01h23m28s)

[didn't push my branch](https://youtu.be/Ctfuh8tIteg?t=01h23m29s)

[it'd be very very disappointing](https://youtu.be/Ctfuh8tIteg?t=01h23m32s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h23m35s)

[no it shows Net 7 upgrade 10 months ago](https://youtu.be/Ctfuh8tIteg?t=01h23m36s)

[that that's not right](https://youtu.be/Ctfuh8tIteg?t=01h23m39s)

[um I need to go back and look I'd be](https://youtu.be/Ctfuh8tIteg?t=01h23m41s)

[very unhappy with myself if I lost](https://youtu.be/Ctfuh8tIteg?t=01h23m42s)

[if I lost work on here because I was](https://youtu.be/Ctfuh8tIteg?t=01h23m45s)

[building out some integration tests the](https://youtu.be/Ctfuh8tIteg?t=01h23m46s)

[idea being that you add this nuget](https://youtu.be/Ctfuh8tIteg?t=01h23m48s)

[package to your project you set up some](https://youtu.be/Ctfuh8tIteg?t=01h23m50s)

[uh properties in your CS prods just like](https://youtu.be/Ctfuh8tIteg?t=01h23m53s)

[you would for building nougat package](https://youtu.be/Ctfuh8tIteg?t=01h23m55s)

[and then you run.net publish](https://youtu.be/Ctfuh8tIteg?t=01h23m58s)

[and you're done](https://youtu.be/Ctfuh8tIteg?t=01h24m00s)

[that's the end goal](https://youtu.be/Ctfuh8tIteg?t=01h24m02s)

[um and the the big difference of what](https://youtu.be/Ctfuh8tIteg?t=01h24m05s)

[this adds beyond](https://youtu.be/Ctfuh8tIteg?t=01h24m07s)

[what cloud scroll does because Cloud](https://youtu.be/Ctfuh8tIteg?t=01h24m09s)

[squirrel is set up with some really nice](https://youtu.be/Ctfuh8tIteg?t=01h24m11s)

[um properties if you want to publish out](https://youtu.be/Ctfuh8tIteg?t=01h24m15s)

[to one of its well-known locations so](https://youtu.be/Ctfuh8tIteg?t=01h24m17s)

[the way squirrel Works in general is](https://youtu.be/Ctfuh8tIteg?t=01h24m20s)

[that hang on oh more Shameless](https://youtu.be/Ctfuh8tIteg?t=01h24m22s)

[self-promotion intellitech](https://youtu.be/Ctfuh8tIteg?t=01h24m24s)

[squirrel](https://youtu.be/Ctfuh8tIteg?t=01h24m27s)

[uh that is](https://youtu.be/Ctfuh8tIteg?t=01h24m29s)

[yeah this one okay good our SEO isn't](https://youtu.be/Ctfuh8tIteg?t=01h24m32s)

[crap](https://youtu.be/Ctfuh8tIteg?t=01h24m35s)

[so if you're interested this is a](https://youtu.be/Ctfuh8tIteg?t=01h24m37s)

[slightly older blog post that I wrote](https://youtu.be/Ctfuh8tIteg?t=01h24m39s)

[um nothing is nothing functionally has](https://youtu.be/Ctfuh8tIteg?t=01h24m42s)

[changed about squirrel since I wrote](https://youtu.be/Ctfuh8tIteg?t=01h24m44s)

[this blog post that's how slow they](https://youtu.be/Ctfuh8tIteg?t=01h24m45s)

[update so to fight despite the fact that](https://youtu.be/Ctfuh8tIteg?t=01h24m47s)

[this is old this is this is still](https://youtu.be/Ctfuh8tIteg?t=01h24m50s)

[accurate information as far as I'm aware](https://youtu.be/Ctfuh8tIteg?t=01h24m53s)

[if you find something different let me](https://youtu.be/Ctfuh8tIteg?t=01h24m55s)

[know but Cloud squirrel functions](https://youtu.be/Ctfuh8tIteg?t=01h24m56s)

[essentially the same way so](https://youtu.be/Ctfuh8tIteg?t=01h24m58s)

[you have new spec stuff you generate you](https://youtu.be/Ctfuh8tIteg?t=01h25m02s)

[build but at the end of the day what you](https://youtu.be/Ctfuh8tIteg?t=01h25m05s)

[end up with is a releases file and this](https://youtu.be/Ctfuh8tIteg?t=01h25m07s)

[is just a text a new line delimited text](https://youtu.be/Ctfuh8tIteg?t=01h25m10s)

[file that lists out all of your versions](https://youtu.be/Ctfuh8tIteg?t=01h25m13s)

[right and then there's the the setup](https://youtu.be/Ctfuh8tIteg?t=01h25m16s)

[things and the nuget package stuff if](https://youtu.be/Ctfuh8tIteg?t=01h25m18s)

[you publish this out](https://youtu.be/Ctfuh8tIteg?t=01h25m20s)

[to a](https://youtu.be/Ctfuh8tIteg?t=01h25m22s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h25m24s)

[do a GitHub release like what uh is](https://youtu.be/Ctfuh8tIteg?t=01h25m25s)

[being done here the](https://youtu.be/Ctfuh8tIteg?t=01h25m28s)

[um there's nice support to then let](https://youtu.be/Ctfuh8tIteg?t=01h25m31s)

[GitHub effectively manage that releases](https://youtu.be/Ctfuh8tIteg?t=01h25m34s)

[file for you and do all of the work so](https://youtu.be/Ctfuh8tIteg?t=01h25m36s)

[Cloud squirrel has some nice](https://youtu.be/Ctfuh8tIteg?t=01h25m38s)

[um CLI commands built into it to make](https://youtu.be/Ctfuh8tIteg?t=01h25m41s)

[your life really easy if that's where](https://youtu.be/Ctfuh8tIteg?t=01h25m43s)

[you want to publish](https://youtu.be/Ctfuh8tIteg?t=01h25m45s)

[right the one thing I don't necessarily](https://youtu.be/Ctfuh8tIteg?t=01h25m46s)

[like about that is in order for the](https://youtu.be/Ctfuh8tIteg?t=01h25m49s)

[updates to work squirrel installers uh](https://youtu.be/Ctfuh8tIteg?t=01h25m51s)

[where is my code sample I thought I saw](https://youtu.be/Ctfuh8tIteg?t=01h25m55s)

[it](https://youtu.be/Ctfuh8tIteg?t=01h25m57s)

[um to to do the updates within your app](https://youtu.be/Ctfuh8tIteg?t=01h25m58s)

[you have to create it you have to do the](https://youtu.be/Ctfuh8tIteg?t=01h26m01s)

[update call yourself that's not](https://youtu.be/Ctfuh8tIteg?t=01h26m03s)

[something that you get for free out of](https://youtu.be/Ctfuh8tIteg?t=01h26m05s)

[the box you have to determine when and](https://youtu.be/Ctfuh8tIteg?t=01h26m08s)

[how updates occur so this isn't like](https://youtu.be/Ctfuh8tIteg?t=01h26m10s)

[click once where it where it does it all](https://youtu.be/Ctfuh8tIteg?t=01h26m12s)

[for you](https://youtu.be/Ctfuh8tIteg?t=01h26m14s)

[um you create an update manager and you](https://youtu.be/Ctfuh8tIteg?t=01h26m16s)

[tell it where to look for updates](https://youtu.be/Ctfuh8tIteg?t=01h26m19s)

[now this is also convenient because say](https://youtu.be/Ctfuh8tIteg?t=01h26m21s)

[you want to have like an alpha beta and](https://youtu.be/Ctfuh8tIteg?t=01h26m23s)

[release feeds you could just create](https://youtu.be/Ctfuh8tIteg?t=01h26m25s)

[three of these suckers Point them at](https://youtu.be/Ctfuh8tIteg?t=01h26m27s)

[each of the different locations of where](https://youtu.be/Ctfuh8tIteg?t=01h26m28s)

[those things are and Away you go the](https://youtu.be/Ctfuh8tIteg?t=01h26m30s)

[problem is is this location has to be](https://youtu.be/Ctfuh8tIteg?t=01h26m32s)

[pointed somewhere where it can find that](https://youtu.be/Ctfuh8tIteg?t=01h26m34s)

[releases file for the Manifest that's](https://youtu.be/Ctfuh8tIteg?t=01h26m36s)

[how it knows it looks it goes okay what](https://youtu.be/Ctfuh8tIteg?t=01h26m38s)

[do I have what's in this releases file](https://youtu.be/Ctfuh8tIteg?t=01h26m40s)

[okay now I can you know either do the](https://youtu.be/Ctfuh8tIteg?t=01h26m43s)

[appropriate updates or whatnot](https://youtu.be/Ctfuh8tIteg?t=01h26m45s)

[this amount of work is painful to me and](https://youtu.be/Ctfuh8tIteg?t=01h26m49s)

[I didn't like it so I the idea with](https://youtu.be/Ctfuh8tIteg?t=01h26m52s)

[skirt is I wanted to have](https://youtu.be/Ctfuh8tIteg?t=01h26m55s)

[a web API that I could point this guy at](https://youtu.be/Ctfuh8tIteg?t=01h26m58s)

[and then I wanted it to sit between the](https://youtu.be/Ctfuh8tIteg?t=01h27m00s)

[storage mechanism and whatever uh and](https://youtu.be/Ctfuh8tIteg?t=01h27m04s)

[the app itself so that if I want to](https://youtu.be/Ctfuh8tIteg?t=01h27m08s)

[change where the storage is at I want to](https://youtu.be/Ctfuh8tIteg?t=01h27m10s)

[move it from you know storage account a](https://youtu.be/Ctfuh8tIteg?t=01h27m12s)

[to storage account b or maybe move it](https://youtu.be/Ctfuh8tIteg?t=01h27m14s)

[into GitHub artifact or whatever right I](https://youtu.be/Ctfuh8tIteg?t=01h27m15s)

[don't want to have to worry about well I](https://youtu.be/Ctfuh8tIteg?t=01h27m18s)

[can't do that easily because old](https://youtu.be/Ctfuh8tIteg?t=01h27m20s)

[versions are going to be looking here](https://youtu.be/Ctfuh8tIteg?t=01h27m22s)

[for the releases file I wanted kind of](https://youtu.be/Ctfuh8tIteg?t=01h27m23s)

[one Central API where that could all be](https://youtu.be/Ctfuh8tIteg?t=01h27m25s)

[managed and then it's it generates the](https://youtu.be/Ctfuh8tIteg?t=01h27m27s)

[releases file](https://youtu.be/Ctfuh8tIteg?t=01h27m30s)

[kind of ish on the Fly is the idea so](https://youtu.be/Ctfuh8tIteg?t=01h27m31s)

[that it can control the releases so that](https://youtu.be/Ctfuh8tIteg?t=01h27m34s)

[if you need to you know unlist something](https://youtu.be/Ctfuh8tIteg?t=01h27m36s)

[or if you want to manage multiple](https://youtu.be/Ctfuh8tIteg?t=01h27m37s)

[channels that kind of thing you can get](https://youtu.be/Ctfuh8tIteg?t=01h27m39s)

[away with it so because that's the other](https://youtu.be/Ctfuh8tIteg?t=01h27m40s)

[limitation of like if you use uh Cloud](https://youtu.be/Ctfuh8tIteg?t=01h27m42s)

[squirrel and point it at a](https://youtu.be/Ctfuh8tIteg?t=01h27m46s)

[GitHub release you don't have the](https://youtu.be/Ctfuh8tIteg?t=01h27m49s)

[ability of doing like that Alpha Beta](https://youtu.be/Ctfuh8tIteg?t=01h27m52s)

[Channel thing](https://youtu.be/Ctfuh8tIteg?t=01h27m54s)

[because you only have one place to look](https://youtu.be/Ctfuh8tIteg?t=01h27m56s)

[for the file so unless you want to write](https://youtu.be/Ctfuh8tIteg?t=01h27m58s)

[some code to go through and do some work](https://youtu.be/Ctfuh8tIteg?t=01h28m01s)

[and that kind of thing and if you're](https://youtu.be/Ctfuh8tIteg?t=01h28m02s)

[going to write code to do it that's](https://youtu.be/Ctfuh8tIteg?t=01h28m04s)

[where score day came in and I was like I](https://youtu.be/Ctfuh8tIteg?t=01h28m05s)

[kind of want something to have it](https://youtu.be/Ctfuh8tIteg?t=01h28m07s)

[working but I did run into a couple](https://youtu.be/Ctfuh8tIteg?t=01h28m08s)

[minor problems I thought I had revved it](https://youtu.be/Ctfuh8tIteg?t=01h28m11s)

[up to like the V3 of cloud squirrel and](https://youtu.be/Ctfuh8tIteg?t=01h28m14s)

[I was working on building some](https://youtu.be/Ctfuh8tIteg?t=01h28m17s)

[integration tests](https://youtu.be/Ctfuh8tIteg?t=01h28m18s)

[because I want to go end to end with my](https://youtu.be/Ctfuh8tIteg?t=01h28m19s)

[testing on it of](https://youtu.be/Ctfuh8tIteg?t=01h28m21s)

[dot net new app add nougat packet like I](https://youtu.be/Ctfuh8tIteg?t=01h28m23s)

[I was trying to script the entire bloody](https://youtu.be/Ctfuh8tIteg?t=01h28m26s)

[process of I'm going to go.net new add](https://youtu.be/Ctfuh8tIteg?t=01h28m29s)

[the thing add the thing add the thing](https://youtu.be/Ctfuh8tIteg?t=01h28m32s)

[and away we go so](https://youtu.be/Ctfuh8tIteg?t=01h28m34s)

[um if you're interested and you haven't](https://youtu.be/Ctfuh8tIteg?t=01h28m37s)

[picked an installer technology](https://youtu.be/Ctfuh8tIteg?t=01h28m38s)

[um squirrel or Cloud squirrel are very](https://youtu.be/Ctfuh8tIteg?t=01h28m41s)

[popular options out there there's a lot](https://youtu.be/Ctfuh8tIteg?t=01h28m43s)

[of a lot of main apps that are using it](https://youtu.be/Ctfuh8tIteg?t=01h28m46s)

[for example get Kraken](https://youtu.be/Ctfuh8tIteg?t=01h28m48s)

[uses it to deploy their stuff out](https://youtu.be/Ctfuh8tIteg?t=01h28m51s)

[so it can't be that bad because my](https://youtu.be/Ctfuh8tIteg?t=01h28m53s)

[beloved get cracking uses it](https://youtu.be/Ctfuh8tIteg?t=01h28m56s)

[so there's that that that's kind of an](https://youtu.be/Ctfuh8tIteg?t=01h28m58s)

[important detail](https://youtu.be/Ctfuh8tIteg?t=01h29m00s)

[okay](https://youtu.be/Ctfuh8tIteg?t=01h29m01s)

[uh I've already once again lost my place](https://youtu.be/Ctfuh8tIteg?t=01h29m03s)

[so this was adding in the](https://youtu.be/Ctfuh8tIteg?t=01h29m05s)

[grid splitter](https://youtu.be/Ctfuh8tIteg?t=01h29m08s)

[uh did you ever get your.net template](https://youtu.be/Ctfuh8tIteg?t=01h29m11s)

[with multiple options to work yes ish](https://youtu.be/Ctfuh8tIteg?t=01h29m13s)

[um I got it far enough along working and](https://youtu.be/Ctfuh8tIteg?t=01h29m16s)

[then I also](https://youtu.be/Ctfuh8tIteg?t=01h29m18s)

[I backed up and started questioning if I](https://youtu.be/Ctfuh8tIteg?t=01h29m21s)

[wanted that or not](https://youtu.be/Ctfuh8tIteg?t=01h29m23s)

[because](https://youtu.be/Ctfuh8tIteg?t=01h29m25s)

[I had a realization](https://youtu.be/Ctfuh8tIteg?t=01h29m27s)

[that](https://youtu.be/Ctfuh8tIteg?t=01h29m30s)

[I might actually want things out of sync](https://youtu.be/Ctfuh8tIteg?t=01h29m32s)

[um intentionally](https://youtu.be/Ctfuh8tIteg?t=01h29m37s)

[and that and that got me a little](https://youtu.be/Ctfuh8tIteg?t=01h29m39s)

[I I then backed up and started](https://youtu.be/Ctfuh8tIteg?t=01h29m42s)

[questioning it not if I could but if I](https://youtu.be/Ctfuh8tIteg?t=01h29m44s)

[should which is a hard question to](https://youtu.be/Ctfuh8tIteg?t=01h29m48s)

[answer](https://youtu.be/Ctfuh8tIteg?t=01h29m50s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h29m52s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h29m55s)

[so so yes ish I I got it far enough to](https://youtu.be/Ctfuh8tIteg?t=01h29m58s)

[to question if I was even doing the](https://youtu.be/Ctfuh8tIteg?t=01h30m03s)

[right thing and then I kind of paused](https://youtu.be/Ctfuh8tIteg?t=01h30m05s)

[for a minute because I was like I don't](https://youtu.be/Ctfuh8tIteg?t=01h30m07s)

[know](https://youtu.be/Ctfuh8tIteg?t=01h30m08s)

[um but you make a good point it would be](https://youtu.be/Ctfuh8tIteg?t=01h30m11s)

[cool to Circle back to uh let's see](https://youtu.be/Ctfuh8tIteg?t=01h30m13s)

[added new](https://youtu.be/Ctfuh8tIteg?t=01h30m15s)

[and](https://youtu.be/Ctfuh8tIteg?t=01h30m17s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h30m21s)

[to cover the brushes in this file also](https://youtu.be/Ctfuh8tIteg?t=01h30m22s)

[Michael if you're watching thank you](https://youtu.be/Ctfuh8tIteg?t=01h30m27s)

[thank you thank you all of these review](https://youtu.be/Ctfuh8tIteg?t=01h30m29s)

[bits have been amazing](https://youtu.be/Ctfuh8tIteg?t=01h30m31s)

[you are awesome](https://youtu.be/Ctfuh8tIteg?t=01h30m33s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h30m35s)

[to handle the](https://youtu.be/Ctfuh8tIteg?t=01h30m39s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h30m45s)

[net Sparkle oh](https://youtu.be/Ctfuh8tIteg?t=01h30m48s)

[no but it sounds cool](https://youtu.be/Ctfuh8tIteg?t=01h30m53s)

[let's](https://youtu.be/Ctfuh8tIteg?t=01h31m01s)

[so they support](https://youtu.be/Ctfuh8tIteg?t=01h31m08s)

[at least most of all the big things](https://youtu.be/Ctfuh8tIteg?t=01h31m10s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h31m13s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h31m14s)

[there's at least something that was](https://youtu.be/Ctfuh8tIteg?t=01h31m17s)

[committed recently though that's in the](https://youtu.be/Ctfuh8tIteg?t=01h31m19s)

[vs code folder](https://youtu.be/Ctfuh8tIteg?t=01h31m22s)

[and the GitHub folder](https://youtu.be/Ctfuh8tIteg?t=01h31m24s)

[when's their last release two weeks ago](https://youtu.be/Ctfuh8tIteg?t=01h31m27s)

[okay so that's](https://youtu.be/Ctfuh8tIteg?t=01h31m30s)

[that's pretty recent](https://youtu.be/Ctfuh8tIteg?t=01h31m34s)

[and the one before that was November of](https://youtu.be/Ctfuh8tIteg?t=01h31m37s)

[2022.](https://youtu.be/Ctfuh8tIteg?t=01h31m40s)

[so](https://youtu.be/Ctfuh8tIteg?t=01h31m43s)

[interesting this is](https://youtu.be/Ctfuh8tIteg?t=01h31m49s)

[how updates work](https://youtu.be/Ctfuh8tIteg?t=01h31m54s)

[let's see it does not help you with one](https://youtu.be/Ctfuh8tIteg?t=01h32m04s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h32m08s)

[that makes sense](https://youtu.be/Ctfuh8tIteg?t=01h32m09s)

[uh two](https://youtu.be/Ctfuh8tIteg?t=01h32m12s)

[it's interesting that they don't try to](https://youtu.be/Ctfuh8tIteg?t=01h32m20s)

[do this because step two is actually](https://youtu.be/Ctfuh8tIteg?t=01h32m22s)

[legitimately one of the big things that](https://youtu.be/Ctfuh8tIteg?t=01h32m25s)

[squirrel tries to do](https://youtu.be/Ctfuh8tIteg?t=01h32m26s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h32m29s)

[and four](https://youtu.be/Ctfuh8tIteg?t=01h32m30s)

[yeah so I would argue squirrel tries to](https://youtu.be/Ctfuh8tIteg?t=01h32m32s)

[handle two for you and Cloud squirrel](https://youtu.be/Ctfuh8tIteg?t=01h32m36s)

[tries to handle it in a cross-platform](https://youtu.be/Ctfuh8tIteg?t=01h32m38s)

[way so this idea that a cross-platform](https://youtu.be/Ctfuh8tIteg?t=01h32m40s)

[installer package system would be](https://youtu.be/Ctfuh8tIteg?t=01h32m42s)

[difficult uh yes and that's why we](https://youtu.be/Ctfuh8tIteg?t=01h32m43s)

[applaud Cloud squirrel for taking it on](https://youtu.be/Ctfuh8tIteg?t=01h32m46s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h32m50s)

[and four is arguably what skirt a is](https://youtu.be/Ctfuh8tIteg?t=01h32m52s)

[trying to go for](https://youtu.be/Ctfuh8tIteg?t=01h32m55s)

[yeah and it doesn't like screwdie only](https://youtu.be/Ctfuh8tIteg?t=01h33m00s)

[partially helps you with number four](https://youtu.be/Ctfuh8tIteg?t=01h33m03s)

[like it doesn't help you upload the](https://youtu.be/Ctfuh8tIteg?t=01h33m04s)

[files somewhere it expects you to put](https://youtu.be/Ctfuh8tIteg?t=01h33m07s)

[them somewhere but then it plays](https://youtu.be/Ctfuh8tIteg?t=01h33m09s)

[middleman doing the the redirection](https://youtu.be/Ctfuh8tIteg?t=01h33m11s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h33m15s)

[but this doesn't seem bad](https://youtu.be/Ctfuh8tIteg?t=01h33m19s)

[the other thing with like squirrel and](https://youtu.be/Ctfuh8tIteg?t=01h33m23s)

[Cloud squirrel that's worth noting is](https://youtu.be/Ctfuh8tIteg?t=01h33m26s)

[you don't get customization on the](https://youtu.be/Ctfuh8tIteg?t=01h33m28s)

[install like you know the next next](https://youtu.be/Ctfuh8tIteg?t=01h33m30s)

[finish experience wizardy thing for](https://youtu.be/Ctfuh8tIteg?t=01h33m32s)

[installs that most people are used to](https://youtu.be/Ctfuh8tIteg?t=01h33m34s)

[um you don't get any of that](https://youtu.be/Ctfuh8tIteg?t=01h33m36s)

[squirrel is designed to install into the](https://youtu.be/Ctfuh8tIteg?t=01h33m39s)

[the the user's Local app data so it](https://youtu.be/Ctfuh8tIteg?t=01h33m42s)

[doesn't need UAC and it's designed to](https://youtu.be/Ctfuh8tIteg?t=01h33m45s)

[install so bloody fast that it doesn't](https://youtu.be/Ctfuh8tIteg?t=01h33m48s)

[pop an install screen](https://youtu.be/Ctfuh8tIteg?t=01h33m50s)

[that's its purpose in life is to go](https://youtu.be/Ctfuh8tIteg?t=01h33m53s)

[really fast on the install](https://youtu.be/Ctfuh8tIteg?t=01h33m55s)

[um the setting that they have in](https://youtu.be/Ctfuh8tIteg?t=01h33m58s)

[Squirrel for if you should pull up the](https://youtu.be/Ctfuh8tIteg?t=01h34m00s)

[splash screen I think only triggers if](https://youtu.be/Ctfuh8tIteg?t=01h34m01s)

[your installer takes more than four](https://youtu.be/Ctfuh8tIteg?t=01h34m04s)

[seconds](https://youtu.be/Ctfuh8tIteg?t=01h34m06s)

[and most of the time you'll never see](https://youtu.be/Ctfuh8tIteg?t=01h34m07s)

[the splash screen](https://youtu.be/Ctfuh8tIteg?t=01h34m09s)

[because the install is done that fast](https://youtu.be/Ctfuh8tIteg?t=01h34m10s)

[because it takes them longer to get the](https://youtu.be/Ctfuh8tIteg?t=01h34m12s)

[splash screen up than that four seconds](https://youtu.be/Ctfuh8tIteg?t=01h34m14s)

[so they they intentionally delay even](https://youtu.be/Ctfuh8tIteg?t=01h34m16s)

[going to pop it until your app has taken](https://youtu.be/Ctfuh8tIteg?t=01h34m19s)

[so long on the install they go okay I](https://youtu.be/Ctfuh8tIteg?t=01h34m21s)

[guess I guess we should put it up now](https://youtu.be/Ctfuh8tIteg?t=01h34m23s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h34m25s)

[interesting](https://youtu.be/Ctfuh8tIteg?t=01h34m32s)

[this looks interesting](https://youtu.be/Ctfuh8tIteg?t=01h34m42s)

[it's it's curious how they have this set](https://youtu.be/Ctfuh8tIteg?t=01h34m49s)

[up like this looks really powerful but](https://youtu.be/Ctfuh8tIteg?t=01h34m51s)

[yeah I I question how](https://youtu.be/Ctfuh8tIteg?t=01h35m05s)

[it seems like a lot of steps but maybe I](https://youtu.be/Ctfuh8tIteg?t=01h35m10s)

[just need to actually go through and gen](https://youtu.be/Ctfuh8tIteg?t=01h35m13s)

[this](https://youtu.be/Ctfuh8tIteg?t=01h35m15s)

[oh oh wow](https://youtu.be/Ctfuh8tIteg?t=01h35m28s)

[App Center wow okay so](https://youtu.be/Ctfuh8tIteg?t=01h35m30s)

[yeah so I will caution people](https://youtu.be/Ctfuh8tIteg?t=01h35m34s)

[App Center](https://youtu.be/Ctfuh8tIteg?t=01h35m37s)

[is amazing and wonderful](https://youtu.be/Ctfuh8tIteg?t=01h35m39s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h35m43s)

[the](https://youtu.be/Ctfuh8tIteg?t=01h35m45s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h35m47s)

[it is functionally dead though](https://youtu.be/Ctfuh8tIteg?t=01h35m48s)

[like Microsoft hasn't killed it](https://youtu.be/Ctfuh8tIteg?t=01h35m51s)

[completely](https://youtu.be/Ctfuh8tIteg?t=01h35m54s)

[but don't expect to see any updates](https://youtu.be/Ctfuh8tIteg?t=01h35m55s)

[coming to it](https://youtu.be/Ctfuh8tIteg?t=01h35m58s)

[it's it's pretty](https://youtu.be/Ctfuh8tIteg?t=01h36m00s)

[yeah it's kind of DOA](https://youtu.be/Ctfuh8tIteg?t=01h36m03s)

[even though it's nice I would not start](https://youtu.be/Ctfuh8tIteg?t=01h36m07s)

[new projects on it at all](https://youtu.be/Ctfuh8tIteg?t=01h36m09s)

[uh didn't notice Cloud squirrel 3 will](https://youtu.be/Ctfuh8tIteg?t=01h36m11s)

[also be cross-platform yeah that is the](https://youtu.be/Ctfuh8tIteg?t=01h36m13s)

[big thing for it is the cross platform](https://youtu.be/Ctfuh8tIteg?t=01h36m15s)

[support](https://youtu.be/Ctfuh8tIteg?t=01h36m17s)

[um scur day should be cross-platform](https://youtu.be/Ctfuh8tIteg?t=01h36m19s)

[um the only thing I will caution of is](https://youtu.be/Ctfuh8tIteg?t=01h36m21s)

[the](https://youtu.be/Ctfuh8tIteg?t=01h36m25s)

[I'm aware that Scurry day needs to have](https://youtu.be/Ctfuh8tIteg?t=01h36m27s)

[probably two nougat packages one that's](https://youtu.be/Ctfuh8tIteg?t=01h36m30s)

[WPF specific and one that's just the](https://youtu.be/Ctfuh8tIteg?t=01h36m33s)

[core Library bits right now it's all](https://youtu.be/Ctfuh8tIteg?t=01h36m35s)

[mushed into one so at the moment](https://youtu.be/Ctfuh8tIteg?t=01h36m38s)

[I'm trying to think what's in there that](https://youtu.be/Ctfuh8tIteg?t=01h36m42s)

[might not work](https://youtu.be/Ctfuh8tIteg?t=01h36m44s)

[the bits that are inside the nuget](https://youtu.be/Ctfuh8tIteg?t=01h36m46s)

[package right now that are not](https://youtu.be/Ctfuh8tIteg?t=01h36m48s)

[cross-platform I think are all around](https://youtu.be/Ctfuh8tIteg?t=01h36m49s)

[the code generation that it does for you](https://youtu.be/Ctfuh8tIteg?t=01h36m51s)

[because in order to make it easy](https://youtu.be/Ctfuh8tIteg?t=01h36m54s)

[generates some additional bits of code](https://youtu.be/Ctfuh8tIteg?t=01h36m57s)

[that it injects with Source generators](https://youtu.be/Ctfuh8tIteg?t=01h37m00s)

[and Ms build magic in order to put the](https://youtu.be/Ctfuh8tIteg?t=01h37m03s)

[right things in the right places](https://youtu.be/Ctfuh8tIteg?t=01h37m06s)

[so there's](https://youtu.be/Ctfuh8tIteg?t=01h37m08s)

[some of that would probably need to be](https://youtu.be/Ctfuh8tIteg?t=01h37m11s)

[separated out](https://youtu.be/Ctfuh8tIteg?t=01h37m13s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h37m16s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h37m19s)

[uh let's see are you able to do](https://youtu.be/Ctfuh8tIteg?t=01h37m24s)

[templates in a way that after you start](https://youtu.be/Ctfuh8tIteg?t=01h37m26s)

[repo you can later apply something like](https://youtu.be/Ctfuh8tIteg?t=01h37m27s)

[the actions template uh so you can](https://youtu.be/Ctfuh8tIteg?t=01h37m29s)

[always you can always do dot net](https://youtu.be/Ctfuh8tIteg?t=01h37m33s)

[templates](https://youtu.be/Ctfuh8tIteg?t=01h37m34s)

[um after the fact so for example](https://youtu.be/Ctfuh8tIteg?t=01h37m35s)

[uh let me grab a new terminal here](https://youtu.be/Ctfuh8tIteg?t=01h37m38s)

[so we'll just do](https://youtu.be/Ctfuh8tIteg?t=01h37m42s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h37m45s)

[right so if we look here I've got a git](https://youtu.be/Ctfuh8tIteg?t=01h37m47s)

[ignore file that's already in my repo](https://youtu.be/Ctfuh8tIteg?t=01h37m50s)

[but say I'm like you know what I'd](https://youtu.be/Ctfuh8tIteg?t=01h37m52s)

[really like the the the.net one so but](https://youtu.be/Ctfuh8tIteg?t=01h37m54s)

[if I do you know dot net new uh](https://youtu.be/Ctfuh8tIteg?t=01h37m56s)

[get ignore](https://youtu.be/Ctfuh8tIteg?t=01h38m00s)

[right you got to spell it correctly](https://youtu.be/Ctfuh8tIteg?t=01h38m02s)

[um you'll note it immediately goes hang](https://youtu.be/Ctfuh8tIteg?t=01h38m04s)

[on](https://youtu.be/Ctfuh8tIteg?t=01h38m06s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h38m08s)

[that's going to override existing files](https://youtu.be/Ctfuh8tIteg?t=01h38m08s)

[so the default behavior of the.net new](https://youtu.be/Ctfuh8tIteg?t=01h38m11s)

[templates is to not override anything](https://youtu.be/Ctfuh8tIteg?t=01h38m12s)

[which is generally safe but there's](https://youtu.be/Ctfuh8tIteg?t=01h38m15s)

[nothing stopping you from saying nah](https://youtu.be/Ctfuh8tIteg?t=01h38m18s)

[do it and if you're under Source control](https://youtu.be/Ctfuh8tIteg?t=01h38m21s)

[it's not that big of a deal right you](https://youtu.be/Ctfuh8tIteg?t=01h38m23s)

[can apply the template and go in and](https://youtu.be/Ctfuh8tIteg?t=01h38m25s)

[look at it so if you](https://youtu.be/Ctfuh8tIteg?t=01h38m27s)

[um like if you realize oh I'd like to](https://youtu.be/Ctfuh8tIteg?t=01h38m30s)

[start a a project but I'd like some of](https://youtu.be/Ctfuh8tIteg?t=01h38m32s)

[the stuff that you have in your template](https://youtu.be/Ctfuh8tIteg?t=01h38m34s)

[well](https://youtu.be/Ctfuh8tIteg?t=01h38m37s)

[one commit all your changes save your](https://youtu.be/Ctfuh8tIteg?t=01h38m38s)

[state first right and then just run.net](https://youtu.be/Ctfuh8tIteg?t=01h38m42s)

[new with the](https://youtu.be/Ctfuh8tIteg?t=01h38m44s)

[um the thing and it will](https://youtu.be/Ctfuh8tIteg?t=01h38m47s)

[it'll override everything with the](https://youtu.be/Ctfuh8tIteg?t=01h38m50s)

[contents of the template and then you](https://youtu.be/Ctfuh8tIteg?t=01h38m52s)

[can just revert the files and or bits](https://youtu.be/Ctfuh8tIteg?t=01h38m53s)

[that you don't want](https://youtu.be/Ctfuh8tIteg?t=01h38m56s)

[right uh is there essentially a skip](https://youtu.be/Ctfuh8tIteg?t=01h38m57s)

[option to add files that aren't added](https://youtu.be/Ctfuh8tIteg?t=01h39m01s)

[already](https://youtu.be/Ctfuh8tIteg?t=01h39m04s)

[no](https://youtu.be/Ctfuh8tIteg?t=01h39m06s)

[yeah and that's the thing is](https://youtu.be/Ctfuh8tIteg?t=01h39m11s)

[um there is that subtle difference](https://youtu.be/Ctfuh8tIteg?t=01h39m14s)

[between](https://youtu.be/Ctfuh8tIteg?t=01h39m16s)

[um what is like an item template or a](https://youtu.be/Ctfuh8tIteg?t=01h39m17s)

[repo level template and you still kind](https://youtu.be/Ctfuh8tIteg?t=01h39m20s)

[of functionally Define them out very](https://youtu.be/Ctfuh8tIteg?t=01h39m22s)

[like they're very similar in terms of](https://youtu.be/Ctfuh8tIteg?t=01h39m24s)

[what you write](https://youtu.be/Ctfuh8tIteg?t=01h39m26s)

[but](https://youtu.be/Ctfuh8tIteg?t=01h39m28s)

[you you can't just do the the individual](https://youtu.be/Ctfuh8tIteg?t=01h39m29s)

[one but yeah the actions thing I think](https://youtu.be/Ctfuh8tIteg?t=01h39m32s)

[um Mr X is right the the easiest thing](https://youtu.be/Ctfuh8tIteg?t=01h39m36s)

[is just an item template and do it and](https://youtu.be/Ctfuh8tIteg?t=01h39m38s)

[that's part of where I got back to that](https://youtu.be/Ctfuh8tIteg?t=01h39m41s)

[idea on my templates repo of thinking is](https://youtu.be/Ctfuh8tIteg?t=01h39m43s)

[this actually the right solution](https://youtu.be/Ctfuh8tIteg?t=01h39m47s)

[because and that's what that got me](https://youtu.be/Ctfuh8tIteg?t=01h39m49s)

[thinking of is do I actually want to](https://youtu.be/Ctfuh8tIteg?t=01h39m51s)

[have](https://youtu.be/Ctfuh8tIteg?t=01h39m54s)

[these things be part](https://youtu.be/Ctfuh8tIteg?t=01h39m55s)

[of them or not](https://youtu.be/Ctfuh8tIteg?t=01h39m58s)

[and that's where I was like you know I'm](https://youtu.be/Ctfuh8tIteg?t=01h40m00s)

[not sure I actually want them to be that](https://youtu.be/Ctfuh8tIteg?t=01h40m02s)

[way I I kind of feel like if I want](https://youtu.be/Ctfuh8tIteg?t=01h40m04s)

[like for example if I do a GitHub](https://youtu.be/Ctfuh8tIteg?t=01h40m08s)

[actions template right that has some](https://youtu.be/Ctfuh8tIteg?t=01h40m10s)

[published stuff and I'm like you know](https://youtu.be/Ctfuh8tIteg?t=01h40m13s)

[I'd really like that to be applied to my](https://youtu.be/Ctfuh8tIteg?t=01h40m14s)

[other project templates I feel like I](https://youtu.be/Ctfuh8tIteg?t=01h40m16s)

[want to intentionally go through and do](https://youtu.be/Ctfuh8tIteg?t=01h40m19s)

[the the dot net new you know](https://youtu.be/Ctfuh8tIteg?t=01h40m21s)

[Caboose cool action template here dash](https://youtu.be/Ctfuh8tIteg?t=01h40m25s)

[dash for some other templates I want to](https://youtu.be/Ctfuh8tIteg?t=01h40m28s)

[do that very explicitly](https://youtu.be/Ctfuh8tIteg?t=01h40m30s)

[on a case-by-case basis rather than](https://youtu.be/Ctfuh8tIteg?t=01h40m33s)

[having it go all the way through](https://youtu.be/Ctfuh8tIteg?t=01h40m35s)

[so I and that's where it's like I](https://youtu.be/Ctfuh8tIteg?t=01h40m38s)

[because I realize I'm packaging multiple](https://youtu.be/Ctfuh8tIteg?t=01h40m40s)

[templates into a single nougat package](https://youtu.be/Ctfuh8tIteg?t=01h40m42s)

[and that also means that](https://youtu.be/Ctfuh8tIteg?t=01h40m46s)

[if like my WPF template is a solution](https://youtu.be/Ctfuh8tIteg?t=01h40m49s)

[template and if somebody wants a bit of](https://youtu.be/Ctfuh8tIteg?t=01h40m53s)

[one of the other templates in it they](https://youtu.be/Ctfuh8tIteg?t=01h40m56s)

[can always go and apply that and that's](https://youtu.be/Ctfuh8tIteg?t=01h40m58s)

[where I was like I could try to automate](https://youtu.be/Ctfuh8tIteg?t=01h40m59s)

[that away but](https://youtu.be/Ctfuh8tIteg?t=01h41m01s)

[at the end of the day it almost feels](https://youtu.be/Ctfuh8tIteg?t=01h41m03s)

[better to let them be out of sync](https://youtu.be/Ctfuh8tIteg?t=01h41m05s)

[for like it's it's not always](https://youtu.be/Ctfuh8tIteg?t=01h41m07s)

[developers like to keep everything dry](https://youtu.be/Ctfuh8tIteg?t=01h41m11s)

[because that's what they were taught and](https://youtu.be/Ctfuh8tIteg?t=01h41m13s)

[sometimes I don't know if that's the](https://youtu.be/Ctfuh8tIteg?t=01h41m16s)

[right answer](https://youtu.be/Ctfuh8tIteg?t=01h41m17s)

[okay list box 30 step](https://youtu.be/Ctfuh8tIteg?t=01h41m20s)

[same song another verse uh let's see](https://youtu.be/Ctfuh8tIteg?t=01h41m23s)

[here here](https://youtu.be/Ctfuh8tIteg?t=01h41m27s)

[um but yes at some point once I get scur](https://youtu.be/Ctfuh8tIteg?t=01h41m32s)

[day actually working I want to go](https://youtu.be/Ctfuh8tIteg?t=01h41m35s)

[through and do it the other thing that](https://youtu.be/Ctfuh8tIteg?t=01h41m37s)

[that bit me is](https://youtu.be/Ctfuh8tIteg?t=01h41m39s)

[I built score a day and I was playing](https://youtu.be/Ctfuh8tIteg?t=01h41m41s)

[with I think it was just regular](https://youtu.be/Ctfuh8tIteg?t=01h41m44s)

[squirrel at first](https://youtu.be/Ctfuh8tIteg?t=01h41m46s)

[and regular squirrel it's update EXE](https://youtu.be/Ctfuh8tIteg?t=01h41m47s)

[bootstrapper](https://youtu.be/Ctfuh8tIteg?t=01h41m50s)

[there was something up with it that I](https://youtu.be/Ctfuh8tIteg?t=01h41m51s)

[was getting bit and Windows Defender was](https://youtu.be/Ctfuh8tIteg?t=01h41m54s)

[deleting it on me and it was real and it](https://youtu.be/Ctfuh8tIteg?t=01h41m57s)

[took me so long to figure out why things](https://youtu.be/Ctfuh8tIteg?t=01h42m00s)

[weren't working](https://youtu.be/Ctfuh8tIteg?t=01h42m01s)

[because](https://youtu.be/Ctfuh8tIteg?t=01h42m03s)

[Windows Defender was like oh that's a](https://youtu.be/Ctfuh8tIteg?t=01h42m04s)

[virus I'm going to burn it down I'm like](https://youtu.be/Ctfuh8tIteg?t=01h42m06s)

[what the](https://youtu.be/Ctfuh8tIteg?t=01h42m08s)

[end to its credit it keeps working just](https://youtu.be/Ctfuh8tIteg?t=01h42m09s)

[fine with that file gone it just](https://youtu.be/Ctfuh8tIteg?t=01h42m12s)

[you know as trouble updating because the](https://youtu.be/Ctfuh8tIteg?t=01h42m14s)

[bootstrapper for the update is gone](https://youtu.be/Ctfuh8tIteg?t=01h42m17s)

[really annoying](https://youtu.be/Ctfuh8tIteg?t=01h42m20s)

[but](https://youtu.be/Ctfuh8tIteg?t=01h42m23s)

[Cloud squirrel 3 doesn't have that](https://youtu.be/Ctfuh8tIteg?t=01h42m25s)

[problem because it got the mechanism by](https://youtu.be/Ctfuh8tIteg?t=01h42m27s)

[which it works is much cleaner](https://youtu.be/Ctfuh8tIteg?t=01h42m29s)

[um Casey went through and redid a bunch](https://youtu.be/Ctfuh8tIteg?t=01h42m32s)

[of it I even helped out with uh on the](https://youtu.be/Ctfuh8tIteg?t=01h42m35s)

[cloud squirrel 3 the CLI app because](https://youtu.be/Ctfuh8tIteg?t=01h42m39s)

[there's a global tool for it](https://youtu.be/Ctfuh8tIteg?t=01h42m41s)

[um I did the Rev that updated it to](https://youtu.be/Ctfuh8tIteg?t=01h42m44s)

[system command line](https://youtu.be/Ctfuh8tIteg?t=01h42m46s)

[so there was a bit of that which was](https://youtu.be/Ctfuh8tIteg?t=01h42m48s)

[which was fun and and interesting and uh](https://youtu.be/Ctfuh8tIteg?t=01h42m50s)

[it was fun to at least contribute a](https://youtu.be/Ctfuh8tIteg?t=01h42m52s)

[little bit to it](https://youtu.be/Ctfuh8tIteg?t=01h42m55s)

[uh okay I already forgot what was it](https://youtu.be/Ctfuh8tIteg?t=01h42m56s)

[What's My Line number 37.](https://youtu.be/Ctfuh8tIteg?t=01h42m59s)

[37 so this one here](https://youtu.be/Ctfuh8tIteg?t=01h43m03s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h43m07s)

[list box item the border is the hover](https://youtu.be/Ctfuh8tIteg?t=01h43m09s)

[background](https://youtu.be/Ctfuh8tIteg?t=01h43m12s)

[this is probably a good case to just do](https://youtu.be/Ctfuh8tIteg?t=01h43m14s)

[list box item](https://youtu.be/Ctfuh8tIteg?t=01h43m19s)

[border](https://youtu.be/Ctfuh8tIteg?t=01h43m24s)

[oh this is interesting](https://youtu.be/Ctfuh8tIteg?t=01h43m30s)

[I should probably do it as list box item](https://youtu.be/Ctfuh8tIteg?t=01h43m33s)

[I'm only hesitating here because I think](https://youtu.be/Ctfuh8tIteg?t=01h43m39s)

[on some of the other ones I did it is](https://youtu.be/Ctfuh8tIteg?t=01h43m41s)

[the parent control which is generally](https://youtu.be/Ctfuh8tIteg?t=01h43m42s)

[list box this one gets awkward because](https://youtu.be/Ctfuh8tIteg?t=01h43m45s)

[list view is a thing as well](https://youtu.be/Ctfuh8tIteg?t=01h43m48s)

[hmm I think it's better to do this as](https://youtu.be/Ctfuh8tIteg?t=01h43m52s)

[list box item](https://youtu.be/Ctfuh8tIteg?t=01h43m55s)

[yeah I think material design brush list](https://youtu.be/Ctfuh8tIteg?t=01h44m00s)

[box item](https://youtu.be/Ctfuh8tIteg?t=01h44m04s)

[dot border makes the most sense](https://youtu.be/Ctfuh8tIteg?t=01h44m05s)

[yeah yeah let's do that oh we want the](https://youtu.be/Ctfuh8tIteg?t=01h44m10s)

[uh text box](https://youtu.be/Ctfuh8tIteg?t=01h44m16s)

[of her background but um](https://youtu.be/Ctfuh8tIteg?t=01h44m19s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h44m22s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h44m23s)

[uh have you figured out a good GitHub](https://youtu.be/Ctfuh8tIteg?t=01h44m30s)

[action template yet to share bits](https://youtu.be/Ctfuh8tIteg?t=01h44m33s)

[between repos](https://youtu.be/Ctfuh8tIteg?t=01h44m34s)

[uh because I like the idea but I haven't](https://youtu.be/Ctfuh8tIteg?t=01h44m36s)

[found it worthwhile enough to actually](https://youtu.be/Ctfuh8tIteg?t=01h44m38s)

[build it out](https://youtu.be/Ctfuh8tIteg?t=01h44m40s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h44m42s)

[Benjamin can you explain further I'm not](https://youtu.be/Ctfuh8tIteg?t=01h44m45s)

[sure I understand the question](https://youtu.be/Ctfuh8tIteg?t=01h44m48s)

[what do you mean by share between repos](https://youtu.be/Ctfuh8tIteg?t=01h44m50s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h44m54s)

[there](https://youtu.be/Ctfuh8tIteg?t=01h45m00s)

[this box item](https://youtu.be/Ctfuh8tIteg?t=01h45m03s)

[order](https://youtu.be/Ctfuh8tIteg?t=01h45m06s)

[run the keys down](https://youtu.be/Ctfuh8tIteg?t=01h45m09s)

[and then I go here](https://youtu.be/Ctfuh8tIteg?t=01h45m13s)

[and I go here](https://youtu.be/Ctfuh8tIteg?t=01h45m16s)

[and go here](https://youtu.be/Ctfuh8tIteg?t=01h45m19s)

[and then we go and check what is](https://youtu.be/Ctfuh8tIteg?t=01h45m22s)

[else is in this file](https://youtu.be/Ctfuh8tIteg?t=01h45m26s)

[that's the only comment](https://youtu.be/Ctfuh8tIteg?t=01h45m29s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h45m31s)

[oh you could create actions that could](https://youtu.be/Ctfuh8tIteg?t=01h45m33s)

[be reused as steps](https://youtu.be/Ctfuh8tIteg?t=01h45m35s)

[um yes I think though in this case](https://youtu.be/Ctfuh8tIteg?t=01h45m38s)

[uh like reusing workflows or at least](https://youtu.be/Ctfuh8tIteg?t=01h45m42s)

[Parts like the Evo Ops does decently](https://youtu.be/Ctfuh8tIteg?t=01h45m46s)

[well](https://youtu.be/Ctfuh8tIteg?t=01h45m48s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h45m49s)

[so there's a couple layers to that that](https://youtu.be/Ctfuh8tIteg?t=01h45m53s)

[gets that get weird right like GitHub](https://youtu.be/Ctfuh8tIteg?t=01h45m55s)

[actions they've been very clear is not](https://youtu.be/Ctfuh8tIteg?t=01h45m58s)

[devops and that the two things attack](https://youtu.be/Ctfuh8tIteg?t=01h46m00s)

[differently because devops has the](https://youtu.be/Ctfuh8tIteg?t=01h46m02s)

[templating concept which is very much](https://youtu.be/Ctfuh8tIteg?t=01h46m05s)

[it's kind of like the C plus](https://youtu.be/Ctfuh8tIteg?t=01h46m09s)

[preprocessor it takes your input file](https://youtu.be/Ctfuh8tIteg?t=01h46m10s)

[rips it through functionally generates](https://youtu.be/Ctfuh8tIteg?t=01h46m13s)

[out a new blocky yaml and then runs that](https://youtu.be/Ctfuh8tIteg?t=01h46m16s)

[that's kind of the way the templates](https://youtu.be/Ctfuh8tIteg?t=01h46m18s)

[work whereas GitHub actions they don't](https://youtu.be/Ctfuh8tIteg?t=01h46m21s)

[have templates](https://youtu.be/Ctfuh8tIteg?t=01h46m23s)

[but that doesn't mean you have to like](https://youtu.be/Ctfuh8tIteg?t=01h46m25s)

[uh repeat yourself with your yaml](https://youtu.be/Ctfuh8tIteg?t=01h46m27s)

[there's just other ways to attack it](https://youtu.be/Ctfuh8tIteg?t=01h46m30s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h46m33s)

[and I think the hardest part for me is I](https://youtu.be/Ctfuh8tIteg?t=01h46m38s)

[have yet to come up with a good system](https://youtu.be/Ctfuh8tIteg?t=01h46m41s)

[at least from the GitHub action side](https://youtu.be/Ctfuh8tIteg?t=01h46m46s)

[that I like](https://youtu.be/Ctfuh8tIteg?t=01h46m49s)

[because I don't necessarily know](https://youtu.be/Ctfuh8tIteg?t=01h46m53s)

[like I will generally copy my my GitHub](https://youtu.be/Ctfuh8tIteg?t=01h46m56s)

[action around](https://youtu.be/Ctfuh8tIteg?t=01h46m58s)

[but there are a few things that are very](https://youtu.be/Ctfuh8tIteg?t=01h47m00s)

[hyper specific](https://youtu.be/Ctfuh8tIteg?t=01h47m04s)

[to the the app and the domain for what](https://youtu.be/Ctfuh8tIteg?t=01h47m06s)

[it is like for example even on my](https://youtu.be/Ctfuh8tIteg?t=01h47m09s)

[so if we go and look here because this](https://youtu.be/Ctfuh8tIteg?t=01h47m14s)

[is one of the areas where I where I was](https://youtu.be/Ctfuh8tIteg?t=01h47m16s)

[contemplating doing it uh is on my on my](https://youtu.be/Ctfuh8tIteg?t=01h47m18s)

[templates right so if we take the](https://youtu.be/Ctfuh8tIteg?t=01h47m22s)

[um the nuget one for example right this](https://youtu.be/Ctfuh8tIteg?t=01h47m25s)

[the my nougat template I actually](https://youtu.be/Ctfuh8tIteg?t=01h47m28s)

[include a](https://youtu.be/Ctfuh8tIteg?t=01h47m30s)

[um GitHub action in here](https://youtu.be/Ctfuh8tIteg?t=01h47m33s)

[right as a starting point and the only](https://youtu.be/Ctfuh8tIteg?t=01h47m35s)

[reason I can do this is because this is](https://youtu.be/Ctfuh8tIteg?t=01h47m38s)

[a solution level template and you you](https://youtu.be/Ctfuh8tIteg?t=01h47m40s)

[get all the things out of the gate right](https://youtu.be/Ctfuh8tIteg?t=01h47m42s)

[and this is sort of in a state where I](https://youtu.be/Ctfuh8tIteg?t=01h47m45s)

[think this is kind of like](https://youtu.be/Ctfuh8tIteg?t=01h47m47s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h47m51s)

[oh look at that there's a bug in it](https://youtu.be/Ctfuh8tIteg?t=01h47m51s)

[see this is this is why I shouldn't be](https://youtu.be/Ctfuh8tIteg?t=01h47m56s)

[allowed dang NAB it now I gotta fix it I](https://youtu.be/Ctfuh8tIteg?t=01h47m57s)

[can't I can't let a bug sit while I know](https://youtu.be/Ctfuh8tIteg?t=01h48m00s)

[about it](https://youtu.be/Ctfuh8tIteg?t=01h48m01s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h48m03s)

[uh upload](https://youtu.be/Ctfuh8tIteg?t=01h48m05s)

[uh you get hard to have fat](https://youtu.be/Ctfuh8tIteg?t=01h48m08s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h48m13s)

[the](https://youtu.be/Ctfuh8tIteg?t=01h48m18s)

[CH now I gotta look at this real quick](https://youtu.be/Ctfuh8tIteg?t=01h48m21s)

[to make sure](https://youtu.be/Ctfuh8tIteg?t=01h48m22s)

[yeah uh let's see](https://youtu.be/Ctfuh8tIteg?t=01h48m25s)

[fixing step name](https://youtu.be/Ctfuh8tIteg?t=01h48m29s)

[uh commit directly uh bypass rules and](https://youtu.be/Ctfuh8tIteg?t=01h48m32s)

[commit changes yeah just just do it I](https://youtu.be/Ctfuh8tIteg?t=01h48m36s)

[don't wanna I don't wanna think too hard](https://youtu.be/Ctfuh8tIteg?t=01h48m38s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h48m41s)

[so there is there is a some interesting](https://youtu.be/Ctfuh8tIteg?t=01h48m42s)

[stuff around here for doing that I just](https://youtu.be/Ctfuh8tIteg?t=01h48m45s)

[I I still have yet to determine what is](https://youtu.be/Ctfuh8tIteg?t=01h48m52s)

[the the state that I like right because](https://youtu.be/Ctfuh8tIteg?t=01h48m55s)

[with all of these things like because Mr](https://youtu.be/Ctfuh8tIteg?t=01h48m58s)

[X calls out you know you can make your](https://youtu.be/Ctfuh8tIteg?t=01h49m01s)

[own steps you can do all these things to](https://youtu.be/Ctfuh8tIteg?t=01h49m03s)

[share out your yaml](https://youtu.be/Ctfuh8tIteg?t=01h49m05s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h49m08s)

[and then](https://youtu.be/Ctfuh8tIteg?t=01h49m11s)

[going through and doing it](https://youtu.be/Ctfuh8tIteg?t=01h49m13s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h49m16s)

[yeah I see what you're saying you you](https://youtu.be/Ctfuh8tIteg?t=01h49m21s)

[effectively want to automate your way](https://youtu.be/Ctfuh8tIteg?t=01h49m23s)

[and I think the hard part is](https://youtu.be/Ctfuh8tIteg?t=01h49m25s)

[depending on what the change is some of](https://youtu.be/Ctfuh8tIteg?t=01h49m27s)

[that can be automated](https://youtu.be/Ctfuh8tIteg?t=01h49m30s)

[some of it can't be like](https://youtu.be/Ctfuh8tIteg?t=01h49m32s)

[if you knew you had 10 plus repos that](https://youtu.be/Ctfuh8tIteg?t=01h49m37s)

[were all using this same yaml file](https://youtu.be/Ctfuh8tIteg?t=01h49m39s)

[um it would be fairly trivial to to](https://youtu.be/Ctfuh8tIteg?t=01h49m43s)

[basically run the](https://youtu.be/Ctfuh8tIteg?t=01h49m46s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h49m50s)

[so one say hypothetically you'd build 10](https://youtu.be/Ctfuh8tIteg?t=01h49m51s)

[repos using this and I just fixed the](https://youtu.be/Ctfuh8tIteg?t=01h49m54s)

[name of this step and you're like oh](https://youtu.be/Ctfuh8tIteg?t=01h49m56s)

[shoot I've got that same thing in all 10](https://youtu.be/Ctfuh8tIteg?t=01h49m57s)

[of my repos right you could pull the](https://youtu.be/Ctfuh8tIteg?t=01h49m59s)

[latest template](https://youtu.be/Ctfuh8tIteg?t=01h50m02s)

[run.net new uh you know dash dash Force](https://youtu.be/Ctfuh8tIteg?t=01h50m04s)

[apply the template and then get revert](https://youtu.be/Ctfuh8tIteg?t=01h50m07s)

[everything that's not this file right](https://youtu.be/Ctfuh8tIteg?t=01h50m10s)

[that's something that's easily](https://youtu.be/Ctfuh8tIteg?t=01h50m12s)

[scriptable but it's I think because the](https://youtu.be/Ctfuh8tIteg?t=01h50m13s)

[types of changes are going to be so](https://youtu.be/Ctfuh8tIteg?t=01h50m16s)

[dynamic](https://youtu.be/Ctfuh8tIteg?t=01h50m18s)

[like I agree it would be nice to have](https://youtu.be/Ctfuh8tIteg?t=01h50m19s)

[things at a top level](https://youtu.be/Ctfuh8tIteg?t=01h50m21s)

[but it requires a level of templating](https://youtu.be/Ctfuh8tIteg?t=01h50m23s)

[where there's not really any](https://youtu.be/Ctfuh8tIteg?t=01h50m27s)

[infrastructure built in place and I](https://youtu.be/Ctfuh8tIteg?t=01h50m29s)

[think that's why the GitHub CLI is kind](https://youtu.be/Ctfuh8tIteg?t=01h50m31s)

[of exists is because](https://youtu.be/Ctfuh8tIteg?t=01h50m34s)

[the intent is to try to encourage people](https://youtu.be/Ctfuh8tIteg?t=01h50m36s)

[to be able to build the edits that they](https://youtu.be/Ctfuh8tIteg?t=01h50m39s)

[want rather than expecting them all to](https://youtu.be/Ctfuh8tIteg?t=01h50m42s)

[be handled](https://youtu.be/Ctfuh8tIteg?t=01h50m44s)

[because if they at least leave the the](https://youtu.be/Ctfuh8tIteg?t=01h50m47s)

[hooks for people to build their own](https://youtu.be/Ctfuh8tIteg?t=01h50m50s)

[automation they'll go through and do it](https://youtu.be/Ctfuh8tIteg?t=01h50m51s)

[depending on what the task is and I](https://youtu.be/Ctfuh8tIteg?t=01h50m53s)

[think that's the key](https://youtu.be/Ctfuh8tIteg?t=01h50m55s)

[depending on what the task is](https://youtu.be/Ctfuh8tIteg?t=01h50m57s)

[because the task may not be uh](https://youtu.be/Ctfuh8tIteg?t=01h50m59s)

[straightforward](https://youtu.be/Ctfuh8tIteg?t=01h51m03s)

[boom](https://youtu.be/Ctfuh8tIteg?t=01h51m04s)

[can I just say how much I love being](https://youtu.be/Ctfuh8tIteg?t=01h51m06s)

[able to have my brushes gend like that](https://youtu.be/Ctfuh8tIteg?t=01h51m08s)

[like being able to have all my theme](https://youtu.be/Ctfuh8tIteg?t=01h51m14s)

[brushes](https://youtu.be/Ctfuh8tIteg?t=01h51m17s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h51m20s)

[oh is there some sharing of actions or](https://youtu.be/Ctfuh8tIteg?t=01h51m25s)

[action variables possible with the user](https://youtu.be/Ctfuh8tIteg?t=01h51m27s)

[Global GitHub repo one can create](https://youtu.be/Ctfuh8tIteg?t=01h51m30s)

[I](https://youtu.be/Ctfuh8tIteg?t=01h51m39s)

[don't think so there is a concept](https://youtu.be/Ctfuh8tIteg?t=01h51m41s)

[because GitHub actions are literally](https://youtu.be/Ctfuh8tIteg?t=01h51m43s)

[just GitHub repos with tags there is](https://youtu.be/Ctfuh8tIteg?t=01h51m46s)

[some stuff around](https://youtu.be/Ctfuh8tIteg?t=01h51m50s)

[and this is usually around GitHub](https://youtu.be/Ctfuh8tIteg?t=01h51m52s)

[Enterprise so I don't know how much of](https://youtu.be/Ctfuh8tIteg?t=01h51m54s)

[this is in like regular free accounts](https://youtu.be/Ctfuh8tIteg?t=01h51m56s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h51m59s)

[but there is this concept of being able](https://youtu.be/Ctfuh8tIteg?t=01h52m00s)

[to effectively like build out some](https://youtu.be/Ctfuh8tIteg?t=01h52m02s)

[shared policies and actions in that](https://youtu.be/Ctfuh8tIteg?t=01h52m04s)

[regard](https://youtu.be/Ctfuh8tIteg?t=01h52m07s)

[but at the end of the day the apps](https://youtu.be/Ctfuh8tIteg?t=01h52m08s)

[consuming them are still](https://youtu.be/Ctfuh8tIteg?t=01h52m10s)

[they're basically using the either the](https://youtu.be/Ctfuh8tIteg?t=01h52m13s)

[reusable workflows or the action syntax](https://youtu.be/Ctfuh8tIteg?t=01h52m15s)

[inside of the the repos](https://youtu.be/Ctfuh8tIteg?t=01h52m18s)

[workflow to reach back across to go and](https://youtu.be/Ctfuh8tIteg?t=01h52m21s)

[get it](https://youtu.be/Ctfuh8tIteg?t=01h52m24s)

[so there's](https://youtu.be/Ctfuh8tIteg?t=01h52m26s)

[kind of a little bit there](https://youtu.be/Ctfuh8tIteg?t=01h52m28s)

[and again the hard part being that](https://youtu.be/Ctfuh8tIteg?t=01h52m31s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h52m35s)

[yeah reusing workflows](https://youtu.be/Ctfuh8tIteg?t=01h52m38s)

[yeah the](https://youtu.be/Ctfuh8tIteg?t=01h52m41s)

[it's just people people wanted reusable](https://youtu.be/Ctfuh8tIteg?t=01h52m43s)

[workflows to be](https://youtu.be/Ctfuh8tIteg?t=01h52m45s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h52m48s)

[to be.net uh templates and they really](https://youtu.be/Ctfuh8tIteg?t=01h52m50s)

[aren't right so you can kind of get](https://youtu.be/Ctfuh8tIteg?t=01h52m53s)

[this but again the the key thing with](https://youtu.be/Ctfuh8tIteg?t=01h52m57s)

[all of these is](https://youtu.be/Ctfuh8tIteg?t=01h52m59s)

[um your where is the like the uses yeah](https://youtu.be/Ctfuh8tIteg?t=01h53m02s)

[so all of these things](https://youtu.be/Ctfuh8tIteg?t=01h53m05s)

[this is effectively your share right of](https://youtu.be/Ctfuh8tIteg?t=01h53m08s)

[uh owner repo name](https://youtu.be/Ctfuh8tIteg?t=01h53m11s)

[and then the at at](https://youtu.be/Ctfuh8tIteg?t=01h53m14s)

[um get ref](https://youtu.be/Ctfuh8tIteg?t=01h53m17s)

[and the important part is the that this](https://youtu.be/Ctfuh8tIteg?t=01h53m19s)

[is git ref right so it can be Branch](https://youtu.be/Ctfuh8tIteg?t=01h53m21s)

[like in this case it's going to track](https://youtu.be/Ctfuh8tIteg?t=01h53m24s)

[forward with latest Main](https://youtu.be/Ctfuh8tIteg?t=01h53m26s)

[oftentimes we will Point those at tags](https://youtu.be/Ctfuh8tIteg?t=01h53m28s)

[because tags aren't expected to move](https://youtu.be/Ctfuh8tIteg?t=01h53m30s)

[they're expected to be in stationary on](https://youtu.be/Ctfuh8tIteg?t=01h53m31s)

[a given thing](https://youtu.be/Ctfuh8tIteg?t=01h53m33s)

[so it let it lets you go through and pin](https://youtu.be/Ctfuh8tIteg?t=01h53m38s)

[it or yeah shop for if you want an](https://youtu.be/Ctfuh8tIteg?t=01h53m40s)

[individual get uh commit or whatnot so](https://youtu.be/Ctfuh8tIteg?t=01h53m42s)

[you can pin stuff where we're necessary](https://youtu.be/Ctfuh8tIteg?t=01h53m44s)

[so you can kind of get this but it](https://youtu.be/Ctfuh8tIteg?t=01h53m47s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h53m50s)

[yeah](https://youtu.be/Ctfuh8tIteg?t=01h53m53s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h53m56s)

[yeah it is one of those things that I I](https://youtu.be/Ctfuh8tIteg?t=01h53m57s)

[think sometimes we also forget how](https://youtu.be/Ctfuh8tIteg?t=01h54m00s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h54m04s)

[there's one more GitHub actions released](https://youtu.be/Ctfuh8tIteg?t=01h54m07s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h54m10s)

[uh that's on May 10th of what year](https://youtu.be/Ctfuh8tIteg?t=01h54m13s)

[please](https://youtu.be/Ctfuh8tIteg?t=01h54m16s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=01h54m20s)

[um what was the](https://youtu.be/Ctfuh8tIteg?t=01h54m21s)

[foreign](https://youtu.be/Ctfuh8tIteg?t=01h54m24s)

[so it's all it's also worth remembering](https://youtu.be/Ctfuh8tIteg?t=01h54m27s)

[that GitHub actions are kind of one of](https://youtu.be/Ctfuh8tIteg?t=01h54m30s)

[the New Kids on the Block](https://youtu.be/Ctfuh8tIteg?t=01h54m33s)

[like if you compare them with when](https://youtu.be/Ctfuh8tIteg?t=01h54m34s)

[devops was released or](https://youtu.be/Ctfuh8tIteg?t=01h54m36s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h54m39s)

[app there or any of the other big ones](https://youtu.be/Ctfuh8tIteg?t=01h54m40s)

[that have been around](https://youtu.be/Ctfuh8tIteg?t=01h54m42s)

[they're the they're kind of playing](https://youtu.be/Ctfuh8tIteg?t=01h54m45s)

[catch-up to a lot of people like there's](https://youtu.be/Ctfuh8tIteg?t=01h54m47s)

[a lot of features that most the other](https://youtu.be/Ctfuh8tIteg?t=01h54m49s)

[systems have had years to implement](https://youtu.be/Ctfuh8tIteg?t=01h54m51s)

[and](https://youtu.be/Ctfuh8tIteg?t=01h54m54s)

[yeah even GitHub environments are less](https://youtu.be/Ctfuh8tIteg?t=01h54m57s)

[than three years old yeah so they are](https://youtu.be/Ctfuh8tIteg?t=01h54m59s)

[GitHub actions are advancing really](https://youtu.be/Ctfuh8tIteg?t=01h55m01s)

[rapidly considering that because I think](https://youtu.be/Ctfuh8tIteg?t=01h55m03s)

[they they came into the game](https://youtu.be/Ctfuh8tIteg?t=01h55m06s)

[understanding](https://youtu.be/Ctfuh8tIteg?t=01h55m07s)

[like we're uniquely positioned to make](https://youtu.be/Ctfuh8tIteg?t=01h55m09s)

[this awesome but we're also years behind](https://youtu.be/Ctfuh8tIteg?t=01h55m12s)

[the competition](https://youtu.be/Ctfuh8tIteg?t=01h55m15s)

[like that whole idea of first to market](https://youtu.be/Ctfuh8tIteg?t=01h55m16s)

[wins yeah GitHub did not adhere to that](https://youtu.be/Ctfuh8tIteg?t=01h55m18s)

[they just went you know what I guess](https://youtu.be/Ctfuh8tIteg?t=01h55m21s)

[we're going for it](https://youtu.be/Ctfuh8tIteg?t=01h55m22s)

[uh oh if you don't push it it doesn't go](https://youtu.be/Ctfuh8tIteg?t=01h55m25s)

[up uh let's see](https://youtu.be/Ctfuh8tIteg?t=01h55m27s)

[uh let's see here](https://youtu.be/Ctfuh8tIteg?t=01h55m31s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=01h55m33s)

[uh added uh to](https://youtu.be/Ctfuh8tIteg?t=01h55m37s)

[address this](https://youtu.be/Ctfuh8tIteg?t=01h55m40s)

[add single comment](https://youtu.be/Ctfuh8tIteg?t=01h55m42s)

[man I wish this thing wasn't so bloody](https://youtu.be/Ctfuh8tIteg?t=01h55m45s)

[slow every single click](https://youtu.be/Ctfuh8tIteg?t=01h55m47s)

[GitHub definitely slows down when you](https://youtu.be/Ctfuh8tIteg?t=01h55m51s)

[hammer it with things like this](https://youtu.be/Ctfuh8tIteg?t=01h55m54s)

[view like I tried to go through and](https://youtu.be/Ctfuh8tIteg?t=01h55m56s)

[clear out everything that didn't have](https://youtu.be/Ctfuh8tIteg?t=01h55m59s)

[comments so that it was collapsed and](https://youtu.be/Ctfuh8tIteg?t=01h56m00s)

[out of the way and it still is just](https://youtu.be/Ctfuh8tIteg?t=01h56m02s)

[this poor little browser is dragging](https://youtu.be/Ctfuh8tIteg?t=01h56m06s)

[behind so this is going to be list view](https://youtu.be/Ctfuh8tIteg?t=01h56m10s)

[36 so it's just gonna be the next guy](https://youtu.be/Ctfuh8tIteg?t=01h56m12s)

[over right so take me there](https://youtu.be/Ctfuh8tIteg?t=01h56m14s)

[uh boom 36.](https://youtu.be/Ctfuh8tIteg?t=01h56m17s)

[yeah because this is this here is a](https://youtu.be/Ctfuh8tIteg?t=01h56m21s)

[beautiful example of why the old way of](https://youtu.be/Ctfuh8tIteg?t=01h56m23s)

[doing brushes sucked right there's a](https://youtu.be/Ctfuh8tIteg?t=01h56m25s)

[border in that's what is that one two](https://youtu.be/Ctfuh8tIteg?t=01h56m29s)

[three four levels deep inside of a](https://youtu.be/Ctfuh8tIteg?t=01h56m32s)

[template on a scroll viewer that's used](https://youtu.be/Ctfuh8tIteg?t=01h56m35s)

[inside of a grid view which is inside of](https://youtu.be/Ctfuh8tIteg?t=01h56m38s)

[a list view so we're at minimum six](https://youtu.be/Ctfuh8tIteg?t=01h56m41s)

[levels deep](https://youtu.be/Ctfuh8tIteg?t=01h56m43s)

[and somebody wants to change the](https://youtu.be/Ctfuh8tIteg?t=01h56m44s)

[background of this guy](https://youtu.be/Ctfuh8tIteg?t=01h56m46s)

[there's not a clean way of doing that](https://youtu.be/Ctfuh8tIteg?t=01h56m48s)

[it's just it you just you're you're host](https://youtu.be/Ctfuh8tIteg?t=01h56m51s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h56m55s)

[so the question though is what should](https://youtu.be/Ctfuh8tIteg?t=01h56m56s)

[this brush be called](https://youtu.be/Ctfuh8tIteg?t=01h56m58s)

[because it is the Border brush](https://youtu.be/Ctfuh8tIteg?t=01h57m01s)

[well this is functionally an underline](https://youtu.be/Ctfuh8tIteg?t=01h57m05s)

[so the way the thickness objects Works](https://youtu.be/Ctfuh8tIteg?t=01h57m07s)

[in WPF right is you kind of if you can](https://youtu.be/Ctfuh8tIteg?t=01h57m09s)

[remember your unit circle](https://youtu.be/Ctfuh8tIteg?t=01h57m11s)

[yeah I'm probably pointing this to rock](https://youtu.be/Ctfuh8tIteg?t=01h57m13s)

[yeah I think my video is right you know](https://youtu.be/Ctfuh8tIteg?t=01h57m17s)

[left top right](https://youtu.be/Ctfuh8tIteg?t=01h57m19s)

[bottom](https://youtu.be/Ctfuh8tIteg?t=01h57m22s)

[sorry I've got so many so many things on](https://youtu.be/Ctfuh8tIteg?t=01h57m25s)

[my camera are like mirrored or inverted](https://youtu.be/Ctfuh8tIteg?t=01h57m27s)

[I sometimes forget which way things are](https://youtu.be/Ctfuh8tIteg?t=01h57m29s)

[pointed](https://youtu.be/Ctfuh8tIteg?t=01h57m31s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h57m32s)

[I think](https://youtu.be/Ctfuh8tIteg?t=01h57m33s)

[I think I'm pointing left for people](https://youtu.be/Ctfuh8tIteg?t=01h57m37s)

[can't remember if my previous inverted](https://youtu.be/Ctfuh8tIteg?t=01h57m40s)

[or not though so I might be perfect](https://youtu.be/Ctfuh8tIteg?t=01h57m41s)

[yes pointed left ah I did get it right](https://youtu.be/Ctfuh8tIteg?t=01h57m43s)

[um](https://youtu.be/Ctfuh8tIteg?t=01h57m47s)

[so the fact that this is only the fourth](https://youtu.be/Ctfuh8tIteg?t=01h57m49s)

[digit means it's the bottom one so this](https://youtu.be/Ctfuh8tIteg?t=01h57m52s)

[is functionally an underline what is](https://youtu.be/Ctfuh8tIteg?t=01h57m53s)

[this doing](https://youtu.be/Ctfuh8tIteg?t=01h57m56s)

[so this is the scroll viewer](https://youtu.be/Ctfuh8tIteg?t=01h57m57s)

[don't care about you this is a grid](https://youtu.be/Ctfuh8tIteg?t=01h58m00s)

[it's a grid with something on the right](https://youtu.be/Ctfuh8tIteg?t=01h58m04s)

[and the bottom](https://youtu.be/Ctfuh8tIteg?t=01h58m06s)

[inside the grid is a dock panel](https://youtu.be/Ctfuh8tIteg?t=01h58m08s)

[got it so the thing on the right is a](https://youtu.be/Ctfuh8tIteg?t=01h58m14s)

[scroll bar the thing on the bottom is a](https://youtu.be/Ctfuh8tIteg?t=01h58m16s)

[scroll bar got it that's that's why](https://youtu.be/Ctfuh8tIteg?t=01h58m18s)

[that's set up the way it is](https://youtu.be/Ctfuh8tIteg?t=01h58m20s)

[got it that makes sense](https://youtu.be/Ctfuh8tIteg?t=01h58m22s)

[the dock panel is in the middle of the](https://youtu.be/Ctfuh8tIteg?t=01h58m25s)

[Grid it's taking up the big](https://youtu.be/Ctfuh8tIteg?t=01h58m28s)

[thingymabobber there](https://youtu.be/Ctfuh8tIteg?t=01h58m31s)

[there is a scroll viewer inside of it](https://youtu.be/Ctfuh8tIteg?t=01h58m33s)

[so this is this is a](https://youtu.be/Ctfuh8tIteg?t=01h58m38s)

[this is a template on a scroll viewer](https://youtu.be/Ctfuh8tIteg?t=01h58m40s)

[that wraps a scroll viewer](https://youtu.be/Ctfuh8tIteg?t=01h58m43s)

[excellent](https://youtu.be/Ctfuh8tIteg?t=01h58m45s)

[there's no way that's confusing to](https://youtu.be/Ctfuh8tIteg?t=01h58m47s)

[anybody and then it puts a small](https://youtu.be/Ctfuh8tIteg?t=01h58m48s)

[underline](https://youtu.be/Ctfuh8tIteg?t=01h58m50s)

[grid view oh I got it so this is the](https://youtu.be/Ctfuh8tIteg?t=01h58m58s)

[header row so this is this is actually a](https://youtu.be/Ctfuh8tIteg?t=01h59m00s)

[separator](https://youtu.be/Ctfuh8tIteg?t=01h59m03s)

[because this creates a](https://youtu.be/Ctfuh8tIteg?t=01h59m11s)

[why do we have this stack panel](https://youtu.be/Ctfuh8tIteg?t=01h59m15s)

[right we have to have a stack panel](https://youtu.be/Ctfuh8tIteg?t=01h59m20s)

[oriented because we have a rectangle](https://youtu.be/Ctfuh8tIteg?t=01h59m22s)

[got it okay so that's why all those are](https://youtu.be/Ctfuh8tIteg?t=01h59m27s)

[there so there's a border around a stack](https://youtu.be/Ctfuh8tIteg?t=01h59m29s)

[panel that has the header rows this is](https://youtu.be/Ctfuh8tIteg?t=01h59m32s)

[the header Rose](https://youtu.be/Ctfuh8tIteg?t=01h59m34s)

[this guy is set up so that it can](https://youtu.be/Ctfuh8tIteg?t=01h59m36s)

[scroll the headers as needed or the](https://youtu.be/Ctfuh8tIteg?t=01h59m40s)

[content as needed because there is the](https://youtu.be/Ctfuh8tIteg?t=01h59m43s)

[content in the middle](https://youtu.be/Ctfuh8tIteg?t=01h59m45s)

[uh](https://youtu.be/Ctfuh8tIteg?t=01h59m50s)

[right okay so](https://youtu.be/Ctfuh8tIteg?t=01h59m55s)

[I'm kind of wondering](https://youtu.be/Ctfuh8tIteg?t=01h59m58s)

[what to call this guy right let's just](https://youtu.be/Ctfuh8tIteg?t=02h00m01s)

[confirm that I'm right that this is in](https://youtu.be/Ctfuh8tIteg?t=02h00m03s)

[fact the separator between the header](https://youtu.be/Ctfuh8tIteg?t=02h00m05s)

[row and the](https://youtu.be/Ctfuh8tIteg?t=02h00m07s)

[um](https://youtu.be/Ctfuh8tIteg?t=02h00m10s)

[and the content beneath it I think](https://youtu.be/Ctfuh8tIteg?t=02h00m11s)

[that's the case](https://youtu.be/Ctfuh8tIteg?t=02h00m13s)

[I think that's the case that should be](https://youtu.be/Ctfuh8tIteg?t=02h00m14s)

[the case all right](https://youtu.be/Ctfuh8tIteg?t=02h00m16s)

[probably maybe](https://youtu.be/Ctfuh8tIteg?t=02h00m19s)

[okay](https://youtu.be/Ctfuh8tIteg?t=02h00m24s)

[it's it's Times Like These I.E 11](https://youtu.be/Ctfuh8tIteg?t=02h00m25s)

[o'clock at night](https://youtu.be/Ctfuh8tIteg?t=02h00m28s)

[when you've only had one can of Mountain](https://youtu.be/Ctfuh8tIteg?t=02h00m29s)

[Dew and you start questioning your](https://youtu.be/Ctfuh8tIteg?t=02h00m31s)

[sanities on list views](https://youtu.be/Ctfuh8tIteg?t=02h00m32s)

[I'm sure it's just me though](https://youtu.be/Ctfuh8tIteg?t=02h00m36s)

[uh](https://youtu.be/Ctfuh8tIteg?t=02h00m38s)

[-huh](https://youtu.be/Ctfuh8tIteg?t=02h00m41s)

[separator line between header and](https://youtu.be/Ctfuh8tIteg?t=02h00m42s)

[content](https://youtu.be/Ctfuh8tIteg?t=02h00m45s)

[I can read a template I'm not as crazy](https://youtu.be/Ctfuh8tIteg?t=02h00m46s)

[as I think I am](https://youtu.be/Ctfuh8tIteg?t=02h00m49s)

[okay](https://youtu.be/Ctfuh8tIteg?t=02h00m52s)

[so](https://youtu.be/Ctfuh8tIteg?t=02h00m54s)

[if that is what it is](https://youtu.be/Ctfuh8tIteg?t=02h00m57s)

[what then is the appropriate name](https://youtu.be/Ctfuh8tIteg?t=02h01m00s)

[because this this style is keyed on grid](https://youtu.be/Ctfuh8tIteg?t=02h01m06s)

[view scroll viewer style so we it's only](https://youtu.be/Ctfuh8tIteg?t=02h01m10s)

[ever going to show up](https://youtu.be/Ctfuh8tIteg?t=02h01m12s)

[I I so I I think](https://youtu.be/Ctfuh8tIteg?t=02h01m17s)

[grid view is the right](https://youtu.be/Ctfuh8tIteg?t=02h01m22s)

[key here](https://youtu.be/Ctfuh8tIteg?t=02h01m25s)

[I'm tempted to call it header separator](https://youtu.be/Ctfuh8tIteg?t=02h01m27s)

[I think because functionally that's what](https://youtu.be/Ctfuh8tIteg?t=02h01m34s)

[it's doing right it's the separator](https://youtu.be/Ctfuh8tIteg?t=02h01m37s)

[between the editor header and the](https://youtu.be/Ctfuh8tIteg?t=02h01m39s)

[content](https://youtu.be/Ctfuh8tIteg?t=02h01m40s)

[is that a good name](https://youtu.be/Ctfuh8tIteg?t=02h01m41s)

[uh the old adage of computer science](https://youtu.be/Ctfuh8tIteg?t=02h01m48s)

[is it a good name is it a good name I do](https://youtu.be/Ctfuh8tIteg?t=02h01m51s)

[not know I do not know I do not know](https://youtu.be/Ctfuh8tIteg?t=02h01m54s)

[um maybe](https://youtu.be/Ctfuh8tIteg?t=02h01m57s)

[uh I think we're gonna go with that](https://youtu.be/Ctfuh8tIteg?t=02h02m01s)

[uh uh grid view comes after grid](https://youtu.be/Ctfuh8tIteg?t=02h02m04s)

[splitter because V comes after s in the](https://youtu.be/Ctfuh8tIteg?t=02h02m08s)

[alphabet last I checked](https://youtu.be/Ctfuh8tIteg?t=02h02m11s)

[so I want that much there](https://youtu.be/Ctfuh8tIteg?t=02h02m17s)

[and then that goes](https://youtu.be/Ctfuh8tIteg?t=02h02m22s)

[there](https://youtu.be/Ctfuh8tIteg?t=02h02m24s)

[also for people who haven't found it uh](https://youtu.be/Ctfuh8tIteg?t=02h02m32s)

[in Windows 10 and 11 if you](https://youtu.be/Ctfuh8tIteg?t=02h02m35s)

[um I don't remember the last time I used](https://youtu.be/Ctfuh8tIteg?t=02h02m37s)

[Ctrl V](https://youtu.be/Ctfuh8tIteg?t=02h02m39s)

[if you train your fingers to move just](https://youtu.be/Ctfuh8tIteg?t=02h02m40s)

[slightly off of the control key onto the](https://youtu.be/Ctfuh8tIteg?t=02h02m43s)

[Windows key and go Windows key V that's](https://youtu.be/Ctfuh8tIteg?t=02h02m45s)

[where you get this cool little paste](https://youtu.be/Ctfuh8tIteg?t=02h02m48s)

[buffer](https://youtu.be/Ctfuh8tIteg?t=02h02m49s)

[think of a bobber and more importantly](https://youtu.be/Ctfuh8tIteg?t=02h02m50s)

[this thing has like paste as plain text](https://youtu.be/Ctfuh8tIteg?t=02h02m52s)

[so because I know I'm not the only one](https://youtu.be/Ctfuh8tIteg?t=02h02m56s)

[who opens up notepad pastes in the rich](https://youtu.be/Ctfuh8tIteg?t=02h02m58s)

[text document just to strip the](https://youtu.be/Ctfuh8tIteg?t=02h03m00s)

[formatting and copy it back out](https://youtu.be/Ctfuh8tIteg?t=02h03m02s)

[you don't have to do that you can just](https://youtu.be/Ctfuh8tIteg?t=02h03m04s)

[come in here and paste this plain text I](https://youtu.be/Ctfuh8tIteg?t=02h03m06s)

[think on Windows 10 these buttons don't](https://youtu.be/Ctfuh8tIteg?t=02h03m09s)

[exist and it's buried underneath the The](https://youtu.be/Ctfuh8tIteg?t=02h03m11s)

[Little Dot there's like a little context](https://youtu.be/Ctfuh8tIteg?t=02h03m13s)

[menu thing that drops from here or](https://youtu.be/Ctfuh8tIteg?t=02h03m15s)

[something it's a slightly different view](https://youtu.be/Ctfuh8tIteg?t=02h03m17s)

[but](https://youtu.be/Ctfuh8tIteg?t=02h03m19s)

[um](https://youtu.be/Ctfuh8tIteg?t=02h03m21s)

[same idea](https://youtu.be/Ctfuh8tIteg?t=02h03m22s)

[uh](https://youtu.be/Ctfuh8tIteg?t=02h03m24s)

[uh let's see here](https://youtu.be/Ctfuh8tIteg?t=02h03m26s)

[rebuild](https://youtu.be/Ctfuh8tIteg?t=02h03m28s)

[and then we're gonna go here gen brush](https://youtu.be/Ctfuh8tIteg?t=02h03m31s)

[and then we come here](https://youtu.be/Ctfuh8tIteg?t=02h03m36s)

[world's a happy place](https://youtu.be/Ctfuh8tIteg?t=02h03m38s)

[adding](https://youtu.be/Ctfuh8tIteg?t=02h03m41s)

[oh did I](https://youtu.be/Ctfuh8tIteg?t=02h03m45s)

[nope I just copied poorly okay the r is](https://youtu.be/Ctfuh8tIteg?t=02h03m53s)

[there](https://youtu.be/Ctfuh8tIteg?t=02h03m55s)

[R is not there see double check that uh](https://youtu.be/Ctfuh8tIteg?t=02h04m00s)

[because that would have been bad](https://youtu.be/Ctfuh8tIteg?t=02h04m04s)

[and in reality I probably should be](https://youtu.be/Ctfuh8tIteg?t=02h04m08s)

[writing UI tests for every single one of](https://youtu.be/Ctfuh8tIteg?t=02h04m10s)

[these cases but](https://youtu.be/Ctfuh8tIteg?t=02h04m12s)

[I kind of just want to get this thing](https://youtu.be/Ctfuh8tIteg?t=02h04m16s)

[merged](https://youtu.be/Ctfuh8tIteg?t=02h04m18s)

[uh let's see](https://youtu.be/Ctfuh8tIteg?t=02h04m19s)

[added](https://youtu.be/Ctfuh8tIteg?t=02h04m24s)

[uh I'll give you the whole brush name](https://youtu.be/Ctfuh8tIteg?t=02h04m27s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=02h04m31s)

[uh there they're there](https://youtu.be/Ctfuh8tIteg?t=02h04m36s)

[uh to](https://youtu.be/Ctfuh8tIteg?t=02h04m39s)

[end all this case](https://youtu.be/Ctfuh8tIteg?t=02h04m42s)

[in some apps Ctrl shift V paste this](https://youtu.be/Ctfuh8tIteg?t=02h04m46s)

[plain text oh that's a good point](https://youtu.be/Ctfuh8tIteg?t=02h04m49s)

[yes](https://youtu.be/Ctfuh8tIteg?t=02h04m52s)

[and power toys is definitely worthwhile](https://youtu.be/Ctfuh8tIteg?t=02h04m54s)

[for anybody who is unfamiliar with that](https://youtu.be/Ctfuh8tIteg?t=02h04m56s)

[thing go get it uh okay so we've got one](https://youtu.be/Ctfuh8tIteg?t=02h04m59s)

[more in here on 155.](https://youtu.be/Ctfuh8tIteg?t=02h05m02s)

[let's go look at 155.](https://youtu.be/Ctfuh8tIteg?t=02h05m06s)

[so this is the grid view item](https://youtu.be/Ctfuh8tIteg?t=02h05m12s)

[see this is where things get weird right](https://youtu.be/Ctfuh8tIteg?t=02h05m16s)

[the grid view still uses list view items](https://youtu.be/Ctfuh8tIteg?t=02h05m19s)

[so do you name the brush](https://youtu.be/Ctfuh8tIteg?t=02h05m24s)

[with list view item](https://youtu.be/Ctfuh8tIteg?t=02h05m26s)

[or do you name it with grid View](https://youtu.be/Ctfuh8tIteg?t=02h05m28s)

[so what do we got here this is once](https://youtu.be/Ctfuh8tIteg?t=02h05m33s)

[again a](https://youtu.be/Ctfuh8tIteg?t=02h05m35s)

[functionally and underline](https://youtu.be/Ctfuh8tIteg?t=02h05m37s)

[so I don't think we call this thing](https://youtu.be/Ctfuh8tIteg?t=02h05m42s)

[underline I think whatever we call this](https://youtu.be/Ctfuh8tIteg?t=02h05m45s)

[thing needs to end with the word](https://youtu.be/Ctfuh8tIteg?t=02h05m49s)

[separator to be in in sync with the](https://youtu.be/Ctfuh8tIteg?t=02h05m51s)

[other thing but do we call it list view](https://youtu.be/Ctfuh8tIteg?t=02h05m53s)

[item separator](https://youtu.be/Ctfuh8tIteg?t=02h05m55s)

[or should it be grid view item](https://youtu.be/Ctfuh8tIteg?t=02h05m58s)

[separator](https://youtu.be/Ctfuh8tIteg?t=02h06m02s)

[would we share this brush between the](https://youtu.be/Ctfuh8tIteg?t=02h06m08s)

[two](https://youtu.be/Ctfuh8tIteg?t=02h06m11s)

[probably not so I think grid view item](https://youtu.be/Ctfuh8tIteg?t=02h06m12s)

[makes more sense](https://youtu.be/Ctfuh8tIteg?t=02h06m15s)

[wait](https://youtu.be/Ctfuh8tIteg?t=02h06m25s)

[set property background](https://youtu.be/Ctfuh8tIteg?t=02h06m28s)

[did that one get called out too](https://youtu.be/Ctfuh8tIteg?t=02h06m34s)

[no that one got missed](https://youtu.be/Ctfuh8tIteg?t=02h06m38s)

[is mouse over hover background](https://youtu.be/Ctfuh8tIteg?t=02h06m44s)

[this is probably worth looking at](https://youtu.be/Ctfuh8tIteg?t=02h06m47s)

[now see this is where I'm I'm torn right](https://youtu.be/Ctfuh8tIteg?t=02h06m54s)

[because like here we're using list view](https://youtu.be/Ctfuh8tIteg?t=02h06m56s)

[do we have](https://youtu.be/Ctfuh8tIteg?t=02h06m59s)

[uh do we have a list view hover already](https://youtu.be/Ctfuh8tIteg?t=02h07m03s)

[just to select it I'm wondering if it](https://youtu.be/Ctfuh8tIteg?t=02h07m13s)

[makes sense](https://youtu.be/Ctfuh8tIteg?t=02h07m16s)

[to do a list view hover and then I'm](https://youtu.be/Ctfuh8tIteg?t=02h07m18s)

[wondering if this should be](https://youtu.be/Ctfuh8tIteg?t=02h07m21s)

[should this be list view item](https://youtu.be/Ctfuh8tIteg?t=02h07m28s)

[we did list box item](https://youtu.be/Ctfuh8tIteg?t=02h07m32s)

[should it be](https://youtu.be/Ctfuh8tIteg?t=02h07m38s)

[should we have the item things just go](https://youtu.be/Ctfuh8tIteg?t=02h07m40s)

[to the top](https://youtu.be/Ctfuh8tIteg?t=02h07m43s)

[I'm wondering if it makes more sense to](https://youtu.be/Ctfuh8tIteg?t=02h07m47s)

[do](https://youtu.be/Ctfuh8tIteg?t=02h07m49s)

[list view separator](https://youtu.be/Ctfuh8tIteg?t=02h07m50s)

[does that make sense](https://youtu.be/Ctfuh8tIteg?t=02h07m57s)

[does that make sense to just group them](https://youtu.be/Ctfuh8tIteg?t=02h08m04s)

[all under the parent naming](https://youtu.be/Ctfuh8tIteg?t=02h08m07s)

[I think it probably does](https://youtu.be/Ctfuh8tIteg?t=02h08m14s)

[I think it probably does](https://youtu.be/Ctfuh8tIteg?t=02h08m18s)

[um let me look at what we gend already](https://youtu.be/Ctfuh8tIteg?t=02h08m28s)

[though](https://youtu.be/Ctfuh8tIteg?t=02h08m30s)

[grid view header separator man that](https://youtu.be/Ctfuh8tIteg?t=02h08m34s)

[that's probably a better name though](https://youtu.be/Ctfuh8tIteg?t=02h08m36s)

[um](https://youtu.be/Ctfuh8tIteg?t=02h08m45s)

[should it be](https://youtu.be/Ctfuh8tIteg?t=02h08m47s)

[trying to decide if it makes more sense](https://youtu.be/Ctfuh8tIteg?t=02h08m52s)

[this one is really going to be specific](https://youtu.be/Ctfuh8tIteg?t=02h09m03s)

[to there](https://youtu.be/Ctfuh8tIteg?t=02h09m06s)

[should this one](https://youtu.be/Ctfuh8tIteg?t=02h09m08s)

[like](https://youtu.be/Ctfuh8tIteg?t=02h09m13s)

[I think we should just do grid views uh](https://youtu.be/Ctfuh8tIteg?t=02h09m16s)

[well I'm torn because if I do this as](https://youtu.be/Ctfuh8tIteg?t=02h09m19s)

[grid View](https://youtu.be/Ctfuh8tIteg?t=02h09m21s)

[because now I'm questioning what we did](https://youtu.be/Ctfuh8tIteg?t=02h09m23s)

[before if this should actually be list](https://youtu.be/Ctfuh8tIteg?t=02h09m24s)

[View](https://youtu.be/Ctfuh8tIteg?t=02h09m26s)

[maybe it should be](https://youtu.be/Ctfuh8tIteg?t=02h09m30s)

[maybe that really should be list View](https://youtu.be/Ctfuh8tIteg?t=02h09m33s)

[and separate it that way](https://youtu.be/Ctfuh8tIteg?t=02h09m39s)

[because the grid view is really](https://youtu.be/Ctfuh8tIteg?t=02h09m47s)

[contained inside the parent list View](https://youtu.be/Ctfuh8tIteg?t=02h09m48s)

[that's probably okay](https://youtu.be/Ctfuh8tIteg?t=02h09m51s)

[probably okay so if we do that now](https://youtu.be/Ctfuh8tIteg?t=02h09m55s)

[you're in the wrong place even so let's](https://youtu.be/Ctfuh8tIteg?t=02h09m57s)

[move you](https://youtu.be/Ctfuh8tIteg?t=02h09m59s)

[because I do have a feeling I'm going to](https://youtu.be/Ctfuh8tIteg?t=02h10m00s)

[end up going through here and](https://youtu.be/Ctfuh8tIteg?t=02h10m02s)

[oh uh that needs to be above](https://youtu.be/Ctfuh8tIteg?t=02h10m05s)

[um I have a feeling I'm gonna be going](https://youtu.be/Ctfuh8tIteg?t=02h10m09s)

[through these and then](https://youtu.be/Ctfuh8tIteg?t=02h10m10s)

[redoing some of these but it's much](https://youtu.be/Ctfuh8tIteg?t=02h10m12s)

[easier to redo them once they're all in](https://youtu.be/Ctfuh8tIteg?t=02h10m15s)

[um so if that's the case](https://youtu.be/Ctfuh8tIteg?t=02h10m18s)

[that then makes the next one much easier](https://youtu.be/Ctfuh8tIteg?t=02h10m21s)

[to determine](https://youtu.be/Ctfuh8tIteg?t=02h10m25s)

[right because it was](https://youtu.be/Ctfuh8tIteg?t=02h10m28s)

[lost my line numbers](https://youtu.be/Ctfuh8tIteg?t=02h10m31s)

[uh let's see collapse no I want](https://youtu.be/Ctfuh8tIteg?t=02h10m36s)

[list View](https://youtu.be/Ctfuh8tIteg?t=02h10m40s)

[lists you header separator and then I'm](https://youtu.be/Ctfuh8tIteg?t=02h10m45s)

[gonna be on 155 for the other one](https://youtu.be/Ctfuh8tIteg?t=02h10m48s)

[so this then becomes](https://youtu.be/Ctfuh8tIteg?t=02h10m55s)

[let's use separator and the question is](https://youtu.be/Ctfuh8tIteg?t=02h10m59s)

[should the header separator](https://youtu.be/Ctfuh8tIteg?t=02h11m03s)

[be a separate brush is it worth](https://youtu.be/Ctfuh8tIteg?t=02h11m06s)

[is it worth that knowledge because that](https://youtu.be/Ctfuh8tIteg?t=02h11m10s)

[was hover background](https://youtu.be/Ctfuh8tIteg?t=02h11m12s)

[that was hover background previously](https://youtu.be/Ctfuh8tIteg?t=02h11m15s)

[they were using the same brush should it](https://youtu.be/Ctfuh8tIteg?t=02h11m17s)

[just be list view separator and used in](https://youtu.be/Ctfuh8tIteg?t=02h11m19s)

[both places](https://youtu.be/Ctfuh8tIteg?t=02h11m21s)

[I'm going to decree the answers yes and](https://youtu.be/Ctfuh8tIteg?t=02h11m25s)

[if we need to split it later we can](https://youtu.be/Ctfuh8tIteg?t=02h11m27s)

[that may be the wrong call](https://youtu.be/Ctfuh8tIteg?t=02h11m31s)

[may be the wrong call but I](https://youtu.be/Ctfuh8tIteg?t=02h11m35s)

[I think](https://youtu.be/Ctfuh8tIteg?t=02h11m41s)

[that works](https://youtu.be/Ctfuh8tIteg?t=02h11m43s)

[right and then this is hover background](https://youtu.be/Ctfuh8tIteg?t=02h11m47s)

[which](https://youtu.be/Ctfuh8tIteg?t=02h11m51s)

[is also the same and I question if it](https://youtu.be/Ctfuh8tIteg?t=02h11m54s)

[should be changed as well](https://youtu.be/Ctfuh8tIteg?t=02h11m57s)

[is that the only one in here](https://youtu.be/Ctfuh8tIteg?t=02h12m01s)

[there's two](https://youtu.be/Ctfuh8tIteg?t=02h12m04s)

[so there's a couple cases uh](https://youtu.be/Ctfuh8tIteg?t=02h12m13s)

[let's see just saw this it may be old](https://youtu.be/Ctfuh8tIteg?t=02h12m17s)

[seems potentially cool I like copilot](https://youtu.be/Ctfuh8tIteg?t=02h12m22s)

[and intellisense](https://youtu.be/Ctfuh8tIteg?t=02h12m24s)

[uh](https://youtu.be/Ctfuh8tIteg?t=02h12m26s)

[uh](https://youtu.be/Ctfuh8tIteg?t=02h12m28s)

[I did a copilot predictions not only](https://youtu.be/Ctfuh8tIteg?t=02h12m37s)

[uh](https://youtu.be/Ctfuh8tIteg?t=02h12m40s)

[I feel like I saw this when was this](https://youtu.be/Ctfuh8tIteg?t=02h13m00s)

[posted](https://youtu.be/Ctfuh8tIteg?t=02h13m02s)

[June 8th](https://youtu.be/Ctfuh8tIteg?t=02h13m04s)

[so old news but yeah old news only if](https://youtu.be/Ctfuh8tIteg?t=02h13m06s)

[you are at um](https://youtu.be/Ctfuh8tIteg?t=02h13m09s)

[I haven't picked it up I I saw stuff](https://youtu.be/Ctfuh8tIteg?t=02h13m12s)

[about this this has been getting really](https://youtu.be/Ctfuh8tIteg?t=02h13m14s)

[good the one area that has not gotten](https://youtu.be/Ctfuh8tIteg?t=02h13m16s)

[better that I wish would get more love](https://youtu.be/Ctfuh8tIteg?t=02h13m19s)

[would be the](https://youtu.be/Ctfuh8tIteg?t=02h13m21s)

[um](https://youtu.be/Ctfuh8tIteg?t=02h13m23s)

[the xaml designer I try to use copilot](https://youtu.be/Ctfuh8tIteg?t=02h13m24s)

[with xaml is](https://youtu.be/Ctfuh8tIteg?t=02h13m29s)

[sort of miserable because the the](https://youtu.be/Ctfuh8tIteg?t=02h13m31s)

[keyboard shortcut interaction between](https://youtu.be/Ctfuh8tIteg?t=02h13m33s)

[taking the co-pilot suggestion taking](https://youtu.be/Ctfuh8tIteg?t=02h13m35s)

[the intellisense suggestion or Closing](https://youtu.be/Ctfuh8tIteg?t=02h13m37s)

[one or the other to do your own thing is](https://youtu.be/Ctfuh8tIteg?t=02h13m39s)

[it's difficult on the keyboard let's put](https://youtu.be/Ctfuh8tIteg?t=02h13m43s)

[it that way](https://youtu.be/Ctfuh8tIteg?t=02h13m46s)

[[Music]](https://youtu.be/Ctfuh8tIteg?t=02h13m48s)

[um](https://youtu.be/Ctfuh8tIteg?t=02h13m48s)

[I'm gonna ignore both of these for now](https://youtu.be/Ctfuh8tIteg?t=02h13m49s)

[maybe I should address them](https://youtu.be/Ctfuh8tIteg?t=02h13m54s)

[they're both using this](https://youtu.be/Ctfuh8tIteg?t=02h13m56s)

[it weirds me out that these were both](https://youtu.be/Ctfuh8tIteg?t=02h14m02s)

[using the same brushes](https://youtu.be/Ctfuh8tIteg?t=02h14m04s)

[um](https://youtu.be/Ctfuh8tIteg?t=02h14m13s)

[maybe we'll do this here](https://youtu.be/Ctfuh8tIteg?t=02h14m14s)

[and I think they should have](https://youtu.be/Ctfuh8tIteg?t=02h14m17s)

[uh this should be](https://youtu.be/Ctfuh8tIteg?t=02h14m21s)

[list view hover](https://youtu.be/Ctfuh8tIteg?t=02h14m24s)

[right so we're going to go there](https://youtu.be/Ctfuh8tIteg?t=02h14m28s)

[um](https://youtu.be/Ctfuh8tIteg?t=02h14m32s)

[and I'm tempted to give this thing a](https://youtu.be/Ctfuh8tIteg?t=02h14m36s)

[different key but I think I might just](https://youtu.be/Ctfuh8tIteg?t=02h14m40s)

[keep it as list view hover](https://youtu.be/Ctfuh8tIteg?t=02h14m42s)

[for now](https://youtu.be/Ctfuh8tIteg?t=02h14m44s)

[these two may need to be separated but I](https://youtu.be/Ctfuh8tIteg?t=02h14m46s)

[don't think I I haven't this isn't one](https://youtu.be/Ctfuh8tIteg?t=02h14m48s)

[of those things where I remember seeing](https://youtu.be/Ctfuh8tIteg?t=02h14m51s)

[a lot of people requesting that feature](https://youtu.be/Ctfuh8tIteg?t=02h14m53s)

[wow](https://youtu.be/Ctfuh8tIteg?t=02h15m04s)

[user mapped section open there's](https://youtu.be/Ctfuh8tIteg?t=02h15m07s)

[something you don't see every day](https://youtu.be/Ctfuh8tIteg?t=02h15m09s)

[uh pretty confident](https://youtu.be/Ctfuh8tIteg?t=02h15m12s)

[it's the Kraken doing that let's just](https://youtu.be/Ctfuh8tIteg?t=02h15m15s)

[rerun](https://youtu.be/Ctfuh8tIteg?t=02h15m17s)

[yeah timing's everything don't touch the](https://youtu.be/Ctfuh8tIteg?t=02h15m19s)

[file while somebody else is touching it](https://youtu.be/Ctfuh8tIteg?t=02h15m22s)

[got it](https://youtu.be/Ctfuh8tIteg?t=02h15m24s)

[uh let's make sure we got those and](https://youtu.be/Ctfuh8tIteg?t=02h15m26s)

[those in place](https://youtu.be/Ctfuh8tIteg?t=02h15m28s)

[okay let's see](https://youtu.be/Ctfuh8tIteg?t=02h15m32s)

[adding new list view brushes I should](https://youtu.be/Ctfuh8tIteg?t=02h15m36s)

[double check and confirm that that is in](https://youtu.be/Ctfuh8tIteg?t=02h15m41s)

[fact](https://youtu.be/Ctfuh8tIteg?t=02h15m43s)

[the end of the comments on that which](https://youtu.be/Ctfuh8tIteg?t=02h15m45s)

[they are](https://youtu.be/Ctfuh8tIteg?t=02h15m47s)

[um](https://youtu.be/Ctfuh8tIteg?t=02h15m50s)

[okay so let's reply here](https://youtu.be/Ctfuh8tIteg?t=02h15m55s)

[uh this needs to be edited](https://youtu.be/Ctfuh8tIteg?t=02h15m59s)

[because I changed my mind on how we're](https://youtu.be/Ctfuh8tIteg?t=02h16m01s)

[going to do that](https://youtu.be/Ctfuh8tIteg?t=02h16m04s)

[um](https://youtu.be/Ctfuh8tIteg?t=02h16m07s)

[this needs to be here](https://youtu.be/Ctfuh8tIteg?t=02h16m08s)

[this needs to be](https://youtu.be/Ctfuh8tIteg?t=02h16m11s)

[here](https://youtu.be/Ctfuh8tIteg?t=02h16m14s)

[update comment](https://youtu.be/Ctfuh8tIteg?t=02h16m15s)

[and then go here](https://youtu.be/Ctfuh8tIteg?t=02h16m18s)

[um uh](https://youtu.be/Ctfuh8tIteg?t=02h16m24s)

[to handle this case and the other ones](https://youtu.be/Ctfuh8tIteg?t=02h16m34s)

[didn't get commented on so they don't](https://youtu.be/Ctfuh8tIteg?t=02h16m37s)

[matter](https://youtu.be/Ctfuh8tIteg?t=02h16m38s)

[um because there's nothing to resolve](https://youtu.be/Ctfuh8tIteg?t=02h16m41s)

[commit and push](https://youtu.be/Ctfuh8tIteg?t=02h16m43s)

[and resolve conversation](https://youtu.be/Ctfuh8tIteg?t=02h16m47s)

[resolve conversation and there's yet](https://youtu.be/Ctfuh8tIteg?t=02h16m50s)

[another one down](https://youtu.be/Ctfuh8tIteg?t=02h16m52s)

[okay slow going](https://youtu.be/Ctfuh8tIteg?t=02h16m54s)

[we're getting there though we're getting](https://youtu.be/Ctfuh8tIteg?t=02h16m57s)

[there there's only there's only a](https://youtu.be/Ctfuh8tIteg?t=02h16m58s)

[handful more of these guys to address](https://youtu.be/Ctfuh8tIteg?t=02h17m00s)

[and I](https://youtu.be/Ctfuh8tIteg?t=02h17m02s)

[hopefully we'll get time to try and take](https://youtu.be/Ctfuh8tIteg?t=02h17m04s)

[them out again](https://youtu.be/Ctfuh8tIteg?t=02h17m06s)

[um but I can feel myself fading it's 11](https://youtu.be/Ctfuh8tIteg?t=02h17m08s)

[30.](https://youtu.be/Ctfuh8tIteg?t=02h17m11s)

[and I've got](https://youtu.be/Ctfuh8tIteg?t=02h17m13s)

[I've got early morning meetings tomorrow](https://youtu.be/Ctfuh8tIteg?t=02h17m16s)

[so](https://youtu.be/Ctfuh8tIteg?t=02h17m18s)

[I think with that I will probably wrap](https://youtu.be/Ctfuh8tIteg?t=02h17m19s)

[it up for tonight again I'm Gonna Keep](https://youtu.be/Ctfuh8tIteg?t=02h17m21s)

[hammering on this 5-0 thing because it's](https://youtu.be/Ctfuh8tIteg?t=02h17m22s)

[the the next priority I have on my plate](https://youtu.be/Ctfuh8tIteg?t=02h17m25s)

[for for trying to get in and done](https://youtu.be/Ctfuh8tIteg?t=02h17m28s)

[so](https://youtu.be/Ctfuh8tIteg?t=02h17m30s)

[thank you everyone for coming and](https://youtu.be/Ctfuh8tIteg?t=02h17m31s)

[hanging out Benjamin it was great](https://youtu.be/Ctfuh8tIteg?t=02h17m33s)

[um Joshua if you're still watching I'll](https://youtu.be/Ctfuh8tIteg?t=02h17m37s)

[see you tomorrow I'll be in a little](https://youtu.be/Ctfuh8tIteg?t=02h17m39s)

[later I've got some meetings and stuff](https://youtu.be/Ctfuh8tIteg?t=02h17m41s)

[to take care of in the morning but I](https://youtu.be/Ctfuh8tIteg?t=02h17m43s)

[will be there for lunch because there's](https://youtu.be/Ctfuh8tIteg?t=02h17m44s)

[food involved and I am motivated by food](https://youtu.be/Ctfuh8tIteg?t=02h17m46s)

[so](https://youtu.be/Ctfuh8tIteg?t=02h17m50s)

[um everyone else thank you for coming](https://youtu.be/Ctfuh8tIteg?t=02h17m51s)

[and hanging out uh as always see](https://youtu.be/Ctfuh8tIteg?t=02h17m53s)

[everyone next week happy Cody](https://youtu.be/Ctfuh8tIteg?t=02h17m56s)

