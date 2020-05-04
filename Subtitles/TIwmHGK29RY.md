[YouTube Video](https://youtu.be/TIwmHGK29RY)


[okay welcome everybody tonight is going](https://youtu.be/TIwmHGK29RY?t=00h00m02s)



[to be something a little new and](https://youtu.be/TIwmHGK29RY?t=00h00m05s)



[different mark Michaelis is back again](https://youtu.be/TIwmHGK29RY?t=00h00m07s)



[we are on a quest to try and understand](https://youtu.be/TIwmHGK29RY?t=00h00m10s)



[garbage collection in dotnet we had some](https://youtu.be/TIwmHGK29RY?t=00h00m13s)



[questions come up just how it works the](https://youtu.be/TIwmHGK29RY?t=00h00m17s)



[difference is between dotnet Cornette](https://youtu.be/TIwmHGK29RY?t=00h00m20s)



[framework and so we are going to](https://youtu.be/TIwmHGK29RY?t=00h00m22s)



[basically be playing around tonight and](https://youtu.be/TIwmHGK29RY?t=00h00m24s)



[see what we can learn and see how much](https://youtu.be/TIwmHGK29RY?t=00h00m26s)



[we can test something that we only have](https://youtu.be/TIwmHGK29RY?t=00h00m29s)



[limited control over so mark welcome](https://youtu.be/TIwmHGK29RY?t=00h00m31s)



[thank you](https://youtu.be/TIwmHGK29RY?t=00h00m35s)



[well it be here again awesome okay so I](https://youtu.be/TIwmHGK29RY?t=00h00m36s)



[have done as absolutely as little as](https://youtu.be/TIwmHGK29RY?t=00h00m41s)



[humanly possible I have a PowerShell](https://youtu.be/TIwmHGK29RY?t=00h00m45s)



[script that literally prints hello world](https://youtu.be/TIwmHGK29RY?t=00h00m47s)



[and I ran a dotnet new for a console](https://youtu.be/TIwmHGK29RY?t=00h00m49s)



[project so we've got pretty much nothing](https://youtu.be/TIwmHGK29RY?t=00h00m53s)



[I well I've got two HelloWorld](https://youtu.be/TIwmHGK29RY?t=00h00m56s)



[implementations which is exciting what](https://youtu.be/TIwmHGK29RY?t=00h00m58s)



[is exciting stuff](https://youtu.be/TIwmHGK29RY?t=00h01m00s)



[the c-sharp extension is recommended for](https://youtu.be/TIwmHGK29RY?t=00h01m02s)



[this file actually I should probably](https://youtu.be/TIwmHGK29RY?t=00h01m04s)



[have that so don't mind me I'm just](https://youtu.be/TIwmHGK29RY?t=00h01m05s)



[clicking buttons okay so where did you](https://youtu.be/TIwmHGK29RY?t=00h01m09s)



[want to go first cuz i you'd sent me a](https://youtu.be/TIwmHGK29RY?t=00h01m12s)



[list of like four things to try what's](https://youtu.be/TIwmHGK29RY?t=00h01m14s)



[right I think the first thing is to see](https://youtu.be/TIwmHGK29RY?t=00h01m17s)



[how the finalizar get called when the](https://youtu.be/TIwmHGK29RY?t=00h01m20s)



[program shuts down in dawnia core so if](https://youtu.be/TIwmHGK29RY?t=00h01m23s)



[we go write a class that's called a](https://youtu.be/TIwmHGK29RY?t=00h01m27s)



[thing perhaps and I and for ease you](https://youtu.be/TIwmHGK29RY?t=00h01m29s)



[know you might want to consider putting](https://youtu.be/TIwmHGK29RY?t=00h01m33s)



[both in the same file yeah exactly yeah](https://youtu.be/TIwmHGK29RY?t=00h01m34s)



[we don't need a bounce around this is](https://youtu.be/TIwmHGK29RY?t=00h01m36s)



[this is literally about as simple as](https://youtu.be/TIwmHGK29RY?t=00h01m38s)



[pasta I don't know if you're watching](https://youtu.be/TIwmHGK29RY?t=00h01m40s)



[the the Twitter chat Meghan says hello](https://youtu.be/TIwmHGK29RY?t=00h01m42s)



[all right Megan so okay so now we want](https://youtu.be/TIwmHGK29RY?t=00h01m46s)



[I'm kind of surprised that Meghan you](https://youtu.be/TIwmHGK29RY?t=00h01m51s)



[know decided to listen to us more she's](https://youtu.be/TIwmHGK29RY?t=00h01m53s)



[listened to us quite a bit already that](https://youtu.be/TIwmHGK29RY?t=00h01m55s)



[is true to me people so let's put a](https://youtu.be/TIwmHGK29RY?t=00h01m59s)



[finalized let's just go ahead and write](https://youtu.be/TIwmHGK29RY?t=00h02m07s)



[out a message so executing finalizer](https://youtu.be/TIwmHGK29RY?t=00h02m08s)



[I assume we're talking just console](https://youtu.be/TIwmHGK29RY?t=00h02m13s)



[right yeah that's great](https://youtu.be/TIwmHGK29RY?t=00h02m15s)



[they can be gone you had a fancier](https://youtu.be/TIwmHGK29RY?t=00h02m19s)



[phrase but I can spell thing begone exit](https://youtu.be/TIwmHGK29RY?t=00h02m24s)



[well I would hate to push your](https://youtu.be/TIwmHGK29RY?t=00h02m28s)



[vocabulary to use words like executing](https://youtu.be/TIwmHGK29RY?t=00h02m31s)



[and finalizar so that's good enough for](https://youtu.be/TIwmHGK29RY?t=00h02m33s)



[me](https://youtu.be/TIwmHGK29RY?t=00h02m34s)



[perfect and let's go ahead and declare a](https://youtu.be/TIwmHGK29RY?t=00h02m35s)



[this declared a method called do](https://youtu.be/TIwmHGK29RY?t=00h02m42s)



[something inside a thing no no sorry](https://youtu.be/TIwmHGK29RY?t=00h02m44s)



[inside main or outside it mean well you](https://youtu.be/TIwmHGK29RY?t=00h02m47s)



[know we could should try it in Maine](https://youtu.be/TIwmHGK29RY?t=00h02m50s)



[because I think that's the more](https://youtu.be/TIwmHGK29RY?t=00h02m51s)



[interesting problem to look at so let's](https://youtu.be/TIwmHGK29RY?t=00h02m52s)



[just go ahead and do it inside Maine](https://youtu.be/TIwmHGK29RY?t=00h02m53s)



[okay and go ahead and stand sheet thing](https://youtu.be/TIwmHGK29RY?t=00h02m54s)



[I'm trying to set up for a for a dr.](https://youtu.be/TIwmHGK29RY?t=00h02m59s)



[Seuss reference yeah I see does that](https://youtu.be/TIwmHGK29RY?t=00h03m04s)



[mean we have to come up with another](https://youtu.be/TIwmHGK29RY?t=00h03m08s)



[variable listen maybe a name like thing](https://youtu.be/TIwmHGK29RY?t=00h03m09s)



[- maybe yes that would be ideal okay](https://youtu.be/TIwmHGK29RY?t=00h03m12s)



[good I try to prep my jokes in advance](https://youtu.be/TIwmHGK29RY?t=00h03m14s)



[uh-huh I think that's good enough let's](https://youtu.be/TIwmHGK29RY?t=00h03m16s)



[see what happens](https://youtu.be/TIwmHGK29RY?t=00h03m19s)



[oh just compile and run well sure I mean](https://youtu.be/TIwmHGK29RY?t=00h03m20s)



[we've got to finalize it we've been](https://youtu.be/TIwmHGK29RY?t=00h03m24s)



[stand she did a thing what's what's](https://youtu.be/TIwmHGK29RY?t=00h03m25s)



[gonna happen now ah good question so](https://youtu.be/TIwmHGK29RY?t=00h03m26s)



[something about dotnet run](https://youtu.be/TIwmHGK29RY?t=00h03m31s)



[that's not a good sign so observation](https://youtu.be/TIwmHGK29RY?t=00h03m37s)



[number one we have a finalizar and we've](https://youtu.be/TIwmHGK29RY?t=00h03m42s)



[been sent shaded a thing and we would](https://youtu.be/TIwmHGK29RY?t=00h03m46s)



[expect no abnormal circumstances that](https://youtu.be/TIwmHGK29RY?t=00h03m48s)



[our thing would be disposed of](https://youtu.be/TIwmHGK29RY?t=00h03m52s)



[so and let's see net core finalizar it's](https://youtu.be/TIwmHGK29RY?t=00h03m55s)



[not here to be called on shut down](https://youtu.be/TIwmHGK29RY?t=00h04m03s)



[alright so that's a little bit](https://youtu.be/TIwmHGK29RY?t=00h04m09s)



[disconcerting why don't we try put the](https://youtu.be/TIwmHGK29RY?t=00h04m11s)



[instantiation inside another method so](https://youtu.be/TIwmHGK29RY?t=00h04m14s)



[let's try to do something method let's](https://youtu.be/TIwmHGK29RY?t=00h04m17s)



[instantiate thing one there we could](https://youtu.be/TIwmHGK29RY?t=00h04m21s)



[call it a thing too if you like we'll](https://youtu.be/TIwmHGK29RY?t=00h04m27s)



[just move that line down yep yeah and](https://youtu.be/TIwmHGK29RY?t=00h04m28s)



[now try it again](https://youtu.be/TIwmHGK29RY?t=00h04m31s)



[swing-and-a-miss no worky so the only](https://youtu.be/TIwmHGK29RY?t=00h04m38s)



[other thing that might be worth trying](https://youtu.be/TIwmHGK29RY?t=00h04m40s)



[is a change it to a framework project](https://youtu.be/TIwmHGK29RY?t=00h04m42s)



[mm-hmm so rather than targeting net core](https://youtu.be/TIwmHGK29RY?t=00h04m45s)



[so net four five I think that four or](https://youtu.be/TIwmHGK29RY?t=00h04m48s)



[five is good that sounds like a good](https://youtu.be/TIwmHGK29RY?t=00h04m53s)



[number to me I'm just trying to go as](https://youtu.be/TIwmHGK29RY?t=00h04m54s)



[old as possible that's interesting](https://youtu.be/TIwmHGK29RY?t=00h04m56s)



[we've still got nothing so according to](https://youtu.be/TIwmHGK29RY?t=00h05m02s)



[the documentation justjust just out of](https://youtu.be/TIwmHGK29RY?t=00h05m04s)



[curiosity right so public thing right](https://youtu.be/TIwmHGK29RY?t=00h05m08s)



[I'm just you want to make sure that we](https://youtu.be/TIwmHGK29RY?t=00h05m11s)



[actually create this thing all right](https://youtu.be/TIwmHGK29RY?t=00h05m16s)



[like because for example you'll note](https://youtu.be/TIwmHGK29RY?t=00h05m22s)



[that one of us forgot to call do thing](https://youtu.be/TIwmHGK29RY?t=00h05m27s)



[oh my goodness details oh so I'm typing](https://youtu.be/TIwmHGK29RY?t=00h05m28s)



[so that has to be me that made that](https://youtu.be/TIwmHGK29RY?t=00h05m33s)



[mistake well clearly it is always the](https://youtu.be/TIwmHGK29RY?t=00h05m34s)



[navigators fault never the driver that's](https://youtu.be/TIwmHGK29RY?t=00h05m36s)



[true unless I'm navigating I mean this](https://youtu.be/TIwmHGK29RY?t=00h05m39s)



[I'm the driving then it's different](https://youtu.be/TIwmHGK29RY?t=00h05m41s)



[oh look at that so now thing be gone](https://youtu.be/TIwmHGK29RY?t=00h05m42s)



[okay now that's changed the project back](https://youtu.be/TIwmHGK29RY?t=00h05m47s)



[to a net core at war yeah now I do the](https://youtu.be/TIwmHGK29RY?t=00h05m50s)



[same thing just just for my sanity](https://youtu.be/TIwmHGK29RY?t=00h05m56s)



[I think asking for your sanity is asking](https://youtu.be/TIwmHGK29RY?t=00h06m07s)



[for a lot I I realized that that is a](https://youtu.be/TIwmHGK29RY?t=00h06m09s)



[problem so inside of net core we don't](https://youtu.be/TIwmHGK29RY?t=00h06m11s)



[guarantee our finalizar](https://youtu.be/TIwmHGK29RY?t=00h06m16s)



[this is exactly right and I think you](https://youtu.be/TIwmHGK29RY?t=00h06m18s)



[know this is a fairly unknown it's](https://youtu.be/TIwmHGK29RY?t=00h06m20s)



[called it a secret feature what should](https://youtu.be/TIwmHGK29RY?t=00h06m23s)



[we call it well isn't that what we call](https://youtu.be/TIwmHGK29RY?t=00h06m25s)



[undocumented features yes yes I guess](https://youtu.be/TIwmHGK29RY?t=00h06m32s)



[but I think it's only a bug if it wasn't](https://youtu.be/TIwmHGK29RY?t=00h06m35s)



[intentional and and I I think the team](https://youtu.be/TIwmHGK29RY?t=00h06m37s)



[is well aware of this behavior and it](https://youtu.be/TIwmHGK29RY?t=00h06m41s)



[was not done without the awareness to](https://youtu.be/TIwmHGK29RY?t=00h06m43s)



[put to put this in there and so it's my](https://youtu.be/TIwmHGK29RY?t=00h06m47s)



[understanding that is intentionally at](https://youtu.be/TIwmHGK29RY?t=00h06m53s)



[least is documented as being the fact](https://youtu.be/TIwmHGK29RY?t=00h06m54s)



[that dotnet core does not guarantee that](https://youtu.be/TIwmHGK29RY?t=00h06m57s)



[you finalized it will get court call so](https://youtu.be/TIwmHGK29RY?t=00h06m59s)



[at a curiosity can you where is that](https://youtu.be/TIwmHGK29RY?t=00h07m01s)



[documentation page again right also](https://youtu.be/TIwmHGK29RY?t=00h07m04s)



[there's universal agreement among the](https://youtu.be/TIwmHGK29RY?t=00h07m07s)



[people chatting that it is either an odd](https://youtu.be/TIwmHGK29RY?t=00h07m08s)



[feature hated or a secret so I can give](https://youtu.be/TIwmHGK29RY?t=00h07m10s)



[you that I mean I can I can try to hunt](https://youtu.be/TIwmHGK29RY?t=00h07m18s)



[too or I got it I got it widow how do I](https://youtu.be/TIwmHGK29RY?t=00h07m24s)



[check this with you I got it well we're](https://youtu.be/TIwmHGK29RY?t=00h07m26s)



[in a Skype call so one would think that](https://youtu.be/TIwmHGK29RY?t=00h07m29s)



[Skype would be able to send links yeah I](https://youtu.be/TIwmHGK29RY?t=00h07m30s)



[like that one so boom that guy so for](https://youtu.be/TIwmHGK29RY?t=00h07m34s)



[those people playing along at home but I](https://youtu.be/TIwmHGK29RY?t=00h07m39s)



[don't send you the right link no you did](https://youtu.be/TIwmHGK29RY?t=00h07m47s)



[this is the one you were looking for](https://youtu.be/TIwmHGK29RY?t=00h07m48s)



[correct yeah](https://youtu.be/TIwmHGK29RY?t=00h07m50s)



[finalize our c-sharp programming guide](https://youtu.be/TIwmHGK29RY?t=00h07m52s)



[no it's just you sent it with the pound](https://youtu.be/TIwmHGK29RY?t=00h07m54s)



[feedback so jump me all the way to the](https://youtu.be/TIwmHGK29RY?t=00h07m56s)



[end oh I apologize I forgive you](https://youtu.be/TIwmHGK29RY?t=00h07m58s)



[thank you hopefully that happens more](https://youtu.be/TIwmHGK29RY?t=00h08m00s)



[than once today that you apologize or](https://youtu.be/TIwmHGK29RY?t=00h08m03s)



[that I forgive you the latter excellent](https://youtu.be/TIwmHGK29RY?t=00h08m06s)



[so something empty final I should not be](https://youtu.be/TIwmHGK29RY?t=00h08m10s)



[used yeah so that line right there in](https://youtu.be/TIwmHGK29RY?t=00h08m16s)



[dotnet framework applications but not in](https://youtu.be/TIwmHGK29RY?t=00h08m21s)



[dotnet core applications finalized errs](https://youtu.be/TIwmHGK29RY?t=00h08m24s)



[are also called when the program exits I](https://youtu.be/TIwmHGK29RY?t=00h08m26s)



[think we can't conclusively say that](https://youtu.be/TIwmHGK29RY?t=00h08m29s)



[that line is true yes indeed so I think](https://youtu.be/TIwmHGK29RY?t=00h08m32s)



[the reason why this is so intriguing to](https://youtu.be/TIwmHGK29RY?t=00h08m38s)



[me is that we have this idea and we've](https://youtu.be/TIwmHGK29RY?t=00h08m41s)



[sort of you know I'm we've written about](https://youtu.be/TIwmHGK29RY?t=00h08m44s)



[it this we've stated us that assuming](https://youtu.be/TIwmHGK29RY?t=00h08m46s)



[normal circumstances other than you know](https://youtu.be/TIwmHGK29RY?t=00h08m48s)



[the complete computer not you know being](https://youtu.be/TIwmHGK29RY?t=00h08m50s)



[shut down or the debugger stopping the](https://youtu.be/TIwmHGK29RY?t=00h08m52s)



[program fine analyzers will always be](https://youtu.be/TIwmHGK29RY?t=00h08m54s)



[executed sometime between when they go](https://youtu.be/TIwmHGK29RY?t=00h08m56s)



[out of scope or when the application](https://youtu.be/TIwmHGK29RY?t=00h08m58s)



[shuts down yeah and that's been true](https://youtu.be/TIwmHGK29RY?t=00h09m00s)



[since c-sharp why not oh right that's](https://youtu.be/TIwmHGK29RY?t=00h09m03s)



[that's the rule the finalizer will get](https://youtu.be/TIwmHGK29RY?t=00h09m05s)



[called before the application shuts down](https://youtu.be/TIwmHGK29RY?t=00h09m07s)



[you don't know when but it will happen](https://youtu.be/TIwmHGK29RY?t=00h09m08s)



[and clearly we're saying that that is no](https://youtu.be/TIwmHGK29RY?t=00h09m10s)



[longer the case and we've got very](https://youtu.be/TIwmHGK29RY?t=00h09m14s)



[simple code to prove it right and so if](https://youtu.be/TIwmHGK29RY?t=00h09m15s)



[we merely do so let's just okay because](https://youtu.be/TIwmHGK29RY?t=00h09m20s)



[now I'm right you're right so we're](https://youtu.be/TIwmHGK29RY?t=00h09m24s)



[gonna go async main because I can oh](https://youtu.be/TIwmHGK29RY?t=00h09m27s)



[right](https://youtu.be/TIwmHGK29RY?t=00h09m29s)



[something about laying version latest](https://youtu.be/TIwmHGK29RY?t=00h09m30s)



[because I don't think too hard for those](https://youtu.be/TIwmHGK29RY?t=00h09m36s)



[people watching latest is a bad idea for](https://youtu.be/TIwmHGK29RY?t=00h09m41s)



[most projects because it'll depend on](https://youtu.be/TIwmHGK29RY?t=00h09m43s)



[what's installed on the system](https://youtu.be/TIwmHGK29RY?t=00h09m45s)



[what oh could not be found okay fine](https://youtu.be/TIwmHGK29RY?t=00h09m48s)



[include it for me please](https://youtu.be/TIwmHGK29RY?t=00h09m51s)



[pretty please so I'm curious if I do do](https://youtu.be/TIwmHGK29RY?t=00h09m53s)



[thing and then just do something like a](https://youtu.be/TIwmHGK29RY?t=00h09m56s)



[weight TAS delay of a second right even](https://youtu.be/TIwmHGK29RY?t=00h09m57s)



[in dotnet core I would hope I I don't](https://youtu.be/TIwmHGK29RY?t=00h10m03s)



[think so because what's gonna trigger](https://youtu.be/TIwmHGK29RY?t=00h10m08s)



[that final answer you know you're not](https://youtu.be/TIwmHGK29RY?t=00h10m09s)



[putting pressure on memory I'm I just](https://youtu.be/TIwmHGK29RY?t=00h10m11s)



[sort of I mean you're right you're right](https://youtu.be/TIwmHGK29RY?t=00h10m15s)



[this is on particular circumstances so I](https://youtu.be/TIwmHGK29RY?t=00h10m17s)



[I don't know well so GC now](https://youtu.be/TIwmHGK29RY?t=00h10m19s)



[think you gotta get yourself so yes so](https://youtu.be/TIwmHGK29RY?t=00h10m24s)



[hold on one second](https://youtu.be/TIwmHGK29RY?t=00h10m27s)



[GC collect runs synchronously and it](https://youtu.be/TIwmHGK29RY?t=00h10m28s)



[will stop the program you won't need the](https://youtu.be/TIwmHGK29RY?t=00h10m31s)



[delay if that works good point try](https://youtu.be/TIwmHGK29RY?t=00h10m33s)



[without the delay first yes yes because](https://youtu.be/TIwmHGK29RY?t=00h10m36s)



[I'm wondering if I just give it enough](https://youtu.be/TIwmHGK29RY?t=00h10m41s)



[time yeah okay](https://youtu.be/TIwmHGK29RY?t=00h10m42s)



[what so GC collect what what was the](https://youtu.be/TIwmHGK29RY?t=00h10m49s)



[namespace for garbage collection it](https://youtu.be/TIwmHGK29RY?t=00h10m56s)



[since a lot of it some system yes not](https://youtu.be/TIwmHGK29RY?t=00h10m58s)



[just a control in it I would love to but](https://youtu.be/TIwmHGK29RY?t=00h11m05s)



[it wants to introduce a local for GC](https://youtu.be/TIwmHGK29RY?t=00h11m08s)



[collect and that seems wrong and I'm not](https://youtu.be/TIwmHGK29RY?t=00h11m10s)



[used to coding without my fancy visual](https://youtu.be/TIwmHGK29RY?t=00h11m18s)



[studio well we can switch of course](https://youtu.be/TIwmHGK29RY?t=00h11m20s)



[they're in hold up its insistent like I](https://youtu.be/TIwmHGK29RY?t=00h11m23s)



[said then explain that to me](https://youtu.be/TIwmHGK29RY?t=00h11m29s)



[I think it's going to have to take](https://youtu.be/TIwmHGK29RY?t=00h11m35s)



[system yes that should be there yeah](https://youtu.be/TIwmHGK29RY?t=00h11m38s)



[jarred you are right on the mark but I](https://youtu.be/TIwmHGK29RY?t=00h11m41s)



[don't see it Sonic 3.1 do you see that](https://youtu.be/TIwmHGK29RY?t=00h11m45s)



[should work III don't disagree okay](https://youtu.be/TIwmHGK29RY?t=00h11m52s)



[trying to run it anyway let's see what](https://youtu.be/TIwmHGK29RY?t=00h11m57s)



[happens okay so clearly Omni sharp is](https://youtu.be/TIwmHGK29RY?t=00h11m59s)



[just out of its mind yes I think the](https://youtu.be/TIwmHGK29RY?t=00h12m04s)



[tripod system in front of it see if that](https://youtu.be/TIwmHGK29RY?t=00h12m07s)



[helps](https://youtu.be/TIwmHGK29RY?t=00h12m08s)



[really really Omni sharp really clearly](https://youtu.be/TIwmHGK29RY?t=00h12m13s)



[it does and it also clearly doesn't](https://youtu.be/TIwmHGK29RY?t=00h12m20s)



[actually force it to run right so](https://youtu.be/TIwmHGK29RY?t=00h12m22s)



[because the one thing I was wanting to](https://youtu.be/TIwmHGK29RY?t=00h12m25s)



[oh hold on](https://youtu.be/TIwmHGK29RY?t=00h12m27s)



[save your file first before you do that](https://youtu.be/TIwmHGK29RY?t=00h12m28s)



[the one thing I was wanting to see is a](https://youtu.be/TIwmHGK29RY?t=00h12m30s)



[finalizar run there there we go yes yeah](https://youtu.be/TIwmHGK29RY?t=00h12m32s)



[so that's actually really important cuz](https://youtu.be/TIwmHGK29RY?t=00h12m35s)



[I want to prove that finalizes work in](https://youtu.be/TIwmHGK29RY?t=00h12m37s)



[net core right like I would I don't](https://youtu.be/TIwmHGK29RY?t=00h12m39s)



[think you need to delay statement I](https://youtu.be/TIwmHGK29RY?t=00h12m42s)



[think that should work I I find it](https://youtu.be/TIwmHGK29RY?t=00h12m44s)



[interesting that using PowerShell](https://youtu.be/TIwmHGK29RY?t=00h12m45s)



[commenting there but okay I'm actually](https://youtu.be/TIwmHGK29RY?t=00h12m47s)



[kind of surprised to see you using a](https://youtu.be/TIwmHGK29RY?t=00h12m50s)



[poundabout do partial kinda you know I](https://youtu.be/TIwmHGK29RY?t=00h12m52s)



[know I was doing scripting earlier and](https://youtu.be/TIwmHGK29RY?t=00h12m53s)



[it unfortunately penetrated my fingers](https://youtu.be/TIwmHGK29RY?t=00h12m56s)



[what's your warning oh I did it I don't](https://youtu.be/TIwmHGK29RY?t=00h12m59s)



[know I now have an async main without a](https://youtu.be/TIwmHGK29RY?t=00h13m03s)



[but okay so the JC collect did tell the](https://youtu.be/TIwmHGK29RY?t=00h13m05s)



[thing please go and clean up and it said](https://youtu.be/TIwmHGK29RY?t=00h13m10s)



[okay sure I got nothing better to do](https://youtu.be/TIwmHGK29RY?t=00h13m13s)



[yeah and and the the rule about GC](https://youtu.be/TIwmHGK29RY?t=00h13m14s)



[collect it it will run for every](https://youtu.be/TIwmHGK29RY?t=00h13m17s)



[finalizar that is in the finalization](https://youtu.be/TIwmHGK29RY?t=00h13m19s)



[queue so it does force finalization to](https://youtu.be/TIwmHGK29RY?t=00h13m21s)



[happen and and that you know as long as](https://youtu.be/TIwmHGK29RY?t=00h13m24s)



[nothing's holding on to that object you](https://youtu.be/TIwmHGK29RY?t=00h13m27s)



[should be good but the idea that we](https://youtu.be/TIwmHGK29RY?t=00h13m29s)



[would have to call GC collect at the](https://youtu.be/TIwmHGK29RY?t=00h13m32s)



[exit of every program you know is that a](https://youtu.be/TIwmHGK29RY?t=00h13m35s)



[viable approach maybe unless of course](https://youtu.be/TIwmHGK29RY?t=00h13m38s)



[you got something holding on to it and](https://youtu.be/TIwmHGK29RY?t=00h13m41s)



[so the big concern here is would it be](https://youtu.be/TIwmHGK29RY?t=00h13m42s)



[okay to have a standard that says or a](https://youtu.be/TIwmHGK29RY?t=00h13m45s)



[school system that GC collect which](https://youtu.be/TIwmHGK29RY?t=00h13m46s)



[obviously Microsoft chose not to do](https://youtu.be/TIwmHGK29RY?t=00h13m49s)



[automatically but if you do and you've](https://youtu.be/TIwmHGK29RY?t=00h13m51s)



[got something that is still being kind](https://youtu.be/TIwmHGK29RY?t=00h13m53s)



[of something still pointing to it](https://youtu.be/TIwmHGK29RY?t=00h13m55s)



[something stood in scope then it doesn't](https://youtu.be/TIwmHGK29RY?t=00h14m00s)



[matter to you call DC's collect because](https://youtu.be/TIwmHGK29RY?t=00h14m02s)



[that thing doesn't go out of scope until](https://youtu.be/TIwmHGK29RY?t=00h14m04s)



[the program exits so if you had for](https://youtu.be/TIwmHGK29RY?t=00h14m05s)



[example this is a static variable you](https://youtu.be/TIwmHGK29RY?t=00h14m07s)



[still wouldn't run the finalizer](https://youtu.be/TIwmHGK29RY?t=00h14m09s)



[yeah but isn't there](https://youtu.be/TIwmHGK29RY?t=00h14m10s)



[isn't there concurrent gc2 wouldn't that](https://youtu.be/TIwmHGK29RY?t=00h14m16s)



[it's not gonna help you because no but](https://youtu.be/TIwmHGK29RY?t=00h14m21s)



[I'm not think it would help I'm thinking](https://youtu.be/TIwmHGK29RY?t=00h14m24s)



[it would hurt right if you call GC](https://youtu.be/TIwmHGK29RY?t=00h14m25s)



[collect and there was a concurrent](https://youtu.be/TIwmHGK29RY?t=00h14m27s)



[garbage collection like if that that](https://youtu.be/TIwmHGK29RY?t=00h14m29s)



[would clean up most things well what](https://youtu.be/TIwmHGK29RY?t=00h14m33s)



[about something that gets like promoted](https://youtu.be/TIwmHGK29RY?t=00h14m35s)



[to like a large object keep or something](https://youtu.be/TIwmHGK29RY?t=00h14m38s)



[right does it like so if you have](https://youtu.be/TIwmHGK29RY?t=00h14m40s)



[something like an object this](https://youtu.be/TIwmHGK29RY?t=00h14m45s)



[resurrected or something like that it](https://youtu.be/TIwmHGK29RY?t=00h14m46s)



[doesn't really change I don't think it](https://youtu.be/TIwmHGK29RY?t=00h14m47s)



[you're introducing unnecessary](https://youtu.be/TIwmHGK29RY?t=00h14m48s)



[complexity I don't think it matters okay](https://youtu.be/TIwmHGK29RY?t=00h14m49s)



[as long as the object has a reference to](https://youtu.be/TIwmHGK29RY?t=00h14m53s)



[it it will not get it cleaned up by the](https://youtu.be/TIwmHGK29RY?t=00h14m56s)



[finalizar okay so let me ask one other](https://youtu.be/TIwmHGK29RY?t=00h14m57s)



[dumb question then so the finalizar](https://youtu.be/TIwmHGK29RY?t=00h15m04s)



[doesn't get called but but what but when](https://youtu.be/TIwmHGK29RY?t=00h15m06s)



[does it actually matter right like so](https://youtu.be/TIwmHGK29RY?t=00h15m13s)



[this is the important part about](https://youtu.be/TIwmHGK29RY?t=00h15m16s)



[finalization right remember that final](https://youtu.be/TIwmHGK29RY?t=00h15m18s)



[answer is not used to manage memory yeah](https://youtu.be/TIwmHGK29RY?t=00h15m20s)



[only used to manage resources that are](https://youtu.be/TIwmHGK29RY?t=00h15m23s)



[not managed by the vine and so you know](https://youtu.be/TIwmHGK29RY?t=00h15m25s)



[the example that I like to use which is](https://youtu.be/TIwmHGK29RY?t=00h15m32s)



[not a bad example which is a bad example](https://youtu.be/TIwmHGK29RY?t=00h15m33s)



[cuz there's other ways to do this is hey](https://youtu.be/TIwmHGK29RY?t=00h15m36s)



[what if I have something that I created](https://youtu.be/TIwmHGK29RY?t=00h15m37s)



[like a very large temporary file and I](https://youtu.be/TIwmHGK29RY?t=00h15m39s)



[want to make sure that file gets to lead](https://youtu.be/TIwmHGK29RY?t=00h15m42s)



[it before the application shuts down now](https://youtu.be/TIwmHGK29RY?t=00h15m44s)



[there are rules you can actually create](https://youtu.be/TIwmHGK29RY?t=00h15m46s)



[an event on a new file so that it gets](https://youtu.be/TIwmHGK29RY?t=00h15m48s)



[shut down automatically when the file](https://youtu.be/TIwmHGK29RY?t=00h15m50s)



[when the stream is closed and be](https://youtu.be/TIwmHGK29RY?t=00h15m52s)



[interesting to look at the code to find](https://youtu.be/TIwmHGK29RY?t=00h15m56s)



[out if that's actually using a finalizer](https://youtu.be/TIwmHGK29RY?t=00h15m57s)



[but that's beside the point right now](https://youtu.be/TIwmHGK29RY?t=00h15m58s)



[the the idea here is that you want](https://youtu.be/TIwmHGK29RY?t=00h16m01s)



[something to happen when the application](https://youtu.be/TIwmHGK29RY?t=00h16m04s)



[shuts down so that whatever it was doing](https://youtu.be/TIwmHGK29RY?t=00h16m06s)



[or consuming or losing no longer is](https://youtu.be/TIwmHGK29RY?t=00h16m07s)



[being consumed so that makes sense and](https://youtu.be/TIwmHGK29RY?t=00h16m10s)



[that kind of because Jared asked the](https://youtu.be/TIwmHGK29RY?t=00h16m13s)



[question what are some examples of](https://youtu.be/TIwmHGK29RY?t=00h16m14s)



[finalizes that you'd want to run prior](https://youtu.be/TIwmHGK29RY?t=00h16m15s)



[to an app shutdown and I think that](https://youtu.be/TIwmHGK29RY?t=00h16m17s)



[plays sort of right into that yeah I](https://youtu.be/TIwmHGK29RY?t=00h16m20s)



[mean I can also think of like a process](https://youtu.be/TIwmHGK29RY?t=00h16m23s)



[to write like something something that's](https://youtu.be/TIwmHGK29RY?t=00h16m24s)



[it would have to be something that lives](https://youtu.be/TIwmHGK29RY?t=00h16m28s)



[outside of your app something that lives](https://youtu.be/TIwmHGK29RY?t=00h16m30s)



[at a system level right - I wouldn't](https://youtu.be/TIwmHGK29RY?t=00h16m32s)



[imagine but I well I think fuck if they](https://youtu.be/TIwmHGK29RY?t=00h16m35s)



[handled by safe handles so I I don't](https://youtu.be/TIwmHGK29RY?t=00h16m38s)



[know oh they are probably well like I](https://youtu.be/TIwmHGK29RY?t=00h16m40s)



[don't doubt that a socket probably has](https://youtu.be/TIwmHGK29RY?t=00h16m46s)



[its own finalizar but if I can't](https://youtu.be/TIwmHGK29RY?t=00h16m49s)



[guarantee that that actually gets called](https://youtu.be/TIwmHGK29RY?t=00h16m50s)



[so so how many source how about a mutex](https://youtu.be/TIwmHGK29RY?t=00h16m53s)



[yeah a mutex is something that should](https://youtu.be/TIwmHGK29RY?t=00h16m59s)



[should work across processes in order to](https://youtu.be/TIwmHGK29RY?t=00h17m03s)



[do things like make sure you don't write](https://youtu.be/TIwmHGK29RY?t=00h17m06s)



[a process more than X number of times or](https://youtu.be/TIwmHGK29RY?t=00h17m07s)



[something like that yeah if you you got](https://youtu.be/TIwmHGK29RY?t=00h17m09s)



[to make sure you clean up their mutex](https://youtu.be/TIwmHGK29RY?t=00h17m11s)



[between you shut down the process](https://youtu.be/TIwmHGK29RY?t=00h17m12s)



[otherwise it's gonna continue to prevent](https://youtu.be/TIwmHGK29RY?t=00h17m13s)



[other things from running yes yes yes](https://youtu.be/TIwmHGK29RY?t=00h17m15s)



[yes and I actually want to check real](https://youtu.be/TIwmHGK29RY?t=00h17m18s)



[quick so because I believe the sorry for](https://youtu.be/TIwmHGK29RY?t=00h17m20s)



[everybody who was used to the dark theme](https://youtu.be/TIwmHGK29RY?t=00h17m25s)



[I am curious](https://youtu.be/TIwmHGK29RY?t=00h17m29s)



[okay so mutex derives from wait handle](https://youtu.be/TIwmHGK29RY?t=00h17m31s)



[which I assume](https://youtu.be/TIwmHGK29RY?t=00h17m34s)



[let's go core CLR implementation that](https://youtu.be/TIwmHGK29RY?t=00h17m35s)



[isn't going to help me](https://youtu.be/TIwmHGK29RY?t=00h17m40s)



[try this one I'm looking to see if this](https://youtu.be/TIwmHGK29RY?t=00h17m44s)



[guy actually has a finalizar somewhere](https://youtu.be/TIwmHGK29RY?t=00h17m47s)



[right cuz wait handle I would assume it](https://youtu.be/TIwmHGK29RY?t=00h17m51s)



[implements hi disposable right but](https://youtu.be/TIwmHGK29RY?t=00h17m55s)



[that's the co-operative finalization](https://youtu.be/TIwmHGK29RY?t=00h18m01s)



[there's nothing there's nothing directly](https://youtu.be/TIwmHGK29RY?t=00h18m06s)



[there is no finalizar directly on mutex](https://youtu.be/TIwmHGK29RY?t=00h18m10s)



[but I suppose if I had an object that](https://youtu.be/TIwmHGK29RY?t=00h18m13s)



[took out a mutex I would want to make](https://youtu.be/TIwmHGK29RY?t=00h18m15s)



[sure that it was cleaned up right](https://youtu.be/TIwmHGK29RY?t=00h18m17s)



[because this guy is disposable I want to](https://youtu.be/TIwmHGK29RY?t=00h18m19s)



[implement the I dispose pattern right](https://youtu.be/TIwmHGK29RY?t=00h18m21s)



[the I dispose pattern involves a](https://youtu.be/TIwmHGK29RY?t=00h18m24s)



[finalizar right and therefore I want to](https://youtu.be/TIwmHGK29RY?t=00h18m26s)



[make sure my finalizar actually works](https://youtu.be/TIwmHGK29RY?t=00h18m29s)



[correct](https://youtu.be/TIwmHGK29RY?t=00h18m33s)



[that seems mostly reasonable right yeah](https://youtu.be/TIwmHGK29RY?t=00h18m35s)



[again I don't think we need to specify](https://youtu.be/TIwmHGK29RY?t=00h18m40s)



[what it is that we're trying to do it's](https://youtu.be/TIwmHGK29RY?t=00h18m42s)



[just the idea that this is not right the](https://youtu.be/TIwmHGK29RY?t=00h18m43s)



[idea is know it to be the case right and](https://youtu.be/TIwmHGK29RY?t=00h18m46s)



[it's it's reasonable for us to come up](https://youtu.be/TIwmHGK29RY?t=00h18m49s)



[with even imaginary examples and you](https://youtu.be/TIwmHGK29RY?t=00h18m51s)



[know as I say it could be a file it](https://youtu.be/TIwmHGK29RY?t=00h18m54s)



[could be a distributed connection I am](https://youtu.be/TIwmHGK29RY?t=00h18m56s)



[really curious now right so now that](https://youtu.be/TIwmHGK29RY?t=00h18m59s)



[you've gotten me on this private](https://youtu.be/TIwmHGK29RY?t=00h19m02s)



[read-only and this this might end up](https://youtu.be/TIwmHGK29RY?t=00h19m04s)



[hosing my system so we're gonna have fun](https://youtu.be/TIwmHGK29RY?t=00h19m06s)



[well I wonder if you don't want to](https://youtu.be/TIwmHGK29RY?t=00h19m09s)



[consider trying to finish out the](https://youtu.be/TIwmHGK29RY?t=00h19m12s)



[example without the complexity and then](https://youtu.be/TIwmHGK29RY?t=00h19m14s)



[add in things like mutexes well well](https://youtu.be/TIwmHGK29RY?t=00h19m16s)



[sort of what I want to see though is I](https://youtu.be/TIwmHGK29RY?t=00h19m19s)



[want to see a mutex stick around outside](https://youtu.be/TIwmHGK29RY?t=00h19m21s)



[the life of my app right like I want to](https://youtu.be/TIwmHGK29RY?t=00h19m25s)



[I want to get bit like I want to show](https://youtu.be/TIwmHGK29RY?t=00h19m28s)



[the absolute worst case how why is this](https://youtu.be/TIwmHGK29RY?t=00h19m30s)



[a major major problem for me right](https://youtu.be/TIwmHGK29RY?t=00h19m33s)



[because that's that's ultimately what I](https://youtu.be/TIwmHGK29RY?t=00h19m40s)



[am looking for money we're gonna name](https://youtu.be/TIwmHGK29RY?t=00h19m43s)



[right well that's what I was looking for](https://youtu.be/TIwmHGK29RY?t=00h19m45s)



[where is the attach the name bit to it](https://youtu.be/TIwmHGK29RY?t=00h19m47s)



[is it a constructor there's something](https://youtu.be/TIwmHGK29RY?t=00h19m50s)



[that there's something about it and I](https://youtu.be/TIwmHGK29RY?t=00h19m53s)



[don't remember exactly where it is](https://youtu.be/TIwmHGK29RY?t=00h19m55s)



[you text boolean string initially own](https://youtu.be/TIwmHGK29RY?t=00h19m57s)



[string name that's what I want so true](https://youtu.be/TIwmHGK29RY?t=00h20m01s)



[yeah I suspect this contains itself up](https://youtu.be/TIwmHGK29RY?t=00h20m09s)



[but I could be wrong well but I've](https://youtu.be/TIwmHGK29RY?t=00h20m12s)



[clearly got a case where I can break](https://youtu.be/TIwmHGK29RY?t=00h20m15s)



[this right yeah yes yes I agree so I](https://youtu.be/TIwmHGK29RY?t=00h20m18s)



[want to run this not see this guy get](https://youtu.be/TIwmHGK29RY?t=00h20m20s)



[called because I'm clearly not cleaning](https://youtu.be/TIwmHGK29RY?t=00h20m24s)



[this up right and actually just just](https://youtu.be/TIwmHGK29RY?t=00h20m25s)



[proof is in the pudding so mutex](https://youtu.be/TIwmHGK29RY?t=00h20m29s)



[disposed the thing I should do right yes](https://youtu.be/TIwmHGK29RY?t=00h20m32s)



[so if I do this I expect it to not get](https://youtu.be/TIwmHGK29RY?t=00h20m38s)



[disposed let me just make sure I am](https://youtu.be/TIwmHGK29RY?t=00h20m43s)



[course still yeah great everyone's happy](https://youtu.be/TIwmHGK29RY?t=00h20m44s)



[right and I'm going to make my warning](https://youtu.be/TIwmHGK29RY?t=00h20m47s)



[go away because I don't like seeing lots](https://youtu.be/TIwmHGK29RY?t=00h20m51s)



[of yellow text okay so I don't expect it](https://youtu.be/TIwmHGK29RY?t=00h20m52s)



[to get cleaned up and then on my next](https://youtu.be/TIwmHGK29RY?t=00h20m57s)



[run I expected to blow up in my face](https://youtu.be/TIwmHGK29RY?t=00h21m00s)



[right my process is gone yes yeah and](https://youtu.be/TIwmHGK29RY?t=00h21m01s)



[now go boom let's take him up](https://youtu.be/TIwmHGK29RY?t=00h21m09s)



[[Music]](https://youtu.be/TIwmHGK29RY?t=00h21m16s)



[something's not working the way I expect](https://youtu.be/TIwmHGK29RY?t=00h21m17s)



[I why do you not think that a mutex](https://youtu.be/TIwmHGK29RY?t=00h21m20s)



[cleans up after itself well no so I](https://youtu.be/TIwmHGK29RY?t=00h21m24s)



[don't think the mutex cleans up after](https://youtu.be/TIwmHGK29RY?t=00h21m27s)



[itself I think the process whacks it](https://youtu.be/TIwmHGK29RY?t=00h21m28s)



[because the operating system when I eat](https://youtu.be/TIwmHGK29RY?t=00h21m32s)



[you that's when you put to mood Tech why](https://youtu.be/TIwmHGK29RY?t=00h21m34s)



[don't you create two mutexes with the](https://youtu.be/TIwmHGK29RY?t=00h21m36s)



[same name just to verify that we get the](https://youtu.be/TIwmHGK29RY?t=00h21m37s)



[expected behavior that seems reasonable](https://youtu.be/TIwmHGK29RY?t=00h21m39s)



[your mom would have changed the name of](https://youtu.be/TIwmHGK29RY?t=00h21m48s)



[you a variable though your field yo yeah](https://youtu.be/TIwmHGK29RY?t=00h21m49s)



[I feel right so something like that so](https://youtu.be/TIwmHGK29RY?t=00h21m52s)



[Jared the boolean is the initially owned](https://youtu.be/TIwmHGK29RY?t=00h21m56s)



[property because you can create a mutex](https://youtu.be/TIwmHGK29RY?t=00h21m58s)



[and not own it the type thing already](https://youtu.be/TIwmHGK29RY?t=00h22m00s)



[contains a definition for oh you should](https://youtu.be/TIwmHGK29RY?t=00h22m09s)



[save your file before you try to call](https://youtu.be/TIwmHGK29RY?t=00h22m11s)



[dotnet run on it so you should be able](https://youtu.be/TIwmHGK29RY?t=00h22m13s)



[to do an f5 control f5 in fact yeah but](https://youtu.be/TIwmHGK29RY?t=00h22m16s)



[it ran and this clearly didn't break so](https://youtu.be/TIwmHGK29RY?t=00h22m20s)



[that's there's the okay I I should](https://youtu.be/TIwmHGK29RY?t=00h22m22s)



[actually look at this because this is](https://youtu.be/TIwmHGK29RY?t=00h22m28s)



[clearly something that oh wait one](https://youtu.be/TIwmHGK29RY?t=00h22m29s)



[release mutex that's probably the](https://youtu.be/TIwmHGK29RY?t=00h22m33s)



[problem the managed object doesn't](https://youtu.be/TIwmHGK29RY?t=00h22m37s)



[matter got it](https://youtu.be/TIwmHGK29RY?t=00h22m39s)



[wait what's quote in release mutex so so](https://youtu.be/TIwmHGK29RY?t=00h22m44s)



[the I think I want it not initially](https://youtu.be/TIwmHGK29RY?t=00h22m48s)



[owned and I want mutex wait one right](https://youtu.be/TIwmHGK29RY?t=00h22m54s)



[yes and then I want mutex release mutex](https://youtu.be/TIwmHGK29RY?t=00h23m01s)



[let my mutex go okay assume that dispose](https://youtu.be/TIwmHGK29RY?t=00h23m10s)



[calls release mutex but yes so that](https://youtu.be/TIwmHGK29RY?t=00h23m14s)



[should work](https://youtu.be/TIwmHGK29RY?t=00h23m19s)



[and this should hang](https://youtu.be/TIwmHGK29RY?t=00h23m24s)



[I am not surprised that it's not hanging](https://youtu.be/TIwmHGK29RY?t=00h23m36s)



[and I can't imagine a circumstances](https://youtu.be/TIwmHGK29RY?t=00h23m39s)



[where you'd want it to agree it still](https://youtu.be/TIwmHGK29RY?t=00h23m40s)



[bothers me on the way that mutex is](https://youtu.be/TIwmHGK29RY?t=00h23m44s)



[working I feel like I should be because](https://youtu.be/TIwmHGK29RY?t=00h23m45s)



[you're supposed to be able to check and](https://youtu.be/TIwmHGK29RY?t=00h23m47s)



[see it well while you see it works put](https://youtu.be/TIwmHGK29RY?t=00h23m50s)



[into process communication that's](https://youtu.be/TIwmHGK29RY?t=00h23m52s)



[exactly what it's designed yeah and the](https://youtu.be/TIwmHGK29RY?t=00h23m53s)



[process is dead but you want it allowed](https://youtu.be/TIwmHGK29RY?t=00h23m55s)



[to keep it alive so well the fact that](https://youtu.be/TIwmHGK29RY?t=00h23m57s)



[the process handles this is not](https://youtu.be/TIwmHGK29RY?t=00h23m59s)



[surprising to me that is fair that is](https://youtu.be/TIwmHGK29RY?t=00h24m00s)



[also disappointing okay](https://youtu.be/TIwmHGK29RY?t=00h24m03s)



[wait you're disappointed that it behaves](https://youtu.be/TIwmHGK29RY?t=00h24m05s)



[the way you want it to well I'm](https://youtu.be/TIwmHGK29RY?t=00h24m07s)



[disappointed that it protects me from](https://youtu.be/TIwmHGK29RY?t=00h24m09s)



[shooting myself in the foot](https://youtu.be/TIwmHGK29RY?t=00h24m11s)



[sometimes I want to be able to shoot](https://youtu.be/TIwmHGK29RY?t=00h24m12s)



[myself in the foot that's exactly what](https://youtu.be/TIwmHGK29RY?t=00h24m13s)



[I'm hearing you said just want to make](https://youtu.be/TIwmHGK29RY?t=00h24m16s)



[sure we can kill it yes okay so okay](https://youtu.be/TIwmHGK29RY?t=00h24m17s)



[carry on](https://youtu.be/TIwmHGK29RY?t=00h24m23s)



[so now the question that we want to ask](https://youtu.be/TIwmHGK29RY?t=00h24m25s)



[ourselves is well what way do we make](https://youtu.be/TIwmHGK29RY?t=00h24m27s)



[sure this this muteness finalized it](https://youtu.be/TIwmHGK29RY?t=00h24m30s)



[will get cold and and we've already got](https://youtu.be/TIwmHGK29RY?t=00h24m33s)



[one obvious we can call system dot GC](https://youtu.be/TIwmHGK29RY?t=00h24m35s)



[collect but if the object is referenced](https://youtu.be/TIwmHGK29RY?t=00h24m37s)



[then GC collect will not succeed and we](https://youtu.be/TIwmHGK29RY?t=00h24m39s)



[can go ahead and prove that so let's](https://youtu.be/TIwmHGK29RY?t=00h24m41s)



[grab a static variable go ahead and](https://youtu.be/TIwmHGK29RY?t=00h24m42s)



[assign thing to that static variable and](https://youtu.be/TIwmHGK29RY?t=00h24m44s)



[I would just move your declaration or](https://youtu.be/TIwmHGK29RY?t=00h24m46s)



[however you want to do it you gonna do](https://youtu.be/TIwmHGK29RY?t=00h24m50s)



[another one what do you how you're gonna](https://youtu.be/TIwmHGK29RY?t=00h24m56s)



[do it okay that's fine](https://youtu.be/TIwmHGK29RY?t=00h24m57s)



[right yep okay so now at this point you](https://youtu.be/TIwmHGK29RY?t=00h25m02s)



[call to DC collect there's still a](https://youtu.be/TIwmHGK29RY?t=00h25m07s)



[reference to the thing](https://youtu.be/TIwmHGK29RY?t=00h25m08s)



[so GC cluck doesn't succeed in shutting](https://youtu.be/TIwmHGK29RY?t=00h25m09s)



[down my okay calling my finalize it try](https://youtu.be/TIwmHGK29RY?t=00h25m12s)



[again](https://youtu.be/TIwmHGK29RY?t=00h25m17s)



[and then proof being in the pudding if I](https://youtu.be/TIwmHGK29RY?t=00h25m21s)



[take this out I should see you get](https://youtu.be/TIwmHGK29RY?t=00h25m25s)



[cleaned up](https://youtu.be/TIwmHGK29RY?t=00h25m28s)



[okay so it works as expected](https://youtu.be/TIwmHGK29RY?t=00h25m37s)



[yes but not as wanted well I don't think](https://youtu.be/TIwmHGK29RY?t=00h25m42s)



[we want to take one really measure the](https://youtu.be/TIwmHGK29RY?t=00h25m50s)



[size of your program we don't want to](https://youtu.be/TIwmHGK29RY?t=00h25m52s)



[take on the pretty the idea that OGC](https://youtu.be/TIwmHGK29RY?t=00h25m53s)



[cluck is a viable way to solve this](https://youtu.be/TIwmHGK29RY?t=00h25m56s)



[problem I I don't disagree GC collect is](https://youtu.be/TIwmHGK29RY?t=00h25m57s)



[a stop-gap problem it is a very easy way](https://youtu.be/TIwmHGK29RY?t=00h26m01s)



[to do it but it's not going to be](https://youtu.be/TIwmHGK29RY?t=00h26m06s)



[reliably cleaning up so the proposed](https://youtu.be/TIwmHGK29RY?t=00h26m08s)



[solution for this is actually to call](https://youtu.be/TIwmHGK29RY?t=00h26m12s)



[process it's to register for the process](https://youtu.be/TIwmHGK29RY?t=00h26m14s)



[exit event okay so zoom when you do that](https://youtu.be/TIwmHGK29RY?t=00h26m17s)



[inside your constructor well I would](https://youtu.be/TIwmHGK29RY?t=00h26m20s)



[assume that I do it inside of main right](https://youtu.be/TIwmHGK29RY?t=00h26m23s)



[no I would do it inside the constructor](https://youtu.be/TIwmHGK29RY?t=00h26m25s)



[per thing because you may write this](https://youtu.be/TIwmHGK29RY?t=00h26m27s)



[object in a different library you may](https://youtu.be/TIwmHGK29RY?t=00h26m32s)



[not even have a main okay is this on the](https://youtu.be/TIwmHGK29RY?t=00h26m33s)



[process object it's on app domain I](https://youtu.be/TIwmHGK29RY?t=00h26m38s)



[think we have a problem then don't we I](https://youtu.be/TIwmHGK29RY?t=00h26m42s)



[think F domain does have a process exit](https://youtu.be/TIwmHGK29RY?t=00h26m46s)



[on it I don't know but not net core](https://youtu.be/TIwmHGK29RY?t=00h26m49s)



[three okay maybe it's some process exit](https://youtu.be/TIwmHGK29RY?t=00h26m53s)



[one signature I was gonna say the app](https://youtu.be/TIwmHGK29RY?t=00h27m00s)



[domain class got highly limited yes so](https://youtu.be/TIwmHGK29RY?t=00h27m04s)



[there is a process exit right that's all](https://youtu.be/TIwmHGK29RY?t=00h27m09s)



[neon process okay that's fine yeah well](https://youtu.be/TIwmHGK29RY?t=00h27m12s)



[no it lives on the app domain thingy a](https://youtu.be/TIwmHGK29RY?t=00h27m15s)



[big scary warning yada yada yada yeah](https://youtu.be/TIwmHGK29RY?t=00h27m20s)



[you got a big scary warning so AB domain](https://youtu.be/TIwmHGK29RY?t=00h27m25s)



[current domain](https://youtu.be/TIwmHGK29RY?t=00h27m29s)



[I mean unloaded yeah okay-y process exit](https://youtu.be/TIwmHGK29RY?t=00h27m33s)



[okay and so now you're gonna have to set](https://youtu.be/TIwmHGK29RY?t=00h27m40s)



[up a close method cuz you can't call](https://youtu.be/TIwmHGK29RY?t=00h27m46s)



[your finalizar so you're gonna have to](https://youtu.be/TIwmHGK29RY?t=00h27m48s)



[go separate out your dispose pattern and](https://youtu.be/TIwmHGK29RY?t=00h27m50s)



[you know alright so yeah](https://youtu.be/TIwmHGK29RY?t=00h27m52s)



[so I'll turn the kin to that](https://youtu.be/TIwmHGK29RY?t=00h28m03s)



[console.writeline](https://youtu.be/TIwmHGK29RY?t=00h28m09s)



[and we think that works so if works](https://youtu.be/TIwmHGK29RY?t=00h28m23s)



[means we expect that sweep it under the](https://youtu.be/TIwmHGK29RY?t=00h28m27s)



[rug is drug is gonna get cold the answer](https://youtu.be/TIwmHGK29RY?t=00h28m29s)



[is yes but we still don't expect that](https://youtu.be/TIwmHGK29RY?t=00h28m31s)



[finalizer to get cold because of this](https://youtu.be/TIwmHGK29RY?t=00h28m32s)



[right oh because we don't have GC](https://youtu.be/TIwmHGK29RY?t=00h28m37s)



[collect we're not calling GC collect](https://youtu.be/TIwmHGK29RY?t=00h28m39s)



[anyway so it shouldn't shouldn't matter](https://youtu.be/TIwmHGK29RY?t=00h28m40s)



[whether you have that or not okay well](https://youtu.be/TIwmHGK29RY?t=00h28m42s)



[let's just eliminate and have as few](https://youtu.be/TIwmHGK29RY?t=00h28m43s)



[variables flying at the same time as](https://youtu.be/TIwmHGK29RY?t=00h28m47s)



[possible by the way as we do this one of](https://youtu.be/TIwmHGK29RY?t=00h28m49s)



[the things that's really interesting](https://youtu.be/TIwmHGK29RY?t=00h28m56s)



[about it is testing is really hard you](https://youtu.be/TIwmHGK29RY?t=00h28m57s)



[know there's no way to test besides](https://youtu.be/TIwmHGK29RY?t=00h29m00s)



[running a process and going through the](https://youtu.be/TIwmHGK29RY?t=00h29m01s)



[exit so if you're gonna write a unit](https://youtu.be/TIwmHGK29RY?t=00h29m03s)



[test for this you have to have a unit](https://youtu.be/TIwmHGK29RY?t=00h29m05s)



[test that goes and runs a process yeah](https://youtu.be/TIwmHGK29RY?t=00h29m06s)



[so it's a there were there were some](https://youtu.be/TIwmHGK29RY?t=00h29m11s)



[there would be some people who would](https://youtu.be/TIwmHGK29RY?t=00h29m13s)



[dispute the the the unit portion of that](https://youtu.be/TIwmHGK29RY?t=00h29m14s)



[test I don't think you have a choice in](https://youtu.be/TIwmHGK29RY?t=00h29m17s)



[fact I think that is the only way to do](https://youtu.be/TIwmHGK29RY?t=00h29m20s)



[this because you're actually trying to](https://youtu.be/TIwmHGK29RY?t=00h29m22s)



[verify the runs before exit and and the](https://youtu.be/TIwmHGK29RY?t=00h29m23s)



[other thing that this raises is the](https://youtu.be/TIwmHGK29RY?t=00h29m26s)



[point the fact that after mains are not](https://youtu.be/TIwmHGK29RY?t=00h29m27s)



[sort of first passed citizens in.net](https://youtu.be/TIwmHGK29RY?t=00h29m29s)



[core so you can't run this an app to me](https://youtu.be/TIwmHGK29RY?t=00h29m31s)



[the only app domain you have is your](https://youtu.be/TIwmHGK29RY?t=00h29m33s)



[current one you can't instantiate a new](https://youtu.be/TIwmHGK29RY?t=00h29m36s)



[afternoon](https://youtu.be/TIwmHGK29RY?t=00h29m37s)



[really then what's the create domain](https://youtu.be/TIwmHGK29RY?t=00h29m38s)



[button do I don't think that works I](https://youtu.be/TIwmHGK29RY?t=00h29m42s)



[think it gives you an error and tells it](https://youtu.be/TIwmHGK29RY?t=00h29m46s)



[does not working down in court give it a](https://youtu.be/TIwmHGK29RY?t=00h29m47s)



[try](https://youtu.be/TIwmHGK29RY?t=00h29m49s)



[this is a great example I think this is](https://youtu.be/TIwmHGK29RY?t=00h29m49s)



[a great example of a an API that shows](https://youtu.be/TIwmHGK29RY?t=00h29m52s)



[up in order to be dotnet standard](https://youtu.be/TIwmHGK29RY?t=00h29m56s)



[compatible but an actual fact doesn't](https://youtu.be/TIwmHGK29RY?t=00h29m58s)



[exist I'm going my recollection my](https://youtu.be/TIwmHGK29RY?t=00h30m00s)



[memory here so I could be wrong but I](https://youtu.be/TIwmHGK29RY?t=00h30m04s)



[believe that that's what happens so you](https://youtu.be/TIwmHGK29RY?t=00h30m05s)



[don't think I can even get a new one I](https://youtu.be/TIwmHGK29RY?t=00h30m07s)



[don't think so try it](https://youtu.be/TIwmHGK29RY?t=00h30m09s)



[Oh platform not supported exception](https://youtu.be/TIwmHGK29RY?t=00h30m11s)



[which which by the way I mean this is a](https://youtu.be/TIwmHGK29RY?t=00h30m16s)



[whole nother issue in itself like the](https://youtu.be/TIwmHGK29RY?t=00h30m18s)



[fact that you would only know this you](https://youtu.be/TIwmHGK29RY?t=00h30m20s)



[basically lose the ability to program](https://youtu.be/TIwmHGK29RY?t=00h30m22s)



[with intellisense I mean intellisense is](https://youtu.be/TIwmHGK29RY?t=00h30m24s)



[gonna need you the wrong way in this](https://youtu.be/TIwmHGK29RY?t=00h30m28s)



[particular scenario because I buy the](https://youtu.be/TIwmHGK29RY?t=00h30m29s)



[app domain dot like that I didn't and we](https://youtu.be/TIwmHGK29RY?t=00h30m32s)



[might look](https://youtu.be/TIwmHGK29RY?t=00h30m36s)



[I hadn't converted an existing project](https://youtu.be/TIwmHGK29RY?t=00h30m37s)



[but they won't know this parlament ill](https://youtu.be/TIwmHGK29RY?t=00h30m39s)



[they actually go ahead and and run it](https://youtu.be/TIwmHGK29RY?t=00h30m40s)



[and you know it's a bit disconcerting to](https://youtu.be/TIwmHGK29RY?t=00h30m43s)



[me that that you have this create method](https://youtu.be/TIwmHGK29RY?t=00h30m45s)



[and obviously there's a tension between](https://youtu.be/TIwmHGK29RY?t=00h30m47s)



[being you know compiled compatible but](https://youtu.be/TIwmHGK29RY?t=00h30m49s)



[not runtime compatible though right I](https://youtu.be/TIwmHGK29RY?t=00h30m52s)



[will say most of the time when people](https://youtu.be/TIwmHGK29RY?t=00h30m56s)



[are using app domains it's because](https://youtu.be/TIwmHGK29RY?t=00h30m58s)



[they're doing some sort of like plug-in](https://youtu.be/TIwmHGK29RY?t=00h30m59s)



[dynamic assembly loading bit and dotnet](https://youtu.be/TIwmHGK29RY?t=00h31m01s)



[core has an alternate API for that with](https://youtu.be/TIwmHGK29RY?t=00h31m04s)



[which i think is called assembly load](https://youtu.be/TIwmHGK29RY?t=00h31m08s)



[context yes yes and but i don't think](https://youtu.be/TIwmHGK29RY?t=00h31m11s)



[that's the that's the point that i'm](https://youtu.be/TIwmHGK29RY?t=00h31m15s)



[trying to make here is intellisense will](https://youtu.be/TIwmHGK29RY?t=00h31m16s)



[lead you down the wrong way and you will](https://youtu.be/TIwmHGK29RY?t=00h31m18s)



[not know this an issue of a unit test](https://youtu.be/TIwmHGK29RY?t=00h31m19s)



[you run all your code run all my code](https://youtu.be/TIwmHGK29RY?t=00h31m21s)



[that sounds simple enough](https://youtu.be/TIwmHGK29RY?t=00h31m25s)



[and that's and i feel like yeah it's a](https://youtu.be/TIwmHGK29RY?t=00h31m27s)



[little bit scary disconcerting i think](https://youtu.be/TIwmHGK29RY?t=00h31m32s)



[it's a better word it's fair](https://youtu.be/TIwmHGK29RY?t=00h31m34s)



[anyway that's this we don't need focus](https://youtu.be/TIwmHGK29RY?t=00h31m37s)



[on that part so what we have now is the](https://youtu.be/TIwmHGK29RY?t=00h31m39s)



[example we actually called exit we've](https://youtu.be/TIwmHGK29RY?t=00h31m42s)



[not gone ahead and got nap domain but](https://youtu.be/TIwmHGK29RY?t=00h31m44s)



[we've registered for the event and did](https://youtu.be/TIwmHGK29RY?t=00h31m46s)



[we run this yet yeah so this one here](https://youtu.be/TIwmHGK29RY?t=00h31m47s)



[this guy here actually it worked it](https://youtu.be/TIwmHGK29RY?t=00h31m50s)



[worked yes okay yeah so so we swept it](https://youtu.be/TIwmHGK29RY?t=00h31m52s)



[under the rug problems gone so that's](https://youtu.be/TIwmHGK29RY?t=00h31m55s)



[interesting now we were at we're now](https://youtu.be/TIwmHGK29RY?t=00h32m00s)



[gonna go across this exit but if we go](https://youtu.be/TIwmHGK29RY?t=00h32m02s)



[ahead and call GC collect and we don't](https://youtu.be/TIwmHGK29RY?t=00h32m04s)



[have a reference to it ideally that](https://youtu.be/TIwmHGK29RY?t=00h32m06s)



[would mean that this object would](https://youtu.be/TIwmHGK29RY?t=00h32m09s)



[disappear by the finalizer correct if we](https://youtu.be/TIwmHGK29RY?t=00h32m10s)



[call GC collect and we don't so correct](https://youtu.be/TIwmHGK29RY?t=00h32m13s)



[GC collect in there now we would we'd be](https://youtu.be/TIwmHGK29RY?t=00h32m18s)



[lying in the finalizer to get invoked](https://youtu.be/TIwmHGK29RY?t=00h32m21s)



[correct so for those people unfamiliar](https://youtu.be/TIwmHGK29RY?t=00h32m23s)



[with the GC when when the thing falls](https://youtu.be/TIwmHGK29RY?t=00h32m26s)



[out of scope ultimately when the garbage](https://youtu.be/TIwmHGK29RY?t=00h32m28s)



[collector runs it follows the route](https://youtu.be/TIwmHGK29RY?t=00h32m31s)



[references and looks for things that are](https://youtu.be/TIwmHGK29RY?t=00h32m33s)



[still referenced and anything that's not](https://youtu.be/TIwmHGK29RY?t=00h32m36s)



[reference gets marked and put in a queue](https://youtu.be/TIwmHGK29RY?t=00h32m37s)



[then it gets cleaned up alright and that](https://youtu.be/TIwmHGK29RY?t=00h32m39s)



[second step of then it gets cleaned up](https://youtu.be/TIwmHGK29RY?t=00h32m43s)



[is when this guy gets invoked](https://youtu.be/TIwmHGK29RY?t=00h32m44s)



[exactly and there's a separate thread](https://youtu.be/TIwmHGK29RY?t=00h32m48s)



[running and when it runs it actually](https://youtu.be/TIwmHGK29RY?t=00h32m50s)



[stops all threads in the process to go](https://youtu.be/TIwmHGK29RY?t=00h32m52s)



[ahead and do the GC cleanup but when you](https://youtu.be/TIwmHGK29RY?t=00h32m53s)



[call system that GC to deflect you're](https://youtu.be/TIwmHGK29RY?t=00h32m55s)



[actually given the ability to direct the](https://youtu.be/TIwmHGK29RY?t=00h32m57s)



[runtime about when you think it should](https://youtu.be/TIwmHGK29RY?t=00h33m01s)



[run right this hasn't always been](https://youtu.be/TIwmHGK29RY?t=00h33m02s)



[available as deterministic but now I](https://youtu.be/TIwmHGK29RY?t=00h33m05s)



[think in dynacord Saturn Minister really](https://youtu.be/TIwmHGK29RY?t=00h33m07s)



[that's my experience and I think that's](https://youtu.be/TIwmHGK29RY?t=00h33m10s)



[what the documentation for collects is](https://youtu.be/TIwmHGK29RY?t=00h33m12s)



[if you know I say I thought it was](https://youtu.be/TIwmHGK29RY?t=00h33m14s)



[because collect as I've always](https://youtu.be/TIwmHGK29RY?t=00h33m16s)



[understood it is a request to the GC to](https://youtu.be/TIwmHGK29RY?t=00h33m18s)



[say yeah pretty please or the the](https://youtu.be/TIwmHGK29RY?t=00h33m21s)



[documentation says differently but let's](https://youtu.be/TIwmHGK29RY?t=00h33m25s)



[check it yeah forces immediate garbage](https://youtu.be/TIwmHGK29RY?t=00h33m26s)



[types from all generations](https://youtu.be/TIwmHGK29RY?t=00h33m31s)



[where are you seen that right at the](https://youtu.be/TIwmHGK29RY?t=00h33m34s)



[description of the method the very](https://youtu.be/TIwmHGK29RY?t=00h33m36s)



[beginning at the top at the top Oh](https://youtu.be/TIwmHGK29RY?t=00h33m40s)



[perform a collection forces an immediate](https://youtu.be/TIwmHGK29RY?t=00h33m47s)



[garbage collection of all generations](https://youtu.be/TIwmHGK29RY?t=00h33m50s)



[right below where it says collect yeah](https://youtu.be/TIwmHGK29RY?t=00h33m51s)



[okay](https://youtu.be/TIwmHGK29RY?t=00h33m53s)



[it seems pretty dogmatic I guess so](https://youtu.be/TIwmHGK29RY?t=00h33m54s)



[this is sorry this is bothering me that](https://youtu.be/TIwmHGK29RY?t=00h33m59s)



[mmm](https://youtu.be/TIwmHGK29RY?t=00h34m02s)



[this also bothers me sometimes I feel](https://youtu.be/TIwmHGK29RY?t=00h34m03s)



[like the documentation has been changed](https://youtu.be/TIwmHGK29RY?t=00h34m05s)



[and this doesn't reflect the version](https://youtu.be/TIwmHGK29RY?t=00h34m07s)



[changes yeah why don't you change the](https://youtu.be/TIwmHGK29RY?t=00h34m11s)



[design their crema cuando how about](https://youtu.be/TIwmHGK29RY?t=00h34m13s)



[white one it would be scary because this](https://youtu.be/TIwmHGK29RY?t=00h34m16s)



[was not true in Wyandotte oh I'm pretty](https://youtu.be/TIwmHGK29RY?t=00h34m22s)



[sure so what one still has the same](https://youtu.be/TIwmHGK29RY?t=00h34m24s)



[verbage here yeah and what I don't know](https://youtu.be/TIwmHGK29RY?t=00h34m26s)



[is which one change right it's always](https://youtu.be/TIwmHGK29RY?t=00h34m29s)



[been their way you know I don't know](https://youtu.be/TIwmHGK29RY?t=00h34m30s)



[yeah something in the back of my mind is](https://youtu.be/TIwmHGK29RY?t=00h34m32s)



[telling me that this hasn't always been](https://youtu.be/TIwmHGK29RY?t=00h34m34s)



[a guarantee and that it's right I'm](https://youtu.be/TIwmHGK29RY?t=00h34m36s)



[agreeing with you a hundred percent](https://youtu.be/TIwmHGK29RY?t=00h34m38s)



[I completely that's my assertion is was](https://youtu.be/TIwmHGK29RY?t=00h34m40s)



[not it was a request](https://youtu.be/TIwmHGK29RY?t=00h34m42s)



[I might go poking through the docs repo](https://youtu.be/TIwmHGK29RY?t=00h34m43s)



[and see because this stuff is open](https://youtu.be/TIwmHGK29RY?t=00h34m45s)



[source and you can hunt the history I](https://youtu.be/TIwmHGK29RY?t=00h34m47s)



[have a feeling that there's one source](https://youtu.be/TIwmHGK29RY?t=00h34m49s)



[and they don't keep different versions](https://youtu.be/TIwmHGK29RY?t=00h34m52s)



[for different bits here right yeah](https://youtu.be/TIwmHGK29RY?t=00h34m53s)



[that's my hunch yeah again I am agreeing](https://youtu.be/TIwmHGK29RY?t=00h34m56s)



[with you on this one](https://youtu.be/TIwmHGK29RY?t=00h35m00s)



[my recollection is that it's not it has](https://youtu.be/TIwmHGK29RY?t=00h35m01s)



[not always been deterministic well so](https://youtu.be/TIwmHGK29RY?t=00h35m04s)



[that seems very obvious in that it would](https://youtu.be/TIwmHGK29RY?t=00h35m07s)



[say GC go now clean up all the stuff do](https://youtu.be/TIwmHGK29RY?t=00h35m09s)



[the thing so anyway so the point being](https://youtu.be/TIwmHGK29RY?t=00h35m12s)



[here so let's go run a GC collect now](https://youtu.be/TIwmHGK29RY?t=00h35m17s)



[you'd expect the finalized to be called](https://youtu.be/TIwmHGK29RY?t=00h35m19s)



[let's see if it actually is nope so oh](https://youtu.be/TIwmHGK29RY?t=00h35m20s)



[hold on oh yeah yes exactly I was gonna](https://youtu.be/TIwmHGK29RY?t=00h35m29s)



[say there's an implicit this cap yeah](https://youtu.be/TIwmHGK29RY?t=00h35m32s)



[exactly so the the recommended way to do](https://youtu.be/TIwmHGK29RY?t=00h35m35s)



[this is to go ahead and set up an event](https://youtu.be/TIwmHGK29RY?t=00h35m40s)



[that calls process exit that will now](https://youtu.be/TIwmHGK29RY?t=00h35m42s)



[make sure your object gets called but](https://youtu.be/TIwmHGK29RY?t=00h35m44s)



[the very fact that you go ahead and](https://youtu.be/TIwmHGK29RY?t=00h35m47s)



[create that reference to process exit is](https://youtu.be/TIwmHGK29RY?t=00h35m48s)



[now meaning it never ends up in the](https://youtu.be/TIwmHGK29RY?t=00h35m50s)



[finalization queue because something's](https://youtu.be/TIwmHGK29RY?t=00h35m52s)



[pointing to it so it can't get up so for](https://youtu.be/TIwmHGK29RY?t=00h35m54s)



[those people who are missing it there's](https://youtu.be/TIwmHGK29RY?t=00h35m57s)



[an implicit this dot right here which](https://youtu.be/TIwmHGK29RY?t=00h35m59s)



[means this delegate that's being created](https://youtu.be/TIwmHGK29RY?t=00h36m02s)



[holds on to a reference of this thing](https://youtu.be/TIwmHGK29RY?t=00h36m04s)



[instance and that delegate gets put on](https://youtu.be/TIwmHGK29RY?t=00h36m07s)



[the list of delegates to get invoked for](https://youtu.be/TIwmHGK29RY?t=00h36m10s)



[this event which is a static event so](https://youtu.be/TIwmHGK29RY?t=00h36m13s)



[effectively we have a static referencing](https://youtu.be/TIwmHGK29RY?t=00h36m15s)



[our instance which would be why this guy](https://youtu.be/TIwmHGK29RY?t=00h36m18s)



[never gets called that's exactly right](https://youtu.be/TIwmHGK29RY?t=00h36m22s)



[so hold on I want to try something else](https://youtu.be/TIwmHGK29RY?t=00h36m24s)



[right break the implicit capture fair](https://youtu.be/TIwmHGK29RY?t=00h36m28s)



[enough but now you're not doing it](https://youtu.be/TIwmHGK29RY?t=00h36m34s)



[inside the object minor details my point](https://youtu.be/TIwmHGK29RY?t=00h36m36s)



[is you would not be executive yeah there](https://youtu.be/TIwmHGK29RY?t=00h36m42s)



[it goes capture yeah of the instance and](https://youtu.be/TIwmHGK29RY?t=00h36m44s)



[now it works I just done have lost my](https://youtu.be/TIwmHGK29RY?t=00h36m49s)



[reference to the instance yes exactly](https://youtu.be/TIwmHGK29RY?t=00h36m52s)



[exactly which is sort of the thing that](https://youtu.be/TIwmHGK29RY?t=00h36m54s)



[I needed to clean up in the first place](https://youtu.be/TIwmHGK29RY?t=00h36m57s)



[yeah so so what now is interesting is](https://youtu.be/TIwmHGK29RY?t=00h36m58s)



[what happened if we used a weak](https://youtu.be/TIwmHGK29RY?t=00h37m01s)



[reference and is it possible to use a](https://youtu.be/TIwmHGK29RY?t=00h37m03s)



[reef weak reference to a delegate that's](https://youtu.be/TIwmHGK29RY?t=00h37m05s)



[an interesting idea so let's do this](https://youtu.be/TIwmHGK29RY?t=00h37m10s)



[so I think what you can get away with](https://youtu.be/TIwmHGK29RY?t=00h37m14s)



[right is this so thing ref right and I](https://youtu.be/TIwmHGK29RY?t=00h37m16s)



[do var myself gets new week reference of](https://youtu.be/TIwmHGK29RY?t=00h37m22s)



[thing](https://youtu.be/TIwmHGK29RY?t=00h37m29s)



[I'll give it myself right and then I](https://youtu.be/TIwmHGK29RY?t=00h37m31s)



[will let my delegate capture the week](https://youtu.be/TIwmHGK29RY?t=00h37m34s)



[reference yes and I'll pass it this is](https://youtu.be/TIwmHGK29RY?t=00h37m37s)



[exactly run to the rug and oh I learned](https://youtu.be/TIwmHGK29RY?t=00h37m41s)



[something yesterday or today all my days](https://youtu.be/TIwmHGK29RY?t=00h37m46s)



[this is valid yeah I would have](https://youtu.be/TIwmHGK29RY?t=00h37m49s)



[mentioned that to you I had this as](https://youtu.be/TIwmHGK29RY?t=00h37m53s)



[Mallett I won't mention any names but I](https://youtu.be/TIwmHGK29RY?t=00h37m55s)



[had an editor for my book and his](https://youtu.be/TIwmHGK29RY?t=00h37m58s)



[initials](https://youtu.be/TIwmHGK29RY?t=00h38m00s)



[I mean his initials are the first letter](https://youtu.be/TIwmHGK29RY?t=00h38m01s)



[of Kevin and the first letter of boss](https://youtu.be/TIwmHGK29RY?t=00h38m04s)



[that's what his initials are and he](https://youtu.be/TIwmHGK29RY?t=00h38m07s)



[mentioned this in Christ me to correct](https://youtu.be/TIwmHGK29RY?t=00h38m09s)



[the code and wonder why I was doing this](https://youtu.be/TIwmHGK29RY?t=00h38m11s)



[and there is a reason that you want to](https://youtu.be/TIwmHGK29RY?t=00h38m12s)



[go do this](https://youtu.be/TIwmHGK29RY?t=00h38m14s)



[sigh but I won't mention any names](https://youtu.be/TIwmHGK29RY?t=00h38m17s)



[okay so out thing food right so you got](https://youtu.be/TIwmHGK29RY?t=00h38m23s)



[to call the method you got to call it](https://youtu.be/TIwmHGK29RY?t=00h38m33s)



[you want to you want to call I guess you](https://youtu.be/TIwmHGK29RY?t=00h38m35s)



[don't have clean up anymore is that were](https://youtu.be/TIwmHGK29RY?t=00h38m38s)



[you saying so I'm leaving clean up as](https://youtu.be/TIwmHGK29RY?t=00h38m39s)



[static and passing this through right as](https://youtu.be/TIwmHGK29RY?t=00h38m41s)



[a weak ref I mean I could I could do it](https://youtu.be/TIwmHGK29RY?t=00h38m45s)



[I can do a private void instance clean](https://youtu.be/TIwmHGK29RY?t=00h38m47s)



[up right if we want to prove that we can](https://youtu.be/TIwmHGK29RY?t=00h38m53s)



[act on the instance right](https://youtu.be/TIwmHGK29RY?t=00h38m55s)



[let's get it working and then I'll talk](https://youtu.be/TIwmHGK29RY?t=00h39m03s)



[about some ideas for refactoring it](https://youtu.be/TIwmHGK29RY?t=00h39m05s)



[because I I don't like the idea of us](https://youtu.be/TIwmHGK29RY?t=00h39m07s)



[having out the static method but it may](https://youtu.be/TIwmHGK29RY?t=00h39m09s)



[not be possible to avoid yeah so yeah](https://youtu.be/TIwmHGK29RY?t=00h39m12s)



[that's that's that's great and I've been](https://youtu.be/TIwmHGK29RY?t=00h39m24s)



[I think if we went and declared the](https://youtu.be/TIwmHGK29RY?t=00h39m27s)



[static method inside the well anyway](https://youtu.be/TIwmHGK29RY?t=00h39m29s)



[let's try it it's good yeah so it is it](https://youtu.be/TIwmHGK29RY?t=00h39m32s)



[is very interesting so one thing is](https://youtu.be/TIwmHGK29RY?t=00h39m38s)



[falling out of scope oh we've got a GC](https://youtu.be/TIwmHGK29RY?t=00h39m41s)



[clean R or GC collect let's get rid of](https://youtu.be/TIwmHGK29RY?t=00h39m43s)



[that](https://youtu.be/TIwmHGK29RY?t=00h39m47s)



[okay so now the things alive we can get](https://youtu.be/TIwmHGK29RY?t=00h39m54s)



[into here right because the only reason](https://youtu.be/TIwmHGK29RY?t=00h39m58s)



[we put the GC collect on here is to make](https://youtu.be/TIwmHGK29RY?t=00h40m01s)



[sure that is to prove out the the](https://youtu.be/TIwmHGK29RY?t=00h40m03s)



[capturing the thing being gone I think](https://youtu.be/TIwmHGK29RY?t=00h40m05s)



[isn't given being called what well right](https://youtu.be/TIwmHGK29RY?t=00h40m07s)



[god](https://youtu.be/TIwmHGK29RY?t=00h40m11s)



[what would call this finalizar nothing's](https://youtu.be/TIwmHGK29RY?t=00h40m12s)



[going to call it right I think the I so](https://youtu.be/TIwmHGK29RY?t=00h40m17s)



[I think the idea of what we're talking](https://youtu.be/TIwmHGK29RY?t=00h40m19s)



[about](https://youtu.be/TIwmHGK29RY?t=00h40m22s)



[I guess I guess that's fine because I](https://youtu.be/TIwmHGK29RY?t=00h40m22s)



[think we'd have to get things exactly](https://youtu.be/TIwmHGK29RY?t=00h40m24s)



[what we expect you're right we're](https://youtu.be/TIwmHGK29RY?t=00h40m26s)



[expecting that ultimately what ends up](https://youtu.be/TIwmHGK29RY?t=00h40m28s)



[happening is it's something like here](https://youtu.be/TIwmHGK29RY?t=00h40m30s)



[that's where you should call instance](https://youtu.be/TIwmHGK29RY?t=00h40m33s)



[clean up yes exactly](https://youtu.be/TIwmHGK29RY?t=00h40m35s)



[now that yes though thing right but it's](https://youtu.be/TIwmHGK29RY?t=00h40m36s)



[important to note that if you call an](https://youtu.be/TIwmHGK29RY?t=00h40m42s)



[instance method in here you can](https://youtu.be/TIwmHGK29RY?t=00h40m43s)



[guarantee nothing about your managed](https://youtu.be/TIwmHGK29RY?t=00h40m45s)



[references anymore so explain what you](https://youtu.be/TIwmHGK29RY?t=00h40m47s)



[mean by that the the order of cleanup](https://youtu.be/TIwmHGK29RY?t=00h40m50s)



[isn't deterministic right you know but](https://youtu.be/TIwmHGK29RY?t=00h40m53s)



[you don't care about that well so but](https://youtu.be/TIwmHGK29RY?t=00h40m56s)



[right but say I wanted to do say](https://youtu.be/TIwmHGK29RY?t=00h40m59s)



[hypothetically I had a a mutex field](https://youtu.be/TIwmHGK29RY?t=00h41m01s)



[here right if I tried to do something](https://youtu.be/TIwmHGK29RY?t=00h41m04s)



[like mutex dispose this would be bad](https://youtu.be/TIwmHGK29RY?t=00h41m06s)



[well it is it is it is so you text](https://youtu.be/TIwmHGK29RY?t=00h41m10s)



[question dispose and you should be doing](https://youtu.be/TIwmHGK29RY?t=00h41m14s)



[that anyway so but so remember though](https://youtu.be/TIwmHGK29RY?t=00h41m16s)



[this this falls into the the I](https://youtu.be/TIwmHGK29RY?t=00h41m20s)



[disposable pattern right how you get](https://youtu.be/TIwmHGK29RY?t=00h41m23s)



[your they should be reentrant all](https://youtu.be/TIwmHGK29RY?t=00h41m25s)



[disposed methods to be reentrant agreed](https://youtu.be/TIwmHGK29RY?t=00h41m27s)



[but in general when you do your dispose](https://youtu.be/TIwmHGK29RY?t=00h41m30s)



[method you have a dispose it takes in a](https://youtu.be/TIwmHGK29RY?t=00h41m32s)



[bool and you only get rid of your you](https://youtu.be/TIwmHGK29RY?t=00h41m35s)



[only touch or manage references if that](https://youtu.be/TIwmHGK29RY?t=00h41m37s)



[boolean is true because if it and you](https://youtu.be/TIwmHGK29RY?t=00h41m39s)



[call it with false from your finalizer](https://youtu.be/TIwmHGK29RY?t=00h41m42s)



[so that you know whether you can](https://youtu.be/TIwmHGK29RY?t=00h41m48s)



[actually trust your manager efference](https://youtu.be/TIwmHGK29RY?t=00h41m50s)



[--is or not yeah I don't so I agree with](https://youtu.be/TIwmHGK29RY?t=00h41m52s)



[everything you're saying but I think the](https://youtu.be/TIwmHGK29RY?t=00h41m56s)



[way that I would make sure that you use](https://youtu.be/TIwmHGK29RY?t=00h41m58s)



[that it's reentrant is not just to rely](https://youtu.be/TIwmHGK29RY?t=00h42m01s)



[on that boolean to actually go ahead and](https://youtu.be/TIwmHGK29RY?t=00h42m03s)



[reset the variables to know so that you](https://youtu.be/TIwmHGK29RY?t=00h42m05s)



[actually have a more](https://youtu.be/TIwmHGK29RY?t=00h42m07s)



[other than what's Annie calls you I](https://youtu.be/TIwmHGK29RY?t=00h42m08s)



[could I could understand that that would](https://youtu.be/TIwmHGK29RY?t=00h42m11s)



[make sense so by by by by specifying in](https://youtu.be/TIwmHGK29RY?t=00h42m13s)



[your mutex you did the question mark](https://youtu.be/TIwmHGK29RY?t=00h42m18s)



[period you know that it hasn't been](https://youtu.be/TIwmHGK29RY?t=00h42m19s)



[cleaned up what has things up so you](https://youtu.be/TIwmHGK29RY?t=00h42m21s)



[expect something you know the clean up](https://youtu.be/TIwmHGK29RY?t=00h42m23s)



[to the ends up looking something like](https://youtu.be/TIwmHGK29RY?t=00h42m26s)



[this alright yes gets ugly for trying to](https://youtu.be/TIwmHGK29RY?t=00h42m29s)



[use read only but me yeah an actual fact](https://youtu.be/TIwmHGK29RY?t=00h42m36s)



[because you assume that they implement a](https://youtu.be/TIwmHGK29RY?t=00h42m40s)



[mutex to be they've submitted mutex to](https://youtu.be/TIwmHGK29RY?t=00h42m42s)



[be reentrant I still don't think I think](https://youtu.be/TIwmHGK29RY?t=00h42m45s)



[you can still call dispose directly so I](https://youtu.be/TIwmHGK29RY?t=00h42m48s)



[think that actually works because they](https://youtu.be/TIwmHGK29RY?t=00h42m56s)



[assuming they wrote it correctly to](https://youtu.be/TIwmHGK29RY?t=00h42m58s)



[allow me to supposed to be reentrant](https://youtu.be/TIwmHGK29RY?t=00h43m00s)



[even if this suppose is being called you](https://youtu.be/TIwmHGK29RY?t=00h43m01s)



[can call it again](https://youtu.be/TIwmHGK29RY?t=00h43m03s)



[I guess my my thought is this little](https://youtu.be/TIwmHGK29RY?t=00h43m04s)



[period right here scares me but the](https://youtu.be/TIwmHGK29RY?t=00h43m08s)



[return of my memory management the](https://youtu.be/TIwmHGK29RY?t=00h43m12s)



[object is still around I am still around](https://youtu.be/TIwmHGK29RY?t=00h43m13s)



[but I can't guarantee anything I](https://youtu.be/TIwmHGK29RY?t=00h43m16s)



[references you can guarantee its](https://youtu.be/TIwmHGK29RY?t=00h43m18s)



[reference you just can't guarantee that](https://youtu.be/TIwmHGK29RY?t=00h43m21s)



[it's the dispose method has what hasn't](https://youtu.be/TIwmHGK29RY?t=00h43m22s)



[been called I can guarantee that a](https://youtu.be/TIwmHGK29RY?t=00h43m24s)



[managed so here let's be if there's if](https://youtu.be/TIwmHGK29RY?t=00h43m31s)



[there's still a reference to it](https://youtu.be/TIwmHGK29RY?t=00h43m34s)



[the district is not out of scope and it](https://youtu.be/TIwmHGK29RY?t=00h43m36s)



[can be called so you're telling me I](https://youtu.be/TIwmHGK29RY?t=00h43m41s)



[should be able to do thing to instance](https://youtu.be/TIwmHGK29RY?t=00h43m46s)



[clean up here pretend like that says](https://youtu.be/TIwmHGK29RY?t=00h43m49s)



[dispose yes](https://youtu.be/TIwmHGK29RY?t=00h43m51s)



[I can't matter if I believe you or not](https://youtu.be/TIwmHGK29RY?t=00h43m59s)



[oh I don't see why you would start now](https://youtu.be/TIwmHGK29RY?t=00h44m01s)



[but remember why we're talking about](https://youtu.be/TIwmHGK29RY?t=00h44m06s)



[memory management](https://youtu.be/TIwmHGK29RY?t=00h44m08s)



[there's never never a time where objects](https://youtu.be/TIwmHGK29RY?t=00h44m09s)



[out of scope does it become no never](https://youtu.be/TIwmHGK29RY?t=00h44m12s)



[time an object goes out of scope and](https://youtu.be/TIwmHGK29RY?t=00h44m16s)



[becomes no you it mean it goes out of](https://youtu.be/TIwmHGK29RY?t=00h44m18s)



[scope submit the memory manager just](https://youtu.be/TIwmHGK29RY?t=00h44m22s)



[cleans it up if you still have the](https://youtu.be/TIwmHGK29RY?t=00h44m24s)



[ability to call something on it it is](https://youtu.be/TIwmHGK29RY?t=00h44m26s)



[not no because it's a reference to it so](https://youtu.be/TIwmHGK29RY?t=00h44m27s)



[I'm sorry something in the back of my](https://youtu.be/TIwmHGK29RY?t=00h44m36s)



[mind is telling me that there's](https://youtu.be/TIwmHGK29RY?t=00h44m38s)



[something wrong with that right](https://youtu.be/TIwmHGK29RY?t=00h44m39s)



[free managed objects blah blah blah](https://youtu.be/TIwmHGK29RY?t=00h44m48s)



[because the order in which garbage](https://youtu.be/TIwmHGK29RY?t=00h44m57s)



[collection destroys managed objects](https://youtu.be/TIwmHGK29RY?t=00h45m00s)



[during final ations is not defined](https://youtu.be/TIwmHGK29RY?t=00h45m01s)



[calling the dis dispose overload but you](https://youtu.be/TIwmHGK29RY?t=00h45m03s)



[your your scintillating is that aware](https://youtu.be/TIwmHGK29RY?t=00h45m09s)



[you're conflating the resource](https://youtu.be/TIwmHGK29RY?t=00h45m13s)



[management with the memory management](https://youtu.be/TIwmHGK29RY?t=00h45m15s)



[if](https://youtu.be/TIwmHGK29RY?t=00h45m24s)



[you're looking at those two concepts the](https://youtu.be/TIwmHGK29RY?t=00h45m27s)



[same I don't see as long as disposable](https://youtu.be/TIwmHGK29RY?t=00h45m29s)



[is always reentrant the objects still](https://youtu.be/TIwmHGK29RY?t=00h45m32s)



[exist okay I might make us actually hack](https://youtu.be/TIwmHGK29RY?t=00h45m35s)



[out this example then at some point to](https://youtu.be/TIwmHGK29RY?t=00h45m42s)



[prove to me that it's okay because it](https://youtu.be/TIwmHGK29RY?t=00h45m44s)



[still it still is bothering me because](https://youtu.be/TIwmHGK29RY?t=00h45m47s)



[the whole point of this is so that you](https://youtu.be/TIwmHGK29RY?t=00h45m51s)



[know inside of this method whether you](https://youtu.be/TIwmHGK29RY?t=00h45m53s)



[came from a finalizer or not yeah I](https://youtu.be/TIwmHGK29RY?t=00h45m56s)



[think to do this what we're doing](https://youtu.be/TIwmHGK29RY?t=00h45m58s)



[completely we need to go ahead and add](https://youtu.be/TIwmHGK29RY?t=00h46m01s)



[dispose but we've still got a couple](https://youtu.be/TIwmHGK29RY?t=00h46m02s)



[things to prove out I believe okay well](https://youtu.be/TIwmHGK29RY?t=00h46m04s)



[I will stop then carry forward well I](https://youtu.be/TIwmHGK29RY?t=00h46m07s)



[just want to get look at the card let's](https://youtu.be/TIwmHGK29RY?t=00h46m11s)



[go back to the code and just review that](https://youtu.be/TIwmHGK29RY?t=00h46m13s)



[we've got a weak reference but I think](https://youtu.be/TIwmHGK29RY?t=00h46m14s)



[we've sort of added a bit of complexity](https://youtu.be/TIwmHGK29RY?t=00h46m16s)



[here that I'm not sure we want so if we](https://youtu.be/TIwmHGK29RY?t=00h46m17s)



[were trying to code this the simplest](https://youtu.be/TIwmHGK29RY?t=00h46m20s)



[way I think we need to have a close or](https://youtu.be/TIwmHGK29RY?t=00h46m22s)



[cleanup method that's an instance method](https://youtu.be/TIwmHGK29RY?t=00h46m24s)



[and I don't know if we want to have the](https://youtu.be/TIwmHGK29RY?t=00h46m26s)



[static cleanup that seems like it's can](https://youtu.be/TIwmHGK29RY?t=00h46m29s)



[we maybe put that oh yeah we can we can](https://youtu.be/TIwmHGK29RY?t=00h46m33s)



[clean that up so real quick I will clean](https://youtu.be/TIwmHGK29RY?t=00h46m35s)



[this up and get rid of the static one](https://youtu.be/TIwmHGK29RY?t=00h46m38s)



[Megan has a question about why does](https://youtu.be/TIwmHGK29RY?t=00h46m40s)



[dispose need to be reentrant because](https://youtu.be/TIwmHGK29RY?t=00h46m42s)



[it's not predictable how when who has](https://youtu.be/TIwmHGK29RY?t=00h46m46s)



[called a win if two objects refer to](https://youtu.be/TIwmHGK29RY?t=00h46m49s)



[something and you don't know what the](https://youtu.be/TIwmHGK29RY?t=00h46m51s)



[what are they being called in in the by](https://youtu.be/TIwmHGK29RY?t=00h46m53s)



[the finalizar two objects may call](https://youtu.be/TIwmHGK29RY?t=00h46m55s)



[disposed themselves and you don't know](https://youtu.be/TIwmHGK29RY?t=00h46m57s)



[you don't know which ones already called](https://youtu.be/TIwmHGK29RY?t=00h46m59s)



[it so it doesn't need to be like so the](https://youtu.be/TIwmHGK29RY?t=00h47m00s)



[best practices just do this but it is](https://youtu.be/TIwmHGK29RY?t=00h47m04s)



[possible that two objects are gonna call](https://youtu.be/TIwmHGK29RY?t=00h47m06s)



[disposed on the on the dispose method](https://youtu.be/TIwmHGK29RY?t=00h47m08s)



[the other thing that can happen is](https://youtu.be/TIwmHGK29RY?t=00h47m13s)



[there's the concept of Resurrection](https://youtu.be/TIwmHGK29RY?t=00h47m17s)



[Kevin give you remember the details on](https://youtu.be/TIwmHGK29RY?t=00h47m19s)



[this you can actually resurrect an](https://youtu.be/TIwmHGK29RY?t=00h47m21s)



[object yeah yes you can you can make](https://youtu.be/TIwmHGK29RY?t=00h47m23s)



[zombies in c-sharp and it is awesome and](https://youtu.be/TIwmHGK29RY?t=00h47m28s)



[you should never ever do it bad this is](https://youtu.be/TIwmHGK29RY?t=00h47m31s)



[not advisable but it is totally awesome](https://youtu.be/TIwmHGK29RY?t=00h47m35s)



[but it is a good example](https://youtu.be/TIwmHGK29RY?t=00h47m38s)



[object can be resurrected why disposed](https://youtu.be/TIwmHGK29RY?t=00h47m40s)



[man to be called multiple times let's](https://youtu.be/TIwmHGK29RY?t=00h47m42s)



[see so I can get away with it](https://youtu.be/TIwmHGK29RY?t=00h47m48s)



[Cameron points out that in this context](https://youtu.be/TIwmHGK29RY?t=00h47m53s)



[awesome means terrible aye aye aye but](https://youtu.be/TIwmHGK29RY?t=00h47m55s)



[it's so cool Cameron you know you've](https://youtu.be/TIwmHGK29RY?t=00h48m04s)



[always wanted to have your own zombie](https://youtu.be/TIwmHGK29RY?t=00h48m07s)



[object army I am giving you that chance](https://youtu.be/TIwmHGK29RY?t=00h48m09s)



[uh let's see](https://youtu.be/TIwmHGK29RY?t=00h48m11s)



[so let's I'm gonna just because I'm](https://youtu.be/TIwmHGK29RY?t=00h48m16s)



[getting a little too carried away with](https://youtu.be/TIwmHGK29RY?t=00h48m22s)



[my messages I think these need to be a](https://youtu.be/TIwmHGK29RY?t=00h48m23s)



[little clear I will put the method name](https://youtu.be/TIwmHGK29RY?t=00h48m29s)



[inside your message so we always know](https://youtu.be/TIwmHGK29RY?t=00h48m35s)



[what is being called the method name](https://youtu.be/TIwmHGK29RY?t=00h48m37s)



[inside my method the problem is I'm](https://youtu.be/TIwmHGK29RY?t=00h48m40s)



[inside the only game inside your message](https://youtu.be/TIwmHGK29RY?t=00h48m42s)



[the name of the method that the method](https://youtu.be/TIwmHGK29RY?t=00h48m46s)



[message exists in I would I would always](https://youtu.be/TIwmHGK29RY?t=00h48m49s)



[put that name this you know otherwise](https://youtu.be/TIwmHGK29RY?t=00h48m52s)



[we're losing track of which messages is](https://youtu.be/TIwmHGK29RY?t=00h48m56s)



[in which method I I don't disagree but](https://youtu.be/TIwmHGK29RY?t=00h48m57s)



[what name would you like me to put](https://youtu.be/TIwmHGK29RY?t=00h48m59s)



[inside of an anonymous delegate invoked](https://youtu.be/TIwmHGK29RY?t=00h49m01s)



[from a constructor anonymous delegate](https://youtu.be/TIwmHGK29RY?t=00h49m02s)



[invoke from a constructor it doesn't](https://youtu.be/TIwmHGK29RY?t=00h49m06s)



[matter you give it a name who cares give](https://youtu.be/TIwmHGK29RY?t=00h49m07s)



[it a variable name go ahead and go ahead](https://youtu.be/TIwmHGK29RY?t=00h49m09s)



[and write it as a method impact the so](https://youtu.be/TIwmHGK29RY?t=00h49m15s)



[here's the here's the thing though by](https://youtu.be/TIwmHGK29RY?t=00h49m19s)



[writing it as a method I now have this](https://youtu.be/TIwmHGK29RY?t=00h49m20s)



[static versus instance problem right](https://youtu.be/TIwmHGK29RY?t=00h49m23s)



[like I need to be clear on what it's](https://youtu.be/TIwmHGK29RY?t=00h49m25s)



[capturing over which is part of the](https://youtu.be/TIwmHGK29RY?t=00h49m26s)



[anonymous delegate then I don't have to](https://youtu.be/TIwmHGK29RY?t=00h49m29s)



[worry about it](https://youtu.be/TIwmHGK29RY?t=00h49m31s)



[that's I mean I can do it as a static](https://youtu.be/TIwmHGK29RY?t=00h49m32s)



[local function well remember that though](https://youtu.be/TIwmHGK29RY?t=00h49m35s)



[that's going to do is going to go it's](https://youtu.be/TIwmHGK29RY?t=00h49m38s)



[still gonna post it into the into the il](https://youtu.be/TIwmHGK29RY?t=00h49m39s)



[right force it into the il hoisted that](https://youtu.be/TIwmHGK29RY?t=00h49m43s)



[method is still going to exist in the il](https://youtu.be/TIwmHGK29RY?t=00h49m49s)



[yeah as an instance method correct](https://youtu.be/TIwmHGK29RY?t=00h49m51s)



[so what will](https://youtu.be/TIwmHGK29RY?t=00h49m53s)



[but it'll be on a hidden inner class at](https://youtu.be/TIwmHGK29RY?t=00h49m54s)



[this point and it won't capture over](https://youtu.be/TIwmHGK29RY?t=00h49m58s)



[anything I couldn't remember with us on](https://youtu.be/TIwmHGK29RY?t=00h49m59s)



[a hidden in a class or is on the this](https://youtu.be/TIwmHGK29RY?t=00h50m03s)



[class itself I can double check I'm](https://youtu.be/TIwmHGK29RY?t=00h50m05s)



[fairly confident they get their own](https://youtu.be/TIwmHGK29RY?t=00h50m07s)



[hidden inner classes okay so if we run](https://youtu.be/TIwmHGK29RY?t=00h50m09s)



[this okay so cleans up instance so the](https://youtu.be/TIwmHGK29RY?t=00h50m11s)



[instance say it alive which is what we](https://youtu.be/TIwmHGK29RY?t=00h50m23s)



[expect given the lack of a GC right and](https://youtu.be/TIwmHGK29RY?t=00h50m28s)



[if I turn the GC on I expected the other](https://youtu.be/TIwmHGK29RY?t=00h50m31s)



[half of my if statement](https://youtu.be/TIwmHGK29RY?t=00h50m35s)



[which is exactly what happens right so I](https://youtu.be/TIwmHGK29RY?t=00h50m43s)



[can force myself into either half of](https://youtu.be/TIwmHGK29RY?t=00h50m46s)



[this if statement based upon whether I](https://youtu.be/TIwmHGK29RY?t=00h50m48s)



[call GC collect or not okay it does sort](https://youtu.be/TIwmHGK29RY?t=00h50m50s)



[of make me want to write some sort of](https://youtu.be/TIwmHGK29RY?t=00h50m59s)



[fancy extension method on this or helper](https://youtu.be/TIwmHGK29RY?t=00h51m00s)



[this feels like something very very](https://youtu.be/TIwmHGK29RY?t=00h51m03s)



[generis sizable well and so that that's](https://youtu.be/TIwmHGK29RY?t=00h51m07s)



[the interesting part about this how do](https://youtu.be/TIwmHGK29RY?t=00h51m10s)



[we go ahead and write the full use the](https://youtu.be/TIwmHGK29RY?t=00h51m11s)



[full the full finalization pattern the](https://youtu.be/TIwmHGK29RY?t=00h51m15s)



[full finalization pattern we should have](https://youtu.be/TIwmHGK29RY?t=00h51m19s)



[disposed which goes that obviously ready](https://youtu.be/TIwmHGK29RY?t=00h51m20s)



[registers from GC I mean that whole](https://youtu.be/TIwmHGK29RY?t=00h51m23s)



[thing you should you shouldn't really be](https://youtu.be/TIwmHGK29RY?t=00h51m25s)



[implementing finalizes without a dispose](https://youtu.be/TIwmHGK29RY?t=00h51m26s)



[yes I would agree I cannot think of a](https://youtu.be/TIwmHGK29RY?t=00h51m30s)



[single situation where I've created a](https://youtu.be/TIwmHGK29RY?t=00h51m33s)



[finalizer where the object was not I](https://youtu.be/TIwmHGK29RY?t=00h51m35s)



[disposable in fact I would say the goat](https://youtu.be/TIwmHGK29RY?t=00h51m37s)



[because the coding guidelines are that](https://youtu.be/TIwmHGK29RY?t=00h51m41s)



[they should all go together if you have](https://youtu.be/TIwmHGK29RY?t=00h51m44s)



[a dispose method you should always have](https://youtu.be/TIwmHGK29RY?t=00h51m46s)



[a finalizar if you have a final answer](https://youtu.be/TIwmHGK29RY?t=00h51m47s)



[you should always have a dispose method](https://youtu.be/TIwmHGK29RY?t=00h51m49s)



[I don't know of any exceptions that is](https://youtu.be/TIwmHGK29RY?t=00h51m50s)



[fair so so okay so anything else we want](https://youtu.be/TIwmHGK29RY?t=00h51m54s)



[to test along this path before I think I](https://youtu.be/TIwmHGK29RY?t=00h51m57s)



[think you've covered all the scenarios I](https://youtu.be/TIwmHGK29RY?t=00h52m04s)



[knew about the most interesting one to](https://youtu.be/TIwmHGK29RY?t=00h52m06s)



[me was the fact that when you X](https://youtu.be/TIwmHGK29RY?t=00h52m08s)



[registered with process exit you had to](https://youtu.be/TIwmHGK29RY?t=00h52m09s)



[deal with the weak reference yes yeah](https://youtu.be/TIwmHGK29RY?t=00h52m12s)



[because this bites you all the time in](https://youtu.be/TIwmHGK29RY?t=00h52m16s)



[WPF like the number of times I've had](https://youtu.be/TIwmHGK29RY?t=00h52m18s)



[people ask questions about you know](https://youtu.be/TIwmHGK29RY?t=00h52m19s)



[what's going on why is why do I have](https://youtu.be/TIwmHGK29RY?t=00h52m21s)



[this memory leak very consistently I](https://youtu.be/TIwmHGK29RY?t=00h52m24s)



[just hunt for plus equals it's it's very](https://youtu.be/TIwmHGK29RY?t=00h52m26s)



[unique](https://youtu.be/TIwmHGK29RY?t=00h52m28s)



[like the c-sharp team is wonderful that](https://youtu.be/TIwmHGK29RY?t=00h52m29s)



[they've that they've significantly](https://youtu.be/TIwmHGK29RY?t=00h52m31s)



[improved the code you write to register](https://youtu.be/TIwmHGK29RY?t=00h52m33s)



[right they got it down to two characters](https://youtu.be/TIwmHGK29RY?t=00h52m36s)



[and and this is the problem union is](https://youtu.be/TIwmHGK29RY?t=00h52m39s)



[that people don't understand how much](https://youtu.be/TIwmHGK29RY?t=00h52m45s)



[code gets generated by those two](https://youtu.be/TIwmHGK29RY?t=00h52m47s)



[characters oh my goodness well actually](https://youtu.be/TIwmHGK29RY?t=00h52m49s)



[no those two characters aren't getting](https://youtu.be/TIwmHGK29RY?t=00h52m52s)



[it's not that there's generate that much](https://youtu.be/TIwmHGK29RY?t=00h52m54s)



[the process X](https://youtu.be/TIwmHGK29RY?t=00h52m55s)



[class or the method that when you create](https://youtu.be/TIwmHGK29RY?t=00h52m58s)



[the event is what generates tons of code](https://youtu.be/TIwmHGK29RY?t=00h53m01s)



[that's true so it's not actually the](https://youtu.be/TIwmHGK29RY?t=00h53m04s)



[plus equals because that's literally](https://youtu.be/TIwmHGK29RY?t=00h53m06s)



[just an assignment right delegate the](https://youtu.be/TIwmHGK29RY?t=00h53m08s)



[process exit declared is in a bed that's](https://youtu.be/TIwmHGK29RY?t=00h53m11s)



[what generates tons of code yeah there's](https://youtu.be/TIwmHGK29RY?t=00h53m13s)



[a comment that the difference between](https://youtu.be/TIwmHGK29RY?t=00h53m16s)



[awesome and terrible is shipping and I'm](https://youtu.be/TIwmHGK29RY?t=00h53m18s)



[okay with that definition because I have](https://youtu.be/TIwmHGK29RY?t=00h53m24s)



[shipped stuff like this okay so do we](https://youtu.be/TIwmHGK29RY?t=00h53m26s)



[want to go down the I disposable path](https://youtu.be/TIwmHGK29RY?t=00h53m33s)



[now is that where we think we go next](https://youtu.be/TIwmHGK29RY?t=00h53m34s)



[that the only part that I think is left](https://youtu.be/TIwmHGK29RY?t=00h53m36s)



[remaining here is what is the general](https://youtu.be/TIwmHGK29RY?t=00h53m39s)



[pattern that we want for implementing](https://youtu.be/TIwmHGK29RY?t=00h53m40s)



[finalized errs and disposables assuming](https://youtu.be/TIwmHGK29RY?t=00h53m43s)



[they both together let's just call it](https://youtu.be/TIwmHGK29RY?t=00h53m46s)



[the dispose pattern right so first](https://youtu.be/TIwmHGK29RY?t=00h53m47s)



[assumption you're coding and dotnet core](https://youtu.be/TIwmHGK29RY?t=00h53m49s)



[right because I don't I don't know if we](https://youtu.be/TIwmHGK29RY?t=00h53m52s)



[want to make a rule that's different I](https://youtu.be/TIwmHGK29RY?t=00h53m57s)



[think you want to do the same regardless](https://youtu.be/TIwmHGK29RY?t=00h53m59s)



[well but is does this API exist with the](https://youtu.be/TIwmHGK29RY?t=00h54m01s)



[via the the process exit like so here's](https://youtu.be/TIwmHGK29RY?t=00h54m08s)



[here's my quite like I don't mind being](https://youtu.be/TIwmHGK29RY?t=00h54m14s)



[different but does that exist in like](https://youtu.be/TIwmHGK29RY?t=00h54m16s)



[four six change just changed your](https://youtu.be/TIwmHGK29RY?t=00h54m18s)



[project oh that's a better test isn't it](https://youtu.be/TIwmHGK29RY?t=00h54m22s)



[I believe the answer is yes](https://youtu.be/TIwmHGK29RY?t=00h54m24s)



[okay so okay so the API exists this is](https://youtu.be/TIwmHGK29RY?t=00h54m37s)



[about to get really ugly well that's why](https://youtu.be/TIwmHGK29RY?t=00h54m45s)



[you know even with a helper this is I'm](https://youtu.be/TIwmHGK29RY?t=00h54m49s)



[just I'm just envisioning a particular](https://youtu.be/TIwmHGK29RY?t=00h54m51s)



[project I have where there's a lot of](https://youtu.be/TIwmHGK29RY?t=00h54m53s)



[finalized errs due to some pointer](https://youtu.be/TIwmHGK29RY?t=00h54m56s)



[horrendous nests that may be getting](https://youtu.be/TIwmHGK29RY?t=00h54m58s)



[done and hypothetically speaking](https://youtu.be/TIwmHGK29RY?t=00h55m01s)



[hypothetically speaking no one would](https://youtu.be/TIwmHGK29RY?t=00h55m03s)



[ever do something crazy like of course](https://youtu.be/TIwmHGK29RY?t=00h55m06s)



[no of course but in actual fact I would](https://youtu.be/TIwmHGK29RY?t=00h55m08s)



[say in those pointer scenarios can't you](https://youtu.be/TIwmHGK29RY?t=00h55m10s)



[rely on safe handles not always because](https://youtu.be/TIwmHGK29RY?t=00h55m12s)



[I'm not always responsible for making](https://youtu.be/TIwmHGK29RY?t=00h55m18s)



[those like I can I can sort of wrap](https://youtu.be/TIwmHGK29RY?t=00h55m20s)



[things in safe handles but a lot of](https://youtu.be/TIwmHGK29RY?t=00h55m22s)



[times I'm getting the pointer back pass](https://youtu.be/TIwmHGK29RY?t=00h55m24s)



[to me and then I'm sending it somewhere](https://youtu.be/TIwmHGK29RY?t=00h55m27s)



[else so I can kind of do it but](https://youtu.be/TIwmHGK29RY?t=00h55m29s)



[ultimately I still have to manage it but](https://youtu.be/TIwmHGK29RY?t=00h55m32s)



[if you're sending it somewhere else](https://youtu.be/TIwmHGK29RY?t=00h55m35s)



[they're gonna have references to it and](https://youtu.be/TIwmHGK29RY?t=00h55m36s)



[stuff I don't know it just seems to me](https://youtu.be/TIwmHGK29RY?t=00h55m38s)



[you want to use safe handle as much as](https://youtu.be/TIwmHGK29RY?t=00h55m39s)



[possible in the Pointer case I mean](https://youtu.be/TIwmHGK29RY?t=00h55m41s)



[that's what safe handles designed for I](https://youtu.be/TIwmHGK29RY?t=00h55m43s)



[do completely agree completely agree I](https://youtu.be/TIwmHGK29RY?t=00h55m44s)



[just in in our case I don't think it's](https://youtu.be/TIwmHGK29RY?t=00h55m48s)



[always possible I we shouldn't do it now](https://youtu.be/TIwmHGK29RY?t=00h55m50s)



[I mean I'd be curious to understand what](https://youtu.be/TIwmHGK29RY?t=00h55m55s)



[scenario you have that you can use a](https://youtu.be/TIwmHGK29RY?t=00h55m57s)



[safe handle for a pointer dad is fair](https://youtu.be/TIwmHGK29RY?t=00h55m58s)



[I'm so not to derail us too much but](https://youtu.be/TIwmHGK29RY?t=00h56m07s)



[when we get to the I disposable I am](https://youtu.be/TIwmHGK29RY?t=00h56m10s)



[curious about ienumerable to go along](https://youtu.be/TIwmHGK29RY?t=00h56m11s)



[with it explain ienumerable derives from](https://youtu.be/TIwmHGK29RY?t=00h56m14s)



[it well but of course okay I'm just just](https://youtu.be/TIwmHGK29RY?t=00h56m20s)



[just so we're all there that we play](https://youtu.be/TIwmHGK29RY?t=00h56m24s)



[here it's going to affect enumerables so](https://youtu.be/TIwmHGK29RY?t=00h56m27s)



[as soon as I a sink enumerable and for](https://youtu.be/TIwmHGK29RY?t=00h56m30s)



[that matter this is now and I a sink](https://youtu.be/TIwmHGK29RY?t=00h56m32s)



[disposable agreed again this is about to](https://youtu.be/TIwmHGK29RY?t=00h56m34s)



[get very very ugly I don't I don't think](https://youtu.be/TIwmHGK29RY?t=00h56m38s)



[so okay I mean what you have you've got](https://youtu.be/TIwmHGK29RY?t=00h56m42s)



[it you've got to be basically trying to](https://youtu.be/TIwmHGK29RY?t=00h56m45s)



[refactor this code so we can sort two](https://youtu.be/TIwmHGK29RY?t=00h56m46s)



[objects at the end of the day what we](https://youtu.be/TIwmHGK29RY?t=00h56m48s)



[want to do is we want to have a bad](https://youtu.be/TIwmHGK29RY?t=00h56m49s)



[thing and we have a another thing and we](https://youtu.be/TIwmHGK29RY?t=00h56m51s)



[want to be able to implement the dispose](https://youtu.be/TIwmHGK29RY?t=00h56m54s)



[pattern without writing a thousand lines](https://youtu.be/TIwmHGK29RY?t=00h56m56s)



[of code I guess the goal so what you're](https://youtu.be/TIwmHGK29RY?t=00h56m58s)



[saying is we have thing one and thing](https://youtu.be/TIwmHGK29RY?t=00h57m01s)



[two we have to clean up a mess](https://youtu.be/TIwmHGK29RY?t=00h57m02s)



[yes exactly all the hats I have sitting](https://youtu.be/TIwmHGK29RY?t=00h57m04s)



[next to me I don't have the right one](https://youtu.be/TIwmHGK29RY?t=00h57m07s)



[for this moment which is really](https://youtu.be/TIwmHGK29RY?t=00h57m09s)



[disappointing I'm so sorry](https://youtu.be/TIwmHGK29RY?t=00h57m12s)



[add that to my list I need a Cat in the](https://youtu.be/TIwmHGK29RY?t=00h57m14s)



[Hat hat or or just a thing what anything](https://youtu.be/TIwmHGK29RY?t=00h57m17s)



[- sure that's true okay so we are going](https://youtu.be/TIwmHGK29RY?t=00h57m21s)



[to do this so we're gonna start with](https://youtu.be/TIwmHGK29RY?t=00h57m27s)



[we're gonna start here right so uh can I](https://youtu.be/TIwmHGK29RY?t=00h57m30s)



[can I cheat real quick private static](https://youtu.be/TIwmHGK29RY?t=00h57m37s)



[void right why did you mean can I go](https://youtu.be/TIwmHGK29RY?t=00h57m41s)



[ahead and call resharper and have it](https://youtu.be/TIwmHGK29RY?t=00h57m46s)



[generate my dispose method](https://youtu.be/TIwmHGK29RY?t=00h57m48s)



[no I'm just getting really annoyed of](https://youtu.be/TIwmHGK29RY?t=00h57m53s)



[typing all of this out every time so I'm](https://youtu.be/TIwmHGK29RY?t=00h57m55s)



[I'm just going to yeah this is exactly](https://youtu.be/TIwmHGK29RY?t=00h57m58s)



[what I'm going to horrendously cheat](https://youtu.be/TIwmHGK29RY?t=00h58m01s)



[let's see yeah oh that's out that would](https://youtu.be/TIwmHGK29RY?t=00h58m11s)



[be bad](https://youtu.be/TIwmHGK29RY?t=00h58m18s)



[boom okay so now I just do right line I](https://youtu.be/TIwmHGK29RY?t=00h58m20s)



[don't know empty string Oh better](https://youtu.be/TIwmHGK29RY?t=00h58m27s)



[can you call right line without anything](https://youtu.be/TIwmHGK29RY?t=00h58m34s)



[I can as soon as I do this](https://youtu.be/TIwmHGK29RY?t=00h58m35s)



[boom what are you squawking about my](https://youtu.be/TIwmHGK29RY?t=00h58m49s)



[color remember name go at it there we go](https://youtu.be/TIwmHGK29RY?t=00h58m53s)



[okay now less thinking more awesome okay](https://youtu.be/TIwmHGK29RY?t=00h58m58s)



[so that gets rid of that and I think I](https://youtu.be/TIwmHGK29RY?t=00h59m05s)



[get rid of here and instead of instance](https://youtu.be/TIwmHGK29RY?t=00h59m09s)



[cleanup we're gonna call dispose instead](https://youtu.be/TIwmHGK29RY?t=00h59m12s)



[I realize this is not the correct](https://youtu.be/TIwmHGK29RY?t=00h59m14s)



[dispose pattern we'll get there in a](https://youtu.be/TIwmHGK29RY?t=00h59m17s)



[moment](https://youtu.be/TIwmHGK29RY?t=00h59m20s)



[right clean that up](https://youtu.be/TIwmHGK29RY?t=00h59m21s)



[you no longer need mark I'm really](https://youtu.be/TIwmHGK29RY?t=00h59m30s)



[curious with this height](https://youtu.be/TIwmHGK29RY?t=00h59m37s)



[okay](https://youtu.be/TIwmHGK29RY?t=00h59m48s)



[go](https://youtu.be/TIwmHGK29RY?t=00h59m59s)



[I think that works right so we have a GC](https://youtu.be/TIwmHGK29RY?t=01h00m02s)



[collect so we come in here we we see the](https://youtu.be/TIwmHGK29RY?t=01h00m05s)



[instantiation I'm getting rid of](https://youtu.be/TIwmHGK29RY?t=01h00m09s)



[HelloWorld because that's just adding to](https://youtu.be/TIwmHGK29RY?t=01h00m10s)



[my noise right we see my constructor](https://youtu.be/TIwmHGK29RY?t=01h00m12s)



[gets called new thing finalize gets](https://youtu.be/TIwmHGK29RY?t=01h00m15s)



[called thing be gone because we fell out](https://youtu.be/TIwmHGK29RY?t=01h00m20s)



[of scope and GC collect forced it to](https://youtu.be/TIwmHGK29RY?t=01h00m22s)



[kick off we then hit process exit came](https://youtu.be/TIwmHGK29RY?t=01h00m26s)



[in week reference no longer has a](https://youtu.be/TIwmHGK29RY?t=01h00m29s)



[reference so we graph dead also](https://youtu.be/TIwmHGK29RY?t=01h00m31s)



[realizing that that isn't using my new](https://youtu.be/TIwmHGK29RY?t=01h00m36s)



[method I'm curious what this thing](https://youtu.be/TIwmHGK29RY?t=01h00m39s)



[reports yeah constructor good to know](https://youtu.be/TIwmHGK29RY?t=01h00m43s)



[I wasn't sure what caller member name](https://youtu.be/TIwmHGK29RY?t=01h00m50s)



[was gonna be there it's interesting that](https://youtu.be/TIwmHGK29RY?t=01h00m52s)



[it did the same thing for finalize the](https://youtu.be/TIwmHGK29RY?t=01h00m56s)



[column one my name and finalized his](https://youtu.be/TIwmHGK29RY?t=01h01m00s)



[final is yes yes that when I was aware](https://youtu.be/TIwmHGK29RY?t=01h01m01s)



[of because the you can actually get at](https://youtu.be/TIwmHGK29RY?t=01h01m04s)



[what is it this what happens if you have](https://youtu.be/TIwmHGK29RY?t=01h01m10s)



[a method called finalized pretty sure it](https://youtu.be/TIwmHGK29RY?t=01h01m14s)



[doesn't allow it but let's check what](https://youtu.be/TIwmHGK29RY?t=01h01m17s)



[I'm introducing a finalized method can](https://youtu.be/TIwmHGK29RY?t=01h01m30s)



[interfere with destructor invocation and](https://youtu.be/TIwmHGK29RY?t=01h01m33s)



[that's an era not a warning right no](https://youtu.be/TIwmHGK29RY?t=01h01m37s)



[idea](https://youtu.be/TIwmHGK29RY?t=01h01m42s)



[well compiled don't build do run I'm](https://youtu.be/TIwmHGK29RY?t=01h01m43s)



[lazy boom yeah so short version that](https://youtu.be/TIwmHGK29RY?t=01h01m47s)



[guy's gonna gen 1 this guy now conflicts](https://youtu.be/TIwmHGK29RY?t=01h01m54s)



[you have to break it for overload](https://youtu.be/TIwmHGK29RY?t=01h01m57s)



[resolution so](https://youtu.be/TIwmHGK29RY?t=01h02m01s)



[yeah you should you shouldn't have](https://youtu.be/TIwmHGK29RY?t=01h02m10s)



[finalized as any method ain't finalized](https://youtu.be/TIwmHGK29RY?t=01h02m11s)



[I think it's a reasonable rule I agree](https://youtu.be/TIwmHGK29RY?t=01h02m13s)



[and it very accurately warns you that](https://youtu.be/TIwmHGK29RY?t=01h02m16s)



[you're doing something bad and then](https://youtu.be/TIwmHGK29RY?t=01h02m19s)



[blows up so okay okay so the key thing](https://youtu.be/TIwmHGK29RY?t=01h02m21s)



[here that we want to be aware of is your](https://youtu.be/TIwmHGK29RY?t=01h02m30s)



[registration with the recurrence yep is](https://youtu.be/TIwmHGK29RY?t=01h02m31s)



[there anything else that needs to be](https://youtu.be/TIwmHGK29RY?t=01h02m35s)



[refactored well part of me really wants](https://youtu.be/TIwmHGK29RY?t=01h02m36s)



[to do something more like I don't know](https://youtu.be/TIwmHGK29RY?t=01h02m43s)



[right I kind of want that right looks](https://youtu.be/TIwmHGK29RY?t=01h02m54s)



[I'm saying refactor that's what I meant](https://youtu.be/TIwmHGK29RY?t=01h02m59s)



[if you want to refactor everything](https://youtu.be/TIwmHGK29RY?t=01h03m00s)



[inside your your constructor class I](https://youtu.be/TIwmHGK29RY?t=01h03m02s)



[disposable standard name this I](https://youtu.be/TIwmHGK29RY?t=01h03m10s)



[disposable no no what](https://youtu.be/TIwmHGK29RY?t=01h03m15s)



[what if you had a static the extension](https://youtu.be/TIwmHGK29RY?t=01h03m19s)



[method that took an i disposable that's](https://youtu.be/TIwmHGK29RY?t=01h03m23s)



[what I'm thinking this is going to do](https://youtu.be/TIwmHGK29RY?t=01h03m26s)



[right okay](https://youtu.be/TIwmHGK29RY?t=01h03m27s)



[I'm worried because we're now I](https://youtu.be/TIwmHGK29RY?t=01h03m29s)



[disposable so we can do this I would](https://youtu.be/TIwmHGK29RY?t=01h03m30s)



[pull it just disposable the class](https://youtu.be/TIwmHGK29RY?t=01h03m32s)



[register for finalized I don't know yeah](https://youtu.be/TIwmHGK29RY?t=01h03m50s)



[it's good enough for now we don't yeah](https://youtu.be/TIwmHGK29RY?t=01h03m57s)



[I'm a little torn on using the word](https://youtu.be/TIwmHGK29RY?t=01h03m59s)



[finalized because it seems to imply](https://youtu.be/TIwmHGK29RY?t=01h04m00s)



[something about the finalizer right](https://youtu.be/TIwmHGK29RY?t=01h04m05s)



[dozen executives didn't play well but](https://youtu.be/TIwmHGK29RY?t=01h04m07s)



[we're not going to invoke the finalizar](https://youtu.be/TIwmHGK29RY?t=01h04m12s)



[know it's register for finalized no that](https://youtu.be/TIwmHGK29RY?t=01h04m15s)



[evoke the fine laser fair fair let's see](https://youtu.be/TIwmHGK29RY?t=01h04m18s)



[this becomes I disposable maybe it's](https://youtu.be/TIwmHGK29RY?t=01h04m23s)



[registered disposable fine light yes ok](https://youtu.be/TIwmHGK29RY?t=01h04m27s)



[wow I cannot type let's try that again](https://youtu.be/TIwmHGK29RY?t=01h04m36s)



[console ok and this thing becomes I](https://youtu.be/TIwmHGK29RY?t=01h04m40s)



[disposable right so that now doesn't](https://youtu.be/TIwmHGK29RY?t=01h04m46s)



[look quite as ugly let's just make sure](https://youtu.be/TIwmHGK29RY?t=01h04m53s)



[it still works](https://youtu.be/TIwmHGK29RY?t=01h04m56s)



[finalized thing begone week reference](https://youtu.be/TIwmHGK29RY?t=01h05m04s)



[dead clear that toggle the other case](https://youtu.be/TIwmHGK29RY?t=01h05m07s)



[okay it appears we are falling down both](https://youtu.be/TIwmHGK29RY?t=01h05m18s)



[cases of our if and in actual fact do we](https://youtu.be/TIwmHGK29RY?t=01h05m21s)



[need to ever test the system not to](https://youtu.be/TIwmHGK29RY?t=01h05m28s)



[collect method now we do eat everything](https://youtu.be/TIwmHGK29RY?t=01h05m30s)



[I have to try the system dot G Co I](https://youtu.be/TIwmHGK29RY?t=01h05m32s)



[guess because we want to make sure the](https://youtu.be/TIwmHGK29RY?t=01h05m35s)



[finalizar is invoked](https://youtu.be/TIwmHGK29RY?t=01h05m36s)



[yes that's mostly a sanity check to make](https://youtu.be/TIwmHGK29RY?t=01h05m37s)



[sure kevin has something isn't there can](https://youtu.be/TIwmHGK29RY?t=01h05m40s)



[you do you can't collect on a specific](https://youtu.be/TIwmHGK29RY?t=01h05m44s)



[object I'm just wondering if we do this](https://youtu.be/TIwmHGK29RY?t=01h05m47s)



[and without having to run the process](https://youtu.be/TIwmHGK29RY?t=01h05m49s)



[twice no you cannot do collect on a](https://youtu.be/TIwmHGK29RY?t=01h05m50s)



[specific object but for those people who](https://youtu.be/TIwmHGK29RY?t=01h05m52s)



[want to know how to make zombies let's](https://youtu.be/TIwmHGK29RY?t=01h05m54s)



[see it's a system GC oh you know you're](https://youtu.be/TIwmHGK29RY?t=01h05m57s)



[missing you're missing in the plant](https://youtu.be/TIwmHGK29RY?t=01h06m02s)



[you're missing the cancel finalization](https://youtu.be/TIwmHGK29RY?t=01h06m03s)



[yeah that's what we get to the full](https://youtu.be/TIwmHGK29RY?t=01h06m06s)



[dispose right because did you rear edge](https://youtu.be/TIwmHGK29RY?t=01h06m08s)



[astir for finalized yes where is it it's](https://youtu.be/TIwmHGK29RY?t=01h06m16s)



[right there yeah so you can take](https://youtu.be/TIwmHGK29RY?t=01h06m22s)



[yourself out of the queue right so if](https://youtu.be/TIwmHGK29RY?t=01h06m25s)



[you suppress finalize that second step](https://youtu.be/TIwmHGK29RY?t=01h06m27s)



[of the GC where it goes through and](https://youtu.be/TIwmHGK29RY?t=01h06m29s)



[calls your finalizer yeah that method](https://youtu.be/TIwmHGK29RY?t=01h06m30s)



[says don't do that okay so the other](https://youtu.be/TIwmHGK29RY?t=01h06m32s)



[thing that's worth noting is I don't](https://youtu.be/TIwmHGK29RY?t=01h06m40s)



[think we can full like the other problem](https://youtu.be/TIwmHGK29RY?t=01h06m42s)



[with trying to do this completely](https://youtu.be/TIwmHGK29RY?t=01h06m44s)



[generically is the same reason why](https://youtu.be/TIwmHGK29RY?t=01h06m45s)



[there's not a completely generic](https://youtu.be/TIwmHGK29RY?t=01h06m47s)



[disposed implementation because there's](https://youtu.be/TIwmHGK29RY?t=01h06m50s)



[four cases right but it's hopeful sorry](https://youtu.be/TIwmHGK29RY?t=01h06m52s)



[Kevin](https://youtu.be/TIwmHGK29RY?t=01h06m57s)



[why are we not calling GC suppress](https://youtu.be/TIwmHGK29RY?t=01h06m58s)



[from right here if this pose gets called](https://youtu.be/TIwmHGK29RY?t=01h07m03s)



[GC suppress should be called okay yes I](https://youtu.be/TIwmHGK29RY?t=01h07m06s)



[will I will I will fix this because this](https://youtu.be/TIwmHGK29RY?t=01h07m09s)



[is this is really what the full dispose](https://youtu.be/TIwmHGK29RY?t=01h07m12s)



[implementation should look like right so](https://youtu.be/TIwmHGK29RY?t=01h07m15s)



[this becomes disposed true right this](https://youtu.be/TIwmHGK29RY?t=01h07m17s)



[guy becomes disposed false all right and](https://youtu.be/TIwmHGK29RY?t=01h07m21s)



[then this becomes disposed full](https://youtu.be/TIwmHGK29RY?t=01h07m27s)



[disposing we need a private member I](https://youtu.be/TIwmHGK29RY?t=01h07m31s)



[think they don't create dispose I](https://youtu.be/TIwmHGK29RY?t=01h07m36s)



[dispose will have a second method on it](https://youtu.be/TIwmHGK29RY?t=01h07m38s)



[and you know what we should do we should](https://youtu.be/TIwmHGK29RY?t=01h07m40s)



[go ahead and define a interface default](https://youtu.be/TIwmHGK29RY?t=01h07m42s)



[member Microsoft should define an info](https://youtu.be/TIwmHGK29RY?t=01h07m52s)



[as default member called anti disposable](https://youtu.be/TIwmHGK29RY?t=01h07m56s)



[load your hands I can I can imagine what](https://youtu.be/TIwmHGK29RY?t=01h07m58s)



[that would do oh dear heavens alright](https://youtu.be/TIwmHGK29RY?t=01h08m01s)



[this looks something like this but that](https://youtu.be/TIwmHGK29RY?t=01h08m09s)



[code is the same every time say say what](https://youtu.be/TIwmHGK29RY?t=01h08m12s)



[again your dispose it takes it variable](https://youtu.be/TIwmHGK29RY?t=01h08m15s)



[it's the same every time it is but the](https://youtu.be/TIwmHGK29RY?t=01h08m19s)



[so the key bit is the difference it like](https://youtu.be/TIwmHGK29RY?t=01h08m22s)



[there's a reason there's four separate](https://youtu.be/TIwmHGK29RY?t=01h08m25s)



[sections on this implementing right and](https://youtu.be/TIwmHGK29RY?t=01h08m27s)



[inside a visual studio you can now](https://youtu.be/TIwmHGK29RY?t=01h08m31s)



[generate yeah they finally copy what](https://youtu.be/TIwmHGK29RY?t=01h08m34s)



[resharper has had for a while](https://youtu.be/TIwmHGK29RY?t=01h08m36s)



[alright you can now just say Auto](https://youtu.be/TIwmHGK29RY?t=01h08m37s)



[gentleman tation and it will give you](https://youtu.be/TIwmHGK29RY?t=01h08m41s)



[something I think the default one well](https://youtu.be/TIwmHGK29RY?t=01h08m44s)



[that's not quite right it Jen's up a lot](https://youtu.be/TIwmHGK29RY?t=01h08m48s)



[of code and comments out a lot of code](https://youtu.be/TIwmHGK29RY?t=01h08m52s)



[because you you'll note that in some of](https://youtu.be/TIwmHGK29RY?t=01h08m53s)



[these cases they don't have a finalizer](https://youtu.be/TIwmHGK29RY?t=01h08m55s)



[right you don't need a finalizer in all](https://youtu.be/TIwmHGK29RY?t=01h08m59s)



[cases why not I don't agree you don't](https://youtu.be/TIwmHGK29RY?t=01h09m02s)



[need a finalizer if there's no unmanaged](https://youtu.be/TIwmHGK29RY?t=01h09m06s)



[objects then why did he dispose](https://youtu.be/TIwmHGK29RY?t=01h09m11s)



[so that you can clean up your managed](https://youtu.be/TIwmHGK29RY?t=01h09m15s)



[stuff why do you need to clean up your](https://youtu.be/TIwmHGK29RY?t=01h09m18s)



[managed stuff that's what the cart GC](https://youtu.be/TIwmHGK29RY?t=01h09m21s)



[does not if you want it deterministic](https://youtu.be/TIwmHGK29RY?t=01h09m22s)



[why I'm not following](https://youtu.be/TIwmHGK29RY?t=01h09m27s)



[well for example scenario you want to](https://youtu.be/TIwmHGK29RY?t=01h09m30s)



[set things to null no file handle I want](https://youtu.be/TIwmHGK29RY?t=01h09m32s)



[to make sure done with like football](https://youtu.be/TIwmHGK29RY?t=01h09m38s)



[well handles handle themselves well they](https://youtu.be/TIwmHGK29RY?t=01h09m40s)



[will clean up when when they get when](https://youtu.be/TIwmHGK29RY?t=01h09m43s)



[the GC cleans them up but if I want to](https://youtu.be/TIwmHGK29RY?t=01h09m46s)



[make sure I release my file handle when](https://youtu.be/TIwmHGK29RY?t=01h09m47s)



[I'm done with it](https://youtu.be/TIwmHGK29RY?t=01h09m49s)



[I need to actually wrap it in and using](https://youtu.be/TIwmHGK29RY?t=01h09m49s)



[right so the dispose gets invoked yeah](https://youtu.be/TIwmHGK29RY?t=01h09m52s)



[exactly but you still want to finalize](https://youtu.be/TIwmHGK29RY?t=01h09m54s)



[that if you forget it gets invoked still](https://youtu.be/TIwmHGK29RY?t=01h09m57s)



[want to finalize or so that if it gets](https://youtu.be/TIwmHGK29RY?t=01h10m03s)



[invoked okay so this whole name is three](https://youtu.be/TIwmHGK29RY?t=01h10m05s)



[statements so what you're saying is I've](https://youtu.be/TIwmHGK29RY?t=01h10m08s)



[got an object that has got its own](https://youtu.be/TIwmHGK29RY?t=01h10m10s)



[finalizer on it therefore if I](https://youtu.be/TIwmHGK29RY?t=01h10m13s)



[instantiate it I don't need to worry](https://youtu.be/TIwmHGK29RY?t=01h10m16s)



[about invoking its finalizar or music I](https://youtu.be/TIwmHGK29RY?t=01h10m17s)



[just need to worry about using dispose](https://youtu.be/TIwmHGK29RY?t=01h10m19s)



[correct if you are wrapping if you are](https://youtu.be/TIwmHGK29RY?t=01h10m22s)



[not directly doing the unmanaged e stuff](https://youtu.be/TIwmHGK29RY?t=01h10m26s)



[on your own you don't need to care right](https://youtu.be/TIwmHGK29RY?t=01h10m29s)



[it's when you are dealing with an](https://youtu.be/TIwmHGK29RY?t=01h10m34s)



[unmanaged objects what I'm trying to](https://youtu.be/TIwmHGK29RY?t=01h10m35s)



[understand is why we're trying to](https://youtu.be/TIwmHGK29RY?t=01h10m37s)



[clarify is why do you need dispose why](https://youtu.be/TIwmHGK29RY?t=01h10m39s)



[do you implement I dispose why do you](https://youtu.be/TIwmHGK29RY?t=01h10m42s)



[implement I dispose well so forth take](https://youtu.be/TIwmHGK29RY?t=01h10m47s)



[your temp file case right yeah it's](https://youtu.be/TIwmHGK29RY?t=01h10m51s)



[because when you go out of scope you](https://youtu.be/TIwmHGK29RY?t=01h10m53s)



[want to make sure it gets cleaned up](https://youtu.be/TIwmHGK29RY?t=01h10m55s)



[yeah you want to support the dispose](https://youtu.be/TIwmHGK29RY?t=01h10m56s)



[pattern on your object you better clean](https://youtu.be/TIwmHGK29RY?t=01h10m58s)



[up the other object that supports the](https://youtu.be/TIwmHGK29RY?t=01h10m59s)



[dispose pattern sorry](https://youtu.be/TIwmHGK29RY?t=01h11m01s)



[big bright right screen for a moment](https://youtu.be/TIwmHGK29RY?t=01h11m03s)



[I'll let that fire up resharper's gonna](https://youtu.be/TIwmHGK29RY?t=01h11m08s)



[have to think about what it's done but I](https://youtu.be/TIwmHGK29RY?t=01h11m11s)



[want to show the default oh wow that is](https://youtu.be/TIwmHGK29RY?t=01h11m14s)



[tiny let's make that bigger](https://youtu.be/TIwmHGK29RY?t=01h11m18s)



[because the the generated pattern that](https://youtu.be/TIwmHGK29RY?t=01h11m24s)



[they have is actually oh this is gonna](https://youtu.be/TIwmHGK29RY?t=01h11m27s)



[be resharper's isn't it I need the one](https://youtu.be/TIwmHGK29RY?t=01h11m29s)



[without resharper the control period](https://youtu.be/TIwmHGK29RY?t=01h11m33s)



[network so it does the problem is](https://youtu.be/TIwmHGK29RY?t=01h11m38s)



[resharper hijacks it and I don't I have](https://youtu.be/TIwmHGK29RY?t=01h11m41s)



[to turn resharper off to see it I don't](https://youtu.be/TIwmHGK29RY?t=01h11m44s)



[think I've ever seen you do this this is](https://youtu.be/TIwmHGK29RY?t=01h11m48s)



[gonna be quite an experience](https://youtu.be/TIwmHGK29RY?t=01h11m49s)



[turning a sharper off yeah well it's not](https://youtu.be/TIwmHGK29RY?t=01h11m50s)



[exactly a challenge but that's not my](https://youtu.be/TIwmHGK29RY?t=01h11m54s)



[point](https://youtu.be/TIwmHGK29RY?t=01h11m57s)



[it goes against religion as a challenge](https://youtu.be/TIwmHGK29RY?t=01h11m58s)



[for you I only have it turned on on one](https://youtu.be/TIwmHGK29RY?t=01h12m00s)



[of my computer so I actually see both](https://youtu.be/TIwmHGK29RY?t=01h12m02s)



[sides and it annoys me that's not what I](https://youtu.be/TIwmHGK29RY?t=01h12m04s)



[want](https://youtu.be/TIwmHGK29RY?t=01h12m08s)



[where are you a sharper](https://youtu.be/TIwmHGK29RY?t=01h12m10s)



[I might come back to this at a later](https://youtu.be/TIwmHGK29RY?t=01h12m14s)



[point and Jen it up the default one that](https://youtu.be/TIwmHGK29RY?t=01h12m16s)



[it generates is actually rather nice in](https://youtu.be/TIwmHGK29RY?t=01h12m18s)



[the way that it comments everything out](https://youtu.be/TIwmHGK29RY?t=01h12m22s)



[right but it did](https://youtu.be/TIwmHGK29RY?t=01h12m23s)



[it'll Jen one up for you with a](https://youtu.be/TIwmHGK29RY?t=01h12m25s)



[finalizar but the finalizes commented](https://youtu.be/TIwmHGK29RY?t=01h12m28s)



[out because they realized that most](https://youtu.be/TIwmHGK29RY?t=01h12m30s)



[people probably are generating I](https://youtu.be/TIwmHGK29RY?t=01h12m33s)



[disposable without meeting unmanaged](https://youtu.be/TIwmHGK29RY?t=01h12m35s)



[stuff resharper is so old-school just](https://youtu.be/TIwmHGK29RY?t=01h12m37s)



[use writer ah yes I think that was](https://youtu.be/TIwmHGK29RY?t=01h12m42s)



[Cameron no that's the shocking part I](https://youtu.be/TIwmHGK29RY?t=01h12m46s)



[have a few co-workers who are very much](https://youtu.be/TIwmHGK29RY?t=01h12m50s)



[writer fans and I and I'm very tempted](https://youtu.be/TIwmHGK29RY?t=01h12m53s)



[to actually go that direction resharper](https://youtu.be/TIwmHGK29RY?t=01h12m57s)



[is slowly starting to feel really big](https://youtu.be/TIwmHGK29RY?t=01h12m59s)



[and bulky and I've got a machine that](https://youtu.be/TIwmHGK29RY?t=01h13m01s)



[can handle resharper and there are times](https://youtu.be/TIwmHGK29RY?t=01h13m04s)



[where just slow and it's not resource](https://youtu.be/TIwmHGK29RY?t=01h13m06s)



[limited Cameron yes there are dozens of](https://youtu.be/TIwmHGK29RY?t=01h13m10s)



[you writer users ok I've just pasted it](https://youtu.be/TIwmHGK29RY?t=01h13m16s)



[I don't know if this pace is going to](https://youtu.be/TIwmHGK29RY?t=01h13m19s)



[come through I just pasted the code](https://youtu.be/TIwmHGK29RY?t=01h13m21s)



[inside the chat window oh when it](https://youtu.be/TIwmHGK29RY?t=01h13m22s)



[generated it yeah oh thank you](https://youtu.be/TIwmHGK29RY?t=01h13m24s)



[so I'll go paste it up here alright so](https://youtu.be/TIwmHGK29RY?t=01h13m28s)



[it gende up something that looks like](https://youtu.be/TIwmHGK29RY?t=01h13m32s)



[this yeah that looks better so let's see](https://youtu.be/TIwmHGK29RY?t=01h13m35s)



[so it generates a boolean flag to know](https://youtu.be/TIwmHGK29RY?t=01h13m39s)



[if it's been disposed right because if](https://youtu.be/TIwmHGK29RY?t=01h13m41s)



[it's been disposed do nothing set it to](https://youtu.be/TIwmHGK29RY?t=01h13m46s)



[true right my if statements inverted but](https://youtu.be/TIwmHGK29RY?t=01h13m47s)



[ok sure it does generate the finalizer](https://youtu.be/TIwmHGK29RY?t=01h13m50s)



[right yeah so you'll note it very](https://youtu.be/TIwmHGK29RY?t=01h13m54s)



[explicitly it doesn't doesn't do is](https://youtu.be/TIwmHGK29RY?t=01h13m58s)



[register put process exit what's the](https://youtu.be/TIwmHGK29RY?t=01h14m01s)



[deal with that](https://youtu.be/TIwmHGK29RY?t=01h14m03s)



[come on well bear in mind I think we](https://youtu.be/TIwmHGK29RY?t=01h14m04s)



[only need to guarantee the process exit](https://youtu.be/TIwmHGK29RY?t=01h14m08s)



[in the managed case right or in the](https://youtu.be/TIwmHGK29RY?t=01h14m10s)



[unmanaged case and this is clearly](https://youtu.be/TIwmHGK29RY?t=01h14m16s)



[commented out because you only need it](https://youtu.be/TIwmHGK29RY?t=01h14m18s)



[for unmanaged resources](https://youtu.be/TIwmHGK29RY?t=01h14m21s)



[fair enough](https://youtu.be/TIwmHGK29RY?t=01h14m23s)



[yeah so and then tells you here here's](https://youtu.be/TIwmHGK29RY?t=01h14m30s)



[where you put the managed stuff here's](https://youtu.be/TIwmHGK29RY?t=01h14m33s)



[where you put the unmanaged stuff you](https://youtu.be/TIwmHGK29RY?t=01h14m35s)



[should know out large fields because](https://youtu.be/TIwmHGK29RY?t=01h14m37s)



[that is actually you know helpful right](https://youtu.be/TIwmHGK29RY?t=01h14m39s)



[like you were telling me to do it before](https://youtu.be/TIwmHGK29RY?t=01h14m42s)



[this to take you out of the finalizar](https://youtu.be/TIwmHGK29RY?t=01h14m44s)



[queue that the GC is gonna run on right](https://youtu.be/TIwmHGK29RY?t=01h14m47s)



[so but again only do this if the final](https://youtu.be/TIwmHGK29RY?t=01h14m50s)



[or finalize is overridden only override](https://youtu.be/TIwmHGK29RY?t=01h14m54s)



[the final answer if you have managed to](https://youtu.be/TIwmHGK29RY?t=01h14m56s)



[suppress finalizar and you don't have a](https://youtu.be/TIwmHGK29RY?t=01h14m58s)



[final answer](https://youtu.be/TIwmHGK29RY?t=01h15m00s)



[say again what if you call GC suppress](https://youtu.be/TIwmHGK29RY?t=01h15m00s)



[finalize you don't have a finalized er](https://youtu.be/TIwmHGK29RY?t=01h15m03s)



[that's a good question I imagine it's](https://youtu.be/TIwmHGK29RY?t=01h15m06s)



[just wasteful well sure but okay anyway](https://youtu.be/TIwmHGK29RY?t=01h15m09s)



[okay so worthwhile pattern anyway so](https://youtu.be/TIwmHGK29RY?t=01h15m16s)



[here we are we are may we have a](https://youtu.be/TIwmHGK29RY?t=01h15m20s)



[finalized this so we're making some](https://youtu.be/TIwmHGK29RY?t=01h15m23s)



[sweeping assumptions about what we have](https://youtu.be/TIwmHGK29RY?t=01h15m24s)



[but huzzah right so if we're disposing](https://youtu.be/TIwmHGK29RY?t=01h15m26s)



[we get rid of our managed stuff I don't](https://youtu.be/TIwmHGK29RY?t=01h15m30s)



[know console or I'm sorry right line](https://youtu.be/TIwmHGK29RY?t=01h15m33s)



[remove managed stuff right and then](https://youtu.be/TIwmHGK29RY?t=01h15m39s)



[right line remove unmanaged stuff boom](https://youtu.be/TIwmHGK29RY?t=01h15m45s)



[all right I think that's it right look](https://youtu.be/TIwmHGK29RY?t=01h15m58s)



[good to me let's see if it works](https://youtu.be/TIwmHGK29RY?t=01h16m03s)



[oh let's see let's see just so we](https://youtu.be/TIwmHGK29RY?t=01h16m13s)



[created a new thing finalized was](https://youtu.be/TIwmHGK29RY?t=01h16m17s)



[invoked disposed removed the unmanaged](https://youtu.be/TIwmHGK29RY?t=01h16m20s)



[stuff without removing the managed stuff](https://youtu.be/TIwmHGK29RY?t=01h16m25s)



[and then the week Ref was dead so GC is](https://youtu.be/TIwmHGK29RY?t=01h16m27s)



[turned on yeah and if we turn GC off we](https://youtu.be/TIwmHGK29RY?t=01h16m31s)



[should see the other side of that if so](https://youtu.be/TIwmHGK29RY?t=01h16m37s)



[constructor disposed got called remove](https://youtu.be/TIwmHGK29RY?t=01h16m43s)



[managed stuff remove unmanaged stuff](https://youtu.be/TIwmHGK29RY?t=01h16m47s)



[nice so I actually did properly clean it](https://youtu.be/TIwmHGK29RY?t=01h16m49s)



[up so you know you know it'd be](https://youtu.be/TIwmHGK29RY?t=01h16m55s)



[interesting is to instantiate it after](https://youtu.be/TIwmHGK29RY?t=01h17m03s)



[you call system dot collect because we](https://youtu.be/TIwmHGK29RY?t=01h17m05s)



[should be under then replicate this](https://youtu.be/TIwmHGK29RY?t=01h17m07s)



[whole thing without writing the process](https://youtu.be/TIwmHGK29RY?t=01h17m09s)



[twice so instantiate it once call GC](https://youtu.be/TIwmHGK29RY?t=01h17m10s)



[collect and then instantiate it again](https://youtu.be/TIwmHGK29RY?t=01h17m13s)



[and that we will only need one process](https://youtu.be/TIwmHGK29RY?t=01h17m15s)



[oh so I can hit both sides right yes I](https://youtu.be/TIwmHGK29RY?t=01h17m17s)



[don't think that works](https://youtu.be/TIwmHGK29RY?t=01h17m25s)



[looks good to me try that again so we](https://youtu.be/TIwmHGK29RY?t=01h17m34s)



[create thing we create thing right](https://youtu.be/TIwmHGK29RY?t=01h17m41s)



[finalizar gets invoked thing begone](https://youtu.be/TIwmHGK29RY?t=01h17m46s)



[right dispose remove and when did we](https://youtu.be/TIwmHGK29RY?t=01h17m49s)



[create two things do thing do thing okay](https://youtu.be/TIwmHGK29RY?t=01h17m54s)



[I'm just surprised that we didn't see](https://youtu.be/TIwmHGK29RY?t=01h18m01s)



[the finalized message before we created](https://youtu.be/TIwmHGK29RY?t=01h18m04s)



[the second thing yeah that's a good](https://youtu.be/TIwmHGK29RY?t=01h18m05s)



[point it now makes me go back to my](https://youtu.be/TIwmHGK29RY?t=01h18m11s)



[original statement GC collect is not a](https://youtu.be/TIwmHGK29RY?t=01h18m14s)



[command it's a request request just may](https://youtu.be/TIwmHGK29RY?t=01h18m16s)



[be denied yeah because that seems to](https://youtu.be/TIwmHGK29RY?t=01h18m19s)



[indicate I've clearly put something](https://youtu.be/TIwmHGK29RY?t=01h18m24s)



[there that's not there anymore and we](https://youtu.be/TIwmHGK29RY?t=01h18m26s)



[don't have a reference to it I know I](https://youtu.be/TIwmHGK29RY?t=01h18m29s)



[know I'm just trying to figure this out](https://youtu.be/TIwmHGK29RY?t=01h18m35s)



[I'm literally creating it up and](https://youtu.be/TIwmHGK29RY?t=01h18m37s)



[throwing it away right no I that's this](https://youtu.be/TIwmHGK29RY?t=01h18m38s)



[one](https://youtu.be/TIwmHGK29RY?t=01h18m41s)



[hence my point right I think this is](https://youtu.be/TIwmHGK29RY?t=01h18m41s)



[this is this is showing that the](https://youtu.be/TIwmHGK29RY?t=01h18m43s)



[documentation is wrong correct that is](https://youtu.be/TIwmHGK29RY?t=01h18m45s)



[correct and I think Keith seems to agree](https://youtu.be/TIwmHGK29RY?t=01h18m49s)



[that the this is the GC collect is a](https://youtu.be/TIwmHGK29RY?t=01h18m52s)



[request not a command garbage collector](https://youtu.be/TIwmHGK29RY?t=01h18m58s)



[gets to tell you nah not interested I'm](https://youtu.be/TIwmHGK29RY?t=01h19m02s)



[busy I'll come back later](https://youtu.be/TIwmHGK29RY?t=01h19m04s)



[no your rooms not that dirty I'm not](https://youtu.be/TIwmHGK29RY?t=01h19m06s)



[getting the vacuum out just because](https://youtu.be/TIwmHGK29RY?t=01h19m10s)



[you've got a little speck of dirt down](https://youtu.be/TIwmHGK29RY?t=01h19m11s)



[there is there anything we can do to](https://youtu.be/TIwmHGK29RY?t=01h19m13s)



[force it it worked before we just had](https://youtu.be/TIwmHGK29RY?t=01h19m14s)



[one object we don't know whit whit order](https://youtu.be/TIwmHGK29RY?t=01h19m16s)



[to do well the thing is we we forced it](https://youtu.be/TIwmHGK29RY?t=01h19m17s)



[before and then we dropped out of main](https://youtu.be/TIwmHGK29RY?t=01h19m20s)



[right so what if we write lines what do](https://youtu.be/TIwmHGK29RY?t=01h19m25s)



[people write lines before and after GC](https://youtu.be/TIwmHGK29RY?t=01h19m30s)



[collide](https://youtu.be/TIwmHGK29RY?t=01h19m32s)



[hang on real quick private static I can](https://youtu.be/TIwmHGK29RY?t=01h19m32s)



[type static](https://youtu.be/TIwmHGK29RY?t=01h19m38s)



[instance count right private int ID gets](https://youtu.be/TIwmHGK29RY?t=01h19m41s)



[interlocked increment ref instance count](https://youtu.be/TIwmHGK29RY?t=01h19m52s)



[why do you need to do that in locked](https://youtu.be/TIwmHGK29RY?t=01h19m59s)



[because I'm paranoid about threats never](https://youtu.be/TIwmHGK29RY?t=01h20m01s)



[you only go one you're paranoid GC GC](https://youtu.be/TIwmHGK29RY?t=01h20m05s)



[twit uh telling you I'm paranoid about](https://youtu.be/TIwmHGK29RY?t=01h20m08s)



[threats you know you you're not](https://youtu.be/TIwmHGK29RY?t=01h20m10s)



[instantiating anything on two different](https://youtu.be/TIwmHGK29RY?t=01h20m16s)



[threads the GC mean right at a different](https://youtu.be/TIwmHGK29RY?t=01h20m18s)



[rate but it's not going to change you](https://youtu.be/TIwmHGK29RY?t=01h20m20s)



[since counter you decrementing it's](https://youtu.be/TIwmHGK29RY?t=01h20m21s)



[discount uh-oh so GC wait for pending](https://youtu.be/TIwmHGK29RY?t=01h20m22s)



[finalize errs to wait haha](https://youtu.be/TIwmHGK29RY?t=01h20m27s)



[Thank You Keith](https://youtu.be/TIwmHGK29RY?t=01h20m30s)



[that is the second method yes and you](https://youtu.be/TIwmHGK29RY?t=01h20m35s)



[won thank you and then because Omni](https://youtu.be/TIwmHGK29RY?t=01h20m38s)



[sharp clearly can't figure it out it's a](https://youtu.be/TIwmHGK29RY?t=01h20m41s)



[system it's right there it's right there](https://youtu.be/TIwmHGK29RY?t=01h20m46s)



[okay let's try that now we theoretically](https://youtu.be/TIwmHGK29RY?t=01h20m48s)



[get the order that you expect yeah there](https://youtu.be/TIwmHGK29RY?t=01h20m52s)



[was a second method Hey look at that yes](https://youtu.be/TIwmHGK29RY?t=01h20m53s)



[thank you I knew there was a second one](https://youtu.be/TIwmHGK29RY?t=01h20m57s)



[I forgot about it thank you](https://youtu.be/TIwmHGK29RY?t=01h20m59s)



[yes so let's turn that off just to prove](https://youtu.be/TIwmHGK29RY?t=01h21m00s)



[a point yeah](https://youtu.be/TIwmHGK29RY?t=01h21m03s)



[and now we go now we got one process](https://youtu.be/TIwmHGK29RY?t=01h21m06s)



[that proves both issues so we don't need](https://youtu.be/TIwmHGK29RY?t=01h21m09s)



[to go ahead and run the process twice](https://youtu.be/TIwmHGK29RY?t=01h21m11s)



[which was a pain let's see is there a](https://youtu.be/TIwmHGK29RY?t=01h21m13s)



[way to globally trap when the GC collect](https://youtu.be/TIwmHGK29RY?t=01h21m16s)



[things or do you have to instrument all](https://youtu.be/TIwmHGK29RY?t=01h21m19s)



[disposed methods so in general I guess](https://youtu.be/TIwmHGK29RY?t=01h21m21s)



[that my question would be why do you](https://youtu.be/TIwmHGK29RY?t=01h21m25s)



[want to globally trap when the GC](https://youtu.be/TIwmHGK29RY?t=01h21m26s)



[collects things so there's a lot of like](https://youtu.be/TIwmHGK29RY?t=01h21m29s)



[performance and memory management tools](https://youtu.be/TIwmHGK29RY?t=01h21m32s)



[that that can tie into that level of](https://youtu.be/TIwmHGK29RY?t=01h21m33s)



[stuff those are fairly low-level api's](https://youtu.be/TIwmHGK29RY?t=01h21m36s)



[in general you you don't want to try and](https://youtu.be/TIwmHGK29RY?t=01h21m39s)



[control the GC the GC usually like the](https://youtu.be/TIwmHGK29RY?t=01h21m43s)



[garbage collector and net is probably](https://youtu.be/TIwmHGK29RY?t=01h21m48s)



[one of the things that has received some](https://youtu.be/TIwmHGK29RY?t=01h21m51s)



[of the most performance optimizations](https://youtu.be/TIwmHGK29RY?t=01h21m53s)



[over the years of the entire runtime](https://youtu.be/TIwmHGK29RY?t=01h21m55s)



[follow closely by system dot string you](https://youtu.be/TIwmHGK29RY?t=01h22m00s)



[can correct me if I'm wrong mark but at](https://youtu.be/TIwmHGK29RY?t=01h22m06s)



[least that would be my perception is](https://youtu.be/TIwmHGK29RY?t=01h22m08s)



[those are probably the areas where the](https://youtu.be/TIwmHGK29RY?t=01h22m09s)



[most time and energy has gone into](https://youtu.be/TIwmHGK29RY?t=01h22m11s)



[optimizing because at this point the](https://youtu.be/TIwmHGK29RY?t=01h22m13s)



[dotnet GC is ridiculously performant yes](https://youtu.be/TIwmHGK29RY?t=01h22m15s)



[I agree that okay so now we're back into](https://youtu.be/TIwmHGK29RY?t=01h22m20s)



[our our happy state where things run we](https://youtu.be/TIwmHGK29RY?t=01h22m24s)



[wait for pending finalize errs](https://youtu.be/TIwmHGK29RY?t=01h22m27s)



[everything works nicely](https://youtu.be/TIwmHGK29RY?t=01h22m29s)



[I think we're good I think we've proven](https://youtu.be/TIwmHGK29RY?t=01h22m33s)



[what we wanted to prove proven that](https://youtu.be/TIwmHGK29RY?t=01h22m35s)



[disposing sucks is there a way to do](https://youtu.be/TIwmHGK29RY?t=01h22m40s)



[this there's just no way to refactor out](https://youtu.be/TIwmHGK29RY?t=01h22m43s)



[disposes there so there's not could we](https://youtu.be/TIwmHGK29RY?t=01h22m46s)



[go create could we create either an](https://youtu.be/TIwmHGK29RY?t=01h22m51s)



[abstract cast or an abstract interface](https://youtu.be/TIwmHGK29RY?t=01h22m53s)



[you're gonna have to explain and create](https://youtu.be/TIwmHGK29RY?t=01h22m59s)



[an interface that does what that does](https://youtu.be/TIwmHGK29RY?t=01h23m01s)



[the dispose pattern Oh with like a](https://youtu.be/TIwmHGK29RY?t=01h23m05s)



[default interface implementation yeah](https://youtu.be/TIwmHGK29RY?t=01h23m09s)



[oh that's an interesting and creepily I](https://youtu.be/TIwmHGK29RY?t=01h23m12s)



[hate the idea but we're gonna do it](https://youtu.be/TIwmHGK29RY?t=01h23m20s)



[anyway](https://youtu.be/TIwmHGK29RY?t=01h23m22s)



[repeated because one I universally](https://youtu.be/TIwmHGK29RY?t=01h23m24s)



[disliked default interface members](https://youtu.be/TIwmHGK29RY?t=01h23m29s)



[because yuck I think this might be the](https://youtu.be/TIwmHGK29RY?t=01h23m31s)



[great example of why you wanted a](https://youtu.be/TIwmHGK29RY?t=01h23m44s)



[default interface member yeah sorry so](https://youtu.be/TIwmHGK29RY?t=01h23m46s)



[just answer the question finding things](https://youtu.be/TIwmHGK29RY?t=01h23m49s)



[that stay pinned I agree that you](https://youtu.be/TIwmHGK29RY?t=01h23m51s)



[shouldn't end up with too many objects](https://youtu.be/TIwmHGK29RY?t=01h23m52s)



[that need it and then the finding things](https://youtu.be/TIwmHGK29RY?t=01h23m55s)



[that stay pinned I would imagine that](https://youtu.be/TIwmHGK29RY?t=01h23m58s)



[you don't want to try to do something](https://youtu.be/TIwmHGK29RY?t=01h23m59s)



[like that at runtime that's what the](https://youtu.be/TIwmHGK29RY?t=01h24m01s)



[memory management debugging tools are](https://youtu.be/TIwmHGK29RY?t=01h24m02s)



[for so the performance tool inside of](https://youtu.be/TIwmHGK29RY?t=01h24m06s)



[Visual Studio red gates tool dot memory](https://youtu.be/TIwmHGK29RY?t=01h24m09s)



[etc all of those I would say are](https://youtu.be/TIwmHGK29RY?t=01h24m12s)



[probably better solutions if you're](https://youtu.be/TIwmHGK29RY?t=01h24m14s)



[wanting to track down the stuff that's](https://youtu.be/TIwmHGK29RY?t=01h24m16s)



[pinned where are you chatting on this](https://youtu.be/TIwmHGK29RY?t=01h24m17s)



[because I'm not seeing the chat what am](https://youtu.be/TIwmHGK29RY?t=01h24m19s)



[I missing](https://youtu.be/TIwmHGK29RY?t=01h24m20s)



[oh you on you're on Twitter sorry yes I](https://youtu.be/TIwmHGK29RY?t=01h24m21s)



[have a what I have an extra window that](https://youtu.be/TIwmHGK29RY?t=01h24m25s)



[you don't have but you can go to twitch](https://youtu.be/TIwmHGK29RY?t=01h24m26s)



[and see it yourself as well](https://youtu.be/TIwmHGK29RY?t=01h24m28s)



[I was so busy looking at the screen I](https://youtu.be/TIwmHGK29RY?t=01h24m33s)



[wasn't not gonna twitch](https://youtu.be/TIwmHGK29RY?t=01h24m36s)



[sorry that's why I just keep jumping in](https://youtu.be/TIwmHGK29RY?t=01h24m37s)



[on you every time designs and I tried to](https://youtu.be/TIwmHGK29RY?t=01h24m40s)



[pay attention every so often okay so we](https://youtu.be/TIwmHGK29RY?t=01h24m43s)



[can do a default interface yeah so I do](https://youtu.be/TIwmHGK29RY?t=01h24m45s)



[think it is it would be very important](https://youtu.be/TIwmHGK29RY?t=01h24m50s)



[to call out when I would expect that](https://youtu.be/TIwmHGK29RY?t=01h24m52s)



[this interface actually would get used](https://youtu.be/TIwmHGK29RY?t=01h24m54s)



[right but let me just be clear what's](https://youtu.be/TIwmHGK29RY?t=01h24m56s)



[gone why I'm looking to do this to](https://youtu.be/TIwmHGK29RY?t=01h25m00s)



[implement the dispose pattern there's](https://youtu.be/TIwmHGK29RY?t=01h25m02s)



[only one method that is custom and by](https://youtu.be/TIwmHGK29RY?t=01h25m04s)



[and by only one that's custom you're](https://youtu.be/TIwmHGK29RY?t=01h25m10s)



[referring to this this guy here right](https://youtu.be/TIwmHGK29RY?t=01h25m12s)



[correct](https://youtu.be/TIwmHGK29RY?t=01h25m14s)



[okay and in fact we could go ahead and](https://youtu.be/TIwmHGK29RY?t=01h25m15s)



[not and we could actually go ahead and](https://youtu.be/TIwmHGK29RY?t=01h25m19s)



[have abstract versions of dispose](https://youtu.be/TIwmHGK29RY?t=01h25m21s)



[unmanaged and disposed managed and then](https://youtu.be/TIwmHGK29RY?t=01h25m25s)



[we could actually implement dispose wait](https://youtu.be/TIwmHGK29RY?t=01h25m29s)



[what](https://youtu.be/TIwmHGK29RY?t=01h25m33s)



[oh I disposed manager I dispose](https://youtu.be/TIwmHGK29RY?t=01h25m34s)



[unmanaged yes and yeah so you could do](https://youtu.be/TIwmHGK29RY?t=01h25m36s)



[that and spread them or you could mark](https://youtu.be/TIwmHGK29RY?t=01h25m40s)



[him at this is gonna sound bizarre you](https://youtu.be/TIwmHGK29RY?t=01h25m42s)



[could mark him as protected because they](https://youtu.be/TIwmHGK29RY?t=01h25m43s)



[should never be called directly so](https://youtu.be/TIwmHGK29RY?t=01h25m45s)



[agreed so bear mine the other metric](https://youtu.be/TIwmHGK29RY?t=01h25m47s)



[that the disposed stuff generates for is](https://youtu.be/TIwmHGK29RY?t=01h25m52s)



[whether you expect to derive from the](https://youtu.be/TIwmHGK29RY?t=01h25m54s)



[class or not right yeah that's that's](https://youtu.be/TIwmHGK29RY?t=01h25m56s)



[that does those are the two those are](https://youtu.be/TIwmHGK29RY?t=01h25m59s)



[the two cases of how you end up with](https://youtu.be/TIwmHGK29RY?t=01h26m02s)



[four permutations of you know I do I](https://youtu.be/TIwmHGK29RY?t=01h26m03s)



[Drive or not or do I have unmanaged or](https://youtu.be/TIwmHGK29RY?t=01h26m06s)



[not so let's look at the case without](https://youtu.be/TIwmHGK29RY?t=01h26m08s)



[derivation and see if we can do it](https://youtu.be/TIwmHGK29RY?t=01h26m09s)



[further but I I just think that this is](https://youtu.be/TIwmHGK29RY?t=01h26m11s)



[should be possible to implement dispose](https://youtu.be/TIwmHGK29RY?t=01h26m13s)



[and this look at the non derived case to](https://youtu.be/TIwmHGK29RY?t=01h26m15s)



[start okay so I assume you're](https://youtu.be/TIwmHGK29RY?t=01h26m18s)



[anticipating something like this right](https://youtu.be/TIwmHGK29RY?t=01h26m21s)



[yes](https://youtu.be/TIwmHGK29RY?t=01h26m23s)



[okay so that goes there I'm apparently](https://youtu.be/TIwmHGK29RY?t=01h26m29s)



[quickly gonna become a meme and what are](https://youtu.be/TIwmHGK29RY?t=01h26m34s)



[we and to like we actually want to go to](https://youtu.be/TIwmHGK29RY?t=01h26m39s)



[want to implement dispose and dispose it](https://youtu.be/TIwmHGK29RY?t=01h26m41s)



[takes a boolean and you want to have as](https://youtu.be/TIwmHGK29RY?t=01h26m44s)



[check members for unmanaged clean up and](https://youtu.be/TIwmHGK29RY?t=01h26m46s)



[manage kena so what you're suggesting](https://youtu.be/TIwmHGK29RY?t=01h26m49s)



[then is well suppose M an aged all right](https://youtu.be/TIwmHGK29RY?t=01h26m55s)



[Lloyd dispose unmanaged so we'll deal](https://youtu.be/TIwmHGK29RY?t=01h27m04s)



[with protection levels later because](https://youtu.be/TIwmHGK29RY?t=01h27m12s)



[that's one thing I see that's different](https://youtu.be/TIwmHGK29RY?t=01h27m14s)



[about this right](https://youtu.be/TIwmHGK29RY?t=01h27m15s)



[right and then](https://youtu.be/TIwmHGK29RY?t=01h27m24s)



[attitude dude to do because there is no](https://youtu.be/TIwmHGK29RY?t=01h27m29s)



[way this is going to be a bad idea](https://youtu.be/TIwmHGK29RY?t=01h27m32s)



[I can't wait with this why is that](https://youtu.be/TIwmHGK29RY?t=01h27m38s)



[lowercase D say that again why is your](https://youtu.be/TIwmHGK29RY?t=01h27m40s)



[field begin with the lowercase because](https://youtu.be/TIwmHGK29RY?t=01h27m45s)



[I'm typing quickly just tell analyzers](https://youtu.be/TIwmHGK29RY?t=01h27m47s)



[just checking well you've got a whole](https://youtu.be/TIwmHGK29RY?t=01h27m51s)



[audience I think they qualify as](https://youtu.be/TIwmHGK29RY?t=01h27m53s)



[analyzers well based on the number of](https://youtu.be/TIwmHGK29RY?t=01h27m57s)



[stuff I've gotten away with tonight I](https://youtu.be/TIwmHGK29RY?t=01h27m59s)



[don't know if I would quite go that far](https://youtu.be/TIwmHGK29RY?t=01h28m01s)



[so we do it so first problem well hang](https://youtu.be/TIwmHGK29RY?t=01h28m02s)



[on you can do private fields yeah so so](https://youtu.be/TIwmHGK29RY?t=01h28m11s)



[Keith I would agree with you in general](https://youtu.be/TIwmHGK29RY?t=01h28m17s)



[for dotnet though I'm gonna post a link](https://youtu.be/TIwmHGK29RY?t=01h28m19s)



[real quick there is a long-standing](https://youtu.be/TIwmHGK29RY?t=01h28m22s)



[debate and you will find so the the](https://youtu.be/TIwmHGK29RY?t=01h28m25s)



[intelligent coding standards actually](https://youtu.be/TIwmHGK29RY?t=01h28m30s)



[invert that for Pascal case which is the](https://youtu.be/TIwmHGK29RY?t=01h28m31s)



[subtle inside joke that's being](https://youtu.be/TIwmHGK29RY?t=01h28m36s)



[referenced there let see is I can get](https://youtu.be/TIwmHGK29RY?t=01h28m37s)



[away with this can't I](https://youtu.be/TIwmHGK29RY?t=01h28m45s)



[[Music]](https://youtu.be/TIwmHGK29RY?t=01h28m48s)



[trying to remember how to do this I'm](https://youtu.be/TIwmHGK29RY?t=01h28m52s)



[not seeing your where your type oh there](https://youtu.be/TIwmHGK29RY?t=01h28m55s)



[it is](https://youtu.be/TIwmHGK29RY?t=01h28m57s)



[what are you trying to do I'm trying to](https://youtu.be/TIwmHGK29RY?t=01h28m57s)



[figure out how I can actually implement](https://youtu.be/TIwmHGK29RY?t=01h28m59s)



[this right because I want this level of](https://youtu.be/TIwmHGK29RY?t=01h29m01s)



[implementation right the problem is is](https://youtu.be/TIwmHGK29RY?t=01h29m03s)



[this requires state](https://youtu.be/TIwmHGK29RY?t=01h29m07s)



[hmm what if you did as an abstract](https://youtu.be/TIwmHGK29RY?t=01h29m15s)



[classes start and then we can change it](https://youtu.be/TIwmHGK29RY?t=01h29m17s)



[later so yeah that works but then you](https://youtu.be/TIwmHGK29RY?t=01h29m18s)



[come up with the other problems as well](https://youtu.be/TIwmHGK29RY?t=01h29m23s)



[with that right if you can't effectively](https://youtu.be/TIwmHGK29RY?t=01h29m25s)



[tack this on to something oh I agree I](https://youtu.be/TIwmHGK29RY?t=01h29m28s)



[said we can change it later let's make](https://youtu.be/TIwmHGK29RY?t=01h29m32s)



[it an abstract Casa started okay](https://youtu.be/TIwmHGK29RY?t=01h29m33s)



[fixing that name then something like](https://youtu.be/TIwmHGK29RY?t=01h29m41s)



[that something like that I'm just gonna](https://youtu.be/TIwmHGK29RY?t=01h29m46s)



[use this because boom ba-ba-boom alright](https://youtu.be/TIwmHGK29RY?t=01h29m49s)



[and then this becomes](https://youtu.be/TIwmHGK29RY?t=01h29m57s)



[all right so we're now protected](https://youtu.be/TIwmHGK29RY?t=01h30m04s)



[abstract C and I still can't spell yeah](https://youtu.be/TIwmHGK29RY?t=01h30m07s)



[Keith Intelli tech is who both mark and](https://youtu.be/TIwmHGK29RY?t=01h30m14s)



[I work for mark won't admit it but he's](https://youtu.be/TIwmHGK29RY?t=01h30m17s)



[the head honcho person you are just](https://youtu.be/TIwmHGK29RY?t=01h30m20s)



[trouble I was I was trying to work on my](https://youtu.be/TIwmHGK29RY?t=01h30m25s)



[way of having to apologize and get](https://youtu.be/TIwmHGK29RY?t=01h30m29s)



[forgiven a second time you got it you](https://youtu.be/TIwmHGK29RY?t=01h30m31s)



[gotta set these things up well in](https://youtu.be/TIwmHGK29RY?t=01h30m35s)



[advance okay just remember I know where](https://youtu.be/TIwmHGK29RY?t=01h30m37s)



[you work don't worry I'm not planning on](https://youtu.be/TIwmHGK29RY?t=01h30m42s)



[going into the office anytime soon I](https://youtu.be/TIwmHGK29RY?t=01h30m45s)



[don't know does that mean we're not](https://youtu.be/TIwmHGK29RY?t=01h30m49s)



[gonna get this thing lifted the heck](https://youtu.be/TIwmHGK29RY?t=01h30m51s)



[okay so something and akin to that right](https://youtu.be/TIwmHGK29RY?t=01h31m01s)



[no you can't make that private why oh](https://youtu.be/TIwmHGK29RY?t=01h31m09s)



[yeah he's gonna call it you should go](https://youtu.be/TIwmHGK29RY?t=01h31m12s)



[ahead public dispose right right](https://youtu.be/TIwmHGK29RY?t=01h31m15s)



[I always beaucoup the wrong one I agree](https://youtu.be/TIwmHGK29RY?t=01h31m17s)



[and I mean technically if I'm gonna keep](https://youtu.be/TIwmHGK29RY?t=01h31m18s)



[going like if this is gonna be an](https://youtu.be/TIwmHGK29RY?t=01h31m20s)



[abstract class all right I now can](https://youtu.be/TIwmHGK29RY?t=01h31m21s)



[actually get around to the other side](https://youtu.be/TIwmHGK29RY?t=01h31m25s)



[where I do dispose false does semicolons](https://youtu.be/TIwmHGK29RY?t=01h31m26s)



[are hard system GC suppress finalize](https://youtu.be/TIwmHGK29RY?t=01h31m32s)



[this right and heck if I'm an abstract](https://youtu.be/TIwmHGK29RY?t=01h31m38s)



[class I can keep going right so](https://youtu.be/TIwmHGK29RY?t=01h31m44s)



[protected clean up this register for](https://youtu.be/TIwmHGK29RY?t=01h31m47s)



[clean up right yes so on one hand now I](https://youtu.be/TIwmHGK29RY?t=01h31m54s)



[get really nice and I don't need any of](https://youtu.be/TIwmHGK29RY?t=01h32m03s)



[this](https://youtu.be/TIwmHGK29RY?t=01h32m10s)



[in fact I don't even need the shoes get](https://youtu.be/TIwmHGK29RY?t=01h32m15s)



[rid of with the extension method back up](https://youtu.be/TIwmHGK29RY?t=01h32m18s)



[there say again we can probably move](https://youtu.be/TIwmHGK29RY?t=01h32m20s)



[your extension method into there as well](https://youtu.be/TIwmHGK29RY?t=01h32m23s)



[yeah that would be well no you can't](https://youtu.be/TIwmHGK29RY?t=01h32m27s)



[because that would make it a static](https://youtu.be/TIwmHGK29RY?t=01h32m30s)



[class and not if you put it as a sub](https://youtu.be/TIwmHGK29RY?t=01h32m31s)



[cast or something like that nobody else](https://youtu.be/TIwmHGK29RY?t=01h32m34s)



[needs it anyway don't worry about it](https://youtu.be/TIwmHGK29RY?t=01h32m36s)



[it's fine](https://youtu.be/TIwmHGK29RY?t=01h32m38s)



[yes I think you run into is I think what](https://youtu.be/TIwmHGK29RY?t=01h32m38s)



[I'm gonna do though real quick just for](https://youtu.be/TIwmHGK29RY?t=01h32m42s)



[my own sanity bub pass was the wrong](https://youtu.be/TIwmHGK29RY?t=01h32m43s)



[word I meant nester cast but anyway](https://youtu.be/TIwmHGK29RY?t=01h32m45s)



[right because I want this I want this](https://youtu.be/TIwmHGK29RY?t=01h32m51s)



[and I want to do I kind of just want to](https://youtu.be/TIwmHGK29RY?t=01h32m55s)



[have write lines everywhere right](https://youtu.be/TIwmHGK29RY?t=01h32m59s)



[because I kind of just want to prove](https://youtu.be/TIwmHGK29RY?t=01h33m00s)



[where I'm at and](https://youtu.be/TIwmHGK29RY?t=01h33m03s)



[and yeah so now all this guy comes with](https://youtu.be/TIwmHGK29RY?t=01h33m14s)



[his implement abstract class and I'm](https://youtu.be/TIwmHGK29RY?t=01h33m20s)



[actually gonna expose this guy just so I](https://youtu.be/TIwmHGK29RY?t=01h33m26s)



[can abuse him a little bit further all](https://youtu.be/TIwmHGK29RY?t=01h33m29s)



[right](https://youtu.be/TIwmHGK29RY?t=01h33m34s)



[so paste paste figure out how to type](https://youtu.be/TIwmHGK29RY?t=01h33m34s)



[optional all right okay go do all the](https://youtu.be/TIwmHGK29RY?t=01h33m42s)



[things](https://youtu.be/TIwmHGK29RY?t=01h33m48s)



[wait do I hear a train in the background](https://youtu.be/TIwmHGK29RY?t=01h33m57s)



[you do hear a train in the background go](https://youtu.be/TIwmHGK29RY?t=01h34m01s)



[home I did not recognize that wall and I](https://youtu.be/TIwmHGK29RY?t=01h34m04s)



[probably should have okay](https://youtu.be/TIwmHGK29RY?t=01h34m11s)



[showers and beds here right it's true](https://youtu.be/TIwmHGK29RY?t=01h34m13s)



[actually beds probably a euphemism](https://youtu.be/TIwmHGK29RY?t=01h34m18s)



[hammock hammock is a better word yes so](https://youtu.be/TIwmHGK29RY?t=01h34m21s)



[constructor one was called finalized was](https://youtu.be/TIwmHGK29RY?t=01h34m26s)



[called disposed was called disposed](https://youtu.be/TIwmHGK29RY?t=01h34m29s)



[unmanaged was called kind of all makes](https://youtu.be/TIwmHGK29RY?t=01h34m32s)



[sense right](https://youtu.be/TIwmHGK29RY?t=01h34m36s)



[then constructor two was called week ref](https://youtu.be/TIwmHGK29RY?t=01h34m37s)



[was dead this is why we include the](https://youtu.be/TIwmHGK29RY?t=01h34m41s)



[method name so that that's right there](https://youtu.be/TIwmHGK29RY?t=01h34m45s)



[disposed to was called disposed to was](https://youtu.be/TIwmHGK29RY?t=01h34m55s)



[called twice](https://youtu.be/TIwmHGK29RY?t=01h34m57s)



[no it wasn't this is because I have a](https://youtu.be/TIwmHGK29RY?t=01h34m58s)



[right line here too all right](https://youtu.be/TIwmHGK29RY?t=01h35m04s)



[I don't really want that disposed](https://youtu.be/TIwmHGK29RY?t=01h35m08s)



[because one was called with the dispose](https://youtu.be/TIwmHGK29RY?t=01h35m13s)



[without the boolean then one was called](https://youtu.be/TIwmHGK29RY?t=01h35m15s)



[dispose with the boolean then managed](https://youtu.be/TIwmHGK29RY?t=01h35m17s)



[then unmanaged okay](https://youtu.be/TIwmHGK29RY?t=01h35m19s)



[are you watching chat now do I need a](https://youtu.be/TIwmHGK29RY?t=01h35m28s)



[foreword the jokes verbally I am now on](https://youtu.be/TIwmHGK29RY?t=01h35m31s)



[the thing excellent](https://youtu.be/TIwmHGK29RY?t=01h35m35s)



[who is that](https://youtu.be/TIwmHGK29RY?t=01h35m39s)



[okay so abstract base works right but it](https://youtu.be/TIwmHGK29RY?t=01h35m48s)



[has all of the problems of being an](https://youtu.be/TIwmHGK29RY?t=01h35m53s)



[abstract base class yeah so now we make](https://youtu.be/TIwmHGK29RY?t=01h35m54s)



[it an interface okay](https://youtu.be/TIwmHGK29RY?t=01h35m57s)



[I'm so here's the part where I think it](https://youtu.be/TIwmHGK29RY?t=01h36m00s)



[starts to quickly fall apart I'm gonna](https://youtu.be/TIwmHGK29RY?t=01h36m04s)



[leave the abstract class and I'm gonna](https://youtu.be/TIwmHGK29RY?t=01h36m05s)



[write the interface okay sure no I think](https://youtu.be/TIwmHGK29RY?t=01h36m07s)



[you should leave the abstract class I](https://youtu.be/TIwmHGK29RY?t=01h36m09s)



[clean up and you will also be i](https://youtu.be/TIwmHGK29RY?t=01h36m13s)



[disposable right in fact the way to do](https://youtu.be/TIwmHGK29RY?t=01h36m18s)



[this eventually would be to have both I](https://youtu.be/TIwmHGK29RY?t=01h36m21s)



[don't doubt that I'm just questioning if](https://youtu.be/TIwmHGK29RY?t=01h36m25s)



[we can actually get away with everything](https://youtu.be/TIwmHGK29RY?t=01h36m28s)



[in the interface right yep only you have](https://youtu.be/TIwmHGK29RY?t=01h36m29s)



[how many instance members just one right](https://youtu.be/TIwmHGK29RY?t=01h36m32s)



[how many on one field right I have a](https://youtu.be/TIwmHGK29RY?t=01h36m35s)



[single field but this one doesn't](https://youtu.be/TIwmHGK29RY?t=01h36m37s)



[technically well do we count this one](https://youtu.be/TIwmHGK29RY?t=01h36m40s)



[yeah that's the only one you have I](https://youtu.be/TIwmHGK29RY?t=01h36m44s)



[technically have this little ID thing](https://youtu.be/TIwmHGK29RY?t=01h36m47s)



[but that one's inconsequential that](https://youtu.be/TIwmHGK29RY?t=01h36m49s)



[one's just for output you didn't need](https://youtu.be/TIwmHGK29RY?t=01h36m51s)



[that then we don't need that on that bit](https://youtu.be/TIwmHGK29RY?t=01h36m53s)



[you know no this one we don't need this](https://youtu.be/TIwmHGK29RY?t=01h36m55s)



[is just so that Kevin could have nice](https://youtu.be/TIwmHGK29RY?t=01h36m57s)



[output so I think the only one you need](https://youtu.be/TIwmHGK29RY?t=01h36m59s)



[is is this about is that is disposed](https://youtu.be/TIwmHGK29RY?t=01h37m03s)



[right so here's the problem here's](https://youtu.be/TIwmHGK29RY?t=01h37m05s)



[problem number one I'm pretty sure I](https://youtu.be/TIwmHGK29RY?t=01h37m07s)



[can't get away with this](https://youtu.be/TIwmHGK29RY?t=01h37m11s)



[why not you just gotta implement in the](https://youtu.be/TIwmHGK29RY?t=01h37m12s)



[base class the derived class](https://youtu.be/TIwmHGK29RY?t=01h37m15s)



[that feels yucky but okay and I'm just](https://youtu.be/TIwmHGK29RY?t=01h37m21s)



[going to grab all of this then right you](https://youtu.be/TIwmHGK29RY?t=01h37m26s)



[can't have a final answer yeah that's](https://youtu.be/TIwmHGK29RY?t=01h37m30s)



[that's the other fun one right because I](https://youtu.be/TIwmHGK29RY?t=01h37m32s)



[mentioned a second ago that the](https://youtu.be/TIwmHGK29RY?t=01h37m36s)



[let's see so dispose we can actually](https://youtu.be/TIwmHGK29RY?t=01h37m45s)



[give a default implementation too right](https://youtu.be/TIwmHGK29RY?t=01h37m47s)



[yes let's see oh you couldn't you copied](https://youtu.be/TIwmHGK29RY?t=01h37m49s)



[that right you didn't yeah I copied it I](https://youtu.be/TIwmHGK29RY?t=01h37m56s)



[believe I have to do I send it like this](https://youtu.be/TIwmHGK29RY?t=01h37m58s)



[I have to do explicit implementation to](https://youtu.be/TIwmHGK29RY?t=01h38m02s)



[happen because why because if I do this](https://youtu.be/TIwmHGK29RY?t=01h38m06s)



[I'm hiding the base member and that's](https://youtu.be/TIwmHGK29RY?t=01h38m11s)



[not what I want how do you get around](https://youtu.be/TIwmHGK29RY?t=01h38m14s)



[that by doing an explicit implementation](https://youtu.be/TIwmHGK29RY?t=01h38m16s)



[right because now it knows how to](https://youtu.be/TIwmHGK29RY?t=01h38m20s)



[resolve this it knows that I'm](https://youtu.be/TIwmHGK29RY?t=01h38m22s)



[earnest in actually saying go to the](https://youtu.be/TIwmHGK29RY?t=01h38m24s)



[base I think makes sense](https://youtu.be/TIwmHGK29RY?t=01h38m26s)



[ish all right so this guy we said we](https://youtu.be/TIwmHGK29RY?t=01h38m29s)



[don't need me more this guy wait wait](https://youtu.be/TIwmHGK29RY?t=01h38m32s)



[when did you meet sorry I walked this](https://youtu.be/TIwmHGK29RY?t=01h38m36s)



[I'll move it down I had a second copy of](https://youtu.be/TIwmHGK29RY?t=01h38m40s)



[the problem okay that's what I was](https://youtu.be/TIwmHGK29RY?t=01h38m43s)



[checking you had a second copy you got](https://youtu.be/TIwmHGK29RY?t=01h38m45s)



[it yeah so we don't need the right line](https://youtu.be/TIwmHGK29RY?t=01h38m46s)



[that doesn't matter we do need these](https://youtu.be/TIwmHGK29RY?t=01h38m48s)



[let's see we cannot have a constructor](https://youtu.be/TIwmHGK29RY?t=01h38m53s)



[that is not a thing right and these](https://youtu.be/TIwmHGK29RY?t=01h38m59s)



[things no longer need to be bad right we](https://youtu.be/TIwmHGK29RY?t=01h39m03s)



[want the implementer of the interface to](https://youtu.be/TIwmHGK29RY?t=01h39m12s)



[get a disposed management is supposed to](https://youtu.be/TIwmHGK29RY?t=01h39m14s)



[unmanaged because I don't know what you](https://youtu.be/TIwmHGK29RY?t=01h39m16s)



[got do we want them to what did you have](https://youtu.be/TIwmHGK29RY?t=01h39m17s)



[them declared as before well they're](https://youtu.be/TIwmHGK29RY?t=01h39m22s)



[protected yeah they were a protected](https://youtu.be/TIwmHGK29RY?t=01h39m24s)



[abstract and that's the only other thing](https://youtu.be/TIwmHGK29RY?t=01h39m26s)



[I don't I'm not you sure you don't want](https://youtu.be/TIwmHGK29RY?t=01h39m28s)



[them again to be protected abstract](https://youtu.be/TIwmHGK29RY?t=01h39m30s)



[you can't use abstract on an interface](https://youtu.be/TIwmHGK29RY?t=01h39m36s)



[member you can use abstract on a](https://youtu.be/TIwmHGK29RY?t=01h39m39s)



[implement it there's what's the rule](https://youtu.be/TIwmHGK29RY?t=01h39m43s)



[oh my Guinness you I think it was](https://youtu.be/TIwmHGK29RY?t=01h39m45s)



[protected I think because you can you](https://youtu.be/TIwmHGK29RY?t=01h39m53s)



[can put a protection modifier if you're](https://youtu.be/TIwmHGK29RY?t=01h39m56s)



[gonna do a default implementation right](https://youtu.be/TIwmHGK29RY?t=01h39m58s)



[yeah that's but you can't if it not okay](https://youtu.be/TIwmHGK29RY?t=01h40m00s)



[fair enough](https://youtu.be/TIwmHGK29RY?t=01h40m02s)



[right yeah which makes it difficult well](https://youtu.be/TIwmHGK29RY?t=01h40m03s)



[in actual fact this is what we want](https://youtu.be/TIwmHGK29RY?t=01h40m10s)



[that's what we want to force people to](https://youtu.be/TIwmHGK29RY?t=01h40m12s)



[implement right I'm not I'm not a huge](https://youtu.be/TIwmHGK29RY?t=01h40m13s)



[fan of the API that effectively exposes](https://youtu.be/TIwmHGK29RY?t=01h40m16s)



[methods that somebody could](https://youtu.be/TIwmHGK29RY?t=01h40m18s)



[theoretically call but a yuck right](https://youtu.be/TIwmHGK29RY?t=01h40m19s)



[like somebody implements this interface](https://youtu.be/TIwmHGK29RY?t=01h40m24s)



[can you not declare those who's](https://youtu.be/TIwmHGK29RY?t=01h40m27s)



[protected please virtual but oh wait](https://youtu.be/TIwmHGK29RY?t=01h40m28s)



[Kevin why didn't you declare them as you](https://youtu.be/TIwmHGK29RY?t=01h40m34s)



[can do that so we're gonna test this so](https://youtu.be/TIwmHGK29RY?t=01h40m37s)



[I don't know I'm fairly confident you](https://youtu.be/TIwmHGK29RY?t=01h40m44s)



[can yeah so that's what my point is you](https://youtu.be/TIwmHGK29RY?t=01h40m48s)



[don't need to expose them it publicly](https://youtu.be/TIwmHGK29RY?t=01h40m51s)



[okay that makes me feel mildly better](https://youtu.be/TIwmHGK29RY?t=01h40m52s)



[because I would not want somebody to be](https://youtu.be/TIwmHGK29RY?t=01h40m55s)



[able to just get a hold of that is the](https://youtu.be/TIwmHGK29RY?t=01h40m57s)



[goal all right so maybe I mean I can do](https://youtu.be/TIwmHGK29RY?t=01h41m00s)



[this no you can't do that you can do it](https://youtu.be/TIwmHGK29RY?t=01h41m05s)



[protected but not private because it's](https://youtu.be/TIwmHGK29RY?t=01h41m10s)



[not marked as abstract external parcel](https://youtu.be/TIwmHGK29RY?t=01h41m14s)



[no you can't do a private property](https://youtu.be/TIwmHGK29RY?t=01h41m17s)



[because there's no there's no it doesn't](https://youtu.be/TIwmHGK29RY?t=01h41m19s)



[generate the property this is you](https://youtu.be/TIwmHGK29RY?t=01h41m20s)



[requiring the drive fast implemented](https://youtu.be/TIwmHGK29RY?t=01h41m22s)



[that's I know the implementation I want](https://youtu.be/TIwmHGK29RY?t=01h41m24s)



[an auto property I want I want to switch](https://youtu.be/TIwmHGK29RY?t=01h41m28s)



[there I go on off on](https://youtu.be/TIwmHGK29RY?t=01h41m31s)



[that's that to be protected](https://youtu.be/TIwmHGK29RY?t=01h41m33s)



[there you go well](https://youtu.be/TIwmHGK29RY?t=01h41m38s)



[really do other people call whether it's](https://youtu.be/TIwmHGK29RY?t=01h41m49s)



[disposed some actually can I get away](https://youtu.be/TIwmHGK29RY?t=01h41m51s)



[with that No](https://youtu.be/TIwmHGK29RY?t=01h41m52s)



[and abstract properties cannot have](https://youtu.be/TIwmHGK29RY?t=01h41m59s)



[private accessors feel like I want them](https://youtu.be/TIwmHGK29RY?t=01h42m01s)



[to know you don't you want to do no you](https://youtu.be/TIwmHGK29RY?t=01h42m04s)



[don't want to have data in the interface](https://youtu.be/TIwmHGK29RY?t=01h42m08s)



[I I realized that what I want is](https://youtu.be/TIwmHGK29RY?t=01h42m09s)



[multiple inheritance okay well you're](https://youtu.be/TIwmHGK29RY?t=01h42m16s)



[getting pretty close to multiple](https://youtu.be/TIwmHGK29RY?t=01h42m22s)



[inheritance with this interface and so](https://youtu.be/TIwmHGK29RY?t=01h42m23s)



[the last thing I would does that work](https://youtu.be/TIwmHGK29RY?t=01h42m25s)



[are we working so we are so we're in a](https://youtu.be/TIwmHGK29RY?t=01h42m27s)



[running state I believe at this point](https://youtu.be/TIwmHGK29RY?t=01h42m30s)



[but right so let's let this so we've got](https://youtu.be/TIwmHGK29RY?t=01h42m31s)



[thing right let's do because I'm gonna](https://youtu.be/TIwmHGK29RY?t=01h42m35s)



[keep my running joke going right](https://youtu.be/TIwmHGK29RY?t=01h42m40s)



[because I feel like I want to have a](https://youtu.be/TIwmHGK29RY?t=01h42m48s)



[compare and contrast moment yes and](https://youtu.be/TIwmHGK29RY?t=01h42m50s)



[eventually what I'd like to do is I'd](https://youtu.be/TIwmHGK29RY?t=01h42m54s)



[like to refactor clean up to implement I](https://youtu.be/TIwmHGK29RY?t=01h42m55s)



[cleaner I could understand that](https://youtu.be/TIwmHGK29RY?t=01h43m00s)



[huh](https://youtu.be/TIwmHGK29RY?t=01h43m17s)



[remind me to look that up this is why](https://youtu.be/TIwmHGK29RY?t=01h43m22s)



[default interface implementation suck](https://youtu.be/TIwmHGK29RY?t=01h43m26s)



[see that see that no I don't what's](https://youtu.be/TIwmHGK29RY?t=01h43m30s)



[wrong](https://youtu.be/TIwmHGK29RY?t=01h43m35s)



[protected set public set](https://youtu.be/TIwmHGK29RY?t=01h43m36s)



[I don't like protection modifiers in](https://youtu.be/TIwmHGK29RY?t=01h43m40s)



[interfaces they just do things wrong](https://youtu.be/TIwmHGK29RY?t=01h43m45s)



[wait sorry I didn't follow what you're](https://youtu.be/TIwmHGK29RY?t=01h43m47s)



[saying what was the problem](https://youtu.be/TIwmHGK29RY?t=01h43m50s)



[interface protect it's set I'm not](https://youtu.be/TIwmHGK29RY?t=01h43m51s)



[seeing something maybe your mouse is](https://youtu.be/TIwmHGK29RY?t=01h43m55s)



[behind or something okay](https://youtu.be/TIwmHGK29RY?t=01h43m56s)



[protect it's set right yeah public said](https://youtu.be/TIwmHGK29RY?t=01h43m59s)



[hmm right because technically that](https://youtu.be/TIwmHGK29RY?t=01h44m08s)



[implements the interface like I get why](https://youtu.be/TIwmHGK29RY?t=01h44m11s)



[it works it just makes me unhappy okay](https://youtu.be/TIwmHGK29RY?t=01h44m16s)



[so the other thing then that this guy](https://youtu.be/TIwmHGK29RY?t=01h44m22s)



[has to be able to do right is](https://youtu.be/TIwmHGK29RY?t=01h44m25s)



[hypothetically he now needs to know that](https://youtu.be/TIwmHGK29RY?t=01h44m27s)



[if I implement the interface I need to](https://youtu.be/TIwmHGK29RY?t=01h44m30s)



[clean up right so I need to call dispose](https://youtu.be/TIwmHGK29RY?t=01h44m36s)



[which apparently might need to indicate](https://youtu.be/TIwmHGK29RY?t=01h44m41s)



[a problem right is I've already got a](https://youtu.be/TIwmHGK29RY?t=01h44m44s)



[protection problem here and then GC](https://youtu.be/TIwmHGK29RY?t=01h44m47s)



[suppress finalize this and](https://youtu.be/TIwmHGK29RY?t=01h44m51s)



[we'll make omni sharp happy is disposed](https://youtu.be/TIwmHGK29RY?t=01h44m58s)



[marked as protected in the base class in](https://youtu.be/TIwmHGK29RY?t=01h45m02s)



[the interface](https://youtu.be/TIwmHGK29RY?t=01h45m04s)



[why can't you pull this goes there no](https://youtu.be/TIwmHGK29RY?t=01h45m08s)



[you don't want to do that you want to](https://youtu.be/TIwmHGK29RY?t=01h45m12s)



[make it public though I'm sorry I want](https://youtu.be/TIwmHGK29RY?t=01h45m15s)



[to do what the dispose method oh this is](https://youtu.be/TIwmHGK29RY?t=01h45m18s)



[the one that takes up Olivia yeah](https://youtu.be/TIwmHGK29RY?t=01h45m25s)



[because the because the finalizer now](https://youtu.be/TIwmHGK29RY?t=01h45m28s)



[needs to invoke it right](https://youtu.be/TIwmHGK29RY?t=01h45m30s)



[ideally passing a false I can't just](https://youtu.be/TIwmHGK29RY?t=01h45m33s)



[call into the public one okay so you're](https://youtu.be/TIwmHGK29RY?t=01h45m35s)



[gonna have a problem yeah if you marked](https://youtu.be/TIwmHGK29RY?t=01h45m39s)



[it as protected I don't thinking of okay](https://youtu.be/TIwmHGK29RY?t=01h45m40s)



[I I don't disagree largely because the](https://youtu.be/TIwmHGK29RY?t=01h45m42s)



[compiler tells me so yeah this is one of](https://youtu.be/TIwmHGK29RY?t=01h45m52s)



[the weirdest not most non-intuitive](https://youtu.be/TIwmHGK29RY?t=01h45m55s)



[things about protected you can declare](https://youtu.be/TIwmHGK29RY?t=01h45m58s)



[it a method but you can't invoke it so](https://youtu.be/TIwmHGK29RY?t=01h46m00s)



[just want to make sure that it wouldn't](https://youtu.be/TIwmHGK29RY?t=01h46m03s)



[who's seen this as what's going on so](https://youtu.be/TIwmHGK29RY?t=01h46m04s)



[inside your thing to you have declared a](https://youtu.be/TIwmHGK29RY?t=01h46m06s)



[disposed method I guess you didn't but](https://youtu.be/TIwmHGK29RY?t=01h46m13s)



[you can't invoke it right I can't I](https://youtu.be/TIwmHGK29RY?t=01h46m18s)



[can't get to the protecting of the the](https://youtu.be/TIwmHGK29RY?t=01h46m20s)



[protected member on my interface right](https://youtu.be/TIwmHGK29RY?t=01h46m22s)



[and in fact if you over if you override](https://youtu.be/TIwmHGK29RY?t=01h46m25s)



[it inside thing to you override dispose](https://youtu.be/TIwmHGK29RY?t=01h46m28s)



[you still can't call it that's exciting](https://youtu.be/TIwmHGK29RY?t=01h46m32s)



[protection modifiers are awesome on](https://youtu.be/TIwmHGK29RY?t=01h46m36s)



[interfaces it's worth demonstrating this](https://youtu.be/TIwmHGK29RY?t=01h46m39s)



[this is this is why when I was asked](https://youtu.be/TIwmHGK29RY?t=01h46m42s)



[about default interface members](https://youtu.be/TIwmHGK29RY?t=01h46m45s)



[yesterday my answer was don't use them](https://youtu.be/TIwmHGK29RY?t=01h46m47s)



[yesterday yes I was having fun with](https://youtu.be/TIwmHGK29RY?t=01h46m50s)



[coding standard stuff oh I get it](https://youtu.be/TIwmHGK29RY?t=01h46m55s)



[and we don't want to is there way to do](https://youtu.be/TIwmHGK29RY?t=01h47m00s)



[this I don't think he I don't think you](https://youtu.be/TIwmHGK29RY?t=01h47m04s)



[can get a reasonable implementation just](https://youtu.be/TIwmHGK29RY?t=01h47m07s)



[abusing an interface hold on I'm not is](https://youtu.be/TIwmHGK29RY?t=01h47m10s)



[the only issue we have that we can't](https://youtu.be/TIwmHGK29RY?t=01h47m17s)



[call this pose we can do it there my](https://youtu.be/TIwmHGK29RY?t=01h47m18s)



[screens frozen what am I saying don't](https://youtu.be/TIwmHGK29RY?t=01h47m31s)



[you worry don't you worry there is new](https://youtu.be/TIwmHGK29RY?t=01h47m33s)



[hotness that dropped I'm trying to see](https://youtu.be/TIwmHGK29RY?t=01h47m38s)



[if there's a dark mode and I don't see](https://youtu.be/TIwmHGK29RY?t=01h47m42s)



[it I'm sure there's probably hiding](https://youtu.be/TIwmHGK29RY?t=01h47m44s)



[around here see or.net five-o preview](https://youtu.be/TIwmHGK29RY?t=01h47m46s)



[that drop this week has source](https://youtu.be/TIwmHGK29RY?t=01h47m50s)



[generators you aren't smiling source](https://youtu.be/TIwmHGK29RY?t=01h47m52s)



[generators are supposed to make you do](https://youtu.be/TIwmHGK29RY?t=01h48m00s)



[this you're just trying to get up having](https://youtu.be/TIwmHGK29RY?t=01h48m01s)



[to write I out I it's so beautiful](https://youtu.be/TIwmHGK29RY?t=01h48m05s)



[before you do this Kevin I want to see](https://youtu.be/TIwmHGK29RY?t=01h48m10s)



[if we can do without this oh I don't](https://youtu.be/TIwmHGK29RY?t=01h48m12s)



[think I don't think I'm gonna pull it](https://youtu.be/TIwmHGK29RY?t=01h48m14s)



[tonight because I stopped to download it](https://youtu.be/TIwmHGK29RY?t=01h48m16s)



[I don't know it's 10:00 to 11:00 so](https://youtu.be/TIwmHGK29RY?t=01h48m17s)



[there's only one issue right and the](https://youtu.be/TIwmHGK29RY?t=01h48m22s)



[only issue we have is that we can't cool](https://youtu.be/TIwmHGK29RY?t=01h48m24s)



[this pose is that correct](https://youtu.be/TIwmHGK29RY?t=01h48m26s)



[so I have the issue of I can't get](https://youtu.be/TIwmHGK29RY?t=01h48m27s)



[access to my dispose I don't like this](https://youtu.be/TIwmHGK29RY?t=01h48m30s)



[bully and having to be declared like](https://youtu.be/TIwmHGK29RY?t=01h48m33s)



[this but I could I could live with it it](https://youtu.be/TIwmHGK29RY?t=01h48m35s)



[would make me unhappy](https://youtu.be/TIwmHGK29RY?t=01h48m38s)



[ya know that you're gonna do that this](https://youtu.be/TIwmHGK29RY?t=01h48m39s)



[is just this is just a weird thing right](https://youtu.be/TIwmHGK29RY?t=01h48m42s)



[because I agree thank you the other](https://youtu.be/TIwmHGK29RY?t=01h48m45s)



[thing that it doesn't give me is it](https://youtu.be/TIwmHGK29RY?t=01h48m49s)



[doesn't give me the auto register in the](https://youtu.be/TIwmHGK29RY?t=01h48m51s)



[constructor like this guy gave me right](https://youtu.be/TIwmHGK29RY?t=01h48m53s)



[no I understand but what I'm basically](https://youtu.be/TIwmHGK29RY?t=01h48m55s)



[want to get to is if this works and you](https://youtu.be/TIwmHGK29RY?t=01h48m58s)



[get your peanut passed to implement the](https://youtu.be/TIwmHGK29RY?t=01h49m00s)



[interface then the user has either](https://youtu.be/TIwmHGK29RY?t=01h49m02s)



[choice so if we can solve the dispose](https://youtu.be/TIwmHGK29RY?t=01h49m04s)



[method here essentially the whole](https://youtu.be/TIwmHGK29RY?t=01h49m09s)



[problem we've got a good solution](https://youtu.be/TIwmHGK29RY?t=01h49m11s)



[because you can either derive from](https://youtu.be/TIwmHGK29RY?t=01h49m12s)



[clean up or implement I clean up](https://youtu.be/TIwmHGK29RY?t=01h49m16s)



[correct so the only problem that we need](https://youtu.be/TIwmHGK29RY?t=01h49m24s)



[to solve is how do you call dispose and](https://youtu.be/TIwmHGK29RY?t=01h49m27s)



[Kelly you are absolutely correct I've](https://youtu.be/TIwmHGK29RY?t=01h49m31s)



[already been looking at ways of making](https://youtu.be/TIwmHGK29RY?t=01h49m34s)



[them awesome if Mark hadn't messaged me](https://youtu.be/TIwmHGK29RY?t=01h49m35s)



[that there will probably be a stream](https://youtu.be/TIwmHGK29RY?t=01h49m39s)



[where it's all about me just wanting to](https://youtu.be/TIwmHGK29RY?t=01h49m41s)



[play with source generators because they](https://youtu.be/TIwmHGK29RY?t=01h49m44s)



[look really cool so as far as actually](https://youtu.be/TIwmHGK29RY?t=01h49m47s)



[being able to invoke this though right](https://youtu.be/TIwmHGK29RY?t=01h49m54s)



[like you can there's a way to do it I](https://youtu.be/TIwmHGK29RY?t=01h49m56s)



[just want to make sure that's the only](https://youtu.be/TIwmHGK29RY?t=01h49m58s)



[problem before we solve it okay so so I](https://youtu.be/TIwmHGK29RY?t=01h49m59s)



[don't doubt that we can make it so that](https://youtu.be/TIwmHGK29RY?t=01h50m05s)



[we can invoke it my only fear is I I](https://youtu.be/TIwmHGK29RY?t=01h50m07s)



[would not want to expose it such that](https://youtu.be/TIwmHGK29RY?t=01h50m10s)



[someone outside of me could call it](https://youtu.be/TIwmHGK29RY?t=01h50m12s)



[right okay because that would if someone](https://youtu.be/TIwmHGK29RY?t=01h50m14s)



[not me is able to call dispose and pass](https://youtu.be/TIwmHGK29RY?t=01h50m20s)



[a boolean from outside that seems very](https://youtu.be/TIwmHGK29RY?t=01h50m22s)



[very bad okay I think that's fair there](https://youtu.be/TIwmHGK29RY?t=01h50m27s)



[any other issues besides this law](https://youtu.be/TIwmHGK29RY?t=01h50m31s)



[these guys have the same protection](https://youtu.be/TIwmHGK29RY?t=01h50m39s)



[level problem but that I think is again](https://youtu.be/TIwmHGK29RY?t=01h50m41s)



[but those are probably what's what's the](https://youtu.be/TIwmHGK29RY?t=01h50m46s)



[issue with those they're not public sure](https://youtu.be/TIwmHGK29RY?t=01h50m48s)



[they are seen to gets new thing too](https://youtu.be/TIwmHGK29RY?t=01h50m50s)



[right oh I get it you're saying their](https://youtu.be/TIwmHGK29RY?t=01h50m57s)



[interface to public yeah so I I clean up](https://youtu.be/TIwmHGK29RY?t=01h50m59s)



[I got it I got it yeah and then Oh hold](https://youtu.be/TIwmHGK29RY?t=01h51m02s)



[the phone no they aren't](https://youtu.be/TIwmHGK29RY?t=01h51m09s)



[oh because what what do you do caramels](https://youtu.be/TIwmHGK29RY?t=01h51m12s)



[I got a look at the declaration](https://youtu.be/TIwmHGK29RY?t=01h51m18s)



[protected yeah perfect](https://youtu.be/TIwmHGK29RY?t=01h51m19s)



[so they aren't they aren't actually](https://youtu.be/TIwmHGK29RY?t=01h51m22s)



[exposed okay so those the so ignore that](https://youtu.be/TIwmHGK29RY?t=01h51m24s)



[I just want to confirm that this guy](https://youtu.be/TIwmHGK29RY?t=01h51m26s)



[squawks at me for the same reason right](https://youtu.be/TIwmHGK29RY?t=01h51m28s)



[is inaccessible due to its protection](https://youtu.be/TIwmHGK29RY?t=01h51m30s)



[level okay finally something that](https://youtu.be/TIwmHGK29RY?t=01h51m32s)



[behaves the way I would hope okay so](https://youtu.be/TIwmHGK29RY?t=01h51m36s)



[we're back to the thing there's only one](https://youtu.be/TIwmHGK29RY?t=01h51m40s)



[thing that is not not reasonable right](https://youtu.be/TIwmHGK29RY?t=01h51m42s)



[yes well one thing that doesn't work](https://youtu.be/TIwmHGK29RY?t=01h51m45s)



[whether doing this is reasonable I think](https://youtu.be/TIwmHGK29RY?t=01h51m47s)



[is a different discussion I don't know](https://youtu.be/TIwmHGK29RY?t=01h51m50s)



[if you look at that instead of code](https://youtu.be/TIwmHGK29RY?t=01h51m52s)



[first of all look at thing one that's](https://youtu.be/TIwmHGK29RY?t=01h51m55s)



[pretty good for this opposed pattern yes](https://youtu.be/TIwmHGK29RY?t=01h51m57s)



[it's very it is very clean I might even](https://youtu.be/TIwmHGK29RY?t=01h52m04s)



[go as far as to say I'm rather than](https://youtu.be/TIwmHGK29RY?t=01h52m08s)



[making this one abstract I might even go](https://youtu.be/TIwmHGK29RY?t=01h52m12s)



[as far as to making this virtual yeah an](https://youtu.be/TIwmHGK29RY?t=01h52m14s)



[empty body yeah maybe because I feel](https://youtu.be/TIwmHGK29RY?t=01h52m18s)



[like the unmanaged reference case is](https://youtu.be/TIwmHGK29RY?t=01h52m22s)



[occur significantly less than the](https://youtu.be/TIwmHGK29RY?t=01h52m25s)



[managed case yeah no that's fair but](https://youtu.be/TIwmHGK29RY?t=01h52m27s)



[what I'm saying is like from now on I](https://youtu.be/TIwmHGK29RY?t=01h52m30s)



[would feel comfortable always using that](https://youtu.be/TIwmHGK29RY?t=01h52m33s)



[class yes when possible right I think](https://youtu.be/TIwmHGK29RY?t=01h52m35s)



[I'd probably call it disposable rather](https://youtu.be/TIwmHGK29RY?t=01h52m40s)



[than clean up but yes fair I was just](https://youtu.be/TIwmHGK29RY?t=01h52m42s)



[trying to differentiate my name's so I](https://youtu.be/TIwmHGK29RY?t=01h52m45s)



[agree I know I'm but I'm trying to say](https://youtu.be/TIwmHGK29RY?t=01h52m47s)



[is there Nate you all we making an API](https://youtu.be/TIwmHGK29RY?t=01h52m49s)



[here that would be reason](https://youtu.be/TIwmHGK29RY?t=01h52m51s)



[and so far I think the answer is yes if](https://youtu.be/TIwmHGK29RY?t=01h52m52s)



[you wanted to use up you want to know](https://youtu.be/TIwmHGK29RY?t=01h52m55s)



[any inheritance this is a reasonable](https://youtu.be/TIwmHGK29RY?t=01h52m57s)



[approach and I think and I would agree](https://youtu.be/TIwmHGK29RY?t=01h52m59s)



[because I think there's a lot of classes](https://youtu.be/TIwmHGK29RY?t=01h53m01s)



[where I have gone through and](https://youtu.be/TIwmHGK29RY?t=01h53m02s)



[implemented the I disposable pattern as](https://youtu.be/TIwmHGK29RY?t=01h53m04s)



[an abstract base for that exact reason](https://youtu.be/TIwmHGK29RY?t=01h53m06s)



[right yeah is I want I wanted an easy](https://youtu.be/TIwmHGK29RY?t=01h53m09s)



[way to implement dispose and I was tired](https://youtu.be/TIwmHGK29RY?t=01h53m12s)



[of all the boilerplate even with elegant](https://youtu.be/TIwmHGK29RY?t=01h53m13s)



[so now let's go to your dispose method](https://youtu.be/TIwmHGK29RY?t=01h53m17s)



[how's that declared so it's protected](https://youtu.be/TIwmHGK29RY?t=01h53m19s)



[right and it's an interface level Oh](https://youtu.be/TIwmHGK29RY?t=01h53m21s)



[protect it at the interface level](https://youtu.be/TIwmHGK29RY?t=01h53m23s)



[correct how do we make it so you can](https://youtu.be/TIwmHGK29RY?t=01h53m25s)



[invoke that guy I'm open to suggestions](https://youtu.be/TIwmHGK29RY?t=01h53m33s)



[okay so the the worst one is you can do](https://youtu.be/TIwmHGK29RY?t=01h53m40s)



[it my goodness that's not going to do it](https://youtu.be/TIwmHGK29RY?t=01h53m46s)



[so the one thing to know I don't this is](https://youtu.be/TIwmHGK29RY?t=01h53m49s)



[going to help us but the interface can](https://youtu.be/TIwmHGK29RY?t=01h53m52s)



[call it so you can't call dispose but](https://youtu.be/TIwmHGK29RY?t=01h53m54s)



[the interface can call this pose right](https://youtu.be/TIwmHGK29RY?t=01h53m59s)



[clearly because it's being done right](https://youtu.be/TIwmHGK29RY?t=01h54m01s)



[here right right well I just want to](https://youtu.be/TIwmHGK29RY?t=01h54m03s)



[point it out because you know that you](https://youtu.be/TIwmHGK29RY?t=01h54m06s)



[want to know how to get it to invoke so](https://youtu.be/TIwmHGK29RY?t=01h54m07s)



[can we define a method like an interface](https://youtu.be/TIwmHGK29RY?t=01h54m09s)



[method that could invoke it so I think](https://youtu.be/TIwmHGK29RY?t=01h54m13s)



[the answer is yes but by doing so](https://youtu.be/TIwmHGK29RY?t=01h54m20s)



[doesn't that mean it's available outside](https://youtu.be/TIwmHGK29RY?t=01h54m22s)



[right doesn't that expose us to the same](https://youtu.be/TIwmHGK29RY?t=01h54m24s)



[protection problem I guess is my point](https://youtu.be/TIwmHGK29RY?t=01h54m30s)



[I'm trying to define a protected method](https://youtu.be/TIwmHGK29RY?t=01h54m37s)



[that I can invoke no if you what if it](https://youtu.be/TIwmHGK29RY?t=01h54m39s)



[was what if you have a virtual method](https://youtu.be/TIwmHGK29RY?t=01h54m49s)



[you could / you could call you can't](https://youtu.be/TIwmHGK29RY?t=01h54m51s)



[call base right](https://youtu.be/TIwmHGK29RY?t=01h54m53s)



[you cannot Co base they base goes up](https://youtu.be/TIwmHGK29RY?t=01h54m54s)



[your object hierarchy not in the](https://youtu.be/TIwmHGK29RY?t=01h54m57s)



[interfaces right and it seems like we're](https://youtu.be/TIwmHGK29RY?t=01h54m59s)



[so close](https://youtu.be/TIwmHGK29RY?t=01h55m03s)



[interfaces thou art evil oh I don't](https://youtu.be/TIwmHGK29RY?t=01h55m10s)



[think you want to say that you certainly](https://youtu.be/TIwmHGK29RY?t=01h55m15s)



[don't want to go and record saying that](https://youtu.be/TIwmHGK29RY?t=01h55m16s)



[it's a good point must edit video add](https://youtu.be/TIwmHGK29RY?t=01h55m19s)



[that to my list yeah no I definitely](https://youtu.be/TIwmHGK29RY?t=01h55m22s)



[don't think you want to go on record](https://youtu.be/TIwmHGK29RY?t=01h55m26s)



[saying that interface is like evil oh my](https://youtu.be/TIwmHGK29RY?t=01h55m27s)



[goodness that would be bad](https://youtu.be/TIwmHGK29RY?t=01h55m29s)



[okay so while mark thinks on that for a](https://youtu.be/TIwmHGK29RY?t=01h55m30s)



[moment I have a question for people in](https://youtu.be/TIwmHGK29RY?t=01h55m32s)



[chat would people use a base class like](https://youtu.be/TIwmHGK29RY?t=01h55m34s)



[this or an interface like this assuming](https://youtu.be/TIwmHGK29RY?t=01h55m37s)



[that it was working that would be my](https://youtu.be/TIwmHGK29RY?t=01h55m39s)



[question because I know I would](https://youtu.be/TIwmHGK29RY?t=01h55m43s)



[theoretically use it in place of my you](https://youtu.be/TIwmHGK29RY?t=01h55m45s)



[know disposable object but what I do in](https://youtu.be/TIwmHGK29RY?t=01h55m48s)



[my projects I don't think is fair to say](https://youtu.be/TIwmHGK29RY?t=01h55m52s)



[is common Kelly I don't know what s](https://youtu.be/TIwmHGK29RY?t=01h55m54s)



[means is that sure or don't come near me](https://youtu.be/TIwmHGK29RY?t=01h56m01s)



[with a ten-foot pole yeah so interface](https://youtu.be/TIwmHGK29RY?t=01h56m08s)



[maybe base class now I'm guessing you're](https://youtu.be/TIwmHGK29RY?t=01h56m12s)



[watching](https://youtu.be/TIwmHGK29RY?t=01h56m16s)



[I I still think I would use whichever](https://youtu.be/TIwmHGK29RY?t=01h56m21s)



[one I could I would use the base class](https://youtu.be/TIwmHGK29RY?t=01h56m25s)



[whenever I could but if I couldn't then](https://youtu.be/TIwmHGK29RY?t=01h56m26s)



[I would go ahead and use the interface](https://youtu.be/TIwmHGK29RY?t=01h56m28s)



[and remember you're not gonna have a](https://youtu.be/TIwmHGK29RY?t=01h56m29s)



[versioning compatible change if you](https://youtu.be/TIwmHGK29RY?t=01h56m31s)



[change your mind rule so you could](https://youtu.be/TIwmHGK29RY?t=01h56m32s)



[actually go ahead and derive from peanut](https://youtu.be/TIwmHGK29RY?t=01h56m38s)



[and then it's some future point you](https://youtu.be/TIwmHGK29RY?t=01h56m40s)



[actually needed to do the you need to do](https://youtu.be/TIwmHGK29RY?t=01h56m42s)



[inheritance back you could switch and it](https://youtu.be/TIwmHGK29RY?t=01h56m45s)



[would not be a breaking the face](https://youtu.be/TIwmHGK29RY?t=01h56m47s)



[breaking change an API breaking change](https://youtu.be/TIwmHGK29RY?t=01h56m49s)



[I'm curious now how do you call it](https://youtu.be/TIwmHGK29RY?t=01h56m53s)



[detected interface so this is the other](https://youtu.be/TIwmHGK29RY?t=01h56m59s)



[interesting one right](https://youtu.be/TIwmHGK29RY?t=01h57m04s)



[by the way I'm sure people have told you](https://youtu.be/TIwmHGK29RY?t=01h57m11s)



[this but watching your twitch stream](https://youtu.be/TIwmHGK29RY?t=01h57m13s)



[with your face and hearing your voice is](https://youtu.be/TIwmHGK29RY?t=01h57m15s)



[very challenging because your faith is](https://youtu.be/TIwmHGK29RY?t=01h57m17s)



[like ten seconds behind not for me see](https://youtu.be/TIwmHGK29RY?t=01h57m23s)



[the other thing that's that I don't know](https://youtu.be/TIwmHGK29RY?t=01h57m34s)



[if it makes me very happy is if somebody](https://youtu.be/TIwmHGK29RY?t=01h57m36s)



[were to go through and say implement the](https://youtu.be/TIwmHGK29RY?t=01h57m40s)



[dispose over load right because they](https://youtu.be/TIwmHGK29RY?t=01h57m43s)



[want to do their own thing for whatever](https://youtu.be/TIwmHGK29RY?t=01h57m46s)



[reason right they don't they can't](https://youtu.be/TIwmHGK29RY?t=01h57m49s)



[actually make random in it it's not](https://youtu.be/TIwmHGK29RY?t=01h57m51s)



[retro](https://youtu.be/TIwmHGK29RY?t=01h57m55s)



[this guy doesn't get called from here](https://youtu.be/TIwmHGK29RY?t=01h58m02s)



[you can't override it](https://youtu.be/TIwmHGK29RY?t=01h58m06s)



[can you get away with that](https://youtu.be/TIwmHGK29RY?t=01h58m18s)



[what what do you think so well so the](https://youtu.be/TIwmHGK29RY?t=01h58m21s)



[the beauty of the default implemented](https://youtu.be/TIwmHGK29RY?t=01h58m25s)



[members right is that in theory if](https://youtu.be/TIwmHGK29RY?t=01h58m28s)



[somebody doesn't like your](https://youtu.be/TIwmHGK29RY?t=01h58m30s)



[implementation they can put their own in](https://youtu.be/TIwmHGK29RY?t=01h58m31s)



[its place you but you don't want them](https://youtu.be/TIwmHGK29RY?t=01h58m33s)



[doing that in this case I don't disagree](https://youtu.be/TIwmHGK29RY?t=01h58m38s)



[that I don't want them to but they can](https://youtu.be/TIwmHGK29RY?t=01h58m40s)



[right no can't they can't do this one](https://youtu.be/TIwmHGK29RY?t=01h58m43s)



[but they can do this crap alright like I](https://youtu.be/TIwmHGK29RY?t=01h58m47s)



[may not be able to do this but I](https://youtu.be/TIwmHGK29RY?t=01h58m53s)



[certainly so what if you so what if you](https://youtu.be/TIwmHGK29RY?t=01h58m54s)



[did do what we're suggesting what did](https://youtu.be/TIwmHGK29RY?t=01h58m58s)



[you actually went ahead and declare it](https://youtu.be/TIwmHGK29RY?t=01h58m59s)



[as new](https://youtu.be/TIwmHGK29RY?t=01h59m01s)



[like this yeah how does that get around](https://youtu.be/TIwmHGK29RY?t=01h59m09s)



[the fact that I can still hijack it you](https://youtu.be/TIwmHGK29RY?t=01h59m14s)



[can you no longer call it except through](https://youtu.be/TIwmHGK29RY?t=01h59m17s)



[the interface you can no longer call it](https://youtu.be/TIwmHGK29RY?t=01h59m19s)



[except through the interface](https://youtu.be/TIwmHGK29RY?t=01h59m22s)



[sorry you can't change it it's not](https://youtu.be/TIwmHGK29RY?t=01h59m24s)



[ritual new drops the virtual yes it's a](https://youtu.be/TIwmHGK29RY?t=01h59m26s)



[whole new method so there is a way to do](https://youtu.be/TIwmHGK29RY?t=01h59m34s)



[it just to be clear you could go ahead](https://youtu.be/TIwmHGK29RY?t=01h59m39s)



[and implement I disposable right right](https://youtu.be/TIwmHGK29RY?t=01h59m41s)



[and explicitly say bypass this one go to](https://youtu.be/TIwmHGK29RY?t=01h59m44s)



[the base right so what you're saying is](https://youtu.be/TIwmHGK29RY?t=01h59m48s)



[it's because that's private](https://youtu.be/TIwmHGK29RY?t=01h59m53s)



[right that's still a thing no you can't](https://youtu.be/TIwmHGK29RY?t=01h59m56s)



[do that](https://youtu.be/TIwmHGK29RY?t=02h00m02s)



[oh yeah and the interface yeah if you do](https://youtu.be/TIwmHGK29RY?t=02h00m02s)



[explicit implements the interface that's](https://youtu.be/TIwmHGK29RY?t=02h00m06s)



[exactly right](https://youtu.be/TIwmHGK29RY?t=02h00m07s)



[yeah I can I can bypass the new and say](https://youtu.be/TIwmHGK29RY?t=02h00m08s)



[yeah and go straight underneath you know](https://youtu.be/TIwmHGK29RY?t=02h00m10s)



[I but I think again that this scene](https://youtu.be/TIwmHGK29RY?t=02h00m15s)



[still seems to me this is you have to](https://youtu.be/TIwmHGK29RY?t=02h00m17s)



[know a heck of a lot no matter what and](https://youtu.be/TIwmHGK29RY?t=02h00m19s)



[we have made how much you have to know](https://youtu.be/TIwmHGK29RY?t=02h00m21s)



[way simpler to the point that you would](https://youtu.be/TIwmHGK29RY?t=02h00m25s)



[actually have to know a lot to be or](https://youtu.be/TIwmHGK29RY?t=02h00m27s)



[break this](https://youtu.be/TIwmHGK29RY?t=02h00m29s)



[I almost so I like the extension method](https://youtu.be/TIwmHGK29RY?t=02h00m34s)



[that we wrote right like this makes me](https://youtu.be/TIwmHGK29RY?t=02h00m40s)



[happy](https://youtu.be/TIwmHGK29RY?t=02h00m43s)



[because this gives me a nice generic way](https://youtu.be/TIwmHGK29RY?t=02h00m45s)



[of going through and making sure like if](https://youtu.be/TIwmHGK29RY?t=02h00m48s)



[I if I really really really want to make](https://youtu.be/TIwmHGK29RY?t=02h00m50s)



[sure that my dispose gets called because](https://youtu.be/TIwmHGK29RY?t=02h00m52s)



[I've got something that matters right I](https://youtu.be/TIwmHGK29RY?t=02h00m54s)



[think you can do protected static I got](https://youtu.be/TIwmHGK29RY?t=02h01m00s)



[a question could we use extension](https://youtu.be/TIwmHGK29RY?t=02h01m04s)



[methods to invoke disposed extension](https://youtu.be/TIwmHGK29RY?t=02h01m06s)



[message stated you're going to have to](https://youtu.be/TIwmHGK29RY?t=02h01m09s)



[explain I'm not sure I follow](https://youtu.be/TIwmHGK29RY?t=02h01m14s)



[could we write it an extension method on](https://youtu.be/TIwmHGK29RY?t=02h01m15s)



[that takes a I clean up well it wouldn't](https://youtu.be/TIwmHGK29RY?t=02h01m20s)



[have to be public and Nestle is on a](https://youtu.be/TIwmHGK29RY?t=02h01m31s)



[nested class what I'm trying to do is](https://youtu.be/TIwmHGK29RY?t=02h01m34s)



[allow disposable to figure out a way to](https://youtu.be/TIwmHGK29RY?t=02h01m38s)



[for disposable to cold dispose in the](https://youtu.be/TIwmHGK29RY?t=02h01m41s)



[constructor now sorry your thing to to](https://youtu.be/TIwmHGK29RY?t=02h01m43s)



[call disposed inside the constructor](https://youtu.be/TIwmHGK29RY?t=02h01m49s)



[sorry Keith has an interesting idea here](https://youtu.be/TIwmHGK29RY?t=02h01m53s)



[I'm curious](https://youtu.be/TIwmHGK29RY?t=02h01m56s)



[and Kelly has a horrible idea that's an](https://youtu.be/TIwmHGK29RY?t=02h02m03s)



[interesting idea](https://youtu.be/TIwmHGK29RY?t=02h02m10s)



[because then from here right right you](https://youtu.be/TIwmHGK29RY?t=02h02m18s)



[can invoke it](https://youtu.be/TIwmHGK29RY?t=02h02m24s)



[yeah CIO but why take a thing you don't](https://youtu.be/TIwmHGK29RY?t=02h02m27s)



[want to be thing you want to have yeah](https://youtu.be/TIwmHGK29RY?t=02h02m33s)



[there you go](https://youtu.be/TIwmHGK29RY?t=02h02m35s)



[yeah so you do thing and just right yeah](https://youtu.be/TIwmHGK29RY?t=02h02m36s)



[that was my point of making that a an](https://youtu.be/TIwmHGK29RY?t=02h02m40s)



[extension method but I agree it doesn't](https://youtu.be/TIwmHGK29RY?t=02h02m42s)



[need to be an extension ugly](https://youtu.be/TIwmHGK29RY?t=02h02m44s)



[oh I I know why too big the expansion](https://youtu.be/TIwmHGK29RY?t=02h02m45s)



[method because then the brace class can](https://youtu.be/TIwmHGK29RY?t=02h02m47s)



[just call it the drive faster](https://youtu.be/TIwmHGK29RY?t=02h02m49s)



[it's an interesting idea can you call](https://youtu.be/TIwmHGK29RY?t=02h03m04s)



[this Bo's now can you try it what](https://youtu.be/TIwmHGK29RY?t=02h03m08s)



[happens I call this new static one you](https://youtu.be/TIwmHGK29RY?t=02h03m09s)



[mean from thing - can you call this pose](https://youtu.be/TIwmHGK29RY?t=02h03m12s)



[yeah](https://youtu.be/TIwmHGK29RY?t=02h03m14s)



[what's the warning name dispose does not](https://youtu.be/TIwmHGK29RY?t=02h03m23s)



[exist in current context let me let me](https://youtu.be/TIwmHGK29RY?t=02h03m27s)



[clean up a couple small things here real](https://youtu.be/TIwmHGK29RY?t=02h03m31s)



[quick that I just to make sure we aren't](https://youtu.be/TIwmHGK29RY?t=02h03m33s)



[getting bit by something else what is my](https://youtu.be/TIwmHGK29RY?t=02h03m36s)



[disposable dispose](https://youtu.be/TIwmHGK29RY?t=02h03m45s)



[I clean up disposed](https://youtu.be/TIwmHGK29RY?t=02h03m56s)



[and get at it that way that's a clever](https://youtu.be/TIwmHGK29RY?t=02h04m09s)



[way around it but you made an extension](https://youtu.be/TIwmHGK29RY?t=02h04m12s)



[method then you wouldn't have to preface](https://youtu.be/TIwmHGK29RY?t=02h04m15s)



[it with I clean up](https://youtu.be/TIwmHGK29RY?t=02h04m20s)



[I don't know if you can do that though](https://youtu.be/TIwmHGK29RY?t=02h04m27s)



[because once you make an extension](https://youtu.be/TIwmHGK29RY?t=02h04m31s)



[method you're in a static class and then](https://youtu.be/TIwmHGK29RY?t=02h04m33s)



[you won't be able to touch the protected](https://youtu.be/TIwmHGK29RY?t=02h04m35s)



[member you can if you put it as a nested](https://youtu.be/TIwmHGK29RY?t=02h04m36s)



[class](https://youtu.be/TIwmHGK29RY?t=02h04m39s)



[are you seriously proposing it go here](https://youtu.be/TIwmHGK29RY?t=02h04m44s)



[yeah well seriously is that pushing](https://youtu.be/TIwmHGK29RY?t=02h04m49s)



[seriously would be pushing it I'm not](https://youtu.be/TIwmHGK29RY?t=02h04m53s)



[sure the word seriously is right in this](https://youtu.be/TIwmHGK29RY?t=02h04m54s)



[context](https://youtu.be/TIwmHGK29RY?t=02h04m56s)



[I for some reason in the back of my head](https://youtu.be/TIwmHGK29RY?t=02h05m08s)



[it's telling some time reminds me of](https://youtu.be/TIwmHGK29RY?t=02h05m11s)



[that extension methods can't be in](https://youtu.be/TIwmHGK29RY?t=02h05m13s)



[nested ones yeah](https://youtu.be/TIwmHGK29RY?t=02h05m14s)



[extension methods must be declared in](https://youtu.be/TIwmHGK29RY?t=02h05m17s)



[top-level static class well that's dumb](https://youtu.be/TIwmHGK29RY?t=02h05m19s)



[why would they do that restriction yeah](https://youtu.be/TIwmHGK29RY?t=02h05m21s)



[because I've tried to do that before to](https://youtu.be/TIwmHGK29RY?t=02h05m24s)



[get to get away with it and you can't](https://youtu.be/TIwmHGK29RY?t=02h05m25s)



[you can't do two wacky of things with](https://youtu.be/TIwmHGK29RY?t=02h05m29s)



[the extension methods which is usually](https://youtu.be/TIwmHGK29RY?t=02h05m32s)



[okay right because you're not trying to](https://youtu.be/TIwmHGK29RY?t=02h05m35s)



[hide them this feel horrible to me right](https://youtu.be/TIwmHGK29RY?t=02h05m37s)



[like hold a hold on one second can you](https://youtu.be/TIwmHGK29RY?t=02h05m44s)



[go back to your disposal fermentation](https://youtu.be/TIwmHGK29RY?t=02h05m46s)



[the static one what if we did it what if](https://youtu.be/TIwmHGK29RY?t=02h05m50s)



[he made that instance rather than static](https://youtu.be/TIwmHGK29RY?t=02h05m54s)



[and we didn't call it disposed](https://youtu.be/TIwmHGK29RY?t=02h05m56s)



[so](https://youtu.be/TIwmHGK29RY?t=02h06m08s)



[I'm not entirely sure how to do this but](https://youtu.be/TIwmHGK29RY?t=02h06m14s)



[my gut says something like that you](https://youtu.be/TIwmHGK29RY?t=02h06m17s)



[saying you can't cool this pose you](https://youtu.be/TIwmHGK29RY?t=02h06m23s)



[could not call it without the Pripet](https://youtu.be/TIwmHGK29RY?t=02h06m25s)



[without the fully-qualified gonna strip](https://youtu.be/TIwmHGK29RY?t=02h06m26s)



[yeah you can't delete I - you can't](https://youtu.be/TIwmHGK29RY?t=02h06m34s)



[delete the this there right is that true](https://youtu.be/TIwmHGK29RY?t=02h06m38s)



[correct because it's protected yeah that](https://youtu.be/TIwmHGK29RY?t=02h06m40s)



[restriction I have not it's been](https://youtu.be/TIwmHGK29RY?t=02h06m46s)



[baffling for me for a long time why did](https://youtu.be/TIwmHGK29RY?t=02h06m48s)



[they make it impossible to call a](https://youtu.be/TIwmHGK29RY?t=02h06m51s)



[protected member because the people who](https://youtu.be/TIwmHGK29RY?t=02h06m53s)



[put implement implemented protected](https://youtu.be/TIwmHGK29RY?t=02h06m55s)



[members on their interfaces are crazy](https://youtu.be/TIwmHGK29RY?t=02h06m59s)



[just like you don't care this is not an](https://youtu.be/TIwmHGK29RY?t=02h07m02s)



[implemented this is not why that's how](https://youtu.be/TIwmHGK29RY?t=02h07m05s)



[our abstract classes work normally right](https://youtu.be/TIwmHGK29RY?t=02h07m09s)



[and and this is why I don't like default](https://youtu.be/TIwmHGK29RY?t=02h07m11s)



[interface members is the protection](https://youtu.be/TIwmHGK29RY?t=02h07m14s)



[levels on them are true I I completely](https://youtu.be/TIwmHGK29RY?t=02h07m16s)



[agree but I want to try to forget us why](https://youtu.be/TIwmHGK29RY?t=02h07m20s)



[did Microsoft make it so protected](https://youtu.be/TIwmHGK29RY?t=02h07m23s)



[members could not be invoked](https://youtu.be/TIwmHGK29RY?t=02h07m26s)



[well they they're not so it's not just](https://youtu.be/TIwmHGK29RY?t=02h07m28s)



[protected so because I will point out](https://youtu.be/TIwmHGK29RY?t=02h07m31s)



[that right](https://youtu.be/TIwmHGK29RY?t=02h07m33s)



[this is protected yeah yeah yeah I agree](https://youtu.be/TIwmHGK29RY?t=02h07m36s)



[yes protected instance members](https://youtu.be/TIwmHGK29RY?t=02h07m40s)



[something back my mind says that there's](https://youtu.be/TIwmHGK29RY?t=02h07m48s)



[some sort of conflict with that right of](https://youtu.be/TIwmHGK29RY?t=02h07m50s)



[how do you do your method resolution at](https://youtu.be/TIwmHGK29RY?t=02h07m54s)



[that point](https://youtu.be/TIwmHGK29RY?t=02h07m57s)



[Jarrid would be a good one to ask on](https://youtu.be/TIwmHGK29RY?t=02h08m02s)



[this](https://youtu.be/TIwmHGK29RY?t=02h08m04s)



[okay yeah okay still not the interface](https://youtu.be/TIwmHGK29RY?t=02h08m10s)



[is nice but it still requires a lot of](https://youtu.be/TIwmHGK29RY?t=02h08m19s)



[effort I think the class is the way to](https://youtu.be/TIwmHGK29RY?t=02h08m23s)



[go whenever you can I I don't doubt that](https://youtu.be/TIwmHGK29RY?t=02h08m26s)



[the class is the is by far the cleaner](https://youtu.be/TIwmHGK29RY?t=02h08m28s)



[option right it just has the problems of](https://youtu.be/TIwmHGK29RY?t=02h08m31s)



[the naps track based class which I'm not](https://youtu.be/TIwmHGK29RY?t=02h08m34s)



[which means it's not usable everywhere](https://youtu.be/TIwmHGK29RY?t=02h08m36s)



[you know I often I don't control my](https://youtu.be/TIwmHGK29RY?t=02h08m40s)



[hires be serious the number of times you](https://youtu.be/TIwmHGK29RY?t=02h08m43s)



[have classes that derive from other](https://youtu.be/TIwmHGK29RY?t=02h08m46s)



[classes and do cleanup is not that](https://youtu.be/TIwmHGK29RY?t=02h08m48s)



[comment](https://youtu.be/TIwmHGK29RY?t=02h08m50s)



[how many enumerables do you write I](https://youtu.be/TIwmHGK29RY?t=02h08m51s)



[think that's my most common use case](https://youtu.be/TIwmHGK29RY?t=02h08m57s)



[right is so you'd write an ienumerable](https://youtu.be/TIwmHGK29RY?t=02h09m00s)



[disposable right and I and in that case](https://youtu.be/TIwmHGK29RY?t=02h09m05s)



[I can still derive from this I guess so](https://youtu.be/TIwmHGK29RY?t=02h09m10s)



[that works that's a bad example](https://youtu.be/TIwmHGK29RY?t=02h09m14s)



[I just think it's fairly rare that I'm](https://youtu.be/TIwmHGK29RY?t=02h09m20s)



[writing a class hierarchy for something](https://youtu.be/TIwmHGK29RY?t=02h09m23s)



[that is disposable and that's the](https://youtu.be/TIwmHGK29RY?t=02h09m27s)



[purpose of doing it is to provide](https://youtu.be/TIwmHGK29RY?t=02h09m30s)



[disposability](https://youtu.be/TIwmHGK29RY?t=02h09m31s)



[so I write base classes that is](https://youtu.be/TIwmHGK29RY?t=02h09m39s)



[disposable when the purpose of doing it](https://youtu.be/TIwmHGK29RY?t=02h09m41s)



[is to be disposable in this case we've](https://youtu.be/TIwmHGK29RY?t=02h09m42s)



[provided that class that is true and the](https://youtu.be/TIwmHGK29RY?t=02h09m44s)



[other thing I would do here is I'd](https://youtu.be/TIwmHGK29RY?t=02h09m54s)



[probably go ahead I think I'd still](https://youtu.be/TIwmHGK29RY?t=02h09m55s)



[refactor my ID refactor my clean up](https://youtu.be/TIwmHGK29RY?t=02h09m57s)



[class which i think is not called](https://youtu.be/TIwmHGK29RY?t=02h10m01s)



[disposable no it's it's still clean up](https://youtu.be/TIwmHGK29RY?t=02h10m03s)



[right to make it I clean up okay no no I](https://youtu.be/TIwmHGK29RY?t=02h10m06s)



[was gonna yes exactly right so that guy](https://youtu.be/TIwmHGK29RY?t=02h10m09s)



[goes like that what are you wanting to](https://youtu.be/TIwmHGK29RY?t=02h10m13s)



[implement Oh yuck](https://youtu.be/TIwmHGK29RY?t=02h10m17s)



[oh this bullying is uglier than all](https://youtu.be/TIwmHGK29RY?t=02h10m27s)



[get-out](https://youtu.be/TIwmHGK29RY?t=02h10m30s)



[not a fan not a fan what are you still](https://youtu.be/TIwmHGK29RY?t=02h10m41s)



[unhappy about I dispose set cannot be](https://youtu.be/TIwmHGK29RY?t=02h10m45s)



[implicitly implemented in a non-public](https://youtu.be/TIwmHGK29RY?t=02h10m52s)



[member again yok just gonna say that](https://youtu.be/TIwmHGK29RY?t=02h10m54s)



[gonna be protected it technically the](https://youtu.be/TIwmHGK29RY?t=02h11m05s)



[setter is protected you just can't tell](https://youtu.be/TIwmHGK29RY?t=02h11m10s)



[that means this guy goes away](https://youtu.be/TIwmHGK29RY?t=02h11m16s)



[constructor stays there the disposed](https://youtu.be/TIwmHGK29RY?t=02h11m24s)



[implementation goes away this guy stays](https://youtu.be/TIwmHGK29RY?t=02h11m30s)



[here I am realizing we could kind of get](https://youtu.be/TIwmHGK29RY?t=02h11m35s)



[away with not needing the GC suppress](https://youtu.be/TIwmHGK29RY?t=02h11m39s)



[finalize right like theoretically we](https://youtu.be/TIwmHGK29RY?t=02h11m44s)



[could move that inside nope that's not](https://youtu.be/TIwmHGK29RY?t=02h11m46s)



[the copy button alright so in theory we](https://youtu.be/TIwmHGK29RY?t=02h11m53s)



[could move this inside of this guy be](https://youtu.be/TIwmHGK29RY?t=02h11m57s)



[done with it](https://youtu.be/TIwmHGK29RY?t=02h12m00s)



[alright I think I'm gonna do that just](https://youtu.be/TIwmHGK29RY?t=02h12m07s)



[so that just so my derive class no](https://youtu.be/TIwmHGK29RY?t=02h12m09s)



[longer needs to do unmanaged when it](https://youtu.be/TIwmHGK29RY?t=02h12m13s)



[doesn't care about it](https://youtu.be/TIwmHGK29RY?t=02h12m14s)



[let's see disposed managed yuck](https://youtu.be/TIwmHGK29RY?t=02h12m20s)



[see](https://youtu.be/TIwmHGK29RY?t=02h12m28s)



[so now we have a problem](https://youtu.be/TIwmHGK29RY?t=02h12m33s)



[your problem is you're supposed to you](https://youtu.be/TIwmHGK29RY?t=02h12m43s)



[have to implement those is the kind](https://youtu.be/TIwmHGK29RY?t=02h12m44s)



[abstract it is and I mean there's no](https://youtu.be/TIwmHGK29RY?t=02h12m46s)



[reason I can't just forward over right](https://youtu.be/TIwmHGK29RY?t=02h12m50s)



[like just leave them](https://youtu.be/TIwmHGK29RY?t=02h12m52s)



[like that like this works it makes me](https://youtu.be/TIwmHGK29RY?t=02h13m00s)



[feel dirty](https://youtu.be/TIwmHGK29RY?t=02h13m04s)



[well I can't you just delete it entirely](https://youtu.be/TIwmHGK29RY?t=02h13m07s)



[because default interface members are](https://youtu.be/TIwmHGK29RY?t=02h13m11s)



[down right yeah cuz the implementing the](https://youtu.be/TIwmHGK29RY?t=02h13m13s)



[interface yeah again nobody sees that](https://youtu.be/TIwmHGK29RY?t=02h13m21s)



[code you don't care I kind of care you](https://youtu.be/TIwmHGK29RY?t=02h13m29s)



[don't suck why has it forced me to](https://youtu.be/TIwmHGK29RY?t=02h13m32s)



[implement this one that shouldn't be](https://youtu.be/TIwmHGK29RY?t=02h13m38s)



[required right because that one actually](https://youtu.be/TIwmHGK29RY?t=02h13m41s)



[does exist](https://youtu.be/TIwmHGK29RY?t=02h13m43s)



[can I get away with this No](https://youtu.be/TIwmHGK29RY?t=02h13m49s)



[because those ones difference between](https://youtu.be/TIwmHGK29RY?t=02h13m55s)



[because you said you have to mute the](https://youtu.be/TIwmHGK29RY?t=02h14m00s)



[interface because yeah because the](https://youtu.be/TIwmHGK29RY?t=02h14m02s)



[dispose one has an implementation these](https://youtu.be/TIwmHGK29RY?t=02h14m04s)



[ones don't right](https://youtu.be/TIwmHGK29RY?t=02h14m06s)



[that's totally gets reasonable I don't](https://youtu.be/TIwmHGK29RY?t=02h14m08s)



[think yeah I think you're totally fine](https://youtu.be/TIwmHGK29RY?t=02h14m09s)



[with it except now in implementing](https://youtu.be/TIwmHGK29RY?t=02h14m10s)



[classes do they do they know does the](https://youtu.be/TIwmHGK29RY?t=02h14m14s)



[person implementing deriving from this](https://youtu.be/TIwmHGK29RY?t=02h14m18s)



[caste know that they have to be](https://youtu.be/TIwmHGK29RY?t=02h14m20s)



[uncommitted know that they have to do](https://youtu.be/TIwmHGK29RY?t=02h14m21s)



[this yes if you delete one of those stop](https://youtu.be/TIwmHGK29RY?t=02h14m27s)



[comparing well yeah I mean well let me](https://youtu.be/TIwmHGK29RY?t=02h14m30s)



[rephrase](https://youtu.be/TIwmHGK29RY?t=02h14m33s)



[it'll squawk it at one of them right](https://youtu.be/TIwmHGK29RY?t=02h14m34s)



[it'll require that you implement the](https://youtu.be/TIwmHGK29RY?t=02h14m36s)



[manage side because that's what we want](https://youtu.be/TIwmHGK29RY?t=02h14m40s)



[it that's good yeah so that's that's the](https://youtu.be/TIwmHGK29RY?t=02h14m45s)



[bare minimum you can get away with now](https://youtu.be/TIwmHGK29RY?t=02h14m47s)



[right that seems pretty good compared to](https://youtu.be/TIwmHGK29RY?t=02h14m49s)



[what we had and again the the abstract](https://youtu.be/TIwmHGK29RY?t=02h14m51s)



[base works and works well but it has the](https://youtu.be/TIwmHGK29RY?t=02h14m56s)



[problems of an abstract base that is](https://youtu.be/TIwmHGK29RY?t=02h15m01s)



[still way better than what we had before](https://youtu.be/TIwmHGK29RY?t=02h15m05s)



[yeah I think I need to use it I'm on the](https://youtu.be/TIwmHGK29RY?t=02h15m14s)



[fence](https://youtu.be/TIwmHGK29RY?t=02h15m16s)



[I promise you know the other thing that](https://youtu.be/TIwmHGK29RY?t=02h15m21s)



[I'm that I'm still considering right is](https://youtu.be/TIwmHGK29RY?t=02h15m23s)



[if I need to have something that I'm](https://youtu.be/TIwmHGK29RY?t=02h15m25s)



[disposing that exists outside of myself](https://youtu.be/TIwmHGK29RY?t=02h15m31s)



[right before I would use this a living](https://youtu.be/TIwmHGK29RY?t=02h15m39s)



[phrase exists outside of my process you](https://youtu.be/TIwmHGK29RY?t=02h15m44s)



[need to have an unmanaged resource well](https://youtu.be/TIwmHGK29RY?t=02h15m49s)



[but even beyond that right because if if](https://youtu.be/TIwmHGK29RY?t=02h15m52s)



[all it is is say in an unmanaged Pointer](https://youtu.be/TIwmHGK29RY?t=02h15m55s)



[my entire heap that my process was](https://youtu.be/TIwmHGK29RY?t=02h15m59s)



[allocated is about to get cleaned up by](https://youtu.be/TIwmHGK29RY?t=02h16m03s)



[the OS but that's missing the point you](https://youtu.be/TIwmHGK29RY?t=02h16m05s)



[don't need to worry about stuff that is](https://youtu.be/TIwmHGK29RY?t=02h16m08s)



[already that we've really got classes](https://youtu.be/TIwmHGK29RY?t=02h16m09s)



[for safe handling handles that right but](https://youtu.be/TIwmHGK29RY?t=02h16m11s)



[I guess that's the point is it's not](https://youtu.be/TIwmHGK29RY?t=02h16m16s)



[just unmanaged stuff it's something that](https://youtu.be/TIwmHGK29RY?t=02h16m17s)



[has to live outside of my process it's](https://youtu.be/TIwmHGK29RY?t=02h16m19s)



[something that memory management will](https://youtu.be/TIwmHGK29RY?t=02h16m22s)



[not handle and is not already being](https://youtu.be/TIwmHGK29RY?t=02h16m24s)



[taught at appropriate dispose in](https://youtu.be/TIwmHGK29RY?t=02h16m26s)



[fermentation on it at the end of the day](https://youtu.be/TIwmHGK29RY?t=02h16m29s)



[that's the only requirement this is an](https://youtu.be/TIwmHGK29RY?t=02h16m32s)



[object that is not already have it as](https://youtu.be/TIwmHGK29RY?t=02h16m34s)



[that disposed implementation on it that](https://youtu.be/TIwmHGK29RY?t=02h16m36s)



[is true and if you don't have that you](https://youtu.be/TIwmHGK29RY?t=02h16m40s)



[really don't need to you're not worried](https://youtu.be/TIwmHGK29RY?t=02h16m44s)



[about our managed period the whole](https://youtu.be/TIwmHGK29RY?t=02h16m45s)



[problem goes away](https://youtu.be/TIwmHGK29RY?t=02h16m48s)



[that is true](https://youtu.be/TIwmHGK29RY?t=02h16m56s)



[I do wonder too a little bit about the](https://youtu.be/TIwmHGK29RY?t=02h17m00s)



[memory pressure that we're allocating as](https://youtu.be/TIwmHGK29RY?t=02h17m02s)



[well though what](https://youtu.be/TIwmHGK29RY?t=02h17m04s)



[so say you say the something to write a](https://youtu.be/TIwmHGK29RY?t=02h17m10s)



[derived class is used I don't know in a](https://youtu.be/TIwmHGK29RY?t=02h17m15s)



[list of 10,000 things right we're still](https://youtu.be/TIwmHGK29RY?t=02h17m20s)



[allocating a weak reference object which](https://youtu.be/TIwmHGK29RY?t=02h17m24s)



[by itself is very small and we're still](https://youtu.be/TIwmHGK29RY?t=02h17m27s)



[allocating a delegate for every single](https://youtu.be/TIwmHGK29RY?t=02h17m30s)



[instance and I don't think you can get](https://youtu.be/TIwmHGK29RY?t=02h17m34s)



[it like I could take the delegate and](https://youtu.be/TIwmHGK29RY?t=02h17m40s)



[put that into say a static function](https://youtu.be/TIwmHGK29RY?t=02h17m42s)



[right to avoid some of the allocation](https://youtu.be/TIwmHGK29RY?t=02h17m44s)



[but ultimately I have to have something](https://youtu.be/TIwmHGK29RY?t=02h17m48s)



[that holds onto this weak reference yeah](https://youtu.be/TIwmHGK29RY?t=02h17m51s)



[I could get away with I could get away](https://youtu.be/TIwmHGK29RY?t=02h17m56s)



[with a single allocation into process](https://youtu.be/TIwmHGK29RY?t=02h18m02s)



[exit by pointing it to a static function](https://youtu.be/TIwmHGK29RY?t=02h18m04s)



[and having a list of these guys that I](https://youtu.be/TIwmHGK29RY?t=02h18m07s)



[hold on to that would be smaller](https://youtu.be/TIwmHGK29RY?t=02h18m10s)



[but it would have the resizing bits of](https://youtu.be/TIwmHGK29RY?t=02h18m17s)



[list yuck](https://youtu.be/TIwmHGK29RY?t=02h18m21s)



[because this does add some level of](https://youtu.be/TIwmHGK29RY?t=02h18m27s)



[overhead calling the register for](https://youtu.be/TIwmHGK29RY?t=02h18m30s)



[cleanup I guess you're right and in and](https://youtu.be/TIwmHGK29RY?t=02h18m33s)



[maybe it maybe it's not a big deal right](https://youtu.be/TIwmHGK29RY?t=02h18m40s)



[but I do want like I feel like if I'm](https://youtu.be/TIwmHGK29RY?t=02h18m42s)



[gonna use this class somewhere I want to](https://youtu.be/TIwmHGK29RY?t=02h18m45s)



[be very careful about where it gets used](https://youtu.be/TIwmHGK29RY?t=02h18m48s)



[I think my comment about this Kevin in](https://youtu.be/TIwmHGK29RY?t=02h18m50s)



[written the real world there's a serious](https://youtu.be/TIwmHGK29RY?t=02h18m53s)



[shortage of objects that need to have](https://youtu.be/TIwmHGK29RY?t=02h18m56s)



[this implemented on them and I can](https://youtu.be/TIwmHGK29RY?t=02h18m58s)



[imagine you having a thousand of them](https://youtu.be/TIwmHGK29RY?t=02h19m00s)



[nevermind some significant number](https://youtu.be/TIwmHGK29RY?t=02h19m02s)



[I might want to go through and actually](https://youtu.be/TIwmHGK29RY?t=02h19m11s)



[query some of my repos and see how many](https://youtu.be/TIwmHGK29RY?t=02h19m13s)



[I disposable implementations there are](https://youtu.be/TIwmHGK29RY?t=02h19m16s)



[of my objects right it's not](https://youtu.be/TIwmHGK29RY?t=02h19m18s)



[implementations it's instances well](https://youtu.be/TIwmHGK29RY?t=02h19m20s)



[right but if I find all of the things](https://youtu.be/TIwmHGK29RY?t=02h19m24s)



[that implement I disposable then I can](https://youtu.be/TIwmHGK29RY?t=02h19m27s)



[just see how many instances of those](https://youtu.be/TIwmHGK29RY?t=02h19m30s)



[things I'm creating that's well my point](https://youtu.be/TIwmHGK29RY?t=02h19m32s)



[is I don't think we're creating that](https://youtu.be/TIwmHGK29RY?t=02h19m35s)



[many instances if something has to be](https://youtu.be/TIwmHGK29RY?t=02h19m36s)



[and](https://youtu.be/TIwmHGK29RY?t=02h19m38s)



[no hold on that's not true it's not a](https://youtu.be/TIwmHGK29RY?t=02h19m40s)



[disposable it's AI disposable objects](https://youtu.be/TIwmHGK29RY?t=02h19m42s)



[that are there because you have](https://youtu.be/TIwmHGK29RY?t=02h19m44s)



[unmanaged resources that's true the](https://youtu.be/TIwmHGK29RY?t=02h19m45s)



[other thing we could do is you gotta](https://youtu.be/TIwmHGK29RY?t=02h19m53s)



[manage resource week](https://youtu.be/TIwmHGK29RY?t=02h19m55s)



[if we change this from I disposable we](https://youtu.be/TIwmHGK29RY?t=02h20m03s)



[could also unregister the delegate right](https://youtu.be/TIwmHGK29RY?t=02h20m06s)



[if de spoke because we only clear easy](https://youtu.be/TIwmHGK29RY?t=02h20m10s)



[suppressed suppressed we should also do](https://youtu.be/TIwmHGK29RY?t=02h20m14s)



[this I totally agree yeah because it](https://youtu.be/TIwmHGK29RY?t=02h20m16s)



[fact I think that's a mistake not to](https://youtu.be/TIwmHGK29RY?t=02h20m20s)



[have done that the problem is keeping](https://youtu.be/TIwmHGK29RY?t=02h20m21s)



[track of that item in order to](https://youtu.be/TIwmHGK29RY?t=02h20m23s)



[unregister it is hard right well I think](https://youtu.be/TIwmHGK29RY?t=02h20m25s)



[what I would do is I would not do this](https://youtu.be/TIwmHGK29RY?t=02h20m28s)



[in an extension method right no agree we](https://youtu.be/TIwmHGK29RY?t=02h20m30s)



[don't have I would move this up that way](https://youtu.be/TIwmHGK29RY?t=02h20m33s)



[I could hold on to the delegate instance](https://youtu.be/TIwmHGK29RY?t=02h20m35s)



[to be able to don't have a choice you](https://youtu.be/TIwmHGK29RY?t=02h20m37s)



[don't have a choice you don't have a](https://youtu.be/TIwmHGK29RY?t=02h20m39s)



[reasonable choice true and actually does](https://youtu.be/TIwmHGK29RY?t=02h20m41s)



[that mean no I was gonna say does that](https://youtu.be/TIwmHGK29RY?t=02h20m49s)



[mean we need the weak reference at that](https://youtu.be/TIwmHGK29RY?t=02h20m55s)



[point you do because process exit is](https://youtu.be/TIwmHGK29RY?t=02h20m57s)



[still pointing to it yeah yeah cuz I](https://youtu.be/TIwmHGK29RY?t=02h20m59s)



[definitely don't to hold on to it](https://youtu.be/TIwmHGK29RY?t=02h21m03s)



[forever well cool I think it's fun thank](https://youtu.be/TIwmHGK29RY?t=02h21m04s)



[you yeah I think I think that's probably](https://youtu.be/TIwmHGK29RY?t=02h21m11s)



[as far as we can take it tonight](https://youtu.be/TIwmHGK29RY?t=02h21m14s)



[hopefully people found this to be](https://youtu.be/TIwmHGK29RY?t=02h21m15s)



[interesting so thank you Kevin those fun](https://youtu.be/TIwmHGK29RY?t=02h21m17s)



[yeah no thank you Mark so with that I](https://youtu.be/TIwmHGK29RY?t=02h21m22s)



[will say goodnight I'll hopefully have](https://youtu.be/TIwmHGK29RY?t=02h21m26s)



[this video posted to YouTube tomorrow](https://youtu.be/TIwmHGK29RY?t=02h21m29s)



[ish at some point I will probably be](https://youtu.be/TIwmHGK29RY?t=02h21m31s)



[writing this up over the next two weeks](https://youtu.be/TIwmHGK29RY?t=02h21m34s)



[excellent thank you Mike I've got a](https://youtu.be/TIwmHGK29RY?t=02h21m36s)



[specific request for the c-sharp team to](https://youtu.be/TIwmHGK29RY?t=02h21m39s)



[write this up](https://youtu.be/TIwmHGK29RY?t=02h21m41s)



[excellent once you do let me know I want](https://youtu.be/TIwmHGK29RY?t=02h21m42s)



[to put a link to that because I assume](https://youtu.be/TIwmHGK29RY?t=02h21m46s)



[that's that good heaven once I do I will](https://youtu.be/TIwmHGK29RY?t=02h21m48s)



[let you know so you can check it for me](https://youtu.be/TIwmHGK29RY?t=02h21m51s)



[what are you talking about of course](https://youtu.be/TIwmHGK29RY?t=02h21m53s)



[perfect all right I think this is the](https://youtu.be/TIwmHGK29RY?t=02h21m57s)



[challenging problem and there's actually](https://youtu.be/TIwmHGK29RY?t=02h21m59s)



[a specific article that we're trying to](https://youtu.be/TIwmHGK29RY?t=02h22m01s)



[get at that I need to edit because it](https://youtu.be/TIwmHGK29RY?t=02h22m03s)



[doesn't just talk about this correctly](https://youtu.be/TIwmHGK29RY?t=02h22m05s)



[in fact that's one of them well the](https://youtu.be/TIwmHGK29RY?t=02h22m07s)



[first one I think to write I've got a](https://youtu.be/TIwmHGK29RY?t=02h22m09s)



[I've got an issue posted against that](https://youtu.be/TIwmHGK29RY?t=02h22m11s)



[article](https://youtu.be/TIwmHGK29RY?t=02h22m13s)



[and unfortunately what for those times](https://youtu.be/TIwmHGK29RY?t=02h22m15s)



[where I posted an issue and they came](https://youtu.be/TIwmHGK29RY?t=02h22m17s)



[back and said okay mark go ahead and](https://youtu.be/TIwmHGK29RY?t=02h22m18s)



[write it CMOS a feature that is the](https://youtu.be/TIwmHGK29RY?t=02h22m20s)



[problem](https://youtu.be/TIwmHGK29RY?t=02h22m25s)



[yes that's be careful what you say yeah](https://youtu.be/TIwmHGK29RY?t=02h22m25s)



[if you complain they're either going to](https://youtu.be/TIwmHGK29RY?t=02h22m28s)



[let you do it you're wrong](https://youtu.be/TIwmHGK29RY?t=02h22m30s)



[yeah well it should be easier my book is](https://youtu.be/TIwmHGK29RY?t=02h22m35s)



[like pregnant so we're close that would](https://youtu.be/TIwmHGK29RY?t=02h22m38s)



[be awesome cool I'm going to say sign](https://youtu.be/TIwmHGK29RY?t=02h22m42s)



[off we'll have a good night thanks](https://youtu.be/TIwmHGK29RY?t=02h22m47s)



[thanks everyone it was fun](https://youtu.be/TIwmHGK29RY?t=02h22m49s)



[now that worked well Kevin nice job I](https://youtu.be/TIwmHGK29RY?t=02h23m10s)



[was so excited about the week reference](https://youtu.be/TIwmHGK29RY?t=02h23m16s)



[because that's the thing I really wanted](https://youtu.be/TIwmHGK29RY?t=02h23m19s)



[to try cuz I knew that this problem](https://youtu.be/TIwmHGK29RY?t=02h23m21s)



[existed and I knew the way to solve was](https://youtu.be/TIwmHGK29RY?t=02h23m22s)



[with the recurrence yeah yeah send it to](https://youtu.be/TIwmHGK29RY?t=02h23m25s)



[me](https://youtu.be/TIwmHGK29RY?t=02h23m30s)



[just said I mean you just copy and paste](https://youtu.be/TIwmHGK29RY?t=02h23m37s)



[in an email I don't need nothing besides](https://youtu.be/TIwmHGK29RY?t=02h23m39s)



[that yeah that's fine](https://youtu.be/TIwmHGK29RY?t=02h23m41s)



[how'd you send it to me how did you send](https://youtu.be/TIwmHGK29RY?t=02h23m49s)



[it to me Oh No](https://youtu.be/TIwmHGK29RY?t=02h23m53s)



[that's a terrible way to send me a file](https://youtu.be/TIwmHGK29RY?t=02h23m57s)



[were you thinking](https://youtu.be/TIwmHGK29RY?t=02h24m00s)



[where the heck does that go you know I](https://youtu.be/TIwmHGK29RY?t=02h24m08s)



[mean where does it actually we're gonna](https://youtu.be/TIwmHGK29RY?t=02h24m15s)



[save the file where's it's actually](https://youtu.be/TIwmHGK29RY?t=02h24m16s)



[saved to this is a oh my goodness I've](https://youtu.be/TIwmHGK29RY?t=02h24m17s)



[now got a file called program dot CS and](https://youtu.be/TIwmHGK29RY?t=02h24m22s)



[I'm supposed to know what it's for](https://youtu.be/TIwmHGK29RY?t=02h24m24s)



[thanks a lot no I'm kidding](https://youtu.be/TIwmHGK29RY?t=02h24m26s)



[thank you Kevin those fine I enjoyed](https://youtu.be/TIwmHGK29RY?t=02h24m31s)



[that](https://youtu.be/TIwmHGK29RY?t=02h24m32s)



[yeah](https://youtu.be/TIwmHGK29RY?t=02h24m47s)



[yeah](https://youtu.be/TIwmHGK29RY?t=02h25m14s)


