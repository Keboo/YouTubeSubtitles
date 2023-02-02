[YouTube Video](https://youtu.be/tRxsBGWxowA)



[hello everyone welcome back tonight I](https://youtu.be/tRxsBGWxowA?t=00h00m01s)

[think I'm going to go back to the](https://youtu.be/tRxsBGWxowA?t=00h00m04s)

[material design and xaml project do some](https://youtu.be/tRxsBGWxowA?t=00h00m05s)

[work on the brush theming stuff](https://youtu.be/tRxsBGWxowA?t=00h00m07s)

[um I'm still planning on doing a 4 8](https://youtu.be/tRxsBGWxowA?t=00h00m10s)

[release uh at some point but](https://youtu.be/tRxsBGWxowA?t=00h00m12s)

[it's been a long day](https://youtu.be/tRxsBGWxowA?t=00h00m15s)

[I don't really want to fix bugs I'm](https://youtu.be/tRxsBGWxowA?t=00h00m16s)

[gonna have fun building out some new](https://youtu.be/tRxsBGWxowA?t=00h00m18s)

[stuff I think or at least figuring out](https://youtu.be/tRxsBGWxowA?t=00h00m20s)

[what the new stuff needs to be so high](https://youtu.be/tRxsBGWxowA?t=00h00m22s)

[level what's going on](https://youtu.be/tRxsBGWxowA?t=00h00m24s)

[um previous versions of the material](https://youtu.be/tRxsBGWxowA?t=00h00m26s)

[design and xaml project there were some](https://youtu.be/tRxsBGWxowA?t=00h00m28s)

[brushes they had things like material](https://youtu.be/tRxsBGWxowA?t=00h00m30s)

[design uh paper and that kind of thing](https://youtu.be/tRxsBGWxowA?t=00h00m31s)

[which doesn't lend itself well to](https://youtu.be/tRxsBGWxowA?t=00h00m34s)

[extensibility it also means that there's](https://youtu.be/tRxsBGWxowA?t=00h00m36s)

[a very small number of brushes and so](https://youtu.be/tRxsBGWxowA?t=00h00m38s)

[oftentimes if somebody wants to change](https://youtu.be/tRxsBGWxowA?t=00h00m41s)

[just one particular color there's not an](https://youtu.be/tRxsBGWxowA?t=00h00m42s)

[easy way to say hey just go change this](https://youtu.be/tRxsBGWxowA?t=00h00m44s)

[and it'll only affect all your text](https://youtu.be/tRxsBGWxowA?t=00h00m46s)

[boxes because oftentimes things get um](https://youtu.be/tRxsBGWxowA?t=00h00m48s)

[uh spam or uh reused and multiply](https://youtu.be/tRxsBGWxowA?t=00h00m52s)

[multiple places](https://youtu.be/tRxsBGWxowA?t=00h00m55s)

[all right one moment please](https://youtu.be/tRxsBGWxowA?t=00h00m57s)

[and](https://youtu.be/tRxsBGWxowA?t=00h01m04s)

[there we go](https://youtu.be/tRxsBGWxowA?t=00h01m06s)

[um](https://youtu.be/tRxsBGWxowA?t=00h01m08s)

[so looking to expand out the number of](https://youtu.be/tRxsBGWxowA?t=00h01m10s)

[brushes the problem with expanding the](https://youtu.be/tRxsBGWxowA?t=00h01m12s)

[number of brushes is there's obviously](https://youtu.be/tRxsBGWxowA?t=00h01m14s)

[quite a bit of uh work that goes into](https://youtu.be/tRxsBGWxowA?t=00h01m15s)

[one just applying the new brushes across](https://youtu.be/tRxsBGWxowA?t=00h01m18s)

[all of the various Styles and templates](https://youtu.be/tRxsBGWxowA?t=00h01m21s)

[that there are there's also some](https://youtu.be/tRxsBGWxowA?t=00h01m23s)

[migration issues so how do we get people](https://youtu.be/tRxsBGWxowA?t=00h01m25s)

[to move from brush a to brush B and](https://youtu.be/tRxsBGWxowA?t=00h01m28s)

[going forward and initially I thought I](https://youtu.be/tRxsBGWxowA?t=00h01m30s)

[was going to be able to push it forward](https://youtu.be/tRxsBGWxowA?t=00h01m32s)

[and not break people and then realized](https://youtu.be/tRxsBGWxowA?t=00h01m33s)

[yeah that's not really going to be](https://youtu.be/tRxsBGWxowA?t=00h01m36s)

[possible there's going to be breaking](https://youtu.be/tRxsBGWxowA?t=00h01m37s)

[changes](https://youtu.be/tRxsBGWxowA?t=00h01m39s)

[um and I apologize so the easiest thing](https://youtu.be/tRxsBGWxowA?t=00h01m41s)

[I can do is hopefully put forward some](https://youtu.be/tRxsBGWxowA?t=00h01m43s)

[easy find and replace patterns for](https://youtu.be/tRxsBGWxowA?t=00h01m46s)

[people to be able to apply to their](https://youtu.be/tRxsBGWxowA?t=00h01m48s)

[repositories say hey](https://youtu.be/tRxsBGWxowA?t=00h01m49s)

[brush a you want to replace with brush B](https://youtu.be/tRxsBGWxowA?t=00h01m51s)

[and there'll probably be a few of those](https://youtu.be/tRxsBGWxowA?t=00h01m54s)

[where there's a conditional saying yeah](https://youtu.be/tRxsBGWxowA?t=00h01m56s)

[if you're using the material design](https://youtu.be/tRxsBGWxowA?t=00h01m57s)

[divider](https://youtu.be/tRxsBGWxowA?t=00h01m58s)

[um in a uh like a toolbar this is the](https://youtu.be/tRxsBGWxowA?t=00h02m00s)

[new brush but if you're using it in say](https://youtu.be/tRxsBGWxowA?t=00h02m03s)

[um I don't know a grid splitter this](https://youtu.be/tRxsBGWxowA?t=00h02m06s)

[might be the other brush so there's](https://youtu.be/tRxsBGWxowA?t=00h02m07s)

[going to be a couple of those things](https://youtu.be/tRxsBGWxowA?t=00h02m08s)

[where the existing brushes are going to](https://youtu.be/tRxsBGWxowA?t=00h02m09s)

[get forked into multiple several brushes](https://youtu.be/tRxsBGWxowA?t=00h02m11s)

[the other thing with a lot of these](https://youtu.be/tRxsBGWxowA?t=00h02m13s)

[brush Keys is at the end of the day we](https://youtu.be/tRxsBGWxowA?t=00h02m15s)

[don't really want](https://youtu.be/tRxsBGWxowA?t=00h02m18s)

[a lot of individual colors because](https://youtu.be/tRxsBGWxowA?t=00h02m20s)

[really when you're doing a theme](https://youtu.be/tRxsBGWxowA?t=00h02m22s)

[for the easy use case you really only](https://youtu.be/tRxsBGWxowA?t=00h02m24s)

[want to set a handful of colors and have](https://youtu.be/tRxsBGWxowA?t=00h02m27s)

[them apply everywhere right there's kind](https://youtu.be/tRxsBGWxowA?t=00h02m28s)

[of a different approaches to this](https://youtu.be/tRxsBGWxowA?t=00h02m30s)

[depending on how you're using the](https://youtu.be/tRxsBGWxowA?t=00h02m32s)

[library some people just want to drop it](https://youtu.be/tRxsBGWxowA?t=00h02m34s)

[in and say I don't want to think too](https://youtu.be/tRxsBGWxowA?t=00h02m36s)

[hard let me set a primary and secondary](https://youtu.be/tRxsBGWxowA?t=00h02m37s)

[color and then just get out of my way](https://youtu.be/tRxsBGWxowA?t=00h02m39s)

[right do the theming have it work great](https://youtu.be/tRxsBGWxowA?t=00h02m41s)

[some people are using it in Enterprise](https://youtu.be/tRxsBGWxowA?t=00h02m44s)

[applications where they're like no we've](https://youtu.be/tRxsBGWxowA?t=00h02m46s)

[got a designer we've got our own color](https://youtu.be/tRxsBGWxowA?t=00h02m49s)

[palette please don't mess with this we](https://youtu.be/tRxsBGWxowA?t=00h02m50s)

[want to set everything individually it's](https://youtu.be/tRxsBGWxowA?t=00h02m53s)

[like okay and so trying to walk that](https://youtu.be/tRxsBGWxowA?t=00h02m54s)

[fence and making sure that it's useful](https://youtu.be/tRxsBGWxowA?t=00h02m56s)

[for both so I've got some ideas on how I](https://youtu.be/tRxsBGWxowA?t=00h02m58s)

[think I want to accomplish this I had a](https://youtu.be/tRxsBGWxowA?t=00h03m01s)

[new theming brush Branch I may abandon](https://youtu.be/tRxsBGWxowA?t=00h03m03s)

[it I may rebase it it's hard to say](https://youtu.be/tRxsBGWxowA?t=00h03m06s)

[there's](https://youtu.be/tRxsBGWxowA?t=00h03m08s)

[it's it's a work in progress this I](https://youtu.be/tRxsBGWxowA?t=00h03m10s)

[think there's probably going to be bits](https://youtu.be/tRxsBGWxowA?t=00h03m13s)

[and pieces I pull out of it and bring it](https://youtu.be/tRxsBGWxowA?t=00h03m14s)

[forward but I don't know if I'm going to](https://youtu.be/tRxsBGWxowA?t=00h03m16s)

[completely keep it wholesale](https://youtu.be/tRxsBGWxowA?t=00h03m17s)

[but let's look at code let's look at](https://youtu.be/tRxsBGWxowA?t=00h03m20s)

[code](https://youtu.be/tRxsBGWxowA?t=00h03m22s)

[okay so uh I am playing with my my](https://youtu.be/tRxsBGWxowA?t=00h03m23s)

[template demo app so](https://youtu.be/tRxsBGWxowA?t=00h03m27s)

[hang on this is an opportunity for](https://youtu.be/tRxsBGWxowA?t=00h03m29s)

[Shameless self-promotion](https://youtu.be/tRxsBGWxowA?t=00h03m32s)

[um also](https://youtu.be/tRxsBGWxowA?t=00h03m34s)

[the brain teaser that was up if anybody](https://youtu.be/tRxsBGWxowA?t=00h03m36s)

[finds it interesting](https://youtu.be/tRxsBGWxowA?t=00h03m38s)

[um](https://youtu.be/tRxsBGWxowA?t=00h03m40s)

[let me know](https://youtu.be/tRxsBGWxowA?t=00h03m40s)

[uh we will cut we I will uh Circle back](https://youtu.be/tRxsBGWxowA?t=00h03m42s)

[to the brain teaser at the end um but if](https://youtu.be/tRxsBGWxowA?t=00h03m45s)

[anybody is interested the app that I am](https://youtu.be/tRxsBGWxowA?t=00h03m47s)

[starting with uh is from my own template](https://youtu.be/tRxsBGWxowA?t=00h03m50s)

[you run uh let's see](https://youtu.be/tRxsBGWxowA?t=00h03m54s)

[boom if you click full WPF project](https://youtu.be/tRxsBGWxowA?t=00h03m57s)

[.net new kabu WPF boom that's it](https://youtu.be/tRxsBGWxowA?t=00h04m00s)

[so install the template](https://youtu.be/tRxsBGWxowA?t=00h04m04s)

[dot net new you end up with something](https://youtu.be/tRxsBGWxowA?t=00h04m06s)

[that looks like this](https://youtu.be/tRxsBGWxowA?t=00h04m09s)

[well sort of I've added a box so here's](https://youtu.be/tRxsBGWxowA?t=00h04m11s)

[here's my current thinking of how I](https://youtu.be/tRxsBGWxowA?t=00h04m14s)

[think I want to do this so I kind of](https://youtu.be/tRxsBGWxowA?t=00h04m16s)

[want to play around in this small](https://youtu.be/tRxsBGWxowA?t=00h04m17s)

[application](https://youtu.be/tRxsBGWxowA?t=00h04m19s)

[that way I can start small figure out](https://youtu.be/tRxsBGWxowA?t=00h04m21s)

[what the end result needs to look like](https://youtu.be/tRxsBGWxowA?t=00h04m23s)

[because I think we're going to do some](https://youtu.be/tRxsBGWxowA?t=00h04m25s)

[Source generatory bits to get everything](https://youtu.be/tRxsBGWxowA?t=00h04m26s)

[all up and going I think I think](https://youtu.be/tRxsBGWxowA?t=00h04m29s)

[um because there's a lot of things that](https://youtu.be/tRxsBGWxowA?t=00h04m33s)

[I there's a lot of use cases I want to](https://youtu.be/tRxsBGWxowA?t=00h04m34s)

[make sure work well but I figure I'm](https://youtu.be/tRxsBGWxowA?t=00h04m36s)

[going to do this with one brush in an](https://youtu.be/tRxsBGWxowA?t=00h04m37s)

[isolated little demo](https://youtu.be/tRxsBGWxowA?t=00h04m40s)

[make sure I'm happy with the one case](https://youtu.be/tRxsBGWxowA?t=00h04m42s)

[and then we'll expand it out to](https://youtu.be/tRxsBGWxowA?t=00h04m44s)

[everything so that's the game plan](https://youtu.be/tRxsBGWxowA?t=00h04m46s)

[so I've got this little border it's got](https://youtu.be/tRxsBGWxowA?t=00h04m49s)

[a width it's got a height it's using](https://youtu.be/tRxsBGWxowA?t=00h04m51s)

[this theme brush that I called other](https://youtu.be/tRxsBGWxowA?t=00h04m54s)

[um and actually there's also one called](https://youtu.be/tRxsBGWxowA?t=00h04m57s)

[primary that we can drop in as well and](https://youtu.be/tRxsBGWxowA?t=00h04m58s)

[as all good UI designers will tell you](https://youtu.be/tRxsBGWxowA?t=00h05m01s)

[you the default color is always fuchsia](https://youtu.be/tRxsBGWxowA?t=00h05m03s)

[uh mostly because it's ugly enough I](https://youtu.be/tRxsBGWxowA?t=00h05m05s)

[know I'm not going to leave it there](https://youtu.be/tRxsBGWxowA?t=00h05m07s)

[I apologize T-Mobile people who pick on](https://youtu.be/tRxsBGWxowA?t=00h05m09s)

[the weird pink colors sure I'm sure](https://youtu.be/tRxsBGWxowA?t=00h05m12s)

[designers can make it work for me it's](https://youtu.be/tRxsBGWxowA?t=00h05m15s)

[ugly enough that I leave it as a visual](https://youtu.be/tRxsBGWxowA?t=00h05m17s)

[to do](https://youtu.be/tRxsBGWxowA?t=00h05m18s)

[um I actually told the designer that I](https://youtu.be/tRxsBGWxowA?t=00h05m19s)

[worked with recently I'm like if you see](https://youtu.be/tRxsBGWxowA?t=00h05m21s)

[fuchsia in the app just understand that](https://youtu.be/tRxsBGWxowA?t=00h05m22s)

[that was me trying to communicate I](https://youtu.be/tRxsBGWxowA?t=00h05m24s)

[still need a design or a theme for this](https://youtu.be/tRxsBGWxowA?t=00h05m26s)

[uh and I didn't want to make sure that I](https://youtu.be/tRxsBGWxowA?t=00h05m29s)

[that we shipped something that was good](https://youtu.be/tRxsBGWxowA?t=00h05m32s)

[enough so I make it ugly enough to make](https://youtu.be/tRxsBGWxowA?t=00h05m33s)

[sure people change it uh okay so here's](https://youtu.be/tRxsBGWxowA?t=00h05m35s)

[this nothing fancy it's a dynamic](https://youtu.be/tRxsBGWxowA?t=00h05m38s)

[resource because it's a theme brush and](https://youtu.be/tRxsBGWxowA?t=00h05m40s)

[in WPF you always want to use Dynamic](https://youtu.be/tRxsBGWxowA?t=00h05m42s)

[resources on anything that could change](https://youtu.be/tRxsBGWxowA?t=00h05m44s)

[at runtime so typically that will be](https://youtu.be/tRxsBGWxowA?t=00h05m46s)

[things like your color themes because if](https://youtu.be/tRxsBGWxowA?t=00h05m49s)

[you want to give the user the ability to](https://youtu.be/tRxsBGWxowA?t=00h05m51s)

[toggle between dark and light theme and](https://youtu.be/tRxsBGWxowA?t=00h05m53s)

[whatnot uh this the actual color behind](https://youtu.be/tRxsBGWxowA?t=00h05m54s)

[this is potentially going to change](https://youtu.be/tRxsBGWxowA?t=00h05m58s)

[um so and I think we are going to](https://youtu.be/tRxsBGWxowA?t=00h06m01s)

[actually demonstrate changing this so](https://youtu.be/tRxsBGWxowA?t=00h06m02s)

[let's look at what I did so in my](https://youtu.be/tRxsBGWxowA?t=00h06m04s)

[app.xaml I declared a color and I again](https://youtu.be/tRxsBGWxowA?t=00h06m05s)

[this is me just testing the structure](https://youtu.be/tRxsBGWxowA?t=00h06m09s)

[that I think I want for the material](https://youtu.be/tRxsBGWxowA?t=00h06m11s)

[design project](https://youtu.be/tRxsBGWxowA?t=00h06m12s)

[um](https://youtu.be/tRxsBGWxowA?t=00h06m15s)

[so I've got a color and then I create a](https://youtu.be/tRxsBGWxowA?t=00h06m16s)

[solid color brush giving it a key so I'm](https://youtu.be/tRxsBGWxowA?t=00h06m19s)

[just kind of playing with this uh idea](https://youtu.be/tRxsBGWxowA?t=00h06m22s)

[Here theme brushes](https://youtu.be/tRxsBGWxowA?t=00h06m24s)

[primary on the material design and xaml](https://youtu.be/tRxsBGWxowA?t=00h06m26s)

[project there is a](https://youtu.be/tRxsBGWxowA?t=00h06m29s)

[we go here this thing this theme brush](https://youtu.be/tRxsBGWxowA?t=00h06m33s)

[renamed there is my proposal here for](https://youtu.be/tRxsBGWxowA?t=00h06m36s)

[how some of these brushes are going to](https://youtu.be/tRxsBGWxowA?t=00h06m40s)

[break down](https://youtu.be/tRxsBGWxowA?t=00h06m41s)

[um everything starts with material](https://youtu.be/tRxsBGWxowA?t=00h06m44s)

[design dot brush there will obviously be](https://youtu.be/tRxsBGWxowA?t=00h06m45s)

[dot color to go along with it but then](https://youtu.be/tRxsBGWxowA?t=00h06m48s)

[primary light primary light foreground](https://youtu.be/tRxsBGWxowA?t=00h06m50s)

[Etc so I'm playing around with this idea](https://youtu.be/tRxsBGWxowA?t=00h06m52s)

[I think this is the naming scheme I want](https://youtu.be/tRxsBGWxowA?t=00h06m55s)

[I think obviously issues open all](https://youtu.be/tRxsBGWxowA?t=00h06m58s)

[feedback and critique welcome](https://youtu.be/tRxsBGWxowA?t=00h07m01s)

[we link these two guys together](https://youtu.be/tRxsBGWxowA?t=00h07m03s)

[and then this little trick here of going](https://youtu.be/tRxsBGWxowA?t=00h07m06s)

[through and generating a static resource](https://youtu.be/tRxsBGWxowA?t=00h07m09s)

[um effectively giving me a way to Alias](https://youtu.be/tRxsBGWxowA?t=00h07m13s)

[it and I think I like this](https://youtu.be/tRxsBGWxowA?t=00h07m16s)

[specifically what I think I like is the](https://youtu.be/tRxsBGWxowA?t=00h07m19s)

[ability to be able to come in and](https://youtu.be/tRxsBGWxowA?t=00h07m23s)

[uh let's just do this again right so](https://youtu.be/tRxsBGWxowA?t=00h07m26s)

[I've got two boxes](https://youtu.be/tRxsBGWxowA?t=00h07m30s)

[other](https://youtu.be/tRxsBGWxowA?t=00h07m33s)

[right and it gives me that ability to](https://youtu.be/tRxsBGWxowA?t=00h07m35s)

[have alternate resource keys but still](https://youtu.be/tRxsBGWxowA?t=00h07m38s)

[Source them from the same underlying](https://youtu.be/tRxsBGWxowA?t=00h07m42s)

[brush I think I like this and](https://youtu.be/tRxsBGWxowA?t=00h07m44s)

[specifically what I think I like is it](https://youtu.be/tRxsBGWxowA?t=00h07m47s)

[means I can start with a small number of](https://youtu.be/tRxsBGWxowA?t=00h07m49s)

[brushes because we probably are not](https://youtu.be/tRxsBGWxowA?t=00h07m52s)

[going to have that many different colors](https://youtu.be/tRxsBGWxowA?t=00h07m54s)

[so the default material design themes](https://youtu.be/tRxsBGWxowA?t=00h07m56s)

[there's your primary color which it has](https://youtu.be/tRxsBGWxowA?t=00h07m59s)

[a a dark and a light variant there's](https://youtu.be/tRxsBGWxowA?t=00h08m03s)

[your secondary color which also has a](https://youtu.be/tRxsBGWxowA?t=00h08m05s)

[dark and a light variant there's things](https://youtu.be/tRxsBGWxowA?t=00h08m06s)

[like your your dark and light](https://youtu.be/tRxsBGWxowA?t=00h08m09s)

[backgrounds kind of like your what I](https://youtu.be/tRxsBGWxowA?t=00h08m11s)

[don't want to say whites and blacks](https://youtu.be/tRxsBGWxowA?t=00h08m12s)

[because they're off white and off uh and](https://youtu.be/tRxsBGWxowA?t=00h08m14s)

[off black a little bit uh but you've got](https://youtu.be/tRxsBGWxowA?t=00h08m16s)

[some of those you've got some Grays](https://youtu.be/tRxsBGWxowA?t=00h08m18s)

[thrown in there for like separators and](https://youtu.be/tRxsBGWxowA?t=00h08m20s)

[different things like that or Shadows](https://youtu.be/tRxsBGWxowA?t=00h08m21s)

[um but overall the the fundamental](https://youtu.be/tRxsBGWxowA?t=00h08m24s)

[colors that start your theme there's not](https://youtu.be/tRxsBGWxowA?t=00h08m27s)

[that many and what I think I want to let](https://youtu.be/tRxsBGWxowA?t=00h08m29s)

[people do is be able to have one if](https://youtu.be/tRxsBGWxowA?t=00h08m32s)

[people want to go crazy and Define every](https://youtu.be/tRxsBGWxowA?t=00h08m37s)

[brush have at it right I wanna I wanna](https://youtu.be/tRxsBGWxowA?t=00h08m38s)

[give people a template uh resource](https://youtu.be/tRxsBGWxowA?t=00h08m41s)

[dictionary that has all of them defined](https://youtu.be/tRxsBGWxowA?t=00h08m45s)

[and you can change them to your heart's](https://youtu.be/tRxsBGWxowA?t=00h08m48s)

[content right if you want all of them go](https://youtu.be/tRxsBGWxowA?t=00h08m50s)

[to town but I think the way I want to](https://youtu.be/tRxsBGWxowA?t=00h08m53s)

[structure that is going to be something](https://youtu.be/tRxsBGWxowA?t=00h08m56s)

[like this where we've got the colors](https://youtu.be/tRxsBGWxowA?t=00h08m57s)

[the colors have their have their brushes](https://youtu.be/tRxsBGWxowA?t=00h09m01s)

[and then behind the scenes there's a](https://youtu.be/tRxsBGWxowA?t=00h09m04s)

[whole bunch of aliases that way if](https://youtu.be/tRxsBGWxowA?t=00h09m07s)

[somebody goes](https://youtu.be/tRxsBGWxowA?t=00h09m08s)

[I don't want this thing aliased off of](https://youtu.be/tRxsBGWxowA?t=00h09m10s)

[the primary I wanted aliased somewhere](https://youtu.be/tRxsBGWxowA?t=00h09m12s)

[else great Swap this thing out right so](https://youtu.be/tRxsBGWxowA?t=00h09m15s)

[if we do something like solid color](https://youtu.be/tRxsBGWxowA?t=00h09m18s)

[brush X key](https://youtu.be/tRxsBGWxowA?t=00h09m21s)

[again I'm just testing out what I think](https://youtu.be/tRxsBGWxowA?t=00h09m23s)

[I want](https://youtu.be/tRxsBGWxowA?t=00h09m26s)

[other and then this guy goes color blue](https://youtu.be/tRxsBGWxowA?t=00h09m28s)

[right because that's](https://youtu.be/tRxsBGWxowA?t=00h09m31s)

[that that's another color right now we](https://youtu.be/tRxsBGWxowA?t=00h09m33s)

[can do this and now when I come back](https://youtu.be/tRxsBGWxowA?t=00h09m36s)

[here this guy is now sore so without](https://youtu.be/tRxsBGWxowA?t=00h09m38s)

[changing my app just changing the](https://youtu.be/tRxsBGWxowA?t=00h09m41s)

[resource dictionaries that are imported](https://youtu.be/tRxsBGWxowA?t=00h09m43s)

[above I end up with this](https://youtu.be/tRxsBGWxowA?t=00h09m46s)

[I think this is what I want I can think](https://youtu.be/tRxsBGWxowA?t=00h09m48s)

[so let's take this a step further](https://youtu.be/tRxsBGWxowA?t=00h09m51s)

[because the other thing I want to test](https://youtu.be/tRxsBGWxowA?t=00h09m54s)

[is doing some some themy changes stuff](https://youtu.be/tRxsBGWxowA?t=00h09m56s)

[so we've already got a button that's](https://youtu.be/tRxsBGWxowA?t=00h10m00s)

[called click me so we're gonna we're](https://youtu.be/tRxsBGWxowA?t=00h10m03s)

[gonna go reroute this button to do](https://youtu.be/tRxsBGWxowA?t=00h10m05s)

[something different and in general you](https://youtu.be/tRxsBGWxowA?t=00h10m07s)

[should not](https://youtu.be/tRxsBGWxowA?t=00h10m10s)

[uh you should not do what I'm about to](https://youtu.be/tRxsBGWxowA?t=00h10m12s)

[do in your view models this is this is](https://youtu.be/tRxsBGWxowA?t=00h10m15s)

[demo level stuff we're gonna we're gonna](https://youtu.be/tRxsBGWxowA?t=00h10m17s)

[just try it so](https://youtu.be/tRxsBGWxowA?t=00h10m19s)

[um yeah so this button is bound to](https://youtu.be/tRxsBGWxowA?t=00h10m22s)

[increment count so this is where we want](https://youtu.be/tRxsBGWxowA?t=00h10m25s)

[to be so we're going to do and](https://youtu.be/tRxsBGWxowA?t=00h10m27s)

[specifically this is the line of code](https://youtu.be/tRxsBGWxowA?t=00h10m29s)

[that I would recommend you not put in](https://youtu.be/tRxsBGWxowA?t=00h10m31s)

[your view models uh ever](https://youtu.be/tRxsBGWxowA?t=00h10m32s)

[app.current](https://youtu.be/tRxsBGWxowA?t=00h10m35s)

[uh uh if you find yourself doing this](https://youtu.be/tRxsBGWxowA?t=00h10m37s)

[back up slowly you are probably mixing](https://youtu.be/tRxsBGWxowA?t=00h10m40s)

[mixing View and view model code](https://youtu.be/tRxsBGWxowA?t=00h10m43s)

[in most cases if you see you're using](https://youtu.be/tRxsBGWxowA?t=00h10m47s)

[system Windows](https://youtu.be/tRxsBGWxowA?t=00h10m49s)

[that is something okay sidebar while I'm](https://youtu.be/tRxsBGWxowA?t=00h10m50s)

[thinking about it](https://youtu.be/tRxsBGWxowA?t=00h10m53s)

[um one thing I that keeps floating](https://youtu.be/tRxsBGWxowA?t=00h10m54s)

[around in my head is I've got](https://youtu.be/tRxsBGWxowA?t=00h10m56s)

[these ideas](https://youtu.be/tRxsBGWxowA?t=00h11m00s)

[of things that I would want an analyzer](https://youtu.be/tRxsBGWxowA?t=00h11m02s)

[to flag in my code](https://youtu.be/tRxsBGWxowA?t=00h11m04s)

[however](https://youtu.be/tRxsBGWxowA?t=00h11m07s)

[a lot of them tend to be very specific](https://youtu.be/tRxsBGWxowA?t=00h11m08s)

[to a given project or a domain and the](https://youtu.be/tRxsBGWxowA?t=00h11m11s)

[problem is is building a](https://youtu.be/tRxsBGWxowA?t=00h11m14s)

[a somewhat customy analyzer for each](https://youtu.be/tRxsBGWxowA?t=00h11m16s)

[project](https://youtu.be/tRxsBGWxowA?t=00h11m20s)

[seems difficult](https://youtu.be/tRxsBGWxowA?t=00h11m21s)

[and I keep having ideas floating the](https://youtu.be/tRxsBGWxowA?t=00h11m23s)

[back of my head of I'd really love it if](https://youtu.be/tRxsBGWxowA?t=00h11m25s)

[there was a](https://youtu.be/tRxsBGWxowA?t=00h11m27s)

[simple way simple way to emphasis loop I](https://youtu.be/tRxsBGWxowA?t=00h11m29s)

[realize what I'm proposing is not simple](https://youtu.be/tRxsBGWxowA?t=00h11m32s)

[in the least](https://youtu.be/tRxsBGWxowA?t=00h11m34s)

[but a a way to have a generic analyzer](https://youtu.be/tRxsBGWxowA?t=00h11m35s)

[that I could feed a set of rules to](https://youtu.be/tRxsBGWxowA?t=00h11m38s)

[and then have uh](https://youtu.be/tRxsBGWxowA?t=00h11m41s)

[and then have it apply those at each of](https://youtu.be/tRxsBGWxowA?t=00h11m44s)

[my projects that way I didn't have to](https://youtu.be/tRxsBGWxowA?t=00h11m46s)

[build up new analyzers the whole setup](https://youtu.be/tRxsBGWxowA?t=00h11m48s)

[and templating bit is kind of a pain](https://youtu.be/tRxsBGWxowA?t=00h11m50s)

[let's see I have a couple questions](https://youtu.be/tRxsBGWxowA?t=00h11m52s)

[about your mvvm uh 8.1 video you said](https://youtu.be/tRxsBGWxowA?t=00h11m54s)

[you should uh](https://youtu.be/tRxsBGWxowA?t=00h11m57s)

[uh this loads the token of messenger but](https://youtu.be/tRxsBGWxowA?t=00h12m01s)

[if I'm not wrong there there's no](https://youtu.be/tRxsBGWxowA?t=00h12m04s)

[disposed method in a WPF control then](https://youtu.be/tRxsBGWxowA?t=00h12m07s)

[how can you do it](https://youtu.be/tRxsBGWxowA?t=00h12m09s)

[hang on sorry](https://youtu.be/tRxsBGWxowA?t=00h12m12s)

[I think that question's supposed to read](https://youtu.be/tRxsBGWxowA?t=00h12m18s)

[you said you should dispose the token of](https://youtu.be/tRxsBGWxowA?t=00h12m20s)

[the messenger but if I'm not wrong there](https://youtu.be/tRxsBGWxowA?t=00h12m23s)

[is no dispose method in a WPF control](https://youtu.be/tRxsBGWxowA?t=00h12m26s)

[therefore how can you do it](https://youtu.be/tRxsBGWxowA?t=00h12m29s)

[ah so](https://youtu.be/tRxsBGWxowA?t=00h12m32s)

[if you don't mind uh darkum first of all](https://youtu.be/tRxsBGWxowA?t=00h12m34s)

[welcome thank you for the question](https://youtu.be/tRxsBGWxowA?t=00h12m37s)

[um let's take a look so we're gonna come](https://youtu.be/tRxsBGWxowA?t=00h12m40s)

[back](https://youtu.be/tRxsBGWxowA?t=00h12m41s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h12m43s)

[Kevin let's start here okay so we'll](https://youtu.be/tRxsBGWxowA?t=00h12m44s)

[come back to that in a minute so let's](https://youtu.be/tRxsBGWxowA?t=00h12m47s)

[start with this uh I messenger](https://youtu.be/tRxsBGWxowA?t=00h12m48s)

[uh messenger](https://youtu.be/tRxsBGWxowA?t=00h12m52s)

[right so there's there's a couple cases](https://youtu.be/tRxsBGWxowA?t=00h12m54s)

[and wow co-pilot no that is not what I](https://youtu.be/tRxsBGWxowA?t=00h12m56s)

[intended for you to learn](https://youtu.be/tRxsBGWxowA?t=00h12m59s)

[um](https://youtu.be/tRxsBGWxowA?t=00h13m01s)

[so I if and you're asking me to remember](https://youtu.be/tRxsBGWxowA?t=00h13m02s)

[like a whole week ago and my memory is](https://youtu.be/tRxsBGWxowA?t=00h13m05s)

[not that good right now lack of sleep](https://youtu.be/tRxsBGWxowA?t=00h13m07s)

[and not enough caffeine](https://youtu.be/tRxsBGWxowA?t=00h13m08s)

[so there's a couple ways to go about](https://youtu.be/tRxsBGWxowA?t=00h13m11s)

[doing this because the messenger is](https://youtu.be/tRxsBGWxowA?t=00h13m13s)

[um one of those interfaces that ends up](https://youtu.be/tRxsBGWxowA?t=00h13m16s)

[in a lot of different places](https://youtu.be/tRxsBGWxowA?t=00h13m18s)

[in my apps it kind of ends up being that](https://youtu.be/tRxsBGWxowA?t=00h13m20s)

[Communications piece between like maybe](https://youtu.be/tRxsBGWxowA?t=00h13m23s)

[some user controls over here maybe a](https://youtu.be/tRxsBGWxowA?t=00h13m25s)

[window over here some view models over](https://youtu.be/tRxsBGWxowA?t=00h13m27s)

[here and it's just sending messages all](https://youtu.be/tRxsBGWxowA?t=00h13m29s)

[over the place and so how you might go](https://youtu.be/tRxsBGWxowA?t=00h13m31s)

[about handling](https://youtu.be/tRxsBGWxowA?t=00h13m34s)

[um disposing](https://youtu.be/tRxsBGWxowA?t=00h13m36s)

[is going to vary depending on what](https://youtu.be/tRxsBGWxowA?t=00h13m38s)

[context we're in](https://youtu.be/tRxsBGWxowA?t=00h13m41s)

[So based on your question I think what](https://youtu.be/tRxsBGWxowA?t=00h13m42s)

[you were driving for is you have a](https://youtu.be/tRxsBGWxowA?t=00h13m45s)

[messenger inside of a user control so](https://youtu.be/tRxsBGWxowA?t=00h13m47s)

[let's](https://youtu.be/tRxsBGWxowA?t=00h13m51s)

[and again feel free to feel free to uh](https://youtu.be/tRxsBGWxowA?t=00h13m52s)

[correct me if I'm off base here uh yeah](https://youtu.be/tRxsBGWxowA?t=00h13m55s)

[user control one sounds like a great](https://youtu.be/tRxsBGWxowA?t=00h13m57s)

[name](https://youtu.be/tRxsBGWxowA?t=00h13m59s)

[Okay so we've got user control here and](https://youtu.be/tRxsBGWxowA?t=00h14m01s)

[let's just put something in it so we can](https://youtu.be/tRxsBGWxowA?t=00h14m04s)

[see it uh](https://youtu.be/tRxsBGWxowA?t=00h14m06s)

[thumb user control](https://youtu.be/tRxsBGWxowA?t=00h14m08s)

[all right so this guy for whatever](https://youtu.be/tRxsBGWxowA?t=00h14m11s)

[reason is going to like listen on](https://youtu.be/tRxsBGWxowA?t=00h14m13s)

[messages for reasons or similar uh](https://youtu.be/tRxsBGWxowA?t=00h14m15s)

[and let's save that and then let's drop](https://youtu.be/tRxsBGWxowA?t=00h14m23s)

[in our user control here](https://youtu.be/tRxsBGWxowA?t=00h14m26s)

[uh yeah user control one great](https://youtu.be/tRxsBGWxowA?t=00h14m29s)

[okay and let's just build the project so](https://youtu.be/tRxsBGWxowA?t=00h14m34s)

[that the designer can be happy](https://youtu.be/tRxsBGWxowA?t=00h14m36s)

[okay some user control there great great](https://youtu.be/tRxsBGWxowA?t=00h14m40s)

[now um so there's a couple things first](https://youtu.be/tRxsBGWxowA?t=00h14m45s)

[of all to be aware of one I'm going to](https://youtu.be/tRxsBGWxowA?t=00h14m48s)

[clean up this default because this all](https://youtu.be/tRxsBGWxowA?t=00h14m50s)

[bothers me and that's a lot cleaner to](https://youtu.be/tRxsBGWxowA?t=00h14m52s)

[look at](https://youtu.be/tRxsBGWxowA?t=00h14m54s)

[so the the thing with user controls uh](https://youtu.be/tRxsBGWxowA?t=00h14m55s)

[let's see](https://youtu.be/tRxsBGWxowA?t=00h14m59s)

[second with observable Corrections if I](https://youtu.be/tRxsBGWxowA?t=00h15m00s)

[so at the source of list box let's](https://youtu.be/tRxsBGWxowA?t=00h15m03s)

[listen to the list box will be updated](https://youtu.be/tRxsBGWxowA?t=00h15m05s)

[during the sort](https://youtu.be/tRxsBGWxowA?t=00h15m07s)

[which is uh Json waste is it possible](https://youtu.be/tRxsBGWxowA?t=00h15m08s)

[deposit as soon as the responsibility](https://youtu.be/tRxsBGWxowA?t=00h15m13s)

[update only at the end of the sort](https://youtu.be/tRxsBGWxowA?t=00h15m14s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h15m17s)

[uh yes yes I will come I will come back](https://youtu.be/tRxsBGWxowA?t=00h15m22s)

[to that as well](https://youtu.be/tRxsBGWxowA?t=00h15m26s)

[um inside of a user control getting your](https://youtu.be/tRxsBGWxowA?t=00h15m28s)

[iMessenger into it is oftentimes](https://youtu.be/tRxsBGWxowA?t=00h15m30s)

[difficult but let's pretend for a moment](https://youtu.be/tRxsBGWxowA?t=00h15m34s)

[that we've gotten our](https://youtu.be/tRxsBGWxowA?t=00h15m36s)

[uh I messenger](https://youtu.be/tRxsBGWxowA?t=00h15m38s)

[let's just pretend that we've gotten it](https://youtu.be/tRxsBGWxowA?t=00h15m42s)

[in here so making your user control](https://youtu.be/tRxsBGWxowA?t=00h15m44s)

[um disposable is typically not what you](https://youtu.be/tRxsBGWxowA?t=00h15m48s)

[want however inside of um view objects](https://youtu.be/tRxsBGWxowA?t=00h15m49s)

[so this will apply to user controls](https://youtu.be/tRxsBGWxowA?t=00h15m53s)

[Windows Etc](https://youtu.be/tRxsBGWxowA?t=00h15m55s)

[you do have a loaded](https://youtu.be/tRxsBGWxowA?t=00h15m56s)

[um and unloaded events and oftentimes](https://youtu.be/tRxsBGWxowA?t=00h16m00s)

[these are sufficient for what you are](https://youtu.be/tRxsBGWxowA?t=00h16m03s)

[doing](https://youtu.be/tRxsBGWxowA?t=00h16m07s)

[so specifically if you are looking to](https://youtu.be/tRxsBGWxowA?t=00h16m08s)

[say hey I want this user control to](https://youtu.be/tRxsBGWxowA?t=00h16m10s)

[register up on messages right so](https://youtu.be/tRxsBGWxowA?t=00h16m13s)

[messenger](https://youtu.be/tRxsBGWxowA?t=00h16m16s)

[uh let's see](https://youtu.be/tRxsBGWxowA?t=00h16m18s)

[was it register all or is registered for](https://youtu.be/tRxsBGWxowA?t=00h16m19s)

[the token](https://youtu.be/tRxsBGWxowA?t=00h16m23s)

[one of these guys has the the token](https://youtu.be/tRxsBGWxowA?t=00h16m26s)

[recipient on here if one of these was](https://youtu.be/tRxsBGWxowA?t=00h16m28s)

[looking to actually](https://youtu.be/tRxsBGWxowA?t=00h16m31s)

[do that registration](https://youtu.be/tRxsBGWxowA?t=00h16m34s)

[the the unloaded one would be your](https://youtu.be/tRxsBGWxowA?t=00h16m36s)

[equivalent for uh unloading it the other](https://youtu.be/tRxsBGWxowA?t=00h16m39s)

[thing that oftentimes I find myself](https://youtu.be/tRxsBGWxowA?t=00h16m42s)

[doing like for example in the the main](https://youtu.be/tRxsBGWxowA?t=00h16m45s)

[window](https://youtu.be/tRxsBGWxowA?t=00h16m48s)

[right is here Windows have a nice close](https://youtu.be/tRxsBGWxowA?t=00h16m49s)

[event that you can watch for and that's](https://youtu.be/tRxsBGWxowA?t=00h16m54s)

[a very easy way to say hey when when is](https://youtu.be/tRxsBGWxowA?t=00h16m56s)

[the window closed](https://youtu.be/tRxsBGWxowA?t=00h16m58s)

[um however if you've got things where](https://youtu.be/tRxsBGWxowA?t=00h17m00s)

[they are](https://youtu.be/tRxsBGWxowA?t=00h17m02s)

[um](https://youtu.be/tRxsBGWxowA?t=00h17m04s)

[creating their own](https://youtu.be/tRxsBGWxowA?t=00h17m04s)

[or they where the user control owns the](https://youtu.be/tRxsBGWxowA?t=00h17m07s)

[data context you may end up wanting to](https://youtu.be/tRxsBGWxowA?t=00h17m10s)

[do something like](https://youtu.be/tRxsBGWxowA?t=00h17m13s)

[um eye disposable](https://youtu.be/tRxsBGWxowA?t=00h17m14s)

[uh oh I'm in the wrong method](https://youtu.be/tRxsBGWxowA?t=00h17m17s)

[uh uh you may end up wanting to do](https://youtu.be/tRxsBGWxowA?t=00h17m20s)

[something like this or even if a data](https://youtu.be/tRxsBGWxowA?t=00h17m23s)

[context is I disposable](https://youtu.be/tRxsBGWxowA?t=00h17m27s)

[uh uh](https://youtu.be/tRxsBGWxowA?t=00h17m33s)

[thank you](https://youtu.be/tRxsBGWxowA?t=00h17m37s)

[because oftentimes with your views](https://youtu.be/tRxsBGWxowA?t=00h17m41s)

[loaded and unloaded will end up being](https://youtu.be/tRxsBGWxowA?t=00h17m43s)

[the inverse of each other now most of](https://youtu.be/tRxsBGWxowA?t=00h17m45s)

[the time this won't be a problem but](https://youtu.be/tRxsBGWxowA?t=00h17m48s)

[um](https://youtu.be/tRxsBGWxowA?t=00h17m52s)

[depending on how you're doing your your](https://youtu.be/tRxsBGWxowA?t=00h17m54s)

[user controls and your views this](https://youtu.be/tRxsBGWxowA?t=00h17m56s)

[um Can occasionally be problematic](https://youtu.be/tRxsBGWxowA?t=00h18m00s)

[having multiple disposes so just be](https://youtu.be/tRxsBGWxowA?t=00h18m02s)

[aware that a properly implemented eye](https://youtu.be/tRxsBGWxowA?t=00h18m04s)

[dispose method is expected to be](https://youtu.be/tRxsBGWxowA?t=00h18m07s)

[tolerant of being called multiple times](https://youtu.be/tRxsBGWxowA?t=00h18m10s)

[if you let Visual Studio implement the](https://youtu.be/tRxsBGWxowA?t=00h18m12s)

[eye dispose interface uh for example if](https://youtu.be/tRxsBGWxowA?t=00h18m14s)

[I just do it here](https://youtu.be/tRxsBGWxowA?t=00h18m17s)

[and I say Visual Studio write it for me](https://youtu.be/tRxsBGWxowA?t=00h18m20s)

[you'll note Implement interface with](https://youtu.be/tRxsBGWxowA?t=00h18m22s)

[dispose pattern so if you let Visual](https://youtu.be/tRxsBGWxowA?t=00h18m24s)

[Studio Do It](https://youtu.be/tRxsBGWxowA?t=00h18m26s)

[um you will note that it uh is tolerant](https://youtu.be/tRxsBGWxowA?t=00h18m28s)

[of making sure that it doesn't invoke](https://youtu.be/tRxsBGWxowA?t=00h18m31s)

[multiple times so it has this flag that](https://youtu.be/tRxsBGWxowA?t=00h18m33s)

[say effectively am I already disposed](https://youtu.be/tRxsBGWxowA?t=00h18m35s)

[which gets set to True here so if](https://youtu.be/tRxsBGWxowA?t=00h18m39s)

[dispose ends up being invoked multiple](https://youtu.be/tRxsBGWxowA?t=00h18m41s)

[times you won't actually end up doing](https://youtu.be/tRxsBGWxowA?t=00h18m43s)

[the work twice so that's how a properly](https://youtu.be/tRxsBGWxowA?t=00h18m45s)

[implemented dispose method should work](https://youtu.be/tRxsBGWxowA?t=00h18m49s)

[not all classes may follow that so just](https://youtu.be/tRxsBGWxowA?t=00h18m51s)

[be aware if it's if it's just your stuff](https://youtu.be/tRxsBGWxowA?t=00h18m54s)

[you're cleaning up Implement dispose](https://youtu.be/tRxsBGWxowA?t=00h18m55s)

[properly problem goes away everyone's](https://youtu.be/tRxsBGWxowA?t=00h18m57s)

[happy](https://youtu.be/tRxsBGWxowA?t=00h18m59s)

[um let's see okay](https://youtu.be/tRxsBGWxowA?t=00h19m01s)

[so uh for view models if you have an](https://youtu.be/tRxsBGWxowA?t=00h19m04s)

[iMessenger instance in here](https://youtu.be/tRxsBGWxowA?t=00h19m08s)

[um making your view model I disposable](https://youtu.be/tRxsBGWxowA?t=00h19m11s)

[is definitely one way of going through](https://youtu.be/tRxsBGWxowA?t=00h19m13s)

[and handling it the uh the other way is](https://youtu.be/tRxsBGWxowA?t=00h19m15s)

[uh just giving yourself some sort of](https://youtu.be/tRxsBGWxowA?t=00h19m20s)

[um cleanup method when you know that](https://youtu.be/tRxsBGWxowA?t=00h19m23s)

[it's no longer going to happen so if](https://youtu.be/tRxsBGWxowA?t=00h19m25s)

[you're using the weak reference](https://youtu.be/tRxsBGWxowA?t=00h19m28s)

[messenger](https://youtu.be/tRxsBGWxowA?t=00h19m29s)

[I should think through this before I put](https://youtu.be/tRxsBGWxowA?t=00h19m31s)

[my foot all the way in my mouth](https://youtu.be/tRxsBGWxowA?t=00h19m33s)

[the messenger itself will not maintain a](https://youtu.be/tRxsBGWxowA?t=00h19m35s)

[strong reference to your view model](https://youtu.be/tRxsBGWxowA?t=00h19m39s)

[so typically the only thing that's going](https://youtu.be/tRxsBGWxowA?t=00h19m40s)

[to hold a reference to your view model](https://youtu.be/tRxsBGWxowA?t=00h19m42s)

[is going to be the view itself](https://youtu.be/tRxsBGWxowA?t=00h19m44s)

[so in my in my use case here I've got a](https://youtu.be/tRxsBGWxowA?t=00h19m47s)

[main window this view model here the](https://youtu.be/tRxsBGWxowA?t=00h19m50s)

[window is the Windows data context is](https://youtu.be/tRxsBGWxowA?t=00h19m54s)

[what's holding the reference to my view](https://youtu.be/tRxsBGWxowA?t=00h19m56s)

[model so unless I've done something](https://youtu.be/tRxsBGWxowA?t=00h19m58s)

[where like my di container as registered](https://youtu.be/tRxsBGWxowA?t=00h20m00s)

[this is Singleton and is holding on to](https://youtu.be/tRxsBGWxowA?t=00h20m03s)

[it as well the only thing that's going](https://youtu.be/tRxsBGWxowA?t=00h20m05s)

[to keep this viewmodel instance alive is](https://youtu.be/tRxsBGWxowA?t=00h20m07s)

[this view itself so uh giving yourself a](https://youtu.be/tRxsBGWxowA?t=00h20m10s)

[method where your view calls back into](https://youtu.be/tRxsBGWxowA?t=00h20m14s)

[your view model to notify it of hey](https://youtu.be/tRxsBGWxowA?t=00h20m17s)

[you're all done time to be cleaned up I](https://youtu.be/tRxsBGWxowA?t=00h20m19s)

[disposable is a convenient way to go](https://youtu.be/tRxsBGWxowA?t=00h20m22s)

[about doing that but you don't](https://youtu.be/tRxsBGWxowA?t=00h20m23s)

[necessarily have to](https://youtu.be/tRxsBGWxowA?t=00h20m25s)

[so](https://youtu.be/tRxsBGWxowA?t=00h20m27s)

[I think that answers question one but](https://youtu.be/tRxsBGWxowA?t=00h20m29s)

[let me know if I've misunderstood](https://youtu.be/tRxsBGWxowA?t=00h20m31s)

[something uh so question two on the](https://youtu.be/tRxsBGWxowA?t=00h20m33s)

[observable collection](https://youtu.be/tRxsBGWxowA?t=00h20m36s)

[so let's go here so there is](https://youtu.be/tRxsBGWxowA?t=00h20m38s)

[so you've got something uh about like](https://youtu.be/tRxsBGWxowA?t=00h20m41s)

[this public](https://youtu.be/tRxsBGWxowA?t=00h20m44s)

[uh observable collection right and we're](https://youtu.be/tRxsBGWxowA?t=00h20m45s)

[gonna just do an observable collection](https://youtu.be/tRxsBGWxowA?t=00h20m49s)

[of ins uh numbers okay](https://youtu.be/tRxsBGWxowA?t=00h20m50s)

[so you've got you've got something like](https://youtu.be/tRxsBGWxowA?t=00h20m56s)

[this](https://youtu.be/tRxsBGWxowA?t=00h20m58s)

[or thereabouts uh and the idea being](https://youtu.be/tRxsBGWxowA?t=00h20m59s)

[that you want to make a bunch of](https://youtu.be/tRxsBGWxowA?t=00h21m02s)

[mutations to this collection uh your](https://youtu.be/tRxsBGWxowA?t=00h21m04s)

[sample there it's during a sort](https://youtu.be/tRxsBGWxowA?t=00h21m07s)

[somewhere where you're going to be](https://youtu.be/tRxsBGWxowA?t=00h21m10s)

[adding removing a bunch of things](https://youtu.be/tRxsBGWxowA?t=00h21m11s)

[so](https://youtu.be/tRxsBGWxowA?t=00h21m13s)

[um typically as you make changes to the](https://youtu.be/tRxsBGWxowA?t=00h21m15s)

[collection it raises the I notify](https://youtu.be/tRxsBGWxowA?t=00h21m17s)

[collection change so if we look at the](https://youtu.be/tRxsBGWxowA?t=00h21m19s)

[numbers collection on here uh we will](https://youtu.be/tRxsBGWxowA?t=00h21m21s)

[note there is an event called collection](https://youtu.be/tRxsBGWxowA?t=00h21m24s)

[changed and this is what typically is](https://youtu.be/tRxsBGWxowA?t=00h21m26s)

[going to get raised all over the place](https://youtu.be/tRxsBGWxowA?t=00h21m28s)

[now uh the observable collection itself](https://youtu.be/tRxsBGWxowA?t=00h21m30s)

[doesn't give you a](https://youtu.be/tRxsBGWxowA?t=00h21m34s)

[lean way of doing this but uh public](https://youtu.be/tRxsBGWxowA?t=00h21m36s)

[class](https://youtu.be/tRxsBGWxowA?t=00h21m40s)

[my observable collection](https://youtu.be/tRxsBGWxowA?t=00h21m43s)

[we can do this and we can go observable](https://youtu.be/tRxsBGWxowA?t=00h21m46s)

[collection of t](https://youtu.be/tRxsBGWxowA?t=00h21m49s)

[there are](https://youtu.be/tRxsBGWxowA?t=00h21m51s)

[um some nice handy](https://youtu.be/tRxsBGWxowA?t=00h21m54s)

[um](https://youtu.be/tRxsBGWxowA?t=00h22m01s)

[methods that you can override on here as](https://youtu.be/tRxsBGWxowA?t=00h22m02s)

[well so for example on collection change](https://youtu.be/tRxsBGWxowA?t=00h22m04s)

[and what we can do is we can say uh](https://youtu.be/tRxsBGWxowA?t=00h22m06s)

[public pool](https://youtu.be/tRxsBGWxowA?t=00h22m11s)

[uh what's a cleaner way of doing this](https://youtu.be/tRxsBGWxowA?t=00h22m13s)

[um let's do this let's we'll actually do](https://youtu.be/tRxsBGWxowA?t=00h22m16s)

[a full implementation I I was going to](https://youtu.be/tRxsBGWxowA?t=00h22m18s)

[just do a short one but you know what](https://youtu.be/tRxsBGWxowA?t=00h22m20s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h22m22s)

[batch changes](https://youtu.be/tRxsBGWxowA?t=00h22m24s)

[uh probably](https://youtu.be/tRxsBGWxowA?t=00h22m28s)

[yeah we'll we'll call it that for now so](https://youtu.be/tRxsBGWxowA?t=00h22m31s)

[we're we're gonna I'm gonna actually](https://youtu.be/tRxsBGWxowA?t=00h22m33s)

[implement this whole thing because I](https://youtu.be/tRxsBGWxowA?t=00h22m34s)

[I've done this on a number of uh](https://youtu.be/tRxsBGWxowA?t=00h22m35s)

[projects myself I can't think of one](https://youtu.be/tRxsBGWxowA?t=00h22m37s)

[that's open source at the moment where I](https://youtu.be/tRxsBGWxowA?t=00h22m40s)

[can share the code so I'm just going to](https://youtu.be/tRxsBGWxowA?t=00h22m41s)

[write it here and away we go](https://youtu.be/tRxsBGWxowA?t=00h22m43s)

[um](https://youtu.be/tRxsBGWxowA?t=00h22m47s)

[so we're gonna do something like private](https://youtu.be/tRxsBGWxowA?t=00h22m48s)

[pool uh](https://youtu.be/tRxsBGWxowA?t=00h22m51s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h22m55s)

[hope there was something built in so](https://youtu.be/tRxsBGWxowA?t=00h22m56s)

[about observability I've implemented my](https://youtu.be/tRxsBGWxowA?t=00h22m58s)

[own mechanism I hope there was something](https://youtu.be/tRxsBGWxowA?t=00h22m59s)

[built in there so there's not really](https://youtu.be/tRxsBGWxowA?t=00h23m00s)

[something built in and maybe I'll talk](https://youtu.be/tRxsBGWxowA?t=00h23m03s)

[through this before I get too carried](https://youtu.be/tRxsBGWxowA?t=00h23m05s)

[away](https://youtu.be/tRxsBGWxowA?t=00h23m06s)

[um effectively what you end up doing if](https://youtu.be/tRxsBGWxowA?t=00h23m07s)

[you want to have that batch behavior for](https://youtu.be/tRxsBGWxowA?t=00h23m09s)

[your observable collection is deriving](https://youtu.be/tRxsBGWxowA?t=00h23m11s)

[from observable collection and guilt](https://youtu.be/tRxsBGWxowA?t=00h23m14s)

[giving yourself some control over this](https://youtu.be/tRxsBGWxowA?t=00h23m16s)

[on collection change because by default](https://youtu.be/tRxsBGWxowA?t=00h23m18s)

[it's just gonna fire repeatedly the one](https://youtu.be/tRxsBGWxowA?t=00h23m20s)

[thing you do have to make sure that you](https://youtu.be/tRxsBGWxowA?t=00h23m23s)

[do is when you are done batching you do](https://youtu.be/tRxsBGWxowA?t=00h23m25s)

[need to raise collection changed](https://youtu.be/tRxsBGWxowA?t=00h23m28s)

[um so for example](https://youtu.be/tRxsBGWxowA?t=00h23m31s)

[public uh avoid done batching right uh](https://youtu.be/tRxsBGWxowA?t=00h23m34s)

[uh on collection change new](https://youtu.be/tRxsBGWxowA?t=00h23m41s)

[um and then this guy here you want to](https://youtu.be/tRxsBGWxowA?t=00h23m45s)

[end up sending a reset for the e-new](https://youtu.be/tRxsBGWxowA?t=00h23m47s)

[value](https://youtu.be/tRxsBGWxowA?t=00h23m49s)

[which you'll end up telling the UI for](https://youtu.be/tRxsBGWxowA?t=00h23m50s)

[like a list box or similar hey](https://youtu.be/tRxsBGWxowA?t=00h23m53s)

[something big has happened to this list](https://youtu.be/tRxsBGWxowA?t=00h23m55s)

[box forget what you thought you knew](https://youtu.be/tRxsBGWxowA?t=00h23m57s)

[just do it because some uh things will](https://youtu.be/tRxsBGWxowA?t=00h23m59s)

[watch that collection change for like](https://youtu.be/tRxsBGWxowA?t=00h24m03s)

[moves and it'll just move the item](https://youtu.be/tRxsBGWxowA?t=00h24m04s)

[around which is really convenient and](https://youtu.be/tRxsBGWxowA?t=00h24m06s)

[very efficient if it knows that oh only](https://youtu.be/tRxsBGWxowA?t=00h24m09s)

[one item moved around that's great](https://youtu.be/tRxsBGWxowA?t=00h24m11s)

[um](https://youtu.be/tRxsBGWxowA?t=00h24m14s)

[sometimes this is what you want](https://youtu.be/tRxsBGWxowA?t=00h24m15s)

[the reason I suspect something's not](https://youtu.be/tRxsBGWxowA?t=00h24m18s)

[built in aside from they just didn't do](https://youtu.be/tRxsBGWxowA?t=00h24m20s)

[it is](https://youtu.be/tRxsBGWxowA?t=00h24m23s)

[depending on use case it can be](https://youtu.be/tRxsBGWxowA?t=00h24m26s)

[convenient to have your collection](https://youtu.be/tRxsBGWxowA?t=00h24m28s)

[actually raise those collection changes](https://youtu.be/tRxsBGWxowA?t=00h24m31s)

[now it depends on what changes are](https://youtu.be/tRxsBGWxowA?t=00h24m33s)

[happening right like I I think of one](https://youtu.be/tRxsBGWxowA?t=00h24m36s)

[where there's like a potentially like a](https://youtu.be/tRxsBGWxowA?t=00h24m38s)

[stock clicker or an animatable graph is](https://youtu.be/tRxsBGWxowA?t=00h24m41s)

[I might actually want to see those](https://youtu.be/tRxsBGWxowA?t=00h24m43s)

[changes come in and let my control](https://youtu.be/tRxsBGWxowA?t=00h24m44s)

[animate rather than it throwing away all](https://youtu.be/tRxsBGWxowA?t=00h24m47s)

[the data and effectively repainting](https://youtu.be/tRxsBGWxowA?t=00h24m49s)

[itself every time](https://youtu.be/tRxsBGWxowA?t=00h24m51s)

[so but in terms of the observable](https://youtu.be/tRxsBGWxowA?t=00h24m52s)

[collection there's](https://youtu.be/tRxsBGWxowA?t=00h24m55s)

[um I think deriving from observable](https://youtu.be/tRxsBGWxowA?t=00h24m57s)

[collection is probably the cleanest](https://youtu.be/tRxsBGWxowA?t=00h24m59s)

[approach](https://youtu.be/tRxsBGWxowA?t=00h25m01s)

[um](https://youtu.be/tRxsBGWxowA?t=00h25m03s)

[oh yes yes yes thank you thank you thank](https://youtu.be/tRxsBGWxowA?t=00h25m04s)

[you the the token from observable so](https://youtu.be/tRxsBGWxowA?t=00h25m07s)

[that was](https://youtu.be/tRxsBGWxowA?t=00h25m09s)

[uh messenger create observable uh that's](https://youtu.be/tRxsBGWxowA?t=00h25m11s)

[right](https://youtu.be/tRxsBGWxowA?t=00h25m15s)

[because this guy comes through and uh](https://youtu.be/tRxsBGWxowA?t=00h25m16s)

[that's right it was the stuff did I](https://youtu.be/tRxsBGWxowA?t=00h25m20s)

[leave fluent](https://youtu.be/tRxsBGWxowA?t=00h25m22s)

[dude I can't remember if I left fluent](https://youtu.be/tRxsBGWxowA?t=00h25m24s)

[installed on this or not](https://youtu.be/tRxsBGWxowA?t=00h25m27s)

[because this is the I Observer pattern](https://youtu.be/tRxsBGWxowA?t=00h25m31s)

[did not leave it here](https://youtu.be/tRxsBGWxowA?t=00h25m35s)

[um](https://youtu.be/tRxsBGWxowA?t=00h25m37s)

[but the](https://youtu.be/tRxsBGWxowA?t=00h25m39s)

[regardless of which way it goes about](https://youtu.be/tRxsBGWxowA?t=00h25m43s)

[doing it at the end of the day if you](https://youtu.be/tRxsBGWxowA?t=00h25m44s)

[register and do the Observer pattern for](https://youtu.be/tRxsBGWxowA?t=00h25m46s)

[the subscription or your messages you](https://youtu.be/tRxsBGWxowA?t=00h25m50s)

[end up with something like object token](https://youtu.be/tRxsBGWxowA?t=00h25m52s)

[gets dot right](https://youtu.be/tRxsBGWxowA?t=00h25m55s)

[for now we'll just](https://youtu.be/tRxsBGWxowA?t=00h26m00s)

[do that until it's shut up](https://youtu.be/tRxsBGWxowA?t=00h26m01s)

[um](https://youtu.be/tRxsBGWxowA?t=00h26m03s)

[and the way I would end up cleaning it](https://youtu.be/tRxsBGWxowA?t=00h26m05s)

[up is and again this is going to be](https://youtu.be/tRxsBGWxowA?t=00h26m07s)

[really dependent upon where in the app](https://youtu.be/tRxsBGWxowA?t=00h26m09s)

[it is but in general the the way I I](https://youtu.be/tRxsBGWxowA?t=00h26m11s)

[typically go about doing it is having](https://youtu.be/tRxsBGWxowA?t=00h26m14s)

[the uh view typically on the unloaded](https://youtu.be/tRxsBGWxowA?t=00h26m16s)

[event](https://youtu.be/tRxsBGWxowA?t=00h26m20s)

[um call into my view model](https://youtu.be/tRxsBGWxowA?t=00h26m21s)

[via going through the data context](https://youtu.be/tRxsBGWxowA?t=00h26m23s)

[either typecasting to eye disposable or](https://youtu.be/tRxsBGWxowA?t=00h26m25s)

[it's actually perfectly valid](https://youtu.be/tRxsBGWxowA?t=00h26m29s)

[um uh this is in a user control so](https://youtu.be/tRxsBGWxowA?t=00h26m32s)

[in the mvvm space it is okay for your](https://youtu.be/tRxsBGWxowA?t=00h26m36s)

[view to know about your view model it](https://youtu.be/tRxsBGWxowA?t=00h26m40s)

[kind of has to](https://youtu.be/tRxsBGWxowA?t=00h26m43s)

[um oh thank you for the compliment I](https://youtu.be/tRxsBGWxowA?t=00h26m44s)

[appreciate it so](https://youtu.be/tRxsBGWxowA?t=00h26m46s)

[hard casting your data context to a](https://youtu.be/tRxsBGWxowA?t=00h26m48s)

[particular](https://youtu.be/tRxsBGWxowA?t=00h26m51s)

[um view model type is perfectly valid in](https://youtu.be/tRxsBGWxowA?t=00h26m53s)

[fact in your xaml I would highly](https://youtu.be/tRxsBGWxowA?t=00h26m55s)

[recommend and I think I do it here](https://youtu.be/tRxsBGWxowA?t=00h26m58s)

[that your xaml should be directly](https://youtu.be/tRxsBGWxowA?t=00h27m01s)

[setting Your Design time data context](https://youtu.be/tRxsBGWxowA?t=00h27m04s)

[so that](https://youtu.be/tRxsBGWxowA?t=00h27m07s)

[um the tooling can give you hints about](https://youtu.be/tRxsBGWxowA?t=00h27m09s)

[hey you've messed up this binding or hey](https://youtu.be/tRxsBGWxowA?t=00h27m11s)

[these when you type in binding actually](https://youtu.be/tRxsBGWxowA?t=00h27m14s)

[show me the properties on The View model](https://youtu.be/tRxsBGWxowA?t=00h27m16s)

[so it is very okay for your View Coach](https://youtu.be/tRxsBGWxowA?t=00h27m18s)

[to know about its view model](https://youtu.be/tRxsBGWxowA?t=00h27m21s)

[um the one thing I would be very](https://youtu.be/tRxsBGWxowA?t=00h27m24s)

[cautious of and this is part of why I](https://youtu.be/tRxsBGWxowA?t=00h27m25s)

[typically go through the eye disposable](https://youtu.be/tRxsBGWxowA?t=00h27m27s)

[interface for doing the unregister](https://youtu.be/tRxsBGWxowA?t=00h27m29s)

[um so for example I could come into my](https://youtu.be/tRxsBGWxowA?t=00h27m32s)

[my main window right and I could do](https://youtu.be/tRxsBGWxowA?t=00h27m35s)

[something like you know](https://youtu.be/tRxsBGWxowA?t=00h27m37s)

[uh close is probably where I would do it](https://youtu.be/tRxsBGWxowA?t=00h27m39s)

[in a window](https://youtu.be/tRxsBGWxowA?t=00h27m42s)

[unloaded any user control closed in a](https://youtu.be/tRxsBGWxowA?t=00h27m43s)

[window uh but we could do something like](https://youtu.be/tRxsBGWxowA?t=00h27m45s)

[uh main window view model](https://youtu.be/tRxsBGWxowA?t=00h27m48s)

[data context](https://youtu.be/tRxsBGWxowA?t=00h27m52s)

[um and then I've I see people do this a](https://youtu.be/tRxsBGWxowA?t=00h27m57s)

[lot uh](https://youtu.be/tRxsBGWxowA?t=00h28m00s)

[they do something like this and and they](https://youtu.be/tRxsBGWxowA?t=00h28m02s)

[they write a method that looks like this](https://youtu.be/tRxsBGWxowA?t=00h28m05s)

[and in general the pattern I don't have](https://youtu.be/tRxsBGWxowA?t=00h28m07s)

[an issue with](https://youtu.be/tRxsBGWxowA?t=00h28m10s)

[naming is hard like there's a a running](https://youtu.be/tRxsBGWxowA?t=00h28m13s)

[joke in computer science that there's](https://youtu.be/tRxsBGWxowA?t=00h28m15s)

[only two really hard things that we that](https://youtu.be/tRxsBGWxowA?t=00h28m17s)

[we really struggle with](https://youtu.be/tRxsBGWxowA?t=00h28m19s)

[um uh let's see what is it uh cash](https://youtu.be/tRxsBGWxowA?t=00h28m21s)

[invalidation naming things and off by](https://youtu.be/tRxsBGWxowA?t=00h28m25s)

[one errors those are the two things that](https://youtu.be/tRxsBGWxowA?t=00h28m27s)

[are very difficult](https://youtu.be/tRxsBGWxowA?t=00h28m29s)

[um and specifically around the naming](https://youtu.be/tRxsBGWxowA?t=00h28m31s)

[things the reason I like to go through](https://youtu.be/tRxsBGWxowA?t=00h28m32s)

[the eye disposable interface is it hides](https://youtu.be/tRxsBGWxowA?t=00h28m35s)

[away from The View model the exact cases](https://youtu.be/tRxsBGWxowA?t=00h28m37s)

[under which it should consider itself](https://youtu.be/tRxsBGWxowA?t=00h28m40s)

[disposed](https://youtu.be/tRxsBGWxowA?t=00h28m41s)

[right it leaves that up to the view](https://youtu.be/tRxsBGWxowA?t=00h28m43s)

[which typically The View will have](https://youtu.be/tRxsBGWxowA?t=00h28m46s)

[knowledge about the application lifetime](https://youtu.be/tRxsBGWxowA?t=00h28m47s)

[right if I'm a window and I'm being](https://youtu.be/tRxsBGWxowA?t=00h28m51s)

[closed I know something about my](https://youtu.be/tRxsBGWxowA?t=00h28m52s)

[lifetime I'm being closed I'm shutting](https://youtu.be/tRxsBGWxowA?t=00h28m54s)

[down I should tell my view model hey](https://youtu.be/tRxsBGWxowA?t=00h28m56s)

[clean up anything that you had we're all](https://youtu.be/tRxsBGWxowA?t=00h28m58s)

[done right so the The View then](https://youtu.be/tRxsBGWxowA?t=00h29m01s)

[communicates that information back down](https://youtu.be/tRxsBGWxowA?t=00h29m04s)

[if I'm a user control and I'm being](https://youtu.be/tRxsBGWxowA?t=00h29m05s)

[unloaded effectively being taken out of](https://youtu.be/tRxsBGWxowA?t=00h29m07s)

[the visual tree](https://youtu.be/tRxsBGWxowA?t=00h29m09s)

[I should tell my view model hey we're](https://youtu.be/tRxsBGWxowA?t=00h29m10s)

[all done I'm not actually like you could](https://youtu.be/tRxsBGWxowA?t=00h29m12s)

[tell me to do something but I'm not I've](https://youtu.be/tRxsBGWxowA?t=00h29m15s)

[been unloaded I'm Not Really Gonna](https://youtu.be/tRxsBGWxowA?t=00h29m17s)

[contribute anything you could probably](https://youtu.be/tRxsBGWxowA?t=00h29m19s)

[unregister the one thing I would do](https://youtu.be/tRxsBGWxowA?t=00h29m21s)

[though is make sure that this method](https://youtu.be/tRxsBGWxowA?t=00h29m24s)

[is not a leaky abstraction with its name](https://youtu.be/tRxsBGWxowA?t=00h29m26s)

[right so the fact that this thing has](https://youtu.be/tRxsBGWxowA?t=00h29m31s)

[the word window in it makes me Twitch](https://youtu.be/tRxsBGWxowA?t=00h29m33s)

[the fact that this thing has the word](https://youtu.be/tRxsBGWxowA?t=00h29m35s)

[closed in it which indicates something](https://youtu.be/tRxsBGWxowA?t=00h29m37s)

[about view State makes me Twitch](https://youtu.be/tRxsBGWxowA?t=00h29m39s)

[um now admittedly the class itself is](https://youtu.be/tRxsBGWxowA?t=00h29m43s)

[called main window view model so there's](https://youtu.be/tRxsBGWxowA?t=00h29m45s)

[a little bit of that going on there](https://youtu.be/tRxsBGWxowA?t=00h29m49s)

[um already but making sure that the name](https://youtu.be/tRxsBGWxowA?t=00h29m51s)

[is more reflective about what should be](https://youtu.be/tRxsBGWxowA?t=00h29m55s)

[done or about its state rather than](https://youtu.be/tRxsBGWxowA?t=00h29m57s)

[about who's calling it I I realize](https://youtu.be/tRxsBGWxowA?t=00h30m00s)

[that's a very subtle thing and I would](https://youtu.be/tRxsBGWxowA?t=00h30m03s)

[have no problem with if this was called](https://youtu.be/tRxsBGWxowA?t=00h30m04s)

[you know cleanup](https://youtu.be/tRxsBGWxowA?t=00h30m06s)

[right totally fine with that](https://youtu.be/tRxsBGWxowA?t=00h30m08s)

[um](https://youtu.be/tRxsBGWxowA?t=00h30m13s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h30m13s)

[uh let's see if unloaded is called when](https://youtu.be/tRxsBGWxowA?t=00h30m16s)

[you remove from the visual tree what](https://youtu.be/tRxsBGWxowA?t=00h30m19s)

[happens when you remove a control from a](https://youtu.be/tRxsBGWxowA?t=00h30m21s)

[grid and put it in another grid for](https://youtu.be/tRxsBGWxowA?t=00h30m22s)

[example that is a wonderful question all](https://youtu.be/tRxsBGWxowA?t=00h30m24s)

[right so](https://youtu.be/tRxsBGWxowA?t=00h30m27s)

[I'm doing this for memory but we'll go](https://youtu.be/tRxsBGWxowA?t=00h30m29s)

[test it](https://youtu.be/tRxsBGWxowA?t=00h30m30s)

[but I'm going to say my prediction first](https://youtu.be/tRxsBGWxowA?t=00h30m32s)

[so I can claim I was right if I am right](https://youtu.be/tRxsBGWxowA?t=00h30m33s)

[um I believe what we will see is the](https://youtu.be/tRxsBGWxowA?t=00h30m36s)

[loaded event will fire when it's added](https://youtu.be/tRxsBGWxowA?t=00h30m38s)

[to grid one the unloaded event will fire](https://youtu.be/tRxsBGWxowA?t=00h30m39s)

[when it is removed from that grid and](https://youtu.be/tRxsBGWxowA?t=00h30m42s)

[the loaded event will fire again when it](https://youtu.be/tRxsBGWxowA?t=00h30m45s)

[is added to grid 2. but let's](https://youtu.be/tRxsBGWxowA?t=00h30m47s)

[let's actually confirm that because](https://youtu.be/tRxsBGWxowA?t=00h30m50s)

[there's no reason not to](https://youtu.be/tRxsBGWxowA?t=00h30m55s)

[do](https://youtu.be/tRxsBGWxowA?t=00h30m57s)

[and then we're going to go here](https://youtu.be/tRxsBGWxowA?t=00h30m59s)

[and say uh actually let's do this I'm](https://youtu.be/tRxsBGWxowA?t=00h31m02s)

[going to do two grids in here](https://youtu.be/tRxsBGWxowA?t=00h31m05s)

[grid X name](https://youtu.be/tRxsBGWxowA?t=00h31m07s)

[period one](https://youtu.be/tRxsBGWxowA?t=00h31m11s)

[hmm](https://youtu.be/tRxsBGWxowA?t=00h31m13s)

[grid X name](https://youtu.be/tRxsBGWxowA?t=00h31m15s)

[uh grid 2.](https://youtu.be/tRxsBGWxowA?t=00h31m18s)

[and then we're going to go with](https://youtu.be/tRxsBGWxowA?t=00h31m21s)

[button uh content move me](https://youtu.be/tRxsBGWxowA?t=00h31m24s)

[X name button](https://youtu.be/tRxsBGWxowA?t=00h31m28s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h31m32s)

[uh let's see what is there a risk to](https://youtu.be/tRxsBGWxowA?t=00h31m33s)

[dispose The View model when a reality](https://youtu.be/tRxsBGWxowA?t=00h31m35s)

[should be remained active uh absolutely](https://youtu.be/tRxsBGWxowA?t=00h31m37s)

[absolutely](https://youtu.be/tRxsBGWxowA?t=00h31m40s)

[um and this is why](https://youtu.be/tRxsBGWxowA?t=00h31m42s)

[I would put so if you are just moving a](https://youtu.be/tRxsBGWxowA?t=00h31m44s)

[control from point A to point B and the](https://youtu.be/tRxsBGWxowA?t=00h31m47s)

[most common case where that happens is](https://youtu.be/tRxsBGWxowA?t=00h31m49s)

[um when you have like a list box that's](https://youtu.be/tRxsBGWxowA?t=00h31m53s)

[virtualizing because by default if you](https://youtu.be/tRxsBGWxowA?t=00h31m55s)

[bind a collection to a list box](https://youtu.be/tRxsBGWxowA?t=00h31m58s)

[um it doesn't generate list box items](https://youtu.be/tRxsBGWxowA?t=00h32m00s)

[for every item in your observable](https://youtu.be/tRxsBGWxowA?t=00h32m03s)

[collection right you might have 10 000](https://youtu.be/tRxsBGWxowA?t=00h32m05s)

[items in your observable collection but](https://youtu.be/tRxsBGWxowA?t=00h32m06s)

[if your list box can only see eight it](https://youtu.be/tRxsBGWxowA?t=00h32m08s)

[doesn't need ten thousand list box items](https://youtu.be/tRxsBGWxowA?t=00h32m11s)

[that would slow your view down immensely](https://youtu.be/tRxsBGWxowA?t=00h32m13s)

[so by default virtualization is turned](https://youtu.be/tRxsBGWxowA?t=00h32m15s)

[on for](https://youtu.be/tRxsBGWxowA?t=00h32m17s)

[five six of the default controls](https://youtu.be/tRxsBGWxowA?t=00h32m18s)

[don't quiz me on them](https://youtu.be/tRxsBGWxowA?t=00h32m21s)

[um and so it'll only generate items for](https://youtu.be/tRxsBGWxowA?t=00h32m23s)

[each of the individual ones I don't](https://youtu.be/tRxsBGWxowA?t=00h32m26s)

[think](https://youtu.be/tRxsBGWxowA?t=00h32m28s)

[I don't think you get](https://youtu.be/tRxsBGWxowA?t=00h32m33s)

[uh don't worry about it](https://youtu.be/tRxsBGWxowA?t=00h32m36s)

[um](https://youtu.be/tRxsBGWxowA?t=00h32m38s)

[uh I do not mind bad typing I I don't](https://youtu.be/tRxsBGWxowA?t=00h32m39s)

[think you actually get unloaded events](https://youtu.be/tRxsBGWxowA?t=00h32m43s)

[on the list box items or the the list](https://youtu.be/tRxsBGWxowA?t=00h32m45s)

[box template items](https://youtu.be/tRxsBGWxowA?t=00h32m47s)

[when they move](https://youtu.be/tRxsBGWxowA?t=00h32m50s)

[I could be wrong there I could be wrong](https://youtu.be/tRxsBGWxowA?t=00h32m52s)

[and this is why I like to let the view](https://youtu.be/tRxsBGWxowA?t=00h32m55s)

[objects Drive The View models because](https://youtu.be/tRxsBGWxowA?t=00h32m58s)

[context matters right we can move this](https://youtu.be/tRxsBGWxowA?t=00h33m01s)

[button from grid one to grid two](https://youtu.be/tRxsBGWxowA?t=00h33m04s)

[um and look at the events that fire](https://youtu.be/tRxsBGWxowA?t=00h33m08s)

[um and](https://youtu.be/tRxsBGWxowA?t=00h33m12s)

[but in a lot of cases it's fairly rare](https://youtu.be/tRxsBGWxowA?t=00h33m14s)

[that you move a user control from point](https://youtu.be/tRxsBGWxowA?t=00h33m17s)

[A to point B oftentimes when a control](https://youtu.be/tRxsBGWxowA?t=00h33m19s)

[gets unloaded you don't take that same](https://youtu.be/tRxsBGWxowA?t=00h33m21s)

[control instance and put it back in the](https://youtu.be/tRxsBGWxowA?t=00h33m24s)

[view somewhere else oftentimes what's](https://youtu.be/tRxsBGWxowA?t=00h33m26s)

[happening is](https://youtu.be/tRxsBGWxowA?t=00h33m28s)

[um](https://youtu.be/tRxsBGWxowA?t=00h33m31s)

[uh when the control disappears appears](https://youtu.be/tRxsBGWxowA?t=00h33m32s)

[again oh thank you Justin Bieber](https://youtu.be/tRxsBGWxowA?t=00h33m35s)

[yeah and so with the with the list box](https://youtu.be/tRxsBGWxowA?t=00h33m38s)

[item and the scrolling thank you I I](https://youtu.be/tRxsBGWxowA?t=00h33m40s)

[appreciate that](https://youtu.be/tRxsBGWxowA?t=00h33m42s)

[um](https://youtu.be/tRxsBGWxowA?t=00h33m44s)

[but most of the time when the views are](https://youtu.be/tRxsBGWxowA?t=00h33m45s)

[unloaded it's because like a view has](https://youtu.be/tRxsBGWxowA?t=00h33m47s)

[gone away and doesn't need to come back](https://youtu.be/tRxsBGWxowA?t=00h33m50s)

[so if you are leveraging the unloaded](https://youtu.be/tRxsBGWxowA?t=00h33m52s)

[I would tell you to also pay attention](https://youtu.be/tRxsBGWxowA?t=00h33m55s)

[to loaded as well](https://youtu.be/tRxsBGWxowA?t=00h33m57s)

[right](https://youtu.be/tRxsBGWxowA?t=00h33m58s)

[um but again context matters I would](https://youtu.be/tRxsBGWxowA?t=00h34m00s)

[potentially do something different for](https://youtu.be/tRxsBGWxowA?t=00h34m03s)

[this user control if I was inside of a](https://youtu.be/tRxsBGWxowA?t=00h34m05s)

[it or if this user control was intended](https://youtu.be/tRxsBGWxowA?t=00h34m08s)

[to be used inside of a list box versus](https://youtu.be/tRxsBGWxowA?t=00h34m11s)

[if this is just a control that I'm](https://youtu.be/tRxsBGWxowA?t=00h34m13s)

[slapping up on a details pane somewhere](https://youtu.be/tRxsBGWxowA?t=00h34m15s)

[right because oftentimes when controls](https://youtu.be/tRxsBGWxowA?t=00h34m17s)

[get unloaded they're often going away](https://youtu.be/tRxsBGWxowA?t=00h34m20s)

[they are it's not necessarily that same](https://youtu.be/tRxsBGWxowA?t=00h34m23s)

[instance that's going to come back in at](https://youtu.be/tRxsBGWxowA?t=00h34m25s)

[least not](https://youtu.be/tRxsBGWxowA?t=00h34m28s)

[typically in code because oftentimes the](https://youtu.be/tRxsBGWxowA?t=00h34m29s)

[the reason controls are getting](https://youtu.be/tRxsBGWxowA?t=00h34m32s)

[instantiated is either because you wrote](https://youtu.be/tRxsBGWxowA?t=00h34m34s)

[something in your xaml like you know](https://youtu.be/tRxsBGWxowA?t=00h34m37s)

[text block button that caused the](https://youtu.be/tRxsBGWxowA?t=00h34m40s)

[control to get instantiated](https://youtu.be/tRxsBGWxowA?t=00h34m42s)

[um or it's part of a data template](https://youtu.be/tRxsBGWxowA?t=00h34m45s)

[and so outside of that virtualization](https://youtu.be/tRxsBGWxowA?t=00h34m47s)

[case](https://youtu.be/tRxsBGWxowA?t=00h34m49s)

[I](https://youtu.be/tRxsBGWxowA?t=00h34m50s)

[I don't know if I would care too much](https://youtu.be/tRxsBGWxowA?t=00h34m51s)

[about it I I'm trying to think of cases](https://youtu.be/tRxsBGWxowA?t=00h34m54s)

[that I've run into where I've needed to](https://youtu.be/tRxsBGWxowA?t=00h34m58s)

[have](https://youtu.be/tRxsBGWxowA?t=00h35m00s)

[a dispose on something that was inside](https://youtu.be/tRxsBGWxowA?t=00h35m01s)

[of a collection](https://youtu.be/tRxsBGWxowA?t=00h35m04s)

[or or some sort of notification from](https://youtu.be/tRxsBGWxowA?t=00h35m07s)

[items inside of a collection typically I](https://youtu.be/tRxsBGWxowA?t=00h35m09s)

[haven't had them inside of The View](https://youtu.be/tRxsBGWxowA?t=00h35m11s)

[okay so so the one use case I can think](https://youtu.be/tRxsBGWxowA?t=00h35m18s)

[of](https://youtu.be/tRxsBGWxowA?t=00h35m21s)

[um I had a large collection of objects](https://youtu.be/tRxsBGWxowA?t=00h35m22s)

[they were in an observable collection](https://youtu.be/tRxsBGWxowA?t=00h35m24s)

[and they were being bound to a list view](https://youtu.be/tRxsBGWxowA?t=00h35m26s)

[um and there was a view event I'm trying](https://youtu.be/tRxsBGWxowA?t=00h35m29s)

[to remember what it was there was an](https://youtu.be/tRxsBGWxowA?t=00h35m32s)

[event being fired from one of the view](https://youtu.be/tRxsBGWxowA?t=00h35m34s)

[objects that I wanted to send a message](https://youtu.be/tRxsBGWxowA?t=00h35m36s)

[out on with the iMessenger](https://youtu.be/tRxsBGWxowA?t=00h35m39s)

[um what I ended up doing is I had the](https://youtu.be/tRxsBGWxowA?t=00h35m42s)

[view just blindly call into my view](https://youtu.be/tRxsBGWxowA?t=00h35m44s)

[model that was backing it](https://youtu.be/tRxsBGWxowA?t=00h35m47s)

[and letting the view model use the](https://youtu.be/tRxsBGWxowA?t=00h35m49s)

[messenger to send the message what that](https://youtu.be/tRxsBGWxowA?t=00h35m51s)

[subtly did was then move the](https://youtu.be/tRxsBGWxowA?t=00h35m54s)

[responsibility of cleaning up](https://youtu.be/tRxsBGWxowA?t=00h35m56s)

[um any of the registration stuff from](https://youtu.be/tRxsBGWxowA?t=00h35m59s)

[The View into the view model](https://youtu.be/tRxsBGWxowA?t=00h36m01s)

[because the view model was being](https://youtu.be/tRxsBGWxowA?t=00h36m04s)

[maintained in my observable collection](https://youtu.be/tRxsBGWxowA?t=00h36m05s)

[and I didn't then care how many](https://youtu.be/tRxsBGWxowA?t=00h36m08s)

[instances of the view there were right](https://youtu.be/tRxsBGWxowA?t=00h36m10s)

[the view may have effectively just](https://youtu.be/tRxsBGWxowA?t=00h36m12s)

[called the method on my view model to](https://youtu.be/tRxsBGWxowA?t=00h36m15s)

[say hey do the thing](https://youtu.be/tRxsBGWxowA?t=00h36m17s)

[but I did I pushed the responsibility](https://youtu.be/tRxsBGWxowA?t=00h36m19s)

[down into the view model which then also](https://youtu.be/tRxsBGWxowA?t=00h36m22s)

[let me test it but it then took it took](https://youtu.be/tRxsBGWxowA?t=00h36m24s)

[some of that headache away about trying](https://youtu.be/tRxsBGWxowA?t=00h36m27s)

[to think about well is this control](https://youtu.be/tRxsBGWxowA?t=00h36m28s)

[being unloaded because it's going away](https://youtu.be/tRxsBGWxowA?t=00h36m30s)

[or dead and so moving that](https://youtu.be/tRxsBGWxowA?t=00h36m32s)

[responsibility](https://youtu.be/tRxsBGWxowA?t=00h36m35s)

[um out of the view code into the view](https://youtu.be/tRxsBGWxowA?t=00h36m37s)

[model](https://youtu.be/tRxsBGWxowA?t=00h36m39s)

[can certainly help and again the one](https://youtu.be/tRxsBGWxowA?t=00h36m40s)

[thing I I want to make sure people](https://youtu.be/tRxsBGWxowA?t=00h36m42s)

[understand is that it is okay to use the](https://youtu.be/tRxsBGWxowA?t=00h36m44s)

[code behind](https://youtu.be/tRxsBGWxowA?t=00h36m47s)

[some people will hate me for saying that](https://youtu.be/tRxsBGWxowA?t=00h36m49s)

[they're like go behind bed bindings view](https://youtu.be/tRxsBGWxowA?t=00h36m50s)

[models yeah code behind is very](https://youtu.be/tRxsBGWxowA?t=00h36m53s)

[acceptable if you're doing something](https://youtu.be/tRxsBGWxowA?t=00h36m56s)

[that's related to your view like the](https://youtu.be/tRxsBGWxowA?t=00h36m58s)

[code behind is there it is the code](https://youtu.be/tRxsBGWxowA?t=00h37m00s)

[behind your view if you're doing view](https://youtu.be/tRxsBGWxowA?t=00h37m02s)

[stuff](https://youtu.be/tRxsBGWxowA?t=00h37m04s)

[have at it knock yourself out it's great](https://youtu.be/tRxsBGWxowA?t=00h37m06s)

[um and especially if it's hey I I need](https://youtu.be/tRxsBGWxowA?t=00h37m09s)

[to you know my view object](https://youtu.be/tRxsBGWxowA?t=00h37m12s)

[um has some events and I want to to push](https://youtu.be/tRxsBGWxowA?t=00h37m14s)

[them down I've been doing a lot of work](https://youtu.be/tRxsBGWxowA?t=00h37m17s)

[with esri's map control recently](https://youtu.be/tRxsBGWxowA?t=00h37m18s)

[um and there's there's cases where some](https://youtu.be/tRxsBGWxowA?t=00h37m20s)

[of the stuff that they have is surface](https://youtu.be/tRxsBGWxowA?t=00h37m23s)

[via events and not via](https://youtu.be/tRxsBGWxowA?t=00h37m24s)

[um](https://youtu.be/tRxsBGWxowA?t=00h37m28s)

[something that's easily bindable](https://youtu.be/tRxsBGWxowA?t=00h37m28s)

[okay great what we ended up doing is](https://youtu.be/tRxsBGWxowA?t=00h37m31s)

[writing some code in our um code behind](https://youtu.be/tRxsBGWxowA?t=00h37m34s)

[to smooth that over right the the esri](https://youtu.be/tRxsBGWxowA?t=00h37m36s)

[map control may do some asynchronous](https://youtu.be/tRxsBGWxowA?t=00h37m39s)

[stuff and notify us of some events and](https://youtu.be/tRxsBGWxowA?t=00h37m42s)

[then okay fine I'll watch for those](https://youtu.be/tRxsBGWxowA?t=00h37m44s)

[events in my code behind but rather than](https://youtu.be/tRxsBGWxowA?t=00h37m46s)

[doing much work there as soon as I can](https://youtu.be/tRxsBGWxowA?t=00h37m48s)

[get it out of](https://youtu.be/tRxsBGWxowA?t=00h37m50s)

[um anything that needs to talk to view](https://youtu.be/tRxsBGWxowA?t=00h37m52s)

[objects I push the code down into my](https://youtu.be/tRxsBGWxowA?t=00h37m55s)

[view model because one I can then test](https://youtu.be/tRxsBGWxowA?t=00h37m57s)

[it and then two it takes away that](https://youtu.be/tRxsBGWxowA?t=00h37m59s)

[responsibility](https://youtu.be/tRxsBGWxowA?t=00h38m02s)

[um](https://youtu.be/tRxsBGWxowA?t=00h38m04s)

[uh sorry I I missed this question so](https://youtu.be/tRxsBGWxowA?t=00h38m08s)

[let's see for example I move controls](https://youtu.be/tRxsBGWxowA?t=00h38m10s)

[from one grid to another when I make](https://youtu.be/tRxsBGWxowA?t=00h38m13s)

[floatable pad items where tab item](https://youtu.be/tRxsBGWxowA?t=00h38m15s)

[becomes a float window ah yes okay so if](https://youtu.be/tRxsBGWxowA?t=00h38m17s)

[you've got if you've got the browser](https://youtu.be/tRxsBGWxowA?t=00h38m20s)

[experience or even the the visual studio](https://youtu.be/tRxsBGWxowA?t=00h38m21s)

[experience right where you you drag the](https://youtu.be/tRxsBGWxowA?t=00h38m23s)

[tags you pull them out because this is](https://youtu.be/tRxsBGWxowA?t=00h38m25s)

[now](https://youtu.be/tRxsBGWxowA?t=00h38m27s)

[even though from a user perspective all](https://youtu.be/tRxsBGWxowA?t=00h38m29s)

[I've done is pull a tab out from a](https://youtu.be/tRxsBGWxowA?t=00h38m30s)

[developer perspective we understand that](https://youtu.be/tRxsBGWxowA?t=00h38m33s)

[okay hang on what you've actually done](https://youtu.be/tRxsBGWxowA?t=00h38m35s)

[is created a new window you've now taken](https://youtu.be/tRxsBGWxowA?t=00h38m37s)

[that that thing that was populated in](https://youtu.be/tRxsBGWxowA?t=00h38m40s)

[the tab before and you've made a a new](https://youtu.be/tRxsBGWxowA?t=00h38m42s)

[one](https://youtu.be/tRxsBGWxowA?t=00h38m43s)

[um so in those cases yes you would you](https://youtu.be/tRxsBGWxowA?t=00h38m44s)

[would](https://youtu.be/tRxsBGWxowA?t=00h38m47s)

[you would almost assuredly see both the](https://youtu.be/tRxsBGWxowA?t=00h38m49s)

[uh I guess it depends a little bit on](https://youtu.be/tRxsBGWxowA?t=00h38m51s)

[how you did it but you would probably](https://youtu.be/tRxsBGWxowA?t=00h38m53s)

[see unloaded and loaded](https://youtu.be/tRxsBGWxowA?t=00h38m54s)

[um triggering in both of those cases](https://youtu.be/tRxsBGWxowA?t=00h38m57s)

[I think for those I would probably still](https://youtu.be/tRxsBGWxowA?t=00h38m59s)

[suggest](https://youtu.be/tRxsBGWxowA?t=00h39m02s)

[pushing it into the view model](https://youtu.be/tRxsBGWxowA?t=00h39m04s)

[letting the view communicate to the view](https://youtu.be/tRxsBGWxowA?t=00h39m07s)

[model if there are relevant](https://youtu.be/tRxsBGWxowA?t=00h39m09s)

[application life cycle changes that it](https://youtu.be/tRxsBGWxowA?t=00h39m12s)

[needs to know about](https://youtu.be/tRxsBGWxowA?t=00h39m14s)

[and then letting the view model drive at](https://youtu.be/tRxsBGWxowA?t=00h39m16s)

[that point](https://youtu.be/tRxsBGWxowA?t=00h39m18s)

[I think that would as a general practice](https://youtu.be/tRxsBGWxowA?t=00h39m21s)

[and again context matters and and](https://youtu.be/tRxsBGWxowA?t=00h39m24s)

[there's I I can already think of](https://youtu.be/tRxsBGWxowA?t=00h39m26s)

[exception cases where I've done](https://youtu.be/tRxsBGWxowA?t=00h39m28s)

[otherwise](https://youtu.be/tRxsBGWxowA?t=00h39m30s)

[but they've all been specific to what](https://youtu.be/tRxsBGWxowA?t=00h39m31s)

[was needing to happen in that](https://youtu.be/tRxsBGWxowA?t=00h39m34s)

[application at that point](https://youtu.be/tRxsBGWxowA?t=00h39m35s)

[yeah](https://youtu.be/tRxsBGWxowA?t=00h39m44s)

[great questions I love the discussion uh](https://youtu.be/tRxsBGWxowA?t=00h39m45s)

[and love questions so thank you thank](https://youtu.be/tRxsBGWxowA?t=00h39m49s)

[you for dropping those in let me know if](https://youtu.be/tRxsBGWxowA?t=00h39m50s)

[I if I uh missed anything or didn't](https://youtu.be/tRxsBGWxowA?t=00h39m52s)

[cover it I'm scanning back through them](https://youtu.be/tRxsBGWxowA?t=00h39m56s)

[now I](https://youtu.be/tRxsBGWxowA?t=00h39m58s)

[I think I talked about all of them](https://youtu.be/tRxsBGWxowA?t=00h40m00s)

[I'm not sure if I answered all of them](https://youtu.be/tRxsBGWxowA?t=00h40m03s)

[yeah you could certainly use a flag to](https://youtu.be/tRxsBGWxowA?t=00h40m12s)

[do it if you know that you're in the](https://youtu.be/tRxsBGWxowA?t=00h40m15s)

[moving around state](https://youtu.be/tRxsBGWxowA?t=00h40m17s)

[as much as possible I think I would](https://youtu.be/tRxsBGWxowA?t=00h40m19s)

[suggest trying to avoid](https://youtu.be/tRxsBGWxowA?t=00h40m22s)

[needing Flags](https://youtu.be/tRxsBGWxowA?t=00h40m24s)

[but again there's there's so many](https://youtu.be/tRxsBGWxowA?t=00h40m29s)

[there's so many cases like](https://youtu.be/tRxsBGWxowA?t=00h40m31s)

[um people often worry about event](https://youtu.be/tRxsBGWxowA?t=00h40m34s)

[handlers so for example I registered up](https://youtu.be/tRxsBGWxowA?t=00h40m36s)

[this close event handler](https://youtu.be/tRxsBGWxowA?t=00h40m39s)

[um and event handlers are notorious for](https://youtu.be/tRxsBGWxowA?t=00h40m41s)

[causing memory leaks notorious](https://youtu.be/tRxsBGWxowA?t=00h40m43s)

[um and I think I've talked about this](https://youtu.be/tRxsBGWxowA?t=00h40m46s)

[before it's because this these two](https://youtu.be/tRxsBGWxowA?t=00h40m48s)

[characters](https://youtu.be/tRxsBGWxowA?t=00h40m50s)

[it's really easy especially in WPF to](https://youtu.be/tRxsBGWxowA?t=00h40m51s)

[accidentally link two things together](https://youtu.be/tRxsBGWxowA?t=00h40m54s)

[that you did not intend to link together](https://youtu.be/tRxsBGWxowA?t=00h40m56s)

[um because under the hood what you're](https://youtu.be/tRxsBGWxowA?t=00h40m59s)

[actually doing is creating a new uh what](https://youtu.be/tRxsBGWxowA?t=00h41m01s)

[is this event handler object this](https://youtu.be/tRxsBGWxowA?t=00h41m04s)

[looks like uh method name expect oh so](https://youtu.be/tRxsBGWxowA?t=00h41m11s)

[this actually looks like this so you're](https://youtu.be/tRxsBGWxowA?t=00h41m15s)

[actually instantiating an object and](https://youtu.be/tRxsBGWxowA?t=00h41m16s)

[there is](https://youtu.be/tRxsBGWxowA?t=00h41m19s)

[just to just to be clear we'll put the](https://youtu.be/tRxsBGWxowA?t=00h41m21s)

[this in there to make it really obvious](https://youtu.be/tRxsBGWxowA?t=00h41m23s)

[um](https://youtu.be/tRxsBGWxowA?t=00h41m26s)

[and this is one of those areas where](https://youtu.be/tRxsBGWxowA?t=00h41m27s)

[things always get really messy](https://youtu.be/tRxsBGWxowA?t=00h41m28s)

[especially if you start using events to](https://youtu.be/tRxsBGWxowA?t=00h41m30s)

[communicate between your views and your](https://youtu.be/tRxsBGWxowA?t=00h41m33s)

[view models](https://youtu.be/tRxsBGWxowA?t=00h41m35s)

[which is why with the iMessenger I like](https://youtu.be/tRxsBGWxowA?t=00h41m36s)

[using the weak reference one because it](https://youtu.be/tRxsBGWxowA?t=00h41m38s)

[Dodges this whole problem](https://youtu.be/tRxsBGWxowA?t=00h41m40s)

[because what ends up happening and in](https://youtu.be/tRxsBGWxowA?t=00h41m42s)

[this case there's no memory leak](https://youtu.be/tRxsBGWxowA?t=00h41m44s)

[there's no memory leak because this](https://youtu.be/tRxsBGWxowA?t=00h41m46s)

[event is on the same instance as the](https://youtu.be/tRxsBGWxowA?t=00h41m48s)

[event handler they're gonna die at this](https://youtu.be/tRxsBGWxowA?t=00h41m51s)

[it's the same object it's all going to](https://youtu.be/tRxsBGWxowA?t=00h41m52s)

[die as one group](https://youtu.be/tRxsBGWxowA?t=00h41m55s)

[right the problem comes is when they](https://youtu.be/tRxsBGWxowA?t=00h41m56s)

[aren't the same object and now you have](https://youtu.be/tRxsBGWxowA?t=00h41m59s)

[to start thinking about oh did I un](https://youtu.be/tRxsBGWxowA?t=00h42m01s)

[unregister that event properly because](https://youtu.be/tRxsBGWxowA?t=00h42m04s)

[unregistering an event is kind of the](https://youtu.be/tRxsBGWxowA?t=00h42m06s)

[same problem as needing to know when do](https://youtu.be/tRxsBGWxowA?t=00h42m08s)

[I get rid of my messenger token or when](https://youtu.be/tRxsBGWxowA?t=00h42m10s)

[do I call dispose](https://youtu.be/tRxsBGWxowA?t=00h42m12s)

[right if I register for an event I have](https://youtu.be/tRxsBGWxowA?t=00h42m14s)

[to think about okay those two things are](https://youtu.be/tRxsBGWxowA?t=00h42m16s)

[coupled together now with a strong](https://youtu.be/tRxsBGWxowA?t=00h42m18s)

[reference](https://youtu.be/tRxsBGWxowA?t=00h42m20s)

[when do I unregister for the event or do](https://youtu.be/tRxsBGWxowA?t=00h42m21s)

[I even need to right if it's the](https://youtu.be/tRxsBGWxowA?t=00h42m24s)

[um](https://youtu.be/tRxsBGWxowA?t=00h42m28s)

[if the objects are expected to have the](https://youtu.be/tRxsBGWxowA?t=00h42m28s)

[same lifetime like you register for an](https://youtu.be/tRxsBGWxowA?t=00h42m31s)

[event like for example on the main](https://youtu.be/tRxsBGWxowA?t=00h42m34s)

[window if I do give me a named object](https://youtu.be/tRxsBGWxowA?t=00h42m36s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h42m41s)

[deck panel](https://youtu.be/tRxsBGWxowA?t=00h42m43s)

[right if I do this and go](https://youtu.be/tRxsBGWxowA?t=00h42m47s)

[backpanel dot loaded](https://youtu.be/tRxsBGWxowA?t=00h42m51s)

[right and register for this](https://youtu.be/tRxsBGWxowA?t=00h42m54s)

[I'm also not worried about memory leaks](https://youtu.be/tRxsBGWxowA?t=00h42m56s)

[because these two things are expected to](https://youtu.be/tRxsBGWxowA?t=00h42m59s)

[die together](https://youtu.be/tRxsBGWxowA?t=00h43m01s)

[um this is Kevin you're such a cool WPF](https://youtu.be/tRxsBGWxowA?t=00h43m03s)

[dungeon master](https://youtu.be/tRxsBGWxowA?t=00h43m05s)

[thank you Justin Bieber](https://youtu.be/tRxsBGWxowA?t=00h43m06s)

[um](https://youtu.be/tRxsBGWxowA?t=00h43m09s)

[because when the window dies the stack](https://youtu.be/tRxsBGWxowA?t=00h43m10s)

[panel is going to die with it there now](https://youtu.be/tRxsBGWxowA?t=00h43m12s)

[admittedly I can get away with that](https://youtu.be/tRxsBGWxowA?t=00h43m15s)

[because I know that I'm not moving the](https://youtu.be/tRxsBGWxowA?t=00h43m17s)

[stack panel around in my visual tree](https://youtu.be/tRxsBGWxowA?t=00h43m19s)

[right like the examples we were going](https://youtu.be/tRxsBGWxowA?t=00h43m21s)

[through earlier where well maybe this](https://youtu.be/tRxsBGWxowA?t=00h43m22s)

[thing is moving around maybe it's being](https://youtu.be/tRxsBGWxowA?t=00h43m25s)

[swapped out for uh on different Taps](https://youtu.be/tRxsBGWxowA?t=00h43m26s)

[maybe it's being pulled out context](https://youtu.be/tRxsBGWxowA?t=00h43m28s)

[matters](https://youtu.be/tRxsBGWxowA?t=00h43m30s)

[um but in this case it's like I'm not](https://youtu.be/tRxsBGWxowA?t=00h43m31s)

[worried about any memory leaks because](https://youtu.be/tRxsBGWxowA?t=00h43m34s)

[at the point the the main window goes](https://youtu.be/tRxsBGWxowA?t=00h43m35s)

[out of scope the stack panel will be out](https://youtu.be/tRxsBGWxowA?t=00h43m38s)

[of scope as well they'll die as a unit](https://youtu.be/tRxsBGWxowA?t=00h43m40s)

[perfect that's that's what we want](https://youtu.be/tRxsBGWxowA?t=00h43m42s)

[um](https://youtu.be/tRxsBGWxowA?t=00h43m46s)

[yeah and if you've got specific uh use](https://youtu.be/tRxsBGWxowA?t=00h43m49s)

[cases that you want to talk through if](https://youtu.be/tRxsBGWxowA?t=00h43m51s)

[they're ideally if it's open sourcing](https://youtu.be/tRxsBGWxowA?t=00h43m54s)

[you can share it great](https://youtu.be/tRxsBGWxowA?t=00h43m55s)

[um if not if you want to just talk](https://youtu.be/tRxsBGWxowA?t=00h43m57s)

[through it I'm I'm also happy to look at](https://youtu.be/tRxsBGWxowA?t=00h44m00s)

[those it's one of those it's really easy](https://youtu.be/tRxsBGWxowA?t=00h44m01s)

[to throw out recommendations when it's](https://youtu.be/tRxsBGWxowA?t=00h44m03s)

[General](https://youtu.be/tRxsBGWxowA?t=00h44m05s)

[um](https://youtu.be/tRxsBGWxowA?t=00h44m07s)

[but like I said earlier with with a lot](https://youtu.be/tRxsBGWxowA?t=00h44m08s)

[of this WPF stuff context really matters](https://youtu.be/tRxsBGWxowA?t=00h44m10s)

[um and when the rubber meets the road](https://youtu.be/tRxsBGWxowA?t=00h44m14s)

[and you're actually building an](https://youtu.be/tRxsBGWxowA?t=00h44m15s)

[application you will probably find use](https://youtu.be/tRxsBGWxowA?t=00h44m17s)

[cases where things get weird and](https://youtu.be/tRxsBGWxowA?t=00h44m20s)

[difficult](https://youtu.be/tRxsBGWxowA?t=00h44m22s)

[or you pull in some third-party Library](https://youtu.be/tRxsBGWxowA?t=00h44m23s)

[it's like well shoot I can't do the](https://youtu.be/tRxsBGWxowA?t=00h44m26s)

[normal thing because you know this](https://youtu.be/tRxsBGWxowA?t=00h44m28s)

[property here that I wanted to bind to](https://youtu.be/tRxsBGWxowA?t=00h44m30s)

[is not bindable](https://youtu.be/tRxsBGWxowA?t=00h44m32s)

[okay now I have to do extra stuff in](https://youtu.be/tRxsBGWxowA?t=00h44m34s)

[order to make it work right maybe I do a](https://youtu.be/tRxsBGWxowA?t=00h44m37s)

[behavior or an attach property or](https://youtu.be/tRxsBGWxowA?t=00h44m39s)

[something to to make these things work](https://youtu.be/tRxsBGWxowA?t=00h44m41s)

[and then the question goes well should](https://youtu.be/tRxsBGWxowA?t=00h44m42s)

[it have been bindable maybe there's a](https://youtu.be/tRxsBGWxowA?t=00h44m44s)

[good reason why the the authors didn't](https://youtu.be/tRxsBGWxowA?t=00h44m46s)

[do it that way and then round and round](https://youtu.be/tRxsBGWxowA?t=00h44m48s)

[around we go](https://youtu.be/tRxsBGWxowA?t=00h44m50s)

[um and sometimes it's like well maybe](https://youtu.be/tRxsBGWxowA?t=00h44m51s)

[it's that way because it doesn't work in](https://youtu.be/tRxsBGWxowA?t=00h44m53s)

[the general case but in maybe in your](https://youtu.be/tRxsBGWxowA?t=00h44m55s)

[use case it's fine](https://youtu.be/tRxsBGWxowA?t=00h44m57s)

[like I find that a lot with the esri](https://youtu.be/tRxsBGWxowA?t=00h44m58s)

[controls that I've been working with](https://youtu.be/tRxsBGWxowA?t=00h45m00s)

[they they're very well designed](https://youtu.be/tRxsBGWxowA?t=00h45m01s)

[um It's just sometimes once I confine](https://youtu.be/tRxsBGWxowA?t=00h45m04s)

[them to my one specific use case it's](https://youtu.be/tRxsBGWxowA?t=00h45m07s)

[like dang it it'd be really nice if](https://youtu.be/tRxsBGWxowA?t=00h45m09s)

[you know insert thing here but it's like](https://youtu.be/tRxsBGWxowA?t=00h45m12s)

[okay I get why it's not done that way it](https://youtu.be/tRxsBGWxowA?t=00h45m15s)

[doesn't work in the general use case](https://youtu.be/tRxsBGWxowA?t=00h45m17s)

[because I'm Define my scope this big I](https://youtu.be/tRxsBGWxowA?t=00h45m18s)

[can get away with it but in general it](https://youtu.be/tRxsBGWxowA?t=00h45m21s)

[doesn't work](https://youtu.be/tRxsBGWxowA?t=00h45m24s)

[so also dot Morton if you're watching](https://youtu.be/tRxsBGWxowA?t=00h45m25s)

[love the work it's awesome controls to](https://youtu.be/tRxsBGWxowA?t=00h45m27s)

[work with](https://youtu.be/tRxsBGWxowA?t=00h45m30s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h45m31s)

[uh I left myself a note a while ago](https://youtu.be/tRxsBGWxowA?t=00h45m32s)

[um](https://youtu.be/tRxsBGWxowA?t=00h45m39s)

[there was a button](https://youtu.be/tRxsBGWxowA?t=00h45m41s)

[have you used chat GPT what are your](https://youtu.be/tRxsBGWxowA?t=00h45m44s)

[thought what use cases have you found](https://youtu.be/tRxsBGWxowA?t=00h45m47s)

[useful](https://youtu.be/tRxsBGWxowA?t=00h45m48s)

[um yes I have used it](https://youtu.be/tRxsBGWxowA?t=00h45m50s)

[um](https://youtu.be/tRxsBGWxowA?t=00h45m52s)

[chat I would say chat GPT is to search](https://youtu.be/tRxsBGWxowA?t=00h45m53s)

[engines what co-pilot is to C sharp](https://youtu.be/tRxsBGWxowA?t=00h45m57s)

[um it is](https://youtu.be/tRxsBGWxowA?t=00h46m01s)

[I so the the couple use cases that I](https://youtu.be/tRxsBGWxowA?t=00h46m03s)

[found that I found useful for it](https://youtu.be/tRxsBGWxowA?t=00h46m06s)

[um](https://youtu.be/tRxsBGWxowA?t=00h46m08s)

[one generalized uh like programming](https://youtu.be/tRxsBGWxowA?t=00h46m09s)

[questions of how do I do X](https://youtu.be/tRxsBGWxowA?t=00h46m14s)

[sometimes it's results vastly uh exceed](https://youtu.be/tRxsBGWxowA?t=00h46m17s)

[what you would get with Google because](https://youtu.be/tRxsBGWxowA?t=00h46m21s)

[it's synthesizing data down uh the](https://youtu.be/tRxsBGWxowA?t=00h46m22s)

[problem being is chat GPT unfortunately](https://youtu.be/tRxsBGWxowA?t=00h46m25s)

[uh was trained from you know](https://youtu.be/tRxsBGWxowA?t=00h46m29s)

[humans that are apparently dumb uh](https://youtu.be/tRxsBGWxowA?t=00h46m32s)

[insert stack Overflow articles here and](https://youtu.be/tRxsBGWxowA?t=00h46m35s)

[so sometimes chat gbt gives you really](https://youtu.be/tRxsBGWxowA?t=00h46m38s)

[convincing looking answers that are 100](https://youtu.be/tRxsBGWxowA?t=00h46m40s)

[wrong I was asking if some Powershell](https://youtu.be/tRxsBGWxowA?t=00h46m42s)

[questions last week and I was really](https://youtu.be/tRxsBGWxowA?t=00h46m44s)

[impressed with the answers it gave I was](https://youtu.be/tRxsBGWxowA?t=00h46m46s)

[like that's really impressive and so I I](https://youtu.be/tRxsBGWxowA?t=00h46m48s)

[shared it with some colleagues and one](https://youtu.be/tRxsBGWxowA?t=00h46m51s)

[of them looked at it and went yeah it](https://youtu.be/tRxsBGWxowA?t=00h46m52s)

[gave you two suggestions but one of](https://youtu.be/tRxsBGWxowA?t=00h46m54s)

[those suggestions is just straight up](https://youtu.be/tRxsBGWxowA?t=00h46m56s)

[wrong I'm like yes but the first one is](https://youtu.be/tRxsBGWxowA?t=00h46m57s)

[kind of close](https://youtu.be/tRxsBGWxowA?t=00h47m00s)

[um to what I actually wanted so I was](https://youtu.be/tRxsBGWxowA?t=00h47m02s)

[like in in that regard uh it is](https://youtu.be/tRxsBGWxowA?t=00h47m03s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h47m09s)

[huh](https://youtu.be/tRxsBGWxowA?t=00h47m11s)

[Robert I don't know what you did](https://youtu.be/tRxsBGWxowA?t=00h47m13s)

[sorry uh](https://youtu.be/tRxsBGWxowA?t=00h47m16s)

[uh Shield mode on](https://youtu.be/tRxsBGWxowA?t=00h47m19s)

[turn](https://youtu.be/tRxsBGWxowA?t=00h47m22s)

[oh](https://youtu.be/tRxsBGWxowA?t=00h47m24s)

[all right I don't know what you clicked](https://youtu.be/tRxsBGWxowA?t=00h47m27s)

[so I'm clicking the button because it's](https://youtu.be/tRxsBGWxowA?t=00h47m28s)

[big and purple and in my way](https://youtu.be/tRxsBGWxowA?t=00h47m30s)

[um also welcome Robert uh so I I have](https://youtu.be/tRxsBGWxowA?t=00h47m32s)

[found it really useful for asking like](https://youtu.be/tRxsBGWxowA?t=00h47m36s)

[how to type questions on programming](https://youtu.be/tRxsBGWxowA?t=00h47m39s)

[stuff so it's really great there](https://youtu.be/tRxsBGWxowA?t=00h47m42s)

[um](https://youtu.be/tRxsBGWxowA?t=00h47m46s)

[the other place that I've actually used](https://youtu.be/tRxsBGWxowA?t=00h47m47s)

[it and it's it's funny that you uh use](https://youtu.be/tRxsBGWxowA?t=00h47m49s)

[the dungeon master reference a moment](https://youtu.be/tRxsBGWxowA?t=00h47m52s)

[ago Justin Bieber because I do run a uh](https://youtu.be/tRxsBGWxowA?t=00h47m54s)

[um I DM for a a group we've been going](https://youtu.be/tRxsBGWxowA?t=00h47m58s)

[uh just over a year and](https://youtu.be/tRxsBGWxowA?t=00h48m01s)

[so one I only played I think](https://youtu.be/tRxsBGWxowA?t=00h48m06s)

[two two or three games of d d before I](https://youtu.be/tRxsBGWxowA?t=00h48m10s)

[was like yeah dming looks like fun let's](https://youtu.be/tRxsBGWxowA?t=00h48m13s)

[do that](https://youtu.be/tRxsBGWxowA?t=00h48m15s)

[don't recommend that for most people](https://youtu.be/tRxsBGWxowA?t=00h48m16s)

[didn't know what I was getting into and](https://youtu.be/tRxsBGWxowA?t=00h48m18s)

[then more importantly decided to jump](https://youtu.be/tRxsBGWxowA?t=00h48m20s)

[off the deep end because my wife was](https://youtu.be/tRxsBGWxowA?t=00h48m22s)

[helping and she loved story driven stuff](https://youtu.be/tRxsBGWxowA?t=00h48m24s)

[she's great at that](https://youtu.be/tRxsBGWxowA?t=00h48m26s)

[um she doesn't care as much about like](https://youtu.be/tRxsBGWxowA?t=00h48m28s)

[the mechanics and strategy bits but](https://youtu.be/tRxsBGWxowA?t=00h48m29s)

[loves the story aspect of it and so it](https://youtu.be/tRxsBGWxowA?t=00h48m32s)

[was like yeah you know we'll put our](https://youtu.be/tRxsBGWxowA?t=00h48m34s)

[heads together we'll we'll do our own](https://youtu.be/tRxsBGWxowA?t=00h48m36s)

[world creation build out our own](https://youtu.be/tRxsBGWxowA?t=00h48m37s)

[campaign did not realize how much work](https://youtu.be/tRxsBGWxowA?t=00h48m39s)

[that was it's a ton of work fair warning](https://youtu.be/tRxsBGWxowA?t=00h48m41s)

[don't do that or at least understand](https://youtu.be/tRxsBGWxowA?t=00h48m44s)

[what you're getting yourself into but](https://youtu.be/tRxsBGWxowA?t=00h48m46s)

[chat GPT is actually not bad for like](https://youtu.be/tRxsBGWxowA?t=00h48m48s)

[rules questions](https://youtu.be/tRxsBGWxowA?t=00h48m52s)

[um it's also not bad for World](https://youtu.be/tRxsBGWxowA?t=00h48m54s)

[Generation questions](https://youtu.be/tRxsBGWxowA?t=00h48m56s)

[because you can just do something like](https://youtu.be/tRxsBGWxowA?t=00h48m58s)

[say hey Jenn me up you know uh some NPCs](https://youtu.be/tRxsBGWxowA?t=00h49m00s)

[for a Tavern and it just barfs out a](https://youtu.be/tRxsBGWxowA?t=00h49m04s)

[bunch of stuff it kind of gets a little](https://youtu.be/tRxsBGWxowA?t=00h49m07s)

[repetitive at times you sometimes have](https://youtu.be/tRxsBGWxowA?t=00h49m09s)

[to mix up the keywords or regen](https://youtu.be/tRxsBGWxowA?t=00h49m11s)

[responses because it does feel like](https://youtu.be/tRxsBGWxowA?t=00h49m12s)

[occasionally I'll get to the end where a](https://youtu.be/tRxsBGWxowA?t=00h49m14s)

[lot of the responses start to feel real](https://youtu.be/tRxsBGWxowA?t=00h49m17s)

[similar](https://youtu.be/tRxsBGWxowA?t=00h49m18s)

[but because it's contextual you can go](https://youtu.be/tRxsBGWxowA?t=00h49m19s)

[yeah okay try that again but this time](https://youtu.be/tRxsBGWxowA?t=00h49m21s)

[don't use necrotic damage and it](https://youtu.be/tRxsBGWxowA?t=00h49m24s)

[it's like oh thank you and oftentimes](https://youtu.be/tRxsBGWxowA?t=00h49m26s)

[you know I'll take what it spits out and](https://youtu.be/tRxsBGWxowA?t=00h49m29s)

[I'll change it and clean it up but](https://youtu.be/tRxsBGWxowA?t=00h49m30s)

[um for things like writer's block](https://youtu.be/tRxsBGWxowA?t=00h49m33s)

[it feels like it could be really helpful](https://youtu.be/tRxsBGWxowA?t=00h49m36s)

[in that regard so](https://youtu.be/tRxsBGWxowA?t=00h49m39s)

[so yeah so I think it's I think it is](https://youtu.be/tRxsBGWxowA?t=00h49m43s)

[awesome I I would definitely Advocate](https://youtu.be/tRxsBGWxowA?t=00h49m45s)

[people give it a shot it is it's fun to](https://youtu.be/tRxsBGWxowA?t=00h49m48s)

[play with if nothing else](https://youtu.be/tRxsBGWxowA?t=00h49m51s)

[straight up fun to play with there was](https://youtu.be/tRxsBGWxowA?t=00h49m52s)

[let me look real quick because I don't](https://youtu.be/tRxsBGWxowA?t=00h49m54s)

[know if it's live yet](https://youtu.be/tRxsBGWxowA?t=00h49m55s)

[um a colleague of mine actually wrote a](https://youtu.be/tRxsBGWxowA?t=00h49m58s)

[nice blog post on it](https://youtu.be/tRxsBGWxowA?t=00h50m00s)

[but I don't know if it's published yet](https://youtu.be/tRxsBGWxowA?t=00h50m03s)

[so before I](https://youtu.be/tRxsBGWxowA?t=00h50m06s)

[before I say anything about it let me](https://youtu.be/tRxsBGWxowA?t=00h50m10s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h50m14s)

[uh doesn't look like it's published yet](https://youtu.be/tRxsBGWxowA?t=00h50m18s)

[I don't see it](https://youtu.be/tRxsBGWxowA?t=00h50m21s)

[I should kick him and and see where](https://youtu.be/tRxsBGWxowA?t=00h50m26s)

[where it is but he had a very nice](https://youtu.be/tRxsBGWxowA?t=00h50m29s)

[write-up on it](https://youtu.be/tRxsBGWxowA?t=00h50m31s)

[I don't know why it's not published](https://youtu.be/tRxsBGWxowA?t=00h50m34s)

[a look](https://youtu.be/tRxsBGWxowA?t=00h50m36s)

[I will look](https://youtu.be/tRxsBGWxowA?t=00h50m38s)

[okay something something something theme](https://youtu.be/tRxsBGWxowA?t=00h50m40s)

[brush changes something something](https://youtu.be/tRxsBGWxowA?t=00h50m42s)

[something something okay so](https://youtu.be/tRxsBGWxowA?t=00h50m44s)

[backing up to where I once was here so I](https://youtu.be/tRxsBGWxowA?t=00h50m47s)

[think what I would like to do](https://youtu.be/tRxsBGWxowA?t=00h50m52s)

[is set this little app up because again](https://youtu.be/tRxsBGWxowA?t=00h50m55s)

[I've got](https://youtu.be/tRxsBGWxowA?t=00h50m58s)

[two little boxes with a little bit of](https://youtu.be/tRxsBGWxowA?t=00h50m59s)

[uh color in them](https://youtu.be/tRxsBGWxowA?t=00h51m03s)

[and I want to look at a couple use cases](https://youtu.be/tRxsBGWxowA?t=00h51m06s)

[of](https://youtu.be/tRxsBGWxowA?t=00h51m08s)

[I want to refactor the resource](https://youtu.be/tRxsBGWxowA?t=00h51m10s)

[dictionaries to be in the same structure](https://youtu.be/tRxsBGWxowA?t=00h51m12s)

[that they would be inside of the](https://youtu.be/tRxsBGWxowA?t=00h51m13s)

[material design library and then look at](https://youtu.be/tRxsBGWxowA?t=00h51m15s)

[how easy are they to just immediately](https://youtu.be/tRxsBGWxowA?t=00h51m17s)

[consume](https://youtu.be/tRxsBGWxowA?t=00h51m20s)

[uh how easy are they to change from](https://youtu.be/tRxsBGWxowA?t=00h51m22s)

[either xaml or code behind](https://youtu.be/tRxsBGWxowA?t=00h51m25s)

[and then how easy are they for people](https://youtu.be/tRxsBGWxowA?t=00h51m28s)

[who want to change just a few versus](https://youtu.be/tRxsBGWxowA?t=00h51m30s)

[change them all which means I might have](https://youtu.be/tRxsBGWxowA?t=00h51m32s)

[to add a second brush so I can do the](https://youtu.be/tRxsBGWxowA?t=00h51m34s)

[few case but I think that's I think](https://youtu.be/tRxsBGWxowA?t=00h51m36s)

[that's what I'd like to test so maybe](https://youtu.be/tRxsBGWxowA?t=00h51m39s)

[maybe we start there let's start with a](https://youtu.be/tRxsBGWxowA?t=00h51m40s)

[couple resource dictionaries so add](https://youtu.be/tRxsBGWxowA?t=00h51m43s)

[resource dictionary so if we were to](https://youtu.be/tRxsBGWxowA?t=00h51m45s)

[structure this in uh let's see we'll](https://youtu.be/tRxsBGWxowA?t=00h51m48s)

[call it theme colors](https://youtu.be/tRxsBGWxowA?t=00h51m52s)

[all right so we're gonna do something](https://youtu.be/tRxsBGWxowA?t=00h51m55s)

[like that and then I think what I'm](https://youtu.be/tRxsBGWxowA?t=00h51m56s)

[going to do is add](https://youtu.be/tRxsBGWxowA?t=00h51m57s)

[resource dictionary](https://youtu.be/tRxsBGWxowA?t=00h52m00s)

[theme](https://youtu.be/tRxsBGWxowA?t=00h52m02s)

[brushes](https://youtu.be/tRxsBGWxowA?t=00h52m03s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h52m06s)

[uh another question this is more generic](https://youtu.be/tRxsBGWxowA?t=00h52m09s)

[I don't want to abuse your kindness but](https://youtu.be/tRxsBGWxowA?t=00h52m10s)

[I can answer from you uh if I have a](https://youtu.be/tRxsBGWxowA?t=00h52m12s)

[validation code](https://youtu.be/tRxsBGWxowA?t=00h52m15s)

[uh let's see if I have a validation code](https://youtu.be/tRxsBGWxowA?t=00h52m20s)

[class full of constant strings email not](https://youtu.be/tRxsBGWxowA?t=00h52m23s)

[verified Etc but I want to use as a base](https://youtu.be/tRxsBGWxowA?t=00h52m26s)

[class for multiple projects](https://youtu.be/tRxsBGWxowA?t=00h52m28s)

[uh and I want to add another validation](https://youtu.be/tRxsBGWxowA?t=00h52m30s)

[codes only relevant for those projects](https://youtu.be/tRxsBGWxowA?t=00h52m33s)

[how do I avoid create a class extensive](https://youtu.be/tRxsBGWxowA?t=00h52m36s)

[Base Class so the both and the core uh](https://youtu.be/tRxsBGWxowA?t=00h52m39s)

[can continue using](https://youtu.be/tRxsBGWxowA?t=00h52m43s)

[that is a good question let me](https://youtu.be/tRxsBGWxowA?t=00h52m45s)

[think for just a moment before I answer](https://youtu.be/tRxsBGWxowA?t=00h52m50s)

[so](https://youtu.be/tRxsBGWxowA?t=00h52m53s)

[I can't resist writing code so we're I'm](https://youtu.be/tRxsBGWxowA?t=00h52m57s)

[gonna just I'm gonna just mock something](https://youtu.be/tRxsBGWxowA?t=00h52m59s)

[mock something out a little bit right so](https://youtu.be/tRxsBGWxowA?t=00h53m00s)

[public class uh validation codes right](https://youtu.be/tRxsBGWxowA?t=00h53m02s)

[uh public uh string email not verified](https://youtu.be/tRxsBGWxowA?t=00h53m07s)

[it's name of](https://youtu.be/tRxsBGWxowA?t=00h53m13s)

[email not verified exact value doesn't](https://youtu.be/tRxsBGWxowA?t=00h53m16s)

[matter all right](https://youtu.be/tRxsBGWxowA?t=00h53m19s)

[thank you co-pilot sure we can have a](https://youtu.be/tRxsBGWxowA?t=00h53m20s)

[second one just because you asked now](https://youtu.be/tRxsBGWxowA?t=00h53m22s)

[the hard so there's a couple things that](https://youtu.be/tRxsBGWxowA?t=00h53m24s)

[are worth](https://youtu.be/tRxsBGWxowA?t=00h53m27s)

[considering](https://youtu.be/tRxsBGWxowA?t=00h53m28s)

[yeah so partial](https://youtu.be/tRxsBGWxowA?t=00h53m31s)

[and here's the thing](https://youtu.be/tRxsBGWxowA?t=00h53m34s)

[so there there well there's a couple](https://youtu.be/tRxsBGWxowA?t=00h53m37s)

[things so one if you have a class like](https://youtu.be/tRxsBGWxowA?t=00h53m39s)

[this that contains either only constant](https://youtu.be/tRxsBGWxowA?t=00h53m41s)

[or sometimes I found that they can't be](https://youtu.be/tRxsBGWxowA?t=00h53m43s)

[compile time constant but you can do](https://youtu.be/tRxsBGWxowA?t=00h53m46s)

[like static read only right maybe you've](https://youtu.be/tRxsBGWxowA?t=00h53m48s)

[got some grids or something that that](https://youtu.be/tRxsBGWxowA?t=00h53m51s)

[you want in there that are functionally](https://youtu.be/tRxsBGWxowA?t=00h53m53s)

[constant but not known at compile time](https://youtu.be/tRxsBGWxowA?t=00h53m55s)

[um](https://youtu.be/tRxsBGWxowA?t=00h53m59s)

[yeah Robert's right making the class](https://youtu.be/tRxsBGWxowA?t=00h54m00s)

[static the the the thing that I'm that](https://youtu.be/tRxsBGWxowA?t=00h54m03s)

[I'm hearing in the question though is in](https://youtu.be/tRxsBGWxowA?t=00h54m06s)

[in some of your projects you want to](https://youtu.be/tRxsBGWxowA?t=00h54m09s)

[have something like public class](https://youtu.be/tRxsBGWxowA?t=00h54m10s)

[uh validation codes](https://youtu.be/tRxsBGWxowA?t=00h54m13s)

[uh in Project right so this is maybe](https://youtu.be/tRxsBGWxowA?t=00h54m16s)

[what we'll call this base right uh](https://youtu.be/tRxsBGWxowA?t=00h54m20s)

[right and this is immediately where the](https://youtu.be/tRxsBGWxowA?t=00h54m24s)

[problems start because then you run into](https://youtu.be/tRxsBGWxowA?t=00h54m27s)

[the case of](https://youtu.be/tRxsBGWxowA?t=00h54m29s)

[once the class is static](https://youtu.be/tRxsBGWxowA?t=00h54m31s)

[this doesn't really work anymore](https://youtu.be/tRxsBGWxowA?t=00h54m34s)

[um](https://youtu.be/tRxsBGWxowA?t=00h54m39s)

[so there's a couple things I would](https://youtu.be/tRxsBGWxowA?t=00h54m47s)

[propose considering so](https://youtu.be/tRxsBGWxowA?t=00h54m50s)

[uh](https://youtu.be/tRxsBGWxowA?t=00h54m54s)

[yeah static read-only because cons](https://youtu.be/tRxsBGWxowA?t=00h54m58s)

[yeah they're yeah there's subtle](https://youtu.be/tRxsBGWxowA?t=00h55m01s)

[differences when const is only the](https://youtu.be/tRxsBGWxowA?t=00h55m03s)

[compiled time constant stuff and there's](https://youtu.be/tRxsBGWxowA?t=00h55m05s)

[there's plenty of cases I've run into](https://youtu.be/tRxsBGWxowA?t=00h55m06s)

[where I need static read only instead](https://youtu.be/tRxsBGWxowA?t=00h55m08s)

[um](https://youtu.be/tRxsBGWxowA?t=00h55m11s)

[so there's a couple things that you](https://youtu.be/tRxsBGWxowA?t=00h55m13s)

[could consider one would be file linking](https://youtu.be/tRxsBGWxowA?t=00h55m15s)

[so and and this is gonna this this](https://youtu.be/tRxsBGWxowA?t=00h55m18s)

[technique depends on where the project](https://youtu.be/tRxsBGWxowA?t=00h55m20s)

[is so let's imagine I have this thing](https://youtu.be/tRxsBGWxowA?t=00h55m24s)

[here what you can do is you can go add](https://youtu.be/tRxsBGWxowA?t=00h55m26s)

[existing item](https://youtu.be/tRxsBGWxowA?t=00h55m28s)

[uh that's the wrong project let's try](https://youtu.be/tRxsBGWxowA?t=00h55m30s)

[that again where the heck is this thing](https://youtu.be/tRxsBGWxowA?t=00h55m33s)

[actually located open containing folder](https://youtu.be/tRxsBGWxowA?t=00h55m35s)

[I'm here I forgot where I was so let's](https://youtu.be/tRxsBGWxowA?t=00h55m39s)

[try this again uh add existing item and](https://youtu.be/tRxsBGWxowA?t=00h55m41s)

[quit being there I don't want to be in](https://youtu.be/tRxsBGWxowA?t=00h55m45s)

[testicles so what you can do so I'm](https://youtu.be/tRxsBGWxowA?t=00h55m46s)

[adding an item to the to my test project](https://youtu.be/tRxsBGWxowA?t=00h55m48s)

[and this is purely arbitrary but you can](https://youtu.be/tRxsBGWxowA?t=00h55m51s)

[go add and add as link now this is one](https://youtu.be/tRxsBGWxowA?t=00h55m54s)

[of those](https://youtu.be/tRxsBGWxowA?t=00h55m58s)

[this is one of those cases where it](https://youtu.be/tRxsBGWxowA?t=00h56m00s)

[adding file links is convenient](https://youtu.be/tRxsBGWxowA?t=00h56m03s)

[because now I have one file that's being](https://youtu.be/tRxsBGWxowA?t=00h56m06s)

[used in two places right if I edit one](https://youtu.be/tRxsBGWxowA?t=00h56m11s)

[right and we say Okay copilot send me](https://youtu.be/tRxsBGWxowA?t=00h56m13s)

[another one thanks](https://youtu.be/tRxsBGWxowA?t=00h56m15s)

[um](https://youtu.be/tRxsBGWxowA?t=00h56m18s)

[it doesn't matter which one I open it's](https://youtu.be/tRxsBGWxowA?t=00h56m19s)

[the same file the the thing to be aware](https://youtu.be/tRxsBGWxowA?t=00h56m21s)

[of is file linking is functionally the](https://youtu.be/tRxsBGWxowA?t=00h56m23s)

[same as just copying and pasting that](https://youtu.be/tRxsBGWxowA?t=00h56m26s)

[class into both projects](https://youtu.be/tRxsBGWxowA?t=00h56m28s)

[there's nothing more magical about it](https://youtu.be/tRxsBGWxowA?t=00h56m31s)

[than that](https://youtu.be/tRxsBGWxowA?t=00h56m33s)

[um and so](https://youtu.be/tRxsBGWxowA?t=00h56m34s)

[file linking can then start to cause](https://youtu.be/tRxsBGWxowA?t=00h56m36s)

[weird problems because you can imagine](https://youtu.be/tRxsBGWxowA?t=00h56m40s)

[if I because I've got project a project](https://youtu.be/tRxsBGWxowA?t=00h56m42s)

[B](https://youtu.be/tRxsBGWxowA?t=00h56m44s)

[imagine project C that references both](https://youtu.be/tRxsBGWxowA?t=00h56m45s)

[Project A and B and I call validation](https://youtu.be/tRxsBGWxowA?t=00h56m48s)

[codes Dot and it immediately goes hang](https://youtu.be/tRxsBGWxowA?t=00h56m51s)

[on](https://youtu.be/tRxsBGWxowA?t=00h56m55s)

[which one do you mean because](https://youtu.be/tRxsBGWxowA?t=00h56m56s)

[since it's the same file it's going to](https://youtu.be/tRxsBGWxowA?t=00h56m59s)

[be the same namespace it's going to be](https://youtu.be/tRxsBGWxowA?t=00h57m01s)

[the same class name and so you uh uh so](https://youtu.be/tRxsBGWxowA?t=00h57m03s)

[then you run into that kind of problem](https://youtu.be/tRxsBGWxowA?t=00h57m07s)

[but file lengthy I uh save to get or not](https://youtu.be/tRxsBGWxowA?t=00h57m09s)

[so yes saved in git but it doesn't show](https://youtu.be/tRxsBGWxowA?t=00h57m12s)

[up in the project directory what it'll](https://youtu.be/tRxsBGWxowA?t=00h57m16s)

[show up as is](https://youtu.be/tRxsBGWxowA?t=00h57m18s)

[um in your CS products like this](https://youtu.be/tRxsBGWxowA?t=00h57m20s)

[so you'll see this type of line get](https://youtu.be/tRxsBGWxowA?t=00h57m23s)

[added in](https://youtu.be/tRxsBGWxowA?t=00h57m26s)

[so then if you're looking at like a PR](https://youtu.be/tRxsBGWxowA?t=00h57m27s)

[or similar for a diff you'll only see it](https://youtu.be/tRxsBGWxowA?t=00h57m29s)

[in one place so if you're using file](https://youtu.be/tRxsBGWxowA?t=00h57m31s)

[linking I oftentimes](https://youtu.be/tRxsBGWxowA?t=00h57m34s)

[I I get very cautious about what I'm](https://youtu.be/tRxsBGWxowA?t=00h57m37s)

[file linking if the uh if the file](https://youtu.be/tRxsBGWxowA?t=00h57m39s)

[contains public stuff](https://youtu.be/tRxsBGWxowA?t=00h57m43s)

[because as soon as you get it because](https://youtu.be/tRxsBGWxowA?t=00h57m45s)

[you can get into that case where](https://youtu.be/tRxsBGWxowA?t=00h57m47s)

[um project C comes in references Project](https://youtu.be/tRxsBGWxowA?t=00h57m50s)

[A and B and now it's uh you have to deal](https://youtu.be/tRxsBGWxowA?t=00h57m53s)

[with like external Alias to disambiguate](https://youtu.be/tRxsBGWxowA?t=00h57m56s)

[which one of those two classes you mean](https://youtu.be/tRxsBGWxowA?t=00h57m59s)

[because each of those assemblies has](https://youtu.be/tRxsBGWxowA?t=00h58m01s)

[their own copy of the class](https://youtu.be/tRxsBGWxowA?t=00h58m03s)

[um](https://youtu.be/tRxsBGWxowA?t=00h58m06s)

[so assuming you own all the assemblies](https://youtu.be/tRxsBGWxowA?t=00h58m09s)

[in question and they're in the same repo](https://youtu.be/tRxsBGWxowA?t=00h58m11s)

[file linking is an option](https://youtu.be/tRxsBGWxowA?t=00h58m13s)

[um another option and it's kind of](https://youtu.be/tRxsBGWxowA?t=00h58m18s)

[wasteful is you can end up pushing](https://youtu.be/tRxsBGWxowA?t=00h58m20s)

[things into like a shared project](https://youtu.be/tRxsBGWxowA?t=00h58m24s)

[between them that is](https://youtu.be/tRxsBGWxowA?t=00h58m25s)

[kind of Overkill it also doesn't play](https://youtu.be/tRxsBGWxowA?t=00h58m28s)

[nice if you want](https://youtu.be/tRxsBGWxowA?t=00h58m30s)

[um](https://youtu.be/tRxsBGWxowA?t=00h58m33s)

[it doesn't play nice if you want to](https://youtu.be/tRxsBGWxowA?t=00h58m35s)

[extend it so the advantage of or I](https://youtu.be/tRxsBGWxowA?t=00h58m37s)

[should say I'll point this out the other](https://youtu.be/tRxsBGWxowA?t=00h58m40s)

[advantage of file linking is I can now](https://youtu.be/tRxsBGWxowA?t=00h58m41s)

[get away with this garbage with partial](https://youtu.be/tRxsBGWxowA?t=00h58m44s)

[so you'll note I've added a partial here](https://youtu.be/tRxsBGWxowA?t=00h58m46s)

[and if I do this uh let's get rid of](https://youtu.be/tRxsBGWxowA?t=00h58m49s)

[this one](https://youtu.be/tRxsBGWxowA?t=00h58m53s)

[right so if I come in here uh collapse](https://youtu.be/tRxsBGWxowA?t=00h58m54s)

[give me a new thing uh](https://youtu.be/tRxsBGWxowA?t=00h58m58s)

[not the not the being I wanted I wanted](https://youtu.be/tRxsBGWxowA?t=00h59m01s)

[that one right so I can now get away](https://youtu.be/tRxsBGWxowA?t=00h59m04s)

[with this](https://youtu.be/tRxsBGWxowA?t=00h59m07s)

[and then if I reference it uh let's see](https://youtu.be/tRxsBGWxowA?t=00h59m09s)

[validation codes base you'll note](https://youtu.be/tRxsBGWxowA?t=00h59m13s)

[hey why doesn't it show them all](https://youtu.be/tRxsBGWxowA?t=00h59m16s)

[passwords do not match passwords do not](https://youtu.be/tRxsBGWxowA?t=00h59m18s)

[match](https://youtu.be/tRxsBGWxowA?t=00h59m21s)

[oh because this is in the wrong](https://youtu.be/tRxsBGWxowA?t=00h59m22s)

[namespace](https://youtu.be/tRxsBGWxowA?t=00h59m24s)

[move you out](https://youtu.be/tRxsBGWxowA?t=00h59m26s)

[so you'll note I've got two files here](https://youtu.be/tRxsBGWxowA?t=00h59m28s)

[and as long as I put them in the same](https://youtu.be/tRxsBGWxowA?t=00h59m30s)

[namespace like they're supposed to be](https://youtu.be/tRxsBGWxowA?t=00h59m31s)

[because right now that partial isn't](https://youtu.be/tRxsBGWxowA?t=00h59m34s)

[doing anything okay now we go back](https://youtu.be/tRxsBGWxowA?t=00h59m36s)

[and now if I do the intellisense](https://youtu.be/tRxsBGWxowA?t=00h59m39s)

[I I see all three](https://youtu.be/tRxsBGWxowA?t=00h59m42s)

[so if you do the file linking file](https://youtu.be/tRxsBGWxowA?t=00h59m44s)

[linking does give you a nice](https://youtu.be/tRxsBGWxowA?t=00h59m46s)

[opportunity we'll say to abuse partial](https://youtu.be/tRxsBGWxowA?t=00h59m49s)

[because again file linking is no](https://youtu.be/tRxsBGWxowA?t=00h59m54s)

[different than if you were to just copy](https://youtu.be/tRxsBGWxowA?t=00h59m56s)

[that file into both places](https://youtu.be/tRxsBGWxowA?t=00h59m57s)

[and then you're good to go the the](https://youtu.be/tRxsBGWxowA?t=01h00m00s)

[advantage of file linking is you don't](https://youtu.be/tRxsBGWxowA?t=01h00m02s)

[have two copies of the file so you](https://youtu.be/tRxsBGWxowA?t=01h00m04s)

[aren't trying to keep two things in sync](https://youtu.be/tRxsBGWxowA?t=01h00m05s)

[which would be horrible](https://youtu.be/tRxsBGWxowA?t=01h00m07s)

[um it's just the tooling copies the file](https://youtu.be/tRxsBGWxowA?t=01h00m08s)

[for you and saves you the effort but it](https://youtu.be/tRxsBGWxowA?t=01h00m10s)

[is effectively just that copying the](https://youtu.be/tRxsBGWxowA?t=01h00m13s)

[file for you](https://youtu.be/tRxsBGWxowA?t=01h00m16s)

[um it all it also does mean that if you](https://youtu.be/tRxsBGWxowA?t=01h00m17s)

[do file linking you have to kind of](https://youtu.be/tRxsBGWxowA?t=01h00m19s)

[think about your name spaces](https://youtu.be/tRxsBGWxowA?t=01h00m21s)

[because normally your namespace follows](https://youtu.be/tRxsBGWxowA?t=01h00m23s)

[the project that it's in but as soon as](https://youtu.be/tRxsBGWxowA?t=01h00m25s)

[you do file linking you have to violate](https://youtu.be/tRxsBGWxowA?t=01h00m28s)

[that because now you've got a class](https://youtu.be/tRxsBGWxowA?t=01h00m30s)

[that has to be in a different namespace](https://youtu.be/tRxsBGWxowA?t=01h00m33s)

[in order for that to work so](https://youtu.be/tRxsBGWxowA?t=01h00m36s)

[um](https://youtu.be/tRxsBGWxowA?t=01h00m39s)

[but again use use cases will vary](https://youtu.be/tRxsBGWxowA?t=01h00m39s)

[um but file linking is an option](https://youtu.be/tRxsBGWxowA?t=01h00m43s)

[um](https://youtu.be/tRxsBGWxowA?t=01h00m46s)

[some sort of shared project would be](https://youtu.be/tRxsBGWxowA?t=01h00m50s)

[another so just straight up push the](https://youtu.be/tRxsBGWxowA?t=01h00m52s)

[code down into a lower level one](https://youtu.be/tRxsBGWxowA?t=01h00m54s)

[um](https://youtu.be/tRxsBGWxowA?t=01h00m58s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h01m00s)

[let's see if I use file Link in any case](https://youtu.be/tRxsBGWxowA?t=01h01m02s)

[it means I cannot have the validation](https://youtu.be/tRxsBGWxowA?t=01h01m04s)

[code base in a dll that I can use in](https://youtu.be/tRxsBGWxowA?t=01h01m06s)

[different projects but I must have the](https://youtu.be/tRxsBGWxowA?t=01h01m09s)

[code ported from one project to another](https://youtu.be/tRxsBGWxowA?t=01h01m11s)

[correct file linking is really only](https://youtu.be/tRxsBGWxowA?t=01h01m12s)

[viable if you end up](https://youtu.be/tRxsBGWxowA?t=01h01m15s)

[um](https://youtu.be/tRxsBGWxowA?t=01h01m19s)

[effectively if all of the projects are](https://youtu.be/tRxsBGWxowA?t=01h01m22s)

[in the same solution or at least in the](https://youtu.be/tRxsBGWxowA?t=01h01m24s)

[same repository the moment they get](https://youtu.be/tRxsBGWxowA?t=01h01m25s)

[outside the same repository file linking](https://youtu.be/tRxsBGWxowA?t=01h01m27s)

[really isn't a viable Choice some people](https://youtu.be/tRxsBGWxowA?t=01h01m29s)

[I've seen file link across repositories](https://youtu.be/tRxsBGWxowA?t=01h01m32s)

[and just tell people hey when you clone](https://youtu.be/tRxsBGWxowA?t=01h01m34s)

[this you also have to clone this other](https://youtu.be/tRxsBGWxowA?t=01h01m36s)

[repository side by side don't do that](https://youtu.be/tRxsBGWxowA?t=01h01m37s)

[that's yucky](https://youtu.be/tRxsBGWxowA?t=01h01m40s)

[um it's somewhat okay if we're talking](https://youtu.be/tRxsBGWxowA?t=01h01m42s)

[about sub modules but yeah it gets yucky](https://youtu.be/tRxsBGWxowA?t=01h01m44s)

[I don't like it](https://youtu.be/tRxsBGWxowA?t=01h01m48s)

[um](https://youtu.be/tRxsBGWxowA?t=01h01m50s)

[yeah the](https://youtu.be/tRxsBGWxowA?t=01h01m51s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h01m54s)

[a common shared project](https://youtu.be/tRxsBGWxowA?t=01h01m55s)

[um](https://youtu.be/tRxsBGWxowA?t=01h02m00s)

[the other thing you could do](https://youtu.be/tRxsBGWxowA?t=01h02m03s)

[the other thing and I guess it depends](https://youtu.be/tRxsBGWxowA?t=01h02m13s)

[on how much infrastructure you want to](https://youtu.be/tRxsBGWxowA?t=01h02m15s)

[put in place around this because if it](https://youtu.be/tRxsBGWxowA?t=01h02m16s)

[is just a class with some constants](https://youtu.be/tRxsBGWxowA?t=01h02m18s)

[there there's trade-offs on the time to](https://youtu.be/tRxsBGWxowA?t=01h02m21s)

[do it so there are a few other features](https://youtu.be/tRxsBGWxowA?t=01h02m23s)

[that could be viable options](https://youtu.be/tRxsBGWxowA?t=01h02m26s)

[for example there are what are called](https://youtu.be/tRxsBGWxowA?t=01h02m29s)

[Source only nuget packages](https://youtu.be/tRxsBGWxowA?t=01h02m32s)

[so rather than a nuget package coming in](https://youtu.be/tRxsBGWxowA?t=01h02m34s)

[and referencing a dll a nuget package](https://youtu.be/tRxsBGWxowA?t=01h02m36s)

[can bring in source code files](https://youtu.be/tRxsBGWxowA?t=01h02m39s)

[it gives you](https://youtu.be/tRxsBGWxowA?t=01h02m42s)

[file linking like Behavior](https://youtu.be/tRxsBGWxowA?t=01h02m44s)

[except for rather than the source of it](https://youtu.be/tRxsBGWxowA?t=01h02m47s)

[being another file that's in your](https://youtu.be/tRxsBGWxowA?t=01h02m49s)

[repository it's a file that's shipped](https://youtu.be/tRxsBGWxowA?t=01h02m51s)

[down via nuget package](https://youtu.be/tRxsBGWxowA?t=01h02m53s)

[um](https://youtu.be/tRxsBGWxowA?t=01h02m57s)

[that that would be one option](https://youtu.be/tRxsBGWxowA?t=01h02m58s)

[um](https://youtu.be/tRxsBGWxowA?t=01h03m02s)

[the other thing could could be a](https://youtu.be/tRxsBGWxowA?t=01h03m03s)

[question on what is the source of Truth](https://youtu.be/tRxsBGWxowA?t=01h03m05s)

[for these constants as well because I do](https://youtu.be/tRxsBGWxowA?t=01h03m07s)

[think about](https://youtu.be/tRxsBGWxowA?t=01h03m09s)

[and again this is probably way Overkill](https://youtu.be/tRxsBGWxowA?t=01h03m11s)

[not probably this is definitely way](https://youtu.be/tRxsBGWxowA?t=01h03m14s)

[Overkill but even like Source generator](https://youtu.be/tRxsBGWxowA?t=01h03m15s)

[you know in to make it work could be](https://youtu.be/tRxsBGWxowA?t=01h03m18s)

[could potentially be an option](https://youtu.be/tRxsBGWxowA?t=01h03m21s)

[um but again that's](https://youtu.be/tRxsBGWxowA?t=01h03m24s)

[almost assuredly Overkill](https://youtu.be/tRxsBGWxowA?t=01h03m26s)

[um the other thing that that I've](https://youtu.be/tRxsBGWxowA?t=01h03m31s)

[kind of abused in the past if you don't](https://youtu.be/tRxsBGWxowA?t=01h03m33s)

[mind](https://youtu.be/tRxsBGWxowA?t=01h03m36s)

[breaking namespace problems](https://youtu.be/tRxsBGWxowA?t=01h03m39s)

[um the the only real advantage to having](https://youtu.be/tRxsBGWxowA?t=01h03m42s)

[them all in the same class is so that](https://youtu.be/tRxsBGWxowA?t=01h03m44s)

[you can go dot on the class and see them](https://youtu.be/tRxsBGWxowA?t=01h03m46s)

[all in your intellisense](https://youtu.be/tRxsBGWxowA?t=01h03m48s)

[um sometimes uh just futzing with class](https://youtu.be/tRxsBGWxowA?t=01h03m51s)

[names can be reasonable so uh validation](https://youtu.be/tRxsBGWxowA?t=01h03m54s)

[codes I've cheated a little bit just](https://youtu.be/tRxsBGWxowA?t=01h03m59s)

[knowing that intellisense likes](https://youtu.be/tRxsBGWxowA?t=01h04m01s)

[alphabetizing uh validation you know](https://youtu.be/tRxsBGWxowA?t=01h04m03s)

[launch codes because that's useful](https://youtu.be/tRxsBGWxowA?t=01h04m06s)

[thanks copilot you're on fire](https://youtu.be/tRxsBGWxowA?t=01h04m11s)

[um](https://youtu.be/tRxsBGWxowA?t=01h04m13s)

[and just cheating this that way and](https://youtu.be/tRxsBGWxowA?t=01h04m14s)

[again assume that these are coming in](https://youtu.be/tRxsBGWxowA?t=01h04m16s)

[from different places but other than](https://youtu.be/tRxsBGWxowA?t=01h04m18s)

[that I don't know if there's](https://youtu.be/tRxsBGWxowA?t=01h04m19s)

[uh let's say many websites every website](https://youtu.be/tRxsBGWxowA?t=01h04m24s)

[has validation codes for email and](https://youtu.be/tRxsBGWxowA?t=01h04m26s)

[password once uh](https://youtu.be/tRxsBGWxowA?t=01h04m28s)

[uh yeah](https://youtu.be/tRxsBGWxowA?t=01h04m35s)

[yeah no I think that use case makes](https://youtu.be/tRxsBGWxowA?t=01h04m36s)

[sense the the difficulty being that I](https://youtu.be/tRxsBGWxowA?t=01h04m39s)

[think what I would do in that use case](https://youtu.be/tRxsBGWxowA?t=01h04m42s)

[is I would probably](https://youtu.be/tRxsBGWxowA?t=01h04m45s)

[I would probably propose that validation](https://youtu.be/tRxsBGWxowA?t=01h04m49s)

[codes might be too generic of a](https://youtu.be/tRxsBGWxowA?t=01h04m51s)

[container name](https://youtu.be/tRxsBGWxowA?t=01h04m53s)

[um and instead do you know web](https://youtu.be/tRxsBGWxowA?t=01h04m55s)

[validation codes and then in each the](https://youtu.be/tRxsBGWxowA?t=01h04m57s)

[the projects that need to extend it](https://youtu.be/tRxsBGWxowA?t=01h05m00s)

[right so this ends up in my nuget](https://youtu.be/tRxsBGWxowA?t=01h05m02s)

[package or shared dll or wherever I put](https://youtu.be/tRxsBGWxowA?t=01h05m04s)

[it](https://youtu.be/tRxsBGWxowA?t=01h05m06s)

[um but then this the the one that's](https://youtu.be/tRxsBGWxowA?t=01h05m07s)

[actually in the the dog breeds](https://youtu.be/tRxsBGWxowA?t=01h05m10s)

[um right uh or the stock one uh stock](https://youtu.be/tRxsBGWxowA?t=01h05m13s)

[validation codes](https://youtu.be/tRxsBGWxowA?t=01h05m17s)

[um the other thing you can do is you](https://youtu.be/tRxsBGWxowA?t=01h05m21s)

[could abuse name spaces a little bit](https://youtu.be/tRxsBGWxowA?t=01h05m23s)

[right so then](https://youtu.be/tRxsBGWxowA?t=01h05m26s)

[as long as I put all so even though the](https://youtu.be/tRxsBGWxowA?t=01h05m28s)

[the classes are coming from different](https://youtu.be/tRxsBGWxowA?t=01h05m31s)

[assemblies](https://youtu.be/tRxsBGWxowA?t=01h05m32s)

[um as long as I put all of the classes](https://youtu.be/tRxsBGWxowA?t=01h05m34s)

[in the same namespace I'm still then](https://youtu.be/tRxsBGWxowA?t=01h05m36s)

[able to in my project do something like](https://youtu.be/tRxsBGWxowA?t=01h05m39s)

[validation Dot and then rather than](https://youtu.be/tRxsBGWxowA?t=01h05m42s)

[seeing member names off of the class if](https://youtu.be/tRxsBGWxowA?t=01h05m45s)

[I know that all of my validation classes](https://youtu.be/tRxsBGWxowA?t=01h05m48s)

[regardless of whether they came in from](https://youtu.be/tRxsBGWxowA?t=01h05m50s)

[a nuget package or similar you can cheat](https://youtu.be/tRxsBGWxowA?t=01h05m52s)

[and just do](https://youtu.be/tRxsBGWxowA?t=01h05m56s)

[the same thing just shifted up a level](https://youtu.be/tRxsBGWxowA?t=01h05m58s)

[right so rather than typing class name](https://youtu.be/tRxsBGWxowA?t=01h06m01s)

[dot to get the intellisense to see them](https://youtu.be/tRxsBGWxowA?t=01h06m03s)

[all namespace dot gets you the class](https://youtu.be/tRxsBGWxowA?t=01h06m04s)

[name and then organize them accordingly](https://youtu.be/tRxsBGWxowA?t=01h06m07s)

[by name right and then you can drop into](https://youtu.be/tRxsBGWxowA?t=01h06m10s)

[to where things need to go](https://youtu.be/tRxsBGWxowA?t=01h06m12s)

[and then you're off to the races what](https://youtu.be/tRxsBGWxowA?t=01h06m17s)

[are you squawkied about](https://youtu.be/tRxsBGWxowA?t=01h06m18s)

[yeah because that's one thing like](https://youtu.be/tRxsBGWxowA?t=01h06m23s)

[oftentimes oftentimes people expect me](https://youtu.be/tRxsBGWxowA?t=01h06m25s)

[like the general guidance is your name](https://youtu.be/tRxsBGWxowA?t=01h06m28s)

[space should follow your project name](https://youtu.be/tRxsBGWxowA?t=01h06m31s)

[right that's the by default that should](https://youtu.be/tRxsBGWxowA?t=01h06m34s)

[be where you start or I should say](https://youtu.be/tRxsBGWxowA?t=01h06m36s)

[project name and then and then hierarchy](https://youtu.be/tRxsBGWxowA?t=01h06m38s)

[right so if you've got folders you know](https://youtu.be/tRxsBGWxowA?t=01h06m41s)

[blah blah blah](https://youtu.be/tRxsBGWxowA?t=01h06m42s)

[but there's nothing stopping you from](https://youtu.be/tRxsBGWxowA?t=01h06m43s)

[from putting things in different name](https://youtu.be/tRxsBGWxowA?t=01h06m46s)

[spaces](https://youtu.be/tRxsBGWxowA?t=01h06m48s)

[and so at least by convention you can go](https://youtu.be/tRxsBGWxowA?t=01h06m50s)

[that route so if the the so if the goal](https://youtu.be/tRxsBGWxowA?t=01h06m52s)

[is just to get the intellisense to to be](https://youtu.be/tRxsBGWxowA?t=01h06m54s)

[easy having a a reasonable uh namespace](https://youtu.be/tRxsBGWxowA?t=01h06m57s)

[name](https://youtu.be/tRxsBGWxowA?t=01h07m01s)

[that could be fun](https://youtu.be/tRxsBGWxowA?t=01h07m03s)

[and I know I've abused that a little bit](https://youtu.be/tRxsBGWxowA?t=01h07m06s)

[as well it's actually the same way that](https://youtu.be/tRxsBGWxowA?t=01h07m08s)

[a lot of the the Generico stuff works so](https://youtu.be/tRxsBGWxowA?t=01h07m10s)

[when you see all of the things that are](https://youtu.be/tRxsBGWxowA?t=01h07m18s)

[on like](https://youtu.be/tRxsBGWxowA?t=01h07m20s)

[um configuring the services where you do](https://youtu.be/tRxsBGWxowA?t=01h07m21s)

[Services dot all that is is people](https://youtu.be/tRxsBGWxowA?t=01h07m23s)

[writing extension methods and putting](https://youtu.be/tRxsBGWxowA?t=01h07m26s)

[them all in the same namespace so that](https://youtu.be/tRxsBGWxowA?t=01h07m28s)

[when you do Services dot you see a list](https://youtu.be/tRxsBGWxowA?t=01h07m31s)

[of namespace that's how they get the](https://youtu.be/tRxsBGWxowA?t=01h07m33s)

[behavior of hey I install a nuget and](https://youtu.be/tRxsBGWxowA?t=01h07m34s)

[now when I do Services dot I have you](https://youtu.be/tRxsBGWxowA?t=01h07m37s)

[know add and service bus right great the](https://youtu.be/tRxsBGWxowA?t=01h07m39s)

[only reason that works is because then](https://youtu.be/tRxsBGWxowA?t=01h07m42s)

[service bus created an extension method](https://youtu.be/tRxsBGWxowA?t=01h07m44s)

[that's inside the common namespace that](https://youtu.be/tRxsBGWxowA?t=01h07m47s)

[everyone that they assume everybody's](https://youtu.be/tRxsBGWxowA?t=01h07m49s)

[already referencing so it just magically](https://youtu.be/tRxsBGWxowA?t=01h07m51s)

[shows up](https://youtu.be/tRxsBGWxowA?t=01h07m53s)

[um](https://youtu.be/tRxsBGWxowA?t=01h07m56s)

[I often find uh not to use hierarchy as](https://youtu.be/tRxsBGWxowA?t=01h07m57s)

[namespace because it's too much typing](https://youtu.be/tRxsBGWxowA?t=01h08m00s)

[and lines of code become too long that](https://youtu.be/tRxsBGWxowA?t=01h08m01s)

[is true and I think namespaces go right](https://youtu.be/tRxsBGWxowA?t=01h08m03s)

[in hand in hand with the the idea of](https://youtu.be/tRxsBGWxowA?t=01h08m06s)

[naming things as hard like I had a](https://youtu.be/tRxsBGWxowA?t=01h08m08s)

[colleague just I think it was yesterday](https://youtu.be/tRxsBGWxowA?t=01h08m11s)

[lament that some new stuff we were](https://youtu.be/tRxsBGWxowA?t=01h08m13s)

[building the namespaces were already](https://youtu.be/tRxsBGWxowA?t=01h08m16s)

[problematic](https://youtu.be/tRxsBGWxowA?t=01h08m18s)

[which points to him he was right](https://youtu.be/tRxsBGWxowA?t=01h08m20s)

[um and then we got to have a good](https://youtu.be/tRxsBGWxowA?t=01h08m23s)

[discussion about what what she we should](https://youtu.be/tRxsBGWxowA?t=01h08m25s)

[change to fix it because I will confess](https://youtu.be/tRxsBGWxowA?t=01h08m27s)

[I was part of the problem so that's on](https://youtu.be/tRxsBGWxowA?t=01h08m30s)

[me the the other thing with namespace to](https://youtu.be/tRxsBGWxowA?t=01h08m32s)

[be aware of](https://youtu.be/tRxsBGWxowA?t=01h08m35s)

[um](https://youtu.be/tRxsBGWxowA?t=01h08m36s)

[yeah horizontal scrolling it is you](https://youtu.be/tRxsBGWxowA?t=01h08m37s)

[don't always have you can think of name](https://youtu.be/tRxsBGWxowA?t=01h08m40s)

[spaces the same way you do like relative](https://youtu.be/tRxsBGWxowA?t=01h08m42s)

[file paths](https://youtu.be/tRxsBGWxowA?t=01h08m44s)

[and so you'll note back here when I type](https://youtu.be/tRxsBGWxowA?t=01h08m46s)

[this out all I typed is validation](https://youtu.be/tRxsBGWxowA?t=01h08m48s)

[and because of the the base namespace](https://youtu.be/tRxsBGWxowA?t=01h08m52s)

[lining up of template demo this is all I](https://youtu.be/tRxsBGWxowA?t=01h08m54s)

[need to disambiguate so](https://youtu.be/tRxsBGWxowA?t=01h08m57s)

[if you if you think of namespaces as](https://youtu.be/tRxsBGWxowA?t=01h09m01s)

[relative paths sometimes that kind of](https://youtu.be/tRxsBGWxowA?t=01h09m03s)

[helps me conceptualize](https://youtu.be/tRxsBGWxowA?t=01h09m05s)

[what's going where or and what all what](https://youtu.be/tRxsBGWxowA?t=01h09m07s)

[I actually need to to do](https://youtu.be/tRxsBGWxowA?t=01h09m11s)

[yeah](https://youtu.be/tRxsBGWxowA?t=01h09m13s)

[I think that's why people have gotten](https://youtu.be/tRxsBGWxowA?t=01h09m15s)

[like those massive you know](https://youtu.be/tRxsBGWxowA?t=01h09m17s)

[60 inch wide monitors is because they](https://youtu.be/tRxsBGWxowA?t=01h09m20s)

[hate horizontal scrolling as well I'm](https://youtu.be/tRxsBGWxowA?t=01h09m22s)

[pretty sure that's the reason for for](https://youtu.be/tRxsBGWxowA?t=01h09m24s)

[massively large monitors](https://youtu.be/tRxsBGWxowA?t=01h09m26s)

[I could be wrong](https://youtu.be/tRxsBGWxowA?t=01h09m28s)

[Hey look it's the brain teaser from](https://youtu.be/tRxsBGWxowA?t=01h09m30s)

[today let's look back to that later](https://youtu.be/tRxsBGWxowA?t=01h09m32s)

[um but yes for anybody who missed it](https://youtu.be/tRxsBGWxowA?t=01h09m37s)

[here's the brain teaser](https://youtu.be/tRxsBGWxowA?t=01h09m39s)

[it's a very simple one the values of a b](https://youtu.be/tRxsBGWxowA?t=01h09m41s)

[and c and then the follow-up question is](https://youtu.be/tRxsBGWxowA?t=01h09m44s)

[always why](https://youtu.be/tRxsBGWxowA?t=01h09m47s)

[because](https://youtu.be/tRxsBGWxowA?t=01h09m48s)

[I'm guessing most people in the chat can](https://youtu.be/tRxsBGWxowA?t=01h09m50s)

[easily type this code and run it and see](https://youtu.be/tRxsBGWxowA?t=01h09m52s)

[the values but then understanding why](https://youtu.be/tRxsBGWxowA?t=01h09m54s)

[the values are that way](https://youtu.be/tRxsBGWxowA?t=01h09m57s)

[so and so far the last three brain](https://youtu.be/tRxsBGWxowA?t=01h09m59s)

[teasers I've done have been courtesy of](https://youtu.be/tRxsBGWxowA?t=01h10m02s)

[me just doing code reviews and finding](https://youtu.be/tRxsBGWxowA?t=01h10m05s)

[them](https://youtu.be/tRxsBGWxowA?t=01h10m07s)

[because sometimes I look down and things](https://youtu.be/tRxsBGWxowA?t=01h10m09s)

[go hang on hang on something doesn't](https://youtu.be/tRxsBGWxowA?t=01h10m10s)

[line up with my internal compiler](https://youtu.be/tRxsBGWxowA?t=01h10m13s)

[and it's because my mental compiler](https://youtu.be/tRxsBGWxowA?t=01h10m16s)

[doesn't work or it doesn't work](https://youtu.be/tRxsBGWxowA?t=01h10m18s)

[appropriately okay so I'm gonna move](https://youtu.be/tRxsBGWxowA?t=01h10m20s)

[this and I realize I named these](https://youtu.be/tRxsBGWxowA?t=01h10m23s)

[resource dictionaries dumbly because I](https://youtu.be/tRxsBGWxowA?t=01h10m26s)

[called this colors and I'm going to put](https://youtu.be/tRxsBGWxowA?t=01h10m28s)

[a brush in it](https://youtu.be/tRxsBGWxowA?t=01h10m29s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h10m32s)

[uh see I think a equals doubt b equals](https://youtu.be/tRxsBGWxowA?t=01h10m34s)

[Min value C equals max value](https://youtu.be/tRxsBGWxowA?t=01h10m37s)

[interesting](https://youtu.be/tRxsBGWxowA?t=01h10m40s)

[uh I lost my place](https://youtu.be/tRxsBGWxowA?t=01h10m44s)

[wish there was a way for me to](https://youtu.be/tRxsBGWxowA?t=01h10m53s)

[oh I know I can hang on hang on I got](https://youtu.be/tRxsBGWxowA?t=01h10m56s)

[this i got this I got this uh let's see](https://youtu.be/tRxsBGWxowA?t=01h10m59s)

[at existing](https://youtu.be/tRxsBGWxowA?t=01h11m02s)

[put it right above my head for now](https://youtu.be/tRxsBGWxowA?t=01h11m09s)

[there](https://youtu.be/tRxsBGWxowA?t=01h11m11s)

[leave it there for anybody who wants to](https://youtu.be/tRxsBGWxowA?t=01h11m13s)

[poke their head at it](https://youtu.be/tRxsBGWxowA?t=01h11m14s)

[yeah so get date time is a local](https://youtu.be/tRxsBGWxowA?t=01h11m18s)

[function inside](https://youtu.be/tRxsBGWxowA?t=01h11m20s)

[it is a fun one because there's there's](https://youtu.be/tRxsBGWxowA?t=01h11m26s)

[two separate cop](https://youtu.be/tRxsBGWxowA?t=01h11m28s)

[um on subset play](https://youtu.be/tRxsBGWxowA?t=01h11m30s)

[though I did realize when I was showing](https://youtu.be/tRxsBGWxowA?t=01h11m33s)

[this to several colleagues that uh not](https://youtu.be/tRxsBGWxowA?t=01h11m34s)

[everybody](https://youtu.be/tRxsBGWxowA?t=01h11m37s)

[some people it's weird to me that](https://youtu.be/tRxsBGWxowA?t=01h11m39s)

[certain aspects of the c-sharp language](https://youtu.be/tRxsBGWxowA?t=01h11m41s)

[some people just go oh yeah that makes](https://youtu.be/tRxsBGWxowA?t=01h11m43s)

[perfect sense and other ones just miss](https://youtu.be/tRxsBGWxowA?t=01h11m44s)

[and I'm trying to not say which Concepts](https://youtu.be/tRxsBGWxowA?t=01h11m49s)

[to avoid spoiling things but](https://youtu.be/tRxsBGWxowA?t=01h11m51s)

[I the the ones that I find that people](https://youtu.be/tRxsBGWxowA?t=01h11m53s)

[just intrinsically think oh yeah of](https://youtu.be/tRxsBGWxowA?t=01h11m56s)

[course it works that way those are the](https://youtu.be/tRxsBGWxowA?t=01h11m58s)

[best features](https://youtu.be/tRxsBGWxowA?t=01h11m59s)

[that means you hit the mark on the head](https://youtu.be/tRxsBGWxowA?t=01h12m01s)

[C sharp team](https://youtu.be/tRxsBGWxowA?t=01h12m03s)

[okay and we didn't move the brush in so](https://youtu.be/tRxsBGWxowA?t=01h12m04s)

[I want to do this](https://youtu.be/tRxsBGWxowA?t=01h12m07s)

[actually I want both of these lines](https://youtu.be/tRxsBGWxowA?t=01h12m10s)

[lapse that up and then we're gonna do](https://youtu.be/tRxsBGWxowA?t=01h12m14s)

[brushes we're gonna do this so I think](https://youtu.be/tRxsBGWxowA?t=01h12m16s)

[what I want to do](https://youtu.be/tRxsBGWxowA?t=01h12m19s)

[and I don't really want this one I want](https://youtu.be/tRxsBGWxowA?t=01h12m21s)

[this line instead](https://youtu.be/tRxsBGWxowA?t=01h12m23s)

[just realized I don't have Karnak](https://youtu.be/tRxsBGWxowA?t=01h12m26s)

[running](https://youtu.be/tRxsBGWxowA?t=01h12m27s)

[clean that up](https://youtu.be/tRxsBGWxowA?t=01h12m29s)

[um](https://youtu.be/tRxsBGWxowA?t=01h12m32s)

[so we've got that we've got that and now](https://youtu.be/tRxsBGWxowA?t=01h12m33s)

[both brushes because the designer should](https://youtu.be/tRxsBGWxowA?t=01h12m35s)

[just be working](https://youtu.be/tRxsBGWxowA?t=01h12m39s)

[um](https://youtu.be/tRxsBGWxowA?t=01h12m41s)

[uh oh it's not going to work because I](https://youtu.be/tRxsBGWxowA?t=01h12m45s)

[didn't reference either of those](https://youtu.be/tRxsBGWxowA?t=01h12m48s)

[resource dictionaries now my assumption](https://youtu.be/tRxsBGWxowA?t=01h12m49s)

[being that I can very easily](https://youtu.be/tRxsBGWxowA?t=01h12m52s)

[resource dictionary source and I I think](https://youtu.be/tRxsBGWxowA?t=01h12m55s)

[I should be able to get away with going](https://youtu.be/tRxsBGWxowA?t=01h12m59s)

[uh the uh let's see](https://youtu.be/tRxsBGWxowA?t=01h13m01s)

[beam brushes](https://youtu.be/tRxsBGWxowA?t=01h13m05s)

[example](https://youtu.be/tRxsBGWxowA?t=01h13m09s)

[oh I'm sorry copilot you were right and](https://youtu.be/tRxsBGWxowA?t=01h13m11s)

[I didn't listen to you I apologize](https://youtu.be/tRxsBGWxowA?t=01h13m13s)

[please forgive me](https://youtu.be/tRxsBGWxowA?t=01h13m14s)

[you are you are great and always right](https://youtu.be/tRxsBGWxowA?t=01h13m16s)

[Copilot](https://youtu.be/tRxsBGWxowA?t=01h13m18s)

[uh okay now if we build I think that](https://youtu.be/tRxsBGWxowA?t=01h13m19s)

[works oh it doesn't work yet](https://youtu.be/tRxsBGWxowA?t=01h13m22s)

[next was less than the size of the](https://youtu.be/tRxsBGWxowA?t=01h13m25s)

[collection](https://youtu.be/tRxsBGWxowA?t=01h13m27s)

[that's an interesting error that's not](https://youtu.be/tRxsBGWxowA?t=01h13m28s)

[the error I would expect](https://youtu.be/tRxsBGWxowA?t=01h13m30s)

[that's a very interesting error and then](https://youtu.be/tRxsBGWxowA?t=01h13m37s)

[the only reason I say it's not the error](https://youtu.be/tRxsBGWxowA?t=01h13m40s)

[I expect is because I would have](https://youtu.be/tRxsBGWxowA?t=01h13m42s)

[expected it to say like unknown key](https://youtu.be/tRxsBGWxowA?t=01h13m44s)

[because I'm I'm straight up referencing](https://youtu.be/tRxsBGWxowA?t=01h13m46s)

[a key that it doesn't know anything](https://youtu.be/tRxsBGWxowA?t=01h13m47s)

[about so I](https://youtu.be/tRxsBGWxowA?t=01h13m49s)

[I would expect it to do that but okay](https://youtu.be/tRxsBGWxowA?t=01h13m51s)

[and then you have to reference the theme](https://youtu.be/tRxsBGWxowA?t=01h13m55s)

[colors](https://youtu.be/tRxsBGWxowA?t=01h14m00s)

[dot xaml](https://youtu.be/tRxsBGWxowA?t=01h14m02s)

[I think](https://youtu.be/tRxsBGWxowA?t=01h14m04s)

[I think that's what we want there](https://youtu.be/tRxsBGWxowA?t=01h14m07s)

[now you should not fail](https://youtu.be/tRxsBGWxowA?t=01h14m10s)

[unknown build air index was outside of](https://youtu.be/tRxsBGWxowA?t=01h14m14s)

[range what the heck have I done](https://youtu.be/tRxsBGWxowA?t=01h14m17s)

[so let's let's do this](https://youtu.be/tRxsBGWxowA?t=01h14m24s)

[I do that are you happy now](https://youtu.be/tRxsBGWxowA?t=01h14m27s)

[oh interesting so I can't separate](https://youtu.be/tRxsBGWxowA?t=01h14m33s)

[um so if I do this](https://youtu.be/tRxsBGWxowA?t=01h14m43s)

[ah see this is why I wanted to test this](https://youtu.be/tRxsBGWxowA?t=01h14m51s)

[because I wasn't sure if I could get](https://youtu.be/tRxsBGWxowA?t=01h14m53s)

[away with something like this](https://youtu.be/tRxsBGWxowA?t=01h14m55s)

[um so this static resource trick is not](https://youtu.be/tRxsBGWxowA?t=01h14m58s)

[hip](https://youtu.be/tRxsBGWxowA?t=01h15m02s)

[if I do this](https://youtu.be/tRxsBGWxowA?t=01h15m05s)

[oh thank you for the subscription](https://youtu.be/tRxsBGWxowA?t=01h15m07s)

[appreciate it Darko](https://youtu.be/tRxsBGWxowA?t=01h15m10s)

[but it's okay if I put it there because](https://youtu.be/tRxsBGWxowA?t=01h15m13s)

[it finds it](https://youtu.be/tRxsBGWxowA?t=01h15m15s)

[interesting so I](https://youtu.be/tRxsBGWxowA?t=01h15m17s)

[you definitely deserved it](https://youtu.be/tRxsBGWxowA?t=01h15m21s)

[well thank you I try I definitely a uh](https://youtu.be/tRxsBGWxowA?t=01h15m23s)

[by all means I love questions I I come](https://youtu.be/tRxsBGWxowA?t=01h15m27s)

[on here to stream and I usually have an](https://youtu.be/tRxsBGWxowA?t=01h15m29s)

[idea in my head about what I want to](https://youtu.be/tRxsBGWxowA?t=01h15m32s)

[work on](https://youtu.be/tRxsBGWxowA?t=01h15m33s)

[and mostly that's the the filler work](https://youtu.be/tRxsBGWxowA?t=01h15m35s)

[unless people have questions or I get](https://youtu.be/tRxsBGWxowA?t=01h15m38s)

[distracted on stuff because I](https://youtu.be/tRxsBGWxowA?t=01h15m40s)

[I definitely don't mind I I definitely](https://youtu.be/tRxsBGWxowA?t=01h15m43s)

[don't mind going into questions for](https://youtu.be/tRxsBGWxowA?t=01h15m45s)

[things](https://youtu.be/tRxsBGWxowA?t=01h15m46s)

[um](https://youtu.be/tRxsBGWxowA?t=01h15m49s)

[though](https://youtu.be/tRxsBGWxowA?t=01h15m50s)

[small self-promotion uh if people want](https://youtu.be/tRxsBGWxowA?t=01h15m51s)

[to follow on YouTube I I am hoping to](https://youtu.be/tRxsBGWxowA?t=01h15m54s)

[start putting together](https://youtu.be/tRxsBGWxowA?t=01h15m57s)

[um some shorter videos specifically with](https://youtu.be/tRxsBGWxowA?t=01h15m58s)

[just these brain teasers in them I was](https://youtu.be/tRxsBGWxowA?t=01h16m01s)

[figuring those could be a simple little](https://youtu.be/tRxsBGWxowA?t=01h16m03s)

[five minute ones that are easy where](https://youtu.be/tRxsBGWxowA?t=01h16m05s)

[people can drop in see the problem I'll](https://youtu.be/tRxsBGWxowA?t=01h16m07s)

[explain it you can pause and try to try](https://youtu.be/tRxsBGWxowA?t=01h16m10s)

[to think through it before I give you](https://youtu.be/tRxsBGWxowA?t=01h16m13s)

[the answer and walk through it because I](https://youtu.be/tRxsBGWxowA?t=01h16m15s)

[personally absolutely love these types](https://youtu.be/tRxsBGWxowA?t=01h16m17s)

[of little coding brain teasers I love](https://youtu.be/tRxsBGWxowA?t=01h16m20s)

[when I see them come up on like Twitter](https://youtu.be/tRxsBGWxowA?t=01h16m22s)

[and whatnot from different people they](https://youtu.be/tRxsBGWxowA?t=01h16m24s)

[are amazing](https://youtu.be/tRxsBGWxowA?t=01h16m25s)

[um](https://youtu.be/tRxsBGWxowA?t=01h16m27s)

[but I also fully acknowledge that I am](https://youtu.be/tRxsBGWxowA?t=01h16m28s)

[weird and I should not consider myself](https://youtu.be/tRxsBGWxowA?t=01h16m31s)

[the standard use case](https://youtu.be/tRxsBGWxowA?t=01h16m33s)

[um okay so that is perfectly interesting](https://youtu.be/tRxsBGWxowA?t=01h16m37s)

[so it's it's okay if I do that](https://youtu.be/tRxsBGWxowA?t=01h16m40s)

[it's okay if I do that is it okay if I](https://youtu.be/tRxsBGWxowA?t=01h16m44s)

[do](https://youtu.be/tRxsBGWxowA?t=01h16m47s)

[it's all it's also okay if I do that](https://youtu.be/tRxsBGWxowA?t=01h16m50s)

[it's just not okay if I end up](https://youtu.be/tRxsBGWxowA?t=01h16m53s)

[specifying it okay so](https://youtu.be/tRxsBGWxowA?t=01h16m58s)

[if that's the case](https://youtu.be/tRxsBGWxowA?t=01h17m01s)

[if that's the case can I get away with](https://youtu.be/tRxsBGWxowA?t=01h17m03s)

[so this is other](https://youtu.be/tRxsBGWxowA?t=01h17m09s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h17m14s)

[uh the 1970 1970 1901.](https://youtu.be/tRxsBGWxowA?t=01h17m16s)

[uh let's see](https://youtu.be/tRxsBGWxowA?t=01h17m21s)

[now I have to now I have to go back and](https://youtu.be/tRxsBGWxowA?t=01h17m29s)

[relook at my own problem and remember so](https://youtu.be/tRxsBGWxowA?t=01h17m30s)

[let's see so null is the first parameter](https://youtu.be/tRxsBGWxowA?t=01h17m33s)

[so](https://youtu.be/tRxsBGWxowA?t=01h17m35s)

[you know](https://youtu.be/tRxsBGWxowA?t=01h17m36s)

[there](https://youtu.be/tRxsBGWxowA?t=01h17m38s)

[I can tell you I I can tell you right](https://youtu.be/tRxsBGWxowA?t=01h17m40s)

[away 1901 is incorrect](https://youtu.be/tRxsBGWxowA?t=01h17m43s)

[you shouldn't get a 1901 for the year on](https://youtu.be/tRxsBGWxowA?t=01h17m46s)

[any of them](https://youtu.be/tRxsBGWxowA?t=01h17m48s)

[uh all of them are default](https://youtu.be/tRxsBGWxowA?t=01h17m50s)

[and this this is why these problems are](https://youtu.be/tRxsBGWxowA?t=01h17m57s)

[great because it has been distilled down](https://youtu.be/tRxsBGWxowA?t=01h17m59s)

[into just a handful like whenever I do](https://youtu.be/tRxsBGWxowA?t=01h18m02s)

[the brain teasers typically I find these](https://youtu.be/tRxsBGWxowA?t=01h18m04s)

[things in code reviews and they're Sur](https://youtu.be/tRxsBGWxowA?t=01h18m06s)

[and it's usually amongst this big](https://youtu.be/tRxsBGWxowA?t=01h18m08s)

[function and lots of stuff going on and](https://youtu.be/tRxsBGWxowA?t=01h18m10s)

[yada yada yada yada and it's I try to](https://youtu.be/tRxsBGWxowA?t=01h18m12s)

[see how tightly I can distill it down](https://youtu.be/tRxsBGWxowA?t=01h18m15s)

[because there's something elegant when](https://youtu.be/tRxsBGWxowA?t=01h18m17s)

[you can get the problem down to just one](https://youtu.be/tRxsBGWxowA?t=01h18m20s)

[or two lines](https://youtu.be/tRxsBGWxowA?t=01h18m22s)

[um to specifically show off what the](https://youtu.be/tRxsBGWxowA?t=01h18m24s)

[problem is](https://youtu.be/tRxsBGWxowA?t=01h18m26s)

[so hang on if I do](https://youtu.be/tRxsBGWxowA?t=01h18m27s)

[this](https://youtu.be/tRxsBGWxowA?t=01h18m30s)

[that renders red](https://youtu.be/tRxsBGWxowA?t=01h18m32s)

[and if I just straight up comment this](https://youtu.be/tRxsBGWxowA?t=01h18m39s)

[out](https://youtu.be/tRxsBGWxowA?t=01h18m41s)

[it falls back oh interesting](https://youtu.be/tRxsBGWxowA?t=01h18m44s)

[great brain teasers every stream things](https://youtu.be/tRxsBGWxowA?t=01h18m46s)

[no problem it was actually uh a](https://youtu.be/tRxsBGWxowA?t=01h18m49s)

[colleague of mine when I was posting out](https://youtu.be/tRxsBGWxowA?t=01h18m52s)

[brain teasers because I've got just a](https://youtu.be/tRxsBGWxowA?t=01h18m54s)

[running teams chat with a](https://youtu.be/tRxsBGWxowA?t=01h18m57s)

[the a group of different uh people that](https://youtu.be/tRxsBGWxowA?t=01h19m00s)

[I've worked on on different projects](https://youtu.be/tRxsBGWxowA?t=01h19m03s)

[and the the chat is mostly around](https://youtu.be/tRxsBGWxowA?t=01h19m05s)

[sharing memes and gifts but I will throw](https://youtu.be/tRxsBGWxowA?t=01h19m08s)

[brain teasers in every so often](https://youtu.be/tRxsBGWxowA?t=01h19m10s)

[um](https://youtu.be/tRxsBGWxowA?t=01h19m13s)

[and his comment was he's like you know](https://youtu.be/tRxsBGWxowA?t=01h19m15s)

[you should you should post those up on](https://youtu.be/tRxsBGWxowA?t=01h19m17s)

[your stream I think people would love](https://youtu.be/tRxsBGWxowA?t=01h19m18s)

[them I'm like hey sure we'll give it a](https://youtu.be/tRxsBGWxowA?t=01h19m19s)

[try and so far people seem to to enjoy](https://youtu.be/tRxsBGWxowA?t=01h19m21s)

[them](https://youtu.be/tRxsBGWxowA?t=01h19m24s)

[interesting Okay so](https://youtu.be/tRxsBGWxowA?t=01h19m25s)

[if I just do this and generate out the](https://youtu.be/tRxsBGWxowA?t=01h19m29s)

[resource dictionaries this way](https://youtu.be/tRxsBGWxowA?t=01h19m33s)

[what I really should end up doing](https://youtu.be/tRxsBGWxowA?t=01h19m42s)

[if I just generate one big resource](https://youtu.be/tRxsBGWxowA?t=01h19m49s)

[dictionary](https://youtu.be/tRxsBGWxowA?t=01h19m52s)

[that has](https://youtu.be/tRxsBGWxowA?t=01h19m55s)

[color brush](https://youtu.be/tRxsBGWxowA?t=01h19m57s)

[aliases](https://youtu.be/tRxsBGWxowA?t=01h19m59s)

[then all anyone has to do to change one](https://youtu.be/tRxsBGWxowA?t=01h20m01s)

[of these things out is change out the](https://youtu.be/tRxsBGWxowA?t=01h20m04s)

[alias now what happens](https://youtu.be/tRxsBGWxowA?t=01h20m07s)

[what happens if rather than doing other](https://youtu.be/tRxsBGWxowA?t=01h20m11s)

[I do primary here I think I know what](https://youtu.be/tRxsBGWxowA?t=01h20m14s)

[happens](https://youtu.be/tRxsBGWxowA?t=01h20m16s)

[right so that's swapping to primary I'm](https://youtu.be/tRxsBGWxowA?t=01h20m20s)

[but I'm curious how that ends up doing](https://youtu.be/tRxsBGWxowA?t=01h20m22s)

[the resolution](https://youtu.be/tRxsBGWxowA?t=01h20m24s)

[that's interesting](https://youtu.be/tRxsBGWxowA?t=01h20m29s)

[yeah no I I love the discussion I like](https://youtu.be/tRxsBGWxowA?t=01h20m44s)

[seeing how people think in a per and](https://youtu.be/tRxsBGWxowA?t=01h20m47s)

[approach the the problems too](https://youtu.be/tRxsBGWxowA?t=01h20m49s)

[like I said I every time I see one I](https://youtu.be/tRxsBGWxowA?t=01h20m52s)

[always take the brain teasers and I I](https://youtu.be/tRxsBGWxowA?t=01h20m55s)

[always try to go through and like either](https://youtu.be/tRxsBGWxowA?t=01h20m57s)

[verbally speak out loud what I think the](https://youtu.be/tRxsBGWxowA?t=01h20m59s)

[answer is or write it down because](https://youtu.be/tRxsBGWxowA?t=01h21m01s)

[otherwise if I just kind of think at my](https://youtu.be/tRxsBGWxowA?t=01h21m03s)

[head I get into that state where I lie](https://youtu.be/tRxsBGWxowA?t=01h21m05s)

[to myself it's like oh yeah I totally](https://youtu.be/tRxsBGWxowA?t=01h21m08s)

[got that one it's like did you are you](https://youtu.be/tRxsBGWxowA?t=01h21m10s)

[being honest with yourself and only](https://youtu.be/tRxsBGWxowA?t=01h21m13s)

[about half the time am I being honest](https://youtu.be/tRxsBGWxowA?t=01h21m15s)

[with myself](https://youtu.be/tRxsBGWxowA?t=01h21m16s)

[I think I like this I think I like this](https://youtu.be/tRxsBGWxowA?t=01h21m18s)

[so I think what I want to do](https://youtu.be/tRxsBGWxowA?t=01h21m22s)

[okay so for the material design Library](https://youtu.be/tRxsBGWxowA?t=01h21m28s)

[I think this is what I want I want to](https://youtu.be/tRxsBGWxowA?t=01h21m31s)

[generate a resource dictionary with uh](https://youtu.be/tRxsBGWxowA?t=01h21m34s)

[theme colors](https://youtu.be/tRxsBGWxowA?t=01h21m37s)

[right](https://youtu.be/tRxsBGWxowA?t=01h21m40s)

[under the hood I then want what I will](https://youtu.be/tRxsBGWxowA?t=01h21m41s)

[call primary](https://youtu.be/tRxsBGWxowA?t=01h21m45s)

[uh primary brushes](https://youtu.be/tRxsBGWxowA?t=01h21m46s)

[basically uh](https://youtu.be/tRxsBGWxowA?t=01h21m49s)

[uh one to one with colors](https://youtu.be/tRxsBGWxowA?t=01h21m51s)

[and then](https://youtu.be/tRxsBGWxowA?t=01h21m55s)

[what I then want to do](https://youtu.be/tRxsBGWxowA?t=01h21m56s)

[uh brush aliases](https://youtu.be/tRxsBGWxowA?t=01h21m59s)

[uh uh with](https://youtu.be/tRxsBGWxowA?t=01h22m02s)

[all of the individualized aliases for](https://youtu.be/tRxsBGWxowA?t=01h22m06s)

[the brushes on the individual control so](https://youtu.be/tRxsBGWxowA?t=01h22m09s)

[going back to where](https://youtu.be/tRxsBGWxowA?t=01h22m12s)

[started if I can](https://youtu.be/tRxsBGWxowA?t=01h22m15s)

[this guy here](https://youtu.be/tRxsBGWxowA?t=01h22m17s)

[if anybody's interested](https://youtu.be/tRxsBGWxowA?t=01h22m20s)

[so](https://youtu.be/tRxsBGWxowA?t=01h22m22s)

[all of these here](https://youtu.be/tRxsBGWxowA?t=01h22m26s)

[but at the end of the day I want to go](https://youtu.be/tRxsBGWxowA?t=01h22m29s)

[through each control](https://youtu.be/tRxsBGWxowA?t=01h22m31s)

[and generate out the brushes that they](https://youtu.be/tRxsBGWxowA?t=01h22m33s)

[need for it](https://youtu.be/tRxsBGWxowA?t=01h22m36s)

[now if I get really fancy](https://youtu.be/tRxsBGWxowA?t=01h22m38s)

[I generate the list of brushes](https://youtu.be/tRxsBGWxowA?t=01h22m41s)

[that's if I get really faints](https://youtu.be/tRxsBGWxowA?t=01h22m44s)

[because it would be really cool](https://youtu.be/tRxsBGWxowA?t=01h22m47s)

[if I didn't have to know about all of](https://youtu.be/tRxsBGWxowA?t=01h22m50s)

[them](https://youtu.be/tRxsBGWxowA?t=01h22m54s)

[though I guess if I do that I break the](https://youtu.be/tRxsBGWxowA?t=01h22m56s)

[visual studio tooling and that's](https://youtu.be/tRxsBGWxowA?t=01h22m59s)

[probably worse](https://youtu.be/tRxsBGWxowA?t=01h23m00s)

[that would be bad](https://youtu.be/tRxsBGWxowA?t=01h23m03s)

[that would be bad I wonder can I do okay](https://youtu.be/tRxsBGWxowA?t=01h23m09s)

[now now I want to test some things I](https://youtu.be/tRxsBGWxowA?t=01h23m13s)

[wonder can I get away with](https://youtu.be/tRxsBGWxowA?t=01h23m16s)

[uh yo yeah you'll do](https://youtu.be/tRxsBGWxowA?t=01h23m19s)

[uh public](https://youtu.be/tRxsBGWxowA?t=01h23m22s)

[blast my](https://youtu.be/tRxsBGWxowA?t=01h23m25s)

[Dynamic resource](https://youtu.be/tRxsBGWxowA?t=01h23m28s)

[uh Dynamic resource so](https://youtu.be/tRxsBGWxowA?t=01h23m30s)

[um](https://youtu.be/tRxsBGWxowA?t=01h23m35s)

[can I do this](https://youtu.be/tRxsBGWxowA?t=01h23m36s)

[can I](https://youtu.be/tRxsBGWxowA?t=01h23m39s)

[I think I can get away with this](https://youtu.be/tRxsBGWxowA?t=01h23m46s)

[I think I can get away with this](https://youtu.be/tRxsBGWxowA?t=01h23m50s)

[because I don't need it to do anything](https://youtu.be/tRxsBGWxowA?t=01h23m58s)

[special](https://youtu.be/tRxsBGWxowA?t=01h24m00s)

[I'm just so here's here's my here's my](https://youtu.be/tRxsBGWxowA?t=01h24m02s)

[crazy idea crazy idea so](https://youtu.be/tRxsBGWxowA?t=01h24m04s)

[imagine these brushes like these brushes](https://youtu.be/tRxsBGWxowA?t=01h24m07s)

[are just sitting in Main window.xaml in](https://youtu.be/tRxsBGWxowA?t=01h24m10s)

[an app](https://youtu.be/tRxsBGWxowA?t=01h24m12s)

[but imagine instead that these brushes](https://youtu.be/tRxsBGWxowA?t=01h24m14s)

[are](https://youtu.be/tRxsBGWxowA?t=01h24m16s)

[why is](https://youtu.be/tRxsBGWxowA?t=01h24m17s)

[my machine has been giving me nothing](https://youtu.be/tRxsBGWxowA?t=01h24m19s)

[but problems](https://youtu.be/tRxsBGWxowA?t=01h24m21s)

[and I don't understand it's like Windows](https://youtu.be/tRxsBGWxowA?t=01h24m24s)

[Explorer has decided it hates me uh but](https://youtu.be/tRxsBGWxowA?t=01h24m26s)

[imagine these brushes instead are inside](https://youtu.be/tRxsBGWxowA?t=01h24m28s)

[of I don't know chip right](https://youtu.be/tRxsBGWxowA?t=01h24m31s)

[uh where is a dynamic resource in here](https://youtu.be/tRxsBGWxowA?t=01h24m37s)

[come on](https://youtu.be/tRxsBGWxowA?t=01h24m40s)

[everyone](https://youtu.be/tRxsBGWxowA?t=01h24m41s)

[Dynamic these ones so imagine instead](https://youtu.be/tRxsBGWxowA?t=01h24m42s)

[that they were here because my thought](https://youtu.be/tRxsBGWxowA?t=01h24m45s)

[is it would be pretty cool](https://youtu.be/tRxsBGWxowA?t=01h24m48s)

[I guess I could I could I could still](https://youtu.be/tRxsBGWxowA?t=01h24m52s)

[hunt out the list of brushes just by](https://youtu.be/tRxsBGWxowA?t=01h24m54s)

[ripping through](https://youtu.be/tRxsBGWxowA?t=01h24m57s)

[all of the styles](https://youtu.be/tRxsBGWxowA?t=01h24m59s)

[looking for anything that was a dynamic](https://youtu.be/tRxsBGWxowA?t=01h25m02s)

[resource that started with material](https://youtu.be/tRxsBGWxowA?t=01h25m05s)

[design dot for the key](https://youtu.be/tRxsBGWxowA?t=01h25m06s)

[and then I could automatically pick it](https://youtu.be/tRxsBGWxowA?t=01h25m09s)

[up](https://youtu.be/tRxsBGWxowA?t=01h25m11s)

[because that would be pretty slick](https://youtu.be/tRxsBGWxowA?t=01h25m13s)

[not gonna lie that would be slick](https://youtu.be/tRxsBGWxowA?t=01h25m17s)

[because it would be pretty cool](https://youtu.be/tRxsBGWxowA?t=01h25m22s)

[if just by adding it to the the template](https://youtu.be/tRxsBGWxowA?t=01h25m25s)

[we could generate that out so the reason](https://youtu.be/tRxsBGWxowA?t=01h25m29s)

[I I like that idea or why I want to know](https://youtu.be/tRxsBGWxowA?t=01h25m31s)

[about all of these brushes is right now](https://youtu.be/tRxsBGWxowA?t=01h25m35s)

[we have this eye theme class](https://youtu.be/tRxsBGWxowA?t=01h25m37s)

[because one thing that I have noticed is](https://youtu.be/tRxsBGWxowA?t=01h25m40s)

[that people](https://youtu.be/tRxsBGWxowA?t=01h25m43s)

[some people like editing their stuff in](https://youtu.be/tRxsBGWxowA?t=01h25m45s)

[xaml and some people like doing it in C](https://youtu.be/tRxsBGWxowA?t=01h25m47s)

[sharp](https://youtu.be/tRxsBGWxowA?t=01h25m50s)

[and especially when it comes to doing](https://youtu.be/tRxsBGWxowA?t=01h25m51s)

[logicy things like hey the user changed](https://youtu.be/tRxsBGWxowA?t=01h25m53s)

[their theme I would like to change just](https://youtu.be/tRxsBGWxowA?t=01h25m56s)

[part of it right some people want to](https://youtu.be/tRxsBGWxowA?t=01h25m58s)

[write a xaml file](https://youtu.be/tRxsBGWxowA?t=01h26m01s)

[and apparently I can't do that some](https://youtu.be/tRxsBGWxowA?t=01h26m03s)

[people want to write a xaml file like](https://youtu.be/tRxsBGWxowA?t=01h26m05s)

[this that just overrides a brush](https://youtu.be/tRxsBGWxowA?t=01h26m06s)

[and some people prefer to say no no just](https://youtu.be/tRxsBGWxowA?t=01h26m09s)

[give me the theme object I'm going to go](https://youtu.be/tRxsBGWxowA?t=01h26m11s)

[through and set the colors I care about](https://youtu.be/tRxsBGWxowA?t=01h26m13s)

[and away we go](https://youtu.be/tRxsBGWxowA?t=01h26m16s)

[right and this thing this lovely little](https://youtu.be/tRxsBGWxowA?t=01h26m17s)

[guy here there's also some extension](https://youtu.be/tRxsBGWxowA?t=01h26m20s)

[methods so that you can just say like](https://youtu.be/tRxsBGWxowA?t=01h26m21s)

[set primary set whatever](https://youtu.be/tRxsBGWxowA?t=01h26m23s)

[and it populates all the things](https://youtu.be/tRxsBGWxowA?t=01h26m25s)

[so I wanna like I don't want to break](https://youtu.be/tRxsBGWxowA?t=01h26m28s)

[that](https://youtu.be/tRxsBGWxowA?t=01h26m30s)

[conceptually because that's nice](https://youtu.be/tRxsBGWxowA?t=01h26m31s)

[but I kind of like the idea of](https://youtu.be/tRxsBGWxowA?t=01h26m34s)

[having something that'll just rip](https://youtu.be/tRxsBGWxowA?t=01h26m38s)

[through all of these Styles and](https://youtu.be/tRxsBGWxowA?t=01h26m40s)

[appropriately generate that because if I](https://youtu.be/tRxsBGWxowA?t=01h26m43s)

[have to build](https://youtu.be/tRxsBGWxowA?t=01h26m46s)

[resource dictionaries that look like](https://youtu.be/tRxsBGWxowA?t=01h26m49s)

[this now admittedly I've done this in](https://youtu.be/tRxsBGWxowA?t=01h26m51s)

[three lines but this is likely going to](https://youtu.be/tRxsBGWxowA?t=01h26m54s)

[be something like 300 lines when we're](https://youtu.be/tRxsBGWxowA?t=01h26m56s)

[done because](https://youtu.be/tRxsBGWxowA?t=01h26m59s)

[the the number of colors won't be big](https://youtu.be/tRxsBGWxowA?t=01h27m00s)

[it'll be in the like I think eight to](https://youtu.be/tRxsBGWxowA?t=01h27m02s)

[ten range](https://youtu.be/tRxsBGWxowA?t=01h27m05s)

[right because I've got three primary](https://youtu.be/tRxsBGWxowA?t=01h27m07s)

[three secondary](https://youtu.be/tRxsBGWxowA?t=01h27m10s)

[which is six and then probably maybe up](https://youtu.be/tRxsBGWxowA?t=01h27m12s)

[to maybe about a dozen I think that](https://youtu.be/tRxsBGWxowA?t=01h27m15s)

[there's probably because there's gonna](https://youtu.be/tRxsBGWxowA?t=01h27m16s)

[be like validation color there's going](https://youtu.be/tRxsBGWxowA?t=01h27m17s)

[to be the Shadow and the separator](https://youtu.be/tRxsBGWxowA?t=01h27m19s)

[there's going to be like I think in any](https://youtu.be/tRxsBGWxowA?t=01h27m21s)

[given theme a](https://youtu.be/tRxsBGWxowA?t=01h27m23s)

[10 to 12 maybe colors then the primary](https://youtu.be/tRxsBGWxowA?t=01h27m26s)

[brushes are going to mirror those so 10](https://youtu.be/tRxsBGWxowA?t=01h27m29s)

[to 12 there and then the aliases are](https://youtu.be/tRxsBGWxowA?t=01h27m31s)

[going to be a gazillion](https://youtu.be/tRxsBGWxowA?t=01h27m33s)

[because in an ideal world I want to be](https://youtu.be/tRxsBGWxowA?t=01h27m36s)

[able to have individual brushes for each](https://youtu.be/tRxsBGWxowA?t=01h27m39s)

[template](https://youtu.be/tRxsBGWxowA?t=01h27m41s)

[so that if somebody says Hey I want to](https://youtu.be/tRxsBGWxowA?t=01h27m43s)

[edit my text box templates they can do](https://youtu.be/tRxsBGWxowA?t=01h27m45s)

[that oh that's what I wanted to check](https://youtu.be/tRxsBGWxowA?t=01h27m48s)

[can I chain these things together](https://youtu.be/tRxsBGWxowA?t=01h27m50s)

[right so if I make you other](https://youtu.be/tRxsBGWxowA?t=01h27m53s)

[and I make you other two](https://youtu.be/tRxsBGWxowA?t=01h27m57s)

[right what happens](https://youtu.be/tRxsBGWxowA?t=01h28m00s)

[here](https://youtu.be/tRxsBGWxowA?t=01h28m02s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h28m06s)

[do you still work](https://youtu.be/tRxsBGWxowA?t=01h28m11s)

[or do you not work](https://youtu.be/tRxsBGWxowA?t=01h28m13s)

[like I can see already the daisy](https://youtu.be/tRxsBGWxowA?t=01h28m15s)

[chaining breaks it but](https://youtu.be/tRxsBGWxowA?t=01h28m17s)

[I should make these things smaller I](https://youtu.be/tRxsBGWxowA?t=01h28m21s)

[don't need them to be](https://youtu.be/tRxsBGWxowA?t=01h28m23s)

[actually](https://youtu.be/tRxsBGWxowA?t=01h28m25s)

[uh let's do that boom](https://youtu.be/tRxsBGWxowA?t=01h28m28s)

[so I can daisy chain them together](https://youtu.be/tRxsBGWxowA?t=01h28m32s)

[that's convenient](https://youtu.be/tRxsBGWxowA?t=01h28m34s)

[the only thing that's mildly](https://youtu.be/tRxsBGWxowA?t=01h28m36s)

[inconvenient about it](https://youtu.be/tRxsBGWxowA?t=01h28m38s)

[is if you replace the one in the middle](https://youtu.be/tRxsBGWxowA?t=01h28m40s)

[it doesn't propagate down](https://youtu.be/tRxsBGWxowA?t=01h28m42s)

[so for example other two depends on](https://youtu.be/tRxsBGWxowA?t=01h28m45s)

[other which depends so yeah other two](https://youtu.be/tRxsBGWxowA?t=01h28m48s)

[depends on other other depends on](https://youtu.be/tRxsBGWxowA?t=01h28m50s)

[primary primary depends on color right](https://youtu.be/tRxsBGWxowA?t=01h28m52s)

[so we've got four layers in here](https://youtu.be/tRxsBGWxowA?t=01h28m55s)

[the issue being](https://youtu.be/tRxsBGWxowA?t=01h28m58s)

[I don't think I can do](https://youtu.be/tRxsBGWxowA?t=01h29m02s)

[I don't think I can get away with that](https://youtu.be/tRxsBGWxowA?t=01h29m08s)

[can I](https://youtu.be/tRxsBGWxowA?t=01h29m10s)

[I don't think I can](https://youtu.be/tRxsBGWxowA?t=01h29m13s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h29m17s)

[uh let's see how about we call this](https://youtu.be/tRxsBGWxowA?t=01h29m19s)

[theme](https://youtu.be/tRxsBGWxowA?t=01h29m21s)

[override because I think this is what](https://youtu.be/tRxsBGWxowA?t=01h29m22s)

[we're actually getting down to so theme](https://youtu.be/tRxsBGWxowA?t=01h29m24s)

[override we'll call this](https://youtu.be/tRxsBGWxowA?t=01h29m26s)

[stop it stop moving around on me you be](https://youtu.be/tRxsBGWxowA?t=01h29m28s)

[seen](https://youtu.be/tRxsBGWxowA?t=01h29m31s)

[so you're going to just reference so you](https://youtu.be/tRxsBGWxowA?t=01h29m32s)

[reference theme](https://youtu.be/tRxsBGWxowA?t=01h29m35s)

[make this thing look the way I want uh](https://youtu.be/tRxsBGWxowA?t=01h29m37s)

[oh and this is an app](https://youtu.be/tRxsBGWxowA?t=01h29m39s)

[uh theme](https://youtu.be/tRxsBGWxowA?t=01h29m41s)

[override](https://youtu.be/tRxsBGWxowA?t=01h29m44s)

[builds everyone's happy designer](https://youtu.be/tRxsBGWxowA?t=01h29m50s)

[launches](https://youtu.be/tRxsBGWxowA?t=01h29m52s)

[huh](https://youtu.be/tRxsBGWxowA?t=01h29m57s)

[what does the designer have](https://youtu.be/tRxsBGWxowA?t=01h30m00s)

[middle one](https://youtu.be/tRxsBGWxowA?t=01h30m02s)

[huh](https://youtu.be/tRxsBGWxowA?t=01h30m06s)

[okay](https://youtu.be/tRxsBGWxowA?t=01h30m09s)

[now I'm confused uh so now I want to](https://youtu.be/tRxsBGWxowA?t=01h30m11s)

[look at it so come here Snoop](https://youtu.be/tRxsBGWxowA?t=01h30m14s)

[I want to see what the heck you did](https://youtu.be/tRxsBGWxowA?t=01h30m17s)

[uh yeah you go to the side you go to the](https://youtu.be/tRxsBGWxowA?t=01h30m19s)

[side](https://youtu.be/tRxsBGWxowA?t=01h30m22s)

[you come over here Ctrl shift](https://youtu.be/tRxsBGWxowA?t=01h30m24s)

[and I want to see your background](https://youtu.be/tRxsBGWxowA?t=01h30m26s)

[interesting so it didn't resolve](https://youtu.be/tRxsBGWxowA?t=01h30m30s)

[the resource theme brushes other](https://youtu.be/tRxsBGWxowA?t=01h30m37s)

[could not be resolved](https://youtu.be/tRxsBGWxowA?t=01h30m40s)

[which is weird to me because](https://youtu.be/tRxsBGWxowA?t=01h30m43s)

[theme brushes other](https://youtu.be/tRxsBGWxowA?t=01h30m46s)

[but other did I typo something](https://youtu.be/tRxsBGWxowA?t=01h30m49s)

[it's weird that it's able to resolve two](https://youtu.be/tRxsBGWxowA?t=01h30m58s)

[which is dependent on it](https://youtu.be/tRxsBGWxowA?t=01h31m00s)

[if I invert the order](https://youtu.be/tRxsBGWxowA?t=01h31m03s)

[kind of expect that to not do it](https://youtu.be/tRxsBGWxowA?t=01h31m08s)

[hey acid rain how you doing](https://youtu.be/tRxsBGWxowA?t=01h31m15s)

[ah interesting oh oh](https://youtu.be/tRxsBGWxowA?t=01h31m18s)

[um](https://youtu.be/tRxsBGWxowA?t=01h31m23s)

[that's interesting](https://youtu.be/tRxsBGWxowA?t=01h31m26s)

[that is very interesting](https://youtu.be/tRxsBGWxowA?t=01h31m30s)

[I I have a sinking suspicion](https://youtu.be/tRxsBGWxowA?t=01h31m37s)

[oh what's the back of my eyelids](https://youtu.be/tRxsBGWxowA?t=01h31m44s)

[uh I should probably be doing the same](https://youtu.be/tRxsBGWxowA?t=01h31m47s)

[I'm on two cans of mountain well](https://youtu.be/tRxsBGWxowA?t=01h31m50s)

[almost two cans of Mountain Dew and six](https://youtu.be/tRxsBGWxowA?t=01h31m54s)

[hours of sleep eyelids sound like a](https://youtu.be/tRxsBGWxowA?t=01h31m57s)

[great thing](https://youtu.be/tRxsBGWxowA?t=01h31m59s)

[I am thinking that the issue is](https://youtu.be/tRxsBGWxowA?t=01h32m04s)

[oh yes oh I should have grabbed it](https://youtu.be/tRxsBGWxowA?t=01h32m09s)

[I'll bring it next week](https://youtu.be/tRxsBGWxowA?t=01h32m14s)

[a buddy of mine got me the most awesome](https://youtu.be/tRxsBGWxowA?t=01h32m16s)

[ball cap ever](https://youtu.be/tRxsBGWxowA?t=01h32m20s)

[and I am loving it okay so let's go up](https://youtu.be/tRxsBGWxowA?t=01h32m23s)

[here](https://youtu.be/tRxsBGWxowA?t=01h32m28s)

[let's look at these app resources](https://youtu.be/tRxsBGWxowA?t=01h32m29s)

[so](https://youtu.be/tRxsBGWxowA?t=01h32m32s)

[this guy here so this is so one if](https://youtu.be/tRxsBGWxowA?t=01h32m35s)

[people haven't seen this in Snoop this](https://youtu.be/tRxsBGWxowA?t=01h32m38s)

[is this is just pure absolute gold](https://youtu.be/tRxsBGWxowA?t=01h32m40s)

[um](https://youtu.be/tRxsBGWxowA?t=01h32m44s)

[so the uh](https://youtu.be/tRxsBGWxowA?t=01h32m46s)

[inside so from the root of uh Snoop](https://youtu.be/tRxsBGWxowA?t=01h32m48s)

[oh is it](https://youtu.be/tRxsBGWxowA?t=01h32m52s)

[uh you can do the underneath app you can](https://youtu.be/tRxsBGWxowA?t=01h32m54s)

[just expand out your resources and take](https://youtu.be/tRxsBGWxowA?t=01h32m57s)

[a look at everything that's in the](https://youtu.be/tRxsBGWxowA?t=01h32m59s)

[runtime dictionary](https://youtu.be/tRxsBGWxowA?t=01h33m01s)

[uh time to go for here working Italy](https://youtu.be/tRxsBGWxowA?t=01h33m02s)

[dark on have a good day at work good](https://youtu.be/tRxsBGWxowA?t=01h33m05s)

[luck](https://youtu.be/tRxsBGWxowA?t=01h33m08s)

[thanks for dropping by I appreciate all](https://youtu.be/tRxsBGWxowA?t=01h33m09s)

[the questions](https://youtu.be/tRxsBGWxowA?t=01h33m10s)

[um and but when you expand it out you](https://youtu.be/tRxsBGWxowA?t=01h33m12s)

[can actually start walking your resource](https://youtu.be/tRxsBGWxowA?t=01h33m13s)

[dictionaries and take a look at them](https://youtu.be/tRxsBGWxowA?t=01h33m15s)

[so we can see here in the overrides one](https://youtu.be/tRxsBGWxowA?t=01h33m18s)

[I've got a single solid color brush that](https://youtu.be/tRxsBGWxowA?t=01h33m21s)

[has the key of theme brushes primary](https://youtu.be/tRxsBGWxowA?t=01h33m24s)

[not shocking](https://youtu.be/tRxsBGWxowA?t=01h33m26s)

[and then down here I only end up with](https://youtu.be/tRxsBGWxowA?t=01h33m28s)

[two](https://youtu.be/tRxsBGWxowA?t=01h33m31s)

[uh and I'm pretty sure I know the reason](https://youtu.be/tRxsBGWxowA?t=01h33m35s)

[is it's because the static resource](https://youtu.be/tRxsBGWxowA?t=01h33m41s)

[yeah you can't chain the aliases](https://youtu.be/tRxsBGWxowA?t=01h33m48s)

[foreign I think they all have to](https://youtu.be/tRxsBGWxowA?t=01h33m53s)

[reference the same primary](https://youtu.be/tRxsBGWxowA?t=01h33m55s)

[because that's the working Theory](https://youtu.be/tRxsBGWxowA?t=01h34m01s)

[no](https://youtu.be/tRxsBGWxowA?t=01h34m04s)

[that theory does not appear to hold](https://youtu.be/tRxsBGWxowA?t=01h34m09s)

[so what's going on what's going on](https://youtu.be/tRxsBGWxowA?t=01h34m13s)

[so I have other two](https://youtu.be/tRxsBGWxowA?t=01h34m18s)

[K but not other](https://youtu.be/tRxsBGWxowA?t=01h34m28s)

[and if I invert them](https://youtu.be/tRxsBGWxowA?t=01h34m31s)

[I pretty sure I get the exact opposite](https://youtu.be/tRxsBGWxowA?t=01h34m35s)

[which I do](https://youtu.be/tRxsBGWxowA?t=01h34m40s)

[or at least the](https://youtu.be/tRxsBGWxowA?t=01h34m42s)

[the box is lighting up would appear to](https://youtu.be/tRxsBGWxowA?t=01h34m44s)

[be so](https://youtu.be/tRxsBGWxowA?t=01h34m46s)

[uh let's see](https://youtu.be/tRxsBGWxowA?t=01h34m48s)

[interesting why is this static resource](https://youtu.be/tRxsBGWxowA?t=01h34m54s)

[trick not](https://youtu.be/tRxsBGWxowA?t=01h34m57s)

[behaving the way I expect](https://youtu.be/tRxsBGWxowA?t=01h35m00s)

[rather than other two let's name it](https://youtu.be/tRxsBGWxowA?t=01h35m03s)

[they are both self-closing](https://youtu.be/tRxsBGWxowA?t=01h35m10s)

[why would one](https://youtu.be/tRxsBGWxowA?t=01h35m13s)

[why would one close that out](https://youtu.be/tRxsBGWxowA?t=01h35m17s)

[let's make sure the override isn't](https://youtu.be/tRxsBGWxowA?t=01h35m20s)

[affecting it I don't think it should be](https://youtu.be/tRxsBGWxowA?t=01h35m22s)

[um and then this becomes blue](https://youtu.be/tRxsBGWxowA?t=01h35m26s)

[excellent that's exactly what I expected](https://youtu.be/tRxsBGWxowA?t=01h35m34s)

[happen nothing works](https://youtu.be/tRxsBGWxowA?t=01h35m36s)

[perfect we're gonna launch because I](https://youtu.be/tRxsBGWxowA?t=01h35m38s)

[don't trust the designer](https://youtu.be/tRxsBGWxowA?t=01h35m40s)

[uh did you upgrade Snoop to the new](https://youtu.be/tRxsBGWxowA?t=01h35m51s)

[version 5.0 I did I did I did](https://youtu.be/tRxsBGWxowA?t=01h35m53s)

[highly highly recommended](https://youtu.be/tRxsBGWxowA?t=01h35m57s)

[at least I'm pretty sure this is the new](https://youtu.be/tRxsBGWxowA?t=01h36m00s)

[one](https://youtu.be/tRxsBGWxowA?t=01h36m01s)

[where's my uh](https://youtu.be/tRxsBGWxowA?t=01h36m02s)

[the light theme I will say as much as I](https://youtu.be/tRxsBGWxowA?t=01h36m05s)

[like Dart theme](https://youtu.be/tRxsBGWxowA?t=01h36m07s)

[I I feel so this dark theme](https://youtu.be/tRxsBGWxowA?t=01h36m09s)

[with almost a little too much like](https://youtu.be/tRxsBGWxowA?t=01h36m12s)

[it looks like it's pure black and pure](https://youtu.be/tRxsBGWxowA?t=01h36m17s)

[white](https://youtu.be/tRxsBGWxowA?t=01h36m19s)

[which is almost too much contrast](https://youtu.be/tRxsBGWxowA?t=01h36m20s)

[whereas if you look over here this isn't](https://youtu.be/tRxsBGWxowA?t=01h36m23s)

[pure black like you can even see the](https://youtu.be/tRxsBGWxowA?t=01h36m26s)

[difference between the visual studio](https://youtu.be/tRxsBGWxowA?t=01h36m29s)

[Dark theme in this right is Dark theme](https://youtu.be/tRxsBGWxowA?t=01h36m30s)

[should be dark](https://youtu.be/tRxsBGWxowA?t=01h36m33s)

[but when you go pure black it's almost](https://youtu.be/tRxsBGWxowA?t=01h36m34s)

[uh grading the the contrast ratio](https://youtu.be/tRxsBGWxowA?t=01h36m36s)

[it almost hurts more to look at it](https://youtu.be/tRxsBGWxowA?t=01h36m41s)

[I am](https://youtu.be/tRxsBGWxowA?t=01h36m45s)

[oh I wonder](https://youtu.be/tRxsBGWxowA?t=01h36m50s)

[this might be why](https://youtu.be/tRxsBGWxowA?t=01h36m54s)

[ma apps had a clever thing that they did](https://youtu.be/tRxsBGWxowA?t=01h36m57s)

[at one point where is that](https://youtu.be/tRxsBGWxowA?t=01h37m00s)

[they rolled their own](https://youtu.be/tRxsBGWxowA?t=01h37m03s)

[thingymabobber](https://youtu.be/tRxsBGWxowA?t=01h37m06s)

[um](https://youtu.be/tRxsBGWxowA?t=01h37m15s)

[yeah let's go look at what they did](https://youtu.be/tRxsBGWxowA?t=01h37m16s)

[because ma apps had a](https://youtu.be/tRxsBGWxowA?t=01h37m19s)

[if that's where I I first saw this trick](https://youtu.be/tRxsBGWxowA?t=01h37m24s)

[is there's not it's](https://youtu.be/tRxsBGWxowA?t=01h37m27s)

[those are looking](https://youtu.be/tRxsBGWxowA?t=01h37m31s)

[they have let's see it's in here](https://youtu.be/tRxsBGWxowA?t=01h37m35s)

[uh where did they put it probably markup](https://youtu.be/tRxsBGWxowA?t=01h37m40s)

[yeah this guy](https://youtu.be/tRxsBGWxowA?t=01h37m44s)

[they did this](https://youtu.be/tRxsBGWxowA?t=01h37m46s)

[I'm curious](https://youtu.be/tRxsBGWxowA?t=01h37m54s)

[curious why](https://youtu.be/tRxsBGWxowA?t=01h38m00s)

[let's let's go here we're gonna](https://youtu.be/tRxsBGWxowA?t=01h38m09s)

[I'm gonna cheat and just drop uh this](https://youtu.be/tRxsBGWxowA?t=01h38m13s)

[lovely little guy in thank you](https://youtu.be/tRxsBGWxowA?t=01h38m16s)

[um](https://youtu.be/tRxsBGWxowA?t=01h38m18s)

[yeah drop the name space we're gonna put](https://youtu.be/tRxsBGWxowA?t=01h38m19s)

[up my name space for the moment](https://youtu.be/tRxsBGWxowA?t=01h38m21s)

[I'm gonna try this uh](https://youtu.be/tRxsBGWxowA?t=01h38m23s)

[snoopers use one great line very](https://youtu.be/tRxsBGWxowA?t=01h38m28s)

[um so the the author of Snoop](https://youtu.be/tRxsBGWxowA?t=01h38m32s)

[um Bastion Schmidt I think I'm saying](https://youtu.be/tRxsBGWxowA?t=01h38m36s)

[that correctly](https://youtu.be/tRxsBGWxowA?t=01h38m38s)

[um he actually runs the](https://youtu.be/tRxsBGWxowA?t=01h38m39s)

[uh let's see if we go](https://youtu.be/tRxsBGWxowA?t=01h38m43s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h38m47s)

[controls EX](https://youtu.be/tRxsBGWxowA?t=01h38m49s)

[uh this guy](https://youtu.be/tRxsBGWxowA?t=01h38m52s)

[so you will note here this Library](https://youtu.be/tRxsBGWxowA?t=01h38m55s)

[this lovely this lovely gentleman here](https://youtu.be/tRxsBGWxowA?t=01h38m59s)

[you'll note there's Snoop so](https://youtu.be/tRxsBGWxowA?t=01h39m02s)

[he'd be the one who who runs Snoop also](https://youtu.be/tRxsBGWxowA?t=01h39m06s)

[runs this Library this Library uh is the](https://youtu.be/tRxsBGWxowA?t=01h39m09s)

[backing Library underneath](https://youtu.be/tRxsBGWxowA?t=01h39m13s)

[um mod apps](https://youtu.be/tRxsBGWxowA?t=01h39m17s)

[and it still kind of does but not not](https://youtu.be/tRxsBGWxowA?t=01h39m18s)

[really as much anymore](https://youtu.be/tRxsBGWxowA?t=01h39m23s)

[um](https://youtu.be/tRxsBGWxowA?t=01h39m25s)

[it was the underlying library and I](https://youtu.be/tRxsBGWxowA?t=01h39m26s)

[think it shows yeah the it was doing the](https://youtu.be/tRxsBGWxowA?t=01h39m29s)

[underlying library from the material](https://youtu.be/tRxsBGWxowA?t=01h39m32s)

[design library for a long time the](https://youtu.be/tRxsBGWxowA?t=01h39m35s)

[materials design Library didn't ever](https://youtu.be/tRxsBGWxowA?t=01h39m38s)

[take a direct dependency on the nuget](https://youtu.be/tRxsBGWxowA?t=01h39m40s)

[package but what it did instead is it](https://youtu.be/tRxsBGWxowA?t=01h39m42s)

[was using a thing called packet rather](https://youtu.be/tRxsBGWxowA?t=01h39m44s)

[than nougat because packet gives](https://youtu.be/tRxsBGWxowA?t=01h39m46s)

[additional functionality in addition to](https://youtu.be/tRxsBGWxowA?t=01h39m49s)

[nougat packages you can tell packet hey](https://youtu.be/tRxsBGWxowA?t=01h39m51s)

[I have this file dependency](https://youtu.be/tRxsBGWxowA?t=01h39m54s)

[and it would go out to the control ZX](https://youtu.be/tRxsBGWxowA?t=01h39m57s)

[library and download like The the pop-up](https://youtu.be/tRxsBGWxowA?t=01h39m59s)

[control and similar](https://youtu.be/tRxsBGWxowA?t=01h40m02s)

[um](https://youtu.be/tRxsBGWxowA?t=01h40m04s)

[yeah so there is the](https://youtu.be/tRxsBGWxowA?t=01h40m07s)

[um there is all of this Jazz and you'll](https://youtu.be/tRxsBGWxowA?t=01h40m11s)

[note this pack icon thing that looks](https://youtu.be/tRxsBGWxowA?t=01h40m13s)

[remarkably similar to the one inside the](https://youtu.be/tRxsBGWxowA?t=01h40m16s)

[material design](https://youtu.be/tRxsBGWxowA?t=01h40m18s)

[um this is how it started was inside of](https://youtu.be/tRxsBGWxowA?t=01h40m19s)

[here](https://youtu.be/tRxsBGWxowA?t=01h40m22s)

[again same same for this type of thing](https://youtu.be/tRxsBGWxowA?t=01h40m23s)

[as well this is also the the underlying](https://youtu.be/tRxsBGWxowA?t=01h40m26s)

[thing inside of the ma apps](https://youtu.be/tRxsBGWxowA?t=01h40m28s)

[um the icon libraries from them as well](https://youtu.be/tRxsBGWxowA?t=01h40m30s)

[um](https://youtu.be/tRxsBGWxowA?t=01h40m35s)

[so it may be it may be an interesting](https://youtu.be/tRxsBGWxowA?t=01h40m37s)

[question and see I contribute a couple](https://youtu.be/tRxsBGWxowA?t=01h40m39s)

[things](https://youtu.be/tRxsBGWxowA?t=01h40m41s)

[not a ton and I've questioned whether](https://youtu.be/tRxsBGWxowA?t=01h40m44s)

[there should be a dependency there or](https://youtu.be/tRxsBGWxowA?t=01h40m46s)

[not and I go back and forth okay I want](https://youtu.be/tRxsBGWxowA?t=01h40m48s)

[to check this static extension so](https://youtu.be/tRxsBGWxowA?t=01h40m51s)

[I want to go here](https://youtu.be/tRxsBGWxowA?t=01h40m56s)

[so I want to use uh let's see uh](https://youtu.be/tRxsBGWxowA?t=01h40m58s)

[uh let's see XML and S let's do a we'll](https://youtu.be/tRxsBGWxowA?t=01h41m04s)

[just call it locals CLR](https://youtu.be/tRxsBGWxowA?t=01h41m09s)

[namespace](https://youtu.be/tRxsBGWxowA?t=01h41m12s)

[and then we will do template demo](https://youtu.be/tRxsBGWxowA?t=01h41m14s)

[what oh I can't spell template demo](https://youtu.be/tRxsBGWxowA?t=01h41m20s)

[and then this becomes something more](https://youtu.be/tRxsBGWxowA?t=01h41m24s)

[like](https://youtu.be/tRxsBGWxowA?t=01h41m26s)

[local colon](https://youtu.be/tRxsBGWxowA?t=01h41m28s)

[right static resource does not exist in](https://youtu.be/tRxsBGWxowA?t=01h41m31s)

[template demo yes it does](https://youtu.be/tRxsBGWxowA?t=01h41m33s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h41m37s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h41m39s)

[oh I can see you](https://youtu.be/tRxsBGWxowA?t=01h41m41s)

[uh compile](https://youtu.be/tRxsBGWxowA?t=01h41m43s)

[uh let's see what am I doing wrong](https://youtu.be/tRxsBGWxowA?t=01h41m48s)

[epic resource extension should be made](https://youtu.be/tRxsBGWxowA?t=01h41m51s)

[optional](https://youtu.be/tRxsBGWxowA?t=01h41m54s)

[extensions optional resource key oh it's](https://youtu.be/tRxsBGWxowA?t=01h42m02s)

[in this is the validation in space](https://youtu.be/tRxsBGWxowA?t=01h42m05s)

[that's why it's not finding it](https://youtu.be/tRxsBGWxowA?t=01h42m07s)

[try that again](https://youtu.be/tRxsBGWxowA?t=01h42m09s)

[there we go Okay so](https://youtu.be/tRxsBGWxowA?t=01h42m11s)

[we do that](https://youtu.be/tRxsBGWxowA?t=01h42m14s)

[interesting](https://youtu.be/tRxsBGWxowA?t=01h42m18s)

[let me just launch to make sure that the](https://youtu.be/tRxsBGWxowA?t=01h42m23s)

[interesting interesting interesting](https://youtu.be/tRxsBGWxowA?t=01h42m31s)

[that surprises me](https://youtu.be/tRxsBGWxowA?t=01h42m34s)

[that surprises me a little bit](https://youtu.be/tRxsBGWxowA?t=01h42m39s)

[because the](https://youtu.be/tRxsBGWxowA?t=01h42m42s)

[so all we've done is make a derived](https://youtu.be/tRxsBGWxowA?t=01h42m47s)

[class](https://youtu.be/tRxsBGWxowA?t=01h42m50s)

[that calls into the base](https://youtu.be/tRxsBGWxowA?t=01h42m52s)

[and that works](https://youtu.be/tRxsBGWxowA?t=01h42m58s)

[oh I bet you it works because static and](https://youtu.be/tRxsBGWxowA?t=01h43m01s)

[dynamic resources are special in WPF](https://youtu.be/tRxsBGWxowA?t=01h43m05s)

[oh I bet you that's why it works](https://youtu.be/tRxsBGWxowA?t=01h43m08s)

[I bet you that's why it works](https://youtu.be/tRxsBGWxowA?t=01h43m12s)

[okay so now that now that we're back to](https://youtu.be/tRxsBGWxowA?t=01h43m16s)

[in functioning state](https://youtu.be/tRxsBGWxowA?t=01h43m20s)

[with these here what happens](https://youtu.be/tRxsBGWxowA?t=01h43m22s)

[if in my override](https://youtu.be/tRxsBGWxowA?t=01h43m27s)

[I do something like this](https://youtu.be/tRxsBGWxowA?t=01h43m30s)

[all right oh uh you have to include](https://youtu.be/tRxsBGWxowA?t=01h43m35s)

[local in your](https://youtu.be/tRxsBGWxowA?t=01h43m37s)

[name spaces come on you'll find it](https://youtu.be/tRxsBGWxowA?t=01h43m39s)

[come on come on](https://youtu.be/tRxsBGWxowA?t=01h43m43s)

[co-pilot do it for me](https://youtu.be/tRxsBGWxowA?t=01h43m46s)

[no okay](https://youtu.be/tRxsBGWxowA?t=01h43m48s)

[uh let's see local get CLR c l r name](https://youtu.be/tRxsBGWxowA?t=01h43m52s)

[space](https://youtu.be/tRxsBGWxowA?t=01h43m59s)

[your autocomplete is killing me](https://youtu.be/tRxsBGWxowA?t=01h44m01s)

[uh](https://youtu.be/tRxsBGWxowA?t=01h44m04s)

[uh keep going to call it same thing and](https://youtu.be/tRxsBGWxowA?t=01h44m07s)

[it's template demo](https://youtu.be/tRxsBGWxowA?t=01h44m09s)

[there what happens if I do that does it](https://youtu.be/tRxsBGWxowA?t=01h44m11s)

[still work](https://youtu.be/tRxsBGWxowA?t=01h44m14s)

[yes](https://youtu.be/tRxsBGWxowA?t=01h44m16s)

[what happens if I override U to be red](https://youtu.be/tRxsBGWxowA?t=01h44m17s)

[uh actually I don't want that to be read](https://youtu.be/tRxsBGWxowA?t=01h44m24s)

[what I'd like to do is make](https://youtu.be/tRxsBGWxowA?t=01h44m26s)

[a brush](https://youtu.be/tRxsBGWxowA?t=01h44m30s)

[give it the same key](https://youtu.be/tRxsBGWxowA?t=01h44m32s)

[put the key back in here real quick and](https://youtu.be/tRxsBGWxowA?t=01h44m40s)

[then](https://youtu.be/tRxsBGWxowA?t=01h44m43s)

[now I expect the primary one to be red](https://youtu.be/tRxsBGWxowA?t=01h44m44s)

[oh interesting](https://youtu.be/tRxsBGWxowA?t=01h44m53s)

[so that changed](https://youtu.be/tRxsBGWxowA?t=01h44m56s)

[primary and other](https://youtu.be/tRxsBGWxowA?t=01h45m01s)

[interesting so that changed primary and](https://youtu.be/tRxsBGWxowA?t=01h45m12s)

[other](https://youtu.be/tRxsBGWxowA?t=01h45m16s)

[hold on let's reorder these a little bit](https://youtu.be/tRxsBGWxowA?t=01h45m17s)

[that opens up a different set of](https://youtu.be/tRxsBGWxowA?t=01h45m22s)

[possibilities now](https://youtu.be/tRxsBGWxowA?t=01h45m25s)

[that so](https://youtu.be/tRxsBGWxowA?t=01h45m28s)

[my limited perspective is that the](https://youtu.be/tRxsBGWxowA?t=01h45m29s)

[people who are going to want to do a lot](https://youtu.be/tRxsBGWxowA?t=01h45m32s)

[of theming related changes](https://youtu.be/tRxsBGWxowA?t=01h45m35s)

[forcing them to put a namespace in front](https://youtu.be/tRxsBGWxowA?t=01h45m37s)

[of static resource is not going to be](https://youtu.be/tRxsBGWxowA?t=01h45m39s)

[too big of a lift](https://youtu.be/tRxsBGWxowA?t=01h45m41s)

[because I suspect what they're going to](https://youtu.be/tRxsBGWxowA?t=01h45m45s)

[be more interested in is Gen me up the](https://youtu.be/tRxsBGWxowA?t=01h45m46s)

[the thing with all of the](https://youtu.be/tRxsBGWxowA?t=01h45m49s)

[with all of the keys so I'm anticipating](https://youtu.be/tRxsBGWxowA?t=01h45m52s)

[generating](https://youtu.be/tRxsBGWxowA?t=01h45m54s)

[an overrides file because I want it to](https://youtu.be/tRxsBGWxowA?t=01h45m58s)

[be easy for somebody who wants to come](https://youtu.be/tRxsBGWxowA?t=01h46m00s)

[in here and do it I want to at least](https://youtu.be/tRxsBGWxowA?t=01h46m01s)

[have documentation that says here's the](https://youtu.be/tRxsBGWxowA?t=01h46m04s)

[here's the override file you need to](https://youtu.be/tRxsBGWxowA?t=01h46m06s)

[drop into your project](https://youtu.be/tRxsBGWxowA?t=01h46m07s)

[maybe put that in the wiki](https://youtu.be/tRxsBGWxowA?t=01h46m09s)

[maybe have the wikiato generated from](https://youtu.be/tRxsBGWxowA?t=01h46m12s)

[the pipeline](https://youtu.be/tRxsBGWxowA?t=01h46m14s)

[that's my thinking](https://youtu.be/tRxsBGWxowA?t=01h46m15s)

[because we're already updating the wiki](https://youtu.be/tRxsBGWxowA?t=01h46m18s)

[from the pipeline as it sits now which](https://youtu.be/tRxsBGWxowA?t=01h46m19s)

[is pretty slick](https://youtu.be/tRxsBGWxowA?t=01h46m21s)

[so when we set primary](https://youtu.be/tRxsBGWxowA?t=01h46m23s)

[oh this one works because it's falling](https://youtu.be/tRxsBGWxowA?t=01h46m27s)

[back to primary oh hang on that doesn't](https://youtu.be/tRxsBGWxowA?t=01h46m29s)

[count that doesn't count so let's change](https://youtu.be/tRxsBGWxowA?t=01h46m32s)

[this to Foo](https://youtu.be/tRxsBGWxowA?t=01h46m36s)

[okay so that's the reason that one's](https://youtu.be/tRxsBGWxowA?t=01h46m37s)

[working is because these are in the same](https://youtu.be/tRxsBGWxowA?t=01h46m39s)

[resource dictionary](https://youtu.be/tRxsBGWxowA?t=01h46m40s)

[so now I expect only one red](https://youtu.be/tRxsBGWxowA?t=01h46m43s)

[perfect](https://youtu.be/tRxsBGWxowA?t=01h46m54s)

[and if I set and if I do one here and I](https://youtu.be/tRxsBGWxowA?t=01h46m56s)

[change it and I change for example other](https://youtu.be/tRxsBGWxowA?t=01h46m59s)

[to be blue](https://youtu.be/tRxsBGWxowA?t=01h47m03s)

[I get blue](https://youtu.be/tRxsBGWxowA?t=01h47m08s)

[I don't know why I keep stopping the app](https://youtu.be/tRxsBGWxowA?t=01h47m10s)

[the hot reload works really well for](https://youtu.be/tRxsBGWxowA?t=01h47m11s)

[resource stuff](https://youtu.be/tRxsBGWxowA?t=01h47m14s)

[so it is still that same situation is](https://youtu.be/tRxsBGWxowA?t=01h47m22s)

[I'm going to need to generate up](https://youtu.be/tRxsBGWxowA?t=01h47m25s)

[a bunch of these let's do a secondary](https://youtu.be/tRxsBGWxowA?t=01h47m38s)

[theme color so uh let's go with](https://youtu.be/tRxsBGWxowA?t=01h47m40s)

[secondary](https://youtu.be/tRxsBGWxowA?t=01h47m43s)

[and](https://youtu.be/tRxsBGWxowA?t=01h47m46s)

[uh zero zero FF delete delete](https://youtu.be/tRxsBGWxowA?t=01h47m48s)

[uh yeah that'll work and then this would](https://youtu.be/tRxsBGWxowA?t=01h47m52s)

[end up being](https://youtu.be/tRxsBGWxowA?t=01h47m57s)

[secondary](https://youtu.be/tRxsBGWxowA?t=01h47m59s)

[and this would end up being](https://youtu.be/tRxsBGWxowA?t=01h48m00s)

[secondary](https://youtu.be/tRxsBGWxowA?t=01h48m03s)

[and then this would end up being](https://youtu.be/tRxsBGWxowA?t=01h48m05s)

[knew a couple of these](https://youtu.be/tRxsBGWxowA?t=01h48m08s)

[uh bar and bad sound great bar](https://youtu.be/tRxsBGWxowA?t=01h48m10s)

[baz and this is](https://youtu.be/tRxsBGWxowA?t=01h48m16s)

[secondary](https://youtu.be/tRxsBGWxowA?t=01h48m19s)

[secondary those get structured like that](https://youtu.be/tRxsBGWxowA?t=01h48m22s)

[all right we go here we go here](https://youtu.be/tRxsBGWxowA?t=01h48m28s)

[um we are quickly approaching grid](https://youtu.be/tRxsBGWxowA?t=01h48m31s)

[territory](https://youtu.be/tRxsBGWxowA?t=01h48m34s)

[uh agreed](https://youtu.be/tRxsBGWxowA?t=01h48m35s)

[column definitions](https://youtu.be/tRxsBGWxowA?t=01h48m39s)

[uh column definition with Auto](https://youtu.be/tRxsBGWxowA?t=01h48m41s)

[two of those](https://youtu.be/tRxsBGWxowA?t=01h48m46s)

[um](https://youtu.be/tRxsBGWxowA?t=01h48m50s)

[just going to do](https://youtu.be/tRxsBGWxowA?t=01h48m52s)

[stack panel in each](https://youtu.be/tRxsBGWxowA?t=01h48m53s)

[and then I'm just going to copy you](https://youtu.be/tRxsBGWxowA?t=01h49m01s)

[paste and then I want you to be](https://youtu.be/tRxsBGWxowA?t=01h49m04s)

[secondary](https://youtu.be/tRxsBGWxowA?t=01h49m08s)

[bar](https://youtu.be/tRxsBGWxowA?t=01h49m10s)

[s](https://youtu.be/tRxsBGWxowA?t=01h49m13s)

[and I get it you're unhappy with me get](https://youtu.be/tRxsBGWxowA?t=01h49m15s)

[it I get it you're you're unhappy](https://youtu.be/tRxsBGWxowA?t=01h49m17s)

[oh I did not put you in the second grid](https://youtu.be/tRxsBGWxowA?t=01h49m21s)

[column](https://youtu.be/tRxsBGWxowA?t=01h49m24s)

[a grid column one](https://youtu.be/tRxsBGWxowA?t=01h49m26s)

[uh and now we go huh](https://youtu.be/tRxsBGWxowA?t=01h49m33s)

[uh grid column](https://youtu.be/tRxsBGWxowA?t=01h49m39s)

[restart that because that does not look](https://youtu.be/tRxsBGWxowA?t=01h49m43s)

[correct to me](https://youtu.be/tRxsBGWxowA?t=01h49m46s)

[when I put two things in a grid](https://youtu.be/tRxsBGWxowA?t=01h49m47s)

[what](https://youtu.be/tRxsBGWxowA?t=01h49m50s)

[oh](https://youtu.be/tRxsBGWxowA?t=01h49m52s)

[because I didn't put the stack panels in](https://youtu.be/tRxsBGWxowA?t=01h49m54s)

[the grid](https://youtu.be/tRxsBGWxowA?t=01h49m56s)

[you don't put them in the grid](https://youtu.be/tRxsBGWxowA?t=01h49m58s)

[it does not lay out properly that's too](https://youtu.be/tRxsBGWxowA?t=01h50m00s)

[deep](https://youtu.be/tRxsBGWxowA?t=01h50m04s)

[that looks better](https://youtu.be/tRxsBGWxowA?t=01h50m05s)

[there we go okay so now we've got](https://youtu.be/tRxsBGWxowA?t=01h50m07s)

[Primary in the left secondary on the](https://youtu.be/tRxsBGWxowA?t=01h50m09s)

[right and then in my override if I](https://youtu.be/tRxsBGWxowA?t=01h50m11s)

[wanted to change one of these for](https://youtu.be/tRxsBGWxowA?t=01h50m13s)

[example I decide that I actually want](https://youtu.be/tRxsBGWxowA?t=01h50m15s)

[um](https://youtu.be/tRxsBGWxowA?t=01h50m19s)

[the secondary brush to be](https://youtu.be/tRxsBGWxowA?t=01h50m21s)

[bringing you down uh brushes](https://youtu.be/tRxsBGWxowA?t=01h50m27s)

[secondary as red](https://youtu.be/tRxsBGWxowA?t=01h50m31s)

[that changes that now what's really](https://youtu.be/tRxsBGWxowA?t=01h50m34s)

[disappointing is if I change the](https://youtu.be/tRxsBGWxowA?t=01h50m36s)

[secondary brush in an override it](https://youtu.be/tRxsBGWxowA?t=01h50m38s)

[doesn't affect](https://youtu.be/tRxsBGWxowA?t=01h50m40s)

[it doesn't regen the other ones](https://youtu.be/tRxsBGWxowA?t=01h50m44s)

[it doesn't shock me too much I do wonder](https://youtu.be/tRxsBGWxowA?t=01h50m55s)

[what happens so let's](https://youtu.be/tRxsBGWxowA?t=01h50m59s)

[let's just](https://youtu.be/tRxsBGWxowA?t=01h51m01s)

[I'm curious if we can get away with this](https://youtu.be/tRxsBGWxowA?t=01h51m10s)

[I don't think it's going to work the way](https://youtu.be/tRxsBGWxowA?t=01h51m13s)

[I want but](https://youtu.be/tRxsBGWxowA?t=01h51m15s)

[I'm just I want to try it I haven't done](https://youtu.be/tRxsBGWxowA?t=01h51m18s)

[enough playing with this stuff to know](https://youtu.be/tRxsBGWxowA?t=01h51m21s)

[exactly how it's going to behave](https://youtu.be/tRxsBGWxowA?t=01h51m23s)

[so we're gonna do this](https://youtu.be/tRxsBGWxowA?t=01h51m25s)

[yeah and I'm gonna guess that you want](https://youtu.be/tRxsBGWxowA?t=01h51m31s)

[to refresh all right I get it you're](https://youtu.be/tRxsBGWxowA?t=01h51m32s)

[unhappy](https://youtu.be/tRxsBGWxowA?t=01h51m34s)

[so not surprising](https://youtu.be/tRxsBGWxowA?t=01h51m37s)

[not overly surprising effectively the](https://youtu.be/tRxsBGWxowA?t=01h51m41s)

[same behavior because the resolution of](https://youtu.be/tRxsBGWxowA?t=01h51m44s)

[this Dynamic resource is from this point](https://youtu.be/tRxsBGWxowA?t=01h51m46s)

[not from the other one](https://youtu.be/tRxsBGWxowA?t=01h51m49s)

[that is really disappointing because it](https://youtu.be/tRxsBGWxowA?t=01h51m54s)

[means then that](https://youtu.be/tRxsBGWxowA?t=01h51m56s)

[if I gen an override](https://youtu.be/tRxsBGWxowA?t=01h52m01s)

[somebody can't just override the](https://youtu.be/tRxsBGWxowA?t=01h52m05s)

[secondary color](https://youtu.be/tRxsBGWxowA?t=01h52m08s)

[because all of the theme ones Downstream](https://youtu.be/tRxsBGWxowA?t=01h52m14s)

[of it are going to have it](https://youtu.be/tRxsBGWxowA?t=01h52m17s)

[if](https://youtu.be/tRxsBGWxowA?t=01h52m24s)

[if](https://youtu.be/tRxsBGWxowA?t=01h52m26s)

[I wonder can I do](https://youtu.be/tRxsBGWxowA?t=01h52m28s)

[hang on hang on we're going to try one](https://youtu.be/tRxsBGWxowA?t=01h52m31s)

[more thing I wonder now that we've moved](https://youtu.be/tRxsBGWxowA?t=01h52m33s)

[these can I change the aliases in a](https://youtu.be/tRxsBGWxowA?t=01h52m35s)

[different resource dictionary search](https://youtu.be/tRxsBGWxowA?t=01h52m38s)

[dictionary uh how about beam aliasis](https://youtu.be/tRxsBGWxowA?t=01h52m40s)

[to do](https://youtu.be/tRxsBGWxowA?t=01h52m48s)

[copy](https://youtu.be/tRxsBGWxowA?t=01h52m50s)

[let you out](https://youtu.be/tRxsBGWxowA?t=01h52m52s)

[paste](https://youtu.be/tRxsBGWxowA?t=01h52m54s)

[uh nope this line](https://youtu.be/tRxsBGWxowA?t=01h52m56s)

[you come back and you](https://youtu.be/tRxsBGWxowA?t=01h53m00s)

[like that now if I how would I expect to](https://youtu.be/tRxsBGWxowA?t=01h53m04s)

[change this together](https://youtu.be/tRxsBGWxowA?t=01h53m08s)

[I expect this](https://youtu.be/tRxsBGWxowA?t=01h53m10s)

[theme](https://youtu.be/tRxsBGWxowA?t=01h53m13s)

[aliases](https://youtu.be/tRxsBGWxowA?t=01h53m15s)

[if I do this](https://youtu.be/tRxsBGWxowA?t=01h53m18s)

[one does that still work](https://youtu.be/tRxsBGWxowA?t=01h53m23s)

[now we have a way of injecting](https://youtu.be/tRxsBGWxowA?t=01h53m34s)

[in the middle](https://youtu.be/tRxsBGWxowA?t=01h53m39s)

[and then if I wanted to do just](https://youtu.be/tRxsBGWxowA?t=01h53m41s)

[a foo](https://youtu.be/tRxsBGWxowA?t=01h53m45s)

[so this shows overriding all the](https://youtu.be/tRxsBGWxowA?t=01h53m47s)

[secondary colors using the base one](https://youtu.be/tRxsBGWxowA?t=01h53m50s)

[and if I did a solid color brush with a](https://youtu.be/tRxsBGWxowA?t=01h53m53s)

[key of](https://youtu.be/tRxsBGWxowA?t=01h53m56s)

[uh let's do theme brushes other](https://youtu.be/tRxsBGWxowA?t=01h53m57s)

[uh color green](https://youtu.be/tRxsBGWxowA?t=01h54m05s)

[that'll override just the one](https://youtu.be/tRxsBGWxowA?t=01h54m14s)

[and in the aliases](https://youtu.be/tRxsBGWxowA?t=01h54m18s)

[that's probably what we want I don't](https://youtu.be/tRxsBGWxowA?t=01h54m22s)

[think we want one Alias referencing](https://youtu.be/tRxsBGWxowA?t=01h54m23s)

[another](https://youtu.be/tRxsBGWxowA?t=01h54m25s)

[though it could be nice it could be nice](https://youtu.be/tRxsBGWxowA?t=01h54m26s)

[so hang on let's let's try this let's](https://youtu.be/tRxsBGWxowA?t=01h54m29s)

[have you go back to theme brushes](https://youtu.be/tRxsBGWxowA?t=01h54m31s)

[other the problem is is the moment you](https://youtu.be/tRxsBGWxowA?t=01h54m34s)

[have theme brushes](https://youtu.be/tRxsBGWxowA?t=01h54m36s)

[chained I think I'm gonna have to move](https://youtu.be/tRxsBGWxowA?t=01h54m38s)

[them into a I think I need a dictionary](https://youtu.be/tRxsBGWxowA?t=01h54m40s)

[a separate dictionary each level of the](https://youtu.be/tRxsBGWxowA?t=01h54m42s)

[chaining in order for this to work](https://youtu.be/tRxsBGWxowA?t=01h54m43s)

[so if I do that](https://youtu.be/tRxsBGWxowA?t=01h54m46s)

[what happens](https://youtu.be/tRxsBGWxowA?t=01h54m50s)

[because I overrode other](https://youtu.be/tRxsBGWxowA?t=01h54m53s)

[hold on I overrode other who depends on](https://youtu.be/tRxsBGWxowA?t=01h54m57s)

[other but Foo has already resolved](https://youtu.be/tRxsBGWxowA?t=01h55m00s)

[because I was kind of thinking it would](https://youtu.be/tRxsBGWxowA?t=01h55m08s)

[be cool if I could overwrite other and](https://youtu.be/tRxsBGWxowA?t=01h55m10s)

[see it chained down](https://youtu.be/tRxsBGWxowA?t=01h55m12s)

[but the problem being is because these](https://youtu.be/tRxsBGWxowA?t=01h55m14s)

[are in the same resource dictionary and](https://youtu.be/tRxsBGWxowA?t=01h55m16s)

[I think even if I make these](https://youtu.be/tRxsBGWxowA?t=01h55m18s)

[let me just check I think as even if I](https://youtu.be/tRxsBGWxowA?t=01h55m20s)

[do these as static](https://youtu.be/tRxsBGWxowA?t=01h55m22s)

[but I think I would want all of the](https://youtu.be/tRxsBGWxowA?t=01h55m27s)

[brush yeah so these resolve the same](https://youtu.be/tRxsBGWxowA?t=01h55m29s)

[whether they're static or dynamic but I](https://youtu.be/tRxsBGWxowA?t=01h55m31s)

[think](https://youtu.be/tRxsBGWxowA?t=01h55m33s)

[that's a good question I think I would](https://youtu.be/tRxsBGWxowA?t=01h55m40s)

[want them dynamic](https://youtu.be/tRxsBGWxowA?t=01h55m42s)

[I think I would want them dynamic](https://youtu.be/tRxsBGWxowA?t=01h55m46s)

[in](https://youtu.be/tRxsBGWxowA?t=01h55m48s)

[in most cases](https://youtu.be/tRxsBGWxowA?t=01h55m53s)

[Yeah so basically everywhere where I](https://youtu.be/tRxsBGWxowA?t=01h55m57s)

[want to be able to inject and have it](https://youtu.be/tRxsBGWxowA?t=01h55m59s)

[propagate down through the resources I](https://youtu.be/tRxsBGWxowA?t=01h56m02s)

[have to separate it out into a separate](https://youtu.be/tRxsBGWxowA?t=01h56m05s)

[resource dictionary](https://youtu.be/tRxsBGWxowA?t=01h56m08s)

[but if we do this where we have a base](https://youtu.be/tRxsBGWxowA?t=01h56m11s)

[theme](https://youtu.be/tRxsBGWxowA?t=01h56m14s)

[with theme colors and primary brushes](https://youtu.be/tRxsBGWxowA?t=01h56m18s)

[we then have a bunch of brush aliases](https://youtu.be/tRxsBGWxowA?t=01h56m24s)

[and this could and this will just be a](https://youtu.be/tRxsBGWxowA?t=01h56m30s)

[straight dictionary I could just gen](https://youtu.be/tRxsBGWxowA?t=01h56m33s)

[this once and be done](https://youtu.be/tRxsBGWxowA?t=01h56m35s)

[because this will be constant](https://youtu.be/tRxsBGWxowA?t=01h56m36s)

[and then the stuff that would need to be](https://youtu.be/tRxsBGWxowA?t=01h56m41s)

[gen per color theme](https://youtu.be/tRxsBGWxowA?t=01h56m42s)

[would be a combination of the base theme](https://youtu.be/tRxsBGWxowA?t=01h56m45s)

[because this will end up being like](https://youtu.be/tRxsBGWxowA?t=01h56m49s)

[Amber](https://youtu.be/tRxsBGWxowA?t=01h56m51s)

[or red or what the various other](https://youtu.be/tRxsBGWxowA?t=01h56m52s)

[material design based theme colors](https://youtu.be/tRxsBGWxowA?t=01h56m54s)

[coupled with the brush aliases](https://youtu.be/tRxsBGWxowA?t=01h56m57s)

[and then](https://youtu.be/tRxsBGWxowA?t=01h57m03s)

[yeah so the overrides go here](https://youtu.be/tRxsBGWxowA?t=01h57m05s)

[do I want the overrides here](https://youtu.be/tRxsBGWxowA?t=01h57m11s)

[does that give people enough control](https://youtu.be/tRxsBGWxowA?t=01h57m15s)

[because if I gen the overrides](https://youtu.be/tRxsBGWxowA?t=01h57m18s)

[right so this works here inside the](https://youtu.be/tRxsBGWxowA?t=01h57m23s)

[overrides dictionary](https://youtu.be/tRxsBGWxowA?t=01h57m25s)

[I don't think it works inside of](https://youtu.be/tRxsBGWxowA?t=01h57m27s)

[here](https://youtu.be/tRxsBGWxowA?t=01h57m32s)

[right I don't think that is going to](https://youtu.be/tRxsBGWxowA?t=01h57m40s)

[override anything](https://youtu.be/tRxsBGWxowA?t=01h57m42s)

[oh it does it still works](https://youtu.be/tRxsBGWxowA?t=01h57m45s)

[why does it work](https://youtu.be/tRxsBGWxowA?t=01h57m48s)

[because these sit between](https://youtu.be/tRxsBGWxowA?t=01h57m56s)

[the running the dynamic brush](https://youtu.be/tRxsBGWxowA?t=01h58m04s)

[and there at run time okay](https://youtu.be/tRxsBGWxowA?t=01h58m09s)

[I think that works I think that works I](https://youtu.be/tRxsBGWxowA?t=01h58m11s)

[almost want to do a](https://youtu.be/tRxsBGWxowA?t=01h58m14s)

[a test run with just a couple of these](https://youtu.be/tRxsBGWxowA?t=01h58m17s)

[things to make sure but I think this is](https://youtu.be/tRxsBGWxowA?t=01h58m19s)

[fine then so I gend these up](https://youtu.be/tRxsBGWxowA?t=01h58m22s)

[I'm almost wondering if I really need to](https://youtu.be/tRxsBGWxowA?t=01h58m29s)

[gen](https://youtu.be/tRxsBGWxowA?t=01h58m31s)

[these linky ones up I've gotten it down](https://youtu.be/tRxsBGWxowA?t=01h58m33s)

[to where it's really easy](https://youtu.be/tRxsBGWxowA?t=01h58m36s)

[do I need these I need a separation](https://youtu.be/tRxsBGWxowA?t=01h58m39s)

[between](https://youtu.be/tRxsBGWxowA?t=01h58m43s)

[each of these](https://youtu.be/tRxsBGWxowA?t=01h58m46s)

[right because if I if I move these](https://youtu.be/tRxsBGWxowA?t=01h58m49s)

[things up](https://youtu.be/tRxsBGWxowA?t=01h58m52s)

[all right if I move these things into](https://youtu.be/tRxsBGWxowA?t=01h58m54s)

[the base there's no opportunity to](https://youtu.be/tRxsBGWxowA?t=01h58m56s)

[inject on the resolution because they](https://youtu.be/tRxsBGWxowA?t=01h58m58s)

[just resolve to the ones in the same](https://youtu.be/tRxsBGWxowA?t=01h59m00s)

[resource dictionary but the moment they](https://youtu.be/tRxsBGWxowA?t=01h59m01s)

[aren't in the same resource dictionary](https://youtu.be/tRxsBGWxowA?t=01h59m03s)

[and it has to resolve them](https://youtu.be/tRxsBGWxowA?t=01h59m05s)

[it is then forced to go through my](https://youtu.be/tRxsBGWxowA?t=01h59m08s)

[app.xaml or other resource dictionaries](https://youtu.be/tRxsBGWxowA?t=01h59m13s)

[which gives me an opportunity to get](https://youtu.be/tRxsBGWxowA?t=01h59m15s)

[between](https://youtu.be/tRxsBGWxowA?t=01h59m17s)

[where the brush is and where the color](https://youtu.be/tRxsBGWxowA?t=01h59m19s)

[is defined](https://youtu.be/tRxsBGWxowA?t=01h59m21s)

[I think that works](https://youtu.be/tRxsBGWxowA?t=01h59m25s)

[I think that works](https://youtu.be/tRxsBGWxowA?t=01h59m27s)

[I'm happy with it](https://youtu.be/tRxsBGWxowA?t=01h59m34s)

[I think the next step is then going to](https://youtu.be/tRxsBGWxowA?t=01h59m35s)

[be implement it and test it](https://youtu.be/tRxsBGWxowA?t=01h59m37s)

[but I think I I think I am happy with](https://youtu.be/tRxsBGWxowA?t=01h59m40s)

[that and then Jenning up that list that](https://youtu.be/tRxsBGWxowA?t=01h59m43s)

[might be the next step well no](https://youtu.be/tRxsBGWxowA?t=01h59m46s)

[we'll do a small proof of concept in the](https://youtu.be/tRxsBGWxowA?t=01h59m49s)

[material design app and do it but I](https://youtu.be/tRxsBGWxowA?t=01h59m51s)

[think I may end up](https://youtu.be/tRxsBGWxowA?t=01h59m53s)

[calling it for the night as the lack of](https://youtu.be/tRxsBGWxowA?t=01h59m55s)

[caffeine is getting me but as promised](https://youtu.be/tRxsBGWxowA?t=01h59m57s)

[okay I'm gonna turn off the](https://youtu.be/tRxsBGWxowA?t=02h00m00s)

[uh let's talk let's talk brain teaser](https://youtu.be/tRxsBGWxowA?t=02h00m05s)

[brain teaser okay so everybody's had](https://youtu.be/tRxsBGWxowA?t=02h00m09s)

[plenty of time](https://youtu.be/tRxsBGWxowA?t=02h00m13s)

[place place your bets now on the values](https://youtu.be/tRxsBGWxowA?t=02h00m15s)

[of a b and c okay and let's let's launch](https://youtu.be/tRxsBGWxowA?t=02h00m19s)

[and debug we'll start with the answer](https://youtu.be/tRxsBGWxowA?t=02h00m22s)

[and then work back to the why](https://youtu.be/tRxsBGWxowA?t=02h00m24s)

[okay so uh if we go locals](https://youtu.be/tRxsBGWxowA?t=02h00m30s)

[you will note](https://youtu.be/tRxsBGWxowA?t=02h00m34s)

[the values uh you know let me just drag](https://youtu.be/tRxsBGWxowA?t=02h00m36s)

[these over so they're nice and close to](https://youtu.be/tRxsBGWxowA?t=02h00m38s)

[each other](https://youtu.be/tRxsBGWxowA?t=02h00m39s)

[a](https://youtu.be/tRxsBGWxowA?t=02h00m42s)

[is year zero zero one](https://youtu.be/tRxsBGWxowA?t=02h00m44s)

[B is 1970 and C is zero zero one](https://youtu.be/tRxsBGWxowA?t=02h00m47s)

[okay so short version is B became the](https://youtu.be/tRxsBGWxowA?t=02h00m53s)

[1970 case](https://youtu.be/tRxsBGWxowA?t=02h00m59s)

[and A and C both got date time Min value](https://youtu.be/tRxsBGWxowA?t=02h01m01s)

[so let's let's walk through what's going](https://youtu.be/tRxsBGWxowA?t=02h01m05s)

[on here and see what's happening we're](https://youtu.be/tRxsBGWxowA?t=02h01m07s)

[going to start with b since B is the the](https://youtu.be/tRxsBGWxowA?t=02h01m09s)

[unusual use case](https://youtu.be/tRxsBGWxowA?t=02h01m11s)

[so in this case we're passing in a](https://youtu.be/tRxsBGWxowA?t=02h01m13s)

[nullable double](https://youtu.be/tRxsBGWxowA?t=02h01m15s)

[and there is a concept here because](https://youtu.be/tRxsBGWxowA?t=02h01m17s)

[nullable double int question mark is](https://youtu.be/tRxsBGWxowA?t=02h01m20s)

[identical to](https://youtu.be/tRxsBGWxowA?t=02h01m23s)

[uh nullable](https://youtu.be/tRxsBGWxowA?t=02h01m25s)

[that's what the in question mark](https://youtu.be/tRxsBGWxowA?t=02h01m28s)

[translates to these are functionally the](https://youtu.be/tRxsBGWxowA?t=02h01m30s)

[same you'll note that Visual Studio is](https://youtu.be/tRxsBGWxowA?t=02h01m32s)

[trying to say hey you don't need to do](https://youtu.be/tRxsBGWxowA?t=02h01m34s)

[this you can you can simplify the name](https://youtu.be/tRxsBGWxowA?t=02h01m36s)

[back down and they're the same great I](https://youtu.be/tRxsBGWxowA?t=02h01m38s)

[get it](https://youtu.be/tRxsBGWxowA?t=02h01m40s)

[what the the thing with nullable int and](https://youtu.be/tRxsBGWxowA?t=02h01m41s)

[um is you will note that this is a very](https://youtu.be/tRxsBGWxowA?t=02h01m45s)

[simple struct there's not a lot there's](https://youtu.be/tRxsBGWxowA?t=02h01m48s)

[not a lot going on here there's the](https://youtu.be/tRxsBGWxowA?t=02h01m50s)

[common has value value get value or](https://youtu.be/tRxsBGWxowA?t=02h01m52s)

[default the two string thing that we](https://youtu.be/tRxsBGWxowA?t=02h01m54s)

[abused last time](https://youtu.be/tRxsBGWxowA?t=02h01m56s)

[right but there is not](https://youtu.be/tRxsBGWxowA?t=02h01m58s)

[there's not operators defined on this so](https://youtu.be/tRxsBGWxowA?t=02h02m02s)

[for example less than is not defined](https://youtu.be/tRxsBGWxowA?t=02h02m05s)

[um so the question comes how is this](https://youtu.be/tRxsBGWxowA?t=02h02m09s)

[actually being evaluated the answer is](https://youtu.be/tRxsBGWxowA?t=02h02m11s)

[what is called lifted operators C sharp](https://youtu.be/tRxsBGWxowA?t=02h02m14s)

[so nullable of T is special it gets](https://youtu.be/tRxsBGWxowA?t=02h02m17s)

[special treatment you can't match it](https://youtu.be/tRxsBGWxowA?t=02h02m20s)

[um](https://youtu.be/tRxsBGWxowA?t=02h02m23s)

[what ends up happening is when you do a](https://youtu.be/tRxsBGWxowA?t=02h02m24s)

[comparison like this nullable of T first](https://youtu.be/tRxsBGWxowA?t=02h02m28s)

[checks for no](https://youtu.be/tRxsBGWxowA?t=02h02m31s)

[and if one side of this operand is null](https://youtu.be/tRxsBGWxowA?t=02h02m32s)

[it returns false so just straight up if](https://youtu.be/tRxsBGWxowA?t=02h02m37s)

[null doesn't matter what the value is on](https://youtu.be/tRxsBGWxowA?t=02h02m41s)

[the other side it's not greater than or](https://youtu.be/tRxsBGWxowA?t=02h02m44s)

[equal to straight up false which means](https://youtu.be/tRxsBGWxowA?t=02h02m46s)

[it can simultaneously be not greater](https://youtu.be/tRxsBGWxowA?t=02h02m49s)

[than or equal to and not less than or](https://youtu.be/tRxsBGWxowA?t=02h02m51s)

[equal to](https://youtu.be/tRxsBGWxowA?t=02h02m53s)

[simultaneously that's always that's](https://youtu.be/tRxsBGWxowA?t=02h02m54s)

[another fun one shoot spoiling another](https://youtu.be/tRxsBGWxowA?t=02h02m56s)

[brain teaser next time I'll show that so](https://youtu.be/tRxsBGWxowA?t=02h02m58s)

[the the lifted operator for the the turn](https://youtu.be/tRxsBGWxowA?t=02h03m01s)

[error here is important to understand so](https://youtu.be/tRxsBGWxowA?t=02h03m04s)

[for the null case it's going to not](https://youtu.be/tRxsBGWxowA?t=02h03m06s)

[return troll true it's going to always](https://youtu.be/tRxsBGWxowA?t=02h03m09s)

[be false and fall into default](https://youtu.be/tRxsBGWxowA?t=02h03m11s)

[um and then this guy here with negative](https://youtu.be/tRxsBGWxowA?t=02h03m14s)

[one negative one is also not greater](https://youtu.be/tRxsBGWxowA?t=02h03m16s)

[than or equal to zero so it falls into](https://youtu.be/tRxsBGWxowA?t=02h03m19s)

[default that makes sense zero is equal](https://youtu.be/tRxsBGWxowA?t=02h03m20s)

[to zero so we get nineteen seventy so](https://youtu.be/tRxsBGWxowA?t=02h03m23s)

[the null case is the only weird one](https://youtu.be/tRxsBGWxowA?t=02h03m26s)

[lifted operators that's the magical](https://youtu.be/tRxsBGWxowA?t=02h03m28s)

[answer](https://youtu.be/tRxsBGWxowA?t=02h03m30s)

[um the other one that's worth noting is](https://youtu.be/tRxsBGWxowA?t=02h03m31s)

[what this default is actually returning](https://youtu.be/tRxsBGWxowA?t=02h03m34s)

[so you'll note here that these are all](https://youtu.be/tRxsBGWxowA?t=02h03m36s)

[declared as nullable date times the](https://youtu.be/tRxsBGWxowA?t=02h03m38s)

[question mark on here and the function](https://youtu.be/tRxsBGWxowA?t=02h03m40s)

[here is also a notable date time](https://youtu.be/tRxsBGWxowA?t=02h03m43s)

[and the uh I made this thing an](https://youtu.be/tRxsBGWxowA?t=02h03m46s)

[expression bodied member but we're gonna](https://youtu.be/tRxsBGWxowA?t=02h03m48s)

[we're gonna start breaking this apart a](https://youtu.be/tRxsBGWxowA?t=02h03m50s)

[little to make it make a little more](https://youtu.be/tRxsBGWxowA?t=02h03m52s)

[sense](https://youtu.be/tRxsBGWxowA?t=02h03m53s)

[um and the important part to note is](https://youtu.be/tRxsBGWxowA?t=02h03m55s)

[people often assume that uh these things](https://youtu.be/tRxsBGWxowA?t=02h03m58s)

[here let's see will it uh with](https://youtu.be/tRxsBGWxowA?t=02h04m01s)

[statements](https://youtu.be/tRxsBGWxowA?t=02h04m04s)

[so you'll note there's there's a subtle](https://youtu.be/tRxsBGWxowA?t=02h04m06s)

[thing that has happened when I told it](https://youtu.be/tRxsBGWxowA?t=02h04m08s)

[to break it apart from a ternary is](https://youtu.be/tRxsBGWxowA?t=02h04m09s)

[rather than just doing a return of](https://youtu.be/tRxsBGWxowA?t=02h04m12s)

[default](https://youtu.be/tRxsBGWxowA?t=02h04m16s)

[it's doing a default of date time and I](https://youtu.be/tRxsBGWxowA?t=02h04m18s)

[do not love how it did that that's](https://youtu.be/tRxsBGWxowA?t=02h04m22s)

[clearer to me](https://youtu.be/tRxsBGWxowA?t=02h04m24s)

[regardless](https://youtu.be/tRxsBGWxowA?t=02h04m25s)

[it's doing a default of date time not](https://youtu.be/tRxsBGWxowA?t=02h04m26s)

[nullable date time](https://youtu.be/tRxsBGWxowA?t=02h04m29s)

[okay and the default of date time is](https://youtu.be/tRxsBGWxowA?t=02h04m31s)

[date time min](https://youtu.be/tRxsBGWxowA?t=02h04m35s)

[or Min value](https://youtu.be/tRxsBGWxowA?t=02h04m37s)

[but the default of nullable date time is](https://youtu.be/tRxsBGWxowA?t=02h04m39s)

[null two different things because date](https://youtu.be/tRxsBGWxowA?t=02h04m42s)

[time is also a struct](https://youtu.be/tRxsBGWxowA?t=02h04m44s)

[all right we look at that e is a struct](https://youtu.be/tRxsBGWxowA?t=02h04m46s)

[so a value type](https://youtu.be/tRxsBGWxowA?t=02h04m49s)

[but the important thing to note so if we](https://youtu.be/tRxsBGWxowA?t=02h04m52s)

[look at this it becomes pretty obvious](https://youtu.be/tRxsBGWxowA?t=02h04m55s)

[to understand why we didn't get a null](https://youtu.be/tRxsBGWxowA?t=02h04m56s)

[back for either a or c](https://youtu.be/tRxsBGWxowA?t=02h04m58s)

[right](https://youtu.be/tRxsBGWxowA?t=02h05m01s)

[is because this default here is actually](https://youtu.be/tRxsBGWxowA?t=02h05m02s)

[the default of a date time not a date](https://youtu.be/tRxsBGWxowA?t=02h05m05s)

[time nullable now if we go all the way](https://youtu.be/tRxsBGWxowA?t=02h05m08s)

[back into this vicinity what gets](https://youtu.be/tRxsBGWxowA?t=02h05m11s)

[confusing is when you have a ternary](https://youtu.be/tRxsBGWxowA?t=02h05m14s)

[here](https://youtu.be/tRxsBGWxowA?t=02h05m16s)

[this default is effectively the same as](https://youtu.be/tRxsBGWxowA?t=02h05m17s)

[if you put this inside of parents](https://youtu.be/tRxsBGWxowA?t=02h05m21s)

[so](https://youtu.be/tRxsBGWxowA?t=02h05m23s)

[you first have to evaluate the ternary](https://youtu.be/tRxsBGWxowA?t=02h05m25s)

[expression and the compiler evaluates](https://youtu.be/tRxsBGWxowA?t=02h05m28s)

[the ternary expression as both the true](https://youtu.be/tRxsBGWxowA?t=02h05m31s)

[and the false case as returning a date](https://youtu.be/tRxsBGWxowA?t=02h05m34s)

[time object not a millable date time](https://youtu.be/tRxsBGWxowA?t=02h05m37s)

[object](https://youtu.be/tRxsBGWxowA?t=02h05m40s)

[this](https://youtu.be/tRxsBGWxowA?t=02h05m42s)

[to to make the point even more clear](https://youtu.be/tRxsBGWxowA?t=02h05m43s)

[if you went date time question mark on](https://youtu.be/tRxsBGWxowA?t=02h05m46s)

[this side](https://youtu.be/tRxsBGWxowA?t=02h05m49s)

[you've now changed the behavior](https://youtu.be/tRxsBGWxowA?t=02h05m50s)

[because now the compiler looks at it and](https://youtu.be/tRxsBGWxowA?t=02h05m55s)

[goes ah ah I can now see that this side](https://youtu.be/tRxsBGWxowA?t=02h05m57s)

[of the ternary is a notable date time](https://youtu.be/tRxsBGWxowA?t=02h06m01s)

[therefore this thing also must be a](https://youtu.be/tRxsBGWxowA?t=02h06m03s)

[nullable date time so if we run this](https://youtu.be/tRxsBGWxowA?t=02h06m06s)

[you'll note I haven't touched the](https://youtu.be/tRxsBGWxowA?t=02h06m09s)

[default side I've only touched the true](https://youtu.be/tRxsBGWxowA?t=02h06m10s)

[side](https://youtu.be/tRxsBGWxowA?t=02h06m11s)

[you'll note now rather than getting date](https://youtu.be/tRxsBGWxowA?t=02h06m18s)

[time Min value when we hit the false](https://youtu.be/tRxsBGWxowA?t=02h06m20s)

[case we now get null](https://youtu.be/tRxsBGWxowA?t=02h06m22s)

[so the the key thing to to catch here](https://youtu.be/tRxsBGWxowA?t=02h06m24s)

[that I should say that the interview](https://youtu.be/tRxsBGWxowA?t=02h06m27s)

[answer for when somebody tries to trip](https://youtu.be/tRxsBGWxowA?t=02h06m29s)

[you up with this in an interview](https://youtu.be/tRxsBGWxowA?t=02h06m31s)

[hopefully they don't ask questions like](https://youtu.be/tRxsBGWxowA?t=02h06m33s)

[this in your interview brain teasers](https://youtu.be/tRxsBGWxowA?t=02h06m34s)

[like this are not good integrated](https://youtu.be/tRxsBGWxowA?t=02h06m36s)

[questions](https://youtu.be/tRxsBGWxowA?t=02h06m37s)

[um](https://youtu.be/tRxsBGWxowA?t=02h06m39s)

[the the key thing to to point out here](https://youtu.be/tRxsBGWxowA?t=02h06m40s)

[is that the default is part of the](https://youtu.be/tRxsBGWxowA?t=02h06m43s)

[ternary not part of the return](https://youtu.be/tRxsBGWxowA?t=02h06m46s)

[so despite what](https://youtu.be/tRxsBGWxowA?t=02h06m49s)

[despite how it may look yeah sorry](https://youtu.be/tRxsBGWxowA?t=02h06m51s)

[Justin Bieber](https://youtu.be/tRxsBGWxowA?t=02h06m54s)

[which this code typically like in most](https://youtu.be/tRxsBGWxowA?t=02h06m57s)

[cases this code would look perfectly](https://youtu.be/tRxsBGWxowA?t=02h07m01s)

[reasonable and it for a lot of code](https://youtu.be/tRxsBGWxowA?t=02h07m03s)

[review this would probably pass without](https://youtu.be/tRxsBGWxowA?t=02h07m06s)

[people giving it a second thought they](https://youtu.be/tRxsBGWxowA?t=02h07m08s)

[just read through it and go oh yeah blah](https://youtu.be/tRxsBGWxowA?t=02h07m10s)

[blah but this is what actually came up](https://youtu.be/tRxsBGWxowA?t=02h07m12s)

[in in our code review is there was a](https://youtu.be/tRxsBGWxowA?t=02h07m14s)

[subtle difference where they were](https://youtu.be/tRxsBGWxowA?t=02h07m16s)

[expecting a null and they weren't](https://youtu.be/tRxsBGWxowA?t=02h07m17s)

[getting it](https://youtu.be/tRxsBGWxowA?t=02h07m19s)

[again also write unit tests that saves](https://youtu.be/tRxsBGWxowA?t=02h07m21s)

[you this pain and suffering but](https://youtu.be/tRxsBGWxowA?t=02h07m23s)

[um making sure that it's clear that when](https://youtu.be/tRxsBGWxowA?t=02h07m25s)

[you do a default without specifying the](https://youtu.be/tRxsBGWxowA?t=02h07m27s)

[type](https://youtu.be/tRxsBGWxowA?t=02h07m29s)

[um and I I guess I'll point out here if](https://youtu.be/tRxsBGWxowA?t=02h07m36s)

[we specify the the the type for default](https://youtu.be/tRxsBGWxowA?t=02h07m38s)

[you'll note when I specify date time](https://youtu.be/tRxsBGWxowA?t=02h07m40s)

[default went yeah you don't need that](https://youtu.be/tRxsBGWxowA?t=02h07m42s)

[that's optional when you specify it with](https://youtu.be/tRxsBGWxowA?t=02h07m44s)

[the question mark it goes hang on hang](https://youtu.be/tRxsBGWxowA?t=02h07m46s)

[on](https://youtu.be/tRxsBGWxowA?t=02h07m48s)

[now I need you to tell me the type](https://youtu.be/tRxsBGWxowA?t=02h07m49s)

[because this is different than what I](https://youtu.be/tRxsBGWxowA?t=02h07m51s)

[was going to do right when the compiler](https://youtu.be/tRxsBGWxowA?t=02h07m53s)

[agrees it out that basically means the](https://youtu.be/tRxsBGWxowA?t=02h07m55s)

[compiler going yeah yeah I knew that you](https://youtu.be/tRxsBGWxowA?t=02h07m56s)

[didn't need to tell me but when it's not](https://youtu.be/tRxsBGWxowA?t=02h07m58s)

[grayed out that's probably going whoa oh](https://youtu.be/tRxsBGWxowA?t=02h08m00s)

[you're doing something different I'm my](https://youtu.be/tRxsBGWxowA?t=02h08m03s)

[bad I I'm I missed I got that one wrong](https://youtu.be/tRxsBGWxowA?t=02h08m04s)

[because now it's changed the the return](https://youtu.be/tRxsBGWxowA?t=02h08m07s)

[type from the ternary expression thus](https://youtu.be/tRxsBGWxowA?t=02h08m10s)

[changing the return type of the meth or](https://youtu.be/tRxsBGWxowA?t=02h08m13s)

[the return value to the method](https://youtu.be/tRxsBGWxowA?t=02h08m15s)

[so uh General guidance of what I would](https://youtu.be/tRxsBGWxowA?t=02h08m17s)

[tell you here is if you use default](https://youtu.be/tRxsBGWxowA?t=02h08m20s)

[without specifying the type make sure](https://youtu.be/tRxsBGWxowA?t=02h08m22s)

[the type is obvious this is no different](https://youtu.be/tRxsBGWxowA?t=02h08m25s)

[than like the guidance around using VAR](https://youtu.be/tRxsBGWxowA?t=02h08m27s)

[of if you use VAR the type should be](https://youtu.be/tRxsBGWxowA?t=02h08m29s)

[obvious if you used if you use default](https://youtu.be/tRxsBGWxowA?t=02h08m32s)

[without specifying the type the type](https://youtu.be/tRxsBGWxowA?t=02h08m35s)

[should be obvious and you can also you](https://youtu.be/tRxsBGWxowA?t=02h08m37s)

[know hover your just like VAR you can](https://youtu.be/tRxsBGWxowA?t=02h08m38s)

[hover your mouse on it and see what the](https://youtu.be/tRxsBGWxowA?t=02h08m40s)

[compiler thinks the type is right the](https://youtu.be/tRxsBGWxowA?t=02h08m42s)

[compiler is inferring date time](https://youtu.be/tRxsBGWxowA?t=02h08m44s)

[not knowable daytime](https://youtu.be/tRxsBGWxowA?t=02h08m46s)

[oops so use the tools](https://youtu.be/tRxsBGWxowA?t=02h08m49s)

[be be conscious of when things are](https://youtu.be/tRxsBGWxowA?t=02h08m52s)

[different than what you expect the](https://youtu.be/tRxsBGWxowA?t=02h08m56s)

[defaults to be](https://youtu.be/tRxsBGWxowA?t=02h08m57s)

[but there's the answer so](https://youtu.be/tRxsBGWxowA?t=02h08m59s)

[daytime in daytime men](https://youtu.be/tRxsBGWxowA?t=02h09m02s)

[1970 or Unix epoch if you want to get](https://youtu.be/tRxsBGWxowA?t=02h09m05s)

[real fancy with it](https://youtu.be/tRxsBGWxowA?t=02h09m09s)

[but I think with that I'm going to tell](https://youtu.be/tRxsBGWxowA?t=02h09m11s)

[everyone thank you for coming and](https://youtu.be/tRxsBGWxowA?t=02h09m13s)

[hanging out I appreciate all of the uh](https://youtu.be/tRxsBGWxowA?t=02h09m14s)

[the old faces and and new names of](https://youtu.be/tRxsBGWxowA?t=02h09m17s)

[people dropping in with questions](https://youtu.be/tRxsBGWxowA?t=02h09m20s)

[comments as always I love questions I](https://youtu.be/tRxsBGWxowA?t=02h09m21s)

[have no problem getting side railed on](https://youtu.be/tRxsBGWxowA?t=02h09m24s)

[uh answering questions or looking at uh](https://youtu.be/tRxsBGWxowA?t=02h09m25s)

[things yeah glad you enjoyed the brain](https://youtu.be/tRxsBGWxowA?t=02h09m28s)

[teaser Justin Bieber like I said if](https://youtu.be/tRxsBGWxowA?t=02h09m31s)

[anybody's interested check out YouTube](https://youtu.be/tRxsBGWxowA?t=02h09m33s)

[um I'm hoping to start putting together](https://youtu.be/tRxsBGWxowA?t=02h09m36s)

[some short video content with with these](https://youtu.be/tRxsBGWxowA?t=02h09m37s)

[brain teasers in there for those people](https://youtu.be/tRxsBGWxowA?t=02h09m39s)

[who watch My Stream regularly uh spoiler](https://youtu.be/tRxsBGWxowA?t=02h09m41s)

[the first ones are probably going to be](https://youtu.be/tRxsBGWxowA?t=02h09m43s)

[repeats so don't worry get to newer](https://youtu.be/tRxsBGWxowA?t=02h09m45s)

[content but I've got a whole slew of](https://youtu.be/tRxsBGWxowA?t=02h09m47s)

[these kind of little things that I keep](https://youtu.be/tRxsBGWxowA?t=02h09m49s)

[saving every time they come up so I need](https://youtu.be/tRxsBGWxowA?t=02h09m51s)

[to actually like put them into uh](https://youtu.be/tRxsBGWxowA?t=02h09m53s)

[useful things rather than just slapping](https://youtu.be/tRxsBGWxowA?t=02h09m55s)

[them in in little unit tests here so](https://youtu.be/tRxsBGWxowA?t=02h09m58s)

[tell everyone good night happy coding](https://youtu.be/tRxsBGWxowA?t=02h10m00s)

[see everyone next time](https://youtu.be/tRxsBGWxowA?t=02h10m03s)

