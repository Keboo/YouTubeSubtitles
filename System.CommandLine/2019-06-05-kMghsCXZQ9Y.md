[YouTube Video](https://youtu.be/kMghsCXZQ9Y)


[okay](https://youtu.be/kMghsCXZQ9Y?t=00h06m26s)



[it looks like we are just about at](https://youtu.be/kMghsCXZQ9Y?t=00h06m27s)



[starting time so today we are going to](https://youtu.be/kMghsCXZQ9Y?t=00h06m30s)



[be going through and looking at the](https://youtu.be/kMghsCXZQ9Y?t=00h06m34s)



[system command line library](https://youtu.be/kMghsCXZQ9Y?t=00h06m36s)



[we've got John once again who has been](https://youtu.be/kMghsCXZQ9Y?t=00h06m38s)



[one of the I'll say principal devs on](https://youtu.be/kMghsCXZQ9Y?t=00h06m42s)



[the project building this out we're](https://youtu.be/kMghsCXZQ9Y?t=00h06m45s)



[going to be looking at the sort of a](https://youtu.be/kMghsCXZQ9Y?t=00h06m48s)



[dependent nougat package that's part of](https://youtu.be/kMghsCXZQ9Y?t=00h06m52s)



[the same repository called system](https://youtu.be/kMghsCXZQ9Y?t=00h06m54s)



[command line dot rendering it's sort of](https://youtu.be/kMghsCXZQ9Y?t=00h06m57s)



[designed to go through and make](https://youtu.be/kMghsCXZQ9Y?t=00h07m01s)



[outputting your CLI apps much easier so](https://youtu.be/kMghsCXZQ9Y?t=00h07m04s)



[things like if you want to do some fancy](https://youtu.be/kMghsCXZQ9Y?t=00h07m08s)



[layout with a grid or have automatic](https://youtu.be/kMghsCXZQ9Y?t=00h07m10s)



[updating similar to what you'd get in a](https://youtu.be/kMghsCXZQ9Y?t=00h07m12s)



[WPF framework with like a binding so](https://youtu.be/kMghsCXZQ9Y?t=00h07m15s)



[that type of functionality only built](https://youtu.be/kMghsCXZQ9Y?t=00h07m17s)



[into the CLI so John I don't know if you](https://youtu.be/kMghsCXZQ9Y?t=00h07m21s)



[want to give a brief introduction to](https://youtu.be/kMghsCXZQ9Y?t=00h07m24s)



[yourself and then we can dive into the](https://youtu.be/kMghsCXZQ9Y?t=00h07m25s)



[library give me just one moment because](https://youtu.be/kMghsCXZQ9Y?t=00h07m30s)



[I do have to unmute you and figure out](https://youtu.be/kMghsCXZQ9Y?t=00h07m32s)



[where the heck your audio source right](https://youtu.be/kMghsCXZQ9Y?t=00h07m33s)



[there you go now you're hot great cool](https://youtu.be/kMghsCXZQ9Y?t=00h07m36s)



[so yeah um I am a developer on the](https://youtu.be/kMghsCXZQ9Y?t=00h07m41s)



[dotnet team I've been working on the](https://youtu.be/kMghsCXZQ9Y?t=00h07m48s)



[system command line thing for a bit over](https://youtu.be/kMghsCXZQ9Y?t=00h07m51s)



[a year and then a little bit farther](https://youtu.be/kMghsCXZQ9Y?t=00h07m52s)



[back it was if this was a new parser for](https://youtu.be/kMghsCXZQ9Y?t=00h07m54s)



[the.net CLI which we kind of at some](https://youtu.be/kMghsCXZQ9Y?t=00h07m56s)



[point to you know it'd be great to have](https://youtu.be/kMghsCXZQ9Y?t=00h08m02s)



[some libraries that people can use for](https://youtu.be/kMghsCXZQ9Y?t=00h08m04s)



[some of these broader ambitions that go](https://youtu.be/kMghsCXZQ9Y?t=00h08m06s)



[beyond parsing yeah and completion Susan](https://youtu.be/kMghsCXZQ9Y?t=00h08m07s)



[an app model that involves sort of an](https://youtu.be/kMghsCXZQ9Y?t=00h08m11s)



[execution pipeline you know these are](https://youtu.be/kMghsCXZQ9Y?t=00h08m14s)



[some of them that we sort of expanded](https://youtu.be/kMghsCXZQ9Y?t=00h08m16s)



[beyond what it's typically available in](https://youtu.be/kMghsCXZQ9Y?t=00h08m18s)



[in a lot of libraries and then the thing](https://youtu.be/kMghsCXZQ9Y?t=00h08m20s)



[that we discovered from there was that](https://youtu.be/kMghsCXZQ9Y?t=00h08m22s)



[rendering output was actually really a](https://youtu.be/kMghsCXZQ9Y?t=00h08m24s)



[place where the older system dock](https://youtu.be/kMghsCXZQ9Y?t=00h08m27s)



[console API is were not really](https://youtu.be/kMghsCXZQ9Y?t=00h08m30s)



[as rich as we might like especially](https://youtu.be/kMghsCXZQ9Y?t=00h08m32s)



[given this the new windows turn all has](https://youtu.be/kMghsCXZQ9Y?t=00h08m35s)



[come out antsy terminals have become you](https://youtu.be/kMghsCXZQ9Y?t=00h08m37s)



[know they've been available on windows](https://youtu.be/kMghsCXZQ9Y?t=00h08m43s)



[for a little while but you have to do](https://youtu.be/kMghsCXZQ9Y?t=00h08m44s)



[something special to enable it so the](https://youtu.be/kMghsCXZQ9Y?t=00h08m45s)



[windows 32 API but you have to use to](https://youtu.be/kMghsCXZQ9Y?t=00h08m47s)



[enable virtual terminal mode so what is](https://youtu.be/kMghsCXZQ9Y?t=00h08m49s)



[an C output give you one of the](https://youtu.be/kMghsCXZQ9Y?t=00h08m51s)



[different kinds of things you can render](https://youtu.be/kMghsCXZQ9Y?t=00h08m53s)



[to the console these are all things that](https://youtu.be/kMghsCXZQ9Y?t=00h08m55s)



[we looked at and said this is really](https://youtu.be/kMghsCXZQ9Y?t=00h08m57s)



[hard for people to do well and maybe we](https://youtu.be/kMghsCXZQ9Y?t=00h08m59s)



[should try and tackle some of that](https://youtu.be/kMghsCXZQ9Y?t=00h09m02s)



[complexity and provide an API for doing](https://youtu.be/kMghsCXZQ9Y?t=00h09m03s)



[it so that's that's the piece that it's](https://youtu.be/kMghsCXZQ9Y?t=00h09m05s)



[a little bit less far along than the](https://youtu.be/kMghsCXZQ9Y?t=00h09m09s)



[core system command line library that](https://youtu.be/kMghsCXZQ9Y?t=00h09m11s)



[offers parsing communication on the](https://youtu.be/kMghsCXZQ9Y?t=00h09m13s)



[model bindings but um we think that](https://youtu.be/kMghsCXZQ9Y?t=00h09m15s)



[there's like a really interesting story](https://youtu.be/kMghsCXZQ9Y?t=00h09m17s)



[here and so yeah at some point somehow](https://youtu.be/kMghsCXZQ9Y?t=00h09m19s)



[convinced Kevin that he should become](https://youtu.be/kMghsCXZQ9Y?t=00h09m25s)



[interested in this thing you can see his](https://youtu.be/kMghsCXZQ9Y?t=00h09m27s)



[name in here even the source code your](https://youtu.be/kMghsCXZQ9Y?t=00h09m31s)



[your cameras what's being shown that](https://youtu.be/kMghsCXZQ9Y?t=00h09m35s)



[your screen but I see so yeah now this](https://youtu.be/kMghsCXZQ9Y?t=00h09m37s)



[has been a collaborative effort but but](https://youtu.be/kMghsCXZQ9Y?t=00h09m43s)



[Kevin you've been particularly involved](https://youtu.be/kMghsCXZQ9Y?t=00h09m45s)



[in in every stage of it it's been open](https://youtu.be/kMghsCXZQ9Y?t=00h09m47s)



[source almost from the beginning this](https://youtu.be/kMghsCXZQ9Y?t=00h09m50s)



[isn't really the whole thing is very](https://youtu.be/kMghsCXZQ9Y?t=00h09m52s)



[community driven is not being driven by](https://youtu.be/kMghsCXZQ9Y?t=00h09m54s)



[I'm Microsoft top-down kind of effort](https://youtu.be/kMghsCXZQ9Y?t=00h10m00s)



[this has really been very grassroots](https://youtu.be/kMghsCXZQ9Y?t=00h10m03s)



[it's been fun - it's been fun to hack on](https://youtu.be/kMghsCXZQ9Y?t=00h10m07s)



[and work on so I'm going to as much as I](https://youtu.be/kMghsCXZQ9Y?t=00h10m10s)



[enjoy looking at your webcam I'm gonna](https://youtu.be/kMghsCXZQ9Y?t=00h10m14s)



[flip you over here to your to your](https://youtu.be/kMghsCXZQ9Y?t=00h10m16s)



[screen](https://youtu.be/kMghsCXZQ9Y?t=00h10m20s)



[okay and we are up we've got our your](https://youtu.be/kMghsCXZQ9Y?t=00h10m23s)



[visual studio and then a terminal on the](https://youtu.be/kMghsCXZQ9Y?t=00h10m27s)



[right hand side the fancy little clock](https://youtu.be/kMghsCXZQ9Y?t=00h10m30s)



[tiny itty bitty fought but fancy little](https://youtu.be/kMghsCXZQ9Y?t=00h10m34s)



[clock it's pretty nasty um you know I](https://youtu.be/kMghsCXZQ9Y?t=00h10m38s)



[don't have the new Windows terminal](https://youtu.be/kMghsCXZQ9Y?t=00h10m41s)



[install this machine or else I could](https://youtu.be/kMghsCXZQ9Y?t=00h10m42s)



[like zoom this thing with the scroll](https://youtu.be/kMghsCXZQ9Y?t=00h10m43s)



[wheel but I can't um we can take a look](https://youtu.be/kMghsCXZQ9Y?t=00h10m46s)



[at it and you do this in Visual Studio](https://youtu.be/kMghsCXZQ9Y?t=00h10m51s)



[code which has a scaleable terminal so](https://youtu.be/kMghsCXZQ9Y?t=00h10m53s)



[in the system command line github repo](https://youtu.be/kMghsCXZQ9Y?t=00h11m01s)



[we have this samples directory and](https://youtu.be/kMghsCXZQ9Y?t=00h11m07s)



[inside the sample of the threads there's](https://youtu.be/kMghsCXZQ9Y?t=00h11m11s)



[a few things here one of them is this](https://youtu.be/kMghsCXZQ9Y?t=00h11m12s)



[rendering playground and that's the](https://youtu.be/kMghsCXZQ9Y?t=00h11m15s)



[thing that I was just showing the clock](https://youtu.be/kMghsCXZQ9Y?t=00h11m19s)



[for so we can show that here - here grab](https://youtu.be/kMghsCXZQ9Y?t=00h11m20s)



[this somewhat cryptic command line](https://youtu.be/kMghsCXZQ9Y?t=00h11m28s)



[oh hey John yeah](https://youtu.be/kMghsCXZQ9Y?t=00h11m43s)



[do you mind shifting your window up just](https://youtu.be/kMghsCXZQ9Y?t=00h11m49s)



[a hair I think the very bottom of where](https://youtu.be/kMghsCXZQ9Y?t=00h11m52s)



[you're typing is getting clipped](https://youtu.be/kMghsCXZQ9Y?t=00h11m55s)



[it's not better that is perfect](https://youtu.be/kMghsCXZQ9Y?t=00h11m58s)



[cool and the fonts a little bit more](https://youtu.be/kMghsCXZQ9Y?t=00h12m01s)



[agreeable font is more agreeable thank](https://youtu.be/kMghsCXZQ9Y?t=00h12m05s)



[you okay so what are we looking one of](https://youtu.be/kMghsCXZQ9Y?t=00h12m08s)



[the there were a couple of things that](https://youtu.be/kMghsCXZQ9Y?t=00h12m20s)



[we saw that were common things people](https://youtu.be/kMghsCXZQ9Y?t=00h12m21s)



[like to do with with Richard console](https://youtu.be/kMghsCXZQ9Y?t=00h12m23s)



[apps which are things like table layouts](https://youtu.be/kMghsCXZQ9Y?t=00h12m25s)



[other kinds of you know multi-column](https://youtu.be/kMghsCXZQ9Y?t=00h12m29s)



[layouts potentially they're different](https://youtu.be/kMghsCXZQ9Y?t=00h12m32s)



[screen regions that kind of show](https://youtu.be/kMghsCXZQ9Y?t=00h12m33s)



[different things and then within that](https://youtu.be/kMghsCXZQ9Y?t=00h12m34s)



[sometimes things that are updating might](https://youtu.be/kMghsCXZQ9Y?t=00h12m37s)



[be progress bars or it might be data](https://youtu.be/kMghsCXZQ9Y?t=00h12m39s)



[that's updating within specific cells](https://youtu.be/kMghsCXZQ9Y?t=00h12m41s)



[and those are and they're great](https://youtu.be/kMghsCXZQ9Y?t=00h12m43s)



[experiences from a console perspective](https://youtu.be/kMghsCXZQ9Y?t=00h12m45s)



[they're pretty hard to write given it](https://youtu.be/kMghsCXZQ9Y?t=00h12m46s)



[you know the standard console api's are](https://youtu.be/kMghsCXZQ9Y?t=00h12m49s)



[just standard in standard error standard](https://youtu.be/kMghsCXZQ9Y?t=00h12m54s)



[out so you know you're just writing text](https://youtu.be/kMghsCXZQ9Y?t=00h12m56s)



[in that text so sister doc console has](https://youtu.be/kMghsCXZQ9Y?t=00h12m59s)



[month so yeah in a normal terminal right](https://youtu.be/kMghsCXZQ9Y?t=00h13m02s)



[you you might have a virtual terminal](https://youtu.be/kMghsCXZQ9Y?t=00h13m05s)



[that's sitting on top of those console](https://youtu.be/kMghsCXZQ9Y?t=00h13m08s)



[screens and is able to render things in](https://youtu.be/kMghsCXZQ9Y?t=00h13m10s)



[a way where you are able to see history](https://youtu.be/kMghsCXZQ9Y?t=00h13m12s)



[right if I go when I'm gonna do the same](https://youtu.be/kMghsCXZQ9Y?t=00h13m14s)



[thing over here just to give you an](https://youtu.be/kMghsCXZQ9Y?t=00h13m20s)



[example if I think of it just as just as](https://youtu.be/kMghsCXZQ9Y?t=00h13m22s)



[a file screen](https://youtu.be/kMghsCXZQ9Y?t=00h13m27s)



[six works](https://youtu.be/kMghsCXZQ9Y?t=00h13m31s)



[yep](https://youtu.be/kMghsCXZQ9Y?t=00h13m46s)



[okay](https://youtu.be/kMghsCXZQ9Y?t=00h14m10s)



[okay perfect I think we got that fix re](https://youtu.be/kMghsCXZQ9Y?t=00h14m41s)



[doing doing this a little bit on the fly](https://youtu.be/kMghsCXZQ9Y?t=00h14m44s)



[okay](https://youtu.be/kMghsCXZQ9Y?t=00h14m50s)



[cool see you may want to go back to](https://youtu.be/kMghsCXZQ9Y?t=00h14m53s)



[where you were kicking off this new](https://youtu.be/kMghsCXZQ9Y?t=00h14m55s)



[terminal I think that bit got clipped](https://youtu.be/kMghsCXZQ9Y?t=00h14m57s)



[out while I was shifting windows around](https://youtu.be/kMghsCXZQ9Y?t=00h14m59s)



[sure but let me just explain what's](https://youtu.be/kMghsCXZQ9Y?t=00h15m03s)



[going on on the screen right here and](https://youtu.be/kMghsCXZQ9Y?t=00h15m06s)



[talked a little bit about Eternals](https://youtu.be/kMghsCXZQ9Y?t=00h15m10s)



[versus consoles so system console](https://youtu.be/kMghsCXZQ9Y?t=00h15m11s)



[completes two things that are usually](https://youtu.be/kMghsCXZQ9Y?t=00h15m16s)



[separate contacts and command line](https://youtu.be/kMghsCXZQ9Y?t=00h15m18s)



[applications being the console versus](https://youtu.be/kMghsCXZQ9Y?t=00h15m20s)



[the temple so what are the difference](https://youtu.be/kMghsCXZQ9Y?t=00h15m23s)



[between the two right and a lot of](https://youtu.be/kMghsCXZQ9Y?t=00h15m25s)



[people use the terms interchangeably](https://youtu.be/kMghsCXZQ9Y?t=00h15m28s)



[which can be analytic the console is](https://youtu.be/kMghsCXZQ9Y?t=00h15m29s)



[just a set of strings right and this](https://youtu.be/kMghsCXZQ9Y?t=00h15m32s)



[idea goes back to you know it](https://youtu.be/kMghsCXZQ9Y?t=00h15m34s)



[effectively it goes back to actual](https://youtu.be/kMghsCXZQ9Y?t=00h15m41s)



[hardware before it was a software](https://youtu.be/kMghsCXZQ9Y?t=00h15m43s)



[abstraction right it was it was what is](https://youtu.be/kMghsCXZQ9Y?t=00h15m45s)



[the input and output from a physical](https://youtu.be/kMghsCXZQ9Y?t=00h15m47s)



[console and there was an additional](https://youtu.be/kMghsCXZQ9Y?t=00h15m49s)



[output string which is in the standard](https://youtu.be/kMghsCXZQ9Y?t=00h15m52s)



[error so you have standard alarmed and](https://youtu.be/kMghsCXZQ9Y?t=00h15m53s)



[it's very important standard and these](https://youtu.be/kMghsCXZQ9Y?t=00h15m56s)



[are typically at the you know going way](https://youtu.be/kMghsCXZQ9Y?t=00h15m58s)



[back things were connected to actual](https://youtu.be/kMghsCXZQ9Y?t=00h16m00s)



[physical devices and that physical](https://youtu.be/kMghsCXZQ9Y?t=00h16m01s)



[device terminal and keyboard right so](https://youtu.be/kMghsCXZQ9Y?t=00h16m05s)



[the console concept you have it when you](https://youtu.be/kMghsCXZQ9Y?t=00h16m11s)



[have a terminal sitting on top of it the](https://youtu.be/kMghsCXZQ9Y?t=00h16m14s)



[original terminal that sits on top of](https://youtu.be/kMghsCXZQ9Y?t=00h16m15s)



[the console was a typewriter right or a](https://youtu.be/kMghsCXZQ9Y?t=00h16m17s)



[printer and so the output for that](https://youtu.be/kMghsCXZQ9Y?t=00h16m20s)



[printer that you know there's no way to](https://youtu.be/kMghsCXZQ9Y?t=00h16m23s)



[go back and rewrite it it's just](https://youtu.be/kMghsCXZQ9Y?t=00h16m24s)



[spooling out in front of you so what](https://youtu.be/kMghsCXZQ9Y?t=00h16m26s)



[you're seeing on the right here is I'm](https://youtu.be/kMghsCXZQ9Y?t=00h16m28s)



[thinking about the text stream and](https://youtu.be/kMghsCXZQ9Y?t=00h16m30s)



[writing out the text stream in a way](https://youtu.be/kMghsCXZQ9Y?t=00h16m32s)



[that's a pendulum and that's really the](https://youtu.be/kMghsCXZQ9Y?t=00h16m34s)



[true console interface that you get when](https://youtu.be/kMghsCXZQ9Y?t=00h16m36s)



[you spin up a process you connect to it](https://youtu.be/kMghsCXZQ9Y?t=00h16m39s)



[it stand it in standard out and error](https://youtu.be/kMghsCXZQ9Y?t=00h16m40s)



[it's up to you as the consumer of those](https://youtu.be/kMghsCXZQ9Y?t=00h16m43s)



[strings to think about history if you](https://youtu.be/kMghsCXZQ9Y?t=00h16m45s)



[want to so at some point the virtual](https://youtu.be/kMghsCXZQ9Y?t=00h16m48s)



[terminal concept came along and it's a](https://youtu.be/kMghsCXZQ9Y?t=00h16m52s)



[it's a fairly Universal concept in the](https://youtu.be/kMghsCXZQ9Y?t=00h16m56s)



[form of virtual terminal](https://youtu.be/kMghsCXZQ9Y?t=00h17m00s)



[is able to do things and what the](https://youtu.be/kMghsCXZQ9Y?t=00h17m01s)



[windows constantly the window command](https://youtu.be/kMghsCXZQ9Y?t=00h17m04s)



[line really combo study actually](https://youtu.be/kMghsCXZQ9Y?t=00h17m06s)



[understand really is it ended in virtual](https://youtu.be/kMghsCXZQ9Y?t=00h17m09s)



[terminal but it doesn't follow a common](https://youtu.be/kMghsCXZQ9Y?t=00h17m11s)



[virtual terminal standard has been used](https://youtu.be/kMghsCXZQ9Y?t=00h17m13s)



[in the x-term world i linux and mac for](https://youtu.be/kMghsCXZQ9Y?t=00h17m16s)



[many many years and one of the things](https://youtu.be/kMghsCXZQ9Y?t=00h17m19s)



[that we said here was i have a](https://youtu.be/kMghsCXZQ9Y?t=00h17m23s)



[foundation for this approach we said](https://youtu.be/kMghsCXZQ9Y?t=00h17m25s)



[let's actually separate the console in](https://youtu.be/kMghsCXZQ9Y?t=00h17m26s)



[terminal abstraction from one more so on](https://youtu.be/kMghsCXZQ9Y?t=00h17m28s)



[the right we're just writing output to a](https://youtu.be/kMghsCXZQ9Y?t=00h17m32s)



[stream and we're just letting it render](https://youtu.be/kMghsCXZQ9Y?t=00h17m34s)



[to it to the to the terminal right and](https://youtu.be/kMghsCXZQ9Y?t=00h17m36s)



[the terminal has this you know it shows](https://youtu.be/kMghsCXZQ9Y?t=00h17m39s)



[you all the past stuff that was in the](https://youtu.be/kMghsCXZQ9Y?t=00h17m41s)



[stream depending on the settings](https://youtu.be/kMghsCXZQ9Y?t=00h17m43s)



[goodnight in my terminal window i can](https://youtu.be/kMghsCXZQ9Y?t=00h17m44s)



[scroll back a certain distance but maybe](https://youtu.be/kMghsCXZQ9Y?t=00h17m46s)



[not forever](https://youtu.be/kMghsCXZQ9Y?t=00h17m48s)



[all right determine or the console has a](https://youtu.be/kMghsCXZQ9Y?t=00h17m50s)



[fixed buffer yep yeah and so that's](https://youtu.be/kMghsCXZQ9Y?t=00h17m53s)



[really that's an implementation but I](https://youtu.be/kMghsCXZQ9Y?t=00h17m56s)



[can go and I can adjust the buffer size](https://youtu.be/kMghsCXZQ9Y?t=00h17m58s)



[right so that's just that that's just an](https://youtu.be/kMghsCXZQ9Y?t=00h17m59s)



[implementation detail of my virtual](https://youtu.be/kMghsCXZQ9Y?t=00h18m02s)



[terminal application it's not intrinsic](https://youtu.be/kMghsCXZQ9Y?t=00h18m04s)



[to the console itself right](https://youtu.be/kMghsCXZQ9Y?t=00h18m06s)



[it's not intrinsic to my the application](https://youtu.be/kMghsCXZQ9Y?t=00h18m09s)



[that that I'm talking to you right now](https://youtu.be/kMghsCXZQ9Y?t=00h18m10s)



[is standard out I'm seeing being](https://youtu.be/kMghsCXZQ9Y?t=00h18m12s)



[rendered all right okay so on the Left](https://youtu.be/kMghsCXZQ9Y?t=00h18m14s)



[we're doing something a little bit](https://youtu.be/kMghsCXZQ9Y?t=00h18m20s)



[different right we're over writing](https://youtu.be/kMghsCXZQ9Y?t=00h18m22s)



[sections of the screen over and over](https://youtu.be/kMghsCXZQ9Y?t=00h18m24s)



[again to produce more of an animation in](https://youtu.be/kMghsCXZQ9Y?t=00h18m25s)



[place rather than a continuously rolling](https://youtu.be/kMghsCXZQ9Y?t=00h18m30s)



[output stream but the way that we're](https://youtu.be/kMghsCXZQ9Y?t=00h18m34s)



[doing that is actually to produce a](https://youtu.be/kMghsCXZQ9Y?t=00h18m39s)



[continuously rolling output stream](https://youtu.be/kMghsCXZQ9Y?t=00h18m43s)



[because remember yes that's what the](https://youtu.be/kMghsCXZQ9Y?t=00h18m44s)



[console is and just to just to have an](https://youtu.be/kMghsCXZQ9Y?t=00h18m46s)



[example let's go and look at the console](https://youtu.be/kMghsCXZQ9Y?t=00h18m48s)



[abstraction so this is in system command](https://youtu.be/kMghsCXZQ9Y?t=00h18m53s)



[line and we have this eye console and it](https://youtu.be/kMghsCXZQ9Y?t=00h18m56s)



[has standard out standard error and](https://youtu.be/kMghsCXZQ9Y?t=00h19m00s)



[standard it it doesn't have things that](https://youtu.be/kMghsCXZQ9Y?t=00h19m01s)



[let you you know do terminal stuff like](https://youtu.be/kMghsCXZQ9Y?t=00h19m03s)



[reposition the cursor for making](https://youtu.be/kMghsCXZQ9Y?t=00h19m05s)



[different colors and think of it that](https://youtu.be/kMghsCXZQ9Y?t=00h19m06s)



[that's not part of this abstraction they](https://youtu.be/kMghsCXZQ9Y?t=00h19m09s)



[have a different abstraction for that](https://youtu.be/kMghsCXZQ9Y?t=00h19m11s)



[called I terminal](https://youtu.be/kMghsCXZQ9Y?t=00h19m12s)



[and this is what I terminal looks like](https://youtu.be/kMghsCXZQ9Y?t=00h19m15s)



[right now but it's very much a work in](https://youtu.be/kMghsCXZQ9Y?t=00h19m17s)



[progress right so you can see that like](https://youtu.be/kMghsCXZQ9Y?t=00h19m19s)



[both of these things are present in](https://youtu.be/kMghsCXZQ9Y?t=00h19m21s)



[system console but they're conflated](https://youtu.be/kMghsCXZQ9Y?t=00h19m24s)



[insect about if I if I go to system got](https://youtu.be/kMghsCXZQ9Y?t=00h19m26s)



[console and I redirect my output to a](https://youtu.be/kMghsCXZQ9Y?t=00h19m28s)



[file and then I try to set the](https://youtu.be/kMghsCXZQ9Y?t=00h19m30s)



[foreground color I get an exception all](https://youtu.be/kMghsCXZQ9Y?t=00h19m31s)



[right so that kind of tells you there's](https://youtu.be/kMghsCXZQ9Y?t=00h19m33s)



[too many different responsibilities in](https://youtu.be/kMghsCXZQ9Y?t=00h19m35s)



[system not console interface plus its](https://youtu.be/kMghsCXZQ9Y?t=00h19m36s)



[global so you have state sharing](https://youtu.be/kMghsCXZQ9Y?t=00h19m38s)



[problems which makes testing and if](https://youtu.be/kMghsCXZQ9Y?t=00h19m41s)



[you've ever tried to write tests the](https://youtu.be/kMghsCXZQ9Y?t=00h19m42s)



[things that need to writing on system](https://youtu.be/kMghsCXZQ9Y?t=00h19m43s)



[console you probably quickly found that](https://youtu.be/kMghsCXZQ9Y?t=00h19m44s)



[they couldn't be running parallel and if](https://youtu.be/kMghsCXZQ9Y?t=00h19m47s)



[one of them fail and didn't clean up](https://youtu.be/kMghsCXZQ9Y?t=00h19m48s)



[correctly all the others would say hello](https://youtu.be/kMghsCXZQ9Y?t=00h19m49s)



[so yeah these abstractions here we're](https://youtu.be/kMghsCXZQ9Y?t=00h19m55s)



[kind of in a work a work in progress and](https://youtu.be/kMghsCXZQ9Y?t=00h19m58s)



[I think we'll probably end up in a](https://youtu.be/kMghsCXZQ9Y?t=00h19m59s)



[different place for the screen readers](https://youtu.be/kMghsCXZQ9Y?t=00h20m00s)



[and stream writers compared to what we](https://youtu.be/kMghsCXZQ9Y?t=00h20m02s)



[have right now where we're using extreme](https://youtu.be/kMghsCXZQ9Y?t=00h20m03s)



[abstractions we didn't go with sense of](https://youtu.be/kMghsCXZQ9Y?t=00h20m05s)



[the i/o duck stream for various reasons](https://youtu.be/kMghsCXZQ9Y?t=00h20m07s)



[one of them is that you can send it to](https://youtu.be/kMghsCXZQ9Y?t=00h20m10s)



[objects you can just write any object](https://youtu.be/kMghsCXZQ9Y?t=00h20m11s)



[you have all these interfaces overloads](https://youtu.be/kMghsCXZQ9Y?t=00h20m14s)



[for write that let you pass in any](https://youtu.be/kMghsCXZQ9Y?t=00h20m15s)



[object to it right which is up again](https://youtu.be/kMghsCXZQ9Y?t=00h20m17s)



[it's a little bit of a not the right](https://youtu.be/kMghsCXZQ9Y?t=00h20m19s)



[abstraction but as you'll see what](https://youtu.be/kMghsCXZQ9Y?t=00h20m20s)



[system command-line rendering we](https://youtu.be/kMghsCXZQ9Y?t=00h20m23s)



[actually do want to be able to render](https://youtu.be/kMghsCXZQ9Y?t=00h20m25s)



[objects but we want to control the way](https://youtu.be/kMghsCXZQ9Y?t=00h20m26s)



[they get written to output so it's not](https://youtu.be/kMghsCXZQ9Y?t=00h20m28s)



[that interfaces problem to think about](https://youtu.be/kMghsCXZQ9Y?t=00h20m31s)



[that so this is some of the reasons why](https://youtu.be/kMghsCXZQ9Y?t=00h20m33s)



[we define a new console interface and an](https://youtu.be/kMghsCXZQ9Y?t=00h20m34s)



[eternal interface so hopefully I don't](https://youtu.be/kMghsCXZQ9Y?t=00h20m37s)



[that all make three little time makes](https://youtu.be/kMghsCXZQ9Y?t=00h20m42s)



[sense to me but I've also been in the](https://youtu.be/kMghsCXZQ9Y?t=00h20m44s)



[project working on it so yeah](https://youtu.be/kMghsCXZQ9Y?t=00h20m46s)



[so let me show a different thing here](https://youtu.be/kMghsCXZQ9Y?t=00h20m51s)



[let's do this work because I think such](https://youtu.be/kMghsCXZQ9Y?t=00h20m57s)



[a switch sorry](https://youtu.be/kMghsCXZQ9Y?t=00h21m13s)



[yeah what about wha diagonal lines](https://youtu.be/kMghsCXZQ9Y?t=00h21m17s)



[gibberish I love it yeah what the heck](https://youtu.be/kMghsCXZQ9Y?t=00h21m23s)



[is going on there so vt100 control](https://youtu.be/kMghsCXZQ9Y?t=00h21m26s)



[characters just off yeah exactly](https://youtu.be/kMghsCXZQ9Y?t=00h21m32s)



[really feels like something that should](https://youtu.be/kMghsCXZQ9Y?t=00h21m41s)



[be turned into a screen saver yeah so so](https://youtu.be/kMghsCXZQ9Y?t=00h21m42s)



[what you're seeing there that you know](https://youtu.be/kMghsCXZQ9Y?t=00h21m51s)



[even when I'm using vt100 output rather](https://youtu.be/kMghsCXZQ9Y?t=00h21m53s)



[than just plain text output right before](https://youtu.be/kMghsCXZQ9Y?t=00h21m56s)



[it was just plain text output when](https://youtu.be/kMghsCXZQ9Y?t=00h21m58s)



[you're seeing the time being upended](https://youtu.be/kMghsCXZQ9Y?t=00h21m59s)



[again and again and again that's what](https://youtu.be/kMghsCXZQ9Y?t=00h22m00s)



[you're seeing here - except it's also](https://youtu.be/kMghsCXZQ9Y?t=00h22m02s)



[got all these control characters in the](https://youtu.be/kMghsCXZQ9Y?t=00h22m03s)



[limit so if we scroll back through a](https://youtu.be/kMghsCXZQ9Y?t=00h22m05s)



[little bit of time here but it's](https://youtu.be/kMghsCXZQ9Y?t=00h22m06s)



[embedded in all these control characters](https://youtu.be/kMghsCXZQ9Y?t=00h22m13s)



[what those control characters are doing](https://youtu.be/kMghsCXZQ9Y?t=00h22m14s)



[is updating sections of the screen so](https://youtu.be/kMghsCXZQ9Y?t=00h22m16s)



[that you get that effect that you saw in](https://youtu.be/kMghsCXZQ9Y?t=00h22m18s)



[Digital Studio codes terminal window](https://youtu.be/kMghsCXZQ9Y?t=00h22m22s)



[here right that is literally the same](https://youtu.be/kMghsCXZQ9Y?t=00h22m24s)



[output except on the right we've set the](https://youtu.be/kMghsCXZQ9Y?t=00h22m27s)



[terminal to virtual terminal mode using](https://youtu.be/kMghsCXZQ9Y?t=00h22m30s)



[those meant this a win32 api that i](https://youtu.be/kMghsCXZQ9Y?t=00h22m34s)



[mentioned before](https://youtu.be/kMghsCXZQ9Y?t=00h22m37s)



[and that will also detect terminal modes](https://youtu.be/kMghsCXZQ9Y?t=00h22m37s)



[correctly on Linux and Mac because vt100](https://youtu.be/kMghsCXZQ9Y?t=00h22m39s)



[is just supported automatically on](https://youtu.be/kMghsCXZQ9Y?t=00h22m41s)



[externals yeah and you get this instead](https://youtu.be/kMghsCXZQ9Y?t=00h22m43s)



[so this is it's a what we t100 is doing](https://youtu.be/kMghsCXZQ9Y?t=00h22m49s)



[is it's sending signals over the](https://youtu.be/kMghsCXZQ9Y?t=00h22m53s)



[standard output or standard error right](https://youtu.be/kMghsCXZQ9Y?t=00h22m55s)



[and can be used on standard n as well](https://youtu.be/kMghsCXZQ9Y?t=00h22m57s)



[and enabled separate them centered and](https://youtu.be/kMghsCXZQ9Y?t=00h22m59s)



[it's sending signals that say hey move](https://youtu.be/kMghsCXZQ9Y?t=00h23m00s)



[the cursor hey set this color all these](https://youtu.be/kMghsCXZQ9Y?t=00h23m03s)



[kinds of things are encoded into the](https://youtu.be/kMghsCXZQ9Y?t=00h23m04s)



[vt100 but it's just still just the text](https://youtu.be/kMghsCXZQ9Y?t=00h23m05s)



[extreme so you need to have a virtual](https://youtu.be/kMghsCXZQ9Y?t=00h23m08s)



[terminal that knows how to render this](https://youtu.be/kMghsCXZQ9Y?t=00h23m09s)



[dock correctly the upcoming Windows](https://youtu.be/kMghsCXZQ9Y?t=00h23m11s)



[terminal does that automatically as well](https://youtu.be/kMghsCXZQ9Y?t=00h23m13s)



[but the future is leaking 100 even](https://youtu.be/kMghsCXZQ9Y?t=00h23m15s)



[though it's a technology than 40 years](https://youtu.be/kMghsCXZQ9Y?t=00h23m18s)



[old right so real quick there's a](https://youtu.be/kMghsCXZQ9Y?t=00h23m20s)



[question here](https://youtu.be/kMghsCXZQ9Y?t=00h23m22s)



[Xavier I thought you said last time that](https://youtu.be/kMghsCXZQ9Y?t=00h23m25s)



[can only be one directive but you used](https://youtu.be/kMghsCXZQ9Y?t=00h23m27s)



[this time so you want to go back to that](https://youtu.be/kMghsCXZQ9Y?t=00h23m29s)



[invocation and look at that real quick](https://youtu.be/kMghsCXZQ9Y?t=00h23m33s)



[yeah yeah so I'll do that here little](https://youtu.be/kMghsCXZQ9Y?t=00h23m35s)



[easier to read so here](https://youtu.be/kMghsCXZQ9Y?t=00h23m39s)



[here's what I did to enable the clock in](https://youtu.be/kMghsCXZQ9Y?t=00h23m42s)



[in place rerender shifted all the way to](https://youtu.be/kMghsCXZQ9Y?t=00h23m46s)



[the left room my video sits in the](https://youtu.be/kMghsCXZQ9Y?t=00h23m50s)



[bottom right corner so anything in the](https://youtu.be/kMghsCXZQ9Y?t=00h23m52s)



[bottom right gets yeah I've got that](https://youtu.be/kMghsCXZQ9Y?t=00h23m54s)



[I've got the stream on my other machine](https://youtu.be/kMghsCXZQ9Y?t=00h23m58s)



[over here so perfect I can I can kind of](https://youtu.be/kMghsCXZQ9Y?t=00h23m59s)



[see it in position accordingly](https://youtu.be/kMghsCXZQ9Y?t=00h24m02s)



[technology okay](https://youtu.be/kMghsCXZQ9Y?t=00h24m05s)



[so save your questions you know I](https://youtu.be/kMghsCXZQ9Y?t=00h24m08s)



[you thought that you can only use one](https://youtu.be/kMghsCXZQ9Y?t=00h24m12s)



[directive that's not true you can only](https://youtu.be/kMghsCXZQ9Y?t=00h24m14s)



[have directives at the beginning of the](https://youtu.be/kMghsCXZQ9Y?t=00h24m18s)



[command line so right this is not neck](https://youtu.be/kMghsCXZQ9Y?t=00h24m20s)



[run this little thing here says](https://youtu.be/kMghsCXZQ9Y?t=00h24m22s)



[everything after it should be sent to my](https://youtu.be/kMghsCXZQ9Y?t=00h24m24s)



[program so all these are you know these](https://youtu.be/kMghsCXZQ9Y?t=00h24m27s)



[are all of the arguments that are being](https://youtu.be/kMghsCXZQ9Y?t=00h24m29s)



[sent to the rendering playground program](https://youtu.be/kMghsCXZQ9Y?t=00h24m30s)



[there could be as many directives as you](https://youtu.be/kMghsCXZQ9Y?t=00h24m34s)



[want it's just that once you stop having](https://youtu.be/kMghsCXZQ9Y?t=00h24m36s)



[directives at the front of the command](https://youtu.be/kMghsCXZQ9Y?t=00h24m39s)



[line everything else becomes the options](https://youtu.be/kMghsCXZQ9Y?t=00h24m40s)



[that are defined inside of your program](https://youtu.be/kMghsCXZQ9Y?t=00h24m42s)



[itself so we had talked about dragon](https://youtu.be/kMghsCXZQ9Y?t=00h24m44s)



[fruit before the rendering playground](https://youtu.be/kMghsCXZQ9Y?t=00h24m46s)



[program CS is a dragon fruit program](https://youtu.be/kMghsCXZQ9Y?t=00h24m49s)



[right so it's rather than the string](https://youtu.be/kMghsCXZQ9Y?t=00h24m54s)



[args for main it has a bunch of strongly](https://youtu.be/kMghsCXZQ9Y?t=00h24m57s)



[type named specific arguments so this is](https://youtu.be/kMghsCXZQ9Y?t=00h25m00s)



[the thing that defines the input to the](https://youtu.be/kMghsCXZQ9Y?t=00h25m03s)



[program directives are always orthogonal](https://youtu.be/kMghsCXZQ9Y?t=00h25m06s)



[to this so directives are things you](https://youtu.be/kMghsCXZQ9Y?t=00h25m08s)



[know tends to drive cross-cutting](https://youtu.be/kMghsCXZQ9Y?t=00h25m10s)



[functionality and a lot of its](https://youtu.be/kMghsCXZQ9Y?t=00h25m11s)



[functionality that's just built into](https://youtu.be/kMghsCXZQ9Y?t=00h25m13s)



[system command line so what these two](https://youtu.be/kMghsCXZQ9Y?t=00h25m14s)



[are doing ultimately the story is that](https://youtu.be/kMghsCXZQ9Y?t=00h25m17s)



[you want to be able to specify them but](https://youtu.be/kMghsCXZQ9Y?t=00h25m19s)



[in most cases you want them to just have](https://youtu.be/kMghsCXZQ9Y?t=00h25m22s)



[reasonable defaults which we call you](https://youtu.be/kMghsCXZQ9Y?t=00h25m24s)



[know detective basically word we're](https://youtu.be/kMghsCXZQ9Y?t=00h25m26s)



[talking about detecting terminal](https://youtu.be/kMghsCXZQ9Y?t=00h25m27s)



[capabilities and just doing the right](https://youtu.be/kMghsCXZQ9Y?t=00h25m29s)



[thing so that on Windows will say oh can](https://youtu.be/kMghsCXZQ9Y?t=00h25m31s)



[we elevate it to vt100 yes then we can](https://youtu.be/kMghsCXZQ9Y?t=00h25m32s)



[render in vt100 mode if not we're on](https://youtu.be/kMghsCXZQ9Y?t=00h25m35s)



[against a system console API is which do](https://youtu.be/kMghsCXZQ9Y?t=00h25m37s)



[work for a lot of terminal type](https://youtu.be/kMghsCXZQ9Y?t=00h25m39s)



[they're not remote Abel in the same way](https://youtu.be/kMghsCXZQ9Y?t=00h25m41s)



[that bt100 is right if you send a bt100](https://youtu.be/kMghsCXZQ9Y?t=00h25m43s)



[stream across an SSH connection](https://youtu.be/kMghsCXZQ9Y?t=00h25m45s)



[it still renders correctly on the remote](https://youtu.be/kMghsCXZQ9Y?t=00h25m48s)



[terminal which is one of the reasons why](https://youtu.be/kMghsCXZQ9Y?t=00h25m49s)



[it's really nice system that console is](https://youtu.be/kMghsCXZQ9Y?t=00h25m50s)



[not very good at that kind of thing or](https://youtu.be/kMghsCXZQ9Y?t=00h25m52s)



[if you are starting up a child process](https://youtu.be/kMghsCXZQ9Y?t=00h25m54s)



[and your parent process is redirecting](https://youtu.be/kMghsCXZQ9Y?t=00h25m56s)



[output and you want the child process to](https://youtu.be/kMghsCXZQ9Y?t=00h25m58s)



[not emit scuffling bt100 into your log](https://youtu.be/kMghsCXZQ9Y?t=00h26m00s)



[file right then the directives become](https://youtu.be/kMghsCXZQ9Y?t=00h26m03s)



[handy for telling it here here's the](https://youtu.be/kMghsCXZQ9Y?t=00h26m05s)



[rendering mode I want so that's kind of](https://youtu.be/kMghsCXZQ9Y?t=00h26m07s)



[what you're seeing here is like the](https://youtu.be/kMghsCXZQ9Y?t=00h26m09s)



[ability to specify but hopefully also](https://youtu.be/kMghsCXZQ9Y?t=00h26m10s)



[that you don't need to if you don't if](https://youtu.be/kMghsCXZQ9Y?t=00h26m12s)



[you're not in one of these kind of](https://youtu.be/kMghsCXZQ9Y?t=00h26m15s)



[hybrid scenarios so what this directive](https://youtu.be/kMghsCXZQ9Y?t=00h26m16s)



[is enabling VT but if you don't specify](https://youtu.be/kMghsCXZQ9Y?t=00h26m21s)



[it we try to detect it what this one is](https://youtu.be/kMghsCXZQ9Y?t=00h26m23s)



[here is what's the output mode there are](https://youtu.be/kMghsCXZQ9Y?t=00h26m26s)



[three different output modes that we](https://youtu.be/kMghsCXZQ9Y?t=00h26m27s)



[support one is pantsy which is the thing](https://youtu.be/kMghsCXZQ9Y?t=00h26m29s)



[you see on the right with all the you](https://youtu.be/kMghsCXZQ9Y?t=00h26m30s)



[know the BT 100 codes are also known as](https://youtu.be/kMghsCXZQ9Y?t=00h26m32s)



[ansi escape sequences non ANSI which](https://youtu.be/kMghsCXZQ9Y?t=00h26m34s)



[means render as if you are writing to](https://youtu.be/kMghsCXZQ9Y?t=00h26m38s)



[system console which basically means](https://youtu.be/kMghsCXZQ9Y?t=00h26m40s)



[plain text but we also will try to](https://youtu.be/kMghsCXZQ9Y?t=00h26m42s)



[position the cursor using system gun](https://youtu.be/kMghsCXZQ9Y?t=00h26m45s)



[it's just a console API and the third](https://youtu.be/kMghsCXZQ9Y?t=00h26m47s)



[option is file which no attempt is made](https://youtu.be/kMghsCXZQ9Y?t=00h26m50s)



[to reposition cursors ever we said okay](https://youtu.be/kMghsCXZQ9Y?t=00h26m54s)



[we're just writing to a file but you can](https://youtu.be/kMghsCXZQ9Y?t=00h26m56s)



[force me T 100 to the file for example](https://youtu.be/kMghsCXZQ9Y?t=00h26m58s)



[so the be using these two directives](https://youtu.be/kMghsCXZQ9Y?t=00h27m00s)



[together you can have various](https://youtu.be/kMghsCXZQ9Y?t=00h27m01s)



[combinations about them so given all](https://youtu.be/kMghsCXZQ9Y?t=00h27m03s)



[that stuff what we wanted to then do is](https://youtu.be/kMghsCXZQ9Y?t=00h27m08s)



[say oK we've got the capabilities that](https://youtu.be/kMghsCXZQ9Y?t=00h27m10s)



[take a single block of code and render](https://youtu.be/kMghsCXZQ9Y?t=00h27m12s)



[it in all these different ways so what](https://youtu.be/kMghsCXZQ9Y?t=00h27m15s)



[does that code look like right what's](https://youtu.be/kMghsCXZQ9Y?t=00h27m17s)



[the API that that we could write we](https://youtu.be/kMghsCXZQ9Y?t=00h27m18s)



[thought about you know asp.net MVC views](https://youtu.be/kMghsCXZQ9Y?t=00h27m20s)



[and we thought a bit about WPF and what](https://youtu.be/kMghsCXZQ9Y?t=00h27m23s)



[are the view abstractions there that](https://youtu.be/kMghsCXZQ9Y?t=00h27m25s)



[kind of let you think about layouts and](https://youtu.be/kMghsCXZQ9Y?t=00h27m27s)



[content first and foremost rather than](https://youtu.be/kMghsCXZQ9Y?t=00h27m29s)



[text extremes all right and then we can](https://youtu.be/kMghsCXZQ9Y?t=00h27m32s)



[use that API to target all of these](https://youtu.be/kMghsCXZQ9Y?t=00h27m34s)



[different kinds of output so let's take](https://youtu.be/kMghsCXZQ9Y?t=00h27m36s)



[a look at the clock how does this thing](https://youtu.be/kMghsCXZQ9Y?t=00h27m41s)



[work magic](https://youtu.be/kMghsCXZQ9Y?t=00h27m44s)



[do you want to explain this one Kevin I](https://youtu.be/kMghsCXZQ9Y?t=00h27m51s)



[think you've got more context into the](https://youtu.be/kMghsCXZQ9Y?t=00h27m53s)



[AP in the API detail than I do](https://youtu.be/kMghsCXZQ9Y?t=00h27m56s)



[well I will I will do my best and you](https://youtu.be/kMghsCXZQ9Y?t=00h27m57s)



[can correct me where I steer all right](https://youtu.be/kMghsCXZQ9Y?t=00h28m00s)



[so I have done a bunch of work on these](https://youtu.be/kMghsCXZQ9Y?t=00h28m02s)



[things so inside of the system rendering](https://youtu.be/kMghsCXZQ9Y?t=00h28m04s)



[project there's a a cause starting at](https://youtu.be/kMghsCXZQ9Y?t=00h28m08s)



[the top the highest level object is](https://youtu.be/kMghsCXZQ9Y?t=00h28m13s)



[views for people who are familiar with](https://youtu.be/kMghsCXZQ9Y?t=00h28m15s)



[like thick client like sam'l types setup](https://youtu.be/kMghsCXZQ9Y?t=00h28m19s)



[you can think of these as roughly](https://youtu.be/kMghsCXZQ9Y?t=00h28m24s)



[equivalent to like your the various](https://youtu.be/kMghsCXZQ9Y?t=00h28m26s)



[elements that you might layout people](https://youtu.be/kMghsCXZQ9Y?t=00h28m27s)



[who've done wind forms or windows forms](https://youtu.be/kMghsCXZQ9Y?t=00h28m29s)



[might also be familiar with this type of](https://youtu.be/kMghsCXZQ9Y?t=00h28m31s)



[setup at the top level we have a screen](https://youtu.be/kMghsCXZQ9Y?t=00h28m33s)



[view and the screen view is somewhat](https://youtu.be/kMghsCXZQ9Y?t=00h28m36s)



[misleading in its name but it basically](https://youtu.be/kMghsCXZQ9Y?t=00h28m40s)



[represents the view of your terminal](https://youtu.be/kMghsCXZQ9Y?t=00h28m42s)



[that's that's visible so from like a](https://youtu.be/kMghsCXZQ9Y?t=00h28m45s)



[system console API perspective you can](https://youtu.be/kMghsCXZQ9Y?t=00h28m48s)



[think of this as the actual height and](https://youtu.be/kMghsCXZQ9Y?t=00h28m52s)



[width that you have available with this](https://youtu.be/kMghsCXZQ9Y?t=00h28m55s)



[clock perspective inside of the views](https://youtu.be/kMghsCXZQ9Y?t=00h29m00s)



[most things boiled down into one of two](https://youtu.be/kMghsCXZQ9Y?t=00h29m02s)



[types you've got sort of your layout](https://youtu.be/kMghsCXZQ9Y?t=00h29m04s)



[views for if you want to do things like](https://youtu.be/kMghsCXZQ9Y?t=00h29m06s)



[tables or grids or that kind of thing](https://youtu.be/kMghsCXZQ9Y?t=00h29m08s)



[and you can compose those things](https://youtu.be/kMghsCXZQ9Y?t=00h29m10s)



[together however you want and then with](https://youtu.be/kMghsCXZQ9Y?t=00h29m12s)



[inside of those layout views you usually](https://youtu.be/kMghsCXZQ9Y?t=00h29m15s)



[get down to a Content view whose purpose](https://youtu.be/kMghsCXZQ9Y?t=00h29m18s)



[is really just to output some sort of](https://youtu.be/kMghsCXZQ9Y?t=00h29m21s)



[content if you dig a little deeper in](https://youtu.be/kMghsCXZQ9Y?t=00h29m24s)



[the API inside of the content view](https://youtu.be/kMghsCXZQ9Y?t=00h29m27s)



[there's things called spans similar to](https://youtu.be/kMghsCXZQ9Y?t=00h29m29s)



[what you might be familiar with with](https://youtu.be/kMghsCXZQ9Y?t=00h29m32s)



[like HTML for a span object for being](https://youtu.be/kMghsCXZQ9Y?t=00h29m34s)



[able to say adjust the color of](https://youtu.be/kMghsCXZQ9Y?t=00h29m37s)



[something so that part of your text is](https://youtu.be/kMghsCXZQ9Y?t=00h29m39s)



[red for example and so in this example](https://youtu.be/kMghsCXZQ9Y?t=00h29m41s)



[what we have here is a screen view at](https://youtu.be/kMghsCXZQ9Y?t=00h29m45s)



[the root and inside of the screen view](https://youtu.be/kMghsCXZQ9Y?t=00h29m48s)



[we're going to put a Content view which](https://youtu.be/kMghsCXZQ9Y?t=00h29m53s)



[is just that o'clock that you see there](https://youtu.be/kMghsCXZQ9Y?t=00h29m57s)



[and then we're going to start rendering](https://youtu.be/kMghsCXZQ9Y?t=00h29m59s)



[it the](https://youtu.be/kMghsCXZQ9Y?t=00h30m01s)



[while loop at the bottom is just there](https://youtu.be/kMghsCXZQ9Y?t=00h30m03s)



[looking for a key press four to indicate](https://youtu.be/kMghsCXZQ9Y?t=00h30m05s)



[basically stop the demo and after that](https://youtu.be/kMghsCXZQ9Y?t=00h30m08s)



[it's just going to sit there and spin](https://youtu.be/kMghsCXZQ9Y?t=00h30m12s)



[and every time the the clock has changed](https://youtu.be/kMghsCXZQ9Y?t=00h30m13s)



[its just going to update that observable](https://youtu.be/kMghsCXZQ9Y?t=00h30m16s)



[so not to dive too deep into the eye](https://youtu.be/kMghsCXZQ9Y?t=00h30m19s)



[observable interface but it basically](https://youtu.be/kMghsCXZQ9Y?t=00h30m23s)



[has a published subscribe type pattern](https://youtu.be/kMghsCXZQ9Y?t=00h30m25s)



[to it for people with mvvm backgrounds](https://youtu.be/kMghsCXZQ9Y?t=00h30m28s)



[you can think of it almost as the](https://youtu.be/kMghsCXZQ9Y?t=00h30m32s)



[equivalent of like and inotify property](https://youtu.be/kMghsCXZQ9Y?t=00h30m34s)



[changed please no one throw stuff at me](https://youtu.be/kMghsCXZQ9Y?t=00h30m36s)



[I realize they are very different in a](https://youtu.be/kMghsCXZQ9Y?t=00h30m39s)



[lot of fundamental ways but that content](https://youtu.be/kMghsCXZQ9Y?t=00h30m40s)



[view from observable registers up](https://youtu.be/kMghsCXZQ9Y?t=00h30m43s)



[looking for changes to that observable](https://youtu.be/kMghsCXZQ9Y?t=00h30m47s)



[object and then will automatically](https://youtu.be/kMghsCXZQ9Y?t=00h30m52s)



[update the UI contents as those change](https://youtu.be/kMghsCXZQ9Y?t=00h30m54s)



[which is how you're seeing that clock](https://youtu.be/kMghsCXZQ9Y?t=00h30m57s)



[essentially tick every time there's a](https://youtu.be/kMghsCXZQ9Y?t=00h30m59s)



[new second so that's a very long](https://youtu.be/kMghsCXZQ9Y?t=00h31m01s)



[explanation for a very few lines of code](https://youtu.be/kMghsCXZQ9Y?t=00h31m03s)



[but ultimately it leads to a ticking](https://youtu.be/kMghsCXZQ9Y?t=00h31m08s)



[clock like what you see right there](https://youtu.be/kMghsCXZQ9Y?t=00h31m11s)



[another thing that I would that I would](https://youtu.be/kMghsCXZQ9Y?t=00h31m18s)



[add in as a sort of a demonstration of a](https://youtu.be/kMghsCXZQ9Y?t=00h31m20s)



[different set of capabilities that you](https://youtu.be/kMghsCXZQ9Y?t=00h31m22s)



[eluded to just them is this I don't know](https://youtu.be/kMghsCXZQ9Y?t=00h31m23s)



[if we added directives for height and](https://youtu.be/kMghsCXZQ9Y?t=00h31m28s)



[width and so on and there may be some](https://youtu.be/kMghsCXZQ9Y?t=00h31m29s)



[collisions here between some of the](https://youtu.be/kMghsCXZQ9Y?t=00h31m32s)



[concepts but we have this other sample](https://youtu.be/kMghsCXZQ9Y?t=00h31m33s)



[you have mentioned this this sample here](https://youtu.be/kMghsCXZQ9Y?t=00h31m35s)



[is this sure this is positioned in a way](https://youtu.be/kMghsCXZQ9Y?t=00h31m41s)



[that it will make sense when I render it](https://youtu.be/kMghsCXZQ9Y?t=00h31m43s)



[okay so we have this mobi sample which](https://youtu.be/kMghsCXZQ9Y?t=00h31m45s)



[is it's like the first paragraph of](https://youtu.be/kMghsCXZQ9Y?t=00h31m48s)



[moby-dick with some formatting inside of](https://youtu.be/kMghsCXZQ9Y?t=00h31m50s)



[it and the rendering playground has](https://youtu.be/kMghsCXZQ9Y?t=00h31m53s)



[height top-left width parameters you can](https://youtu.be/kMghsCXZQ9Y?t=00h31m55s)



[pass in alright so you can see here some](https://youtu.be/kMghsCXZQ9Y?t=00h31m58s)



[underlining some text colors the text](https://youtu.be/kMghsCXZQ9Y?t=00h32m05s)



[colors are actually quite interesting](https://youtu.be/kMghsCXZQ9Y?t=00h32m09s)



[because doing this yeah there we go and](https://youtu.be/kMghsCXZQ9Y?t=00h32m10s)



[you'll see the word wrapping is](https://youtu.be/kMghsCXZQ9Y?t=00h32m21s)



[supported within that area right so even](https://youtu.be/kMghsCXZQ9Y?t=00h32m22s)



[though I rendered to a let's do](https://youtu.be/kMghsCXZQ9Y?t=00h32m25s)



[something like that see what it looks](https://youtu.be/kMghsCXZQ9Y?t=00h32m31s)



[like](https://youtu.be/kMghsCXZQ9Y?t=00h32m33s)



[shrink it down to almost](https://youtu.be/kMghsCXZQ9Y?t=00h32m39s)



[understand yeah and I am aware I was](https://youtu.be/kMghsCXZQ9Y?t=00h32m44s)



[playing around with some of the](https://youtu.be/kMghsCXZQ9Y?t=00h32m47s)



[rendering stuff earlier this week and I](https://youtu.be/kMghsCXZQ9Y?t=00h32m49s)



[did run into a couple bugs in different](https://youtu.be/kMghsCXZQ9Y?t=00h32m50s)



[areas so the this like John said at the](https://youtu.be/kMghsCXZQ9Y?t=00h32m52s)



[beginning this this rendering stuff is](https://youtu.be/kMghsCXZQ9Y?t=00h32m56s)



[very much in a lot more flux and not](https://youtu.be/kMghsCXZQ9Y?t=00h32m58s)



[quite as stable as the base system](https://youtu.be/kMghsCXZQ9Y?t=00h33m02s)



[command-line parser that it's built on](https://youtu.be/kMghsCXZQ9Y?t=00h33m04s)



[top of so we definitely would enjoy](https://youtu.be/kMghsCXZQ9Y?t=00h33m06s)



[feedback on issues bug reports or if](https://youtu.be/kMghsCXZQ9Y?t=00h33m11s)



[people want to dive in and help and fix](https://youtu.be/kMghsCXZQ9Y?t=00h33m14s)



[stuff there is yeah yep but putting](https://youtu.be/kMghsCXZQ9Y?t=00h33m16s)



[these two things together you can](https://youtu.be/kMghsCXZQ9Y?t=00h33m23s)



[imagine that once you have you know you](https://youtu.be/kMghsCXZQ9Y?t=00h33m24s)



[if you define regions of your screen and](https://youtu.be/kMghsCXZQ9Y?t=00h33m26s)



[think of them at the table layout right](https://youtu.be/kMghsCXZQ9Y?t=00h33m29s)



[this this API that I'm showing here can](https://youtu.be/kMghsCXZQ9Y?t=00h33m31s)



[can show you how you can create a bunch](https://youtu.be/kMghsCXZQ9Y?t=00h33m33s)



[of different cells within it and you can](https://youtu.be/kMghsCXZQ9Y?t=00h33m34s)



[do the updating in place with the clock](https://youtu.be/kMghsCXZQ9Y?t=00h33m36s)



[approach and by combining those two](https://youtu.be/kMghsCXZQ9Y?t=00h33m38s)



[things we'll get some really interesting](https://youtu.be/kMghsCXZQ9Y?t=00h33m40s)



[rich animated stats a polite kind of a](https://youtu.be/kMghsCXZQ9Y?t=00h33m41s)



[one of our ideal goals for this piece](https://youtu.be/kMghsCXZQ9Y?t=00h33m45s)



[right you want to jump back to that](https://youtu.be/kMghsCXZQ9Y?t=00h33m48s)



[clock output because there was one thing](https://youtu.be/kMghsCXZQ9Y?t=00h33m51s)



[that we didn't quite touch on that I](https://youtu.be/kMghsCXZQ9Y?t=00h33m52s)



[don't know if it's horribly intuitive so](https://youtu.be/kMghsCXZQ9Y?t=00h33m54s)



[in the clock output where we have it](https://youtu.be/kMghsCXZQ9Y?t=00h33m58s)



[updating if you want to just jump back](https://youtu.be/kMghsCXZQ9Y?t=00h34m00s)



[to the code real quick there was that](https://youtu.be/kMghsCXZQ9Y?t=00h34m02s)



[content view from observable so one day](https://youtu.be/kMghsCXZQ9Y?t=00h34m04s)



[John comes to me and says hey I've got](https://youtu.be/kMghsCXZQ9Y?t=00h34m09s)



[this great cool awesome idea of how to](https://youtu.be/kMghsCXZQ9Y?t=00h34m11s)



[actually effectively do this binding](https://youtu.be/kMghsCXZQ9Y?t=00h34m14s)



[because we had tossed around different](https://youtu.be/kMghsCXZQ9Y?t=00h34m17s)



[ideas my WPF background I'm very partial](https://youtu.be/kMghsCXZQ9Y?t=00h34m19s)



[to the binding of I want to just update](https://youtu.be/kMghsCXZQ9Y?t=00h34m23s)



[my data and have my view magically be](https://youtu.be/kMghsCXZQ9Y?t=00h34m26s)



[pulled in sync John can you move it so](https://youtu.be/kMghsCXZQ9Y?t=00h34m30s)



[we can see that full from observable](https://youtu.be/kMghsCXZQ9Y?t=00h34m32s)



[line 107 I think there we go so you'll](https://youtu.be/kMghsCXZQ9Y?t=00h34m34s)



[notice that content view from observable](https://youtu.be/kMghsCXZQ9Y?t=00h34m38s)



[that second parameter that's going in](https://youtu.be/kMghsCXZQ9Y?t=00h34m40s)



[there so the first parameter is just any](https://youtu.be/kMghsCXZQ9Y?t=00h34m43s)



[object that implements I observable and](https://youtu.be/kMghsCXZQ9Y?t=00h34m45s)



[the second one goes into that X lambda](https://youtu.be/kMghsCXZQ9Y?t=00h34m47s)



[and what looks like an interpolated](https://youtu.be/kMghsCXZQ9Y?t=00h34m50s)



[string there but this is kind of a](https://youtu.be/kMghsCXZQ9Y?t=00h34m53s)



[obscure area](https://youtu.be/kMghsCXZQ9Y?t=00h34m56s)



[c-sharp that got added one string](https://youtu.be/kMghsCXZQ9Y?t=00h34m58s)



[interpolation came into play in that](https://youtu.be/kMghsCXZQ9Y?t=00h35m00s)



[that dollar sign in front of the string](https://youtu.be/kMghsCXZQ9Y?t=00h35m02s)



[doesn't always return a string and so in](https://youtu.be/kMghsCXZQ9Y?t=00h35m06s)



[this case it's actually returning a](https://youtu.be/kMghsCXZQ9Y?t=00h35m10s)



[formattable string which you can sort of](https://youtu.be/kMghsCXZQ9Y?t=00h35m12s)



[think about it as the equivalent of what](https://youtu.be/kMghsCXZQ9Y?t=00h35m15s)



[a link expression is to a link query](https://youtu.be/kMghsCXZQ9Y?t=00h35m19s)



[where the link expression contains the](https://youtu.be/kMghsCXZQ9Y?t=00h35m21s)



[metadata of the actual query and the](https://youtu.be/kMghsCXZQ9Y?t=00h35m24s)



[link query itself is just effectively](https://youtu.be/kMghsCXZQ9Y?t=00h35m27s)



[the delegate so this is the formattable](https://youtu.be/kMghsCXZQ9Y?t=00h35m29s)



[string basically gives you all of the](https://youtu.be/kMghsCXZQ9Y?t=00h35m34s)



[metadata about the string that could be](https://youtu.be/kMghsCXZQ9Y?t=00h35m36s)



[formatted so that you can then act on it](https://youtu.be/kMghsCXZQ9Y?t=00h35m39s)



[and do something different which is how](https://youtu.be/kMghsCXZQ9Y?t=00h35m41s)



[we're getting our automatic updating](https://youtu.be/kMghsCXZQ9Y?t=00h35m43s)



[we're basically parsing out those](https://youtu.be/kMghsCXZQ9Y?t=00h35m44s)



[elements and saying ah I see that that's](https://youtu.be/kMghsCXZQ9Y?t=00h35m47s)



[an observable object let me wire up to](https://youtu.be/kMghsCXZQ9Y?t=00h35m48s)



[the appropriate events and then update](https://youtu.be/kMghsCXZQ9Y?t=00h35m51s)



[my UI when those things come through so](https://youtu.be/kMghsCXZQ9Y?t=00h35m53s)



[you can actually it's quite powerful in](https://youtu.be/kMghsCXZQ9Y?t=00h35m55s)



[that if you wanted to say prefix the](https://youtu.be/kMghsCXZQ9Y?t=00h35m57s)



[time with the time is or something you](https://youtu.be/kMghsCXZQ9Y?t=00h35m59s)



[could just type that string in there and](https://youtu.be/kMghsCXZQ9Y?t=00h36m02s)



[it automatically works and so it's smart](https://youtu.be/kMghsCXZQ9Y?t=00h36m04s)



[enough to realize and when it's parsing](https://youtu.be/kMghsCXZQ9Y?t=00h36m19s)



[that string to know okay here's where](https://youtu.be/kMghsCXZQ9Y?t=00h36m21s)



[the I observable goes here's the content](https://youtu.be/kMghsCXZQ9Y?t=00h36m23s)



[that needs to update and do all of that](https://youtu.be/kMghsCXZQ9Y?t=00h36m25s)



[updating in place so just something to](https://youtu.be/kMghsCXZQ9Y?t=00h36m26s)



[be aware of so this this content view](https://youtu.be/kMghsCXZQ9Y?t=00h36m30s)



[from observable I I think is probably](https://youtu.be/kMghsCXZQ9Y?t=00h36m33s)



[one of the most powerful ways of being](https://youtu.be/kMghsCXZQ9Y?t=00h36m36s)



[able to use this rendering library just](https://youtu.be/kMghsCXZQ9Y?t=00h36m38s)



[because of how easy it is to get a](https://youtu.be/kMghsCXZQ9Y?t=00h36m40s)



[region effectively in your output that](https://youtu.be/kMghsCXZQ9Y?t=00h36m42s)



[just automatically updates as things go](https://youtu.be/kMghsCXZQ9Y?t=00h36m45s)



[through](https://youtu.be/kMghsCXZQ9Y?t=00h36m47s)



[and here is another example of that same](https://youtu.be/kMghsCXZQ9Y?t=00h36m51s)



[approach which were the moby-dick output](https://youtu.be/kMghsCXZQ9Y?t=00h36m57s)



[that we were showing before you know](https://youtu.be/kMghsCXZQ9Y?t=00h37m01s)



[that's that's isn't the code for that](https://youtu.be/kMghsCXZQ9Y?t=00h37m03s)



[you can look at that there's a code here](https://youtu.be/kMghsCXZQ9Y?t=00h37m05s)



[here I do think that looks like a bug](https://youtu.be/kMghsCXZQ9Y?t=00h37m28s)



[there because it seems like call me](https://youtu.be/kMghsCXZQ9Y?t=00h37m36s)



[appears to be bold what appeared people](https://youtu.be/kMghsCXZQ9Y?t=00h37m37s)



[all right yeah](https://youtu.be/kMghsCXZQ9Y?t=00h37m41s)



[call me right at the beginning whereas](https://youtu.be/kMghsCXZQ9Y?t=00h37m42s)



[you're bold on starts at the end of that](https://youtu.be/kMghsCXZQ9Y?t=00h37m44s)



[yeah so like we said there's there's](https://youtu.be/kMghsCXZQ9Y?t=00h37m48s)



[there's bugs like this it doesn't take](https://youtu.be/kMghsCXZQ9Y?t=00h37m52s)



[too long playing with this rendering](https://youtu.be/kMghsCXZQ9Y?t=00h37m53s)



[playground app to start to find some of](https://youtu.be/kMghsCXZQ9Y?t=00h37m55s)



[the rough edges and bugs in this area](https://youtu.be/kMghsCXZQ9Y?t=00h37m57s)



[yeah this was definitely you know the](https://youtu.be/kMghsCXZQ9Y?t=00h38m02s)



[goal of the rendering playground was to](https://youtu.be/kMghsCXZQ9Y?t=00h38m05s)



[make it easier to really interact with](https://youtu.be/kMghsCXZQ9Y?t=00h38m07s)



[through this functionality and see what](https://youtu.be/kMghsCXZQ9Y?t=00h38m09s)



[it's doing on the screen which is really](https://youtu.be/kMghsCXZQ9Y?t=00h38m13s)



[very helpful there's another year yeah](https://youtu.be/kMghsCXZQ9Y?t=00h38m15s)



[so we have this kind of approach here](https://youtu.be/kMghsCXZQ9Y?t=00h38m22s)



[but then you can also because it's all](https://youtu.be/kMghsCXZQ9Y?t=00h38m24s)



[just strings you could imagine extension](https://youtu.be/kMghsCXZQ9Y?t=00h38m25s)



[methods that do the wrapping in the](https://youtu.be/kMghsCXZQ9Y?t=00h38m27s)



[eighth to the vt100](https://youtu.be/kMghsCXZQ9Y?t=00h38m29s)



[so what is this thing do you want to](https://youtu.be/kMghsCXZQ9Y?t=00h38m30s)



[look at the output of this sir what's a](https://youtu.be/kMghsCXZQ9Y?t=00h38m32s)



[the bt100 output](https://youtu.be/kMghsCXZQ9Y?t=00h38m34s)



[[Music]](https://youtu.be/kMghsCXZQ9Y?t=00h38m42s)



[but without fail if you play around with](https://youtu.be/kMghsCXZQ9Y?t=00h38m47s)



[some of this VT stuff you will](https://youtu.be/kMghsCXZQ9Y?t=00h38m50s)



[inevitably get yourself into the](https://youtu.be/kMghsCXZQ9Y?t=00h38m52s)



[settings where you break Oh interesting](https://youtu.be/kMghsCXZQ9Y?t=00h38m53s)



[well](https://youtu.be/kMghsCXZQ9Y?t=00h39m06s)



[I'd have to look at what those control](https://youtu.be/kMghsCXZQ9Y?t=00h39m09s)



[characters are but there's definitely do](https://youtu.be/kMghsCXZQ9Y?t=00h39m10s)



[that one could be that yeah I'm seeing](https://youtu.be/kMghsCXZQ9Y?t=00h39m16s)



[stuff before so I think the first one is](https://youtu.be/kMghsCXZQ9Y?t=00h39m19s)



[to clear the screen well that could be](https://youtu.be/kMghsCXZQ9Y?t=00h39m26s)



[you know if we had a good VP parser we](https://youtu.be/kMghsCXZQ9Y?t=00h39m30s)



[could group we could create a much](https://youtu.be/kMghsCXZQ9Y?t=00h39m34s)



[better than the bugging experience here](https://youtu.be/kMghsCXZQ9Y?t=00h39m35s)



[if anyone would like to write one or](https://youtu.be/kMghsCXZQ9Y?t=00h39m38s)



[recommend one please let us know I'll](https://youtu.be/kMghsCXZQ9Y?t=00h39m40s)



[let you know what I can do there so the](https://youtu.be/kMghsCXZQ9Y?t=00h39m46s)



[other thing we can do is we can search](https://youtu.be/kMghsCXZQ9Y?t=00h39m49s)



[for it right we can go okay we've got](https://youtu.be/kMghsCXZQ9Y?t=00h39m50s)



[this thing typically typically it's your](https://youtu.be/kMghsCXZQ9Y?t=00h39m51s)



[the the question mark square brace and](https://youtu.be/kMghsCXZQ9Y?t=00h39m56s)



[then the numeric is what's important I](https://youtu.be/kMghsCXZQ9Y?t=00h39m59s)



[think that I think the semicolon is what](https://youtu.be/kMghsCXZQ9Y?t=00h40m02s)



[precedes parameters yeah I think so](https://youtu.be/kMghsCXZQ9Y?t=00h40m06s)



[try that the nice part about vt100 is](https://youtu.be/kMghsCXZQ9Y?t=00h40m10s)



[it's been around for so many decades](https://youtu.be/kMghsCXZQ9Y?t=00h40m15s)



[that there's lots of documentation it](https://youtu.be/kMghsCXZQ9Y?t=00h40m17s)



[just usually shows up on webpages that](https://youtu.be/kMghsCXZQ9Y?t=00h40m20s)



[look like they were created and 20 years](https://youtu.be/kMghsCXZQ9Y?t=00h40m22s)



[ago yeah I'm curious as to why we're not](https://youtu.be/kMghsCXZQ9Y?t=00h40m25s)



[finding this well this this is the I](https://youtu.be/kMghsCXZQ9Y?t=00h40m28s)



[guess you were just doing straight text](https://youtu.be/kMghsCXZQ9Y?t=00h40m39s)



[search on it](https://youtu.be/kMghsCXZQ9Y?t=00h40m41s)



[Oh probably because you have in the ANSI](https://youtu.be/kMghsCXZQ9Y?t=00h40m41s)



[control character class there the I](https://youtu.be/kMghsCXZQ9Y?t=00h40m47s)



[think the square brace is part of that](https://youtu.be/kMghsCXZQ9Y?t=00h40m50s)



[starting](https://youtu.be/kMghsCXZQ9Y?t=00h40m53s)



[yeah which is so I think it's actually](https://youtu.be/kMghsCXZQ9Y?t=00h40m56s)



[separate strings oh right yeah so if we](https://youtu.be/kMghsCXZQ9Y?t=00h40m59s)



[look at this we've got 88 references to](https://youtu.be/kMghsCXZQ9Y?t=00h41m02s)



[this class we can find a place where we](https://youtu.be/kMghsCXZQ9Y?t=00h41m04s)



[define these also entity control code no](https://youtu.be/kMghsCXZQ9Y?t=00h41m06s)



[not that one we're looking for](https://youtu.be/kMghsCXZQ9Y?t=00h41m09s)



[I'm just looking where that says ansi](https://youtu.be/kMghsCXZQ9Y?t=00h41m16s)



[escape](https://youtu.be/kMghsCXZQ9Y?t=00h41m18s)



[look we've got a class that has like a](https://youtu.be/kMghsCXZQ9Y?t=00h41m28s)



[whole yeah the one right above it and](https://youtu.be/kMghsCXZQ9Y?t=00h41m31s)



[that's that's why we're not finding it](https://youtu.be/kMghsCXZQ9Y?t=00h41m35s)



[when we search yeah yeah so let's go](https://youtu.be/kMghsCXZQ9Y?t=00h41m38s)



[back here we could bold on with the](https://youtu.be/kMghsCXZQ9Y?t=00h41m49s)



[first one when I go to bold on that's](https://youtu.be/kMghsCXZQ9Y?t=00h42m00s)



[the first one we know of and that one](https://youtu.be/kMghsCXZQ9Y?t=00h42m03s)



[Brenda](https://youtu.be/kMghsCXZQ9Y?t=00h42m14s)



[who's calling me so bold on has got to](https://youtu.be/kMghsCXZQ9Y?t=00h42m20s)



[be either that one M or four M guy right](https://youtu.be/kMghsCXZQ9Y?t=00h42m23s)



[there guessing](https://youtu.be/kMghsCXZQ9Y?t=00h42m26s)



[so yeah what these are doing is they're](https://youtu.be/kMghsCXZQ9Y?t=00h42m38s)



[just wrapping that oddly hard didn't](https://youtu.be/kMghsCXZQ9Y?t=00h42m39s)



[have it be able to well if I remember](https://youtu.be/kMghsCXZQ9Y?t=00h42m48s)



[right the style span there's a bit of a](https://youtu.be/kMghsCXZQ9Y?t=00h42m49s)



[visitor pattern there where it then](https://youtu.be/kMghsCXZQ9Y?t=00h42m52s)



[translates it into these ANSI codes](https://youtu.be/kMghsCXZQ9Y?t=00h42m54s)



[because the yeah the span because we](https://youtu.be/kMghsCXZQ9Y?t=00h42m57s)



[don't know whether it's going to be](https://youtu.be/kMghsCXZQ9Y?t=00h43m00s)



[written out with an C or not yep there's](https://youtu.be/kMghsCXZQ9Y?t=00h43m02s)



[different visitors when it's parsing](https://youtu.be/kMghsCXZQ9Y?t=00h43m06s)



[that formattable string into it so bold](https://youtu.be/kMghsCXZQ9Y?t=00h43m08s)



[on one M so there it is that's in the](https://youtu.be/kMghsCXZQ9Y?t=00h43m12s)



[correct place but the other thing over](https://youtu.be/kMghsCXZQ9Y?t=00h43m19s)



[here seems to be yeah whatever that](https://youtu.be/kMghsCXZQ9Y?t=00h43m21s)



[whatever six is seems to be confusing it](https://youtu.be/kMghsCXZQ9Y?t=00h43m25s)



[I feel like we are not ripening backs I](https://youtu.be/kMghsCXZQ9Y?t=00h43m39s)



[couldn't find it but maybe I'm it maybe](https://youtu.be/kMghsCXZQ9Y?t=00h43m43s)



[it's in one of these things so if you](https://youtu.be/kMghsCXZQ9Y?t=00h43m46s)



[had a thing that we can always do of](https://youtu.be/kMghsCXZQ9Y?t=00h43m48s)



[course is we can search for it](https://youtu.be/kMghsCXZQ9Y?t=00h43m49s)



[so if this escape character here that's](https://youtu.be/kMghsCXZQ9Y?t=00h44m05s)



[this then we have the defined we have a](https://youtu.be/kMghsCXZQ9Y?t=00h44m09s)



[constant for them to escape okay it's](https://youtu.be/kMghsCXZQ9Y?t=00h44m12s)



[apparently in the vs code terminal](https://youtu.be/kMghsCXZQ9Y?t=00h44m17s)



[renders is a question mark I think your](https://youtu.be/kMghsCXZQ9Y?t=00h44m19s)



[debt when it rendered it is a weird box](https://youtu.be/kMghsCXZQ9Y?t=00h44m21s)



[for Unicode something or another yeah](https://youtu.be/kMghsCXZQ9Y?t=00h44m23s)



[and there's all these different](https://youtu.be/kMghsCXZQ9Y?t=00h44m35s)



[categories as well you can find it in](https://youtu.be/kMghsCXZQ9Y?t=00h44m37s)



[here](https://youtu.be/kMghsCXZQ9Y?t=00h44m40s)



[rapid lungs](https://youtu.be/kMghsCXZQ9Y?t=00h44m45s)



[because that](https://youtu.be/kMghsCXZQ9Y?t=00h44m49s)



[the other thing is it's sometimes](https://youtu.be/kMghsCXZQ9Y?t=00h45m12s)



[possible for things like this to be](https://youtu.be/kMghsCXZQ9Y?t=00h45m14s)



[let's see I think we just I think during](https://youtu.be/kMghsCXZQ9Y?t=00h45m17s)



[render we render something else to](https://youtu.be/kMghsCXZQ9Y?t=00h45m19s)



[prepare the screen right we clear the](https://youtu.be/kMghsCXZQ9Y?t=00h45m21s)



[screen you're clear second segment was](https://youtu.be/kMghsCXZQ9Y?t=00h45m23s)



[at the bottom it could also be a move oh](https://youtu.be/kMghsCXZQ9Y?t=00h45m33s)



[that could be it](https://youtu.be/kMghsCXZQ9Y?t=00h45m36s)



[I'm looking at how like the the move or](https://youtu.be/kMghsCXZQ9Y?t=00h45m38s)



[the clear where it's parameterised after](https://youtu.be/kMghsCXZQ9Y?t=00h45m42s)



[the square brace so that six maybe](https://youtu.be/kMghsCXZQ9Y?t=00h45m47s)



[something else actually it's not there](https://youtu.be/kMghsCXZQ9Y?t=00h45m49s)



[look at the cursor one I think it's the](https://youtu.be/kMghsCXZQ9Y?t=00h45m56s)



[next one up](https://youtu.be/kMghsCXZQ9Y?t=00h45m59s)



[yeah I'm wondering it was something like](https://youtu.be/kMghsCXZQ9Y?t=00h46m16s)



[this here it it it's moving that's so](https://youtu.be/kMghsCXZQ9Y?t=00h46m19s)



[move got it that's what it is that's why](https://youtu.be/kMghsCXZQ9Y?t=00h46m22s)



[we couldn't search for it yep](https://youtu.be/kMghsCXZQ9Y?t=00h46m28s)



[the H should have been a dead giveaway](https://youtu.be/kMghsCXZQ9Y?t=00h46m30s)



[yeah so that H is the one that's kind of](https://youtu.be/kMghsCXZQ9Y?t=00h46m35s)



[interesting so yeah it has many](https://youtu.be/kMghsCXZQ9Y?t=00h46m37s)



[different parameters we've you can even](https://youtu.be/kMghsCXZQ9Y?t=00h46m39s)



[get a flavor here for the API that we](https://youtu.be/kMghsCXZQ9Y?t=00h46m41s)



[have a below level API that we have for](https://youtu.be/kMghsCXZQ9Y?t=00h46m43s)



[ante output which is what you know for](https://youtu.be/kMghsCXZQ9Y?t=00h46m45s)



[the ones that take inputs we've created](https://youtu.be/kMghsCXZQ9Y?t=00h46m47s)



[functions for them here's another one](https://youtu.be/kMghsCXZQ9Y?t=00h46m48s)



[for sending that RGB colors one of the](https://youtu.be/kMghsCXZQ9Y?t=00h46m52s)



[things that it was probably not super](https://youtu.be/kMghsCXZQ9Y?t=00h46m55s)



[noticeable but the hard to be colors for](https://youtu.be/kMghsCXZQ9Y?t=00h46m58s)



[the mobi sample are specified they're](https://youtu.be/kMghsCXZQ9Y?t=00h47m01s)



[not just your standard sort of 1615](https://youtu.be/kMghsCXZQ9Y?t=00h47m04s)



[console colors and it is worth noting](https://youtu.be/kMghsCXZQ9Y?t=00h47m07s)



[too that we have seen slight differences](https://youtu.be/kMghsCXZQ9Y?t=00h47m10s)



[between the windows and NICs terminals](https://youtu.be/kMghsCXZQ9Y?t=00h47m12s)



[which is really unfortunate it's getting](https://youtu.be/kMghsCXZQ9Y?t=00h47m15s)



[a lot better especially with the new](https://youtu.be/kMghsCXZQ9Y?t=00h47m18s)



[terminal stuff on the latest version of](https://youtu.be/kMghsCXZQ9Y?t=00h47m21s)



[Windows 10 so if you're on like the](https://youtu.be/kMghsCXZQ9Y?t=00h47m24s)



[insider previews of Windows you're](https://youtu.be/kMghsCXZQ9Y?t=00h47m26s)



[probably going to have a much better](https://youtu.be/kMghsCXZQ9Y?t=00h47m28s)



[experience than if you're on say an old](https://youtu.be/kMghsCXZQ9Y?t=00h47m30s)



[version of Windows 10 so just keep that](https://youtu.be/kMghsCXZQ9Y?t=00h47m32s)



[in mind yeah yeah and the new Windows](https://youtu.be/kMghsCXZQ9Y?t=00h47m37s)



[terminal won't standardize this even](https://youtu.be/kMghsCXZQ9Y?t=00h47m40s)



[further right which would be excellent](https://youtu.be/kMghsCXZQ9Y?t=00h47m41s)



[cool](https://youtu.be/kMghsCXZQ9Y?t=00h47m53s)



[sweet](https://youtu.be/kMghsCXZQ9Y?t=00h47m59s)



[what not well I was gonna say what do](https://youtu.be/kMghsCXZQ9Y?t=00h48m02s)



[you want what do you want to go after we](https://youtu.be/kMghsCXZQ9Y?t=00h48m05s)



[can we can you could run down trying to](https://youtu.be/kMghsCXZQ9Y?t=00h48m07s)



[fix one of these bugs we could go](https://youtu.be/kMghsCXZQ9Y?t=00h48m11s)



[through and do a demo of actually using](https://youtu.be/kMghsCXZQ9Y?t=00h48m15s)



[this to build something if we wanted to](https://youtu.be/kMghsCXZQ9Y?t=00h48m17s)



[I'm happy in the right um fix the puck](https://youtu.be/kMghsCXZQ9Y?t=00h48m26s)



[says Xavier okay well let let's continue](https://youtu.be/kMghsCXZQ9Y?t=00h48m32s)



[down this path in and see if we can](https://youtu.be/kMghsCXZQ9Y?t=00h48m36s)



[actually fix this demo so that it works](https://youtu.be/kMghsCXZQ9Y?t=00h48m37s)



[the way we expect so real quick can you](https://youtu.be/kMghsCXZQ9Y?t=00h48m40s)



[run this one more time](https://youtu.be/kMghsCXZQ9Y?t=00h48m45s)



[I'm curious run it in your PowerShell](https://youtu.be/kMghsCXZQ9Y?t=00h48m46s)



[terminal all right I don't know what I](https://youtu.be/kMghsCXZQ9Y?t=00h48m50s)



[don't know what the terminal technology](https://youtu.be/kMghsCXZQ9Y?t=00h48m53s)



[is that's I realized the terminal is](https://youtu.be/kMghsCXZQ9Y?t=00h48m54s)



[listed there as powershell vs code but i](https://youtu.be/kMghsCXZQ9Y?t=00h48m57s)



[am curious if we see a different](https://youtu.be/kMghsCXZQ9Y?t=00h49m00s)



[behavior there](https://youtu.be/kMghsCXZQ9Y?t=00h49m05s)



[so here's that the output vt100 won't](https://youtu.be/kMghsCXZQ9Y?t=00h49m15s)



[look the same and it starts with a](https://youtu.be/kMghsCXZQ9Y?t=00h49m19s)



[positioning thing and then the bold](https://youtu.be/kMghsCXZQ9Y?t=00h49m21s)



[thing happens later it looks correct and](https://youtu.be/kMghsCXZQ9Y?t=00h49m22s)



[I'm going to enable VT so this defaults](https://youtu.be/kMghsCXZQ9Y?t=00h49m30s)



[to true but I call the Senate route of](https://youtu.be/kMghsCXZQ9Y?t=00h49m33s)



[the line interesting so the other thing](https://youtu.be/kMghsCXZQ9Y?t=00h49m36s)



[that it could be that's that's also](https://youtu.be/kMghsCXZQ9Y?t=00h49m44s)



[worth noting is we may not actually have](https://youtu.be/kMghsCXZQ9Y?t=00h49m46s)



[a bug here per se or at least a bug may](https://youtu.be/kMghsCXZQ9Y?t=00h49m48s)



[not necessarily be with this demo](https://youtu.be/kMghsCXZQ9Y?t=00h49m51s)



[because when you're doing the VT control](https://youtu.be/kMghsCXZQ9Y?t=00h49m52s)



[character stuff it it's very possible](https://youtu.be/kMghsCXZQ9Y?t=00h49m55s)



[that you can get your terminal into bad](https://youtu.be/kMghsCXZQ9Y?t=00h49m57s)



[states or inconsistent states where if](https://youtu.be/kMghsCXZQ9Y?t=00h50m01s)



[one app doesn't properly clean itself up](https://youtu.be/kMghsCXZQ9Y?t=00h50m04s)



[yeah next app running ends up picking up](https://youtu.be/kMghsCXZQ9Y?t=00h50m06s)



[some of the the formatting or whatever](https://youtu.be/kMghsCXZQ9Y?t=00h50m10s)



[the leftover settings were that weren't](https://youtu.be/kMghsCXZQ9Y?t=00h50m12s)



[properly undone so it's very possible](https://youtu.be/kMghsCXZQ9Y?t=00h50m13s)



[especially if like one of these apps](https://youtu.be/kMghsCXZQ9Y?t=00h50m15s)



[crashes mid run that it hasn't properly](https://youtu.be/kMghsCXZQ9Y?t=00h50m18s)



[reset some of the state that it was in](https://youtu.be/kMghsCXZQ9Y?t=00h50m21s)



[so you end up with you know your](https://youtu.be/kMghsCXZQ9Y?t=00h50m24s)



[terminal running and you see this in a](https://youtu.be/kMghsCXZQ9Y?t=00h50m26s)



[lot of different terminal apps that even](https://youtu.be/kMghsCXZQ9Y?t=00h50m28s)



[do things with like colors if they get](https://youtu.be/kMghsCXZQ9Y?t=00h50m29s)



[into errors a lot of times they don't](https://youtu.be/kMghsCXZQ9Y?t=00h50m31s)



[necessarily undo say the foreground](https://youtu.be/kMghsCXZQ9Y?t=00h50m33s)



[color that they set and so then your](https://youtu.be/kMghsCXZQ9Y?t=00h50m35s)



[terminals stuck in a weird foreground](https://youtu.be/kMghsCXZQ9Y?t=00h50m37s)



[color until you reset it yeah](https://youtu.be/kMghsCXZQ9Y?t=00h50m39s)



[which could have been the case that we](https://youtu.be/kMghsCXZQ9Y?t=00h50m42s)



[have here which might mean that there is](https://youtu.be/kMghsCXZQ9Y?t=00h50m43s)



[no bug well so let's try to us](https://youtu.be/kMghsCXZQ9Y?t=00h50m45s)



[let's close video code and reopen it](https://youtu.be/kMghsCXZQ9Y?t=00h50m48s)



[whoa oh right so what I'm doing here](https://youtu.be/kMghsCXZQ9Y?t=00h51m06s)



[arkaid of the build system that we use](https://youtu.be/kMghsCXZQ9Y?t=00h51m16s)



[about that got a lot of great stuff for](https://youtu.be/kMghsCXZQ9Y?t=00h51m18s)



[us you know manage assign build multiple](https://youtu.be/kMghsCXZQ9Y?t=00h51m20s)



[operating system tasks and things like](https://youtu.be/kMghsCXZQ9Y?t=00h51m23s)



[this um but because we're we're](https://youtu.be/kMghsCXZQ9Y?t=00h51m25s)



[replacing a bunch of them as build](https://youtu.be/kMghsCXZQ9Y?t=00h51m27s)



[targets with RK which isn't always ideal](https://youtu.be/kMghsCXZQ9Y?t=00h51m29s)



[on a local dev environment like it'll](https://youtu.be/kMghsCXZQ9Y?t=00h51m31s)



[it'll pull down a very specific version](https://youtu.be/kMghsCXZQ9Y?t=00h51m33s)



[of a Java SDK for example do a bunch of](https://youtu.be/kMghsCXZQ9Y?t=00h51m35s)



[other stuff that maybe you know what you](https://youtu.be/kMghsCXZQ9Y?t=00h51m37s)



[want for just a quick inner loop out of](https://youtu.be/kMghsCXZQ9Y?t=00h51m39s)



[that so we have this flag to disable](https://youtu.be/kMghsCXZQ9Y?t=00h51m41s)



[that is a very good you know my](https://youtu.be/kMghsCXZQ9Y?t=00h51m44s)



[PowerShell windows I was forget it there](https://youtu.be/kMghsCXZQ9Y?t=00h51m49s)



[because for PowerShell like the](https://youtu.be/kMghsCXZQ9Y?t=00h51m51s)



[standalone PowerShell which uses a](https://youtu.be/kMghsCXZQ9Y?t=00h51m54s)



[different profile than the PowerShell](https://youtu.be/kMghsCXZQ9Y?t=00h51m56s)



[that's embedded in vs code I just have](https://youtu.be/kMghsCXZQ9Y?t=00h51m59s)



[this set up in my profile so it's always](https://youtu.be/kMghsCXZQ9Y?t=00h52m01s)



[there I guess I should do the same thing](https://youtu.be/kMghsCXZQ9Y?t=00h52m03s)



[from if we don't have this document it's](https://youtu.be/kMghsCXZQ9Y?t=00h52m08s)



[somewhere unlike our readme we might](https://youtu.be/kMghsCXZQ9Y?t=00h52m11s)



[might consider adding that because I](https://youtu.be/kMghsCXZQ9Y?t=00h52m14s)



[could see that I know we got bit by this](https://youtu.be/kMghsCXZQ9Y?t=00h52m16s)



[we've done a couple hackathons on this](https://youtu.be/kMghsCXZQ9Y?t=00h52m19s)



[project yeah and I think without fail](https://youtu.be/kMghsCXZQ9Y?t=00h52m21s)



[every single person in the hackathon has](https://youtu.be/kMghsCXZQ9Y?t=00h52m24s)



[gotten bit by it](https://youtu.be/kMghsCXZQ9Y?t=00h52m26s)



[aha so there we are so it so I'm gonna](https://youtu.be/kMghsCXZQ9Y?t=00h52m28s)



[guess that we ran something that left us](https://youtu.be/kMghsCXZQ9Y?t=00h52m33s)



[in a bad state and I don't remember I'd](https://youtu.be/kMghsCXZQ9Y?t=00h52m37s)



[probably have to go back over the stream](https://youtu.be/kMghsCXZQ9Y?t=00h52m42s)



[to try and figure out what the heck the](https://youtu.be/kMghsCXZQ9Y?t=00h52m44s)



[order was that we ran that's a beauty of](https://youtu.be/kMghsCXZQ9Y?t=00h52m46s)



[this stream John now we can actually go](https://youtu.be/kMghsCXZQ9Y?t=00h52m47s)



[back and re-watch the the first 50](https://youtu.be/kMghsCXZQ9Y?t=00h52m50s)



[minutes to see what was the order of](https://youtu.be/kMghsCXZQ9Y?t=00h52m54s)



[things that we ran in that window oh](https://youtu.be/kMghsCXZQ9Y?t=00h52m56s)



[yeah I think I think you've identified](https://youtu.be/kMghsCXZQ9Y?t=00h52m57s)



[the the basic problem though it's kind](https://youtu.be/kMghsCXZQ9Y?t=00h53m00s)



[of hard to actually we do have a hook in](https://youtu.be/kMghsCXZQ9Y?t=00h53m02s)



[place that was a community contribution](https://youtu.be/kMghsCXZQ9Y?t=00h53m04s)



[to allow you to hook your program such](https://youtu.be/kMghsCXZQ9Y?t=00h53m06s)



[that when what cancels is sent you can](https://youtu.be/kMghsCXZQ9Y?t=00h53m09s)



[block a cancel and runs on clean up code](https://youtu.be/kMghsCXZQ9Y?t=00h53m12s)



[before shell](https://youtu.be/kMghsCXZQ9Y?t=00h53m14s)



[down right so please be good citizens](https://youtu.be/kMghsCXZQ9Y?t=00h53m15s)



[and clean up any formatting or whatnot](https://youtu.be/kMghsCXZQ9Y?t=00h53m18s)



[that you've set for the most part the](https://youtu.be/kMghsCXZQ9Y?t=00h53m20s)



[the rendering stuff in the system](https://youtu.be/kMghsCXZQ9Y?t=00h53m23s)



[command-line rendering does try to](https://youtu.be/kMghsCXZQ9Y?t=00h53m26s)



[handle that as much for you as possible](https://youtu.be/kMghsCXZQ9Y?t=00h53m29s)



[so if you're if you're laying out a](https://youtu.be/kMghsCXZQ9Y?t=00h53m31s)



[bunch of views it will go through and](https://youtu.be/kMghsCXZQ9Y?t=00h53m33s)



[you know toggle it on and off but](https://youtu.be/kMghsCXZQ9Y?t=00h53m35s)



[something like this where you've got](https://youtu.be/kMghsCXZQ9Y?t=00h53m37s)



[bold on bold off if you don't properly](https://youtu.be/kMghsCXZQ9Y?t=00h53m38s)



[match those tags there's nothing in](https://youtu.be/kMghsCXZQ9Y?t=00h53m41s)



[there to to verify that you've done that](https://youtu.be/kMghsCXZQ9Y?t=00h53m44s)



[the other thing is like nesting tags](https://youtu.be/kMghsCXZQ9Y?t=00h53m51s)



[doesn't always work and that's kind of](https://youtu.be/kMghsCXZQ9Y?t=00h53m54s)



[Terminal specific so there's also stuff](https://youtu.be/kMghsCXZQ9Y?t=00h53m56s)



[like that that see you actually hold on](https://youtu.be/kMghsCXZQ9Y?t=00h53m57s)



[John Oh John I think you may have just](https://youtu.be/kMghsCXZQ9Y?t=00h54m03s)



[hit it look at that call me Ishmael is](https://youtu.be/kMghsCXZQ9Y?t=00h54m05s)



[now bolded again I'm wondering so](https://youtu.be/kMghsCXZQ9Y?t=00h54m10s)



[speculative don't know this for a fact](https://youtu.be/kMghsCXZQ9Y?t=00h54m12s)



[but note the size of the window that](https://youtu.be/kMghsCXZQ9Y?t=00h54m14s)



[you're running I'm wondering if what's](https://youtu.be/kMghsCXZQ9Y?t=00h54m16s)



[happening is it's is at the end of that](https://youtu.be/kMghsCXZQ9Y?t=00h54m18s)



[output it's got the bull Don Flag it](https://youtu.be/kMghsCXZQ9Y?t=00h54m20s)



[runs out of space and never outputs the](https://youtu.be/kMghsCXZQ9Y?t=00h54m22s)



[bold off tag so it leaves the terminal](https://youtu.be/kMghsCXZQ9Y?t=00h54m27s)



[output bolded maybe maybe this is](https://youtu.be/kMghsCXZQ9Y?t=00h54m29s)



[something that you can actually see if](https://youtu.be/kMghsCXZQ9Y?t=00h54m36s)



[we go back to this window now and run](https://youtu.be/kMghsCXZQ9Y?t=00h54m38s)



[this again I did I took out the code](https://youtu.be/kMghsCXZQ9Y?t=00h54m39s)



[that was underlining and you can see](https://youtu.be/kMghsCXZQ9Y?t=00h54m42s)



[here it actually looked looks like it's](https://youtu.be/kMghsCXZQ9Y?t=00h54m43s)



[bolded through call here as well kind of](https://youtu.be/kMghsCXZQ9Y?t=00h54m45s)



[hard to tell I mean let me increase the](https://youtu.be/kMghsCXZQ9Y?t=00h54m51s)



[size of this terminal what about Xavier](https://youtu.be/kMghsCXZQ9Y?t=00h54m54s)



[the answer is bold working yes I think](https://youtu.be/kMghsCXZQ9Y?t=00h54m58s)



[I'm a hard to tell ya in the PowerShell](https://youtu.be/kMghsCXZQ9Y?t=00h55m05s)



[into it I don't I don't I don't know but](https://youtu.be/kMghsCXZQ9Y?t=00h55m09s)



[doing bold at all this is those weird](https://youtu.be/kMghsCXZQ9Y?t=00h55m11s)



[bits of the vt100 is you're the terminal](https://youtu.be/kMghsCXZQ9Y?t=00h55m16s)



[that you're running you can send the](https://youtu.be/kMghsCXZQ9Y?t=00h55m20s)



[commands and your terminal can say thank](https://youtu.be/kMghsCXZQ9Y?t=00h55m22s)



[you very much and choose how much of the](https://youtu.be/kMghsCXZQ9Y?t=00h55m24s)



[the spec it's gonna follow I mean it](https://youtu.be/kMghsCXZQ9Y?t=00h55m29s)



[could even be font related to like if](https://youtu.be/kMghsCXZQ9Y?t=00h55m32s)



[the if the output font doesn't support](https://youtu.be/kMghsCXZQ9Y?t=00h55m34s)



[bold it wouldn't matter what vt100 code](https://youtu.be/kMghsCXZQ9Y?t=00h55m36s)



[you sent if the font that it goes to](https://youtu.be/kMghsCXZQ9Y?t=00h55m42s)



[render doesn't actually support bold as](https://youtu.be/kMghsCXZQ9Y?t=00h55m44s)



[well but yeah exactly a lot of variables](https://youtu.be/kMghsCXZQ9Y?t=00h55m46s)



[here that looks like it bolded but again](https://youtu.be/kMghsCXZQ9Y?t=00h55m50s)



[it will be in bolded the whole sentence](https://youtu.be/kMghsCXZQ9Y?t=00h55m52s)



[yes as far as I can tell let's try it](https://youtu.be/kMghsCXZQ9Y?t=00h55m53s)



[with something that's more obvious it](https://youtu.be/kMghsCXZQ9Y?t=00h55m56s)



[don't look like there's some kind of](https://youtu.be/kMghsCXZQ9Y?t=00h55m59s)



[issue there yeah and I do wonder do you](https://youtu.be/kMghsCXZQ9Y?t=00h56m00s)



[have any more bold it's interesting that](https://youtu.be/kMghsCXZQ9Y?t=00h56m04s)



[it's because we only have that one bold](https://youtu.be/kMghsCXZQ9Y?t=00h56m07s)



[style in this thing yeah](https://youtu.be/kMghsCXZQ9Y?t=00h56m12s)



[hmmm that appeared to do nothing](https://youtu.be/kMghsCXZQ9Y?t=00h56m30s)



[okay what the heck yeah hold on](https://youtu.be/kMghsCXZQ9Y?t=00h56m43s)



[methodically knocking people's hats off](https://youtu.be/kMghsCXZQ9Y?t=00h56m49s)



[then it's interesting that I wonder](https://youtu.be/kMghsCXZQ9Y?t=00h56m51s)



[because we have those that reset I](https://youtu.be/kMghsCXZQ9Y?t=00h56m56s)



[wonder if that reset doesn't behave the](https://youtu.be/kMghsCXZQ9Y?t=00h56m59s)



[way we expect yeah so a good portion of](https://youtu.be/kMghsCXZQ9Y?t=00h57m01s)



[this work is figuring out how is vt100](https://youtu.be/kMghsCXZQ9Y?t=00h57m06s)



[supposed to work and then figuring out](https://youtu.be/kMghsCXZQ9Y?t=00h57m08s)



[you know are there differences between](https://youtu.be/kMghsCXZQ9Y?t=00h57m10s)



[different terminals and so some of these](https://youtu.be/kMghsCXZQ9Y?t=00h57m12s)



[bugs will fall into this category of](https://youtu.be/kMghsCXZQ9Y?t=00h57m14s)



[differences between terminals now in the](https://youtu.be/kMghsCXZQ9Y?t=00h57m16s)



[linux world there's n curses which uses](https://youtu.be/kMghsCXZQ9Y?t=00h57m18s)



[basically a database of all these](https://youtu.be/kMghsCXZQ9Y?t=00h57m23s)



[terminal capabilities to solve this](https://youtu.be/kMghsCXZQ9Y?t=00h57m25s)



[problem across a wide variety of](https://youtu.be/kMghsCXZQ9Y?t=00h57m27s)



[terminals you can imagine this project](https://youtu.be/kMghsCXZQ9Y?t=00h57m29s)



[eventually gaining that kind of a](https://youtu.be/kMghsCXZQ9Y?t=00h57m32s)



[knowledge base the thing is there's no](https://youtu.be/kMghsCXZQ9Y?t=00h57m34s)



[there's no equivalent for Windows](https://youtu.be/kMghsCXZQ9Y?t=00h57m36s)



[hopefully we don't need one and then n](https://youtu.be/kMghsCXZQ9Y?t=00h57m37s)



[curses as well as not it doesn't really](https://youtu.be/kMghsCXZQ9Y?t=00h57m40s)



[work great for redirecting output it's](https://youtu.be/kMghsCXZQ9Y?t=00h57m42s)



[really a you know a vt100 only kind of](https://youtu.be/kMghsCXZQ9Y?t=00h57m44s)



[programming environment so right it's](https://youtu.be/kMghsCXZQ9Y?t=00h57m48s)



[meant for pretty output and there is](https://youtu.be/kMghsCXZQ9Y?t=00h57m50s)



[nothing stopping you like if if what](https://youtu.be/kMghsCXZQ9Y?t=00h57m51s)



[you're looking for is like pretty](https://youtu.be/kMghsCXZQ9Y?t=00h57m53s)



[windowing type stuff inside of your CLI](https://youtu.be/kMghsCXZQ9Y?t=00h57m55s)



[there's nothing stopping you from using](https://youtu.be/kMghsCXZQ9Y?t=00h57m57s)



[end curses rather than the system](https://youtu.be/kMghsCXZQ9Y?t=00h57m58s)



[command line rendering like there's](https://youtu.be/kMghsCXZQ9Y?t=00h58m01s)



[there's some things that I suspect n](https://youtu.be/kMghsCXZQ9Y?t=00h58m02s)



[curses will still be the the better](https://youtu.be/kMghsCXZQ9Y?t=00h58m03s)



[answer for oh yeah like if you're if](https://youtu.be/kMghsCXZQ9Y?t=00h58m05s)



[you're looking to build you know some](https://youtu.be/kMghsCXZQ9Y?t=00h58m08s)



[sort of Emacs type equivalent with all](https://youtu.be/kMghsCXZQ9Y?t=00h58m10s)



[kinds of fancy and I in quotes here](https://youtu.be/kMghsCXZQ9Y?t=00h58m12s)



[gooey bits on your CLI that it's](https://youtu.be/kMghsCXZQ9Y?t=00h58m14s)



[probably the better answer it is](https://youtu.be/kMghsCXZQ9Y?t=00h58m17s)



[interesting to I'll point out so in this](https://youtu.be/kMghsCXZQ9Y?t=00h58m20s)



[demo you'll notice that the methodically](https://youtu.be/kMghsCXZQ9Y?t=00h58m22s)



[knocking people's hats off that sentence](https://youtu.be/kMghsCXZQ9Y?t=00h58m26s)



[is theoretically going darker and darker](https://youtu.be/kMghsCXZQ9Y?t=00h58m28s)



[red according to the RGB values yeah but](https://youtu.be/kMghsCXZQ9Y?t=00h58m30s)



[you'll notice in your rendering it only](https://youtu.be/kMghsCXZQ9Y?t=00h58m33s)



[picks one whereas over in your](https://youtu.be/kMghsCXZQ9Y?t=00h58m35s)



[PowerShell you can or I guess it's going](https://youtu.be/kMghsCXZQ9Y?t=00h58m39s)



[lighter and lighter red not darker and](https://youtu.be/kMghsCXZQ9Y?t=00h58m41s)



[darker but regardless more red as it](https://youtu.be/kMghsCXZQ9Y?t=00h58m43s)



[works its way through there is on that](https://youtu.be/kMghsCXZQ9Y?t=00h58m47s)



[Wikipedia page that you pulled up](https://youtu.be/kMghsCXZQ9Y?t=00h58m50s)



[there's a great kind of write-up about](https://youtu.be/kMghsCXZQ9Y?t=00h58m52s)



[the the colors that are supported](https://youtu.be/kMghsCXZQ9Y?t=00h58m54s)



[across different terminals because](https://youtu.be/kMghsCXZQ9Y?t=00h58m57s)



[there's I think a set of like 24](https://youtu.be/kMghsCXZQ9Y?t=00h58m59s)



[different call safe consul colors like](https://youtu.be/kMghsCXZQ9Y?t=00h59m02s)



[if you you if you look in the what is it](https://youtu.be/kMghsCXZQ9Y?t=00h59m08s)



[I think that I think it's just the](https://youtu.be/kMghsCXZQ9Y?t=00h59m10s)



[system duck consul color is the the](https://youtu.be/kMghsCXZQ9Y?t=00h59m12s)



[built-in class that contains the list of](https://youtu.be/kMghsCXZQ9Y?t=00h59m15s)



[the the reduced list of these are the](https://youtu.be/kMghsCXZQ9Y?t=00h59m18s)



[absolutely the only safe colors you can](https://youtu.be/kMghsCXZQ9Y?t=00h59m21s)



[use and I believe in our foreground](https://youtu.be/kMghsCXZQ9Y?t=00h59m24s)



[color span rather than that arbitrary](https://youtu.be/kMghsCXZQ9Y?t=00h59m25s)



[RGB we actually have static properties](https://youtu.be/kMghsCXZQ9Y?t=00h59m27s)



[for all of the safe colors if you're](https://youtu.be/kMghsCXZQ9Y?t=00h59m30s)



[worried about making sure that you pick](https://youtu.be/kMghsCXZQ9Y?t=00h59m32s)



[a good one but if you know you're gonna](https://youtu.be/kMghsCXZQ9Y?t=00h59m34s)



[be running in terminals where yeah](https://youtu.be/kMghsCXZQ9Y?t=00h59m36s)



[so there's your a list of all of the the](https://youtu.be/kMghsCXZQ9Y?t=00h59m38s)



[safe colors but obviously that list is](https://youtu.be/kMghsCXZQ9Y?t=00h59m40s)



[very limited and if you know you're](https://youtu.be/kMghsCXZQ9Y?t=00h59m43s)



[going to be running in terminals that](https://youtu.be/kMghsCXZQ9Y?t=00h59m44s)



[support it well you can take advantage](https://youtu.be/kMghsCXZQ9Y?t=00h59m45s)



[and use a wider palette yeah so I'm](https://youtu.be/kMghsCXZQ9Y?t=00h59m47s)



[gonna put some of this down to just](https://youtu.be/kMghsCXZQ9Y?t=00h59m55s)



[different terminal behaviors right cuz I](https://youtu.be/kMghsCXZQ9Y?t=00h59m56s)



[mean we can at least see the difference](https://youtu.be/kMghsCXZQ9Y?t=00h59m59s)



[in the the foreground color there the](https://youtu.be/kMghsCXZQ9Y?t=01h00m00s)



[the part that does really interest me is](https://youtu.be/kMghsCXZQ9Y?t=01h00m03s)



[why why it seems to be picking up that](https://youtu.be/kMghsCXZQ9Y?t=01h00m05s)



[bold but yeah there is](https://youtu.be/kMghsCXZQ9Y?t=01h00m09s)



[whatever terminal is being run](https://youtu.be/kMghsCXZQ9Y?t=01h00m11s)



[you've got something else still running](https://youtu.be/kMghsCXZQ9Y?t=01h00m20s)



[something else is holding on to that](https://youtu.be/kMghsCXZQ9Y?t=01h00m35s)



[we've got too many terminal windows open](https://youtu.be/kMghsCXZQ9Y?t=01h00m38s)



[now everything's bold I am noticing](https://youtu.be/kMghsCXZQ9Y?t=01h00m50s)



[something the the output that from](https://youtu.be/kMghsCXZQ9Y?t=01h00m58s)



[msbuild does appear to also set some](https://youtu.be/kMghsCXZQ9Y?t=01h01m03s)



[formatting I'm wondering if we might new](https://youtu.be/kMghsCXZQ9Y?t=01h01m06s)



[terminal yeah does you'll notice like](https://youtu.be/kMghsCXZQ9Y?t=01h01m11s)



[even your command line API on the other](https://youtu.be/kMghsCXZQ9Y?t=01h01m17s)



[terminal went bold as well which means](https://youtu.be/kMghsCXZQ9Y?t=01h01m20s)



[something left formatting or something](https://youtu.be/kMghsCXZQ9Y?t=01h01m23s)



[set the flag and then never unset it so](https://youtu.be/kMghsCXZQ9Y?t=01h01m27s)



[let's do this let's do let's not go](https://youtu.be/kMghsCXZQ9Y?t=01h01m30s)



[through them I spilled every single time](https://youtu.be/kMghsCXZQ9Y?t=01h01m35s)



[we run this thing right so we'll do go](https://youtu.be/kMghsCXZQ9Y?t=01h01m36s)



[in here I'll do it dot that publish when](https://youtu.be/kMghsCXZQ9Y?t=01h01m40s)



[x64 is that right](https://youtu.be/kMghsCXZQ9Y?t=01h01m50s)



[so this will produce an executable and](https://youtu.be/kMghsCXZQ9Y?t=01h01m59s)



[then we can run that directly we're not](https://youtu.be/kMghsCXZQ9Y?t=01h02m01s)



[going through dotnet run every time](https://youtu.be/kMghsCXZQ9Y?t=01h02m04s)



[right](https://youtu.be/kMghsCXZQ9Y?t=01h02m05s)



[so I think project](https://youtu.be/kMghsCXZQ9Y?t=01h02m12s)



[oh sorry Xavier I think my my nightbot](https://youtu.be/kMghsCXZQ9Y?t=01h02m19s)



[setup might be a little restrictive](https://youtu.be/kMghsCXZQ9Y?t=01h02m25s)



[yeah Savior has a great link in the the](https://youtu.be/kMghsCXZQ9Y?t=01h02m33s)



[chat as well about testing testing VT](https://youtu.be/kMghsCXZQ9Y?t=01h02m37s)



[109 and the compatibility or more](https://youtu.be/kMghsCXZQ9Y?t=01h02m44s)



[accurately to lack thereof yep yeah this](https://youtu.be/kMghsCXZQ9Y?t=01h02m47s)



[is this is an excellent one and I think](https://youtu.be/kMghsCXZQ9Y?t=01h02m53s)



[you you mentioned it earlier there as](https://youtu.be/kMghsCXZQ9Y?t=01h02m57s)



[well how n curses goes - it handles it](https://youtu.be/kMghsCXZQ9Y?t=01h03m00s)



[because despite there being these nice](https://youtu.be/kMghsCXZQ9Y?t=01h03m06s)



[posted standards there is a there's a](https://youtu.be/kMghsCXZQ9Y?t=01h03m08s)



[constant problem across various](https://youtu.be/kMghsCXZQ9Y?t=01h03m15s)



[terminals of with varying levels of](https://youtu.be/kMghsCXZQ9Y?t=01h03m16s)



[support there's there's unfortunately](https://youtu.be/kMghsCXZQ9Y?t=01h03m19s)



[not a good standardized way of handling](https://youtu.be/kMghsCXZQ9Y?t=01h03m22s)



[it yet but we're getting better](https://youtu.be/kMghsCXZQ9Y?t=01h03m25s)



[so now we can we can do this directly](https://youtu.be/kMghsCXZQ9Y?t=01h03m40s)



[against the executable so we know I must](https://youtu.be/kMghsCXZQ9Y?t=01h03m42s)



[build if not in the picture well](https://youtu.be/kMghsCXZQ9Y?t=01h03m51s)



[actually let's even go start a new](https://youtu.be/kMghsCXZQ9Y?t=01h03m53s)



[terminal](https://youtu.be/kMghsCXZQ9Y?t=01h03m55s)



[oops](https://youtu.be/kMghsCXZQ9Y?t=01h04m11s)



[good news you have no viruses](https://youtu.be/kMghsCXZQ9Y?t=01h04m25s)



[okay](https://youtu.be/kMghsCXZQ9Y?t=01h04m29s)



[[Music]](https://youtu.be/kMghsCXZQ9Y?t=01h04m33s)



[I've removed the bowl now let's put the](https://youtu.be/kMghsCXZQ9Y?t=01h04m37s)



[bowl back we'll start yet another](https://youtu.be/kMghsCXZQ9Y?t=01h04m39s)



[terminal so we don't pollute that one](https://youtu.be/kMghsCXZQ9Y?t=01h04m42s)



[so we'll do our publish again here and](https://youtu.be/kMghsCXZQ9Y?t=01h04m54s)



[then this turn a little our program](https://youtu.be/kMghsCXZQ9Y?t=01h04m57s)



[again hard to tell](https://youtu.be/kMghsCXZQ9Y?t=01h05m00s)



[try it from let's try it from here](https://youtu.be/kMghsCXZQ9Y?t=01h05m12s)



[hold up](https://youtu.be/kMghsCXZQ9Y?t=01h05m28s)



[yeah I was gonna say right before you](https://youtu.be/kMghsCXZQ9Y?t=01h05m33s)



[ran that your publish seemed to go bold](https://youtu.be/kMghsCXZQ9Y?t=01h05m34s)



[already](https://youtu.be/kMghsCXZQ9Y?t=01h05m36s)



[interesting](https://youtu.be/kMghsCXZQ9Y?t=01h05m45s)



[it's weird it's hard to tell it does](https://youtu.be/kMghsCXZQ9Y?t=01h05m47s)



[feel like whatever terminals inside of](https://youtu.be/kMghsCXZQ9Y?t=01h05m56s)



[es code might be yeah yep lying to us](https://youtu.be/kMghsCXZQ9Y?t=01h05m58s)



[well anyway yeah so that's a that's a](https://youtu.be/kMghsCXZQ9Y?t=01h06m13s)



[great example of having to run through](https://youtu.be/kMghsCXZQ9Y?t=01h06m19s)



[some of this stuff just to get very lost](https://youtu.be/kMghsCXZQ9Y?t=01h06m21s)



[and confused and to have issues being](https://youtu.be/kMghsCXZQ9Y?t=01h06m24s)



[terminal related and not necessarily](https://youtu.be/kMghsCXZQ9Y?t=01h06m27s)



[console related let's go through John](https://youtu.be/kMghsCXZQ9Y?t=01h06m31s)



[real quick I think we have a sample in](https://youtu.be/kMghsCXZQ9Y?t=01h06m34s)



[here that does like the grid or the](https://youtu.be/kMghsCXZQ9Y?t=01h06m36s)



[table layout yeah it's like a top](https://youtu.be/kMghsCXZQ9Y?t=01h06m38s)



[equivalent yeah fire that one off if you](https://youtu.be/kMghsCXZQ9Y?t=01h06m44s)



[don't mind it's that one that one's](https://youtu.be/kMghsCXZQ9Y?t=01h06m47s)



[probably worth while taking a look at we](https://youtu.be/kMghsCXZQ9Y?t=01h06m51s)



[can do here now that we actually publish](https://youtu.be/kMghsCXZQ9Y?t=01h06m56s)



[this thing I can't do this](https://youtu.be/kMghsCXZQ9Y?t=01h06m57s)



[from dotnet run Oh can't do it from here](https://youtu.be/kMghsCXZQ9Y?t=01h07m01s)



[either](https://youtu.be/kMghsCXZQ9Y?t=01h07m07s)



[interesting honestly let's try](https://youtu.be/kMghsCXZQ9Y?t=01h07m19s)



[completions are not working](https://youtu.be/kMghsCXZQ9Y?t=01h07m28s)



[okay so that's the scrolling output go](https://youtu.be/kMghsCXZQ9Y?t=01h07m42s)



[back unable of et you will never get a](https://youtu.be/kMghsCXZQ9Y?t=01h07m46s)



[parse error from direct specifying a](https://youtu.be/kMghsCXZQ9Y?t=01h07m54s)



[directive that doesn't actually exist](https://youtu.be/kMghsCXZQ9Y?t=01h07m57s)



[did I do that right yeah and they will -](https://youtu.be/kMghsCXZQ9Y?t=01h08m02s)



[VT so we also want to set the output to](https://youtu.be/kMghsCXZQ9Y?t=01h08m06s)



[answer it's not Auto detecting correctly](https://youtu.be/kMghsCXZQ9Y?t=01h08m09s)



[it'd be nice if this filtered down to](https://youtu.be/kMghsCXZQ9Y?t=01h08m22s)



[the you know it was sort of them in some](https://youtu.be/kMghsCXZQ9Y?t=01h08m23s)



[way according to which at the highest](https://youtu.be/kMghsCXZQ9Y?t=01h08m28s)



[GPU that would be nice have it bounce](https://youtu.be/kMghsCXZQ9Y?t=01h08m30s)



[around a little bit I just think that's](https://youtu.be/kMghsCXZQ9Y?t=01h08m33s)



[yeah so basically this guy is just](https://youtu.be/kMghsCXZQ9Y?t=01h08m37s)



[grabbing forget how it picks the the](https://youtu.be/kMghsCXZQ9Y?t=01h08m39s)



[processes but it grabs the top X number](https://youtu.be/kMghsCXZQ9Y?t=01h08m41s)



[and then goes through and you can see it](https://youtu.be/kMghsCXZQ9Y?t=01h08m44s)



[outputting the one thing that would be](https://youtu.be/kMghsCXZQ9Y?t=01h08m49s)



[nice for it to do is also deal with that](https://youtu.be/kMghsCXZQ9Y?t=01h08m50s)



[because you see the blinking cursor](https://youtu.be/kMghsCXZQ9Y?t=01h08m56s)



[every time it's effective effectively](https://youtu.be/kMghsCXZQ9Y?t=01h08m57s)



[going and repainting the screen on an](https://youtu.be/kMghsCXZQ9Y?t=01h08m59s)



[update yeah because it has to move the](https://youtu.be/kMghsCXZQ9Y?t=01h09m01s)



[cursor around redraw those areas there](https://youtu.be/kMghsCXZQ9Y?t=01h09m03s)



[are ansi codes for hiding the cursor and](https://youtu.be/kMghsCXZQ9Y?t=01h09m08s)



[i think one really nice improvement](https://youtu.be/kMghsCXZQ9Y?t=01h09m12s)



[would be turning the cursor off do the](https://youtu.be/kMghsCXZQ9Y?t=01h09m14s)



[redraw turning it back on if it was on](https://youtu.be/kMghsCXZQ9Y?t=01h09m16s)



[previously yeah yep that's something we](https://youtu.be/kMghsCXZQ9Y?t=01h09m19s)



[could we could probably do yeah let's](https://youtu.be/kMghsCXZQ9Y?t=01h09m24s)



[take a crack at it why not all right](https://youtu.be/kMghsCXZQ9Y?t=01h09m32s)



[let's see so this is the this is the](https://youtu.be/kMghsCXZQ9Y?t=01h09m37s)



[code here like we also want you](https://youtu.be/kMghsCXZQ9Y?t=01h09m40s)



[underlined so this is](https://youtu.be/kMghsCXZQ9Y?t=01h09m44s)



[anyway so weird yeah so where we go here](https://youtu.be/kMghsCXZQ9Y?t=01h09m53s)



[we want to go into the screen view um](https://youtu.be/kMghsCXZQ9Y?t=01h09m56s)



[this is you you're testing my memory](https://youtu.be/kMghsCXZQ9Y?t=01h10m00s)



[it's been so long since I wrote this or](https://youtu.be/kMghsCXZQ9Y?t=01h10m02s)



[one of these visitors but probably the](https://youtu.be/kMghsCXZQ9Y?t=01h10m07s)



[auntie visitor right well so let's let's](https://youtu.be/kMghsCXZQ9Y?t=01h10m10s)



[start at the screen view because I think](https://youtu.be/kMghsCXZQ9Y?t=01h10m15s)



[that was a good place to start because](https://youtu.be/kMghsCXZQ9Y?t=01h10m17s)



[that's ultimately what's triggering so](https://youtu.be/kMghsCXZQ9Y?t=01h10m18s)



[these views they end up working very](https://youtu.be/kMghsCXZQ9Y?t=01h10m20s)



[similar to the way like a windows form](https://youtu.be/kMghsCXZQ9Y?t=01h10m25s)



[or a WPF kind of rendering stack works](https://youtu.be/kMghsCXZQ9Y?t=01h10m28s)



[in that when content changes there's an](https://youtu.be/kMghsCXZQ9Y?t=01h10m33s)



[invalidation notification that](https://youtu.be/kMghsCXZQ9Y?t=01h10m37s)



[propagates its way up to the view](https://youtu.be/kMghsCXZQ9Y?t=01h10m39s)



[hierarchy until it reaches a point where](https://youtu.be/kMghsCXZQ9Y?t=01h10m41s)



[it knows the the size that it needs to](https://youtu.be/kMghsCXZQ9Y?t=01h10m44s)



[deal with and usually in most cases it](https://youtu.be/kMghsCXZQ9Y?t=01h10m47s)



[properly it's just all the way up to the](https://youtu.be/kMghsCXZQ9Y?t=01h10m49s)



[screen view so you'll notice that that](https://youtu.be/kMghsCXZQ9Y?t=01h10m51s)



[updated event down there I believe so](https://youtu.be/kMghsCXZQ9Y?t=01h10m54s)



[jump to the the child updated method](https://youtu.be/kMghsCXZQ9Y?t=01h10m57s)



[yeah and so this this goes through and](https://youtu.be/kMghsCXZQ9Y?t=01h11m00s)



[so the same exact problem that you run](https://youtu.be/kMghsCXZQ9Y?t=01h11m03s)



[into on GUI applications where you can](https://youtu.be/kMghsCXZQ9Y?t=01h11m05s)



[only have a single thread mucking with](https://youtu.be/kMghsCXZQ9Y?t=01h11m08s)



[your UI elements at a time this](https://youtu.be/kMghsCXZQ9Y?t=01h11m11s)



[effectively does the same thing where it](https://youtu.be/kMghsCXZQ9Y?t=01h11m13s)



[uses the context to switch back to the](https://youtu.be/kMghsCXZQ9Y?t=01h11m16s)



[UI thread it'll batch up if it gets a](https://youtu.be/kMghsCXZQ9Y?t=01h11m18s)



[bunch of these updates that comes](https://youtu.be/kMghsCXZQ9Y?t=01h11m22s)



[through at once so that it only posts a](https://youtu.be/kMghsCXZQ9Y?t=01h11m23s)



[single render pass and then it calls](https://youtu.be/kMghsCXZQ9Y?t=01h11m25s)



[render and works its way going back down](https://youtu.be/kMghsCXZQ9Y?t=01h11m27s)



[the UI stack relaying out the views so I](https://youtu.be/kMghsCXZQ9Y?t=01h11m30s)



[guess the question comes in where we](https://youtu.be/kMghsCXZQ9Y?t=01h11m33s)



[want to go about doing this so](https://youtu.be/kMghsCXZQ9Y?t=01h11m36s)



[because go ahead and jump to like that](https://youtu.be/kMghsCXZQ9Y?t=01h11m41s)



[child render method that's probably the](https://youtu.be/kMghsCXZQ9Y?t=01h11m43s)



[closest so like 68 yep there](https://youtu.be/kMghsCXZQ9Y?t=01h11m44s)



[and this is where it's going to get](https://youtu.be/kMghsCXZQ9Y?t=01h11m55s)



[interesting because I don't know if we](https://youtu.be/kMghsCXZQ9Y?t=01h11m57s)



[necessarily have a consistent area well](https://youtu.be/kMghsCXZQ9Y?t=01h11m58s)



[go ahead and jump into like content view](https://youtu.be/kMghsCXZQ9Y?t=01h12m05s)



[because we could theoretically I just](https://youtu.be/kMghsCXZQ9Y?t=01h12m10s)



[wonder if we're gonna get the blinky it](https://youtu.be/kMghsCXZQ9Y?t=01h12m14s)



[like in that render to region etheric](https://youtu.be/kMghsCXZQ9Y?t=01h12m15s)



[Lee theoretically wrap that turning the](https://youtu.be/kMghsCXZQ9Y?t=01h12m19s)



[cursor on and off yep because here we](https://youtu.be/kMghsCXZQ9Y?t=01h12m21s)



[have all the information that we need as](https://youtu.be/kMghsCXZQ9Y?t=01h12m25s)



[far as output mode and C etc etc so we](https://youtu.be/kMghsCXZQ9Y?t=01h12m27s)



[could do it here I just worry that if we](https://youtu.be/kMghsCXZQ9Y?t=01h12m34s)



[do it here we're effectively turning it](https://youtu.be/kMghsCXZQ9Y?t=01h12m36s)



[on and off at each of the content views](https://youtu.be/kMghsCXZQ9Y?t=01h12m37s)



[and so like in that process view there](https://youtu.be/kMghsCXZQ9Y?t=01h12m41s)



[there's a Content view for each one of](https://youtu.be/kMghsCXZQ9Y?t=01h12m44s)



[those effectively cells in that table](https://youtu.be/kMghsCXZQ9Y?t=01h12m46s)



[yeah yeah so I I feel like the the](https://youtu.be/kMghsCXZQ9Y?t=01h12m49s)



[visitor might be up a place where we can](https://youtu.be/kMghsCXZQ9Y?t=01h12m56s)



[control this as well so this is where we](https://youtu.be/kMghsCXZQ9Y?t=01h13m01s)



[you know we sent the cursor to a](https://youtu.be/kMghsCXZQ9Y?t=01h13m03s)



[specific position first and I think](https://youtu.be/kMghsCXZQ9Y?t=01h13m06s)



[there's a stop operation on it gotcha](https://youtu.be/kMghsCXZQ9Y?t=01h13m10s)



[so basically hide it before the set](https://youtu.be/kMghsCXZQ9Y?t=01h13m15s)



[position and then re-enable it after](https://youtu.be/kMghsCXZQ9Y?t=01h13m18s)



[we're done maybe yeah although that](https://youtu.be/kMghsCXZQ9Y?t=01h13m20s)



[would probably enable it yeah that still](https://youtu.be/kMghsCXZQ9Y?t=01h13m26s)



[doesn't actually capturing the complete](https://youtu.be/kMghsCXZQ9Y?t=01h13m28s)



[render operation from start to finish](https://youtu.be/kMghsCXZQ9Y?t=01h13m29s)



[but that that's actually fine though](https://youtu.be/kMghsCXZQ9Y?t=01h13m30s)



[like if we hide it before we move it](https://youtu.be/kMghsCXZQ9Y?t=01h13m33s)



[well but if we reenable it after the](https://youtu.be/kMghsCXZQ9Y?t=01h13m37s)



[right because it won't be back to its](https://youtu.be/kMghsCXZQ9Y?t=01h13m40s)



[original position yet I suspect we'll](https://youtu.be/kMghsCXZQ9Y?t=01h13m43s)



[still see the flashing at the end of the](https://youtu.be/kMghsCXZQ9Y?t=01h13m45s)



[content views so we don't necessarily](https://youtu.be/kMghsCXZQ9Y?t=01h13m47s)



[see the cursor jump to the beginning but](https://youtu.be/kMghsCXZQ9Y?t=01h13m49s)



[we might see it at the very end](https://youtu.be/kMghsCXZQ9Y?t=01h13m52s)



[we could try it let's do it so because](https://youtu.be/kMghsCXZQ9Y?t=01h13m56s)



[this is just a text output stream](https://youtu.be/kMghsCXZQ9Y?t=01h14m02s)



[alright we're just writing text out so](https://youtu.be/kMghsCXZQ9Y?t=01h14m04s)



[this is what the API looks like and all](https://youtu.be/kMghsCXZQ9Y?t=01h14m07s)



[these cursor things right cursor hide so](https://youtu.be/kMghsCXZQ9Y?t=01h14m10s)



[you'll see here right the writer it](https://youtu.be/kMghsCXZQ9Y?t=01h14m19s)



[wants a string cursor hide is an ansi](https://youtu.be/kMghsCXZQ9Y?t=01h14m22s)



[control code the thing that's](https://youtu.be/kMghsCXZQ9Y?t=01h14m25s)



[interesting about empty control codes is](https://youtu.be/kMghsCXZQ9Y?t=01h14m27s)



[that if you to string them I believe](https://youtu.be/kMghsCXZQ9Y?t=01h14m30s)



[they're just empty and that is one of](https://youtu.be/kMghsCXZQ9Y?t=01h14m32s)



[the things that enables you to embed](https://youtu.be/kMghsCXZQ9Y?t=01h14m35s)



[them inside of a interpolated string and](https://youtu.be/kMghsCXZQ9Y?t=01h14m37s)



[render that string on and they're](https://youtu.be/kMghsCXZQ9Y?t=01h14m40s)



[actually they're hidden right you](https://youtu.be/kMghsCXZQ9Y?t=01h14m41s)



[actually need the right renderer to like](https://youtu.be/kMghsCXZQ9Y?t=01h14m42s)



[what Kevin was saying before is like](https://youtu.be/kMghsCXZQ9Y?t=01h14m44s)



[tear them apart find the control code](https://youtu.be/kMghsCXZQ9Y?t=01h14m46s)



[objects that were passed into the](https://youtu.be/kMghsCXZQ9Y?t=01h14m49s)



[interpolated string and render them on](https://youtu.be/kMghsCXZQ9Y?t=01h14m50s)



[condition of you know whether you](https://youtu.be/kMghsCXZQ9Y?t=01h14m53s)



[actually want to render them okay so](https://youtu.be/kMghsCXZQ9Y?t=01h14m57s)



[that just broke a whole bunch of tests](https://youtu.be/kMghsCXZQ9Y?t=01h14m59s)



[but that's okay the real questions we do](https://youtu.be/kMghsCXZQ9Y?t=01h15m01s)



[that and I think I will go back to](https://youtu.be/kMghsCXZQ9Y?t=01h15m05s)



[dotnet running this thing it's usually a](https://youtu.be/kMghsCXZQ9Y?t=01h15m08s)



[good idea to do to clean up the publish](https://youtu.be/kMghsCXZQ9Y?t=01h15m11s)



[folder you got a build error interesting](https://youtu.be/kMghsCXZQ9Y?t=01h15m14s)



[yeah strange trivia anyway](https://youtu.be/kMghsCXZQ9Y?t=01h15m30s)



[so what was that command we were doing](https://youtu.be/kMghsCXZQ9Y?t=01h15m34s)



[along this right but we're going back to](https://youtu.be/kMghsCXZQ9Y?t=01h15m36s)



[down there Ronna mode so we can make](https://youtu.be/kMghsCXZQ9Y?t=01h15m38s)



[changes to the code and not to publish](https://youtu.be/kMghsCXZQ9Y?t=01h15m40s)



[each other](https://youtu.be/kMghsCXZQ9Y?t=01h15m42s)



[okay so the cursor is the resolution you](https://youtu.be/kMghsCXZQ9Y?t=01h15m55s)



[know the frame resolution coming through](https://youtu.be/kMghsCXZQ9Y?t=01h16m00s)



[okay](https://youtu.be/kMghsCXZQ9Y?t=01h16m02s)



[hey look this looks okay like this it's](https://youtu.be/kMghsCXZQ9Y?t=01h16m02s)



[still blinking but I don't see it](https://youtu.be/kMghsCXZQ9Y?t=01h16m05s)



[jumping around as much all right I mean](https://youtu.be/kMghsCXZQ9Y?t=01h16m06s)



[yeah I'm seeing it at different places](https://youtu.be/kMghsCXZQ9Y?t=01h16m10s)



[but it is the the places where I'll see](https://youtu.be/kMghsCXZQ9Y?t=01h16m12s)



[it flash well no there's a couple at the](https://youtu.be/kMghsCXZQ9Y?t=01h16m14s)



[beginning that didn't solve the problem](https://youtu.be/kMghsCXZQ9Y?t=01h16m16s)



[interesting because we really don't have](https://youtu.be/kMghsCXZQ9Y?t=01h16m26s)



[a car](https://youtu.be/kMghsCXZQ9Y?t=01h16m30s)



[we don't necessarily have a good concept](https://youtu.be/kMghsCXZQ9Y?t=01h16m32s)



[of where we are in the rendering of this](https://youtu.be/kMghsCXZQ9Y?t=01h16m34s)



[yeah and the cobble yeah I mean we can](https://youtu.be/kMghsCXZQ9Y?t=01h16m40s)



[go to the screen view level that'll work](https://youtu.be/kMghsCXZQ9Y?t=01h16m53s)



[it has it has the new knowledge I guess](https://youtu.be/kMghsCXZQ9Y?t=01h16m54s)



[because you could wrap that render call](https://youtu.be/kMghsCXZQ9Y?t=01h16m59s)



[yeah we could do it right here right](https://youtu.be/kMghsCXZQ9Y?t=01h17m06s)



[through the whole lit the whole](https://youtu.be/kMghsCXZQ9Y?t=01h17m08s)



[operation or is this one in here no you](https://youtu.be/kMghsCXZQ9Y?t=01h17m09s)



[want to do it up on the 68 okay](https://youtu.be/kMghsCXZQ9Y?t=01h17m13s)



[and this is where it gets interesting](https://youtu.be/kMghsCXZQ9Y?t=01h17m28s)



[because you have to do the render to](https://youtu.be/kMghsCXZQ9Y?t=01h17m30s)



[region](https://youtu.be/kMghsCXZQ9Y?t=01h17m32s)



[we can we can do it this way so matter](https://youtu.be/kMghsCXZQ9Y?t=01h17m37s)



[parse this band](https://youtu.be/kMghsCXZQ9Y?t=01h17m44s)



[let's return this band we render that to](https://youtu.be/kMghsCXZQ9Y?t=01h17m45s)



[up](https://youtu.be/kMghsCXZQ9Y?t=01h17m48s)



[[Music]](https://youtu.be/kMghsCXZQ9Y?t=01h17m59s)



[[Applause]](https://youtu.be/kMghsCXZQ9Y?t=01h18m07s)



[can we just go straight to the writer do](https://youtu.be/kMghsCXZQ9Y?t=01h18m12s)



[we do we have a writer here so inside of](https://youtu.be/kMghsCXZQ9Y?t=01h18m17s)



[a console renderer there's the icons on](https://youtu.be/kMghsCXZQ9Y?t=01h18m20s)



[soul I don't think it's exposed anywhere](https://youtu.be/kMghsCXZQ9Y?t=01h18m23s)



[though I mean you could do render to](https://youtu.be/kMghsCXZQ9Y?t=01h18m25s)



[region you know this also does a bunch](https://youtu.be/kMghsCXZQ9Y?t=01h18m28s)



[of stuff](https://youtu.be/kMghsCXZQ9Y?t=01h18m33s)



[yeah that does do a bunch of stuff I](https://youtu.be/kMghsCXZQ9Y?t=01h18m37s)



[kinda want to I think the cleanest thing](https://youtu.be/kMghsCXZQ9Y?t=01h18m40s)



[we can do just as an experiment is just](https://youtu.be/kMghsCXZQ9Y?t=01h18m43s)



[render it straight to a console](https://youtu.be/kMghsCXZQ9Y?t=01h18m45s)



[we can I mean as an experiment right now](https://youtu.be/kMghsCXZQ9Y?t=01h18m54s)



[we can certainly just expose the console](https://youtu.be/kMghsCXZQ9Y?t=01h18m56s)



[here because we do have it that is let's](https://youtu.be/kMghsCXZQ9Y?t=01h18m58s)



[just do that](https://youtu.be/kMghsCXZQ9Y?t=01h19m02s)



[and maybe just for as an API thought](https://youtu.be/kMghsCXZQ9Y?t=01h19m10s)



[there it does seem that there's kind of](https://youtu.be/kMghsCXZQ9Y?t=01h19m16s)



[this like I realized NC 100 does it with](https://youtu.be/kMghsCXZQ9Y?t=01h19m18s)



[control code outputs but perhaps we](https://youtu.be/kMghsCXZQ9Y?t=01h19m21s)



[don't necessarily expose it the same way](https://youtu.be/kMghsCXZQ9Y?t=01h19m26s)



[yeah because it feels like if I wanted](https://youtu.be/kMghsCXZQ9Y?t=01h19m31s)



[to code against this what I really want](https://youtu.be/kMghsCXZQ9Y?t=01h19m34s)



[to do is have something where you know](https://youtu.be/kMghsCXZQ9Y?t=01h19m36s)



[hide cursor show cursor or better yet](https://youtu.be/kMghsCXZQ9Y?t=01h19m38s)



[something that gives me an idol that I](https://youtu.be/kMghsCXZQ9Y?t=01h19m41s)



[can act on yeah so here so now we just](https://youtu.be/kMghsCXZQ9Y?t=01h19m43s)



[back the string value right so we just](https://youtu.be/kMghsCXZQ9Y?t=01h19m52s)



[go grab the cursor hide directly and](https://youtu.be/kMghsCXZQ9Y?t=01h19m54s)



[right escape sequence see what that good](https://youtu.be/kMghsCXZQ9Y?t=01h19m58s)



[let's rename it at the end](https://youtu.be/kMghsCXZQ9Y?t=01h20m04s)



[[Music]](https://youtu.be/kMghsCXZQ9Y?t=01h20m07s)



[because that I would still expect to see](https://youtu.be/kMghsCXZQ9Y?t=01h20m13s)



[a flash if we reenable it but I would](https://youtu.be/kMghsCXZQ9Y?t=01h20m15s)



[expect the flash to remain in the Bott](https://youtu.be/kMghsCXZQ9Y?t=01h20m17s)



[bottom right-hand corner](https://youtu.be/kMghsCXZQ9Y?t=01h20m19s)



[because it is worth noting that when you](https://youtu.be/kMghsCXZQ9Y?t=01h20m27s)



[use the screen view it does effectively](https://youtu.be/kMghsCXZQ9Y?t=01h20m29s)



[clear the screen yeah hey oh yeah that](https://youtu.be/kMghsCXZQ9Y?t=01h20m30s)



[blooming better it's also showing that](https://youtu.be/kMghsCXZQ9Y?t=01h20m39s)



[we didn't break any tests which means](https://youtu.be/kMghsCXZQ9Y?t=01h20m40s)



[that we don't have tests for the screen](https://youtu.be/kMghsCXZQ9Y?t=01h20m42s)



[view I'm guessing there are technically](https://youtu.be/kMghsCXZQ9Y?t=01h20m43s)



[tests for the screen view but they](https://youtu.be/kMghsCXZQ9Y?t=01h20m50s)



[clearly are not that specific yeah well](https://youtu.be/kMghsCXZQ9Y?t=01h20m52s)



[if we I think it's an area where if we](https://youtu.be/kMghsCXZQ9Y?t=01h20m58s)



[don't know what's the right day a lot of](https://youtu.be/kMghsCXZQ9Y?t=01h21m00s)



[times with the rendering steps you kind](https://youtu.be/kMghsCXZQ9Y?t=01h21m01s)



[of have to experiment figure out what](https://youtu.be/kMghsCXZQ9Y?t=01h21m02s)



[gives you the right effect and then](https://youtu.be/kMghsCXZQ9Y?t=01h21m04s)



[encode that into a task to pin the page](https://youtu.be/kMghsCXZQ9Y?t=01h21m07s)



[that the behavior in place you know](https://youtu.be/kMghsCXZQ9Y?t=01h21m09s)



[right so it's fair that we don't have](https://youtu.be/kMghsCXZQ9Y?t=01h21m10s)



[tasks here who we're figuring out what's](https://youtu.be/kMghsCXZQ9Y?t=01h21m13s)



[the right way to do this right well and](https://youtu.be/kMghsCXZQ9Y?t=01h21m15s)



[I think the tests that are on there are](https://youtu.be/kMghsCXZQ9Y?t=01h21m17s)



[more about does it call child render](https://youtu.be/kMghsCXZQ9Y?t=01h21m19s)



[with the right stuff I don't think it's](https://youtu.be/kMghsCXZQ9Y?t=01h21m22s)



[actually testing any sort of output yes](https://youtu.be/kMghsCXZQ9Y?t=01h21m24s)



[I don't think the unit tests that you go](https://youtu.be/kMghsCXZQ9Y?t=01h21m27s)



[through screen view actually get all the](https://youtu.be/kMghsCXZQ9Y?t=01h21m29s)



[way down to doing any sort of rendering](https://youtu.be/kMghsCXZQ9Y?t=01h21m31s)



[I think it's more less just pinning the](https://youtu.be/kMghsCXZQ9Y?t=01h21m34s)



[interaction between the objects](https://youtu.be/kMghsCXZQ9Y?t=01h21m38s)



[so now I moved the restoring of the](https://youtu.be/kMghsCXZQ9Y?t=01h21m46s)



[cursor to the disposal of the screen](https://youtu.be/kMghsCXZQ9Y?t=01h21m50s)



[view so now it's hidden for the entire](https://youtu.be/kMghsCXZQ9Y?t=01h21m52s)



[life of the screen because in the screen](https://youtu.be/kMghsCXZQ9Y?t=01h21m54s)



[you takes over the screen](https://youtu.be/kMghsCXZQ9Y?t=01h21m55s)



[maybe we just maybe there's no point in](https://youtu.be/kMghsCXZQ9Y?t=01h21m57s)



[ever showing a cursor until we kill them](https://youtu.be/kMghsCXZQ9Y?t=01h21m59s)



[kill the screen view then it so I kind](https://youtu.be/kMghsCXZQ9Y?t=01h22m01s)



[of agree with that but that only makes](https://youtu.be/kMghsCXZQ9Y?t=01h22m05s)



[so because it only makes sense if the](https://youtu.be/kMghsCXZQ9Y?t=01h22m09s)



[screen view is going to be doing](https://youtu.be/kMghsCXZQ9Y?t=01h22m13s)



[updating and the screen view doesn't](https://youtu.be/kMghsCXZQ9Y?t=01h22m15s)



[know if it's doing updating until a](https://youtu.be/kMghsCXZQ9Y?t=01h22m17s)



[child view raises that update event](https://youtu.be/kMghsCXZQ9Y?t=01h22m21s)



[because it could be that somebody uses a](https://youtu.be/kMghsCXZQ9Y?t=01h22m23s)



[screen view to just lay it out and then](https://youtu.be/kMghsCXZQ9Y?t=01h22m25s)



[they expect you know the user to type](https://youtu.be/kMghsCXZQ9Y?t=01h22m27s)



[something in even we don't have an info](https://youtu.be/kMghsCXZQ9Y?t=01h22m29s)



[mode right now but yeah assuming that we](https://youtu.be/kMghsCXZQ9Y?t=01h22m32s)



[that's sort of a different thing is](https://youtu.be/kMghsCXZQ9Y?t=01h22m36s)



[coordinating the screen view based on](https://youtu.be/kMghsCXZQ9Y?t=01h22m38s)



[input but right now with the screen do](https://youtu.be/kMghsCXZQ9Y?t=01h22m40s)



[screen me does it really renders a non](https://youtu.be/kMghsCXZQ9Y?t=01h22m41s)



[interactive view that is true](https://youtu.be/kMghsCXZQ9Y?t=01h22m44s)



[interactivity is a bit more complex and](https://youtu.be/kMghsCXZQ9Y?t=01h22m47s)



[we we kind of left it out of scope for](https://youtu.be/kMghsCXZQ9Y?t=01h22m50s)



[the moment right because we figured you](https://youtu.be/kMghsCXZQ9Y?t=01h22m51s)



[know before you can have interactivity](https://youtu.be/kMghsCXZQ9Y?t=01h22m58s)



[you've got to have a good rendering](https://youtu.be/kMghsCXZQ9Y?t=01h22m59s)



[experience in any case that is true I](https://youtu.be/kMghsCXZQ9Y?t=01h23m00s)



[think that's a fair thing is like this](https://youtu.be/kMghsCXZQ9Y?t=01h23m05s)



[definitely won't work for interactive](https://youtu.be/kMghsCXZQ9Y?t=01h23m08s)



[mode and also my cursor there my cursor](https://youtu.be/kMghsCXZQ9Y?t=01h23m10s)



[okay I thought it was gone forever](https://youtu.be/kMghsCXZQ9Y?t=01h23m15s)



[yeah I mean if we want to go through](https://youtu.be/kMghsCXZQ9Y?t=01h23m25s)



[okay so I think that's probably a fair](https://youtu.be/kMghsCXZQ9Y?t=01h23m27s)



[assertion to have it hide the cursor for](https://youtu.be/kMghsCXZQ9Y?t=01h23m30s)



[now yep I think then the question](https://youtu.be/kMghsCXZQ9Y?t=01h23m32s)



[becomes how should the screen view get](https://youtu.be/kMghsCXZQ9Y?t=01h23m35s)



[access to that console because exposing](https://youtu.be/kMghsCXZQ9Y?t=01h23m37s)



[it via the render is not the right](https://youtu.be/kMghsCXZQ9Y?t=01h23m39s)



[answer](https://youtu.be/kMghsCXZQ9Y?t=01h23m41s)



[well we gotta pass it indirectly if the](https://youtu.be/kMghsCXZQ9Y?t=01h23m42s)



[screen view needs back up to the console](https://youtu.be/kMghsCXZQ9Y?t=01h23m45s)



[that you just have a console sure](https://youtu.be/kMghsCXZQ9Y?t=01h23m47s)



[probably simpler yeah let's do that](https://youtu.be/kMghsCXZQ9Y?t=01h23m50s)



[this will break test](https://youtu.be/kMghsCXZQ9Y?t=01h24m03s)



[this will break compilation first I](https://youtu.be/kMghsCXZQ9Y?t=01h24m27s)



[think in every single case we're going](https://youtu.be/kMghsCXZQ9Y?t=01h24m34s)



[to have a console near at hand I hope](https://youtu.be/kMghsCXZQ9Y?t=01h24m36s)



[the test terminal which we can test](https://youtu.be/kMghsCXZQ9Y?t=01h24m42s)



[terminal so test terminal implements I](https://youtu.be/kMghsCXZQ9Y?t=01h24m44s)



[console because terminal implements I](https://youtu.be/kMghsCXZQ9Y?t=01h24m46s)



[console](https://youtu.be/kMghsCXZQ9Y?t=01h24m49s)



[[Applause]](https://youtu.be/kMghsCXZQ9Y?t=01h24m53s)



[[Music]](https://youtu.be/kMghsCXZQ9Y?t=01h24m56s)



[[Applause]](https://youtu.be/kMghsCXZQ9Y?t=01h24m57s)



[we shouldn't smoke](https://youtu.be/kMghsCXZQ9Y?t=01h24m59s)



[[Music]](https://youtu.be/kMghsCXZQ9Y?t=01h25m02s)



[[Applause]](https://youtu.be/kMghsCXZQ9Y?t=01h25m04s)



[why was there a second complaint nothing](https://youtu.be/kMghsCXZQ9Y?t=01h25m08s)



[[Applause]](https://youtu.be/kMghsCXZQ9Y?t=01h25m13s)



[[Applause]](https://youtu.be/kMghsCXZQ9Y?t=01h25m22s)



[hey John are the fans on your computer](https://youtu.be/kMghsCXZQ9Y?t=01h25m26s)



[firing up right now by any chance oh](https://youtu.be/kMghsCXZQ9Y?t=01h25m29s)



[yeah that's the back feeding noise that](https://youtu.be/kMghsCXZQ9Y?t=01h25m30s)



[I'm getting on your mic](https://youtu.be/kMghsCXZQ9Y?t=01h25m34s)



[see there are tests on screen view](https://youtu.be/kMghsCXZQ9Y?t=01h26m05s)



[the thing that I often like to bring up](https://youtu.be/kMghsCXZQ9Y?t=01h26m17s)



[here I'll see ya see these builders that](https://youtu.be/kMghsCXZQ9Y?t=01h26m21s)



[could publish thing before I think I](https://youtu.be/kMghsCXZQ9Y?t=01h26m28s)



[need to clear up](https://youtu.be/kMghsCXZQ9Y?t=01h26m31s)



[oh well this one's pretty simple it's](https://youtu.be/kMghsCXZQ9Y?t=01h26m57s)



[just invocation context console](https://youtu.be/kMghsCXZQ9Y?t=01h27m01s)



[yep so the invocation context was passed](https://youtu.be/kMghsCXZQ9Y?t=01h27m07s)



[into the dragon for entry point here](https://youtu.be/kMghsCXZQ9Y?t=01h27m10s)



[because we asked for it to be kind of a](https://youtu.be/kMghsCXZQ9Y?t=01h27m11s)



[you know system console system about](https://youtu.be/kMghsCXZQ9Y?t=01h27m14s)



[command line types are available yeah in](https://youtu.be/kMghsCXZQ9Y?t=01h27m16s)



[your command handlers that was one thing](https://youtu.be/kMghsCXZQ9Y?t=01h27m20s)



[that I ran into at work the other day is](https://youtu.be/kMghsCXZQ9Y?t=01h27m22s)



[we don't have a good list of what all](https://youtu.be/kMghsCXZQ9Y?t=01h27m25s)



[the magical types are that you can ask](https://youtu.be/kMghsCXZQ9Y?t=01h27m29s)



[for your command handler outside of the](https://youtu.be/kMghsCXZQ9Y?t=01h27m31s)



[unit test that was the closest place](https://youtu.be/kMghsCXZQ9Y?t=01h27m34s)



[where I could find a reasonable list](https://youtu.be/kMghsCXZQ9Y?t=01h27m35s)



[yeah yeah I kind of started that a](https://youtu.be/kMghsCXZQ9Y?t=01h27m37s)



[little bit with the interactive tutorial](https://youtu.be/kMghsCXZQ9Y?t=01h27m43s)



[that I've pushed the other day that's](https://youtu.be/kMghsCXZQ9Y?t=01h27m45s)



[true I did not look there but it still](https://youtu.be/kMghsCXZQ9Y?t=01h27m47s)



[it's not like a it's not a good](https://youtu.be/kMghsCXZQ9Y?t=01h27m50s)



[reference material you know it's more of](https://youtu.be/kMghsCXZQ9Y?t=01h27m51s)



[a tutorial right I was thinking](https://youtu.be/kMghsCXZQ9Y?t=01h27m53s)



[somewhere where we list out like the the](https://youtu.be/kMghsCXZQ9Y?t=01h27m56s)



[dragonfruit command handlers or](https://youtu.be/kMghsCXZQ9Y?t=01h27m58s)



[something just to call out of hey by the](https://youtu.be/kMghsCXZQ9Y?t=01h28m00s)



[way here's the extra magical parameter](https://youtu.be/kMghsCXZQ9Y?t=01h28m04s)



[types you can ask for and we'll pass](https://youtu.be/kMghsCXZQ9Y?t=01h28m06s)



[them in](https://youtu.be/kMghsCXZQ9Y?t=01h28m08s)



[okay I see it gotta go all the way over](https://youtu.be/kMghsCXZQ9Y?t=01h28m13s)



[here and this is this build error is the](https://youtu.be/kMghsCXZQ9Y?t=01h28m15s)



[one that's because I published it you'll](https://youtu.be/kMghsCXZQ9Y?t=01h28m20s)



[always see this it's because of the](https://youtu.be/kMghsCXZQ9Y?t=01h28m27s)



[dotnet core and puts it after so](https://youtu.be/kMghsCXZQ9Y?t=01h28m30s)



[implicit at the implicit SDK burring](https://youtu.be/kMghsCXZQ9Y?t=01h28m34s)



[it's locked in place when you publish](https://youtu.be/kMghsCXZQ9Y?t=01h28m36s)



[and on that clean apparently does not](https://youtu.be/kMghsCXZQ9Y?t=01h28m44s)



[wipe it out](https://youtu.be/kMghsCXZQ9Y?t=01h28m46s)



[how's it look this is aggressive when in](https://youtu.be/kMghsCXZQ9Y?t=01h28m47s)



[doubt](https://youtu.be/kMghsCXZQ9Y?t=01h28m55s)



[and the reason I'm starting just a](https://youtu.be/kMghsCXZQ9Y?t=01h29m06s)



[command-line solution from the terminal](https://youtu.be/kMghsCXZQ9Y?t=01h29m09s)



[again is because of that power shot](https://youtu.be/kMghsCXZQ9Y?t=01h29m11s)



[environment variable so that you can](https://youtu.be/kMghsCXZQ9Y?t=01h29m13s)



[make sure that you pick it up inside of](https://youtu.be/kMghsCXZQ9Y?t=01h29m17s)



[this session cool everything should work](https://youtu.be/kMghsCXZQ9Y?t=01h29m18s)



[fine like if you're use if you don't](https://youtu.be/kMghsCXZQ9Y?t=01h29m22s)



[disable arcade everything will work fine](https://youtu.be/kMghsCXZQ9Y?t=01h29m23s)



[the certain tooling might be broken a](https://youtu.be/kMghsCXZQ9Y?t=01h29m25s)



[specific tool in this case that it will](https://youtu.be/kMghsCXZQ9Y?t=01h29m28s)



[interfere with and then crunch and](https://youtu.be/kMghsCXZQ9Y?t=01h29m30s)



[crunch does not like the arcade redirect](https://youtu.be/kMghsCXZQ9Y?t=01h29m34s)



[all of the build outputs into an](https://youtu.be/kMghsCXZQ9Y?t=01h29m37s)



[artifact folder and end crunch does not](https://youtu.be/kMghsCXZQ9Y?t=01h29m39s)



[seem to know how to follow it over there](https://youtu.be/kMghsCXZQ9Y?t=01h29m41s)



[so if you like your build outputs to be](https://youtu.be/kMghsCXZQ9Y?t=01h29m43s)



[in the normal bin and object olders](https://youtu.be/kMghsCXZQ9Y?t=01h29m46s)



[underneath each project disabling ok now](https://youtu.be/kMghsCXZQ9Y?t=01h29m48s)



[the other thing that happened of course](https://youtu.be/kMghsCXZQ9Y?t=01h30m00s)



[is that unconcious not disabled because](https://youtu.be/kMghsCXZQ9Y?t=01h30m02s)



[i wiped out n crunch file line to get](https://youtu.be/kMghsCXZQ9Y?t=01h30m05s)



[clean build looks good](https://youtu.be/kMghsCXZQ9Y?t=01h30m08s)



[with the top of benchmarks](https://youtu.be/kMghsCXZQ9Y?t=01h30m34s)



[oh that's right we did get those that it](https://youtu.be/kMghsCXZQ9Y?t=01h30m37s)



[didn't work yeah](https://youtu.be/kMghsCXZQ9Y?t=01h30m39s)



[and second crunch love the benchmark](https://youtu.be/kMghsCXZQ9Y?t=01h30m43s)



[projects very much](https://youtu.be/kMghsCXZQ9Y?t=01h30m46s)



[[Applause]](https://youtu.be/kMghsCXZQ9Y?t=01h30m49s)



[[Applause]](https://youtu.be/kMghsCXZQ9Y?t=01h30m59s)



[disable attachments](https://youtu.be/kMghsCXZQ9Y?t=01h31m06s)



[yeah absolutely they're little tips and](https://youtu.be/kMghsCXZQ9Y?t=01h31m35s)



[tricks](https://youtu.be/kMghsCXZQ9Y?t=01h31m37s)



[did you maybe I missed it did you stash](https://youtu.be/kMghsCXZQ9Y?t=01h32m04s)



[the current work before you did the Klan](https://youtu.be/kMghsCXZQ9Y?t=01h32m07s)



[or did you just clean what FDX](https://youtu.be/kMghsCXZQ9Y?t=01h32m09s)



[there were no added file so got it](https://youtu.be/kMghsCXZQ9Y?t=01h32m11s)



[oh it always one get statics before](https://youtu.be/kMghsCXZQ9Y?t=01h32m22s)



[letting get clean I've got a couple](https://youtu.be/kMghsCXZQ9Y?t=01h32m25s)



[projects where we've got like developer](https://youtu.be/kMghsCXZQ9Y?t=01h32m29s)



[config files that aren't checked in and](https://youtu.be/kMghsCXZQ9Y?t=01h32m32s)



[yeah get clean always wipes them out and](https://youtu.be/kMghsCXZQ9Y?t=01h32m33s)



[so I've learned I just need to keep a](https://youtu.be/kMghsCXZQ9Y?t=01h32m37s)



[backup copy sitting off outside the repo](https://youtu.be/kMghsCXZQ9Y?t=01h32m39s)



[yeah I actually did recover a bunch of](https://youtu.be/kMghsCXZQ9Y?t=01h32m42s)



[stuff that I wiped out you then get](https://youtu.be/kMghsCXZQ9Y?t=01h32m47s)



[clean recently it came there are there](https://youtu.be/kMghsCXZQ9Y?t=01h32m49s)



[cases in which you can recover stuff](https://youtu.be/kMghsCXZQ9Y?t=01h32m55s)



[that was wiped that would get clean ever](https://youtu.be/kMghsCXZQ9Y?t=01h32m56s)



[from what just like a file deletion](https://youtu.be/kMghsCXZQ9Y?t=01h33m00s)



[utility or no like the act if you've](https://youtu.be/kMghsCXZQ9Y?t=01h33m03s)



[ever committed them at all then you can](https://youtu.be/kMghsCXZQ9Y?t=01h33m07s)



[find references to them in your github](https://youtu.be/kMghsCXZQ9Y?t=01h33m09s)



[repository or git repository it's a pain](https://youtu.be/kMghsCXZQ9Y?t=01h33m12s)



[in the butt you basically dep don't like](https://youtu.be/kMghsCXZQ9Y?t=01h33m17s)



[to go and you know plug through history](https://youtu.be/kMghsCXZQ9Y?t=01h33m18s)



[for find files yeah yeah just give you](https://youtu.be/kMghsCXZQ9Y?t=01h33m21s)



[like a list of goods and then you have](https://youtu.be/kMghsCXZQ9Y?t=01h33m28s)



[to ask it for each one of those goods to](https://youtu.be/kMghsCXZQ9Y?t=01h33m29s)



[show what the dips are and then you need](https://youtu.be/kMghsCXZQ9Y?t=01h33m31s)



[to extract the dips out and manually and](https://youtu.be/kMghsCXZQ9Y?t=01h33m32s)



[apply them back to your files but](https://youtu.be/kMghsCXZQ9Y?t=01h33m34s)



[sometimes that's quicker than rewriting](https://youtu.be/kMghsCXZQ9Y?t=01h33m36s)



[everything that you just blew away](https://youtu.be/kMghsCXZQ9Y?t=01h33m38s)



[because you're being stupid that's true](https://youtu.be/kMghsCXZQ9Y?t=01h33m39s)



[and more importantly demo works yep cool](https://youtu.be/kMghsCXZQ9Y?t=01h33m41s)



[do we break any tests doing this no](https://youtu.be/kMghsCXZQ9Y?t=01h33m47s)



[that's a problem well we're just not](https://youtu.be/kMghsCXZQ9Y?t=01h33m51s)



[what we clearly don't have any tests](https://youtu.be/kMghsCXZQ9Y?t=01h33m56s)



[that are checking those that like outer](https://youtu.be/kMghsCXZQ9Y?t=01h33m58s)



[most render operation in the](https://youtu.be/kMghsCXZQ9Y?t=01h33m59s)



[screenreader should we write some tests](https://youtu.be/kMghsCXZQ9Y?t=01h34m01s)



[before we do something crazy like commit](https://youtu.be/kMghsCXZQ9Y?t=01h34m06s)



[this yeah one of them got pretty beat up](https://youtu.be/kMghsCXZQ9Y?t=01h34m08s)



[yeah there are some tests here I mean](https://youtu.be/kMghsCXZQ9Y?t=01h34m14s)



[the first thing I'm seeing right out the](https://youtu.be/kMghsCXZQ9Y?t=01h34m19s)



[gate is like do we care to write the the](https://youtu.be/kMghsCXZQ9Y?t=01h34m20s)



[quick one real quick on the no reference](https://youtu.be/kMghsCXZQ9Y?t=01h34m23s)



[on the](https://youtu.be/kMghsCXZQ9Y?t=01h34m27s)



[yep structure perimeter so I mean you](https://youtu.be/kMghsCXZQ9Y?t=01h34m28s)



[can basically duplicate that same test](https://youtu.be/kMghsCXZQ9Y?t=01h34m31s)



[right there](https://youtu.be/kMghsCXZQ9Y?t=01h34m33s)



[what do you want to cut screen view](https://youtu.be/kMghsCXZQ9Y?t=01h34m42s)



[requires a console](https://youtu.be/kMghsCXZQ9Y?t=01h34m45s)



[[Music]](https://youtu.be/kMghsCXZQ9Y?t=01h35m07s)



[okay and if I mean really pedantic](https://youtu.be/kMghsCXZQ9Y?t=01h35m13s)



[rather than the camp location on your](https://youtu.be/kMghsCXZQ9Y?t=01h35m17s)



[screen view we might want to match the](https://youtu.be/kMghsCXZQ9Y?t=01h35m20s)



[other naming where the moron who wrote](https://youtu.be/kMghsCXZQ9Y?t=01h35m22s)



[them the first time but it an underscore](https://youtu.be/kMghsCXZQ9Y?t=01h35m25s)



[between them oh here we won't mention](https://youtu.be/kMghsCXZQ9Y?t=01h35m26s)



[his name you probably find out find out](https://youtu.be/kMghsCXZQ9Y?t=01h35m30s)



[this is the part where we need to](https://youtu.be/kMghsCXZQ9Y?t=01h35m34s)



[rewrite git history](https://youtu.be/kMghsCXZQ9Y?t=01h35m36s)



[oh so something you should show off real](https://youtu.be/kMghsCXZQ9Y?t=01h35m39s)



[quick John because I mentioned this to a](https://youtu.be/kMghsCXZQ9Y?t=01h35m45s)



[co-worker and I want to show this to](https://youtu.be/kMghsCXZQ9Y?t=01h35m48s)



[them your your fancy edit and vyas code](https://youtu.be/kMghsCXZQ9Y?t=01h35m49s)



[command do you mind showing that because](https://youtu.be/kMghsCXZQ9Y?t=01h35m54s)



[I believe that's just open it in](https://youtu.be/kMghsCXZQ9Y?t=01h35m59s)



[external tool with the correct](https://youtu.be/kMghsCXZQ9Y?t=01h36m00s)



[parameters yeah so what I just did you](https://youtu.be/kMghsCXZQ9Y?t=01h36m03s)



[know because I like to use the multiple](https://youtu.be/kMghsCXZQ9Y?t=01h36m06s)



[cursors functionality and Visual Studio](https://youtu.be/kMghsCXZQ9Y?t=01h36m08s)



[code because it's awesome and very](https://youtu.be/kMghsCXZQ9Y?t=01h36m10s)



[another thing sometimes if you want to](https://youtu.be/kMghsCXZQ9Y?t=01h36m11s)



[have a text editor that's not quite](https://youtu.be/kMghsCXZQ9Y?t=01h36m13s)



[opinionated about the thing you're](https://youtu.be/kMghsCXZQ9Y?t=01h36m15s)



[editing I have a keystroke that I set up](https://youtu.be/kMghsCXZQ9Y?t=01h36m16s)



[so it's a tool you go into so what it](https://youtu.be/kMghsCXZQ9Y?t=01h36m20s)



[does I'll show it I'll show the tool](https://youtu.be/kMghsCXZQ9Y?t=01h36m22s)



[entry here it's just under external](https://youtu.be/kMghsCXZQ9Y?t=01h36m24s)



[tools bf code so it's just a path aliyev](https://youtu.be/kMghsCXZQ9Y?t=01h36m26s)



[codec t and then this little thing here](https://youtu.be/kMghsCXZQ9Y?t=01h36m30s)



[that tells it what arguments to pass the](https://youtu.be/kMghsCXZQ9Y?t=01h36m32s)



[via code which is pulling from your](https://youtu.be/kMghsCXZQ9Y?t=01h36m35s)



[current cursor position Chrome file so](https://youtu.be/kMghsCXZQ9Y?t=01h36m36s)



[the idea is that I can if I want to be I](https://youtu.be/kMghsCXZQ9Y?t=01h36m39s)



[want to edit this thing right here and](https://youtu.be/kMghsCXZQ9Y?t=01h36m41s)



[BS code I of this hip-hop chef C and now](https://youtu.be/kMghsCXZQ9Y?t=01h36m43s)



[I'm in Visual Studio code in that same](https://youtu.be/kMghsCXZQ9Y?t=01h36m48s)



[position and I can do stuff like move](https://youtu.be/kMghsCXZQ9Y?t=01h36m50s)



[lines around or maybe I want to cursor](https://youtu.be/kMghsCXZQ9Y?t=01h36m52s)



[is because I would do something strange](https://youtu.be/kMghsCXZQ9Y?t=01h36m56s)



[right yeah yeah okay then you save it](https://youtu.be/kMghsCXZQ9Y?t=01h37m01s)



[here and as the other setting that's key](https://youtu.be/kMghsCXZQ9Y?t=01h37m07s)



[to turn on in Visual Studio is the](https://youtu.be/kMghsCXZQ9Y?t=01h37m09s)



[automatic reloading of your files when](https://youtu.be/kMghsCXZQ9Y?t=01h37m12s)



[they change from external source that](https://youtu.be/kMghsCXZQ9Y?t=01h37m13s)



[when you hit save in vs code visual](https://youtu.be/kMghsCXZQ9Y?t=01h37m16s)



[studio reloads it so cool](https://youtu.be/kMghsCXZQ9Y?t=01h37m18s)



[okay so that test passes let's do](https://youtu.be/kMghsCXZQ9Y?t=01h37m27s)



[another test then we should probably](https://youtu.be/kMghsCXZQ9Y?t=01h37m32s)



[what did I call it probably render hides](https://youtu.be/kMghsCXZQ9Y?t=01h37m36s)



[cursor something to that effect](https://youtu.be/kMghsCXZQ9Y?t=01h37m42s)



[okay so let's go up and new up a new](https://youtu.be/kMghsCXZQ9Y?t=01h37m50s)



[screen view can you go back down I'm](https://youtu.be/kMghsCXZQ9Y?t=01h37m55s)



[wondering if or I'm sorry scroll down](https://youtu.be/kMghsCXZQ9Y?t=01h37m58s)



[your left view to the screen view where](https://youtu.be/kMghsCXZQ9Y?t=01h38m01s)



[we actually did the work because we](https://youtu.be/kMghsCXZQ9Y?t=01h38m04s)



[yeah so we should probably do two tests](https://youtu.be/kMghsCXZQ9Y?t=01h38m14s)



[this one we're render hides the cursor](https://youtu.be/kMghsCXZQ9Y?t=01h38m17s)



[and then one more we're disposed shows](https://youtu.be/kMghsCXZQ9Y?t=01h38m19s)



[it okay on the hide the cursor I like](https://youtu.be/kMghsCXZQ9Y?t=01h38m22s)



[show it matches the ANSI command the](https://youtu.be/kMghsCXZQ9Y?t=01h38m39s)



[other thing that that is clearly missing](https://youtu.be/kMghsCXZQ9Y?t=01h38m43s)



[from this is the like this code is](https://youtu.be/kMghsCXZQ9Y?t=01h38m44s)



[clearly making massive assumptions about](https://youtu.be/kMghsCXZQ9Y?t=01h38m47s)



[the output because we're just randomly](https://youtu.be/kMghsCXZQ9Y?t=01h38m49s)



[spewing ANSI characters out which is](https://youtu.be/kMghsCXZQ9Y?t=01h38m51s)



[almost surely not what you want like](https://youtu.be/kMghsCXZQ9Y?t=01h38m54s)



[these to write lines we clearly need](https://youtu.be/kMghsCXZQ9Y?t=01h38m57s)



[more checks around them for output modes](https://youtu.be/kMghsCXZQ9Y?t=01h38m59s)



[and that sort of thing right that will](https://youtu.be/kMghsCXZQ9Y?t=01h39m00s)



[be a different test so so yeah so let's](https://youtu.be/kMghsCXZQ9Y?t=01h39m04s)



[do screen gets new screen view you can](https://youtu.be/kMghsCXZQ9Y?t=01h39m09s)



[basically do the same type of](https://youtu.be/kMghsCXZQ9Y?t=01h39m12s)



[instantiation as what's on 62 so it'll](https://youtu.be/kMghsCXZQ9Y?t=01h39m13s)



[take ya all that jazz](https://youtu.be/kMghsCXZQ9Y?t=01h39m18s)



[and the thing is we don't actually need](https://youtu.be/kMghsCXZQ9Y?t=01h39m23s)



[a view because like we've got the no](https://youtu.be/kMghsCXZQ9Y?t=01h39m25s)



[prop operator on child right there and I](https://youtu.be/kMghsCXZQ9Y?t=01h39m30s)



[know I saw another test about if there's](https://youtu.be/kMghsCXZQ9Y?t=01h39m31s)



[no child that doesn't air it's just you](https://youtu.be/kMghsCXZQ9Y?t=01h39m34s)



[know no ops basically okay so it does](https://youtu.be/kMghsCXZQ9Y?t=01h39m37s)



[beg the question should we be writing](https://youtu.be/kMghsCXZQ9Y?t=01h39m41s)



[out this ansi escape character if there](https://youtu.be/kMghsCXZQ9Y?t=01h39m42s)



[is no child but that's a different](https://youtu.be/kMghsCXZQ9Y?t=01h39m45s)



[discussion so yeah so screen render okay](https://youtu.be/kMghsCXZQ9Y?t=01h39m46s)



[you should should it what's the scenario](https://youtu.be/kMghsCXZQ9Y?t=01h39m52s)



[for not having a child programmer hasn't](https://youtu.be/kMghsCXZQ9Y?t=01h39m53s)



[set one up yet it seems it's it's](https://youtu.be/kMghsCXZQ9Y?t=01h39m57s)



[potentially programmer air because i](https://youtu.be/kMghsCXZQ9Y?t=01h40m01s)



[don't know how else you get into this](https://youtu.be/kMghsCXZQ9Y?t=01h40m05s)



[situation where the child is unset and](https://youtu.be/kMghsCXZQ9Y?t=01h40m06s)



[so we can we can even just leave it at](https://youtu.be/kMghsCXZQ9Y?t=01h40m13s)



[that and be done screen dot render](https://youtu.be/kMghsCXZQ9Y?t=01h40m18s)



[because that'll i mean do we call into](https://youtu.be/kMghsCXZQ9Y?t=01h40m21s)



[the overload directly that feels a](https://youtu.be/kMghsCXZQ9Y?t=01h40m24s)



[little bit more like](https://youtu.be/kMghsCXZQ9Y?t=01h40m27s)



[now the basic overload is probably fine](https://youtu.be/kMghsCXZQ9Y?t=01h40m32s)



[because we've got another test that](https://youtu.be/kMghsCXZQ9Y?t=01h40m34s)



[asserts that if you go into the](https://youtu.be/kMghsCXZQ9Y?t=01h40m36s)



[parameter list overload it calls the](https://youtu.be/kMghsCXZQ9Y?t=01h40m37s)



[other one okay so that seems reasonable](https://youtu.be/kMghsCXZQ9Y?t=01h40m40s)



[and so then we need to do might be a](https://youtu.be/kMghsCXZQ9Y?t=01h40m45s)



[little aggressive but that's probably](https://youtu.be/kMghsCXZQ9Y?t=01h40m56s)



[currently correct right now right for](https://youtu.be/kMghsCXZQ9Y?t=01h40m57s)



[now it is correct hide escape sequence](https://youtu.be/kMghsCXZQ9Y?t=01h41m01s)



[oh good call I was moving on to the next](https://youtu.be/kMghsCXZQ9Y?t=01h41m10s)



[test already okay that's cool](https://youtu.be/kMghsCXZQ9Y?t=01h41m16s)



[so yeah here's mine](https://youtu.be/kMghsCXZQ9Y?t=01h41m20s)



[very nice](https://youtu.be/kMghsCXZQ9Y?t=01h41m37s)



[okay so next one I guess is similar to](https://youtu.be/kMghsCXZQ9Y?t=01h41m42s)



[this right yep pretty much](https://youtu.be/kMghsCXZQ9Y?t=01h41m46s)



[well we technically don't even need to](https://youtu.be/kMghsCXZQ9Y?t=01h41m49s)



[call render dress we can just do screen](https://youtu.be/kMghsCXZQ9Y?t=01h41m53s)



[dot dispose right and I would say ends](https://youtu.be/kMghsCXZQ9Y?t=01h41m56s)



[with not starts with and then you need](https://youtu.be/kMghsCXZQ9Y?t=01h42m07s)



[to change your escape sequence oh no](https://youtu.be/kMghsCXZQ9Y?t=01h42m09s)



[cool](https://youtu.be/kMghsCXZQ9Y?t=01h42m22s)



[and that's roughly what I would expect](https://youtu.be/kMghsCXZQ9Y?t=01h42m24s)



[yeah so here's the only thing that](https://youtu.be/kMghsCXZQ9Y?t=01h42m27s)



[that's kind of bothering me a little bit](https://youtu.be/kMghsCXZQ9Y?t=01h42m30s)



[about this and maybe we do need to](https://youtu.be/kMghsCXZQ9Y?t=01h42m32s)



[expose something via the renderer](https://youtu.be/kMghsCXZQ9Y?t=01h42m33s)



[because right now the renderer has all](https://youtu.be/kMghsCXZQ9Y?t=01h42m35s)



[of that logic in render to region for](https://youtu.be/kMghsCXZQ9Y?t=01h42m37s)



[handling the various output modes and](https://youtu.be/kMghsCXZQ9Y?t=01h42m39s)



[determining whether it should display](https://youtu.be/kMghsCXZQ9Y?t=01h42m43s)



[ANSI characters or not yeah it makes me](https://youtu.be/kMghsCXZQ9Y?t=01h42m45s)



[wonder if render needs another overload](https://youtu.be/kMghsCXZQ9Y?t=01h42m48s)



[to support this kind of thing because](https://youtu.be/kMghsCXZQ9Y?t=01h42m54s)



[ideally rather than having the console](https://youtu.be/kMghsCXZQ9Y?t=01h42m56s)



[to act on right here I think what would](https://youtu.be/kMghsCXZQ9Y?t=01h42m58s)



[be cleaner is if in screen view we could](https://youtu.be/kMghsCXZQ9Y?t=01h43m00s)



[just do renderer dot render control code](https://youtu.be/kMghsCXZQ9Y?t=01h43m04s)



[or yeah we even talked about doing that](https://youtu.be/kMghsCXZQ9Y?t=01h43m11s)



[via the terminal itself that maybe we](https://youtu.be/kMghsCXZQ9Y?t=01h43m14s)



[want different implementations of](https://youtu.be/kMghsCXZQ9Y?t=01h43m16s)



[terminal for ANSI versus non empty](https://youtu.be/kMghsCXZQ9Y?t=01h43m18s)



[terminals right does this this kind of](https://youtu.be/kMghsCXZQ9Y?t=01h43m21s)



[raw writing out of these things we](https://youtu.be/kMghsCXZQ9Y?t=01h43m24s)



[either have to duplicate all the logic](https://youtu.be/kMghsCXZQ9Y?t=01h43m26s)



[for our modes to know whether it's okay](https://youtu.be/kMghsCXZQ9Y?t=01h43m28s)



[to write these things out yeah I mean I](https://youtu.be/kMghsCXZQ9Y?t=01h43m30s)



[guess it really is only an if check](https://youtu.be/kMghsCXZQ9Y?t=01h43m33s)



[isn't it well but right now we already](https://youtu.be/kMghsCXZQ9Y?t=01h43m34s)



[have that responsibility by you know](https://youtu.be/kMghsCXZQ9Y?t=01h43m37s)



[because we have two different visitor](https://youtu.be/kMghsCXZQ9Y?t=01h43m39s)



[classes we have these we have the you](https://youtu.be/kMghsCXZQ9Y?t=01h43m41s)



[know the anti rendering spam visit or](https://youtu.be/kMghsCXZQ9Y?t=01h43m46s)



[the file rendering spam visitor I think](https://youtu.be/kMghsCXZQ9Y?t=01h43m47s)



[and the monana empties fan rendering the](https://youtu.be/kMghsCXZQ9Y?t=01h43m50s)



[content remembers yeah it's the](https://youtu.be/kMghsCXZQ9Y?t=01h43m51s)



[different ones that implement that](https://youtu.be/kMghsCXZQ9Y?t=01h43m54s)



[implement this these let's take in these](https://youtu.be/kMghsCXZQ9Y?t=01h43m56s)



[are the ones where right now that](https://youtu.be/kMghsCXZQ9Y?t=01h44m02s)



[decision about how to render is made](https://youtu.be/kMghsCXZQ9Y?t=01h44m03s)



[right well but the decision about which](https://youtu.be/kMghsCXZQ9Y?t=01h44m05s)



[one of these visitors gets used is](https://youtu.be/kMghsCXZQ9Y?t=01h44m08s)



[handled in the renderer let's jump to](https://youtu.be/kMghsCXZQ9Y?t=01h44m09s)



[that let's jump to console render a](https://youtu.be/kMghsCXZQ9Y?t=01h44m13s)



[render to region there's a switch](https://youtu.be/kMghsCXZQ9Y?t=01h44m15s)



[statement in there for my members](https://youtu.be/kMghsCXZQ9Y?t=01h44m17s)



[correct](https://youtu.be/kMghsCXZQ9Y?t=01h44m19s)



[so yeah so on that mode of what it does](https://youtu.be/kMghsCXZQ9Y?t=01h44m23s)



[because that that's that auto-detect](https://youtu.be/kMghsCXZQ9Y?t=01h44m29s)



[that you were mentioning online 71 we're](https://youtu.be/kMghsCXZQ9Y?t=01h44m31s)



[where if the mode is set to auto which I](https://youtu.be/kMghsCXZQ9Y?t=01h44m35s)



[believe is the default it falls back and](https://youtu.be/kMghsCXZQ9Y?t=01h44m37s)



[says okay try to detect otherwise you](https://youtu.be/kMghsCXZQ9Y?t=01h44m39s)



[know we're just gonna go conservative](https://youtu.be/kMghsCXZQ9Y?t=01h44m41s)



[and go plain text and then it shells out](https://youtu.be/kMghsCXZQ9Y?t=01h44m43s)



[to the various visitors text i've been](https://youtu.be/kMghsCXZQ9Y?t=01h44m49s)



[calling a file on the command line](https://youtu.be/kMghsCXZQ9Y?t=01h44m54s)



[that's the problem I'm surprised that](https://youtu.be/kMghsCXZQ9Y?t=01h44m58s)



[doesn't give you for the parameters on](https://youtu.be/kMghsCXZQ9Y?t=01h45m02s)



[directives shouldn't that be a parse air](https://youtu.be/kMghsCXZQ9Y?t=01h45m06s)



[yeah that one probably should if the](https://youtu.be/kMghsCXZQ9Y?t=01h45m11s)



[directive is opinionated about what](https://youtu.be/kMghsCXZQ9Y?t=01h45m13s)



[values can be in their directives are](https://youtu.be/kMghsCXZQ9Y?t=01h45m15s)



[kind of a special special world right](https://youtu.be/kMghsCXZQ9Y?t=01h45m16s)



[now because we we don't have the notion](https://youtu.be/kMghsCXZQ9Y?t=01h45m18s)



[of discovering what directives are](https://youtu.be/kMghsCXZQ9Y?t=01h45m19s)



[available right and so what we do is we](https://youtu.be/kMghsCXZQ9Y?t=01h45m21s)



[just say you know if you pass in](https://youtu.be/kMghsCXZQ9Y?t=01h45m24s)



[directives we we can act on them right](https://youtu.be/kMghsCXZQ9Y?t=01h45m25s)



[but we won't validate them right kind of](https://youtu.be/kMghsCXZQ9Y?t=01h45m30s)



[like HTTP headers in as well yeah I can](https://youtu.be/kMghsCXZQ9Y?t=01h45m34s)



[understand that and be in being very](https://youtu.be/kMghsCXZQ9Y?t=01h45m38s)



[loose on the directives themselves but](https://youtu.be/kMghsCXZQ9Y?t=01h45m40s)



[once somebody has specified a directive](https://youtu.be/kMghsCXZQ9Y?t=01h45m43s)



[named him like output mode it feels like](https://youtu.be/kMghsCXZQ9Y?t=01h45m45s)



[the directive itself could be very](https://youtu.be/kMghsCXZQ9Y?t=01h45m48s)



[opinionated about what values it would](https://youtu.be/kMghsCXZQ9Y?t=01h45m50s)



[allow and err so you know if you tie a](https://youtu.be/kMghsCXZQ9Y?t=01h45m52s)



[fat finger your output mode from you](https://youtu.be/kMghsCXZQ9Y?t=01h45m56s)



[know Auto to be ATO yeah it probably](https://youtu.be/kMghsCXZQ9Y?t=01h45m59s)



[should blow up in your face to say yeah](https://youtu.be/kMghsCXZQ9Y?t=01h46m03s)



[I think that's a good idea](https://youtu.be/kMghsCXZQ9Y?t=01h46m05s)



[yeah at least for the directive](https://youtu.be/kMghsCXZQ9Y?t=01h46m07s)



[parameters I understand being a little](https://youtu.be/kMghsCXZQ9Y?t=01h46m09s)



[bit more loose on the directives](https://youtu.be/kMghsCXZQ9Y?t=01h46m11s)



[themselves anyway](https://youtu.be/kMghsCXZQ9Y?t=01h46m12s)



[so my thought though is we've already](https://youtu.be/kMghsCXZQ9Y?t=01h46m17s)



[got sort of this switch of what we're](https://youtu.be/kMghsCXZQ9Y?t=01h46m20s)



[going to render out yep](https://youtu.be/kMghsCXZQ9Y?t=01h46m24s)



[and these visitors because I am](https://youtu.be/kMghsCXZQ9Y?t=01h46m27s)



[wondering if we could take advantage of](https://youtu.be/kMghsCXZQ9Y?t=01h46m30s)



[this render to region because what](https://youtu.be/kMghsCXZQ9Y?t=01h46m32s)



[exactly does it you](https://youtu.be/kMghsCXZQ9Y?t=01h46m35s)



[the region for anyway because in our](https://youtu.be/kMghsCXZQ9Y?t=01h46m36s)



[case we really could give it a zero](https://youtu.be/kMghsCXZQ9Y?t=01h46m39s)



[region for turning the the cursor on and](https://youtu.be/kMghsCXZQ9Y?t=01h46m41s)



[off right yeah doesn't need to be a](https://youtu.be/kMghsCXZQ9Y?t=01h46m50s)



[region really right just render it now](https://youtu.be/kMghsCXZQ9Y?t=01h46m53s)



[yeah and every stream yeah exactly](https://youtu.be/kMghsCXZQ9Y?t=01h46m58s)



[because we we allow the span itself to](https://youtu.be/kMghsCXZQ9Y?t=01h47m03s)



[be no but we don't allow the region](https://youtu.be/kMghsCXZQ9Y?t=01h47m06s)



[I'm wonder if we just lacks that](https://youtu.be/kMghsCXZQ9Y?t=01h47m10s)



[restriction or maybe it's just a](https://youtu.be/kMghsCXZQ9Y?t=01h47m12s)



[separate method render to region fields](https://youtu.be/kMghsCXZQ9Y?t=01h47m15s)



[oh yeah you're like like it really](https://youtu.be/kMghsCXZQ9Y?t=01h47m17s)



[should be but we can we can factor this](https://youtu.be/kMghsCXZQ9Y?t=01h47m19s)



[into two different methods where one](https://youtu.be/kMghsCXZQ9Y?t=01h47m24s)



[doesn't take a region does the span](https://youtu.be/kMghsCXZQ9Y?t=01h47m26s)



[visitor visit there currently it's](https://youtu.be/kMghsCXZQ9Y?t=01h47m28s)



[tricky because when you're in a nancy](https://youtu.be/kMghsCXZQ9Y?t=01h47m42s)



[mode you really do want the render](https://youtu.be/kMghsCXZQ9Y?t=01h47m44s)



[operation to be region specific because](https://youtu.be/kMghsCXZQ9Y?t=01h47m46s)



[it also need to clean up that region](https://youtu.be/kMghsCXZQ9Y?t=01h47m47s)



[true but that's also why I'm wondering](https://youtu.be/kMghsCXZQ9Y?t=01h47m50s)



[if maybe we just give it like a zero](https://youtu.be/kMghsCXZQ9Y?t=01h47m53s)



[sized region mm-hmm like it would it](https://youtu.be/kMghsCXZQ9Y?t=01h47m56s)



[would be nice if there was a nice easy](https://youtu.be/kMghsCXZQ9Y?t=01h48m01s)



[because we've got the the screen view](https://youtu.be/kMghsCXZQ9Y?t=01h48m02s)



[builds a region that represents the](https://youtu.be/kMghsCXZQ9Y?t=01h48m05s)



[whole screen by basically looking at the](https://youtu.be/kMghsCXZQ9Y?t=01h48m07s)



[console sighs I almost want to get one](https://youtu.be/kMghsCXZQ9Y?t=01h48m08s)



[that's similar that's basically you know](https://youtu.be/kMghsCXZQ9Y?t=01h48m12s)



[region dot zero where it looks at the](https://youtu.be/kMghsCXZQ9Y?t=01h48m16s)



[current cursor position for its X Y](https://youtu.be/kMghsCXZQ9Y?t=01h48m20s)



[position but then same height width to](https://youtu.be/kMghsCXZQ9Y?t=01h48m23s)



[either one or zero I don't know if we'd](https://youtu.be/kMghsCXZQ9Y?t=01h48m26s)



[be tolerant of 0 I feel like that's an](https://youtu.be/kMghsCXZQ9Y?t=01h48m28s)



[off by one error waiting to happen yeah](https://youtu.be/kMghsCXZQ9Y?t=01h48m29s)



[yeah it feels like I wouldn't want to](https://youtu.be/kMghsCXZQ9Y?t=01h48m32s)



[explode that implementation detail in](https://youtu.be/kMghsCXZQ9Y?t=01h48m36s)



[the API no I agree with that but I'm](https://youtu.be/kMghsCXZQ9Y?t=01h48m38s)



[just thinking for the if we had a second](https://youtu.be/kMghsCXZQ9Y?t=01h48m43s)



[one of these methods that that didn't](https://youtu.be/kMghsCXZQ9Y?t=01h48m47s)



[take a region](https://youtu.be/kMghsCXZQ9Y?t=01h48m50s)



[that's how we could get around the](https://youtu.be/kMghsCXZQ9Y?t=01h48m50s)



[visitors requiring a region yeah yeah](https://youtu.be/kMghsCXZQ9Y?t=01h48m52s)



[or maybe the visitors should not require](https://youtu.be/kMghsCXZQ9Y?t=01h49m06s)



[a reason](https://youtu.be/kMghsCXZQ9Y?t=01h49m08s)



[I mean that is a possibility I mean](https://youtu.be/kMghsCXZQ9Y?t=01h49m23s)



[another way I'm thinking about it I](https://youtu.be/kMghsCXZQ9Y?t=01h49m29s)



[guess if you have it is that we're not](https://youtu.be/kMghsCXZQ9Y?t=01h49m30s)



[really rendering a text expand anymore](https://youtu.be/kMghsCXZQ9Y?t=01h49m32s)



[all right](https://youtu.be/kMghsCXZQ9Y?t=01h49m35s)



[or we're not it's not a content span](https://youtu.be/kMghsCXZQ9Y?t=01h49m36s)



[maybe right it's just what are the](https://youtu.be/kMghsCXZQ9Y?t=01h49m39s)



[different spam types we have it's I](https://youtu.be/kMghsCXZQ9Y?t=01h49m41s)



[think the red wreath render without a](https://youtu.be/kMghsCXZQ9Y?t=01h49m43s)



[region maybe should only be used for](https://youtu.be/kMghsCXZQ9Y?t=01h49m45s)



[rendering control signals agree which](https://youtu.be/kMghsCXZQ9Y?t=01h49m47s)



[means it's a very different kind of](https://youtu.be/kMghsCXZQ9Y?t=01h49m52s)



[overload than what we have right now for](https://youtu.be/kMghsCXZQ9Y?t=01h49m54s)



[render to region right it maybe take](https://youtu.be/kMghsCXZQ9Y?t=01h49m56s)



[something less general than a spam I](https://youtu.be/kMghsCXZQ9Y?t=01h50m01s)



[could see that though we don't currently](https://youtu.be/kMghsCXZQ9Y?t=01h50m05s)



[have anything to separate out those](https://youtu.be/kMghsCXZQ9Y?t=01h50m08s)



[control codes well maybe it just takes](https://youtu.be/kMghsCXZQ9Y?t=01h50m10s)



[the control maybe it just takes an ansi](https://youtu.be/kMghsCXZQ9Y?t=01h50m16s)



[escape sequence directly or an anticodon](https://youtu.be/kMghsCXZQ9Y?t=01h50m18s)



[whatever the type was so maybe we're](https://youtu.be/kMghsCXZQ9Y?t=01h50m20s)



[entering an ansi control code maybe it](https://youtu.be/kMghsCXZQ9Y?t=01h50m29s)



[maybe it's render an T control code no](https://youtu.be/kMghsCXZQ9Y?t=01h50m31s)



[Rita I could see that because the](https://youtu.be/kMghsCXZQ9Y?t=01h50m34s)



[control codes I can't say don't take up](https://youtu.be/kMghsCXZQ9Y?t=01h50m40s)



[any space because there's ones in there](https://youtu.be/kMghsCXZQ9Y?t=01h50m43s)



[too that are like clear screen which](https://youtu.be/kMghsCXZQ9Y?t=01h50m47s)



[clearly take up the whole screens worth](https://youtu.be/kMghsCXZQ9Y?t=01h50m50s)



[of space yeah yeah but I think that](https://youtu.be/kMghsCXZQ9Y?t=01h50m53s)



[overload is still clear in that it's no](https://youtu.be/kMghsCXZQ9Y?t=01h50m56s)



[longer just](https://youtu.be/kMghsCXZQ9Y?t=01h50m58s)



[just rendering content it's actually](https://youtu.be/kMghsCXZQ9Y?t=01h51m04s)



[saying no go go perform this action and](https://youtu.be/kMghsCXZQ9Y?t=01h51m06s)



[it's up to you to do it yeah it's a](https://youtu.be/kMghsCXZQ9Y?t=01h51m09s)



[little bit interesting cuz actually what](https://youtu.be/kMghsCXZQ9Y?t=01h51m11s)



[we what we actually want everything that](https://youtu.be/kMghsCXZQ9Y?t=01h51m13s)



[you're saying makes perfect sense I I](https://youtu.be/kMghsCXZQ9Y?t=01h51m15s)



[want to revise what I said though is](https://youtu.be/kMghsCXZQ9Y?t=01h51m16s)



[it's not](https://youtu.be/kMghsCXZQ9Y?t=01h51m18s)



[Nancy escape sequence it's some other](https://youtu.be/kMghsCXZQ9Y?t=01h51m19s)



[thing that can be generalised across](https://youtu.be/kMghsCXZQ9Y?t=01h51m20s)



[empty and non ANSI terminals oh so you](https://youtu.be/kMghsCXZQ9Y?t=01h51m23s)



[not necessarily a nancy control what](https://youtu.be/kMghsCXZQ9Y?t=01h51m30s)



[you're saying yeah I guess what would](https://youtu.be/kMghsCXZQ9Y?t=01h51m34s)



[you propose that argument to be though](https://youtu.be/kMghsCXZQ9Y?t=01h51m39s)



[it's kind of like these right here oh](https://youtu.be/kMghsCXZQ9Y?t=01h51m42s)



[wait is this why the bulb thing wasn't](https://youtu.be/kMghsCXZQ9Y?t=01h51m44s)



[working correctly no Stiles man all](https://youtu.be/kMghsCXZQ9Y?t=01h51m46s)



[right so these we have these here right](https://youtu.be/kMghsCXZQ9Y?t=01h51m49s)



[and this was the thing that we started](https://youtu.be/kMghsCXZQ9Y?t=01h51m56s)



[looking at the beginning which is you](https://youtu.be/kMghsCXZQ9Y?t=01h51m59s)



[know this is a generalization across you](https://youtu.be/kMghsCXZQ9Y?t=01h52m01s)



[know generates a an abstraction that](https://youtu.be/kMghsCXZQ9Y?t=01h52m06s)



[lets us do formatting stuff independent](https://youtu.be/kMghsCXZQ9Y?t=01h52m08s)



[of the type of terminal](https://youtu.be/kMghsCXZQ9Y?t=01h52m11s)



[alright so the ANSI renderings ban](https://youtu.be/kMghsCXZQ9Y?t=01h52m16s)



[visitor maps them to antico's right](https://youtu.be/kMghsCXZQ9Y?t=01h52m18s)



[right this is a mapping of those spans](https://youtu.be/kMghsCXZQ9Y?t=01h52m29s)



[two specific ANSI codes and then if you](https://youtu.be/kMghsCXZQ9Y?t=01h52m31s)



[look at the non ANSI one it does](https://youtu.be/kMghsCXZQ9Y?t=01h52m36s)



[something rather different it maps onto](https://youtu.be/kMghsCXZQ9Y?t=01h52m42s)



[console colors for example and it maps](https://youtu.be/kMghsCXZQ9Y?t=01h52m45s)



[them to ya foreground color mappings](https://youtu.be/kMghsCXZQ9Y?t=01h52m49s)



[background color mappings](https://youtu.be/kMghsCXZQ9Y?t=01h52m53s)



[I just wanted to visit the color span so](https://youtu.be/kMghsCXZQ9Y?t=01h52m54s)



[I've got this color span what should I](https://youtu.be/kMghsCXZQ9Y?t=01h52m59s)



[do it gets the mapping out and then it](https://youtu.be/kMghsCXZQ9Y?t=01h53m01s)



[sets the background color it sort of](https://youtu.be/kMghsCXZQ9Y?t=01h53m02s)



[whereas this one here just can be a lot](https://youtu.be/kMghsCXZQ9Y?t=01h53m06s)



[simpler it just writes out the escape](https://youtu.be/kMghsCXZQ9Y?t=01h53m11s)



[sequence I guess we should look at the](https://youtu.be/kMghsCXZQ9Y?t=01h53m12s)



[yeah background color span compare](https://youtu.be/kMghsCXZQ9Y?t=01h53m17s)



[apples to apples](https://youtu.be/kMghsCXZQ9Y?t=01h53m21s)



[so we could do something similar for](https://youtu.be/kMghsCXZQ9Y?t=01h53m30s)



[this for you know cursor control and](https://youtu.be/kMghsCXZQ9Y?t=01h53m32s)



[screen clearing and things like that and](https://youtu.be/kMghsCXZQ9Y?t=01h53m34s)



[then we just add another method to the](https://youtu.be/kMghsCXZQ9Y?t=01h53m38s)



[visitor and have the two different](https://youtu.be/kMghsCXZQ9Y?t=01h53m39s)



[implementations of it](https://youtu.be/kMghsCXZQ9Y?t=01h53m43s)



[are you proposing something that](https://youtu.be/kMghsCXZQ9Y?t=01h53m52s)



[ultimately derives from span yep so the](https://youtu.be/kMghsCXZQ9Y?t=01h53m54s)



[ANSI class we notice that forwards all](https://youtu.be/kMghsCXZQ9Y?t=01h54m04s)



[these different categories and usually](https://youtu.be/kMghsCXZQ9Y?t=01h54m07s)



[that you know the color category the](https://youtu.be/kMghsCXZQ9Y?t=01h54m09s)



[cursor category is not represented by](https://youtu.be/kMghsCXZQ9Y?t=01h54m11s)



[spans right now when you can use them](https://youtu.be/kMghsCXZQ9Y?t=01h54m13s)



[inside of other stands but like scroll](https://youtu.be/kMghsCXZQ9Y?t=01h54m15s)



[cursor hide show save position all this](https://youtu.be/kMghsCXZQ9Y?t=01h54m18s)



[stuff here inside of cursor we don't](https://youtu.be/kMghsCXZQ9Y?t=01h54m22s)



[have a dedicated span class the way that](https://youtu.be/kMghsCXZQ9Y?t=01h54m25s)



[we do for the foreground and background](https://youtu.be/kMghsCXZQ9Y?t=01h54m29s)



[color spans and stylus bands right but](https://youtu.be/kMghsCXZQ9Y?t=01h54m30s)



[we could have a cursor control span I](https://youtu.be/kMghsCXZQ9Y?t=01h54m35s)



[guess right it's a little bit weird for](https://youtu.be/kMghsCXZQ9Y?t=01h54m37s)



[the system console stuff but I guess it](https://youtu.be/kMghsCXZQ9Y?t=01h54m40s)



[works right and then that thing each of](https://youtu.be/kMghsCXZQ9Y?t=01h54m42s)



[the visitors can act accordingly to](https://youtu.be/kMghsCXZQ9Y?t=01h54m45s)



[translate that into something that works](https://youtu.be/kMghsCXZQ9Y?t=01h54m47s)



[for the specific terminal that it's](https://youtu.be/kMghsCXZQ9Y?t=01h54m49s)



[working what would you put a data on](https://youtu.be/kMghsCXZQ9Y?t=01h54m50s)



[that span I guess it'd have to be an](https://youtu.be/kMghsCXZQ9Y?t=01h54m56s)



[ansi control code wouldn't it no or](https://youtu.be/kMghsCXZQ9Y?t=01h55m01s)



[would you actually effectively duplicate](https://youtu.be/kMghsCXZQ9Y?t=01h55m03s)



[this data exposed I mean that's what we](https://youtu.be/kMghsCXZQ9Y?t=01h55m06s)



[did for the files ban for example right](https://youtu.be/kMghsCXZQ9Y?t=01h55m10s)



[that is true and we did it in a compiler](https://youtu.be/kMghsCXZQ9Y?t=01h55m12s)



[size way by using name of we actively](https://youtu.be/kMghsCXZQ9Y?t=01h55m16s)



[act upon them by name we index them by](https://youtu.be/kMghsCXZQ9Y?t=01h55m21s)



[name so it's a you know it's it's a](https://youtu.be/kMghsCXZQ9Y?t=01h55m23s)



[glorified string it's a string but with](https://youtu.be/kMghsCXZQ9Y?t=01h55m26s)



[some compiler you know differentiated by](https://youtu.be/kMghsCXZQ9Y?t=01h55m28s)



[type so the compiler can help us out but](https://youtu.be/kMghsCXZQ9Y?t=01h55m33s)



[the thing that matters about at the](https://youtu.be/kMghsCXZQ9Y?t=01h55m37s)



[bottom of that into the string got it so](https://youtu.be/kMghsCXZQ9Y?t=01h55m39s)



[we end up with a cursor span with a](https://youtu.be/kMghsCXZQ9Y?t=01h55m42s)



[bunch of statics on it for you know move](https://youtu.be/kMghsCXZQ9Y?t=01h55m44s)



[position or show/hide etc yeah](https://youtu.be/kMghsCXZQ9Y?t=01h55m47s)



[it's not a bad idea you know I think I](https://youtu.be/kMghsCXZQ9Y?t=01h55m55s)



[think we had considered that these](https://youtu.be/kMghsCXZQ9Y?t=01h55m59s)



[things could also just they could just](https://youtu.be/kMghsCXZQ9Y?t=01h56m00s)



[as easily be methods but the thing is](https://youtu.be/kMghsCXZQ9Y?t=01h56m02s)



[that you know if their methods then](https://youtu.be/kMghsCXZQ9Y?t=01h56m04s)



[you'd imagine a method a class that](https://youtu.be/kMghsCXZQ9Y?t=01h56m05s)



[grows over time whereas this is a little](https://youtu.be/kMghsCXZQ9Y?t=01h56m08s)



[bit easier to come in and say you know](https://youtu.be/kMghsCXZQ9Y?t=01h56m10s)



[what I would actually like to implement](https://youtu.be/kMghsCXZQ9Y?t=01h56m11s)



[this obscure additional escape code so](https://youtu.be/kMghsCXZQ9Y?t=01h56m12s)



[this kind of lets people bring in](https://youtu.be/kMghsCXZQ9Y?t=01h56m17s)



[additional functionality without having](https://youtu.be/kMghsCXZQ9Y?t=01h56m19s)



[to go on extend classes or River but it](https://youtu.be/kMghsCXZQ9Y?t=01h56m21s)



[is very kind of close to the middle that](https://youtu.be/kMghsCXZQ9Y?t=01h56m25s)



[is true okay well I think we have two](https://youtu.be/kMghsCXZQ9Y?t=01h56m31s)



[options we go and implement it now or we](https://youtu.be/kMghsCXZQ9Y?t=01h56m36s)



[document it for later uh I think I would](https://youtu.be/kMghsCXZQ9Y?t=01h56m38s)



[vote for the documented for later part I](https://youtu.be/kMghsCXZQ9Y?t=01h56m44s)



[don't know how long you want to spend on](https://youtu.be/kMghsCXZQ9Y?t=01h56m45s)



[this tonight but I think well probably](https://youtu.be/kMghsCXZQ9Y?t=01h56m47s)



[not too much longer we're getting close](https://youtu.be/kMghsCXZQ9Y?t=01h56m52s)



[to that two-hour mark and I](https://youtu.be/kMghsCXZQ9Y?t=01h56m55s)



[unfortunately have to get up for the my](https://youtu.be/kMghsCXZQ9Y?t=01h56m57s)



[son's hospital room tomorrow](https://youtu.be/kMghsCXZQ9Y?t=01h57m03s)



[yeah yeah it works I've got it yeah I've](https://youtu.be/kMghsCXZQ9Y?t=01h57m05s)



[got a I've got a day tomorrow as well um](https://youtu.be/kMghsCXZQ9Y?t=01h57m09s)



[so we can we can open an issue for it](https://youtu.be/kMghsCXZQ9Y?t=01h57m13s)



[yeah let's document this or then real](https://youtu.be/kMghsCXZQ9Y?t=01h57m16s)



[quick and we'll go through and have it](https://youtu.be/kMghsCXZQ9Y?t=01h57m18s)



[for later maybe we'll get lucky somebody](https://youtu.be/kMghsCXZQ9Y?t=01h57m21s)



[on the stream wants to go and pick this](https://youtu.be/kMghsCXZQ9Y?t=01h57m24s)



[up and get it knocked out tonight you](https://youtu.be/kMghsCXZQ9Y?t=01h57m25s)



[could have a poor request by morning Hey](https://youtu.be/kMghsCXZQ9Y?t=01h57m27s)



[okay](https://youtu.be/kMghsCXZQ9Y?t=01h57m34s)



[so let's open on an issue here I want to](https://youtu.be/kMghsCXZQ9Y?t=01h57m38s)



[put the rendering label on it](https://youtu.be/kMghsCXZQ9Y?t=01h57m44s)



[input Help Wanted who knows if it's a](https://youtu.be/kMghsCXZQ9Y?t=01h57m48s)



[good first issue sure how much at the](https://youtu.be/kMghsCXZQ9Y?t=01h57m50s)



[stream the person's been watching yeah](https://youtu.be/kMghsCXZQ9Y?t=01h57m55s)



[good first issue though the the the](https://youtu.be/kMghsCXZQ9Y?t=01h58m00s)



[convention and you know across the](https://youtu.be/kMghsCXZQ9Y?t=01h58m04s)



[dotnet open source projects is that when](https://youtu.be/kMghsCXZQ9Y?t=01h58m07s)



[I put you know for me as a you know](https://youtu.be/kMghsCXZQ9Y?t=01h58m10s)



[contributor on the project if I hook](https://youtu.be/kMghsCXZQ9Y?t=01h58m13s)



[good first issue on something I](https://youtu.be/kMghsCXZQ9Y?t=01h58m16s)



[basically signed myself up to help](https://youtu.be/kMghsCXZQ9Y?t=01h58m17s)



[somebody move a PR to completion on that](https://youtu.be/kMghsCXZQ9Y?t=01h58m19s)



[issue so I'm I'm you know I can I can](https://youtu.be/kMghsCXZQ9Y?t=01h58m22s)



[provide how about provide code reviews](https://youtu.be/kMghsCXZQ9Y?t=01h58m27s)



[etc so for anybody watching this keep](https://youtu.be/kMghsCXZQ9Y?t=01h58m28s)



[that in mind if you want to contribute](https://youtu.be/kMghsCXZQ9Y?t=01h58m36s)



[to this how do you all of the issues](https://youtu.be/kMghsCXZQ9Y?t=01h58m38s)



[labeled with good first issue especially](https://youtu.be/kMghsCXZQ9Y?t=01h58m40s)



[if John's put it on there you can see](https://youtu.be/kMghsCXZQ9Y?t=01h58m42s)



[these clearly a helpful individual who's](https://youtu.be/kMghsCXZQ9Y?t=01h58m44s)



[good at this](https://youtu.be/kMghsCXZQ9Y?t=01h58m47s)



[kind of hard one to explain yeah well I](https://youtu.be/kMghsCXZQ9Y?t=01h58m54s)



[think so I think for a first cut without](https://youtu.be/kMghsCXZQ9Y?t=01h59m00s)



[and I don't necessarily I wouldn't](https://youtu.be/kMghsCXZQ9Y?t=01h59m03s)



[expect somebody to go through an](https://youtu.be/kMghsCXZQ9Y?t=01h59m05s)



[implement it but I would expect the the](https://youtu.be/kMghsCXZQ9Y?t=01h59m06s)



[spans to be there and then the](https://youtu.be/kMghsCXZQ9Y?t=01h59m10s)



[corresponding visitor methods to be](https://youtu.be/kMghsCXZQ9Y?t=01h59m12s)



[created yeah](https://youtu.be/kMghsCXZQ9Y?t=01h59m14s)



[and obviously corresponding unit tests](https://youtu.be/kMghsCXZQ9Y?t=01h59m16s)



[because those visitors I believe are](https://youtu.be/kMghsCXZQ9Y?t=01h59m19s)



[fairly well tested](https://youtu.be/kMghsCXZQ9Y?t=01h59m21s)



[so while you're typing that I'll just go](https://youtu.be/kMghsCXZQ9Y?t=02h00m26s)



[back through and make sure that I'm](https://youtu.be/kMghsCXZQ9Y?t=02h00m29s)



[clear on exactly what we said we were](https://youtu.be/kMghsCXZQ9Y?t=02h00m30s)



[going to do is we'll have effectively a](https://youtu.be/kMghsCXZQ9Y?t=02h00m33s)



[cursor span class that mimics what we](https://youtu.be/kMghsCXZQ9Y?t=02h00m36s)



[have for the was a format span I think](https://youtu.be/kMghsCXZQ9Y?t=02h00m43s)



[that had the various blink bold etc](https://youtu.be/kMghsCXZQ9Y?t=02h00m45s)



[methods on there yep not format stance](https://youtu.be/kMghsCXZQ9Y?t=02h00m48s)



[span style span](https://youtu.be/kMghsCXZQ9Y?t=02h00m53s)



[I think and then on the each of the](https://youtu.be/kMghsCXZQ9Y?t=02h00m57s)



[visitors they should watch for this](https://youtu.be/kMghsCXZQ9Y?t=02h01m04s)



[given span type and the the ANSI visitor](https://youtu.be/kMghsCXZQ9Y?t=02h01m05s)



[should obviously convert it into the](https://youtu.be/kMghsCXZQ9Y?t=02h01m10s)



[corresponding ANSI control codes or](https://youtu.be/kMghsCXZQ9Y?t=02h01m12s)



[escape sequences yep](https://youtu.be/kMghsCXZQ9Y?t=02h01m15s)



[the the non ANSI visitor should convert](https://youtu.be/kMghsCXZQ9Y?t=02h01m17s)



[it into system console calls because at](https://youtu.be/kMghsCXZQ9Y?t=02h01m22s)



[least the cursor positioning stuff](https://youtu.be/kMghsCXZQ9Y?t=02h01m25s)



[system console does support and then for](https://youtu.be/kMghsCXZQ9Y?t=02h01m28s)



[the for the plain text visitor I think](https://youtu.be/kMghsCXZQ9Y?t=02h01m34s)



[it's just straight-up ignore them](https://youtu.be/kMghsCXZQ9Y?t=02h01m41s)



[yeah that's almost always the case the](https://youtu.be/kMghsCXZQ9Y?t=02h01m43s)



[plain text visitor is it ignores](https://youtu.be/kMghsCXZQ9Y?t=02h01m45s)



[everything but content basically yeah](https://youtu.be/kMghsCXZQ9Y?t=02h01m48s)



[exactly](https://youtu.be/kMghsCXZQ9Y?t=02h01m50s)



[so that one's simple don't add a method](https://youtu.be/kMghsCXZQ9Y?t=02h01m52s)



[to it yes I think the base visitor](https://youtu.be/kMghsCXZQ9Y?t=02h01m54s)



[implementation is just empty for](https://youtu.be/kMghsCXZQ9Y?t=02h01m58s)



[everything so this is what is this one](https://youtu.be/kMghsCXZQ9Y?t=02h02m00s)



[called the non ANSI rendering span](https://youtu.be/kMghsCXZQ9Y?t=02h02m05s)



[visitor](https://youtu.be/kMghsCXZQ9Y?t=02h02m09s)



[this is one thing that I would love](https://youtu.be/kMghsCXZQ9Y?t=02h02m26s)



[github implemented is some way to](https://youtu.be/kMghsCXZQ9Y?t=02h02m28s)



[effectively link stuff in your comments](https://youtu.be/kMghsCXZQ9Y?t=02h02m30s)



[to at least with like tool to or](https://youtu.be/kMghsCXZQ9Y?t=02h02m32s)



[autocomplete to link to files in your](https://youtu.be/kMghsCXZQ9Y?t=02h02m37s)



[repo yeah which would be awesome](https://youtu.be/kMghsCXZQ9Y?t=02h02m39s)



[especially if it was smart enough if the](https://youtu.be/kMghsCXZQ9Y?t=02h02m45s)



[file got renamed or whatever to update](https://youtu.be/kMghsCXZQ9Y?t=02h02m47s)



[the comment on the issue so that it](https://youtu.be/kMghsCXZQ9Y?t=02h02m49s)



[could follow it around](https://youtu.be/kMghsCXZQ9Y?t=02h02m52s)



[I'll keep wishing someday I'll get it](https://youtu.be/kMghsCXZQ9Y?t=02h02m58s)



[maybe that's not the best name for this](https://youtu.be/kMghsCXZQ9Y?t=02h03m04s)



[time yeah because I think that output](https://youtu.be/kMghsCXZQ9Y?t=02h03m06s)



[mode used to be called file at one point](https://youtu.be/kMghsCXZQ9Y?t=02h03m12s)



[and then it got renamed down to](https://youtu.be/kMghsCXZQ9Y?t=02h03m14s)



[plaintext you don't think the span](https://youtu.be/kMghsCXZQ9Y?t=02h03m16s)



[visitor just got left behind in the](https://youtu.be/kMghsCXZQ9Y?t=02h03m18s)



[refactor yeah](https://youtu.be/kMghsCXZQ9Y?t=02h03m20s)



[a parenthetical cool something like that](https://youtu.be/kMghsCXZQ9Y?t=02h03m35s)



[sweet cool so if anybody is interested](https://youtu.be/kMghsCXZQ9Y?t=02h03m42s)



[in picking up an issue and working on](https://youtu.be/kMghsCXZQ9Y?t=02h03m49s)



[rendering stuff here's a good one](https://youtu.be/kMghsCXZQ9Y?t=02h03m52s)



[yeah if if you want to add a link to](https://youtu.be/kMghsCXZQ9Y?t=02h03m54s)



[this recording when it's available into](https://youtu.be/kMghsCXZQ9Y?t=02h03m58s)



[this it'll provide more context than](https://youtu.be/kMghsCXZQ9Y?t=02h04m00s)



[anyone could possibly need that is true](https://youtu.be/kMghsCXZQ9Y?t=02h04m03s)



[once I get it I usually export them to](https://youtu.be/kMghsCXZQ9Y?t=02h04m06s)



[YouTube and so I'll just I'll try and be](https://youtu.be/kMghsCXZQ9Y?t=02h04m08s)



[convenient and also pass in the the](https://youtu.be/kMghsCXZQ9Y?t=02h04m11s)



[timestamp for it so that somebody](https://youtu.be/kMghsCXZQ9Y?t=02h04m13s)



[doesn't have to scroll through two hours](https://youtu.be/kMghsCXZQ9Y?t=02h04m15s)



[of video to figure out whether the](https://youtu.be/kMghsCXZQ9Y?t=02h04m17s)



[useful bits start yeah cool sweet well](https://youtu.be/kMghsCXZQ9Y?t=02h04m18s)



[anything else you wanted to look at or](https://youtu.be/kMghsCXZQ9Y?t=02h04m26s)



[any closing thoughts no not really I](https://youtu.be/kMghsCXZQ9Y?t=02h04m28s)



[mean this was this was good very kind of](https://youtu.be/kMghsCXZQ9Y?t=02h04m33s)



[make it up as we go so I didn't really](https://youtu.be/kMghsCXZQ9Y?t=02h04m36s)



[have an agenda so I don't really have](https://youtu.be/kMghsCXZQ9Y?t=02h04m38s)



[clothing boss perfect and I was relying](https://youtu.be/kMghsCXZQ9Y?t=02h04m39s)



[on you for the agenda so that means I](https://youtu.be/kMghsCXZQ9Y?t=02h04m43s)



[don't have much of one either so unless](https://youtu.be/kMghsCXZQ9Y?t=02h04m44s)



[anyone on chat has any final questions](https://youtu.be/kMghsCXZQ9Y?t=02h04m47s)



[the thoughts will probably wrap it up](https://youtu.be/kMghsCXZQ9Y?t=02h04m50s)



[here but thank you John once again for](https://youtu.be/kMghsCXZQ9Y?t=02h04m52s)



[coming on this is always fun I enjoy](https://youtu.be/kMghsCXZQ9Y?t=02h04m53s)



[pairing with you especially going](https://youtu.be/kMghsCXZQ9Y?t=02h04m56s)



[through this project it's been exciting](https://youtu.be/kMghsCXZQ9Y?t=02h04m57s)



[and fun to work on so yeah likewise it's](https://youtu.be/kMghsCXZQ9Y?t=02h04m59s)



[been great and this is the flashing part](https://youtu.be/kMghsCXZQ9Y?t=02h05m03s)



[so people who want to get involved you](https://youtu.be/kMghsCXZQ9Y?t=02h05m07s)



[know it's good almost like UI for those](https://youtu.be/kMghsCXZQ9Y?t=02h05m09s)



[of us who like our WPF it does feel a](https://youtu.be/kMghsCXZQ9Y?t=02h05m13s)



[little more friendly yeah though it's](https://youtu.be/kMghsCXZQ9Y?t=02h05m15s)



[WPF where you have to deal with vt100](https://youtu.be/kMghsCXZQ9Y?t=02h05m19s)



[so it's a weird blend so yeah the](https://youtu.be/kMghsCXZQ9Y?t=02h05m21s)



[technology of future path exactly](https://youtu.be/kMghsCXZQ9Y?t=02h05m30s)



[awesome and thank you Savior for hanging](https://youtu.be/kMghsCXZQ9Y?t=02h05m34s)



[out we appreciate it we will probably](https://youtu.be/kMghsCXZQ9Y?t=02h05m36s)



[end up doing more of these I'm sure at](https://youtu.be/kMghsCXZQ9Y?t=02h05m39s)



[some point John I'll be pinging you for](https://youtu.be/kMghsCXZQ9Y?t=02h05m40s)



[schedule and steal more of your time to](https://youtu.be/kMghsCXZQ9Y?t=02h05m42s)



[do this stuff on the live stream it](https://youtu.be/kMghsCXZQ9Y?t=02h05m45s)



[seems like this is a](https://youtu.be/kMghsCXZQ9Y?t=02h05m47s)



[fairly useful if nothing else he gets me](https://youtu.be/kMghsCXZQ9Y?t=02h05m49s)



[a little more involved on the project so](https://youtu.be/kMghsCXZQ9Y?t=02h05m51s)



[miss I miss our weekly stand-ups on it](https://youtu.be/kMghsCXZQ9Y?t=02h05m56s)



[at times so oh yeah I think this is a](https://youtu.be/kMghsCXZQ9Y?t=02h05m59s)



[good format horrible yeah works well](https://youtu.be/kMghsCXZQ9Y?t=02h06m02s)



[well with that I'm going to kill the](https://youtu.be/kMghsCXZQ9Y?t=02h06m07s)



[stream and I will get some stuff](https://youtu.be/kMghsCXZQ9Y?t=02h06m11s)



[uploading thanks guys for hanging out by](https://youtu.be/kMghsCXZQ9Y?t=02h06m12s)



[fuck okay](https://youtu.be/kMghsCXZQ9Y?t=02h06m16s)


