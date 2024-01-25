[YouTube Video](https://youtu.be/upMpPtQuc0c)



[hello everyone welcome back uh last week](https://youtu.be/upMpPtQuc0c?t=00h00m01s)

[we dived into Mock and auto mocker so if](https://youtu.be/upMpPtQuc0c?t=00h00m04s)

[you haven't seen that I'm sure there's](https://youtu.be/upMpPtQuc0c?t=00h00m07s)

[links somewhere to last week's stream](https://youtu.be/upMpPtQuc0c?t=00h00m08s)

[floating around on the YouTubes and the](https://youtu.be/upMpPtQuc0c?t=00h00m10s)

[Twitches uh tonight uh going to dive](https://youtu.be/upMpPtQuc0c?t=00h00m12s)

[back into the auto marker Library last](https://youtu.be/upMpPtQuc0c?t=00h00m15s)

[week I kind of teased some of the source](https://youtu.be/upMpPtQuc0c?t=00h00m18s)

[generator stuff uh that's coming and](https://youtu.be/upMpPtQuc0c?t=00h00m20s)

[that it already has specifically The](https://youtu.be/upMpPtQuc0c?t=00h00m22s)

[Source generator that builds out unit](https://youtu.be/upMpPtQuc0c?t=00h00m24s)

[test for you for the argument nolles on](https://youtu.be/upMpPtQuc0c?t=00h00m26s)

[your Constructors so if you haven't seen](https://youtu.be/upMpPtQuc0c?t=00h00m28s)

[that go check out the past video it's](https://youtu.be/upMpPtQuc0c?t=00h00m30s)

[pretty cool uh Andrew welcome uh tonight](https://youtu.be/upMpPtQuc0c?t=00h00m32s)

[we're I am I am going to be joined by](https://youtu.be/upMpPtQuc0c?t=00h00m36s)

[one of my my mods uh a colleague and](https://youtu.be/upMpPtQuc0c?t=00h00m38s)

[friend Benjamin who unfortunately uh](https://youtu.be/upMpPtQuc0c?t=00h00m42s)

[found I won't say a bug as much as uh an](https://youtu.be/upMpPtQuc0c?t=00h00m46s)

[unimplemented feature and](https://youtu.be/upMpPtQuc0c?t=00h00m49s)

[so I uh I conned him into starting work](https://youtu.be/upMpPtQuc0c?t=00h00m52s)

[on doing it and then I conned him into](https://youtu.be/upMpPtQuc0c?t=00h00m55s)

[joining me on the stream tonight to keep](https://youtu.be/upMpPtQuc0c?t=00h00m58s)

[going on it because I kind of feel like](https://youtu.be/upMpPtQuc0c?t=00h00m59s)

[this will be a good example of kind of](https://youtu.be/upMpPtQuc0c?t=00h01m01s)

[source generators how to use them maybe](https://youtu.be/upMpPtQuc0c?t=00h01m04s)

[not necessarily a start from scratch but](https://youtu.be/upMpPtQuc0c?t=00h01m06s)

[we're gonna we're going to at least work](https://youtu.be/upMpPtQuc0c?t=00h01m08s)

[on them and figure out how to make them](https://youtu.be/upMpPtQuc0c?t=00h01m10s)

[work so welcome everyone](https://youtu.be/upMpPtQuc0c?t=00h01m12s)

[Benjamin](https://youtu.be/upMpPtQuc0c?t=00h01m15s)

[hi hello hello anything fancy you want](https://youtu.be/upMpPtQuc0c?t=00h01m17s)

[to say no okay cool we made it from the](https://youtu.be/upMpPtQuc0c?t=00h01m21s)

[stream well yeah I mean you're normally](https://youtu.be/upMpPtQuc0c?t=00h01m27s)

[the one floating in the background on](https://youtu.be/upMpPtQuc0c?t=00h01m29s)

[the chat for everybody so this will be](https://youtu.be/upMpPtQuc0c?t=00h01m30s)

[good uh quick note for anybody on the](https://youtu.be/upMpPtQuc0c?t=00h01m33s)

[material design in zaml I did spin a 51](https://youtu.be/upMpPtQuc0c?t=00h01m35s)

[Milestone I started kicking things out](https://youtu.be/upMpPtQuc0c?t=00h01m38s)

[my intent is to migrate a couple of my](https://youtu.be/upMpPtQuc0c?t=00h01m41s)

[own projects to the the 5 preview nougat](https://youtu.be/upMpPtQuc0c?t=00h01m44s)

[packages test it and ship it so I I've](https://youtu.be/upMpPtQuc0c?t=00h01m47s)

[done now one project and it went fairly](https://youtu.be/upMpPtQuc0c?t=00h01m52s)

[smoothly so yeah we'll do I'm going to](https://youtu.be/upMpPtQuc0c?t=00h01m54s)

[do a couple more just to make sure I'm](https://youtu.be/upMpPtQuc0c?t=00h01m57s)

[not missing anything too obvious because](https://youtu.be/upMpPtQuc0c?t=00h01m59s)

[I'm sure I'm going to anger some people](https://youtu.be/upMpPtQuc0c?t=00h02m01s)

[so](https://youtu.be/upMpPtQuc0c?t=00h02m03s)

[Benjamin I'm going to let well actually](https://youtu.be/upMpPtQuc0c?t=00h02m05s)

[before we start so I've pulled his](https://youtu.be/upMpPtQuc0c?t=00h02m07s)

[Branch so for those people who want to](https://youtu.be/upMpPtQuc0c?t=00h02m09s)

[follow along at home uh let's see copy](https://youtu.be/upMpPtQuc0c?t=00h02m11s)

[link to](https://youtu.be/upMpPtQuc0c?t=00h02m14s)

[branch](https://youtu.be/upMpPtQuc0c?t=00h02m16s)

[and people will note that is a get](https://youtu.be/upMpPtQuc0c?t=00h02m17s)

[Kraken link so if you click it uh it's](https://youtu.be/upMpPtQuc0c?t=00h02m20s)

[going to prompt you for get Kraken but](https://youtu.be/upMpPtQuc0c?t=00h02m22s)

[you have get Kraken It'll like point you](https://youtu.be/upMpPtQuc0c?t=00h02m26s)

[to the repo and bring you to the branch](https://youtu.be/upMpPtQuc0c?t=00h02m29s)

[and all the cool stuff which I think is](https://youtu.be/upMpPtQuc0c?t=00h02m31s)

[pretty awesome](https://youtu.be/upMpPtQuc0c?t=00h02m34s)

[um okay there's that there's that feel](https://youtu.be/upMpPtQuc0c?t=00h02m38s)

[like there was something else I was](https://youtu.be/upMpPtQuc0c?t=00h02m41s)

[going to say oh yeah so I pulled your](https://youtu.be/upMpPtQuc0c?t=00h02m42s)

[branch and then I immediately tried to](https://youtu.be/upMpPtQuc0c?t=00h02m44s)

[build it and then was very unhappy that](https://youtu.be/upMpPtQuc0c?t=00h02m46s)

[it doesn't build because why did you](https://youtu.be/upMpPtQuc0c?t=00h02m48s)

[send me something that doesn't](https://youtu.be/upMpPtQuc0c?t=00h02m50s)

[work but secretly who it works on my](https://youtu.be/upMpPtQuc0c?t=00h02m52s)

[machine well said every developer at](https://youtu.be/upMpPtQuc0c?t=00h02m55s)

[least once in their lives so this is](https://youtu.be/upMpPtQuc0c?t=00h02m58s)

[actually a good one a good one to call](https://youtu.be/upMpPtQuc0c?t=00h03m00s)

[out because this is a problem that is](https://youtu.be/upMpPtQuc0c?t=00h03m02s)

[self-inflicted to me that I think some](https://youtu.be/upMpPtQuc0c?t=00h03m04s)

[people may potentially run into it's not](https://youtu.be/upMpPtQuc0c?t=00h03m06s)

[it's not overly likely but uh so the](https://youtu.be/upMpPtQuc0c?t=00h03m09s)

[auto marker library is using centralized](https://youtu.be/upMpPtQuc0c?t=00h03m12s)

[package management meaning all of our](https://youtu.be/upMpPtQuc0c?t=00h03m16s)

[versions for our packages live here uh](https://youtu.be/upMpPtQuc0c?t=00h03m17s)

[one of the wonderful things about this](https://youtu.be/upMpPtQuc0c?t=00h03m20s)

[feature is it insists that you do](https://youtu.be/upMpPtQuc0c?t=00h03m22s)

[package Source mapping and if I go here](https://youtu.be/upMpPtQuc0c?t=00h03m25s)

[and do manage new](https://youtu.be/upMpPtQuc0c?t=00h03m28s)

[packages we'll quickly see the](https://youtu.be/upMpPtQuc0c?t=00h03m30s)

[problem I hit the little gear here](https://youtu.be/upMpPtQuc0c?t=00h03m33s)

[you'll note I immediately have all these](https://youtu.be/upMpPtQuc0c?t=00h03m35s)

[sources and most people probably don't](https://youtu.be/upMpPtQuc0c?t=00h03m38s)

[have these they probably have n.org is I](https://youtu.be/upMpPtQuc0c?t=00h03m41s)

[think the the default one and the](https://youtu.be/upMpPtQuc0c?t=00h03m44s)

[problem being is centralized package](https://youtu.be/upMpPtQuc0c?t=00h03m46s)

[management wants you to actually do um](https://youtu.be/upMpPtQuc0c?t=00h03m48s)

[package mapping so that it knows where](https://youtu.be/upMpPtQuc0c?t=00h03m53s)

[to resolve these things from I.E add a n](https://youtu.be/upMpPtQuc0c?t=00h03m56s)

[get config and I have done that problem](https://youtu.be/upMpPtQuc0c?t=00h03m59s)

[is is I added a new get](https://youtu.be/upMpPtQuc0c?t=00h04m03s)

[config here on this other branch on this](https://youtu.be/upMpPtQuc0c?t=00h04m05s)

[PR that unfortunately Adam just got back](https://youtu.be/upMpPtQuc0c?t=00h04m09s)

[recently and hasn't merged yet so that's](https://youtu.be/upMpPtQuc0c?t=00h04m12s)

[disappointing so real quick we're going](https://youtu.be/upMpPtQuc0c?t=00h04m15s)

[to just come over here and I'm going to](https://youtu.be/upMpPtQuc0c?t=00h04m17s)

[just go snipe that file real quick so](https://youtu.be/upMpPtQuc0c?t=00h04m19s)

[magical keyboard](https://youtu.be/upMpPtQuc0c?t=00h04m23s)

[shortcut uh alt o opens up the](https://youtu.be/upMpPtQuc0c?t=00h04m25s)

[Repository](https://youtu.be/upMpPtQuc0c?t=00h04m28s)

[in uh Windows Explorer you can also do](https://youtu.be/upMpPtQuc0c?t=00h04m30s)

[file open and file manager but I just do](https://youtu.be/upMpPtQuc0c?t=00h04m33s)

[that and then I go back](https://youtu.be/upMpPtQuc0c?t=00h04m37s)

[here and then I go here and I go](https://youtu.be/upMpPtQuc0c?t=00h04m39s)

[paste oh turns out if you switch](https://youtu.be/upMpPtQuc0c?t=00h04m43s)

[branches don't you want to do some](https://youtu.be/upMpPtQuc0c?t=00h04m47s)

[cherry pick cherry pick showing off the](https://youtu.be/upMpPtQuc0c?t=00h04m48s)

[G Kraken cherry pick no commit oh that's](https://youtu.be/upMpPtQuc0c?t=00h04m51s)

[fine okay yeah good point okay we'll](https://youtu.be/upMpPtQuc0c?t=00h04m53s)

[cherry pick this side cherry pick you](https://youtu.be/upMpPtQuc0c?t=00h04m55s)

[want to immediately complate the changes](https://youtu.be/upMpPtQuc0c?t=00h04m57s)

[no merge conflicts Mark is resolved](https://youtu.be/upMpPtQuc0c?t=00h04m59s)

[because I really could care less uh yeah](https://youtu.be/upMpPtQuc0c?t=00h05m02s)

[delete this file I don't care so unstage](https://youtu.be/upMpPtQuc0c?t=00h05m06s)

[stage](https://youtu.be/upMpPtQuc0c?t=00h05m11s)

[uh uh let's see new git that would be a](https://youtu.be/upMpPtQuc0c?t=00h05m14s)

[cool get Kracken feature though reach](https://youtu.be/upMpPtQuc0c?t=00h05m16s)

[into a branch and grab a file without](https://youtu.be/upMpPtQuc0c?t=00h05m18s)

[checking it out it it would be it would](https://youtu.be/upMpPtQuc0c?t=00h05m20s)

[be cool if it would let you right click](https://youtu.be/upMpPtQuc0c?t=00h05m22s)

[on a file and cherry pick file now I](https://youtu.be/upMpPtQuc0c?t=00h05m23s)

[realize that like there's a lot of ways](https://youtu.be/upMpPtQuc0c?t=00h05m27s)

[that goes wrong real](https://youtu.be/upMpPtQuc0c?t=00h05m30s)

[quick um okay next next question am I](https://youtu.be/upMpPtQuc0c?t=00h05m32s)

[GNA have Push](https://youtu.be/upMpPtQuc0c?t=00h05m35s)

[permissions to not to my bu well not to](https://youtu.be/upMpPtQuc0c?t=00h05m39s)

[your remote but you know what you can](https://youtu.be/upMpPtQuc0c?t=00h05m42s)

[well no there's a cheap way to do this](https://youtu.be/upMpPtQuc0c?t=00h05m45s)

[open a PR real](https://youtu.be/upMpPtQuc0c?t=00h05m47s)

[quick okay open a PR and leave the Box](https://youtu.be/upMpPtQuc0c?t=00h05m49s)

[check to allow uh contributors to push](https://youtu.be/upMpPtQuc0c?t=00h05m52s)

[back to your](https://youtu.be/upMpPtQuc0c?t=00h05m54s)

[fork oh actually hang on before you do](https://youtu.be/upMpPtQuc0c?t=00h05m56s)

[that](https://youtu.be/upMpPtQuc0c?t=00h05m59s)

[I'm](https://youtu.be/upMpPtQuc0c?t=00h06m01s)

[curious can I do](https://youtu.be/upMpPtQuc0c?t=00h06m02s)

[it uh start pull](https://youtu.be/upMpPtQuc0c?t=00h06m07s)

[request origin yeah so hang on I'm GNA](https://youtu.be/upMpPtQuc0c?t=00h06m09s)

[see if I can do this continue editing on](https://youtu.be/upMpPtQuc0c?t=00h06m13s)

[GitHub see I I don't think I don't think](https://youtu.be/upMpPtQuc0c?t=00h06m16s)

[it'll that would seem weird because then](https://youtu.be/upMpPtQuc0c?t=00h06m19s)

[you can't the check box yeah okay it](https://youtu.be/upMpPtQuc0c?t=00h06m21s)

[doesn't give me the check boox I was](https://youtu.be/upMpPtQuc0c?t=00h06m24s)

[going to say that'd be that'd be a heck](https://youtu.be/upMpPtQuc0c?t=00h06m25s)

[of a heck of a thing so apparently you](https://youtu.be/upMpPtQuc0c?t=00h06m27s)

[have to actually make it](https://youtu.be/upMpPtQuc0c?t=00h06m29s)

[if let me know when that PR opens or](https://youtu.be/upMpPtQuc0c?t=00h06m32s)

[actually I'll probably see it in my of a](https://youtu.be/upMpPtQuc0c?t=00h06m35s)

[little get cracken right above your head](https://youtu.be/upMpPtQuc0c?t=00h06m37s)

[done and my pull request section a](https://youtu.be/upMpPtQuc0c?t=00h06m42s)

[little bigger collapse](https://youtu.be/upMpPtQuc0c?t=00h06m45s)

[collapse uh I want a refresh button](https://youtu.be/upMpPtQuc0c?t=00h06m49s)

[where's my I refresh just Fetch and it I](https://youtu.be/upMpPtQuc0c?t=00h06m53s)

[think when you do a fetch it'll refresh](https://youtu.be/upMpPtQuc0c?t=00h06m57s)

[is automatic l oh is that it I think](https://youtu.be/upMpPtQuc0c?t=00h06m59s)

[don't quote me on that but I think](https://youtu.be/upMpPtQuc0c?t=00h07m02s)

[B oh look at that look at boom boom boom](https://youtu.be/upMpPtQuc0c?t=00h07m05s)

[okay and then](https://youtu.be/upMpPtQuc0c?t=00h07m08s)

[push oh that's so dirty I I love that I](https://youtu.be/upMpPtQuc0c?t=00h07m10s)

[love that okay that's a hack sweet I now](https://youtu.be/upMpPtQuc0c?t=00h07m14s)

[have pushed permissions to your](https://youtu.be/upMpPtQuc0c?t=00h07m17s)

[repository well I have pushed](https://youtu.be/upMpPtQuc0c?t=00h07m18s)

[permissions to this branch in your](https://youtu.be/upMpPtQuc0c?t=00h07m20s)

[repository it is a kind of a cheap way](https://youtu.be/upMpPtQuc0c?t=00h07m22s)

[to scope somebody's permissions](https://youtu.be/upMpPtQuc0c?t=00h07m24s)

[down without I haven't thought about](https://youtu.be/upMpPtQuc0c?t=00h07m27s)

[using way I before I have to say](https://youtu.be/upMpPtQuc0c?t=00h07m29s)

[collaborating by opening a PR and](https://youtu.be/upMpPtQuc0c?t=00h07m31s)

[checking a box I mean it it is limited](https://youtu.be/upMpPtQuc0c?t=00h07m33s)

[to where you can do this okay but](https://youtu.be/upMpPtQuc0c?t=00h07m36s)

[regardless I think now if I rebuild now](https://youtu.be/upMpPtQuc0c?t=00h07m39s)

[that I have a a n get config in place I](https://youtu.be/upMpPtQuc0c?t=00h07m43s)

[think will](https://youtu.be/upMpPtQuc0c?t=00h07m47s)

[be I don't know if you're watching chat](https://youtu.be/upMpPtQuc0c?t=00h07m52s)

[Andrew hi Benjamin I thought co-pilot](https://youtu.be/upMpPtQuc0c?t=00h07m55s)

[with Kevin's only friend he talks a lot](https://youtu.be/upMpPtQuc0c?t=00h07m57s)

[to him or](https://youtu.be/upMpPtQuc0c?t=00h07m59s)

[her me and co-pilot sometimes sometimes](https://youtu.be/upMpPtQuc0c?t=00h08m02s)

[I think Kevin's my co-pilot I just ask](https://youtu.be/upMpPtQuc0c?t=00h08m05s)

[him questions and all of a sudden the](https://youtu.be/upMpPtQuc0c?t=00h08m06s)

[perfect answers come back I wouldn't say](https://youtu.be/upMpPtQuc0c?t=00h08m08s)

[perfect my answers are maybe on par with](https://youtu.be/upMpPtQuc0c?t=00h08m10s)

[co-pilot but yes you give better](https://youtu.be/upMpPtQuc0c?t=00h08m15s)

[explanations than co-pilot gives](https://youtu.be/upMpPtQuc0c?t=00h08m17s)

[absolutely but co-pilot set that bar](https://youtu.be/upMpPtQuc0c?t=00h08m19s)

[pretty](https://youtu.be/upMpPtQuc0c?t=00h08m21s)

[low uh okay so we've got this going okay](https://youtu.be/upMpPtQuc0c?t=00h08m23s)

[walk me through what we've done where am](https://youtu.be/upMpPtQuc0c?t=00h08m26s)

[I going cuz you've done a bit of work](https://youtu.be/upMpPtQuc0c?t=00h08m28s)

[here already where should I haven't done](https://youtu.be/upMpPtQuc0c?t=00h08m29s)

[too much work but under the mock](https://youtu.be/upMpPtQuc0c?t=00h08m31s)

[automach generator example xunit](https://youtu.be/upMpPtQuc0c?t=00h08m35s)

[tests uh this guy here okay yep I set a](https://youtu.be/upMpPtQuc0c?t=00h08m39s)

[string test this was just me kind of](https://youtu.be/upMpPtQuc0c?t=00h08m42s)

[proving that there was a problem I](https://youtu.be/upMpPtQuc0c?t=00h08m44s)

[haven't actually cleaned this up but](https://youtu.be/upMpPtQuc0c?t=00h08m45s)

[there's a um wait I here string test yes](https://youtu.be/upMpPtQuc0c?t=00h08m47s)

[and it calls the controller string type](https://youtu.be/upMpPtQuc0c?t=00h08m53s)

[of controller string got it which is](https://youtu.be/upMpPtQuc0c?t=00h08m56s)

[under example and that has](https://youtu.be/upMpPtQuc0c?t=00h08m59s)

[a parameter yeah feel free to this was](https://youtu.be/upMpPtQuc0c?t=00h09m01s)

[proof of concept got it right](https://youtu.be/upMpPtQuc0c?t=00h09m05s)

[um and so oh it's interesting that you](https://youtu.be/upMpPtQuc0c?t=00h09m09s)

[have string string is that](https://youtu.be/upMpPtQuc0c?t=00h09m12s)

[intentional I was kind of trying to](https://youtu.be/upMpPtQuc0c?t=00h09m15s)

[prove one that the first one doesn't um](https://youtu.be/upMpPtQuc0c?t=00h09m17s)

[oh I see yeah that's probably the hard](https://youtu.be/upMpPtQuc0c?t=00h09m20s)

[weate a test for the first one and we](https://youtu.be/upMpPtQuc0c?t=00h09m22s)

[don't generate test for the second one](https://youtu.be/upMpPtQuc0c?t=00h09m23s)

[got it was kind of the thinking got it](https://youtu.be/upMpPtQuc0c?t=00h09m25s)

[okay because right now if we look at](https://youtu.be/upMpPtQuc0c?t=00h09m28s)

[what this guy's generating I'm guessing](https://youtu.be/upMpPtQuc0c?t=00h09m30s)

[we have a](https://youtu.be/upMpPtQuc0c?t=00h09m32s)

[problem because I'm and to be clear I've](https://youtu.be/upMpPtQuc0c?t=00h09m34s)

[never done generators before so this is](https://youtu.be/upMpPtQuc0c?t=00h09m37s)

[all this is all fresh excellent the past](https://youtu.be/upMpPtQuc0c?t=00h09m39s)

[24-hour](https://youtu.be/upMpPtQuc0c?t=00h09m42s)

[fresh hey in a couple hours you'll you](https://youtu.be/upMpPtQuc0c?t=00h09m44s)

[will be more than just uh fresh and it](https://youtu.be/upMpPtQuc0c?t=00h09m48s)

[will be perfectly make sense and](https://youtu.be/upMpPtQuc0c?t=00h09m52s)

[everything so this guy the The Source](https://youtu.be/upMpPtQuc0c?t=00h09m54s)

[generator did genen these things out and](https://youtu.be/upMpPtQuc0c?t=00h09m57s)

[the problem here in case it's not](https://youtu.be/upMpPtQuc0c?t=00h10m00s)

[obvious to people the the way that this](https://youtu.be/upMpPtQuc0c?t=00h10m02s)

[is this Constructor test is intended to](https://youtu.be/upMpPtQuc0c?t=00h10m05s)

[be used is that the the system under](https://youtu.be/upMpPtQuc0c?t=00h10m08s)

[test in this case](https://youtu.be/upMpPtQuc0c?t=00h10m13s)

[controller um oh I'm looking at the](https://youtu.be/upMpPtQuc0c?t=00h10m15s)

[wrong one this guy uh controller string](https://youtu.be/upMpPtQuc0c?t=00h10m18s)

[is it anticipates the system under test](https://youtu.be/upMpPtQuc0c?t=00h10m22s)

[being something that's like dependency](https://youtu.be/upMpPtQuc0c?t=00h10m25s)

[injected and so it only is going to have](https://youtu.be/upMpPtQuc0c?t=00h10m27s)

[things that a DI container would resolve](https://youtu.be/upMpPtQuc0c?t=00h10m30s)

[and sometimes you have to do this kind](https://youtu.be/upMpPtQuc0c?t=00h10m33s)

[of partial method thing to inject extra](https://youtu.be/upMpPtQuc0c?t=00h10m35s)

[stuff but for the most part that's the](https://youtu.be/upMpPtQuc0c?t=00h10m37s)

[intent and what you've subtly broken is](https://youtu.be/upMpPtQuc0c?t=00h10m40s)

[this type of Constructor was never a use](https://youtu.be/upMpPtQuc0c?t=00h10m44s)

[case it was designed to](https://youtu.be/upMpPtQuc0c?t=00h10m47s)

[fulfill so it kind of can I was being](https://youtu.be/upMpPtQuc0c?t=00h10m49s)

[lazy I I'm creating a little Library](https://youtu.be/upMpPtQuc0c?t=00h10m52s)

[thing where I'm creating a service that](https://youtu.be/upMpPtQuc0c?t=00h10m54s)

[gets added to the DI and it has about](https://youtu.be/upMpPtQuc0c?t=00h10m57s)

[eight parameters of potential options of](https://youtu.be/upMpPtQuc0c?t=00h10m59s)

[how to register with GitHub in fact and](https://youtu.be/upMpPtQuc0c?t=00h11m01s)

[I was like do I want to write all these](https://youtu.be/upMpPtQuc0c?t=00h11m05s)

[tests no that's how this running for me](https://youtu.be/upMpPtQuc0c?t=00h11m06s)

[and then I was like why does it keep](https://youtu.be/upMpPtQuc0c?t=00h11m09s)

[failing and this is what I track down](https://youtu.be/upMpPtQuc0c?t=00h11m11s)

[right because right now the source](https://youtu.be/upMpPtQuc0c?t=00h11m13s)

[generator blindly Jens an uh an argument](https://youtu.be/upMpPtQuc0c?t=00h11m15s)

[null test for each one of these and one](https://youtu.be/upMpPtQuc0c?t=00h11m17s)

[of these it should gen the test for and](https://youtu.be/upMpPtQuc0c?t=00h11m20s)

[one of these it shouldn't and I think](https://youtu.be/upMpPtQuc0c?t=00h11m22s)

[what we're saying is we don't want it to](https://youtu.be/upMpPtQuc0c?t=00h11m24s)

[generate uh a test if the parameter has](https://youtu.be/upMpPtQuc0c?t=00h11m27s)

[a default value of null on there so](https://youtu.be/upMpPtQuc0c?t=00h11m31s)

[whether it's what do you think if it's](https://youtu.be/upMpPtQuc0c?t=00h11m34s)

[just nullable like is there ever a case](https://youtu.be/upMpPtQuc0c?t=00h11m35s)

[where if it's nullable I think the](https://youtu.be/upMpPtQuc0c?t=00h11m37s)

[expectation at least in my opinion is](https://youtu.be/upMpPtQuc0c?t=00h11m39s)

[that you](https://youtu.be/upMpPtQuc0c?t=00h11m41s)

[have you will handle it if it's a](https://youtu.be/upMpPtQuc0c?t=00h11m42s)

[nullable parameter coming in you're](https://youtu.be/upMpPtQuc0c?t=00h11m45s)

[expecting that the the okay end user](https://youtu.be/upMpPtQuc0c?t=00h11m46s)

[will handle it I don't even think it has](https://youtu.be/upMpPtQuc0c?t=00h11m49s)

[to be default um that's that is a that](https://youtu.be/upMpPtQuc0c?t=00h11m51s)

[is a fair point if it's declared](https://youtu.be/upMpPtQuc0c?t=00h11m55s)

[nullable you wouldn't expect it to to](https://youtu.be/upMpPtQuc0c?t=00h11m57s)

[throw an argument null exception though](https://youtu.be/upMpPtQuc0c?t=00h11m59s)

[that does mean that we have to be more](https://youtu.be/upMpPtQuc0c?t=00h12m02s)

[intelligent right so there's a](https://youtu.be/upMpPtQuc0c?t=00h12m04s)

[couple I guess that is really the only](https://youtu.be/upMpPtQuc0c?t=00h12m06s)

[case if it is](https://youtu.be/upMpPtQuc0c?t=00h12m09s)

[nullable but how I I think we still want](https://youtu.be/upMpPtQuc0c?t=00h12m10s)

[to handle this case here for the case](https://youtu.be/upMpPtQuc0c?t=00h12m13s)

[where somebody has nullability turned](https://youtu.be/upMpPtQuc0c?t=00h12m15s)

[off right because there's nothing that's](https://youtu.be/upMpPtQuc0c?t=00h12m17s)

[true as well because totally agree yeah](https://youtu.be/upMpPtQuc0c?t=00h12m20s)

[because somebody could be in this](https://youtu.be/upMpPtQuc0c?t=00h12m23s)

[situation and I think we also want to](https://youtu.be/upMpPtQuc0c?t=00h12m25s)

[acknowledge that so I think there's two](https://youtu.be/upMpPtQuc0c?t=00h12m27s)

[cases we want to we want to handle but I](https://youtu.be/upMpPtQuc0c?t=00h12m30s)

[think both of them are reasonable to do](https://youtu.be/upMpPtQuc0c?t=00h12m32s)

[one of them another case though I'm](https://youtu.be/upMpPtQuc0c?t=00h12m36s)

[happy to be write an analyzer that says](https://youtu.be/upMpPtQuc0c?t=00h12m37s)

[turn on nullability](https://youtu.be/upMpPtQuc0c?t=00h12m40s)

[well and to be fair this is the first](https://youtu.be/upMpPtQuc0c?t=00h12m42s)

[time anybody's requested this the other](https://youtu.be/upMpPtQuc0c?t=00h12m44s)

[thing that people really want this](https://youtu.be/upMpPtQuc0c?t=00h12m46s)

[Source generator to do is act on more](https://youtu.be/upMpPtQuc0c?t=00h12m48s)

[than](https://youtu.be/upMpPtQuc0c?t=00h12m50s)

[just](https://youtu.be/upMpPtQuc0c?t=00h12m51s)

[Constructors right people want people](https://youtu.be/upMpPtQuc0c?t=00h12m53s)

[yeah people want to be able to specify a](https://youtu.be/upMpPtQuc0c?t=00h12m56s)

[a method name or similar and in this](https://youtu.be/upMpPtQuc0c?t=00h12m58s)

[case like this stuff up here it's okay](https://youtu.be/upMpPtQuc0c?t=00h13m00s)

[if we use magic strings because or name](https://youtu.be/upMpPtQuc0c?t=00h13m02s)

[of or similar because it it's comp it's](https://youtu.be/upMpPtQuc0c?t=00h13m05s)

[still going to be compiler checked okay](https://youtu.be/upMpPtQuc0c?t=00h13m08s)

[so that's that's the expectation the](https://youtu.be/upMpPtQuc0c?t=00h13m10s)

[failure case here is that we've got two](https://youtu.be/upMpPtQuc0c?t=00h13m11s)

[things here if I run the tests I assume](https://youtu.be/upMpPtQuc0c?t=00h13m14s)

[I'm in a a failing state for these tests](https://youtu.be/upMpPtQuc0c?t=00h13m17s)

[yeah yeah I don't think I got it working](https://youtu.be/upMpPtQuc0c?t=00h13m20s)

[yet perfect I](https://youtu.be/upMpPtQuc0c?t=00h13m22s)

[love I run the](https://youtu.be/upMpPtQuc0c?t=00h13m25s)

[test](https://youtu.be/upMpPtQuc0c?t=00h13m27s)

[uh if I did this is surprised to me](https://youtu.be/upMpPtQuc0c?t=00h13m30s)

[because it wasn't working on my machine](https://youtu.be/upMpPtQuc0c?t=00h13m33s)

[that's fair hey izy uh so we are working](https://youtu.be/upMpPtQuc0c?t=00h13m35s)

[on expanding the auto marer unit test](https://youtu.be/upMpPtQuc0c?t=00h13m38s)

[generator um to be a little bit smarter](https://youtu.be/upMpPtQuc0c?t=00h13m43s)

[right now it blindly generates unit test](https://youtu.be/upMpPtQuc0c?t=00h13m46s)

[for all parameters and we want it to not](https://youtu.be/upMpPtQuc0c?t=00h13m48s)

[generate if the parameter is if null is](https://youtu.be/upMpPtQuc0c?t=00h13m51s)

[expected for the parameter](https://youtu.be/upMpPtQuc0c?t=00h13m54s)

[basically okay so good so this test](https://youtu.be/upMpPtQuc0c?t=00h13m55s)

[fails but it also fails because it](https://youtu.be/upMpPtQuc0c?t=00h13m59s)

[shouldn't exist so the expectation is](https://youtu.be/upMpPtQuc0c?t=00h14m02s)

[this test just doesn't show up right so](https://youtu.be/upMpPtQuc0c?t=00h14m05s)

[that that kind of makes sense did you](https://youtu.be/upMpPtQuc0c?t=00h14m08s)

[write](https://youtu.be/upMpPtQuc0c?t=00h14m10s)

[any unit test over this yet no it](https://youtu.be/upMpPtQuc0c?t=00h14m11s)

[doesn't look like it no I just wrote The](https://youtu.be/upMpPtQuc0c?t=00h14m14s)

[Generation test I hadn't totally found](https://youtu.be/upMpPtQuc0c?t=00h14m16s)

[my way around the library so I was](https://youtu.be/upMpPtQuc0c?t=00h14m18s)

[playing around with how to how it pass](https://youtu.be/upMpPtQuc0c?t=00h14m19s)

[the I think we decided offline um it's](https://youtu.be/upMpPtQuc0c?t=00h14m21s)

[best to pass in basically you can opt in](https://youtu.be/upMpPtQuc0c?t=00h14m25s)

[to this functionality because you had](https://youtu.be/upMpPtQuc0c?t=00h14m27s)

[some existing functionality otherwise so](https://youtu.be/upMpPtQuc0c?t=00h14m29s)

[I work on passing an enome through the](https://youtu.be/upMpPtQuc0c?t=00h14m31s)

[the](https://youtu.be/upMpPtQuc0c?t=00h14m34s)

[attribute uh that would then toggle this](https://youtu.be/upMpPtQuc0c?t=00h14m35s)

[yeah and I got I think that far so we](https://youtu.be/upMpPtQuc0c?t=00h14m38s)

[have something like this where we can](https://youtu.be/upMpPtQuc0c?t=00h14m41s)

[then](https://youtu.be/upMpPtQuc0c?t=00h14m43s)

[do it should actually be there it's](https://youtu.be/upMpPtQuc0c?t=00h14m44s)

[called yep it's called skip knowable](https://youtu.be/upMpPtQuc0c?t=00h14m47s)

[reference types right now but I think I](https://youtu.be/upMpPtQuc0c?t=00h14m50s)

[think I might want to rename this enum](https://youtu.be/upMpPtQuc0c?t=00h14m53s)

[value to something like uh skip](https://youtu.be/upMpPtQuc0c?t=00h14m55s)

[parameters that are expected to be null](https://youtu.be/upMpPtQuc0c?t=00h14m59s)

[or something yeah and there might be two](https://youtu.be/upMpPtQuc0c?t=00h15m01s)

[honestly if one's like noble reference](https://youtu.be/upMpPtQuc0c?t=00h15m04s)

[types and ones equals null default value](https://youtu.be/upMpPtQuc0c?t=00h15m07s)

[I don't know if people there might be a](https://youtu.be/upMpPtQuc0c?t=00h15m12s)

[both and one or the other I'm trying to](https://youtu.be/upMpPtQuc0c?t=00h15m13s)

[imagine the use case where somebody](https://youtu.be/upMpPtQuc0c?t=00h15m16s)

[wants one but not the other like I can](https://youtu.be/upMpPtQuc0c?t=00h15m18s)

[see people wanting feature on feature](https://youtu.be/upMpPtQuc0c?t=00h15m20s)

[off but I'm struggling to imagine where](https://youtu.be/upMpPtQuc0c?t=00h15m24s)

[somebody would](https://youtu.be/upMpPtQuc0c?t=00h15m26s)

[right because what we're positing](https://youtu.be/upMpPtQuc0c?t=00h15m29s)

[is I guess because of the optional](https://youtu.be/upMpPtQuc0c?t=00h15m32s)

[parameter right we're positing the case](https://youtu.be/upMpPtQuc0c?t=00h15m35s)

[where somebody wants the test for Foo or](https://youtu.be/upMpPtQuc0c?t=00h15m38s)

[test name but not the other and I don't](https://youtu.be/upMpPtQuc0c?t=00h15m41s)

[know if they would actually want](https://youtu.be/upMpPtQuc0c?t=00h15m44s)

[that right um with a pent square there's](https://youtu.be/upMpPtQuc0c?t=00h15m47s)

[what three options so a string that](https://youtu.be/upMpPtQuc0c?t=00h15m51s)

[doesn't have a default](https://youtu.be/upMpPtQuc0c?t=00h15m53s)

[parameter a a nullable string that does](https://youtu.be/upMpPtQuc0c?t=00h15m55s)

[have a defa default parameter and a](https://youtu.be/upMpPtQuc0c?t=00h15m58s)

[notable string that](https://youtu.be/upMpPtQuc0c?t=00h15m59s)

[doesn't yeah I can't think of one yeah I](https://youtu.be/upMpPtQuc0c?t=00h16m01s)

[suspect they I think I agree with you](https://youtu.be/upMpPtQuc0c?t=00h16m05s)

[yeah I think they only want to honor off](https://youtu.be/upMpPtQuc0c?t=00h16m06s)

[but let's you know what I'm going to](https://youtu.be/upMpPtQuc0c?t=00h16m08s)

[leave the enom name we'll think on it I](https://youtu.be/upMpPtQuc0c?t=00h16m10s)

[the only thing I don't like is calling](https://youtu.be/upMpPtQuc0c?t=00h16m13s)

[it Noble reference types seems to imply](https://youtu.be/upMpPtQuc0c?t=00h16m14s)

[that it will only work in that one case](https://youtu.be/upMpPtQuc0c?t=00h16m17s)

[and I want to handle the case where](https://youtu.be/upMpPtQuc0c?t=00h16m18s)

[Noble reference types is](https://youtu.be/upMpPtQuc0c?t=00h16m20s)

[disabled um just because we do Target](https://youtu.be/upMpPtQuc0c?t=00h16m22s)

[old enough Frameworks that people might](https://youtu.be/upMpPtQuc0c?t=00h16m25s)

[care okay so we got got that so so you](https://youtu.be/upMpPtQuc0c?t=00h16m27s)

[did good there already you've already](https://youtu.be/upMpPtQuc0c?t=00h16m29s)

[added that so in the test](https://youtu.be/upMpPtQuc0c?t=00h16m31s)

[generator generator target class okay so](https://youtu.be/upMpPtQuc0c?t=00h16m34s)

[let's go through the source generator](https://youtu.be/upMpPtQuc0c?t=00h16m37s)

[kind of layout real quick and figure out](https://youtu.be/upMpPtQuc0c?t=00h16m39s)

[where where we want to start this so the](https://youtu.be/upMpPtQuc0c?t=00h16m42s)

[starting place for a source](https://youtu.be/upMpPtQuc0c?t=00h16m46s)

[generator uh comes with having a class](https://youtu.be/upMpPtQuc0c?t=00h16m49s)

[that has the generator attribute and](https://youtu.be/upMpPtQuc0c?t=00h16m53s)

[deriving from isource generator this](https://youtu.be/upMpPtQuc0c?t=00h16m54s)

[does also assume that you have have uh](https://youtu.be/upMpPtQuc0c?t=00h16m57s)

[appropriately referenced the the needed](https://youtu.be/upMpPtQuc0c?t=00h16m59s)

[new get packages so you must do that so](https://youtu.be/upMpPtQuc0c?t=00h17m01s)

[that you have these types but then 50 B](https://youtu.be/upMpPtQuc0c?t=00h17m04s)

[Bo yeah the implementation for isource](https://youtu.be/upMpPtQuc0c?t=00h17m06s)

[generator is really simple there's](https://youtu.be/upMpPtQuc0c?t=00h17m09s)

[initialize](https://youtu.be/upMpPtQuc0c?t=00h17m13s)

[execute um this used to even be a single](https://youtu.be/upMpPtQuc0c?t=00h17m14s)

[method until recently when I'm trying to](https://youtu.be/upMpPtQuc0c?t=00h17m17s)

[remember what they called](https://youtu.be/upMpPtQuc0c?t=00h17m20s)

[it this is like Source generators V2 and](https://youtu.be/upMpPtQuc0c?t=00h17m22s)

[there was a name for it so that they](https://youtu.be/upMpPtQuc0c?t=00h17m25s)

[could do increment incremental Source](https://youtu.be/upMpPtQuc0c?t=00h17m27s)

[generators](https://youtu.be/upMpPtQuc0c?t=00h17m29s)

[ha um but the idea here is that during](https://youtu.be/upMpPtQuc0c?t=00h17m31s)

[initialize we register for uh the syntax](https://youtu.be/upMpPtQuc0c?t=00h17m34s)

[receiver where we want to handle](https://youtu.be/upMpPtQuc0c?t=00h17m38s)

[parsy uh and then the actual execution](https://youtu.be/upMpPtQuc0c?t=00h17m41s)

[of uh parsing all of our stuff and the](https://youtu.be/upMpPtQuc0c?t=00h17m45s)

[the the typical recommendation and this](https://youtu.be/upMpPtQuc0c?t=00h17m49s)

[this Source generator kind of doesn't](https://youtu.be/upMpPtQuc0c?t=00h17m51s)

[follow best practices so we'll take this](https://youtu.be/upMpPtQuc0c?t=00h17m53s)

[with a bit of a grain of salt is you](https://youtu.be/upMpPtQuc0c?t=00h17m55s)

[typically want to parse the the C code](https://youtu.be/upMpPtQuc0c?t=00h17m58s)

[because you're acting on the the syntax](https://youtu.be/upMpPtQuc0c?t=00h18m02s)

[tree of your source code parse that into](https://youtu.be/upMpPtQuc0c?t=00h18m05s)

[an object model and separate out the](https://youtu.be/upMpPtQuc0c?t=00h18m07s)

[parsing into an object model from taking](https://youtu.be/upMpPtQuc0c?t=00h18m10s)

[that object model and generating source](https://youtu.be/upMpPtQuc0c?t=00h18m13s)

[code from It generally you want those](https://youtu.be/upMpPtQuc0c?t=00h18m15s)

[two steps to be distinct is is typically](https://youtu.be/upMpPtQuc0c?t=00h18m17s)

[what you want and this mostly handles it](https://youtu.be/upMpPtQuc0c?t=00h18m20s)

[is right so the syntax receiver is what](https://youtu.be/upMpPtQuc0c?t=00h18m23s)

[we registered up up on](https://youtu.be/upMpPtQuc0c?t=00h18m27s)

[and](https://youtu.be/upMpPtQuc0c?t=00h18m29s)

[specifically this is where we start](https://youtu.be/upMpPtQuc0c?t=00h18m30s)

[doing the interesting stuff and it's](https://youtu.be/upMpPtQuc0c?t=00h18m32s)

[very very very very very important the](https://youtu.be/upMpPtQuc0c?t=00h18m36s)

[order of operations that we check for](https://youtu.be/upMpPtQuc0c?t=00h18m39s)

[things right so it checks for a class](https://youtu.be/upMpPtQuc0c?t=00h18m41s)

[declaration syntax because you want to](https://youtu.be/upMpPtQuc0c?t=00h18m43s)

[do the the cheapest check first and the](https://youtu.be/upMpPtQuc0c?t=00h18m45s)

[most expensive check last so we first](https://youtu.be/upMpPtQuc0c?t=00h18m49s)

[check if it's a class declaration syntax](https://youtu.be/upMpPtQuc0c?t=00h18m51s)

[because most syntax nodes aren't going](https://youtu.be/upMpPtQuc0c?t=00h18m53s)

[to be class declarations and so we just](https://youtu.be/upMpPtQuc0c?t=00h18m56s)

[move on right immediately filter](https://youtu.be/upMpPtQuc0c?t=00h18m59s)

[everything else](https://youtu.be/upMpPtQuc0c?t=00h19m00s)

[out find the stuff find the attribute](https://youtu.be/upMpPtQuc0c?t=00h19m02s)

[and then specifically come down and find](https://youtu.be/upMpPtQuc0c?t=00h19m05s)

[the Constructor test attribute and I](https://youtu.be/upMpPtQuc0c?t=00h19m07s)

[will point out that the you'll note the](https://youtu.be/upMpPtQuc0c?t=00h19m10s)

[Constructor test attribute we hunt this](https://youtu.be/upMpPtQuc0c?t=00h19m13s)

[guy by Magic](https://youtu.be/upMpPtQuc0c?t=00h19m15s)

[strings that is good in this](https://youtu.be/upMpPtQuc0c?t=00h19m17s)

[case um because you don't necessarily](https://youtu.be/upMpPtQuc0c?t=00h19m21s)

[want your Source generator to have a a](https://youtu.be/upMpPtQuc0c?t=00h19m24s)

[hard reference back to your other](https://youtu.be/upMpPtQuc0c?t=00h19m27s)

[Library so I was going to ask how was it](https://youtu.be/upMpPtQuc0c?t=00h19m29s)

[doing that where's that](https://youtu.be/upMpPtQuc0c?t=00h19m32s)

[declared uh this Constructor test](https://youtu.be/upMpPtQuc0c?t=00h19m35s)

[attribute yeah so this is just magic](https://youtu.be/upMpPtQuc0c?t=00h19m38s)

[string got it literally a magic string](https://youtu.be/upMpPtQuc0c?t=00h19m41s)

[um but the attribute itself does exist](https://youtu.be/upMpPtQuc0c?t=00h19m44s)

[over here right because the when we](https://youtu.be/upMpPtQuc0c?t=00h19m47s)

[build up our Nate package this is](https://youtu.be/upMpPtQuc0c?t=00h19m50s)

[actually probably Worth showing](https://youtu.be/upMpPtQuc0c?t=00h19m53s)

[off n get package Explorer open package](https://youtu.be/upMpPtQuc0c?t=00h19m55s)

[from online feed we go and look here](https://youtu.be/upMpPtQuc0c?t=00h19m58s)

[because at the end of the](https://youtu.be/upMpPtQuc0c?t=00h20m02s)

[day um you typically want it set up](https://youtu.be/upMpPtQuc0c?t=00h20m04s)

[you'll note we have lib which anybody](https://youtu.be/upMpPtQuc0c?t=00h20m08s)

[who references the nougat package the](https://youtu.be/upMpPtQuc0c?t=00h20m11s)

[lib folder is the dlls that your](https://youtu.be/upMpPtQuc0c?t=00h20m12s)

[projects is then going to automatically](https://youtu.be/upMpPtQuc0c?t=00h20m15s)

[reference based upon your target](https://youtu.be/upMpPtQuc0c?t=00h20m16s)

[framework most people are probably going](https://youtu.be/upMpPtQuc0c?t=00h20m18s)

[to land in the net standard case but](https://youtu.be/upMpPtQuc0c?t=00h20m20s)

[then we have an](https://youtu.be/upMpPtQuc0c?t=00h20m22s)

[analyzer specifically for C because if](https://youtu.be/upMpPtQuc0c?t=00h20m24s)

[hyp pathetically because this is net](https://youtu.be/upMpPtQuc0c?t=00h20m27s)

[somebody could use it on different](https://youtu.be/upMpPtQuc0c?t=00h20m30s)

[language and in that case our analyzer](https://youtu.be/upMpPtQuc0c?t=00h20m31s)

[will not help you this is a c only](https://youtu.be/upMpPtQuc0c?t=00h20m33s)

[Helper and that's where it lands so](https://youtu.be/upMpPtQuc0c?t=00h20m36s)

[ultimately that's the separation of](https://youtu.be/upMpPtQuc0c?t=00h20m40s)

[concerns there is it actually considered](https://youtu.be/upMpPtQuc0c?t=00h20m41s)

[an analyzer if it's a generator](https://youtu.be/upMpPtQuc0c?t=00h20m43s)

[yes because they both come from the same](https://youtu.be/upMpPtQuc0c?t=00h20m46s)

[SDK got it but they they they do](https://youtu.be/upMpPtQuc0c?t=00h20m50s)

[get the the](https://youtu.be/upMpPtQuc0c?t=00h20m53s)

[compiler effectively loads them the same](https://youtu.be/upMpPtQuc0c?t=00h20m55s)

[way](https://youtu.be/upMpPtQuc0c?t=00h20m57s)

[but the when they get executed and what](https://youtu.be/upMpPtQuc0c?t=00h20m58s)

[they do is slightly different and it's](https://youtu.be/upMpPtQuc0c?t=00h21m01s)

[it's not uncommon to be able to have](https://youtu.be/upMpPtQuc0c?t=00h21m04s)

[like in our case we've got this test](https://youtu.be/upMpPtQuc0c?t=00h21m07s)

[generator project which it feels like a](https://youtu.be/upMpPtQuc0c?t=00h21m08s)

[weird name but it is generating test so](https://youtu.be/upMpPtQuc0c?t=00h21m10s)

[it works right but you can put all of](https://youtu.be/upMpPtQuc0c?t=00h21m13s)

[your generators and all of your](https://youtu.be/upMpPtQuc0c?t=00h21m15s)

[analyzers into a single assembly and](https://youtu.be/upMpPtQuc0c?t=00h21m17s)

[then it's going the um the compiler is](https://youtu.be/upMpPtQuc0c?t=00h21m19s)

[going to load up your assembly and pull](https://youtu.be/upMpPtQuc0c?t=00h21m23s)

[all that stuff out which does make it](https://youtu.be/upMpPtQuc0c?t=00h21m24s)

[mildly painful to to debug because](https://youtu.be/upMpPtQuc0c?t=00h21m26s)

[things like Ms build like to stay](https://youtu.be/upMpPtQuc0c?t=00h21m29s)

[running and hold on to that dll which is](https://youtu.be/upMpPtQuc0c?t=00h21m31s)

[good for performance horrible for](https://youtu.be/upMpPtQuc0c?t=00h21m34s)

[debug but I like this so you put the the](https://youtu.be/upMpPtQuc0c?t=00h21m37s)

[enum in good default member on the](https://youtu.be/upMpPtQuc0c?t=00h21m40s)

[enum I like the name of the enom the](https://youtu.be/upMpPtQuc0c?t=00h21m44s)

[member name we may work on but overall](https://youtu.be/upMpPtQuc0c?t=00h21m47s)

[that works well um this is actually not](https://youtu.be/upMpPtQuc0c?t=00h21m50s)

[needed trying to decide if we want it or](https://youtu.be/upMpPtQuc0c?t=00h21m53s)

[not yeah I was trying to decide more I](https://youtu.be/upMpPtQuc0c?t=00h21m56s)

[it was coming from my EF mind of setting](https://youtu.be/upMpPtQuc0c?t=00h21m59s)

[default numbers and whatnot and I was](https://youtu.be/upMpPtQuc0c?t=00h22m01s)

[just yeah I don't I didn't have it of](https://youtu.be/upMpPtQuc0c?t=00h22m03s)

[other project had gotten refactor yeah I](https://youtu.be/upMpPtQuc0c?t=00h22m07s)

[might nuke it for now but it's not bad](https://youtu.be/upMpPtQuc0c?t=00h22m10s)

[there's also probably what while we're](https://youtu.be/upMpPtQuc0c?t=00h22m13s)

[here it's probably worth also doing](https://youtu.be/upMpPtQuc0c?t=00h22m15s)

[a uh constru overload a Constructor](https://youtu.be/upMpPtQuc0c?t=00h22m19s)

[just uh](https://youtu.be/upMpPtQuc0c?t=00h22m25s)

[boom](https://youtu.be/upMpPtQuc0c?t=00h22m29s)

[and we'll come back and add as you can](https://youtu.be/upMpPtQuc0c?t=00h22m32s)

[see we've been bad on some of our](https://youtu.be/upMpPtQuc0c?t=00h22m36s)

[documentation we do have the analyzer](https://youtu.be/upMpPtQuc0c?t=00h22m37s)

[forcing us to write it doesn't mean we](https://youtu.be/upMpPtQuc0c?t=00h22m39s)

[wrote Good docs okay so we got that we](https://youtu.be/upMpPtQuc0c?t=00h22m40s)

[got that so you you built all of that up](https://youtu.be/upMpPtQuc0c?t=00h22m44s)

[and then you did come in here and it and](https://youtu.be/upMpPtQuc0c?t=00h22m47s)

[you did track](https://youtu.be/upMpPtQuc0c?t=00h22m50s)

[down where the source generator is](https://youtu.be/upMpPtQuc0c?t=00h22m52s)

[pulling at least the](https://youtu.be/upMpPtQuc0c?t=00h22m54s)

[first um attribute off of](https://youtu.be/upMpPtQuc0c?t=00h22m56s)

[it right so it's it's pulling this this](https://youtu.be/upMpPtQuc0c?t=00h22m59s)

[attribute](https://youtu.be/upMpPtQuc0c?t=00h23m03s)

[here yep right so it Yanks the attribute](https://youtu.be/upMpPtQuc0c?t=00h23m04s)

[and then that's where I I think I got it](https://youtu.be/upMpPtQuc0c?t=00h23m08s)

[but I wasn't really confident and I](https://youtu.be/upMpPtQuc0c?t=00h23m11s)

[didn't know how to debug this so this](https://youtu.be/upMpPtQuc0c?t=00h23m12s)

[was blind putting things on a screen and](https://youtu.be/upMpPtQuc0c?t=00h23m15s)

[hoping yeah I'm looking here to](https://youtu.be/upMpPtQuc0c?t=00h23m18s)

[see and then I set it at the bottom in](https://youtu.be/upMpPtQuc0c?t=00h23m22s)

[the target](https://youtu.be/upMpPtQuc0c?t=00h23m25s)

[class it at the bottom right passing it](https://youtu.be/upMpPtQuc0c?t=00h23m26s)

[through](https://youtu.be/upMpPtQuc0c?t=00h23m30s)

[here um because I was looking to see](https://youtu.be/upMpPtQuc0c?t=00h23m31s)

[where this](https://youtu.be/upMpPtQuc0c?t=00h23m33s)

[was um because this is pulling off the](https://youtu.be/upMpPtQuc0c?t=00h23m35s)

[symbol because the the hard part with](https://youtu.be/upMpPtQuc0c?t=00h23m39s)

[Source generators is you have to account](https://youtu.be/upMpPtQuc0c?t=00h23m41s)

[for how many different ways the C](https://youtu.be/upMpPtQuc0c?t=00h23m43s)

[language allows somebody to specify](https://youtu.be/upMpPtQuc0c?t=00h23m47s)

[things which is obnoxious to say the](https://youtu.be/upMpPtQuc0c?t=00h23m48s)

[least](https://youtu.be/upMpPtQuc0c?t=00h23m51s)

[um I am surprised](https://youtu.be/upMpPtQuc0c?t=00h23m55s)

[well let's let's go here so there's a](https://youtu.be/upMpPtQuc0c?t=00h24m02s)

[couple ways we can go through and debug](https://youtu.be/upMpPtQuc0c?t=00h24m03s)

[this uh option one we have why are my](https://youtu.be/upMpPtQuc0c?t=00h24m06s)

[all my dependencies yelling at](https://youtu.be/upMpPtQuc0c?t=00h24m09s)

[me I just relaunch Visual Studio I have](https://youtu.be/upMpPtQuc0c?t=00h24m11s)

[to believe the that nougat config made](https://youtu.be/upMpPtQuc0c?t=00h24m14s)

[it lose its mind there's a handful of](https://youtu.be/upMpPtQuc0c?t=00h24m17s)

[files that Visual Studio is really bad](https://youtu.be/upMpPtQuc0c?t=00h24m19s)

[at reloading on and Nate config is one](https://youtu.be/upMpPtQuc0c?t=00h24m21s)

[of](https://youtu.be/upMpPtQuc0c?t=00h24m24s)

[them](https://youtu.be/upMpPtQuc0c?t=00h24m26s)

[not necessarily edits but creation or](https://youtu.be/upMpPtQuc0c?t=00h24m28s)

[deletion it just it's like it something](https://youtu.be/upMpPtQuc0c?t=00h24m30s)

[holds on to some past memories and it](https://youtu.be/upMpPtQuc0c?t=00h24m33s)

[then proceeds to have nightmares and](https://youtu.be/upMpPtQuc0c?t=00h24m36s)

[forgets how to load project analyzes as](https://youtu.be/upMpPtQuc0c?t=00h24m38s)

[well yeah visual St just does not ever](https://youtu.be/upMpPtQuc0c?t=00h24m41s)

[want to let up your](https://youtu.be/upMpPtQuc0c?t=00h24m44s)

[analyzers well I think a lot of it comes](https://youtu.be/upMpPtQuc0c?t=00h24m46s)

[from the it it's I suspect related to](https://youtu.be/upMpPtQuc0c?t=00h24m48s)

[the caching for the](https://youtu.be/upMpPtQuc0c?t=00h24m51s)

[performance](https://youtu.be/upMpPtQuc0c?t=00h24m54s)

[um let's see see](https://youtu.be/upMpPtQuc0c?t=00h24m56s)

[here okay so we got that there now my](https://youtu.be/upMpPtQuc0c?t=00h24m58s)

[now my things aren't aren't horrible so](https://youtu.be/upMpPtQuc0c?t=00h25m01s)

[we can grab this so we do have tests](https://youtu.be/upMpPtQuc0c?t=00h25m04s)

[down here so we can we can we can come](https://youtu.be/upMpPtQuc0c?t=00h25m08s)

[down here and do this](https://youtu.be/upMpPtQuc0c?t=00h25m11s)

[oh why didn't you point out that this](https://youtu.be/upMpPtQuc0c?t=00h25m13s)

[file wasn't named](https://youtu.be/upMpPtQuc0c?t=00h25m15s)

[properly okay there fix that I hadn't I](https://youtu.be/upMpPtQuc0c?t=00h25m17s)

[hadn't gotten into finding that file yet](https://youtu.be/upMpPtQuc0c?t=00h25m20s)

[oh excellent so these are so we have we](https://youtu.be/upMpPtQuc0c?t=00h25m22s)

[have the example projects up here](https://youtu.be/upMpPtQuc0c?t=00h25m25s)

[which are like your your end to end](https://youtu.be/upMpPtQuc0c?t=00h25m28s)

[tests and then we've got individual unit](https://youtu.be/upMpPtQuc0c?t=00h25m30s)

[tests down here because end to end tests](https://youtu.be/upMpPtQuc0c?t=00h25m32s)

[are really bad at like catching failure](https://youtu.be/upMpPtQuc0c?t=00h25m35s)

[cases and that kind of thing so a lot of](https://youtu.be/upMpPtQuc0c?t=00h25m37s)

[these unit tests are specifically around](https://youtu.be/upMpPtQuc0c?t=00h25m39s)

[grabbing failure cases but it does it](https://youtu.be/upMpPtQuc0c?t=00h25m42s)

[does test some of the happy path](https://youtu.be/upMpPtQuc0c?t=00h25m45s)

[Generation stuff so we may want to just](https://youtu.be/upMpPtQuc0c?t=00h25m47s)

[write ourselves a test](https://youtu.be/upMpPtQuc0c?t=00h25m51s)

[here uh to be able to run and that might](https://youtu.be/upMpPtQuc0c?t=00h25m54s)

[might be one of the easiest ways to](https://youtu.be/upMpPtQuc0c?t=00h25m57s)

[debug this the nice part so for doing](https://youtu.be/upMpPtQuc0c?t=00h25m59s)

[these um generator](https://youtu.be/upMpPtQuc0c?t=00h26m02s)

[things Microsoft does put out a specific](https://youtu.be/upMpPtQuc0c?t=00h26m06s)

[package that gives you some of this](https://youtu.be/upMpPtQuc0c?t=00h26m09s)

[boiler plate because you could do a lot](https://youtu.be/upMpPtQuc0c?t=00h26m11s)

[of it yourself because rosin's open](https://youtu.be/upMpPtQuc0c?t=00h26m14s)

[source but dear Heavens don't like that](https://youtu.be/upMpPtQuc0c?t=00h26m16s)

[sounds miserable so there I believe](https://youtu.be/upMpPtQuc0c?t=00h26m19s)

[there's also like an xunit one and um](https://youtu.be/upMpPtQuc0c?t=00h26m21s)

[and probably nunit I don't remember but](https://youtu.be/upMpPtQuc0c?t=00h26m24s)

[they've got a couple of these things out](https://youtu.be/upMpPtQuc0c?t=00h26m27s)

[here oh real quick did you see the test](https://youtu.be/upMpPtQuc0c?t=00h26m28s)

[anywhere announcement earlier I did not](https://youtu.be/upMpPtQuc0c?t=00h26m31s)

[oh okay side tangent side tangent side](https://youtu.be/upMpPtQuc0c?t=00h26m35s)

[tangent um Microsoft has released a new](https://youtu.be/upMpPtQuc0c?t=00h26m38s)

[test](https://youtu.be/upMpPtQuc0c?t=00h26m42s)

[Runner um to compete with Ms](https://youtu.be/upMpPtQuc0c?t=00h26m44s)

[test uh I don't know if it's compete as](https://youtu.be/upMpPtQuc0c?t=00h26m47s)

[much as](https://youtu.be/upMpPtQuc0c?t=00h26m50s)

[augment the there there's pros and cons](https://youtu.be/upMpPtQuc0c?t=00h26m51s)

[to it so this guy here this guy here](https://youtu.be/upMpPtQuc0c?t=00h26m54s)

[okay so link](https://youtu.be/upMpPtQuc0c?t=00h26m57s)

[incoming for those at home so there](https://youtu.be/upMpPtQuc0c?t=00h26m59s)

[there's there's this guy here uh blah](https://youtu.be/upMpPtQuc0c?t=00h27m03s)

[test adapter blah blah](https://youtu.be/upMpPtQuc0c?t=00h27m07s)

[blah and you go through and you add this](https://youtu.be/upMpPtQuc0c?t=00h27m09s)

[little guy here right enable Ms test](https://youtu.be/upMpPtQuc0c?t=00h27m13s)

[Runner that's the](https://youtu.be/upMpPtQuc0c?t=00h27m17s)

[key right and there's a a meta level](https://youtu.be/upMpPtQuc0c?t=00h27m20s)

[nougat package that brings in all the](https://youtu.be/upMpPtQuc0c?t=00h27m24s)

[normal stuff because before you would](https://youtu.be/upMpPtQuc0c?t=00h27m26s)

[always bring in like all of these](https://youtu.be/upMpPtQuc0c?t=00h27m27s)

[individual packages and that was kind of](https://youtu.be/upMpPtQuc0c?t=00h27m29s)

[a pain in the neck now there's they were](https://youtu.be/upMpPtQuc0c?t=00h27m31s)

[brought in through dependencies yeah now](https://youtu.be/upMpPtQuc0c?t=00h27m33s)

[there's just kind of one level meta](https://youtu.be/upMpPtQuc0c?t=00h27m35s)

[package that you could reference called](https://youtu.be/upMpPtQuc0c?t=00h27m37s)

[Ms test boom bang done huzzah right](https://youtu.be/upMpPtQuc0c?t=00h27m38s)

[you're Off to the Races um but the the](https://youtu.be/upMpPtQuc0c?t=00h27m41s)

[new the new uh testable one you'll know](https://youtu.be/upMpPtQuc0c?t=00h27m45s)

[you can do this with](https://youtu.be/upMpPtQuc0c?t=00h27m48s)

[it so you can you can actually compile](https://youtu.be/upMpPtQuc0c?t=00h27m51s)

[the tests and get out this nice little](https://youtu.be/upMpPtQuc0c?t=00h27m55s)

[thingy that can](https://youtu.be/upMpPtQuc0c?t=00h27m58s)

[run because unit tests are just an](https://youtu.be/upMpPtQuc0c?t=00h27m59s)

[application](https://youtu.be/upMpPtQuc0c?t=00h28m04s)

[right and normally there's like me some](https://youtu.be/upMpPtQuc0c?t=00h28m06s)

[some code I I've been creating a g of](https://youtu.be/upMpPtQuc0c?t=00h28m09s)

[action lately](https://youtu.be/upMpPtQuc0c?t=00h28m12s)

[to to build once and then share across](https://youtu.be/upMpPtQuc0c?t=00h28m13s)

[multiple pipelines and tests are one of](https://youtu.be/upMpPtQuc0c?t=00h28m16s)

[the cases where it gets to be difficult](https://youtu.be/upMpPtQuc0c?t=00h28m19s)

[yeah so the the prime purpose though of](https://youtu.be/upMpPtQuc0c?t=00h28m21s)

[this is because normally like Ms test](https://youtu.be/upMpPtQuc0c?t=00h28m23s)

[uses reflection to find your test](https://youtu.be/upMpPtQuc0c?t=00h28m26s)

[classes and your test methods and all](https://youtu.be/upMpPtQuc0c?t=00h28m27s)

[that jazz and it's not horribly bad but](https://youtu.be/upMpPtQuc0c?t=00h28m29s)

[it is reflection and that comes with a](https://youtu.be/upMpPtQuc0c?t=00h28m32s)

[hit this thing here you can do things](https://youtu.be/upMpPtQuc0c?t=00h28m34s)

[like](https://youtu.be/upMpPtQuc0c?t=00h28m37s)

[aot and](https://youtu.be/upMpPtQuc0c?t=00h28m39s)

[trimming now is that how small can you](https://youtu.be/upMpPtQuc0c?t=00h28m42s)

[get your test down to like is that](https://youtu.be/upMpPtQuc0c?t=00h28m44s)

[important to a lot of people perhaps not](https://youtu.be/upMpPtQuc0c?t=00h28m47s)

[right so you'll note there's one less](https://youtu.be/upMpPtQuc0c?t=00h28m50s)

[process and one less process hop when](https://youtu.be/upMpPtQuc0c?t=00h28m53s)

[running tests because compared to net](https://youtu.be/upMpPtQuc0c?t=00h28m55s)

[test now is one less process and one](https://youtu.be/upMpPtQuc0c?t=00h28m59s)

[less process hop important to most](https://youtu.be/upMpPtQuc0c?t=00h29m02s)

[people probably not right most people](https://youtu.be/upMpPtQuc0c?t=00h29m04s)

[that level of performance on their tests](https://youtu.be/upMpPtQuc0c?t=00h29m08s)

[isn't that big of a deal some people](https://youtu.be/upMpPtQuc0c?t=00h29m10s)

[have like 16,000 tests in their thing](https://youtu.be/upMpPtQuc0c?t=00h29m13s)

[and they might see a nice](https://youtu.be/upMpPtQuc0c?t=00h29m15s)

[bump so fact that Microsoft could see a](https://youtu.be/upMpPtQuc0c?t=00h29m18s)

[three times performance improvement with](https://youtu.be/upMpPtQuc0c?t=00h29m21s)

[four times less memory that's a big](https://youtu.be/upMpPtQuc0c?t=00h29m23s)

[number yes yes yes like this is one of](https://youtu.be/upMpPtQuc0c?t=00h29m25s)

[the I felt like often times people would](https://youtu.be/upMpPtQuc0c?t=00h29m29s)

[like normally people would ask hey which](https://youtu.be/upMpPtQuc0c?t=00h29m32s)

[testing framework should I go with and](https://youtu.be/upMpPtQuc0c?t=00h29m34s)

[it was usually like you know usually I](https://youtu.be/upMpPtQuc0c?t=00h29m36s)

[tell people the default the xunit](https://youtu.be/upMpPtQuc0c?t=00h29m38s)

[because in my opinion it's one of the](https://youtu.be/upMpPtQuc0c?t=00h29m40s)

[more easily extendable ones but I](https://youtu.be/upMpPtQuc0c?t=00h29m41s)

[usually would say any of the Big Three](https://youtu.be/upMpPtQuc0c?t=00h29m44s)

[xunit N unit Ms test they're more or](https://youtu.be/upMpPtQuc0c?t=00h29m47s)

[less at feature](https://youtu.be/upMpPtQuc0c?t=00h29m49s)

[Parish with with some exceptions in](https://youtu.be/upMpPtQuc0c?t=00h29m50s)

[different areas and that kind of thing I](https://youtu.be/upMpPtQuc0c?t=00h29m53s)

[was like but for the most part they'll](https://youtu.be/upMpPtQuc0c?t=00h29m54s)

[all do what what you need](https://youtu.be/upMpPtQuc0c?t=00h29m56s)

[this this is a big deal and I believe](https://youtu.be/upMpPtQuc0c?t=00h29m59s)

[xunit 3 that they've teased for like](https://youtu.be/upMpPtQuc0c?t=00h30m03s)

[years at this point is supposed to have](https://youtu.be/upMpPtQuc0c?t=00h30m05s)

[something similar but](https://youtu.be/upMpPtQuc0c?t=00h30m08s)

[I this is I think the first time Ms test](https://youtu.be/upMpPtQuc0c?t=00h30m09s)

[has been first to a party rather than](https://youtu.be/upMpPtQuc0c?t=00h30m12s)

[last so yeah this is this is pretty cool](https://youtu.be/upMpPtQuc0c?t=00h30m15s)

[um yeah so I haven't gone through a ton](https://youtu.be/upMpPtQuc0c?t=00h30m20s)

[of this stuff yet but this thing dropped](https://youtu.be/upMpPtQuc0c?t=00h30m23s)

[I believe today yeah January 24th so if](https://youtu.be/upMpPtQuc0c?t=00h30m25s)

[anybody's watching this video later this](https://youtu.be/upMpPtQuc0c?t=00h30m27s)

[we're at at time of recording it's](https://youtu.be/upMpPtQuc0c?t=00h30m30s)

[January 24th 2024 this just came out](https://youtu.be/upMpPtQuc0c?t=00h30m32s)

[so it's it's pretty cool it's it's](https://youtu.be/upMpPtQuc0c?t=00h30m36s)

[pretty cool anyway complete side tangent](https://youtu.be/upMpPtQuc0c?t=00h30m40s)

[anyway back to testing I just saw Ms](https://youtu.be/upMpPtQuc0c?t=00h30m43s)

[test adapter and that sometimes hate](https://youtu.be/upMpPtQuc0c?t=00h30m46s)

[when these things come out though](https://youtu.be/upMpPtQuc0c?t=00h30m47s)

[because then like I see something like](https://youtu.be/upMpPtQuc0c?t=00h30m48s)

[that and I'm like I gotta switch every](https://youtu.be/upMpPtQuc0c?t=00h30m50s)

[project I've ever written over to this](https://youtu.be/upMpPtQuc0c?t=00h30m51s)

[new latest feature it's one of my](https://youtu.be/upMpPtQuc0c?t=00h30m53s)

[biggest voles but](https://youtu.be/upMpPtQuc0c?t=00h30m55s)

[shiny yeah yeah but if you're about to](https://youtu.be/upMpPtQuc0c?t=00h30m58s)

[start a new test project yeah maybe it's](https://youtu.be/upMpPtQuc0c?t=00h31m02s)

[time maybe it's worth giving a shot play](https://youtu.be/upMpPtQuc0c?t=00h31m04s)

[with it be hard to pull me away from](https://youtu.be/upMpPtQuc0c?t=00h31m07s)

[xunit it's either that or I wait for](https://youtu.be/upMpPtQuc0c?t=00h31m08s)

[xunit to bring along I do you like my](https://youtu.be/upMpPtQuc0c?t=00h31m10s)

[xunit oh is he January 25th okay sorry](https://youtu.be/upMpPtQuc0c?t=00h31m12s)

[depending on where you are in the world](https://youtu.be/upMpPtQuc0c?t=00h31m16s)

[it may be January 25th already I think](https://youtu.be/upMpPtQuc0c?t=00h31m17s)

[when this blog post came out it was](https://youtu.be/upMpPtQuc0c?t=00h31m21s)

[probably January 24th in most of the](https://youtu.be/upMpPtQuc0c?t=00h31m22s)

[world because this came out](https://youtu.be/upMpPtQuc0c?t=00h31m25s)

[I I was sent the leak earlier this](https://youtu.be/upMpPtQuc0c?t=00h31m28s)

[morning](https://youtu.be/upMpPtQuc0c?t=00h31m30s)

[so it was it was earlyish when it when](https://youtu.be/upMpPtQuc0c?t=00h31m32s)

[it](https://youtu.be/upMpPtQuc0c?t=00h31m35s)

[dropped uh okay that was all of that](https://youtu.be/upMpPtQuc0c?t=00h31m36s)

[silly o'clock in the morning yeah yeah](https://youtu.be/upMpPtQuc0c?t=00h31m40s)

[is he isn't it](https://youtu.be/upMpPtQuc0c?t=00h31m43s)

[like like four or five for you or](https://youtu.be/upMpPtQuc0c?t=00h31m45s)

[something like](https://youtu.be/upMpPtQuc0c?t=00h31m48s)

[that uh okay uh let's see so we want to](https://youtu.be/upMpPtQuc0c?t=00h31m51s)

[go through we want to let's give](https://youtu.be/upMpPtQuc0c?t=00h31m55s)

[ourselves eles a test to play with I](https://youtu.be/upMpPtQuc0c?t=00h31m56s)

[think that's step one](https://youtu.be/upMpPtQuc0c?t=00h31m58s)

[and we'll go from we'll go from there](https://youtu.be/upMpPtQuc0c?t=00h32m00s)

[all right because I think that's](https://youtu.be/upMpPtQuc0c?t=00h32m03s)

[probably the easiest way uh generation](https://youtu.be/upMpPtQuc0c?t=00h32m05s)

[with uh not value type parameter uh](https://youtu.be/upMpPtQuc0c?t=00h32m08s)

[parameter change this parameter with](https://youtu.be/upMpPtQuc0c?t=00h32m16s)

[default value 5 a.m. yeah yeah that's](https://youtu.be/upMpPtQuc0c?t=00h32m19s)

[definitely silly o'clock I almost had a](https://youtu.be/upMpPtQuc0c?t=00h32m23s)

[six :30 a.m. meeting this morning and](https://youtu.be/upMpPtQuc0c?t=00h32m26s)

[thank goodness it got](https://youtu.be/upMpPtQuc0c?t=00h32m28s)

[rescheduled um does not generate](https://youtu.be/upMpPtQuc0c?t=00h32m30s)

[test yeah that's that is very fair okay](https://youtu.be/upMpPtQuc0c?t=00h32m33s)

[so we're gonna have a controller uh](https://youtu.be/upMpPtQuc0c?t=00h32m36s)

[we're going to do](https://youtu.be/upMpPtQuc0c?t=00h32m38s)

[string think we can just do this here if](https://youtu.be/upMpPtQuc0c?t=00h32m41s)

[I remember right because I don't think](https://youtu.be/upMpPtQuc0c?t=00h32m44s)

[the generated code has nullable](https://youtu.be/upMpPtQuc0c?t=00h32m46s)

[reference types turned on I don't](https://youtu.be/upMpPtQuc0c?t=00h32m48s)

[believe I think by default it's](https://youtu.be/upMpPtQuc0c?t=00h32m51s)

[off um and so we expect this to occur is](https://youtu.be/upMpPtQuc0c?t=00h32m54s)

[that intentional or is that just I think](https://youtu.be/upMpPtQuc0c?t=00h32m58s)

[that's somewhat an artifact of the](https://youtu.be/upMpPtQuc0c?t=00h33m01s)

[built-in framework stuff I I think if I](https://youtu.be/upMpPtQuc0c?t=00h33m04s)

[remember right there's a way to turn it](https://youtu.be/upMpPtQuc0c?t=00h33m07s)

[on in](https://youtu.be/upMpPtQuc0c?t=00h33m09s)

[here in these Source](https://youtu.be/upMpPtQuc0c?t=00h33m10s)

[generators yeah because you can build up](https://youtu.be/upMpPtQuc0c?t=00h33m13s)

[the compilation](https://youtu.be/upMpPtQuc0c?t=00h33m15s)

[options and so I believe inside of the](https://youtu.be/upMpPtQuc0c?t=00h33m16s)

[compilation](https://youtu.be/upMpPtQuc0c?t=00h33m19s)

[options uh there's there's something](https://youtu.be/upMpPtQuc0c?t=00h33m21s)

[around one of these Noble context](https://youtu.be/upMpPtQuc0c?t=00h33m24s)

[options I think this is](https://youtu.be/upMpPtQuc0c?t=00h33m26s)

[it yeah so you can like something like](https://youtu.be/upMpPtQuc0c?t=00h33m28s)

[this um gets you gets you turned on to](https://youtu.be/upMpPtQuc0c?t=00h33m32s)

[to be able to have Noble reference type](https://youtu.be/upMpPtQuc0c?t=00h33m37s)

[stuff enabled we just haven't](https://youtu.be/upMpPtQuc0c?t=00h33m39s)

[necessarily turned it on in here yet we](https://youtu.be/upMpPtQuc0c?t=00h33m41s)

[may because you'll know this is still in](https://youtu.be/upMpPtQuc0c?t=00h33m43s)

[my code land we may have to give](https://youtu.be/upMpPtQuc0c?t=00h33m45s)

[ourselves](https://youtu.be/upMpPtQuc0c?t=00h33m47s)

[a](https://youtu.be/upMpPtQuc0c?t=00h33m49s)

[um protected member or something to be](https://youtu.be/upMpPtQuc0c?t=00h33m51s)

[able to to toggle that but we'll start](https://youtu.be/upMpPtQuc0c?t=00h33m53s)

[here because this is this is the first](https://youtu.be/upMpPtQuc0c?t=00h33m56s)

[easy failure case right so that's](https://youtu.be/upMpPtQuc0c?t=00h33m58s)

[namespace controller string null this](https://youtu.be/upMpPtQuc0c?t=00h34m01s)

[test should](https://youtu.be/upMpPtQuc0c?t=00h34m03s)

[fail right red green](https://youtu.be/upMpPtQuc0c?t=00h34m05s)

[testing also great old](https://youtu.be/upMpPtQuc0c?t=00h34m09s)

[shelf uh type name space or end of](https://youtu.be/upMpPtQuc0c?t=00h34m11s)

[definition what I don't remember doing](https://youtu.be/upMpPtQuc0c?t=00h34m14s)

[something stupid oh I did do something](https://youtu.be/upMpPtQuc0c?t=00h34m17s)

[stupid okay how many things open run](https://youtu.be/upMpPtQuc0c?t=00h34m22s)

[test](https://youtu.be/upMpPtQuc0c?t=00h34m26s)

[I think one of the most convincing](https://youtu.be/upMpPtQuc0c?t=00h34m31s)

[arguments to get like AR goggles is so I](https://youtu.be/upMpPtQuc0c?t=00h34m32s)

[can have as many monitors as I want I](https://youtu.be/upMpPtQuc0c?t=00h34m35s)

[can just boom boom boom](https://youtu.be/upMpPtQuc0c?t=00h34m38s)

[boom and then you'll note here this is](https://youtu.be/upMpPtQuc0c?t=00h34m42s)

[this is also one of the nice things that](https://youtu.be/upMpPtQuc0c?t=00h34m45s)

[they do set up is they give you like](https://youtu.be/upMpPtQuc0c?t=00h34m47s)

[reasonable asserts right so they](https://youtu.be/upMpPtQuc0c?t=00h34m49s)

[actually like the built-in Library did](https://youtu.be/upMpPtQuc0c?t=00h34m52s)

[not match diff shown right so here was](https://youtu.be/upMpPtQuc0c?t=00h34m55s)

[what it was expected and it renders it](https://youtu.be/upMpPtQuc0c?t=00h34m59s)

[with like a g diff so for people who are](https://youtu.be/upMpPtQuc0c?t=00h35m00s)

[familiar with seeing that speaking of](https://youtu.be/upMpPtQuc0c?t=00h35m03s)

[get diffs video coming out I think I'm](https://youtu.be/upMpPtQuc0c?t=00h35m05s)

[almost done with it probably tomorrow on](https://youtu.be/upMpPtQuc0c?t=00h35m09s)

[cloud patches](https://youtu.be/upMpPtQuc0c?t=00h35m12s)

[so they are cool they are awesome I love](https://youtu.be/upMpPtQuc0c?t=00h35m15s)

[it so we want to say this test pass and](https://youtu.be/upMpPtQuc0c?t=00h35m18s)

[this test not suck so okay so now now](https://youtu.be/upMpPtQuc0c?t=00h35m20s)

[that we've got that I believe what we](https://youtu.be/upMpPtQuc0c?t=00h35m23s)

[can do is we can come back into](https://youtu.be/upMpPtQuc0c?t=00h35m25s)

[[Music]](https://youtu.be/upMpPtQuc0c?t=00h35m26s)

[to uh we probably want to just grab it](https://youtu.be/upMpPtQuc0c?t=00h35m29s)

[here](https://youtu.be/upMpPtQuc0c?t=00h35m32s)

[right I think and now we can just debug](https://youtu.be/upMpPtQuc0c?t=00h35m33s)

[the test and this is probably the](https://youtu.be/upMpPtQuc0c?t=00h35m36s)

[easiest way to debug Source generators](https://youtu.be/upMpPtQuc0c?t=00h35m38s)

[you will note the other way of doing](https://youtu.be/upMpPtQuc0c?t=00h35m40s)

[this is](https://youtu.be/upMpPtQuc0c?t=00h35m42s)

[with](https://youtu.be/upMpPtQuc0c?t=00h35m45s)

[um is I I left myself a hook in one of](https://youtu.be/upMpPtQuc0c?t=00h35m48s)

[these I think it's here you can](https://youtu.be/upMpPtQuc0c?t=00h35m51s)

[uncomment this line as well so if you](https://youtu.be/upMpPtQuc0c?t=00h35m53s)

[actually want to test it like inside of](https://youtu.be/upMpPtQuc0c?t=00h35m55s)

[a CS Pro type situ you turn on debugger](https://youtu.be/upMpPtQuc0c?t=00h35m57s)

[launch it prompts Visual Studio you](https://youtu.be/upMpPtQuc0c?t=00h35m59s)

[attach to it in a way you go and then](https://youtu.be/upMpPtQuc0c?t=00h36m02s)

[you're actually inside of um the process](https://youtu.be/upMpPtQuc0c?t=00h36m04s)

[that loaded I saw that comment out but I](https://youtu.be/upMpPtQuc0c?t=00h36m08s)

[wasn't sure how to use it yeah so this](https://youtu.be/upMpPtQuc0c?t=00h36m10s)

[would be if we wanted to debug these](https://youtu.be/upMpPtQuc0c?t=00h36m13s)

[guys up here but in general the tests](https://youtu.be/upMpPtQuc0c?t=00h36m15s)

[the the unit tests make our life much](https://youtu.be/upMpPtQuc0c?t=00h36m18s)

[easier so we just start there right](https://youtu.be/upMpPtQuc0c?t=00h36m21s)

[because most of the time you can get](https://youtu.be/upMpPtQuc0c?t=00h36m24s)

[yourself away with with with doing this](https://youtu.be/upMpPtQuc0c?t=00h36m25s)

[okay so let's see what you got](https://youtu.be/upMpPtQuc0c?t=00h36m27s)

[so this guy here so this got us our](https://youtu.be/upMpPtQuc0c?t=00h36m30s)

[attribute that we can see here and](https://youtu.be/upMpPtQuc0c?t=00h36m34s)

[there's a whole bunch of stuff in it](https://youtu.be/upMpPtQuc0c?t=00h36m37s)

[right we're going to skip that for now](https://youtu.be/upMpPtQuc0c?t=00h36m39s)

[so you went after the named arguments](https://youtu.be/upMpPtQuc0c?t=00h36m41s)

[which in this case there are](https://youtu.be/upMpPtQuc0c?t=00h36m43s)

[none real quick did](https://youtu.be/upMpPtQuc0c?t=00h36m44s)

[I did I actually set my test up](https://youtu.be/upMpPtQuc0c?t=00h36m47s)

[properly see I didn't set my test up](https://youtu.be/upMpPtQuc0c?t=00h36m50s)

[properly and you didn't yell at me why](https://youtu.be/upMpPtQuc0c?t=00h36m53s)

[didn't you yell at me okay so step one](https://youtu.be/upMpPtQuc0c?t=00h36m55s)

[when everything's Orange it's a little](https://youtu.be/upMpPtQuc0c?t=00h36m57s)

[harder for me to read I don't have my](https://youtu.be/upMpPtQuc0c?t=00h36m58s)

[color I know that's one of the things](https://youtu.be/upMpPtQuc0c?t=00h37m01s)

[there's there's theoretically support](https://youtu.be/upMpPtQuc0c?t=00h37m05s)

[for this though now right because they](https://youtu.be/upMpPtQuc0c?t=00h37m07s)

[added the cool stuff for like Rex and](https://youtu.be/upMpPtQuc0c?t=00h37m09s)

[whatnot where it can parse the strings](https://youtu.be/upMpPtQuc0c?t=00h37m12s)

[out for you in theory something is that](https://youtu.be/upMpPtQuc0c?t=00h37m13s)

[that is now Within](https://youtu.be/upMpPtQuc0c?t=00h37m17s)

[Reach like the groundwork has been laate](https://youtu.be/upMpPtQuc0c?t=00h37m19s)

[it's not there it it would be very slick](https://youtu.be/upMpPtQuc0c?t=00h37m22s)

[there' have to be probably some way to](https://youtu.be/upMpPtQuc0c?t=00h37m25s)

[denote that I expect this to be a c](https://youtu.be/upMpPtQuc0c?t=00h37m27s)

[snippet or something um okay I was going](https://youtu.be/upMpPtQuc0c?t=00h37m29s)

[to go to the generator test and I was](https://youtu.be/upMpPtQuc0c?t=00h37m32s)

[just going to poach markdown style](https://youtu.be/upMpPtQuc0c?t=00h37m34s)

[syntax some rostering literals with](https://youtu.be/upMpPtQuc0c?t=00h37m37s)

[some postfix yeah ring literals have to](https://youtu.be/upMpPtQuc0c?t=00h37m40s)

[be on their own nine seems to set up](https://youtu.be/upMpPtQuc0c?t=00h37m43s)

[kind of perfectly I I agree okay so](https://youtu.be/upMpPtQuc0c?t=00h37m46s)

[there's that so](https://youtu.be/upMpPtQuc0c?t=00h37m49s)

[now now I think your named argues I](https://youtu.be/upMpPtQuc0c?t=00h37m52s)

[think where your setup is going to fail](https://youtu.be/upMpPtQuc0c?t=00h37m54s)

[is when we do it without the named](https://youtu.be/upMpPtQuc0c?t=00h37m56s)

[arguments like I think we can make this](https://youtu.be/upMpPtQuc0c?t=00h37m58s)

[work for a named argument and then I](https://youtu.be/upMpPtQuc0c?t=00h38m00s)

[think it's going to probably fall apart](https://youtu.be/upMpPtQuc0c?t=00h38m02s)

[so named arguments now has a length of](https://youtu.be/upMpPtQuc0c?t=00h38m04s)

[one](https://youtu.be/upMpPtQuc0c?t=00h38m06s)

[aah right and I don't know if you can](https://youtu.be/upMpPtQuc0c?t=00h38m08s)

[see that but that does have values](https://youtu.be/upMpPtQuc0c?t=00h38m10s)

[so okay um](https://youtu.be/upMpPtQuc0c?t=00h38m15s)

[Wow Let's see is your Boolean correct](https://youtu.be/upMpPtQuc0c?t=00h38m20s)

[false so that's that's a problem](https://youtu.be/upMpPtQuc0c?t=00h38m24s)

[uh I'm going to do this](https://youtu.be/upMpPtQuc0c?t=00h38m27s)

[inop yeah](https://youtu.be/upMpPtQuc0c?t=00h38m29s)

[well you you said you hadn't tested it](https://youtu.be/upMpPtQuc0c?t=00h38m31s)

[yet so I mean if you if you wrote a a](https://youtu.be/upMpPtQuc0c?t=00h38m34s)

[source uh or a source generator and you](https://youtu.be/upMpPtQuc0c?t=00h38m36s)

[got it right the first time without any](https://youtu.be/upMpPtQuc0c?t=00h38m38s)

[effort I was going to be a little](https://youtu.be/upMpPtQuc0c?t=00h38m42s)

[shocked](https://youtu.be/upMpPtQuc0c?t=00h38m44s)

[because I think only people who've built](https://youtu.be/upMpPtQuc0c?t=00h38m45s)

[a ton of these can actually pull that](https://youtu.be/upMpPtQuc0c?t=00h38m48s)

[kind of stuff off okay so let's do named](https://youtu.be/upMpPtQuc0c?t=00h38m49s)

[argument down](https://youtu.be/upMpPtQuc0c?t=00h38m52s)

[here okay so](https://youtu.be/upMpPtQuc0c?t=00h38m54s)

[because you went value](https://youtu.be/upMpPtQuc0c?t=00h38m58s)

[value and the problem is is that is](https://youtu.be/upMpPtQuc0c?t=00h39m02s)

[not kind](https://youtu.be/upMpPtQuc0c?t=00h39m07s)

[error well that's not](https://youtu.be/upMpPtQuc0c?t=00h39m10s)

[useful](https://youtu.be/upMpPtQuc0c?t=00h39m13s)

[uh typed constant is not array use value](https://youtu.be/upMpPtQuc0c?t=00h39m14s)

[property oh well that kind of makes](https://youtu.be/upMpPtQuc0c?t=00h39m18s)

[sense](https://youtu.be/upMpPtQuc0c?t=00h39m21s)

[um is null true kind](https://youtu.be/upMpPtQuc0c?t=00h39m23s)

[eror I have a feeling this means we have](https://youtu.be/upMpPtQuc0c?t=00h39m28s)

[messed something](https://youtu.be/upMpPtQuc0c?t=00h39m31s)

[up but I'm not](https://youtu.be/upMpPtQuc0c?t=00h39m35s)

[clear as to what so I'm going to just](https://youtu.be/upMpPtQuc0c?t=00h39m38s)

[take](https://youtu.be/upMpPtQuc0c?t=00h39m41s)

[this because sometimes there's wisdom in](https://youtu.be/upMpPtQuc0c?t=00h39m42s)

[just doing](https://youtu.be/upMpPtQuc0c?t=00h39m44s)

[this okay that seems fine](https://youtu.be/upMpPtQuc0c?t=00h39m52s)

[uh where is](https://youtu.be/upMpPtQuc0c?t=00h39m57s)

[my looking to see if I had](https://youtu.be/upMpPtQuc0c?t=00h40m04s)

[um we've got curious how where it's](https://youtu.be/upMpPtQuc0c?t=00h40m10s)

[getting its Global using from oh it's](https://youtu.be/upMpPtQuc0c?t=00h40m13s)

[not getting Global using it's because](https://youtu.be/upMpPtQuc0c?t=00h40m15s)

[it's](https://youtu.be/upMpPtQuc0c?t=00h40m17s)

[here wait a](https://youtu.be/upMpPtQuc0c?t=00h40m19s)

[minute oh that's that's probably because](https://youtu.be/upMpPtQuc0c?t=00h40m22s)

[we're in the middle of a debug session](https://youtu.be/upMpPtQuc0c?t=00h40m24s)

[let's stop this well hold on before we](https://youtu.be/upMpPtQuc0c?t=00h40m26s)

[get too carried away go back let's go](https://youtu.be/upMpPtQuc0c?t=00h40m30s)

[back and do a little](https://youtu.be/upMpPtQuc0c?t=00h40m33s)

[investigativ on here so if we go I also](https://youtu.be/upMpPtQuc0c?t=00h40m35s)

[changed the CSR reference to the test](https://youtu.be/upMpPtQuc0c?t=00h40m38s)

[rator project because I wasn't able to](https://youtu.be/upMpPtQuc0c?t=00h40m41s)

[add the I was struggling to add the enum](https://youtu.be/upMpPtQuc0c?t=00h40m43s)

[to](https://youtu.be/upMpPtQuc0c?t=00h40m45s)

[the attribute otherwise oh that I might](https://youtu.be/upMpPtQuc0c?t=00h40m47s)

[be messing up too yeah that's probably](https://youtu.be/upMpPtQuc0c?t=00h40m50s)

[part of the problem so the comment](https://youtu.be/upMpPtQuc0c?t=00h40m52s)

[earlier about how you don't want a hard](https://youtu.be/upMpPtQuc0c?t=00h40m54s)

[reference between the](https://youtu.be/upMpPtQuc0c?t=00h40m55s)

[these that is very](https://youtu.be/upMpPtQuc0c?t=00h40m58s)

[plausible so it wasn't in it was in mock](https://youtu.be/upMpPtQuc0c?t=00h41m02s)

[automach I removed there was on the test](https://youtu.be/upMpPtQuc0c?t=00h41m04s)

[generator reference it had output to](https://youtu.be/upMpPtQuc0c?t=00h41m07s)

[item type to analyzer and reference](https://youtu.be/upMpPtQuc0c?t=00h41m10s)

[output assembly false and I oh killed](https://youtu.be/upMpPtQuc0c?t=00h41m11s)

[that yeah online what line are we](https://youtu.be/upMpPtQuc0c?t=00h41m17s)

[on I was going to go back here and grab](https://youtu.be/upMpPtQuc0c?t=00h41m21s)

[it](https://youtu.be/upMpPtQuc0c?t=00h41m25s)

[yeah that line we actually](https://youtu.be/upMpPtQuc0c?t=00h41m26s)

[want I'd love to learn how to reference](https://youtu.be/upMpPtQuc0c?t=00h41m30s)

[my en](https://youtu.be/upMpPtQuc0c?t=00h41m33s)

[then well I shall demonstrate so let's](https://youtu.be/upMpPtQuc0c?t=00h41m34s)

[go](https://youtu.be/upMpPtQuc0c?t=00h41m38s)

[here](https://youtu.be/upMpPtQuc0c?t=00h41m39s)

[and uh that's not it it was this line](https://youtu.be/upMpPtQuc0c?t=00h41m42s)

[was](https://youtu.be/upMpPtQuc0c?t=00h41m46s)

[it numbers but I know why do I not have](https://youtu.be/upMpPtQuc0c?t=00h41m47s)

[line numbers](https://youtu.be/upMpPtQuc0c?t=00h41m50s)

[turn I've installed too many updates](https://youtu.be/upMpPtQuc0c?t=00h41m51s)

[standby line num should be I I don't](https://youtu.be/upMpPtQuc0c?t=00h41m55s)

[understand why line numbers are not](https://youtu.be/upMpPtQuc0c?t=00h41m58s)

[enabled for all languages by](https://youtu.be/upMpPtQuc0c?t=00h42m01s)

[default that feels like something that](https://youtu.be/upMpPtQuc0c?t=00h42m03s)

[should](https://youtu.be/upMpPtQuc0c?t=00h42m05s)

[just always be](https://youtu.be/upMpPtQuc0c?t=00h42m07s)

[there so what did I break just so I'm](https://youtu.be/upMpPtQuc0c?t=00h42m09s)

[aware of what I](https://youtu.be/upMpPtQuc0c?t=00h42m13s)

[broke so in this case when you are when](https://youtu.be/upMpPtQuc0c?t=00h42m14s)

[you're bringing in a project um the by](https://youtu.be/upMpPtQuc0c?t=00h42m18s)

[by deleting these you're making it set](https://youtu.be/upMpPtQuc0c?t=00h42m22s)

[up as a project to project reference so](https://youtu.be/upMpPtQuc0c?t=00h42m25s)

[if you were to run a Nate or a net pack](https://youtu.be/upMpPtQuc0c?t=00h42m28s)

[on this it's going to think ah okay](https://youtu.be/upMpPtQuc0c?t=00h42m31s)

[we're going to have uh assembly a](https://youtu.be/upMpPtQuc0c?t=00h42m34s)

[reference assembly B and that's not](https://youtu.be/upMpPtQuc0c?t=00h42m36s)

[actually what we want it specifically](https://youtu.be/upMpPtQuc0c?t=00h42m39s)

[this whole idea of reference the output](https://youtu.be/upMpPtQuc0c?t=00h42m42s)

[assembly like we want this guy to know](https://youtu.be/upMpPtQuc0c?t=00h42m44s)

[about the analyzer project for the](https://youtu.be/upMpPtQuc0c?t=00h42m47s)

[purposes of packing but we don't want it](https://youtu.be/upMpPtQuc0c?t=00h42m49s)

[to pack up this test generator project](https://youtu.be/upMpPtQuc0c?t=00h42m52s)

[because uh mock automach we really don't](https://youtu.be/upMpPtQuc0c?t=00h42m55s)

[want it to have any](https://youtu.be/upMpPtQuc0c?t=00h42m58s)

[dependencies right now we take uh we we](https://youtu.be/upMpPtQuc0c?t=00h43m01s)

[take a couple like on non-blocking](https://youtu.be/upMpPtQuc0c?t=00h43m04s)

[collection and value Tuple and on mock](https://youtu.be/upMpPtQuc0c?t=00h43m07s)

[obviously those are acceptable](https://youtu.be/upMpPtQuc0c?t=00h43m09s)

[dependencies and personally if we could](https://youtu.be/upMpPtQuc0c?t=00h43m11s)

[get rid of non-blocking that'd be even](https://youtu.be/upMpPtQuc0c?t=00h43m13s)

[cooler but don't want rewrite that so we](https://youtu.be/upMpPtQuc0c?t=00h43m14s)

[we want as few dependencies as possible](https://youtu.be/upMpPtQuc0c?t=00h43m18s)

[so that we aren't reliant on other](https://youtu.be/upMpPtQuc0c?t=00h43m20s)

[Frameworks or similar but we still want](https://youtu.be/upMpPtQuc0c?t=00h43m22s)

[Dot pack to know that hey when we net](https://youtu.be/upMpPtQuc0c?t=00h43m25s)

[pack this project treat this guy here as](https://youtu.be/upMpPtQuc0c?t=00h43m28s)

[an analyzer and do the needful for us](https://youtu.be/upMpPtQuc0c?t=00h43m32s)

[right so that's part of](https://youtu.be/upMpPtQuc0c?t=00h43m36s)

[how this and this get us all the way in](https://youtu.be/upMpPtQuc0c?t=00h43m37s)

[got it and that explains why I couldn't](https://youtu.be/upMpPtQuc0c?t=00h43m42s)

[see my en when I was setting it correct](https://youtu.be/upMpPtQuc0c?t=00h43m43s)

[well and that's also why](https://youtu.be/upMpPtQuc0c?t=00h43m46s)

[um this guy here did you add a](https://youtu.be/upMpPtQuc0c?t=00h43m50s)

[reference how is he able to to see this](https://youtu.be/upMpPtQuc0c?t=00h43m54s)

[no cuz it's in it's in that class it's](https://youtu.be/upMpPtQuc0c?t=00h43m58s)

[in that uh so it's down right there yeah](https://youtu.be/upMpPtQuc0c?t=00h44m01s)

[oh so here's the thing is we don't want](https://youtu.be/upMpPtQuc0c?t=00h44m04s)

[this enum here we want this enum up](https://youtu.be/upMpPtQuc0c?t=00h44m06s)

[here got it see I was thinking you want](https://youtu.be/upMpPtQuc0c?t=00h44m10s)

[it in that other one and then just](https://youtu.be/upMpPtQuc0c?t=00h44m13s)

[reference it in the](https://youtu.be/upMpPtQuc0c?t=00h44m14s)

[attribute no other way around because we](https://youtu.be/upMpPtQuc0c?t=00h44m17s)

[want people to be able to](https://youtu.be/upMpPtQuc0c?t=00h44m20s)

[leverage](https://youtu.be/upMpPtQuc0c?t=00h44m23s)

[um to Leever](https://youtu.be/upMpPtQuc0c?t=00h44m25s)

[to this is the dll that they're going to](https://youtu.be/upMpPtQuc0c?t=00h44m27s)

[be referencing so anything we want](https://youtu.be/upMpPtQuc0c?t=00h44m29s)

[people to type into their test projects](https://youtu.be/upMpPtQuc0c?t=00h44m32s)

[needs to be in this](https://youtu.be/upMpPtQuc0c?t=00h44m34s)

[assembly which I think is perfectly fine](https://youtu.be/upMpPtQuc0c?t=00h44m35s)

[but now you are quickly going to see ah](https://youtu.be/upMpPtQuc0c?t=00h44m39s)

[we now have different problem right is](https://youtu.be/upMpPtQuc0c?t=00h44m41s)

[now this guy wants to reference it um](https://youtu.be/upMpPtQuc0c?t=00h44m44s)

[and you'll know this is part of why we](https://youtu.be/upMpPtQuc0c?t=00h44m47s)

[ended up with um and I'll turn off my](https://youtu.be/upMpPtQuc0c?t=00h44m49s)

[breakpoint so you can see it magical](https://youtu.be/upMpPtQuc0c?t=00h44m51s)

[strings this magical string here and](https://youtu.be/upMpPtQuc0c?t=00h44m53s)

[it's to some](https://youtu.be/upMpPtQuc0c?t=00h44m57s)

[degree no co-pilot no](https://youtu.be/upMpPtQuc0c?t=00h44m59s)

[no](https://youtu.be/upMpPtQuc0c?t=00h45m02s)

[um I think what we're going to do is](https://youtu.be/upMpPtQuc0c?t=00h45m05s)

[we're just G to break this guy](https://youtu.be/upMpPtQuc0c?t=00h45m07s)

[out because I want to](https://youtu.be/upMpPtQuc0c?t=00h45m09s)

[see I want to see what this comes](https://youtu.be/upMpPtQuc0c?t=00h45m13s)

[through as um and then we're just going](https://youtu.be/upMpPtQuc0c?t=00h45m15s)

[to comment this for the](https://youtu.be/upMpPtQuc0c?t=00h45m18s)

[moment because normally I just do it](https://youtu.be/upMpPtQuc0c?t=00h45m21s)

[with my immediate window but you know](https://youtu.be/upMpPtQuc0c?t=00h45m23s)

[what we're going to do this since that](https://youtu.be/upMpPtQuc0c?t=00h45m24s)

[didn't compile](https://youtu.be/upMpPtQuc0c?t=00h45m26s)

[before and then we'll go here we'll go](https://youtu.be/upMpPtQuc0c?t=00h45m27s)

[here we'll](https://youtu.be/upMpPtQuc0c?t=00h45m30s)

[debug uh nope what did I do oh so I](https://youtu.be/upMpPtQuc0c?t=00h45m32s)

[didn't oh actually hey co-pilot do it](https://youtu.be/upMpPtQuc0c?t=00h45m44s)

[for](https://youtu.be/upMpPtQuc0c?t=00h45m47s)

[me dang](https://youtu.be/upMpPtQuc0c?t=00h45m49s)

[it trigger inline suggestion I've been](https://youtu.be/upMpPtQuc0c?t=00h45m51s)

[surprisingly](https://youtu.be/upMpPtQuc0c?t=00h45m55s)

[that's funny I've been surprisingly](https://youtu.be/upMpPtQuc0c?t=00h45m56s)

[unimpressed with cop's ability to](https://youtu.be/upMpPtQuc0c?t=00h45m58s)

[generate summaries I've tried it quite a](https://youtu.be/upMpPtQuc0c?t=00h46m00s)

[few times and I have rarely found that](https://youtu.be/upMpPtQuc0c?t=00h46m02s)

[it writes it for me it's really good](https://youtu.be/upMpPtQuc0c?t=00h46m05s)

[writing comments above but not actually](https://youtu.be/upMpPtQuc0c?t=00h46m07s)

[summaries and filling out all the things](https://youtu.be/upMpPtQuc0c?t=00h46m09s)

[maybe that's an indication](https://youtu.be/upMpPtQuc0c?t=00h46m11s)

[that most people don't do it and](https://youtu.be/upMpPtQuc0c?t=00h46m13s)

[therefore it's testing data is](https://youtu.be/upMpPtQuc0c?t=00h46m15s)

[crap or it's training data is](https://youtu.be/upMpPtQuc0c?t=00h46m17s)

[crap okay so that got us to nowhere](https://youtu.be/upMpPtQuc0c?t=00h46m21s)

[so I would like to](https://youtu.be/upMpPtQuc0c?t=00h46m26s)

[do the nope copy go to our immediate](https://youtu.be/upMpPtQuc0c?t=00h46m28s)

[paste right so that got us to there we](https://youtu.be/upMpPtQuc0c?t=00h46m33s)

[do dot](https://youtu.be/upMpPtQuc0c?t=00h46m36s)

[value that gets](https://youtu.be/upMpPtQuc0c?t=00h46m37s)

[us boom bo boom okay so we can see we've](https://youtu.be/upMpPtQuc0c?t=00h46m41s)

[got a typed](https://youtu.be/upMpPtQuc0c?t=00h46m46s)

[construct fact that the kind shows erir](https://youtu.be/upMpPtQuc0c?t=00h46m48s)

[is concerning to me](https://youtu.be/upMpPtQuc0c?t=00h46m52s)

[I'm wondering if that indicates that the](https://youtu.be/upMpPtQuc0c?t=00h46m59s)

[thing fails](https://youtu.be/upMpPtQuc0c?t=00h47m00s)

[to fails to account for](https://youtu.be/upMpPtQuc0c?t=00h47m04s)

[compilation uh because this does run](https://youtu.be/upMpPtQuc0c?t=00h47m11s)

[async uh let's](https://youtu.be/upMpPtQuc0c?t=00h47m14s)

[see I kind of want to check this and see](https://youtu.be/upMpPtQuc0c?t=00h47m18s)

[at the point it](https://youtu.be/upMpPtQuc0c?t=00h47m21s)

[does does this thing actually compile](https://youtu.be/upMpPtQuc0c?t=00h47m23s)

[file verify](https://youtu.be/upMpPtQuc0c?t=00h47m25s)

[Diagnostics with inheritance applied I'm](https://youtu.be/upMpPtQuc0c?t=00h47m30s)

[trying to look at where this where this](https://youtu.be/upMpPtQuc0c?t=00h47m32s)

[guy](https://youtu.be/upMpPtQuc0c?t=00h47m35s)

[runs I are you thinking the updated](https://youtu.be/upMpPtQuc0c?t=00h47m37s)

[things where to reference this aren't](https://youtu.be/upMpPtQuc0c?t=00h47m40s)

[actually there when it's turn test it's](https://youtu.be/upMpPtQuc0c?t=00h47m41s)

[just executing old stuff I'm I'm](https://youtu.be/upMpPtQuc0c?t=00h47m43s)

[thinking there is a compilation issue](https://youtu.be/upMpPtQuc0c?t=00h47m45s)

[and I just can't see](https://youtu.be/upMpPtQuc0c?t=00h47m49s)

[it it should be](https://youtu.be/upMpPtQuc0c?t=00h47m51s)

[fine I don't don't see the](https://youtu.be/upMpPtQuc0c?t=00h47m54s)

[failure like it's not obvious to me](https://youtu.be/upMpPtQuc0c?t=00h47m59s)

[where the failure](https://youtu.be/upMpPtQuc0c?t=00h48m01s)

[is because this](https://youtu.be/upMpPtQuc0c?t=00h48m05s)

[code should work and I mean we can we](https://youtu.be/upMpPtQuc0c?t=00h48m07s)

[can test this in a slightly different](https://youtu.be/upMpPtQuc0c?t=00h48m10s)

[way as well](https://youtu.be/upMpPtQuc0c?t=00h48m13s)

[um the first thing it's hits is syntax](https://youtu.be/upMpPtQuc0c?t=00h48m16s)

[receiver before hits the generator](https://youtu.be/upMpPtQuc0c?t=00h48m19s)

[right](https://youtu.be/upMpPtQuc0c?t=00h48m23s)

[uh generator registers the syntax](https://youtu.be/upMpPtQuc0c?t=00h48m24s)

[receiver so the first thing it hits is](https://youtu.be/upMpPtQuc0c?t=00h48m27s)

[the um ini I added something into the](https://youtu.be/upMpPtQuc0c?t=00h48m31s)

[source generator](https://youtu.be/upMpPtQuc0c?t=00h48m35s)

[that is causing something with the](https://youtu.be/upMpPtQuc0c?t=00h48m37s)

[syntax receiver no because the it's it's](https://youtu.be/upMpPtQuc0c?t=00h48m39s)

[parsing um and because remember](https://youtu.be/upMpPtQuc0c?t=00h48m42s)

[sometimes the source generator runs and](https://youtu.be/upMpPtQuc0c?t=00h48m45s)

[the code that's being fed in isn't in a](https://youtu.be/upMpPtQuc0c?t=00h48m47s)

[compilable state right because the code](https://youtu.be/upMpPtQuc0c?t=00h48m49s)

[fed into Source generators isn't](https://youtu.be/upMpPtQuc0c?t=00h48m53s)

[actually expected to work because](https://youtu.be/upMpPtQuc0c?t=00h48m55s)

[sometimes you're writing code knowing](https://youtu.be/upMpPtQuc0c?t=00h48m58s)

[that a source generator is going to fill](https://youtu.be/upMpPtQuc0c?t=00h49m00s)

[in some blanks that actually make the](https://youtu.be/upMpPtQuc0c?t=00h49m01s)

[final result compile so the source](https://youtu.be/upMpPtQuc0c?t=00h49m03s)

[generator can't make the assumption that](https://youtu.be/upMpPtQuc0c?t=00h49m06s)

[the input coming in is in a compilable](https://youtu.be/upMpPtQuc0c?t=00h49m08s)

[state and that's where it gets weird](https://youtu.be/upMpPtQuc0c?t=00h49m13s)

[right so notet uh new oh how about MK](https://youtu.be/upMpPtQuc0c?t=00h49m15s)

[dur](https://youtu.be/upMpPtQuc0c?t=00h49m21s)

[uh gen test](https://youtu.be/upMpPtQuc0c?t=00h49m22s)

[right uh net new xunit](https://youtu.be/upMpPtQuc0c?t=00h49m27s)

[[Music]](https://youtu.be/upMpPtQuc0c?t=00h49m34s)

[boom that is](https://youtu.be/upMpPtQuc0c?t=00h49m41s)

[not that's what I wanted thank you very](https://youtu.be/upMpPtQuc0c?t=00h49m45s)

[much okay launch just going to we're](https://youtu.be/upMpPtQuc0c?t=00h49m48s)

[just going to plug this in real quick](https://youtu.be/upMpPtQuc0c?t=00h49m51s)

[and see what I'm what I'm messing up up](https://youtu.be/upMpPtQuc0c?t=00h49m52s)

[on because I think that should](https://youtu.be/upMpPtQuc0c?t=00h49m58s)

[compile oh but I can't just plug this in](https://youtu.be/upMpPtQuc0c?t=00h50m01s)

[because I want to test a new enum that's](https://youtu.be/upMpPtQuc0c?t=00h50m05s)

[not I'd have to build a](https://youtu.be/upMpPtQuc0c?t=00h50m07s)

[package come back to that idea okay come](https://youtu.be/upMpPtQuc0c?t=00h50m10s)

[back to that idea okay so immediate](https://youtu.be/upMpPtQuc0c?t=00h50m13s)

[window because I I I sort of was](https://youtu.be/upMpPtQuc0c?t=00h50m15s)

[expecting that we should be](https://youtu.be/upMpPtQuc0c?t=00h50m18s)

[getting a value from that](https://youtu.be/upMpPtQuc0c?t=00h50m20s)

[let's go look at this guy you might be](https://youtu.be/upMpPtQuc0c?t=00h50m27s)

[having too high confidence in what I](https://youtu.be/upMpPtQuc0c?t=00h50m29s)

[wrote I](https://youtu.be/upMpPtQuc0c?t=00h50m30s)

[mean that okay fair let's let's double](https://youtu.be/upMpPtQuc0c?t=00h50m33s)

[check nothing wrong with that nothing](https://youtu.be/upMpPtQuc0c?t=00h50m37s)

[wrong with](https://youtu.be/upMpPtQuc0c?t=00h50m39s)

[that what did you change](https://youtu.be/upMpPtQuc0c?t=00h50m40s)

[here uh that's just the moving of a pen](https://youtu.be/upMpPtQuc0c?t=00h50m44s)

[okay](https://youtu.be/upMpPtQuc0c?t=00h50m47s)

[great oh this is oh you pulled out the](https://youtu.be/upMpPtQuc0c?t=00h50m49s)

[Constructor test](https://youtu.be/upMpPtQuc0c?t=00h50m52s)

[attribute](https://youtu.be/upMpPtQuc0c?t=00h50m54s)

[ah](https://youtu.be/upMpPtQuc0c?t=00h50m58s)

[[Music]](https://youtu.be/upMpPtQuc0c?t=00h51m00s)

[ah I can't see it clearly if you had](https://youtu.be/upMpPtQuc0c?t=00h51m01s)

[done that already I had I had this is](https://youtu.be/upMpPtQuc0c?t=00h51m03s)

[probably not very obvious okay okay okay](https://youtu.be/upMpPtQuc0c?t=00h51m07s)

[oh there in that if I think I see it now](https://youtu.be/upMpPtQuc0c?t=00h51m10s)

[so this guy here so one of the things](https://youtu.be/upMpPtQuc0c?t=00h51m13s)

[that's worth noting is when you're](https://youtu.be/upMpPtQuc0c?t=00h51m15s)

[looking at it and I'm I'm going to try](https://youtu.be/upMpPtQuc0c?t=00h51m17s)

[to not butcher my terminology here](https://youtu.be/upMpPtQuc0c?t=00h51m19s)

[is when viewing the source code there is](https://youtu.be/upMpPtQuc0c?t=00h51m24s)

[the the grammatical form where it's just](https://youtu.be/upMpPtQuc0c?t=00h51m27s)

[kind of looking at individual tokens and](https://youtu.be/upMpPtQuc0c?t=00h51m31s)

[then there's like the type resolved form](https://youtu.be/upMpPtQuc0c?t=00h51m33s)

[right the grammatical form is cheap to](https://youtu.be/upMpPtQuc0c?t=00h51m36s)

[inspect because we're just looking at](https://youtu.be/upMpPtQuc0c?t=00h51m38s)

[the tokens around us and we're not](https://youtu.be/upMpPtQuc0c?t=00h51m40s)

[really concerned but when you say hey I](https://youtu.be/upMpPtQuc0c?t=00h51m42s)

[want to resolve a type that requires](https://youtu.be/upMpPtQuc0c?t=00h51m44s)

[like some work to happen so we going and](https://youtu.be/upMpPtQuc0c?t=00h51m46s)

[pulling out this this uh type here](https://youtu.be/upMpPtQuc0c?t=00h51m52s)

[this is something that we only do once](https://youtu.be/upMpPtQuc0c?t=00h51m56s)

[we've gotten all the way down into here](https://youtu.be/upMpPtQuc0c?t=00h51m58s)

[so I think this is actually probably](https://youtu.be/upMpPtQuc0c?t=00h52m01s)

[where we want to grab this let's go back](https://youtu.be/upMpPtQuc0c?t=00h52m03s)

[up here because this this is probably](https://youtu.be/upMpPtQuc0c?t=00h52m05s)

[going to get us a lot](https://youtu.be/upMpPtQuc0c?t=00h52m06s)

[closer okay come on Kevin that should](https://youtu.be/upMpPtQuc0c?t=00h52m12s)

[have been the first place you look what](https://youtu.be/upMpPtQuc0c?t=00h52m14s)

[did what did I write well](https://youtu.be/upMpPtQuc0c?t=00h52m15s)

[yeah in retrospect not not horrible okay](https://youtu.be/upMpPtQuc0c?t=00h52m19s)

[so we get into here get our type info](https://youtu.be/upMpPtQuc0c?t=00h52m22s)

[and we step through and I think we just](https://youtu.be/upMpPtQuc0c?t=00h52m26s)

[fall into here right so now Target type](https://youtu.be/upMpPtQuc0c?t=00h52m28s)

[gives](https://youtu.be/upMpPtQuc0c?t=00h52m31s)

[us uh our type info so this guy here the](https://youtu.be/upMpPtQuc0c?t=00h52m32s)

[class declaration is looking at the](https://youtu.be/upMpPtQuc0c?t=00h52m36s)

[attribute list selecting many and](https://youtu.be/upMpPtQuc0c?t=00h52m38s)

[is pulling out the type info where it is](https://youtu.be/upMpPtQuc0c?t=00h52m42s)

[where the name of the attribute is](https://youtu.be/upMpPtQuc0c?t=00h52m46s)

[Constructor test attribute right so it's](https://youtu.be/upMpPtQuc0c?t=00h52m48s)

[intentionally hunting things so in](https://youtu.be/upMpPtQuc0c?t=00h52m51s)

[theory if somebody else made a](https://youtu.be/upMpPtQuc0c?t=00h52m53s)

[Constructor test attribute we would](https://youtu.be/upMpPtQuc0c?t=00h52m54s)

[match on that and that would potentially](https://youtu.be/upMpPtQuc0c?t=00h52m56s)

[be](https://youtu.be/upMpPtQuc0c?t=00h52m58s)

[bad right we should in theory maybe test](https://youtu.be/upMpPtQuc0c?t=00h52m59s)

[on more than just the type name maybe we](https://youtu.be/upMpPtQuc0c?t=00h53m03s)

[should test on the name space as well](https://youtu.be/upMpPtQuc0c?t=00h53m04s)

[because if they make one with the same](https://youtu.be/upMpPtQuc0c?t=00h53m06s)

[name and the same name space they](https://youtu.be/upMpPtQuc0c?t=00h53m08s)

[deserve what they get in this case this](https://youtu.be/upMpPtQuc0c?t=00h53m09s)

[is kind this could be accidental so](https://youtu.be/upMpPtQuc0c?t=00h53m11s)

[maybe maybe worth doing um and then this](https://youtu.be/upMpPtQuc0c?t=00h53m14s)

[get Target type this is where the](https://youtu.be/upMpPtQuc0c?t=00h53m17s)

[magical bit is actually coming from](https://youtu.be/upMpPtQuc0c?t=00h53m19s)

[because this is now processing the](https://youtu.be/upMpPtQuc0c?t=00h53m22s)

[attribute syn tax to go through and pull](https://youtu.be/upMpPtQuc0c?t=00h53m24s)

[out the the type that is in the](https://youtu.be/upMpPtQuc0c?t=00h53m27s)

[arguments](https://youtu.be/upMpPtQuc0c?t=00h53m30s)

[list so I think is this these days kind](https://youtu.be/upMpPtQuc0c?t=00h53m32s)

[of generated automatically when you set](https://youtu.be/upMpPtQuc0c?t=00h53m35s)

[up a base generator or is this stuff](https://youtu.be/upMpPtQuc0c?t=00h53m37s)

[that one has to know in depth be a to](https://youtu.be/upMpPtQuc0c?t=00h53m40s)

[write more the latter which is and and](https://youtu.be/upMpPtQuc0c?t=00h53m42s)

[it gets harder every time the C team](https://youtu.be/upMpPtQuc0c?t=00h53m46s)

[introduces new syntax this is why when](https://youtu.be/upMpPtQuc0c?t=00h53m48s)

[new versions of C drop very often](https://youtu.be/upMpPtQuc0c?t=00h53m51s)

[analyze iers or Source generators don't](https://youtu.be/upMpPtQuc0c?t=00h53m54s)

[play nice with new](https://youtu.be/upMpPtQuc0c?t=00h53m57s)

[syntax](https://youtu.be/upMpPtQuc0c?t=00h53m59s)

[because uh this type of stuff goes uh](https://youtu.be/upMpPtQuc0c?t=00h54m00s)

[Belly Up Jared always good to see you](https://youtu.be/upMpPtQuc0c?t=00h54m03s)

[welcome so this is actually what's](https://youtu.be/upMpPtQuc0c?t=00h54m07s)

[pulling that guy out and I think see](https://youtu.be/upMpPtQuc0c?t=00h54m10s)

[this is explicitly looking for a type of](https://youtu.be/upMpPtQuc0c?t=00h54m15s)

[expression and in your case because this](https://youtu.be/upMpPtQuc0c?t=00h54m17s)

[is not going to be a type of I think](https://youtu.be/upMpPtQuc0c?t=00h54m20s)

[what we can do here okay so we're just](https://youtu.be/upMpPtQuc0c?t=00h54m22s)

[going to execution I think what we can](https://youtu.be/upMpPtQuc0c?t=00h54m24s)

[do is we can reach across](https://youtu.be/upMpPtQuc0c?t=00h54m27s)

[here](https://youtu.be/upMpPtQuc0c?t=00h54m31s)

[um and I think we could just return a bu](https://youtu.be/upMpPtQuc0c?t=00h54m33s)

[right rather than get Target type uh get](https://youtu.be/upMpPtQuc0c?t=00h54m37s)

[what are we going to call](https://youtu.be/upMpPtQuc0c?t=00h54m41s)

[it skip](https://youtu.be/upMpPtQuc0c?t=00h54m43s)

[uh nullable](https://youtu.be/upMpPtQuc0c?t=00h54m45s)

[parameters yeah something like](https://youtu.be/upMpPtQuc0c?t=00h54m49s)

[that okay so this guy's gonna come](https://youtu.be/upMpPtQuc0c?t=00h54m51s)

[through here and then we're going to](https://youtu.be/upMpPtQuc0c?t=00h54m54s)

[need to pull apart the argument](https://youtu.be/upMpPtQuc0c?t=00h54m55s)

[list and we are probably going to need](https://youtu.be/upMpPtQuc0c?t=00h54m58s)

[to look at this and figure out what this](https://youtu.be/upMpPtQuc0c?t=00h55m00s)

[expression is now one of the really](https://youtu.be/upMpPtQuc0c?t=00h55m02s)

[really really really handy things here](https://youtu.be/upMpPtQuc0c?t=00h55m05s)

[uh](https://youtu.be/upMpPtQuc0c?t=00h55m08s)

[sharp. this this be gold and that also](https://youtu.be/upMpPtQuc0c?t=00h55m09s)

[be tiny okay um if we go back to our](https://youtu.be/upMpPtQuc0c?t=00h55m14s)

[test right so we can come in](https://youtu.be/upMpPtQuc0c?t=00h55m19s)

[here this is the stuff we're trying to](https://youtu.be/upMpPtQuc0c?t=00h55m21s)

[parse right so we come we come here we](https://youtu.be/upMpPtQuc0c?t=00h55m24s)

[come here we paste in our code and](https://youtu.be/upMpPtQuc0c?t=00h55m27s)

[rather than iil because it's going to](https://youtu.be/upMpPtQuc0c?t=00h55m29s)

[freak out uh we can go syntax tree and](https://youtu.be/upMpPtQuc0c?t=00h55m31s)

[you'll start to notice something real](https://youtu.be/upMpPtQuc0c?t=00h55m34s)

[quick um and actually just to make this](https://youtu.be/upMpPtQuc0c?t=00h55m36s)

[thing happy I'm going](https://youtu.be/upMpPtQuc0c?t=00h55m40s)

[to just to make sharp lab stop screaming](https://youtu.be/upMpPtQuc0c?t=00h55m42s)

[at me I'm going to do that and I'm going](https://youtu.be/upMpPtQuc0c?t=00h55m45s)

[to](https://youtu.be/upMpPtQuc0c?t=00h55m48s)

[do](https://youtu.be/upMpPtQuc0c?t=00h55m50s)

[this](https://youtu.be/upMpPtQuc0c?t=00h55m54s)

[and now sharp Labs](https://youtu.be/upMpPtQuc0c?t=00h55m55s)

[can oh so if they if C 11 had actually](https://youtu.be/upMpPtQuc0c?t=00h55m57s)

[implemented what I would have thought](https://youtu.be/upMpPtQuc0c?t=00h56m02s)

[would have been amazing the perimeter](https://youtu.be/upMpPtQuc0c?t=00h56m03s)

[null checking feature would that meant](https://youtu.be/upMpPtQuc0c?t=00h56m05s)

[you would have had to count for a third](https://youtu.be/upMpPtQuc0c?t=00h56m07s)

[case of yes 100% yes well it depends](https://youtu.be/upMpPtQuc0c?t=00h56m08s)

[because I don't know if we would have](https://youtu.be/upMpPtQuc0c?t=00h56m13s)

[been because I think it compiles out to](https://youtu.be/upMpPtQuc0c?t=00h56m17s)

[an argument null exception. throw if](https://youtu.be/upMpPtQuc0c?t=00h56m20s)

[null essentially right and so that](https://youtu.be/upMpPtQuc0c?t=00h56m22s)

[that's where things get interesting](https://youtu.be/upMpPtQuc0c?t=00h56m26s)

[because it](https://youtu.be/upMpPtQuc0c?t=00h56m27s)

[does it does CH if they add new syntax](https://youtu.be/upMpPtQuc0c?t=00h56m29s)

[that you want to handle you do have to](https://youtu.be/upMpPtQuc0c?t=00h56m33s)

[go and change your your generator or](https://youtu.be/upMpPtQuc0c?t=00h56m34s)

[analyzer and that's and that is somewhat](https://youtu.be/upMpPtQuc0c?t=00h56m37s)

[problematic so but the nice part here](https://youtu.be/upMpPtQuc0c?t=00h56m40s)

[right is we can come in here and we can](https://youtu.be/upMpPtQuc0c?t=00h56m42s)

[start to parse this thing a uh um par](https://youtu.be/upMpPtQuc0c?t=00h56m44s)

[this thing out because you'll note](https://youtu.be/upMpPtQuc0c?t=00h56m49s)

[there's an attribute list oh look](https://youtu.be/upMpPtQuc0c?t=00h56m50s)

[there's an attribute oh what is in the](https://youtu.be/upMpPtQuc0c?t=00h56m53s)

[attribute oh there's an arguments list](https://youtu.be/upMpPtQuc0c?t=00h56m55s)

[this should look really familiar to the](https://youtu.be/upMpPtQuc0c?t=00h56m57s)

[method we were just looking at right so](https://youtu.be/upMpPtQuc0c?t=00h56m58s)

[anybody who wants to play along at home](https://youtu.be/upMpPtQuc0c?t=00h57m01s)

[uh what in the world are we doing here](https://youtu.be/upMpPtQuc0c?t=00h57m03s)

[we are building or extending a source](https://youtu.be/upMpPtQuc0c?t=00h57m05s)

[generator so right now we've got a](https://youtu.be/upMpPtQuc0c?t=00h57m08s)

[source generator jar that builds tests](https://youtu.be/upMpPtQuc0c?t=00h57m09s)

[to do uh argument null tests and we want](https://youtu.be/upMpPtQuc0c?t=00h57m12s)

[it to be tolerant of things that are](https://youtu.be/upMpPtQuc0c?t=00h57m15s)

[expected to be null and not do dumb](https://youtu.be/upMpPtQuc0c?t=00h57m18s)

[stuff how did care I'll say if you copy](https://youtu.be/upMpPtQuc0c?t=00h57m20s)

[the whole link will they actually share](https://youtu.be/upMpPtQuc0c?t=00h57m22s)

[yeah that's a good point it](https://youtu.be/upMpPtQuc0c?t=00h57m26s)

[will it absolutely will I'm guessing you](https://youtu.be/upMpPtQuc0c?t=00h57m29s)

[want the](https://youtu.be/upMpPtQuc0c?t=00h57m32s)

[whole I don't think it does does it](https://youtu.be/upMpPtQuc0c?t=00h57m33s)

[not unless someone else is just is it](https://youtu.be/upMpPtQuc0c?t=00h57m38s)

[just me hang on is a this is a new](https://youtu.be/upMpPtQuc0c?t=00h57m41s)

[private session oh](https://youtu.be/upMpPtQuc0c?t=00h57m45s)

[uh I'll try one more time if you're](https://youtu.be/upMpPtQuc0c?t=00h57m49s)

[looking if you're worried about the](https://youtu.be/upMpPtQuc0c?t=00h57m52s)

[thing on the right it starts it defaults](https://youtu.be/upMpPtQuc0c?t=00h57m54s)

[to collaps click on something on the](https://youtu.be/upMpPtQuc0c?t=00h57m56s)

[left to make it](https://youtu.be/upMpPtQuc0c?t=00h57m58s)

[expand don't see your code with the](https://youtu.be/upMpPtQuc0c?t=00h57m59s)

[link works on my](https://youtu.be/upMpPtQuc0c?t=00h58m02s)

[box even in a private says ever](https://youtu.be/upMpPtQuc0c?t=00h58m05s)

[developer ever even in a private one oh](https://youtu.be/upMpPtQuc0c?t=00h58m08s)

[it does no code on the left you're](https://youtu.be/upMpPtQuc0c?t=00h58m12s)

[right yeah well that's](https://youtu.be/upMpPtQuc0c?t=00h58m15s)

[boring I don't know what you're copying](https://youtu.be/upMpPtQuc0c?t=00h58m19s)

[then like what are they sending through](https://youtu.be/upMpPtQuc0c?t=00h58m21s)

[that link but](https://youtu.be/upMpPtQuc0c?t=00h58m23s)

[yeah oh did I just lose it that's going](https://youtu.be/upMpPtQuc0c?t=00h58m25s)

[to be real](https://youtu.be/upMpPtQuc0c?t=00h58m28s)

[disappointing hang on hang on we can do](https://youtu.be/upMpPtQuc0c?t=00h58m32s)

[this I can go here only they have links](https://youtu.be/upMpPtQuc0c?t=00h58m34s)

[that actually work I can go](https://youtu.be/upMpPtQuc0c?t=00h58m37s)

[here hang on hang on uh let's see](https://youtu.be/upMpPtQuc0c?t=00h58m40s)

[there's the](https://youtu.be/upMpPtQuc0c?t=00h58m44s)

[enom oh you could create a gist it looks](https://youtu.be/upMpPtQuc0c?t=00h58m46s)

[like there's a button at the top and you](https://youtu.be/upMpPtQuc0c?t=00h58m51s)

[have to hook it into to GitHub baby and](https://youtu.be/upMpPtQuc0c?t=00h58m54s)

[that's maybe how you do it uh that could](https://youtu.be/upMpPtQuc0c?t=00h58m56s)

[be and I got to move this to the end](https://youtu.be/upMpPtQuc0c?t=00h58m59s)

[because I copied them in the wrong order](https://youtu.be/upMpPtQuc0c?t=00h59m01s)

[to make this work](https://youtu.be/upMpPtQuc0c?t=00h59m02s)

[okay and then I need something like](https://youtu.be/upMpPtQuc0c?t=00h59m04s)

[using](https://youtu.be/upMpPtQuc0c?t=00h59m07s)

[system uh but you need to turn caps lock](https://youtu.be/upMpPtQuc0c?t=00h59m09s)

[off to make that play nice and there we](https://youtu.be/upMpPtQuc0c?t=00h59m12s)

[go now we're back into a happy State](https://youtu.be/upMpPtQuc0c?t=00h59m15s)

[okay](https://youtu.be/upMpPtQuc0c?t=00h59m19s)

[ID okay but the important thing here is](https://youtu.be/upMpPtQuc0c?t=00h59m20s)

[what what we expect to see inside of](https://youtu.be/upMpPtQuc0c?t=00h59m24s)

[this so inside of the argument list](https://youtu.be/upMpPtQuc0c?t=00h59m27s)

[we're expecting to see an attribute](https://youtu.be/upMpPtQuc0c?t=00h59m30s)

[argument we're expecting its expression](https://youtu.be/upMpPtQuc0c?t=00h59m32s)

[in this in this particular instance to](https://youtu.be/upMpPtQuc0c?t=00h59m35s)

[be a simple member access](https://youtu.be/upMpPtQuc0c?t=00h59m37s)

[expression um and then from there we can](https://youtu.be/upMpPtQuc0c?t=00h59m40s)

[we can look at the name to get the the](https://youtu.be/upMpPtQuc0c?t=00h59m44s)

[identifier but we](https://youtu.be/upMpPtQuc0c?t=00h59m47s)

[may we may or may not want to try to](https://youtu.be/upMpPtQuc0c?t=00h59m50s)

[pull that](https://youtu.be/upMpPtQuc0c?t=00h59m55s)

[apart because I think what we probably](https://youtu.be/upMpPtQuc0c?t=00h59m56s)

[want to do is just look at this and go](https://youtu.be/upMpPtQuc0c?t=00h59m58s)

[for the constant value that's probably](https://youtu.be/upMpPtQuc0c?t=01h00m00s)

[what we want to pull](https://youtu.be/upMpPtQuc0c?t=01h00m02s)

[out](https://youtu.be/upMpPtQuc0c?t=01h00m04s)

[um because in this case one of the nice](https://youtu.be/upMpPtQuc0c?t=01h00m07s)

[Parts because we're shipping the the](https://youtu.be/upMpPtQuc0c?t=01h00m11s)

[generator with the library we can kind](https://youtu.be/upMpPtQuc0c?t=01h00m13s)

[of make the assumption that those two](https://youtu.be/upMpPtQuc0c?t=01h00m16s)

[things are going to be in sync if they](https://youtu.be/upMpPtQuc0c?t=01h00m17s)

[weren't going to be in](https://youtu.be/upMpPtQuc0c?t=01h00m19s)

[sync who knows world world goes crazy](https://youtu.be/upMpPtQuc0c?t=01h00m21s)

[but I think what we can do here is just](https://youtu.be/upMpPtQuc0c?t=01h00m24s)

[this so we can sort of](https://youtu.be/upMpPtQuc0c?t=01h00m26s)

[parse because this one here was so](https://youtu.be/upMpPtQuc0c?t=01h00m30s)

[you'll know this one](https://youtu.be/upMpPtQuc0c?t=01h00m33s)

[was](https://youtu.be/upMpPtQuc0c?t=01h00m35s)

[um uh attribute argument operation type](https://youtu.be/upMpPtQuc0c?t=01h00m36s)

[of expression and I think we want simple](https://youtu.be/upMpPtQuc0c?t=01h00m40s)

[member access expression is a much](https://youtu.be/upMpPtQuc0c?t=01h00m42s)

[better one what's the difference between](https://youtu.be/upMpPtQuc0c?t=01h00m44s)

[those for one that doesn't know what](https://youtu.be/upMpPtQuc0c?t=01h00m46s)

[those mean uh](https://youtu.be/upMpPtQuc0c?t=01h00m49s)

[every everything in the C sharp](https://youtu.be/upMpPtQuc0c?t=01h00m52s)

[language is has been codified so this is](https://youtu.be/upMpPtQuc0c?t=01h00m55s)

[this is meta level of programming so](https://youtu.be/upMpPtQuc0c?t=01h00m59s)

[kind of like when you do reflection how](https://youtu.be/upMpPtQuc0c?t=01h01m01s)

[a property info is an object](https://youtu.be/upMpPtQuc0c?t=01h01m03s)

[representing all of the stuff about a](https://youtu.be/upMpPtQuc0c?t=01h01m05s)

[property think of every little token in](https://youtu.be/upMpPtQuc0c?t=01h01m07s)

[the C language as having a uh an object](https://youtu.be/upMpPtQuc0c?t=01h01m10s)

[type that uh reflects it so this is the](https://youtu.be/upMpPtQuc0c?t=01h01m13s)

[compiler's view of your world so if we](https://youtu.be/upMpPtQuc0c?t=01h01m17s)

[do uh](https://youtu.be/upMpPtQuc0c?t=01h01m21s)

[simple uh member access expression and I](https://youtu.be/upMpPtQuc0c?t=01h01m23s)

[am very aware that this doesn't work](https://youtu.be/upMpPtQuc0c?t=01h01m27s)

[right](https://youtu.be/upMpPtQuc0c?t=01h01m32s)

[the um this guy here should](https://youtu.be/upMpPtQuc0c?t=01h01m34s)

[be right so this guy here simple member](https://youtu.be/upMpPtQuc0c?t=01h01m38s)

[access expression we probably need his](https://youtu.be/upMpPtQuc0c?t=01h01m41s)

[base type member access expression I'm](https://youtu.be/upMpPtQuc0c?t=01h01m44s)

[guessing uh let's see here because this](https://youtu.be/upMpPtQuc0c?t=01h01m48s)

[guy give me your name space kind of we](https://youtu.be/upMpPtQuc0c?t=01h01m52s)

[do](https://youtu.be/upMpPtQuc0c?t=01h01m56s)

[syntax give me give me your fully](https://youtu.be/upMpPtQuc0c?t=01h01m59s)

[qualified Thing mo](https://youtu.be/upMpPtQuc0c?t=01h02m01s)

[bobber](https://youtu.be/upMpPtQuc0c?t=01h02m03s)

[um what are they So Pro tip what I did](https://youtu.be/upMpPtQuc0c?t=01h02m06s)

[here is just from past experience](https://youtu.be/upMpPtQuc0c?t=01h02m11s)

[knowing that all of these things are](https://youtu.be/upMpPtQuc0c?t=01h02m14s)

[obnoxiously in the same place it means](https://youtu.be/upMpPtQuc0c?t=01h02m16s)

[that if you F12 on them and get to this](https://youtu.be/upMpPtQuc0c?t=01h02m19s)

[file you can hit a dropdown and here's a](https://youtu.be/upMpPtQuc0c?t=01h02m21s)

[list because quite often the actual](https://youtu.be/upMpPtQuc0c?t=01h02m23s)

[derive type is something hidden from you](https://youtu.be/upMpPtQuc0c?t=01h02m26s)

[and the base type is what you actually](https://youtu.be/upMpPtQuc0c?t=01h02m28s)

[want to act on I](https://youtu.be/upMpPtQuc0c?t=01h02m30s)

[suspect member access expression syntax](https://youtu.be/upMpPtQuc0c?t=01h02m33s)

[that sounds like what I](https://youtu.be/upMpPtQuc0c?t=01h02m36s)

[want surprised they had a parameter](https://youtu.be/upMpPtQuc0c?t=01h02m43s)

[literally called](https://youtu.be/upMpPtQuc0c?t=01h02m45s)

[Green](https://youtu.be/upMpPtQuc0c?t=01h02m47s)

[yeah um and so this guy here member](https://youtu.be/upMpPtQuc0c?t=01h02m50s)

[access expr expression first or default](https://youtu.be/upMpPtQuc0c?t=01h02m53s)

[and so in this case our else case is](https://youtu.be/upMpPtQuc0c?t=01h02m56s)

[going to be false and in this case uh](https://youtu.be/upMpPtQuc0c?t=01h02m57s)

[let's see](https://youtu.be/upMpPtQuc0c?t=01h03m00s)

[remember uh access](https://youtu.be/upMpPtQuc0c?t=01h03m02s)

[expression spelling mildly counts and](https://youtu.be/upMpPtQuc0c?t=01h03m08s)

[then I think what we saw is we can go](https://youtu.be/upMpPtQuc0c?t=01h03m12s)

[here and then I think look at operation](https://youtu.be/upMpPtQuc0c?t=01h03m14s)

[and constant](https://youtu.be/upMpPtQuc0c?t=01h03m17s)

[value think is what we want to do](https://youtu.be/upMpPtQuc0c?t=01h03m19s)

[assuming operation](https://youtu.be/upMpPtQuc0c?t=01h03m22s)

[uh operator token ooh this may](https://youtu.be/upMpPtQuc0c?t=01h03m25s)

[be this may be another case where it](https://youtu.be/upMpPtQuc0c?t=01h03m28s)

[gets awkward because we don't have good](https://youtu.be/upMpPtQuc0c?t=01h03m30s)

[access to](https://youtu.be/upMpPtQuc0c?t=01h03m33s)

[it](https://youtu.be/upMpPtQuc0c?t=01h03m34s)

[uh I don't really want to parse that](https://youtu.be/upMpPtQuc0c?t=01h03m37s)

[across raw kind language is](https://youtu.be/upMpPtQuc0c?t=01h03m41s)

[missing I kind of want to fine fix my](https://youtu.be/upMpPtQuc0c?t=01h03m45s)

[spelling thank thank you I understand I](https://youtu.be/upMpPtQuc0c?t=01h03m48s)

[can't spell I get it](https://youtu.be/upMpPtQuc0c?t=01h03m51s)

[show off um this kind is](https://youtu.be/upMpPtQuc0c?t=01h03m55s)

[missing I](https://youtu.be/upMpPtQuc0c?t=01h03m59s)

[think field reference and going](https://youtu.be/upMpPtQuc0c?t=01h04m02s)

[there](https://youtu.be/upMpPtQuc0c?t=01h04m07s)

[um operator](https://youtu.be/upMpPtQuc0c?t=01h04m10s)

[token field reference operation operator](https://youtu.be/upMpPtQuc0c?t=01h04m17s)

[token uh we might need to just look at](https://youtu.be/upMpPtQuc0c?t=01h04m21s)

[what this comes back](https://youtu.be/upMpPtQuc0c?t=01h04m25s)

[as uh let's see varu](https://youtu.be/upMpPtQuc0c?t=01h04m27s)

[gets and then we do this we do this do](https://youtu.be/upMpPtQuc0c?t=01h04m31s)

[this do this boom okay then we come in](https://youtu.be/upMpPtQuc0c?t=01h04m35s)

[here and this guy here is currently just](https://youtu.be/upMpPtQuc0c?t=01h04m40s)

[returning](https://youtu.be/upMpPtQuc0c?t=01h04m44s)

[back the](https://youtu.be/upMpPtQuc0c?t=01h04m47s)

[type might need to do we might need to](https://youtu.be/upMpPtQuc0c?t=01h04m52s)

[break this up so that it does a little](https://youtu.be/upMpPtQuc0c?t=01h04m55s)

[more uh but for now we're just going to](https://youtu.be/upMpPtQuc0c?t=01h05m01s)

[do this because right now this is doing](https://youtu.be/upMpPtQuc0c?t=01h05m04s)

[all of this work to do a first or](https://youtu.be/upMpPtQuc0c?t=01h05m07s)

[default just to get this for a big if](https://youtu.be/upMpPtQuc0c?t=01h05m09s)

[condition but what might end up needing](https://youtu.be/upMpPtQuc0c?t=01h05m11s)

[to happen is we might need this to](https://youtu.be/upMpPtQuc0c?t=01h05m13s)

[return more than](https://youtu.be/upMpPtQuc0c?t=01h05m15s)

[just null right like we might want to](https://youtu.be/upMpPtQuc0c?t=01h05m17s)

[say if we get inside this if block go](https://youtu.be/upMpPtQuc0c?t=01h05m20s)

[ahead and turn back you know the the uh](https://youtu.be/upMpPtQuc0c?t=01h05m23s)

[attribute itself and then inside of here](https://youtu.be/upMpPtQuc0c?t=01h05m27s)

[do the pull apart or something to that](https://youtu.be/upMpPtQuc0c?t=01h05m30s)

[effect](https://youtu.be/upMpPtQuc0c?t=01h05m33s)

[but for now we do this let's go here and](https://youtu.be/upMpPtQuc0c?t=01h05m36s)

[let's see what comes back out of](https://youtu.be/upMpPtQuc0c?t=01h05m40s)

[this uh oh Mountain Dew is almost](https://youtu.be/upMpPtQuc0c?t=01h05m44s)

[empty don't worry I brought back](https://youtu.be/upMpPtQuc0c?t=01h05m49s)

[up](https://youtu.be/upMpPtQuc0c?t=01h05m53s)

[okay so let's go in here and let's see](https://youtu.be/upMpPtQuc0c?t=01h05m55s)

[what we get back](https://youtu.be/upMpPtQuc0c?t=01h05m58s)

[so oh that was stupid of](https://youtu.be/upMpPtQuc0c?t=01h06m01s)

[me of course it matched but I wanted to](https://youtu.be/upMpPtQuc0c?t=01h06m06s)

[look at the whole thing darn it Kevin](https://youtu.be/upMpPtQuc0c?t=01h06m10s)

[I'm excited for someday your kids are](https://youtu.be/upMpPtQuc0c?t=01h06m12s)

[going to make you like a rub gold](https://youtu.be/upMpPtQuc0c?t=01h06m14s)

[Goldberg machine for serving you up](https://youtu.be/upMpPtQuc0c?t=01h06m15s)

[mountain and do and it'll be fantastic I](https://youtu.be/upMpPtQuc0c?t=01h06m17s)

[completely agree that that would be](https://youtu.be/upMpPtQuc0c?t=01h06m21s)

[fantastic](https://youtu.be/upMpPtQuc0c?t=01h06m23s)

[uh let's](https://youtu.be/upMpPtQuc0c?t=01h06m26s)

[see this](https://youtu.be/upMpPtQuc0c?t=01h06m27s)

[is I just want](https://youtu.be/upMpPtQuc0c?t=01h06m35s)

[this de reference of possibly null yeah](https://youtu.be/upMpPtQuc0c?t=01h06m43s)

[I agree that it's possibly no and I'm](https://youtu.be/upMpPtQuc0c?t=01h06m47s)

[going to say tell you to shut up and do](https://youtu.be/upMpPtQuc0c?t=01h06m49s)

[it](https://youtu.be/upMpPtQuc0c?t=01h06m51s)

[anyway](https://youtu.be/upMpPtQuc0c?t=01h06m53s)

[uh because in this unit test it is not](https://youtu.be/upMpPtQuc0c?t=01h06m54s)

[possible to have anything but](https://youtu.be/upMpPtQuc0c?t=01h06m57s)

[that because I control the sum total of](https://youtu.be/upMpPtQuc0c?t=01h07m00s)

[all of the code being fed into this](https://youtu.be/upMpPtQuc0c?t=01h07m03s)

[Source](https://youtu.be/upMpPtQuc0c?t=01h07m05s)

[generator okay there there okay so we](https://youtu.be/upMpPtQuc0c?t=01h07m10s)

[want to look at foo](https://youtu.be/upMpPtQuc0c?t=01h07m13s)

[how we would like to see go locals and](https://youtu.be/upMpPtQuc0c?t=01h07m16s)

[we'll expand this out and let us look](https://youtu.be/upMpPtQuc0c?t=01h07m20s)

[I need to find a way to make this font](https://youtu.be/upMpPtQuc0c?t=01h07m24s)

[big there's a lot in here yes there is](https://youtu.be/upMpPtQuc0c?t=01h07m27s)

[and the the unfortunate part is a lot of](https://youtu.be/upMpPtQuc0c?t=01h07m29s)

[this is derived](https://youtu.be/upMpPtQuc0c?t=01h07m31s)

[classes not](https://youtu.be/upMpPtQuc0c?t=01h07m34s)

[always um exactly what we're after so](https://youtu.be/upMpPtQuc0c?t=01h07m37s)

[are you able to hide that in your](https://youtu.be/upMpPtQuc0c?t=01h07m41s)

[locals search depth are you able to](https://youtu.be/upMpPtQuc0c?t=01h07m43s)

[reduce that would](https://youtu.be/upMpPtQuc0c?t=01h07m45s)

[that](https://youtu.be/upMpPtQuc0c?t=01h07m46s)

[for to lower](https://youtu.be/upMpPtQuc0c?t=01h07m48s)

[this would that actually change like how](https://youtu.be/upMpPtQuc0c?t=01h07m50s)

[many deride classes it goes by does it](https://youtu.be/upMpPtQuc0c?t=01h07m53s)

[actually know or does not have aom that](https://youtu.be/upMpPtQuc0c?t=01h07m54s)

[at this point in time I I think this is](https://youtu.be/upMpPtQuc0c?t=01h07m56s)

[the search and depth for for local](https://youtu.be/upMpPtQuc0c?t=01h07m58s)

[variables not necessarily how deep this](https://youtu.be/upMpPtQuc0c?t=01h08m00s)

[is going to expand itself out because in](https://youtu.be/upMpPtQuc0c?t=01h08m03s)

[our case here we've got](https://youtu.be/upMpPtQuc0c?t=01h08m05s)

[a so we get back](https://youtu.be/upMpPtQuc0c?t=01h08m08s)

[the](https://youtu.be/upMpPtQuc0c?t=01h08m12s)

[expression um but I'm looking for where](https://youtu.be/upMpPtQuc0c?t=01h08m15s)

[this thing actually is going to have its](https://youtu.be/upMpPtQuc0c?t=01h08m18s)

[value](https://youtu.be/upMpPtQuc0c?t=01h08m20s)

[stored because the operator](https://youtu.be/upMpPtQuc0c?t=01h08m22s)

[token I don't know if this actually has](https://youtu.be/upMpPtQuc0c?t=01h08m25s)

[what we](https://youtu.be/upMpPtQuc0c?t=01h08m29s)

[seek uh](https://youtu.be/upMpPtQuc0c?t=01h08m30s)

[no this thing here has the](https://youtu.be/upMpPtQuc0c?t=01h08m36s)

[span but this is what I so that's the](https://youtu.be/upMpPtQuc0c?t=01h08m40s)

[parent](https://youtu.be/upMpPtQuc0c?t=01h08m43s)

[though where do I find identifier name](https://youtu.be/upMpPtQuc0c?t=01h08m47s)

[syntax test generator Behavior](https://youtu.be/upMpPtQuc0c?t=01h08m51s)

[that looks like what I](https://youtu.be/upMpPtQuc0c?t=01h08m55s)

[want](https://youtu.be/upMpPtQuc0c?t=01h08m58s)

[um syntax token identifier token](https://youtu.be/upMpPtQuc0c?t=01h09m00s)

[Behavior right give me the right hand](https://youtu.be/upMpPtQuc0c?t=01h09m04s)

[side of the](https://youtu.be/upMpPtQuc0c?t=01h09m07s)

[equation I am wondering if I don't](https://youtu.be/upMpPtQuc0c?t=01h09m11s)

[have go up to the parent real quick and](https://youtu.be/upMpPtQuc0c?t=01h09m15s)

[then work our way down because I'm](https://youtu.be/upMpPtQuc0c?t=01h09m18s)

[wondering if maybe I grabbed too](https://youtu.be/upMpPtQuc0c?t=01h09m19s)

[early um](https://youtu.be/upMpPtQuc0c?t=01h09m21s)

[remember access no because this shows](https://youtu.be/upMpPtQuc0c?t=01h09m27s)

[skip notable reference types this has](https://youtu.be/upMpPtQuc0c?t=01h09m29s)

[it](https://youtu.be/upMpPtQuc0c?t=01h09m32s)

[right um](https://youtu.be/upMpPtQuc0c?t=01h09m34s)

[name the pros and cons of that new](https://youtu.be/upMpPtQuc0c?t=01h09m36s)

[feature that they actually like show](https://youtu.be/upMpPtQuc0c?t=01h09m39s)

[useful things for value for an](https://youtu.be/upMpPtQuc0c?t=01h09m41s)

[object](https://youtu.be/upMpPtQuc0c?t=01h09m44s)

[yeah yeah very much so well hold on the](https://youtu.be/upMpPtQuc0c?t=01h09m47s)

[name of this I saw it there the name a](https://youtu.be/upMpPtQuc0c?t=01h09m50s)

[little bit right there thing I'm](https://youtu.be/upMpPtQuc0c?t=01h09m54s)

[highlighted not too down well parent](https://youtu.be/upMpPtQuc0c?t=01h09m56s)

[parent is going to take us up a level](https://youtu.be/upMpPtQuc0c?t=01h09m58s)

[because parent is showing us the entire](https://youtu.be/upMpPtQuc0c?t=01h10m00s)

[attribute argument syntax which you can](https://youtu.be/upMpPtQuc0c?t=01h10m02s)

[see is behavior equals and then the](https://youtu.be/upMpPtQuc0c?t=01h10m05s)

[whole thing we really only want to pull](https://youtu.be/upMpPtQuc0c?t=01h10m07s)

[out the right hand side of that kex I'm](https://youtu.be/upMpPtQuc0c?t=01h10m09s)

[assuming kex is what it's pulling out](https://youtu.be/upMpPtQuc0c?t=01h10m13s)

[partially for to](https://youtu.be/upMpPtQuc0c?t=01h10m15s)

[display correct](https://youtu.be/upMpPtQuc0c?t=01h10m18s)

[and I](https://youtu.be/upMpPtQuc0c?t=01h10m22s)

[think okay let's let's flatten this up](https://youtu.be/upMpPtQuc0c?t=01h10m24s)

[real quick let's flatten this up because](https://youtu.be/upMpPtQuc0c?t=01h10m26s)

[I think what that's showing me is I want](https://youtu.be/upMpPtQuc0c?t=01h10m29s)

[to actually be inside of](https://youtu.be/upMpPtQuc0c?t=01h10m31s)

[name um because name then](https://youtu.be/upMpPtQuc0c?t=01h10m34s)

[has skip Noble reference type I think](https://youtu.be/upMpPtQuc0c?t=01h10m42s)

[what I want to do is I want to pull](https://youtu.be/upMpPtQuc0c?t=01h10m46s)

[out from Fu I think I wanted to check](https://youtu.be/upMpPtQuc0c?t=01h10m49s)

[for the the identifier name syntax let](https://youtu.be/upMpPtQuc0c?t=01h10m54s)

[me just check here real](https://youtu.be/upMpPtQuc0c?t=01h10m58s)

[quick uh identifier name Skip Noble](https://youtu.be/upMpPtQuc0c?t=01h11m00s)

[reference types this](https://youtu.be/upMpPtQuc0c?t=01h11m04s)

[guy trying to different than the](https://youtu.be/upMpPtQuc0c?t=01h11m12s)

[expression that's two](https://youtu.be/upMpPtQuc0c?t=01h11m14s)

[up yeah cuz the expression that's what's](https://youtu.be/upMpPtQuc0c?t=01h11m19s)

[on that's the member on yeah which is](https://youtu.be/upMpPtQuc0c?t=01h11m22s)

[why I think I want to go down a](https://youtu.be/upMpPtQuc0c?t=01h11m25s)

[level because at the point and because](https://youtu.be/upMpPtQuc0c?t=01h11m28s)

[this is one of the nice Parts about](https://youtu.be/upMpPtQuc0c?t=01h11m30s)

[sharp Labs like I don't know if you can](https://youtu.be/upMpPtQuc0c?t=01h11m32s)

[see when I do when I'm hovering](https://youtu.be/upMpPtQuc0c?t=01h11m34s)

[here uh if I do this right when I have](https://youtu.be/upMpPtQuc0c?t=01h11m37s)

[this selected on the right it actually](https://youtu.be/upMpPtQuc0c?t=01h11m42s)

[highlights the relevant section of the C](https://youtu.be/upMpPtQuc0c?t=01h11m44s)

[on the](https://youtu.be/upMpPtQuc0c?t=01h11m47s)

[left so that like so when we're talking](https://youtu.be/upMpPtQuc0c?t=01h11m48s)

[about this simple member access](https://youtu.be/upMpPtQuc0c?t=01h11m51s)

[expression we're literally only](https://youtu.be/upMpPtQuc0c?t=01h11m53s)

[considering the things to the right hand](https://youtu.be/upMpPtQuc0c?t=01h11m55s)

[side of the](https://youtu.be/upMpPtQuc0c?t=01h11m56s)

[equals so I'm also now curious what what](https://youtu.be/upMpPtQuc0c?t=01h11m58s)

[happens](https://youtu.be/upMpPtQuc0c?t=01h12m02s)

[if we do this right because this](https://youtu.be/upMpPtQuc0c?t=01h12m03s)

[now is the same](https://youtu.be/upMpPtQuc0c?t=01h12m08s)

[thing I think what we want to do is we](https://youtu.be/upMpPtQuc0c?t=01h12m13s)

[want to go after](https://youtu.be/upMpPtQuc0c?t=01h12m15s)

[the I think we want to check](https://youtu.be/upMpPtQuc0c?t=01h12m19s)

[the](https://youtu.be/upMpPtQuc0c?t=01h12m22s)

[identify our](https://youtu.be/upMpPtQuc0c?t=01h12m24s)

[name I'm I'm just worried that we may](https://youtu.be/upMpPtQuc0c?t=01h12m26s)

[need to filter this further right to](https://youtu.be/upMpPtQuc0c?t=01h12m29s)

[make sure that we actually](https://youtu.be/upMpPtQuc0c?t=01h12m31s)

[grab which one we're](https://youtu.be/upMpPtQuc0c?t=01h12m34s)

[on because of the way that you can](https://youtu.be/upMpPtQuc0c?t=01h12m38s)

[specify attributes with their parameters](https://youtu.be/upMpPtQuc0c?t=01h12m40s)

[out of](https://youtu.be/upMpPtQuc0c?t=01h12m42s)

[order where you do like the default](https://youtu.be/upMpPtQuc0c?t=01h12m43s)

[Constructor and then specify them but](https://youtu.be/upMpPtQuc0c?t=01h12m46s)

[for now I think in the interest of](https://youtu.be/upMpPtQuc0c?t=01h12m48s)

[getting this working we go here here and](https://youtu.be/upMpPtQuc0c?t=01h12m50s)

[we](https://youtu.be/upMpPtQuc0c?t=01h12m54s)

[say identifier I think we just go after](https://youtu.be/upMpPtQuc0c?t=01h12m56s)

[the name of](https://youtu.be/upMpPtQuc0c?t=01h13m00s)

[Fu I think is I think is the Target](https://youtu.be/upMpPtQuc0c?t=01h13m02s)

[because that gets us the identifier](https://youtu.be/upMpPtQuc0c?t=01h13m04s)

[name um because this guy up here right](https://youtu.be/upMpPtQuc0c?t=01h13m10s)

[this just did type of expression and](https://youtu.be/upMpPtQuc0c?t=01h13m12s)

[grabbed the type](https://youtu.be/upMpPtQuc0c?t=01h13m14s)

[back uh so if we do fu.](https://youtu.be/upMpPtQuc0c?t=01h13m16s)

[name uh and then this guy here should](https://youtu.be/upMpPtQuc0c?t=01h13m20s)

[give](https://youtu.be/upMpPtQuc0c?t=01h13m24s)

[us was it what was it it was underneath](https://youtu.be/upMpPtQuc0c?t=01h13m26s)

[name](https://youtu.be/upMpPtQuc0c?t=01h13m35s)

[uh I we could hunt it](https://youtu.be/upMpPtQuc0c?t=01h13m40s)

[by Guess](https://youtu.be/upMpPtQuc0c?t=01h13m44s)

[value I feel like we can we could](https://youtu.be/upMpPtQuc0c?t=01h13m47s)

[resolve the tip but do we care like](https://youtu.be/upMpPtQuc0c?t=01h13m50s)

[that's the question is do we care about](https://youtu.be/upMpPtQuc0c?t=01h13m53s)

[the](https://youtu.be/upMpPtQuc0c?t=01h13m55s)

[type I don't know if we](https://youtu.be/upMpPtQuc0c?t=01h13m58s)

[do you think you just grab it on Magic](https://youtu.be/upMpPtQuc0c?t=01h14m01s)

[string again grab it on Magic string](https://youtu.be/upMpPtQuc0c?t=01h14m03s)

[because we we will know if we get a](https://youtu.be/upMpPtQuc0c?t=01h14m06s)

[string that doesn't match any of ours](https://youtu.be/upMpPtQuc0c?t=01h14m08s)

[and we can just say nah I I'm I am and](https://youtu.be/upMpPtQuc0c?t=01h14m10s)

[if we're in the same attribute it's](https://youtu.be/upMpPtQuc0c?t=01h14m13s)

[unlikely and if we also check the member](https://youtu.be/upMpPtQuc0c?t=01h14m14s)

[that's on AK the type whatever I forget](https://youtu.be/upMpPtQuc0c?t=01h14m18s)

[what we called it that give a good](https://youtu.be/upMpPtQuc0c?t=01h14m22s)

[double check that if you're going that](https://youtu.be/upMpPtQuc0c?t=01h14m24s)

[in depth yeah because that's the](https://youtu.be/upMpPtQuc0c?t=01h14m25s)

[question is how much do you want to](https://youtu.be/upMpPtQuc0c?t=01h14m27s)

[inspect I think that's probably okay](https://youtu.be/upMpPtQuc0c?t=01h14m29s)

[name identifier value I want to go](https://youtu.be/upMpPtQuc0c?t=01h14m32s)

[name identifier.](https://youtu.be/upMpPtQuc0c?t=01h14m36s)

[value and actually what I could probably](https://youtu.be/upMpPtQuc0c?t=01h14m40s)

[just do is value](https://youtu.be/upMpPtQuc0c?t=01h14m42s)

[text oh do we care if somebody specifies](https://youtu.be/upMpPtQuc0c?t=01h14m44s)

[the enum with an](https://youtu.be/upMpPtQuc0c?t=01h14m48s)

[integer](https://youtu.be/upMpPtQuc0c?t=01h14m52s)

[no no I just I I think I think that is a](https://youtu.be/upMpPtQuc0c?t=01h14m54s)

[bridge what if they're using it for](https://youtu.be/upMpPtQuc0c?t=01h15m00s)

[EA but that seems like the most likely](https://youtu.be/upMpPtQuc0c?t=01h15m02s)

[case but I](https://youtu.be/upMpPtQuc0c?t=01h15m04s)

[don't but they would so specifically](https://youtu.be/upMpPtQuc0c?t=01h15m06s)

[let's be clear what I'm do we care if](https://youtu.be/upMpPtQuc0c?t=01h15m10s)

[somebody does something weird like like](https://youtu.be/upMpPtQuc0c?t=01h15m13s)

[saying that's](https://youtu.be/upMpPtQuc0c?t=01h15m16s)

[one doing do we care to support that use](https://youtu.be/upMpPtQuc0c?t=01h15m17s)

[case](https://youtu.be/upMpPtQuc0c?t=01h15m22s)

[nah I don't think so if you're doing](https://youtu.be/upMpPtQuc0c?t=01h15m24s)

[that you're you're already asking for](https://youtu.be/upMpPtQuc0c?t=01h15m26s)

[hard stuff and you can go ride your own](https://youtu.be/upMpPtQuc0c?t=01h15m28s)

[tests yeah I kind of agree](https://youtu.be/upMpPtQuc0c?t=01h15m30s)

[like okay also what's this thing flading](https://youtu.be/upMpPtQuc0c?t=01h15m34s)

[thing on the top is that a pre feature](https://youtu.be/upMpPtQuc0c?t=01h15m38s)

[yeah Isn't that cool it shows you the](https://youtu.be/upMpPtQuc0c?t=01h15m41s)

[context to where you're at what feature](https://youtu.be/upMpPtQuc0c?t=01h15m42s)

[is that I don't remember it was what so](https://youtu.be/upMpPtQuc0c?t=01h15m44s)

[bear in mind I'm running preview visual](https://youtu.be/upMpPtQuc0c?t=01h15m46s)

[studio so some of the stuff that's on I](https://youtu.be/upMpPtQuc0c?t=01h15m48s)

[I I've quickly learned I have features](https://youtu.be/upMpPtQuc0c?t=01h15m52s)

[in Visual Studio by running previews](https://youtu.be/upMpPtQuc0c?t=01h15m54s)

[that don't exist in regular one like for](https://youtu.be/upMpPtQuc0c?t=01h15m56s)

[example my options window appears to be](https://youtu.be/upMpPtQuc0c?t=01h15m58s)

[crashing I don't think stable Visual](https://youtu.be/upMpPtQuc0c?t=01h16m00s)

[Studio does that that's a good](https://youtu.be/upMpPtQuc0c?t=01h16m02s)

[feature why Visual](https://youtu.be/upMpPtQuc0c?t=01h16m05s)

[Studio but yes it showed up as defaulted](https://youtu.be/upMpPtQuc0c?t=01h16m11s)

[on on one of the yep and visual studio](https://youtu.be/upMpPtQuc0c?t=01h16m14s)

[um sorry about that it it showed up on](https://youtu.be/upMpPtQuc0c?t=01h16m18s)

[one of the latest previews](https://youtu.be/upMpPtQuc0c?t=01h16m21s)

[as being on which I thought it was](https://youtu.be/upMpPtQuc0c?t=01h16m24s)

[rather slick but even if you aren't on](https://youtu.be/upMpPtQuc0c?t=01h16m26s)

[preview check the preview features under](https://youtu.be/upMpPtQuc0c?t=01h16m28s)

[your options because sometimes what they](https://youtu.be/upMpPtQuc0c?t=01h16m29s)

[do is they release the feature and](https://youtu.be/upMpPtQuc0c?t=01h16m32s)

[initially they release the feature and](https://youtu.be/upMpPtQuc0c?t=01h16m34s)

[only the preview build gets it and then](https://youtu.be/upMpPtQuc0c?t=01h16m35s)

[eventually they release it into the full](https://youtu.be/upMpPtQuc0c?t=01h16m37s)

[version but it's off and behind a](https://youtu.be/upMpPtQuc0c?t=01h16m39s)

[feature flag and then when it's finally](https://youtu.be/upMpPtQuc0c?t=01h16m41s)

[ready then they turn it all the way on](https://youtu.be/upMpPtQuc0c?t=01h16m44s)

[oh I'm still on 3.0 of my preview may I](https://youtu.be/upMpPtQuc0c?t=01h16m46s)

[have to upgrade to](https://youtu.be/upMpPtQuc0c?t=01h16m49s)

[4.0 yeah okay so I I think we go here](https://youtu.be/upMpPtQuc0c?t=01h16m50s)

[and for](https://youtu.be/upMpPtQuc0c?t=01h16m54s)

[reference](https://youtu.be/upMpPtQuc0c?t=01h16m55s)

[um uh let's see first or](https://youtu.be/upMpPtQuc0c?t=01h16m57s)

[default](https://youtu.be/upMpPtQuc0c?t=01h16m59s)

[is uh because we're going to](https://youtu.be/upMpPtQuc0c?t=01h17m02s)

[do uh](https://youtu.be/upMpPtQuc0c?t=01h17m05s)

[member uh I'm just going to do member](https://youtu.be/upMpPtQuc0c?t=01h17m07s)

[expression so that](https://youtu.be/upMpPtQuc0c?t=01h17m09s)

[seems and](https://youtu.be/upMpPtQuc0c?t=01h17m12s)

[actually we could just do right here we](https://youtu.be/upMpPtQuc0c?t=01h17m16s)

[could go name do identifier do value](https://youtu.be/upMpPtQuc0c?t=01h17m18s)

[text equals I mean why why break this](https://youtu.be/upMpPtQuc0c?t=01h17m24s)

[out when I can do it all in one simple](https://youtu.be/upMpPtQuc0c?t=01h17m28s)

[property pattern match we're probably](https://youtu.be/upMpPtQuc0c?t=01h17m30s)

[going to have to use that more times](https://youtu.be/upMpPtQuc0c?t=01h17m33s)

[right would it be worth putting out a](https://youtu.be/upMpPtQuc0c?t=01h17m34s)

[constant in that same constant class uh](https://youtu.be/upMpPtQuc0c?t=01h17m35s)

[we are](https://youtu.be/upMpPtQuc0c?t=01h17m38s)

[definitely uh going to be doing that uh](https://youtu.be/upMpPtQuc0c?t=01h17m39s)

[let's see hold on what is this thing](https://youtu.be/upMpPtQuc0c?t=01h17m43s)

[squating about a property sub pattern](https://youtu.be/upMpPtQuc0c?t=01h17m44s)

[requires a reference to the property or](https://youtu.be/upMpPtQuc0c?t=01h17m46s)

[field to be matched](https://youtu.be/upMpPtQuc0c?t=01h17m48s)

[oh](https://youtu.be/upMpPtQuc0c?t=01h17m52s)

[oh that's right no no no I have this](https://youtu.be/upMpPtQuc0c?t=01h17m54s)

[right name name I think no I just the](https://youtu.be/upMpPtQuc0c?t=01h17m56s)

[colon goes](https://youtu.be/upMpPtQuc0c?t=01h17m59s)

[there](https://youtu.be/upMpPtQuc0c?t=01h18m02s)

[so we](https://youtu.be/upMpPtQuc0c?t=01h18m04s)

[do this and this just becomes a return](https://youtu.be/upMpPtQuc0c?t=01h18m06s)

[right so for for the and then we don't](https://youtu.be/upMpPtQuc0c?t=01h18m10s)

[need that anymore we can literally just](https://youtu.be/upMpPtQuc0c?t=01h18m12s)

[if we have the so this will fall apart](https://youtu.be/upMpPtQuc0c?t=01h18m15s)

[if we add more members to the en](https://youtu.be/upMpPtQuc0c?t=01h18m17s)

[whatever right air checking is not](https://youtu.be/upMpPtQuc0c?t=01h18m19s)

[something I'm interested in at the](https://youtu.be/upMpPtQuc0c?t=01h18m21s)

[moment](https://youtu.be/upMpPtQuc0c?t=01h18m22s)

[or when we and then we change that](https://youtu.be/upMpPtQuc0c?t=01h18m24s)

[member name correct well so all of these](https://youtu.be/upMpPtQuc0c?t=01h18m25s)

[magic strings should end up in these um](https://youtu.be/upMpPtQuc0c?t=01h18m29s)

[this constant file that we have here](https://youtu.be/upMpPtQuc0c?t=01h18m32s)

[right so they they should they should](https://youtu.be/upMpPtQuc0c?t=01h18m35s)

[all go there uh but make it work make it](https://youtu.be/upMpPtQuc0c?t=01h18m36s)

[right make it fast this is the make it](https://youtu.be/upMpPtQuc0c?t=01h18m40s)

[work phase um okay so skip notable](https://youtu.be/upMpPtQuc0c?t=01h18m42s)

[parameters and I think what we're going](https://youtu.be/upMpPtQuc0c?t=01h18m46s)

[to do is we're going to move this guy](https://youtu.be/upMpPtQuc0c?t=01h18m47s)

[inside of here because if we don't get a](https://youtu.be/upMpPtQuc0c?t=01h18m48s)

[Target type we don't care about the](https://youtu.be/upMpPtQuc0c?t=01h18m51s)

[other things right like we don't have a](https://youtu.be/upMpPtQuc0c?t=01h18m53s)

[target class to play](https://youtu.be/upMpPtQuc0c?t=01h18m55s)

[with um and in this case here this is](https://youtu.be/upMpPtQuc0c?t=01h18m57s)

[pushing through I'm just wondering if I](https://youtu.be/upMpPtQuc0c?t=01h19m01s)

[break](https://youtu.be/upMpPtQuc0c?t=01h19m02s)

[out this guy](https://youtu.be/upMpPtQuc0c?t=01h19m04s)

[here if I should have it return more](https://youtu.be/upMpPtQuc0c?t=01h19m07s)

[than](https://youtu.be/upMpPtQuc0c?t=01h19m10s)

[this](https://youtu.be/upMpPtQuc0c?t=01h19m12s)

[um I'm kind of thinking I do](https://youtu.be/upMpPtQuc0c?t=01h19m14s)

[this and this in the interest of](https://youtu.be/upMpPtQuc0c?t=01h19m19s)

[simplicity](https://youtu.be/upMpPtQuc0c?t=01h19m22s)

[right good old tuples](https://youtu.be/upMpPtQuc0c?t=01h19m23s)

[yeah this is going to be unhappy with me](https://youtu.be/upMpPtQuc0c?t=01h19m29s)

[uh one thing I don't like about them](https://youtu.be/upMpPtQuc0c?t=01h19m33s)

[sometimes when you return them out](https://youtu.be/upMpPtQuc0c?t=01h19m34s)

[they're you have to kind of know that](https://youtu.be/upMpPtQuc0c?t=01h19m36s)

[they're being returned out because](https://youtu.be/upMpPtQuc0c?t=01h19m37s)

[they're sometimes hard to discover or](https://youtu.be/upMpPtQuc0c?t=01h19m38s)

[more difficult to discover yeah and I'm](https://youtu.be/upMpPtQuc0c?t=01h19m40s)

[noticing this thing is going to get](https://youtu.be/upMpPtQuc0c?t=01h19m42s)

[obnoxious because it's going to complain](https://youtu.be/upMpPtQuc0c?t=01h19m44s)

[about the null case and I don't really](https://youtu.be/upMpPtQuc0c?t=01h19m46s)

[cuz I I want to be able to leverage the](https://youtu.be/upMpPtQuc0c?t=01h19m49s)

[first or default so okay so what do we](https://youtu.be/upMpPtQuc0c?t=01h19m50s)

[actually need out of this](https://youtu.be/upMpPtQuc0c?t=01h19m52s)

[guy uh is name type](https://youtu.be/upMpPtQuc0c?t=01h19m55s)

[symbol I think what we should do is we](https://youtu.be/upMpPtQuc0c?t=01h20m00s)

[should return](https://youtu.be/upMpPtQuc0c?t=01h20m03s)

[back because before we were just](https://youtu.be/upMpPtQuc0c?t=01h20m07s)

[returning back the type I think what we](https://youtu.be/upMpPtQuc0c?t=01h20m09s)

[do is this where it's worth just](https://youtu.be/upMpPtQuc0c?t=01h20m12s)

[breaking the whole thing out and just](https://youtu.be/upMpPtQuc0c?t=01h20m13s)

[doing this separately returning a and](https://youtu.be/upMpPtQuc0c?t=01h20m15s)

[yeah I think that's probably a good](https://youtu.be/upMpPtQuc0c?t=01h20m17s)

[idea uh](https://youtu.be/upMpPtQuc0c?t=01h20m20s)

[uh uh because it was clearly hard code](https://youtu.be/upMpPtQuc0c?t=01h20m25s)

[for somebody to read it before so we're](https://youtu.be/upMpPtQuc0c?t=01h20m28s)

[going to like not do that](https://youtu.be/upMpPtQuc0c?t=01h20m30s)

[mess we'll do](https://youtu.be/upMpPtQuc0c?t=01h20m33s)

[that and that'll get us to there then](https://youtu.be/upMpPtQuc0c?t=01h20m36s)

[this will get us into here and then get](https://youtu.be/upMpPtQuc0c?t=01h20m39s)

[Target type attribute right so this will](https://youtu.be/upMpPtQuc0c?t=01h20m42s)

[go here that will go there and](https://youtu.be/upMpPtQuc0c?t=01h20m46s)

[then](https://youtu.be/upMpPtQuc0c?t=01h20m51s)

[we need to](https://youtu.be/upMpPtQuc0c?t=01h20m54s)

[handle the](https://youtu.be/upMpPtQuc0c?t=01h20m58s)

[the what I want to do is this and what I](https://youtu.be/upMpPtQuc0c?t=01h21m00s)

[want to do is I want to invert the if](https://youtu.be/upMpPtQuc0c?t=01h21m02s)

[statement like that and then I want to](https://youtu.be/upMpPtQuc0c?t=01h21m05s)

[put the diagnostic inside of here and](https://youtu.be/upMpPtQuc0c?t=01h21m07s)

[then I want to early](https://youtu.be/upMpPtQuc0c?t=01h21m10s)

[return okay co-pilot you want to show](https://youtu.be/upMpPtQuc0c?t=01h21m14s)

[off do the rest for](https://youtu.be/upMpPtQuc0c?t=01h21m16s)

[me ha See can't even figure it out](https://youtu.be/upMpPtQuc0c?t=01h21m19s)

[uh let's see so uh](https://youtu.be/upMpPtQuc0c?t=01h21m24s)

[[Music]](https://youtu.be/upMpPtQuc0c?t=01h21m27s)

[pool uh skip](https://youtu.be/upMpPtQuc0c?t=01h21m28s)

[nullable par](https://youtu.be/upMpPtQuc0c?t=01h21m32s)

[parameters boom okay and then I think](https://youtu.be/upMpPtQuc0c?t=01h21m35s)

[down](https://youtu.be/upMpPtQuc0c?t=01h21m38s)

[here I think what we're going to do here](https://youtu.be/upMpPtQuc0c?t=01h21m39s)

[is just rename this to skip nullable](https://youtu.be/upMpPtQuc0c?t=01h21m41s)

[parameters](https://youtu.be/upMpPtQuc0c?t=01h21m47s)

[boom and then this becomes skip Noble](https://youtu.be/upMpPtQuc0c?t=01h21m49s)

[par](https://youtu.be/upMpPtQuc0c?t=01h21m52s)

[parameters okay so that goes there that](https://youtu.be/upMpPtQuc0c?t=01h21m53s)

[goes like that that goes like that](https://youtu.be/upMpPtQuc0c?t=01h21m56s)

[everyone's happy um assume whatever we](https://youtu.be/upMpPtQuc0c?t=01h21m57s)

[eventually name our thing to we'll](https://youtu.be/upMpPtQuc0c?t=01h22m00s)

[probably just want rename all to that](https://youtu.be/upMpPtQuc0c?t=01h22m02s)

[yeah but I think this gets us through to](https://youtu.be/upMpPtQuc0c?t=01h22m04s)

[here this gets us through to here this](https://youtu.be/upMpPtQuc0c?t=01h22m06s)

[now gets this generated up properly](https://youtu.be/upMpPtQuc0c?t=01h22m08s)

[right so this is all on the parsing side](https://youtu.be/upMpPtQuc0c?t=01h22m11s)

[and I would argue the parsing side is](https://youtu.be/upMpPtQuc0c?t=01h22m14s)

[the hard side to actually Implement](https://youtu.be/upMpPtQuc0c?t=01h22m17s)

[right in general my opinion is that](https://youtu.be/upMpPtQuc0c?t=01h22m20s)

[that's where oh wow we can just keep](https://youtu.be/upMpPtQuc0c?t=01h22m22s)

[collapsing look at that look at that](https://youtu.be/upMpPtQuc0c?t=01h22m25s)

[clean well I don't know if I'd call that](https://youtu.be/upMpPtQuc0c?t=01h22m29s)

[deeply nested with link statement clean](https://youtu.be/upMpPtQuc0c?t=01h22m31s)

[but you know each his own okay so that](https://youtu.be/upMpPtQuc0c?t=01h22m33s)

[this gets us to here so now we need to](https://youtu.be/upMpPtQuc0c?t=01h22m36s)

[go to the actual generation side of the](https://youtu.be/upMpPtQuc0c?t=01h22m38s)

[fence right because it's all well and](https://youtu.be/upMpPtQuc0c?t=01h22m41s)

[good to have this but at some point we](https://youtu.be/upMpPtQuc0c?t=01h22m43s)

[now need to take that that Target so all](https://youtu.be/upMpPtQuc0c?t=01h22m45s)

[I did was line 46 on here I basically](https://youtu.be/upMpPtQuc0c?t=01h22m48s)

[just had skip this might be dumb but uh](https://youtu.be/upMpPtQuc0c?t=01h22m50s)

[you also used element at which gives me](https://youtu.be/upMpPtQuc0c?t=01h22m55s)

[great](https://youtu.be/upMpPtQuc0c?t=01h22m57s)

[pause don't use I don't use element ad](https://youtu.be/upMpPtQuc0c?t=01h22m58s)

[on an indexable](https://youtu.be/upMpPtQuc0c?t=01h23m01s)

[collection well I was doing it because M](https://youtu.be/upMpPtQuc0c?t=01h23m03s)

[ability because parameters and I hadn't](https://youtu.be/upMpPtQuc0c?t=01h23m06s)

[I hadn't processed how I wanted to do](https://youtu.be/upMpPtQuc0c?t=01h23m08s)

[that yet so I was I was](https://youtu.be/upMpPtQuc0c?t=01h23m09s)

[spinning oh I see so you were ah gotcha](https://youtu.be/upMpPtQuc0c?t=01h23m12s)

[okay so this so now we have to know if](https://youtu.be/upMpPtQuc0c?t=01h23m16s)

[the oh so we might have one more parsing](https://youtu.be/upMpPtQuc0c?t=01h23m18s)

[thing to do real quick because we yeah](https://youtu.be/upMpPtQuc0c?t=01h23m21s)

[that's the if the setting's on but we](https://youtu.be/upMpPtQuc0c?t=01h23m24s)

[also need on the parsing side is the](https://youtu.be/upMpPtQuc0c?t=01h23m26s)

[parameter knowable right yeah so that's](https://youtu.be/upMpPtQuc0c?t=01h23m28s)

[the part that I that's kind of where I](https://youtu.be/upMpPtQuc0c?t=01h23m30s)

[stopped that's where you caught me ah](https://youtu.be/upMpPtQuc0c?t=01h23m32s)

[perfect okay so here we find the](https://youtu.be/upMpPtQuc0c?t=01h23m35s)

[Constructor it pulls the parameters out](https://youtu.be/upMpPtQuc0c?t=01h23m37s)

[and I think right](https://youtu.be/upMpPtQuc0c?t=01h23m40s)

[here we literally just come in here and](https://youtu.be/upMpPtQuc0c?t=01h23m43s)

[I I think what we probably want is](https://youtu.be/upMpPtQuc0c?t=01h23m45s)

[public bu is](https://youtu.be/upMpPtQuc0c?t=01h23m48s)

[nullable](https://youtu.be/upMpPtQuc0c?t=01h23m51s)

[right for now we're just going to go](https://youtu.be/upMpPtQuc0c?t=01h23m53s)

[with get and I think we'll just run our](https://youtu.be/upMpPtQuc0c?t=01h23m55s)

[test again and catch it right here](https://youtu.be/upMpPtQuc0c?t=01h23m58s)

[because I think we can probably detect](https://youtu.be/upMpPtQuc0c?t=01h23m59s)

[it inside of here I think but let's](https://youtu.be/upMpPtQuc0c?t=01h24m01s)

[let's look at that or actually hang on](https://youtu.be/upMpPtQuc0c?t=01h24m05s)

[we can probably our sharp Labs thing if](https://youtu.be/upMpPtQuc0c?t=01h24m07s)

[we go](https://youtu.be/upMpPtQuc0c?t=01h24m11s)

[here uh let's see parameter list](https://youtu.be/upMpPtQuc0c?t=01h24m12s)

[parameter uh let's see here do you have](https://youtu.be/upMpPtQuc0c?t=01h24m17s)

[a](https://youtu.be/upMpPtQuc0c?t=01h24m21s)

[nice easy way of doing](https://youtu.be/upMpPtQuc0c?t=01h24m24s)

[it uh parameter](https://youtu.be/upMpPtQuc0c?t=01h24m27s)

[default so if it has a](https://youtu.be/upMpPtQuc0c?t=01h24m30s)

[default which I think is the case that](https://youtu.be/upMpPtQuc0c?t=01h24m33s)

[we're testing currently right](https://youtu.be/upMpPtQuc0c?t=01h24m35s)

[so actually that's a good point if it](https://youtu.be/upMpPtQuc0c?t=01h24m38s)

[has a default we skip regardless of what](https://youtu.be/upMpPtQuc0c?t=01h24m41s)

[the default](https://youtu.be/upMpPtQuc0c?t=01h24m43s)

[is](https://youtu.be/upMpPtQuc0c?t=01h24m45s)

[um CU you would the default is null](https://youtu.be/upMpPtQuc0c?t=01h24m47s)

[because you could still have you could](https://youtu.be/upMpPtQuc0c?t=01h24m50s)

[have a non-nullable type with a default](https://youtu.be/upMpPtQuc0c?t=01h24m52s)

[and you could pass a](https://youtu.be/upMpPtQuc0c?t=01h24m54s)

[null but the only way that happens is if](https://youtu.be/upMpPtQuc0c?t=01h24m56s)

[it's a value because defaults have to be](https://youtu.be/upMpPtQuc0c?t=01h24m58s)

[compile time](https://youtu.be/upMpPtQuc0c?t=01h25m00s)

[constants that's true the only compile](https://youtu.be/upMpPtQuc0c?t=01h25m02s)

[time constant of a reference type is](https://youtu.be/upMpPtQuc0c?t=01h25m04s)

[null I](https://youtu.be/upMpPtQuc0c?t=01h25m06s)

[believe can you not do a default](https://youtu.be/upMpPtQuc0c?t=01h25m10s)

[string oh empty yes no you thank you I](https://youtu.be/upMpPtQuc0c?t=01h25m13s)

[stand](https://youtu.be/upMpPtQuc0c?t=01h25m16s)

[corrected good example but in that case](https://youtu.be/upMpPtQuc0c?t=01h25m18s)

[would you want to test for an argument](https://youtu.be/upMpPtQuc0c?t=01h25m23s)

[null](https://youtu.be/upMpPtQuc0c?t=01h25m26s)

[exception if my if my string is not a](https://youtu.be/upMpPtQuc0c?t=01h25m27s)

[nullable string I argue that I would](https://youtu.be/upMpPtQuc0c?t=01h25m31s)

[because okay I can if I have nullable](https://youtu.be/upMpPtQuc0c?t=01h25m35s)

[off I can still force](https://youtu.be/upMpPtQuc0c?t=01h25m38s)

[in got it I can force null into there](https://youtu.be/upMpPtQuc0c?t=01h25m41s)

[right so you're saying you're saying in](https://youtu.be/upMpPtQuc0c?t=01h25m44s)

[this case you would still want the test](https://youtu.be/upMpPtQuc0c?t=01h25m46s)

[to](https://youtu.be/upMpPtQuc0c?t=01h25m48s)

[fire don't you think I would think I can](https://youtu.be/upMpPtQuc0c?t=01h25m49s)

[accept that I can accept that](https://youtu.be/upMpPtQuc0c?t=01h25m52s)

[so uh so we want to check for a default](https://youtu.be/upMpPtQuc0c?t=01h25m55s)

[with a value of no](https://youtu.be/upMpPtQuc0c?t=01h25m59s)

[literal and if this is a value type](https://youtu.be/upMpPtQuc0c?t=01h26m01s)

[instead of a reference type one test at](https://youtu.be/upMpPtQuc0c?t=01h26m04s)

[a](https://youtu.be/upMpPtQuc0c?t=01h26m07s)

[time one test at a time then those](https://youtu.be/upMpPtQuc0c?t=01h26m08s)

[definitely have defaults that aren't all](https://youtu.be/upMpPtQuc0c?t=01h26m11s)

[uh so let's go here so uh let's see so](https://youtu.be/upMpPtQuc0c?t=01h26m14s)

[if uh](https://youtu.be/upMpPtQuc0c?t=01h26m17s)

[symbol uh def](https://youtu.be/upMpPtQuc0c?t=01h26m19s)

[default has explicit default value well](https://youtu.be/upMpPtQuc0c?t=01h26m22s)

[that looks real convenient to](https://youtu.be/upMpPtQuc0c?t=01h26m26s)

[me uh wow I impressed that whoever has](https://youtu.be/upMpPtQuc0c?t=01h26m29s)

[to write out this whenever they write a](https://youtu.be/upMpPtQuc0c?t=01h26m32s)

[new feature must it must be a pain but](https://youtu.be/upMpPtQuc0c?t=01h26m34s)

[also this is kind of beautiful in its un](https://youtu.be/upMpPtQuc0c?t=01h26m36s)

[convoluted way I the compiler is](https://youtu.be/upMpPtQuc0c?t=01h26m38s)

[complex but you are correct there is an](https://youtu.be/upMpPtQuc0c?t=01h26m43s)

[Elegance to it um explicit default value](https://youtu.be/upMpPtQuc0c?t=01h26m46s)

[what is your type](https://youtu.be/upMpPtQuc0c?t=01h26m50s)

[like the fact that I'm not doing doing](https://youtu.be/upMpPtQuc0c?t=01h26m52s)

[like blind string comparisons and](https://youtu.be/upMpPtQuc0c?t=01h26m54s)

[pulling question marks off really](https://youtu.be/upMpPtQuc0c?t=01h26m55s)

[surprises me because that's what I](https://youtu.be/upMpPtQuc0c?t=01h26m57s)

[thought I would be doing uh let's see](https://youtu.be/upMpPtQuc0c?t=01h26m58s)

[is nullable](https://youtu.be/upMpPtQuc0c?t=01h27m01s)

[equals I](https://youtu.be/upMpPtQuc0c?t=01h27m04s)

[think I think we do](https://youtu.be/upMpPtQuc0c?t=01h27m09s)

[this](https://youtu.be/upMpPtQuc0c?t=01h27m11s)

[but let's run it and find](https://youtu.be/upMpPtQuc0c?t=01h27m13s)

[out uh let's see the name a does not](https://youtu.be/upMpPtQuc0c?t=01h27m18s)

[exist well that sounds like somebody](https://youtu.be/upMpPtQuc0c?t=01h27m22s)

[messed up uh the name attribute exists](https://youtu.be/upMpPtQuc0c?t=01h27m24s)

[though RSE](https://youtu.be/upMpPtQuc0c?t=01h27m30s)

[repeat okay so we come in here symbol](https://youtu.be/upMpPtQuc0c?t=01h27m41s)

[has explicit default](https://youtu.be/upMpPtQuc0c?t=01h27m45s)

[value](https://youtu.be/upMpPtQuc0c?t=01h27m51s)

[okay okay we got that okay perfect so](https://youtu.be/upMpPtQuc0c?t=01h27m53s)

[now we go over to here so we're going to](https://youtu.be/upMpPtQuc0c?t=01h27m57s)

[do we're going to do](https://youtu.be/upMpPtQuc0c?t=01h28m00s)

[this right I](https://youtu.be/upMpPtQuc0c?t=01h28m02s)

[think um I'm looking to see how we do](https://youtu.be/upMpPtQuc0c?t=01h28m06s)

[parameters yeah](https://youtu.be/upMpPtQuc0c?t=01h28m10s)

[so because this was looking to](https://youtu.be/upMpPtQuc0c?t=01h28m14s)

[see wh which parameter we were on Noble](https://youtu.be/upMpPtQuc0c?t=01h28m17s)

[parameter index so you are pulling the](https://youtu.be/upMpPtQuc0c?t=01h28m21s)

[nullable parameter index out why is test](https://youtu.be/upMpPtQuc0c?t=01h28m23s)

[parameters nullable just out of](https://youtu.be/upMpPtQuc0c?t=01h28m26s)

[curiosity you're thinking there should](https://youtu.be/upMpPtQuc0c?t=01h28m35s)

[be a default list no I don't like that](https://youtu.be/upMpPtQuc0c?t=01h28m37s)

[as much but I mean we can just do](https://youtu.be/upMpPtQuc0c?t=01h28m39s)

[this all right so rather than doing this](https://youtu.be/upMpPtQuc0c?t=01h28m42s)

[we can do is](https://youtu.be/upMpPtQuc0c?t=01h28m45s)

[nullable uh and we got to handle the](https://youtu.be/upMpPtQuc0c?t=01h28m48s)

[case so if the settings on and the](https://youtu.be/upMpPtQuc0c?t=01h28m50s)

[parameters nullable we'll continue we](https://youtu.be/upMpPtQuc0c?t=01h28m54s)

[won't generate the test our unit test](https://youtu.be/upMpPtQuc0c?t=01h28m56s)

[goes green and The Peasants](https://youtu.be/upMpPtQuc0c?t=01h28m58s)

[Rejoice](https://youtu.be/upMpPtQuc0c?t=01h29m04s)

[no okay well that didn't quite work](https://youtu.be/upMpPtQuc0c?t=01h29m06s)

[mismatch in the number of Diagnostics](https://youtu.be/upMpPtQuc0c?t=01h29m09s)

[return expected zero it's just an off by](https://youtu.be/upMpPtQuc0c?t=01h29m11s)

[one error just](https://youtu.be/upMpPtQuc0c?t=01h29m13s)

[d++ uh let's see the name test](https://youtu.be/upMpPtQuc0c?t=01h29m17s)

[generation Behavior does not exist the](https://youtu.be/upMpPtQuc0c?t=01h29m19s)

[current context okay now we're seeing](https://youtu.be/upMpPtQuc0c?t=01h29m22s)

[the compilation](https://youtu.be/upMpPtQuc0c?t=01h29m24s)

[problem that explains a little bit from](https://youtu.be/upMpPtQuc0c?t=01h29m25s)

[before okay um test generation behavior](https://youtu.be/upMpPtQuc0c?t=01h29m28s)

[is that not what](https://youtu.be/upMpPtQuc0c?t=01h29m32s)

[we called](https://youtu.be/upMpPtQuc0c?t=01h29m34s)

[it oh I bet you I know it's a reference](https://youtu.be/upMpPtQuc0c?t=01h29m37s)

[problem it's not](https://youtu.be/upMpPtQuc0c?t=01h29m40s)

[a no it's a namespace](https://youtu.be/upMpPtQuc0c?t=01h29m42s)

[problem oh because it was in the test](https://youtu.be/upMpPtQuc0c?t=01h29m46s)

[project before yeah yeah yeah so](https://youtu.be/upMpPtQuc0c?t=01h29m49s)

[because the the test as we set it up we](https://youtu.be/upMpPtQuc0c?t=01h29m52s)

[only included the automach Nam space](https://youtu.be/upMpPtQuc0c?t=01h29m56s)

[which is all anyone is expected to have](https://youtu.be/upMpPtQuc0c?t=01h29m59s)

[to include the only exception is if you](https://youtu.be/upMpPtQuc0c?t=01h30m01s)

[write your own custom resolver and then](https://youtu.be/upMpPtQuc0c?t=01h30m03s)

[you got to include the resolver name](https://youtu.be/upMpPtQuc0c?t=01h30m04s)

[space I](https://youtu.be/upMpPtQuc0c?t=01h30m07s)

[win wow I win I'm impressed okay uh](https://youtu.be/upMpPtQuc0c?t=01h30m09s)

[immediately](https://youtu.be/upMpPtQuc0c?t=01h30m14s)

[commit proof of](https://youtu.be/upMpPtQuc0c?t=01h30m17s)

[working B](https://youtu.be/upMpPtQuc0c?t=01h30m20s)

[push H so now the now the test goes okay](https://youtu.be/upMpPtQuc0c?t=01h30m22s)

[so we've got that much working uh](https://youtu.be/upMpPtQuc0c?t=01h30m26s)

[actually before we get too carried away](https://youtu.be/upMpPtQuc0c?t=01h30m30s)

[before we too car let's just run all the](https://youtu.be/upMpPtQuc0c?t=01h30m31s)

[tests just just just to make sure we](https://youtu.be/upMpPtQuc0c?t=01h30m33s)

[didn't F okay good like I don't think we](https://youtu.be/upMpPtQuc0c?t=01h30m36s)

[broke anything else but let's just let's](https://youtu.be/upMpPtQuc0c?t=01h30m39s)

[just make sure we didn't break it you](https://youtu.be/upMpPtQuc0c?t=01h30m41s)

[never know okay so what was what were](https://youtu.be/upMpPtQuc0c?t=01h30m42s)

[the other cases we wanted to test let's](https://youtu.be/upMpPtQuc0c?t=01h30m44s)

[let's build let's build some tests for](https://youtu.be/upMpPtQuc0c?t=01h30m46s)

[those we'll do the whole test driven](https://youtu.be/upMpPtQuc0c?t=01h30m47s)

[development thing because you know it's](https://youtu.be/upMpPtQuc0c?t=01h30m49s)

[working well](https://youtu.be/upMpPtQuc0c?t=01h30m51s)

[it's working well okay so parameter with](https://youtu.be/upMpPtQuc0c?t=01h30m52s)

[I I heard empty string](https://youtu.be/upMpPtQuc0c?t=01h30m57s)

[right sure empty](https://youtu.be/upMpPtQuc0c?t=01h30m59s)

[string uh](https://youtu.be/upMpPtQuc0c?t=01h31m02s)

[does generate test right so we expect](https://youtu.be/upMpPtQuc0c?t=01h31m04s)

[this guy](https://youtu.be/upMpPtQuc0c?t=01h31m09s)

[here to actually gener to actually](https://youtu.be/upMpPtQuc0c?t=01h31m11s)

[generate a test so I you have](https://youtu.be/upMpPtQuc0c?t=01h31m14s)

[to I have to actually go get the test](https://youtu.be/upMpPtQuc0c?t=01h31m17s)

[that I expected to](https://youtu.be/upMpPtQuc0c?t=01h31m19s)

[generate because I expect it to actually](https://youtu.be/upMpPtQuc0c?t=01h31m20s)

[build you know](https://youtu.be/upMpPtQuc0c?t=01h31m23s)

[something um so we expect the actual](https://youtu.be/upMpPtQuc0c?t=01h31m25s)

[output of this guy to look more like](https://youtu.be/upMpPtQuc0c?t=01h31m28s)

[this](https://youtu.be/upMpPtQuc0c?t=01h31m31s)

[uh so given this oh we probably](https://youtu.be/upMpPtQuc0c?t=01h31m34s)

[shouldn't have this thing named token](https://youtu.be/upMpPtQuc0c?t=01h31m37s)

[should we let's change this uh](https://youtu.be/upMpPtQuc0c?t=01h31m39s)

[string uh name oh Kevin you gave me](https://youtu.be/upMpPtQuc0c?t=01h31m41s)

[Builders give you build airs](https://youtu.be/upMpPtQuc0c?t=01h31m45s)

[what I give two you two Constructor test](https://youtu.be/upMpPtQuc0c?t=01h31m48s)

[classes within within the xunit one oh](https://youtu.be/upMpPtQuc0c?t=01h31m53s)

[oops Yeah you want to push it that's](https://youtu.be/upMpPtQuc0c?t=01h31m59s)

[fine uh let's see with null because this](https://youtu.be/upMpPtQuc0c?t=01h32m02s)

[should](https://youtu.be/upMpPtQuc0c?t=01h32m04s)

[be with nll I think](https://youtu.be/upMpPtQuc0c?t=01h32m06s)

[string is it because it it gens the test](https://youtu.be/upMpPtQuc0c?t=01h32m12s)

[name based on the type not the parameter](https://youtu.be/upMpPtQuc0c?t=01h32m15s)

[name I](https://youtu.be/upMpPtQuc0c?t=01h32m18s)

[believe uh guess it would be camel case](https://youtu.be/upMpPtQuc0c?t=01h32m20s)

[yeah which is mildly obnoxious it looks](https://youtu.be/upMpPtQuc0c?t=01h32m25s)

[weird yeah it it it looks weird and it](https://youtu.be/upMpPtQuc0c?t=01h32m29s)

[looks](https://youtu.be/upMpPtQuc0c?t=01h32m32s)

[wrong um with](https://youtu.be/upMpPtQuc0c?t=01h32m33s)

[no is this be you set up or this just](https://youtu.be/upMpPtQuc0c?t=01h32m36s)

[default](https://youtu.be/upMpPtQuc0c?t=01h32m39s)

[Behavior Uh what do you mean the naming](https://youtu.be/upMpPtQuc0c?t=01h32m40s)

[the generation in this case they](https://youtu.be/upMpPtQuc0c?t=01h32m43s)

[generating the method names uh this is](https://youtu.be/upMpPtQuc0c?t=01h32m46s)

[this is my own naming scheme and I'm](https://youtu.be/upMpPtQuc0c?t=01h32m48s)

[very happy like if we want to change it](https://youtu.be/upMpPtQuc0c?t=01h32m50s)

[because these are just generated things](https://youtu.be/upMpPtQuc0c?t=01h32m52s)

[we could fix this like yeah we could](https://youtu.be/upMpPtQuc0c?t=01h32m53s)

[totally change it it kind of makes sense](https://youtu.be/upMpPtQuc0c?t=01h32m56s)

[though it looks weird but it kind of](https://youtu.be/upMpPtQuc0c?t=01h32m59s)

[makes sense yeah and it did make this](https://youtu.be/upMpPtQuc0c?t=01h33m01s)

[sweeping assumption that these things](https://youtu.be/upMpPtQuc0c?t=01h33m04s)

[would like we're we're going to run into](https://youtu.be/upMpPtQuc0c?t=01h33m07s)

[a bit of an issue with what your example](https://youtu.be/upMpPtQuc0c?t=01h33m09s)

[test above because Auto marer is](https://youtu.be/upMpPtQuc0c?t=01h33m12s)

[populating based on type it's not going](https://youtu.be/upMpPtQuc0c?t=01h33m14s)

[to differentiate parameters by name](https://youtu.be/upMpPtQuc0c?t=01h33m17s)

[String and yeah yeah so it's going to](https://youtu.be/upMpPtQuc0c?t=01h33m19s)

[have a bit of an issue](https://youtu.be/upMpPtQuc0c?t=01h33m23s)

[there now you could work around it right](https://youtu.be/upMpPtQuc0c?t=01h33m26s)

[like rather than ju so for example up](https://youtu.be/upMpPtQuc0c?t=01h33m30s)

[here in](https://youtu.be/upMpPtQuc0c?t=01h33m33s)

[your this guy rather than doing use](https://youtu.be/upMpPtQuc0c?t=01h33m35s)

[because use is going to key on](https://youtu.be/upMpPtQuc0c?t=01h33m38s)

[type you would have to basically](https://youtu.be/upMpPtQuc0c?t=01h33m40s)

[register a custom resolver to know the](https://youtu.be/upMpPtQuc0c?t=01h33m43s)

[difference also why was that needed cuz](https://youtu.be/upMpPtQuc0c?t=01h33m45s)

[I was surprised I don't know why I was](https://youtu.be/upMpPtQuc0c?t=01h33m48s)

[surprised but I was surprised that I](https://youtu.be/upMpPtQuc0c?t=01h33m49s)

[needed to do that and we couldn't get](https://youtu.be/upMpPtQuc0c?t=01h33m51s)

[that based off of the uh it's parameters](https://youtu.be/upMpPtQuc0c?t=01h33m53s)

[so the reason the reason it's needed is](https://youtu.be/upMpPtQuc0c?t=01h33m57s)

[because and and there's an open](https://youtu.be/upMpPtQuc0c?t=01h34m00s)

[discussion feedback welcome um autom](https://youtu.be/upMpPtQuc0c?t=01h34m04s)

[marker when you ask it for a type all it](https://youtu.be/upMpPtQuc0c?t=01h34m07s)

[does is walk through its list of](https://youtu.be/upMpPtQuc0c?t=01h34m10s)

[resolvers to see if it knows how to make](https://youtu.be/upMpPtQuc0c?t=01h34m12s)

[the type so one it looks in its cache to](https://youtu.be/upMpPtQuc0c?t=01h34m14s)

[see have I already made one of these](https://youtu.be/upMpPtQuc0c?t=01h34m17s)

[things if so use that do is the type](https://youtu.be/upMpPtQuc0c?t=01h34m19s)

[looking for auto marer if so return](https://youtu.be/upMpPtQuc0c?t=01h34m22s)

[myself is it an array in which case I'll](https://youtu.be/upMpPtQuc0c?t=01h34m24s)

[do some array magic stuff uh is it](https://youtu.be/upMpPtQuc0c?t=01h34m27s)

[looking for the Disposable one this is](https://youtu.be/upMpPtQuc0c?t=01h34m30s)

[kind of an internal thing for I](https://youtu.be/upMpPtQuc0c?t=01h34m31s)

[disposable support so do that check for](https://youtu.be/upMpPtQuc0c?t=01h34m33s)

[innumerable right check for lazy check](https://youtu.be/upMpPtQuc0c?t=01h34m37s)

[for Funk check for cancellation token](https://youtu.be/upMpPtQuc0c?t=01h34m39s)

[and then the very last one is see if](https://youtu.be/upMpPtQuc0c?t=01h34m42s)

[mock can resolve](https://youtu.be/upMpPtQuc0c?t=01h34m45s)

[it right like this this thing here is](https://youtu.be/upMpPtQuc0c?t=01h34m47s)

[one of the that's the catch all this is](https://youtu.be/upMpPtQuc0c?t=01h34m51s)

[the catch all and the problem is is none](https://youtu.be/upMpPtQuc0c?t=01h34m53s)

[of these match](https://youtu.be/upMpPtQuc0c?t=01h34m55s)

[string and there's been a debate about](https://youtu.be/upMpPtQuc0c?t=01h34m56s)

[should we have a resolver for Strings](https://youtu.be/upMpPtQuc0c?t=01h34m59s)

[should we have a resolver for](https://youtu.be/upMpPtQuc0c?t=01h35m02s)

[goids right there there's types like](https://youtu.be/upMpPtQuc0c?t=01h35m04s)

[that where it's like should](https://youtu.be/upMpPtQuc0c?t=01h35m07s)

[we just to simplify it and the problem](https://youtu.be/upMpPtQuc0c?t=01h35m09s)

[is is because most of the time people](https://youtu.be/upMpPtQuc0c?t=01h35m13s)

[are using this as kind of like a](https://youtu.be/upMpPtQuc0c?t=01h35m15s)

[lightweight di container for spinning](https://youtu.be/upMpPtQuc0c?t=01h35m16s)

[their stuff up it's like no di container](https://youtu.be/upMpPtQuc0c?t=01h35m18s)

[resolves those types for you now it's](https://youtu.be/upMpPtQuc0c?t=01h35m21s)

[very trivial to write a resolver right](https://youtu.be/upMpPtQuc0c?t=01h35m23s)

[because the resolver interface is](https://youtu.be/upMpPtQuc0c?t=01h35m25s)

[literally just this resolve method right](https://youtu.be/upMpPtQuc0c?t=01h35m27s)

[so if you wrote a string resolver inside](https://youtu.be/upMpPtQuc0c?t=01h35m30s)

[of here you would literally just go if](https://youtu.be/upMpPtQuc0c?t=01h35m33s)

[context requested type equals equals](https://youtu.be/upMpPtQuc0c?t=01h35m35s)

[type of string return insert the string](https://youtu.be/upMpPtQuc0c?t=01h35m37s)

[here that I want right done no thinking](https://youtu.be/upMpPtQuc0c?t=01h35m40s)

[and you're Off to the](https://youtu.be/upMpPtQuc0c?t=01h35m44s)

[Races or same thing with goid you could](https://youtu.be/upMpPtQuc0c?t=01h35m47s)

[do good new good and you're done](https://youtu.be/upMpPtQuc0c?t=01h35m50s)

[right but it's one of those we've left](https://youtu.be/upMpPtQuc0c?t=01h35m53s)

[it as a thing but there's also been a](https://youtu.be/upMpPtQuc0c?t=01h35m55s)

[debate about well maybe we should write](https://youtu.be/upMpPtQuc0c?t=01h35m57s)

[the resolver for people and include it](https://youtu.be/upMpPtQuc0c?t=01h36m00s)

[in the library and then they can inject](https://youtu.be/upMpPtQuc0c?t=01h36m01s)

[it where they want](https://youtu.be/upMpPtQuc0c?t=01h36m03s)

[it so they can they you basically pre](https://youtu.be/upMpPtQuc0c?t=01h36m05s)

[written it but it's not actually being](https://youtu.be/upMpPtQuc0c?t=01h36m08s)

[it's not actually in the list of](https://youtu.be/upMpPtQuc0c?t=01h36m10s)

[resolvers I also have a thought that](https://youtu.be/upMpPtQuc0c?t=01h36m11s)

[right now we build this list of resolve](https://youtu.be/upMpPtQuc0c?t=01h36m14s)

[this default list of resolvers in the](https://youtu.be/upMpPtQuc0c?t=01h36m16s)

[Constructor as an instance I have also](https://youtu.be/upMpPtQuc0c?t=01h36m18s)

[wondered if perhaps we should have a](https://youtu.be/upMpPtQuc0c?t=01h36m22s)

[static list that is built that this](https://youtu.be/upMpPtQuc0c?t=01h36m24s)

[thing the the instance makes a copy of](https://youtu.be/upMpPtQuc0c?t=01h36m28s)

[the static list when it's started up](https://youtu.be/upMpPtQuc0c?t=01h36m33s)

[that way if people want to set it once](https://youtu.be/upMpPtQuc0c?t=01h36m35s)

[with their pre-canned list of resolvers](https://youtu.be/upMpPtQuc0c?t=01h36m37s)

[in whatever order they want they can do](https://youtu.be/upMpPtQuc0c?t=01h36m40s)

[it once tce yeah they can do it once](https://youtu.be/upMpPtQuc0c?t=01h36m42s)

[statically and then you don't have to do](https://youtu.be/upMpPtQuc0c?t=01h36m44s)

[it every single time because if you have](https://youtu.be/upMpPtQuc0c?t=01h36m46s)

[one that you want to inject for every](https://youtu.be/upMpPtQuc0c?t=01h36m48s)

[one of your unit tests you have to add](https://youtu.be/upMpPtQuc0c?t=01h36m49s)

[it every time you do an automach](https://youtu.be/upMpPtQuc0c?t=01h36m52s)

[resolver](https://youtu.be/upMpPtQuc0c?t=01h36m53s)

[in versus if there was a stattic now](https://youtu.be/upMpPtQuc0c?t=01h36m54s)

[most people just work around it by](https://youtu.be/upMpPtQuc0c?t=01h36m57s)

[writing a static Factory and you're done](https://youtu.be/upMpPtQuc0c?t=01h36m58s)

[right it's like should we have that or](https://youtu.be/upMpPtQuc0c?t=01h37m00s)

[should people write it if they need it](https://youtu.be/upMpPtQuc0c?t=01h37m02s)

[like so that's the reason this is here](https://youtu.be/upMpPtQuc0c?t=01h37m05s)

[is because none of the resolvers will](https://youtu.be/upMpPtQuc0c?t=01h37m08s)

[match on stream so anything questions to](https://youtu.be/upMpPtQuc0c?t=01h37m10s)

[ask yeah anytime you have a type that a](https://youtu.be/upMpPtQuc0c?t=01h37m12s)

[resolver won't match you have to do a](https://youtu.be/upMpPtQuc0c?t=01h37m15s)

[use or a with in order to make it match](https://youtu.be/upMpPtQuc0c?t=01h37m17s)

[okay uh](https://youtu.be/upMpPtQuc0c?t=01h37m20s)

[so going to make this name and then](https://youtu.be/upMpPtQuc0c?t=01h37m22s)

[we're going to run this test which it](https://youtu.be/upMpPtQuc0c?t=01h37m26s)

[should fail](https://youtu.be/upMpPtQuc0c?t=01h37m28s)

[now okay it did look at the](https://youtu.be/upMpPtQuc0c?t=01h37m33s)

[diff okay so what did it do that I got](https://youtu.be/upMpPtQuc0c?t=01h37m38s)

[wrong it's probably somewhat of a naming](https://youtu.be/upMpPtQuc0c?t=01h37m41s)

[thing](https://youtu.be/upMpPtQuc0c?t=01h37m44s)

[Constructors just](https://youtu.be/upMpPtQuc0c?t=01h37m47s)

[string](https://youtu.be/upMpPtQuc0c?t=01h37m50s)

[okay so I I left the word controller in](https://youtu.be/upMpPtQuc0c?t=01h37m52s)

[there and I and I shouldn't have so this](https://youtu.be/upMpPtQuc0c?t=01h37m54s)

[should](https://youtu.be/upMpPtQuc0c?t=01h37m57s)

[be like this this should be like this](https://youtu.be/upMpPtQuc0c?t=01h37m58s)

[show me here why does that did the](https://youtu.be/upMpPtQuc0c?t=01h38m02s)

[previous one have](https://youtu.be/upMpPtQuc0c?t=01h38m05s)

[controller um the previous one wasn't](https://youtu.be/upMpPtQuc0c?t=01h38m07s)

[generating a test so I copied this from](https://youtu.be/upMpPtQuc0c?t=01h38m09s)

[a earlier one got it so there's that and](https://youtu.be/upMpPtQuc0c?t=01h38m12s)

[then uh let's see controller Constructor](https://youtu.be/upMpPtQuc0c?t=01h38m17s)

[with null string so I have controller](https://youtu.be/upMpPtQuc0c?t=01h38m21s)

[there to go and](https://youtu.be/upMpPtQuc0c?t=01h38m25s)

[delete and controller there to go and](https://youtu.be/upMpPtQuc0c?t=01h38m26s)

[delete okay so here I have controller](https://youtu.be/upMpPtQuc0c?t=01h38m29s)

[here that shouldn't be here and](https://youtu.be/upMpPtQuc0c?t=01h38m34s)

[controller here that shouldn't be here I](https://youtu.be/upMpPtQuc0c?t=01h38m37s)

[guess it should have made sense I just](https://youtu.be/upMpPtQuc0c?t=01h38m39s)

[chased](https://youtu.be/upMpPtQuc0c?t=01h38m40s)

[the](https://youtu.be/upMpPtQuc0c?t=01h38m45s)

[okay okay so](https://youtu.be/upMpPtQuc0c?t=01h38m49s)

[uh controller controller string must](https://youtu.be/upMpPtQuc0c?t=01h38m54s)

[declare a body because it is not marked](https://youtu.be/upMpPtQuc0c?t=01h38m55s)

[as abstract](https://youtu.be/upMpPtQuc0c?t=01h38m57s)

[ex](https://youtu.be/upMpPtQuc0c?t=01h38m58s)

[or](https://youtu.be/upMpPtQuc0c?t=01h39m01s)

[I are you missing a PR somewhere it](https://youtu.be/upMpPtQuc0c?t=01h39m03s)

[looks like](https://youtu.be/upMpPtQuc0c?t=01h39m06s)

[maybe](https://youtu.be/upMpPtQuc0c?t=01h39m08s)

[no oh have you do you need to um put a](https://youtu.be/upMpPtQuc0c?t=01h39m10s)

[slash in front of your](https://youtu.be/upMpPtQuc0c?t=01h39m15s)

[quotes Escape](https://youtu.be/upMpPtQuc0c?t=01h39m16s)

[them oh that is a good point let me look](https://youtu.be/upMpPtQuc0c?t=01h39m19s)

[quite](https://youtu.be/upMpPtQuc0c?t=01h39m25s)

[possibly](https://youtu.be/upMpPtQuc0c?t=01h39m27s)

[uh they oh it's because they're it's](https://youtu.be/upMpPtQuc0c?t=01h39m29s)

[treating as a single quote you know what](https://youtu.be/upMpPtQuc0c?t=01h39m33s)

[while we're](https://youtu.be/upMpPtQuc0c?t=01h39m36s)

[here let's just do](https://youtu.be/upMpPtQuc0c?t=01h39m37s)

[this right and](https://youtu.be/upMpPtQuc0c?t=01h39m40s)

[we'll okay so that goes like that and](https://youtu.be/upMpPtQuc0c?t=01h39m44s)

[then the thing I hate about these is](https://youtu.be/upMpPtQuc0c?t=01h39m47s)

[getting them get getting raw string](https://youtu.be/upMpPtQuc0c?t=01h39m49s)

[literals to be up right the first time](https://youtu.be/upMpPtQuc0c?t=01h39m51s)

[is sometimes a pain in the](https://youtu.be/upMpPtQuc0c?t=01h39m53s)

[neck yeah and I don't know why it's so](https://youtu.be/upMpPtQuc0c?t=01h39m56s)

[hard but it it really discourages me](https://youtu.be/upMpPtQuc0c?t=01h39m59s)

[from using them oh this](https://youtu.be/upMpPtQuc0c?t=01h40m02s)

[is oh cuz you guys are still on down at](https://youtu.be/upMpPtQuc0c?t=01h40m06s)

[six yeah that's why I didn't do this](https://youtu.be/upMpPtQuc0c?t=01h40m08s)

[before okay fine undo undo](https://youtu.be/upMpPtQuc0c?t=01h40m11s)

[undo is that a hard is that a difficult](https://youtu.be/upMpPtQuc0c?t=01h40m14s)

[upgrade so it is not a difficult upgrade](https://youtu.be/upMpPtQuc0c?t=01h40m17s)

[ever there the test projects could be](https://youtu.be/upMpPtQuc0c?t=01h40m20s)

[upgraded I'll say this the the generator](https://youtu.be/upMpPtQuc0c?t=01h40m23s)

[has to stay on net standard 20 otherwise](https://youtu.be/upMpPtQuc0c?t=01h40m27s)

[Ms build can't load you so that's](https://youtu.be/upMpPtQuc0c?t=01h40m30s)

[important all](https://youtu.be/upMpPtQuc0c?t=01h40m33s)

[generators yeah and analyzers I think I](https://youtu.be/upMpPtQuc0c?t=01h40m35s)

[think if you're willing to to require](https://youtu.be/upMpPtQuc0c?t=01h40m39s)

[VSS 2022 you can be net standard 21 I](https://youtu.be/upMpPtQuc0c?t=01h40m41s)

[don't remember basically Ms build sets a](https://youtu.be/upMpPtQuc0c?t=01h40m45s)

[minimum Target framework that you have](https://youtu.be/upMpPtQuc0c?t=01h40m47s)

[to adhere to in order for it to load](https://youtu.be/upMpPtQuc0c?t=01h40m49s)

[because if you target that's really](https://youtu.be/upMpPtQuc0c?t=01h40m52s)

[interesting I thought it was just like I](https://youtu.be/upMpPtQuc0c?t=01h40m53s)

[thought it was just how compatible you](https://youtu.be/upMpPtQuc0c?t=01h40m54s)

[want it to be I didn't realize it was](https://youtu.be/upMpPtQuc0c?t=01h40m55s)

[well it is kind of how compatible but](https://youtu.be/upMpPtQuc0c?t=01h40m57s)

[how compatible with which version of Ms](https://youtu.be/upMpPtQuc0c?t=01h40m59s)

[build because it has to load your dll up](https://youtu.be/upMpPtQuc0c?t=01h41m01s)

[so it provides the restrictions on what](https://youtu.be/upMpPtQuc0c?t=01h41m04s)

[you're allowed to do um just do that](https://youtu.be/upMpPtQuc0c?t=01h41m07s)

[that'll probably fix that compile](https://youtu.be/upMpPtQuc0c?t=01h41m10s)

[issue so the but the test project could](https://youtu.be/upMpPtQuc0c?t=01h41m14s)

[be moved to net8 that that isn't a](https://youtu.be/upMpPtQuc0c?t=01h41m18s)

[problem okay so I'd almost say their](https://youtu.be/upMpPtQuc0c?t=01h41m21s)

[escape might be clear than for quotes oh](https://youtu.be/upMpPtQuc0c?t=01h41m24s)

[going like](https://youtu.be/upMpPtQuc0c?t=01h41m28s)

[this](https://youtu.be/upMpPtQuc0c?t=01h41m30s)

[yeah um but that's](https://youtu.be/upMpPtQuc0c?t=01h41m32s)

[not you know escaping a it's a literal](https://youtu.be/upMpPtQuc0c?t=01h41m35s)

[yeah that's the](https://youtu.be/upMpPtQuc0c?t=01h41m39s)

[problem you are correct I didn't look up](https://youtu.be/upMpPtQuc0c?t=01h41m40s)

[you are correct it's kind of ugly but at](https://youtu.be/upMpPtQuc0c?t=01h41m43s)

[least in this case it's at least just](https://youtu.be/upMpPtQuc0c?t=01h41m45s)

[trying to prove that the test gets](https://youtu.be/upMpPtQuc0c?t=01h41m47s)

[generated okay I think the next case we](https://youtu.be/upMpPtQuc0c?t=01h41m49s)

[wanted to cover was nullable types being](https://youtu.be/upMpPtQuc0c?t=01h41m51s)

[in see this is not bad once you get the](https://youtu.be/upMpPtQuc0c?t=01h41m54s)

[first one we run our test now Kevin it's](https://youtu.be/upMpPtQuc0c?t=01h41m56s)

[green I just ran it oh I didn't even see](https://youtu.be/upMpPtQuc0c?t=01h41m57s)

[that you were too fast see boom test](https://youtu.be/upMpPtQuc0c?t=01h42m00s)

[pass you are ahead of me I was so](https://youtu.be/upMpPtQuc0c?t=01h42m03s)

[focused on Counting quotes boom see that](https://youtu.be/upMpPtQuc0c?t=01h42m06s)

[test now works okay so we wanted to](https://youtu.be/upMpPtQuc0c?t=01h42m09s)

[handle](https://youtu.be/upMpPtQuc0c?t=01h42m12s)

[nullable nullable types as well right so](https://youtu.be/upMpPtQuc0c?t=01h42m13s)

[the next test we want is actually going](https://youtu.be/upMpPtQuc0c?t=01h42m17s)

[to be closer to](https://youtu.be/upMpPtQuc0c?t=01h42m18s)

[this one](https://youtu.be/upMpPtQuc0c?t=01h42m21s)

[right um yes we want to do we want to do](https://youtu.be/upMpPtQuc0c?t=01h42m23s)

[if if it's a nullable string so uh](https://youtu.be/upMpPtQuc0c?t=01h42m26s)

[parameter uh with you get default value](https://youtu.be/upMpPtQuc0c?t=01h42m32s)

[nullable string you could you kind it's](https://youtu.be/upMpPtQuc0c?t=01h42m36s)

[kind of maybe unnecessary](https://youtu.be/upMpPtQuc0c?t=01h42m38s)

[but well because we want this right and](https://youtu.be/upMpPtQuc0c?t=01h42m43s)

[we don't want this to gen a](https://youtu.be/upMpPtQuc0c?t=01h42m46s)

[test right that's so let's I agree](https://youtu.be/upMpPtQuc0c?t=01h42m48s)

[let's do this I think this is actually a](https://youtu.be/upMpPtQuc0c?t=01h42m51s)

[compile air on this one now let me look](https://youtu.be/upMpPtQuc0c?t=01h42m54s)

[because I think it's going to be unhappy](https://youtu.be/upMpPtQuc0c?t=01h42m57s)

[about](https://youtu.be/upMpPtQuc0c?t=01h42m59s)

[the no it's just unhappy about the](https://youtu.be/upMpPtQuc0c?t=01h43m00s)

[diff what about the oh wait I want to](https://youtu.be/upMpPtQuc0c?t=01h43m04s)

[make sure say what is it going to](https://youtu.be/upMpPtQuc0c?t=01h43m07s)

[generate for without the type in the](https://youtu.be/upMpPtQuc0c?t=01h43m08s)

[name so if you have a string and a](https://youtu.be/upMpPtQuc0c?t=01h43m10s)

[string question](https://youtu.be/upMpPtQuc0c?t=01h43m12s)

[mark I want to be real explicit about it](https://youtu.be/upMpPtQuc0c?t=01h43m16s)

[sorry say that again if you have a](https://youtu.be/upMpPtQuc0c?t=01h43m19s)

[string and a string question](https://youtu.be/upMpPtQuc0c?t=01h43m20s)

[mark is it going to change the name](https://youtu.be/upMpPtQuc0c?t=01h43m22s)

[since are could you come up with would](https://youtu.be/upMpPtQuc0c?t=01h43m24s)

[you end up with potentially duplicate](https://youtu.be/upMpPtQuc0c?t=01h43m26s)

[generated method names for your](https://youtu.be/upMpPtQuc0c?t=01h43m29s)

[tests oh um I don't know about](https://youtu.be/upMpPtQuc0c?t=01h43m33s)

[duplicates because it's smart enough to](https://youtu.be/upMpPtQuc0c?t=01h43m36s)

[handle that but whether it puts a](https://youtu.be/upMpPtQuc0c?t=01h43m38s)

[question mark in the in the test name is](https://youtu.be/upMpPtQuc0c?t=01h43m40s)

[a good question answer it does](https://youtu.be/upMpPtQuc0c?t=01h43m42s)

[not so even if you have multiple](https://youtu.be/upMpPtQuc0c?t=01h43m46s)

[parameters that are all strings it won't](https://youtu.be/upMpPtQuc0c?t=01h43m48s)

[well generate we haven't done the](https://youtu.be/upMpPtQuc0c?t=01h43m52s)

[multiple we haven't done that test yet](https://youtu.be/upMpPtQuc0c?t=01h43m53s)

[with those I I know the generator does](https://youtu.be/upMpPtQuc0c?t=01h43m55s)

[fail already if you have a class that](https://youtu.be/upMpPtQuc0c?t=01h43m59s)

[takes like two parameters of the same](https://youtu.be/upMpPtQuc0c?t=01h44m02s)

[type it falls apart and I don't know how](https://youtu.be/upMpPtQuc0c?t=01h44m04s)

[we handle that yet because Auto mocker](https://youtu.be/upMpPtQuc0c?t=01h44m07s)

[is what's expected to populate those](https://youtu.be/upMpPtQuc0c?t=01h44m10s)

[parameters I guess as long as you don't](https://youtu.be/upMpPtQuc0c?t=01h44m12s)

[expect them to ever be different you're](https://youtu.be/upMpPtQuc0c?t=01h44m14s)

[okay what if you had the param](https://youtu.be/upMpPtQuc0c?t=01h44m18s)

[name as well as the](https://youtu.be/upMpPtQuc0c?t=01h44m21s)

[type oh because the you're thinking of](https://youtu.be/upMpPtQuc0c?t=01h44m26s)

[the duplicate test](https://youtu.be/upMpPtQuc0c?t=01h44m29s)

[problem that would help](https://youtu.be/upMpPtQuc0c?t=01h44m31s)

[disambiguate that would help](https://youtu.be/upMpPtQuc0c?t=01h44m35s)

[disambiguate I think automaker knows](https://youtu.be/upMpPtQuc0c?t=01h44m37s)

[about the par can figure out the](https://youtu.be/upMpPtQuc0c?t=01h44m40s)

[parameter name as well as the parameter](https://youtu.be/upMpPtQuc0c?t=01h44m43s)

[type](https://youtu.be/upMpPtQuc0c?t=01h44m49s)

[those the type um I don't know if it](https://youtu.be/upMpPtQuc0c?t=01h44m51s)

[does uh that's the wrong thing wrong](https://youtu.be/upMpPtQuc0c?t=01h44m58s)

[window um I don't because the the](https://youtu.be/upMpPtQuc0c?t=01h45m01s)

[resolver I](https://youtu.be/upMpPtQuc0c?t=01h45m05s)

[don't Auto marer doesn't get the](https://youtu.be/upMpPtQuc0c?t=01h45m08s)

[parameter](https://youtu.be/upMpPtQuc0c?t=01h45m10s)

[name it when it's asked for a type](https://youtu.be/upMpPtQuc0c?t=01h45m11s)

[because quite often what you're calling](https://youtu.be/upMpPtQuc0c?t=01h45m14s)

[is automaker doget and get often times](https://youtu.be/upMpPtQuc0c?t=01h45m16s)

[will just](https://youtu.be/upMpPtQuc0c?t=01h45m20s)

[have um the type passed in so for](https://youtu.be/upMpPtQuc0c?t=01h45m22s)

[example the caller could just do](https://youtu.be/upMpPtQuc0c?t=01h45m24s)

[this and all you're going to get is the](https://youtu.be/upMpPtQuc0c?t=01h45m27s)

[type now the we](https://youtu.be/upMpPtQuc0c?t=01h45m29s)

[could there's because we're generating](https://youtu.be/upMpPtQuc0c?t=01h45m33s)

[these tests there's nothing stopping us](https://youtu.be/upMpPtQuc0c?t=01h45m35s)

[from adding](https://youtu.be/upMpPtQuc0c?t=01h45m39s)

[stuff](https://youtu.be/upMpPtQuc0c?t=01h45m41s)

[heid or or similar yeah like like we](https://youtu.be/upMpPtQuc0c?t=01h45m44s)

[could do we could do things like that um](https://youtu.be/upMpPtQuc0c?t=01h45m47s)

[but let's let's handle this case next](https://youtu.be/upMpPtQuc0c?t=01h45m51s)

[because this is now we'll hit it when we](https://youtu.be/upMpPtQuc0c?t=01h45m54s)

[hit it yeah okay so let let's let's deal](https://youtu.be/upMpPtQuc0c?t=01h45m56s)

[with this one because this one's](https://youtu.be/upMpPtQuc0c?t=01h45m59s)

[generating a test so what we want to do](https://youtu.be/upMpPtQuc0c?t=01h46m00s)

[is we want to know about and I think we](https://youtu.be/upMpPtQuc0c?t=01h46m02s)

[can just catch it in the in the](https://youtu.be/upMpPtQuc0c?t=01h46m04s)

[parameter class can't we right and the](https://youtu.be/upMpPtQuc0c?t=01h46m07s)

[diff is the diff is fine now it's just](https://youtu.be/upMpPtQuc0c?t=01h46m10s)

[the compiler no the diff is well the](https://youtu.be/upMpPtQuc0c?t=01h46m12s)

[diff is generating a test got it and we](https://youtu.be/upMpPtQuc0c?t=01h46m15s)

[don't want and it shouldn't be Genera](https://youtu.be/upMpPtQuc0c?t=01h46m17s)

[test got correct yeah so and I think we](https://youtu.be/upMpPtQuc0c?t=01h46m18s)

[can grab that where we grab the](https://youtu.be/upMpPtQuc0c?t=01h46m21s)

[parameter right so I I think inside of](https://youtu.be/upMpPtQuc0c?t=01h46m24s)

[here we can just grab it right there and](https://youtu.be/upMpPtQuc0c?t=01h46m28s)

[we can debug our way to Victory and](https://youtu.be/upMpPtQuc0c?t=01h46m31s)

[win my chat there we go okay okay so now](https://youtu.be/upMpPtQuc0c?t=01h46m37s)

[the question is so this guy clearly](https://youtu.be/upMpPtQuc0c?t=01h46m41s)

[knows the type](https://youtu.be/upMpPtQuc0c?t=01h46m44s)

[is string question nullable annotation](https://youtu.be/upMpPtQuc0c?t=01h46m46s)

[right there](https://youtu.be/upMpPtQuc0c?t=01h46m49s)

[okay](https://youtu.be/upMpPtQuc0c?t=01h46m52s)

[so if n so that will tell us if](https://youtu.be/upMpPtQuc0c?t=01h46m53s)

[nullability is enabled but how do we](https://youtu.be/upMpPtQuc0c?t=01h46m56s)

[tell if the type is](https://youtu.be/upMpPtQuc0c?t=01h46m59s)

[knowable is that on the thing uh well so](https://youtu.be/upMpPtQuc0c?t=01h47m02s)

[um you're thinking that](https://youtu.be/upMpPtQuc0c?t=01h47m08s)

[Oneil is enabled I was thinking that's](https://youtu.be/upMpPtQuc0c?t=01h47m10s)

[actually like there's a question mark on](https://youtu.be/upMpPtQuc0c?t=01h47m13s)

[it oh that's a good point so that](https://youtu.be/upMpPtQuc0c?t=01h47m14s)

[uh or](https://youtu.be/upMpPtQuc0c?t=01h47m18s)

[uh](https://youtu.be/upMpPtQuc0c?t=01h47m21s)

[symbol noal annotation](https://youtu.be/upMpPtQuc0c?t=01h47m23s)

[is](https://youtu.be/upMpPtQuc0c?t=01h47m27s)

[uh annotated intentionally using is](https://youtu.be/upMpPtQuc0c?t=01h47m28s)

[pattern matching because](https://youtu.be/upMpPtQuc0c?t=01h47m32s)

[I not be shocked if we needed to do an](https://youtu.be/upMpPtQuc0c?t=01h47m34s)

[or at some point but I think there's](https://youtu.be/upMpPtQuc0c?t=01h47m36s)

[only the three cases](https://youtu.be/upMpPtQuc0c?t=01h47m38s)

[yeah known true known false](https://youtu.be/upMpPtQuc0c?t=01h47m41s)

[unknown and we want to generate oh wait](https://youtu.be/upMpPtQuc0c?t=01h47m46s)

[what are the cases for none it comes](https://youtu.be/upMpPtQuc0c?t=01h47m49s)

[from it's](https://youtu.be/upMpPtQuc0c?t=01h47m52s)

[disabled or it comes from C 7.3 or](https://youtu.be/upMpPtQuc0c?t=01h47m53s)

[earlier interesting well right these two](https://youtu.be/upMpPtQuc0c?t=01h47m57s)

[are if Noble reference types are enabled](https://youtu.be/upMpPtQuc0c?t=01h47m59s)

[is it string question mark or just non-](https://youtu.be/upMpPtQuc0c?t=01h48m01s)

[knowable string right but if Noble](https://youtu.be/upMpPtQuc0c?t=01h48m04s)

[annotations are off or it's an older](https://youtu.be/upMpPtQuc0c?t=01h48m06s)

[framework or any of the cases that it](https://youtu.be/upMpPtQuc0c?t=01h48m08s)

[breaks on this is they call it none but](https://youtu.be/upMpPtQuc0c?t=01h48m10s)

[I usually call it unknown is we just](https://youtu.be/upMpPtQuc0c?t=01h48m13s)

[have no idea whether this thing's](https://youtu.be/upMpPtQuc0c?t=01h48m16s)

[nullable or not you should probably](https://youtu.be/upMpPtQuc0c?t=01h48m18s)

[panic could freak out and](https://youtu.be/upMpPtQuc0c?t=01h48m19s)

[worry](https://youtu.be/upMpPtQuc0c?t=01h48m24s)

[and let's see uh let's see expected test](https://youtu.be/upMpPtQuc0c?t=01h48m27s)

[State](https://youtu.be/upMpPtQuc0c?t=01h48m33s)

[sources](https://youtu.be/upMpPtQuc0c?t=01h48m38s)

[huh wow why do we expect two I don't](https://youtu.be/upMpPtQuc0c?t=01h48m40s)

[know I'm going to turn that off I wonder](https://youtu.be/upMpPtQuc0c?t=01h48m44s)

[if I broke something when I turned that](https://youtu.be/upMpPtQuc0c?t=01h48m46s)

[on](https://youtu.be/upMpPtQuc0c?t=01h48m49s)

[yeah why would expect two I literally](https://youtu.be/upMpPtQuc0c?t=01h48m53s)

[added one thing to the](https://youtu.be/upMpPtQuc0c?t=01h48m56s)

[collection expected](https://youtu.be/upMpPtQuc0c?t=01h49m00s)

[two Source generator](https://youtu.be/upMpPtQuc0c?t=01h49m03s)

[application expected test State](https://youtu.be/upMpPtQuc0c?t=01h49m10s)

[sources what I'm very very](https://youtu.be/upMpPtQuc0c?t=01h49m14s)

[confused test state](https://youtu.be/upMpPtQuc0c?t=01h49m18s)

[did I accidentally delete](https://youtu.be/upMpPtQuc0c?t=01h49m23s)

[something](https://youtu.be/upMpPtQuc0c?t=01h49m28s)

[no because this guy here is so this is a](https://youtu.be/upMpPtQuc0c?t=01h49m30s)

[dumb property just to be clear it makes](https://youtu.be/upMpPtQuc0c?t=01h49m35s)

[writing the test look friendly but it's](https://youtu.be/upMpPtQuc0c?t=01h49m38s)

[a dumb](https://youtu.be/upMpPtQuc0c?t=01h49m41s)

[property right like two sets add two](https://youtu.be/upMpPtQuc0c?t=01h49m42s)

[it's like the Setters being called](https://youtu.be/upMpPtQuc0c?t=01h49m46s)

[multiple times right cuz it's](https://youtu.be/upMpPtQuc0c?t=01h49m48s)

[saying to match update document but test](https://youtu.be/upMpPtQuc0c?t=01h49m51s)

[State sources with test State generated](https://youtu.be/upMpPtQuc0c?t=01h49m55s)

[sources contains two](https://youtu.be/upMpPtQuc0c?t=01h49m58s)

[documents what are documents is that the](https://youtu.be/upMpPtQuc0c?t=01h50m00s)

[things that you're passing into that](https://youtu.be/upMpPtQuc0c?t=01h50m03s)

[state function correct document is the](https://youtu.be/upMpPtQuc0c?t=01h50m04s)

[the way that Roslin thinks of like your](https://youtu.be/upMpPtQuc0c?t=01h50m08s)

[C file like when you compile a normal](https://youtu.be/upMpPtQuc0c?t=01h50m11s)

[project each file becomes its own](https://youtu.be/upMpPtQuc0c?t=01h50m15s)

[document so file not class so if you](https://youtu.be/upMpPtQuc0c?t=01h50m18s)

[have multiple classes in a single file](https://youtu.be/upMpPtQuc0c?t=01h50m20s)

[it still be a document correct correct](https://youtu.be/upMpPtQuc0c?t=01h50m21s)

[I'm going to restart Visual Studio](https://youtu.be/upMpPtQuc0c?t=01h50m24s)

[because I have a thinking suspicion that](https://youtu.be/upMpPtQuc0c?t=01h50m26s)

[something has cashed something and it](https://youtu.be/upMpPtQuc0c?t=01h50m30s)

[hates me so we're just going to](https://youtu.be/upMpPtQuc0c?t=01h50m32s)

[not not do that that was a weird error](https://youtu.be/upMpPtQuc0c?t=01h50m34s)

[though for a caching error it seems like](https://youtu.be/upMpPtQuc0c?t=01h50m37s)

[it is but I've just learned that I don't](https://youtu.be/upMpPtQuc0c?t=01h50m40s)

[trust anything with Source analyzers to](https://youtu.be/upMpPtQuc0c?t=01h50m41s)

[not be](https://youtu.be/upMpPtQuc0c?t=01h50m43s)

[cashed fair enough as the old saying go](https://youtu.be/upMpPtQuc0c?t=01h50m44s)

[cash French failure Point here or French](https://youtu.be/upMpPtQuc0c?t=01h50m47s)

[word for failure Point](https://youtu.be/upMpPtQuc0c?t=01h50m50s)

[here I hadn't heard of that before but](https://youtu.be/upMpPtQuc0c?t=01h50m52s)

[that's good it's I heard it somewhere at](https://youtu.be/upMpPtQuc0c?t=01h50m55s)

[one point and I I laughed so I've kept](https://youtu.be/upMpPtQuc0c?t=01h50m58s)

[it uh it's also like the the word](https://youtu.be/upMpPtQuc0c?t=01h51m04s)

[because my my father used to work for](https://youtu.be/upMpPtQuc0c?t=01h51m07s)

[the postal service and he he always](https://youtu.be/upMpPtQuc0c?t=01h51m09s)

[informed us that the word fragil means](https://youtu.be/upMpPtQuc0c?t=01h51m11s)

[bounce off of](https://youtu.be/upMpPtQuc0c?t=01h51m13s)

[wall for anybody in America who has](https://youtu.be/upMpPtQuc0c?t=01h51m15s)

[dealt with Postal Service that is funny](https://youtu.be/upMpPtQuc0c?t=01h51m18s)

[for everyone else just assume it means](https://youtu.be/upMpPtQuc0c?t=01h51m20s)

[that sometimes packages arrive very beat](https://youtu.be/upMpPtQuc0c?t=01h51m21s)

[up how often do you use that in your](https://youtu.be/upMpPtQuc0c?t=01h51m25s)

[DayDay language for Jil um only when](https://youtu.be/upMpPtQuc0c?t=01h51m27s)

[describing other people's](https://youtu.be/upMpPtQuc0c?t=01h51m32s)

[code hopefully my code isn't](https://youtu.be/upMpPtQuc0c?t=01h51m36s)

[fragile okay so something about this](https://youtu.be/upMpPtQuc0c?t=01h51m42s)

[input has gone Ary blue and I'm I'm](https://youtu.be/upMpPtQuc0c?t=01h51m45s)

[curious](https://youtu.be/upMpPtQuc0c?t=01h51m52s)

[why](https://youtu.be/upMpPtQuc0c?t=01h51m55s)

[how](https://youtu.be/upMpPtQuc0c?t=01h51m57s)

[huh](https://youtu.be/upMpPtQuc0c?t=01h52m04s)

[um we're just going to do](https://youtu.be/upMpPtQuc0c?t=01h52m09s)

[this](https://youtu.be/upMpPtQuc0c?t=01h52m11s)

[uh I don't know if you're watching why](https://youtu.be/upMpPtQuc0c?t=01h52m15s)

[you sign](https://youtu.be/upMpPtQuc0c?t=01h52m17s)

[back uh](https://youtu.be/upMpPtQuc0c?t=01h52m18s)

[sorry what oh did you just do that yeah](https://youtu.be/upMpPtQuc0c?t=01h52m20s)

[I just want to I just want to inspect](https://youtu.be/upMpPtQuc0c?t=01h52m23s)

[this thing I like the uh the comment in](https://youtu.be/upMpPtQuc0c?t=01h52m25s)

[chat when it sticks to the wall that is](https://youtu.be/upMpPtQuc0c?t=01h52m28s)

[the sign that it is](https://youtu.be/upMpPtQuc0c?t=01h52m29s)

[ready not wrong not wrong a new a new](https://youtu.be/upMpPtQuc0c?t=01h52m34s)

[Vis series feature I am liking is that](https://youtu.be/upMpPtQuc0c?t=01h52m37s)

[when you get to the end of a method you](https://youtu.be/upMpPtQuc0c?t=01h52m40s)

[can actually see the return in your](https://youtu.be/upMpPtQuc0c?t=01h52m41s)

[Autos yes yes that came](https://youtu.be/upMpPtQuc0c?t=01h52m43s)

[out well wasn't too long ago well the](https://youtu.be/upMpPtQuc0c?t=01h52m47s)

[the previews had it for I think close to](https://youtu.be/upMpPtQuc0c?t=01h52m49s)

[like nine months](https://youtu.be/upMpPtQuc0c?t=01h52m51s)

[yeah the only thing common I have about](https://youtu.be/upMpPtQuc0c?t=01h52m54s)

[it is it's sometime hard to find because](https://youtu.be/upMpPtQuc0c?t=01h52m57s)

[it they have some magical name that ends](https://youtu.be/upMpPtQuc0c?t=01h52m59s)

[with like](https://youtu.be/upMpPtQuc0c?t=01h53m00s)

[returns that it](https://youtu.be/upMpPtQuc0c?t=01h53m02s)

[is wait am](https://youtu.be/upMpPtQuc0c?t=01h53m05s)

[huh I'm not I wait what I'm I](https://youtu.be/upMpPtQuc0c?t=01h53m12s)

[huh I'm confused](https://youtu.be/upMpPtQuc0c?t=01h53m17s)

[seeing a lot of zeros yeah that's that's](https://youtu.be/upMpPtQuc0c?t=01h53m21s)

[what I'm confused](https://youtu.be/upMpPtQuc0c?t=01h53m23s)

[about okay there's the generated](https://youtu.be/upMpPtQuc0c?t=01h53m25s)

[sources right this](https://youtu.be/upMpPtQuc0c?t=01h53m28s)

[is oh item one item](https://youtu.be/upMpPtQuc0c?t=01h53m35s)

[two hang on why do we](https://youtu.be/upMpPtQuc0c?t=01h53m38s)

[have oh this is a](https://youtu.be/upMpPtQuc0c?t=01h53m43s)

[tuple there's still only one item in](https://youtu.be/upMpPtQuc0c?t=01h53m48s)

[there right okay so that that I'm okay](https://youtu.be/upMpPtQuc0c?t=01h53m51s)

[with generated sources](https://youtu.be/upMpPtQuc0c?t=01h53m57s)

[has the file name and the source text so](https://youtu.be/upMpPtQuc0c?t=01h54m01s)

[this this method returns a tuple](https://youtu.be/upMpPtQuc0c?t=01h54m06s)

[generated](https://youtu.be/upMpPtQuc0c?t=01h54m07s)

[sources uh source file](https://youtu.be/upMpPtQuc0c?t=01h54m10s)

[collection is a collection of value](https://youtu.be/upMpPtQuc0c?t=01h54m13s)

[tuples again I will not claim this API](https://youtu.be/upMpPtQuc0c?t=01h54m16s)

[is great because yuck right but file](https://youtu.be/upMpPtQuc0c?t=01h54m18s)

[name content okay great like that okay](https://youtu.be/upMpPtQuc0c?t=01h54m21s)

[so that makes](https://youtu.be/upMpPtQuc0c?t=01h54m25s)

[sense I love that they used a list in](https://youtu.be/upMpPtQuc0c?t=01h54m27s)

[this case a list of tup PS and and here](https://youtu.be/upMpPtQuc0c?t=01h54m31s)

[is the](https://youtu.be/upMpPtQuc0c?t=01h54m34s)

[source right same](https://youtu.be/upMpPtQuc0c?t=01h54m35s)

[thing I mean normally I'd be looking at](https://youtu.be/upMpPtQuc0c?t=01h54m42s)

[these these things here and freaking out](https://youtu.be/upMpPtQuc0c?t=01h54m45s)

[about them but I'm not that](https://youtu.be/upMpPtQuc0c?t=01h54m48s)

[generated yeah I mean the back slash](https://youtu.be/upMpPtQuc0c?t=01h54m52s)

[zero gives me a bit of](https://youtu.be/upMpPtQuc0c?t=01h54m56s)

[pause but I think that's more around](https://youtu.be/upMpPtQuc0c?t=01h54m58s)

[like an index that gets slapped on it to](https://youtu.be/upMpPtQuc0c?t=01h55m01s)

[to](https://youtu.be/upMpPtQuc0c?t=01h55m03s)

[disambiguate so and the code itself](https://youtu.be/upMpPtQuc0c?t=01h55m06s)

[seems as expected](https://youtu.be/upMpPtQuc0c?t=01h55m10s)

[so okay so when I step over](https://youtu.be/upMpPtQuc0c?t=01h55m13s)

[you](https://youtu.be/upMpPtQuc0c?t=01h55m18s)

[operation not oh operation not valid due](https://youtu.be/upMpPtQuc0c?t=01h55m21s)

[to the current state so it's crashing](https://youtu.be/upMpPtQuc0c?t=01h55m25s)

[and giving me a really bad air](https://youtu.be/upMpPtQuc0c?t=01h55m28s)

[okay okay](https://youtu.be/upMpPtQuc0c?t=01h55m31s)

[so well what's our air here uh you can't](https://youtu.be/upMpPtQuc0c?t=01h55m33s)

[access explicit default value property](https://youtu.be/upMpPtQuc0c?t=01h55m37s)

[if it doesn't have one so else](https://youtu.be/upMpPtQuc0c?t=01h55m41s)

[if right so which](https://youtu.be/upMpPtQuc0c?t=01h55m48s)

[is thank you co-pilot see now you're](https://youtu.be/upMpPtQuc0c?t=01h55m52s)

[being](https://youtu.be/upMpPtQuc0c?t=01h55m54s)

[useful there see something like that I](https://youtu.be/upMpPtQuc0c?t=01h55m56s)

[think that okay okay that that makes a](https://youtu.be/upMpPtQuc0c?t=01h55m59s)

[lot more sense it's very very confused](https://youtu.be/upMpPtQuc0c?t=01h56m03s)

[by that you could probably use](https://youtu.be/upMpPtQuc0c?t=01h56m06s)

[a operator](https://youtu.be/upMpPtQuc0c?t=01h56m09s)

[there uh very](https://youtu.be/upMpPtQuc0c?t=01h56m13s)

[possible mismatch The annotation for no](https://youtu.be/upMpPtQuc0c?t=01h56m15s)

[reference type should only be used when](https://youtu.be/upMpPtQuc0c?t=01h56m18s)

[Noble now I go put now I go put that](https://youtu.be/upMpPtQuc0c?t=01h56m20s)

[sucker](https://youtu.be/upMpPtQuc0c?t=01h56m23s)

[back see found](https://youtu.be/upMpPtQuc0c?t=01h56m26s)

[knowable](https://youtu.be/upMpPtQuc0c?t=01h56m30s)

[enable there we go okay so that now](https://youtu.be/upMpPtQuc0c?t=01h56m39s)

[works properly as we would expect and](https://youtu.be/upMpPtQuc0c?t=01h56m42s)

[we're going to put this back to](https://youtu.be/upMpPtQuc0c?t=01h56m45s)

[be](https://youtu.be/upMpPtQuc0c?t=01h56m48s)

[wait now that okay so Pro tip run run](https://youtu.be/upMpPtQuc0c?t=01h56m50s)

[with the debugger attached and make sure](https://youtu.be/upMpPtQuc0c?t=01h56m53s)

[your analyze or your Source generators](https://youtu.be/upMpPtQuc0c?t=01h56m55s)

[and just](https://youtu.be/upMpPtQuc0c?t=01h56m57s)

[crashing Okay so we've handled that case](https://youtu.be/upMpPtQuc0c?t=01h56m59s)

[what was another case we wanted to](https://youtu.be/upMpPtQuc0c?t=01h57m02s)

[handle I don't know if we need to cover](https://youtu.be/upMpPtQuc0c?t=01h57m05s)

[it but if you have](https://youtu.be/upMpPtQuc0c?t=01h57m07s)

[both I think our logic is good enough](https://youtu.be/upMpPtQuc0c?t=01h57m09s)

[but if you have both a nullable type and](https://youtu.be/upMpPtQuc0c?t=01h57m12s)

[a default valuable variable and I think](https://youtu.be/upMpPtQuc0c?t=01h57m14s)

[the other one nullable value types](https://youtu.be/upMpPtQuc0c?t=01h57m17s)

[maybe okay uh one thing I just realized](https://youtu.be/upMpPtQuc0c?t=01h57m20s)

[I want to add to our to our tests real](https://youtu.be/upMpPtQuc0c?t=01h57m24s)

[quick is I would like to](https://youtu.be/upMpPtQuc0c?t=01h57m26s)

[do I'm going to change this test here](https://youtu.be/upMpPtQuc0c?t=01h57m29s)

[just to make sure it gets](https://youtu.be/upMpPtQuc0c?t=01h57m31s)

[covered I I this shouldn't break based](https://youtu.be/upMpPtQuc0c?t=01h57m33s)

[on what we saw before but I I want to](https://youtu.be/upMpPtQuc0c?t=01h57m35s)

[make sure that if that we have use a](https://youtu.be/upMpPtQuc0c?t=01h57m37s)

[Constructor yeah okay good still passes](https://youtu.be/upMpPtQuc0c?t=01h57m39s)

[I didn't think also we wanted to do one](https://youtu.be/upMpPtQuc0c?t=01h57m43s)

[where we didn't pass in Behavior cuz](https://youtu.be/upMpPtQuc0c?t=01h57m46s)

[didn't we have a case some where where](https://youtu.be/upMpPtQuc0c?t=01h57m48s)

[when we had we didn't set Behavior it](https://youtu.be/upMpPtQuc0c?t=01h57m50s)

[was crafing at some point that might](https://youtu.be/upMpPtQuc0c?t=01h57m52s)

[have been on way back when but if we](https://youtu.be/upMpPtQuc0c?t=01h57m54s)

[don't set](https://youtu.be/upMpPtQuc0c?t=01h57m57s)

[it wasn't in our syntax receiver at one](https://youtu.be/upMpPtQuc0c?t=01h58m00s)

[point when we ran the generator is](https://youtu.be/upMpPtQuc0c?t=01h58m03s)

[crashing or something like that well I](https://youtu.be/upMpPtQuc0c?t=01h58m05s)

[think I think the the tests that were](https://youtu.be/upMpPtQuc0c?t=01h58m07s)

[here before we added this property I](https://youtu.be/upMpPtQuc0c?t=01h58m10s)

[think cover it right because none of](https://youtu.be/upMpPtQuc0c?t=01h58m11s)

[these ones here are going to be](https://youtu.be/upMpPtQuc0c?t=01h58m14s)

[specifying it so I'm sort of implicitly](https://youtu.be/upMpPtQuc0c?t=01h58m16s)

[testing those case the the case of it](https://youtu.be/upMpPtQuc0c?t=01h58m20s)

[not specified with these existing tests](https://youtu.be/upMpPtQuc0c?t=01h58m22s)

[makes](https://youtu.be/upMpPtQuc0c?t=01h58m25s)

[sense so those still continue to work](https://youtu.be/upMpPtQuc0c?t=01h58m27s)

[so um real quick before we get carried](https://youtu.be/upMpPtQuc0c?t=01h58m31s)

[away let's let's real quick give](https://youtu.be/upMpPtQuc0c?t=01h58m34s)

[ourselves some](https://youtu.be/upMpPtQuc0c?t=01h58m36s)

[constants um to play with so that we](https://youtu.be/upMpPtQuc0c?t=01h58m38s)

[don't have to do this this wtin inside](https://youtu.be/upMpPtQuc0c?t=01h58m40s)

[of here](https://youtu.be/upMpPtQuc0c?t=01h58m44s)

[so uh](https://youtu.be/upMpPtQuc0c?t=01h58m46s)

[public con](https://youtu.be/upMpPtQuc0c?t=01h58m50s)

[string uh enum](https://youtu.be/upMpPtQuc0c?t=01h58m52s)

[value](https://youtu.be/upMpPtQuc0c?t=01h58m57s)

[boom right so we want uh I think we have](https://youtu.be/upMpPtQuc0c?t=01h58m59s)

[a used static don't we do we](https://youtu.be/upMpPtQuc0c?t=01h59m02s)

[[Music]](https://youtu.be/upMpPtQuc0c?t=01h59m06s)

[not I'm somewhat tempted to do](https://youtu.be/upMpPtQuc0c?t=01h59m10s)

[this](https://youtu.be/upMpPtQuc0c?t=01h59m18s)

[right because now I can](https://youtu.be/upMpPtQuc0c?t=01h59m21s)

[do](https://youtu.be/upMpPtQuc0c?t=01h59m24s)

[that how does that make you](https://youtu.be/upMpPtQuc0c?t=01h59m26s)

[feel I think I'm fine with it in this](https://youtu.be/upMpPtQuc0c?t=01h59m29s)

[case because we the fact that we're](https://youtu.be/upMpPtQuc0c?t=01h59m31s)

[using constants and it's not actually](https://youtu.be/upMpPtQuc0c?t=01h59m33s)

[referencing a yeah forty using static is](https://youtu.be/upMpPtQuc0c?t=01h59m34s)

[one of those I I use it very pun](https://youtu.be/upMpPtQuc0c?t=01h59m38s)

[intended very](https://youtu.be/upMpPtQuc0c?t=01h59m40s)

[sparingly yeah because my normal](https://youtu.be/upMpPtQuc0c?t=01h59m43s)

[complaint is I don't know what where the](https://youtu.be/upMpPtQuc0c?t=01h59m45s)

[member is like you're whether the member](https://youtu.be/upMpPtQuc0c?t=01h59m49s)

[is local to the class or if it's](https://youtu.be/upMpPtQuc0c?t=01h59m52s)

[somewhere else in this case because it's](https://youtu.be/upMpPtQuc0c?t=01h59m55s)

[a constant I don't really care yeah so](https://youtu.be/upMpPtQuc0c?t=01h59m57s)

[yeah okay so that works here we will run](https://youtu.be/upMpPtQuc0c?t=02h00m03s)

[into a problem with this Logic the](https://youtu.be/upMpPtQuc0c?t=02h00m07s)

[moment somebody adds yet one more like](https://youtu.be/upMpPtQuc0c?t=02h00m08s)

[en parameter like this will no longer](https://youtu.be/upMpPtQuc0c?t=02h00m11s)

[work but to be fair we have the same](https://youtu.be/upMpPtQuc0c?t=02h00m13s)

[issue here the moment somebody else adds](https://youtu.be/upMpPtQuc0c?t=02h00m15s)

[a type parameter this thing falls apart](https://youtu.be/upMpPtQuc0c?t=02h00m17s)

[so uh type parameter so if somebody were](https://youtu.be/upMpPtQuc0c?t=02h00m22s)

[to on our attribute go and put in](https://youtu.be/upMpPtQuc0c?t=02h00m25s)

[another property that accepts a](https://youtu.be/upMpPtQuc0c?t=02h00m27s)

[type um it falls apart oh Izzy what is](https://youtu.be/upMpPtQuc0c?t=02h00m29s)

[using static ah great question this was](https://youtu.be/upMpPtQuc0c?t=02h00m34s)

[added in c n](https://youtu.be/upMpPtQuc0c?t=02h00m38s)

[10 trying to remember o o This Is We I](https://youtu.be/upMpPtQuc0c?t=02h00m40s)

[got this i got this](https://youtu.be/upMpPtQuc0c?t=02h00m44s)

[uh](https://youtu.be/upMpPtQuc0c?t=02h00m48s)

[come on](https://youtu.be/upMpPtQuc0c?t=02h00m51s)

[uh why is it not showing up static](https://youtu.be/upMpPtQuc0c?t=02h00m54s)

[using](https://youtu.be/upMpPtQuc0c?t=02h01m03s)

[using think it C 6 I think it was really](https://youtu.be/upMpPtQuc0c?t=02h01m05s)

[old wasn't it uh it could be seven see](https://youtu.be/upMpPtQuc0c?t=02h01m08s)

[this is why I need our search to be](https://youtu.be/upMpPtQuc0c?t=02h01m11s)

[better so it doesn't so it doesn't stuck](https://youtu.be/upMpPtQuc0c?t=02h01m12s)

[so short version is future stream if](https://youtu.be/upMpPtQuc0c?t=02h01m15s)

[only this code was open source so we](https://youtu.be/upMpPtQuc0c?t=02h01m17s)

[could like I don't know fix it fix it we](https://youtu.be/upMpPtQuc0c?t=02h01m18s)

[can fix it I think C 6 quot me on that](https://youtu.be/upMpPtQuc0c?t=02h01m22s)

[though yeah so the idea with using](https://youtu.be/upMpPtQuc0c?t=02h01m26s)

[static is it um it it's it's not that](https://youtu.be/upMpPtQuc0c?t=02h01m28s)

[complicated it literally lets you uh](https://youtu.be/upMpPtQuc0c?t=02h01m32s)

[invoke static members of the type](https://youtu.be/upMpPtQuc0c?t=02h01m35s)

[without specifying the class name in](https://youtu.be/upMpPtQuc0c?t=02h01m38s)

[front of it because normally I'd have to](https://youtu.be/upMpPtQuc0c?t=02h01m40s)

[type automach Dot and put this in and if](https://youtu.be/upMpPtQuc0c?t=02h01m41s)

[you do it using static it says well](https://youtu.be/upMpPtQuc0c?t=02h01m44s)

[let's just assume that all of the static](https://youtu.be/upMpPtQuc0c?t=02h01m47s)

[members of this type are available to me](https://youtu.be/upMpPtQuc0c?t=02h01m49s)

[directly inside my type now obviously](https://youtu.be/upMpPtQuc0c?t=02h01m52s)

[you can shoot yourself in the foot with](https://youtu.be/upMpPtQuc0c?t=02h01m54s)

[ambiguity if you've got if you try to do](https://youtu.be/upMpPtQuc0c?t=02h01m56s)

[using static with things that have uh](https://youtu.be/upMpPtQuc0c?t=02h01m59s)

[matching member names that's a problem](https://youtu.be/upMpPtQuc0c?t=02h02m02s)

[don't do that but it it's more often the](https://youtu.be/upMpPtQuc0c?t=02h02m04s)

[problem with it is it makes it unobvious](https://youtu.be/upMpPtQuc0c?t=02h02m09s)

[where it's coming from right so another](https://youtu.be/upMpPtQuc0c?t=02h02m11s)

[common one that I I usually don't mind](https://youtu.be/upMpPtQuc0c?t=02h02m14s)

[too much is like system. goo](https://youtu.be/upMpPtQuc0c?t=02h02m16s)

[right so now down here I can literally](https://youtu.be/upMpPtQuc0c?t=02h02m20s)

[go guid g gets new](https://youtu.be/upMpPtQuc0c?t=02h02m22s)

[goid right because I can I can now](https://youtu.be/upMpPtQuc0c?t=02h02m26s)

[access the new guid method off of this](https://youtu.be/upMpPtQuc0c?t=02h02m29s)

[guid class without specifying gu. new](https://youtu.be/upMpPtQuc0c?t=02h02m31s)

[and this conso is the other one](https://youtu.be/upMpPtQuc0c?t=02h02m34s)

[sometimes I like oh yeah so that I I can](https://youtu.be/upMpPtQuc0c?t=02h02m36s)

[see that like there's a handful of these](https://youtu.be/upMpPtQuc0c?t=02h02m39s)

[things that as long as it doesn't kill](https://youtu.be/upMpPtQuc0c?t=02h02m41s)

[your](https://youtu.be/upMpPtQuc0c?t=02h02m44s)

[readability and and based on context](https://youtu.be/upMpPtQuc0c?t=02h02m45s)

[like if you're building a cont conso](https://youtu.be/upMpPtQuc0c?t=02h02m47s)

[application like if you see a right line](https://youtu.be/upMpPtQuc0c?t=02h02m50s)

[method it's it's not that bad to assume](https://youtu.be/upMpPtQuc0c?t=02h02m53s)

[that oh this right line method is going](https://youtu.be/upMpPtQuc0c?t=02h02m57s)

[to system. console not bad so it is it](https://youtu.be/upMpPtQuc0c?t=02h02m59s)

[is definitely a way you can make your](https://youtu.be/upMpPtQuc0c?t=02h03m03s)

[code](https://youtu.be/upMpPtQuc0c?t=02h03m05s)

[unreadable but used well it can also](https://youtu.be/upMpPtQuc0c?t=02h03m06s)

[save a bit of typing and reduce some of](https://youtu.be/upMpPtQuc0c?t=02h03m09s)

[the noise because do people really need](https://youtu.be/upMpPtQuc0c?t=02h03m12s)

[to see console. right line or is Right](https://youtu.be/upMpPtQuc0c?t=02h03m15s)

[line itself good enough okay great if](https://youtu.be/upMpPtQuc0c?t=02h03m17s)

[right line itself is good enough](https://youtu.be/upMpPtQuc0c?t=02h03m21s)

[uh make my code cleaner excellent always](https://youtu.be/upMpPtQuc0c?t=02h03m25s)

[always happy that there's something new](https://youtu.be/upMpPtQuc0c?t=02h03m28s)

[yeah so in this case let just drop in](https://youtu.be/upMpPtQuc0c?t=02h03m30s)

[using static to be able to go through](https://youtu.be/upMpPtQuc0c?t=02h03m33s)

[and do](https://youtu.be/upMpPtQuc0c?t=02h03m35s)

[it great question great question](https://youtu.be/upMpPtQuc0c?t=02h03m36s)

[okay uh okay so I think those were the](https://youtu.be/upMpPtQuc0c?t=02h03m39s)

[only places we put in the magical](https://youtu.be/upMpPtQuc0c?t=02h03m42s)

[strings though I think I've handled](https://youtu.be/upMpPtQuc0c?t=02h03m44s)

[that do you want to be able to change](https://youtu.be/upMpPtQuc0c?t=02h03m46s)

[your your test strings to be](https://youtu.be/upMpPtQuc0c?t=02h03m51s)

[interpolated and use name of or use them](https://youtu.be/upMpPtQuc0c?t=02h03m53s)

[use the consonants](https://youtu.be/upMpPtQuc0c?t=02h03m57s)

[there what would that look](https://youtu.be/upMpPtQuc0c?t=02h03m59s)

[like not sure in the test you're using](https://youtu.be/upMpPtQuc0c?t=02h04m02s)

[string literals I'm wondering if you](https://youtu.be/upMpPtQuc0c?t=02h04m04s)

[want to use interpolated strings so that](https://youtu.be/upMpPtQuc0c?t=02h04m06s)

[when you when we probably rename this](https://youtu.be/upMpPtQuc0c?t=02h04m08s)

[later you don't have to do a you could](https://youtu.be/upMpPtQuc0c?t=02h04m10s)

[just do control F search but oh because](https://youtu.be/upMpPtQuc0c?t=02h04m12s)

[of this no yeah not in there I'm talking](https://youtu.be/upMpPtQuc0c?t=02h04m15s)

[about like in the act test energ](https://youtu.be/upMpPtQuc0c?t=02h04m18s)

[tests for](https://youtu.be/upMpPtQuc0c?t=02h04m20s)

[[Music]](https://youtu.be/upMpPtQuc0c?t=02h04m21s)

[your oh sh oh I see so you're talking](https://youtu.be/upMpPtQuc0c?t=02h04m24s)

[about changing these ones up um I don't](https://youtu.be/upMpPtQuc0c?t=02h04m26s)

[think this one actually](https://youtu.be/upMpPtQuc0c?t=02h04m30s)

[has Having learned something new I can](https://youtu.be/upMpPtQuc0c?t=02h04m33s)

[go back to bed](https://youtu.be/upMpPtQuc0c?t=02h04m35s)

[now I you can um this oh it does](https://youtu.be/upMpPtQuc0c?t=02h04m36s)

[reference it does reference it so you're](https://youtu.be/upMpPtQuc0c?t=02h04m41s)

[right we could we could get away with](https://youtu.be/upMpPtQuc0c?t=02h04m43s)

[doing oh](https://youtu.be/upMpPtQuc0c?t=02h04m47s)

[oo I didn't think about that yeah we](https://youtu.be/upMpPtQuc0c?t=02h04m51s)

[start to get into some weird interesting](https://youtu.be/upMpPtQuc0c?t=02h04m54s)

[cases I don't know if I nothing to make](https://youtu.be/upMpPtQuc0c?t=02h04m59s)

[your rename easier but I think control F](https://youtu.be/upMpPtQuc0c?t=02h05m01s)

[will do it too as long you remember yeah](https://youtu.be/upMpPtQuc0c?t=02h05m03s)

[and actually you make a good point](https://youtu.be/upMpPtQuc0c?t=02h05m06s)

[before we get too carried away we should](https://youtu.be/upMpPtQuc0c?t=02h05m08s)

[we should finalize some naming here I I](https://youtu.be/upMpPtQuc0c?t=02h05m09s)

[think is so so couple couple questions](https://youtu.be/upMpPtQuc0c?t=02h05m17s)

[to to answer is skip the right word or](https://youtu.be/upMpPtQuc0c?t=02h05m20s)

[is ignore the right](https://youtu.be/upMpPtQuc0c?t=02h05m22s)

[word I ignore I think the general when I](https://youtu.be/upMpPtQuc0c?t=02h05m27s)

[think of Microsoft naming stuff they](https://youtu.be/upMpPtQuc0c?t=02h05m30s)

[usually use ignore over skip skip](https://youtu.be/upMpPtQuc0c?t=02h05m33s)

[usually implies you have a collection](https://youtu.be/upMpPtQuc0c?t=02h05m35s)

[and you're moving along it ignore](https://youtu.be/upMpPtQuc0c?t=02h05m37s)

[usually means I'm avoiding a behavior](https://youtu.be/upMpPtQuc0c?t=02h05m39s)

[it's true though one could argue the](https://youtu.be/upMpPtQuc0c?t=02h05m43s)

[parameters list is a](https://youtu.be/upMpPtQuc0c?t=02h05m45s)

[collection but but that that is leaky](https://youtu.be/upMpPtQuc0c?t=02h05m47s)

[abstraction letting the details of this](https://youtu.be/upMpPtQuc0c?t=02h05m51s)

[come up but to some degree I would argue](https://youtu.be/upMpPtQuc0c?t=02h05m53s)

[the users of this should have a concept](https://youtu.be/upMpPtQuc0c?t=02h05m55s)

[of what it's doing that it's checking](https://youtu.be/upMpPtQuc0c?t=02h05m58s)

[their](https://youtu.be/upMpPtQuc0c?t=02h06m00s)

[parameters](https://youtu.be/upMpPtQuc0c?t=02h06m02s)

[um and I think we might want the word](https://youtu.be/upMpPtQuc0c?t=02h06m05s)

[parameters in here somewhere](https://youtu.be/upMpPtQuc0c?t=02h06m07s)

[potentially ignore knowable](https://youtu.be/upMpPtQuc0c?t=02h06m10s)

[parameters is that I don't know if that](https://youtu.be/upMpPtQuc0c?t=02h06m13s)

[covers the full case because we don't](https://youtu.be/upMpPtQuc0c?t=02h06m15s)

[actually just do knowable we also](https://youtu.be/upMpPtQuc0c?t=02h06m17s)

[do wait didn't we do a case we IGN we](https://youtu.be/upMpPtQuc0c?t=02h06m20s)

[ignore](https://youtu.be/upMpPtQuc0c?t=02h06m23s)

[nullable if you're if it's nullable or](https://youtu.be/upMpPtQuc0c?t=02h06m25s)

[your default value is null those are the](https://youtu.be/upMpPtQuc0c?t=02h06m28s)

[two cases we handle because if you have](https://youtu.be/upMpPtQuc0c?t=02h06m30s)

[a non-nullable string but you take your](https://youtu.be/upMpPtQuc0c?t=02h06m31s)

[default value to](https://youtu.be/upMpPtQuc0c?t=02h06m33s)

[null you we kind of expecting you've](https://youtu.be/upMpPtQuc0c?t=02h06m35s)

[done something weird and you're you're](https://youtu.be/upMpPtQuc0c?t=02h06m38s)

[in pre- nullable land right that would](https://youtu.be/upMpPtQuc0c?t=02h06m40s)

[be my expectation at least correct Yeah](https://youtu.be/upMpPtQuc0c?t=02h06m42s)

[Izzy so the the idea here is that if](https://youtu.be/upMpPtQuc0c?t=02h06m45s)

[ignore in this case means the source](https://youtu.be/upMpPtQuc0c?t=02h06m48s)

[generator will not generate a test for](https://youtu.be/upMpPtQuc0c?t=02h06m51s)

[it](https://youtu.be/upMpPtQuc0c?t=02h06m54s)

[so for that specific parameter yes uh oh](https://youtu.be/upMpPtQuc0c?t=02h06m55s)

[I was going to show the test I'm](https://youtu.be/upMpPtQuc0c?t=02h06m59s)

[clicking on the generator so uh for](https://youtu.be/upMpPtQuc0c?t=02h07m00s)

[example your X unit one might be](https://youtu.be/upMpPtQuc0c?t=02h07m04s)

[slightly](https://youtu.be/upMpPtQuc0c?t=02h07m06s)

[clear uh yeah we can go up there uh so](https://youtu.be/upMpPtQuc0c?t=02h07m07s)

[if we go you just get some coloring](https://youtu.be/upMpPtQuc0c?t=02h07m10s)

[yeah so for example in this case uh it's](https://youtu.be/upMpPtQuc0c?t=02h07m14s)

[generating out for the The Constructor](https://youtu.be/upMpPtQuc0c?t=02h07m19s)

[tests and the idea here](https://youtu.be/upMpPtQuc0c?t=02h07m23s)

[is it shouldn't generate a test for here](https://youtu.be/upMpPtQuc0c?t=02h07m27s)

[or here because I'd argue there's a](https://youtu.be/upMpPtQuc0c?t=02h07m32s)

[third case which is a comma string](https://youtu.be/upMpPtQuc0c?t=02h07m35s)

[equals null if you put a fourth](https://youtu.be/upMpPtQuc0c?t=02h07m38s)

[parameter on](https://youtu.be/upMpPtQuc0c?t=02h07m40s)

[sorry comma](https://youtu.be/upMpPtQuc0c?t=02h07m42s)

[string whatever you want it yeah like](https://youtu.be/upMpPtQuc0c?t=02h07m45s)

[like](https://youtu.be/upMpPtQuc0c?t=02h07m48s)

[that yeah I think we actually handle](https://youtu.be/upMpPtQuc0c?t=02h07m50s)

[this case I do too I just think those](https://youtu.be/upMpPtQuc0c?t=02h07m53s)

[are the three cases I can't think of any](https://youtu.be/upMpPtQuc0c?t=02h07m55s)

[other U maybe a value](https://youtu.be/upMpPtQuc0c?t=02h07m57s)

[type value type we didn't test value](https://youtu.be/upMpPtQuc0c?t=02h07m59s)

[types but we'll go right a test for that](https://youtu.be/upMpPtQuc0c?t=02h08m02s)

[I don't think it'll be that different](https://youtu.be/upMpPtQuc0c?t=02h08m04s)

[from string I think it's probably](https://youtu.be/upMpPtQuc0c?t=02h08m05s)

[already working I think it's already](https://youtu.be/upMpPtQuc0c?t=02h08m07s)

[covered too I just think those are the](https://youtu.be/upMpPtQuc0c?t=02h08m09s)

[four cases I can't think of anything](https://youtu.be/upMpPtQuc0c?t=02h08m10s)

[else that we would not want to generate](https://youtu.be/upMpPtQuc0c?t=02h08m12s)

[a test for I think these are four valid](https://youtu.be/upMpPtQuc0c?t=02h08m14s)

[cases cuz the fourth case there](https://youtu.be/upMpPtQuc0c?t=02h08m16s)

[is a you're doing something weird or you](https://youtu.be/upMpPtQuc0c?t=02h08m19s)

[have no ability not turned on and in](https://youtu.be/upMpPtQuc0c?t=02h08m20s)

[which case this would be expected cuz](https://youtu.be/upMpPtQuc0c?t=02h08m23s)

[you're talking about that right yep on](https://youtu.be/upMpPtQuc0c?t=02h08m25s)

[all of those I'm also now wondering if](https://youtu.be/upMpPtQuc0c?t=02h08m29s)

[we want to put this in a nullable](https://youtu.be/upMpPtQuc0c?t=02h08m31s)

[disabled context just for the sake of](https://youtu.be/upMpPtQuc0c?t=02h08m32s)

[string Fu not having an](https://youtu.be/upMpPtQuc0c?t=02h08m34s)

[extra not having the null bang](https://youtu.be/upMpPtQuc0c?t=02h08m36s)

[afterwards would that mess us up with](https://youtu.be/upMpPtQuc0c?t=02h08m38s)

[our I so I think we should I think we](https://youtu.be/upMpPtQuc0c?t=02h08m40s)

[should go write a test to to to check it](https://youtu.be/upMpPtQuc0c?t=02h08m43s)

[I don't because these are like our end](https://youtu.be/upMpPtQuc0c?t=02h08m47s)

[to end test yeah totally no totally](https://youtu.be/upMpPtQuc0c?t=02h08m49s)

[agree I was just curious is when we](https://youtu.be/upMpPtQuc0c?t=02h08m52s)

[break apart the parameters is it the](https://youtu.be/upMpPtQuc0c?t=02h08m53s)

[fact that it's a null null bang versus](https://youtu.be/upMpPtQuc0c?t=02h08m55s)

[just a null because of the fact that we](https://youtu.be/upMpPtQuc0c?t=02h08m58s)

[have null ability turned on does that](https://youtu.be/upMpPtQuc0c?t=02h09m00s)

[make a difference when we parse it out I](https://youtu.be/upMpPtQuc0c?t=02h09m02s)

[so the one thing the because we](https://youtu.be/upMpPtQuc0c?t=02h09m04s)

[explicitly look for the default value of](https://youtu.be/upMpPtQuc0c?t=02h09m07s)

[the no literal I don't think the bang](https://youtu.be/upMpPtQuc0c?t=02h09m09s)

[makes a difference on whether this is](https://youtu.be/upMpPtQuc0c?t=02h09m12s)

[interpreted as the no literal or not so](https://youtu.be/upMpPtQuc0c?t=02h09m14s)

[the fact that we're looking at that I](https://youtu.be/upMpPtQuc0c?t=02h09m17s)

[think both now I think we should write a](https://youtu.be/upMpPtQuc0c?t=02h09m20s)

[test but I think I suspect both cases](https://youtu.be/upMpPtQuc0c?t=02h09m22s)

[are covered now but going back here if](https://youtu.be/upMpPtQuc0c?t=02h09m24s)

[we make the param if we make the enu](https://youtu.be/upMpPtQuc0c?t=02h09m29s)

[member name called ignored ignore](https://youtu.be/upMpPtQuc0c?t=02h09m31s)

[nullable parameters would you read all](https://youtu.be/upMpPtQuc0c?t=02h09m33s)

[if I was to ask you to identify the](https://youtu.be/upMpPtQuc0c?t=02h09m36s)

[nullable parameters would you identify](https://youtu.be/upMpPtQuc0c?t=02h09m38s)

[all four of these as Noble](https://youtu.be/upMpPtQuc0c?t=02h09m41s)

[parameters does that name make sense I](https://youtu.be/upMpPtQuc0c?t=02h09m43s)

[think I would not I would not interpret](https://youtu.be/upMpPtQuc0c?t=02h09m45s)

[line n is that I don't think you would](https://youtu.be/upMpPtQuc0c?t=02h09m48s)

[not interpret that as notable parameter](https://youtu.be/upMpPtQuc0c?t=02h09m50s)

[so then maybe the name isn't as good as](https://youtu.be/upMpPtQuc0c?t=02h09m52s)

[what do you](https://youtu.be/upMpPtQuc0c?t=02h09m55s)

[think it's hard because I kind of agree](https://youtu.be/upMpPtQuc0c?t=02h09m59s)

[with](https://youtu.be/upMpPtQuc0c?t=02h10m03s)

[you and I'm trying to turn off knowing](https://youtu.be/upMpPtQuc0c?t=02h10m06s)

[the implementation that we just wrote](https://youtu.be/upMpPtQuc0c?t=02h10m09s)

[and make my brain stop this where](https://youtu.be/upMpPtQuc0c?t=02h10m11s)

[co-pilot comes in Kevin Bing chat yeah](https://youtu.be/upMpPtQuc0c?t=02h10m14s)

[we don't need being chat I've got](https://youtu.be/upMpPtQuc0c?t=02h10m18s)

[uh co-](https://youtu.be/upMpPtQuc0c?t=02h10m21s)

[pilot uh do I not get help co-pilot chat](https://youtu.be/upMpPtQuc0c?t=02h10m25s)

[launch](https://youtu.be/upMpPtQuc0c?t=02h10m31s)

[there what is a good name](https://youtu.be/upMpPtQuc0c?t=02h10m34s)

[for uh](https://youtu.be/upMpPtQuc0c?t=02h10m39s)

[something](https://youtu.be/upMpPtQuc0c?t=02h10m42s)

[that](https://youtu.be/upMpPtQuc0c?t=02h10m43s)

[describes all for of](https://youtu.be/upMpPtQuc0c?t=02h10m45s)

[of these parameters now I'm going to do](https://youtu.be/upMpPtQuc0c?t=02h10m49s)

[this I'm going to do this and I'm going](https://youtu.be/upMpPtQuc0c?t=02h10m53s)

[to do](https://youtu.be/upMpPtQuc0c?t=02h10m56s)

[this also I didn't know that the pound](https://youtu.be/upMpPtQuc0c?t=02h10m58s)

[sign you could reference](https://youtu.be/upMpPtQuc0c?t=02h11m01s)

[files it's copilot that was news to me](https://youtu.be/upMpPtQuc0c?t=02h11m03s)

[oh really oh th this thing up](https://youtu.be/upMpPtQuc0c?t=02h11m07s)

[here is what you're talking about yeah](https://youtu.be/upMpPtQuc0c?t=02h11m09s)

[like but like even in the inline](https://youtu.be/upMpPtQuc0c?t=02h11m12s)

[chat optional string parameters](https://youtu.be/upMpPtQuc0c?t=02h11m15s)

[okay okay go](https://youtu.be/upMpPtQuc0c?t=02h11m18s)

[pilot](https://youtu.be/upMpPtQuc0c?t=02h11m23s)

[no that I would argue that doesn't cover](https://youtu.be/upMpPtQuc0c?t=02h11m29s)

[line seven](https://youtu.be/upMpPtQuc0c?t=02h11m32s)

[I correct or heaven forbid line 10 the](https://youtu.be/upMpPtQuc0c?t=02h11m35s)

[one that's named](https://youtu.be/upMpPtQuc0c?t=02h11m40s)

[int](https://youtu.be/upMpPtQuc0c?t=02h11m42s)

[I well You could argue that's an](https://youtu.be/upMpPtQuc0c?t=02h11m46s)

[optional](https://youtu.be/upMpPtQuc0c?t=02h11m49s)

[parameter yes but it it wants to name it](https://youtu.be/upMpPtQuc0c?t=02h11m50s)

[uh optional string](https://youtu.be/upMpPtQuc0c?t=02h11m54s)

[parameters I could get on board with](https://youtu.be/upMpPtQuc0c?t=02h11m56s)

[optional parameters and going okay yeah](https://youtu.be/upMpPtQuc0c?t=02h11m58s)

[maybe maybe but okay so despite the fact](https://youtu.be/upMpPtQuc0c?t=02h12m04s)

[that co-pilot is clearly an idiot um](https://youtu.be/upMpPtQuc0c?t=02h12m07s)

[yeah um I am wondering](https://youtu.be/upMpPtQuc0c?t=02h12m11s)

[though optional might make](https://youtu.be/upMpPtQuc0c?t=02h12m15s)

[a good addition](https://youtu.be/upMpPtQuc0c?t=02h12m18s)

[here ignore nullable or optional](https://youtu.be/upMpPtQuc0c?t=02h12m22s)

[parameters the only thing I hate about](https://youtu.be/upMpPtQuc0c?t=02h12m26s)

[that is you use the word or in that and](https://youtu.be/upMpPtQuc0c?t=02h12m27s)

[I hate the](https://youtu.be/upMpPtQuc0c?t=02h12m29s)

[word I totally](https://youtu.be/upMpPtQuc0c?t=02h12m31s)

[agree](https://youtu.be/upMpPtQuc0c?t=02h12m34s)

[ignore how do you say or without saying](https://youtu.be/upMpPtQuc0c?t=02h12m38s)

[or the problem is you still want a](https://youtu.be/upMpPtQuc0c?t=02h12m42s)

[functional or even if you put a](https://youtu.be/upMpPtQuc0c?t=02h12m44s)

[different word on it](https://youtu.be/upMpPtQuc0c?t=02h12m46s)

[because we it really is an or case](https://youtu.be/upMpPtQuc0c?t=02h12m49s)

[otherwise I'd say we could do something](https://youtu.be/upMpPtQuc0c?t=02h12m51s)

[like optional nullable parameters but](https://youtu.be/upMpPtQuc0c?t=02h12m52s)

[it's](https://youtu.be/upMpPtQuc0c?t=02h12m54s)

[really we did do we did handle](https://youtu.be/upMpPtQuc0c?t=02h12m55s)

[functionally an or when we were](https://youtu.be/upMpPtQuc0c?t=02h12m58s)

[detecting the](https://youtu.be/upMpPtQuc0c?t=02h12m59s)

[parameter I](https://youtu.be/upMpPtQuc0c?t=02h13m04s)

[don't ignore optional nullable](https://youtu.be/upMpPtQuc0c?t=02h13m08s)

[parameters that somewhat seems to imply](https://youtu.be/upMpPtQuc0c?t=02h13m13s)

[an an to me I could be wrong but](https://youtu.be/upMpPtQuc0c?t=02h13m15s)

[yeah the problem is is I don't see](https://youtu.be/upMpPtQuc0c?t=02h13m22s)

[it I don't see it playing](https://youtu.be/upMpPtQuc0c?t=02h13m31s)

[nice I guess the other thing to be aware](https://youtu.be/upMpPtQuc0c?t=02h13m36s)

[of though is this is definitely this is](https://youtu.be/upMpPtQuc0c?t=02h13m38s)

[an optin Behavior this isn't something](https://youtu.be/upMpPtQuc0c?t=02h13m40s)

[somebody's GNA get by](https://youtu.be/upMpPtQuc0c?t=02h13m42s)

[accident](https://youtu.be/upMpPtQuc0c?t=02h13m44s)

[so you know what what if we do this what](https://youtu.be/upMpPtQuc0c?t=02h13m46s)

[if we do](https://youtu.be/upMpPtQuc0c?t=02h13m49s)

[this uh JC suggests the word default in](https://youtu.be/upMpPtQuc0c?t=02h13m50s)

[there as](https://youtu.be/upMpPtQuc0c?t=02h13m54s)

[well yeah I can see it the only heny](https://youtu.be/upMpPtQuc0c?t=02h13m56s)

[with default is that we have a default](https://youtu.be/upMpPtQuc0c?t=02h13m59s)

[and so it seems to conflict a](https://youtu.be/upMpPtQuc0c?t=02h14m01s)

[little yeah](https://youtu.be/upMpPtQuc0c?t=02h14m05s)

[so what if we cheat and just try to](https://youtu.be/upMpPtQuc0c?t=02h14m09s)

[cover it in the](https://youtu.be/upMpPtQuc0c?t=02h14m11s)

[documentation I'm fine with that uh](https://youtu.be/upMpPtQuc0c?t=02h14m14s)

[let's see control the behavior of the](https://youtu.be/upMpPtQuc0c?t=02h14m17s)

[test](https://youtu.be/upMpPtQuc0c?t=02h14m21s)

[generator](https://youtu.be/upMpPtQuc0c?t=02h14m23s)

[uh allow](https://youtu.be/upMpPtQuc0c?t=02h14m25s)

[uh skip Noble parameters see it's doing](https://youtu.be/upMpPtQuc0c?t=02h14m29s)

[better there K I have not seen you do](https://youtu.be/upMpPtQuc0c?t=02h14m32s)

[this well with what is going on kopa you](https://youtu.be/upMpPtQuc0c?t=02h14m35s)

[always let me down with this stuff see I](https://youtu.be/upMpPtQuc0c?t=02h14m37s)

[typed the word the and it did the rest](https://youtu.be/upMpPtQuc0c?t=02h14m39s)

[here you want to see how well it does](https://youtu.be/upMpPtQuc0c?t=02h14m40s)

[here hey Copa do](https://youtu.be/upMpPtQuc0c?t=02h14m42s)

[it okay less impressive](https://youtu.be/upMpPtQuc0c?t=02h14m45s)

[less](https://youtu.be/upMpPtQuc0c?t=02h14m50s)

[impressive um the parameter is a noble](https://youtu.be/upMpPtQuc0c?t=02h15m09s)

[reference type well it's not reference](https://youtu.be/upMpPtQuc0c?t=02h15m12s)

[it's a noble type type](https://youtu.be/upMpPtQuc0c?t=02h15m15s)

[uh](https://youtu.be/upMpPtQuc0c?t=02h15m19s)

[isable it's not really because in](https://youtu.be/upMpPtQuc0c?t=02h15m22s)

[how knowable](https://youtu.be/upMpPtQuc0c?t=02h15m26s)

[reference types are](https://youtu.be/upMpPtQuc0c?t=02h15m28s)

[enabled uh](https://youtu.be/upMpPtQuc0c?t=02h15m32s)

[and the parameter](https://youtu.be/upMpPtQuc0c?t=02h15m34s)

[type is the nullable reference type](https://youtu.be/upMpPtQuc0c?t=02h15m37s)

[right because that that was directly](https://youtu.be/upMpPtQuc0c?t=02h15m40s)

[something we checked in our if condition](https://youtu.be/upMpPtQuc0c?t=02h15m42s)

[right uh okay co-pilot](https://youtu.be/upMpPtQuc0c?t=02h15m44s)

[yes Noble value types are enabled you](https://youtu.be/upMpPtQuc0c?t=02h15m48s)

[can't you can't really is anyone going](https://youtu.be/upMpPtQuc0c?t=02h15m51s)

[to have that not enabled what are you](https://youtu.be/upMpPtQuc0c?t=02h15m54s)

[running on C 1.0 I I think even in 1.0](https://youtu.be/upMpPtQuc0c?t=02h15m56s)

[Noble of T was a thing like that is yeah](https://youtu.be/upMpPtQuc0c?t=02h15m59s)

[um just put out to a question mark yet](https://youtu.be/upMpPtQuc0c?t=02h16m05s)

[parameter](https://youtu.be/upMpPtQuc0c?t=02h16m08s)

[uh has a default value of](https://youtu.be/upMpPtQuc0c?t=02h16m09s)

[null right yep those are only two cases](https://youtu.be/upMpPtQuc0c?t=02h16m14s)

[right and value types if you have a if](https://youtu.be/upMpPtQuc0c?t=02h16m19s)

[you have a nullable value](https://youtu.be/upMpPtQuc0c?t=02h16m23s)

[type uh well but this one that falls](https://youtu.be/upMpPtQuc0c?t=02h16m25s)

[into this case here](https://youtu.be/upMpPtQuc0c?t=02h16m30s)

[right whether it's value or reference](https://youtu.be/upMpPtQuc0c?t=02h16m31s)

[type no what I'm saying is if you just](https://youtu.be/upMpPtQuc0c?t=02h16m35s)

[have an INT question](https://youtu.be/upMpPtQuc0c?t=02h16m38s)

[mark without a default](https://youtu.be/upMpPtQuc0c?t=02h16m39s)

[value what do you think that I think](https://youtu.be/upMpPtQuc0c?t=02h16m45s)

[that's another case that so that is](https://youtu.be/upMpPtQuc0c?t=02h16m48s)

[certainly a case and one that I agree we](https://youtu.be/upMpPtQuc0c?t=02h16m51s)

[should not Jen a test for we should go](https://youtu.be/upMpPtQuc0c?t=02h16m55s)

[write a test because I and then if I was](https://youtu.be/upMpPtQuc0c?t=02h16m58s)

[going to be nitpicky I'd say we should](https://youtu.be/upMpPtQuc0c?t=02h17m01s)

[switch the bottom line of that summary](https://youtu.be/upMpPtQuc0c?t=02h17m02s)

[with the second line uh you can be as](https://youtu.be/upMpPtQuc0c?t=02h17m04s)

[nitpicky as you'd](https://youtu.be/upMpPtQuc0c?t=02h17m07s)

[like so you want to do](https://youtu.be/upMpPtQuc0c?t=02h17m09s)

[that yeah cuz I think one talking about](https://youtu.be/upMpPtQuc0c?t=02h17m12s)

[notable reference types notable value](https://youtu.be/upMpPtQuc0c?t=02h17m14s)

[types similar kind of thing and last one](https://youtu.be/upMpPtQuc0c?t=02h17m16s)

[is right um we may go through there's I](https://youtu.be/upMpPtQuc0c?t=02h17m18s)

[I believe the XML docs actually have a](https://youtu.be/upMpPtQuc0c?t=02h17m22s)

[thing for bulleted lists so we may yeah](https://youtu.be/upMpPtQuc0c?t=02h17m25s)

[if you want to find that real quick I'm](https://youtu.be/upMpPtQuc0c?t=02h17m30s)

[going to go add the test for uh nullable](https://youtu.be/upMpPtQuc0c?t=02h17m32s)

[of int right so uh parameter with](https://youtu.be/upMpPtQuc0c?t=02h17m36s)

[nullable value type uh let's see web uh](https://youtu.be/upMpPtQuc0c?t=02h17m43s)

[wbig says I think it's list and Li as](https://youtu.be/upMpPtQuc0c?t=02h17m48s)

[the](https://youtu.be/upMpPtQuc0c?t=02h17m53s)

[options oops list sounds right to me I](https://youtu.be/upMpPtQuc0c?t=02h17m55s)

[copied at the wrong](https://youtu.be/upMpPtQuc0c?t=02h17m59s)

[place um I can check it here in just a](https://youtu.be/upMpPtQuc0c?t=02h18m01s)

[second if I plug it in](https://youtu.be/upMpPtQuc0c?t=02h18m05s)

[it'll light up but I want to write this](https://youtu.be/upMpPtQuc0c?t=02h18m08s)

[test real quick parameter with](https://youtu.be/upMpPtQuc0c?t=02h18m10s)

[Noble see](https://youtu.be/upMpPtQuc0c?t=02h18m14s)

[value type does not generate test so](https://youtu.be/upMpPtQuc0c?t=02h18m16s)

[this guy here and what we are proposing](https://youtu.be/upMpPtQuc0c?t=02h18m20s)

[is int and I'm going to just change this](https://youtu.be/upMpPtQuc0c?t=02h18m23s)

[to age so it's mildly more](https://youtu.be/upMpPtQuc0c?t=02h18m25s)

[interesting um all of that should be the](https://youtu.be/upMpPtQuc0c?t=02h18m27s)

[same we don't care about the state of](https://youtu.be/upMpPtQuc0c?t=02h18m31s)

[nullability](https://youtu.be/upMpPtQuc0c?t=02h18m32s)

[that should be what that looks like](https://youtu.be/upMpPtQuc0c?t=02h18m36s)

[okay see how that](https://youtu.be/upMpPtQuc0c?t=02h18m39s)

[goes come on Green Circle](https://youtu.be/upMpPtQuc0c?t=02h18m45s)

[oh uh it gave me problem well it gave me](https://youtu.be/upMpPtQuc0c?t=02h18m52s)

[a t actually made it it gave me a](https://youtu.be/upMpPtQuc0c?t=02h18m55s)

[diagnostic air which means I've probably](https://youtu.be/upMpPtQuc0c?t=02h18m57s)

[got a compilation here oh um I've broken](https://youtu.be/upMpPtQuc0c?t=02h18m59s)

[all of our](https://youtu.be/upMpPtQuc0c?t=02h19m03s)

[test because oh yes this is the whole](https://youtu.be/upMpPtQuc0c?t=02h19m04s)

[this is this this was kind of what we](https://youtu.be/upMpPtQuc0c?t=02h19m08s)

[were just discussing a moment ago of hey](https://youtu.be/upMpPtQuc0c?t=02h19m09s)

[let's rename our enu member and then](https://youtu.be/upMpPtQuc0c?t=02h19m12s)

[let's not go fix it in all the tests so](https://youtu.be/upMpPtQuc0c?t=02h19m14s)

[you know there was](https://youtu.be/upMpPtQuc0c?t=02h19m17s)

[that uh let's see so I would just select](https://youtu.be/upMpPtQuc0c?t=02h19m19s)

[solution honestly at this](https://youtu.be/upMpPtQuc0c?t=02h19m23s)

[point oh that's a good point Tire](https://youtu.be/upMpPtQuc0c?t=02h19m26s)

[solution](https://youtu.be/upMpPtQuc0c?t=02h19m29s)

[rename nice concerns me that it didn't](https://youtu.be/upMpPtQuc0c?t=02h19m32s)

[land I thought there was more inside the](https://youtu.be/upMpPtQuc0c?t=02h19m35s)

[yeah it concerns me that it didn't](https://youtu.be/upMpPtQuc0c?t=02h19m37s)

[find that](https://youtu.be/upMpPtQuc0c?t=02h19m40s)

[one and it didn't](https://youtu.be/upMpPtQuc0c?t=02h19m43s)

[find this](https://youtu.be/upMpPtQuc0c?t=02h19m46s)

[one and that should be all of them I](https://youtu.be/upMpPtQuc0c?t=02h19m48s)

[think make sure it](https://youtu.be/upMpPtQuc0c?t=02h19m52s)

[compiles uh maybe in your sign Tex you](https://youtu.be/upMpPtQuc0c?t=02h19m59s)

[updated the one in your s Tex Receiver](https://youtu.be/upMpPtQuc0c?t=02h20m02s)

[right well now it you got you changed](https://youtu.be/upMpPtQuc0c?t=02h20m06s)

[all those to enums yes I mean not en](https://youtu.be/upMpPtQuc0c?t=02h20m08s)

[cons](https://youtu.be/upMpPtQuc0c?t=02h20m11s)

[sorry uh](https://youtu.be/upMpPtQuc0c?t=02h20m15s)

[uh it's because you have two](https://youtu.be/upMpPtQuc0c?t=02h20m18s)

[Constructors inside your other one this](https://youtu.be/upMpPtQuc0c?t=02h20m19s)

[is the Builder I was talking about oh](https://youtu.be/upMpPtQuc0c?t=02h20m21s)

[sorry um did you already push a thing](https://youtu.be/upMpPtQuc0c?t=02h20m26s)

[for this or no yeah I should just pull](https://youtu.be/upMpPtQuc0c?t=02h20m28s)

[your change is what I heard](https://youtu.be/upMpPtQuc0c?t=02h20m31s)

[p uh](https://youtu.be/upMpPtQuc0c?t=02h20m36s)

[conflict I'm going to take your side of](https://youtu.be/upMpPtQuc0c?t=02h20m39s)

[the](https://youtu.be/upMpPtQuc0c?t=02h20m42s)

[conflict and yeah sure fine](https://youtu.be/upMpPtQuc0c?t=02h20m44s)

[uh I don't really want](https://youtu.be/upMpPtQuc0c?t=02h20m48s)

[that delete stash](https://youtu.be/upMpPtQuc0c?t=02h20m49s)

[thanks okay so this should now](https://youtu.be/upMpPtQuc0c?t=02h20m52s)

[build](https://youtu.be/upMpPtQuc0c?t=02h20m55s)

[properly huz okay now if we go back to](https://youtu.be/upMpPtQuc0c?t=02h21m00s)

[our test Explorer just going to rerun](https://youtu.be/upMpPtQuc0c?t=02h21m04s)

[all to sanity](https://youtu.be/upMpPtQuc0c?t=02h21m07s)

[check okay and it works just](https://youtu.be/upMpPtQuc0c?t=02h21m12s)

[fine](https://youtu.be/upMpPtQuc0c?t=02h21m16s)

[I'm surprised it works just fine without](https://youtu.be/upMpPtQuc0c?t=02h21m21s)

[us changing any](https://youtu.be/upMpPtQuc0c?t=02h21m24s)

[code for nullable in for nullable Value](https://youtu.be/upMpPtQuc0c?t=02h21m26s)

[types yeah why did that](https://youtu.be/upMpPtQuc0c?t=02h21m30s)

[work I don't know this is why test need](https://youtu.be/upMpPtQuc0c?t=02h21m35s)

[to start red because I don't know](https://youtu.be/upMpPtQuc0c?t=02h21m37s)

[why I I now want to grab this and look](https://youtu.be/upMpPtQuc0c?t=02h21m42s)

[at it because I don't understand how](https://youtu.be/upMpPtQuc0c?t=02h21m45s)

[that passed is it because of the](https://youtu.be/upMpPtQuc0c?t=02h21m47s)

[annotated fact the fact it's](https://youtu.be/upMpPtQuc0c?t=02h21m50s)

[annotated I don't think so because I](https://youtu.be/upMpPtQuc0c?t=02h21m53s)

[explicitly got rid of the pound nullable](https://youtu.be/upMpPtQuc0c?t=02h21m56s)

[enabled at the](https://youtu.be/upMpPtQuc0c?t=02h21m58s)

[beginning yeah but isn't](https://youtu.be/upMpPtQuc0c?t=02h22m00s)

[it what version of.net are you running](https://youtu.be/upMpPtQuc0c?t=02h22m03s)

[isn't isn't that default isn't nullable](https://youtu.be/upMpPtQuc0c?t=02h22m06s)

[value types](https://youtu.be/upMpPtQuc0c?t=02h22m09s)

[default not not for this because you](https://youtu.be/upMpPtQuc0c?t=02h22m12s)

[have to](https://youtu.be/upMpPtQuc0c?t=02h22m15s)

[um so this is like lower level than](https://youtu.be/upMpPtQuc0c?t=02h22m18s)

[we're just running in standard 8 this is](https://youtu.be/upMpPtQuc0c?t=02h22m20s)

[like we're invoking the rosin compiler](https://youtu.be/upMpPtQuc0c?t=02h22m22s)

[by](https://youtu.be/upMpPtQuc0c?t=02h22m25s)

[hand so all the niceties that you might](https://youtu.be/upMpPtQuc0c?t=02h22m26s)

[get from like the MS build SDK yeah](https://youtu.be/upMpPtQuc0c?t=02h22m29s)

[those aren't here I'm like I don't even](https://youtu.be/upMpPtQuc0c?t=02h22m32s)

[know how to turn off Noble reference](https://youtu.be/upMpPtQuc0c?t=02h22m35s)

[nullable value types in a normal](https://youtu.be/upMpPtQuc0c?t=02h22m38s)

[project I mean in the Cs project is just](https://youtu.be/upMpPtQuc0c?t=02h22m41s)

[nullable disabled is the easy way to do](https://youtu.be/upMpPtQuc0c?t=02h22m44s)

[it well that's for Value type that's for](https://youtu.be/upMpPtQuc0c?t=02h22m46s)

[reference types right I don't think](https://youtu.be/upMpPtQuc0c?t=02h22m48s)

[value types you can't turn it off but](https://youtu.be/upMpPtQuc0c?t=02h22m51s)

[I'm I'm surprised that because I didn't](https://youtu.be/upMpPtQuc0c?t=02h22m52s)

[think any of](https://youtu.be/upMpPtQuc0c?t=02h22m54s)

[our which one of these because it's](https://youtu.be/upMpPtQuc0c?t=02h22m56s)

[clearly landing on one of these I think](https://youtu.be/upMpPtQuc0c?t=02h22m58s)

[I think it's landing on the bottom one](https://youtu.be/upMpPtQuc0c?t=02h23m00s)

[because it still has The annotation it](https://youtu.be/upMpPtQuc0c?t=02h23m02s)

[knows that it has a question mark at the](https://youtu.be/upMpPtQuc0c?t=02h23m03s)

[end](https://youtu.be/upMpPtQuc0c?t=02h23m04s)

[oh my only question my brain was to](https://youtu.be/upMpPtQuc0c?t=02h23m08s)

[write it without I I don't think you](https://youtu.be/upMpPtQuc0c?t=02h23m11s)

[can](https://youtu.be/upMpPtQuc0c?t=02h23m16s)

[I think annotated is a pretty widespread](https://youtu.be/upMpPtQuc0c?t=02h23m18s)

[it just works unless you literally write](https://youtu.be/upMpPtQuc0c?t=02h23m21s)

[nullable](https://youtu.be/upMpPtQuc0c?t=02h23m24s)

[int or nullable](https://youtu.be/upMpPtQuc0c?t=02h23m27s)

[string you basically do the compiled](https://youtu.be/upMpPtQuc0c?t=02h23m31s)

[version](https://youtu.be/upMpPtQuc0c?t=02h23m33s)

[but that'd actually be interesting would](https://youtu.be/upMpPtQuc0c?t=02h23m36s)

[that break if you did](https://youtu.be/upMpPtQuc0c?t=02h23m38s)

[Noble yeah I was about to say now I want](https://youtu.be/upMpPtQuc0c?t=02h23m39s)

[to test that because you're you're](https://youtu.be/upMpPtQuc0c?t=02h23m42s)

[proposing this right](https://youtu.be/upMpPtQuc0c?t=02h23m44s)

[yeah I I bet you that fails there's no](https://youtu.be/upMpPtQuc0c?t=02h23m49s)

[way it's no longer technically](https://youtu.be/upMpPtQuc0c?t=02h23m53s)

[annotated yeah totally fails do we](https://youtu.be/upMpPtQuc0c?t=02h23m57s)

[care how hard I'm kind of curious when](https://youtu.be/upMpPtQuc0c?t=02h24m02s)

[we get in there is there some other](https://youtu.be/upMpPtQuc0c?t=02h24m06s)

[thing we could just be grabbing oh I](https://youtu.be/upMpPtQuc0c?t=02h24m07s)

[like we can look at the ti so I'm just](https://youtu.be/upMpPtQuc0c?t=02h24m09s)

[curious if we stop there I'm just](https://youtu.be/upMpPtQuc0c?t=02h24m13s)

[curious what we can we can get the](https://youtu.be/upMpPtQuc0c?t=02h24m14s)

[symbol type like that's true so we could](https://youtu.be/upMpPtQuc0c?t=02h24m16s)

[go through now bear in mind it's going](https://youtu.be/upMpPtQuc0c?t=02h24m21s)

[to be a check for](https://youtu.be/upMpPtQuc0c?t=02h24m24s)

[generic I I don't think it's going to](https://youtu.be/upMpPtQuc0c?t=02h24m26s)

[have something easy I think it's](https://youtu.be/upMpPtQuc0c?t=02h24m27s)

[literally going to be we dive into this](https://youtu.be/upMpPtQuc0c?t=02h24m29s)

[sucker's type and pull it](https://youtu.be/upMpPtQuc0c?t=02h24m31s)

[apart I don't think there's going to be](https://youtu.be/upMpPtQuc0c?t=02h24m34s)

[a shorthand for this because I don't](https://youtu.be/upMpPtQuc0c?t=02h24m36s)

[think yeah Noble annotation](https://youtu.be/upMpPtQuc0c?t=02h24m39s)

[none I think you're going to end](https://youtu.be/upMpPtQuc0c?t=02h24m41s)

[up hunting it from generics and then and](https://youtu.be/upMpPtQuc0c?t=02h24m44s)

[then hunting it out as as you would any](https://youtu.be/upMpPtQuc0c?t=02h24m48s)

[other generic](https://youtu.be/upMpPtQuc0c?t=02h24m50s)

[type yeah well I I me you can't type](https://youtu.be/upMpPtQuc0c?t=02h24m52s)

[check like you normally would you have](https://youtu.be/upMpPtQuc0c?t=02h24m56s)

[to containing type wait no containing](https://youtu.be/upMpPtQuc0c?t=02h24m57s)

[type is null](https://youtu.be/upMpPtQuc0c?t=02h25m00s)

[wait ping type where do you see goes](https://youtu.be/upMpPtQuc0c?t=02h25m02s)

[down a little](https://youtu.be/upMpPtQuc0c?t=02h25m06s)

[bit uh keep](https://youtu.be/upMpPtQuc0c?t=02h25m09s)

[going there underlying type I thought](https://youtu.be/upMpPtQuc0c?t=02h25m13s)

[that was a containing type to somewhere](https://youtu.be/upMpPtQuc0c?t=02h25m15s)

[I don't know oh that's yeah Tuple](https://youtu.be/upMpPtQuc0c?t=02h25m17s)

[underlying type hey where was coning](https://youtu.be/upMpPtQuc0c?t=02h25m19s)

[type I saw it somewhere yeah well](https://youtu.be/upMpPtQuc0c?t=02h25m21s)

[because you're going to end up falling](https://youtu.be/upMpPtQuc0c?t=02h25m23s)

[into um pulling this apart you have to](https://youtu.be/upMpPtQuc0c?t=02h25m25s)

[look up in the well you you you end up](https://youtu.be/upMpPtQuc0c?t=02h25m28s)

[looking at the type itself and and going](https://youtu.be/upMpPtQuc0c?t=02h25m32s)

[for an open generic and saying hey is](https://youtu.be/upMpPtQuc0c?t=02h25m34s)

[the type of this thing the open generic](https://youtu.be/upMpPtQuc0c?t=02h25m36s)

[nullable of T if so blah blah blah treat](https://youtu.be/upMpPtQuc0c?t=02h25m37s)

[it the same](https://youtu.be/upMpPtQuc0c?t=02h25m41s)

[way I](https://youtu.be/upMpPtQuc0c?t=02h25m42s)

[I I don't know if I care I don't](https://youtu.be/upMpPtQuc0c?t=02h25m45s)

[remember the last time I saw somebody](https://youtu.be/upMpPtQuc0c?t=02h25m47s)

[write Noble of T rather than putting a](https://youtu.be/upMpPtQuc0c?t=02h25m49s)

[question mark on something I totally](https://youtu.be/upMpPtQuc0c?t=02h25m53s)

[agree now would it be fun to write well](https://youtu.be/upMpPtQuc0c?t=02h25m55s)

[but no I don't think it's necessary I](https://youtu.be/upMpPtQuc0c?t=02h25m58s)

[don't I don't I don't know if that's](https://youtu.be/upMpPtQuc0c?t=02h26m00s)

[actually a requirement from anyone I](https://youtu.be/upMpPtQuc0c?t=02h26m01s)

[agree if people are doing that I don't I](https://youtu.be/upMpPtQuc0c?t=02h26m05s)

[don't does autom marer even work if](https://youtu.be/upMpPtQuc0c?t=02h26m08s)

[they're on that all of a thing that they](https://youtu.be/upMpPtQuc0c?t=02h26m10s)

[don't have question mark well I don't](https://youtu.be/upMpPtQuc0c?t=02h26m13s)

[think there I don't think there's I](https://youtu.be/upMpPtQuc0c?t=02h26m15s)

[don't think there's a version of C that](https://youtu.be/upMpPtQuc0c?t=02h26m16s)

[um ever had that I think C 1.0 had Noble](https://youtu.be/upMpPtQuc0c?t=02h26m19s)

[value](https://youtu.be/upMpPtQuc0c?t=02h26m23s)

[types it had Noble value types but I](https://youtu.be/upMpPtQuc0c?t=02h26m24s)

[don't think it had Noble question](https://youtu.be/upMpPtQuc0c?t=02h26m26s)

[marks](https://youtu.be/upMpPtQuc0c?t=02h26m30s)

[oh okay that I that I could potentially](https://youtu.be/upMpPtQuc0c?t=02h26m32s)

[give](https://youtu.be/upMpPtQuc0c?t=02h26m35s)

[you okay are there any other cases we](https://youtu.be/upMpPtQuc0c?t=02h26m38s)

[want to write a test](https://youtu.be/upMpPtQuc0c?t=02h26m40s)

[for what was our X know ones I think we](https://youtu.be/upMpPtQuc0c?t=02h26m42s)

[covered pretty much all of them been](https://youtu.be/upMpPtQuc0c?t=02h26m46s)

[yeah good question we let's just run the](https://youtu.be/upMpPtQuc0c?t=02h26m48s)

[whole](https://youtu.be/upMpPtQuc0c?t=02h26m50s)

[Suite like I love that we ran the 182](https://youtu.be/upMpPtQuc0c?t=02h26m54s)

[unit test inside Auto marer in 300](https://youtu.be/upMpPtQuc0c?t=02h26m58s)

[milliseconds times and the generator](https://youtu.be/upMpPtQuc0c?t=02h27m02s)

[took nearly nearly 10 times as long for](https://youtu.be/upMpPtQuc0c?t=02h27m04s)

[nine oh I was right Nel value types were](https://youtu.be/upMpPtQuc0c?t=02h27m09s)

[introduced in C 2.0 so C](https://youtu.be/upMpPtQuc0c?t=02h27m12s)

[1.0](https://youtu.be/upMpPtQuc0c?t=02h27m15s)

[[Music]](https://youtu.be/upMpPtQuc0c?t=02h27m17s)

[did not did not exist in C](https://youtu.be/upMpPtQuc0c?t=02h27m18s)

[1.0 I think we can conclude no one is](https://youtu.be/upMpPtQuc0c?t=02h27m22s)

[running C 1.0 and referencing the latest](https://youtu.be/upMpPtQuc0c?t=02h27m24s)

[version of Auto marker with Source](https://youtu.be/upMpPtQuc0c?t=02h27m27s)

[generators cuz that P somebody with a](https://youtu.be/upMpPtQuc0c?t=02h27m30s)

[compiler new enough to run Source](https://youtu.be/upMpPtQuc0c?t=02h27m33s)

[generators and targeting Lang version](https://youtu.be/upMpPtQuc0c?t=02h27m35s)

[1.0 I don't even think you can set your](https://youtu.be/upMpPtQuc0c?t=02h27m37s)

[Lang version that old there's have you](https://youtu.be/upMpPtQuc0c?t=02h27m40s)

[tried](https://youtu.be/upMpPtQuc0c?t=02h27m44s)

[it no](https://youtu.be/upMpPtQuc0c?t=02h27m45s)

[uh okay this is failing but this is](https://youtu.be/upMpPtQuc0c?t=02h27m49s)

[failing because of the int that I](https://youtu.be/upMpPtQuc0c?t=02h27m51s)

[added right](https://youtu.be/upMpPtQuc0c?t=02h27m55s)

[so I](https://youtu.be/upMpPtQuc0c?t=02h27m57s)

[think did we expect to be able to handle](https://youtu.be/upMpPtQuc0c?t=02h27m59s)

[in unless I'm missing what you're saying](https://youtu.be/upMpPtQuc0c?t=02h28m02s)

[um the uh we can handle the int we just](https://youtu.be/upMpPtQuc0c?t=02h28m05s)

[have to do](https://youtu.be/upMpPtQuc0c?t=02h28m09s)

[a mocker use because again it doesn't](https://youtu.be/upMpPtQuc0c?t=02h28m11s)

[have a resolver that knows how to how to](https://youtu.be/upMpPtQuc0c?t=02h28m14s)

[resolve ins right so have we covered a](https://youtu.be/upMpPtQuc0c?t=02h28m16s)

[non-nullable we did the we did the](https://youtu.be/upMpPtQuc0c?t=02h28m21s)

[negatives did we do a positive of if](https://youtu.be/upMpPtQuc0c?t=02h28m23s)

[it's](https://youtu.be/upMpPtQuc0c?t=02h28m25s)

[a non-nullable value](https://youtu.be/upMpPtQuc0c?t=02h28m27s)

[type do we need to](https://youtu.be/upMpPtQuc0c?t=02h28m30s)

[um I think we can let these integration](https://youtu.be/upMpPtQuc0c?t=02h28m34s)

[tests cover that case uh oh and when you](https://youtu.be/upMpPtQuc0c?t=02h28m38s)

[do a use and register the](https://youtu.be/upMpPtQuc0c?t=02h28m42s)

[type register the right Ty so do we want](https://youtu.be/upMpPtQuc0c?t=02h28m45s)

[to make two while we're at it just](https://youtu.be/upMpPtQuc0c?t=02h28m48s)

[because you'll need the other one for](https://youtu.be/upMpPtQuc0c?t=02h28m50s)

[the other](https://youtu.be/upMpPtQuc0c?t=02h28m51s)

[case oh an uh a non- knowable int yeah](https://youtu.be/upMpPtQuc0c?t=02h28m52s)

[there so that that one](https://youtu.be/upMpPtQuc0c?t=02h28m57s)

[works](https://youtu.be/upMpPtQuc0c?t=02h28m59s)

[um I need another good number B besides](https://youtu.be/upMpPtQuc0c?t=02h29m04s)

[42 for all my random numbers when I was](https://youtu.be/upMpPtQuc0c?t=02h29m08s)

[first in college one of my professors he](https://youtu.be/upMpPtQuc0c?t=02h29m11s)

[would actually have the students he'd](https://youtu.be/upMpPtQuc0c?t=02h29m13s)

[say random number and he would just](https://youtu.be/upMpPtQuc0c?t=02h29m15s)

[expect you to be able to do random](https://youtu.be/upMpPtQuc0c?t=02h29m17s)

[string of numbers as fast as you could](https://youtu.be/upMpPtQuc0c?t=02h29m18s)

[go and he expected legit random like if](https://youtu.be/upMpPtQuc0c?t=02h29m20s)

[you weren't throwing in negatives and](https://youtu.be/upMpPtQuc0c?t=02h29m23s)

[bouncing all over the number line you](https://youtu.be/upMpPtQuc0c?t=02h29m25s)

[were doing something wrong do you have](https://youtu.be/upMpPtQuc0c?t=02h29m27s)

[to stay with whole numbers uh usually it](https://youtu.be/upMpPtQuc0c?t=02h29m29s)

[was just integers he didn't usually go](https://youtu.be/upMpPtQuc0c?t=02h29m31s)

[for Floats or anything wacky because](https://youtu.be/upMpPtQuc0c?t=02h29m33s)

[that would](https://youtu.be/upMpPtQuc0c?t=02h29m35s)

[be mildly](https://youtu.be/upMpPtQuc0c?t=02h29m36s)

[insane uh let's see uh so we're going to](https://youtu.be/upMpPtQuc0c?t=02h29m38s)

[do uh](https://youtu.be/upMpPtQuc0c?t=02h29m41s)

[age and then](https://youtu.be/upMpPtQuc0c?t=02h29m44s)

[years I don't know like I I have no idea](https://youtu.be/upMpPtQuc0c?t=02h29m48s)

[what any of this references right so](https://youtu.be/upMpPtQuc0c?t=02h29m51s)

[years needs to go up here right because](https://youtu.be/upMpPtQuc0c?t=02h29m54s)

[we have to have the optional things at](https://youtu.be/upMpPtQuc0c?t=02h29m58s)

[the](https://youtu.be/upMpPtQuc0c?t=02h29m59s)

[end and then that goes like that that](https://youtu.be/upMpPtQuc0c?t=02h30m01s)

[goes like that uh testable](https://youtu.be/upMpPtQuc0c?t=02h30m05s)

[name](https://youtu.be/upMpPtQuc0c?t=02h30m08s)

[um you were assigning those things into](https://youtu.be/upMpPtQuc0c?t=02h30m10s)

[properties is that necessary](https://youtu.be/upMpPtQuc0c?t=02h30m14s)

[that was me just trying to set up my](https://youtu.be/upMpPtQuc0c?t=02h30m17s)

[yeah I was trying to sample my arent no](https://youtu.be/upMpPtQuc0c?t=02h30m20s)

[exception throw if](https://youtu.be/upMpPtQuc0c?t=02h30m24s)

[null for people who haven't seen this](https://youtu.be/upMpPtQuc0c?t=02h30m26s)

[before this is this is the new hip way](https://youtu.be/upMpPtQuc0c?t=02h30m29s)

[of checking for null and](https://youtu.be/upMpPtQuc0c?t=02h30m32s)

[throwing throw tip can you force null](https://youtu.be/upMpPtQuc0c?t=02h30m33s)

[into int I don't think you can because](https://youtu.be/upMpPtQuc0c?t=02h30m37s)

[it just come out with the default value](https://youtu.be/upMpPtQuc0c?t=02h30m39s)

[so here's the fun part do you know what](https://youtu.be/upMpPtQuc0c?t=02h30m41s)

[null](https://youtu.be/upMpPtQuc0c?t=02h30m43s)

[is if you](https://youtu.be/upMpPtQuc0c?t=02h30m45s)

[if you were asked to Define what null is](https://youtu.be/upMpPtQuc0c?t=02h30m47s)

[what is null defined](https://youtu.be/upMpPtQuc0c?t=02h30m49s)

[as a point of memory](https://youtu.be/upMpPtQuc0c?t=02h30m51s)

[zero for in null is zero yeah w got it](https://youtu.be/upMpPtQuc0c?t=02h30m54s)

[no no in the runtime null is defined as](https://youtu.be/upMpPtQuc0c?t=02h31m02s)

[zero show me this the zero the zero](https://youtu.be/upMpPtQuc0c?t=02h31m07s)

[pointer I will I will I will have to](https://youtu.be/upMpPtQuc0c?t=02h31m09s)

[look it up but real quick the throw of](https://youtu.be/upMpPtQuc0c?t=02h31m11s)

[no callor argument expression this is](https://youtu.be/upMpPtQuc0c?t=02h31m13s)

[one of the coolest things because I was](https://youtu.be/upMpPtQuc0c?t=02h31m15s)

[showing some colleagues this the other](https://youtu.be/upMpPtQuc0c?t=02h31m17s)

[day is you obviously that the the way](https://youtu.be/upMpPtQuc0c?t=02h31m18s)

[they implemented this is you'll notice](https://youtu.be/upMpPtQuc0c?t=02h31m23s)

[it takes the two parameters it can now](https://youtu.be/upMpPtQuc0c?t=02h31m25s)

[throw an argument null exception with](https://youtu.be/upMpPtQuc0c?t=02h31m27s)

[the appropriate parand name because that](https://youtu.be/upMpPtQuc0c?t=02h31m29s)

[is important that is important if we](https://youtu.be/upMpPtQuc0c?t=02h31m31s)

[look at our analyzer and our](https://youtu.be/upMpPtQuc0c?t=02h31m34s)

[generator come on does yours actually](https://youtu.be/upMpPtQuc0c?t=02h31m42s)

[check that the name is correct as as](https://youtu.be/upMpPtQuc0c?t=02h31m45s)

[well as the of course it does if you're](https://youtu.be/upMpPtQuc0c?t=02h31m46s)

[going to throw an argument exception](https://youtu.be/upMpPtQuc0c?t=02h31m48s)

[darn it you should specify the pram name](https://youtu.be/upMpPtQuc0c?t=02h31m50s)

[properly don't you wish that there was](https://youtu.be/upMpPtQuc0c?t=02h31m52s)

[parameter null checking features yeah](https://youtu.be/upMpPtQuc0c?t=02h31m55s)

[that in the past couple days I've been](https://youtu.be/upMpPtQuc0c?t=02h31m57s)

[really missing that why is this thing](https://youtu.be/upMpPtQuc0c?t=02h31m59s)

[not](https://youtu.be/upMpPtQuc0c?t=02h32m02s)

[generating](https://youtu.be/upMpPtQuc0c?t=02h32m04s)

[test I mean it clearly generated](https://youtu.be/upMpPtQuc0c?t=02h32m09s)

[tests so when I was doing this earlier I](https://youtu.be/upMpPtQuc0c?t=02h32m13s)

[don't know if I was looking the wrong](https://youtu.be/upMpPtQuc0c?t=02h32m16s)

[place but I couldn't get them to](https://youtu.be/upMpPtQuc0c?t=02h32m17s)

[actually generate out I was having to](https://youtu.be/upMpPtQuc0c?t=02h32m18s)

[expose out the generated files via th](https://youtu.be/upMpPtQuc0c?t=02h32m22s)

[this view here is often](https://youtu.be/upMpPtQuc0c?t=02h32m26s)

[problematic I do not like this view it](https://youtu.be/upMpPtQuc0c?t=02h32m28s)

[it it causes me no end of problems but](https://youtu.be/upMpPtQuc0c?t=02h32m31s)

[the but yes echoing them out is fine I'm](https://youtu.be/upMpPtQuc0c?t=02h32m34s)

[curious why this thing's now failing](https://youtu.be/upMpPtQuc0c?t=02h32m38s)

[expected type of see if I click](https://youtu.be/upMpPtQuc0c?t=02h32m40s)

[here oh because it's doesn't know about](https://youtu.be/upMpPtQuc0c?t=02h32m44s)

[it it it it's not going to go uh no](https://youtu.be/upMpPtQuc0c?t=02h32m47s)

[exception was thrown throws no exception](https://youtu.be/upMpPtQuc0c?t=02h32m50s)

[with n string oh so it does count for](https://youtu.be/upMpPtQuc0c?t=02h32m53s)

[you oh then then it's happy so string](https://youtu.be/upMpPtQuc0c?t=02h32m58s)

[one Noble](https://youtu.be/upMpPtQuc0c?t=02h33m01s)

[name I thought we covered](https://youtu.be/upMpPtQuc0c?t=02h33m03s)

[that yeah I](https://youtu.be/upMpPtQuc0c?t=02h33m06s)

[wanna I want to now debug](https://youtu.be/upMpPtQuc0c?t=02h33m08s)

[like close some of the stuff up so I](https://youtu.be/upMpPtQuc0c?t=02h33m11s)

[don't have to deal with all of it uh](https://youtu.be/upMpPtQuc0c?t=02h33m14s)

[let's see](https://youtu.be/upMpPtQuc0c?t=02h33m16s)

[testl thank you debug I want to see](https://youtu.be/upMpPtQuc0c?t=02h33m18s)

[why](https://youtu.be/upMpPtQuc0c?t=02h33m22s)

[name](https://youtu.be/upMpPtQuc0c?t=02h33m26s)

[huh yeah that's](https://youtu.be/upMpPtQuc0c?t=02h33m29s)

[right wait why is it empty is it empty](https://youtu.be/upMpPtQuc0c?t=02h33m33s)

[string it is empty](https://youtu.be/upMpPtQuc0c?t=02h33m35s)

[string there's why is it empty string](https://youtu.be/upMpPtQuc0c?t=02h33m37s)

[um](https://youtu.be/upMpPtQuc0c?t=02h33m45s)

[is it because your mocker is putting in](https://youtu.be/upMpPtQuc0c?t=02h33m47s)

[empty string well hold on I'm wondering](https://youtu.be/upMpPtQuc0c?t=02h33m48s)

[if your suggestion of dealing with your](https://youtu.be/upMpPtQuc0c?t=02h33m50s)

[because you'll notice checking it's](https://youtu.be/upMpPtQuc0c?t=02h33m53s)

[looking for pram name](https://youtu.be/upMpPtQuc0c?t=02h33m54s)

[years with null string one throws](https://youtu.be/upMpPtQuc0c?t=02h33m56s)

[argument null](https://youtu.be/upMpPtQuc0c?t=02h33m59s)

[exception uh something is off](https://youtu.be/upMpPtQuc0c?t=02h34m01s)

[here so this this one is cor this test](https://youtu.be/upMpPtQuc0c?t=02h34m05s)

[is](https://youtu.be/upMpPtQuc0c?t=02h34m08s)

[correct oh yours is the last one we did](https://youtu.be/upMpPtQuc0c?t=02h34m10s)

[the](https://youtu.be/upMpPtQuc0c?t=02h34m13s)

[yeah so and you'll it is smart this is](https://youtu.be/upMpPtQuc0c?t=02h34m15s)

[what I mean where it's smart enough to](https://youtu.be/upMpPtQuc0c?t=02h34m19s)

[not crash out conflict yeah the the](https://youtu.be/upMpPtQuc0c?t=02h34m20s)

[problem is is it came up with string and](https://youtu.be/upMpPtQuc0c?t=02h34m25s)

[then check the wrong](https://youtu.be/upMpPtQuc0c?t=02h34m28s)

[parameter that's interesting oh because](https://youtu.be/upMpPtQuc0c?t=02h34m34s)

[it's checking age instead](https://youtu.be/upMpPtQuc0c?t=02h34m36s)

[of](https://youtu.be/upMpPtQuc0c?t=02h34m40s)

[years uh let's see hold on no control](https://youtu.be/upMpPtQuc0c?t=02h34m43s)

[is it's going name default in no the](https://youtu.be/upMpPtQuc0c?t=02h34m46s)

[thing all the way on the right](https://youtu.be/upMpPtQuc0c?t=02h34m50s)

[age yeah but age it pulled back value](https://youtu.be/upMpPtQuc0c?t=02h34m52s)

[yep you're right](https://youtu.be/upMpPtQuc0c?t=02h34m56s)

[Boo test name knowable name this can't](https://youtu.be/upMpPtQuc0c?t=02h34m58s)

[this this shouldn't generate a test](https://youtu.be/upMpPtQuc0c?t=02h35m03s)

[though so it's passing it's passing](https://youtu.be/upMpPtQuc0c?t=02h35m04s)

[default default end is going to be zero](https://youtu.be/upMpPtQuc0c?t=02h35m07s)

[right and so so we should be generating](https://youtu.be/upMpPtQuc0c?t=02h35m10s)

[test correct so we are not properly](https://youtu.be/upMpPtQuc0c?t=02h35m13s)

[handling](https://youtu.be/upMpPtQuc0c?t=02h35m17s)

[the non-nullable the we are not handling](https://youtu.be/upMpPtQuc0c?t=02h35m19s)

[the value type](https://youtu.be/upMpPtQuc0c?t=02h35m22s)

[case non above ite yeah so how is that a](https://youtu.be/upMpPtQuc0c?t=02h35m24s)

[double on](https://youtu.be/upMpPtQuc0c?t=02h35m28s)

[Tandra non above I type well I I think](https://youtu.be/upMpPtQuc0c?t=02h35m29s)

[this is easy though I I because once](https://youtu.be/upMpPtQuc0c?t=02h35m33s)

[again I think we can just go right into](https://youtu.be/upMpPtQuc0c?t=02h35m35s)

[here so okay shoot I wasn't going to](https://youtu.be/upMpPtQuc0c?t=02h35m37s)

[make us write a unit test but darn it](https://youtu.be/upMpPtQuc0c?t=02h35m40s)

[now we're writing a unit test CU clearly](https://youtu.be/upMpPtQuc0c?t=02h35m41s)

[we've just identified a case that was](https://youtu.be/upMpPtQuc0c?t=02h35m44s)

[not caught by our unit test and only](https://youtu.be/upMpPtQuc0c?t=02h35m46s)

[caught by an integration test so we](https://youtu.be/upMpPtQuc0c?t=02h35m47s)

[should](https://youtu.be/upMpPtQuc0c?t=02h35m49s)

[probably probably write a unit](https://youtu.be/upMpPtQuc0c?t=02h35m50s)

[test mostly so I can debug it](https://youtu.be/upMpPtQuc0c?t=02h35m53s)

[easier uh I feel good that I thought of](https://youtu.be/upMpPtQuc0c?t=02h35m56s)

[this case uh parameter with uh value](https://youtu.be/upMpPtQuc0c?t=02h35m58s)

[type does not generate](https://youtu.be/upMpPtQuc0c?t=02h36m03s)

[test wait should this one so no value](https://youtu.be/upMpPtQuc0c?t=02h36m11s)

[type get a test](https://youtu.be/upMpPtQuc0c?t=02h36m15s)

[generated a nullable yes that's true no](https://youtu.be/upMpPtQuc0c?t=02h36m17s)

[value type gets a test generated just](https://youtu.be/upMpPtQuc0c?t=02h36m20s)

[going through the rules as we've outline](https://youtu.be/upMpPtQuc0c?t=02h36m22s)

[them right do you agree I can't think of](https://youtu.be/upMpPtQuc0c?t=02h36m24s)

[a case if I'm building a library I can't](https://youtu.be/upMpPtQuc0c?t=02h36m27s)

[think of a case where I have a value](https://youtu.be/upMpPtQuc0c?t=02h36m29s)

[type that I'm ever going to throw an](https://youtu.be/upMpPtQuc0c?t=02h36m30s)

[argument n exception and I'm gonna and I](https://youtu.be/upMpPtQuc0c?t=02h36m32s)

[I'm gonna propose it doesn't matter the](https://youtu.be/upMpPtQuc0c?t=02h36m35s)

[state of that](https://youtu.be/upMpPtQuc0c?t=02h36m38s)

[enom right regardless whether that is](https://youtu.be/upMpPtQuc0c?t=02h36m40s)

[set or not so I'm going to delete the](https://youtu.be/upMpPtQuc0c?t=02h36m44s)

[enum Setter from this test as well and](https://youtu.be/upMpPtQuc0c?t=02h36m46s)

[we're just going to do this right this](https://youtu.be/upMpPtQuc0c?t=02h36m49s)

[should fail and it should show a diff](https://youtu.be/upMpPtQuc0c?t=02h36m51s)

[where it's generated a test right](https://youtu.be/upMpPtQuc0c?t=02h36m53s)

[so and it it worked flawlessly and the](https://youtu.be/upMpPtQuc0c?t=02h36m57s)

[unit test passed and what the](https://youtu.be/upMpPtQuc0c?t=02h37m00s)

[heck is it because of some if condition](https://youtu.be/upMpPtQuc0c?t=02h37m04s)

[I guess hold on let's let's go let's go](https://youtu.be/upMpPtQuc0c?t=02h37m07s)

[back let's turn this guy on right some](https://youtu.be/upMpPtQuc0c?t=02h37m09s)

[there is a there's a failure in here](https://youtu.be/upMpPtQuc0c?t=02h37m12s)

[somewhere and I don't know where yet](https://youtu.be/upMpPtQuc0c?t=02h37m14s)

[is the failure case with the en](https://youtu.be/upMpPtQuc0c?t=02h37m20s)

[set no that skips as](https://youtu.be/upMpPtQuc0c?t=02h37m27s)

[well is it when you have a first](https://youtu.be/upMpPtQuc0c?t=02h37m32s)

[parameter of something if you put string](https://youtu.be/upMpPtQuc0c?t=02h37m34s)

[first before the int because that](https://youtu.be/upMpPtQuc0c?t=02h37m37s)

[remember was doing string one and it was](https://youtu.be/upMpPtQuc0c?t=02h37m40s)

[getting confused oh that's a good point](https://youtu.be/upMpPtQuc0c?t=02h37m41s)

[because it it messed up so you think if](https://youtu.be/upMpPtQuc0c?t=02h37m44s)

[I do string](https://youtu.be/upMpPtQuc0c?t=02h37m46s)

[name uh not just end age then I think](https://youtu.be/upMpPtQuc0c?t=02h37m50s)

[that should be sufficient](https://youtu.be/upMpPtQuc0c?t=02h37m53s)

[okay it's going to generate two tests so](https://youtu.be/upMpPtQuc0c?t=02h37m57s)

[we're going to have to nope neither](https://youtu.be/upMpPtQuc0c?t=02h37m59s)

[should generate a test right](https://youtu.be/upMpPtQuc0c?t=02h38m01s)

[non-nullable string no the first one](https://youtu.be/upMpPtQuc0c?t=02h38m03s)

[should that's a non-nullable string](https://youtu.be/upMpPtQuc0c?t=02h38m05s)

[should generate a test ah good fair fair](https://youtu.be/upMpPtQuc0c?t=02h38m07s)

[fair fair okay so let's look at the](https://youtu.be/upMpPtQuc0c?t=02h38m10s)

[diff so that only did the string](https://youtu.be/upMpPtQuc0c?t=02h38m13s)

[one what's your xun one](https://youtu.be/upMpPtQuc0c?t=02h38m21s)

[again the xunit one has all the things](https://youtu.be/upMpPtQuc0c?t=02h38m23s)

[cuz we're looking](https://youtu.be/upMpPtQuc0c?t=02h38m27s)

[for we're looking for years and you know](https://youtu.be/upMpPtQuc0c?t=02h38m29s)

[we](https://youtu.be/upMpPtQuc0c?t=02h38m33s)

[could we could](https://youtu.be/upMpPtQuc0c?t=02h38m34s)

[do because thing yeah we could do the](https://youtu.be/upMpPtQuc0c?t=02h38m37s)

[whole thing if we wanted right so I](https://youtu.be/upMpPtQuc0c?t=02h38m39s)

[could I could come up here and what I](https://youtu.be/upMpPtQuc0c?t=02h38m42s)

[could do is I can just grab this also I](https://youtu.be/upMpPtQuc0c?t=02h38m44s)

[could probably rename that to not be](https://youtu.be/upMpPtQuc0c?t=02h38m47s)

[controller string but that was my](https://youtu.be/upMpPtQuc0c?t=02h38m48s)

[initial thing I was going on yeah that](https://youtu.be/upMpPtQuc0c?t=02h38m51s)

[might be nicer but](https://youtu.be/upMpPtQuc0c?t=02h38m54s)

[let's like part of the reason for for](https://youtu.be/upMpPtQuc0c?t=02h38m56s)

[some of the naming up there is so that](https://youtu.be/upMpPtQuc0c?t=02h38m59s)

[it copies and paste nicely into here so](https://youtu.be/upMpPtQuc0c?t=02h39m01s)

[this uh you're gonna have to remove](https://youtu.be/upMpPtQuc0c?t=02h39m03s)

[string off](https://youtu.be/upMpPtQuc0c?t=02h39m05s)

[controller](https://youtu.be/upMpPtQuc0c?t=02h39m06s)

[you](https://youtu.be/upMpPtQuc0c?t=02h39m08s)

[um let's run this test now because this](https://youtu.be/upMpPtQuc0c?t=02h39m11s)

[will obviously fail because we expect](https://youtu.be/upMpPtQuc0c?t=02h39m15s)

[some test but let's see what tests it I](https://youtu.be/upMpPtQuc0c?t=02h39m17s)

[hope so I hope it obviously](https://youtu.be/upMpPtQuc0c?t=02h39m19s)

[fails okay uh let's see](https://youtu.be/upMpPtQuc0c?t=02h39m22s)

[so controller could not be found are you](https://youtu.be/upMpPtQuc0c?t=02h39m25s)

[missing a directory reference uh what](https://youtu.be/upMpPtQuc0c?t=02h39m28s)

[did I do wrong when I copied this](https://youtu.be/upMpPtQuc0c?t=02h39m32s)

[in do you also need no](https://youtu.be/upMpPtQuc0c?t=02h39m34s)

[enable I](https://youtu.be/upMpPtQuc0c?t=02h39m37s)

[shouldn't because we're using reference](https://youtu.be/upMpPtQuc0c?t=02h39m40s)

[we're using Noble reference](https://youtu.be/upMpPtQuc0c?t=02h39m42s)

[types](https://youtu.be/upMpPtQuc0c?t=02h39m44s)

[oh that is a good](https://youtu.be/upMpPtQuc0c?t=02h39m46s)

[point Thank you so let's do](https://youtu.be/upMpPtQuc0c?t=02h39m48s)

[pound](https://youtu.be/upMpPtQuc0c?t=02h39m53s)

[that](https://youtu.be/upMpPtQuc0c?t=02h39m54s)

[um public class](https://youtu.be/upMpPtQuc0c?t=02h39m57s)

[controller oh are you using a primary](https://youtu.be/upMpPtQuc0c?t=02h40m01s)

[Constructor](https://youtu.be/upMpPtQuc0c?t=02h40m03s)

[yeah well not even oh this is](https://youtu.be/upMpPtQuc0c?t=02h40m05s)

[interesting will it work for a primary](https://youtu.be/upMpPtQuc0c?t=02h40m08s)

[Constructor yes yes and I know this](https://youtu.be/upMpPtQuc0c?t=02h40m09s)

[because there was a bug that came in the](https://youtu.be/upMpPtQuc0c?t=02h40m12s)

[other day where a user was um asking](https://youtu.be/upMpPtQuc0c?t=02h40m14s)

[about primary Constructors and so I](https://youtu.be/upMpPtQuc0c?t=02h40m17s)

[intentionally wrote a bunch of tests](https://youtu.be/upMpPtQuc0c?t=02h40m21s)

[around primary Constructor it ended up](https://youtu.be/upMpPtQuc0c?t=02h40m23s)

[not being the primary Constructors ended](https://youtu.be/upMpPtQuc0c?t=02h40m25s)

[up not being a](https://youtu.be/upMpPtQuc0c?t=02h40m27s)

[bug](https://youtu.be/upMpPtQuc0c?t=02h40m28s)

[but um I resolved it by putting in just](https://youtu.be/upMpPtQuc0c?t=02h40m30s)

[a bunch of tests Kevin what's all this](https://youtu.be/upMpPtQuc0c?t=02h40m34s)

[extra code we're doing we could just use](https://youtu.be/upMpPtQuc0c?t=02h40m37s)

[a primary Constructor well but I'd have](https://youtu.be/upMpPtQuc0c?t=02h40m38s)

[to change the underlying Lang version on](https://youtu.be/upMpPtQuc0c?t=02h40m41s)

[it got it but there are tests now what](https://youtu.be/upMpPtQuc0c?t=02h40m43s)

[is the underlining L version Oh for the](https://youtu.be/upMpPtQuc0c?t=02h40m47s)

[this](https://youtu.be/upMpPtQuc0c?t=02h40m51s)

[guy I don't remember what did we set it](https://youtu.be/upMpPtQuc0c?t=02h40m51s)

[to uh let's see with language version](https://youtu.be/upMpPtQuc0c?t=02h40m56s)

[language](https://youtu.be/upMpPtQuc0c?t=02h41m00s)

[version yeah where do you see that 46](https://youtu.be/upMpPtQuc0c?t=02h41m01s)

[46 language](https://youtu.be/upMpPtQuc0c?t=02h41m05s)

[version langing version default latest](https://youtu.be/upMpPtQuc0c?t=02h41m08s)

[latest](https://youtu.be/upMpPtQuc0c?t=02h41m12s)

[supported would be supported yeah](https://youtu.be/upMpPtQuc0c?t=02h41m13s)

[so look at that I didn't realize that](https://youtu.be/upMpPtQuc0c?t=02h41m20s)

[they actually decorated out a lot of the](https://youtu.be/upMpPtQuc0c?t=02h41m22s)

[stuff that was included Hey Kevin that's](https://youtu.be/upMpPtQuc0c?t=02h41m24s)

[how you do a bulleted list by the way](https://youtu.be/upMpPtQuc0c?t=02h41m27s)

[hey look at that that's how you do a](https://youtu.be/upMpPtQuc0c?t=02h41m29s)

[bulleted](https://youtu.be/upMpPtQuc0c?t=02h41m30s)

[list just gonna pin that real](https://youtu.be/upMpPtQuc0c?t=02h41m33s)

[quick um okay uh let's look at the](https://youtu.be/upMpPtQuc0c?t=02h41m35s)

[output of this okay did we get the same](https://youtu.be/upMpPtQuc0c?t=02h41m39s)

[okay so we got the same](https://youtu.be/upMpPtQuc0c?t=02h41m41s)

[output that's good the test is is](https://youtu.be/upMpPtQuc0c?t=02h41m43s)

[replicating the bad I do kind of want to](https://youtu.be/upMpPtQuc0c?t=02h41m46s)

[break this down like let's remove some](https://youtu.be/upMpPtQuc0c?t=02h41m48s)

[parameters cuz I'm really curious on](https://youtu.be/upMpPtQuc0c?t=02h41m49s)

[under what condition it's actually doing](https://youtu.be/upMpPtQuc0c?t=02h41m51s)

[this okay so I'm going to propose that I](https://youtu.be/upMpPtQuc0c?t=02h41m53s)

[can get rid of at least this much and it](https://youtu.be/upMpPtQuc0c?t=02h41m55s)

[shouldn't make a](https://youtu.be/upMpPtQuc0c?t=02h41m58s)

[difference the fact that it's falling](https://youtu.be/upMpPtQuc0c?t=02h41m59s)

[over on year I'm confused yeah I'm I'm](https://youtu.be/upMpPtQuc0c?t=02h42m01s)

[willing to bet it's got to be in these](https://youtu.be/upMpPtQuc0c?t=02h42m04s)

[first three parameters I'm willing to](https://youtu.be/upMpPtQuc0c?t=02h42m06s)

[bet we still get the two tests generated](https://youtu.be/upMpPtQuc0c?t=02h42m07s)

[okay so there's a failure okay so we get](https://youtu.be/upMpPtQuc0c?t=02h42m10s)

[we we do get the two t Okay so good it](https://youtu.be/upMpPtQuc0c?t=02h42m12s)

[is in the first three](https://youtu.be/upMpPtQuc0c?t=02h42m14s)

[parameters okay let can I do just](https://youtu.be/upMpPtQuc0c?t=02h42m16s)

[uh webling have a good](https://youtu.be/upMpPtQuc0c?t=02h42m21s)

[night see you well I don't know if](https://youtu.be/upMpPtQuc0c?t=02h42m24s)

[you'll see me at work tomorrow I don't I](https://youtu.be/upMpPtQuc0c?t=02h42m26s)

[I won't be in the office](https://youtu.be/upMpPtQuc0c?t=02h42m28s)

[but I will be](https://youtu.be/upMpPtQuc0c?t=02h42m30s)

[online okay let's go](https://youtu.be/upMpPtQuc0c?t=02h42m33s)

[here and let's see this I feel like this](https://youtu.be/upMpPtQuc0c?t=02h42m36s)

[is the exact test we had just a second](https://youtu.be/upMpPtQuc0c?t=02h42m39s)

[ago with in string is it](https://youtu.be/upMpPtQuc0c?t=02h42m41s)

[that is the same](https://youtu.be/upMpPtQuc0c?t=02h42m47s)

[but there we go how the heck is it](https://youtu.be/upMpPtQuc0c?t=02h42m49s)

[grabbing something something about this](https://youtu.be/upMpPtQuc0c?t=02h42m52s)

[is messing it](https://youtu.be/upMpPtQuc0c?t=02h42m55s)

[up that also would explain why it needs](https://youtu.be/upMpPtQuc0c?t=02h42m58s)

[a third one and it interprets the second](https://youtu.be/upMpPtQuc0c?t=02h43m00s)

[one as a string it named the test as a](https://youtu.be/upMpPtQuc0c?t=02h43m03s)

[string I was checking for years okay so](https://youtu.be/upMpPtQuc0c?t=02h43m06s)

[let's indent this wow we just found an](https://youtu.be/upMpPtQuc0c?t=02h43m10s)

[edge case uh I mean this why we write](https://youtu.be/upMpPtQuc0c?t=02h43m13s)

[test okay so let's let's catch it in in](https://youtu.be/upMpPtQuc0c?t=02h43m16s)

[the the thing](https://youtu.be/upMpPtQuc0c?t=02h43m19s)

[again because I bet this existed before](https://youtu.be/upMpPtQuc0c?t=02h43m21s)

[even we started writing these changes](https://youtu.be/upMpPtQuc0c?t=02h43m24s)

[yeah and I'm willing to bet it has to do](https://youtu.be/upMpPtQuc0c?t=02h43m26s)

[with the duplicate](https://youtu.be/upMpPtQuc0c?t=02h43m27s)

[types Magnus thanks for the sub uh let's](https://youtu.be/upMpPtQuc0c?t=02h43m29s)

[see here so symbol coming in is of](https://youtu.be/upMpPtQuc0c?t=02h43m33s)

[string I'd like to have the name pin to](https://youtu.be/upMpPtQuc0c?t=02h43m36s)

[go with it do](https://youtu.be/upMpPtQuc0c?t=02h43m39s)

[that uh Eric thanks for the sub as as](https://youtu.be/upMpPtQuc0c?t=02h43m42s)

[well uh okay so let's grab the name of](https://youtu.be/upMpPtQuc0c?t=02h43m46s)

[this](https://youtu.be/upMpPtQuc0c?t=02h43m49s)

[guy where are you I would like to know](https://youtu.be/upMpPtQuc0c?t=02h43m50s)

[your](https://youtu.be/upMpPtQuc0c?t=02h43m53s)

[name wow what is going on Rin also thank](https://youtu.be/upMpPtQuc0c?t=02h43m55s)

[you for the sub everybody's coming in](https://youtu.be/upMpPtQuc0c?t=02h43m58s)

[tonight uh oh there it is name it was](https://youtu.be/upMpPtQuc0c?t=02h44m01s)

[cleverly hidden under the property name](https://youtu.be/upMpPtQuc0c?t=02h44m05s)

[of name okay so this one makes sense](https://youtu.be/upMpPtQuc0c?t=02h44m08s)

[right we come](https://youtu.be/upMpPtQuc0c?t=02h44m10s)

[in is Noble is false for name that that](https://youtu.be/upMpPtQuc0c?t=02h44m13s)

[aligns with what we have okay great next](https://youtu.be/upMpPtQuc0c?t=02h44m18s)

[gears is nullable as](https://youtu.be/upMpPtQuc0c?t=02h44m24s)

[false also true but it should not can we](https://youtu.be/upMpPtQuc0c?t=02h44m28s)

[it should not generate a a test](https://youtu.be/upMpPtQuc0c?t=02h44m32s)

[here uh let's see can you suggest a](https://youtu.be/upMpPtQuc0c?t=02h44m36s)

[project that will look good for cover](https://youtu.be/upMpPtQuc0c?t=02h44m40s)

[letter that's a good](https://youtu.be/upMpPtQuc0c?t=02h44m43s)

[question](https://youtu.be/upMpPtQuc0c?t=02h44m46s)

[um let me think on that one for a minute](https://youtu.be/upMpPtQuc0c?t=02h44m49s)

[Cosmic I am](https://youtu.be/upMpPtQuc0c?t=02h44m55s)

[not I'm not sure Noble is true okay](https://youtu.be/upMpPtQuc0c?t=02h45m00s)

[spreadsheet application and that was one](https://youtu.be/upMpPtQuc0c?t=02h45m05s)

[of my little ones I did one point time](https://youtu.be/upMpPtQuc0c?t=02h45m07s)

[yeah little WPF app with having to do](https://youtu.be/upMpPtQuc0c?t=02h45m09s)

[like event firing and updates and](https://youtu.be/upMpPtQuc0c?t=02h45m12s)

[handling reference cells that's a](https://youtu.be/upMpPtQuc0c?t=02h45m16s)

[complicated there is](https://youtu.be/upMpPtQuc0c?t=02h45m20s)

[um on](https://youtu.be/upMpPtQuc0c?t=02h45m24s)

[uh there is a project I](https://youtu.be/upMpPtQuc0c?t=02h45m26s)

[was where is it uh oh what is his name](https://youtu.be/upMpPtQuc0c?t=02h45m32s)

[the the AWS Cloud bar](https://youtu.be/upMpPtQuc0c?t=02h45m37s)

[guy](https://youtu.be/upMpPtQuc0c?t=02h45m40s)

[um I am blanking on on his name and I](https://youtu.be/upMpPtQuc0c?t=02h45m43s)

[want his](https://youtu.be/upMpPtQuc0c?t=02h45m46s)

[name um he has a great project where](https://youtu.be/upMpPtQuc0c?t=02h45m48s)

[it's Forest Brazil that's right that's](https://youtu.be/upMpPtQuc0c?t=02h45m52s)

[what I'm looking](https://youtu.be/upMpPtQuc0c?t=02h45m55s)

[for um he has](https://youtu.be/upMpPtQuc0c?t=02h45m56s)

[a a cloud resume](https://youtu.be/upMpPtQuc0c?t=02h46m01s)

[challenge](https://youtu.be/upMpPtQuc0c?t=02h46m04s)

[um have you seen](https://youtu.be/upMpPtQuc0c?t=02h46m08s)

[this](https://youtu.be/upMpPtQuc0c?t=02h46m11s)

[uh here this this is what I'm looking](https://youtu.be/upMpPtQuc0c?t=02h46m12s)

[for](https://youtu.be/upMpPtQuc0c?t=02h46m15s)

[yeah](https://youtu.be/upMpPtQuc0c?t=02h46m19s)

[um this guy](https://youtu.be/upMpPtQuc0c?t=02h46m22s)

[here uh this](https://youtu.be/upMpPtQuc0c?t=02h46m25s)

[is there is a I want the I want the uh](https://youtu.be/upMpPtQuc0c?t=02h46m28s)

[there is](https://youtu.be/upMpPtQuc0c?t=02h46m32s)

[a yeah there's there's a GitHub for this](https://youtu.be/upMpPtQuc0c?t=02h46m35s)

[as well yeah this](https://youtu.be/upMpPtQuc0c?t=02h46m38s)

[so um](https://youtu.be/upMpPtQuc0c?t=02h46m43s)

[something in in this vicinity I would](https://youtu.be/upMpPtQuc0c?t=02h46m46s)

[propose doing or or something similar](https://youtu.be/upMpPtQuc0c?t=02h46m49s)

[this somebody who goes through this](https://youtu.be/upMpPtQuc0c?t=02h46m52s)

[is I I think very looks very good on a](https://youtu.be/upMpPtQuc0c?t=02h46m58s)

[resume and even if you don't do all of](https://youtu.be/upMpPtQuc0c?t=02h47m02s)

[it right some amount of this is perfect](https://youtu.be/upMpPtQuc0c?t=02h47m04s)

[is it demonstrates Proficiency in this](https://youtu.be/upMpPtQuc0c?t=02h47m07s)

[case this is an Azure one right um](https://youtu.be/upMpPtQuc0c?t=02h47m10s)

[there there's an Azure one there's an](https://youtu.be/upMpPtQuc0c?t=02h47m16s)

[AWS one there's ones with python or](https://youtu.be/upMpPtQuc0c?t=02h47m18s)

[similar the language doesn't matter as](https://youtu.be/upMpPtQuc0c?t=02h47m20s)

[much as demonstrating a certain amount](https://youtu.be/upMpPtQuc0c?t=02h47m23s)

[of proficiency with pushing stuff up to](https://youtu.be/upMpPtQuc0c?t=02h47m26s)

[the cloud so something to that effect uh](https://youtu.be/upMpPtQuc0c?t=02h47m28s)

[let's see build your own Docker oh dear](https://youtu.be/upMpPtQuc0c?t=02h47m32s)

[Heavens what Have you shared with me no](https://youtu.be/upMpPtQuc0c?t=02h47m34s)

[no this is build your own X that's just](https://youtu.be/upMpPtQuc0c?t=02h47m37s)

[happens to be the thing at the top so](https://youtu.be/upMpPtQuc0c?t=02h47m39s)

[you can choose whatever you want in](https://youtu.be/upMpPtQuc0c?t=02h47m41s)

[whatever language so if you scroll down](https://youtu.be/upMpPtQuc0c?t=02h47m42s)

[a bit](https://youtu.be/upMpPtQuc0c?t=02h47m44s)

[oh going so like build your own 3D](https://youtu.be/upMpPtQuc0c?t=02h47m45s)

[renderer and has it in different](https://youtu.be/upMpPtQuc0c?t=02h47m47s)

[languages so you can choose kind of what](https://youtu.be/upMpPtQuc0c?t=02h47m49s)

[you want to build it has a bunch of](https://youtu.be/upMpPtQuc0c?t=02h47m50s)

[different languages for how to build](https://youtu.be/upMpPtQuc0c?t=02h47m52s)

[that thing this is interesting command](https://youtu.be/upMpPtQuc0c?t=02h47m54s)

[line hang](https://youtu.be/upMpPtQuc0c?t=02h47m56s)

[on put that in my star list I might need](https://youtu.be/upMpPtQuc0c?t=02h47m58s)

[to go back and look at that that's](https://youtu.be/upMpPtQuc0c?t=02h48m01s)

[pretty](https://youtu.be/upMpPtQuc0c?t=02h48m02s)

[cool but yes that cloud skills challenge](https://youtu.be/upMpPtQuc0c?t=02h48m03s)

[if if if you're intentionally looking](https://youtu.be/upMpPtQuc0c?t=02h48m06s)

[for something to put on a a cover letter](https://youtu.be/upMpPtQuc0c?t=02h48m08s)

[that](https://youtu.be/upMpPtQuc0c?t=02h48m11s)

[is a worthwhile want to do okay so this](https://youtu.be/upMpPtQuc0c?t=02h48m13s)

[guy found its parameters if you manage](https://youtu.be/upMpPtQuc0c?t=02h48m16s)

[to build your own Docker you will be](https://youtu.be/upMpPtQuc0c?t=02h48m17s)

[ahead and Beyond yes that is that is](https://youtu.be/upMpPtQuc0c?t=02h48m19s)

[probably that that's why when I saw that](https://youtu.be/upMpPtQuc0c?t=02h48m22s)

[I was like um that might be a little](https://youtu.be/upMpPtQuc0c?t=02h48m24s)

[deep uh okay we want to go back to our](https://youtu.be/upMpPtQuc0c?t=02h48m27s)

[generator also this is one of the things](https://youtu.be/upMpPtQuc0c?t=02h48m31s)

[that's probably bad about this generator](https://youtu.be/upMpPtQuc0c?t=02h48m33s)

[usually I would move all of this code](https://youtu.be/upMpPtQuc0c?t=02h48m35s)

[Generation stuff not here rather than](https://youtu.be/upMpPtQuc0c?t=02h48m37s)

[having it be all just here okay so let's](https://youtu.be/upMpPtQuc0c?t=02h48m40s)

[look at like you just you be put in](https://youtu.be/upMpPtQuc0c?t=02h48m43s)

[another method something outside of this](https://youtu.be/upMpPtQuc0c?t=02h48m45s)

[Source generator so that there's a](https://youtu.be/upMpPtQuc0c?t=02h48m48s)

[separation between code that's](https://youtu.be/upMpPtQuc0c?t=02h48m49s)

[generating it and the thing that's](https://youtu.be/upMpPtQuc0c?t=02h48m51s)

[interacting with the source generator](https://youtu.be/upMpPtQuc0c?t=02h48m53s)

[Library probably makes it harder to test](https://youtu.be/upMpPtQuc0c?t=02h48m55s)

[too um yeah potentially okay so Noble](https://youtu.be/upMpPtQuc0c?t=02h48m57s)

[parameter index oh this is also from](https://youtu.be/upMpPtQuc0c?t=02h49m02s)

[this is](https://youtu.be/upMpPtQuc0c?t=02h49m06s)

[me what that was I wrote that line 45 44](https://youtu.be/upMpPtQuc0c?t=02h49m08s)

[through 48 so something may be weird](https://youtu.be/upMpPtQuc0c?t=02h49m12s)

[with well I edited it you had element](https://youtu.be/upMpPtQuc0c?t=02h49m14s)

[true element at so I'll take a little](https://youtu.be/upMpPtQuc0c?t=02h49m17s)

[bit of responsibility so if the thing is](https://youtu.be/upMpPtQuc0c?t=02h49m19s)

[on because the the behavior that we're](https://youtu.be/upMpPtQuc0c?t=02h49m22s)

[seeing is expected if somebody just uses](https://youtu.be/upMpPtQuc0c?t=02h49m24s)

[it blindly but we have the feature on so](https://youtu.be/upMpPtQuc0c?t=02h49m28s)

[this checks is](https://youtu.be/upMpPtQuc0c?t=02h49m31s)

[nullable I wonder if in remember it's](https://youtu.be/upMpPtQuc0c?t=02h49m37s)

[still an](https://youtu.be/upMpPtQuc0c?t=02h49m40s)

[INT it's failing on the year case which](https://youtu.be/upMpPtQuc0c?t=02h49m41s)

[is an INT and we never want to generate](https://youtu.be/upMpPtQuc0c?t=02h49m44s)

[test either case for INT yeah so this](https://youtu.be/upMpPtQuc0c?t=02h49m45s)

[this one here is generating up](https://youtu.be/upMpPtQuc0c?t=02h49m48s)

[for um for the first one so that one we](https://youtu.be/upMpPtQuc0c?t=02h49m54s)

[don't care about this one we care right](https://youtu.be/upMpPtQuc0c?t=02h49m57s)

[so this is parameter sub](https://youtu.be/upMpPtQuc0c?t=02h50m00s)

[one parameter sub one we should really](https://youtu.be/upMpPtQuc0c?t=02h50m03s)

[do a debug thing int right this is](https://youtu.be/upMpPtQuc0c?t=02h50m06s)

[coming](https://youtu.be/upMpPtQuc0c?t=02h50m10s)

[through and it's and it's](https://youtu.be/upMpPtQuc0c?t=02h50m12s)

[non-nullable okay wait like it I I agree](https://youtu.be/upMpPtQuc0c?t=02h50m16s)

[it is not](https://youtu.be/upMpPtQuc0c?t=02h50m22s)

[nullable it's true so this is this is a](https://youtu.be/upMpPtQuc0c?t=02h50m24s)

[bad this is potentially a bad check](https://youtu.be/upMpPtQuc0c?t=02h50m27s)

[right](https://youtu.be/upMpPtQuc0c?t=02h50m30s)

[of I think we I think what I almost want](https://youtu.be/upMpPtQuc0c?t=02h50m34s)

[to](https://youtu.be/upMpPtQuc0c?t=02h50m37s)

[do skip knowable parameters sh](https://youtu.be/upMpPtQuc0c?t=02h50m40s)

[can we just skip value types can we have](https://youtu.be/upMpPtQuc0c?t=02h50m45s)

[that as a blanket check at first because](https://youtu.be/upMpPtQuc0c?t=02h50m47s)

[I think this works for reference types](https://youtu.be/upMpPtQuc0c?t=02h50m49s)

[right I think that is a thing but I are](https://youtu.be/upMpPtQuc0c?t=02h50m51s)

[are so I I think I agree with you and I](https://youtu.be/upMpPtQuc0c?t=02h50m53s)

[think what we want is the following code](https://youtu.be/upMpPtQuc0c?t=02h50m57s)

[because we never had like this is a bug](https://youtu.be/upMpPtQuc0c?t=02h51m01s)

[before we got](https://youtu.be/upMpPtQuc0c?t=02h51m03s)

[here is value](https://youtu.be/upMpPtQuc0c?t=02h51m05s)

[type](https://youtu.be/upMpPtQuc0c?t=02h51m08s)

[right we never want to generate a test](https://youtu.be/upMpPtQuc0c?t=02h51m11s)

[for a value](https://youtu.be/upMpPtQuc0c?t=02h51m14s)

[type is that true though yeah yes it C](https://youtu.be/upMpPtQuc0c?t=02h51m18s)

[we we do not want to generate a thing](https://youtu.be/upMpPtQuc0c?t=02h51m22s)

[for Value type because we're explicitly](https://youtu.be/upMpPtQuc0c?t=02h51m24s)

[asserting on argument null exception it](https://youtu.be/upMpPtQuc0c?t=02h51m26s)

[doesn't make](https://youtu.be/upMpPtQuc0c?t=02h51m29s)

[sense](https://youtu.be/upMpPtQuc0c?t=02h51m30s)

[right it does not make sense if it's a](https://youtu.be/upMpPtQuc0c?t=02h51m35s)

[value type so we just need to parse out](https://youtu.be/upMpPtQuc0c?t=02h51m37s)

[is value type here right so](https://youtu.be/upMpPtQuc0c?t=02h51m41s)

[because if it's nullable then we assume](https://youtu.be/upMpPtQuc0c?t=02h51m46s)

[that the developers handled it if it's](https://youtu.be/upMpPtQuc0c?t=02h51m48s)

[not nullable it's going to have a](https://youtu.be/upMpPtQuc0c?t=02h51m50s)

[default value it's not going to be null](https://youtu.be/upMpPtQuc0c?t=02h51m51s)

[you can't shove null into a value type](https://youtu.be/upMpPtQuc0c?t=02h51m52s)

[yeah well and the test doesn't shove in](https://youtu.be/upMpPtQuc0c?t=02h51m55s)

[null to its own credit it shoves in](https://youtu.be/upMpPtQuc0c?t=02h51m56s)

[default of](https://youtu.be/upMpPtQuc0c?t=02h51m58s)

[type but that is true except that's zero](https://youtu.be/upMpPtQuc0c?t=02h52m01s)

[in this case well and and it's it's](https://youtu.be/upMpPtQuc0c?t=02h52m04s)

[not uh let's see this needs to be equals](https://youtu.be/upMpPtQuc0c?t=02h52m07s)

[equals true but even even though that](https://youtu.be/upMpPtQuc0c?t=02h52m09s)

[compil](https://youtu.be/upMpPtQuc0c?t=02h52m13s)

[the expectation is still an argument](https://youtu.be/upMpPtQuc0c?t=02h52m15s)

[null](https://youtu.be/upMpPtQuc0c?t=02h52m17s)

[exception you shouldn't be throwing](https://youtu.be/upMpPtQuc0c?t=02h52m19s)

[argument null exception on default of in](https://youtu.be/upMpPtQuc0c?t=02h52m21s)

[so like that's just like out of range](https://youtu.be/upMpPtQuc0c?t=02h52m24s)

[sure like that type of stuff is](https://youtu.be/upMpPtQuc0c?t=02h52m27s)

[legit so I think just blindly blanking](https://youtu.be/upMpPtQuc0c?t=02h52m30s)

[on all value types is probably](https://youtu.be/upMpPtQuc0c?t=02h52m34s)

[the wait is that seriously an](https://youtu.be/upMpPtQuc0c?t=02h52m37s)

[API oh look at that wow thank you](https://youtu.be/upMpPtQuc0c?t=02h52m40s)

[Copilot](https://youtu.be/upMpPtQuc0c?t=02h52m43s)

[out debug I I I almost had to think for](https://youtu.be/upMpPtQuc0c?t=02h52m46s)

[myself and like find the](https://youtu.be/upMpPtQuc0c?t=02h52m49s)

[API now we'll see if it works that was](https://youtu.be/upMpPtQuc0c?t=02h52m52s)

[so like 2022 come](https://youtu.be/upMpPtQuc0c?t=02h52m55s)

[on dang it no well no this is correct](https://youtu.be/upMpPtQuc0c?t=02h53m00s)

[this is correct one test this is this we](https://youtu.be/upMpPtQuc0c?t=02h53m04s)

[we didn't update our expectation so this](https://youtu.be/upMpPtQuc0c?t=02h53m06s)

[one here](https://youtu.be/upMpPtQuc0c?t=02h53m10s)

[is with no string](https://youtu.be/upMpPtQuc0c?t=02h53m12s)

[right uh Auto marker](https://youtu.be/upMpPtQuc0c?t=02h53m16s)

[setup I'm a little confused](https://youtu.be/upMpPtQuc0c?t=02h53m19s)

[though oh this is fine this is fine um](https://youtu.be/upMpPtQuc0c?t=02h53m25s)

[looks good to me well I was just](https://youtu.be/upMpPtQuc0c?t=02h53m28s)

[noticing that there wasn't an assert](https://youtu.be/upMpPtQuc0c?t=02h53m31s)

[here oh yes that is a detail well but](https://youtu.be/upMpPtQuc0c?t=02h53m34s)

[this that is actually somewhat expected](https://youtu.be/upMpPtQuc0c?t=02h53m38s)

[so it did it attempts to](https://youtu.be/upMpPtQuc0c?t=02h53m41s)

[and this is something that I I I](https://youtu.be/upMpPtQuc0c?t=02h53m45s)

[actually like um and it's not something](https://youtu.be/upMpPtQuc0c?t=02h53m47s)

[that's actually tested is it attempts to](https://youtu.be/upMpPtQuc0c?t=02h53m50s)

[detect your your unit test framework](https://youtu.be/upMpPtQuc0c?t=02h53m52s)

[based upon your referenced assemblies](https://youtu.be/upMpPtQuc0c?t=02h53m55s)

[and so it will all based upon it's the](https://youtu.be/upMpPtQuc0c?t=02h53m57s)

[detected framework it'll decorate your](https://youtu.be/upMpPtQuc0c?t=02h54m00s)

[methods accordingly when](https://youtu.be/upMpPtQuc0c?t=02h54m02s)

[needed right and it will generate a](https://youtu.be/upMpPtQuc0c?t=02h54m04s)

[appropriate assertions if none of those](https://youtu.be/upMpPtQuc0c?t=02h54m07s)

[are available it still generates the](https://youtu.be/upMpPtQuc0c?t=02h54m09s)

[method with the idea that](https://youtu.be/upMpPtQuc0c?t=02h54m11s)

[if you're using some other testing](https://youtu.be/upMpPtQuc0c?t=02h54m15s)

[framework you can still call that](https://youtu.be/upMpPtQuc0c?t=02h54m16s)

[method right you do the wiring up to](https://youtu.be/upMpPtQuc0c?t=02h54m18s)

[make your test call it but it'll still](https://youtu.be/upMpPtQuc0c?t=02h54m21s)

[gen all the methods for by magical](https://youtu.be/upMpPtQuc0c?t=02h54m25s)

[string by by whatever means you want to](https://youtu.be/upMpPtQuc0c?t=02h54m26s)

[invoke the method by sounds ugly you'd](https://youtu.be/upMpPtQuc0c?t=02h54m29s)

[probably have to like expose out the](https://youtu.be/upMpPtQuc0c?t=02h54m32s)

[generator code at the end of the day](https://youtu.be/upMpPtQuc0c?t=02h54m33s)

[well right but if you if you think of](https://youtu.be/upMpPtQuc0c?t=02h54m36s)

[the way you would do it in xunit like](https://youtu.be/upMpPtQuc0c?t=02h54m38s)

[ignoring the fact that this is going to](https://youtu.be/upMpPtQuc0c?t=02h54m41s)

[cause a duplicate test right if pretend](https://youtu.be/upMpPtQuc0c?t=02h54m42s)

[rather than fact I'm typing in Kevin's](https://youtu.be/upMpPtQuc0c?t=02h54m46s)

[thing you know public void Fu right I](https://youtu.be/upMpPtQuc0c?t=02h54m48s)

[can still do](https://youtu.be/upMpPtQuc0c?t=02h54m53s)

[this and invoke it which is slightly](https://youtu.be/upMpPtQuc0c?t=02h54m56s)

[better than won't it have a compile](https://youtu.be/upMpPtQuc0c?t=02h54m59s)

[layer no it hasn't existed until you](https://youtu.be/upMpPtQuc0c?t=02h55m01s)

[compile no that's that is the that's why](https://youtu.be/upMpPtQuc0c?t=02h55m04s)

[I was saying earlier how Source gener](https://youtu.be/upMpPtQuc0c?t=02h55m07s)

[have to be allant of code coming in that](https://youtu.be/upMpPtQuc0c?t=02h55m09s)

[may not compile yet](https://youtu.be/upMpPtQuc0c?t=02h55m13s)

[that was one of the big things with](https://youtu.be/upMpPtQuc0c?t=02h55m16s)

[Source generators is the ability to work](https://youtu.be/upMpPtQuc0c?t=02h55m17s)

[with code that doesn't work quite yet so](https://youtu.be/upMpPtQuc0c?t=02h55m20s)

[this will](https://youtu.be/upMpPtQuc0c?t=02h55m24s)

[compile uh I don't know if I have the](https://youtu.be/upMpPtQuc0c?t=02h55m25s)

[method name right uh but we can we can](https://youtu.be/upMpPtQuc0c?t=02h55m27s)

[double check it it's not that big a deal](https://youtu.be/upMpPtQuc0c?t=02h55m30s)

[I was just curious but yes you C you you](https://youtu.be/upMpPtQuc0c?t=02h55m33s)

[can go through](https://youtu.be/upMpPtQuc0c?t=02h55m35s)

[and stupid here actually I think I know](https://youtu.be/upMpPtQuc0c?t=02h55m37s)

[how to fix this](https://youtu.be/upMpPtQuc0c?t=02h55m40s)

[unload reload](https://youtu.be/upMpPtQuc0c?t=02h55m42s)

[load forces it to re reparse itself and](https://youtu.be/upMpPtQuc0c?t=02h55m45s)

[think](https://youtu.be/upMpPtQuc0c?t=02h55m51s)

[um because otherwise if you weren't able](https://youtu.be/upMpPtQuc0c?t=02h55m53s)

[to do it um see this](https://youtu.be/upMpPtQuc0c?t=02h55m56s)

[dot](https://youtu.be/upMpPtQuc0c?t=02h56m05s)

[where it is possible I](https://youtu.be/upMpPtQuc0c?t=02h56m08s)

[promise I promise I promise I promise](https://youtu.be/upMpPtQuc0c?t=02h56m11s)

[I'm not just making this](https://youtu.be/upMpPtQuc0c?t=02h56m14s)

[up um where is my](https://youtu.be/upMpPtQuc0c?t=02h56m16s)

[analyzers see this one has it right so](https://youtu.be/upMpPtQuc0c?t=02h56m20s)

[for example I go into a project where I](https://youtu.be/upMpPtQuc0c?t=02h56m23s)

[can actually see the stupid thing](https://youtu.be/upMpPtQuc0c?t=02h56m26s)

[working right so I can](https://youtu.be/upMpPtQuc0c?t=02h56m30s)

[do test](https://youtu.be/upMpPtQuc0c?t=02h56m32s)

[method public void](https://youtu.be/upMpPtQuc0c?t=02h56m35s)

[Fu then I can just invoke that method](https://youtu.be/upMpPtQuc0c?t=02h56m38s)

[right so assert afterwards no you don't](https://youtu.be/upMpPtQuc0c?t=02h56m43s)

[need to do an assert cuz well yes I](https://youtu.be/upMpPtQuc0c?t=02h56m45s)

[guess you would you would need to](https://youtu.be/upMpPtQuc0c?t=02h56m47s)

[actually um do it because no well it](https://youtu.be/upMpPtQuc0c?t=02h56m49s)

[depends because the the nonunit testy](https://youtu.be/upMpPtQuc0c?t=02h56m53s)

[framework as well will throw an](https://youtu.be/upMpPtQuc0c?t=02h56m56s)

[exception](https://youtu.be/upMpPtQuc0c?t=02h56m59s)

[so you might have to do an assert](https://youtu.be/upMpPtQuc0c?t=02h57m02s)

[depending on how how your unit test](https://youtu.be/upMpPtQuc0c?t=02h57m04s)

[framework handles it most of them](https://youtu.be/upMpPtQuc0c?t=02h57m08s)

[unhandled exception is the way it works](https://youtu.be/upMpPtQuc0c?t=02h57m09s)

[so it's just going to be a failure yeah](https://youtu.be/upMpPtQuc0c?t=02h57m12s)

[but it's one of those it's like I so far](https://youtu.be/upMpPtQuc0c?t=02h57m14s)

[we haven't had anybody complain about](https://youtu.be/upMpPtQuc0c?t=02h57m16s)

[wanting insert other unit test framework](https://youtu.be/upMpPtQuc0c?t=02h57m19s)

[here I will create my own unit test](https://youtu.be/upMpPtQuc0c?t=02h57m21s)

[framework I mean there there's a chance](https://youtu.be/upMpPtQuc0c?t=02h57m24s)

[the new I'm curious how the new](https://youtu.be/upMpPtQuc0c?t=02h57m26s)

[Microsoft Runner new Ms test the thing](https://youtu.be/upMpPtQuc0c?t=02h57m29s)

[is is the way it works in order to be](https://youtu.be/upMpPtQuc0c?t=02h57m31s)

[able to go fast is it drops reflection](https://youtu.be/upMpPtQuc0c?t=02h57m33s)

[in favor of source](https://youtu.be/upMpPtQuc0c?t=02h57m35s)

[generators so it's s it's I think it's](https://youtu.be/upMpPtQuc0c?t=02h57m37s)

[it's hip to Source generators that's how](https://youtu.be/upMpPtQuc0c?t=02h57m40s)

[that's source generators allowed them to](https://youtu.be/upMpPtQuc0c?t=02h57m43s)

[get rid of reflection and that's how](https://youtu.be/upMpPtQuc0c?t=02h57m45s)

[they've squeezed out every inch of](https://youtu.be/upMpPtQuc0c?t=02h57m47s)

[performance and things that otherwise](https://youtu.be/upMpPtQuc0c?t=02h57m49s)

[would have sucked see this is what](https://youtu.be/upMpPtQuc0c?t=02h57m51s)

[co-pilot's giving them AI is giving them](https://youtu.be/upMpPtQuc0c?t=02h57m53s)

[ideas like](https://youtu.be/upMpPtQuc0c?t=02h57m55s)

[this uh let's see uh okay so parameter](https://youtu.be/upMpPtQuc0c?t=02h57m57s)

[with value type does not generate tests](https://youtu.be/upMpPtQuc0c?t=02h58m01s)

[so I](https://youtu.be/upMpPtQuc0c?t=02h58m03s)

[think but should generate test it should](https://youtu.be/upMpPtQuc0c?t=02h58m07s)

[generate one](https://youtu.be/upMpPtQuc0c?t=02h58m09s)

[test yeah I'm trying to decide I think](https://youtu.be/upMpPtQuc0c?t=02h58m10s)

[what we want to do so I I think what I](https://youtu.be/upMpPtQuc0c?t=02h58m14s)

[want to do here is I want to do uh in](https://youtu.be/upMpPtQuc0c?t=02h58m17s)

[age because I think said when we did](https://youtu.be/upMpPtQuc0c?t=02h58m20s)

[that initially that didn't that didn't](https://youtu.be/upMpPtQuc0c?t=02h58m22s)

[cause our X agreed but I think what I](https://youtu.be/upMpPtQuc0c?t=02h58m24s)

[want to do is I want to have two tests](https://youtu.be/upMpPtQuc0c?t=02h58m28s)

[right I want to have one I want to leave](https://youtu.be/upMpPtQuc0c?t=02h58m30s)

[this test as is for yes I agree the](https://youtu.be/upMpPtQuc0c?t=02h58m32s)

[value type and then one I need to stop](https://youtu.be/upMpPtQuc0c?t=02h58m36s)

[doing that I copy from the wrong place I](https://youtu.be/upMpPtQuc0c?t=02h58m38s)

[I want to do this one to cover the](https://youtu.be/upMpPtQuc0c?t=02h58m41s)

[standalone int case and then I'll I'll](https://youtu.be/upMpPtQuc0c?t=02h58m43s)

[I'll change the other one up to to](https://youtu.be/upMpPtQuc0c?t=02h58m46s)

[handle it cuz I think there's value in](https://youtu.be/upMpPtQuc0c?t=02h58m48s)

[having](https://youtu.be/upMpPtQuc0c?t=02h58m50s)

[both again not that I expect people to](https://youtu.be/upMpPtQuc0c?t=02h58m52s)

[be doing this that](https://youtu.be/upMpPtQuc0c?t=02h58m55s)

[much uh let's see that goes like that](https://youtu.be/upMpPtQuc0c?t=02h58m56s)

[that goes like that don't care about I](https://youtu.be/upMpPtQuc0c?t=02h58m59s)

[love writing these kind of tests though](https://youtu.be/upMpPtQuc0c?t=02h59m02s)

[where it's just like slight](https://youtu.be/upMpPtQuc0c?t=02h59m03s)

[modifications in these weird edge](https://youtu.be/upMpPtQuc0c?t=02h59m04s)

[cases um](https://youtu.be/upMpPtQuc0c?t=02h59m07s)

[with um what how do we write the name of](https://youtu.be/upMpPtQuc0c?t=02h59m11s)

[this uh](https://youtu.be/upMpPtQuc0c?t=02h59m15s)

[generation](https://youtu.be/upMpPtQuc0c?t=02h59m18s)

[uh fix](https://youtu.be/upMpPtQuc0c?t=02h59m19s)

[bug uh generation uh parameter doesn't](https://youtu.be/upMpPtQuc0c?t=02h59m22s)

[handle](https://youtu.be/upMpPtQuc0c?t=02h59m26s)

