[YouTube Video](https://youtu.be/HyJJX6FFdpA)



[hello everybody Welcome back Uh tonight](https://youtu.be/HyJJX6FFdpA?t=00h00m02s)

[we've got some a couple really exciting](https://youtu.be/HyJJX6FFdpA?t=00h00m04s)

[things So first of all there is a new](https://youtu.be/HyJJX6FFdpA?t=00h00m06s)

[Git Kraken release that makes me very](https://youtu.be/HyJJX6FFdpA?t=00h00m08s)

[very excited It has new AI stuff It has](https://youtu.be/HyJJX6FFdpA?t=00h00m10s)

[new features and I am tickled to death](https://youtu.be/HyJJX6FFdpA?t=00h00m14s)

[So we're going to take a look at that I](https://youtu.be/HyJJX6FFdpA?t=00h00m16s)

[want to continue poking at my T-Unit](https://youtu.be/HyJJX6FFdpA?t=00h00m19s)

[stuff in material design Uh get a few](https://youtu.be/HyJJX6FFdpA?t=00h00m21s)

[PRs merged Probably leverage a little](https://youtu.be/HyJJX6FFdpA?t=00h00m23s)

[more co-pilot It's been mildly helpful](https://youtu.be/HyJJX6FFdpA?t=00h00m25s)

[usefulish but you know we're going to](https://youtu.be/HyJJX6FFdpA?t=00h00m28s)

[see how it goes Uh so let us dive in So](https://youtu.be/HyJJX6FFdpA?t=00h00m30s)

[let's see here I go click and I go click](https://youtu.be/HyJJX6FFdpA?t=00h00m34s)

[and I go okay so here is the new Kraken](https://youtu.be/HyJJX6FFdpA?t=00h00m37s)

[So the key thing here and if I go to the](https://youtu.be/HyJJX6FFdpA?t=00h00m40s)

[other side right is going to be this](https://youtu.be/HyJJX6FFdpA?t=00h00m42s)

[little version down here right You're](https://youtu.be/HyJJX6FFdpA?t=00h00m44s)

[looking for 11.2.0](https://youtu.be/HyJJX6FFdpA?t=00h00m45s)

[is the magical incantation So uh if you](https://youtu.be/HyJJX6FFdpA?t=00h00m47s)

[wondering what version you want that's](https://youtu.be/HyJJX6FFdpA?t=00h00m51s)

[the one If you don't see it check for](https://youtu.be/HyJJX6FFdpA?t=00h00m53s)

[updates get new updates etc So the big](https://youtu.be/HyJJX6FFdpA?t=00h00m55s)

[the big the big guy here right AI](https://youtu.be/HyJJX6FFdpA?t=00h00m58s)

[powered merge conflict resolution right](https://youtu.be/HyJJX6FFdpA?t=00h01m01s)

[Like this is gold Absolute gold I my](https://youtu.be/HyJJX6FFdpA?t=00h01m04s)

[opinion one of the hardest things to](https://youtu.be/HyJJX6FFdpA?t=00h01m08s)

[deal with is conflict resolution inside](https://youtu.be/HyJJX6FFdpA?t=00h01m10s)

[of um git and source control I've](https://youtu.be/HyJJX6FFdpA?t=00h01m13s)

[mentioned before I think Jet Brains](https://youtu.be/HyJJX6FFdpA?t=00h01m17s)

[Writer might have one of the nicest ones](https://youtu.be/HyJJX6FFdpA?t=00h01m20s)

[fornet only because it's a little more](https://youtu.be/HyJJX6FFdpA?t=00h01m22s)

[intelligent about the language So it](https://youtu.be/HyJJX6FFdpA?t=00h01m24s)

[does something a little better than just](https://youtu.be/HyJJX6FFdpA?t=00h01m27s)

[the regular um textbased uh merge that](https://youtu.be/HyJJX6FFdpA?t=00h01m28s)

[most Git tools have but it can cheat](https://youtu.be/HyJJX6FFdpA?t=00h01m32s)

[because it's got a language model to](https://youtu.be/HyJJX6FFdpA?t=00h01m35s)

[play with and and can do that kind of](https://youtu.be/HyJJX6FFdpA?t=00h01m36s)

[thing Um but being able to try to](https://youtu.be/HyJJX6FFdpA?t=00h01m38s)

[leverage this with AI is kind of](https://youtu.be/HyJJX6FFdpA?t=00h01m41s)

[exciting Now I haven't had a lot of](https://youtu.be/HyJJX6FFdpA?t=00h01m44s)

[opportunity to play with it It seems](https://youtu.be/HyJJX6FFdpA?t=00h01m46s)

[decent with my limited experience We](https://youtu.be/HyJJX6FFdpA?t=00h01m48s)

[might play with it more tonight We'll](https://youtu.be/HyJJX6FFdpA?t=00h01m50s)

[see how many uh how many errors and](https://youtu.be/HyJJX6FFdpA?t=00h01m51s)

[rebase problems we run into It might be](https://youtu.be/HyJJX6FFdpA?t=00h01m54s)

[uh a nice little thing to to play with](https://youtu.be/HyJJX6FFdpA?t=00h01m56s)

[Uh the other big one here is reverting](https://youtu.be/HyJJX6FFdpA?t=00h01m59s)

[individual hunks from the diff view So](https://youtu.be/HyJJX6FFdpA?t=00h02m02s)

[if you realize oh shoot you know I](https://youtu.be/HyJJX6FFdpA?t=00h02m05s)

[committed that debug line didn't mean to](https://youtu.be/HyJJX6FFdpA?t=00h02m07s)

[do it in that file you often don't want](https://youtu.be/HyJJX6FFdpA?t=00h02m09s)

[to revert the whole file you just want](https://youtu.be/HyJJX6FFdpA?t=00h02m11s)

[to revert that one part And so uh that](https://youtu.be/HyJJX6FFdpA?t=00h02m13s)

[is new and awesome uh as a way of just](https://youtu.be/HyJJX6FFdpA?t=00h02m17s)

[kind of being able to go uh backwards](https://youtu.be/HyJJX6FFdpA?t=00h02m19s)

[which is which is absolutely gold Uh](https://youtu.be/HyJJX6FFdpA?t=00h02m22s)

[this one down here also makes me really](https://youtu.be/HyJJX6FFdpA?t=00h02m25s)

[excited The the cache of the AI](https://youtu.be/HyJJX6FFdpA?t=00h02m27s)

[explanations it was really annoying like](https://youtu.be/HyJJX6FFdpA?t=00h02m29s)

[if I hit explain on multiple commits](https://youtu.be/HyJJX6FFdpA?t=00h02m32s)

[having to toggle back and forth between](https://youtu.be/HyJJX6FFdpA?t=00h02m34s)

[them like that just doesn't it doesn't](https://youtu.be/HyJJX6FFdpA?t=00h02m36s)

[feel good Like you end up having to](https://youtu.be/HyJJX6FFdpA?t=00h02m38s)

[rehit the explain again And so now it at](https://youtu.be/HyJJX6FFdpA?t=00h02m40s)

[least maintains the last five which is a](https://youtu.be/HyJJX6FFdpA?t=00h02m42s)

[lot nicer Um to be able to just leverage](https://youtu.be/HyJJX6FFdpA?t=00h02m44s)

[that which I'm I'm tickled to death](https://youtu.be/HyJJX6FFdpA?t=00h02m47s)

[about that And then you know prettier](https://youtu.be/HyJJX6FFdpA?t=00h02m50s)

[buttons yada yada yada which is which is](https://youtu.be/HyJJX6FFdpA?t=00h02m52s)

[cool Um and then a handful of other nice](https://youtu.be/HyJJX6FFdpA?t=00h02m55s)

[features that I don't care that much](https://youtu.be/HyJJX6FFdpA?t=00h02m58s)

[about Um one that I'm going to point out](https://youtu.be/HyJJX6FFdpA?t=00h02m59s)

[down here and this is something that I](https://youtu.be/HyJJX6FFdpA?t=00h03m02s)

[am actively testing and messaging get](https://youtu.be/HyJJX6FFdpA?t=00h03m04s)

[cracking back and forth on they have an](https://youtu.be/HyJJX6FFdpA?t=00h03m08s)

[MCP server However if you are on Windows](https://youtu.be/HyJJX6FFdpA?t=00h03m10s)

[just be aware it doesn't quite play very](https://youtu.be/HyJJX6FFdpA?t=00h03m14s)

[nice So I have had a lot of issues](https://youtu.be/HyJJX6FFdpA?t=00h03m18s)

[getting it to uh not crash And once it](https://youtu.be/HyJJX6FFdpA?t=00h03m23s)

[starts it it's like the instance of the](https://youtu.be/HyJJX6FFdpA?t=00h03m26s)

[CLI that is running the MCP uh blocks](https://youtu.be/HyJJX6FFdpA?t=00h03m29s)

[other instances and so you end up not](https://youtu.be/HyJJX6FFdpA?t=00h03m32s)

[being able to use the Git Kraken CLI](https://youtu.be/HyJJX6FFdpA?t=00h03m34s)

[once you have it started as an MCP](https://youtu.be/HyJJX6FFdpA?t=00h03m37s)

[server which is kind of annoying Um but](https://youtu.be/HyJJX6FFdpA?t=00h03m39s)

[something that is actively being worked](https://youtu.be/HyJJX6FFdpA?t=00h03m42s)

[on and if you are a not on Windows um or](https://youtu.be/HyJJX6FFdpA?t=00h03m44s)

[b just interested to play around with it](https://youtu.be/HyJJX6FFdpA?t=00h03m48s)

[it is a very nice CLI to work with So uh](https://youtu.be/HyJJX6FFdpA?t=00h03m50s)

[that is 112 in a nutshell Um as always](https://youtu.be/HyJJX6FFdpA?t=00h03m54s)

[the video is pretty good The video is](https://youtu.be/HyJJX6FFdpA?t=00h03m58s)

[pretty good So definitely worth a watch](https://youtu.be/HyJJX6FFdpA?t=00h04m00s)

[It's like 6 minutes or something Um and](https://youtu.be/HyJJX6FFdpA?t=00h04m03s)

[absolutely worth our time Okay so](https://youtu.be/HyJJX6FFdpA?t=00h04m06s)

[material design T-Unit we got we got](https://youtu.be/HyJJX6FFdpA?t=00h04m08s)

[some stuff There's some PRs that are](https://youtu.be/HyJJX6FFdpA?t=00h04m11s)

[outstanding and I'm tempted to just](https://youtu.be/HyJJX6FFdpA?t=00h04m13s)

[assign co-pilot to go review them One of](https://youtu.be/HyJJX6FFdpA?t=00h04m15s)

[them we may go and look at but I wanted](https://youtu.be/HyJJX6FFdpA?t=00h04m17s)

[to try to get some of these things](https://youtu.be/HyJJX6FFdpA?t=00h04m19s)

[figured out here So the password box](https://youtu.be/HyJJX6FFdpA?t=00h04m21s)

[test here Um](https://youtu.be/HyJJX6FFdpA?t=00h04m23s)

[oh and there's actually something even](https://youtu.be/HyJJX6FFdpA?t=00h04m28s)

[more exciting So I'll tip my hand a](https://youtu.be/HyJJX6FFdpA?t=00h04m30s)

[little bit There is So several streams](https://youtu.be/HyJJX6FFdpA?t=00h04m31s)

[ago I nerd sniped one of my colleagues](https://youtu.be/HyJJX6FFdpA?t=00h04m34s)

[cuz I made a comment that it would be](https://youtu.be/HyJJX6FFdpA?t=00h04m37s)

[really great if after a test failure](https://youtu.be/HyJJX6FFdpA?t=00h04m39s)

[like this I had a build artifact that](https://youtu.be/HyJJX6FFdpA?t=00h04m43s)

[was just a Visual Studio playlist file](https://youtu.be/HyJJX6FFdpA?t=00h04m45s)

[of the failed test that I could download](https://youtu.be/HyJJX6FFdpA?t=00h04m47s)

[and run because more often than not what](https://youtu.be/HyJJX6FFdpA?t=00h04m49s)

[I want to do is run run the test this](https://youtu.be/HyJJX6FFdpA?t=00h04m53s)

[the failing test to see what's wrong and](https://youtu.be/HyJJX6FFdpA?t=00h04m57s)

[fix them locally](https://youtu.be/HyJJX6FFdpA?t=00h04m59s)

[and I have completely nerd sniped uh him](https://youtu.be/HyJJX6FFdpA?t=00h05m01s)

[into building it for me This concerns me](https://youtu.be/HyJJX6FFdpA?t=00h05m06s)

[a little bit that it shows a test count](https://youtu.be/HyJJX6FFdpA?t=00h05m08s)

[of six That does not make me feel warm](https://youtu.be/HyJJX6FFdpA?t=00h05m10s)

[and fuzzy That makes me feel very](https://youtu.be/HyJJX6FFdpA?t=00h05m13s)

[unhappy and not warm and fuzzy And why](https://youtu.be/HyJJX6FFdpA?t=00h05m16s)

[do I not have](https://youtu.be/HyJJX6FFdpA?t=00h05m19s)

[a build artifact Did I not upload a](https://youtu.be/HyJJX6FFdpA?t=00h05m22s)

[build artifact](https://youtu.be/HyJJX6FFdpA?t=00h05m24s)

[Upload screenshots](https://youtu.be/HyJJX6FFdpA?t=00h05m27s)

[No files were found](https://youtu.be/HyJJX6FFdpA?t=00h05m29s)

[Really](https://youtu.be/HyJJX6FFdpA?t=00h05m33s)

[That seems](https://youtu.be/HyJJX6FFdpA?t=00h05m35s)

[very unlikely Let's just go and search](https://youtu.be/HyJJX6FFdpA?t=00h05m37s)

[the logs real quick because I have a](https://youtu.be/HyJJX6FFdpA?t=00h05m41s)

[strange suspicion that that is a lie](https://youtu.be/HyJJX6FFdpA?t=00h05m43s)

[Where is the Oh I actually want to](https://youtu.be/HyJJX6FFdpA?t=00h05m49s)

[search logs here](https://youtu.be/HyJJX6FFdpA?t=00h05m51s)

[because](https://youtu.be/HyJJX6FFdpA?t=00h05m54s)

[No you're telling me there's no other](https://youtu.be/HyJJX6FFdpA?t=00h05m58s)

[usage of the word screenshots but those](https://youtu.be/HyJJX6FFdpA?t=00h06m00s)

[three](https://youtu.be/HyJJX6FFdpA?t=00h06m02s)

[Something's off Something something is](https://youtu.be/HyJJX6FFdpA?t=00h06m04s)

[up](https://youtu.be/HyJJX6FFdpA?t=00h06m07s)

[because this is Let's see here CA](https://youtu.be/HyJJX6FFdpA?t=00h06m09s)

[material design toolkit test UI bin](https://youtu.be/HyJJX6FFdpA?t=00h06m13s)

[release blah blah blah And this is](https://youtu.be/HyJJX6FFdpA?t=00h06m16s)

[looking in](https://youtu.be/HyJJX6FFdpA?t=00h06m18s)

[Oh I guess I got to scroll now](https://youtu.be/HyJJX6FFdpA?t=00h06m20s)

[Material design materials](https://youtu.be/HyJJX6FFdpA?t=00h06m24s)

[Oh I see the bug See there's no slash](https://youtu.be/HyJJX6FFdpA?t=00h06m27s)

[there](https://youtu.be/HyJJX6FFdpA?t=00h06m31s)

[That is annoying beyond belief So let's](https://youtu.be/HyJJX6FFdpA?t=00h06m33s)

[go here How long has that been broken](https://youtu.be/HyJJX6FFdpA?t=00h06m36s)

[Let's see So let's see Upload](https://youtu.be/HyJJX6FFdpA?t=00h06m42s)

[screenshots](https://youtu.be/HyJJX6FFdpA?t=00h06m44s)

[Um](https://youtu.be/HyJJX6FFdpA?t=00h06m46s)

[ooh](https://youtu.be/HyJJX6FFdpA?t=00h06m48s)

[GitHub workspace doesn't include a](https://youtu.be/HyJJX6FFdpA?t=00h06m50s)

[trailing slash anymore](https://youtu.be/HyJJX6FFdpA?t=00h06m52s)

[That's shocking to me](https://youtu.be/HyJJX6FFdpA?t=00h06m56s)

[Am I using GitHub workspace anywhere](https://youtu.be/HyJJX6FFdpA?t=00h07m01s)

[else](https://youtu.be/HyJJX6FFdpA?t=00h07m03s)

[No that's the only usage of it](https://youtu.be/HyJJX6FFdpA?t=00h07m09s)

[Okay Well we're going to we're going to](https://youtu.be/HyJJX6FFdpA?t=00h07m13s)

[fix that and send that really quick](https://youtu.be/HyJJX6FFdpA?t=00h07m15s)

[because](https://youtu.be/HyJJX6FFdpA?t=00h07m17s)

[uh yeah write the commit message for me](https://youtu.be/HyJJX6FFdpA?t=00h07m18s)

[See the new the new pretty one This is a](https://youtu.be/HyJJX6FFdpA?t=00h07m21s)

[lot of text um for something that is not](https://youtu.be/HyJJX6FFdpA?t=00h07m23s)

[a lot of text worthy](https://youtu.be/HyJJX6FFdpA?t=00h07m27s)

[I need to I need to reprompt Oh that's](https://youtu.be/HyJJX6FFdpA?t=00h07m29s)

[something else that's that was subtly](https://youtu.be/HyJJX6FFdpA?t=00h07m31s)

[snuck in um to this release So](https://youtu.be/HyJJX6FFdpA?t=00h07m33s)

[underneath file preferences if you check](https://youtu.be/HyJJX6FFdpA?t=00h07m36s)

[out the the Git Kraken AI the you'll see](https://youtu.be/HyJJX6FFdpA?t=00h07m39s)

[that there are um extra bits here for uh](https://youtu.be/HyJJX6FFdpA?t=00h07m43s)

[additional instructions I mean they go](https://youtu.be/HyJJX6FFdpA?t=00h07m48s)

[along with the other features but it's](https://youtu.be/HyJJX6FFdpA?t=00h07m50s)

[worth knowing that those are in there as](https://youtu.be/HyJJX6FFdpA?t=00h07m52s)

[well](https://youtu.be/HyJJX6FFdpA?t=00h07m53s)

[ju just to make them a little bit nicer](https://youtu.be/HyJJX6FFdpA?t=00h07m55s)

[A little bit nicer Okay so that'll kick](https://youtu.be/HyJJX6FFdpA?t=00h07m58s)

[that off Um I want to know](https://youtu.be/HyJJX6FFdpA?t=00h08m00s)

[what is go like why am I h I I don't](https://youtu.be/HyJJX6FFdpA?t=00h08m05s)

[understand why I'm having so many](https://youtu.be/HyJJX6FFdpA?t=00h08m08s)

[problems with this thing running](https://youtu.be/HyJJX6FFdpA?t=00h08m09s)

[Kind of want to cancel the execution of](https://youtu.be/HyJJX6FFdpA?t=00h08m14s)

[this](https://youtu.be/HyJJX6FFdpA?t=00h08m16s)

[Oh stop moving my mouse I want to cancel](https://youtu.be/HyJJX6FFdpA?t=00h08m18s)

[Stop Okay thank you Okay so I want to](https://youtu.be/HyJJX6FFdpA?t=00h08m20s)

[get down to password box](https://youtu.be/HyJJX6FFdpA?t=00h08m24s)

[uh run these tests by themselves please](https://youtu.be/HyJJX6FFdpA?t=00h08m28s)

[Cuz it claims that there's failures in](https://youtu.be/HyJJX6FFdpA?t=00h08m36s)

[here So let's find them Let's find them](https://youtu.be/HyJJX6FFdpA?t=00h08m38s)

[So I am realizing I did just tell it to](https://youtu.be/HyJJX6FFdpA?t=00h08m45s)

[run 44 tests Um for those people](https://youtu.be/HyJJX6FFdpA?t=00h08m47s)

[interested uh I know I teased it on a](https://youtu.be/HyJJX6FFdpA?t=00h08m50s)

[prior stream as well but today was](https://youtu.be/HyJJX6FFdpA?t=00h08m52s)

[actually the day of the GitHub uh global](https://youtu.be/HyJJX6FFdpA?t=00h08m54s)

[boot camp that we were hosting at](https://youtu.be/HyJJX6FFdpA?t=00h08m57s)

[Intellletch I spent the last three hours](https://youtu.be/HyJJX6FFdpA?t=00h08m59s)

[talking so hopefully my voice holds out](https://youtu.be/HyJJX6FFdpA?t=00h09m02s)

[tonight That'd be really cool if it did](https://youtu.be/HyJJX6FFdpA?t=00h09m04s)

[Um but covering a lot of co-pilot stuff](https://youtu.be/HyJJX6FFdpA?t=00h09m06s)

[It wasn't uh streamed on YouTube but I](https://youtu.be/HyJJX6FFdpA?t=00h09m09s)

[think and don't hold me to this but I](https://youtu.be/HyJJX6FFdpA?t=00h09m13s)

[think we're planning on posting um a](https://youtu.be/HyJJX6FFdpA?t=00h09m15s)

[recording at some point So if you watch](https://youtu.be/HyJJX6FFdpA?t=00h09m18s)

[the Intelllettech YouTube channel you](https://youtu.be/HyJJX6FFdpA?t=00h09m20s)

[will probably see it there Um if you are](https://youtu.be/HyJJX6FFdpA?t=00h09m22s)

[at all interested in GitHub Copilot it](https://youtu.be/HyJJX6FFdpA?t=00h09m24s)

[is very worthwhile Uh the goal was to](https://youtu.be/HyJJX6FFdpA?t=00h09m27s)

[take people who had limited experience](https://youtu.be/HyJJX6FFdpA?t=00h09m30s)

[with it and get them all the way up to](https://youtu.be/HyJJX6FFdpA?t=00h09m32s)

[speed for being very productive because](https://youtu.be/HyJJX6FFdpA?t=00h09m35s)

[I think it is a very valuable tool Okay](https://youtu.be/HyJJX6FFdpA?t=00h09m37s)

[36 failed Well the good news is we at](https://youtu.be/HyJJX6FFdpA?t=00h09m41s)

[least see the failures Okay so uh they](https://youtu.be/HyJJX6FFdpA?t=00h09m45s)

[there's a whole bunch in the data driven](https://youtu.be/HyJJX6FFdpA?t=00h09m49s)

[test So let's see expect math abs be](https://youtu.be/HyJJX6FFdpA?t=00h09m51s)

[between](https://youtu.be/HyJJX6FFdpA?t=00h09m54s)

[uh but received zero](https://youtu.be/HyJJX6FFdpA?t=00h09m56s)

[Well let's take a look](https://youtu.be/HyJJX6FFdpA?t=00h10m00s)

[Um](https://youtu.be/HyJJX6FFdpA?t=00h10m03s)

[so the problem is is I wrote this is](https://youtu.be/HyJJX6FFdpA?t=00h10m11s)

[between method and now I'm trying to](https://youtu.be/HyJJX6FFdpA?t=00h10m13s)

[remember if this is an inclusive lower](https://youtu.be/HyJJX6FFdpA?t=00h10m14s)

[bound and I'm realizing I should have](https://youtu.be/HyJJX6FFdpA?t=00h10m18s)

[probably written it to be a little more](https://youtu.be/HyJJX6FFdpA?t=00h10m19s)

[exact](https://youtu.be/HyJJX6FFdpA?t=00h10m22s)

[because what is um](https://youtu.be/HyJJX6FFdpA?t=00h10m25s)

[is it expected to be inclusive](https://youtu.be/HyJJX6FFdpA?t=00h10m29s)

[Uh let's see if uh oh I have the choice](https://youtu.be/HyJJX6FFdpA?t=00h10m33s)

[inclusive or exclusive](https://youtu.be/HyJJX6FFdpA?t=00h10m37s)

[That's cool So I wrote it nicely No I](https://youtu.be/HyJJX6FFdpA?t=00h10m41s)

[didn't This isn't mine This is](https://youtu.be/HyJJX6FFdpA?t=00h10m43s)

[this isn't mine](https://youtu.be/HyJJX6FFdpA?t=00h10m48s)

[Yeah This is tunit extensions So is](https://youtu.be/HyJJX6FFdpA?t=00h10m51s)

[between how do you set](https://youtu.be/HyJJX6FFdpA?t=00h10m53s)

[the exclusive or exclusive](https://youtu.be/HyJJX6FFdpA?t=00h10m57s)

[Um](https://youtu.be/HyJJX6FFdpA?t=00h11m01s)

[because it has the between assert](https://youtu.be/HyJJX6FFdpA?t=00h11m04s)

[condition](https://youtu.be/HyJJX6FFdpA?t=00h11m06s)

[Do not populate this value Do not](https://youtu.be/HyJJX6FFdpA?t=00h11m08s)

[populate this value Yeah Um](https://youtu.be/HyJJX6FFdpA?t=00h11m11s)

[Oh you're supposed to do Oh I got you I](https://youtu.be/HyJJX6FFdpA?t=00h11m16s)

[got you So it wants So this is an](https://youtu.be/HyJJX6FFdpA?t=00h11m19s)

[exclusive range and these ones Oh I see](https://youtu.be/HyJJX6FFdpA?t=00h11m22s)

[So this is probably just a logic error](https://youtu.be/HyJJX6FFdpA?t=00h11m27s)

[right So we expect Let's just read this](https://youtu.be/HyJJX6FFdpA?t=00h11m29s)

[Password uh respects padding](https://youtu.be/HyJJX6FFdpA?t=00h11m33s)

[Yes So](https://youtu.be/HyJJX6FFdpA?t=00h11m37s)

[uh with inclusive bounds So that's](https://youtu.be/HyJJX6FFdpA?t=00h11m39s)

[that's what we're looking for Um](https://youtu.be/HyJJX6FFdpA?t=00h11m42s)

[and then this thing](https://youtu.be/HyJJX6FFdpA?t=00h11m46s)

[uh let's see](https://youtu.be/HyJJX6FFdpA?t=00h11m48s)

[Does text field is a play It slightly](https://youtu.be/HyJJX6FFdpA?t=00h11m51s)

[modifies the hint placement Okay got it](https://youtu.be/HyJJX6FFdpA?t=00h11m53s)

[Got it Got it Got it Got it Got it Okay](https://youtu.be/HyJJX6FFdpA?t=00h11m56s)

[so that one's there And I wonder if the](https://youtu.be/HyJJX6FFdpA?t=00h11m57s)

[other one's basically the same thing I](https://youtu.be/HyJJX6FFdpA?t=00h11m59s)

[think it is because I think these were](https://youtu.be/HyJJX6FFdpA?t=00h12m01s)

[written at the exact same time](https://youtu.be/HyJJX6FFdpA?t=00h12m03s)

[Yeah I think that is exactly the problem](https://youtu.be/HyJJX6FFdpA?t=00h12m06s)

[Okay with inclusive bounds](https://youtu.be/HyJJX6FFdpA?t=00h12m09s)

[With inclusive bounds that gets me to](https://youtu.be/HyJJX6FFdpA?t=00h12m14s)

[there That gets me to there Okay So now](https://youtu.be/HyJJX6FFdpA?t=00h12m16s)

[if I rerun these tests here I should get](https://youtu.be/HyJJX6FFdpA?t=00h12m19s)

[success](https://youtu.be/HyJJX6FFdpA?t=00h12m23s)

[and we'll see if that gets us any any](https://youtu.be/HyJJX6FFdpA?t=00h12m28s)

[closer](https://youtu.be/HyJJX6FFdpA?t=00h12m31s)

[Oh my thing is launching on the other](https://youtu.be/HyJJX6FFdpA?t=00h12m34s)

[side](https://youtu.be/HyJJX6FFdpA?t=00h12m36s)

[There we go I my click may have messed](https://youtu.be/HyJJX6FFdpA?t=00h12m40s)

[it up but we'll see](https://youtu.be/HyJJX6FFdpA?t=00h12m43s)

[I am actually surprised that this thing](https://youtu.be/HyJJX6FFdpA?t=00h12m46s)

[um is set up to spin a separate window](https://youtu.be/HyJJX6FFdpA?t=00h12m50s)

[for each of these There's um when using](https://youtu.be/HyJJX6FFdpA?t=00h12m52s)

[XUnit for these tests it is somewhat](https://youtu.be/HyJJX6FFdpA?t=00h12m56s)

[expensive if you start fresh every time](https://youtu.be/HyJJX6FFdpA?t=00h12m58s)

[because it has to spin a whole new WPF](https://youtu.be/HyJJX6FFdpA?t=00h13m01s)

[app create a whole new window So there's](https://youtu.be/HyJJX6FFdpA?t=00h13m03s)

[a a nice performance optimization If you](https://youtu.be/HyJJX6FFdpA?t=00h13m06s)

[know that the test that you're writing](https://youtu.be/HyJJX6FFdpA?t=00h13m09s)

[doesn't require anything static like in](https://youtu.be/HyJJX6FFdpA?t=00h13m10s)

[the app.zaml level or similar that](https://youtu.be/HyJJX6FFdpA?t=00h13m13s)

[you're mcking with there's no reason to](https://youtu.be/HyJJX6FFdpA?t=00h13m15s)

[restart the whole app You can go through](https://youtu.be/HyJJX6FFdpA?t=00h13m17s)

[and spin it This one here I'm guessing](https://youtu.be/HyJJX6FFdpA?t=00h13m20s)

[it's one app and spinning windows Oh](https://youtu.be/HyJJX6FFdpA?t=00h13m22s)

[Mini 4G thanks for the sub I appreciate](https://youtu.be/HyJJX6FFdpA?t=00h13m25s)

[it](https://youtu.be/HyJJX6FFdpA?t=00h13m28s)

[Um and so if when it spins if it spins a](https://youtu.be/HyJJX6FFdpA?t=00h13m29s)

[whole new window a window is cheaper](https://youtu.be/HyJJX6FFdpA?t=00h13m33s)

[than an app but it's not free And so](https://youtu.be/HyJJX6FFdpA?t=00h13m36s)

[it's actually cheaper to Here we go All](https://youtu.be/HyJJX6FFdpA?t=00h13m38s)

[green on the password box test Uh so](https://youtu.be/HyJJX6FFdpA?t=00h13m41s)

[it's actually cheaper to go through and](https://youtu.be/HyJJX6FFdpA?t=00h13m44s)

[uh just leverage the same window and](https://youtu.be/HyJJX6FFdpA?t=00h13m46s)

[swap the contents But I have a suspicion](https://youtu.be/HyJJX6FFdpA?t=00h13m50s)

[that the way these things are written](https://youtu.be/HyJJX6FFdpA?t=00h13m52s)

[Yeah it's using my uh or that one's not](https://youtu.be/HyJJX6FFdpA?t=00h13m55s)

[Where is it](https://youtu.be/HyJJX6FFdpA?t=00h13m58s)

[Where is it These ones down here Um but](https://youtu.be/HyJJX6FFdpA?t=00h14m01s)

[so they're using the shared app uh but](https://youtu.be/HyJJX6FFdpA?t=00h14m03s)

[not a shared window because this load](https://youtu.be/HyJJX6FFdpA?t=00h14m06s)

[ZAML spins a new window every time So if](https://youtu.be/HyJJX6FFdpA?t=00h14m08s)

[I was overly concerned with the](https://youtu.be/HyJJX6FFdpA?t=00h14m11s)

[execution time of these because you'll](https://youtu.be/HyJJX6FFdpA?t=00h14m12s)

[note this took over a minute The](https://youtu.be/HyJJX6FFdpA?t=00h14m14s)

[simplest way to speed this up is to give](https://youtu.be/HyJJX6FFdpA?t=00h14m16s)

[them a shared window and just reuse the](https://youtu.be/HyJJX6FFdpA?t=00h14m18s)

[same window every time since I know that](https://youtu.be/HyJJX6FFdpA?t=00h14m21s)

[these tests are not dependent on](https://youtu.be/HyJJX6FFdpA?t=00h14m23s)

[anything in the window itself They're](https://youtu.be/HyJJX6FFdpA?t=00h14m26s)

[only testing the individual content of](https://youtu.be/HyJJX6FFdpA?t=00h14m28s)

[it and then just swap the content So at](https://youtu.be/HyJJX6FFdpA?t=00h14m30s)

[some point I plan on going through and](https://youtu.be/HyJJX6FFdpA?t=00h14m33s)

[cleaning up um these tests because I](https://youtu.be/HyJJX6FFdpA?t=00h14m35s)

[think there's a lot of tests that I](https://youtu.be/HyJJX6FFdpA?t=00h14m38s)

[could optimize that way but we'll we'll](https://youtu.be/HyJJX6FFdpA?t=00h14m40s)

[circle back to it because really it](https://youtu.be/HyJJX6FFdpA?t=00h14m42s)

[comes down to this test base here Um](https://youtu.be/HyJJX6FFdpA?t=00h14m43s)

[it maintains a consistent app so that we](https://youtu.be/HyJJX6FFdpA?t=00h14m48s)

[uh at least once per class we don't have](https://youtu.be/HyJJX6FFdpA?t=00h14m51s)

[to spin a new one every time Um though I](https://youtu.be/HyJJX6FFdpA?t=00h14m53s)

[am this is before test and I'm wondering](https://youtu.be/HyJJX6FFdpA?t=00h14m56s)

[if this is running more than the other](https://youtu.be/HyJJX6FFdpA?t=00h15m00s)

[one did Regardless this sort of setup is](https://youtu.be/HyJJX6FFdpA?t=00h15m02s)

[what ends up uh spinning up either that](https://youtu.be/HyJJX6FFdpA?t=00h15m05s)

[app or window And so if we wanted to](https://youtu.be/HyJJX6FFdpA?t=00h15m08s)

[have a shared window this would be where](https://youtu.be/HyJJX6FFdpA?t=00h15m09s)

[the the change would need to go in Okay](https://youtu.be/HyJJX6FFdpA?t=00h15m11s)

[so that handles that Um](https://youtu.be/HyJJX6FFdpA?t=00h15m14s)

[let me go back to my output window Let's](https://youtu.be/HyJJX6FFdpA?t=00h15m18s)

[take a quick gander at the other any](https://youtu.be/HyJJX6FFdpA?t=00h15m21s)

[other failed classes because we know](https://youtu.be/HyJJX6FFdpA?t=00h15m24s)

[there's that one](https://youtu.be/HyJJX6FFdpA?t=00h15m27s)

[This is all okay So textbox test shows](https://youtu.be/HyJJX6FFdpA?t=00h15m29s)

[another failure](https://youtu.be/HyJJX6FFdpA?t=00h15m32s)

[Let's go with](https://youtu.be/HyJJX6FFdpA?t=00h15m34s)

[uh](https://youtu.be/HyJJX6FFdpA?t=00h15m36s)

[textbox tests and let's run these ones](https://youtu.be/HyJJX6FFdpA?t=00h15m38s)

[and see what we come up with This is why](https://youtu.be/HyJJX6FFdpA?t=00h15m41s)

[I want that playlist file Like it would](https://youtu.be/HyJJX6FFdpA?t=00h15m43s)

[be very nice to just download a playlist](https://youtu.be/HyJJX6FFdpA?t=00h15m44s)

[of the failing tests and hit run against](https://youtu.be/HyJJX6FFdpA?t=00h15m47s)

[it So um I told my colleague what I](https://youtu.be/HyJJX6FFdpA?t=00h15m50s)

[would do is uh bring him on to the](https://youtu.be/HyJJX6FFdpA?t=00h15m52s)

[stream and he can show off his cool new](https://youtu.be/HyJJX6FFdpA?t=00h15m55s)

[stuff cuz I I think it'll be pretty](https://youtu.be/HyJJX6FFdpA?t=00h15m58s)

[slick Like it's it's one of those things](https://youtu.be/HyJJX6FFdpA?t=00h16m00s)

[The playlist file isn't something that](https://youtu.be/HyJJX6FFdpA?t=00h16m02s)

[there's like an open spec for so he had](https://youtu.be/HyJJX6FFdpA?t=00h16m04s)

[to reverse engineer it but it's also not](https://youtu.be/HyJJX6FFdpA?t=00h16m06s)

[a complicated looking one I don't think](https://youtu.be/HyJJX6FFdpA?t=00h16m09s)

[But he spent a lot of time digging into](https://youtu.be/HyJJX6FFdpA?t=00h16m12s)

[it and so I I think it'll end up being](https://youtu.be/HyJJX6FFdpA?t=00h16m15s)

[quite interesting](https://youtu.be/HyJJX6FFdpA?t=00h16m18s)

[Interesting Fact that this window here](https://youtu.be/HyJJX6FFdpA?t=00h16m23s)

[is hanging is](https://youtu.be/HyJJX6FFdpA?t=00h16m25s)

[concerning to me](https://youtu.be/HyJJX6FFdpA?t=00h16m28s)

[I'm guessing this is going to be the](https://youtu.be/HyJJX6FFdpA?t=00h16m31s)

[test failure](https://youtu.be/HyJJX6FFdpA?t=00h16m32s)

[I click Does that make it happier](https://youtu.be/HyJJX6FFdpA?t=00h16m38s)

[Not at a break point is it](https://youtu.be/HyJJX6FFdpA?t=00h16m41s)

[Doesn't look like it but it certainly](https://youtu.be/HyJJX6FFdpA?t=00h16m49s)

[looks like a hang Let's kill it for the](https://youtu.be/HyJJX6FFdpA?t=00h16m52s)

[moment because we already have a couple](https://youtu.be/HyJJX6FFdpA?t=00h16m55s)

[failures that we can go and dig into So](https://youtu.be/HyJJX6FFdpA?t=00h16m56s)

[I think this is probably another one](https://youtu.be/HyJJX6FFdpA?t=00h16m59s)

[that has that same Yeah exclusive range](https://youtu.be/HyJJX6FFdpA?t=00h17m00s)

[These are probably just need um](https://youtu.be/HyJJX6FFdpA?t=00h17m03s)

[with inclusive bounds with inclusive](https://youtu.be/HyJJX6FFdpA?t=00h17m07s)

[bounds](https://youtu.be/HyJJX6FFdpA?t=00h17m09s)

[I'm guessing we're going to see a bunch](https://youtu.be/HyJJX6FFdpA?t=00h17m11s)

[of these](https://youtu.be/HyJJX6FFdpA?t=00h17m12s)

[um because I don't think when I did the](https://youtu.be/HyJJX6FFdpA?t=00h17m14s)

[replacement for the is between I took](https://youtu.be/HyJJX6FFdpA?t=00h17m16s)

[that into account So thank you Copilot](https://youtu.be/HyJJX6FFdpA?t=00h17m18s)

[Uh thank you Oh I wanted to check one](https://youtu.be/HyJJX6FFdpA?t=00h17m22s)

[thing So tools options Visual Studio So](https://youtu.be/HyJJX6FFdpA?t=00h17m25s)

[if you haven't updated Visual Studio you](https://youtu.be/HyJJX6FFdpA?t=00h17m28s)

[should do so Um there's this cool new](https://youtu.be/HyJJX6FFdpA?t=00h17m30s)

[co-pilot consumptions window And yes I](https://youtu.be/HyJJX6FFdpA?t=00h17m33s)

[have log debug report Oh this one](https://youtu.be/HyJJX6FFdpA?t=00h17m35s)

[actually shows a usage for me my other](https://youtu.be/HyJJX6FFdpA?t=00h17m37s)

[machine it shows zero which I found](https://youtu.be/HyJJX6FFdpA?t=00h17m40s)

[laughable because I clearly have used it](https://youtu.be/HyJJX6FFdpA?t=00h17m43s)

[a lot more than zero](https://youtu.be/HyJJX6FFdpA?t=00h17m45s)

[Um but you actually get a consumptions](https://youtu.be/HyJJX6FFdpA?t=00h17m47s)

[window which is a nice one to be able to](https://youtu.be/HyJJX6FFdpA?t=00h17m49s)

[do Um and if you go into the options](https://youtu.be/HyJJX6FFdpA?t=00h17m51s)

[here I want the next edit suggestions](https://youtu.be/HyJJX6FFdpA?t=00h17m55s)

[I want to set the completions model and](https://youtu.be/HyJJX6FFdpA?t=00h17m59s)

[I want to enable adaptive paste This is](https://youtu.be/HyJJX6FFdpA?t=00h18m02s)

[this is one of the ones that um excites](https://youtu.be/HyJJX6FFdpA?t=00h18m05s)

[me the most from the latest Visual](https://youtu.be/HyJJX6FFdpA?t=00h18m07s)

[Studio one If we go file what's the](https://youtu.be/HyJJX6FFdpA?t=00h18m09s)

[release notes in here Release notes](https://youtu.be/HyJJX6FFdpA?t=00h18m12s)

[[Music]](https://youtu.be/HyJJX6FFdpA?t=00h18m15s)

[Studio 2022 release notes](https://youtu.be/HyJJX6FFdpA?t=00h18m18s)

[Uh adaptive paste So this is one that um](https://youtu.be/HyJJX6FFdpA?t=00h18m21s)

[and for anybody who wants to uh follow](https://youtu.be/HyJJX6FFdpA?t=00h18m26s)

[along at home there's the link Um but](https://youtu.be/HyJJX6FFdpA?t=00h18m28s)

[this is one of the things that's](https://youtu.be/HyJJX6FFdpA?t=00h18m32s)

[actually one of those nice little](https://youtu.be/HyJJX6FFdpA?t=00h18m33s)

[predictive things that I think will be](https://youtu.be/HyJJX6FFdpA?t=00h18m35s)

[really great is when copying and pasting](https://youtu.be/HyJJX6FFdpA?t=00h18m37s)

[code you often have to make extra](https://youtu.be/HyJJX6FFdpA?t=00h18m40s)

[changes after you paste it in This is](https://youtu.be/HyJJX6FFdpA?t=00h18m43s)

[leveraging uh copilot to try to do that](https://youtu.be/HyJJX6FFdpA?t=00h18m46s)

[for you on a paste operation Now I'm](https://youtu.be/HyJJX6FFdpA?t=00h18m49s)

[curious how much it causes me pain and](https://youtu.be/HyJJX6FFdpA?t=00h18m52s)

[suffering versus how much it works well](https://youtu.be/HyJJX6FFdpA?t=00h18m55s)

[But like there's a reason I run preview](https://youtu.be/HyJJX6FFdpA?t=00h18m58s)

[builds of Visual Studio Um I want to try](https://youtu.be/HyJJX6FFdpA?t=00h19m00s)

[the new stuff as soon as possible and so](https://youtu.be/HyJJX6FFdpA?t=00h19m03s)

[we are going to do it This is another](https://youtu.be/HyJJX6FFdpA?t=00h19m06s)

[cool one down here is before this not](https://youtu.be/HyJJX6FFdpA?t=00h19m08s)

[implemented solution Now the quick](https://youtu.be/HyJJX6FFdpA?t=00h19m10s)

[actions just has an implement with](https://youtu.be/HyJJX6FFdpA?t=00h19m12s)

[copilot Right So now that's convenient](https://youtu.be/HyJJX6FFdpA?t=00h19m14s)

[but it's not overly shocking right Like](https://youtu.be/HyJJX6FFdpA?t=00h19m18s)

[the all I would do before is delete the](https://youtu.be/HyJJX6FFdpA?t=00h19m22s)

[throw and prompt copilot with like](https://youtu.be/HyJJX6FFdpA?t=00h19m24s)

[inline chat or something to implement it](https://youtu.be/HyJJX6FFdpA?t=00h19m26s)

[And now there's just a quick action for](https://youtu.be/HyJJX6FFdpA?t=00h19m28s)

[it So it's like that's cool It's not](https://youtu.be/HyJJX6FFdpA?t=00h19m30s)

[doing like it's saving me a little time](https://youtu.be/HyJJX6FFdpA?t=00h19m33s)

[but it's not doing anything fancy that I](https://youtu.be/HyJJX6FFdpA?t=00h19m35s)

[couldn't have done myself a moment ago](https://youtu.be/HyJJX6FFdpA?t=00h19m37s)

[Okay so we're going to run these two](https://youtu.be/HyJJX6FFdpA?t=00h19m39s)

[tests now that we fixed that inclusive](https://youtu.be/HyJJX6FFdpA?t=00h19m41s)

[bounds](https://youtu.be/HyJJX6FFdpA?t=00h19m42s)

[And I think that'll get those two](https://youtu.be/HyJJX6FFdpA?t=00h19m45s)

[running And then we're going to rerun](https://youtu.be/HyJJX6FFdpA?t=00h19m47s)

[the other test Um Oh uh because I killed](https://youtu.be/HyJJX6FFdpA?t=00h19m48s)

[it this file has it locked We will](https://youtu.be/HyJJX6FFdpA?t=00h19m52s)

[unlock that file And hopefully it takes](https://youtu.be/HyJJX6FFdpA?t=00h19m55s)

[off here in a second Yeah Yeah Yeah I](https://youtu.be/HyJJX6FFdpA?t=00h19m57s)

[understand The file was locked You](https://youtu.be/HyJJX6FFdpA?t=00h19m59s)

[wrapped yourself around the axle You](https://youtu.be/HyJJX6FFdpA?t=00h20m01s)

[don't like it anymore I get it I get it](https://youtu.be/HyJJX6FFdpA?t=00h20m04s)

[Um I'm a little surprised that that](https://youtu.be/HyJJX6FFdpA?t=00h20m07s)

[process didn't kill it](https://youtu.be/HyJJX6FFdpA?t=00h20m09s)

[Yeah that process is hung](https://youtu.be/HyJJX6FFdpA?t=00h20m13s)

[So the the ZAML test host process](https://youtu.be/HyJJX6FFdpA?t=00h20m17s)

[actually watches the um the unit test](https://youtu.be/HyJJX6FFdpA?t=00h20m20s)

[process and it will kill itself if it](https://youtu.be/HyJJX6FFdpA?t=00h20m23s)

[detects the unit test process is dead](https://youtu.be/HyJJX6FFdpA?t=00h20m28s)

[The the hard part there is it doesn't](https://youtu.be/HyJJX6FFdpA?t=00h20m30s)

[know whether unit tests are running or](https://youtu.be/HyJJX6FFdpA?t=00h20m32s)

[not It only knows whether the unit test](https://youtu.be/HyJJX6FFdpA?t=00h20m34s)

[process is still alive And because](https://youtu.be/HyJJX6FFdpA?t=00h20m37s)

[Visual Studio will oftenimes keep the](https://youtu.be/HyJJX6FFdpA?t=00h20m39s)

[test host process alive there's it can](https://youtu.be/HyJJX6FFdpA?t=00h20m41s)

[sometimes not realize that it needs to](https://youtu.be/HyJJX6FFdpA?t=00h20m45s)

[terminate itself when it really should](https://youtu.be/HyJJX6FFdpA?t=00h20m48s)

[Okay so this one here I think is the](https://youtu.be/HyJJX6FFdpA?t=00h20m52s)

[basically the exact same test as the](https://youtu.be/HyJJX6FFdpA?t=00h20m55s)

[combo box](https://youtu.be/HyJJX6FFdpA?t=00h20m58s)

[And in fact we should probably just hunt](https://youtu.be/HyJJX6FFdpA?t=00h21m01s)

[out and see because I'm trying to think](https://youtu.be/HyJJX6FFdpA?t=00h21m03s)

[combo box text box password box](https://youtu.be/HyJJX6FFdpA?t=00h21m06s)

[The fourth one in there I think](https://youtu.be/HyJJX6FFdpA?t=00h21m11s)

[the type of input boxes there that I'm](https://youtu.be/HyJJX6FFdpA?t=00h21m14s)

[forgetting about Rich text box maybe Um](https://youtu.be/HyJJX6FFdpA?t=00h21m16s)

[but I think if we just hunt](https://youtu.be/HyJJX6FFdpA?t=00h21m20s)

[this we can probably find them all](https://youtu.be/HyJJX6FFdpA?t=00h21m23s)

[because all of these tests were I](https://youtu.be/HyJJX6FFdpA?t=00h21m27s)

[believe written at the exact same time](https://youtu.be/HyJJX6FFdpA?t=00h21m29s)

[combo box test I believe we already](https://youtu.be/HyJJX6FFdpA?t=00h21m32s)

[fixed Nope So we didn't So](https://youtu.be/HyJJX6FFdpA?t=00h21m35s)

[with inclusive bounds So we're just](https://youtu.be/HyJJX6FFdpA?t=00h21m39s)

[going to do all of these really quick](https://youtu.be/HyJJX6FFdpA?t=00h21m41s)

[because I suspect they all need the same](https://youtu.be/HyJJX6FFdpA?t=00h21m43s)

[change because they're all effectively](https://youtu.be/HyJJX6FFdpA?t=00h21m47s)

[uh doing the exact same thing Hey](https://youtu.be/HyJJX6FFdpA?t=00h21m49s)

[Copilot Thank you See I didn't even have](https://youtu.be/HyJJX6FFdpA?t=00h21m51s)

[to tell it what I wanted I just had to](https://youtu.be/HyJJX6FFdpA?t=00h21m55s)

[yell its name That's that's how powerful](https://youtu.be/HyJJX6FFdpA?t=00h21m56s)

[it is](https://youtu.be/HyJJX6FFdpA?t=00h21m59s)

[That is sarcastic for those people who](https://youtu.be/HyJJX6FFdpA?t=00h22m01s)

[are unable Oh date picker That's a good](https://youtu.be/HyJJX6FFdpA?t=00h22m03s)

[one I forgot about that one Let's do](https://youtu.be/HyJJX6FFdpA?t=00h22m05s)

[date picker Thank you](https://youtu.be/HyJJX6FFdpA?t=00h22m08s)

[Figure it out Copilot There's your hint](https://youtu.be/HyJJX6FFdpA?t=00h22m11s)

[Saw I saw you I saw you do it late You](https://youtu.be/HyJJX6FFdpA?t=00h22m13s)

[were too slow You got to be faster than](https://youtu.be/HyJJX6FFdpA?t=00h22m15s)

[that co-pilot I I cannot afford to wait](https://youtu.be/HyJJX6FFdpA?t=00h22m16s)

[for you You are way too slow for me Come](https://youtu.be/HyJJX6FFdpA?t=00h22m19s)

[on figure it out Three two one Okay I'm](https://youtu.be/HyJJX6FFdpA?t=00h22m21s)

[typing cuz darn it I'm the real](https://youtu.be/HyJJX6FFdpA?t=00h22m24s)

[developer You're just](https://youtu.be/HyJJX6FFdpA?t=00h22m26s)

[a pretend developer Okay So that handles](https://youtu.be/HyJJX6FFdpA?t=00h22m30s)

[those That handles those Password box We](https://youtu.be/HyJJX6FFdpA?t=00h22m32s)

[already did Yeah](https://youtu.be/HyJJX6FFdpA?t=00h22m35s)

[Yeah And then](https://youtu.be/HyJJX6FFdpA?t=00h22m38s)

[text boxes we just did](https://youtu.be/HyJJX6FFdpA?t=00h22m41s)

[Yeah And then Oh time picker I knew](https://youtu.be/HyJJX6FFdpA?t=00h22m44s)

[there were more Knew there were more](https://youtu.be/HyJJX6FFdpA?t=00h22m48s)

[Let's see](https://youtu.be/HyJJX6FFdpA?t=00h22m50s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=00h22m52s)

[oh This is using is close to](https://youtu.be/HyJJX6FFdpA?t=00h22m56s)

[Oh](https://youtu.be/HyJJX6FFdpA?t=00h23m00s)

[this one might not have been as much of](https://youtu.be/HyJJX6FFdpA?t=00h23m04s)

[a problem](https://youtu.be/HyJJX6FFdpA?t=00h23m06s)

[Is close to condition](https://youtu.be/HyJJX6FFdpA?t=00h23m08s)

[Interesting I might This one doesn't](https://youtu.be/HyJJX6FFdpA?t=00h23m15s)

[matter as much because it's going to do](https://youtu.be/HyJJX6FFdpA?t=00h23m19s)

[something very very different](https://youtu.be/HyJJX6FFdpA?t=00h23m20s)

[Interesting We could have in theory](https://youtu.be/HyJJX6FFdpA?t=00h23m22s)

[switched the other ones to be the same](https://youtu.be/HyJJX6FFdpA?t=00h23m24s)

[You know what Let's make sure these](https://youtu.be/HyJJX6FFdpA?t=00h23m27s)

[tests pass really quick and then I may](https://youtu.be/HyJJX6FFdpA?t=00h23m28s)

[go and switch the other ones to match I](https://youtu.be/HyJJX6FFdpA?t=00h23m30s)

[think Let's see Uh time picker tests](https://youtu.be/HyJJX6FFdpA?t=00h23m34s)

[Uh yeah this one I just want to see](https://youtu.be/HyJJX6FFdpA?t=00h23m39s)

[these ones work really quick](https://youtu.be/HyJJX6FFdpA?t=00h23m42s)

[I suspect they will because it's doing a](https://youtu.be/HyJJX6FFdpA?t=00h23m45s)

[less than or equal to on um an absolute](https://youtu.be/HyJJX6FFdpA?t=00h23m47s)

[value of the difference](https://youtu.be/HyJJX6FFdpA?t=00h23m50s)

[So it it should be working the same as](https://youtu.be/HyJJX6FFdpA?t=00h23m52s)

[inclusive bounds The difference being is](https://youtu.be/HyJJX6FFdpA?t=00h23m55s)

[that this will handle the negative if](https://youtu.be/HyJJX6FFdpA?t=00h23m58s)

[the other side happens to be bigger](https://youtu.be/HyJJX6FFdpA?t=00h23m59s)

[whereas between might not So I kind Yeah](https://youtu.be/HyJJX6FFdpA?t=00h24m01s)

[So that's actually I think is close to](https://youtu.be/HyJJX6FFdpA?t=00h24m04s)

[is actually better than the other one So](https://youtu.be/HyJJX6FFdpA?t=00h24m07s)

[we're going to do this this and then](https://youtu.be/HyJJX6FFdpA?t=00h24m10s)

[this gets rid of with inclusive bounds](https://youtu.be/HyJJX6FFdpA?t=00h24m13s)

[and then](https://youtu.be/HyJJX6FFdpA?t=00h24m18s)

[there there](https://youtu.be/HyJJX6FFdpA?t=00h24m20s)

[and then](https://youtu.be/HyJJX6FFdpA?t=00h24m26s)

[and reality the the other thing you](https://youtu.be/HyJJX6FFdpA?t=00h24m28s)

[could always do to get the same behavior](https://youtu.be/HyJJX6FFdpA?t=00h24m30s)

[here if you don't have this extension is](https://youtu.be/HyJJX6FFdpA?t=00h24m32s)

[you could just do negative tolerance to](https://youtu.be/HyJJX6FFdpA?t=00h24m33s)

[tolerance because the middle is zero](https://youtu.be/HyJJX6FFdpA?t=00h24m35s)

[right like you can write the equivalent](https://youtu.be/HyJJX6FFdpA?t=00h24m37s)

[with the built-in stuff I just wrote the](https://youtu.be/HyJJX6FFdpA?t=00h24m39s)

[extension partially because I wanted to](https://youtu.be/HyJJX6FFdpA?t=00h24m42s)

[figure out how to do it See and this one](https://youtu.be/HyJJX6FFdpA?t=00h24m43s)

[is doing](https://youtu.be/HyJJX6FFdpA?t=00h24m46s)

[the negative tolerance to tolerance](https://youtu.be/HyJJX6FFdpA?t=00h24m48s)

[because it's a because the center point](https://youtu.be/HyJJX6FFdpA?t=00h24m50s)

[is zero If your center point between the](https://youtu.be/HyJJX6FFdpA?t=00h24m52s)

[upper and lower isn't zero you just have](https://youtu.be/HyJJX6FFdpA?t=00h24m55s)

[to uh appropriately add and subtract](https://youtu.be/HyJJX6FFdpA?t=00h24m57s)

[right It's a It's now a small math](https://youtu.be/HyJJX6FFdpA?t=00h25m00s)

[problem rather than](https://youtu.be/HyJJX6FFdpA?t=00h25m04s)

[something else But I think is close to](https://youtu.be/HyJJX6FFdpA?t=00h25m06s)

[is probably](https://youtu.be/HyJJX6FFdpA?t=00h25m09s)

[um Where did you put the tab in That is](https://youtu.be/HyJJX6FFdpA?t=00h25m11s)

[one of the other things that has annoyed](https://youtu.be/HyJJX6FFdpA?t=00h25m14s)

[me is I feel like a lot of the tooling](https://youtu.be/HyJJX6FFdpA?t=00h25m16s)

[around this is getting](https://youtu.be/HyJJX6FFdpA?t=00h25m18s)

[problematic Like the tab key is getting](https://youtu.be/HyJJX6FFdpA?t=00h25m21s)

[very very overloaded in terms of the](https://youtu.be/HyJJX6FFdpA?t=00h25m24s)

[actions that it does And so it starts to](https://youtu.be/HyJJX6FFdpA?t=00h25m27s)

[make a user experience issue inside of a](https://youtu.be/HyJJX6FFdpA?t=00h25m29s)

[lot of tooling](https://youtu.be/HyJJX6FFdpA?t=00h25m32s)

[And so I would love to Whoa Whoa Oh hold](https://youtu.be/HyJJX6FFdpA?t=00h25m35s)

[up I would love to](https://youtu.be/HyJJX6FFdpA?t=00h25m38s)

[excuse me I'd love to see that get a lot](https://youtu.be/HyJJX6FFdpA?t=00h25m41s)

[better](https://youtu.be/HyJJX6FFdpA?t=00h25m42s)

[because right now every time you press](https://youtu.be/HyJJX6FFdpA?t=00h25m45s)

[tab it does really end up kind of being](https://youtu.be/HyJJX6FFdpA?t=00h25m46s)

[little aggressive in its solutioning](https://youtu.be/HyJJX6FFdpA?t=00h25m50s)

[Okay Where are you](https://youtu.be/HyJJX6FFdpA?t=00h25m53s)

[Uh let's see is close to is close to](https://youtu.be/HyJJX6FFdpA?t=00h25m55s)

[We can do this We can do this We do this](https://youtu.be/HyJJX6FFdpA?t=00h26m00s)

[And we can expand you and do the same](https://youtu.be/HyJJX6FFdpA?t=00h26m04s)

[thing](https://youtu.be/HyJJX6FFdpA?t=00h26m06s)

[I think this like we've got the](https://youtu.be/HyJJX6FFdpA?t=00h26m10s)

[extension We might as well use it It's](https://youtu.be/HyJJX6FFdpA?t=00h26m11s)

[just a little less typing Okay So that](https://youtu.be/HyJJX6FFdpA?t=00h26m13s)

[handles that](https://youtu.be/HyJJX6FFdpA?t=00h26m16s)

[And we're going to do](https://youtu.be/HyJJX6FFdpA?t=00h26m18s)

[AI Write the message for me Great Thank](https://youtu.be/HyJJX6FFdpA?t=00h26m21s)

[you We're going to push that And I think](https://youtu.be/HyJJX6FFdpA?t=00h26m23s)

[that I don't think the other one](https://youtu.be/HyJJX6FFdpA?t=00h26m27s)

[probably finished yet but we'll take a](https://youtu.be/HyJJX6FFdpA?t=00h26m30s)

[look](https://youtu.be/HyJJX6FFdpA?t=00h26m33s)

[Yeah this one hadn't finished yet So](https://youtu.be/HyJJX6FFdpA?t=00h26m35s)

[we're going to cancel its run and we're](https://youtu.be/HyJJX6FFdpA?t=00h26m36s)

[going to let this one go for a minute](https://youtu.be/HyJJX6FFdpA?t=00h26m38s)

[and then I want to take a brief look at](https://youtu.be/HyJJX6FFdpA?t=00h26m41s)

[this PR here So this was an interesting](https://youtu.be/HyJJX6FFdpA?t=00h26m44s)

[one Um Corvin's put in one to fix this](https://youtu.be/HyJJX6FFdpA?t=00h26m47s)

[problem here](https://youtu.be/HyJJX6FFdpA?t=00h26m51s)

[right So](https://youtu.be/HyJJX6FFdpA?t=00h26m54s)

[um](https://youtu.be/HyJJX6FFdpA?t=00h26m56s)

[and so it it ends up causing this kind](https://youtu.be/HyJJX6FFdpA?t=00h26m58s)

[of situation where there's not enough](https://youtu.be/HyJJX6FFdpA?t=00h27m01s)

[space for your tabs Um](https://youtu.be/HyJJX6FFdpA?t=00h27m04s)

[but in the regular WPF it does right So](https://youtu.be/HyJJX6FFdpA?t=00h27m08s)

[you've got more tabs than you have](https://youtu.be/HyJJX6FFdpA?t=00h27m11s)

[horizontal space What should happen And](https://youtu.be/HyJJX6FFdpA?t=00h27m13s)

[Corin's put in an attach property to to](https://youtu.be/HyJJX6FFdpA?t=00h27m17s)

[set wrapping](https://youtu.be/HyJJX6FFdpA?t=00h27m21s)

[which is okay but it gives me pause](https://youtu.be/HyJJX6FFdpA?t=00h27m26s)

[because I the the issue is it assumes](https://youtu.be/HyJJX6FFdpA?t=00h27m28s)

[this enum has a sum total of all the](https://youtu.be/HyJJX6FFdpA?t=00h27m31s)

[possibilities and I'm not sure that's](https://youtu.be/HyJJX6FFdpA?t=00h27m34s)

[right and I thought](https://youtu.be/HyJJX6FFdpA?t=00h27m36s)

[I thought the control](https://youtu.be/HyJJX6FFdpA?t=00h27m39s)

[allowed for swapping that out but I](https://youtu.be/HyJJX6FFdpA?t=00h27m42s)

[could be wrong So I wanted to take a](https://youtu.be/HyJJX6FFdpA?t=00h27m44s)

[brief gander at because I think I have](https://youtu.be/HyJJX6FFdpA?t=00h27m48s)

[an example of this even](https://youtu.be/HyJJX6FFdpA?t=00h27m52s)

[I think I have an example of this tab](https://youtu.be/HyJJX6FFdpA?t=00h27m55s)

[control](https://youtu.be/HyJJX6FFdpA?t=00h27m58s)

[No I don't I don't So let's let's go](https://youtu.be/HyJJX6FFdpA?t=00h28m01s)

[take a while that while that thing's](https://youtu.be/HyJJX6FFdpA?t=00h28m05s)

[thinking about it life Um I want to go](https://youtu.be/HyJJX6FFdpA?t=00h28m07s)

[and look at this guy because I thought](https://youtu.be/HyJJX6FFdpA?t=00h28m10s)

[you could override this And it may not](https://youtu.be/HyJJX6FFdpA?t=00h28m16s)

[be obvious how to do so And I think that](https://youtu.be/HyJJX6FFdpA?t=00h28m18s)

[might be the fundamental problem here](https://youtu.be/HyJJX6FFdpA?t=00h28m21s)

[but I thought you could get at this](https://youtu.be/HyJJX6FFdpA?t=00h28m24s)

[Let's see because this is a virtualizing](https://youtu.be/HyJJX6FFdpA?t=00h28m28s)

[stack panel and that might be the](https://youtu.be/HyJJX6FFdpA?t=00h28m31s)

[fundamental issue here](https://youtu.be/HyJJX6FFdpA?t=00h28m36s)

[cuz doesn't maybe maybe I'm making this](https://youtu.be/HyJJX6FFdpA?t=00h28m39s)

[up I thought](https://youtu.be/HyJJX6FFdpA?t=00h28m42s)

[property](https://youtu.be/HyJJX6FFdpA?t=00h28m45s)

[um](https://youtu.be/HyJJX6FFdpA?t=00h28m46s)

[I thought items panel was the solution](https://youtu.be/HyJJX6FFdpA?t=00h28m50s)

[here and and maybe I'm just](https://youtu.be/HyJJX6FFdpA?t=00h28m52s)

[maybe the issue the the fact that items](https://youtu.be/HyJJX6FFdpA?t=00h28m57s)

[panel isn't working](https://youtu.be/HyJJX6FFdpA?t=00h28m59s)

[because of the way this is set up](https://youtu.be/HyJJX6FFdpA?t=00h29m03s)

[because this virtualizing stack panel](https://youtu.be/HyJJX6FFdpA?t=00h29m05s)

[inside of a scroll viewer here](https://youtu.be/HyJJX6FFdpA?t=00h29m07s)

[right I think is like this is fun](https://youtu.be/HyJJX6FFdpA?t=00h29m12s)

[functionally why you're getting the the](https://youtu.be/HyJJX6FFdpA?t=00h29m15s)

[behavior that you are right There's a a](https://youtu.be/HyJJX6FFdpA?t=00h29m17s)

[stack panel](https://youtu.be/HyJJX6FFdpA?t=00h29m20s)

[uniform grid and I'm trying to remember](https://youtu.be/HyJJX6FFdpA?t=00h29m23s)

[what this uniform grid is for](https://youtu.be/HyJJX6FFdpA?t=00h29m25s)

[This is the collapse all bit](https://youtu.be/HyJJX6FFdpA?t=00h29m28s)

[Don't remember why we have this](https://youtu.be/HyJJX6FFdpA?t=00h29m31s)

[Might have to double check that But this](https://youtu.be/HyJJX6FFdpA?t=00h29m34s)

[here](https://youtu.be/HyJJX6FFdpA?t=00h29m38s)

[and I'm wondering if leveraging the](https://youtu.be/HyJJX6FFdpA?t=00h29m40s)

[items panel might be a better solution](https://youtu.be/HyJJX6FFdpA?t=00h29m42s)

[cuz what I'd rather do is give people](https://youtu.be/HyJJX6FFdpA?t=00h29m44s)

[the control to put in whatever items](https://youtu.be/HyJJX6FFdpA?t=00h29m46s)

[panel they want rather than an enume](https://youtu.be/HyJJX6FFdpA?t=00h29m48s)

[with a fixed set of values Like](https://youtu.be/HyJJX6FFdpA?t=00h29m52s)

[admittedly the ene with a fixed set of](https://youtu.be/HyJJX6FFdpA?t=00h29m54s)

[values makes it easy whereas doing an](https://youtu.be/HyJJX6FFdpA?t=00h29m56s)

[items panel does make it a little more](https://youtu.be/HyJJX6FFdpA?t=00h29m58s)

[difficult However the items panel is](https://youtu.be/HyJJX6FFdpA?t=00h30m01s)

[significantly more extendable and gives](https://youtu.be/HyJJX6FFdpA?t=00h30m03s)

[access to all the the power right](https://youtu.be/HyJJX6FFdpA?t=00h30m06s)

[Because the moment somebody says "Oh I](https://youtu.be/HyJJX6FFdpA?t=00h30m08s)

[want to set this on your your stack](https://youtu.be/HyJJX6FFdpA?t=00h30m10s)

[panel or your wrap panel." Now you have](https://youtu.be/HyJJX6FFdpA?t=00h30m12s)

[to go and do more work because I think](https://youtu.be/HyJJX6FFdpA?t=00h30m14s)

[that was the implementation here when I](https://youtu.be/HyJJX6FFdpA?t=00h30m16s)

[looked at it Um](https://youtu.be/HyJJX6FFdpA?t=00h30m18s)

[is](https://youtu.be/HyJJX6FFdpA?t=00h30m21s)

[this guy here Let's see what was what](https://youtu.be/HyJJX6FFdpA?t=00h30m23s)

[was the change](https://youtu.be/HyJJX6FFdpA?t=00h30m25s)

[Uh it's the scroll viewer](https://youtu.be/HyJJX6FFdpA?t=00h30m28s)

[And so is this just toggling visibility](https://youtu.be/HyJJX6FFdpA?t=00h30m32s)

[or where does it swap it out](https://youtu.be/HyJJX6FFdpA?t=00h30m35s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=00h30m39s)

[some ordering here that's not obvious to](https://youtu.be/HyJJX6FFdpA?t=00h30m41s)

[me](https://youtu.be/HyJJX6FFdpA?t=00h30m43s)

[Wrapping header Yeah because you have a](https://youtu.be/HyJJX6FFdpA?t=00h30m45s)

[wrap panel and a scroll viewer And this](https://youtu.be/HyJJX6FFdpA?t=00h30m48s)

[is a combination that gives me a bit of](https://youtu.be/HyJJX6FFdpA?t=00h30m50s)

[pause because it's very unusual to have](https://youtu.be/HyJJX6FFdpA?t=00h30m52s)

[a wrap panel inside of a scroll view](https://youtu.be/HyJJX6FFdpA?t=00h30m57s)

[I guess this is to scroll vertically](https://youtu.be/HyJJX6FFdpA?t=00h31m01s)

[if you run out of space But the question](https://youtu.be/HyJJX6FFdpA?t=00h31m05s)

[then is how do you know how how much](https://youtu.be/HyJJX6FFdpA?t=00h31m07s)

[space this should have](https://youtu.be/HyJJX6FFdpA?t=00h31m09s)

[Because how much space do you give to](https://youtu.be/HyJJX6FFdpA?t=00h31m12s)

[your headers versus your actual tab](https://youtu.be/HyJJX6FFdpA?t=00h31m14s)

[content Obviously the container wrapping](https://youtu.be/HyJJX6FFdpA?t=00h31m16s)

[the tab control knows how much overall](https://youtu.be/HyJJX6FFdpA?t=00h31m19s)

[space it has but it doesn't know](https://youtu.be/HyJJX6FFdpA?t=00h31m22s)

[individually](https://youtu.be/HyJJX6FFdpA?t=00h31m24s)

[that this is this one is giving me a lot](https://youtu.be/HyJJX6FFdpA?t=00h31m28s)

[of pause for that reason I think we want](https://youtu.be/HyJJX6FFdpA?t=00h31m30s)

[to do something with the items panel](https://youtu.be/HyJJX6FFdpA?t=00h31m34s)

[instead and just default the items panel](https://youtu.be/HyJJX6FFdpA?t=00h31m38s)

[to using the um the virtualizing stack](https://youtu.be/HyJJX6FFdpA?t=00h31m41s)

[panel as it is today](https://youtu.be/HyJJX6FFdpA?t=00h31m45s)

[and then go from there](https://youtu.be/HyJJX6FFdpA?t=00h31m48s)

[Okay Okay So I know when I see this this](https://youtu.be/HyJJX6FFdpA?t=00h31m50s)

[is often an indication of a failure](https://youtu.be/HyJJX6FFdpA?t=00h31m52s)

[Um but not always because sometimes it](https://youtu.be/HyJJX6FFdpA?t=00h31m57s)

[it um doesn't know](https://youtu.be/HyJJX6FFdpA?t=00h32m00s)

[that there is a failure Uh let's see](https://youtu.be/HyJJX6FFdpA?t=00h32m04s)

[here](https://youtu.be/HyJJX6FFdpA?t=00h32m07s)

[Air test failed So the autosuggest box](https://youtu.be/HyJJX6FFdpA?t=00h32m09s)

[test Let's just grab those and take a](https://youtu.be/HyJJX6FFdpA?t=00h32m12s)

[look at them](https://youtu.be/HyJJX6FFdpA?t=00h32m14s)

[Close Close Close Close Close Close This](https://youtu.be/HyJJX6FFdpA?t=00h32m17s)

[is going to be whack-a-ole with test](https://youtu.be/HyJJX6FFdpA?t=00h32m20s)

[Uh why are you guys not in alphabetical](https://youtu.be/HyJJX6FFdpA?t=00h32m23s)

[order there Let's run these There's only](https://youtu.be/HyJJX6FFdpA?t=00h32m27s)

[six We'll see We'll see what's going on](https://youtu.be/HyJJX6FFdpA?t=00h32m30s)

[There may still be that hang on the](https://youtu.be/HyJJX6FFdpA?t=00h32m33s)

[textbox one We didn't go back and double](https://youtu.be/HyJJX6FFdpA?t=00h32m34s)

[check that because that one did give me](https://youtu.be/HyJJX6FFdpA?t=00h32m36s)

[a bit of pause of why is this thing](https://youtu.be/HyJJX6FFdpA?t=00h32m38s)

[hanging like that](https://youtu.be/HyJJX6FFdpA?t=00h32m39s)

[Boom](https://youtu.be/HyJJX6FFdpA?t=00h32m46s)

[Boom](https://youtu.be/HyJJX6FFdpA?t=00h32m48s)

[we go](https://youtu.be/HyJJX6FFdpA?t=00h32m54s)

[Okay So what do we got](https://youtu.be/HyJJX6FFdpA?t=00h32m57s)

[See unable to cast item of type string](https://youtu.be/HyJJX6FFdpA?t=00h33m02s)

[to type task Well that seems wrong](https://youtu.be/HyJJX6FFdpA?t=00h33m05s)

[Uh we shouldn't be](https://youtu.be/HyJJX6FFdpA?t=00h33m09s)

[Where did it go I can't see what line it](https://youtu.be/HyJJX6FFdpA?t=00h33m13s)

[was 227](https://youtu.be/HyJJX6FFdpA?t=00h33m15s)

[Uh let's see Unable](https://youtu.be/HyJJX6FFdpA?t=00h33m18s)

[Wait what](https://youtu.be/HyJJX6FFdpA?t=00h33m26s)

[to type](https://youtu.be/HyJJX6FFdpA?t=00h33m29s)

[Um](https://youtu.be/HyJJX6FFdpA?t=00h33m46s)

[where is the am I am I stupid where is](https://youtu.be/HyJJX6FFdpA?t=00h33m51s)

[the string](https://youtu.be/HyJJX6FFdpA?t=00h33m54s)

[okay something is so I am missing some](https://youtu.be/HyJJX6FFdpA?t=00h33m59s)

[syntax here and this is my library which](https://youtu.be/HyJJX6FFdpA?t=00h34m02s)

[gives me](https://youtu.be/HyJJX6FFdpA?t=00h34m04s)

[and it's showing here So let's](https://youtu.be/HyJJX6FFdpA?t=00h34m15s)

[let's just run it until this point and](https://youtu.be/HyJJX6FFdpA?t=00h34m19s)

[see what is going on](https://youtu.be/HyJJX6FFdpA?t=00h34m22s)

[Why I'm](https://youtu.be/HyJJX6FFdpA?t=00h34m26s)

[remote execute serialize It's like it](https://youtu.be/HyJJX6FFdpA?t=00h34m28s)

[tried to serialize the parameter](https://youtu.be/HyJJX6FFdpA?t=00h34m30s)

[but that's a task return](https://youtu.be/HyJJX6FFdpA?t=00h34m34s)

[Unable to cast object of type string to](https://youtu.be/HyJJX6FFdpA?t=00h34m38s)

[system threading task](https://youtu.be/HyJJX6FFdpA?t=00h34m41s)

[I agree that you shouldn't do that](https://youtu.be/HyJJX6FFdpA?t=00h34m43s)

[So don't](https://youtu.be/HyJJX6FFdpA?t=00h34m47s)

[uh debug](https://youtu.be/HyJJX6FFdpA?t=00h34m52s)

[Pretty please](https://youtu.be/HyJJX6FFdpA?t=00h34m55s)

[Okay So we got there](https://youtu.be/HyJJX6FFdpA?t=00h35m00s)

[selected item Yeah Great Remote execute](https://youtu.be/HyJJX6FFdpA?t=00h35m03s)

[Um](https://youtu.be/HyJJX6FFdpA?t=00h35m16s)

[unable to cast object of type string](https://youtu.be/HyJJX6FFdpA?t=00h35m18s)

[to system threading task](https://youtu.be/HyJJX6FFdpA?t=00h35m22s)

[I am clearly misunderstanding something](https://youtu.be/HyJJX6FFdpA?t=00h35m36s)

[very fundamental here](https://youtu.be/HyJJX6FFdpA?t=00h35m39s)

[cuz we have remote executes all over the](https://youtu.be/HyJJX6FFdpA?t=00h35m44s)

[place And this is a suggest box](https://youtu.be/HyJJX6FFdpA?t=00h35m46s)

[And so its parameter needs to be the](https://youtu.be/HyJJX6FFdpA?t=00h35m51s)

[auto suggest box](https://youtu.be/HyJJX6FFdpA?t=00h35m53s)

[unable to cast object of type system](https://youtu.be/HyJJX6FFdpA?t=00h35m57s)

[string to So I'm I'm also holding off on](https://youtu.be/HyJJX6FFdpA?t=00h36m00s)

[because I wonder if I broke something in](https://youtu.be/HyJJX6FFdpA?t=00h36m05s)

[my ZAML test Merry Christmas What we up](https://youtu.be/HyJJX6FFdpA?t=00h36m06s)

[to this sweltering bright morning that](https://youtu.be/HyJJX6FFdpA?t=00h36m09s)

[is bound to go wrong while I'm at the](https://youtu.be/HyJJX6FFdpA?t=00h36m12s)

[grass stone](https://youtu.be/HyJJX6FFdpA?t=00h36m13s)

[Ah Izzy it is always a pleasure Always a](https://youtu.be/HyJJX6FFdpA?t=00h36m15s)

[pleasure No I am back fighting my](https://youtu.be/HyJJX6FFdpA?t=00h36m18s)

[um my T-Unit test because I really want](https://youtu.be/HyJJX6FFdpA?t=00h36m22s)

[to get this thing going and I don't](https://youtu.be/HyJJX6FFdpA?t=00h36m25s)

[understand where my cast is occurring](https://youtu.be/HyJJX6FFdpA?t=00h36m27s)

[Um](https://youtu.be/HyJJX6FFdpA?t=00h36m31s)

[it's clearly occurring inside of this](https://youtu.be/HyJJX6FFdpA?t=00h36m35s)

[extension method but I am](https://youtu.be/HyJJX6FFdpA?t=00h36m37s)

[I am missing something very obvious that](https://youtu.be/HyJJX6FFdpA?t=00h36m40s)

[I'm not entirely clear what](https://youtu.be/HyJJX6FFdpA?t=00h36m42s)

[because it takes in a delegate](https://youtu.be/HyJJX6FFdpA?t=00h36m47s)

[Okay so let's turn off](https://youtu.be/HyJJX6FFdpA?t=00h36m54s)

[I don't want breakpoint settings I want](https://youtu.be/HyJJX6FFdpA?t=00h36m57s)

[tool options](https://youtu.be/HyJJX6FFdpA?t=00h36m59s)

[Uh I want debug settings Debugging](https://youtu.be/HyJJX6FFdpA?t=00h37m01s)

[Turn off just my code I would like to](https://youtu.be/HyJJX6FFdpA?t=00h37m05s)

[debug in](https://youtu.be/HyJJX6FFdpA?t=00h37m08s)

[Uh oh Oh thank you Izzy I actually have](https://youtu.be/HyJJX6FFdpA?t=00h37m10s)

[it The fact that it's down on 79% is](https://youtu.be/HyJJX6FFdpA?t=00h37m13s)

[probably that's probably better](https://youtu.be/HyJJX6FFdpA?t=00h37m16s)

[My apologies Thank you for calling that](https://youtu.be/HyJJX6FFdpA?t=00h37m19s)

[out](https://youtu.be/HyJJX6FFdpA?t=00h37m21s)

[I will say I I did also submit feedback](https://youtu.be/HyJJX6FFdpA?t=00h37m23s)

[because this new co-pilot consumptions](https://youtu.be/HyJJX6FFdpA?t=00h37m27s)

[window here Here here's a here is a fun](https://youtu.be/HyJJX6FFdpA?t=00h37m29s)

[f see this bothers me This bothers me a](https://youtu.be/HyJJX6FFdpA?t=00h37m32s)

[great deal and it it occurs I find a lot](https://youtu.be/HyJJX6FFdpA?t=00h37m36s)

[of these because I bump my default font](https://youtu.be/HyJJX6FFdpA?t=00h37m38s)

[size in Visual Studio up a few points](https://youtu.be/HyJJX6FFdpA?t=00h37m40s)

[just because I'm constantly um either](https://youtu.be/HyJJX6FFdpA?t=00h37m43s)

[streaming or presenting or showing](https://youtu.be/HyJJX6FFdpA?t=00h37m46s)

[similar And then there's this this right](https://youtu.be/HyJJX6FFdpA?t=00h37m47s)

[So if we take snoop because a](https://youtu.be/HyJJX6FFdpA?t=00h37m50s)

[significant portion of Visual Studio is](https://youtu.be/HyJJX6FFdpA?t=00h37m52s)

[WPF you can snoop it which is even](https://youtu.be/HyJJX6FFdpA?t=00h37m54s)

[better So you go "Oh that's interesting](https://youtu.be/HyJJX6FFdpA?t=00h37m56s)

[I wonder why this button is being cut](https://youtu.be/HyJJX6FFdpA?t=00h37m59s)

[off." So we we snoop our way in and we](https://youtu.be/HyJJX6FFdpA?t=00h38m01s)

[go and we look at this button and we go](https://youtu.be/HyJJX6FFdpA?t=00h38m04s)

["Well clearly it's being cropped](https://youtu.be/HyJJX6FFdpA?t=00h38m06s)

[horizontally." So let's look at width](https://youtu.be/HyJJX6FFdpA?t=00h38m07s)

[properties](https://youtu.be/HyJJX6FFdpA?t=00h38m09s)

[And there we find our bug](https://youtu.be/HyJJX6FFdpA?t=00h38m12s)

[right Our max width property](https://youtu.be/HyJJX6FFdpA?t=00h38m15s)

[right there is being set to 125 and its](https://youtu.be/HyJJX6FFdpA?t=00h38m19s)

[value source is local meaning it's set](https://youtu.be/HyJJX6FFdpA?t=00h38m23s)

[directly on the element](https://youtu.be/HyJJX6FFdpA?t=00h38m25s)

[right And all we have to do to fix this](https://youtu.be/HyJJX6FFdpA?t=00h38m28s)

[is not set it That's it That's it That's](https://youtu.be/HyJJX6FFdpA?t=00h38m31s)

[the sum to like just stop setting that](https://youtu.be/HyJJX6FFdpA?t=00h38m35s)

[They're like the like you can get away](https://youtu.be/HyJJX6FFdpA?t=00h38m41s)

[with setting things like max width and](https://youtu.be/HyJJX6FFdpA?t=00h38m42s)

[similar when you don't have a highly](https://youtu.be/HyJJX6FFdpA?t=00h38m45s)

[customized application But on Visual](https://youtu.be/HyJJX6FFdpA?t=00h38m46s)

[Studio something that allows its fonts](https://youtu.be/HyJJX6FFdpA?t=00h38m49s)

[to be like the font face and size can be](https://youtu.be/HyJJX6FFdpA?t=00h38m52s)

[completely changed on pretty much every](https://youtu.be/HyJJX6FFdpA?t=00h38m55s)

[element You cannot assume the size of](https://youtu.be/HyJJX6FFdpA?t=00h38m57s)

[any element containing text Like you you](https://youtu.be/HyJJX6FFdpA?t=00h39m01s)

[can't it's going to change when someone](https://youtu.be/HyJJX6FFdpA?t=00h39m04s)

[like me bumps it up So it's like just](https://youtu.be/HyJJX6FFdpA?t=00h39m06s)

[just don't set that That's all I ask](https://youtu.be/HyJJX6FFdpA?t=00h39m09s)

[Don't set it I want you to not do work](https://youtu.be/HyJJX6FFdpA?t=00h39m12s)

[That's all I ask Like min width sure](https://youtu.be/HyJJX6FFdpA?t=00h39m16s)

[Right You can get away with that because](https://youtu.be/HyJJX6FFdpA?t=00h39m18s)

[it's like well maybe we don't want it](https://youtu.be/HyJJX6FFdpA?t=00h39m20s)

[going that far small I don't know why](https://youtu.be/HyJJX6FFdpA?t=00h39m22s)

[min width is being set at all anyway The](https://youtu.be/HyJJX6FFdpA?t=00h39m24s)

[window's not resizable](https://youtu.be/HyJJX6FFdpA?t=00h39m26s)

[So I have no idea why we have min width](https://youtu.be/HyJJX6FFdpA?t=00h39m28s)

[set either but I mean obviously clearing](https://youtu.be/HyJJX6FFdpA?t=00h39m31s)

[it doesn't do a darn thing right I think](https://youtu.be/HyJJX6FFdpA?t=00h39m34s)

[it was to override the style but what do](https://youtu.be/HyJJX6FFdpA?t=00h39m37s)

[I know So yeah Uh absolutely Submitted a](https://youtu.be/HyJJX6FFdpA?t=00h39m39s)

[um feedback request for that because](https://youtu.be/HyJJX6FFdpA?t=00h39m47s)

[that that bothered me a great deal and I](https://youtu.be/HyJJX6FFdpA?t=00h39m49s)

[was very unhappy about it I was I was](https://youtu.be/HyJJX6FFdpA?t=00h39m53s)

[not okay with with how that was working](https://youtu.be/HyJJX6FFdpA?t=00h39m56s)

[Okay So we don't need that break point](https://youtu.be/HyJJX6FFdpA?t=00h39m59s)

[So we'll go to here Then I should be](https://youtu.be/HyJJX6FFdpA?t=00h40m01s)

[able to step](https://youtu.be/HyJJX6FFdpA?t=00h40m03s)

[Okay So we are here right and I have an](https://youtu.be/HyJJX6FFdpA?t=00h40m06s)

[action](https://youtu.be/HyJJX6FFdpA?t=00h40m09s)

[and that action signature looks like](https://youtu.be/HyJJX6FFdpA?t=00h40m11s)

[what I would expect](https://youtu.be/HyJJX6FFdpA?t=00h40m14s)

[I think that's fine Like I don't see](https://youtu.be/HyJJX6FFdpA?t=00h40m25s)

[right like the return type here](https://youtu.be/HyJJX6FFdpA?t=00h40m31s)

[is task of autosuggest box](https://youtu.be/HyJJX6FFdpA?t=00h40m34s)

[It's interesting that this is task of](https://youtu.be/HyJJX6FFdpA?t=00h40m38s)

[autosuggest Why is that](https://youtu.be/HyJJX6FFdpA?t=00h40m40s)

[Why did](https://youtu.be/HyJJX6FFdpA?t=00h40m46s)

[am I missing something](https://youtu.be/HyJJX6FFdpA?t=00h40m48s)

[the method](https://youtu.be/HyJJX6FFdpA?t=00h40m54s)

[Okay Return type of task I'm just](https://youtu.be/HyJJX6FFdpA?t=00h40m59s)

[misreading the two string](https://youtu.be/HyJJX6FFdpA?t=00h41m01s)

[Got it There's a space right there Okay](https://youtu.be/HyJJX6FFdpA?t=00h41m05s)

[So return type is task This is the class](https://youtu.be/HyJJX6FFdpA?t=00h41m08s)

[and the generated uh local function that](https://youtu.be/HyJJX6FFdpA?t=00h41m12s)

[goes in there Okay that's fine Going to](https://youtu.be/HyJJX6FFdpA?t=00h41m15s)

[step again](https://youtu.be/HyJJX6FFdpA?t=00h41m18s)

[Uh empty array We're going to step up](https://youtu.be/HyJJX6FFdpA?t=00h41m21s)

[We're going to step in](https://youtu.be/HyJJX6FFdpA?t=00h41m25s)

[Client remote execute Great Step in](https://youtu.be/HyJJX6FFdpA?t=00h41m30s)

[Okay Remote execute That's all fine](https://youtu.be/HyJJX6FFdpA?t=00h41m37s)

[Method name Method declaring type Full](https://youtu.be/HyJJX6FFdpA?t=00h41m41s)

[name Right Like this All looks fine to](https://youtu.be/HyJJX6FFdpA?t=00h41m43s)

[me](https://youtu.be/HyJJX6FFdpA?t=00h41m47s)

[Okay method generic argument](https://youtu.be/HyJJX6FFdpA?t=00h41m51s)

[generic method blah blah blah that's all](https://youtu.be/HyJJX6FFdpA?t=00h41m56s)

[fine that's all fine it logs](https://youtu.be/HyJJX6FFdpA?t=00h41m59s)

[it does the invocation](https://youtu.be/HyJJX6FFdpA?t=00h42m05s)

[error messages any](https://youtu.be/HyJJX6FFdpA?t=00h42m07s)

[value type](https://youtu.be/HyJJX6FFdpA?t=00h42m10s)

[is null](https://youtu.be/HyJJX6FFdpA?t=00h42m12s)

[this is task](https://youtu.be/HyJJX6FFdpA?t=00h42m18s)

[avoid task Ask result](https://youtu.be/HyJJX6FFdpA?t=00h42m20s)

[if value](https://youtu.be/HyJJX6FFdpA?t=00h42m30s)

[task avoid task result](https://youtu.be/HyJJX6FFdpA?t=00h42m41s)

[Oh that's interesting](https://youtu.be/HyJJX6FFdpA?t=00h42m45s)

[That is very very interesting I bet you](https://youtu.be/HyJJX6FFdpA?t=00h42m49s)

[I know where the bug is I bet you](https://youtu.be/HyJJX6FFdpA?t=00h42m52s)

[this comes because of](https://youtu.be/HyJJX6FFdpA?t=00h42m58s)

[the number of places where we were doing](https://youtu.be/HyJJX6FFdpA?t=00h43m04s)

[this is low](https://youtu.be/HyJJX6FFdpA?t=00h43m06s)

[the these specific remote executes I am](https://youtu.be/HyJJX6FFdpA?t=00h43m10s)

[willing to bet](https://youtu.be/HyJJX6FFdpA?t=00h43m13s)

[were previously synchronous not](https://youtu.be/HyJJX6FFdpA?t=00h43m18s)

[asynchronous](https://youtu.be/HyJJX6FFdpA?t=00h43m20s)

[and that's that's the fundamental](https://youtu.be/HyJJX6FFdpA?t=00h43m24s)

[problem Okay Okay This feels like a ZAML](https://youtu.be/HyJJX6FFdpA?t=00h43m26s)

[test](https://youtu.be/HyJJX6FFdpA?t=00h43m29s)

[because I am willing to bet I don't have](https://youtu.be/HyJJX6FFdpA?t=00h43m33s)

[a test in ZAML test covering](https://youtu.be/HyJJX6FFdpA?t=00h43m35s)

[asynchronous remote callbacks](https://youtu.be/HyJJX6FFdpA?t=00h43m38s)

[and I absolutely should](https://youtu.be/HyJJX6FFdpA?t=00h43m41s)

[I absolutely should](https://youtu.be/HyJJX6FFdpA?t=00h43m44s)

[[Music]](https://youtu.be/HyJJX6FFdpA?t=00h43m48s)

[Let me just refresh my memory on where](https://youtu.be/HyJJX6FFdpA?t=00h43m50s)

[we were at here because I know we were](https://youtu.be/HyJJX6FFdpA?t=00h43m52s)

[doing work in this](https://youtu.be/HyJJX6FFdpA?t=00h43m53s)

[Uh let's see here](https://youtu.be/HyJJX6FFdpA?t=00h43m58s)

[We're doing co-piloty stuff Oh that's](https://youtu.be/HyJJX6FFdpA?t=00h44m02s)

[right Copilot was attempting to rewrite](https://youtu.be/HyJJX6FFdpA?t=00h44m04s)

[the source generators for me We're going](https://youtu.be/HyJJX6FFdpA?t=00h44m06s)

[to not worry about that for the moment](https://youtu.be/HyJJX6FFdpA?t=00h44m09s)

[and switch back here Okay](https://youtu.be/HyJJX6FFdpA?t=00h44m10s)

[because it it botched my source](https://youtu.be/HyJJX6FFdpA?t=00h44m14s)

[generator rewrite in some way that was](https://youtu.be/HyJJX6FFdpA?t=00h44m16s)

[not obvious Okay So I want execution](https://youtu.be/HyJJX6FFdpA?t=00h44m19s)

[tests](https://youtu.be/HyJJX6FFdpA?t=00h44m23s)

[Where are my execution tests](https://youtu.be/HyJJX6FFdpA?t=00h44m27s)

[Um it's going to be either under visual](https://youtu.be/HyJJX6FFdpA?t=00h44m31s)

[element test is probably where the first](https://youtu.be/HyJJX6FFdpA?t=00h44m34s)

[one is](https://youtu.be/HyJJX6FFdpA?t=00h44m36s)

[Um and](https://youtu.be/HyJJX6FFdpA?t=00h44m38s)

[remote execute So this guy here](https://youtu.be/HyJJX6FFdpA?t=00h44m42s)

[Yeah And so we're going to we're going](https://youtu.be/HyJJX6FFdpA?t=00h44m46s)

[to rebuild all the things](https://youtu.be/HyJJX6FFdpA?t=00h44m48s)

[I think it just hasn't refreshed itself](https://youtu.be/HyJJX6FFdpA?t=00h44m53s)

[Um because this is](https://youtu.be/HyJJX6FFdpA?t=00h44m56s)

[expecting to be able to serialize and](https://youtu.be/HyJJX6FFdpA?t=00h45m02s)

[deserialize a task uh can execute](https://youtu.be/HyJJX6FFdpA?t=00h45m03s)

[um](https://youtu.be/HyJJX6FFdpA?t=00h45m08s)

[async method](https://youtu.be/HyJJX6FFdpA?t=00h45m11s)

[uh let's see and then we want to do](https://youtu.be/HyJJX6FFdpA?t=00h45m16s)

[oh I replaced the wrong word](https://youtu.be/HyJJX6FFdpA?t=00h45m21s)

[task and then we want to come in here](https://youtu.be/HyJJX6FFdpA?t=00h45m24s)

[and we want to go with uh can execute](https://youtu.be/HyJJX6FFdpA?t=00h45m27s)

[async method](https://youtu.be/HyJJX6FFdpA?t=00h45m31s)

[with return](https://youtu.be/HyJJX6FFdpA?t=00h45m33s)

[value I think](https://youtu.be/HyJJX6FFdpA?t=00h45m36s)

[I don't know that we tested the returns](https://youtu.be/HyJJX6FFdpA?t=00h45m40s)

[very thoroughly before](https://youtu.be/HyJJX6FFdpA?t=00h45m42s)

[because there's a very limited number of](https://youtu.be/HyJJX6FFdpA?t=00h45m47s)

[things that can be returned but we](https://youtu.be/HyJJX6FFdpA?t=00h45m48s)

[should probably add a test in here for](https://youtu.be/HyJJX6FFdpA?t=00h45m50s)

[that as well So can execute remote code](https://youtu.be/HyJJX6FFdpA?t=00h45m52s)

[remote execute let's see with return](https://youtu.be/HyJJX6FFdpA?t=00h45m57s)

[value](https://youtu.be/HyJJX6FFdpA?t=00h46m01s)

[um](https://youtu.be/HyJJX6FFdpA?t=00h46m08s)

[I can't type with today apparently](https://youtu.be/HyJJX6FFdpA?t=00h46m10s)

[So we're going to smooth this around to](https://youtu.be/HyJJX6FFdpA?t=00h46m13s)

[make the name match the other one](https://youtu.be/HyJJX6FFdpA?t=00h46m15s)

[And let's go in here](https://youtu.be/HyJJX6FFdpA?t=00h46m19s)

[with return value Okay](https://youtu.be/HyJJX6FFdpA?t=00h46m22s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=00h46m26s)

[08 task](https://youtu.be/HyJJX6FFdpA?t=00h46m29s)

[delay 10 Right I just need something to](https://youtu.be/HyJJX6FFdpA?t=00h46m31s)

[slow this down to make it to make it](https://youtu.be/HyJJX6FFdpA?t=00h46m34s)

[work Uh let's see Await task delay](https://youtu.be/HyJJX6FFdpA?t=00h46m37s)

[00:46:46,560 --> 00:46:54,160](https://youtu.be/HyJJX6FFdpA?t=00h46m44s)

Uh let's see with return value

[return uh window.title title](https://youtu.be/HyJJX6FFdpA?t=00h46m50s)

[right So I want this to be task of](https://youtu.be/HyJJX6FFdpA?t=00h46m54s)

[string](https://youtu.be/HyJJX6FFdpA?t=00h46m55s)

[right And I we may not need the return](https://youtu.be/HyJJX6FFdpA?t=00h47m00s)

[value case I should check No it](https://youtu.be/HyJJX6FFdpA?t=00h47m04s)

[absolutely supports it Uh string title](https://youtu.be/HyJJX6FFdpA?t=00h47m07s)

[right is what that should end up being](https://youtu.be/HyJJX6FFdpA?t=00h47m11s)

[And we probably need overloads for the](https://youtu.be/HyJJX6FFdpA?t=00h47m15s)

[task returning ones because we're](https://youtu.be/HyJJX6FFdpA?t=00h47m17s)

[landing here and that is wrong So we](https://youtu.be/HyJJX6FFdpA?t=00h47m19s)

[want that to work Stop it Stop it Stop](https://youtu.be/HyJJX6FFdpA?t=00h47m22s)

[it Stop it Stop it Stop it Stop it](https://youtu.be/HyJJX6FFdpA?t=00h47m25s)

[Thank you](https://youtu.be/HyJJX6FFdpA?t=00h47m28s)

[Why Why you make me work hard Okay And](https://youtu.be/HyJJX6FFdpA?t=00h47m31s)

[so](https://youtu.be/HyJJX6FFdpA?t=00h47m34s)

[this one up here](https://youtu.be/HyJJX6FFdpA?t=00h47m36s)

[uh let's see with return value we want](https://youtu.be/HyJJX6FFdpA?t=00h47m40s)

[to go string and we want to return](https://youtu.be/HyJJX6FFdpA?t=00h47m44s)

[window title So before we do the async](https://youtu.be/HyJJX6FFdpA?t=00h47m47s)

[stuff let's get the non async one](https://youtu.be/HyJJX6FFdpA?t=00h47m49s)

[working](https://youtu.be/HyJJX6FFdpA?t=00h47m53s)

[uh and then we will deal with the async](https://youtu.be/HyJJX6FFdpA?t=00h47m55s)

[side of the fence Not bad at co-pilot](https://youtu.be/HyJJX6FFdpA?t=00h47m58s)

[I don't like yelling at you Actually I](https://youtu.be/HyJJX6FFdpA?t=00h48m01s)

[do like yelling at you but I would](https://youtu.be/HyJJX6FFdpA?t=00h48m04s)

[prefer to do it less](https://youtu.be/HyJJX6FFdpA?t=00h48m05s)

[Okay so this guy should probably be](https://youtu.be/HyJJX6FFdpA?t=00h48m08s)

[nullable](https://youtu.be/HyJJX6FFdpA?t=00h48m10s)

[Stop it](https://youtu.be/HyJJX6FFdpA?t=00h48m13s)

[You're trying to be helpful and I'm](https://youtu.be/HyJJX6FFdpA?t=00h48m16s)

[trying to remind you that you are an](https://youtu.be/HyJJX6FFdpA?t=00h48m18s)

[idiot developer who needs to knock it](https://youtu.be/HyJJX6FFdpA?t=00h48m20s)

[off](https://youtu.be/HyJJX6FFdpA?t=00h48m22s)

[See a real developer I could just throw](https://youtu.be/HyJJX6FFdpA?t=00h48m24s)

[a rubber duck at co-pilot That's a lot](https://youtu.be/HyJJX6FFdpA?t=00h48m26s)

[more problematic Okay](https://youtu.be/HyJJX6FFdpA?t=00h48m29s)

[Okay Both of those tests h pass](https://youtu.be/HyJJX6FFdpA?t=00h48m35s)

[Now we're in happy case Okay Let's go](https://youtu.be/HyJJX6FFdpA?t=00h48m39s)

[here](https://youtu.be/HyJJX6FFdpA?t=00h48m42s)

[Right And so this is](https://youtu.be/HyJJX6FFdpA?t=00h48m44s)

[the interesting one because you'll know](https://youtu.be/HyJJX6FFdpA?t=00h48m47s)

[this thing here has already landed on](https://youtu.be/HyJJX6FFdpA?t=00h48m49s)

[the wrong overload because you can see](https://youtu.be/HyJJX6FFdpA?t=00h48m51s)

[it's wanting to return task of nullable](https://youtu.be/HyJJX6FFdpA?t=00h48m53s)

[task](https://youtu.be/HyJJX6FFdpA?t=00h48m55s)

[Um and that's only because of the way](https://youtu.be/HyJJX6FFdpA?t=00h48m57s)

[these things are written here and](https://youtu.be/HyJJX6FFdpA?t=00h48m59s)

[because in reality what I would really](https://youtu.be/HyJJX6FFdpA?t=00h49m02s)

[like is a remote execute function](https://youtu.be/HyJJX6FFdpA?t=00h49m04s)

[uh and this to be task](https://youtu.be/HyJJX6FFdpA?t=00h49m09s)

[Right Um because I don't want this to be](https://youtu.be/HyJJX6FFdpA?t=00h49m14s)

[t result](https://youtu.be/HyJJX6FFdpA?t=00h49m17s)

[I](https://youtu.be/HyJJX6FFdpA?t=00h49m20s)

[want this to just be task](https://youtu.be/HyJJX6FFdpA?t=00h49m21s)

[And we're going to end up reaxing our](https://youtu.be/HyJJX6FFdpA?t=00h49m26s)

[way to victory And this just becomes](https://youtu.be/HyJJX6FFdpA?t=00h49m29s)

[task](https://youtu.be/HyJJX6FFdpA?t=00h49m33s)

[Right That's that's where we're going](https://youtu.be/HyJJX6FFdpA?t=00h49m35s)

[And then](https://youtu.be/HyJJX6FFdpA?t=00h49m37s)

[yeah cuz the it's it's actually these](https://youtu.be/HyJJX6FFdpA?t=00h49m40s)

[ones down here that we're going for And](https://youtu.be/HyJJX6FFdpA?t=00h49m42s)

[then this just becomes object nullable](https://youtu.be/HyJJX6FFdpA?t=00h49m44s)

[with the same parameter types Really](https://youtu.be/HyJJX6FFdpA?t=00h49m50s)

[Is it down lower](https://youtu.be/HyJJX6FFdpA?t=00h49m53s)

[Uh where are you](https://youtu.be/HyJJX6FFdpA?t=00h49m57s)

[Action No you don't](https://youtu.be/HyJJX6FFdpA?t=00h50m02s)

[Where is it](https://youtu.be/HyJJX6FFdpA?t=00h50m05s)

[Funk of tea task](https://youtu.be/HyJJX6FFdpA?t=00h50m09s)

[Um](https://youtu.be/HyJJX6FFdpA?t=00h50m11s)

[do I need to do remote execute async](https://youtu.be/HyJJX6FFdpA?t=00h50m13s)

[just to disambiguate](https://youtu.be/HyJJX6FFdpA?t=00h50m15s)

[Please co-pilot you're not helping Stop](https://youtu.be/HyJJX6FFdpA?t=00h50m17s)

[it](https://youtu.be/HyJJX6FFdpA?t=00h50m20s)

[Um](https://youtu.be/HyJJX6FFdpA?t=00h50m23s)

[why does it](https://youtu.be/HyJJX6FFdpA?t=00h50m27s)

[Oh be](https://youtu.be/HyJJX6FFdpA?t=00h50m30s)

[I'm an idiot](https://youtu.be/HyJJX6FFdpA?t=00h50m33s)

[I'm an idiot is why](https://youtu.be/HyJJX6FFdpA?t=00h50m35s)

[there That should get me into the happy](https://youtu.be/HyJJX6FFdpA?t=00h50m38s)

[place So now when we look at this](https://youtu.be/HyJJX6FFdpA?t=00h50m41s)

[overload resolution it should be There](https://youtu.be/HyJJX6FFdpA?t=00h50m43s)

[we go So you'll note it's no longer task](https://youtu.be/HyJJX6FFdpA?t=00h50m46s)

[of task It's now just task because we've](https://youtu.be/HyJJX6FFdpA?t=00h50m49s)

[now set ourselves up with an overload](https://youtu.be/HyJJX6FFdpA?t=00h50m51s)

[that is slightly better](https://youtu.be/HyJJX6FFdpA?t=00h50m54s)

[So that gets us into a much better](https://youtu.be/HyJJX6FFdpA?t=00h50m57s)

[situation](https://youtu.be/HyJJX6FFdpA?t=00h51m01s)

[because now I think it's not going to](https://youtu.be/HyJJX6FFdpA?t=00h51m03s)

[try the cast on the return](https://youtu.be/HyJJX6FFdpA?t=00h51m04s)

[which now should get this to work I](https://youtu.be/HyJJX6FFdpA?t=00h51m07s)

[think](https://youtu.be/HyJJX6FFdpA?t=00h51m11s)

[like I said we'll go through and add a](https://youtu.be/HyJJX6FFdpA?t=00h51m12s)

[bunch of overloads once we get these](https://youtu.be/HyJJX6FFdpA?t=00h51m14s)

[working but because I think I want them](https://youtu.be/HyJJX6FFdpA?t=00h51m15s)

[all the way out Okay so that one works](https://youtu.be/HyJJX6FFdpA?t=00h51m17s)

[great we go here](https://youtu.be/HyJJX6FFdpA?t=00h51m21s)

[and then this one is absolutely](https://youtu.be/HyJJX6FFdpA?t=00h51m25s)

[problematic and this should really be](https://youtu.be/HyJJX6FFdpA?t=00h51m27s)

[string nullable](https://youtu.be/HyJJX6FFdpA?t=00h51m28s)

[Um but this one here if we go and look](https://youtu.be/HyJJX6FFdpA?t=00h51m30s)

[at it So this is actually going to come](https://youtu.be/HyJJX6FFdpA?t=00h51m33s)

[up here](https://youtu.be/HyJJX6FFdpA?t=00h51m37s)

[and it's going to be a little more akin](https://youtu.be/HyJJX6FFdpA?t=00h51m40s)

[to this](https://youtu.be/HyJJX6FFdpA?t=00h51m42s)

[Um this is going to be once again T](https://youtu.be/HyJJX6FFdpA?t=00h51m44s)

[result](https://youtu.be/HyJJX6FFdpA?t=00h51m48s)

[We'll put that back in And this is going](https://youtu.be/HyJJX6FFdpA?t=00h51m49s)

[to be](https://youtu.be/HyJJX6FFdpA?t=00h51m52s)

[uh yes co-pilot Now you're being helpful](https://youtu.be/HyJJX6FFdpA?t=00h51m54s)

[And then this becomes T result](https://youtu.be/HyJJX6FFdpA?t=00h51m57s)

[Okay So that one it actually figured](https://youtu.be/HyJJX6FFdpA?t=00h52m01s)

[itself out on](https://youtu.be/HyJJX6FFdpA?t=00h52m03s)

[overload resolution now works properly](https://youtu.be/HyJJX6FFdpA?t=00h52m05s)

[Now we run it](https://youtu.be/HyJJX6FFdpA?t=00h52m08s)

[And I think aside from adding a bunch of](https://youtu.be/HyJJX6FFdpA?t=00h52m13s)

[overloads which I don't bother to test](https://youtu.be/HyJJX6FFdpA?t=00h52m16s)

[every overload because that's kind of](https://youtu.be/HyJJX6FFdpA?t=00h52m18s)

[pointless Okay so that failed But why](https://youtu.be/HyJJX6FFdpA?t=00h52m20s)

[did it failed Expected test title actual](https://youtu.be/HyJJX6FFdpA?t=00h52m24s)

[async method builder blah blah blah blah](https://youtu.be/HyJJX6FFdpA?t=00h52m27s)

[blah It got the wrong thing](https://youtu.be/HyJJX6FFdpA?t=00h52m30s)

[back](https://youtu.be/HyJJX6FFdpA?t=00h52m34s)

[Um and it probably is doing the wrong](https://youtu.be/HyJJX6FFdpA?t=00h52m38s)

[thing on the other one too But because](https://youtu.be/HyJJX6FFdpA?t=00h52m40s)

[there's no serialization it doesn't care](https://youtu.be/HyJJX6FFdpA?t=00h52m42s)

[Um but this guy is making it through](https://youtu.be/HyJJX6FFdpA?t=00h52m47s)

[And so I think what we need to do is](https://youtu.be/HyJJX6FFdpA?t=00h52m51s)

[look at the execution on the other side](https://youtu.be/HyJJX6FFdpA?t=00h52m53s)

[Uh let's see Uh host](https://youtu.be/HyJJX6FFdpA?t=00h52m59s)

[invocation](https://youtu.be/HyJJX6FFdpA?t=00h53m03s)

[Yeah So I think we want to grab it here](https://youtu.be/HyJJX6FFdpA?t=00h53m07s)

[and take a look at](https://youtu.be/HyJJX6FFdpA?t=00h53m09s)

[at it because that will tell us why it's](https://youtu.be/HyJJX6FFdpA?t=00h53m12s)

[serializing the wrong value And I think](https://youtu.be/HyJJX6FFdpA?t=00h53m16s)

[it probably just needs some special](https://youtu.be/HyJJX6FFdpA?t=00h53m18s)

[cases to look for if it's if it's an](https://youtu.be/HyJJX6FFdpA?t=00h53m20s)

[async method which is not an easy thing](https://youtu.be/HyJJX6FFdpA?t=00h53m24s)

[to detect I will point out I I am](https://youtu.be/HyJJX6FFdpA?t=00h53m26s)

[acutely aware at how painful it is to do](https://youtu.be/HyJJX6FFdpA?t=00h53m30s)

[properly So it gets the element does the](https://youtu.be/HyJJX6FFdpA?t=00h53m33s)

[needful loads the assembly does the](https://youtu.be/HyJJX6FFdpA?t=00h53m35s)

[needful gets the method does this And](https://youtu.be/HyJJX6FFdpA?t=00h53m37s)

[this is where I think we're going to run](https://youtu.be/HyJJX6FFdpA?t=00h53m41s)

[into the problems because yeah it's just](https://youtu.be/HyJJX6FFdpA?t=00h53m42s)

[method invoking](https://youtu.be/HyJJX6FFdpA?t=00h53m45s)

[And I think what we want to do because](https://youtu.be/HyJJX6FFdpA?t=00h53m51s)

[this is already an asynchronous method](https://youtu.be/HyJJX6FFdpA?t=00h53m53s)

[Yeah Yeah Good good good good good](https://youtu.be/HyJJX6FFdpA?t=00h53m55s)

[So this response here](https://youtu.be/HyJJX6FFdpA?t=00h53m59s)

[is the async method right And so now the](https://youtu.be/HyJJX6FFdpA?t=00h54m01s)

[question becomes how do we want to](https://youtu.be/HyJJX6FFdpA?t=00h54m06s)

[validate this](https://youtu.be/HyJJX6FFdpA?t=00h54m09s)

[How do we want to validate this](https://youtu.be/HyJJX6FFdpA?t=00h54m15s)

[So the the the brain deadad way of doing](https://youtu.be/HyJJX6FFdpA?t=00h54m19s)

[it is we could look at the methods](https://youtu.be/HyJJX6FFdpA?t=00h54m22s)

[return type and go if you are a task or](https://youtu.be/HyJJX6FFdpA?t=00h54m23s)

[a task of t you're obviously there but](https://youtu.be/HyJJX6FFdpA?t=00h54m27s)

[then we have to handle task of task](https://youtu.be/HyJJX6FFdpA?t=00h54m29s)

[value task value task of t](https://youtu.be/HyJJX6FFdpA?t=00h54m32s)

[probably I awaitable there's a bunch of](https://youtu.be/HyJJX6FFdpA?t=00h54m36s)

[um](https://youtu.be/HyJJX6FFdpA?t=00h54m38s)

[a bunch of possibilities the other thing](https://youtu.be/HyJJX6FFdpA?t=00h54m40s)

[is we could actually try to implement](https://youtu.be/HyJJX6FFdpA?t=00h54m42s)

[asynchrony stuff](https://youtu.be/HyJJX6FFdpA?t=00h54m46s)

[We could try to implement asynchrony](https://youtu.be/HyJJX6FFdpA?t=00h54m53s)

[stuff](https://youtu.be/HyJJX6FFdpA?t=00h54m55s)

[which means we then need to look this up](https://youtu.be/HyJJX6FFdpA?t=00h54m58s)

[And the only the only thing that makes](https://youtu.be/HyJJX6FFdpA?t=00h55m01s)

[this a little hard So the things that](https://youtu.be/HyJJX6FFdpA?t=00h55m03s)

[are asynchronous right So I'll kill](https://youtu.be/HyJJX6FFdpA?t=00h55m05s)

[execution so we can work through this](https://youtu.be/HyJJX6FFdpA?t=00h55m08s)

[here real quick because the funny part](https://youtu.be/HyJJX6FFdpA?t=00h55m10s)

[is I helped a colleague with this not](https://youtu.be/HyJJX6FFdpA?t=00h55m12s)

[that long ago The things that you can](https://youtu.be/HyJJX6FFdpA?t=00h55m13s)

[put after this await are things that are](https://youtu.be/HyJJX6FFdpA?t=00h55m15s)

[awaitable Right So if we look at](https://youtu.be/HyJJX6FFdpA?t=00h55m18s)

[task.delay on here um the things that](https://youtu.be/HyJJX6FFdpA?t=00h55m20s)

[are awaitable contain this get a waiter](https://youtu.be/HyJJX6FFdpA?t=00h55m24s)

[Now get a waiter has to return something](https://youtu.be/HyJJX6FFdpA?t=00h55m27s)

[that has a signature that has I'm trying](https://youtu.be/HyJJX6FFdpA?t=00h55m31s)

[to remember all the things It's like on](https://youtu.be/HyJJX6FFdpA?t=00h55m34s)

[completed get result blah blah blah Like](https://youtu.be/HyJJX6FFdpA?t=00h55m36s)

[it has to it has to match a particular](https://youtu.be/HyJJX6FFdpA?t=00h55m39s)

[pattern In fact that pattern I've](https://youtu.be/HyJJX6FFdpA?t=00h55m41s)

[written before in my Calamities repo](https://youtu.be/HyJJX6FFdpA?t=00h55m44s)

[Uh for people who haven't seen this](https://youtu.be/HyJJX6FFdpA?t=00h55m49s)

[before this is a repo of code that you](https://youtu.be/HyJJX6FFdpA?t=00h55m50s)

[should absolutely never duplicate It's](https://youtu.be/HyJJX6FFdpA?t=00h55m52s)

[filled with bad stuff Like I couldn't](https://youtu.be/HyJJX6FFdpA?t=00h55m55s)

[name it any more explicitly Um but for](https://youtu.be/HyJJX6FFdpA?t=00h55m57s)

[example](https://youtu.be/HyJJX6FFdpA?t=00h56m00s)

[you'll note I've got this this task](https://youtu.be/HyJJX6FFdpA?t=00h56m01s)

[class here that is not the real task Um](https://youtu.be/HyJJX6FFdpA?t=00h56m04s)

[but in order to make that cla that task](https://youtu.be/HyJJX6FFdpA?t=00h56m07s)

[awaitable it needed to have a get a](https://youtu.be/HyJJX6FFdpA?t=00h56m10s)

[waiter method You'll note that get a](https://youtu.be/HyJJX6FFdpA?t=00h56m13s)

[waiter method needs to be something that](https://youtu.be/HyJJX6FFdpA?t=00h56m15s)

[is it could be an extension method It](https://youtu.be/HyJJX6FFdpA?t=00h56m18s)

[may not be actually on the type itself](https://youtu.be/HyJJX6FFdpA?t=00h56m20s)

[That's what that's what makes it hard to](https://youtu.be/HyJJX6FFdpA?t=00h56m23s)

[do the inspection like it is nearly](https://youtu.be/HyJJX6FFdpA?t=00h56m25s)

[impossible](https://youtu.be/HyJJX6FFdpA?t=00h56m27s)

[dare I say completely impossible to know](https://youtu.be/HyJJX6FFdpA?t=00h56m29s)

[at runtime what the compiler knew at](https://youtu.be/HyJJX6FFdpA?t=00h56m31s)

[compile time in terms of whether it's an](https://youtu.be/HyJJX6FFdpA?t=00h56m33s)

[awaitable type or not the](https://youtu.be/HyJJX6FFdpA?t=00h56m36s)

[the the thing that get a waiter has to](https://youtu.be/HyJJX6FFdpA?t=00h56m39s)

[return is also duct typed and it has to](https://youtu.be/HyJJX6FFdpA?t=00h56m42s)

[be something that has the same](https://youtu.be/HyJJX6FFdpA?t=00h56m44s)

[signatures as I notify completion which](https://youtu.be/HyJJX6FFdpA?t=00h56m47s)

[are these things here it doesn't have to](https://youtu.be/HyJJX6FFdpA?t=00h56m50s)

[implement the interface but that](https://youtu.be/HyJJX6FFdpA?t=00h56m52s)

[interface declares There's the shape](https://youtu.be/HyJJX6FFdpA?t=00h56m54s)

[that the compiler looks for And as long](https://youtu.be/HyJJX6FFdpA?t=00h56m56s)

[as it sees those members and those](https://youtu.be/HyJJX6FFdpA?t=00h56m58s)

[members have the right signatures you](https://youtu.be/HyJJX6FFdpA?t=00h57m01s)

[can await it That's the requirement So](https://youtu.be/HyJJX6FFdpA?t=00h57m03s)

[it's it's duct typing all the way down](https://youtu.be/HyJJX6FFdpA?t=00h57m06s)

[which is awesome right Like the C# team](https://youtu.be/HyJJX6FFdpA?t=00h57m09s)

[did this intentionally because it gave](https://youtu.be/HyJJX6FFdpA?t=00h57m11s)

[them lots of ways to do back compat They](https://youtu.be/HyJJX6FFdpA?t=00h57m12s)

[could then make things awaitable that](https://youtu.be/HyJJX6FFdpA?t=00h57m15s)

[were like in the BCL whose basic](https://youtu.be/HyJJX6FFdpA?t=00h57m17s)

[signatures were fixed that they couldn't](https://youtu.be/HyJJX6FFdpA?t=00h57m20s)

[change They could go through and make](https://youtu.be/HyJJX6FFdpA?t=00h57m21s)

[those things awaitable by just writing](https://youtu.be/HyJJX6FFdpA?t=00h57m23s)

[some extension methods Great Huzzah](https://youtu.be/HyJJX6FFdpA?t=00h57m24s)

[Even better But it means trying to](https://youtu.be/HyJJX6FFdpA?t=00h57m28s)

[detect it here is nigh impossible](https://youtu.be/HyJJX6FFdpA?t=00h57m31s)

[So my choices are](https://youtu.be/HyJJX6FFdpA?t=00h57m35s)

[option A We detect the stuff that's](https://youtu.be/HyJJX6FFdpA?t=00h57m38s)

[obvious and we don't worry about the](https://youtu.be/HyJJX6FFdpA?t=00h57m41s)

[edge cases where somebody tries to do it](https://youtu.be/HyJJX6FFdpA?t=00h57m43s)

[and we just make it not work Because we](https://youtu.be/HyJJX6FFdpA?t=00h57m46s)

[could say that ZAML test only is going](https://youtu.be/HyJJX6FFdpA?t=00h57m48s)

[to support task and task of T](https://youtu.be/HyJJX6FFdpA?t=00h57m52s)

[That's probably the path of least](https://youtu.be/HyJJX6FFdpA?t=00h57m58s)

[resistance There's very limited reason](https://youtu.be/HyJJX6FFdpA?t=00h57m59s)

[We could even support value task](https://youtu.be/HyJJX6FFdpA?t=00h58m02s)

[and value task of T and call it there](https://youtu.be/HyJJX6FFdpA?t=00h58m06s)

[That might be the path of least](https://youtu.be/HyJJX6FFdpA?t=00h58m12s)

[resistance I think that's the path that](https://youtu.be/HyJJX6FFdpA?t=00h58m13s)

[we're going to go because it's rare that](https://youtu.be/HyJJX6FFdpA?t=00h58m15s)

[anyone's going to invoke this and have](https://youtu.be/HyJJX6FFdpA?t=00h58m17s)

[their own custom type of anything](https://youtu.be/HyJJX6FFdpA?t=00h58m19s)

[because this is kind of a remote execute](https://youtu.be/HyJJX6FFdpA?t=00h58m21s)

[thing I'm kind of okay with doing this](https://youtu.be/HyJJX6FFdpA?t=00h58m23s)

[So uh let's see Private Oh wait Why am I](https://youtu.be/HyJJX6FFdpA?t=00h58m26s)

[doing this Um](https://youtu.be/HyJJX6FFdpA?t=00h58m30s)

[you know what Copilot you want to help](https://youtu.be/HyJJX6FFdpA?t=00h58m33s)

[You You've been You've been lazy all day](https://youtu.be/HyJJX6FFdpA?t=00h58m36s)

[Okay I want to check if the response](https://youtu.be/HyJJX6FFdpA?t=00h58m38s)

[type is task task of t](https://youtu.be/HyJJX6FFdpA?t=00h58m44s)

[uh value task or value task of t If it](https://youtu.be/HyJJX6FFdpA?t=00h58m49s)

[is one of these types](https://youtu.be/HyJJX6FFdpA?t=00h58m56s)

[I want to await it and set the](https://youtu.be/HyJJX6FFdpA?t=00h59m00s)

[value of](https://youtu.be/HyJJX6FFdpA?t=00h59m06s)

[response](https://youtu.be/HyJJX6FFdpA?t=00h59m09s)

[to be the result of the task Go](https://youtu.be/HyJJX6FFdpA?t=00h59m10s)

[impress me co-pilot](https://youtu.be/HyJJX6FFdpA?t=00h59m18s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=00h59m25s)

[let's see Um that is](https://youtu.be/HyJJX6FFdpA?t=00h59m27s)

[a functional implementation and a pretty](https://youtu.be/HyJJX6FFdpA?t=00h59m31s)

[garbage one at that](https://youtu.be/HyJJX6FFdpA?t=00h59m34s)

[Um](https://youtu.be/HyJJX6FFdpA?t=00h59m37s)

[yeah](https://youtu.be/HyJJX6FFdpA?t=00h59m39s)

[Okay So there's a number of problems](https://youtu.be/HyJJX6FFdpA?t=00h59m41s)

[with this Problem one](https://youtu.be/HyJJX6FFdpA?t=00h59m42s)

[uh let's see here](https://youtu.be/HyJJX6FFdpA?t=00h59m48s)

[Yeah I I know Izzy but I just gave a](https://youtu.be/HyJJX6FFdpA?t=00h59m55s)

[talk on this and and I'm kind of in a](https://youtu.be/HyJJX6FFdpA?t=00h59m57s)

[co-piloty mode](https://youtu.be/HyJJX6FFdpA?t=00h59m58s)

[Um](https://youtu.be/HyJJX6FFdpA?t=01h00m01s)

[yeah I don't like this implementation at](https://youtu.be/HyJJX6FFdpA?t=01h00m05s)

[all](https://youtu.be/HyJJX6FFdpA?t=01h00m07s)

[So configure await false though good](https://youtu.be/HyJJX6FFdpA?t=01h00m09s)

[practice is not going to be what we want](https://youtu.be/HyJJX6FFdpA?t=01h00m11s)

[here We do want this to be invoke and we](https://youtu.be/HyJJX6FFdpA?t=01h00m13s)

[want to make this an async delegate](https://youtu.be/HyJJX6FFdpA?t=01h00m16s)

[because I believe with this yes it it's](https://youtu.be/HyJJX6FFdpA?t=01h00m19s)

[so there's an important thing to note](https://youtu.be/HyJJX6FFdpA?t=01h00m23s)

[here right so I changed this to invoke](https://youtu.be/HyJJX6FFdpA?t=01h00m25s)

[and made this an async lambda but you'll](https://youtu.be/HyJJX6FFdpA?t=01h00m28s)

[note that that lambda is being converted](https://youtu.be/HyJJX6FFdpA?t=01h00m31s)

[into a funk of task that is important](https://youtu.be/HyJJX6FFdpA?t=01h00m34s)

[right that will get awaited here if you](https://youtu.be/HyJJX6FFdpA?t=01h00m37s)

[do invoke a sync](https://youtu.be/HyJJX6FFdpA?t=01h00m39s)

[I don't believe that's what happens](https://youtu.be/HyJJX6FFdpA?t=01h00m42s)

[right](https://youtu.be/HyJJX6FFdpA?t=01h00m45s)

[Oh interesting](https://youtu.be/HyJJX6FFdpA?t=01h00m48s)

[Oh maybe I've got this backwards](https://youtu.be/HyJJX6FFdpA?t=01h00m56s)

[Okay we're going to leave it there as](https://youtu.be/HyJJX6FFdpA?t=01h01m01s)

[that for now until but because we've got](https://youtu.be/HyJJX6FFdpA?t=01h01m04s)

[enough tests to verify that I haven't](https://youtu.be/HyJJX6FFdpA?t=01h01m06s)

[screwed this up Um](https://youtu.be/HyJJX6FFdpA?t=01h01m07s)

[I do love how it how it flipped to](https://youtu.be/HyJJX6FFdpA?t=01h01m11s)

[dynamic here to be able to to actually](https://youtu.be/HyJJX6FFdpA?t=01h01m13s)

[do the invocation That is kind of](https://youtu.be/HyJJX6FFdpA?t=01h01m16s)

[hilarious](https://youtu.be/HyJJX6FFdpA?t=01h01m19s)

[Um did it do that up above](https://youtu.be/HyJJX6FFdpA?t=01h01m21s)

[Oh no It didn't have to do that above](https://youtu.be/HyJJX6FFdpA?t=01h01m28s)

[because it's a task I wonder if value](https://youtu.be/HyJJX6FFdpA?t=01h01m30s)

[task is actually reasonable because the](https://youtu.be/HyJJX6FFdpA?t=01h01m33s)

[whole point of value task is something](https://youtu.be/HyJJX6FFdpA?t=01h01m35s)

[that's going to execute synchronously in](https://youtu.be/HyJJX6FFdpA?t=01h01m36s)

[most cases I don't think we need to](https://youtu.be/HyJJX6FFdpA?t=01h01m38s)

[support it because we're already](https://youtu.be/HyJJX6FFdpA?t=01h01m41s)

[shelling out to serialize and do IPC](https://youtu.be/HyJJX6FFdpA?t=01h01m44s)

[across the processes So I'm I think just](https://youtu.be/HyJJX6FFdpA?t=01h01m46s)

[task is all we care about](https://youtu.be/HyJJX6FFdpA?t=01h01m50s)

[Um this is potentially one of the most](https://youtu.be/HyJJX6FFdpA?t=01h01m52s)

[horrid implementations I have ever seen](https://youtu.be/HyJJX6FFdpA?t=01h01m55s)

[Thank you co-pilot for being absolute](https://youtu.be/HyJJX6FFdpA?t=01h02m01s)

[trash](https://youtu.be/HyJJX6FFdpA?t=01h02m04s)

[Um](https://youtu.be/HyJJX6FFdpA?t=01h02m06s)

[let's see here So I really want to just](https://youtu.be/HyJJX6FFdpA?t=01h02m09s)

[know cuz](https://youtu.be/HyJJX6FFdpA?t=01h02m11s)

[task](https://youtu.be/HyJJX6FFdpA?t=01h02m14s)

[I think I can actually get away with if](https://youtu.be/HyJJX6FFdpA?t=01h02m18s)

[response is task](https://youtu.be/HyJJX6FFdpA?t=01h02m20s)

[task response Stop doing configure await](https://youtu.be/HyJJX6FFdpA?t=01h02m26s)

[Knock it off Like we're intentionally](https://youtu.be/HyJJX6FFdpA?t=01h02m30s)

[touching UI objects That's a horrible Oh](https://youtu.be/HyJJX6FFdpA?t=01h02m32s)

[here Maybe we'll do it this way](https://youtu.be/HyJJX6FFdpA?t=01h02m35s)

[Configure await True Like we](https://youtu.be/HyJJX6FFdpA?t=01h02m37s)

[intentionally are marshalling ourselves](https://youtu.be/HyJJX6FFdpA?t=01h02m40s)

[onto the UI thread Stop flipping out of](https://youtu.be/HyJJX6FFdpA?t=01h02m42s)

[it Okay So we're going to do that](https://youtu.be/HyJJX6FFdpA?t=01h02m45s)

[And then I think what I want to do is](https://youtu.be/HyJJX6FFdpA?t=01h02m51s)

[task response](https://youtu.be/HyJJX6FFdpA?t=01h02m54s)

[Um](https://youtu.be/HyJJX6FFdpA?t=01h02m56s)

[oh cuz how do I get it into an arbitrary](https://youtu.be/HyJJX6FFdpA?t=01h02m59s)

[return type It's using reflection here](https://youtu.be/HyJJX6FFdpA?t=01h03m02s)

[and going after the result property](https://youtu.be/HyJJX6FFdpA?t=01h03m05s)

[Is that what I want](https://youtu.be/HyJJX6FFdpA?t=01h03m10s)

[I don't really like that](https://youtu.be/HyJJX6FFdpA?t=01h03m14s)

[The dynamic approach is one option](https://youtu.be/HyJJX6FFdpA?t=01h03m18s)

[Not sure I like that either](https://youtu.be/HyJJX6FFdpA?t=01h03m22s)

[Uh yeah bless it It only gets it from](https://youtu.be/HyJJX6FFdpA?t=01h03m24s)

[all the rubbish on GitHub How's it](https://youtu.be/HyJJX6FFdpA?t=01h03m28s)

[supposed to know that 99% of that is](https://youtu.be/HyJJX6FFdpA?t=01h03m30s)

[just wrong Yeah exactly The only saving](https://youtu.be/HyJJX6FFdpA?t=01h03m32s)

[grace it has is that it's technically a](https://youtu.be/HyJJX6FFdpA?t=01h03m35s)

[curated set of GitHub It's not the blind](https://youtu.be/HyJJX6FFdpA?t=01h03m37s)

[full set because that would be bad But](https://youtu.be/HyJJX6FFdpA?t=01h03m39s)

[even the curated stuff is filled with](https://youtu.be/HyJJX6FFdpA?t=01h03m41s)

[bad code as well Like just because it's](https://youtu.be/HyJJX6FFdpA?t=01h03m44s)

[written by you know something with a lot](https://youtu.be/HyJJX6FFdpA?t=01h03m46s)

[of stars or similar like it doesn't make](https://youtu.be/HyJJX6FFdpA?t=01h03m49s)

[it great code It just means it was](https://youtu.be/HyJJX6FFdpA?t=01h03m51s)

[popular](https://youtu.be/HyJJX6FFdpA?t=01h03m54s)

[Popular doesn't always mean good Okay](https://youtu.be/HyJJX6FFdpA?t=01h03m56s)

[But the question being is if it is a](https://youtu.be/HyJJX6FFdpA?t=01h04m00s)

[task of t how do I get the result out](https://youtu.be/HyJJX6FFdpA?t=01h04m02s)

[Because over here and I can get away](https://youtu.be/HyJJX6FFdpA?t=01h04m05s)

[with this because task of t derives from](https://youtu.be/HyJJX6FFdpA?t=01h04m08s)

[task right](https://youtu.be/HyJJX6FFdpA?t=01h04m11s)

[So I could I can do I could do this](https://youtu.be/HyJJX6FFdpA?t=01h04m14s)

[maneuver The hard part is figuring out](https://youtu.be/HyJJX6FFdpA?t=01h04m17s)

[if I'm in this situation and I don't](https://youtu.be/HyJJX6FFdpA?t=01h04m20s)

[know my type](https://youtu.be/HyJJX6FFdpA?t=01h04m23s)

[uh Microsoft code is generally worse](https://youtu.be/HyJJX6FFdpA?t=01h04m25s)

[than general GitHub There are absolutely](https://youtu.be/HyJJX6FFdpA?t=01h04m28s)

[some repos where that is true That is](https://youtu.be/HyJJX6FFdpA?t=01h04m29s)

[is the reflection option really the best](https://youtu.be/HyJJX6FFdpA?t=01h04m34s)

[choice](https://youtu.be/HyJJX6FFdpA?t=01h04m36s)

[because I am kind of wondering if I do](https://youtu.be/HyJJX6FFdpA?t=01h04m38s)

[this](https://youtu.be/HyJJX6FFdpA?t=01h04m40s)

[um](https://youtu.be/HyJJX6FFdpA?t=01h04m42s)

[because this](https://youtu.be/HyJJX6FFdpA?t=01h04m45s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=01h04m48s)

[this doesn't bother me that much but I](https://youtu.be/HyJJX6FFdpA?t=01h04m53s)

[might do task response Um because I](https://youtu.be/HyJJX6FFdpA?t=01h04m56s)

[don't like using the method signature](https://youtu.be/HyJJX6FFdpA?t=01h04m59s)

[completely I kind of like getting the](https://youtu.be/HyJJX6FFdpA?t=01h05m01s)

[runtime type That way I'll await it](https://youtu.be/HyJJX6FFdpA?t=01h05m03s)

[regardless](https://youtu.be/HyJJX6FFdpA?t=01h05m07s)

[Uh let's see](https://youtu.be/HyJJX6FFdpA?t=01h05m09s)

[Let's do this and go type task type gets](https://youtu.be/HyJJX6FFdpA?t=01h05m11s)

[that and then we're going to go here](https://youtu.be/HyJJX6FFdpA?t=01h05m15s)

[task type](https://youtu.be/HyJJX6FFdpA?t=01h05m18s)

[and then we're going to simplify this](https://youtu.be/HyJJX6FFdpA?t=01h05m22s)

[task type](https://youtu.be/HyJJX6FFdpA?t=01h05m26s)

[I don't need that I don't need that](https://youtu.be/HyJJX6FFdpA?t=01h05m29s)

[and then](https://youtu.be/HyJJX6FFdpA?t=01h05m32s)

[task type get property result](https://youtu.be/HyJJX6FFdpA?t=01h05m36s)

[because that's going to get the runtime](https://youtu.be/HyJJX6FFdpA?t=01h05m40s)

[one And I think what I actually want](https://youtu.be/HyJJX6FFdpA?t=01h05m42s)

[this to be is name of because we should](https://youtu.be/HyJJX6FFdpA?t=01h05m45s)

[be able to get away of task No stop it](https://youtu.be/HyJJX6FFdpA?t=01h05m48s)

[Stop it](https://youtu.be/HyJJX6FFdpA?t=01h05m52s)

[Result](https://youtu.be/HyJJX6FFdpA?t=01h05m55s)

[Oh that's right I can't do that yet](https://youtu.be/HyJJX6FFdpA?t=01h05m56s)

[That's a C# 14 feature We'll soon be](https://youtu.be/HyJJX6FFdpA?t=01h05m58s)

[able to do this where we can just do](https://youtu.be/HyJJX6FFdpA?t=01h06m02s)

[this right So huzzah Um get value](https://youtu.be/HyJJX6FFdpA?t=01h06m04s)

[task response](https://youtu.be/HyJJX6FFdpA?t=01h06m10s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=01h06m12s)

[uh how does everyone else do it What do](https://youtu.be/HyJJX6FFdpA?t=01h06m18s)

[you mean by it Izzy](https://youtu.be/HyJJX6FFdpA?t=01h06m20s)

[Uh let's see here So there is](https://youtu.be/HyJJX6FFdpA?t=01h06m25s)

[there's what I think is a functional](https://youtu.be/HyJJX6FFdpA?t=01h06m29s)

[implementation](https://youtu.be/HyJJX6FFdpA?t=01h06m31s)

[I think that's a functional](https://youtu.be/HyJJX6FFdpA?t=01h06m33s)

[implementation So let's go back to our](https://youtu.be/HyJJX6FFdpA?t=01h06m34s)

[test Get rid of this and let's debug](https://youtu.be/HyJJX6FFdpA?t=01h06m36s)

[through here because I think this will](https://youtu.be/HyJJX6FFdpA?t=01h06m40s)

[get us through here](https://youtu.be/HyJJX6FFdpA?t=01h06m43s)

[I'm a little unhappy about the the](https://youtu.be/HyJJX6FFdpA?t=01h06m50s)

[reflection call there](https://youtu.be/HyJJX6FFdpA?t=01h06m52s)

[You know what I could do](https://youtu.be/HyJJX6FFdpA?t=01h06m56s)

[Okay we're gonna we're going to clean](https://youtu.be/HyJJX6FFdpA?t=01h07m00s)

[Assuming this works I've got an idea on](https://youtu.be/HyJJX6FFdpA?t=01h07m02s)

[how to clean this up So that should be a](https://youtu.be/HyJJX6FFdpA?t=01h07m03s)

[task response](https://youtu.be/HyJJX6FFdpA?t=01h07m06s)

[Oh is it going to shoot itself in the](https://youtu.be/HyJJX6FFdpA?t=01h07m10s)

[foot](https://youtu.be/HyJJX6FFdpA?t=01h07m12s)

[Uh okay Don't know what that was about](https://youtu.be/HyJJX6FFdpA?t=01h07m14s)

[And then it goes here right](https://youtu.be/HyJJX6FFdpA?t=01h07m17s)

[task type](https://youtu.be/HyJJX6FFdpA?t=01h07m24s)

[Oh](https://youtu.be/HyJJX6FFdpA?t=01h07m26s)

[it's redone it Oh I forgot about that It](https://youtu.be/HyJJX6FFdpA?t=01h07m29s)

[doesn't return a task Writing code and](https://youtu.be/HyJJX6FFdpA?t=01h07m34s)

[making standards](https://youtu.be/HyJJX6FFdpA?t=01h07m36s)

[Um](https://youtu.be/HyJJX6FFdpA?t=01h07m39s)

[yeah](https://youtu.be/HyJJX6FFdpA?t=01h07m44s)

[sorry I'm distracted here I forgot the](https://youtu.be/HyJJX6FFdpA?t=01h07m47s)

[fact that I declared my method with a](https://youtu.be/HyJJX6FFdpA?t=01h07m50s)

[task return doesn't mean that it returns](https://youtu.be/HyJJX6FFdpA?t=01h07m53s)

[a task Forgot about that detail Forgot](https://youtu.be/HyJJX6FFdpA?t=01h07m55s)

[about that detail It doesn't return a](https://youtu.be/HyJJX6FFdpA?t=01h07m59s)

[task How silly of me How absolutely](https://youtu.be/HyJJX6FFdpA?t=01h08m01s)

[insanely stupidly silly of me Um which](https://youtu.be/HyJJX6FFdpA?t=01h08m04s)

[is why this signature will not work And](https://youtu.be/HyJJX6FFdpA?t=01h08m08s)

[I actually have to do](https://youtu.be/HyJJX6FFdpA?t=01h08m11s)

[I actually have to rely on the method](https://youtu.be/HyJJX6FFdpA?t=01h08m13s)

[signature don't I](https://youtu.be/HyJJX6FFdpA?t=01h08m15s)

[um](https://youtu.be/HyJJX6FFdpA?t=01h08m18s)

[to be able to have this work That is](https://youtu.be/HyJJX6FFdpA?t=01h08m20s)

[absolutely dumb I forgot about that So](https://youtu.be/HyJJX6FFdpA?t=01h08m23s)

[because the async keyword lets the](https://youtu.be/HyJJX6FFdpA?t=01h08m26s)

[compiler rewrite your function the](https://youtu.be/HyJJX6FFdpA?t=01h08m28s)

[return type from your function is](https://youtu.be/HyJJX6FFdpA?t=01h08m31s)

[something that deres from task but it is](https://youtu.be/HyJJX6FFdpA?t=01h08m32s)

[not itself task So when you act on the](https://youtu.be/HyJJX6FFdpA?t=01h08m34s)

[runtime type](https://youtu.be/HyJJX6FFdpA?t=01h08m38s)

[that does not work](https://youtu.be/HyJJX6FFdpA?t=01h08m41s)

[Okay there we go There we go There we go](https://youtu.be/HyJJX6FFdpA?t=01h08m43s)

[There we go There we go So now my](https://youtu.be/HyJJX6FFdpA?t=01h08m47s)

[response is string right And so my value](https://youtu.be/HyJJX6FFdpA?t=01h08m49s)

[type](https://youtu.be/HyJJX6FFdpA?t=01h08m54s)

[Oh I need to change this up](https://youtu.be/HyJJX6FFdpA?t=01h08m57s)

[Um](https://youtu.be/HyJJX6FFdpA?t=01h09m04s)

[let's see Because I need](https://youtu.be/HyJJX6FFdpA?t=01h09m06s)

[I need to change](https://youtu.be/HyJJX6FFdpA?t=01h09m12s)

[the Okay sorry I see a bug that's about](https://youtu.be/HyJJX6FFdpA?t=01h09m14s)

[to occur here in just a moment So this](https://youtu.be/HyJJX6FFdpA?t=01h09m17s)

[is only valid in the else case](https://youtu.be/HyJJX6FFdpA?t=01h09m20s)

[And then up here what we need to do is](https://youtu.be/HyJJX6FFdpA?t=01h09m23s)

[let's see in the else case here](https://youtu.be/HyJJX6FFdpA?t=01h09m27s)

[it's easy because we effectively set our](https://youtu.be/HyJJX6FFdpA?t=01h09m30s)

[return type](https://youtu.be/HyJJX6FFdpA?t=01h09m33s)

[to be void](https://youtu.be/HyJJX6FFdpA?t=01h09m35s)

[Um](https://youtu.be/HyJJX6FFdpA?t=01h09m40s)

[because this is the the functional](https://youtu.be/HyJJX6FFdpA?t=01h09m41s)

[return type Oh stop your complaining Uh](https://youtu.be/HyJJX6FFdpA?t=01h09m44s)

[uh let's see](https://youtu.be/HyJJX6FFdpA?t=01h09m50s)

[Oh and actually do we need to set this I](https://youtu.be/HyJJX6FFdpA?t=01h09m53s)

[think we do Uh let's see Nope Stop it](https://youtu.be/HyJJX6FFdpA?t=01h09m57s)

[Stop it Assembly qualified name There we](https://youtu.be/HyJJX6FFdpA?t=01h10m01s)

[go Now up above here we actually need to](https://youtu.be/HyJJX6FFdpA?t=01h10m04s)

[pull out the generic parameter](https://youtu.be/HyJJX6FFdpA?t=01h10m08s)

[from the task](https://youtu.be/HyJJX6FFdpA?t=01h10m12s)

[to return it So in this case the type](https://youtu.be/HyJJX6FFdpA?t=01h10m17s)

[that I want to use is going to be uh](https://youtu.be/HyJJX6FFdpA?t=01h10m21s)

[task type get generic](https://youtu.be/HyJJX6FFdpA?t=01h10m25s)

[arguments](https://youtu.be/HyJJX6FFdpA?t=01h10m30s)

[and I think it is safe](https://youtu.be/HyJJX6FFdpA?t=01h10m32s)

[to do subzero here because our generic](https://youtu.be/HyJJX6FFdpA?t=01h10m35s)

[type definition is equal to task](https://youtu.be/HyJJX6FFdpA?t=01h10m38s)

[with arity one and I I can say a one](https://youtu.be/HyJJX6FFdpA?t=01h10m42s)

[because there's not a comma in here](https://youtu.be/HyJJX6FFdpA?t=01h10m45s)

[right or anything like that So I think](https://youtu.be/HyJJX6FFdpA?t=01h10m47s)

[Subzero is safe here But we've got a](https://youtu.be/HyJJX6FFdpA?t=01h10m50s)

[test on both sides of this So as long as](https://youtu.be/HyJJX6FFdpA?t=01h10m53s)

[the test pass we'll be okay Oh and I've](https://youtu.be/HyJJX6FFdpA?t=01h10m56s)

[got a lone ZAML test process which is](https://youtu.be/HyJJX6FFdpA?t=01h10m58s)

[probably about to hang my build](https://youtu.be/HyJJX6FFdpA?t=01h11m02s)

[Oh maybe not Maybe not Will this work](https://youtu.be/HyJJX6FFdpA?t=01h11m05s)

[with value test Uh good question Maggers](https://youtu.be/HyJJX6FFdpA?t=01h11m09s)

[No And I don't know that it needs to And](https://youtu.be/HyJJX6FFdpA?t=01h11m11s)

[and the reason I say that is if you're](https://youtu.be/HyJJX6FFdpA?t=01h11m14s)

[using the remote execute here you're](https://youtu.be/HyJJX6FFdpA?t=01h11m17s)

[sending you're making an IPC call from](https://youtu.be/HyJJX6FFdpA?t=01h11m20s)

[one process to another to have it call](https://youtu.be/HyJJX6FFdpA?t=01h11m23s)

[back into a function inside of your](https://youtu.be/HyJJX6FFdpA?t=01h11m26s)

[assembly Value tasks are useful when the](https://youtu.be/HyJJX6FFdpA?t=01h11m28s)

[most common case is synchronous because](https://youtu.be/HyJJX6FFdpA?t=01h11m32s)

[value tasks take a they're they're very](https://youtu.be/HyJJX6FFdpA?t=01h11m35s)

[efficient and don't require um the same](https://youtu.be/HyJJX6FFdpA?t=01h11m37s)

[level of allocation as a task when the](https://youtu.be/HyJJX6FFdpA?t=01h11m40s)

[thing can execute synchronously but they](https://youtu.be/HyJJX6FFdpA?t=01h11m43s)

[take a slightly larger hit when they](https://youtu.be/HyJJX6FFdpA?t=01h11m46s)

[have to convert themselves into a full](https://youtu.be/HyJJX6FFdpA?t=01h11m48s)

[task for the asynchronous case So a lot](https://youtu.be/HyJJX6FFdpA?t=01h11m50s)

[of value task methods are things like um](https://youtu.be/HyJJX6FFdpA?t=01h11m53s)

[checking caches right Where if you want](https://youtu.be/HyJJX6FFdpA?t=01h11m56s)

[to be really optimistic of cache hit a](https://youtu.be/HyJJX6FFdpA?t=01h11m59s)

[value task is fine because that probably](https://youtu.be/HyJJX6FFdpA?t=01h12m02s)

[returns synchronously and can go back](https://youtu.be/HyJJX6FFdpA?t=01h12m04s)

[quickly But on the uh the miss case it's](https://youtu.be/HyJJX6FFdpA?t=01h12m05s)

[like well no actually I need to go](https://youtu.be/HyJJX6FFdpA?t=01h12m09s)

[asynchronous I'm going to need a full](https://youtu.be/HyJJX6FFdpA?t=01h12m10s)

[task That way I've got something to](https://youtu.be/HyJJX6FFdpA?t=01h12m12s)

[await on](https://youtu.be/HyJJX6FFdpA?t=01h12m14s)

[um to have that go through and work So](https://youtu.be/HyJJX6FFdpA?t=01h12m16s)

[this is not going to work with value](https://youtu.be/HyJJX6FFdpA?t=01h12m18s)

[task but I don't know that it needs to](https://youtu.be/HyJJX6FFdpA?t=01h12m20s)

[because the synchronous case is](https://youtu.be/HyJJX6FFdpA?t=01h12m22s)

[effectively impossible inside of this](https://youtu.be/HyJJX6FFdpA?t=01h12m25s)

[library](https://youtu.be/HyJJX6FFdpA?t=01h12m27s)

[Okay And this should be string Yeah good](https://youtu.be/HyJJX6FFdpA?t=01h12m29s)

[Okay So that that set that up](https://youtu.be/HyJJX6FFdpA?t=01h12m33s)

[Serialize the value Great](https://youtu.be/HyJJX6FFdpA?t=01h12m37s)

[And now that should I think have just](https://youtu.be/HyJJX6FFdpA?t=01h12m41s)

[passed](https://youtu.be/HyJJX6FFdpA?t=01h12m44s)

[Did it pass or did it fail It failed](https://youtu.be/HyJJX6FFdpA?t=01h12m46s)

[Expected test title actual null So](https://youtu.be/HyJJX6FFdpA?t=01h12m51s)

[there's there's a thing on](https://youtu.be/HyJJX6FFdpA?t=01h12m54s)

[um](https://youtu.be/HyJJX6FFdpA?t=01h12m59s)

[there's an issue on the deserialization](https://youtu.be/HyJJX6FFdpA?t=01h13m03s)

[on the other side But I also want to](https://youtu.be/HyJJX6FFdpA?t=01h13m06s)

[just debug this side of it real quick to](https://youtu.be/HyJJX6FFdpA?t=01h13m08s)

[make sure that this works properly](https://youtu.be/HyJJX6FFdpA?t=01h13m10s)

[because this should now hit the opposite](https://youtu.be/HyJJX6FFdpA?t=01h13m14s)

[of this](https://youtu.be/HyJJX6FFdpA?t=01h13m16s)

[and then continue on normally and still](https://youtu.be/HyJJX6FFdpA?t=01h13m18s)

[functionally work Now it probably](https://youtu.be/HyJJX6FFdpA?t=01h13m20s)

[continues to pass because there there's](https://youtu.be/HyJJX6FFdpA?t=01h13m22s)

[no deserialization on the other side](https://youtu.be/HyJJX6FFdpA?t=01h13m24s)

[Okay So this one is](https://youtu.be/HyJJX6FFdpA?t=01h13m27s)

[still failing but it's probably failing](https://youtu.be/HyJJX6FFdpA?t=01h13m32s)

[uh in here Go to implementation](https://youtu.be/HyJJX6FFdpA?t=01h13m36s)

[and it's probably failing](https://youtu.be/HyJJX6FFdpA?t=01h13m40s)

[here So](https://youtu.be/HyJJX6FFdpA?t=01h13m44s)

[I'm somewhat confident that's where I'm](https://youtu.be/HyJJX6FFdpA?t=01h13m47s)

[looking](https://youtu.be/HyJJX6FFdpA?t=01h13m49s)

[Okay So there's that Just going to check](https://youtu.be/HyJJX6FFdpA?t=01h13m54s)

[it one more time to make sure that we](https://youtu.be/HyJJX6FFdpA?t=01h13m56s)

[got all the things](https://youtu.be/HyJJX6FFdpA?t=01h13m57s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=01h14m00s)

[Reply value type is null](https://youtu.be/HyJJX6FFdpA?t=01h14m02s)

[I'm actually surprised](https://youtu.be/HyJJX6FFdpA?t=01h14m06s)

[value is empty string](https://youtu.be/HyJJX6FFdpA?t=01h14m11s)

[Did I launch the wrong method](https://youtu.be/HyJJX6FFdpA?t=01h14m14s)

[My delegate](https://youtu.be/HyJJX6FFdpA?t=01h14m20s)

[No this is task of string So it it got](https://youtu.be/HyJJX6FFdpA?t=01h14m22s)

[nothing](https://youtu.be/HyJJX6FFdpA?t=01h14m25s)

[something is off I hit those break](https://youtu.be/HyJJX6FFdpA?t=01h14m29s)

[points in not in the order I expected](https://youtu.be/HyJJX6FFdpA?t=01h14m31s)

[which is also surprising cuz I expected](https://youtu.be/HyJJX6FFdpA?t=01h14m33s)

[to get all the way down through](https://youtu.be/HyJJX6FFdpA?t=01h14m36s)

[here and here](https://youtu.be/HyJJX6FFdpA?t=01h14m39s)

[So let's let's make sure that we're](https://youtu.be/HyJJX6FFdpA?t=01h14m42s)

[actually getting that far](https://youtu.be/HyJJX6FFdpA?t=01h14m43s)

[I wonder if I'm getting bit by that um](https://youtu.be/HyJJX6FFdpA?t=01h14m46s)

[dispatch Jync JC good morning Good](https://youtu.be/HyJJX6FFdpA?t=01h14m51s)

[morning Oh look at that It is jumping](https://youtu.be/HyJJX6FFdpA?t=01h14m54s)

[See I I Okay that's okay](https://youtu.be/HyJJX6FFdpA?t=01h15m00s)

[Okay Okay I thought there was something](https://youtu.be/HyJJX6FFdpA?t=01h15m04s)

[about I I vaguely recall this guy not](https://youtu.be/HyJJX6FFdpA?t=01h15m08s)

[waiting for its delegate to completely](https://youtu.be/HyJJX6FFdpA?t=01h15m12s)

[await So as soon as it hits here it's](https://youtu.be/HyJJX6FFdpA?t=01h15m13s)

[allowing the other one to execute And we](https://youtu.be/HyJJX6FFdpA?t=01h15m15s)

[want this thing to completely finish](https://youtu.be/HyJJX6FFdpA?t=01h15m17s)

[See this is why we have these tests](https://youtu.be/HyJJX6FFdpA?t=01h15m20s)

[because it guarantees that I get to see](https://youtu.be/HyJJX6FFdpA?t=01h15m23s)

[all the things Okay so I hit this](https://youtu.be/HyJJX6FFdpA?t=01h15m25s)

[breakpoint and I shouldn't hit the other](https://youtu.be/HyJJX6FFdpA?t=01h15m28s)

[one until after I get done here](https://youtu.be/HyJJX6FFdpA?t=01h15m29s)

[which is good Value type is set Value is](https://youtu.be/HyJJX6FFdpA?t=01h15m32s)

[set Great Now when I F5 I should hit the](https://youtu.be/HyJJX6FFdpA?t=01h15m36s)

[other breakpoint There we are Value type](https://youtu.be/HyJJX6FFdpA?t=01h15m39s)

[comes in here There we've got the value](https://youtu.be/HyJJX6FFdpA?t=01h15m43s)

[Now we des serialize](https://youtu.be/HyJJX6FFdpA?t=01h15m46s)

[Now hopefully I just F5 and the test](https://youtu.be/HyJJX6FFdpA?t=01h15m48s)

[passes Um](https://youtu.be/HyJJX6FFdpA?t=01h15m51s)

[let's see Velop question Is there any](https://youtu.be/HyJJX6FFdpA?t=01h15m54s)

[documentation on how to downgrade a](https://youtu.be/HyJJX6FFdpA?t=01h15m56s)

[release](https://youtu.be/HyJJX6FFdpA?t=01h15m59s)

[No](https://youtu.be/HyJJX6FFdpA?t=01h16m05s)

[And there probably should be There](https://youtu.be/HyJJX6FFdpA?t=01h16m07s)

[probably should be](https://youtu.be/HyJJX6FFdpA?t=01h16m09s)

[um the So there's](https://youtu.be/HyJJX6FFdpA?t=01h16m12s)

[let let me ask a follow-up question Are](https://youtu.be/HyJJX6FFdpA?t=01h16m20s)

[you wanting to force a downgrade](https://youtu.be/HyJJX6FFdpA?t=01h16m23s)

[Um](https://youtu.be/HyJJX6FFdpA?t=01h16m27s)

[yeah I just compiled the old release](https://youtu.be/HyJJX6FFdpA?t=01h16m29s)

[packed it and then had the user run](https://youtu.be/HyJJX6FFdpA?t=01h16m31s)

[setup .exe Yeah So there's a couple](https://youtu.be/HyJJX6FFdpA?t=01h16m32s)

[there's a couple ways of going through](https://youtu.be/HyJJX6FFdpA?t=01h16m36s)

[and dealing with it and it depends on](https://youtu.be/HyJJX6FFdpA?t=01h16m38s)

[what you are looking for Let me let me](https://youtu.be/HyJJX6FFdpA?t=01h16m40s)

[real quick I don't want to lose this](https://youtu.be/HyJJX6FFdpA?t=01h16m42s)

[request I want to](https://youtu.be/HyJJX6FFdpA?t=01h16m44s)

[um new issue](https://youtu.be/HyJJX6FFdpA?t=01h16m48s)

[uh add documentation for downgrading a](https://youtu.be/HyJJX6FFdpA?t=01h16m50s)

[release](https://youtu.be/HyJJX6FFdpA?t=01h16m56s)

[So there there's a couple there's a](https://youtu.be/HyJJX6FFdpA?t=01h16m58s)

[couple ways of going through and uh I'll](https://youtu.be/HyJJX6FFdpA?t=01h17m00s)

[assign myself to it Uh I did want to](https://youtu.be/HyJJX6FFdpA?t=01h17m03s)

[force a downgrade So there's there's a](https://youtu.be/HyJJX6FFdpA?t=01h17m07s)

[couple ways to approach](https://youtu.be/HyJJX6FFdpA?t=01h17m08s)

[it](https://youtu.be/HyJJX6FFdpA?t=01h17m11s)

[and it depends a little bit on how you](https://youtu.be/HyJJX6FFdpA?t=01h17m13s)

[code the client side of the application](https://youtu.be/HyJJX6FFdpA?t=01h17m15s)

[So your update manager um you can pull](https://youtu.be/HyJJX6FFdpA?t=01h17m19s)

[back a list of releases right And if you](https://youtu.be/HyJJX6FFdpA?t=01h17m23s)

[just use the the cheater helper methods](https://youtu.be/HyJJX6FFdpA?t=01h17m27s)

[all it does is grab latest and then uses](https://youtu.be/HyJJX6FFdpA?t=01h17m30s)

[that to it compares latest with current](https://youtu.be/HyJJX6FFdpA?t=01h17m32s)

[and says "Oh okay If latest is greater](https://youtu.be/HyJJX6FFdpA?t=01h17m35s)

[than current then there's an update do](https://youtu.be/HyJJX6FFdpA?t=01h17m37s)

[the download etc etc etc." Right](https://youtu.be/HyJJX6FFdpA?t=01h17m39s)

[If you want to be able to have your](https://youtu.be/HyJJX6FFdpA?t=01h17m43s)

[client or have your server force the](https://youtu.be/HyJJX6FFdpA?t=01h17m45s)

[client backwards you need to not](https://youtu.be/HyJJX6FFdpA?t=01h17m48s)

[leverage the builtin function for doing](https://youtu.be/HyJJX6FFdpA?t=01h17m51s)

[that And let me just I think I can](https://youtu.be/HyJJX6FFdpA?t=01h17m54s)

[that's not the Velopac repository Let me](https://youtu.be/HyJJX6FFdpA?t=01h17m57s)

[grab the actual Velopac repository The](https://youtu.be/HyJJX6FFdpA?t=01h17m59s)

[so on the on the client side what you](https://youtu.be/HyJJX6FFdpA?t=01h18m05s)

[can do is you can](https://youtu.be/HyJJX6FFdpA?t=01h18m08s)

[change it so that it checks for the](https://youtu.be/HyJJX6FFdpA?t=01h18m10s)

[pending releases and if the latest](https://youtu.be/HyJJX6FFdpA?t=01h18m12s)

[release is not equal right which is very](https://youtu.be/HyJJX6FFdpA?t=01h18m15s)

[different than greater than right If the](https://youtu.be/HyJJX6FFdpA?t=01h18m18s)

[current release is not equal to your](https://youtu.be/HyJJX6FFdpA?t=01h18m22s)

[current one you can then force you can](https://youtu.be/HyJJX6FFdpA?t=01h18m24s)

[have your client then say "No no no I'm](https://youtu.be/HyJJX6FFdpA?t=01h18m27s)

[going to assume that this is a force](https://youtu.be/HyJJX6FFdpA?t=01h18m30s)

[downgrade](https://youtu.be/HyJJX6FFdpA?t=01h18m31s)

[and push it through." Right Like that](https://youtu.be/HyJJX6FFdpA?t=01h18m33s)

[that is an option The other way that um](https://youtu.be/HyJJX6FFdpA?t=01h18m35s)

[is a way to do it because fellow pack](https://youtu.be/HyJJX6FFdpA?t=01h18m41s)

[doesn't necessarily control whether](https://youtu.be/HyJJX6FFdpA?t=01h18m43s)

[you're going to force an upgrade or a](https://youtu.be/HyJJX6FFdpA?t=01h18m46s)

[downgrade](https://youtu.be/HyJJX6FFdpA?t=01h18m48s)

[right like the update manager is in your](https://youtu.be/HyJJX6FFdpA?t=01h18m50s)

[control to decide what that needs to](https://youtu.be/HyJJX6FFdpA?t=01h18m52s)

[look like So here real quick just to to](https://youtu.be/HyJJX6FFdpA?t=01h18m55s)

[show what I'm talking about the I guess](https://youtu.be/HyJJX6FFdpA?t=01h18m58s)

[I can go to the samples right So if I](https://youtu.be/HyJJX6FFdpA?t=01h19m01s)

[open up one of these guys](https://youtu.be/HyJJX6FFdpA?t=01h19m03s)

[right because the samples just show the](https://youtu.be/HyJJX6FFdpA?t=01h19m08s)

[the simple path for check for updates](https://youtu.be/HyJJX6FFdpA?t=01h19m09s)

[But check for updates again does a very](https://youtu.be/HyJJX6FFdpA?t=01h19m12s)

[simple](https://youtu.be/HyJJX6FFdpA?t=01h19m15s)

[um this right there's a new version](https://youtu.be/HyJJX6FFdpA?t=01h19m17s)

[available easy right this should allow](https://youtu.be/HyJJX6FFdpA?t=01h19m20s)

[version downgrade](https://youtu.be/HyJJX6FFdpA?t=01h19m25s)

[will allow it to go older right um and](https://youtu.be/HyJJX6FFdpA?t=01h19m27s)

[then the the non-default channel which](https://youtu.be/HyJJX6FFdpA?t=01h19m32s)

[is probably not what you wanted but the](https://youtu.be/HyJJX6FFdpA?t=01h19m35s)

[issue is is these these options here are](https://youtu.be/HyJJX6FFdpA?t=01h19m37s)

[client side they aren't server side And](https://youtu.be/HyJJX6FFdpA?t=01h19m41s)

[so if you're wanting to force a](https://youtu.be/HyJJX6FFdpA?t=01h19m43s)

[downgrade you almost have to have a](https://youtu.be/HyJJX6FFdpA?t=01h19m45s)

[version of your application out there](https://youtu.be/HyJJX6FFdpA?t=01h19m47s)

[that is already prepped to allow you to](https://youtu.be/HyJJX6FFdpA?t=01h19m50s)

[force that right The other way that um](https://youtu.be/HyJJX6FFdpA?t=01h19m53s)

[that we often do it is](https://youtu.be/HyJJX6FFdpA?t=01h19m56s)

[you can do a logical downgrade](https://youtu.be/HyJJX6FFdpA?t=01h20m00s)

[with an upgraded release version Right](https://youtu.be/HyJJX6FFdpA?t=01h20m03s)

[So sometimes if it's I've pushed out a](https://youtu.be/HyJJX6FFdpA?t=01h20m06s)

[bad release like V3 is a problem I want](https://youtu.be/HyJJX6FFdpA?t=01h20m08s)

[people to go back to V2 I can always](https://youtu.be/HyJJX6FFdpA?t=01h20m12s)

[recompile V2 packages it up as V4 and](https://youtu.be/HyJJX6FFdpA?t=01h20m14s)

[push that out Now it doesn't again](https://youtu.be/HyJJX6FFdpA?t=01h20m19s)

[unless your update manager is forcing](https://youtu.be/HyJJX6FFdpA?t=01h20m22s)

[updates onto the users it still is up to](https://youtu.be/HyJJX6FFdpA?t=01h20m25s)

[you to decide](https://youtu.be/HyJJX6FFdpA?t=01h20m28s)

[what you do with this check for updates](https://youtu.be/HyJJX6FFdpA?t=01h20m30s)

[call and the download updates call right](https://youtu.be/HyJJX6FFdpA?t=01h20m32s)

[there There is a little bit of uh of](https://youtu.be/HyJJX6FFdpA?t=01h20m35s)

[things there The other thing that you](https://youtu.be/HyJJX6FFdpA?t=01h20m38s)

[can do right if you want to be able to](https://youtu.be/HyJJX6FFdpA?t=01h20m40s)

[and there's not um](https://youtu.be/HyJJX6FFdpA?t=01h20m44s)

[it's kind of intentional we don't do](https://youtu.be/HyJJX6FFdpA?t=01h20m47s)

[this but it's but I'll show you where](https://youtu.be/HyJJX6FFdpA?t=01h20m49s)

[the magical incantation is Uh where's](https://youtu.be/HyJJX6FFdpA?t=01h20m51s)

[the deployment bits](https://youtu.be/HyJJX6FFdpA?t=01h20m53s)

[Where is the flow update source](https://youtu.be/HyJJX6FFdpA?t=01h20m59s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=01h21m03s)

[oh my uh](https://youtu.be/HyJJX6FFdpA?t=01h21m09s)

[uh flow source There we are So this is](https://youtu.be/HyJJX6FFdpA?t=01h21m12s)

[this is the update source um that we use](https://youtu.be/HyJJX6FFdpA?t=01h21m18s)

[to contact our hosted service Right And](https://youtu.be/HyJJX6FFdpA?t=01h21m21s)

[so this guy here you will note when it](https://youtu.be/HyJJX6FFdpA?t=01h21m24s)

[is uh grabbing this assets feed it is it](https://youtu.be/HyJJX6FFdpA?t=01h21m27s)

[is grabbing a Velopac flow release asset](https://youtu.be/HyJJX6FFdpA?t=01h21m32s)

[So a regular Velopac asset is just a](https://youtu.be/HyJJX6FFdpA?t=01h21m36s)

[Poco and the data in this Poco should](https://youtu.be/HyJJX6FFdpA?t=01h21m39s)

[look really similar to your](https://youtu.be/HyJJX6FFdpA?t=01h21m42s)

[releases.json file right It's just these](https://youtu.be/HyJJX6FFdpA?t=01h21m44s)

[things here Now there is no tooling](https://youtu.be/HyJJX6FFdpA?t=01h21m47s)

[built in to like VPK or similar but if](https://youtu.be/HyJJX6FFdpA?t=01h21m50s)

[you wanted to write your own update](https://youtu.be/HyJJX6FFdpA?t=01h21m54s)

[source there is nothing stopping you](https://youtu.be/HyJJX6FFdpA?t=01h21m55s)

[from adding say an additional property](https://youtu.be/HyJJX6FFdpA?t=01h21m58s)

[on one of the updates that is like force](https://youtu.be/HyJJX6FFdpA?t=01h22m01s)

[downgrade](https://youtu.be/HyJJX6FFdpA?t=01h22m04s)

[right like if you want to have something](https://youtu.be/HyJJX6FFdpA?t=01h22m06s)

[where your server can communicate down](https://youtu.be/HyJJX6FFdpA?t=01h22m09s)

[to your client again you have to release](https://youtu.be/HyJJX6FFdpA?t=01h22m11s)

[a version of your client that's](https://youtu.be/HyJJX6FFdpA?t=01h22m13s)

[expecting this um but once that's at](https://youtu.be/HyJJX6FFdpA?t=01h22m15s)

[least out there Um you uh you could then](https://youtu.be/HyJJX6FFdpA?t=01h22m17s)

[go through edit your JSON file to add](https://youtu.be/HyJJX6FFdpA?t=01h22m22s)

[some additional property and then write](https://youtu.be/HyJJX6FFdpA?t=01h22m25s)

[your own update source](https://youtu.be/HyJJX6FFdpA?t=01h22m28s)

[because the the only thing and you can](https://youtu.be/HyJJX6FFdpA?t=01h22m30s)

[use the flow one as kind of a template](https://youtu.be/HyJJX6FFdpA?t=01h22m32s)

[for how to do it Um you probably don't](https://youtu.be/HyJJX6FFdpA?t=01h22m34s)

[need most of this um and so yours could](https://youtu.be/HyJJX6FFdpA?t=01h22m37s)

[be very simplistic But the key thing](https://youtu.be/HyJJX6FFdpA?t=01h22m41s)

[here is when des serializing the the](https://youtu.be/HyJJX6FFdpA?t=01h22m43s)

[releases you need to tell it to des](https://youtu.be/HyJJX6FFdpA?t=01h22m46s)

[serialize as your new type that derives](https://youtu.be/HyJJX6FFdpA?t=01h22m50s)

[from Velopac asset with whatever](https://youtu.be/HyJJX6FFdpA?t=01h22m53s)

[properties you want](https://youtu.be/HyJJX6FFdpA?t=01h22m54s)

[And then your app can use those](https://youtu.be/HyJJX6FFdpA?t=01h22m57s)

[properties when it retrieves the um the](https://youtu.be/HyJJX6FFdpA?t=01h22m59s)

[update right because this this update](https://youtu.be/HyJJX6FFdpA?t=01h23m03s)

[here is just an update info that is uh](https://youtu.be/HyJJX6FFdpA?t=01h23m05s)

[being returned back to you And there's](https://youtu.be/HyJJX6FFdpA?t=01h23m09s)

[nothing stopping you from making this um](https://youtu.be/HyJJX6FFdpA?t=01h23m11s)

[this re uh this Velopac asset class uh](https://youtu.be/HyJJX6FFdpA?t=01h23m15s)

[your derived class But yeah there's](https://youtu.be/HyJJX6FFdpA?t=01h23m19s)

[nothing built in to it currently to to](https://youtu.be/HyJJX6FFdpA?t=01h23m21s)

[allow a downgrade](https://youtu.be/HyJJX6FFdpA?t=01h23m25s)

[Partly because](https://youtu.be/HyJJX6FFdpA?t=01h23m27s)

[a lot of apps](https://youtu.be/HyJJX6FFdpA?t=01h23m29s)

[don't downgrade na nicely like even if](https://youtu.be/HyJJX6FFdpA?t=01h23m31s)

[the the installer supports the downgrade](https://youtu.be/HyJJX6FFdpA?t=01h23m35s)

[the app also has to do it because in a](https://youtu.be/HyJJX6FFdpA?t=01h23m37s)

[lot of cases um like even if you take a](https://youtu.be/HyJJX6FFdpA?t=01h23m40s)

[net application with like an EF](https://youtu.be/HyJJX6FFdpA?t=01h23m43s)

[migration right if you deploy a version](https://youtu.be/HyJJX6FFdpA?t=01h23m45s)

[of your app with an EF migration that](https://youtu.be/HyJJX6FFdpA?t=01h23m48s)

[has upgraded your database you need](https://youtu.be/HyJJX6FFdpA?t=01h23m50s)

[something outside of your app to ensure](https://youtu.be/HyJJX6FFdpA?t=01h23m53s)

[that it appropriately downgrades that](https://youtu.be/HyJJX6FFdpA?t=01h23m56s)

[database say it's just a SQLite file](https://youtu.be/HyJJX6FFdpA?t=01h23m58s)

[right In order for that older version to](https://youtu.be/HyJJX6FFdpA?t=01h24m00s)

[actually work](https://youtu.be/HyJJX6FFdpA?t=01h24m02s)

[what you did before of just giving out](https://youtu.be/HyJJX6FFdpA?t=01h24m04s)

[the old setup .exe that works perfectly](https://youtu.be/HyJJX6FFdpA?t=01h24m07s)

[fine And honestly for a lot of my](https://youtu.be/HyJJX6FFdpA?t=01h24m10s)

[releases if I self-host um like Fellow](https://youtu.be/HyJJX6FFdpA?t=01h24m12s)

[Packflow we actually keep the old setup](https://youtu.be/HyJJX6FFdpA?t=01h24m15s)

[.exes Um](https://youtu.be/HyJJX6FFdpA?t=01h24m18s)

[the because the setup exe is a a](https://youtu.be/HyJJX6FFdpA?t=01h24m20s)

[bootstrapped executable with your um](https://youtu.be/HyJJX6FFdpA?t=01h24m24s)

[Nougat package added on as metadata Like](https://youtu.be/HyJJX6FFdpA?t=01h24m28s)

[that's all it is is a a bootstrap](https://youtu.be/HyJJX6FFdpA?t=01h24m31s)

[executable that has metadata at the end](https://youtu.be/HyJJX6FFdpA?t=01h24m32s)

[of the file It literally just goes and](https://youtu.be/HyJJX6FFdpA?t=01h24m35s)

[hunts that metadata out and installs it](https://youtu.be/HyJJX6FFdpA?t=01h24m36s)

[And so](https://youtu.be/HyJJX6FFdpA?t=01h24m39s)

[if all you do is the VPK and take the](https://youtu.be/HyJJX6FFdpA?t=01h24m41s)

[output of it you'll end up overwriting](https://youtu.be/HyJJX6FFdpA?t=01h24m43s)

[that executable every time I oftentimes](https://youtu.be/HyJJX6FFdpA?t=01h24m45s)

[will make a copy of that executable with](https://youtu.be/HyJJX6FFdpA?t=01h24m48s)

[the version number on it That way if I](https://youtu.be/HyJJX6FFdpA?t=01h24m50s)

[ever need to grab a version add a partic](https://youtu.be/HyJJX6FFdpA?t=01h24m53s)

[or tell somebody to install add a](https://youtu.be/HyJJX6FFdpA?t=01h24m55s)

[particular version they can just grab](https://youtu.be/HyJJX6FFdpA?t=01h24m57s)

[that setup EXE So it the the default is](https://youtu.be/HyJJX6FFdpA?t=01h24m59s)

[it always just makes the the one that's](https://youtu.be/HyJJX6FFdpA?t=01h25m03s)

[going to be latest because that's what](https://youtu.be/HyJJX6FFdpA?t=01h25m06s)

[you kind of want to host But you don't](https://youtu.be/HyJJX6FFdpA?t=01h25m07s)

[have to do that You can just bring it](https://youtu.be/HyJJX6FFdpA?t=01h25m10s)

[back But yeah the the way you did it](https://youtu.be/HyJJX6FFdpA?t=01h25m12s)

[worked very smoothly So if if that is](https://youtu.be/HyJJX6FFdpA?t=01h25m14s)

[acceptable there's nothing built in to](https://youtu.be/HyJJX6FFdpA?t=01h25m17s)

[give it to you with like a a remote edit](https://youtu.be/HyJJX6FFdpA?t=01h25m19s)

[on the server You would have to build it](https://youtu.be/HyJJX6FFdpA?t=01h25m22s)

[It's possible Um and again it kind of](https://youtu.be/HyJJX6FFdpA?t=01h25m24s)

[depends a little bit on what you need to](https://youtu.be/HyJJX6FFdpA?t=01h25m28s)

[do And oftentimes if you want to control](https://youtu.be/HyJJX6FFdpA?t=01h25m30s)

[it entirely from server side what we](https://youtu.be/HyJJX6FFdpA?t=01h25m32s)

[usually suggest is](https://youtu.be/HyJJX6FFdpA?t=01h25m35s)

[package your old version up with a new](https://youtu.be/HyJJX6FFdpA?t=01h25m38s)

[VEL pack number and then let the regular](https://youtu.be/HyJJX6FFdpA?t=01h25m41s)

[update process go through because we](https://youtu.be/HyJJX6FFdpA?t=01h25m43s)

[suspect that a lot of people um are just](https://youtu.be/HyJJX6FFdpA?t=01h25m46s)

[doing it like this where it's check for](https://youtu.be/HyJJX6FFdpA?t=01h25m50s)

[updates download updates apply and](https://youtu.be/HyJJX6FFdpA?t=01h25m52s)

[restart](https://youtu.be/HyJJX6FFdpA?t=01h25m55s)

[Yeah No there's there's not necessarily](https://youtu.be/HyJJX6FFdpA?t=01h25m57s)

[a built-in easier process Um that is](https://youtu.be/HyJJX6FFdpA?t=01h25m59s)

[something that we've talked about adding](https://youtu.be/HyJJX6FFdpA?t=01h26m02s)

[in for Velopac flow to allow](https://youtu.be/HyJJX6FFdpA?t=01h26m04s)

[like force downgrades or similar because](https://youtu.be/HyJJX6FFdpA?t=01h26m09s)

[if you're using our hosted service we](https://youtu.be/HyJJX6FFdpA?t=01h26m11s)

[can we can do magic on the back end for](https://youtu.be/HyJJX6FFdpA?t=01h26m13s)

[controlling that manifest whereas what](https://youtu.be/HyJJX6FFdpA?t=01h26m17s)

[you get you would have to to edit](https://youtu.be/HyJJX6FFdpA?t=01h26m20s)

[yourself Like Velopac flow we don't have](https://youtu.be/HyJJX6FFdpA?t=01h26m22s)

[a JSON file that we store We gen it on](https://youtu.be/HyJJX6FFdpA?t=01h26m24s)

[the fly based upon this the state of](https://youtu.be/HyJJX6FFdpA?t=01h26m26s)

[your app and the database and scanning](https://youtu.be/HyJJX6FFdpA?t=01h26m28s)

[and various things So it's it's very](https://youtu.be/HyJJX6FFdpA?t=01h26m30s)

[much tied to this idea of](https://youtu.be/HyJJX6FFdpA?t=01h26m33s)

[um as long as I can build it and push it](https://youtu.be/HyJJX6FFdpA?t=01h26m36s)

[out it just works So but yes no you](https://youtu.be/HyJJX6FFdpA?t=01h26m38s)

[didn't you didn't miss anything But I I](https://youtu.be/HyJJX6FFdpA?t=01h26m41s)

[do agree with you that that is something](https://youtu.be/HyJJX6FFdpA?t=01h26m44s)

[that deserves an entry in the docs at](https://youtu.be/HyJJX6FFdpA?t=01h26m46s)

[minimum so people know what is and is](https://youtu.be/HyJJX6FFdpA?t=01h26m49s)

[not there because I think more than just](https://youtu.be/HyJJX6FFdpA?t=01h26m51s)

[you will probably have that question](https://youtu.be/HyJJX6FFdpA?t=01h26m54s)

[about what is actually in the box and](https://youtu.be/HyJJX6FFdpA?t=01h26m55s)

[what isn't So I think that's that's](https://youtu.be/HyJJX6FFdpA?t=01h26m58s)

[perfect Okay So I think though my remote](https://youtu.be/HyJJX6FFdpA?t=01h27m01s)

[executes networking conclusion host on](https://youtu.be/HyJJX6FFdpA?t=01h27m05s)

[flow I mean I would love that I would](https://youtu.be/HyJJX6FFdpA?t=01h27m08s)

[absolutely love that](https://youtu.be/HyJJX6FFdpA?t=01h27m11s)

[And I apologize It we keep threatening](https://youtu.be/HyJJX6FFdpA?t=01h27m14s)

[to release and we uh I will admit I got](https://youtu.be/HyJJX6FFdpA?t=01h27m16s)

[hung up between the build conference my](https://youtu.be/HyJJX6FFdpA?t=01h27m21s)

[GitHub co-pilot talk this uh this](https://youtu.be/HyJJX6FFdpA?t=01h27m23s)

[afternoon and then a user group talk](https://youtu.be/HyJJX6FFdpA?t=01h27m26s)

[before Most of my free time has been](https://youtu.be/HyJJX6FFdpA?t=01h27m28s)

[absolutely swamped prepping things So](https://youtu.be/HyJJX6FFdpA?t=01h27m30s)

[that has not been as good Okay so this](https://youtu.be/HyJJX6FFdpA?t=01h27m33s)

[handles that and all I am missing now is](https://youtu.be/HyJJX6FFdpA?t=01h27m38s)

[a metric ton of overloads](https://youtu.be/HyJJX6FFdpA?t=01h27m40s)

[Do I dare let Copilot write the](https://youtu.be/HyJJX6FFdpA?t=01h27m46s)

[overloads for me That feels incredibly](https://youtu.be/HyJJX6FFdpA?t=01h27m50s)

[risky](https://youtu.be/HyJJX6FFdpA?t=01h27m53s)

[So we're going to do it Nope We're going](https://youtu.be/HyJJX6FFdpA?t=01h27m57s)

[to make a commit and then we're going to](https://youtu.be/HyJJX6FFdpA?t=01h28m00s)

[tell it to do it That sounds much better](https://youtu.be/HyJJX6FFdpA?t=01h28m01s)

[Uh let's see](https://youtu.be/HyJJX6FFdpA?t=01h28m04s)

[because I think the only reason we had](https://youtu.be/HyJJX6FFdpA?t=01h28m09s)

[this problem is because](https://youtu.be/HyJJX6FFdpA?t=01h28m11s)

[uh need to speak to cyber security first](https://youtu.be/HyJJX6FFdpA?t=01h28m14s)

[though Yeah And JC if there are](https://youtu.be/HyJJX6FFdpA?t=01h28m16s)

[we sort of anticipate that some](https://youtu.be/HyJJX6FFdpA?t=01h28m21s)

[enterprises may not be thrilled with the](https://youtu.be/HyJJX6FFdpA?t=01h28m25s)

[idea of hosting apps on a third party](https://youtu.be/HyJJX6FFdpA?t=01h28m27s)

[service Um I would be very interested in](https://youtu.be/HyJJX6FFdpA?t=01h28m30s)

[any feedback you might have on if there](https://youtu.be/HyJJX6FFdpA?t=01h28m34s)

[are](https://youtu.be/HyJJX6FFdpA?t=01h28m37s)

[things that we could do that would help](https://youtu.be/HyJJX6FFdpA?t=01h28m39s)

[alleviate that concern for people Um](https://youtu.be/HyJJX6FFdpA?t=01h28m41s)

[I I am aware that people may may want](https://youtu.be/HyJJX6FFdpA?t=01h28m46s)

[various securityerts and whatnot which](https://youtu.be/HyJJX6FFdpA?t=01h28m49s)

[at some point we will probably work our](https://youtu.be/HyJJX6FFdpA?t=01h28m52s)

[way through but that's not likely](https://youtu.be/HyJJX6FFdpA?t=01h28m53s)

[something that we're going to do v1 out](https://youtu.be/HyJJX6FFdpA?t=01h28m55s)

[the gate](https://youtu.be/HyJJX6FFdpA?t=01h28m57s)

[Um the other kind of ask that I've heard](https://youtu.be/HyJJX6FFdpA?t=01h28m59s)

[several times from people is they want](https://youtu.be/HyJJX6FFdpA?t=01h29m02s)

[to be able to effectively have um](https://youtu.be/HyJJX6FFdpA?t=01h29m04s)

[protected update endpoints right They](https://youtu.be/HyJJX6FFdpA?t=01h29m08s)

[want they want some integration with](https://youtu.be/HyJJX6FFdpA?t=01h29m10s)

[like their their Azure AD so that only](https://youtu.be/HyJJX6FFdpA?t=01h29m13s)

[people in their org like they don't want](https://youtu.be/HyJJX6FFdpA?t=01h29m16s)

[an unprotected update endpoint they want](https://youtu.be/HyJJX6FFdpA?t=01h29m20s)

[it uh locked down and so they want some](https://youtu.be/HyJJX6FFdpA?t=01h29m22s)

[level of integration with insert off](https://youtu.be/HyJJX6FFdpA?t=01h29m25s)

[provider here which again totally fine I](https://youtu.be/HyJJX6FFdpA?t=01h29m28s)

[don't think that's something we're going](https://youtu.be/HyJJX6FFdpA?t=01h29m31s)

[to have out the door for release but](https://youtu.be/HyJJX6FFdpA?t=01h29m32s)

[that is something else that I've heard](https://youtu.be/HyJJX6FFdpA?t=01h29m34s)

[people request and so it is it is on our](https://youtu.be/HyJJX6FFdpA?t=01h29m35s)

[radar of things that might be needed But](https://youtu.be/HyJJX6FFdpA?t=01h29m39s)

[if they if they give push back I would](https://youtu.be/HyJJX6FFdpA?t=01h29m42s)

[love to hear what](https://youtu.be/HyJJX6FFdpA?t=01h29m44s)

[what we could do to actually make that](https://youtu.be/HyJJX6FFdpA?t=01h29m47s)

[happen because that would be that would](https://youtu.be/HyJJX6FFdpA?t=01h29m49s)

[be awesome](https://youtu.be/HyJJX6FFdpA?t=01h29m52s)

[Yeah And and that's the thing is if](https://youtu.be/HyJJX6FFdpA?t=01h29m54s)

[you're using Azure for single sign on](https://youtu.be/HyJJX6FFdpA?t=01h29m56s)

[like I assume you're hosting your your](https://youtu.be/HyJJX6FFdpA?t=01h29m58s)

[releases right now in like a storage](https://youtu.be/HyJJX6FFdpA?t=01h30m00s)

[account or similar but I my first](https://youtu.be/HyJJX6FFdpA?t=01h30m02s)

[question would be is that storage](https://youtu.be/HyJJX6FFdpA?t=01h30m04s)

[account does it have a publicly](https://youtu.be/HyJJX6FFdpA?t=01h30m06s)

[accessible endpoint](https://youtu.be/HyJJX6FFdpA?t=01h30m07s)

[Right like does it have because if it's](https://youtu.be/HyJJX6FFdpA?t=01h30m09s)

[got uh read access on the blobs](https://youtu.be/HyJJX6FFdpA?t=01h30m13s)

[that's slightly less secure than what we](https://youtu.be/HyJJX6FFdpA?t=01h30m18s)

[do on flow because flow it uses](https://youtu.be/HyJJX6FFdpA?t=01h30m20s)

[authenticated um short gen SAS tokens to](https://youtu.be/HyJJX6FFdpA?t=01h30m24s)

[to feed it out so that anybody grabbing](https://youtu.be/HyJJX6FFdpA?t=01h30m29s)

[it can't always go back and hit that](https://youtu.be/HyJJX6FFdpA?t=01h30m31s)

[same one just a file share at present](https://youtu.be/HyJJX6FFdpA?t=01h30m34s)

[Okay Yeah So at least a file share](https://youtu.be/HyJJX6FFdpA?t=01h30m36s)

[though could be kept internal to an org](https://youtu.be/HyJJX6FFdpA?t=01h30m38s)

[right Like if if that is if that is a](https://youtu.be/HyJJX6FFdpA?t=01h30m42s)

[case and it needs to be completely](https://youtu.be/HyJJX6FFdpA?t=01h30m45s)

[internal that that is an option](https://youtu.be/HyJJX6FFdpA?t=01h30m47s)

[Um the other the other thing that might](https://youtu.be/HyJJX6FFdpA?t=01h30m50s)

[be worth pitching that I don't know how](https://youtu.be/HyJJX6FFdpA?t=01h30m52s)

[well things would go We toyed with the](https://youtu.be/HyJJX6FFdpA?t=01h30m55s)

[idea of um like an Azure hosted offering](https://youtu.be/HyJJX6FFdpA?t=01h30m58s)

[of if enterprises wanted to host a](https://youtu.be/HyJJX6FFdpA?t=01h31m02s)

[version of Flow within their um Azure](https://youtu.be/HyJJX6FFdpA?t=01h31m04s)

[infrastructure because you can host um](https://youtu.be/HyJJX6FFdpA?t=01h31m08s)

[things like that via the Azure](https://youtu.be/HyJJX6FFdpA?t=01h31m12s)

[marketplace where you effectively](https://youtu.be/HyJJX6FFdpA?t=01h31m14s)

[package up your version of the app](https://youtu.be/HyJJX6FFdpA?t=01h31m16s)

[people buy it from the marketplace It](https://youtu.be/HyJJX6FFdpA?t=01h31m18s)

[installs inside of their Azure](https://youtu.be/HyJJX6FFdpA?t=01h31m20s)

[subscription and it's theirs but as a um](https://youtu.be/HyJJX6FFdpA?t=01h31m22s)

[systems builder you can push updates And](https://youtu.be/HyJJX6FFdpA?t=01h31m27s)

[so the Azure marketplace facilitates a](https://youtu.be/HyJJX6FFdpA?t=01h31m30s)

[way of me being able to push updates](https://youtu.be/HyJJX6FFdpA?t=01h31m33s)

[because Velopac flow we we want to](https://youtu.be/HyJJX6FFdpA?t=01h31m35s)

[iterate on and keep pushing updates to](https://youtu.be/HyJJX6FFdpA?t=01h31m38s)

[it gives me a way of effectively pushing](https://youtu.be/HyJJX6FFdpA?t=01h31m40s)

[those updates and then the CIS admins](https://youtu.be/HyJJX6FFdpA?t=01h31m42s)

[can choose to say oh yes I would like](https://youtu.be/HyJJX6FFdpA?t=01h31m45s)

[flow v next right and have it installed](https://youtu.be/HyJJX6FFdpA?t=01h31m46s)

[so that again ideas we've toyed around](https://youtu.be/HyJJX6FFdpA?t=01h31m50s)

[with and so I I'd absolutely love any](https://youtu.be/HyJJX6FFdpA?t=01h31m54s)

[and all feedback you want to shoot my](https://youtu.be/HyJJX6FFdpA?t=01h31m57s)

[direction let's see I want overloads](https://youtu.be/HyJJX6FFdpA?t=01h31m58s)

[for this method](https://youtu.be/HyJJX6FFdpA?t=01h32m03s)

[uh that expand](https://youtu.be/HyJJX6FFdpA?t=01h32m06s)

[uh](https://youtu.be/HyJJX6FFdpA?t=01h32m10s)

[the number of t](https://youtu.be/HyJJX6FFdpA?t=01h32m12s)

[parameters](https://youtu.be/HyJJX6FFdpA?t=01h32m17s)

[uh out](https://youtu.be/HyJJX6FFdpA?t=01h32m19s)

[to t8](https://youtu.be/HyJJX6FFdpA?t=01h32m21s)

[Um yeah let's just try that See if that](https://youtu.be/HyJJX6FFdpA?t=01h32m24s)

[works](https://youtu.be/HyJJX6FFdpA?t=01h32m28s)

[Well that looks pretty close Let's see](https://youtu.be/HyJJX6FFdpA?t=01h32m35s)

[T1](https://youtu.be/HyJJX6FFdpA?t=01h32m39s)

[actions Pam one](https://youtu.be/HyJJX6FFdpA?t=01h32m42s)

[pram one pram two pram 3 pram 4](https://youtu.be/HyJJX6FFdpA?t=01h32m45s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=01h32m49s)

[I think that looks about right Thank you](https://youtu.be/HyJJX6FFdpA?t=01h32m51s)

[co-pilot You have been very helpful I](https://youtu.be/HyJJX6FFdpA?t=01h32m55s)

[promise to only mock you a little bit](https://youtu.be/HyJJX6FFdpA?t=01h32m57s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=01h33m00s)

[that got me to there I'm going to move](https://youtu.be/HyJJX6FFdpA?t=01h33m02s)

[this one to the end](https://youtu.be/HyJJX6FFdpA?t=01h33m04s)

[Since you did so good last time co-pilot](https://youtu.be/HyJJX6FFdpA?t=01h33m08s)

[I'm going to give you another chance](https://youtu.be/HyJJX6FFdpA?t=01h33m10s)

[only because I like you Uh let's see I](https://youtu.be/HyJJX6FFdpA?t=01h33m12s)

[want overloads](https://youtu.be/HyJJX6FFdpA?t=01h33m16s)

[for this method that](https://youtu.be/HyJJX6FFdpA?t=01h33m18s)

[uh go out to T8 Don't remember](https://youtu.be/HyJJX6FFdpA?t=01h33m22s)

[goes out to T15](https://youtu.be/HyJJX6FFdpA?t=01h33m27s)

[That is a good point Um](https://youtu.be/HyJJX6FFdpA?t=01h33m30s)

[though I think at least at present](https://youtu.be/HyJJX6FFdpA?t=01h33m35s)

[because these are input parameters sent](https://youtu.be/HyJJX6FFdpA?t=01h33m38s)

[across I have not yet once needed](https://youtu.be/HyJJX6FFdpA?t=01h33m39s)

[something that actually went out even](https://youtu.be/HyJJX6FFdpA?t=01h33m42s)

[this far on the air and I think funk has](https://youtu.be/HyJJX6FFdpA?t=01h33m44s)

[a limit I don't know that funk goes out](https://youtu.be/HyJJX6FFdpA?t=01h33m48s)

[Uh why not a parametric of t Uh because](https://youtu.be/HyJJX6FFdpA?t=01h33m52s)

[there all of these things are shelling](https://youtu.be/HyJJX6FFdpA?t=01h33m56s)

[out to this underlying one that is just](https://youtu.be/HyJJX6FFdpA?t=01h33m58s)

[arbitrary number here So these are just](https://youtu.be/HyJJX6FFdpA?t=01h34m01s)

[convenience methods wrapping around this](https://youtu.be/HyJJX6FFdpA?t=01h34m06s)

[one of of being able to do this This one](https://youtu.be/HyJJX6FFdpA?t=01h34m08s)

[I actually think could just be params](https://youtu.be/HyJJX6FFdpA?t=01h34m12s)

[Um but I think I run into small issues](https://youtu.be/HyJJX6FFdpA?t=01h34m15s)

[of casting when if I change that one](https://youtu.be/HyJJX6FFdpA?t=01h34m18s)

[blindly But these are just the common](https://youtu.be/HyJJX6FFdpA?t=01h34m21s)

[use cases because at the end of the day](https://youtu.be/HyJJX6FFdpA?t=01h34m23s)

[all of these things are just here uh to](https://youtu.be/HyJJX6FFdpA?t=01h34m25s)

[be able to uh bring this thing back Whoa](https://youtu.be/HyJJX6FFdpA?t=01h34m28s)

[What did we do here](https://youtu.be/HyJJX6FFdpA?t=01h34m31s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=01h34m36s)

[I messed something up I messed something](https://youtu.be/HyJJX6FFdpA?t=01h34m39s)

[up](https://youtu.be/HyJJX6FFdpA?t=01h34m42s)

[And by I mess something up I mean](https://youtu.be/HyJJX6FFdpA?t=01h34m44s)

[co-pilot clearly is an idiot Um](https://youtu.be/HyJJX6FFdpA?t=01h34m46s)

[this is the action one](https://youtu.be/HyJJX6FFdpA?t=01h34m52s)

[What would be the one up here](https://youtu.be/HyJJX6FFdpA?t=01h34m55s)

[Let's see Uh](https://youtu.be/HyJJX6FFdpA?t=01h35m01s)

[task of t result](https://youtu.be/HyJJX6FFdpA?t=01h35m04s)

[Oh it dropped the original](https://youtu.be/HyJJX6FFdpA?t=01h35m07s)

[Why did it do that Co-pilot you were](https://youtu.be/HyJJX6FFdpA?t=01h35m13s)

[doing so well and I didn't hate you and](https://youtu.be/HyJJX6FFdpA?t=01h35m17s)

[now I kind of do See you're you're not](https://youtu.be/HyJJX6FFdpA?t=01h35m19s)

[like I need I like](https://youtu.be/HyJJX6FFdpA?t=01h35m25s)

[I need that still You can't get rid of](https://youtu.be/HyJJX6FFdpA?t=01h35m28s)

[that overload Like the one I was](https://youtu.be/HyJJX6FFdpA?t=01h35m30s)

[actually using](https://youtu.be/HyJJX6FFdpA?t=01h35m32s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=01h35m35s)

[let's see Doesn't uh parametric of T](https://youtu.be/HyJJX6FFdpA?t=01h35m40s)

[array also need ambulance of T array](https://youtu.be/HyJJX6FFdpA?t=01h35m42s)

[depends if the code is already dead or](https://youtu.be/HyJJX6FFdpA?t=01h35m45s)

[not Yeah](https://youtu.be/HyJJX6FFdpA?t=01h35m47s)

[Uh sorry I need to fix this one](https://youtu.be/HyJJX6FFdpA?t=01h35m49s)

[Yeah Because the other thing that I](https://youtu.be/HyJJX6FFdpA?t=01h35m57s)

[always try to remind myself is that this](https://youtu.be/HyJJX6FFdpA?t=01h35m59s)

[library really has a single consumer](https://youtu.be/HyJJX6FFdpA?t=01h36m01s)

[and it is material design and zaml like](https://youtu.be/HyJJX6FFdpA?t=01h36m06s)

[I've seen other libraries that are](https://youtu.be/HyJJX6FFdpA?t=01h36m10s)

[actually using it which more power to](https://youtu.be/HyJJX6FFdpA?t=01h36m11s)

[them right if if somebody else wants to](https://youtu.be/HyJJX6FFdpA?t=01h36m14s)

[leverage this and um get usages out of](https://youtu.be/HyJJX6FFdpA?t=01h36m16s)

[it great I am not going to stop you um](https://youtu.be/HyJJX6FFdpA?t=01h36m20s)

[but I also build this for its primary](https://youtu.be/HyJJX6FFdpA?t=01h36m23s)

[consumer](https://youtu.be/HyJJX6FFdpA?t=01h36m26s)

[I I've I'd contemplated using it to](https://youtu.be/HyJJX6FFdpA?t=01h36m30s)

[build actual UI tests for apps which I](https://youtu.be/HyJJX6FFdpA?t=01h36m33s)

[know I've seen a handful of people do](https://youtu.be/HyJJX6FFdpA?t=01h36m36s)

[and it can work for that It's just](https://youtu.be/HyJJX6FFdpA?t=01h36m38s)

[because it's designed to test individual](https://youtu.be/HyJJX6FFdpA?t=01h36m40s)

[segments of the UI not necessarily whole](https://youtu.be/HyJJX6FFdpA?t=01h36m43s)

[apps Depending on your app's startup it](https://youtu.be/HyJJX6FFdpA?t=01h36m46s)

[can potentially be problematic](https://youtu.be/HyJJX6FFdpA?t=01h36m48s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=01h36m51s)

[there's that Uh we're just going to](https://youtu.be/HyJJX6FFdpA?t=01h36m52s)

[amend Sounds great And then the last](https://youtu.be/HyJJX6FFdpA?t=01h36m55s)

[thing I want to do is I need to bump my](https://youtu.be/HyJJX6FFdpA?t=01h36m58s)

[version so I get a release for it So do](https://youtu.be/HyJJX6FFdpA?t=01h37m00s)

[I](https://youtu.be/HyJJX6FFdpA?t=01h37m06s)

[do I need to I don't know that I do](https://youtu.be/HyJJX6FFdpA?t=01h37m08s)

[because we bumped it last time and I](https://youtu.be/HyJJX6FFdpA?t=01h37m10s)

[don't know that I kicked a full release](https://youtu.be/HyJJX6FFdpA?t=01h37m12s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=01h37m16s)

[[Music]](https://youtu.be/HyJJX6FFdpA?t=01h37m18s)

[let's see Test eight test nine](https://youtu.be/HyJJX6FFdpA?t=01h37m20s)

[Where is my push nougats](https://youtu.be/HyJJX6FFdpA?t=01h37m24s)

[So nougat version I guess I should go](https://youtu.be/HyJJX6FFdpA?t=01h37m28s)

[and look and see Did I release 13 or not](https://youtu.be/HyJJX6FFdpA?t=01h37m30s)

[I don't remember If I didn't um](https://youtu.be/HyJJX6FFdpA?t=01h37m34s)

[then we'll just tack on there](https://youtu.be/HyJJX6FFdpA?t=01h37m39s)

[I didn't release 13 yet So we can we can](https://youtu.be/HyJJX6FFdpA?t=01h37m43s)

[let this guy go and](https://youtu.be/HyJJX6FFdpA?t=01h37m47s)

[test it here So we will uh we will send](https://youtu.be/HyJJX6FFdpA?t=01h37m50s)

[this](https://youtu.be/HyJJX6FFdpA?t=01h37m54s)

[and then as long as that works](https://youtu.be/HyJJX6FFdpA?t=01h37m56s)

[uh create pull request](https://youtu.be/HyJJX6FFdpA?t=01h38m01s)

[Uh I clicked the wrong button didn't I](https://youtu.be/HyJJX6FFdpA?t=01h38m07s)

[Yep I did like a dummy](https://youtu.be/HyJJX6FFdpA?t=01h38m11s)

[Uh ZAML test](https://youtu.be/HyJJX6FFdpA?t=01h38m14s)

[Let's see So the source generators that](https://youtu.be/HyJJX6FFdpA?t=01h38m18s)

[was the stuff we were looking at before](https://youtu.be/HyJJX6FFdpA?t=01h38m20s)

[which I will circle back to at some](https://youtu.be/HyJJX6FFdpA?t=01h38m22s)

[point And then I'm just going to enable](https://youtu.be/HyJJX6FFdpA?t=01h38m24s)

[automerge](https://youtu.be/HyJJX6FFdpA?t=01h38m25s)

[squash And as long as that passes we'll](https://youtu.be/HyJJX6FFdpA?t=01h38m27s)

[just send it We will just send it And](https://youtu.be/HyJJX6FFdpA?t=01h38m31s)

[then that will push all the way out](https://youtu.be/HyJJX6FFdpA?t=01h38m34s)

[to Nougat as a a preview release And I](https://youtu.be/HyJJX6FFdpA?t=01h38m38s)

[think on my material design branch](https://youtu.be/HyJJX6FFdpA?t=01h38m42s)

[um cuz yeah this is that'll fix that](https://youtu.be/HyJJX6FFdpA?t=01h38m47s)

[error there](https://youtu.be/HyJJX6FFdpA?t=01h38m50s)

[Um I think I'm already referencing a](https://youtu.be/HyJJX6FFdpA?t=01h38m52s)

[preview package for ZAML test Yeah I'm](https://youtu.be/HyJJX6FFdpA?t=01h38m55s)

[I'm on 602 already So I'm perfectly](https://youtu.be/HyJJX6FFdpA?t=01h38m59s)

[happy to take a preview nougat package](https://youtu.be/HyJJX6FFdpA?t=01h39m02s)

[here and get away with it because that](https://youtu.be/HyJJX6FFdpA?t=01h39m06s)

[seems](https://youtu.be/HyJJX6FFdpA?t=01h39m08s)

[that seems okay And that'll fix that](https://youtu.be/HyJJX6FFdpA?t=01h39m10s)

[problem Okay So next issue What failures](https://youtu.be/HyJJX6FFdpA?t=01h39m13s)

[did we get on this from our latest run](https://youtu.be/HyJJX6FFdpA?t=01h39m18s)

[Because we know we've got the one](https://youtu.be/HyJJX6FFdpA?t=01h39m22s)

[Do we have more than the one](https://youtu.be/HyJJX6FFdpA?t=01h39m25s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=01h39m30s)

[Uh test has timed out after 20 minutes](https://youtu.be/HyJJX6FFdpA?t=01h39m33s)

[So I am wondering if I need to address](https://youtu.be/HyJJX6FFdpA?t=01h39m35s)

[that Let's go Let's go back and look at](https://youtu.be/HyJJX6FFdpA?t=01h39m39s)

[the text block one or text box ones](https://youtu.be/HyJJX6FFdpA?t=01h39m42s)

[because those ones we saw hang](https://youtu.be/HyJJX6FFdpA?t=01h39m45s)

[and I want to confirm or deny whether](https://youtu.be/HyJJX6FFdpA?t=01h39m48s)

[we're still experiencing the hangs](https://youtu.be/HyJJX6FFdpA?t=01h39m52s)

[because if we are still experiencing the](https://youtu.be/HyJJX6FFdpA?t=01h39m55s)

[hangs](https://youtu.be/HyJJX6FFdpA?t=01h39m57s)

[that is problematic Izzy have a good one](https://youtu.be/HyJJX6FFdpA?t=01h39m59s)

[Prove that the smoking gun is hardware](https://youtu.be/HyJJX6FFdpA?t=01h40m07s)

[and not the software Well if you wrote](https://youtu.be/HyJJX6FFdpA?t=01h40m09s)

[the software then I believe you](https://youtu.be/HyJJX6FFdpA?t=01h40m11s)

[Okay So this is the problem child](https://youtu.be/HyJJX6FFdpA?t=01h40m16s)

[Who is it](https://youtu.be/HyJJX6FFdpA?t=01h40m19s)

[So this one here is hanging](https://youtu.be/HyJJX6FFdpA?t=01h40m21s)

[So we want to we want to take a look at](https://youtu.be/HyJJX6FFdpA?t=01h40m25s)

[this guy Close window That will kill](https://youtu.be/HyJJX6FFdpA?t=01h40m28s)

[that off Validation error So you are](https://youtu.be/HyJJX6FFdpA?t=01h40m31s)

[doing something bad](https://youtu.be/HyJJX6FFdpA?t=01h40m35s)

[Boy I don't see a hang here Like I see](https://youtu.be/HyJJX6FFdpA?t=01h40m42s)

[this wait four but the default behavior](https://youtu.be/HyJJX6FFdpA?t=01h40m44s)

[of wait for is try for](https://youtu.be/HyJJX6FFdpA?t=01h40m47s)

[um some number of seconds and then come](https://youtu.be/HyJJX6FFdpA?t=01h40m50s)

[back There's not a lot that's magical in](https://youtu.be/HyJJX6FFdpA?t=01h40m54s)

[here](https://youtu.be/HyJJX6FFdpA?t=01h40m56s)

[So I guess let's let's launch this and](https://youtu.be/HyJJX6FFdpA?t=01h41m00s)

[catch it at a break point and then](https://youtu.be/HyJJX6FFdpA?t=01h41m03s)

[let's figure out where exactly it's](https://youtu.be/HyJJX6FFdpA?t=01h41m07s)

[hanging I think that's going to be the](https://youtu.be/HyJJX6FFdpA?t=01h41m09s)

[the key question is where is this guy](https://youtu.be/HyJJX6FFdpA?t=01h41m12s)

[getting hung up](https://youtu.be/HyJJX6FFdpA?t=01h41m16s)

[Load user control Great Great Leftclick](https://youtu.be/HyJJX6FFdpA?t=01h41m19s)

[Wait for And I'm going to put a break](https://youtu.be/HyJJX6FFdpA?t=01h41m25s)

[point here and a break point here](https://youtu.be/HyJJX6FFdpA?t=01h41m26s)

[So we get inside the wait for that's](https://youtu.be/HyJJX6FFdpA?t=01h41m29s)

[fine](https://youtu.be/HyJJX6FFdpA?t=01h41m32s)

[Default air view blah blah blah](https://youtu.be/HyJJX6FFdpA?t=01h41m36s)

[Should probably turn on just my code](https://youtu.be/HyJJX6FFdpA?t=01h41m42s)

[again](https://youtu.be/HyJJX6FFdpA?t=01h41m44s)

[because this is going to get ugly So](https://youtu.be/HyJJX6FFdpA?t=01h41m46s)

[let's stop this because I don't want to](https://youtu.be/HyJJX6FFdpA?t=01h41m48s)

[deal with that](https://youtu.be/HyJJX6FFdpA?t=01h41m50s)

[Uh enable just my code](https://youtu.be/HyJJX6FFdpA?t=01h41m52s)

[Then let's debug one more time](https://youtu.be/HyJJX6FFdpA?t=01h41m55s)

[I want to be able to hit F10 and not end](https://youtu.be/HyJJX6FFdpA?t=01h41m59s)

[up deep in the bowels of the BCL Okay so](https://youtu.be/HyJJX6FFdpA?t=01h42m02s)

[we know we get down here as far as the](https://youtu.be/HyJJX6FFdpA?t=01h42m07s)

[left click Great We know we get inside](https://youtu.be/HyJJX6FFdpA?t=01h42m09s)

[object reference not set to the instance](https://youtu.be/HyJJX6FFdpA?t=01h42m13s)

[of an object](https://youtu.be/HyJJX6FFdpA?t=01h42m16s)

[What we got going on here](https://youtu.be/HyJJX6FFdpA?t=01h42m19s)

[What do we got going on here](https://youtu.be/HyJJX6FFdpA?t=01h42m26s)

[Test context current](https://youtu.be/HyJJX6FFdpA?t=01h42m33s)

[This guy](https://youtu.be/HyJJX6FFdpA?t=01h42m37s)

[how would this ever work](https://youtu.be/HyJJX6FFdpA?t=01h42m40s)

[That is okay So we're going to fix that](https://youtu.be/HyJJX6FFdpA?t=01h42m50s)

[So the the issue here this and this is](https://youtu.be/HyJJX6FFdpA?t=01h42m53s)

[one of those weird areas of ZAML test](https://youtu.be/HyJJX6FFdpA?t=01h42m57s)

[right So I've got this validation](https://youtu.be/HyJJX6FFdpA?t=01h42m59s)

[updates control It lives in my UI test](https://youtu.be/HyJJX6FFdpA?t=01h43m02s)

[project which means it can access things](https://youtu.be/HyJJX6FFdpA?t=01h43m05s)

[like tunits uh test context current The](https://youtu.be/HyJJX6FFdpA?t=01h43m09s)

[problem is this control gets loaded by](https://youtu.be/HyJJX6FFdpA?t=01h43m13s)

[the WPF app that it starts in a](https://youtu.be/HyJJX6FFdpA?t=01h43m16s)

[different process So even though this](https://youtu.be/HyJJX6FFdpA?t=01h43m19s)

[thing is here](https://youtu.be/HyJJX6FFdpA?t=01h43m21s)

[this is never going to](https://youtu.be/HyJJX6FFdpA?t=01h43m24s)

[never going to work](https://youtu.be/HyJJX6FFdpA?t=01h43m27s)

[right No shut up Don't help me That is](https://youtu.be/HyJJX6FFdpA?t=01h43m30s)

[that is actually what we want Okay so](https://youtu.be/HyJJX6FFdpA?t=01h43m34s)

[let's debug again because I wonder I](https://youtu.be/HyJJX6FFdpA?t=01h43m37s)

[wonder if we are if that was the issue](https://youtu.be/HyJJX6FFdpA?t=01h43m39s)

[is I'm sure I just autocoded that and](https://youtu.be/HyJJX6FFdpA?t=01h43m42s)

[went oh yeah of course we need to pass](https://youtu.be/HyJJX6FFdpA?t=01h43m45s)

[the cancellation token without actually](https://youtu.be/HyJJX6FFdpA?t=01h43m47s)

[thinking about the fact that this user](https://youtu.be/HyJJX6FFdpA?t=01h43m49s)

[control isn't actually](https://youtu.be/HyJJX6FFdpA?t=01h43m50s)

[um need to kill the process is that user](https://youtu.be/HyJJX6FFdpA?t=01h43m53s)

[control isn't actually something that](https://youtu.be/HyJJX6FFdpA?t=01h43m56s)

[lives inside of the that process Nope I](https://youtu.be/HyJJX6FFdpA?t=01h43m59s)

[get it You were unhappy you couldn't](https://youtu.be/HyJJX6FFdpA?t=01h44m02s)

[restart Process is dead now Try again](https://youtu.be/HyJJX6FFdpA?t=01h44m03s)

[Oh I guess it's not all the way dead The](https://youtu.be/HyJJX6FFdpA?t=01h44m07s)

[window's dead Uh let's see](https://youtu.be/HyJJX6FFdpA?t=01h44m09s)

[Demo test See couple rogue ones And task](https://youtu.be/HyJJX6FFdpA?t=01h44m13s)

[and task I've at times written code](https://youtu.be/HyJJX6FFdpA?t=01h44m18s)

[uh remove using in that file That's the](https://youtu.be/HyJJX6FFdpA?t=01h44m23s)

[thing There is no using](https://youtu.be/HyJJX6FFdpA?t=01h44m25s)

[that That that's the other part is and I](https://youtu.be/HyJJX6FFdpA?t=01h44m28s)

[I like](https://youtu.be/HyJJX6FFdpA?t=01h44m31s)

[TUnit includes if we go and look at](https://youtu.be/HyJJX6FFdpA?t=01h44m35s)

[if we go and do open containing folder](https://youtu.be/HyJJX6FFdpA?t=01h44m41s)

[right if I back this sucker up and I I](https://youtu.be/HyJJX6FFdpA?t=01h44m44s)

[don't know how I feel about this I think](https://youtu.be/HyJJX6FFdpA?t=01h44m47s)

[I like it](https://youtu.be/HyJJX6FFdpA?t=01h44m49s)

[but I'm not sure I do Uh where is the](https://youtu.be/HyJJX6FFdpA?t=01h44m51s)

[global using](https://youtu.be/HyJJX6FFdpA?t=01h44m56s)

[global using right if I drag this sucker](https://youtu.be/HyJJX6FFdpA?t=01h44m59s)

[in](https://youtu.be/HyJJX6FFdpA?t=01h45m01s)

[right you'll see tunit in here right I](https://youtu.be/HyJJX6FFdpA?t=01h45m04s)

[didn't add tunit in here tunit puts](https://youtu.be/HyJJX6FFdpA?t=01h45m08s)

[itself in the global using](https://youtu.be/HyJJX6FFdpA?t=01h45m11s)

[right and there may be an option to turn](https://youtu.be/HyJJX6FFdpA?t=01h45m14s)

[it off or similar but it's in there uh](https://youtu.be/HyJJX6FFdpA?t=01h45m16s)

[oh got it oh clean up the data antage](https://youtu.be/HyJJX6FFdpA?t=01h45m20s)

[yeah yeah yeah that's fine yeah yep yep](https://youtu.be/HyJJX6FFdpA?t=01h45m22s)

[yep yeah](https://youtu.be/HyJJX6FFdpA?t=01h45m24s)

[Yeah but the fact that TUNT puts itself](https://youtu.be/HyJJX6FFdpA?t=01h45m27s)

[in the global using is kind of a](https://youtu.be/HyJJX6FFdpA?t=01h45m29s)

[blessing and a curse Like I like it](https://youtu.be/HyJJX6FFdpA?t=01h45m31s)

[but it does mean like it's one of those](https://youtu.be/HyJJX6FFdpA?t=01h45m37s)

[situations where I would like to be able](https://youtu.be/HyJJX6FFdpA?t=01h45m39s)

[to ban it I wonder can you do that with](https://youtu.be/HyJJX6FFdpA?t=01h45m42s)

[a banned API analyzer Can you ban a](https://youtu.be/HyJJX6FFdpA?t=01h45m44s)

[usage per namespace](https://youtu.be/HyJJX6FFdpA?t=01h45m48s)

[I don't think you can I think you have](https://youtu.be/HyJJX6FFdpA?t=01h45m51s)

[to do it per project](https://youtu.be/HyJJX6FFdpA?t=01h45m52s)

[Yeah So now the test is actually running](https://youtu.be/HyJJX6FFdpA?t=01h45m58s)

[without hanging That is probably](https://youtu.be/HyJJX6FFdpA?t=01h46m00s)

[I don't know if it passed Oh it did Good](https://youtu.be/HyJJX6FFdpA?t=01h46m04s)

[Good Good Good Okay So now I should be](https://youtu.be/HyJJX6FFdpA?t=01h46m06s)

[able to run this So this will actually](https://youtu.be/HyJJX6FFdpA?t=01h46m08s)

[probably fix the hang](https://youtu.be/HyJJX6FFdpA?t=01h46m10s)

[which will make the test actually not](https://youtu.be/HyJJX6FFdpA?t=01h46m12s)

[take 20 minutes to run because they were](https://youtu.be/HyJJX6FFdpA?t=01h46m14s)

[probably getting hung up on that](https://youtu.be/HyJJX6FFdpA?t=01h46m17s)

[I'm actually tempted to do a quick hunt](https://youtu.be/HyJJX6FFdpA?t=01h46m21s)

[for usages of that cancellation token](https://youtu.be/HyJJX6FFdpA?t=01h46m24s)

[and just make sure that I haven't done](https://youtu.be/HyJJX6FFdpA?t=01h46m26s)

[that anywhere else and specifically done](https://youtu.be/HyJJX6FFdpA?t=01h46m29s)

[it anywhere else in the the user](https://youtu.be/HyJJX6FFdpA?t=01h46m33s)

[controls](https://youtu.be/HyJJX6FFdpA?t=01h46m36s)

[because that would be the the one big](https://youtu.be/HyJJX6FFdpA?t=01h46m39s)

[kicker there](https://youtu.be/HyJJX6FFdpA?t=01h46m41s)

[[Music]](https://youtu.be/HyJJX6FFdpA?t=01h46m44s)

[Come on That's looking better That's](https://youtu.be/HyJJX6FFdpA?t=01h46m54s)

[looking better](https://youtu.be/HyJJX6FFdpA?t=01h46m56s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=01h47m01s)

[Good Good And when this is done we're](https://youtu.be/HyJJX6FFdpA?t=01h47m04s)

[going to go check that ZAML test](https://youtu.be/HyJJX6FFdpA?t=01h47m06s)

[pipeline and see if it released all the](https://youtu.be/HyJJX6FFdpA?t=01h47m08s)

[way out or not](https://youtu.be/HyJJX6FFdpA?t=01h47m10s)

[How many more you got left in here](https://youtu.be/HyJJX6FFdpA?t=01h47m13s)

[That's all of them Okay so all the](https://youtu.be/HyJJX6FFdpA?t=01h47m16s)

[textbox tests now should be fine That's](https://youtu.be/HyJJX6FFdpA?t=01h47m18s)

[good That's good Um let me do](https://youtu.be/HyJJX6FFdpA?t=01h47m21s)

[brief gander at](https://youtu.be/HyJJX6FFdpA?t=01h47m26s)

[this](https://youtu.be/HyJJX6FFdpA?t=01h47m29s)

[Why did the test fail](https://youtu.be/HyJJX6FFdpA?t=01h47m31s)

[Uh let's see One failed test Where is it](https://youtu.be/HyJJX6FFdpA?t=01h47m35s)

[Show it to me](https://youtu.be/HyJJX6FFdpA?t=01h47m39s)

[I think I have a flaky test but I](https://youtu.be/HyJJX6FFdpA?t=01h47m44s)

[am unhappy about that On remote execute](https://youtu.be/HyJJX6FFdpA?t=01h47m47s)

[can execute delegate Well that's scary](https://youtu.be/HyJJX6FFdpA?t=01h47m50s)

[Um](https://youtu.be/HyJJX6FFdpA?t=01h47m53s)

[cuz that's something I literally just](https://youtu.be/HyJJX6FFdpA?t=01h47m58s)

[changed So we should probably go look at](https://youtu.be/HyJJX6FFdpA?t=01h48m01s)

[that because that feels like that feels](https://youtu.be/HyJJX6FFdpA?t=01h48m03s)

[like an important test to look at Oh](https://youtu.be/HyJJX6FFdpA?t=01h48m06s)

[this is the app level one So this is not](https://youtu.be/HyJJX6FFdpA?t=01h48m08s)

[the visual element Oh good Well I guess](https://youtu.be/HyJJX6FFdpA?t=01h48m10s)

[you know honestly we probably should add](https://youtu.be/HyJJX6FFdpA?t=01h48m14s)

[overloads to this one that are](https://youtu.be/HyJJX6FFdpA?t=01h48m15s)

[that are similar](https://youtu.be/HyJJX6FFdpA?t=01h48m19s)

[Okay Well it caught a legit test failure](https://youtu.be/HyJJX6FFdpA?t=01h48m22s)

[so that's good We should probably add](https://youtu.be/HyJJX6FFdpA?t=01h48m24s)

[async tests to this as well Uh let's see](https://youtu.be/HyJJX6FFdpA?t=01h48m27s)

[um expected actual enus](https://youtu.be/HyJJX6FFdpA?t=01h48m32s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=01h48m42s)

[that is interesting So I kind of want to](https://youtu.be/HyJJX6FFdpA?t=01h48m48s)

[grab it here and here](https://youtu.be/HyJJX6FFdpA?t=01h48m51s)

[and see why](https://youtu.be/HyJJX6FFdpA?t=01h48m54s)

[Cutie welcome](https://youtu.be/HyJJX6FFdpA?t=01h48m58s)

[Did you stream tonight I when I when I](https://youtu.be/HyJJX6FFdpA?t=01h49m01s)

[looked earlier it didn't show that you](https://youtu.be/HyJJX6FFdpA?t=01h49m04s)

[were online](https://youtu.be/HyJJX6FFdpA?t=01h49m05s)

[Okay so current culture that got set](https://youtu.be/HyJJX6FFdpA?t=01h49m08s)

[Okay that's good](https://youtu.be/HyJJX6FFdpA?t=01h49m13s)

[That does a thing](https://youtu.be/HyJJX6FFdpA?t=01h49m17s)

[We are configure a weight true so we](https://youtu.be/HyJJX6FFdpA?t=01h49m20s)

[shouldn't be changing threads](https://youtu.be/HyJJX6FFdpA?t=01h49m22s)

[And then we get down here](https://youtu.be/HyJJX6FFdpA?t=01h49m24s)

[Culture info](https://youtu.be/HyJJX6FFdpA?t=01h49m28s)

[current culture is not what we](https://youtu.be/HyJJX6FFdpA?t=01h49m35s)

[what is thread current thread culture](https://youtu.be/HyJJX6FFdpA?t=01h49m41s)

[here](https://youtu.be/HyJJX6FFdpA?t=01h49m44s)

[Interesting So what thread are we on](https://youtu.be/HyJJX6FFdpA?t=01h49m46s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=01h49m53s)

[So I need to go back and figure out uh](https://youtu.be/HyJJX6FFdpA?t=01h49m54s)

[delayed due to tech issues](https://youtu.be/HyJJX6FFdpA?t=01h50m00s)

[Oh Oh that is horrible That is horrible](https://youtu.be/HyJJX6FFdpA?t=01h50m03s)

[Delayed two hours So you did actually](https://youtu.be/HyJJX6FFdpA?t=01h50m06s)

[then get a stream up So yay That part's](https://youtu.be/HyJJX6FFdpA?t=01h50m08s)

[good I guess Uh project is coming along](https://youtu.be/HyJJX6FFdpA?t=01h50m10s)

[good I have f unfortunately my tests](https://youtu.be/HyJJX6FFdpA?t=01h50m13s)

[have pointed out uh that I'm an idiot](https://youtu.be/HyJJX6FFdpA?t=01h50m15s)

[And I'm not entirely clear how I'm an](https://youtu.be/HyJJX6FFdpA?t=01h50m18s)

[idiot yet](https://youtu.be/HyJJX6FFdpA?t=01h50m21s)

[Um the huh we're at so debugging goes](https://youtu.be/HyJJX6FFdpA?t=01h50m24s)

[through like the five stages of grief](https://youtu.be/HyJJX6FFdpA?t=01h50m30s)

[and the five stages of debugging are not](https://youtu.be/HyJJX6FFdpA?t=01h50m33s)

[as different as one would hope Manage](https://youtu.be/HyJJX6FFdpA?t=01h50m35s)

[thread ID one](https://youtu.be/HyJJX6FFdpA?t=01h50m38s)

[We set it](https://youtu.be/HyJJX6FFdpA?t=01h50m42s)

[I blame AI Well it's about to be a](https://youtu.be/HyJJX6FFdpA?t=01h50m45s)

[co-pilot problem here in a moment I just](https://youtu.be/HyJJX6FFdpA?t=01h50m47s)

[don't trust it to actually solve it And](https://youtu.be/HyJJX6FFdpA?t=01h50m49s)

[then it hits here But none of it's like](https://youtu.be/HyJJX6FFdpA?t=01h50m52s)

[it's not going down a different code](https://youtu.be/HyJJX6FFdpA?t=01h50m55s)

[path The only thing that changed](https://youtu.be/HyJJX6FFdpA?t=01h50m57s)

[was that](https://youtu.be/HyJJX6FFdpA?t=01h51m01s)

[which is interesting](https://youtu.be/HyJJX6FFdpA?t=01h51m03s)

[It's interesting](https://youtu.be/HyJJX6FFdpA?t=01h51m06s)

[And then we're on the same thread ID](https://youtu.be/HyJJX6FFdpA?t=01h51m08s)

[here](https://youtu.be/HyJJX6FFdpA?t=01h51m10s)

[Like we haven't changed threads](https://youtu.be/HyJJX6FFdpA?t=01h51m12s)

[but the culture isn't different Wait](https://youtu.be/HyJJX6FFdpA?t=01h51m17s)

[wait wait](https://youtu.be/HyJJX6FFdpA?t=01h51m20s)

[is Huh But we we set the culture to not](https://youtu.be/HyJJX6FFdpA?t=01h51m22s)

[English Let's grab it here Right Your](https://youtu.be/HyJJX6FFdpA?t=01h51m27s)

[culture has been changed](https://youtu.be/HyJJX6FFdpA?t=01h51m32s)

[Current culture current UI culture](https://youtu.be/HyJJX6FFdpA?t=01h51m37s)

[right So that's fine Both of those are](https://youtu.be/HyJJX6FFdpA?t=01h51m41s)

[different](https://youtu.be/HyJJX6FFdpA?t=01h51m43s)

[Is alive is background manage thread ID](https://youtu.be/HyJJX6FFdpA?t=01h51m45s)

[normal thread state running Great Like](https://youtu.be/HyJJX6FFdpA?t=01h51m48s)

[all of that is perfectly normal](https://youtu.be/HyJJX6FFdpA?t=01h51m51s)

[And then when we come back around into](https://youtu.be/HyJJX6FFdpA?t=01h51m57s)

[here](https://youtu.be/HyJJX6FFdpA?t=01h51m59s)

[like this does the remote execution And](https://youtu.be/HyJJX6FFdpA?t=01h52m00s)

[this is the exact same code](https://youtu.be/HyJJX6FFdpA?t=01h52m04s)

[This is the exact same code](https://youtu.be/HyJJX6FFdpA?t=01h52m11s)

[Okay this is going to look weird](https://youtu.be/HyJJX6FFdpA?t=01h52m18s)

[But bear with me for a moment](https://youtu.be/HyJJX6FFdpA?t=01h52m21s)

[I'm curious if this fixes it because](https://youtu.be/HyJJX6FFdpA?t=01h52m28s)

[that was what we changed](https://youtu.be/HyJJX6FFdpA?t=01h52m32s)

[And I am wondering if](https://youtu.be/HyJJX6FFdpA?t=01h52m36s)

[I'm going to feel really dirty here in a](https://youtu.be/HyJJX6FFdpA?t=01h52m40s)

[minute Like](https://youtu.be/HyJJX6FFdpA?t=01h52m42s)

[like if you write code like this you you](https://youtu.be/HyJJX6FFdpA?t=01h52m46s)

[should feel bad](https://youtu.be/HyJJX6FFdpA?t=01h52m49s)

[Like that is that is ugly Oh dang it](https://youtu.be/HyJJX6FFdpA?t=01h52m52s)

[I've got a I got a ZAML test process](https://youtu.be/HyJJX6FFdpA?t=01h52m55s)

[loose Die There you go Okay](https://youtu.be/HyJJX6FFdpA?t=01h52m57s)

[let's try this again](https://youtu.be/HyJJX6FFdpA?t=01h53m01s)

[Run](https://youtu.be/HyJJX6FFdpA?t=01h53m04s)

[Like on one hand the test is failing](https://youtu.be/HyJJX6FFdpA?t=01h53m06s)

[appropriately](https://youtu.be/HyJJX6FFdpA?t=01h53m08s)

[Weird](https://youtu.be/HyJJX6FFdpA?t=01h53m15s)

[weird weird Okay And I just want to](https://youtu.be/HyJJX6FFdpA?t=01h53m18s)

[confirm if I go back here right this](https://youtu.be/HyJJX6FFdpA?t=01h53m20s)

[test passes right Like](https://youtu.be/HyJJX6FFdpA?t=01h53m24s)

[I'm not crazy](https://youtu.be/HyJJX6FFdpA?t=01h53m28s)

[That's step one is always confirm that](https://youtu.be/HyJJX6FFdpA?t=01h53m31s)

[you can recreate the problem because](https://youtu.be/HyJJX6FFdpA?t=01h53m33s)

[it's not always obvious what the problem](https://youtu.be/HyJJX6FFdpA?t=01h53m34s)

[is](https://youtu.be/HyJJX6FFdpA?t=01h53m36s)

[Okay so my change breaks it](https://youtu.be/HyJJX6FFdpA?t=01h53m38s)

[on one hand Glad I wrote a test On the](https://youtu.be/HyJJX6FFdpA?t=01h53m44s)

[other hand what the heck](https://youtu.be/HyJJX6FFdpA?t=01h53m47s)

[What the heck](https://youtu.be/HyJJX6FFdpA?t=01h53m51s)

[Okay so we have a remote execute that](https://youtu.be/HyJJX6FFdpA?t=01h53m56s)

[uses the application to change the](https://youtu.be/HyJJX6FFdpA?t=01h53m58s)

[culture](https://youtu.be/HyJJX6FFdpA?t=01h54m01s)

[We then have another remote execute](https://youtu.be/HyJJX6FFdpA?t=01h54m04s)

[and I want to do](https://youtu.be/HyJJX6FFdpA?t=01h54m11s)

[uh thread current thread current UI](https://youtu.be/HyJJX6FFdpA?t=01h54m14s)

[culture do that maneuver](https://youtu.be/HyJJX6FFdpA?t=01h54m17s)

[We're going to do that We're going to do](https://youtu.be/HyJJX6FFdpA?t=01h54m21s)

[that We're going to do that](https://youtu.be/HyJJX6FFdpA?t=01h54m22s)

[Right So we'll we'll nest that all the](https://youtu.be/HyJJX6FFdpA?t=01h54m25s)

[way through](https://youtu.be/HyJJX6FFdpA?t=01h54m27s)

[We've changed the UI threads culture](https://youtu.be/HyJJX6FFdpA?t=01h54m30s)

[and I okay and I just I](https://youtu.be/HyJJX6FFdpA?t=01h54m35s)

[right like I want to](https://youtu.be/HyJJX6FFdpA?t=01h54m38s)

[this is backed by the current thread](https://youtu.be/HyJJX6FFdpA?t=01h54m41s)

[like I'm not crazy](https://youtu.be/HyJJX6FFdpA?t=01h54m44s)

[right](https://youtu.be/HyJJX6FFdpA?t=01h54m47s)

[I don't think I'm crazy](https://youtu.be/HyJJX6FFdpA?t=01h54m50s)

[what would change the threads culture](https://youtu.be/HyJJX6FFdpA?t=01h54m53s)

[back](https://youtu.be/HyJJX6FFdpA?t=01h54m57s)

[And why would making the dispatcher](https://youtu.be/HyJJX6FFdpA?t=01h54m59s)

[asynchronous change that](https://youtu.be/HyJJX6FFdpA?t=01h55m03s)

[Why Especially since it doesn't](https://youtu.be/HyJJX6FFdpA?t=01h55m08s)

[none of these things actually hit like](https://youtu.be/HyJJX6FFdpA?t=01h55m11s)

[it's got to be the the presence of that](https://youtu.be/HyJJX6FFdpA?t=01h55m15s)

[like it that has to be the issue](https://youtu.be/HyJJX6FFdpA?t=01h55m22s)

[right Like if I just comment this out](https://youtu.be/HyJJX6FFdpA?t=01h55m26s)

[async right Like if I just comment this](https://youtu.be/HyJJX6FFdpA?t=01h55m39s)

[sucker out and do that without doing](https://youtu.be/HyJJX6FFdpA?t=01h55m41s)

[anything else right This test passes](https://youtu.be/HyJJX6FFdpA?t=01h55m44s)

[I think](https://youtu.be/HyJJX6FFdpA?t=01h55m49s)

[Right](https://youtu.be/HyJJX6FFdpA?t=01h55m51s)

[Am I losing it](https://youtu.be/HyJJX6FFdpA?t=01h55m53s)

[Okay that test passes What the heck](https://youtu.be/HyJJX6FFdpA?t=01h55m57s)

[Why](https://youtu.be/HyJJX6FFdpA?t=01h56m01s)

[Why is changing this](https://youtu.be/HyJJX6FFdpA?t=01h56m04s)

[to an asynchronous method](https://youtu.be/HyJJX6FFdpA?t=01h56m08s)

[breaking how the thread gets set because](https://youtu.be/HyJJX6FFdpA?t=01h56m11s)

[the invoke is before the await There's](https://youtu.be/HyJJX6FFdpA?t=01h56m15s)

[no like](https://youtu.be/HyJJX6FFdpA?t=01h56m18s)

[this whole front bit runs synchronously](https://youtu.be/HyJJX6FFdpA?t=01h56m20s)

[like everything before the await would](https://youtu.be/HyJJX6FFdpA?t=01h56m25s)

[run synchronously This doesn't even get](https://youtu.be/HyJJX6FFdpA?t=01h56m26s)

[called in this test](https://youtu.be/HyJJX6FFdpA?t=01h56m30s)

[It's ju it's literally the fact that I](https://youtu.be/HyJJX6FFdpA?t=01h56m32s)

[did this](https://youtu.be/HyJJX6FFdpA?t=01h56m35s)

[that is the like okay let's just confirm](https://youtu.be/HyJJX6FFdpA?t=01h56m37s)

[right if I put that on there this test](https://youtu.be/HyJJX6FFdpA?t=01h56m41s)

[fails](https://youtu.be/HyJJX6FFdpA?t=01h56m44s)

[right like obviously we get the warning](https://youtu.be/HyJJX6FFdpA?t=01h56m48s)

[because we added async and not not yeah](https://youtu.be/HyJJX6FFdpA?t=01h56m50s)

[that those five characters are breaking](https://youtu.be/HyJJX6FFdpA?t=01h56m53s)

[this test](https://youtu.be/HyJJX6FFdpA?t=01h56m56s)

[What](https://youtu.be/HyJJX6FFdpA?t=01h57m00s)

[the heck](https://youtu.be/HyJJX6FFdpA?t=01h57m02s)

[Like](https://youtu.be/HyJJX6FFdpA?t=01h57m08s)

[what](https://youtu.be/HyJJX6FFdpA?t=01h57m12s)

[Okay And if I do await a wait right If I](https://youtu.be/HyJJX6FFdpA?t=01h57m14s)

[await the await the await because](https://youtu.be/HyJJX6FFdpA?t=01h57m19s)

[reasons](https://youtu.be/HyJJX6FFdpA?t=01h57m22s)

[like even though that's an asynchronous](https://youtu.be/HyJJX6FFdpA?t=01h57m28s)

[delegate it runs synchronously](https://youtu.be/HyJJX6FFdpA?t=01h57m29s)

[still fails](https://youtu.be/HyJJX6FFdpA?t=01h57m33s)

[Still fails](https://youtu.be/HyJJX6FFdpA?t=01h57m36s)

[What the heck](https://youtu.be/HyJJX6FFdpA?t=01h57m39s)

[Like](https://youtu.be/HyJJX6FFdpA?t=01h57m43s)

[what](https://youtu.be/HyJJX6FFdpA?t=01h57m45s)

[Right like the culture has been changed](https://youtu.be/HyJJX6FFdpA?t=01h57m47s)

[on this thread We have hit a break point](https://youtu.be/HyJJX6FFdpA?t=01h57m49s)

[We can see that the current culture is](https://youtu.be/HyJJX6FFdpA?t=01h57m51s)

[like like](https://youtu.be/HyJJX6FFdpA?t=01h57m56s)

[and now obviously the current culture is](https://youtu.be/HyJJX6FFdpA?t=01h57m57s)

[the US What the heck](https://youtu.be/HyJJX6FFdpA?t=01h58m00s)

[I](https://youtu.be/HyJJX6FFdpA?t=01h58m13s)

[Huh](https://youtu.be/HyJJX6FFdpA?t=01h58m15s)

[Okay co-pilot let's have a little let's](https://youtu.be/HyJJX6FFdpA?t=01h58m19s)

[have a little chat](https://youtu.be/HyJJX6FFdpA?t=01h58m21s)

[Let's let's have a little discussion](https://youtu.be/HyJJX6FFdpA?t=01h58m23s)

[because I am clearly an idiot Um I do](https://youtu.be/HyJJX6FFdpA?t=01h58m25s)

[not know what is going on Let's see if](https://youtu.be/HyJJX6FFdpA?t=01h58m30s)

[you can shed any light in this](https://youtu.be/HyJJX6FFdpA?t=01h58m32s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=01h58m36s)

[And we're going to pop you open I need](https://youtu.be/HyJJX6FFdpA?t=01h58m39s)

[to pin you so you stop closing Right So](https://youtu.be/HyJJX6FFdpA?t=01h58m41s)

[active document](https://youtu.be/HyJJX6FFdpA?t=01h58m44s)

[and I want you to have access to this](https://youtu.be/HyJJX6FFdpA?t=01h58m46s)

[document too I want to feed you both of](https://youtu.be/HyJJX6FFdpA?t=01h58m47s)

[these Okay](https://youtu.be/HyJJX6FFdpA?t=01h58m51s)

[Uh oh you're going to make me do it the](https://youtu.be/HyJJX6FFdpA?t=01h58m56s)

[hard Oh yuck](https://youtu.be/HyJJX6FFdpA?t=01h58m57s)

[Files And I want visual Stop it Visual](https://youtu.be/HyJJX6FFdpA?t=01h59m00s)

[tree service invocation Great](https://youtu.be/HyJJX6FFdpA?t=01h59m06s)

[Uh okay Uh smarty pants Um](https://youtu.be/HyJJX6FFdpA?t=01h59m11s)

[this](https://youtu.be/HyJJX6FFdpA?t=01h59m18s)

[test](https://youtu.be/HyJJX6FFdpA?t=01h59m20s)

[um](https://youtu.be/HyJJX6FFdpA?t=01h59m23s)

[fails when](https://youtu.be/HyJJX6FFdpA?t=01h59m25s)

[uh](https://youtu.be/HyJJX6FFdpA?t=01h59m29s)

[remote invocation uses](https://youtu.be/HyJJX6FFdpA?t=01h59m32s)

[uh](https://youtu.be/HyJJX6FFdpA?t=01h59m38s)

[this code Uh](https://youtu.be/HyJJX6FFdpA?t=01h59m41s)

[but passes when it uses](https://youtu.be/HyJJX6FFdpA?t=01h59m44s)

[and just dial this back](https://youtu.be/HyJJX6FFdpA?t=01h59m50s)

[Uh when it uses](https://youtu.be/HyJJX6FFdpA?t=01h59m58s)

[when it fails the culture](https://youtu.be/HyJJX6FFdpA?t=02h00m01s)

[uh does not appear to be set](https://youtu.be/HyJJX6FFdpA?t=02h00m05s)

[What might cause this](https://youtu.be/HyJJX6FFdpA?t=02h00m10s)

[Okay impress me copilot Impress me](https://youtu.be/HyJJX6FFdpA?t=02h00m14s)

[because I believe that you suck at](https://youtu.be/HyJJX6FFdpA?t=02h00m17s)

[debugging](https://youtu.be/HyJJX6FFdpA?t=02h00m19s)

[This is subtle but important difference](https://youtu.be/HyJJX6FFdpA?t=02h00m22s)

[in how WPF disposer interacts with async](https://youtu.be/HyJJX6FFdpA?t=02h00m24s)

[delegates and thread culture Okay](https://youtu.be/HyJJX6FFdpA?t=02h00m27s)

[In voke async the lambda runs](https://youtu.be/HyJJX6FFdpA?t=02h00m31s)

[synchronously on the UI thread Okay the](https://youtu.be/HyJJX6FFdpA?t=02h00m32s)

[UI threads uh is preserved as it is the](https://youtu.be/HyJJX6FFdpA?t=02h00m36s)

[same thread as the WPF application Great](https://youtu.be/HyJJX6FFdpA?t=02h00m40s)

[Await await dispatcher voke async The](https://youtu.be/HyJJX6FFdpA?t=02h00m44s)

[other schedules the start of the async](https://youtu.be/HyJJX6FFdpA?t=02h00m46s)

[lambda on the UI thread The first part](https://youtu.be/HyJJX6FFdpA?t=02h00m49s)

[of the async lambda runs on the UI](https://youtu.be/HyJJX6FFdpA?t=02h00m51s)

[thread But after the first await inside](https://youtu.be/HyJJX6FFdpA?t=02h00m53s)

[the lambda the continuation may run on a](https://youtu.be/HyJJX6FFdpA?t=02h00m55s)

[thread pool thread You are wrong I did](https://youtu.be/HyJJX6FFdpA?t=02h00m57s)

[configure await true it will marshall](https://youtu.be/HyJJX6FFdpA?t=02h01m00s)

[back](https://youtu.be/HyJJX6FFdpA?t=02h01m02s)

[on net core net 5 including net 8 net 9](https://youtu.be/HyJJX6FFdpA?t=02h01m04s)

[the default behavior in a library is to](https://youtu.be/HyJJX6FFdpA?t=02h01m07s)

[not capture the synchronization context](https://youtu.be/HyJJX6FFdpA?t=02h01m10s)

[you would be mostly correct except for](https://youtu.be/HyJJX6FFdpA?t=02h01m12s)

[we're not in a library here we're in a](https://youtu.be/HyJJX6FFdpA?t=02h01m14s)

[running WPF application you [ __ ]](https://youtu.be/HyJJX6FFdpA?t=02h01m16s)

[um unless you use configure true which](https://youtu.be/HyJJX6FFdpA?t=02h01m19s)

[we did or omit configurate false which](https://youtu.be/HyJJX6FFdpA?t=02h01m22s)

[we technically did as well uh however in](https://youtu.be/HyJJX6FFdpA?t=02h01m25s)

[some test environments or custom](https://youtu.be/HyJJX6FFdpA?t=02h01m28s)

[dispatchers the blah blah blah](https://youtu.be/HyJJX6FFdpA?t=02h01m30s)

[Okay WPF's dispatcher does not](https://youtu.be/HyJJX6FFdpA?t=02h01m33s)

[automatically throw the the threads](https://youtu.be/HyJJX6FFdpA?t=02h01m35s)

[culture to continuations of async](https://youtu.be/HyJJX6FFdpA?t=02h01m38s)

[methods](https://youtu.be/HyJJX6FFdpA?t=02h01m41s)

[This could be relevant](https://youtu.be/HyJJX6FFdpA?t=02h01m45s)

[Does not automatically throw the threads](https://youtu.be/HyJJX6FFdpA?t=02h01m48s)

[culture to continuations of async](https://youtu.be/HyJJX6FFdpA?t=02h01m50s)

[methods](https://youtu.be/HyJJX6FFdpA?t=02h01m53s)

[When you use a synchronous Lambda](https://youtu.be/HyJJX6FFdpA?t=02h01m55s)

[everything runs on the UI thread so the](https://youtu.be/HyJJX6FFdpA?t=02h01m57s)

[culture is correct When you use an async](https://youtu.be/HyJJX6FFdpA?t=02h01m58s)

[lambda after the first await inside the](https://youtu.be/HyJJX6FFdpA?t=02h02m01s)

[lambda the continuation may run on a](https://youtu.be/HyJJX6FFdpA?t=02h02m04s)

[thread that does not have the UI threads](https://youtu.be/HyJJX6FFdpA?t=02h02m07s)

[culture set blah blah blah blah blah Um](https://youtu.be/HyJJX6FFdpA?t=02h02m10s)

[if you must use an async lambi you can](https://youtu.be/HyJJX6FFdpA?t=02h02m12s)

[ensure by capturing and restoring it](https://youtu.be/HyJJX6FFdpA?t=02h02m14s)

[manually or by ensuring the continuation](https://youtu.be/HyJJX6FFdpA?t=02h02m17s)

[runs on the UI thread](https://youtu.be/HyJJX6FFdpA?t=02h02m19s)

[Um](https://youtu.be/HyJJX6FFdpA?t=02h02m26s)

[what](https://youtu.be/HyJJX6FFdpA?t=02h02m28s)

[always runs on the UI's thread Culture](https://youtu.be/HyJJX6FFdpA?t=02h02m33s)

[is correct Continuation may run on a](https://youtu.be/HyJJX6FFdpA?t=02h02m35s)

[different thread Culture may be lost](https://youtu.be/HyJJX6FFdpA?t=02h02m38s)

[but we aren't hitting a continuation](https://youtu.be/HyJJX6FFdpA?t=02h02m42s)

[Uh](https://youtu.be/HyJJX6FFdpA?t=02h02m46s)

[there are no awaits in the code path](https://youtu.be/HyJJX6FFdpA?t=02h02m48s)

[that is executed](https://youtu.be/HyJJX6FFdpA?t=02h02m53s)

[Come on copilot figure something out Uh](https://youtu.be/HyJJX6FFdpA?t=02h03m00s)

[there are no weights in the code Then](https://youtu.be/HyJJX6FFdpA?t=02h03m02s)

[the difference in behavior is due to how](https://youtu.be/HyJJX6FFdpA?t=02h03m04s)

[the dispatcher handles async versus sync](https://youtu.be/HyJJX6FFdpA?t=02h03m06s)

[delegates That I could believe Even if](https://youtu.be/HyJJX6FFdpA?t=02h03m08s)

[the async lambda is not truly](https://youtu.be/HyJJX6FFdpA?t=02h03m11s)

[asynchronous](https://youtu.be/HyJJX6FFdpA?t=02h03m13s)

[why cultures differ Let's see](https://youtu.be/HyJJX6FFdpA?t=02h03m14s)

[Dropped too quick Let's see The delegate](https://youtu.be/HyJJX6FFdpA?t=02h03m20s)

[is synchronous and always runs on the UI](https://youtu.be/HyJJX6FFdpA?t=02h03m23s)

[thread inheriting its culture Great](https://youtu.be/HyJJX6FFdpA?t=02h03m25s)

[Even if the lambda is async but contains](https://youtu.be/HyJJX6FFdpA?t=02h03m29s)

[no weight the compiler still generates a](https://youtu.be/HyJJX6FFdpA?t=02h03m31s)

[state machine and returns a task Agreed](https://youtu.be/HyJJX6FFdpA?t=02h03m33s)

[WPF's dispatch or invoke async will](https://youtu.be/HyJJX6FFdpA?t=02h03m36s)

[execute the start of the async lambda on](https://youtu.be/HyJJX6FFdpA?t=02h03m38s)

[the UI thread But the continuation even](https://youtu.be/HyJJX6FFdpA?t=02h03m41s)

[if trivial may run on a different thread](https://youtu.be/HyJJX6FFdpA?t=02h03m44s)

[depending no it is](https://youtu.be/HyJJX6FFdpA?t=02h03m47s)

[[Music]](https://youtu.be/HyJJX6FFdpA?t=02h03m50s)

[I it is lying to me](https://youtu.be/HyJJX6FFdpA?t=02h03m52s)

[the default culture for new threads is](https://youtu.be/HyJJX6FFdpA?t=02h03m57s)

[not inherited by creative dev but from](https://youtu.be/HyJJX6FFdpA?t=02h04m00s)

[the processor OS So if a continuation](https://youtu.be/HyJJX6FFdpA?t=02h04m02s)

[runs on a thread pool thread it may not](https://youtu.be/HyJJX6FFdpA?t=02h04m04s)

[have the UI threads culture It is not a](https://youtu.be/HyJJX6FFdpA?t=02h04m06s)

[thread pool thread you [ __ ]](https://youtu.be/HyJJX6FFdpA?t=02h04m08s)

[It it like the continuation thread is](https://youtu.be/HyJJX6FFdpA?t=02h04m11s)

[STA It has the same Okay The](https://youtu.be/HyJJX6FFdpA?t=02h04m14s)

[continuation](https://youtu.be/HyJJX6FFdpA?t=02h04m18s)

[thread is STA It has the same thread ID](https://youtu.be/HyJJX6FFdpA?t=02h04m20s)

[at the be and end of the lambda](https://youtu.be/HyJJX6FFdpA?t=02h04m26s)

[Like I don't know how much more I can](https://youtu.be/HyJJX6FFdpA?t=02h04m33s)

[continuously tell you Always use a](https://youtu.be/HyJJX6FFdpA?t=02h04m35s)

[synchronous delegate with dispatcher](https://youtu.be/HyJJX6FFdpA?t=02h04m38s)

[invoke async If you must ensure the](https://youtu.be/HyJJX6FFdpA?t=02h04m39s)

[entire code bath runs on the UI thread](https://youtu.be/HyJJX6FFdpA?t=02h04m41s)

[or manually set the culture at the start](https://youtu.be/HyJJX6FFdpA?t=02h04m43s)

[of your lambda](https://youtu.be/HyJJX6FFdpA?t=02h04m45s)

[The idea of manually setting the culture](https://youtu.be/HyJJX6FFdpA?t=02h04m48s)

[is interesting I wonder if that is](https://youtu.be/HyJJX6FFdpA?t=02h04m50s)

[um this out this rules out thread](https://youtu.be/HyJJX6FFdpA?t=02h04m55s)

[switching as the cause of the culture](https://youtu.be/HyJJX6FFdpA?t=02h04m58s)

[issue Yes What I was trying to tell you](https://youtu.be/HyJJX6FFdpA?t=02h04m59s)

[even with the same there is a subtle](https://youtu.be/HyJJX6FFdpA?t=02h05m03s)

[difference in how](https://youtu.be/HyJJX6FFdpA?t=02h05m05s)

[The compiler generates a state machine](https://youtu.be/HyJJX6FFdpA?t=02h05m08s)

[Agreed But that doesn't answer why this](https://youtu.be/HyJJX6FFdpA?t=02h05m10s)

[is happening The lambda is invoked It](https://youtu.be/HyJJX6FFdpA?t=02h05m13s)

[returns a task immediately](https://youtu.be/HyJJX6FFdpA?t=02h05m15s)

[But the state machine's entry point may](https://youtu.be/HyJJX6FFdpA?t=02h05m21s)

[not preserve all of the thread local](https://youtu.be/HyJJX6FFdpA?t=02h05m23s)

[states such as in the same way as a](https://youtu.be/HyJJX6FFdpA?t=02h05m26s)

[synchronous delegate](https://youtu.be/HyJJX6FFdpA?t=02h05m28s)

[Is that really the entirety of the](https://youtu.be/HyJJX6FFdpA?t=02h05m32s)

[problem](https://youtu.be/HyJJX6FFdpA?t=02h05m34s)

[Is that really the entirety of the](https://youtu.be/HyJJX6FFdpA?t=02h05m38s)

[problem](https://youtu.be/HyJJX6FFdpA?t=02h05m41s)

[Int framework culture is always thread](https://youtu.be/HyJJX6FFdpA?t=02h05m43s)

[local So that's a that's a fun one here](https://youtu.be/HyJJX6FFdpA?t=02h05m46s)

[Right So in C we have the concept of of](https://youtu.be/HyJJX6FFdpA?t=02h05m48s)

[statics right And generally with a](https://youtu.be/HyJJX6FFdpA?t=02h05m52s)

[static variable you get one like there](https://youtu.be/HyJJX6FFdpA?t=02h05m54s)

[is one shared static instance for](https://youtu.be/HyJJX6FFdpA?t=02h05m56s)

[your process Put a little asterics next](https://youtu.be/HyJJX6FFdpA?t=02h05m59s)

[to that but functionally think of it](https://youtu.be/HyJJX6FFdpA?t=02h06m01s)

[that way Right But we also have the](https://youtu.be/HyJJX6FFdpA?t=02h06m03s)

[concept of thread local which means you](https://youtu.be/HyJJX6FFdpA?t=02h06m05s)

[can have a static variable and if it's](https://youtu.be/HyJJX6FFdpA?t=02h06m07s)

[marked as thread local it's not one per](https://youtu.be/HyJJX6FFdpA?t=02h06m10s)

[process it's one per thread which is](https://youtu.be/HyJJX6FFdpA?t=02h06m12s)

[really fun when multiple threads start](https://youtu.be/HyJJX6FFdpA?t=02h06m15s)

[running your code And it gets really](https://youtu.be/HyJJX6FFdpA?t=02h06m18s)

[confusing very confusing And then](https://youtu.be/HyJJX6FFdpA?t=02h06m20s)

[because that's not messed up enough we](https://youtu.be/HyJJX6FFdpA?t=02h06m23s)

[also have async local which is tied to](https://youtu.be/HyJJX6FFdpA?t=02h06m25s)

[the async and await and will flow](https://youtu.be/HyJJX6FFdpA?t=02h06m28s)

[through that](https://youtu.be/HyJJX6FFdpA?t=02h06m30s)

[which is convenient it can be very](https://youtu.be/HyJJX6FFdpA?t=02h06m32s)

[convenient at times because then you](https://youtu.be/HyJJX6FFdpA?t=02h06m34s)

[don't care about thread but you care](https://youtu.be/HyJJX6FFdpA?t=02h06m36s)

[about the execution context and where](https://youtu.be/HyJJX6FFdpA?t=02h06m37s)

[that variable gets linked into](https://youtu.be/HyJJX6FFdpA?t=02h06m39s)

[um](https://youtu.be/HyJJX6FFdpA?t=02h06m42s)

[even if the thread ID is the same So I](https://youtu.be/HyJJX6FFdpA?t=02h06m46s)

[this seems like it might be](https://youtu.be/HyJJX6FFdpA?t=02h06m50s)

[it cited a source So let's go let's go](https://youtu.be/HyJJX6FFdpA?t=02h06m56s)

[look at its source](https://youtu.be/HyJJX6FFdpA?t=02h06m58s)

[Where did you Where did that link go](https://youtu.be/HyJJX6FFdpA?t=02h07m01s)

[Current UI culture Like this is wanting](https://youtu.be/HyJJX6FFdpA?t=02h07m10s)

[me to preserve it and then restore it](https://youtu.be/HyJJX6FFdpA?t=02h07m12s)

[But I almost like](https://youtu.be/HyJJX6FFdpA?t=02h07m17s)

[you If you must use an async lambda](https://youtu.be/HyJJX6FFdpA?t=02h07m21s)

[manually capture and restore the culture](https://youtu.be/HyJJX6FFdpA?t=02h07m23s)

[at the start of the lambda But this](https://youtu.be/HyJJX6FFdpA?t=02h07m25s)

[isn't right Like I don't want to capture](https://youtu.be/HyJJX6FFdpA?t=02h07m28s)

[it I want it to come through correctly](https://youtu.be/HyJJX6FFdpA?t=02h07m30s)

[Like it's it's not staying preserved](https://youtu.be/HyJJX6FFdpA?t=02h07m33s)

[Like it's being changed](https://youtu.be/HyJJX6FFdpA?t=02h07m36s)

[the thread local culture And I I have a](https://youtu.be/HyJJX6FFdpA?t=02h07m45s)

[hard time believing this is a thread](https://youtu.be/HyJJX6FFdpA?t=02h07m48s)

[local problem if it's the same thread](https://youtu.be/HyJJX6FFdpA?t=02h07m50s)

[Uh did you just say you can have uh](https://youtu.be/HyJJX6FFdpA?t=02h07m56s)

[static instances per async awaited](https://youtu.be/HyJJX6FFdpA?t=02h07m58s)

[Victor do you ready You ready to watch](https://youtu.be/HyJJX6FFdpA?t=02h08m02s)

[your head hurt You ready to watch your](https://youtu.be/HyJJX6FFdpA?t=02h08m04s)

[head hurt You actually are using this](https://youtu.be/HyJJX6FFdpA?t=02h08m06s)

[feature You just don't know it Um](https://youtu.be/HyJJX6FFdpA?t=02h08m09s)

[because you're using you you're using a](https://youtu.be/HyJJX6FFdpA?t=02h08m15s)

[very bad class that I wrote Um](https://youtu.be/HyJJX6FFdpA?t=02h08m18s)

[this lovely little Yeah this lovely](https://youtu.be/HyJJX6FFdpA?t=02h08m21s)

[little guy here So yes and and just to](https://youtu.be/HyJJX6FFdpA?t=02h08m24s)

[clarify this is your async local and](https://youtu.be/HyJJX6FFdpA?t=02h08m28s)

[thread local](https://youtu.be/HyJJX6FFdpA?t=02h08m31s)

[right So you'll note these are both](https://youtu.be/HyJJX6FFdpA?t=02h08m33s)

[static fields right Nothing nothing](https://youtu.be/HyJJX6FFdpA?t=02h08m35s)

[fancy about it here Um and you'll note](https://youtu.be/HyJJX6FFdpA?t=02h08m37s)

[we come in to this async method A right](https://youtu.be/HyJJX6FFdpA?t=02h08m41s)

[It sets both values to value one Uh](https://youtu.be/HyJJX6FFdpA?t=02h08m44s)

[async method B](https://youtu.be/HyJJX6FFdpA?t=02h08m48s)

[right So we jump down we jump down here](https://youtu.be/HyJJX6FFdpA?t=02h08m50s)

[and we and it writes out the values](https://youtu.be/HyJJX6FFdpA?t=02h08m52s)

[entering B here's the values blah blah](https://youtu.be/HyJJX6FFdpA?t=02h08m54s)

[blah await](https://youtu.be/HyJJX6FFdpA?t=02h08m57s)

[and then you'll note it's there's](https://youtu.be/HyJJX6FFdpA?t=02h09m00s)

[nothing set here but this is a um I](https://youtu.be/HyJJX6FFdpA?t=02h09m02s)

[think the intent is a console app where](https://youtu.be/HyJJX6FFdpA?t=02h09m04s)

[the continuation after the await is](https://youtu.be/HyJJX6FFdpA?t=02h09m07s)

[probably a different thread right and so](https://youtu.be/HyJJX6FFdpA?t=02h09m08s)

[we can see here entering asynchronous](https://youtu.be/HyJJX6FFdpA?t=02h09m10s)

[method B value one uh async local value](https://youtu.be/HyJJX6FFdpA?t=02h09m12s)

[is one thread local is value one great](https://youtu.be/HyJJX6FFdpA?t=02h09m17s)

[right we then do a exiting or I guess It](https://youtu.be/HyJJX6FFdpA?t=02h09m20s)

[does entering twice because it goes here](https://youtu.be/HyJJX6FFdpA?t=02h09m24s)

[and here Uh because you'll note this](https://youtu.be/HyJJX6FFdpA?t=02h09m26s)

[isn't a weighted t down here So we come](https://youtu.be/HyJJX6FFdpA?t=02h09m28s)

[in here and it goes asynchronous method](https://youtu.be/HyJJX6FFdpA?t=02h09m30s)

[B value two value two And then the key](https://youtu.be/HyJJX6FFdpA?t=02h09m33s)

[difference is going to be on this](https://youtu.be/HyJJX6FFdpA?t=02h09m36s)

[exiting Right Expected value two got](https://youtu.be/HyJJX6FFdpA?t=02h09m37s)

[value two thread local is empty](https://youtu.be/HyJJX6FFdpA?t=02h09m41s)

[Right Expected value one got value one](https://youtu.be/HyJJX6FFdpA?t=02h09m45s)

[thread local is empty And the reason is](https://youtu.be/HyJJX6FFdpA?t=02h09m49s)

[because this assignment occurs on](https://youtu.be/HyJJX6FFdpA?t=02h09m52s)

[whatever the starting thread is right](https://youtu.be/HyJJX6FFdpA?t=02h09m54s)

[We'll call it thread one right This](https://youtu.be/HyJJX6FFdpA?t=02h09m56s)

[occurs on thread one Goes in executes](https://youtu.be/HyJJX6FFdpA?t=02h09m58s)

[method B gets all the way to this await](https://youtu.be/HyJJX6FFdpA?t=02h10m01s)

[and goes "Oops I'm going asynchronous."](https://youtu.be/HyJJX6FFdpA?t=02h10m04s)

[Thread one go do something else Oh I'm](https://youtu.be/HyJJX6FFdpA?t=02h10m06s)

[done with my delay Who's next Thread two](https://youtu.be/HyJJX6FFdpA?t=02h10m09s)

[picks it up Thread two picks it up and](https://youtu.be/HyJJX6FFdpA?t=02h10m11s)

[goes down here And so that thread local](https://youtu.be/HyJJX6FFdpA?t=02h10m14s)

[storage is a different value per thread](https://youtu.be/HyJJX6FFdpA?t=02h10m16s)

[right different value per thread](https://youtu.be/HyJJX6FFdpA?t=02h10m20s)

[Now one of the awesome things about](https://youtu.be/HyJJX6FFdpA?t=02h10m23s)

[thread locals is you get into this](https://youtu.be/HyJJX6FFdpA?t=02h10m25s)

[situation where this is thread safe by](https://youtu.be/HyJJX6FFdpA?t=02h10m28s)

[definition](https://youtu.be/HyJJX6FFdpA?t=02h10m30s)

[right Because you always only like you](https://youtu.be/HyJJX6FFdpA?t=02h10m32s)

[can't flow the value to a different like](https://youtu.be/HyJJX6FFdpA?t=02h10m35s)

[thread safety or comes into play when](https://youtu.be/HyJJX6FFdpA?t=02h10m38s)

[you have two threads touch the same](https://youtu.be/HyJJX6FFdpA?t=02h10m40s)

[thingy Well if there's a separate value](https://youtu.be/HyJJX6FFdpA?t=02h10m42s)

[per thread you can't have effectively](https://youtu.be/HyJJX6FFdpA?t=02h10m45s)

[both threads trying to play with the](https://youtu.be/HyJJX6FFdpA?t=02h10m48s)

[same toy anymore It's like you all get](https://youtu.be/HyJJX6FFdpA?t=02h10m49s)

[one All of you little kids get to have](https://youtu.be/HyJJX6FFdpA?t=02h10m51s)

[your own copy of this toy and play with](https://youtu.be/HyJJX6FFdpA?t=02h10m54s)

[it and no one can share You all just](https://youtu.be/HyJJX6FFdpA?t=02h10m57s)

[play with your own Whereas async local](https://youtu.be/HyJJX6FFdpA?t=02h11m00s)

[is like you know what I know something](https://youtu.be/HyJJX6FFdpA?t=02h11m02s)

[about async and await because when you](https://youtu.be/HyJJX6FFdpA?t=02h11m05s)

[hit an await it has to capture up all of](https://youtu.be/HyJJX6FFdpA?t=02h11m07s)

[your local variable states so that after](https://youtu.be/HyJJX6FFdpA?t=02h11m11s)

[the await it can restore them right So](https://youtu.be/HyJJX6FFdpA?t=02h11m14s)

[like it has to capture this expected](https://youtu.be/HyJJX6FFdpA?t=02h11m16s)

[value to know when I come back after](https://youtu.be/HyJJX6FFdpA?t=02h11m18s)

[this uh await here I have to repopulate](https://youtu.be/HyJJX6FFdpA?t=02h11m22s)

[expected value because that's a local](https://youtu.be/HyJJX6FFdpA?t=02h11m26s)

[variable and I needed to have the right](https://youtu.be/HyJJX6FFdpA?t=02h11m28s)

[thing So as part of that um async and](https://youtu.be/HyJJX6FFdpA?t=02h11m30s)

[await framework there is the uh I think](https://youtu.be/HyJJX6FFdpA?t=02h11m33s)

[it's execution context that contains the](https://youtu.be/HyJJX6FFdpA?t=02h11m36s)

[storage um but it captures those](https://youtu.be/HyJJX6FFdpA?t=02h11m38s)

[variables stores them and then when it](https://youtu.be/HyJJX6FFdpA?t=02h11m41s)

[comes back it restores them all back](https://youtu.be/HyJJX6FFdpA?t=02h11m44s)

[into their appropriate places But](https://youtu.be/HyJJX6FFdpA?t=02h11m47s)

[because it's a different thread this](https://youtu.be/HyJJX6FFdpA?t=02h11m49s)

[then is not set because its assignment](https://youtu.be/HyJJX6FFdpA?t=02h11m51s)

[was always done on this thread Um worth](https://youtu.be/HyJJX6FFdpA?t=02h11m54s)

[noting that's not always true If you](https://youtu.be/HyJJX6FFdpA?t=02h11m57s)

[were to take this code and throw this](https://youtu.be/HyJJX6FFdpA?t=02h12m00s)

[into a WPF application this is not the](https://youtu.be/HyJJX6FFdpA?t=02h12m03s)

[output that you would get because the](https://youtu.be/HyJJX6FFdpA?t=02h12m05s)

[default behavior of an asynchronous](https://youtu.be/HyJJX6FFdpA?t=02h12m08s)

[method in something like a UI based](https://youtu.be/HyJJX6FFdpA?t=02h12m10s)

[application is configure await true the](https://youtu.be/HyJJX6FFdpA?t=02h12m12s)

[thread after the await will be the same](https://youtu.be/HyJJX6FFdpA?t=02h12m16s)

[thread](https://youtu.be/HyJJX6FFdpA?t=02h12m19s)

[only because it um in a UI application](https://youtu.be/HyJJX6FFdpA?t=02h12m21s)

[if you put an async in the middle of say](https://youtu.be/HyJJX6FFdpA?t=02h12m24s)

[a click handler you want to come back to](https://youtu.be/HyJJX6FFdpA?t=02h12m26s)

[that same UI thread because it's like oh](https://youtu.be/HyJJX6FFdpA?t=02h12m28s)

[I do the asynchronous thing and then I](https://youtu.be/HyJJX6FFdpA?t=02h12m31s)

[set those variables back into my UI and](https://youtu.be/HyJJX6FFdpA?t=02h12m33s)

[so to save on everybody needing to](https://youtu.be/HyJJX6FFdpA?t=02h12m36s)

[marshall back to the UI every time the](https://youtu.be/HyJJX6FFdpA?t=02h12m37s)

[default behavior when there is a UI](https://youtu.be/HyJJX6FFdpA?t=02h12m40s)

[thread is to just go back to it if](https://youtu.be/HyJJX6FFdpA?t=02h12m42s)

[that's where you started from right](https://youtu.be/HyJJX6FFdpA?t=02h12m44s)

[Which is generally convenient The](https://youtu.be/HyJJX6FFdpA?t=02h12m46s)

[disadvantage is it's a potential](https://youtu.be/HyJJX6FFdpA?t=02h12m48s)

[performance bottleneck because there is](https://youtu.be/HyJJX6FFdpA?t=02h12m50s)

[only one UI thread and it means you're](https://youtu.be/HyJJX6FFdpA?t=02h12m52s)

[doing work on the UI thread Which is why](https://youtu.be/HyJJX6FFdpA?t=02h12m54s)

[you'll see the recommendation to do](https://youtu.be/HyJJX6FFdpA?t=02h12m56s)

[continue configure await false to say](https://youtu.be/HyJJX6FFdpA?t=02h12m57s)

[rather than rely on the UI thread right](https://youtu.be/HyJJX6FFdpA?t=02h13m01s)

[Like do you always have to ask the head](https://youtu.be/HyJJX6FFdpA?t=02h13m03s)

[guy to do the work or can anybody do the](https://youtu.be/HyJJX6FFdpA?t=02h13m05s)

[work right Configure await false says](https://youtu.be/HyJJX6FFdpA?t=02h13m07s)

[you know I don't need the head guy to do](https://youtu.be/HyJJX6FFdpA?t=02h13m09s)

[this I just got some stuff I need to get](https://youtu.be/HyJJX6FFdpA?t=02h13m11s)

[done Whoever's available next is great](https://youtu.be/HyJJX6FFdpA?t=02h13m13s)

[right That's what configure weight false](https://youtu.be/HyJJX6FFdpA?t=02h13m15s)

[gets you is who's ever available next](https://youtu.be/HyJJX6FFdpA?t=02h13m17s)

[I'd like them to do a little work for me](https://youtu.be/HyJJX6FFdpA?t=02h13m19s)

[Great right But it's like well to](https://youtu.be/HyJJX6FFdpA?t=02h13m21s)

[actually post that work on the UI yeah](https://youtu.be/HyJJX6FFdpA?t=02h13m24s)

[you need that that head honcho UI thread](https://youtu.be/HyJJX6FFdpA?t=02h13m26s)

[dude But yes you are correct So there is](https://youtu.be/HyJJX6FFdpA?t=02h13m28s)

[there is async local and thread local Um](https://youtu.be/HyJJX6FFdpA?t=02h13m31s)

[use them only to do good And for Victor](https://youtu.be/HyJJX6FFdpA?t=02h13m35s)

[for fun if you want to hunt your current](https://youtu.be/HyJJX6FFdpA?t=02h13m40s)

[codebase you will find instances of](https://youtu.be/HyJJX6FFdpA?t=02h13m42s)

[async local littered into particular](https://youtu.be/HyJJX6FFdpA?t=02h13m45s)

[classes that I may have my fingers all](https://youtu.be/HyJJX6FFdpA?t=02h13m48s)

[over My bad](https://youtu.be/HyJJX6FFdpA?t=02h13m50s)

[Like something that starts with auto](https://youtu.be/HyJJX6FFdpA?t=02h13m54s)

[mocker and ends in the word resolver](https://youtu.be/HyJJX6FFdpA?t=02h13m57s)

[That's your hint](https://youtu.be/HyJJX6FFdpA?t=02h14m00s)

[Um worth noting async local isn't](https://youtu.be/HyJJX6FFdpA?t=02h14m04s)

[preserved inside of say a task.run](https://youtu.be/HyJJX6FFdpA?t=02h14m07s)

[right Because that's intentionally a](https://youtu.be/HyJJX6FFdpA?t=02h14m11s)

[different asynchronous scope So worth](https://youtu.be/HyJJX6FFdpA?t=02h14m12s)

[noting So if you ever want to break an](https://youtu.be/HyJJX6FFdpA?t=02h14m16s)

[async local you wrap something in a task](https://youtu.be/HyJJX6FFdpA?t=02h14m18s)

[And watch it crash and burn Okay Now](https://youtu.be/HyJJX6FFdpA?t=02h14m20s)

[co-pilot though](https://youtu.be/HyJJX6FFdpA?t=02h14m24s)

[the behavior that I am seeing does](https://youtu.be/HyJJX6FFdpA?t=02h14m28s)

[appear to match](https://youtu.be/HyJJX6FFdpA?t=02h14m31s)

[the description here](https://youtu.be/HyJJX6FFdpA?t=02h14m33s)

[Um oh that link was just an automatic So](https://youtu.be/HyJJX6FFdpA?t=02h14m37s)

[um how can I](https://youtu.be/HyJJX6FFdpA?t=02h14m42s)

[preserve](https://youtu.be/HyJJX6FFdpA?t=02h14m45s)

[changes to](https://youtu.be/HyJJX6FFdpA?t=02h14m47s)

[thread culture](https://youtu.be/HyJJX6FFdpA?t=02h14m49s)

[uh that is set inside of an async lambda](https://youtu.be/HyJJX6FFdpA?t=02h14m53s)

[cuz really at the end of the day this](https://youtu.be/HyJJX6FFdpA?t=02h15m01s)

[entire setup was built because Nikolai](https://youtu.be/HyJJX6FFdpA?t=02h15m04s)

[wanted to test](https://youtu.be/HyJJX6FFdpA?t=02h15m06s)

[culture differences and I would be very](https://youtu.be/HyJJX6FFdpA?t=02h15m09s)

[annoyed if I could not](https://youtu.be/HyJJX6FFdpA?t=02h15m12s)

[do so](https://youtu.be/HyJJX6FFdpA?t=02h15m15s)

[Um culture info are backed by async](https://youtu.be/HyJJX6FFdpA?t=02h15m19s)

[Okay let's go I'm I'm tired of it](https://youtu.be/HyJJX6FFdpA?t=02h15m25s)

[telling me this Let's go look Let's go](https://youtu.be/HyJJX6FFdpA?t=02h15m27s)

[look You are telling me](https://youtu.be/HyJJX6FFdpA?t=02h15m30s)

[this guy is backed by an async local Oh](https://youtu.be/HyJJX6FFdpA?t=02h15m34s)

[no](https://youtu.be/HyJJX6FFdpA?t=02h15m37s)

[Oh no](https://youtu.be/HyJJX6FFdpA?t=02h15m39s)

[Oh no](https://youtu.be/HyJJX6FFdpA?t=02h15m42s)

[Oh no](https://youtu.be/HyJJX6FFdpA?t=02h15m44s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=02h15m47s)

[So this is the other way you can declare](https://youtu.be/HyJJX6FFdpA?t=02h15m49s)

[a thread static](https://youtu.be/HyJJX6FFdpA?t=02h15m51s)

[Oh no](https://youtu.be/HyJJX6FFdpA?t=02h15m54s)

[Oh no](https://youtu.be/HyJJX6FFdpA?t=02h15m59s)

[Oh no No](https://youtu.be/HyJJX6FFdpA?t=02h16m02s)

[Oh](https://youtu.be/HyJJX6FFdpA?t=02h16m06s)

[you hurt me so badly](https://youtu.be/HyJJX6FFdpA?t=02h16m10s)

[Wait a minute It isn't using the async](https://youtu.be/HyJJX6FFdpA?t=02h16m15s)

[local field anywhere Hold on This is](https://youtu.be/HyJJX6FFdpA?t=02h16m17s)

[methods for current the following order](https://youtu.be/HyJJX6FFdpA?t=02h16m21s)

[when RT return the current user profile](https://youtu.be/HyJJX6FFdpA?t=02h16m25s)

[language The current thread culture that](https://youtu.be/HyJJX6FFdpA?t=02h16m28s)

[has already been set using one of the](https://youtu.be/HyJJX6FFdpA?t=02h16m29s)

[current culture current UI culture The](https://youtu.be/HyJJX6FFdpA?t=02h16m32s)

[thread culture if if the user is already](https://youtu.be/HyJJX6FFdpA?t=02h16m34s)

[set one of the default thread culture Uh](https://youtu.be/HyJJX6FFdpA?t=02h16m37s)

[default is okay](https://youtu.be/HyJJX6FFdpA?t=02h16m39s)

[This is interesting to me](https://youtu.be/HyJJX6FFdpA?t=02h16m43s)

[You'll note the setter is assigning to](https://youtu.be/HyJJX6FFdpA?t=02h16m50s)

[this field here](https://youtu.be/HyJJX6FFdpA?t=02h16m52s)

[You'll note something about this field](https://youtu.be/HyJJX6FFdpA?t=02h16m56s)

[It's used in the setter](https://youtu.be/HyJJX6FFdpA?t=02h17m01s)

[but not the getter](https://youtu.be/HyJJX6FFdpA?t=02h17m04s)

[What am I missing](https://youtu.be/HyJJX6FFdpA?t=02h17m08s)

[What am I missing](https://youtu.be/HyJJX6FFdpA?t=02h17m15s)

[So when you do current culture set](https://youtu.be/HyJJX6FFdpA?t=02h17m19s)

[it doesn't change the current](https://youtu.be/HyJJX6FFdpA?t=02h17m23s)

[what](https://youtu.be/HyJJX6FFdpA?t=02h17m30s)

[okaynet is not broken Net is not broken](https://youtu.be/HyJJX6FFdpA?t=02h17m34s)

[Net is not broken that okay axom number](https://youtu.be/HyJJX6FFdpA?t=02h17m37s)

[one](https://youtu.be/HyJJX6FFdpA?t=02h17m40s)

[I am not understanding something there](https://youtu.be/HyJJX6FFdpA?t=02h17m42s)

[is no way this is broken I am missing](https://youtu.be/HyJJX6FFdpA?t=02h17m44s)

[something that has to be the case](https://youtu.be/HyJJX6FFdpA?t=02h17m48s)

[right like all of these are](https://youtu.be/HyJJX6FFdpA?t=02h17m52s)

[static volatile great excellent](https://youtu.be/HyJJX6FFdpA?t=02h17m55s)

[if you ever Victor if you want to make](https://youtu.be/HyJJX6FFdpA?t=02h17m58s)

[your head hurt a little bit more go](https://youtu.be/HyJJX6FFdpA?t=02h18m00s)

[ahead and pull up the language spec for](https://youtu.be/HyJJX6FFdpA?t=02h18m02s)

[the word volatile you'll get to learn](https://youtu.be/HyJJX6FFdpA?t=02h18m04s)

[all about memory barriers and if that](https://youtu.be/HyJJX6FFdpA?t=02h18m05s)

[doesn't make your head hurt](https://youtu.be/HyJJX6FFdpA?t=02h18m09s)

[Cuz the the dirty little secret is that](https://youtu.be/HyJJX6FFdpA?t=02h18m11s)

[the runtime may choose to not execute](https://youtu.be/HyJJX6FFdpA?t=02h18m15s)

[your code in the order it's written](https://youtu.be/HyJJX6FFdpA?t=02h18m17s)

[If that doesn't terrify you a little bit](https://youtu.be/HyJJX6FFdpA?t=02h18m21s)

[I don't know what does](https://youtu.be/HyJJX6FFdpA?t=02h18m23s)

[What I just I just I just I don't Huh](https://youtu.be/HyJJX6FFdpA?t=02h18m26s)

[Okay Let Okay Okay](https://youtu.be/HyJJX6FFdpA?t=02h18m31s)

[uh thread and what what what is the what](https://youtu.be/HyJJX6FFdpA?t=02h18m35s)

[is the assignment that we are doing in](https://youtu.be/HyJJX6FFdpA?t=02h18m37s)

[here](https://youtu.be/HyJJX6FFdpA?t=02h18m39s)

[right app test thread.currenc current](https://youtu.be/HyJJX6FFdpA?t=02h18m41s)

[culture right That's what does](https://youtu.be/HyJJX6FFdpA?t=02h18m43s)

[thread.currenculture](https://youtu.be/HyJJX6FFdpA?t=02h18m46s)

[do](https://youtu.be/HyJJX6FFdpA?t=02h18m48s)

[Okay so thread current culture reaches](https://youtu.be/HyJJX6FFdpA?t=02h18m52s)

[in to current culture to bring it across](https://youtu.be/HyJJX6FFdpA?t=02h18m54s)

[right And it has this require current](https://youtu.be/HyJJX6FFdpA?t=02h18m58s)

[thread Great Fine Just checks for cross](https://youtu.be/HyJJX6FFdpA?t=02h19m00s)

[thread exceptions Uh JC I absolutely did](https://youtu.be/HyJJX6FFdpA?t=02h19m03s)

[miss you and I'm back at work We are we](https://youtu.be/HyJJX6FFdpA?t=02h19m07s)

[are having a field day of trying to](https://youtu.be/HyJJX6FFdpA?t=02h19m11s)

[understand what is going on So this test](https://youtu.be/HyJJX6FFdpA?t=02h19m14s)

[starts failing and we have confirmed](https://youtu.be/HyJJX6FFdpA?t=02h19m16s)

[that the difference between a passing](https://youtu.be/HyJJX6FFdpA?t=02h19m20s)

[test and a failing test is literally](https://youtu.be/HyJJX6FFdpA?t=02h19m22s)

[those five characters](https://youtu.be/HyJJX6FFdpA?t=02h19m24s)

[And it appears that the that the issue](https://youtu.be/HyJJX6FFdpA?t=02h19m27s)

[is around](https://youtu.be/HyJJX6FFdpA?t=02h19m31s)

[culture](https://youtu.be/HyJJX6FFdpA?t=02h19m33s)

[and the way culture inflow info is](https://youtu.be/HyJJX6FFdpA?t=02h19m34s)

[flowed through asynchronous context That](https://youtu.be/HyJJX6FFdpA?t=02h19m38s)

[is what it appears to be](https://youtu.be/HyJJX6FFdpA?t=02h19m42s)

[But we are working through this So](https://youtu.be/HyJJX6FFdpA?t=02h19m46s)

[thread Okay So setting it on the thread](https://youtu.be/HyJJX6FFdpA?t=02h19m48s)

[literally the thread just reaches into](https://youtu.be/HyJJX6FFdpA?t=02h19m51s)

[culture info current culture assignment](https://youtu.be/HyJJX6FFdpA?t=02h19m53s)

[Right And this sets the async local](https://youtu.be/HyJJX6FFdpA?t=02h19m56s)

[current culture](https://youtu.be/HyJJX6FFdpA?t=02h20m01s)

[I am confused](https://youtu.be/HyJJX6FFdpA?t=02h20m06s)

[why culture info](https://youtu.be/HyJJX6FFdpA?t=02h20m09s)

[assignment](https://youtu.be/HyJJX6FFdpA?t=02h20m11s)

[sets this field but then the getter](https://youtu.be/HyJJX6FFdpA?t=02h20m13s)

[reads not this field](https://youtu.be/HyJJX6FFdpA?t=02h20m16s)

[Like am am I I like I'm very very](https://youtu.be/HyJJX6FFdpA?t=02h20m21s)

[confused by that](https://youtu.be/HyJJX6FFdpA?t=02h20m25s)

[because that seems wrong that it would](https://youtu.be/HyJJX6FFdpA?t=02h20m27s)

[do this](https://youtu.be/HyJJX6FFdpA?t=02h20m30s)

[right and that's the only usages of this](https://youtu.be/HyJJX6FFdpA?t=02h20m32s)

[It's those three are literally the only](https://youtu.be/HyJJX6FFdpA?t=02h20m38s)

[usages that this is reporting](https://youtu.be/HyJJX6FFdpA?t=02h20m40s)

[like how would this ever work Because](https://youtu.be/HyJJX6FFdpA?t=02h20m48s)

[the thing is we have a version of this](https://youtu.be/HyJJX6FFdpA?t=02h20m51s)

[test that works which means at some](https://youtu.be/HyJJX6FFdpA?t=02h20m53s)

[point](https://youtu.be/HyJJX6FFdpA?t=02h20m55s)

[uh](https://youtu.be/HyJJX6FFdpA?t=02h20m58s)

[doctor so don't raise your hand Uh yeah](https://youtu.be/HyJJX6FFdpA?t=02h20m59s)

[like at like](https://youtu.be/HyJJX6FFdpA?t=02h21m04s)

[we've now reached the stage in the](https://youtu.be/HyJJX6FFdpA?t=02h21m06s)

[debugging process right If we're going](https://youtu.be/HyJJX6FFdpA?t=02h21m08s)

[to go back through those five stages of](https://youtu.be/HyJJX6FFdpA?t=02h21m10s)

[grief where we've gone through the why](https://youtu.be/HyJJX6FFdpA?t=02h21m11s)

[is it broken](https://youtu.be/HyJJX6FFdpA?t=02h21m15s)

[right The there there's no way it could](https://youtu.be/HyJJX6FFdpA?t=02h21m17s)

[be my code We've gotten to the you know](https://youtu.be/HyJJX6FFdpA?t=02h21m20s)

[there's a bug in the .NET framework and](https://youtu.be/HyJJX6FFdpA?t=02h21m22s)

[then now we've reached the how did it](https://youtu.be/HyJJX6FFdpA?t=02h21m25s)

[ever work stage of our debugging grief](https://youtu.be/HyJJX6FFdpA?t=02h21m27s)

[Yeah I like](https://youtu.be/HyJJX6FFdpA?t=02h21m32s)

[huh](https://youtu.be/HyJJX6FFdpA?t=02h21m34s)

[Like like Okay](https://youtu.be/HyJJX6FFdpA?t=02h21m36s)

[So it comes in here](https://youtu.be/HyJJX6FFdpA?t=02h21m41s)

[If it is null it does a compare exchange](https://youtu.be/HyJJX6FFdpA?t=02h21m46s)

[Like you'll know this is this is](https://youtu.be/HyJJX6FFdpA?t=02h21m52s)

[actually a double check right Because](https://youtu.be/HyJJX6FFdpA?t=02h21m54s)

[this no check is just for the easy case](https://youtu.be/HyJJX6FFdpA?t=02h21m57s)

[And then this one here compares the ref](https://youtu.be/HyJJX6FFdpA?t=02h22m00s)

[value of the field against null If it is](https://youtu.be/HyJJX6FFdpA?t=02h22m02s)

[null it assigns a new one in Otherwise](https://youtu.be/HyJJX6FFdpA?t=02h22m05s)

[we uh get the current value returned](https://youtu.be/HyJJX6FFdpA?t=02h22m07s)

[back to us In both cases this one is](https://youtu.be/HyJJX6FFdpA?t=02h22m10s)

[safe to access and they can do the bang](https://youtu.be/HyJJX6FFdpA?t=02h22m12s)

[not equals value which is a complicated](https://youtu.be/HyJJX6FFdpA?t=02h22m14s)

[way of doing all of that assignment But](https://youtu.be/HyJJX6FFdpA?t=02h22m18s)

[now it makes me wonder why](https://youtu.be/HyJJX6FFdpA?t=02h22m20s)

[How](https://youtu.be/HyJJX6FFdpA?t=02h22m24s)

[Okay So here's what we're going to try](https://youtu.be/HyJJX6FFdpA?t=02h22m30s)

[then Here's what we are going to try](https://youtu.be/HyJJX6FFdpA?t=02h22m32s)

[Because I know where it is](https://youtu.be/HyJJX6FFdpA?t=02h22m35s)

[I want to look at](https://youtu.be/HyJJX6FFdpA?t=02h22m38s)

[I want to look at it here](https://youtu.be/HyJJX6FFdpA?t=02h22m42s)

[And I want to look at culture info in](https://youtu.be/HyJJX6FFdpA?t=02h22m46s)

[both of these places](https://youtu.be/HyJJX6FFdpA?t=02h22m48s)

[and see what the heck is going on](https://youtu.be/HyJJX6FFdpA?t=02h22m50s)

[because there has to be](https://youtu.be/HyJJX6FFdpA?t=02h22m54s)

[there has to be something right Like](https://youtu.be/HyJJX6FFdpA?t=02h22m59s)

[there's some there is something changed](https://youtu.be/HyJJX6FFdpA?t=02h23m06s)

[Okay for anybody who follows Brian Rean](https://youtu.be/HyJJX6FFdpA?t=02h23m10s)

[Okay So if I look here and I go down and](https://youtu.be/HyJJX6FFdpA?t=02h23m14s)

[I want to look at non-public members](https://youtu.be/HyJJX6FFdpA?t=02h23m17s)

[right So we have not set anything](https://youtu.be/HyJJX6FFdpA?t=02h23m20s)

[Uh where do I get my static members Oh](https://youtu.be/HyJJX6FFdpA?t=02h23m25s)

[probably under the static non-publix](https://youtu.be/HyJJX6FFdpA?t=02h23m30s)

[That would make sense Okay So](https://youtu.be/HyJJX6FFdpA?t=02h23m34s)

[we have our async local current culture](https://youtu.be/HyJJX6FFdpA?t=02h23m38s)

[right that is there](https://youtu.be/HyJJX6FFdpA?t=02h23m43s)

[right thread default thread current](https://youtu.be/HyJJX6FFdpA?t=02h23m46s)

[culture so we're going to go there async](https://youtu.be/HyJJX6FFdpA?t=02h23m49s)

[local culture](https://youtu.be/HyJJX6FFdpA?t=02h23m52s)

[and s user default culture](https://youtu.be/HyJJX6FFdpA?t=02h23m55s)

[current thread culture I think those are](https://youtu.be/HyJJX6FFdpA?t=02h24m00s)

[all of them okay so there's that we are](https://youtu.be/HyJJX6FFdpA?t=02h24m03s)

[going to go step](https://youtu.be/HyJJX6FFdpA?t=02h24m06s)

[s current thread culture gets changed](https://youtu.be/HyJJX6FFdpA?t=02h24m13s)

[I'm a little surprised this one isn't Oh](https://youtu.be/HyJJX6FFdpA?t=02h24m18s)

[probably because I didn't pin the value](https://youtu.be/HyJJX6FFdpA?t=02h24m21s)

[I just pinned the other one Okay so that](https://youtu.be/HyJJX6FFdpA?t=02h24m23s)

[that one there](https://youtu.be/HyJJX6FFdpA?t=02h24m27s)

[the current threads culture is changed](https://youtu.be/HyJJX6FFdpA?t=02h24m32s)

[That makes sense We get to the next one](https://youtu.be/HyJJX6FFdpA?t=02h24m36s)

[That value is different despite it being](https://youtu.be/HyJJX6FFdpA?t=02h24m43s)

[the same exact](https://youtu.be/HyJJX6FFdpA?t=02h24m47s)

[thread](https://youtu.be/HyJJX6FFdpA?t=02h24m50s)

[Wow This is](https://youtu.be/HyJJX6FFdpA?t=02h24m56s)

[this hurts me on a whole new level](https://youtu.be/HyJJX6FFdpA?t=02h25m00s)

[Like I don't want to maintain my own](https://youtu.be/HyJJX6FFdpA?t=02h25m06s)

[culture variables](https://youtu.be/HyJJX6FFdpA?t=02h25m09s)

[I could but I don't want to](https://youtu.be/HyJJX6FFdpA?t=02h25m11s)

[That just](https://youtu.be/HyJJX6FFdpA?t=02h25m15s)

[that makes me feel very very sad](https://youtu.be/HyJJX6FFdpA?t=02h25m17s)

[because I could go through and grab a](https://youtu.be/HyJJX6FFdpA?t=02h25m24s)

[hold of them](https://youtu.be/HyJJX6FFdpA?t=02h25m27s)

[ahead of time because I could pull the](https://youtu.be/HyJJX6FFdpA?t=02h25m29s)

[current culture out](https://youtu.be/HyJJX6FFdpA?t=02h25m33s)

[preserve it go into the asynchronous](https://youtu.be/HyJJX6FFdpA?t=02h25m35s)

[delegate](https://youtu.be/HyJJX6FFdpA?t=02h25m38s)

[do the work](https://youtu.be/HyJJX6FFdpA?t=02h25m40s)

[and then preserve again on the way out](https://youtu.be/HyJJX6FFdpA?t=02h25m44s)

[Like that just feels so disgusting](https://youtu.be/HyJJX6FFdpA?t=02h25m46s)

[That feels very very very](https://youtu.be/HyJJX6FFdpA?t=02h25m52s)

[disgusting](https://youtu.be/HyJJX6FFdpA?t=02h25m56s)

[because this here](https://youtu.be/HyJJX6FFdpA?t=02h26m01s)

[Okay So I want to](https://youtu.be/HyJJX6FFdpA?t=02h26m05s)

[I I Yeah Yeah Yeah Test failure I get it](https://youtu.be/HyJJX6FFdpA?t=02h26m09s)

[The assert doesn't work Okay Okay Debug](https://youtu.be/HyJJX6FFdpA?t=02h26m13s)

[one more time I I I just I have a hard](https://youtu.be/HyJJX6FFdpA?t=02h26m16s)

[time](https://youtu.be/HyJJX6FFdpA?t=02h26m19s)

[swallowing this because something about](https://youtu.be/HyJJX6FFdpA?t=02h26m21s)

[my understanding of threading doesn't](https://youtu.be/HyJJX6FFdpA?t=02h26m23s)

[match](https://youtu.be/HyJJX6FFdpA?t=02h26m27s)

[what we're clearly seeing Okay So I have](https://youtu.be/HyJJX6FFdpA?t=02h26m29s)

[made an object ID on the async local](https://youtu.be/HyJJX6FFdpA?t=02h26m32s)

[variable here I am going to make an](https://youtu.be/HyJJX6FFdpA?t=02h26m36s)

[object ID on this one](https://youtu.be/HyJJX6FFdpA?t=02h26m39s)

[And so the key thing here with an object](https://youtu.be/HyJJX6FFdpA?t=02h26m43s)

[ID this is globally unique right So the](https://youtu.be/HyJJX6FFdpA?t=02h26m45s)

[debugger is now watching this particular](https://youtu.be/HyJJX6FFdpA?t=02h26m48s)

[instance It's given it the the](https://youtu.be/HyJJX6FFdpA?t=02h26m51s)

[identifier dollar sign 2 The other one's](https://youtu.be/HyJJX6FFdpA?t=02h26m52s)

[going to be dollar sign one](https://youtu.be/HyJJX6FFdpA?t=02h26m55s)

[But it means that we now have a](https://youtu.be/HyJJX6FFdpA?t=02h26m57s)

[effectively a global reference to this](https://youtu.be/HyJJX6FFdpA?t=02h26m59s)

[guy Right This has gone in here and I'm](https://youtu.be/HyJJX6FFdpA?t=02h27m01s)

[going to make an object ID reference to](https://youtu.be/HyJJX6FFdpA?t=02h27m06s)

[here](https://youtu.be/HyJJX6FFdpA?t=02h27m09s)

[Okay we're going to pull that guy out](https://youtu.be/HyJJX6FFdpA?t=02h27m16s)

[And if we look here that is dollar sign](https://youtu.be/HyJJX6FFdpA?t=02h27m18s)

[three](https://youtu.be/HyJJX6FFdpA?t=02h27m20s)

[And it literally puts back two](https://youtu.be/HyJJX6FFdpA?t=02h27m26s)

[and it puts it back](https://youtu.be/HyJJX6FFdpA?t=02h27m30s)

[probably because of the current state](https://youtu.be/HyJJX6FFdpA?t=02h27m35s)

[Man I I guess we have to hack around it](https://youtu.be/HyJJX6FFdpA?t=02h27m38s)

[Is there a better way of doing this](https://youtu.be/HyJJX6FFdpA?t=02h27m42s)

[So okay this this this is going to be](https://youtu.be/HyJJX6FFdpA?t=02h27m48s)

[hacky](https://youtu.be/HyJJX6FFdpA?t=02h27m51s)

[and](https://youtu.be/HyJJX6FFdpA?t=02h27m53s)

[please don't hate me Want to check the](https://youtu.be/HyJJX6FFdpA?t=02h27m54s)

[the return value on this delegate I](https://youtu.be/HyJJX6FFdpA?t=02h27m57s)

[think](https://youtu.be/HyJJX6FFdpA?t=02h27m59s)

[yeah I think what we do is the following](https://youtu.be/HyJJX6FFdpA?t=02h28m02s)

[Ev](https://youtu.be/HyJJX6FFdpA?t=02h28m07s)

[I think what we do is we go with uh](https://youtu.be/HyJJX6FFdpA?t=02h28m11s)

[culture info](https://youtu.be/HyJJX6FFdpA?t=02h28m15s)

[uh current](https://youtu.be/HyJJX6FFdpA?t=02h28m18s)

[uh UI culture](https://youtu.be/HyJJX6FFdpA?t=02h28m21s)

[right And then we go await application](https://youtu.be/HyJJX6FFdpA?t=02h28m25s)

[dispatch and we yank those suckers out](https://youtu.be/HyJJX6FFdpA?t=02h28m28s)

[cannot await void We don't need to await](https://youtu.be/HyJJX6FFdpA?t=02h28m36s)

[void Uh but we could](https://youtu.be/HyJJX6FFdpA?t=02h28m40s)

[invoke](https://youtu.be/HyJJX6FFdpA?t=02h28m43s)

[a sync](https://youtu.be/HyJJX6FFdpA?t=02h28m44s)

[right Um but we actually don't need we](https://youtu.be/HyJJX6FFdpA?t=02h28m46s)

[don't need to await or do anything right](https://youtu.be/HyJJX6FFdpA?t=02h28m49s)

[And then if we come in here](https://youtu.be/HyJJX6FFdpA?t=02h28m53s)

[because I'm curious what this will be if](https://youtu.be/HyJJX6FFdpA?t=02h28m57s)

[this will show the changed value or not](https://youtu.be/HyJJX6FFdpA?t=02h28m59s)

[And then I think what we do is we do](https://youtu.be/HyJJX6FFdpA?t=02h29m02s)

[this and we do this](https://youtu.be/HyJJX6FFdpA?t=02h29m06s)

[use of unassigned local variable](https://youtu.be/HyJJX6FFdpA?t=02h29m12s)

[um null bang I just need to shut it up](https://youtu.be/HyJJX6FFdpA?t=02h29m16s)

[because it doesn't real it can't](https://youtu.be/HyJJX6FFdpA?t=02h29m20s)

[guarantee that this delegate is invoked](https://youtu.be/HyJJX6FFdpA?t=02h29m23s)

[before this delegate but we know that](https://youtu.be/HyJJX6FFdpA?t=02h29m25s)

[practically it will be So we just tell](https://youtu.be/HyJJX6FFdpA?t=02h29m26s)

[it to shut up So I am curious if this](https://youtu.be/HyJJX6FFdpA?t=02h29m29s)

[one here what the values will be](https://youtu.be/HyJJX6FFdpA?t=02h29m32s)

[coming into this](https://youtu.be/HyJJX6FFdpA?t=02h29m36s)

[right like will it will this delegate](https://youtu.be/HyJJX6FFdpA?t=02h29m38s)

[see the updated ones that were set in](https://youtu.be/HyJJX6FFdpA?t=02h29m41s)

[the first pass](https://youtu.be/HyJJX6FFdpA?t=02h29m46s)

[Okay](https://youtu.be/HyJJX6FFdpA?t=02h29m48s)

[let's see what we get here](https://youtu.be/HyJJX6FFdpA?t=02h29m52s)

[cuz remember these are like this is all](https://youtu.be/HyJJX6FFdpA?t=02h29m55s)

[executing in the same process](https://youtu.be/HyJJX6FFdpA?t=02h29m59s)

[space So let's see current currently is](https://youtu.be/HyJJX6FFdpA?t=02h30m02s)

[enus UI culture is enus the first pass](https://youtu.be/HyJJX6FFdpA?t=02h30m05s)

[in so this is expected for now right we](https://youtu.be/HyJJX6FFdpA?t=02h30m08s)

[come in here this is the guy that's](https://youtu.be/HyJJX6FFdpA?t=02h30m12s)

[going to do the change does the details](https://youtu.be/HyJJX6FFdpA?t=02h30m13s)

[got it we come back in here](https://youtu.be/HyJJX6FFdpA?t=02h30m15s)

[current UI culture](https://youtu.be/HyJJX6FFdpA?t=02h30m19s)

[is different](https://youtu.be/HyJJX6FFdpA?t=02h30m25s)

[okay so here's what I'm curious of if I](https://youtu.be/HyJJX6FFdpA?t=02h30m31s)

[go all the way down here](https://youtu.be/HyJJX6FFdpA?t=02h30m34s)

[right So return reply](https://youtu.be/HyJJX6FFdpA?t=02h30m36s)

[at the very end of this delegate](https://youtu.be/HyJJX6FFdpA?t=02h30m42s)

[Can I do](https://youtu.be/HyJJX6FFdpA?t=02h30m45s)

[realize my big head's in the way Uh](https://youtu.be/HyJJX6FFdpA?t=02h30m48s)

[current equals](https://youtu.be/HyJJX6FFdpA?t=02h30m51s)

[right that goes like that And then UI](https://youtu.be/HyJJX6FFdpA?t=02h30m53s)

[culture](https://youtu.be/HyJJX6FFdpA?t=02h30m56s)

[looks like that](https://youtu.be/HyJJX6FFdpA?t=02h30m58s)

[And then if that works](https://youtu.be/HyJJX6FFdpA?t=02h31m02s)

[can I then](https://youtu.be/HyJJX6FFdpA?t=02h31m05s)

[propagate them appropriately](https://youtu.be/HyJJX6FFdpA?t=02h31m09s)

[Like this](https://youtu.be/HyJJX6FFdpA?t=02h31m16s)

[Like this is uglier than I'll get out I](https://youtu.be/HyJJX6FFdpA?t=02h31m23s)

[hope this doesn't work because I don't](https://youtu.be/HyJJX6FFdpA?t=02h31m25s)

[want to ship code like this But I am now](https://youtu.be/HyJJX6FFdpA?t=02h31m27s)

[curious if this works and this works](https://youtu.be/HyJJX6FFdpA?t=02h31m29s)

[I am I am curious if that works](https://youtu.be/HyJJX6FFdpA?t=02h31m37s)

[And I left a break point at the end](https://youtu.be/HyJJX6FFdpA?t=02h31m43s)

[didn't I Where I capture it Yeah Good](https://youtu.be/HyJJX6FFdpA?t=02h31m45s)

[good good good Because I'm curious what](https://youtu.be/HyJJX6FFdpA?t=02h31m48s)

[the thread shows down here because again](https://youtu.be/HyJJX6FFdpA?t=02h31m49s)

[we aren't hitting any of the awaits](https://youtu.be/HyJJX6FFdpA?t=02h31m51s)

[Okay So we come in here we change the](https://youtu.be/HyJJX6FFdpA?t=02h31m58s)

[current culture Great We come here we](https://youtu.be/HyJJX6FFdpA?t=02h32m01s)

[read the current culture This is still](https://youtu.be/HyJJX6FFdpA?t=02h32m05s)

[showing changed Okay that makes me feel](https://youtu.be/HyJJX6FFdpA?t=02h32m07s)

[better](https://youtu.be/HyJJX6FFdpA?t=02h32m11s)

[Now we come over here](https://youtu.be/HyJJX6FFdpA?t=02h32m13s)

[and this guy changed changed Okay](https://youtu.be/HyJJX6FFdpA?t=02h32m16s)

[now it actually is persisted](https://youtu.be/HyJJX6FFdpA?t=02h32m23s)

[I hate everything about this](https://youtu.be/HyJJX6FFdpA?t=02h32m29s)

[I hate every everything about this Cuz](https://youtu.be/HyJJX6FFdpA?t=02h32m34s)

[now the test is going to pass Dang damn](https://youtu.be/HyJJX6FFdpA?t=02h32m37s)

[it](https://youtu.be/HyJJX6FFdpA?t=02h32m39s)

[I hate everything about this](https://youtu.be/HyJJX6FFdpA?t=02h32m44s)

[Do I ship this](https://youtu.be/HyJJX6FFdpA?t=02h32m48s)

[Like that is ugly](https://youtu.be/HyJJX6FFdpA?t=02h32m51s)

[That is](https://youtu.be/HyJJX6FFdpA?t=02h32m55s)

[ugly](https://youtu.be/HyJJX6FFdpA?t=02h32m56s)

[all because of these And I the the part](https://youtu.be/HyJJX6FFdpA?t=02h32m59s)

[that's baffling me is I still don't](https://youtu.be/HyJJX6FFdpA?t=02h33m03s)

[fully understand what's different You](https://youtu.be/HyJJX6FFdpA?t=02h33m05s)

[know what Let's grab this in here I want](https://youtu.be/HyJJX6FFdpA?t=02h33m07s)

[to understand what's different](https://youtu.be/HyJJX6FFdpA?t=02h33m10s)

[Because when it comes through](https://youtu.be/HyJJX6FFdpA?t=02h33m19s)

[the async local variable is what is](https://youtu.be/HyJJX6FFdpA?t=02h33m24s)

[different](https://youtu.be/HyJJX6FFdpA?t=02h33m27s)

[The async local is what is different](https://youtu.be/HyJJX6FFdpA?t=02h33m33s)

[And there must be special handling](https://youtu.be/HyJJX6FFdpA?t=02h33m44s)

[around the asynchronous stuff to make it](https://youtu.be/HyJJX6FFdpA?t=02h33m46s)

[so that this has to be different](https://youtu.be/HyJJX6FFdpA?t=02h33m51s)

[I wonder what happens if I do this](https://youtu.be/HyJJX6FFdpA?t=02h33m59s)

[Can we do this Because I think we can](https://youtu.be/HyJJX6FFdpA?t=02h34m11s)

[come in here and I think we can do](https://youtu.be/HyJJX6FFdpA?t=02h34m14s)

[request](https://youtu.be/HyJJX6FFdpA?t=02h34m18s)

[and I think I can do this](https://youtu.be/HyJJX6FFdpA?t=02h34m20s)

[I think I can type it](https://youtu.be/HyJJX6FFdpA?t=02h34m24s)

[Yeah you you are probably going to lose](https://youtu.be/HyJJX6FFdpA?t=02h34m31s)

[your mind](https://youtu.be/HyJJX6FFdpA?t=02h34m34s)

[Um](https://youtu.be/HyJJX6FFdpA?t=02h34m38s)

[all right It can't pass in](https://youtu.be/HyJJX6FFdpA?t=02h34m47s)

[the base class](https://youtu.be/HyJJX6FFdpA?t=02h34m51s)

[That's probably something we can address](https://youtu.be/HyJJX6FFdpA?t=02h34m56s)

[though](https://youtu.be/HyJJX6FFdpA?t=02h34m58s)

[Um](https://youtu.be/HyJJX6FFdpA?t=02h35m03s)

[yeah we can probably address the](https://youtu.be/HyJJX6FFdpA?t=02h35m11s)

[application problem That's not as big of](https://youtu.be/HyJJX6FFdpA?t=02h35m14s)

[an issue It's everything else that's not](https://youtu.be/HyJJX6FFdpA?t=02h35m16s)

[going to be static](https://youtu.be/HyJJX6FFdpA?t=02h35m19s)

[because all of these things are](https://youtu.be/HyJJX6FFdpA?t=02h35m25s)

[instance-based](https://youtu.be/HyJJX6FFdpA?t=02h35m26s)

[So it would need to pass in what](https://youtu.be/HyJJX6FFdpA?t=02h35m28s)

[um visual tree service](https://youtu.be/HyJJX6FFdpA?t=02h35m36s)

[Actually you know what Before we get](https://youtu.be/HyJJX6FFdpA?t=02h35m41s)

[carried away let's](https://youtu.be/HyJJX6FFdpA?t=02h35m42s)

[let's not let's not do anything anything](https://youtu.be/HyJJX6FFdpA?t=02h35m45s)

[rash](https://youtu.be/HyJJX6FFdpA?t=02h35m48s)

[Well let's do something very rash but](https://youtu.be/HyJJX6FFdpA?t=02h35m50s)

[let's do it in a nice way Um can I do a](https://youtu.be/HyJJX6FFdpA?t=02h35m52s)

[static one here](https://youtu.be/HyJJX6FFdpA?t=02h35m56s)

[Get the um](https://youtu.be/HyJJX6FFdpA?t=02h36m00s)

[get the appropriate values Static async](https://youtu.be/HyJJX6FFdpA?t=02h36m04s)

[Right this is what I want I want to get](https://youtu.be/HyJJX6FFdpA?t=02h36m09s)

[the right values here And I want to be](https://youtu.be/HyJJX6FFdpA?t=02h36m11s)

[able to pass in a visual](https://youtu.be/HyJJX6FFdpA?t=02h36m14s)

[tree service](https://youtu.be/HyJJX6FFdpA?t=02h36m17s)

[VT and a remote](https://youtu.be/HyJJX6FFdpA?t=02h36m19s)

[uh invocation request because if I can](https://youtu.be/HyJJX6FFdpA?t=02h36m23s)

[get both of these in problem solved](https://youtu.be/HyJJX6FFdpA?t=02h36m25s)

[right And then this guy here is going to](https://youtu.be/HyJJX6FFdpA?t=02h36m30s)

[need to take in the parameters So I pass](https://youtu.be/HyJJX6FFdpA?t=02h36m33s)

[in this and request and then we see if](https://youtu.be/HyJJX6FFdpA?t=02h36m36s)

[that works](https://youtu.be/HyJJX6FFdpA?t=02h36m40s)

[I don't know what is going to happen](https://youtu.be/HyJJX6FFdpA?t=02h36m44s)

[One of the dumbest issues I've ever seen](https://youtu.be/HyJJX6FFdpA?t=02h36m56s)

[I'm surprised I haven't been bit by it](https://youtu.be/HyJJX6FFdpA?t=02h37m00s)

[more](https://youtu.be/HyJJX6FFdpA?t=02h37m02s)

[Okay so we can we can make this work](https://youtu.be/HyJJX6FFdpA?t=02h37m03s)

[This works and your current culture is](https://youtu.be/HyJJX6FFdpA?t=02h37m07s)

[enus And the key part is there's an](https://youtu.be/HyJJX6FFdpA?t=02h37m11s)

[async keyword So I'm curious what's](https://youtu.be/HyJJX6FFdpA?t=02h37m13s)

[about to happen](https://youtu.be/HyJJX6FFdpA?t=02h37m14s)

[when we when we get on the second pass](https://youtu.be/HyJJX6FFdpA?t=02h37m16s)

[through right Because these are still](https://youtu.be/HyJJX6FFdpA?t=02h37m18s)

[enus Great Changes culture does the](https://youtu.be/HyJJX6FFdpA?t=02h37m19s)

[needful right Comes back in right We get](https://youtu.be/HyJJX6FFdpA?t=02h37m23s)

[here and the outer ones Oh because](https://youtu.be/HyJJX6FFdpA?t=02h37m27s)

[they've been replaced right](https://youtu.be/HyJJX6FFdpA?t=02h37m31s)

[Ah look at that](https://youtu.be/HyJJX6FFdpA?t=02h37m35s)

[Look at that](https://youtu.be/HyJJX6FFdpA?t=02h37m39s)

[And then the return value of this is](https://youtu.be/HyJJX6FFdpA?t=02h37m44s)

[what](https://youtu.be/HyJJX6FFdpA?t=02h37m46s)

[This is invoke delegate object](https://youtu.be/HyJJX6FFdpA?t=02h37m51s)

[So what if this is arbitrary delegate](https://youtu.be/HyJJX6FFdpA?t=02h37m56s)

[Can I await it](https://youtu.be/HyJJX6FFdpA?t=02h38m00s)

[Can I Can I do an await in here and get](https://youtu.be/HyJJX6FFdpA?t=02h38m04s)

[away with this](https://youtu.be/HyJJX6FFdpA?t=02h38m07s)

[Something tells me the answer is going](https://youtu.be/HyJJX6FFdpA?t=02h38m10s)

[to be no](https://youtu.be/HyJJX6FFdpA?t=02h38m12s)

[because I also need to be able to return](https://youtu.be/HyJJX6FFdpA?t=02h38m14s)

[um](https://youtu.be/HyJJX6FFdpA?t=02h38m19s)

[like I need to be able to get something](https://youtu.be/HyJJX6FFdpA?t=02h38m20s)

[back out](https://youtu.be/HyJJX6FFdpA?t=02h38m22s)

[Bring bar gets await Like I need to be](https://youtu.be/HyJJX6FFdpA?t=02h38m25s)

[able to do this](https://youtu.be/HyJJX6FFdpA?t=02h38m28s)

[and I think I can get away with a direct](https://youtu.be/HyJJX6FFdpA?t=02h38m33s)

[task cast](https://youtu.be/HyJJX6FFdpA?t=02h38m37s)

[I don't know though](https://youtu.be/HyJJX6FFdpA?t=02h38m40s)

[cannot implic Oh task of string](https://youtu.be/HyJJX6FFdpA?t=02h38m47s)

[I think this is going to work](https://youtu.be/HyJJX6FFdpA?t=02h38m55s)

[like this I I am now down in the weeds](https://youtu.be/HyJJX6FFdpA?t=02h38m59s)

[of something I have not done before](https://youtu.be/HyJJX6FFdpA?t=02h39m01s)

[And I think that](https://youtu.be/HyJJX6FFdpA?t=02h39m06s)

[okay don't care as much about you](https://youtu.be/HyJJX6FFdpA?t=02h39m11s)

[So what like I assume you are going to](https://youtu.be/HyJJX6FFdpA?t=02h39m15s)

[be US still Yeah Yeah Yeah Great Great](https://youtu.be/HyJJX6FFdpA?t=02h39m17s)

[Do the needful change the thing Okay](https://youtu.be/HyJJX6FFdpA?t=02h39m20s)

[Come back in Right We got the new value](https://youtu.be/HyJJX6FFdpA?t=02h39m23s)

[Great Come in here Right We check it We](https://youtu.be/HyJJX6FFdpA?t=02h39m27s)

[check it](https://youtu.be/HyJJX6FFdpA?t=02h39m30s)

[This is interesting because it is a](https://youtu.be/HyJJX6FFdpA?t=02h39m41s)

[static async](https://youtu.be/HyJJX6FFdpA?t=02h39m44s)

[Why does that change it though](https://youtu.be/HyJJX6FFdpA?t=02h39m49s)

[Why does that change it There is a hole](https://youtu.be/HyJJX6FFdpA?t=02h39m52s)

[in my knowledge](https://youtu.be/HyJJX6FFdpA?t=02h39m54s)

[bothering me But what this means is we](https://youtu.be/HyJJX6FFdpA?t=02h39m57s)

[don't need to do this garbage here](https://youtu.be/HyJJX6FFdpA?t=02h40m00s)

[Can we get foo back out I assume we can](https://youtu.be/HyJJX6FFdpA?t=02h40m05s)

[I guess I I guess the question is](https://youtu.be/HyJJX6FFdpA?t=02h40m10s)

[getting bar](https://youtu.be/HyJJX6FFdpA?t=02h40m11s)

[right](https://youtu.be/HyJJX6FFdpA?t=02h40m15s)

[Oh uh I kind of step out](https://youtu.be/HyJJX6FFdpA?t=02h40m18s)

[step out step out step out](https://youtu.be/HyJJX6FFdpA?t=02h40m23s)

[I should be able to look at bar here](https://youtu.be/HyJJX6FFdpA?t=02h40m28s)

[bar is the correct value Okay So I think](https://youtu.be/HyJJX6FFdpA?t=02h40m32s)

[what we can do then to make this work](https://youtu.be/HyJJX6FFdpA?t=02h40m36s)

[is we can change this to](https://youtu.be/HyJJX6FFdpA?t=02h40m40s)

[static](https://youtu.be/HyJJX6FFdpA?t=02h40m43s)

[We can change this to](https://youtu.be/HyJJX6FFdpA?t=02h40m44s)

[this](https://youtu.be/HyJJX6FFdpA?t=02h40m48s)

[and we can pass the values in](https://youtu.be/HyJJX6FFdpA?t=02h40m51s)

[I'm going to call it service instead](https://youtu.be/HyJJX6FFdpA?t=02h40m54s)

[Right And the return value from this is](https://youtu.be/HyJJX6FFdpA?t=02h40m58s)

[going to end up needing to be task of](https://youtu.be/HyJJX6FFdpA?t=02h41m00s)

[whatever the response object is Uh this](https://youtu.be/HyJJX6FFdpA?t=02h41m03s)

[reply](https://youtu.be/HyJJX6FFdpA?t=02h41m08s)

[we're going to put this reply here And](https://youtu.be/HyJJX6FFdpA?t=02h41m10s)

[we're going to go reply equals](https://youtu.be/HyJJX6FFdpA?t=02h41m12s)

[and actually we're going to do remote](https://youtu.be/HyJJX6FFdpA?t=02h41m19s)

[invocation reply We're going to just](https://youtu.be/HyJJX6FFdpA?t=02h41m21s)

[declare in line Then we're going to move](https://youtu.be/HyJJX6FFdpA?t=02h41m23s)

[the creation of this inside of the](https://youtu.be/HyJJX6FFdpA?t=02h41m25s)

[delegate](https://youtu.be/HyJJX6FFdpA?t=02h41m27s)

[We're going to get rid of this absolute](https://youtu.be/HyJJX6FFdpA?t=02h41m29s)

[garbage of code](https://youtu.be/HyJJX6FFdpA?t=02h41m32s)

[And we're going to get rid of this](https://youtu.be/HyJJX6FFdpA?t=02h41m36s)

[culture setting stuff That all goes away](https://youtu.be/HyJJX6FFdpA?t=02h41m37s)

[This all goes away](https://youtu.be/HyJJX6FFdpA?t=02h41m41s)

[This all goes away We need a second](https://youtu.be/HyJJX6FFdpA?t=02h41m44s)

[closing print here to handle the cast](https://youtu.be/HyJJX6FFdpA?t=02h41m47s)

[And then we need to pass in the](https://youtu.be/HyJJX6FFdpA?t=02h41m50s)

[collection of items which is going to be](https://youtu.be/HyJJX6FFdpA?t=02h41m52s)

[this and request](https://youtu.be/HyJJX6FFdpA?t=02h41m54s)

[that gets us into there Now for most of](https://youtu.be/HyJJX6FFdpA?t=02h41m57s)

[these things I think we can just do](https://youtu.be/HyJJX6FFdpA?t=02h42m00s)

[service dot](https://youtu.be/HyJJX6FFdpA?t=02h42m03s)

[not services](https://youtu.be/HyJJX6FFdpA?t=02h42m05s)

[dot and that should get us back onto the](https://youtu.be/HyJJX6FFdpA?t=02h42m07s)

[instance uh in question](https://youtu.be/HyJJX6FFdpA?t=02h42m12s)

[without too much of a headache](https://youtu.be/HyJJX6FFdpA?t=02h42m15s)

[And we name the same thing request for](https://youtu.be/HyJJX6FFdpA?t=02h42m18s)

[what it was before Then all we have to](https://youtu.be/HyJJX6FFdpA?t=02h42m20s)

[do down here is return reply](https://youtu.be/HyJJX6FFdpA?t=02h42m23s)

[And I think](https://youtu.be/HyJJX6FFdpA?t=02h42m26s)

[that solves it](https://youtu.be/HyJJX6FFdpA?t=02h42m29s)

[Right So if we run this](https://youtu.be/HyJJX6FFdpA?t=02h42m34s)

[please work](https://youtu.be/HyJJX6FFdpA?t=02h42m38s)

[Would make me very happy to see a green](https://youtu.be/HyJJX6FFdpA?t=02h42m41s)

[check mark right here](https://youtu.be/HyJJX6FFdpA?t=02h42m42s)

[Of](https://youtu.be/HyJJX6FFdpA?t=02h42m45s)

[course not Let's see Uh](https://youtu.be/HyJJX6FFdpA?t=02h42m47s)

[that did not work](https://youtu.be/HyJJX6FFdpA?t=02h42m50s)

[So the question becomes why](https://youtu.be/HyJJX6FFdpA?t=02h42m54s)

[still have the await there](https://youtu.be/HyJJX6FFdpA?t=02h43m02s)

[Um move unnecessary parenthesis That's](https://youtu.be/HyJJX6FFdpA?t=02h43m09s)

[fine](https://youtu.be/HyJJX6FFdpA?t=02h43m12s)

[So I'm I'm curious to look at these](https://youtu.be/HyJJX6FFdpA?t=02h43m24s)

[calls to see where the timing of this is](https://youtu.be/HyJJX6FFdpA?t=02h43m28s)

[falling apart](https://youtu.be/HyJJX6FFdpA?t=02h43m32s)

[Why Why do you hate me so much](https://youtu.be/HyJJX6FFdpA?t=02h43m36s)

[Okay so it gets all the things does the](https://youtu.be/HyJJX6FFdpA?t=02h43m45s)

[needful it's going to invoke the method](https://youtu.be/HyJJX6FFdpA?t=02h43m47s)

[before it hits any asynchronous](https://youtu.be/HyJJX6FFdpA?t=02h43m50s)

[garbage right So it does that hits the](https://youtu.be/HyJJX6FFdpA?t=02h43m53s)

[thing sets the culture We are in](https://youtu.be/HyJJX6FFdpA?t=02h43m56s)

[Dutch or whatever DK is Um we come in](https://youtu.be/HyJJX6FFdpA?t=02h44m00s)

[here we get our value type assembly](https://youtu.be/HyJJX6FFdpA?t=02h44m04s)

[qualified name blah blah blah Everyone's](https://youtu.be/HyJJX6FFdpA?t=02h44m06s)

[happy Everyone's happy Everyone's happy](https://youtu.be/HyJJX6FFdpA?t=02h44m08s)

[Get out here We get out here We return a](https://youtu.be/HyJJX6FFdpA?t=02h44m13s)

[reply](https://youtu.be/HyJJX6FFdpA?t=02h44m15s)

[Reply should be fully populated](https://youtu.be/HyJJX6FFdpA?t=02h44m18s)

[An empty string but that's okay I think](https://youtu.be/HyJJX6FFdpA?t=02h44m22s)

[that's what's expected here Yeah because](https://youtu.be/HyJJX6FFdpA?t=02h44m25s)

[it's a void returning method So empty](https://youtu.be/HyJJX6FFdpA?t=02h44m28s)

[string](https://youtu.be/HyJJX6FFdpA?t=02h44m30s)

[is the expected reply Step out We step](https://youtu.be/HyJJX6FFdpA?t=02h44m32s)

[out We've got an object right It's got a](https://youtu.be/HyJJX6FFdpA?t=02h44m35s)

[void empty value](https://youtu.be/HyJJX6FFdpA?t=02h44m38s)

[That all makes sense Great Great](https://youtu.be/HyJJX6FFdpA?t=02h44m44s)

[Send it](https://youtu.be/HyJJX6FFdpA?t=02h44m48s)

[We come back in](https://youtu.be/HyJJX6FFdpA?t=02h44m50s)

[I guess we've lost a bit of our](https://youtu.be/HyJJX6FFdpA?t=02h44m53s)

[debug code that we had in there But we](https://youtu.be/HyJJX6FFdpA?t=02h44m57s)

[come back in We come back through here](https://youtu.be/HyJJX6FFdpA?t=02h44m59s)

[We come in here We jump in Our current](https://youtu.be/HyJJX6FFdpA?t=02h45m02s)

[culture is flipped back What the heck](https://youtu.be/HyJJX6FFdpA?t=02h45m07s)

[Didn't we just see this work](https://youtu.be/HyJJX6FFdpA?t=02h45m10s)

[I wonder if it was working because of](https://youtu.be/HyJJX6FFdpA?t=02h45m17s)

[the I bet you it was working because of](https://youtu.be/HyJJX6FFdpA?t=02h45m19s)

[the assignments that we had previously](https://youtu.be/HyJJX6FFdpA?t=02h45m21s)

[with the ugly garbage code](https://youtu.be/HyJJX6FFdpA?t=02h45m24s)

[That is so stupid](https://youtu.be/HyJJX6FFdpA?t=02h45m34s)

[Okay Well I think what I'm going to do](https://youtu.be/HyJJX6FFdpA?t=02h45m36s)

[is I'm going to undo this and put it](https://youtu.be/HyJJX6FFdpA?t=02h45m38s)

[back the way it was for the moment](https://youtu.be/HyJJX6FFdpA?t=02h45m40s)

[The ugly ugly piece of garbage code](https://youtu.be/HyJJX6FFdpA?t=02h45m43s)

[Because I think this is only working](https://youtu.be/HyJJX6FFdpA?t=02h45m49s)

[because of the reassignment down below](https://youtu.be/HyJJX6FFdpA?t=02h45m52s)

[which means the stat Okay that actually](https://youtu.be/HyJJX6FFdpA?t=02h45m56s)

[makes me feel mildly better because it](https://youtu.be/HyJJX6FFdpA?t=02h45m58s)

[means the static lambda versus not](https://youtu.be/HyJJX6FFdpA?t=02h46m01s)

[doesn't make any difference](https://youtu.be/HyJJX6FFdpA?t=02h46m03s)

[But this reads the right value](https://youtu.be/HyJJX6FFdpA?t=02h46m08s)

[Oh but it reads the right value because](https://youtu.be/HyJJX6FFdpA?t=02h46m11s)

[it was assigned here Right If I turn](https://youtu.be/HyJJX6FFdpA?t=02h46m12s)

[this off](https://youtu.be/HyJJX6FFdpA?t=02h46m15s)

[if I don't reassign back inside of a](https://youtu.be/HyJJX6FFdpA?t=02h46m18s)

[synchronous delegate the asynchronous](https://youtu.be/HyJJX6FFdpA?t=02h46m20s)

[delegate won't see it](https://youtu.be/HyJJX6FFdpA?t=02h46m22s)

[I believe So my assertion here then is](https://youtu.be/HyJJX6FFdpA?t=02h46m25s)

[this test will fail because we aren't](https://youtu.be/HyJJX6FFdpA?t=02h46m30s)

[reassigning it back And if I uncomment](https://youtu.be/HyJJX6FFdpA?t=02h46m33s)

[that code the reassigning it back will](https://youtu.be/HyJJX6FFdpA?t=02h46m35s)

[work This is so freaking ugly So it](https://youtu.be/HyJJX6FFdpA?t=02h46m38s)

[should be US right now](https://youtu.be/HyJJX6FFdpA?t=02h46m43s)

[right Great great great English US](https://youtu.be/HyJJX6FFdpA?t=02h46m46s)

[Everyone's happy There we go We change](https://youtu.be/HyJJX6FFdpA?t=02h46m49s)

[color or culture Come in here and it](https://youtu.be/HyJJX6FFdpA?t=02h46m51s)

[should be English US](https://youtu.be/HyJJX6FFdpA?t=02h46m55s)

[this US Yeah So it's only it's only](https://youtu.be/HyJJX6FFdpA?t=02h46m57s)

[working on the other ones because of the](https://youtu.be/HyJJX6FFdpA?t=02h47m01s)

[assignment When you do the assignment](https://youtu.be/HyJJX6FFdpA?t=02h47m04s)

[inside of an asynchronous lambda](https://youtu.be/HyJJX6FFdpA?t=02h47m06s)

[where it is assigning is problematic So](https://youtu.be/HyJJX6FFdpA?t=02h47m13s)

[okay that's what I want to understand](https://youtu.be/HyJJX6FFdpA?t=02h47m17s)

[What is changing here Because we know](https://youtu.be/HyJJX6FFdpA?t=02h47m20s)

[the other one we see it assign](https://youtu.be/HyJJX6FFdpA?t=02h47m23s)

[the asynchronous local What is it](https://youtu.be/HyJJX6FFdpA?t=02h47m27s)

[assigned differently here that makes it](https://youtu.be/HyJJX6FFdpA?t=02h47m29s)

[magically work](https://youtu.be/HyJJX6FFdpA?t=02h47m32s)

[It must be assigning a different](https://youtu.be/HyJJX6FFdpA?t=02h47m34s)

[field value](https://youtu.be/HyJJX6FFdpA?t=02h47m38s)

[or a different async local value I guess](https://youtu.be/HyJJX6FFdpA?t=02h47m43s)

[Okay So he does the thing does the thing](https://youtu.be/HyJJX6FFdpA?t=02h47m47s)

[sets the thing So right so the S current](https://youtu.be/HyJJX6FFdpA?t=02h47m52s)

[thread culture it's changed Now if we](https://youtu.be/HyJJX6FFdpA?t=02h47m54s)

[look here](https://youtu.be/HyJJX6FFdpA?t=02h47m57s)

[and](https://youtu.be/HyJJX6FFdpA?t=02h48m01s)

[I guess I really want to look at culture](https://youtu.be/HyJJX6FFdpA?t=02h48m02s)

[info](https://youtu.be/HyJJX6FFdpA?t=02h48m04s)

[Uh but this will work We can get there](https://youtu.be/HyJJX6FFdpA?t=02h48m06s)

[from here right And so we come down here](https://youtu.be/HyJJX6FFdpA?t=02h48m08s)

[static members nonpublic](https://youtu.be/HyJJX6FFdpA?t=02h48m12s)

[This one doesn't have](https://youtu.be/HyJJX6FFdpA?t=02h48m20s)

[thread UI culture is set](https://youtu.be/HyJJX6FFdpA?t=02h48m27s)

[Interesting](https://youtu.be/HyJJX6FFdpA?t=02h48m33s)

[So now when I do the assignment right if](https://youtu.be/HyJJX6FFdpA?t=02h48m35s)

[I go here and look at this and I come](https://youtu.be/HyJJX6FFdpA?t=02h48m37s)

[here and look at static members and I](https://youtu.be/HyJJX6FFdpA?t=02h48m40s)

[look at non-public members and I scroll](https://youtu.be/HyJJX6FFdpA?t=02h48m42s)

[down](https://youtu.be/HyJJX6FFdpA?t=02h48m45s)

[where has it actually assigned it](https://youtu.be/HyJJX6FFdpA?t=02h48m47s)

[S current thread culture is now assigned](https://youtu.be/HyJJX6FFdpA?t=02h48m50s)

[But what assigned s current thread](https://youtu.be/HyJJX6FFdpA?t=02h48m57s)

[culture](https://youtu.be/HyJJX6FFdpA?t=02h49m00s)

[This one got assigned instead](https://youtu.be/HyJJX6FFdpA?t=02h49m04s)

[Oh no](https://youtu.be/HyJJX6FFdpA?t=02h49m13s)

[that's the difference](https://youtu.be/HyJJX6FFdpA?t=02h49m17s)

[Oh nobody's going to see that](https://youtu.be/HyJJX6FFdpA?t=02h49m20s)

[Oh that is so brutal](https://youtu.be/HyJJX6FFdpA?t=02h49m28s)

[That is so brutal Okay so here's what's](https://youtu.be/HyJJX6FFdpA?t=02h49m32s)

[going on](https://youtu.be/HyJJX6FFdpA?t=02h49m35s)

[Async local the class has a value](https://youtu.be/HyJJX6FFdpA?t=02h49m38s)

[changed callback that you can register](https://youtu.be/HyJJX6FFdpA?t=02h49m42s)

[Culture info is re and this is the link](https://youtu.be/HyJJX6FFdpA?t=02h49m46s)

[why we don't see the the tieback to the](https://youtu.be/HyJJX6FFdpA?t=02h49m49s)

[value here When the async local value](https://youtu.be/HyJJX6FFdpA?t=02h49m52s)

[changes this call back method is invoked](https://youtu.be/HyJJX6FFdpA?t=02h49m56s)

[This callback method is a static](https://youtu.be/HyJJX6FFdpA?t=02h49m59s)

[function that is simply assigning to a](https://youtu.be/HyJJX6FFdpA?t=02h50m02s)

[static field It is assigning to a static](https://youtu.be/HyJJX6FFdpA?t=02h50m04s)

[field that is declared thread static](https://youtu.be/HyJJX6FFdpA?t=02h50m07s)

[meaning a separate instance per thread](https://youtu.be/HyJJX6FFdpA?t=02h50m11s)

[So by doing this thing in an async](https://youtu.be/HyJJX6FFdpA?t=02h50m16s)

[lambda we are ending up with a different](https://youtu.be/HyJJX6FFdpA?t=02h50m19s)

[thread static variable](https://youtu.be/HyJJX6FFdpA?t=02h50m22s)

[and the other one doesn't get assigned](https://youtu.be/HyJJX6FFdpA?t=02h50m27s)

[That is bloody brutal](https://youtu.be/HyJJX6FFdpA?t=02h50m34s)

[That is absolutely bloody brutal](https://youtu.be/HyJJX6FFdpA?t=02h50m40s)

[Okay Well Nikolai if you're watching](https://youtu.be/HyJJX6FFdpA?t=02h50m43s)

[this was a](https://youtu.be/HyJJX6FFdpA?t=02h50m46s)

[beating to take](https://youtu.be/HyJJX6FFdpA?t=02h50m48s)

[Um but we're going to leave this in](https://youtu.be/HyJJX6FFdpA?t=02h50m52s)

[place And I I think what I would like to](https://youtu.be/HyJJX6FFdpA?t=02h50m54s)

[do so we we're going to get rid of some](https://youtu.be/HyJJX6FFdpA?t=02h50m56s)

[of this debugging code](https://youtu.be/HyJJX6FFdpA?t=02h50m59s)

[Um](https://youtu.be/HyJJX6FFdpA?t=02h51m01s)

[and I don't think we need to assign](https://youtu.be/HyJJX6FFdpA?t=02h51m03s)

[current We'll we'll bring this test back](https://youtu.be/HyJJX6FFdpA?t=02h51m06s)

[down to its simplistic state Right So](https://youtu.be/HyJJX6FFdpA?t=02h51m07s)

[this should now go green I have that](https://youtu.be/HyJJX6FFdpA?t=02h51m10s)

[threading copying the culture around](https://youtu.be/HyJJX6FFdpA?t=02h51m13s)

[garbage](https://youtu.be/HyJJX6FFdpA?t=02h51m16s)

[There we go That goes great What I would](https://youtu.be/HyJJX6FFdpA?t=02h51m20s)

[like to add in here as well though is a](https://youtu.be/HyJJX6FFdpA?t=02h51m23s)

[couple test for asynchronous](https://youtu.be/HyJJX6FFdpA?t=02h51m26s)

[uh with](https://youtu.be/HyJJX6FFdpA?t=02h51m29s)

[async](https://youtu.be/HyJJX6FFdpA?t=02h51m31s)

[callback](https://youtu.be/HyJJX6FFdpA?t=02h51m34s)

[uh can execute delegate](https://youtu.be/HyJJX6FFdpA?t=02h51m35s)

[uh task And we're going to come in here](https://youtu.be/HyJJX6FFdpA?t=02h51m38s)

[and go await task delay a one](https://youtu.be/HyJJX6FFdpA?t=02h51m41s)

[something small but yet quick](https://youtu.be/HyJJX6FFdpA?t=02h51m47s)

[Uh let's see here](https://youtu.be/HyJJX6FFdpA?t=02h51m50s)

[This guy should](https://youtu.be/HyJJX6FFdpA?t=02h51m55s)

[guess I I need to learn how to spell the](https://youtu.be/HyJJX6FFdpA?t=02h52m00s)

[word with again Um why are you not](https://youtu.be/HyJJX6FFdpA?t=02h52m01s)

[landing on the other overload](https://youtu.be/HyJJX6FFdpA?t=02h52m05s)

[Oh because this is a separate set of](https://youtu.be/HyJJX6FFdpA?t=02h52m14s)

[extensions](https://youtu.be/HyJJX6FFdpA?t=02h52m18s)

[isn't it Yes Yes Yes](https://youtu.be/HyJJX6FFdpA?t=02h52m20s)

[Um](https://youtu.be/HyJJX6FFdpA?t=02h52m25s)

[there is a different set of](https://youtu.be/HyJJX6FFdpA?t=02h52m28s)

[remote execute methods These ones here](https://youtu.be/HyJJX6FFdpA?t=02h52m33s)

[we need to duplicate as well](https://youtu.be/HyJJX6FFdpA?t=02h52m37s)

[Um and let's see](https://youtu.be/HyJJX6FFdpA?t=02h52m40s)

[I would like to create this one](https://youtu.be/HyJJX6FFdpA?t=02h52m43s)

[And I would like it to be here And the](https://youtu.be/HyJJX6FFdpA?t=02h52m49s)

[signature of this guy is actually going](https://youtu.be/HyJJX6FFdpA?t=02h52m52s)

[to be](https://youtu.be/HyJJX6FFdpA?t=02h52m55s)

[funk](https://youtu.be/HyJJX6FFdpA?t=02h52m57s)

[of T](https://youtu.be/HyJJX6FFdpA?t=02h52m59s)

[Oh no Funk](https://youtu.be/HyJJX6FFdpA?t=02h53m01s)

[ass](https://youtu.be/HyJJX6FFdpA?t=02h53m03s)

[right Because before this was action](https://youtu.be/HyJJX6FFdpA?t=02h53m06s)

[No co-pilot](https://youtu.be/HyJJX6FFdpA?t=02h53m12s)

[reject solution Um](https://youtu.be/HyJJX6FFdpA?t=02h53m14s)

[here you want to do something useful](https://youtu.be/HyJJX6FFdpA?t=02h53m20s)

[co-pilot](https://youtu.be/HyJJX6FFdpA?t=02h53m21s)

[No that's not what No stop helping A](https://youtu.be/HyJJX6FFdpA?t=02h53m24s)

[part of shut up and just listen for the](https://youtu.be/HyJJX6FFdpA?t=02h53m28s)

[directions Uh create overloads for this](https://youtu.be/HyJJX6FFdpA?t=02h53m30s)

[method that go out to T8](https://youtu.be/HyJJX6FFdpA?t=02h53m36s)

[I think this is what I want I think this](https://youtu.be/HyJJX6FFdpA?t=02h53m44s)

[is what I want](https://youtu.be/HyJJX6FFdpA?t=02h53m47s)

[Come on](https://youtu.be/HyJJX6FFdpA?t=02h53m52s)

[Okay Did you delete the original one You](https://youtu.be/HyJJX6FFdpA?t=02h53m57s)

[did You did Why](https://youtu.be/HyJJX6FFdpA?t=02h54m00s)

[can you not co-pilot](https://youtu.be/HyJJX6FFdpA?t=02h54m03s)

[Like](https://youtu.be/HyJJX6FFdpA?t=02h54m07s)

[is there a reason you hate me so much](https://youtu.be/HyJJX6FFdpA?t=02h54m09s)

[that you would](https://youtu.be/HyJJX6FFdpA?t=02h54m11s)

[like I appreciate you doing this but I'd](https://youtu.be/HyJJX6FFdpA?t=02h54m15s)

[really appreciate you not screwing it up](https://youtu.be/HyJJX6FFdpA?t=02h54m18s)

[too Um that that that'd be great](https://youtu.be/HyJJX6FFdpA?t=02h54m20s)

[Uh let's see here And then I need](https://youtu.be/HyJJX6FFdpA?t=02h54m27s)

[overloads](https://youtu.be/HyJJX6FFdpA?t=02h54m30s)

[So that should handle the first case](https://youtu.be/HyJJX6FFdpA?t=02h54m32s)

[right Right So this should now land on](https://youtu.be/HyJJX6FFdpA?t=02h54m36s)

[app remote execute because this is](https://youtu.be/HyJJX6FFdpA?t=02h54m43s)

[uh task with one parameter](https://youtu.be/HyJJX6FFdpA?t=02h54m48s)

[Oh is that is that correct](https://youtu.be/HyJJX6FFdpA?t=02h54m54s)

[Yes](https://youtu.be/HyJJX6FFdpA?t=02h54m58s)

[Funk of](https://youtu.be/HyJJX6FFdpA?t=02h55m01s)

[action So it should be landing on this](https://youtu.be/HyJJX6FFdpA?t=02h55m04s)

[one](https://youtu.be/HyJJX6FFdpA?t=02h55m06s)

[because T1](https://youtu.be/HyJJX6FFdpA?t=02h55m09s)

[Oh it's because I didn't clear this](https://youtu.be/HyJJX6FFdpA?t=02h55m16s)

[I dropped](https://youtu.be/HyJJX6FFdpA?t=02h55m22s)

[What did I do How did I get rid of](https://youtu.be/HyJJX6FFdpA?t=02h55m28s)

[I deleted it out of the funk but didn't](https://youtu.be/HyJJX6FFdpA?t=02h55m32s)

[functionally get rid of it anywhere else](https://youtu.be/HyJJX6FFdpA?t=02h55m34s)

[which is a problem Okay now it should](https://youtu.be/HyJJX6FFdpA?t=02h55m37s)

[resolve](https://youtu.be/HyJJX6FFdpA?t=02h55m39s)

[Go pilot Seriously stop it](https://youtu.be/HyJJX6FFdpA?t=02h55m43s)

[You are not being helpful at the moment](https://youtu.be/HyJJX6FFdpA?t=02h55m46s)

[Uh still not landing on the right](https://youtu.be/HyJJX6FFdpA?t=02h55m50s)

[overload and you are being annoying Um](https://youtu.be/HyJJX6FFdpA?t=02h55m53s)

[so wait a minute What is the T here then](https://youtu.be/HyJJX6FFdpA?t=02h56m00s)

[We don't need a T](https://youtu.be/HyJJX6FFdpA?t=02h56m06s)

[Why do we have a T on these other ones](https://youtu.be/HyJJX6FFdpA?t=02h56m17s)

[Is this just been a mistake](https://youtu.be/HyJJX6FFdpA?t=02h56m24s)

[I think this is was a mistake](https://youtu.be/HyJJX6FFdpA?t=02h56m27s)

[We aren't leveraging T anywhere](https://youtu.be/HyJJX6FFdpA?t=02h56m30s)

[We are not leveraging T anywhere](https://youtu.be/HyJJX6FFdpA?t=02h56m38s)

[This should now be the overload that it](https://youtu.be/HyJJX6FFdpA?t=02h56m44s)

[lands on](https://youtu.be/HyJJX6FFdpA?t=02h56m46s)

[Right](https://youtu.be/HyJJX6FFdpA?t=02h56m51s)

[Does this guy should be t No the T1 is](https://youtu.be/HyJJX6FFdpA?t=02h56m56s)

[the one that it should be landing on](https://youtu.be/HyJJX6FFdpA?t=02h56m59s)

[It should have bunk of T1 task](https://youtu.be/HyJJX6FFdpA?t=02h57m04s)

[bunk T1 T1 is application](https://youtu.be/HyJJX6FFdpA?t=02h57m10s)

[task returning delegate](https://youtu.be/HyJJX6FFdpA?t=02h57m16s)

[What am I missing](https://youtu.be/HyJJX6FFdpA?t=02h57m23s)

[remote execute](https://youtu.be/HyJJX6FFdpA?t=02h57m28s)

[Oh because it's expecting a Oh I've](https://youtu.be/HyJJX6FFdpA?t=02h57m32s)

[modified this incorrectly](https://youtu.be/HyJJX6FFdpA?t=02h57m34s)

[T1 is the Okay so hold on I need to go](https://youtu.be/HyJJX6FFdpA?t=02h57m37s)

[back](https://youtu.be/HyJJX6FFdpA?t=02h57m41s)

[I do need the T It's just not obvious](https://youtu.be/HyJJX6FFdpA?t=02h57m44s)

[why](https://youtu.be/HyJJX6FFdpA?t=02h57m47s)

[Well hold on](https://youtu.be/HyJJX6FFdpA?t=02h57m52s)

[Okay this is](https://youtu.be/HyJJX6FFdpA?t=02h57m55s)

[this is where my head starts to spin for](https://youtu.be/HyJJX6FFdpA?t=02h57m57s)

[a moment while I process through my](https://youtu.be/HyJJX6FFdpA?t=02h57m59s)

[generics because when we do it at the](https://youtu.be/HyJJX6FFdpA?t=02h58m01s)

[application level](https://youtu.be/HyJJX6FFdpA?t=02h58m03s)

[we need to specify](https://youtu.be/HyJJX6FFdpA?t=02h58m05s)

[app](https://youtu.be/HyJJX6FFdpA?t=02h58m08s)

[And the first T parameter in our](https://youtu.be/HyJJX6FFdpA?t=02h58m13s)

[delegate isn't one that gets passed in](https://youtu.be/HyJJX6FFdpA?t=02h58m15s)

[from the caller It's one that gets](https://youtu.be/HyJJX6FFdpA?t=02h58m19s)

[specified by the remote running process](https://youtu.be/HyJJX6FFdpA?t=02h58m22s)

[So okay co-pilot come here I need you to](https://youtu.be/HyJJX6FFdpA?t=02h58m26s)

[I need you to think for me for a second](https://youtu.be/HyJJX6FFdpA?t=02h58m30s)

[because my brain is is hurting So we do](https://youtu.be/HyJJX6FFdpA?t=02h58m32s)

[need this change discard](https://youtu.be/HyJJX6FFdpA?t=02h58m35s)

[But what we Yeah Yes to all Thanks](https://youtu.be/HyJJX6FFdpA?t=02h58m41s)

[Um we do need this one because the T in](https://youtu.be/HyJJX6FFdpA?t=02h58m45s)

[this case is going to be application and](https://youtu.be/HyJJX6FFdpA?t=02h58m48s)

[T result is going to go through here](https://youtu.be/HyJJX6FFdpA?t=02h58m49s)

[Down here](https://youtu.be/HyJJX6FFdpA?t=02h58m52s)

[we do need a T](https://youtu.be/HyJJX6FFdpA?t=02h58m54s)

[And this is going to be um](https://youtu.be/HyJJX6FFdpA?t=02h58m59s)

[Task](https://youtu.be/HyJJX6FFdpA?t=02h59m04s)

[This is going to be T](https://youtu.be/HyJJX6FFdpA?t=02h59m09s)

[This is going to be t](https://youtu.be/HyJJX6FFdpA?t=02h59m14s)

[because pram is the value that gets](https://youtu.be/HyJJX6FFdpA?t=02h59m18s)

[passed from the test side T is the value](https://youtu.be/HyJJX6FFdpA?t=02h59m20s)

[that comes in from the app side](https://youtu.be/HyJJX6FFdpA?t=02h59m24s)

[and builds that up](https://youtu.be/HyJJX6FFdpA?t=02h59m27s)

[and now it resolves properly](https://youtu.be/HyJJX6FFdpA?t=02h59m32s)

[Um](https://youtu.be/HyJJX6FFdpA?t=02h59m37s)

[let's go Async task here](https://youtu.be/HyJJX6FFdpA?t=02h59m40s)

[Await task delay We're just going to](https://youtu.be/HyJJX6FFdpA?t=02h59m44s)

[make our life as miserable as possible](https://youtu.be/HyJJX6FFdpA?t=02h59m46s)

[with this test](https://youtu.be/HyJJX6FFdpA?t=02h59m48s)

[Now that I know how painful culture is](https://youtu.be/HyJJX6FFdpA?t=02h59m56s)

[to work with on a thread](https://youtu.be/HyJJX6FFdpA?t=02h59m57s)

[Um](https://youtu.be/HyJJX6FFdpA?t=03h00m07s)

[think I can get away with this now Can't](https://youtu.be/HyJJX6FFdpA?t=03h00m14s)

[I](https://youtu.be/HyJJX6FFdpA?t=03h00m16s)

[Think I can I think I can I think I can](https://youtu.be/HyJJX6FFdpA?t=03h00m19s)

[Boy there's something about that](https://youtu.be/HyJJX6FFdpA?t=03h00m24s)

[asynchronous context that still isn't](https://youtu.be/HyJJX6FFdpA?t=03h00m28s)

[sitting right](https://youtu.be/HyJJX6FFdpA?t=03h00m30s)

[on remote execute](https://youtu.be/HyJJX6FFdpA?t=03h00m42s)

[What is it failing on](https://youtu.be/HyJJX6FFdpA?t=03h00m50s)

[Oh assert R equals false](https://youtu.be/HyJJX6FFdpA?t=03h00m54s)

[Okay so that doesn't quite play nice](https://youtu.be/HyJJX6FFdpA?t=03h00m57s)

[Um](https://youtu.be/HyJJX6FFdpA?t=03h01m02s)

[how can we write a reasonable thing I](https://youtu.be/HyJJX6FFdpA?t=03h01m08s)

[maybe this is a bad test](https://youtu.be/HyJJX6FFdpA?t=03h01m10s)

[Maybe this is a bad test because you](https://youtu.be/HyJJX6FFdpA?t=03h01m13s)

[should never be doing the culture stuff](https://youtu.be/HyJJX6FFdpA?t=03h01m15s)

[in something else](https://youtu.be/HyJJX6FFdpA?t=03h01m17s)

[And I think this might be good enough](https://youtu.be/HyJJX6FFdpA?t=03h01m20s)

[for now](https://youtu.be/HyJJX6FFdpA?t=03h01m22s)

[Um](https://youtu.be/HyJJX6FFdpA?t=03h01m24s)

[yeah let's just add in the extra](https://youtu.be/HyJJX6FFdpA?t=03h01m28s)

[overloads on the app mixins and push it](https://youtu.be/HyJJX6FFdpA?t=03h01m29s)

[and call it a day](https://youtu.be/HyJJX6FFdpA?t=03h01m32s)

[Call it a day So](https://youtu.be/HyJJX6FFdpA?t=03h01m34s)

[um](https://youtu.be/HyJJX6FFdpA?t=03h01m38s)

[see so on the remote execute t result I](https://youtu.be/HyJJX6FFdpA?t=03h01m41s)

[want to do something similar to this](https://youtu.be/HyJJX6FFdpA?t=03h01m45s)

[but I want it to be here and I want it](https://youtu.be/HyJJX6FFdpA?t=03h01m49s)

[to be](https://youtu.be/HyJJX6FFdpA?t=03h01m53s)

[uh task of t result](https://youtu.be/HyJJX6FFdpA?t=03h01m56s)

[right and so I want that built and](https://youtu.be/HyJJX6FFdpA?t=03h02m02s)

[co-pilot](https://youtu.be/HyJJX6FFdpA?t=03h02m04s)

[generate overloads for this method out](https://youtu.be/HyJJX6FFdpA?t=03h02m07s)

[to T8](https://youtu.be/HyJJX6FFdpA?t=03h02m12s)

[Preserve this method because I'm getting](https://youtu.be/HyJJX6FFdpA?t=03h02m14s)

[annoyed at having to rewrite it every](https://youtu.be/HyJJX6FFdpA?t=03h02m17s)

[time](https://youtu.be/HyJJX6FFdpA?t=03h02m19s)

[So if you could just do that copilot](https://youtu.be/HyJJX6FFdpA?t=03h02m21s)

[that'd be great](https://youtu.be/HyJJX6FFdpA?t=03h02m23s)

[Come on](https://youtu.be/HyJJX6FFdpA?t=03h02m26s)

[There we go Did you Did you do the one](https://youtu.be/HyJJX6FFdpA?t=03h02m39s)

[thing I asked you to do No of course not](https://youtu.be/HyJJX6FFdpA?t=03h02m42s)

[I asked you to preserve the function Did](https://youtu.be/HyJJX6FFdpA?t=03h02m46s)

[you preserve it No you did not You](https://youtu.be/HyJJX6FFdpA?t=03h02m48s)

[deleted it and overwrote it Now I](https://youtu.be/HyJJX6FFdpA?t=03h02m51s)

[believe it's probably because I had it](https://youtu.be/HyJJX6FFdpA?t=03h02m53s)

[selected and you were too dumb to](https://youtu.be/HyJJX6FFdpA?t=03h02m55s)

[realize that that means you shouldn't](https://youtu.be/HyJJX6FFdpA?t=03h02m57s)

[overwrite it But you know what](https://youtu.be/HyJJX6FFdpA?t=03h02m58s)

[Still annoys me](https://youtu.be/HyJJX6FFdpA?t=03h03m02s)

[Still annoys me](https://youtu.be/HyJJX6FFdpA?t=03h03m05s)

[Okay that gets me there That gets me](https://youtu.be/HyJJX6FFdpA?t=03h03m10s)

[there There are the overloads](https://youtu.be/HyJJX6FFdpA?t=03h03m12s)

[Uh yeah go ahead Summarize that change](https://youtu.be/HyJJX6FFdpA?t=03h03m17s)

[for me co-pilot](https://youtu.be/HyJJX6FFdpA?t=03h03m20s)

[Hey yeah that is that is the](https://youtu.be/HyJJX6FFdpA?t=03h03m25s)

[understatement of the year Okay we're](https://youtu.be/HyJJX6FFdpA?t=03h03m26s)

[going to push that We're going to run it](https://youtu.be/HyJJX6FFdpA?t=03h03m29s)

[Hopefully this merges](https://youtu.be/HyJJX6FFdpA?t=03h03m32s)

[I](https://youtu.be/HyJJX6FFdpA?t=03h03m35s)

[hope to be able to get this done soon](https://youtu.be/HyJJX6FFdpA?t=03h03m37s)

[but it feels like every time I feel like](https://youtu.be/HyJJX6FFdpA?t=03h03m39s)

[I'm getting close I'm just a little bit](https://youtu.be/HyJJX6FFdpA?t=03h03m41s)

[further away So this is going to](https://youtu.be/HyJJX6FFdpA?t=03h03m43s)

[continue to be an adventure for us Um on](https://youtu.be/HyJJX6FFdpA?t=03h03m44s)

[the note of the](https://youtu.be/HyJJX6FFdpA?t=03h03m47s)

[tab control PR I think I'm going to hold](https://youtu.be/HyJJX6FFdpA?t=03h03m50s)

[for a bit because I want to take a stab](https://youtu.be/HyJJX6FFdpA?t=03h03m52s)

[at trying to do it with an items panel](https://youtu.be/HyJJX6FFdpA?t=03h03m54s)

[instead of just a fixed enume because I](https://youtu.be/HyJJX6FFdpA?t=03h03m58s)

[I have a the suspicion that as soon as](https://youtu.be/HyJJX6FFdpA?t=03h04m00s)

[we expose something like that it's going](https://youtu.be/HyJJX6FFdpA?t=03h04m02s)

[to become an API that's difficult to](https://youtu.be/HyJJX6FFdpA?t=03h04m04s)

[manage and I'd much rather give a more](https://youtu.be/HyJJX6FFdpA?t=03h04m06s)

[generalized one in there So we'll see](https://youtu.be/HyJJX6FFdpA?t=03h04m08s)

[how it lands Um as always thank you](https://youtu.be/HyJJX6FFdpA?t=03h04m10s)

[everyone for coming and hanging out JC](https://youtu.be/HyJJX6FFdpA?t=03h04m13s)

[your eagle eye is always appreciated Uh](https://youtu.be/HyJJX6FFdpA?t=03h04m15s)

[with that it is late Bid everybody good](https://youtu.be/HyJJX6FFdpA?t=03h04m18s)

[night or good morning depending on where](https://youtu.be/HyJJX6FFdpA?t=03h04m21s)

[you are located and I will see everyone](https://youtu.be/HyJJX6FFdpA?t=03h04m23s)

[next time Happy coding](https://youtu.be/HyJJX6FFdpA?t=03h04m25s)

