[YouTube Video](https://youtu.be/b4mxGZlaQHY)



[hello everyone welcome back uh tonight](https://youtu.be/b4mxGZlaQHY?t=00h00m03s)

[i'm going to take another run at that](https://youtu.be/b4mxGZlaQHY?t=00h00m05s)

[flipper control that](https://youtu.be/b4mxGZlaQHY?t=00h00m07s)

[i've done some work on a few streams uh](https://youtu.be/b4mxGZlaQHY?t=00h00m09s)

[ago and](https://youtu.be/b4mxGZlaQHY?t=00h00m13s)

[you before that uh it's the last thing](https://youtu.be/b4mxGZlaQHY?t=00h00m14s)

[that's stopping me from a material](https://youtu.be/b4mxGZlaQHY?t=00h00m16s)

[design and xaml release and i've been](https://youtu.be/b4mxGZlaQHY?t=00h00m18s)

[trying to decide whether i](https://youtu.be/b4mxGZlaQHY?t=00h00m20s)

[kicked the release out or actually try](https://youtu.be/b4mxGZlaQHY?t=00h00m22s)

[to get this fixed in i really would like](https://youtu.be/b4mxGZlaQHY?t=00h00m25s)

[to get](https://youtu.be/b4mxGZlaQHY?t=00h00m26s)

[this fix in place as this has been the](https://youtu.be/b4mxGZlaQHY?t=00h00m27s)

[source of a bunch of bugs but](https://youtu.be/b4mxGZlaQHY?t=00h00m29s)

[if i can't get it solved tonight uh](https://youtu.be/b4mxGZlaQHY?t=00h00m32s)

[there may be a release coming without](https://youtu.be/b4mxGZlaQHY?t=00h00m35s)

[this fix in and i'll just punt it yet](https://youtu.be/b4mxGZlaQHY?t=00h00m37s)

[one more release down the line i just](https://youtu.be/b4mxGZlaQHY?t=00h00m39s)

[hate doing that](https://youtu.be/b4mxGZlaQHY?t=00h00m41s)

[so quick refresher for people](https://youtu.be/b4mxGZlaQHY?t=00h00m42s)

[so when last we met we were doing](https://youtu.be/b4mxGZlaQHY?t=00h00m47s)

[something with](https://youtu.be/b4mxGZlaQHY?t=00h00m50s)

[this flipper control here](https://youtu.be/b4mxGZlaQHY?t=00h00m51s)

[and specifically this guy and there was](https://youtu.be/b4mxGZlaQHY?t=00h00m54s)

[a use case that came up where](https://youtu.be/b4mxGZlaQHY?t=00h00m56s)

[the user had a bunch of animating](https://youtu.be/b4mxGZlaQHY?t=00h00m59s)

[controls inside of the flipper but](https://youtu.be/b4mxGZlaQHY?t=00h01m01s)

[because the flipper was always using a](https://youtu.be/b4mxGZlaQHY?t=00h01m03s)

[visual brush](https://youtu.be/b4mxGZlaQHY?t=00h01m05s)

[those things were not reflected](https://youtu.be/b4mxGZlaQHY?t=00h01m07s)

[accurately](https://youtu.be/b4mxGZlaQHY?t=00h01m08s)

[so now i've got it to the point where it](https://youtu.be/b4mxGZlaQHY?t=00h01m09s)

[is](https://youtu.be/b4mxGZlaQHY?t=00h01m11s)

[reflecting accurately but you'll note it](https://youtu.be/b4mxGZlaQHY?t=00h01m13s)

[has](https://youtu.be/b4mxGZlaQHY?t=00h01m16s)

[you'll see the](https://youtu.be/b4mxGZlaQHY?t=00h01m17s)

[the visual brush kind of lingering there](https://youtu.be/b4mxGZlaQHY?t=00h01m19s)

[for a little bit and then more](https://youtu.be/b4mxGZlaQHY?t=00h01m21s)

[importantly](https://youtu.be/b4mxGZlaQHY?t=00h01m22s)

[you also see that kind of weird](https://youtu.be/b4mxGZlaQHY?t=00h01m23s)

[animating effect where it's only](https://youtu.be/b4mxGZlaQHY?t=00h01m27s)

[animated about halfway through](https://youtu.be/b4mxGZlaQHY?t=00h01m29s)

[so you'll note it flips halfway through](https://youtu.be/b4mxGZlaQHY?t=00h01m31s)

[the flip the image goes away and you](https://youtu.be/b4mxGZlaQHY?t=00h01m34s)

[don't see the new content coming in so i](https://youtu.be/b4mxGZlaQHY?t=00h01m36s)

[want to fix that then i want to see if i](https://youtu.be/b4mxGZlaQHY?t=00h01m38s)

[can fix this hanging out here i think](https://youtu.be/b4mxGZlaQHY?t=00h01m40s)

[the issue here is](https://youtu.be/b4mxGZlaQHY?t=00h01m42s)

[the duration needs to be set but i don't](https://youtu.be/b4mxGZlaQHY?t=00h01m45s)

[know for certain so we're going to test](https://youtu.be/b4mxGZlaQHY?t=00h01m48s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h01m50s)

[0.4](https://youtu.be/b4mxGZlaQHY?t=00h01m55s)

[uh because this guy should be](https://youtu.be/b4mxGZlaQHY?t=00h01m58s)

[controlling this guy](https://youtu.be/b4mxGZlaQHY?t=00h02m03s)

[fairly effectively](https://youtu.be/b4mxGZlaQHY?t=00h02m04s)

[uh because the plane 3d which has that](https://youtu.be/b4mxGZlaQHY?t=00h02m07s)

[should be](https://youtu.be/b4mxGZlaQHY?t=00h02m10s)

[what's being toggled](https://youtu.be/b4mxGZlaQHY?t=00h02m13s)

[i'm just going to double check this](https://youtu.be/b4mxGZlaQHY?t=00h02m16s)

[because you can see it swaps the actual](https://youtu.be/b4mxGZlaQHY?t=00h02m18s)

[content at the very end](https://youtu.be/b4mxGZlaQHY?t=00h02m20s)

[let's see here so what is this](https://youtu.be/b4mxGZlaQHY?t=00h02m32s)

[visibility](https://youtu.be/b4mxGZlaQHY?t=00h02m33s)

[unflipped](https://youtu.be/b4mxGZlaQHY?t=00h02m35s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h02m39s)

[in both of these cases it goes to](https://youtu.be/b4mxGZlaQHY?t=00h02m41s)

[collapsed](https://youtu.be/b4mxGZlaQHY?t=00h02m43s)

[starts collapsed](https://youtu.be/b4mxGZlaQHY?t=00h02m45s)

[these things should not be leaving it](https://youtu.be/b4mxGZlaQHY?t=00h02m48s)

[visible](https://youtu.be/b4mxGZlaQHY?t=00h02m50s)

[let's set the duration on both of these](https://youtu.be/b4mxGZlaQHY?t=00h02m51s)

[because i have a i have a hunch that](https://youtu.be/b4mxGZlaQHY?t=00h02m53s)

[this duration not being set is part of](https://youtu.be/b4mxGZlaQHY?t=00h02m57s)

[why we see that lingering](https://youtu.be/b4mxGZlaQHY?t=00h03m00s)

[happening](https://youtu.be/b4mxGZlaQHY?t=00h03m04s)

[and because i don't trust the](https://youtu.be/b4mxGZlaQHY?t=00h03m06s)

[hot reload yet](https://youtu.be/b4mxGZlaQHY?t=00h03m10s)

[hot reload is great when it works](https://youtu.be/b4mxGZlaQHY?t=00h03m12s)

[i have just run into too many cases](https://youtu.be/b4mxGZlaQHY?t=00h03m15s)

[where it it works some of the time which](https://youtu.be/b4mxGZlaQHY?t=00h03m16s)

[is](https://youtu.be/b4mxGZlaQHY?t=00h03m19s)

[which is not overly great](https://youtu.be/b4mxGZlaQHY?t=00h03m20s)

[i would prefer if it would](https://youtu.be/b4mxGZlaQHY?t=00h03m23s)

[work all the time or not at all so we're](https://youtu.be/b4mxGZlaQHY?t=00h03m25s)

[gonna](https://youtu.be/b4mxGZlaQHY?t=00h03m27s)

[nope that is still lingering](https://youtu.be/b4mxGZlaQHY?t=00h03m32s)

[it only lingered on the one side](https://youtu.be/b4mxGZlaQHY?t=00h03m40s)

[oh no it did linger on both](https://youtu.be/b4mxGZlaQHY?t=00h03m43s)

[okay so there's a couple things i want](https://youtu.be/b4mxGZlaQHY?t=00h03m49s)

[to do um i would like the so the](https://youtu.be/b4mxGZlaQHY?t=00h03m51s)

[the 3d plane the thing that's actually](https://youtu.be/b4mxGZlaQHY?t=00h03m54s)

[doing that animation](https://youtu.be/b4mxGZlaQHY?t=00h03m56s)

[right now](https://youtu.be/b4mxGZlaQHY?t=00h03m58s)

[what we did before is we](https://youtu.be/b4mxGZlaQHY?t=00h03m59s)

[uh at the point it goes to flip](https://youtu.be/b4mxGZlaQHY?t=00h04m02s)

[it sets this visual content which is](https://youtu.be/b4mxGZlaQHY?t=00h04m04s)

[great](https://youtu.be/b4mxGZlaQHY?t=00h04m07s)

[except for this only sets effectively](https://youtu.be/b4mxGZlaQHY?t=00h04m08s)

[one side of the flipper and so once you](https://youtu.be/b4mxGZlaQHY?t=00h04m10s)

[get past that halfway point it doesn't](https://youtu.be/b4mxGZlaQHY?t=00h04m12s)

[really matter anymore so i would like to](https://youtu.be/b4mxGZlaQHY?t=00h04m15s)

[get it](https://youtu.be/b4mxGZlaQHY?t=00h04m17s)

[so that it doesn't do that](https://youtu.be/b4mxGZlaQHY?t=00h04m18s)

[and it has as it's flipping it actually](https://youtu.be/b4mxGZlaQHY?t=00h04m20s)

[has the content on both sides](https://youtu.be/b4mxGZlaQHY?t=00h04m22s)

[that would be ideal](https://youtu.be/b4mxGZlaQHY?t=00h04m26s)

[the other thing i would like to get it](https://youtu.be/b4mxGZlaQHY?t=00h04m27s)

[to do is resize halfway](https://youtu.be/b4mxGZlaQHY?t=00h04m29s)

[and that's what this guy here was](https://youtu.be/b4mxGZlaQHY?t=00h04m33s)

[designed to try and do](https://youtu.be/b4mxGZlaQHY?t=00h04m35s)

[we might just put this back real quick](https://youtu.be/b4mxGZlaQHY?t=00h04m41s)

[and see how well this works i don't](https://youtu.be/b4mxGZlaQHY?t=00h04m43s)

[think this is going to do a lot](https://youtu.be/b4mxGZlaQHY?t=00h04m45s)

[i don't think it actually i don't think](https://youtu.be/b4mxGZlaQHY?t=00h04m51s)

[we actually need this](https://youtu.be/b4mxGZlaQHY?t=00h04m52s)

[i i think what we can actually do is](https://youtu.be/b4mxGZlaQHY?t=00h04m55s)

[we can trigger a re-measure of this guy](https://youtu.be/b4mxGZlaQHY?t=00h05m02s)

[as it's doing the flip](https://youtu.be/b4mxGZlaQHY?t=00h05m05s)

[yeah i think that's what we're going to](https://youtu.be/b4mxGZlaQHY?t=00h05m14s)

[do is we are going to have](https://youtu.be/b4mxGZlaQHY?t=00h05m16s)

[we're going to have the flipper watch](https://youtu.be/b4mxGZlaQHY?t=00h05m21s)

[the 3d plane and when it crests that](https://youtu.be/b4mxGZlaQHY?t=00h05m23s)

[mark](https://youtu.be/b4mxGZlaQHY?t=00h05m27s)

[it's going to](https://youtu.be/b4mxGZlaQHY?t=00h05m30s)

[auto remeasure](https://youtu.be/b4mxGZlaQHY?t=00h05m31s)

[uh let's see so it's](https://youtu.be/b4mxGZlaQHY?t=00h05m34s)

[oh hang on what is this doing it starts](https://youtu.be/b4mxGZlaQHY?t=00h05m43s)

[at 0 goes to negative 90](https://youtu.be/b4mxGZlaQHY?t=00h05m45s)

[so it's adjusting the y axis](https://youtu.be/b4mxGZlaQHY?t=00h05m49s)

[okay so i gotta switch my brain into 3d](https://youtu.be/b4mxGZlaQHY?t=00h05m52s)

[mode real quick](https://youtu.be/b4mxGZlaQHY?t=00h05m55s)

[so it's rotating around about the y-axis](https://youtu.be/b4mxGZlaQHY?t=00h05m58s)

[okay so that's effectively doing this](https://youtu.be/b4mxGZlaQHY?t=00h06m08s)

[maneuver so it starts at zero](https://youtu.be/b4mxGZlaQHY?t=00h06m10s)

[goes negative 90](https://youtu.be/b4mxGZlaQHY?t=00h06m13s)

[goes positive](https://youtu.be/b4mxGZlaQHY?t=00h06m17s)

[90 and then zero](https://youtu.be/b4mxGZlaQHY?t=00h06m18s)

[trying to understand](https://youtu.be/b4mxGZlaQHY?t=00h06m26s)

[oh i see](https://youtu.be/b4mxGZlaQHY?t=00h06m29s)

[basically when it's](https://youtu.be/b4mxGZlaQHY?t=00h06m31s)

[perpendicular to us it's flipping to the](https://youtu.be/b4mxGZlaQHY?t=00h06m33s)

[other one](https://youtu.be/b4mxGZlaQHY?t=00h06m35s)

[and then spinning around](https://youtu.be/b4mxGZlaQHY?t=00h06m36s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=00h06m41s)

[that flips there](https://youtu.be/b4mxGZlaQHY?t=00h06m42s)

[from 90 to negative 90 is where](https://youtu.be/b4mxGZlaQHY?t=00h06m44s)

[it matters](https://youtu.be/b4mxGZlaQHY?t=00h06m49s)

[because you'll note both of these things](https://youtu.be/b4mxGZlaQHY?t=00h06m53s)

[are occurring at the same time](https://youtu.be/b4mxGZlaQHY?t=00h06m54s)

[and because they have the same key time](https://youtu.be/b4mxGZlaQHY?t=00h06m57s)

[what will end up happening is it's going](https://youtu.be/b4mxGZlaQHY?t=00h07m00s)

[to](https://youtu.be/b4mxGZlaQHY?t=00h07m01s)

[do what's called tweening](https://youtu.be/b4mxGZlaQHY?t=00h07m02s)

[the basically figure out the animation](https://youtu.be/b4mxGZlaQHY?t=00h07m04s)

[points from point a to point](https://youtu.be/b4mxGZlaQHY?t=00h07m06s)

[or sorry from point a to point b](https://youtu.be/b4mxGZlaQHY?t=00h07m08s)

[over the course of 0.2 seconds and so it](https://youtu.be/b4mxGZlaQHY?t=00h07m10s)

[figures out](https://youtu.be/b4mxGZlaQHY?t=00h07m13s)

[you know based on a number of things](https://youtu.be/b4mxGZlaQHY?t=00h07m14s)

[what](https://youtu.be/b4mxGZlaQHY?t=00h07m17s)

[points that will end up being](https://youtu.be/b4mxGZlaQHY?t=00h07m18s)

[once it gets to 90 it flips to negative](https://youtu.be/b4mxGZlaQHY?t=00h07m21s)

[00:07:25,039 --> 00:07:30,000](https://youtu.be/b4mxGZlaQHY?t=00h07m24s)

and then

[spins back so this entire thing is](https://youtu.be/b4mxGZlaQHY?t=00h07m27s)

[rotating about the y-axis](https://youtu.be/b4mxGZlaQHY?t=00h07m30s)

[okay so we could actually watch for](https://youtu.be/b4mxGZlaQHY?t=00h07m33s)

[when the value goes positive to negative](https://youtu.be/b4mxGZlaQHY?t=00h07m36s)

[will be the](https://youtu.be/b4mxGZlaQHY?t=00h07m40s)

[the center of the flip](https://youtu.be/b4mxGZlaQHY?t=00h07m41s)

[shouldn't be too hard](https://youtu.be/b4mxGZlaQHY?t=00h07m46s)

[okay so let's let's start with let's](https://youtu.be/b4mxGZlaQHY?t=00h07m48s)

[start with just getting that](https://youtu.be/b4mxGZlaQHY?t=00h07m51s)

[thing figured out](https://youtu.be/b4mxGZlaQHY?t=00h07m53s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h07m55s)

[i think the flipper here](https://youtu.be/b4mxGZlaQHY?t=00h07m56s)

[um where is the](https://youtu.be/b4mxGZlaQHY?t=00h08m00s)

[apply template](https://youtu.be/b4mxGZlaQHY?t=00h08m03s)

[where's your apply template](https://youtu.be/b4mxGZlaQHY?t=00h08m05s)

[on apply template take me there there we](https://youtu.be/b4mxGZlaQHY?t=00h08m08s)

[are so after we get the plane 3d](https://youtu.be/b4mxGZlaQHY?t=00h08m11s)

[so how about](https://youtu.be/b4mxGZlaQHY?t=00h08m17s)

[if](https://youtu.be/b4mxGZlaQHY?t=00h08m18s)

[plane 3d is](https://youtu.be/b4mxGZlaQHY?t=00h08m20s)

[about is](https://youtu.be/b4mxGZlaQHY?t=00h08m22s)

[not null we can use new c-sharp syntax](https://youtu.be/b4mxGZlaQHY?t=00h08m24s)

[we are going to go plain 3d](https://youtu.be/b4mxGZlaQHY?t=00h08m28s)

[we want to register up on the](https://youtu.be/b4mxGZlaQHY?t=00h08m36s)

[dependency property](https://youtu.be/b4mxGZlaQHY?t=00h08m39s)

[because that's one option or we could](https://youtu.be/b4mxGZlaQHY?t=00h08m43s)

[give ourselves something](https://youtu.be/b4mxGZlaQHY?t=00h08m46s)

[watch](https://youtu.be/b4mxGZlaQHY?t=00h08m48s)

[i don't know what sounds better in this](https://youtu.be/b4mxGZlaQHY?t=00h08m52s)

[situation](https://youtu.be/b4mxGZlaQHY?t=00h08m54s)

[because we could do](https://youtu.be/b4mxGZlaQHY?t=00h08m56s)

[what is the generic](https://youtu.be/b4mxGZlaQHY?t=00h09m01s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h09m03s)

[there's a](https://youtu.be/b4mxGZlaQHY?t=00h09m05s)

[there's a way to end up watching these](https://youtu.be/b4mxGZlaQHY?t=00h09m12s)

[things](https://youtu.be/b4mxGZlaQHY?t=00h09m13s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h09m16s)

[just ask the magical google uh](https://youtu.be/b4mxGZlaQHY?t=00h09m19s)

[yeah](https://youtu.be/b4mxGZlaQHY?t=00h09m35s)

[oh](https://youtu.be/b4mxGZlaQHY?t=00h09m38s)

[yuck](https://youtu.be/b4mxGZlaQHY?t=00h09m38s)

[uh if it depends upon his property](https://youtu.be/b4mxGZlaQHY?t=00h09m46s)

[change callback](https://youtu.be/b4mxGZlaQHY?t=00h09m49s)

[yeah i don't like those options we're](https://youtu.be/b4mxGZlaQHY?t=00h09m52s)

[just going to add ourselves a property](https://youtu.be/b4mxGZlaQHY?t=00h09m54s)

[here](https://youtu.be/b4mxGZlaQHY?t=00h09m56s)

[so rotation y](https://youtu.be/b4mxGZlaQHY?t=00h09m57s)

[and](https://youtu.be/b4mxGZlaQHY?t=00h10m02s)

[this is the callback here already](https://youtu.be/b4mxGZlaQHY?t=00h10m03s)

[um let's see well let's see what does](https://youtu.be/b4mxGZlaQHY?t=00h10m08s)

[update rotation do](https://youtu.be/b4mxGZlaQHY?t=00h10m10s)

[let's just give this guy a new event](https://youtu.be/b4mxGZlaQHY?t=00h10m16s)

[that](https://youtu.be/b4mxGZlaQHY?t=00h10m19s)

[people can work with](https://youtu.be/b4mxGZlaQHY?t=00h10m20s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h10m23s)

[so public](https://youtu.be/b4mxGZlaQHY?t=00h10m25s)

[event handler](https://youtu.be/b4mxGZlaQHY?t=00h10m27s)

[patient changed](https://youtu.be/b4mxGZlaQHY?t=00h10m30s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h10m33s)

[let's see event](https://youtu.be/b4mxGZlaQHY?t=00h10m34s)

[and then we are going to create a new](https://youtu.be/b4mxGZlaQHY?t=00h10m37s)

[we need ourselves a new event args class](https://youtu.be/b4mxGZlaQHY?t=00h10m46s)

[just gonna do oh here while we're in](https://youtu.be/b4mxGZlaQHY?t=00h10m50s)

[here while we're in here file scope name](https://youtu.be/b4mxGZlaQHY?t=00h10m52s)

[space booyah](https://youtu.be/b4mxGZlaQHY?t=00h10m54s)

[plus indentation](https://youtu.be/b4mxGZlaQHY?t=00h10m55s)

[public](https://youtu.be/b4mxGZlaQHY?t=00h10m57s)

[uh rotation](https://youtu.be/b4mxGZlaQHY?t=00h10m59s)

[change event art](https://youtu.be/b4mxGZlaQHY?t=00h11m02s)

[bed args and then we will just include](https://youtu.be/b4mxGZlaQHY?t=00h11m05s)

[all of the because they're all just](https://youtu.be/b4mxGZlaQHY?t=00h11m10s)

[doubles right yeah](https://youtu.be/b4mxGZlaQHY?t=00h11m12s)

[so public](https://youtu.be/b4mxGZlaQHY?t=00h11m15s)

[double](https://youtu.be/b4mxGZlaQHY?t=00h11m18s)

[gen x](https://youtu.be/b4mxGZlaQHY?t=00h11m21s)

[y](https://youtu.be/b4mxGZlaQHY?t=00h11m28s)

[z](https://youtu.be/b4mxGZlaQHY?t=00h11m30s)

[then i should be able to auto code this](https://youtu.be/b4mxGZlaQHY?t=00h11m32s)

[guy into](https://youtu.be/b4mxGZlaQHY?t=00h11m34s)

[generate constructor](https://youtu.be/b4mxGZlaQHY?t=00h11m36s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h11m40s)

[add parameter to constructor](https://youtu.be/b4mxGZlaQHY?t=00h11m41s)

[and](https://youtu.be/b4mxGZlaQHY?t=00h11m45s)

[oh well that didn't](https://youtu.be/b4mxGZlaQHY?t=00h11m50s)

[you got half of it right oh auto code](https://youtu.be/b4mxGZlaQHY?t=00h11m53s)

[will do the rest thank you](https://youtu.be/b4mxGZlaQHY?t=00h11m56s)

[thank you autocode you are wonderful](https://youtu.be/b4mxGZlaQHY?t=00h11m59s)

[i really do appreciate you intellicode](https://youtu.be/b4mxGZlaQHY?t=00h12m02s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h12m06s)

[okay so we will have this guy come here](https://youtu.be/b4mxGZlaQHY?t=00h12m09s)

[and this guy is going to be one of these](https://youtu.be/b4mxGZlaQHY?t=00h12m13s)

[okay and then on that update](https://youtu.be/b4mxGZlaQHY?t=00h12m17s)

[rotation okay](https://youtu.be/b4mxGZlaQHY?t=00h12m22s)

[so we will go](https://youtu.be/b4mxGZlaQHY?t=00h12m25s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h12m31s)

[i call it rotation](https://youtu.be/b4mxGZlaQHY?t=00h12m34s)

[changed](https://youtu.be/b4mxGZlaQHY?t=00h12m37s)

[uh invoke](https://youtu.be/b4mxGZlaQHY?t=00h12m39s)

[this new](https://youtu.be/b4mxGZlaQHY?t=00h12m40s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h12m44s)

[location](https://youtu.be/b4mxGZlaQHY?t=00h12m45s)

[x](https://youtu.be/b4mxGZlaQHY?t=00h12m47s)

[bye](https://youtu.be/b4mxGZlaQHY?t=00h12m53s)

[boom](https://youtu.be/b4mxGZlaQHY?t=00h12m58s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h12m59s)

[that](https://youtu.be/b4mxGZlaQHY?t=00h13m05s)

[okay so and then this guy will just](https://youtu.be/b4mxGZlaQHY?t=00h13m12s)

[register up for it](https://youtu.be/b4mxGZlaQHY?t=00h13m14s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h13m16s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h13m16s)

[i think she changed](https://youtu.be/b4mxGZlaQHY?t=00h13m18s)

[now we had a question come up on the](https://youtu.be/b4mxGZlaQHY?t=00h13m24s)

[stream a while back about when do you](https://youtu.be/b4mxGZlaQHY?t=00h13m26s)

[need to](https://youtu.be/b4mxGZlaQHY?t=00h13m28s)

[unregister for these events](https://youtu.be/b4mxGZlaQHY?t=00h13m30s)

[because event handlers are a](https://youtu.be/b4mxGZlaQHY?t=00h13m32s)

[wonderful way to leak memory in many](https://youtu.be/b4mxGZlaQHY?t=00h13m35s)

[situations](https://youtu.be/b4mxGZlaQHY?t=00h13m38s)

[um and in this case it will not be an](https://youtu.be/b4mxGZlaQHY?t=00h13m39s)

[issue simply because](https://youtu.be/b4mxGZlaQHY?t=00h13m42s)

[what will end up happening is the plane](https://youtu.be/b4mxGZlaQHY?t=00h13m45s)

[3d](https://youtu.be/b4mxGZlaQHY?t=00h13m48s)

[will implicitly contain a reference to](https://youtu.be/b4mxGZlaQHY?t=00h13m49s)

[the flipper](https://youtu.be/b4mxGZlaQHY?t=00h13m51s)

[which in this case is perfectly fine](https://youtu.be/b4mxGZlaQHY?t=00h13m52s)

[because what at the point where the](https://youtu.be/b4mxGZlaQHY?t=00h13m56s)

[flipper is going away the plane 3d will](https://youtu.be/b4mxGZlaQHY?t=00h13m58s)

[be going away as well](https://youtu.be/b4mxGZlaQHY?t=00h14m01s)

[so that circular reference one of them](https://youtu.be/b4mxGZlaQHY?t=00h14m03s)

[is not going to have a a longer life](https://youtu.be/b4mxGZlaQHY?t=00h14m05s)

[span than the other](https://youtu.be/b4mxGZlaQHY?t=00h14m07s)

[so we're good](https://youtu.be/b4mxGZlaQHY?t=00h14m09s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h14m14s)

[so at this point](https://youtu.be/b4mxGZlaQHY?t=00h14m15s)

[uh let's see](https://youtu.be/b4mxGZlaQHY?t=00h14m18s)

[double](https://youtu.be/b4mxGZlaQHY?t=00h14m20s)

[last rotation y](https://youtu.be/b4mxGZlaQHY?t=00h14m22s)

[and actually let's make you nullable](https://youtu.be/b4mxGZlaQHY?t=00h14m25s)

[so if](https://youtu.be/b4mxGZlaQHY?t=00h14m29s)

[because we know we're going from](https://youtu.be/b4mxGZlaQHY?t=00h14m31s)

[positive to negative right](https://youtu.be/b4mxGZlaQHY?t=00h14m33s)

[yeah so if last rotation y is greater](https://youtu.be/b4mxGZlaQHY?t=00h14m36s)

[than zero](https://youtu.be/b4mxGZlaQHY?t=00h14m38s)

[and](https://youtu.be/b4mxGZlaQHY?t=00h14m40s)

[e](https://youtu.be/b4mxGZlaQHY?t=00h14m42s)

[dot rotation y is less than zero](https://youtu.be/b4mxGZlaQHY?t=00h14m43s)

[mid flip](https://youtu.be/b4mxGZlaQHY?t=00h14m49s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h14m51s)

[else uh let's see here](https://youtu.be/b4mxGZlaQHY?t=00h14m55s)

[what are you squawking about](https://youtu.be/b4mxGZlaQHY?t=00h14m59s)

[use of unassigned variable last oh](https://youtu.be/b4mxGZlaQHY?t=00h15m01s)

[fine hush](https://youtu.be/b4mxGZlaQHY?t=00h15m05s)

[play it](https://youtu.be/b4mxGZlaQHY?t=00h15m10s)

[quite quiet](https://youtu.be/b4mxGZlaQHY?t=00h15m11s)

[um let's see uh else](https://youtu.be/b4mxGZlaQHY?t=00h15m12s)

[actually i guess this really shouldn't](https://youtu.be/b4mxGZlaQHY?t=00h15m18s)

[be in an ls box we should just always](https://youtu.be/b4mxGZlaQHY?t=00h15m20s)

[set it](https://youtu.be/b4mxGZlaQHY?t=00h15m21s)

[okay so this is the point where we now](https://youtu.be/b4mxGZlaQHY?t=00h15m23s)

[want to](https://youtu.be/b4mxGZlaQHY?t=00h15m25s)

[change the content](https://youtu.be/b4mxGZlaQHY?t=00h15m27s)

[so i'd like to do](https://youtu.be/b4mxGZlaQHY?t=00h15m29s)

[exactly what we're doing on the other](https://youtu.be/b4mxGZlaQHY?t=00h15m31s)

[one](https://youtu.be/b4mxGZlaQHY?t=00h15m32s)

[to do](https://youtu.be/b4mxGZlaQHY?t=00h15m37s)

[and then](https://youtu.be/b4mxGZlaQHY?t=00h15m42s)

[i want to do this maneuver](https://youtu.be/b4mxGZlaQHY?t=00h15m45s)

[boom okay so](https://youtu.be/b4mxGZlaQHY?t=00h15m51s)

[i don't need flipper we've already got](https://youtu.be/b4mxGZlaQHY?t=00h15m54s)

[flipper in this case](https://youtu.be/b4mxGZlaQHY?t=00h15m56s)

[just this so we can drop that](https://youtu.be/b4mxGZlaQHY?t=00h15m59s)

[drop that](https://youtu.be/b4mxGZlaQHY?t=00h16m03s)

[and then this was being based upon](https://youtu.be/b4mxGZlaQHY?t=00h16m05s)

[is flipped](https://youtu.be/b4mxGZlaQHY?t=00h16m09s)

[this is going to be](https://youtu.be/b4mxGZlaQHY?t=00h16m11s)

[is flipped](https://youtu.be/b4mxGZlaQHY?t=00h16m14s)

[and then](https://youtu.be/b4mxGZlaQHY?t=00h16m17s)

[this here is going to actually be](https://youtu.be/b4mxGZlaQHY?t=00h16m19s)

[directly inverted](https://youtu.be/b4mxGZlaQHY?t=00h16m21s)

[because as you're going across we want](https://youtu.be/b4mxGZlaQHY?t=00h16m24s)

[to change it up](https://youtu.be/b4mxGZlaQHY?t=00h16m25s)

[this goes like this](https://youtu.be/b4mxGZlaQHY?t=00h16m28s)

[and i think what we should see then is](https://youtu.be/b4mxGZlaQHY?t=00h16m31s)

[the content of this guy swapped](https://youtu.be/b4mxGZlaQHY?t=00h16m33s)

[so rather than seeing the old content at](https://youtu.be/b4mxGZlaQHY?t=00h16m38s)

[the end you should see the new one](https://youtu.be/b4mxGZlaQHY?t=00h16m40s)

[appropriately placed](https://youtu.be/b4mxGZlaQHY?t=00h16m42s)

[at least that's the game plan](https://youtu.be/b4mxGZlaQHY?t=00h16m46s)

[see how well that works](https://youtu.be/b4mxGZlaQHY?t=00h16m49s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h16m52s)

[that still has the old stuff](https://youtu.be/b4mxGZlaQHY?t=00h16m58s)

[but let's make sure we're actually](https://youtu.be/b4mxGZlaQHY?t=00h17m01s)

[getting into this mid flip thing](https://youtu.be/b4mxGZlaQHY?t=00h17m02s)

[right about where one would expect](https://youtu.be/b4mxGZlaQHY?t=00h17m07s)

[if i move this](https://youtu.be/b4mxGZlaQHY?t=00h17m09s)

[yeah that flips about halfway across](https://youtu.be/b4mxGZlaQHY?t=00h17m11s)

[okay so is flipped is going to false so](https://youtu.be/b4mxGZlaQHY?t=00h17m14s)

[we're going to grab](https://youtu.be/b4mxGZlaQHY?t=00h17m16s)

[the front content which is where we're](https://youtu.be/b4mxGZlaQHY?t=00h17m18s)

[heading to](https://youtu.be/b4mxGZlaQHY?t=00h17m20s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h17m25s)

[that's an interesting](https://youtu.be/b4mxGZlaQHY?t=00h17m29s)

[perspective](https://youtu.be/b4mxGZlaQHY?t=00h17m31s)

[we've hit this multiple times now](https://youtu.be/b4mxGZlaQHY?t=00h17m39s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h17m42s)

[this is an interesting problem in that i](https://youtu.be/b4mxGZlaQHY?t=00h17m49s)

[can't render what's not visible](https://youtu.be/b4mxGZlaQHY?t=00h17m50s)

[can't render what isn't visible so how](https://youtu.be/b4mxGZlaQHY?t=00h18m02s)

[do i make the content visible](https://youtu.be/b4mxGZlaQHY?t=00h18m04s)

[i hate to duplicate the content](https://youtu.be/b4mxGZlaQHY?t=00h18m18s)

[maybe that's the easiest option is](https://youtu.be/b4mxGZlaQHY?t=00h18m22s)

[duplicate the visual tree](https://youtu.be/b4mxGZlaQHY?t=00h18m24s)

[rather than this render bitmap stuff](https://youtu.be/b4mxGZlaQHY?t=00h18m27s)

[because what it's running into](https://youtu.be/b4mxGZlaQHY?t=00h18m36s)

[is we get halfway through that flip](https://youtu.be/b4mxGZlaQHY?t=00h18m38s)

[and it goes to swap the content and at](https://youtu.be/b4mxGZlaQHY?t=00h18m40s)

[least with that breakpoint in there we](https://youtu.be/b4mxGZlaQHY?t=00h18m42s)

[we conveniently hit it](https://youtu.be/b4mxGZlaQHY?t=00h18m44s)

[but because the content was](https://youtu.be/b4mxGZlaQHY?t=00h18m47s)

[not marked as visible](https://youtu.be/b4mxGZlaQHY?t=00h18m49s)

[it wasn't able to render it](https://youtu.be/b4mxGZlaQHY?t=00h18m51s)

[i don't know if we'll hit this again](https://youtu.be/b4mxGZlaQHY?t=00h18m53s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h18m56s)

[turn this off](https://youtu.be/b4mxGZlaQHY?t=00h18m57s)

[it's probably timing dependent i would](https://youtu.be/b4mxGZlaQHY?t=00h18m58s)

[imagine](https://youtu.be/b4mxGZlaQHY?t=00h19m00s)

[nope we're just repeatedly hitting it on](https://youtu.be/b4mxGZlaQHY?t=00h19m04s)

[the flip back](https://youtu.be/b4mxGZlaQHY?t=00h19m06s)

[surprising me that we're hitting it on](https://youtu.be/b4mxGZlaQHY?t=00h19m09s)

[one](https://youtu.be/b4mxGZlaQHY?t=00h19m10s)

[on the way back and not the other](https://youtu.be/b4mxGZlaQHY?t=00h19m11s)

[that is actually very surprising to me](https://youtu.be/b4mxGZlaQHY?t=00h19m20s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h19m27s)

[were we doing some sort of measuring to](https://youtu.be/b4mxGZlaQHY?t=00h19m28s)

[this thing beforehand](https://youtu.be/b4mxGZlaQHY?t=00h19m30s)

[and look](https://youtu.be/b4mxGZlaQHY?t=00h19m32s)

[um okay so we're gonna do we're gonna do](https://youtu.be/b4mxGZlaQHY?t=00h19m45s)

[a couple things because i want to make](https://youtu.be/b4mxGZlaQHY?t=00h19m47s)

[this a little](https://youtu.be/b4mxGZlaQHY?t=00h19m48s)

[a little more obvious](https://youtu.be/b4mxGZlaQHY?t=00h19m51s)

[well hang on i should be getting the](https://youtu.be/b4mxGZlaQHY?t=00h19m57s)

[name of these let's spread this again so](https://youtu.be/b4mxGZlaQHY?t=00h19m59s)

[both of these are there](https://youtu.be/b4mxGZlaQHY?t=00h20m05s)

[that should work](https://youtu.be/b4mxGZlaQHY?t=00h20m12s)

[huh](https://youtu.be/b4mxGZlaQHY?t=00h20m28s)

[i'm somewhat wondering if there might be](https://youtu.be/b4mxGZlaQHY?t=00h20m38s)

[an easier approach to this](https://youtu.be/b4mxGZlaQHY?t=00h20m40s)

[because i've been going at this from the](https://youtu.be/b4mxGZlaQHY?t=00h20m48s)

[approach of the plane 3d but i'm](https://youtu.be/b4mxGZlaQHY?t=00h20m50s)

[wondering if perhaps there's a](https://youtu.be/b4mxGZlaQHY?t=00h20m51s)

[a better option](https://youtu.be/b4mxGZlaQHY?t=00h20m55s)

[we'll consider that here in just a](https://youtu.be/b4mxGZlaQHY?t=00h21m00s)

[moment](https://youtu.be/b4mxGZlaQHY?t=00h21m01s)

[i i might want to try something slightly](https://youtu.be/b4mxGZlaQHY?t=00h21m02s)

[different](https://youtu.be/b4mxGZlaQHY?t=00h21m04s)

[very interesting](https://youtu.be/b4mxGZlaQHY?t=00h21m09s)

[uh okay so i want to try one more thing](https://youtu.be/b4mxGZlaQHY?t=00h21m16s)

[just](https://youtu.be/b4mxGZlaQHY?t=00h21m19s)

[just for grins](https://youtu.be/b4mxGZlaQHY?t=00h21m22s)

[i'm i'm kind of curious](https://youtu.be/b4mxGZlaQHY?t=00h21m27s)

[if i can do this animation a little bit](https://youtu.be/b4mxGZlaQHY?t=00h21m34s)

[differently](https://youtu.be/b4mxGZlaQHY?t=00h21m36s)

[because this is entirely based around](https://youtu.be/b4mxGZlaQHY?t=00h21m38s)

[that plain 3d](https://youtu.be/b4mxGZlaQHY?t=00h21m39s)

[which is does the bitmaps and the](https://youtu.be/b4mxGZlaQHY?t=00h21m41s)

[re-rendering and all of that jazz](https://youtu.be/b4mxGZlaQHY?t=00h21m43s)

[which is the problematic part](https://youtu.be/b4mxGZlaQHY?t=00h21m47s)

[but if we're already going to this](https://youtu.be/b4mxGZlaQHY?t=00h21m51s)

[effort](https://youtu.be/b4mxGZlaQHY?t=00h21m52s)

[i'm kind of i'm kind of wondering if we](https://youtu.be/b4mxGZlaQHY?t=00h21m56s)

[can do something a little a little more](https://youtu.be/b4mxGZlaQHY?t=00h21m58s)

[fancy](https://youtu.be/b4mxGZlaQHY?t=00h22m00s)

[so let's we're going to try i want to](https://youtu.be/b4mxGZlaQHY?t=00h22m01s)

[try something new](https://youtu.be/b4mxGZlaQHY?t=00h22m03s)

[uh content presenter so there are two](https://youtu.be/b4mxGZlaQHY?t=00h22m05s)

[types of](https://youtu.be/b4mxGZlaQHY?t=00h22m07s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h22m09s)

[transforms](https://youtu.be/b4mxGZlaQHY?t=00h22m11s)

[there is a](https://youtu.be/b4mxGZlaQHY?t=00h22m12s)

[layout transform and a render trend](https://youtu.be/b4mxGZlaQHY?t=00h22m15s)

[inside a wpf](https://youtu.be/b4mxGZlaQHY?t=00h22m17s)

[um the](https://youtu.be/b4mxGZlaQHY?t=00h22m19s)

[the key the key part with these is that](https://youtu.be/b4mxGZlaQHY?t=00h22m22s)

[the is the point at which they occur the](https://youtu.be/b4mxGZlaQHY?t=00h22m25s)

[layout transform will affect layout so](https://youtu.be/b4mxGZlaQHY?t=00h22m27s)

[if you have a layout transform and you](https://youtu.be/b4mxGZlaQHY?t=00h22m30s)

[shift your content](https://youtu.be/b4mxGZlaQHY?t=00h22m32s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h22m34s)

[by say a scale right so let's just](https://youtu.be/b4mxGZlaQHY?t=00h22m37s)

[imagine that we're going to scale our x](https://youtu.be/b4mxGZlaQHY?t=00h22m39s)

[by a factor of 2.](https://youtu.be/b4mxGZlaQHY?t=00h22m41s)

[if you do it as a layout transform](https://youtu.be/b4mxGZlaQHY?t=00h22m43s)

[all of the elements around will see this](https://youtu.be/b4mxGZlaQHY?t=00h22m45s)

[content presenter scaled out twice as](https://youtu.be/b4mxGZlaQHY?t=00h22m48s)

[big](https://youtu.be/b4mxGZlaQHY?t=00h22m50s)

[on the x-axis horizontally](https://youtu.be/b4mxGZlaQHY?t=00h22m51s)

[whereas if you do it as a render](https://youtu.be/b4mxGZlaQHY?t=00h22m54s)

[transform the layout won't be affected](https://youtu.be/b4mxGZlaQHY?t=00h22m55s)

[but the rendered size will so when it's](https://youtu.be/b4mxGZlaQHY?t=00h22m58s)

[doing its measuring to figure out how](https://youtu.be/b4mxGZlaQHY?t=00h23m00s)

[big it needs to be](https://youtu.be/b4mxGZlaQHY?t=00h23m02s)

[it won't take this into account](https://youtu.be/b4mxGZlaQHY?t=00h23m04s)

[but if you do it as a layout transform](https://youtu.be/b4mxGZlaQHY?t=00h23m07s)

[it will](https://youtu.be/b4mxGZlaQHY?t=00h23m09s)

[render transform is a lot quicker](https://youtu.be/b4mxGZlaQHY?t=00h23m11s)

[because it doesn't affect layout](https://youtu.be/b4mxGZlaQHY?t=00h23m13s)

[uh but it also has the drawback of](https://youtu.be/b4mxGZlaQHY?t=00h23m16s)

[because it doesn't affect layout your](https://youtu.be/b4mxGZlaQHY?t=00h23m18s)

[other elements around aren't going to](https://youtu.be/b4mxGZlaQHY?t=00h23m20s)

[like move and adapt to you because](https://youtu.be/b4mxGZlaQHY?t=00h23m22s)

[normally in wpf as the control gets](https://youtu.be/b4mxGZlaQHY?t=00h23m24s)

[bigger by default it'll fill its](https://youtu.be/b4mxGZlaQHY?t=00h23m26s)

[container](https://youtu.be/b4mxGZlaQHY?t=00h23m28s)

[so if you scale it out in the layout](https://youtu.be/b4mxGZlaQHY?t=00h23m29s)

[transform your container gets bigger to](https://youtu.be/b4mxGZlaQHY?t=00h23m31s)

[hold it and everything responds](https://youtu.be/b4mxGZlaQHY?t=00h23m32s)

[accordingly that's great but that can be](https://youtu.be/b4mxGZlaQHY?t=00h23m33s)

[quite expensive](https://youtu.be/b4mxGZlaQHY?t=00h23m35s)

[if you try to animate across that](https://youtu.be/b4mxGZlaQHY?t=00h23m37s)

[typically for animations you want to be](https://youtu.be/b4mxGZlaQHY?t=00h23m39s)

[animating a render transform](https://youtu.be/b4mxGZlaQHY?t=00h23m41s)

[but that also means you need to take](https://youtu.be/b4mxGZlaQHY?t=00h23m44s)

[into account the fact that nothing](https://youtu.be/b4mxGZlaQHY?t=00h23m45s)

[around you is going to know that you've](https://youtu.be/b4mxGZlaQHY?t=00h23m47s)

[shifted so but in our case we just want](https://youtu.be/b4mxGZlaQHY?t=00h23m49s)

[to occupy the same size](https://youtu.be/b4mxGZlaQHY?t=00h23m52s)

[so i'm kind of wondering i'm kind of](https://youtu.be/b4mxGZlaQHY?t=00h23m54s)

[wondering if we can get away with](https://youtu.be/b4mxGZlaQHY?t=00h23m56s)

[something here](https://youtu.be/b4mxGZlaQHY?t=00h23m58s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h24m00s)

[and i'm kind of wondering because this](https://youtu.be/b4mxGZlaQHY?t=00h24m04s)

[will](https://youtu.be/b4mxGZlaQHY?t=00h24m06s)

[that won't spin me across the right axis](https://youtu.be/b4mxGZlaQHY?t=00h24m10s)

[um and i think i have to go with the](https://youtu.be/b4mxGZlaQHY?t=00h24m14s)

[matrix transform](https://youtu.be/b4mxGZlaQHY?t=00h24m16s)

[which i think is what the other one the](https://youtu.be/b4mxGZlaQHY?t=00h24m19s)

[plane 3d is actually doing with that](https://youtu.be/b4mxGZlaQHY?t=00h24m23s)

[i'm gonna have to remember my](https://youtu.be/b4mxGZlaQHY?t=00h24m27s)

[my matrix transform uh this is using a](https://youtu.be/b4mxGZlaQHY?t=00h24m33s)

[perspective camera to spin it](https://youtu.be/b4mxGZlaQHY?t=00h24m36s)

[what is using both](https://youtu.be/b4mxGZlaQHY?t=00h24m42s)

[there's a skis so](https://youtu.be/b4mxGZlaQHY?t=00h24m45s)

[scale center](https://youtu.be/b4mxGZlaQHY?t=00h24m51s)

[i don't know if we actually care about](https://youtu.be/b4mxGZlaQHY?t=00h24m53s)

[this](https://youtu.be/b4mxGZlaQHY?t=00h24m56s)

[i don't know if we care about this at](https://youtu.be/b4mxGZlaQHY?t=00h25m03s)

[all](https://youtu.be/b4mxGZlaQHY?t=00h25m05s)

[i'm just looking at what this is doing](https://youtu.be/b4mxGZlaQHY?t=00h25m14s)

[here](https://youtu.be/b4mxGZlaQHY?t=00h25m16s)

[what does it use this rotation transform](https://youtu.be/b4mxGZlaQHY?t=00h25m22s)

[for i understand why it might need scale](https://youtu.be/b4mxGZlaQHY?t=00h25m24s)

[but i don't understand](https://youtu.be/b4mxGZlaQHY?t=00h25m26s)

[it's got a transform group of scale](https://youtu.be/b4mxGZlaQHY?t=00h25m30s)

[and rotation](https://youtu.be/b4mxGZlaQHY?t=00h25m34s)

[the problem is is we want to go across](https://youtu.be/b4mxGZlaQHY?t=00h25m38s)

[the y-axis](https://youtu.be/b4mxGZlaQHY?t=00h25m41s)

[and the rotation transform isn't going](https://youtu.be/b4mxGZlaQHY?t=00h25m43s)

[to go across the y-axis](https://youtu.be/b4mxGZlaQHY?t=00h25m45s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=00h25m52s)

[let's let's i i want to try this with a](https://youtu.be/b4mxGZlaQHY?t=00h25m55s)

[matrix transform](https://youtu.be/b4mxGZlaQHY?t=00h25m57s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h25m58s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h26m03s)

[transform](https://youtu.be/b4mxGZlaQHY?t=00h26m04s)

[i want to see](https://youtu.be/b4mxGZlaQHY?t=00h26m08s)

[yeah i want to look at](https://youtu.be/b4mxGZlaQHY?t=00h26m14s)

[rotation by angle because if we do say a](https://youtu.be/b4mxGZlaQHY?t=00h26m17s)

[45 degree](https://youtu.be/b4mxGZlaQHY?t=00h26m20s)

[rotation](https://youtu.be/b4mxGZlaQHY?t=00h26m22s)

[right](https://youtu.be/b4mxGZlaQHY?t=00h26m25s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h26m28s)

[love to try it spin](https://youtu.be/b4mxGZlaQHY?t=00h26m30s)

[go](https://youtu.be/b4mxGZlaQHY?t=00h26m33s)

[how do i how do i make it go](https://youtu.be/b4mxGZlaQHY?t=00h26m44s)

[oh enter](https://youtu.be/b4mxGZlaQHY?t=00h26m46s)

[okay so that okay see that's that's the](https://youtu.be/b4mxGZlaQHY?t=00h26m48s)

[problem is we don't want to spin that](https://youtu.be/b4mxGZlaQHY?t=00h26m50s)

[way](https://youtu.be/b4mxGZlaQHY?t=00h26m52s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h26m53s)

[two](https://youtu.be/b4mxGZlaQHY?t=00h26m55s)

[that's not quite what we want either](https://youtu.be/b4mxGZlaQHY?t=00h27m02s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h27m06s)

[do](https://youtu.be/b4mxGZlaQHY?t=00h27m07s)

[also not quite what i'm looking for](https://youtu.be/b4mxGZlaQHY?t=00h27m10s)

[these are not](https://youtu.be/b4mxGZlaQHY?t=00h27m13s)

[these are oh](https://youtu.be/b4mxGZlaQHY?t=00h27m16s)

[this is a problem this matrix isn't big](https://youtu.be/b4mxGZlaQHY?t=00h27m17s)

[enough](https://youtu.be/b4mxGZlaQHY?t=00h27m19s)

[uh blah blah blah blah blah blah blah](https://youtu.be/b4mxGZlaQHY?t=00h27m21s)

[blah blah](https://youtu.be/b4mxGZlaQHY?t=00h27m23s)

[setting up a view matrix](https://youtu.be/b4mxGZlaQHY?t=00h27m24s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h27m28s)

[look at point](https://youtu.be/b4mxGZlaQHY?t=00h27m31s)

[i at up](https://youtu.be/b4mxGZlaQHY?t=00h27m39s)

[yeah this looks more like what i'm](https://youtu.be/b4mxGZlaQHY?t=00h27m46s)

[interested in](https://youtu.be/b4mxGZlaQHY?t=00h27m48s)

[see i'm interested in understanding the](https://youtu.be/b4mxGZlaQHY?t=00h27m54s)

[rotation](https://youtu.be/b4mxGZlaQHY?t=00h27m56s)

[about a separate axis and i do not](https://youtu.be/b4mxGZlaQHY?t=00h27m59s)

[remember my linear algebra well enough](https://youtu.be/b4mxGZlaQHY?t=00h28m01s)

[matrix rotation on x](https://youtu.be/b4mxGZlaQHY?t=00h28m05s)

[let's see](https://youtu.be/b4mxGZlaQHY?t=00h28m12s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h28m15s)

[cosine sine](https://youtu.be/b4mxGZlaQHY?t=00h28m17s)

[blah blah blah](https://youtu.be/b4mxGZlaQHY?t=00h28m20s)

[do you know what we're gonna do real](https://youtu.be/b4mxGZlaQHY?t=00h28m25s)

[quick](https://youtu.be/b4mxGZlaQHY?t=00h28m26s)

[we're going to spin it we're going to](https://youtu.be/b4mxGZlaQHY?t=00h28m35s)

[spin it a test app because i cannot](https://youtu.be/b4mxGZlaQHY?t=00h28m36s)

[remember](https://youtu.be/b4mxGZlaQHY?t=00h28m39s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h28m40s)

[how this works so we are going to play](https://youtu.be/b4mxGZlaQHY?t=00h28m41s)

[i think is the way we're gonna do this](https://youtu.be/b4mxGZlaQHY?t=00h28m44s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h28m47s)

[let's let's spin an app and](https://youtu.be/b4mxGZlaQHY?t=00h28m49s)

[pun intended spin something inside of it](https://youtu.be/b4mxGZlaQHY?t=00h28m52s)

[i'm i'm curious how that how this goes](https://youtu.be/b4mxGZlaQHY?t=00h28m55s)

[worst case scenario](https://youtu.be/b4mxGZlaQHY?t=00h28m59s)

[i i learned something](https://youtu.be/b4mxGZlaQHY?t=00h29m00s)

[because i cannot remember how this](https://youtu.be/b4mxGZlaQHY?t=00h29m02s)

[unless this thing is going to give it to](https://youtu.be/b4mxGZlaQHY?t=00h29m06s)

[me right here](https://youtu.be/b4mxGZlaQHY?t=00h29m07s)

[uh translations](https://youtu.be/b4mxGZlaQHY?t=00h29m15s)

[yeah](https://youtu.be/b4mxGZlaQHY?t=00h29m18s)

[yeah yeah yeah yeah](https://youtu.be/b4mxGZlaQHY?t=00h29m19s)

[that's not what i want okay so let's](https://youtu.be/b4mxGZlaQHY?t=00h29m21s)

[come over here so we're gonna go here](https://youtu.be/b4mxGZlaQHY?t=00h29m23s)

[we're going to go to the example project](https://youtu.be/b4mxGZlaQHY?t=00h29m25s)

[that i just dump all my samples in](https://youtu.be/b4mxGZlaQHY?t=00h29m26s)

[i think i got some sort of like](https://youtu.be/b4mxGZlaQHY?t=00h29m29s)

[animation or](https://youtu.be/b4mxGZlaQHY?t=00h29m30s)

[i have one yeah animation](https://youtu.be/b4mxGZlaQHY?t=00h29m32s)

[uh add new project](https://youtu.be/b4mxGZlaQHY?t=00h29m35s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=00h29m38s)

[wpf application sounds great](https://youtu.be/b4mxGZlaQHY?t=00h29m40s)

[let's go with](https://youtu.be/b4mxGZlaQHY?t=00h29m44s)

[matrix](https://youtu.be/b4mxGZlaQHY?t=00h29m45s)

[transform](https://youtu.be/b4mxGZlaQHY?t=00h29m46s)

[bubble bomb](https://youtu.be/b4mxGZlaQHY?t=00h29m49s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h29m49s)

[and we are going to not put you inside](https://youtu.be/b4mxGZlaQHY?t=00h29m51s)

[of there we're going to put you inside](https://youtu.be/b4mxGZlaQHY?t=00h29m54s)

[of animation select](https://youtu.be/b4mxGZlaQHY?t=00h29m55s)

[next](https://youtu.be/b4mxGZlaQHY?t=00h29m57s)

[dotnet 6 sounds great](https://youtu.be/b4mxGZlaQHY?t=00h30m00s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h30m04s)

[so here's what we're going to do we're](https://youtu.be/b4mxGZlaQHY?t=00h30m06s)

[going to go with a](https://youtu.be/b4mxGZlaQHY?t=00h30m07s)

[grid we'll have a couple columns](https://youtu.be/b4mxGZlaQHY?t=00h30m09s)

[uh so we'll have a column definition](https://youtu.be/b4mxGZlaQHY?t=00h30m12s)

[hey](https://youtu.be/b4mxGZlaQHY?t=00h30m14s)

[we'll delete it](https://youtu.be/b4mxGZlaQHY?t=00h30m15s)

[that's our column definition](https://youtu.be/b4mxGZlaQHY?t=00h30m17s)

[pretty please](https://youtu.be/b4mxGZlaQHY?t=00h30m18s)

[column dash and we'll do a width of like](https://youtu.be/b4mxGZlaQHY?t=00h30m19s)

[300 sure](https://youtu.be/b4mxGZlaQHY?t=00h30m22s)

[and then we'll do a column definition of](https://youtu.be/b4mxGZlaQHY?t=00h30m24s)

[with one star so the rest will fill](https://youtu.be/b4mxGZlaQHY?t=00h30m27s)

[okay so we're going to start with this](https://youtu.be/b4mxGZlaQHY?t=00h30m30s)

[we're going to have a border](https://youtu.be/b4mxGZlaQHY?t=00h30m32s)

[we're going to have a name of order](https://youtu.be/b4mxGZlaQHY?t=00h30m34s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h30m37s)

[background red make it big obvious it](https://youtu.be/b4mxGZlaQHY?t=00h30m39s)

[will have a](https://youtu.be/b4mxGZlaQHY?t=00h30m43s)

[width of](https://youtu.be/b4mxGZlaQHY?t=00h30m45s)

[00:30:48,559 --> 00:30:54,559](https://youtu.be/b4mxGZlaQHY?t=00h30m47s)

a height of 200

[it will be](https://youtu.be/b4mxGZlaQHY?t=00h30m52s)

[and we are going to put it in grid](https://youtu.be/b4mxGZlaQHY?t=00h30m56s)

[column one](https://youtu.be/b4mxGZlaQHY?t=00h30m59s)

[great](https://youtu.be/b4mxGZlaQHY?t=00h31m00s)

[okay we will have a stack panel on this](https://youtu.be/b4mxGZlaQHY?t=00h31m01s)

[side with a](https://youtu.be/b4mxGZlaQHY?t=00h31m04s)

[vertical alignment of center](https://youtu.be/b4mxGZlaQHY?t=00h31m06s)

[inside of the stack panel we're gonna](https://youtu.be/b4mxGZlaQHY?t=00h31m08s)

[just start putting some stuff in](https://youtu.be/b4mxGZlaQHY?t=00h31m10s)

[um actually this stack panel should](https://youtu.be/b4mxGZlaQHY?t=00h31m12s)

[probably be](https://youtu.be/b4mxGZlaQHY?t=00h31m14s)

[i think we're gonna make it a grid](https://youtu.be/b4mxGZlaQHY?t=00h31m19s)

[actually because i'm sort of thinking](https://youtu.be/b4mxGZlaQHY?t=00h31m22s)

[what might be nice is a](https://youtu.be/b4mxGZlaQHY?t=00h31m25s)

[grid with](https://youtu.be/b4mxGZlaQHY?t=00h31m29s)

[three columns three rows](https://youtu.be/b4mxGZlaQHY?t=00h31m30s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h31m33s)

[and](https://youtu.be/b4mxGZlaQHY?t=00h31m39s)

[we'll just put a text box inside of them](https://youtu.be/b4mxGZlaQHY?t=00h31m40s)

[and](https://youtu.be/b4mxGZlaQHY?t=00h31m44s)

[those will represent our](https://youtu.be/b4mxGZlaQHY?t=00h31m46s)

[are the individual elements of the uh](https://youtu.be/b4mxGZlaQHY?t=00h31m53s)

[matrix](https://youtu.be/b4mxGZlaQHY?t=00h31m55s)

[let's see so height gets](https://youtu.be/b4mxGZlaQHY?t=00h31m56s)

[auto](https://youtu.be/b4mxGZlaQHY?t=00h31m59s)

[and](https://youtu.be/b4mxGZlaQHY?t=00h32m01s)

[with](https://youtu.be/b4mxGZlaQHY?t=00h32m04s)

[gets](https://youtu.be/b4mxGZlaQHY?t=00h32m04s)

[uh we should probably fix these eat [ __ ]](https://youtu.be/b4mxGZlaQHY?t=00h32m08s)

[i don't know](https://youtu.be/b4mxGZlaQHY?t=00h32m10s)

[well the whole thing's 300 wide so](https://youtu.be/b4mxGZlaQHY?t=00h32m13s)

[give it a little patty we'll go 80](https://youtu.be/b4mxGZlaQHY?t=00h32m17s)

[80 piece](https://youtu.be/b4mxGZlaQHY?t=00h32m19s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h32m22s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h32m23s)

[that'll be fine uh](https://youtu.be/b4mxGZlaQHY?t=00h32m26s)

[vertical alignment center put](https://youtu.be/b4mxGZlaQHY?t=00h32m29s)

[two in the middle i'll make my designer](https://youtu.be/b4mxGZlaQHY?t=00h32m32s)

[a little bigger so we can kind of watch](https://youtu.be/b4mxGZlaQHY?t=00h32m34s)

[this thing build out](https://youtu.be/b4mxGZlaQHY?t=00h32m35s)

[okay so we're gonna go with](https://youtu.be/b4mxGZlaQHY?t=00h32m37s)

[uh text box](https://youtu.be/b4mxGZlaQHY?t=00h32m40s)

[uh let's see x name](https://youtu.be/b4mxGZlaQHY?t=00h32m44s)

[m1](https://youtu.be/b4mxGZlaQHY?t=00h32m47s)

[and grid column zero](https://youtu.be/b4mxGZlaQHY?t=00h32m50s)

[grid row zero these are technically](https://youtu.be/b4mxGZlaQHY?t=00h32m54s)

[defaulted to zero so we don't need this](https://youtu.be/b4mxGZlaQHY?t=00h32m56s)

[but i'm about to copy and paste a bunch](https://youtu.be/b4mxGZlaQHY?t=00h32m58s)

[so i want to make sure i get this right](https://youtu.be/b4mxGZlaQHY?t=00h33m01s)

[uh so let's see one one one two one](https://youtu.be/b4mxGZlaQHY?t=00h33m04s)

[three](https://youtu.be/b4mxGZlaQHY?t=00h33m06s)

[yeah i think we're gonna do](https://youtu.be/b4mxGZlaQHY?t=00h33m10s)

[just the](https://youtu.be/b4mxGZlaQHY?t=00h33m13s)

[upper three](https://youtu.be/b4mxGZlaQHY?t=00h33m14s)

[so one one](https://youtu.be/b4mxGZlaQHY?t=00h33m16s)

[two one three](https://youtu.be/b4mxGZlaQHY?t=00h33m21s)

[this will be 1 2](https://youtu.be/b4mxGZlaQHY?t=00h33m22s)

[and then we will](https://youtu.be/b4mxGZlaQHY?t=00h33m26s)

[copy this paste](https://youtu.be/b4mxGZlaQHY?t=00h33m28s)

[this will be](https://youtu.be/b4mxGZlaQHY?t=00h33m31s)

[00:33:35,200 --> 00:33:38,880](https://youtu.be/b4mxGZlaQHY?t=00h33m33s)

this will be

[one](https://youtu.be/b4mxGZlaQHY?t=00h33m37s)

[paste](https://youtu.be/b4mxGZlaQHY?t=00h33m38s)

[this will be](https://youtu.be/b4mxGZlaQHY?t=00h33m40s)

[three](https://youtu.be/b4mxGZlaQHY?t=00h33m42s)

[this will be](https://youtu.be/b4mxGZlaQHY?t=00h33m44s)

[two](https://youtu.be/b4mxGZlaQHY?t=00h33m45s)

[boom](https://youtu.be/b4mxGZlaQHY?t=00h33m46s)

[there we go bob's your uncle uh okay so](https://youtu.be/b4mxGZlaQHY?t=00h33m48s)

[set as startup](https://youtu.be/b4mxGZlaQHY?t=00h33m53s)

[probably fine for now](https://youtu.be/b4mxGZlaQHY?t=00h33m57s)

[uh let's see](https://youtu.be/b4mxGZlaQHY?t=00h34m00s)

[alignment center get that thing off the](https://youtu.be/b4mxGZlaQHY?t=00h34m03s)

[edge great](https://youtu.be/b4mxGZlaQHY?t=00h34m04s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=00h34m06s)

[what i'd kind of like to do](https://youtu.be/b4mxGZlaQHY?t=00h34m08s)

[uh cleaned you up](https://youtu.be/b4mxGZlaQHY?t=00h34m12s)

[let's go name space clean you up](https://youtu.be/b4mxGZlaQHY?t=00h34m15s)

[and](https://youtu.be/b4mxGZlaQHY?t=00h34m18s)

[okay so border](https://youtu.be/b4mxGZlaQHY?t=00h34m20s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h34m23s)

[can i call that thing border](https://youtu.be/b4mxGZlaQHY?t=00h34m26s)

[nickname](https://youtu.be/b4mxGZlaQHY?t=00h34m29s)

[about target just to eliminate the](https://youtu.be/b4mxGZlaQHY?t=00h34m31s)

[confusion](https://youtu.be/b4mxGZlaQHY?t=00h34m33s)

[target](https://youtu.be/b4mxGZlaQHY?t=00h34m35s)

[render](https://youtu.be/b4mxGZlaQHY?t=00h34m36s)

[transform](https://youtu.be/b4mxGZlaQHY?t=00h34m38s)

[gets new](https://youtu.be/b4mxGZlaQHY?t=00h34m40s)

[matrix transform](https://youtu.be/b4mxGZlaQHY?t=00h34m42s)

[uh oh](https://youtu.be/b4mxGZlaQHY?t=00h34m46s)

[confused because i named my namespace or](https://youtu.be/b4mxGZlaQHY?t=00h34m51s)

[my project matrix transform so](https://youtu.be/b4mxGZlaQHY?t=00h34m54s)

[system windows media](https://youtu.be/b4mxGZlaQHY?t=00h34m59s)

[about](https://youtu.be/b4mxGZlaQHY?t=00h35m02s)

[using](https://youtu.be/b4mxGZlaQHY?t=00h35m04s)

[matrix transform equals](https://youtu.be/b4mxGZlaQHY?t=00h35m06s)

[nope](https://youtu.be/b4mxGZlaQHY?t=00h35m17s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h35m23s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h35m24s)

[yeah](https://youtu.be/b4mxGZlaQHY?t=00h35m26s)

[that's a bit of a problem](https://youtu.be/b4mxGZlaQHY?t=00h35m27s)

[oh stop helping me i have auto cleanup](https://youtu.be/b4mxGZlaQHY?t=00h35m33s)

[set and it's](https://youtu.be/b4mxGZlaQHY?t=00h35m36s)

[kind of annoying at the moment okay](https://youtu.be/b4mxGZlaQHY?t=00h35m38s)

[there so matrix transform](https://youtu.be/b4mxGZlaQHY?t=00h35m41s)

[and we want it to have](https://youtu.be/b4mxGZlaQHY?t=00h35m45s)

[matrix values](https://youtu.be/b4mxGZlaQHY?t=00h35m49s)

[this way transforms](https://youtu.be/b4mxGZlaQHY?t=00h35m58s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=00h36m11s)

[identity](https://youtu.be/b4mxGZlaQHY?t=00h36m12s)

[multiply](https://youtu.be/b4mxGZlaQHY?t=00h36m13s)

[parse](https://youtu.be/b4mxGZlaQHY?t=00h36m15s)

[huh](https://youtu.be/b4mxGZlaQHY?t=00h36m18s)

[i wonder if i to string that guy if i](https://youtu.be/b4mxGZlaQHY?t=00h36m20s)

[can get a](https://youtu.be/b4mxGZlaQHY?t=00h36m22s)

[it's interesting](https://youtu.be/b4mxGZlaQHY?t=00h36m26s)

[it's formattable but it doesn't show a](https://youtu.be/b4mxGZlaQHY?t=00h36m32s)

[two string](https://youtu.be/b4mxGZlaQHY?t=00h36m36s)

[got it so this is](https://youtu.be/b4mxGZlaQHY?t=00h36m37s)

[depend rotate](https://youtu.be/b4mxGZlaQHY?t=00h36m44s)

[you skew](https://youtu.be/b4mxGZlaQHY?t=00h36m49s)

[transform](https://youtu.be/b4mxGZlaQHY?t=00h36m51s)

[this is where i think](https://youtu.be/b4mxGZlaQHY?t=00h36m53s)

[this is more what we're going to be](https://youtu.be/b4mxGZlaQHY?t=00h36m56s)

[looking for](https://youtu.be/b4mxGZlaQHY?t=00h36m57s)

[is to transform this guy](https://youtu.be/b4mxGZlaQHY?t=00h36m59s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h37m09s)

[yeah we](https://youtu.be/b4mxGZlaQHY?t=00h37m12s)

[are gonna look but](https://youtu.be/b4mxGZlaQHY?t=00h37m13s)

[let's see how this goes so matrix uh](https://youtu.be/b4mxGZlaQHY?t=00h37m16s)

[identity](https://youtu.be/b4mxGZlaQHY?t=00h37m19s)

[he's going to start like that](https://youtu.be/b4mxGZlaQHY?t=00h37m21s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h37m23s)

[and then we are going to do a](https://youtu.be/b4mxGZlaQHY?t=00h37m25s)

[that's changed](https://youtu.be/b4mxGZlaQHY?t=00h37m30s)

[i'm gonna rename this just text changed](https://youtu.be/b4mxGZlaQHY?t=00h37m36s)

[and we will end up binding all of the](https://youtu.be/b4mxGZlaQHY?t=00h37m40s)

[text boxes to this same thing](https://youtu.be/b4mxGZlaQHY?t=00h37m42s)

[though](https://youtu.be/b4mxGZlaQHY?t=00h37m45s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h37m47s)

[let's see we're going to have int](https://youtu.be/b4mxGZlaQHY?t=00h37m48s)

[get value](https://youtu.be/b4mxGZlaQHY?t=00h37m51s)

[text box](https://youtu.be/b4mxGZlaQHY?t=00h37m53s)

[uh tv](https://youtu.be/b4mxGZlaQHY?t=00h37m57s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h37m58s)

[if](https://youtu.be/b4mxGZlaQHY?t=00h38m00s)

[int](https://youtu.be/b4mxGZlaQHY?t=00h38m00s)

[try parse and i think what we're going](https://youtu.be/b4mxGZlaQHY?t=00h38m02s)

[to do is](https://youtu.be/b4mxGZlaQHY?t=00h38m04s)

[int](https://youtu.be/b4mxGZlaQHY?t=00h38m06s)

[default](https://youtu.be/b4mxGZlaQHY?t=00h38m08s)

[value](https://youtu.be/b4mxGZlaQHY?t=00h38m09s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h38m12s)

[tb.text](https://youtu.be/b4mxGZlaQHY?t=00h38m13s)

[and](https://youtu.be/b4mxGZlaQHY?t=00h38m17s)

[uh and actually we should probably do](https://youtu.be/b4mxGZlaQHY?t=00h38m20s)

[this as a double](https://youtu.be/b4mxGZlaQHY?t=00h38m21s)

[i think that's what all of the](https://youtu.be/b4mxGZlaQHY?t=00h38m24s)

[individual ones on that matrix are](https://youtu.be/b4mxGZlaQHY?t=00h38m25s)

[anyway](https://youtu.be/b4mxGZlaQHY?t=00h38m27s)

[doubles](https://youtu.be/b4mxGZlaQHY?t=00h38m29s)

[uh let's see double](https://youtu.be/b4mxGZlaQHY?t=00h38m30s)

[parsed value](https://youtu.be/b4mxGZlaQHY?t=00h38m35s)

[else return default value](https://youtu.be/b4mxGZlaQHY?t=00h38m37s)

[so i'm only doing that because i](https://youtu.be/b4mxGZlaQHY?t=00h38m44s)

[i want to use the existing one on there](https://youtu.be/b4mxGZlaQHY?t=00h38m47s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h38m50s)

[this thing will be](https://youtu.be/b4mxGZlaQHY?t=00h38m53s)

[target](https://youtu.be/b4mxGZlaQHY?t=00h38m56s)

[let's let's catch this real quick](https://youtu.be/b4mxGZlaQHY?t=00h39m01s)

[i have it and transform](https://youtu.be/b4mxGZlaQHY?t=00h39m04s)

[i think we can](https://youtu.be/b4mxGZlaQHY?t=00h39m11s)

[i think you can set](https://youtu.be/b4mxGZlaQHY?t=00h39m13s)

[that that directly](https://youtu.be/b4mxGZlaQHY?t=00h39m17s)

[new](https://youtu.be/b4mxGZlaQHY?t=00h39m25s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=00h39m32s)

[target](https://youtu.be/b4mxGZlaQHY?t=00h39m34s)

[so this will actually be just](https://youtu.be/b4mxGZlaQHY?t=00h39m35s)

[transform](https://youtu.be/b4mxGZlaQHY?t=00h39m38s)

[dot](https://youtu.be/b4mxGZlaQHY?t=00h39m40s)

[matrix and this is the property i](https://youtu.be/b4mxGZlaQHY?t=00h39m41s)

[believe is settable](https://youtu.be/b4mxGZlaQHY?t=00h39m43s)

[yeah get set](https://youtu.be/b4mxGZlaQHY?t=00h39m47s)

[perfect](https://youtu.be/b4mxGZlaQHY?t=00h39m49s)

[so we will do](https://youtu.be/b4mxGZlaQHY?t=00h39m51s)

[transform dot matrix gets](https://youtu.be/b4mxGZlaQHY?t=00h39m53s)

[new matrix](https://youtu.be/b4mxGZlaQHY?t=00h39m57s)

[this is actually going to end up being](https://youtu.be/b4mxGZlaQHY?t=00h40m10s)

[new](https://youtu.be/b4mxGZlaQHY?t=00h40m12s)

[and then this is where we're going to](https://youtu.be/b4mxGZlaQHY?t=00h40m13s)

[have to specify values](https://youtu.be/b4mxGZlaQHY?t=00h40m14s)

[it's interesting to me that it doesn't](https://youtu.be/b4mxGZlaQHY?t=00h40m16s)

[show us](https://youtu.be/b4mxGZlaQHY?t=00h40m18s)

[all of the possible values](https://youtu.be/b4mxGZlaQHY?t=00h40m22s)

[oh enter oh because some of them aren't](https://youtu.be/b4mxGZlaQHY?t=00h40m32s)

[relevant](https://youtu.be/b4mxGZlaQHY?t=00h40m34s)

[oh maybe this is why it's not being used](https://youtu.be/b4mxGZlaQHY?t=00h40m37s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h40m43s)

[okay so this is going to actually be](https://youtu.be/b4mxGZlaQHY?t=00h40m45s)

[get value](https://youtu.be/b4mxGZlaQHY?t=00h40m48s)

[m11](https://youtu.be/b4mxGZlaQHY?t=00h40m50s)

[and then](https://youtu.be/b4mxGZlaQHY?t=00h40m52s)

[distain m11](https://youtu.be/b4mxGZlaQHY?t=00h40m54s)

[we're just gonna rinse repeat this](https://youtu.be/b4mxGZlaQHY?t=00h40m56s)

[for every single one of them](https://youtu.be/b4mxGZlaQHY?t=00h40m59s)

[get value](https://youtu.be/b4mxGZlaQHY?t=00h41m03s)

[m one two](https://youtu.be/b4mxGZlaQHY?t=00h41m07s)

[existing m](https://youtu.be/b4mxGZlaQHY?t=00h41m10s)

[one two](https://youtu.be/b4mxGZlaQHY?t=00h41m12s)

[one two two](https://youtu.be/b4mxGZlaQHY?t=00h41m24s)

[one](https://youtu.be/b4mxGZlaQHY?t=00h41m28s)

[two one](https://youtu.be/b4mxGZlaQHY?t=00h41m30s)

[and then it's](https://youtu.be/b4mxGZlaQHY?t=00h41m36s)

[it's interesting that they have offset](https://youtu.be/b4mxGZlaQHY?t=00h41m37s)

[xy which i think are actually what we've](https://youtu.be/b4mxGZlaQHY?t=00h41m39s)

[labeled three one](https://youtu.be/b4mxGZlaQHY?t=00h41m42s)

[three two](https://youtu.be/b4mxGZlaQHY?t=00h41m44s)

[regardless that's what we're going to](https://youtu.be/b4mxGZlaQHY?t=00h41m46s)

[use](https://youtu.be/b4mxGZlaQHY?t=00h41m47s)

[three one](https://youtu.be/b4mxGZlaQHY?t=00h41m49s)

[three two i'm i'm kind of going from the](https://youtu.be/b4mxGZlaQHY?t=00h41m51s)

[hip here because](https://youtu.be/b4mxGZlaQHY?t=00h41m53s)

[that x](https://youtu.be/b4mxGZlaQHY?t=00h41m56s)

[offset y this may end up being the](https://youtu.be/b4mxGZlaQHY?t=00h41m59s)

[reason why the 3d plane was used](https://youtu.be/b4mxGZlaQHY?t=00h42m01s)

[but given what we're trying to do](https://youtu.be/b4mxGZlaQHY?t=00h42m09s)

[oh we didn't register up the other uh](https://youtu.be/b4mxGZlaQHY?t=00h42m17s)

[text change handlers](https://youtu.be/b4mxGZlaQHY?t=00h42m19s)

[we technically don't need to register](https://youtu.be/b4mxGZlaQHY?t=00h42m22s)

[them all but](https://youtu.be/b4mxGZlaQHY?t=00h42m23s)

[we're going to just for simplicity's](https://youtu.be/b4mxGZlaQHY?t=00h42m25s)

[sake](https://youtu.be/b4mxGZlaQHY?t=00h42m28s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h42m35s)

[and now we try it](https://youtu.be/b4mxGZlaQHY?t=00h42m39s)

[see how it works see how it works see if](https://youtu.be/b4mxGZlaQHY?t=00h42m41s)

[we can do some animation](https://youtu.be/b4mxGZlaQHY?t=00h42m43s)

[okay so if i change you to a 2](https://youtu.be/b4mxGZlaQHY?t=00h42m46s)

[that](https://youtu.be/b4mxGZlaQHY?t=00h42m50s)

[worked pretty well](https://youtu.be/b4mxGZlaQHY?t=00h42m51s)

[i change you to](https://youtu.be/b4mxGZlaQHY?t=00h42m54s)

[1 i don't expect to change if i change](https://youtu.be/b4mxGZlaQHY?t=00h42m56s)

[you to a one](https://youtu.be/b4mxGZlaQHY?t=00h42m58s)

[because the default](https://youtu.be/b4mxGZlaQHY?t=00h43m00s)

[matrix should look something like](https://youtu.be/b4mxGZlaQHY?t=00h43m02s)

[this](https://youtu.be/b4mxGZlaQHY?t=00h43m06s)

[we didn't bind anything to these other](https://youtu.be/b4mxGZlaQHY?t=00h43m08s)

[ones so these ones](https://youtu.be/b4mxGZlaQHY?t=00h43m10s)

[won't do a darn thing](https://youtu.be/b4mxGZlaQHY?t=00h43m12s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h43m15s)

[see if i do four](https://youtu.be/b4mxGZlaQHY?t=00h43m16s)

[zero](https://youtu.be/b4mxGZlaQHY?t=00h43m19s)

[um that might](https://youtu.be/b4mxGZlaQHY?t=00h43m22s)

[be that might be the reason for this is](https://youtu.be/b4mxGZlaQHY?t=00h43m24s)

[no matter what i do here](https://youtu.be/b4mxGZlaQHY?t=00h43m28s)

[there's not going to be a clean](https://youtu.be/b4mxGZlaQHY?t=00h43m35s)

[no matter what i do there will not be a](https://youtu.be/b4mxGZlaQHY?t=00h43m42s)

[clean setup for this](https://youtu.be/b4mxGZlaQHY?t=00h43m44s)

[that is](https://youtu.be/b4mxGZlaQHY?t=00h43m50s)

[probably why this thing is not](https://youtu.be/b4mxGZlaQHY?t=00h43m52s)

[exposing it](https://youtu.be/b4mxGZlaQHY?t=00h43m57s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h43m59s)

[that would also be why](https://youtu.be/b4mxGZlaQHY?t=00h44m03s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h44m06s)

[i'm a little surprised](https://youtu.be/b4mxGZlaQHY?t=00h44m07s)

[let me just confirm my suspicions wpf](https://youtu.be/b4mxGZlaQHY?t=00h44m11s)

[bb he takes](https://youtu.be/b4mxGZlaQHY?t=00h44m14s)

[and say transform](https://youtu.be/b4mxGZlaQHY?t=00h44m30s)

[3d](https://youtu.be/b4mxGZlaQHY?t=00h44m33s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h44m38s)

[i know this is somewhat possible because](https://youtu.be/b4mxGZlaQHY?t=00h44m40s)

[snoop does it](https://youtu.be/b4mxGZlaQHY?t=00h44m42s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h44m44s)

[wait](https://youtu.be/b4mxGZlaQHY?t=00h44m50s)

[let's form 3d](https://youtu.be/b4mxGZlaQHY?t=00h44m52s)

[okay i just want to confirm are you a](https://youtu.be/b4mxGZlaQHY?t=00h44m57s)

[can i just](https://youtu.be/b4mxGZlaQHY?t=00h44m59s)

[assign you to a](https://youtu.be/b4mxGZlaQHY?t=00h45m01s)

[i don't think i can just assign you to a](https://youtu.be/b4mxGZlaQHY?t=00h45m08s)

[what i was](https://youtu.be/b4mxGZlaQHY?t=00h45m17s)

[thinking is that wasn't going to be](https://youtu.be/b4mxGZlaQHY?t=00h45m18s)

[possible](https://youtu.be/b4mxGZlaQHY?t=00h45m20s)

[but how does one end up doing this](https://youtu.be/b4mxGZlaQHY?t=00h45m22s)

[view box oh so this is going back to](https://youtu.be/b4mxGZlaQHY?t=00h45m25s)

[that perspective camera again oh damn](https://youtu.be/b4mxGZlaQHY?t=00h45m27s)

[but this is a heck of a lot simpler than](https://youtu.be/b4mxGZlaQHY?t=00h45m34s)

[the other one](https://youtu.be/b4mxGZlaQHY?t=00h45m36s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h45m39s)

[felt like the 3d object cannot be seen](https://youtu.be/b4mxGZlaQHY?t=00h45m43s)

[okay so i actually have a theory because](https://youtu.be/b4mxGZlaQHY?t=00h45m49s)

[i think what i want to do](https://youtu.be/b4mxGZlaQHY?t=00h45m52s)

[is whatever](https://youtu.be/b4mxGZlaQHY?t=00h45m55s)

[snoop must be doing something similar to](https://youtu.be/b4mxGZlaQHY?t=00h45m58s)

[this](https://youtu.be/b4mxGZlaQHY?t=00h46m00s)

[let's let's go with spelunky](https://youtu.be/b4mxGZlaQHY?t=00h46m01s)

[visualize 3d view](https://youtu.be/b4mxGZlaQHY?t=00h46m05s)

[this is kind of like what we're looking](https://youtu.be/b4mxGZlaQHY?t=00h46m08s)

[for](https://youtu.be/b4mxGZlaQHY?t=00h46m09s)

[my amazon device is speaking to me and](https://youtu.be/b4mxGZlaQHY?t=00h46m14s)

[i'm not sure how i feel about that](https://youtu.be/b4mxGZlaQHY?t=00h46m16s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h46m21s)

[the this looks a heck of a lot nicer](https://youtu.be/b4mxGZlaQHY?t=00h46m24s)

[this looks a heck of a lot nicer](https://youtu.be/b4mxGZlaQHY?t=00h46m32s)

[for visual to model 3d](https://youtu.be/b4mxGZlaQHY?t=00h46m38s)

[yeah](https://youtu.be/b4mxGZlaQHY?t=00h46m45s)

[this](https://youtu.be/b4mxGZlaQHY?t=00h46m46s)

[this be what i want to play with](https://youtu.be/b4mxGZlaQHY?t=00h46m47s)

[i would like to play with this](https://youtu.be/b4mxGZlaQHY?t=00h46m51s)

[yes so](https://youtu.be/b4mxGZlaQHY?t=00h47m05s)

[let's look at this because i think this](https://youtu.be/b4mxGZlaQHY?t=00h47m07s)

[might be a lot easier than trying to do](https://youtu.be/b4mxGZlaQHY?t=00h47m09s)

[the](https://youtu.be/b4mxGZlaQHY?t=00h47m11s)

[and this has already been updated for](https://youtu.be/b4mxGZlaQHY?t=00h47m15s)

[latest c-sharp versions oh i love it i](https://youtu.be/b4mxGZlaQHY?t=00h47m16s)

[love it i love it i love it](https://youtu.be/b4mxGZlaQHY?t=00h47m19s)

[i love everything about](https://youtu.be/b4mxGZlaQHY?t=00h47m21s)

[this okay so we're going to take](https://youtu.be/b4mxGZlaQHY?t=00h47m22s)

[this thing for a little spin](https://youtu.be/b4mxGZlaQHY?t=00h47m27s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h47m29s)

[um right just trying to decide where i](https://youtu.be/b4mxGZlaQHY?t=00h47m36s)

[want to put this](https://youtu.be/b4mxGZlaQHY?t=00h47m39s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h47m41s)

[let's take this and put it in the](https://youtu.be/b4mxGZlaQHY?t=00h47m45s)

[example project real quick](https://youtu.be/b4mxGZlaQHY?t=00h47m48s)

[let's see so that's going to be here](https://youtu.be/b4mxGZlaQHY?t=00h47m52s)

[here](https://youtu.be/b4mxGZlaQHY?t=00h47m54s)

[sorry i'll bring it back on screen in](https://youtu.be/b4mxGZlaQHY?t=00h47m56s)

[just a moment](https://youtu.be/b4mxGZlaQHY?t=00h47m57s)

[make sure i don't accidentally do](https://youtu.be/b4mxGZlaQHY?t=00h48m00s)

[something stupid](https://youtu.be/b4mxGZlaQHY?t=00h48m01s)

[i've been known to do every so often](https://youtu.be/b4mxGZlaQHY?t=00h48m04s)

[okay so this this is going to go into](https://youtu.be/b4mxGZlaQHY?t=00h48m07s)

[here](https://youtu.be/b4mxGZlaQHY?t=00h48m09s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h48m10s)

[sure save](https://youtu.be/b4mxGZlaQHY?t=00h48m11s)

[okay so let's let's take a](https://youtu.be/b4mxGZlaQHY?t=00h48m14s)

[little look-see here so step one stop](https://youtu.be/b4mxGZlaQHY?t=00h48m17s)

[debugging](https://youtu.be/b4mxGZlaQHY?t=00h48m20s)

[step two](https://youtu.be/b4mxGZlaQHY?t=00h48m22s)

[change name space](https://youtu.be/b4mxGZlaQHY?t=00h48m24s)

[and then](https://youtu.be/b4mxGZlaQHY?t=00h48m25s)

[give credit where credit is due](https://youtu.be/b4mxGZlaQHY?t=00h48m28s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h48m32s)

[did i close that](https://youtu.be/b4mxGZlaQHY?t=00h48m33s)

[i did](https://youtu.be/b4mxGZlaQHY?t=00h48m35s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h48m37s)

[see](https://youtu.be/b4mxGZlaQHY?t=00h48m39s)

[taken from](https://youtu.be/b4mxGZlaQHY?t=00h48m42s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h48m45s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h48m46s)

[clean that up](https://youtu.be/b4mxGZlaQHY?t=00h48m48s)

[and then](https://youtu.be/b4mxGZlaQHY?t=00h48m50s)

[trackball behavior we don't care about](https://youtu.be/b4mxGZlaQHY?t=00h48m52s)

[that just going to get rid of that](https://youtu.be/b4mxGZlaQHY?t=00h48m54s)

[get rid of that](https://youtu.be/b4mxGZlaQHY?t=00h48m58s)

[we're going to manipulate this in a](https://youtu.be/b4mxGZlaQHY?t=00h48m59s)

[variety of different ways](https://youtu.be/b4mxGZlaQHY?t=00h49m02s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h49m05s)

[mesh freeze if possible](https://youtu.be/b4mxGZlaQHY?t=00h49m06s)

[uh i don't know what that method does](https://youtu.be/b4mxGZlaQHY?t=00h49m11s)

[let's go here](https://youtu.be/b4mxGZlaQHY?t=00h49m16s)

[freeze if possible](https://youtu.be/b4mxGZlaQHY?t=00h49m17s)

[usable extensions](https://youtu.be/b4mxGZlaQHY?t=00h49m20s)

[okay let's borrow that method real quick](https://youtu.be/b4mxGZlaQHY?t=00h49m24s)

[pretty simple one uh](https://youtu.be/b4mxGZlaQHY?t=00h49m28s)

[slap that in there](https://youtu.be/b4mxGZlaQHY?t=00h49m32s)

[right](https://youtu.be/b4mxGZlaQHY?t=00h49m35s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h49m37s)

[and then that should be](https://youtu.be/b4mxGZlaQHY?t=00h49m39s)

[then you just move](https://youtu.be/b4mxGZlaQHY?t=00h49m43s)

[mesh goes here](https://youtu.be/b4mxGZlaQHY?t=00h49m46s)

[goes here](https://youtu.be/b4mxGZlaQHY?t=00h49m51s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h50m02s)

[and we've got one more in here](https://youtu.be/b4mxGZlaQHY?t=00h50m04s)

[okay that gets us there](https://youtu.be/b4mxGZlaQHY?t=00h50m07s)

[visual capture utils](https://youtu.be/b4mxGZlaQHY?t=00h50m10s)

[grab](https://youtu.be/b4mxGZlaQHY?t=00h50m15s)

[the image brush](https://youtu.be/b4mxGZlaQHY?t=00h50m16s)

[so this thing is still](https://youtu.be/b4mxGZlaQHY?t=00h50m18s)

[somewhat doing the same](https://youtu.be/b4mxGZlaQHY?t=00h50m21s)

[image brushy stuff](https://youtu.be/b4mxGZlaQHY?t=00h50m25s)

[we're going to turn you off for the](https://youtu.be/b4mxGZlaQHY?t=00h50m29s)

[moment stop yelling at me](https://youtu.be/b4mxGZlaQHY?t=00h50m30s)

[i need to go find this guy](https://youtu.be/b4mxGZlaQHY?t=00h50m32s)

[uh show me that](https://youtu.be/b4mxGZlaQHY?t=00h50m36s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h50m41s)

[it's gonna go raw](https://youtu.be/b4mxGZlaQHY?t=00h50m47s)

[probably just gonna strip down the one](https://youtu.be/b4mxGZlaQHY?t=00h50m51s)

[bit that we need](https://youtu.be/b4mxGZlaQHY?t=00h50m54s)

[okay so specifically we're looking for](https://youtu.be/b4mxGZlaQHY?t=00h51m00s)

[render visual](https://youtu.be/b4mxGZlaQHY?t=00h51m02s)

[render visual](https://youtu.be/b4mxGZlaQHY?t=00h51m06s)

[i'd like to bring](https://youtu.be/b4mxGZlaQHY?t=00h51m09s)

[just you over](https://youtu.be/b4mxGZlaQHY?t=00h51m11s)

[we're going to go](https://youtu.be/b4mxGZlaQHY?t=00h51m15s)

[private on that](https://youtu.be/b4mxGZlaQHY?t=00h51m17s)

[drop the class name](https://youtu.be/b4mxGZlaQHY?t=00h51m21s)

[you become](https://youtu.be/b4mxGZlaQHY?t=00h51m24s)

[that](https://youtu.be/b4mxGZlaQHY?t=00h51m25s)

[i assume](https://youtu.be/b4mxGZlaQHY?t=00h51m27s)

[base dpi yeah just a fixed constant](https://youtu.be/b4mxGZlaQHY?t=00h51m36s)

[put that at the top too](https://youtu.be/b4mxGZlaQHY?t=00h51m40s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h51m41s)

[something like that](https://youtu.be/b4mxGZlaQHY?t=00h51m44s)

[and binding flags requires reflection](https://youtu.be/b4mxGZlaQHY?t=00h51m47s)

[wow](https://youtu.be/b4mxGZlaQHY?t=00h51m55s)

[that's that's exciting](https://youtu.be/b4mxGZlaQHY?t=00h51m56s)

[render for bitmap effect](https://youtu.be/b4mxGZlaQHY?t=00h52m02s)

[it is in fact non-public](https://youtu.be/b4mxGZlaQHY?t=00h52m08s)

[that's uh](https://youtu.be/b4mxGZlaQHY?t=00h52m13s)

[that's pretty cool](https://youtu.be/b4mxGZlaQHY?t=00h52m15s)

[okay so that means you](https://youtu.be/b4mxGZlaQHY?t=00h52m17s)

[don't need anymore](https://youtu.be/b4mxGZlaQHY?t=00h52m19s)

[and you](https://youtu.be/b4mxGZlaQHY?t=00h52m22s)

[um extension method so the one i copied](https://youtu.be/b4mxGZlaQHY?t=00h52m26s)

[in is](https://youtu.be/b4mxGZlaQHY?t=00h52m29s)

[no bueno](https://youtu.be/b4mxGZlaQHY?t=00h52m31s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h52m33s)

[okay but that should](https://youtu.be/b4mxGZlaQHY?t=00h52m35s)

[give us something we can play with](https://youtu.be/b4mxGZlaQHY?t=00h52m40s)

[this is a viewport 3d](https://youtu.be/b4mxGZlaQHY?t=00h52m44s)

[just fine](https://youtu.be/b4mxGZlaQHY?t=00h52m48s)

[go back over to here](https://youtu.be/b4mxGZlaQHY?t=00h52m51s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h52m56s)

[this guy here](https://youtu.be/b4mxGZlaQHY?t=00h52m58s)

[we can just put you down i think](https://youtu.be/b4mxGZlaQHY?t=00h53m05s)

[i think we can just add you into our](https://youtu.be/b4mxGZlaQHY?t=00h53m10s)

[main window](https://youtu.be/b4mxGZlaQHY?t=00h53m13s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h53m15s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h53m16s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h53m17s)

[and logical child](https://youtu.be/b4mxGZlaQHY?t=00h53m25s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h53m28s)

[can i](https://youtu.be/b4mxGZlaQHY?t=00h53m30s)

[change this thing up to be later](https://youtu.be/b4mxGZlaQHY?t=00h53m31s)

[doesn't look like it](https://youtu.be/b4mxGZlaQHY?t=00h53m35s)

[does it seem](https://youtu.be/b4mxGZlaQHY?t=00h53m39s)

[i'm wondering if this is going to run a](https://youtu.be/b4mxGZlaQHY?t=00h53m46s)

[muck of the idea of this thing](https://youtu.be/b4mxGZlaQHY?t=00h53m48s)

[get content visual bounds](https://youtu.be/b4mxGZlaQHY?t=00h53m50s)

[of wanting to actually have the thing](https://youtu.be/b4mxGZlaQHY?t=00h53m54s)

[rendered first](https://youtu.be/b4mxGZlaQHY?t=00h53m56s)

[let's put it behind a button](https://youtu.be/b4mxGZlaQHY?t=00h53m57s)

[pick](https://youtu.be/b4mxGZlaQHY?t=00h54m00s)

[just](https://youtu.be/b4mxGZlaQHY?t=00h54m02s)

[no](https://youtu.be/b4mxGZlaQHY?t=00h54m03s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h54m04s)

[your visual studio please stop doing](https://youtu.be/b4mxGZlaQHY?t=00h54m06s)

[that](https://youtu.be/b4mxGZlaQHY?t=00h54m08s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h54m10s)

[let's put you behind a button me thinks](https://youtu.be/b4mxGZlaQHY?t=00h54m13s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h54m17s)

[button](https://youtu.be/b4mxGZlaQHY?t=00h54m22s)

[i don't know click](https://youtu.be/b4mxGZlaQHY?t=00h54m24s)

[event handler](https://youtu.be/b4mxGZlaQHY?t=00h54m26s)

[grid](https://youtu.be/b4mxGZlaQHY?t=00h54m28s)

[row two](https://youtu.be/b4mxGZlaQHY?t=00h54m29s)

[grid column](https://youtu.be/b4mxGZlaQHY?t=00h54m32s)

[boom](https://youtu.be/b4mxGZlaQHY?t=00h54m35s)

[just make that sell a button for now](https://youtu.be/b4mxGZlaQHY?t=00h54m37s)

[and on button click](https://youtu.be/b4mxGZlaQHY?t=00h54m39s)

[we'll go](https://youtu.be/b4mxGZlaQHY?t=00h54m42s)

[our](https://youtu.be/b4mxGZlaQHY?t=00h54m45s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h54m45s)

[view gets](https://youtu.be/b4mxGZlaQHY?t=00h54m48s)

[new](https://youtu.be/b4mxGZlaQHY?t=00h54m50s)

[visual](https://youtu.be/b4mxGZlaQHY?t=00h54m58s)

[3d view](https://youtu.be/b4mxGZlaQHY?t=00h55m00s)

[i want this guy to be target](https://youtu.be/b4mxGZlaQHY?t=00h55m03s)

[and it wants a dpi](https://youtu.be/b4mxGZlaQHY?t=00h55m10s)

[i think what we're going to do is make](https://youtu.be/b4mxGZlaQHY?t=00h55m13s)

[you](https://youtu.be/b4mxGZlaQHY?t=00h55m14s)

[optional i'm guessing where do you get](https://youtu.be/b4mxGZlaQHY?t=00h55m18s)

[used](https://youtu.be/b4mxGZlaQHY?t=00h55m21s)

[right there](https://youtu.be/b4mxGZlaQHY?t=00h55m24s)

[yeah we're going to do that and go](https://youtu.be/b4mxGZlaQHY?t=00h55m27s)

[base dpi](https://youtu.be/b4mxGZlaQHY?t=00h55m29s)

[i cannot convert from double to int](https://youtu.be/b4mxGZlaQHY?t=00h55m35s)

[really can](https://youtu.be/b4mxGZlaQHY?t=00h55m39s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h55m41s)

[i don't want to think too much about dpi](https://youtu.be/b4mxGZlaQHY?t=00h55m45s)

[at the moment and then we're going to do](https://youtu.be/b4mxGZlaQHY?t=00h55m47s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h55m51s)

[let's go over here and go](https://youtu.be/b4mxGZlaQHY?t=00h55m52s)

[grid](https://youtu.be/b4mxGZlaQHY?t=00h55m55s)

[grid](https://youtu.be/b4mxGZlaQHY?t=00h55m57s)

[column one](https://youtu.be/b4mxGZlaQHY?t=00h55m58s)

[boom](https://youtu.be/b4mxGZlaQHY?t=00h56m01s)

[you up](https://youtu.be/b4mxGZlaQHY?t=00h56m03s)

[we will do](https://youtu.be/b4mxGZlaQHY?t=00h56m06s)

[grid row definitions we're going to just](https://youtu.be/b4mxGZlaQHY?t=00h56m08s)

[do a couple rows](https://youtu.be/b4mxGZlaQHY?t=00h56m11s)

[equal spacing](https://youtu.be/b4mxGZlaQHY?t=00h56m14s)

[you're going to sit there](https://youtu.be/b4mxGZlaQHY?t=00h56m17s)

[uh](https://youtu.be/b4mxGZlaQHY?t=00h56m19s)

[name](https://youtu.be/b4mxGZlaQHY?t=00h56m21s)

[content](https://youtu.be/b4mxGZlaQHY?t=00h56m23s)

[rather than adding that there](https://youtu.be/b4mxGZlaQHY?t=00h56m25s)

[though grid](https://youtu.be/b4mxGZlaQHY?t=00h56m28s)

[set row](https://youtu.be/b4mxGZlaQHY?t=00h56m30s)

[of view will be row one](https://youtu.be/b4mxGZlaQHY?t=00h56m32s)

[and then we will do](https://youtu.be/b4mxGZlaQHY?t=00h56m35s)

[mr adam](https://youtu.be/b4mxGZlaQHY?t=00h56m40s)

[doing well so i've i've started down a](https://youtu.be/b4mxGZlaQHY?t=00h56m42s)

[rabbit trail as i often do](https://youtu.be/b4mxGZlaQHY?t=00h56m45s)

[i am](https://youtu.be/b4mxGZlaQHY?t=00h56m49s)

[i'm trying to rethink the flipper](https://youtu.be/b4mxGZlaQHY?t=00h56m51s)

[control and i am](https://youtu.be/b4mxGZlaQHY?t=00h56m53s)

[shame](https://youtu.be/b4mxGZlaQHY?t=00h56m55s)

[shamefully stealing from snoop](https://youtu.be/b4mxGZlaQHY?t=00h56m56s)

[so if we um](https://youtu.be/b4mxGZlaQHY?t=00h56m58s)

[i don't know here we'll just target](https://youtu.be/b4mxGZlaQHY?t=00h57m00s)

[visual studio](https://youtu.be/b4mxGZlaQHY?t=00h57m02s)

[so if you fire up visual studio and you](https://youtu.be/b4mxGZlaQHY?t=00h57m04s)

[find a](https://youtu.be/b4mxGZlaQHY?t=00h57m06s)

[uh one of these guys](https://youtu.be/b4mxGZlaQHY?t=00h57m09s)

[this guy that'll work](https://youtu.be/b4mxGZlaQHY?t=00h57m12s)

[you if you open up the](https://youtu.be/b4mxGZlaQHY?t=00h57m14s)

[magnifier window](https://youtu.be/b4mxGZlaQHY?t=00h57m16s)

[you'll note this thing has a 3d view](https://youtu.be/b4mxGZlaQHY?t=00h57m18s)

[that](https://youtu.be/b4mxGZlaQHY?t=00h57m21s)

[allows you to do this kind of stuff to](https://youtu.be/b4mxGZlaQHY?t=00h57m22s)

[the elements](https://youtu.be/b4mxGZlaQHY?t=00h57m24s)

[which is which is pretty cool](https://youtu.be/b4mxGZlaQHY?t=00h57m27s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h57m30s)

[and i'm i'm trying to see if i can](https://youtu.be/b4mxGZlaQHY?t=00h57m31s)

[leverage](https://youtu.be/b4mxGZlaQHY?t=00h57m33s)

[the 3d control inside of snoop to do the](https://youtu.be/b4mxGZlaQHY?t=00h57m34s)

[flipper control for material design](https://youtu.be/b4mxGZlaQHY?t=00h57m38s)

[that's the thinking because](https://youtu.be/b4mxGZlaQHY?t=00h57m42s)

[that looks a lot like flipper to me](https://youtu.be/b4mxGZlaQHY?t=00h57m46s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h57m48s)

[we're trying it and right now we're](https://youtu.be/b4mxGZlaQHY?t=00h57m51s)

[playing with the control in a a separate](https://youtu.be/b4mxGZlaQHY?t=00h57m52s)

[app just for](https://youtu.be/b4mxGZlaQHY?t=00h57m55s)

[just for grins uh let's see](https://youtu.be/b4mxGZlaQHY?t=00h57m57s)

[whoopsy and here we see the problem with](https://youtu.be/b4mxGZlaQHY?t=00h57m59s)

[attaching](https://youtu.be/b4mxGZlaQHY?t=00h58m02s)

[snoop](https://youtu.be/b4mxGZlaQHY?t=00h58m04s)

[right](https://youtu.be/b4mxGZlaQHY?t=00h58m08s)

[i shouldn't have done that](https://youtu.be/b4mxGZlaQHY?t=00h58m10s)

[um some of visual studio gets very very](https://youtu.be/b4mxGZlaQHY?t=00h58m12s)

[unhappy](https://youtu.be/b4mxGZlaQHY?t=00h58m16s)

[if you um](https://youtu.be/b4mxGZlaQHY?t=00h58m18s)

[snoop it](https://youtu.be/b4mxGZlaQHY?t=00h58m20s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h58m24s)

[but proof in the pudding](https://youtu.be/b4mxGZlaQHY?t=00h58m25s)

[parts of visual studio or wpf](https://youtu.be/b4mxGZlaQHY?t=00h58m27s)

[so](https://youtu.be/b4mxGZlaQHY?t=00h58m33s)

[long live wpf](https://youtu.be/b4mxGZlaQHY?t=00h58m34s)

[okay so let's go back here and go](https://youtu.be/b4mxGZlaQHY?t=00h58m37s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=00h58m40s)

[content grid](https://youtu.be/b4mxGZlaQHY?t=00h58m41s)

[uh children](https://youtu.be/b4mxGZlaQHY?t=00h58m44s)

[ad](https://youtu.be/b4mxGZlaQHY?t=00h58m46s)

[you](https://youtu.be/b4mxGZlaQHY?t=00h58m48s)

[i think that should be good enough to](https://youtu.be/b4mxGZlaQHY?t=00h58m49s)

[make it work](https://youtu.be/b4mxGZlaQHY?t=00h58m51s)

[find out](https://youtu.be/b4mxGZlaQHY?t=00h58m53s)

[because i want to see if we can get](https://youtu.be/b4mxGZlaQHY?t=00h58m55s)

[if this other control works and i can](https://youtu.be/b4mxGZlaQHY?t=00h58m59s)

[make it work well enough](https://youtu.be/b4mxGZlaQHY?t=00h59m02s)

[okay so that](https://youtu.be/b4mxGZlaQHY?t=00h59m05s)

[that clearly did something](https://youtu.be/b4mxGZlaQHY?t=00h59m08s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h59m12s)

[that's that's big](https://youtu.be/b4mxGZlaQHY?t=00h59m13s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=00h59m15s)

[new plan of attack here](https://youtu.be/b4mxGZlaQHY?t=00h59m17s)

[um](https://youtu.be/b4mxGZlaQHY?t=00h59m19s)

[step one this whole thing needs to be in](https://youtu.be/b4mxGZlaQHY?t=00h59m22s)

[a scroll viewer](https://youtu.be/b4mxGZlaQHY?t=00h59m24s)

[because](https://youtu.be/b4mxGZlaQHY?t=00h59m28s)

[darn it i need to be able to scroll this](https://youtu.be/b4mxGZlaQHY?t=00h59m29s)

[thing up and down](https://youtu.be/b4mxGZlaQHY?t=00h59m31s)

[so step one we're going to give me](https://youtu.be/b4mxGZlaQHY?t=00h59m33s)

[scroll bars](https://youtu.be/b4mxGZlaQHY?t=00h59m34s)

[okay](https://youtu.be/b4mxGZlaQHY?t=00h59m37s)

[so apparently doing that caused](https://youtu.be/b4mxGZlaQHY?t=00h59m41s)

[i i rest my case](https://youtu.be/b4mxGZlaQHY?t=00h59m44s)

[the the hot reload is great until it's](https://youtu.be/b4mxGZlaQHY?t=00h59m46s)

[not](https://youtu.be/b4mxGZlaQHY?t=00h59m48s)

[and then you restart your app](https://youtu.be/b4mxGZlaQHY?t=00h59m49s)

[whatever reason my test windows are](https://youtu.be/b4mxGZlaQHY?t=00h59m52s)

[going crazy there are no unit tests](https://youtu.be/b4mxGZlaQHY?t=00h59m55s)

[hands off](https://youtu.be/b4mxGZlaQHY?t=00h59m57s)

[hands off](https://youtu.be/b4mxGZlaQHY?t=00h59m59s)

[because i wanted to do something fancy](https://youtu.be/b4mxGZlaQHY?t=01h00m04s)

[with like a matrix transform just](https://youtu.be/b4mxGZlaQHY?t=01h00m06s)

[directly on the content presenter](https://youtu.be/b4mxGZlaQHY?t=01h00m08s)

[i have since](https://youtu.be/b4mxGZlaQHY?t=01h00m11s)

[learned potentially relearned](https://youtu.be/b4mxGZlaQHY?t=01h00m12s)

[that](https://youtu.be/b4mxGZlaQHY?t=01h00m15s)

[that is not reasonably possible with the](https://youtu.be/b4mxGZlaQHY?t=01h00m17s)

[wpf 3d transform bits](https://youtu.be/b4mxGZlaQHY?t=01h00m19s)

[hey](https://youtu.be/b4mxGZlaQHY?t=01h00m22s)

[where'd you go launch](https://youtu.be/b4mxGZlaQHY?t=01h00m23s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h00m25s)

[they are you want to do it you have to](https://youtu.be/b4mxGZlaQHY?t=01h00m26s)

[use the perspective camera and](https://youtu.be/b4mxGZlaQHY?t=01h00m29s)

[well that requires some other stuff okay](https://youtu.be/b4mxGZlaQHY?t=01h00m32s)

[so that gets me](https://youtu.be/b4mxGZlaQHY?t=01h00m34s)

[that gets me better](https://youtu.be/b4mxGZlaQHY?t=01h00m36s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h00m40s)

[well](https://youtu.be/b4mxGZlaQHY?t=01h00m44s)

[those scroll bars are problematic okay](https://youtu.be/b4mxGZlaQHY?t=01h00m46s)

[so but](https://youtu.be/b4mxGZlaQHY?t=01h00m48s)

[that is good-ish the thing renders yeah](https://youtu.be/b4mxGZlaQHY?t=01h00m51s)

[sure fine fix the line endings okay so](https://youtu.be/b4mxGZlaQHY?t=01h00m54s)

[now the question is what are the](https://youtu.be/b4mxGZlaQHY?t=01h00m58s)

[things to do so z scale is set to 1 by](https://youtu.be/b4mxGZlaQHY?t=01h01m00s)

[default which is fine](https://youtu.be/b4mxGZlaQHY?t=01h01m03s)

[um we may adjust that](https://youtu.be/b4mxGZlaQHY?t=01h01m07s)

[a little bit](https://youtu.be/b4mxGZlaQHY?t=01h01m10s)

[um i'm kind of curious what happens if](https://youtu.be/b4mxGZlaQHY?t=01h01m12s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h01m17s)

[let's see](https://youtu.be/b4mxGZlaQHY?t=01h01m19s)

[view](https://youtu.be/b4mxGZlaQHY?t=01h01m20s)

[vertical alignment](https://youtu.be/b4mxGZlaQHY?t=01h01m21s)

[center](https://youtu.be/b4mxGZlaQHY?t=01h01m24s)

[view](https://youtu.be/b4mxGZlaQHY?t=01h01m27s)

[horizontal alignment gets horizontal](https://youtu.be/b4mxGZlaQHY?t=01h01m28s)

[alignment center so rather than having](https://youtu.be/b4mxGZlaQHY?t=01h01m30s)

[it fill i bet it's a little cleaner if](https://youtu.be/b4mxGZlaQHY?t=01h01m33s)

[we just center that guy up](https://youtu.be/b4mxGZlaQHY?t=01h01m35s)

[either it's going to shrink all the way](https://youtu.be/b4mxGZlaQHY?t=01h01m38s)

[down and have no concept of its size](https://youtu.be/b4mxGZlaQHY?t=01h01m40s)

[nope still going to be big okay](https://youtu.be/b4mxGZlaQHY?t=01h01m43s)

[so](https://youtu.be/b4mxGZlaQHY?t=01h01m45s)

[something about that makes it go big](https://youtu.be/b4mxGZlaQHY?t=01h01m46s)

[that's fine-ish i guess](https://youtu.be/b4mxGZlaQHY?t=01h01m50s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h01m55s)

[make brush from visual](https://youtu.be/b4mxGZlaQHY?t=01h01m57s)

[it does the](https://youtu.be/b4mxGZlaQHY?t=01h01m59s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h02m00s)

[needful then it does a render visual](https://youtu.be/b4mxGZlaQHY?t=01h02m04s)

[where it does a whole bunch of stuff and](https://youtu.be/b4mxGZlaQHY?t=01h02m10s)

[does render target bitmap](https://youtu.be/b4mxGZlaQHY?t=01h02m12s)

[has some cool stuff in here i'm](https://youtu.be/b4mxGZlaQHY?t=01h02m14s)

[interested to know where the thing does](https://youtu.be/b4mxGZlaQHY?t=01h02m16s)

[the](https://youtu.be/b4mxGZlaQHY?t=01h02m19s)

[the rotation and i'm wondering if that's](https://youtu.be/b4mxGZlaQHY?t=01h02m21s)

[the behavior that i unfortunately](https://youtu.be/b4mxGZlaQHY?t=01h02m23s)

[next](https://youtu.be/b4mxGZlaQHY?t=01h02m26s)

[transform 3d](https://youtu.be/b4mxGZlaQHY?t=01h02m29s)

[model transform so this guy here is](https://youtu.be/b4mxGZlaQHY?t=01h02m33s)

[what's doing this](https://youtu.be/b4mxGZlaQHY?t=01h02m36s)

[a model transfer i could just hunt this](https://youtu.be/b4mxGZlaQHY?t=01h02m40s)

[guy](https://youtu.be/b4mxGZlaQHY?t=01h02m42s)

[and probably get a pretty good idea of](https://youtu.be/b4mxGZlaQHY?t=01h02m43s)

[where you're going](https://youtu.be/b4mxGZlaQHY?t=01h02m49s)

[these bounds are](https://youtu.be/b4mxGZlaQHY?t=01h02m51s)

[probably being set largest which is](https://youtu.be/b4mxGZlaQHY?t=01h02m53s)

[where these things are coming in from i](https://youtu.be/b4mxGZlaQHY?t=01h02m55s)

[assume these bounds are probably based](https://youtu.be/b4mxGZlaQHY?t=01h02m57s)

[upon wherever it's](https://youtu.be/b4mxGZlaQHY?t=01h02m58s)

[that scale transform 3d](https://youtu.be/b4mxGZlaQHY?t=01h03m00s)

[these scale transform](https://youtu.be/b4mxGZlaQHY?t=01h03m08s)

[i want to know](https://youtu.be/b4mxGZlaQHY?t=01h03m14s)

[z scale so we can we can make z scale go](https://youtu.be/b4mxGZlaQHY?t=01h03m17s)

[bigger and smaller that's fine but](https://youtu.be/b4mxGZlaQHY?t=01h03m19s)

[that's not really what i want](https://youtu.be/b4mxGZlaQHY?t=01h03m22s)

[i want to modify you so i can make you](https://youtu.be/b4mxGZlaQHY?t=01h03m24s)

[this guy](https://youtu.be/b4mxGZlaQHY?t=01h03m29s)

[no this is a translate offset](https://youtu.be/b4mxGZlaQHY?t=01h03m31s)

[that's just x y we don't care about that](https://youtu.be/b4mxGZlaQHY?t=01h03m34s)

[um if matrix is not identity](https://youtu.be/b4mxGZlaQHY?t=01h03m37s)

[it does a 3d matrix](https://youtu.be/b4mxGZlaQHY?t=01h03m41s)

[and then sets that into the model](https://youtu.be/b4mxGZlaQHY?t=01h03m45s)

[i'm happy about this but where](https://youtu.be/b4mxGZlaQHY?t=01h03m49s)

[something in here needs to not just be](https://youtu.be/b4mxGZlaQHY?t=01h03m53s)

[using identity values](https://youtu.be/b4mxGZlaQHY?t=01h03m55s)

[something has to change it](https://youtu.be/b4mxGZlaQHY?t=01h03m58s)

[uh let's see](https://youtu.be/b4mxGZlaQHY?t=01h04m06s)

[push transform offset matrix transform](https://youtu.be/b4mxGZlaQHY?t=01h04m07s)

[but this is legitimately just a](https://youtu.be/b4mxGZlaQHY?t=01h04m12s)

[xy shift](https://youtu.be/b4mxGZlaQHY?t=01h04m15s)

[that's not going to do anything other](https://youtu.be/b4mxGZlaQHY?t=01h04m18s)

[than that](https://youtu.be/b4mxGZlaQHY?t=01h04m20s)

[this guy here is](https://youtu.be/b4mxGZlaQHY?t=01h04m32s)

[doing something very similar to what we](https://youtu.be/b4mxGZlaQHY?t=01h04m35s)

[did on our](https://youtu.be/b4mxGZlaQHY?t=01h04m37s)

[version okay](https://youtu.be/b4mxGZlaQHY?t=01h04m38s)

[question is where](https://youtu.be/b4mxGZlaQHY?t=01h04m45s)

[let me go back to that plane 3d real](https://youtu.be/b4mxGZlaQHY?t=01h04m47s)

[quick](https://youtu.be/b4mxGZlaQHY?t=01h04m49s)

[because it was doing something very](https://youtu.be/b4mxGZlaQHY?t=01h04m51s)

[interesting on the rotation](https://youtu.be/b4mxGZlaQHY?t=01h04m53s)

[update 3d because i think this is](https://youtu.be/b4mxGZlaQHY?t=01h04m57s)

[probably where we](https://youtu.be/b4mxGZlaQHY?t=01h04m59s)

[lost it](https://youtu.be/b4mxGZlaQHY?t=01h05m01s)

[feel the view in radians](https://youtu.be/b4mxGZlaQHY?t=01h05m04s)

[and then it rotated it by setting the](https://youtu.be/b4mxGZlaQHY?t=01h05m14s)

[camera property on the perspective](https://youtu.be/b4mxGZlaQHY?t=01h05m17s)

[camera](https://youtu.be/b4mxGZlaQHY?t=01h05m19s)

[oh](https://youtu.be/b4mxGZlaQHY?t=01h05m23s)

[i wonder](https://youtu.be/b4mxGZlaQHY?t=01h05m25s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h05m26s)

[i wonder](https://youtu.be/b4mxGZlaQHY?t=01h05m27s)

[if something outside of this guy is](https://youtu.be/b4mxGZlaQHY?t=01h05m30s)

[setting it hang on let's go](https://youtu.be/b4mxGZlaQHY?t=01h05m32s)

[back to snoop](https://youtu.be/b4mxGZlaQHY?t=01h05m34s)

[back to snoop's code](https://youtu.be/b4mxGZlaQHY?t=01h05m37s)

[let's go hunting this guy](https://youtu.be/b4mxGZlaQHY?t=01h05m39s)

[the only perspective camera is here](https://youtu.be/b4mxGZlaQHY?t=01h05m43s)

[huh](https://youtu.be/b4mxGZlaQHY?t=01h05m50s)

[it has a this can't oh](https://youtu.be/b4mxGZlaQHY?t=01h05m54s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h05m56s)

[oh](https://youtu.be/b4mxGZlaQHY?t=01h05m58s)

[so i bet you](https://youtu.be/b4mxGZlaQHY?t=01h06m00s)

[i bet you the magical incantation is](https://youtu.be/b4mxGZlaQHY?t=01h06m02s)

[that camera property](https://youtu.be/b4mxGZlaQHY?t=01h06m05s)

[so](https://youtu.be/b4mxGZlaQHY?t=01h06m07s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h06m07s)

[i](https://youtu.be/b4mxGZlaQHY?t=01h06m15s)

[okay i bet you that behavior](https://youtu.be/b4mxGZlaQHY?t=01h06m16s)

[that i so callously got rid of](https://youtu.be/b4mxGZlaQHY?t=01h06m20s)

[changes the camera property](https://youtu.be/b4mxGZlaQHY?t=01h06m24s)

[on this thing somewhere](https://youtu.be/b4mxGZlaQHY?t=01h06m27s)

[else let's go while looking](https://youtu.be/b4mxGZlaQHY?t=01h06m30s)

[oh look trackball behavior touching a](https://youtu.be/b4mxGZlaQHY?t=01h06m34s)

[projection camera](https://youtu.be/b4mxGZlaQHY?t=01h06m37s)

[what a shock](https://youtu.be/b4mxGZlaQHY?t=01h06m39s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=01h06m42s)

[this is what is grabbing and moving it](https://youtu.be/b4mxGZlaQHY?t=01h06m50s)

[around](https://youtu.be/b4mxGZlaQHY?t=01h06m53s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=01h06m55s)

[where do you do your assignment back](https://youtu.be/b4mxGZlaQHY?t=01h06m58s)

[one of you guys](https://youtu.be/b4mxGZlaQHY?t=01h07m02s)

[somebody around here is doing a viewport](https://youtu.be/b4mxGZlaQHY?t=01h07m05s)

[assignment](https://youtu.be/b4mxGZlaQHY?t=01h07m07s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=01h07m10s)

[get direction get position](https://youtu.be/b4mxGZlaQHY?t=01h07m14s)

[update camera i would like to see that](https://youtu.be/b4mxGZlaQHY?t=01h07m21s)

[method please](https://youtu.be/b4mxGZlaQHY?t=01h07m24s)

[okay so you grab the camera pull the](https://youtu.be/b4mxGZlaQHY?t=01h07m26s)

[matrix](https://youtu.be/b4mxGZlaQHY?t=01h07m28s)

[matrix.rotate](https://youtu.be/b4mxGZlaQHY?t=01h07m30s)

[and you do](https://youtu.be/b4mxGZlaQHY?t=01h07m34s)

[that maneuver okay so](https://youtu.be/b4mxGZlaQHY?t=01h07m35s)

[this be what i want to do](https://youtu.be/b4mxGZlaQHY?t=01h07m38s)

[this this be what i want to do i just](https://youtu.be/b4mxGZlaQHY?t=01h07m41s)

[want to do it programmatically and not](https://youtu.be/b4mxGZlaQHY?t=01h07m44s)

[with](https://youtu.be/b4mxGZlaQHY?t=01h07m46s)

[the mouse](https://youtu.be/b4mxGZlaQHY?t=01h07m47s)

[okay so on text change we're gonna](https://youtu.be/b4mxGZlaQHY?t=01h07m50s)

[kind of throw all of this away all that](https://youtu.be/b4mxGZlaQHY?t=01h07m53s)

[goes away](https://youtu.be/b4mxGZlaQHY?t=01h07m56s)

[okay so we want to do this](https://youtu.be/b4mxGZlaQHY?t=01h07m57s)

[and we want to grab](https://youtu.be/b4mxGZlaQHY?t=01h08m00s)

[uh we're just going to cash this guy](https://youtu.be/b4mxGZlaQHY?t=01h08m04s)

[private paste](https://youtu.be/b4mxGZlaQHY?t=01h08m09s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h08m12s)

[you](https://youtu.be/b4mxGZlaQHY?t=01h08m13s)

[okay i'll do that](https://youtu.be/b4mxGZlaQHY?t=01h08m16s)

[and then down here](https://youtu.be/b4mxGZlaQHY?t=01h08m18s)

[and i'm only doing this because i think](https://youtu.be/b4mxGZlaQHY?t=01h08m20s)

[this](https://youtu.be/b4mxGZlaQHY?t=01h08m24s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h08m24s)

[because this class is constructor takes](https://youtu.be/b4mxGZlaQHY?t=01h08m26s)

[into visual i suspect it needs the other](https://youtu.be/b4mxGZlaQHY?t=01h08m28s)

[element already rendered](https://youtu.be/b4mxGZlaQHY?t=01h08m30s)

[before it'll work](https://youtu.be/b4mxGZlaQHY?t=01h08m33s)

[i don't know that for a fact](https://youtu.be/b4mxGZlaQHY?t=01h08m34s)

[but i think excellent so](https://youtu.be/b4mxGZlaQHY?t=01h08m36s)

[this ends up becoming view camera](https://youtu.be/b4mxGZlaQHY?t=01h08m39s)

[and](https://youtu.be/b4mxGZlaQHY?t=01h08m43s)

[that goes like this](https://youtu.be/b4mxGZlaQHY?t=01h08m46s)

[we do no coalescing and](https://youtu.be/b4mxGZlaQHY?t=01h08m47s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=01h08m51s)

[we need a look at point a distance a](https://youtu.be/b4mxGZlaQHY?t=01h08m55s)

[zoom](https://youtu.be/b4mxGZlaQHY?t=01h08m58s)

[and a look direction](https://youtu.be/b4mxGZlaQHY?t=01h09m00s)

[and really what i'd like to do is just](https://youtu.be/b4mxGZlaQHY?t=01h09m08s)

[get this to the point where i can](https://youtu.be/b4mxGZlaQHY?t=01h09m11s)

[set those something simple like](https://youtu.be/b4mxGZlaQHY?t=01h09m13s)

[um the rotation on the other one](https://youtu.be/b4mxGZlaQHY?t=01h09m16s)

[let's go back here](https://youtu.be/b4mxGZlaQHY?t=01h09m19s)

[this looks like what i could do](https://youtu.be/b4mxGZlaQHY?t=01h09m25s)

[because i'm thinking what i need is a](https://youtu.be/b4mxGZlaQHY?t=01h09m29s)

[combination of this plain 3d control](https://youtu.be/b4mxGZlaQHY?t=01h09m30s)

[and the other one and the](https://youtu.be/b4mxGZlaQHY?t=01h09m35s)

[snoop one field of view](https://youtu.be/b4mxGZlaQHY?t=01h09m37s)

[what what is a signing field of view on](https://youtu.be/b4mxGZlaQHY?t=01h09m40s)

[this](https://youtu.be/b4mxGZlaQHY?t=01h09m42s)

[final reference](https://youtu.be/b4mxGZlaQHY?t=01h09m43s)

[let's fill the view always](https://youtu.be/b4mxGZlaQHY?t=01h09m49s)

[zero](https://youtu.be/b4mxGZlaQHY?t=01h09m51s)

[no what's the default](https://youtu.be/b4mxGZlaQHY?t=01h09m54s)

[property metadata](https://youtu.be/b4mxGZlaQHY?t=01h09m58s)

[01:10:07,520 --> 01:10:10,920](https://youtu.be/b4mxGZlaQHY?t=01h10m01s)

no 179

[oh this is this is a callback](https://youtu.be/b4mxGZlaQHY?t=01h10m16s)

[yeah the default value is 45](https://youtu.be/b4mxGZlaQHY?t=01h10m22s)

[so](https://youtu.be/b4mxGZlaQHY?t=01h10m25s)

[45 i assume 45 degrees because it's then](https://youtu.be/b4mxGZlaQHY?t=01h10m26s)

[being converted to radians](https://youtu.be/b4mxGZlaQHY?t=01h10m29s)

[look along the z right distance based on](https://youtu.be/b4mxGZlaQHY?t=01h10m36s)

[the field of view](https://youtu.be/b4mxGZlaQHY?t=01h10m38s)

[name is the projected size of the 2d](https://youtu.be/b4mxGZlaQHY?t=01h10m41s)

[content that it's looking at](https://youtu.be/b4mxGZlaQHY?t=01h10m43s)

[for derived camera okay so](https://youtu.be/b4mxGZlaQHY?t=01h10m46s)

[i see all of this](https://youtu.be/b4mxGZlaQHY?t=01h11m04s)

[stuff happening but i'm left wondering](https://youtu.be/b4mxGZlaQHY?t=01h11m06s)

[how i'm i'm now confused as to how this](https://youtu.be/b4mxGZlaQHY?t=01h11m14s)

[control is working](https://youtu.be/b4mxGZlaQHY?t=01h11m17s)

[update rotation](https://youtu.be/b4mxGZlaQHY?t=01h11m20s)

[ah](https://youtu.be/b4mxGZlaQHY?t=01h11m23s)

[got it this guy's being applied](https://youtu.be/b4mxGZlaQHY?t=01h11m34s)

[rotation transformation](https://youtu.be/b4mxGZlaQHY?t=01h11m38s)

[okay see i think this thing has a lot](https://youtu.be/b4mxGZlaQHY?t=01h11m43s)

[more going on to it than we actually](https://youtu.be/b4mxGZlaQHY?t=01h11m45s)

[need](https://youtu.be/b4mxGZlaQHY?t=01h11m47s)

[just why i'm more inclined to take the](https://youtu.be/b4mxGZlaQHY?t=01h11m49s)

[snoop one and dumb this guy down](https://youtu.be/b4mxGZlaQHY?t=01h11m51s)

[um okay so](https://youtu.be/b4mxGZlaQHY?t=01h11m57s)

[this rotation transform](https://youtu.be/b4mxGZlaQHY?t=01h12m03s)

[gets used where](https://youtu.be/b4mxGZlaQHY?t=01h12m06s)

[really just here which gets applied](https://youtu.be/b4mxGZlaQHY?t=01h12m15s)

[the back model](https://youtu.be/b4mxGZlaQHY?t=01h12m19s)

[model 3d group](https://youtu.be/b4mxGZlaQHY?t=01h12m23s)

[and that has the lights so that we can](https://youtu.be/b4mxGZlaQHY?t=01h12m25s)

[see it](https://youtu.be/b4mxGZlaQHY?t=01h12m28s)

[one of the lights is at negative one z](https://youtu.be/b4mxGZlaQHY?t=01h12m32s)

[and then slightly shifted](https://youtu.be/b4mxGZlaQHY?t=01h12m41s)

[and then one z okay](https://youtu.be/b4mxGZlaQHY?t=01h12m44s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h12m50s)

[go back to our example one](https://youtu.be/b4mxGZlaQHY?t=01h12m56s)

[just trying to make sure i understand](https://youtu.be/b4mxGZlaQHY?t=01h13m00s)

[this](https://youtu.be/b4mxGZlaQHY?t=01h13m01s)

[so directional light one directional](https://youtu.be/b4mxGZlaQHY?t=01h13m02s)

[light two](https://youtu.be/b4mxGZlaQHY?t=01h13m04s)

[so this one there's no intent to subtly](https://youtu.be/b4mxGZlaQHY?t=01h13m06s)

[offset it](https://youtu.be/b4mxGZlaQHY?t=01h13m09s)

[there's just it one a negative one which](https://youtu.be/b4mxGZlaQHY?t=01h13m11s)

[kind of makes sense](https://youtu.be/b4mxGZlaQHY?t=01h13m13s)

[this is the group that would get the](https://youtu.be/b4mxGZlaQHY?t=01h13m15s)

[transform applied to it](https://youtu.be/b4mxGZlaQHY?t=01h13m17s)

[it's just got the scale transform it's](https://youtu.be/b4mxGZlaQHY?t=01h13m21s)

[not adding extra stuff to it which makes](https://youtu.be/b4mxGZlaQHY?t=01h13m23s)

[me believe that the rotational transform](https://youtu.be/b4mxGZlaQHY?t=01h13m25s)

[is not necessary](https://youtu.be/b4mxGZlaQHY?t=01h13m27s)

[but in our case the rotational transform](https://youtu.be/b4mxGZlaQHY?t=01h13m30s)

[is needed](https://youtu.be/b4mxGZlaQHY?t=01h13m32s)

[because we would like to](https://youtu.be/b4mxGZlaQHY?t=01h13m34s)

[mutate that okay so i need me one of](https://youtu.be/b4mxGZlaQHY?t=01h13m37s)

[these guys](https://youtu.be/b4mxGZlaQHY?t=01h13m40s)

[and i would like to put it](https://youtu.be/b4mxGZlaQHY?t=01h13m42s)

[we will figure this out](https://youtu.be/b4mxGZlaQHY?t=01h13m46s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=01h13m48s)

[do that](https://youtu.be/b4mxGZlaQHY?t=01h13m52s)

[for the moment](https://youtu.be/b4mxGZlaQHY?t=01h13m53s)

[and](https://youtu.be/b4mxGZlaQHY?t=01h13m56s)

[this guy i believe just needs to be a](https://youtu.be/b4mxGZlaQHY?t=01h13m59s)

[transformed group](https://youtu.be/b4mxGZlaQHY?t=01h14m01s)

[uh if i'm not mistaken](https://youtu.be/b4mxGZlaQHY?t=01h14m05s)

[patient transform](https://youtu.be/b4mxGZlaQHY?t=01h14m09s)

[yeah transform 3d group](https://youtu.be/b4mxGZlaQHY?t=01h14m11s)

[that's going to contain the scale and](https://youtu.be/b4mxGZlaQHY?t=01h14m15s)

[the rotation](https://youtu.be/b4mxGZlaQHY?t=01h14m16s)

[we will come back over here](https://youtu.be/b4mxGZlaQHY?t=01h14m18s)

[this is a transform](https://youtu.be/b4mxGZlaQHY?t=01h14m21s)

[group](https://youtu.be/b4mxGZlaQHY?t=01h14m24s)

[is the model](https://youtu.be/b4mxGZlaQHY?t=01h14m25s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h14m25s)

[so](https://youtu.be/b4mxGZlaQHY?t=01h14m27s)

[z scale transform goes here](https://youtu.be/b4mxGZlaQHY?t=01h14m28s)

[uh let's see and then rotation transform](https://youtu.be/b4mxGZlaQHY?t=01h14m32s)

[comes from](https://youtu.be/b4mxGZlaQHY?t=01h14m38s)

[oh it's just straight up instantiated](https://youtu.be/b4mxGZlaQHY?t=01h14m44s)

[you don't](https://youtu.be/b4mxGZlaQHY?t=01h14m47s)

[we might need it so we're gonna](https://youtu.be/b4mxGZlaQHY?t=01h14m49s)

[grab that too](https://youtu.be/b4mxGZlaQHY?t=01h14m52s)

[uh let's see rotation transform gets new](https://youtu.be/b4mxGZlaQHY?t=01h14m58s)

[uh and i think what we can do is we can](https://youtu.be/b4mxGZlaQHY?t=01h15m02s)

[actually cheat a little bit](https://youtu.be/b4mxGZlaQHY?t=01h15m04s)

[because this thing is reassigning the](https://youtu.be/b4mxGZlaQHY?t=01h15m06s)

[rotation here and i don't think we ever](https://youtu.be/b4mxGZlaQHY?t=01h15m09s)

[we get away with this we might not be oh](https://youtu.be/b4mxGZlaQHY?t=01h15m17s)

[we probably can't get away with this](https://youtu.be/b4mxGZlaQHY?t=01h15m19s)

[because we're in static context there](https://youtu.be/b4mxGZlaQHY?t=01h15m20s)

[okay fine um](https://youtu.be/b4mxGZlaQHY?t=01h15m23s)

[rotation gets](https://youtu.be/b4mxGZlaQHY?t=01h15m28s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h15m34s)

[and that's fine that's fine](https://youtu.be/b4mxGZlaQHY?t=01h15m35s)

[that's fine you now get](https://youtu.be/b4mxGZlaQHY?t=01h15m38s)

[that group](https://youtu.be/b4mxGZlaQHY?t=01h15m41s)

[okay let's just restart it](https://youtu.be/b4mxGZlaQHY?t=01h15m42s)

[nothing should have changed so far](https://youtu.be/b4mxGZlaQHY?t=01h15m44s)

[what's your problem what did i mess up](https://youtu.be/b4mxGZlaQHY?t=01h15m48s)

[oh uh](https://youtu.be/b4mxGZlaQHY?t=01h15m52s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h15m52s)

[oh please](https://youtu.be/b4mxGZlaQHY?t=01h15m56s)

[so nothing should have changed it should](https://youtu.be/b4mxGZlaQHY?t=01h15m59s)

[still work](https://youtu.be/b4mxGZlaQHY?t=01h16m00s)

[should be in a working state so you come](https://youtu.be/b4mxGZlaQHY?t=01h16m02s)

[here okay here's to work as we did](https://youtu.be/b4mxGZlaQHY?t=01h16m04s)

[before great](https://youtu.be/b4mxGZlaQHY?t=01h16m07s)

[okay so we've got that we've got that](https://youtu.be/b4mxGZlaQHY?t=01h16m09s)

[okay so let's take](https://youtu.be/b4mxGZlaQHY?t=01h16m15s)

[this guy and take a look at its rotation](https://youtu.be/b4mxGZlaQHY?t=01h16m22s)

[bits](https://youtu.be/b4mxGZlaQHY?t=01h16m26s)

[because when we wrote because we are](https://youtu.be/b4mxGZlaQHY?t=01h16m27s)

[only animating rotation y](https://youtu.be/b4mxGZlaQHY?t=01h16m29s)

[which means the rest of these should all](https://youtu.be/b4mxGZlaQHY?t=01h16m34s)

[get](https://youtu.be/b4mxGZlaQHY?t=01h16m36s)

[uh we're gonna just copy this method](https://youtu.be/b4mxGZlaQHY?t=01h16m41s)

[i think we're gonna want something like](https://youtu.be/b4mxGZlaQHY?t=01h16m44s)

[this](https://youtu.be/b4mxGZlaQHY?t=01h16m46s)

[in here](https://youtu.be/b4mxGZlaQHY?t=01h16m47s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h16m51s)

[so](https://youtu.be/b4mxGZlaQHY?t=01h16m53s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h17m04s)

[these things have three axes](https://youtu.be/b4mxGZlaQHY?t=01h17m05s)

[okay so i think that's](https://youtu.be/b4mxGZlaQHY?t=01h17m17s)

[because we're going to end up rebuilding](https://youtu.be/b4mxGZlaQHY?t=01h17m21s)

[part of that thing](https://youtu.be/b4mxGZlaQHY?t=01h17m23s)

[what do you end up getting used](https://youtu.be/b4mxGZlaQHY?t=01h17m25s)

[for oh is that literally it](https://youtu.be/b4mxGZlaQHY?t=01h17m28s)

[okay and then rotation](https://youtu.be/b4mxGZlaQHY?t=01h17m32s)

[x and z are gonna have their default](https://youtu.be/b4mxGZlaQHY?t=01h17m35s)

[values](https://youtu.be/b4mxGZlaQHY?t=01h17m37s)

[so](https://youtu.be/b4mxGZlaQHY?t=01h17m38s)

[zero](https://youtu.be/b4mxGZlaQHY?t=01h17m39s)

[and](https://youtu.be/b4mxGZlaQHY?t=01h17m42s)

[let's fill the view](https://youtu.be/b4mxGZlaQHY?t=01h17m44s)

[zero](https://youtu.be/b4mxGZlaQHY?t=01h17m46s)

[those guys we can hard code to zero for](https://youtu.be/b4mxGZlaQHY?t=01h17m48s)

[the moment](https://youtu.be/b4mxGZlaQHY?t=01h17m50s)

[so rotation x is going to be](https://youtu.be/b4mxGZlaQHY?t=01h17m52s)

[zero rotation z is going to be zero](https://youtu.be/b4mxGZlaQHY?t=01h17m55s)

[okay uh](https://youtu.be/b4mxGZlaQHY?t=01h17m59s)

[double](https://youtu.be/b4mxGZlaQHY?t=01h18m00s)

[rotation](https://youtu.be/b4mxGZlaQHY?t=01h18m02s)

[y](https://youtu.be/b4mxGZlaQHY?t=01h18m04s)

[we're gonna just do that](https://youtu.be/b4mxGZlaQHY?t=01h18m05s)

[and then that goes in and gets applied](https://youtu.be/b4mxGZlaQHY?t=01h18m08s)

[and everyone's happy](https://youtu.be/b4mxGZlaQHY?t=01h18m11s)

[okay so then we come back over to our](https://youtu.be/b4mxGZlaQHY?t=01h18m12s)

[code behind](https://youtu.be/b4mxGZlaQHY?t=01h18m15s)

[and what we are going to do is we are](https://youtu.be/b4mxGZlaQHY?t=01h18m16s)

[going to go with](https://youtu.be/b4mxGZlaQHY?t=01h18m19s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h18m21s)

[if](https://youtu.be/b4mxGZlaQHY?t=01h18m22s)

[view](https://youtu.be/b4mxGZlaQHY?t=01h18m23s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h18m25s)

[view so we'll do a not null check](https://youtu.be/b4mxGZlaQHY?t=01h18m26s)

[view](https://youtu.be/b4mxGZlaQHY?t=01h18m29s)

[see](https://youtu.be/b4mxGZlaQHY?t=01h18m34s)

[get value](https://youtu.be/b4mxGZlaQHY?t=01h18m35s)

[we'll use m31 for this with a default of](https://youtu.be/b4mxGZlaQHY?t=01h18m38s)

[whatever the rotation y defaults to](https://youtu.be/b4mxGZlaQHY?t=01h18m43s)

[default to zero](https://youtu.be/b4mxGZlaQHY?t=01h18m47s)

[uh let's see](https://youtu.be/b4mxGZlaQHY?t=01h18m50s)

[rotation](https://youtu.be/b4mxGZlaQHY?t=01h18m56s)

[okay and then this should](https://youtu.be/b4mxGZlaQHY?t=01h18m57s)

[be as simple as view dot](https://youtu.be/b4mxGZlaQHY?t=01h19m00s)

[notation](https://youtu.be/b4mxGZlaQHY?t=01h19m04s)

[that you uh](https://youtu.be/b4mxGZlaQHY?t=01h19m06s)

[cannot make that public](https://youtu.be/b4mxGZlaQHY?t=01h19m09s)

[nope](https://youtu.be/b4mxGZlaQHY?t=01h19m11s)

[update rotation](https://youtu.be/b4mxGZlaQHY?t=01h19m15s)

[rotation](https://youtu.be/b4mxGZlaQHY?t=01h19m22s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h19m24s)

[as we type we should be able to just](https://youtu.be/b4mxGZlaQHY?t=01h19m25s)

[swing the thing around](https://youtu.be/b4mxGZlaQHY?t=01h19m27s)

[that's the animation](https://youtu.be/b4mxGZlaQHY?t=01h19m30s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=01h19m31s)

[give me a give me a box give me a big](https://youtu.be/b4mxGZlaQHY?t=01h19m32s)

[box okay so if i come over here and type](https://youtu.be/b4mxGZlaQHY?t=01h19m34s)

[in](https://youtu.be/b4mxGZlaQHY?t=01h19m38s)

[n](https://youtu.be/b4mxGZlaQHY?t=01h19m39s)

[starts to swing](https://youtu.be/b4mxGZlaQHY?t=01h19m40s)

[01:19:45,040 --> 01:19:49,440](https://youtu.be/b4mxGZlaQHY?t=01h19m42s)

there we see why we need scale

[uh let's see](https://youtu.be/b4mxGZlaQHY?t=01h19m47s)

[go 45](https://youtu.be/b4mxGZlaQHY?t=01h19m49s)

[i think it's huge](https://youtu.be/b4mxGZlaQHY?t=01h19m53s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h19m56s)

[01:19:59,600 --> 01:20:04,040](https://youtu.be/b4mxGZlaQHY?t=01h19m57s)

uh

[negative 10.](https://youtu.be/b4mxGZlaQHY?t=01h20m00s)

[negative 45](https://youtu.be/b4mxGZlaQHY?t=01h20m05s)

[okay well that that okay so this](https://youtu.be/b4mxGZlaQHY?t=01h20m09s)

[this somewhat makes sense](https://youtu.be/b4mxGZlaQHY?t=01h20m11s)

[because our](https://youtu.be/b4mxGZlaQHY?t=01h20m14s)

[camera origin is not adjusting](https://youtu.be/b4mxGZlaQHY?t=01h20m16s)

[but we can now make this thing spin](https://youtu.be/b4mxGZlaQHY?t=01h20m18s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h20m26s)

[so](https://youtu.be/b4mxGZlaQHY?t=01h20m28s)

[i like this i like being able to test it](https://youtu.be/b4mxGZlaQHY?t=01h20m33s)

[right here](https://youtu.be/b4mxGZlaQHY?t=01h20m35s)

[to make this thing go okay so we're](https://youtu.be/b4mxGZlaQHY?t=01h20m38s)

[gonna we're gonna keep going with this](https://youtu.be/b4mxGZlaQHY?t=01h20m40s)

[so the](https://youtu.be/b4mxGZlaQHY?t=01h20m45s)

[plane 3d had a scale that was being](https://youtu.be/b4mxGZlaQHY?t=01h20m46s)

[applied to it](https://youtu.be/b4mxGZlaQHY?t=01h20m50s)

[the factor](https://youtu.be/b4mxGZlaQHY?t=01h20m57s)

[this is even being used](https://youtu.be/b4mxGZlaQHY?t=01h21m01s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=01h21m07s)

[scale so how is this working](https://youtu.be/b4mxGZlaQHY?t=01h21m12s)

[so update rotation was called](https://youtu.be/b4mxGZlaQHY?t=01h21m25s)

[let's go back up here so when we when we](https://youtu.be/b4mxGZlaQHY?t=01h21m35s)

[were modifying the rotation y](https://youtu.be/b4mxGZlaQHY?t=01h21m36s)

[it calls update rotation](https://youtu.be/b4mxGZlaQHY?t=01h21m40s)

[but update 3d must be getting invoked](https://youtu.be/b4mxGZlaQHY?t=01h21m45s)

[from somewhere](https://youtu.be/b4mxGZlaQHY?t=01h21m47s)

[ah](https://youtu.be/b4mxGZlaQHY?t=01h21m50s)

[on a range](https://youtu.be/b4mxGZlaQHY?t=01h21m51s)

[this is how it's determining its target](https://youtu.be/b4mxGZlaQHY?t=01h21m54s)

[size](https://youtu.be/b4mxGZlaQHY?t=01h21m56s)

[and this is probably part of my problem](https://youtu.be/b4mxGZlaQHY?t=01h22m01s)

[so it's trying to figure out its target](https://youtu.be/b4mxGZlaQHY?t=01h22m08s)

[bounds and i feel like i just want to](https://youtu.be/b4mxGZlaQHY?t=01h22m10s)

[tell it this rather than having to try](https://youtu.be/b4mxGZlaQHY?t=01h22m12s)

[to figure it out](https://youtu.be/b4mxGZlaQHY?t=01h22m14s)

[okay so it's using the logical bounds to](https://youtu.be/b4mxGZlaQHY?t=01h22m22s)

[get the width and the height of its](https://youtu.be/b4mxGZlaQHY?t=01h22m24s)

[target size so it needs to know how big](https://youtu.be/b4mxGZlaQHY?t=01h22m26s)

[the the thingy is that it's wrapping](https://youtu.be/b4mxGZlaQHY?t=01h22m28s)

[and it uses those](https://youtu.be/b4mxGZlaQHY?t=01h22m33s)

[to figure out a z value](https://youtu.be/b4mxGZlaQHY?t=01h22m36s)

[field of view so we were never changing](https://youtu.be/b4mxGZlaQHY?t=01h22m38s)

[this](https://youtu.be/b4mxGZlaQHY?t=01h22m40s)

[the field of view was always 45 so we](https://youtu.be/b4mxGZlaQHY?t=01h22m44s)

[can](https://youtu.be/b4mxGZlaQHY?t=01h22m47s)

[we can do something like this](https://youtu.be/b4mxGZlaQHY?t=01h22m48s)

[so let's come back over here](https://youtu.be/b4mxGZlaQHY?t=01h22m56s)

[okay so and then we're gonna do](https://youtu.be/b4mxGZlaQHY?t=01h23m04s)

[something like uh i don't know](https://youtu.be/b4mxGZlaQHY?t=01h23m06s)

[update](https://youtu.be/b4mxGZlaQHY?t=01h23m08s)

[3d](https://youtu.be/b4mxGZlaQHY?t=01h23m10s)

[update](https://youtu.be/b4mxGZlaQHY?t=01h23m15s)

[3d](https://youtu.be/b4mxGZlaQHY?t=01h23m18s)

[boom okay so](https://youtu.be/b4mxGZlaQHY?t=01h23m21s)

[this guy here is going to be](https://youtu.be/b4mxGZlaQHY?t=01h23m23s)

[get to send the bounds for sizing and](https://youtu.be/b4mxGZlaQHY?t=01h23m25s)

[center desire size and](https://youtu.be/b4mxGZlaQHY?t=01h23m28s)

[lay out white space whereas get](https://youtu.be/b4mxGZlaQHY?t=01h23m30s)

[descended bounds is tighter](https://youtu.be/b4mxGZlaQHY?t=01h23m31s)

[i don't think i want either of these](https://youtu.be/b4mxGZlaQHY?t=01h23m36s)

[things](https://youtu.be/b4mxGZlaQHY?t=01h23m38s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h23m44s)

[what did we do with the visual once it](https://youtu.be/b4mxGZlaQHY?t=01h23m46s)

[came in did we just throw it away](https://youtu.be/b4mxGZlaQHY?t=01h23m48s)

[oh this is part of the reason for the](https://youtu.be/b4mxGZlaQHY?t=01h23m52s)

[sizing](https://youtu.be/b4mxGZlaQHY?t=01h23m54s)

[it's hard-coded](https://youtu.be/b4mxGZlaQHY?t=01h23m56s)

[well let's make that go away](https://youtu.be/b4mxGZlaQHY?t=01h23m58s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h24m01s)

[convert to visual](https://youtu.be/b4mxGZlaQHY?t=01h24m03s)

[visual comes in here](https://youtu.be/b4mxGZlaQHY?t=01h24m05s)

[does some stuff](https://youtu.be/b4mxGZlaQHY?t=01h24m08s)

[bounds gets set](https://youtu.be/b4mxGZlaQHY?t=01h24m10s)

[bounce bounce](https://youtu.be/b4mxGZlaQHY?t=01h24m20s)

[turn you off for the moment](https://youtu.be/b4mxGZlaQHY?t=01h24m24s)

[transform matrix](https://youtu.be/b4mxGZlaQHY?t=01h24m30s)

[does a bunch of stuff to it](https://youtu.be/b4mxGZlaQHY?t=01h24m34s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h24m37s)

[kind of thinking we just well](https://youtu.be/b4mxGZlaQHY?t=01h24m41s)

[real quick we're going to comment this](https://youtu.be/b4mxGZlaQHY?t=01h24m46s)

[out i want to make sure that my changing](https://youtu.be/b4mxGZlaQHY?t=01h24m47s)

[of the](https://youtu.be/b4mxGZlaQHY?t=01h24m49s)

[hard-coded width and height doesn't make](https://youtu.be/b4mxGZlaQHY?t=01h24m50s)

[a big difference](https://youtu.be/b4mxGZlaQHY?t=01h24m52s)

[that was almost assuredly the reason for](https://youtu.be/b4mxGZlaQHY?t=01h24m54s)

[it being so massive](https://youtu.be/b4mxGZlaQHY?t=01h24m56s)

[okay but](https://youtu.be/b4mxGZlaQHY?t=01h25m01s)

[not having any size is also clearly](https://youtu.be/b4mxGZlaQHY?t=01h25m02s)

[problematic okay so](https://youtu.be/b4mxGZlaQHY?t=01h25m04s)

[we're going to come down here](https://youtu.be/b4mxGZlaQHY?t=01h25m06s)

[with](https://youtu.be/b4mxGZlaQHY?t=01h25m09s)

[its](https://youtu.be/b4mxGZlaQHY?t=01h25m10s)

[visual dot](https://youtu.be/b4mxGZlaQHY?t=01h25m12s)

[about if](https://youtu.be/b4mxGZlaQHY?t=01h25m21s)

[visual is](https://youtu.be/b4mxGZlaQHY?t=01h25m24s)

[framework element](https://youtu.be/b4mxGZlaQHY?t=01h25m26s)

[it will work for now we'll probably need](https://youtu.be/b4mxGZlaQHY?t=01h25m44s)

[something slightly more advanced when we](https://youtu.be/b4mxGZlaQHY?t=01h25m46s)

[get there but](https://youtu.be/b4mxGZlaQHY?t=01h25m47s)

[for now it should have](https://youtu.be/b4mxGZlaQHY?t=01h25m50s)

[there from size](https://youtu.be/b4mxGZlaQHY?t=01h25m52s)

[now when i do 45 it should still be big](https://youtu.be/b4mxGZlaQHY?t=01h25m54s)

[01:26:00,800 --> 01:26:04,480](https://youtu.be/b4mxGZlaQHY?t=01h25m58s)

but it's panning but it's not going

[quite what we wanted okay](https://youtu.be/b4mxGZlaQHY?t=01h26m02s)

[okay that's that's getting better](https://youtu.be/b4mxGZlaQHY?t=01h26m04s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h26m08s)

[i think what we're going to do is we're](https://youtu.be/b4mxGZlaQHY?t=01h26m13s)

[going to get rid of this](https://youtu.be/b4mxGZlaQHY?t=01h26m14s)

[we're going to just grab our size](https://youtu.be/b4mxGZlaQHY?t=01h26m16s)

[width and height](https://youtu.be/b4mxGZlaQHY?t=01h26m19s)

[okay uh we will do var](https://youtu.be/b4mxGZlaQHY?t=01h26m22s)

[field of view equals 45](https://youtu.be/b4mxGZlaQHY?t=01h26m25s)

[the double](https://youtu.be/b4mxGZlaQHY?t=01h26m30s)

[z factor i think](https://youtu.be/b4mxGZlaQHY?t=01h26m32s)

[was](https://youtu.be/b4mxGZlaQHY?t=01h26m34s)

[never changing](https://youtu.be/b4mxGZlaQHY?t=01h26m36s)

[i don't know why it was defaulting to](https://youtu.be/b4mxGZlaQHY?t=01h26m40s)

[two but](https://youtu.be/b4mxGZlaQHY?t=01h26m42s)

[we'll go with it](https://youtu.be/b4mxGZlaQHY?t=01h26m45s)

[okay viewport](https://youtu.be/b4mxGZlaQHY?t=01h26m47s)

[3d is](https://youtu.be/b4mxGZlaQHY?t=01h26m48s)

[grabbing the camera](https://youtu.be/b4mxGZlaQHY?t=01h26m51s)

[i think](https://youtu.be/b4mxGZlaQHY?t=01h26m55s)

[we are the viewport](https://youtu.be/b4mxGZlaQHY?t=01h26m57s)

[just do that](https://youtu.be/b4mxGZlaQHY?t=01h26m59s)

[scale transform has a different name](https://youtu.be/b4mxGZlaQHY?t=01h27m01s)

[so that works there let's see if this](https://youtu.be/b4mxGZlaQHY?t=01h27m11s)

[works](https://youtu.be/b4mxGZlaQHY?t=01h27m13s)

[so now hopefully as we type we can kind](https://youtu.be/b4mxGZlaQHY?t=01h27m14s)

[of](https://youtu.be/b4mxGZlaQHY?t=01h27m16s)

[manually simulate this so](https://youtu.be/b4mxGZlaQHY?t=01h27m16s)

[give me a box](https://youtu.be/b4mxGZlaQHY?t=01h27m19s)

[we're all happy](https://youtu.be/b4mxGZlaQHY?t=01h27m21s)

[i type in 20](https://youtu.be/b4mxGZlaQHY?t=01h27m22s)

[and it disappears](https://youtu.be/b4mxGZlaQHY?t=01h27m25s)

[one zero](https://youtu.be/b4mxGZlaQHY?t=01h27m30s)

[something went bye-bye](https://youtu.be/b4mxGZlaQHY?t=01h27m33s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h27m36s)

[let's try this again](https://youtu.be/b4mxGZlaQHY?t=01h27m37s)

[show me a box](https://youtu.be/b4mxGZlaQHY?t=01h27m42s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h27m46s)

[we come in here width](https://youtu.be/b4mxGZlaQHY?t=01h27m48s)

[200 height 200 not shocking](https://youtu.be/b4mxGZlaQHY?t=01h27m49s)

[build a view 45](https://youtu.be/b4mxGZlaQHY?t=01h27m53s)

[build a view in radians](https://youtu.be/b4mxGZlaQHY?t=01h27m56s)

[the axis y-axis field of view](https://youtu.be/b4mxGZlaQHY?t=01h28m12s)

[width height](https://youtu.be/b4mxGZlaQHY?t=01h28m15s)

[scale](https://youtu.be/b4mxGZlaQHY?t=01h28m18s)

[this scale seems](https://youtu.be/b4mxGZlaQHY?t=01h28m25s)

[very wrong](https://youtu.be/b4mxGZlaQHY?t=01h28m27s)

[scaling it to 200](https://youtu.be/b4mxGZlaQHY?t=01h28m30s)

[see that looks better to me](https://youtu.be/b4mxGZlaQHY?t=01h28m41s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h28m50s)

[it feels like we could be setting some](https://youtu.be/b4mxGZlaQHY?t=01h29m05s)

[of these things up front](https://youtu.be/b4mxGZlaQHY?t=01h29m07s)

[but we're going to](https://youtu.be/b4mxGZlaQHY?t=01h29m08s)

[turn that off because i think that's](https://youtu.be/b4mxGZlaQHY?t=01h29m12s)

[going to be](https://youtu.be/b4mxGZlaQHY?t=01h29m14s)

[highly problematic](https://youtu.be/b4mxGZlaQHY?t=01h29m16s)

[given the values that are being passed](https://youtu.be/b4mxGZlaQHY?t=01h29m20s)

[in there](https://youtu.be/b4mxGZlaQHY?t=01h29m21s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h29m25s)

[try again](https://youtu.be/b4mxGZlaQHY?t=01h29m26s)

[definitely did a major shift n](https://youtu.be/b4mxGZlaQHY?t=01h29m35s)

[01:29:42,320 --> 01:29:44,719](https://youtu.be/b4mxGZlaQHY?t=01h29m39s)

[50.](https://youtu.be/b4mxGZlaQHY?t=01h29m46s)

[uh let's see 80](https://youtu.be/b4mxGZlaQHY?t=01h29m51s)

[90.](https://youtu.be/b4mxGZlaQHY?t=01h29m54s)

[okay so the rotation origin i think does](https://youtu.be/b4mxGZlaQHY?t=01h29m59s)

[need to be set](https://youtu.be/b4mxGZlaQHY?t=01h30m02s)

[let's do that](https://youtu.be/b4mxGZlaQHY?t=01h30m04s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h30m07s)

[but we can do this here](https://youtu.be/b4mxGZlaQHY?t=01h30m08s)

[situation transform center](https://youtu.be/b4mxGZlaQHY?t=01h30m11s)

[we're doing center x and center y](https://youtu.be/b4mxGZlaQHY?t=01h30m17s)

[but we can do these based upon the](https://youtu.be/b4mxGZlaQHY?t=01h30m24s)

[oh i guess we actually need to do it](https://youtu.be/b4mxGZlaQHY?t=01h30m28s)

[down here where we have some](https://youtu.be/b4mxGZlaQHY?t=01h30m29s)

[sizing](https://youtu.be/b4mxGZlaQHY?t=01h30m32s)

[with](https://youtu.be/b4mxGZlaQHY?t=01h30m35s)

[height](https://youtu.be/b4mxGZlaQHY?t=01h30m38s)

[let's leave those in](https://youtu.be/b4mxGZlaQHY?t=01h30m40s)

[bring this over here](https://youtu.be/b4mxGZlaQHY?t=01h30m49s)

[load me up](https://youtu.be/b4mxGZlaQHY?t=01h30m52s)

[01:30:57,760 --> 01:31:02,520](https://youtu.be/b4mxGZlaQHY?t=01h30m54s)

30. okay so we're still getting that

[that shift and i have to believe this](https://youtu.be/b4mxGZlaQHY?t=01h31m02s)

[i'm missing something obvious either the](https://youtu.be/b4mxGZlaQHY?t=01h31m09s)

[field of view is being](https://youtu.be/b4mxGZlaQHY?t=01h31m11s)

[overwritten somewhere that i don't](https://youtu.be/b4mxGZlaQHY?t=01h31m13s)

[understand because field of view seems](https://youtu.be/b4mxGZlaQHY?t=01h31m15s)

[odd that it would be 45 to default](https://youtu.be/b4mxGZlaQHY?t=01h31m17s)

[maybe i'm just not understanding](https://youtu.be/b4mxGZlaQHY?t=01h31m20s)

[something but let's just do a quick](https://youtu.be/b4mxGZlaQHY?t=01h31m21s)

[search](https://youtu.be/b4mxGZlaQHY?t=01h31m23s)

[yeah those are the only usages of field](https://youtu.be/b4mxGZlaQHY?t=01h31m28s)

[of view](https://youtu.be/b4mxGZlaQHY?t=01h31m30s)

[based on text](https://youtu.be/b4mxGZlaQHY?t=01h31m34s)

[i just make sure i wasn't filtering on](https://youtu.be/b4mxGZlaQHY?t=01h31m38s)

[any weird files or anything](https://youtu.be/b4mxGZlaQHY?t=01h31m40s)

[uh nope entire solution](https://youtu.be/b4mxGZlaQHY?t=01h31m42s)

[so it](https://youtu.be/b4mxGZlaQHY?t=01h31m50s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h32m02s)

[z factor being adjusted and i just](https://youtu.be/b4mxGZlaQHY?t=01h32m14s)

[didn't realize it](https://youtu.be/b4mxGZlaQHY?t=01h32m16s)

[i think so but let's just hunt it and](https://youtu.be/b4mxGZlaQHY?t=01h32m22s)

[make sure i'm not missing something](https://youtu.be/b4mxGZlaQHY?t=01h32m24s)

[obvious](https://youtu.be/b4mxGZlaQHY?t=01h32m25s)

[okay so those are all the ones we expect](https://youtu.be/b4mxGZlaQHY?t=01h32m28s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h32m32s)

[defactor is technically being a set](https://youtu.be/b4mxGZlaQHY?t=01h32m35s)

[the value is slightly different than two](https://youtu.be/b4mxGZlaQHY?t=01h32m39s)

[but stuff like that makes me assume that](https://youtu.be/b4mxGZlaQHY?t=01h32m43s)

[it may have just been doing that to](https://youtu.be/b4mxGZlaQHY?t=01h32m45s)

[trigger the update rotation](https://youtu.be/b4mxGZlaQHY?t=01h32m46s)

[so we can](https://youtu.be/b4mxGZlaQHY?t=01h32m52s)

[mimic that](https://youtu.be/b4mxGZlaQHY?t=01h32m53s)

[i'm actually going to go](https://youtu.be/b4mxGZlaQHY?t=01h32m55s)

[bar](https://youtu.be/b4mxGZlaQHY?t=01h32m57s)

[z factor gets](https://youtu.be/b4mxGZlaQHY?t=01h32m58s)

[that](https://youtu.be/b4mxGZlaQHY?t=01h33m01s)

[and put this back to](https://youtu.be/b4mxGZlaQHY?t=01h33m02s)

[the factor](https://youtu.be/b4mxGZlaQHY?t=01h33m04s)

[a little surprise the scale transform](https://youtu.be/b4mxGZlaQHY?t=01h33m07s)

[getting set the way it is](https://youtu.be/b4mxGZlaQHY?t=01h33m11s)

[the scale transform is here](https://youtu.be/b4mxGZlaQHY?t=01h33m17s)

[scale x and scale y](https://youtu.be/b4mxGZlaQHY?t=01h33m28s)

[are being set to the width and height](https://youtu.be/b4mxGZlaQHY?t=01h33m34s)

[that just seems so very wrong](https://youtu.be/b4mxGZlaQHY?t=01h33m41s)

[because a scale of one](https://youtu.be/b4mxGZlaQHY?t=01h33m43s)

[scale transform 3d let's just make sure](https://youtu.be/b4mxGZlaQHY?t=01h33m51s)

[maybe i've got the wrong](https://youtu.be/b4mxGZlaQHY?t=01h33m54s)

[build transform 3d](https://youtu.be/b4mxGZlaQHY?t=01h34m03s)

[it goes into the model](https://youtu.be/b4mxGZlaQHY?t=01h34m08s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h34m12s)

[this look at point could be problematic](https://youtu.be/b4mxGZlaQHY?t=01h34m18s)

[kind of tempted to just take this](https://youtu.be/b4mxGZlaQHY?t=01h34m28s)

[scaling out for the moment](https://youtu.be/b4mxGZlaQHY?t=01h34m30s)

[see what happens](https://youtu.be/b4mxGZlaQHY?t=01h34m32s)

[i'm wondering if it's not being scaled](https://youtu.be/b4mxGZlaQHY?t=01h34m40s)

[if it will actually behave the way i](https://youtu.be/b4mxGZlaQHY?t=01h34m42s)

[want](https://youtu.be/b4mxGZlaQHY?t=01h34m43s)

[the fact that this thing shifts all the](https://youtu.be/b4mxGZlaQHY?t=01h34m49s)

[way over on a zero](https://youtu.be/b4mxGZlaQHY?t=01h34m50s)

[makes me suspect there's something else](https://youtu.be/b4mxGZlaQHY?t=01h34m58s)

[at play that i'm missing](https://youtu.be/b4mxGZlaQHY?t=01h35m00s)

[oh look at that there's field of view](https://youtu.be/b4mxGZlaQHY?t=01h35m04s)

[hardcoded to 45.](https://youtu.be/b4mxGZlaQHY?t=01h35m06s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h35m14s)

[look at that there is](https://youtu.be/b4mxGZlaQHY?t=01h35m15s)

[ahaha](https://youtu.be/b4mxGZlaQHY?t=01h35m19s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h35m20s)

[there is some camera setup stuff being](https://youtu.be/b4mxGZlaQHY?t=01h35m21s)

[done up here](https://youtu.be/b4mxGZlaQHY?t=01h35m24s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=01h35m34s)

[what is going on here so this is look at](https://youtu.be/b4mxGZlaQHY?t=01h35m35s)

[point](https://youtu.be/b4mxGZlaQHY?t=01h35m38s)

[model bounds](https://youtu.be/b4mxGZlaQHY?t=01h35m44s)

[i wonder if we could actually just](https://youtu.be/b4mxGZlaQHY?t=01h35m46s)

[switch to using this over here](https://youtu.be/b4mxGZlaQHY?t=01h35m47s)

[model gets assigned where](https://youtu.be/b4mxGZlaQHY?t=01h35m54s)

[group](https://youtu.be/b4mxGZlaQHY?t=01h36m04s)

[the last item in the group](https://youtu.be/b4mxGZlaQHY?t=01h36m06s)

[model 3d visual](https://youtu.be/b4mxGZlaQHY?t=01h36m09s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h36m11s)

[okay so we could we could get the bounce](https://youtu.be/b4mxGZlaQHY?t=01h36m15s)

[back out](https://youtu.be/b4mxGZlaQHY?t=01h36m16s)

[that wouldn't be horrible](https://youtu.be/b4mxGZlaQHY?t=01h36m19s)

[now this is doing more or less the same](https://youtu.be/b4mxGZlaQHY?t=01h36m26s)

[thing](https://youtu.be/b4mxGZlaQHY?t=01h36m28s)

[field of view](https://youtu.be/b4mxGZlaQHY?t=01h36m32s)

[so hold on though they are setting a](https://youtu.be/b4mxGZlaQHY?t=01h36m35s)

[position](https://youtu.be/b4mxGZlaQHY?t=01h36m37s)

[the camera distance](https://youtu.be/b4mxGZlaQHY?t=01h36m45s)

[the only change here](https://youtu.be/b4mxGZlaQHY?t=01h36m56s)

[let's eliminate this update 3d bit](https://youtu.be/b4mxGZlaQHY?t=01h37m04s)

[because i'm wondering](https://youtu.be/b4mxGZlaQHY?t=01h37m07s)

[i'm wondering now](https://youtu.be/b4mxGZlaQHY?t=01h37m13s)

[now that i've gotten that](https://youtu.be/b4mxGZlaQHY?t=01h37m15s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h37m19s)

[okay so i find it interesting that the](https://youtu.be/b4mxGZlaQHY?t=01h37m30s)

[rotation angle seems to have inverted](https://youtu.be/b4mxGZlaQHY?t=01h37m32s)

[but it's now centered about the right](https://youtu.be/b4mxGZlaQHY?t=01h37m39s)

[thing okay so we've got a negative](https://youtu.be/b4mxGZlaQHY?t=01h37m41s)

[in here that's different](https://youtu.be/b4mxGZlaQHY?t=01h37m45s)

[so the only difference is this guy here](https://youtu.be/b4mxGZlaQHY?t=01h37m58s)

[i think because this vector here](https://youtu.be/b4mxGZlaQHY?t=01h38m01s)

[is i believe the z-axis](https://youtu.be/b4mxGZlaQHY?t=01h38m06s)

[yes that's a z-axis so we can filter](https://youtu.be/b4mxGZlaQHY?t=01h38m13s)

[that down](https://youtu.be/b4mxGZlaQHY?t=01h38m15s)

[the axis](https://youtu.be/b4mxGZlaQHY?t=01h38m17s)

[this one i think is](https://youtu.be/b4mxGZlaQHY?t=01h38m19s)

[negative y-axis](https://youtu.be/b4mxGZlaQHY?t=01h38m22s)

[might account for the](https://youtu.be/b4mxGZlaQHY?t=01h38m29s)

[because this one's doing negative z-axis](https://youtu.be/b4mxGZlaQHY?t=01h38m35s)

[since this one's doing negative y-axis](https://youtu.be/b4mxGZlaQHY?t=01h38m37s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h38m44s)

[build a view is hard coded there at 45](https://youtu.be/b4mxGZlaQHY?t=01h38m46s)

[which is fine](https://youtu.be/b4mxGZlaQHY?t=01h38m49s)

[and so then the only difference is this](https://youtu.be/b4mxGZlaQHY?t=01h38m51s)

[look at point](https://youtu.be/b4mxGZlaQHY?t=01h38m54s)

[which is let's see the x](https://youtu.be/b4mxGZlaQHY?t=01h38m58s)

[this is just getting this this is the 3d](https://youtu.be/b4mxGZlaQHY?t=01h39m02s)

[point of the center of our object](https://youtu.be/b4mxGZlaQHY?t=01h39m04s)

[because it's grabbing the x coordinate](https://youtu.be/b4mxGZlaQHY?t=01h39m06s)

[adding half of the x to go halfway](https://youtu.be/b4mxGZlaQHY?t=01h39m08s)

[across y coordinate plus half of y so](https://youtu.be/b4mxGZlaQHY?t=01h39m10s)

[this is legitimately if you imagine our](https://youtu.be/b4mxGZlaQHY?t=01h39m14s)

[our model bounds is a cube this is dead](https://youtu.be/b4mxGZlaQHY?t=01h39m16s)

[center of the cube](https://youtu.be/b4mxGZlaQHY?t=01h39m19s)

[so we are looking at the center point](https://youtu.be/b4mxGZlaQHY?t=01h39m21s)

[and then camera distance](https://youtu.be/b4mxGZlaQHY?t=01h39m25s)

[is the](https://youtu.be/b4mxGZlaQHY?t=01h39m30s)

[the x width](https://youtu.be/b4mxGZlaQHY?t=01h39m32s)

[halfway](https://youtu.be/b4mxGZlaQHY?t=01h39m34s)

[we are backing the camera](https://youtu.be/b4mxGZlaQHY?t=01h39m36s)

[up](https://youtu.be/b4mxGZlaQHY?t=01h39m38s)

[yes this is going to be](https://youtu.be/b4mxGZlaQHY?t=01h39m44s)

[going backwards so we start at the very](https://youtu.be/b4mxGZlaQHY?t=01h39m45s)

[center of our cube and then we](https://youtu.be/b4mxGZlaQHY?t=01h39m48s)

[back the camera up](https://youtu.be/b4mxGZlaQHY?t=01h39m50s)

[along the z axis](https://youtu.be/b4mxGZlaQHY?t=01h39m53s)

[right](https://youtu.be/b4mxGZlaQHY?t=01h39m56s)

[yeah](https://youtu.be/b4mxGZlaQHY?t=01h39m57s)

[you back the camera up along the z axis](https://youtu.be/b4mxGZlaQHY?t=01h39m58s)

[half](https://youtu.be/b4mxGZlaQHY?t=01h40m02s)

[well let's see hold on order of](https://youtu.be/b4mxGZlaQHY?t=01h40m03s)

[operations here](https://youtu.be/b4mxGZlaQHY?t=01h40m04s)

[it's going to do the tangent](https://youtu.be/b4mxGZlaQHY?t=01h40m08s)

[uh so](https://youtu.be/b4mxGZlaQHY?t=01h40m11s)

[field of view which is set to 45 degrees](https://youtu.be/b4mxGZlaQHY?t=01h40m14s)

[converted to radians](https://youtu.be/b4mxGZlaQHY?t=01h40m17s)

[half of that](https://youtu.be/b4mxGZlaQHY?t=01h40m24s)

[so half of a 45 degree angle](https://youtu.be/b4mxGZlaQHY?t=01h40m26s)

[divided by](https://youtu.be/b4mxGZlaQHY?t=01h40m34s)

[half of the horizontal size](https://youtu.be/b4mxGZlaQHY?t=01h40m47s)

[so i think the intent there is to just](https://youtu.be/b4mxGZlaQHY?t=01h40m54s)

[does that end up working i'm a little](https://youtu.be/b4mxGZlaQHY?t=01h40m57s)

[confused by the radian](https://youtu.be/b4mxGZlaQHY?t=01h40m59s)

[division here and i'm maybe just missing](https://youtu.be/b4mxGZlaQHY?t=01h41m02s)

[it but](https://youtu.be/b4mxGZlaQHY?t=01h41m05s)

[clearly this thing backs up the camera](https://youtu.be/b4mxGZlaQHY?t=01h41m06s)

[for it](https://youtu.be/b4mxGZlaQHY?t=01h41m08s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h41m17s)

[that's all that is doing](https://youtu.be/b4mxGZlaQHY?t=01h41m19s)

[this one here was adjusting that point](https://youtu.be/b4mxGZlaQHY?t=01h41m23s)

[as it was going](https://youtu.be/b4mxGZlaQHY?t=01h41m30s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h41m41s)

[center of the z-axis](https://youtu.be/b4mxGZlaQHY?t=01h41m46s)

[i think that's fine](https://youtu.be/b4mxGZlaQHY?t=01h41m58s)

[though that also makes me realize that](https://youtu.be/b4mxGZlaQHY?t=01h42m01s)

[this guy here](https://youtu.be/b4mxGZlaQHY?t=01h42m05s)

[should almost assuredly be](https://youtu.be/b4mxGZlaQHY?t=01h42m08s)

[um bounds](https://youtu.be/b4mxGZlaQHY?t=01h42m12s)

[size x](https://youtu.be/b4mxGZlaQHY?t=01h42m16s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h42m19s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h42m20s)

[bounds](https://youtu.be/b4mxGZlaQHY?t=01h42m21s)

[sides y](https://youtu.be/b4mxGZlaQHY?t=01h42m23s)

[okay so i don't think this completely](https://youtu.be/b4mxGZlaQHY?t=01h42m26s)

[fixes it but it should maintain](https://youtu.be/b4mxGZlaQHY?t=01h42m28s)

[parity](https://youtu.be/b4mxGZlaQHY?t=01h42m30s)

[okay so that's there](https://youtu.be/b4mxGZlaQHY?t=01h42m33s)

[20 degrees rotates out now](https://youtu.be/b4mxGZlaQHY?t=01h42m36s)

[01:42:40,800 --> 01:42:45,280](https://youtu.be/b4mxGZlaQHY?t=01h42m39s)

really big

[minus 20 gets smaller](https://youtu.be/b4mxGZlaQHY?t=01h42m42s)

[minus 45](https://youtu.be/b4mxGZlaQHY?t=01h42m45s)

[it's smaller because the](https://youtu.be/b4mxGZlaQHY?t=01h42m46s)

[rotation](https://youtu.be/b4mxGZlaQHY?t=01h42m49s)

[is occurring right along this axis here](https://youtu.be/b4mxGZlaQHY?t=01h42m52s)

[and what i'd really like to do is switch](https://youtu.be/b4mxGZlaQHY?t=01h42m57s)

[the rotation such that it occurs across](https://youtu.be/b4mxGZlaQHY?t=01h42m59s)

[the middle](https://youtu.be/b4mxGZlaQHY?t=01h43m01s)

[i'm a little curious what this value](https://youtu.be/b4mxGZlaQHY?t=01h43m04s)

[here is](https://youtu.be/b4mxGZlaQHY?t=01h43m06s)

[i would sort of expected this is size x](https://youtu.be/b4mxGZlaQHY?t=01h43m08s)

[to be 200 because that's the size of](https://youtu.be/b4mxGZlaQHY?t=01h43m11s)

[okay so it is so center x](https://youtu.be/b4mxGZlaQHY?t=01h43m17s)

[of the rotation transform](https://youtu.be/b4mxGZlaQHY?t=01h43m20s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h43m34s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h43m48s)

[i'm just going to set that to 100 while](https://youtu.be/b4mxGZlaQHY?t=01h43m51s)

[we're in here real quick just to see i](https://youtu.be/b4mxGZlaQHY?t=01h43m52s)

[don't think it's going to make any](https://youtu.be/b4mxGZlaQHY?t=01h43m54s)

[difference](https://youtu.be/b4mxGZlaQHY?t=01h43m56s)

[but um](https://youtu.be/b4mxGZlaQHY?t=01h43m59s)

[definitely changing](https://youtu.be/b4mxGZlaQHY?t=01h44m15s)

[let's think about this for a moment](https://youtu.be/b4mxGZlaQHY?t=01h44m27s)

[aside from this camera distance](https://youtu.be/b4mxGZlaQHY?t=01h44m36s)

[and this so this perspective camera](https://youtu.be/b4mxGZlaQHY?t=01h44m43s)

[takes in exactly what](https://youtu.be/b4mxGZlaQHY?t=01h44m44s)

[a position](https://youtu.be/b4mxGZlaQHY?t=01h44m48s)

[which we give it](https://youtu.be/b4mxGZlaQHY?t=01h44m49s)

[we start from the center of our our mesh](https://youtu.be/b4mxGZlaQHY?t=01h44m54s)

[and go backwards](https://youtu.be/b4mxGZlaQHY?t=01h44m56s)

[and we are looking at the](https://youtu.be/b4mxGZlaQHY?t=01h45m01s)

[oh hang on](https://youtu.be/b4mxGZlaQHY?t=01h45m09s)

[x y z](https://youtu.be/b4mxGZlaQHY?t=01h45m10s)

[we're looking down the z axis](https://youtu.be/b4mxGZlaQHY?t=01h45m13s)

[up direction is](https://youtu.be/b4mxGZlaQHY?t=01h45m18s)

[i guess it really doesn't matter whether](https://youtu.be/b4mxGZlaQHY?t=01h45m21s)

[it's negative y or positive y does it](https://youtu.be/b4mxGZlaQHY?t=01h45m22s)

[in this case it's really not going to](https://youtu.be/b4mxGZlaQHY?t=01h45m26s)

[make any difference](https://youtu.be/b4mxGZlaQHY?t=01h45m27s)

[i guess it does matter whether the](https://youtu.be/b4mxGZlaQHY?t=01h45m33s)

[origin is bottom left as i'm assuming or](https://youtu.be/b4mxGZlaQHY?t=01h45m35s)

[top left](https://youtu.be/b4mxGZlaQHY?t=01h45m37s)

[not a big deal for the moment](https://youtu.be/b4mxGZlaQHY?t=01h45m40s)

[but if things appear upside down that](https://youtu.be/b4mxGZlaQHY?t=01h45m43s)

[will be y](https://youtu.be/b4mxGZlaQHY?t=01h45m44s)

[and then field of view is what i i guess](https://youtu.be/b4mxGZlaQHY?t=01h45m47s)

[i'm](https://youtu.be/b4mxGZlaQHY?t=01h45m50s)

[maybe that's the parameter i'm not fully](https://youtu.be/b4mxGZlaQHY?t=01h45m51s)

[understanding](https://youtu.be/b4mxGZlaQHY?t=01h45m53s)

[width of the camera](https://youtu.be/b4mxGZlaQHY?t=01h45m55s)

[angle of projection specified in degrees](https://youtu.be/b4mxGZlaQHY?t=01h45m57s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h46m03s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h46m09s)

[so this really shouldn't need to change](https://youtu.be/b4mxGZlaQHY?t=01h46m14s)

[rotation so i guess the question then is](https://youtu.be/b4mxGZlaQHY?t=01h46m30s)

[i don't understand what this is](https://youtu.be/b4mxGZlaQHY?t=01h46m34s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h46m39s)

[i'm curious if maybe this i this is just](https://youtu.be/b4mxGZlaQHY?t=01h46m45s)

[being complicated due to the math here](https://youtu.be/b4mxGZlaQHY?t=01h46m48s)

[and](https://youtu.be/b4mxGZlaQHY?t=01h46m52s)

[i want to look at what else is in here](https://youtu.be/b4mxGZlaQHY?t=01h46m54s)

[represents a 3d rotation of a specified](https://youtu.be/b4mxGZlaQHY?t=01h47m04s)

[angle about a specified axis hallelujah](https://youtu.be/b4mxGZlaQHY?t=01h47m06s)

[that sounds remarkably like exactly what](https://youtu.be/b4mxGZlaQHY?t=01h47m10s)

[i'm trying to do](https://youtu.be/b4mxGZlaQHY?t=01h47m12s)

[axis angle](https://youtu.be/b4mxGZlaQHY?t=01h47m14s)

[hey](https://youtu.be/b4mxGZlaQHY?t=01h47m16s)

[let's try that that sounds like exactly](https://youtu.be/b4mxGZlaQHY?t=01h47m18s)

[what i want](https://youtu.be/b4mxGZlaQHY?t=01h47m21s)

[okay when in doubt read the docs](https://youtu.be/b4mxGZlaQHY?t=01h47m24s)

[okay so we are going to](https://youtu.be/b4mxGZlaQHY?t=01h47m28s)

[uh i'm gonna leave this here for the](https://youtu.be/b4mxGZlaQHY?t=01h47m31s)

[moment](https://youtu.be/b4mxGZlaQHY?t=01h47m33s)

[and then i'm going to do](https://youtu.be/b4mxGZlaQHY?t=01h47m35s)

[change this up to](https://youtu.be/b4mxGZlaQHY?t=01h47m39s)

[axis rotation](https://youtu.be/b4mxGZlaQHY?t=01h47m40s)

[and then we're going to come down here](https://youtu.be/b4mxGZlaQHY?t=01h47m45s)

[we're going to comment you out and we](https://youtu.be/b4mxGZlaQHY?t=01h47m47s)

[are going to go with](https://youtu.be/b4mxGZlaQHY?t=01h47m50s)

[axis rotation](https://youtu.be/b4mxGZlaQHY?t=01h47m51s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h47m58s)

[what's your problem](https://youtu.be/b4mxGZlaQHY?t=01h47m59s)

[uh add](https://youtu.be/b4mxGZlaQHY?t=01h48m06s)

[oh](https://youtu.be/b4mxGZlaQHY?t=01h48m17s)

[axis rotation 3d](https://youtu.be/b4mxGZlaQHY?t=01h48m28s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h48m36s)

[okay so i guess now the question is how](https://youtu.be/b4mxGZlaQHY?t=01h48m37s)

[the heck do i use this thing](https://youtu.be/b4mxGZlaQHY?t=01h48m39s)

[because](https://youtu.be/b4mxGZlaQHY?t=01h48m41s)

[for the flipper that's all we want to do](https://youtu.be/b4mxGZlaQHY?t=01h48m42s)

[is i want to rotate about an axis](https://youtu.be/b4mxGZlaQHY?t=01h48m46s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h48m51s)

[geometry model 3d rotate transform 3d](https://youtu.be/b4mxGZlaQHY?t=01h48m54s)

[got it](https://youtu.be/b4mxGZlaQHY?t=01h49m01s)

[rotation transform](https://youtu.be/b4mxGZlaQHY?t=01h49m07s)

[x-axis rotation](https://youtu.be/b4mxGZlaQHY?t=01h49m12s)

[this goes back here](https://youtu.be/b4mxGZlaQHY?t=01h49m14s)

[this goes back to xs group](https://youtu.be/b4mxGZlaQHY?t=01h49m16s)

[got it](https://youtu.be/b4mxGZlaQHY?t=01h49m20s)

[okay so that goes there](https://youtu.be/b4mxGZlaQHY?t=01h49m20s)

[that goes there](https://youtu.be/b4mxGZlaQHY?t=01h49m22s)

[everyone is happy](https://youtu.be/b4mxGZlaQHY?t=01h49m25s)

[okay and](https://youtu.be/b4mxGZlaQHY?t=01h49m28s)

[axis rotation dot axis](https://youtu.be/b4mxGZlaQHY?t=01h49m30s)

[we are going to rotate it about](https://youtu.be/b4mxGZlaQHY?t=01h49m34s)

[i guess we want to rotate it about the z](https://youtu.be/b4mxGZlaQHY?t=01h49m38s)

[axis right](https://youtu.be/b4mxGZlaQHY?t=01h49m39s)

[so z](https://youtu.be/b4mxGZlaQHY?t=01h49m42s)

[axis](https://youtu.be/b4mxGZlaQHY?t=01h49m44s)

[okay and then](https://youtu.be/b4mxGZlaQHY?t=01h49m46s)

[axis rotation](https://youtu.be/b4mxGZlaQHY?t=01h49m49s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h49m52s)

[angle is not set](https://youtu.be/b4mxGZlaQHY?t=01h49m52s)

[but](https://youtu.be/b4mxGZlaQHY?t=01h49m56s)

[that is what we're going to do down in](https://youtu.be/b4mxGZlaQHY?t=01h49m56s)

[this so rather than doing all of this](https://youtu.be/b4mxGZlaQHY?t=01h50m00s)

[we're just going to go with](https://youtu.be/b4mxGZlaQHY?t=01h50m02s)

[rotation y](https://youtu.be/b4mxGZlaQHY?t=01h50m04s)

[and do you have a](https://youtu.be/b4mxGZlaQHY?t=01h50m07s)

[i guess the center doesn't really make](https://youtu.be/b4mxGZlaQHY?t=01h50m10s)

[sense does it](https://youtu.be/b4mxGZlaQHY?t=01h50m12s)

[yeah okay so we we're gonna try that](https://youtu.be/b4mxGZlaQHY?t=01h50m18s)

[because boy that sounds a heck of a lot](https://youtu.be/b4mxGZlaQHY?t=01h50m21s)

[easier](https://youtu.be/b4mxGZlaQHY?t=01h50m23s)

[all this fancy math](https://youtu.be/b4mxGZlaQHY?t=01h50m26s)

[rotating an object around](https://youtu.be/b4mxGZlaQHY?t=01h50m29s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h50m32s)

[well okay so i think we can conclude](https://youtu.be/b4mxGZlaQHY?t=01h50m37s)

[very conclusively](https://youtu.be/b4mxGZlaQHY?t=01h50m39s)

[at the wrong axis](https://youtu.be/b4mxGZlaQHY?t=01h50m41s)

[okay so we'll try this](https://youtu.be/b4mxGZlaQHY?t=01h50m43s)

[y-axis](https://youtu.be/b4mxGZlaQHY?t=01h50m49s)

[try again](https://youtu.be/b4mxGZlaQHY?t=01h50m51s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h51m00s)

[now we're at least back to where we were](https://youtu.be/b4mxGZlaQHY?t=01h51m04s)

[if we do minus 45 we start seeing it](https://youtu.be/b4mxGZlaQHY?t=01h51m13s)

[rotate out](https://youtu.be/b4mxGZlaQHY?t=01h51m18s)

[interesting to me that](https://youtu.be/b4mxGZlaQHY?t=01h51m23s)

[these corners are shifting it's like](https://youtu.be/b4mxGZlaQHY?t=01h51m26s)

[oh it's got to be because of my](https://youtu.be/b4mxGZlaQHY?t=01h51m32s)

[look at point](https://youtu.be/b4mxGZlaQHY?t=01h51m35s)

[i'm 100 back](https://youtu.be/b4mxGZlaQHY?t=01h51m39s)

[from this](https://youtu.be/b4mxGZlaQHY?t=01h51m42s)

[interesting](https://youtu.be/b4mxGZlaQHY?t=01h51m51s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h51m58s)

[got it okay so if that's the case](https://youtu.be/b4mxGZlaQHY?t=01h52m03s)

[well](https://youtu.be/b4mxGZlaQHY?t=01h52m08s)

[which is why it gets bigger when it](https://youtu.be/b4mxGZlaQHY?t=01h52m11s)

[rotates towards me](https://youtu.be/b4mxGZlaQHY?t=01h52m12s)

[so if i want to spin this thing](https://youtu.be/b4mxGZlaQHY?t=01h52m14s)

[what is the right way to do this](https://youtu.be/b4mxGZlaQHY?t=01h52m19s)

[i think in 3d space](https://youtu.be/b4mxGZlaQHY?t=01h52m21s)

[the object i want it to](https://youtu.be/b4mxGZlaQHY?t=01h52m25s)

[be centered](https://youtu.be/b4mxGZlaQHY?t=01h52m29s)

[i feel the view](https://youtu.be/b4mxGZlaQHY?t=01h52m31s)

[scale needs to be the look at point](https://youtu.be/b4mxGZlaQHY?t=01h52m43s)

[center](https://youtu.be/b4mxGZlaQHY?t=01h52m46s)

[rotational transform center](https://youtu.be/b4mxGZlaQHY?t=01h52m49s)

[i'm gonna do](https://youtu.be/b4mxGZlaQHY?t=01h52m54s)

[i don't think that's gonna make a big](https://youtu.be/b4mxGZlaQHY?t=01h53m03s)

[difference at all](https://youtu.be/b4mxGZlaQHY?t=01h53m04s)

[and we're gonna put the z scale back in](https://youtu.be/b4mxGZlaQHY?t=01h53m06s)

[but i think this is a little closer](https://youtu.be/b4mxGZlaQHY?t=01h53m12s)

[at least in terms of what conceptually](https://youtu.be/b4mxGZlaQHY?t=01h53m16s)

[what i want to think about when i do](https://youtu.be/b4mxGZlaQHY?t=01h53m18s)

[this](https://youtu.be/b4mxGZlaQHY?t=01h53m19s)

[so size z is zero so it's gonna still be](https://youtu.be/b4mxGZlaQHY?t=01h53m20s)

[zero so that's fine](https://youtu.be/b4mxGZlaQHY?t=01h53m23s)

[let it](https://youtu.be/b4mxGZlaQHY?t=01h53m25s)

[we'll let it live and this should still](https://youtu.be/b4mxGZlaQHY?t=01h53m26s)

[be the same](https://youtu.be/b4mxGZlaQHY?t=01h53m28s)

[because it shouldn't be doing](https://youtu.be/b4mxGZlaQHY?t=01h53m30s)

[anything fancy](https://youtu.be/b4mxGZlaQHY?t=01h53m34s)

[so if i have a plane](https://youtu.be/b4mxGZlaQHY?t=01h53m39s)

[because right now i'm rotating about](https://youtu.be/b4mxGZlaQHY?t=01h53m44s)

[this](https://youtu.be/b4mxGZlaQHY?t=01h53m46s)

[how do i shift it](https://youtu.be/b4mxGZlaQHY?t=01h53m49s)

[such that its center](https://youtu.be/b4mxGZlaQHY?t=01h53m54s)

[i think i want to actually take the](https://youtu.be/b4mxGZlaQHY?t=01h54m10s)

[object and shift its position](https://youtu.be/b4mxGZlaQHY?t=01h54m12s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h54m17s)

[such that it's centered about the origin](https://youtu.be/b4mxGZlaQHY?t=01h54m26s)

[rather than having its edge about it](https://youtu.be/b4mxGZlaQHY?t=01h54m28s)

[um i don't know where](https://youtu.be/b4mxGZlaQHY?t=01h54m34s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=01h54m37s)

[model visual](https://youtu.be/b4mxGZlaQHY?t=01h54m39s)

[group](https://youtu.be/b4mxGZlaQHY?t=01h54m46s)

[uh let's see](https://youtu.be/b4mxGZlaQHY?t=01h54m56s)

[i could](https://youtu.be/b4mxGZlaQHY?t=01h55m01s)

[translate it](https://youtu.be/b4mxGZlaQHY?t=01h55m02s)

[the x offset](https://youtu.be/b4mxGZlaQHY?t=01h55m14s)

[is going to be](https://youtu.be/b4mxGZlaQHY?t=01h55m16s)

[well let's](https://youtu.be/b4mxGZlaQHY?t=01h55m21s)

[uh](https://youtu.be/b4mxGZlaQHY?t=01h55m24s)

[boom](https://youtu.be/b4mxGZlaQHY?t=01h55m29s)

[translate transform like that](https://youtu.be/b4mxGZlaQHY?t=01h55m31s)

[and so this down here becomes](https://youtu.be/b4mxGZlaQHY?t=01h55m34s)

[translate transform offset x](https://youtu.be/b4mxGZlaQHY?t=01h55m38s)

[it's](https://youtu.be/b4mxGZlaQHY?t=01h55m42s)

[uh bounds](https://youtu.be/b4mxGZlaQHY?t=01h55m43s)

[size and x](https://youtu.be/b4mxGZlaQHY?t=01h55m46s)

[divided by two](https://youtu.be/b4mxGZlaQHY?t=01h55m48s)

[and](https://youtu.be/b4mxGZlaQHY?t=01h55m50s)

[i want it negative because i want to](https://youtu.be/b4mxGZlaQHY?t=01h55m51s)

[bring it backwards](https://youtu.be/b4mxGZlaQHY?t=01h55m53s)

[along the x-axis](https://youtu.be/b4mxGZlaQHY?t=01h55m55s)

[where it should sit there](https://youtu.be/b4mxGZlaQHY?t=01h55m59s)

[i have a feeling what this is going to](https://youtu.be/b4mxGZlaQHY?t=01h56m03s)

[do is it's going to shift](https://youtu.be/b4mxGZlaQHY?t=01h56m05s)

[the box](https://youtu.be/b4mxGZlaQHY?t=01h56m07s)

[and not my center of origin](https://youtu.be/b4mxGZlaQHY?t=01h56m11s)

[did what i expected](https://youtu.be/b4mxGZlaQHY?t=01h56m16s)

[yeah](https://youtu.be/b4mxGZlaQHY?t=01h56m18s)

[but now when i do](https://youtu.be/b4mxGZlaQHY?t=01h56m20s)

[so now](https://youtu.be/b4mxGZlaQHY?t=01h56m24s)

[now it's rotating about the](https://youtu.be/b4mxGZlaQHY?t=01h56m25s)

[the bit that i expected to](https://youtu.be/b4mxGZlaQHY?t=01h56m28s)

[so that's fine](https://youtu.be/b4mxGZlaQHY?t=01h56m34s)

[aside from the fact that all that i'm](https://youtu.be/b4mxGZlaQHY?t=01h56m36s)

[rotating about the slightly the wrong](https://youtu.be/b4mxGZlaQHY?t=01h56m39s)

[point](https://youtu.be/b4mxGZlaQHY?t=01h56m42s)

[so](https://youtu.be/b4mxGZlaQHY?t=01h56m43s)

[if that will get it there](https://youtu.be/b4mxGZlaQHY?t=01h56m45s)

[i think what i can do then is](https://youtu.be/b4mxGZlaQHY?t=01h56m48s)

[just tweak the axis of](https://youtu.be/b4mxGZlaQHY?t=01h56m52s)

[rotation i'll leave you there](https://youtu.be/b4mxGZlaQHY?t=01h56m54s)

[because this is y-axis](https://youtu.be/b4mxGZlaQHY?t=01h57m01s)

[how is that going to work because this](https://youtu.be/b4mxGZlaQHY?t=01h57m07s)

[is just doing a matrix transform](https://youtu.be/b4mxGZlaQHY?t=01h57m09s)

[it's ultimately going to tweak that](https://youtu.be/b4mxGZlaQHY?t=01h57m16s)

[how do i shift this](https://youtu.be/b4mxGZlaQHY?t=01h57m36s)

[such that](https://youtu.be/b4mxGZlaQHY?t=01h57m38s)

[that i position it accordingly](https://youtu.be/b4mxGZlaQHY?t=01h57m48s)

[model bounds](https://youtu.be/b4mxGZlaQHY?t=01h57m58s)

[i'd like to center](https://youtu.be/b4mxGZlaQHY?t=01h58m04s)

[center](https://youtu.be/b4mxGZlaQHY?t=01h58m11s)

[so i want to center the model itself](https://youtu.be/b4mxGZlaQHY?t=01h58m13s)

[about the origin](https://youtu.be/b4mxGZlaQHY?t=01h58m15s)

[that's where i'm not sure i understand](https://youtu.be/b4mxGZlaQHY?t=01h58m17s)

[how to do this](https://youtu.be/b4mxGZlaQHY?t=01h58m20s)

[um](https://youtu.be/b4mxGZlaQHY?t=01h58m22s)

[center](https://youtu.be/b4mxGZlaQHY?t=01h58m23s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h58m26s)

[do this](https://youtu.be/b4mxGZlaQHY?t=01h58m30s)

[on](https://youtu.be/b4mxGZlaQHY?t=01h58m34s)

[rotating around its center you first](https://youtu.be/b4mxGZlaQHY?t=01h58m42s)

[need to translate so the center is at](https://youtu.be/b4mxGZlaQHY?t=01h58m44s)

[the origin then rotate](https://youtu.be/b4mxGZlaQHY?t=01h58m46s)

[okay](https://youtu.be/b4mxGZlaQHY?t=01h58m54s)

[i mean i could do that but i don't](https://youtu.be/b4mxGZlaQHY?t=01h58m55s)

[really want to](https://youtu.be/b4mxGZlaQHY?t=01h58m57s)

[and set the center rotation of the](https://youtu.be/b4mxGZlaQHY?t=01h59m10s)

[transform 3d](https://youtu.be/b4mxGZlaQHY?t=01h59m13s)

[okay so that's kind of more what i was](https://youtu.be/b4mxGZlaQHY?t=01h59m16s)

[envisioning](https://youtu.be/b4mxGZlaQHY?t=01h59m18s)

[i'm wondering if i said u two a hundred](https://youtu.be/b4mxGZlaQHY?t=01h59m25s)

[you two a hundred](https://youtu.be/b4mxGZlaQHY?t=01h59m30s)

[i'm gonna try this and then i may try to](https://youtu.be/b4mxGZlaQHY?t=01h59m55s)

[just shift the axis over](https://youtu.be/b4mxGZlaQHY?t=01h59m57s)

[i think if i move the axis over](https://youtu.be/b4mxGZlaQHY?t=01h59m59s)

[i don't know exactly how that's going to](https://youtu.be/b4mxGZlaQHY?t=02h00m03s)

[play out but we'll see](https://youtu.be/b4mxGZlaQHY?t=02h00m05s)

[okay so this is still](https://youtu.be/b4mxGZlaQHY?t=02h00m08s)

[oh hang on](https://youtu.be/b4mxGZlaQHY?t=02h00m11s)

[why is there a translate transform in](https://youtu.be/b4mxGZlaQHY?t=02h00m15s)

[there](https://youtu.be/b4mxGZlaQHY?t=02h00m16s)

[because i left it in there](https://youtu.be/b4mxGZlaQHY?t=02h00m21s)

[one more time](https://youtu.be/b4mxGZlaQHY?t=02h00m24s)

[put it up](https://youtu.be/b4mxGZlaQHY?t=02h00m31s)

[okay so it's](https://youtu.be/b4mxGZlaQHY?t=02h00m39s)

[at least rotating around the center that](https://youtu.be/b4mxGZlaQHY?t=02h00m42s)

[i expect](https://youtu.be/b4mxGZlaQHY?t=02h00m45s)

[i think it's rotating about the center](https://youtu.be/b4mxGZlaQHY?t=02h00m50s)

[that i expect](https://youtu.be/b4mxGZlaQHY?t=02h00m52s)

[let's](https://youtu.be/b4mxGZlaQHY?t=02h00m55s)

[hang on](https://youtu.be/b4mxGZlaQHY?t=02h00m56s)

[i think this is](https://youtu.be/b4mxGZlaQHY?t=02h00m58s)

[part of the problem](https://youtu.be/b4mxGZlaQHY?t=02h00m59s)

[i don't think i want all of those set](https://youtu.be/b4mxGZlaQHY?t=02h01m04s)

[yep](https://youtu.be/b4mxGZlaQHY?t=02h01m10s)

[i just do these one at a time](https://youtu.be/b4mxGZlaQHY?t=02h01m13s)

[one of these is going to be on the mark](https://youtu.be/b4mxGZlaQHY?t=02h01m16s)

[i bet](https://youtu.be/b4mxGZlaQHY?t=02h01m17s)

[right](https://youtu.be/b4mxGZlaQHY?t=02h01m31s)

[a strange feeling that that camera](https://youtu.be/b4mxGZlaQHY?t=02h01m33s)

[distance point of origin is gonna](https://youtu.be/b4mxGZlaQHY?t=02h01m36s)

[bite me here in a moment](https://youtu.be/b4mxGZlaQHY?t=02h01m39s)

[okay we're gonna](https://youtu.be/b4mxGZlaQHY?t=02h02m02s)

[let's come back over here um](https://youtu.be/b4mxGZlaQHY?t=02h02m19s)

[private](https://youtu.be/b4mxGZlaQHY?t=02h02m24s)

[it's](https://youtu.be/b4mxGZlaQHY?t=02h02m25s)

[thatcher timer](https://youtu.be/b4mxGZlaQHY?t=02h02m27s)

[it's gonna do this for a moment i think](https://youtu.be/b4mxGZlaQHY?t=02h02m32s)

[what i want to do is make this thing](https://youtu.be/b4mxGZlaQHY?t=02h02m34s)

[spin](https://youtu.be/b4mxGZlaQHY?t=02h02m35s)

[oh let's see timer](https://youtu.be/b4mxGZlaQHY?t=02h02m38s)

[tick](https://youtu.be/b4mxGZlaQHY?t=02h02m42s)

[apply and then i want to set some sort](https://youtu.be/b4mxGZlaQHY?t=02h02m48s)

[of uh interval of](https://youtu.be/b4mxGZlaQHY?t=02h02m50s)

[the time span](https://youtu.be/b4mxGZlaQHY?t=02h02m57s)

[from seconds](https://youtu.be/b4mxGZlaQHY?t=02h02m59s)

[tick every i don't know five times a](https://youtu.be/b4mxGZlaQHY?t=02h03m01s)

[second](https://youtu.be/b4mxGZlaQHY?t=02h03m03s)

[sounds great](https://youtu.be/b4mxGZlaQHY?t=02h03m04s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=02h03m06s)

[we're going to do here](https://youtu.be/b4mxGZlaQHY?t=02h03m08s)

[is we are just going to run the rotation](https://youtu.be/b4mxGZlaQHY?t=02h03m12s)

[from](https://youtu.be/b4mxGZlaQHY?t=02h03m19s)

[i want this to take a little faster](https://youtu.be/b4mxGZlaQHY?t=02h03m25s)

[uh](https://youtu.be/b4mxGZlaQHY?t=02h03m29s)

[interrotation](https://youtu.be/b4mxGZlaQHY?t=02h03m31s)

[increment](https://youtu.be/b4mxGZlaQHY?t=02h03m43s)

[ref rotation](https://youtu.be/b4mxGZlaQHY?t=02h03m45s)

[uh let's see](https://youtu.be/b4mxGZlaQHY?t=02h03m48s)

[adults gets](https://youtu.be/b4mxGZlaQHY?t=02h03m54s)

[uh if](https://youtu.be/b4mxGZlaQHY?t=02h03m56s)

[results greater than 90](https://youtu.be/b4mxGZlaQHY?t=02h03m58s)

[uh](https://youtu.be/b4mxGZlaQHY?t=02h04m02s)

[result yet minus 90](https://youtu.be/b4mxGZlaQHY?t=02h04m03s)

[uh](https://youtu.be/b4mxGZlaQHY?t=02h04m07s)

[and then we're going to do](https://youtu.be/b4mxGZlaQHY?t=02h04m08s)

[there](https://youtu.be/b4mxGZlaQHY?t=02h04m28s)

[oh i probably have to start the timer](https://youtu.be/b4mxGZlaQHY?t=02h04m30s)

[that's probably not going to do much](https://youtu.be/b4mxGZlaQHY?t=02h04m33s)

[ticking if](https://youtu.be/b4mxGZlaQHY?t=02h04m34s)

[we don't tell it to go](https://youtu.be/b4mxGZlaQHY?t=02h04m36s)

[okay so we'll have a timer we'll just](https://youtu.be/b4mxGZlaQHY?t=02h04m39s)

[have it tick this way i don't have to](https://youtu.be/b4mxGZlaQHY?t=02h04m41s)

[keep typing stuff](https://youtu.be/b4mxGZlaQHY?t=02h04m42s)

[then we can use those values for other](https://youtu.be/b4mxGZlaQHY?t=02h04m43s)

[things](https://youtu.be/b4mxGZlaQHY?t=02h04m45s)

[okay so we need this timer](https://youtu.be/b4mxGZlaQHY?t=02h04m53s)

[you know a little faster](https://youtu.be/b4mxGZlaQHY?t=02h04m55s)

[actually you know what we'll have](https://youtu.be/b4mxGZlaQHY?t=02h05m03s)

[we'll just multiply the result by](https://youtu.be/b4mxGZlaQHY?t=02h05m13s)

[n i guess](https://youtu.be/b4mxGZlaQHY?t=02h05m16s)

[oh this is](https://youtu.be/b4mxGZlaQHY?t=02h05m54s)

[never going to reset um](https://youtu.be/b4mxGZlaQHY?t=02h05m57s)

[let's see](https://youtu.be/b4mxGZlaQHY?t=02h06m03s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h06m22s)

[that kind of helps see roughly where](https://youtu.be/b4mxGZlaQHY?t=02h06m24s)

[we're sitting](https://youtu.be/b4mxGZlaQHY?t=02h06m26s)

[so we can see where where the center of](https://youtu.be/b4mxGZlaQHY?t=02h06m28s)

[rotation is it's currently somewhere off](https://youtu.be/b4mxGZlaQHY?t=02h06m29s)

[to the left](https://youtu.be/b4mxGZlaQHY?t=02h06m32s)

[okay now what we can do is we can start](https://youtu.be/b4mxGZlaQHY?t=02h06m33s)

[adding features to tweak this](https://youtu.be/b4mxGZlaQHY?t=02h06m36s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h06m40s)

[so](https://youtu.be/b4mxGZlaQHY?t=02h06m50s)

[that](https://youtu.be/b4mxGZlaQHY?t=02h06m50s)

[a little surprise center of z](https://youtu.be/b4mxGZlaQHY?t=02h06m55s)

[unless this](https://youtu.be/b4mxGZlaQHY?t=02h06m59s)

[origin isn't where i think it is](https://youtu.be/b4mxGZlaQHY?t=02h07m01s)

[what's weird about this is i've moved](https://youtu.be/b4mxGZlaQHY?t=02h07m15s)

[the origin](https://youtu.be/b4mxGZlaQHY?t=02h07m18s)

[further left](https://youtu.be/b4mxGZlaQHY?t=02h07m20s)

[or i should say further to the right and](https://youtu.be/b4mxGZlaQHY?t=02h07m22s)

[it's acting further left](https://youtu.be/b4mxGZlaQHY?t=02h07m25s)

[i wonder what happens if we go the other](https://youtu.be/b4mxGZlaQHY?t=02h07m28s)

[way](https://youtu.be/b4mxGZlaQHY?t=02h07m29s)

[and now it's just making a bigger circle](https://youtu.be/b4mxGZlaQHY?t=02h07m44s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h07m54s)

[about ready to get rid of the button](https://youtu.be/b4mxGZlaQHY?t=02h08m03s)

[click too so i don't keep doing that](https://youtu.be/b4mxGZlaQHY?t=02h08m04s)

[setting the y doesn't do a darn thing](https://youtu.be/b4mxGZlaQHY?t=02h08m08s)

[okay so here's what we're going to do](https://youtu.be/b4mxGZlaQHY?t=02h08m13s)

[we're going to change the axis of](https://youtu.be/b4mxGZlaQHY?t=02h08m14s)

[rotation](https://youtu.be/b4mxGZlaQHY?t=02h08m16s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h08m19s)

[the feeling that's going to be a little](https://youtu.be/b4mxGZlaQHY?t=02h08m32s)

[wrong because that's a vector](https://youtu.be/b4mxGZlaQHY?t=02h08m34s)

[i'm giving the x component of the vector](https://youtu.be/b4mxGZlaQHY?t=02h08m38s)

[not horribly shocked](https://youtu.be/b4mxGZlaQHY?t=02h08m53s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h08m56s)

[because it should just be multiplying](https://youtu.be/b4mxGZlaQHY?t=02h09m00s)

[the angle by the](https://youtu.be/b4mxGZlaQHY?t=02h09m01s)

[matrix which is how we're getting this](https://youtu.be/b4mxGZlaQHY?t=02h09m05s)

[here okay](https://youtu.be/b4mxGZlaQHY?t=02h09m07s)

[that makes](https://youtu.be/b4mxGZlaQHY?t=02h09m09s)

[sense](https://youtu.be/b4mxGZlaQHY?t=02h09m10s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h09m16s)

[axis rotation this is](https://youtu.be/b4mxGZlaQHY?t=02h09m20s)

[angle in degrees right this is something](https://youtu.be/b4mxGZlaQHY?t=02h09m22s)

[stupid that i'm doing](https://youtu.be/b4mxGZlaQHY?t=02h09m25s)

[in degrees okay](https://youtu.be/b4mxGZlaQHY?t=02h09m27s)

[good](https://youtu.be/b4mxGZlaQHY?t=02h09m30s)

[this field of view is still what i'm](https://youtu.be/b4mxGZlaQHY?t=02h09m42s)

[not groking](https://youtu.be/b4mxGZlaQHY?t=02h09m49s)

[i can see what is happening](https://youtu.be/b4mxGZlaQHY?t=02h09m55s)

[and i can tell that we're starting at](https://youtu.be/b4mxGZlaQHY?t=02h09m58s)

[our](https://youtu.be/b4mxGZlaQHY?t=02h10m00s)

[our point](https://youtu.be/b4mxGZlaQHY?t=02h10m03s)

[and then we're backing up some distance](https://youtu.be/b4mxGZlaQHY?t=02h10m11s)

[because the field of view wants to be a](https://youtu.be/b4mxGZlaQHY?t=02h10m16s)

[let's just double check what this ends](https://youtu.be/b4mxGZlaQHY?t=02h10m23s)

[up being](https://youtu.be/b4mxGZlaQHY?t=02h10m24s)

[build a view is just set to 45 and this](https://youtu.be/b4mxGZlaQHY?t=02h10m28s)

[thing is just](https://youtu.be/b4mxGZlaQHY?t=02h10m30s)

[i believe the intent here is just](https://youtu.be/b4mxGZlaQHY?t=02h10m32s)

[backing up such that 45 degrees of the](https://youtu.be/b4mxGZlaQHY?t=02h10m34s)

[camera view encompasses the entire](https://youtu.be/b4mxGZlaQHY?t=02h10m36s)

[target](https://youtu.be/b4mxGZlaQHY?t=02h10m40s)

[we're attempting to look](https://youtu.be/b4mxGZlaQHY?t=02h10m44s)

[look at point is 200](https://youtu.be/b4mxGZlaQHY?t=02h10m47s)

[200. so this guy here](https://youtu.be/b4mxGZlaQHY?t=02h10m50s)

[that's interesting](https://youtu.be/b4mxGZlaQHY?t=02h10m58s)

[those numbers don't line up with what i](https://youtu.be/b4mxGZlaQHY?t=02h11m03s)

[would expect](https://youtu.be/b4mxGZlaQHY?t=02h11m05s)

[maybe that's part of the problem these](https://youtu.be/b4mxGZlaQHY?t=02h11m08s)

[bounds are different than what i expect](https://youtu.be/b4mxGZlaQHY?t=02h11m10s)

[the location is weird](https://youtu.be/b4mxGZlaQHY?t=02h11m15s)

[the x and y are very different](https://youtu.be/b4mxGZlaQHY?t=02h11m19s)

[okay so this model isn't as i would](https://youtu.be/b4mxGZlaQHY?t=02h11m26s)

[expect](https://youtu.be/b4mxGZlaQHY?t=02h11m29s)

[where did model come from](https://youtu.be/b4mxGZlaQHY?t=02h11m32s)

[this model is different than what i](https://youtu.be/b4mxGZlaQHY?t=02h11m38s)

[would expect it to be](https://youtu.be/b4mxGZlaQHY?t=02h11m40s)

[so let's](https://youtu.be/b4mxGZlaQHY?t=02h11m43s)

[because it's ending up not](https://youtu.be/b4mxGZlaQHY?t=02h11m44s)

[it's being offset by](https://youtu.be/b4mxGZlaQHY?t=02h11m48s)

[some amount and i don't understand where](https://youtu.be/b4mxGZlaQHY?t=02h11m51s)

[those values are coming from](https://youtu.be/b4mxGZlaQHY?t=02h11m53s)

[okay so get content balance](https://youtu.be/b4mxGZlaQHY?t=02h11m55s)

[okay those numbers make sense we set our](https://youtu.be/b4mxGZlaQHY?t=02h11m58s)

[border to 200 200](https://youtu.be/b4mxGZlaQHY?t=02h12m00s)

[that works](https://youtu.be/b4mxGZlaQHY?t=02h12m02s)

[if visual is viewport 3d](https://youtu.be/b4mxGZlaQHY?t=02h12m05s)

[which is not okay include empty visuals](https://youtu.be/b4mxGZlaQHY?t=02h12m10s)

[don't care](https://youtu.be/b4mxGZlaQHY?t=02h12m12s)

[bounds is empty](https://youtu.be/b4mxGZlaQHY?t=02h12m14s)

[bounds width bounce height so we have a](https://youtu.be/b4mxGZlaQHY?t=02h12m17s)

[thingy](https://youtu.be/b4mxGZlaQHY?t=02h12m19s)

[what is z here](https://youtu.be/b4mxGZlaQHY?t=02h12m23s)

[d is zero okay so left](https://youtu.be/b4mxGZlaQHY?t=02h12m26s)

[right](https://youtu.be/b4mxGZlaQHY?t=02h12m29s)

[right left](https://youtu.be/b4mxGZlaQHY?t=02h12m30s)

[bottom bottom top](https://youtu.be/b4mxGZlaQHY?t=02h12m32s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h12m35s)

[no idea what triangle indices are good](https://youtu.be/b4mxGZlaQHY?t=02h12m42s)

[for](https://youtu.be/b4mxGZlaQHY?t=02h12m44s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h12m48s)

[make brush from visual](https://youtu.be/b4mxGZlaQHY?t=02h12m52s)

[draw outlines that's something we'll end](https://youtu.be/b4mxGZlaQHY?t=02h12m58s)

[up getting rid of](https://youtu.be/b4mxGZlaQHY?t=02h13m00s)

[drawing context](https://youtu.be/b4mxGZlaQHY?t=02h13m04s)

[offset matrices great](https://youtu.be/b4mxGZlaQHY?t=02h13m07s)

[great drawing context](https://youtu.be/b4mxGZlaQHY?t=02h13m10s)

[size](https://youtu.be/b4mxGZlaQHY?t=02h13m16s)

[epi dpi](https://youtu.be/b4mxGZlaQHY?t=02h13m19s)

[the scale gets set to 1 which is as](https://youtu.be/b4mxGZlaQHY?t=02h13m26s)

[expected](https://youtu.be/b4mxGZlaQHY?t=02h13m28s)

[pixel format is always going to be set](https://youtu.be/b4mxGZlaQHY?t=02h13m30s)

[we render the visual](https://youtu.be/b4mxGZlaQHY?t=02h13m34s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h13m45s)

[image brush](https://youtu.be/b4mxGZlaQHY?t=02h13m47s)

[material](https://youtu.be/b4mxGZlaQHY?t=02h13m53s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h14m02s)

[aside from those](https://youtu.be/b4mxGZlaQHY?t=02h14m09s)

[triangle indices nothing there seems to](https://youtu.be/b4mxGZlaQHY?t=02h14m13s)

[be a problem](https://youtu.be/b4mxGZlaQHY?t=02h14m15s)

[geometry model 3d](https://youtu.be/b4mxGZlaQHY?t=02h14m22s)

[back material](https://youtu.be/b4mxGZlaQHY?t=02h14m29s)

[this thing not have a](https://youtu.be/b4mxGZlaQHY?t=02h14m33s)

[director that would let you set](https://youtu.be/b4mxGZlaQHY?t=02h14m36s)

[both oh](https://youtu.be/b4mxGZlaQHY?t=02h14m38s)

[interesting](https://youtu.be/b4mxGZlaQHY?t=02h14m41s)

[values okay so interesting](https://youtu.be/b4mxGZlaQHY?t=02h14m50s)

[z](https://youtu.be/b4mxGZlaQHY?t=02h14m54s)

[minus](https://youtu.be/b4mxGZlaQHY?t=02h14m55s)

[equals one](https://youtu.be/b4mxGZlaQHY?t=02h14m58s)

[for reasons](https://youtu.be/b4mxGZlaQHY?t=02h14m59s)

[matrix should be identity](https://youtu.be/b4mxGZlaQHY?t=02h15m05s)

[get offset](https://youtu.be/b4mxGZlaQHY?t=02h15m09s)

[well look at that](https://youtu.be/b4mxGZlaQHY?t=02h15m14s)

[because i offset my original item with](https://youtu.be/b4mxGZlaQHY?t=02h15m18s)

[horizontal and vertical alignments](https://youtu.be/b4mxGZlaQHY?t=02h15m22s)

[this thing has](https://youtu.be/b4mxGZlaQHY?t=02h15m27s)

[stuff](https://youtu.be/b4mxGZlaQHY?t=02h15m29s)

[okay so we're gonna just make our life a](https://youtu.be/b4mxGZlaQHY?t=02h15m31s)

[little easier](https://youtu.be/b4mxGZlaQHY?t=02h15m34s)

[we're gonna do this](https://youtu.be/b4mxGZlaQHY?t=02h15m36s)

[okay we may have been fighting this](https://youtu.be/b4mxGZlaQHY?t=02h15m47s)

[whole time](https://youtu.be/b4mxGZlaQHY?t=02h15m49s)

[with it being off because](https://youtu.be/b4mxGZlaQHY?t=02h15m50s)

[a couple of values](https://youtu.be/b4mxGZlaQHY?t=02h15m53s)

[open that off](https://youtu.be/b4mxGZlaQHY?t=02h15m56s)

[uh let's see step out and let's just](https://youtu.be/b4mxGZlaQHY?t=02h15m58s)

[confirm](https://youtu.be/b4mxGZlaQHY?t=02h16m01s)

[jump down to here where we saw it before](https://youtu.be/b4mxGZlaQHY?t=02h16m07s)

[model](https://youtu.be/b4mxGZlaQHY?t=02h16m11s)

[with that that looks significantly more](https://youtu.be/b4mxGZlaQHY?t=02h16m13s)

[accurate](https://youtu.be/b4mxGZlaQHY?t=02h16m15s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h16m17s)

[okay now it's swinging about an exact](https://youtu.be/b4mxGZlaQHY?t=02h16m23s)

[zero axis which is what we expect](https://youtu.be/b4mxGZlaQHY?t=02h16m26s)

[comes out to the front](https://youtu.be/b4mxGZlaQHY?t=02h16m29s)

[jumps i think it's actually because of](https://youtu.be/b4mxGZlaQHY?t=02h16m30s)

[my if logic it's getting an extra 10](https://youtu.be/b4mxGZlaQHY?t=02h16m33s)

[degrees whatever](https://youtu.be/b4mxGZlaQHY?t=02h16m35s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h16m38s)

[so](https://youtu.be/b4mxGZlaQHY?t=02h16m40s)

[let's try this](https://youtu.be/b4mxGZlaQHY?t=02h16m48s)

[because now i think we should be able to](https://youtu.be/b4mxGZlaQHY?t=02h16m51s)

[get this thing to](https://youtu.be/b4mxGZlaQHY?t=02h16m52s)

[offset appropriately](https://youtu.be/b4mxGZlaQHY?t=02h16m54s)

[okay that is definitely not right](https://youtu.be/b4mxGZlaQHY?t=02h17m00s)

[now that we don't have a weird thing so](https://youtu.be/b4mxGZlaQHY?t=02h17m03s)

[center y](https://youtu.be/b4mxGZlaQHY?t=02h17m06s)

[was shifting the center of y rotation](https://youtu.be/b4mxGZlaQHY?t=02h17m10s)

[off of zero and over a hundred](https://youtu.be/b4mxGZlaQHY?t=02h17m12s)

[it might be center x that i actually](https://youtu.be/b4mxGZlaQHY?t=02h17m15s)

[want to change](https://youtu.be/b4mxGZlaQHY?t=02h17m17s)

[because we're going about y](https://youtu.be/b4mxGZlaQHY?t=02h17m20s)

[i would have thought](https://youtu.be/b4mxGZlaQHY?t=02h17m27s)

[d would have been the appropriate one](https://youtu.be/b4mxGZlaQHY?t=02h17m30s)

[but let's](https://youtu.be/b4mxGZlaQHY?t=02h17m31s)

[goal](https://youtu.be/b4mxGZlaQHY?t=02h17m44s)

[about time](https://youtu.be/b4mxGZlaQHY?t=02h17m47s)

[about bloody time](https://youtu.be/b4mxGZlaQHY?t=02h17m49s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h17m52s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h17m56s)

[okay so we're gonna clean some stuff up](https://youtu.be/b4mxGZlaQHY?t=02h17m58s)

[we are going to clean some stuff up so](https://youtu.be/b4mxGZlaQHY?t=02h18m01s)

[we don't need the translate transform](https://youtu.be/b4mxGZlaQHY?t=02h18m03s)

[we ain't gonna use it](https://youtu.be/b4mxGZlaQHY?t=02h18m05s)

[okay don't need those ain't gonna use](https://youtu.be/b4mxGZlaQHY?t=02h18m08s)

[them](https://youtu.be/b4mxGZlaQHY?t=02h18m12s)

[don't need this ain't gonna use it](https://youtu.be/b4mxGZlaQHY?t=02h18m13s)

[which means we don't need](https://youtu.be/b4mxGZlaQHY?t=02h18m17s)

[any of this garbage](https://youtu.be/b4mxGZlaQHY?t=02h18m20s)

[an update 3d has no reference we can use](https://youtu.be/b4mxGZlaQHY?t=02h18m22s)

[any of this garbage](https://youtu.be/b4mxGZlaQHY?t=02h18m25s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h18m28s)

[now i can use any of this i can use any](https://youtu.be/b4mxGZlaQHY?t=02h18m31s)

[of this](https://youtu.be/b4mxGZlaQHY?t=02h18m33s)

[we don't actually want that i don't](https://youtu.be/b4mxGZlaQHY?t=02h18m35s)

[believe](https://youtu.be/b4mxGZlaQHY?t=02h18m38s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h18m40s)

[which means this matrix](https://youtu.be/b4mxGZlaQHY?t=02h18m42s)

[i don't even think we want to get the](https://youtu.be/b4mxGZlaQHY?t=02h18m46s)

[transform off the visual](https://youtu.be/b4mxGZlaQHY?t=02h18m47s)

[yeah i'm pretty sure we don't want any](https://youtu.be/b4mxGZlaQHY?t=02h18m52s)

[of this](https://youtu.be/b4mxGZlaQHY?t=02h18m54s)

[because](https://youtu.be/b4mxGZlaQHY?t=02h18m57s)

[because we're going to be using this](https://youtu.be/b4mxGZlaQHY?t=02h18m58s)

[specifically for flipper and nothing](https://youtu.be/b4mxGZlaQHY?t=02h19m00s)

[else i think we can start making some](https://youtu.be/b4mxGZlaQHY?t=02h19m02s)

[really big sweeping assumptions about](https://youtu.be/b4mxGZlaQHY?t=02h19m04s)

[this](https://youtu.be/b4mxGZlaQHY?t=02h19m06s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h19m07s)

[for example we don't need the pen](https://youtu.be/b4mxGZlaQHY?t=02h19m10s)

[uh we're not gonna ever draw outlines](https://youtu.be/b4mxGZlaQHY?t=02h19m14s)

[those are two things we're just gonna](https://youtu.be/b4mxGZlaQHY?t=02h19m17s)

[scrap right out the gate](https://youtu.be/b4mxGZlaQHY?t=02h19m20s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h19m23s)

[you off](https://youtu.be/b4mxGZlaQHY?t=02h19m25s)

[turn you off](https://youtu.be/b4mxGZlaQHY?t=02h19m27s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h19m33s)

[me](https://youtu.be/b4mxGZlaQHY?t=02h19m50s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=02h19m51s)

[this may not matter because](https://youtu.be/b4mxGZlaQHY?t=02h19m53s)

[visual may not end up](https://youtu.be/b4mxGZlaQHY?t=02h19m56s)

[being inside of here](https://youtu.be/b4mxGZlaQHY?t=02h20m00s)

[pretty sure we don't need this guy](https://youtu.be/b4mxGZlaQHY?t=02h20m03s)

[either because i'm i'm pretty confident](https://youtu.be/b4mxGZlaQHY?t=02h20m04s)

[we don't ever fall into this](https://youtu.be/b4mxGZlaQHY?t=02h20m06s)

[if condition](https://youtu.be/b4mxGZlaQHY?t=02h20m09s)

[the viewport is never going to be no no](https://youtu.be/b4mxGZlaQHY?t=02h20m13s)

[yeah so](https://youtu.be/b4mxGZlaQHY?t=02h20m16s)

[i'm just going to get rid of this all](https://youtu.be/b4mxGZlaQHY?t=02h20m19s)

[together](https://youtu.be/b4mxGZlaQHY?t=02h20m21s)

[make that a little cleaner](https://youtu.be/b4mxGZlaQHY?t=02h20m26s)

[which means this invocation is never](https://youtu.be/b4mxGZlaQHY?t=02h20m29s)

[going to be set](https://youtu.be/b4mxGZlaQHY?t=02h20m33s)

[pixel format we're never setting but](https://youtu.be/b4mxGZlaQHY?t=02h20m35s)

[we're going to leave it for now](https://youtu.be/b4mxGZlaQHY?t=02h20m38s)

[as there may be a useful point to it](https://youtu.be/b4mxGZlaQHY?t=02h20m41s)

[later on](https://youtu.be/b4mxGZlaQHY?t=02h20m43s)

[which means we don't need any of this](https://youtu.be/b4mxGZlaQHY?t=02h20m45s)

[reflection magic](https://youtu.be/b4mxGZlaQHY?t=02h20m46s)

[means we don't need any of this](https://youtu.be/b4mxGZlaQHY?t=02h20m49s)

[under visual](https://youtu.be/b4mxGZlaQHY?t=02h20m55s)

[and remember are you](https://youtu.be/b4mxGZlaQHY?t=02h21m06s)

[[ __ ] map you come with uh you don't](https://youtu.be/b4mxGZlaQHY?t=02h21m12s)

[sure if that came with a disposed method](https://youtu.be/b4mxGZlaQHY?t=02h21m16s)

[on it or not](https://youtu.be/b4mxGZlaQHY?t=02h21m18s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h21m20s)

[i'll do that we're gonna do that](https://youtu.be/b4mxGZlaQHY?t=02h21m22s)

[clean some of that up](https://youtu.be/b4mxGZlaQHY?t=02h21m26s)

[all of you work](https://youtu.be/b4mxGZlaQHY?t=02h21m34s)

[don't need any of that](https://youtu.be/b4mxGZlaQHY?t=02h21m36s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h21m40s)

[i suspect we can](https://youtu.be/b4mxGZlaQHY?t=02h21m44s)

[clean up some more of these things](https://youtu.be/b4mxGZlaQHY?t=02h21m46s)

[include empty visuals false](https://youtu.be/b4mxGZlaQHY?t=02h21m48s)

[don't even want to consider those as](https://youtu.be/b4mxGZlaQHY?t=02h21m51s)

[things](https://youtu.be/b4mxGZlaQHY?t=02h21m53s)

[we're just gonna get rid of that](https://youtu.be/b4mxGZlaQHY?t=02h21m55s)

[visual viewport 3d](https://youtu.be/b4mxGZlaQHY?t=02h21m58s)

[i don't think we care about that](https://youtu.be/b4mxGZlaQHY?t=02h22m06s)

[we're never going to have a visual 3d](https://youtu.be/b4mxGZlaQHY?t=02h22m10s)

[inside of this flipper](https://youtu.be/b4mxGZlaQHY?t=02h22m12s)

[be a little unusual](https://youtu.be/b4mxGZlaQHY?t=02h22m14s)

[that can be static now](https://youtu.be/b4mxGZlaQHY?t=02h22m18s)

[let's make sure we haven't broken](https://youtu.be/b4mxGZlaQHY?t=02h22m22s)

[anything yet](https://youtu.be/b4mxGZlaQHY?t=02h22m24s)

[and we'll keep going because there's](https://youtu.be/b4mxGZlaQHY?t=02h22m27s)

[probably more we can delete](https://youtu.be/b4mxGZlaQHY?t=02h22m28s)

[boom he broke something](https://youtu.be/b4mxGZlaQHY?t=02h22m34s)

[okay so let's come in here and just](https://youtu.be/b4mxGZlaQHY?t=02h22m48s)

[see what it was we broke](https://youtu.be/b4mxGZlaQHY?t=02h22m50s)

[i might have to start undoing things](https://youtu.be/b4mxGZlaQHY?t=02h22m56s)

[until i find what it what it was](https://youtu.be/b4mxGZlaQHY?t=02h22m59s)

[okay so come in here](https://youtu.be/b4mxGZlaQHY?t=02h23m02s)

[[Music]](https://youtu.be/b4mxGZlaQHY?t=02h23m03s)

[visual should have us](https://youtu.be/b4mxGZlaQHY?t=02h23m06s)

[should all line up with what we saw](https://youtu.be/b4mxGZlaQHY?t=02h23m17s)

[before](https://youtu.be/b4mxGZlaQHY?t=02h23m19s)

[good](https://youtu.be/b4mxGZlaQHY?t=02h23m20s)

[children count](https://youtu.be/b4mxGZlaQHY?t=02h23m31s)

[might need to hand a hole or let that](https://youtu.be/b4mxGZlaQHY?t=02h23m34s)

[stay there](https://youtu.be/b4mxGZlaQHY?t=02h23m37s)

[and then this really needs to be bound](https://youtu.be/b4mxGZlaQHY?t=02h23m50s)

[size x divided by two](https://youtu.be/b4mxGZlaQHY?t=02h23m52s)

[not sure where the issue is that all](https://youtu.be/b4mxGZlaQHY?t=02h24m27s)

[looked like it did what i expected](https://youtu.be/b4mxGZlaQHY?t=02h24m31s)

[we're gonna just take a quick](https://youtu.be/b4mxGZlaQHY?t=02h24m34s)

[investigative look at this](https://youtu.be/b4mxGZlaQHY?t=02h24m35s)

[guy okay scroll viewer grid](https://youtu.be/b4mxGZlaQHY?t=02h24m40s)

[okay that guy](https://youtu.be/b4mxGZlaQHY?t=02h24m46s)

[that is all as expected](https://youtu.be/b4mxGZlaQHY?t=02h25m01s)

[what i do wrong in here now](https://youtu.be/b4mxGZlaQHY?t=02h25m05s)

[start undoing things until we get back](https://youtu.be/b4mxGZlaQHY?t=02h25m26s)

[to where we were and then we will go a](https://youtu.be/b4mxGZlaQHY?t=02h25m28s)

[little slower](https://youtu.be/b4mxGZlaQHY?t=02h25m30s)

[once i see my mistake as i am undoing](https://youtu.be/b4mxGZlaQHY?t=02h25m33s)

[things](https://youtu.be/b4mxGZlaQHY?t=02h25m36s)

[i thought everything we did was pretty](https://youtu.be/b4mxGZlaQHY?t=02h25m39s)

[safe](https://youtu.be/b4mxGZlaQHY?t=02h25m41s)

[right there and see if that brings us](https://youtu.be/b4mxGZlaQHY?t=02h25m57s)

[back to working](https://youtu.be/b4mxGZlaQHY?t=02h25m59s)

[went off](https://youtu.be/b4mxGZlaQHY?t=02h26m07s)

[does](https://youtu.be/b4mxGZlaQHY?t=02h26m11s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h26m13s)

[let's come back through here and i'll](https://youtu.be/b4mxGZlaQHY?t=02h26m21s)

[just clean stuff as i go](https://youtu.be/b4mxGZlaQHY?t=02h26m22s)

[be a little more methodical](https://youtu.be/b4mxGZlaQHY?t=02h26m25s)

[visual is a border](https://youtu.be/b4mxGZlaQHY?t=02h26m31s)

[i guess we can leave that there include](https://youtu.be/b4mxGZlaQHY?t=02h26m34s)

[empty visuals we're never going to do](https://youtu.be/b4mxGZlaQHY?t=02h26m36s)

[this](https://youtu.be/b4mxGZlaQHY?t=02h26m38s)

[all works](https://youtu.be/b4mxGZlaQHY?t=02h26m46s)

[hang on](https://youtu.be/b4mxGZlaQHY?t=02h26m58s)

[when did we get down to](https://youtu.be/b4mxGZlaQHY?t=02h27m00s)

[the brush from visual](https://youtu.be/b4mxGZlaQHY?t=02h27m04s)

[i want to catch it here because this is](https://youtu.be/b4mxGZlaQHY?t=02h27m07s)

[where i thought i could blow away](https://youtu.be/b4mxGZlaQHY?t=02h27m09s)

[this entire if condition](https://youtu.be/b4mxGZlaQHY?t=02h27m12s)

[oh if viewport is](https://youtu.be/b4mxGZlaQHY?t=02h27m25s)

[got it](https://youtu.be/b4mxGZlaQHY?t=02h27m28s)

[got it i misread this](https://youtu.be/b4mxGZlaQHY?t=02h27m39s)

[condition](https://youtu.be/b4mxGZlaQHY?t=02h27m41s)

[got it so that deletion is almost surely](https://youtu.be/b4mxGZlaQHY?t=02h27m44s)

[what did it to me](https://youtu.be/b4mxGZlaQHY?t=02h27m47s)

[okay and that does look](https://youtu.be/b4mxGZlaQHY?t=02h27m49s)

[more appropriate](https://youtu.be/b4mxGZlaQHY?t=02h27m52s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h28m01s)

[okay so that'll clean that up](https://youtu.be/b4mxGZlaQHY?t=02h28m06s)

[don't want any of that i don't want to](https://youtu.be/b4mxGZlaQHY?t=02h28m10s)

[delete it just yet](https://youtu.be/b4mxGZlaQHY?t=02h28m12s)

[these scale i](https://youtu.be/b4mxGZlaQHY?t=02h28m15s)

[think i'll leave it but i don't think](https://youtu.be/b4mxGZlaQHY?t=02h28m17s)

[we're going to use it](https://youtu.be/b4mxGZlaQHY?t=02h28m18s)

[translate transform is now dead axis](https://youtu.be/b4mxGZlaQHY?t=02h28m21s)

[transform goes away](https://youtu.be/b4mxGZlaQHY?t=02h28m24s)

[x-axis goes away](https://youtu.be/b4mxGZlaQHY?t=02h28m27s)

[that goes away](https://youtu.be/b4mxGZlaQHY?t=02h28m31s)

[i need you to match the rest of the](https://youtu.be/b4mxGZlaQHY?t=02h28m37s)

[other children](https://youtu.be/b4mxGZlaQHY?t=02h28m39s)

[thank you](https://youtu.be/b4mxGZlaQHY?t=02h28m42s)

[you created in the constructor anyway](https://youtu.be/b4mxGZlaQHY?t=02h28m44s)

[save the view up](https://youtu.be/b4mxGZlaQHY?t=02h28m52s)

[view up](https://youtu.be/b4mxGZlaQHY?t=02h28m55s)

[axis rotation](https://youtu.be/b4mxGZlaQHY?t=02h28m56s)

[to be able to set you now](https://youtu.be/b4mxGZlaQHY?t=02h28m59s)

[because this will have static access](https://youtu.be/b4mxGZlaQHY?t=02h29m04s)

[that should work](https://youtu.be/b4mxGZlaQHY?t=02h29m08s)

[that](https://youtu.be/b4mxGZlaQHY?t=02h29m12s)

[hush](https://youtu.be/b4mxGZlaQHY?t=02h29m13s)

[hush now](https://youtu.be/b4mxGZlaQHY?t=02h29m14s)

[i don't need to set that anymore](https://youtu.be/b4mxGZlaQHY?t=02h29m19s)

[do need to set u](https://youtu.be/b4mxGZlaQHY?t=02h29m24s)

[d what is this value used for](https://youtu.be/b4mxGZlaQHY?t=02h29m30s)

[this value used anywhere](https://youtu.be/b4mxGZlaQHY?t=02h29m36s)

[no it's not used anywhere so we're just](https://youtu.be/b4mxGZlaQHY?t=02h29m49s)

[gonna get rid of it](https://youtu.be/b4mxGZlaQHY?t=02h29m51s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h29m53s)

[actually let's leave this is z for now](https://youtu.be/b4mxGZlaQHY?t=02h30m15s)

[we're gonna just declare it up front](https://youtu.be/b4mxGZlaQHY?t=02h30m18s)

[austin this one's a double doesn't it](https://youtu.be/b4mxGZlaQHY?t=02h30m21s)

[yeah](https://youtu.be/b4mxGZlaQHY?t=02h30m26s)

[double](https://youtu.be/b4mxGZlaQHY?t=02h30m29s)

[he gets](https://youtu.be/b4mxGZlaQHY?t=02h30m31s)

[there](https://youtu.be/b4mxGZlaQHY?t=02h30m32s)

[that way the rest of this code can keep](https://youtu.be/b4mxGZlaQHY?t=02h30m34s)

[working but i don't have to](https://youtu.be/b4mxGZlaQHY?t=02h30m35s)

[think about it too hard](https://youtu.be/b4mxGZlaQHY?t=02h30m38s)

[oh interesting so i can't make you a](https://youtu.be/b4mxGZlaQHY?t=02h30m43s)

[const](https://youtu.be/b4mxGZlaQHY?t=02h30m44s)

[oh](https://youtu.be/b4mxGZlaQHY?t=02h30m52s)

[interesting](https://youtu.be/b4mxGZlaQHY?t=02h30m53s)

[that's the point of it for recursion](https://youtu.be/b4mxGZlaQHY?t=02h30m55s)

[okay we'll put it back](https://youtu.be/b4mxGZlaQHY?t=02h31m00s)

[put it back it's a weird api but it's](https://youtu.be/b4mxGZlaQHY?t=02h31m02s)

[private so i don't care](https://youtu.be/b4mxGZlaQHY?t=02h31m05s)

[that'll work](https://youtu.be/b4mxGZlaQHY?t=02h31m13s)

[gives me that that gives me that](https://youtu.be/b4mxGZlaQHY?t=02h31m16s)

[gives me that](https://youtu.be/b4mxGZlaQHY?t=02h31m20s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h31m24s)

[so we're gonna come over here and we're](https://youtu.be/b4mxGZlaQHY?t=02h31m27s)

[gonna change](https://youtu.be/b4mxGZlaQHY?t=02h31m28s)

[we're gonna change some stuff up](https://youtu.be/b4mxGZlaQHY?t=02h31m30s)

[um let's see](https://youtu.be/b4mxGZlaQHY?t=02h31m34s)

[front](https://youtu.be/b4mxGZlaQHY?t=02h31m37s)

[back](https://youtu.be/b4mxGZlaQHY?t=02h31m41s)

[and make you](https://youtu.be/b4mxGZlaQHY?t=02h31m42s)

[blue](https://youtu.be/b4mxGZlaQHY?t=02h31m43s)

[okay and then we're going to do](https://youtu.be/b4mxGZlaQHY?t=02h31m45s)

[red](https://youtu.be/b4mxGZlaQHY?t=02h31m48s)

[column definitions](https://youtu.be/b4mxGZlaQHY?t=02h31m49s)

[on definition ding](https://youtu.be/b4mxGZlaQHY?t=02h31m53s)

[okay and then](https://youtu.be/b4mxGZlaQHY?t=02h31m56s)

[grid column](https://youtu.be/b4mxGZlaQHY?t=02h32m00s)

[one and then when we add in the spinny](https://youtu.be/b4mxGZlaQHY?t=02h32m01s)

[dude](https://youtu.be/b4mxGZlaQHY?t=02h32m04s)

[we're gonna just make him be](https://youtu.be/b4mxGZlaQHY?t=02h32m06s)

[uh](https://youtu.be/b4mxGZlaQHY?t=02h32m10s)

[that column span](https://youtu.be/b4mxGZlaQHY?t=02h32m13s)

[two](https://youtu.be/b4mxGZlaQHY?t=02h32m18s)

[would be front](https://youtu.be/b4mxGZlaQHY?t=02h32m21s)

[that in for now um](https://youtu.be/b4mxGZlaQHY?t=02h32m32s)

[i'm not gonna make you do anything okay](https://youtu.be/b4mxGZlaQHY?t=02h32m38s)

[so](https://youtu.be/b4mxGZlaQHY?t=02h32m40s)

[storyboard and can be loaded at will](https://youtu.be/b4mxGZlaQHY?t=02h32m49s)

[now we're gonna make this thing start](https://youtu.be/b4mxGZlaQHY?t=02h32m54s)

[working nice for us](https://youtu.be/b4mxGZlaQHY?t=02h32m56s)

[um i think what i'm going to do is get](https://youtu.be/b4mxGZlaQHY?t=02h32m58s)

[rid of](https://youtu.be/b4mxGZlaQHY?t=02h33m00s)

[already got rid of all my](https://youtu.be/b4mxGZlaQHY?t=02h33m02s)

[already got rid of all my text boxes so](https://youtu.be/b4mxGZlaQHY?t=02h33m10s)

[that's fine](https://youtu.be/b4mxGZlaQHY?t=02h33m11s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h33m14s)

[let's get this thing working for front](https://youtu.be/b4mxGZlaQHY?t=02h33m16s)

[and back content](https://youtu.be/b4mxGZlaQHY?t=02h33m18s)

[because i would like to have this thing](https://youtu.be/b4mxGZlaQHY?t=02h33m20s)

[work](https://youtu.be/b4mxGZlaQHY?t=02h33m22s)

[for both](https://youtu.be/b4mxGZlaQHY?t=02h33m23s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h33m26s)

[so that it's clear when it's spinning](https://youtu.be/b4mxGZlaQHY?t=02h33m27s)

[what it's](https://youtu.be/b4mxGZlaQHY?t=02h33m29s)

[what it's wrapping and i think](https://youtu.be/b4mxGZlaQHY?t=02h33m31s)

[front](https://youtu.be/b4mxGZlaQHY?t=02h33m36s)

[visual](https://youtu.be/b4mxGZlaQHY?t=02h33m38s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h33m42s)

[i think we can do that](https://youtu.be/b4mxGZlaQHY?t=02h33m43s)

[we come down here and we go with back](https://youtu.be/b4mxGZlaQHY?t=02h33m45s)

[okay so we've got both of those](https://youtu.be/b4mxGZlaQHY?t=02h33m48s)

[now i'm not](https://youtu.be/b4mxGZlaQHY?t=02h33m55s)

[i think what i need to do is pass both](https://youtu.be/b4mxGZlaQHY?t=02h34m00s)

[of these in here](https://youtu.be/b4mxGZlaQHY?t=02h34m02s)

[because i think this back material is](https://youtu.be/b4mxGZlaQHY?t=02h34m08s)

[what i actually want it to be](https://youtu.be/b4mxGZlaQHY?t=02h34m10s)

[we're going to do](https://youtu.be/b4mxGZlaQHY?t=02h34m12s)

[front visual](https://youtu.be/b4mxGZlaQHY?t=02h34m14s)

[back](https://youtu.be/b4mxGZlaQHY?t=02h34m19s)

[visual](https://youtu.be/b4mxGZlaQHY?t=02h34m21s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h34m24s)

[make you static which is cool](https://youtu.be/b4mxGZlaQHY?t=02h34m29s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h34m33s)

[hold on hold on this thing this might be](https://youtu.be/b4mxGZlaQHY?t=02h34m47s)

[at the wrong level](https://youtu.be/b4mxGZlaQHY?t=02h34m49s)

[because how does this recursion then](https://youtu.be/b4mxGZlaQHY?t=02h34m54s)

[work](https://youtu.be/b4mxGZlaQHY?t=02h34m56s)

[so if there is](https://youtu.be/b4mxGZlaQHY?t=02h35m02s)

[this would normally just do a plain](https://youtu.be/b4mxGZlaQHY?t=02h35m07s)

[model but if it contains extra](https://youtu.be/b4mxGZlaQHY?t=02h35m08s)

[children](https://youtu.be/b4mxGZlaQHY?t=02h35m10s)

[it's going to add these children to a](https://youtu.be/b4mxGZlaQHY?t=02h35m12s)

[group](https://youtu.be/b4mxGZlaQHY?t=02h35m15s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h35m20s)

[ha](https://youtu.be/b4mxGZlaQHY?t=02h35m32s)

[and so it's going to change up the](https://youtu.be/b4mxGZlaQHY?t=02h35m38s)

[return type from](https://youtu.be/b4mxGZlaQHY?t=02h35m40s)

[either be a model 3d group](https://youtu.be/b4mxGZlaQHY?t=02h35m43s)

[i'm wondering if i should just wrap this](https://youtu.be/b4mxGZlaQHY?t=02h35m48s)

[because this is going to come back as](https://youtu.be/b4mxGZlaQHY?t=02h35m55s)

[either a group](https://youtu.be/b4mxGZlaQHY?t=02h35m59s)

[and diffuse material](https://youtu.be/b4mxGZlaQHY?t=02h36m11s)

[so this is going to be a](https://youtu.be/b4mxGZlaQHY?t=02h36m27s)

[the 3d model is effectively just a plane](https://youtu.be/b4mxGZlaQHY?t=02h36m29s)

[with the material being the](https://youtu.be/b4mxGZlaQHY?t=02h36m34s)

[rendered image over the top](https://youtu.be/b4mxGZlaQHY?t=02h36m36s)

[but when you go to a group](https://youtu.be/b4mxGZlaQHY?t=02h36m40s)

[it's going to end up doing the same](https://youtu.be/b4mxGZlaQHY?t=02h36m44s)

[thing](https://youtu.be/b4mxGZlaQHY?t=02h36m46s)

[and adding these things in](https://youtu.be/b4mxGZlaQHY?t=02h36m48s)

[okay](https://youtu.be/b4mxGZlaQHY?t=02h36m54s)

[i think what i actually want to do](https://youtu.be/b4mxGZlaQHY?t=02h37m02s)

[is change this](https://youtu.be/b4mxGZlaQHY?t=02h37m06s)

[so that i end up with](https://youtu.be/b4mxGZlaQHY?t=02h37m08s)

[two of these](https://youtu.be/b4mxGZlaQHY?t=02h37m12s)

[so i don't want this](https://youtu.be/b4mxGZlaQHY?t=02h37m20s)

[i don't want this to be](https://youtu.be/b4mxGZlaQHY?t=02h37m24s)

[aching into](https://youtu.be/b4mxGZlaQHY?t=02h37m27s)

[i wanted to only take in the one](https://youtu.be/b4mxGZlaQHY?t=02h37m29s)

[and then up here](https://youtu.be/b4mxGZlaQHY?t=02h37m33s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h37m37s)

[front](https://youtu.be/b4mxGZlaQHY?t=02h37m40s)

[bottle](https://youtu.be/b4mxGZlaQHY?t=02h37m42s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h37m44s)

[and then i'm going to want to do](https://youtu.be/b4mxGZlaQHY?t=02h37m51s)

[something with](https://youtu.be/b4mxGZlaQHY?t=02h37m53s)

[back model](https://youtu.be/b4mxGZlaQHY?t=02h37m56s)

[for now let's assume these things are](https://youtu.be/b4mxGZlaQHY?t=02h38m00s)

[the same size](https://youtu.be/b4mxGZlaQHY?t=02h38m01s)

[um so this would be](https://youtu.be/b4mxGZlaQHY?t=02h38m03s)

[back model](https://youtu.be/b4mxGZlaQHY?t=02h38m06s)

[back](https://youtu.be/b4mxGZlaQHY?t=02h38m08s)

[uh and z should get zero again](https://youtu.be/b4mxGZlaQHY?t=02h38m13s)

[layer those things through](https://youtu.be/b4mxGZlaQHY?t=02h38m18s)

[okay so](https://youtu.be/b4mxGZlaQHY?t=02h38m21s)

[which is all good i think](https://youtu.be/b4mxGZlaQHY?t=02h38m28s)

[we may end up wanting to hard code the z](https://youtu.be/b4mxGZlaQHY?t=02h38m32s)

[i'm wondering if that initial one is the](https://youtu.be/b4mxGZlaQHY?t=02h38m34s)

[separation that you see in](https://youtu.be/b4mxGZlaQHY?t=02h38m36s)

[uh snoops](https://youtu.be/b4mxGZlaQHY?t=02h38m38s)

[is fine](https://youtu.be/b4mxGZlaQHY?t=02h38m44s)

[okay so how do i get](https://youtu.be/b4mxGZlaQHY?t=02h38m46s)

[i guess more importantly](https://youtu.be/b4mxGZlaQHY?t=02h38m53s)

[look at point and see](https://youtu.be/b4mxGZlaQHY?t=02h39m01s)

[scale](https://youtu.be/b4mxGZlaQHY?t=02h39m04s)

[kind of wondering if this really needs](https://youtu.be/b4mxGZlaQHY?t=02h39m06s)

[to be set anymore](https://youtu.be/b4mxGZlaQHY?t=02h39m07s)

[let's see what happens if we don't set](https://youtu.be/b4mxGZlaQHY?t=02h39m12s)

[it](https://youtu.be/b4mxGZlaQHY?t=02h39m13s)

[yeah i'm thinking we don't need the uh](https://youtu.be/b4mxGZlaQHY?t=02h39m26s)

[i think we don't need the z](https://youtu.be/b4mxGZlaQHY?t=02h39m30s)

[thinking we don't need](https://youtu.be/b4mxGZlaQHY?t=02h39m40s)

[it um](https://youtu.be/b4mxGZlaQHY?t=02h39m42s)

[um and i'm actually wondering if i](https://youtu.be/b4mxGZlaQHY?t=02h39m53s)

[should change my rotation a bit](https://youtu.be/b4mxGZlaQHY?t=02h39m55s)

[um](https://youtu.be/b4mxGZlaQHY?t=02h40m02s)

[let's](https://youtu.be/b4mxGZlaQHY?t=02h40m11s)

[just let it spin all the way around](https://youtu.be/b4mxGZlaQHY?t=02h40m28s)

[because i want to i do want to see the](https://youtu.be/b4mxGZlaQHY?t=02h40m31s)

[back rather than just doing the](https://youtu.be/b4mxGZlaQHY?t=02h40m33s)

[i can't tell what the front and the back](https://youtu.be/b4mxGZlaQHY?t=02h40m51s)

[is yet so that we'll](https://youtu.be/b4mxGZlaQHY?t=02h40m53s)

[see if that ends up working um okay](https://youtu.be/b4mxGZlaQHY?t=02h40m55s)

[um and actually while we're in here](https://youtu.be/b4mxGZlaQHY?t=02h41m01s)

[let's make our life a little bit easier](https://youtu.be/b4mxGZlaQHY?t=02h41m02s)

[and eliminate that button so loaded plus](https://youtu.be/b4mxGZlaQHY?t=02h41m04s)

[equals boom](https://youtu.be/b4mxGZlaQHY?t=02h41m06s)

[this is gonna do the work that was](https://youtu.be/b4mxGZlaQHY?t=02h41m09s)

[previously in the button click so that i](https://youtu.be/b4mxGZlaQHY?t=02h41m10s)

[don't think too hard](https://youtu.be/b4mxGZlaQHY?t=02h41m12s)

[stop having](https://youtu.be/b4mxGZlaQHY?t=02h41m18s)

[buttons](https://youtu.be/b4mxGZlaQHY?t=02h41m20s)

[you](https://youtu.be/b4mxGZlaQHY?t=02h41m33s)

