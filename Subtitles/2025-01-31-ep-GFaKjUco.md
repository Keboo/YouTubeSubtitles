[YouTube Video](https://youtu.be/ep-GFaKjUco)



[hello everyone welcome back uh tonight](https://youtu.be/ep-GFaKjUco?t=00h00m01s)

[we're going to kind of do a little bit](https://youtu.be/ep-GFaKjUco?t=00h00m04s)

[of the same a little bit of different](https://youtu.be/ep-GFaKjUco?t=00h00m06s)

[and carry on our merry way and see where](https://youtu.be/ep-GFaKjUco?t=00h00m07s)

[things go uh going to kick things off](https://youtu.be/ep-GFaKjUco?t=00h00m10s)

[with a little material design work](https://youtu.be/ep-GFaKjUco?t=00h00m13s)

[there's an open PR that I want to mer](https://youtu.be/ep-GFaKjUco?t=00h00m14s)

[merge I the 53 releas is slowly building](https://youtu.be/ep-GFaKjUco?t=00h00m16s)

[up stuff in it um I've been kind of](https://youtu.be/ep-GFaKjUco?t=00h00m19s)

[focusing my efforts elsewhere so it's](https://youtu.be/ep-GFaKjUco?t=00h00m21s)

[not like the Project's going away and I](https://youtu.be/ep-GFaKjUco?t=00h00m24s)

[don't want it to stagnant um but I've](https://youtu.be/ep-GFaKjUco?t=00h00m26s)

[been building other things which is what](https://youtu.be/ep-GFaKjUco?t=00h00m28s)

[we're going to look at as well so more](https://youtu.be/ep-GFaKjUco?t=00h00m30s)

[velop pack tonight and please don't](https://youtu.be/ep-GFaKjUco?t=00h00m33s)

[laugh at me I am not much of a react](https://youtu.be/ep-GFaKjUco?t=00h00m35s)

[developer but I'm learning so we'll have](https://youtu.be/ep-GFaKjUco?t=00h00m37s)

[fun we'll have fun that is that is the](https://youtu.be/ep-GFaKjUco?t=00h00m40s)

[aim of the game okay so this PR here for](https://youtu.be/ep-GFaKjUco?t=00h00m42s)

[anyone who wants to follow along at](https://youtu.be/ep-GFaKjUco?t=00h00m46s)

[home if I can remember how](https://youtu.be/ep-GFaKjUco?t=00h00m48s)

[to copy paste there we go okay so this](https://youtu.be/ep-GFaKjUco?t=00h00m51s)

[is a bug here that that came](https://youtu.be/ep-GFaKjUco?t=00h00m54s)

[in um so this this one here is numeric](https://youtu.be/ep-GFaKjUco?t=00h00m57s)

[up down does not update with values](https://youtu.be/ep-GFaKjUco?t=00h01m02s)

[outside of the range right so](https://youtu.be/ep-GFaKjUco?t=00h01m04s)

[um this guy here is kind of interesting](https://youtu.be/ep-GFaKjUco?t=00h01m08s)

[we me pull this up and play around with](https://youtu.be/ep-GFaKjUco?t=00h01m10s)

[it because I want to I want to test it](https://youtu.be/ep-GFaKjUco?t=00h01m12s)

[this is an interesting one and there's](https://youtu.be/ep-GFaKjUco?t=00h01m14s)

[kind of some precedence already set like](https://youtu.be/ep-GFaKjUco?t=00h01m16s)

[in WPF if you buying the text value of a](https://youtu.be/ep-GFaKjUco?t=00h01m19s)

[text box to say an INT or a double you](https://youtu.be/ep-GFaKjUco?t=00h01m22s)

[get a little bit of this it's not quite](https://youtu.be/ep-GFaKjUco?t=00h01m25s)

[the same um but there is is this concept](https://youtu.be/ep-GFaKjUco?t=00h01m27s)

[of having a box that you type into and](https://youtu.be/ep-GFaKjUco?t=00h01m31s)

[the value entered being uh invalid or](https://youtu.be/ep-GFaKjUco?t=00h01m36s)

[out of range in this case right so in](https://youtu.be/ep-GFaKjUco?t=00h01m39s)

[this case here minimum of -2 a half uh](https://youtu.be/ep-GFaKjUco?t=00h01m43s)

[maximum positive two and a half value of](https://youtu.be/ep-GFaKjUco?t=00h01m47s)

[zero right so first one value zero input](https://youtu.be/ep-GFaKjUco?t=00h01m49s)

[20 which is way above the maximum right](https://youtu.be/ep-GFaKjUco?t=00h01m52s)

[lost uh lost focus and then I appreciate](https://youtu.be/ep-GFaKjUco?t=00h01m55s)

[the uh sand Fox 922 putting putting this](https://youtu.be/ep-GFaKjUco?t=00h01m59s)

[in so the view shows two and a half and](https://youtu.be/ep-GFaKjUco?t=00h02m02s)

[the value shows two and a half okay](https://youtu.be/ep-GFaKjUco?t=00h02m05s)

[great that's kind of what I would](https://youtu.be/ep-GFaKjUco?t=00h02m07s)

[expect uh](https://youtu.be/ep-GFaKjUco?t=00h02m09s)

[value uh two and a half input 30 lost](https://youtu.be/ep-GFaKjUco?t=00h02m11s)

[Focus view shows 30 value shows two and](https://youtu.be/ep-GFaKjUco?t=00h02m16s)

[a half this one kind of surprises me um](https://youtu.be/ep-GFaKjUco?t=00h02m19s)

[I I'm not clear why one of these would](https://youtu.be/ep-GFaKjUco?t=00h02m23s)

[do it especially with the trigger being](https://youtu.be/ep-GFaKjUco?t=00h02m27s)

[lost Focus this appears to be going from](https://youtu.be/ep-GFaKjUco?t=00h02m28s)

[a default value of Zero from a](https://youtu.be/ep-GFaKjUco?t=00h02m31s)

[non-default value is the only key](https://youtu.be/ep-GFaKjUco?t=00h02m33s)

[difference and so that that one's a](https://youtu.be/ep-GFaKjUco?t=00h02m34s)

[little more interesting to me and I](https://youtu.be/ep-GFaKjUco?t=00h02m36s)

[wonder if there's something else subtly](https://youtu.be/ep-GFaKjUco?t=00h02m38s)

[at play](https://youtu.be/ep-GFaKjUco?t=00h02m39s)

[here um this one here value is two and a](https://youtu.be/ep-GFaKjUco?t=00h02m40s)

[half enter 30 increase button click the](https://youtu.be/ep-GFaKjUco?t=00h02m44s)

[view still shows 30 the value still](https://youtu.be/ep-GFaKjUco?t=00h02m49s)

[shows two and a half](https://youtu.be/ep-GFaKjUco?t=00h02m52s)

[um yeah and so this is here uh the Set](https://youtu.be/ep-GFaKjUco?t=00h02m56s)

[current value is not clamped on minimum](https://youtu.be/ep-GFaKjUco?t=00h03m00s)

[maximum that's probably a reasonable](https://youtu.be/ep-GFaKjUco?t=00h03m02s)

[guess in terms of this um Corvin uh took](https://youtu.be/ep-GFaKjUco?t=00h03m05s)

[a run at](https://youtu.be/ep-GFaKjUco?t=00h03m09s)

[it uh let's see set the text of the](https://youtu.be/ep-GFaKjUco?t=00h03m11s)

[internal text box to the current value](https://youtu.be/ep-GFaKjUco?t=00h03m14s)

[one uh regardless whether it can be](https://youtu.be/ep-GFaKjUco?t=00h03m16s)

[parsed or not I think that's probably](https://youtu.be/ep-GFaKjUco?t=00h03m19s)

[fair but I think we're going to look at](https://youtu.be/ep-GFaKjUco?t=00h03m23s)

[exactly um how this works and yeah and](https://youtu.be/ep-GFaKjUco?t=00h03m27s)

[then entering non-numerical value so](https://youtu.be/ep-GFaKjUco?t=00h03m29s)

[this is a numeric up down control not](https://youtu.be/ep-GFaKjUco?t=00h03m32s)

[shockingly it requires a numeric value](https://youtu.be/ep-GFaKjUco?t=00h03m34s)

[uh otherwise it wouldn't be a numeric up](https://youtu.be/ep-GFaKjUco?t=00h03m36s)

[down](https://youtu.be/ep-GFaKjUco?t=00h03m38s)

[control um and I think this I I think](https://youtu.be/ep-GFaKjUco?t=00h03m39s)

[reverting to the previous value and not](https://youtu.be/ep-GFaKjUco?t=00h03m42s)

[necessarily to zero is correct that's](https://youtu.be/ep-GFaKjUco?t=00h03m44s)

[kind of normal like this is one of those](https://youtu.be/ep-GFaKjUco?t=00h03m46s)

[cases where I I can see people arguing](https://youtu.be/ep-GFaKjUco?t=00h03m49s)

[for one or the other like if somebody](https://youtu.be/ep-GFaKjUco?t=00h03m51s)

[erases it and types an ABC right that's](https://youtu.be/ep-GFaKjUco?t=00h03m52s)

[not a valid value so it's like H yeah I](https://youtu.be/ep-GFaKjUco?t=00h03m55s)

[I think going back to the regular value](https://youtu.be/ep-GFaKjUco?t=00h03m59s)

[is rather than zero is probably correct](https://youtu.be/ep-GFaKjUco?t=00h04m01s)

[so uh that's not where we want to go we](https://youtu.be/ep-GFaKjUco?t=00h04m03s)

[want to go](https://youtu.be/ep-GFaKjUco?t=00h04m06s)

[here okay and this is one where we may](https://youtu.be/ep-GFaKjUco?t=00h04m08s)

[pause for just a moment and go and write](https://youtu.be/ep-GFaKjUco?t=00h04m11s)

[because we've got some UI tests around](https://youtu.be/ep-GFaKjUco?t=00h04m14s)

[this and this feels like something where](https://youtu.be/ep-GFaKjUco?t=00h04m16s)

[I want to write some UI tests for it](https://youtu.be/ep-GFaKjUco?t=00h04m17s)

[just just because just because um let's](https://youtu.be/ep-GFaKjUco?t=00h04m19s)

[see so this one here uh triar is the so](https://youtu.be/ep-GFaKjUco?t=00h04m23s)

[previously we were triar the value](https://youtu.be/ep-GFaKjUco?t=00h04m28s)

[getting it and then we res Set current](https://youtu.be/ep-GFaKjUco?t=00h04m31s)

[value but it wasn't being bounded and so](https://youtu.be/ep-GFaKjUco?t=00h04m32s)

[this is calling coer numeric value and I](https://youtu.be/ep-GFaKjUco?t=00h04m35s)

[might need to go and look at where this](https://youtu.be/ep-GFaKjUco?t=00h04m37s)

[function is let's just check out this](https://youtu.be/ep-GFaKjUco?t=00h04m40s)

[Branch real quick okay so material](https://youtu.be/ep-GFaKjUco?t=00h04m41s)

[design this one](https://youtu.be/ep-GFaKjUco?t=00h04m44s)

[here](https://youtu.be/ep-GFaKjUco?t=00h04m46s)

[uh check](https://youtu.be/ep-GFaKjUco?t=00h04m48s)

[out and](https://youtu.be/ep-GFaKjUco?t=00h04m51s)

[then uh for people who haven't seen it](https://youtu.be/ep-GFaKjUco?t=00h04m54s)

[I've got the new fancy hotkey bound up](https://youtu.be/ep-GFaKjUco?t=00h04m56s)

[so](https://youtu.be/ep-GFaKjUco?t=00h04m59s)

[uh open an external editor or I'm sorry](https://youtu.be/ep-GFaKjUco?t=00h05m00s)

[open repo and external editor for my](https://youtu.be/ep-GFaKjUco?t=00h05m03s)

[preferences so if we](https://youtu.be/ep-GFaKjUco?t=00h05m06s)

[go no uh where is](https://youtu.be/ep-GFaKjUco?t=00h05m08s)

[the where is the fancy tool external](https://youtu.be/ep-GFaKjUco?t=00h05m11s)

[tools so I've got external tool pointed](https://youtu.be/ep-GFaKjUco?t=00h05m15s)

[at visual studio so that I can just go](https://youtu.be/ep-GFaKjUco?t=00h05m17s)

[control shift e and it pops it open it](https://youtu.be/ep-GFaKjUco?t=00h05m20s)

[does because it's feeding in the the](https://youtu.be/ep-GFaKjUco?t=00h05m22s)

[repo directory rather than like a](https://youtu.be/ep-GFaKjUco?t=00h05m25s)

[solution file or similar um it does get](https://youtu.be/ep-GFaKjUco?t=00h05m27s)

[you into this view but then I can just](https://youtu.be/ep-GFaKjUco?t=00h05m30s)

[double click the solution or the project](https://youtu.be/ep-GFaKjUco?t=00h05m31s)

[or whatever I want and poof I'm in so](https://youtu.be/ep-GFaKjUco?t=00h05m33s)

[it's not perfect but it's getting closer](https://youtu.be/ep-GFaKjUco?t=00h05m35s)

[getting closer okay so let's go here](https://youtu.be/ep-GFaKjUco?t=00h05m38s)

[we're going to change our demo to the](https://youtu.be/ep-GFaKjUco?t=00h05m41s)

[regular](https://youtu.be/ep-GFaKjUco?t=00h05m44s)

[one and then this has the fix in place](https://youtu.be/ep-GFaKjUco?t=00h05m46s)

[so let's just go to numeric up](https://youtu.be/ep-GFaKjUco?t=00h05m50s)

[down yeah that one okay and specifically](https://youtu.be/ep-GFaKjUco?t=00h05m54s)

[what are we talking about here we're](https://youtu.be/ep-GFaKjUco?t=00h06m00s)

[talking line](https://youtu.be/ep-GFaKjUco?t=00h06m01s)

[2 e](https://youtu.be/ep-GFaKjUco?t=00h06m03s)

[216 okay I'm in the wrong](https://youtu.be/ep-GFaKjUco?t=00h06m07s)

[place uh because I should be on up down](https://youtu.be/ep-GFaKjUco?t=00h06m11s)

[base I think is the actual](https://youtu.be/ep-GFaKjUco?t=00h06m15s)

[file yeah up down base the](https://youtu.be/ep-GFaKjUco?t=00h06m18s)

[non-generic and so this is](https://youtu.be/ep-GFaKjUco?t=00h06m22s)

[26 okay so what does coer numeric value](https://youtu.be/ep-GFaKjUco?t=00h06m26s)

[do this one actually](https://youtu.be/ep-GFaKjUco?t=00h06m28s)

[clamps it's interesting to do that](https://youtu.be/ep-GFaKjUco?t=00h06m37s)

[here it almost like this is doing the](https://youtu.be/ep-GFaKjUco?t=00h06m43s)

[correct thing however I almost want](https://youtu.be/ep-GFaKjUco?t=00h06m46s)

[to](https://youtu.be/ep-GFaKjUco?t=00h06m49s)

[um probably okay it it what's what kind](https://youtu.be/ep-GFaKjUco?t=00h06m56s)

[of triggering my Spidey Sense is this is](https://youtu.be/ep-GFaKjUco?t=00h06m59s)

[a coers function and a coers function is](https://youtu.be/ep-GFaKjUco?t=00h07m02s)

[meant to be used as part of a dependency](https://youtu.be/ep-GFaKjUco?t=00h07m05s)

[property and usually I find that if I](https://youtu.be/ep-GFaKjUco?t=00h07m07s)

[have to manually call one of these](https://youtu.be/ep-GFaKjUco?t=00h07m09s)

[either the value change to the course](https://youtu.be/ep-GFaKjUco?t=00h07m11s)

[functions directly I usually just](https://youtu.be/ep-GFaKjUco?t=00h07m13s)

[refactor out the bits that I care about](https://youtu.be/ep-GFaKjUco?t=00h07m15s)

[um into a separate method to try to](https://youtu.be/ep-GFaKjUco?t=00h07m19s)

[leave these coers ones just related to](https://youtu.be/ep-GFaKjUco?t=00h07m21s)

[the dependency property it's a little](https://youtu.be/ep-GFaKjUco?t=00h07m23s)

[pedantic but it saves on any amount of](https://youtu.be/ep-GFaKjUco?t=00h07m25s)

[confusion right so if there's there's](https://youtu.be/ep-GFaKjUco?t=00h07m28s)

[some shared logic send it elsewhere um](https://youtu.be/ep-GFaKjUco?t=00h07m29s)

[and part of it is is because you end up](https://youtu.be/ep-GFaKjUco?t=00h07m33s)

[having to pass in the control itself](https://youtu.be/ep-GFaKjUco?t=00h07m34s)

[because it wants the the control to be](https://youtu.be/ep-GFaKjUco?t=00h07m37s)

[able to read the um the up down and](https://youtu.be/ep-GFaKjUco?t=00h07m39s)

[similar so it's like eh it works it](https://youtu.be/ep-GFaKjUco?t=00h07m42s)

[works](https://youtu.be/ep-GFaKjUco?t=00h07m46s)

[okay so let's see here because this](https://youtu.be/ep-GFaKjUco?t=00h07m49s)

[is because because the weird part here](https://youtu.be/ep-GFaKjUco?t=00h07m54s)

[is this is going to set value which is](https://youtu.be/ep-GFaKjUco?t=00h07m56s)

[also going to feed right back back](https://youtu.be/ep-GFaKjUco?t=00h07m58s)

[through this](https://youtu.be/ep-GFaKjUco?t=00h07m59s)

[coer doesn't](https://youtu.be/ep-GFaKjUco?t=00h08m00s)

[it I not actually now that I think about](https://youtu.be/ep-GFaKjUco?t=00h08m06s)

[it okay well let's let's write some](https://youtu.be/ep-GFaKjUco?t=00h08m11s)

[tests let's write some tests this this](https://youtu.be/ep-GFaKjUco?t=00h08m13s)

[feels like something that we test our](https://youtu.be/ep-GFaKjUco?t=00h08m15s)

[way to Victory](https://youtu.be/ep-GFaKjUco?t=00h08m17s)

[on okay](https://youtu.be/ep-GFaKjUco?t=00h08m19s)

[so UI test](https://youtu.be/ep-GFaKjUco?t=00h08m22s)

[WPF uh up down controls numeric up down](https://youtu.be/ep-GFaKjUco?t=00h08m25s)

[tests](https://youtu.be/ep-GFaKjUco?t=00h08m28s)

[we'll just do the](https://youtu.be/ep-GFaKjUco?t=00h08m33s)

[uh I guess the other one must have been](https://youtu.be/ep-GFaKjUco?t=00h08m35s)

[using](https://youtu.be/ep-GFaKjUco?t=00h08m37s)

[decimal given because I'm I'm tempted to](https://youtu.be/ep-GFaKjUco?t=00h08m39s)

[I need to quit clicking on this given](https://youtu.be/ep-GFaKjUco?t=00h08m41s)

[that this](https://youtu.be/ep-GFaKjUco?t=00h08m43s)

[was based on this I'm tell let's do](https://youtu.be/ep-GFaKjUco?t=00h08m47s)

[decimal and we'll actually use the the](https://youtu.be/ep-GFaKjUco?t=00h08m50s)

[use cases right here hey Izzy welcome uh](https://youtu.be/ep-GFaKjUco?t=00h08m52s)

[currently taking a look at this numeric](https://youtu.be/ep-GFaKjUco?t=00h08m56s)

[up down Pull request on the material](https://youtu.be/ep-GFaKjUco?t=00h08m58s)

[design uh we're going to look at a PR](https://youtu.be/ep-GFaKjUco?t=00h09m00s)

[that I opened on velop Pac um remind me](https://youtu.be/ep-GFaKjUco?t=00h09m03s)

[iszy I want to hit you up more on that](https://youtu.be/ep-GFaKjUco?t=00h09m08s)

[MSI stuff so you're going to see a PR](https://youtu.be/ep-GFaKjUco?t=00h09m09s)

[into the velop PAC repo effectively](https://youtu.be/ep-GFaKjUco?t=00h09m11s)

[putting back the old](https://youtu.be/ep-GFaKjUco?t=00h09m14s)

[MSI um that's kind of a stop Gap](https://youtu.be/ep-GFaKjUco?t=00h09m15s)

[immediately because I have a project at](https://youtu.be/ep-GFaKjUco?t=00h09m19s)

[work that that I'm looking to migrate](https://youtu.be/ep-GFaKjUco?t=00h09m23s)

[and I need feature parody with the old](https://youtu.be/ep-GFaKjUco?t=00h09m25s)

[Cloud squirrel stuff so I just need that](https://youtu.be/ep-GFaKjUco?t=00h09m27s)

[in place for now but we we kind of want](https://youtu.be/ep-GFaKjUco?t=00h09m30s)

[to Circle back to the the the MSI stuff](https://youtu.be/ep-GFaKjUco?t=00h09m33s)

[that we were doing last week um because](https://youtu.be/ep-GFaKjUco?t=00h09m36s)

[I feel like there's a good solution](https://youtu.be/ep-GFaKjUco?t=00h09m38s)

[there and I appreciate your your](https://youtu.be/ep-GFaKjUco?t=00h09m41s)

[messages uh okay I am confused as to how](https://youtu.be/ep-GFaKjUco?t=00h09m44s)

[and why this wasn't working before and I](https://youtu.be/ep-GFaKjUco?t=00h09m47s)

[have a strange feeling it's](https://youtu.be/ep-GFaKjUco?t=00h09m50s)

[this it it surprises me here](https://youtu.be/ep-GFaKjUco?t=00h09m56s)

[doing this because dropping the else](https://youtu.be/ep-GFaKjUco?t=00h10m01s)

[block means it's always setting the text](https://youtu.be/ep-GFaKjUco?t=00h10m03s)

[but if uh look at the bundle install](https://youtu.be/ep-GFaKjUco?t=00h10m06s)

[instead yeah that is when you when you](https://youtu.be/ep-GFaKjUco?t=00h10m11s)

[mentioned that to me that got me](https://youtu.be/ep-GFaKjUco?t=00h10m14s)

[thinking that that might be something](https://youtu.be/ep-GFaKjUco?t=00h10m15s)

[that I that I want to look at doing](https://youtu.be/ep-GFaKjUco?t=00h10m17s)

[because I was discussing with kayin some](https://youtu.be/ep-GFaKjUco?t=00h10m21s)

[of the challenges with the MSI installer](https://youtu.be/ep-GFaKjUco?t=00h10m23s)

[specifically everything that we manually](https://youtu.be/ep-GFaKjUco?t=00h10m26s)

[hand handle um inside of our setup exe](https://youtu.be/ep-GFaKjUco?t=00h10m29s)

[and the fear was trying to maintain both](https://youtu.be/ep-GFaKjUco?t=00h10m33s)

[of those and so the idea of the bundle](https://youtu.be/ep-GFaKjUco?t=00h10m35s)

[installer was appealing to](https://youtu.be/ep-GFaKjUco?t=00h10m37s)

[investigate um I I strongly suspect a](https://youtu.be/ep-GFaKjUco?t=00h10m40s)

[lot of the people asking for msis are](https://youtu.be/ep-GFaKjUco?t=00h10m43s)

[only doing it because that um the](https://youtu.be/ep-GFaKjUco?t=00h10m45s)

[packaging support uh that comes with](https://youtu.be/ep-GFaKjUco?t=00h10m48s)

[msis there's so much uh sis admin stuff](https://youtu.be/ep-GFaKjUco?t=00h10m51s)

[that](https://youtu.be/ep-GFaKjUco?t=00h10m55s)

[leverages uh Packaging](https://youtu.be/ep-GFaKjUco?t=00h10m56s)

[and can read the stuff out of an MSI and](https://youtu.be/ep-GFaKjUco?t=00h10m59s)

[so it people feel more warm and fuzzy](https://youtu.be/ep-GFaKjUco?t=00h11m02s)

[when they have an MSI rather than an](https://youtu.be/ep-GFaKjUco?t=00h11m04s)

[arbitrary executable so it's like I get](https://youtu.be/ep-GFaKjUco?t=00h11m06s)

[it from a from a from a Feelgood it](https://youtu.be/ep-GFaKjUco?t=00h11m09s)

[perspective an MSI is probably a](https://youtu.be/ep-GFaKjUco?t=00h11m12s)

[worthwhile thing to have it obviously](https://youtu.be/ep-GFaKjUco?t=00h11m15s)

[doesn't work everywhere um but for some](https://youtu.be/ep-GFaKjUco?t=00h11m16s)

[people they don't care about that so it](https://youtu.be/ep-GFaKjUco?t=00h11m20s)

[I I'm thinking I want to Circle back to](https://youtu.be/ep-GFaKjUco?t=00h11m23s)

[to doing that to doing more of like a a](https://youtu.be/ep-GFaKjUco?t=00h11m25s)

[bundle installer as a uh longer term](https://youtu.be/ep-GFaKjUco?t=00h11m28s)

[thing](https://youtu.be/ep-GFaKjUco?t=00h11m33s)

[instead yeah and that and that's kind of](https://youtu.be/ep-GFaKjUco?t=00h11m37s)

[what I wanted to look at after your](https://youtu.be/ep-GFaKjUco?t=00h11m39s)

[message I started doing some reading on](https://youtu.be/ep-GFaKjUco?t=00h11m41s)

[it because I I will admit I'm out of my](https://youtu.be/ep-GFaKjUco?t=00h11m42s)

[depth on that and so I was trying to](https://youtu.be/ep-GFaKjUco?t=00h11m46s)

[learn](https://youtu.be/ep-GFaKjUco?t=00h11m49s)

[more uh let's see here so but I want to](https://youtu.be/ep-GFaKjUco?t=00h11m50s)

[get this guy merged but I think I want](https://youtu.be/ep-GFaKjUco?t=00h11m53s)

[to do it by adding some tests in](https://youtu.be/ep-GFaKjUco?t=00h11m56s)

[first so let's let's look here uh uh](https://youtu.be/ep-GFaKjUco?t=00h11m59s)

[let's](https://youtu.be/ep-GFaKjUco?t=00h12m04s)

[see](https://youtu.be/ep-GFaKjUco?t=00h12m06s)

[uh](https://youtu.be/ep-GFaKjUco?t=00h12m08s)

[Max uh and](https://youtu.be/ep-GFaKjUco?t=00h12m11s)

[Min assignments are](https://youtu.be/ep-GFaKjUco?t=00h12m14s)

[enforced when](https://youtu.be/ep-GFaKjUco?t=00h12m17s)

[typing see this is what what surprises](https://youtu.be/ep-GFaKjUco?t=00h12m20s)

[me is this here kind of](https://youtu.be/ep-GFaKjUco?t=00h12m23s)

[what do we what are you doing Max Min](https://youtu.be/ep-GFaKjUco?t=00h12m29s)

[assignments course value to be in](https://youtu.be/ep-GFaKjUco?t=00h12m31s)

[range yeah and I I I really think that](https://youtu.be/ep-GFaKjUco?t=00h12m42s)

[people just don't like](https://youtu.be/ep-GFaKjUco?t=00h12m44s)

[like um because I was looking into like](https://youtu.be/ep-GFaKjUco?t=00h12m47s)

[the InTune stuff on what it takes to](https://youtu.be/ep-GFaKjUco?t=00h12m50s)

[actually have um](https://youtu.be/ep-GFaKjUco?t=00h12m52s)

[executables and it looked like the only](https://youtu.be/ep-GFaKjUco?t=00h12m55s)

[difference is the the CIS admin has to](https://youtu.be/ep-GFaKjUco?t=00h12m57s)

[like specify the switches for a silent](https://youtu.be/ep-GFaKjUco?t=00h13m01s)

[install and whatnot versus the tool just](https://youtu.be/ep-GFaKjUco?t=00h13m03s)

[automatically populating those boxes for](https://youtu.be/ep-GFaKjUco?t=00h13m05s)

[them and I'm](https://youtu.be/ep-GFaKjUco?t=00h13m07s)

[like it felt like something that we](https://youtu.be/ep-GFaKjUco?t=00h13m09s)

[could document our way to Victory but I](https://youtu.be/ep-GFaKjUco?t=00h13m11s)

[need the old MSI behavior for now just](https://youtu.be/ep-GFaKjUco?t=00h13m13s)

[so that I can upgrade a particular](https://youtu.be/ep-GFaKjUco?t=00h13m17s)

[project at work so I am selfishly](https://youtu.be/ep-GFaKjUco?t=00h13m19s)

[motivated to put the old one back](https://youtu.be/ep-GFaKjUco?t=00h13m22s)

[immediately um just so that I can get my](https://youtu.be/ep-GFaKjUco?t=00h13m25s)

[current one handled and and that client](https://youtu.be/ep-GFaKjUco?t=00h13m27s)

[all warm and](https://youtu.be/ep-GFaKjUco?t=00h13m30s)

[fuzzy but then long term I want to do](https://youtu.be/ep-GFaKjUco?t=00h13m31s)

[something better uh let's see set](https://youtu.be/ep-GFaKjUco?t=00h13m34s)

[minimum so this is just setting the min](https://youtu.be/ep-GFaKjUco?t=00h13m37s)

[max uh this is so we don't actually have](https://youtu.be/ep-GFaKjUco?t=00h13m41s)

[one for doing the typing it doesn't look](https://youtu.be/ep-GFaKjUco?t=00h13m45s)

[like it looks like this is the closest](https://youtu.be/ep-GFaKjUco?t=00h13m49s)

[one but we don't have anything that](https://youtu.be/ep-GFaKjUco?t=00h13m51s)

[actually types values in okay so this is](https://youtu.be/ep-GFaKjUco?t=00h13m54s)

[that's probably how this bug came](https://youtu.be/ep-GFaKjUco?t=00h13m57s)

[through through is we don't actually](https://youtu.be/ep-GFaKjUco?t=00h13m58s)

[have a bug doing this](https://youtu.be/ep-GFaKjUco?t=00h14m00s)

[so let's go through and I'm going to](https://youtu.be/ep-GFaKjUco?t=00h14m03s)

[we're going to just straight use the bug](https://youtu.be/ep-GFaKjUco?t=00h14m07s)

[report as this so minimum 2.5](https://youtu.be/ep-GFaKjUco?t=00h14m08s)

[maximum 2.5 I think I said that](https://youtu.be/ep-GFaKjUco?t=00h14m13s)

[wrong uh minimum minus](https://youtu.be/ep-GFaKjUco?t=00h14m17s)

[2.5 maximum](https://youtu.be/ep-GFaKjUco?t=00h14m22s)

[2.5 right and then we'll just be real](https://youtu.be/ep-GFaKjUco?t=00h14m25s)

[explicit value gets](https://youtu.be/ep-GFaKjUco?t=00h14m28s)

[zero](https://youtu.be/ep-GFaKjUco?t=00h14m30s)

[um and it doesn't really matter what the](https://youtu.be/ep-GFaKjUco?t=00h14m33s)

[button increment is because in these](https://youtu.be/ep-GFaKjUco?t=00h14m35s)

[tests they are not actually doing this](https://youtu.be/ep-GFaKjUco?t=00h14m38s)

[okay and then really what we need is](https://youtu.be/ep-GFaKjUco?t=00h14m42s)

[something else to focus so we're going](https://youtu.be/ep-GFaKjUco?t=00h14m45s)

[to just](https://youtu.be/ep-GFaKjUco?t=00h14m47s)

[go uh actually I think what we might do](https://youtu.be/ep-GFaKjUco?t=00h14m48s)

[is we just might do a d](https://youtu.be/ep-GFaKjUco?t=00h14m51s)

[panel](https://youtu.be/ep-GFaKjUco?t=00h14m55s)

[think that's pretty close close pretty](https://youtu.be/ep-GFaKjUco?t=00h14m57s)

[close now put a button next really you](https://youtu.be/ep-GFaKjUco?t=00h14m59s)

[can't read my](https://youtu.be/ep-GFaKjUco?t=00h15m03s)

[mind uh](https://youtu.be/ep-GFaKjUco?t=00h15m04s)

[bummer uh](https://youtu.be/ep-GFaKjUco?t=00h15m08s)

[alternate](https://youtu.be/ep-GFaKjUco?t=00h15m10s)

[Focus](https://youtu.be/ep-GFaKjUco?t=00h15m12s)

[element](https://youtu.be/ep-GFaKjUco?t=00h15m13s)

[uh yeah whatever okay so this is going](https://youtu.be/ep-GFaKjUco?t=00h15m16s)

[to end up being stack](https://youtu.be/ep-GFaKjUco?t=00h15m19s)

[panel I'm going to make](https://youtu.be/ep-GFaKjUco?t=00h15m22s)

[you stack panel but I still want this](https://youtu.be/ep-GFaKjUco?t=00h15m24s)

[variable here I want to go VAR numeric](https://youtu.be/ep-GFaKjUco?t=00h15m29s)

[up](https://youtu.be/ep-GFaKjUco?t=00h15m32s)

[down now we can do that okay so now the](https://youtu.be/ep-GFaKjUco?t=00h15m33s)

[rest of this just continues to work uh](https://youtu.be/ep-GFaKjUco?t=00h15m36s)

[and then I want to](https://youtu.be/ep-GFaKjUco?t=00h15m39s)

[do bar button gets](https://youtu.be/ep-GFaKjUco?t=00h15m41s)

[await uh stack panel hey stop it stop](https://youtu.be/ep-GFaKjUco?t=00h15m45s)

[it uh get element](https://youtu.be/ep-GFaKjUco?t=00h15m51s)

[button uh this I don't remember if get](https://youtu.be/ep-GFaKjUco?t=00h15m54s)

[ele El](https://youtu.be/ep-GFaKjUco?t=00h15m58s)

[is yeah we'll see which button comes](https://youtu.be/ep-GFaKjUco?t=00h16m06s)

[back I'm actually not confident whether](https://youtu.be/ep-GFaKjUco?t=00h16m10s)

[this is a depth first or a breadth first](https://youtu.be/ep-GFaKjUco?t=00h16m12s)

[search I think it's breadth first](https://youtu.be/ep-GFaKjUco?t=00h16m14s)

[meaning does it because there are](https://youtu.be/ep-GFaKjUco?t=00h16m17s)

[buttons inside of this numeric up down](https://youtu.be/ep-GFaKjUco?t=00h16m19s)

[control right because there's the plus](https://youtu.be/ep-GFaKjUco?t=00h16m21s)

[minus if it's depth first it is going to](https://youtu.be/ep-GFaKjUco?t=00h16m22s)

[go down and grab this one here here and](https://youtu.be/ep-GFaKjUco?t=00h16m27s)

[and find the ones here if it's breath](https://youtu.be/ep-GFaKjUco?t=00h16m30s)

[first it'll grab this one because this](https://youtu.be/ep-GFaKjUco?t=00h16m31s)

[one's at the higher level I hope it's](https://youtu.be/ep-GFaKjUco?t=00h16m33s)

[breath first if not we might go log a](https://youtu.be/ep-GFaKjUco?t=00h16m35s)

[bug against my examl zaml test Library](https://youtu.be/ep-GFaKjUco?t=00h16m37s)

[uh bum okay so there's all that there's](https://youtu.be/ep-GFaKjUco?t=00h16m41s)

[all that and then I think we just want](https://youtu.be/ep-GFaKjUco?t=00h16m43s)

[to get rid of all of this work here and](https://youtu.be/ep-GFaKjUco?t=00h16m44s)

[then recorder success did we not have](https://youtu.be/ep-GFaKjUco?t=00h16m51s)

[recorder success](https://youtu.be/ep-GFaKjUco?t=00h16m53s)

[oh that's](https://youtu.be/ep-GFaKjUco?t=00h16m55s)

[bad so by not calling recorder success](https://youtu.be/ep-GFaKjUco?t=00h16m57s)

[it means this thing is gonna output uh](https://youtu.be/ep-GFaKjUco?t=00h17m00s)

[an image every time](https://youtu.be/ep-GFaKjUco?t=00h17m04s)

[regardless that's](https://youtu.be/ep-GFaKjUco?t=00h17m05s)

[exciting uh oh and this we should](https://youtu.be/ep-GFaKjUco?t=00h17m07s)

[actually probably move to the other one](https://youtu.be/ep-GFaKjUco?t=00h17m10s)

[because this is the numeric up down](https://youtu.be/ep-GFaKjUco?t=00h17m13s)

[test and I think we want to do this in](https://youtu.be/ep-GFaKjUco?t=00h17m15s)

[the decimal updown test yeah I kind of](https://youtu.be/ep-GFaKjUco?t=00h17m17s)

[thought I did the same thing did I mess](https://youtu.be/ep-GFaKjUco?t=00h17m20s)

[it up everywhere](https://youtu.be/ep-GFaKjUco?t=00h17m22s)

[yep I messed it up everywhere](https://youtu.be/ep-GFaKjUco?t=00h17m24s)

[at some point I'm going to write myself](https://youtu.be/ep-GFaKjUco?t=00h17m30s)

[a custom little xunit thing to do this](https://youtu.be/ep-GFaKjUco?t=00h17m32s)

[work for me part of what makes that](https://youtu.be/ep-GFaKjUco?t=00h17m35s)

[mildly difficult is the way this test](https://youtu.be/ep-GFaKjUco?t=00h17m38s)

[recorder works is it's abusing some](https://youtu.be/ep-GFaKjUco?t=00h17m40s)

[caller attributes to get the unit test](https://youtu.be/ep-GFaKjUco?t=00h17m42s)

[method name if I put it inside of an](https://youtu.be/ep-GFaKjUco?t=00h17m45s)

[xunit attribute it gets slightly more](https://youtu.be/ep-GFaKjUco?t=00h17m47s)

[complicated to be able to locate](https://youtu.be/ep-GFaKjUco?t=00h17m49s)

[it uh let's just make sure we fix that](https://youtu.be/ep-GFaKjUco?t=00h17m51s)

[recorder change on all of](https://youtu.be/ep-GFaKjUco?t=00h17m54s)

[these cuz that's just just that's just](https://youtu.be/ep-GFaKjUco?t=00h17m57s)

[stupid on my](https://youtu.be/ep-GFaKjUco?t=00h17m59s)

[part I really should probably be](https://youtu.be/ep-GFaKjUco?t=00h18m06s)

[checking to make sure that oh no no no](https://youtu.be/ep-GFaKjUco?t=00h18m08s)

[no uh because all this success method](https://youtu.be/ep-GFaKjUco?t=00h18m14s)

[does is tell the the test recorder that](https://youtu.be/ep-GFaKjUco?t=00h18m18s)

[hey the test completed successfully](https://youtu.be/ep-GFaKjUco?t=00h18m21s)

[don't don't uh take screenshots because](https://youtu.be/ep-GFaKjUco?t=00h18m24s)

[otherwise what will happen is the](https://youtu.be/ep-GFaKjUco?t=00h18m27s)

[dispose on this test recorder grabs a](https://youtu.be/ep-GFaKjUco?t=00h18m29s)

[screenshot of whatever the app's](https://youtu.be/ep-GFaKjUco?t=00h18m31s)

[currently at before it shuts down so](https://youtu.be/ep-GFaKjUco?t=00h18m33s)

[that it uh because for like a UI test](https://youtu.be/ep-GFaKjUco?t=00h18m36s)

[you want to see the state of the app so](https://youtu.be/ep-GFaKjUco?t=00h18m38s)

[it's just a a quick and easy way to](https://youtu.be/ep-GFaKjUco?t=00h18m40s)

[basically take screenshots all the way](https://youtu.be/ep-GFaKjUco?t=00h18m42s)

[through because I'm way too lazy uh okay](https://youtu.be/ep-GFaKjUco?t=00h18m44s)

[so this actually needs to be decimal up](https://youtu.be/ep-GFaKjUco?t=00h18m48s)

[down rather than numeric up down so this](https://youtu.be/ep-GFaKjUco?t=00h18m51s)

[is going to be decimal up](https://youtu.be/ep-GFaKjUco?t=00h18m54s)

[down uh let's see](https://youtu.be/ep-GFaKjUco?t=00h18m57s)

[here I don't have our neck running here](https://youtu.be/ep-GFaKjUco?t=00h19m06s)

[we](https://youtu.be/ep-GFaKjUco?t=00h19m09s)

[go okay so that gets me to there that](https://youtu.be/ep-GFaKjUco?t=00h19m10s)

[gets me to there that gets me to there](https://youtu.be/ep-GFaKjUco?t=00h19m13s)

[okay so test cases that we care](https://youtu.be/ep-GFaKjUco?t=00h19m15s)

[about](https://youtu.be/ep-GFaKjUco?t=00h19m19s)

[so value zero type in 20 and then move](https://youtu.be/ep-GFaKjUco?t=00h19m21s)

[Focus this is expected to work okay so](https://youtu.be/ep-GFaKjUco?t=00h19m25s)

[let's grab text](https://youtu.be/ep-GFaKjUco?t=00h19m29s)

[box uh do we set](https://youtu.be/ep-GFaKjUco?t=00h19m33s)

[text I think we can just set](https://youtu.be/ep-GFaKjUco?t=00h19m38s)

[text uh so type in](https://youtu.be/ep-GFaKjUco?t=00h19m41s)

[20 uh learn how to type is the next one](https://youtu.be/ep-GFaKjUco?t=00h19m48s)

[uh and then we want to move Focus so we](https://youtu.be/ep-GFaKjUco?t=00h19m52s)

[want to go button](https://youtu.be/ep-GFaKjUco?t=00h19m56s)

[uh what is my](https://youtu.be/ep-GFaKjUco?t=00h19m59s)

[focus move keyboard Focus to the](https://youtu.be/ep-GFaKjUco?t=00h20m02s)

[button and then I want to](https://youtu.be/ep-GFaKjUco?t=00h20m07s)

[go](https://youtu.be/ep-GFaKjUco?t=00h20m11s)

[that I should probably learn how to](https://youtu.be/ep-GFaKjUco?t=00h20m14s)

[spell here there we](https://youtu.be/ep-GFaKjUco?t=00h20m16s)

[go uh get text and then I think what I](https://youtu.be/ep-GFaKjUco?t=00h20m22s)

[want to do is get value as well](https://youtu.be/ep-GFaKjUco?t=00h20m25s)

[why do I not have get value on](https://youtu.be/ep-GFaKjUco?t=00h20m29s)

[here oh probably because I'm not](https://youtu.be/ep-GFaKjUco?t=00h20m31s)

[generating the extension methods for](https://youtu.be/ep-GFaKjUco?t=00h20m33s)

[decimal I](https://youtu.be/ep-GFaKjUco?t=00h20m35s)

[bet is that](https://youtu.be/ep-GFaKjUco?t=00h20m38s)

[here I am generating helpers for decimal](https://youtu.be/ep-GFaKjUco?t=00h20m41s)

[up](https://youtu.be/ep-GFaKjUco?t=00h20m44s)

[down why does it not have a thing for](https://youtu.be/ep-GFaKjUco?t=00h20m46s)

[Value oh because I'm on text box I don't](https://youtu.be/ep-GFaKjUco?t=00h20m52s)

[want the tech uh I want to do this on](https://youtu.be/ep-GFaKjUco?t=00h20m55s)

[decimal up down](https://youtu.be/ep-GFaKjUco?t=00h20m57s)

[so decimal up](https://youtu.be/ep-GFaKjUco?t=00h20m59s)

[down get](https://youtu.be/ep-GFaKjUco?t=00h21m02s)

[value will give it to me oh I guess the](https://youtu.be/ep-GFaKjUco?t=00h21m05s)

[up down control doesn't have a text](https://youtu.be/ep-GFaKjUco?t=00h21m08s)

[property so in order to check the text I](https://youtu.be/ep-GFaKjUco?t=00h21m09s)

[have to do that uh and then this needs](https://youtu.be/ep-GFaKjUco?t=00h21m11s)

[to be like this and like](https://youtu.be/ep-GFaKjUco?t=00h21m14s)

[this okay so this is expected to](https://youtu.be/ep-GFaKjUco?t=00h21m20s)

[pass let's just see if it actually does](https://youtu.be/ep-GFaKjUco?t=00h21m25s)

[we can probably get rid of the bits that](https://youtu.be/ep-GFaKjUco?t=00h21m36s)

[are retrieving the plus minus buttons as](https://youtu.be/ep-GFaKjUco?t=00h21m37s)

[well because we aren't going to we](https://youtu.be/ep-GFaKjUco?t=00h21m41s)

[aren't going to be using those buttons](https://youtu.be/ep-GFaKjUco?t=00h21m43s)

[at](https://youtu.be/ep-GFaKjUco?t=00h21m44s)

[all so failed what failed strings](https://youtu.be/ep-GFaKjUco?t=00h21m49s)

[differ so that actually](https://youtu.be/ep-GFaKjUco?t=00h21m56s)

[so that partially makes me feel better](https://youtu.be/ep-GFaKjUco?t=00h22m00s)

[and partially makes me feel worse](https://youtu.be/ep-GFaKjUco?t=00h22m03s)

[um await Tas](https://youtu.be/ep-GFaKjUco?t=00h22m06s)

[delay I don't know give me three seconds](https://youtu.be/ep-GFaKjUco?t=00h22m10s)

[I just want to I just want to visually](https://youtu.be/ep-GFaKjUco?t=00h22m13s)

[check this to make sure that it is in](https://youtu.be/ep-GFaKjUco?t=00h22m14s)

[fact moving the focus to the](https://youtu.be/ep-GFaKjUco?t=00h22m16s)

[button um](https://youtu.be/ep-GFaKjUco?t=00h22m26s)

[actually uh let's](https://youtu.be/ep-GFaKjUco?t=00h22m30s)

[see type](https://youtu.be/ep-GFaKjUco?t=00h22m34s)

[or trying to remember the send input](https://youtu.be/ep-GFaKjUco?t=00h22m36s)

[that's what I want I want it to actually](https://youtu.be/ep-GFaKjUco?t=00h22m39s)

[type in](https://youtu.be/ep-GFaKjUco?t=00h22m42s)

[things send](https://youtu.be/ep-GFaKjUco?t=00h22m45s)

[input uh what is](https://youtu.be/ep-GFaKjUco?t=00h22m48s)

[my there's um sorry I I'm trying to](https://youtu.be/ep-GFaKjUco?t=00h22m53s)

[remember my short hand for this then](https://youtu.be/ep-GFaKjUco?t=00h22m58s)

[keyboard input that's what it is like I](https://youtu.be/ep-GFaKjUco?t=00h23m01s)

[know I wrote myself an extension method](https://youtu.be/ep-GFaKjUco?t=00h23m04s)

[for this because I was way too I was way](https://youtu.be/ep-GFaKjUco?t=00h23m06s)

[too lazy to like do](https://youtu.be/ep-GFaKjUco?t=00h23m08s)

[work um and it](https://youtu.be/ep-GFaKjUco?t=00h23m13s)

[wants that so th this one may shock some](https://youtu.be/ep-GFaKjUco?t=00h23m15s)

[people that this works but this](https://youtu.be/ep-GFaKjUco?t=00h23m19s)

[doesn't kind of a trick and I should](https://youtu.be/ep-GFaKjUco?t=00h23m23s)

[probably give my myself an overload](https://youtu.be/ep-GFaKjUco?t=00h23m26s)

[there was a reason something I bumped](https://youtu.be/ep-GFaKjUco?t=00h23m28s)

[into that limits it so what's happening](https://youtu.be/ep-GFaKjUco?t=00h23m30s)

[here is send keyboard input takes in a](https://youtu.be/ep-GFaKjUco?t=00h23m32s)

[formattable string not a string most](https://youtu.be/ep-GFaKjUco?t=00h23m35s)

[people think that when you put a dollar](https://youtu.be/ep-GFaKjUco?t=00h23m38s)

[sign in front of the quotes um that just](https://youtu.be/ep-GFaKjUco?t=00h23m39s)

[does string format and that's true most](https://youtu.be/ep-GFaKjUco?t=00h23m42s)

[of the time um but secretly the compiler](https://youtu.be/ep-GFaKjUco?t=00h23m45s)

[will look at where you're assigning that](https://youtu.be/ep-GFaKjUco?t=00h23m49s)

[dollar sign quote stringy thing and then](https://youtu.be/ep-GFaKjUco?t=00h23m52s)

[decide whether it's a formattable string](https://youtu.be/ep-GFaKjUco?t=00h23m55s)

[or string](https://youtu.be/ep-GFaKjUco?t=00h23m57s)

[and that's what you're going to get a](https://youtu.be/ep-GFaKjUco?t=00h23m58s)

[formattable string just lets you um do](https://youtu.be/ep-GFaKjUco?t=00h24m00s)

[introspection on](https://youtu.be/ep-GFaKjUco?t=00h24m03s)

[it um and be able to do this but I'm I](https://youtu.be/ep-GFaKjUco?t=00h24m05s)

[probably could allow myself just a](https://youtu.be/ep-GFaKjUco?t=00h24m08s)

[regular string overload here and just](https://youtu.be/ep-GFaKjUco?t=00h24m10s)

[add some text input right it does the](https://youtu.be/ep-GFaKjUco?t=00h24m12s)

[only reason it does this is so that I](https://youtu.be/ep-GFaKjUco?t=00h24m15s)

[can do some fancy stuff and pass in you](https://youtu.be/ep-GFaKjUco?t=00h24m16s)

[know fancy keys and modifier keys and](https://youtu.be/ep-GFaKjUco?t=00h24m19s)

[all of that jazz like it's clever and](https://youtu.be/ep-GFaKjUco?t=00h24m22s)

[and slick](https://youtu.be/ep-GFaKjUco?t=00h24m24s)

[but needs that okay so that](https://youtu.be/ep-GFaKjUco?t=00h24m26s)

[should uh run](https://youtu.be/ep-GFaKjUco?t=00h24m30s)

[test and then I I want to see because I](https://youtu.be/ep-GFaKjUco?t=00h24m33s)

[don't think we were hitting the](https://youtu.be/ep-GFaKjUco?t=00h24m36s)

[Lost](https://youtu.be/ep-GFaKjUco?t=00h24m39s)

[Focus okay so that that worked as](https://youtu.be/ep-GFaKjUco?t=00h24m41s)

[expected](https://youtu.be/ep-GFaKjUco?t=00h24m45s)

[um I kind of want to do something](https://youtu.be/ep-GFaKjUco?t=00h24m48s)

[like uh modifier](https://youtu.be/ep-GFaKjUco?t=00h24m52s)

[Keys control](https://youtu.be/ep-GFaKjUco?t=00h24m55s)

[uh what is the should look at this real](https://youtu.be/ep-GFaKjUco?t=00h24m59s)

[quick because it's I can send in](https://youtu.be/ep-GFaKjUco?t=00h25m01s)

[modifier Keys followed](https://youtu.be/ep-GFaKjUco?t=00h25m02s)

[by argument is not modifier](https://youtu.be/ep-GFaKjUco?t=00h25m08s)

[Keys yeah so I want to send in modifier](https://youtu.be/ep-GFaKjUco?t=00h25m14s)

[Keys followed by key I think I think I](https://youtu.be/ep-GFaKjUco?t=00h25m18s)

[want to go](https://youtu.be/ep-GFaKjUco?t=00h25m21s)

[control uh keys](https://youtu.be/ep-GFaKjUco?t=00h25m24s)

[so basically select all the text and](https://youtu.be/ep-GFaKjUco?t=00h25m29s)

[then clap that then then type in the 20](https://youtu.be/ep-GFaKjUco?t=00h25m32s)

[because I don't know if you caught it](https://youtu.be/ep-GFaKjUco?t=00h25m36s)

[but when it was uh typing that in it was](https://youtu.be/ep-GFaKjUco?t=00h25m38s)

[actually going through](https://youtu.be/ep-GFaKjUco?t=00h25m41s)

[and yeah H let's do this this real quick](https://youtu.be/ep-GFaKjUco?t=00h25m46s)

[going to do we're going to slow this](https://youtu.be/ep-GFaKjUco?t=00h25m50s)

[sucker down real](https://youtu.be/ep-GFaKjUco?t=00h25m52s)

[quick delay](https://youtu.be/ep-GFaKjUco?t=00h25m54s)

[I just want to I just want to make](https://youtu.be/ep-GFaKjUco?t=00h25m58s)

[absolute certain I see what's happening](https://youtu.be/ep-GFaKjUco?t=00h26m00s)

[here there's no point in chasing this if](https://youtu.be/ep-GFaKjUco?t=00h26m03s)

[I've got a bad test like obviously this](https://youtu.be/ep-GFaKjUco?t=00h26m06s)

[one's working](https://youtu.be/ep-GFaKjUco?t=00h26m08s)

[but](https://youtu.be/ep-GFaKjUco?t=00h26m09s)

[there collected it all typed in](https://youtu.be/ep-GFaKjUco?t=00h26m11s)

[20 moves Focus](https://youtu.be/ep-GFaKjUco?t=00h26m16s)

[great](https://youtu.be/ep-GFaKjUco?t=00h26m19s)

[okay great great](https://youtu.be/ep-GFaKjUco?t=00h26m21s)

[great ooh let's see so can I hide and](https://youtu.be/ep-GFaKjUco?t=00h26m26s)

[provide my own up down buttons for this](https://youtu.be/ep-GFaKjUco?t=00h26m30s)

[control um I'd inject something between](https://youtu.be/ep-GFaKjUco?t=00h26m33s)

[the text box and the](https://youtu.be/ep-GFaKjUco?t=00h26m37s)

[buttons injecting something between the](https://youtu.be/ep-GFaKjUco?t=00h26m39s)

[buttons is](https://youtu.be/ep-GFaKjUco?t=00h26m41s)

[definitely is definitely wow I think](https://youtu.be/ep-GFaKjUco?t=00h26m45s)

[this thing because my injection held the](https://youtu.be/ep-GFaKjUco?t=00h26m47s)

[control key](https://youtu.be/ep-GFaKjUco?t=00h26m50s)

[down um](https://youtu.be/ep-GFaKjUco?t=00h26m53s)

[there is not a way I without templating](https://youtu.be/ep-GFaKjUco?t=00h26m59s)

[to inject something between the buttons](https://youtu.be/ep-GFaKjUco?t=00h27m03s)

[but before I put my foot all the way in](https://youtu.be/ep-GFaKjUco?t=00h27m06s)

[my mouth I just want to confirm](https://youtu.be/ep-GFaKjUco?t=00h27m07s)

[that I'm fairly](https://youtu.be/ep-GFaKjUco?t=00h27m11s)

[confident the template doesn't give](https://youtu.be/ep-GFaKjUco?t=00h27m14s)

[you fancy injection right so there's the](https://youtu.be/ep-GFaKjUco?t=00h27m17s)

[main text box and then it's just a stack](https://youtu.be/ep-GFaKjUco?t=00h27m20s)

[panel with up down](https://youtu.be/ep-GFaKjUco?t=00h27m23s)

[buttons for my data speed control ah](https://youtu.be/ep-GFaKjUco?t=00h27m25s)

[interesting yeah no so I think what](https://youtu.be/ep-GFaKjUco?t=00h27m29s)

[you're going to end up with Izzy is](https://youtu.be/ep-GFaKjUco?t=00h27m32s)

[probably a new control template if you](https://youtu.be/ep-GFaKjUco?t=00h27m35s)

[want to inject something there like the](https://youtu.be/ep-GFaKjUco?t=00h27m37s)

[content for the buttons you can put your](https://youtu.be/ep-GFaKjUco?t=00h27m40s)

[own content in the buttons that is a](https://youtu.be/ep-GFaKjUco?t=00h27m43s)

[thing right you don't have to use](https://youtu.be/ep-GFaKjUco?t=00h27m45s)

[the um the pre canned pack icons that](https://youtu.be/ep-GFaKjUco?t=00h27m47s)

[we've got in](https://youtu.be/ep-GFaKjUco?t=00h27m51s)

[there but you you uh but to put](https://youtu.be/ep-GFaKjUco?t=00h27m52s)

[something between them there's nothing](https://youtu.be/ep-GFaKjUco?t=00h27m56s)

[there's nothing exposed inside of the](https://youtu.be/ep-GFaKjUco?t=00h27m57s)

[template that would allow it there's](https://youtu.be/ep-GFaKjUco?t=00h28m00s)

[also not really anything that lets you](https://youtu.be/ep-GFaKjUco?t=00h28m01s)

[even control the position of where those](https://youtu.be/ep-GFaKjUco?t=00h28m03s)

[buttons are and we had talked about](https://youtu.be/ep-GFaKjUco?t=00h28m06s)

[different options for people because](https://youtu.be/ep-GFaKjUco?t=00h28m08s)

[there's a lot of different ways that](https://youtu.be/ep-GFaKjUco?t=00h28m10s)

[people like to do these up down controls](https://youtu.be/ep-GFaKjUco?t=00h28m12s)

[some people like the the plus minus](https://youtu.be/ep-GFaKjUco?t=00h28m14s)

[buttons stacked on top of each other](https://youtu.be/ep-GFaKjUco?t=00h28m16s)

[rather than side to side um and](https://youtu.be/ep-GFaKjUco?t=00h28m18s)

[ultimately was like you know what for a](https://youtu.be/ep-GFaKjUco?t=00h28m21s)

[V1 let's just get something out there](https://youtu.be/ep-GFaKjUco?t=00h28m23s)

[that works it seems to be a popular](https://youtu.be/ep-GFaKjUco?t=00h28m24s)

[control because people keep keep logging](https://youtu.be/ep-GFaKjUco?t=00h28m26s)

[issues against it which means they're](https://youtu.be/ep-GFaKjUco?t=00h28m29s)

[using it or trying to use it](https://youtu.be/ep-GFaKjUco?t=00h28m30s)

[so it it is it has gotten a lot more](https://youtu.be/ep-GFaKjUco?t=00h28m33s)

[attention than I anticipated I'll say](https://youtu.be/ep-GFaKjUco?t=00h28m36s)

[that um because yeah I sort of](https://youtu.be/ep-GFaKjUco?t=00h28m38s)

[anticipated somebody yelling about](https://youtu.be/ep-GFaKjUco?t=00h28m41s)

[wanting to change these properties here](https://youtu.be/ep-GFaKjUco?t=00h28m43s)

[for](https://youtu.be/ep-GFaKjUco?t=00h28m45s)

[something so yeah not I think your](https://youtu.be/ep-GFaKjUco?t=00h28m46s)

[easiest option is probably just to snag](https://youtu.be/ep-GFaKjUco?t=00h28m48s)

[the template and then roll your own](https://youtu.be/ep-GFaKjUco?t=00h28m51s)

[template replace it with uh something](https://youtu.be/ep-GFaKjUco?t=00h28m54s)

[that has whatever controls you want](https://youtu.be/ep-GFaKjUco?t=00h28m57s)

[maybe some attached Properties or](https://youtu.be/ep-GFaKjUco?t=00h28m59s)

[similar uh okay so this is I think what](https://youtu.be/ep-GFaKjUco?t=00h29m01s)

[we're going to actually do is this](https://youtu.be/ep-GFaKjUco?t=00h29m05s)

[await textbox move keyboard Focus](https://youtu.be/ep-GFaKjUco?t=00h29m07s)

[await](https://youtu.be/ep-GFaKjUco?t=00h29m12s)

[textbox](https://youtu.be/ep-GFaKjUco?t=00h29m19s)

[uh is what what I what](https://youtu.be/ep-GFaKjUco?t=00h29m25s)

[was just about to ask about putting](https://youtu.be/ep-GFaKjUco?t=00h29m29s)

[buttons on the left yeah and that's that](https://youtu.be/ep-GFaKjUco?t=00h29m31s)

[was the thing that I was anticipating](https://youtu.be/ep-GFaKjUco?t=00h29m33s)

[people asking about first is the the](https://youtu.be/ep-GFaKjUco?t=00h29m35s)

[position of those buttons it's like we](https://youtu.be/ep-GFaKjUco?t=00h29m38s)

[just put them in on the right because we](https://youtu.be/ep-GFaKjUco?t=00h29m40s)

[had to decide on a style to to ship with](https://youtu.be/ep-GFaKjUco?t=00h29m43s)

[and that seemed to be the most kind of](https://youtu.be/ep-GFaKjUco?t=00h29m46s)

[idiomatic one but it there's so many](https://youtu.be/ep-GFaKjUco?t=00h29m48s)

[implementations that people have done](https://youtu.be/ep-GFaKjUco?t=00h29m51s)

[for this same](https://youtu.be/ep-GFaKjUco?t=00h29m52s)

[control I I kind of](https://youtu.be/ep-GFaKjUco?t=00h29m54s)

[anticipate uh uh people wanting to do](https://youtu.be/ep-GFaKjUco?t=00h29m56s)

[the same um I'm wanting to look here](https://youtu.be/ep-GFaKjUco?t=00h29m59s)

[real quick because I](https://youtu.be/ep-GFaKjUco?t=00h30m04s)

[thought why is this thing](https://youtu.be/ep-GFaKjUco?t=00h30m08s)

[not directing me to the](https://youtu.be/ep-GFaKjUco?t=00h30m10s)

[right](https://youtu.be/ep-GFaKjUco?t=00h30m13s)

[thingy](https://youtu.be/ep-GFaKjUco?t=00h30m16s)

[um took me there a second ago](https://youtu.be/ep-GFaKjUco?t=00h30m21s)

[uh I want to look and see how it handles](https://youtu.be/ep-GFaKjUco?t=00h30m28s)

[those modifier Keys why is it failing](https://youtu.be/ep-GFaKjUco?t=00h30m30s)

[to very confused why it keeps taking me](https://youtu.be/ep-GFaKjUco?t=00h30m35s)

[here I don't want to be](https://youtu.be/ep-GFaKjUco?t=00h30m37s)

[here um I might just have to go look](https://youtu.be/ep-GFaKjUco?t=00h30m39s)

[because I I want to](https://youtu.be/ep-GFaKjUco?t=00h30m42s)

[do okay I might have to just do](https://youtu.be/ep-GFaKjUco?t=00h30m44s)

[this uh send keyboard](https://youtu.be/ep-GFaKjUco?t=00h30m47s)

[input uh](https://youtu.be/ep-GFaKjUco?t=00h30m52s)

[right like that's the method I'd like to](https://youtu.be/ep-GFaKjUco?t=00h30m58s)

[go to why do you keep directing me to](https://youtu.be/ep-GFaKjUco?t=00h31m00s)

[the wrong](https://youtu.be/ep-GFaKjUco?t=00h31m02s)

[file yeah this is the wrong](https://youtu.be/ep-GFaKjUco?t=00h31m05s)

[file confused why it can't figure it out](https://youtu.be/ep-GFaKjUco?t=00h31m12s)

[uh let's see text box send](https://youtu.be/ep-GFaKjUco?t=00h31m15s)

[input and then it's going to be let's](https://youtu.be/ep-GFaKjUco?t=00h31m20s)

[see keyboard input](https://youtu.be/ep-GFaKjUco?t=00h31m24s)

[uh let's see and I'm trying to I'm](https://youtu.be/ep-GFaKjUco?t=00h31m29s)

[trying to remember my own](https://youtu.be/ep-GFaKjUco?t=00h31m30s)

[apis Keys input but I does Keys input](https://youtu.be/ep-GFaKjUco?t=00h31m37s)

[support down or just](https://youtu.be/ep-GFaKjUco?t=00h31m41s)

[up because it should be doing](https://youtu.be/ep-GFaKjUco?t=00h31m43s)

[both but I'm wondering if it's just](https://youtu.be/ep-GFaKjUco?t=00h31m47s)

[doing on I got to look now uh let's see](https://youtu.be/ep-GFaKjUco?t=00h31m51s)

[go here](https://youtu.be/ep-GFaKjUco?t=00h31m57s)

[damel](https://youtu.be/ep-GFaKjUco?t=00h32m01s)

[test uh let's](https://youtu.be/ep-GFaKjUco?t=00h32m05s)

[see um I've got too much going on so](https://youtu.be/ep-GFaKjUco?t=00h32m10s)

[let's I niiz ones there's some](https://youtu.be/ep-GFaKjUco?t=00h32m14s)

[dependabot branches out there that](https://youtu.be/ep-GFaKjUco?t=00h32m18s)

[aren't merging in I should go fix](https://youtu.be/ep-GFaKjUco?t=00h32m21s)

[them uh uh let's see here I just want to](https://youtu.be/ep-GFaKjUco?t=00h32m26s)

[look at how it handles this key](https://youtu.be/ep-GFaKjUco?t=00h32m29s)

[input talking](https://youtu.be/ep-GFaKjUco?t=00h32m31s)

[about install an update installing a](https://youtu.be/ep-GFaKjUco?t=00h32m34s)

[visual studio update Midstream sort of a](https://youtu.be/ep-GFaKjUco?t=00h32m37s)

[bad](https://youtu.be/ep-GFaKjUco?t=00h32m39s)

[idea um okay so what I am really looking](https://youtu.be/ep-GFaKjUco?t=00h32m40s)

[for is](https://youtu.be/ep-GFaKjUco?t=00h32m43s)

[input is set](https://youtu.be/ep-GFaKjUco?t=00h32m46s)

[modifiers send](https://youtu.be/ep-GFaKjUco?t=00h32m49s)

[input and input and see this this is](https://youtu.be/ep-GFaKjUco?t=00h32m55s)

[where I'm wondering if do I ever](https://youtu.be/ep-GFaKjUco?t=00h32m58s)

[actually](https://youtu.be/ep-GFaKjUco?t=00h33m00s)

[handle](https://youtu.be/ep-GFaKjUco?t=00h33m03s)

[uh get key](https://youtu.be/ep-GFaKjUco?t=00h33m14s)

[press create input](https://youtu.be/ep-GFaKjUco?t=00h33m19s)

[oh I have to send a modifier Keys none](https://youtu.be/ep-GFaKjUco?t=00h33m29s)

[to](https://youtu.be/ep-GFaKjUco?t=00h33m32s)

[um to unpre ah that's what I want to do](https://youtu.be/ep-GFaKjUco?t=00h33m34s)

[okay that's all I needed okay so this](https://youtu.be/ep-GFaKjUco?t=00h33m38s)

[should really](https://youtu.be/ep-GFaKjUco?t=00h33m41s)

[be modifier Keys](https://youtu.be/ep-GFaKjUco?t=00h33m44s)

[none do](https://youtu.be/ep-GFaKjUco?t=00h33m49s)

[that okay](https://youtu.be/ep-GFaKjUco?t=00h33m52s)

[okay so this should get me all the way](https://youtu.be/ep-GFaKjUco?t=00h34m00s)

[there I think then we're going to go](https://youtu.be/ep-GFaKjUco?t=00h34m03s)

[test the other](https://youtu.be/ep-GFaKjUco?t=00h34m05s)

[case Okay test case one](https://youtu.be/ep-GFaKjUco?t=00h34m10s)

[yes test case](https://youtu.be/ep-GFaKjUco?t=00h34m14s)

[two value starts at](https://youtu.be/ep-GFaKjUco?t=00h34m17s)

[zero type in 20 lose focus so we're](https://youtu.be/ep-GFaKjUco?t=00h34m20s)

[going to set value to zero](https://youtu.be/ep-GFaKjUco?t=00h34m25s)

[oh no type in 20 is the one that we did](https://youtu.be/ep-GFaKjUco?t=00h34m30s)

[type in](https://youtu.be/ep-GFaKjUco?t=00h34m33s)

[30 I kind of want to](https://youtu.be/ep-GFaKjUco?t=00h34m36s)

[check kind of want to RT the change](https://youtu.be/ep-GFaKjUco?t=00h34m39s)

[inside of](https://youtu.be/ep-GFaKjUco?t=00h34m44s)

[here I'm I'm a little surprised that](https://youtu.be/ep-GFaKjUco?t=00h34m45s)

[this fixes it so let's](https://youtu.be/ep-GFaKjUco?t=00h34m48s)

[grab let's grab that Delta real quick](https://youtu.be/ep-GFaKjUco?t=00h34m50s)

[the](https://youtu.be/ep-GFaKjUco?t=00h35m01s)

[fix](https://youtu.be/ep-GFaKjUco?t=00h35m04s)

[uh the branch I'm](https://youtu.be/ep-GFaKjUco?t=00h35m08s)

[on this is the old code so going to grab](https://youtu.be/ep-GFaKjUco?t=00h35m14s)

[that so I can ab test this a little](https://youtu.be/ep-GFaKjUco?t=00h35m17s)

[bit going to do that there right so the](https://youtu.be/ep-GFaKjUco?t=00h35m20s)

[assertion before](https://youtu.be/ep-GFaKjUco?t=00h35m26s)

[is](https://youtu.be/ep-GFaKjUco?t=00h35m29s)

[this](https://youtu.be/ep-GFaKjUco?t=00h35m31s)

[fails and I think the expectation here](https://youtu.be/ep-GFaKjUco?t=00h35m34s)

[is that the value should remain at](https://youtu.be/ep-GFaKjUco?t=00h35m38s)

[zero right and the displayed value on](https://youtu.be/ep-GFaKjUco?t=00h35m43s)

[loss focus should probably revert back](https://youtu.be/ep-GFaKjUco?t=00h35m47s)

[to the old one I would](https://youtu.be/ep-GFaKjUco?t=00h35m49s)

[hope right because this is](https://youtu.be/ep-GFaKjUco?t=00h35m53s)

[wait value starts at](https://youtu.be/ep-GFaKjUco?t=00h35m58s)

[2.5 input 30 loss Focus so it should go](https://youtu.be/ep-GFaKjUco?t=00h36m00s)

[back to](https://youtu.be/ep-GFaKjUco?t=00h36m03s)

[2.5 so that should go](https://youtu.be/ep-GFaKjUco?t=00h36m05s)

[there value should start at](https://youtu.be/ep-GFaKjUco?t=00h36m08s)

[2.5 we move keyboard Focus we select all](https://youtu.be/ep-GFaKjUco?t=00h36m13s)

[we type in 30 we move keyboard Focus to](https://youtu.be/ep-GFaKjUco?t=00h36m17s)

[the button and then we expect that this](https://youtu.be/ep-GFaKjUco?t=00h36m20s)

[gets back down to](https://youtu.be/ep-GFaKjUco?t=00h36m23s)

[2.5 the bug report indicates that that](https://youtu.be/ep-GFaKjUco?t=00h36m25s)

[is not the case I'm sort of surprised at](https://youtu.be/ep-GFaKjUco?t=00h36m28s)

[that like I'm not completely surprised](https://youtu.be/ep-GFaKjUco?t=00h36m32s)

[the text isn't updating properly but I](https://youtu.be/ep-GFaKjUco?t=00h36m34s)

[I'm a little](https://youtu.be/ep-GFaKjUco?t=00h36m38s)

[surprised we need to call that](https://youtu.be/ep-GFaKjUco?t=00h36m39s)

[coer okay so](https://youtu.be/ep-GFaKjUco?t=00h36m42s)

[that see does that align with the](https://youtu.be/ep-GFaKjUco?t=00h36m45s)

[bug the bug view shows 30 value is 2.5](https://youtu.be/ep-GFaKjUco?t=00h36m48s)

[and I think the fix there is just this](https://youtu.be/ep-GFaKjUco?t=00h36m52s)

[right](https://youtu.be/ep-GFaKjUco?t=00h36m57s)

[is on Lost Focus always set the text](https://youtu.be/ep-GFaKjUco?t=00h37m00s)

[back but the value should should already](https://youtu.be/ep-GFaKjUco?t=00h37m04s)

[be coerced if we do](https://youtu.be/ep-GFaKjUco?t=00h37m07s)

[that I'm wondering if that coerced call](https://youtu.be/ep-GFaKjUco?t=00h37m10s)

[is being is doubling up because set](https://youtu.be/ep-GFaKjUco?t=00h37m13s)

[value and Set current value I thought](https://youtu.be/ep-GFaKjUco?t=00h37m16s)

[both went through the](https://youtu.be/ep-GFaKjUco?t=00h37m19s)

[coer ah they do okay so it's okay so the](https://youtu.be/ep-GFaKjUco?t=00h37m22s)

[lack of the else does there](https://youtu.be/ep-GFaKjUco?t=00h37m26s)

[okay value 2.5 input 30 increase button](https://youtu.be/ep-GFaKjUco?t=00h37m28s)

[click view shows 30 value should be](https://youtu.be/ep-GFaKjUco?t=00h37m33s)

[2.5 okay so let's now I need to actually](https://youtu.be/ep-GFaKjUco?t=00h37m37s)

[grab that increase button I'm going to](https://youtu.be/ep-GFaKjUco?t=00h37m39s)

[just go back up here and grab](https://youtu.be/ep-GFaKjUco?t=00h37m42s)

[this right so if we do](https://youtu.be/ep-GFaKjUco?t=00h37m49s)

[this boom like that and](https://youtu.be/ep-GFaKjUco?t=00h37m54s)

[then so the just want to make sure I got](https://youtu.be/ep-GFaKjUco?t=00h37m58s)

[the setup so value is 2.5 input 30 and](https://youtu.be/ep-GFaKjUco?t=00h38m01s)

[then rather than tabbing away what this](https://youtu.be/ep-GFaKjUco?t=00h38m05s)

[is doing um we want to](https://youtu.be/ep-GFaKjUco?t=00h38m07s)

[do uh plus button](https://youtu.be/ep-GFaKjUco?t=00h38m10s)

[click left](https://youtu.be/ep-GFaKjUco?t=00h38m14s)

[click right so we would like to do](https://youtu.be/ep-GFaKjUco?t=00h38m17s)

[that and then the expectation I would](https://youtu.be/ep-GFaKjUco?t=00h38m21s)

[assume is that neither one moves](https://youtu.be/ep-GFaKjUco?t=00h38m24s)

[right](https://youtu.be/ep-GFaKjUco?t=00h38m28s)

[um I'm not entirely clear that the text](https://youtu.be/ep-GFaKjUco?t=00h38m33s)

[should change on this one I kind of feel](https://youtu.be/ep-GFaKjUco?t=00h38m36s)

[like the text should remain where it was](https://youtu.be/ep-GFaKjUco?t=00h38m38s)

[at but the value absolutely shouldn't](https://youtu.be/ep-GFaKjUco?t=00h38m43s)

[change so I'm gonna I think my](https://youtu.be/ep-GFaKjUco?t=00h38m46s)

[expectation here is](https://youtu.be/ep-GFaKjUco?t=00h38m49s)

[this I do love some unit testing yes](https://youtu.be/ep-GFaKjUco?t=00h38m52s)

[this is kind of unit testing this is](https://youtu.be/ep-GFaKjUco?t=00h38m55s)

[unit testing where we actually spawn the](https://youtu.be/ep-GFaKjUco?t=00h38m57s)

[window](https://youtu.be/ep-GFaKjUco?t=00h39m02s)

[okay okay so I think this this all works](https://youtu.be/ep-GFaKjUco?t=00h39m05s)

[okay so let's just clean this up to](https://youtu.be/ep-GFaKjUco?t=00h39m08s)

[cover the user](https://youtu.be/ep-GFaKjUco?t=00h39m10s)

[cases right I don't think we need we](https://youtu.be/ep-GFaKjUco?t=00h39m12s)

[care about the first case because the](https://youtu.be/ep-GFaKjUco?t=00h39m14s)

[first case was working even with us](https://youtu.be/ep-GFaKjUco?t=00h39m16s)

[doing nothing right but we do need a](https://youtu.be/ep-GFaKjUco?t=00h39m18s)

[test case for both of these to cover to](https://youtu.be/ep-GFaKjUco?t=00h39m21s)

[cover these cases and I'm trying to](https://youtu.be/ep-GFaKjUco?t=00h39m24s)

[decide if they should be one test or two](https://youtu.be/ep-GFaKjUco?t=00h39m25s)

[I think they should be two tests because](https://youtu.be/ep-GFaKjUco?t=00h39m29s)

[the the ACT portion of the test is very](https://youtu.be/ep-GFaKjUco?t=00h39m32s)

[different between the two of them even](https://youtu.be/ep-GFaKjUco?t=00h39m34s)

[if the setup is the same so we'll we'll](https://youtu.be/ep-GFaKjUco?t=00h39m36s)

[start with leaving this one as is and we](https://youtu.be/ep-GFaKjUco?t=00h39m39s)

[will say](https://youtu.be/ep-GFaKjUco?t=00h39m42s)

[um](https://youtu.be/ep-GFaKjUco?t=00h39m45s)

[uh uh let's do](https://youtu.be/ep-GFaKjUco?t=00h39m48s)

[this](https://youtu.be/ep-GFaKjUco?t=00h39m51s)

[uh increase button click](https://youtu.be/ep-GFaKjUco?t=00h39m53s)

[uh when text is](https://youtu.be/ep-GFaKjUco?t=00h39m58s)

[above](https://youtu.be/ep-GFaKjUco?t=00h40m01s)

[maximum uh does not increase](https://youtu.be/ep-GFaKjUco?t=00h40m04s)

[value](https://youtu.be/ep-GFaKjUco?t=00h40m10s)

[okay so that goes something like this](https://youtu.be/ep-GFaKjUco?t=00h40m14s)

[um uh let's see because](https://youtu.be/ep-GFaKjUco?t=00h40m20s)

[the focus has not left the up down](https://youtu.be/ep-GFaKjUco?t=00h40m23s)

[control we don't override the text](https://youtu.be/ep-GFaKjUco?t=00h40m30s)

[yet uh we don't expect the](https://youtu.be/ep-GFaKjUco?t=00h40m37s)

[text change right future Kevin just](https://youtu.be/ep-GFaKjUco?t=00h40m42s)

[needs to remember what current Kevin is](https://youtu.be/ep-GFaKjUco?t=00h40m46s)

[thinking that is that is what we are](https://youtu.be/ep-GFaKjUco?t=00h40m47s)

[doing here right okay so then](https://youtu.be/ep-GFaKjUco?t=00h40m50s)

[uh lost](https://youtu.be/ep-GFaKjUco?t=00h40m55s)

[Focus uh when text is above](https://youtu.be/ep-GFaKjUco?t=00h40m59s)

[maximum uh reverts](https://youtu.be/ep-GFaKjUco?t=00h41m04s)

[to original value right so this we're](https://youtu.be/ep-GFaKjUco?t=00h41m08s)

[going to get rid of this one here and](https://youtu.be/ep-GFaKjUco?t=00h41m12s)

[then down here we want to put this back](https://youtu.be/ep-GFaKjUco?t=00h41m15s)

[get rid of this we don't need the](https://youtu.be/ep-GFaKjUco?t=00h41m17s)

[increase button on this test so we want](https://youtu.be/ep-GFaKjUco?t=00h41m20s)

[to set the](https://youtu.be/ep-GFaKjUco?t=00h41m22s)

[focus replace it with 30 and then the](https://youtu.be/ep-GFaKjUco?t=00h41m23s)

[expectation here is that this does](https://youtu.be/ep-GFaKjUco?t=00h41m26s)

[revert the value so we get rid of that](https://youtu.be/ep-GFaKjUco?t=00h41m28s)

[comment that on Lost Focus](https://youtu.be/ep-GFaKjUco?t=00h41m30s)

[here should](https://youtu.be/ep-GFaKjUco?t=00h41m33s)

[uh should reset the text value back and](https://youtu.be/ep-GFaKjUco?t=00h41m37s)

[the value should remain at two and a](https://youtu.be/ep-GFaKjUco?t=00h41m39s)

[half right](https://youtu.be/ep-GFaKjUco?t=00h41m42s)

[okay and then I think just because it](https://youtu.be/ep-GFaKjUco?t=00h41m44s)

[was called out in the pr let's just](https://youtu.be/ep-GFaKjUco?t=00h41m47s)

[uh maybe maybe let's Data Drive this](https://youtu.be/ep-GFaKjUco?t=00h42m00s)

[sucker a little](https://youtu.be/ep-GFaKjUco?t=00h42m03s)

[bit Theory and we'll change it when text](https://youtu.be/ep-GFaKjUco?t=00h42m05s)

[is](https://youtu.be/ep-GFaKjUco?t=00h42m09s)

[invalid I'll put an underscore](https://youtu.be/ep-GFaKjUco?t=00h42m12s)

[there](https://youtu.be/ep-GFaKjUco?t=00h42m15s)

[uh right just to separate out the](https://youtu.be/ep-GFaKjUco?t=00h42m18s)

[difference in the portions of the](https://youtu.be/ep-GFaKjUco?t=00h42m21s)

[test what are you squawking about oh](https://youtu.be/ep-GFaKjUco?t=00h42m24s)

[yeah yeah yeah so](https://youtu.be/ep-GFaKjUco?t=00h42m27s)

[string uh input text we're going to do](https://youtu.be/ep-GFaKjUco?t=00h42m30s)

[this and we're going to change this to](https://youtu.be/ep-GFaKjUco?t=00h42m35s)

[be put text I'm actually going to be](https://youtu.be/ep-GFaKjUco?t=00h42m43s)

[curious I think this works just](https://youtu.be/ep-GFaKjUco?t=00h42m48s)

[fine because the type isn't going to be](https://youtu.be/ep-GFaKjUco?t=00h42m52s)

[a](https://youtu.be/ep-GFaKjUco?t=00h42m55s)

[uh I just want](https://youtu.be/ep-GFaKjUco?t=00h42m59s)

[to why that thing isn't going to this](https://youtu.be/ep-GFaKjUco?t=00h43m02s)

[extension method anymore uh let's see](https://youtu.be/ep-GFaKjUco?t=00h43m05s)

[pulls out the text Parts argument get](https://youtu.be/ep-GFaKjUco?t=00h43m08s)

[argument yeah it'll two- string it so](https://youtu.be/ep-GFaKjUco?t=00h43m13s)

[it'll be fine it'll be fine okay so this](https://youtu.be/ep-GFaKjUco?t=00h43m15s)

[is going to be inline data of 30 right](https://youtu.be/ep-GFaKjUco?t=00h43m18s)

[because that's one of the things then we](https://youtu.be/ep-GFaKjUco?t=00h43m23s)

[should do inline data of](https://youtu.be/ep-GFaKjUco?t=00h43m24s)

[of know ABC right something clearly](https://youtu.be/ep-GFaKjUco?t=00h43m27s)

[invalid um there another case that I](https://youtu.be/ep-GFaKjUco?t=00h43m35s)

[want to](https://youtu.be/ep-GFaKjUco?t=00h43m38s)

[test I think just to be real clear I](https://youtu.be/ep-GFaKjUco?t=00h43m42s)

[also want to do](https://youtu.be/ep-GFaKjUco?t=00h43m45s)

[2ab right or 2 a something that clearly](https://youtu.be/ep-GFaKjUco?t=00h43m49s)

[shouldn't do it I I'm I'm only](https://youtu.be/ep-GFaKjUco?t=00h43m52s)

[questioning this here because these](https://youtu.be/ep-GFaKjUco?t=00h43m54s)

[tests are kind of expensive to run in](https://youtu.be/ep-GFaKjUco?t=00h43m56s)

[terms of execution time and so even](https://youtu.be/ep-GFaKjUco?t=00h43m58s)

[though with normal unit testing it would](https://youtu.be/ep-GFaKjUco?t=00h44m01s)

[be no question you throw everything in](https://youtu.be/ep-GFaKjUco?t=00h44m03s)

[here that you care to validate but here](https://youtu.be/ep-GFaKjUco?t=00h44m05s)

[I kind of question and go well each of](https://youtu.be/ep-GFaKjUco?t=00h44m07s)

[these tests can cost like two seconds](https://youtu.be/ep-GFaKjUco?t=00h44m09s)

[and it's very easy with these inline](https://youtu.be/ep-GFaKjUco?t=00h44m11s)

[datas and data driven test to just blow](https://youtu.be/ep-GFaKjUco?t=00h44m13s)

[this thing up but I think that's](https://youtu.be/ep-GFaKjUco?t=00h44m15s)

[probably](https://youtu.be/ep-GFaKjUco?t=00h44m17s)

[okay in this](https://youtu.be/ep-GFaKjUco?t=00h44m19s)

[situation okay let's make sure this test](https://youtu.be/ep-GFaKjUco?t=00h44m21s)

[passes show me green check](https://youtu.be/ep-GFaKjUco?t=00h44m25s)

[mark yay okay show me green check](https://youtu.be/ep-GFaKjUco?t=00h44m28s)

[mark concerns me that that green check](https://youtu.be/ep-GFaKjUco?t=00h44m39s)

[mark showed up before it actually](https://youtu.be/ep-GFaKjUco?t=00h44m41s)

[finished running all of](https://youtu.be/ep-GFaKjUco?t=00h44m44s)

[them I blame Visual Studio okay but the](https://youtu.be/ep-GFaKjUco?t=00h44m46s)

[important part of both of those things](https://youtu.be/ep-GFaKjUco?t=00h44m49s)

[passed so I think here the key change we](https://youtu.be/ep-GFaKjUco?t=00h44m51s)

[don't need to coers the Set current](https://youtu.be/ep-GFaKjUco?t=00h44m54s)

[value](https://youtu.be/ep-GFaKjUco?t=00h44m56s)

[will do the coercion for](https://youtu.be/ep-GFaKjUco?t=00h44m57s)

[us but the dropping of the else I think](https://youtu.be/ep-GFaKjUco?t=00h45m00s)

[is the key change there of making sure](https://youtu.be/ep-GFaKjUco?t=00h45m03s)

[that we do actually go back to the text](https://youtu.be/ep-GFaKjUco?t=00h45m05s)

[because value and actually this probably](https://youtu.be/ep-GFaKjUco?t=00h45m08s)

[warrants a](https://youtu.be/ep-GFaKjUco?t=00h45m10s)

[comment uh because](https://youtu.be/ep-GFaKjUco?t=00h45m11s)

[setting value property](https://youtu.be/ep-GFaKjUco?t=00h45m14s)

[will coers the](https://youtu.be/ep-GFaKjUco?t=00h45m18s)

[value](https://youtu.be/ep-GFaKjUco?t=00h45m21s)

[we sign back to the text box here okay I](https://youtu.be/ep-GFaKjUco?t=00h45m24s)

[think that is the key thing here is this](https://youtu.be/ep-GFaKjUco?t=00h45m33s)

[actually is being appropriately](https://youtu.be/ep-GFaKjUco?t=00h45m37s)

[clamped like I said I get a little](https://youtu.be/ep-GFaKjUco?t=00h45m40s)

[Twitchy when I see invocations of the](https://youtu.be/ep-GFaKjUco?t=00h45m42s)

[value change to the course value being](https://youtu.be/ep-GFaKjUco?t=00h45m44s)

[called from outside of the dependency](https://youtu.be/ep-GFaKjUco?t=00h45m46s)

[property and in general if I find myself](https://youtu.be/ep-GFaKjUco?t=00h45m49s)

[needing this I will extract this into](https://youtu.be/ep-GFaKjUco?t=00h45m51s)

[its own method and do it there the other](https://youtu.be/ep-GFaKjUco?t=00h45m53s)

[thing is the dependency properties often](https://youtu.be/ep-GFaKjUco?t=00h45m56s)

[times will cause boxing to occur because](https://youtu.be/ep-GFaKjUco?t=00h45m59s)

[we have in this case things like](https://youtu.be/ep-GFaKjUco?t=00h46m02s)

[decimals being shoved into objects it's](https://youtu.be/ep-GFaKjUco?t=00h46m05s)

[like it's a little wasteful to to box it](https://youtu.be/ep-GFaKjUco?t=00h46m07s)

[when when the alternative is just](https://youtu.be/ep-GFaKjUco?t=00h46m10s)

[refactor okay but I think that's better](https://youtu.be/ep-GFaKjUco?t=00h46m12s)

[let check](https://youtu.be/ep-GFaKjUco?t=00h46m15s)

[here](https://youtu.be/ep-GFaKjUco?t=00h46m20s)

[okay let's see adding UI tests](https://youtu.be/ep-GFaKjUco?t=00h46m23s)

[remove the uh direct](https://youtu.be/ep-GFaKjUco?t=00h46m27s)

[co uh call as it will be handled by the](https://youtu.be/ep-GFaKjUco?t=00h46m32s)

[dependency property there we go that](https://youtu.be/ep-GFaKjUco?t=00h46m39s)

[makes me that makes me feel warm and](https://youtu.be/ep-GFaKjUco?t=00h46m42s)

[fuzzy now we will push](https://youtu.be/ep-GFaKjUco?t=00h46m44s)

[that and](https://youtu.be/ep-GFaKjUco?t=00h46m51s)

[then open](https://youtu.be/ep-GFaKjUco?t=00h46m53s)

[uh let's see we will enable auto merge](https://youtu.be/ep-GFaKjUco?t=00h46m59s)

[and then I think there's no reason I](https://youtu.be/ep-GFaKjUco?t=00h47m02s)

[can't just blind to prove](https://youtu.be/ep-GFaKjUco?t=00h47m03s)

[this because we kind of just did this so](https://youtu.be/ep-GFaKjUco?t=00h47m05s)

[the two changes here are this is](https://youtu.be/ep-GFaKjUco?t=00h47m08s)

[unrelated to the change just because I I](https://youtu.be/ep-GFaKjUco?t=00h47m10s)

[noticed](https://youtu.be/ep-GFaKjUco?t=00h47m13s)

[it uh did I just miss it where I added](https://youtu.be/ep-GFaKjUco?t=00h47m15s)

[test there my added test Okay](https://youtu.be/ep-GFaKjUco?t=00h47m19s)

[cool so we're going to do that we're](https://youtu.be/ep-GFaKjUco?t=00h47m22s)

[going to do that](https://youtu.be/ep-GFaKjUco?t=00h47m24s)

[uh let's](https://youtu.be/ep-GFaKjUco?t=00h47m29s)

[see](https://youtu.be/ep-GFaKjUco?t=00h47m33s)

[uh](https://youtu.be/ep-GFaKjUco?t=00h47m38s)

[well boom do](https://youtu.be/ep-GFaKjUco?t=00h47m41s)

[that and then that guy will rock and](https://youtu.be/ep-GFaKjUco?t=00h47m46s)

[roll and so that will get it into 2](https://youtu.be/ep-GFaKjUco?t=00h47m48s)

[53 and yeah so there's a handful of](https://youtu.be/ep-GFaKjUco?t=00h47m52s)

[things in here we may go through and try](https://youtu.be/ep-GFaKjUco?t=00h47m54s)

[and address but I think for the most](https://youtu.be/ep-GFaKjUco?t=00h47m56s)

[part these ones are both going to go](https://youtu.be/ep-GFaKjUco?t=00h47m57s)

[through and](https://youtu.be/ep-GFaKjUco?t=00h47m59s)

[then off to the race as we go okay uh](https://youtu.be/ep-GFaKjUco?t=00h48m00s)

[I'm gonna](https://youtu.be/ep-GFaKjUco?t=00h48m05s)

[put out of my way to the side uh go away](https://youtu.be/ep-GFaKjUco?t=00h48m06s)

[go away okay](https://youtu.be/ep-GFaKjUco?t=00h48m10s)

[so now for completely Switching](https://youtu.be/ep-GFaKjUco?t=00h48m12s)

[gears uh close close and we're going to](https://youtu.be/ep-GFaKjUco?t=00h48m15s)

[change this up okay](https://youtu.be/ep-GFaKjUco?t=00h48m19s)

[so this PR here this PR here looks weird](https://youtu.be/ep-GFaKjUco?t=00h48m21s)

[so I this one it gets vpac Kaylin](https://youtu.be/ep-GFaKjUco?t=00h48m25s)

[reviewed it left a bunch of comments um](https://youtu.be/ep-GFaKjUco?t=00h48m29s)

[this is the most important comment here](https://youtu.be/ep-GFaKjUco?t=00h48m32s)

[because this one is going to impact a](https://youtu.be/ep-GFaKjUco?t=00h48m34s)

[lot of things when you when you add to](https://youtu.be/ep-GFaKjUco?t=00h48m37s)

[to public Eno members and shared](https://youtu.be/ep-GFaKjUco?t=00h48m39s)

[libraries things go crazy right this](https://youtu.be/ep-GFaKjUco?t=00h48m41s)

[it's it's bad this is reimplementing](https://youtu.be/ep-GFaKjUco?t=00h48m45s)

[and I actually have to go](https://youtu.be/ep-GFaKjUco?t=00h48m49s)

[to uh squirrel Windows oh uh](https://youtu.be/ep-GFaKjUco?t=00h48m53s)

[doesn't work does](https://youtu.be/ep-GFaKjUco?t=00h48m57s)

[it if we go here because Cloud squirrel](https://youtu.be/ep-GFaKjUco?t=00h48m59s)

[forked squirrel windows we could kind of](https://youtu.be/ep-GFaKjUco?t=00h49m02s)

[look at the Docks here they don't really](https://youtu.be/ep-GFaKjUco?t=00h49m05s)

[describe it very](https://youtu.be/ep-GFaKjUco?t=00h49m08s)

[well uh where is the](https://youtu.be/ep-GFaKjUco?t=00h49m10s)

[MSI](https://youtu.be/ep-GFaKjUco?t=00h49m13s)

[bit they process update manager team](https://youtu.be/ep-GFaKjUco?t=00h49m17s)

[City blah blah machine white installs](https://youtu.be/ep-GFaKjUco?t=00h49m20s)

[this guy](https://youtu.be/ep-GFaKjUco?t=00h49m22s)

[here right uh](https://youtu.be/ep-GFaKjUco?t=00h49m24s)

[um](https://youtu.be/ep-GFaKjUco?t=00h49m31s)

[uh yeah so the idea here is this](https://youtu.be/ep-GFaKjUco?t=00h49m33s)

[generates an](https://youtu.be/ep-GFaKjUco?t=00h49m37s)

[MSI and the way the setup installers](https://youtu.be/ep-GFaKjUco?t=00h49m39s)

[work is your app gets installed](https://youtu.be/ep-GFaKjUco?t=00h49m43s)

[underneath Local app data right so it's](https://youtu.be/ep-GFaKjUco?t=00h49m45s)

[on a it's in a a user uh a per user](https://youtu.be/ep-GFaKjUco?t=00h49m47s)

[directory that's very important here one](https://youtu.be/ep-GFaKjUco?t=00h49m51s)

[because the user will have access or](https://youtu.be/ep-GFaKjUco?t=00h49m54s)

[will have right access access to it](https://youtu.be/ep-GFaKjUco?t=00h49m55s)

[enabling them to do the installs without](https://youtu.be/ep-GFaKjUco?t=00h49m57s)

[prompting a UAC right and there's a](https://youtu.be/ep-GFaKjUco?t=00h49m59s)

[several things inside of uh srel windows](https://youtu.be/ep-GFaKjUco?t=00h50m02s)

[and velop pack that at least at present](https://youtu.be/ep-GFaKjUco?t=00h50m06s)

[make that assumption that the installer](https://youtu.be/ep-GFaKjUco?t=00h50m09s)

[will have right access to the](https://youtu.be/ep-GFaKjUco?t=00h50m11s)

[applications directory because it it](https://youtu.be/ep-GFaKjUco?t=00h50m12s)

[needs right access it's installing an](https://youtu.be/ep-GFaKjUco?t=00h50m14s)

[app it has to put files](https://youtu.be/ep-GFaKjUco?t=00h50m16s)

[there what the machine wide install does](https://youtu.be/ep-GFaKjUco?t=00h50m18s)

[is it actually uh adds a registry key so](https://youtu.be/ep-GFaKjUco?t=00h50m21s)

[that this MSI will prompt the UAC prompt](https://youtu.be/ep-GFaKjUco?t=00h50m25s)

[because it's going to put in a registry](https://youtu.be/ep-GFaKjUco?t=00h50m28s)

[key under hkey local machine right and](https://youtu.be/ep-GFaKjUco?t=00h50m30s)

[actually let me just show this off some](https://youtu.be/ep-GFaKjUco?t=00h50m34s)

[people may not know what the registry is](https://youtu.be/ep-GFaKjUco?t=00h50m37s)

[okay right so you get to the registry by](https://youtu.be/ep-GFaKjUco?t=00h50m39s)

[pressing Windows key R and typing in](https://youtu.be/ep-GFaKjUco?t=00h50m41s)

[regge edit right that command](https://youtu.be/ep-GFaKjUco?t=00h50m44s)

[there it opens up a thing like this for](https://youtu.be/ep-GFaKjUco?t=00h50m48s)

[people who haven't seen the registry](https://youtu.be/ep-GFaKjUco?t=00h50m51s)

[before let me just give a a brief](https://youtu.be/ep-GFaKjUco?t=00h50m52s)

[rundown this is effect or I should say](https://youtu.be/ep-GFaKjUco?t=00h50m54s)

[this is old okay right registry has](https://youtu.be/ep-GFaKjUco?t=00h50m57s)

[existed I think since Windows](https://youtu.be/ep-GFaKjUco?t=00h51m01s)

[9x so Windows 95 I think may have been](https://youtu.be/ep-GFaKjUco?t=00h51m05s)

[the first version with it I can't](https://youtu.be/ep-GFaKjUco?t=00h51m09s)

[remember if it's older than that](https://youtu.be/ep-GFaKjUco?t=00h51m10s)

[regardless it's y old very very very old](https://youtu.be/ep-GFaKjUco?t=00h51m12s)

[but it is a place to be able to store](https://youtu.be/ep-GFaKjUco?t=00h51m15s)

[values and it's hierarchal kind of like](https://youtu.be/ep-GFaKjUco?t=00h51m18s)

[your your folders and files but instead](https://youtu.be/ep-GFaKjUco?t=00h51m21s)

[of folders and I realized these look](https://youtu.be/ep-GFaKjUco?t=00h51m24s)

[like folders because Microsoft gave them](https://youtu.be/ep-GFaKjUco?t=00h51m25s)

[a folder icon right so you can](https://youtu.be/ep-GFaKjUco?t=00h51m28s)

[conceptually think of them as folders](https://youtu.be/ep-GFaKjUco?t=00h51m31s)

[even though they're not folders right](https://youtu.be/ep-GFaKjUco?t=00h51m33s)

[inside of folders you have and let's get](https://youtu.be/ep-GFaKjUco?t=00h51m35s)

[down into something that actually has](https://youtu.be/ep-GFaKjUco?t=00h51m38s)

[something useful right you have values](https://youtu.be/ep-GFaKjUco?t=00h51m39s)

[right and these guys here can be](https://youtu.be/ep-GFaKjUco?t=00h51m43s)

[different types of values you can Source](https://youtu.be/ep-GFaKjUco?t=00h51m45s)

[strings binary data um 32bit numeric](https://youtu.be/ep-GFaKjUco?t=00h51m47s)

[64-bit numeric multiple strings and](https://youtu.be/ep-GFaKjUco?t=00h51m52s)

[expandable strings it's effectively a](https://youtu.be/ep-GFaKjUco?t=00h51m54s)

[really fancy key value store right but](https://youtu.be/ep-GFaKjUco?t=00h51m57s)

[there are a couple very important things](https://youtu.be/ep-GFaKjUco?t=00h52m01s)

[to note here for example the top level](https://youtu.be/ep-GFaKjUco?t=00h52m03s)

[items uh are referred to as uh hives](https://youtu.be/ep-GFaKjUco?t=00h52m06s)

[right so you will see people often](https://youtu.be/ep-GFaKjUco?t=00h52m11s)

[abbreviate these as H](https://youtu.be/ep-GFaKjUco?t=00h52m14s)

[KCU and HK LM right meaning the current](https://youtu.be/ep-GFaKjUco?t=00h52m17s)

[the H key for the current user and the](https://youtu.be/ep-GFaKjUco?t=00h52m22s)

[local machine functionally you can kind](https://youtu.be/ep-GFaKjUco?t=00h52m25s)

[of think of these at least in terms of](https://youtu.be/ep-GFaKjUco?t=00h52m27s)

[the way uh the installers look at these](https://youtu.be/ep-GFaKjUco?t=00h52m29s)

[is one of these is Machine level meaning](https://youtu.be/ep-GFaKjUco?t=00h52m32s)

[all users and one of these things is for](https://youtu.be/ep-GFaKjUco?t=00h52m34s)

[the current user there are magical](https://youtu.be/ep-GFaKjUco?t=00h52m37s)

[registry keypads that uh specify](https://youtu.be/ep-GFaKjUco?t=00h52m40s)

[programs that are going to run at](https://youtu.be/ep-GFaKjUco?t=00h52m44s)

[startup so hkey local machines software](https://youtu.be/ep-GFaKjUco?t=00h52m45s)

[Microsoft Windows current version run](https://youtu.be/ep-GFaKjUco?t=00h52m48s)

[right you can tell how many times I've](https://youtu.be/ep-GFaKjUco?t=00h52m51s)

[gone here because I rattled that off for](https://youtu.be/ep-GFaKjUco?t=00h52m53s)

[memory this is also the place where a](https://youtu.be/ep-GFaKjUco?t=00h52m57s)

[viruses and similar used to just love to](https://youtu.be/ep-GFaKjUco?t=00h53m01s)

[put themselves right because if you add](https://youtu.be/ep-GFaKjUco?t=00h53m03s)

[a particular little registry key in here](https://youtu.be/ep-GFaKjUco?t=00h53m06s)

[right these are things that are going to](https://youtu.be/ep-GFaKjUco?t=00h53m10s)

[run on Startup for example I run](https://youtu.be/ep-GFaKjUco?t=00h53m12s)

[everything I like everything everything](https://youtu.be/ep-GFaKjUco?t=00h53m15s)

[is my my Universal go-to search launcher](https://youtu.be/ep-GFaKjUco?t=00h53m17s)

[tool right it runs on Startup right I](https://youtu.be/ep-GFaKjUco?t=00h53m21s)

[didn't write this registry key when I](https://youtu.be/ep-GFaKjUco?t=00h53m24s)

[check the settings box that said run on](https://youtu.be/ep-GFaKjUco?t=00h53m26s)

[Startup it put that registry key in](https://youtu.be/ep-GFaKjUco?t=00h53m28s)

[there but that's functionally how it](https://youtu.be/ep-GFaKjUco?t=00h53m30s)

[works right and because I am inside of](https://youtu.be/ep-GFaKjUco?t=00h53m32s)

[uh local machine these are things that](https://youtu.be/ep-GFaKjUco?t=00h53m36s)

[are going to apply to all users now I'm](https://youtu.be/ep-GFaKjUco?t=00h53m38s)

[the only user on this box so current](https://youtu.be/ep-GFaKjUco?t=00h53m40s)

[user and all users is kind of](https://youtu.be/ep-GFaKjUco?t=00h53m43s)

[meaningless here but for some places](https://youtu.be/ep-GFaKjUco?t=00h53m44s)

[where there are multiple users on a](https://youtu.be/ep-GFaKjUco?t=00h53m46s)

[machine that makes a big difference](https://youtu.be/ep-GFaKjUco?t=00h53m47s)

[right but you have the same equivalent](https://youtu.be/ep-GFaKjUco?t=00h53m50s)

[run key underneath the current user Hive](https://youtu.be/ep-GFaKjUco?t=00h53m52s)

[what this MSI does is it injects a line](https://youtu.be/ep-GFaKjUco?t=00h53m55s)

[inside of that uh registry that will](https://youtu.be/ep-GFaKjUco?t=00h53m59s)

[invoke the setup](https://youtu.be/ep-GFaKjUco?t=00h54m03s)

[exe when the user logs in right so](https://youtu.be/ep-GFaKjUco?t=00h54m05s)

[because these these executions happen on](https://youtu.be/ep-GFaKjUco?t=00h54m08s)

[Startup and these are just arbitrary run](https://youtu.be/ep-GFaKjUco?t=00h54m11s)

[commands right that this is just on the](https://youtu.be/ep-GFaKjUco?t=00h54m13s)

[terminal this gets entered this thing](https://youtu.be/ep-GFaKjUco?t=00h54m16s)

[fires off and if we look at what the the](https://youtu.be/ep-GFaKjUco?t=00h54m18s)

[squirrel MSI does is it invokes the](https://youtu.be/ep-GFaKjUco?t=00h54m21s)

[setup exe but it passes an argument and](https://youtu.be/ep-GFaKjUco?t=00h54m23s)

[I think the argument is called like Dash](https://youtu.be/ep-GFaKjUco?t=00h54m26s)

[Das check install and check install just](https://youtu.be/ep-GFaKjUco?t=00h54m28s)

[says hey if I'm installed quick exit no](https://youtu.be/ep-GFaKjUco?t=00h54m31s)

[harm no foul all good right if I'm not](https://youtu.be/ep-GFaKjUco?t=00h54m35s)

[installed run the installer and actually](https://youtu.be/ep-GFaKjUco?t=00h54m38s)

[install the application so from a user](https://youtu.be/ep-GFaKjUco?t=00h54m40s)

[perspective what it looks like happens](https://youtu.be/ep-GFaKjUco?t=00h54m42s)

[after the MSI is run on next login poof](https://youtu.be/ep-GFaKjUco?t=00h54m45s)

[I magically get the application](https://youtu.be/ep-GFaKjUco?t=00h54m48s)

[installed huzzah right that's the way it](https://youtu.be/ep-GFaKjUco?t=00h54m50s)

[works it's kind of hacky right that's](https://youtu.be/ep-GFaKjUco?t=00h54m52s)

[not the way](https://youtu.be/ep-GFaKjUco?t=00h54m55s)

[that's not the way anybody expects an](https://youtu.be/ep-GFaKjUco?t=00h54m57s)

[all user install to work right when you](https://youtu.be/ep-GFaKjUco?t=00h54m59s)

[when you run it and say oh yeah just run](https://youtu.be/ep-GFaKjUco?t=00h55m03s)

[this MSI it magically works the other](https://youtu.be/ep-GFaKjUco?t=00h55m04s)

[big disadvantage is it means every user](https://youtu.be/ep-GFaKjUco?t=00h55m07s)

[that is on your machine ends up with its](https://youtu.be/ep-GFaKjUco?t=00h55m09s)

[own copy of the application so if you've](https://youtu.be/ep-GFaKjUco?t=00h55m11s)

[got a one gig application that's one gig](https://youtu.be/ep-GFaKjUco?t=00h55m14s)

[times however many users you](https://youtu.be/ep-GFaKjUco?t=00h55m16s)

[got hard drive space is cheap but for](https://youtu.be/ep-GFaKjUco?t=00h55m18s)

[some places that matters a lot right](https://youtu.be/ep-GFaKjUco?t=00h55m21s)

[like they've got a lot of users or](https://youtu.be/ep-GFaKjUco?t=00h55m23s)

[similar I had one place tell me they had](https://youtu.be/ep-GFaKjUco?t=00h55m25s)

[something like 500 users on the same](https://youtu.be/ep-GFaKjUco?t=00h55m26s)

[machine I'm like dear Heavens why and](https://youtu.be/ep-GFaKjUco?t=00h55m28s)

[you know it's like it's a a shared](https://youtu.be/ep-GFaKjUco?t=00h55m31s)

[terminal for blah blah blah blah blah](https://youtu.be/ep-GFaKjUco?t=00h55m32s)

[whatever so that's the way it works](https://youtu.be/ep-GFaKjUco?t=00h55m36s)

[that's the premise for where we're going](https://youtu.be/ep-GFaKjUco?t=00h55m39s)

[right](https://youtu.be/ep-GFaKjUco?t=00h55m41s)

[so Cloud squirrel ripped this out during](https://youtu.be/ep-GFaKjUco?t=00h55m43s)

[the V3 upgrade the V3 upgrade of cloud](https://youtu.be/ep-GFaKjUco?t=00h55m47s)

[squirrel is what got rebranded to velop](https://youtu.be/ep-GFaKjUco?t=00h55m50s)

[Pac so if you're on cloud squirrel Cloud](https://youtu.be/ep-GFaKjUco?t=00h55m51s)

[squirrel V3 and velop Pac are effective](https://youtu.be/ep-GFaKjUco?t=00h55m54s)

[the same thing just a different name](https://youtu.be/ep-GFaKjUco?t=00h55m56s)

[right there's some name space changes](https://youtu.be/ep-GFaKjUco?t=00h55m59s)

[and that kind of thing but it was](https://youtu.be/ep-GFaKjUco?t=00h56m00s)

[effectively just](https://youtu.be/ep-GFaKjUco?t=00h56m02s)

[rebranded but it the MSI thing was](https://youtu.be/ep-GFaKjUco?t=00h56m04s)

[dropped um as it was deemed a hack and a](https://youtu.be/ep-GFaKjUco?t=00h56m07s)

[pain in the butt to](https://youtu.be/ep-GFaKjUco?t=00h56m10s)

[maintain um I have a vested interest in](https://youtu.be/ep-GFaKjUco?t=00h56m12s)

[wanting it back talked to kayin he was](https://youtu.be/ep-GFaKjUco?t=00h56m15s)

[cool with it I was like you know what we](https://youtu.be/ep-GFaKjUco?t=00h56m17s)

[we still need to revisit the MSI a real](https://youtu.be/ep-GFaKjUco?t=00h56m19s)

[MSI uh and an all user install as a](https://youtu.be/ep-GFaKjUco?t=00h56m23s)

[long-term solution but in a short-term](https://youtu.be/ep-GFaKjUco?t=00h56m26s)

[solution um specifically because I was](https://youtu.be/ep-GFaKjUco?t=00h56m28s)

[trying to go through and eliminate](https://youtu.be/ep-GFaKjUco?t=00h56m31s)

[reasons why people wouldn't migrate off](https://youtu.be/ep-GFaKjUco?t=00h56m33s)

[a cloud squirrel on](https://youtu.be/ep-GFaKjUco?t=00h56m35s)

[developac right that's a thing people](https://youtu.be/ep-GFaKjUco?t=00h56m37s)

[had in Cloud squirrel it got taken away](https://youtu.be/ep-GFaKjUco?t=00h56m39s)

[there was at least one comment on](https://youtu.be/ep-GFaKjUco?t=00h56m43s)

[Discord about it and I'm like I don't](https://youtu.be/ep-GFaKjUco?t=00h56m44s)

[want to I don't want to have a stumbling](https://youtu.be/ep-GFaKjUco?t=00h56m46s)

[block for people migrating off of cloud](https://youtu.be/ep-GFaKjUco?t=00h56m49s)

[squirrel develop pack because](https://youtu.be/ep-GFaKjUco?t=00h56m51s)

[functionally it should be a drop in](https://youtu.be/ep-GFaKjUco?t=00h56m52s)

[replacement change any name spaces](https://youtu.be/ep-GFaKjUco?t=00h56m55s)

[you've got done that's the end goal and](https://youtu.be/ep-GFaKjUco?t=00h56m57s)

[it's not going to be perfect like](https://youtu.be/ep-GFaKjUco?t=00h57m00s)

[depending on how old a cloud squirrel](https://youtu.be/ep-GFaKjUco?t=00h57m01s)

[you're on if you're already on the V3](https://youtu.be/ep-GFaKjUco?t=00h57m03s)

[stuff it's pretty close but there are a](https://youtu.be/ep-GFaKjUco?t=00h57m04s)

[handful of API changes um that go in](https://youtu.be/ep-GFaKjUco?t=00h57m06s)

[there so all of that said I basically](https://youtu.be/ep-GFaKjUco?t=00h57m09s)

[pulled forward the cloud squirrel stuff](https://youtu.be/ep-GFaKjUco?t=00h57m12s)

[as best I could but I had to kind of](https://youtu.be/ep-GFaKjUco?t=00h57m15s)

[guess a little bit because some things](https://youtu.be/ep-GFaKjUco?t=00h57m17s)

[have gotten renamed some of the cheese](https://youtu.be/ep-GFaKjUco?t=00h57m19s)

[had moved and so yeah so kayn gave me a](https://youtu.be/ep-GFaKjUco?t=00h57m21s)

[good code review that's where we're](https://youtu.be/ep-GFaKjUco?t=00h57m25s)

[going let's go fix let's go fix up my](https://youtu.be/ep-GFaKjUco?t=00h57m27s)

[stuff right](https://youtu.be/ep-GFaKjUco?t=00h57m30s)

[so so we're going to come down](https://youtu.be/ep-GFaKjUco?t=00h57m33s)

[here and I want yeah reset local don't](https://youtu.be/ep-GFaKjUco?t=00h57m35s)

[know where my old one is and then I'm](https://youtu.be/ep-GFaKjUco?t=00h57m40s)

[going to pull up](https://youtu.be/ep-GFaKjUco?t=00h57m42s)

[develop](https://youtu.be/ep-GFaKjUco?t=00h57m44s)

[so hey no where's my pull](https://youtu.be/ep-GFaKjUco?t=00h57m48s)

[button uh](https://youtu.be/ep-GFaKjUco?t=00h57m51s)

[there just pull that up there we go then](https://youtu.be/ep-GFaKjUco?t=00h57m58s)

[we'll switch back sometimes it's easier](https://youtu.be/ep-GFaKjUco?t=00h58m01s)

[to just double click and have it do the](https://youtu.be/ep-GFaKjUco?t=00h58m02s)

[switch and pull at the same time okay so](https://youtu.be/ep-GFaKjUco?t=00h58m04s)

[I'm going to rebase because I](https://youtu.be/ep-GFaKjUco?t=00h58m06s)

[instinctively rebase](https://youtu.be/ep-GFaKjUco?t=00h58m07s)

[always okay now let's go through and](https://youtu.be/ep-GFaKjUco?t=00h58m09s)

[address the pr comments I think I can](https://youtu.be/ep-GFaKjUco?t=00h58m12s)

[get those from right here if I'm not](https://youtu.be/ep-GFaKjUco?t=00h58m16s)

[mistaken let's see](https://youtu.be/ep-GFaKjUco?t=00h58m17s)

[uh those are all the renovate stuff](https://youtu.be/ep-GFaKjUco?t=00h58m23s)

[doing updates which is](https://youtu.be/ep-GFaKjUco?t=00h58m26s)

[great uh this one here great so here's](https://youtu.be/ep-GFaKjUco?t=00h58m28s)

[what we got uh suggestion to rename from](https://youtu.be/ep-GFaKjUco?t=00h58m32s)

[MSI to MSI deployment tool I think I](https://youtu.be/ep-GFaKjUco?t=00h58m36s)

[like that especially with the comment of](https://youtu.be/ep-GFaKjUco?t=00h58m39s)

[we want](https://youtu.be/ep-GFaKjUco?t=00h58m42s)

[to uh at some point bring in](https://youtu.be/ep-GFaKjUco?t=00h58m44s)

[real a real MSI that actually works the](https://youtu.be/ep-GFaKjUco?t=00h58m48s)

[way it should right this is calling this](https://youtu.be/ep-GFaKjUco?t=00h58m51s)

[a deployment to is probably much more](https://youtu.be/ep-GFaKjUco?t=00h58m55s)

[accurate so uh why am I can I just go](https://youtu.be/ep-GFaKjUco?t=00h58m57s)

[control shift oh I can sweet control](https://youtu.be/ep-GFaKjUco?t=00h59m02s)

[shift e works from review thing as well](https://youtu.be/ep-GFaKjUco?t=00h59m05s)

[yes yes I love it](https://youtu.be/ep-GFaKjUco?t=00h59m08s)

[uh um no I don't really want you to do](https://youtu.be/ep-GFaKjUco?t=00h59m15s)

[that thank you for asking though before](https://youtu.be/ep-GFaKjUco?t=00h59m18s)

[just doing it Visual Studio I appreciate](https://youtu.be/ep-GFaKjUco?t=00h59m21s)

[that let's see vpac asset is where we're](https://youtu.be/ep-GFaKjUco?t=00h59m23s)

[going](https://youtu.be/ep-GFaKjUco?t=00h59m25s)

[lellow pack](https://youtu.be/ep-GFaKjUco?t=00h59m28s)

[asset that is not the right](https://youtu.be/ep-GFaKjUco?t=00h59m31s)

[one uh C](https://youtu.be/ep-GFaKjUco?t=00h59m35s)

[lib yeah this one boom okay](https://youtu.be/ep-GFaKjUco?t=00h59m40s)

[so](https://youtu.be/ep-GFaKjUco?t=00h59m44s)

[uh](https://youtu.be/ep-GFaKjUco?t=00h59m46s)

[a for the](https://youtu.be/ep-GFaKjUco?t=00h59m50s)

[application deployment tool](https://youtu.be/ep-GFaKjUco?t=00h59m53s)

[and I think what I'm going to end up](https://youtu.be/ep-GFaKjUco?t=00h59m56s)

[doing is going and writing some docs for](https://youtu.be/ep-GFaKjUco?t=00h59m58s)

[this as well because I want people to do](https://youtu.be/ep-GFaKjUco?t=01h00m01s)

[it something else I really want to get](https://youtu.be/ep-GFaKjUco?t=01h00m02s)

[to is getting nullability turned on](https://youtu.be/ep-GFaKjUco?t=01h00m04s)

[everywhere I've started turning it on um](https://youtu.be/ep-GFaKjUco?t=01h00m07s)

[in places but it there like there's a](https://youtu.be/ep-GFaKjUco?t=01h00m11s)

[lot of work there right and I would](https://youtu.be/ep-GFaKjUco?t=01h00m14s)

[right now people it the velop pack is uh](https://youtu.be/ep-GFaKjUco?t=01h00m16s)

[0. like 1053 I think his latest release](https://youtu.be/ep-GFaKjUco?t=01h00m20s)

[um we're kind of using the hey we're pre](https://youtu.be/ep-GFaKjUco?t=01h00m24s)

[1.0 to make some breaking API changes](https://youtu.be/ep-GFaKjUco?t=01h00m27s)

[like renaming things that were named](https://youtu.be/ep-GFaKjUco?t=01h00m31s)

[poorly before because it kind of feels](https://youtu.be/ep-GFaKjUco?t=01h00m34s)

[like now's the opportunity to have](https://youtu.be/ep-GFaKjUco?t=01h00m36s)

[some uh back compat breaking changes and](https://youtu.be/ep-GFaKjUco?t=01h00m38s)

[nullability is one of those things that](https://youtu.be/ep-GFaKjUco?t=01h00m42s)

[I would like to kind of squeeze in](https://youtu.be/ep-GFaKjUco?t=01h00m43s)

[before we get the 1.0 release I don't](https://youtu.be/ep-GFaKjUco?t=01h00m45s)

[know if I will but I want to start](https://youtu.be/ep-GFaKjUco?t=01h00m47s)

[getting more of it in as I can um](https://youtu.be/ep-GFaKjUco?t=01h00m48s)

[because anybody with warnings as airs on](https://youtu.be/ep-GFaKjUco?t=01h00m51s)

[as it gets turned on it will start](https://youtu.be/ep-GFaKjUco?t=01h00m54s)

[triggering](https://youtu.be/ep-GFaKjUco?t=01h00m56s)

[those okay there's](https://youtu.be/ep-GFaKjUco?t=01h01m00s)

[that that's easy I don't think that](https://youtu.be/ep-GFaKjUco?t=01h01m03s)

[broke anything but let's](https://youtu.be/ep-GFaKjUco?t=01h01m06s)

[just let's just compile this sucker up](https://youtu.be/ep-GFaKjUco?t=01h01m11s)

[it is also going to cause a a need a](https://youtu.be/ep-GFaKjUco?t=01h01m14s)

[change to occur](https://youtu.be/ep-GFaKjUco?t=01h01m17s)

[in it](https://youtu.be/ep-GFaKjUco?t=01h01m19s)

[building not oh it's not building](https://youtu.be/ep-GFaKjUco?t=01h01m23s)

[because I don't have the solution open](https://youtu.be/ep-GFaKjUco?t=01h01m25s)

[that's probably why my search was so](https://youtu.be/ep-GFaKjUco?t=01h01m28s)

[bad let's try this](https://youtu.be/ep-GFaKjUco?t=01h01m30s)

[again there we go compile](https://youtu.be/ep-GFaKjUco?t=01h01m32s)

[please um because we are going to need](https://youtu.be/ep-GFaKjUco?t=01h01m36s)

[to to mimic this uh asset type out on](https://youtu.be/ep-GFaKjUco?t=01h01m39s)

[the low side of the fence something I'm](https://youtu.be/ep-GFaKjUco?t=01h01m44s)

[hoping we get to tonight we'll see we'll](https://youtu.be/ep-GFaKjUco?t=01h01m47s)

[see how long some of this stuff takes](https://youtu.be/ep-GFaKjUco?t=01h01m49s)

[me uh let's see yeah that's kind of what](https://youtu.be/ep-GFaKjUco?t=01h01m51s)

[I thought I knew I used it somewhere](https://youtu.be/ep-GFaKjUco?t=01h01m54s)

[be dumb to add it uh should remove](https://youtu.be/ep-GFaKjUco?t=01h01m56s)

[property now these ones here I think are](https://youtu.be/ep-GFaKjUco?t=01h01m59s)

[actually tied to ipac options and I](https://youtu.be/ep-GFaKjUco?t=01h02m01s)

[think I made a mistake because we have](https://youtu.be/ep-GFaKjUco?t=01h02m05s)

[a we have an auto mapping tool inside of](https://youtu.be/ep-GFaKjUco?t=01h02m10s)

[here that Maps uh properties from the](https://youtu.be/ep-GFaKjUco?t=01h02m14s)

[CLI commands into options classes which](https://youtu.be/ep-GFaKjUco?t=01h02m17s)

[is really great because we get compile](https://youtu.be/ep-GFaKjUco?t=01h02m20s)

[time checking but I think](https://youtu.be/ep-GFaKjUco?t=01h02m22s)

[it's I'm not I don't use it a lot this](https://youtu.be/ep-GFaKjUco?t=01h02m24s)

[is Project is the first time I've used](https://youtu.be/ep-GFaKjUco?t=01h02m27s)

[it and so I think I I went slightly](https://youtu.be/ep-GFaKjUco?t=01h02m28s)

[astray on](https://youtu.be/ep-GFaKjUco?t=01h02m32s)

[it uh because Linux pack options and OSX](https://youtu.be/ep-GFaKjUco?t=01h02m33s)

[pack options and I kind of wondered](https://youtu.be/ep-GFaKjUco?t=01h02m36s)

[about these when I did](https://youtu.be/ep-GFaKjUco?t=01h02m38s)

[it](https://youtu.be/ep-GFaKjUco?t=01h02m39s)

[um uh pack options I it felt a little](https://youtu.be/ep-GFaKjUco?t=01h02m43s)

[off and it was one of those things that](https://youtu.be/ep-GFaKjUco?t=01h02m46s)

[that should have been a clue to me if it](https://youtu.be/ep-GFaKjUco?t=01h02m48s)

[feels off it probably](https://youtu.be/ep-GFaKjUco?t=01h02m49s)

[is and then OSX](https://youtu.be/ep-GFaKjUco?t=01h02m52s)

[options because it doesn't make sense to](https://youtu.be/ep-GFaKjUco?t=01h02m56s)

[have a build MSI for OSX or Linux right](https://youtu.be/ep-GFaKjUco?t=01h02m58s)

[like MSI is by definition a Windows](https://youtu.be/ep-GFaKjUco?t=01h03m01s)

[installer](https://youtu.be/ep-GFaKjUco?t=01h03m04s)

[technology yeah and this is what this is](https://youtu.be/ep-GFaKjUco?t=01h03m07s)

[I I think what where I came down to why](https://youtu.be/ep-GFaKjUco?t=01h03m10s)

[I wanted it there is because I options](https://youtu.be/ep-GFaKjUco?t=01h03m12s)

[is of type interface but I think that](https://youtu.be/ep-GFaKjUco?t=01h03m14s)

[gets to be](https://youtu.be/ep-GFaKjUco?t=01h03m18s)

[here](https://youtu.be/ep-GFaKjUco?t=01h03m20s)

[um yeah so this is effectively pull](https://youtu.be/ep-GFaKjUco?t=01h03m22s)

[pulling this forward so they recommended](https://youtu.be/ep-GFaKjUco?t=01h03m25s)

[or recommendation from kin on this](https://youtu.be/ep-GFaKjUco?t=01h03m29s)

[guy so I added a create MSI package and](https://youtu.be/ep-GFaKjUco?t=01h03m36s)

[the the argument was this shouldn't live](https://youtu.be/ep-GFaKjUco?t=01h03m41s)

[down here in baseland and I'm trying to](https://youtu.be/ep-GFaKjUco?t=01h03m43s)

[remember why I put it down here now okay](https://youtu.be/ep-GFaKjUco?t=01h03m47s)

[because there was there's this but what](https://youtu.be/ep-GFaKjUco?t=01h03m50s)

[does it actually need](https://youtu.be/ep-GFaKjUco?t=01h03m54s)

[I don't know that it actually needs to](https://youtu.be/ep-GFaKjUco?t=01h03m58s)

[live down here so let's pull this up](https://youtu.be/ep-GFaKjUco?t=01h04m01s)

[because this guy](https://youtu.be/ep-GFaKjUco?t=01h04m04s)

[here already has create release](https://youtu.be/ep-GFaKjUco?t=01h04m07s)

[package and I think that's probably good](https://youtu.be/ep-GFaKjUco?t=01h04m15s)

[enough no build setup package is what we](https://youtu.be/ep-GFaKjUco?t=01h04m20s)

[want so if there's no install you don't](https://youtu.be/ep-GFaKjUco?t=01h04m23s)

[get your MSI because the without the MSI](https://youtu.be/ep-GFaKjUco?t=01h04m26s)

[needs to reference the XE and bundle it](https://youtu.be/ep-GFaKjUco?t=01h04m29s)

[in so this create setup package is](https://youtu.be/ep-GFaKjUco?t=01h04m31s)

[actually what we want to override and](https://youtu.be/ep-GFaKjUco?t=01h04m35s)

[this guy has three overrides one of](https://youtu.be/ep-GFaKjUco?t=01h04m38s)

[which is Windows and I believe the](https://youtu.be/ep-GFaKjUco?t=01h04m40s)

[argument here](https://youtu.be/ep-GFaKjUco?t=01h04m42s)

[is we want to effectively call into this](https://youtu.be/ep-GFaKjUco?t=01h04m45s)

[now we've already](https://youtu.be/ep-GFaKjUco?t=01h04m48s)

[done the no installer check by virtue of](https://youtu.be/ep-GFaKjUco?t=01h04m50s)

[getting here and we don't need to check](https://youtu.be/ep-GFaKjUco?t=01h04m53s)

[Target OS we're now in a Windows](https://youtu.be/ep-GFaKjUco?t=01h04m55s)

[specific](https://youtu.be/ep-GFaKjUco?t=01h04m58s)

[one uh let's](https://youtu.be/ep-GFaKjUco?t=01h04m59s)

[see async](https://youtu.be/ep-GFaKjUco?t=01h05m02s)

[task now that eliminates](https://youtu.be/ep-GFaKjUco?t=01h05m05s)

[this and I think what I want to do is](https://youtu.be/ep-GFaKjUco?t=01h05m09s)

[pull this sucker out and put this guy](https://youtu.be/ep-GFaKjUco?t=01h05m13s)

[here right of and I think I've got](https://youtu.be/ep-GFaKjUco?t=01h05m16s)

[enough to do all of this information I](https://youtu.be/ep-GFaKjUco?t=01h05m20s)

[just need to find the right stuff](https://youtu.be/ep-GFaKjUco?t=01h05m23s)

[so if we go back into the](https://youtu.be/ep-GFaKjUco?t=01h05m28s)

[base nope back into the base I want to](https://youtu.be/ep-GFaKjUco?t=01h05m32s)

[go back up where I cut](https://youtu.be/ep-GFaKjUco?t=01h05m36s)

[this so I am](https://youtu.be/ep-GFaKjUco?t=01h05m40s)

[looking for what was the first value we](https://youtu.be/ep-GFaKjUco?t=01h05m44s)

[needed pack ID and channel ID so pack ID](https://youtu.be/ep-GFaKjUco?t=01h05m47s)

[was coming from](https://youtu.be/ep-GFaKjUco?t=01h05m51s)

[where previously I should probably look](https://youtu.be/ep-GFaKjUco?t=01h05m53s)

[at the diff that I just](https://youtu.be/ep-GFaKjUco?t=01h05m55s)

[caused before I was getting my pack ID](https://youtu.be/ep-GFaKjUco?t=01h05m57s)

[from let's see package](https://youtu.be/ep-GFaKjUco?t=01h06m02s)

[Builder that's really tiny let me make](https://youtu.be/ep-GFaKjUco?t=01h06m05s)

[that](https://youtu.be/ep-GFaKjUco?t=01h06m08s)

[bigger we go okay so before my first](https://youtu.be/ep-GFaKjUco?t=01h06m09s)

[parameter uh was create MSI package but](https://youtu.be/ep-GFaKjUco?t=01h06m15s)

[pack ID came from where](https://youtu.be/ep-GFaKjUco?t=01h06m18s)

[P ID existed and was](https://youtu.be/ep-GFaKjUco?t=01h06m26s)

[being passed through okay so if pack ID](https://youtu.be/ep-GFaKjUco?t=01h06m31s)

[was being passed through it must be](https://youtu.be/ep-GFaKjUco?t=01h06m34s)

[declared higher](https://youtu.be/ep-GFaKjUco?t=01h06m36s)

[up pack ID so this is just options pack](https://youtu.be/ep-GFaKjUco?t=01h06m37s)

[ID so that's that's easy enough to](https://youtu.be/ep-GFaKjUco?t=01h06m41s)

[achieve we can come over here boom and](https://youtu.be/ep-GFaKjUco?t=01h06m44s)

[this is capital O](https://youtu.be/ep-GFaKjUco?t=01h06m48s)

[options great where did Channel come](https://youtu.be/ep-GFaKjUco?t=01h06m50s)

[from](https://youtu.be/ep-GFaKjUco?t=01h06m52s)

[uh options channel has](https://youtu.be/ep-GFaKjUco?t=01h06m58s)

[that boom uh once again need to](https://youtu.be/ep-GFaKjUco?t=01h07m01s)

[capitalize it okay so that gets me to](https://youtu.be/ep-GFaKjUco?t=01h07m05s)

[there uh asset](https://youtu.be/ep-GFaKjUco?t=01h07m08s)

[cash this one's more interesting let's](https://youtu.be/ep-GFaKjUco?t=01h07m16s)

[come back to it set up exe path](https://youtu.be/ep-GFaKjUco?t=01h07m18s)

[um this no longer needs to be override](https://youtu.be/ep-GFaKjUco?t=01h07m22s)

[and this could be](https://youtu.be/ep-GFaKjUco?t=01h07m25s)

[private](https://youtu.be/ep-GFaKjUco?t=01h07m27s)

[um I don't think we care about any of](https://youtu.be/ep-GFaKjUco?t=01h07m37s)

[these let's](https://youtu.be/ep-GFaKjUco?t=01h07m45s)

[see oh this is uh turn task completed](https://youtu.be/ep-GFaKjUco?t=01h07m47s)

[task this was something else I was](https://youtu.be/ep-GFaKjUco?t=01h07m53s)

[contemplating going and cleaning up too](https://youtu.be/ep-GFaKjUco?t=01h07m54s)

[at some point](https://youtu.be/ep-GFaKjUco?t=01h07m57s)

[um oh interesting why does it think that](https://youtu.be/ep-GFaKjUco?t=01h08m02s)

[this is reachable on all](https://youtu.be/ep-GFaKjUco?t=01h08m05s)

[platforms honestly I don't know](https://youtu.be/ep-GFaKjUco?t=01h08m12s)

[why this is just a it's literally an if](https://youtu.be/ep-GFaKjUco?t=01h08m20s)

[with a pass through so let's just lift](https://youtu.be/ep-GFaKjUco?t=01h08m22s)

[this up and out](https://youtu.be/ep-GFaKjUco?t=01h08m24s)

[and inline it at the call](https://youtu.be/ep-GFaKjUco?t=01h08m26s)

[site because there's no reason to to](https://youtu.be/ep-GFaKjUco?t=01h08m29s)

[jump that if we don't need to right so](https://youtu.be/ep-GFaKjUco?t=01h08m33s)

[that goes away that goes away and](https://youtu.be/ep-GFaKjUco?t=01h08m37s)

[honestly both of these should probably](https://youtu.be/ep-GFaKjUco?t=01h08m40s)

[move](https://youtu.be/ep-GFaKjUco?t=01h08m42s)

[in okay so that gets me the MSI name but](https://youtu.be/ep-GFaKjUco?t=01h08m46s)

[the only reason I need the MSI name is](https://youtu.be/ep-GFaKjUco?t=01h08m48s)

[because I was going to grab the asset](https://youtu.be/ep-GFaKjUco?t=01h08m50s)

[path from the asset cach and this needs](https://youtu.be/ep-GFaKjUco?t=01h08m52s)

[the setup exe which I believe is](https://youtu.be/ep-GFaKjUco?t=01h08m56s)

[here just want to make sure that](https://youtu.be/ep-GFaKjUco?t=01h09m02s)

[I create that from the right place so](https://youtu.be/ep-GFaKjUco?t=01h09m05s)

[setup exe path came from the](https://youtu.be/ep-GFaKjUco?t=01h09m08s)

[base and is](https://youtu.be/ep-GFaKjUco?t=01h09m12s)

[where setup exe path is here I had](https://youtu.be/ep-GFaKjUco?t=01h09m15s)

[previously extracted this up and out](https://youtu.be/ep-GFaKjUco?t=01h09m21s)

[but this was the asset cash here so](https://youtu.be/ep-GFaKjUco?t=01h09m26s)

[here's my problem I don't think the](https://youtu.be/ep-GFaKjUco?t=01h09m28s)

[asset cach is exposed](https://youtu.be/ep-GFaKjUco?t=01h09m30s)

[anywhere one of those areas where it's](https://youtu.be/ep-GFaKjUco?t=01h09m37s)

[kind of annoying so the asset cache](https://youtu.be/ep-GFaKjUco?t=01h09m41s)

[contains a list of all of the the build](https://youtu.be/ep-GFaKjUco?t=01h09m43s)

[assets that the vopat creates like an](https://youtu.be/ep-GFaKjUco?t=01h09m46s)

[asset itself isn't much it's just](https://youtu.be/ep-GFaKjUco?t=01h09m50s)

[effectively a a file and a a given type](https://youtu.be/ep-GFaKjUco?t=01h09m52s)

[but the the key thing here is when it's](https://youtu.be/ep-GFaKjUco?t=01h09m55s)

[figuring out like release entries so](https://youtu.be/ep-GFaKjUco?t=01h09m58s)

[that it knows what it's built or it's um](https://youtu.be/ep-GFaKjUco?t=01h10m01s)

[getting back all the the file paths so](https://youtu.be/ep-GFaKjUco?t=01h10m03s)

[it knows which things does it need to](https://youtu.be/ep-GFaKjUco?t=01h10m05s)

[move like this is what's keeping track](https://youtu.be/ep-GFaKjUco?t=01h10m07s)

[of it so without it here right move bag](https://youtu.be/ep-GFaKjUco?t=01h10m09s)

[too or similar so that it can find them](https://youtu.be/ep-GFaKjUco?t=01h10m14s)

[all um it's kind of difficult](https://youtu.be/ep-GFaKjUco?t=01h10m17s)

[kind of difficult to deal](https://youtu.be/ep-GFaKjUco?t=01h10m26s)

[with and I guess](https://youtu.be/ep-GFaKjUco?t=01h10m29s)

[we do we need to put it into](https://youtu.be/ep-GFaKjUco?t=01h10m32s)

[here probably](https://youtu.be/ep-GFaKjUco?t=01h10m39s)

[don't probably](https://youtu.be/ep-GFaKjUco?t=01h10m45s)

[don't the key thing here is the the](https://youtu.be/ep-GFaKjUco?t=01h10m50s)

[asset path or um the build assets does](https://youtu.be/ep-GFaKjUco?t=01h10m53s)

[have effectively a root level output](https://youtu.be/ep-GFaKjUco?t=01h10m56s)

[directory and so it's slapping that on](https://youtu.be/ep-GFaKjUco?t=01h11m01s)

[top of everything that goes through but](https://youtu.be/ep-GFaKjUco?t=01h11m04s)

[when we call](https://youtu.be/ep-GFaKjUco?t=01h11m07s)

[into build setup](https://youtu.be/ep-GFaKjUco?t=01h11m09s)

[package like this thing's getting the](https://youtu.be/ep-GFaKjUco?t=01h11m13s)

[the](https://youtu.be/ep-GFaKjUco?t=01h11m16s)

[path I guess if we don't need to put it](https://youtu.be/ep-GFaKjUco?t=01h11m19s)

[into the asset cach and we just created](https://youtu.be/ep-GFaKjUco?t=01h11m23s)

[alongside because there's](https://youtu.be/ep-GFaKjUco?t=01h11m26s)

[not there's no](https://youtu.be/ep-GFaKjUco?t=01h11m30s)

[need is there a need I need to need to](https://youtu.be/ep-GFaKjUco?t=01h11m34s)

[think carefully before I say](https://youtu.be/ep-GFaKjUco?t=01h11m37s)

[this is there a need for it to show up](https://youtu.be/ep-GFaKjUco?t=01h11m40s)

[in the release](https://youtu.be/ep-GFaKjUco?t=01h11m44s)

[manifest don't believe so because the](https://youtu.be/ep-GFaKjUco?t=01h11m47s)

[release manifest the Json file when a](https://youtu.be/ep-GFaKjUco?t=01h11m51s)

[Lop Pac app goes for updates it pulls](https://youtu.be/ep-GFaKjUco?t=01h11m55s)

[the the Json file down looks the](https://youtu.be/ep-GFaKjUco?t=01h11m58s)

[Manifest finds the updates right figures](https://youtu.be/ep-GFaKjUco?t=01h12m01s)

[out whether it's going to do a Delta](https://youtu.be/ep-GFaKjUco?t=01h12m04s)

[update or a full](https://youtu.be/ep-GFaKjUco?t=01h12m06s)

[update pulls down the relevant packages](https://youtu.be/ep-GFaKjUco?t=01h12m08s)

[for that and then applies them updates](https://youtu.be/ep-GFaKjUco?t=01h12m11s)

[you're Off to the](https://youtu.be/ep-GFaKjUco?t=01h12m14s)

[Races the exe is only there because](https://youtu.be/ep-GFaKjUco?t=01h12m18s)

[there is a desire to to be able to hit](https://youtu.be/ep-GFaKjUco?t=01h12m21s)

[the path and that down I'm kind of](https://youtu.be/ep-GFaKjUco?t=01h12m24s)

[wondering like I think it does make](https://youtu.be/ep-GFaKjUco?t=01h12m32s)

[sense to put it in](https://youtu.be/ep-GFaKjUco?t=01h12m34s)

[there we don't need it but I could see](https://youtu.be/ep-GFaKjUco?t=01h12m37s)

[somebody else wanting](https://youtu.be/ep-GFaKjUco?t=01h12m40s)

[it but if I wanted to go quick and](https://youtu.be/ep-GFaKjUco?t=01h12m43s)

[dirty right the whole point of doing](https://youtu.be/ep-GFaKjUco?t=01h12m46s)

[this is just to get](https://youtu.be/ep-GFaKjUco?t=01h12m48s)

[the the path but I could easily do R MSI](https://youtu.be/ep-GFaKjUco?t=01h12m50s)

[path it's path.](https://youtu.be/ep-GFaKjUco?t=01h12m56s)

[combine and then do I](https://youtu.be/ep-GFaKjUco?t=01h12m59s)

[have](https://youtu.be/ep-GFaKjUco?t=01h13m03s)

[uh Target setup exe right like I could](https://youtu.be/ep-GFaKjUco?t=01h13m05s)

[do the I don't know why this is pack](https://youtu.be/ep-GFaKjUco?t=01h13m09s)

[directory that's not where we want to go](https://youtu.be/ep-GFaKjUco?t=01h13m13s)

[we want to go path. getet directory name](https://youtu.be/ep-GFaKjUco?t=01h13m15s)

[right target setup exe so we're going to](https://youtu.be/ep-GFaKjUco?t=01h13m19s)

[get the directory that we generated the](https://youtu.be/ep-GFaKjUco?t=01h13m21s)

[setup exe in](https://youtu.be/ep-GFaKjUco?t=01h13m22s)

[shove the MSI in there Bippity bity](https://youtu.be/ep-GFaKjUco?t=01h13m25s)

[booah We're Off to the Races right and](https://youtu.be/ep-GFaKjUco?t=01h13m28s)

[this just becomes Target setup](https://youtu.be/ep-GFaKjUco?t=01h13m30s)

[exe and now we're working the](https://youtu.be/ep-GFaKjUco?t=01h13m33s)

[disadvantage of what I've done is we](https://youtu.be/ep-GFaKjUco?t=01h13m35s)

[could actually delete it entirely from](https://youtu.be/ep-GFaKjUco?t=01h13m36s)

[the](https://youtu.be/ep-GFaKjUco?t=01h13m40s)

[assets or an initial release on a](https://youtu.be/ep-GFaKjUco?t=01h13m51s)

[feature that I don't think we want to](https://youtu.be/ep-GFaKjUco?t=01h13m53s)

[keep this is probably not a bad thing](https://youtu.be/ep-GFaKjUco?t=01h13m55s)

[to which means I can get rid of](https://youtu.be/ep-GFaKjUco?t=01h13m59s)

[this](https://youtu.be/ep-GFaKjUco?t=01h14m04s)

[altogether no one's referencing it](https://youtu.be/ep-GFaKjUco?t=01h14m06s)

[anymore makes the back end cleaner](https://youtu.be/ep-GFaKjUco?t=01h14m10s)

[too it does mean that Flo doesn't have](https://youtu.be/ep-GFaKjUco?t=01h14m18s)

[support MSI file and I'm kind of okay](https://youtu.be/ep-GFaKjUco?t=01h14m21s)

[with that cuz I kind of want Flo to have](https://youtu.be/ep-GFaKjUco?t=01h14m24s)

[the the real Ms the actual good one not](https://youtu.be/ep-GFaKjUco?t=01h14m28s)

[the deployment tool](https://youtu.be/ep-GFaKjUco?t=01h14m33s)

[MSI this no longer needs](https://youtu.be/ep-GFaKjUco?t=01h14m42s)

[that task completed task I think though](https://youtu.be/ep-GFaKjUco?t=01h14m46s)

[what we want to do](https://youtu.be/ep-GFaKjUco?t=01h14m50s)

[is we do need to check](https://youtu.be/ep-GFaKjUco?t=01h14m53s)

[check uh](https://youtu.be/ep-GFaKjUco?t=01h14m56s)

[options. build](https://youtu.be/ep-GFaKjUco?t=01h14m59s)

[MSI all right so we need](https://youtu.be/ep-GFaKjUco?t=01h15m02s)

[that kind attempted to do something](https://youtu.be/ep-GFaKjUco?t=01h15m21s)

[really funky](https://youtu.be/ep-GFaKjUco?t=01h15m23s)

[I'm proba so just for reference I'm](https://youtu.be/ep-GFaKjUco?t=01h15m27s)

[probably about to](https://youtu.be/ep-GFaKjUco?t=01h15m29s)

[throw](https://youtu.be/ep-GFaKjUco?t=01h15m30s)

[right](https://youtu.be/ep-GFaKjUco?t=01h15m32s)

[um](https://youtu.be/ep-GFaKjUco?t=01h15m44s)

[uh this feel this feels so wrong right](https://youtu.be/ep-GFaKjUco?t=01h15m48s)

[like](https://youtu.be/ep-GFaKjUco?t=01h15m51s)

[I'm like I either have to have this one](https://youtu.be/ep-GFaKjUco?t=01h15m53s)

[be 200 and change all of these ones](https://youtu.be/ep-GFaKjUco?t=01h15m56s)

[because if we aren't going to build the](https://youtu.be/ep-GFaKjUco?t=01h15m58s)

[MSI this this is a 100% progress but I](https://youtu.be/ep-GFaKjUco?t=01h16m00s)

[but I'm somewhat tempted to do something](https://youtu.be/ep-GFaKjUco?t=01h16m04s)

[really funky where it's something like](https://youtu.be/ep-GFaKjUco?t=01h16m06s)

[uh options build Ms if build](https://youtu.be/ep-GFaKjUco?t=01h16m09s)

[MSI uh x /](https://youtu.be/ep-GFaKjUco?t=01h16m14s)

[two uh otherwise](https://youtu.be/ep-GFaKjUco?t=01h16m17s)

[X feel stupid](https://youtu.be/ep-GFaKjUco?t=01h16m23s)

[it](https://youtu.be/ep-GFaKjUco?t=01h16m26s)

[feels feels kind](https://youtu.be/ep-GFaKjUco?t=01h16m27s)

[of](https://youtu.be/ep-GFaKjUco?t=01h16m29s)

[like just just just to walk through](https://youtu.be/ep-GFaKjUco?t=01h16m31s)

[what's happening here in this case](https://youtu.be/ep-GFaKjUco?t=01h16m34s)

[progress is an action of int right this](https://youtu.be/ep-GFaKjUco?t=01h16m36s)

[should have probably been like an ie](https://youtu.be/ep-GFaKjUco?t=01h16m38s)

[progress interface whatever right at the](https://youtu.be/ep-GFaKjUco?t=01h16m40s)

[end of the day it's just something to](https://youtu.be/ep-GFaKjUco?t=01h16m43s)

[report back progress because the fancy](https://youtu.be/ep-GFaKjUco?t=01h16m45s)

[progress bars we have on the CLI](https://youtu.be/ep-GFaKjUco?t=01h16m47s)

[leverage it great fine this is taking in](https://youtu.be/ep-GFaKjUco?t=01h16m49s)

[the parameter and assigning a new value](https://youtu.be/ep-GFaKjUco?t=01h16m53s)

[but remember we evaluate the right](https://youtu.be/ep-GFaKjUco?t=01h16m56s)

[before the left so we're going to](https://youtu.be/ep-GFaKjUco?t=01h16m57s)

[capture the current p in value before we](https://youtu.be/ep-GFaKjUco?t=01h16m59s)

[assign it here and we're going to say](https://youtu.be/ep-GFaKjUco?t=01h17m02s)

[whatever value comes](https://youtu.be/ep-GFaKjUco?t=01h17m04s)

[in if we are building the MS if we're](https://youtu.be/ep-GFaKjUco?t=01h17m06s)

[going to build the MSI we're going to](https://youtu.be/ep-GFaKjUco?t=01h17m09s)

[take the value that's passed in and](https://youtu.be/ep-GFaKjUco?t=01h17m11s)

[divide it by two me this becomes you](https://youtu.be/ep-GFaKjUco?t=01h17m12s)

[know](https://youtu.be/ep-GFaKjUco?t=01h17m15s)

[5% whatever half of 25 is 14 and a half](https://youtu.be/ep-GFaKjUco?t=01h17m16s)

[this becomes 25 this becomes 50 this](https://youtu.be/ep-GFaKjUco?t=01h17m20s)

[becomes 100 right so it's it's one of](https://youtu.be/ep-GFaKjUco?t=01h17m23s)

[those things it's it's a little](https://youtu.be/ep-GFaKjUco?t=01h17m26s)

[weird right but we also pass the prog](https://youtu.be/ep-GFaKjUco?t=01h17m28s)

[actually do we even need to pass it into](https://youtu.be/ep-GFaKjUco?t=01h17m31s)

[here oh because we passed progress into](https://youtu.be/ep-GFaKjUco?t=01h17m34s)

[this](https://youtu.be/ep-GFaKjUco?t=01h17m41s)

[oh this guy has his own](https://youtu.be/ep-GFaKjUco?t=01h17m42s)

[progress he doesn't do much](https://youtu.be/ep-GFaKjUco?t=01h17m45s)

[yeah interesting okay so maybe this is a](https://youtu.be/ep-GFaKjUco?t=01h17m56s)

[bad](https://youtu.be/ep-GFaKjUco?t=01h18m00s)

[idea because what I really want is this](https://youtu.be/ep-GFaKjUco?t=01h18m01s)

[progress to](https://youtu.be/ep-GFaKjUco?t=01h18m05s)

[work and then I want to then I want to](https://youtu.be/ep-GFaKjUco?t=01h18m07s)

[feed in something](https://youtu.be/ep-GFaKjUco?t=01h18m10s)

[here right I almost want this to be](https://youtu.be/ep-GFaKjUco?t=01h18m12s)

[x](https://youtu.be/ep-GFaKjUco?t=01h18m16s)

[uh this feels hacker than and all get](https://youtu.be/ep-GFaKjUco?t=01h18m22s)

[out this](https://youtu.be/ep-GFaKjUco?t=01h18m28s)

[feels very very](https://youtu.be/ep-GFaKjUco?t=01h18m29s)

[hacky okay I think the reason it feels](https://youtu.be/ep-GFaKjUco?t=01h18m36s)

[hacky is because I'm reassigning these](https://youtu.be/ep-GFaKjUco?t=01h18m38s)

[things um we're gonna we're going to](https://youtu.be/ep-GFaKjUco?t=01h18m41s)

[change this up right action of](https://youtu.be/ep-GFaKjUco?t=01h18m44s)

[int gets uh setup](https://youtu.be/ep-GFaKjUco?t=01h18m47s)

[exe progress](https://youtu.be/ep-GFaKjUco?t=01h18m51s)

[right and this is going to get](https://youtu.be/ep-GFaKjUco?t=01h18m54s)

[progress and then we're going to](https://youtu.be/ep-GFaKjUco?t=01h18m59s)

[do action of](https://youtu.be/ep-GFaKjUco?t=01h19m03s)

[int MSI](https://youtu.be/ep-GFaKjUco?t=01h19m06s)

[progress It's I don't know right x x](https://youtu.be/ep-GFaKjUco?t=01h19m08s)

[Lambda do nothing right for the moment](https://youtu.be/ep-GFaKjUco?t=01h19m13s)

[okay so we're](https://youtu.be/ep-GFaKjUco?t=01h19m16s)

[GNA action of int](https://youtu.be/ep-GFaKjUco?t=01h19m22s)

[overall progress right so th this guy](https://youtu.be/ep-GFaKjUco?t=01h19m26s)

[here I think it is going to end up being](https://youtu.be/ep-GFaKjUco?t=01h19m32s)

[what actually](https://youtu.be/ep-GFaKjUco?t=01h19m35s)

[does the the work right so rather than](https://youtu.be/ep-GFaKjUco?t=01h19m37s)

[re I because I think the big hacky thing](https://youtu.be/ep-GFaKjUco?t=01h19m40s)

[is the way progress is being reassigned](https://youtu.be/ep-GFaKjUco?t=01h19m42s)

[and changed right we don't we don't want](https://youtu.be/ep-GFaKjUco?t=01h19m44s)

[to do that uh let's see so for for](https://youtu.be/ep-GFaKjUco?t=01h19m46s)

[starters we're just going to straight](https://youtu.be/ep-GFaKjUco?t=01h19m49s)

[pass X3 right so we're going to get rid](https://youtu.be/ep-GFaKjUco?t=01h19m51s)

[of that get rid of that none of that](https://youtu.be/ep-GFaKjUco?t=01h19m53s)

[goes here this becomes setup exe](https://youtu.be/ep-GFaKjUco?t=01h19m54s)

[progress right so the the key thing here](https://youtu.be/ep-GFaKjUco?t=01h19m59s)

[is I want to replace all usages of](https://youtu.be/ep-GFaKjUco?t=01h20m01s)

[progress with setup exe progress so that](https://youtu.be/ep-GFaKjUco?t=01h20m03s)

[it it's responsible for just reporting](https://youtu.be/ep-GFaKjUco?t=01h20m07s)

[the exe progress make this not stupid or](https://youtu.be/ep-GFaKjUco?t=01h20m10s)

[not suck for the moment okay so that's](https://youtu.be/ep-GFaKjUco?t=01h20m16s)

[set up exe progress and then this guy](https://youtu.be/ep-GFaKjUco?t=01h20m17s)

[down here should](https://youtu.be/ep-GFaKjUco?t=01h20m20s)

[become MSI progress](https://youtu.be/ep-GFaKjUco?t=01h20m21s)

[right that way okay that's better right](https://youtu.be/ep-GFaKjUco?t=01h20m28s)

[so he's going to report back the MSI](https://youtu.be/ep-GFaKjUco?t=01h20m31s)

[progress he's going to report the setup](https://youtu.be/ep-GFaKjUco?t=01h20m33s)

[exe progress and this guy's job here is](https://youtu.be/ep-GFaKjUco?t=01h20m35s)

[to figure out what the heck to](https://youtu.be/ep-GFaKjUco?t=01h20m38s)

[do all right so this guy is going to](https://youtu.be/ep-GFaKjUco?t=01h20m41s)

[come](https://youtu.be/ep-GFaKjUco?t=01h20m44s)

[in and so when setup exe first gets](https://youtu.be/ep-GFaKjUco?t=01h20m45s)

[called it's going to pass in a](https://youtu.be/ep-GFaKjUco?t=01h20m48s)

[10 right and I let's see I done this](https://youtu.be/ep-GFaKjUco?t=01h20m50s)

[weird](https://youtu.be/ep-GFaKjUco?t=01h20m54s)

[weird so setup](https://youtu.be/ep-GFaKjUco?t=01h20m57s)

[exe needs to then pass](https://youtu.be/ep-GFaKjUco?t=01h21m01s)

[into here and I'm wondering if I really](https://youtu.be/ep-GFaKjUco?t=01h21m06s)

[want this overall](https://youtu.be/ep-GFaKjUco?t=01h21m08s)

[progress because I think this can this](https://youtu.be/ep-GFaKjUco?t=01h21m10s)

[can now just we can just do it in here](https://youtu.be/ep-GFaKjUco?t=01h21m13s)

[right so](https://youtu.be/ep-GFaKjUco?t=01h21m16s)

[uh options. build MSI so if build MSI](https://youtu.be/ep-GFaKjUco?t=01h21m18s)

[this is going to get the division by two](https://youtu.be/ep-GFaKjUco?t=01h21m23s)

[otherwise we are just going to go](https://youtu.be/ep-GFaKjUco?t=01h21m25s)

[progress](https://youtu.be/ep-GFaKjUco?t=01h21m27s)

[X right this guy goes](https://youtu.be/ep-GFaKjUco?t=01h21m30s)

[here uh what is your](https://youtu.be/ep-GFaKjUco?t=01h21m36s)

[problem oh because I can't do](https://youtu.be/ep-GFaKjUco?t=01h21m44s)

[that](https://youtu.be/ep-GFaKjUco?t=01h21m48s)

[right sorry now I have to think for a](https://youtu.be/ep-GFaKjUco?t=01h21m50s)

[second so set up EXE gets in the](https://youtu.be/ep-GFaKjUco?t=01h21m53s)

[value yeah I think I wrote the I think I](https://youtu.be/ep-GFaKjUco?t=01h21m59s)

[set this up in a an awkward way because](https://youtu.be/ep-GFaKjUco?t=01h22m02s)

[I think I WR wrote this as fan in rather](https://youtu.be/ep-GFaKjUco?t=01h22m04s)

[than fan](https://youtu.be/ep-GFaKjUco?t=01h22m07s)

[out set that backwards now which is](https://youtu.be/ep-GFaKjUco?t=01h22m08s)

[adding okay in these types of situations](https://youtu.be/ep-GFaKjUco?t=01h22m11s)

[it's important to pause and drink some](https://youtu.be/ep-GFaKjUco?t=01h22m14s)

[Mountain](https://youtu.be/ep-GFaKjUco?t=01h22m15s)

[Dew okay we now](https://youtu.be/ep-GFaKjUco?t=01h22m17s)

[can Okay so this guy here um](https://youtu.be/ep-GFaKjUco?t=01h22m21s)

[is really at the end of the day what we](https://youtu.be/ep-GFaKjUco?t=01h22m31s)

[want is a](https://youtu.be/ep-GFaKjUco?t=01h22m32s)

[single single single place to deal with](https://youtu.be/ep-GFaKjUco?t=01h22m34s)

[this](https://youtu.be/ep-GFaKjUco?t=01h22m36s)

[stuff and I think all I'm going to do is](https://youtu.be/ep-GFaKjUco?t=01h22m38s)

[convert](https://youtu.be/ep-GFaKjUco?t=01h22m40s)

[this uh block body](https://youtu.be/ep-GFaKjUco?t=01h22m42s)

[and I'm going to move this guy](https://youtu.be/ep-GFaKjUco?t=01h23m01s)

[up I can figure out how to](https://youtu.be/ep-GFaKjUco?t=01h23m04s)

[type which is not always an easy thing](https://youtu.be/ep-GFaKjUco?t=01h23m06s)

[to](https://youtu.be/ep-GFaKjUco?t=01h23m09s)

[do we V okay clearly I'm losing it which](https://youtu.be/ep-GFaKjUco?t=01h23m10s)

[is not a good sign okay that goes like](https://youtu.be/ep-GFaKjUco?t=01h23m16s)

[that that goes like that that goes like](https://youtu.be/ep-GFaKjUco?t=01h23m19s)

[that](https://youtu.be/ep-GFaKjUco?t=01h23m21s)

[right this thing want to be a local](https://youtu.be/ep-GFaKjUco?t=01h23m22s)

[function](https://youtu.be/ep-GFaKjUco?t=01h23m25s)

[great](https://youtu.be/ep-GFaKjUco?t=01h23m27s)

[um the other one void uh](https://youtu.be/ep-GFaKjUco?t=01h23m31s)

[MSI](https://youtu.be/ep-GFaKjUco?t=01h23m35s)

[progress int](https://youtu.be/ep-GFaKjUco?t=01h23m37s)

[uh value right this guy here uh for MSI](https://youtu.be/ep-GFaKjUco?t=01h23m40s)

[progress uh typing is easy typing the](https://youtu.be/ep-GFaKjUco?t=01h23m47s)

[right thing is hard you make a good](https://youtu.be/ep-GFaKjUco?t=01h23m49s)

[point Izzy you make a very very good](https://youtu.be/ep-GFaKjUco?t=01h23m50s)

[point uh okay so the v d na you co-pilot](https://youtu.be/ep-GFaKjUco?t=01h23m53s)

[did you just get it](https://youtu.be/ep-GFaKjUco?t=01h23m57s)

[right so the other one was divided by](https://youtu.be/ep-GFaKjUco?t=01h24m01s)

[two so this thing wants to represent the](https://youtu.be/ep-GFaKjUco?t=01h24m05s)

[second](https://youtu.be/ep-GFaKjUco?t=01h24m07s)

[half so then it's going to let the](https://youtu.be/ep-GFaKjUco?t=01h24m08s)

[values go in divide them by two but add](https://youtu.be/ep-GFaKjUco?t=01h24m10s)

[50 to](https://youtu.be/ep-GFaKjUco?t=01h24m12s)

[them co-pilot](https://youtu.be/ep-GFaKjUco?t=01h24m15s)

[smart co-pilot is smart](https://youtu.be/ep-GFaKjUco?t=01h24m19s)

[okay that is that now here's the added](https://youtu.be/ep-GFaKjUco?t=01h24m25s)

[bonus have](https://youtu.be/ep-GFaKjUco?t=01h24m29s)

[S](https://youtu.be/ep-GFaKjUco?t=01h24m33s)

[that's okay there's that there's that](https://youtu.be/ep-GFaKjUco?t=01h24m40s)

[there's](https://youtu.be/ep-GFaKjUco?t=01h24m44s)

[that okay so does that](https://youtu.be/ep-GFaKjUco?t=01h24m45s)

[address](https://youtu.be/ep-GFaKjUco?t=01h24m49s)

[uh this one does address all the](https://youtu.be/ep-GFaKjUco?t=01h24m51s)

[feedback because there's the enom kill](https://youtu.be/ep-GFaKjUco?t=01h24m55s)

[the property kill the property this](https://youtu.be/ep-GFaKjUco?t=01h24m56s)

[should probably just be in the windows](https://youtu.be/ep-GFaKjUco?t=01h24m59s)

[Packer not in the Base Class combine the](https://youtu.be/ep-GFaKjUco?t=01h25m01s)

[wick stuff with the regular setup task](https://youtu.be/ep-GFaKjUco?t=01h25m03s)

[check because right now it's not very](https://youtu.be/ep-GFaKjUco?t=01h25m05s)

[configurable got it](https://youtu.be/ep-GFaKjUco?t=01h25m08s)

[done uh I pack options](https://youtu.be/ep-GFaKjUco?t=01h25m10s)

[removed combine this so it only applies](https://youtu.be/ep-GFaKjUco?t=01h25m14s)

[to Windows Okay cool so I think we hit](https://youtu.be/ep-GFaKjUco?t=01h25m16s)

[all of all of kin's](https://youtu.be/ep-GFaKjUco?t=01h25m19s)

[feedback now](https://youtu.be/ep-GFaKjUco?t=01h25m22s)

[I would like to run my test make sure I](https://youtu.be/ep-GFaKjUco?t=01h25m25s)

[didn't break](https://youtu.be/ep-GFaKjUco?t=01h25m27s)

[anything let's see so these up here](https://youtu.be/ep-GFaKjUco?t=01h25m30s)

[packaging tests and windows pack tests I](https://youtu.be/ep-GFaKjUco?t=01h25m33s)

[believe where I left](https://youtu.be/ep-GFaKjUco?t=01h25m37s)

[them don't know why there's an extra](https://youtu.be/ep-GFaKjUco?t=01h25m39s)

[using](https://youtu.be/ep-GFaKjUco?t=01h25m42s)

[there uh let's](https://youtu.be/ep-GFaKjUco?t=01h25m44s)

[see and](https://youtu.be/ep-GFaKjUco?t=01h25m46s)

[then specified version okay so these are](https://youtu.be/ep-GFaKjUco?t=01h25m51s)

[the two things here this is something](https://youtu.be/ep-GFaKjUco?t=01h25m54s)

[kind of cool I don't know if people have](https://youtu.be/ep-GFaKjUco?t=01h25m56s)

[seen this so there's this uh xunit](https://youtu.be/ep-GFaKjUco?t=01h25m57s)

[skippable fact attribute that you can](https://youtu.be/ep-GFaKjUco?t=01h25m59s)

[grab um and this allows you to](https://youtu.be/ep-GFaKjUco?t=01h26m02s)

[skip](https://youtu.be/ep-GFaKjUco?t=01h26m06s)

[uh uh test based upon complex conditions](https://youtu.be/ep-GFaKjUco?t=01h26m08s)

[because normally what you have is just](https://youtu.be/ep-GFaKjUco?t=01h26m13s)

[right you have the fact attribute and](https://youtu.be/ep-GFaKjUco?t=01h26m16s)

[the fact attribute contains a skip](https://youtu.be/ep-GFaKjUco?t=01h26m18s)

[property and the skip is a string and if](https://youtu.be/ep-GFaKjUco?t=01h26m20s)

[you set it it'll skip the test the](https://youtu.be/ep-GFaKjUco?t=01h26m23s)

[problem is this is compile time constant](https://youtu.be/ep-GFaKjUco?t=01h26m24s)

[and doesn't let you do fancy things at](https://youtu.be/ep-GFaKjUco?t=01h26m26s)

[runtime if you want to runtime determine](https://youtu.be/ep-GFaKjUco?t=01h26m28s)

[whether you want to skip a test you can](https://youtu.be/ep-GFaKjUco?t=01h26m30s)

[do something like](https://youtu.be/ep-GFaKjUco?t=01h26m32s)

[this um and so it'll it'll let you do a](https://youtu.be/ep-GFaKjUco?t=01h26m34s)

[runtime check throw the appropriate](https://youtu.be/ep-GFaKjUco?t=01h26m37s)

[xunit exception to mark this thing as](https://youtu.be/ep-GFaKjUco?t=01h26m40s)

[skipped same as what the other one would](https://youtu.be/ep-GFaKjUco?t=01h26m42s)

[do but then without all the extra stuff](https://youtu.be/ep-GFaKjUco?t=01h26m44s)

[right and then you can make this as](https://youtu.be/ep-GFaKjUco?t=01h26m48s)

[complicated as you want let's see stupid](https://youtu.be/ep-GFaKjUco?t=01h26m50s)

[question is there an EAS easy way on](https://youtu.be/ep-GFaKjUco?t=01h26m52s)

[Windows platform to get uh path methods](https://youtu.be/ep-GFaKjUco?t=01h26m54s)

[to generate Linux style paths oh](https://youtu.be/ep-GFaKjUco?t=01h26m58s)

[interesting so you want to be running](https://youtu.be/ep-GFaKjUco?t=01h27m01s)

[under windows but generate Linux style](https://youtu.be/ep-GFaKjUco?t=01h27m05s)

[paths oh that's a good question because](https://youtu.be/ep-GFaKjUco?t=01h27m12s)

[your general your general way of doing](https://youtu.be/ep-GFaKjUco?t=01h27m15s)

[that is path combine or similar uh or](https://youtu.be/ep-GFaKjUco?t=01h27m17s)

[join depending on which way you want to](https://youtu.be/ep-GFaKjUco?t=01h27m21s)

[go](https://youtu.be/ep-GFaKjUco?t=01h27m23s)

[um I don't](https://youtu.be/ep-GFaKjUco?t=01h27m25s)

[think look](https://youtu.be/ep-GFaKjUco?t=01h27m28s)

[though thought one of these had an](https://youtu.be/ep-GFaKjUco?t=01h27m32s)

[overload but maybe I'm maybe I'm making](https://youtu.be/ep-GFaKjUco?t=01h27m34s)

[that](https://youtu.be/ep-GFaKjUco?t=01h27m36s)

[up because you can certainly do path uh.](https://youtu.be/ep-GFaKjUco?t=01h27m37s)

[alternate directory separator character](https://youtu.be/ep-GFaKjUco?t=01h27m41s)

[on if you know you're on Windows this](https://youtu.be/ep-GFaKjUco?t=01h27m44s)

[will get you a forward](https://youtu.be/ep-GFaKjUco?t=01h27m46s)

[slash right um](https://youtu.be/ep-GFaKjUco?t=01h27m48s)

[I don't know of another way to do](https://youtu.be/ep-GFaKjUco?t=01h27m54s)

[it beyond that because everything is](https://youtu.be/ep-GFaKjUco?t=01h27m58s)

[based](https://youtu.be/ep-GFaKjUco?t=01h28m02s)

[on on the running platform because it's](https://youtu.be/ep-GFaKjUco?t=01h28m07s)

[platform](https://youtu.be/ep-GFaKjUco?t=01h28m10s)

[implemented because even things like uh](https://youtu.be/ep-GFaKjUco?t=01h28m12s)

[get invalid file name characters and](https://youtu.be/ep-GFaKjUco?t=01h28m15s)

[what not right these are are platform](https://youtu.be/ep-GFaKjUco?t=01h28m18s)

[implemented because they they vary](https://youtu.be/ep-GFaKjUco?t=01h28m20s)

[slightly uh um that's a really good](https://youtu.be/ep-GFaKjUco?t=01h28m23s)

[question though Izzy I've never had a](https://youtu.be/ep-GFaKjUco?t=01h28m25s)

[need on](https://youtu.be/ep-GFaKjUco?t=01h28m27s)

[Windows to](https://youtu.be/ep-GFaKjUco?t=01h28m28s)

[generate Linux](https://youtu.be/ep-GFaKjUco?t=01h28m31s)

[pathing I've always just written the](https://youtu.be/ep-GFaKjUco?t=01h28m34s)

[idiomatic C and then just run under](https://youtu.be/ep-GFaKjUco?t=01h28m37s)

[Linux because that I was actually](https://youtu.be/ep-GFaKjUco?t=01h28m41s)

[chasing a bug earlier today in my day](https://youtu.be/ep-GFaKjUco?t=01h28m43s)

[job where worked just fine on Windows](https://youtu.be/ep-GFaKjUco?t=01h28m45s)

[failed on Linux and one of the key](https://youtu.be/ep-GFaKjUco?t=01h28m49s)

[things that I knew about the code](https://youtu.be/ep-GFaKjUco?t=01h28m52s)

[was that the file system differences](https://youtu.be/ep-GFaKjUco?t=01h28m54s)

[between Linux and windows are often](https://youtu.be/ep-GFaKjUco?t=01h28m58s)

[times uh a potential culprate and in](https://youtu.be/ep-GFaKjUco?t=01h29m00s)

[this case it was it it had to do with](https://youtu.be/ep-GFaKjUco?t=01h29m02s)

[what was it directory enumerate](https://youtu.be/ep-GFaKjUco?t=01h29m05s)

[files and Linux was returning the files](https://youtu.be/ep-GFaKjUco?t=01h29m08s)

[in a different order than on Windows](https://youtu.be/ep-GFaKjUco?t=01h29m10s)

[because there was no ordering applied to](https://youtu.be/ep-GFaKjUco?t=01h29m13s)

[the to the enumerable and so it came](https://youtu.be/ep-GFaKjUco?t=01h29m15s)

[back in a different order and the code](https://youtu.be/ep-GFaKjUco?t=01h29m17s)

[didn't realize this but the code](https://youtu.be/ep-GFaKjUco?t=01h29m19s)

[mistakenly assumed an order and that was](https://youtu.be/ep-GFaKjUco?t=01h29m21s)

[bad](https://youtu.be/ep-GFaKjUco?t=01h29m23s)

[let's see I'm writing integration tests](https://youtu.be/ep-GFaKjUco?t=01h29m25s)

[and my app is on Linux but my test pack](https://youtu.be/ep-GFaKjUco?t=01h29m27s)

[runs on windows currently swapping path](https://youtu.be/ep-GFaKjUco?t=01h29m30s)

[separators with alt path separators yeah](https://youtu.be/ep-GFaKjUco?t=01h29m33s)

[that's a pretty good way to do it you](https://youtu.be/ep-GFaKjUco?t=01h29m36s)

[you also need to deal with the root](https://youtu.be/ep-GFaKjUco?t=01h29m39s)

[right like your [ __ ]](https://youtu.be/ep-GFaKjUco?t=01h29m41s)

[backslash as well because those](https://youtu.be/ep-GFaKjUco?t=01h29m43s)

[are obviously not going to work in both](https://youtu.be/ep-GFaKjUco?t=01h29m47s)

[cases but I don't don't know aside from](https://youtu.be/ep-GFaKjUco?t=01h29m52s)

[string munging I'm not sure that there](https://youtu.be/ep-GFaKjUco?t=01h29m55s)

[is a good way of doing](https://youtu.be/ep-GFaKjUco?t=01h29m57s)

[it there's probably some cool rejects](https://youtu.be/ep-GFaKjUco?t=01h30m03s)

[for doing it](https://youtu.be/ep-GFaKjUco?t=01h30m05s)

[though uh okay I want to run this test](https://youtu.be/ep-GFaKjUco?t=01h30m06s)

[first of all to make](https://youtu.be/ep-GFaKjUco?t=01h30m10s)

[works I'm actually not even 100% sure](https://youtu.be/ep-GFaKjUco?t=01h30m12s)

[I'm set up to run this test so we're](https://youtu.be/ep-GFaKjUco?t=01h30m15s)

[going to find that out um this is not a](https://youtu.be/ep-GFaKjUco?t=01h30m17s)

[unit test this is a full integration](https://youtu.be/ep-GFaKjUco?t=01h30m20s)

[test](https://youtu.be/ep-GFaKjUco?t=01h30m23s)

[um because these packaging commands like](https://youtu.be/ep-GFaKjUco?t=01h30m25s)

[are actually like executables and](https://youtu.be/ep-GFaKjUco?t=01h30m28s)

[process starts and all kinds of stuff so](https://youtu.be/ep-GFaKjUco?t=01h30m31s)

[they are not](https://youtu.be/ep-GFaKjUco?t=01h30m33s)

[fast but they exercise the complete](https://youtu.be/ep-GFaKjUco?t=01h30m34s)

[system so when they when they pass it](https://youtu.be/ep-GFaKjUco?t=01h30m37s)

[provides high confidence when they fail](https://youtu.be/ep-GFaKjUco?t=01h30m39s)

[it sometimes provides High](https://youtu.be/ep-GFaKjUco?t=01h30m42s)

[frustration](https://youtu.be/ep-GFaKjUco?t=01h30m45s)

[red yeah it it does absolutely look ugly](https://youtu.be/ep-GFaKjUco?t=01h30m50s)

[let me](https://youtu.be/ep-GFaKjUco?t=01h30m53s)

[just all](https://youtu.be/ep-GFaKjUco?t=01h30m55s)

[right yeah it's it's one of these things](https://youtu.be/ep-GFaKjUco?t=01h31m17s)

[where it's I I think most people most](https://youtu.be/ep-GFaKjUco?t=01h31m20s)

[people are in this position here right](https://youtu.be/ep-GFaKjUco?t=01h31m22s)

[where they can't get their slashes the](https://youtu.be/ep-GFaKjUco?t=01h31m24s)

[right direction they aren't trying to do](https://youtu.be/ep-GFaKjUco?t=01h31m26s)

[something as complex as you are and even](https://youtu.be/ep-GFaKjUco?t=01h31m28s)

[stuff like this always gives me pause](https://youtu.be/ep-GFaKjUco?t=01h31m31s)

[because it's like this [ __ ] like it'll](https://youtu.be/ep-GFaKjUco?t=01h31m33s)

[work but it's](https://youtu.be/ep-GFaKjUco?t=01h31m37s)

[not it's not all the way there and I](https://youtu.be/ep-GFaKjUco?t=01h31m41s)

[know there are libraries that try to ex](https://youtu.be/ep-GFaKjUco?t=01h31m45s)

[um abstract away the OS for](https://youtu.be/ep-GFaKjUco?t=01h31m47s)

[you because people want that level of](https://youtu.be/ep-GFaKjUco?t=01h31m50s)

[abstraction for their unit](https://youtu.be/ep-GFaKjUco?t=01h31m54s)

[tests um I've just found that those are](https://youtu.be/ep-GFaKjUco?t=01h31m56s)

[not that it's it's one of those things](https://youtu.be/ep-GFaKjUco?t=01h32m01s)

[like mocks are un necessary](https://youtu.be/ep-GFaKjUco?t=01h32m03s)

[evil but if you see them as the solution](https://youtu.be/ep-GFaKjUco?t=01h32m05s)

[rather than](https://youtu.be/ep-GFaKjUco?t=01h32m09s)

[a a crutch it it it's that's almost](https://youtu.be/ep-GFaKjUco?t=01h32m11s)

[worse um I'm assuming this is going to](https://youtu.be/ep-GFaKjUco?t=01h32m15s)

[be fail to find path](https://youtu.be/ep-GFaKjUco?t=01h32m19s)

[uh let's](https://youtu.be/ep-GFaKjUco?t=01h32m24s)

[see let's see](https://youtu.be/ep-GFaKjUco?t=01h32m29s)

[build what's the failure](https://youtu.be/ep-GFaKjUco?t=01h32m35s)

[here hey acid rain long time no](https://youtu.be/ep-GFaKjUco?t=01h32m37s)

[see how's it](https://youtu.be/ep-GFaKjUco?t=01h32m41s)

[going um let's see copy link for if](https://youtu.be/ep-GFaKjUco?t=01h32m44s)

[anybody wants to play along at](https://youtu.be/ep-GFaKjUco?t=01h32m48s)

[home we're fixing up a a PR that I](https://youtu.be/ep-GFaKjUco?t=01h32m50s)

[submitted a couple days](https://youtu.be/ep-GFaKjUco?t=01h32m54s)

[ago I finally got a review on and so we](https://youtu.be/ep-GFaKjUco?t=01h32m57s)

[are taking a look at trying to address](https://youtu.be/ep-GFaKjUco?t=01h32m59s)

[it I'm just curious](https://youtu.be/ep-GFaKjUco?t=01h33m03s)

[why I mean this looks like it's success](https://youtu.be/ep-GFaKjUco?t=01h33m17s)

[that's the output for Success so what](https://youtu.be/ep-GFaKjUco?t=01h33m21s)

[okay](https://youtu.be/ep-GFaKjUco?t=01h33m28s)

[uh going good just pretending my best to](https://youtu.be/ep-GFaKjUco?t=01h33m30s)

[be a devops](https://youtu.be/ep-GFaKjUco?t=01h33m33s)

[engineer it's a it's a good thing to](https://youtu.be/ep-GFaKjUco?t=01h33m37s)

[pretend to](https://youtu.be/ep-GFaKjUco?t=01h33m39s)

[be like right now devops engineers make](https://youtu.be/ep-GFaKjUco?t=01h33m40s)

[bank](https://youtu.be/ep-GFaKjUco?t=01h33m45s)

[so not that it's not that bad of an idea](https://youtu.be/ep-GFaKjUco?t=01h33m46s)

[out do](https://youtu.be/ep-GFaKjUco?t=01h33m56s)

[down it's okay I pretend to be a devops](https://youtu.be/ep-GFaKjUco?t=01h33m57s)

[engineer ever so often too uh so this is](https://youtu.be/ep-GFaKjUco?t=01h33m59s)

[expecting that there is a file created](https://youtu.be/ep-GFaKjUco?t=01h34m04s)

[uh and it's saying it doesn't exist](https://youtu.be/ep-GFaKjUco?t=01h34m07s)

[despite the fact that I've got test](https://youtu.be/ep-GFaKjUco?t=01h34m10s)

[output showing that it should have done](https://youtu.be/ep-GFaKjUco?t=01h34m11s)

[it have a good one Izzy don't work too](https://youtu.be/ep-GFaKjUco?t=01h34m17s)

[hard try to enjoy it](https://youtu.be/ep-GFaKjUco?t=01h34m20s)

[uh uh Circle CI I so I've I've heard of](https://youtu.be/ep-GFaKjUco?t=01h34m29s)

[circle CI um they have not played with](https://youtu.be/ep-GFaKjUco?t=01h34m33s)

[it because it](https://youtu.be/ep-GFaKjUco?t=01h34m40s)

[is I've had a couple people that say](https://youtu.be/ep-GFaKjUco?t=01h34m42s)

[really good things about](https://youtu.be/ep-GFaKjUco?t=01h34m44s)

[it oh is there not a there we go that's](https://youtu.be/ep-GFaKjUco?t=01h34m46s)

[what I want to see that's what I want to](https://youtu.be/ep-GFaKjUco?t=01h34m50s)

[see](https://youtu.be/ep-GFaKjUco?t=01h34m52s)

[yeah like I used Jenkins many years ago](https://youtu.be/ep-GFaKjUco?t=01h35m01s)

[and haven't touched it much recently or](https://youtu.be/ep-GFaKjUco?t=01h35m04s)

[at least my open source stuff it I went](https://youtu.be/ep-GFaKjUco?t=01h35m07s)

[from Jenkins to appv to GitHub](https://youtu.be/ep-GFaKjUco?t=01h35m09s)

[actions but yeah](https://youtu.be/ep-GFaKjUco?t=01h35m15s)

[yeah honestly this is one of those areas](https://youtu.be/ep-GFaKjUco?t=01h35m25s)

[where I I](https://youtu.be/ep-GFaKjUco?t=01h35m27s)

[think I think it gets](https://youtu.be/ep-GFaKjUco?t=01h35m29s)

[undervalued](https://youtu.be/ep-GFaKjUco?t=01h35m31s)

[um yeah like and that's like everybody](https://youtu.be/ep-GFaKjUco?t=01h35m33s)

[said app was going to die when GitHub](https://youtu.be/ep-GFaKjUco?t=01h35m36s)

[actions came out and had a really nice](https://youtu.be/ep-GFaKjUco?t=01h35m38s)

[free tier but they didn't and I think](https://youtu.be/ep-GFaKjUco?t=01h35m41s)

[part of why they didn't is because](https://youtu.be/ep-GFaKjUco?t=01h35m45s)

[people](https://youtu.be/ep-GFaKjUco?t=01h35m47s)

[overestimate gaml right like](https://youtu.be/ep-GFaKjUco?t=01h35m49s)

[it is like even though it's powerful and](https://youtu.be/ep-GFaKjUco?t=01h35m54s)

[you can do all this stuff with it people](https://youtu.be/ep-GFaKjUco?t=01h35m56s)

[don't always want that right like](https://youtu.be/ep-GFaKjUco?t=01h35m58s)

[Microsoft](https://youtu.be/ep-GFaKjUco?t=01h36m00s)

[uh App Center so nobody Ed this this](https://youtu.be/ep-GFaKjUco?t=01h36m02s)

[thing is I think functionally dead at](https://youtu.be/ep-GFaKjUco?t=01h36m05s)

[this point but yeah scheduled for](https://youtu.be/ep-GFaKjUco?t=01h36m08s)

[retirement March 31st yeah it's it's](https://youtu.be/ep-GFaKjUco?t=01h36m11s)

[it's dead don't don't build on this but](https://youtu.be/ep-GFaKjUco?t=01h36m13s)

[this was a full build C setup for your](https://youtu.be/ep-GFaKjUco?t=01h36m16s)

[mobile apps that integrated with um](https://youtu.be/ep-GFaKjUco?t=01h36m19s)

[uh shoot what it App Store connect on](https://youtu.be/ep-GFaKjUco?t=01h36m24s)

[Apple and Google Play and had a way of](https://youtu.be/ep-GFaKjUco?t=01h36m27s)

[sideloading your apps like it didn't](https://youtu.be/ep-GFaKjUco?t=01h36m30s)

[have all the power of the yaml stuff but](https://youtu.be/ep-GFaKjUco?t=01h36m32s)

[it was quick easy it did all the things](https://youtu.be/ep-GFaKjUco?t=01h36m34s)

[it it did a number of things very simply](https://youtu.be/ep-GFaKjUco?t=01h36m38s)

[and easily and work great and people](https://youtu.be/ep-GFaKjUco?t=01h36m41s)

[loved it um I think Microsoft's thing](https://youtu.be/ep-GFaKjUco?t=01h36m43s)

[was you know not enough Roi on it blah](https://youtu.be/ep-GFaKjUco?t=01h36m47s)

[blah blah but it's I think people](https://youtu.be/ep-GFaKjUco?t=01h36m50s)

[underestimate how](https://youtu.be/ep-GFaKjUco?t=01h36m51s)

[like devops is hard and sometimes making](https://youtu.be/ep-GFaKjUco?t=01h36m54s)

[it sometimes making something pretty and](https://youtu.be/ep-GFaKjUco?t=01h36m59s)

[simple like this is](https://youtu.be/ep-GFaKjUco?t=01h37m01s)

[really right the hard part with simple](https://youtu.be/ep-GFaKjUco?t=01h37m04s)

[is you have to leave enough hooks to](https://youtu.be/ep-GFaKjUco?t=01h37m07s)

[where people can do the complicated](https://youtu.be/ep-GFaKjUco?t=01h37m09s)

[stuff when they need it but if you make](https://youtu.be/ep-GFaKjUco?t=01h37m10s)

[the simple thing simple it just feels](https://youtu.be/ep-GFaKjUco?t=01h37m12s)

[good it feels](https://youtu.be/ep-GFaKjUco?t=01h37m16s)

[polished uh okay so we're going to run](https://youtu.be/ep-GFaKjUco?t=01h37m19s)

[this guy one more time and I think think](https://youtu.be/ep-GFaKjUco?t=01h37m22s)

[I just want to pause and go look at this](https://youtu.be/ep-GFaKjUco?t=01h37m23s)

[temp directory because apparently it it](https://youtu.be/ep-GFaKjUco?t=01h37m25s)

[wrote out a](https://youtu.be/ep-GFaKjUco?t=01h37m28s)

[file and I'm just wondering if maybe I I](https://youtu.be/ep-GFaKjUco?t=01h37m30s)

[mucked up like my my pathing or](https://youtu.be/ep-GFaKjUco?t=01h37m33s)

[similar as let's see this should be test](https://youtu.be/ep-GFaKjUco?t=01h37m40s)

[squirrel hyphen app wind deployment MSI](https://youtu.be/ep-GFaKjUco?t=01h37m42s)

[right](https://youtu.be/ep-GFaKjUco?t=01h37m46s)

[so speaking of my good friend so there](https://youtu.be/ep-GFaKjUco?t=01h37m48s)

[is no MSI out with that suff so that's](https://youtu.be/ep-GFaKjUco?t=01h37m51s)

[that that makes me feel sad uh so](https://youtu.be/ep-GFaKjUco?t=01h37m54s)

[clearly there's nothing](https://youtu.be/ep-GFaKjUco?t=01h37m57s)

[there test is accurately](https://youtu.be/ep-GFaKjUco?t=01h38m00s)

[failing](https://youtu.be/ep-GFaKjUco?t=01h38m04s)

[uh but I'm wondering now if the issue is](https://youtu.be/ep-GFaKjUco?t=01h38m06s)

[because it's not in that asset pack it's](https://youtu.be/ep-GFaKjUco?t=01h38m10s)

[not being copied to the appropriate](https://youtu.be/ep-GFaKjUco?t=01h38m12s)

[directory let's](https://youtu.be/ep-GFaKjUco?t=01h38m17s)

[see object file blah blah](https://youtu.be/ep-GFaKjUco?t=01h38m20s)

[blah see love it so far going to build a](https://youtu.be/ep-GFaKjUco?t=01h38m25s)

[few fun jobs out to update raspberry](https://youtu.be/ep-GFaKjUco?t=01h38m28s)

[pies as a test and then use those to how](https://youtu.be/ep-GFaKjUco?t=01h38m31s)

[to automate his it infrastructure](https://youtu.be/ep-GFaKjUco?t=01h38m34s)

[awesome that is a great way to do it](https://youtu.be/ep-GFaKjUco?t=01h38m36s)

[like I I often tell people build a](https://youtu.be/ep-GFaKjUco?t=01h38m39s)

[project that you like for fun and then](https://youtu.be/ep-GFaKjUco?t=01h38m41s)

[go from](https://youtu.be/ep-GFaKjUco?t=01h38m44s)

[there uh let's see so I'm](https://youtu.be/ep-GFaKjUco?t=01h38m46s)

[curious is this MSI file path is what is](https://youtu.be/ep-GFaKjUco?t=01h38m49s)

[going going to drive where it gets](https://youtu.be/ep-GFaKjUco?t=01h38m53s)

[written to did so the my my gut reaction](https://youtu.be/ep-GFaKjUco?t=01h38m54s)

[says this path is bad so let's grab it](https://youtu.be/ep-GFaKjUco?t=01h38m59s)

[here let's grab it here and see](https://youtu.be/ep-GFaKjUco?t=01h39m05s)

[why what MSI path is pointed to because](https://youtu.be/ep-GFaKjUco?t=01h39m08s)

[it's invoking the CLI tools and the CLI](https://youtu.be/ep-GFaKjUco?t=01h39m12s)

[tools are returning proper exit](https://youtu.be/ep-GFaKjUco?t=01h39m15s)

[codes so where is this](https://youtu.be/ep-GFaKjUco?t=01h39m18s)

[path okay so we are inside of](https://youtu.be/ep-GFaKjUco?t=01h39m21s)

[temp temp five right so there's](https://youtu.be/ep-GFaKjUco?t=01h39m25s)

[that I want to go there and take a quick](https://youtu.be/ep-GFaKjUco?t=01h39m30s)

[quick](https://youtu.be/ep-GFaKjUco?t=01h39m34s)

[Gander okay so we have all of this stuff](https://youtu.be/ep-GFaKjUco?t=01h39m36s)

[which is kind of what I would expect in](https://youtu.be/ep-GFaKjUco?t=01h39m39s)

[all of these](https://youtu.be/ep-GFaKjUco?t=01h39m42s)

[cases great so if I step over](https://youtu.be/ep-GFaKjUco?t=01h39m43s)

[this do your thing](https://youtu.be/ep-GFaKjUco?t=01h39m46s)

[okay that should now](https://youtu.be/ep-GFaKjUco?t=01h39m56s)

[have there it is](https://youtu.be/ep-GFaKjUco?t=01h40m04s)

[there](https://youtu.be/ep-GFaKjUco?t=01h40m07s)

[okay and](https://youtu.be/ep-GFaKjUco?t=01h40m12s)

[then oh there it](https://youtu.be/ep-GFaKjUco?t=01h40m13s)

[is it goes to move it to the release](https://youtu.be/ep-GFaKjUco?t=01h40m19s)

[directory which is temp](https://youtu.be/ep-GFaKjUco?t=01h40m22s)

[4 not temp five which is a temp](https://youtu.be/ep-GFaKjUco?t=01h40m25s)

[directory so because it is not](https://youtu.be/ep-GFaKjUco?t=01h40m29s)

[added to the asset cache it doesn't get](https://youtu.be/ep-GFaKjUco?t=01h40m33s)

[moved in the final step therefore](https://youtu.be/ep-GFaKjUco?t=01h40m37s)

[doesn't get written](https://youtu.be/ep-GFaKjUco?t=01h40m40s)

[out because this is a very very very](https://youtu.be/ep-GFaKjUco?t=01h40m44s)

[important](https://youtu.be/ep-GFaKjUco?t=01h40m48s)

[step the question becomes comes what is](https://youtu.be/ep-GFaKjUco?t=01h40m51s)

[the best way to](https://youtu.be/ep-GFaKjUco?t=01h40m54s)

[feed to get it into](https://youtu.be/ep-GFaKjUco?t=01h40m57s)

[here might have to go put that en value](https://youtu.be/ep-GFaKjUco?t=01h41m01s)

[back my undo buffer is](https://youtu.be/ep-GFaKjUco?t=01h41m11s)

[lost](https://youtu.be/ep-GFaKjUco?t=01h41m15s)

[uh let's see so can I make an educated](https://youtu.be/ep-GFaKjUco?t=01h41m19s)

[guess here the solution is to ensure it](https://youtu.be/ep-GFaKjUco?t=01h41m22s)

[does end up in a known location all the](https://youtu.be/ep-GFaKjUco?t=01h41m24s)

[time or search for it so in this case](https://youtu.be/ep-GFaKjUco?t=01h41m26s)

[here so the the basic steps that that](https://youtu.be/ep-GFaKjUco?t=01h41m29s)

[this thing is going through is](https://youtu.be/ep-GFaKjUco?t=01h41m32s)

[this and I I'll just collapse these guys](https://youtu.be/ep-GFaKjUco?t=01h41m35s)

[down a little](https://youtu.be/ep-GFaKjUco?t=01h41m38s)

[bit um this base Builder goes through](https://youtu.be/ep-GFaKjUco?t=01h41m40s)

[and runs a bunch of](https://youtu.be/ep-GFaKjUco?t=01h41m44s)

[steps oh video craw thank you for the uh](https://youtu.be/ep-GFaKjUco?t=01h41m47s)

[subscription I appreciate it uh but it](https://youtu.be/ep-GFaKjUco?t=01h41m51s)

[runs through each of these individual](https://youtu.be/ep-GFaKjUco?t=01h41m53s)

[tasks right you'll not it has this this](https://youtu.be/ep-GFaKjUco?t=01h41m55s)

[execute progress async It's just so it](https://youtu.be/ep-GFaKjUco?t=01h41m58s)

[can draw pretty progress bars when you](https://youtu.be/ep-GFaKjUco?t=01h42m00s)

[run on the command line but it's got all](https://youtu.be/ep-GFaKjUco?t=01h42m01s)

[of these tasks that it builds up and](https://youtu.be/ep-GFaKjUco?t=01h42m04s)

[executes and the very last one is it uh](https://youtu.be/ep-GFaKjUco?t=01h42m07s)

[is it goes from its asset cach and says](https://youtu.be/ep-GFaKjUco?t=01h42m12s)

[hey go through and move everything from](https://youtu.be/ep-GFaKjUco?t=01h42m14s)

[your](https://youtu.be/ep-GFaKjUco?t=01h42m16s)

[uh the that you know about into the](https://youtu.be/ep-GFaKjUco?t=01h42m18s)

[final release directory because some of](https://youtu.be/ep-GFaKjUco?t=01h42m20s)

[these things made work in other temp](https://youtu.be/ep-GFaKjUco?t=01h42m22s)

[directories but most of them are going](https://youtu.be/ep-GFaKjUco?t=01h42m24s)

[to be there and so this asset cache is](https://youtu.be/ep-GFaKjUco?t=01h42m25s)

[what's keeping track of he here's all](https://youtu.be/ep-GFaKjUco?t=01h42m28s)

[the files because we don't want to move](https://youtu.be/ep-GFaKjUco?t=01h42m30s)

[everything from the temp directory into](https://youtu.be/ep-GFaKjUco?t=01h42m32s)

[the final output it's kind of like the](https://youtu.be/ep-GFaKjUco?t=01h42m34s)

[difference between your obj directory](https://youtu.be/ep-GFaKjUco?t=01h42m36s)

[and your bin](https://youtu.be/ep-GFaKjUco?t=01h42m38s)

[directory right now it just exists in in](https://youtu.be/ep-GFaKjUco?t=01h42m39s)

[the obj directory and this is what moves](https://youtu.be/ep-GFaKjUco?t=01h42m42s)

[it from obj to](https://youtu.be/ep-GFaKjUco?t=01h42m45s)

[bin and I didn't add it to the cache](https://youtu.be/ep-GFaKjUco?t=01h42m46s)

[therefore it didn't get moved and at the](https://youtu.be/ep-GFaKjUco?t=01h42m49s)

[end of it it deletes out the obj](https://youtu.be/ep-GFaKjUco?t=01h42m51s)

[directory and so the lovely MSI that it](https://youtu.be/ep-GFaKjUco?t=01h42m53s)

[built gets](https://youtu.be/ep-GFaKjUco?t=01h42m57s)

[torched so then to your question I it](https://youtu.be/ep-GFaKjUco?t=01h42m59s)

[it's mostly move it to a known location](https://youtu.be/ep-GFaKjUco?t=01h43m03s)

[but it's the thing that's tracking the](https://youtu.be/ep-GFaKjUco?t=01h43m05s)

[locations is this build assets but this](https://youtu.be/ep-GFaKjUco?t=01h43m07s)

[build assets isn't being passed out](https://youtu.be/ep-GFaKjUco?t=01h43m10s)

[anywhere it's only being used](https://youtu.be/ep-GFaKjUco?t=01h43m13s)

[here yeah so it is literally a local](https://youtu.be/ep-GFaKjUco?t=01h43m17s)

[value here that](https://youtu.be/ep-GFaKjUco?t=01h43m21s)

[is not being passed to any](https://youtu.be/ep-GFaKjUco?t=01h43m23s)

[function and it](https://youtu.be/ep-GFaKjUco?t=01h43m28s)

[just creates up](https://youtu.be/ep-GFaKjUco?t=01h43m31s)

[yeah yeah so as far as as far as it's](https://youtu.be/ep-GFaKjUco?t=01h43m35s)

[concerned it built an MSI but it it](https://youtu.be/ep-GFaKjUco?t=01h43m39s)

[thinks the MSI is just another temp file](https://youtu.be/ep-GFaKjUco?t=01h43m41s)

[that's sitting alongside the other](https://youtu.be/ep-GFaKjUco?t=01h43m44s)

[stuff so like it it built up all of this](https://youtu.be/ep-GFaKjUco?t=01h43m47s)

[stuff and functionally it knows that it](https://youtu.be/ep-GFaKjUco?t=01h43m50s)

[needs to move some of these items across](https://youtu.be/ep-GFaKjUco?t=01h43m51s)

[but like some of these here like this](https://youtu.be/ep-GFaKjUco?t=01h43m54s)

[create portable package it's got all](https://youtu.be/ep-GFaKjUco?t=01h43m56s)

[these temp files we don't want to just](https://youtu.be/ep-GFaKjUco?t=01h43m58s)

[blindly copy everything](https://youtu.be/ep-GFaKjUco?t=01h43m59s)

[over](https://youtu.be/ep-GFaKjUco?t=01h44m01s)

[um but I do want this thing added to the](https://youtu.be/ep-GFaKjUco?t=01h44m03s)

[set so I think the solution is probably](https://youtu.be/ep-GFaKjUco?t=01h44m06s)

[going to](https://youtu.be/ep-GFaKjUco?t=01h44m09s)

[be a way to share this asset cache](https://youtu.be/ep-GFaKjUco?t=01h44m13s)

[out um](https://youtu.be/ep-GFaKjUco?t=01h44m19s)

[I'm I'm a little hesitant](https://youtu.be/ep-GFaKjUco?t=01h44m24s)

[to move](https://youtu.be/ep-GFaKjUco?t=01h44m26s)

[it blindly I kind of feel like some of](https://youtu.be/ep-GFaKjUco?t=01h44m28s)

[these other functions need to have it](https://youtu.be/ep-GFaKjUco?t=01h44m32s)

[there](https://youtu.be/ep-GFaKjUco?t=01h44m35s)

[um because there's a bunch of these uh](https://youtu.be/ep-GFaKjUco?t=01h44m38s)

[virtual get main exe search pads all of](https://youtu.be/ep-GFaKjUco?t=01h44m41s)

[these extra](https://youtu.be/ep-GFaKjUco?t=01h44m43s)

[things that go along with it this code](https://youtu.be/ep-GFaKjUco?t=01h44m46s)

[signing create portable package create](https://youtu.be/ep-GFaKjUco?t=01h44m48s)

[Delta packages and each of the platforms](https://youtu.be/ep-GFaKjUco?t=01h44m51s)

[kind of implement these a little](https://youtu.be/ep-GFaKjUco?t=01h44m53s)

[differently as](https://youtu.be/ep-GFaKjUco?t=01h44m55s)

[needed and so I kind of want](https://youtu.be/ep-GFaKjUco?t=01h44m58s)

[to why is this](https://youtu.be/ep-GFaKjUco?t=01h45m03s)

[one oh Linux needed to overwrite it](https://youtu.be/ep-GFaKjUco?t=01h45m06s)

[okay got](https://youtu.be/ep-GFaKjUco?t=01h45m09s)

[it while I'm in here I can't resist](https://youtu.be/ep-GFaKjUco?t=01h45m12s)

[temptation](https://youtu.be/ep-GFaKjUco?t=01h45m15s)

[to nope not what I wanted to do](https://youtu.be/ep-GFaKjUco?t=01h45m17s)

[collection initializer you do](https://youtu.be/ep-GFaKjUco?t=01h45m21s)

[at that point this thing might as well](https://youtu.be/ep-GFaKjUco?t=01h45m24s)

[be an expression bodied member cuz you](https://youtu.be/ep-GFaKjUco?t=01h45m26s)

[are not](https://youtu.be/ep-GFaKjUco?t=01h45m29s)

[fancy can't resist can't resist](https://youtu.be/ep-GFaKjUco?t=01h45m32s)

[collection initializers are just too](https://youtu.be/ep-GFaKjUco?t=01h45m34s)

[cool must use them](https://youtu.be/ep-GFaKjUco?t=01h45m36s)

[um kind of scanning through these](https://youtu.be/ep-GFaKjUco?t=01h45m42s)

[because I had to do this effective title](https://youtu.be/ep-GFaKjUco?t=01h45m45s)

[and similar stuff to be able to share](https://youtu.be/ep-GFaKjUco?t=01h45m47s)

[some logic cu the MSI needed access to](https://youtu.be/ep-GFaKjUco?t=01h45m49s)

[this but this title was also used to](https://youtu.be/ep-GFaKjUco?t=01h45m52s)

[generate the the new spec file that gets](https://youtu.be/ep-GFaKjUco?t=01h45m54s)

[used so I I pulled them into shared](https://youtu.be/ep-GFaKjUco?t=01h45m58s)

[functions but in this](https://youtu.be/ep-GFaKjUco?t=01h46m01s)

[case this should really get converted](https://youtu.be/ep-GFaKjUco?t=01h46m03s)

[into a source generator version this is](https://youtu.be/ep-GFaKjUco?t=01h46m05s)

[this is beautiful for Source generator I](https://youtu.be/ep-GFaKjUco?t=01h46m09s)

[I think what I'm going to end up needing](https://youtu.be/ep-GFaKjUco?t=01h46m12s)

[to do is](https://youtu.be/ep-GFaKjUco?t=01h46m13s)

[pass that build asset down](https://youtu.be/ep-GFaKjUco?t=01h46m16s)

[I I'm trying to decide whether I pass](https://youtu.be/ep-GFaKjUco?t=01h46m23s)

[the build assets class out which kind of](https://youtu.be/ep-GFaKjUco?t=01h46m25s)

[exposes a lot or if I pass out like a](https://youtu.be/ep-GFaKjUco?t=01h46m29s)

[funk or a delegate of some kind because](https://youtu.be/ep-GFaKjUco?t=01h46m31s)

[functionally what I want to](https://youtu.be/ep-GFaKjUco?t=01h46m34s)

[do uh in the windows Runner this is the](https://youtu.be/ep-GFaKjUco?t=01h46m37s)

[line here that previously was leveraging](https://youtu.be/ep-GFaKjUco?t=01h46m41s)

[the asset](https://youtu.be/ep-GFaKjUco?t=01h46m43s)

[cache and really all I want to do is get](https://youtu.be/ep-GFaKjUco?t=01h46m45s)

[the appropriate path for an](https://youtu.be/ep-GFaKjUco?t=01h46m49s)

[MSI which this path works but I need it](https://youtu.be/ep-GFaKjUco?t=01h46m51s)

[added into](https://youtu.be/ep-GFaKjUco?t=01h46m55s)

[the the asset cach as well I kind of](https://youtu.be/ep-GFaKjUco?t=01h46m57s)

[like the delicate](https://youtu.be/ep-GFaKjUco?t=01h47m00s)

[idea delegate idea might not be bad let](https://youtu.be/ep-GFaKjUco?t=01h47m02s)

[me go put the en back first of](https://youtu.be/ep-GFaKjUco?t=01h47m07s)

[all and now shoot myself for deleting it](https://youtu.be/ep-GFaKjUco?t=01h47m11s)

[I've got a little too carried away](https://youtu.be/ep-GFaKjUco?t=01h47m14s)

[should have waited to delete until I](https://youtu.be/ep-GFaKjUco?t=01h47m15s)

[had](https://youtu.be/ep-GFaKjUco?t=01h47m18s)

[um waited to delete it until I actually](https://youtu.be/ep-GFaKjUco?t=01h47m20s)

[run the test that would have been](https://youtu.be/ep-GFaKjUco?t=01h47m23s)

[smarter uh is the build process itself](https://youtu.be/ep-GFaKjUco?t=01h47m25s)

[exposable because I'm thinking then you](https://youtu.be/ep-GFaKjUco?t=01h47m28s)

[could tap into the build process and](https://youtu.be/ep-GFaKjUco?t=01h47m30s)

[look for the package and copy a](https://youtu.be/ep-GFaKjUco?t=01h47m31s)

[duplicate to the destination which would](https://youtu.be/ep-GFaKjUco?t=01h47m34s)

[keep your original in the assets oh](https://youtu.be/ep-GFaKjUco?t=01h47m36s)

[that's an interesting](https://youtu.be/ep-GFaKjUco?t=01h47m39s)

[idea let's](https://youtu.be/ep-GFaKjUco?t=01h47m41s)

[look I](https://youtu.be/ep-GFaKjUco?t=01h47m44s)

[I I think the answer is it could be I](https://youtu.be/ep-GFaKjUco?t=01h47m48s)

[don't believe it is](https://youtu.be/ep-GFaKjUco?t=01h47m53s)

[now but it could be so down here in the](https://youtu.be/ep-GFaKjUco?t=01h47m54s)

[postprocess right now it's just shelling](https://youtu.be/ep-GFaKjUco?t=01h48m00s)

[out to this asset](https://youtu.be/ep-GFaKjUco?t=01h48m02s)

[cach but there's no reason that this](https://youtu.be/ep-GFaKjUco?t=01h48m06s)

[couldn't also live in a virtual](https://youtu.be/ep-GFaKjUco?t=01h48m08s)

[function yeah that's an interesting idea](https://youtu.be/ep-GFaKjUco?t=01h48m19s)

[idea too maybe I I like that](https://youtu.be/ep-GFaKjUco?t=01h48m22s)

[better the only challenge then and this](https://youtu.be/ep-GFaKjUco?t=01h48m27s)

[is one of the things I'm trying to avoid](https://youtu.be/ep-GFaKjUco?t=01h48m30s)

[storing State](https://youtu.be/ep-GFaKjUco?t=01h48m32s)

[outside because right now it right now](https://youtu.be/ep-GFaKjUco?t=01h48m34s)

[everything can run in parallel and is](https://youtu.be/ep-GFaKjUco?t=01h48m38s)

[nice and fast and so I'm a I like the](https://youtu.be/ep-GFaKjUco?t=01h48m40s)

[idea of it being a parameter that gets](https://youtu.be/ep-GFaKjUco?t=01h48m43s)

[passed in if I don't add it to the asset](https://youtu.be/ep-GFaKjUco?t=01h48m45s)

[cash then I have to keep track of the](https://youtu.be/ep-GFaKjUco?t=01h48m50s)

[MSI Andor search the](https://youtu.be/ep-GFaKjUco?t=01h48m53s)

[MSI when I override the](https://youtu.be/ep-GFaKjUco?t=01h48m58s)

[output copy it](https://youtu.be/ep-GFaKjUco?t=01h49m03s)

[over that could](https://youtu.be/ep-GFaKjUco?t=01h49m06s)

[do could do it would require wrapping](https://youtu.be/ep-GFaKjUco?t=01h49m11s)

[this little bit up in a nice function to](https://youtu.be/ep-GFaKjUco?t=01h49m15s)

[share in both places which is totally](https://youtu.be/ep-GFaKjUco?t=01h49m17s)

[doable it is absolutely doable](https://youtu.be/ep-GFaKjUco?t=01h49m19s)

[well or is it because I would need the](https://youtu.be/ep-GFaKjUco?t=01h49m25s)

[exe path which means once again I need](https://youtu.be/ep-GFaKjUco?t=01h49m27s)

[to then extract something from](https://youtu.be/ep-GFaKjUco?t=01h49m29s)

[it gives me pause again I](https://youtu.be/ep-GFaKjUco?t=01h49m32s)

[um I don't](https://youtu.be/ep-GFaKjUco?t=01h49m35s)

[like yeah I think I almost](https://youtu.be/ep-GFaKjUco?t=01h49m39s)

[like well regardless let's put let's put](https://youtu.be/ep-GFaKjUco?t=01h49m43s)

[the let's put the enum back first of](https://youtu.be/ep-GFaKjUco?t=01h49m45s)

[all all right that that we're going to](https://youtu.be/ep-GFaKjUco?t=01h49m48s)

[put back um](https://youtu.be/ep-GFaKjUco?t=01h49m50s)

[first before I get too carried away and](https://youtu.be/ep-GFaKjUco?t=01h49m53s)

[I need to put back the CH the name](https://youtu.be/ep-GFaKjUco?t=01h49m55s)

[change MSI deployment tool suggestion I](https://youtu.be/ep-GFaKjUco?t=01h49m57s)

[think we take](https://youtu.be/ep-GFaKjUco?t=01h50m01s)

[it](https://youtu.be/ep-GFaKjUco?t=01h50m03s)

[or](https://youtu.be/ep-GFaKjUco?t=01h50m07s)

[uh think I think I want to do that just](https://youtu.be/ep-GFaKjUco?t=01h50m10s)

[to be really clear that this isn't a](https://youtu.be/ep-GFaKjUco?t=01h50m13s)

[because the thing we don't want to do](https://youtu.be/ep-GFaKjUco?t=01h50m15s)

[here is have people think that this MSI](https://youtu.be/ep-GFaKjUco?t=01h50m17s)

[is an an U valid MSI installer like it](https://youtu.be/ep-GFaKjUco?t=01h50m19s)

[is a valid installer but it's not it's](https://youtu.be/ep-GFaKjUco?t=01h50m24s)

[not a replacement for the actual](https://youtu.be/ep-GFaKjUco?t=01h50m28s)

[installer it's an MSI that is used to](https://youtu.be/ep-GFaKjUco?t=01h50m30s)

[deploy the](https://youtu.be/ep-GFaKjUco?t=01h50m34s)

[installer I don't know how to capture](https://youtu.be/ep-GFaKjUco?t=01h50m35s)

[that yeah so I think what we're going to](https://youtu.be/ep-GFaKjUco?t=01h50m42s)

[do here is change this guy up a little](https://youtu.be/ep-GFaKjUco?t=01h50m44s)

[bit I think we're just going to tack](https://youtu.be/ep-GFaKjUco?t=01h50m49s)

[something on the end](https://youtu.be/ep-GFaKjUco?t=01h50m51s)

[here that's](https://youtu.be/ep-GFaKjUco?t=01h50m53s)

[um](https://youtu.be/ep-GFaKjUco?t=01h51m01s)

[uh uh let's](https://youtu.be/ep-GFaKjUco?t=01h51m06s)

[see then that goes up](https://youtu.be/ep-GFaKjUco?t=01h51m20s)

[here this no longer needs to](https://youtu.be/ep-GFaKjUco?t=01h51m25s)

[exist that can go away](https://youtu.be/ep-GFaKjUco?t=01h51m28s)

[too but what needs to exist is here](https://youtu.be/ep-GFaKjUco?t=01h51m30s)

[needs to take in](https://youtu.be/ep-GFaKjUco?t=01h51m34s)

[a relative](https://youtu.be/ep-GFaKjUco?t=01h51m36s)

[path asset](https://youtu.be/ep-GFaKjUco?t=01h51m39s)

[type then this needs to be asset](https://youtu.be/ep-GFaKjUco?t=01h51m42s)

[cache uh make asset path actually I](https://youtu.be/ep-GFaKjUco?t=01h51m45s)

[guess I can probably pass this as](https://youtu.be/ep-GFaKjUco?t=01h51m48s)

[a method group](https://youtu.be/ep-GFaKjUco?t=01h51m50s)

[the wrong return](https://youtu.be/ep-GFaKjUco?t=01h51m54s)

[type](https://youtu.be/ep-GFaKjUco?t=01h51m59s)

[oh yep it absolutely does have the wrong](https://youtu.be/ep-GFaKjUco?t=01h52m02s)

[return type parameter](https://youtu.be/ep-GFaKjUco?t=01h52m05s)

[parameter](https://youtu.be/ep-GFaKjUco?t=01h52m07s)

[ring we pass it that way then the caller](https://youtu.be/ep-GFaKjUco?t=01h52m12s)

[doesn't need to know about it does mean](https://youtu.be/ep-GFaKjUco?t=01h52m15s)

[this has to change to match](https://youtu.be/ep-GFaKjUco?t=01h52m18s)

[this is almost a case so the the thing](https://youtu.be/ep-GFaKjUco?t=01h52m28s)

[that I don't like a little bit about](https://youtu.be/ep-GFaKjUco?t=01h52m30s)

[this is the fact this string is not](https://youtu.be/ep-GFaKjUco?t=01h52m32s)

[named there there's no hint here this is](https://youtu.be/ep-GFaKjUco?t=01h52m35s)

[one of those cases where Funk and action](https://youtu.be/ep-GFaKjUco?t=01h52m37s)

[are nice but I'm seriously tempted to do](https://youtu.be/ep-GFaKjUco?t=01h52m39s)

[a custom delegate type here um just to](https://youtu.be/ep-GFaKjUco?t=01h52m42s)

[just so I can ascribe a meaning and a](https://youtu.be/ep-GFaKjUco?t=01h52m46s)

[name to this parameter because it's not](https://youtu.be/ep-GFaKjUco?t=01h52m49s)

[really really clear what this](https://youtu.be/ep-GFaKjUco?t=01h52m52s)

[is now we're going to roll with it uh](https://youtu.be/ep-GFaKjUco?t=01h52m56s)

[let's see so this is should have two](https://youtu.be/ep-GFaKjUco?t=01h52m59s)

[compile airs I think in the OSX and](https://youtu.be/ep-GFaKjUco?t=01h53m01s)

[Linux](https://youtu.be/ep-GFaKjUco?t=01h53m05s)

[Builders the other two derive classes I](https://youtu.be/ep-GFaKjUco?t=01h53m06s)

[was going to get it building and](https://youtu.be/ep-GFaKjUco?t=01h53m09s)

[then make it](https://youtu.be/ep-GFaKjUco?t=01h53m10s)

[work just in the](https://youtu.be/ep-GFaKjUco?t=01h53m14s)

[one thank](https://youtu.be/ep-GFaKjUco?t=01h53m17s)

[you prized](https://youtu.be/ep-GFaKjUco?t=01h53m20s)

[the Linux one doesn't overwrite](https://youtu.be/ep-GFaKjUco?t=01h53m24s)

[it it must not need](https://youtu.be/ep-GFaKjUco?t=01h53m33s)

[it oh it doesn't it doesn't need it oh I](https://youtu.be/ep-GFaKjUco?t=01h53m41s)

[guess it's just using the portable one](https://youtu.be/ep-GFaKjUco?t=01h53m44s)

[so it kind of makes sense why it because](https://youtu.be/ep-GFaKjUco?t=01h53m46s)

[Linux doesn't have a setup package it](https://youtu.be/ep-GFaKjUco?t=01h53m48s)

[just has a portable installer so okay](https://youtu.be/ep-GFaKjUco?t=01h53m50s)

[kind of makes sense it it doesn't](https://youtu.be/ep-GFaKjUco?t=01h53m52s)

[generate it doesn't need it okay so down](https://youtu.be/ep-GFaKjUco?t=01h53m54s)

[here then this guy actually needs to](https://youtu.be/ep-GFaKjUco?t=01h53m56s)

[leverage this so VAR MSI path is going](https://youtu.be/ep-GFaKjUco?t=01h53m59s)

[to become create](https://youtu.be/ep-GFaKjUco?t=01h54m03s)

[asset uh we're going to need to](https://youtu.be/ep-GFaKjUco?t=01h54m06s)

[do that's not right but we're going to](https://youtu.be/ep-GFaKjUco?t=01h54m10s)

[use it here bipac asset type MSI](https://youtu.be/ep-GFaKjUco?t=01h54m12s)

[deployment tool that goes](https://youtu.be/ep-GFaKjUco?t=01h54m15s)

[there yeah exactly um I just want to](https://youtu.be/ep-GFaKjUco?t=01h54m18s)

[check on what I had previously before I](https://youtu.be/ep-GFaKjUco?t=01h54m22s)

[get too carried](https://youtu.be/ep-GFaKjUco?t=01h54m26s)

[away uh this doesn't show me what I want](https://youtu.be/ep-GFaKjUco?t=01h54m28s)

[so of course opened in the wrong browser](https://youtu.be/ep-GFaKjUco?t=01h54m32s)

[um just want to look at](https://youtu.be/ep-GFaKjUco?t=01h54m36s)

[what I had done previously on the other](https://youtu.be/ep-GFaKjUco?t=01h54m40s)

[side those go away that goes](https://youtu.be/ep-GFaKjUco?t=01h54m43s)

[away that goes](https://youtu.be/ep-GFaKjUco?t=01h54m46s)

[away actually generating it I'm just](https://youtu.be/ep-GFaKjUco?t=01h54m50s)

[looking for](https://youtu.be/ep-GFaKjUco?t=01h54m53s)

[the oh yeah I made the air messaging](https://youtu.be/ep-GFaKjUco?t=01h55m01s)

[better](https://youtu.be/ep-GFaKjUco?t=01h55m04s)

[too okay so this is the setup e exe](https://youtu.be/ep-GFaKjUco?t=01h55m05s)

[path this took MSI name oh so it just](https://youtu.be/ep-GFaKjUco?t=01h55m10s)

[fed the name in and it relied on it to](https://youtu.be/ep-GFaKjUco?t=01h55m15s)

[use the ah right because the asset path](https://youtu.be/ep-GFaKjUco?t=01h55m17s)

[has everything it needs that just uh](https://youtu.be/ep-GFaKjUco?t=01h55m20s)

[that goes there this then goes](https://youtu.be/ep-GFaKjUco?t=01h55m25s)

[away yeah when portable selfed works it](https://youtu.be/ep-GFaKjUco?t=01h55m29s)

[is sweet I absolutely agree 100% agree](https://youtu.be/ep-GFaKjUco?t=01h55m33s)

[with that](https://youtu.be/ep-GFaKjUco?t=01h55m37s)

[one okay so that](https://youtu.be/ep-GFaKjUco?t=01h55m38s)

[now should just](https://youtu.be/ep-GFaKjUco?t=01h55m41s)

[work we will go rerun the test I'm very](https://youtu.be/ep-GFaKjUco?t=01h55m44s)

[happy to have tests for this by the way](https://youtu.be/ep-GFaKjUco?t=01h55m49s)

[one of those areas where like some of](https://youtu.be/ep-GFaKjUco?t=01h55m52s)

[these tests are a pain to set up and if](https://youtu.be/ep-GFaKjUco?t=01h55m55s)

[you try to uh there's been a number of](https://youtu.be/ep-GFaKjUco?t=01h55m57s)

[people who have contributed to the velop](https://youtu.be/ep-GFaKjUco?t=01h56m00s)

[PAC repository directly so huge props to](https://youtu.be/ep-GFaKjUco?t=01h56m01s)

[them](https://youtu.be/ep-GFaKjUco?t=01h56m04s)

[um we we have on our docket to do better](https://youtu.be/ep-GFaKjUco?t=01h56m06s)

[contributor docks because the setup for](https://youtu.be/ep-GFaKjUco?t=01h56m09s)

[the repo is](https://youtu.be/ep-GFaKjUco?t=01h56m12s)

[non-trivial like you can kind of work](https://youtu.be/ep-GFaKjUco?t=01h56m14s)

[your way through the the GitHub action](https://youtu.be/ep-GFaKjUco?t=01h56m15s)

[stuff to figure out what the setup needs](https://youtu.be/ep-GFaKjUco?t=01h56m18s)

[to look like but like there's a lot](https://youtu.be/ep-GFaKjUco?t=01h56m19s)

[there because there's there's rust](https://youtu.be/ep-GFaKjUco?t=01h56m23s)

[binaries that you need it's not just a](https://youtu.be/ep-GFaKjUco?t=01h56m24s)

[fire visual studio hit F5 it's kind of a](https://youtu.be/ep-GFaKjUco?t=01h56m27s)

[it's a big boy okay we're going to go](https://youtu.be/ep-GFaKjUco?t=01h56m32s)

[for gold](https://youtu.be/ep-GFaKjUco?t=01h56m34s)

[now we're GNA go for gold straight](https://youtu.be/ep-GFaKjUco?t=01h56m36s)

[run](https://youtu.be/ep-GFaKjUco?t=01h56m39s)

[and let](https://youtu.be/ep-GFaKjUco?t=01h56m41s)

[Explorer show me green check](https://youtu.be/ep-GFaKjUco?t=01h56m44s)

[mark I would like to see a green check](https://youtu.be/ep-GFaKjUco?t=01h56m47s)

[mark](https://youtu.be/ep-GFaKjUco?t=01h56m49s)

[yay okay now does the version override](https://youtu.be/ep-GFaKjUco?t=01h56m50s)

[work](https://youtu.be/ep-GFaKjUco?t=01h56m54s)

[probably I'm sort of holding off running](https://youtu.be/ep-GFaKjUco?t=01h57m06s)

[all the tests because not really worth](https://youtu.be/ep-GFaKjUco?t=01h57m09s)

[it because you can see some of these](https://youtu.be/ep-GFaKjUco?t=01h57m11s)

[tests like again these are not really](https://youtu.be/ep-GFaKjUco?t=01h57m12s)

[unit tests these are full end to end](https://youtu.be/ep-GFaKjUco?t=01h57m14s)

[integration](https://youtu.be/ep-GFaKjUco?t=01h57m16s)

[tests and I shouldn't say complete end](https://youtu.be/ep-GFaKjUco?t=01h57m18s)

[to end they are they're hitting straight](https://youtu.be/ep-GFaKjUco?t=01h57m20s)

[API Runners but this also then actually](https://youtu.be/ep-GFaKjUco?t=01h57m24s)

[cracks open the MSI to verify that](https://youtu.be/ep-GFaKjUco?t=01h57m27s)

[particular versions are actually set](https://youtu.be/ep-GFaKjUco?t=01h57m29s)

[it's not a great test to make sure that](https://youtu.be/ep-GFaKjUco?t=01h57m31s)

[everything in the MSI is set up just](https://youtu.be/ep-GFaKjUco?t=01h57m33s)

[perfectly but it's it is good](https://youtu.be/ep-GFaKjUco?t=01h57m35s)

[enough good enough to give me high](https://youtu.be/ep-GFaKjUco?t=01h57m39s)

[confidence](https://youtu.be/ep-GFaKjUco?t=01h57m42s)

[okay now we come back here and I](https://youtu.be/ep-GFaKjUco?t=01h57m43s)

[think just check the the diffs I'm going](https://youtu.be/ep-GFaKjUco?t=01h57m47s)

[to move my big head to the](https://youtu.be/ep-GFaKjUco?t=01h57m50s)

[okay so this one here we changed up the](https://youtu.be/ep-GFaKjUco?t=01h57m53s)

[name of the enom and changed up the](https://youtu.be/ep-GFaKjUco?t=01h57m56s)

[description great uh](https://youtu.be/ep-GFaKjUco?t=01h57m59s)

[stage uh let's see I want to bring you](https://youtu.be/ep-GFaKjUco?t=01h58m01s)

[down a little bit and actually I'm going](https://youtu.be/ep-GFaKjUco?t=01h58m04s)

[to shrink this up just a little bit so](https://youtu.be/ep-GFaKjUco?t=01h58m05s)

[I've got a little more space to work](https://youtu.be/ep-GFaKjUco?t=01h58m07s)

[okay we deleted the thing off the](https://youtu.be/ep-GFaKjUco?t=01h58m08s)

[interface good pack Builder we're going](https://youtu.be/ep-GFaKjUco?t=01h58m10s)

[to come back to Linux pack option we](https://youtu.be/ep-GFaKjUco?t=01h58m12s)

[deleted the property I realize my big](https://youtu.be/ep-GFaKjUco?t=01h58m15s)

[head is blocking it my apologies at the](https://youtu.be/ep-GFaKjUco?t=01h58m17s)

[bottom so I can't do it](https://youtu.be/ep-GFaKjUco?t=01h58m19s)

[never use unit test work on a project](https://youtu.be/ep-GFaKjUco?t=01h58m27s)

[large enough to need it keep looking for](https://youtu.be/ep-GFaKjUco?t=01h58m30s)

[ways to implement them and things like](https://youtu.be/ep-GFaKjUco?t=01h58m32s)

[uh slacker yeah so that's actually a](https://youtu.be/ep-GFaKjUco?t=01h58m35s)

[really good point some people get really](https://youtu.be/ep-GFaKjUco?t=01h58m38s)

[hung up on the idea of unit tests I](https://youtu.be/ep-GFaKjUco?t=01h58m40s)

[think what's important is that your app](https://youtu.be/ep-GFaKjUco?t=01h58m42s)

[is tested right because any app that is](https://youtu.be/ep-GFaKjUco?t=01h58m44s)

[actively getting used or any software](https://youtu.be/ep-GFaKjUco?t=01h58m48s)

[that is active getting used is](https://youtu.be/ep-GFaKjUco?t=01h58m51s)

[functionally being tested by the end](https://youtu.be/ep-GFaKjUco?t=01h58m53s)

[User it's](https://youtu.be/ep-GFaKjUco?t=01h58m54s)

[just some categories of bugs are very](https://youtu.be/ep-GFaKjUco?t=01h58m56s)

[expensive and so you want to you want to](https://youtu.be/ep-GFaKjUco?t=01h59m00s)

[catch them early because there's been](https://youtu.be/ep-GFaKjUco?t=01h59m02s)

[plenty of studies that show the further](https://youtu.be/ep-GFaKjUco?t=01h59m04s)

[out uh bug gets the more costly it is in](https://youtu.be/ep-GFaKjUco?t=01h59m06s)

[terms of like developer time and effort](https://youtu.be/ep-GFaKjUco?t=01h59m10s)

[to track it down fix get a thing out](https://youtu.be/ep-GFaKjUco?t=01h59m11s)

[lost reputation Etc potential loss](https://youtu.be/ep-GFaKjUco?t=01h59m14s)

[finances and those types of things like](https://youtu.be/ep-GFaKjUco?t=01h59m17s)

[that's where the the idea of oh we got](https://youtu.be/ep-GFaKjUco?t=01h59m19s)

[to test but it doesn't have to be a unit](https://youtu.be/ep-GFaKjUco?t=01h59m20s)

[test like unit tests are good and they](https://youtu.be/ep-GFaKjUco?t=01h59m23s)

[catch a particular category of bugs](https://youtu.be/ep-GFaKjUco?t=01h59m26s)

[right they're they're good at that and I](https://youtu.be/ep-GFaKjUco?t=01h59m29s)

[usually tell people every type of](https://youtu.be/ep-GFaKjUco?t=01h59m32s)

[testing has a blind spot or or a](https://youtu.be/ep-GFaKjUco?t=01h59m33s)

[negative right there's a pro and con to](https://youtu.be/ep-GFaKjUco?t=01h59m36s)

[every type of testing manual tests work](https://youtu.be/ep-GFaKjUco?t=01h59m37s)

[great cons they're you're you're usually](https://youtu.be/ep-GFaKjUco?t=01h59m41s)

[done by humans uh and unless they're](https://youtu.be/ep-GFaKjUco?t=01h59m44s)

[very carefully scripted it's easy for](https://youtu.be/ep-GFaKjUco?t=01h59m46s)

[the human to forget things or or miss](https://youtu.be/ep-GFaKjUco?t=01h59m48s)

[things or or make mistakes and they also](https://youtu.be/ep-GFaKjUco?t=01h59m50s)

[take a lot of time because you know the](https://youtu.be/ep-GFaKjUco?t=01h59m52s)

[human only goes so fast so it's like but](https://youtu.be/ep-GFaKjUco?t=01h59m54s)

[for some projects that's a very](https://youtu.be/ep-GFaKjUco?t=01h59m58s)

[acceptable tradeoff right it mean the](https://youtu.be/ep-GFaKjUco?t=02h00m00s)

[the other Pro is you didn't spend any](https://youtu.be/ep-GFaKjUco?t=02h00m03s)

[time writing any extra stuff right it's](https://youtu.be/ep-GFaKjUco?t=02h00m05s)

[just I manually go clicky clicky clicky](https://youtu.be/ep-GFaKjUco?t=02h00m09s)

[and make sure it](https://youtu.be/ep-GFaKjUco?t=02h00m11s)

[works uh let's see where I get hung up](https://youtu.be/ep-GFaKjUco?t=02h00m12s)

[is developing unit test uh for slack](https://youtu.be/ep-GFaKjUco?t=02h00m15s)

[Lord is that even though uh the Json has](https://youtu.be/ep-GFaKjUco?t=02h00m17s)

[the same dictionaries and keys the order](https://youtu.be/ep-GFaKjUco?t=02h00m20s)

[them specifically is what could cause](https://youtu.be/ep-GFaKjUco?t=02h00m22s)

[the bug yeah and that I think that's](https://youtu.be/ep-GFaKjUco?t=02h00m24s)

[you're you're asking the right question](https://youtu.be/ep-GFaKjUco?t=02h00m27s)

[right because when writing tests I often](https://youtu.be/ep-GFaKjUco?t=02h00m29s)

[tell people the the first and most](https://youtu.be/ep-GFaKjUco?t=02h00m31s)

[important question to answer is what am](https://youtu.be/ep-GFaKjUco?t=02h00m33s)

[I trying to test right what is what am I](https://youtu.be/ep-GFaKjUco?t=02h00m35s)

[what type of bug or or thing am I](https://youtu.be/ep-GFaKjUco?t=02h00m40s)

[worried about happening because](https://youtu.be/ep-GFaKjUco?t=02h00m42s)

[sometimes you're writing a pinning test](https://youtu.be/ep-GFaKjUco?t=02h00m44s)

[where it's this functionality has to be](https://youtu.be/ep-GFaKjUco?t=02h00m46s)

[exactly this way and if anything changes](https://youtu.be/ep-GFaKjUco?t=02h00m48s)

[it I want to guard my myself from future](https://youtu.be/ep-GFaKjUco?t=02h00m51s)

[Kevin you know being stupid and making a](https://youtu.be/ep-GFaKjUco?t=02h00m53s)

[change that breaks this right so if it's](https://youtu.be/ep-GFaKjUco?t=02h00m56s)

[like the order of keys in a Json file is](https://youtu.be/ep-GFaKjUco?t=02h00m57s)

[important maybe I write a test that](https://youtu.be/ep-GFaKjUco?t=02h01m00s)

[reads the Json file and asserts on the](https://youtu.be/ep-GFaKjUco?t=02h01m02s)

[order of the keys right but then the](https://youtu.be/ep-GFaKjUco?t=02h01m04s)

[other question is well what's the cost](https://youtu.be/ep-GFaKjUco?t=02h01m06s)

[of that bug coming in right when is it](https://youtu.be/ep-GFaKjUco?t=02h01m08s)

[likely to be caught if it's likely to be](https://youtu.be/ep-GFaKjUco?t=02h01m11s)

[caught right as I deploy and it's](https://youtu.be/ep-GFaKjUco?t=02h01m12s)

[unlikely that it's going to like bring](https://youtu.be/ep-GFaKjUco?t=02h01m14s)

[down everything or it's not going to](https://youtu.be/ep-GFaKjUco?t=02h01m15s)

[take long to fix if it does he there](https://youtu.be/ep-GFaKjUco?t=02h01m17s)

[there's a pro and a con tradeoff there](https://youtu.be/ep-GFaKjUco?t=02h01m20s)

[that's potentially worth](https://youtu.be/ep-GFaKjUco?t=02h01m22s)

[considering right because some projects](https://youtu.be/ep-GFaKjUco?t=02h01m25s)

[don't need it like I have a a little](https://youtu.be/ep-GFaKjUco?t=02h01m27s)

[budget application that I've built that](https://youtu.be/ep-GFaKjUco?t=02h01m30s)

[is used by me me and](https://youtu.be/ep-GFaKjUco?t=02h01m31s)

[me and I have some tests in there](https://youtu.be/ep-GFaKjUco?t=02h01m35s)

[probably a few more than I actually need](https://youtu.be/ep-GFaKjUco?t=02h01m38s)

[um because I got annoyed at uh the](https://youtu.be/ep-GFaKjUco?t=02h01m41s)

[amount of time I would waste uh when](https://youtu.be/ep-GFaKjUco?t=02h01m45s)

[there was a a bug and I'm trying to Bal](https://youtu.be/ep-GFaKjUco?t=02h01m48s)

[when I'm trying to balance my budget at](https://youtu.be/ep-GFaKjUco?t=02h01m50s)

[the end of the month and numbers aren't](https://youtu.be/ep-GFaKjUco?t=02h01m51s)

[lining up it really bothers me when the](https://youtu.be/ep-GFaKjUco?t=02h01m53s)

[bug when it's because my software isn't](https://youtu.be/ep-GFaKjUco?t=02h01m56s)

[reporting the right number and it's on](https://youtu.be/ep-GFaKjUco?t=02h01m58s)

[me it's like dang nabbit that I just](https://youtu.be/ep-GFaKjUco?t=02h01m59s)

[wasted an hour of my life to do it so](https://youtu.be/ep-GFaKjUco?t=02h02m01s)

[that's that's the cost of the bug to me](https://youtu.be/ep-GFaKjUco?t=02h02m03s)

[is it wastes my time um because then I](https://youtu.be/ep-GFaKjUco?t=02h02m05s)

[chase a a ghost or a phantom transaction](https://youtu.be/ep-GFaKjUco?t=02h02m07s)

[that's not there and that's very](https://youtu.be/ep-GFaKjUco?t=02h02m10s)

[annoying um so I have a certain number](https://youtu.be/ep-GFaKjUco?t=02h02m13s)

[of Testa in there just to kind of](https://youtu.be/ep-GFaKjUco?t=02h02m16s)

[guarantee good data Integrity coming](https://youtu.be/ep-GFaKjUco?t=02h02m17s)

[through but I don't test everything](https://youtu.be/ep-GFaKjUco?t=02h02m19s)

[because some of it's like the cost of a](https://youtu.be/ep-GFaKjUco?t=02h02m22s)

[bug showing up in certain areas are](https://youtu.be/ep-GFaKjUco?t=02h02m24s)

[like it's it's not necessarily all all](https://youtu.be/ep-GFaKjUco?t=02h02m29s)

[the way worth it so yeah um I think I](https://youtu.be/ep-GFaKjUco?t=02h02m32s)

[think you're the those questions are](https://youtu.be/ep-GFaKjUco?t=02h02m36s)

[probably the right way uh maybe the](https://youtu.be/ep-GFaKjUco?t=02h02m39s)

[solution is test Json export from slack](https://youtu.be/ep-GFaKjUco?t=02h02m41s)

[which has every case I can think of with](https://youtu.be/ep-GFaKjUco?t=02h02m45s)

[image uploads formatting and then I](https://youtu.be/ep-GFaKjUco?t=02h02m47s)

[randomize the order of each entry so](https://youtu.be/ep-GFaKjUco?t=02h02m49s)

[maybe the picture first uh then a](https://youtu.be/ep-GFaKjUco?t=02h02m51s)

[thread yeah then randomize again and](https://youtu.be/ep-GFaKjUco?t=02h02m56s)

[maybe it's a thread thread reply than a](https://youtu.be/ep-GFaKjUco?t=02h02m58s)

[picture yeah and there's depending on](https://youtu.be/ep-GFaKjUco?t=02h03m00s)

[what it is that that almost falls into a](https://youtu.be/ep-GFaKjUco?t=02h03m03s)

[category of like what's called fuzz](https://youtu.be/ep-GFaKjUco?t=02h03m06s)

[testing where it's I'm going I'm going](https://youtu.be/ep-GFaKjUco?t=02h03m08s)

[to randomize things the one thing if you](https://youtu.be/ep-GFaKjUco?t=02h03m11s)

[do randomize um make sure that you set a](https://youtu.be/ep-GFaKjUco?t=02h03m13s)

[seed um or or output the seed or similar](https://youtu.be/ep-GFaKjUco?t=02h03m18s)

[because the random class in C you can](https://youtu.be/ep-GFaKjUco?t=02h03m22s)

[tell it a starting seed which means it](https://youtu.be/ep-GFaKjUco?t=02h03m24s)

[will output deterministic values from a](https://youtu.be/ep-GFaKjUco?t=02h03m27s)

[given seed the default seed is based on](https://youtu.be/ep-GFaKjUco?t=02h03m30s)

[the current](https://youtu.be/ep-GFaKjUco?t=02h03m31s)

[time um but the problem with that is you](https://youtu.be/ep-GFaKjUco?t=02h03m33s)

[can never rerun at that time if there's](https://youtu.be/ep-GFaKjUco?t=02h03m36s)

[a problem and one of the most](https://youtu.be/ep-GFaKjUco?t=02h03m38s)

[frustrating things is like a test failed](https://youtu.be/ep-GFaKjUco?t=02h03m39s)

[and when you rerun it it goes green and](https://youtu.be/ep-GFaKjUco?t=02h03m42s)

[it's like oh that worries me because](https://youtu.be/ep-GFaKjUco?t=02h03m44s)

[that tells me that a particular random](https://youtu.be/ep-GFaKjUco?t=02h03m46s)

[order has a problem but I can't rerun to](https://youtu.be/ep-GFaKjUco?t=02h03m48s)

[see that order to know what it was right](https://youtu.be/ep-GFaKjUco?t=02h03m52s)

[so yeah if you do random like random](https://youtu.be/ep-GFaKjUco?t=02h03m55s)

[isn't bad just make sure that you can](https://youtu.be/ep-GFaKjUco?t=02h03m57s)

[rerun the same set of](https://youtu.be/ep-GFaKjUco?t=02h03m59s)

[random that that's the only advice I](https://youtu.be/ep-GFaKjUco?t=02h04m01s)

[have because I've done that a couple](https://youtu.be/ep-GFaKjUco?t=02h04m03s)

[times where where I will um just like](https://youtu.be/ep-GFaKjUco?t=02h04m04s)

[dump like I will grab like the current](https://youtu.be/ep-GFaKjUco?t=02h04m08s)

[ticks and I will specify the seed in and](https://youtu.be/ep-GFaKjUco?t=02h04m11s)

[I will output that so that if there's](https://youtu.be/ep-GFaKjUco?t=02h04m13s)

[ever a problem I can go and dump that](https://youtu.be/ep-GFaKjUco?t=02h04m16s)

[back in and yeah can't fix the bug if](https://youtu.be/ep-GFaKjUco?t=02h04m18s)

[you can't repo for for 8 million Cycles](https://youtu.be/ep-GFaKjUco?t=02h04m21s)

[exactly recy Arc hello welcome welcome](https://youtu.be/ep-GFaKjUco?t=02h04m24s)

[welcome welcome we are just getting a PR](https://youtu.be/ep-GFaKjUco?t=02h04m27s)

[fixed up and and likely merged here](https://youtu.be/ep-GFaKjUco?t=02h04m30s)

[shortly that drops that that that goes](https://youtu.be/ep-GFaKjUco?t=02h04m33s)

[there that clears all that out but yeah](https://youtu.be/ep-GFaKjUco?t=02h04m36s)

[so that that style of testing is is](https://youtu.be/ep-GFaKjUco?t=02h04m39s)

[wonderful to be able to go through and](https://youtu.be/ep-GFaKjUco?t=02h04m43s)

[do and and it and again it does kind of](https://youtu.be/ep-GFaKjUco?t=02h04m44s)

[capture that type of bugs like I work on](https://youtu.be/ep-GFaKjUco?t=02h04m47s)

[one uh piece of softare in my day job](https://youtu.be/ep-GFaKjUco?t=02h04m49s)

[where the user provides input files and](https://youtu.be/ep-GFaKjUco?t=02h04m52s)

[these](https://youtu.be/ep-GFaKjUco?t=02h04m55s)

[files are across the board some of them](https://youtu.be/ep-GFaKjUco?t=02h04m56s)

[are valid files some of them are invalid](https://youtu.be/ep-GFaKjUco?t=02h04m59s)

[and part of the the what the software](https://youtu.be/ep-GFaKjUco?t=02h05m01s)

[has to do is figure out which is which](https://youtu.be/ep-GFaKjUco?t=02h05m03s)

[which means the input set is the literal](https://youtu.be/ep-GFaKjUco?t=02h05m05s)

[universe and it is frustrating because](https://youtu.be/ep-GFaKjUco?t=02h05m07s)

[you cannot you can't test that because](https://youtu.be/ep-GFaKjUco?t=02h05m10s)

[the the input set is just way too big so](https://youtu.be/ep-GFaKjUco?t=02h05m14s)

[we've got a set of regression tests with](https://youtu.be/ep-GFaKjUco?t=02h05m17s)

[like known problematic files and that](https://youtu.be/ep-GFaKjUco?t=02h05m19s)

[kind of thing so](https://youtu.be/ep-GFaKjUco?t=02h05m21s)

[great right like we can we can verify we](https://youtu.be/ep-GFaKjUco?t=02h05m22s)

[aren't regressing but I can't I can't](https://youtu.be/ep-GFaKjUco?t=02h05m24s)

[test my way to Victory because I the the](https://youtu.be/ep-GFaKjUco?t=02h05m26s)

[input set is just too big and it's](https://youtu.be/ep-GFaKjUco?t=02h05m29s)

[unknown I have no idea what I'm goingon](https://youtu.be/ep-GFaKjUco?t=02h05m31s)

[to random string of ones and zeros](https://youtu.be/ep-GFaKjUco?t=02h05m33s)

[that's what that's what's coming um and](https://youtu.be/ep-GFaKjUco?t=02h05m35s)

[so](https://youtu.be/ep-GFaKjUco?t=02h05m38s)

[it's uh a little more a little more](https://youtu.be/ep-GFaKjUco?t=02h05m39s)

[difficult and so you have to then start](https://youtu.be/ep-GFaKjUco?t=02h05m43s)

[kind of looking for alternate testing](https://youtu.be/ep-GFaKjUco?t=02h05m44s)

[strategies yeah exactly what it's like](https://youtu.be/ep-GFaKjUco?t=02h05m48s)

[importing a slack server with 4,000 Json](https://youtu.be/ep-GFaKjUco?t=02h05m50s)

[files Json is format but the data inside](https://youtu.be/ep-GFaKjUco?t=02h05m53s)

[I what's known can be anything yeah](https://youtu.be/ep-GFaKjUco?t=02h05m56s)

[exactly and so I think the key thing](https://youtu.be/ep-GFaKjUco?t=02h05m58s)

[there](https://youtu.be/ep-GFaKjUco?t=02h05m59s)

[is potentially have a couple cases to](https://youtu.be/ep-GFaKjUco?t=02h06m02s)

[test known situations right like you can](https://youtu.be/ep-GFaKjUco?t=02h06m04s)

[you can generate a handful of different](https://youtu.be/ep-GFaKjUco?t=02h06m08s)

[Json files like you said with you know](https://youtu.be/ep-GFaKjUco?t=02h06m11s)

[thread image Etc right make sure that](https://youtu.be/ep-GFaKjUco?t=02h06m13s)

[those ones work and then say you know](https://youtu.be/ep-GFaKjUco?t=02h06m16s)

[what I'm going to call it a day because](https://youtu.be/ep-GFaKjUco?t=02h06m18s)

[sometimes and this is actually what we](https://youtu.be/ep-GFaKjUco?t=02h06m21s)

[did with that that other project I was](https://youtu.be/ep-GFaKjUco?t=02h06m22s)

[describing we started off we had a](https://youtu.be/ep-GFaKjUco?t=02h06m24s)

[handful of test files we made sure they](https://youtu.be/ep-GFaKjUco?t=02h06m26s)

[all worked and we went this is probably](https://youtu.be/ep-GFaKjUco?t=02h06m29s)

[wrong but we don't know what's wrong yet](https://youtu.be/ep-GFaKjUco?t=02h06m32s)

[until we see more data and then each](https://youtu.be/ep-GFaKjUco?t=02h06m35s)

[time we had a problem we just added](https://youtu.be/ep-GFaKjUco?t=02h06m37s)

[another sample to the to the test set](https://youtu.be/ep-GFaKjUco?t=02h06m39s)

[and so over time it grew as we](https://youtu.be/ep-GFaKjUco?t=02h06m42s)

[encountered more issues but the tests](https://youtu.be/ep-GFaKjUco?t=02h06m46s)

[were there specifically to just prevent](https://youtu.be/ep-GFaKjUco?t=02h06m48s)

[regression](https://youtu.be/ep-GFaKjUco?t=02h06m50s)

[so it's like it doesn't need to be](https://youtu.be/ep-GFaKjUco?t=02h06m52s)

[perfect out the gate but at least if you](https://youtu.be/ep-GFaKjUco?t=02h06m53s)

[start building them up as you see more](https://youtu.be/ep-GFaKjUco?t=02h06m57s)

[things you can you can um you can go oh](https://youtu.be/ep-GFaKjUco?t=02h06m59s)

[shoot well this thing failed let me make](https://youtu.be/ep-GFaKjUco?t=02h07m03s)

[sure I've got a sample that covers you](https://youtu.be/ep-GFaKjUco?t=02h07m04s)

[know whatever that thing is and then and](https://youtu.be/ep-GFaKjUco?t=02h07m06s)

[then at least you know as you move](https://youtu.be/ep-GFaKjUco?t=02h07m10s)

[forward you aren't ever going backwards](https://youtu.be/ep-GFaKjUco?t=02h07m12s)

[right it's like I know I've seen](https://youtu.be/ep-GFaKjUco?t=02h07m14s)

[something that looks like this in the](https://youtu.be/ep-GFaKjUco?t=02h07m15s)

[past so I I want to make sure I still](https://youtu.be/ep-GFaKjUco?t=02h07m16s)

[handle it and then it gives you a little](https://youtu.be/ep-GFaKjUco?t=02h07m18s)

[more freedom to change things up you](https://youtu.be/ep-GFaKjUco?t=02h07m20s)

[still got to be a little careful because](https://youtu.be/ep-GFaKjUco?t=02h07m21s)

[it's like shoot do I remove this if](https://youtu.be/ep-GFaKjUco?t=02h07m23s)

[condition like we haven't seen a case](https://youtu.be/ep-GFaKjUco?t=02h07m25s)

[that does this but maybe it exists](https://youtu.be/ep-GFaKjUco?t=02h07m28s)

[answer is it](https://youtu.be/ep-GFaKjUco?t=02h07m30s)

[might who knows uh let's](https://youtu.be/ep-GFaKjUco?t=02h07m32s)

[see adding PR](https://youtu.be/ep-GFaKjUco?t=02h07m36s)

[feedback uh let's see](https://youtu.be/ep-GFaKjUco?t=02h07m40s)

[moved let's see move the MSI generation](https://youtu.be/ep-GFaKjUco?t=02h07m43s)

[to the windows](https://youtu.be/ep-GFaKjUco?t=02h07m48s)

[pack](https://youtu.be/ep-GFaKjUco?t=02h07m53s)

[um from the base](https://youtu.be/ep-GFaKjUco?t=02h07m55s)

[class uh let's see rename the enum to](https://youtu.be/ep-GFaKjUco?t=02h08m00s)

[better](https://youtu.be/ep-GFaKjUco?t=02h08m06s)

[collect](https://youtu.be/ep-GFaKjUco?t=02h08m07s)

[purpose I think those were the key](https://youtu.be/ep-GFaKjUco?t=02h08m09s)

[changes and so then we push Force push](https://youtu.be/ep-GFaKjUco?t=02h08m12s)

[and we force push because we](https://youtu.be/ep-GFaKjUco?t=02h08m16s)

[rebased and then](https://youtu.be/ep-GFaKjUco?t=02h08m20s)

[and opens on the wrong monitor there we](https://youtu.be/ep-GFaKjUco?t=02h08m23s)

[go okay so](https://youtu.be/ep-GFaKjUco?t=02h08m26s)

[then it's going to resolve some](https://youtu.be/ep-GFaKjUco?t=02h08m29s)

[conversations comment resolve](https://youtu.be/ep-GFaKjUco?t=02h08m32s)

[great uh let's](https://youtu.be/ep-GFaKjUco?t=02h08m36s)

[see](https://youtu.be/ep-GFaKjUco?t=02h08m39s)

[removed](https://youtu.be/ep-GFaKjUco?t=02h08m40s)

[comment](https://youtu.be/ep-GFaKjUco?t=02h08m42s)

[solve uh](https://youtu.be/ep-GFaKjUco?t=02h08m45s)

[moved Drive class](https://youtu.be/ep-GFaKjUco?t=02h08m48s)

[as uh we'll just do](https://youtu.be/ep-GFaKjUco?t=02h08m53s)

[that kayin](https://youtu.be/ep-GFaKjUco?t=02h08m56s)

[smart you will see exactly what happened](https://youtu.be/ep-GFaKjUco?t=02h08m58s)

[boom I just feel awkward hitting resolve](https://youtu.be/ep-GFaKjUco?t=02h09m02s)

[without doing this uh](https://youtu.be/ep-GFaKjUco?t=02h09m03s)

[done did remove the property off the](https://youtu.be/ep-GFaKjUco?t=02h09m07s)

[interface uh](https://youtu.be/ep-GFaKjUco?t=02h09m11s)

[done resolve conversation](https://youtu.be/ep-GFaKjUco?t=02h09m15s)

[okay uh shouldn't be here remove](https://youtu.be/ep-GFaKjUco?t=02h09m19s)

[property](https://youtu.be/ep-GFaKjUco?t=02h09m22s)

[removed then resolve conversation and](https://youtu.be/ep-GFaKjUco?t=02h09m25s)

[then I just want to jump over and look](https://youtu.be/ep-GFaKjUco?t=02h09m27s)

[at the](https://youtu.be/ep-GFaKjUco?t=02h09m29s)

[combined diff](https://youtu.be/ep-GFaKjUco?t=02h09m31s)

[here make sure there's](https://youtu.be/ep-GFaKjUco?t=02h09m33s)

[nothing weird so these are properties](https://youtu.be/ep-GFaKjUco?t=02h09m35s)

[these ones have to be here for mapping](https://youtu.be/ep-GFaKjUco?t=02h09m39s)

[but these ones the the vpac build](https://youtu.be/ep-GFaKjUco?t=02h09m41s)

[project may end up being moved and](https://youtu.be/ep-GFaKjUco?t=02h09m45s)

[changed up a little bit we've run into a](https://youtu.be/ep-GFaKjUco?t=02h09m48s)

[couple tiny snags with it that like it's](https://youtu.be/ep-GFaKjUco?t=02h09m51s)

[it's totally doable to make it work but](https://youtu.be/ep-GFaKjUco?t=02h09m54s)

[it is increasingly becoming a pain in](https://youtu.be/ep-GFaKjUco?t=02h09m57s)

[the neck because it](https://youtu.be/ep-GFaKjUco?t=02h09m59s)

[is](https://youtu.be/ep-GFaKjUco?t=02h10m01s)

[duplicating um the same stuff that](https://youtu.be/ep-GFaKjUco?t=02h10m03s)

[already exists in the](https://youtu.be/ep-GFaKjUco?t=02h10m06s)

[CLI so we are we're talking about maybe](https://youtu.be/ep-GFaKjUco?t=02h10m08s)

[wrapping or](https://youtu.be/ep-GFaKjUco?t=02h10m12s)

[similar here that is just the name space](https://youtu.be/ep-GFaKjUco?t=02h10m13s)

[change some of these changes weren't the](https://youtu.be/ep-GFaKjUco?t=02h10m17s)

[ones made tonight this one here bit me](https://youtu.be/ep-GFaKjUco?t=02h10m19s)

[on some testing so I fixed it because it](https://youtu.be/ep-GFaKjUco?t=02h10m22s)

[bothered](https://youtu.be/ep-GFaKjUco?t=02h10m26s)

[me that one was just using the named](https://youtu.be/ep-GFaKjUco?t=02h10m27s)

[value](https://youtu.be/ep-GFaKjUco?t=02h10m30s)

[with](https://youtu.be/ep-GFaKjUco?t=02h10m31s)

[um uh the deconstruction rather](https://youtu.be/ep-GFaKjUco?t=02h10m34s)

[than](https://youtu.be/ep-GFaKjUco?t=02h10m37s)

[otherwise is this was creating a value](https://youtu.be/ep-GFaKjUco?t=02h10m39s)

[Tuple just for this the standard out](https://youtu.be/ep-GFaKjUco?t=02h10m42s)

[just to call it back by there and I'm](https://youtu.be/ep-GFaKjUco?t=02h10m46s)

[like nah let's just pass standard out](https://youtu.be/ep-GFaKjUco?t=02h10m48s)

[all the way through that's what is](https://youtu.be/ep-GFaKjUco?t=02h10m50s)

[intended and that reads a little cleaner](https://youtu.be/ep-GFaKjUco?t=02h10m52s)

[so Wix platform stuff for being able to](https://youtu.be/ep-GFaKjUco?t=02h10m54s)

[reach into the template the candle and](https://youtu.be/ep-GFaKjUco?t=02h10m57s)

[the](https://youtu.be/ep-GFaKjUco?t=02h10m59s)

[light better air](https://youtu.be/ep-GFaKjUco?t=02h11m00s)

[messaging because before it just said](https://youtu.be/ep-GFaKjUco?t=02h11m03s)

[couldn't find file I had it include](https://youtu.be/ep-GFaKjUco?t=02h11m05s)

[where it searched because I had trouble](https://youtu.be/ep-GFaKjUco?t=02h11m07s)

[reading my own air message and went you](https://youtu.be/ep-GFaKjUco?t=02h11m11s)

[know what I would really like to be able](https://youtu.be/ep-GFaKjUco?t=02h11m12s)

[to see](https://youtu.be/ep-GFaKjUco?t=02h11m14s)

[more okay so this is what we were just](https://youtu.be/ep-GFaKjUco?t=02h11m15s)

[changing passes that in these are prior](https://youtu.be/ep-GFaKjUco?t=02h11m18s)

[changes because the MSI needs the title](https://youtu.be/ep-GFaKjUco?t=02h11m22s)

[and the authors as](https://youtu.be/ep-GFaKjUco?t=02h11m25s)

[well uh let's see pack title this one](https://youtu.be/ep-GFaKjUco?t=02h11m27s)

[was kind of](https://youtu.be/ep-GFaKjUco?t=02h11m30s)

[dumb because this was falling back to](https://youtu.be/ep-GFaKjUco?t=02h11m32s)

[pack ID but pack ID was already](https://youtu.be/ep-GFaKjUco?t=02h11m34s)

[something that was being no coest on it](https://youtu.be/ep-GFaKjUco?t=02h11m36s)

[so it was like uh let's just not do](https://youtu.be/ep-GFaKjUco?t=02h11m39s)

[that okay there](https://youtu.be/ep-GFaKjUco?t=02h11m43s)

[there collection initializers because I](https://youtu.be/ep-GFaKjUco?t=02h11m46s)

[can't resist there's the shared methods](https://youtu.be/ep-GFaKjUco?t=02h11m49s)

[that can be used in both](https://youtu.be/ep-GFaKjUco?t=02h11m51s)

[places let's see this is the windows](https://youtu.be/ep-GFaKjUco?t=02h11m53s)

[pack command so this is actually the VPK](https://youtu.be/ep-GFaKjUco?t=02h11m55s)

[CLI uh worth noting this MSI deployment](https://youtu.be/ep-GFaKjUco?t=02h11m58s)

[tool is not something that because it's](https://youtu.be/ep-GFaKjUco?t=02h12m02s)

[kind of a hack in the way that it's even](https://youtu.be/ep-GFaKjUco?t=02h12m04s)

[working](https://youtu.be/ep-GFaKjUco?t=02h12m07s)

[um oh that's a](https://youtu.be/ep-GFaKjUco?t=02h12m10s)

[bug is this](https://youtu.be/ep-GFaKjUco?t=02h12m16s)

[thing that that that is wrong Windows](https://youtu.be/ep-GFaKjUco?t=02h12m20s)

[pack command we'll fix that um it's](https://youtu.be/ep-GFaKjUco?t=02h12m22s)

[setting an argument](https://youtu.be/ep-GFaKjUco?t=02h12m25s)

[name and it's kind of a dumb thing](https://youtu.be/ep-GFaKjUco?t=02h12m28s)

[because the argument name isn't](https://youtu.be/ep-GFaKjUco?t=02h12m31s)

[something that's going to need to](https://youtu.be/ep-GFaKjUco?t=02h12m33s)

[exist this is validation](https://youtu.be/ep-GFaKjUco?t=02h12m42s)

[on validate must be valid MSI version](https://youtu.be/ep-GFaKjUco?t=02h12m46s)

[great right so this ensures correct](https://youtu.be/ep-GFaKjUco?t=02h12m49s)

[things are passed in uh argument help](https://youtu.be/ep-GFaKjUco?t=02h12m52s)

[name version yeah this is a just a a](https://youtu.be/ep-GFaKjUco?t=02h12m56s)

[switch like you can technically](https://youtu.be/ep-GFaKjUco?t=02h13m02s)

[pass false or True to this but that's an](https://youtu.be/ep-GFaKjUco?t=02h13m04s)

[unusual way to use a](https://youtu.be/ep-GFaKjUco?t=02h13m07s)

[CLI um we are going to pretend like](https://youtu.be/ep-GFaKjUco?t=02h13m09s)

[nothing happened amend and force push](https://youtu.be/ep-GFaKjUco?t=02h13m12s)

[nothing to see here there was no](https://youtu.be/ep-GFaKjUco?t=02h13m17s)

[mistakes it's it's fine it's totally](https://youtu.be/ep-GFaKjUco?t=02h13m19s)

[fine](https://youtu.be/ep-GFaKjUco?t=02h13m23s)

[okay then we're going to refresh this](https://youtu.be/ep-GFaKjUco?t=02h13m26s)

[sucker and then going to continue going](https://youtu.be/ep-GFaKjUco?t=02h13m29s)

[down this path okay cool I missed that](https://youtu.be/ep-GFaKjUco?t=02h13m33s)

[before um this one](https://youtu.be/ep-GFaKjUco?t=02h13m37s)

[here is just referencing the dll inside](https://youtu.be/ep-GFaKjUco?t=02h13m41s)

[the test project so that the test](https://youtu.be/ep-GFaKjUco?t=02h13m45s)

[project can pull apart the MSI to](https://youtu.be/ep-GFaKjUco?t=02h13m47s)

[actually read the information out of it](https://youtu.be/ep-GFaKjUco?t=02h13m49s)

[collection](https://youtu.be/ep-GFaKjUco?t=02h13m52s)

[initializers collapse the using](https://youtu.be/ep-GFaKjUco?t=02h13m54s)

[statements minor cleanup more more](https://youtu.be/ep-GFaKjUco?t=02h13m58s)

[collection Expressions because I love](https://youtu.be/ep-GFaKjUco?t=02h14m01s)

[them very](https://youtu.be/ep-GFaKjUco?t=02h14m03s)

[dearly and then these are the new tests](https://youtu.be/ep-GFaKjUco?t=02h14m06s)

[that we just saw run and pass those are](https://youtu.be/ep-GFaKjUco?t=02h14m08s)

[fine made some methods static made some](https://youtu.be/ep-GFaKjUco?t=02h14m11s)

[stuff read only this is another thing](https://youtu.be/ep-GFaKjUco?t=02h14m14s)

[that's probably worth knowing about acid](https://youtu.be/ep-GFaKjUco?t=02h14m17s)

[rain if you're on a newer. net there is](https://youtu.be/ep-GFaKjUco?t=02h14m18s)

[a](https://youtu.be/ep-GFaKjUco?t=02h14m20s)

[uh random. shared because quite often](https://youtu.be/ep-GFaKjUco?t=02h14m21s)

[you want to declare a single random](https://youtu.be/ep-GFaKjUco?t=02h14m25s)

[instance rather than multiple](https://youtu.be/ep-GFaKjUco?t=02h14m27s)

[instances because uh with Modern](https://youtu.be/ep-GFaKjUco?t=02h14m29s)

[Hardware if you declare two random](https://youtu.be/ep-GFaKjUco?t=02h14m33s)

[instances in close enough succession](https://youtu.be/ep-GFaKjUco?t=02h14m35s)

[because they're using the current date](https://youtu.be/ep-GFaKjUco?t=02h14m38s)

[time value often times the clock in a](https://youtu.be/ep-GFaKjUco?t=02h14m39s)

[system like it's pretty accurate but](https://youtu.be/ep-GFaKjUco?t=02h14m42s)

[there's a window of opportunity there](https://youtu.be/ep-GFaKjUco?t=02h14m45s)

[where both instances could get the same](https://youtu.be/ep-GFaKjUco?t=02h14m47s)

[starting seed and and so it's uh kind of](https://youtu.be/ep-GFaKjUco?t=02h14m49s)

[a fun bug when people do new random](https://youtu.be/ep-GFaKjUco?t=02h14m52s)

[inside of a loop or something and then](https://youtu.be/ep-GFaKjUco?t=02h14m55s)

[they're like I got the same random value](https://youtu.be/ep-GFaKjUco?t=02h14m56s)

[every time it's like well you're just](https://youtu.be/ep-GFaKjUco?t=02h14m58s)

[running on fast enough Hardware that](https://youtu.be/ep-GFaKjUco?t=02h15m01s)

[your seed is always the same every time](https://youtu.be/ep-GFaKjUco?t=02h15m03s)

[okay these are just uh vendor assets](https://youtu.be/ep-GFaKjUco?t=02h15m06s)

[that are being shoved](https://youtu.be/ep-GFaKjUco?t=02h15m10s)

[in build build build build build build](https://youtu.be/ep-GFaKjUco?t=02h15m14s)

[oh I just realized I didn't check to](https://youtu.be/ep-GFaKjUco?t=02h15m17s)

[validate that these were added into the](https://youtu.be/ep-GFaKjUco?t=02h15m19s)

[new get package when it's](https://youtu.be/ep-GFaKjUco?t=02h15m21s)

[built go Val let's go validate that real](https://youtu.be/ep-GFaKjUco?t=02h15m26s)

[quick so if I do](https://youtu.be/ep-GFaKjUco?t=02h15m28s)

[this so because I've overridden the get](https://youtu.be/ep-GFaKjUco?t=02h15m30s)

[Kraken command for uh open in vs code to](https://youtu.be/ep-GFaKjUco?t=02h15m35s)

[be open in Visual Studio I've lost open](https://youtu.be/ep-GFaKjUco?t=02h15m39s)

[in vs code so my my hack is to just type](https://youtu.be/ep-GFaKjUco?t=02h15m42s)

[code space period and now I've got open](https://youtu.be/ep-GFaKjUco?t=02h15m45s)

[in vs code](https://youtu.be/ep-GFaKjUco?t=02h15m48s)

[okay my back over here for a second so I](https://youtu.be/ep-GFaKjUco?t=02h15m51s)

[want to go find](https://youtu.be/ep-GFaKjUco?t=02h15m53s)

[the](https://youtu.be/ep-GFaKjUco?t=02h15m56s)

[uh when we build the](https://youtu.be/ep-GFaKjUco?t=02h15m58s)

[nougat how are](https://youtu.be/ep-GFaKjUco?t=02h16m01s)

[we I can probably just hunt vendor how](https://youtu.be/ep-GFaKjUco?t=02h16m04s)

[do we get the vendor stuff](https://youtu.be/ep-GFaKjUco?t=02h16m07s)

[inside build](https://youtu.be/ep-GFaKjUco?t=02h16m10s)

[targets okay uh add Nate vendor Libs](https://youtu.be/ep-GFaKjUco?t=02h16m17s)

[okay so it's going to just slurp up](https://youtu.be/ep-GFaKjUco?t=02h16m22s)

[everything inside a vendor so vendor SL](https://youtu.be/ep-GFaKjUco?t=02h16m24s)

[starstar it'll slurp everything up add](https://youtu.be/ep-GFaKjUco?t=02h16m27s)

[it into the package it'll be underneath](https://youtu.be/ep-GFaKjUco?t=02h16m30s)

[the vendor directory Bippity bity booya](https://youtu.be/ep-GFaKjUco?t=02h16m32s)

[okay cool I wasn't sure how that](https://youtu.be/ep-GFaKjUco?t=02h16m35s)

[worked](https://youtu.be/ep-GFaKjUco?t=02h16m40s)

[sweet that actually makes it really](https://youtu.be/ep-GFaKjUco?t=02h16m42s)

[nice uh there's the updates setup exe](https://youtu.be/ep-GFaKjUco?t=02h16m45s)

[because it's just grabbing these from a](https://youtu.be/ep-GFaKjUco?t=02h16m49s)

[different direction Dory but if it's in](https://youtu.be/ep-GFaKjUco?t=02h16m50s)

[underneath the vendor directory](https://youtu.be/ep-GFaKjUco?t=02h16m52s)

[which is](https://youtu.be/ep-GFaKjUco?t=02h16m54s)

[where stuff isn't in the way inside of](https://youtu.be/ep-GFaKjUco?t=02h16m58s)

[here this is where we've got like the](https://youtu.be/ep-GFaKjUco?t=02h17m01s)

[light EXE the candle exe their configs](https://youtu.be/ep-GFaKjUco?t=02h17m02s)

[relevant dlls for it and then the](https://youtu.be/ep-GFaKjUco?t=02h17m06s)

[template so and this Wix template is](https://youtu.be/ep-GFaKjUco?t=02h17m08s)

[basically copy paste from what it was in](https://youtu.be/ep-GFaKjUco?t=02h17m11s)

[Cloud](https://youtu.be/ep-GFaKjUco?t=02h17m14s)

[squirrel I think I had to change a](https://youtu.be/ep-GFaKjUco?t=02h17m16s)

[handful of curly braces I think](https://youtu.be/ep-GFaKjUco?t=02h17m18s)

[because the cloud scr brought in an](https://youtu.be/ep-GFaKjUco?t=02h17m21s)

[entire library for doing effectively a](https://youtu.be/ep-GFaKjUco?t=02h17m24s)

[string replace like we don't need a](https://youtu.be/ep-GFaKjUco?t=02h17m26s)

[templating library for what is a string](https://youtu.be/ep-GFaKjUco?t=02h17m28s)

[replace you need a templating library](https://youtu.be/ep-GFaKjUco?t=02h17m30s)

[when you're running templates and this](https://youtu.be/ep-GFaKjUco?t=02h17m32s)

[is re exible so I reex it okay cool so](https://youtu.be/ep-GFaKjUco?t=02h17m35s)

[that makes me feel better that makes me](https://youtu.be/ep-GFaKjUco?t=02h17m39s)

[feel better](https://youtu.be/ep-GFaKjUco?t=02h17m42s)

[and going to click that button request](https://youtu.be/ep-GFaKjUco?t=02h17m44s)

[re-review](https://youtu.be/ep-GFaKjUco?t=02h17m47s)

[there okay and I](https://youtu.be/ep-GFaKjUco?t=02h17m49s)

[think that oh it's showing something](https://youtu.be/ep-GFaKjUco?t=02h17m54s)

[failed failed the test failed on](https://youtu.be/ep-GFaKjUco?t=02h17m58s)

[Ubuntu which one](https://youtu.be/ep-GFaKjUco?t=02h18m02s)

[failed uh let's see](https://youtu.be/ep-GFaKjUco?t=02h18m11s)

[expected check some](https://youtu.be/ep-GFaKjUco?t=02h18m14s)

[failed uh let's see](https://youtu.be/ep-GFaKjUco?t=02h18m18s)

[update manager check checkum should use](https://youtu.be/ep-GFaKjUco?t=02h18m21s)

[sha](https://youtu.be/ep-GFaKjUco?t=02h18m24s)

[256 this looks like something that](https://youtu.be/ep-GFaKjUco?t=02h18m30s)

[is a timing issue if I was guessing](https://youtu.be/ep-GFaKjUco?t=02h18m38s)

[because this does not look relevant to](https://youtu.be/ep-GFaKjUco?t=02h18m42s)

[what I](https://youtu.be/ep-GFaKjUco?t=02h18m44s)

[did and since these tests previously](https://youtu.be/ep-GFaKjUco?t=02h18m46s)

[passed I'm going to assume this is is](https://youtu.be/ep-GFaKjUco?t=02h18m49s)

[not overly relevant to me okay let's](https://youtu.be/ep-GFaKjUco?t=02h18m51s)

[check over](https://youtu.be/ep-GFaKjUco?t=02h18m54s)

[here uh let's see](https://youtu.be/ep-GFaKjUco?t=02h18m56s)

[here Uno](https://youtu.be/ep-GFaKjUco?t=02h18m59s)

[SDK that one's still](https://youtu.be/ep-GFaKjUco?t=02h19m03s)

[running that one's going to rev a](https://youtu.be/ep-GFaKjUco?t=02h19m06s)

[bunch um some of these I'm tempted to](https://youtu.be/ep-GFaKjUco?t=02h19m09s)

[just](https://youtu.be/ep-GFaKjUco?t=02h19m12s)

[merge because like this AWS SDK should](https://youtu.be/ep-GFaKjUco?t=02h19m16s)

[be fine](https://youtu.be/ep-GFaKjUco?t=02h19m20s)

[now but I may wait kin's been tweaking](https://youtu.be/ep-GFaKjUco?t=02h19m22s)

[our renovate config and I don't want](https://youtu.be/ep-GFaKjUco?t=02h19m27s)

[to I don't want to get in the way of](https://youtu.be/ep-GFaKjUco?t=02h19m29s)

[something that is](https://youtu.be/ep-GFaKjUco?t=02h19m32s)

[working this guy is still](https://youtu.be/ep-GFaKjUco?t=02h19m34s)

[running this branch has no conflicts](https://youtu.be/ep-GFaKjUco?t=02h19m38s)

[with the base Branch I know it doesn't I](https://youtu.be/ep-GFaKjUco?t=02h19m41s)

[rebased yeah our our build pipeline is](https://youtu.be/ep-GFaKjUco?t=02h19m45s)

[kind of](https://youtu.be/ep-GFaKjUco?t=02h19m48s)

[ridiculous like it](https://youtu.be/ep-GFaKjUco?t=02h19m49s)

[is um it it's it's kind of](https://youtu.be/ep-GFaKjUco?t=02h19m53s)

[insane there's just a](https://youtu.be/ep-GFaKjUco?t=02h20m01s)

[couple couple jobs in](https://youtu.be/ep-GFaKjUco?t=02h20m03s)

[there I wonder why we build all of our](https://youtu.be/ep-GFaKjUco?t=02h20m07s)

[samples](https://youtu.be/ep-GFaKjUco?t=02h20m10s)

[on I guess we're valid ating that the](https://youtu.be/ep-GFaKjUco?t=02h20m18s)

[pat command works on all of them that's](https://youtu.be/ep-GFaKjUco?t=02h20m21s)

[probably worth it that's probably worth](https://youtu.be/ep-GFaKjUco?t=02h20m23s)

[it this is the this this is the other](https://youtu.be/ep-GFaKjUco?t=02h20m26s)

[drawback with something like building an](https://youtu.be/ep-GFaKjUco?t=02h20m27s)

[installer technology like this the](https://youtu.be/ep-GFaKjUco?t=02h20m29s)

[things that people might try to install](https://youtu.be/ep-GFaKjUco?t=02h20m31s)

[is also once again the](https://youtu.be/ep-GFaKjUco?t=02h20m33s)

[Universe um like they're going to have](https://youtu.be/ep-GFaKjUco?t=02h20m35s)

[an](https://youtu.be/ep-GFaKjUco?t=02h20m38s)

[application or something that runs that](https://youtu.be/ep-GFaKjUco?t=02h20m39s)

[they want to install and our job is to](https://youtu.be/ep-GFaKjUco?t=02h20m42s)

[get it into the the end State okay cool](https://youtu.be/ep-GFaKjUco?t=02h20m45s)

[cool cool cool cool cool okay so that](https://youtu.be/ep-GFaKjUco?t=02h20m49s)

[gets me there that gets me there that](https://youtu.be/ep-GFaKjUco?t=02h20m51s)

[gets me](https://youtu.be/ep-GFaKjUco?t=02h20m52s)

[there I think](https://youtu.be/ep-GFaKjUco?t=02h20m56s)

[that's I think that's](https://youtu.be/ep-GFaKjUco?t=02h20m58s)

[good that's](https://youtu.be/ep-GFaKjUco?t=02h21m03s)

[good given that my Mountain Dew is empty](https://youtu.be/ep-GFaKjUco?t=02h21m06s)

[I might end up calling it right there](https://youtu.be/ep-GFaKjUco?t=02h21m09s)

[for tonight](https://youtu.be/ep-GFaKjUco?t=02h21m12s)

[I did not sleep well last night so it](https://youtu.be/ep-GFaKjUco?t=02h21m13s)

[would probably be good to do so I'm](https://youtu.be/ep-GFaKjUco?t=02h21m16s)

[going to potentially just watch this and](https://youtu.be/ep-GFaKjUco?t=02h21m18s)

[then re kick this failure once it's all](https://youtu.be/ep-GFaKjUco?t=02h21m20s)

[the way](https://youtu.be/ep-GFaKjUco?t=02h21m22s)

[done um because I want to see these test](https://youtu.be/ep-GFaKjUco?t=02h21m23s)

[ones rerun I want to know if it's an a](https://youtu.be/ep-GFaKjUco?t=02h21m28s)

[legit failure or not this feels like](https://youtu.be/ep-GFaKjUco?t=02h21m31s)

[something that's not a legit](https://youtu.be/ep-GFaKjUco?t=02h21m34s)

[failure yeah so we'll rerun we'll retest](https://youtu.be/ep-GFaKjUco?t=02h21m39s)

[we'll see how it](https://youtu.be/ep-GFaKjUco?t=02h21m44s)

[goes so cool well thank you everyone for](https://youtu.be/ep-GFaKjUco?t=02h21m45s)

[coming in hanging out uh um I am](https://youtu.be/ep-GFaKjUco?t=02h21m49s)

[probably going to be running headlong](https://youtu.be/ep-GFaKjUco?t=02h21m52s)

[into a bunch of velop pack development](https://youtu.be/ep-GFaKjUco?t=02h21m53s)

[stuff so expect to see more of that](https://youtu.be/ep-GFaKjUco?t=02h21m55s)

[streaming or more commit stuff I got to](https://youtu.be/ep-GFaKjUco?t=02h21m58s)

[balance a little bit because some of it](https://youtu.be/ep-GFaKjUco?t=02h22m01s)

[is closed Source but even the closed](https://youtu.be/ep-GFaKjUco?t=02h22m03s)

[Source repos I can kind of show on](https://youtu.be/ep-GFaKjUco?t=02h22m05s)

[stream as well um mostly because I'm one](https://youtu.be/ep-GFaKjUco?t=02h22m07s)

[of the founders and my partner said yeah](https://youtu.be/ep-GFaKjUco?t=02h22m11s)

[sure go for it so that's pretty much it](https://youtu.be/ep-GFaKjUco?t=02h22m13s)

[so we will potentially dive into that](https://youtu.be/ep-GFaKjUco?t=02h22m17s)

[and yeah acid Rin always good to have](https://youtu.be/ep-GFaKjUco?t=02h22m20s)

[you around man so feel free to hit me up](https://youtu.be/ep-GFaKjUco?t=02h22m22s)

[with more stuff if people got questions](https://youtu.be/ep-GFaKjUco?t=02h22m25s)

[but kind of hoping to start testing out](https://youtu.be/ep-GFaKjUco?t=02h22m27s)

[some of the velop pack stuff that we've](https://youtu.be/ep-GFaKjUco?t=02h22m31s)

[been building and like plug installers](https://youtu.be/ep-GFaKjUco?t=02h22m33s)

[in for the material design demo app I](https://youtu.be/ep-GFaKjUco?t=02h22m35s)

[want to get the avalonia sample stuff](https://youtu.be/ep-GFaKjUco?t=02h22m38s)

[rocking and rolling and get more docks](https://youtu.be/ep-GFaKjUco?t=02h22m40s)

[and that kind of stuff out so expect](https://youtu.be/ep-GFaKjUco?t=02h22m42s)

[more of that coming](https://youtu.be/ep-GFaKjUco?t=02h22m44s)

[song uh with that I'll tell everybody](https://youtu.be/ep-GFaKjUco?t=02h22m45s)

[happy coding see yall next time](https://youtu.be/ep-GFaKjUco?t=02h22m48s)

