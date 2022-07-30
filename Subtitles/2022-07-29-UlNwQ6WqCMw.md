[YouTube Video](https://youtu.be/UlNwQ6WqCMw)



[hello everyone welcome back](https://youtu.be/UlNwQ6WqCMw?t=00h00m03s)

[uh tonight i'm gonna go](https://youtu.be/UlNwQ6WqCMw?t=00h00m05s)

[kind of a little tangential to what i](https://youtu.be/UlNwQ6WqCMw?t=00h00m07s)

[normally do with c sharp and wpf and](https://youtu.be/UlNwQ6WqCMw?t=00h00m09s)

[actually look at doing some deployment](https://youtu.be/UlNwQ6WqCMw?t=00h00m11s)

[stuff um just an update for those people](https://youtu.be/UlNwQ6WqCMw?t=00h00m12s)

[who watched last week's stream with uh](https://youtu.be/UlNwQ6WqCMw?t=00h00m15s)

[xaml test](https://youtu.be/UlNwQ6WqCMw?t=00h00m17s)

[um i'm a little ashamed to say](https://youtu.be/UlNwQ6WqCMw?t=00h00m18s)

[right at the end i kind of uh quit](https://youtu.be/UlNwQ6WqCMw?t=00h00m20s)

[because i couldn't get both tests to](https://youtu.be/UlNwQ6WqCMw?t=00h00m22s)

[work it turns out they were working just](https://youtu.be/UlNwQ6WqCMw?t=00h00m24s)

[fine i just needed to do a get clean](https://youtu.be/UlNwQ6WqCMw?t=00h00m26s)

[first so](https://youtu.be/UlNwQ6WqCMw?t=00h00m28s)

[yeah oops](https://youtu.be/UlNwQ6WqCMw?t=00h00m30s)

[um yeah i was very confused the next day](https://youtu.be/UlNwQ6WqCMw?t=00h00m32s)

[when i went to take a crack at it and](https://youtu.be/UlNwQ6WqCMw?t=00h00m34s)

[everything was working i was very very](https://youtu.be/UlNwQ6WqCMw?t=00h00m35s)

[confused for a few minutes](https://youtu.be/UlNwQ6WqCMw?t=00h00m37s)

[um but tonight we're going to look at a](https://youtu.be/UlNwQ6WqCMw?t=00h00m39s)

[deployment](https://youtu.be/UlNwQ6WqCMw?t=00h00m41s)

[technology i guess installer technology](https://youtu.be/UlNwQ6WqCMw?t=00h00m43s)

[called squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h00m45s)

[so](https://youtu.be/UlNwQ6WqCMw?t=00h00m47s)

[real quick](https://youtu.be/UlNwQ6WqCMw?t=00h00m47s)

[shameless self-promotion i wrote a blog](https://youtu.be/UlNwQ6WqCMw?t=00h00m49s)

[post on squirrel a very long time ago](https://youtu.be/UlNwQ6WqCMw?t=00h00m51s)

[these things aren't dated and i don't](https://youtu.be/UlNwQ6WqCMw?t=00h00m55s)

[remember how old this is it's at least a](https://youtu.be/UlNwQ6WqCMw?t=00h00m56s)

[couple of years it's been a little while](https://youtu.be/UlNwQ6WqCMw?t=00h00m58s)

[but i walk through kind of everything](https://youtu.be/UlNwQ6WqCMw?t=00h01m01s)

[everything from you know a](https://youtu.be/UlNwQ6WqCMw?t=00h01m03s)

[simple wpf application that's basically](https://youtu.be/UlNwQ6WqCMw?t=00h01m05s)

[hello world doing the new spec file yada](https://youtu.be/UlNwQ6WqCMw?t=00h01m08s)

[yada build stuff up do updates](https://youtu.be/UlNwQ6WqCMw?t=00h01m11s)

[i realized i'm yada yada yada in all the](https://youtu.be/UlNwQ6WqCMw?t=00h01m15s)

[cool parts but](https://youtu.be/UlNwQ6WqCMw?t=00h01m17s)

[um if you are interested in squirrel it](https://youtu.be/UlNwQ6WqCMw?t=00h01m19s)

[is here and the](https://youtu.be/UlNwQ6WqCMw?t=00h01m21s)

[the actual repo that i reference it's](https://youtu.be/UlNwQ6WqCMw?t=00h01m23s)

[also referenced in that blog post is](https://youtu.be/UlNwQ6WqCMw?t=00h01m25s)

[here and there's a lot of steps to it](https://youtu.be/UlNwQ6WqCMw?t=00h01m26s)

[you have to go through and make a new](https://youtu.be/UlNwQ6WqCMw?t=00h01m29s)

[spec you gotta](https://youtu.be/UlNwQ6WqCMw?t=00h01m31s)

[squirrel works by wrapping your package](https://youtu.be/UlNwQ6WqCMw?t=00h01m33s)

[into a nougat package even though it's](https://youtu.be/UlNwQ6WqCMw?t=00h01m35s)

[never going to nudeget.org it's just](https://youtu.be/UlNwQ6WqCMw?t=00h01m38s)

[using that as a way of doing um](https://youtu.be/UlNwQ6WqCMw?t=00h01m40s)

[packaging metadata versioning all of](https://youtu.be/UlNwQ6WqCMw?t=00h01m42s)

[that stuff which is great](https://youtu.be/UlNwQ6WqCMw?t=00h01m44s)

[and the squirrel installers tend to be](https://youtu.be/UlNwQ6WqCMw?t=00h01m46s)

[really really fast](https://youtu.be/UlNwQ6WqCMw?t=00h01m48s)

[like](https://youtu.be/UlNwQ6WqCMw?t=00h01m50s)

[they oftentimes won't display a splash](https://youtu.be/UlNwQ6WqCMw?t=00h01m51s)

[screen because they get your app](https://youtu.be/UlNwQ6WqCMw?t=00h01m53s)

[installed so fast](https://youtu.be/UlNwQ6WqCMw?t=00h01m55s)

[which is impressive like the the tagline](https://youtu.be/UlNwQ6WqCMw?t=00h01m57s)

[it's like click once that works or as i](https://youtu.be/UlNwQ6WqCMw?t=00h01m59s)

[usually call it clunk once](https://youtu.be/UlNwQ6WqCMw?t=00h02m01s)

[it is effectively what it is for those](https://youtu.be/UlNwQ6WqCMw?t=00h02m03s)

[people who may not know click once this](https://youtu.be/UlNwQ6WqCMw?t=00h02m04s)

[is microsoft's um installer technology](https://youtu.be/UlNwQ6WqCMw?t=00h02m06s)

[you've probably used it um i believe](https://youtu.be/UlNwQ6WqCMw?t=00h02m09s)

[chrome's installer not chrome itself but](https://youtu.be/UlNwQ6WqCMw?t=00h02m12s)

[the chrome installer actually uses click](https://youtu.be/UlNwQ6WqCMw?t=00h02m14s)

[once just to bootstrap it and get out](https://youtu.be/UlNwQ6WqCMw?t=00h02m16s)

[there and it works fairly well um it's](https://youtu.be/UlNwQ6WqCMw?t=00h02m18s)

[kind of clunky uh hence my name of clunk](https://youtu.be/UlNwQ6WqCMw?t=00h02m22s)

[once uh](https://youtu.be/UlNwQ6WqCMw?t=00h02m25s)

[and it's not real tolerant of network](https://youtu.be/UlNwQ6WqCMw?t=00h02m27s)

[outages so i've used it on some projects](https://youtu.be/UlNwQ6WqCMw?t=00h02m29s)

[and specifically if you have users that](https://youtu.be/UlNwQ6WqCMw?t=00h02m31s)

[are on a shaky internet connection it](https://youtu.be/UlNwQ6WqCMw?t=00h02m33s)

[can sometimes be](https://youtu.be/UlNwQ6WqCMw?t=00h02m35s)

[problematic and when it goes poorly](https://youtu.be/UlNwQ6WqCMw?t=00h02m36s)

[it's a pain to debug it is just an](https://youtu.be/UlNwQ6WqCMw?t=00h02m39s)

[absolute nightmare](https://youtu.be/UlNwQ6WqCMw?t=00h02m41s)

[but installers aren't that easy to build](https://youtu.be/UlNwQ6WqCMw?t=00h02m42s)

[if anybody has ever looked into like the](https://youtu.be/UlNwQ6WqCMw?t=00h02m45s)

[installer technology wix and written one](https://youtu.be/UlNwQ6WqCMw?t=00h02m46s)

[of those things by hand you're you're](https://youtu.be/UlNwQ6WqCMw?t=00h02m49s)

[aware of how complicated](https://youtu.be/UlNwQ6WqCMw?t=00h02m50s)

[getting an installer and all of the](https://youtu.be/UlNwQ6WqCMw?t=00h02m53s)

[registrations and all that stuff correct](https://youtu.be/UlNwQ6WqCMw?t=00h02m54s)

[really is](https://youtu.be/UlNwQ6WqCMw?t=00h02m57s)

[squirrel tries to make that as easy as](https://youtu.be/UlNwQ6WqCMw?t=00h02m58s)

[possible and to their credit they do a](https://youtu.be/UlNwQ6WqCMw?t=00h03m00s)

[pretty good job and it's fairly well](https://youtu.be/UlNwQ6WqCMw?t=00h03m02s)

[documented](https://youtu.be/UlNwQ6WqCMw?t=00h03m04s)

[however there is a spin-off product](https://youtu.be/UlNwQ6WqCMw?t=00h03m05s)

[called cloud squirrel that i was gonna i](https://youtu.be/UlNwQ6WqCMw?t=00h03m08s)

[was gonna take a look at](https://youtu.be/UlNwQ6WqCMw?t=00h03m11s)

[because it looks really really promising](https://youtu.be/UlNwQ6WqCMw?t=00h03m12s)

[so you'll note this was originally](https://youtu.be/UlNwQ6WqCMw?t=00h03m15s)

[forked from squirrel.windows](https://youtu.be/UlNwQ6WqCMw?t=00h03m17s)

[squirrel.windows at one point in time um](https://youtu.be/UlNwQ6WqCMw?t=00h03m19s)

[had thrown up a banner saying that they](https://youtu.be/UlNwQ6WqCMw?t=00h03m21s)

[were looking for new maintainers but i i](https://youtu.be/UlNwQ6WqCMw?t=00h03m23s)

[think they're past that i don't i](https://youtu.be/UlNwQ6WqCMw?t=00h03m25s)

[haven't played in their issue list in a](https://youtu.be/UlNwQ6WqCMw?t=00h03m27s)

[while](https://youtu.be/UlNwQ6WqCMw?t=00h03m28s)

[but this one down here forked off of](https://youtu.be/UlNwQ6WqCMw?t=00h03m30s)

[that](https://youtu.be/UlNwQ6WqCMw?t=00h03m32s)

[and made a bunch of changes so and this](https://youtu.be/UlNwQ6WqCMw?t=00h03m32s)

[is kind of where they they call them out](https://youtu.be/UlNwQ6WqCMw?t=00h03m35s)

[so this continuous updates and fixes](https://youtu.be/UlNwQ6WqCMw?t=00h03m37s)

[this is i largely an artifact of](https://youtu.be/UlNwQ6WqCMw?t=00h03m39s)

[squirrel has scroll.windows hasn't](https://youtu.be/UlNwQ6WqCMw?t=00h03m42s)

[gotten a lot of love to its credit it](https://youtu.be/UlNwQ6WqCMw?t=00h03m44s)

[hasn't needed a lot of love with the](https://youtu.be/UlNwQ6WqCMw?t=00h03m46s)

[exception of one of its dependent](https://youtu.be/UlNwQ6WqCMw?t=00h03m48s)

[libraries being woefully out of date](https://youtu.be/UlNwQ6WqCMw?t=00h03m49s)

[i haven't really had a lot of complaints](https://youtu.be/UlNwQ6WqCMw?t=00h03m52s)

[with it](https://youtu.be/UlNwQ6WqCMw?t=00h03m54s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h03m55s)

[it does add a significant size](https://youtu.be/UlNwQ6WqCMw?t=00h03m57s)

[to the bootstrapper the update.exe so](https://youtu.be/UlNwQ6WqCMw?t=00h04m00s)

[beware it is](https://youtu.be/UlNwQ6WqCMw?t=00h04m03s)

[compared to scroll.windows it's bigger](https://youtu.be/UlNwQ6WqCMw?t=00h04m05s)

[but it also does a lot more so](https://youtu.be/UlNwQ6WqCMw?t=00h04m07s)

[tweet your zone um and you'll also note](https://youtu.be/UlNwQ6WqCMw?t=00h04m11s)

[it does uh](https://youtu.be/UlNwQ6WqCMw?t=00h04m13s)

[the sdk is updated for latest and](https://youtu.be/UlNwQ6WqCMw?t=00h04m15s)

[greatest stuff they added xml comments](https://youtu.be/UlNwQ6WqCMw?t=00h04m17s)

[sdk dependencies you'll note](https://youtu.be/UlNwQ6WqCMw?t=00h04m19s)

[this one has a lot more dependencies and](https://youtu.be/UlNwQ6WqCMw?t=00h04m21s)

[this sharp compress is the sec the the](https://youtu.be/UlNwQ6WqCMw?t=00h04m24s)

[one that i had commented was woefully](https://youtu.be/UlNwQ6WqCMw?t=00h04m26s)

[out of date](https://youtu.be/UlNwQ6WqCMw?t=00h04m28s)

[um they apparently have](https://youtu.be/UlNwQ6WqCMw?t=00h04m30s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h04m32s)

[significantly shrunk it i'm a little](https://youtu.be/UlNwQ6WqCMw?t=00h04m33s)

[curious how they're doing it without m](https://youtu.be/UlNwQ6WqCMw?t=00h04m34s)

[without including mono cecil so i'm not](https://youtu.be/UlNwQ6WqCMw?t=00h04m36s)

[entirely sure how that works](https://youtu.be/UlNwQ6WqCMw?t=00h04m38s)

[um the strong name signed](https://youtu.be/UlNwQ6WqCMw?t=00h04m40s)

[yeah yada yada yada](https://youtu.be/UlNwQ6WqCMw?t=00h04m43s)

[all kinds of cool stuff though the other](https://youtu.be/UlNwQ6WqCMw?t=00h04m45s)

[thing that actually interested me the](https://youtu.be/UlNwQ6WqCMw?t=00h04m48s)

[most is](https://youtu.be/UlNwQ6WqCMw?t=00h04m49s)

[um there's a couple comments that](https://youtu.be/UlNwQ6WqCMw?t=00h04m51s)

[they're working on a 3-0](https://youtu.be/UlNwQ6WqCMw?t=00h04m53s)

[that is supposed to be cross plat](https://youtu.be/UlNwQ6WqCMw?t=00h04m55s)

[which](https://youtu.be/UlNwQ6WqCMw?t=00h04m58s)

[squirrel and](https://youtu.be/UlNwQ6WqCMw?t=00h04m59s)

[cloud squirrel v2 and squirrel.windows](https://youtu.be/UlNwQ6WqCMw?t=00h05m01s)

[are are windows only now you don't have](https://youtu.be/UlNwQ6WqCMw?t=00h05m04s)

[to you don't have to use net apps at all](https://youtu.be/UlNwQ6WqCMw?t=00h05m06s)

[you can use this to distribute any old](https://youtu.be/UlNwQ6WqCMw?t=00h05m08s)

[thing that you want which is great](https://youtu.be/UlNwQ6WqCMw?t=00h05m10s)

[um it is worth noting that it is a per](https://youtu.be/UlNwQ6WqCMw?t=00h05m12s)

[user install so if you're running like a](https://youtu.be/UlNwQ6WqCMw?t=00h05m15s)

[global admin install thing you have to](https://youtu.be/UlNwQ6WqCMw?t=00h05m17s)

[jump through some extra](https://youtu.be/UlNwQ6WqCMw?t=00h05m19s)

[hoops for that](https://youtu.be/UlNwQ6WqCMw?t=00h05m21s)

[and it's not easy to build it doesn't](https://youtu.be/UlNwQ6WqCMw?t=00h05m23s)

[really give you an easy option to have](https://youtu.be/UlNwQ6WqCMw?t=00h05m25s)

[like a single installer that lets you](https://youtu.be/UlNwQ6WqCMw?t=00h05m26s)

[pick hey do you want to install per user](https://youtu.be/UlNwQ6WqCMw?t=00h05m28s)

[or per machine that kind of thing so it](https://youtu.be/UlNwQ6WqCMw?t=00h05m30s)

[doesn't quite give you that it aims to](https://youtu.be/UlNwQ6WqCMw?t=00h05m32s)

[be simple no wizardy next next next](https://youtu.be/UlNwQ6WqCMw?t=00h05m34s)

[finish type install experience it's a](https://youtu.be/UlNwQ6WqCMw?t=00h05m37s)

[double-click install done type](https://youtu.be/UlNwQ6WqCMw?t=00h05m39s)

[experience is what is what this aims to](https://youtu.be/UlNwQ6WqCMw?t=00h05m41s)

[do](https://youtu.be/UlNwQ6WqCMw?t=00h05m42s)

[um so 3-0 which i don't think we're](https://youtu.be/UlNwQ6WqCMw?t=00h05m43s)

[going to play with because it looks like](https://youtu.be/UlNwQ6WqCMw?t=00h05m46s)

[it's still very much in the works um but](https://youtu.be/UlNwQ6WqCMw?t=00h05m47s)

[it is](https://youtu.be/UlNwQ6WqCMw?t=00h05m50s)

[potentially going to be a cross-plat](https://youtu.be/UlNwQ6WqCMw?t=00h05m51s)

[version which is another thing that that](https://youtu.be/UlNwQ6WqCMw?t=00h05m54s)

[interested me in going here it's like oh](https://youtu.be/UlNwQ6WqCMw?t=00h05m56s)

[i'm i'm going to use this to deploy a](https://youtu.be/UlNwQ6WqCMw?t=00h05m58s)

[wpf app which means windows only so i](https://youtu.be/UlNwQ6WqCMw?t=00h06m00s)

[don't actually care yet but it is it is](https://youtu.be/UlNwQ6WqCMw?t=00h06m02s)

[an interesting idea](https://youtu.be/UlNwQ6WqCMw?t=00h06m05s)

[the bigger thing for me](https://youtu.be/UlNwQ6WqCMw?t=00h06m06s)

[is the the steps that it shows here so](https://youtu.be/UlNwQ6WqCMw?t=00h06m08s)

[step one is get your app in a releasable](https://youtu.be/UlNwQ6WqCMw?t=00h06m11s)

[state so whatever that means right](https://youtu.be/UlNwQ6WqCMw?t=00h06m14s)

[do the do the compile do whatever you](https://youtu.be/UlNwQ6WqCMw?t=00h06m16s)

[need to do to get your app in a](https://youtu.be/UlNwQ6WqCMw?t=00h06m19s)

[releasable state for net apps that's](https://youtu.be/UlNwQ6WqCMw?t=00h06m20s)

[usually a dot net publish with the](https://youtu.be/UlNwQ6WqCMw?t=00h06m22s)

[configuration of release into some known](https://youtu.be/UlNwQ6WqCMw?t=00h06m24s)

[directory right](https://youtu.be/UlNwQ6WqCMw?t=00h06m26s)

[typically for a net app that's how we](https://youtu.be/UlNwQ6WqCMw?t=00h06m28s)

[publish](https://youtu.be/UlNwQ6WqCMw?t=00h06m30s)

[yeah cross plat cross cross-plat looks](https://youtu.be/UlNwQ6WqCMw?t=00h06m31s)

[interesting now i will call out when it](https://youtu.be/UlNwQ6WqCMw?t=00h06m34s)

[says cross-plat](https://youtu.be/UlNwQ6WqCMw?t=00h06m36s)

[currently what they mean is they are](https://youtu.be/UlNwQ6WqCMw?t=00h06m37s)

[looking to add os x support](https://youtu.be/UlNwQ6WqCMw?t=00h06m39s)

[and with linux being a question mark](https://youtu.be/UlNwQ6WqCMw?t=00h06m42s)

[so just just to be clear when they say](https://youtu.be/UlNwQ6WqCMw?t=00h06m45s)

[some people hear cross plating they](https://youtu.be/UlNwQ6WqCMw?t=00h06m47s)

[immediately assume windows os x and](https://youtu.be/UlNwQ6WqCMw?t=00h06m49s)

[linux but in this case it's really just](https://youtu.be/UlNwQ6WqCMw?t=00h06m51s)

[os x](https://youtu.be/UlNwQ6WqCMw?t=00h06m54s)

[um though at the same time linux users](https://youtu.be/UlNwQ6WqCMw?t=00h06m55s)

[they tend to be a little more](https://youtu.be/UlNwQ6WqCMw?t=00h06m57s)

[happy](https://youtu.be/UlNwQ6WqCMw?t=00h06m59s)

[like being in](https://youtu.be/UlNwQ6WqCMw?t=00h07m00s)

[ultra control of things and command](https://youtu.be/UlNwQ6WqCMw?t=00h07m02s)

[lining all the stuff and](https://youtu.be/UlNwQ6WqCMw?t=00h07m04s)

[usually linux users don't mind not](https://youtu.be/UlNwQ6WqCMw?t=00h07m06s)

[having installers](https://youtu.be/UlNwQ6WqCMw?t=00h07m08s)

[or what it's worth um but and then these](https://youtu.be/UlNwQ6WqCMw?t=00h07m10s)

[two lines here or i should say this line](https://youtu.be/UlNwQ6WqCMw?t=00h07m12s)

[here does it isn't actually required all](https://youtu.be/UlNwQ6WqCMw?t=00h07m15s)

[this is doing is setting up an alias so](https://youtu.be/UlNwQ6WqCMw?t=00h07m17s)

[they can just say squirrel squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h07m19s)

[because ultimately you have to use their](https://youtu.be/UlNwQ6WqCMw?t=00h07m22s)

[little cli app to package things up and](https://youtu.be/UlNwQ6WqCMw?t=00h07m24s)

[they've eliminated the or at least i](https://youtu.be/UlNwQ6WqCMw?t=00h07m27s)

[should say it appears that they've](https://youtu.be/UlNwQ6WqCMw?t=00h07m29s)

[eliminated the need to like spin your](https://youtu.be/UlNwQ6WqCMw?t=00h07m30s)

[own new spec file and all of that which](https://youtu.be/UlNwQ6WqCMw?t=00h07m33s)

[if you read that blog post i put in the](https://youtu.be/UlNwQ6WqCMw?t=00h07m35s)

[the new spec file is really just to hold](https://youtu.be/UlNwQ6WqCMw?t=00h07m38s)

[the extra metadata so you can think of](https://youtu.be/UlNwQ6WqCMw?t=00h07m40s)

[authors versions icons splash screen](https://youtu.be/UlNwQ6WqCMw?t=00h07m42s)

[that type of stuff](https://youtu.be/UlNwQ6WqCMw?t=00h07m46s)

[it's really just](https://youtu.be/UlNwQ6WqCMw?t=00h07m48s)

[that type of stuff and so building up an](https://youtu.be/UlNwQ6WqCMw?t=00h07m50s)

[entire new spec file kind of felt](https://youtu.be/UlNwQ6WqCMw?t=00h07m51s)

[it felt like an unneeded extra bit of](https://youtu.be/UlNwQ6WqCMw?t=00h07m54s)

[complexity that should have just been](https://youtu.be/UlNwQ6WqCMw?t=00h07m56s)

[automated away they appear to have](https://youtu.be/UlNwQ6WqCMw?t=00h07m57s)

[automated it away with their cli out so](https://youtu.be/UlNwQ6WqCMw?t=00h07m59s)

[this is the other thing that interests](https://youtu.be/UlNwQ6WqCMw?t=00h08m03s)

[me and then for those people who are](https://youtu.be/UlNwQ6WqCMw?t=00h08m04s)

[interested this is very similar to](https://youtu.be/UlNwQ6WqCMw?t=00h08m06s)

[how](https://youtu.be/UlNwQ6WqCMw?t=00h08m08s)

[scroll.windows works but if you want to](https://youtu.be/UlNwQ6WqCMw?t=00h08m09s)

[do it if you want to also reference](https://youtu.be/UlNwQ6WqCMw?t=00h08m12s)

[cloud squirrel as a](https://youtu.be/UlNwQ6WqCMw?t=00h08m14s)

[library you can do things with like](https://youtu.be/UlNwQ6WqCMw?t=00h08m16s)

[in-app updates and that kind of thing so](https://youtu.be/UlNwQ6WqCMw?t=00h08m19s)

[if you don't do this what will happen is](https://youtu.be/UlNwQ6WqCMw?t=00h08m21s)

[the](https://youtu.be/UlNwQ6WqCMw?t=00h08m23s)

[the bootstrapper will can still do](https://youtu.be/UlNwQ6WqCMw?t=00h08m24s)

[update checks for you](https://youtu.be/UlNwQ6WqCMw?t=00h08m26s)

[so if you are an app that is outside of](https://youtu.be/UlNwQ6WqCMw?t=00h08m28s)

[that's not using as the sdk you can](https://youtu.be/UlNwQ6WqCMw?t=00h08m30s)

[still use it to like trigger updates and](https://youtu.be/UlNwQ6WqCMw?t=00h08m32s)

[installs and that kind of thing](https://youtu.be/UlNwQ6WqCMw?t=00h08m34s)

[but if you want to do like in-app](https://youtu.be/UlNwQ6WqCMw?t=00h08m35s)

[updates so maybe you have something](https://youtu.be/UlNwQ6WqCMw?t=00h08m37s)

[that's going to check for updates once](https://youtu.be/UlNwQ6WqCMw?t=00h08m38s)

[an hour or something](https://youtu.be/UlNwQ6WqCMw?t=00h08m39s)

[great right it's it's easy to do](https://youtu.be/UlNwQ6WqCMw?t=00h08m41s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h08m43s)

[worth noting my beloved get kraken does](https://youtu.be/UlNwQ6WqCMw?t=00h08m44s)

[use squirrel as their deployment](https://youtu.be/UlNwQ6WqCMw?t=00h08m47s)

[mechanism i don't know if it's cloud](https://youtu.be/UlNwQ6WqCMw?t=00h08m49s)

[squirrel or not i think it's just](https://youtu.be/UlNwQ6WqCMw?t=00h08m50s)

[squirrel windows so at least on windows](https://youtu.be/UlNwQ6WqCMw?t=00h08m52s)

[that appears to be the deployment](https://youtu.be/UlNwQ6WqCMw?t=00h08m54s)

[mechanism](https://youtu.be/UlNwQ6WqCMw?t=00h08m55s)

[but](https://youtu.be/UlNwQ6WqCMw?t=00h08m56s)

[kind of cool so this is this is where i](https://youtu.be/UlNwQ6WqCMw?t=00h08m57s)

[was planning on going now one other](https://youtu.be/UlNwQ6WqCMw?t=00h08m59s)

[thing that they've added here too](https://youtu.be/UlNwQ6WqCMw?t=00h09m01s)

[but um](https://youtu.be/UlNwQ6WqCMw?t=00h09m04s)

[uh that's not the docs folder let's try](https://youtu.be/UlNwQ6WqCMw?t=00h09m06s)

[a docs folder not docs v3 and then using](https://youtu.be/UlNwQ6WqCMw?t=00h09m07s)

[i think is where it is](https://youtu.be/UlNwQ6WqCMw?t=00h09m11s)

[so they have gone to the effort](https://youtu.be/UlNwQ6WqCMw?t=00h09m13s)

[of actually bundling in](https://youtu.be/UlNwQ6WqCMw?t=00h09m19s)

[a](https://youtu.be/UlNwQ6WqCMw?t=00h09m23s)

[github update manager so you can host](https://youtu.be/UlNwQ6WqCMw?t=00h09m24s)

[files on github via the api with like](https://youtu.be/UlNwQ6WqCMw?t=00h09m27s)

[the releases](https://youtu.be/UlNwQ6WqCMw?t=00h09m30s)

[um however there's a there's a couple](https://youtu.be/UlNwQ6WqCMw?t=00h09m31s)

[things with this one github will openly](https://youtu.be/UlNwQ6WqCMw?t=00h09m33s)

[tell you they are not a cdn a content](https://youtu.be/UlNwQ6WqCMw?t=00h09m36s)

[delivery network that is not their](https://youtu.be/UlNwQ6WqCMw?t=00h09m38s)

[purpose in life for small stuff](https://youtu.be/UlNwQ6WqCMw?t=00h09m40s)

[this is great right people download](https://youtu.be/UlNwQ6WqCMw?t=00h09m43s)

[stuff off the releases page all the time](https://youtu.be/UlNwQ6WqCMw?t=00h09m45s)

[that's perfectly fine](https://youtu.be/UlNwQ6WqCMw?t=00h09m47s)

[if you get a bunch of users and you](https://youtu.be/UlNwQ6WqCMw?t=00h09m48s)

[start doing like in-app update checks](https://youtu.be/UlNwQ6WqCMw?t=00h09m51s)

[every hour](https://youtu.be/UlNwQ6WqCMw?t=00h09m53s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h09m54s)

[like if you get high enough on the uh](https://youtu.be/UlNwQ6WqCMw?t=00h09m56s)

[the metrics chart that they start](https://youtu.be/UlNwQ6WqCMw?t=00h09m58s)

[noticing](https://youtu.be/UlNwQ6WqCMw?t=00h09m59s)

[they might scold you a little and say](https://youtu.be/UlNwQ6WqCMw?t=00h10m00s)

[please don't use this](https://youtu.be/UlNwQ6WqCMw?t=00h10m02s)

[um like we are we are not a content](https://youtu.be/UlNwQ6WqCMw?t=00h10m04s)

[delivery network we're meant to host](https://youtu.be/UlNwQ6WqCMw?t=00h10m06s)

[like we can host artifacts that's fine](https://youtu.be/UlNwQ6WqCMw?t=00h10m08s)

[but we're not your your content delivery](https://youtu.be/UlNwQ6WqCMw?t=00h10m10s)

[but what i was contemplating doing is](https://youtu.be/UlNwQ6WqCMw?t=00h10m14s)

[going a little bit different so i was](https://youtu.be/UlNwQ6WqCMw?t=00h10m16s)

[thinking i was going to go through and](https://youtu.be/UlNwQ6WqCMw?t=00h10m20s)

[put my own web service](https://youtu.be/UlNwQ6WqCMw?t=00h10m21s)

[between github and my app](https://youtu.be/UlNwQ6WqCMw?t=00h10m24s)

[so the thought is i want to take my wpf](https://youtu.be/UlNwQ6WqCMw?t=00h10m27s)

[app i want to package it up](https://youtu.be/UlNwQ6WqCMw?t=00h10m30s)

[i want to use github releases as my my](https://youtu.be/UlNwQ6WqCMw?t=00h10m33s)

[trigger mechanism so i've done uh past](https://youtu.be/UlNwQ6WqCMw?t=00h10m37s)

[streams on github action so](https://youtu.be/UlNwQ6WqCMw?t=00h10m39s)

[when a new release is created i would](https://youtu.be/UlNwQ6WqCMw?t=00h10m41s)

[like that to kick off the the building](https://youtu.be/UlNwQ6WqCMw?t=00h10m43s)

[and releasing of my app](https://youtu.be/UlNwQ6WqCMw?t=00h10m45s)

[i would like a](https://youtu.be/UlNwQ6WqCMw?t=00h10m48s)

[my own web service to be responsible for](https://youtu.be/UlNwQ6WqCMw?t=00h10m49s)

[serving up requests](https://youtu.be/UlNwQ6WqCMw?t=00h10m52s)

[um but the backing data store would](https://youtu.be/UlNwQ6WqCMw?t=00h10m54s)

[still be github so i can do caching i](https://youtu.be/UlNwQ6WqCMw?t=00h10m56s)

[can hold on to stuff](https://youtu.be/UlNwQ6WqCMw?t=00h10m59s)

[and currently i'll have the service](https://youtu.be/UlNwQ6WqCMw?t=00h11m00s)

[reach out to github maybe i move stuff](https://youtu.be/UlNwQ6WqCMw?t=00h11m02s)

[later elsewhere at a different point but](https://youtu.be/UlNwQ6WqCMw?t=00h11m04s)

[then i've got a constant delivery](https://youtu.be/UlNwQ6WqCMw?t=00h11m06s)

[mechanism and my goal is to get this](https://youtu.be/UlNwQ6WqCMw?t=00h11m08s)

[service down such that i can use this](https://youtu.be/UlNwQ6WqCMw?t=00h11m11s)

[for more than one app](https://youtu.be/UlNwQ6WqCMw?t=00h11m14s)

[that way](https://youtu.be/UlNwQ6WqCMw?t=00h11m16s)

[as i spend new repos as i have new apps](https://youtu.be/UlNwQ6WqCMw?t=00h11m17s)

[i've got a i've got a simple way of](https://youtu.be/UlNwQ6WqCMw?t=00h11m20s)

[doing that mechanism](https://youtu.be/UlNwQ6WqCMw?t=00h11m22s)

[and so i'm sort of picturing a simple](https://youtu.be/UlNwQ6WqCMw?t=00h11m24s)

[asp.net core app](https://youtu.be/UlNwQ6WqCMw?t=00h11m26s)

[something that](https://youtu.be/UlNwQ6WqCMw?t=00h11m29s)

[has only a few endpoints that are](https://youtu.be/UlNwQ6WqCMw?t=00h11m30s)

[responsible for uh responding to like](https://youtu.be/UlNwQ6WqCMw?t=00h11m32s)

[the update checks and that kind of thing](https://youtu.be/UlNwQ6WqCMw?t=00h11m35s)

[that can hold on and do a little bit of](https://youtu.be/UlNwQ6WqCMw?t=00h11m37s)

[caching](https://youtu.be/UlNwQ6WqCMw?t=00h11m38s)

[that can have a constant url that i can](https://youtu.be/UlNwQ6WqCMw?t=00h11m39s)

[point at](https://youtu.be/UlNwQ6WqCMw?t=00h11m41s)

[something i could wrap behind dns or](https://youtu.be/UlNwQ6WqCMw?t=00h11m42s)

[whatever that way i can have my apps](https://youtu.be/UlNwQ6WqCMw?t=00h11m44s)

[forward in the way i expect and then if](https://youtu.be/UlNwQ6WqCMw?t=00h11m46s)

[i want to move stuff around later i](https://youtu.be/UlNwQ6WqCMw?t=00h11m48s)

[can't and it's all hidden behind there](https://youtu.be/UlNwQ6WqCMw?t=00h11m50s)

[because that's the one thing about like](https://youtu.be/UlNwQ6WqCMw?t=00h11m52s)

[this github update manager the moment](https://youtu.be/UlNwQ6WqCMw?t=00h11m54s)

[you do something crazy like rename your](https://youtu.be/UlNwQ6WqCMw?t=00h11m57s)

[repo](https://youtu.be/UlNwQ6WqCMw?t=00h11m59s)

[yeah you're broken](https://youtu.be/UlNwQ6WqCMw?t=00h12m00s)

[and that sucks](https://youtu.be/UlNwQ6WqCMw?t=00h12m02s)

[and i just like](https://youtu.be/UlNwQ6WqCMw?t=00h12m05s)

[i like for some people again it's maybe](https://youtu.be/UlNwQ6WqCMw?t=00h12m06s)

[not a big deal for me i kind of prefer](https://youtu.be/UlNwQ6WqCMw?t=00h12m08s)

[to go](https://youtu.be/UlNwQ6WqCMw?t=00h12m11s)

[a different route](https://youtu.be/UlNwQ6WqCMw?t=00h12m12s)

[the fact that this is a dot result makes](https://youtu.be/UlNwQ6WqCMw?t=00h12m16s)

[me worried this is an asynchronous](https://youtu.be/UlNwQ6WqCMw?t=00h12m17s)

[method](https://youtu.be/UlNwQ6WqCMw?t=00h12m19s)

[and this would terrify me um](https://youtu.be/UlNwQ6WqCMw?t=00h12m22s)

[but we'll see yeah so that that's the](https://youtu.be/UlNwQ6WqCMw?t=00h12m32s)

[game plan so](https://youtu.be/UlNwQ6WqCMw?t=00h12m34s)

[this is the the cloud squirrel thing so](https://youtu.be/UlNwQ6WqCMw?t=00h12m35s)

[for anybody who's interested i was going](https://youtu.be/UlNwQ6WqCMw?t=00h12m38s)

[to powwow on my simply budget app um you](https://youtu.be/UlNwQ6WqCMw?t=00h12m40s)

[can find other streams where i've talked](https://youtu.be/UlNwQ6WqCMw?t=00h12m42s)

[about it i've worked in it this is a](https://youtu.be/UlNwQ6WqCMw?t=00h12m44s)

[simple wpf application that i built for](https://youtu.be/UlNwQ6WqCMw?t=00h12m46s)

[doing zero sum budgeting](https://youtu.be/UlNwQ6WqCMw?t=00h12m48s)

[it's target user base is me myself and](https://youtu.be/UlNwQ6WqCMw?t=00h12m50s)

[me](https://youtu.be/UlNwQ6WqCMw?t=00h12m54s)

[so if people don't like something about](https://youtu.be/UlNwQ6WqCMw?t=00h12m55s)

[it](https://youtu.be/UlNwQ6WqCMw?t=00h12m57s)

[tough](https://youtu.be/UlNwQ6WqCMw?t=00h12m58s)

[it it it works it's got a hundred](https://youtu.be/UlNwQ6WqCMw?t=00h13m00s)

[percent user-based satisfaction](https://youtu.be/UlNwQ6WqCMw?t=00h13m02s)

[ish i sometimes i find bugs and i'm](https://youtu.be/UlNwQ6WqCMw?t=00h13m05s)

[really unhappy with myself](https://youtu.be/UlNwQ6WqCMw?t=00h13m06s)

[um in fact there's a crashing bug that's](https://youtu.be/UlNwQ6WqCMw?t=00h13m08s)

[really annoying me see i've even got](https://youtu.be/UlNwQ6WqCMw?t=00h13m10s)

[issues logged against myself it's](https://youtu.be/UlNwQ6WqCMw?t=00h13m11s)

[horrible](https://youtu.be/UlNwQ6WqCMw?t=00h13m12s)

[uh but this is a simple](https://youtu.be/UlNwQ6WqCMw?t=00h13m14s)

[uh wpf app and you can see before i was](https://youtu.be/UlNwQ6WqCMw?t=00h13m16s)

[using msix which just worked okay](https://youtu.be/UlNwQ6WqCMw?t=00h13m19s)

[and there's like a download link here](https://youtu.be/UlNwQ6WqCMw?t=00h13m22s)

[but my cert is woefully expired and it's](https://youtu.be/UlNwQ6WqCMw?t=00h13m24s)

[just there's all this extra complexity](https://youtu.be/UlNwQ6WqCMw?t=00h13m27s)

[and all i want](https://youtu.be/UlNwQ6WqCMw?t=00h13m29s)

[is a](https://youtu.be/UlNwQ6WqCMw?t=00h13m30s)

[it is a very simple installer i just](https://youtu.be/UlNwQ6WqCMw?t=00h13m31s)

[want to get the thing onto the](https://youtu.be/UlNwQ6WqCMw?t=00h13m33s)

[onto the um](https://youtu.be/UlNwQ6WqCMw?t=00h13m36s)

[onto the computer and building it out is](https://youtu.be/UlNwQ6WqCMw?t=00h13m40s)

[actually like this isn't bad this is](https://youtu.be/UlNwQ6WqCMw?t=00h13m42s)

[just doing a build and test it's not](https://youtu.be/UlNwQ6WqCMw?t=00h13m45s)

[actually publishing because building out](https://youtu.be/UlNwQ6WqCMw?t=00h13m47s)

[the msix from the command line oh dear](https://youtu.be/UlNwQ6WqCMw?t=00h13m48s)

[heavens it's it's](https://youtu.be/UlNwQ6WqCMw?t=00h13m51s)

[let's put it this way it's a lot more](https://youtu.be/UlNwQ6WqCMw?t=00h13m53s)

[complicated than how the cloud squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h13m54s)

[readme makes it look](https://youtu.be/UlNwQ6WqCMw?t=00h13m57s)

[this looks trivial](https://youtu.be/UlNwQ6WqCMw?t=00h14m00s)

[the other stuff is hard](https://youtu.be/UlNwQ6WqCMw?t=00h14m02s)

[so](https://youtu.be/UlNwQ6WqCMw?t=00h14m04s)

[what i have done is i have built out](https://youtu.be/UlNwQ6WqCMw?t=00h14m05s)

[this repository here and by built out i](https://youtu.be/UlNwQ6WqCMw?t=00h14m07s)

[mean i created a new empty repository as](https://youtu.be/UlNwQ6WqCMw?t=00h14m09s)

[you can see it's filled with exciting](https://youtu.be/UlNwQ6WqCMw?t=00h14m12s)

[stuff which is a license or readme](https://youtu.be/UlNwQ6WqCMw?t=00h14m14s)

[that's more or less empty and i get](https://youtu.be/UlNwQ6WqCMw?t=00h14m16s)

[ignored that's a sum total of what we](https://youtu.be/UlNwQ6WqCMw?t=00h14m17s)

[got um scare day for people who are](https://youtu.be/UlNwQ6WqCMw?t=00h14m19s)

[unfamiliar is another word for squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h14m22s)

[this is my idea of being funny or what](https://youtu.be/UlNwQ6WqCMw?t=00h14m27s)

[little it's worth and then just for just](https://youtu.be/UlNwQ6WqCMw?t=00h14m30s)

[for kicks and giggles i did go through](https://youtu.be/UlNwQ6WqCMw?t=00h14m32s)

[and i spun up um some resources in azure](https://youtu.be/UlNwQ6WqCMw?t=00h14m35s)

[i've got an app service uh app service](https://youtu.be/UlNwQ6WqCMw?t=00h14m38s)

[plan i threw a storage account in there](https://youtu.be/UlNwQ6WqCMw?t=00h14m41s)

[i'm trying to decide if i if i use that](https://youtu.be/UlNwQ6WqCMw?t=00h14m44s)

[for for any sort of like caching of](https://youtu.be/UlNwQ6WqCMw?t=00h14m47s)

[stuff we'll see we'll see i don't know](https://youtu.be/UlNwQ6WqCMw?t=00h14m48s)

[we might need it i might delete it](https://youtu.be/UlNwQ6WqCMw?t=00h14m51s)

[look fun might delete later okay step](https://youtu.be/UlNwQ6WqCMw?t=00h14m54s)

[one let's build this let's build us a](https://youtu.be/UlNwQ6WqCMw?t=00h14m57s)

[little service that we can powwow with](https://youtu.be/UlNwQ6WqCMw?t=00h14m58s)

[so this is going to be a lot of](https://youtu.be/UlNwQ6WqCMw?t=00h15m01s)

[going as fast as possible](https://youtu.be/UlNwQ6WqCMw?t=00h15m04s)

[to do the simplest thing possible so](https://youtu.be/UlNwQ6WqCMw?t=00h15m07s)

[we're going to start there](https://youtu.be/UlNwQ6WqCMw?t=00h15m09s)

[and maybe the simplest thing is to](https://youtu.be/UlNwQ6WqCMw?t=00h15m11s)

[package the app but yeah we're gonna](https://youtu.be/UlNwQ6WqCMw?t=00h15m13s)

[start with this okay so i want a](https://youtu.be/UlNwQ6WqCMw?t=00h15m15s)

[asp.net core no i want a web api](https://youtu.be/UlNwQ6WqCMw?t=00h15m19s)

[yeah we want a web api next](https://youtu.be/UlNwQ6WqCMw?t=00h15m23s)

[uh let's see i don't know about anyone](https://youtu.be/UlNwQ6WqCMw?t=00h15m26s)

[else but i really appreciate the stream](https://youtu.be/UlNwQ6WqCMw?t=00h15m28s)

[dedicated to azure and we'll be required](https://youtu.be/UlNwQ6WqCMw?t=00h15m30s)

[for some for setting up a simple web app](https://youtu.be/UlNwQ6WqCMw?t=00h15m32s)

[oh jared you are in luck](https://youtu.be/UlNwQ6WqCMw?t=00h15m34s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h15m36s)

[here i will i will show you the part i](https://youtu.be/UlNwQ6WqCMw?t=00h15m39s)

[will show you the part really quick that](https://youtu.be/UlNwQ6WqCMw?t=00h15m42s)

[i](https://youtu.be/UlNwQ6WqCMw?t=00h15m43s)

[that i did beforehand just because it it](https://youtu.be/UlNwQ6WqCMw?t=00h15m44s)

[sometimes takes a minute for azure to](https://youtu.be/UlNwQ6WqCMw?t=00h15m47s)

[spin stuff up so once you're logged into](https://youtu.be/UlNwQ6WqCMw?t=00h15m48s)

[the azure portal i create a resource](https://youtu.be/UlNwQ6WqCMw?t=00h15m51s)

[group](https://youtu.be/UlNwQ6WqCMw?t=00h15m53s)

[give it a name something useful i like](https://youtu.be/UlNwQ6WqCMw?t=00h15m54s)

[to group like resource groups are meant](https://youtu.be/UlNwQ6WqCMw?t=00h15m56s)

[for organization you come in here and](https://youtu.be/UlNwQ6WqCMw?t=00h15m58s)

[you do](https://youtu.be/UlNwQ6WqCMw?t=00h15m59s)

[app service](https://youtu.be/UlNwQ6WqCMw?t=00h16m01s)

[and then i went down to](https://youtu.be/UlNwQ6WqCMw?t=00h16m05s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h16m09s)

[api app so you'll know there's a there's](https://youtu.be/UlNwQ6WqCMw?t=00h16m10s)

[a bunch of different app service](https://youtu.be/UlNwQ6WqCMw?t=00h16m12s)

[thingies and i believe i might be wrong](https://youtu.be/UlNwQ6WqCMw?t=00h16m14s)

[but i think like web app api apps static](https://youtu.be/UlNwQ6WqCMw?t=00h16m17s)

[web app these are all the same service](https://youtu.be/UlNwQ6WqCMw?t=00h16m20s)

[with slightly different default](https://youtu.be/UlNwQ6WqCMw?t=00h16m23s)

[configurations i believe so you come in](https://youtu.be/UlNwQ6WqCMw?t=00h16m24s)

[here you go yeah i'll take one of those](https://youtu.be/UlNwQ6WqCMw?t=00h16m26s)

[you set some stuff up and then more more](https://youtu.be/UlNwQ6WqCMw?t=00h16m30s)

[or less the important things are picking](https://youtu.be/UlNwQ6WqCMw?t=00h16m32s)

[like the runtime in this case i'm](https://youtu.be/UlNwQ6WqCMw?t=00h16m33s)

[building a net 60 thing](https://youtu.be/UlNwQ6WqCMw?t=00h16m35s)

[i'm going to be on linux i pick a region](https://youtu.be/UlNwQ6WqCMw?t=00h16m37s)

[that's close to me](https://youtu.be/UlNwQ6WqCMw?t=00h16m39s)

[skew and size worth noting the skew in](https://youtu.be/UlNwQ6WqCMw?t=00h16m40s)

[size oftentimes you can get away with](https://youtu.be/UlNwQ6WqCMw?t=00h16m43s)

[the free tier stuff](https://youtu.be/UlNwQ6WqCMw?t=00h16m45s)

[um bear in mind free tier is a low skew](https://youtu.be/UlNwQ6WqCMw?t=00h16m47s)

[machine with a cap on compute per day um](https://youtu.be/UlNwQ6WqCMw?t=00h16m50s)

[and if you're on and a lot of](https://youtu.be/UlNwQ6WqCMw?t=00h16m54s)

[azure subscriptions unless you are](https://youtu.be/UlNwQ6WqCMw?t=00h16m56s)

[paying](https://youtu.be/UlNwQ6WqCMw?t=00h16m59s)

[um you will have a max cpu count](https://youtu.be/UlNwQ6WqCMw?t=00h17m00s)

[across your entire uh subscription](https://youtu.be/UlNwQ6WqCMw?t=00h17m04s)

[that you are allowed to use so for](https://youtu.be/UlNwQ6WqCMw?t=00h17m07s)

[example because this is a](https://youtu.be/UlNwQ6WqCMw?t=00h17m08s)

[the thing tied to my mvp msdn i have a](https://youtu.be/UlNwQ6WqCMw?t=00h17m12s)

[cap on](https://youtu.be/UlNwQ6WqCMw?t=00h17m15s)

[how many cpu cores i can use in each](https://youtu.be/UlNwQ6WqCMw?t=00h17m17s)

[region](https://youtu.be/UlNwQ6WqCMw?t=00h17m19s)

[so sometimes i switch a region for no](https://youtu.be/UlNwQ6WqCMw?t=00h17m20s)

[other reason other than i've already](https://youtu.be/UlNwQ6WqCMw?t=00h17m22s)

[used up my my cpu](https://youtu.be/UlNwQ6WqCMw?t=00h17m23s)

[uh my my core caps](https://youtu.be/UlNwQ6WqCMw?t=00h17m25s)

[but at least that much gets you set up](https://youtu.be/UlNwQ6WqCMw?t=00h17m28s)

[oh because you asked to because you](https://youtu.be/UlNwQ6WqCMw?t=00h17m29s)

[asked um let me grab](https://youtu.be/UlNwQ6WqCMw?t=00h17m32s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h17m35s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=00h17m35s)

[there is a](https://youtu.be/UlNwQ6WqCMw?t=00h17m37s)

[if you run this query here](https://youtu.be/UlNwQ6WqCMw?t=00h17m44s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h17m51s)

[this will take you to some streams that](https://youtu.be/UlNwQ6WqCMw?t=00h17m52s)

[i did on my tuna waffle project](https://youtu.be/UlNwQ6WqCMw?t=00h17m54s)

[which i do need to update again because](https://youtu.be/UlNwQ6WqCMw?t=00h17m57s)

[it is a little out of date but](https://youtu.be/UlNwQ6WqCMw?t=00h18m00s)

[and yes](https://youtu.be/UlNwQ6WqCMw?t=00h18m05s)

[we did draw an icon for a tuna waffle](https://youtu.be/UlNwQ6WqCMw?t=00h18m07s)

[because it is cool](https://youtu.be/UlNwQ6WqCMw?t=00h18m09s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h18m11s)

[this org here has several repos in it um](https://youtu.be/UlNwQ6WqCMw?t=00h18m12s)

[that are a very simple asp.net core api](https://youtu.be/UlNwQ6WqCMw?t=00h18m17s)

[the infrastructure is arguably uh](https://youtu.be/UlNwQ6WqCMw?t=00h18m21s)

[overkill for what most simple projects](https://youtu.be/UlNwQ6WqCMw?t=00h18m23s)

[needs this is a](https://youtu.be/UlNwQ6WqCMw?t=00h18m25s)

[kubernetes cluster whole nine yards](https://youtu.be/UlNwQ6WqCMw?t=00h18m27s)

[it does all the stuff it does it in](https://youtu.be/UlNwQ6WqCMw?t=00h18m31s)

[terraform it has github actions to do](https://youtu.be/UlNwQ6WqCMw?t=00h18m32s)

[the work it needs to be updated because](https://youtu.be/UlNwQ6WqCMw?t=00h18m34s)

[it's it hasn't been touched since](https://youtu.be/UlNwQ6WqCMw?t=00h18m36s)

[november of 2021](https://youtu.be/UlNwQ6WqCMw?t=00h18m38s)

[there's been some updates there's some](https://youtu.be/UlNwQ6WqCMw?t=00h18m41s)

[cleaner stuff for example.net six](https://youtu.be/UlNwQ6WqCMw?t=00h18m43s)

[dropped that's the thing](https://youtu.be/UlNwQ6WqCMw?t=00h18m45s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h18m47s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h18m49s)

[so i need my](https://youtu.be/UlNwQ6WqCMw?t=00h18m50s)

[uh this guy here](https://youtu.be/UlNwQ6WqCMw?t=00h18m53s)

[i'm gonna go here i'm gonna copy this](https://youtu.be/UlNwQ6WqCMw?t=00h18m55s)

[and so pro tip when i'm building these](https://youtu.be/UlNwQ6WqCMw?t=00h18m58s)

[out](https://youtu.be/UlNwQ6WqCMw?t=00h19m00s)

[oh come on](https://youtu.be/UlNwQ6WqCMw?t=00h19m01s)

[come on](https://youtu.be/UlNwQ6WqCMw?t=00h19m03s)

[i said copy](https://youtu.be/UlNwQ6WqCMw?t=00h19m04s)

[paste](https://youtu.be/UlNwQ6WqCMw?t=00h19m07s)

[you be dumb](https://youtu.be/UlNwQ6WqCMw?t=00h19m09s)

[uh s because i can't spell and i'm](https://youtu.be/UlNwQ6WqCMw?t=00h19m11s)

[realizing i picked a word that's hard](https://youtu.be/UlNwQ6WqCMw?t=00h19m14s)

[for me to spell](https://youtu.be/UlNwQ6WqCMw?t=00h19m16s)

[so i'm gonna call it api](https://youtu.be/UlNwQ6WqCMw?t=00h19m17s)

[um but then i'm going to put the](https://youtu.be/UlNwQ6WqCMw?t=00h19m19s)

[solution here](https://youtu.be/UlNwQ6WqCMw?t=00h19m21s)

[and that do that](https://youtu.be/UlNwQ6WqCMw?t=00h19m22s)

[i think that'll put it in the right dir](https://youtu.be/UlNwQ6WqCMw?t=00h19m28s)

[right directory okay um](https://youtu.be/UlNwQ6WqCMw?t=00h19m30s)

[i don't know if i need docker support](https://youtu.be/UlNwQ6WqCMw?t=00h19m33s)

[i don't think i do](https://youtu.be/UlNwQ6WqCMw?t=00h19m39s)

[and i think we're going to use](https://youtu.be/UlNwQ6WqCMw?t=00h19m43s)

[controllers rather than minimal apis](https://youtu.be/UlNwQ6WqCMw?t=00h19m44s)

[minimal apis are cool but i find myself](https://youtu.be/UlNwQ6WqCMw?t=00h19m47s)

[looking stuff up a lot and i don't mind](https://youtu.be/UlNwQ6WqCMw?t=00h19m49s)

[the top level statements for my main](https://youtu.be/UlNwQ6WqCMw?t=00h19m51s)

[method](https://youtu.be/UlNwQ6WqCMw?t=00h19m53s)

[so we'll go there and then open api](https://youtu.be/UlNwQ6WqCMw?t=00h19m54s)

[support it's just for swagger](https://youtu.be/UlNwQ6WqCMw?t=00h19m56s)

[um and i don't think we need auth setup](https://youtu.be/UlNwQ6WqCMw?t=00h19m58s)

[because this is going to be for](https://youtu.be/UlNwQ6WqCMw?t=00h20m01s)

[installers to hit](https://youtu.be/UlNwQ6WqCMw?t=00h20m03s)

[which means there's gonna be they're](https://youtu.be/UlNwQ6WqCMw?t=00h20m07s)

[gonna be unauthenticated requests all](https://youtu.be/UlNwQ6WqCMw?t=00h20m08s)

[the time](https://youtu.be/UlNwQ6WqCMw?t=00h20m10s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h20m16s)

[but now](https://youtu.be/UlNwQ6WqCMw?t=00h20m18s)

[i'm just going to run it real quick i](https://youtu.be/UlNwQ6WqCMw?t=00h20m20s)

[kind of want to make sure that this](https://youtu.be/UlNwQ6WqCMw?t=00h20m22s)

[thing showed up in the right folder](https://youtu.be/UlNwQ6WqCMw?t=00h20m23s)

[get cracking isn't showing changes which](https://youtu.be/UlNwQ6WqCMw?t=00h20m30s)

[is now immediately making me think i put](https://youtu.be/UlNwQ6WqCMw?t=00h20m31s)

[things in the wrong directory](https://youtu.be/UlNwQ6WqCMw?t=00h20m33s)

[oh did i misspell it](https://youtu.be/UlNwQ6WqCMw?t=00h20m42s)

[dang it](https://youtu.be/UlNwQ6WqCMw?t=00h20m47s)

[see what happens when you can't spell](https://youtu.be/UlNwQ6WqCMw?t=00h20m54s)

[okay we're gonna copy this see this is](https://youtu.be/UlNwQ6WqCMw?t=00h20m57s)

[why i want to copy and paste so step one](https://youtu.be/UlNwQ6WqCMw?t=00h20m59s)

[ignore everything i just did](https://youtu.be/UlNwQ6WqCMw?t=00h21m02s)

[step two do it over](https://youtu.be/UlNwQ6WqCMw?t=00h21m04s)

[and we'll get rid of the one that's not](https://youtu.be/UlNwQ6WqCMw?t=00h21m07s)

[spelled correctly](https://youtu.be/UlNwQ6WqCMw?t=00h21m08s)

[okay because get cracking should have](https://youtu.be/UlNwQ6WqCMw?t=00h21m12s)

[flagged me](https://youtu.be/UlNwQ6WqCMw?t=00h21m13s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=00h21m16s)

[great new project](https://youtu.be/UlNwQ6WqCMw?t=00h21m18s)

[template should be on top yep](https://youtu.be/UlNwQ6WqCMw?t=00h21m21s)

[we're gonna go there](https://youtu.be/UlNwQ6WqCMw?t=00h21m24s)

[api](https://youtu.be/UlNwQ6WqCMw?t=00h21m26s)

[make the solution name that](https://youtu.be/UlNwQ6WqCMw?t=00h21m29s)

[all the defaults are still set](https://youtu.be/UlNwQ6WqCMw?t=00h21m33s)

[huzzah](https://youtu.be/UlNwQ6WqCMw?t=00h21m35s)

[create](https://youtu.be/UlNwQ6WqCMw?t=00h21m37s)

[there we go see now it's showing up in](https://youtu.be/UlNwQ6WqCMw?t=00h21m42s)

[the right directory great files change](https://youtu.be/UlNwQ6WqCMw?t=00h21m43s)

[their stuff appearing](https://youtu.be/UlNwQ6WqCMw?t=00h21m46s)

[as off](https://youtu.be/UlNwQ6WqCMw?t=00h21m47s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h21m49s)

[let's just run it real quick and make](https://youtu.be/UlNwQ6WqCMw?t=00h21m52s)

[sure it actually works so the default](https://youtu.be/UlNwQ6WqCMw?t=00h21m54s)

[controller is just a weather forecast](https://youtu.be/UlNwQ6WqCMw?t=00h21m56s)

[that i believe just returns a hard-coded](https://youtu.be/UlNwQ6WqCMw?t=00h21m58s)

[list if i'm not mistaken](https://youtu.be/UlNwQ6WqCMw?t=00h22m00s)

[there's that the controller here just](https://youtu.be/UlNwQ6WqCMw?t=00h22m05s)

[does](https://youtu.be/UlNwQ6WqCMw?t=00h22m07s)

[yeah summaries](https://youtu.be/UlNwQ6WqCMw?t=00h22m08s)

[blah blah](https://youtu.be/UlNwQ6WqCMw?t=00h22m10s)

[okay got it](https://youtu.be/UlNwQ6WqCMw?t=00h22m15s)

[now edge](https://youtu.be/UlNwQ6WqCMw?t=00h22m17s)

[okay so this is just swagger for open](https://youtu.be/UlNwQ6WqCMw?t=00h22m18s)

[api](https://youtu.be/UlNwQ6WqCMw?t=00h22m20s)

[so we didn't have to do you'll note i](https://youtu.be/UlNwQ6WqCMw?t=00h22m22s)

[haven't had to write any code yet so](https://youtu.be/UlNwQ6WqCMw?t=00h22m24s)

[this is](https://youtu.be/UlNwQ6WqCMw?t=00h22m25s)

[okay works it jen some stuff everyone's](https://youtu.be/UlNwQ6WqCMw?t=00h22m27s)

[happy huzzah](https://youtu.be/UlNwQ6WqCMw?t=00h22m30s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h22m32s)

[okay so now let's push this up uh let's](https://youtu.be/UlNwQ6WqCMw?t=00h22m34s)

[see](https://youtu.be/UlNwQ6WqCMw?t=00h22m37s)

[default app](https://youtu.be/UlNwQ6WqCMw?t=00h22m38s)

[push push](https://youtu.be/UlNwQ6WqCMw?t=00h22m40s)

[okay now we want to deploy this to azure](https://youtu.be/UlNwQ6WqCMw?t=00h22m42s)

[so](https://youtu.be/UlNwQ6WqCMw?t=00h22m45s)

[step one would normally be go write a](https://youtu.be/UlNwQ6WqCMw?t=00h22m46s)

[github action but that sounds like work](https://youtu.be/UlNwQ6WqCMw?t=00h22m48s)

[that sounds like a lot of work okay](https://youtu.be/UlNwQ6WqCMw?t=00h22m52s)

[a much better option](https://youtu.be/UlNwQ6WqCMw?t=00h22m54s)

[is let something else write the the](https://youtu.be/UlNwQ6WqCMw?t=00h22m57s)

[github action for me so if we go to the](https://youtu.be/UlNwQ6WqCMw?t=00h22m59s)

[app service](https://youtu.be/UlNwQ6WqCMw?t=00h23m00s)

[inside of azure there's this wonderful](https://youtu.be/UlNwQ6WqCMw?t=00h23m02s)

[deployment center](https://youtu.be/UlNwQ6WqCMw?t=00h23m04s)

[now i have previously already linked my](https://youtu.be/UlNwQ6WqCMw?t=00h23m06s)

[github](https://youtu.be/UlNwQ6WqCMw?t=00h23m10s)

[to my azure so if you come in here the](https://youtu.be/UlNwQ6WqCMw?t=00h23m11s)

[first time you are going to need to go](https://youtu.be/UlNwQ6WqCMw?t=00h23m13s)

[through and do the sign in and grant](https://youtu.be/UlNwQ6WqCMw?t=00h23m15s)

[permission and all of that jazz so just](https://youtu.be/UlNwQ6WqCMw?t=00h23m18s)

[be aware first time through you do have](https://youtu.be/UlNwQ6WqCMw?t=00h23m20s)

[to do](https://youtu.be/UlNwQ6WqCMw?t=00h23m22s)

[a little bit of work](https://youtu.be/UlNwQ6WqCMw?t=00h23m23s)

[so we're going to do that](https://youtu.be/UlNwQ6WqCMw?t=00h23m25s)

[come on](https://youtu.be/UlNwQ6WqCMw?t=00h23m28s)

[go and load my list of repositories yep](https://youtu.be/UlNwQ6WqCMw?t=00h23m31s)

[that's the one go find it thank you](https://youtu.be/UlNwQ6WqCMw?t=00h23m33s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=00h23m37s)

[that one](https://youtu.be/UlNwQ6WqCMw?t=00h23m39s)

[find the branch](https://youtu.be/UlNwQ6WqCMw?t=00h23m41s)

[great](https://youtu.be/UlNwQ6WqCMw?t=00h23m43s)

[preview the file](https://youtu.be/UlNwQ6WqCMw?t=00h23m45s)

[so it's gonna trigger on pushes into](https://youtu.be/UlNwQ6WqCMw?t=00h23m48s)

[main it's going to also have a manual](https://youtu.be/UlNwQ6WqCMw?t=00h23m51s)

[trigger which is what workflow dispatch](https://youtu.be/UlNwQ6WqCMw?t=00h23m54s)

[is](https://youtu.be/UlNwQ6WqCMw?t=00h23m56s)

[it's going to](https://youtu.be/UlNwQ6WqCMw?t=00h23m56s)

[it has a couple jobs](https://youtu.be/UlNwQ6WqCMw?t=00h23m58s)

[which this is i will point out some](https://youtu.be/UlNwQ6WqCMw?t=00h24m00s)

[people do this wrong in my opinion](https://youtu.be/UlNwQ6WqCMw?t=00h24m02s)

[your pipelines](https://youtu.be/UlNwQ6WqCMw?t=00h24m04s)

[generally you want a logical a logical](https://youtu.be/UlNwQ6WqCMw?t=00h24m06s)

[separation emphasis on logical](https://youtu.be/UlNwQ6WqCMw?t=00h24m08s)

[separation](https://youtu.be/UlNwQ6WqCMw?t=00h24m10s)

[a logical separation between the part of](https://youtu.be/UlNwQ6WqCMw?t=00h24m13s)

[your pipeline that creates the artifacts](https://youtu.be/UlNwQ6WqCMw?t=00h24m14s)

[and the part of your pipeline that](https://youtu.be/UlNwQ6WqCMw?t=00h24m17s)

[deploys your artifacts](https://youtu.be/UlNwQ6WqCMw?t=00h24m19s)

[those two things should be logically](https://youtu.be/UlNwQ6WqCMw?t=00h24m21s)

[separated](https://youtu.be/UlNwQ6WqCMw?t=00h24m22s)

[now how you get there is up to you](https://youtu.be/UlNwQ6WqCMw?t=00h24m24s)

[okay so we can go through and just](https://youtu.be/UlNwQ6WqCMw?t=00h24m26s)

[double check and see what it's doing](https://youtu.be/UlNwQ6WqCMw?t=00h24m28s)

[it's making sure that the net sdk is](https://youtu.be/UlNwQ6WqCMw?t=00h24m30s)

[installed great it does have include](https://youtu.be/UlNwQ6WqCMw?t=00h24m32s)

[prerelease 2 which makes me a little](https://youtu.be/UlNwQ6WqCMw?t=00h24m34s)

[twitchy but whatever](https://youtu.be/UlNwQ6WqCMw?t=00h24m36s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h24m38s)

[builds with configuration release i find](https://youtu.be/UlNwQ6WqCMw?t=00h24m40s)

[it interesting that it's doing dash dash](https://youtu.be/UlNwQ6WqCMw?t=00h24m42s)

[configuration here and dash c here that](https://youtu.be/UlNwQ6WqCMw?t=00h24m44s)

[just seems weird](https://youtu.be/UlNwQ6WqCMw?t=00h24m46s)

[it is calling it my app which we may go](https://youtu.be/UlNwQ6WqCMw?t=00h24m48s)

[and rename here in a little bit](https://youtu.be/UlNwQ6WqCMw?t=00h24m51s)

[but it uh uploads the artifacts great](https://youtu.be/UlNwQ6WqCMw?t=00h24m53s)

[it's calling it netapp we'll probably](https://youtu.be/UlNwQ6WqCMw?t=00h24m56s)

[rename that too just so it has a cleaner](https://youtu.be/UlNwQ6WqCMw?t=00h24m58s)

[name](https://youtu.be/UlNwQ6WqCMw?t=00h25m00s)

[we come down here](https://youtu.be/UlNwQ6WqCMw?t=00h25m01s)

[you'll note it is going to](https://youtu.be/UlNwQ6WqCMw?t=00h25m03s)

[download the artifacts from the previous](https://youtu.be/UlNwQ6WqCMw?t=00h25m05s)

[job because you'll note this is a build](https://youtu.be/UlNwQ6WqCMw?t=00h25m08s)

[job here](https://youtu.be/UlNwQ6WqCMw?t=00h25m11s)

[and then a deployed job after it and](https://youtu.be/UlNwQ6WqCMw?t=00h25m12s)

[you'll note the deploy job depends on](https://youtu.be/UlNwQ6WqCMw?t=00h25m14s)

[the build job so deploy always comes](https://youtu.be/UlNwQ6WqCMw?t=00h25m16s)

[after build](https://youtu.be/UlNwQ6WqCMw?t=00h25m18s)

[makes sense sometimes you want jobs to](https://youtu.be/UlNwQ6WqCMw?t=00h25m19s)

[run in parallel and if you don't you set](https://youtu.be/UlNwQ6WqCMw?t=00h25m21s)

[up a needs and then they run one after](https://youtu.be/UlNwQ6WqCMw?t=00h25m23s)

[the other](https://youtu.be/UlNwQ6WqCMw?t=00h25m25s)

[which is great it is creating me an](https://youtu.be/UlNwQ6WqCMw?t=00h25m26s)

[environment called production which is](https://youtu.be/UlNwQ6WqCMw?t=00h25m29s)

[cool i assume it's going to create the](https://youtu.be/UlNwQ6WqCMw?t=00h25m30s)

[environment otherwise it's going to be](https://youtu.be/UlNwQ6WqCMw?t=00h25m32s)

[real short action](https://youtu.be/UlNwQ6WqCMw?t=00h25m34s)

[downloads the artifacts from the](https://youtu.be/UlNwQ6WqCMw?t=00h25m36s)

[previous job because jobs](https://youtu.be/UlNwQ6WqCMw?t=00h25m37s)

[likely will run on different agents so](https://youtu.be/UlNwQ6WqCMw?t=00h25m39s)

[you can't assume any shared state](https://youtu.be/UlNwQ6WqCMw?t=00h25m41s)

[between them](https://youtu.be/UlNwQ6WqCMw?t=00h25m43s)

[and so it'll download the artifact and](https://youtu.be/UlNwQ6WqCMw?t=00h25m46s)

[then it'll deploy the stuff out and it's](https://youtu.be/UlNwQ6WqCMw?t=00h25m47s)

[going to create a whole publish profile](https://youtu.be/UlNwQ6WqCMw?t=00h25m49s)

[for me shove it into the secrets bippity](https://youtu.be/UlNwQ6WqCMw?t=00h25m51s)

[boppity booyah we're done so uh save](https://youtu.be/UlNwQ6WqCMw?t=00h25m54s)

[and see i could have written a github](https://youtu.be/UlNwQ6WqCMw?t=00h25m59s)

[action or](https://youtu.be/UlNwQ6WqCMw?t=00h26m01s)

[i could let azure write me a github](https://youtu.be/UlNwQ6WqCMw?t=00h26m03s)

[action](https://youtu.be/UlNwQ6WqCMw?t=00h26m04s)

[okay so we come here and i assume if i](https://youtu.be/UlNwQ6WqCMw?t=00h26m09s)

[do a fetch](https://youtu.be/UlNwQ6WqCMw?t=00h26m11s)

[and look at that there's a commit](https://youtu.be/UlNwQ6WqCMw?t=00h26m13s)

[pull](https://youtu.be/UlNwQ6WqCMw?t=00h26m15s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h26m19s)

[this guy's here](https://youtu.be/UlNwQ6WqCMw?t=00h26m20s)

[which is](https://youtu.be/UlNwQ6WqCMw?t=00h26m22s)

[great and then](https://youtu.be/UlNwQ6WqCMw?t=00h26m22s)

[and if anybody wants the published](https://youtu.be/UlNwQ6WqCMw?t=00h26m28s)

[profile it exists there too](https://youtu.be/UlNwQ6WqCMw?t=00h26m29s)

[um let me see how do i see if you're](https://youtu.be/UlNwQ6WqCMw?t=00h26m31s)

[deployed out yet](https://youtu.be/UlNwQ6WqCMw?t=00h26m34s)

[well i mean we can go here](https://youtu.be/UlNwQ6WqCMw?t=00h26m39s)

[and i think i need to double check the](https://youtu.be/UlNwQ6WqCMw?t=00h26m42s)

[end point i think it's like splash](https://youtu.be/UlNwQ6WqCMw?t=00h26m44s)

[swagger slash something](https://youtu.be/UlNwQ6WqCMw?t=00h26m46s)

[uh let's see properties launch settings](https://youtu.be/UlNwQ6WqCMw?t=00h26m49s)

[what is the endpoint](https://youtu.be/UlNwQ6WqCMw?t=00h26m51s)

[oh the route redirects apparently](https://youtu.be/UlNwQ6WqCMw?t=00h26m55s)

[your app is running and waiting for](https://youtu.be/UlNwQ6WqCMw?t=00h27m02s)

[content i would like it to be deployed](https://youtu.be/UlNwQ6WqCMw?t=00h27m03s)

[do i have to do something oh i know how](https://youtu.be/UlNwQ6WqCMw?t=00h27m05s)

[you see it](https://youtu.be/UlNwQ6WqCMw?t=00h27m08s)

[you're not an idiot you just go over to](https://youtu.be/UlNwQ6WqCMw?t=00h27m09s)

[your actions and you check and see](https://youtu.be/UlNwQ6WqCMw?t=00h27m11s)

[oh it just finished running](https://youtu.be/UlNwQ6WqCMw?t=00h27m14s)

[oh look at that it deployed and then it](https://youtu.be/UlNwQ6WqCMw?t=00h27m19s)

[even went to the effort of here here's](https://youtu.be/UlNwQ6WqCMw?t=00h27m21s)

[the link](https://youtu.be/UlNwQ6WqCMw?t=00h27m23s)

[you're so fun azure](https://youtu.be/UlNwQ6WqCMw?t=00h27m26s)

[uh that's not right](https://youtu.be/UlNwQ6WqCMw?t=00h27m29s)

[here](https://youtu.be/UlNwQ6WqCMw?t=00h27m32s)

[oh the swagger endpoint is not going to](https://youtu.be/UlNwQ6WqCMw?t=00h27m34s)

[work because it is](https://youtu.be/UlNwQ6WqCMw?t=00h27m37s)

[i remember correctly yeah see default](https://youtu.be/UlNwQ6WqCMw?t=00h27m40s)

[deployment](https://youtu.be/UlNwQ6WqCMw?t=00h27m43s)

[if you're in production you don't get](https://youtu.be/UlNwQ6WqCMw?t=00h27m45s)

[swagger](https://youtu.be/UlNwQ6WqCMw?t=00h27m47s)

[which means the only thing that's going](https://youtu.be/UlNwQ6WqCMw?t=00h27m48s)

[to exist is going to be](https://youtu.be/UlNwQ6WqCMw?t=00h27m50s)

[weather](https://youtu.be/UlNwQ6WqCMw?t=00h27m53s)

[slash get weather forecast i believe let](https://youtu.be/UlNwQ6WqCMw?t=00h27m54s)

[me just confirm that](https://youtu.be/UlNwQ6WqCMw?t=00h27m57s)

[but i think what that means is](https://youtu.be/UlNwQ6WqCMw?t=00h28m00s)

[i need to do](https://youtu.be/UlNwQ6WqCMw?t=00h28m03s)

[this url](https://youtu.be/UlNwQ6WqCMw?t=00h28m05s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h28m07s)

[weather slash](https://youtu.be/UlNwQ6WqCMw?t=00h28m08s)

[get](https://youtu.be/UlNwQ6WqCMw?t=00h28m10s)

[weather](https://youtu.be/UlNwQ6WqCMw?t=00h28m10s)

[or cast](https://youtu.be/UlNwQ6WqCMw?t=00h28m11s)

[hey justin bieber](https://youtu.be/UlNwQ6WqCMw?t=00h28m15s)

[it is](https://youtu.be/UlNwQ6WqCMw?t=00h28m16s)

[pseudo wpf](https://youtu.be/UlNwQ6WqCMw?t=00h28m18s)

[uh in this case what i mean is oh it is](https://youtu.be/UlNwQ6WqCMw?t=00h28m20s)

[just weather forecast](https://youtu.be/UlNwQ6WqCMw?t=00h28m22s)

[uh we're deploying wpf apps huzzah](https://youtu.be/UlNwQ6WqCMw?t=00h28m24s)

[okay roof is in the pudding](https://youtu.be/UlNwQ6WqCMw?t=00h28m29s)

[web api created from scratch built and](https://youtu.be/UlNwQ6WqCMw?t=00h28m32s)

[deployed](https://youtu.be/UlNwQ6WqCMw?t=00h28m35s)

[i win](https://youtu.be/UlNwQ6WqCMw?t=00h28m37s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h28m38s)

[now let's go package up our wpf app](https://youtu.be/UlNwQ6WqCMw?t=00h28m39s)

[and then we'll come back to this guy so](https://youtu.be/UlNwQ6WqCMw?t=00h28m44s)

[we're going to hold on here for a minute](https://youtu.be/UlNwQ6WqCMw?t=00h28m46s)

[i'm just going to grab this i'm going to](https://youtu.be/UlNwQ6WqCMw?t=00h28m48s)

[come over here real quick don't mind me](https://youtu.be/UlNwQ6WqCMw?t=00h28m49s)

[just](https://youtu.be/UlNwQ6WqCMw?t=00h28m52s)

[just just just there's i want to i want](https://youtu.be/UlNwQ6WqCMw?t=00h28m53s)

[to confirm i'm not about to uh expose](https://youtu.be/UlNwQ6WqCMw?t=00h28m56s)

[secrets because i'm really bad about](https://youtu.be/UlNwQ6WqCMw?t=00h28m58s)

[that](https://youtu.be/UlNwQ6WqCMw?t=00h28m59s)

[oh wow uh](https://youtu.be/UlNwQ6WqCMw?t=00h29m01s)

[on stage marco is resolved](https://youtu.be/UlNwQ6WqCMw?t=00h29m03s)

[apparently i was in the middle of a](https://youtu.be/UlNwQ6WqCMw?t=00h29m09s)

[rebase on this repository last time i](https://youtu.be/UlNwQ6WqCMw?t=00h29m11s)

[opened it](https://youtu.be/UlNwQ6WqCMw?t=00h29m13s)

[that's exciting](https://youtu.be/UlNwQ6WqCMw?t=00h29m15s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h29m17s)

[so once again for anybody who wants the](https://youtu.be/UlNwQ6WqCMw?t=00h29m19s)

[link uh boom](https://youtu.be/UlNwQ6WqCMw?t=00h29m21s)

[this is the wpf app we're to package up](https://youtu.be/UlNwQ6WqCMw?t=00h29m23s)

[again](https://youtu.be/UlNwQ6WqCMw?t=00h29m26s)

[pick your art](https://youtu.be/UlNwQ6WqCMw?t=00h29m27s)

[pick any wpf app doesn't matter](https://youtu.be/UlNwQ6WqCMw?t=00h29m28s)

[or actually pick any app for that matter](https://youtu.be/UlNwQ6WqCMw?t=00h29m31s)

[this isn't going to be overly specific](https://youtu.be/UlNwQ6WqCMw?t=00h29m34s)

[to wpf](https://youtu.be/UlNwQ6WqCMw?t=00h29m36s)

[okay let's learn some cloud squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h29m40s)

[let's cloud squirrel me](https://youtu.be/UlNwQ6WqCMw?t=00h29m43s)

[cloud squirrel me okay step one we](https://youtu.be/UlNwQ6WqCMw?t=00h29m45s)

[should look at the top so step one](https://youtu.be/UlNwQ6WqCMw?t=00h29m48s)

[install the right nougat package](https://youtu.be/UlNwQ6WqCMw?t=00h29m51s)

[that seems to be a pretty low bar](https://youtu.be/UlNwQ6WqCMw?t=00h29m53s)

[i will install the nuget package](https://youtu.be/UlNwQ6WqCMw?t=00h29m56s)

[here](https://youtu.be/UlNwQ6WqCMw?t=00h30m00s)

[close those close](https://youtu.be/UlNwQ6WqCMw?t=00h30m02s)

[okay i should double check i did up to](https://youtu.be/UlNwQ6WqCMw?t=00h30m06s)

[you to knit six didn't i good](https://youtu.be/UlNwQ6WqCMw?t=00h30m09s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h30m13s)

[wild squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h30m16s)

[blah blah blah](https://youtu.be/UlNwQ6WqCMw?t=00h30m17s)

[install that and then i'm going to check](https://youtu.be/UlNwQ6WqCMw?t=00h30m20s)

[and see what nuget packages show updates](https://youtu.be/UlNwQ6WqCMw?t=00h30m22s)

[because we](https://youtu.be/UlNwQ6WqCMw?t=00h30m24s)

[may or may not want to ingest a few](https://youtu.be/UlNwQ6WqCMw?t=00h30m25s)

[extra updates i mean while we're](https://youtu.be/UlNwQ6WqCMw?t=00h30m26s)

[installing a nuget package we might as](https://youtu.be/UlNwQ6WqCMw?t=00h30m28s)

[well install all the things right](https://youtu.be/UlNwQ6WqCMw?t=00h30m29s)

[because part of me doing this is i](https://youtu.be/UlNwQ6WqCMw?t=00h30m34s)

[haven't had good](https://youtu.be/UlNwQ6WqCMw?t=00h30m35s)

[ci cd for this app because of the msix](https://youtu.be/UlNwQ6WqCMw?t=00h30m37s)

[stuff](https://youtu.be/UlNwQ6WqCMw?t=00h30m40s)

[and that's bothered me i like i like](https://youtu.be/UlNwQ6WqCMw?t=00h30m41s)

[pushing and magically having my app show](https://youtu.be/UlNwQ6WqCMw?t=00h30m43s)

[up like that just makes me happy](https://youtu.be/UlNwQ6WqCMw?t=00h30m46s)

[ooh](https://youtu.be/UlNwQ6WqCMw?t=00h30m51s)

[i don't know if i want to take that](https://youtu.be/UlNwQ6WqCMw?t=00h30m52s)

[change full sail](https://youtu.be/UlNwQ6WqCMw?t=00h30m54s)

[that one's safe that one's safe that](https://youtu.be/UlNwQ6WqCMw?t=00h30m56s)

[one's safe](https://youtu.be/UlNwQ6WqCMw?t=00h30m58s)

[well](https://youtu.be/UlNwQ6WqCMw?t=00h31m01s)

[let's let's let's not make our life any](https://youtu.be/UlNwQ6WqCMw?t=00h31m02s)

[more complicated than it needs to](https://youtu.be/UlNwQ6WqCMw?t=00h31m04s)

[i'll take a note come back to it later](https://youtu.be/UlNwQ6WqCMw?t=00h31m06s)

[okay cloud squirrel now what](https://youtu.be/UlNwQ6WqCMw?t=00h31m08s)

[okay add squirrel aware version to your](https://youtu.be/UlNwQ6WqCMw?t=00h31m11s)

[manifest to indicate that your exe](https://youtu.be/UlNwQ6WqCMw?t=00h31m13s)

[supports squirrel what if i don't want](https://youtu.be/UlNwQ6WqCMw?t=00h31m16s)

[to do this](https://youtu.be/UlNwQ6WqCMw?t=00h31m18s)

[i don't think we need to do](https://youtu.be/UlNwQ6WqCMw?t=00h31m28s)

[so squirrel.windows this is very much](https://youtu.be/UlNwQ6WqCMw?t=00h31m30s)

[optional and i assume it's the same here](https://youtu.be/UlNwQ6WqCMw?t=00h31m32s)

[though maybe we probably should we went](https://youtu.be/UlNwQ6WqCMw?t=00h31m43s)

[to all the effort of doing this](https://youtu.be/UlNwQ6WqCMw?t=00h31m45s)

[so let's add this to our manifest](https://youtu.be/UlNwQ6WqCMw?t=00h31m47s)

[do i even have a manifest](https://youtu.be/UlNwQ6WqCMw?t=00h31m52s)

[i don't even know if i have a manifest](https://youtu.be/UlNwQ6WqCMw?t=00h31m57s)

[you're gonna make me remember how to add](https://youtu.be/UlNwQ6WqCMw?t=00h32m02s)

[an app manifest](https://youtu.be/UlNwQ6WqCMw?t=00h32m04s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h32m18s)

[at manifest and where did you want me to](https://youtu.be/UlNwQ6WqCMw?t=00h32m20s)

[put it](https://youtu.be/UlNwQ6WqCMw?t=00h32m21s)

[right inside the assembly](https://youtu.be/UlNwQ6WqCMw?t=00h32m23s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h32m28s)

[at manifest created handles squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h32m29s)

[events](https://youtu.be/UlNwQ6WqCMw?t=00h32m32s)

[somewhere very early in your application](https://youtu.be/UlNwQ6WqCMw?t=00h32m33s)

[inside of main the other place um i](https://youtu.be/UlNwQ6WqCMw?t=00h32m36s)

[don't think this thing has a custom made](https://youtu.be/UlNwQ6WqCMw?t=00h32m38s)

[it doesn't so we're going to do it early](https://youtu.be/UlNwQ6WqCMw?t=00h32m44s)

[in the process](https://youtu.be/UlNwQ6WqCMw?t=00h32m46s)

[boom](https://youtu.be/UlNwQ6WqCMw?t=00h32m49s)

[and i'm not sure how i want to at some](https://youtu.be/UlNwQ6WqCMw?t=00h32m54s)

[point i'll probably want to do some](https://youtu.be/UlNwQ6WqCMw?t=00h32m56s)

[changes because stuff like this was all](https://youtu.be/UlNwQ6WqCMw?t=00h32m57s)

[around](https://youtu.be/UlNwQ6WqCMw?t=00h32m59s)

[uh leveraging some newer apis so this](https://youtu.be/UlNwQ6WqCMw?t=00h33m00s)

[this project needs a little bit of love](https://youtu.be/UlNwQ6WqCMw?t=00h33m04s)

[but](https://youtu.be/UlNwQ6WqCMw?t=00h33m05s)

[come back to it later](https://youtu.be/UlNwQ6WqCMw?t=00h33m06s)

[uh we'll bring these methods in](https://youtu.be/UlNwQ6WqCMw?t=00h33m08s)

[i'm just going to slap them right at the](https://youtu.be/UlNwQ6WqCMw?t=00h33m11s)

[top because i don't want to think too](https://youtu.be/UlNwQ6WqCMw?t=00h33m12s)

[hard though i do want to get rid of that](https://youtu.be/UlNwQ6WqCMw?t=00h33m14s)

[message box](https://youtu.be/UlNwQ6WqCMw?t=00h33m15s)

[yeah](https://youtu.be/UlNwQ6WqCMw?t=00h33m20s)

[trying to decide if these are actually](https://youtu.be/UlNwQ6WqCMw?t=00h33m23s)

[needed](https://youtu.be/UlNwQ6WqCMw?t=00h33m24s)

[i'm a little i'd be a little miffed if](https://youtu.be/UlNwQ6WqCMw?t=00h33m31s)

[the bootstrapper didn't do this for me](https://youtu.be/UlNwQ6WqCMw?t=00h33m33s)

[but](https://youtu.be/UlNwQ6WqCMw?t=00h33m36s)

[we're gonna follow it so](https://youtu.be/UlNwQ6WqCMw?t=00h33m37s)

[and i personally don't like desktop](https://youtu.be/UlNwQ6WqCMw?t=00h33m39s)

[icons i find them annoying](https://youtu.be/UlNwQ6WqCMw?t=00h33m42s)

[and again the target audience for this](https://youtu.be/UlNwQ6WqCMw?t=00h33m46s)

[app is me so my preferences matter](https://youtu.be/UlNwQ6WqCMw?t=00h33m48s)

[because i represent a hundred percent of](https://youtu.be/UlNwQ6WqCMw?t=00h33m50s)

[my target user base](https://youtu.be/UlNwQ6WqCMw?t=00h33m52s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h33m54s)

[uh build publisher app](https://youtu.be/UlNwQ6WqCMw?t=00h33m55s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h33m59s)

[uh we can do this](https://youtu.be/UlNwQ6WqCMw?t=00h34m00s)

[sorry i'm gonna just](https://youtu.be/UlNwQ6WqCMw?t=00h34m07s)

[get myself into the right directory](https://youtu.be/UlNwQ6WqCMw?t=00h34m09s)

[okay uh dotnet](https://youtu.be/UlNwQ6WqCMw?t=00h34m14s)

[publish](https://youtu.be/UlNwQ6WqCMw?t=00h34m16s)

[uh let's see release](https://youtu.be/UlNwQ6WqCMw?t=00h34m19s)

[uh oh](https://youtu.be/UlNwQ6WqCMw?t=00h34m21s)

[publish something like that maybe](https://youtu.be/UlNwQ6WqCMw?t=00h34m25s)

[uh we may want to whack that thing](https://youtu.be/UlNwQ6WqCMw?t=00h34m30s)

[because i kind of want to kill the msix](https://youtu.be/UlNwQ6WqCMw?t=00h34m35s)

[project](https://youtu.be/UlNwQ6WqCMw?t=00h34m37s)

[the whole point of this is to kill it so](https://youtu.be/UlNwQ6WqCMw?t=00h34m39s)

[i think rather than fighting with it](https://youtu.be/UlNwQ6WqCMw?t=00h34m42s)

[we're just going to](https://youtu.be/UlNwQ6WqCMw?t=00h34m43s)

[burn it to the ground](https://youtu.be/UlNwQ6WqCMw?t=00h34m46s)

[uh okay so let's remove you from the](https://youtu.be/UlNwQ6WqCMw?t=00h34m48s)

[solution](https://youtu.be/UlNwQ6WqCMw?t=00h34m51s)

[we won't delete the whole thing yet but](https://youtu.be/UlNwQ6WqCMw?t=00h34m52s)

[if i get it out of the solution it will](https://youtu.be/UlNwQ6WqCMw?t=00h34m53s)

[compile when i run that](https://youtu.be/UlNwQ6WqCMw?t=00h34m55s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=00h34m58s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=00h35m00s)

[uh let's start with a](https://youtu.be/UlNwQ6WqCMw?t=00h35m04s)

[little build first just to](https://youtu.be/UlNwQ6WqCMw?t=00h35m09s)

[we'll get the publishing in a moment but](https://youtu.be/UlNwQ6WqCMw?t=00h35m12s)

[let's just make sure it builds okay](https://youtu.be/UlNwQ6WqCMw?t=00h35m13s)

[okay so built](https://youtu.be/UlNwQ6WqCMw?t=00h35m18s)

[publish](https://youtu.be/UlNwQ6WqCMw?t=00h35m20s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h35m23s)

[oh i want to disable publish on some of](https://youtu.be/UlNwQ6WqCMw?t=00h35m27s)

[the targets because a lot of these don't](https://youtu.be/UlNwQ6WqCMw?t=00h35m29s)

[need to be published](https://youtu.be/UlNwQ6WqCMw?t=00h35m31s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h35m34s)

[what is the switch here](https://youtu.be/UlNwQ6WqCMw?t=00h35m34s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h35m37s)

[it's like is publish or something](https://youtu.be/UlNwQ6WqCMw?t=00h35m40s)

[is](https://youtu.be/UlNwQ6WqCMw?t=00h35m44s)

[it's packable](https://youtu.be/UlNwQ6WqCMw?t=00h35m50s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h35m52s)

[let's look there's a there is a](https://youtu.be/UlNwQ6WqCMw?t=00h35m53s)

[switch for](https://youtu.be/UlNwQ6WqCMw?t=00h35m55s)

[this um ccs](https://youtu.be/UlNwQ6WqCMw?t=00h35m56s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h36m00s)

[disable publish](https://youtu.be/UlNwQ6WqCMw?t=00h36m00s)

[publish configuration disabled for cs](https://youtu.be/UlNwQ6WqCMw?t=00h36m06s)

[project uh](https://youtu.be/UlNwQ6WqCMw?t=00h36m09s)

[that's not what i'm looking for dot net](https://youtu.be/UlNwQ6WqCMw?t=00h36m16s)

[publish command how to exclude project](https://youtu.be/UlNwQ6WqCMw?t=00h36m18s)

[to publish and publishing](https://youtu.be/UlNwQ6WqCMw?t=00h36m20s)

[from a solution](https://youtu.be/UlNwQ6WqCMw?t=00h36m21s)

[that looks exactly like what i want](https://youtu.be/UlNwQ6WqCMw?t=00h36m23s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=00h36m28s)

[oh specify the project](https://youtu.be/UlNwQ6WqCMw?t=00h36m30s)

[directly is publishable see i knew there](https://youtu.be/UlNwQ6WqCMw?t=00h36m38s)

[was a property](https://youtu.be/UlNwQ6WqCMw?t=00h36m41s)

[i don't want this on most of my](https://youtu.be/UlNwQ6WqCMw?t=00h36m45s)

[on most of my stuff](https://youtu.be/UlNwQ6WqCMw?t=00h36m50s)

[of you guys i don't i'm not](https://youtu.be/UlNwQ6WqCMw?t=00h36m53s)

[okay so now if i publish](https://youtu.be/UlNwQ6WqCMw?t=00h36m57s)

[i should only get the one](https://youtu.be/UlNwQ6WqCMw?t=00h37m00s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h37m04s)

[shared still published](https://youtu.be/UlNwQ6WqCMw?t=00h37m05s)

[oh probably because it's a dependency](https://youtu.be/UlNwQ6WqCMw?t=00h37m14s)

[that'll work okay](https://youtu.be/UlNwQ6WqCMw?t=00h37m18s)

[so we should have a](https://youtu.be/UlNwQ6WqCMw?t=00h37m24s)

[output directory called publish](https://youtu.be/UlNwQ6WqCMw?t=00h37m26s)

[and it contains all this stuff and we're](https://youtu.be/UlNwQ6WqCMw?t=00h37m30s)

[ready to go](https://youtu.be/UlNwQ6WqCMw?t=00h37m33s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h37m34s)

[that step](https://youtu.be/UlNwQ6WqCMw?t=00h37m36s)

[done](https://youtu.be/UlNwQ6WqCMw?t=00h37m37s)

[okay publish your app](https://youtu.be/UlNwQ6WqCMw?t=00h37m42s)

[creator scroll release using the scroll](https://youtu.be/UlNwQ6WqCMw?t=00h37m45s)

[exe command line tool this can be](https://youtu.be/UlNwQ6WqCMw?t=00h37m47s)

[downloaded from yada yada yada](https://youtu.be/UlNwQ6WqCMw?t=00h37m49s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h37m58s)

[so we may do this set alias thing](https://youtu.be/UlNwQ6WqCMw?t=00h37m59s)

[just to make my life a little bit easier](https://youtu.be/UlNwQ6WqCMw?t=00h38m03s)

[now you'll note this thing here is doing](https://youtu.be/UlNwQ6WqCMw?t=00h38m05s)

[userprofile.nuget and all of that stuff](https://youtu.be/UlNwQ6WqCMw?t=00h38m08s)

[that's all well and good let's just go](https://youtu.be/UlNwQ6WqCMw?t=00h38m11s)

[validate that](https://youtu.be/UlNwQ6WqCMw?t=00h38m13s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h38m15s)

[what's the easiest way to do this](https://youtu.be/UlNwQ6WqCMw?t=00h38m16s)

[actually we can copy this thing](https://youtu.be/UlNwQ6WqCMw?t=00h38m19s)

[wholesale and i'll just update the](https://youtu.be/UlNwQ6WqCMw?t=00h38m21s)

[version number](https://youtu.be/UlNwQ6WqCMw?t=00h38m22s)

[is is that guy correct for the version](https://youtu.be/UlNwQ6WqCMw?t=00h38m24s)

[42 so 2 9 40 oh so that's not quite](https://youtu.be/UlNwQ6WqCMw?t=00h38m31s)

[right that's a little dated](https://youtu.be/UlNwQ6WqCMw?t=00h38m35s)

[we're going to do this](https://youtu.be/UlNwQ6WqCMw?t=00h38m38s)

[so it's worth noting when you're using](https://youtu.be/UlNwQ6WqCMw?t=00h38m42s)

[the newer cs product what ends up](https://youtu.be/UlNwQ6WqCMw?t=00h38m44s)

[happening is inside of your user profile](https://youtu.be/UlNwQ6WqCMw?t=00h38m45s)

[you do have this dot nuget folder](https://youtu.be/UlNwQ6WqCMw?t=00h38m47s)

[this is where](https://youtu.be/UlNwQ6WqCMw?t=00h38m50s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h38m51s)

[when nougat restores happen](https://youtu.be/UlNwQ6WqCMw?t=00h38m52s)

[the new get package gets downloaded](https://youtu.be/UlNwQ6WqCMw?t=00h38m54s)

[unzipped into this directory](https://youtu.be/UlNwQ6WqCMw?t=00h38m56s)

[and then referenced and pulled into all](https://youtu.be/UlNwQ6WqCMw?t=00h38m59s)

[of your projects so if you have five](https://youtu.be/UlNwQ6WqCMw?t=00h39m00s)

[projects that all reference the same](https://youtu.be/UlNwQ6WqCMw?t=00h39m02s)

[nuket package](https://youtu.be/UlNwQ6WqCMw?t=00h39m03s)

[they're going to share the same download](https://youtu.be/UlNwQ6WqCMw?t=00h39m05s)

[which is highly convenient](https://youtu.be/UlNwQ6WqCMw?t=00h39m07s)

[before they used to all be inside the](https://youtu.be/UlNwQ6WqCMw?t=00h39m09s)

[same solution directory which is](https://youtu.be/UlNwQ6WqCMw?t=00h39m11s)

[sometimes a little problematic](https://youtu.be/UlNwQ6WqCMw?t=00h39m13s)

[but by default this is the behavior](https://youtu.be/UlNwQ6WqCMw?t=00h39m15s)

[you're gonna get](https://youtu.be/UlNwQ6WqCMw?t=00h39m17s)

[okay so now we got that that's great we](https://youtu.be/UlNwQ6WqCMw?t=00h39m18s)

[don't need this download because we](https://youtu.be/UlNwQ6WqCMw?t=00h39m21s)

[don't have a place we're gonna be](https://youtu.be/UlNwQ6WqCMw?t=00h39m22s)

[hosting yet](https://youtu.be/UlNwQ6WqCMw?t=00h39m24s)

[so we're just gonna straight up do the](https://youtu.be/UlNwQ6WqCMw?t=00h39m25s)

[squirrel pat command](https://youtu.be/UlNwQ6WqCMw?t=00h39m27s)

[i'm gonna put that guy there and](https://youtu.be/UlNwQ6WqCMw?t=00h39m30s)

[bring you up so if i do](https://youtu.be/UlNwQ6WqCMw?t=00h39m32s)

[that was not the tab](https://youtu.be/UlNwQ6WqCMw?t=00h39m36s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h39m40s)

[uh can i just do virgin or something and](https://youtu.be/UlNwQ6WqCMw?t=00h39m43s)

[see](https://youtu.be/UlNwQ6WqCMw?t=00h39m46s)

[there okay good so that thing that](https://youtu.be/UlNwQ6WqCMw?t=00h39m48s)

[thing's working oh they've got a pretty](https://youtu.be/UlNwQ6WqCMw?t=00h39m50s)

[sh](https://youtu.be/UlNwQ6WqCMw?t=00h39m52s)

[oh this is](https://youtu.be/UlNwQ6WqCMw?t=00h39m53s)

[pretty okay the fact that dash dash](https://youtu.be/UlNwQ6WqCMw?t=00h39m54s)

[version doesn't work makes me a little](https://youtu.be/UlNwQ6WqCMw?t=00h39m57s)

[twitchy](https://youtu.be/UlNwQ6WqCMw?t=00h39m58s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h39m59s)

[i kind of want to look at i kind of want](https://youtu.be/UlNwQ6WqCMw?t=00h40m04s)

[to look at their cli at some point this](https://youtu.be/UlNwQ6WqCMw?t=00h40m05s)

[might be a cool one to update the system](https://youtu.be/UlNwQ6WqCMw?t=00h40m07s)

[command line or maybe i'll i'll post an](https://youtu.be/UlNwQ6WqCMw?t=00h40m08s)

[issue and ask if they're interested in](https://youtu.be/UlNwQ6WqCMw?t=00h40m10s)

[it](https://youtu.be/UlNwQ6WqCMw?t=00h40m12s)

[because this might be a fun help output](https://youtu.be/UlNwQ6WqCMw?t=00h40m15s)

[to try to design because they've got a](https://youtu.be/UlNwQ6WqCMw?t=00h40m17s)

[little they've got a little bit of](https://youtu.be/UlNwQ6WqCMw?t=00h40m19s)

[prettiness going on](https://youtu.be/UlNwQ6WqCMw?t=00h40m20s)

[here we could we could slap on some some](https://youtu.be/UlNwQ6WqCMw?t=00h40m22s)

[system command line with some spectre](https://youtu.be/UlNwQ6WqCMw?t=00h40m25s)

[console and](https://youtu.be/UlNwQ6WqCMw?t=00h40m27s)

[make it a little pretty](https://youtu.be/UlNwQ6WqCMw?t=00h40m29s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h40m32s)

[backblaze](https://youtu.be/UlNwQ6WqCMw?t=00h40m35s)

[http which that's what we'll end up](https://youtu.be/UlNwQ6WqCMw?t=00h40m37s)

[using github down so they've put in some](https://youtu.be/UlNwQ6WqCMw?t=00h40m39s)

[some built-in support for very specific](https://youtu.be/UlNwQ6WqCMw?t=00h40m42s)

[targets where people like to host things](https://youtu.be/UlNwQ6WqCMw?t=00h40m44s)

[it's pretty cool so this download here](https://youtu.be/UlNwQ6WqCMw?t=00h40m48s)

[is only relevant because when you do the](https://youtu.be/UlNwQ6WqCMw?t=00h40m50s)

[pack um](https://youtu.be/UlNwQ6WqCMw?t=00h40m52s)

[if you turn on](https://youtu.be/UlNwQ6WqCMw?t=00h40m54s)

[error throw in some spell check as well](https://youtu.be/UlNwQ6WqCMw?t=00h40m57s)

[oh is that there too did i miss that](https://youtu.be/UlNwQ6WqCMw?t=00h41m00s)

[oh yeah](https://youtu.be/UlNwQ6WqCMw?t=00h41m03s)

[[Laughter]](https://youtu.be/UlNwQ6WqCMw?t=00h41m05s)

[that's a good catch that's good catch](https://youtu.be/UlNwQ6WqCMw?t=00h41m07s)

[hold on now i have to look i bet you](https://youtu.be/UlNwQ6WqCMw?t=00h41m10s)

[that's probably literally right in the](https://youtu.be/UlNwQ6WqCMw?t=00h41m12s)

[code](https://youtu.be/UlNwQ6WqCMw?t=00h41m14s)

[exactly](https://youtu.be/UlNwQ6WqCMw?t=00h41m15s)

[i gotta just look now i gotta just look](https://youtu.be/UlNwQ6WqCMw?t=00h41m17s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h41m23s)

[really that's not in the code](https://youtu.be/UlNwQ6WqCMw?t=00h41m29s)

[or is](https://youtu.be/UlNwQ6WqCMw?t=00h41m32s)

[or is](https://youtu.be/UlNwQ6WqCMw?t=00h41m33s)

[github](https://youtu.be/UlNwQ6WqCMw?t=00h41m35s)

[is it not literally](https://youtu.be/UlNwQ6WqCMw?t=00h41m38s)

[i know there one of my colleagues was](https://youtu.be/UlNwQ6WqCMw?t=00h41m42s)

[pointing out the exact](https://youtu.be/UlNwQ6WqCMw?t=00h41m44s)

[text match is sometimes a little](https://youtu.be/UlNwQ6WqCMw?t=00h41m47s)

[problematic for substring matching](https://youtu.be/UlNwQ6WqCMw?t=00h41m49s)

[but i'm betting it is in there and](https://youtu.be/UlNwQ6WqCMw?t=00h41m53s)

[especially since i'm seeing other issues](https://youtu.be/UlNwQ6WqCMw?t=00h41m54s)

[logged](https://youtu.be/UlNwQ6WqCMw?t=00h41m56s)

[but if anybody wants to uh go snipe that](https://youtu.be/UlNwQ6WqCMw?t=00h41m57s)

[one](https://youtu.be/UlNwQ6WqCMw?t=00h42m00s)

[probably an easy one to do](https://youtu.be/UlNwQ6WqCMw?t=00h42m01s)

[okay i want to look real quick what is](https://youtu.be/UlNwQ6WqCMw?t=00h42m03s)

[there](https://youtu.be/UlNwQ6WqCMw?t=00h42m05s)

[program cs](https://youtu.be/UlNwQ6WqCMw?t=00h42m10s)

[are they using here](https://youtu.be/UlNwQ6WqCMw?t=00h42m16s)

[um they're using mono options](https://youtu.be/UlNwQ6WqCMw?t=00h42m19s)

[interesting](https://youtu.be/UlNwQ6WqCMw?t=00h42m22s)

[model options is good and it was one of](https://youtu.be/UlNwQ6WqCMw?t=00h42m23s)

[the ones that system command line looked](https://youtu.be/UlNwQ6WqCMw?t=00h42m25s)

[at for comparison for features mono](https://youtu.be/UlNwQ6WqCMw?t=00h42m27s)

[options is](https://youtu.be/UlNwQ6WqCMw?t=00h42m30s)

[small](https://youtu.be/UlNwQ6WqCMw?t=00h42m32s)

[limited feature set](https://youtu.be/UlNwQ6WqCMw?t=00h42m33s)

[but it's fast but it's small](https://youtu.be/UlNwQ6WqCMw?t=00h42m35s)

[and you'll note it doesn't have things](https://youtu.be/UlNwQ6WqCMw?t=00h42m38s)

[like the dash dash help or the](https://youtu.be/UlNwQ6WqCMw?t=00h42m39s)

[tab completion or all the other fun](https://youtu.be/UlNwQ6WqCMw?t=00h42m42s)

[stuff](https://youtu.be/UlNwQ6WqCMw?t=00h42m44s)

[that's in here](https://youtu.be/UlNwQ6WqCMw?t=00h42m45s)

[hoping to just see here while i'm in](https://youtu.be/UlNwQ6WqCMw?t=00h42m48s)

[here](https://youtu.be/UlNwQ6WqCMw?t=00h42m50s)

[now that i](https://youtu.be/UlNwQ6WqCMw?t=00h42m51s)

[it was e-o-e-r-r-o](https://youtu.be/UlNwQ6WqCMw?t=00h42m57s)

[interesting i don't see it it's not at](https://youtu.be/UlNwQ6WqCMw?t=00h43m04s)

[least immediately right here](https://youtu.be/UlNwQ6WqCMw?t=00h43m05s)

[okay well i won't do it i won't dig too](https://youtu.be/UlNwQ6WqCMw?t=00h43m10s)

[much i won't rabbit trail](https://youtu.be/UlNwQ6WqCMw?t=00h43m12s)

[squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h43m14s)

[uh sorry again](https://youtu.be/UlNwQ6WqCMw?t=00h43m15s)

[my attempted humor](https://youtu.be/UlNwQ6WqCMw?t=00h43m17s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h43m21s)

[though it is also possible that](https://youtu.be/UlNwQ6WqCMw?t=00h43m22s)

[i see commits going in 23 days ago and](https://youtu.be/UlNwQ6WqCMw?t=00h43m26s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=00h43m29s)

[on june so](https://youtu.be/UlNwQ6WqCMw?t=00h43m30s)

[maybe it just has already gotten fixed](https://youtu.be/UlNwQ6WqCMw?t=00h43m33s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h43m36s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h43m37s)

[got distracted got distracted we are](https://youtu.be/UlNwQ6WqCMw?t=00h43m38s)

[doing cloud](https://youtu.be/UlNwQ6WqCMw?t=00h43m40s)

[we want to do the pack pack command](https://youtu.be/UlNwQ6WqCMw?t=00h43m42s)

[okay so we want to do](https://youtu.be/UlNwQ6WqCMw?t=00h43m44s)

[squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h43m47s)

[pack](https://youtu.be/UlNwQ6WqCMw?t=00h43m50s)

[we're going to do](https://youtu.be/UlNwQ6WqCMw?t=00h43m53s)

[oh](https://youtu.be/UlNwQ6WqCMw?t=00h43m56s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h43m57s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=00h43m57s)

[that's uh](https://youtu.be/UlNwQ6WqCMw?t=00h44m00s)

[there let's see](https://youtu.be/UlNwQ6WqCMw?t=00h44m02s)

[framework net](https://youtu.be/UlNwQ6WqCMw?t=00h44m04s)

[six](https://youtu.be/UlNwQ6WqCMw?t=00h44m07s)

[i wonder if this is actually needed](https://youtu.be/UlNwQ6WqCMw?t=00h44m15s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=00h44m22s)

[i think it might be](https://youtu.be/UlNwQ6WqCMw?t=00h44m27s)

[something in the back of my mind is](https://youtu.be/UlNwQ6WqCMw?t=00h44m29s)

[telling me that i need the](https://youtu.be/UlNwQ6WqCMw?t=00h44m31s)

[bc redistributable i don't recall why](https://youtu.be/UlNwQ6WqCMw?t=00h44m33s)

[though](https://youtu.be/UlNwQ6WqCMw?t=00h44m35s)

[so we're going to go with it](https://youtu.be/UlNwQ6WqCMw?t=00h44m36s)

[pack id so this will be](https://youtu.be/UlNwQ6WqCMw?t=00h44m38s)

[simply budget](https://youtu.be/UlNwQ6WqCMw?t=00h44m40s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=00h44m43s)

[pack version](https://youtu.be/UlNwQ6WqCMw?t=00h44m46s)

[is going to be 1.0.0](https://youtu.be/UlNwQ6WqCMw?t=00h44m48s)

[we're going to change it uh](https://youtu.be/UlNwQ6WqCMw?t=00h44m52s)

[pack](https://youtu.be/UlNwQ6WqCMw?t=00h44m54s)

[authors](https://youtu.be/UlNwQ6WqCMw?t=00h44m55s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h44m57s)

[me](https://youtu.be/UlNwQ6WqCMw?t=00h44m59s)

[uh let's see pack der](https://youtu.be/UlNwQ6WqCMw?t=00h45m01s)

[dur is spelled with a d](https://youtu.be/UlNwQ6WqCMw?t=00h45m06s)

[is going to be](https://youtu.be/UlNwQ6WqCMw?t=00h45m09s)

[published](https://youtu.be/UlNwQ6WqCMw?t=00h45m11s)

[uh we don't have an icon and we don't](https://youtu.be/UlNwQ6WqCMw?t=00h45m14s)

[have a splash image those are both](https://youtu.be/UlNwQ6WqCMw?t=00h45m16s)

[optional in squirrel windows so i'm](https://youtu.be/UlNwQ6WqCMw?t=00h45m17s)

[assuming they're optional here too](https://youtu.be/UlNwQ6WqCMw?t=00h45m19s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h45m24s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=00h45m25s)

[framework does not exist](https://youtu.be/UlNwQ6WqCMw?t=00h45m27s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h45m39s)

[so you know it jammed up a new spec for](https://youtu.be/UlNwQ6WqCMw?t=00h45m42s)

[me which is rather convenient](https://youtu.be/UlNwQ6WqCMw?t=00h45m44s)

[uh to knit 602](https://youtu.be/UlNwQ6WqCMw?t=00h45m53s)

[that's kind of cool](https://youtu.be/UlNwQ6WqCMw?t=00h45m56s)

[oh that's nice](https://youtu.be/UlNwQ6WqCMw?t=00h46m00s)

[that's very nice so it](https://youtu.be/UlNwQ6WqCMw?t=00h46m02s)

[it auto did the oh that's very](https://youtu.be/UlNwQ6WqCMw?t=00h46m04s)

[convenient how wonderful](https://youtu.be/UlNwQ6WqCMw?t=00h46m06s)

[okay so removing unnecessary data no](https://youtu.be/UlNwQ6WqCMw?t=00h46m13s)

[release notes](https://youtu.be/UlNwQ6WqCMw?t=00h46m15s)

[there are one scroll aware apps binaries](https://youtu.be/UlNwQ6WqCMw?t=00h46m20s)

[will be executed during install blah](https://youtu.be/UlNwQ6WqCMw?t=00h46m22s)

[blah blah blah blah blah](https://youtu.be/UlNwQ6WqCMw?t=00h46m24s)

[creating setup bundle](https://youtu.be/UlNwQ6WqCMw?t=00h46m26s)

[setup bundle created inside of releases](https://youtu.be/UlNwQ6WqCMw?t=00h46m28s)

[so if i go and look here i should have a](https://youtu.be/UlNwQ6WqCMw?t=00h46m32s)

[releases folder](https://youtu.be/UlNwQ6WqCMw?t=00h46m34s)

[i've got a setup](https://youtu.be/UlNwQ6WqCMw?t=00h46m37s)

[uh so for people who are who are](https://youtu.be/UlNwQ6WqCMw?t=00h46m40s)

[interested](https://youtu.be/UlNwQ6WqCMw?t=00h46m43s)

[this releases director this releases](https://youtu.be/UlNwQ6WqCMw?t=00h46m45s)

[file here is one of the things that i](https://youtu.be/UlNwQ6WqCMw?t=00h46m47s)

[might potentially consider caching](https://youtu.be/UlNwQ6WqCMw?t=00h46m48s)

[inside of my web service so this is when](https://youtu.be/UlNwQ6WqCMw?t=00h46m50s)

[the when the app does an update check](https://youtu.be/UlNwQ6WqCMw?t=00h46m53s)

[what it is doing is it's actually going](https://youtu.be/UlNwQ6WqCMw?t=00h46m56s)

[to make just a simple http request to](https://youtu.be/UlNwQ6WqCMw?t=00h46m57s)

[get this releases file](https://youtu.be/UlNwQ6WqCMw?t=00h47m00s)

[and then this is how it knows if it is](https://youtu.be/UlNwQ6WqCMw?t=00h47m02s)

[expected to](https://youtu.be/UlNwQ6WqCMw?t=00h47m04s)

[uh download a new version so](https://youtu.be/UlNwQ6WqCMw?t=00h47m05s)

[this contains the version information](https://youtu.be/UlNwQ6WqCMw?t=00h47m08s)

[uh i believe this is like md5 hash for](https://youtu.be/UlNwQ6WqCMw?t=00h47m11s)

[validation to make sure it hasn't been](https://youtu.be/UlNwQ6WqCMw?t=00h47m14s)

[tampered with and i don't remember what](https://youtu.be/UlNwQ6WqCMw?t=00h47m15s)

[the third number is](https://youtu.be/UlNwQ6WqCMw?t=00h47m17s)

[something](https://youtu.be/UlNwQ6WqCMw?t=00h47m19s)

[and i'm sure it's important but as you](https://youtu.be/UlNwQ6WqCMw?t=00h47m21s)

[have more and more releases](https://youtu.be/UlNwQ6WqCMw?t=00h47m23s)

[this is where the additional packages](https://youtu.be/UlNwQ6WqCMw?t=00h47m25s)

[will get added to and then more](https://youtu.be/UlNwQ6WqCMw?t=00h47m28s)

[importantly](https://youtu.be/UlNwQ6WqCMw?t=00h47m29s)

[if you have delta packages turned on](https://youtu.be/UlNwQ6WqCMw?t=00h47m31s)

[which it looks like this is by default](https://youtu.be/UlNwQ6WqCMw?t=00h47m33s)

[what it will do is it will actually](https://youtu.be/UlNwQ6WqCMw?t=00h47m35s)

[generate rather than the full package](https://youtu.be/UlNwQ6WqCMw?t=00h47m36s)

[which contains your app and all the](https://youtu.be/UlNwQ6WqCMw?t=00h47m38s)

[stuff](https://youtu.be/UlNwQ6WqCMw?t=00h47m39s)

[if it's doing an update check and](https://youtu.be/UlNwQ6WqCMw?t=00h47m40s)

[there's a delta package from its current](https://youtu.be/UlNwQ6WqCMw?t=00h47m42s)

[one to its next one it can download just](https://youtu.be/UlNwQ6WqCMw?t=00h47m44s)

[the deltas and apply those which can](https://youtu.be/UlNwQ6WqCMw?t=00h47m46s)

[make it the install even faster because](https://youtu.be/UlNwQ6WqCMw?t=00h47m48s)

[now it doesn't have to download a whole](https://youtu.be/UlNwQ6WqCMw?t=00h47m50s)

[bunch of dlls that maybe haven't changed](https://youtu.be/UlNwQ6WqCMw?t=00h47m52s)

[right because even though my app](https://youtu.be/UlNwQ6WqCMw?t=00h47m55s)

[may have a change](https://youtu.be/UlNwQ6WqCMw?t=00h47m58s)

[there's a lot of dlls in here that maybe](https://youtu.be/UlNwQ6WqCMw?t=00h48m00s)

[won't be changing every single release](https://youtu.be/UlNwQ6WqCMw?t=00h48m02s)

[like all of the microsoft dot ones those](https://youtu.be/UlNwQ6WqCMw?t=00h48m04s)

[ones may or may not change](https://youtu.be/UlNwQ6WqCMw?t=00h48m07s)

[interesting i should look why are the](https://youtu.be/UlNwQ6WqCMw?t=00h48m11s)

[test platform ones being brought in](https://youtu.be/UlNwQ6WqCMw?t=00h48m13s)

[huh i probably got some extra references](https://youtu.be/UlNwQ6WqCMw?t=00h48m19s)

[that i don't need lying around so i](https://youtu.be/UlNwQ6WqCMw?t=00h48m21s)

[should probably clean those up because](https://youtu.be/UlNwQ6WqCMw?t=00h48m23s)

[i'm also seeing testos gonna have been](https://youtu.be/UlNwQ6WqCMw?t=00h48m24s)

[a little bit of devops activities yes](https://youtu.be/UlNwQ6WqCMw?t=00h48m27s)

[absolutely yes](https://youtu.be/UlNwQ6WqCMw?t=00h48m29s)

[so](https://youtu.be/UlNwQ6WqCMw?t=00h48m31s)

[we are packaging up a wpf app](https://youtu.be/UlNwQ6WqCMw?t=00h48m32s)

[and using so part of this is me wanting](https://youtu.be/UlNwQ6WqCMw?t=00h48m34s)

[to learn cloud scroll](https://youtu.be/UlNwQ6WqCMw?t=00h48m38s)

[but we're going to package the wpf app](https://youtu.be/UlNwQ6WqCMw?t=00h48m39s)

[up and then rather than just hosting it](https://youtu.be/UlNwQ6WqCMw?t=00h48m42s)

[on github the goal is to](https://youtu.be/UlNwQ6WqCMw?t=00h48m44s)

[sort of host on github but put a web api](https://youtu.be/UlNwQ6WqCMw?t=00h48m46s)

[in the middle to handle the update calls](https://youtu.be/UlNwQ6WqCMw?t=00h48m49s)

[and that kind of thing](https://youtu.be/UlNwQ6WqCMw?t=00h48m51s)

[it's overkill but i like it a little bit](https://youtu.be/UlNwQ6WqCMw?t=00h48m52s)

[better](https://youtu.be/UlNwQ6WqCMw?t=00h48m55s)

[so far we have](https://youtu.be/UlNwQ6WqCMw?t=00h48m56s)

[built and deployed a](https://youtu.be/UlNwQ6WqCMw?t=00h48m58s)

[default asp.net core app all the way up](https://youtu.be/UlNwQ6WqCMw?t=00h48m59s)

[and out it's a very boring app](https://youtu.be/UlNwQ6WqCMw?t=00h49m03s)

[it does nothing and interesting](https://youtu.be/UlNwQ6WqCMw?t=00h49m06s)

[it's the default project template](https://youtu.be/UlNwQ6WqCMw?t=00h49m09s)

[default project template isn't even](https://youtu.be/UlNwQ6WqCMw?t=00h49m11s)

[formatted correctly](https://youtu.be/UlNwQ6WqCMw?t=00h49m13s)

[just disappointing um](https://youtu.be/UlNwQ6WqCMw?t=00h49m14s)

[but this is going to be uh handling the](https://youtu.be/UlNwQ6WqCMw?t=00h49m17s)

[update checks for app](https://youtu.be/UlNwQ6WqCMw?t=00h49m20s)

[so but we did get ci cd already built](https://youtu.be/UlNwQ6WqCMw?t=00h49m21s)

[and plugged into that too which was kind](https://youtu.be/UlNwQ6WqCMw?t=00h49m24s)

[of cool](https://youtu.be/UlNwQ6WqCMw?t=00h49m26s)

[because azure wrote the github action](https://youtu.be/UlNwQ6WqCMw?t=00h49m28s)

[for us](https://youtu.be/UlNwQ6WqCMw?t=00h49m30s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=00h49m31s)

[let's just make sure this installer](https://youtu.be/UlNwQ6WqCMw?t=00h49m33s)

[works i guess that's that's step one](https://youtu.be/UlNwQ6WqCMw?t=00h49m34s)

[yeah so we double click](https://youtu.be/UlNwQ6WqCMw?t=00h49m40s)

[it should perform the install and auto](https://youtu.be/UlNwQ6WqCMw?t=00h49m43s)

[launch the app](https://youtu.be/UlNwQ6WqCMw?t=00h49m44s)

[and we'll see if that's what happens](https://youtu.be/UlNwQ6WqCMw?t=00h49m48s)

[thinking thinking thinking i know my app](https://youtu.be/UlNwQ6WqCMw?t=00h49m51s)

[on initial startup also has to do things](https://youtu.be/UlNwQ6WqCMw?t=00h49m54s)

[like create a database](https://youtu.be/UlNwQ6WqCMw?t=00h49m57s)

[uh tried without the app manifest bit](https://youtu.be/UlNwQ6WqCMw?t=00h50m03s)

[and it seems to discourage it once you](https://youtu.be/UlNwQ6WqCMw?t=00h50m05s)

[let's at least skip the validation if](https://youtu.be/UlNwQ6WqCMw?t=00h50m08s)

[you do ah good to know](https://youtu.be/UlNwQ6WqCMw?t=00h50m11s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h50m15s)

[so one that didn't appear to launch](https://youtu.be/UlNwQ6WqCMw?t=00h50m19s)

[but i i'm al so hold on so step one](https://youtu.be/UlNwQ6WqCMw?t=00h50m22s)

[let's make sure the thing we published](https://youtu.be/UlNwQ6WqCMw?t=00h50m24s)

[actually starts](https://youtu.be/UlNwQ6WqCMw?t=00h50m26s)

[i guess i do have an icon](https://youtu.be/UlNwQ6WqCMw?t=00h50m29s)

[i forgot about that](https://youtu.be/UlNwQ6WqCMw?t=00h50m31s)

[does the app start when i launch it](https://youtu.be/UlNwQ6WqCMw?t=00h50m35s)

[because if this exe doesn't start it](https://youtu.be/UlNwQ6WqCMw?t=00h50m38s)

[doesn't matter what i do with squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h50m40s)

[it's just gonna fail](https://youtu.be/UlNwQ6WqCMw?t=00h50m41s)

[no](https://youtu.be/UlNwQ6WqCMw?t=00h50m44s)

[it looks like my app may just be crash](https://youtu.be/UlNwQ6WqCMw?t=00h50m47s)

[that's exciting](https://youtu.be/UlNwQ6WqCMw?t=00h50m49s)

[okay so what is the air](https://youtu.be/UlNwQ6WqCMw?t=00h50m51s)

[okay so pro tip if your app is dying on](https://youtu.be/UlNwQ6WqCMw?t=00h50m57s)

[startup you open up the event viewer and](https://youtu.be/UlNwQ6WqCMw?t=00h51m00s)

[you go to windows logs application and](https://youtu.be/UlNwQ6WqCMw?t=00h51m03s)

[if you see net runtime this is probably](https://youtu.be/UlNwQ6WqCMw?t=00h51m06s)

[your wpf app crashing take a look](https://youtu.be/UlNwQ6WqCMw?t=00h51m08s)

[because you can see application error](https://youtu.be/UlNwQ6WqCMw?t=00h51m10s)

[hey look simply budget exe that's me](https://youtu.be/UlNwQ6WqCMw?t=00h51m12s)

[uh could not find](https://youtu.be/UlNwQ6WqCMw?t=00h51m15s)

[or load assembly microsoft dependency](https://youtu.be/UlNwQ6WqCMw?t=00h51m17s)

[injection abstractions version 5.0](https://youtu.be/UlNwQ6WqCMw?t=00h51m20s)

[so it tried to launch load up this](https://youtu.be/UlNwQ6WqCMw?t=00h51m25s)

[assembly and the one that it found was](https://youtu.be/UlNwQ6WqCMw?t=00h51m28s)

[wrong](https://youtu.be/UlNwQ6WqCMw?t=00h51m30s)

[we didn't](https://youtu.be/UlNwQ6WqCMw?t=00h51m32s)

[update that did we](https://youtu.be/UlNwQ6WqCMw?t=00h51m34s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h51m37s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=00h51m40s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h51m42s)

[that is not useful](https://youtu.be/UlNwQ6WqCMw?t=00h51m45s)

[because file version and assembly](https://youtu.be/UlNwQ6WqCMw?t=00h51m53s)

[version aren't necessarily the same](https://youtu.be/UlNwQ6WqCMw?t=00h51m56s)

[thing and those are vastly vastly](https://youtu.be/UlNwQ6WqCMw?t=00h51m57s)

[different](https://youtu.be/UlNwQ6WqCMw?t=00h51m59s)

[because the](https://youtu.be/UlNwQ6WqCMw?t=00h52m01s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h52m03s)

[trying not to rabbit trail i'm trying](https://youtu.be/UlNwQ6WqCMw?t=00h52m05s)

[not to rabbit trail i really promise i](https://youtu.be/UlNwQ6WqCMw?t=00h52m07s)

[ain't](https://youtu.be/UlNwQ6WqCMw?t=00h52m08s)

[i should just validate](https://youtu.be/UlNwQ6WqCMw?t=00h52m12s)

[let's just just validate what happens](https://youtu.be/UlNwQ6WqCMw?t=00h52m14s)

[when i f5 this thing i don't know what](https://youtu.be/UlNwQ6WqCMw?t=00h52m16s)

[data i have loaded into here](https://youtu.be/UlNwQ6WqCMw?t=00h52m18s)

[so](https://youtu.be/UlNwQ6WqCMw?t=00h52m21s)

[it should all be random test data](https://youtu.be/UlNwQ6WqCMw?t=00h52m23s)

[but occasionally i mix random test data](https://youtu.be/UlNwQ6WqCMw?t=00h52m26s)

[with real data](https://youtu.be/UlNwQ6WqCMw?t=00h52m28s)

[which is not good](https://youtu.be/UlNwQ6WqCMw?t=00h52m31s)

[uh rabbit trail keep it keeps it](https://youtu.be/UlNwQ6WqCMw?t=00h52m33s)

[exciting it does it does let's](https://youtu.be/UlNwQ6WqCMw?t=00h52m36s)

[we're gonna make sure the app launches](https://youtu.be/UlNwQ6WqCMw?t=00h52m40s)

[you are an oracle this research is in my](https://youtu.be/UlNwQ6WqCMw?t=00h52m47s)

[back greetings](https://youtu.be/UlNwQ6WqCMw?t=00h52m49s)

[ah thank you i appreciate it](https://youtu.be/UlNwQ6WqCMw?t=00h52m52s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h52m56s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=00h52m57s)

[are you paused what are you what are you](https://youtu.be/UlNwQ6WqCMw?t=00h53m02s)

[doing](https://youtu.be/UlNwQ6WqCMw?t=00h53m04s)

[uh where's my output window output](https://youtu.be/UlNwQ6WqCMw?t=00h53m06s)

[window](https://youtu.be/UlNwQ6WqCMw?t=00h53m08s)

[oh so it's doing it's doing a bunch of](https://youtu.be/UlNwQ6WqCMw?t=00h53m12s)

[stuff okay cool](https://youtu.be/UlNwQ6WqCMw?t=00h53m13s)

[yeah and it looks like a load of default](https://youtu.be/UlNwQ6WqCMw?t=00h53m16s)

[data do not panic about the bright](https://youtu.be/UlNwQ6WqCMw?t=00h53m17s)

[orange](https://youtu.be/UlNwQ6WqCMw?t=00h53m19s)

[there is a pound if death that if you](https://youtu.be/UlNwQ6WqCMw?t=00h53m20s)

[compile and debug menu it uses the](https://youtu.be/UlNwQ6WqCMw?t=00h53m22s)

[orange coloring because i had a number](https://youtu.be/UlNwQ6WqCMw?t=00h53m24s)

[of times where i accidentally confused](https://youtu.be/UlNwQ6WqCMw?t=00h53m26s)

[my debug and release builds and so i i](https://youtu.be/UlNwQ6WqCMw?t=00h53m28s)

[pound if there's a here i'll just show](https://youtu.be/UlNwQ6WqCMw?t=00h53m31s)

[it to you](https://youtu.be/UlNwQ6WqCMw?t=00h53m33s)

[there's a thingy in here](https://youtu.be/UlNwQ6WqCMw?t=00h53m34s)

[that if debug](https://youtu.be/UlNwQ6WqCMw?t=00h53m39s)

[yeah so if debug](https://youtu.be/UlNwQ6WqCMw?t=00h53m41s)

[make the make the theme of the app](https://youtu.be/UlNwQ6WqCMw?t=00h53m43s)

[orange](https://youtu.be/UlNwQ6WqCMw?t=00h53m45s)

[so big and ugly](https://youtu.be/UlNwQ6WqCMw?t=00h53m47s)

[but i have never once messed up my uh](https://youtu.be/UlNwQ6WqCMw?t=00h53m50s)

[debugging release builds after doing](https://youtu.be/UlNwQ6WqCMw?t=00h53m53s)

[this so](https://youtu.be/UlNwQ6WqCMw?t=00h53m55s)

[problem solved](https://youtu.be/UlNwQ6WqCMw?t=00h53m57s)

[very low tech make it make it bigger so](https://youtu.be/UlNwQ6WqCMw?t=00h53m59s)

[this is a basic app it does it does this](https://youtu.be/UlNwQ6WqCMw?t=00h54m01s)

[kind of thing](https://youtu.be/UlNwQ6WqCMw?t=00h54m03s)

[and it works and has stuff and does it](https://youtu.be/UlNwQ6WqCMw?t=00h54m06s)

[does things again this is built very](https://youtu.be/UlNwQ6WqCMw?t=00h54m08s)

[much for me me and me](https://youtu.be/UlNwQ6WqCMw?t=00h54m10s)

[uh okay so that worked on debug](https://youtu.be/UlNwQ6WqCMw?t=00h54m13s)

[let's validate that it works on release](https://youtu.be/UlNwQ6WqCMw?t=00h54m16s)

[because that's what we published](https://youtu.be/UlNwQ6WqCMw?t=00h54m19s)

[and then after that we're going to](https://youtu.be/UlNwQ6WqCMw?t=00h54m24s)

[validate that the](https://youtu.be/UlNwQ6WqCMw?t=00h54m26s)

[uh you're debugging just my code](https://youtu.be/UlNwQ6WqCMw?t=00h54m28s)

[continue debugging](https://youtu.be/UlNwQ6WqCMw?t=00h54m33s)

[i suppose i could have just control f5](https://youtu.be/UlNwQ6WqCMw?t=00h54m34s)

[dip too it doesn't really matter if i](https://youtu.be/UlNwQ6WqCMw?t=00h54m37s)

[attach the debugger to it i'm really](https://youtu.be/UlNwQ6WqCMw?t=00h54m39s)

[just wanting the debugger attached so](https://youtu.be/UlNwQ6WqCMw?t=00h54m40s)

[that if it throws i see it](https://youtu.be/UlNwQ6WqCMw?t=00h54m42s)

[rather than having to go and look up the](https://youtu.be/UlNwQ6WqCMw?t=00h54m44s)

[exception after the fact](https://youtu.be/UlNwQ6WqCMw?t=00h54m45s)

[adding in something like app insights](https://youtu.be/UlNwQ6WqCMw?t=00h54m49s)

[would be a great addition](https://youtu.be/UlNwQ6WqCMw?t=00h54m51s)

[i'll make sure to add that to my backlog](https://youtu.be/UlNwQ6WqCMw?t=00h54m53s)

[new preview build of visual studio](https://youtu.be/UlNwQ6WqCMw?t=00h54m57s)

[i don't need it right now now is not the](https://youtu.be/UlNwQ6WqCMw?t=00h55m00s)

[time midstream is not the time to](https://youtu.be/UlNwQ6WqCMw?t=00h55m02s)

[install new visual studios](https://youtu.be/UlNwQ6WqCMw?t=00h55m04s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h55m06s)

[so here look](https://youtu.be/UlNwQ6WqCMw?t=00h55m07s)

[not ugly orange it's a a prettier green](https://youtu.be/UlNwQ6WqCMw?t=00h55m09s)

[kind of a bright obnoxious screen but me](https://youtu.be/UlNwQ6WqCMw?t=00h55m12s)

[this one works for me](https://youtu.be/UlNwQ6WqCMw?t=00h55m15s)

[uh okay so](https://youtu.be/UlNwQ6WqCMw?t=00h55m17s)

[that builds and launches but the](https://youtu.be/UlNwQ6WqCMw?t=00h55m21s)

[published version doesn't so](https://youtu.be/UlNwQ6WqCMw?t=00h55m23s)

[let's go and quickly take a](https://youtu.be/UlNwQ6WqCMw?t=00h55m27s)

[this looks like](https://youtu.be/UlNwQ6WqCMw?t=00h55m31s)

[uh let's take a quick gander here](https://youtu.be/UlNwQ6WqCMw?t=00h55m33s)

[because i want to look at you ah](https://youtu.be/UlNwQ6WqCMw?t=00h55m37s)

[i know why it can't find dependency](https://youtu.be/UlNwQ6WqCMw?t=00h55m41s)

[objections version five](https://youtu.be/UlNwQ6WqCMw?t=00h55m43s)

[because this is version two](https://youtu.be/UlNwQ6WqCMw?t=00h55m45s)

[that'll that'll do it](https://youtu.be/UlNwQ6WqCMw?t=00h55m49s)

[that'll do it](https://youtu.be/UlNwQ6WqCMw?t=00h55m55s)

[um okay](https://youtu.be/UlNwQ6WqCMw?t=00h55m57s)

[let's just do uh](https://youtu.be/UlNwQ6WqCMw?t=00h56m00s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=00h56m01s)

[we might read we might just rev some](https://youtu.be/UlNwQ6WqCMw?t=00h56m05s)

[updates here real quick](https://youtu.be/UlNwQ6WqCMw?t=00h56m07s)

[i'm going to pick up everything that i](https://youtu.be/UlNwQ6WqCMw?t=00h56m09s)

[know is related](https://youtu.be/UlNwQ6WqCMw?t=00h56m11s)

[uh let's see so](https://youtu.be/UlNwQ6WqCMw?t=00h56m17s)

[let's actually include pre-releases and](https://youtu.be/UlNwQ6WqCMw?t=00h56m19s)

[we'll do auto di just so i get latest on](https://youtu.be/UlNwQ6WqCMw?t=00h56m20s)

[it](https://youtu.be/UlNwQ6WqCMw?t=00h56m23s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=00h56m26s)

[so there's nothing major in between](https://youtu.be/UlNwQ6WqCMw?t=00h56m31s)

[those two versions so that should be](https://youtu.be/UlNwQ6WqCMw?t=00h56m33s)

[that should be a fairly safe update](https://youtu.be/UlNwQ6WqCMw?t=00h56m35s)

[i think a lot of it is things like](https://youtu.be/UlNwQ6WqCMw?t=00h56m37s)

[mobile cecil upgrades](https://youtu.be/UlNwQ6WqCMw?t=00h56m39s)

[um we aren't gonna grab](https://youtu.be/UlNwQ6WqCMw?t=00h56m42s)

[cloud squirrel version three as exciting](https://youtu.be/UlNwQ6WqCMw?t=00h56m44s)

[as that would be](https://youtu.be/UlNwQ6WqCMw?t=00h56m46s)

[but i do want to grab](https://youtu.be/UlNwQ6WqCMw?t=00h56m48s)

[this guy here](https://youtu.be/UlNwQ6WqCMw?t=00h56m51s)

[because i am a little interested in how](https://youtu.be/UlNwQ6WqCMw?t=00h56m55s)

[i got version two when the only thing](https://youtu.be/UlNwQ6WqCMw?t=00h56m58s)

[referenced was version five](https://youtu.be/UlNwQ6WqCMw?t=00h57m00s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h57m04s)

[let's come back here](https://youtu.be/UlNwQ6WqCMw?t=00h57m06s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h57m08s)

[under](https://youtu.be/UlNwQ6WqCMw?t=00h57m10s)

[publish](https://youtu.be/UlNwQ6WqCMw?t=00h57m11s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h57m16s)

[build this guy out and make sure that he](https://youtu.be/UlNwQ6WqCMw?t=00h57m24s)

[launches](https://youtu.be/UlNwQ6WqCMw?t=00h57m26s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=00h57m33s)

[come back here](https://youtu.be/UlNwQ6WqCMw?t=00h57m36s)

[publish](https://youtu.be/UlNwQ6WqCMw?t=00h57m38s)

[launch](https://youtu.be/UlNwQ6WqCMw?t=00h57m40s)

[because i am](https://youtu.be/UlNwQ6WqCMw?t=00h57m43s)

[mildly concerned that this thing okay](https://youtu.be/UlNwQ6WqCMw?t=00h57m44s)

[now it launches](https://youtu.be/UlNwQ6WqCMw?t=00h57m47s)

[better](https://youtu.be/UlNwQ6WqCMw?t=00h57m49s)

[better better better okay so now we will](https://youtu.be/UlNwQ6WqCMw?t=00h57m50s)

[do a](https://youtu.be/UlNwQ6WqCMw?t=00h57m52s)

[i'm going to blow away](https://youtu.be/UlNwQ6WqCMw?t=00h57m54s)

[the previous installer](https://youtu.be/UlNwQ6WqCMw?t=00h57m56s)

[just because i'd like to be in a clean](https://youtu.be/UlNwQ6WqCMw?t=00h57m58s)

[clean state to begin with](https://youtu.be/UlNwQ6WqCMw?t=00h58m00s)

[and it should just work](https://youtu.be/UlNwQ6WqCMw?t=00h58m09s)

[that seems to be fine](https://youtu.be/UlNwQ6WqCMw?t=00h58m18s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=00h58m21s)

[run setup](https://youtu.be/UlNwQ6WqCMw?t=00h58m22s)

[cross finger launch app](https://youtu.be/UlNwQ6WqCMw?t=00h58m25s)

[thinking thinking thinking](https://youtu.be/UlNwQ6WqCMw?t=00h58m30s)

[i will note i do have a thing that sets](https://youtu.be/UlNwQ6WqCMw?t=00h58m38s)

[the version number up here but this is](https://youtu.be/UlNwQ6WqCMw?t=00h58m40s)

[based upon the msix stuff so](https://youtu.be/UlNwQ6WqCMw?t=00h58m43s)

[i'm not surprised this is showing local](https://youtu.be/UlNwQ6WqCMw?t=00h58m46s)

[because i think local is its fall back](https://youtu.be/UlNwQ6WqCMw?t=00h58m47s)

[when it's like ah](https://youtu.be/UlNwQ6WqCMw?t=00h58m49s)

[i'm confused](https://youtu.be/UlNwQ6WqCMw?t=00h58m50s)

[so](https://youtu.be/UlNwQ6WqCMw?t=00h58m52s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h58m53s)

[great](https://youtu.be/UlNwQ6WqCMw?t=00h58m55s)

[that looks to be working okay so](https://youtu.be/UlNwQ6WqCMw?t=00h58m59s)

[we've got all that in let's do a](https://youtu.be/UlNwQ6WqCMw?t=00h59m03s)

[get cracking where'd you go](https://youtu.be/UlNwQ6WqCMw?t=00h59m07s)

[you're on a monitor somewhere which](https://youtu.be/UlNwQ6WqCMw?t=00h59m09s)

[monitor you want yeah connect](https://youtu.be/UlNwQ6WqCMw?t=00h59m10s)

[close outlook before it all sudden does](https://youtu.be/UlNwQ6WqCMw?t=00h59m17s)

[something stupid](https://youtu.be/UlNwQ6WqCMw?t=00h59m18s)

[okay so we've got this](https://youtu.be/UlNwQ6WqCMw?t=00h59m20s)

[let's see so solution](https://youtu.be/UlNwQ6WqCMw?t=00h59m22s)

[is there](https://youtu.be/UlNwQ6WqCMw?t=00h59m24s)

[we remove the msix stuff we tune that at](https://youtu.be/UlNwQ6WqCMw?t=00h59m25s)

[manifest](https://youtu.be/UlNwQ6WqCMw?t=00h59m29s)

[that stuff](https://youtu.be/UlNwQ6WqCMw?t=00h59m30s)

[that stuff](https://youtu.be/UlNwQ6WqCMw?t=00h59m32s)

[that stuff that all makes sense okay so](https://youtu.be/UlNwQ6WqCMw?t=00h59m34s)

[we're just going to stage this for now](https://youtu.be/UlNwQ6WqCMw?t=00h59m37s)

[adding in](https://youtu.be/UlNwQ6WqCMw?t=00h59m39s)

[loud](https://youtu.be/UlNwQ6WqCMw?t=00h59m41s)

[squirrel](https://youtu.be/UlNwQ6WqCMw?t=00h59m43s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=00h59m45s)

[watched your presentation on cs projects](https://youtu.be/UlNwQ6WqCMw?t=00h59m47s)

[didn't understand everything but very](https://youtu.be/UlNwQ6WqCMw?t=00h59m49s)

[interesting well thank you justin bieber](https://youtu.be/UlNwQ6WqCMw?t=00h59m50s)

[uh that's clown not cloud](https://youtu.be/UlNwQ6WqCMw?t=00h59m53s)

[let's not do that](https://youtu.be/UlNwQ6WqCMw?t=00h59m55s)

[um](https://youtu.be/UlNwQ6WqCMw?t=00h59m58s)

[always happy to answer questions uh](https://youtu.be/UlNwQ6WqCMw?t=01h00m00s)

[on it it it's one of those presentations](https://youtu.be/UlNwQ6WqCMw?t=01h00m04s)

[i feel like i](https://youtu.be/UlNwQ6WqCMw?t=01h00m07s)

[i honestly rushed it a little](https://youtu.be/UlNwQ6WqCMw?t=01h00m09s)

[uh and i didn't have as much prep time](https://youtu.be/UlNwQ6WqCMw?t=01h00m11s)

[on it i keep wanting to go back and](https://youtu.be/UlNwQ6WqCMw?t=01h00m14s)

[refine it because it is one of those](https://youtu.be/UlNwQ6WqCMw?t=01h00m16s)

[areas](https://youtu.be/UlNwQ6WqCMw?t=01h00m17s)

[of](https://youtu.be/UlNwQ6WqCMw?t=01h00m18s)

[editing cs projects and doing stuff in](https://youtu.be/UlNwQ6WqCMw?t=01h00m19s)

[here is incredibly powerful and i](https://youtu.be/UlNwQ6WqCMw?t=01h00m22s)

[absolutely love it](https://youtu.be/UlNwQ6WqCMw?t=01h00m25s)

[um but it's i also don't think it's one](https://youtu.be/UlNwQ6WqCMw?t=01h00m27s)

[that is well understood so](https://youtu.be/UlNwQ6WqCMw?t=01h00m29s)

[hopefully people found it interesting](https://youtu.be/UlNwQ6WqCMw?t=01h00m31s)

[but thank you for posting the link](https://youtu.be/UlNwQ6WqCMw?t=01h00m34s)

[okay so we got that](https://youtu.be/UlNwQ6WqCMw?t=01h00m36s)

[now what i would like to do is i would](https://youtu.be/UlNwQ6WqCMw?t=01h00m38s)

[like to bring in my](https://youtu.be/UlNwQ6WqCMw?t=01h00m40s)

[github action and i wanted to actually](https://youtu.be/UlNwQ6WqCMw?t=01h00m43s)

[do work for me now](https://youtu.be/UlNwQ6WqCMw?t=01h00m45s)

[so github come here please okay](https://youtu.be/UlNwQ6WqCMw?t=01h00m48s)

[so](https://youtu.be/UlNwQ6WqCMw?t=01h00m52s)

[this is close-ish but not quite](https://youtu.be/UlNwQ6WqCMw?t=01h00m53s)

[right because this will get us](https://youtu.be/UlNwQ6WqCMw?t=01h00m55s)

[this will get us part of the way there](https://youtu.be/UlNwQ6WqCMw?t=01h00m57s)

[let's separate some of this stuff no](https://youtu.be/UlNwQ6WqCMw?t=01h01m00s)

[don't indent don't indent this is yaml](https://youtu.be/UlNwQ6WqCMw?t=01h01m02s)

[you don't randomly indent](https://youtu.be/UlNwQ6WqCMw?t=01h01m04s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h01m06s)

[okay so let's go and look at](https://youtu.be/UlNwQ6WqCMw?t=01h01m08s)

[the one that we created here and let's](https://youtu.be/UlNwQ6WqCMw?t=01h01m11s)

[just add in the yaml file that azure was](https://youtu.be/UlNwQ6WqCMw?t=01h01m14s)

[kind enough to create for us](https://youtu.be/UlNwQ6WqCMw?t=01h01m17s)

[github workflows](https://youtu.be/UlNwQ6WqCMw?t=01h01m19s)

[oh i also don't like the name of it okay](https://youtu.be/UlNwQ6WqCMw?t=01h01m23s)

[so because this thing is going to](https://youtu.be/UlNwQ6WqCMw?t=01h01m25s)

[trigger on a couple stuff](https://youtu.be/UlNwQ6WqCMw?t=01h01m27s)

[uh let's see so this is triggering on](https://youtu.be/UlNwQ6WqCMw?t=01h01m31s)

[pull request two which is good](https://youtu.be/UlNwQ6WqCMw?t=01h01m33s)

[um we're going to add in workflow](https://youtu.be/UlNwQ6WqCMw?t=01h01m36s)

[dispatch](https://youtu.be/UlNwQ6WqCMw?t=01h01m38s)

[because workflow dispatch is is manual](https://youtu.be/UlNwQ6WqCMw?t=01h01m40s)

[trigger so i want a button i can click](https://youtu.be/UlNwQ6WqCMw?t=01h01m43s)

[to to make this guy go](https://youtu.be/UlNwQ6WqCMw?t=01h01m45s)

[let's see branches](https://youtu.be/UlNwQ6WqCMw?t=01h01m47s)

[let's go to the other syntax i kind of](https://youtu.be/UlNwQ6WqCMw?t=01h01m51s)

[like that better](https://youtu.be/UlNwQ6WqCMw?t=01h01m52s)

[that is not even close buddy uh](https://youtu.be/UlNwQ6WqCMw?t=01h02m00s)

[let's see i](https://youtu.be/UlNwQ6WqCMw?t=01h02m04s)

[think it's indented like that nope](https://youtu.be/UlNwQ6WqCMw?t=01h02m05s)

[two more boom](https://youtu.be/UlNwQ6WqCMw?t=01h02m08s)

[boom okay](https://youtu.be/UlNwQ6WqCMw?t=01h02m10s)

[we'll do that](https://youtu.be/UlNwQ6WqCMw?t=01h02m11s)

[this guy's gonna run on a windows agent](https://youtu.be/UlNwQ6WqCMw?t=01h02m13s)

[because it has to](https://youtu.be/UlNwQ6WqCMw?t=01h02m15s)

[um okay so next things](https://youtu.be/UlNwQ6WqCMw?t=01h02m20s)

[if this is pulling down net 5x is this](https://youtu.be/UlNwQ6WqCMw?t=01h02m23s)

[still a five expo](https://youtu.be/UlNwQ6WqCMw?t=01h02m26s)

[but this is net six](https://youtu.be/UlNwQ6WqCMw?t=01h02m27s)

[why are you not on](https://youtu.be/UlNwQ6WqCMw?t=01h02m30s)

[net 60 all the things okay](https://youtu.be/UlNwQ6WqCMw?t=01h02m33s)

[um let's see](https://youtu.be/UlNwQ6WqCMw?t=01h02m35s)

[this one's allowing pre-release i don't](https://youtu.be/UlNwQ6WqCMw?t=01h02m38s)

[think we're gonna do that](https://youtu.be/UlNwQ6WqCMw?t=01h02m40s)

[uh oh and this is doing debug builds oh](https://youtu.be/UlNwQ6WqCMw?t=01h02m44s)

[that's bad](https://youtu.be/UlNwQ6WqCMw?t=01h02m47s)

[whoopsie so clearly i haven't reviewed](https://youtu.be/UlNwQ6WqCMw?t=01h02m49s)

[this one too well](https://youtu.be/UlNwQ6WqCMw?t=01h02m51s)

[uh and then we're going to do](https://youtu.be/UlNwQ6WqCMw?t=01h02m54s)

[i don't know if it's necessary to do the](https://youtu.be/UlNwQ6WqCMw?t=01h02m59s)

[restore and build separately they're](https://youtu.be/UlNwQ6WqCMw?t=01h03m01s)

[they're implicit](https://youtu.be/UlNwQ6WqCMw?t=01h03m02s)

[let's not have a separate step for that](https://youtu.be/UlNwQ6WqCMw?t=01h03m04s)

[there's there's not a lot of overhead in](https://youtu.be/UlNwQ6WqCMw?t=01h03m07s)

[multiple steps](https://youtu.be/UlNwQ6WqCMw?t=01h03m09s)

[just a tiny bit](https://youtu.be/UlNwQ6WqCMw?t=01h03m11s)

[okay and then](https://youtu.be/UlNwQ6WqCMw?t=01h03m13s)

[we're gonna basically want both of these](https://youtu.be/UlNwQ6WqCMw?t=01h03m17s)

[bits here](https://youtu.be/UlNwQ6WqCMw?t=01h03m19s)

[um but we're only gonna we're gonna want](https://youtu.be/UlNwQ6WqCMw?t=01h03m20s)

[to do these conditionally](https://youtu.be/UlNwQ6WqCMw?t=01h03m22s)

[so](https://youtu.be/UlNwQ6WqCMw?t=01h03m23s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=01h03m25s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h03m29s)

[so we only want to do these guys](https://youtu.be/UlNwQ6WqCMw?t=01h03m30s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h03m33s)

[if we aren't a pull request because on](https://youtu.be/UlNwQ6WqCMw?t=01h03m34s)

[pull requests i don't want to be](https://youtu.be/UlNwQ6WqCMw?t=01h03m36s)

[publishing and uploading artifacts and](https://youtu.be/UlNwQ6WqCMw?t=01h03m38s)

[all of that jazz so](https://youtu.be/UlNwQ6WqCMw?t=01h03m40s)

[if uh](https://youtu.be/UlNwQ6WqCMw?t=01h03m42s)

[i don't remember the exact syntax where](https://youtu.be/UlNwQ6WqCMw?t=01h03m44s)

[have i done this before](https://youtu.be/UlNwQ6WqCMw?t=01h03m46s)

[uh this was done on](https://youtu.be/UlNwQ6WqCMw?t=01h03m50s)

[uh auto locker](https://youtu.be/UlNwQ6WqCMw?t=01h03m54s)

[just want your if conditioned](https://youtu.be/UlNwQ6WqCMw?t=01h04m04s)

[uh event name](https://youtu.be/UlNwQ6WqCMw?t=01h04m07s)

[see i could go look it up or i could](https://youtu.be/UlNwQ6WqCMw?t=01h04m08s)

[just remember where i did it before](https://youtu.be/UlNwQ6WqCMw?t=01h04m10s)

[so if event name is not equal to](https://youtu.be/UlNwQ6WqCMw?t=01h04m12s)

[pull request](https://youtu.be/UlNwQ6WqCMw?t=01h04m17s)

[then we'll go ahead and do this bit](https://youtu.be/UlNwQ6WqCMw?t=01h04m21s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h04m27s)

[and then the last thing i want to check](https://youtu.be/UlNwQ6WqCMw?t=01h04m28s)

[was these versions](https://youtu.be/UlNwQ6WqCMw?t=01h04m30s)

[say vaguely recall](https://youtu.be/UlNwQ6WqCMw?t=01h04m32s)

[b2b1 i think there are newer versions of](https://youtu.be/UlNwQ6WqCMw?t=01h04m35s)

[both of these actions](https://youtu.be/UlNwQ6WqCMw?t=01h04m38s)

[let's just double check i](https://youtu.be/UlNwQ6WqCMw?t=01h04m40s)

[at least the setup.net one i'm fairly](https://youtu.be/UlNwQ6WqCMw?t=01h04m44s)

[confident there is so for uh github](https://youtu.be/UlNwQ6WqCMw?t=01h04m45s)

[actions all you have to do to look up](https://youtu.be/UlNwQ6WqCMw?t=01h04m48s)

[the docs for it is you take the name of](https://youtu.be/UlNwQ6WqCMw?t=01h04m50s)

[the action and slap it on the url right](https://youtu.be/UlNwQ6WqCMw?t=01h04m52s)

[after github.com](https://youtu.be/UlNwQ6WqCMw?t=01h04m54s)

[because all github actions are github](https://youtu.be/UlNwQ6WqCMw?t=01h04m56s)

[repositories](https://youtu.be/UlNwQ6WqCMw?t=01h04m59s)

[that are public](https://youtu.be/UlNwQ6WqCMw?t=01h05m01s)

[which is kind of cool](https://youtu.be/UlNwQ6WqCMw?t=01h05m03s)

[okay so check out is that v3 setup.net](https://youtu.be/UlNwQ6WqCMw?t=01h05m05s)

[is at v2 so we're just going to rev](https://youtu.be/UlNwQ6WqCMw?t=01h05m07s)

[those](https://youtu.be/UlNwQ6WqCMw?t=01h05m09s)

[three](https://youtu.be/UlNwQ6WqCMw?t=01h05m10s)

[two](https://youtu.be/UlNwQ6WqCMw?t=01h05m12s)

[bit](https://youtu.be/UlNwQ6WqCMw?t=01h05m14s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h05m15s)

[do that we'll do that we'll do that](https://youtu.be/UlNwQ6WqCMw?t=01h05m18s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=01h05m21s)

[uh okay so the publish is not going to](https://youtu.be/UlNwQ6WqCMw?t=01h05m23s)

[be](https://youtu.be/UlNwQ6WqCMw?t=01h05m26s)

[the end all of this](https://youtu.be/UlNwQ6WqCMw?t=01h05m28s)

[we actually want to do the squirrel](https://youtu.be/UlNwQ6WqCMw?t=01h05m30s)

[stuff so](https://youtu.be/UlNwQ6WqCMw?t=01h05m32s)

[name uh](https://youtu.be/UlNwQ6WqCMw?t=01h05m34s)

[let's do](https://youtu.be/UlNwQ6WqCMw?t=01h05m38s)

[i don't know that's gonna look funny but](https://youtu.be/UlNwQ6WqCMw?t=01h05m42s)

[whatever](https://youtu.be/UlNwQ6WqCMw?t=01h05m44s)

[whatever naming naming can be fixed](https://youtu.be/UlNwQ6WqCMw?t=01h05m45s)

[later boom](https://youtu.be/UlNwQ6WqCMw?t=01h05m47s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=01h05m49s)

[i wonder if there's an easy way for me](https://youtu.be/UlNwQ6WqCMw?t=01h05m55s)

[to do this without](https://youtu.be/UlNwQ6WqCMw?t=01h05m56s)

[let's go back to the docs real quick](https://youtu.be/UlNwQ6WqCMw?t=01h05m58s)

[because in an action i and i may end up](https://youtu.be/UlNwQ6WqCMw?t=01h06m00s)

[writing a](https://youtu.be/UlNwQ6WqCMw?t=01h06m04s)

[a github action for cloud squirrel if i](https://youtu.be/UlNwQ6WqCMw?t=01h06m05s)

[like this because i don't want to have](https://youtu.be/UlNwQ6WqCMw?t=01h06m07s)

[to do](https://youtu.be/UlNwQ6WqCMw?t=01h06m09s)

[this paths look up stuff](https://youtu.be/UlNwQ6WqCMw?t=01h06m10s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h06m16s)

[yeah so this is the old path this is the](https://youtu.be/UlNwQ6WqCMw?t=01h06m25s)

[new path](https://youtu.be/UlNwQ6WqCMw?t=01h06m27s)

[and see i kind of i kind of want](https://youtu.be/UlNwQ6WqCMw?t=01h06m29s)

[something that's going to be a little](https://youtu.be/UlNwQ6WqCMw?t=01h06m31s)

[bit more intelligent and just pull the](https://youtu.be/UlNwQ6WqCMw?t=01h06m31s)

[one based upon the installed version for](https://youtu.be/UlNwQ6WqCMw?t=01h06m33s)

[now we're going to hard code it and i'll](https://youtu.be/UlNwQ6WqCMw?t=01h06m35s)

[just hard code the version but i i do](https://youtu.be/UlNwQ6WqCMw?t=01h06m37s)

[not like this hard-coded version because](https://youtu.be/UlNwQ6WqCMw?t=01h06m39s)

[that means as soon as i rev the nougat](https://youtu.be/UlNwQ6WqCMw?t=01h06m41s)

[package i break](https://youtu.be/UlNwQ6WqCMw?t=01h06m42s)

[and that just feels yucky to me i want](https://youtu.be/UlNwQ6WqCMw?t=01h06m44s)

[it to not feel yucky](https://youtu.be/UlNwQ6WqCMw?t=01h06m46s)

[and this feels a little yucky-ish](https://youtu.be/UlNwQ6WqCMw?t=01h06m48s)

[uh okay so boom](https://youtu.be/UlNwQ6WqCMw?t=01h06m51s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=01h06m54s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h07m01s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=01h07m02s)

[let's see tools and then this we can](https://youtu.be/UlNwQ6WqCMw?t=01h07m06s)

[just do](https://youtu.be/UlNwQ6WqCMw?t=01h07m08s)

[roll.exe and then we kind of want all of](https://youtu.be/UlNwQ6WqCMw?t=01h07m10s)

[my options that i passed here](https://youtu.be/UlNwQ6WqCMw?t=01h07m12s)

[so i kind of just want to grab all this](https://youtu.be/UlNwQ6WqCMw?t=01h07m15s)

[stuff](https://youtu.be/UlNwQ6WqCMw?t=01h07m18s)

[let's grab all that and](https://youtu.be/UlNwQ6WqCMw?t=01h07m20s)

[it's a big longer glue line](https://youtu.be/UlNwQ6WqCMw?t=01h07m24s)

[and we're going with it for now uh hold](https://youtu.be/UlNwQ6WqCMw?t=01h07m26s)

[on.net publish](https://youtu.be/UlNwQ6WqCMw?t=01h07m28s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h07m30s)

[env.net root i don't want this](https://youtu.be/UlNwQ6WqCMw?t=01h07m32s)

[uh we're gonna change this to be](https://youtu.be/UlNwQ6WqCMw?t=01h07m36s)

[publish to match what we did locally](https://youtu.be/UlNwQ6WqCMw?t=01h07m42s)

[right and we're gonna it bothers me that](https://youtu.be/UlNwQ6WqCMw?t=01h07m45s)

[these two things are not](https://youtu.be/UlNwQ6WqCMw?t=01h07m47s)

[using the same switch](https://youtu.be/UlNwQ6WqCMw?t=01h07m50s)

[uh okay so](https://youtu.be/UlNwQ6WqCMw?t=01h07m52s)

[scroll.exe pack](https://youtu.be/UlNwQ6WqCMw?t=01h07m54s)

[framework netsix](https://youtu.be/UlNwQ6WqCMw?t=01h07m56s)

[we will need to specify a version number](https://youtu.be/UlNwQ6WqCMw?t=01h08m00s)

[but that's going to come a little later](https://youtu.be/UlNwQ6WqCMw?t=01h08m03s)

[too because i want](https://youtu.be/UlNwQ6WqCMw?t=01h08m04s)

[ultimately what's going to happen is](https://youtu.be/UlNwQ6WqCMw?t=01h08m06s)

[some of this stuff is going to trigger](https://youtu.be/UlNwQ6WqCMw?t=01h08m09s)

[on a release](https://youtu.be/UlNwQ6WqCMw?t=01h08m11s)

[and this needs to be for two](https://youtu.be/UlNwQ6WqCMw?t=01h08m12s)

[nope two](https://youtu.be/UlNwQ6WqCMw?t=01h08m19s)

[uh so we need to get the version number](https://youtu.be/UlNwQ6WqCMw?t=01h08m22s)

[in there](https://youtu.be/UlNwQ6WqCMw?t=01h08m24s)

[all that goes in there all of that goes](https://youtu.be/UlNwQ6WqCMw?t=01h08m28s)

[in there okay](https://youtu.be/UlNwQ6WqCMw?t=01h08m29s)

[i think that's fine](https://youtu.be/UlNwQ6WqCMw?t=01h08m31s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h08m34s)

[okay so upload artifacts this is going](https://youtu.be/UlNwQ6WqCMw?t=01h08m35s)

[to be](https://youtu.be/UlNwQ6WqCMw?t=01h08m38s)

[we should look does this guy have a](https://youtu.be/UlNwQ6WqCMw?t=01h08m39s)

[an output directory i'd really like an](https://youtu.be/UlNwQ6WqCMw?t=01h08m43s)

[output directory to be specified](https://youtu.be/UlNwQ6WqCMw?t=01h08m45s)

[uh because we were using the pac command](https://youtu.be/UlNwQ6WqCMw?t=01h08m49s)

[release directory](https://youtu.be/UlNwQ6WqCMw?t=01h08m51s)

[output directory for releasified](https://youtu.be/UlNwQ6WqCMw?t=01h08m52s)

[packages that looks like exactly what i](https://youtu.be/UlNwQ6WqCMw?t=01h08m54s)

[want thank you](https://youtu.be/UlNwQ6WqCMw?t=01h08m56s)

[i don't mind it being called releases i](https://youtu.be/UlNwQ6WqCMw?t=01h08m59s)

[just want to be explicit about it so](https://youtu.be/UlNwQ6WqCMw?t=01h09m01s)

[that i don't get bit later when it](https://youtu.be/UlNwQ6WqCMw?t=01h09m02s)

[uh we'll call it release](https://youtu.be/UlNwQ6WqCMw?t=01h09m08s)

[okay so we're gonna have this be](https://youtu.be/UlNwQ6WqCMw?t=01h09m12s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h09m18s)

[boy okay i'm doing this about as hard as](https://youtu.be/UlNwQ6WqCMw?t=01h09m22s)

[i can possibly make it](https://youtu.be/UlNwQ6WqCMw?t=01h09m24s)

[uh let's see um](https://youtu.be/UlNwQ6WqCMw?t=01h09m26s)

[what we call this](https://youtu.be/UlNwQ6WqCMw?t=01h09m29s)

[installer](https://youtu.be/UlNwQ6WqCMw?t=01h09m31s)

[okay so this i think works](https://youtu.be/UlNwQ6WqCMw?t=01h09m32s)

[i think works](https://youtu.be/UlNwQ6WqCMw?t=01h09m36s)

[uh we're going to try it](https://youtu.be/UlNwQ6WqCMw?t=01h09m38s)

[let's see here uh what do we got here so](https://youtu.be/UlNwQ6WqCMw?t=01h09m42s)

[there's that there's that](https://youtu.be/UlNwQ6WqCMw?t=01h09m44s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h09m46s)

[nougats](https://youtu.be/UlNwQ6WqCMw?t=01h09m50s)

[updating](https://youtu.be/UlNwQ6WqCMw?t=01h09m52s)

[action okay](https://youtu.be/UlNwQ6WqCMw?t=01h09m53s)

[uh how will you update the version](https://youtu.be/UlNwQ6WqCMw?t=01h09m56s)

[number dynamically without changing the](https://youtu.be/UlNwQ6WqCMw?t=01h09m58s)

[action every time since hard coded](https://youtu.be/UlNwQ6WqCMw?t=01h10m00s)

[currently](https://youtu.be/UlNwQ6WqCMw?t=01h10m01s)

[so my plan is so i one i'm leaving it](https://youtu.be/UlNwQ6WqCMw?t=01h10m02s)

[hard-coded just to make sure everything](https://youtu.be/UlNwQ6WqCMw?t=01h10m05s)

[works but the the hard-coded 1.0 is is](https://youtu.be/UlNwQ6WqCMw?t=01h10m07s)

[going to definitely change](https://youtu.be/UlNwQ6WqCMw?t=01h10m09s)

[what i think and again emphasis on think](https://youtu.be/UlNwQ6WqCMw?t=01h10m11s)

[because i've gone round and round with](https://youtu.be/UlNwQ6WqCMw?t=01h10m14s)

[myself on](https://youtu.be/UlNwQ6WqCMw?t=01h10m16s)

[how i like to](https://youtu.be/UlNwQ6WqCMw?t=01h10m18s)

[run builds and do release versioning](https://youtu.be/UlNwQ6WqCMw?t=01h10m20s)

[numbers because version numbers are kind](https://youtu.be/UlNwQ6WqCMw?t=01h10m23s)

[of like naming things it's really hard](https://youtu.be/UlNwQ6WqCMw?t=01h10m25s)

[i think what i would like to try on](https://youtu.be/UlNwQ6WqCMw?t=01h10m28s)

[this particular repository](https://youtu.be/UlNwQ6WqCMw?t=01h10m31s)

[is](https://youtu.be/UlNwQ6WqCMw?t=01h10m33s)

[what i would like to do is come in here](https://youtu.be/UlNwQ6WqCMw?t=01h10m34s)

[create a release](https://youtu.be/UlNwQ6WqCMw?t=01h10m37s)

[and](https://youtu.be/UlNwQ6WqCMw?t=01h10m40s)

[grab the tag from that release](https://youtu.be/UlNwQ6WqCMw?t=01h10m40s)

[and i think just by convention what i'm](https://youtu.be/UlNwQ6WqCMw?t=01h10m43s)

[going to do is for example if my tag is](https://youtu.be/UlNwQ6WqCMw?t=01h10m46s)

[1.0.1](https://youtu.be/UlNwQ6WqCMw?t=01h10m48s)

[i want](https://youtu.be/UlNwQ6WqCMw?t=01h10m51s)

[the github action to grab the name of](https://youtu.be/UlNwQ6WqCMw?t=01h10m52s)

[the tag that triggered that that that](https://youtu.be/UlNwQ6WqCMw?t=01h10m54s)

[came from this release](https://youtu.be/UlNwQ6WqCMw?t=01h10m57s)

[and use that for the version number](https://youtu.be/UlNwQ6WqCMw?t=01h10m59s)

[i think that's what i think i want i'm](https://youtu.be/UlNwQ6WqCMw?t=01h11m02s)

[not a hundred percent confident](https://youtu.be/UlNwQ6WqCMw?t=01h11m05s)

[i've also considered things where i i](https://youtu.be/UlNwQ6WqCMw?t=01h11m07s)

[just reach into the assembly and pull](https://youtu.be/UlNwQ6WqCMw?t=01h11m09s)

[the version number out but i'm like](https://youtu.be/UlNwQ6WqCMw?t=01h11m11s)

[rumble](https://youtu.be/UlNwQ6WqCMw?t=01h11m14s)

[so i think that's what i want because i](https://youtu.be/UlNwQ6WqCMw?t=01h11m15s)

[don't want this thing necessarily](https://youtu.be/UlNwQ6WqCMw?t=01h11m17s)

[publishing releases willy nilly](https://youtu.be/UlNwQ6WqCMw?t=01h11m18s)

[because i don't really i don't have the](https://youtu.be/UlNwQ6WqCMw?t=01h11m23s)

[concept of like multiple channels that's](https://youtu.be/UlNwQ6WqCMw?t=01h11m25s)

[another reason why i want to put in this](https://youtu.be/UlNwQ6WqCMw?t=01h11m27s)

[web api in the middle is it gives me the](https://youtu.be/UlNwQ6WqCMw?t=01h11m29s)

[ability if i want to have like a beta](https://youtu.be/UlNwQ6WqCMw?t=01h11m31s)

[channel and a release channel i can](https://youtu.be/UlNwQ6WqCMw?t=01h11m33s)

[start to build out that logic if i've](https://youtu.be/UlNwQ6WqCMw?t=01h11m36s)

[got my own service sitting in the middle](https://youtu.be/UlNwQ6WqCMw?t=01h11m37s)

[if i just point at github i can't do](https://youtu.be/UlNwQ6WqCMw?t=01h11m39s)

[that](https://youtu.be/UlNwQ6WqCMw?t=01h11m41s)

[so i kind of](https://youtu.be/UlNwQ6WqCMw?t=01h11m41s)

[in the back of my mind i'm thinking of](https://youtu.be/UlNwQ6WqCMw?t=01h11m43s)

[that long term but i think this is where](https://youtu.be/UlNwQ6WqCMw?t=01h11m45s)

[i want to go is the workflow i think i](https://youtu.be/UlNwQ6WqCMw?t=01h11m47s)

[want is i want to type in you know my](https://youtu.be/UlNwQ6WqCMw?t=01h11m50s)

[release number some notes](https://youtu.be/UlNwQ6WqCMw?t=01h11m52s)

[and i want my github action to pick up](https://youtu.be/UlNwQ6WqCMw?t=01h11m55s)

[the tag from the release](https://youtu.be/UlNwQ6WqCMw?t=01h11m58s)

[which does mean likely a second action](https://youtu.be/UlNwQ6WqCMw?t=01h12m00s)

[so a second action that triggers on](https://youtu.be/UlNwQ6WqCMw?t=01h12m03s)

[release creation](https://youtu.be/UlNwQ6WqCMw?t=01h12m05s)

[pulls this grabs the artifacts does the](https://youtu.be/UlNwQ6WqCMw?t=01h12m06s)

[publish away we go](https://youtu.be/UlNwQ6WqCMw?t=01h12m08s)

[i think that's what i want](https://youtu.be/UlNwQ6WqCMw?t=01h12m10s)

[not a 100 confident](https://youtu.be/UlNwQ6WqCMw?t=01h12m13s)

[and apparently we're fail](https://youtu.be/UlNwQ6WqCMw?t=01h12m16s)

[so trigger on release yeah that's what i](https://youtu.be/UlNwQ6WqCMw?t=01h12m19s)

[that's what i think i want](https://youtu.be/UlNwQ6WqCMw?t=01h12m21s)

[okay and apparently i can't build](https://youtu.be/UlNwQ6WqCMw?t=01h12m23s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h12m27s)

[oh right because i left in the no](https://youtu.be/UlNwQ6WqCMw?t=01h12m31s)

[restore and then i got rid of the](https://youtu.be/UlNwQ6WqCMw?t=01h12m33s)

[restore target so that will not work](https://youtu.be/UlNwQ6WqCMw?t=01h12m34s)

[if you get rid of the net restore](https://youtu.be/UlNwQ6WqCMw?t=01h12m38s)

[dotnet build does not work](https://youtu.be/UlNwQ6WqCMw?t=01h12m42s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h12m44s)

[stage all uh because i'm pretty](https://youtu.be/UlNwQ6WqCMw?t=01h12m47s)

[confident nobody forked my repo in the](https://youtu.be/UlNwQ6WqCMw?t=01h12m49s)

[last 30 seconds force push](https://youtu.be/UlNwQ6WqCMw?t=01h12m50s)

[i saw no mistake what mistake](https://youtu.be/UlNwQ6WqCMw?t=01h12m53s)

[it's not there it's gone](https://youtu.be/UlNwQ6WqCMw?t=01h12m56s)

[okay back here back to actions](https://youtu.be/UlNwQ6WqCMw?t=01h13m01s)

[first mountain dew it's almost gone](https://youtu.be/UlNwQ6WqCMw?t=01h13m09s)

[don't worry another one](https://youtu.be/UlNwQ6WqCMw?t=01h13m11s)

[so i probably shouldn't go too terribly](https://youtu.be/UlNwQ6WqCMw?t=01h13m15s)

[late tonight i have to be](https://youtu.be/UlNwQ6WqCMw?t=01h13m17s)

[up somewhat uh earlier than normal](https://youtu.be/UlNwQ6WqCMw?t=01h13m20s)

[tomorrow](https://youtu.be/UlNwQ6WqCMw?t=01h13m22s)

[my son has a](https://youtu.be/UlNwQ6WqCMw?t=01h13m23s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h13m26s)

[i want to say doctor's appointment he](https://youtu.be/UlNwQ6WqCMw?t=01h13m28s)

[has a medical procedure that is going to](https://youtu.be/UlNwQ6WqCMw?t=01h13m29s)

[keep me at the hospital for about 24](https://youtu.be/UlNwQ6WqCMw?t=01h13m32s)

[hours which is](https://youtu.be/UlNwQ6WqCMw?t=01h13m34s)

[to be a long 24 hours](https://youtu.be/UlNwQ6WqCMw?t=01h13m35s)

[because the doctors and nurses they do a](https://youtu.be/UlNwQ6WqCMw?t=01h13m38s)

[great job taking care of the patient](https://youtu.be/UlNwQ6WqCMw?t=01h13m40s)

[myself](https://youtu.be/UlNwQ6WqCMw?t=01h13m42s)

[the](https://youtu.be/UlNwQ6WqCMw?t=01h13m43s)

[the the adult in the room uh gets no](https://youtu.be/UlNwQ6WqCMw?t=01h13m44s)

[help and i will be sleeping on a](https://youtu.be/UlNwQ6WqCMw?t=01h13m48s)

[very hard couch that is built for](https://youtu.be/UlNwQ6WqCMw?t=01h13m51s)

[somebody about 12 inches short of me](https://youtu.be/UlNwQ6WqCMw?t=01h13m53s)

[so i i kind of suspect that by](https://youtu.be/UlNwQ6WqCMw?t=01h13m57s)

[the the following morning i am going to](https://youtu.be/UlNwQ6WqCMw?t=01h14m00s)

[be somewhat exhausted very stiff and](https://youtu.be/UlNwQ6WqCMw?t=01h14m02s)

[sore and will be coming home and taking](https://youtu.be/UlNwQ6WqCMw?t=01h14m04s)

[a nap](https://youtu.be/UlNwQ6WqCMw?t=01h14m06s)

[it's my theory](https://youtu.be/UlNwQ6WqCMw?t=01h14m07s)

[but i might get some coding time in](https://youtu.be/UlNwQ6WqCMw?t=01h14m11s)

[we'll see](https://youtu.be/UlNwQ6WqCMw?t=01h14m13s)

[the internet at the hospital is horrible](https://youtu.be/UlNwQ6WqCMw?t=01h14m15s)

[the office tomorrow will be too quiet](https://youtu.be/UlNwQ6WqCMw?t=01h14m18s)

[i'm not sure how to take that jared does](https://youtu.be/UlNwQ6WqCMw?t=01h14m20s)

[that mean i'm the loud one in the office](https://youtu.be/UlNwQ6WqCMw?t=01h14m22s)

[i feel like that means i'm the loud one](https://youtu.be/UlNwQ6WqCMw?t=01h14m25s)

[in the office](https://youtu.be/UlNwQ6WqCMw?t=01h14m27s)

[maybe that's why they put me in the](https://youtu.be/UlNwQ6WqCMw?t=01h14m29s)

[basement](https://youtu.be/UlNwQ6WqCMw?t=01h14m30s)

[okay come on](https://youtu.be/UlNwQ6WqCMw?t=01h14m35s)

[please work i would really like to see](https://youtu.be/UlNwQ6WqCMw?t=01h14m38s)

[this work](https://youtu.be/UlNwQ6WqCMw?t=01h14m39s)

[out the gate](https://youtu.be/UlNwQ6WqCMw?t=01h14m42s)

[i think that's i i think that's what i](https://youtu.be/UlNwQ6WqCMw?t=01h14m46s)

[want at least](https://youtu.be/UlNwQ6WqCMw?t=01h14m48s)

[i probably could have turned off testing](https://youtu.be/UlNwQ6WqCMw?t=01h14m54s)

[for this while this guy's chugging okay](https://youtu.be/UlNwQ6WqCMw?t=01h14m56s)

[while that's building](https://youtu.be/UlNwQ6WqCMw?t=01h14m58s)

[let's go back here and think about what](https://youtu.be/UlNwQ6WqCMw?t=01h15m00s)

[this this guy here actually needs to](https://youtu.be/UlNwQ6WqCMw?t=01h15m02s)

[look like](https://youtu.be/UlNwQ6WqCMw?t=01h15m04s)

[so in terms of this](https://youtu.be/UlNwQ6WqCMw?t=01h15m05s)

[no means i am because i'm always bugging](https://youtu.be/UlNwQ6WqCMw?t=01h15m08s)

[you](https://youtu.be/UlNwQ6WqCMw?t=01h15m10s)

[bugging me](https://youtu.be/UlNwQ6WqCMw?t=01h15m12s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=01h15m14s)

[i'm i'm thinking about what](https://youtu.be/UlNwQ6WqCMw?t=01h15m17s)

[what i want this this web api to](https://youtu.be/UlNwQ6WqCMw?t=01h15m20s)

[actually look like so](https://youtu.be/UlNwQ6WqCMw?t=01h15m22s)

[when uh squirrel or cloud squirrel](https://youtu.be/UlNwQ6WqCMw?t=01h15m24s)

[does the update check the first thing it](https://youtu.be/UlNwQ6WqCMw?t=01h15m28s)

[does is it calls out](https://youtu.be/UlNwQ6WqCMw?t=01h15m30s)

[and if we go back and look](https://youtu.be/UlNwQ6WqCMw?t=01h15m32s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h15m36s)

[where was their update check this so](https://youtu.be/UlNwQ6WqCMw?t=01h15m38s)

[place you host updates](https://youtu.be/UlNwQ6WqCMw?t=01h15m41s)

[and what it's going to do is it's going](https://youtu.be/UlNwQ6WqCMw?t=01h15m44s)

[to use this as the uh base url](https://youtu.be/UlNwQ6WqCMw?t=01h15m46s)

[effectively and then look for slash](https://youtu.be/UlNwQ6WqCMw?t=01h15m49s)

[releases so that releases file that was](https://youtu.be/UlNwQ6WqCMw?t=01h15m51s)

[generated here it expects to be able to](https://youtu.be/UlNwQ6WqCMw?t=01h15m54s)

[retrieve it with a simple get](https://youtu.be/UlNwQ6WqCMw?t=01h15m56s)

[so](https://youtu.be/UlNwQ6WqCMw?t=01h15m59s)

[and my thought though is i don't want](https://youtu.be/UlNwQ6WqCMw?t=01h16m00s)

[this web service to be specific to one](https://youtu.be/UlNwQ6WqCMw?t=01h16m02s)

[app i want to use this for all of my](https://youtu.be/UlNwQ6WqCMw?t=01h16m05s)

[apps like i want to build this service](https://youtu.be/UlNwQ6WqCMw?t=01h16m08s)

[once](https://youtu.be/UlNwQ6WqCMw?t=01h16m10s)

[and be done](https://youtu.be/UlNwQ6WqCMw?t=01h16m11s)

[so i'm thinking what i want to do](https://youtu.be/UlNwQ6WqCMw?t=01h16m13s)

[is i'm thinking i want you know](https://youtu.be/UlNwQ6WqCMw?t=01h16m16s)

[post slash](https://youtu.be/UlNwQ6WqCMw?t=01h16m18s)

[app name](https://youtu.be/UlNwQ6WqCMw?t=01h16m21s)

[i think so in this case it'll be](https://youtu.be/UlNwQ6WqCMw?t=01h16m22s)

[you know so host will be you know](https://youtu.be/UlNwQ6WqCMw?t=01h16m24s)

[whatever you let's do this we'll make it](https://youtu.be/UlNwQ6WqCMw?t=01h16m26s)

[more obvious dns host right so dns host](https://youtu.be/UlNwQ6WqCMw?t=01h16m28s)

[so this is going to be whatever dns name](https://youtu.be/UlNwQ6WqCMw?t=01h16m32s)

[i wrap behind this but for now it'll be](https://youtu.be/UlNwQ6WqCMw?t=01h16m34s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h16m36s)

[uh screwday](https://youtu.be/UlNwQ6WqCMw?t=01h16m37s)

[dot azurewebsites.net or whatever slash](https://youtu.be/UlNwQ6WqCMw?t=01h16m39s)

[and then i think we're gonna do](https://youtu.be/UlNwQ6WqCMw?t=01h16m42s)

[app name](https://youtu.be/UlNwQ6WqCMw?t=01h16m43s)

[and then i think what i want to do is](https://youtu.be/UlNwQ6WqCMw?t=01h16m45s)

[put](https://youtu.be/UlNwQ6WqCMw?t=01h16m50s)

[that](https://youtu.be/UlNwQ6WqCMw?t=01h16m51s)

[as a route](https://youtu.be/UlNwQ6WqCMw?t=01h16m52s)

[and ultimately i i think for now what i](https://youtu.be/UlNwQ6WqCMw?t=01h16m56s)

[may do is i may just 302 the call](https://youtu.be/UlNwQ6WqCMw?t=01h16m58s)

[over to github](https://youtu.be/UlNwQ6WqCMw?t=01h17m01s)

[so this thing is going to need to](https://youtu.be/UlNwQ6WqCMw?t=01h17m03s)

[maintain some mapping between app names](https://youtu.be/UlNwQ6WqCMw?t=01h17m04s)

[and where the stuff lives again](https://youtu.be/UlNwQ6WqCMw?t=01h17m08s)

[if i want to change that like i start](https://youtu.be/UlNwQ6WqCMw?t=01h17m10s)

[storing stuff in a storage account or](https://youtu.be/UlNwQ6WqCMw?t=01h17m12s)

[similar i can do that behind the scenes](https://youtu.be/UlNwQ6WqCMw?t=01h17m14s)

[that's great](https://youtu.be/UlNwQ6WqCMw?t=01h17m16s)

[but the end points have to look](https://youtu.be/UlNwQ6WqCMw?t=01h17m17s)

[something something like this the](https://youtu.be/UlNwQ6WqCMw?t=01h17m19s)

[following thing that's going to happen](https://youtu.be/UlNwQ6WqCMw?t=01h17m21s)

[is after it downloads this releases is](https://youtu.be/UlNwQ6WqCMw?t=01h17m23s)

[if it's decides that it wants to go and](https://youtu.be/UlNwQ6WqCMw?t=01h17m25s)

[download packages](https://youtu.be/UlNwQ6WqCMw?t=01h17m28s)

[it's going to then call back once again](https://youtu.be/UlNwQ6WqCMw?t=01h17m30s)

[using that base hostname](https://youtu.be/UlNwQ6WqCMw?t=01h17m32s)

[looking for the items in this releases](https://youtu.be/UlNwQ6WqCMw?t=01h17m35s)

[file](https://youtu.be/UlNwQ6WqCMw?t=01h17m37s)

[so it'll be you know hunting for this](https://youtu.be/UlNwQ6WqCMw?t=01h17m38s)

[type of thing](https://youtu.be/UlNwQ6WqCMw?t=01h17m40s)

[are your app names generally the same as](https://youtu.be/UlNwQ6WqCMw?t=01h17m42s)

[your repo naming as that might make the](https://youtu.be/UlNwQ6WqCMw?t=01h17m44s)

[mapping simpler](https://youtu.be/UlNwQ6WqCMw?t=01h17m46s)

[that's a good question](https://youtu.be/UlNwQ6WqCMw?t=01h17m48s)

[they](https://youtu.be/UlNwQ6WqCMw?t=01h17m51s)

[i don't think they're exact](https://youtu.be/UlNwQ6WqCMw?t=01h17m52s)

[in this case they are](https://youtu.be/UlNwQ6WqCMw?t=01h17m55s)

[but i don't know if i i don't know if i](https://youtu.be/UlNwQ6WqCMw?t=01h18m01s)

[actually want to put that as a](https://youtu.be/UlNwQ6WqCMw?t=01h18m03s)

[requirement i think i like the idea of](https://youtu.be/UlNwQ6WqCMw?t=01h18m05s)

[just maintaining a map and i might go as](https://youtu.be/UlNwQ6WqCMw?t=01h18m07s)

[far](https://youtu.be/UlNwQ6WqCMw?t=01h18m10s)

[as to just hard code the map for now it](https://youtu.be/UlNwQ6WqCMw?t=01h18m11s)

[should be data driven at some point](https://youtu.be/UlNwQ6WqCMw?t=01h18m13s)

[because i'd like to be able to add a new](https://youtu.be/UlNwQ6WqCMw?t=01h18m15s)

[app without having to redeploy this](https://youtu.be/UlNwQ6WqCMw?t=01h18m18s)

[service](https://youtu.be/UlNwQ6WqCMw?t=01h18m19s)

[but it's not but for now it's not the](https://youtu.be/UlNwQ6WqCMw?t=01h18m22s)

[end of the world if i legitimately just](https://youtu.be/UlNwQ6WqCMw?t=01h18m24s)

[do that](https://youtu.be/UlNwQ6WqCMw?t=01h18m27s)

[link between](https://youtu.be/UlNwQ6WqCMw?t=01h18m29s)

[the other thing that's going to get a](https://youtu.be/UlNwQ6WqCMw?t=01h18m31s)

[little weird](https://youtu.be/UlNwQ6WqCMw?t=01h18m32s)

[so](https://youtu.be/UlNwQ6WqCMw?t=01h18m34s)

[we're also going to need something along](https://youtu.be/UlNwQ6WqCMw?t=01h18m36s)

[the lines of](https://youtu.be/UlNwQ6WqCMw?t=01h18m38s)

[file](https://youtu.be/UlNwQ6WqCMw?t=01h18m40s)

[right](https://youtu.be/UlNwQ6WqCMw?t=01h18m42s)

[that's going to be a thing](https://youtu.be/UlNwQ6WqCMw?t=01h18m43s)

[and i'm trying to decide if i want to do](https://youtu.be/UlNwQ6WqCMw?t=01h18m45s)

[anything different because this one is](https://youtu.be/UlNwQ6WqCMw?t=01h18m48s)

[going to get real generic real fast and](https://youtu.be/UlNwQ6WqCMw?t=01h18m50s)

[i'm a little scared](https://youtu.be/UlNwQ6WqCMw?t=01h18m53s)

[i i almost want to do something like](https://youtu.be/UlNwQ6WqCMw?t=01h18m56s)

[just prefix it with something](https://youtu.be/UlNwQ6WqCMw?t=01h19m02s)

[just because i suspect i'm gonna want to](https://youtu.be/UlNwQ6WqCMw?t=01h19m06s)

[put other things on the service and i'm](https://youtu.be/UlNwQ6WqCMw?t=01h19m08s)

[a little worried about having a route](https://youtu.be/UlNwQ6WqCMw?t=01h19m11s)

[that's just](https://youtu.be/UlNwQ6WqCMw?t=01h19m13s)

[two variables because that's gonna match](https://youtu.be/UlNwQ6WqCMw?t=01h19m14s)

[it like everything and that's gonna suck](https://youtu.be/UlNwQ6WqCMw?t=01h19m16s)

[so i almost like something like this](https://youtu.be/UlNwQ6WqCMw?t=01h19m22s)

[i'm not sure installer is the right name](https://youtu.be/UlNwQ6WqCMw?t=01h19m26s)

[i don't really want to call it squirrel](https://youtu.be/UlNwQ6WqCMw?t=01h19m29s)

[but maybe it actually makes sense to](https://youtu.be/UlNwQ6WqCMw?t=01h19m31s)

[call it squirrel because this is very](https://youtu.be/UlNwQ6WqCMw?t=01h19m32s)

[much tied to squirrel](https://youtu.be/UlNwQ6WqCMw?t=01h19m34s)

[whether it be squirrel windows or cloud](https://youtu.be/UlNwQ6WqCMw?t=01h19m38s)

[squad maybe we maybe we'll call it](https://youtu.be/UlNwQ6WqCMw?t=01h19m39s)

[squirrel i mean we've already called the](https://youtu.be/UlNwQ6WqCMw?t=01h19m41s)

[the service uh skir a day so i mean](https://youtu.be/UlNwQ6WqCMw?t=01h19m43s)

[having having having a squirrel](https://youtu.be/UlNwQ6WqCMw?t=01h19m48s)

[controller doesn't seem bad](https://youtu.be/UlNwQ6WqCMw?t=01h19m50s)

[okay so i think i want that end point](https://youtu.be/UlNwQ6WqCMw?t=01h19m53s)

[let me go back and check my action](https://youtu.be/UlNwQ6WqCMw?t=01h19m56s)

[oh boo](https://youtu.be/UlNwQ6WqCMw?t=01h19m59s)

[dot net test failed](https://youtu.be/UlNwQ6WqCMw?t=01h20m03s)

[okay so here's how here's how we fix](https://youtu.be/UlNwQ6WqCMw?t=01h20m07s)

[this one](https://youtu.be/UlNwQ6WqCMw?t=01h20m09s)

[okay problem solved](https://youtu.be/UlNwQ6WqCMw?t=01h20m12s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h20m14s)

[tests](https://youtu.be/UlNwQ6WqCMw?t=01h20m18s)

[or not because right now i just want to](https://youtu.be/UlNwQ6WqCMw?t=01h20m20s)

[see the](https://youtu.be/UlNwQ6WqCMw?t=01h20m22s)

[i just want to get the ci cd working](https://youtu.be/UlNwQ6WqCMw?t=01h20m23s)

[we'll get around to test later](https://youtu.be/UlNwQ6WqCMw?t=01h20m27s)

[i do want to figure out why they failed](https://youtu.be/UlNwQ6WqCMw?t=01h20m30s)

[oh i can guarantee i know why they](https://youtu.be/UlNwQ6WqCMw?t=01h20m32s)

[failed](https://youtu.be/UlNwQ6WqCMw?t=01h20m34s)

[because i did a no build](https://youtu.be/UlNwQ6WqCMw?t=01h20m37s)

[and did not specify a configuration](https://youtu.be/UlNwQ6WqCMw?t=01h20m39s)

[therefore they will end up](https://youtu.be/UlNwQ6WqCMw?t=01h20m42s)

[trying to use debug which is not this](https://youtu.be/UlNwQ6WqCMw?t=01h20m44s)

[debug is not equal to release](https://youtu.be/UlNwQ6WqCMw?t=01h20m46s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h20m50s)

[ah we'll check that in next](https://youtu.be/UlNwQ6WqCMw?t=01h20m55s)

[let the other one go for now](https://youtu.be/UlNwQ6WqCMw?t=01h20m57s)

[uh okay so back to](https://youtu.be/UlNwQ6WqCMw?t=01h20m59s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=01h21m01s)

[let's cue you back onto the other one](https://youtu.be/UlNwQ6WqCMw?t=01h21m02s)

[boom okay so if we go with something](https://youtu.be/UlNwQ6WqCMw?t=01h21m05s)

[like this](https://youtu.be/UlNwQ6WqCMw?t=01h21m08s)

[let's build let's build me a controller](https://youtu.be/UlNwQ6WqCMw?t=01h21m11s)

[public class uh](https://youtu.be/UlNwQ6WqCMw?t=01h21m14s)

[controller](https://youtu.be/UlNwQ6WqCMw?t=01h21m20s)

[okay we're gonna do this](https://youtu.be/UlNwQ6WqCMw?t=01h21m25s)

[and so the route name](https://youtu.be/UlNwQ6WqCMw?t=01h21m31s)

[this um is just going to grab the first](https://youtu.be/UlNwQ6WqCMw?t=01h21m33s)

[part of the class name and omit the](https://youtu.be/UlNwQ6WqCMw?t=01h21m36s)

[controller suffix so this will](https://youtu.be/UlNwQ6WqCMw?t=01h21m37s)

[effectively give me that bit](https://youtu.be/UlNwQ6WqCMw?t=01h21m39s)

[and i think](https://youtu.be/UlNwQ6WqCMw?t=01h21m42s)

[trying to remember how to get away with](https://youtu.be/UlNwQ6WqCMw?t=01h21m46s)

[this](https://youtu.be/UlNwQ6WqCMw?t=01h21m48s)

[no coalesce uh](https://youtu.be/UlNwQ6WqCMw?t=01h21m49s)

[no](https://youtu.be/UlNwQ6WqCMw?t=01h21m52s)

[so for people who may not know](https://youtu.be/UlNwQ6WqCMw?t=01h21m54s)

[what jared is so eloquently referring to](https://youtu.be/UlNwQ6WqCMw?t=01h21m57s)

[i'll drop a link because it i will say](https://youtu.be/UlNwQ6WqCMw?t=01h22m01s)

[it is a cool framework](https://youtu.be/UlNwQ6WqCMw?t=01h22m03s)

[oh](https://youtu.be/UlNwQ6WqCMw?t=01h22m07s)

[i actually have done](https://youtu.be/UlNwQ6WqCMw?t=01h22m08s)

[so it's it's dated at this point but](https://youtu.be/UlNwQ6WqCMw?t=01h22m10s)

[i do have a stream so people are](https://youtu.be/UlNwQ6WqCMw?t=01h22m15s)

[interested in in the colas framework and](https://youtu.be/UlNwQ6WqCMw?t=01h22m18s)

[i will say](https://youtu.be/UlNwQ6WqCMw?t=01h22m20s)

[this is](https://youtu.be/UlNwQ6WqCMw?t=01h22m21s)

[very much it](https://youtu.be/UlNwQ6WqCMw?t=01h22m23s)

[all the information here is good](https://youtu.be/UlNwQ6WqCMw?t=01h22m25s)

[but it is](https://youtu.be/UlNwQ6WqCMw?t=01h22m28s)

[uh but it it is slightly older there's](https://youtu.be/UlNwQ6WqCMw?t=01h22m33s)

[been a lot of updates to coalesce since](https://youtu.be/UlNwQ6WqCMw?t=01h22m36s)

[then](https://youtu.be/UlNwQ6WqCMw?t=01h22m38s)

[so but if you are interested in it that](https://youtu.be/UlNwQ6WqCMw?t=01h22m39s)

[is grant and andrew giving the](https://youtu.be/UlNwQ6WqCMw?t=01h22m41s)

[arguably the the two main authors of it](https://youtu.be/UlNwQ6WqCMw?t=01h22m43s)

[giving a rundown of it and what it does](https://youtu.be/UlNwQ6WqCMw?t=01h22m47s)

[effectively it is a framework that](https://youtu.be/UlNwQ6WqCMw?t=01h22m49s)

[builds out all of your your middle tier](https://youtu.be/UlNwQ6WqCMw?t=01h22m51s)

[stuff](https://youtu.be/UlNwQ6WqCMw?t=01h22m53s)

[so you write database classes you write](https://youtu.be/UlNwQ6WqCMw?t=01h22m55s)

[front end stuff and it plums up the](https://youtu.be/UlNwQ6WqCMw?t=01h22m58s)

[middle for you](https://youtu.be/UlNwQ6WqCMw?t=01h23m00s)

[okay so i think what i can do](https://youtu.be/UlNwQ6WqCMw?t=01h23m02s)

[i think i can do](https://youtu.be/UlNwQ6WqCMw?t=01h23m07s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=01h23m09s)

[and i'm trying to remember if this works](https://youtu.be/UlNwQ6WqCMw?t=01h23m10s)

[i don't remember how to specify the](https://youtu.be/UlNwQ6WqCMw?t=01h23m13s)

[route into here](https://youtu.be/UlNwQ6WqCMw?t=01h23m15s)

[do i do](https://youtu.be/UlNwQ6WqCMw?t=01h23m18s)

[property name that's not it](https://youtu.be/UlNwQ6WqCMw?t=01h23m21s)

[template that's what i want](https://youtu.be/UlNwQ6WqCMw?t=01h23m26s)

[i want to go here like this](https://youtu.be/UlNwQ6WqCMw?t=01h23m29s)

[and i want this to be app name](https://youtu.be/UlNwQ6WqCMw?t=01h23m31s)

[i i think this gets me](https://youtu.be/UlNwQ6WqCMw?t=01h23m38s)

[spring](https://youtu.be/UlNwQ6WqCMw?t=01h23m40s)

[app name](https://youtu.be/UlNwQ6WqCMw?t=01h23m42s)

[i think this works](https://youtu.be/UlNwQ6WqCMw?t=01h23m44s)

[uh and we're just gonna have this guy](https://youtu.be/UlNwQ6WqCMw?t=01h23m45s)

[return a string for now](https://youtu.be/UlNwQ6WqCMw?t=01h23m47s)

[of](https://youtu.be/UlNwQ6WqCMw?t=01h23m49s)

[i just want to validate that the routing](https://youtu.be/UlNwQ6WqCMw?t=01h23m52s)

[works the way i expect](https://youtu.be/UlNwQ6WqCMw?t=01h23m54s)

[oh](https://youtu.be/UlNwQ6WqCMw?t=01h24m00s)

[thank you](https://youtu.be/UlNwQ6WqCMw?t=01h24m02s)

[that's also a very good link for uh if](https://youtu.be/UlNwQ6WqCMw?t=01h24m03s)

[you're interested in the view one okay](https://youtu.be/UlNwQ6WqCMw?t=01h24m06s)

[so squirrel app name](https://youtu.be/UlNwQ6WqCMw?t=01h24m08s)

[if i go try it out and i do](https://youtu.be/UlNwQ6WqCMw?t=01h24m11s)

[simply budget](https://youtu.be/UlNwQ6WqCMw?t=01h24m14s)

[so that got me kind of the way there](https://youtu.be/UlNwQ6WqCMw?t=01h24m16s)

[um that is not](https://youtu.be/UlNwQ6WqCMw?t=01h24m23s)

[okay so that did not give me what i](https://youtu.be/UlNwQ6WqCMw?t=01h24m27s)

[wanted](https://youtu.be/UlNwQ6WqCMw?t=01h24m30s)

[interesting and i wonder if](https://youtu.be/UlNwQ6WqCMw?t=01h24m34s)

[i wonder if it's a casing issue](https://youtu.be/UlNwQ6WqCMw?t=01h24m40s)

[let's try that and then i want this to](https://youtu.be/UlNwQ6WqCMw?t=01h24m43s)

[be](https://youtu.be/UlNwQ6WqCMw?t=01h24m45s)

[releases i'm wondering if you when you](https://youtu.be/UlNwQ6WqCMw?t=01h24m46s)

[do the template if it's not applying the](https://youtu.be/UlNwQ6WqCMw?t=01h24m48s)

[name to it](https://youtu.be/UlNwQ6WqCMw?t=01h24m50s)

[kind of shut it down for the night some](https://youtu.be/UlNwQ6WqCMw?t=01h24m53s)

[of us have to work in the morning and](https://youtu.be/UlNwQ6WqCMw?t=01h24m54s)

[have a good night see you joe thanks for](https://youtu.be/UlNwQ6WqCMw?t=01h24m55s)

[hanging out](https://youtu.be/UlNwQ6WqCMw?t=01h24m57s)

[okay so that got me much closer to what](https://youtu.be/UlNwQ6WqCMw?t=01h24m59s)

[i want from my url](https://youtu.be/UlNwQ6WqCMw?t=01h25m02s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=01h25m04s)

[simply](https://youtu.be/UlNwQ6WqCMw?t=01h25m06s)

[budget](https://youtu.be/UlNwQ6WqCMw?t=01h25m07s)

[execute](https://youtu.be/UlNwQ6WqCMw?t=01h25m09s)

[okay so that got okay so that that got](https://youtu.be/UlNwQ6WqCMw?t=01h25m11s)

[me there](https://youtu.be/UlNwQ6WqCMw?t=01h25m14s)

[okay so now i want one more](https://youtu.be/UlNwQ6WqCMw?t=01h25m16s)

[and i want this one to be at name](https://youtu.be/UlNwQ6WqCMw?t=01h25m19s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h25m23s)

[file name](https://youtu.be/UlNwQ6WqCMw?t=01h25m24s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h25m29s)

[file name](https://youtu.be/UlNwQ6WqCMw?t=01h25m30s)

[let's make this one return bar](https://youtu.be/UlNwQ6WqCMw?t=01h25m33s)

[or actually how about i](https://youtu.be/UlNwQ6WqCMw?t=01h25m36s)

[how about we do something intelligent](https://youtu.be/UlNwQ6WqCMw?t=01h25m38s)

[with this and go with something like](https://youtu.be/UlNwQ6WqCMw?t=01h25m39s)

[uh app name](https://youtu.be/UlNwQ6WqCMw?t=01h25m41s)

[and](https://youtu.be/UlNwQ6WqCMw?t=01h25m44s)

[file name](https://youtu.be/UlNwQ6WqCMw?t=01h25m47s)

[we'll make it be ha halfway reasonable](https://youtu.be/UlNwQ6WqCMw?t=01h25m48s)

[uh okay so if we relaunch that guy let's](https://youtu.be/UlNwQ6WqCMw?t=01h25m52s)

[take a look at what that gives me for a](https://youtu.be/UlNwQ6WqCMw?t=01h25m55s)

[route because that'll probably get me](https://youtu.be/UlNwQ6WqCMw?t=01h25m57s)

[closer](https://youtu.be/UlNwQ6WqCMw?t=01h25m59s)

[okay because i also want to make sure](https://youtu.be/UlNwQ6WqCMw?t=01h26m03s)

[that when i do](https://youtu.be/UlNwQ6WqCMw?t=01h26m05s)

[let's see](https://youtu.be/UlNwQ6WqCMw?t=01h26m08s)

[budget](https://youtu.be/UlNwQ6WqCMw?t=01h26m11s)

[uh food.n-u-p-p-k-g](https://youtu.be/UlNwQ6WqCMw?t=01h26m12s)

[execute](https://youtu.be/UlNwQ6WqCMw?t=01h26m17s)

[it's that matched in here now if i go up](https://youtu.be/UlNwQ6WqCMw?t=01h26m20s)

[here](https://youtu.be/UlNwQ6WqCMw?t=01h26m22s)

[and i try this out](https://youtu.be/UlNwQ6WqCMw?t=01h26m24s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h26m29s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=01h26m34s)

[i'm happy that it knows the difference](https://youtu.be/UlNwQ6WqCMw?t=01h26m36s)

[i'm just surprised that it knows the](https://youtu.be/UlNwQ6WqCMw?t=01h26m38s)

[difference](https://youtu.be/UlNwQ6WqCMw?t=01h26m40s)

[what happens](https://youtu.be/UlNwQ6WqCMw?t=01h26m46s)

[yeah see i was i'm not i'm not horribly](https://youtu.be/UlNwQ6WqCMw?t=01h26m53s)

[surprised here because that functionally](https://youtu.be/UlNwQ6WqCMw?t=01h26m55s)

[there is no difference](https://youtu.be/UlNwQ6WqCMw?t=01h26m58s)

[so do i leave this here as an end point](https://youtu.be/UlNwQ6WqCMw?t=01h27m03s)

[or do i functionally just say](https://youtu.be/UlNwQ6WqCMw?t=01h27m07s)

[really what i want is if you hit](https://youtu.be/UlNwQ6WqCMw?t=01h27m09s)

[squirrel slash app name slash file name](https://youtu.be/UlNwQ6WqCMw?t=01h27m12s)

[i'm just going to serve up the contents](https://youtu.be/UlNwQ6WqCMw?t=01h27m15s)

[of that i think that's actually what i](https://youtu.be/UlNwQ6WqCMw?t=01h27m16s)

[want i don't know if i actually care](https://youtu.be/UlNwQ6WqCMw?t=01h27m19s)

[about this other endpoint](https://youtu.be/UlNwQ6WqCMw?t=01h27m20s)

[because at the end of the day it's just](https://youtu.be/UlNwQ6WqCMw?t=01h27m25s)

[a special case of file name](https://youtu.be/UlNwQ6WqCMw?t=01h27m26s)

[i think i think we're gonna we're gonna](https://youtu.be/UlNwQ6WqCMw?t=01h27m29s)

[axe this](https://youtu.be/UlNwQ6WqCMw?t=01h27m31s)

[in favor of we just we literally just](https://youtu.be/UlNwQ6WqCMw?t=01h27m32s)

[want to serve this guy up as is](https://youtu.be/UlNwQ6WqCMw?t=01h27m35s)

[let's let's move you into your own](https://youtu.be/UlNwQ6WqCMw?t=01h27m38s)

[folder](https://youtu.be/UlNwQ6WqCMw?t=01h27m39s)

[or on file](https://youtu.be/UlNwQ6WqCMw?t=01h27m41s)

[or was it smart enough to oh that's so](https://youtu.be/UlNwQ6WqCMw?t=01h27m43s)

[cool](https://youtu.be/UlNwQ6WqCMw?t=01h27m46s)

[it was smart enough to bring the](https://youtu.be/UlNwQ6WqCMw?t=01h27m47s)

[comments](https://youtu.be/UlNwQ6WqCMw?t=01h27m48s)

[i didn't know those comments went with](https://youtu.be/UlNwQ6WqCMw?t=01h27m49s)

[that](https://youtu.be/UlNwQ6WqCMw?t=01h27m51s)

[i must just blindly grab stuff above it](https://youtu.be/UlNwQ6WqCMw?t=01h27m53s)

[points awarded](https://youtu.be/UlNwQ6WqCMw?t=01h27m57s)

[oh you failed again](https://youtu.be/UlNwQ6WqCMw?t=01h27m59s)

[why](https://youtu.be/UlNwQ6WqCMw?t=01h28m01s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=01h28m02s)

[this is better though](https://youtu.be/UlNwQ6WqCMw?t=01h28m03s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h28m05s)

[user profile could not be](https://youtu.be/UlNwQ6WqCMw?t=01h28m09s)

[oh this is run under something's](https://youtu.be/UlNwQ6WqCMw?t=01h28m14s)

[ah](https://youtu.be/UlNwQ6WqCMw?t=01h28m18s)

[right](https://youtu.be/UlNwQ6WqCMw?t=01h28m19s)

[this no bueno](https://youtu.be/UlNwQ6WqCMw?t=01h28m21s)

[this no bueno did we do](https://youtu.be/UlNwQ6WqCMw?t=01h28m24s)

[this because we did the set alias](https://youtu.be/UlNwQ6WqCMw?t=01h28m26s)

[approach](https://youtu.be/UlNwQ6WqCMw?t=01h28m29s)

[uh from the docks](https://youtu.be/UlNwQ6WqCMw?t=01h28m31s)

[yeah and you'll know they have this](https://youtu.be/UlNwQ6WqCMw?t=01h28m34s)

[little bit here](https://youtu.be/UlNwQ6WqCMw?t=01h28m36s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h28m42s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=01h28m43s)

[let's do a multi-step run](https://youtu.be/UlNwQ6WqCMw?t=01h28m44s)

[i think let's let's change this up](https://youtu.be/UlNwQ6WqCMw?t=01h28m48s)

[uh okay because](https://youtu.be/UlNwQ6WqCMw?t=01h28m52s)

[uh let's see here so this is going to](https://youtu.be/UlNwQ6WqCMw?t=01h28m54s)

[end up being](https://youtu.be/UlNwQ6WqCMw?t=01h28m56s)

[this](https://youtu.be/UlNwQ6WqCMw?t=01h29m00s)

[2 4 2](https://youtu.be/UlNwQ6WqCMw?t=01h29m02s)

[and then this will end up being](https://youtu.be/UlNwQ6WqCMw?t=01h29m04s)

[this](https://youtu.be/UlNwQ6WqCMw?t=01h29m11s)

[this is a little cleaner because this is](https://youtu.be/UlNwQ6WqCMw?t=01h29m16s)

[going to run under powershell because](https://youtu.be/UlNwQ6WqCMw?t=01h29m18s)

[it's running on the windows agent](https://youtu.be/UlNwQ6WqCMw?t=01h29m19s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=01h29m22s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h29m25s)

[being said](https://youtu.be/UlNwQ6WqCMw?t=01h29m27s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h29m29s)

[to use](https://youtu.be/UlNwQ6WqCMw?t=01h29m31s)

[that's out the door](https://youtu.be/UlNwQ6WqCMw?t=01h29m40s)

[okay so when i let that i'm gonna let](https://youtu.be/UlNwQ6WqCMw?t=01h29m44s)

[that guy](https://youtu.be/UlNwQ6WqCMw?t=01h29m46s)

[like i go pow out for a little bit uh](https://youtu.be/UlNwQ6WqCMw?t=01h29m47s)

[come back over here](https://youtu.be/UlNwQ6WqCMw?t=01h29m49s)

[actions](https://youtu.be/UlNwQ6WqCMw?t=01h29m52s)

[yeah](https://youtu.be/UlNwQ6WqCMw?t=01h29m53s)

[let you run and have fun okay so we've](https://youtu.be/UlNwQ6WqCMw?t=01h29m55s)

[got our squirrel controller it's going](https://youtu.be/UlNwQ6WqCMw?t=01h29m57s)

[to serve this up now](https://youtu.be/UlNwQ6WqCMw?t=01h29m59s)

[it needs to reach over](https://youtu.be/UlNwQ6WqCMw?t=01h30m01s)

[to get you](https://youtu.be/UlNwQ6WqCMw?t=01h30m03s)

[because it wants to grab](https://youtu.be/UlNwQ6WqCMw?t=01h30m05s)

[the](https://youtu.be/UlNwQ6WqCMw?t=01h30m08s)

[the files so for now](https://youtu.be/UlNwQ6WqCMw?t=01h30m09s)

[here's what we're gonna do](https://youtu.be/UlNwQ6WqCMw?t=01h30m11s)

[this is not a great solution](https://youtu.be/UlNwQ6WqCMw?t=01h30m12s)

[public](https://youtu.be/UlNwQ6WqCMw?t=01h30m15s)

[class](https://youtu.be/UlNwQ6WqCMw?t=01h30m16s)

[app map](https://youtu.be/UlNwQ6WqCMw?t=01h30m17s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h30m24s)

[public string get](https://youtu.be/UlNwQ6WqCMw?t=01h30m27s)

[hit repo](https://youtu.be/UlNwQ6WqCMw?t=01h30m40s)

[we're just gonna do this for the moment](https://youtu.be/UlNwQ6WqCMw?t=01h30m45s)

[i actually wish](https://youtu.be/UlNwQ6WqCMw?t=01h30m48s)

[you a hard coding hard coding hard](https://youtu.be/UlNwQ6WqCMw?t=01h30m51s)

[coding](https://youtu.be/UlNwQ6WqCMw?t=01h30m53s)

[yagni yagni yagni yagni yagni you ain't](https://youtu.be/UlNwQ6WqCMw?t=01h30m54s)

[gonna need it](https://youtu.be/UlNwQ6WqCMw?t=01h30m57s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h30m59s)

[so we're gonna](https://youtu.be/UlNwQ6WqCMw?t=01h31m01s)

[this is arguably the simplest i can make](https://youtu.be/UlNwQ6WqCMw?t=01h31m02s)

[this method](https://youtu.be/UlNwQ6WqCMw?t=01h31m05s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h31m08s)

[perfect uh](https://youtu.be/UlNwQ6WqCMw?t=01h31m14s)

[actually we're gonna we're gonna be](https://youtu.be/UlNwQ6WqCMw?t=01h31m17s)

[slightly better it'll be slightly better](https://youtu.be/UlNwQ6WqCMw?t=01h31m19s)

[uh if](https://youtu.be/UlNwQ6WqCMw?t=01h31m22s)

[string equals](https://youtu.be/UlNwQ6WqCMw?t=01h31m24s)

[budget](https://youtu.be/UlNwQ6WqCMw?t=01h31m31s)

[app name](https://youtu.be/UlNwQ6WqCMw?t=01h31m33s)

[in comparison](https://youtu.be/UlNwQ6WqCMw?t=01h31m36s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h31m37s)

[ignore case](https://youtu.be/UlNwQ6WqCMw?t=01h31m38s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h31m46s)

[that do that do that do that okay](https://youtu.be/UlNwQ6WqCMw?t=01h31m48s)

[that is the simplest i can make this](https://youtu.be/UlNwQ6WqCMw?t=01h31m51s)

[we're gonna mildly do it](https://youtu.be/UlNwQ6WqCMw?t=01h31m52s)

[string](https://youtu.be/UlNwQ6WqCMw?t=01h31m54s)

[uh root](https://youtu.be/UlNwQ6WqCMw?t=01h31m56s)

[repo](https://youtu.be/UlNwQ6WqCMw?t=01h31m59s)

[gets](https://youtu.be/UlNwQ6WqCMw?t=01h32m00s)

[at map](https://youtu.be/UlNwQ6WqCMw?t=01h32m01s)

[get repo](https://youtu.be/UlNwQ6WqCMw?t=01h32m02s)

[magic strings i know i know i know i](https://youtu.be/UlNwQ6WqCMw?t=01h32m04s)

[know](https://youtu.be/UlNwQ6WqCMw?t=01h32m06s)

[they're bad they're bad but](https://youtu.be/UlNwQ6WqCMw?t=01h32m08s)

[mvp](https://youtu.be/UlNwQ6WqCMw?t=01h32m10s)

[make it work make it right make it fast](https://youtu.be/UlNwQ6WqCMw?t=01h32m11s)

[in that order we're going with the make](https://youtu.be/UlNwQ6WqCMw?t=01h32m14s)

[it work part first](https://youtu.be/UlNwQ6WqCMw?t=01h32m16s)

[okay so we got that we got that uh](https://youtu.be/UlNwQ6WqCMw?t=01h32m17s)

[if](https://youtu.be/UlNwQ6WqCMw?t=01h32m20s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h32m22s)

[repo root](https://youtu.be/UlNwQ6WqCMw?t=01h32m23s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=01h32m26s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h32m29s)

[you do](https://youtu.be/UlNwQ6WqCMw?t=01h32m37s)

[not found](https://youtu.be/UlNwQ6WqCMw?t=01h32m38s)

[because i'm gonna have to change this](https://youtu.be/UlNwQ6WqCMw?t=01h32m39s)

[this up a little bit](https://youtu.be/UlNwQ6WqCMw?t=01h32m40s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h32m42s)

[i think i actually just want an i action](https://youtu.be/UlNwQ6WqCMw?t=01h32m45s)

[result if i'm not mistaken and then](https://youtu.be/UlNwQ6WqCMw?t=01h32m47s)

[return](https://youtu.be/UlNwQ6WqCMw?t=01h32m50s)

[bound](https://youtu.be/UlNwQ6WqCMw?t=01h32m52s)

[there that'll handle that](https://youtu.be/UlNwQ6WqCMw?t=01h32m54s)

[and then down here we want to actually](https://youtu.be/UlNwQ6WqCMw?t=01h32m57s)

[deal with](https://youtu.be/UlNwQ6WqCMw?t=01h33m00s)

[going out and getting said file](https://youtu.be/UlNwQ6WqCMw?t=01h33m02s)

[and i'm realizing something](https://youtu.be/UlNwQ6WqCMw?t=01h33m11s)

[we need the latest release](https://youtu.be/UlNwQ6WqCMw?t=01h33m14s)

[this one](https://youtu.be/UlNwQ6WqCMw?t=01h33m20s)

[there was docs in here](https://youtu.be/UlNwQ6WqCMw?t=01h33m23s)

[about](https://youtu.be/UlNwQ6WqCMw?t=01h33m27s)

[yeah releases latest](https://youtu.be/UlNwQ6WqCMw?t=01h33m29s)

[linking to releases](https://youtu.be/UlNwQ6WqCMw?t=01h33m36s)

[blah blah blah blah blah blah blah blah](https://youtu.be/UlNwQ6WqCMw?t=01h33m38s)

[blah](https://youtu.be/UlNwQ6WqCMw?t=01h33m40s)

[yeah](https://youtu.be/UlNwQ6WqCMw?t=01h33m41s)

[but there is a example in here where is](https://youtu.be/UlNwQ6WqCMw?t=01h33m42s)

[it](https://youtu.be/UlNwQ6WqCMw?t=01h33m46s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h33m48s)

[where we want to grab](https://youtu.be/UlNwQ6WqCMw?t=01h33m57s)

[yeah so we're gonna want to do this](https://youtu.be/UlNwQ6WqCMw?t=01h34m03s)

[releases latest so in our case it's](https://youtu.be/UlNwQ6WqCMw?t=01h34m06s)

[going to end up being](https://youtu.be/UlNwQ6WqCMw?t=01h34m09s)

[this guy](https://youtu.be/UlNwQ6WqCMw?t=01h34m12s)

[releases latest](https://youtu.be/UlNwQ6WqCMw?t=01h34m20s)

[right and that's going to take us to](https://youtu.be/UlNwQ6WqCMw?t=01h34m23s)

[here](https://youtu.be/UlNwQ6WqCMw?t=01h34m24s)

[okay so that's fine](https://youtu.be/UlNwQ6WqCMw?t=01h34m26s)

[there aren't any releases yet we'll need](https://youtu.be/UlNwQ6WqCMw?t=01h34m28s)

[to deal with that hit fail again](https://youtu.be/UlNwQ6WqCMw?t=01h34m30s)

[and i bet a thousand tonight](https://youtu.be/UlNwQ6WqCMw?t=01h34m35s)

[okay so parse air](https://youtu.be/UlNwQ6WqCMw?t=01h34m38s)

[string has missing terminator](https://youtu.be/UlNwQ6WqCMw?t=01h34m42s)

[what did i do wrong what did i do wrong](https://youtu.be/UlNwQ6WqCMw?t=01h34m51s)

[so let's see oh it's probably when i](https://youtu.be/UlNwQ6WqCMw?t=01h34m54s)

[moved the](https://youtu.be/UlNwQ6WqCMw?t=01h34m56s)

[path out i previously had single ticks](https://youtu.be/UlNwQ6WqCMw?t=01h34m59s)

[around it now i don't need them](https://youtu.be/UlNwQ6WqCMw?t=01h35m02s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h35m04s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=01h35m07s)

[moving](https://youtu.be/UlNwQ6WqCMw?t=01h35m08s)

[gray](https://youtu.be/UlNwQ6WqCMw?t=01h35m10s)

[whoa boom](https://youtu.be/UlNwQ6WqCMw?t=01h35m12s)

[push](https://youtu.be/UlNwQ6WqCMw?t=01h35m15s)

[sudo make me a release pretty please i](https://youtu.be/UlNwQ6WqCMw?t=01h35m17s)

[really just want you to make me release](https://youtu.be/UlNwQ6WqCMw?t=01h35m19s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h35m22s)

[okay so that will get me here and i'm](https://youtu.be/UlNwQ6WqCMw?t=01h35m24s)

[gonna make a i'm going to make a fake](https://youtu.be/UlNwQ6WqCMw?t=01h35m26s)

[release for the moment uh create new tag](https://youtu.be/UlNwQ6WqCMw?t=01h35m28s)

[0.0.0](https://youtu.be/UlNwQ6WqCMw?t=01h35m31s)

[i'm going to do here](https://youtu.be/UlNwQ6WqCMw?t=01h35m33s)

[create that uh](https://youtu.be/UlNwQ6WqCMw?t=01h35m35s)

[testing](https://youtu.be/UlNwQ6WqCMw?t=01h35m39s)

[show release](https://youtu.be/UlNwQ6WqCMw?t=01h35m40s)

[testing so we want to do](https://youtu.be/UlNwQ6WqCMw?t=01h35m44s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h35m46s)

[and then we're gonna add artifacts](https://youtu.be/UlNwQ6WqCMw?t=01h35m47s)

[which i'm literally just gonna take the](https://youtu.be/UlNwQ6WqCMw?t=01h35m51s)

[artifacts that i built locally](https://youtu.be/UlNwQ6WqCMw?t=01h35m52s)

[and attach them](https://youtu.be/UlNwQ6WqCMw?t=01h35m55s)

[because this is doing this part is also](https://youtu.be/UlNwQ6WqCMw?t=01h36m00s)

[something i want the action to do but i](https://youtu.be/UlNwQ6WqCMw?t=01h36m02s)

[think what i'm going to have](https://youtu.be/UlNwQ6WqCMw?t=01h36m05s)

[well](https://youtu.be/UlNwQ6WqCMw?t=01h36m07s)

[yeah because if i create the release](https://youtu.be/UlNwQ6WqCMw?t=01h36m09s)

[it'll kick off an action the release](https://youtu.be/UlNwQ6WqCMw?t=01h36m11s)

[will go live](https://youtu.be/UlNwQ6WqCMw?t=01h36m13s)

[oh i wonder if i run into a small timing](https://youtu.be/UlNwQ6WqCMw?t=01h36m16s)

[window problem](https://youtu.be/UlNwQ6WqCMw?t=01h36m18s)

[if the release goes live and there are](https://youtu.be/UlNwQ6WqCMw?t=01h36m20s)

[no artifacts](https://youtu.be/UlNwQ6WqCMw?t=01h36m22s)

[interesting see that's the reason why i](https://youtu.be/UlNwQ6WqCMw?t=01h36m26s)

[may want to end up caching things](https://youtu.be/UlNwQ6WqCMw?t=01h36m27s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h36m31s)

[but short version we now have a release](https://youtu.be/UlNwQ6WqCMw?t=01h36m32s)

[we now have one of these so if i do](https://youtu.be/UlNwQ6WqCMw?t=01h36m34s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=01h36m37s)

[latest](https://youtu.be/UlNwQ6WqCMw?t=01h36m39s)

[right this will get me to here and if i](https://youtu.be/UlNwQ6WqCMw?t=01h36m42s)

[do release it so there what is the](https://youtu.be/UlNwQ6WqCMw?t=01h36m44s)

[yeah](https://youtu.be/UlNwQ6WqCMw?t=01h36m48s)

[so if i go](https://youtu.be/UlNwQ6WqCMw?t=01h36m53s)

[copy link can i just simply do](https://youtu.be/UlNwQ6WqCMw?t=01h36m55s)

[releases download](https://youtu.be/UlNwQ6WqCMw?t=01h37m00s)

[can i do latest here and get away with](https://youtu.be/UlNwQ6WqCMw?t=01h37m03s)

[this](https://youtu.be/UlNwQ6WqCMw?t=01h37m05s)

[no](https://youtu.be/UlNwQ6WqCMw?t=01h37m08s)

[i'm gonna have to go to the api aren't i](https://youtu.be/UlNwQ6WqCMw?t=01h37m14s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h37m18s)

[oh hang on](https://youtu.be/UlNwQ6WqCMw?t=01h37m18s)

[that worked](https://youtu.be/UlNwQ6WqCMw?t=01h37m21s)

[that's pretty cool](https://youtu.be/UlNwQ6WqCMw?t=01h37m25s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=01h37m28s)

[if all we do is this](https://youtu.be/UlNwQ6WqCMw?t=01h37m30s)

[this works](https://youtu.be/UlNwQ6WqCMw?t=01h37m33s)

[okay so go back to our](https://youtu.be/UlNwQ6WqCMw?t=01h37m34s)

[littlely bitty api](https://youtu.be/UlNwQ6WqCMw?t=01h37m37s)

[so let's see](https://youtu.be/UlNwQ6WqCMw?t=01h37m41s)

[if](https://youtu.be/UlNwQ6WqCMw?t=01h37m42s)

[a string](https://youtu.be/UlNwQ6WqCMw?t=01h37m44s)

[equals](https://youtu.be/UlNwQ6WqCMw?t=01h37m46s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=01h37m48s)

[file name](https://youtu.be/UlNwQ6WqCMw?t=01h37m50s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h37m52s)

[string comparison](https://youtu.be/UlNwQ6WqCMw?t=01h37m53s)

[we'll do another case in sense](https://youtu.be/UlNwQ6WqCMw?t=01h37m56s)

[insensitive though it shouldn't matter](https://youtu.be/UlNwQ6WqCMw?t=01h37m58s)

[grab that for the moment](https://youtu.be/UlNwQ6WqCMw?t=01h38m01s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h38m04s)

[this will then be](https://youtu.be/UlNwQ6WqCMw?t=01h38m05s)

[this is just gonna give me the base url](https://youtu.be/UlNwQ6WqCMw?t=01h38m08s)

[right yeah so i'm gonna i'm gonna need](https://youtu.be/UlNwQ6WqCMw?t=01h38m10s)

[to tack on](https://youtu.be/UlNwQ6WqCMw?t=01h38m12s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h38m14s)

[string](https://youtu.be/UlNwQ6WqCMw?t=01h38m18s)

[or actually let's do uri](https://youtu.be/UlNwQ6WqCMw?t=01h38m19s)

[uh file](https://youtu.be/UlNwQ6WqCMw?t=01h38m21s)

[uri](https://youtu.be/UlNwQ6WqCMw?t=01h38m26s)

[it's new](https://youtu.be/UlNwQ6WqCMw?t=01h38m28s)

[uri repo root](https://youtu.be/UlNwQ6WqCMw?t=01h38m30s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h38m33s)

[but there's an overload here that is](https://youtu.be/UlNwQ6WqCMw?t=01h38m36s)

[like uri kind yeah there it is](https://youtu.be/UlNwQ6WqCMw?t=01h38m38s)

[right kind](https://youtu.be/UlNwQ6WqCMw?t=01h38m41s)

[so i want to tell it that it is absolute](https://youtu.be/UlNwQ6WqCMw?t=01h38m43s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=01h38m47s)

[file uri](https://youtu.be/UlNwQ6WqCMw?t=01h38m49s)

[gets](https://youtu.be/UlNwQ6WqCMw?t=01h38m51s)

[uri combine](https://youtu.be/UlNwQ6WqCMw?t=01h38m53s)

[where is it where's the combined method](https://youtu.be/UlNwQ6WqCMw?t=01h38m57s)

[oh](https://youtu.be/UlNwQ6WqCMw?t=01h39m07s)

[oh it's new it's on the constructor](https://youtu.be/UlNwQ6WqCMw?t=01h39m09s)

[isn't it](https://youtu.be/UlNwQ6WqCMw?t=01h39m12s)

[yeah base uri relative direct there it](https://youtu.be/UlNwQ6WqCMw?t=01h39m14s)

[is okay i do file uri](https://youtu.be/UlNwQ6WqCMw?t=01h39m17s)

[and](https://youtu.be/UlNwQ6WqCMw?t=01h39m20s)

[then this is going to become](https://youtu.be/UlNwQ6WqCMw?t=01h39m23s)

[this bit](https://youtu.be/UlNwQ6WqCMw?t=01h39m28s)

[here](https://youtu.be/UlNwQ6WqCMw?t=01h39m30s)

[i'm wondering if the the fact that's a](https://youtu.be/UlNwQ6WqCMw?t=01h39m35s)

[download is going to be a problem](https://youtu.be/UlNwQ6WqCMw?t=01h39m37s)

[i don't think it will be](https://youtu.be/UlNwQ6WqCMw?t=01h39m41s)

[i don't think it will be](https://youtu.be/UlNwQ6WqCMw?t=01h39m43s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h39m44s)

[return](https://youtu.be/UlNwQ6WqCMw?t=01h39m48s)

[uh let's see redirect](https://youtu.be/UlNwQ6WqCMw?t=01h39m51s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=01h39m56s)

[wait do you not take uh](https://youtu.be/UlNwQ6WqCMw?t=01h40m00s)

[you take a string of course you do](https://youtu.be/UlNwQ6WqCMw?t=01h40m02s)

[of course you do so all my work to put](https://youtu.be/UlNwQ6WqCMw?t=01h40m05s)

[you together in nice uri objects and you](https://youtu.be/UlNwQ6WqCMw?t=01h40m07s)

[just want a bloody stream okay fine](https://youtu.be/UlNwQ6WqCMw?t=01h40m09s)

[fine](https://youtu.be/UlNwQ6WqCMw?t=01h40m11s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h40m13s)

[else](https://youtu.be/UlNwQ6WqCMw?t=01h40m14s)

[return](https://youtu.be/UlNwQ6WqCMw?t=01h40m15s)

[redirect](https://youtu.be/UlNwQ6WqCMw?t=01h40m16s)

[um it's interesting because now](https://youtu.be/UlNwQ6WqCMw?t=01h40m20s)

[squirrel's gonna call back asking with a](https://youtu.be/UlNwQ6WqCMw?t=01h40m29s)

[file name](https://youtu.be/UlNwQ6WqCMw?t=01h40m31s)

[i don't really want to parse the file](https://youtu.be/UlNwQ6WqCMw?t=01h40m33s)

[name](https://youtu.be/UlNwQ6WqCMw?t=01h40m35s)

[but i might have to](https://youtu.be/UlNwQ6WqCMw?t=01h40m36s)

[i might have to because](https://youtu.be/UlNwQ6WqCMw?t=01h40m43s)

[ultimately i'm going to need](https://youtu.be/UlNwQ6WqCMw?t=01h40m45s)

[to know the version that they're](https://youtu.be/UlNwQ6WqCMw?t=01h40m48s)

[targeting](https://youtu.be/UlNwQ6WqCMw?t=01h40m50s)

[that's interesting we probably are going](https://youtu.be/UlNwQ6WqCMw?t=01h40m55s)

[to need to](https://youtu.be/UlNwQ6WqCMw?t=01h40m56s)

[parse this here so](https://youtu.be/UlNwQ6WqCMw?t=01h40m58s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h41m00s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=01h41m04s)

[or let's see file name](https://youtu.be/UlNwQ6WqCMw?t=01h41m10s)

[uh let's see ends with](https://youtu.be/UlNwQ6WqCMw?t=01h41m13s)

[we're just gonna we're just gonna](https://youtu.be/UlNwQ6WqCMw?t=01h41m19s)

[preemptively](https://youtu.be/UlNwQ6WqCMw?t=01h41m21s)

[shoot that one down](https://youtu.be/UlNwQ6WqCMw?t=01h41m24s)

[you ask for something that's not a](https://youtu.be/UlNwQ6WqCMw?t=01h41m29s)

[nougat package](https://youtu.be/UlNwQ6WqCMw?t=01h41m30s)

[we ain't serving it up](https://youtu.be/UlNwQ6WqCMw?t=01h41m32s)

[okay so we we've got some assurances](https://youtu.be/UlNwQ6WqCMw?t=01h41m35s)

[that it's halfway reasonable](https://youtu.be/UlNwQ6WqCMw?t=01h41m37s)

[trying to think of the best way to do](https://youtu.be/UlNwQ6WqCMw?t=01h41m43s)

[this without just](https://youtu.be/UlNwQ6WqCMw?t=01h41m44s)

[ah screw it we're gonna reject it](https://youtu.be/UlNwQ6WqCMw?t=01h41m47s)

[uh regex](https://youtu.be/UlNwQ6WqCMw?t=01h41m49s)

[match](https://youtu.be/UlNwQ6WqCMw?t=01h41m56s)

[see how how aggressive do we want to get](https://youtu.be/UlNwQ6WqCMw?t=01h41m58s)

[with this matching](https://youtu.be/UlNwQ6WqCMw?t=01h42m00s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h42m02s)

[i kind of think we we do](https://youtu.be/UlNwQ6WqCMw?t=01h42m09s)

[any character](https://youtu.be/UlNwQ6WqCMw?t=01h42m12s)

[and then let's see](https://youtu.be/UlNwQ6WqCMw?t=01h42m14s)

[virgin](https://youtu.be/UlNwQ6WqCMw?t=01h42m15s)

[uh is going to be](https://youtu.be/UlNwQ6WqCMw?t=01h42m18s)

[numeric](https://youtu.be/UlNwQ6WqCMw?t=01h42m20s)

[escape](https://youtu.be/UlNwQ6WqCMw?t=01h42m23s)

[numeric](https://youtu.be/UlNwQ6WqCMw?t=01h42m25s)

[oh numeric plus because i want one or](https://youtu.be/UlNwQ6WqCMw?t=01h42m27s)

[more digits escape that oh and you need](https://youtu.be/UlNwQ6WqCMw?t=01h42m30s)

[to be](https://youtu.be/UlNwQ6WqCMw?t=01h42m33s)

[at because you're gonna be picky about](https://youtu.be/UlNwQ6WqCMw?t=01h42m35s)

[that little thing](https://youtu.be/UlNwQ6WqCMw?t=01h42m37s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=01h42m38s)

[i'm gonna need this](https://youtu.be/UlNwQ6WqCMw?t=01h42m42s)

[like that](https://youtu.be/UlNwQ6WqCMw?t=01h42m45s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=01h42m48s)

[and i think what i actually want is](https://youtu.be/UlNwQ6WqCMw?t=01h42m52s)

[we want us match anything hyphen](https://youtu.be/UlNwQ6WqCMw?t=01h42m54s)

[dot version hyphen](https://youtu.be/UlNwQ6WqCMw?t=01h42m58s)

[and then oh the input stream comes first](https://youtu.be/UlNwQ6WqCMw?t=01h43m01s)

[so we're gonna do](https://youtu.be/UlNwQ6WqCMw?t=01h43m04s)

[file name](https://youtu.be/UlNwQ6WqCMw?t=01h43m07s)

[of our match](https://youtu.be/UlNwQ6WqCMw?t=01h43m10s)

[yeah](https://youtu.be/UlNwQ6WqCMw?t=01h43m12s)

[but](https://youtu.be/UlNwQ6WqCMw?t=01h43m14s)

[if](https://youtu.be/UlNwQ6WqCMw?t=01h43m15s)

[that's success we'll do the we're going](https://youtu.be/UlNwQ6WqCMw?t=01h43m17s)

[to do the needful](https://youtu.be/UlNwQ6WqCMw?t=01h43m19s)

[um actually let's not do that let's do](https://youtu.be/UlNwQ6WqCMw?t=01h43m21s)

[if match not success](https://youtu.be/UlNwQ6WqCMw?t=01h43m23s)

[return](https://youtu.be/UlNwQ6WqCMw?t=01h43m25s)

[bad request](https://youtu.be/UlNwQ6WqCMw?t=01h43m31s)

[do](https://youtu.be/UlNwQ6WqCMw?t=01h43m36s)

[you use full error](https://youtu.be/UlNwQ6WqCMw?t=01h43m37s)

[right because we want to get back](https://youtu.be/UlNwQ6WqCMw?t=01h43m40s)

[something helpful there otherwise we're](https://youtu.be/UlNwQ6WqCMw?t=01h43m41s)

[going to return](https://youtu.be/UlNwQ6WqCMw?t=01h43m42s)

[or let's build out the file uri](https://youtu.be/UlNwQ6WqCMw?t=01h43m44s)

[this guy here is then going to](https://youtu.be/UlNwQ6WqCMw?t=01h43m48s)

[become a student didn't highlight regex](https://youtu.be/UlNwQ6WqCMw?t=01h43m50s)

[syntax yeah it](https://youtu.be/UlNwQ6WqCMw?t=01h43m53s)

[you have to get it in the at and you](https://youtu.be/UlNwQ6WqCMw?t=01h43m56s)

[have to be passing it in the right place](https://youtu.be/UlNwQ6WqCMw?t=01h43m58s)

[for it to work](https://youtu.be/UlNwQ6WqCMw?t=01h44m00s)

[um okay so this is going to be](https://youtu.be/UlNwQ6WqCMw?t=01h44m04s)

[i'm back over here](https://youtu.be/UlNwQ6WqCMw?t=01h44m08s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h44m12s)

[i jump here](https://youtu.be/UlNwQ6WqCMw?t=01h44m14s)

[copy link](https://youtu.be/UlNwQ6WqCMw?t=01h44m20s)

[it's going to jump over here this is](https://youtu.be/UlNwQ6WqCMw?t=01h44m21s)

[going to end up being](https://youtu.be/UlNwQ6WqCMw?t=01h44m23s)

[once we have the version](https://youtu.be/UlNwQ6WqCMw?t=01h44m26s)

[it's going to be there](https://youtu.be/UlNwQ6WqCMw?t=01h44m28s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=01h44m30s)

[download rather than latest](https://youtu.be/UlNwQ6WqCMw?t=01h44m31s)

[this will end up being](https://youtu.be/UlNwQ6WqCMw?t=01h44m35s)

[version](https://youtu.be/UlNwQ6WqCMw?t=01h44m38s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=01h44m42s)

[slash](https://youtu.be/UlNwQ6WqCMw?t=01h44m46s)

[file name](https://youtu.be/UlNwQ6WqCMw?t=01h44m49s)

[that](https://youtu.be/UlNwQ6WqCMw?t=01h44m53s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=01h44m55s)

[redirect](https://youtu.be/UlNwQ6WqCMw?t=01h44m57s)

[thank you for figuring that out uh](https://youtu.be/UlNwQ6WqCMw?t=01h44m59s)

[string](https://youtu.be/UlNwQ6WqCMw?t=01h45m01s)

[version gets match](https://youtu.be/UlNwQ6WqCMw?t=01h45m03s)

[groups of](https://youtu.be/UlNwQ6WqCMw?t=01h45m05s)

[version](https://youtu.be/UlNwQ6WqCMw?t=01h45m07s)

[value](https://youtu.be/UlNwQ6WqCMw?t=01h45m09s)

[okay and this should be nice and safe](https://youtu.be/UlNwQ6WqCMw?t=01h45m11s)

[because the match was successful](https://youtu.be/UlNwQ6WqCMw?t=01h45m13s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h45m20s)

[let's try it see what happens](https://youtu.be/UlNwQ6WqCMw?t=01h45m21s)

[oh we do that we're going to come back](https://youtu.be/UlNwQ6WqCMw?t=01h45m27s)

[over here](https://youtu.be/UlNwQ6WqCMw?t=01h45m29s)

[failed again](https://youtu.be/UlNwQ6WqCMw?t=01h45m31s)

[what is your problem uh let's see](https://youtu.be/UlNwQ6WqCMw?t=01h45m34s)

[positional parameter cannot be](https://youtu.be/UlNwQ6WqCMw?t=01h45m37s)

[found that accepts squirrel huh](https://youtu.be/UlNwQ6WqCMw?t=01h45m39s)

[isn't that](https://youtu.be/UlNwQ6WqCMw?t=01h45m46s)

[exactly the command that i ran](https://youtu.be/UlNwQ6WqCMw?t=01h45m48s)

[here](https://youtu.be/UlNwQ6WqCMw?t=01h45m51s)

[said alias](https://youtu.be/UlNwQ6WqCMw?t=01h45m56s)

[come back over here](https://youtu.be/UlNwQ6WqCMw?t=01h46m02s)

[uh oh is it because](https://youtu.be/UlNwQ6WqCMw?t=01h46m04s)

[i didn't do that](https://youtu.be/UlNwQ6WqCMw?t=01h46m06s)

[let's come here](https://youtu.be/UlNwQ6WqCMw?t=01h46m09s)

[get him squirrel boy](https://youtu.be/UlNwQ6WqCMw?t=01h46m16s)

[thank you](https://youtu.be/UlNwQ6WqCMw?t=01h46m20s)

[doing my best though powershell is](https://youtu.be/UlNwQ6WqCMw?t=01h46m21s)

[kicking my butt](https://youtu.be/UlNwQ6WqCMw?t=01h46m23s)

[i](https://youtu.be/UlNwQ6WqCMw?t=01h46m25s)

[sorry i just want to double check that](https://youtu.be/UlNwQ6WqCMw?t=01h46m27s)

[error because i'm not a hundred percent](https://youtu.be/UlNwQ6WqCMw?t=01h46m28s)

[confident what this just did wrong](https://youtu.be/UlNwQ6WqCMw?t=01h46m30s)

[said ali oh yeah it put it all on one](https://youtu.be/UlNwQ6WqCMw?t=01h46m33s)

[line dang navit](https://youtu.be/UlNwQ6WqCMw?t=01h46m36s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h46m38s)

[something tells me my yaml syntax is a](https://youtu.be/UlNwQ6WqCMw?t=01h46m44s)

[little off](https://youtu.be/UlNwQ6WqCMw?t=01h46m46s)

[yeah see that](https://youtu.be/UlNwQ6WqCMw?t=01h46m54s)

[i was gonna say because the semicolon in](https://youtu.be/UlNwQ6WqCMw?t=01h46m56s)

[powershell is optional yeah thank you](https://youtu.be/UlNwQ6WqCMw?t=01h46m58s)

[thank you benjamin](https://youtu.be/UlNwQ6WqCMw?t=01h47m03s)

[see](https://youtu.be/UlNwQ6WqCMw?t=01h47m06s)

[this is why i shouldn't be allowed to](https://youtu.be/UlNwQ6WqCMw?t=01h47m07s)

[write powershell](https://youtu.be/UlNwQ6WqCMw?t=01h47m08s)

[uh okay](https://youtu.be/UlNwQ6WqCMw?t=01h47m11s)

[let's see as all pipeline commit](https://youtu.be/UlNwQ6WqCMw?t=01h47m14s)

[messages go](https://youtu.be/UlNwQ6WqCMw?t=01h47m17s)

[hating yaml](https://youtu.be/UlNwQ6WqCMw?t=01h47m18s)

[anyone who does pipeline work i'm pretty](https://youtu.be/UlNwQ6WqCMw?t=01h47m22s)

[sure everyone has a commit that looks](https://youtu.be/UlNwQ6WqCMw?t=01h47m24s)

[like that](https://youtu.be/UlNwQ6WqCMw?t=01h47m25s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h47m26s)

[okay so that's gonna go again and we're](https://youtu.be/UlNwQ6WqCMw?t=01h47m28s)

[gonna](https://youtu.be/UlNwQ6WqCMw?t=01h47m31s)

[cross our fingers and once again hope](https://youtu.be/UlNwQ6WqCMw?t=01h47m32s)

[for the best uh close to those blows](https://youtu.be/UlNwQ6WqCMw?t=01h47m33s)

[want that one back close that one](https://youtu.be/UlNwQ6WqCMw?t=01h47m38s)

[uh you actions go sit on the latest okay](https://youtu.be/UlNwQ6WqCMw?t=01h47m40s)

[so but we were launching our app](https://youtu.be/UlNwQ6WqCMw?t=01h47m45s)

[here](https://youtu.be/UlNwQ6WqCMw?t=01h47m49s)

[we're gonna test it so if we do try it](https://youtu.be/UlNwQ6WqCMw?t=01h47m52s)

[out](https://youtu.be/UlNwQ6WqCMw?t=01h47m54s)

[simply budget](https://youtu.be/UlNwQ6WqCMw?t=01h47m56s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h47m59s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=01h48m00s)

[execute](https://youtu.be/UlNwQ6WqCMw?t=01h48m02s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h48m06s)

[a million failed pipeline notifications](https://youtu.be/UlNwQ6WqCMw?t=01h48m10s)

[people that additional filters](https://youtu.be/UlNwQ6WqCMw?t=01h48m13s)

[yeah that sounds about right](https://youtu.be/UlNwQ6WqCMw?t=01h48m16s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h48m19s)

[failed to fetch possible reasons](https://youtu.be/UlNwQ6WqCMw?t=01h48m20s)

[those are all possible reasons](https://youtu.be/UlNwQ6WqCMw?t=01h48m25s)

[uh so maybe we should debunk it and](https://youtu.be/UlNwQ6WqCMw?t=01h48m28s)

[actually see why it failed](https://youtu.be/UlNwQ6WqCMw?t=01h48m30s)

[i have a strange feeling it hit the 302](https://youtu.be/UlNwQ6WqCMw?t=01h48m33s)

[and the browser said no](https://youtu.be/UlNwQ6WqCMw?t=01h48m38s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h48m52s)

[yeah possible reasons course ugh](https://youtu.be/UlNwQ6WqCMw?t=01h48m55s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h49m00s)

[yuck don't really want to download](https://youtu.be/UlNwQ6WqCMw?t=01h49m12s)

[like i don't really want my service to](https://youtu.be/UlNwQ6WqCMw?t=01h49m16s)

[reach over to github to grab it and](https://youtu.be/UlNwQ6WqCMw?t=01h49m18s)

[bring it back](https://youtu.be/UlNwQ6WqCMw?t=01h49m20s)

[yet because then i eat those bandwidth](https://youtu.be/UlNwQ6WqCMw?t=01h49m22s)

[costs whereas if i redirect the caller](https://youtu.be/UlNwQ6WqCMw?t=01h49m24s)

[let's let's just test the theory real](https://youtu.be/UlNwQ6WqCMw?t=01h49m33s)

[quick](https://youtu.be/UlNwQ6WqCMw?t=01h49m36s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=01h49m37s)

[woke web request](https://youtu.be/UlNwQ6WqCMw?t=01h49m38s)

[there](https://youtu.be/UlNwQ6WqCMw?t=01h49m41s)

[we turn off browser](https://youtu.be/UlNwQ6WqCMw?t=01h49m44s)

[uh invoke web request](https://youtu.be/UlNwQ6WqCMw?t=01h49m48s)

[oh interesting](https://youtu.be/UlNwQ6WqCMw?t=01h49m50s)

[so this is](https://youtu.be/UlNwQ6WqCMw?t=01h49m52s)

[request connection was closed](https://youtu.be/UlNwQ6WqCMw?t=01h49m54s)

[unexpectedly](https://youtu.be/UlNwQ6WqCMw?t=01h49m56s)

[huh](https://youtu.be/UlNwQ6WqCMw?t=01h49m58s)

[but](https://youtu.be/UlNwQ6WqCMw?t=01h50m03s)

[huh](https://youtu.be/UlNwQ6WqCMw?t=01h50m05s)

[ah](https://youtu.be/UlNwQ6WqCMw?t=01h50m17s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=01h50m18s)

[okay now we're getting somewhere](https://youtu.be/UlNwQ6WqCMw?t=01h50m21s)

[so that that that didn't work](https://youtu.be/UlNwQ6WqCMw?t=01h50m23s)

[but doesn't that work when i put it in](https://youtu.be/UlNwQ6WqCMw?t=01h50m26s)

[the browser](https://youtu.be/UlNwQ6WqCMw?t=01h50m27s)

[oh is this just released not releases](https://youtu.be/UlNwQ6WqCMw?t=01h50m31s)

[am i just stupid](https://youtu.be/UlNwQ6WqCMw?t=01h50m33s)

[there's the file](https://youtu.be/UlNwQ6WqCMw?t=01h50m37s)

[no](https://youtu.be/UlNwQ6WqCMw?t=01h50m40s)

[read these says](https://youtu.be/UlNwQ6WqCMw?t=01h50m41s)

[that okay blow that away blow that away](https://youtu.be/UlNwQ6WqCMw?t=01h50m52s)

[is that not the](https://youtu.be/UlNwQ6WqCMw?t=01h50m58s)

[18 year old worked](https://youtu.be/UlNwQ6WqCMw?t=01h51m01s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h51m03s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h51m05s)

[so we have a run which means i should be](https://youtu.be/UlNwQ6WqCMw?t=01h51m06s)

[able to go here and i should be able to](https://youtu.be/UlNwQ6WqCMw?t=01h51m09s)

[download an installer](https://youtu.be/UlNwQ6WqCMw?t=01h51m11s)

[yes yes progress progress progress](https://youtu.be/UlNwQ6WqCMw?t=01h51m16s)

[okay so this should have an installer in](https://youtu.be/UlNwQ6WqCMw?t=01h51m23s)

[it](https://youtu.be/UlNwQ6WqCMw?t=01h51m24s)

[it does](https://youtu.be/UlNwQ6WqCMw?t=01h51m27s)

[huzzah](https://youtu.be/UlNwQ6WqCMw?t=01h51m28s)

[this](https://youtu.be/UlNwQ6WqCMw?t=01h51m30s)

[this be what we want](https://youtu.be/UlNwQ6WqCMw?t=01h51m31s)

[so](https://youtu.be/UlNwQ6WqCMw?t=01h51m33s)

[that is](https://youtu.be/UlNwQ6WqCMw?t=01h51m34s)

[so now what we would want is a github](https://youtu.be/UlNwQ6WqCMw?t=01h51m35s)

[action](https://youtu.be/UlNwQ6WqCMw?t=01h51m38s)

[that would](https://youtu.be/UlNwQ6WqCMw?t=01h51m40s)

[gen these files](https://youtu.be/UlNwQ6WqCMw?t=01h51m41s)

[on release creation and upload them to](https://youtu.be/UlNwQ6WqCMw?t=01h51m44s)

[the release](https://youtu.be/UlNwQ6WqCMw?t=01h51m46s)

[that's what we want so we've we've](https://youtu.be/UlNwQ6WqCMw?t=01h51m48s)

[validated the github action steps](https://youtu.be/UlNwQ6WqCMw?t=01h51m50s)

[i now want to trigger those on a release](https://youtu.be/UlNwQ6WqCMw?t=01h51m53s)

[and pull those i might deal with that in](https://youtu.be/UlNwQ6WqCMw?t=01h51m55s)

[a minute because](https://youtu.be/UlNwQ6WqCMw?t=01h51m56s)

[that's just going to be syntax of](https://youtu.be/UlNwQ6WqCMw?t=01h51m58s)

[getting that to work rather than](https://youtu.be/UlNwQ6WqCMw?t=01h52m00s)

[anything technical or interesting and](https://youtu.be/UlNwQ6WqCMw?t=01h52m01s)

[this](https://youtu.be/UlNwQ6WqCMw?t=01h52m03s)

[surprises me a great deal so](https://youtu.be/UlNwQ6WqCMw?t=01h52m04s)

[let's go back here and look at that](https://youtu.be/UlNwQ6WqCMw?t=01h52m07s)

[release](https://youtu.be/UlNwQ6WqCMw?t=01h52m09s)

[because i could have sworn](https://youtu.be/UlNwQ6WqCMw?t=01h52m12s)

[copy link](https://youtu.be/UlNwQ6WqCMw?t=01h52m17s)

[paste](https://youtu.be/UlNwQ6WqCMw?t=01h52m19s)

[download](https://youtu.be/UlNwQ6WqCMw?t=01h52m21s)

[um](https://youtu.be/UlNwQ6WqCMw?t=01h52m35s)

[i thought that's what i did before](https://youtu.be/UlNwQ6WqCMw?t=01h52m44s)

[oh](https://youtu.be/UlNwQ6WqCMw?t=01h52m50s)

[is what i did before](https://youtu.be/UlNwQ6WqCMw?t=01h52m53s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h52m56s)

[copy download link so if we come back](https://youtu.be/UlNwQ6WqCMw?t=01h52m58s)

[over here](https://youtu.be/UlNwQ6WqCMw?t=01h53m01s)

[that actually is what i want](https://youtu.be/UlNwQ6WqCMw?t=01h53m15s)

[releases latest so they're redirecting](https://youtu.be/UlNwQ6WqCMw?t=01h53m18s)

[on top of it](https://youtu.be/UlNwQ6WqCMw?t=01h53m20s)

[right so if i come in here](https://youtu.be/UlNwQ6WqCMw?t=01h53m23s)

[i don't want latest here so okay so the](https://youtu.be/UlNwQ6WqCMw?t=01h53m25s)

[issue was](https://youtu.be/UlNwQ6WqCMw?t=01h53m27s)

[where i put my](https://youtu.be/UlNwQ6WqCMw?t=01h53m30s)

[this is](https://youtu.be/UlNwQ6WqCMw?t=01h53m49s)

[latest](https://youtu.be/UlNwQ6WqCMw?t=01h53m51s)

[copy](https://youtu.be/UlNwQ6WqCMw?t=01h53m53s)

[yes that's](https://youtu.be/UlNwQ6WqCMw?t=01h53m56s)

[that's the target url](https://youtu.be/UlNwQ6WqCMw?t=01h53m58s)

[bulk web request paste](https://youtu.be/UlNwQ6WqCMw?t=01h54m00s)

[that one should trigger](https://youtu.be/UlNwQ6WqCMw?t=01h54m03s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h54m13s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h54m26s)

[okay so that's](https://youtu.be/UlNwQ6WqCMw?t=01h54m27s)

[the issue is i copied the wrong url okay](https://youtu.be/UlNwQ6WqCMw?t=01h54m29s)

[okay okay](https://youtu.be/UlNwQ6WqCMw?t=01h54m31s)

[we can do this](https://youtu.be/UlNwQ6WqCMw?t=01h54m32s)

[okay so from the base it's going to be](https://youtu.be/UlNwQ6WqCMw?t=01h54m36s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=01h54m38s)

[latest](https://youtu.be/UlNwQ6WqCMw?t=01h54m42s)

[death wait](https://youtu.be/UlNwQ6WqCMw?t=01h54m44s)

[that should be](https://youtu.be/UlNwQ6WqCMw?t=01h54m54s)

[releases latest](https://youtu.be/UlNwQ6WqCMw?t=01h54m58s)

[download](https://youtu.be/UlNwQ6WqCMw?t=01h55m01s)

[yeah so](https://youtu.be/UlNwQ6WqCMw?t=01h55m10s)

[i'm confused now but let's](https://youtu.be/UlNwQ6WqCMw?t=01h55m13s)

[pop this one more time and we'll take](https://youtu.be/UlNwQ6WqCMw?t=01h55m16s)

[another look at it because i do want to](https://youtu.be/UlNwQ6WqCMw?t=01h55m18s)

[make sure that this is correct because](https://youtu.be/UlNwQ6WqCMw?t=01h55m20s)

[it could it could be that coors issue](https://youtu.be/UlNwQ6WqCMw?t=01h55m22s)

[but now that it's](https://youtu.be/UlNwQ6WqCMw?t=01h55m24s)

[um now that powershell works i should be](https://youtu.be/UlNwQ6WqCMw?t=01h55m26s)

[able to hit it](https://youtu.be/UlNwQ6WqCMw?t=01h55m28s)

[so](https://youtu.be/UlNwQ6WqCMw?t=01h55m30s)

[try it out](https://youtu.be/UlNwQ6WqCMw?t=01h55m31s)

[simply budget](https://youtu.be/UlNwQ6WqCMw?t=01h55m33s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=01h55m37s)

[execute](https://youtu.be/UlNwQ6WqCMw?t=01h55m38s)

[we hit this](https://youtu.be/UlNwQ6WqCMw?t=01h55m40s)

[view](https://youtu.be/UlNwQ6WqCMw?t=01h55m43s)

[copy](https://youtu.be/UlNwQ6WqCMw?t=01h55m46s)

[paste](https://youtu.be/UlNwQ6WqCMw?t=01h55m49s)

[what did i do wrong](https://youtu.be/UlNwQ6WqCMw?t=01h55m51s)

[ah](https://youtu.be/UlNwQ6WqCMw?t=01h55m55s)

[so when it's combining it's dropping the](https://youtu.be/UlNwQ6WqCMw?t=01h55m56s)

[repo name off of it](https://youtu.be/UlNwQ6WqCMw?t=01h55m58s)

[so i think](https://youtu.be/UlNwQ6WqCMw?t=01h56m10s)

[this gets fixed by doing this](https://youtu.be/UlNwQ6WqCMw?t=01h56m13s)

[i think](https://youtu.be/UlNwQ6WqCMw?t=01h56m21s)

[i'm trying to remember the uri combining](https://youtu.be/UlNwQ6WqCMw?t=01h56m22s)

[rules](https://youtu.be/UlNwQ6WqCMw?t=01h56m24s)

[let's try this again try it](https://youtu.be/UlNwQ6WqCMw?t=01h56m25s)

[okay let's check this again](https://youtu.be/UlNwQ6WqCMw?t=01h56m36s)

[view](https://youtu.be/UlNwQ6WqCMw?t=01h56m40s)

[copy](https://youtu.be/UlNwQ6WqCMw?t=01h56m41s)

[and then go here](https://youtu.be/UlNwQ6WqCMw?t=01h56m43s)

[paste](https://youtu.be/UlNwQ6WqCMw?t=01h56m45s)

[oh that looks a heck of a lot better](https://youtu.be/UlNwQ6WqCMw?t=01h56m46s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h56m49s)

[go](https://youtu.be/UlNwQ6WqCMw?t=01h56m50s)

[i can't tell what that did so i'm gonna](https://youtu.be/UlNwQ6WqCMw?t=01h56m58s)

[come down here](https://youtu.be/UlNwQ6WqCMw?t=01h57m00s)

[and go with](https://youtu.be/UlNwQ6WqCMw?t=01h57m01s)

[this guy here](https://youtu.be/UlNwQ6WqCMw?t=01h57m06s)

[because if i come back i'm assuming the](https://youtu.be/UlNwQ6WqCMw?t=01h57m08s)

[reader i assume squirrel is just not hip](https://youtu.be/UlNwQ6WqCMw?t=01h57m10s)

[to](https://youtu.be/UlNwQ6WqCMw?t=01h57m12s)

[handling 302's](https://youtu.be/UlNwQ6WqCMw?t=01h57m13s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=01h57m16s)

[so let's just do](https://youtu.be/UlNwQ6WqCMw?t=01h57m22s)

[that is that the right port number](https://youtu.be/UlNwQ6WqCMw?t=01h57m29s)

[though](https://youtu.be/UlNwQ6WqCMw?t=01h57m31s)

[yes it is](https://youtu.be/UlNwQ6WqCMw?t=01h57m33s)

[good hit the same endpoint](https://youtu.be/UlNwQ6WqCMw?t=01h57m36s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h57m39s)

[let's see](https://youtu.be/UlNwQ6WqCMw?t=01h57m40s)

[basic](https://youtu.be/UlNwQ6WqCMw?t=01h57m42s)

[parsing](https://youtu.be/UlNwQ6WqCMw?t=01h57m43s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h57m46s)

[i think that works](https://youtu.be/UlNwQ6WqCMw?t=01h57m48s)

[i'm hoping that serves it up the way i](https://youtu.be/UlNwQ6WqCMw?t=01h57m50s)

[expect](https://youtu.be/UlNwQ6WqCMw?t=01h57m52s)

[but it looks like it is a bite stream](https://youtu.be/UlNwQ6WqCMw?t=01h57m54s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h57m56s)

[so now if we come in here and we do not](https://youtu.be/UlNwQ6WqCMw?t=01h57m57s)

[this and we say well what we really want](https://youtu.be/UlNwQ6WqCMw?t=01h58m00s)

[now is the](https://youtu.be/UlNwQ6WqCMw?t=01h58m02s)

[the file out of it which is this guy](https://youtu.be/UlNwQ6WqCMw?t=01h58m04s)

[right i expect to get](https://youtu.be/UlNwQ6WqCMw?t=01h58m07s)

[another](https://youtu.be/UlNwQ6WqCMw?t=01h58m10s)

[200 but i expect it to have a a slightly](https://youtu.be/UlNwQ6WqCMw?t=01h58m11s)

[different](https://youtu.be/UlNwQ6WqCMw?t=01h58m14s)

[byte pattern at the beginning](https://youtu.be/UlNwQ6WqCMw?t=01h58m15s)

[404 not found](https://youtu.be/UlNwQ6WqCMw?t=01h58m18s)

[okay so let's look at why that might be](https://youtu.be/UlNwQ6WqCMw?t=01h58m20s)

[the case](https://youtu.be/UlNwQ6WqCMw?t=01h58m23s)

[and hit it](https://youtu.be/UlNwQ6WqCMw?t=01h58m25s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=01h58m29s)

[did it not even come in here](https://youtu.be/UlNwQ6WqCMw?t=01h58m33s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=01h58m40s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=01h58m41s)

[oh if file name ends with](https://youtu.be/UlNwQ6WqCMw?t=01h58m47s)

[oh](https://youtu.be/UlNwQ6WqCMw?t=01h58m50s)

[that's](https://youtu.be/UlNwQ6WqCMw?t=01h58m51s)

[we gotta eliminate that check real quick](https://youtu.be/UlNwQ6WqCMw?t=01h58m53s)

[that's problematic](https://youtu.be/UlNwQ6WqCMw?t=01h58m55s)

[because](https://youtu.be/UlNwQ6WqCMw?t=01h58m58s)

[we don't wanna return not found in that](https://youtu.be/UlNwQ6WqCMw?t=01h58m59s)

[case we do probably want to add some](https://youtu.be/UlNwQ6WqCMw?t=01h59m01s)

[checks on it but if i put it on now](https://youtu.be/UlNwQ6WqCMw?t=01h59m02s)

[it'll also it'll break the releases](https://youtu.be/UlNwQ6WqCMw?t=01h59m05s)

[call back so we'll let that guy fire up](https://youtu.be/UlNwQ6WqCMw?t=01h59m07s)

[we're going to do this guy here](https://youtu.be/UlNwQ6WqCMw?t=01h59m11s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=01h59m17s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=01h59m22s)

[match](https://youtu.be/UlNwQ6WqCMw?t=01h59m29s)

[version 1.000](https://youtu.be/UlNwQ6WqCMw?t=01h59m30s)

[does that url look correct releases](https://youtu.be/UlNwQ6WqCMw?t=01h59m34s)

[download 1.0](https://youtu.be/UlNwQ6WqCMw?t=01h59m36s)

[oh interesting i'm just realizing a](https://youtu.be/UlNwQ6WqCMw?t=01h59m39s)

[small problem](https://youtu.be/UlNwQ6WqCMw?t=01h59m41s)

[this guy here](https://youtu.be/UlNwQ6WqCMw?t=01h59m46s)

[is the release number not the tag number](https://youtu.be/UlNwQ6WqCMw?t=01h59m51s)

[or the release name not the tag number](https://youtu.be/UlNwQ6WqCMw?t=01h59m54s)

[oh interesting and that didn't work](https://youtu.be/UlNwQ6WqCMw?t=02h00m06s)

[oh probably because the it's the really](https://youtu.be/UlNwQ6WqCMw?t=02h00m11s)

[the exact reason i just said](https://youtu.be/UlNwQ6WqCMw?t=02h00m14s)

[is it wants it to be 0.0.0 which is the](https://youtu.be/UlNwQ6WqCMw?t=02h00m20s)

[release name](https://youtu.be/UlNwQ6WqCMw?t=02h00m23s)

[so in order for this to work](https://youtu.be/UlNwQ6WqCMw?t=02h00m28s)

[i](https://youtu.be/UlNwQ6WqCMw?t=02h00m31s)

[have to](https://youtu.be/UlNwQ6WqCMw?t=02h00m32s)

[know](https://youtu.be/UlNwQ6WqCMw?t=02h00m35s)

[which release names contain which](https://youtu.be/UlNwQ6WqCMw?t=02h00m36s)

[versions](https://youtu.be/UlNwQ6WqCMw?t=02h00m38s)

[or i have to build a rule that says](https://youtu.be/UlNwQ6WqCMw?t=02h00m42s)

[time to make release number read from](https://youtu.be/UlNwQ6WqCMw?t=02h00m46s)

[tag number yeah that that is the other](https://youtu.be/UlNwQ6WqCMw?t=02h00m47s)

[thing is](https://youtu.be/UlNwQ6WqCMw?t=02h00m49s)

[or i have to make this release match the](https://youtu.be/UlNwQ6WqCMw?t=02h00m51s)

[tag](https://youtu.be/UlNwQ6WqCMw?t=02h00m54s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=02h00m59s)

[oh it doesn't let you rename this](https://youtu.be/UlNwQ6WqCMw?t=02h01m05s)

[i mean so the other thing i can do that](https://youtu.be/UlNwQ6WqCMw?t=02h01m22s)

[that releases file for the manifest](https://youtu.be/UlNwQ6WqCMw?t=02h01m24s)

[is actually fairly trivial](https://youtu.be/UlNwQ6WqCMw?t=02h01m27s)

[i wonder](https://youtu.be/UlNwQ6WqCMw?t=02h01m33s)

[let's](https://youtu.be/UlNwQ6WqCMw?t=02h01m36s)

[i guess we should get it working first](https://youtu.be/UlNwQ6WqCMw?t=02h01m41s)

[but i have a i have a working theory](https://youtu.be/UlNwQ6WqCMw?t=02h01m43s)

[that](https://youtu.be/UlNwQ6WqCMw?t=02h01m46s)

[i could muck with this file](https://youtu.be/UlNwQ6WqCMw?t=02h01m48s)

[and i could i could embed because i'm](https://youtu.be/UlNwQ6WqCMw?t=02h01m54s)

[fairly confident it just takes the file](https://youtu.be/UlNwQ6WqCMw?t=02h01m56s)

[name portion of that and slaps it onto](https://youtu.be/UlNwQ6WqCMw?t=02h01m58s)

[the root](https://youtu.be/UlNwQ6WqCMw?t=02h02m00s)

[which means i'm pretty confident i](https://youtu.be/UlNwQ6WqCMw?t=02h02m03s)

[could hijack that](https://youtu.be/UlNwQ6WqCMw?t=02h02m06s)

[pretty confident](https://youtu.be/UlNwQ6WqCMw?t=02h02m11s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=02h02m13s)

[so let's let's test this thing out then](https://youtu.be/UlNwQ6WqCMw?t=02h02m15s)

[a little bit](https://youtu.be/UlNwQ6WqCMw?t=02h02m18s)

[further](https://youtu.be/UlNwQ6WqCMw?t=02h02m20s)

[if we come into here](https://youtu.be/UlNwQ6WqCMw?t=02h02m21s)

[come into here](https://youtu.be/UlNwQ6WqCMw?t=02h02m23s)

[uh we're gonna go into our app startup](https://youtu.be/UlNwQ6WqCMw?t=02h02m25s)

[back in this](https://youtu.be/UlNwQ6WqCMw?t=02h02m28s)

[uh on app startup](https://youtu.be/UlNwQ6WqCMw?t=02h02m30s)

[on app run](https://youtu.be/UlNwQ6WqCMw?t=02h02m33s)

[uh i kind of want to just set the](https://youtu.be/UlNwQ6WqCMw?t=02h02m38s)

[version](https://youtu.be/UlNwQ6WqCMw?t=02h02m40s)

[what was i doing though as i do that my](https://youtu.be/UlNwQ6WqCMw?t=02h02m43s)

[main window](https://youtu.be/UlNwQ6WqCMw?t=02h02m45s)

[yeah so here's where it's falling back](https://youtu.be/UlNwQ6WqCMw?t=02h02m50s)

[to local](https://youtu.be/UlNwQ6WqCMw?t=02h02m52s)

[uh if i turn all of this off](https://youtu.be/UlNwQ6WqCMw?t=02h02m54s)

[let me look and see what is this](https://youtu.be/UlNwQ6WqCMw?t=02h02m57s)

[squirrel api give me](https://youtu.be/UlNwQ6WqCMw?t=02h03m00s)

[so i have a sinking suspicion this guy](https://youtu.be/UlNwQ6WqCMw?t=02h03m03s)

[actually has something on here to like](https://youtu.be/UlNwQ6WqCMw?t=02h03m05s)

[retrieve](https://youtu.be/UlNwQ6WqCMw?t=02h03m07s)

[uh handle](https://youtu.be/UlNwQ6WqCMw?t=02h03m10s)

[events oh there's an on every run](https://youtu.be/UlNwQ6WqCMw?t=02h03m12s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h03m20s)

[oh and that's exactly what this guy's](https://youtu.be/UlNwQ6WqCMw?t=02h03m22s)

[doing](https://youtu.be/UlNwQ6WqCMw?t=02h03m24s)

[um](https://youtu.be/UlNwQ6WqCMw?t=02h03m25s)

[this a](https://youtu.be/UlNwQ6WqCMw?t=02h03m31s)

[we're gonna just do this for the moment](https://youtu.be/UlNwQ6WqCMw?t=02h03m45s)

[and we're gonna do](https://youtu.be/UlNwQ6WqCMw?t=02h03m48s)

[that and then we're going to come over](https://youtu.be/UlNwQ6WqCMw?t=02h03m54s)

[here to main window](https://youtu.be/UlNwQ6WqCMw?t=02h03m56s)

[we're going to go with](https://youtu.be/UlNwQ6WqCMw?t=02h03m59s)

[something along the lines of if](https://youtu.be/UlNwQ6WqCMw?t=02h04m05s)

[version is](https://youtu.be/UlNwQ6WqCMw?t=02h04m11s)

[version](https://youtu.be/UlNwQ6WqCMw?t=02h04m14s)

[slap it in](https://youtu.be/UlNwQ6WqCMw?t=02h04m17s)

[something like that](https://youtu.be/UlNwQ6WqCMw?t=02h04m21s)

[which means in this case](https://youtu.be/UlNwQ6WqCMw?t=02h04m23s)

[i don't expect it to have anything](https://youtu.be/UlNwQ6WqCMw?t=02h04m28s)

[it's worth noting this version is](https://youtu.be/UlNwQ6WqCMw?t=02h04m31s)

[different than the i should not do this](https://youtu.be/UlNwQ6WqCMw?t=02h04m34s)

[i should do this this version uh for](https://youtu.be/UlNwQ6WqCMw?t=02h04m36s)

[your squirrel installer is separate from](https://youtu.be/UlNwQ6WqCMw?t=02h04m40s)

[your app's version](https://youtu.be/UlNwQ6WqCMw?t=02h04m42s)

[so your your installer version and your](https://youtu.be/UlNwQ6WqCMw?t=02h04m44s)

[apps version probably should stay in](https://youtu.be/UlNwQ6WqCMw?t=02h04m47s)

[sync](https://youtu.be/UlNwQ6WqCMw?t=02h04m49s)

[it's usually a recipe for confusion if](https://youtu.be/UlNwQ6WqCMw?t=02h04m50s)

[they aren't](https://youtu.be/UlNwQ6WqCMw?t=02h04m52s)

[but it is worth noting that those are](https://youtu.be/UlNwQ6WqCMw?t=02h04m53s)

[different things](https://youtu.be/UlNwQ6WqCMw?t=02h04m54s)

[so if you specify like the version tag](https://youtu.be/UlNwQ6WqCMw?t=02h04m57s)

[in your cs proj that's going to give you](https://youtu.be/UlNwQ6WqCMw?t=02h04m59s)

[something different](https://youtu.be/UlNwQ6WqCMw?t=02h05m00s)

[okay so this guy ended up with nothing](https://youtu.be/UlNwQ6WqCMw?t=02h05m02s)

[here but if i come back over here](https://youtu.be/UlNwQ6WqCMw?t=02h05m04s)

[and do a](https://youtu.be/UlNwQ6WqCMw?t=02h05m08s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h05m11s)

[dot net publish](https://youtu.be/UlNwQ6WqCMw?t=02h05m14s)

[we're gonna do a new build real quick](https://youtu.be/UlNwQ6WqCMw?t=02h05m18s)

[and then we're gonna do a](https://youtu.be/UlNwQ6WqCMw?t=02h05m24s)

[version](https://youtu.be/UlNwQ6WqCMw?t=02h05m27s)

[1.01](https://youtu.be/UlNwQ6WqCMw?t=02h05m29s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=02h05m38s)

[so you'll note now i've got the](https://youtu.be/UlNwQ6WqCMw?t=02h05m42s)

[the full version here](https://youtu.be/UlNwQ6WqCMw?t=02h05m45s)

[i assume it's building a delta package](https://youtu.be/UlNwQ6WqCMw?t=02h05m47s)

[yeah so](https://youtu.be/UlNwQ6WqCMw?t=02h05m49s)

[i've got a full 1.01 and it built a](https://youtu.be/UlNwQ6WqCMw?t=02h05m51s)

[delta package for the update and then](https://youtu.be/UlNwQ6WqCMw?t=02h05m54s)

[this releases here](https://youtu.be/UlNwQ6WqCMw?t=02h05m56s)

[will contain all of that information](https://youtu.be/UlNwQ6WqCMw?t=02h06m01s)

[so](https://youtu.be/UlNwQ6WqCMw?t=02h06m05s)

[if i run this](https://youtu.be/UlNwQ6WqCMw?t=02h06m07s)

[i expect it to do the update for me](https://youtu.be/UlNwQ6WqCMw?t=02h06m09s)

[or install the the latest update](https://youtu.be/UlNwQ6WqCMw?t=02h06m13s)

[launch](https://youtu.be/UlNwQ6WqCMw?t=02h06m16s)

[and have the version number in place](https://youtu.be/UlNwQ6WqCMw?t=02h06m20s)

[that was remarkably trivial](https://youtu.be/UlNwQ6WqCMw?t=02h06m22s)

[i i will say cloud squirrel you are](https://youtu.be/UlNwQ6WqCMw?t=02h06m26s)

[impressing me you are impressing me that](https://youtu.be/UlNwQ6WqCMw?t=02h06m28s)

[was that was remarkably easy to to get](https://youtu.be/UlNwQ6WqCMw?t=02h06m31s)

[all that bundled in](https://youtu.be/UlNwQ6WqCMw?t=02h06m34s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=02h06m36s)

[that's in and working](https://youtu.be/UlNwQ6WqCMw?t=02h06m39s)

[i would like to add an update check to](https://youtu.be/UlNwQ6WqCMw?t=02h06m45s)

[this guy](https://youtu.be/UlNwQ6WqCMw?t=02h06m48s)

[um let me go back to their docs real](https://youtu.be/UlNwQ6WqCMw?t=02h06m51s)

[quick because i do want to add in](https://youtu.be/UlNwQ6WqCMw?t=02h06m54s)

[the update check](https://youtu.be/UlNwQ6WqCMw?t=02h06m57s)

[so you need to do](https://youtu.be/UlNwQ6WqCMw?t=02h06m59s)

[this maneuver here](https://youtu.be/UlNwQ6WqCMw?t=02h07m01s)

[so that it auto updates](https://youtu.be/UlNwQ6WqCMw?t=02h07m04s)

[and maybe my controller if i'm going to](https://youtu.be/UlNwQ6WqCMw?t=02h07m11s)

[have the idea of channels](https://youtu.be/UlNwQ6WqCMw?t=02h07m13s)

[maybe i should have that part that is](https://youtu.be/UlNwQ6WqCMw?t=02h07m16s)

[part of the base url as well](https://youtu.be/UlNwQ6WqCMw?t=02h07m18s)

[so i'm just i'm just thinking here that](https://youtu.be/UlNwQ6WqCMw?t=02h07m22s)

[maybe this should actually be](https://youtu.be/UlNwQ6WqCMw?t=02h07m24s)

[channel](https://youtu.be/UlNwQ6WqCMw?t=02h07m30s)

[right](https://youtu.be/UlNwQ6WqCMw?t=02h07m33s)

[we're gonna do that for the moment we're](https://youtu.be/UlNwQ6WqCMw?t=02h07m39s)

[gonna add it just for fun](https://youtu.be/UlNwQ6WqCMw?t=02h07m40s)

[just for funsies](https://youtu.be/UlNwQ6WqCMw?t=02h07m42s)

[because i think this way i'm prepped to](https://youtu.be/UlNwQ6WqCMw?t=02h07m44s)

[have like an alpha beta release channel](https://youtu.be/UlNwQ6WqCMw?t=02h07m47s)

[and i think we'll just default it if if](https://youtu.be/UlNwQ6WqCMw?t=02h07m50s)

[unspecified](https://youtu.be/UlNwQ6WqCMw?t=02h07m52s)

[or i guess it can't be unspecified can](https://youtu.be/UlNwQ6WqCMw?t=02h07m54s)

[it because it's part of the route](https://youtu.be/UlNwQ6WqCMw?t=02h07m56s)

[not to think about that](https://youtu.be/UlNwQ6WqCMw?t=02h07m59s)

[in this case we're just going to hard](https://youtu.be/UlNwQ6WqCMw?t=02h08m01s)

[code this guy so](https://youtu.be/UlNwQ6WqCMw?t=02h08m04s)

[let's relaunch](https://youtu.be/UlNwQ6WqCMw?t=02h08m06s)

[and](https://youtu.be/UlNwQ6WqCMw?t=02h08m08s)

[i'm trying to think of the easiest way](https://youtu.be/UlNwQ6WqCMw?t=02h08m10s)

[to go about doing this](https://youtu.be/UlNwQ6WqCMw?t=02h08m11s)

[oh i just use localhost](https://youtu.be/UlNwQ6WqCMw?t=02h08m13s)

[yeah so we're just going to use](https://youtu.be/UlNwQ6WqCMw?t=02h08m22s)

[localhost](https://youtu.be/UlNwQ6WqCMw?t=02h08m23s)

[as my update ticket so in here](https://youtu.be/UlNwQ6WqCMw?t=02h08m25s)

[i think we're just going gonna do the](https://youtu.be/UlNwQ6WqCMw?t=02h08m34s)

[update check](https://youtu.be/UlNwQ6WqCMw?t=02h08m35s)

[here i think](https://youtu.be/UlNwQ6WqCMw?t=02h08m37s)

[okay so we're gonna do](https://youtu.be/UlNwQ6WqCMw?t=02h08m40s)

[that maneuver there](https://youtu.be/UlNwQ6WqCMw?t=02h08m43s)

[this](https://youtu.be/UlNwQ6WqCMw?t=02h08m47s)

[goes here](https://youtu.be/UlNwQ6WqCMw?t=02h08m48s)

[but it's also going to contain](https://youtu.be/UlNwQ6WqCMw?t=02h08m52s)

[let's see](https://youtu.be/UlNwQ6WqCMw?t=02h08m54s)

[simply](https://youtu.be/UlNwQ6WqCMw?t=02h08m56s)

[budget](https://youtu.be/UlNwQ6WqCMw?t=02h08m57s)

[slash](https://youtu.be/UlNwQ6WqCMw?t=02h08m58s)

[release](https://youtu.be/UlNwQ6WqCMw?t=02h09m00s)

[i'm wondering if release](https://youtu.be/UlNwQ6WqCMw?t=02h09m03s)

[production](https://youtu.be/UlNwQ6WqCMw?t=02h09m06s)

[is that better](https://youtu.be/UlNwQ6WqCMw?t=02h09m08s)

[okay uh this is an async method](https://youtu.be/UlNwQ6WqCMw?t=02h09m11s)

[um](https://youtu.be/UlNwQ6WqCMw?t=02h09m16s)

[yeah that's gonna be fun](https://youtu.be/UlNwQ6WqCMw?t=02h09m23s)

[you know what let's do it here on loaded](https://youtu.be/UlNwQ6WqCMw?t=02h09m29s)

[i think](https://youtu.be/UlNwQ6WqCMw?t=02h09m34s)

[i'll do it here](https://youtu.be/UlNwQ6WqCMw?t=02h09m40s)

[um](https://youtu.be/UlNwQ6WqCMw?t=02h09m42s)

[because at the end of the day i probably](https://youtu.be/UlNwQ6WqCMw?t=02h09m44s)

[want to do this](https://youtu.be/UlNwQ6WqCMw?t=02h09m46s)

[with a prompt](https://youtu.be/UlNwQ6WqCMw?t=02h09m48s)

[okay so we do that](https://youtu.be/UlNwQ6WqCMw?t=02h09m52s)

[right that](https://youtu.be/UlNwQ6WqCMw?t=02h09m56s)

[that should work now when i fire this](https://youtu.be/UlNwQ6WqCMw?t=02h09m59s)

[guy up](https://youtu.be/UlNwQ6WqCMw?t=02h10m01s)

[i expect to see a couple calls come](https://youtu.be/UlNwQ6WqCMw?t=02h10m02s)

[through](https://youtu.be/UlNwQ6WqCMw?t=02h10m05s)

[over here](https://youtu.be/UlNwQ6WqCMw?t=02h10m07s)

[one for the releases](https://youtu.be/UlNwQ6WqCMw?t=02h10m11s)

[yeah so let's](https://youtu.be/UlNwQ6WqCMw?t=02h10m19s)

[and this will be interesting because](https://youtu.be/UlNwQ6WqCMw?t=02h10m22s)

[this is going to end up redirecting out](https://youtu.be/UlNwQ6WqCMw?t=02h10m23s)

[to the github one](https://youtu.be/UlNwQ6WqCMw?t=02h10m25s)

[be curious to see what this does](https://youtu.be/UlNwQ6WqCMw?t=02h10m29s)

[yeah and they were very specific in the](https://youtu.be/UlNwQ6WqCMw?t=02h10m42s)

[directions i believe to not end your](https://youtu.be/UlNwQ6WqCMw?t=02h10m43s)

[euro with a slash if i recall correctly](https://youtu.be/UlNwQ6WqCMw?t=02h10m47s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=02h10m50s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h10m52s)

[let's see so invalid operation is only](https://youtu.be/UlNwQ6WqCMw?t=02h10m54s)

[installed](https://youtu.be/UlNwQ6WqCMw?t=02h10m56s)

[oh currently installed](https://youtu.be/UlNwQ6WqCMw?t=02h11m01s)

[they have a currently installed version](https://youtu.be/UlNwQ6WqCMw?t=02h11m04s)

[so if](https://youtu.be/UlNwQ6WqCMw?t=02h11m08s)

[mgr](https://youtu.be/UlNwQ6WqCMw?t=02h11m11s)

[is installed app](https://youtu.be/UlNwQ6WqCMw?t=02h11m14s)

[then we'll do this work](https://youtu.be/UlNwQ6WqCMw?t=02h11m20s)

[well that's really convenient](https://youtu.be/UlNwQ6WqCMw?t=02h11m23s)

[thank you what else is on you](https://youtu.be/UlNwQ6WqCMw?t=02h11m26s)

[you got any other cool apis i should](https://youtu.be/UlNwQ6WqCMw?t=02h11m29s)

[know about](https://youtu.be/UlNwQ6WqCMw?t=02h11m31s)

[let's see app directory app id](https://youtu.be/UlNwQ6WqCMw?t=02h11m35s)

[oh interesting](https://youtu.be/UlNwQ6WqCMw?t=02h11m44s)

[i almost want to](https://youtu.be/UlNwQ6WqCMw?t=02h11m49s)

[i'm sure because i almost want to use](https://youtu.be/UlNwQ6WqCMw?t=02h11m57s)

[the app id](https://youtu.be/UlNwQ6WqCMw?t=02h11m59s)

[url or path](https://youtu.be/UlNwQ6WqCMw?t=02h12m02s)

[create source](https://youtu.be/UlNwQ6WqCMw?t=02h12m05s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h12m08s)

[app id override](https://youtu.be/UlNwQ6WqCMw?t=02h12m09s)

[where does that go because i kind of](https://youtu.be/UlNwQ6WqCMw?t=02h12m12s)

[want to be able to apply it](https://youtu.be/UlNwQ6WqCMw?t=02h12m13s)

[looking at its install it's going to be](https://youtu.be/UlNwQ6WqCMw?t=02h12m20s)

[one of those chicken and the egg things](https://youtu.be/UlNwQ6WqCMw?t=02h12m22s)

[yeah because i kind of want to get](https://youtu.be/UlNwQ6WqCMw?t=02h12m30s)

[application name](https://youtu.be/UlNwQ6WqCMw?t=02h12m31s)

[to use that as part of the url](https://youtu.be/UlNwQ6WqCMw?t=02h12m37s)

[is there a way to update the](https://youtu.be/UlNwQ6WqCMw?t=02h12m40s)

[the update managers](https://youtu.be/UlNwQ6WqCMw?t=02h12m43s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h12m46s)

[yeah because i'd almost like to update](https://youtu.be/UlNwQ6WqCMw?t=02h12m54s)

[the](https://youtu.be/UlNwQ6WqCMw?t=02h12m56s)

[this location based upon](https://youtu.be/UlNwQ6WqCMw?t=02h12m57s)

[is installed app](https://youtu.be/UlNwQ6WqCMw?t=02h13m01s)

[can i call this with](https://youtu.be/UlNwQ6WqCMw?t=02h13m04s)

[url or path what does](https://youtu.be/UlNwQ6WqCMw?t=02h13m08s)

[create source get url a path for](https://youtu.be/UlNwQ6WqCMw?t=02h13m10s)

[so if it's nola white space it's going](https://youtu.be/UlNwQ6WqCMw?t=02h13m13s)

[to return null it checks if it's a](https://youtu.be/UlNwQ6WqCMw?t=02h13m15s)

[http otherwise it just does a directory](https://youtu.be/UlNwQ6WqCMw?t=02h13m18s)

[source](https://youtu.be/UlNwQ6WqCMw?t=02h13m20s)

[what happens if create source returns](https://youtu.be/UlNwQ6WqCMw?t=02h13m22s)

[null here](https://youtu.be/UlNwQ6WqCMw?t=02h13m24s)

[update source here](https://youtu.be/UlNwQ6WqCMw?t=02h13m25s)

[so i kind of want to do this](https://youtu.be/UlNwQ6WqCMw?t=02h13m31s)

[i almost want to do this so if it's](https://youtu.be/UlNwQ6WqCMw?t=02h13m36s)

[installed](https://youtu.be/UlNwQ6WqCMw?t=02h13m38s)

[using var](https://youtu.be/UlNwQ6WqCMw?t=02h13m40s)

[note](https://youtu.be/UlNwQ6WqCMw?t=02h13m43s)

[there gets new](https://youtu.be/UlNwQ6WqCMw?t=02h13m45s)

[update manager](https://youtu.be/UlNwQ6WqCMw?t=02h13m47s)

[yes i am typing behind the](https://youtu.be/UlNwQ6WqCMw?t=02h13m49s)

[thingymabobber and no i cannot see what](https://youtu.be/UlNwQ6WqCMw?t=02h13m51s)

[i'm doing](https://youtu.be/UlNwQ6WqCMw?t=02h13m53s)

[uh stop running](https://youtu.be/UlNwQ6WqCMw?t=02h13m54s)

[missed](https://youtu.be/UlNwQ6WqCMw?t=02h13m56s)

[boom](https://youtu.be/UlNwQ6WqCMw?t=02h13m58s)

[so i think i can get away with](https://youtu.be/UlNwQ6WqCMw?t=02h14m00s)

[passing null here](https://youtu.be/UlNwQ6WqCMw?t=02h14m05s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=02h14m13s)

[there that should disambiguate](https://youtu.be/UlNwQ6WqCMw?t=02h14m23s)

[and then this one here](https://youtu.be/UlNwQ6WqCMw?t=02h14m27s)

[it's going to do this](https://youtu.be/UlNwQ6WqCMw?t=02h14m30s)

[and then this is going to change here to](https://youtu.be/UlNwQ6WqCMw?t=02h14m34s)

[be](https://youtu.be/UlNwQ6WqCMw?t=02h14m37s)

[uh let's see mgr](https://youtu.be/UlNwQ6WqCMw?t=02h14m43s)

[app id](https://youtu.be/UlNwQ6WqCMw?t=02h14m46s)

[look up your app id and then use it to](https://youtu.be/UlNwQ6WqCMw?t=02h14m48s)

[do to make the remote calls out](https://youtu.be/UlNwQ6WqCMw?t=02h14m51s)

[i'm almost thinking i may roll my own](https://youtu.be/UlNwQ6WqCMw?t=02h14m55s)

[little package that wraps up some of](https://youtu.be/UlNwQ6WqCMw?t=02h14m57s)

[this stuff so that it's because i i want](https://youtu.be/UlNwQ6WqCMw?t=02h14m59s)

[getting this installer stuff](https://youtu.be/UlNwQ6WqCMw?t=02h15m02s)

[to be as dirt simple for all my wpf apps](https://youtu.be/UlNwQ6WqCMw?t=02h15m04s)

[as possible](https://youtu.be/UlNwQ6WqCMw?t=02h15m06s)

[so i kind of want to package it up and](https://youtu.be/UlNwQ6WqCMw?t=02h15m09s)

[make it pretty make it party](https://youtu.be/UlNwQ6WqCMw?t=02h15m10s)

[okay so if i fire this guy up](https://youtu.be/UlNwQ6WqCMw?t=02h15m13s)

[he should stop here](https://youtu.be/UlNwQ6WqCMw?t=02h15m19s)

[because really i'm not going to do the](https://youtu.be/UlNwQ6WqCMw?t=02h15m27s)

[hard restart of the app on the user like](https://youtu.be/UlNwQ6WqCMw?t=02h15m28s)

[that's not going to be a real thing](https://youtu.be/UlNwQ6WqCMw?t=02h15m30s)

[so it's not an installed app but i want](https://youtu.be/UlNwQ6WqCMw?t=02h15m32s)

[to make sure it's app id is](https://youtu.be/UlNwQ6WqCMw?t=02h15m34s)

[oh because it's not installed it can't](https://youtu.be/UlNwQ6WqCMw?t=02h15m39s)

[get an app id](https://youtu.be/UlNwQ6WqCMw?t=02h15m41s)

[okay so](https://youtu.be/UlNwQ6WqCMw?t=02h15m44s)

[let's do a new build](https://youtu.be/UlNwQ6WqCMw?t=02h15m46s)

[i think we can get away with](https://youtu.be/UlNwQ6WqCMw?t=02h15m54s)

[this](https://youtu.be/UlNwQ6WqCMw?t=02h15m59s)

[oh i guess not](https://youtu.be/UlNwQ6WqCMw?t=02h16m06s)

[that's the bash way of doing things](https://youtu.be/UlNwQ6WqCMw?t=02h16m08s)

[isn't it](https://youtu.be/UlNwQ6WqCMw?t=02h16m10s)

[get away with this](https://youtu.be/UlNwQ6WqCMw?t=02h16m11s)

[oh that's going to build the same](https://youtu.be/UlNwQ6WqCMw?t=02h16m16s)

[version number dang it](https://youtu.be/UlNwQ6WqCMw?t=02h16m17s)

[cancel cancel cancel cancel](https://youtu.be/UlNwQ6WqCMw?t=02h16m20s)

[two](https://youtu.be/UlNwQ6WqCMw?t=02h16m25s)

[boom](https://youtu.be/UlNwQ6WqCMw?t=02h16m26s)

[one command](https://youtu.be/UlNwQ6WqCMw?t=02h16m28s)

[that way i can just up arrow enter](https://youtu.be/UlNwQ6WqCMw?t=02h16m31s)

[and it does all the things](https://youtu.be/UlNwQ6WqCMw?t=02h16m36s)

[then](https://youtu.be/UlNwQ6WqCMw?t=02h16m43s)

[i think this helps get the the little](https://youtu.be/UlNwQ6WqCMw?t=02h16m47s)

[api set up](https://youtu.be/UlNwQ6WqCMw?t=02h16m50s)

[okay so if i go](https://youtu.be/UlNwQ6WqCMw?t=02h16m51s)

[so i should have a](https://youtu.be/UlNwQ6WqCMw?t=02h16m56s)

[desktop](https://youtu.be/UlNwQ6WqCMw?t=02h16m59s)

[app](https://youtu.be/UlNwQ6WqCMw?t=02h17m01s)

[is this the right one](https://youtu.be/UlNwQ6WqCMw?t=02h17m04s)

[open file location i just want to make](https://youtu.be/UlNwQ6WqCMw?t=02h17m08s)

[sure yeah so this is](https://youtu.be/UlNwQ6WqCMw?t=02h17m10s)

[the squirrely installer](https://youtu.be/UlNwQ6WqCMw?t=02h17m12s)

[unintended](https://youtu.be/UlNwQ6WqCMw?t=02h17m14s)

[so if i double click](https://youtu.be/UlNwQ6WqCMw?t=02h17m16s)

[this guy launches ic101](https://youtu.be/UlNwQ6WqCMw?t=02h17m20s)

[oh was my other one running](https://youtu.be/UlNwQ6WqCMw?t=02h17m26s)

[interesting it didn't hit the update](https://youtu.be/UlNwQ6WqCMw?t=02h17m30s)

[check](https://youtu.be/UlNwQ6WqCMw?t=02h17m32s)

[why not](https://youtu.be/UlNwQ6WqCMw?t=02h17m37s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=02h17m39s)

[why did you not hit the update check](https://youtu.be/UlNwQ6WqCMw?t=02h17m40s)

[was this update check not included in](https://youtu.be/UlNwQ6WqCMw?t=02h17m51s)

[the 102](https://youtu.be/UlNwQ6WqCMw?t=02h17m53s)

[might not fit or the 101 version](https://youtu.be/UlNwQ6WqCMw?t=02h17m56s)

[might not have done it i might have to](https://youtu.be/UlNwQ6WqCMw?t=02h17m59s)

[manually install 102](https://youtu.be/UlNwQ6WqCMw?t=02h18m01s)

[and then gen 103](https://youtu.be/UlNwQ6WqCMw?t=02h18m03s)

[let's let's install 102 first of all](https://youtu.be/UlNwQ6WqCMw?t=02h18m07s)

[get that going](https://youtu.be/UlNwQ6WqCMw?t=02h18m10s)

[that should install 102](https://youtu.be/UlNwQ6WqCMw?t=02h18m13s)

[we should actually be able to watch if](https://youtu.be/UlNwQ6WqCMw?t=02h18m18s)

[we look at this extension](https://youtu.be/UlNwQ6WqCMw?t=02h18m20s)

[uh let's see](https://youtu.be/UlNwQ6WqCMw?t=02h18m22s)

[file location](https://youtu.be/UlNwQ6WqCMw?t=02h18m24s)

[yeah so 102 is in now](https://youtu.be/UlNwQ6WqCMw?t=02h18m26s)

[crashing](https://youtu.be/UlNwQ6WqCMw?t=02h18m36s)

[and look at that](https://youtu.be/UlNwQ6WqCMw?t=02h18m41s)

[people could type](https://youtu.be/UlNwQ6WqCMw?t=02h18m45s)

[with name auto di and assembly oh that's](https://youtu.be/UlNwQ6WqCMw?t=02h18m47s)

[interesting](https://youtu.be/UlNwQ6WqCMw?t=02h18m50s)

[that seems to imply the build did](https://youtu.be/UlNwQ6WqCMw?t=02h18m52s)

[something weird on me](https://youtu.be/UlNwQ6WqCMw?t=02h18m55s)

[um](https://youtu.be/UlNwQ6WqCMw?t=02h18m57s)

[got that clean](https://youtu.be/UlNwQ6WqCMw?t=02h19m01s)

[our publish](https://youtu.be/UlNwQ6WqCMw?t=02h19m07s)

[we're just gonna we're gonna go up to](https://youtu.be/UlNwQ6WqCMw?t=02h19m14s)

[103 now](https://youtu.be/UlNwQ6WqCMw?t=02h19m16s)

[102 is apparently](https://youtu.be/UlNwQ6WqCMw?t=02h19m19s)

[no bueno](https://youtu.be/UlNwQ6WqCMw?t=02h19m21s)

[in retrospect i probably should have](https://youtu.be/UlNwQ6WqCMw?t=02h19m27s)

[done this with a hello world app instead](https://youtu.be/UlNwQ6WqCMw?t=02h19m28s)

[but](https://youtu.be/UlNwQ6WqCMw?t=02h19m30s)

[this is the actual app](https://youtu.be/UlNwQ6WqCMw?t=02h19m31s)

[so](https://youtu.be/UlNwQ6WqCMw?t=02h19m33s)

[when in doubt build something that you](https://youtu.be/UlNwQ6WqCMw?t=02h19m36s)

[want](https://youtu.be/UlNwQ6WqCMw?t=02h19m37s)

[okay so did you do](https://youtu.be/UlNwQ6WqCMw?t=02h19m39s)

[lunch 103](https://youtu.be/UlNwQ6WqCMw?t=02h19m42s)

[okay and i'm going to call it now](https://youtu.be/UlNwQ6WqCMw?t=02h19m44s)

[10 more minutes and then i'm gonna](https://youtu.be/UlNwQ6WqCMw?t=02h19m47s)

[call it a night](https://youtu.be/UlNwQ6WqCMw?t=02h19m50s)

[bed image format](https://youtu.be/UlNwQ6WqCMw?t=02h19m58s)

[really why is that just now rearing its](https://youtu.be/UlNwQ6WqCMw?t=02h20m02s)

[head](https://youtu.be/UlNwQ6WqCMw?t=02h20m04s)

[really what is your problem](https://youtu.be/UlNwQ6WqCMw?t=02h20m14s)

[um](https://youtu.be/UlNwQ6WqCMw?t=02h20m16s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=02h20m18s)

[oh i wonder](https://youtu.be/UlNwQ6WqCMw?t=02h20m22s)

[no that shouldn't be the cause](https://youtu.be/UlNwQ6WqCMw?t=02h20m26s)

[i'm just wondering if the delta package](https://youtu.be/UlNwQ6WqCMw?t=02h20m29s)

[is messing it up](https://youtu.be/UlNwQ6WqCMw?t=02h20m30s)

[uh so let's do](https://youtu.be/UlNwQ6WqCMw?t=02h20m36s)

[add remove programs](https://youtu.be/UlNwQ6WqCMw?t=02h20m39s)

[and](https://youtu.be/UlNwQ6WqCMw?t=02h20m42s)

[if we come in here we should be able to](https://youtu.be/UlNwQ6WqCMw?t=02h20m45s)

[do here we should be able to do an](https://youtu.be/UlNwQ6WqCMw?t=02h20m47s)

[uninstall uninstall right](https://youtu.be/UlNwQ6WqCMw?t=02h20m48s)

[i'm wondering if those delta packages](https://youtu.be/UlNwQ6WqCMw?t=02h20m52s)

[are messing me up](https://youtu.be/UlNwQ6WqCMw?t=02h20m53s)

[we're going to test that theory here](https://youtu.be/UlNwQ6WqCMw?t=02h20m56s)

[so that's gone](https://youtu.be/UlNwQ6WqCMw?t=02h21m10s)

[interesting that that didn't trigger](https://youtu.be/UlNwQ6WqCMw?t=02h21m15s)

[the removal of the shortcut](https://youtu.be/UlNwQ6WqCMw?t=02h21m18s)

[but i also may have had a another](https://youtu.be/UlNwQ6WqCMw?t=02h21m24s)

[install here prior](https://youtu.be/UlNwQ6WqCMw?t=02h21m26s)

[so that may or may not be a bug](https://youtu.be/UlNwQ6WqCMw?t=02h21m30s)

[we'll see](https://youtu.be/UlNwQ6WqCMw?t=02h21m32s)

[okay so let's try this again](https://youtu.be/UlNwQ6WqCMw?t=02h21m34s)

[and we can actually downgrade this guy](https://youtu.be/UlNwQ6WqCMw?t=02h21m38s)

[back to](https://youtu.be/UlNwQ6WqCMw?t=02h21m39s)

[a one now](https://youtu.be/UlNwQ6WqCMw?t=02h21m42s)

[because we are](https://youtu.be/UlNwQ6WqCMw?t=02h21m43s)

[starting over because i blew away that](https://youtu.be/UlNwQ6WqCMw?t=02h21m49s)

[director](https://youtu.be/UlNwQ6WqCMw?t=02h21m51s)

[so when you blow away everything in that](https://youtu.be/UlNwQ6WqCMw?t=02h21m53s)

[releases directory it's going to end up](https://youtu.be/UlNwQ6WqCMw?t=02h21m55s)

[rebuilding from that](https://youtu.be/UlNwQ6WqCMw?t=02h21m59s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=02h22m01s)

[because it appends to this file doesn't](https://youtu.be/UlNwQ6WqCMw?t=02h22m02s)

[necessarily uh](https://youtu.be/UlNwQ6WqCMw?t=02h22m04s)

[just blind over right okay](https://youtu.be/UlNwQ6WqCMw?t=02h22m08s)

[now a reinstall should get me](https://youtu.be/UlNwQ6WqCMw?t=02h22m11s)

[there's my](https://youtu.be/UlNwQ6WqCMw?t=02h22m17s)

[see properties](https://youtu.be/UlNwQ6WqCMw?t=02h22m19s)

[you're not what i want you](https://youtu.be/UlNwQ6WqCMw?t=02h22m23s)

[properties](https://youtu.be/UlNwQ6WqCMw?t=02h22m25s)

[open file location](https://youtu.be/UlNwQ6WqCMw?t=02h22m26s)

[okay so that is there](https://youtu.be/UlNwQ6WqCMw?t=02h22m29s)

[still crashing what the heck](https://youtu.be/UlNwQ6WqCMw?t=02h22m35s)

[what did we](https://youtu.be/UlNwQ6WqCMw?t=02h22m39s)

[duplicate type so it's it's added in the](https://youtu.be/UlNwQ6WqCMw?t=02h22m47s)

[type twice](https://youtu.be/UlNwQ6WqCMw?t=02h22m50s)

[huh](https://youtu.be/UlNwQ6WqCMw?t=02h22m55s)

[did a full clean on this](https://youtu.be/UlNwQ6WqCMw?t=02h22m57s)

[and it builds in debug just fine](https://youtu.be/UlNwQ6WqCMw?t=02h23m03s)

[oh i wonder if](https://youtu.be/UlNwQ6WqCMw?t=02h23m14s)

[oh publish is probably not doing a clean](https://youtu.be/UlNwQ6WqCMw?t=02h23m16s)

[rebuild](https://youtu.be/UlNwQ6WqCMw?t=02h23m18s)

[the.net clean would have forced it to](https://youtu.be/UlNwQ6WqCMw?t=02h23m22s)

[trigger that wouldn't it](https://youtu.be/UlNwQ6WqCMw?t=02h23m23s)

[we're going to manually build this guy](https://youtu.be/UlNwQ6WqCMw?t=02h23m27s)

[give me all of your stuff rebuild all](https://youtu.be/UlNwQ6WqCMw?t=02h23m31s)

[successful](https://youtu.be/UlNwQ6WqCMw?t=02h23m33s)

[just make sure this thing launches from](https://youtu.be/UlNwQ6WqCMw?t=02h23m34s)

[visual studio and release mode](https://youtu.be/UlNwQ6WqCMw?t=02h23m36s)

[great](https://youtu.be/UlNwQ6WqCMw?t=02h23m49s)

[um](https://youtu.be/UlNwQ6WqCMw?t=02h23m50s)

[okay so now we run](https://youtu.be/UlNwQ6WqCMw?t=02h23m52s)

[blow away the](https://youtu.be/UlNwQ6WqCMw?t=02h24m01s)

[blow in the publish directory](https://youtu.be/UlNwQ6WqCMw?t=02h24m08s)

[i i kind of want to just fire this up](https://youtu.be/UlNwQ6WqCMw?t=02h24m18s)

[real quick to make sure that the publish](https://youtu.be/UlNwQ6WqCMw?t=02h24m20s)

[directory version](https://youtu.be/UlNwQ6WqCMw?t=02h24m22s)

[launches because it should](https://youtu.be/UlNwQ6WqCMw?t=02h24m26s)

[it does great](https://youtu.be/UlNwQ6WqCMw?t=02h24m30s)

[and then we are going to](https://youtu.be/UlNwQ6WqCMw?t=02h24m35s)

[reinstall](https://youtu.be/UlNwQ6WqCMw?t=02h24m44s)

[i think i actually want to do](https://youtu.be/UlNwQ6WqCMw?t=02h24m46s)

[add remove programs again](https://youtu.be/UlNwQ6WqCMw?t=02h24m49s)

[blow this away](https://youtu.be/UlNwQ6WqCMw?t=02h24m56s)

[there we go](https://youtu.be/UlNwQ6WqCMw?t=02h25m05s)

[he's gone](https://youtu.be/UlNwQ6WqCMw?t=02h25m07s)

[flagged as dead](https://youtu.be/UlNwQ6WqCMw?t=02h25m11s)

[which isn't exactly shocking](https://youtu.be/UlNwQ6WqCMw?t=02h25m13s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=02h25m17s)

[it's interesting to me that this desktop](https://youtu.be/UlNwQ6WqCMw?t=02h25m21s)

[icon doesn't appear to be dying but okay](https://youtu.be/UlNwQ6WqCMw?t=02h25m24s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=02h25m29s)

[i'm going to reinstall from the](https://youtu.be/UlNwQ6WqCMw?t=02h25m32s)

[releases directory](https://youtu.be/UlNwQ6WqCMw?t=02h25m35s)

[and you launch](https://youtu.be/UlNwQ6WqCMw?t=02h25m41s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=02h25m50s)

[that was weird](https://youtu.be/UlNwQ6WqCMw?t=02h25m52s)

[i think in the clean rebuild from visual](https://youtu.be/UlNwQ6WqCMw?t=02h25m54s)

[studio health](https://youtu.be/UlNwQ6WqCMw?t=02h25m56s)

[okay so that works](https://youtu.be/UlNwQ6WqCMw?t=02h25m57s)

[when it restarted](https://youtu.be/UlNwQ6WqCMw?t=02h26m01s)

[did it not hit my](https://youtu.be/UlNwQ6WqCMw?t=02h26m07s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h26m16s)

[or it either restarted or crashed](https://youtu.be/UlNwQ6WqCMw?t=02h26m20s)

[response code does not indicate success](https://youtu.be/UlNwQ6WqCMw?t=02h26m30s)

[oh lovely so it uh](https://youtu.be/UlNwQ6WqCMw?t=02h26m32s)

[it it auto dies if it gets a 404](https://youtu.be/UlNwQ6WqCMw?t=02h26m37s)

[so let's check what](https://youtu.be/UlNwQ6WqCMw?t=02h26m42s)

[let's look at what it is using](https://youtu.be/UlNwQ6WqCMw?t=02h26m49s)

[okay so we should see](https://youtu.be/UlNwQ6WqCMw?t=02h26m56s)

[i'm going to fire up the app just from](https://youtu.be/UlNwQ6WqCMw?t=02h26m59s)

[the desktop shortcut](https://youtu.be/UlNwQ6WqCMw?t=02h27m01s)

[we should see it come through here so](https://youtu.be/UlNwQ6WqCMw?t=02h27m03s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=02h27m06s)

[also which i it does a bunch](https://youtu.be/UlNwQ6WqCMw?t=02h27m09s)

[okay](https://youtu.be/UlNwQ6WqCMw?t=02h27m13s)

[so it is going through and](https://youtu.be/UlNwQ6WqCMw?t=02h27m15s)

[calling localhost simply budget](https://youtu.be/UlNwQ6WqCMw?t=02h27m20s)

[production releases](https://youtu.be/UlNwQ6WqCMw?t=02h27m22s)

[oh so it's actually passing in quite a](https://youtu.be/UlNwQ6WqCMw?t=02h27m29s)

[bit](https://youtu.be/UlNwQ6WqCMw?t=02h27m31s)

[i didn't realize it would pass all this](https://youtu.be/UlNwQ6WqCMw?t=02h27m34s)

[stuff as query parameters](https://youtu.be/UlNwQ6WqCMw?t=02h27m36s)

[that is interesting i'm trying to decide](https://youtu.be/UlNwQ6WqCMw?t=02h27m47s)

[if i like that or not i](https://youtu.be/UlNwQ6WqCMw?t=02h27m50s)

[we could use those query parameters to](https://youtu.be/UlNwQ6WqCMw?t=02h27m53s)

[do something extra](https://youtu.be/UlNwQ6WqCMw?t=02h27m55s)

[it's interesting that i see both upper](https://youtu.be/UlNwQ6WqCMw?t=02h27m58s)

[and lower case](https://youtu.be/UlNwQ6WqCMw?t=02h28m00s)

[i wonder if that's just a fallback](https://youtu.be/UlNwQ6WqCMw?t=02h28m03s)

[mechanism](https://youtu.be/UlNwQ6WqCMw?t=02h28m04s)

[to try to account for things that may or](https://youtu.be/UlNwQ6WqCMw?t=02h28m06s)

[may not handle uh casein very well](https://youtu.be/UlNwQ6WqCMw?t=02h28m07s)

[that is interesting](https://youtu.be/UlNwQ6WqCMw?t=02h28m12s)

[but this should have still worked](https://youtu.be/UlNwQ6WqCMw?t=02h28m14s)

[copy just the url](https://youtu.be/UlNwQ6WqCMw?t=02h28m19s)

[so](https://youtu.be/UlNwQ6WqCMw?t=02h28m21s)

[just let's do a different tab so we'll](https://youtu.be/UlNwQ6WqCMw?t=02h28m22s)

[make you bigger](https://youtu.be/UlNwQ6WqCMw?t=02h28m24s)

[and book web request](https://youtu.be/UlNwQ6WqCMw?t=02h28m26s)

[oh this is](https://youtu.be/UlNwQ6WqCMw?t=02h28m38s)

[404 so it's not resolving](https://youtu.be/UlNwQ6WqCMw?t=02h28m46s)

[i guess we didn't actually test this](https://youtu.be/UlNwQ6WqCMw?t=02h28m52s)

[with the channel name](https://youtu.be/UlNwQ6WqCMw?t=02h28m54s)

[in place did we](https://youtu.be/UlNwQ6WqCMw?t=02h28m56s)

[oh is it does it have squirrel in there](https://youtu.be/UlNwQ6WqCMw?t=02h29m08s)

[[Music]](https://youtu.be/UlNwQ6WqCMw?t=02h29m11s)

[does not](https://youtu.be/UlNwQ6WqCMw?t=02h29m13s)

[okay so that's the other so it's missing](https://youtu.be/UlNwQ6WqCMw?t=02h29m14s)

[squirrel](https://youtu.be/UlNwQ6WqCMw?t=02h29m16s)

[uh so let's add that in real quick](https://youtu.be/UlNwQ6WqCMw?t=02h29m18s)

[id](https://youtu.be/UlNwQ6WqCMw?t=02h29m31s)

[channel](https://youtu.be/UlNwQ6WqCMw?t=02h29m32s)

[let's do](https://youtu.be/UlNwQ6WqCMw?t=02h29m34s)

[talk stream](https://youtu.be/UlNwQ6WqCMw?t=02h29m35s)

[channel](https://youtu.be/UlNwQ6WqCMw?t=02h29m36s)

[i'm just going to break this out so it's](https://youtu.be/UlNwQ6WqCMw?t=02h29m41s)

[clear what that little bit is](https://youtu.be/UlNwQ6WqCMw?t=02h29m43s)

[like an assigned meaning to that string](https://youtu.be/UlNwQ6WqCMw?t=02h29m46s)

[we will i will get rid of some of my](https://youtu.be/UlNwQ6WqCMw?t=02h29m49s)

[my hard-coded ids okay so](https://youtu.be/UlNwQ6WqCMw?t=02h29m52s)

[and then](https://youtu.be/UlNwQ6WqCMw?t=02h29m57s)

[i'm going to rebuild this](https://youtu.be/UlNwQ6WqCMw?t=02h29m58s)

[apparently if i don't rebuild it doesn't](https://youtu.be/UlNwQ6WqCMw?t=02h30m00s)

[do what i expect](https://youtu.be/UlNwQ6WqCMw?t=02h30m02s)

[okay so from here we're going to need to](https://youtu.be/UlNwQ6WqCMw?t=02h30m06s)

[do](https://youtu.be/UlNwQ6WqCMw?t=02h30m09s)

[do 101 and i'll just force the i'll](https://youtu.be/UlNwQ6WqCMw?t=02h30m12s)

[force the install update to happen](https://youtu.be/UlNwQ6WqCMw?t=02h30m15s)

[that's one of the nice parts about this](https://youtu.be/UlNwQ6WqCMw?t=02h30m19s)

[is if something does go wrong like you](https://youtu.be/UlNwQ6WqCMw?t=02h30m20s)

[release a bug in your code](https://youtu.be/UlNwQ6WqCMw?t=02h30m22s)

[just running the newer installer](https://youtu.be/UlNwQ6WqCMw?t=02h30m24s)

[fixes it](https://youtu.be/UlNwQ6WqCMw?t=02h30m27s)

[simply by the fact of the](https://youtu.be/UlNwQ6WqCMw?t=02h30m28s)

[the installer comes with the latest and](https://youtu.be/UlNwQ6WqCMw?t=02h30m30s)

[greatest version baked with it](https://youtu.be/UlNwQ6WqCMw?t=02h30m33s)

[so](https://youtu.be/UlNwQ6WqCMw?t=02h30m37s)

[this guy here you'll note that it is no](https://youtu.be/UlNwQ6WqCMw?t=02h30m39s)

[coincidence that this setup is just](https://youtu.be/UlNwQ6WqCMw?t=02h30m41s)

[slightly larger than this](https://youtu.be/UlNwQ6WqCMw?t=02h30m44s)

[it's because this guy get the latest one](https://youtu.be/UlNwQ6WqCMw?t=02h30m48s)

[gets bundled into the setup exe so if](https://youtu.be/UlNwQ6WqCMw?t=02h30m50s)

[you were to just slap this guy on a](https://youtu.be/UlNwQ6WqCMw?t=02h30m52s)

[thumb drive you could sneak or net it](https://youtu.be/UlNwQ6WqCMw?t=02h30m54s)

[around or whatever](https://youtu.be/UlNwQ6WqCMw?t=02h30m56s)

[so we're gonna force the update](https://youtu.be/UlNwQ6WqCMw?t=02h30m57s)

[to 101 here](https://youtu.be/UlNwQ6WqCMw?t=02h30m59s)

[so you saw the 101 switch out there and](https://youtu.be/UlNwQ6WqCMw?t=02h31m04s)

[then this should fire up](https://youtu.be/UlNwQ6WqCMw?t=02h31m06s)

[we are on the latest version](https://youtu.be/UlNwQ6WqCMw?t=02h31m11s)

[something is happening we are crashing](https://youtu.be/UlNwQ6WqCMw?t=02h31m14s)

[now let's do this](https://youtu.be/UlNwQ6WqCMw?t=02h31m18s)

[kill that](https://youtu.be/UlNwQ6WqCMw?t=02h31m20s)

[launch the app oh on](https://youtu.be/UlNwQ6WqCMw?t=02h31m23s)

[and let's take a quick look at what it's](https://youtu.be/UlNwQ6WqCMw?t=02h31m27s)

[doing](https://youtu.be/UlNwQ6WqCMw?t=02h31m28s)

[okay so that's better](https://youtu.be/UlNwQ6WqCMw?t=02h31m31s)

[this copy just url](https://youtu.be/UlNwQ6WqCMw?t=02h31m34s)

[i'm over here](https://youtu.be/UlNwQ6WqCMw?t=02h31m38s)

[that is still hitting a 404](https://youtu.be/UlNwQ6WqCMw?t=02h31m50s)

[because i should have tested this](https://youtu.be/UlNwQ6WqCMw?t=02h31m53s)

[i do wrong](https://youtu.be/UlNwQ6WqCMw?t=02h32m00s)

[what did i do wrong on this](https://youtu.be/UlNwQ6WqCMw?t=02h32m02s)

[the budget](https://youtu.be/UlNwQ6WqCMw?t=02h32m16s)

[production](https://youtu.be/UlNwQ6WqCMw?t=02h32m19s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h32m21s)

[releases](https://youtu.be/UlNwQ6WqCMw?t=02h32m21s)

[that hits so that's convenient so i did](https://youtu.be/UlNwQ6WqCMw?t=02h32m25s)

[something right](https://youtu.be/UlNwQ6WqCMw?t=02h32m28s)

[uh okay so this is what it was supposed](https://youtu.be/UlNwQ6WqCMw?t=02h32m30s)

[to do](https://youtu.be/UlNwQ6WqCMw?t=02h32m33s)

[and what it actually did was](https://youtu.be/UlNwQ6WqCMw?t=02h32m37s)

[that](https://youtu.be/UlNwQ6WqCMw?t=02h32m42s)

[oh interesting so because it's got the](https://youtu.be/UlNwQ6WqCMw?t=02h32m47s)

[query parameters on there](https://youtu.be/UlNwQ6WqCMw?t=02h32m50s)

[interesting i wonder how i tell](https://youtu.be/UlNwQ6WqCMw?t=02h32m55s)

[e-net](https://youtu.be/UlNwQ6WqCMw?t=02h33m01s)

[or](https://youtu.be/UlNwQ6WqCMw?t=02h33m02s)

[normal](https://youtu.be/UlNwQ6WqCMw?t=02h33m04s)

[how do i](https://youtu.be/UlNwQ6WqCMw?t=02h33m12s)

[i i just want to tell it no](https://youtu.be/UlNwQ6WqCMw?t=02h33m18s)

[so what you're looking at](https://youtu.be/UlNwQ6WqCMw?t=02h33m33s)

[but i i don't](https://youtu.be/UlNwQ6WqCMw?t=02h33m35s)

[use routing](https://youtu.be/UlNwQ6WqCMw?t=02h33m42s)

[yeah i i want to i want to say i don't](https://youtu.be/UlNwQ6WqCMw?t=02h33m45s)

[care what the parameters are](https://youtu.be/UlNwQ6WqCMw?t=02h33m49s)

[can i just do on my template](https://youtu.be/UlNwQ6WqCMw?t=02h34m01s)

[something akin to](https://youtu.be/UlNwQ6WqCMw?t=02h34m05s)

[that](https://youtu.be/UlNwQ6WqCMw?t=02h34m09s)

[just ignore it](https://youtu.be/UlNwQ6WqCMw?t=02h34m14s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h34m19s)

[the literal question is in](https://youtu.be/UlNwQ6WqCMw?t=02h34m20s)

[our name route templates no](https://youtu.be/UlNwQ6WqCMw?t=02h34m23s)

[um](https://youtu.be/UlNwQ6WqCMw?t=02h34m27s)

[let's see](https://youtu.be/UlNwQ6WqCMw?t=02h34m34s)

[usually right compare terminal](https://youtu.be/UlNwQ6WqCMw?t=02h34m38s)

[middleware](https://youtu.be/UlNwQ6WqCMw?t=02h34m41s)

[i don't really want to have to do](https://youtu.be/UlNwQ6WqCMw?t=02h34m42s)

[something overly fancy](https://youtu.be/UlNwQ6WqCMw?t=02h34m43s)

[oh route template precedence](https://youtu.be/UlNwQ6WqCMw?t=02h34m50s)

[that's fine](https://youtu.be/UlNwQ6WqCMw?t=02h35m00s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h35m04s)

[that's not what i want](https://youtu.be/UlNwQ6WqCMw?t=02h35m05s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h35m07s)

[route](https://youtu.be/UlNwQ6WqCMw?t=02h35m09s)

[template](https://youtu.be/UlNwQ6WqCMw?t=02h35m12s)

[can i just do](https://youtu.be/UlNwQ6WqCMw?t=02h35m30s)

[that](https://youtu.be/UlNwQ6WqCMw?t=02h35m33s)

[or](https://youtu.be/UlNwQ6WqCMw?t=02h35m40s)

[just the route name](https://youtu.be/UlNwQ6WqCMw?t=02h35m44s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h35m46s)

[i do that](https://youtu.be/UlNwQ6WqCMw?t=02h35m53s)

[is it is that the syntax for optional](https://youtu.be/UlNwQ6WqCMw?t=02h35m55s)

[uh the optional priority](https://youtu.be/UlNwQ6WqCMw?t=02h36m00s)

[only a period can precede an optional](https://youtu.be/UlNwQ6WqCMw?t=02h36m04s)

[parameter](https://youtu.be/UlNwQ6WqCMw?t=02h36m06s)

[that's not quite what i'm thinking](https://youtu.be/UlNwQ6WqCMw?t=02h36m12s)

[how do i route you how do i rush](https://youtu.be/UlNwQ6WqCMw?t=02h36m24s)

[well i did say i was gonna wrap it up](https://youtu.be/UlNwQ6WqCMw?t=02h36m29s)

[here so maybe this is a good point and i](https://youtu.be/UlNwQ6WqCMw?t=02h36m31s)

[will](https://youtu.be/UlNwQ6WqCMw?t=02h36m33s)

[figure out how to](https://youtu.be/UlNwQ6WqCMw?t=02h36m36s)

[do this routing](https://youtu.be/UlNwQ6WqCMw?t=02h36m39s)

[because i think it is fairly close](https://youtu.be/UlNwQ6WqCMw?t=02h36m41s)

[like i said i do want to get something](https://youtu.be/UlNwQ6WqCMw?t=02h36m44s)

[put together such that there's a sample](https://youtu.be/UlNwQ6WqCMw?t=02h36m45s)

[and all of that jazz so if anyone finds](https://youtu.be/UlNwQ6WqCMw?t=02h36m48s)

[this interesting and wants to check it](https://youtu.be/UlNwQ6WqCMw?t=02h36m50s)

[out i will say from my perspective cloud](https://youtu.be/UlNwQ6WqCMw?t=02h36m53s)

[squirrel it's pretty nice](https://youtu.be/UlNwQ6WqCMw?t=02h36m56s)

[it seems really nice](https://youtu.be/UlNwQ6WqCMw?t=02h36m59s)

[um aside from the few kind of minor](https://youtu.be/UlNwQ6WqCMw?t=02h37m01s)

[hiccups i ran into it works as](https://youtu.be/UlNwQ6WqCMw?t=02h37m03s)

[advertised so if you're looking for an](https://youtu.be/UlNwQ6WqCMw?t=02h37m05s)

[installer for](https://youtu.be/UlNwQ6WqCMw?t=02h37m08s)

[your wpf app i'd highly encourage you to](https://youtu.be/UlNwQ6WqCMw?t=02h37m09s)

[take a look at it especially if you just](https://youtu.be/UlNwQ6WqCMw?t=02h37m11s)

[want to host it in github like i said](https://youtu.be/UlNwQ6WqCMw?t=02h37m13s)

[they do have a very easy way if you want](https://youtu.be/UlNwQ6WqCMw?t=02h37m15s)

[to just use the github file system um](https://youtu.be/UlNwQ6WqCMw?t=02h37m19s)

[i didn't try it myself but there so far](https://youtu.be/UlNwQ6WqCMw?t=02h37m22s)

[their docs have been on point everywhere](https://youtu.be/UlNwQ6WqCMw?t=02h37m24s)

[else so give it a shot](https://youtu.be/UlNwQ6WqCMw?t=02h37m26s)

[uh](https://youtu.be/UlNwQ6WqCMw?t=02h37m28s)

[justin bieber everyone else thanks for](https://youtu.be/UlNwQ6WqCMw?t=02h37m29s)

[hanging out see everyone next time](https://youtu.be/UlNwQ6WqCMw?t=02h37m31s)

[you](https://youtu.be/UlNwQ6WqCMw?t=02h37m51s)

