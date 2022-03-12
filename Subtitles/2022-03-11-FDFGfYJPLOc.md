[YouTube Video](https://youtu.be/FDFGfYJPLOc)



[okay everyone welcome back](https://youtu.be/FDFGfYJPLOc?t=00h00m03s)

[uh tonight oh that is a little loud](https://youtu.be/FDFGfYJPLOc?t=00h00m05s)

[let's turn that down](https://youtu.be/FDFGfYJPLOc?t=00h00m06s)

[ah you're early to the show robert not](https://youtu.be/FDFGfYJPLOc?t=00h00m09s)

[wpf tonight so i have been on a source](https://youtu.be/FDFGfYJPLOc?t=00h00m12s)

[generator kick](https://youtu.be/FDFGfYJPLOc?t=00h00m15s)

[and so i've got some ideas of some](https://youtu.be/FDFGfYJPLOc?t=00h00m16s)

[source generators and i've kind of](https://youtu.be/FDFGfYJPLOc?t=00h00m19s)

[talked about them and shown the results](https://youtu.be/FDFGfYJPLOc?t=00h00m20s)

[of them in a few other streams but i](https://youtu.be/FDFGfYJPLOc?t=00h00m22s)

[figured i would go through and actually](https://youtu.be/FDFGfYJPLOc?t=00h00m24s)

[build one out tonight so specifically](https://youtu.be/FDFGfYJPLOc?t=00h00m26s)

[the idea is there are what i would](https://youtu.be/FDFGfYJPLOc?t=00h00m28s)

[classify low value unit tests](https://youtu.be/FDFGfYJPLOc?t=00h00m30s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h00m33s)

[i don't want to write them but](https://youtu.be/FDFGfYJPLOc?t=00h00m34s)

[occasionally you run into a situation](https://youtu.be/FDFGfYJPLOc?t=00h00m35s)

[where perhaps the repository that you're](https://youtu.be/FDFGfYJPLOc?t=00h00m37s)

[working in has a](https://youtu.be/FDFGfYJPLOc?t=00h00m39s)

[a fixed bar for you must have so much](https://youtu.be/FDFGfYJPLOc?t=00h00m41s)

[code coverage](https://youtu.be/FDFGfYJPLOc?t=00h00m43s)

[and](https://youtu.be/FDFGfYJPLOc?t=00h00m44s)

[some tests](https://youtu.be/FDFGfYJPLOc?t=00h00m45s)

[will say aren't don't add a lot of value](https://youtu.be/FDFGfYJPLOc?t=00h00m47s)

[but if you don't write them you lose](https://youtu.be/FDFGfYJPLOc?t=00h00m49s)

[coverage so for example](https://youtu.be/FDFGfYJPLOc?t=00h00m51s)

[you've got a class takes in a couple](https://youtu.be/FDFGfYJPLOc?t=00h00m53s)

[dependencies in its constructor like a](https://youtu.be/FDFGfYJPLOc?t=00h00m55s)

[good programmer you null check those](https://youtu.be/FDFGfYJPLOc?t=00h00m57s)

[dependencies](https://youtu.be/FDFGfYJPLOc?t=00h00m59s)

[problem is](https://youtu.be/FDFGfYJPLOc?t=00h01m00s)

[that null check adds a](https://youtu.be/FDFGfYJPLOc?t=00h01m02s)

[a branch condition there you know if](https://youtu.be/FDFGfYJPLOc?t=00h01m05s)

[null throw argument no exception great](https://youtu.be/FDFGfYJPLOc?t=00h01m06s)

[but unless you test all of those throw](https://youtu.be/FDFGfYJPLOc?t=00h01m09s)

[statements you're missing out on](https://youtu.be/FDFGfYJPLOc?t=00h01m10s)

[coverage numbers the problem is is](https://youtu.be/FDFGfYJPLOc?t=00h01m12s)

[writing those tests is](https://youtu.be/FDFGfYJPLOc?t=00h01m14s)

[uh mundane boring and they don't add a](https://youtu.be/FDFGfYJPLOc?t=00h01m16s)

[lot of value](https://youtu.be/FDFGfYJPLOc?t=00h01m19s)

[i had a colleague earlier to say say](https://youtu.be/FDFGfYJPLOc?t=00h01m21s)

[yeah](https://youtu.be/FDFGfYJPLOc?t=00h01m23s)

[i won't uh i won't dock you on a code](https://youtu.be/FDFGfYJPLOc?t=00h01m25s)

[review uh if uh if i see those type of](https://youtu.be/FDFGfYJPLOc?t=00h01m28s)

[tests but i'm also not gonna tell you to](https://youtu.be/FDFGfYJPLOc?t=00h01m30s)

[write them either because they really](https://youtu.be/FDFGfYJPLOc?t=00h01m32s)

[don't add a lot](https://youtu.be/FDFGfYJPLOc?t=00h01m34s)

[um so](https://youtu.be/FDFGfYJPLOc?t=00h01m35s)

[what i figured is they they only really](https://youtu.be/FDFGfYJPLOc?t=00h01m37s)

[have a](https://youtu.be/FDFGfYJPLOc?t=00h01m40s)

[value](https://youtu.be/FDFGfYJPLOc?t=00h01m42s)

[for people who are being forced to do it](https://youtu.be/FDFGfYJPLOc?t=00h01m44s)

[for particular code coverage metrics](https://youtu.be/FDFGfYJPLOc?t=00h01m46s)

[i've said it on stream before my](https://youtu.be/FDFGfYJPLOc?t=00h01m49s)

[personal opinion is code coverage](https://youtu.be/FDFGfYJPLOc?t=00h01m51s)

[metrics are only good as a negative](https://youtu.be/FDFGfYJPLOc?t=00h01m52s)

[statistic](https://youtu.be/FDFGfYJPLOc?t=00h01m54s)

[meaning um you can't say that you have](https://youtu.be/FDFGfYJPLOc?t=00h01m55s)

[75 percent coverage you have 25](https://youtu.be/FDFGfYJPLOc?t=00h01m58s)

[uncovered i can't say the quality of](https://youtu.be/FDFGfYJPLOc?t=00h02m00s)

[that 75 percent that actually executed](https://youtu.be/FDFGfYJPLOc?t=00h02m03s)

[during your test but i can tell you](https://youtu.be/FDFGfYJPLOc?t=00h02m05s)

[something about the 25 that wasn't](https://youtu.be/FDFGfYJPLOc?t=00h02m06s)

[executed that ain't covered so i think](https://youtu.be/FDFGfYJPLOc?t=00h02m08s)

[it's only good for the the negative](https://youtu.be/FDFGfYJPLOc?t=00h02m10s)

[metric of how much is it covered versus](https://youtu.be/FDFGfYJPLOc?t=00h02m12s)

[the positive metric of how much is](https://youtu.be/FDFGfYJPLOc?t=00h02m15s)

[so my opinion](https://youtu.be/FDFGfYJPLOc?t=00h02m17s)

[take it with a grain of salt welcome](https://youtu.be/FDFGfYJPLOc?t=00h02m19s)

[everybody lots of people chatting so](https://youtu.be/FDFGfYJPLOc?t=00h02m21s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h02m24s)

[yes agree with everybody so let me show](https://youtu.be/FDFGfYJPLOc?t=00h02m25s)

[you what](https://youtu.be/FDFGfYJPLOc?t=00h02m28s)

[what i started on](https://youtu.be/FDFGfYJPLOc?t=00h02m29s)

[so my goal is to not write this for one](https://youtu.be/FDFGfYJPLOc?t=00h02m31s)

[project my goal is to write this and](https://youtu.be/FDFGfYJPLOc?t=00h02m34s)

[then turn it loose on the world which is](https://youtu.be/FDFGfYJPLOc?t=00h02m36s)

[a scary idea but we're doing it anyway](https://youtu.be/FDFGfYJPLOc?t=00h02m38s)

[so the auto mocker library which](https://youtu.be/FDFGfYJPLOc?t=00h02m41s)

[i think i've shown to to people before](https://youtu.be/FDFGfYJPLOc?t=00h02m44s)

[um this is a library that me and a](https://youtu.be/FDFGfYJPLOc?t=00h02m47s)

[colleague of mine took over a while back](https://youtu.be/FDFGfYJPLOc?t=00h02m49s)

[kind of around the the time the.net core](https://youtu.be/FDFGfYJPLOc?t=00h02m52s)

[came out](https://youtu.be/FDFGfYJPLOc?t=00h02m55s)

[the original author was swamped didn't](https://youtu.be/FDFGfYJPLOc?t=00h02m57s)

[have time for managing it um and so he](https://youtu.be/FDFGfYJPLOc?t=00h02m59s)

[was kind enough to give us contribution](https://youtu.be/FDFGfYJPLOc?t=00h03m02s)

[rights and we took off running with it](https://youtu.be/FDFGfYJPLOc?t=00h03m04s)

[um and it's been great](https://youtu.be/FDFGfYJPLOc?t=00h03m06s)

[but the the idea here is that](https://youtu.be/FDFGfYJPLOc?t=00h03m09s)

[typically when you're writing tests uh](https://youtu.be/FDFGfYJPLOc?t=00h03m12s)

[the idea of creating the object that](https://youtu.be/FDFGfYJPLOc?t=00h03m14s)

[you're going to test or the system under](https://youtu.be/FDFGfYJPLOc?t=00h03m16s)

[test](https://youtu.be/FDFGfYJPLOc?t=00h03m18s)

[the constructor is a static call](https://youtu.be/FDFGfYJPLOc?t=00h03m19s)

[constructors by definition are static](https://youtu.be/FDFGfYJPLOc?t=00h03m22s)

[it seems a little weird but if you think](https://youtu.be/FDFGfYJPLOc?t=00h03m24s)

[about them as a static method that](https://youtu.be/FDFGfYJPLOc?t=00h03m26s)

[returns you back your instance](https://youtu.be/FDFGfYJPLOc?t=00h03m27s)

[get yourself conceptually in the right](https://youtu.be/FDFGfYJPLOc?t=00h03m30s)

[model in c sharp it's a little different](https://youtu.be/FDFGfYJPLOc?t=00h03m31s)

[constructors are more like](https://youtu.be/FDFGfYJPLOc?t=00h03m33s)

[an initializer uh when you do the con uh](https://youtu.be/FDFGfYJPLOc?t=00h03m35s)

[when you call new object type you get uh](https://youtu.be/FDFGfYJPLOc?t=00h03m38s)

[memory allocation and then the](https://youtu.be/FDFGfYJPLOc?t=00h03m41s)

[initialization so memory allocation](https://youtu.be/FDFGfYJPLOc?t=00h03m43s)

[occurs first then the initialization](https://youtu.be/FDFGfYJPLOc?t=00h03m45s)

[there's kind of some back and forth in](https://youtu.be/FDFGfYJPLOc?t=00h03m47s)

[the order static constructors instance](https://youtu.be/FDFGfYJPLOc?t=00h03m48s)

[constructors whatever](https://youtu.be/FDFGfYJPLOc?t=00h03m50s)

[for the purposes of auto mocker the idea](https://youtu.be/FDFGfYJPLOc?t=00h03m53s)

[is if your constructor takes in](https://youtu.be/FDFGfYJPLOc?t=00h03m55s)

[constructor parameters dependencies it](https://youtu.be/FDFGfYJPLOc?t=00h03m57s)

[will go through and automatically](https://youtu.be/FDFGfYJPLOc?t=00h04m00s)

[populate those dependencies with mocks](https://youtu.be/FDFGfYJPLOc?t=00h04m02s)

[and you can do all kinds of things to](https://youtu.be/FDFGfYJPLOc?t=00h04m03s)

[configure](https://youtu.be/FDFGfYJPLOc?t=00h04m05s)

[how it's going to do that popular](https://youtu.be/FDFGfYJPLOc?t=00h04m06s)

[populating](https://youtu.be/FDFGfYJPLOc?t=00h04m08s)

[but the idea is then as you go and add a](https://youtu.be/FDFGfYJPLOc?t=00h04m11s)

[new constructor parameter to your object](https://youtu.be/FDFGfYJPLOc?t=00h04m13s)

[you don't need to go back and refactor](https://youtu.be/FDFGfYJPLOc?t=00h04m15s)

[all your tests to add that in it'll](https://youtu.be/FDFGfYJPLOc?t=00h04m17s)

[automatically just do it for you you](https://youtu.be/FDFGfYJPLOc?t=00h04m19s)

[only need to go and modify the tests](https://youtu.be/FDFGfYJPLOc?t=00h04m20s)

[that actually care about that particular](https://youtu.be/FDFGfYJPLOc?t=00h04m22s)

[dependency](https://youtu.be/FDFGfYJPLOc?t=00h04m24s)

[as it should be](https://youtu.be/FDFGfYJPLOc?t=00h04m25s)

[so that is what it is used for a](https://youtu.be/FDFGfYJPLOc?t=00h04m27s)

[to some degree if for people who watched](https://youtu.be/FDFGfYJPLOc?t=00h04m30s)

[my uh dependency injection stream like](https://youtu.be/FDFGfYJPLOc?t=00h04m32s)

[is six ago](https://youtu.be/FDFGfYJPLOc?t=00h04m35s)

[go back in the history like six](https://youtu.be/FDFGfYJPLOc?t=00h04m37s)

[um you can almost think of auto marker](https://youtu.be/FDFGfYJPLOc?t=00h04m39s)

[as kind of a lightweight di container](https://youtu.be/FDFGfYJPLOc?t=00h04m41s)

[because it does run recursively too so](https://youtu.be/FDFGfYJPLOc?t=00h04m44s)

[if it if your dependency is another](https://youtu.be/FDFGfYJPLOc?t=00h04m47s)

[class and it can look at its constructor](https://youtu.be/FDFGfYJPLOc?t=00h04m49s)

[and figure out its dependencies it'll](https://youtu.be/FDFGfYJPLOc?t=00h04m52s)

[populate that and work its way all the](https://youtu.be/FDFGfYJPLOc?t=00h04m53s)

[way up so it can kind of figure its way](https://youtu.be/FDFGfYJPLOc?t=00h04m55s)

[all the way back to where it's going](https://youtu.be/FDFGfYJPLOc?t=00h04m58s)

[so what i did is i started a branch](https://youtu.be/FDFGfYJPLOc?t=00h05m01s)

[and](https://youtu.be/FDFGfYJPLOc?t=00h05m06s)

[naturally to prevent people from seeing](https://youtu.be/FDFGfYJPLOc?t=00h05m08s)

[it i then](https://youtu.be/FDFGfYJPLOc?t=00h05m10s)

[didn't open my code up to show you which](https://youtu.be/FDFGfYJPLOc?t=00h05m12s)

[is horrible](https://youtu.be/FDFGfYJPLOc?t=00h05m14s)

[so uh for people who are interested to](https://youtu.be/FDFGfYJPLOc?t=00h05m15s)

[do](https://youtu.be/FDFGfYJPLOc?t=00h05m18s)

[link to the repo link to three](https://youtu.be/FDFGfYJPLOc?t=00h05m19s)

[boom okay and then anybody not paying](https://youtu.be/FDFGfYJPLOc?t=00h05m22s)

[attention the test generator branch is](https://youtu.be/FDFGfYJPLOc?t=00h05m25s)

[the one](https://youtu.be/FDFGfYJPLOc?t=00h05m27s)

[uh oh](https://youtu.be/FDFGfYJPLOc?t=00h05m28s)

[hang on that's](https://youtu.be/FDFGfYJPLOc?t=00h05m29s)

[that's the real one um](https://youtu.be/FDFGfYJPLOc?t=00h05m31s)

[i want my auto marker](https://youtu.be/FDFGfYJPLOc?t=00h05m34s)

[uh sorry gotta go back gotta go back](https://youtu.be/FDFGfYJPLOc?t=00h05m36s)

[this](https://youtu.be/FDFGfYJPLOc?t=00h05m40s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h05m42s)

[i actually want](https://youtu.be/FDFGfYJPLOc?t=00h05m43s)

[this one](https://youtu.be/FDFGfYJPLOc?t=00h05m45s)

[i want mine](https://youtu.be/FDFGfYJPLOc?t=00h05m47s)

[so my fork is where the branch exists](https://youtu.be/FDFGfYJPLOc?t=00h05m48s)

[and specifically](https://youtu.be/FDFGfYJPLOc?t=00h05m52s)

[this generator](https://youtu.be/FDFGfYJPLOc?t=00h05m54s)

[this branch](https://youtu.be/FDFGfYJPLOc?t=00h05m55s)

[this is where we're going to play from](https://youtu.be/FDFGfYJPLOc?t=00h05m57s)

[well this is where i'm going to play](https://youtu.be/FDFGfYJPLOc?t=00h06m00s)

[from uh](https://youtu.be/FDFGfYJPLOc?t=00h06m01s)

[okay so if we open this guy up](https://youtu.be/FDFGfYJPLOc?t=00h06m03s)

[i have i i pre-populated some stuff and](https://youtu.be/FDFGfYJPLOc?t=00h06m05s)

[i'm gonna just](https://youtu.be/FDFGfYJPLOc?t=00h06m08s)

[close all my tabs](https://youtu.be/FDFGfYJPLOc?t=00h06m09s)

[okay](https://youtu.be/FDFGfYJPLOc?t=00h06m11s)

[so we're gonna ignore](https://youtu.be/FDFGfYJPLOc?t=00h06m12s)

[everything down here because that's the](https://youtu.be/FDFGfYJPLOc?t=00h06m14s)

[actual auto marker library we're gonna](https://youtu.be/FDFGfYJPLOc?t=00h06m16s)

[focus up here so i wrote a simple class](https://youtu.be/FDFGfYJPLOc?t=00h06m17s)

[called controller it takes in a simple](https://youtu.be/FDFGfYJPLOc?t=00h06m20s)

[interface called i service just](https://youtu.be/FDFGfYJPLOc?t=00h06m22s)

[populates a property](https://youtu.be/FDFGfYJPLOc?t=00h06m25s)

[this is that kind of meaningless code](https://youtu.be/FDFGfYJPLOc?t=00h06m26s)

[that i was mentioning if you were to](https://youtu.be/FDFGfYJPLOc?t=00h06m28s)

[check the the code coverage for it](https://youtu.be/FDFGfYJPLOc?t=00h06m30s)

[you would have to pass in both the null](https://youtu.be/FDFGfYJPLOc?t=00h06m32s)

[and not null case in order to hit both](https://youtu.be/FDFGfYJPLOc?t=00h06m34s)

[sides of the if condition that's](https://youtu.be/FDFGfYJPLOc?t=00h06m36s)

[generated](https://youtu.be/FDFGfYJPLOc?t=00h06m38s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h06m39s)

[by this null check here](https://youtu.be/FDFGfYJPLOc?t=00h06m40s)

[and you can see i just the interface is](https://youtu.be/FDFGfYJPLOc?t=00h06m43s)

[empty there's nothing fancy it's very](https://youtu.be/FDFGfYJPLOc?t=00h06m44s)

[simple i then went and wrote a bunch of](https://youtu.be/FDFGfYJPLOc?t=00h06m46s)

[unit test projects](https://youtu.be/FDFGfYJPLOc?t=00h06m49s)

[they all look remarkably similar](https://youtu.be/FDFGfYJPLOc?t=00h06m51s)

[and so i wrote up](https://youtu.be/FDFGfYJPLOc?t=00h06m53s)

[the tests and you can see live unit](https://youtu.be/FDFGfYJPLOc?t=00h06m55s)

[testing is on and it conveniently points](https://youtu.be/FDFGfYJPLOc?t=00h06m57s)

[out that my test is now passing but if i](https://youtu.be/FDFGfYJPLOc?t=00h06m58s)

[were to unit test this](https://youtu.be/FDFGfYJPLOc?t=00h07m01s)

[manually](https://youtu.be/FDFGfYJPLOc?t=00h07m02s)

[i would do something like this i would](https://youtu.be/FDFGfYJPLOc?t=00h07m04s)

[instantiate an auto marker instance](https://youtu.be/FDFGfYJPLOc?t=00h07m06s)

[i would explicitly tell it to use null](https://youtu.be/FDFGfYJPLOc?t=00h07m08s)

[for the i service dependency whenever it](https://youtu.be/FDFGfYJPLOc?t=00h07m11s)

[runs into one](https://youtu.be/FDFGfYJPLOc?t=00h07m13s)

[and then i would assert that when i call](https://youtu.be/FDFGfYJPLOc?t=00h07m14s)

[mocker create instance on controller](https://youtu.be/FDFGfYJPLOc?t=00h07m16s)

[that it should throw an argument no](https://youtu.be/FDFGfYJPLOc?t=00h07m19s)

[exception](https://youtu.be/FDFGfYJPLOc?t=00h07m20s)

[and the argument null exception should](https://youtu.be/FDFGfYJPLOc?t=00h07m22s)

[have a parameter name of service](https://youtu.be/FDFGfYJPLOc?t=00h07m23s)

[and i you can imagine if i were to go](https://youtu.be/FDFGfYJPLOc?t=00h07m26s)

[and add yet one more parameter to that](https://youtu.be/FDFGfYJPLOc?t=00h07m28s)

[class i would then have to write another](https://youtu.be/FDFGfYJPLOc?t=00h07m31s)

[test](https://youtu.be/FDFGfYJPLOc?t=00h07m33s)

[it would look remarkably similar to this](https://youtu.be/FDFGfYJPLOc?t=00h07m34s)

[except for i'm kind of hard coding this](https://youtu.be/FDFGfYJPLOc?t=00h07m37s)

[type here](https://youtu.be/FDFGfYJPLOc?t=00h07m39s)

[and i'm definitely hard coding this](https://youtu.be/FDFGfYJPLOc?t=00h07m40s)

[string](https://youtu.be/FDFGfYJPLOc?t=00h07m42s)

[and in the past i've written](https://youtu.be/FDFGfYJPLOc?t=00h07m43s)

[reflection-based solutions to this of](https://youtu.be/FDFGfYJPLOc?t=00h07m45s)

[okay well i can i can feed in a type i](https://youtu.be/FDFGfYJPLOc?t=00h07m47s)

[can go looking for its constructor i can](https://youtu.be/FDFGfYJPLOc?t=00h07m50s)

[do all that there that's dumb we're just](https://youtu.be/FDFGfYJPLOc?t=00h07m52s)

[going to skip all that](https://youtu.be/FDFGfYJPLOc?t=00h07m54s)

[i figure i should be able to generate](https://youtu.be/FDFGfYJPLOc?t=00h07m57s)

[these tests with a source generator](https://youtu.be/FDFGfYJPLOc?t=00h08m00s)

[because there's nothing in here that i](https://youtu.be/FDFGfYJPLOc?t=00h08m02s)

[shouldn't be able to pull out](https://youtu.be/FDFGfYJPLOc?t=00h08m03s)

[that's my working theory i don't know of](https://youtu.be/FDFGfYJPLOc?t=00h08m05s)

[a reason why this fails yet so we're](https://youtu.be/FDFGfYJPLOc?t=00h08m07s)

[going to try it and push it to the point](https://youtu.be/FDFGfYJPLOc?t=00h08m08s)

[where it does um or i sh or i ship this](https://youtu.be/FDFGfYJPLOc?t=00h08m10s)

[but the the idea being that](https://youtu.be/FDFGfYJPLOc?t=00h08m14s)

[if this is your test project i would](https://youtu.be/FDFGfYJPLOc?t=00h08m16s)

[love to have somebody declare a test](https://youtu.be/FDFGfYJPLOc?t=00h08m18s)

[project something like this](https://youtu.be/FDFGfYJPLOc?t=00h08m21s)

[and then i don't know uh auto](https://youtu.be/FDFGfYJPLOc?t=00h08m23s)

[mocker](https://youtu.be/FDFGfYJPLOc?t=00h08m27s)

[constructor test](https://youtu.be/FDFGfYJPLOc?t=00h08m29s)

[right](https://youtu.be/FDFGfYJPLOc?t=00h08m31s)

[do some sort of attribute on it to](https://youtu.be/FDFGfYJPLOc?t=00h08m32s)

[indicate type](https://youtu.be/FDFGfYJPLOc?t=00h08m34s)

[we'll see we'll see exactly how we want](https://youtu.be/FDFGfYJPLOc?t=00h08m37s)

[to go about doing that but you'll know](https://youtu.be/FDFGfYJPLOc?t=00h08m39s)

[this class is generated partial and then](https://youtu.be/FDFGfYJPLOc?t=00h08m41s)

[what i would expect to do](https://youtu.be/FDFGfYJPLOc?t=00h08m43s)

[is this test no longer lives here](https://youtu.be/FDFGfYJPLOc?t=00h08m47s)

[but it lives in the partial class](https://youtu.be/FDFGfYJPLOc?t=00h08m50s)

[instead which the source generators can](https://youtu.be/FDFGfYJPLOc?t=00h08m52s)

[build](https://youtu.be/FDFGfYJPLOc?t=00h08m54s)

[so that's the plan so for people](https://youtu.be/FDFGfYJPLOc?t=00h08m55s)

[unfamiliar with source generators they](https://youtu.be/FDFGfYJPLOc?t=00h08m57s)

[are a magical thing that got added to](https://youtu.be/FDFGfYJPLOc?t=00h08m59s)

[the c-sharp tool chain it gives you an](https://youtu.be/FDFGfYJPLOc?t=00h09m01s)

[opportunity actually hang on](https://youtu.be/FDFGfYJPLOc?t=00h09m04s)

[i added](https://youtu.be/FDFGfYJPLOc?t=00h09m06s)

[boom](https://youtu.be/FDFGfYJPLOc?t=00h09m08s)

[docs](https://youtu.be/FDFGfYJPLOc?t=00h09m10s)

[docs documentation is good documentation](https://youtu.be/FDFGfYJPLOc?t=00h09m11s)

[is good](https://youtu.be/FDFGfYJPLOc?t=00h09m13s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h09m14s)

[this picture is what i'm going for here](https://youtu.be/FDFGfYJPLOc?t=00h09m15s)

[when you hit compile](https://youtu.be/FDFGfYJPLOc?t=00h09m17s)

[the source generators get a chance to](https://youtu.be/FDFGfYJPLOc?t=00h09m19s)

[run](https://youtu.be/FDFGfYJPLOc?t=00h09m22s)

[and you're you don't really get there's](https://youtu.be/FDFGfYJPLOc?t=00h09m23s)

[a some limitations to them one of which](https://youtu.be/FDFGfYJPLOc?t=00h09m25s)

[is if you have a lot of source](https://youtu.be/FDFGfYJPLOc?t=00h09m27s)

[generators](https://youtu.be/FDFGfYJPLOc?t=00h09m28s)

[there's not ordering to them or at least](https://youtu.be/FDFGfYJPLOc?t=00h09m29s)

[you can't control the ordering so you](https://youtu.be/FDFGfYJPLOc?t=00h09m31s)

[can't really get yourself or i should](https://youtu.be/FDFGfYJPLOc?t=00h09m34s)

[say you don't want to try to get](https://youtu.be/FDFGfYJPLOc?t=00h09m36s)

[yourself into a state where source](https://youtu.be/FDFGfYJPLOc?t=00h09m37s)

[generator a depends on source generator](https://youtu.be/FDFGfYJPLOc?t=00h09m38s)

[b that's no bueno](https://youtu.be/FDFGfYJPLOc?t=00h09m40s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h09m42s)

[but you hit compile f5 ctrl shift b](https://youtu.be/FDFGfYJPLOc?t=00h09m44s)

[whatever](https://youtu.be/FDFGfYJPLOc?t=00h09m47s)

[source generator runs it can look at](https://youtu.be/FDFGfYJPLOc?t=00h09m48s)

[your source code um specifically it](https://youtu.be/FDFGfYJPLOc?t=00h09m50s)

[looks at what's called the ast or the](https://youtu.be/FDFGfYJPLOc?t=00h09m53s)

[rosslyn c-sharp compiler view of your](https://youtu.be/FDFGfYJPLOc?t=00h09m55s)

[source code and you can investigate it](https://youtu.be/FDFGfYJPLOc?t=00h09m57s)

[go through it figure out you know what](https://youtu.be/FDFGfYJPLOc?t=00h10m00s)

[you like what you know what information](https://youtu.be/FDFGfYJPLOc?t=00h10m02s)

[we need in our case what we would end up](https://youtu.be/FDFGfYJPLOc?t=00h10m04s)

[doing](https://youtu.be/FDFGfYJPLOc?t=00h10m06s)

[is my thought is i go hunting for some](https://youtu.be/FDFGfYJPLOc?t=00h10m07s)

[attribute](https://youtu.be/FDFGfYJPLOc?t=00h10m09s)

[or similar some trigger](https://youtu.be/FDFGfYJPLOc?t=00h10m10s)

[and then from that trigger i generate](https://youtu.be/FDFGfYJPLOc?t=00h10m13s)

[new source code](https://youtu.be/FDFGfYJPLOc?t=00h10m17s)

[and that new source code gets added](https://youtu.be/FDFGfYJPLOc?t=00h10m18s)

[okay that's the the other big limitation](https://youtu.be/FDFGfYJPLOc?t=00h10m21s)

[with source generators is everything](https://youtu.be/FDFGfYJPLOc?t=00h10m23s)

[they do must be additive you are not](https://youtu.be/FDFGfYJPLOc?t=00h10m25s)

[allowed to mutate](https://youtu.be/FDFGfYJPLOc?t=00h10m28s)

[in any way so you cannot remove code you](https://youtu.be/FDFGfYJPLOc?t=00h10m30s)

[cannot change existing code that has](https://youtu.be/FDFGfYJPLOc?t=00h10m33s)

[already been written that is about to be](https://youtu.be/FDFGfYJPLOc?t=00h10m36s)

[compiled now even with those limitations](https://youtu.be/FDFGfYJPLOc?t=00h10m38s)

[there's a lot you can still get away](https://youtu.be/FDFGfYJPLOc?t=00h10m41s)

[with um it just means you have to](https://youtu.be/FDFGfYJPLOc?t=00h10m43s)

[structure your code](https://youtu.be/FDFGfYJPLOc?t=00h10m44s)

[in such a way as to take advantage of a](https://youtu.be/FDFGfYJPLOc?t=00h10m46s)

[source generator so for example](https://youtu.be/FDFGfYJPLOc?t=00h10m49s)

[in this case um abusing partial classes](https://youtu.be/FDFGfYJPLOc?t=00h10m51s)

[which is one of the things that um](https://youtu.be/FDFGfYJPLOc?t=00h10m54s)

[they were really designed for before we](https://youtu.be/FDFGfYJPLOc?t=00h10m58s)

[didn't have source generators but we had](https://youtu.be/FDFGfYJPLOc?t=00h11m00s)

[other things that would generate code](https://youtu.be/FDFGfYJPLOc?t=00h11m02s)

[uh but in this case](https://youtu.be/FDFGfYJPLOc?t=00h11m04s)

[if we intentionally say okay we're gonna](https://youtu.be/FDFGfYJPLOc?t=00h11m07s)

[go hunting for partial classes that that](https://youtu.be/FDFGfYJPLOc?t=00h11m09s)

[are decorated with an attribute](https://youtu.be/FDFGfYJPLOc?t=00h11m11s)

[let's gen this code up](https://youtu.be/FDFGfYJPLOc?t=00h11m12s)

[away we go the other thing i'm hoping to](https://youtu.be/FDFGfYJPLOc?t=00h11m14s)

[be able to do is you'll note i wrote](https://youtu.be/FDFGfYJPLOc?t=00h11m16s)

[this same](https://youtu.be/FDFGfYJPLOc?t=00h11m19s)

[same test with ms test](https://youtu.be/FDFGfYJPLOc?t=00h11m20s)

[i wrote the same thing with n unit and i](https://youtu.be/FDFGfYJPLOc?t=00h11m22s)

[wrote the same thing with x unit because](https://youtu.be/FDFGfYJPLOc?t=00h11m25s)

[those are kind of the big](https://youtu.be/FDFGfYJPLOc?t=00h11m27s)

[big three when it comes to unit testing](https://youtu.be/FDFGfYJPLOc?t=00h11m29s)

[frameworks if you cover those three](https://youtu.be/FDFGfYJPLOc?t=00h11m30s)

[you'll have covered like 95 percent of](https://youtu.be/FDFGfYJPLOc?t=00h11m32s)

[what people use for testing frameworks](https://youtu.be/FDFGfYJPLOc?t=00h11m35s)

[um but i was figuring for this generator](https://youtu.be/FDFGfYJPLOc?t=00h11m39s)

[what i'm really looking to generate out](https://youtu.be/FDFGfYJPLOc?t=00h11m42s)

[the only thing that are going to be](https://youtu.be/FDFGfYJPLOc?t=00h11m44s)

[test method specific](https://youtu.be/FDFGfYJPLOc?t=00h11m47s)

[is some sort of uh attribute at the top](https://youtu.be/FDFGfYJPLOc?t=00h11m49s)

[and then the assertion calls down here](https://youtu.be/FDFGfYJPLOc?t=00h11m53s)

[and so there's there's technically two](https://youtu.be/FDFGfYJPLOc?t=00h11m57s)

[assertions assert that it throws the](https://youtu.be/FDFGfYJPLOc?t=00h11m58s)

[exception and that a certain things are](https://youtu.be/FDFGfYJPLOc?t=00h12m00s)

[equal the thing to note is that](https://youtu.be/FDFGfYJPLOc?t=00h12m02s)

[um all all of the unit testing](https://youtu.be/FDFGfYJPLOc?t=00h12m06s)

[frameworks a passing test is a test that](https://youtu.be/FDFGfYJPLOc?t=00h12m08s)

[doesn't throw an exception](https://youtu.be/FDFGfYJPLOc?t=00h12m11s)

[that's it a test is deemed passing if it](https://youtu.be/FDFGfYJPLOc?t=00h12m14s)

[doesn't throw i'm going to comment this](https://youtu.be/FDFGfYJPLOc?t=00h12m17s)

[out so that live unit testing can be](https://youtu.be/FDFGfYJPLOc?t=00h12m19s)

[happy again](https://youtu.be/FDFGfYJPLOc?t=00h12m21s)

[so if a test doesn't throw an exception](https://youtu.be/FDFGfYJPLOc?t=00h12m22s)

[it passes](https://youtu.be/FDFGfYJPLOc?t=00h12m24s)

[now what that means is there's](https://youtu.be/FDFGfYJPLOc?t=00h12m26s)

[technically a fourth case i could write](https://youtu.be/FDFGfYJPLOc?t=00h12m27s)

[i could have my generator output one](https://youtu.be/FDFGfYJPLOc?t=00h12m30s)

[that is unit test agnostic](https://youtu.be/FDFGfYJPLOc?t=00h12m32s)

[because](https://youtu.be/FDFGfYJPLOc?t=00h12m35s)

[in all of these cases the assert class](https://youtu.be/FDFGfYJPLOc?t=00h12m36s)

[for the unit testing framework all it](https://youtu.be/FDFGfYJPLOc?t=00h12m39s)

[does is some sort of condition and if](https://youtu.be/FDFGfYJPLOc?t=00h12m40s)

[the condition is met or not met throws](https://youtu.be/FDFGfYJPLOc?t=00h12m43s)

[an exception fail in the test](https://youtu.be/FDFGfYJPLOc?t=00h12m45s)

[and so all of these assert methods are](https://youtu.be/FDFGfYJPLOc?t=00h12m47s)

[just thinly veiled rappers around if](https://youtu.be/FDFGfYJPLOc?t=00h12m50s)

[condition throw exception](https://youtu.be/FDFGfYJPLOc?t=00h12m53s)

[that's it](https://youtu.be/FDFGfYJPLOc?t=00h12m55s)

[now the exception that it throws is](https://youtu.be/FDFGfYJPLOc?t=00h12m56s)

[usually has lots of nice information on](https://youtu.be/FDFGfYJPLOc?t=00h12m58s)

[it kind of gives you a hint about hey](https://youtu.be/FDFGfYJPLOc?t=00h13m00s)

[expected this actually got this what's](https://youtu.be/FDFGfYJPLOc?t=00h13m02s)

[wrong with you](https://youtu.be/FDFGfYJPLOc?t=00h13m04s)

[most of them have friendlier messages](https://youtu.be/FDFGfYJPLOc?t=00h13m06s)

[but that's the idea](https://youtu.be/FDFGfYJPLOc?t=00h13m07s)

[so i could also generate and i've kind](https://youtu.be/FDFGfYJPLOc?t=00h13m09s)

[of contemplated this idea the idea of](https://youtu.be/FDFGfYJPLOc?t=00h13m11s)

[doing like um](https://youtu.be/FDFGfYJPLOc?t=00h13m13s)

[a fourth target that's like unit test](https://youtu.be/FDFGfYJPLOc?t=00h13m16s)

[agnostic](https://youtu.be/FDFGfYJPLOc?t=00h13m18s)

[something that](https://youtu.be/FDFGfYJPLOc?t=00h13m19s)

[where it just writes the if condition](https://youtu.be/FDFGfYJPLOc?t=00h13m20s)

[and throws the exception itself](https://youtu.be/FDFGfYJPLOc?t=00h13m22s)

[totally could work](https://youtu.be/FDFGfYJPLOc?t=00h13m25s)

[totally could work](https://youtu.be/FDFGfYJPLOc?t=00h13m26s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h13m29s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h13m30s)

[the goal is detect](https://youtu.be/FDFGfYJPLOc?t=00h13m31s)

[test classes that have been indicated](https://youtu.be/FDFGfYJPLOc?t=00h13m33s)

[and obviously this thing here is going](https://youtu.be/FDFGfYJPLOc?t=00h13m36s)

[to have to have something like um i](https://youtu.be/FDFGfYJPLOc?t=00h13m37s)

[don't know](https://youtu.be/FDFGfYJPLOc?t=00h13m39s)

[target type](https://youtu.be/FDFGfYJPLOc?t=00h13m41s)

[controller or](https://youtu.be/FDFGfYJPLOc?t=00h13m43s)

[sorry](https://youtu.be/FDFGfYJPLOc?t=00h13m45s)

[type of control it's going to have to](https://youtu.be/FDFGfYJPLOc?t=00h13m46s)

[have something in here to indicate what](https://youtu.be/FDFGfYJPLOc?t=00h13m48s)

[the target type is that we need to](https://youtu.be/FDFGfYJPLOc?t=00h13m50s)

[create](https://youtu.be/FDFGfYJPLOc?t=00h13m52s)

[but after that](https://youtu.be/FDFGfYJPLOc?t=00h13m54s)

[i think we're probably good to go](https://youtu.be/FDFGfYJPLOc?t=00h13m57s)

[probably good to go](https://youtu.be/FDFGfYJPLOc?t=00h14m00s)

[so that's where we're going that's what](https://youtu.be/FDFGfYJPLOc?t=00h14m03s)

[we're going to try to build](https://youtu.be/FDFGfYJPLOc?t=00h14m05s)

[i already got i already got the test](https://youtu.be/FDFGfYJPLOc?t=00h14m07s)

[classes set up so the goal will be as](https://youtu.be/FDFGfYJPLOc?t=00h14m08s)

[soon as this thing can generate a test](https://youtu.be/FDFGfYJPLOc?t=00h14m11s)

[to to generate something that looks like](https://youtu.be/FDFGfYJPLOc?t=00h14m12s)

[this so i'm going to comment this for](https://youtu.be/FDFGfYJPLOc?t=00h14m14s)

[the moment and go back to the original](https://youtu.be/FDFGfYJPLOc?t=00h14m15s)

[but](https://youtu.be/FDFGfYJPLOc?t=00h14m17s)

[typically with source generators as long](https://youtu.be/FDFGfYJPLOc?t=00h14m18s)

[as you can figure out](https://youtu.be/FDFGfYJPLOc?t=00h14m20s)

[what the code looks like that you want](https://youtu.be/FDFGfYJPLOc?t=00h14m22s)

[to to generate](https://youtu.be/FDFGfYJPLOc?t=00h14m23s)

[pretty good pretty good okay so](https://youtu.be/FDFGfYJPLOc?t=00h14m27s)

[automaker has a generators project in](https://youtu.be/FDFGfYJPLOc?t=00h14m30s)

[here already we're not going to leverage](https://youtu.be/FDFGfYJPLOc?t=00h14m32s)

[this](https://youtu.be/FDFGfYJPLOc?t=00h14m34s)

[um this one exists here to generate out](https://youtu.be/FDFGfYJPLOc?t=00h14m35s)

[or i should say this one doesn't get](https://youtu.be/FDFGfYJPLOc?t=00h14m39s)

[bundled with the actual um automarketer](https://youtu.be/FDFGfYJPLOc?t=00h14m40s)

[nuget package](https://youtu.be/FDFGfYJPLOc?t=00h14m43s)

[this one just gets leveraged for](https://youtu.be/FDFGfYJPLOc?t=00h14m44s)

[generating out a bunch of overloads that](https://youtu.be/FDFGfYJPLOc?t=00h14m46s)

[we have](https://youtu.be/FDFGfYJPLOc?t=00h14m48s)

[so we are not going to do that we're](https://youtu.be/FDFGfYJPLOc?t=00h14m49s)

[going to create a new project so](https://youtu.be/FDFGfYJPLOc?t=00h14m51s)

[creating a source generator new project](https://youtu.be/FDFGfYJPLOc?t=00h14m55s)

[and all of this is in that docs page](https://youtu.be/FDFGfYJPLOc?t=00h15m00s)

[from above](https://youtu.be/FDFGfYJPLOc?t=00h15m01s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h15m03s)

[i'm just going to save you some trouble](https://youtu.be/FDFGfYJPLOc?t=00h15m04s)

[and we're going to go a little quicker](https://youtu.be/FDFGfYJPLOc?t=00h15m05s)

[okay so the hardest part of any of these](https://youtu.be/FDFGfYJPLOc?t=00h15m06s)

[things naming it i really should have](https://youtu.be/FDFGfYJPLOc?t=00h15m09s)

[thought about this ahead of time so it](https://youtu.be/FDFGfYJPLOc?t=00h15m11s)

[probably should be](https://youtu.be/FDFGfYJPLOc?t=00h15m13s)

[i can probably guess that it's going to](https://youtu.be/FDFGfYJPLOc?t=00h15m15s)

[go there](https://youtu.be/FDFGfYJPLOc?t=00h15m17s)

[yeah we'll call it test generator](https://youtu.be/FDFGfYJPLOc?t=00h15m22s)

[so this is going to end up creating a](https://youtu.be/FDFGfYJPLOc?t=00h15m25s)

[a separate dll that will ultimately need](https://youtu.be/FDFGfYJPLOc?t=00h15m28s)

[to package into the other nuget that](https://youtu.be/FDFGfYJPLOc?t=00h15m30s)

[will be a problem for another day](https://youtu.be/FDFGfYJPLOc?t=00h15m33s)

[okay next thing to note you cannot use](https://youtu.be/FDFGfYJPLOc?t=00h15m34s)

[net 6 or net five or net core three when](https://youtu.be/FDFGfYJPLOc?t=00h15m38s)

[building a source generator](https://youtu.be/FDFGfYJPLOc?t=00h15m41s)

[the reason is because a source](https://youtu.be/FDFGfYJPLOc?t=00h15m42s)

[generators dll has to be loaded by ms](https://youtu.be/FDFGfYJPLOc?t=00h15m44s)

[build when it's running the comp or i](https://youtu.be/FDFGfYJPLOc?t=00h15m47s)

[should not say it must build csc exe](https://youtu.be/FDFGfYJPLOc?t=00h15m49s)

[when it's running the compilation](https://youtu.be/FDFGfYJPLOc?t=00h15m52s)

[which means you are limited in the run](https://youtu.be/FDFGfYJPLOc?t=00h15m54s)

[times](https://youtu.be/FDFGfYJPLOc?t=00h15m56s)

[so net standard 2o is your friend](https://youtu.be/FDFGfYJPLOc?t=00h15m57s)

[okay](https://youtu.be/FDFGfYJPLOc?t=00h16m02s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h16m03s)

[can the generator as well as auto](https://youtu.be/FDFGfYJPLOc?t=00h16m05s)

[automaker see and interact with the](https://youtu.be/FDFGfYJPLOc?t=00h16m06s)

[internal methods that were open for](https://youtu.be/FDFGfYJPLOc?t=00h16m09s)

[tests via internals visible 2.](https://youtu.be/FDFGfYJPLOc?t=00h16m10s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h16m13s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h16m16s)

[yes but they do it in slightly different](https://youtu.be/FDFGfYJPLOc?t=00h16m17s)

[approaches so the](https://youtu.be/FDFGfYJPLOc?t=00h16m20s)

[um auto](https://youtu.be/FDFGfYJPLOc?t=00h16m22s)

[auto mocker by default and mock](https://youtu.be/FDFGfYJPLOc?t=00h16m24s)

[moq](https://youtu.be/FDFGfYJPLOc?t=00h16m27s)

[will only interact on things that are](https://youtu.be/FDFGfYJPLOc?t=00h16m29s)

[public](https://youtu.be/FDFGfYJPLOc?t=00h16m31s)

[by default](https://youtu.be/FDFGfYJPLOc?t=00h16m32s)

[however](https://youtu.be/FDFGfYJPLOc?t=00h16m33s)

[there are a bunch of methods on here](https://youtu.be/FDFGfYJPLOc?t=00h16m34s)

[that have](https://youtu.be/FDFGfYJPLOc?t=00h16m37s)

[used](https://youtu.be/FDFGfYJPLOc?t=00h16m38s)

[private or what is it private](https://youtu.be/FDFGfYJPLOc?t=00h16m41s)

[something or another](https://youtu.be/FDFGfYJPLOc?t=00h16m44s)

[enable private](https://youtu.be/FDFGfYJPLOc?t=00h16m46s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h16m48s)

[because the the fallback for these](https://youtu.be/FDFGfYJPLOc?t=00h16m49s)

[things uh for uh auto marker to get into](https://youtu.be/FDFGfYJPLOc?t=00h16m51s)

[like internal stuff or private stuff for](https://youtu.be/FDFGfYJPLOc?t=00h16m55s)

[for practically speaking those are more](https://youtu.be/FDFGfYJPLOc?t=00h16m59s)

[or less the same you may need to set](https://youtu.be/FDFGfYJPLOc?t=00h17m00s)

[enable private um because that just ends](https://youtu.be/FDFGfYJPLOc?t=00h17m03s)

[up getting passed in as the](https://youtu.be/FDFGfYJPLOc?t=00h17m05s)

[binding flags in some reflection calls](https://youtu.be/FDFGfYJPLOc?t=00h17m08s)

[in order to get access to things now if](https://youtu.be/FDFGfYJPLOc?t=00h17m10s)

[you have internals visible 2 set up into](https://youtu.be/FDFGfYJPLOc?t=00h17m12s)

[your test project you probably won't](https://youtu.be/FDFGfYJPLOc?t=00h17m14s)

[need this for internal members](https://youtu.be/FDFGfYJPLOc?t=00h17m17s)

[again](https://youtu.be/FDFGfYJPLOc?t=00h17m20s)

[i'm putting a little star there because](https://youtu.be/FDFGfYJPLOc?t=00h17m21s)

[it'll somewhat depend on your use case](https://youtu.be/FDFGfYJPLOc?t=00h17m23s)

[when you set internals visible to](https://youtu.be/FDFGfYJPLOc?t=00h17m26s)

[that typically enables your unit test](https://youtu.be/FDFGfYJPLOc?t=00h17m28s)

[project to interact with internal](https://youtu.be/FDFGfYJPLOc?t=00h17m30s)

[members](https://youtu.be/FDFGfYJPLOc?t=00h17m33s)

[as though they were public](https://youtu.be/FDFGfYJPLOc?t=00h17m34s)

[as far as source generators source](https://youtu.be/FDFGfYJPLOc?t=00h17m38s)

[generators get to view](https://youtu.be/FDFGfYJPLOc?t=00h17m40s)

[the the code in the same way that the](https://youtu.be/FDFGfYJPLOc?t=00h17m43s)

[compiler does when it compiles your](https://youtu.be/FDFGfYJPLOc?t=00h17m45s)

[project so protection modifiers that's](https://youtu.be/FDFGfYJPLOc?t=00h17m47s)

[not an issue](https://youtu.be/FDFGfYJPLOc?t=00h17m49s)

[um what are you squawking about oh](https://youtu.be/FDFGfYJPLOc?t=00h17m51s)

[uh also mildly obnoxious](https://youtu.be/FDFGfYJPLOc?t=00h17m54s)

[this thing has](https://youtu.be/FDFGfYJPLOc?t=00h17m57s)

[a](https://youtu.be/FDFGfYJPLOc?t=00h17m59s)

[lot or this project has](https://youtu.be/FDFGfYJPLOc?t=00h18m00s)

[a lot of static analysis turned on and](https://youtu.be/FDFGfYJPLOc?t=00h18m03s)

[it's really hard to mess stuff up](https://youtu.be/FDFGfYJPLOc?t=00h18m05s)

[okay so uh next step and we can kind of](https://youtu.be/FDFGfYJPLOc?t=00h18m07s)

[just poke off of this generator we need](https://youtu.be/FDFGfYJPLOc?t=00h18m10s)

[a class and then more importantly we](https://youtu.be/FDFGfYJPLOc?t=00h18m12s)

[need it to derive from this i source](https://youtu.be/FDFGfYJPLOc?t=00h18m14s)

[generator but in order to have that type](https://youtu.be/FDFGfYJPLOc?t=00h18m16s)

[we need this nuget package so we're just](https://youtu.be/FDFGfYJPLOc?t=00h18m19s)

[going to steal it](https://youtu.be/FDFGfYJPLOc?t=00h18m21s)

[so i could do add new get package or i](https://youtu.be/FDFGfYJPLOc?t=00h18m24s)

[could just paste and then just for not](https://youtu.be/FDFGfYJPLOc?t=00h18m26s)

[breaking the ci](https://youtu.be/FDFGfYJPLOc?t=00h18m28s)

[we're gonna set is packable false](https://youtu.be/FDFGfYJPLOc?t=00h18m30s)

[because ultimately when this](https://youtu.be/FDFGfYJPLOc?t=00h18m33s)

[when we're doing the packing for this](https://youtu.be/FDFGfYJPLOc?t=00h18m35s)

[we're gonna have to do some fancy stuff](https://youtu.be/FDFGfYJPLOc?t=00h18m37s)

[so for now we're just packable falls](https://youtu.be/FDFGfYJPLOc?t=00h18m38s)

[okay and then we will grab this](https://youtu.be/FDFGfYJPLOc?t=00h18m41s)

[doohickey come down here](https://youtu.be/FDFGfYJPLOc?t=00h18m44s)

[and we'll call this](https://youtu.be/FDFGfYJPLOc?t=00h18m47s)

[test](https://youtu.be/FDFGfYJPLOc?t=00h18m49s)

[generator oh i shouldn't have](https://youtu.be/FDFGfYJPLOc?t=00h18m50s)

[uh unit test](https://youtu.be/FDFGfYJPLOc?t=00h18m54s)

[source generator](https://youtu.be/FDFGfYJPLOc?t=00h18m58s)

[yeah we'll do something like that paste](https://youtu.be/FDFGfYJPLOc?t=00h19m01s)

[and then i need](https://youtu.be/FDFGfYJPLOc?t=00h19m03s)

[that interface and](https://youtu.be/FDFGfYJPLOc?t=00h19m06s)

[that attribute](https://youtu.be/FDFGfYJPLOc?t=00h19m08s)

[and then implement interface](https://youtu.be/FDFGfYJPLOc?t=00h19m12s)

[and just like that we got a source](https://youtu.be/FDFGfYJPLOc?t=00h19m15s)

[generator](https://youtu.be/FDFGfYJPLOc?t=00h19m17s)

[okay not not really not actually done so](https://youtu.be/FDFGfYJPLOc?t=00h19m19s)

[first thing we're going to do is get rid](https://youtu.be/FDFGfYJPLOc?t=00h19m21s)

[of the throwing](https://youtu.be/FDFGfYJPLOc?t=00h19m23s)

[and now we're going to add in oh we're](https://youtu.be/FDFGfYJPLOc?t=00h19m24s)

[going to fix this guy up](https://youtu.be/FDFGfYJPLOc?t=00h19m26s)

[boom boom okay now](https://youtu.be/FDFGfYJPLOc?t=00h19m31s)

[normally uh source generators would get](https://youtu.be/FDFGfYJPLOc?t=00h19m34s)

[packaged into a new get package and they](https://youtu.be/FDFGfYJPLOc?t=00h19m36s)

[will get if you package them up](https://youtu.be/FDFGfYJPLOc?t=00h19m39s)

[appropriately into your nuget package](https://youtu.be/FDFGfYJPLOc?t=00h19m41s)

[they automatically will show up](https://youtu.be/FDFGfYJPLOc?t=00h19m43s)

[underneath this analyzer section when](https://youtu.be/FDFGfYJPLOc?t=00h19m45s)

[you reference the nuget package so](https://youtu.be/FDFGfYJPLOc?t=00h19m48s)

[you'll know by default](https://youtu.be/FDFGfYJPLOc?t=00h19m49s)

[microsoft has a bunch that you're](https://youtu.be/FDFGfYJPLOc?t=00h19m51s)

[getting so secretly you've already been](https://youtu.be/FDFGfYJPLOc?t=00h19m53s)

[using](https://youtu.be/FDFGfYJPLOc?t=00h19m56s)

[analyzers](https://youtu.be/FDFGfYJPLOc?t=00h19m58s)

[and a source generator](https://youtu.be/FDFGfYJPLOc?t=00h19m59s)

[kind of falls into the same same bucket](https://youtu.be/FDFGfYJPLOc?t=00h20m01s)

[in a lot of cases so but for what we](https://youtu.be/FDFGfYJPLOc?t=00h20m03s)

[want to do is we want to actually](https://youtu.be/FDFGfYJPLOc?t=00h20m06s)

[reference this source generator in my](https://youtu.be/FDFGfYJPLOc?t=00h20m08s)

[unit test projects because ultimately](https://youtu.be/FDFGfYJPLOc?t=00h20m11s)

[the generator needs to be referenced by](https://youtu.be/FDFGfYJPLOc?t=00h20m14s)

[the project in which you want to](https://youtu.be/FDFGfYJPLOc?t=00h20m16s)

[generate code into](https://youtu.be/FDFGfYJPLOc?t=00h20m18s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h20m21s)

[so if we look here](https://youtu.be/FDFGfYJPLOc?t=00h20m22s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h20m25s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h20m26s)

[this is the magical thing that you need](https://youtu.be/FDFGfYJPLOc?t=00h20m28s)

[so it is a regular project reference](https://youtu.be/FDFGfYJPLOc?t=00h20m30s)

[with this output item type of analyzer](https://youtu.be/FDFGfYJPLOc?t=00h20m34s)

[so for example if i come in here and i](https://youtu.be/FDFGfYJPLOc?t=00h20m37s)

[just do dependencies add project](https://youtu.be/FDFGfYJPLOc?t=00h20m40s)

[reference](https://youtu.be/FDFGfYJPLOc?t=00h20m42s)

[and i do do](https://youtu.be/FDFGfYJPLOc?t=00h20m43s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h20m45s)

[test generator](https://youtu.be/FDFGfYJPLOc?t=00h20m46s)

[boom](https://youtu.be/FDFGfYJPLOc?t=00h20m49s)

[if we look at this guy here](https://youtu.be/FDFGfYJPLOc?t=00h20m50s)

[you'll see it's just done a regular](https://youtu.be/FDFGfYJPLOc?t=00h20m53s)

[uh project reference but in reality what](https://youtu.be/FDFGfYJPLOc?t=00h20m56s)

[we want](https://youtu.be/FDFGfYJPLOc?t=00h20m59s)

[we can just mutate the other one is](https://youtu.be/FDFGfYJPLOc?t=00h21m00s)

[rather than this we're going to not](https://youtu.be/FDFGfYJPLOc?t=00h21m03s)

[self-close that guy](https://youtu.be/FDFGfYJPLOc?t=00h21m05s)

[we will need the output item type of](https://youtu.be/FDFGfYJPLOc?t=00h21m08s)

[analyzer set and then in this case it](https://youtu.be/FDFGfYJPLOc?t=00h21m10s)

[really doesn't matter whether we](https://youtu.be/FDFGfYJPLOc?t=00h21m12s)

[reference the output assembly](https://youtu.be/FDFGfYJPLOc?t=00h21m14s)

[yeah we'll turn it off](https://youtu.be/FDFGfYJPLOc?t=00h21m18s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h21m19s)

[this is the unit test project so it](https://youtu.be/FDFGfYJPLOc?t=00h21m20s)

[really doesn't make a difference but](https://youtu.be/FDFGfYJPLOc?t=00h21m21s)

[we'll do it we'll do it](https://youtu.be/FDFGfYJPLOc?t=00h21m23s)

[appropriately](https://youtu.be/FDFGfYJPLOc?t=00h21m24s)

[so that guy goes there and for now i'm](https://youtu.be/FDFGfYJPLOc?t=00h21m26s)

[just going to pick on ms test we'll](https://youtu.be/FDFGfYJPLOc?t=00h21m28s)

[start small but the intent should be](https://youtu.be/FDFGfYJPLOc?t=00h21m30s)

[that i should be able to toggle this in](https://youtu.be/FDFGfYJPLOc?t=00h21m32s)

[and get all the things working](https://youtu.be/FDFGfYJPLOc?t=00h21m34s)

[all right because this is one we were](https://youtu.be/FDFGfYJPLOc?t=00h21m36s)

[picking on earlier great excellent](https://youtu.be/FDFGfYJPLOc?t=00h21m37s)

[okay](https://youtu.be/FDFGfYJPLOc?t=00h21m40s)

[and now we get to start having fun](https://youtu.be/FDFGfYJPLOc?t=00h21m42s)

[so when writing source generators there](https://youtu.be/FDFGfYJPLOc?t=00h21m45s)

[um this interface is kind of designed to](https://youtu.be/FDFGfYJPLOc?t=00h21m48s)

[give you a really strong hint as to how](https://youtu.be/FDFGfYJPLOc?t=00h21m51s)

[you're supposed to do this](https://youtu.be/FDFGfYJPLOc?t=00h21m55s)

[now this source generator here](https://youtu.be/FDFGfYJPLOc?t=00h21m56s)

[this is an example of doing it the hard](https://youtu.be/FDFGfYJPLOc?t=00h21m59s)

[way and arguably kind of the wrong way](https://youtu.be/FDFGfYJPLOc?t=00h22m01s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h22m04s)

[you'll know this thing doesn't build up](https://youtu.be/FDFGfYJPLOc?t=00h22m04s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h22m07s)

[code normally it builds it up with this](https://youtu.be/FDFGfYJPLOc?t=00h22m09s)

[compilation unit and trying to use the](https://youtu.be/FDFGfYJPLOc?t=00h22m12s)

[rosslyn members to generate out a ton of](https://youtu.be/FDFGfYJPLOc?t=00h22m16s)

[code](https://youtu.be/FDFGfYJPLOc?t=00h22m18s)

[this is the hard way and not actually a](https://youtu.be/FDFGfYJPLOc?t=00h22m20s)

[great way of doing it](https://youtu.be/FDFGfYJPLOc?t=00h22m22s)

[this is a main maintenance nightmare and](https://youtu.be/FDFGfYJPLOc?t=00h22m24s)

[i don't like it](https://youtu.be/FDFGfYJPLOc?t=00h22m26s)

[the other thing is you typically want to](https://youtu.be/FDFGfYJPLOc?t=00h22m29s)

[separate out the](https://youtu.be/FDFGfYJPLOc?t=00h22m30s)

[and in this case there's really not a](https://youtu.be/FDFGfYJPLOc?t=00h22m32s)

[par step so this source generator is](https://youtu.be/FDFGfYJPLOc?t=00h22m34s)

[just generating a bunch of overloads to](https://youtu.be/FDFGfYJPLOc?t=00h22m37s)

[existing methods which is fine but](https://youtu.be/FDFGfYJPLOc?t=00h22m38s)

[you'll note it doesn't do any parsing of](https://youtu.be/FDFGfYJPLOc?t=00h22m41s)

[existing source code it just generates](https://youtu.be/FDFGfYJPLOc?t=00h22m43s)

[some stuff out](https://youtu.be/FDFGfYJPLOc?t=00h22m45s)

[if i go and look at](https://youtu.be/FDFGfYJPLOc?t=00h22m47s)

[one of](https://youtu.be/FDFGfYJPLOc?t=00h22m51s)

[these one of these had my other thingy](https://youtu.be/FDFGfYJPLOc?t=00h22m52s)

[on it](https://youtu.be/FDFGfYJPLOc?t=00h22m56s)

[i think i have it](https://youtu.be/FDFGfYJPLOc?t=00h22m57s)

[yeah that one doesn't have one either i](https://youtu.be/FDFGfYJPLOc?t=00h23m02s)

[really should find one](https://youtu.be/FDFGfYJPLOc?t=00h23m04s)

[oh well i'll just talk through it so](https://youtu.be/FDFGfYJPLOc?t=00h23m06s)

[what building source generators there's](https://youtu.be/FDFGfYJPLOc?t=00h23m09s)

[a general structure that you that you](https://youtu.be/FDFGfYJPLOc?t=00h23m10s)

[want to adhere to for](https://youtu.be/FDFGfYJPLOc?t=00h23m12s)

[good maintainability the pattern should](https://youtu.be/FDFGfYJPLOc?t=00h23m15s)

[look like uh first pass should](https://youtu.be/FDFGfYJPLOc?t=00h23m17s)

[parse the existing uh](https://youtu.be/FDFGfYJPLOc?t=00h23m21s)

[code or syntax tree and give you some](https://youtu.be/FDFGfYJPLOc?t=00h23m24s)

[sort of object model specific to what](https://youtu.be/FDFGfYJPLOc?t=00h23m26s)

[you're doing in our case our parse pass](https://youtu.be/FDFGfYJPLOc?t=00h23m28s)

[is going to basically build us up a list](https://youtu.be/FDFGfYJPLOc?t=00h23m31s)

[of](https://youtu.be/FDFGfYJPLOc?t=00h23m34s)

[test classes and their target types](https://youtu.be/FDFGfYJPLOc?t=00h23m35s)

[next](https://youtu.be/FDFGfYJPLOc?t=00h23m38s)

[you should take that object model that](https://youtu.be/FDFGfYJPLOc?t=00h23m39s)

[you built up](https://youtu.be/FDFGfYJPLOc?t=00h23m41s)

[and the second step should be take that](https://youtu.be/FDFGfYJPLOc?t=00h23m43s)

[object model and write out the source](https://youtu.be/FDFGfYJPLOc?t=00h23m44s)

[code](https://youtu.be/FDFGfYJPLOc?t=00h23m47s)

[don't blur the line between those steps](https://youtu.be/FDFGfYJPLOc?t=00h23m48s)

[otherwise you will quickly run yourself](https://youtu.be/FDFGfYJPLOc?t=00h23m50s)

[into a really hairy maintenance problem](https://youtu.be/FDFGfYJPLOc?t=00h23m52s)

[so if you're looking for something](https://youtu.be/FDFGfYJPLOc?t=00h23m55s)

[that's maintainable two steps](https://youtu.be/FDFGfYJPLOc?t=00h23m56s)

[which is kind of hinted to you](https://youtu.be/FDFGfYJPLOc?t=00h23m59s)

[in these guys so let's go in here and](https://youtu.be/FDFGfYJPLOc?t=00h24m01s)

[take a look so if we go context](https://youtu.be/FDFGfYJPLOc?t=00h24m04s)

[and we go](https://youtu.be/FDFGfYJPLOc?t=00h24m07s)

[where is the](https://youtu.be/FDFGfYJPLOc?t=00h24m09s)

[compilation](https://youtu.be/FDFGfYJPLOc?t=00h24m13s)

[and then i believe this is where we](https://youtu.be/FDFGfYJPLOc?t=00h24m15s)

[start running down the syntax tree of](https://youtu.be/FDFGfYJPLOc?t=00h24m16s)

[finding all the stuff](https://youtu.be/FDFGfYJPLOc?t=00h24m20s)

[yeah](https://youtu.be/FDFGfYJPLOc?t=00h24m24s)

[because we're gonna find all kinds of](https://youtu.be/FDFGfYJPLOc?t=00h24m26s)

[stuff](https://youtu.be/FDFGfYJPLOc?t=00h24m28s)

[okay so we need to uh figure out the](https://youtu.be/FDFGfYJPLOc?t=00h24m29s)

[appropriate way to get the information](https://youtu.be/FDFGfYJPLOc?t=00h24m33s)

[we want because that's always the hard](https://youtu.be/FDFGfYJPLOc?t=00h24m35s)

[part let me look and see because i](https://youtu.be/FDFGfYJPLOc?t=00h24m37s)

[thought i had](https://youtu.be/FDFGfYJPLOc?t=00h24m39s)

[a better sample generator to play with](https://youtu.be/FDFGfYJPLOc?t=00h24m41s)

[i'm trying to look and see where i had](https://youtu.be/FDFGfYJPLOc?t=00h24m44s)

[written one](https://youtu.be/FDFGfYJPLOc?t=00h24m46s)

[i think the xaml test one is reasonable](https://youtu.be/FDFGfYJPLOc?t=00h24m48s)

[but let me](https://youtu.be/FDFGfYJPLOc?t=00h24m51s)

[here i can just pull this over and we](https://youtu.be/FDFGfYJPLOc?t=00h24m53s)

[can look at it here i think this one is](https://youtu.be/FDFGfYJPLOc?t=00h24m54s)

[a more reasonable example](https://youtu.be/FDFGfYJPLOc?t=00h24m58s)

[yeah this one i think is a little bit](https://youtu.be/FDFGfYJPLOc?t=00h25m09s)

[more of a reasonable example](https://youtu.be/FDFGfYJPLOc?t=00h25m11s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h25m14s)

[are you gonna use syntax receiver](https://youtu.be/FDFGfYJPLOc?t=00h25m15s)

[like that guy right there maybe](https://youtu.be/FDFGfYJPLOc?t=00h25m18s)

[yep](https://youtu.be/FDFGfYJPLOc?t=00h25m21s)

[yep yep](https://youtu.be/FDFGfYJPLOc?t=00h25m24s)

[so the the syntax receiver and actually](https://youtu.be/FDFGfYJPLOc?t=00h25m26s)

[we'll just](https://youtu.be/FDFGfYJPLOc?t=00h25m29s)

[so any if anybody's if anybody's](https://youtu.be/FDFGfYJPLOc?t=00h25m30s)

[interested i can share this repo here so](https://youtu.be/FDFGfYJPLOc?t=00h25m32s)

[this is my xaml test library uh](https://youtu.be/FDFGfYJPLOc?t=00h25m35s)

[it has a generator in there](https://youtu.be/FDFGfYJPLOc?t=00h25m38s)

[um it uses the generator because i was](https://youtu.be/FDFGfYJPLOc?t=00h25m40s)

[not going to write all of the classes](https://youtu.be/FDFGfYJPLOc?t=00h25m42s)

[for every wpf](https://youtu.be/FDFGfYJPLOc?t=00h25m44s)

[ui thing out there](https://youtu.be/FDFGfYJPLOc?t=00h25m46s)

[so it comes pre-packaged with the](https://youtu.be/FDFGfYJPLOc?t=00h25m49s)

[generator that rips through all the wpf](https://youtu.be/FDFGfYJPLOc?t=00h25m50s)

[ui classes](https://youtu.be/FDFGfYJPLOc?t=00h25m53s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h25m55s)

[and i believe it how it adheres to the](https://youtu.be/FDFGfYJPLOc?t=00h25m56s)

[the general structure a little bit](https://youtu.be/FDFGfYJPLOc?t=00h25m59s)

[better the other thing that you'll note](https://youtu.be/FDFGfYJPLOc?t=00h26m01s)

[is it is using](https://youtu.be/FDFGfYJPLOc?t=00h26m03s)

[um string builders to build up the](https://youtu.be/FDFGfYJPLOc?t=00h26m05s)

[syntax which is usually a lot more](https://youtu.be/FDFGfYJPLOc?t=00h26m07s)

[maintainable you will note that the fact](https://youtu.be/FDFGfYJPLOc?t=00h26m09s)

[that i'm building up a string](https://youtu.be/FDFGfYJPLOc?t=00h26m11s)

[sort of ties me into a particular](https://youtu.be/FDFGfYJPLOc?t=00h26m13s)

[language](https://youtu.be/FDFGfYJPLOc?t=00h26m16s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h26m17s)

[if you want to add in say vb support or](https://youtu.be/FDFGfYJPLOc?t=00h26m18s)

[similar](https://youtu.be/FDFGfYJPLOc?t=00h26m20s)

[that's something additional that needs](https://youtu.be/FDFGfYJPLOc?t=00h26m21s)

[to be added](https://youtu.be/FDFGfYJPLOc?t=00h26m23s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h26m25s)

[but we can do that](https://youtu.be/FDFGfYJPLOc?t=00h26m26s)

[we can do that i have a slightly](https://youtu.be/FDFGfYJPLOc?t=00h26m28s)

[different generator we can look at for](https://youtu.be/FDFGfYJPLOc?t=00h26m30s)

[doing that one so i am in the wrong one](https://youtu.be/FDFGfYJPLOc?t=00h26m32s)

[i don't want to be an execute i want to](https://youtu.be/FDFGfYJPLOc?t=00h26m34s)

[be an initialize](https://youtu.be/FDFGfYJPLOc?t=00h26m35s)

[test explorer get out of my way okay so](https://youtu.be/FDFGfYJPLOc?t=00h26m37s)

[i'm gonna just shame](https://youtu.be/FDFGfYJPLOc?t=00h26m39s)

[shamefully poach from my other project](https://youtu.be/FDFGfYJPLOc?t=00h26m41s)

[because](https://youtu.be/FDFGfYJPLOc?t=00h26m43s)

[that's what we do](https://youtu.be/FDFGfYJPLOc?t=00h26m44s)

[okay so we'll do that we'll do that](https://youtu.be/FDFGfYJPLOc?t=00h26m46s)

[we'll do that and then we need a syntax](https://youtu.be/FDFGfYJPLOc?t=00h26m48s)

[receiver which is going to look](https://youtu.be/FDFGfYJPLOc?t=00h26m50s)

[something akin to this](https://youtu.be/FDFGfYJPLOc?t=00h26m53s)

[go like this and then](https://youtu.be/FDFGfYJPLOc?t=00h26m57s)

[implement interface](https://youtu.be/FDFGfYJPLOc?t=00h27m00s)

[okay so what this ends up doing because](https://youtu.be/FDFGfYJPLOc?t=00h27m02s)

[you can imagine when we talk about the](https://youtu.be/FDFGfYJPLOc?t=00h27m04s)

[ast or the roslyn syntax tree there's a](https://youtu.be/FDFGfYJPLOc?t=00h27m06s)

[lot of nodes in there and in fact the](https://youtu.be/FDFGfYJPLOc?t=00h27m09s)

[documentation page](https://youtu.be/FDFGfYJPLOc?t=00h27m12s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h27m16s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h27m16s)

[where was the](https://youtu.be/FDFGfYJPLOc?t=00h27m17s)

[did not show it in here i think there](https://youtu.be/FDFGfYJPLOc?t=00h27m19s)

[was syntax analysis](https://youtu.be/FDFGfYJPLOc?t=00h27m21s)

[they have a great picture yeah](https://youtu.be/FDFGfYJPLOc?t=00h27m24s)

[yeah so they there's a section in here](https://youtu.be/FDFGfYJPLOc?t=00h27m26s)

[about understanding syntax trees](https://youtu.be/FDFGfYJPLOc?t=00h27m28s)

[so if you want to understand when you](https://youtu.be/FDFGfYJPLOc?t=00h27m31s)

[write some code in this case when you](https://youtu.be/FDFGfYJPLOc?t=00h27m34s)

[write hello world what does the syntax](https://youtu.be/FDFGfYJPLOc?t=00h27m36s)

[tree of this c sharp code look like in](https://youtu.be/FDFGfYJPLOc?t=00h27m39s)

[terms of what the compiler is going to](https://youtu.be/FDFGfYJPLOc?t=00h27m41s)

[see](https://youtu.be/FDFGfYJPLOc?t=00h27m42s)

[it looks kind of like this](https://youtu.be/FDFGfYJPLOc?t=00h27m44s)

[and as you can imagine that's a lot of](https://youtu.be/FDFGfYJPLOc?t=00h27m46s)

[stuff](https://youtu.be/FDFGfYJPLOc?t=00h27m48s)

[and we could write some like link](https://youtu.be/FDFGfYJPLOc?t=00h27m50s)

[queries or whatnot to go through and](https://youtu.be/FDFGfYJPLOc?t=00h27m51s)

[deal with it but that's a lot of stuff](https://youtu.be/FDFGfYJPLOc?t=00h27m52s)

[i don't want to deal with that that's](https://youtu.be/FDFGfYJPLOc?t=00h27m55s)

[way too much stuff](https://youtu.be/FDFGfYJPLOc?t=00h27m57s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h27m59s)

[uh what you can do instead](https://youtu.be/FDFGfYJPLOc?t=00h28m00s)

[is what's called a visitor pattern](https://youtu.be/FDFGfYJPLOc?t=00h28m02s)

[where](https://youtu.be/FDFGfYJPLOc?t=00h28m05s)

[uh something else walks through the tree](https://youtu.be/FDFGfYJPLOc?t=00h28m06s)

[and just invokes your visitor uh at each](https://youtu.be/FDFGfYJPLOc?t=00h28m08s)

[step of the way](https://youtu.be/FDFGfYJPLOc?t=00h28m11s)

[that is effectively what this little guy](https://youtu.be/FDFGfYJPLOc?t=00h28m14s)

[here is going to do for us](https://youtu.be/FDFGfYJPLOc?t=00h28m16s)

[because he will go visiting and then we](https://youtu.be/FDFGfYJPLOc?t=00h28m18s)

[can just inside of here because on this](https://youtu.be/FDFGfYJPLOc?t=00h28m20s)

[context what is it context node](https://youtu.be/FDFGfYJPLOc?t=00h28m23s)

[it will go and report back to us all of](https://youtu.be/FDFGfYJPLOc?t=00h28m26s)

[the nodes that it um that it visited on](https://youtu.be/FDFGfYJPLOc?t=00h28m29s)

[its on its little journey and you can](https://youtu.be/FDFGfYJPLOc?t=00h28m32s)

[kind of see all the different things in](https://youtu.be/FDFGfYJPLOc?t=00h28m33s)

[here and we can tell it what kind of](https://youtu.be/FDFGfYJPLOc?t=00h28m35s)

[things we're interested in](https://youtu.be/FDFGfYJPLOc?t=00h28m36s)

[so uh](https://youtu.be/FDFGfYJPLOc?t=00h28m40s)

[let's go with let's see if context node](https://youtu.be/FDFGfYJPLOc?t=00h28m42s)

[is](https://youtu.be/FDFGfYJPLOc?t=00h28m46s)

[and then it'll be something syntax](https://youtu.be/FDFGfYJPLOc?t=00h28m47s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h28m50s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h28m52s)

[class syntax or type syntax and maybe](https://youtu.be/FDFGfYJPLOc?t=00h28m53s)

[it's easiest if we just go and grab](https://youtu.be/FDFGfYJPLOc?t=00h28m57s)

[i think i actually have this syntax](https://youtu.be/FDFGfYJPLOc?t=00h29m02s)

[visualizer do i still have this](https://youtu.be/FDFGfYJPLOc?t=00h29m04s)

[installed](https://youtu.be/FDFGfYJPLOc?t=00h29m05s)

[at one point in time i installed](https://youtu.be/FDFGfYJPLOc?t=00h29m07s)

[do not let's go and grab this guy real](https://youtu.be/FDFGfYJPLOc?t=00h29m12s)

[quick because this is probably](https://youtu.be/FDFGfYJPLOc?t=00h29m14s)

[useful](https://youtu.be/FDFGfYJPLOc?t=00h29m17s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h29m18s)

[yeah i i get that syntax trees syntax](https://youtu.be/FDFGfYJPLOc?t=00h29m24s)

[node](https://youtu.be/FDFGfYJPLOc?t=00h29m27s)

[blah blah blah where is the](https://youtu.be/FDFGfYJPLOc?t=00h29m29s)

[i thought it included](https://youtu.be/FDFGfYJPLOc?t=00h29m31s)

[visual studio extension development ah](https://youtu.be/FDFGfYJPLOc?t=00h29m35s)

[it's under view i believe ah thank you](https://youtu.be/FDFGfYJPLOc?t=00h29m37s)

[casey](https://youtu.be/FDFGfYJPLOc?t=00h29m40s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h29m42s)

[what is it called](https://youtu.be/FDFGfYJPLOc?t=00h29m44s)

[i would have expected it under](https://youtu.be/FDFGfYJPLOc?t=00h29m48s)

[server explorer i might not have it](https://youtu.be/FDFGfYJPLOc?t=00h29m53s)

[other windows](https://youtu.be/FDFGfYJPLOc?t=00h29m56s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h29m58s)

[code data](https://youtu.be/FDFGfYJPLOc?t=00h30m01s)

[document outline](https://youtu.be/FDFGfYJPLOc?t=00h30m10s)

[i don't think i have it](https://youtu.be/FDFGfYJPLOc?t=00h30m12s)

[okay](https://youtu.be/FDFGfYJPLOc?t=00h30m15s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h30m19s)

[i must have blown stuff away when i](https://youtu.be/FDFGfYJPLOc?t=00h30m21s)

[redid my machine](https://youtu.be/FDFGfYJPLOc?t=00h30m23s)

[okay come here real quick uh let's do](https://youtu.be/FDFGfYJPLOc?t=00h30m26s)

[this uh](https://youtu.be/FDFGfYJPLOc?t=00h30m28s)

[close some stuff down specifically](https://youtu.be/FDFGfYJPLOc?t=00h30m30s)

[visual studio and then it is the](https://youtu.be/FDFGfYJPLOc?t=00h30m32s)

[extension development](https://youtu.be/FDFGfYJPLOc?t=00h30m35s)

[uh visual studio extension development](https://youtu.be/FDFGfYJPLOc?t=00h30m39s)

[oh look at that](https://youtu.be/FDFGfYJPLOc?t=00h30m41s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h30m43s)

[let's see individual components](https://youtu.be/FDFGfYJPLOc?t=00h30m44s)

[i'm gonna assume it's one of those](https://youtu.be/FDFGfYJPLOc?t=00h30m56s)

[uh do the needful](https://youtu.be/FDFGfYJPLOc?t=00h30m58s)

[and](https://youtu.be/FDFGfYJPLOc?t=00h31m00s)

[we should save and shut down real quick](https://youtu.be/FDFGfYJPLOc?t=00h31m02s)

[okay because i think we're going to want](https://youtu.be/FDFGfYJPLOc?t=00h31m06s)

[to look at this syntax tree the other](https://youtu.be/FDFGfYJPLOc?t=00h31m08s)

[thing is i believe uh sharp labs has it](https://youtu.be/FDFGfYJPLOc?t=00h31m09s)

[as well](https://youtu.be/FDFGfYJPLOc?t=00h31m12s)

[i'm not mistaken](https://youtu.be/FDFGfYJPLOc?t=00h31m14s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h31m15s)

[syntax tree](https://youtu.be/FDFGfYJPLOc?t=00h31m17s)

[show me this](https://youtu.be/FDFGfYJPLOc?t=00h31m19s)

[so for people who haven't seen sharp](https://youtu.be/FDFGfYJPLOc?t=00h31m22s)

[lab.io](https://youtu.be/FDFGfYJPLOc?t=00h31m24s)

[a very worthwhile tool](https://youtu.be/FDFGfYJPLOc?t=00h31m25s)

[uh assuming it's gonna launch](https://youtu.be/FDFGfYJPLOc?t=00h31m29s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h31m35s)

[are we are we going](https://youtu.be/FDFGfYJPLOc?t=00h31m42s)

[to you can load](https://youtu.be/FDFGfYJPLOc?t=00h31m44s)

[blue](https://youtu.be/FDFGfYJPLOc?t=00h31m48s)

[i often use this to check](https://youtu.be/FDFGfYJPLOc?t=00h31m50s)

[um like il related stuff for boxing](https://youtu.be/FDFGfYJPLOc?t=00h31m53s)

[really there we go](https://youtu.be/FDFGfYJPLOc?t=00h31m56s)

[syntax tree show to me there we are see](https://youtu.be/FDFGfYJPLOc?t=00h31m58s)

[that's what we're going for see this is](https://youtu.be/FDFGfYJPLOc?t=00h32m01s)

[what we want this is what we want](https://youtu.be/FDFGfYJPLOc?t=00h32m03s)

[okay um](https://youtu.be/FDFGfYJPLOc?t=00h32m07s)

[save your workflow](https://youtu.be/FDFGfYJPLOc?t=00h32m09s)

[sure](https://youtu.be/FDFGfYJPLOc?t=00h32m14s)

[ssh agent is apparently running have at](https://youtu.be/FDFGfYJPLOc?t=00h32m15s)

[it](https://youtu.be/FDFGfYJPLOc?t=00h32m17s)

[so we can grab this guy here and we can](https://youtu.be/FDFGfYJPLOc?t=00h32m18s)

[imagine that this is going to look like](https://youtu.be/FDFGfYJPLOc?t=00h32m21s)

[something like public class](https://youtu.be/FDFGfYJPLOc?t=00h32m23s)

[uh controller tests](https://youtu.be/FDFGfYJPLOc?t=00h32m26s)

[and then this is going to be something](https://youtu.be/FDFGfYJPLOc?t=00h32m29s)

[like](https://youtu.be/FDFGfYJPLOc?t=00h32m31s)

[test method and you'll note even though](https://youtu.be/FDFGfYJPLOc?t=00h32m32s)

[i don't have](https://youtu.be/FDFGfYJPLOc?t=00h32m35s)

[any using statement for this it the the](https://youtu.be/FDFGfYJPLOc?t=00h32m36s)

[syntax tree still is able to parse so](https://youtu.be/FDFGfYJPLOc?t=00h32m40s)

[anything that's valid c-sharp syntax](https://youtu.be/FDFGfYJPLOc?t=00h32m42s)

[the syntax tree can figure out what it](https://youtu.be/FDFGfYJPLOc?t=00h32m45s)

[is](https://youtu.be/FDFGfYJPLOc?t=00h32m47s)

[even if it doesn't know](https://youtu.be/FDFGfYJPLOc?t=00h32m48s)

[how to resolve this to a particular type](https://youtu.be/FDFGfYJPLOc?t=00h32m50s)

[you can see it gets all the way down](https://youtu.be/FDFGfYJPLOc?t=00h32m56s)

[attribute list](https://youtu.be/FDFGfYJPLOc?t=00h32m58s)

[so in order to pull the test thing it's](https://youtu.be/FDFGfYJPLOc?t=00h33m00s)

[going to look so i guess in our case](https://youtu.be/FDFGfYJPLOc?t=00h33m02s)

[what we're going to have is something](https://youtu.be/FDFGfYJPLOc?t=00h33m04s)

[more like this](https://youtu.be/FDFGfYJPLOc?t=00h33m05s)

[where it is](https://youtu.be/FDFGfYJPLOc?t=00h33m06s)

[um auto marker](https://youtu.be/FDFGfYJPLOc?t=00h33m08s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h33m10s)

[gen test](https://youtu.be/FDFGfYJPLOc?t=00h33m11s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h33m14s)

[type](https://youtu.be/FDFGfYJPLOc?t=00h33m15s)

[type of my type](https://youtu.be/FDFGfYJPLOc?t=00h33m17s)

[so in our case we are looking for a](https://youtu.be/FDFGfYJPLOc?t=00h33m24s)

[class declaration and then pull off the](https://youtu.be/FDFGfYJPLOc?t=00h33m27s)

[attribute list](https://youtu.be/FDFGfYJPLOc?t=00h33m29s)

[off of that class definition we will be](https://youtu.be/FDFGfYJPLOc?t=00h33m31s)

[looking for an attribute that has a](https://youtu.be/FDFGfYJPLOc?t=00h33m33s)

[name that matches whatever identifier we](https://youtu.be/FDFGfYJPLOc?t=00h33m36s)

[give it](https://youtu.be/FDFGfYJPLOc?t=00h33m39s)

[and then inside of that we will be](https://youtu.be/FDFGfYJPLOc?t=00h33m41s)

[looking for an argument list](https://youtu.be/FDFGfYJPLOc?t=00h33m42s)

[to pull open the](https://youtu.be/FDFGfYJPLOc?t=00h33m44s)

[little type of guy](https://youtu.be/FDFGfYJPLOc?t=00h33m47s)

[seems simple](https://youtu.be/FDFGfYJPLOc?t=00h33m50s)

[okay](https://youtu.be/FDFGfYJPLOc?t=00h33m51s)

[all that work to install it we may end](https://youtu.be/FDFGfYJPLOc?t=00h33m55s)

[up just sticking with this because this](https://youtu.be/FDFGfYJPLOc?t=00h33m56s)

[is rather convenient](https://youtu.be/FDFGfYJPLOc?t=00h33m58s)

[i will say i do love sharp lab](https://youtu.be/FDFGfYJPLOc?t=00h34m06s)

[um the other nice part is um sharp lab](https://youtu.be/FDFGfYJPLOc?t=00h34m09s)

[as you can see updates quite](https://youtu.be/FDFGfYJPLOc?t=00h34m12s)

[consistently especially with like](https://youtu.be/FDFGfYJPLOc?t=00h34m14s)

[feature branches](https://youtu.be/FDFGfYJPLOc?t=00h34m16s)

[so you if there is a](https://youtu.be/FDFGfYJPLOc?t=00h34m18s)

[like a preview feature you want to uh](https://youtu.be/FDFGfYJPLOc?t=00h34m20s)

[play with and try](https://youtu.be/FDFGfYJPLOc?t=00h34m23s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h34m24s)

[you can get in there and test them](https://youtu.be/FDFGfYJPLOc?t=00h34m28s)

[uh i just realized and remembered why i](https://youtu.be/FDFGfYJPLOc?t=00h34m30s)

[moved away from the syntax receiver](https://youtu.be/FDFGfYJPLOc?t=00h34m32s)

[why is that casey](https://youtu.be/FDFGfYJPLOc?t=00h34m34s)

[painful](https://youtu.be/FDFGfYJPLOc?t=00h34m40s)

[difficult and i already forgot my type](https://youtu.be/FDFGfYJPLOc?t=00h34m41s)

[that i was targeting](https://youtu.be/FDFGfYJPLOc?t=00h34m43s)

[uh i am looking for](https://youtu.be/FDFGfYJPLOc?t=00h34m44s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h34m46s)

[declaration](https://youtu.be/FDFGfYJPLOc?t=00h34m47s)

[oh okay](https://youtu.be/FDFGfYJPLOc?t=00h34m55s)

[build your things](https://youtu.be/FDFGfYJPLOc?t=00h34m57s)

[have fun](https://youtu.be/FDFGfYJPLOc?t=00h34m59s)

[go hunting](https://youtu.be/FDFGfYJPLOc?t=00h35m07s)

[uh what is the](https://youtu.be/FDFGfYJPLOc?t=00h35m10s)

[what is the type](https://youtu.be/FDFGfYJPLOc?t=00h35m12s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h35m14s)

[because this is going to be](https://youtu.be/FDFGfYJPLOc?t=00h35m15s)

[we can go hunting it by fully qualified](https://youtu.be/FDFGfYJPLOc?t=00h35m18s)

[namespace](https://youtu.be/FDFGfYJPLOc?t=00h35m20s)

[qualified](https://youtu.be/FDFGfYJPLOc?t=00h35m22s)

[uh let's see c sharp](https://youtu.be/FDFGfYJPLOc?t=00h35m25s)

[and then it'll be syntax](https://youtu.be/FDFGfYJPLOc?t=00h35m29s)

[and then it'll be analysis of the](https://youtu.be/FDFGfYJPLOc?t=00h35m31s)

[project](https://youtu.be/FDFGfYJPLOc?t=00h35m33s)

[running the analyzer](https://youtu.be/FDFGfYJPLOc?t=00h35m35s)

[oh does yours not need to look at the](https://youtu.be/FDFGfYJPLOc?t=00h35m38s)

[syntax tree and instead you need to work](https://youtu.be/FDFGfYJPLOc?t=00h35m40s)

[look at the project](https://youtu.be/FDFGfYJPLOc?t=00h35m43s)

[analysis of a project outside of the](https://youtu.be/FDFGfYJPLOc?t=00h35m47s)

[project running the analyzer ah](https://youtu.be/FDFGfYJPLOc?t=00h35m50s)

[you want to look into something](https://youtu.be/FDFGfYJPLOc?t=00h35m53s)

[more interesting okay](https://youtu.be/FDFGfYJPLOc?t=00h35m56s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h35m59s)

[what casey's talking about sounds](https://youtu.be/FDFGfYJPLOc?t=00h36m00s)

[interesting](https://youtu.be/FDFGfYJPLOc?t=00h36m02s)

[i've conned him into uh](https://youtu.be/FDFGfYJPLOc?t=00h36m03s)

[working on it with me](https://youtu.be/FDFGfYJPLOc?t=00h36m06s)

[probably on my stream probably soon](https://youtu.be/FDFGfYJPLOc?t=00h36m08s)

[right](https://youtu.be/FDFGfYJPLOc?t=00h36m12s)

[uh class](https://youtu.be/FDFGfYJPLOc?t=00h36m14s)

[declaration okay so we'll start here](https://youtu.be/FDFGfYJPLOc?t=00h36m16s)

[we want to find a thing that's a class](https://youtu.be/FDFGfYJPLOc?t=00h36m19s)

[declaration](https://youtu.be/FDFGfYJPLOc?t=00h36m21s)

[uh and then let's do this and](https://youtu.be/FDFGfYJPLOc?t=00h36m23s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h36m27s)

[because we cannot we can actually output](https://youtu.be/FDFGfYJPLOc?t=00h36m28s)

[errors and whatnot so we're gonna come](https://youtu.be/FDFGfYJPLOc?t=00h36m29s)

[in here for the syntax receiver and](https://youtu.be/FDFGfYJPLOc?t=00h36m31s)

[we're gonna just do uh](https://youtu.be/FDFGfYJPLOc?t=00h36m33s)

[put you in your own own file for a](https://youtu.be/FDFGfYJPLOc?t=00h36m35s)

[moment](https://youtu.be/FDFGfYJPLOc?t=00h36m37s)

[uh okay so we want to look for if it is](https://youtu.be/FDFGfYJPLOc?t=00h36m40s)

[partial or not](https://youtu.be/FDFGfYJPLOc?t=00h36m43s)

[so let's see how do we do that check](https://youtu.be/FDFGfYJPLOc?t=00h36m45s)

[so partial](https://youtu.be/FDFGfYJPLOc?t=00h36m48s)

[so where does that end up showing up](https://youtu.be/FDFGfYJPLOc?t=00h36m51s)

[so under the](https://youtu.be/FDFGfYJPLOc?t=00h36m54s)

[goes underneath the class partial](https://youtu.be/FDFGfYJPLOc?t=00h36m58s)

[keyword](https://youtu.be/FDFGfYJPLOc?t=00h37m00s)

[okay so i'm looking for a](https://youtu.be/FDFGfYJPLOc?t=00h37m04s)

[partial keyword underneath the class](https://youtu.be/FDFGfYJPLOc?t=00h37m06s)

[declaration okay](https://youtu.be/FDFGfYJPLOc?t=00h37m08s)

[class declaration something about](https://youtu.be/FDFGfYJPLOc?t=00h37m11s)

[partial](https://youtu.be/FDFGfYJPLOc?t=00h37m13s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h37m14s)

[how do i find your](https://youtu.be/FDFGfYJPLOc?t=00h37m20s)

[modifiers](https://youtu.be/FDFGfYJPLOc?t=00h37m23s)

[it's the modifier list i have a sinking](https://youtu.be/FDFGfYJPLOc?t=00h37m26s)

[suspicion](https://youtu.be/FDFGfYJPLOc?t=00h37m29s)

[it looks like this](https://youtu.be/FDFGfYJPLOc?t=00h37m30s)

[syntax token list okay so lesson one](https://youtu.be/FDFGfYJPLOc?t=00h37m31s)

[debugging a source generator](https://youtu.be/FDFGfYJPLOc?t=00h37m36s)

[these things are notoriously](https://youtu.be/FDFGfYJPLOc?t=00h37m38s)

[pain in the butt to debug](https://youtu.be/FDFGfYJPLOc?t=00h37m40s)

[because in order to debug you actually](https://youtu.be/FDFGfYJPLOc?t=00h37m42s)

[have to attach yourself](https://youtu.be/FDFGfYJPLOc?t=00h37m44s)

[to the compiler while it's compiling](https://youtu.be/FDFGfYJPLOc?t=00h37m47s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h37m51s)

[if you can put yourself in the inception](https://youtu.be/FDFGfYJPLOc?t=00h37m52s)

[mindset that's what's actually](https://youtu.be/FDFGfYJPLOc?t=00h37m54s)

[going to happen here is we are going to](https://youtu.be/FDFGfYJPLOc?t=00h37m56s)

[attach ourselves to it and the easiest](https://youtu.be/FDFGfYJPLOc?t=00h37m58s)

[way is with a debugger launch](https://youtu.be/FDFGfYJPLOc?t=00h37m59s)

[so and actually before i get too carried](https://youtu.be/FDFGfYJPLOc?t=00h38m02s)

[away live unit testing needs to stop](https://youtu.be/FDFGfYJPLOc?t=00h38m06s)

[running](https://youtu.be/FDFGfYJPLOc?t=00h38m08s)

[okay so i'm going to](https://youtu.be/FDFGfYJPLOc?t=00h38m10s)

[do this in a very particular order i'm](https://youtu.be/FDFGfYJPLOc?t=00h38m12s)

[going to rebuild my source generator](https://youtu.be/FDFGfYJPLOc?t=00h38m14s)

[project and then i'm going to rebuild](https://youtu.be/FDFGfYJPLOc?t=00h38m16s)

[the project that is using it keep words](https://youtu.be/FDFGfYJPLOc?t=00h38m19s)

[i hit rebuild not build](https://youtu.be/FDFGfYJPLOc?t=00h38m22s)

[because unfortunately](https://youtu.be/FDFGfYJPLOc?t=00h38m24s)

[ms build tries to be intelligent about](https://youtu.be/FDFGfYJPLOc?t=00h38m26s)

[what's changed and it won't see any](https://youtu.be/FDFGfYJPLOc?t=00h38m28s)

[changed files at least in the project](https://youtu.be/FDFGfYJPLOc?t=00h38m30s)

[being built](https://youtu.be/FDFGfYJPLOc?t=00h38m32s)

[rebuild forces it to always run](https://youtu.be/FDFGfYJPLOc?t=00h38m33s)

[okay so we are so it launched it hit](https://youtu.be/FDFGfYJPLOc?t=00h38m36s)

[that debugger launch and we're going to](https://youtu.be/FDFGfYJPLOc?t=00h38m38s)

[attach with ourselves](https://youtu.be/FDFGfYJPLOc?t=00h38m40s)

[to ourselves which is exciting okay so](https://youtu.be/FDFGfYJPLOc?t=00h38m42s)

[we hit our debugger launch](https://youtu.be/FDFGfYJPLOc?t=00h38m45s)

[and inside of here](https://youtu.be/FDFGfYJPLOc?t=00h38m47s)

[i'm gonna just put a break point](https://youtu.be/FDFGfYJPLOc?t=00h38m50s)

[on this and we'll just see it we'll](https://youtu.be/FDFGfYJPLOc?t=00h38m52s)

[watch this thing get hit so we're gonna](https://youtu.be/FDFGfYJPLOc?t=00h38m53s)

[see this guy get hit a ton](https://youtu.be/FDFGfYJPLOc?t=00h38m55s)

[so node and i think i can do](https://youtu.be/FDFGfYJPLOc?t=00h38m57s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h39m00s)

[node](https://youtu.be/FDFGfYJPLOc?t=00h39m02s)

[there's uh](https://youtu.be/FDFGfYJPLOc?t=00h39m03s)

[kind is probably good enough](https://youtu.be/FDFGfYJPLOc?t=00h39m06s)

[pin](https://youtu.be/FDFGfYJPLOc?t=00h39m08s)

[where did that pin go](https://youtu.be/FDFGfYJPLOc?t=00h39m11s)

[pin there stay there okay so we'll just](https://youtu.be/FDFGfYJPLOc?t=00h39m14s)

[f5 this a couple times and you'll note](https://youtu.be/FDFGfYJPLOc?t=00h39m16s)

[so okay](https://youtu.be/FDFGfYJPLOc?t=00h39m19s)

[now we're we had a using directive](https://youtu.be/FDFGfYJPLOc?t=00h39m20s)

[syntax qualified name syntax](https://youtu.be/FDFGfYJPLOc?t=00h39m22s)

[and we can just keep hitting a bunch of](https://youtu.be/FDFGfYJPLOc?t=00h39m25s)

[these breakpoints we're gonna have five](https://youtu.be/FDFGfYJPLOc?t=00h39m27s)

[okay](https://youtu.be/FDFGfYJPLOc?t=00h39m29s)

[so we got down to our class declaration](https://youtu.be/FDFGfYJPLOc?t=00h39m31s)

[syntax](https://youtu.be/FDFGfYJPLOc?t=00h39m33s)

[we can see because there's only one](https://youtu.be/FDFGfYJPLOc?t=00h39m34s)

[class in this project it's gonna be ours](https://youtu.be/FDFGfYJPLOc?t=00h39m36s)

[which it is huzzah okay let's go let's](https://youtu.be/FDFGfYJPLOc?t=00h39m39s)

[go a little spelunking through this guy](https://youtu.be/FDFGfYJPLOc?t=00h39m42s)

[to figure out where](https://youtu.be/FDFGfYJPLOc?t=00h39m44s)

[where this thing lives because i think](https://youtu.be/FDFGfYJPLOc?t=00h39m46s)

[it was going to be the modifiers](https://youtu.be/FDFGfYJPLOc?t=00h39m48s)

[which it appears to be](https://youtu.be/FDFGfYJPLOc?t=00h39m51s)

[oh this is an eye enumerable visualizer](https://youtu.be/FDFGfYJPLOc?t=00h39m57s)

[got it okay](https://youtu.be/FDFGfYJPLOc?t=00h40m01s)

[less not nearly as cool and not nearly](https://youtu.be/FDFGfYJPLOc?t=00h40m03s)

[as scrollable as one would hope](https://youtu.be/FDFGfYJPLOc?t=00h40m05s)

[okay but it does show that partial is](https://youtu.be/FDFGfYJPLOc?t=00h40m07s)

[one of the options in here](https://youtu.be/FDFGfYJPLOc?t=00h40m10s)

[so inside of the modifiers collection](https://youtu.be/FDFGfYJPLOc?t=00h40m13s)

[there is public and partial](https://youtu.be/FDFGfYJPLOc?t=00h40m16s)

[if i expand out the enumerable](https://youtu.be/FDFGfYJPLOc?t=00h40m18s)

[i can go hunting for the partial](https://youtu.be/FDFGfYJPLOc?t=00h40m20s)

[keywords so to know if it's partial i](https://youtu.be/FDFGfYJPLOc?t=00h40m21s)

[can just look at modifiers and say is](https://youtu.be/FDFGfYJPLOc?t=00h40m24s)

[partial keyword in the modifiers](https://youtu.be/FDFGfYJPLOc?t=00h40m26s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h40m29s)

[if](https://youtu.be/FDFGfYJPLOc?t=00h40m30s)

[class declaration modifiers](https://youtu.be/FDFGfYJPLOc?t=00h40m32s)

[of type](https://youtu.be/FDFGfYJPLOc?t=00h40m35s)

[partial](https://youtu.be/FDFGfYJPLOc?t=00h40m38s)

[keyword](https://youtu.be/FDFGfYJPLOc?t=00h40m40s)

[i think that was right](https://youtu.be/FDFGfYJPLOc?t=00h40m43s)

[using system link](https://youtu.be/FDFGfYJPLOc?t=00h40m45s)

[go here](https://youtu.be/FDFGfYJPLOc?t=00h40m51s)

[oh come on don't don't laugh at me](https://youtu.be/FDFGfYJPLOc?t=00h40m53s)

[it was what it was right syntax token](https://youtu.be/FDFGfYJPLOc?t=00h40m56s)

[oh keyword what is your type](https://youtu.be/FDFGfYJPLOc?t=00h41m00s)

[my](https://youtu.be/FDFGfYJPLOc?t=00h41m05s)

[stupid](https://youtu.be/FDFGfYJPLOc?t=00h41m07s)

[uh what is the actual type of this thing](https://youtu.be/FDFGfYJPLOc?t=00h41m09s)

[uh so immediate window we're just gonna](https://youtu.be/FDFGfYJPLOc?t=00h41m13s)

[we're just gonna do some code](https://youtu.be/FDFGfYJPLOc?t=00h41m15s)

[class declaration modifiers](https://youtu.be/FDFGfYJPLOc?t=00h41m17s)

[select](https://youtu.be/FDFGfYJPLOc?t=00h41m22s)

[x](https://youtu.be/FDFGfYJPLOc?t=00h41m24s)

[x dot get type](https://youtu.be/FDFGfYJPLOc?t=00h41m25s)

[full name](https://youtu.be/FDFGfYJPLOc?t=00h41m29s)

[to array](https://youtu.be/FDFGfYJPLOc?t=00h41m32s)

[show me the names of those things](https://youtu.be/FDFGfYJPLOc?t=00h41m34s)

[ah okay so there you just they're gonna](https://youtu.be/FDFGfYJPLOc?t=00h41m36s)

[be syntax tokens okay](https://youtu.be/FDFGfYJPLOc?t=00h41m38s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h41m40s)

[actually i think that thing is already](https://youtu.be/FDFGfYJPLOc?t=00h41m41s)

[gonna give me back syntax tokens](https://youtu.be/FDFGfYJPLOc?t=00h41m42s)

[so let's go](https://youtu.be/FDFGfYJPLOc?t=00h41m45s)

[any lambda](https://youtu.be/FDFGfYJPLOc?t=00h41m46s)

[uh and this is going to be so if they're](https://youtu.be/FDFGfYJPLOc?t=00h41m49s)

[both syntax tokens what is the thing](https://youtu.be/FDFGfYJPLOc?t=00h41m52s)

[inside of it that lets it be](https://youtu.be/FDFGfYJPLOc?t=00h41m55s)

[syntax token](https://youtu.be/FDFGfYJPLOc?t=00h41m59s)

[something in here knows that it's a](https://youtu.be/FDFGfYJPLOc?t=00h42m09s)

[partial keyword](https://youtu.be/FDFGfYJPLOc?t=00h42m10s)

[structured trivia](https://youtu.be/FDFGfYJPLOc?t=00h42m14s)

[text value text i i really would like to](https://youtu.be/FDFGfYJPLOc?t=00h42m19s)

[not go against](https://youtu.be/FDFGfYJPLOc?t=00h42m22s)

[that if i can](https://youtu.be/FDFGfYJPLOc?t=00h42m26s)

[and something about this thing knows](https://youtu.be/FDFGfYJPLOc?t=00h42m29s)

[what it is](https://youtu.be/FDFGfYJPLOc?t=00h42m32s)

[uh i i think it's value as ugly as that](https://youtu.be/FDFGfYJPLOc?t=00h42m35s)

[is that will work i'm just trying to](https://youtu.be/FDFGfYJPLOc?t=00h42m38s)

[avoid because something here knows that](https://youtu.be/FDFGfYJPLOc?t=00h42m40s)

[it's partial keyword](https://youtu.be/FDFGfYJPLOc?t=00h42m43s)

[i want to know where this partial](https://youtu.be/FDFGfYJPLOc?t=00h42m46s)

[keyword thing is](https://youtu.be/FDFGfYJPLOc?t=00h42m47s)

[uh and i](https://youtu.be/FDFGfYJPLOc?t=00h42m56s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h43m01s)

[token](https://youtu.be/FDFGfYJPLOc?t=00h43m04s)

[okay i kinda wanna](https://youtu.be/FDFGfYJPLOc?t=00h43m08s)

[hang on we're to do this i don't want to](https://youtu.be/FDFGfYJPLOc?t=00h43m10s)

[just go gripping through this thing real](https://youtu.be/FDFGfYJPLOc?t=00h43m12s)

[quick because i'm pretty sure](https://youtu.be/FDFGfYJPLOc?t=00h43m14s)

[syntax](https://youtu.be/FDFGfYJPLOc?t=00h43m18s)

[show all my classes showing the enums](https://youtu.be/FDFGfYJPLOc?t=00h43m24s)

[syntax kind](https://youtu.be/FDFGfYJPLOc?t=00h43m34s)

[is that a is that a thing](https://youtu.be/FDFGfYJPLOc?t=00h43m37s)

[there are kind on here that's giving it](https://youtu.be/FDFGfYJPLOc?t=00h43m40s)

[that](https://youtu.be/FDFGfYJPLOc?t=00h43m42s)

[raw kind](https://youtu.be/FDFGfYJPLOc?t=00h43m45s)

[oh please no](https://youtu.be/FDFGfYJPLOc?t=00h43m47s)

[please no](https://youtu.be/FDFGfYJPLOc?t=00h43m51s)

[as structured trivia has trailing](https://youtu.be/FDFGfYJPLOc?t=00h43m56s)

[trivium](https://youtu.be/FDFGfYJPLOc?t=00h43m59s)

[i'm technically looking at public magic](https://youtu.be/FDFGfYJPLOc?t=00h44m08s)

[numbers much better than magic strings](https://youtu.be/FDFGfYJPLOc?t=00h44m09s)

[yes but those magic numbers i'm pretty](https://youtu.be/FDFGfYJPLOc?t=00h44m11s)

[sure are](https://youtu.be/FDFGfYJPLOc?t=00h44m13s)

[so sentax](https://youtu.be/FDFGfYJPLOc?t=00h44m19s)

[i'm pretty confident if i look here](https://youtu.be/FDFGfYJPLOc?t=00h44m27s)

[ha ha](https://youtu.be/FDFGfYJPLOc?t=00h44m34s)

[gotcha](https://youtu.be/FDFGfYJPLOc?t=00h44m36s)

[gotcha](https://youtu.be/FDFGfYJPLOc?t=00h44m39s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h44m42s)

[x dot](https://youtu.be/FDFGfYJPLOc?t=00h44m44s)

[okay stop](https://youtu.be/FDFGfYJPLOc?t=00h44m47s)

[okay you are confused go away uh x](https://youtu.be/FDFGfYJPLOc?t=00h44m49s)

[dot](https://youtu.be/FDFGfYJPLOc?t=00h44m53s)

[rawkind equals equals](https://youtu.be/FDFGfYJPLOc?t=00h44m55s)

[the int value of syntax kind](https://youtu.be/FDFGfYJPLOc?t=00h44m58s)

[come on it's right there](https://youtu.be/FDFGfYJPLOc?t=00h45m04s)

[um i probably just need this using](https://youtu.be/FDFGfYJPLOc?t=00h45m07s)

[i will get you if i need to](https://youtu.be/FDFGfYJPLOc?t=00h45m10s)

[boom](https://youtu.be/FDFGfYJPLOc?t=00h45m12s)

[using](https://youtu.be/FDFGfYJPLOc?t=00h45m13s)

[syntax kind](https://youtu.be/FDFGfYJPLOc?t=00h45m15s)

[partial keyword](https://youtu.be/FDFGfYJPLOc?t=00h45m18s)

[okay](https://youtu.be/FDFGfYJPLOc?t=00h45m22s)

[so we can we'll probably end up putting](https://youtu.be/FDFGfYJPLOc?t=00h45m23s)

[these ifs together with just an and on](https://youtu.be/FDFGfYJPLOc?t=00h45m25s)

[there for now](https://youtu.be/FDFGfYJPLOc?t=00h45m27s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h45m28s)

[use is kind](https://youtu.be/FDFGfYJPLOc?t=00h45m32s)

[oh look at that okay](https://youtu.be/FDFGfYJPLOc?t=00h45m35s)

[sweet there's an extension method for it](https://youtu.be/FDFGfYJPLOc?t=00h45m42s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h45m46s)

[perfect](https://youtu.be/FDFGfYJPLOc?t=00h45m48s)

[okay](https://youtu.be/FDFGfYJPLOc?t=00h45m49s)

[okay so we're only hunting classes we're](https://youtu.be/FDFGfYJPLOc?t=00h45m51s)

[only hunting partial](https://youtu.be/FDFGfYJPLOc?t=00h45m53s)

[it's probably good enough](https://youtu.be/FDFGfYJPLOc?t=00h45m55s)

[i think](https://youtu.be/FDFGfYJPLOc?t=00h45m58s)

[i think that's probably good enough for](https://youtu.be/FDFGfYJPLOc?t=00h46m00s)

[now so uh let's figure out the model](https://youtu.be/FDFGfYJPLOc?t=00h46m02s)

[that we're going to build up because](https://youtu.be/FDFGfYJPLOc?t=00h46m05s)

[really right now what we need is](https://youtu.be/FDFGfYJPLOc?t=00h46m07s)

[okay we're going to make some](https://youtu.be/FDFGfYJPLOc?t=00h46m13s)

[assumptions](https://youtu.be/FDFGfYJPLOc?t=00h46m13s)

[the target type is only going to have a](https://youtu.be/FDFGfYJPLOc?t=00h46m15s)

[single constructor for the moment](https://youtu.be/FDFGfYJPLOc?t=00h46m16s)

[because i don't want to think about](https://youtu.be/FDFGfYJPLOc?t=00h46m18s)

[multiple constructors](https://youtu.be/FDFGfYJPLOc?t=00h46m20s)

[so we need to have public class](https://youtu.be/FDFGfYJPLOc?t=00h46m22s)

[test class um](https://youtu.be/FDFGfYJPLOc?t=00h46m26s)

[and it needs to be public](https://youtu.be/FDFGfYJPLOc?t=00h46m29s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h46m31s)

[i'm gonna put an object uh](https://youtu.be/FDFGfYJPLOc?t=00h46m36s)

[test](https://youtu.be/FDFGfYJPLOc?t=00h46m38s)

[class type](https://youtu.be/FDFGfYJPLOc?t=00h46m40s)

[right](https://youtu.be/FDFGfYJPLOc?t=00h46m43s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h46m44s)

[public object](https://youtu.be/FDFGfYJPLOc?t=00h46m45s)

[subtype so system under test](https://youtu.be/FDFGfYJPLOc?t=00h46m48s)

[we're just going to go with that for the](https://youtu.be/FDFGfYJPLOc?t=00h46m52s)

[moment](https://youtu.be/FDFGfYJPLOc?t=00h46m54s)

[and](https://youtu.be/FDFGfYJPLOc?t=00h46m57s)

[so if we go class declaration](https://youtu.be/FDFGfYJPLOc?t=00h46m59s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h47m04s)

[let's see identifier](https://youtu.be/FDFGfYJPLOc?t=00h47m05s)

[i](https://youtu.be/FDFGfYJPLOc?t=00h47m09s)

[uh let's go with](https://youtu.be/FDFGfYJPLOc?t=00h47m10s)

[last declaration dot](https://youtu.be/FDFGfYJPLOc?t=00h47m13s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h47m21s)

[what is the resolve the type because](https://youtu.be/FDFGfYJPLOc?t=00h47m22s)

[there is a way to get this thing to](https://youtu.be/FDFGfYJPLOc?t=00h47m25s)

[resolve the type](https://youtu.be/FDFGfYJPLOc?t=00h47m26s)

[as part of this because i want to make](https://youtu.be/FDFGfYJPLOc?t=00h47m28s)

[sure i get this](https://youtu.be/FDFGfYJPLOc?t=00h47m31s)

[i think i end up doing this in my xaml](https://youtu.be/FDFGfYJPLOc?t=00h47m33s)

[test one let me look](https://youtu.be/FDFGfYJPLOc?t=00h47m36s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h47m38s)

[let's see bring it in](https://youtu.be/FDFGfYJPLOc?t=00h47m39s)

[don't laugh at me](https://youtu.be/FDFGfYJPLOc?t=00h47m41s)

[this guy](https://youtu.be/FDFGfYJPLOc?t=00h47m43s)

[that's that's the incantation](https://youtu.be/FDFGfYJPLOc?t=00h47m44s)

[because we want to resolve the](https://youtu.be/FDFGfYJPLOc?t=00h47m47s)

[we no longer want to look at just](https://youtu.be/FDFGfYJPLOc?t=00h47m49s)

[text-based tokens we actually want to](https://youtu.be/FDFGfYJPLOc?t=00h47m52s)

[get the](https://youtu.be/FDFGfYJPLOc?t=00h47m54s)

[actual](https://youtu.be/FDFGfYJPLOc?t=00h47m58s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h47m59s)

[compiler result type](https://youtu.be/FDFGfYJPLOc?t=00h48m00s)

[get type info](https://youtu.be/FDFGfYJPLOc?t=00h48m02s)

[okay let's make sure this is going to](https://youtu.be/FDFGfYJPLOc?t=00h48m06s)

[work with the way we expect paste run](https://youtu.be/FDFGfYJPLOc?t=00h48m07s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h48m12s)

[let's see](https://youtu.be/FDFGfYJPLOc?t=00h48m13s)

[our foo gets paste because](https://youtu.be/FDFGfYJPLOc?t=00h48m16s)

[oh hush](https://youtu.be/FDFGfYJPLOc?t=00h48m20s)

[there so boo dot](https://youtu.be/FDFGfYJPLOc?t=00h48m25s)

[what is on this type info](https://youtu.be/FDFGfYJPLOc?t=00h48m28s)

[uh info](https://youtu.be/FDFGfYJPLOc?t=00h48m32s)

[dot](https://youtu.be/FDFGfYJPLOc?t=00h48m35s)

[type i believe](https://youtu.be/FDFGfYJPLOc?t=00h48m40s)

[oh interesting so that's oh type null](https://youtu.be/FDFGfYJPLOc?t=00h48m45s)

[well that's not going to quite do what i](https://youtu.be/FDFGfYJPLOc?t=00h48m49s)

[want](https://youtu.be/FDFGfYJPLOc?t=00h48m52s)

[i must have to feed it something off of](https://youtu.be/FDFGfYJPLOc?t=00h48m54s)

[the end of this so let's just look at](https://youtu.be/FDFGfYJPLOc?t=00h48m56s)

[this](https://youtu.be/FDFGfYJPLOc?t=00h48m58s)

[uh class will span english parent raw](https://youtu.be/FDFGfYJPLOc?t=00h49m00s)

[kind](https://youtu.be/FDFGfYJPLOc?t=00h49m05s)

[there is a way to resolve this](https://youtu.be/FDFGfYJPLOc?t=00h49m09s)

[type expression syntax class declaration](https://youtu.be/FDFGfYJPLOc?t=00h49m14s)

[syntax](https://youtu.be/FDFGfYJPLOc?t=00h49m17s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h49m22s)

[i think i've probably gotten it to the](https://youtu.be/FDFGfYJPLOc?t=00h49m28s)

[point where it is utterly confused i'm](https://youtu.be/FDFGfYJPLOc?t=00h49m29s)

[gonna restart this guy real quick](https://youtu.be/FDFGfYJPLOc?t=00h49m31s)

[we're gonna just catch it inside of here](https://youtu.be/FDFGfYJPLOc?t=00h49m34s)

[again so once again rebuild](https://youtu.be/FDFGfYJPLOc?t=00h49m35s)

[source generator](https://youtu.be/FDFGfYJPLOc?t=00h49m38s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h49m41s)

[oh this guy is unhappy because i made](https://youtu.be/FDFGfYJPLOc?t=00h49m44s)

[them not knowable so it won't compile](https://youtu.be/FDFGfYJPLOc?t=00h49m47s)

[and test class is probably](https://youtu.be/FDFGfYJPLOc?t=00h49m51s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h49m55s)

[a little ambiguous uh](https://youtu.be/FDFGfYJPLOc?t=00h49m57s)

[generator](https://youtu.be/FDFGfYJPLOc?t=00h50m01s)

[target class sure we'll go with that for](https://youtu.be/FDFGfYJPLOc?t=00h50m03s)

[the moment](https://youtu.be/FDFGfYJPLOc?t=00h50m05s)

[get you out of here](https://youtu.be/FDFGfYJPLOc?t=00h50m06s)

[okay so rebuild this guy](https://youtu.be/FDFGfYJPLOc?t=00h50m08s)

[great rebuild](https://youtu.be/FDFGfYJPLOc?t=00h50m12s)

[target](https://youtu.be/FDFGfYJPLOc?t=00h50m15s)

[to do once again we get the lovely](https://youtu.be/FDFGfYJPLOc?t=00h50m18s)

[just in time debugger we'll use](https://youtu.be/FDFGfYJPLOc?t=00h50m21s)

[ourselves to attach to ourselves](https://youtu.be/FDFGfYJPLOc?t=00h50m23s)

[well f5 in](https://youtu.be/FDFGfYJPLOc?t=00h50m26s)

[i want to look at this did you fail to](https://youtu.be/FDFGfYJPLOc?t=00h50m31s)

[resolve the type again you did](https://youtu.be/FDFGfYJPLOc?t=00h50m34s)

[uh okay so how do i know](https://youtu.be/FDFGfYJPLOc?t=00h50m36s)

[your actual type](https://youtu.be/FDFGfYJPLOc?t=00h50m41s)

[that's your attributes](https://youtu.be/FDFGfYJPLOc?t=00h50m44s)

[kind class declaration that's great](https://youtu.be/FDFGfYJPLOc?t=00h50m48s)

[modifiers](https://youtu.be/FDFGfYJPLOc?t=00h50m52s)

[i'm actually missing where it is](https://youtu.be/FDFGfYJPLOc?t=00h51m01s)

[identifier](https://youtu.be/FDFGfYJPLOc?t=00h51m05s)

[so what is this guy expected to take in](https://youtu.be/FDFGfYJPLOc?t=00h51m11s)

[download source](https://youtu.be/FDFGfYJPLOc?t=00h51m14s)

[uh let's see so it's expected to take in](https://youtu.be/FDFGfYJPLOc?t=00h51m17s)

[a syntax node](https://youtu.be/FDFGfYJPLOc?t=00h51m19s)

[and find the](https://youtu.be/FDFGfYJPLOc?t=00h51m22s)

[type info i i really just want to pull](https://youtu.be/FDFGfYJPLOc?t=00h51m31s)

[the type info to make sure i know what](https://youtu.be/FDFGfYJPLOc?t=00h51m33s)

[the type is](https://youtu.be/FDFGfYJPLOc?t=00h51m35s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h51m39s)

[so](https://youtu.be/FDFGfYJPLOc?t=00h51m41s)

[we gotta figure out one of these guys](https://youtu.be/FDFGfYJPLOc?t=00h51m42s)

[needs to give us](https://youtu.be/FDFGfYJPLOc?t=00h51m44s)

[type info for it](https://youtu.be/FDFGfYJPLOc?t=00h51m48s)

[uh let's come down here what are you](https://youtu.be/FDFGfYJPLOc?t=00h51m52s)

[trying to get the type of i want to get](https://youtu.be/FDFGfYJPLOc?t=00h51m54s)

[the type of the class](https://youtu.be/FDFGfYJPLOc?t=00h51m55s)

[specifically is what i'm looking for](https://youtu.be/FDFGfYJPLOc?t=00h51m57s)

[and i'm not entirely sure what the](https://youtu.be/FDFGfYJPLOc?t=00h52m00s)

[appropriate](https://youtu.be/FDFGfYJPLOc?t=00h52m03s)

[parameter is here off of the class](https://youtu.be/FDFGfYJPLOc?t=00h52m05s)

[declaration](https://youtu.be/FDFGfYJPLOc?t=00h52m07s)

[pass in is it](https://youtu.be/FDFGfYJPLOc?t=00h52m09s)

[and text token to syntax node i i](https://youtu.be/FDFGfYJPLOc?t=00h52m16s)

[realize that](https://youtu.be/FDFGfYJPLOc?t=00h52m19s)

[i mean because i can go context dot node](https://youtu.be/FDFGfYJPLOc?t=00h52m23s)

[but that's the same instance](https://youtu.be/FDFGfYJPLOc?t=00h52m26s)

[yeah and it's not resolving the type](https://youtu.be/FDFGfYJPLOc?t=00h52m29s)

[despite the fact that it should know](https://youtu.be/FDFGfYJPLOc?t=00h52m33s)

[because ultimately when i go to generate](https://youtu.be/FDFGfYJPLOc?t=00h52m36s)

[this thing out i'm going to need to make](https://youtu.be/FDFGfYJPLOc?t=00h52m38s)

[sure that my partial class that i](https://youtu.be/FDFGfYJPLOc?t=00h52m40s)

[generate technically is also going to](https://youtu.be/FDFGfYJPLOc?t=00h52m42s)

[need to have something like](https://youtu.be/FDFGfYJPLOc?t=00h52m44s)

[so the file we generate is going to need](https://youtu.be/FDFGfYJPLOc?t=00h52m47s)

[to have that right at the top as well](https://youtu.be/FDFGfYJPLOc?t=00h52m49s)

[and i probably will generate it with](https://youtu.be/FDFGfYJPLOc?t=00h52m52s)

[older syntax](https://youtu.be/FDFGfYJPLOc?t=00h52m56s)

[more like this](https://youtu.be/FDFGfYJPLOc?t=00h52m59s)

[to be](https://youtu.be/FDFGfYJPLOc?t=00h53m01s)

[just to be](https://youtu.be/FDFGfYJPLOc?t=00h53m02s)

[clear of what we're doing](https://youtu.be/FDFGfYJPLOc?t=00h53m03s)

[believe that's what i want](https://youtu.be/FDFGfYJPLOc?t=00h53m08s)

[but](https://youtu.be/FDFGfYJPLOc?t=00h53m11s)

[so the the type info](https://youtu.be/FDFGfYJPLOc?t=00h53m12s)

[that comes back gives you all of that](https://youtu.be/FDFGfYJPLOc?t=00h53m15s)

[lovely stuff](https://youtu.be/FDFGfYJPLOc?t=00h53m17s)

[and](https://youtu.be/FDFGfYJPLOc?t=00h53m20s)

[i do not](https://youtu.be/FDFGfYJPLOc?t=00h53m21s)

[know how to grab it](https://youtu.be/FDFGfYJPLOc?t=00h53m24s)

[uh let's see](https://youtu.be/FDFGfYJPLOc?t=00h53m26s)

[because this guy goes in here](https://youtu.be/FDFGfYJPLOc?t=00h53m29s)

[i'm just looking at what i did on my](https://youtu.be/FDFGfYJPLOc?t=00h53m36s)

[other source generator as well](https://youtu.be/FDFGfYJPLOc?t=00h53m38s)

[uh try casting the node to a class](https://youtu.be/FDFGfYJPLOc?t=00h53m42s)

[declaration syntax](https://youtu.be/FDFGfYJPLOc?t=00h53m44s)

[kind of like this](https://youtu.be/FDFGfYJPLOc?t=00h53m47s)

[and then pass it into there](https://youtu.be/FDFGfYJPLOc?t=00h53m51s)

[it's kind of what i expected to do but](https://youtu.be/FDFGfYJPLOc?t=00h53m56s)

[for whatever reason this thing is not](https://youtu.be/FDFGfYJPLOc?t=00h53m59s)

[finding it](https://youtu.be/FDFGfYJPLOc?t=00h54m02s)

[and i don't entirely know why](https://youtu.be/FDFGfYJPLOc?t=00h54m04s)

[uh let's see so let's go with](https://youtu.be/FDFGfYJPLOc?t=00h54m10s)

[i'm wondering if it's](https://youtu.be/FDFGfYJPLOc?t=00h54m17s)

[actually the parent](https://youtu.be/FDFGfYJPLOc?t=00h54m19s)

[no](https://youtu.be/FDFGfYJPLOc?t=00h54m23s)

[because it still wants a](https://youtu.be/FDFGfYJPLOc?t=00h54m25s)

[syntax](https://youtu.be/FDFGfYJPLOc?t=00h54m27s)

[even though that thing is there](https://youtu.be/FDFGfYJPLOc?t=00h54m28s)

[file scope namespace declaration syntax](https://youtu.be/FDFGfYJPLOc?t=00h54m31s)

[class declaration get type](https://youtu.be/FDFGfYJPLOc?t=00h54m35s)

[i'm a little hesitant to think](https://youtu.be/FDFGfYJPLOc?t=00h54m41s)

[well so class declaration get type isn't](https://youtu.be/FDFGfYJPLOc?t=00h54m44s)

[going to quite get me what i want](https://youtu.be/FDFGfYJPLOc?t=00h54m46s)

[so if i go get type this is the actual](https://youtu.be/FDFGfYJPLOc?t=00h54m49s)

[method on system object](https://youtu.be/FDFGfYJPLOc?t=00h54m52s)

[so this is going to give me something](https://youtu.be/FDFGfYJPLOc?t=00h54m56s)

[that's you know microsoft code analysis](https://youtu.be/FDFGfYJPLOc?t=00h54m58s)

[bit and what i'm looking to get is](https://youtu.be/FDFGfYJPLOc?t=00h55m02s)

[something that contains namespace](https://youtu.be/FDFGfYJPLOc?t=00h55m04s)

[here](https://youtu.be/FDFGfYJPLOc?t=00h55m07s)

[of controller tests](https://youtu.be/FDFGfYJPLOc?t=00h55m08s)

[which](https://youtu.be/FDFGfYJPLOc?t=00h55m12s)

[is going to be the thing that trips me](https://youtu.be/FDFGfYJPLOc?t=00h55m16s)

[up let me look at this guy what was](https://youtu.be/FDFGfYJPLOc?t=00h55m18s)

[oh that's right he wasn't he wasn't](https://youtu.be/FDFGfYJPLOc?t=00h55m20s)

[inspecting he was just generating](https://youtu.be/FDFGfYJPLOc?t=00h55m22s)

[cheater](https://youtu.be/FDFGfYJPLOc?t=00h55m24s)

[uh if i look here](https://youtu.be/FDFGfYJPLOc?t=00h55m25s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h55m30s)

[it's in here](https://youtu.be/FDFGfYJPLOc?t=00h55m31s)

[because in this one here i end up doing](https://youtu.be/FDFGfYJPLOc?t=00h55m35s)

[something very similar](https://youtu.be/FDFGfYJPLOc?t=00h55m37s)

[where i pull it off of the](https://youtu.be/FDFGfYJPLOc?t=00h55m42s)

[in this case the type argument type](https://youtu.be/FDFGfYJPLOc?t=00h55m45s)

[which is why i was expecting to find](https://youtu.be/FDFGfYJPLOc?t=00h55m48s)

[class declaration with some sort of type](https://youtu.be/FDFGfYJPLOc?t=00h55m52s)

[thingy on here but there's](https://youtu.be/FDFGfYJPLOc?t=00h55m55s)

[let's let's investigate this guy so what](https://youtu.be/FDFGfYJPLOc?t=00h56m01s)

[does he have on](https://youtu.be/FDFGfYJPLOc?t=00h56m03s)

[uh let's just do](https://youtu.be/FDFGfYJPLOc?t=00h56m06s)

[watch window](https://youtu.be/FDFGfYJPLOc?t=00h56m08s)

[hey](https://youtu.be/FDFGfYJPLOc?t=00h56m11s)

[don't have any of them open how about](https://youtu.be/FDFGfYJPLOc?t=00h56m13s)

[locals come on go find it](https://youtu.be/FDFGfYJPLOc?t=00h56m14s)

[any day now](https://youtu.be/FDFGfYJPLOc?t=00h56m19s)

[visual studio](https://youtu.be/FDFGfYJPLOc?t=00h56m23s)

[really](https://youtu.be/FDFGfYJPLOc?t=00h56m27s)

[still can't find it](https://youtu.be/FDFGfYJPLOc?t=00h56m32s)

[okay you are worthless](https://youtu.be/FDFGfYJPLOc?t=00h56m35s)

[windows](https://youtu.be/FDFGfYJPLOc?t=00h56m38s)

[locals is that was that really that hard](https://youtu.be/FDFGfYJPLOc?t=00h56m41s)

[that really had visual studio](https://youtu.be/FDFGfYJPLOc?t=00h56m43s)

[see not hard not hard](https://youtu.be/FDFGfYJPLOc?t=00h56m46s)

[okay we're gonna go splunky](https://youtu.be/FDFGfYJPLOc?t=00h56m48s)

[um](https://youtu.be/FDFGfYJPLOc?t=00h56m51s)

[syntax token class keyword kind text](https://youtu.be/FDFGfYJPLOc?t=00h56m59s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h57m04s)

[raw kind of blah blah blah](https://youtu.be/FDFGfYJPLOc?t=00h57m05s)

[semicolon token](https://youtu.be/FDFGfYJPLOc?t=00h57m11s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h57m16s)

[okay so when in doubt the all-powerful](https://youtu.be/FDFGfYJPLOc?t=00h57m17s)

[being of google knows](https://youtu.be/FDFGfYJPLOc?t=00h57m20s)

[so let's see](https://youtu.be/FDFGfYJPLOc?t=00h57m22s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h57m23s)

[roslyn class](https://youtu.be/FDFGfYJPLOc?t=00h57m24s)

[declaration](https://youtu.be/FDFGfYJPLOc?t=00h57m27s)

[syntax](https://youtu.be/FDFGfYJPLOc?t=00h57m29s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h57m30s)

[type info](https://youtu.be/FDFGfYJPLOc?t=00h57m32s)

[yeah how about](https://youtu.be/FDFGfYJPLOc?t=00h57m34s)

[get type info](https://youtu.be/FDFGfYJPLOc?t=00h57m36s)

[what do we got here](https://youtu.be/FDFGfYJPLOc?t=00h57m42s)

[the syntactic model blah blah blah blah](https://youtu.be/FDFGfYJPLOc?t=00h57m44s)

[blah blah](https://youtu.be/FDFGfYJPLOc?t=00h57m48s)

[the name space is syntactic information](https://youtu.be/FDFGfYJPLOc?t=00h57m51s)

[so you need to get it from the semantic](https://youtu.be/FDFGfYJPLOc?t=00h57m53s)

[model](https://youtu.be/FDFGfYJPLOc?t=00h57m55s)

[model](https://youtu.be/FDFGfYJPLOc?t=00h57m56s)

[get type info cl so what was his cl up](https://youtu.be/FDFGfYJPLOc?t=00h57m57s)

[here](https://youtu.be/FDFGfYJPLOc?t=00h58m00s)

[project documents](https://youtu.be/FDFGfYJPLOc?t=00h58m02s)

[classes](https://youtu.be/FDFGfYJPLOc?t=00h58m04s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h58m13s)

[not helpful](https://youtu.be/FDFGfYJPLOc?t=00h58m14s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=00h58m17s)

[initialize register](https://youtu.be/FDFGfYJPLOc?t=00h58m23s)

[syntax node finding well-known types](https://youtu.be/FDFGfYJPLOc?t=00h58m29s)

[yep finding other types](https://youtu.be/FDFGfYJPLOc?t=00h58m35s)

[we could do it from there but i'd kind](https://youtu.be/FDFGfYJPLOc?t=00h58m42s)

[of like to resolve it not from just a](https://youtu.be/FDFGfYJPLOc?t=00h58m44s)

[string but from something](https://youtu.be/FDFGfYJPLOc?t=00h58m46s)

[known find generic types](https://youtu.be/FDFGfYJPLOc?t=00h58m49s)

[get type of a syntax node](https://youtu.be/FDFGfYJPLOc?t=00h58m51s)

[context semantic model get type and](https://youtu.be/FDFGfYJPLOc?t=00h58m55s)

[phone node](https://youtu.be/FDFGfYJPLOc?t=00h58m57s)

[stop](https://youtu.be/FDFGfYJPLOc?t=00h59m15s)

[that is legitimately exactly what i'm](https://youtu.be/FDFGfYJPLOc?t=00h59m17s)

[doing](https://youtu.be/FDFGfYJPLOc?t=00h59m20s)

[what the heck](https://youtu.be/FDFGfYJPLOc?t=00h59m29s)

[yeah uh that's kind of what i thought i](https://youtu.be/FDFGfYJPLOc?t=00h59m31s)

[was doing](https://youtu.be/FDFGfYJPLOc?t=00h59m34s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h59m39s)

[class declaration syntax](https://youtu.be/FDFGfYJPLOc?t=00h59m47s)

[uh](https://youtu.be/FDFGfYJPLOc?t=00h59m53s)

[syntax node helper](https://youtu.be/FDFGfYJPLOc?t=00h59m54s)

[out namespace](https://youtu.be/FDFGfYJPLOc?t=00h59m56s)

[i get parent syntax so this thing just](https://youtu.be/FDFGfYJPLOc?t=01h00m02s)

[walks up the parent syntax](https://youtu.be/FDFGfYJPLOc?t=01h00m04s)

[looking for a syntax node that matches a](https://youtu.be/FDFGfYJPLOc?t=01h00m08s)

[particular type](https://youtu.be/FDFGfYJPLOc?t=01h00m11s)

[this is literally just walking up](https://youtu.be/FDFGfYJPLOc?t=01h00m15s)

[looking for the name space type that's](https://youtu.be/FDFGfYJPLOc?t=01h00m17s)

[fine that's not what i want](https://youtu.be/FDFGfYJPLOc?t=01h00m19s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h00m21s)

[parent is kind syntax kind class](https://youtu.be/FDFGfYJPLOc?t=01h00m25s)

[declaration](https://youtu.be/FDFGfYJPLOc?t=01h00m27s)

[items](https://youtu.be/FDFGfYJPLOc?t=01h00m32s)

[oh actually you know this is an](https://youtu.be/FDFGfYJPLOc?t=01h00m43s)

[interesting point i don't need it](https://youtu.be/FDFGfYJPLOc?t=01h00m44s)

[per se](https://youtu.be/FDFGfYJPLOc?t=01h00m48s)

[i can gen without it](https://youtu.be/FDFGfYJPLOc?t=01h00m50s)

[i can gen without it](https://youtu.be/FDFGfYJPLOc?t=01h00m55s)

[because what we can do is we can go](https://youtu.be/FDFGfYJPLOc?t=01h00m57s)

[public](https://youtu.be/FDFGfYJPLOc?t=01h01m00s)

[uh string](https://youtu.be/FDFGfYJPLOc?t=01h01m01s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h01m04s)

[noble](https://youtu.be/FDFGfYJPLOc?t=01h01m05s)

[namespace right get set](https://youtu.be/FDFGfYJPLOc?t=01h01m06s)

[and then what we can do is we can just](https://youtu.be/FDFGfYJPLOc?t=01h01m09s)

[do](https://youtu.be/FDFGfYJPLOc?t=01h01m11s)

[class name](https://youtu.be/FDFGfYJPLOc?t=01h01m13s)

[because we we know](https://youtu.be/FDFGfYJPLOc?t=01h01m17s)

[we know something already about this](https://youtu.be/FDFGfYJPLOc?t=01h01m19s)

[specifically that we are inside of a](https://youtu.be/FDFGfYJPLOc?t=01h01m21s)

[test project](https://youtu.be/FDFGfYJPLOc?t=01h01m26s)

[and we are looking for a test class and](https://youtu.be/FDFGfYJPLOc?t=01h01m28s)

[i'm going to be generating alongside](https://youtu.be/FDFGfYJPLOc?t=01h01m30s)

[okay so that we can we can do this](https://youtu.be/FDFGfYJPLOc?t=01h01m32s)

[differently](https://youtu.be/FDFGfYJPLOc?t=01h01m34s)

[okay so](https://youtu.be/FDFGfYJPLOc?t=01h01m35s)

[test](https://youtu.be/FDFGfYJPLOc?t=01h01m40s)

[last name](https://youtu.be/FDFGfYJPLOc?t=01h01m43s)

[gets class declaration](https://youtu.be/FDFGfYJPLOc?t=01h01m45s)

[uh identifier](https://youtu.be/FDFGfYJPLOc?t=01h01m51s)

[yeah i just want text](https://youtu.be/FDFGfYJPLOc?t=01h01m54s)

[do that](https://youtu.be/FDFGfYJPLOc?t=01h01m56s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h01m58s)

[and then what we can do is we can find](https://youtu.be/FDFGfYJPLOc?t=01h02m02s)

[the](https://youtu.be/FDFGfYJPLOc?t=01h02m05s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h02m07s)

[find namespace](https://youtu.be/FDFGfYJPLOc?t=01h02m09s)

[and we can do the same thing where we](https://youtu.be/FDFGfYJPLOc?t=01h02m12s)

[just go where we go walking up and go](https://youtu.be/FDFGfYJPLOc?t=01h02m14s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h02m18s)

[uh ancestors](https://youtu.be/FDFGfYJPLOc?t=01h02m22s)

[then we can go of type](https://youtu.be/FDFGfYJPLOc?t=01h02m31s)

[name space declaration syntax](https://youtu.be/FDFGfYJPLOc?t=01h02m35s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h02m39s)

[first](https://youtu.be/FDFGfYJPLOc?t=01h02m42s)

[to do](https://youtu.be/FDFGfYJPLOc?t=01h02m47s)

[nested namespaces](https://youtu.be/FDFGfYJPLOc?t=01h02m49s)

[they're uncommon but you but they are](https://youtu.be/FDFGfYJPLOc?t=01h02m52s)

[legit](https://youtu.be/FDFGfYJPLOc?t=01h02m54s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h02m56s)

[actually we could we could do this](https://youtu.be/FDFGfYJPLOc?t=01h03m03s)

[i guess this isn't bad right so it](https://youtu.be/FDFGfYJPLOc?t=01h03m06s)

[theoretically the the nested](https://youtu.be/FDFGfYJPLOc?t=01h03m08s)

[uh you were looking for the name well](https://youtu.be/FDFGfYJPLOc?t=01h03m11s)

[i'm looking for both the class name and](https://youtu.be/FDFGfYJPLOc?t=01h03m12s)

[the namespace the name i can figure out](https://youtu.be/FDFGfYJPLOc?t=01h03m14s)

[but i was hoping to pull the type info](https://youtu.be/FDFGfYJPLOc?t=01h03m17s)

[and get the fully qualified name](https://youtu.be/FDFGfYJPLOc?t=01h03m19s)

[yeah and parent we can use because we'll](https://youtu.be/FDFGfYJPLOc?t=01h03m22s)

[go ancestors up but the only the only](https://youtu.be/FDFGfYJPLOc?t=01h03m24s)

[thing i'm somewhat interested in is](https://youtu.be/FDFGfYJPLOc?t=01h03m27s)

[right so i can do](https://youtu.be/FDFGfYJPLOc?t=01h03m29s)

[so this is this is new syntax but](https://youtu.be/FDFGfYJPLOc?t=01h03m31s)

[technically](https://youtu.be/FDFGfYJPLOc?t=01h03m33s)

[this this is the problem with source](https://youtu.be/FDFGfYJPLOc?t=01h03m35s)

[generators is if you're inspecting code](https://youtu.be/FDFGfYJPLOc?t=01h03m36s)

[you have to look at all of them](https://youtu.be/FDFGfYJPLOc?t=01h03m39s)

[this is actually](https://youtu.be/FDFGfYJPLOc?t=01h03m40s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h03m45s)

[valid code as well](https://youtu.be/FDFGfYJPLOc?t=01h03m46s)

[now very few people do this](https://youtu.be/FDFGfYJPLOc?t=01h03m50s)

[yeah i think i'm gonna use ancestors](https://youtu.be/FDFGfYJPLOc?t=01h03m56s)

[though rather than just going against](https://youtu.be/FDFGfYJPLOc?t=01h03m57s)

[parent](https://youtu.be/FDFGfYJPLOc?t=01h03m59s)

[because](https://youtu.be/FDFGfYJPLOc?t=01h04m01s)

[this way i can pick them all up](https://youtu.be/FDFGfYJPLOc?t=01h04m02s)

[so and actually we can handle nested](https://youtu.be/FDFGfYJPLOc?t=01h04m05s)

[name spaces right now or each](https://youtu.be/FDFGfYJPLOc?t=01h04m08s)

[uh let's see](https://youtu.be/FDFGfYJPLOc?t=01h04m11s)

[bar name space in](https://youtu.be/FDFGfYJPLOc?t=01h04m12s)

[disambiguate the keyword](https://youtu.be/FDFGfYJPLOc?t=01h04m18s)

[uh i totally forgot about this name](https://youtu.be/FDFGfYJPLOc?t=01h04m20s)

[spaces that's because no one uses](https://youtu.be/FDFGfYJPLOc?t=01h04m21s)

[the only thing that bothers me is](https://youtu.be/FDFGfYJPLOc?t=01h04m26s)

[there's a lot of consumers of this](https://youtu.be/FDFGfYJPLOc?t=01h04m28s)

[library and i can just about guarantee](https://youtu.be/FDFGfYJPLOc?t=01h04m29s)

[there's going to be somebody where this](https://youtu.be/FDFGfYJPLOc?t=01h04m32s)

[breaks their use case](https://youtu.be/FDFGfYJPLOc?t=01h04m33s)

[because it would be nested namespaces](https://youtu.be/FDFGfYJPLOc?t=01h04m38s)

[for the unit test class](https://youtu.be/FDFGfYJPLOc?t=01h04m41s)

[yuck](https://youtu.be/FDFGfYJPLOc?t=01h04m45s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h04m47s)

[string](https://youtu.be/FDFGfYJPLOc?t=01h04m49s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h04m50s)

[namespace](https://youtu.be/FDFGfYJPLOc?t=01h04m51s)

[declaration gets empty string](https://youtu.be/FDFGfYJPLOc?t=01h04m54s)

[and then what we will do is we will do](https://youtu.be/FDFGfYJPLOc?t=01h04m57s)

[namespace declaration](https://youtu.be/FDFGfYJPLOc?t=01h04m59s)

[uh gets](https://youtu.be/FDFGfYJPLOc?t=01h05m02s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h05m03s)

[see](https://youtu.be/FDFGfYJPLOc?t=01h05m05s)

[namespace dot](https://youtu.be/FDFGfYJPLOc?t=01h05m06s)

[identifier](https://youtu.be/FDFGfYJPLOc?t=01h05m09s)

[what is the what is the magical thing on](https://youtu.be/FDFGfYJPLOc?t=01h05m12s)

[this guy](https://youtu.be/FDFGfYJPLOc?t=01h05m14s)

[yeah download source](https://youtu.be/FDFGfYJPLOc?t=01h05m17s)

[uh yeah i kind of just want the name](https://youtu.be/FDFGfYJPLOc?t=01h05m20s)

[oh it's called name](https://youtu.be/FDFGfYJPLOc?t=01h05m23s)

[well who would have expected this to be](https://youtu.be/FDFGfYJPLOc?t=01h05m25s)

[that](https://youtu.be/FDFGfYJPLOc?t=01h05m27s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h05m29s)

[identifier](https://youtu.be/FDFGfYJPLOc?t=01h05m31s)

[x](https://youtu.be/FDFGfYJPLOc?t=01h05m34s)

[get text](https://youtu.be/FDFGfYJPLOc?t=01h05m35s)

[oop that is that's the source text for](https://youtu.be/FDFGfYJPLOc?t=01h05m38s)

[it which would work](https://youtu.be/FDFGfYJPLOc?t=01h05m40s)

[oh full including its leading and](https://youtu.be/FDFGfYJPLOc?t=01h05m42s)

[trailing trivia](https://youtu.be/FDFGfYJPLOc?t=01h05m45s)

[that's probably good enough](https://youtu.be/FDFGfYJPLOc?t=01h05m47s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h05m51s)

[we're gonna do something mildly clever](https://youtu.be/FDFGfYJPLOc?t=01h06m05s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h06m08s)

[private static i innumerable of](https://youtu.be/FDFGfYJPLOc?t=01h06m10s)

[strings get](https://youtu.be/FDFGfYJPLOc?t=01h06m14s)

[name namespaces](https://youtu.be/FDFGfYJPLOc?t=01h06m16s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h06m18s)

[class declaration syntax](https://youtu.be/FDFGfYJPLOc?t=01h06m20s)

[class declaration](https://youtu.be/FDFGfYJPLOc?t=01h06m23s)

[and then if we do this because i don't](https://youtu.be/FDFGfYJPLOc?t=01h06m26s)

[want to deal with figuring out how to](https://youtu.be/FDFGfYJPLOc?t=01h06m28s)

[put things together](https://youtu.be/FDFGfYJPLOc?t=01h06m30s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h06m32s)

[so i'm gonna cheat](https://youtu.be/FDFGfYJPLOc?t=01h06m34s)

[yield return](https://youtu.be/FDFGfYJPLOc?t=01h06m38s)

[and](https://youtu.be/FDFGfYJPLOc?t=01h06m42s)

[i'm gonna cheat a little bit more](https://youtu.be/FDFGfYJPLOc?t=01h06m43s)

[because right now this is starting at](https://youtu.be/FDFGfYJPLOc?t=01h06m44s)

[the bottom and walking up because we're](https://youtu.be/FDFGfYJPLOc?t=01h06m46s)

[using ancestors and ultimately if i'm](https://youtu.be/FDFGfYJPLOc?t=01h06m48s)

[going to join them together with periods](https://youtu.be/FDFGfYJPLOc?t=01h06m50s)

[i want them backwards](https://youtu.be/FDFGfYJPLOc?t=01h06m52s)

[so we're going to just](https://youtu.be/FDFGfYJPLOc?t=01h06m54s)

[reverse that](https://youtu.be/FDFGfYJPLOc?t=01h06m55s)

[yield return those things back out](https://youtu.be/FDFGfYJPLOc?t=01h06m58s)

[get name spaces](https://youtu.be/FDFGfYJPLOc?t=01h07m01s)

[boom no thinking](https://youtu.be/FDFGfYJPLOc?t=01h07m07s)

[done okay so that gets me that far that](https://youtu.be/FDFGfYJPLOc?t=01h07m09s)

[gets me that far that could be that far](https://youtu.be/FDFGfYJPLOc?t=01h07m11s)

[okay so let's get this syntax receiver](https://youtu.be/FDFGfYJPLOc?t=01h07m13s)

[kicking back data and get the thing](https://youtu.be/FDFGfYJPLOc?t=01h07m15s)

[generating at least the empty class for](https://youtu.be/FDFGfYJPLOc?t=01h07m17s)

[me](https://youtu.be/FDFGfYJPLOc?t=01h07m20s)

[so the](https://youtu.be/FDFGfYJPLOc?t=01h07m20s)

[magical syntaxy thing here](https://youtu.be/FDFGfYJPLOc?t=01h07m22s)

[this guy is going to need](https://youtu.be/FDFGfYJPLOc?t=01h07m24s)

[something to share](https://youtu.be/FDFGfYJPLOc?t=01h07m27s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h07m30s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h07m32s)

[how did i pull the data back off of him](https://youtu.be/FDFGfYJPLOc?t=01h07m34s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h07m37s)

[syntax receiver that magic syntax](https://youtu.be/FDFGfYJPLOc?t=01h07m38s)

[got it](https://youtu.be/FDFGfYJPLOc?t=01h07m42s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h07m44s)

[we are going to go with a public](https://youtu.be/FDFGfYJPLOc?t=01h07m45s)

[list](https://youtu.be/FDFGfYJPLOc?t=01h07m48s)

[uh what was it](https://youtu.be/FDFGfYJPLOc?t=01h07m49s)

[generator](https://youtu.be/FDFGfYJPLOc?t=01h07m52s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h07m53s)

[target class](https://youtu.be/FDFGfYJPLOc?t=01h07m54s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h07m58s)

[test](https://youtu.be/FDFGfYJPLOc?t=01h08m00s)

[classes](https://youtu.be/FDFGfYJPLOc?t=01h08m00s)

[get](https://youtu.be/FDFGfYJPLOc?t=01h08m02s)

[instantiate new](https://youtu.be/FDFGfYJPLOc?t=01h08m04s)

[past](https://youtu.be/FDFGfYJPLOc?t=01h08m07s)

[classes new](https://youtu.be/FDFGfYJPLOc?t=01h08m08s)

[generator target class](https://youtu.be/FDFGfYJPLOc?t=01h08m11s)

[really should clean this up at some](https://youtu.be/FDFGfYJPLOc?t=01h08m14s)

[point namespace gets namespace](https://youtu.be/FDFGfYJPLOc?t=01h08m15s)

[declaration](https://youtu.be/FDFGfYJPLOc?t=01h08m17s)

[test class name oh intellicode you are](https://youtu.be/FDFGfYJPLOc?t=01h08m19s)

[on point today](https://youtu.be/FDFGfYJPLOc?t=01h08m22s)

[love it](https://youtu.be/FDFGfYJPLOc?t=01h08m25s)

[love it love it love it](https://youtu.be/FDFGfYJPLOc?t=01h08m26s)

[okay come up here](https://youtu.be/FDFGfYJPLOc?t=01h08m28s)

[pull the syntax receiver back off of](https://youtu.be/FDFGfYJPLOc?t=01h08m29s)

[that guy](https://youtu.be/FDFGfYJPLOc?t=01h08m31s)

[and now we've got it so and then we will](https://youtu.be/FDFGfYJPLOc?t=01h08m32s)

[iterate over](https://youtu.be/FDFGfYJPLOc?t=01h08m34s)

[our test classes](https://youtu.be/FDFGfYJPLOc?t=01h08m36s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h08m41s)

[our](https://youtu.be/FDFGfYJPLOc?t=01h08m44s)

[test class in](https://youtu.be/FDFGfYJPLOc?t=01h08m45s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h08m48s)

[use exclusive type](https://youtu.be/FDFGfYJPLOc?t=01h08m52s)

[don't make it knowable okay so given a](https://youtu.be/FDFGfYJPLOc?t=01h08m54s)

[test class and wanting to generate this](https://youtu.be/FDFGfYJPLOc?t=01h08m57s)

[ultimately we'll need to do more](https://youtu.be/FDFGfYJPLOc?t=01h08m59s)

[advanced stuff but this is kind of what](https://youtu.be/FDFGfYJPLOc?t=01h09m00s)

[we're looking to do](https://youtu.be/FDFGfYJPLOc?t=01h09m02s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h09m05s)

[we are going to do i think we're going](https://youtu.be/FDFGfYJPLOc?t=01h09m08s)

[to do a separate](https://youtu.be/FDFGfYJPLOc?t=01h09m10s)

[i'm going to go the string builder](https://youtu.be/FDFGfYJPLOc?t=01h09m13s)

[approach](https://youtu.be/FDFGfYJPLOc?t=01h09m14s)

[and several people have written like](https://youtu.be/FDFGfYJPLOc?t=01h09m16s)

[indented string builders too](https://youtu.be/FDFGfYJPLOc?t=01h09m18s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h09m21s)

[i'm just going to paste this here as an](https://youtu.be/FDFGfYJPLOc?t=01h09m23s)

[example of what we're going for](https://youtu.be/FDFGfYJPLOc?t=01h09m25s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h09m27s)

[builder](https://youtu.be/FDFGfYJPLOc?t=01h09m28s)

[append line](https://youtu.be/FDFGfYJPLOc?t=01h09m30s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h09m32s)

[we're gonna need](https://youtu.be/FDFGfYJPLOc?t=01h09m38s)

[namespace and then this is going to end](https://youtu.be/FDFGfYJPLOc?t=01h09m41s)

[up being](https://youtu.be/FDFGfYJPLOc?t=01h09m44s)

[namespace of](https://youtu.be/FDFGfYJPLOc?t=01h09m47s)

[uh test class](https://youtu.be/FDFGfYJPLOc?t=01h09m50s)

[namespace](https://youtu.be/FDFGfYJPLOc?t=01h09m53s)

[then we're gonna add in](https://youtu.be/FDFGfYJPLOc?t=01h09m57s)

[so i'm gonna do this the generator guy](https://youtu.be/FDFGfYJPLOc?t=01h09m59s)

[is going to do old school](https://youtu.be/FDFGfYJPLOc?t=01h10m01s)

[name spaces](https://youtu.be/FDFGfYJPLOc?t=01h10m03s)

[just because if i don't and somebody](https://youtu.be/FDFGfYJPLOc?t=01h10m05s)

[tries to use this elsewhere the world](https://youtu.be/FDFGfYJPLOc?t=01h10m07s)

[will fall apart](https://youtu.be/FDFGfYJPLOc?t=01h10m08s)

[and then it we will do builder](https://youtu.be/FDFGfYJPLOc?t=01h10m10s)

[append line](https://youtu.be/FDFGfYJPLOc?t=01h10m13s)

[partial class](https://youtu.be/FDFGfYJPLOc?t=01h10m17s)

[and then this will be](https://youtu.be/FDFGfYJPLOc?t=01h10m19s)

[test class](https://youtu.be/FDFGfYJPLOc?t=01h10m26s)

[test class name](https://youtu.be/FDFGfYJPLOc?t=01h10m27s)

[boom](https://youtu.be/FDFGfYJPLOc?t=01h10m34s)

[open](https://youtu.be/FDFGfYJPLOc?t=01h10m37s)

[close brace](https://youtu.be/FDFGfYJPLOc?t=01h10m38s)

[okay and that gets me into there and](https://youtu.be/FDFGfYJPLOc?t=01h10m43s)

[then](https://youtu.be/FDFGfYJPLOc?t=01h10m45s)

[for now we're going to make the sweeping](https://youtu.be/FDFGfYJPLOc?t=01h10m48s)

[assumption that we're ms test](https://youtu.be/FDFGfYJPLOc?t=01h10m50s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h10m53s)

[to do](https://youtu.be/FDFGfYJPLOc?t=01h10m55s)

[detect other test](https://youtu.be/FDFGfYJPLOc?t=01h10m57s)

[frameworks so we'll need to do that at](https://youtu.be/FDFGfYJPLOc?t=01h11m00s)

[some point but](https://youtu.be/FDFGfYJPLOc?t=01h11m02s)

[we'll leave that in and then we're going](https://youtu.be/FDFGfYJPLOc?t=01h11m03s)

[to do](https://youtu.be/FDFGfYJPLOc?t=01h11m05s)

[this because we are](https://youtu.be/FDFGfYJPLOc?t=01h11m07s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h11m09s)

[let's see](https://youtu.be/FDFGfYJPLOc?t=01h11m10s)

[builder append line](https://youtu.be/FDFGfYJPLOc?t=01h11m12s)

[okay so the next thing we need to do is](https://youtu.be/FDFGfYJPLOc?t=01h11m18s)

[we need to rip through the types](https://youtu.be/FDFGfYJPLOc?t=01h11m20s)

[constructors](https://youtu.be/FDFGfYJPLOc?t=01h11m23s)

[you need to match the accessibility of](https://youtu.be/FDFGfYJPLOc?t=01h11m25s)

[the analyze class that you're generating](https://youtu.be/FDFGfYJPLOc?t=01h11m26s)

[the partial floor](https://youtu.be/FDFGfYJPLOc?t=01h11m28s)

[ah good question so](https://youtu.be/FDFGfYJPLOc?t=01h11m30s)

[uh in this case i'm going to cheat](https://youtu.be/FDFGfYJPLOc?t=01h11m32s)

[so you only have to match the excessive](https://youtu.be/FDFGfYJPLOc?t=01h11m36s)

[uh accessibility modifier](https://youtu.be/FDFGfYJPLOc?t=01h11m39s)

[if you specify one](https://youtu.be/FDFGfYJPLOc?t=01h11m42s)

[so in my case](https://youtu.be/FDFGfYJPLOc?t=01h11m44s)

[i'm going to generate it without one](https://youtu.be/FDFGfYJPLOc?t=01h11m46s)

[and then i don't](https://youtu.be/FDFGfYJPLOc?t=01h11m49s)

[because you can only have one](https://youtu.be/FDFGfYJPLOc?t=01h11m51s)

[access modifier](https://youtu.be/FDFGfYJPLOc?t=01h11m53s)

[ever specified](https://youtu.be/FDFGfYJPLOc?t=01h11m55s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h11m58s)

[as long as it's only specified on one of](https://youtu.be/FDFGfYJPLOc?t=01h11m59s)

[the partials](https://youtu.be/FDFGfYJPLOc?t=01h12m01s)

[you're good there's only one](https://youtu.be/FDFGfYJPLOc?t=01h12m02s)

[if you specify the same one on all](https://youtu.be/FDFGfYJPLOc?t=01h12m05s)

[partials you're also good](https://youtu.be/FDFGfYJPLOc?t=01h12m06s)

[moment you do something different now](https://youtu.be/FDFGfYJPLOc?t=01h12m09s)

[you've got a problem so we're gonna](https://youtu.be/FDFGfYJPLOc?t=01h12m10s)

[cheat in just a minute](https://youtu.be/FDFGfYJPLOc?t=01h12m12s)

[so abuse the the syntax](https://youtu.be/FDFGfYJPLOc?t=01h12m15s)

[a little bit](https://youtu.be/FDFGfYJPLOc?t=01h12m18s)

[not that i would ever do that okay i am](https://youtu.be/FDFGfYJPLOc?t=01h12m20s)

[realizing though we are going to need to](https://youtu.be/FDFGfYJPLOc?t=01h12m22s)

[get that tight because at some point i'm](https://youtu.be/FDFGfYJPLOc?t=01h12m24s)

[gonna have to find that types](https://youtu.be/FDFGfYJPLOc?t=01h12m26s)

[constructors](https://youtu.be/FDFGfYJPLOc?t=01h12m27s)

[which is going to be interesting okay](https://youtu.be/FDFGfYJPLOc?t=01h12m30s)

[but we're gonna get we're gonna get this](https://youtu.be/FDFGfYJPLOc?t=01h12m32s)

[much working uh so this will be](https://youtu.be/FDFGfYJPLOc?t=01h12m34s)

[and we we may we may offer some](https://youtu.be/FDFGfYJPLOc?t=01h12m41s)

[configuration options at some point](https://youtu.be/FDFGfYJPLOc?t=01h12m42s)

[test class](https://youtu.be/FDFGfYJPLOc?t=01h12m45s)

[yeah i do that sometimes don't i um](https://youtu.be/FDFGfYJPLOc?t=01h12m50s)

[oh this is a test class name this is](https://youtu.be/FDFGfYJPLOc?t=01h12m53s)

[gonna be](https://youtu.be/FDFGfYJPLOc?t=01h12m55s)

[okay so we're gonna need to](https://youtu.be/FDFGfYJPLOc?t=01h12m56s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h12m57s)

[so public class](https://youtu.be/FDFGfYJPLOc?t=01h13m00s)

[sub class](https://youtu.be/FDFGfYJPLOc?t=01h13m03s)

[uh public](https://youtu.be/FDFGfYJPLOc?t=01h13m05s)

[and so the so this thing is going to](https://youtu.be/FDFGfYJPLOc?t=01h13m07s)

[need to have a public](https://youtu.be/FDFGfYJPLOc?t=01h13m09s)

[string](https://youtu.be/FDFGfYJPLOc?t=01h13m11s)

[name](https://youtu.be/FDFGfYJPLOc?t=01h13m13s)

[right because we're going to need we're](https://youtu.be/FDFGfYJPLOc?t=01h13m14s)

[going to need to know its name](https://youtu.be/FDFGfYJPLOc?t=01h13m16s)

[and then he's also going to need to have](https://youtu.be/FDFGfYJPLOc?t=01h13m18s)

[constructors](https://youtu.be/FDFGfYJPLOc?t=01h13m22s)

[or constructor parameters](https://youtu.be/FDFGfYJPLOc?t=01h13m24s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h13m28s)

[let's do this uh public class](https://youtu.be/FDFGfYJPLOc?t=01h13m30s)

[null](https://youtu.be/FDFGfYJPLOc?t=01h13m34s)

[structure test](https://youtu.be/FDFGfYJPLOc?t=01h13m35s)

[uh constructor](https://youtu.be/FDFGfYJPLOc?t=01h13m38s)

[parameter test and this guy will contain](https://youtu.be/FDFGfYJPLOc?t=01h13m41s)

[a](https://youtu.be/FDFGfYJPLOc?t=01h13m43s)

[list of these](https://youtu.be/FDFGfYJPLOc?t=01h13m45s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h13m49s)

[director](https://youtu.be/FDFGfYJPLOc?t=01h13m54s)

[null](https://youtu.be/FDFGfYJPLOc?t=01h13m56s)

[yeah so we'll just do that](https://youtu.be/FDFGfYJPLOc?t=01h13m59s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h14m06s)

[we'll do that and](https://youtu.be/FDFGfYJPLOc?t=01h14m07s)

[this guy here so this will end up then](https://youtu.be/FDFGfYJPLOc?t=01h14m10s)

[for reaching over each of those right so](https://youtu.be/FDFGfYJPLOc?t=01h14m12s)

[this guy here is going to need](https://youtu.be/FDFGfYJPLOc?t=01h14m15s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h14m18s)

[uh so let's see here so before we get to](https://youtu.be/FDFGfYJPLOc?t=01h14m24s)

[this inside of this](https://youtu.be/FDFGfYJPLOc?t=01h14m27s)

[the 4-h actually needs to live above](https://youtu.be/FDFGfYJPLOc?t=01h14m34s)

[this because we're going to for each the](https://youtu.be/FDFGfYJPLOc?t=01h14m36s)

[each of the tests so for each](https://youtu.be/FDFGfYJPLOc?t=01h14m38s)

[test](https://youtu.be/FDFGfYJPLOc?t=01h14m41s)

[for each bar](https://youtu.be/FDFGfYJPLOc?t=01h14m43s)

[test in](https://youtu.be/FDFGfYJPLOc?t=01h14m44s)

[test class](https://youtu.be/FDFGfYJPLOc?t=01h14m46s)

[set](https://youtu.be/FDFGfYJPLOc?t=01h14m49s)

[parameter tests](https://youtu.be/FDFGfYJPLOc?t=01h14m51s)

[okay so](https://youtu.be/FDFGfYJPLOc?t=01h14m59s)

[d reference of possibly no value](https://youtu.be/FDFGfYJPLOc?t=01h15m00s)

[law](https://youtu.be/FDFGfYJPLOc?t=01h15m02s)

[and](https://youtu.be/FDFGfYJPLOc?t=01h15m10s)

[that thing](https://youtu.be/FDFGfYJPLOc?t=01h15m12s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h15m13s)

[that'll be fine and then](https://youtu.be/FDFGfYJPLOc?t=01h15m14s)

[this moves up in here too so for each of](https://youtu.be/FDFGfYJPLOc?t=01h15m18s)

[the tests we're going to generate this](https://youtu.be/FDFGfYJPLOc?t=01h15m20s)

[this is actually going to be](https://youtu.be/FDFGfYJPLOc?t=01h15m22s)

[test dot](https://youtu.be/FDFGfYJPLOc?t=01h15m24s)

[i guess it's actually sub name isn't it](https://youtu.be/FDFGfYJPLOc?t=01h15m30s)

[test class sut.name](https://youtu.be/FDFGfYJPLOc?t=01h15m32s)

[and you can't be null if we get to this](https://youtu.be/FDFGfYJPLOc?t=01h15m38s)

[point](https://youtu.be/FDFGfYJPLOc?t=01h15m40s)

[uh with null and then this is going to](https://youtu.be/FDFGfYJPLOc?t=01h15m42s)

[have to be](https://youtu.be/FDFGfYJPLOc?t=01h15m45s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h15m49s)

[so this thing here is going to need to](https://youtu.be/FDFGfYJPLOc?t=01h15m52s)

[have public](https://youtu.be/FDFGfYJPLOc?t=01h15m54s)

[string](https://youtu.be/FDFGfYJPLOc?t=01h15m56s)

[null type](https://youtu.be/FDFGfYJPLOc?t=01h15m58s)

[name](https://youtu.be/FDFGfYJPLOc?t=01h16m01s)

[this is going to need to have](https://youtu.be/FDFGfYJPLOc?t=01h16m04s)

[we're going to want the](https://youtu.be/FDFGfYJPLOc?t=01h16m08s)

[actually](https://youtu.be/FDFGfYJPLOc?t=01h16m10s)

[no we're just we're not going to type](https://youtu.be/FDFGfYJPLOc?t=01h16m11s)

[name we're going to do full name and](https://youtu.be/FDFGfYJPLOc?t=01h16m13s)

[name](https://youtu.be/FDFGfYJPLOc?t=01h16m14s)

[oh it kind of lines up with the naming](https://youtu.be/FDFGfYJPLOc?t=01h16m16s)

[of](https://youtu.be/FDFGfYJPLOc?t=01h16m17s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h16m22s)

[yeah](https://youtu.be/FDFGfYJPLOc?t=01h16m24s)

[that way it sort of lines up with the](https://youtu.be/FDFGfYJPLOc?t=01h16m25s)

[naming of the reflection apis okay so](https://youtu.be/FDFGfYJPLOc?t=01h16m26s)

[then](https://youtu.be/FDFGfYJPLOc?t=01h16m29s)

[builder](https://youtu.be/FDFGfYJPLOc?t=01h16m30s)

[append line](https://youtu.be/FDFGfYJPLOc?t=01h16m31s)

[boom](https://youtu.be/FDFGfYJPLOc?t=01h16m34s)

[do that](https://youtu.be/FDFGfYJPLOc?t=01h16m35s)

[do that](https://youtu.be/FDFGfYJPLOc?t=01h16m37s)

[do that and](https://youtu.be/FDFGfYJPLOc?t=01h16m39s)

[one two three four five six seven eight](https://youtu.be/FDFGfYJPLOc?t=01h16m42s)

[eight](https://youtu.be/FDFGfYJPLOc?t=01h16m44s)

[eight good](https://youtu.be/FDFGfYJPLOc?t=01h16m47s)

[one two three four five six seven eight](https://youtu.be/FDFGfYJPLOc?t=01h16m49s)

[okay that](https://youtu.be/FDFGfYJPLOc?t=01h16m52s)

[i try to do my indentation to make it](https://youtu.be/FDFGfYJPLOc?t=01h16m54s)

[pretty okay so that should generate up](https://youtu.be/FDFGfYJPLOc?t=01h16m56s)

[this now we need to make sure that our](https://youtu.be/FDFGfYJPLOc?t=01h17m00s)

[syntax receiver is actually populating](https://youtu.be/FDFGfYJPLOc?t=01h17m03s)

[those](https://youtu.be/FDFGfYJPLOc?t=01h17m06s)

[uh let's see](https://youtu.be/FDFGfYJPLOc?t=01h17m07s)

[sut gets new](https://youtu.be/FDFGfYJPLOc?t=01h17m10s)

[subclass](https://youtu.be/FDFGfYJPLOc?t=01h17m13s)

[name](https://youtu.be/FDFGfYJPLOc?t=01h17m15s)

[gets](https://youtu.be/FDFGfYJPLOc?t=01h17m17s)

[and in this case](https://youtu.be/FDFGfYJPLOc?t=01h17m19s)

[we are just going to call it](https://youtu.be/FDFGfYJPLOc?t=01h17m20s)

[controller](https://youtu.be/FDFGfYJPLOc?t=01h17m22s)

[we'll assume we parse the rest of that](https://youtu.be/FDFGfYJPLOc?t=01h17m24s)

[out](https://youtu.be/FDFGfYJPLOc?t=01h17m26s)

[new and actually we can do](https://youtu.be/FDFGfYJPLOc?t=01h17m28s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h17m31s)

[this](https://youtu.be/FDFGfYJPLOc?t=01h17m33s)

[so fun trick you'll note i'm j i just](https://youtu.be/FDFGfYJPLOc?t=01h17m34s)

[did a equals and then open curly brace](https://youtu.be/FDFGfYJPLOc?t=01h17m37s)

[so that is the](https://youtu.be/FDFGfYJPLOc?t=01h17m40s)

[the cheater way to go about](https://youtu.be/FDFGfYJPLOc?t=01h17m42s)

[adding items to an to an existing list](https://youtu.be/FDFGfYJPLOc?t=01h17m45s)

[so because this property](https://youtu.be/FDFGfYJPLOc?t=01h17m48s)

[is a read-only property normally you](https://youtu.be/FDFGfYJPLOc?t=01h17m51s)

[shouldn't be able to assign to it](https://youtu.be/FDFGfYJPLOc?t=01h17m53s)

[but yet i'm doing an assignment it's](https://youtu.be/FDFGfYJPLOc?t=01h17m55s)

[really not an assignment](https://youtu.be/FDFGfYJPLOc?t=01h17m58s)

[the compiler is hip to the idea to know](https://youtu.be/FDFGfYJPLOc?t=01h18m00s)

[okay i get what you mean you want to](https://youtu.be/FDFGfYJPLOc?t=01h18m02s)

[call add repeatedly using these items](https://youtu.be/FDFGfYJPLOc?t=01h18m04s)

[inside of here](https://youtu.be/FDFGfYJPLOc?t=01h18m07s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h18m08s)

[okay so we're going to assume we can](https://youtu.be/FDFGfYJPLOc?t=01h18m13s)

[figure these out at some point but for](https://youtu.be/FDFGfYJPLOc?t=01h18m15s)

[now we're just going to get this guy](https://youtu.be/FDFGfYJPLOc?t=01h18m17s)

[generating](https://youtu.be/FDFGfYJPLOc?t=01h18m19s)

[and make sure that it works](https://youtu.be/FDFGfYJPLOc?t=01h18m20s)

[okay so controller](https://youtu.be/FDFGfYJPLOc?t=01h18m23s)

[null type name](https://youtu.be/FDFGfYJPLOc?t=01h18m24s)

[we're going to just](https://youtu.be/FDFGfYJPLOc?t=01h18m27s)

[hard code some of these values in for](https://youtu.be/FDFGfYJPLOc?t=01h18m29s)

[the moment just to make it work and get](https://youtu.be/FDFGfYJPLOc?t=01h18m31s)

[the generator going](https://youtu.be/FDFGfYJPLOc?t=01h18m33s)

[and then](https://youtu.be/FDFGfYJPLOc?t=01h18m34s)

[we'll can we'll come back and figure out](https://youtu.be/FDFGfYJPLOc?t=01h18m37s)

[how to parse that data](https://youtu.be/FDFGfYJPLOc?t=01h18m39s)

[once we get rolling so we will need](https://youtu.be/FDFGfYJPLOc?t=01h18m41s)

[these lines next](https://youtu.be/FDFGfYJPLOc?t=01h18m45s)

[so those are going to go there](https://youtu.be/FDFGfYJPLOc?t=01h18m48s)

[let's just do](https://youtu.be/FDFGfYJPLOc?t=01h18m50s)

[this builder](https://youtu.be/FDFGfYJPLOc?t=01h18m52s)

[and line](https://youtu.be/FDFGfYJPLOc?t=01h18m55s)

[that maneuver](https://youtu.be/FDFGfYJPLOc?t=01h18m58s)

[um this is probably needing gonna need](https://youtu.be/FDFGfYJPLOc?t=01h19m02s)

[to be fully qualified](https://youtu.be/FDFGfYJPLOc?t=01h19m04s)

[i'm going to do this](https://youtu.be/FDFGfYJPLOc?t=01h19m06s)

[now i'm going to generate it](https://youtu.be/FDFGfYJPLOc?t=01h19m14s)

[with older c sharp syntax just so that](https://youtu.be/FDFGfYJPLOc?t=01h19m16s)

[it doesn't](https://youtu.be/FDFGfYJPLOc?t=01h19m19s)

[oh hush i understand you're unhappy just](https://youtu.be/FDFGfYJPLOc?t=01h19m21s)

[so that if people are using it](https://youtu.be/FDFGfYJPLOc?t=01h19m24s)

[differently](https://youtu.be/FDFGfYJPLOc?t=01h19m25s)

[and then this will be interesting so](https://youtu.be/FDFGfYJPLOc?t=01h19m26s)

[generated code by default](https://youtu.be/FDFGfYJPLOc?t=01h19m28s)

[doesn't have nullable reference types](https://youtu.be/FDFGfYJPLOc?t=01h19m30s)

[turned on](https://youtu.be/FDFGfYJPLOc?t=01h19m32s)

[okay so just be aware of that it is](https://youtu.be/FDFGfYJPLOc?t=01h19m34s)

[nullable ambiguous or noble unknown i](https://youtu.be/FDFGfYJPLOc?t=01h19m37s)

[don't remember the exact](https://youtu.be/FDFGfYJPLOc?t=01h19m39s)

[name of it](https://youtu.be/FDFGfYJPLOc?t=01h19m41s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h19m43s)

[okay so this one here is going to be](https://youtu.be/FDFGfYJPLOc?t=01h19m48s)

[slightly different in that this is going](https://youtu.be/FDFGfYJPLOc?t=01h19m50s)

[to need type of](https://youtu.be/FDFGfYJPLOc?t=01h19m52s)

[and this will be test](https://youtu.be/FDFGfYJPLOc?t=01h19m54s)

[null type](https://youtu.be/FDFGfYJPLOc?t=01h19m56s)

[and i want this to be full name](https://youtu.be/FDFGfYJPLOc?t=01h19m58s)

[because i want this to be fully](https://youtu.be/FDFGfYJPLOc?t=01h20m01s)

[qualified](https://youtu.be/FDFGfYJPLOc?t=01h20m02s)

[and then this is going to be](https://youtu.be/FDFGfYJPLOc?t=01h20m05s)

[system dot](https://youtu.be/FDFGfYJPLOc?t=01h20m09s)

[and this will be system dot and we'll](https://youtu.be/FDFGfYJPLOc?t=01h20m12s)

[just populate that](https://youtu.be/FDFGfYJPLOc?t=01h20m14s)

[and then this will be](https://youtu.be/FDFGfYJPLOc?t=01h20m17s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h20m23s)

[name](https://youtu.be/FDFGfYJPLOc?t=01h20m27s)

[so this will be](https://youtu.be/FDFGfYJPLOc?t=01h20m29s)

[here](https://youtu.be/FDFGfYJPLOc?t=01h20m30s)

[test class](https://youtu.be/FDFGfYJPLOc?t=01h20m33s)

[set](https://youtu.be/FDFGfYJPLOc?t=01h20m35s)

[full name](https://youtu.be/FDFGfYJPLOc?t=01h20m36s)

[dollar sign there](https://youtu.be/FDFGfYJPLOc?t=01h20m42s)

[let's see close quote close paren](https://youtu.be/FDFGfYJPLOc?t=01h20m46s)

[we'll need to add a full name property](https://youtu.be/FDFGfYJPLOc?t=01h20m49s)

[there](https://youtu.be/FDFGfYJPLOc?t=01h20m51s)

[and then this is just going to be](https://youtu.be/FDFGfYJPLOc?t=01h20m52s)

[we will need this to be](https://youtu.be/FDFGfYJPLOc?t=01h20m56s)

[a](https://youtu.be/FDFGfYJPLOc?t=01h21m00s)

[test](https://youtu.be/FDFGfYJPLOc?t=01h21m01s)

[parameter](https://youtu.be/FDFGfYJPLOc?t=01h21m03s)

[name](https://youtu.be/FDFGfYJPLOc?t=01h21m05s)

[i need to add some properties there](https://youtu.be/FDFGfYJPLOc?t=01h21m12s)

[and then that should work okay so](https://youtu.be/FDFGfYJPLOc?t=01h21m15s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h21m19s)

[why did you not figure it out](https://youtu.be/FDFGfYJPLOc?t=01h21m22s)

[we'll type full name](https://youtu.be/FDFGfYJPLOc?t=01h21m25s)

[we're gonna go name](https://youtu.be/FDFGfYJPLOc?t=01h21m28s)

[full name](https://youtu.be/FDFGfYJPLOc?t=01h21m31s)

[then](https://youtu.be/FDFGfYJPLOc?t=01h21m33s)

[subfull name](https://youtu.be/FDFGfYJPLOc?t=01h21m35s)

[boom](https://youtu.be/FDFGfYJPLOc?t=01h21m46s)

[that and then](https://youtu.be/FDFGfYJPLOc?t=01h21m48s)

[test needs parameter name on it](https://youtu.be/FDFGfYJPLOc?t=01h21m50s)

[that'll get me into there that'll get me](https://youtu.be/FDFGfYJPLOc?t=01h21m59s)

[into there that will get me into there](https://youtu.be/FDFGfYJPLOc?t=01h22m01s)

[okay so that that's all well and good](https://youtu.be/FDFGfYJPLOc?t=01h22m03s)

[syntax receiver](https://youtu.be/FDFGfYJPLOc?t=01h22m07s)

[okay so let's](https://youtu.be/FDFGfYJPLOc?t=01h22m09s)

[let's see null type full name is going](https://youtu.be/FDFGfYJPLOc?t=01h22m11s)

[to get](https://youtu.be/FDFGfYJPLOc?t=01h22m13s)

[uh i don't remember the full name of](https://youtu.be/FDFGfYJPLOc?t=01h22m15s)

[this guy](https://youtu.be/FDFGfYJPLOc?t=01h22m17s)

[big](https://youtu.be/FDFGfYJPLOc?t=01h22m18s)

[this thing](https://youtu.be/FDFGfYJPLOc?t=01h22m19s)

[this is what it ultimately needs to find](https://youtu.be/FDFGfYJPLOc?t=01h22m20s)

[because it needs to look this up](https://youtu.be/FDFGfYJPLOc?t=01h22m22s)

[from the constructor parameter name](https://youtu.be/FDFGfYJPLOc?t=01h22m26s)

[service](https://youtu.be/FDFGfYJPLOc?t=01h22m30s)

[and then](https://youtu.be/FDFGfYJPLOc?t=01h22m33s)

[this needs to be full name here](https://youtu.be/FDFGfYJPLOc?t=01h22m34s)

[and i believe it's going to have the](https://youtu.be/FDFGfYJPLOc?t=01h22m38s)

[same](https://youtu.be/FDFGfYJPLOc?t=01h22m39s)

[thing bobber there](https://youtu.be/FDFGfYJPLOc?t=01h22m42s)

[and that's what it's going to generate](https://youtu.be/FDFGfYJPLOc?t=01h22m44s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h22m47s)

[let's](https://youtu.be/FDFGfYJPLOc?t=01h22m48s)

[let's try it](https://youtu.be/FDFGfYJPLOc?t=01h22m50s)

[oh uh not gonna work yet because we](https://youtu.be/FDFGfYJPLOc?t=01h22m54s)

[didn't actually do anything with the](https://youtu.be/FDFGfYJPLOc?t=01h22m56s)

[code that we generated so we built this](https://youtu.be/FDFGfYJPLOc?t=01h22m58s)

[up](https://youtu.be/FDFGfYJPLOc?t=01h23m00s)

[did all this work and then we need to](https://youtu.be/FDFGfYJPLOc?t=01h23m01s)

[add it because if you don't](https://youtu.be/FDFGfYJPLOc?t=01h23m02s)

[if you just build up the code into a](https://youtu.be/FDFGfYJPLOc?t=01h23m05s)

[string builder that's great except for](https://youtu.be/FDFGfYJPLOc?t=01h23m06s)

[then it's just in a string builder](https://youtu.be/FDFGfYJPLOc?t=01h23m08s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h23m11s)

[one two three four](https://youtu.be/FDFGfYJPLOc?t=01h23m12s)

[one two three four](https://youtu.be/FDFGfYJPLOc?t=01h23m14s)

[two three four there](https://youtu.be/FDFGfYJPLOc?t=01h23m17s)

[and then to add it is context](https://youtu.be/FDFGfYJPLOc?t=01h23m19s)

[add source](https://youtu.be/FDFGfYJPLOc?t=01h23m23s)

[and we do need to give it a name](https://youtu.be/FDFGfYJPLOc?t=01h23m25s)

[and then the final parameter will be](https://youtu.be/FDFGfYJPLOc?t=01h23m28s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h23m30s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h23m31s)

[builder](https://youtu.be/FDFGfYJPLOc?t=01h23m32s)

[tostring](https://youtu.be/FDFGfYJPLOc?t=01h23m33s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h23m36s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h23m37s)

[this is going to be test class](https://youtu.be/FDFGfYJPLOc?t=01h23m39s)

[so how about we i'm trying to think if i](https://youtu.be/FDFGfYJPLOc?t=01h23m43s)

[can get away with](https://youtu.be/FDFGfYJPLOc?t=01h23m46s)

[test class](https://youtu.be/FDFGfYJPLOc?t=01h23m48s)

[we're gonna this is this is probably not](https://youtu.be/FDFGfYJPLOc?t=01h23m56s)

[going to be sufficient to to do](https://youtu.be/FDFGfYJPLOc?t=01h23m58s)

[something so simplistic like this but we](https://youtu.be/FDFGfYJPLOc?t=01h24m00s)

[we're gonna start here](https://youtu.be/FDFGfYJPLOc?t=01h24m02s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h24m10s)

[test class](https://youtu.be/FDFGfYJPLOc?t=01h24m11s)

[test name dot g dot cs](https://youtu.be/FDFGfYJPLOc?t=01h24m14s)

[okay and then there's one more thing i](https://youtu.be/FDFGfYJPLOc?t=01h24m17s)

[want to set up on this guy because](https://youtu.be/FDFGfYJPLOc?t=01h24m19s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h24m22s)

[if i go back to my nose plug library](https://youtu.be/FDFGfYJPLOc?t=01h24m24s)

[there's a clever trick um for debugging](https://youtu.be/FDFGfYJPLOc?t=01h24m27s)

[the output of these things because this](https://youtu.be/FDFGfYJPLOc?t=01h24m30s)

[will not](https://youtu.be/FDFGfYJPLOc?t=01h24m32s)

[it will not show you the output](https://youtu.be/FDFGfYJPLOc?t=01h24m38s)

[by default](https://youtu.be/FDFGfYJPLOc?t=01h24m41s)

[normally these files just get tacked on](https://youtu.be/FDFGfYJPLOc?t=01h24m42s)

[there](https://youtu.be/FDFGfYJPLOc?t=01h24m45s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h24m46s)

[where did i put it](https://youtu.be/FDFGfYJPLOc?t=01h24m47s)

[in my directory build props](https://youtu.be/FDFGfYJPLOc?t=01h24m49s)

[this this magical thing](https://youtu.be/FDFGfYJPLOc?t=01h24m56s)

[emit compiler generated files](https://youtu.be/FDFGfYJPLOc?t=01h24m58s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h25m01s)

[with this off it just compiles fast](https://youtu.be/FDFGfYJPLOc?t=01h25m02s)

[with this on](https://youtu.be/FDFGfYJPLOc?t=01h25m06s)

[it will actually generate some c-sharp](https://youtu.be/FDFGfYJPLOc?t=01h25m08s)

[files we can go look at](https://youtu.be/FDFGfYJPLOc?t=01h25m10s)

[so that is another easy way to](https://youtu.be/FDFGfYJPLOc?t=01h25m12s)

[easy way this is another way to debug](https://youtu.be/FDFGfYJPLOc?t=01h25m16s)

[your source generators](https://youtu.be/FDFGfYJPLOc?t=01h25m18s)

[so we're going to turn](https://youtu.be/FDFGfYJPLOc?t=01h25m21s)

[this guy off](https://youtu.be/FDFGfYJPLOc?t=01h25m22s)

[rebuild him](https://youtu.be/FDFGfYJPLOc?t=01h25m24s)

[and then we'll rebuild this](https://youtu.be/FDFGfYJPLOc?t=01h25m29s)

[so hopefully](https://youtu.be/FDFGfYJPLOc?t=01h25m33s)

[assuming our thing doesn't blow up](https://youtu.be/FDFGfYJPLOc?t=01h25m35s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h25m38s)

[test method attribute could not be found](https://youtu.be/FDFGfYJPLOc?t=01h25m41s)

[huh](https://youtu.be/FDFGfYJPLOc?t=01h25m47s)

[what did i do wrong](https://youtu.be/FDFGfYJPLOc?t=01h25m49s)

[so i am noticing that this is in my](https://youtu.be/FDFGfYJPLOc?t=01h25m51s)

[generated file](https://youtu.be/FDFGfYJPLOc?t=01h25m53s)

[test method attribute oh because i](https://youtu.be/FDFGfYJPLOc?t=01h25m54s)

[did this and didn't add any using](https://youtu.be/FDFGfYJPLOc?t=01h25m58s)

[statement to it](https://youtu.be/FDFGfYJPLOc?t=01h26m00s)

[okay so we're gonna just fully qualify i](https://youtu.be/FDFGfYJPLOc?t=01h26m01s)

[tend to prefer fully qualifying these](https://youtu.be/FDFGfYJPLOc?t=01h26m04s)

[things](https://youtu.be/FDFGfYJPLOc?t=01h26m06s)

[and then we'll try again](https://youtu.be/FDFGfYJPLOc?t=01h26m07s)

[uh actually real quick before we before](https://youtu.be/FDFGfYJPLOc?t=01h26m09s)

[we try again i will show you where those](https://youtu.be/FDFGfYJPLOc?t=01h26m11s)

[files go so if you look at your project](https://youtu.be/FDFGfYJPLOc?t=01h26m13s)

[folder](https://youtu.be/FDFGfYJPLOc?t=01h26m15s)

[so this is the unit test project that](https://youtu.be/FDFGfYJPLOc?t=01h26m17s)

[has it added](https://youtu.be/FDFGfYJPLOc?t=01h26m18s)

[underneath obj](https://youtu.be/FDFGfYJPLOc?t=01h26m20s)

[and then target in my case or um](https://youtu.be/FDFGfYJPLOc?t=01h26m22s)

[configuration in my case debug generated](https://youtu.be/FDFGfYJPLOc?t=01h26m25s)

[here here and you'll note](https://youtu.be/FDFGfYJPLOc?t=01h26m28s)

[there's the c sharp file that we built](https://youtu.be/FDFGfYJPLOc?t=01h26m31s)

[so i can see another problem that i'm](https://youtu.be/FDFGfYJPLOc?t=01h26m33s)

[going to run into right away is](https://youtu.be/FDFGfYJPLOc?t=01h26m35s)

[apparently i didn't specify namespace](https://youtu.be/FDFGfYJPLOc?t=01h26m36s)

[so that's that's a problem](https://youtu.be/FDFGfYJPLOc?t=01h26m39s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h26m43s)

[which is interesting since i thought our](https://youtu.be/FDFGfYJPLOc?t=01h26m48s)

[syntax receiver was retrieving that](https://youtu.be/FDFGfYJPLOc?t=01h26m49s)

[but you know what in the interest of](https://youtu.be/FDFGfYJPLOc?t=01h26m56s)

[simplicity we're going to hard code it](https://youtu.be/FDFGfYJPLOc?t=01h26m57s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h27m00s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h27m01s)

[just be this for now](https://youtu.be/FDFGfYJPLOc?t=01h27m03s)

[come back and parse that out in a moment](https://youtu.be/FDFGfYJPLOc?t=01h27m09s)

[so we have to rebuild our source](https://youtu.be/FDFGfYJPLOc?t=01h27m11s)

[generator because we modified it](https://youtu.be/FDFGfYJPLOc?t=01h27m13s)

[and then we have to recompile this guy](https://youtu.be/FDFGfYJPLOc?t=01h27m18s)

[here](https://youtu.be/FDFGfYJPLOc?t=01h27m20s)

[okay and now it's running into](https://youtu.be/FDFGfYJPLOc?t=01h27m29s)

[duplicate member](https://youtu.be/FDFGfYJPLOc?t=01h27m31s)

[which is what we want so we are going to](https://youtu.be/FDFGfYJPLOc?t=01h27m33s)

[get rid of this guy](https://youtu.be/FDFGfYJPLOc?t=01h27m34s)

[because hopefully that is gone now](https://youtu.be/FDFGfYJPLOc?t=01h27m36s)

[and](https://youtu.be/FDFGfYJPLOc?t=01h27m40s)

[rebuild one more time](https://youtu.be/FDFGfYJPLOc?t=01h27m42s)

[and hopefully we have a test](https://youtu.be/FDFGfYJPLOc?t=01h27m44s)

[assert isn't found because once again i](https://youtu.be/FDFGfYJPLOc?t=01h27m49s)

[did not fully qualify it](https://youtu.be/FDFGfYJPLOc?t=01h27m53s)

[uh let's see here so let's do](https://youtu.be/FDFGfYJPLOc?t=01h27m56s)

[and i may go back on this and not fully](https://youtu.be/FDFGfYJPLOc?t=01h28m01s)

[qualify everything and slap some using](https://youtu.be/FDFGfYJPLOc?t=01h28m04s)

[statements in here but for now we're](https://youtu.be/FDFGfYJPLOc?t=01h28m06s)

[going to fully qualify](https://youtu.be/FDFGfYJPLOc?t=01h28m07s)

[fully qualified just has the](https://youtu.be/FDFGfYJPLOc?t=01h28m10s)

[nice perk of i'm less concerned about](https://youtu.be/FDFGfYJPLOc?t=01h28m12s)

[naming collisions when that when that](https://youtu.be/FDFGfYJPLOc?t=01h28m14s)

[happens](https://youtu.be/FDFGfYJPLOc?t=01h28m16s)

[it's probably pretty unlikely i'm](https://youtu.be/FDFGfYJPLOc?t=01h28m18s)

[generating all the code](https://youtu.be/FDFGfYJPLOc?t=01h28m20s)

[like it's going to be something like](https://youtu.be/FDFGfYJPLOc?t=01h28m21s)

[somebody has their own assert class or](https://youtu.be/FDFGfYJPLOc?t=01h28m23s)

[somewhere but it's](https://youtu.be/FDFGfYJPLOc?t=01h28m25s)

[like i don't want an ambiguous type](https://youtu.be/FDFGfYJPLOc?t=01h28m26s)

[match](https://youtu.be/FDFGfYJPLOc?t=01h28m29s)

[okay so a rebuilt](https://youtu.be/FDFGfYJPLOc?t=01h28m30s)

[which is a which is a plus](https://youtu.be/FDFGfYJPLOc?t=01h28m32s)

[um if we look back here at our generated](https://youtu.be/FDFGfYJPLOc?t=01h28m35s)

[stuff we can see](https://youtu.be/FDFGfYJPLOc?t=01h28m38s)

[what we got](https://youtu.be/FDFGfYJPLOc?t=01h28m40s)

[looks pretty good](https://youtu.be/FDFGfYJPLOc?t=01h28m43s)

[so you'll note here we're all commented](https://youtu.be/FDFGfYJPLOc?t=01h28m44s)

[out](https://youtu.be/FDFGfYJPLOc?t=01h28m47s)

[um but if i right click here and hit run](https://youtu.be/FDFGfYJPLOc?t=01h28m48s)

[tests](https://youtu.be/FDFGfYJPLOc?t=01h28m50s)

[i should get a test in here](https://youtu.be/FDFGfYJPLOc?t=01h28m52s)

[i got a test](https://youtu.be/FDFGfYJPLOc?t=01h28m57s)

[and you'll know the this slightly](https://youtu.be/FDFGfYJPLOc?t=01h29m00s)

[unfortunate part is no source available](https://youtu.be/FDFGfYJPLOc?t=01h29m02s)

[because this was an auto generated deal](https://youtu.be/FDFGfYJPLOc?t=01h29m06s)

[however it's named pretty explicitly](https://youtu.be/FDFGfYJPLOc?t=01h29m10s)

[and we can go and look at it in the](https://youtu.be/FDFGfYJPLOc?t=01h29m14s)

[generated file if we want to take a look](https://youtu.be/FDFGfYJPLOc?t=01h29m16s)

[at what it's doing](https://youtu.be/FDFGfYJPLOc?t=01h29m18s)

[which is pretty good](https://youtu.be/FDFGfYJPLOc?t=01h29m21s)

[which is pretty good okay](https://youtu.be/FDFGfYJPLOc?t=01h29m23s)

[that gets me most of the way](https://youtu.be/FDFGfYJPLOc?t=01h29m26s)

[at least for the first bit i still have](https://youtu.be/FDFGfYJPLOc?t=01h29m31s)

[to figure out how to](https://youtu.be/FDFGfYJPLOc?t=01h29m32s)

[populate these these things here now the](https://youtu.be/FDFGfYJPLOc?t=01h29m34s)

[one other thing i wanted to look at is](https://youtu.be/FDFGfYJPLOc?t=01h29m36s)

[on here i want to see if i can detect](https://youtu.be/FDFGfYJPLOc?t=01h29m39s)

[the](https://youtu.be/FDFGfYJPLOc?t=01h29m41s)

[um the referenced assemblies](https://youtu.be/FDFGfYJPLOc?t=01h29m44s)

[uh so i don't think i do that here](https://youtu.be/FDFGfYJPLOc?t=01h29m48s)

[i think i get that up here](https://youtu.be/FDFGfYJPLOc?t=01h29m53s)

[because i want to know](https://youtu.be/FDFGfYJPLOc?t=01h29m58s)

[the](https://youtu.be/FDFGfYJPLOc?t=01h30m00s)

[referenced assemblies to this guy](https://youtu.be/FDFGfYJPLOc?t=01h30m01s)

[i think it's under compilation like](https://youtu.be/FDFGfYJPLOc?t=01h30m06s)

[assemblies or](https://youtu.be/FDFGfYJPLOc?t=01h30m08s)

[references](https://youtu.be/FDFGfYJPLOc?t=01h30m11s)

[referenced assembly names got it this is](https://youtu.be/FDFGfYJPLOc?t=01h30m13s)

[what i want](https://youtu.be/FDFGfYJPLOc?t=01h30m15s)

[this is what i want pretty sure](https://youtu.be/FDFGfYJPLOc?t=01h30m17s)

[pretty sure](https://youtu.be/FDFGfYJPLOc?t=01h30m21s)

[because i think we can leverage this to](https://youtu.be/FDFGfYJPLOc?t=01h30m22s)

[say hey](https://youtu.be/FDFGfYJPLOc?t=01h30m24s)

[does it](https://youtu.be/FDFGfYJPLOc?t=01h30m25s)

[what does it look like](https://youtu.be/FDFGfYJPLOc?t=01h30m26s)

[uh so we are going to create our own](https://youtu.be/FDFGfYJPLOc?t=01h30m28s)

[um public enum](https://youtu.be/FDFGfYJPLOc?t=01h30m32s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h30m36s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h30m39s)

[testing](https://youtu.be/FDFGfYJPLOc?t=01h30m40s)

[framework or how about](https://youtu.be/FDFGfYJPLOc?t=01h30m42s)

[target testing framework](https://youtu.be/FDFGfYJPLOc?t=01h30m44s)

[we'll start with an unknown which will](https://youtu.be/FDFGfYJPLOc?t=01h30m46s)

[be our generic case](https://youtu.be/FDFGfYJPLOc?t=01h30m48s)

[uh ms test](https://youtu.be/FDFGfYJPLOc?t=01h30m50s)

[x unit](https://youtu.be/FDFGfYJPLOc?t=01h30m53s)

[n unit](https://youtu.be/FDFGfYJPLOc?t=01h30m56s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h30m58s)

[then we'll write a quick method here](https://youtu.be/FDFGfYJPLOc?t=01h30m59s)

[private](https://youtu.be/FDFGfYJPLOc?t=01h31m02s)

[static](https://youtu.be/FDFGfYJPLOc?t=01h31m04s)

[boom](https://youtu.be/FDFGfYJPLOc?t=01h31m09s)

[get testing framework](https://youtu.be/FDFGfYJPLOc?t=01h31m10s)

[and you're going to take in the](https://youtu.be/FDFGfYJPLOc?t=01h31m16s)

[i think we can we can probably limit it](https://youtu.be/FDFGfYJPLOc?t=01h31m20s)

[of what it needs so context](https://youtu.be/FDFGfYJPLOc?t=01h31m22s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h31m25s)

[compilation](https://youtu.be/FDFGfYJPLOc?t=01h31m26s)

[referenced assembly names](https://youtu.be/FDFGfYJPLOc?t=01h31m28s)

[i think we can just feed it one of these](https://youtu.be/FDFGfYJPLOc?t=01h31m30s)

[thingies](https://youtu.be/FDFGfYJPLOc?t=01h31m32s)

[yeah yeah](https://youtu.be/FDFGfYJPLOc?t=01h31m34s)

[just](https://youtu.be/FDFGfYJPLOc?t=01h31m35s)

[go](https://youtu.be/FDFGfYJPLOc?t=01h31m36s)

[remember my selection please](https://youtu.be/FDFGfYJPLOc?t=01h31m38s)

[i wanted to take in one of these](https://youtu.be/FDFGfYJPLOc?t=01h31m41s)

[thingies](https://youtu.be/FDFGfYJPLOc?t=01h31m42s)

[and just rip through it and say](https://youtu.be/FDFGfYJPLOc?t=01h31m44s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h31m49s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h31m49s)

[assemblies](https://youtu.be/FDFGfYJPLOc?t=01h31m51s)

[okay so if](https://youtu.be/FDFGfYJPLOc?t=01h31m52s)

[what do we got here we got a dependency](https://youtu.be/FDFGfYJPLOc?t=01h31m56s)

[let's go with](https://youtu.be/FDFGfYJPLOc?t=01h32m03s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h32m06s)

[so we'll just rip through there](https://youtu.be/FDFGfYJPLOc?t=01h32m08s)

[for each](https://youtu.be/FDFGfYJPLOc?t=01h32m10s)

[assembly identity](https://youtu.be/FDFGfYJPLOc?t=01h32m13s)

[assembly in](https://youtu.be/FDFGfYJPLOc?t=01h32m15s)

[assemblies](https://youtu.be/FDFGfYJPLOc?t=01h32m17s)

[assembly dot](https://youtu.be/FDFGfYJPLOc?t=01h32m22s)

[oh culture name that's interesting](https://youtu.be/FDFGfYJPLOc?t=01h32m26s)

[good display name](https://youtu.be/FDFGfYJPLOc?t=01h32m33s)

[i think i just kind of want to go with](https://youtu.be/FDFGfYJPLOc?t=01h32m36s)

[name](https://youtu.be/FDFGfYJPLOc?t=01h32m37s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h32m42s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h32m42s)

[contains](https://youtu.be/FDFGfYJPLOc?t=01h32m44s)

[microsoft](https://youtu.be/FDFGfYJPLOc?t=01h32m48s)

[net](https://youtu.be/FDFGfYJPLOc?t=01h32m50s)

[test sdk](https://youtu.be/FDFGfYJPLOc?t=01h32m52s)

[return](https://youtu.be/FDFGfYJPLOc?t=01h32m58s)

[target testing framework ms test](https://youtu.be/FDFGfYJPLOc?t=01h32m59s)

[and then at the very end of this return](https://youtu.be/FDFGfYJPLOc?t=01h33m02s)

[uh target](https://youtu.be/FDFGfYJPLOc?t=01h33m06s)

[testing framework unknown](https://youtu.be/FDFGfYJPLOc?t=01h33m09s)

[and we might again this is one of those](https://youtu.be/FDFGfYJPLOc?t=01h33m13s)

[cases where i i could very conceivably](https://youtu.be/FDFGfYJPLOc?t=01h33m15s)

[go through and add in](https://youtu.be/FDFGfYJPLOc?t=01h33m17s)

[a configuration option to override this](https://youtu.be/FDFGfYJPLOc?t=01h33m19s)

[in case it's guessing is wrong](https://youtu.be/FDFGfYJPLOc?t=01h33m22s)

[we can probably get pretty close](https://youtu.be/FDFGfYJPLOc?t=01h33m24s)

[oh we can't rely on that particular one](https://youtu.be/FDFGfYJPLOc?t=01h33m28s)

[can't we](https://youtu.be/FDFGfYJPLOc?t=01h33m31s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h33m33s)

[how about name starts with ms test](https://youtu.be/FDFGfYJPLOc?t=01h33m38s)

[starts with ms test dot](https://youtu.be/FDFGfYJPLOc?t=01h33m44s)

[then name](https://youtu.be/FDFGfYJPLOc?t=01h33m48s)

[starts with](https://youtu.be/FDFGfYJPLOc?t=01h33m50s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h33m52s)

[end unit](https://youtu.be/FDFGfYJPLOc?t=01h33m55s)

[yeah we'll go with that and then](https://youtu.be/FDFGfYJPLOc?t=01h34m05s)

[i wonder if i should target the test](https://youtu.be/FDFGfYJPLOc?t=01h34m08s)

[adapter one specifically](https://youtu.be/FDFGfYJPLOc?t=01h34m10s)

[no because that doesn't have it](https://youtu.be/FDFGfYJPLOc?t=01h34m14s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h34m17s)

[starts with](https://youtu.be/FDFGfYJPLOc?t=01h34m18s)

[x unit](https://youtu.be/FDFGfYJPLOc?t=01h34m21s)

[this will be n unit](https://youtu.be/FDFGfYJPLOc?t=01h34m23s)

[x unit okay](https://youtu.be/FDFGfYJPLOc?t=01h34m28s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h34m30s)

[if that works](https://youtu.be/FDFGfYJPLOc?t=01h34m31s)

[but we're going to come down here](https://youtu.be/FDFGfYJPLOc?t=01h34m35s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h34m38s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h34m39s)

[that's the framework](https://youtu.be/FDFGfYJPLOc?t=01h34m41s)

[and](https://youtu.be/FDFGfYJPLOc?t=01h34m50s)

[work](https://youtu.be/FDFGfYJPLOc?t=01h34m51s)

[something like that something like that](https://youtu.be/FDFGfYJPLOc?t=01h34m53s)

[okay and then down](https://youtu.be/FDFGfYJPLOc?t=01h34m55s)

[here we're gonna just do](https://youtu.be/FDFGfYJPLOc?t=01h34m58s)

[switch](https://youtu.be/FDFGfYJPLOc?t=01h35m01s)

[testing framework](https://youtu.be/FDFGfYJPLOc?t=01h35m04s)

[and](https://youtu.be/FDFGfYJPLOc?t=01h35m07s)

[case](https://youtu.be/FDFGfYJPLOc?t=01h35m10s)

[testing framework ms test](https://youtu.be/FDFGfYJPLOc?t=01h35m11s)

[tack this in](https://youtu.be/FDFGfYJPLOc?t=01h35m16s)

[just start adding in these other ones](https://youtu.be/FDFGfYJPLOc?t=01h35m22s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h35m25s)

[x unit](https://youtu.be/FDFGfYJPLOc?t=01h35m26s)

[obviously that's wrong but we will fix](https://youtu.be/FDFGfYJPLOc?t=01h35m29s)

[it in a minute](https://youtu.be/FDFGfYJPLOc?t=01h35m32s)

[case](https://youtu.be/FDFGfYJPLOc?t=01h35m33s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h35m35s)

[n unit](https://youtu.be/FDFGfYJPLOc?t=01h35m38s)

[and paste that in okay so let's go get](https://youtu.be/FDFGfYJPLOc?t=01h35m44s)

[those ones](https://youtu.be/FDFGfYJPLOc?t=01h35m47s)

[those ones all have them so n units](https://youtu.be/FDFGfYJPLOc?t=01h35m48s)

[thing is](https://youtu.be/FDFGfYJPLOc?t=01h35m51s)

[n unit framework dot test](https://youtu.be/FDFGfYJPLOc?t=01h35m53s)

[that's easy enough to do](https://youtu.be/FDFGfYJPLOc?t=01h35m56s)

[in unit framework](https://youtu.be/FDFGfYJPLOc?t=01h36m00s)

[test](https://youtu.be/FDFGfYJPLOc?t=01h36m03s)

[and then x unit is](https://youtu.be/FDFGfYJPLOc?t=01h36m05s)

[fact](https://youtu.be/FDFGfYJPLOc?t=01h36m08s)

[i think it's just x unit dot backed so](https://youtu.be/FDFGfYJPLOc?t=01h36m10s)

[that's also easy enough to do](https://youtu.be/FDFGfYJPLOc?t=01h36m13s)

[get rid of you don't need you anymore](https://youtu.be/FDFGfYJPLOc?t=01h36m16s)

[back right is what we saw said it was](https://youtu.be/FDFGfYJPLOc?t=01h36m28s)

[where's the x unit one](https://youtu.be/FDFGfYJPLOc?t=01h36m31s)

[capital x lowercase u](https://youtu.be/FDFGfYJPLOc?t=01h36m35s)

[i'm wondering if i should do that for](https://youtu.be/FDFGfYJPLOc?t=01h36m39s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h36m40s)

[probably do that down here for](https://youtu.be/FDFGfYJPLOc?t=01h36m44s)

[this guy as well so we'll change him](https://youtu.be/FDFGfYJPLOc?t=01h36m46s)

[capital x lowercase u](https://youtu.be/FDFGfYJPLOc?t=01h36m49s)

[looks a little funny but we'll go with](https://youtu.be/FDFGfYJPLOc?t=01h36m52s)

[it](https://youtu.be/FDFGfYJPLOc?t=01h36m54s)

[that's what they do for their namespace](https://youtu.be/FDFGfYJPLOc?t=01h36m55s)

[so it can't be that bad](https://youtu.be/FDFGfYJPLOc?t=01h36m56s)

[okay so that gets me into there](https://youtu.be/FDFGfYJPLOc?t=01h36m58s)

[the rest of that remains the same](https://youtu.be/FDFGfYJPLOc?t=01h37m02s)

[that remains the same](https://youtu.be/FDFGfYJPLOc?t=01h37m04s)

[okay and then this becomes the](https://youtu.be/FDFGfYJPLOc?t=01h37m06s)

[interesting line](https://youtu.be/FDFGfYJPLOc?t=01h37m09s)

[so these two are going to be](https://youtu.be/FDFGfYJPLOc?t=01h37m12s)

[different](https://youtu.be/FDFGfYJPLOc?t=01h37m15s)

[depending on the target framework as](https://youtu.be/FDFGfYJPLOc?t=01h37m16s)

[well so we will put in the same switch](https://youtu.be/FDFGfYJPLOc?t=01h37m18s)

[copy paste](https://youtu.be/FDFGfYJPLOc?t=01h37m22s)

[and then in this case we're going to go](https://youtu.be/FDFGfYJPLOc?t=01h37m24s)

[here](https://youtu.be/FDFGfYJPLOc?t=01h37m28s)

[and it's not clear the goal here in just](https://youtu.be/FDFGfYJPLOc?t=01h37m30s)

[a second is to turn this on for all of](https://youtu.be/FDFGfYJPLOc?t=01h37m32s)

[the](https://youtu.be/FDFGfYJPLOc?t=01h37m33s)

[the tests](https://youtu.be/FDFGfYJPLOc?t=01h37m35s)

[and then this will go here](https://youtu.be/FDFGfYJPLOc?t=01h37m37s)

[okay so for let's do x unit i guess](https://youtu.be/FDFGfYJPLOc?t=01h37m40s)

[since we got this highlighted](https://youtu.be/FDFGfYJPLOc?t=01h37m43s)

[uh so it's x unit dot assert and i think](https://youtu.be/FDFGfYJPLOc?t=01h37m46s)

[most everything else remains the same](https://youtu.be/FDFGfYJPLOc?t=01h37m50s)

[this is just going to be](https://youtu.be/FDFGfYJPLOc?t=01h37m54s)

[oh](https://youtu.be/FDFGfYJPLOc?t=01h38m00s)

[uh x](https://youtu.be/FDFGfYJPLOc?t=01h38m01s)

[unit dot assert](https://youtu.be/FDFGfYJPLOc?t=01h38m02s)

[and](https://youtu.be/FDFGfYJPLOc?t=01h38m06s)

[this becomes](https://youtu.be/FDFGfYJPLOc?t=01h38m07s)

[well this is just throws not throws](https://youtu.be/FDFGfYJPLOc?t=01h38m10s)

[exception](https://youtu.be/FDFGfYJPLOc?t=01h38m11s)

[thumb you down a little bit but the rest](https://youtu.be/FDFGfYJPLOc?t=01h38m14s)

[of it's just about the same](https://youtu.be/FDFGfYJPLOc?t=01h38m16s)

[that works](https://youtu.be/FDFGfYJPLOc?t=01h38m18s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h38m19s)

[end unit](https://youtu.be/FDFGfYJPLOc?t=01h38m20s)

[and this is going to be](https://youtu.be/FDFGfYJPLOc?t=01h38m23s)

[sort of throws](https://youtu.be/FDFGfYJPLOc?t=01h38m27s)

[uh okay](https://youtu.be/FDFGfYJPLOc?t=01h38m32s)

[insert r equals so n unit framework](https://youtu.be/FDFGfYJPLOc?t=01h38m34s)

[and unit framework so i just need that](https://youtu.be/FDFGfYJPLOc?t=01h38m37s)

[prefix on both of those asserts](https://youtu.be/FDFGfYJPLOc?t=01h38m39s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h38m45s)

[that goes there](https://youtu.be/FDFGfYJPLOc?t=01h38m46s)

[that lines up](https://youtu.be/FDFGfYJPLOc?t=01h38m49s)

[this one goes here and this one is also](https://youtu.be/FDFGfYJPLOc?t=01h38m52s)

[just](https://youtu.be/FDFGfYJPLOc?t=01h38m54s)

[throws so i think that's everything](https://youtu.be/FDFGfYJPLOc?t=01h38m56s)

[needed to get that working for the other](https://youtu.be/FDFGfYJPLOc?t=01h38m59s)

[two test projects so let's go turn them](https://youtu.be/FDFGfYJPLOc?t=01h39m01s)

[on](https://youtu.be/FDFGfYJPLOc?t=01h39m03s)

[so like we did before we're gonna add in](https://youtu.be/FDFGfYJPLOc?t=01h39m04s)

[project reference](https://youtu.be/FDFGfYJPLOc?t=01h39m07s)

[end unit](https://youtu.be/FDFGfYJPLOc?t=01h39m10s)

[we'll add in the analyzer boom](https://youtu.be/FDFGfYJPLOc?t=01h39m11s)

[x unit we will add in](https://youtu.be/FDFGfYJPLOc?t=01h39m15s)

[there](https://youtu.be/FDFGfYJPLOc?t=01h39m21s)

[popping a weird jit debugger thing](https://youtu.be/FDFGfYJPLOc?t=01h39m25s)

[see what's going on there](https://youtu.be/FDFGfYJPLOc?t=01h39m29s)

[rebuild](https://youtu.be/FDFGfYJPLOc?t=01h39m31s)

[just make sure](https://youtu.be/FDFGfYJPLOc?t=01h39m32s)

[they have that thing turned off it](https://youtu.be/FDFGfYJPLOc?t=01h39m34s)

[shouldn't be popping it](https://youtu.be/FDFGfYJPLOc?t=01h39m35s)

[okay so that goes there that goes there](https://youtu.be/FDFGfYJPLOc?t=01h39m37s)

[and then just like we had the emit](https://youtu.be/FDFGfYJPLOc?t=01h39m39s)

[turned on on the one](https://youtu.be/FDFGfYJPLOc?t=01h39m41s)

[turn the emit on the others](https://youtu.be/FDFGfYJPLOc?t=01h39m43s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h39m49s)

[now](https://youtu.be/FDFGfYJPLOc?t=01h39m51s)

[we'll rebuild ms test verify it works](https://youtu.be/FDFGfYJPLOc?t=01h39m52s)

[compiled so it couldn't be that bad](https://youtu.be/FDFGfYJPLOc?t=01h39m57s)

[rebuild end unit](https://youtu.be/FDFGfYJPLOc?t=01h40m00s)

[and one other thing to note is](https://youtu.be/FDFGfYJPLOc?t=01h40m04s)

[underneath this analyzer you'll note](https://youtu.be/FDFGfYJPLOc?t=01h40m05s)

[that our thing shows up you can also get](https://youtu.be/FDFGfYJPLOc?t=01h40m07s)

[a view of your source code](https://youtu.be/FDFGfYJPLOc?t=01h40m10s)

[down here as well](https://youtu.be/FDFGfYJPLOc?t=01h40m12s)

[but that doesn't appear to be showing it](https://youtu.be/FDFGfYJPLOc?t=01h40m18s)

[we'll find out why here in a moment](https://youtu.be/FDFGfYJPLOc?t=01h40m22s)

[uh let's see x unit failed for some](https://youtu.be/FDFGfYJPLOc?t=01h40m28s)

[reason](https://youtu.be/FDFGfYJPLOc?t=01h40m31s)

[uh let's look at the output here](https://youtu.be/FDFGfYJPLOc?t=01h40m35s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h40m37s)

[unable to test classes must be public](https://youtu.be/FDFGfYJPLOc?t=01h40m40s)

[oh am i not generating these classes as](https://youtu.be/FDFGfYJPLOc?t=01h40m44s)

[public](https://youtu.be/FDFGfYJPLOc?t=01h40m46s)

[probably should be if i'm not](https://youtu.be/FDFGfYJPLOc?t=01h40m48s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h40m52s)

[source generator so](https://youtu.be/FDFGfYJPLOc?t=01h40m53s)

[partial class](https://youtu.be/FDFGfYJPLOc?t=01h41m00s)

[that seems to imply that the](https://youtu.be/FDFGfYJPLOc?t=01h41m01s)

[name of this](https://youtu.be/FDFGfYJPLOc?t=01h41m07s)

[oh](https://youtu.be/FDFGfYJPLOc?t=01h41m12s)

[it's generating into a different name](https://youtu.be/FDFGfYJPLOc?t=01h41m13s)

[space](https://youtu.be/FDFGfYJPLOc?t=01h41m15s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h41m18s)

[so the partial that's being generated](https://youtu.be/FDFGfYJPLOc?t=01h41m20s)

[has a hard-coded namespace](https://youtu.be/FDFGfYJPLOc?t=01h41m27s)

[which is a problem okay so we need to we](https://youtu.be/FDFGfYJPLOc?t=01h41m33s)

[need to solve that one before we're](https://youtu.be/FDFGfYJPLOc?t=01h41m37s)

[going to get too](https://youtu.be/FDFGfYJPLOc?t=01h41m38s)

[too much further because](https://youtu.be/FDFGfYJPLOc?t=01h41m39s)

[x units happy about it um](https://youtu.be/FDFGfYJPLOc?t=01h41m43s)

[our x units unhappy about it and](https://youtu.be/FDFGfYJPLOc?t=01h41m47s)

[rightfully slope](https://youtu.be/FDFGfYJPLOc?t=01h41m49s)

[rightfully so so let's figure out what's](https://youtu.be/FDFGfYJPLOc?t=01h41m50s)

[going on there](https://youtu.be/FDFGfYJPLOc?t=01h41m53s)

[i'm gonna come back in here](https://youtu.be/FDFGfYJPLOc?t=01h41m54s)

[and this on rebuild the generator](https://youtu.be/FDFGfYJPLOc?t=01h41m57s)

[we're going to come here](https://youtu.be/FDFGfYJPLOc?t=01h42m01s)

[yeah break point still set we're going](https://youtu.be/FDFGfYJPLOc?t=01h42m03s)

[to rebuild x unit](https://youtu.be/FDFGfYJPLOc?t=01h42m04s)

[i'm a little curious why](https://youtu.be/FDFGfYJPLOc?t=01h42m09s)

[five okay](https://youtu.be/FDFGfYJPLOc?t=01h42m17s)

[the namespace is empty string okay great](https://youtu.be/FDFGfYJPLOc?t=01h42m21s)

[so let's go](https://youtu.be/FDFGfYJPLOc?t=01h42m26s)

[into here](https://youtu.be/FDFGfYJPLOc?t=01h42m30s)

[so class declaration ancestors of type](https://youtu.be/FDFGfYJPLOc?t=01h42m35s)

[return nothing](https://youtu.be/FDFGfYJPLOc?t=01h42m38s)

[let's go here and take a look at class](https://youtu.be/FDFGfYJPLOc?t=01h42m40s)

[declaration](https://youtu.be/FDFGfYJPLOc?t=01h42m43s)

[ancestors](https://youtu.be/FDFGfYJPLOc?t=01h42m44s)

[list](https://youtu.be/FDFGfYJPLOc?t=01h42m47s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h42m53s)

[what](https://youtu.be/FDFGfYJPLOc?t=01h43m04s)

[just happened](https://youtu.be/FDFGfYJPLOc?t=01h43m05s)

[uh okay so that's too much stuff to look](https://youtu.be/FDFGfYJPLOc?t=01h43m06s)

[at and the](https://youtu.be/FDFGfYJPLOc?t=01h43m08s)

[uh how about just a straight](https://youtu.be/FDFGfYJPLOc?t=01h43m12s)

[count](https://youtu.be/FDFGfYJPLOc?t=01h43m14s)

[two](https://youtu.be/FDFGfYJPLOc?t=01h43m16s)

[uh so](https://youtu.be/FDFGfYJPLOc?t=01h43m18s)

[two list](https://youtu.be/FDFGfYJPLOc?t=01h43m21s)

[r a gets](https://youtu.be/FDFGfYJPLOc?t=01h43m23s)

[evaluate that a sub zero is](https://youtu.be/FDFGfYJPLOc?t=01h43m26s)

[what](https://youtu.be/FDFGfYJPLOc?t=01h43m30s)

[uh let's see file scope namespace](https://youtu.be/FDFGfYJPLOc?t=01h43m39s)

[declaration](https://youtu.be/FDFGfYJPLOc?t=01h43m42s)

[got it so that is a bit of a problem](https://youtu.be/FDFGfYJPLOc?t=01h43m49s)

[because file scope namespace declaration](https://youtu.be/FDFGfYJPLOc?t=01h43m53s)

[syntax is apparently not a namespace](https://youtu.be/FDFGfYJPLOc?t=01h43m55s)

[declaration syntax](https://youtu.be/FDFGfYJPLOc?t=01h43m57s)

[we probably want to target base](https://youtu.be/FDFGfYJPLOc?t=01h44m00s)

[namespace declaration syntax as the](https://youtu.be/FDFGfYJPLOc?t=01h44m02s)

[i'm gonna go with you both probably](https://youtu.be/FDFGfYJPLOc?t=01h44m07s)

[derived from base](https://youtu.be/FDFGfYJPLOc?t=01h44m09s)

[not immediately apparent](https://youtu.be/FDFGfYJPLOc?t=01h44m14s)

[yeah base name space declaration syntax](https://youtu.be/FDFGfYJPLOc?t=01h44m16s)

[so we want to we want to target this](https://youtu.be/FDFGfYJPLOc?t=01h44m19s)

[that's that's why it's falling apart](https://youtu.be/FDFGfYJPLOc?t=01h44m23s)

[we want that](https://youtu.be/FDFGfYJPLOc?t=01h44m27s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h44m30s)

[and now if we rebuild the source](https://youtu.be/FDFGfYJPLOc?t=01h44m33s)

[generator](https://youtu.be/FDFGfYJPLOc?t=01h44m35s)

[and then we can probably put this guy](https://youtu.be/FDFGfYJPLOc?t=01h44m38s)

[back to](https://youtu.be/FDFGfYJPLOc?t=01h44m39s)

[namespace declaration but we will](https://youtu.be/FDFGfYJPLOc?t=01h44m44s)

[gonna check it here real quick and make](https://youtu.be/FDFGfYJPLOc?t=01h44m47s)

[sure it actually does work](https://youtu.be/FDFGfYJPLOc?t=01h44m48s)

[and then rebuild you](https://youtu.be/FDFGfYJPLOc?t=01h44m51s)

[pop my debugger please](https://youtu.be/FDFGfYJPLOc?t=01h44m54s)

[thank you](https://youtu.be/FDFGfYJPLOc?t=01h45m01s)

[thank you](https://youtu.be/FDFGfYJPLOc?t=01h45m04s)

[namespace declaration is now correct](https://youtu.be/FDFGfYJPLOc?t=01h45m10s)

[excellent excellent excellent okay so](https://youtu.be/FDFGfYJPLOc?t=01h45m12s)

[we're going to go back into here](https://youtu.be/FDFGfYJPLOc?t=01h45m16s)

[from you off](https://youtu.be/FDFGfYJPLOc?t=01h45m19s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h45m23s)

[okay so now we're running into the the](https://youtu.be/FDFGfYJPLOc?t=01h45m28s)

[duplicate test name problem which is](https://youtu.be/FDFGfYJPLOc?t=01h45m30s)

[as we expect so let's comment out these](https://youtu.be/FDFGfYJPLOc?t=01h45m33s)

[tests](https://youtu.be/FDFGfYJPLOc?t=01h45m35s)

[comment out these tests](https://youtu.be/FDFGfYJPLOc?t=01h45m39s)

[stop](https://youtu.be/FDFGfYJPLOc?t=01h45m43s)

[and then we are going to](https://youtu.be/FDFGfYJPLOc?t=01h45m45s)

[rebuild that guy and then i want to](https://youtu.be/FDFGfYJPLOc?t=01h45m48s)

[rebuild each of these and see my test](https://youtu.be/FDFGfYJPLOc?t=01h45m49s)

[work so rebuild](https://youtu.be/FDFGfYJPLOc?t=01h45m51s)

[and rebuild](https://youtu.be/FDFGfYJPLOc?t=01h46m00s)

[and](https://youtu.be/FDFGfYJPLOc?t=01h46m05s)

[rebuild](https://youtu.be/FDFGfYJPLOc?t=01h46m09s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h46m13s)

[uh so i messed up on one of these](https://youtu.be/FDFGfYJPLOc?t=01h46m15s)

[see which project am i in x unit](https://youtu.be/FDFGfYJPLOc?t=01h46m19s)

[oh it's just a cert](https://youtu.be/FDFGfYJPLOc?t=01h46m22s)

[equals right yeah certain equal](https://youtu.be/FDFGfYJPLOc?t=01h46m24s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h46m28s)

[i need to change the](https://youtu.be/FDFGfYJPLOc?t=01h46m28s)

[generator for the x unit case](https://youtu.be/FDFGfYJPLOc?t=01h46m31s)

[to assert equal](https://youtu.be/FDFGfYJPLOc?t=01h46m35s)

[rebuild the generator](https://youtu.be/FDFGfYJPLOc?t=01h46m39s)

[rebuild x unit](https://youtu.be/FDFGfYJPLOc?t=01h46m42s)

[okay so they're all compiled](https://youtu.be/FDFGfYJPLOc?t=01h46m47s)

[we come over here](https://youtu.be/FDFGfYJPLOc?t=01h46m50s)

[this thing's probably about to freak out](https://youtu.be/FDFGfYJPLOc?t=01h46m53s)

[for a moment](https://youtu.be/FDFGfYJPLOc?t=01h46m55s)

[there's the](https://youtu.be/FDFGfYJPLOc?t=01h46m57s)

[the generated test](https://youtu.be/FDFGfYJPLOc?t=01h46m58s)

[for x unit so if we run that that should](https://youtu.be/FDFGfYJPLOc?t=01h47m01s)

[show up](https://youtu.be/FDFGfYJPLOc?t=01h47m04s)

[great](https://youtu.be/FDFGfYJPLOc?t=01h47m07s)

[i should be able to](https://youtu.be/FDFGfYJPLOc?t=01h47m08s)

[do the same thing for n unit rebuild](https://youtu.be/FDFGfYJPLOc?t=01h47m11s)

[are you not showing in here same with ms](https://youtu.be/FDFGfYJPLOc?t=01h47m30s)

[tess](https://youtu.be/FDFGfYJPLOc?t=01h47m32s)

[rebuild](https://youtu.be/FDFGfYJPLOc?t=01h47m33s)

[wondering if this guy is not hip to the](https://youtu.be/FDFGfYJPLOc?t=01h47m35s)

[idea of](https://youtu.be/FDFGfYJPLOc?t=01h47m37s)

[getting confused with multiple test](https://youtu.be/FDFGfYJPLOc?t=01h47m39s)

[runners all being loaded at once](https://youtu.be/FDFGfYJPLOc?t=01h47m41s)

[see run tests](https://youtu.be/FDFGfYJPLOc?t=01h47m44s)

[the ms test one doesn't appear to want](https://youtu.be/FDFGfYJPLOc?t=01h47m52s)

[to run](https://youtu.be/FDFGfYJPLOc?t=01h47m55s)

[run tests](https://youtu.be/FDFGfYJPLOc?t=01h47m57s)

[can i run all](https://youtu.be/FDFGfYJPLOc?t=01h48m01s)

[uh where's the run test there](https://youtu.be/FDFGfYJPLOc?t=01h48m04s)

[target an assembly](https://youtu.be/FDFGfYJPLOc?t=01h48m08s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h48m14s)

[feeling like this is uh](https://youtu.be/FDFGfYJPLOc?t=01h48m17s)

[so it found](https://youtu.be/FDFGfYJPLOc?t=01h48m24s)

[the x unit one](https://youtu.be/FDFGfYJPLOc?t=01h48m27s)

[worries me is i'm i'm wondering if the x](https://youtu.be/FDFGfYJPLOc?t=01h48m32s)

[unit one is somehow hijacking this guy](https://youtu.be/FDFGfYJPLOc?t=01h48m34s)

[the um test discovery](https://youtu.be/FDFGfYJPLOc?t=01h48m37s)

[i would hope that you could do this but](https://youtu.be/FDFGfYJPLOc?t=01h48m42s)

[i've honestly never tried to have](https://youtu.be/FDFGfYJPLOc?t=01h48m44s)

[multiple test frameworks in the same](https://youtu.be/FDFGfYJPLOc?t=01h48m45s)

[solution have visual studio handle it](https://youtu.be/FDFGfYJPLOc?t=01h48m47s)

[um it's also possible that the code](https://youtu.be/FDFGfYJPLOc?t=01h48m50s)

[generation on these other ones isn't](https://youtu.be/FDFGfYJPLOc?t=01h48m52s)

[working so let's go back to](https://youtu.be/FDFGfYJPLOc?t=01h48m54s)

[start with ms test because this one was](https://youtu.be/FDFGfYJPLOc?t=01h48m58s)

[working](https://youtu.be/FDFGfYJPLOc?t=01h49m00s)

[and was generating appropriately so](https://youtu.be/FDFGfYJPLOc?t=01h49m02s)

[we're going to look at the generated](https://youtu.be/FDFGfYJPLOc?t=01h49m04s)

[file first of all](https://youtu.be/FDFGfYJPLOc?t=01h49m05s)

[chase it all the way in](https://youtu.be/FDFGfYJPLOc?t=01h49m08s)

[so this one ended up not](https://youtu.be/FDFGfYJPLOc?t=01h49m18s)

[so i'm noticing the attributes missing](https://youtu.be/FDFGfYJPLOc?t=01h49m22s)

[and everything else so this thing](https://youtu.be/FDFGfYJPLOc?t=01h49m24s)

[did not discover ms test](https://youtu.be/FDFGfYJPLOc?t=01h49m27s)

[is there a difference between the](https://youtu.be/FDFGfYJPLOc?t=01h49m33s)

[assembly name and](https://youtu.be/FDFGfYJPLOc?t=01h49m36s)

[i wonder if there's a subtle](https://youtu.be/FDFGfYJPLOc?t=01h49m44s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h49m46s)

[uh i bet you it's this](https://youtu.be/FDFGfYJPLOc?t=01h49m48s)

[microsoft visual studio test platform](https://youtu.be/FDFGfYJPLOc?t=01h49m50s)

[so let's start there i bet you there's a](https://youtu.be/FDFGfYJPLOc?t=01h49m53s)

[difference between the nuget package](https://youtu.be/FDFGfYJPLOc?t=01h49m55s)

[name and the](https://youtu.be/FDFGfYJPLOc?t=01h49m57s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h50m00s)

[and the compiled assembly](https://youtu.be/FDFGfYJPLOc?t=01h50m01s)

[so that's fine we can come down here we](https://youtu.be/FDFGfYJPLOc?t=01h50m04s)

[can change this in one](https://youtu.be/FDFGfYJPLOc?t=01h50m05s)

[one sweep of our hands](https://youtu.be/FDFGfYJPLOc?t=01h50m07s)

[microsoft](https://youtu.be/FDFGfYJPLOc?t=01h50m11s)

[visual studio](https://youtu.be/FDFGfYJPLOc?t=01h50m14s)

[test](https://youtu.be/FDFGfYJPLOc?t=01h50m17s)

[platform](https://youtu.be/FDFGfYJPLOc?t=01h50m18s)

[we'll start](https://youtu.be/FDFGfYJPLOc?t=01h50m21s)

[there](https://youtu.be/FDFGfYJPLOc?t=01h50m22s)

[rebuild this](https://youtu.be/FDFGfYJPLOc?t=01h50m24s)

[and then rebuild this and now i'm](https://youtu.be/FDFGfYJPLOc?t=01h50m29s)

[wondering if it shows up](https://youtu.be/FDFGfYJPLOc?t=01h50m31s)

[because we had it working before we put](https://youtu.be/FDFGfYJPLOc?t=01h50m34s)

[in that target test framework and i'm](https://youtu.be/FDFGfYJPLOc?t=01h50m35s)

[wondering if that's what](https://youtu.be/FDFGfYJPLOc?t=01h50m37s)

[messed it up](https://youtu.be/FDFGfYJPLOc?t=01h50m39s)

[that it did that it did okay so that got](https://youtu.be/FDFGfYJPLOc?t=01h50m41s)

[ms test back in and working great](https://youtu.be/FDFGfYJPLOc?t=01h50m43s)

[okay let's do end unit](https://youtu.be/FDFGfYJPLOc?t=01h50m46s)

[why are you unhappy now let's check for](https://youtu.be/FDFGfYJPLOc?t=01h50m49s)

[the same exact problem](https://youtu.be/FDFGfYJPLOc?t=01h50m52s)

[if there is a](https://youtu.be/FDFGfYJPLOc?t=01h50m54s)

[oh](https://youtu.be/FDFGfYJPLOc?t=01h51m01s)

[n unit dot](https://youtu.be/FDFGfYJPLOc?t=01h51m02s)

[i wonder if x unit is going to be an x](https://youtu.be/FDFGfYJPLOc?t=01h51m06s)

[unit dot that we can do as well](https://youtu.be/FDFGfYJPLOc?t=01h51m08s)

[yeah x unit dot](https://youtu.be/FDFGfYJPLOc?t=01h51m12s)

[we're going to do that](https://youtu.be/FDFGfYJPLOc?t=01h51m14s)

[and then let's see](https://youtu.be/FDFGfYJPLOc?t=01h51m21s)

[rebuild the generator](https://youtu.be/FDFGfYJPLOc?t=01h51m23s)

[and then we're going to rebuild that](https://youtu.be/FDFGfYJPLOc?t=01h51m29s)

[and then rebuild that](https://youtu.be/FDFGfYJPLOc?t=01h51m36s)

[look like x unit had a problem](https://youtu.be/FDFGfYJPLOc?t=01h51m39s)

[test tools does not exist oh we're](https://youtu.be/FDFGfYJPLOc?t=01h51m43s)

[falling into the wrong one now](https://youtu.be/FDFGfYJPLOc?t=01h51m46s)

[because this guy has](https://youtu.be/FDFGfYJPLOc?t=01h51m49s)

[extra stuff](https://youtu.be/FDFGfYJPLOc?t=01h51m56s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h51m59s)

[so i need to look for something a little](https://youtu.be/FDFGfYJPLOc?t=01h52m04s)

[more hyper specific](https://youtu.be/FDFGfYJPLOc?t=01h52m06s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h52m09s)

[what is](https://youtu.be/FDFGfYJPLOc?t=01h52m10s)

[what is in here that would separate you](https://youtu.be/FDFGfYJPLOc?t=01h52m20s)

[microsoft visual studio test platform](https://youtu.be/FDFGfYJPLOc?t=01h52m24s)

[test](https://youtu.be/FDFGfYJPLOc?t=01h52m30s)

[framework](https://youtu.be/FDFGfYJPLOc?t=01h52m31s)

[narrow it down even further](https://youtu.be/FDFGfYJPLOc?t=01h52m38s)

[because it does include a little](https://youtu.be/FDFGfYJPLOc?t=01h52m40s)

[yeah because it does leverage all of](https://youtu.be/FDFGfYJPLOc?t=01h52m48s)

[these ones here](https://youtu.be/FDFGfYJPLOc?t=01h52m50s)

[i'm not overly shocked that that landed](https://youtu.be/FDFGfYJPLOc?t=01h52m53s)

[in the wrong one](https://youtu.be/FDFGfYJPLOc?t=01h52m56s)

[a rebuild end unit](https://youtu.be/FDFGfYJPLOc?t=01h52m58s)

[you happy](https://youtu.be/FDFGfYJPLOc?t=01h53m01s)

[framework does not exist inside of](https://youtu.be/FDFGfYJPLOc?t=01h53m09s)

[sounds like it landed on the wrong](https://youtu.be/FDFGfYJPLOc?t=01h53m19s)

[thing](https://youtu.be/FDFGfYJPLOc?t=01h53m21s)

[take a look](https://youtu.be/FDFGfYJPLOc?t=01h53m25s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h53m27s)

[where is the generating](https://youtu.be/FDFGfYJPLOc?t=01h53m33s)

[let's go](https://youtu.be/FDFGfYJPLOc?t=01h53m35s)

[are you going to actually show me the](https://youtu.be/FDFGfYJPLOc?t=01h53m38s)

[source generator no you're not going to](https://youtu.be/FDFGfYJPLOc?t=01h53m39s)

[be useful okay](https://youtu.be/FDFGfYJPLOc?t=01h53m42s)

[that's fine you can be unuseful today](https://youtu.be/FDFGfYJPLOc?t=01h53m43s)

[it's really nice when it works](https://youtu.be/FDFGfYJPLOc?t=01h53m47s)

[really kind of obnoxious when it doesn't](https://youtu.be/FDFGfYJPLOc?t=01h53m49s)

[so let's go back in here here](https://youtu.be/FDFGfYJPLOc?t=01h53m51s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=01h53m54s)

[but did detect it as n unit](https://youtu.be/FDFGfYJPLOc?t=01h53m58s)

[correctly](https://youtu.be/FDFGfYJPLOc?t=01h54m01s)

[what was your problem here](https://youtu.be/FDFGfYJPLOc?t=01h54m04s)

[let's see line five](https://youtu.be/FDFGfYJPLOc?t=01h54m08s)

[in unit framework dot test](https://youtu.be/FDFGfYJPLOc?t=01h54m12s)

[that not the right](https://youtu.be/FDFGfYJPLOc?t=01h54m16s)

[and](https://youtu.be/FDFGfYJPLOc?t=01h54m25s)

[unit framework](https://youtu.be/FDFGfYJPLOc?t=01h54m26s)

[dot test](https://youtu.be/FDFGfYJPLOc?t=01h54m28s)

[uh you can also try seeing the generated](https://youtu.be/FDFGfYJPLOc?t=01h54m30s)

[code in the class view i believe](https://youtu.be/FDFGfYJPLOc?t=01h54m32s)

[oh rather than solution one um](https://youtu.be/FDFGfYJPLOc?t=01h54m34s)

[no not here](https://youtu.be/FDFGfYJPLOc?t=01h54m43s)

[uh let's see](https://youtu.be/FDFGfYJPLOc?t=01h54m44s)

[ah so if we'll dock this guy on that](https://youtu.be/FDFGfYJPLOc?t=01h54m50s)

[side](https://youtu.be/FDFGfYJPLOc?t=01h54m53s)

[let's take a look so if i go n unit](https://youtu.be/FDFGfYJPLOc?t=01h54m54s)

[uh](https://youtu.be/FDFGfYJPLOc?t=01h54m58s)

[controller test](https://youtu.be/FDFGfYJPLOc?t=01h55m01s)

[well right now it's failing to compile](https://youtu.be/FDFGfYJPLOc?t=01h55m05s)

[so that's probably a bad example but](https://youtu.be/FDFGfYJPLOc?t=01h55m07s)

[let's go in here](https://youtu.be/FDFGfYJPLOc?t=01h55m09s)

[no](https://youtu.be/FDFGfYJPLOc?t=01h55m13s)

[let me get it compiling then i'll double](https://youtu.be/FDFGfYJPLOc?t=01h55m15s)

[check but i think you might be right](https://youtu.be/FDFGfYJPLOc?t=01h55m17s)

[i always forget about the class view it](https://youtu.be/FDFGfYJPLOc?t=01h55m20s)

[is a very useful tool and](https://youtu.be/FDFGfYJPLOc?t=01h55m21s)

[often underrated](https://youtu.be/FDFGfYJPLOc?t=01h55m25s)

[uh okay so we're going here](https://youtu.be/FDFGfYJPLOc?t=01h55m28s)

[and unit framework dot test](https://youtu.be/FDFGfYJPLOc?t=01h55m35s)

[actually here's what we're gonna do](https://youtu.be/FDFGfYJPLOc?t=01h55m43s)

[we're gonna literally just copy and](https://youtu.be/FDFGfYJPLOc?t=01h55m44s)

[paste you out](https://youtu.be/FDFGfYJPLOc?t=01h55m46s)

[what'd i do wrong](https://youtu.be/FDFGfYJPLOc?t=01h55m57s)

[i didn't find out about the excellent](https://youtu.be/FDFGfYJPLOc?t=01h56m01s)

[way of seeing the generated firehouse](https://youtu.be/FDFGfYJPLOc?t=01h56m03s)

[till today](https://youtu.be/FDFGfYJPLOc?t=01h56m05s)

[yeah and i oftentimes actually like](https://youtu.be/FDFGfYJPLOc?t=01h56m07s)

[um you can see how i've opened it here](https://youtu.be/FDFGfYJPLOc?t=01h56m10s)

[because visual studio if you just drag](https://youtu.be/FDFGfYJPLOc?t=01h56m12s)

[in a random c sharp file if that file](https://youtu.be/FDFGfYJPLOc?t=01h56m14s)

[updates on disk it'll update here as](https://youtu.be/FDFGfYJPLOc?t=01h56m16s)

[well even on compilation failure like](https://youtu.be/FDFGfYJPLOc?t=01h56m18s)

[i've noticed a lot of the generator](https://youtu.be/FDFGfYJPLOc?t=01h56m20s)

[tooling fails on compilation failure](https://youtu.be/FDFGfYJPLOc?t=01h56m22s)

[which is the exact time when i really](https://youtu.be/FDFGfYJPLOc?t=01h56m25s)

[want to look at it](https://youtu.be/FDFGfYJPLOc?t=01h56m27s)

[it's like i would like to go and see it](https://youtu.be/FDFGfYJPLOc?t=01h56m29s)

[when it fails that's like the most](https://youtu.be/FDFGfYJPLOc?t=01h56m31s)

[likely time i want to go look at it](https://youtu.be/FDFGfYJPLOc?t=01h56m33s)

[so oftentimes i'll just leave leave this](https://youtu.be/FDFGfYJPLOc?t=01h56m38s)

[open](https://youtu.be/FDFGfYJPLOc?t=01h56m40s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h56m42s)

[framework does not exist in the](https://youtu.be/FDFGfYJPLOc?t=01h56m45s)

[namespace](https://youtu.be/FDFGfYJPLOc?t=01h56m47s)

[forgive me for questioning you but what](https://youtu.be/FDFGfYJPLOc?t=01h56m50s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h56m56s)

[so conveniently i'm getting the same air](https://youtu.be/FDFGfYJPLOc?t=01h56m58s)

[but i don't understand why](https://youtu.be/FDFGfYJPLOc?t=01h57m01s)

[bring you off for a moment](https://youtu.be/FDFGfYJPLOc?t=01h57m04s)

[are you off for a moment okay so](https://youtu.be/FDFGfYJPLOc?t=01h57m07s)

[we got that figured out](https://youtu.be/FDFGfYJPLOc?t=01h57m10s)

[oh](https://youtu.be/FDFGfYJPLOc?t=01h57m13s)

[suck sucks](https://youtu.be/FDFGfYJPLOc?t=01h57m19s)

[okay so](https://youtu.be/FDFGfYJPLOc?t=01h57m32s)

[here's a fun c sharp problem](https://youtu.be/FDFGfYJPLOc?t=01h57m34s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h57m39s)

[this compiles](https://youtu.be/FDFGfYJPLOc?t=01h57m40s)

[this doesn't](https://youtu.be/FDFGfYJPLOc?t=01h57m42s)

[despite the fact that this is a fully](https://youtu.be/FDFGfYJPLOc?t=01h57m45s)

[qualified name](https://youtu.be/FDFGfYJPLOc?t=01h57m47s)

[the re and this is part of why i was](https://youtu.be/FDFGfYJPLOc?t=01h57m52s)

[like oh i could add the using statements](https://youtu.be/FDFGfYJPLOc?t=01h57m53s)

[into my generator file oh but that could](https://youtu.be/FDFGfYJPLOc?t=01h57m55s)

[run into weird collisions yes like this](https://youtu.be/FDFGfYJPLOc?t=01h57m57s)

[like this and even without doing it it](https://youtu.be/FDFGfYJPLOc?t=01h58m00s)

[ran into weird collisions](https://youtu.be/FDFGfYJPLOc?t=01h58m02s)

[so](https://youtu.be/FDFGfYJPLOc?t=01h58m04s)

[there is a concept of so there are](https://youtu.be/FDFGfYJPLOc?t=01h58m05s)

[there are three levels to specify an](https://youtu.be/FDFGfYJPLOc?t=01h58m08s)

[identifier in c sharp there's the name](https://youtu.be/FDFGfYJPLOc?t=01h58m10s)

[there's the fully qualified name and](https://youtu.be/FDFGfYJPLOc?t=01h58m12s)

[then there's the assembly qualified name](https://youtu.be/FDFGfYJPLOc?t=01h58m14s)

[each working their way up the hierarchy](https://youtu.be/FDFGfYJPLOc?t=01h58m17s)

[in this case because i have a namespace](https://youtu.be/FDFGfYJPLOc?t=01h58m20s)

[in this project that's n unit it is](https://youtu.be/FDFGfYJPLOc?t=01h58m23s)

[trying to go relative to this end unit](https://youtu.be/FDFGfYJPLOc?t=01h58m26s)

[do dot framework and find the test](https://youtu.be/FDFGfYJPLOc?t=01h58m29s)

[attribute](https://youtu.be/FDFGfYJPLOc?t=01h58m31s)

[which it's obviously not going to find](https://youtu.be/FDFGfYJPLOc?t=01h58m32s)

[but once i tell it no no no no no](https://youtu.be/FDFGfYJPLOc?t=01h58m34s)

[don't this isn't relative start from the](https://youtu.be/FDFGfYJPLOc?t=01h58m36s)

[global namespace and this is the fully](https://youtu.be/FDFGfYJPLOc?t=01h58m39s)

[qualified name then it finds it oh that](https://youtu.be/FDFGfYJPLOc?t=01h58m41s)

[is dumb](https://youtu.be/FDFGfYJPLOc?t=01h58m43s)

[that dum dum dum dum](https://youtu.be/FDFGfYJPLOc?t=01h58m45s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h58m49s)

[okay we are gonna we're gonna massively](https://youtu.be/FDFGfYJPLOc?t=01h58m50s)

[qualify some stuff](https://youtu.be/FDFGfYJPLOc?t=01h58m53s)

[i'm gonna massively qualify this beast](https://youtu.be/FDFGfYJPLOc?t=01h58m55s)

[okay](https://youtu.be/FDFGfYJPLOc?t=01h58m57s)

[um yes gross is the appropriate response](https://youtu.be/FDFGfYJPLOc?t=01h58m58s)

[to that](https://youtu.be/FDFGfYJPLOc?t=01h59m02s)

[we are going to fully qualify all of](https://youtu.be/FDFGfYJPLOc?t=01h59m03s)

[those while we're in here](https://youtu.be/FDFGfYJPLOc?t=01h59m05s)

[fully qualify that fully qualify that](https://youtu.be/FDFGfYJPLOc?t=01h59m07s)

[like this is generated code it's once](https://youtu.be/FDFGfYJPLOc?t=01h59m11s)

[it's working ideally no one has to look](https://youtu.be/FDFGfYJPLOc?t=01h59m13s)

[at it](https://youtu.be/FDFGfYJPLOc?t=01h59m15s)

[um](https://youtu.be/FDFGfYJPLOc?t=01h59m18s)

[but that will ensure that it is not](https://youtu.be/FDFGfYJPLOc?t=01h59m21s)

[that if you put your that hypothetically](https://youtu.be/FDFGfYJPLOc?t=01h59m25s)

[if you do something dumb like me and put](https://youtu.be/FDFGfYJPLOc?t=01h59m28s)

[an end unit namespace in your](https://youtu.be/FDFGfYJPLOc?t=01h59m30s)

[in your test project it doesn't break](https://youtu.be/FDFGfYJPLOc?t=01h59m35s)

[which isn't](https://youtu.be/FDFGfYJPLOc?t=01h59m37s)

[terribly uncommon like i'll create uh](https://youtu.be/FDFGfYJPLOc?t=01h59m38s)

[like an n unit or an x unit namespace in](https://youtu.be/FDFGfYJPLOc?t=01h59m41s)

[my test project if i'm like writing](https://youtu.be/FDFGfYJPLOc?t=01h59m43s)

[extension methods to extend the test](https://youtu.be/FDFGfYJPLOc?t=01h59m45s)

[framework right that](https://youtu.be/FDFGfYJPLOc?t=01h59m47s)

[that's kind of a normal thing x unit is](https://youtu.be/FDFGfYJPLOc?t=01h59m49s)

[built to be extendable like](https://youtu.be/FDFGfYJPLOc?t=01h59m51s)

[so some of the projects i work on i](https://youtu.be/FDFGfYJPLOc?t=01h59m54s)

[built some extensions for them](https://youtu.be/FDFGfYJPLOc?t=01h59m56s)

[that's great](https://youtu.be/FDFGfYJPLOc?t=01h59m58s)

[they work it's wonderful](https://youtu.be/FDFGfYJPLOc?t=02h00m00s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h00m06s)

[and then rebuild](https://youtu.be/FDFGfYJPLOc?t=02h00m07s)

[okay so they all compile](https://youtu.be/FDFGfYJPLOc?t=02h00m09s)

[the okay they all compile](https://youtu.be/FDFGfYJPLOc?t=02h00m11s)

[test explorer find them all](https://youtu.be/FDFGfYJPLOc?t=02h00m14s)

[pretty please](https://youtu.be/FDFGfYJPLOc?t=02h00m16s)

[now that they all exist please go](https://youtu.be/FDFGfYJPLOc?t=02h00m19s)

[hunting them](https://youtu.be/FDFGfYJPLOc?t=02h00m21s)

[because i'd like them all to run next](https://youtu.be/FDFGfYJPLOc?t=02h00m24s)

[that's your next task](https://youtu.be/FDFGfYJPLOc?t=02h00m27s)

[come on what are you doing](https://youtu.be/FDFGfYJPLOc?t=02h00m30s)

[uh aborting test discovery because build](https://youtu.be/FDFGfYJPLOc?t=02h00m33s)

[was performed](https://youtu.be/FDFGfYJPLOc?t=02h00m36s)

[build solution](https://youtu.be/FDFGfYJPLOc?t=02h00m38s)

[okay everything's built](https://youtu.be/FDFGfYJPLOc?t=02h00m42s)

[what's your problem test explorer](https://youtu.be/FDFGfYJPLOc?t=02h00m45s)

[i'm gonna relaunch you because i i'm not](https://youtu.be/FDFGfYJPLOc?t=02h00m50s)

[trusting you at the moment](https://youtu.be/FDFGfYJPLOc?t=02h00m53s)

[i'm pretty sure you are](https://youtu.be/FDFGfYJPLOc?t=02h00m54s)

[oh that is the other drawback if you](https://youtu.be/FDFGfYJPLOc?t=02h00m58s)

[open a a generated file from the](https://youtu.be/FDFGfYJPLOc?t=02h00m59s)

[analyzers tab you currently get this](https://youtu.be/FDFGfYJPLOc?t=02h01m02s)

[error in preview visual studio it's](https://youtu.be/FDFGfYJPLOc?t=02h01m04s)

[really annoying and it won't go away](https://youtu.be/FDFGfYJPLOc?t=02h01m06s)

[until you close the tab](https://youtu.be/FDFGfYJPLOc?t=02h01m08s)

[it's a great feature](https://youtu.be/FDFGfYJPLOc?t=02h01m11s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h01m14s)

[test explorer](https://youtu.be/FDFGfYJPLOc?t=02h01m15s)

[you just got yourself wrapped around the](https://youtu.be/FDFGfYJPLOc?t=02h01m18s)

[axle or are you actually working](https://youtu.be/FDFGfYJPLOc?t=02h01m19s)

[i think you're wrapped around the axle i](https://youtu.be/FDFGfYJPLOc?t=02h01m26s)

[think it'll be quicker for me if i](https://youtu.be/FDFGfYJPLOc?t=02h01m28s)

[restart you](https://youtu.be/FDFGfYJPLOc?t=02h01m29s)

[we're going to start with that boom](https://youtu.be/FDFGfYJPLOc?t=02h01m31s)

[and i](https://youtu.be/FDFGfYJPLOc?t=02h01m37s)

[i i think it will work](https://youtu.be/FDFGfYJPLOc?t=02h01m38s)

[i think](https://youtu.be/FDFGfYJPLOc?t=02h01m41s)

[i can't promise any](https://youtu.be/FDFGfYJPLOc?t=02h01m44s)

[come on load](https://youtu.be/FDFGfYJPLOc?t=02h01m48s)

[load](https://youtu.be/FDFGfYJPLOc?t=02h01m52s)

[mountain dew is empty](https://youtu.be/FDFGfYJPLOc?t=02h01m55s)

[i'm trying to decide it's 11 o'clock do](https://youtu.be/FDFGfYJPLOc?t=02h01m58s)

[i crack into the next one or not](https://youtu.be/FDFGfYJPLOc?t=02h02m00s)

[it's really tempting](https://youtu.be/FDFGfYJPLOc?t=02h02m05s)

[it's really tempting](https://youtu.be/FDFGfYJPLOc?t=02h02m06s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h02m09s)

[because i'm clearly not done](https://youtu.be/FDFGfYJPLOc?t=02h02m10s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h02m14s)

[i've got a meeting in the morning](https://youtu.be/FDFGfYJPLOc?t=02h02m18s)

[but it's not until like nine](https://youtu.be/FDFGfYJPLOc?t=02h02m21s)

[that's okay right](https://youtu.be/FDFGfYJPLOc?t=02h02m24s)

[right](https://youtu.be/FDFGfYJPLOc?t=02h02m27s)

[i don't think any of the people in that](https://youtu.be/FDFGfYJPLOc?t=02h02m28s)

[meeting are watching the stream](https://youtu.be/FDFGfYJPLOc?t=02h02m29s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h02m32s)

[is this the wrong way to evaluate](https://youtu.be/FDFGfYJPLOc?t=02h02m34s)

[opening amount okay fine](https://youtu.be/FDFGfYJPLOc?t=02h02m36s)

[on a positive note](https://youtu.be/FDFGfYJPLOc?t=02h02m45s)

[go](https://youtu.be/FDFGfYJPLOc?t=02h02m55s)

[test pass test pass okay we immediately](https://youtu.be/FDFGfYJPLOc?t=02h02m57s)

[commit](https://youtu.be/FDFGfYJPLOc?t=02h02m59s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h03m01s)

[working generated](https://youtu.be/FDFGfYJPLOc?t=02h03m03s)

[tests](https://youtu.be/FDFGfYJPLOc?t=02h03m05s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h03m07s)

[you let's see](https://youtu.be/FDFGfYJPLOc?t=02h03m08s)

[using lots of hard](https://youtu.be/FDFGfYJPLOc?t=02h03m10s)

[coded values for now okay](https://youtu.be/FDFGfYJPLOc?t=02h03m12s)

[so we've got](https://youtu.be/FDFGfYJPLOc?t=02h03m16s)

[we've got the tests in and working](https://youtu.be/FDFGfYJPLOc?t=02h03m20s)

[we've got it switching based upon the](https://youtu.be/FDFGfYJPLOc?t=02h03m23s)

[target framework we might like i said we](https://youtu.be/FDFGfYJPLOc?t=02h03m25s)

[might add a config value at some point](https://youtu.be/FDFGfYJPLOc?t=02h03m27s)

[that you could specify in your cs proj](https://youtu.be/FDFGfYJPLOc?t=02h03m29s)

[to overwrite it if for example it's not](https://youtu.be/FDFGfYJPLOc?t=02h03m31s)

[detecting the right thing because](https://youtu.be/FDFGfYJPLOc?t=02h03m34s)

[you know one of these libraries changes](https://youtu.be/FDFGfYJPLOc?t=02h03m36s)

[or whatnot because we aren't going to](https://youtu.be/FDFGfYJPLOc?t=02h03m38s)

[ship a version of auto](https://youtu.be/FDFGfYJPLOc?t=02h03m40s)

[mocker that takes a hard dependency on](https://youtu.be/FDFGfYJPLOc?t=02h03m43s)

[any of these testing frameworks](https://youtu.be/FDFGfYJPLOc?t=02h03m45s)

[however](https://youtu.be/FDFGfYJPLOc?t=02h03m48s)

[if i gen the code i don't have to take a](https://youtu.be/FDFGfYJPLOc?t=02h03m49s)

[hard dependency](https://youtu.be/FDFGfYJPLOc?t=02h03m52s)

[which is even better because then the](https://youtu.be/FDFGfYJPLOc?t=02h03m53s)

[code lives in your project](https://youtu.be/FDFGfYJPLOc?t=02h03m55s)

[okay so let's see if we can figure out](https://youtu.be/FDFGfYJPLOc?t=02h03m57s)

[some of these other ones because we've](https://youtu.be/FDFGfYJPLOc?t=02h04m01s)

[got the](https://youtu.be/FDFGfYJPLOc?t=02h04m02s)

[so the the](https://youtu.be/FDFGfYJPLOc?t=02h04m05s)

[generating of](https://youtu.be/FDFGfYJPLOc?t=02h04m06s)

[the um](https://youtu.be/FDFGfYJPLOc?t=02h04m08s)

[the generation is fine however i still](https://youtu.be/FDFGfYJPLOc?t=02h04m11s)

[need to figure out how to get that type](https://youtu.be/FDFGfYJPLOc?t=02h04m14s)

[info](https://youtu.be/FDFGfYJPLOc?t=02h04m16s)

[because at the end of the day i the next](https://youtu.be/FDFGfYJPLOc?t=02h04m19s)

[thing i need to do is investigate the](https://youtu.be/FDFGfYJPLOc?t=02h04m21s)

[constructor](https://youtu.be/FDFGfYJPLOc?t=02h04m24s)

[and with the way we set this up where](https://youtu.be/FDFGfYJPLOc?t=02h04m25s)

[this is just doing no constructor](https://youtu.be/FDFGfYJPLOc?t=02h04m27s)

[parameter tests i could theoretically](https://youtu.be/FDFGfYJPLOc?t=02h04m29s)

[handle multiple constructors i would](https://youtu.be/FDFGfYJPLOc?t=02h04m32s)

[just have to change up the name](https://youtu.be/FDFGfYJPLOc?t=02h04m34s)

[i would have to change the name of the](https://youtu.be/FDFGfYJPLOc?t=02h04m39s)

[test because right now it's using um](https://youtu.be/FDFGfYJPLOc?t=02h04m41s)

[what do we do the](https://youtu.be/FDFGfYJPLOc?t=02h04m46s)

[the name of the test is based entirely](https://youtu.be/FDFGfYJPLOc?t=02h04m49s)

[upon the system under test](https://youtu.be/FDFGfYJPLOc?t=02h04m51s)

[and the null parameter type so i've](https://youtu.be/FDFGfYJPLOc?t=02h04m53s)

[already got a problem if you if you say](https://youtu.be/FDFGfYJPLOc?t=02h04m55s)

[generate a](https://youtu.be/FDFGfYJPLOc?t=02h04m57s)

[constructor with two i services that's a](https://youtu.be/FDFGfYJPLOc?t=02h04m59s)

[problem](https://youtu.be/FDFGfYJPLOc?t=02h05m01s)

[so that ain't gonna](https://youtu.be/FDFGfYJPLOc?t=02h05m03s)

[work um so we're gonna have to](https://youtu.be/FDFGfYJPLOc?t=02h05m04s)

[disambiguate a little bit](https://youtu.be/FDFGfYJPLOc?t=02h05m07s)

[or at least make this thing keep track](https://youtu.be/FDFGfYJPLOc?t=02h05m10s)

[of what method names it's already used](https://youtu.be/FDFGfYJPLOc?t=02h05m12s)

[and and not use them again](https://youtu.be/FDFGfYJPLOc?t=02h05m14s)

[like i said we this is another area](https://youtu.be/FDFGfYJPLOc?t=02h05m16s)

[where i feel like i might add a little](https://youtu.be/FDFGfYJPLOc?t=02h05m18s)

[bit of configuration in](https://youtu.be/FDFGfYJPLOc?t=02h05m20s)

[where if somebody wants to change up the](https://youtu.be/FDFGfYJPLOc?t=02h05m22s)

[naming scheme used here](https://youtu.be/FDFGfYJPLOc?t=02h05m24s)

[you can do so](https://youtu.be/FDFGfYJPLOc?t=02h05m26s)

[like maybe we'll do a simple like token](https://youtu.be/FDFGfYJPLOc?t=02h05m28s)

[replacement type deal on these and](https://youtu.be/FDFGfYJPLOc?t=02h05m30s)

[you can access a few of the members or](https://youtu.be/FDFGfYJPLOc?t=02h05m33s)

[whatever](https://youtu.be/FDFGfYJPLOc?t=02h05m34s)

[that seems like a fun thing to do](https://youtu.be/FDFGfYJPLOc?t=02h05m39s)

[have a little bit of config](https://youtu.be/FDFGfYJPLOc?t=02h05m41s)

[we'll ship a default that looks kind of](https://youtu.be/FDFGfYJPLOc?t=02h05m43s)

[like this](https://youtu.be/FDFGfYJPLOc?t=02h05m45s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h05m48s)

[okay so let's figure out](https://youtu.be/FDFGfYJPLOc?t=02h05m50s)

[why we can't retrieve](https://youtu.be/FDFGfYJPLOc?t=02h05m53s)

[the type](https://youtu.be/FDFGfYJPLOc?t=02h05m56s)

[why would i not be able to get the type](https://youtu.be/FDFGfYJPLOc?t=02h06m02s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h06m06s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h06m07s)

[hey uh](https://youtu.be/FDFGfYJPLOc?t=02h06m09s)

[de tuta](https://youtu.be/FDFGfYJPLOc?t=02h06m11s)

[welcome we are building out a c-sharp](https://youtu.be/FDFGfYJPLOc?t=02h06m16s)

[source generator to write unit tests](https://youtu.be/FDFGfYJPLOc?t=02h06m18s)

[because](https://youtu.be/FDFGfYJPLOc?t=02h06m20s)

[i am that level of lazy](https://youtu.be/FDFGfYJPLOc?t=02h06m22s)

[and i hate having to write low-value](https://youtu.be/FDFGfYJPLOc?t=02h06m26s)

[unit tests](https://youtu.be/FDFGfYJPLOc?t=02h06m28s)

[unfortunately some companies have](https://youtu.be/FDFGfYJPLOc?t=02h06m29s)

[rules about you have to have a certain](https://youtu.be/FDFGfYJPLOc?t=02h06m33s)

[percentage of code coverage](https://youtu.be/FDFGfYJPLOc?t=02h06m35s)

[which is fine i just don't like that as](https://youtu.be/FDFGfYJPLOc?t=02h06m38s)

[a measurable metric at all](https://youtu.be/FDFGfYJPLOc?t=02h06m41s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h06m44s)

[with that said that's what we're trying](https://youtu.be/FDFGfYJPLOc?t=02h06m46s)

[to do and specifically we are trying to](https://youtu.be/FDFGfYJPLOc?t=02h06m48s)

[figure out](https://youtu.be/FDFGfYJPLOc?t=02h06m50s)

[so let's let's start with some](https://youtu.be/FDFGfYJPLOc?t=02h06m51s)

[collapsing let's start with some](https://youtu.be/FDFGfYJPLOc?t=02h06m52s)

[collapse so for starters we've got two](https://youtu.be/FDFGfYJPLOc?t=02h06m54s)

[if statements back to back with no else](https://youtu.be/FDFGfYJPLOc?t=02h06m55s)

[in there which means these things](https://youtu.be/FDFGfYJPLOc?t=02h06m57s)

[collapse](https://youtu.be/FDFGfYJPLOc?t=02h06m59s)

[right we can just collapse those things](https://youtu.be/FDFGfYJPLOc?t=02h07m00s)

[together and](https://youtu.be/FDFGfYJPLOc?t=02h07m02s)

[oh did it delete the](https://youtu.be/FDFGfYJPLOc?t=02h07m05s)

[oh it deleted the closing brace for me](https://youtu.be/FDFGfYJPLOc?t=02h07m07s)

[oh no it didn't](https://youtu.be/FDFGfYJPLOc?t=02h07m11s)

[because it didn't unindent properly](https://youtu.be/FDFGfYJPLOc?t=02h07m13s)

[yeah it didn't oh](https://youtu.be/FDFGfYJPLOc?t=02h07m18s)

[there](https://youtu.be/FDFGfYJPLOc?t=02h07m19s)

[there](https://youtu.be/FDFGfYJPLOc?t=02h07m21s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h07m22s)

[i was very surprised](https://youtu.be/FDFGfYJPLOc?t=02h07m23s)

[okay so](https://youtu.be/FDFGfYJPLOc?t=02h07m29s)

[but ultimately we can't just use this to](https://youtu.be/FDFGfYJPLOc?t=02h07m30s)

[get it i just discovered the mvvm source](https://youtu.be/FDFGfYJPLOc?t=02h07m33s)

[generators yes um](https://youtu.be/FDFGfYJPLOc?t=02h07m36s)

[depending on which one you're using so](https://youtu.be/FDFGfYJPLOc?t=02h07m41s)

[what is it um](https://youtu.be/FDFGfYJPLOc?t=02h07m43s)

[the](https://youtu.be/FDFGfYJPLOc?t=02h07m45s)

[microsoft](https://youtu.be/FDFGfYJPLOc?t=02h07m47s)

[mvvm](https://youtu.be/FDFGfYJPLOc?t=02h07m52s)

[there's a couple of them out there but](https://youtu.be/FDFGfYJPLOc?t=02h07m53s)

[the ones from the microsoft toolkit](https://youtu.be/FDFGfYJPLOc?t=02h07m54s)

[are excellent i don't remember exactly](https://youtu.be/FDFGfYJPLOc?t=02h07m58s)

[which one of their](https://youtu.be/FDFGfYJPLOc?t=02h08m00s)

[nougat packages contains the source](https://youtu.be/FDFGfYJPLOc?t=02h08m01s)

[generators but they do have a bunch of](https://youtu.be/FDFGfYJPLOc?t=02h08m03s)

[them](https://youtu.be/FDFGfYJPLOc?t=02h08m05s)

[for doing like the i notify property](https://youtu.be/FDFGfYJPLOc?t=02h08m05s)

[changed and what not in there](https://youtu.be/FDFGfYJPLOc?t=02h08m07s)

[which is they are they can be pretty](https://youtu.be/FDFGfYJPLOc?t=02h08m10s)

[slick it might be bundled inside the](https://youtu.be/FDFGfYJPLOc?t=02h08m12s)

[mvvm one](https://youtu.be/FDFGfYJPLOc?t=02h08m15s)

[i'd probably have to poke around at it](https://youtu.be/FDFGfYJPLOc?t=02h08m17s)

[they they can be really good i try to](https://youtu.be/FDFGfYJPLOc?t=02h08m20s)

[balance](https://youtu.be/FDFGfYJPLOc?t=02h08m22s)

[the the amount of magic i have in my](https://youtu.be/FDFGfYJPLOc?t=02h08m23s)

[code because magic is great](https://youtu.be/FDFGfYJPLOc?t=02h08m25s)

[as long as everyone understands how it's](https://youtu.be/FDFGfYJPLOc?t=02h08m28s)

[working](https://youtu.be/FDFGfYJPLOc?t=02h08m30s)

[um it can also be a recipe for a lot of](https://youtu.be/FDFGfYJPLOc?t=02h08m31s)

[confusion](https://youtu.be/FDFGfYJPLOc?t=02h08m33s)

[when the uh incantation doesn't generate](https://youtu.be/FDFGfYJPLOc?t=02h08m34s)

[the code that you expect it's ah what's](https://youtu.be/FDFGfYJPLOc?t=02h08m36s)

[going on](https://youtu.be/FDFGfYJPLOc?t=02h08m39s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h08m40s)

[but yeah those ones in there can be](https://youtu.be/FDFGfYJPLOc?t=02h08m42s)

[quite quite handy](https://youtu.be/FDFGfYJPLOc?t=02h08m44s)

[i don't think i've actually shown those](https://youtu.be/FDFGfYJPLOc?t=02h08m47s)

[off on my stream much](https://youtu.be/FDFGfYJPLOc?t=02h08m49s)

[i i](https://youtu.be/FDFGfYJPLOc?t=02h08m51s)

[have a hard time with them because i](https://youtu.be/FDFGfYJPLOc?t=02h08m53s)

[usually prefer to i i tend to do a lot](https://youtu.be/FDFGfYJPLOc?t=02h08m55s)

[of](https://youtu.be/FDFGfYJPLOc?t=02h08m57s)

[extra stuff in my properties where i end](https://youtu.be/FDFGfYJPLOc?t=02h08m59s)

[up falling away from the the](https://youtu.be/FDFGfYJPLOc?t=02h09m00s)

[auto-generated ones anyway](https://youtu.be/FDFGfYJPLOc?t=02h09m02s)

[yeah community toolkit mvvm yep](https://youtu.be/FDFGfYJPLOc?t=02h09m04s)

[that sounds right i believe it's the](https://youtu.be/FDFGfYJPLOc?t=02h09m12s)

[same um repo under the hood that they're](https://youtu.be/FDFGfYJPLOc?t=02h09m14s)

[all being built out of because that's](https://youtu.be/FDFGfYJPLOc?t=02h09m17s)

[the one from](https://youtu.be/FDFGfYJPLOc?t=02h09m19s)

[i'm gonna butcher the names zamo llama](https://youtu.be/FDFGfYJPLOc?t=02h09m22s)

[um he streams every so often and](https://youtu.be/FDFGfYJPLOc?t=02h09m25s)

[uh that's uh one of the projects he](https://youtu.be/FDFGfYJPLOc?t=02h09m28s)

[enjoys working on he's one of the](https://youtu.be/FDFGfYJPLOc?t=02h09m30s)

[key maintainers of it](https://youtu.be/FDFGfYJPLOc?t=02h09m33s)

[he can be quite entertaining by the way](https://youtu.be/FDFGfYJPLOc?t=02h09m36s)

[especially if you want to watch someone](https://youtu.be/FDFGfYJPLOc?t=02h09m38s)

[like i code and i wear headphones he](https://youtu.be/FDFGfYJPLOc?t=02h09m39s)

[codes and wears a llama](https://youtu.be/FDFGfYJPLOc?t=02h09m42s)

[or llama hat](https://youtu.be/FDFGfYJPLOc?t=02h09m44s)

[there's something to be said for the](https://youtu.be/FDFGfYJPLOc?t=02h09m47s)

[llama](https://youtu.be/FDFGfYJPLOc?t=02h09m48s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h09m52s)

[oh james montemagno did one too](https://youtu.be/FDFGfYJPLOc?t=02h09m53s)

[i assumed the uh](https://youtu.be/FDFGfYJPLOc?t=02h09m58s)

[james's one was probably doing it in](https://youtu.be/FDFGfYJPLOc?t=02h09m59s)

[reference to like either a xamarin forms](https://youtu.be/FDFGfYJPLOc?t=02h10m01s)

[or a maui app](https://youtu.be/FDFGfYJPLOc?t=02h10m03s)

[because james streams quite quite a bit](https://youtu.be/FDFGfYJPLOc?t=02h10m10s)

[too he is definitely if people haven't](https://youtu.be/FDFGfYJPLOc?t=02h10m12s)

[uh followed um here i'll go find it i'll](https://youtu.be/FDFGfYJPLOc?t=02h10m14s)

[go find it uh he is a worthwhile one to](https://youtu.be/FDFGfYJPLOc?t=02h10m18s)

[follow](https://youtu.be/FDFGfYJPLOc?t=02h10m20s)

[if you don't already on twitch](https://youtu.be/FDFGfYJPLOc?t=02h10m21s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h10m25s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h10m29s)

[yeah here i'll drop his link](https://youtu.be/FDFGfYJPLOc?t=02h10m31s)

[boom](https://youtu.be/FDFGfYJPLOc?t=02h10m33s)

[shout out to james](https://youtu.be/FDFGfYJPLOc?t=02h10m35s)

[so definitely a worthwhile wild one to](https://youtu.be/FDFGfYJPLOc?t=02h10m38s)

[go through and follow because he does](https://youtu.be/FDFGfYJPLOc?t=02h10m40s)

[quite a bit of stuff](https://youtu.be/FDFGfYJPLOc?t=02h10m42s)

[uh source generators in mvvm](https://youtu.be/FDFGfYJPLOc?t=02h10m44s)

[oh cool](https://youtu.be/FDFGfYJPLOc?t=02h10m47s)

[that's pretty cool that i'm guessing his](https://youtu.be/FDFGfYJPLOc?t=02h10m52s)

[was leveraging source generators not](https://youtu.be/FDFGfYJPLOc?t=02h10m54s)

[writing source generators](https://youtu.be/FDFGfYJPLOc?t=02h10m56s)

[but i could be wrong](https://youtu.be/FDFGfYJPLOc?t=02h10m58s)

[i'd have to go and peruse his recent](https://youtu.be/FDFGfYJPLOc?t=02h11m01s)

[videos](https://youtu.be/FDFGfYJPLOc?t=02h11m04s)

[uh okay](https://youtu.be/FDFGfYJPLOc?t=02h11m06s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h11m07s)

[class definition](https://youtu.be/FDFGfYJPLOc?t=02h11m09s)

[type info because we really really](https://youtu.be/FDFGfYJPLOc?t=02h11m11s)

[really really really want an eye type](https://youtu.be/FDFGfYJPLOc?t=02h11m13s)

[info](https://youtu.be/FDFGfYJPLOc?t=02h11m15s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h11m18s)

[let's see](https://youtu.be/FDFGfYJPLOc?t=02h11m19s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h11m20s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h11m21s)

[because it ended up being](https://youtu.be/FDFGfYJPLOc?t=02h11m22s)

[context](https://youtu.be/FDFGfYJPLOc?t=02h11m24s)

[semantic model](https://youtu.be/FDFGfYJPLOc?t=02h11m27s)

[get](https://youtu.be/FDFGfYJPLOc?t=02h11m30s)

[type info](https://youtu.be/FDFGfYJPLOc?t=02h11m32s)

[and i thought this is what should have](https://youtu.be/FDFGfYJPLOc?t=02h11m42s)

[done it](https://youtu.be/FDFGfYJPLOc?t=02h11m44s)

[but let's take a look so it takes in an](https://youtu.be/FDFGfYJPLOc?t=02h11m48s)

[attribute syntax constructor initializer](https://youtu.be/FDFGfYJPLOc?t=02h11m50s)

[syntax expression syntax](https://youtu.be/FDFGfYJPLOc?t=02h11m53s)

[selector group clause syntax or regular](https://youtu.be/FDFGfYJPLOc?t=02h11m56s)

[syntax node](https://youtu.be/FDFGfYJPLOc?t=02h11m58s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h12m04s)

[okay so something](https://youtu.be/FDFGfYJPLOc?t=02h12m09s)

[in this vicinity](https://youtu.be/FDFGfYJPLOc?t=02h12m11s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h12m14s)

[let's](https://youtu.be/FDFGfYJPLOc?t=02h12m15s)

[let's ask the googles real quick again](https://youtu.be/FDFGfYJPLOc?t=02h12m16s)

[and see what we](https://youtu.be/FDFGfYJPLOc?t=02h12m18s)

[because i think we can do get type info](https://youtu.be/FDFGfYJPLOc?t=02h12m20s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h12m24s)

[class declaration syntax](https://youtu.be/FDFGfYJPLOc?t=02h12m25s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h12m30s)

[romantic](https://youtu.be/FDFGfYJPLOc?t=02h12m34s)

[model](https://youtu.be/FDFGfYJPLOc?t=02h12m35s)

[something](https://youtu.be/FDFGfYJPLOc?t=02h12m38s)

[good type info core](https://youtu.be/FDFGfYJPLOc?t=02h12m43s)

[get declared symbol](https://youtu.be/FDFGfYJPLOc?t=02h12m48s)

[maybe maybe we should maybe we should](https://youtu.be/FDFGfYJPLOc?t=02h12m51s)

[try a couple of these options here](https://youtu.be/FDFGfYJPLOc?t=02h12m53s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h12m55s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h13m02s)

[s](https://youtu.be/FDFGfYJPLOc?t=02h13m04s)

[bar](https://youtu.be/FDFGfYJPLOc?t=02h13m07s)

[because this is going to give me a](https://youtu.be/FDFGfYJPLOc?t=02h13m08s)

[symbol okay](https://youtu.be/FDFGfYJPLOc?t=02h13m14s)

[well let's catch it here and let's](https://youtu.be/FDFGfYJPLOc?t=02h13m17s)

[put the](https://youtu.be/FDFGfYJPLOc?t=02h13m21s)

[debugger back on](https://youtu.be/FDFGfYJPLOc?t=02h13m22s)

[which is annoying to have to do it this](https://youtu.be/FDFGfYJPLOc?t=02h13m26s)

[way](https://youtu.be/FDFGfYJPLOc?t=02h13m27s)

[and then we will catch it i don't know](https://youtu.be/FDFGfYJPLOc?t=02h13m29s)

[we were playing with ms test before](https://youtu.be/FDFGfYJPLOc?t=02h13m31s)

[let's keep let's let's stick with what's](https://youtu.be/FDFGfYJPLOc?t=02h13m33s)

[familiar](https://youtu.be/FDFGfYJPLOc?t=02h13m35s)

[they all have the same code though at](https://youtu.be/FDFGfYJPLOc?t=02h13m37s)

[this point or actually they all are](https://youtu.be/FDFGfYJPLOc?t=02h13m39s)

[empty with the same code](https://youtu.be/FDFGfYJPLOc?t=02h13m41s)

[okay so f5 gets me into here](https://youtu.be/FDFGfYJPLOc?t=02h13m45s)

[so type info is still giving me back](https://youtu.be/FDFGfYJPLOc?t=02h13m49s)

[nothing because type is null](https://youtu.be/FDFGfYJPLOc?t=02h13m52s)

[okay what is the declared symbol](https://youtu.be/FDFGfYJPLOc?t=02h13m54s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h14m04s)

[name type symbol](https://youtu.be/FDFGfYJPLOc?t=02h14m05s)

[this is what i want](https://youtu.be/FDFGfYJPLOc?t=02h14m14s)

[ah](https://youtu.be/FDFGfYJPLOc?t=02h14m20s)

[okay because](https://youtu.be/FDFGfYJPLOc?t=02h14m24s)

[let's](https://youtu.be/FDFGfYJPLOc?t=02h14m30s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h14m31s)

[look at that](https://youtu.be/FDFGfYJPLOc?t=02h14m36s)

[there there she be](https://youtu.be/FDFGfYJPLOc?t=02h14m37s)

[there she be](https://youtu.be/FDFGfYJPLOc?t=02h14m40s)

[okay so](https://youtu.be/FDFGfYJPLOc?t=02h14m42s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h14m44s)

[we're gonna add this in here too because](https://youtu.be/FDFGfYJPLOc?t=02h14m45s)

[we should be able to retrieve this so](https://youtu.be/FDFGfYJPLOc?t=02h14m47s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h14m49s)

[boom is](https://youtu.be/FDFGfYJPLOc?t=02h14m52s)

[i](https://youtu.be/FDFGfYJPLOc?t=02h14m55s)

[name type symbol](https://youtu.be/FDFGfYJPLOc?t=02h14m56s)

[symbol okay](https://youtu.be/FDFGfYJPLOc?t=02h14m59s)

[once we get the symbol now we can now we](https://youtu.be/FDFGfYJPLOc?t=02h15m01s)

[can party on this thing](https://youtu.be/FDFGfYJPLOc?t=02h15m03s)

[um because the symbol](https://youtu.be/FDFGfYJPLOc?t=02h15m05s)

[likely also has](https://youtu.be/FDFGfYJPLOc?t=02h15m09s)

[maintaining namespace](https://youtu.be/FDFGfYJPLOc?t=02h15m12s)

[right which is gonna get us](https://youtu.be/FDFGfYJPLOc?t=02h15m14s)

[the whole namespace and everyone's](https://youtu.be/FDFGfYJPLOc?t=02h15m16s)

[everyone's gonna be happy or i'm going](https://youtu.be/FDFGfYJPLOc?t=02h15m19s)

[to be happy at this point okay so now we](https://youtu.be/FDFGfYJPLOc?t=02h15m21s)

[don't have to do any of this extra](https://youtu.be/FDFGfYJPLOc?t=02h15m23s)

[extra work okay okay okay](https://youtu.be/FDFGfYJPLOc?t=02h15m25s)

[so let's start building this guy up so](https://youtu.be/FDFGfYJPLOc?t=02h15m29s)

[for each var](https://youtu.be/FDFGfYJPLOc?t=02h15m31s)

[constructor in](https://youtu.be/FDFGfYJPLOc?t=02h15m32s)

[symbol](https://youtu.be/FDFGfYJPLOc?t=02h15m35s)

[structures](https://youtu.be/FDFGfYJPLOc?t=02h15m37s)

[uh instructors boom gimme](https://youtu.be/FDFGfYJPLOc?t=02h15m40s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h15m43s)

[so we're gonna have to](https://youtu.be/FDFGfYJPLOc?t=02h15m44s)

[have to build this guy up a little bit](https://youtu.be/FDFGfYJPLOc?t=02h15m46s)

[because](https://youtu.be/FDFGfYJPLOc?t=02h15m48s)

[we're gonna need to make](https://youtu.be/FDFGfYJPLOc?t=02h15m51s)

[make one of these thingies and then](https://youtu.be/FDFGfYJPLOc?t=02h15m54s)

[start appending things into it i'm not](https://youtu.be/FDFGfYJPLOc?t=02h15m56s)

[gonna just do it all at once](https://youtu.be/FDFGfYJPLOc?t=02h15m58s)

[one shot](https://youtu.be/FDFGfYJPLOc?t=02h16m00s)

[so let's do this](https://youtu.be/FDFGfYJPLOc?t=02h16m02s)

[boom](https://youtu.be/FDFGfYJPLOc?t=02h16m05s)

[target blast gets](https://youtu.be/FDFGfYJPLOc?t=02h16m07s)

[new](https://youtu.be/FDFGfYJPLOc?t=02h16m10s)

[so we should be able to populate those](https://youtu.be/FDFGfYJPLOc?t=02h16m11s)

[and we can probably end up populating](https://youtu.be/FDFGfYJPLOc?t=02h16m13s)

[these straight from the symbol now](https://youtu.be/FDFGfYJPLOc?t=02h16m15s)

[and then this](https://youtu.be/FDFGfYJPLOc?t=02h16m19s)

[so we can probably even continue here](https://youtu.be/FDFGfYJPLOc?t=02h16m23s)

[and do this so let's see](https://youtu.be/FDFGfYJPLOc?t=02h16m27s)

[oh let's get rid of the bar again](https://youtu.be/FDFGfYJPLOc?t=02h16m32s)

[and](https://youtu.be/FDFGfYJPLOc?t=02h16m36s)

[do that](https://youtu.be/FDFGfYJPLOc?t=02h16m39s)

[and some fun](https://youtu.be/FDFGfYJPLOc?t=02h16m43s)

[make you happy](https://youtu.be/FDFGfYJPLOc?t=02h16m45s)

[uh and then this becomes](https://youtu.be/FDFGfYJPLOc?t=02h16m47s)

[this](https://youtu.be/FDFGfYJPLOc?t=02h16m50s)

[and then all we have to do is populate](https://youtu.be/FDFGfYJPLOc?t=02h16m54s)

[that bit i'm gonna comment this for the](https://youtu.be/FDFGfYJPLOc?t=02h16m57s)

[moment and so at the end test classes](https://youtu.be/FDFGfYJPLOc?t=02h16m58s)

[add target class](https://youtu.be/FDFGfYJPLOc?t=02h17m02s)

[good there](https://youtu.be/FDFGfYJPLOc?t=02h17m04s)

[we are gonna need to figure out how](https://youtu.be/FDFGfYJPLOc?t=02h17m08s)

[we're gonna populate the target type](https://youtu.be/FDFGfYJPLOc?t=02h17m10s)

[because right now](https://youtu.be/FDFGfYJPLOc?t=02h17m13s)

[oh this is the wrong](https://youtu.be/FDFGfYJPLOc?t=02h17m15s)

[thingymabobber](https://youtu.be/FDFGfYJPLOc?t=02h17m16s)

[we still need this](https://youtu.be/FDFGfYJPLOc?t=02h17m18s)

[but this isn't the thing with the](https://youtu.be/FDFGfYJPLOc?t=02h17m20s)

[constructors that i want i need to add](https://youtu.be/FDFGfYJPLOc?t=02h17m22s)

[something i need to add something so](https://youtu.be/FDFGfYJPLOc?t=02h17m26s)

[that i know what the target type is](https://youtu.be/FDFGfYJPLOc?t=02h17m29s)

[because even though this thing is called](https://youtu.be/FDFGfYJPLOc?t=02h17m31s)

[controller tests](https://youtu.be/FDFGfYJPLOc?t=02h17m33s)

[i need to create say an attribute or](https://youtu.be/FDFGfYJPLOc?t=02h17m35s)

[similar that i can put on here to say](https://youtu.be/FDFGfYJPLOc?t=02h17m37s)

[for this class generate me constructor](https://youtu.be/FDFGfYJPLOc?t=02h17m40s)

[tests for this target type](https://youtu.be/FDFGfYJPLOc?t=02h17m43s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h17m46s)

[so i'm thinking this is actually going](https://youtu.be/FDFGfYJPLOc?t=02h17m49s)

[to look a little bit like this](https://youtu.be/FDFGfYJPLOc?t=02h17m50s)

[what does suck class do so in this case](https://youtu.be/FDFGfYJPLOc?t=02h17m53s)

[so sut is just standing for system under](https://youtu.be/FDFGfYJPLOc?t=02h17m55s)

[test](https://youtu.be/FDFGfYJPLOc?t=02h17m58s)

[meaning the](https://youtu.be/FDFGfYJPLOc?t=02h17m59s)

[um the class that we want to test](https://youtu.be/FDFGfYJPLOc?t=02h18m00s)

[so the tests that we're generating look](https://youtu.be/FDFGfYJPLOc?t=02h18m03s)

[kind of like](https://youtu.be/FDFGfYJPLOc?t=02h18m05s)

[this](https://youtu.be/FDFGfYJPLOc?t=02h18m07s)

[um so in this case the](https://youtu.be/FDFGfYJPLOc?t=02h18m09s)

[the class that is being tested is our](https://youtu.be/FDFGfYJPLOc?t=02h18m12s)

[controller class](https://youtu.be/FDFGfYJPLOc?t=02h18m14s)

[because we're instant we're we're](https://youtu.be/FDFGfYJPLOc?t=02h18m15s)

[calling the controller's constructor](https://youtu.be/FDFGfYJPLOc?t=02h18m17s)

[and we're passing through a null for i](https://youtu.be/FDFGfYJPLOc?t=02h18m19s)

[service](https://youtu.be/FDFGfYJPLOc?t=02h18m21s)

[now our controller only has a single](https://youtu.be/FDFGfYJPLOc?t=02h18m22s)

[parameter if it had multiple parameters](https://youtu.be/FDFGfYJPLOc?t=02h18m24s)

[what it will end up doing is using mocks](https://youtu.be/FDFGfYJPLOc?t=02h18m27s)

[for the other parameters null for the](https://youtu.be/FDFGfYJPLOc?t=02h18m29s)

[service the iservice instance](https://youtu.be/FDFGfYJPLOc?t=02h18m32s)

[specifically so that we can trigger](https://youtu.be/FDFGfYJPLOc?t=02h18m34s)

[this condition of throwing an argument](https://youtu.be/FDFGfYJPLOc?t=02h18m37s)

[null](https://youtu.be/FDFGfYJPLOc?t=02h18m39s)

[so that's all that is doing is defining](https://youtu.be/FDFGfYJPLOc?t=02h18m41s)

[what are](https://youtu.be/FDFGfYJPLOc?t=02h18m43s)

[what class we're trying to test with](https://youtu.be/FDFGfYJPLOc?t=02h18m46s)

[these](https://youtu.be/FDFGfYJPLOc?t=02h18m48s)

[so but i think what we do is we do this](https://youtu.be/FDFGfYJPLOc?t=02h18m50s)

[we create a constructor test](https://youtu.be/FDFGfYJPLOc?t=02h18m52s)

[attribute](https://youtu.be/FDFGfYJPLOc?t=02h18m54s)

[and we give it a target type](https://youtu.be/FDFGfYJPLOc?t=02h18m56s)

[that seems reasonable i i really so](https://youtu.be/FDFGfYJPLOc?t=02h18m59s)

[part of me wants to leverage the new um](https://youtu.be/FDFGfYJPLOc?t=02h19m02s)

[the new c-sharp feature where they've](https://youtu.be/FDFGfYJPLOc?t=02h19m06s)

[put in um generic types on attributes](https://youtu.be/FDFGfYJPLOc?t=02h19m08s)

[which is awesome which is great the](https://youtu.be/FDFGfYJPLOc?t=02h19m11s)

[problem is is this thing is still](https://youtu.be/FDFGfYJPLOc?t=02h19m14s)

[targeting some older c sharp things and](https://youtu.be/FDFGfYJPLOc?t=02h19m15s)

[i just](https://youtu.be/FDFGfYJPLOc?t=02h19m17s)

[i know not everyone will be able to use](https://youtu.be/FDFGfYJPLOc?t=02h19m20s)

[it](https://youtu.be/FDFGfYJPLOc?t=02h19m22s)

[which makes me sad](https://youtu.be/FDFGfYJPLOc?t=02h19m25s)

[so i have to i have to jen at the old](https://youtu.be/FDFGfYJPLOc?t=02h19m26s)

[way for now](https://youtu.be/FDFGfYJPLOc?t=02h19m28s)

[okay so](https://youtu.be/FDFGfYJPLOc?t=02h19m30s)

[this will be a public](https://youtu.be/FDFGfYJPLOc?t=02h19m31s)

[class](https://youtu.be/FDFGfYJPLOc?t=02h19m33s)

[constructor](https://youtu.be/FDFGfYJPLOc?t=02h19m34s)

[s](https://youtu.be/FDFGfYJPLOc?t=02h19m38s)

[attribute](https://youtu.be/FDFGfYJPLOc?t=02h19m39s)

[attribute](https://youtu.be/FDFGfYJPLOc?t=02h19m43s)

[and then we will](https://youtu.be/FDFGfYJPLOc?t=02h19m45s)

[let's see move to your own thingy](https://youtu.be/FDFGfYJPLOc?t=02h19m48s)

[and](https://youtu.be/FDFGfYJPLOc?t=02h19m52s)

[now you're going to yell at me for all](https://youtu.be/FDFGfYJPLOc?t=02h19m53s)

[kinds of stuff so first of all hush](https://youtu.be/FDFGfYJPLOc?t=02h19m55s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h19m58s)

[okay so then you declare attribute usage](https://youtu.be/FDFGfYJPLOc?t=02h20m00s)

[attribute usage so we will only allow](https://youtu.be/FDFGfYJPLOc?t=02h20m04s)

[people to specify this attribute on](https://youtu.be/FDFGfYJPLOc?t=02h20m07s)

[classes because that's the only thing we](https://youtu.be/FDFGfYJPLOc?t=02h20m11s)

[support](https://youtu.be/FDFGfYJPLOc?t=02h20m13s)

[and we will not allow multiple we can](https://youtu.be/FDFGfYJPLOc?t=02h20m15s)

[only specify once](https://youtu.be/FDFGfYJPLOc?t=02h20m17s)

[and we will do public type](https://youtu.be/FDFGfYJPLOc?t=02h20m20s)

[um what did we call it over here](https://youtu.be/FDFGfYJPLOc?t=02h20m22s)

[target type is that is that a reasonable](https://youtu.be/FDFGfYJPLOc?t=02h20m27s)

[enough name](https://youtu.be/FDFGfYJPLOc?t=02h20m29s)

[does target type indicate well enough](https://youtu.be/FDFGfYJPLOc?t=02h20m31s)

[that this is the type](https://youtu.be/FDFGfYJPLOc?t=02h20m33s)

[to generate tests for](https://youtu.be/FDFGfYJPLOc?t=02h20m35s)

[i'm not sold on it not sold on it](https://youtu.be/FDFGfYJPLOc?t=02h20m39s)

[um get set](https://youtu.be/FDFGfYJPLOc?t=02h20m42s)

[and then we're gonna do a couple](https://youtu.be/FDFGfYJPLOc?t=02h20m45s)

[constructors](https://youtu.be/FDFGfYJPLOc?t=02h20m46s)

[default one](https://youtu.be/FDFGfYJPLOc?t=02h20m50s)

[and we'll do one more](https://youtu.be/FDFGfYJPLOc?t=02h20m52s)

[type](https://youtu.be/FDFGfYJPLOc?t=02h20m57s)

[see initialize property for me](https://youtu.be/FDFGfYJPLOc?t=02h21m00s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h21m17s)

[what is your problem now um](https://youtu.be/FDFGfYJPLOc?t=02h21m19s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h21m34s)

[i think what we're gonna do is just make](https://youtu.be/FDFGfYJPLOc?t=02h21m40s)

[you knowable and we'll just handle the](https://youtu.be/FDFGfYJPLOc?t=02h21m41s)

[null case](https://youtu.be/FDFGfYJPLOc?t=02h21m43s)

[we will just handle the null case okay](https://youtu.be/FDFGfYJPLOc?t=02h21m45s)

[so this guy here](https://youtu.be/FDFGfYJPLOc?t=02h21m48s)

[structure test you should now work](https://youtu.be/FDFGfYJPLOc?t=02h21m52s)

[uh uh so this should be moq](https://youtu.be/FDFGfYJPLOc?t=02h21m56s)

[oh auto moc](https://youtu.be/FDFGfYJPLOc?t=02h22m01s)

[okay good that that not resolved so](https://youtu.be/FDFGfYJPLOc?t=02h22m05s)

[that's now a thing](https://youtu.be/FDFGfYJPLOc?t=02h22m07s)

[so now we just need our](https://youtu.be/FDFGfYJPLOc?t=02h22m10s)

[source generator to](https://youtu.be/FDFGfYJPLOc?t=02h22m12s)

[pick that up](https://youtu.be/FDFGfYJPLOc?t=02h22m14s)

[so specifically now](https://youtu.be/FDFGfYJPLOc?t=02h22m16s)

[this guy is no longer just looking for](https://youtu.be/FDFGfYJPLOc?t=02h22m18s)

[this something else worth noting when](https://youtu.be/FDFGfYJPLOc?t=02h22m20s)

[doing source generators](https://youtu.be/FDFGfYJPLOc?t=02h22m23s)

[specifically because you're oftentimes](https://youtu.be/FDFGfYJPLOc?t=02h22m25s)

[writing conditions that are well i'm](https://youtu.be/FDFGfYJPLOc?t=02h22m28s)

[looking for something that matches a b](https://youtu.be/FDFGfYJPLOc?t=02h22m29s)

[and c](https://youtu.be/FDFGfYJPLOc?t=02h22m31s)

[the order that you do the condition](https://youtu.be/FDFGfYJPLOc?t=02h22m32s)

[checks on a b and c should be](https://youtu.be/FDFGfYJPLOc?t=02h22m34s)

[intentional the cheaper the check](https://youtu.be/FDFGfYJPLOc?t=02h22m35s)

[the earlier it should be because in c](https://youtu.be/FDFGfYJPLOc?t=02h22m38s)

[sharp it will short circuit if it sees](https://youtu.be/FDFGfYJPLOc?t=02h22m40s)

[ands and one of these things returns](https://youtu.be/FDFGfYJPLOc?t=02h22m42s)

[false it doesn't evaluate the rest it](https://youtu.be/FDFGfYJPLOc?t=02h22m44s)

[stops early which is great we abuse that](https://youtu.be/FDFGfYJPLOc?t=02h22m47s)

[liberally here](https://youtu.be/FDFGfYJPLOc?t=02h22m50s)

[getting the declared symbol going back](https://youtu.be/FDFGfYJPLOc?t=02h22m52s)

[to the semantic model is going to be](https://youtu.be/FDFGfYJPLOc?t=02h22m54s)

[significantly more expensive than say a](https://youtu.be/FDFGfYJPLOc?t=02h22m56s)

[type check](https://youtu.be/FDFGfYJPLOc?t=02h22m58s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h23m00s)

[we do the type checks first we then do](https://youtu.be/FDFGfYJPLOc?t=02h23m01s)

[the modifiers we're going to do all the](https://youtu.be/FDFGfYJPLOc?t=02h23m03s)

[cheap stuff early](https://youtu.be/FDFGfYJPLOc?t=02h23m04s)

[and then go into the harder stuff](https://youtu.be/FDFGfYJPLOc?t=02h23m06s)

[so let's see class declaration and i](https://youtu.be/FDFGfYJPLOc?t=02h23m09s)

[think what we saw is on](https://youtu.be/FDFGfYJPLOc?t=02h23m11s)

[sharp lab](https://youtu.be/FDFGfYJPLOc?t=02h23m14s)

[because we did this here right so we are](https://youtu.be/FDFGfYJPLOc?t=02h23m16s)

[looking for on the class declaration](https://youtu.be/FDFGfYJPLOc?t=02h23m18s)

[there is going to be](https://youtu.be/FDFGfYJPLOc?t=02h23m21s)

[an attribute list](https://youtu.be/FDFGfYJPLOc?t=02h23m23s)

[and that's what we're going to hunt off](https://youtu.be/FDFGfYJPLOc?t=02h23m25s)

[of okay](https://youtu.be/FDFGfYJPLOc?t=02h23m27s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h23m29s)

[something about an attribute list](https://youtu.be/FDFGfYJPLOc?t=02h23m30s)

[great](https://youtu.be/FDFGfYJPLOc?t=02h23m33s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h23m35s)

[any](https://youtu.be/FDFGfYJPLOc?t=02h23m39s)

[stop there](https://youtu.be/FDFGfYJPLOc?t=02h23m41s)

[uh do you need to gen the attribute](https://youtu.be/FDFGfYJPLOc?t=02h23m44s)

[class definition in the analyzed](https://youtu.be/FDFGfYJPLOc?t=02h23m46s)

[assembly um](https://youtu.be/FDFGfYJPLOc?t=02h23m48s)

[that's a good question](https://youtu.be/FDFGfYJPLOc?t=02h23m55s)

[i don't think i need to um](https://youtu.be/FDFGfYJPLOc?t=02h23m57s)

[and the only rationale is and actually](https://youtu.be/FDFGfYJPLOc?t=02h24m01s)

[this guy can go away too](https://youtu.be/FDFGfYJPLOc?t=02h24m04s)

[so this attribute](https://youtu.be/FDFGfYJPLOc?t=02h24m07s)

[and this generator is going to](https://youtu.be/FDFGfYJPLOc?t=02h24m09s)

[so okay so solo back up the source](https://youtu.be/FDFGfYJPLOc?t=02h24m19s)

[generator could generate the attribute](https://youtu.be/FDFGfYJPLOc?t=02h24m21s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h24m25s)

[it kind of depends](https://youtu.be/FDFGfYJPLOc?t=02h24m27s)

[because on one hand](https://youtu.be/FDFGfYJPLOc?t=02h24m28s)

[if you wanted to say conditionally have](https://youtu.be/FDFGfYJPLOc?t=02h24m31s)

[the attribute available based on](https://youtu.be/FDFGfYJPLOc?t=02h24m33s)

[whatever reason like hey i'm only going](https://youtu.be/FDFGfYJPLOc?t=02h24m36s)

[to generate this attribute if](https://youtu.be/FDFGfYJPLOc?t=02h24m38s)

[um if they're referencing end unit or](https://youtu.be/FDFGfYJPLOc?t=02h24m40s)

[similar](https://youtu.be/FDFGfYJPLOc?t=02h24m43s)

[hello national needle mouse](https://youtu.be/FDFGfYJPLOc?t=02h24m44s)

[welcome um then i could see having the](https://youtu.be/FDFGfYJPLOc?t=02h24m46s)

[source generator generate the attribute](https://youtu.be/FDFGfYJPLOc?t=02h24m50s)

[however in my case i want the attribute](https://youtu.be/FDFGfYJPLOc?t=02h24m52s)

[always there](https://youtu.be/FDFGfYJPLOc?t=02h24m54s)

[and we're just going to leverage it for](https://youtu.be/FDFGfYJPLOc?t=02h24m56s)

[the purpose of](https://youtu.be/FDFGfYJPLOc?t=02h24m58s)

[what classes to target](https://youtu.be/FDFGfYJPLOc?t=02h25m01s)

[so it doesn't hurt me to have it in my](https://youtu.be/FDFGfYJPLOc?t=02h25m03s)

[main assembly especially since i intend](https://youtu.be/FDFGfYJPLOc?t=02h25m06s)

[to have this generator go out in the](https://youtu.be/FDFGfYJPLOc?t=02h25m08s)

[same nougat package as this assembly](https://youtu.be/FDFGfYJPLOc?t=02h25m11s)

[if they were shipping separately that](https://youtu.be/FDFGfYJPLOc?t=02h25m14s)

[might be a different concern then](https://youtu.be/FDFGfYJPLOc?t=02h25m16s)

[but in my case](https://youtu.be/FDFGfYJPLOc?t=02h25m18s)

[i don't intend to ship two separate](https://youtu.be/FDFGfYJPLOc?t=02h25m19s)

[nougat packages](https://youtu.be/FDFGfYJPLOc?t=02h25m21s)

[one nougat package](https://youtu.be/FDFGfYJPLOc?t=02h25m23s)

[full send](https://youtu.be/FDFGfYJPLOc?t=02h25m25s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h25m31s)

[i don't know if there is a](https://youtu.be/FDFGfYJPLOc?t=02h25m32s)

[a hundred percent correct answer i think](https://youtu.be/FDFGfYJPLOc?t=02h25m35s)

[it depends](https://youtu.be/FDFGfYJPLOc?t=02h25m37s)

[i would probably default to](https://youtu.be/FDFGfYJPLOc?t=02h25m38s)

[not source generator in it if you don't](https://youtu.be/FDFGfYJPLOc?t=02h25m41s)

[have to](https://youtu.be/FDFGfYJPLOc?t=02h25m44s)

[but there's plenty of reasons why it](https://youtu.be/FDFGfYJPLOc?t=02h25m46s)

[might be desirable](https://youtu.be/FDFGfYJPLOc?t=02h25m49s)

[so for what it's worth](https://youtu.be/FDFGfYJPLOc?t=02h25m52s)

[um okay so and i want to look at this](https://youtu.be/FDFGfYJPLOc?t=02h25m54s)

[attribute list because i think what i'm](https://youtu.be/FDFGfYJPLOc?t=02h25m56s)

[going to want to do](https://youtu.be/FDFGfYJPLOc?t=02h25m58s)

[uh source generator is getting packaged](https://youtu.be/FDFGfYJPLOc?t=02h26m00s)

[alone](https://youtu.be/FDFGfYJPLOc?t=02h26m03s)

[yeah and that that does depend a lot on](https://youtu.be/FDFGfYJPLOc?t=02h26m04s)

[who's](https://youtu.be/FDFGfYJPLOc?t=02h26m07s)

[on what the consuming consumer model is](https://youtu.be/FDFGfYJPLOc?t=02h26m08s)

[for this](https://youtu.be/FDFGfYJPLOc?t=02h26m10s)

[um so i think i actually want to change](https://youtu.be/FDFGfYJPLOc?t=02h26m12s)

[this up here and go with attribute list](https://youtu.be/FDFGfYJPLOc?t=02h26m15s)

[because i think this is going to be a](https://youtu.be/FDFGfYJPLOc?t=02h26m19s)

[first or default check](https://youtu.be/FDFGfYJPLOc?t=02h26m20s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h26m24s)

[test](https://youtu.be/FDFGfYJPLOc?t=02h26m31s)

[attribute](https://youtu.be/FDFGfYJPLOc?t=02h26m32s)

[the other thing that and i think this is](https://youtu.be/FDFGfYJPLOc?t=02h26m35s)

[something we'll casey you and i will](https://youtu.be/FDFGfYJPLOc?t=02h26m37s)

[probably run into is](https://youtu.be/FDFGfYJPLOc?t=02h26m39s)

[generally in my source generators you'll](https://youtu.be/FDFGfYJPLOc?t=02h26m41s)

[note i do no hard references to other](https://youtu.be/FDFGfYJPLOc?t=02h26m43s)

[assemblies](https://youtu.be/FDFGfYJPLOc?t=02h26m46s)

[and i'm sure you're well versed into the](https://youtu.be/FDFGfYJPLOc?t=02h26m48s)

[reasons as to why is you get all kinds](https://youtu.be/FDFGfYJPLOc?t=02h26m50s)

[of fun problems with](https://youtu.be/FDFGfYJPLOc?t=02h26m53s)

[assembly resolution when it's trying to](https://youtu.be/FDFGfYJPLOc?t=02h26m55s)

[load](https://youtu.be/FDFGfYJPLOc?t=02h26m56s)

[which can be quite problematic at](https://youtu.be/FDFGfYJPLOc?t=02h26m58s)

[okay so this is the first or default](https://youtu.be/FDFGfYJPLOc?t=02h27m01s)

[uh okay so](https://youtu.be/FDFGfYJPLOc?t=02h27m05s)

[given the attribute what is on the](https://youtu.be/FDFGfYJPLOc?t=02h27m07s)

[attribute that i want](https://youtu.be/FDFGfYJPLOc?t=02h27m09s)

[i am going to](https://youtu.be/FDFGfYJPLOc?t=02h27m11s)

[be looking for probably based on its](https://youtu.be/FDFGfYJPLOc?t=02h27m13s)

[name](https://youtu.be/FDFGfYJPLOc?t=02h27m17s)

[it's probably good enough](https://youtu.be/FDFGfYJPLOc?t=02h27m19s)

[it's probably good enough where is](https://youtu.be/FDFGfYJPLOc?t=02h27m22s)

[it's gonna look at noseplugs one](https://youtu.be/FDFGfYJPLOc?t=02h27m26s)

[because or actually xaml test is a](https://youtu.be/FDFGfYJPLOc?t=02h27m30s)

[pretty good one because it hunts the](https://youtu.be/FDFGfYJPLOc?t=02h27m32s)

[attribute as well](https://youtu.be/FDFGfYJPLOc?t=02h27m34s)

[it's just a handful of things](https://youtu.be/FDFGfYJPLOc?t=02h27m39s)

[so argument count](https://youtu.be/FDFGfYJPLOc?t=02h27m41s)

[oh actually that's probably](https://youtu.be/FDFGfYJPLOc?t=02h27m45s)

[in this case it specifically went after](https://youtu.be/FDFGfYJPLOc?t=02h27m48s)

[the attribute in my case i think i want](https://youtu.be/FDFGfYJPLOc?t=02h27m50s)

[to be a little more generous](https://youtu.be/FDFGfYJPLOc?t=02h27m52s)

[uh argument list](https://youtu.be/FDFGfYJPLOc?t=02h27m55s)

[yeah because i think i'm going to be](https://youtu.be/FDFGfYJPLOc?t=02h28m02s)

[hunting this in one of two ways](https://youtu.be/FDFGfYJPLOc?t=02h28m04s)

[because this is already pulling the](https://youtu.be/FDFGfYJPLOc?t=02h28m10s)

[attribute syntax out and then hunting](https://youtu.be/FDFGfYJPLOc?t=02h28m11s)

[the arguments on it](https://youtu.be/FDFGfYJPLOc?t=02h28m13s)

[in this case i don't think that's quite](https://youtu.be/FDFGfYJPLOc?t=02h28m15s)

[what i want](https://youtu.be/FDFGfYJPLOc?t=02h28m17s)

[i'd like to pull the attribute and hunt](https://youtu.be/FDFGfYJPLOc?t=02h28m19s)

[it i think by identifier](https://youtu.be/FDFGfYJPLOc?t=02h28m21s)

[uh let's see](https://youtu.be/FDFGfYJPLOc?t=02h28m24s)

[uh identifier](https://youtu.be/FDFGfYJPLOc?t=02h28m27s)

[name](https://youtu.be/FDFGfYJPLOc?t=02h28m30s)

[what are you things](https://youtu.be/FDFGfYJPLOc?t=02h28m31s)

[attribute list syntax](https://youtu.be/FDFGfYJPLOc?t=02h28m34s)

[uh i currently depend on a templating](https://youtu.be/FDFGfYJPLOc?t=02h28m38s)

[engine to assist in the generation of](https://youtu.be/FDFGfYJPLOc?t=02h28m40s)

[newtsoft.json to read my json config](https://youtu.be/FDFGfYJPLOc?t=02h28m42s)

[files](https://youtu.be/FDFGfYJPLOc?t=02h28m45s)

[yeah](https://youtu.be/FDFGfYJPLOc?t=02h28m47s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h28m48s)

[that's going to be fun](https://youtu.be/FDFGfYJPLOc?t=02h28m50s)

[that is going to be fun](https://youtu.be/FDFGfYJPLOc?t=02h28m52s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h28m55s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h28m56s)

[i think what we want to select many](https://youtu.be/FDFGfYJPLOc?t=02h28m59s)

[because this is an ad this is a list](https://youtu.be/FDFGfYJPLOc?t=02h29m04s)

[syntax what is on the list i guess](https://youtu.be/FDFGfYJPLOc?t=02h29m06s)

[let's go here](https://youtu.be/FDFGfYJPLOc?t=02h29m12s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h29m15s)

[yeah so i think we want to select many](https://youtu.be/FDFGfYJPLOc?t=02h29m18s)

[because these are](https://youtu.be/FDFGfYJPLOc?t=02h29m20s)

[attribute lists and under here we want](https://youtu.be/FDFGfYJPLOc?t=02h29m22s)

[the attributes](https://youtu.be/FDFGfYJPLOc?t=02h29m25s)

[and then off of the attributes we want](https://youtu.be/FDFGfYJPLOc?t=02h29m26s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h29m34s)

[first or default because we know the](https://youtu.be/FDFGfYJPLOc?t=02h29m36s)

[compiler is going to prevent it from](https://youtu.be/FDFGfYJPLOc?t=02h29m38s)

[allowing multiple on there](https://youtu.be/FDFGfYJPLOc?t=02h29m39s)

[we want to find an attribute with an](https://youtu.be/FDFGfYJPLOc?t=02h29m42s)

[identifier or a name](https://youtu.be/FDFGfYJPLOc?t=02h29m44s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h29m49s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h29m49s)

[uh what is](https://youtu.be/FDFGfYJPLOc?t=02h29m59s)

[name on here](https://youtu.be/FDFGfYJPLOc?t=02h30m01s)

[we'll spin](https://youtu.be/FDFGfYJPLOc?t=02h30m05s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h30m06s)

[where is the does this not](https://youtu.be/FDFGfYJPLOc?t=02h30m10s)

[does this not have something that's like](https://youtu.be/FDFGfYJPLOc?t=02h30m14s)

[i i mean i could](https://youtu.be/FDFGfYJPLOc?t=02h30m18s)

[name syntax](https://youtu.be/FDFGfYJPLOc?t=02h30m21s)

[i could to string it but i'd much prefer](https://youtu.be/FDFGfYJPLOc?t=02h30m23s)

[something a little bit cleaner](https://youtu.be/FDFGfYJPLOc?t=02h30m26s)

[get red at zero](https://youtu.be/FDFGfYJPLOc?t=02h30m32s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h30m35s)

[can't say i understand exactly what that](https://youtu.be/FDFGfYJPLOc?t=02h30m39s)

[is so simple name](https://youtu.be/FDFGfYJPLOc?t=02h30m41s)

[identifier name syntax i probably am](https://youtu.be/FDFGfYJPLOc?t=02h30m47s)

[going to need to up cast this guy a](https://youtu.be/FDFGfYJPLOc?t=02h30m50s)

[little bit](https://youtu.be/FDFGfYJPLOc?t=02h30m52s)

[because i don't think i want to rely on](https://youtu.be/FDFGfYJPLOc?t=02h30m54s)

[just a two stringer symbol](https://youtu.be/FDFGfYJPLOc?t=02h30m59s)

[similar but maybe that's okay](https://youtu.be/FDFGfYJPLOc?t=02h31m02s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h31m08s)

[like many attributes](https://youtu.be/FDFGfYJPLOc?t=02h31m12s)

[i mean i could go down into here and do](https://youtu.be/FDFGfYJPLOc?t=02h31m18s)

[we could do](https://youtu.be/FDFGfYJPLOc?t=02h31m22s)

[on text](https://youtu.be/FDFGfYJPLOc?t=02h31m24s)

[semantic model get](https://youtu.be/FDFGfYJPLOc?t=02h31m26s)

[hype info right and we could pass in a](https://youtu.be/FDFGfYJPLOc?t=02h31m29s)

[and we could do](https://youtu.be/FDFGfYJPLOc?t=02h31m32s)

[actually](https://youtu.be/FDFGfYJPLOc?t=02h31m35s)

[this becomes a select](https://youtu.be/FDFGfYJPLOc?t=02h31m36s)

[so i want to i want to break this apart](https://youtu.be/FDFGfYJPLOc?t=02h31m40s)

[we get the type info for it](https://youtu.be/FDFGfYJPLOc?t=02h31m43s)

[that goes there](https://youtu.be/FDFGfYJPLOc?t=02h31m47s)

[you just keep daisy chaining and then](https://youtu.be/FDFGfYJPLOc?t=02h31m48s)

[this becomes](https://youtu.be/FDFGfYJPLOc?t=02h31m50s)

[that's a type info now so t dot](https://youtu.be/FDFGfYJPLOc?t=02h31m53s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h31m56s)

[type](https://youtu.be/FDFGfYJPLOc?t=02h31m57s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h32m00s)

[it's like a fully qualified name or](https://youtu.be/FDFGfYJPLOc?t=02h32m04s)

[go through this symbol](https://youtu.be/FDFGfYJPLOc?t=02h32m09s)

[his base type all interfaces](https://youtu.be/FDFGfYJPLOc?t=02h32m12s)

[declare type or is x turn](https://youtu.be/FDFGfYJPLOc?t=02h32m18s)

[this record tuple is type kind](https://youtu.be/FDFGfYJPLOc?t=02h32m21s)

[yeah we'll do this for the moment](https://youtu.be/FDFGfYJPLOc?t=02h32m28s)

[we'll keep it](https://youtu.be/FDFGfYJPLOc?t=02h32m31s)

[simple](https://youtu.be/FDFGfYJPLOc?t=02h32m35s)

[because this is already getting](https://youtu.be/FDFGfYJPLOc?t=02h32m36s)

[complicated](https://youtu.be/FDFGfYJPLOc?t=02h32m37s)

[it's not perfect](https://youtu.be/FDFGfYJPLOc?t=02h32m40s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h32m43s)

[okay so it'll find something with that](https://youtu.be/FDFGfYJPLOc?t=02h32m48s)

[something through there](https://youtu.be/FDFGfYJPLOc?t=02h32m52s)

[let's see if that actually hits](https://youtu.be/FDFGfYJPLOc?t=02h32m54s)

[we still have debug on great](https://youtu.be/FDFGfYJPLOc?t=02h32m58s)

[rebuild source generator](https://youtu.be/FDFGfYJPLOc?t=02h33m01s)

[we can comment this back out otherwise](https://youtu.be/FDFGfYJPLOc?t=02h33m06s)

[we're going to hit](https://youtu.be/FDFGfYJPLOc?t=02h33m08s)

[collisions on the test](https://youtu.be/FDFGfYJPLOc?t=02h33m10s)

[and then we will rebuild here](https://youtu.be/FDFGfYJPLOc?t=02h33m13s)

[and attach debugger](https://youtu.be/FDFGfYJPLOc?t=02h33m21s)

[and i might actually want to do on the](https://youtu.be/FDFGfYJPLOc?t=02h33m25s)

[syntax receiver i might want to catch it](https://youtu.be/FDFGfYJPLOc?t=02h33m28s)

[here](https://youtu.be/FDFGfYJPLOc?t=02h33m30s)

[just so that i can take a look at these](https://youtu.be/FDFGfYJPLOc?t=02h33m32s)

[nodes as they come in](https://youtu.be/FDFGfYJPLOc?t=02h33m34s)

[so compilation unit](https://youtu.be/FDFGfYJPLOc?t=02h33m36s)

[using directive](https://youtu.be/FDFGfYJPLOc?t=02h33m39s)

[qualified name](https://youtu.be/FDFGfYJPLOc?t=02h33m41s)

[more qualified names identifier name](https://youtu.be/FDFGfYJPLOc?t=02h33m45s)

[identifier name](https://youtu.be/FDFGfYJPLOc?t=02h33m47s)

[file scope namespace qualified name](https://youtu.be/FDFGfYJPLOc?t=02h33m50s)

[qualified name qualify name qualify name](https://youtu.be/FDFGfYJPLOc?t=02h33m52s)

[identifier](https://youtu.be/FDFGfYJPLOc?t=02h33m55s)

[get me down to the class one](https://youtu.be/FDFGfYJPLOc?t=02h33m57s)

[okay this is the one we want to look at](https://youtu.be/FDFGfYJPLOc?t=02h33m59s)

[okay so](https://youtu.be/FDFGfYJPLOc?t=02h34m04s)

[by step](https://youtu.be/FDFGfYJPLOc?t=02h34m08s)

[modifiers partial partial](https://youtu.be/FDFGfYJPLOc?t=02h34m10s)

[so we got to the second one](https://youtu.be/FDFGfYJPLOc?t=02h34m13s)

[attribute list](https://youtu.be/FDFGfYJPLOc?t=02h34m17s)

[not entirely sure if this is going to](https://youtu.be/FDFGfYJPLOc?t=02h34m21s)

[work](https://youtu.be/FDFGfYJPLOc?t=02h34m23s)

[so it's going to select out the](https://youtu.be/FDFGfYJPLOc?t=02h34m24s)

[attributes in this case test class great](https://youtu.be/FDFGfYJPLOc?t=02h34m25s)

[it's going to grab the type info for it](https://youtu.be/FDFGfYJPLOc?t=02h34m29s)

[select it the type info that it got came](https://youtu.be/FDFGfYJPLOc?t=02h34m32s)

[back](https://youtu.be/FDFGfYJPLOc?t=02h34m35s)

[as test class attribute](https://youtu.be/FDFGfYJPLOc?t=02h34m36s)

[that's fine next set of attributes](https://youtu.be/FDFGfYJPLOc?t=02h34m39s)

[it's hours get the type info](https://youtu.be/FDFGfYJPLOc?t=02h34m42s)

[the type is constructor test attribute](https://youtu.be/FDFGfYJPLOc?t=02h34m45s)

[instructor test attribute](https://youtu.be/FDFGfYJPLOc?t=02h34m48s)

[it matched hallelujah](https://youtu.be/FDFGfYJPLOc?t=02h34m51s)

[got the clear declared symbol wow](https://youtu.be/FDFGfYJPLOc?t=02h34m53s)

[i kind of assumed that big of an if](https://youtu.be/FDFGfYJPLOc?t=02h34m56s)

[statement my world was going to end](https://youtu.be/FDFGfYJPLOc?t=02h34m58s)

[pretty quick](https://youtu.be/FDFGfYJPLOc?t=02h35m00s)

[that actually worked](https://youtu.be/FDFGfYJPLOc?t=02h35m02s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h35m06s)

[okay so get let's clean some of these up](https://youtu.be/FDFGfYJPLOc?t=02h35m07s)

[now too](https://youtu.be/FDFGfYJPLOc?t=02h35m09s)

[because this guy here has more](https://youtu.be/FDFGfYJPLOc?t=02h35m11s)

[information than what he's giving me](https://youtu.be/FDFGfYJPLOc?t=02h35m13s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h35m16s)

[i want](https://youtu.be/FDFGfYJPLOc?t=02h35m17s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h35m20s)

[this guy to give me some information on](https://youtu.be/FDFGfYJPLOc?t=02h35m22s)

[his stuff](https://youtu.be/FDFGfYJPLOc?t=02h35m26s)

[specifically i wanted his](https://youtu.be/FDFGfYJPLOc?t=02h35m29s)

[type and his](https://youtu.be/FDFGfYJPLOc?t=02h35m31s)

[containing namespace so that's probably](https://youtu.be/FDFGfYJPLOc?t=02h35m35s)

[the one we want to start with](https://youtu.be/FDFGfYJPLOc?t=02h35m38s)

[so this is going to become](https://youtu.be/FDFGfYJPLOc?t=02h35m42s)

[symbol](https://youtu.be/FDFGfYJPLOc?t=02h35m47s)

[containing namespace](https://youtu.be/FDFGfYJPLOc?t=02h35m49s)

[dot](https://youtu.be/FDFGfYJPLOc?t=02h35m51s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h35m53s)

[this is the one where they have](https://youtu.be/FDFGfYJPLOc?t=02h35m56s)

[overrides right on](https://youtu.be/FDFGfYJPLOc?t=02h35m59s)

[the display string](https://youtu.be/FDFGfYJPLOc?t=02h36m02s)

[i believe here you can go](https://youtu.be/FDFGfYJPLOc?t=02h36m04s)

[with uh let's see symbol display format](https://youtu.be/FDFGfYJPLOc?t=02h36m06s)

[and there's like yeah there we go](https://youtu.be/FDFGfYJPLOc?t=02h36m12s)

[fully qualified](https://youtu.be/FDFGfYJPLOc?t=02h36m14s)

[minimally qualified](https://youtu.be/FDFGfYJPLOc?t=02h36m19s)

[i think we're gonna go fully qualified i](https://youtu.be/FDFGfYJPLOc?t=02h36m21s)

[don't know if that's quite what i want](https://youtu.be/FDFGfYJPLOc?t=02h36m23s)

[but we're gonna try it](https://youtu.be/FDFGfYJPLOc?t=02h36m24s)

[all right it's not gonna be happy with](https://youtu.be/FDFGfYJPLOc?t=02h36m28s)

[me](https://youtu.be/FDFGfYJPLOc?t=02h36m30s)

[so keep editing so it won't let me run](https://youtu.be/FDFGfYJPLOc?t=02h36m31s)

[the code](https://youtu.be/FDFGfYJPLOc?t=02h36m34s)

[but if i come down here to my](https://youtu.be/FDFGfYJPLOc?t=02h36m35s)

[interactive window](https://youtu.be/FDFGfYJPLOc?t=02h36m36s)

[or my immediate window boom and you'll](https://youtu.be/FDFGfYJPLOc?t=02h36m38s)

[note fully qualified does do the global](https://youtu.be/FDFGfYJPLOc?t=02h36m41s)

[colon colon in front of it to make sure](https://youtu.be/FDFGfYJPLOc?t=02h36m44s)

[you don't run into problems so that's](https://youtu.be/FDFGfYJPLOc?t=02h36m46s)

[great uh okay so let's get the class](https://youtu.be/FDFGfYJPLOc?t=02h36m48s)

[name too where](https://youtu.be/FDFGfYJPLOc?t=02h36m52s)

[where am i gonna find you at](https://youtu.be/FDFGfYJPLOc?t=02h36m54s)

[constructed from](https://youtu.be/FDFGfYJPLOc?t=02h36m56s)

[that looks very](https://youtu.be/FDFGfYJPLOc?t=02h37m00s)

[possible](https://youtu.be/FDFGfYJPLOc?t=02h37m02s)

[original definition](https://youtu.be/FDFGfYJPLOc?t=02h37m04s)

[also looks like a good one](https://youtu.be/FDFGfYJPLOc?t=02h37m07s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h37m14s)

[name is not looking good](https://youtu.be/FDFGfYJPLOc?t=02h37m18s)

[original definition is looking pretty](https://youtu.be/FDFGfYJPLOc?t=02h37m21s)

[pretty good to me](https://youtu.be/FDFGfYJPLOc?t=02h37m25s)

[it's redefined a couple times](https://youtu.be/FDFGfYJPLOc?t=02h37m28s)

[yeah i'm thinking we're going original](https://youtu.be/FDFGfYJPLOc?t=02h37m35s)

[definition](https://youtu.be/FDFGfYJPLOc?t=02h37m37s)

[so this is going to be then](https://youtu.be/FDFGfYJPLOc?t=02h37m38s)

[let's see](https://youtu.be/FDFGfYJPLOc?t=02h37m42s)

[symbol](https://youtu.be/FDFGfYJPLOc?t=02h37m43s)

[original definition to display string](https://youtu.be/FDFGfYJPLOc?t=02h37m46s)

[uh symbol for display format](https://youtu.be/FDFGfYJPLOc?t=02h37m50s)

[fully qualified](https://youtu.be/FDFGfYJPLOc?t=02h37m55s)

[show it to me](https://youtu.be/FDFGfYJPLOc?t=02h37m56s)

[that looks great](https://youtu.be/FDFGfYJPLOc?t=02h37m58s)

[test class name](https://youtu.be/FDFGfYJPLOc?t=02h38m01s)

[this](https://youtu.be/FDFGfYJPLOc?t=02h38m06s)

[is](https://youtu.be/FDFGfYJPLOc?t=02h38m06s)

[we're test class name i guess i should](https://youtu.be/FDFGfYJPLOc?t=02h38m13s)

[look at where this gets used](https://youtu.be/FDFGfYJPLOc?t=02h38m15s)

[i think test class name before was](https://youtu.be/FDFGfYJPLOc?t=02h38m18s)

[pretty](https://youtu.be/FDFGfYJPLOc?t=02h38m20s)

[light so we might actually want](https://youtu.be/FDFGfYJPLOc?t=02h38m21s)

[minimally qualified here](https://youtu.be/FDFGfYJPLOc?t=02h38m24s)

[yeah so let's that lines up with what we](https://youtu.be/FDFGfYJPLOc?t=02h38m30s)

[had before so we'll put that in](https://youtu.be/FDFGfYJPLOc?t=02h38m32s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h38m35s)

[that gets me there](https://youtu.be/FDFGfYJPLOc?t=02h38m36s)

[okay and then this guy is going to have](https://youtu.be/FDFGfYJPLOc?t=02h38m41s)

[a bunch of stuff on it](https://youtu.be/FDFGfYJPLOc?t=02h38m44s)

[uh oh and we should do a](https://youtu.be/FDFGfYJPLOc?t=02h38m46s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h38m51s)

[test attribute](https://youtu.be/FDFGfYJPLOc?t=02h38m53s)

[type](https://youtu.be/FDFGfYJPLOc?t=02h38m57s)

[is](https://youtu.be/FDFGfYJPLOc?t=02h38m58s)

[not null](https://youtu.be/FDFGfYJPLOc?t=02h39m06s)

[oh wait we know the type is not null](https://youtu.be/FDFGfYJPLOc?t=02h39m13s)

[because this thing matched](https://youtu.be/FDFGfYJPLOc?t=02h39m15s)

[we can make that assumption](https://youtu.be/FDFGfYJPLOc?t=02h39m18s)

[but what we really want to grab is the](https://youtu.be/FDFGfYJPLOc?t=02h39m21s)

[argument list off of that](https://youtu.be/FDFGfYJPLOc?t=02h39m24s)

[right so this guy here](https://youtu.be/FDFGfYJPLOc?t=02h39m28s)

[yeah show me your stuff because you are](https://youtu.be/FDFGfYJPLOc?t=02h39m31s)

[going to have some number](https://youtu.be/FDFGfYJPLOc?t=02h39m33s)

[of property specified or initializers](https://youtu.be/FDFGfYJPLOc?t=02h39m36s)

[set on you](https://youtu.be/FDFGfYJPLOc?t=02h39m40s)

[locations that doesn't count](https://youtu.be/FDFGfYJPLOc?t=02h39m43s)

[up above where are you](https://youtu.be/FDFGfYJPLOc?t=02h39m46s)

[where are you](https://youtu.be/FDFGfYJPLOc?t=02h39m52s)

[instance constructors](https://youtu.be/FDFGfYJPLOc?t=02h39m54s)

[actually wondering if maybe i want to](https://youtu.be/FDFGfYJPLOc?t=02h40m06s)

[grab the original attribute](https://youtu.be/FDFGfYJPLOc?t=02h40m07s)

[oh first time seeing this immediate](https://youtu.be/FDFGfYJPLOc?t=02h40m12s)

[window console thing yeah so the](https://youtu.be/FDFGfYJPLOc?t=02h40m14s)

[immediate window is awesome because it](https://youtu.be/FDFGfYJPLOc?t=02h40m16s)

[lets you evaluate code so it's it may](https://youtu.be/FDFGfYJPLOc?t=02h40m18s)

[not be obvious because of how much i've](https://youtu.be/FDFGfYJPLOc?t=02h40m20s)

[messed up this code but this little](https://youtu.be/FDFGfYJPLOc?t=02h40m22s)

[yellow arrow shows me my current](https://youtu.be/FDFGfYJPLOc?t=02h40m24s)

[execution pointer](https://youtu.be/FDFGfYJPLOc?t=02h40m25s)

[and so you can run code in your](https://youtu.be/FDFGfYJPLOc?t=02h40m27s)

[immediate window as though it were at](https://youtu.be/FDFGfYJPLOc?t=02h40m29s)

[that point in your code so you have](https://youtu.be/FDFGfYJPLOc?t=02h40m31s)

[access to all your your variables that](https://youtu.be/FDFGfYJPLOc?t=02h40m33s)

[would exist at that point](https://youtu.be/FDFGfYJPLOc?t=02h40m36s)

[you can actually do assignments and](https://youtu.be/FDFGfYJPLOc?t=02h40m38s)

[other things and get yourself into all](https://youtu.be/FDFGfYJPLOc?t=02h40m40s)

[kinds of invalid states it's great fun](https://youtu.be/FDFGfYJPLOc?t=02h40m42s)

[but it is incredibly powerful the other](https://youtu.be/FDFGfYJPLOc?t=02h40m46s)

[one that you have um](https://youtu.be/FDFGfYJPLOc?t=02h40m48s)

[if you haven't seen it](https://youtu.be/FDFGfYJPLOc?t=02h40m50s)

[is the interactive windows](https://youtu.be/FDFGfYJPLOc?t=02h40m53s)

[these ones are kind of like the](https://youtu.be/FDFGfYJPLOc?t=02h40m55s)

[immediate window except for you don't](https://youtu.be/FDFGfYJPLOc?t=02h40m57s)

[get the context so these are just meant](https://youtu.be/FDFGfYJPLOc?t=02h40m59s)

[for kind of like your quick scratch pad](https://youtu.be/FDFGfYJPLOc?t=02h41m02s)

[or like a rebel type thing where you can](https://youtu.be/FDFGfYJPLOc?t=02h41m04s)

[try out different c sharp code](https://youtu.be/FDFGfYJPLOc?t=02h41m06s)

[but you can get a kind of a back and](https://youtu.be/FDFGfYJPLOc?t=02h41m09s)

[forth interactive methodology to it](https://youtu.be/FDFGfYJPLOc?t=02h41m11s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h41m16s)

[if you're interested](https://youtu.be/FDFGfYJPLOc?t=02h41m17s)

[i tend to use both of these things quite](https://youtu.be/FDFGfYJPLOc?t=02h41m20s)

[a bit i like the immediate window for](https://youtu.be/FDFGfYJPLOc?t=02h41m22s)

[kind of just quick testing code to see](https://youtu.be/FDFGfYJPLOc?t=02h41m24s)

[quick evaluations of what what things](https://youtu.be/FDFGfYJPLOc?t=02h41m27s)

[are going to do](https://youtu.be/FDFGfYJPLOc?t=02h41m30s)

[because the the watch windows and](https://youtu.be/FDFGfYJPLOc?t=02h41m32s)

[whatnot are pretty good but they don't](https://youtu.be/FDFGfYJPLOc?t=02h41m34s)

[quite get you](https://youtu.be/FDFGfYJPLOc?t=02h41m35s)

[exactly what i want in a lot of cases](https://youtu.be/FDFGfYJPLOc?t=02h41m38s)

[okay so that evaluated the type but what](https://youtu.be/FDFGfYJPLOc?t=02h41m43s)

[i actually want is the token from up](https://youtu.be/FDFGfYJPLOc?t=02h41m46s)

[here](https://youtu.be/FDFGfYJPLOc?t=02h41m48s)

[so this is so unfortunately when i did](https://youtu.be/FDFGfYJPLOc?t=02h41m55s)

[this select i threw away part of the](https://youtu.be/FDFGfYJPLOc?t=02h41m58s)

[data i wanted](https://youtu.be/FDFGfYJPLOc?t=02h42m00s)

[so i might have to go back and break](https://youtu.be/FDFGfYJPLOc?t=02h42m03s)

[that up because i](https://youtu.be/FDFGfYJPLOc?t=02h42m04s)

[i don't act so i i want the type to do](https://youtu.be/FDFGfYJPLOc?t=02h42m06s)

[the evaluation but once i confirm the](https://youtu.be/FDFGfYJPLOc?t=02h42m09s)

[evaluation i want to go back and look at](https://youtu.be/FDFGfYJPLOc?t=02h42m11s)

[the individual attributes](https://youtu.be/FDFGfYJPLOc?t=02h42m15s)

[because i want this argument list](https://youtu.be/FDFGfYJPLOc?t=02h42m20s)

[yeah](https://youtu.be/FDFGfYJPLOc?t=02h42m26s)

[so i want the argument list off the](https://youtu.be/FDFGfYJPLOc?t=02h42m29s)

[attribute at a certain point](https://youtu.be/FDFGfYJPLOc?t=02h42m31s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h42m34s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h42m34s)

[do i actually care](https://youtu.be/FDFGfYJPLOc?t=02h42m38s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h42m41s)

[i think what we can do here is we can](https://youtu.be/FDFGfYJPLOc?t=02h42m58s)

[make this a little more interesting](https://youtu.be/FDFGfYJPLOc?t=02h43m00s)

[so we can do something a bit like this](https://youtu.be/FDFGfYJPLOc?t=02h43m03s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h43m08s)

[we can move](https://youtu.be/FDFGfYJPLOc?t=02h43m09s)

[this guy into](https://youtu.be/FDFGfYJPLOc?t=02h43m12s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h43m14s)

[uh let's see](https://youtu.be/FDFGfYJPLOc?t=02h43m17s)

[you can pull this out](https://youtu.be/FDFGfYJPLOc?t=02h43m22s)

[and do something like this](https://youtu.be/FDFGfYJPLOc?t=02h43m26s)

[and then where](https://youtu.be/FDFGfYJPLOc?t=02h43m30s)

[t](https://youtu.be/FDFGfYJPLOc?t=02h43m32s)

[is not null](https://youtu.be/FDFGfYJPLOc?t=02h43m33s)

[just do that](https://youtu.be/FDFGfYJPLOc?t=02h43m37s)

[and so the else condition here will just](https://youtu.be/FDFGfYJPLOc?t=02h43m39s)

[be return null](https://youtu.be/FDFGfYJPLOc?t=02h43m41s)

[and then](https://youtu.be/FDFGfYJPLOc?t=02h43m44s)

[that goes like that](https://youtu.be/FDFGfYJPLOc?t=02h43m45s)

[so that we can still do the test](https://youtu.be/FDFGfYJPLOc?t=02h43m49s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h43m52s)

[return](https://youtu.be/FDFGfYJPLOc?t=02h43m53s)

[a](https://youtu.be/FDFGfYJPLOc?t=02h43m55s)

[and so this is no longer a type so i've](https://youtu.be/FDFGfYJPLOc?t=02h43m58s)

[subtly by doing this rather than](https://youtu.be/FDFGfYJPLOc?t=02h44m00s)

[returning the type info i'm now back to](https://youtu.be/FDFGfYJPLOc?t=02h44m02s)

[returning the attribute itself](https://youtu.be/FDFGfYJPLOc?t=02h44m04s)

[which is a little bit nicer](https://youtu.be/FDFGfYJPLOc?t=02h44m09s)

[yeah because this will return null](https://youtu.be/FDFGfYJPLOc?t=02h44m17s)

[this thing will keep iterating until it](https://youtu.be/FDFGfYJPLOc?t=02h44m19s)

[finds a not null value which will](https://youtu.be/FDFGfYJPLOc?t=02h44m21s)

[indicate that that that it matched this](https://youtu.be/FDFGfYJPLOc?t=02h44m23s)

[condition here but rather than getting](https://youtu.be/FDFGfYJPLOc?t=02h44m26s)

[the original](https://youtu.be/FDFGfYJPLOc?t=02h44m29s)

[or the the type info i'll get the](https://youtu.be/FDFGfYJPLOc?t=02h44m30s)

[original attribute back out of it](https://youtu.be/FDFGfYJPLOc?t=02h44m32s)

[um okay and so then what we want to do](https://youtu.be/FDFGfYJPLOc?t=02h44m36s)

[is](https://youtu.be/FDFGfYJPLOc?t=02h44m40s)

[let's stop debugging here real quick](https://youtu.be/FDFGfYJPLOc?t=02h44m41s)

[um we can leave the break point there](https://youtu.be/FDFGfYJPLOc?t=02h44m44s)

[i'm gonna turn this breakpoint off let's](https://youtu.be/FDFGfYJPLOc?t=02h44m48s)

[rebuild and i want to try this guy one](https://youtu.be/FDFGfYJPLOc?t=02h44m50s)

[more time](https://youtu.be/FDFGfYJPLOc?t=02h44m52s)

[so i think we can get this pulling that](https://youtu.be/FDFGfYJPLOc?t=02h44m57s)

[type off next](https://youtu.be/FDFGfYJPLOc?t=02h45m00s)

[because we just need to pull the type](https://youtu.be/FDFGfYJPLOc?t=02h45m03s)

[out of the attribute and then rip](https://youtu.be/FDFGfYJPLOc?t=02h45m05s)

[through its constructors](https://youtu.be/FDFGfYJPLOc?t=02h45m06s)

[okay so there's that](https://youtu.be/FDFGfYJPLOc?t=02h45m10s)

[okay so the](https://youtu.be/FDFGfYJPLOc?t=02h45m12s)

[this guy here](https://youtu.be/FDFGfYJPLOc?t=02h45m15s)

[perfect so now i just need to pull off](https://youtu.be/FDFGfYJPLOc?t=02h45m17s)

[his argument list](https://youtu.be/FDFGfYJPLOc?t=02h45m19s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h45m22s)

[because that's where i'm going to get](https://youtu.be/FDFGfYJPLOc?t=02h45m25s)

[these values here](https://youtu.be/FDFGfYJPLOc?t=02h45m27s)

[so i want to do something with](https://youtu.be/FDFGfYJPLOc?t=02h45m29s)

[test attribute](https://youtu.be/FDFGfYJPLOc?t=02h45m32s)

[argument list](https://youtu.be/FDFGfYJPLOc?t=02h45m34s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h45m37s)

[in this case i can just go](https://youtu.be/FDFGfYJPLOc?t=02h45m39s)

[zero](https://youtu.be/FDFGfYJPLOc?t=02h45m41s)

[or i guess](https://youtu.be/FDFGfYJPLOc?t=02h45m42s)

[what are you why are you being so dumb](https://youtu.be/FDFGfYJPLOc?t=02h45m47s)

[argumentless](https://youtu.be/FDFGfYJPLOc?t=02h45m53s)

[about arguments](https://youtu.be/FDFGfYJPLOc?t=02h45m56s)

[okay](https://youtu.be/FDFGfYJPLOc?t=02h45m58s)

[okay so that is going to give me back](https://youtu.be/FDFGfYJPLOc?t=02h46m02s)

[something a little more useful](https://youtu.be/FDFGfYJPLOc?t=02h46m05s)

[so argument list](https://youtu.be/FDFGfYJPLOc?t=02h46m08s)

[arguments](https://youtu.be/FDFGfYJPLOc?t=02h46m10s)

[and then inside of there i will get](https://youtu.be/FDFGfYJPLOc?t=02h46m12s)

[an attribute argument syntax](https://youtu.be/FDFGfYJPLOc?t=02h46m16s)

[this where i want to be](https://youtu.be/FDFGfYJPLOc?t=02h46m20s)

[i think this is where i want to be but](https://youtu.be/FDFGfYJPLOc?t=02h46m33s)

[i'm actually not](https://youtu.be/FDFGfYJPLOc?t=02h46m36s)

[let me look at the no or the xaml test](https://youtu.be/FDFGfYJPLOc?t=02h46m39s)

[one again because that one](https://youtu.be/FDFGfYJPLOc?t=02h46m41s)

[it went to the arguments list arguments](https://youtu.be/FDFGfYJPLOc?t=02h46m44s)

[validated the attribute](https://youtu.be/FDFGfYJPLOc?t=02h46m49s)

[and then pull the pull the type of](https://youtu.be/FDFGfYJPLOc?t=02h46m54s)

[expression off of it](https://youtu.be/FDFGfYJPLOc?t=02h46m56s)

[okay so that is](https://youtu.be/FDFGfYJPLOc?t=02h47m00s)

[that's pretty much what we want to do](https://youtu.be/FDFGfYJPLOc?t=02h47m05s)

[here](https://youtu.be/FDFGfYJPLOc?t=02h47m07s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h47m12s)

[it's going to look a little bit like](https://youtu.be/FDFGfYJPLOc?t=02h47m13s)

[that](https://youtu.be/FDFGfYJPLOc?t=02h47m15s)

[this will be](https://youtu.be/FDFGfYJPLOc?t=02h47m17s)

[quick and dirty approach but i suspect](https://youtu.be/FDFGfYJPLOc?t=02h47m18s)

[we've got a](https://youtu.be/FDFGfYJPLOc?t=02h47m20s)

[problem with it](https://youtu.be/FDFGfYJPLOc?t=02h47m23s)

[what are you squawking about](https://youtu.be/FDFGfYJPLOc?t=02h47m26s)

[oh it's because i'm debugging](https://youtu.be/FDFGfYJPLOc?t=02h47m29s)

[uh argument list may be null here yeah](https://youtu.be/FDFGfYJPLOc?t=02h47m32s)

[yeah yeah](https://youtu.be/FDFGfYJPLOc?t=02h47m35s)

[so we could actually go a step further](https://youtu.be/FDFGfYJPLOc?t=02h47m48s)

[and validate all of these things inside](https://youtu.be/FDFGfYJPLOc?t=02h47m50s)

[of here i'm actually realizing this](https://youtu.be/FDFGfYJPLOc?t=02h47m53s)

[thing is probably a much cheaper call](https://youtu.be/FDFGfYJPLOc?t=02h47m55s)

[than what we're about to do so i'm going](https://youtu.be/FDFGfYJPLOc?t=02h47m57s)

[to move it up](https://youtu.be/FDFGfYJPLOc?t=02h47m58s)

[here](https://youtu.be/FDFGfYJPLOc?t=02h48m01s)

[make that call go first um because in](https://youtu.be/FDFGfYJPLOc?t=02h48m03s)

[here what we could actually end up doing](https://youtu.be/FDFGfYJPLOc?t=02h48m06s)

[is then evaluating](https://youtu.be/FDFGfYJPLOc?t=02h48m08s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h48m12s)

[if this is the appropriate thing i think](https://youtu.be/FDFGfYJPLOc?t=02h48m13s)

[what i'm going to do though is this is](https://youtu.be/FDFGfYJPLOc?t=02h48m15s)

[getting to be hairy i'm going to make a](https://youtu.be/FDFGfYJPLOc?t=02h48m16s)

[i'm going to make a separate method for](https://youtu.be/FDFGfYJPLOc?t=02h48m18s)

[this](https://youtu.be/FDFGfYJPLOc?t=02h48m20s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h48m21s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h48m22s)

[private uh what is](https://youtu.be/FDFGfYJPLOc?t=02h48m24s)

[what is a here attribute syntax private](https://youtu.be/FDFGfYJPLOc?t=02h48m27s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h48m31s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h48m38s)

[get](https://youtu.be/FDFGfYJPLOc?t=02h48m39s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h48m40s)

[target type](https://youtu.be/FDFGfYJPLOc?t=02h48m45s)

[sure](https://youtu.be/FDFGfYJPLOc?t=02h48m46s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h48m48s)

[attribute syntax](https://youtu.be/FDFGfYJPLOc?t=02h48m51s)

[something like that](https://youtu.be/FDFGfYJPLOc?t=02h48m55s)

[then i'm going to do](https://youtu.be/FDFGfYJPLOc?t=02h48m57s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h48m59s)

[i'm going to just bring this into here](https://youtu.be/FDFGfYJPLOc?t=02h49m01s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h49m04s)

[uh we may not do this whole lift we](https://youtu.be/FDFGfYJPLOc?t=02h49m11s)

[might just assume the inside of the if](https://youtu.be/FDFGfYJPLOc?t=02h49m13s)

[already](https://youtu.be/FDFGfYJPLOc?t=02h49m14s)

[so if](https://youtu.be/FDFGfYJPLOc?t=02h49m15s)

[uh attribute syntax](https://youtu.be/FDFGfYJPLOc?t=02h49m17s)

[argument list](https://youtu.be/FDFGfYJPLOc?t=02h49m20s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h49m24s)

[arguments](https://youtu.be/FDFGfYJPLOc?t=02h49m27s)

[count greater than zero so we do have](https://youtu.be/FDFGfYJPLOc?t=02h49m29s)

[some arguments](https://youtu.be/FDFGfYJPLOc?t=02h49m32s)

[uh see we can do that](https://youtu.be/FDFGfYJPLOc?t=02h49m34s)

[um and](https://youtu.be/FDFGfYJPLOc?t=02h49m38s)

[attribute syntax argument list](https://youtu.be/FDFGfYJPLOc?t=02h49m41s)

[dot arguments](https://youtu.be/FDFGfYJPLOc?t=02h49m45s)

[first or default](https://youtu.be/FDFGfYJPLOc?t=02h49m49s)

[uh actually we should probably do an up](https://youtu.be/FDFGfYJPLOc?t=02h49m52s)

[type first](https://youtu.be/FDFGfYJPLOc?t=02h49m54s)

[of type](https://youtu.be/FDFGfYJPLOc?t=02h49m57s)

[because we wanted to hunt the ones that](https://youtu.be/FDFGfYJPLOc?t=02h49m59s)

[were](https://youtu.be/FDFGfYJPLOc?t=02h50m01s)

[we want the expression that our type of](https://youtu.be/FDFGfYJPLOc?t=02h50m04s)

[arguments so we're going to go select](https://youtu.be/FDFGfYJPLOc?t=02h50m07s)

[x dot expression](https://youtu.be/FDFGfYJPLOc?t=02h50m12s)

[of type](https://youtu.be/FDFGfYJPLOc?t=02h50m15s)

[or type of expressions](https://youtu.be/FDFGfYJPLOc?t=02h50m17s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h50m20s)

[and then we are going to take the](https://youtu.be/FDFGfYJPLOc?t=02h50m26s)

[type of](https://youtu.be/FDFGfYJPLOc?t=02h50m29s)

[expression and we are going to](https://youtu.be/FDFGfYJPLOc?t=02h50m32s)

[get the type info for it](https://youtu.be/FDFGfYJPLOc?t=02h50m38s)

[well i guess once we get the type of](https://youtu.be/FDFGfYJPLOc?t=02h50m42s)

[expression we can just return the type](https://youtu.be/FDFGfYJPLOc?t=02h50m43s)

[that'll be type syntax](https://youtu.be/FDFGfYJPLOc?t=02h50m46s)

[uh first or default](https://youtu.be/FDFGfYJPLOc?t=02h50m49s)

[uh](https://youtu.be/FDFGfYJPLOc?t=02h50m55s)

[type expression](https://youtu.be/FDFGfYJPLOc?t=02h51m02s)

[or null](https://youtu.be/FDFGfYJPLOc?t=02h51m04s)

[we're going to just change the return](https://youtu.be/FDFGfYJPLOc?t=02h51m06s)

[type of this to be](https://youtu.be/FDFGfYJPLOc?t=02h51m07s)

[type](https://youtu.be/FDFGfYJPLOc?t=02h51m08s)

[uh type of expression](https://youtu.be/FDFGfYJPLOc?t=02h51m13s)

[i actually want this to be the type](https://youtu.be/FDFGfYJPLOc?t=02h51m16s)

[which is going to be type syntax](https://youtu.be/FDFGfYJPLOc?t=02h51m19s)

[just drop](https://youtu.be/FDFGfYJPLOc?t=02h51m22s)

[that](https://youtu.be/FDFGfYJPLOc?t=02h51m25s)

[will reference type all the things](https://youtu.be/FDFGfYJPLOc?t=02h51m28s)

[[Music]](https://youtu.be/FDFGfYJPLOc?t=02h51m31s)

[uh return](https://youtu.be/FDFGfYJPLOc?t=02h51m38s)

[get target type](https://youtu.be/FDFGfYJPLOc?t=02h51m43s)

[that way that stops this from getting](https://youtu.be/FDFGfYJPLOc?t=02h51m47s)

[out of hand](https://youtu.be/FDFGfYJPLOc?t=02h51m50s)

[let's see so that'll get the target type](https://youtu.be/FDFGfYJPLOc?t=02h51m52s)

[syntax](https://youtu.be/FDFGfYJPLOc?t=02h51m54s)

[so off topic question but would you use](https://youtu.be/FDFGfYJPLOc?t=02h52m04s)

[svgs or pngs for icon button images in](https://youtu.be/FDFGfYJPLOc?t=02h52m06s)

[your wpf app is there a standard um](https://youtu.be/FDFGfYJPLOc?t=02h52m11s)

[there's not a standard per se](https://youtu.be/FDFGfYJPLOc?t=02h52m16s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h52m21s)

[and it depends a little bit so](https://youtu.be/FDFGfYJPLOc?t=02h52m26s)

[if it is an image asset where](https://youtu.be/FDFGfYJPLOc?t=02h52m29s)

[sizing is going to change or scale](https://youtu.be/FDFGfYJPLOc?t=02h52m32s)

[differently](https://youtu.be/FDFGfYJPLOc?t=02h52m35s)

[um i would probably go with an svg](https://youtu.be/FDFGfYJPLOc?t=02h52m36s)

[the](https://youtu.be/FDFGfYJPLOc?t=02h52m39s)

[the advantage of a png or a bitmap is](https://youtu.be/FDFGfYJPLOc?t=02h52m40s)

[going to be that you have a native](https://youtu.be/FDFGfYJPLOc?t=02h52m43s)

[support for it](https://youtu.be/FDFGfYJPLOc?t=02h52m45s)

[whereas svg](https://youtu.be/FDFGfYJPLOc?t=02h52m47s)

[uh wpf kind of predates when svg was](https://youtu.be/FDFGfYJPLOc?t=02h52m49s)

[really a thing so](https://youtu.be/FDFGfYJPLOc?t=02h52m53s)

[there's not native svg support inside of](https://youtu.be/FDFGfYJPLOc?t=02h52m54s)

[wpf you end up dropping into something](https://youtu.be/FDFGfYJPLOc?t=02h52m57s)

[like skia sharper or similar to get](https://youtu.be/FDFGfYJPLOc?t=02h52m59s)

[um svg type](https://youtu.be/FDFGfYJPLOc?t=02h53m02s)

[things in there so](https://youtu.be/FDFGfYJPLOc?t=02h53m05s)

[so you will find that it is much easier](https://youtu.be/FDFGfYJPLOc?t=02h53m08s)

[to pull in a bitmap or a png](https://youtu.be/FDFGfYJPLOc?t=02h53m11s)

[because you can just use the bitmap](https://youtu.be/FDFGfYJPLOc?t=02h53m13s)

[image source or similar](https://youtu.be/FDFGfYJPLOc?t=02h53m15s)

[um to load those guys up slap them onto](https://youtu.be/FDFGfYJPLOc?t=02h53m17s)

[an image control and you're done](https://youtu.be/FDFGfYJPLOc?t=02h53m19s)

[great](https://youtu.be/FDFGfYJPLOc?t=02h53m21s)

[um and often those image controls will](https://youtu.be/FDFGfYJPLOc?t=02h53m22s)

[scale up and down but it's the same as](https://youtu.be/FDFGfYJPLOc?t=02h53m26s)

[if you were to like resize the image in](https://youtu.be/FDFGfYJPLOc?t=02h53m28s)

[paint or something right you can get](https://youtu.be/FDFGfYJPLOc?t=02h53m30s)

[pixelation and it doesn't give you those](https://youtu.be/FDFGfYJPLOc?t=02h53m32s)

[nice pretty smooth lines and whatnot](https://youtu.be/FDFGfYJPLOc?t=02h53m34s)

[that you would get with vector](https://youtu.be/FDFGfYJPLOc?t=02h53m36s)

[vector-based](https://youtu.be/FDFGfYJPLOc?t=02h53m36s)

[art](https://youtu.be/FDFGfYJPLOc?t=02h53m38s)

[the the other option because svgs don't](https://youtu.be/FDFGfYJPLOc?t=02h53m40s)

[have](https://youtu.be/FDFGfYJPLOc?t=02h53m43s)

[built-in support that doesn't mean wpf](https://youtu.be/FDFGfYJPLOc?t=02h53m44s)

[does not have vector support](https://youtu.be/FDFGfYJPLOc?t=02h53m46s)

[they do have um](https://youtu.be/FDFGfYJPLOc?t=02h53m49s)

[shoot i'm blanking on the name the path](https://youtu.be/FDFGfYJPLOc?t=02h53m53s)

[that that you can use to](https://youtu.be/FDFGfYJPLOc?t=02h53m56s)

[to get vector-based drawing inside a wpf](https://youtu.be/FDFGfYJPLOc?t=02h53m58s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h54m03s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h54m04s)

[that's it](https://youtu.be/FDFGfYJPLOc?t=02h54m06s)

[there are there are a handful of things](https://youtu.be/FDFGfYJPLOc?t=02h54m07s)

[that will actually generate them so](https://youtu.be/FDFGfYJPLOc?t=02h54m10s)

[depending on where you're getting your](https://youtu.be/FDFGfYJPLOc?t=02h54m12s)

[icons so](https://youtu.be/FDFGfYJPLOc?t=02h54m13s)

[uh material](https://youtu.be/FDFGfYJPLOc?t=02h54m15s)

[design icons so for example](https://youtu.be/FDFGfYJPLOc?t=02h54m16s)

[i'm just gonna pick on this one because](https://youtu.be/FDFGfYJPLOc?t=02h54m20s)

[i know this one](https://youtu.be/FDFGfYJPLOc?t=02h54m22s)

[load me an icon i don't care which](https://youtu.be/FDFGfYJPLOc?t=02h54m27s)

[just need an icon](https://youtu.be/FDFGfYJPLOc?t=02h54m29s)

[sure you will do perfect um you'll note](https://youtu.be/FDFGfYJPLOc?t=02h54m31s)

[here when i](https://youtu.be/FDFGfYJPLOc?t=02h54m34s)

[have the options so they will give you](https://youtu.be/FDFGfYJPLOc?t=02h54m36s)

[some xaml based](https://youtu.be/FDFGfYJPLOc?t=02h54m40s)

[options for pulling this in with like a](https://youtu.be/FDFGfYJPLOc?t=02h54m42s)

[view box and a canvas but again it's](https://youtu.be/FDFGfYJPLOc?t=02h54m44s)

[going to use the path um](https://youtu.be/FDFGfYJPLOc?t=02h54m46s)

[yeah png will look very blurry on a 4k](https://youtu.be/FDFGfYJPLOc?t=02h54m51s)

[monitor if it's native resolution was](https://youtu.be/FDFGfYJPLOc?t=02h54m53s)

[for 1080p um](https://youtu.be/FDFGfYJPLOc?t=02h54m55s)

[it it kind of depends on the png and](https://youtu.be/FDFGfYJPLOc?t=02h54m58s)

[how big it was supposed to be in in the](https://youtu.be/FDFGfYJPLOc?t=02h55m03s)

[first place right like](https://youtu.be/FDFGfYJPLOc?t=02h55m05s)

[if you are so wpf or i should say inside](https://youtu.be/FDFGfYJPLOc?t=02h55m08s)

[of windows there will typically be dpi](https://youtu.be/FDFGfYJPLOc?t=02h55m11s)

[scaling because just because you go from](https://youtu.be/FDFGfYJPLOc?t=02h55m13s)

[a 1080p to a 4k monitor even though](https://youtu.be/FDFGfYJPLOc?t=02h55m15s)

[you've got four times as many pixels](https://youtu.be/FDFGfYJPLOc?t=02h55m18s)

[that doesn't mean things are at 25](https://youtu.be/FDFGfYJPLOc?t=02h55m20s)

[percent their original height the dpi](https://youtu.be/FDFGfYJPLOc?t=02h55m22s)

[scales it](https://youtu.be/FDFGfYJPLOc?t=02h55m25s)

[so you can cut so you depending on what](https://youtu.be/FDFGfYJPLOc?t=02h55m27s)

[it is](https://youtu.be/FDFGfYJPLOc?t=02h55m30s)

[if it's like a button icon](https://youtu.be/FDFGfYJPLOc?t=02h55m31s)

[it may be small enough that it really](https://youtu.be/FDFGfYJPLOc?t=02h55m33s)

[doesn't make a big difference](https://youtu.be/FDFGfYJPLOc?t=02h55m35s)

[like you can](https://youtu.be/FDFGfYJPLOc?t=02h55m37s)

[definitely test it go into windows and](https://youtu.be/FDFGfYJPLOc?t=02h55m38s)

[change your dpi settings up to like what](https://youtu.be/FDFGfYJPLOc?t=02h55m40s)

[is it 250 is where it the default stops](https://youtu.be/FDFGfYJPLOc?t=02h55m42s)

[before you have to do fun things](https://youtu.be/FDFGfYJPLOc?t=02h55m45s)

[and take a look at it and it may or may](https://youtu.be/FDFGfYJPLOc?t=02h55m47s)

[not matter](https://youtu.be/FDFGfYJPLOc?t=02h55m49s)

[right like if you don't need to go down](https://youtu.be/FDFGfYJPLOc?t=02h55m50s)

[to something like this](https://youtu.be/FDFGfYJPLOc?t=02h55m53s)

[it doesn't but if you have like a](https://youtu.be/FDFGfYJPLOc?t=02h55m54s)

[designer or similar](https://youtu.be/FDFGfYJPLOc?t=02h55m56s)

[that's putting together image assets for](https://youtu.be/FDFGfYJPLOc?t=02h55m58s)

[you quite often whatever tool they're](https://youtu.be/FDFGfYJPLOc?t=02h56m00s)

[using](https://youtu.be/FDFGfYJPLOc?t=02h56m02s)

[will give them the ability to do vector](https://youtu.be/FDFGfYJPLOc?t=02h56m04s)

[based art and so if they can give you](https://youtu.be/FDFGfYJPLOc?t=02h56m06s)

[vectors](https://youtu.be/FDFGfYJPLOc?t=02h56m09s)

[vector based art is preferable](https://youtu.be/FDFGfYJPLOc?t=02h56m10s)

[um the only other area where you won't](https://youtu.be/FDFGfYJPLOc?t=02h56m13s)

[be able to get away with vectors](https://youtu.be/FDFGfYJPLOc?t=02h56m15s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h56m18s)

[uh 3k monitors do not increase the](https://youtu.be/FDFGfYJPLOc?t=02h56m20s)

[elements well](https://youtu.be/FDFGfYJPLOc?t=02h56m21s)

[i could believe that though that's part](https://youtu.be/FDFGfYJPLOc?t=02h56m23s)

[of a windows-y thing](https://youtu.be/FDFGfYJPLOc?t=02h56m26s)

[too if they aren't scaling things well](https://youtu.be/FDFGfYJPLOc?t=02h56m28s)

[um the one area in wpf where you can't](https://youtu.be/FDFGfYJPLOc?t=02h56m30s)

[use vectors is your your ico file your](https://youtu.be/FDFGfYJPLOc?t=02h56m33s)

[icon for what's going to show up in like](https://youtu.be/FDFGfYJPLOc?t=02h56m36s)

[your taskbar](https://youtu.be/FDFGfYJPLOc?t=02h56m39s)

[or the little icon in the corner of your](https://youtu.be/FDFGfYJPLOc?t=02h56m40s)

[window](https://youtu.be/FDFGfYJPLOc?t=02h56m42s)

[or similar](https://youtu.be/FDFGfYJPLOc?t=02h56m44s)

[those things](https://youtu.be/FDFGfYJPLOc?t=02h56m45s)

[those things have to be a dot ico file](https://youtu.be/FDFGfYJPLOc?t=02h56m50s)

[and a dot ico file is basically just a](https://youtu.be/FDFGfYJPLOc?t=02h56m53s)

[bunch of bitmaps at different](https://youtu.be/FDFGfYJPLOc?t=02h56m57s)

[resolutions](https://youtu.be/FDFGfYJPLOc?t=02h56m58s)

[so](https://youtu.be/FDFGfYJPLOc?t=02h57m00s)

[for those ones you're still stuck doing](https://youtu.be/FDFGfYJPLOc?t=02h57m01s)

[an ico file](https://youtu.be/FDFGfYJPLOc?t=02h57m03s)

[sorry](https://youtu.be/FDFGfYJPLOc?t=02h57m05s)

[kind of sucks but](https://youtu.be/FDFGfYJPLOc?t=02h57m07s)

[there that's all that's supported for it](https://youtu.be/FDFGfYJPLOc?t=02h57m08s)

[you can't do vector-based ones for that](https://youtu.be/FDFGfYJPLOc?t=02h57m11s)

[now with that said shameless](https://youtu.be/FDFGfYJPLOc?t=02h57m14s)

[self-promotion](https://youtu.be/FDFGfYJPLOc?t=02h57m16s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h57m18s)

[so the material design library in the](https://youtu.be/FDFGfYJPLOc?t=02h57m20s)

[demo app](https://youtu.be/FDFGfYJPLOc?t=02h57m23s)

[so because only ico files are supported](https://youtu.be/FDFGfYJPLOc?t=02h57m28s)

[for like your windows icon](https://youtu.be/FDFGfYJPLOc?t=02h57m31s)

[um i got annoyed with that](https://youtu.be/FDFGfYJPLOc?t=02h57m34s)

[because the material design library we](https://youtu.be/FDFGfYJPLOc?t=02h57m38s)

[pull in this set of icons by default](https://youtu.be/FDFGfYJPLOc?t=02h57m40s)

[which is great](https://youtu.be/FDFGfYJPLOc?t=02h57m43s)

[um](https://youtu.be/FDFGfYJPLOc?t=02h57m44s)

[and where is it is it under domain hang](https://youtu.be/FDFGfYJPLOc?t=02h57m47s)

[on i will find it](https://youtu.be/FDFGfYJPLOc?t=02h57m52s)

[icon pack view model](https://youtu.be/FDFGfYJPLOc?t=02h57m56s)

[yes this is correct](https://youtu.be/FDFGfYJPLOc?t=02h58m00s)

[this is it now where is it copy to](https://youtu.be/FDFGfYJPLOc?t=02h58m03s)

[clipboard set defaults](https://youtu.be/FDFGfYJPLOc?t=02h58m05s)

[okay so inside the demo app um](https://youtu.be/FDFGfYJPLOc?t=02h58m09s)

[i wrote a little thing that will](https://youtu.be/FDFGfYJPLOc?t=02h58m12s)

[that will take](https://youtu.be/FDFGfYJPLOc?t=02h58m15s)

[the](https://youtu.be/FDFGfYJPLOc?t=02h58m16s)

[the material design icon which is a a](https://youtu.be/FDFGfYJPLOc?t=02h58m17s)

[vector-based thing and turn it into an](https://youtu.be/FDFGfYJPLOc?t=02h58m19s)

[ico file the thing that i ran into that](https://youtu.be/FDFGfYJPLOc?t=02h58m22s)

[i didn't like is there's a lot of](https://youtu.be/FDFGfYJPLOc?t=02h58m25s)

[programs you'll find online that will](https://youtu.be/FDFGfYJPLOc?t=02h58m27s)

[create you an ico file](https://youtu.be/FDFGfYJPLOc?t=02h58m29s)

[but](https://youtu.be/FDFGfYJPLOc?t=02h58m31s)

[the what they often do is they will you](https://youtu.be/FDFGfYJPLOc?t=02h58m32s)

[feed them the image and all they do is](https://youtu.be/FDFGfYJPLOc?t=02h58m34s)

[resize that image](https://youtu.be/FDFGfYJPLOc?t=02h58m37s)

[to each of the ico dimensions](https://youtu.be/FDFGfYJPLOc?t=02h58m39s)

[and do that the problem is is if the if](https://youtu.be/FDFGfYJPLOc?t=02h58m42s)

[you have a vector based thing you should](https://youtu.be/FDFGfYJPLOc?t=02h58m44s)

[really resize the vector convert to](https://youtu.be/FDFGfYJPLOc?t=02h58m46s)

[bitmap and use each of those and most of](https://youtu.be/FDFGfYJPLOc?t=02h58m49s)

[them weren't they were taking the the](https://youtu.be/FDFGfYJPLOc?t=02h58m51s)

[the image rasterizing it once and then](https://youtu.be/FDFGfYJPLOc?t=02h58m53s)

[resizing the rasterize image i'm like](https://youtu.be/FDFGfYJPLOc?t=02h58m56s)

[what the](https://youtu.be/FDFGfYJPLOc?t=02h58m58s)

[no](https://youtu.be/FDFGfYJPLOc?t=02h58m59s)

[that's dumb](https://youtu.be/FDFGfYJPLOc?t=02h59m01s)

[um so we don't do that um](https://youtu.be/FDFGfYJPLOc?t=02h59m02s)

[i wrote up a little thing it's it this](https://youtu.be/FDFGfYJPLOc?t=02h59m05s)

[is all in the demo app so this isn't](https://youtu.be/FDFGfYJPLOc?t=02h59m07s)

[something that necessarily ships with](https://youtu.be/FDFGfYJPLOc?t=02h59m09s)

[the library you have to just run the](https://youtu.be/FDFGfYJPLOc?t=02h59m10s)

[demo app to see this but you're welcome](https://youtu.be/FDFGfYJPLOc?t=02h59m11s)

[to poach the code or whatnot](https://youtu.be/FDFGfYJPLOc?t=02h59m14s)

[but all it does is it takes whatever](https://youtu.be/FDFGfYJPLOc?t=02h59m16s)

[icon you select runs through a list of](https://youtu.be/FDFGfYJPLOc?t=02h59m18s)

[sizes](https://youtu.be/FDFGfYJPLOc?t=02h59m20s)

[uh converts it rasterizes it to a bitmap](https://youtu.be/FDFGfYJPLOc?t=02h59m21s)

[again it'll take the vector image go to](https://youtu.be/FDFGfYJPLOc?t=02h59m25s)

[a bitmap at the appropriate resolution](https://youtu.be/FDFGfYJPLOc?t=02h59m28s)

[add it into the list of images for the](https://youtu.be/FDFGfYJPLOc?t=02h59m31s)

[icon file and save the icon file](https://youtu.be/FDFGfYJPLOc?t=02h59m33s)

[that's it](https://youtu.be/FDFGfYJPLOc?t=02h59m36s)

[it's not it's not overly fancy](https://youtu.be/FDFGfYJPLOc?t=02h59m38s)

[but it works](https://youtu.be/FDFGfYJPLOc?t=02h59m41s)

[and so if you want to use one of the](https://youtu.be/FDFGfYJPLOc?t=02h59m43s)

[material design icons and all you care](https://youtu.be/FDFGfYJPLOc?t=02h59m44s)

[about is having a foreground and a](https://youtu.be/FDFGfYJPLOc?t=02h59m47s)

[background like you may want to do](https://youtu.be/FDFGfYJPLOc?t=02h59m49s)

[something a little more interesting](https://youtu.be/FDFGfYJPLOc?t=02h59m51s)

[right like this is this is very much](https://youtu.be/FDFGfYJPLOc?t=02h59m54s)

[fixed for](https://youtu.be/FDFGfYJPLOc?t=02h59m57s)

[doing one](https://youtu.be/FDFGfYJPLOc?t=02h59m58s)

[one thing with the colors and maybe you](https://youtu.be/FDFGfYJPLOc?t=03h00m00s)

[want something more advanced](https://youtu.be/FDFGfYJPLOc?t=03h00m02s)

[poach this code and do whatever you want](https://youtu.be/FDFGfYJPLOc?t=03h00m04s)

[to it it'll be fun](https://youtu.be/FDFGfYJPLOc?t=03h00m05s)

[so](https://youtu.be/FDFGfYJPLOc?t=03h00m07s)

[for what it's worth that's where all of](https://youtu.be/FDFGfYJPLOc?t=03h00m08s)

[this stuff](https://youtu.be/FDFGfYJPLOc?t=03h00m10s)

[is at](https://youtu.be/FDFGfYJPLOc?t=03h00m11s)

[and where all of this is going i'm](https://youtu.be/FDFGfYJPLOc?t=03h00m12s)

[actually surprised i thought this thing](https://youtu.be/FDFGfYJPLOc?t=03h00m14s)

[had](https://youtu.be/FDFGfYJPLOc?t=03h00m16s)

[color selection but it looks like it's](https://youtu.be/FDFGfYJPLOc?t=03h00m18s)

[been hard-coded](https://youtu.be/FDFGfYJPLOc?t=03h00m20s)

[that may be a mistake](https://youtu.be/FDFGfYJPLOc?t=03h00m21s)

[because](https://youtu.be/FDFGfYJPLOc?t=03h00m25s)

[there's](https://youtu.be/FDFGfYJPLOc?t=03h00m26s)

[this](https://youtu.be/FDFGfYJPLOc?t=03h00m27s)

[yeah i'm a little surprised that](https://youtu.be/FDFGfYJPLOc?t=03h00m38s)

[these values are being hard-coded](https://youtu.be/FDFGfYJPLOc?t=03h00m41s)

[because i i would have expected it to](https://youtu.be/FDFGfYJPLOc?t=03h00m45s)

[use](https://youtu.be/FDFGfYJPLOc?t=03h00m47s)

[these color properties i might have to](https://youtu.be/FDFGfYJPLOc?t=03h00m47s)

[double check that but](https://youtu.be/FDFGfYJPLOc?t=03h00m50s)

[so for what it's worth if you go through](https://youtu.be/FDFGfYJPLOc?t=03h00m52s)

[and do it](https://youtu.be/FDFGfYJPLOc?t=03h00m54s)

[that will](https://youtu.be/FDFGfYJPLOc?t=03h00m55s)

[that is one this is one's example here](https://youtu.be/FDFGfYJPLOc?t=03h00m57s)

[i'll i'll even drop the coded](https://youtu.be/FDFGfYJPLOc?t=03h00m59s)

[this is one sample of if you've got a](https://youtu.be/FDFGfYJPLOc?t=03h01m01s)

[vector-based image how you can get it](https://youtu.be/FDFGfYJPLOc?t=03h01m03s)

[down to an ico file](https://youtu.be/FDFGfYJPLOc?t=03h01m05s)

[it is leveraging a nuget package that is](https://youtu.be/FDFGfYJPLOc?t=03h01m07s)

[uh](https://youtu.be/FDFGfYJPLOc?t=03h01m09s)

[this blue wolf icons it just happened to](https://youtu.be/FDFGfYJPLOc?t=03h01m10s)

[be there's a bunch of nuget packages](https://youtu.be/FDFGfYJPLOc?t=03h01m12s)

[that'll do](https://youtu.be/FDFGfYJPLOc?t=03h01m14s)

[ico generation and actually the file](https://youtu.be/FDFGfYJPLOc?t=03h01m16s)

[spec you can find on wikipedia it's not](https://youtu.be/FDFGfYJPLOc?t=03h01m18s)

[that complicated it's it's really not it](https://youtu.be/FDFGfYJPLOc?t=03h01m21s)

[is literally](https://youtu.be/FDFGfYJPLOc?t=03h01m23s)

[bitmap bitmap bitmap bitmap bitmap](https://youtu.be/FDFGfYJPLOc?t=03h01m25s)

[done](https://youtu.be/FDFGfYJPLOc?t=03h01m28s)

[so](https://youtu.be/FDFGfYJPLOc?t=03h01m30s)

[it gets a little complicated around](https://youtu.be/FDFGfYJPLOc?t=03h01m31s)

[different areas because you have](https://youtu.be/FDFGfYJPLOc?t=03h01m33s)

[newer formats after windows 7 that](https://youtu.be/FDFGfYJPLOc?t=03h01m35s)

[support alpha transparency and prior](https://youtu.be/FDFGfYJPLOc?t=03h01m39s)

[versions didn't and so there's](https://youtu.be/FDFGfYJPLOc?t=03h01m41s)

[slight updates to the file format and](https://youtu.be/FDFGfYJPLOc?t=03h01m43s)

[that kind of thing but it's not overly](https://youtu.be/FDFGfYJPLOc?t=03h01m45s)

[complicated if you want to roll it](https://youtu.be/FDFGfYJPLOc?t=03h01m47s)

[yourself](https://youtu.be/FDFGfYJPLOc?t=03h01m48s)

[but i just found a nuget package that](https://youtu.be/FDFGfYJPLOc?t=03h01m49s)

[that did a good job of it and had a](https://youtu.be/FDFGfYJPLOc?t=03h01m51s)

[reasonable api and went good now](https://youtu.be/FDFGfYJPLOc?t=03h01m52s)

[syntax model](https://youtu.be/FDFGfYJPLOc?t=03h02m00s)

[type of expressions something something](https://youtu.be/FDFGfYJPLOc?t=03h02m02s)

[something um okay so type of this gets](https://youtu.be/FDFGfYJPLOc?t=03h02m04s)

[me back here](https://youtu.be/FDFGfYJPLOc?t=03h02m07s)

[uh this is no longer constructor test](https://youtu.be/FDFGfYJPLOc?t=03h02m09s)

[attribute this is target](https://youtu.be/FDFGfYJPLOc?t=03h02m11s)

[type](https://youtu.be/FDFGfYJPLOc?t=03h02m15s)

[we're going to go here](https://youtu.be/FDFGfYJPLOc?t=03h02m16s)

[um](https://youtu.be/FDFGfYJPLOc?t=03h02m19s)

[this is going to be](https://youtu.be/FDFGfYJPLOc?t=03h02m21s)

[because that's already the dot type on](https://youtu.be/FDFGfYJPLOc?t=03h02m23s)

[the end of it we're going to get it here](https://youtu.be/FDFGfYJPLOc?t=03h02m26s)

[and this is going to be](https://youtu.be/FDFGfYJPLOc?t=03h02m30s)

[this is a type info of the](https://youtu.be/FDFGfYJPLOc?t=03h02m32s)

[uh set type](https://youtu.be/FDFGfYJPLOc?t=03h02m35s)

[um](https://youtu.be/FDFGfYJPLOc?t=03h02m40s)

[and actually we should probably move](https://youtu.be/FDFGfYJPLOc?t=03h02m48s)

[this into](https://youtu.be/FDFGfYJPLOc?t=03h02m50s)

[i'm gonna subtly pull this guy out](https://youtu.be/FDFGfYJPLOc?t=03h02m54s)

[no problem um](https://youtu.be/FDFGfYJPLOc?t=03h03m00s)

[i i i quite often on these streams we'll](https://youtu.be/FDFGfYJPLOc?t=03h03m03s)

[we'll rabbit trail on different things](https://youtu.be/FDFGfYJPLOc?t=03h03m06s)

[so if if you have questions always feel](https://youtu.be/FDFGfYJPLOc?t=03h03m07s)

[free to](https://youtu.be/FDFGfYJPLOc?t=03h03m10s)

[ask always happy to answer](https://youtu.be/FDFGfYJPLOc?t=03h03m10s)

[uh get type info](https://youtu.be/FDFGfYJPLOc?t=03h03m14s)

[uh](https://youtu.be/FDFGfYJPLOc?t=03h03m17s)

[type](https://youtu.be/FDFGfYJPLOc?t=03h03m19s)

[right that's what we're going for i](https://youtu.be/FDFGfYJPLOc?t=03h03m20s)

[type symbol](https://youtu.be/FDFGfYJPLOc?t=03h03m23s)

[is your problem](https://youtu.be/FDFGfYJPLOc?t=03h03m26s)

[possible no reference assignment](https://youtu.be/FDFGfYJPLOc?t=03h03m28s)

[uh](https://youtu.be/FDFGfYJPLOc?t=03h03m31s)

[yeah that is a possible no reference](https://youtu.be/FDFGfYJPLOc?t=03h03m32s)

[assignment](https://youtu.be/FDFGfYJPLOc?t=03h03m34s)

[and get target type is](https://youtu.be/FDFGfYJPLOc?t=03h03m37s)

[target type](https://youtu.be/FDFGfYJPLOc?t=03h03m43s)

[and](https://youtu.be/FDFGfYJPLOc?t=03h03m47s)

[so i think i want to be inside i guess](https://youtu.be/FDFGfYJPLOc?t=03h03m53s)

[it's not going to make a difference](https://youtu.be/FDFGfYJPLOc?t=03h03m56s)

[either way will it](https://youtu.be/FDFGfYJPLOc?t=03h03m57s)

[um](https://youtu.be/FDFGfYJPLOc?t=03h03m58s)

[we will do this](https://youtu.be/FDFGfYJPLOc?t=03h04m00s)

[this](https://youtu.be/FDFGfYJPLOc?t=03h04m02s)

[and](https://youtu.be/FDFGfYJPLOc?t=03h04m03s)

[target type](https://youtu.be/FDFGfYJPLOc?t=03h04m07s)

[target type](https://youtu.be/FDFGfYJPLOc?t=03h04m09s)

[uh](https://youtu.be/FDFGfYJPLOc?t=03h04m21s)

[okay](https://youtu.be/FDFGfYJPLOc?t=03h04m29s)

[uh let's see boom](https://youtu.be/FDFGfYJPLOc?t=03h04m34s)

[but we don't need that anymore that now](https://youtu.be/FDFGfYJPLOc?t=03h04m42s)

[exists](https://youtu.be/FDFGfYJPLOc?t=03h04m44s)

[okay and we know we've gotten a non-null](https://youtu.be/FDFGfYJPLOc?t=03h04m46s)

[instance by the time we get down here so](https://youtu.be/FDFGfYJPLOc?t=03h04m48s)

[this is going to be](https://youtu.be/FDFGfYJPLOc?t=03h04m50s)

[subtype](https://youtu.be/FDFGfYJPLOc?t=03h04m52s)

[to display string](https://youtu.be/FDFGfYJPLOc?t=03h04m54s)

[let's see symbol](https://youtu.be/FDFGfYJPLOc?t=03h04m57s)

[display format and then we want](https://youtu.be/FDFGfYJPLOc?t=03h05m00s)

[not fully qualified we want minimally](https://youtu.be/FDFGfYJPLOc?t=03h05m03s)

[qualified](https://youtu.be/FDFGfYJPLOc?t=03h05m05s)

[and then this one here is going to be](https://youtu.be/FDFGfYJPLOc?t=03h05m08s)

[the](https://youtu.be/FDFGfYJPLOc?t=03h05m11s)

[big one](https://youtu.be/FDFGfYJPLOc?t=03h05m12s)

[i'm kind of wondering if maybe i should](https://youtu.be/FDFGfYJPLOc?t=03h05m16s)

[just attach the symbol to this thing and](https://youtu.be/FDFGfYJPLOc?t=03h05m17s)

[move on](https://youtu.be/FDFGfYJPLOc?t=03h05m19s)

[yeah](https://youtu.be/FDFGfYJPLOc?t=03h05m21s)

[yeah we'll keep them separate](https://youtu.be/FDFGfYJPLOc?t=03h05m22s)

[okay so that gets us that](https://youtu.be/FDFGfYJPLOc?t=03h05m24s)

[and now](https://youtu.be/FDFGfYJPLOc?t=03h05m27s)

[given this type we just want to rip](https://youtu.be/FDFGfYJPLOc?t=03h05m28s)

[through his constructors](https://youtu.be/FDFGfYJPLOc?t=03h05m30s)

[to give us the last bit because this is](https://youtu.be/FDFGfYJPLOc?t=03h05m32s)

[currently hard coded](https://youtu.be/FDFGfYJPLOc?t=03h05m35s)

[and we don't want to do that so](https://youtu.be/FDFGfYJPLOc?t=03h05m37s)

[for each](https://youtu.be/FDFGfYJPLOc?t=03h05m39s)

[varsity or in](https://youtu.be/FDFGfYJPLOc?t=03h05m41s)

[set type](https://youtu.be/FDFGfYJPLOc?t=03h05m45s)

[team type](https://youtu.be/FDFGfYJPLOc?t=03h05m50s)

[structures](https://youtu.be/FDFGfYJPLOc?t=03h05m56s)

[surprise this thing doesn't have uh](https://youtu.be/FDFGfYJPLOc?t=03h06m03s)

[is it because it's an eye type symbol](https://youtu.be/FDFGfYJPLOc?t=03h06m11s)

[and not an i name type symbol is that](https://youtu.be/FDFGfYJPLOc?t=03h06m13s)

[the issue](https://youtu.be/FDFGfYJPLOc?t=03h06m15s)

[yeah](https://youtu.be/FDFGfYJPLOc?t=03h06m17s)

[let's go](https://youtu.be/FDFGfYJPLOc?t=03h06m21s)

[here](https://youtu.be/FDFGfYJPLOc?t=03h06m22s)

[just make sure we get that](https://youtu.be/FDFGfYJPLOc?t=03h06m24s)

[this can now be](https://youtu.be/FDFGfYJPLOc?t=03h06m38s)

[just](https://youtu.be/FDFGfYJPLOc?t=03h06m40s)

[that okay](https://youtu.be/FDFGfYJPLOc?t=03h06m40s)

[so this guy here explicit type](https://youtu.be/FDFGfYJPLOc?t=03h06m42s)

[okay so for each constructor we are just](https://youtu.be/FDFGfYJPLOc?t=03h06m46s)

[going to run through this guy i need to](https://youtu.be/FDFGfYJPLOc?t=03h06m49s)

[get his parameters](https://youtu.be/FDFGfYJPLOc?t=03h06m52s)

[um](https://youtu.be/FDFGfYJPLOc?t=03h06m55s)

[for each of our](https://youtu.be/FDFGfYJPLOc?t=03h06m58s)

[parameter and](https://youtu.be/FDFGfYJPLOc?t=03h07m02s)

[see their parameters](https://youtu.be/FDFGfYJPLOc?t=03h07m05s)

[okay that good nope nope not what i](https://youtu.be/FDFGfYJPLOc?t=03h07m10s)

[wanted you to do explicit type please](https://youtu.be/FDFGfYJPLOc?t=03h07m12s)

[gracias](https://youtu.be/FDFGfYJPLOc?t=03h07m15s)

[okay so i need to create up](https://youtu.be/FDFGfYJPLOc?t=03h07m16s)

[one of these guys](https://youtu.be/FDFGfYJPLOc?t=03h07m20s)

[okay](https://youtu.be/FDFGfYJPLOc?t=03h07m23s)

[so this guy here is going to be the](https://youtu.be/FDFGfYJPLOc?t=03h07m24s)

[parameter short name so it's going to be](https://youtu.be/FDFGfYJPLOc?t=03h07m29s)

[parameter 2 display string](https://youtu.be/FDFGfYJPLOc?t=03h07m32s)

[uh let's see](https://youtu.be/FDFGfYJPLOc?t=03h07m38s)

[simple](https://youtu.be/FDFGfYJPLOc?t=03h07m40s)

[display format](https://youtu.be/FDFGfYJPLOc?t=03h07m41s)

[minimally qualified](https://youtu.be/FDFGfYJPLOc?t=03h07m43s)

[this is going to be the big one](https://youtu.be/FDFGfYJPLOc?t=03h07m46s)

[parameter to display string](https://youtu.be/FDFGfYJPLOc?t=03h07m50s)

[symbol display format](https://youtu.be/FDFGfYJPLOc?t=03h07m53s)

[fully qualified](https://youtu.be/FDFGfYJPLOc?t=03h07m56s)

[and this is just the name](https://youtu.be/FDFGfYJPLOc?t=03h07m59s)

[parameter dot](https://youtu.be/FDFGfYJPLOc?t=03h08m01s)

[name boom okay](https://youtu.be/FDFGfYJPLOc?t=03h08m04s)

[and then this guy just needs to be added](https://youtu.be/FDFGfYJPLOc?t=03h08m07s)

[into sat](https://youtu.be/FDFGfYJPLOc?t=03h08m09s)

[no](https://youtu.be/FDFGfYJPLOc?t=03h08m11s)

[add](https://youtu.be/FDFGfYJPLOc?t=03h08m15s)

[boom](https://youtu.be/FDFGfYJPLOc?t=03h08m18s)

[boom](https://youtu.be/FDFGfYJPLOc?t=03h08m19s)

[okay so that](https://youtu.be/FDFGfYJPLOc?t=03h08m20s)

[should work](https://youtu.be/FDFGfYJPLOc?t=03h08m24s)

[we'll see](https://youtu.be/FDFGfYJPLOc?t=03h08m27s)

[we'll see we still have the issue of](https://youtu.be/FDFGfYJPLOc?t=03h08m28s)

[collisions](https://youtu.be/FDFGfYJPLOc?t=03h08m30s)

