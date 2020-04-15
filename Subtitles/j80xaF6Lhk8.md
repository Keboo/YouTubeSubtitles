[YouTube Video](https://youtu.be/j80xaF6Lhk8)


[okay sorry for my absence online](https://youtu.be/j80xaF6Lhk8?t=00h03m47s)



[recently the whole kovat thing kind of](https://youtu.be/j80xaF6Lhk8?t=00h03m51s)



[through my usual schedule to the wind](https://youtu.be/j80xaF6Lhk8?t=00h03m53s)



[and so I dropped my normal schedule for](https://youtu.be/j80xaF6Lhk8?t=00h03m56s)



[streaming and I'm still trying to figure](https://youtu.be/j80xaF6Lhk8?t=00h04m00s)



[out what its gonna look like there's a](https://youtu.be/j80xaF6Lhk8?t=00h04m01s)



[good chance I'll just be moving from](https://youtu.be/j80xaF6Lhk8?t=00h04m04s)



[Thursdays to Tuesdays and still try to](https://youtu.be/j80xaF6Lhk8?t=00h04m05s)



[do it weekly or it might be every other](https://youtu.be/j80xaF6Lhk8?t=00h04m07s)



[week we'll see I'm still trying to](https://youtu.be/j80xaF6Lhk8?t=00h04m11s)



[figure it out so once I know I will](https://youtu.be/j80xaF6Lhk8?t=00h04m12s)



[actually put a schedule back up on my](https://youtu.be/j80xaF6Lhk8?t=00h04m14s)



[twitch page tonight we are going to do](https://youtu.be/j80xaF6Lhk8?t=00h04m16s)



[something a little bit different I'm](https://youtu.be/j80xaF6Lhk8?t=00h04m19s)



[going back to the system command line](https://youtu.be/j80xaF6Lhk8?t=00h04m22s)



[library that I've worked on in the past](https://youtu.be/j80xaF6Lhk8?t=00h04m23s)



[today we're going to go through and put](https://youtu.be/j80xaF6Lhk8?t=00h04m26s)



[the c-sharp eight nullable reference](https://youtu.be/j80xaF6Lhk8?t=00h04m28s)



[types in so for people who are](https://youtu.be/j80xaF6Lhk8?t=00h04m31s)



[unfamiliar with it on c-sharp eight](https://youtu.be/j80xaF6Lhk8?t=00h04m33s)



[they added a feature so that the](https://youtu.be/j80xaF6Lhk8?t=00h04m35s)



[compiler can help detect no reference](https://youtu.be/j80xaF6Lhk8?t=00h04m38s)



[exceptions or where you might be causing](https://youtu.be/j80xaF6Lhk8?t=00h04m41s)



[a no reference exception but to do that](https://youtu.be/j80xaF6Lhk8?t=00h04m43s)



[you have to be explicit about what](https://youtu.be/j80xaF6Lhk8?t=00h04m46s)



[variables and properties and arguments](https://youtu.be/j80xaF6Lhk8?t=00h04m48s)



[can potentially be null and which ones](https://youtu.be/j80xaF6Lhk8?t=00h04m50s)



[are expected to be non no it's worth](https://youtu.be/j80xaF6Lhk8?t=00h04m52s)



[noting that this is just static analysis](https://youtu.be/j80xaF6Lhk8?t=00h04m54s)



[just because something's declared non](https://youtu.be/j80xaF6Lhk8?t=00h04m56s)



[knowable doesn't actually stop somebody](https://youtu.be/j80xaF6Lhk8?t=00h04m58s)



[from passing a null in so you still have](https://youtu.be/j80xaF6Lhk8?t=00h05m00s)



[to do the checking but at least it lets](https://youtu.be/j80xaF6Lhk8?t=00h05m02s)



[you go through your code and get some](https://youtu.be/j80xaF6Lhk8?t=00h05m05s)



[really good analysis on where you might](https://youtu.be/j80xaF6Lhk8?t=00h05m06s)



[be making mistakes because when you have](https://youtu.be/j80xaF6Lhk8?t=00h05m08s)



[to be explicit about what's know and](https://youtu.be/j80xaF6Lhk8?t=00h05m10s)



[what's not things start to kind of shake](https://youtu.be/j80xaF6Lhk8?t=00h05m12s)



[out so for those people who are familiar](https://youtu.be/j80xaF6Lhk8?t=00h05m14s)



[with like jetbrains --is annotations for](https://youtu.be/j80xaF6Lhk8?t=00h05m16s)



[like can be null and not null](https://youtu.be/j80xaF6Lhk8?t=00h05m19s)



[it's similar to that only a lot more](https://youtu.be/j80xaF6Lhk8?t=00h05m21s)



[powerful so we are going to dive in let](https://youtu.be/j80xaF6Lhk8?t=00h05m23s)



[me first start with a couple links so I](https://youtu.be/j80xaF6Lhk8?t=00h05m28s)



[started this and I'm gonna be I believe](https://youtu.be/j80xaF6Lhk8?t=00h05m30s)



[this is all pushed up I'm gonna be](https://youtu.be/j80xaF6Lhk8?t=00h05m35s)



[starting from this branch here so my](https://youtu.be/j80xaF6Lhk8?t=00h05m38s)



[github command line API and then it's](https://youtu.be/j80xaF6Lhk8?t=00h05m42s)



[the knowability branch so I've gone](https://youtu.be/j80xaF6Lhk8?t=00h05m45s)



[through and done at least the first pass](https://youtu.be/j80xaF6Lhk8?t=00h05m47s)



[and done a lot of the easy stuff right](https://youtu.be/j80xaF6Lhk8?t=00h05m51s)



[so there's a few for example](https://youtu.be/j80xaF6Lhk8?t=00h05m53s)



[invocation pipeline right so so there's](https://youtu.be/j80xaF6Lhk8?t=00h05m57s)



[a few things like this so for noble](https://youtu.be/j80xaF6Lhk8?t=00h06m01s)



[reference types the key thing is the](https://youtu.be/j80xaF6Lhk8?t=00h06m04s)



[signature matches what you would do for](https://youtu.be/j80xaF6Lhk8?t=00h06m06s)



[a knowable value type so in question](https://youtu.be/j80xaF6Lhk8?t=00h06m08s)



[mark to make yourself a nullable int](https://youtu.be/j80xaF6Lhk8?t=00h06m11s)



[reference types now play by the same](https://youtu.be/j80xaF6Lhk8?t=00h06m13s)



[rule if you put a question mark it](https://youtu.be/j80xaF6Lhk8?t=00h06m15s)



[indicates that it could be null no](https://youtu.be/j80xaF6Lhk8?t=00h06m16s)



[question mark not know but because this](https://youtu.be/j80xaF6Lhk8?t=00h06m18s)



[is a syntax change you have to opt into](https://youtu.be/j80xaF6Lhk8?t=00h06m21s)



[it so up in the project file what I've](https://youtu.be/j80xaF6Lhk8?t=00h06m23s)



[done is I've turned it knowable enabled](https://youtu.be/j80xaF6Lhk8?t=00h06m26s)



[on it's worth noting that some of the](https://youtu.be/j80xaF6Lhk8?t=00h06m28s)



[features that we're going to use do](https://youtu.be/j80xaF6Lhk8?t=00h06m32s)



[require you to be on Visual Studio 16.3](https://youtu.be/j80xaF6Lhk8?t=00h06m33s)



[as well as your project needs to target](https://youtu.be/j80xaF6Lhk8?t=00h06m37s)



[either net stand or - one dot net core](https://youtu.be/j80xaF6Lhk8?t=00h06m41s)



[three one and I don't recall the](https://youtu.be/j80xaF6Lhk8?t=00h06m45s)



[framework equivalent maybe for a two](https://youtu.be/j80xaF6Lhk8?t=00h06m48s)



[question mark not a how about a set](https://youtu.be/j80xaF6Lhk8?t=00h06m52s)



[percent positive we'll get to why that](https://youtu.be/j80xaF6Lhk8?t=00h06m55s)



[matters in a moment but the first pass](https://youtu.be/j80xaF6Lhk8?t=00h06m56s)



[that I went through and did is basically](https://youtu.be/j80xaF6Lhk8?t=00h07m00s)



[cases like this right so before the](https://youtu.be/j80xaF6Lhk8?t=00h07m02s)



[knowable stuff we had something that](https://youtu.be/j80xaF6Lhk8?t=00h07m05s)



[looked kind of like this right and so](https://youtu.be/j80xaF6Lhk8?t=00h07m07s)



[it's very clear that this parameter is](https://youtu.be/j80xaF6Lhk8?t=00h07m09s)



[obviously knowable right we sat at a](https://youtu.be/j80xaF6Lhk8?t=00h07m11s)



[default value of null so we're gonna](https://youtu.be/j80xaF6Lhk8?t=00h07m14s)



[declare it as knowable and so you start](https://youtu.be/j80xaF6Lhk8?t=00h07m15s)



[declaring things like this and a whole](https://youtu.be/j80xaF6Lhk8?t=00h07m17s)



[bunch of stuff start shaking out and](https://youtu.be/j80xaF6Lhk8?t=00h07m19s)



[once you turn this on what you end up](https://youtu.be/j80xaF6Lhk8?t=00h07m21s)



[with is this lovely warning CS let's](https://youtu.be/j80xaF6Lhk8?t=00h07m23s)



[make this bigger ah there we go](https://youtu.be/j80xaF6Lhk8?t=00h07m28s)



[CS 80 604 right and so it goes through](https://youtu.be/j80xaF6Lhk8?t=00h07m30s)



[and now that the compiler has knowledge](https://youtu.be/j80xaF6Lhk8?t=00h07m33s)



[about what can be null or what could not](https://youtu.be/j80xaF6Lhk8?t=00h07m35s)



[be null it starts to complain and saying](https://youtu.be/j80xaF6Lhk8?t=00h07m37s)



[hey what about this what about this and](https://youtu.be/j80xaF6Lhk8?t=00h07m39s)



[so it is a big syntax change you end up](https://youtu.be/j80xaF6Lhk8?t=00h07m42s)



[going through your entire project and](https://youtu.be/j80xaF6Lhk8?t=00h07m45s)



[really just trying to decide is this](https://youtu.be/j80xaF6Lhk8?t=00h07m48s)



[knowable is this not it might in my](https://youtu.be/j80xaF6Lhk8?t=00h07m49s)



[handling know am I not and then](https://youtu.be/j80xaF6Lhk8?t=00h07m51s)



[decorating it appropriately and because](https://youtu.be/j80xaF6Lhk8?t=00h07m53s)



[just putting a question mark isn't](https://youtu.be/j80xaF6Lhk8?t=00h07m57s)



[always the right answer we're gonna look](https://youtu.be/j80xaF6Lhk8?t=00h07m59s)



[at some trying to remember the there's a](https://youtu.be/j80xaF6Lhk8?t=00h08m01s)



[special attribute that they have that](https://youtu.be/j80xaF6Lhk8?t=00h08m06s)



[says trust me it's not know](https://youtu.be/j80xaF6Lhk8?t=00h08m07s)



[the the way that it was pitched at one](https://youtu.be/j80xaF6Lhk8?t=00h08m10s)



[point was the dammit operator in most](https://youtu.be/j80xaF6Lhk8?t=00h08m12s)



[cases it's I think it's more like the](https://youtu.be/j80xaF6Lhk8?t=00h08m15s)



[trust me I'm the programmer so I've](https://youtu.be/j80xaF6Lhk8?t=00h08m18s)



[gotten the system command-line project I](https://youtu.be/j80xaF6Lhk8?t=00h08m21s)



[unloaded everything but this one project](https://youtu.be/j80xaF6Lhk8?t=00h08m24s)



[because I didn't want to deal with any](https://youtu.be/j80xaF6Lhk8?t=00h08m26s)



[extra fallout I was just interested in](https://youtu.be/j80xaF6Lhk8?t=00h08m28s)



[the core project so I unloaded](https://youtu.be/j80xaF6Lhk8?t=00h08m31s)



[everything and was just decided I'm](https://youtu.be/j80xaF6Lhk8?t=00h08m32s)



[gonna start working through all of these](https://youtu.be/j80xaF6Lhk8?t=00h08m35s)



[and I'll do this on a project-by-project](https://youtu.be/j80xaF6Lhk8?t=00h08m37s)



[basis and and deal with fallout as it](https://youtu.be/j80xaF6Lhk8?t=00h08m38s)



[comes so I went through and handled what](https://youtu.be/j80xaF6Lhk8?t=00h08m41s)



[I thought were all of the easy cases](https://youtu.be/j80xaF6Lhk8?t=00h08m44s)



[like this right so very clearly nullable](https://youtu.be/j80xaF6Lhk8?t=00h08m46s)



[go through and make the change and just](https://youtu.be/j80xaF6Lhk8?t=00h08m49s)



[kind of did a first pass so these](https://youtu.be/j80xaF6Lhk8?t=00h08m50s)



[remaining 50 warnings which there there](https://youtu.be/j80xaF6Lhk8?t=00h08m52s)



[may be more are all of the hard cases](https://youtu.be/j80xaF6Lhk8?t=00h08m55s)



[right the ones that took me or that I](https://youtu.be/j80xaF6Lhk8?t=00h08m58s)



[said this is going to take me more than](https://youtu.be/j80xaF6Lhk8?t=00h09m00s)



[three seconds to evaluate move on and](https://youtu.be/j80xaF6Lhk8?t=00h09m02s)



[I'll come back to it so we're gonna](https://youtu.be/j80xaF6Lhk8?t=00h09m04s)



[start working through some of these and](https://youtu.be/j80xaF6Lhk8?t=00h09m05s)



[I don't know if I've got a good place to](https://youtu.be/j80xaF6Lhk8?t=00h09m07s)



[start so I may just pick somewhere and](https://youtu.be/j80xaF6Lhk8?t=00h09m09s)



[start going and then we will see how](https://youtu.be/j80xaF6Lhk8?t=00h09m10s)



[that goes](https://youtu.be/j80xaF6Lhk8?t=00h09m14s)



[so if people have questions on this](https://youtu.be/j80xaF6Lhk8?t=00h09m14s)



[stuff or figuring out how how to do it](https://youtu.be/j80xaF6Lhk8?t=00h09m17s)



[the other see if I was smart there is so](https://youtu.be/j80xaF6Lhk8?t=00h09m19s)



[the actual nope nope not that link](https://youtu.be/j80xaF6Lhk8?t=00h09m27s)



[that's the magical link I want so there](https://youtu.be/j80xaF6Lhk8?t=00h09m29s)



[is a specification for the the c-sharp](https://youtu.be/j80xaF6Lhk8?t=00h09m33s)



[eight knowability stuff and then what's](https://youtu.be/j80xaF6Lhk8?t=00h09m36s)



[kind of hidden and not always well](https://youtu.be/j80xaF6Lhk8?t=00h09m39s)



[talked about is you see if I can get](https://youtu.be/j80xaF6Lhk8?t=00h09m42s)



[this is this guy here is is how to start](https://youtu.be/j80xaF6Lhk8?t=00h09m45s)



[handling some of the more unusual cases](https://youtu.be/j80xaF6Lhk8?t=00h09m50s)



[right so because ultimately there's a](https://youtu.be/j80xaF6Lhk8?t=00h09m52s)



[lot of cases where just saying knowable](https://youtu.be/j80xaF6Lhk8?t=00h09m54s)



[or not isn't quite true for example the](https://youtu.be/j80xaF6Lhk8?t=00h09m57s)



[tryparse methods right so you see if I](https://youtu.be/j80xaF6Lhk8?t=00h09m59s)



[can land on one real quick thank you](https://youtu.be/j80xaF6Lhk8?t=00h10m03s)



[John I don't know if brave is the right](https://youtu.be/j80xaF6Lhk8?t=00h10m11s)



[word stupid crazy I initially decided](https://youtu.be/j80xaF6Lhk8?t=00h10m12s)



[that I was going to go through and take](https://youtu.be/j80xaF6Lhk8?t=00h10m15s)



[this on at about it was a 1 a.m. coding](https://youtu.be/j80xaF6Lhk8?t=00h10m17s)



[session and I was like yeah let's do](https://youtu.be/j80xaF6Lhk8?t=00h10m19s)



[this let's start and](https://youtu.be/j80xaF6Lhk8?t=00h10m21s)



[at about 2:00 a.m. I realized yeah this](https://youtu.be/j80xaF6Lhk8?t=00h10m23s)



[was probably not a good idea to start at](https://youtu.be/j80xaF6Lhk8?t=00h10m25s)



[1:00 a.m.](https://youtu.be/j80xaF6Lhk8?t=00h10m26s)



[fortunately I have multiple mountain](https://youtu.be/j80xaF6Lhk8?t=00h10m29s)



[Dew's so hopefully ok we'll see we will](https://youtu.be/j80xaF6Lhk8?t=00h10m33s)



[see okay so let's just start going](https://youtu.be/j80xaF6Lhk8?t=00h10m39s)



[through and picking on these so this](https://youtu.be/j80xaF6Lhk8?t=00h10m42s)



[one's probably a simpler case to play](https://youtu.be/j80xaF6Lhk8?t=00h10m43s)



[with so and this is one where where I'm](https://youtu.be/j80xaF6Lhk8?t=00h10m46s)



[not a hundred percent sure I think I](https://youtu.be/j80xaF6Lhk8?t=00h10m49s)



[remember looking at this so we have this](https://youtu.be/j80xaF6Lhk8?t=00h10m51s)



[add method here it's very simple takes](https://youtu.be/j80xaF6Lhk8?t=00h10m52s)



[in a string name and a string value I](https://youtu.be/j80xaF6Lhk8?t=00h10m54s)



[declared the value as knowable because I](https://youtu.be/j80xaF6Lhk8?t=00h10m58s)



[believe there was a usage where we were](https://youtu.be/j80xaF6Lhk8?t=00h11m03s)



[very explicitly passing in something](https://youtu.be/j80xaF6Lhk8?t=00h11m05s)



[that could be no and I think it was this](https://youtu.be/j80xaF6Lhk8?t=00h11m07s)



[guy here so and again these things kind](https://youtu.be/j80xaF6Lhk8?t=00h11m10s)



[of move up and move down yeah so value](https://youtu.be/j80xaF6Lhk8?t=00h11m12s)



[can come in as null here right from the](https://youtu.be/j80xaF6Lhk8?t=00h11m15s)



[directive node this guy is calling add](https://youtu.be/j80xaF6Lhk8?t=00h11m17s)



[this lands in here and we might very](https://youtu.be/j80xaF6Lhk8?t=00h11m20s)



[well have the add now the part that gets](https://youtu.be/j80xaF6Lhk8?t=00h11m22s)



[interesting is this is the case where](https://youtu.be/j80xaF6Lhk8?t=00h11m24s)



[the list is already added to the](https://youtu.be/j80xaF6Lhk8?t=00h11m27s)



[dictionary right so I went to get the](https://youtu.be/j80xaF6Lhk8?t=00h11m29s)



[the list of values out if the list](https://youtu.be/j80xaF6Lhk8?t=00h11m32s)



[doesn't exist we don't allow an OLE to](https://youtu.be/j80xaF6Lhk8?t=00h11m34s)



[be added but if the list does exist](https://youtu.be/j80xaF6Lhk8?t=00h11m37s)



[apparently we do allow it all so the](https://youtu.be/j80xaF6Lhk8?t=00h11m39s)



[question is should we and I think the](https://youtu.be/j80xaF6Lhk8?t=00h11m41s)



[answer is no I think and John feel free](https://youtu.be/j80xaF6Lhk8?t=00h11m45s)



[to tell me if I'm stupid because you'll](https://youtu.be/j80xaF6Lhk8?t=00h11m49s)



[unfortunately get to see this pull](https://youtu.be/j80xaF6Lhk8?t=00h11m52s)



[request at the end but I think the](https://youtu.be/j80xaF6Lhk8?t=00h11m53s)



[answer is in this case we don't want](https://youtu.be/j80xaF6Lhk8?t=00h11m55s)



[null values to get added into this](https://youtu.be/j80xaF6Lhk8?t=00h11m57s)



[mostly because we've got like these](https://youtu.be/j80xaF6Lhk8?t=00h11m59s)



[contains where we're altima looking to](https://youtu.be/j80xaF6Lhk8?t=00h12m01s)



[pull non knowable strings out so I think](https://youtu.be/j80xaF6Lhk8?t=00h12m04s)



[the answer is we don't want to let the](https://youtu.be/j80xaF6Lhk8?t=00h12m07s)



[null go in because this is ultimately](https://youtu.be/j80xaF6Lhk8?t=00h12m09s)



[the warning right is we've told it that](https://youtu.be/j80xaF6Lhk8?t=00h12m11s)



[we expect a list of non notable strings](https://youtu.be/j80xaF6Lhk8?t=00h12m13s)



[and we're allowing a potential Knowle to](https://youtu.be/j80xaF6Lhk8?t=00h12m15s)



[get in so I think we basically want this](https://youtu.be/j80xaF6Lhk8?t=00h12m17s)



[same logic but because I'm crazy I'm](https://youtu.be/j80xaF6Lhk8?t=00h12m21s)



[gonna pull this out all right and do](https://youtu.be/j80xaF6Lhk8?t=00h12m24s)



[something like this sounds right](https://youtu.be/j80xaF6Lhk8?t=00h12m28s)



[be careful John it's telling me that it](https://youtu.be/j80xaF6Lhk8?t=00h12m31s)



[sounds right is sort of license for me](https://youtu.be/j80xaF6Lhk8?t=00h12m34s)



[to start breaking things so let's see](https://youtu.be/j80xaF6Lhk8?t=00h12m37s)



[actually let's do values here drop this](https://youtu.be/j80xaF6Lhk8?t=00h12m39s)



[guy here and then this guy will become](https://youtu.be/j80xaF6Lhk8?t=00h12m45s)



[values here we'll put the list in values](https://youtu.be/j80xaF6Lhk8?t=00h12m50s)



[values all right and so this is](https://youtu.be/j80xaF6Lhk8?t=00h12m57s)



[effectively empty now if the tests pass](https://youtu.be/j80xaF6Lhk8?t=00h13m05s)



[nothing is broken that wasn't already](https://youtu.be/j80xaF6Lhk8?t=00h13m09s)



[broken excellent that's what we like to](https://youtu.be/j80xaF6Lhk8?t=00h13m11s)



[hear and then we'll just invert the if](https://youtu.be/j80xaF6Lhk8?t=00h13m13s)



[statement and whack the else okay so](https://youtu.be/j80xaF6Lhk8?t=00h13m16s)



[what do you in line out variable](https://youtu.be/j80xaF6Lhk8?t=00h13m19s)



[declaration sure we can inline that why](https://youtu.be/j80xaF6Lhk8?t=00h13m22s)



[not okay one down forty nine to go](https://youtu.be/j80xaF6Lhk8?t=00h13m24s)



[assuming no more crop up as we go](https://youtu.be/j80xaF6Lhk8?t=00h13m28s)



[so f8 and let's just jump to the next](https://youtu.be/j80xaF6Lhk8?t=00h13m31s)



[one okay so this is another one that](https://youtu.be/j80xaF6Lhk8?t=00h13m34s)



[gets a little interesting right so this](https://youtu.be/j80xaF6Lhk8?t=00h13m37s)



[I've value descriptor has a type](https://youtu.be/j80xaF6Lhk8?t=00h13m40s)



[property on it that is declared as non](https://youtu.be/j80xaF6Lhk8?t=00h13m44s)



[knowable so the question is should it be](https://youtu.be/j80xaF6Lhk8?t=00h13m47s)



[knowable or should it not be and this is](https://youtu.be/j80xaF6Lhk8?t=00h13m50s)



[where I believe I saw multiple cases](https://youtu.be/j80xaF6Lhk8?t=00h13m53s)



[where it could go either way](https://youtu.be/j80xaF6Lhk8?t=00h13m55s)



[and I think the answer is the](https://youtu.be/j80xaF6Lhk8?t=00h13m56s)



[expectation is non null I think but](https://youtu.be/j80xaF6Lhk8?t=00h13m59s)



[there was obviously a lot of usages here](https://youtu.be/j80xaF6Lhk8?t=00h14m02s)



[I'm a little disappointed that my](https://youtu.be/j80xaF6Lhk8?t=00h14m05s)



[extension doesn't change the font size a](https://youtu.be/j80xaF6Lhk8?t=00h14m07s)



[visual area of my resharpen find all](https://youtu.be/j80xaF6Lhk8?t=00h14m10s)



[window I might just have to go through](https://youtu.be/j80xaF6Lhk8?t=00h14m13s)



[and check it so the what I'm really](https://youtu.be/j80xaF6Lhk8?t=00h14m15s)



[interested in knowing is looking at its](https://youtu.be/j80xaF6Lhk8?t=00h14m17s)



[usage and determining if the expectation](https://youtu.be/j80xaF6Lhk8?t=00h14m21s)



[is knowable or non nullable so it gets](https://youtu.be/j80xaF6Lhk8?t=00h14m23s)



[passed into here which is declared as](https://youtu.be/j80xaF6Lhk8?t=00h14m25s)



[non knowable and this guy clearly isn't](https://youtu.be/j80xaF6Lhk8?t=00h14m28s)



[checking for null so that's expected](https://youtu.be/j80xaF6Lhk8?t=00h14m30s)



[okay find results all right so that](https://youtu.be/j80xaF6Lhk8?t=00h14m33s)



[one's there these are just equality](https://youtu.be/j80xaF6Lhk8?t=00h14m36s)



[checks](https://youtu.be/j80xaF6Lhk8?t=00h14m38s)



[see that's an equality check how does](https://youtu.be/j80xaF6Lhk8?t=00h14m41s)



[this one get used so convert if needed](https://youtu.be/j80xaF6Lhk8?t=00h14m43s)



[takes in a type same thing clearly non](https://youtu.be/j80xaF6Lhk8?t=00h14m47s)



[knowable so that's not expected to be](https://youtu.be/j80xaF6Lhk8?t=00h14m54s)



[known so I think the answer and again I](https://youtu.be/j80xaF6Lhk8?t=00h14m57s)



[just the the problem with the Nobel](https://youtu.be/j80xaF6Lhk8?t=00h15m02s)



[reference types is is all about](https://youtu.be/j80xaF6Lhk8?t=00h15m05s)



[declaring your intent the problem is](https://youtu.be/j80xaF6Lhk8?t=00h15m06s)



[sometimes going through your code it's](https://youtu.be/j80xaF6Lhk8?t=00h15m08s)



[not always clear what your intent was](https://youtu.be/j80xaF6Lhk8?t=00h15m10s)



[because I've now done this on multiple](https://youtu.be/j80xaF6Lhk8?t=00h15m13s)



[projects so here for example right we're](https://youtu.be/j80xaF6Lhk8?t=00h15m15s)



[doing value type dot get default value](https://youtu.be/j80xaF6Lhk8?t=00h15m17s)



[for type which I know as an extension](https://youtu.be/j80xaF6Lhk8?t=00h15m19s)



[method but I don't think it checks for a](https://youtu.be/j80xaF6Lhk8?t=00h15m21s)



[null right no it doesn't it just](https://youtu.be/j80xaF6Lhk8?t=00h15m23s)



[dereferences so okay so that clearly is](https://youtu.be/j80xaF6Lhk8?t=00h15m25s)



[expecting non null expects non null](https://youtu.be/j80xaF6Lhk8?t=00h15m31s)



[expects non null okay so I believe the](https://youtu.be/j80xaF6Lhk8?t=00h15m35s)



[interface is correct this should be non](https://youtu.be/j80xaF6Lhk8?t=00h15m38s)



[null](https://youtu.be/j80xaF6Lhk8?t=00h15m40s)



[okay so now back to wherever that usage](https://youtu.be/j80xaF6Lhk8?t=00h15m41s)



[was that was squawking at me did that so](https://youtu.be/j80xaF6Lhk8?t=00h15m44s)



[so here right so we agree that this guy](https://youtu.be/j80xaF6Lhk8?t=00h15m54s)



[should be non known so the problem is is](https://youtu.be/j80xaF6Lhk8?t=00h15m57s)



[argument argument type is declared as](https://youtu.be/j80xaF6Lhk8?t=00h15m59s)



[knowable and I think this should be non](https://youtu.be/j80xaF6Lhk8?t=00h16m01s)



[known I think but I'm very aware that](https://youtu.be/j80xaF6Lhk8?t=00h16m06s)



[that's likely to cause a problem up here](https://youtu.be/j80xaF6Lhk8?t=00h16m10s)



[so if we go and look at our constructors](https://youtu.be/j80xaF6Lhk8?t=00h16m13s)



[the issue that we have here is that it's](https://youtu.be/j80xaF6Lhk8?t=00h16m17s)



[saying if you invoke this constructor](https://youtu.be/j80xaF6Lhk8?t=00h16m21s)



[you've told me argument type is not](https://youtu.be/j80xaF6Lhk8?t=00h16m23s)



[knowable but you haven't given it a](https://youtu.be/j80xaF6Lhk8?t=00h16m24s)



[value therefore the default will be null](https://youtu.be/j80xaF6Lhk8?t=00h16m26s)



[which is probably wrong and I'm trying](https://youtu.be/j80xaF6Lhk8?t=00h16m29s)



[to decide if we can just get away with](https://youtu.be/j80xaF6Lhk8?t=00h16m35s)



[something like type dot missing is that](https://youtu.be/j80xaF6Lhk8?t=00h16m37s)



[what are you why are you declare this](https://youtu.be/j80xaF6Lhk8?t=00h16m41s)



[object yuck](https://youtu.be/j80xaF6Lhk8?t=00h16m44s)



[so that ain't gonna fly](https://youtu.be/j80xaF6Lhk8?t=00h16m50s)



[so let's let's think about this guy here](https://youtu.be/j80xaF6Lhk8?t=00h16m56s)



[so if argument type isn't specified I'm](https://youtu.be/j80xaF6Lhk8?t=00h16m59s)



[sort of wondering if something like](https://youtu.be/j80xaF6Lhk8?t=00h17m02s)



[maybe type of void is what's expected](https://youtu.be/j80xaF6Lhk8?t=00h17m03s)



[here right and this is only mostly good](https://youtu.be/j80xaF6Lhk8?t=00h17m06s)



[because you can see that it's still](https://youtu.be/j80xaF6Lhk8?t=00h17m09s)



[whining about this set right because](https://youtu.be/j80xaF6Lhk8?t=00h17m10s)



[even though I have now set it I've taken](https://youtu.be/j80xaF6Lhk8?t=00h17m13s)



[care of that problem it's still possible](https://youtu.be/j80xaF6Lhk8?t=00h17m16s)



[for somebody to call this property and](https://youtu.be/j80xaF6Lhk8?t=00h17m18s)



[set a non no value into it which is](https://youtu.be/j80xaF6Lhk8?t=00h17m19s)



[yucky this guy no it can't be made](https://youtu.be/j80xaF6Lhk8?t=00h17m22s)



[private bad resharper kind of thinking](https://youtu.be/j80xaF6Lhk8?t=00h17m27s)



[I'm kind of thinking we lead with that](https://youtu.be/j80xaF6Lhk8?t=00h17m33s)



[and just see how it goes because there](https://youtu.be/j80xaF6Lhk8?t=00h17m34s)



[is a argument generic class so if we](https://youtu.be/j80xaF6Lhk8?t=00h17m38s)



[take a look at that guy real quick so](https://youtu.be/j80xaF6Lhk8?t=00h17m41s)



[argument of T right and his whole thing](https://youtu.be/j80xaF6Lhk8?t=00h17m44s)



[is he sets the argument type to be T so](https://youtu.be/j80xaF6Lhk8?t=00h17m47s)



[that that gets set appropriately so](https://youtu.be/j80xaF6Lhk8?t=00h17m53s)



[there is that kind of this is bothering](https://youtu.be/j80xaF6Lhk8?t=00h17m55s)



[me we've got constructor chaining but](https://youtu.be/j80xaF6Lhk8?t=00h18m01s)



[the Constructors aren't what I would](https://youtu.be/j80xaF6Lhk8?t=00h18m04s)



[deem order right ding-ding-ding so or](https://youtu.be/j80xaF6Lhk8?t=00h18m06s)



[something there abouts so what is your](https://youtu.be/j80xaF6Lhk8?t=00h18m09s)



[problem here constructor to be me](https://youtu.be/j80xaF6Lhk8?t=00h18m11s)



[private know don't care don't care okay](https://youtu.be/j80xaF6Lhk8?t=00h18m14s)



[so we're gonna lead with that I think](https://youtu.be/j80xaF6Lhk8?t=00h18m17s)



[and let this guy default to void we'll](https://youtu.be/j80xaF6Lhk8?t=00h18m19s)



[probably end up having to deal with that](https://youtu.be/j80xaF6Lhk8?t=00h18m22s)



[setter at some point but oh well we'll](https://youtu.be/j80xaF6Lhk8?t=00h18m25s)



[come back around to that okay so here we](https://youtu.be/j80xaF6Lhk8?t=00h18m29s)



[go here so parent here can be null okay](https://youtu.be/j80xaF6Lhk8?t=00h18m33s)



[so what are we looking at we've got an](https://youtu.be/j80xaF6Lhk8?t=00h18m38s)



[argument result which is used when](https://youtu.be/j80xaF6Lhk8?t=00h18m40s)



[parsing arguments right and the parent](https://youtu.be/j80xaF6Lhk8?t=00h18m43s)



[comes in and parent result is knowable](https://youtu.be/j80xaF6Lhk8?t=00h18m50s)



[and then we call validate so the](https://youtu.be/j80xaF6Lhk8?t=00h18m53s)



[question is should this guy be taking in](https://youtu.be/j80xaF6Lhk8?t=00h18m57s)



[a noble value and so let's look and see](https://youtu.be/j80xaF6Lhk8?t=00h18m59s)



[how is this used so there's a switch](https://youtu.be/j80xaF6Lhk8?t=00h19m03s)



[here](https://youtu.be/j80xaF6Lhk8?t=00h19m05s)



[where it might do some work and then](https://youtu.be/j80xaF6Lhk8?t=00h19m07s)



[that would end it up gets getting set](https://youtu.be/j80xaF6Lhk8?t=00h19m12s)



[here so this guy clearly is set up this](https://youtu.be/j80xaF6Lhk8?t=00h19m14s)



[argument result is clearly set to handle](https://youtu.be/j80xaF6Lhk8?t=00h19m18s)



[a null the problem is is this method](https://youtu.be/j80xaF6Lhk8?t=00h19m20s)



[returns the knowable value this returns](https://youtu.be/j80xaF6Lhk8?t=00h19m23s)



[a notable value I'm kind of wondering if](https://youtu.be/j80xaF6Lhk8?t=00h19m26s)



[this should just be knowable because if](https://youtu.be/j80xaF6Lhk8?t=00h19m29s)



[a null comes into here this guy will](https://youtu.be/j80xaF6Lhk8?t=00h19m31s)



[clearly handle it I think that's the](https://youtu.be/j80xaF6Lhk8?t=00h19m33s)



[appropriate fix all right so now that](https://youtu.be/j80xaF6Lhk8?t=00h19m36s)



[guy stops whining that goes away next](https://youtu.be/j80xaF6Lhk8?t=00h19m41s)



[one down we now have this problem here](https://youtu.be/j80xaF6Lhk8?t=00h19m44s)



[right is okay if no comes in so can it](https://youtu.be/j80xaF6Lhk8?t=00h19m46s)



[be no though so the answer John I think](https://youtu.be/j80xaF6Lhk8?t=00h19m51s)



[is comes with this parent because I](https://youtu.be/j80xaF6Lhk8?t=00h19m53s)



[believe on this guy here if I remember](https://youtu.be/j80xaF6Lhk8?t=00h19m56s)



[correctly there is a code path where we](https://youtu.be/j80xaF6Lhk8?t=00h20m00s)



[pass in a null and I think the only time](https://youtu.be/j80xaF6Lhk8?t=00h20m02s)



[parent is null if it's at the root which](https://youtu.be/j80xaF6Lhk8?t=00h20m08s)



[I assume would be a command result](https://youtu.be/j80xaF6Lhk8?t=00h20m15s)



[rather than a symbol result so sorry let](https://youtu.be/j80xaF6Lhk8?t=00h20m18s)



[me let me find my way through this real](https://youtu.be/j80xaF6Lhk8?t=00h20m21s)



[quick because I believe there was a path](https://youtu.be/j80xaF6Lhk8?t=00h20m24s)



[through where no was very explicitly](https://youtu.be/j80xaF6Lhk8?t=00h20m26s)



[yeah so command result here right parent](https://youtu.be/j80xaF6Lhk8?t=00h20m28s)



[comes in and can be null and so so the](https://youtu.be/j80xaF6Lhk8?t=00h20m32s)



[answer is I've at least got one code](https://youtu.be/j80xaF6Lhk8?t=00h20m41s)



[path where I can get into here and be](https://youtu.be/j80xaF6Lhk8?t=00h20m43s)



[null can I get to here in that case that](https://youtu.be/j80xaF6Lhk8?t=00h20m44s)



[is a fair question because argument](https://youtu.be/j80xaF6Lhk8?t=00h20m51s)



[conversion results I think the answer is](https://youtu.be/j80xaF6Lhk8?t=00h20m54s)



[yes because inside of the command result](https://youtu.be/j80xaF6Lhk8?t=00h20m59s)



[if we call argument conversion results I](https://youtu.be/j80xaF6Lhk8?t=00h21m01s)



[think this is possible is it possible](https://youtu.be/j80xaF6Lhk8?t=00h21m05s)



[for the children if we're iterating over](https://youtu.be/j80xaF6Lhk8?t=00h21m08s)



[the children their parents should be](https://youtu.be/j80xaF6Lhk8?t=00h21m12s)



[this right so that shouldn't actually be](https://youtu.be/j80xaF6Lhk8?t=00h21m14s)



[possible](https://youtu.be/j80xaF6Lhk8?t=00h21m17s)



[let's see here argument conversion](https://youtu.be/j80xaF6Lhk8?t=00h21m21s)



[result this guy is expected to get](https://youtu.be/j80xaF6Lhk8?t=00h21m27s)



[always give one back which I think it's](https://youtu.be/j80xaF6Lhk8?t=00h21m30s)



[fair so I don't think that's a problem](https://youtu.be/j80xaF6Lhk8?t=00h21m32s)



[you know you make a good point if all so](https://youtu.be/j80xaF6Lhk8?t=00h21m38s)



[the only two cases that we have here are](https://youtu.be/j80xaF6Lhk8?t=00h21m42s)



[our option and command result and they](https://youtu.be/j80xaF6Lhk8?t=00h21m44s)



[always iterate over their children and I](https://youtu.be/j80xaF6Lhk8?t=00h21m47s)



[assume if you're iterating over your](https://youtu.be/j80xaF6Lhk8?t=00h21m49s)



[children parent must be set for this I](https://youtu.be/j80xaF6Lhk8?t=00h21m50s)



[like to fire up a live unit testing your](https://youtu.be/j80xaF6Lhk8?t=00h21m55s)



[and crunch at an if block and and let](https://youtu.be/j80xaF6Lhk8?t=00h21m57s)



[the tests tell me well you make a fair](https://youtu.be/j80xaF6Lhk8?t=00h22m00s)



[point so I don't have those but I do](https://youtu.be/j80xaF6Lhk8?t=00h22m04s)



[have live unit testing so we can fire up](https://youtu.be/j80xaF6Lhk8?t=00h22m09s)



[live unit testing and and some of these](https://youtu.be/j80xaF6Lhk8?t=00h22m15s)



[classes because they're internal I think](https://youtu.be/j80xaF6Lhk8?t=00h22m23s)



[there's gonna be plenty of cases where](https://youtu.be/j80xaF6Lhk8?t=00h22m26s)



[we can make certain assumptions oh right](https://youtu.be/j80xaF6Lhk8?t=00h22m27s)



[unit testing doesn't work if you unload](https://youtu.be/j80xaF6Lhk8?t=00h22m30s)



[the unit testing project so let's see](https://youtu.be/j80xaF6Lhk8?t=00h22m34s)



[system command-line tests we'll reload](https://youtu.be/j80xaF6Lhk8?t=00h22m38s)



[this one](https://youtu.be/j80xaF6Lhk8?t=00h22m40s)



[to do now is live unit testing hip](https://youtu.be/j80xaF6Lhk8?t=00h22m45s)



[enough to that idea or is it gonna make](https://youtu.be/j80xaF6Lhk8?t=00h22m47s)



[me stop and reload it building one](https://youtu.be/j80xaF6Lhk8?t=00h22m50s)



[projects I think it's hip enough to it](https://youtu.be/j80xaF6Lhk8?t=00h22m53s)



[do a test build completed with failures](https://youtu.be/j80xaF6Lhk8?t=00h23m01s)



[well that doesn't sound good okay so I'm](https://youtu.be/j80xaF6Lhk8?t=00h23m07s)



[gonna stop this real quick and I'm just](https://youtu.be/j80xaF6Lhk8?t=00h23m10s)



[gonna build it myself and see if there's](https://youtu.be/j80xaF6Lhk8?t=00h23m12s)



[failures because I've been working with](https://youtu.be/j80xaF6Lhk8?t=00h23m13s)



[them all unloaded so there's a very real](https://youtu.be/j80xaF6Lhk8?t=00h23m15s)



[chance that I've broken something](https://youtu.be/j80xaF6Lhk8?t=00h23m17s)



[let's go with just the heirs for the](https://youtu.be/j80xaF6Lhk8?t=00h23m22s)



[moment project Buddha wada oh I broke it](https://youtu.be/j80xaF6Lhk8?t=00h23m24s)



[because i revved the core project to net](https://youtu.be/j80xaF6Lhk8?t=00h23m36s)



[standard two one this is fun project](https://youtu.be/j80xaF6Lhk8?t=00h23m40s)



[command-line is not compatible with net](https://youtu.be/j80xaF6Lhk8?t=00h23m49s)



[so I'm I'm confused where it's oh it's](https://youtu.be/j80xaF6Lhk8?t=00h23m51s)



[getting it right here okay so we're](https://youtu.be/j80xaF6Lhk8?t=00h23m55s)



[gonna I assume John if we are able to](https://youtu.be/j80xaF6Lhk8?t=00h24m03s)



[rev this to net standard two one](https://youtu.be/j80xaF6Lhk8?t=00h24m06s)



[I'm okay to rev the dotnet framework](https://youtu.be/j80xaF6Lhk8?t=00h24m08s)



[version two question net standard](https://youtu.be/j80xaF6Lhk8?t=00h24m09s)



[[Music]](https://youtu.be/j80xaF6Lhk8?t=00h24m16s)



[there's a nice chart out on github might](https://youtu.be/j80xaF6Lhk8?t=00h24m18s)



[even be in the docs page where it shows](https://youtu.be/j80xaF6Lhk8?t=00h24m22s)



[the overlap right this is what I want so](https://youtu.be/j80xaF6Lhk8?t=00h24m23s)



[2 1 maps to Oh John oh oh we have](https://youtu.be/j80xaF6Lhk8?t=00h24m27s)



[problem there is no net framework yeah](https://youtu.be/j80xaF6Lhk8?t=00h24m35s)



[that is a bit of a problem okay so and](https://youtu.be/j80xaF6Lhk8?t=00h24m43s)



[David I don't know if you've done any of](https://youtu.be/j80xaF6Lhk8?t=00h24m47s)



[this work yourself but so now here's](https://youtu.be/j80xaF6Lhk8?t=00h24m50s)



[here's the question right right the the](https://youtu.be/j80xaF6Lhk8?t=00h24m51s)



[the test projects are net core app three](https://youtu.be/j80xaF6Lhk8?t=00h24m58s)



[one already John the issue is when doing](https://youtu.be/j80xaF6Lhk8?t=00h25m01s)



[this windows thing it's tacking on net](https://youtu.be/j80xaF6Lhk8?t=00h25m04s)



[four six two right so the only reason](https://youtu.be/j80xaF6Lhk8?t=00h25m06s)



[why we have these things](https://youtu.be/j80xaF6Lhk8?t=00h25m11s)



[is because for example why is this on my](https://youtu.be/j80xaF6Lhk8?t=00h25m13s)



[other monitor bring this over so already](https://youtu.be/j80xaF6Lhk8?t=00h25m16s)



[not nolwenn right so there's a bunch of](https://youtu.be/j80xaF6Lhk8?t=00h25m18s)



[attributes that you can use with](https://youtu.be/j80xaF6Lhk8?t=00h25m22s)



[knowable reference types for example](https://youtu.be/j80xaF6Lhk8?t=00h25m26s)



[this is effectively a tryparse method](https://youtu.be/j80xaF6Lhk8?t=00h25m28s)



[right so the out variable is declared as](https://youtu.be/j80xaF6Lhk8?t=00h25m30s)



[knowable but we know that this guy is](https://youtu.be/j80xaF6Lhk8?t=00h25m33s)



[not going to be null when we return true](https://youtu.be/j80xaF6Lhk8?t=00h25m40s)



[right because it's a tryparse](https://youtu.be/j80xaF6Lhk8?t=00h25m43s)



[effectively so the question then is if](https://youtu.be/j80xaF6Lhk8?t=00h25m45s)



[you want to put these attributes in they](https://youtu.be/j80xaF6Lhk8?t=00h25m48s)



[don't exist inside of the library if you](https://youtu.be/j80xaF6Lhk8?t=00h25m51s)



[are targeting 4-6-2 so i can cheat and i](https://youtu.be/j80xaF6Lhk8?t=00h25m55s)



[will show you what i did elsewhere and](https://youtu.be/j80xaF6Lhk8?t=00h26m00s)



[please know and throw things at me](https://youtu.be/j80xaF6Lhk8?t=00h26m04s)



[so for auto mocker what we ended up](https://youtu.be/j80xaF6Lhk8?t=00h26m07s)



[doing is the the compiler doesn't](https://youtu.be/j80xaF6Lhk8?t=00h26m10s)



[actually care where the the assembly of](https://youtu.be/j80xaF6Lhk8?t=00h26m14s)



[the attributes right it's just looking](https://youtu.be/j80xaF6Lhk8?t=00h26m19s)



[for an attribute that matches a fully](https://youtu.be/j80xaF6Lhk8?t=00h26m20s)



[qualified name that has a particular](https://youtu.be/j80xaF6Lhk8?t=00h26m22s)



[signature so we could bring these guys](https://youtu.be/j80xaF6Lhk8?t=00h26m23s)



[in which is what we did on auto marker](https://youtu.be/j80xaF6Lhk8?t=00h26m27s)



[to support older frameworks and then](https://youtu.be/j80xaF6Lhk8?t=00h26m30s)



[reference reference them that way I](https://youtu.be/j80xaF6Lhk8?t=00h26m33s)



[think in the interest of getting this](https://youtu.be/j80xaF6Lhk8?t=00h26m38s)



[working without making a decision now](https://youtu.be/j80xaF6Lhk8?t=00h26m41s)



[John](https://youtu.be/j80xaF6Lhk8?t=00h26m43s)



[the answer is I just turned off net 462](https://youtu.be/j80xaF6Lhk8?t=00h26m43s)



[and carry on my merry way and we deal](https://youtu.be/j80xaF6Lhk8?t=00h26m46s)



[with framework versions at a at a later](https://youtu.be/j80xaF6Lhk8?t=00h26m48s)



[point I think that's my answer in the](https://youtu.be/j80xaF6Lhk8?t=00h26m52s)



[interest of not getting hung up on](https://youtu.be/j80xaF6Lhk8?t=00h26m56s)



[little things like compiling right so we](https://youtu.be/j80xaF6Lhk8?t=00h26m57s)



[because that'll show up in a diff and be](https://youtu.be/j80xaF6Lhk8?t=00h27m01s)



[pretty obviously a not a good change I](https://youtu.be/j80xaF6Lhk8?t=00h27m04s)



[hope](https://youtu.be/j80xaF6Lhk8?t=00h27m06s)



[so let's compile that guy so again we](https://youtu.be/j80xaF6Lhk8?t=00h27m10s)



[could bring those attributes in we could](https://youtu.be/j80xaF6Lhk8?t=00h27m14s)



[pound them for target framework 4 6 2 or](https://youtu.be/j80xaF6Lhk8?t=00h27m16s)



[something like the question is is how do](https://youtu.be/j80xaF6Lhk8?t=00h27m19s)



[we want to handle it because I think to](https://youtu.be/j80xaF6Lhk8?t=00h27m23s)



[properly annotate knowable reference](https://youtu.be/j80xaF6Lhk8?t=00h27m25s)



[types you really need them on any](https://youtu.be/j80xaF6Lhk8?t=00h27m27s)



[library that's reasonably complex so I I](https://youtu.be/j80xaF6Lhk8?t=00h27m29s)



[kind of think we we need them and so the](https://youtu.be/j80xaF6Lhk8?t=00h27m34s)



[question is how to handle it because I](https://youtu.be/j80xaF6Lhk8?t=00h27m37s)



[don't think this library should](https://youtu.be/j80xaF6Lhk8?t=00h27m40s)



[necessarily drop support for older](https://youtu.be/j80xaF6Lhk8?t=00h27m41s)



[frameworks there's enough people still](https://youtu.be/j80xaF6Lhk8?t=00h27m44s)



[compiling for dotnet framework myself](https://youtu.be/j80xaF6Lhk8?t=00h27m46s)



[included oh good I only broke a couple](https://youtu.be/j80xaF6Lhk8?t=00h27m48s)



[things so now you're gonna make me get](https://youtu.be/j80xaF6Lhk8?t=00h27m51s)



[confused typo correction apparently I](https://youtu.be/j80xaF6Lhk8?t=00h27m54s)



[broke something oh I probably changed](https://youtu.be/j80xaF6Lhk8?t=00h28m00s)



[behavior expected string empty string to](https://youtu.be/j80xaF6Lhk8?t=00h28m02s)



[contain quote quote Yin but was not](https://youtu.be/j80xaF6Lhk8?t=00h28m09s)



[matched did you mean it well](https://youtu.be/j80xaF6Lhk8?t=00h28m13s)



[should contain this turns out does not](https://youtu.be/j80xaF6Lhk8?t=00h28m22s)



[contain that it came back with an empty](https://youtu.be/j80xaF6Lhk8?t=00h28m28s)



[string so I think this is actually in](https://youtu.be/j80xaF6Lhk8?t=00h28m31s)



[the let's go and fix this real quick](https://youtu.be/j80xaF6Lhk8?t=00h28m35s)



[because it probably should have had](https://youtu.be/j80xaF6Lhk8?t=00h28m40s)



[these on the whole time to make sure as](https://youtu.be/j80xaF6Lhk8?t=00h28m42s)



[I was making changes I wasn't breaking](https://youtu.be/j80xaF6Lhk8?t=00h28m43s)



[things but it's so much easier to just](https://youtu.be/j80xaF6Lhk8?t=00h28m45s)



[unload stuff](https://youtu.be/j80xaF6Lhk8?t=00h28m47s)



[so David adding your own attributes for](https://youtu.be/j80xaF6Lhk8?t=00h28m55s)



[knowable stuff if you're targeting](https://youtu.be/j80xaF6Lhk8?t=00h28m58s)



[dotnet framework seems to be pretty](https://youtu.be/j80xaF6Lhk8?t=00h28m59s)



[standard and then a wonderful link let's](https://youtu.be/j80xaF6Lhk8?t=00h29m01s)



[just take a look at this](https://youtu.be/j80xaF6Lhk8?t=00h29m04s)



[Visual Studio project system yeah and I](https://youtu.be/j80xaF6Lhk8?t=00h29m06s)



[think I actually stole the file that I](https://youtu.be/j80xaF6Lhk8?t=00h29m09s)



[used on Auto mocker from one of these](https://youtu.be/j80xaF6Lhk8?t=00h29m12s)



[Microsoft projects where I saw somebody](https://youtu.be/j80xaF6Lhk8?t=00h29m15s)



[else adding it I can't claim to be the](https://youtu.be/j80xaF6Lhk8?t=00h29m17s)



[one who came up with the idea I saw it](https://youtu.be/j80xaF6Lhk8?t=00h29m20s)



[and was like oh that's how you do it](https://youtu.be/j80xaF6Lhk8?t=00h29m23s)



[perfect and then I didn't move on it](https://youtu.be/j80xaF6Lhk8?t=00h29m25s)



[actually surprised me that there's not](https://youtu.be/j80xaF6Lhk8?t=00h29m27s)



[an official Microsoft nougat package](https://youtu.be/j80xaF6Lhk8?t=00h29m29s)



[with these things in here to shim it in](https://youtu.be/j80xaF6Lhk8?t=00h29m31s)



[there's at least one unofficial package](https://youtu.be/j80xaF6Lhk8?t=00h29m33s)



[I saw where it looked like some somebody](https://youtu.be/j80xaF6Lhk8?t=00h29m37s)



[had just wrapped these things up I don't](https://youtu.be/j80xaF6Lhk8?t=00h29m38s)



[know it doesn't seem like something I](https://youtu.be/j80xaF6Lhk8?t=00h29m44s)



[would pull in a nougat dependency for](https://youtu.be/j80xaF6Lhk8?t=00h29m45s)



[for a single one-liner file especially](https://youtu.be/j80xaF6Lhk8?t=00h29m47s)



[for code that's never executed framework](https://youtu.be/j80xaF6Lhk8?t=00h29m49s)



[standard love it John loved it](https://youtu.be/j80xaF6Lhk8?t=00h29m55s)



[okay so come in here come in here so](https://youtu.be/j80xaF6Lhk8?t=00h30m01s)



[this is provide no we didn't fall into](https://youtu.be/j80xaF6Lhk8?t=00h30m07s)



[this case why why why why why why so](https://youtu.be/j80xaF6Lhk8?t=00h30m10s)



[this uses typo correction and I think](https://youtu.be/j80xaF6Lhk8?t=00h30m16s)



[we're right here right because we know](https://youtu.be/j80xaF6Lhk8?t=00h30m18s)



[that the unit test failed in here](https://youtu.be/j80xaF6Lhk8?t=00h30m21s)



[because if it provided suggestions we](https://youtu.be/j80xaF6Lhk8?t=00h30m25s)



[would have gotten something and not](https://youtu.be/j80xaF6Lhk8?t=00h30m28s)



[necessarily empty strings so hey come](https://youtu.be/j80xaF6Lhk8?t=00h30m29s)



[here](https://youtu.be/j80xaF6Lhk8?t=00h30m34s)



[you debug test let's just step through](https://youtu.be/j80xaF6Lhk8?t=00h30m35s)



[this guy real quick since it's only one](https://youtu.be/j80xaF6Lhk8?t=00h30m41s)



[failing test how long could it possibly](https://youtu.be/j80xaF6Lhk8?t=00h30m43s)



[take](https://youtu.be/j80xaF6Lhk8?t=00h30m44s)



[famous last words I all of this started](https://youtu.be/j80xaF6Lhk8?t=00h30m46s)



[because I went to play with a an idea I](https://youtu.be/j80xaF6Lhk8?t=00h30m48s)



[had for cleaning up and making dragon](https://youtu.be/j80xaF6Lhk8?t=00h30m53s)



[fruit a little more powerful and then I](https://youtu.be/j80xaF6Lhk8?t=00h30m55s)



[got blocked by a bug and then there was](https://youtu.be/j80xaF6Lhk8?t=00h30m58s)



[Noble reference types and then just one](https://youtu.be/j80xaF6Lhk8?t=00h31m00s)



[thing led to another and I just kept](https://youtu.be/j80xaF6Lhk8?t=00h31m01s)



[going](https://youtu.be/j80xaF6Lhk8?t=00h31m03s)



[ok so unmatched tokens there are none](https://youtu.be/j80xaF6Lhk8?t=00h31m04s)



[and treat unmatched tokens as heirs](https://youtu.be/j80xaF6Lhk8?t=00h31m09s)



[so that is true which is what we expect](https://youtu.be/j80xaF6Lhk8?t=00h31m20s)



[but there are no unmatched tokens which](https://youtu.be/j80xaF6Lhk8?t=00h31m23s)



[is a little shocking to me and it picked](https://youtu.be/j80xaF6Lhk8?t=00h31m25s)



[up EE raw input was een I don't think](https://youtu.be/j80xaF6Lhk8?t=00h31m28s)



[that matches let's go back where is my](https://youtu.be/j80xaF6Lhk8?t=00h31m32s)



[test where's my test window already lost](https://youtu.be/j80xaF6Lhk8?t=00h31m38s)



[team Explorer](https://youtu.be/j80xaF6Lhk8?t=00h31m42s)



[going where](https://youtu.be/j80xaF6Lhk8?t=00h31m44s)



[sounds like a worthy yak to shave yes it](https://youtu.be/j80xaF6Lhk8?t=00h31m50s)



[yes it is let's see here](https://youtu.be/j80xaF6Lhk8?t=00h31m54s)



[where's my coming come on I know video](https://youtu.be/j80xaF6Lhk8?t=00h31m59s)



[studio it is hard to do it test](https://youtu.be/j80xaF6Lhk8?t=00h32m04s)



[I just want my tests explore let's see](https://youtu.be/j80xaF6Lhk8?t=00h32m07s)



[palm as I launched that from resharper](https://youtu.be/j80xaF6Lhk8?t=00h32m11s)



[and I don't see it down here probably](https://youtu.be/j80xaF6Lhk8?t=00h32m15s)



[means I'm here right this unit tests](https://youtu.be/j80xaF6Lhk8?t=00h32m18s)



[think that one oh that's why it is](https://youtu.be/j80xaF6Lhk8?t=00h32m24s)



[hanging out on other windows lovely this](https://youtu.be/j80xaF6Lhk8?t=00h32m28s)



[one there's the guy I'm looking for unit](https://youtu.be/j80xaF6Lhk8?t=00h32m33s)



[let's go there okay so all that just](https://youtu.be/j80xaF6Lhk8?t=00h32m39s)



[because I wanted to get back here so](https://youtu.be/j80xaF6Lhk8?t=00h32m42s)



[parse that that guy came through there](https://youtu.be/j80xaF6Lhk8?t=00h32m44s)



[shove me back](https://youtu.be/j80xaF6Lhk8?t=00h32m48s)



[so the parse result what did you](https://youtu.be/j80xaF6Lhk8?t=00h32m50s)



[confused why argument](https://youtu.be/j80xaF6Lhk8?t=00h32m55s)



[why was that able to match I'm wondering](https://youtu.be/j80xaF6Lhk8?t=00h33m02s)



[if that argument typed that we just](https://youtu.be/j80xaF6Lhk8?t=00h33m06s)



[changed is now affecting the behavior](https://youtu.be/j80xaF6Lhk8?t=00h33m07s)



[that is interesting okay so clearly the](https://youtu.be/j80xaF6Lhk8?t=00h33m12s)



[bug starts here in the parsing so we're](https://youtu.be/j80xaF6Lhk8?t=00h33m23s)



[gonna just jump to their test Explorer](https://youtu.be/j80xaF6Lhk8?t=00h33m26s)



[you stay pinned live unit testing you go](https://youtu.be/j80xaF6Lhk8?t=00h33m30s)



[away for a minute I don't want to think](https://youtu.be/j80xaF6Lhk8?t=00h33m33s)



[about you too much not that one why why](https://youtu.be/j80xaF6Lhk8?t=00h33m35s)



[at some point in time if anybody has a](https://youtu.be/j80xaF6Lhk8?t=00h33m41s)



[lovely extension that will keep your](https://youtu.be/j80xaF6Lhk8?t=00h33m44s)



[window layout the same between debug and](https://youtu.be/j80xaF6Lhk8?t=00h33m46s)



[not debug modes I would love it that is](https://youtu.be/j80xaF6Lhk8?t=00h33m49s)



[I understand it's kind of nice to](https://youtu.be/j80xaF6Lhk8?t=00h33m53s)



[sometimes having different layouts for](https://youtu.be/j80xaF6Lhk8?t=00h33m56s)



[when you're debugging versus not but](https://youtu.be/j80xaF6Lhk8?t=00h33m57s)



[more often than not I find myself just](https://youtu.be/j80xaF6Lhk8?t=00h33m59s)



[wanting the same window layout](https://youtu.be/j80xaF6Lhk8?t=00h34m02s)



[regardless whether I'm debugging or](https://youtu.be/j80xaF6Lhk8?t=00h34m04s)



[editing I don't want my window layout to](https://youtu.be/j80xaF6Lhk8?t=00h34m06s)



[change on me okay so same result there](https://youtu.be/j80xaF6Lhk8?t=00h34m08s)



[no unmatched tokens okay so let's go run](https://youtu.be/j80xaF6Lhk8?t=00h34m12s)



[it back and see where it goes so no](https://youtu.be/j80xaF6Lhk8?t=00h34m19s)



[shocker there one item in the collection](https://youtu.be/j80xaF6Lhk8?t=00h34m24s)



[tokenize take a look what is in our](https://youtu.be/j80xaF6Lhk8?t=00h34m28s)



[tokenize we've got two tokens we've got](https://youtu.be/j80xaF6Lhk8?t=00h34m33s)



[an implicit command for the executable](https://youtu.be/j80xaF6Lhk8?t=00h34m36s)



[and then an argument hey](https://youtu.be/j80xaF6Lhk8?t=00h34m39s)



[let's take a look here parse operation](https://youtu.be/j80xaF6Lhk8?t=00h34m45s)



[great execute the parse parse route](https://youtu.be/j80xaF6Lhk8?t=00h34m49s)



[command](https://youtu.be/j80xaF6Lhk8?t=00h34m52s)



[[Music]](https://youtu.be/j80xaF6Lhk8?t=00h34m54s)



[touken command there's the example of](https://youtu.be/j80xaF6Lhk8?t=00h34m58s)



[the null parent if you care John so](https://youtu.be/j80xaF6Lhk8?t=00h35m03s)



[there's up](https://youtu.be/j80xaF6Lhk8?t=00h35m06s)



[Vance harsh directives I think we can](https://youtu.be/j80xaF6Lhk8?t=00h35m10s)



[skip this parse command children I](https://youtu.be/j80xaF6Lhk8?t=00h35m13s)



[expect it to be in here so while more I](https://youtu.be/j80xaF6Lhk8?t=00h35m15s)



[expect to be true not at the end and](https://youtu.be/j80xaF6Lhk8?t=00h35m18s)



[parse option parse command](https://youtu.be/j80xaF6Lhk8?t=00h35m25s)



[child](https://youtu.be/j80xaF6Lhk8?t=00h35m32s)



[is null so this guy here actually was](https://youtu.be/j80xaF6Lhk8?t=00h35m36s)



[able to parse when it probably shouldn't](https://youtu.be/j80xaF6Lhk8?t=00h35m42s)



[have I'm probably gonna get in a bit of](https://youtu.be/j80xaF6Lhk8?t=00h35m44s)



[a pickle if I reset myself in my yeah](https://youtu.be/j80xaF6Lhk8?t=00h35m47s)



[cuz this guy calls advanced okay well](https://youtu.be/j80xaF6Lhk8?t=00h35m50s)



[let's back up and try this again](https://youtu.be/j80xaF6Lhk8?t=00h35m55s)



[somewhere in here this broke our](https://youtu.be/j80xaF6Lhk8?t=00h36m01s)



[sub-command past parse command argument](https://youtu.be/j80xaF6Lhk8?t=00h36m05s)



[I assume this is the guy that's now](https://youtu.be/j80xaF6Lhk8?t=00h36m08s)



[processing that I don't expect so parse](https://youtu.be/j80xaF6Lhk8?t=00h36m12s)



[sub-command I expect this guy to return](https://youtu.be/j80xaF6Lhk8?t=00h36m14s)



[y'all yeah okay that makes sense](https://youtu.be/j80xaF6Lhk8?t=00h36m16s)



[parse option this is not an option I](https://youtu.be/j80xaF6Lhk8?t=00h36m19s)



[expect return all great okay parse](https://youtu.be/j80xaF6Lhk8?t=00h36m21s)



[command argument this is where it is](https://youtu.be/j80xaF6Lhk8?t=00h36m24s)



[passing communit I Piz argument so it](https://youtu.be/j80xaF6Lhk8?t=00h36m26s)



[falls into here but why does this guy](https://youtu.be/j80xaF6Lhk8?t=00h36m30s)



[why does this command have well let's](https://youtu.be/j80xaF6Lhk8?t=00h36m35s)



[just check this command has an argument](https://youtu.be/j80xaF6Lhk8?t=00h36m40s)



[right with argument wait I'm confused](https://youtu.be/j80xaF6Lhk8?t=00h36m43s)



[what is type argument okay](https://youtu.be/j80xaF6Lhk8?t=00h36m50s)



[first or default of this guy so it's an](https://youtu.be/j80xaF6Lhk8?t=00h37m01s)



[AI argument and a knot is full what is](https://youtu.be/j80xaF6Lhk8?t=00h37m06s)



[is full doing checks the argument](https://youtu.be/j80xaF6Lhk8?t=00h37m11s)



[argument counts try gets the argument](https://youtu.be/j80xaF6Lhk8?t=00h37m13s)



[out of there based on the maximum number](https://youtu.be/j80xaF6Lhk8?t=00h37m17s)



[so what is the arity then I guess of my](https://youtu.be/j80xaF6Lhk8?t=00h37m21s)



[argument so maximum let's see arity](https://youtu.be/j80xaF6Lhk8?t=00h37m23s)



[maximum number values minimum number](https://youtu.be/j80xaF6Lhk8?t=00h37m32s)



[values is one that doesn't seem right](https://youtu.be/j80xaF6Lhk8?t=00h37m34s)



[alright the default route command is](https://youtu.be/j80xaF6Lhk8?t=00h37m45s)



[what this guy is generating alright](https://youtu.be/j80xaF6Lhk8?t=00h37m48s)



[command line nope](https://youtu.be/j80xaF6Lhk8?t=00h37m52s)



[add argument here this guy comes in](https://youtu.be/j80xaF6Lhk8?t=00h37m54s)



[here's where the arity is getting set](https://youtu.be/j80xaF6Lhk8?t=00h38m01s)



[I am](https://youtu.be/j80xaF6Lhk8?t=00h38m10s)



[not on a percent confident here so if](https://youtu.be/j80xaF6Lhk8?t=00h38m15s)



[arity is null oh this is what we chim](https://youtu.be/j80xaF6Lhk8?t=00h38m18s)



[this guy here is the break right okay so](https://youtu.be/j80xaF6Lhk8?t=00h38m24s)



[alright let's take this off and just](https://youtu.be/j80xaF6Lhk8?t=00h38m29s)



[validate real quick because I'm pretty](https://youtu.be/j80xaF6Lhk8?t=00h38m31s)



[sure if I do that it passes I think](https://youtu.be/j80xaF6Lhk8?t=00h38m33s)



[because I'm defaulting the this guy to](https://youtu.be/j80xaF6Lhk8?t=00h38m38s)



[not null and this was checking against](https://youtu.be/j80xaF6Lhk8?t=00h38m41s)



[null okay so this now makes for an](https://youtu.be/j80xaF6Lhk8?t=00h38m43s)



[interesting case because before we](https://youtu.be/j80xaF6Lhk8?t=00h38m46s)



[looked at the usages of this and](https://youtu.be/j80xaF6Lhk8?t=00h38m49s)



[determined at least usages from the](https://youtu.be/j80xaF6Lhk8?t=00h38m50s)



[interface that argument type was largely](https://youtu.be/j80xaF6Lhk8?t=00h38m52s)



[expected to be non null but clearly we](https://youtu.be/j80xaF6Lhk8?t=00h38m56s)



[have a case where null is expected so](https://youtu.be/j80xaF6Lhk8?t=00h39m05s)



[now once again yeah I know I agree with](https://youtu.be/j80xaF6Lhk8?t=00h39m07s)



[you John mutable objects are kind of a](https://youtu.be/j80xaF6Lhk8?t=00h39m13s)



[pain this is part of the reason why](https://youtu.be/j80xaF6Lhk8?t=00h39m15s)



[immutable is so awesome in most cases](https://youtu.be/j80xaF6Lhk8?t=00h39m17s)



[because you don't have to deal with](https://youtu.be/j80xaF6Lhk8?t=00h39m20s)



[these weird state changing things right](https://youtu.be/j80xaF6Lhk8?t=00h39m21s)



[because I think my comment earlier is we](https://youtu.be/j80xaF6Lhk8?t=00h39m25s)



[can set this to void or similar right](https://youtu.be/j80xaF6Lhk8?t=00h39m27s)



[but it doesn't stop somebody from](https://youtu.be/j80xaF6Lhk8?t=00h39m31s)



[setting this in and I'm sort of](https://youtu.be/j80xaF6Lhk8?t=00h39m32s)



[wondering now if this guy here should be](https://youtu.be/j80xaF6Lhk8?t=00h39m35s)



[well let's see maybe maybe the solution](https://youtu.be/j80xaF6Lhk8?t=00h39m41s)



[is this guy here should handle the void](https://youtu.be/j80xaF6Lhk8?t=00h39m44s)



[case right because I'm guessing he](https://youtu.be/j80xaF6Lhk8?t=00h39m47s)



[probably doesn't I kind of like this](https://youtu.be/j80xaF6Lhk8?t=00h39m48s)



[right let's see why do we have all of](https://youtu.be/j80xaF6Lhk8?t=00h39m55s)



[these this is knowable exactly one](https://youtu.be/j80xaF6Lhk8?t=00h39m59s)



[so if type](https://youtu.be/j80xaF6Lhk8?t=00h40m03s)



[return zero](https://youtu.be/j80xaF6Lhk8?t=00h40m13s)



[okay if we do that that lets me put this](https://youtu.be/j80xaF6Lhk8?t=00h40m21s)



[back on I'm gonna put it to do in here](https://youtu.be/j80xaF6Lhk8?t=00h40m25s)



[to do what if null gets set right okay](https://youtu.be/j80xaF6Lhk8?t=00h40m27s)



[live unit testing turn you back on](https://youtu.be/j80xaF6Lhk8?t=00h40m34s)



[now everyone should be happy at least as](https://youtu.be/j80xaF6Lhk8?t=00h40m37s)



[happy as they can be thinking thinking](https://youtu.be/j80xaF6Lhk8?t=00h40m42s)



[thinking okay everyone's happy](https://youtu.be/j80xaF6Lhk8?t=00h40m47s)



[or at least back to mostly being happy](https://youtu.be/j80xaF6Lhk8?t=00h40m50s)



[okay](https://youtu.be/j80xaF6Lhk8?t=00h40m54s)



[that guy probably warrants his own unit](https://youtu.be/j80xaF6Lhk8?t=00h40m55s)



[test by itself](https://youtu.be/j80xaF6Lhk8?t=00h40m58s)



[just to make sure we don't break that](https://youtu.be/j80xaF6Lhk8?t=00h41m00s)



[but back to where we were let's see](https://youtu.be/j80xaF6Lhk8?t=00h41m02s)



[where are my breakpoints where are my](https://youtu.be/j80xaF6Lhk8?t=00h41m09s)



[breakpoints at you come here](https://youtu.be/j80xaF6Lhk8?t=00h41m12s)



[delete oh yeah sure](https://youtu.be/j80xaF6Lhk8?t=00h41m18s)



[that'll be fine okay air list warnings](https://youtu.be/j80xaF6Lhk8?t=00h41m20s)



[back on let's just pick on the next one](https://youtu.be/j80xaF6Lhk8?t=00h41m25s)



[you winner](https://youtu.be/j80xaF6Lhk8?t=00h41m27s)



[air list argument type is uninitialized](https://youtu.be/j80xaF6Lhk8?t=00h41m30s)



[that's no longer true that's no longer](https://youtu.be/j80xaF6Lhk8?t=00h41m32s)



[true next one down okay so no way live](https://youtu.be/j80xaF6Lhk8?t=00h41m34s)



[unit testing turned itself back off I](https://youtu.be/j80xaF6Lhk8?t=00h41m43s)



[must have hit build or similar okay so](https://youtu.be/j80xaF6Lhk8?t=00h41m45s)



[we've got this case here we've got get](https://youtu.be/j80xaF6Lhk8?t=00h41m48s)



[suggestions text to match I initially](https://youtu.be/j80xaF6Lhk8?t=00h41m51s)



[made this parameter knowable because it](https://youtu.be/j80xaF6Lhk8?t=00h41m54s)



[had a default value of no so let's see](https://youtu.be/j80xaF6Lhk8?t=00h41m56s)



[Megan sorry if this is a basic question](https://youtu.be/j80xaF6Lhk8?t=00h42m00s)



[but what is live unit testing does it](https://youtu.be/j80xaF6Lhk8?t=00h42m02s)



[test as you code yeah](https://youtu.be/j80xaF6Lhk8?t=00h42m04s)



[Megan just like David said it so first](https://youtu.be/j80xaF6Lhk8?t=00h42m07s)



[of all I will point out that it is not a](https://youtu.be/j80xaF6Lhk8?t=00h42m11s)



[feature that shows up in the lower](https://youtu.be/j80xaF6Lhk8?t=00h42m13s)



[versions of Visual Studio I think you](https://youtu.be/j80xaF6Lhk8?t=00h42m15s)



[have to have it might even be enterprise](https://youtu.be/j80xaF6Lhk8?t=00h42m17s)



[I don't even know if it's in Pro or not](https://youtu.be/j80xaF6Lhk8?t=00h42m20s)



[but yes you you turn it on and it will](https://youtu.be/j80xaF6Lhk8?t=00h42m23s)



[intelligently try and keep track of what](https://youtu.be/j80xaF6Lhk8?t=00h42m26s)



[you're editing and rerun the relevant](https://youtu.be/j80xaF6Lhk8?t=00h42m29s)



[tests as you make changes more](https://youtu.be/j80xaF6Lhk8?t=00h42m31s)



[importantly it gives you this](https://youtu.be/j80xaF6Lhk8?t=00h42m33s)



[nice little green check when it runs a](https://youtu.be/j80xaF6Lhk8?t=00h42m35s)



[test that passes or red Xs if it fails](https://youtu.be/j80xaF6Lhk8?t=00h42m38s)



[so sometimes you can just follow the](https://youtu.be/j80xaF6Lhk8?t=00h42m41s)



[follow the colorful pictures and figure](https://youtu.be/j80xaF6Lhk8?t=00h42m44s)



[out exactly what's going wrong without](https://youtu.be/j80xaF6Lhk8?t=00h42m47s)



[even needing to to click on your test](https://youtu.be/j80xaF6Lhk8?t=00h42m49s)



[which is really awesome most of the time](https://youtu.be/j80xaF6Lhk8?t=00h42m50s)



[so there's other tools like n crunch](https://youtu.be/j80xaF6Lhk8?t=00h42m54s)



[which do similar they've been around](https://youtu.be/j80xaF6Lhk8?t=00h42m57s)



[longer this is just Microsoft's built-in](https://youtu.be/j80xaF6Lhk8?t=00h42m59s)



[solution but again I think it does take](https://youtu.be/j80xaF6Lhk8?t=00h43m01s)



[Visual Studio Enterprise don't quote me](https://youtu.be/j80xaF6Lhk8?t=00h43m03s)



[on that okay so back to this guy we've](https://youtu.be/j80xaF6Lhk8?t=00h43m06s)



[got text a match we've got these fixed](https://youtu.be/j80xaF6Lhk8?t=00h43m12s)



[suggestions which are a list of non](https://youtu.be/j80xaF6Lhk8?t=00h43m16s)



[knowable strings all right and the](https://youtu.be/j80xaF6Lhk8?t=00h43m20s)



[suggestions source that can pull out](https://youtu.be/j80xaF6Lhk8?t=00h43m23s)



[more suggestions which are returning non](https://youtu.be/j80xaF6Lhk8?t=00h43m26s)



[knowable strings and I guess my first](https://youtu.be/j80xaF6Lhk8?t=00h43m28s)



[thought is because these can come from](https://youtu.be/j80xaF6Lhk8?t=00h43m32s)



[the outside should I really assume that](https://youtu.be/j80xaF6Lhk8?t=00h43m36s)



[they're non knowable I think in this](https://youtu.be/j80xaF6Lhk8?t=00h43m39s)



[case because a suggestion source all](https://youtu.be/j80xaF6Lhk8?t=00h43m44s)



[right so if we look at these suggestion](https://youtu.be/j80xaF6Lhk8?t=00h43m47s)



[sources so in the grand scheme of things](https://youtu.be/j80xaF6Lhk8?t=00h43m49s)



[if you're working with system command](https://youtu.be/j80xaF6Lhk8?t=00h43m53s)



[line these allow you to provide](https://youtu.be/j80xaF6Lhk8?t=00h43m56s)



[suggestions when people are doing tab](https://youtu.be/j80xaF6Lhk8?t=00h43m58s)



[completion so if you've got you know](https://youtu.be/j80xaF6Lhk8?t=00h44m00s)



[some built-in vocabulary or file or](https://youtu.be/j80xaF6Lhk8?t=00h44m04s)



[database or whatever you can use this to](https://youtu.be/j80xaF6Lhk8?t=00h44m08s)



[provide those things it is important to](https://youtu.be/j80xaF6Lhk8?t=00h44m09s)



[note it's very intentionally not an](https://youtu.be/j80xaF6Lhk8?t=00h44m11s)



[async but yeah so the question is should](https://youtu.be/j80xaF6Lhk8?t=00h44m14s)



[this be knowable and I think the answer](https://youtu.be/j80xaF6Lhk8?t=00h44m19s)



[is yes because this is expected to be](https://youtu.be/j80xaF6Lhk8?t=00h44m23s)



[implemented by people outside of the](https://youtu.be/j80xaF6Lhk8?t=00h44m27s)



[library and because it's people by](https://youtu.be/j80xaF6Lhk8?t=00h44m29s)



[outside of the library I can't assume](https://youtu.be/j80xaF6Lhk8?t=00h44m31s)



[see sharpie and Nobles so I think I have](https://youtu.be/j80xaF6Lhk8?t=00h44m33s)



[to assume that that could be knowable](https://youtu.be/j80xaF6Lhk8?t=00h44m38s)



[and then that's going to change what](https://youtu.be/j80xaF6Lhk8?t=00h44m40s)



[we're doing down here right so this guy](https://youtu.be/j80xaF6Lhk8?t=00h44m44s)



[is now very unhappy](https://youtu.be/j80xaF6Lhk8?t=00h44m45s)



[because I've now said that this guy is](https://youtu.be/j80xaF6Lhk8?t=00h44m48s)



[going to return a non knowable list of](https://youtu.be/j80xaF6Lhk8?t=00h44m51s)



[strings but yet this guy here is](https://youtu.be/j80xaF6Lhk8?t=00h44m52s)



[potentially nullable so the question is](https://youtu.be/j80xaF6Lhk8?t=00h44m56s)



[how do I go through and do this so I](https://youtu.be/j80xaF6Lhk8?t=00h45m01s)



[could go through and as part of this](https://youtu.be/j80xaF6Lhk8?t=00h45m04s)



[select mini when we're building up the](https://youtu.be/j80xaF6Lhk8?t=00h45m07s)



[dynamic suggestions verify non null it's](https://youtu.be/j80xaF6Lhk8?t=00h45m08s)



[one option I could push it through that](https://youtu.be/j80xaF6Lhk8?t=00h45m12s)



[way and then that just keeps this nice](https://youtu.be/j80xaF6Lhk8?t=00h45m14s)



[and clean so what interface is this](https://youtu.be/j80xaF6Lhk8?t=00h45m17s)



[tight to oh so this itself is I](https://youtu.be/j80xaF6Lhk8?t=00h45m18s)



[suggestion source which is gonna mean oh](https://youtu.be/j80xaF6Lhk8?t=00h45m23s)



[yeah so this is going to propagate like](https://youtu.be/j80xaF6Lhk8?t=00h45m25s)



[that right so that's gonna go like that](https://youtu.be/j80xaF6Lhk8?t=00h45m28s)



[which now it's going to be unhappy about](https://youtu.be/j80xaF6Lhk8?t=00h45m30s)



[because of the base yeah so down here](https://youtu.be/j80xaF6Lhk8?t=00h45m32s)



[this guy is now going to be unhappy](https://youtu.be/j80xaF6Lhk8?t=00h45m36s)



[because he wants this alright so let it](https://youtu.be/j80xaF6Lhk8?t=00h45m38s)



[figure itself out there I think so there](https://youtu.be/j80xaF6Lhk8?t=00h45m45s)



[save you'll notice me and I didn't even](https://youtu.be/j80xaF6Lhk8?t=00h45m50s)



[have to hit save before live unit](https://youtu.be/j80xaF6Lhk8?t=00h45m52s)



[testing got all over eager and had to](https://youtu.be/j80xaF6Lhk8?t=00h45m54s)



[rerun stuff it likes to be helpful](https://youtu.be/j80xaF6Lhk8?t=00h45m56s)



[okay so fixed suggestions is not null](https://youtu.be/j80xaF6Lhk8?t=00h46m03s)



[here agreed so let's see order to](https://youtu.be/j80xaF6Lhk8?t=00h46m08s)



[numerals string nullable cannot be used](https://youtu.be/j80xaF6Lhk8?t=00h46m16s)



[for parameter candidates type](https://youtu.be/j80xaF6Lhk8?t=00h46m18s)



[ienumerable](https://youtu.be/j80xaF6Lhk8?t=00h46m20s)



[suggestions extensions containing so](https://youtu.be/j80xaF6Lhk8?t=00h46m23s)



[this guy here is it ours and so what](https://youtu.be/j80xaF6Lhk8?t=00h46m26s)



[it's saying is that doesn't match that](https://youtu.be/j80xaF6Lhk8?t=00h46m29s)



[doesn't match and that doesn't match](https://youtu.be/j80xaF6Lhk8?t=00h46m35s)



[yuck which i think is gonna then](https://youtu.be/j80xaF6Lhk8?t=00h46m41s)



[propagate into here contains](https://youtu.be/j80xaF6Lhk8?t=00h46m43s)



[case-insensitive](https://youtu.be/j80xaF6Lhk8?t=00h46m46s)



[so let's see here this guy I don't think](https://youtu.be/j80xaF6Lhk8?t=00h46m47s)



[I don't think we can even get away with](https://youtu.be/j80xaF6Lhk8?t=00h46m56s)



[this can we so value clearly can be null](https://youtu.be/j80xaF6Lhk8?t=00h46m58s)



[because we are explicitly checking for](https://youtu.be/j80xaF6Lhk8?t=00h47m02s)



[it here and if sources null](https://youtu.be/j80xaF6Lhk8?t=00h47m06s)



[yeah if sources know this guy's gonna](https://youtu.be/j80xaF6Lhk8?t=00h47m17s)



[throw I believe yeah so source should](https://youtu.be/j80xaF6Lhk8?t=00h47m20s)



[probably not be no because that's bad](https://youtu.be/j80xaF6Lhk8?t=00h47m25s)



[value where we're going to handle](https://youtu.be/j80xaF6Lhk8?t=00h47m29s)



[ourselves well let's step back so this](https://youtu.be/j80xaF6Lhk8?t=00h47m32s)



[means here so I think what we do is this](https://youtu.be/j80xaF6Lhk8?t=00h47m34s)



[like that something like that perhaps](https://youtu.be/j80xaF6Lhk8?t=00h47m42s)



[not a huge fan of it but as John pointed](https://youtu.be/j80xaF6Lhk8?t=00h47m51s)



[out all the tests pass so haven't broken](https://youtu.be/j80xaF6Lhk8?t=00h47m54s)



[anything yet okay](https://youtu.be/j80xaF6Lhk8?t=00h47m56s)



[and I think that is our last guy here do](https://youtu.be/j80xaF6Lhk8?t=00h47m58s)



[we got another warning up here](https://youtu.be/j80xaF6Lhk8?t=00h48m01s)



[that's just resharper that's just](https://youtu.be/j80xaF6Lhk8?t=00h48m03s)



[resharper we're ignoring all of its](https://youtu.be/j80xaF6Lhk8?t=00h48m05s)



[suggestions about making things private](https://youtu.be/j80xaF6Lhk8?t=00h48m08s)



[and whatnot because that is not part of](https://youtu.be/j80xaF6Lhk8?t=00h48m10s)



[what we're doing here okay oh you're](https://youtu.be/j80xaF6Lhk8?t=00h48m11s)



[still watching John I'm doing my best to](https://youtu.be/j80xaF6Lhk8?t=00h48m18s)



[not make you cringe too much](https://youtu.be/j80xaF6Lhk8?t=00h48m21s)



[no promises it's a very real chance I](https://youtu.be/j80xaF6Lhk8?t=00h48m24s)



[will do it okay](https://youtu.be/j80xaF6Lhk8?t=00h48m27s)



[so save all clear out some mess](https://youtu.be/j80xaF6Lhk8?t=00h48m29s)



[carry on okay so argument arity so this](https://youtu.be/j80xaF6Lhk8?t=00h48m33s)



[class is here to describe watch you](https://youtu.be/j80xaF6Lhk8?t=00h48m37s)



[watching from between my fingers yes](https://youtu.be/j80xaF6Lhk8?t=00h48m40s)



[perfect so this class here declares the](https://youtu.be/j80xaF6Lhk8?t=00h48m45s)



[era T of an argument](https://youtu.be/j80xaF6Lhk8?t=00h48m49s)



[so options commands have arguments that](https://youtu.be/j80xaF6Lhk8?t=00h48m50s)



[get passed to them and you can think of](https://youtu.be/j80xaF6Lhk8?t=00h48m54s)



[this as you know exactly one one or more](https://youtu.be/j80xaF6Lhk8?t=00h48m56s)



[zero or more those types of things right](https://youtu.be/j80xaF6Lhk8?t=00h48m59s)



[so minimum maximum and we've got a bunch](https://youtu.be/j80xaF6Lhk8?t=00h49m01s)



[of knowable problems in here so this is](https://youtu.be/j80xaF6Lhk8?t=00h49m05s)



[the one that we sort of looked at before](https://youtu.be/j80xaF6Lhk8?t=00h49m08s)



[and we determined that this simple](https://youtu.be/j80xaF6Lhk8?t=00h49m10s)



[result coming in could be null](https://youtu.be/j80xaF6Lhk8?t=00h49m12s)



[the first issue here is command result](https://youtu.be/j80xaF6Lhk8?t=00h49m15s)



[is not null but the route portion of it](https://youtu.be/j80xaF6Lhk8?t=00h49m19s)



[could be so this guy is very clearly](https://youtu.be/j80xaF6Lhk8?t=00h49m22s)



[nullable because there's an as cast to](https://youtu.be/j80xaF6Lhk8?t=00h49m27s)



[begin with right and then a dot root on](https://youtu.be/j80xaF6Lhk8?t=00h49m30s)



[top of it which just propagates back](https://youtu.be/j80xaF6Lhk8?t=00h49m34s)



[into itself right so this guy's going to](https://youtu.be/j80xaF6Lhk8?t=00h49m38s)



[walk all the way up or walk up](https://youtu.be/j80xaF6Lhk8?t=00h49m39s)



[so that guy is clearly nullable this is](https://youtu.be/j80xaF6Lhk8?t=00h49m45s)



[clearly not checking for null I think](https://youtu.be/j80xaF6Lhk8?t=00h49m50s)



[the solution here is no problem alright](https://youtu.be/j80xaF6Lhk8?t=00h49m53s)



[because this guy can fall into here this](https://youtu.be/j80xaF6Lhk8?t=00h49m58s)



[argument result is clearly null checked](https://youtu.be/j80xaF6Lhk8?t=00h50m01s)



[here so that works ok symbol result so](https://youtu.be/j80xaF6Lhk8?t=00h50m03s)



[this is the guy that's coming in here so](https://youtu.be/j80xaF6Lhk8?t=00h50m08s)



[the question first of all is this is not](https://youtu.be/j80xaF6Lhk8?t=00h50m11s)



[an extension method so this may be null](https://youtu.be/j80xaF6Lhk8?t=00h50m15s)



[mm-hmm and so if symbol result is null](https://youtu.be/j80xaF6Lhk8?t=00h50m22s)



[what's going to happen if it is null](https://youtu.be/j80xaF6Lhk8?t=00h50m26s)



[it's going to come into heat this switch](https://youtu.be/j80xaF6Lhk8?t=00h50m29s)



[it's gonna hit the default case and get](https://youtu.be/j80xaF6Lhk8?t=00h50m31s)



[assigned here which means argument](https://youtu.be/j80xaF6Lhk8?t=00h50m34s)



[result is null which means argument](https://youtu.be/j80xaF6Lhk8?t=00h50m36s)



[result will be 0 minimum number of](https://youtu.be/j80xaF6Lhk8?t=00h50m38s)



[values I don't think is ever expected to](https://youtu.be/j80xaF6Lhk8?t=00h50m43s)



[be negative I think in this case we just](https://youtu.be/j80xaF6Lhk8?t=00h50m45s)



[tell the compiler hands off this is not](https://youtu.be/j80xaF6Lhk8?t=00h50m52s)



[actually a case that matters so the](https://youtu.be/j80xaF6Lhk8?t=00h50m54s)



[knowable](https://youtu.be/j80xaF6Lhk8?t=00h50m56s)



[checking from the compiler doesn't it's](https://youtu.be/j80xaF6Lhk8?t=00h50m57s)



[not recursive right so if you call into](https://youtu.be/j80xaF6Lhk8?t=00h51m00s)



[something if it can't figure it out just](https://youtu.be/j80xaF6Lhk8?t=00h51m03s)



[by looking at that one call site it's](https://youtu.be/j80xaF6Lhk8?t=00h51m05s)



[done it's not gonna do inspection of the](https://youtu.be/j80xaF6Lhk8?t=00h51m07s)



[il inside of your methods or any of that](https://youtu.be/j80xaF6Lhk8?t=00h51m10s)



[jazz right so it is it is sort of single](https://youtu.be/j80xaF6Lhk8?t=00h51m12s)



[level which is how it's able to stay](https://youtu.be/j80xaF6Lhk8?t=00h51m16s)



[reasonably perform it but it does mean](https://youtu.be/j80xaF6Lhk8?t=00h51m18s)



[that it it's not gonna do the the fancy](https://youtu.be/j80xaF6Lhk8?t=00h51m21s)



[analysis I know the JetBrains stuff](https://youtu.be/j80xaF6Lhk8?t=00h51m24s)



[tries and does a pretty good job mostly](https://youtu.be/j80xaF6Lhk8?t=00h51m25s)



[but they still don't go inside they](https://youtu.be/j80xaF6Lhk8?t=00h51m29s)



[still don't do recursive but they will](https://youtu.be/j80xaF6Lhk8?t=00h51m31s)



[do analysis inside of your il to do to](https://youtu.be/j80xaF6Lhk8?t=00h51m34s)



[do to do to do to do so we come down](https://youtu.be/j80xaF6Lhk8?t=00h51m39s)



[into here so if token count is greater](https://youtu.be/j80xaF6Lhk8?t=00h51m41s)



[than maximum number of arguments this](https://youtu.be/j80xaF6Lhk8?t=00h51m44s)



[would be a zero so again remember in the](https://youtu.be/j80xaF6Lhk8?t=00h51m49s)



[case where the null occurs right so in](https://youtu.be/j80xaF6Lhk8?t=00h51m53s)



[order for symbol result to be null](https://youtu.be/j80xaF6Lhk8?t=00h51m55s)



[dokin count will be zero okay so in](https://youtu.be/j80xaF6Lhk8?t=00h51m58s)



[order for that to happen that would](https://youtu.be/j80xaF6Lhk8?t=00h52m03s)



[require this to be the maximum to be a](https://youtu.be/j80xaF6Lhk8?t=00h52m05s)



[negative and I realize according to the](https://youtu.be/j80xaF6Lhk8?t=00h52m08s)



[API there's nothing stopping somebody](https://youtu.be/j80xaF6Lhk8?t=00h52m14s)



[from setting the maximum to be a](https://youtu.be/j80xaF6Lhk8?t=00h52m16s)



[negative right there they write like the](https://youtu.be/j80xaF6Lhk8?t=00h52m18s)



[the constructor will try and prevent you](https://youtu.be/j80xaF6Lhk8?t=00h52m23s)



[know insane values but these are just](https://youtu.be/j80xaF6Lhk8?t=00h52m26s)



[public auto properties right there's you](https://youtu.be/j80xaF6Lhk8?t=00h52m29s)



[you could go into this thing and say yep](https://youtu.be/j80xaF6Lhk8?t=00h52m32s)



[I know the constructor enforced some](https://youtu.be/j80xaF6Lhk8?t=00h52m34s)



[level of sanity but you know I'm gonna](https://youtu.be/j80xaF6Lhk8?t=00h52m36s)



[change it and do something crazy but I I](https://youtu.be/j80xaF6Lhk8?t=00h52m37s)



[feel like in both of these cases I just](https://youtu.be/j80xaF6Lhk8?t=00h52m41s)



[tell the compiler know I know better](https://youtu.be/j80xaF6Lhk8?t=00h52m44s)



[than you trust me this ain't gonna be no](https://youtu.be/j80xaF6Lhk8?t=00h52m46s)



[I think that's what we do here because](https://youtu.be/j80xaF6Lhk8?t=00h52m48s)



[rationally that is not possible okay](https://youtu.be/j80xaF6Lhk8?t=00h52m52s)



[well let's continue on so that handles](https://youtu.be/j80xaF6Lhk8?t=00h52m58s)



[argument arity argument converter close](https://youtu.be/j80xaF6Lhk8?t=00h53m01s)



[some of these guys up okay so this is](https://youtu.be/j80xaF6Lhk8?t=00h53m04s)



[this is one this one's gonna be fun I](https://youtu.be/j80xaF6Lhk8?t=00h53m07s)



[remember looking at this one earlier](https://youtu.be/j80xaF6Lhk8?t=00h53m09s)



[okay so here we've got a very unusual](https://youtu.be/j80xaF6Lhk8?t=00h53m11s)



[use case so for starters we've got this](https://youtu.be/j80xaF6Lhk8?t=00h53m15s)



[this large extension method right but](https://youtu.be/j80xaF6Lhk8?t=00h53m19s)



[this is effectively a tryparse right so](https://youtu.be/j80xaF6Lhk8?t=00h53m22s)



[it's got returns a bool has an out](https://youtu.be/j80xaF6Lhk8?t=00h53m25s)



[parameter in this case the out parameter](https://youtu.be/j80xaF6Lhk8?t=00h53m27s)



[happens to be a value to 'pl whose](https://youtu.be/j80xaF6Lhk8?t=00h53m29s)



[individual members are knowable right](https://youtu.be/j80xaF6Lhk8?t=00h53m32s)



[which they have to be know based upon](https://youtu.be/j80xaF6Lhk8?t=00h53m35s)



[this and this gets very very weird right](https://youtu.be/j80xaF6Lhk8?t=00h53m37s)



[because ideally what I'd love to do is](https://youtu.be/j80xaF6Lhk8?t=00h53m40s)



[put something like not null when we](https://youtu.be/j80xaF6Lhk8?t=00h53m44s)



[return true right and decorate it the](https://youtu.be/j80xaF6Lhk8?t=00h53m48s)



[problem is this is a value tuple](https://youtu.be/j80xaF6Lhk8?t=00h53m51s)



[you know what so the issue being here](https://youtu.be/j80xaF6Lhk8?t=00h53m58s)



[right this doesn't work because value](https://youtu.be/j80xaF6Lhk8?t=00h54m04s)



[tuple will always be not known right](https://youtu.be/j80xaF6Lhk8?t=00h54m05s)



[there's new it's a struct a value type](https://youtu.be/j80xaF6Lhk8?t=00h54m08s)



[can't be known unless we put a little](https://youtu.be/j80xaF6Lhk8?t=00h54m12s)



[question mark there right because the](https://youtu.be/j80xaF6Lhk8?t=00h54m16s)



[the hard case right down here is this](https://youtu.be/j80xaF6Lhk8?t=00h54m18s)



[guy right so in the tryparse case right](https://youtu.be/j80xaF6Lhk8?t=00h54m20s)



[we return false null and null and so](https://youtu.be/j80xaF6Lhk8?t=00h54m23s)



[initially I had gone through and marked](https://youtu.be/j80xaF6Lhk8?t=00h54m29s)



[both of these is knowable because](https://youtu.be/j80xaF6Lhk8?t=00h54m31s)



[clearly we are setting null into them](https://youtu.be/j80xaF6Lhk8?t=00h54m32s)



[okay kind of makes sense but I'm](https://youtu.be/j80xaF6Lhk8?t=00h54m35s)



[wondering if it makes more sense for](https://youtu.be/j80xaF6Lhk8?t=00h54m38s)



[these to be non nullable write the value](https://youtu.be/j80xaF6Lhk8?t=00h54m41s)



[tuple itself to be no right and then](https://youtu.be/j80xaF6Lhk8?t=00h54m47s)



[rather than null null this guy returns](https://youtu.be/j80xaF6Lhk8?t=00h54m51s)



[sets it to no there and so not null when](https://youtu.be/j80xaF6Lhk8?t=00h54m56s)



[true right because if we return true we](https://youtu.be/j80xaF6Lhk8?t=00h54m59s)



[know we're going to return a valid value](https://youtu.be/j80xaF6Lhk8?t=00h55m02s)



[tuple](https://youtu.be/j80xaF6Lhk8?t=00h55m04s)



[I wonder if it's cleaner to do know when](https://youtu.be/j80xaF6Lhk8?t=00h55m10s)



[not know when maybe no allowing all](https://youtu.be/j80xaF6Lhk8?t=00h55m14s)



[disallow no yeah yeah so there's a bunch](https://youtu.be/j80xaF6Lhk8?t=00h55m19s)



[of attributes we're going to get to](https://youtu.be/j80xaF6Lhk8?t=00h55m23s)



[another fun case because I know there's](https://youtu.be/j80xaF6Lhk8?t=00h55m24s)



[cases in here so right now with c-sharp](https://youtu.be/j80xaF6Lhk8?t=00h55m26s)



[eight](https://youtu.be/j80xaF6Lhk8?t=00h55m29s)



[you can't put attributes on local](https://youtu.be/j80xaF6Lhk8?t=00h55m29s)



[functions or you can't put attributes](https://youtu.be/j80xaF6Lhk8?t=00h55m32s)



[yeah on local functions or their](https://youtu.be/j80xaF6Lhk8?t=00h55m35s)



[arguments and whatnot right and we have](https://youtu.be/j80xaF6Lhk8?t=00h55m39s)



[these things that we've got local](https://youtu.be/j80xaF6Lhk8?t=00h55m42s)



[functions that follow this pattern that](https://youtu.be/j80xaF6Lhk8?t=00h55m44s)



[you can't decorate correctly which is](https://youtu.be/j80xaF6Lhk8?t=00h55m47s)



[really frustrating](https://youtu.be/j80xaF6Lhk8?t=00h55m49s)



[there is on.net five I saw on the github](https://youtu.be/j80xaF6Lhk8?t=00h55m51s)



[page with all of the potential features](https://youtu.be/j80xaF6Lhk8?t=00h55m55s)



[adding that support that is in the](https://youtu.be/j80xaF6Lhk8?t=00h55m59s)



[status of merged so I think that means](https://youtu.be/j80xaF6Lhk8?t=00h56m01s)



[high probability that are to make it](https://youtu.be/j80xaF6Lhk8?t=00h56m05s)



[into dotnet five if the codes already](https://youtu.be/j80xaF6Lhk8?t=00h56m07s)



[been merged so I'm sure I I don't know](https://youtu.be/j80xaF6Lhk8?t=00h56m09s)



[what the official answer is but I'm](https://youtu.be/j80xaF6Lhk8?t=00h56m14s)



[guessing is probably is about as close](https://youtu.be/j80xaF6Lhk8?t=00h56m15s)



[of an answer as I'm going to hear okay](https://youtu.be/j80xaF6Lhk8?t=00h56m18s)



[so I think if we do this this guy's](https://youtu.be/j80xaF6Lhk8?t=00h56m21s)



[private which means we can change up](https://youtu.be/j80xaF6Lhk8?t=00h56m24s)



[this signature without doing too much](https://youtu.be/j80xaF6Lhk8?t=00h56m26s)



[damage](https://youtu.be/j80xaF6Lhk8?t=00h56m29s)



[only a couple usages great so let's](https://youtu.be/j80xaF6Lhk8?t=00h56m30s)



[change this up right so I think what we](https://youtu.be/j80xaF6Lhk8?t=00h56m33s)



[do is this and we do this and we make](https://youtu.be/j80xaF6Lhk8?t=00h56m36s)



[you nullable let's see so this guy here](https://youtu.be/j80xaF6Lhk8?t=00h56m41s)



[is unhappy because now it's technically](https://youtu.be/j80xaF6Lhk8?t=00h56m53s)



[tuple dot value now why are you unable](https://youtu.be/j80xaF6Lhk8?t=00h56m56s)



[to figure this one out](https://youtu.be/j80xaF6Lhk8?t=00h57m03s)



[feels like it should be able to identify](https://youtu.be/j80xaF6Lhk8?t=00h57m10s)



[this one I'm sure it's the the fact that](https://youtu.be/j80xaF6Lhk8?t=00h57m12s)



[it's not doing extra recursive stuff but](https://youtu.be/j80xaF6Lhk8?t=00h57m16s)



[the fact that it knows that this](https://youtu.be/j80xaF6Lhk8?t=00h57m19s)



[parameter is not null makes me wonder if](https://youtu.be/j80xaF6Lhk8?t=00h57m23s)



[I've decorated this wrong is it supposed](https://youtu.be/j80xaF6Lhk8?t=00h57m28s)



[to actually be so let me look is this](https://youtu.be/j80xaF6Lhk8?t=00h57m31s)



[supposed to be decorated on the return](https://youtu.be/j80xaF6Lhk8?t=00h57m33s)



[type](https://youtu.be/j80xaF6Lhk8?t=00h57m34s)



[so attribute usage not know when no that](https://youtu.be/j80xaF6Lhk8?t=00h57m35s)



[is definitely on the parameter so let's](https://youtu.be/j80xaF6Lhk8?t=00h57m40s)



[look at which of these are maybe no when](https://youtu.be/j80xaF6Lhk8?t=00h57m44s)



[did that also goes there I am somewhat](https://youtu.be/j80xaF6Lhk8?t=00h57m56s)



[tempted to use them maybe nolwenn and](https://youtu.be/j80xaF6Lhk8?t=00h58m02s)



[flip it to be the other direction](https://youtu.be/j80xaF6Lhk8?t=00h58m04s)



[because that's how dictionaries](https://youtu.be/j80xaF6Lhk8?t=00h58m05s)



[implemented not null if not null](https://youtu.be/j80xaF6Lhk8?t=00h58m08s)



[attribute](https://youtu.be/j80xaF6Lhk8?t=00h58m12s)



[okay does not return does not return if](https://youtu.be/j80xaF6Lhk8?t=00h58m14s)



[does not return if these things are for](https://youtu.be/j80xaF6Lhk8?t=00h58m18s)



[like assert type methods right so your](https://youtu.be/j80xaF6Lhk8?t=00h58m22s)



[unit testing things were a certain not](https://youtu.be/j80xaF6Lhk8?t=00h58m24s)



[null so does not return if various](https://youtu.be/j80xaF6Lhk8?t=00h58m26s)



[condition etc right so that's correct](https://youtu.be/j80xaF6Lhk8?t=00h58m30s)



[they're just surprised that the usage](https://youtu.be/j80xaF6Lhk8?t=00h58m35s)



[can't figure it out and is gonna make me](https://youtu.be/j80xaF6Lhk8?t=00h58m38s)



[do something I don't really want to do](https://youtu.be/j80xaF6Lhk8?t=00h58m40s)



[jump me show me there](https://youtu.be/j80xaF6Lhk8?t=00h58m43s)



[okay I got too many tabs some people do](https://youtu.be/j80xaF6Lhk8?t=00h58m46s)



[really well with lots of tabs](https://youtu.be/j80xaF6Lhk8?t=00h58m51s)



[I do not okay so](https://youtu.be/j80xaF6Lhk8?t=00h58m52s)



[something in the back of my mind is](https://youtu.be/j80xaF6Lhk8?t=00h59m04s)



[telling me I can do tuple deconstruction](https://youtu.be/j80xaF6Lhk8?t=00h59m06s)



[here right](https://youtu.be/j80xaF6Lhk8?t=00h59m08s)



[I think in this case what I might just](https://youtu.be/j80xaF6Lhk8?t=00h59m16s)



[do in the interest of sanity and](https://youtu.be/j80xaF6Lhk8?t=00h59m18s)



[simplicity system in possible invalid](https://youtu.be/j80xaF6Lhk8?t=00h59m20s)



[operation exception I am missing the](https://youtu.be/j80xaF6Lhk8?t=00h59m28s)



[invalid op](https://youtu.be/j80xaF6Lhk8?t=00h59m31s)



[well](https://youtu.be/j80xaF6Lhk8?t=00h59m41s)



[okay I'm just gonna](https://youtu.be/j80xaF6Lhk8?t=00h59m46s)



[no I think I'm gonna leave this alone](https://youtu.be/j80xaF6Lhk8?t=00h59m51s)



[I'm not gonna ignore that for now](https://youtu.be/j80xaF6Lhk8?t=00h59m54s)



[because I think this is just resharper](https://youtu.be/j80xaF6Lhk8?t=00h59m57s)



[being dumb okay next up okay so this one](https://youtu.be/j80xaF6Lhk8?t=00h59m59s)



[gets even more fun so again with the](https://youtu.be/j80xaF6Lhk8?t=01h00m05s)



[Nobel reference types generics get](https://youtu.be/j80xaF6Lhk8?t=01h00m07s)



[really interesting right because how do](https://youtu.be/j80xaF6Lhk8?t=01h00m09s)



[you know if a value is knowable or not](https://youtu.be/j80xaF6Lhk8?t=01h00m11s)



[right so for example argument converter](https://youtu.be/j80xaF6Lhk8?t=01h00m14s)



[this is get value or default right](https://youtu.be/j80xaF6Lhk8?t=01h00m17s)



[there's no rhyme or reason of what T can](https://youtu.be/j80xaF6Lhk8?t=01h00m20s)



[be this is unconstrained and so we now](https://youtu.be/j80xaF6Lhk8?t=01h00m23s)



[get to the Schrodinger's generic](https://youtu.be/j80xaF6Lhk8?t=01h00m26s)



[parameters where it's if this were an](https://youtu.be/j80xaF6Lhk8?t=01h00m28s)



[int for example then obviously non](https://youtu.be/j80xaF6Lhk8?t=01h00m31s)



[nullable but for example if it were](https://youtu.be/j80xaF6Lhk8?t=01h00m35s)



[called will say object knowable right](https://youtu.be/j80xaF6Lhk8?t=01h00m38s)



[and so the question now is how to to](https://youtu.be/j80xaF6Lhk8?t=01h00m42s)



[properly decorate this because this is](https://youtu.be/j80xaF6Lhk8?t=01h00m46s)



[nullable if it's basically the the T](https://youtu.be/j80xaF6Lhk8?t=01h00m49s)



[type here right so let's see so what do](https://youtu.be/j80xaF6Lhk8?t=01h00m55s)



[we have here so this value is obviously](https://youtu.be/j80xaF6Lhk8?t=01h01m00s)



[knowable object I'm somewhat wondering](https://youtu.be/j80xaF6Lhk8?t=01h01m02s)



[if the answer is this all right because](https://youtu.be/j80xaF6Lhk8?t=01h01m05s)



[that handles well that doesn't quite fix](https://youtu.be/j80xaF6Lhk8?t=01h01m08s)



[it so I think what you do is you'd do](https://youtu.be/j80xaF6Lhk8?t=01h01m11s)



[something like return maybe not](https://youtu.be/j80xaF6Lhk8?t=01h01m16s)



[I think is this situation there and then](https://youtu.be/j80xaF6Lhk8?t=01h01m23s)



[this guy becomes like this and like this](https://youtu.be/j80xaF6Lhk8?t=01h01m27s)



[I think is the solution again I'm open](https://youtu.be/j80xaF6Lhk8?t=01h01m34s)



[to other suggestions of how to properly](https://youtu.be/j80xaF6Lhk8?t=01h01m40s)



[do this but I think that's probably the](https://youtu.be/j80xaF6Lhk8?t=01h01m43s)



[the solution there](https://youtu.be/j80xaF6Lhk8?t=01h01m47s)



[I didn't expose any new things that](https://youtu.be/j80xaF6Lhk8?t=01h01m49s)



[weren't in here previously and live unit](https://youtu.be/j80xaF6Lhk8?t=01h01m52s)



[testing is still green I've got it kind](https://youtu.be/j80xaF6Lhk8?t=01h01m55s)



[of minimized but the little green dots](https://youtu.be/j80xaF6Lhk8?t=01h01m57s)



[in the top right corner that's what we](https://youtu.be/j80xaF6Lhk8?t=01h02m00s)



[were watching if they go red it means](https://youtu.be/j80xaF6Lhk8?t=01h02m02s)



[I've broken something okay so let's](https://youtu.be/j80xaF6Lhk8?t=01h02m04s)



[carry on argument converter expression](https://youtu.be/j80xaF6Lhk8?t=01h02m08s)



[extensions so what do we got here so](https://youtu.be/j80xaF6Lhk8?t=01h02m10s)



[this is scary in and of itself the fact](https://youtu.be/j80xaF6Lhk8?t=01h02m14s)



[that I see these blue lines mean that I](https://youtu.be/j80xaF6Lhk8?t=01h02m17s)



[have no unit test to guarantee that I](https://youtu.be/j80xaF6Lhk8?t=01h02m19s)



[haven't screwed something up so that's](https://youtu.be/j80xaF6Lhk8?t=01h02m21s)



[fun and so here we have an interesting](https://youtu.be/j80xaF6Lhk8?t=01h02m23s)



[case right so this local variable is](https://youtu.be/j80xaF6Lhk8?t=01h02m27s)



[declared here with pattern matching and](https://youtu.be/j80xaF6Lhk8?t=01h02m31s)



[so in this case it's declared as non](https://youtu.be/j80xaF6Lhk8?t=01h02m34s)



[nullable but down here it's reused as](https://youtu.be/j80xaF6Lhk8?t=01h02m38s)



[and with an as expression which clearly](https://youtu.be/j80xaF6Lhk8?t=01h02m47s)



[makes it knowable but looking at the](https://youtu.be/j80xaF6Lhk8?t=01h02m49s)



[code and the fact that it's not actually](https://youtu.be/j80xaF6Lhk8?t=01h02m52s)



[this remember expression used further](https://youtu.be/j80xaF6Lhk8?t=01h02m56s)



[down let's see type and name oh it is so](https://youtu.be/j80xaF6Lhk8?t=01h02m58s)



[it's set here if not null type and name](https://youtu.be/j80xaF6Lhk8?t=01h03m04s)



[and it's just returning out that tuple](https://youtu.be/j80xaF6Lhk8?t=01h03m08s)



[so it's this local function is capturing](https://youtu.be/j80xaF6Lhk8?t=01h03m14s)



[this variable this looks weird](https://youtu.be/j80xaF6Lhk8?t=01h03m17s)



[also mild perk this looks weird I think](https://youtu.be/j80xaF6Lhk8?t=01h03m22s)



[what we can do here though right so](https://youtu.be/j80xaF6Lhk8?t=01h03m35s)



[there's no the only early exit is inside](https://youtu.be/j80xaF6Lhk8?t=01h03m39s)



[of here so I think what we just do is](https://youtu.be/j80xaF6Lhk8?t=01h03m45s)



[this right so you could just pattern](https://youtu.be/j80xaF6Lhk8?t=01h03m46s)



[match into this right is remember](https://youtu.be/j80xaF6Lhk8?t=01h03m51s)



[expression oh I can't reuse the same](https://youtu.be/j80xaF6Lhk8?t=01h03m56s)



[variable though](https://youtu.be/j80xaF6Lhk8?t=01h03m59s)



[that's no boy no kind of curious I](https://youtu.be/j80xaF6Lhk8?t=01h04m09s)



[haven't tried that yeah not exactly](https://youtu.be/j80xaF6Lhk8?t=01h04m13s)



[surprised that doesn't make a lot of](https://youtu.be/j80xaF6Lhk8?t=01h04m17s)



[sense so I'm sort of wondering if the](https://youtu.be/j80xaF6Lhk8?t=01h04m18s)



[solution is to not do this weird](https://youtu.be/j80xaF6Lhk8?t=01h04m23s)



[capturing thing right](https://youtu.be/j80xaF6Lhk8?t=01h04m26s)



[make this guy static and do this alright](https://youtu.be/j80xaF6Lhk8?t=01h04m28s)



[so this this remember expression this](https://youtu.be/j80xaF6Lhk8?t=01h04m35s)



[guy then gets passed in there and did to](https://youtu.be/j80xaF6Lhk8?t=01h04m40s)



[do the to do this guy here I think I](https://youtu.be/j80xaF6Lhk8?t=01h04m46s)



[like the pattern match here as well](https://youtu.be/j80xaF6Lhk8?t=01h04m54s)



[right](https://youtu.be/j80xaF6Lhk8?t=01h05m00s)



[let's see operand I think we just do](https://youtu.be/j80xaF6Lhk8?t=01h05m02s)



[this this pass it in there right I think](https://youtu.be/j80xaF6Lhk8?t=01h05m08s)



[that gets me closer I think](https://youtu.be/j80xaF6Lhk8?t=01h05m13s)



[feel free to jump in and correct me the](https://youtu.be/j80xaF6Lhk8?t=01h05m19s)



[its I'm almost out of a mountain dew so](https://youtu.be/j80xaF6Lhk8?t=01h05m21s)



[there's a very very real chance that I'm](https://youtu.be/j80xaF6Lhk8?t=01h05m24s)



[highly likely to make mistakes but I I](https://youtu.be/j80xaF6Lhk8?t=01h05m26s)



[think that's probably the cleanest and](https://youtu.be/j80xaF6Lhk8?t=01h05m28s)



[actually okay we're gonna pattern match](https://youtu.be/j80xaF6Lhk8?t=01h05m30s)



[this and I've got no unit tests to guard](https://youtu.be/j80xaF6Lhk8?t=01h05m32s)



[me so why not do a few more refactorings](https://youtu.be/j80xaF6Lhk8?t=01h05m36s)



[while we're while we're in in the middle](https://youtu.be/j80xaF6Lhk8?t=01h05m38s)



[of this right so all right so just nest](https://youtu.be/j80xaF6Lhk8?t=01h05m41s)



[those together](https://youtu.be/j80xaF6Lhk8?t=01h05m48s)



[there if I I'm sure John would just love](https://youtu.be/j80xaF6Lhk8?t=01h05m55s)



[to see all of all of those extra changes](https://youtu.be/j80xaF6Lhk8?t=01h05m59s)



[tacked into there okay next up on the](https://youtu.be/j80xaF6Lhk8?t=01h06m02s)



[chopping block model binder so a model](https://youtu.be/j80xaF6Lhk8?t=01h06m05s)



[binder is the portion of the library](https://youtu.be/j80xaF6Lhk8?t=01h06m10s)



[when you want to do something where you](https://youtu.be/j80xaF6Lhk8?t=01h06m13s)



[call invoke right so you get your string](https://youtu.be/j80xaF6Lhk8?t=01h06m17s)



[array you can parse it into an object](https://youtu.be/j80xaF6Lhk8?t=01h06m19s)



[model right and then you can call invoke](https://youtu.be/j80xaF6Lhk8?t=01h06m21s)



[and that needs to take that parsed](https://youtu.be/j80xaF6Lhk8?t=01h06m24s)



[object model and actually call some](https://youtu.be/j80xaF6Lhk8?t=01h06m26s)



[method on your commands right so the](https://youtu.be/j80xaF6Lhk8?t=01h06m28s)



[model binder lets your commands have](https://youtu.be/j80xaF6Lhk8?t=01h06m31s)



[nice nice handler syntax so you can](https://youtu.be/j80xaF6Lhk8?t=01h06m34s)



[declare the method the way you want and](https://youtu.be/j80xaF6Lhk8?t=01h06m38s)



[it deals with effectively binding those](https://youtu.be/j80xaF6Lhk8?t=01h06m39s)



[parts values into the value that you get](https://youtu.be/j80xaF6Lhk8?t=01h06m43s)



[tacked on so we've got this little case](https://youtu.be/j80xaF6Lhk8?t=01h06m45s)



[here so out VAR value source this looks](https://youtu.be/j80xaF6Lhk8?t=01h06m50s)



[like a similar case right is value](https://youtu.be/j80xaF6Lhk8?t=01h06m56s)



[sources declared here this VAR makes it](https://youtu.be/j80xaF6Lhk8?t=01h07m00s)



[hard to see this guy here is non](https://youtu.be/j80xaF6Lhk8?t=01h07m03s)



[nullable this guy here looks to return](https://youtu.be/j80xaF6Lhk8?t=01h07m07s)



[so this guy has an out and I think this](https://youtu.be/j80xaF6Lhk8?t=01h07m15s)



[guy just needs to be decorated right so](https://youtu.be/j80xaF6Lhk8?t=01h07m22s)



[not null when true all right I think](https://youtu.be/j80xaF6Lhk8?t=01h07m24s)



[that's the simple solution so one true](https://youtu.be/j80xaF6Lhk8?t=01h07m32s)



[this guy will actually have a value yeah](https://youtu.be/j80xaF6Lhk8?t=01h07m36s)



[yeah a lot of the code is pre c-sharp](https://youtu.be/j80xaF6Lhk8?t=01h07m42s)



[eight no John don't don't take it to](https://youtu.be/j80xaF6Lhk8?t=01h07m44s)



[mean that I think some of the code is](https://youtu.be/j80xaF6Lhk8?t=01h07m46s)



[crappy like that's that's the very](https://youtu.be/j80xaF6Lhk8?t=01h07m48s)



[nature of large libraries is it evolves](https://youtu.be/j80xaF6Lhk8?t=01h07m50s)



[over time and you can always tell the](https://youtu.be/j80xaF6Lhk8?t=01h07m52s)



[age of code based upon the version of](https://youtu.be/j80xaF6Lhk8?t=01h07m55s)



[the compiler that it was clearly written](https://youtu.be/j80xaF6Lhk8?t=01h07m56s)



[against like I'll find old stuff that](https://youtu.be/j80xaF6Lhk8?t=01h07m58s)



[doesn't have auto properties and it's](https://youtu.be/j80xaF6Lhk8?t=01h08m00s)



[got all the backing fields it's like oh](https://youtu.be/j80xaF6Lhk8?t=01h08m02s)



[how did we ever write code that way it's](https://youtu.be/j80xaF6Lhk8?t=01h08m04s)



[like alright this was you know](https://youtu.be/j80xaF6Lhk8?t=01h08m07s)



[back presea sharp six days back in the](https://youtu.be/j80xaF6Lhk8?t=01h08m08s)



[old days my properties had to go uphill](https://youtu.be/j80xaF6Lhk8?t=01h08m16s)



[both ways okay I will be done now before](https://youtu.be/j80xaF6Lhk8?t=01h08m18s)



[people throw things let's see so](https://youtu.be/j80xaF6Lhk8?t=01h08m22s)



[converting no literal to non I am](https://youtu.be/j80xaF6Lhk8?t=01h08m25s)



[confused let's not talk about var I know](https://youtu.be/j80xaF6Lhk8?t=01h08m29s)



[so I will I will say so I know you said](https://youtu.be/j80xaF6Lhk8?t=01h08m37s)



[not talked about var but I'm gonna make](https://youtu.be/j80xaF6Lhk8?t=01h08m40s)



[one small teeny point so there because](https://youtu.be/j80xaF6Lhk8?t=01h08m42s)



[var is clearly one of those Hot Topic](https://youtu.be/j80xaF6Lhk8?t=01h08m47s)



[debates where you will never get people](https://youtu.be/j80xaF6Lhk8?t=01h08m48s)



[to agree I saw that even like some of](https://youtu.be/j80xaF6Lhk8?t=01h08m51s)



[the Stack Overflow guys were debating it](https://youtu.be/j80xaF6Lhk8?t=01h08m53s)



[this is the last week I will say](https://youtu.be/j80xaF6Lhk8?t=01h08m55s)



[sometimes var when trying to figure out](https://youtu.be/j80xaF6Lhk8?t=01h08m59s)



[this knowable reference type stuff makes](https://youtu.be/j80xaF6Lhk8?t=01h09m01s)



[it really really hard like the type may](https://youtu.be/j80xaF6Lhk8?t=01h09m04s)



[be obvious but whether it's knowable or](https://youtu.be/j80xaF6Lhk8?t=01h09m06s)



[not is not obvious so an added dimension](https://youtu.be/j80xaF6Lhk8?t=01h09m09s)



[to consider when deciding whether to use](https://youtu.be/j80xaF6Lhk8?t=01h09m13s)



[var or not I will leave it at that and I](https://youtu.be/j80xaF6Lhk8?t=01h09m16s)



[will stop otherwise I'm afraid what](https://youtu.be/j80xaF6Lhk8?t=01h09m18s)



[John's gonna do is promptly like start](https://youtu.be/j80xaF6Lhk8?t=01h09m21s)



[just Auto rejecting pull requests from](https://youtu.be/j80xaF6Lhk8?t=01h09m23s)



[me okay so two non knowable type I'm](https://youtu.be/j80xaF6Lhk8?t=01h09m25s)



[still trying to wrap my head around this](https://youtu.be/j80xaF6Lhk8?t=01h09m31s)



[one of why this so ok so let's start](https://youtu.be/j80xaF6Lhk8?t=01h09m33s)



[with this right try get value so maybe](https://youtu.be/j80xaF6Lhk8?t=01h09m39s)



[know when false Oh see this is this is](https://youtu.be/j80xaF6Lhk8?t=01h09m42s)



[why they did it](https://youtu.be/j80xaF6Lhk8?t=01h09m47s)



[oh I get it for this case ok so not so](https://youtu.be/j80xaF6Lhk8?t=01h09m48s)



[rather than not know when true you do](https://youtu.be/j80xaF6Lhk8?t=01h09m52s)



[maybe know when false and then you can](https://youtu.be/j80xaF6Lhk8?t=01h09m56s)



[declare it as non knowable ah I](https://youtu.be/j80xaF6Lhk8?t=01h10m00s)



[understand now](https://youtu.be/j80xaF6Lhk8?t=01h10m04s)



[so what is your problem](https://youtu.be/j80xaF6Lhk8?t=01h10m09s)



[value source is not null here I agree](https://youtu.be/j80xaF6Lhk8?t=01h10m14s)



[I'm gonna hit compiled because I think](https://youtu.be/j80xaF6Lhk8?t=01h10m17s)



[you've lost your mind because both of](https://youtu.be/j80xaF6Lhk8?t=01h10m19s)



[these should be that's an I've al you](https://youtu.be/j80xaF6Lhk8?t=01h10m23s)



[source that's not value source neither](https://youtu.be/j80xaF6Lhk8?t=01h10m25s)



[one is knowable I think we're okay I](https://youtu.be/j80xaF6Lhk8?t=01h10m27s)



[hope](https://youtu.be/j80xaF6Lhk8?t=01h10m34s)



[okay ere list hopefully should be right](https://youtu.be/j80xaF6Lhk8?t=01h10m38s)



[at the top model binder comforting no](https://youtu.be/j80xaF6Lhk8?t=01h10m42s)



[literal or possible no value to non](https://youtu.be/j80xaF6Lhk8?t=01h10m44s)



[nullable type but but right](https://youtu.be/j80xaF6Lhk8?t=01h10m47s)



[I value source](https://youtu.be/j80xaF6Lhk8?t=01h11m01s)



[but I just declared you as non knowable](https://youtu.be/j80xaF6Lhk8?t=01h11m10s)



[I'm missing something obvious here value](https://youtu.be/j80xaF6Lhk8?t=01h11m12s)



[source all right so this this goes here](https://youtu.be/j80xaF6Lhk8?t=01h11m15s)



[what am i are you do you still think](https://youtu.be/j80xaF6Lhk8?t=01h11m19s)



[this you really want it to be knowable](https://youtu.be/j80xaF6Lhk8?t=01h11m28s)



[despite that I literally just declared](https://youtu.be/j80xaF6Lhk8?t=01h11m32s)



[it as non nullable what maybe no one](https://youtu.be/j80xaF6Lhk8?t=01h11m35s)



[false all right so let's let's look at](https://youtu.be/j80xaF6Lhk8?t=01h11m42s)



[let's look at dictionary right cuz this](https://youtu.be/j80xaF6Lhk8?t=01h11m45s)



[is how I dictionary has it declared](https://youtu.be/j80xaF6Lhk8?t=01h11m48s)



[we'll try get maybe know when false](https://youtu.be/j80xaF6Lhk8?t=01h11m50s)



[right because in this case they don't](https://youtu.be/j80xaF6Lhk8?t=01h11m54s)



[know they don't know what generic](https://youtu.be/j80xaF6Lhk8?t=01h11m57s)



[parameters you're gonna pass right and](https://youtu.be/j80xaF6Lhk8?t=01h12m01s)



[knowable there's this to it there's](https://youtu.be/j80xaF6Lhk8?t=01h12m06s)



[actually an enum that gets passed into](https://youtu.be/j80xaF6Lhk8?t=01h12m09s)



[here and I'm trying to remember what it](https://youtu.be/j80xaF6Lhk8?t=01h12m11s)



[what it maps to there is a notable type](https://youtu.be/j80xaF6Lhk8?t=01h12m13s)



[this stuff is yeah you'll note compiler](https://youtu.be/j80xaF6Lhk8?t=01h12m16s)



[generated attributes but if you ever](https://youtu.be/j80xaF6Lhk8?t=01h12m18s)



[need to like dig through the code with](https://youtu.be/j80xaF6Lhk8?t=01h12m21s)



[reflection or il-2 to determine whether](https://youtu.be/j80xaF6Lhk8?t=01h12m22s)



[no ability was used this is the stuff](https://youtu.be/j80xaF6Lhk8?t=01h12m25s)



[you look for right the nullable](https://youtu.be/j80xaF6Lhk8?t=01h12m27s)



[unknowable contact stuff that's how you](https://youtu.be/j80xaF6Lhk8?t=01h12m29s)



[can tell whether things have actually](https://youtu.be/j80xaF6Lhk8?t=01h12m31s)



[been compiled for knowable reference](https://youtu.be/j80xaF6Lhk8?t=01h12m32s)



[types but](https://youtu.be/j80xaF6Lhk8?t=01h12m37s)



[I am still confused why this is unhappy](https://youtu.be/j80xaF6Lhk8?t=01h12m42s)



[maybe know when false try get value](https://youtu.be/j80xaF6Lhk8?t=01h12m45s)



[source you are legitimately declared](https://youtu.be/j80xaF6Lhk8?t=01h12m51s)



[maybe no one false okay so here's what](https://youtu.be/j80xaF6Lhk8?t=01h13m02s)



[we're gonna do we're gonna just take](https://youtu.be/j80xaF6Lhk8?t=01h13m07s)



[this attribute out of the mix for a](https://youtu.be/j80xaF6Lhk8?t=01h13m08s)



[moment and I want to see you work](https://youtu.be/j80xaF6Lhk8?t=01h13m10s)



[okay](https://youtu.be/j80xaF6Lhk8?t=01h13m22s)



[so that makes sense to me](https://youtu.be/j80xaF6Lhk8?t=01h13m25s)



[I'm missing something](https://youtu.be/j80xaF6Lhk8?t=01h13m34s)



[maybe know when buuel return value is](https://youtu.be/j80xaF6Lhk8?t=01h13m39s)



[false I'm not crazy right and it gets](https://youtu.be/j80xaF6Lhk8?t=01h13m44s)



[unhappy about that something feels very](https://youtu.be/j80xaF6Lhk8?t=01h13m52s)



[wrong about this why would it start](https://youtu.be/j80xaF6Lhk8?t=01h13m54s)



[complaining on the return value of false](https://youtu.be/j80xaF6Lhk8?t=01h13m59s)



[Oh got it it's not complete oh oh I get](https://youtu.be/j80xaF6Lhk8?t=01h14m04s)



[it I get it I get it I get it so it](https://youtu.be/j80xaF6Lhk8?t=01h14m12s)



[wants it still wants that but it knows](https://youtu.be/j80xaF6Lhk8?t=01h14m14s)



[value source food gets value source -](https://youtu.be/j80xaF6Lhk8?t=01h14m20s)



[right so it's cool with that idea](https://youtu.be/j80xaF6Lhk8?t=01h14m28s)



[because it knows that after the return](https://youtu.be/j80xaF6Lhk8?t=01h14m31s)



[this guy has returned true](https://youtu.be/j80xaF6Lhk8?t=01h14m35s)



[so therefore this guy is not null](https://youtu.be/j80xaF6Lhk8?t=01h14m38s)



[alright so if I do maybe no one true I](https://youtu.be/j80xaF6Lhk8?t=01h14m40s)



[expect it to now be unhappy about down](https://youtu.be/j80xaF6Lhk8?t=01h14m44s)



[here thinking thinking thinking right so](https://youtu.be/j80xaF6Lhk8?t=01h14m46s)



[now it's unhappy because now it knows](https://youtu.be/j80xaF6Lhk8?t=01h14m50s)



[the return so it's unhappy about this](https://youtu.be/j80xaF6Lhk8?t=01h14m52s)



[because this one is not knowable up here](https://youtu.be/j80xaF6Lhk8?t=01h14m58s)



[that's what it's unhappy about](https://youtu.be/j80xaF6Lhk8?t=01h15m08s)



[I think we just do that that seemed that](https://youtu.be/j80xaF6Lhk8?t=01h15m16s)



[seems like the simplest of compiler](https://youtu.be/j80xaF6Lhk8?t=01h15m20s)



[trust me you're wrong maybe no one put](https://youtu.be/j80xaF6Lhk8?t=01h15m22s)



[this back before I before I make a](https://youtu.be/j80xaF6Lhk8?t=01h15m26s)



[mistake and leave it like that right I](https://youtu.be/j80xaF6Lhk8?t=01h15m28s)



[think I just tell the compiler hands off](https://youtu.be/j80xaF6Lhk8?t=01h15m30s)



[trust me I want to reuse this and I'll](https://youtu.be/j80xaF6Lhk8?t=01h15m32s)



[put this back to the VAR because that's](https://youtu.be/j80xaF6Lhk8?t=01h15m35s)



[how I found it okay next up on the](https://youtu.be/j80xaF6Lhk8?t=01h15m36s)



[chopping block simple set okay so what](https://youtu.be/j80xaF6Lhk8?t=01h15m40s)



[do we got going on here](https://youtu.be/j80xaF6Lhk8?t=01h15m44s)



[so we've got something about our](https://youtu.be/j80xaF6Lhk8?t=01h15m46s)



[interface so you collapse all right so](https://youtu.be/j80xaF6Lhk8?t=01h15m48s)



[something about the lability reference](https://youtu.be/j80xaF6Lhk8?t=01h15m53s)



[types and return type of nullable I](https://youtu.be/j80xaF6Lhk8?t=01h15m57s)



[symbol get by alias string alias does](https://youtu.be/j80xaF6Lhk8?t=01h16m00s)



[not match implemented member so get by](https://youtu.be/j80xaF6Lhk8?t=01h16m04s)



[alias string alias so let's look at this](https://youtu.be/j80xaF6Lhk8?t=01h16m09s)



[get by alias string alias okay that](https://youtu.be/j80xaF6Lhk8?t=01h16m16s)



[seems simple](https://youtu.be/j80xaF6Lhk8?t=01h16m20s)



[nonno nonno so what have we done wrong](https://youtu.be/j80xaF6Lhk8?t=01h16m21s)



[must be in here get by alias ah clearly](https://youtu.be/j80xaF6Lhk8?t=01h16m25s)



[can return a null well that's fairly](https://youtu.be/j80xaF6Lhk8?t=01h16m31s)



[obvious that this method is expected to](https://youtu.be/j80xaF6Lhk8?t=01h16m37s)



[return a knowable type so I think the](https://youtu.be/j80xaF6Lhk8?t=01h16m39s)



[solution here is simply to say yep](https://youtu.be/j80xaF6Lhk8?t=01h16m42s)



[Knowle it can be alright so we come back](https://youtu.be/j80xaF6Lhk8?t=01h16m45s)



[here that guys now happy next up okay so](https://youtu.be/j80xaF6Lhk8?t=01h16m49s)



[what do we got down here](https://youtu.be/j80xaF6Lhk8?t=01h16m55s)



[so we've got a alias already in use so](https://youtu.be/j80xaF6Lhk8?t=01h16m55s)



[this guy has an out string that's non](https://youtu.be/j80xaF6Lhk8?t=01h17m01s)



[knowable](https://youtu.be/j80xaF6Lhk8?t=01h17m05s)



[I think we just decorate this guy right](https://youtu.be/j80xaF6Lhk8?t=01h17m09s)



[maybe know when and I think I like I](https://youtu.be/j80xaF6Lhk8?t=01h17m13s)



[think I like doing it this way right](https://youtu.be/j80xaF6Lhk8?t=01h17m17s)



[declare the value as non-null right that](https://youtu.be/j80xaF6Lhk8?t=01h17m19s)



[way people can use nan old stuff but](https://youtu.be/j80xaF6Lhk8?t=01h17m23s)



[hint to the compiler hey on a false you](https://youtu.be/j80xaF6Lhk8?t=01h17m27s)



[really shouldn't be using the out](https://youtu.be/j80xaF6Lhk8?t=01h17m30s)



[parameter on a tryparse type method on a](https://youtu.be/j80xaF6Lhk8?t=01h17m31s)



[false return you anyway you shouldn't](https://youtu.be/j80xaF6Lhk8?t=01h17m34s)



[trust it right it's most of them say](https://youtu.be/j80xaF6Lhk8?t=01h17m36s)



[they're set to uninitialized or knoll or](https://youtu.be/j80xaF6Lhk8?t=01h17m39s)



[similar right so this sort of makes](https://youtu.be/j80xaF6Lhk8?t=01h17m41s)



[sense I think I might go back through](https://youtu.be/j80xaF6Lhk8?t=01h17m43s)



[and hunt out the other places where I](https://youtu.be/j80xaF6Lhk8?t=01h17m45s)



[did the tryparse by making this knowable](https://youtu.be/j80xaF6Lhk8?t=01h17m47s)



[and switch it to this so that they're](https://youtu.be/j80xaF6Lhk8?t=01h17m49s)



[not knowable](https://youtu.be/j80xaF6Lhk8?t=01h17m50s)



[I think that's cleaner okay again my](https://youtu.be/j80xaF6Lhk8?t=01h17m51s)



[opinion if people have other opinions on](https://youtu.be/j80xaF6Lhk8?t=01h17m55s)



[whether those are no lore not I would](https://youtu.be/j80xaF6Lhk8?t=01h17m57s)



[love to hear it okay I think this is](https://youtu.be/j80xaF6Lhk8?t=01h17m58s)



[actually where we were earlier huzzah](https://youtu.be/j80xaF6Lhk8?t=01h18m01s)



[we've worked our way back around in a](https://youtu.be/j80xaF6Lhk8?t=01h18m03s)



[circle so here we are here so parent](https://youtu.be/j80xaF6Lhk8?t=01h18m04s)



[results so parent can be null but this](https://youtu.be/j80xaF6Lhk8?t=01h18m09s)



[was the question of can we get into here](https://youtu.be/j80xaF6Lhk8?t=01h18m13s)



[and I believe this is where John had](https://youtu.be/j80xaF6Lhk8?t=01h18m15s)



[suggested live unit testing and then I](https://youtu.be/j80xaF6Lhk8?t=01h18m19s)



[got all kinds of all kinds of confused](https://youtu.be/j80xaF6Lhk8?t=01h18m21s)



[right so I think the simple answer is we](https://youtu.be/j80xaF6Lhk8?t=01h18m24s)



[know it's not null at least in all of](https://youtu.be/j80xaF6Lhk8?t=01h18m28s)



[our tests this is internal so we can](https://youtu.be/j80xaF6Lhk8?t=01h18m30s)



[certainly make certain assumptions about](https://youtu.be/j80xaF6Lhk8?t=01h18m37s)



[this right this isn't something that](https://youtu.be/j80xaF6Lhk8?t=01h18m40s)



[somebody from the outside can make a](https://youtu.be/j80xaF6Lhk8?t=01h18m41s)



[mistake or use with c-sharp 7 or that](https://youtu.be/j80xaF6Lhk8?t=01h18m43s)



[kind of thing](https://youtu.be/j80xaF6Lhk8?t=01h18m45s)



[so it's somewhat restricted so I don't](https://youtu.be/j80xaF6Lhk8?t=01h18m48s)



[have to stress too much about that and](https://youtu.be/j80xaF6Lhk8?t=01h18m52s)



[so the question then comes is on this](https://youtu.be/j80xaF6Lhk8?t=01h18m54s)



[convert is it possible to call this on](https://youtu.be/j80xaF6Lhk8?t=01h18m56s)



[an object where the parent is null since](https://youtu.be/j80xaF6Lhk8?t=01h18m59s)



[the parent will only be null in the case](https://youtu.be/j80xaF6Lhk8?t=01h19m01s)



[of the root command all right and so](https://youtu.be/j80xaF6Lhk8?t=01h19m04s)



[and this is where I think the answer is](https://youtu.be/j80xaF6Lhk8?t=01h19m11s)



[no right because in this guy's case I](https://youtu.be/j80xaF6Lhk8?t=01h19m14s)



[earn a bad bad bad man no need to just](https://youtu.be/j80xaF6Lhk8?t=01h19m19s)



[start closing things so in this guy's](https://youtu.be/j80xaF6Lhk8?t=01h19m23s)



[case here he's iterating over his](https://youtu.be/j80xaF6Lhk8?t=01h19m26s)



[children so the children of this command](https://youtu.be/j80xaF6Lhk8?t=01h19m28s)



[result are clearly not going to be the](https://youtu.be/j80xaF6Lhk8?t=01h19m34s)



[route command because they're children](https://youtu.be/j80xaF6Lhk8?t=01h19m35s)



[of something else therefore they are not](https://youtu.be/j80xaF6Lhk8?t=01h19m37s)



[the route same thing applies to the](https://youtu.be/j80xaF6Lhk8?t=01h19m39s)



[options one it has a similar setup why](https://youtu.be/j80xaF6Lhk8?t=01h19m42s)



[will you not jump me to the thing right](https://youtu.be/j80xaF6Lhk8?t=01h19m45s)



[iterating over its children to build it](https://youtu.be/j80xaF6Lhk8?t=01h19m47s)



[up right](https://youtu.be/j80xaF6Lhk8?t=01h19m49s)



[this argument result is interesting I do](https://youtu.be/j80xaF6Lhk8?t=01h19m51s)



[wonder if it is possible for this one](https://youtu.be/j80xaF6Lhk8?t=01h19m56s)



[because this guy clearly has a nullable](https://youtu.be/j80xaF6Lhk8?t=01h20m03s)



[parent so is it possible hit that so](https://youtu.be/j80xaF6Lhk8?t=01h20m06s)



[harsh result visitor](https://youtu.be/j80xaF6Lhk8?t=01h20m21s)



[argument results this will obviously](https://youtu.be/j80xaF6Lhk8?t=01h20m29s)



[never pass a null because though it is](https://youtu.be/j80xaF6Lhk8?t=01h20m31s)



[technically possible to invoke an](https://youtu.be/j80xaF6Lhk8?t=01h20m35s)



[instance member and have this be null](https://youtu.be/j80xaF6Lhk8?t=01h20m38s)



[not something you should ever check for](https://youtu.be/j80xaF6Lhk8?t=01h20m40s)



[for anybody wants a fun brain teaser try](https://youtu.be/j80xaF6Lhk8?t=01h20m46s)



[and invoke an instance method where this](https://youtu.be/j80xaF6Lhk8?t=01h20m50s)



[is null it's really fun here's a hint it](https://youtu.be/j80xaF6Lhk8?t=01h20m51s)



[involves delegates yeah because that](https://youtu.be/j80xaF6Lhk8?t=01h20m56s)



[will doing things like that is one of](https://youtu.be/j80xaF6Lhk8?t=01h21m02s)



[those ways to be evil in c-sharp I've](https://youtu.be/j80xaF6Lhk8?t=01h21m04s)



[actually thought about doing it a talk](https://youtu.be/j80xaF6Lhk8?t=01h21m07s)



[at some point on just all of the](https://youtu.be/j80xaF6Lhk8?t=01h21m09s)



[horrible horrible things you can do in](https://youtu.be/j80xaF6Lhk8?t=01h21m12s)



[c-sharp that you should never do in real](https://youtu.be/j80xaF6Lhk8?t=01h21m14s)



[life just to be able to write the code](https://youtu.be/j80xaF6Lhk8?t=01h21m16s)



[for them because it's really unfortunate](https://youtu.be/j80xaF6Lhk8?t=01h21m18s)



[that there's all these great features in](https://youtu.be/j80xaF6Lhk8?t=01h21m21s)



[c-sharp and you never get to use them in](https://youtu.be/j80xaF6Lhk8?t=01h21m23s)



[a real project because they are highly](https://youtu.be/j80xaF6Lhk8?t=01h21m24s)



[frowned upon highly frowned upon one of](https://youtu.be/j80xaF6Lhk8?t=01h21m27s)



[my poor teammates I subjected him to an](https://youtu.be/j80xaF6Lhk8?t=01h21m33s)



[implementation I did of ienumerable that](https://youtu.be/j80xaF6Lhk8?t=01h21m36s)



[uses pointers because I had to use](https://youtu.be/j80xaF6Lhk8?t=01h21m39s)



[pointers and d'arnot I wanted a for each](https://youtu.be/j80xaF6Lhk8?t=01h21m42s)



[loop and so I had to write my own](https://youtu.be/j80xaF6Lhk8?t=01h21m44s)



[enumerable and it was fun and I'm not](https://youtu.be/j80xaF6Lhk8?t=01h21m47s)



[sure he thought it was as fun as I did](https://youtu.be/j80xaF6Lhk8?t=01h21m50s)



[okay so I don't think I'm really really](https://youtu.be/j80xaF6Lhk8?t=01h21m53s)



[tempted to just flag this guy and just](https://youtu.be/j80xaF6Lhk8?t=01h22m00s)



[tell the compiler hands off like I'm](https://youtu.be/j80xaF6Lhk8?t=01h22m04s)



[really tempted to do that](https://youtu.be/j80xaF6Lhk8?t=01h22m06s)



[really really tempted to do that should](https://youtu.be/j80xaF6Lhk8?t=01h22m13s)



[check arity let's let's just see right](https://youtu.be/j80xaF6Lhk8?t=01h22m16s)



[so if parent result is I option result](https://youtu.be/j80xaF6Lhk8?t=01h22m19s)



[an option result is implicit so that](https://youtu.be/j80xaF6Lhk8?t=01h22m23s)



[doesn't that doesn't necessarily](https://youtu.be/j80xaF6Lhk8?t=01h22m25s)



[guarantee that we skipped this case at](https://youtu.be/j80xaF6Lhk8?t=01h22m26s)



[all but how would we get here because](https://youtu.be/j80xaF6Lhk8?t=01h22m28s)



[we'd have to come in through an argument](https://youtu.be/j80xaF6Lhk8?t=01h22m33s)



[result I don't think it's possible](https://youtu.be/j80xaF6Lhk8?t=01h22m35s)



[because you'd have to have an argument](https://youtu.be/j80xaF6Lhk8?t=01h22m36s)



[result that was at the root and I don't](https://youtu.be/j80xaF6Lhk8?t=01h22m39s)



[think you can have an RA the commander](https://youtu.be/j80xaF6Lhk8?t=01h22m42s)



[is the only one where the parents should](https://youtu.be/j80xaF6Lhk8?t=01h22m44s)



[be null everyone else should have a](https://youtu.be/j80xaF6Lhk8?t=01h22m46s)



[parent and it's not possible have an](https://youtu.be/j80xaF6Lhk8?t=01h22m48s)



[argument through I'm going to say it's](https://youtu.be/j80xaF6Lhk8?t=01h22m51s)



[it's not possible and the the unit test](https://youtu.be/j80xaF6Lhk8?t=01h22m52s)



[obviously don't have a null case that](https://youtu.be/j80xaF6Lhk8?t=01h22m55s)



[comes through here otherwise this line](https://youtu.be/j80xaF6Lhk8?t=01h22m58s)



[would be throwing right so cuz you can](https://youtu.be/j80xaF6Lhk8?t=01h22m59s)



[put these annotations in and again this](https://youtu.be/j80xaF6Lhk8?t=01h23m03s)



[does not stop anybody from just passing](https://youtu.be/j80xaF6Lhk8?t=01h23m04s)



[null in right just because you declare](https://youtu.be/j80xaF6Lhk8?t=01h23m07s)



[something is non knowable just means](https://youtu.be/j80xaF6Lhk8?t=01h23m09s)



[that if somebody tries to pass Noland](https://youtu.be/j80xaF6Lhk8?t=01h23m11s)



[and they're using the later latest](https://youtu.be/j80xaF6Lhk8?t=01h23m13s)



[c-sharp a compiler they'll get a warning](https://youtu.be/j80xaF6Lhk8?t=01h23m15s)



[doesn't stop them at all they can still](https://youtu.be/j80xaF6Lhk8?t=01h23m17s)



[do it right so proof is in the pudding](https://youtu.be/j80xaF6Lhk8?t=01h23m19s)



[not null gets null right so I can](https://youtu.be/j80xaF6Lhk8?t=01h23m22s)



[certainly pass null into it non knowable](https://youtu.be/j80xaF6Lhk8?t=01h23m28s)



[string and to make the warning go away I](https://youtu.be/j80xaF6Lhk8?t=01h23m32s)



[can tell the compiler hands-off](https://youtu.be/j80xaF6Lhk8?t=01h23m33s)



[trust me this is Nola's not no I](https://youtu.be/j80xaF6Lhk8?t=01h23m35s)



[shouldn't but you can totally do that](https://youtu.be/j80xaF6Lhk8?t=01h23m39s)



[okay getting sidetracked next up next up](https://youtu.be/j80xaF6Lhk8?t=01h23m41s)



[argument result extensions okay so we've](https://youtu.be/j80xaF6Lhk8?t=01h23m45s)



[got a generic and what are you squawking](https://youtu.be/j80xaF6Lhk8?t=01h23m49s)



[about possible no reference return so](https://youtu.be/j80xaF6Lhk8?t=01h23m52s)



[get value or default right so this is](https://youtu.be/j80xaF6Lhk8?t=01h23m55s)



[going to pull through and I think we are](https://youtu.be/j80xaF6Lhk8?t=01h24m03s)



[this is the guy we looked at here right](https://youtu.be/j80xaF6Lhk8?t=01h24m06s)



[and I think this is the same solution](https://youtu.be/j80xaF6Lhk8?t=01h24m08s)



[right is this guy is getting value or](https://youtu.be/j80xaF6Lhk8?t=01h24m10s)



[default I don't want to declare t is](https://youtu.be/j80xaF6Lhk8?t=01h24m13s)



[knowable but I do want to say if you if](https://youtu.be/j80xaF6Lhk8?t=01h24m15s)



[you asked for an object you might get a](https://youtu.be/j80xaF6Lhk8?t=01h24m19s)



[knowable object back Nola's totally](https://youtu.be/j80xaF6Lhk8?t=01h24m20s)



[possible here but I don't want to change](https://youtu.be/j80xaF6Lhk8?t=01h24m24s)



[this this guy however I think I do want](https://youtu.be/j80xaF6Lhk8?t=01h24m25s)



[to change if you're using this you](https://youtu.be/j80xaF6Lhk8?t=01h24m29s)



[should be told that Noll is very valid](https://youtu.be/j80xaF6Lhk8?t=01h24m32s)



[okay next up air list and these types of](https://youtu.be/j80xaF6Lhk8?t=01h24m36s)



[changes this is how this number may not](https://youtu.be/j80xaF6Lhk8?t=01h24m41s)



[be going down because we've clearly](https://youtu.be/j80xaF6Lhk8?t=01h24m44s)



[solved more than seven we've just gotten](https://youtu.be/j80xaF6Lhk8?t=01h24m45s)



[ourselves back up okay so this is a](https://youtu.be/j80xaF6Lhk8?t=01h24m47s)



[great case where I'm gonna flip it maybe](https://youtu.be/j80xaF6Lhk8?t=01h24m51s)



[know when false right and then I'm gonna](https://youtu.be/j80xaF6Lhk8?t=01h24m54s)



[switch you over to be that right because](https://youtu.be/j80xaF6Lhk8?t=01h24m59s)



[I think that'll help clean up some of](https://youtu.be/j80xaF6Lhk8?t=01h25m01s)



[this so we've got a couple things in](https://youtu.be/j80xaF6Lhk8?t=01h25m02s)



[here so maybe no one false oh shoot](https://youtu.be/j80xaF6Lhk8?t=01h25m05s)



[[Music]](https://youtu.be/j80xaF6Lhk8?t=01h25m14s)



[actually I don't even know if we can](https://youtu.be/j80xaF6Lhk8?t=01h25m16s)



[make any annotation assumption right](https://youtu.be/j80xaF6Lhk8?t=01h25m18s)



[mostly because this is a get value or](https://youtu.be/j80xaF6Lhk8?t=01h25m22s)



[default the exact method we just looked](https://youtu.be/j80xaF6Lhk8?t=01h25m24s)



[at all right so this guy can clearly set](https://youtu.be/j80xaF6Lhk8?t=01h25m26s)



[a null into value and ya an argument](https://youtu.be/j80xaF6Lhk8?t=01h25m30s)



[conversion results this guy is what he](https://youtu.be/j80xaF6Lhk8?t=01h25m37s)



[has an index or alias set and this is](https://youtu.be/j80xaF6Lhk8?t=01h25m42s)



[the same thing right so get by alias can](https://youtu.be/j80xaF6Lhk8?t=01h25m46s)



[return a knowable all right and so and](https://youtu.be/j80xaF6Lhk8?t=01h25m48s)



[actually I think I want to change this I](https://youtu.be/j80xaF6Lhk8?t=01h25m54s)



[think I want to do this hey Raymond out](https://youtu.be/j80xaF6Lhk8?t=01h25m58s)



[you doing let's see here change the](https://youtu.be/j80xaF6Lhk8?t=01h26m02s)



[return I think we want to do this and](https://youtu.be/j80xaF6Lhk8?t=01h26m06s)



[declare it as maybe no because I don't](https://youtu.be/j80xaF6Lhk8?t=01h26m09s)



[think I want to declare that T is a](https://youtu.be/j80xaF6Lhk8?t=01h26m12s)



[knowable type simply because if T is](https://youtu.be/j80xaF6Lhk8?t=01h26m14s)



[declared as an int and I realize we](https://youtu.be/j80xaF6Lhk8?t=01h26m18s)



[don't have that case here right let's](https://youtu.be/j80xaF6Lhk8?t=01h26m20s)



[see get by alias what are you squawking](https://youtu.be/j80xaF6Lhk8?t=01h26m22s)



[about](https://youtu.be/j80xaF6Lhk8?t=01h26m27s)



[let's see return is not a valid](https://youtu.be/j80xaF6Lhk8?t=01h26m29s)



[attribute for this declaration](https://youtu.be/j80xaF6Lhk8?t=01h26m33s)



[why what are you doing how how does one](https://youtu.be/j80xaF6Lhk8?t=01h26m35s)



[declare this then Oh like that okay](https://youtu.be/j80xaF6Lhk8?t=01h26m54s)



[that's interesting I never considered](https://youtu.be/j80xaF6Lhk8?t=01h27m00s)



[that this wasn't a return type because](https://youtu.be/j80xaF6Lhk8?t=01h27m02s)



[this is an operator perhaps if this is](https://youtu.be/j80xaF6Lhk8?t=01h27m06s)



[an indexing operator then the operator](https://youtu.be/j80xaF6Lhk8?t=01h27m09s)



[doesn't have necessarily a return value](https://youtu.be/j80xaF6Lhk8?t=01h27m12s)



[because it's not necessarily a normal](https://youtu.be/j80xaF6Lhk8?t=01h27m14s)



[method I guess okay I guess I can get on](https://youtu.be/j80xaF6Lhk8?t=01h27m15s)



[board with that uh let's see here](https://youtu.be/j80xaF6Lhk8?t=01h27m20s)



[err list I already lost my place okay so](https://youtu.be/j80xaF6Lhk8?t=01h27m24s)



[the indexer clearly can return null this](https://youtu.be/j80xaF6Lhk8?t=01h27m28s)



[guy can return null so I think the](https://youtu.be/j80xaF6Lhk8?t=01h27m32s)



[solution here is no problem](https://youtu.be/j80xaF6Lhk8?t=01h27m34s)



[alright why do you think that is not](https://youtu.be/j80xaF6Lhk8?t=01h27m36s)



[conditional access qualifiers known not](https://youtu.be/j80xaF6Lhk8?t=01h27m41s)



[to be null because this guy here is a](https://youtu.be/j80xaF6Lhk8?t=01h27m44s)



[result set or an alias set of these no](https://youtu.be/j80xaF6Lhk8?t=01h27m51s)



[no no no okay so hold on hold on so](https://youtu.be/j80xaF6Lhk8?t=01h28m00s)



[object who gets I think this is just a](https://youtu.be/j80xaF6Lhk8?t=01h28m07s)



[bad usage of the attribute like even](https://youtu.be/j80xaF6Lhk8?t=01h28m10s)



[though it even though it worked right](https://youtu.be/j80xaF6Lhk8?t=01h28m13s)



[because we know that the indexer should](https://youtu.be/j80xaF6Lhk8?t=01h28m15s)



[be the same as get my alias right and we](https://youtu.be/j80xaF6Lhk8?t=01h28m17s)



[know that one set up](https://youtu.be/j80xaF6Lhk8?t=01h28m21s)



[so want this to work](https://youtu.be/j80xaF6Lhk8?t=01h28m26s)



[so simit corn so what's interesting to](https://youtu.be/j80xaF6Lhk8?t=01h28m34s)



[me is that it's telling me that this](https://youtu.be/j80xaF6Lhk8?t=01h28m37s)



[expression is known to not be null which](https://youtu.be/j80xaF6Lhk8?t=01h28m40s)



[we thee seems to go against what this](https://youtu.be/j80xaF6Lhk8?t=01h28m45s)



[may be no okay so next up we're going to](https://youtu.be/j80xaF6Lhk8?t=01h28m55s)



[look at nope not that one oh let's see](https://youtu.be/j80xaF6Lhk8?t=01h28m59s)



[here so I think I put this in the chat](https://youtu.be/j80xaF6Lhk8?t=01h29m03s)



[earlier but so Raymond what are we](https://youtu.be/j80xaF6Lhk8?t=01h29m06s)



[working on here I know I'm late to the](https://youtu.be/j80xaF6Lhk8?t=01h29m10s)



[party](https://youtu.be/j80xaF6Lhk8?t=01h29m11s)



[no problem Raymond I I bounce around and](https://youtu.be/j80xaF6Lhk8?t=01h29m11s)



[do stuff late so the the project in](https://youtu.be/j80xaF6Lhk8?t=01h29m15s)



[question is a system command line I am](https://youtu.be/j80xaF6Lhk8?t=01h29m17s)



[adding the c-sharp eight nullable](https://youtu.be/j80xaF6Lhk8?t=01h29m21s)



[reference types so that github link is](https://youtu.be/j80xaF6Lhk8?t=01h29m24s)



[my branch of the project where I've been](https://youtu.be/j80xaF6Lhk8?t=01h29m27s)



[working just getting just trying to do](https://youtu.be/j80xaF6Lhk8?t=01h29m31s)



[this so we started off with yesterday](https://youtu.be/j80xaF6Lhk8?t=01h29m34s)



[and early this morning I sniped all of](https://youtu.be/j80xaF6Lhk8?t=01h29m38s)



[the easy ones and we've been working](https://youtu.be/j80xaF6Lhk8?t=01h29m40s)



[through the rest of the hard ones](https://youtu.be/j80xaF6Lhk8?t=01h29m44s)



[so this Docs page here is all of the](https://youtu.be/j80xaF6Lhk8?t=01h29m45s)



[fancy new annotations that go along with](https://youtu.be/j80xaF6Lhk8?t=01h29m50s)



[the c-sharp eight Noble reference types](https://youtu.be/j80xaF6Lhk8?t=01h29m52s)



[you will note this here right if you go](https://youtu.be/j80xaF6Lhk8?t=01h29m56s)



[back into old yielding days no show up I](https://youtu.be/j80xaF6Lhk8?t=01h30m00s)



[was kind of hoping that the maybe no](https://youtu.be/j80xaF6Lhk8?t=01h30m04s)



[specifies an output maybe no even if the](https://youtu.be/j80xaF6Lhk8?t=01h30m08s)



[corresponding type disallows it yup that](https://youtu.be/j80xaF6Lhk8?t=01h30m10s)



[sounds kind of like what I want](https://youtu.be/j80xaF6Lhk8?t=01h30m15s)



[why so this is allowed on fields](https://youtu.be/j80xaF6Lhk8?t=01h30m21s)



[parameters properties and return values](https://youtu.be/j80xaF6Lhk8?t=01h30m27s)



[I want that one so why does this not](https://youtu.be/j80xaF6Lhk8?t=01h30m30s)



[work here is it because the type of tea](https://youtu.be/j80xaF6Lhk8?t=01h30m36s)



[switch it to of I'm not sure I follow I](https://youtu.be/j80xaF6Lhk8?t=01h30m50s)



[might](https://youtu.be/j80xaF6Lhk8?t=01h30m58s)



[ah switch to PC I think the reason is](https://youtu.be/j80xaF6Lhk8?t=01h31m04s)



[this guy here is returning is because](https://youtu.be/j80xaF6Lhk8?t=01h31m10s)



[this is a non knowable type no problem](https://youtu.be/j80xaF6Lhk8?t=01h31m20s)



[Raymond I eventually translate it it](https://youtu.be/j80xaF6Lhk8?t=01h31m24s)



[took me a minute to true to get all the](https://youtu.be/j80xaF6Lhk8?t=01h31m26s)



[way through it but I got there I am slow](https://youtu.be/j80xaF6Lhk8?t=01h31m28s)



[but I've got one mountain doing me and](https://youtu.be/j80xaF6Lhk8?t=01h31m30s)



[one more worth to go so so I'm not um so](https://youtu.be/j80xaF6Lhk8?t=01h31m33s)



[this this is still okay](https://youtu.be/j80xaF6Lhk8?t=01h31m40s)



[we got to get this back down to just the](https://youtu.be/j80xaF6Lhk8?t=01h31m43s)



[things I care about noop noop this right](https://youtu.be/j80xaF6Lhk8?t=01h31m44s)



[so here so here is the interesting one](https://youtu.be/j80xaF6Lhk8?t=01h31m51s)



[right is it is convinced that I don't](https://youtu.be/j80xaF6Lhk8?t=01h31m53s)



[need this all right](https://youtu.be/j80xaF6Lhk8?t=01h31m56s)



[Auto code says remove conditional access](https://youtu.be/j80xaF6Lhk8?t=01h31m57s)



[and I don't understand why because as](https://youtu.be/j80xaF6Lhk8?t=01h32m01s)



[soon as I remove conditional access](https://youtu.be/j80xaF6Lhk8?t=01h32m04s)



[possible null reference exception occurs](https://youtu.be/j80xaF6Lhk8?t=01h32m06s)



[it's like it both knows and doesn't know](https://youtu.be/j80xaF6Lhk8?t=01h32m17s)



[it's bothering me and I'm wondering if](https://youtu.be/j80xaF6Lhk8?t=01h32m22s)



[I'm wondering if this is a resharper ism](https://youtu.be/j80xaF6Lhk8?t=01h32m27s)



[I wonder if that is the case so I'm](https://youtu.be/j80xaF6Lhk8?t=01h32m32s)



[gonna turn this I'm gonna leave this as](https://youtu.be/j80xaF6Lhk8?t=01h32m42s)



[is and assume that this is a resharper](https://youtu.be/j80xaF6Lhk8?t=01h32m44s)



[ism for now but I would be very curious](https://youtu.be/j80xaF6Lhk8?t=01h32m46s)



[if anyone has any insight or ideas to](https://youtu.be/j80xaF6Lhk8?t=01h32m48s)



[try because the fact that the fact that](https://youtu.be/j80xaF6Lhk8?t=01h32m51s)



[it seems to hint that I don't need this](https://youtu.be/j80xaF6Lhk8?t=01h32m56s)



[on a generic method that is very clearly](https://youtu.be/j80xaF6Lhk8?t=01h32m58s)



[decorated with the return type possibly](https://youtu.be/j80xaF6Lhk8?t=01h33m02s)



[being null all right you'll note that T](https://youtu.be/j80xaF6Lhk8?t=01h33m06s)



[is a class I do wonder if there's a](https://youtu.be/j80xaF6Lhk8?t=01h33m11s)



[potential here right like we're not](https://youtu.be/j80xaF6Lhk8?t=01h33m18s)



[preventing ooh contains get by alias Oh](https://youtu.be/j80xaF6Lhk8?t=01h33m21s)



[so here's an interesting one](https://youtu.be/j80xaF6Lhk8?t=01h33m29s)



[alias is not null here](https://youtu.be/j80xaF6Lhk8?t=01h33m31s)



[I'm starting to think that this needs to](https://youtu.be/j80xaF6Lhk8?t=01h33m37s)



[be like this](https://youtu.be/j80xaF6Lhk8?t=01h33m39s)



[that needs to be like this because that](https://youtu.be/j80xaF6Lhk8?t=01h33m46s)



[fit okay I'm thinking that's the](https://youtu.be/j80xaF6Lhk8?t=01h33m48s)



[solution right ditch the attribute that](https://youtu.be/j80xaF6Lhk8?t=01h33m51s)



[fixes this this now understands what I](https://youtu.be/j80xaF6Lhk8?t=01h33m53s)



[mean I think that makes more sense](https://youtu.be/j80xaF6Lhk8?t=01h33m56s)



[because I think the issue is the generic](https://youtu.be/j80xaF6Lhk8?t=01h33m59s)



[constraint on T is being tied to class](https://youtu.be/j80xaF6Lhk8?t=01h34m03s)



[and I don't want to tie it to something](https://youtu.be/j80xaF6Lhk8?t=01h34m07s)



[like no local class right like that that](https://youtu.be/j80xaF6Lhk8?t=01h34m10s)



[doesn't make sense where I can abuse the](https://youtu.be/j80xaF6Lhk8?t=01h34m12s)



[non knowable I'd prefer to all right I](https://youtu.be/j80xaF6Lhk8?t=01h34m15s)



[think that's what I want but clearly](https://youtu.be/j80xaF6Lhk8?t=01h34m19s)



[things like checking and lookup it's](https://youtu.be/j80xaF6Lhk8?t=01h34m22s)



[possible for it to not be there](https://youtu.be/j80xaF6Lhk8?t=01h34m24s)



[therefore null should be valid return](https://youtu.be/j80xaF6Lhk8?t=01h34m26s)



[okay we're going with that that's at](https://youtu.be/j80xaF6Lhk8?t=01h34m29s)



[least an answer I can justify noble C](https://youtu.be/j80xaF6Lhk8?t=01h34m32s)



[sharp eight links sure I assume so for](https://youtu.be/j80xaF6Lhk8?t=01h34m38s)



[you Raymond there's the there's the repo](https://youtu.be/j80xaF6Lhk8?t=01h34m42s)



[and the branch that I'm on and if your](https://youtu.be/j80xaF6Lhk8?t=01h34m46s)



[let me actually switch because I think I](https://youtu.be/j80xaF6Lhk8?t=01h34m49s)



[have the where is it](https://youtu.be/j80xaF6Lhk8?t=01h34m52s)



[do-do-do-do-do so this is this trying to](https://youtu.be/j80xaF6Lhk8?t=01h35m00s)



[decide so I can just pull it over here](https://youtu.be/j80xaF6Lhk8?t=01h35m07s)



[right so there's there's two there's two](https://youtu.be/j80xaF6Lhk8?t=01h35m08s)



[potential reasonable reasonable ones](https://youtu.be/j80xaF6Lhk8?t=01h35m12s)



[here right and it's probably just as](https://youtu.be/j80xaF6Lhk8?t=01h35m14s)



[easy to pull up the your favorite being](https://youtu.be/j80xaF6Lhk8?t=01h35m17s)



[search engine and punch in c-sharp eight](https://youtu.be/j80xaF6Lhk8?t=01h35m23s)



[specification right and then there's](https://youtu.be/j80xaF6Lhk8?t=01h35m27s)



[this one here alright I usually just try](https://youtu.be/j80xaF6Lhk8?t=01h35m30s)



[to hunt through the docks pages because](https://youtu.be/j80xaF6Lhk8?t=01h35m33s)



[the docks pages on the microsoft docks](https://youtu.be/j80xaF6Lhk8?t=01h35m34s)



[are actually fairly good uncovering this](https://youtu.be/j80xaF6Lhk8?t=01h35m37s)



[so this is the design with notable](https://youtu.be/j80xaF6Lhk8?t=01h35m40s)



[references is sort of a walkthrough of](https://youtu.be/j80xaF6Lhk8?t=01h35m42s)



[how do i lay this stuff out and then the](https://youtu.be/j80xaF6Lhk8?t=01h35m44s)



[spec is all of the the gory details and](https://youtu.be/j80xaF6Lhk8?t=01h35m47s)



[then you can find the ad attributes](https://youtu.be/j80xaF6Lhk8?t=01h35m50s)



[well okay so this guy here so value name](https://youtu.be/j80xaF6Lhk8?t=01h35m53s)



[is potentially knowable so let's let's](https://youtu.be/j80xaF6Lhk8?t=01h35m57s)



[take a quick gander at this and figure](https://youtu.be/j80xaF6Lhk8?t=01h36m01s)



[out why why value name is marked as](https://youtu.be/j80xaF6Lhk8?t=01h36m04s)



[knowable because there is a potential](https://youtu.be/j80xaF6Lhk8?t=01h36m08s)



[fix where we just make it not knowable](https://youtu.be/j80xaF6Lhk8?t=01h36m10s)



[and we're done if that is reasonable so](https://youtu.be/j80xaF6Lhk8?t=01h36m12s)



[that's a getter getter come on show me](https://youtu.be/j80xaF6Lhk8?t=01h36m15s)



[something interesting so one this is an](https://youtu.be/j80xaF6Lhk8?t=01h36m20s)



[argument for it being alright because](https://youtu.be/j80xaF6Lhk8?t=01h36m24s)



[there was clearly an explicit check for](https://youtu.be/j80xaF6Lhk8?t=01h36m25s)



[it so that strongly hints to me that](https://youtu.be/j80xaF6Lhk8?t=01h36m28s)



[Noll is a very valid value there all](https://youtu.be/j80xaF6Lhk8?t=01h36m32s)



[right and so there's some checks inside](https://youtu.be/j80xaF6Lhk8?t=01h36m35s)



[of property descriptor as well parsing](https://youtu.be/j80xaF6Lhk8?t=01h36m37s)



[command result I think this is just I](https://youtu.be/j80xaF6Lhk8?t=01h36m41s)



[think this is just a bug right I think](https://youtu.be/j80xaF6Lhk8?t=01h36m45s)



[this is just a case where we didn't](https://youtu.be/j80xaF6Lhk8?t=01h36m50s)



[account for the fact that this could](https://youtu.be/j80xaF6Lhk8?t=01h36m53s)



[theoretically be null so the simple the](https://youtu.be/j80xaF6Lhk8?t=01h36m55s)



[simple answer right is you do something](https://youtu.be/j80xaF6Lhk8?t=01h37m00s)



[like this right but if we're going to do](https://youtu.be/j80xaF6Lhk8?t=01h37m02s)



[that right and have effectively this](https://youtu.be/j80xaF6Lhk8?t=01h37m06s)



[thing short-circuit on the null case it](https://youtu.be/j80xaF6Lhk8?t=01h37m10s)



[stands to reason that we shouldn't](https://youtu.be/j80xaF6Lhk8?t=01h37m12s)



[iterate over our arguments if this guy](https://youtu.be/j80xaF6Lhk8?t=01h37m15s)



[is normal so I'm going to propose that](https://youtu.be/j80xaF6Lhk8?t=01h37m18s)



[we do if value descriptor dot value name](https://youtu.be/j80xaF6Lhk8?t=01h37m22s)



[is string you name right so we're gonna](https://youtu.be/j80xaF6Lhk8?t=01h37m27s)



[pull this guy out check on non null](https://youtu.be/j80xaF6Lhk8?t=01h37m31s)



[types boom and then down here we'll just](https://youtu.be/j80xaF6Lhk8?t=01h37m33s)



[use value name so ignore and then this](https://youtu.be/j80xaF6Lhk8?t=01h37m38s)



[equals equals true is no longer a thing](https://youtu.be/j80xaF6Lhk8?t=01h37m44s)



[right so pattern match the string out to](https://youtu.be/j80xaF6Lhk8?t=01h37m46s)



[verify non null and we'll only iterate](https://youtu.be/j80xaF6Lhk8?t=01h37m49s)



[if we actually have to and unit tests](https://youtu.be/j80xaF6Lhk8?t=01h37m51s)



[confirm I didn't break anything yeah so](https://youtu.be/j80xaF6Lhk8?t=01h37m55s)



[it is worth noting that this little](https://youtu.be/j80xaF6Lhk8?t=01h37m59s)



[squiggly that you see on this is string](https://youtu.be/j80xaF6Lhk8?t=01h38m01s)



[this is a JetBrains ism](https://youtu.be/j80xaF6Lhk8?t=01h38m03s)



[that they really really like you to use](https://youtu.be/j80xaF6Lhk8?t=01h38m06s)



[this pattern and I really don't like it](https://youtu.be/j80xaF6Lhk8?t=01h38m09s)



[because it feels like a VAR I like that](https://youtu.be/j80xaF6Lhk8?t=01h38m14s)



[better and I don't understand why they](https://youtu.be/j80xaF6Lhk8?t=01h38m19s)



[so if somebody knows why they suggest](https://youtu.be/j80xaF6Lhk8?t=01h38m23s)



[that over the type I would be very](https://youtu.be/j80xaF6Lhk8?t=01h38m26s)



[curious to understand it actually do](https://youtu.be/j80xaF6Lhk8?t=01h38m28s)



[they have a](https://youtu.be/j80xaF6Lhk8?t=01h38m31s)



[[Music]](https://youtu.be/j80xaF6Lhk8?t=01h38m33s)



[isn't there a some for some of the](https://youtu.be/j80xaF6Lhk8?t=01h38m35s)



[resharper ones they have a why is](https://youtu.be/j80xaF6Lhk8?t=01h38m40s)



[resharper suggesting this that's always](https://youtu.be/j80xaF6Lhk8?t=01h38m41s)



[handy and I would love to understand the](https://youtu.be/j80xaF6Lhk8?t=01h38m44s)



[reason why this is by default that](https://youtu.be/j80xaF6Lhk8?t=01h38m46s)



[beyond just a minimum of the suggestion](https://youtu.be/j80xaF6Lhk8?t=01h38m51s)



[right on my other machine I've](https://youtu.be/j80xaF6Lhk8?t=01h38m54s)



[downgraded it because it annoys me okay](https://youtu.be/j80xaF6Lhk8?t=01h38m55s)



[here list up next one down so we handled](https://youtu.be/j80xaF6Lhk8?t=01h38m59s)



[that one that one let's keep going](https://youtu.be/j80xaF6Lhk8?t=01h39m03s)



[possible no reference returns so get](https://youtu.be/j80xaF6Lhk8?t=01h39m06s)



[value or default this guy let's see so](https://youtu.be/j80xaF6Lhk8?t=01h39m09s)



[he comes in he asks for it](https://youtu.be/j80xaF6Lhk8?t=01h39m15s)



[single or default so here's one that](https://youtu.be/j80xaF6Lhk8?t=01h39m20s)



[just looks straight up like a bug to me](https://youtu.be/j80xaF6Lhk8?t=01h39m25s)



[right like so here's the hard part right](https://youtu.be/j80xaF6Lhk8?t=01h39m27s)



[the VAR is hiding it this is an argument](https://youtu.be/j80xaF6Lhk8?t=01h39m28s)



[conversion result but it's a single or](https://youtu.be/j80xaF6Lhk8?t=01h39m32s)



[default the or default case worries me](https://youtu.be/j80xaF6Lhk8?t=01h39m36s)



[right because this means it could be no](https://youtu.be/j80xaF6Lhk8?t=01h39m40s)



[surprised it's not like this right](https://youtu.be/j80xaF6Lhk8?t=01h39m46s)



[because I think we actually have this](https://youtu.be/j80xaF6Lhk8?t=01h39m49s)



[case right where I need to where I need](https://youtu.be/j80xaF6Lhk8?t=01h39m51s)



[to check it what are you squawking about](https://youtu.be/j80xaF6Lhk8?t=01h39m58s)



[here cannot lift conditional access t-to](https://youtu.be/j80xaF6Lhk8?t=01h40m00s)



[nillable type yeah I understand it's](https://youtu.be/j80xaF6Lhk8?t=01h40m05s)



[because I'm somewhat suggesting that](https://youtu.be/j80xaF6Lhk8?t=01h40m07s)



[this may be no right](https://youtu.be/j80xaF6Lhk8?t=01h40m12s)



[it may be null based upon so if we look](https://youtu.be/j80xaF6Lhk8?t=01h40m17s)



[at this guy here right so this may be](https://youtu.be/j80xaF6Lhk8?t=01h40m21s)



[null based upon the type of T I'm just](https://youtu.be/j80xaF6Lhk8?t=01h40m24s)



[surprised that it's not suggesting that](https://youtu.be/j80xaF6Lhk8?t=01h40m27s)



[this is a problem](https://youtu.be/j80xaF6Lhk8?t=01h40m31s)



[how does it get away with that singular](https://youtu.be/j80xaF6Lhk8?t=01h40m38s)



[default has to return null right right](https://youtu.be/j80xaF6Lhk8?t=01h40m42s)



[the or default portion of that method](https://youtu.be/j80xaF6Lhk8?t=01h40m48s)



[says that the default value could be](https://youtu.be/j80xaF6Lhk8?t=01h40m51s)



[returned and I don't understand why this](https://youtu.be/j80xaF6Lhk8?t=01h40m53s)



[is not flagging keep going keep going so](https://youtu.be/j80xaF6Lhk8?t=01h40m56s)



[I this feels like that should go there](https://youtu.be/j80xaF6Lhk8?t=01h41m05s)



[oh it's being smart that's why it's not](https://youtu.be/j80xaF6Lhk8?t=01h41m08s)



[flagging it this is this is an extension](https://youtu.be/j80xaF6Lhk8?t=01h41m14s)



[method oh look at that](https://youtu.be/j80xaF6Lhk8?t=01h41m18s)



[oh it's smarter than me okay it looks](https://youtu.be/j80xaF6Lhk8?t=01h41m21s)



[weird to have a dot on something that](https://youtu.be/j80xaF6Lhk8?t=01h41m26s)



[could be null but because the extension](https://youtu.be/j80xaF6Lhk8?t=01h41m27s)



[method will handle the null case okay](https://youtu.be/j80xaF6Lhk8?t=01h41m29s)



[easy peasy](https://youtu.be/j80xaF6Lhk8?t=01h41m35s)



[okay so here's another case with that](https://youtu.be/j80xaF6Lhk8?t=01h41m37s)



[value name on is match and I think the](https://youtu.be/j80xaF6Lhk8?t=01h41m40s)



[solution here is we just account for the](https://youtu.be/j80xaF6Lhk8?t=01h41m44s)



[null](https://youtu.be/j80xaF6Lhk8?t=01h41m49s)



[let's see here so what would happen if](https://youtu.be/j80xaF6Lhk8?t=01h41m55s)



[we short-circuited this I think in the](https://youtu.be/j80xaF6Lhk8?t=01h41m58s)



[interest of simplicity this is the](https://youtu.be/j80xaF6Lhk8?t=01h42m02s)



[simplest we sort of have the same thing](https://youtu.be/j80xaF6Lhk8?t=01h42m04s)



[though where we're now technically](https://youtu.be/j80xaF6Lhk8?t=01h42m08s)



[iterating over children where in the](https://youtu.be/j80xaF6Lhk8?t=01h42m10s)



[null case this is never going to match](https://youtu.be/j80xaF6Lhk8?t=01h42m11s)



[right because if value name is null this](https://youtu.be/j80xaF6Lhk8?t=01h42m14s)



[will get evaluated to null null does not](https://youtu.be/j80xaF6Lhk8?t=01h42m17s)



[equal true therefore nothing will match](https://youtu.be/j80xaF6Lhk8?t=01h42m22s)



[this will be an empty array which will](https://youtu.be/j80xaF6Lhk8?t=01h42m24s)



[then not land into either these cases](https://youtu.be/j80xaF6Lhk8?t=01h42m27s)



[and will fall down into this other stuff](https://youtu.be/j80xaF6Lhk8?t=01h42m29s)



[right in this case null is fine though I](https://youtu.be/j80xaF6Lhk8?t=01h42m30s)



[do wonder if perhaps we should have a](https://youtu.be/j80xaF6Lhk8?t=01h42m35s)



[different because no wanted to put into](https://youtu.be/j80xaF6Lhk8?t=01h42m37s)



[a string we'll just end up as empty](https://youtu.be/j80xaF6Lhk8?t=01h42m41s)



[string maybe we should put something](https://youtu.be/j80xaF6Lhk8?t=01h42m42s)



[else there problem for a different day](https://youtu.be/j80xaF6Lhk8?t=01h42m44s)



[ok keep going let's see that one we just](https://youtu.be/j80xaF6Lhk8?t=01h42m47s)



[handled](https://youtu.be/j80xaF6Lhk8?t=01h42m53s)



[ok so clear up some of these so get](https://youtu.be/j80xaF6Lhk8?t=01h42m55s)



[value or default get value or default I](https://youtu.be/j80xaF6Lhk8?t=01h43m02s)



[think this is another case of the return](https://youtu.be/j80xaF6Lhk8?t=01h43m06s)



[value may be null depending on what your](https://youtu.be/j80xaF6Lhk8?t=01h43m08s)



[T is so be smart about it](https://youtu.be/j80xaF6Lhk8?t=01h43m12s)



[let's see here I think a non-generic](https://youtu.be/j80xaF6Lhk8?t=01h43m16s)



[case we've been just handling like that](https://youtu.be/j80xaF6Lhk8?t=01h43m18s)



[which makes sense and](https://youtu.be/j80xaF6Lhk8?t=01h43m24s)



[and you squawking about here Oh extra](https://youtu.be/j80xaF6Lhk8?t=01h43m26s)



[using statements to do does](https://youtu.be/j80xaF6Lhk8?t=01h43m30s)



[short-circuiting that previous method](https://youtu.be/j80xaF6Lhk8?t=01h43m35s)



[caused the method to return garbage so](https://youtu.be/j80xaF6Lhk8?t=01h43m37s)



[the answer is no let me know your your](https://youtu.be/j80xaF6Lhk8?t=01h43m40s)



[fine so the the short-circuiting stuff](https://youtu.be/j80xaF6Lhk8?t=01h43m45s)



[is actually really really intelligent so](https://youtu.be/j80xaF6Lhk8?t=01h43m48s)



[if I can get I may have lost my contact](https://youtu.be/j80xaF6Lhk8?t=01h43m54s)



[stack all the way in here but when you](https://youtu.be/j80xaF6Lhk8?t=01h43m57s)



[do the null propagation operator even if](https://youtu.be/j80xaF6Lhk8?t=01h43m59s)



[it's an extension method the compiler is](https://youtu.be/j80xaF6Lhk8?t=01h44m02s)



[smart enough to interpret it and won't](https://youtu.be/j80xaF6Lhk8?t=01h44m05s)



[actually if if the left side of the](https://youtu.be/j80xaF6Lhk8?t=01h44m09s)



[question mark evaluates to know the](https://youtu.be/j80xaF6Lhk8?t=01h44m11s)



[stuff after the question mark doesn't](https://youtu.be/j80xaF6Lhk8?t=01h44m14s)



[get evaluated it means that the entire](https://youtu.be/j80xaF6Lhk8?t=01h44m16s)



[side or the left hand side of this](https://youtu.be/j80xaF6Lhk8?t=01h44m19s)



[equals expression if I hover over it](https://youtu.be/j80xaF6Lhk8?t=01h44m22s)



[will end up being a knowable just](https://youtu.be/j80xaF6Lhk8?t=01h44m25s)



[reporting incorrectly here it'll be a](https://youtu.be/j80xaF6Lhk8?t=01h44m28s)



[knowable boolean expression so rather](https://youtu.be/j80xaF6Lhk8?t=01h44m30s)



[than just having true or false](https://youtu.be/j80xaF6Lhk8?t=01h44m33s)



[I now have null true and false which is](https://youtu.be/j80xaF6Lhk8?t=01h44m35s)



[why you can't just have this anymore](https://youtu.be/j80xaF6Lhk8?t=01h44m37s)



[right](https://youtu.be/j80xaF6Lhk8?t=01h44m40s)



[because we're want you to give it a](https://youtu.be/j80xaF6Lhk8?t=01h44m40s)



[predicate where you tell it true or](https://youtu.be/j80xaF6Lhk8?t=01h44m43s)



[false for each of the items and if this](https://youtu.be/j80xaF6Lhk8?t=01h44m44s)



[is returning a nullable boolean that's](https://youtu.be/j80xaF6Lhk8?t=01h44m47s)



[no longer just a true or false](https://youtu.be/j80xaF6Lhk8?t=01h44m49s)



[that's a null a true or a false so we](https://youtu.be/j80xaF6Lhk8?t=01h44m50s)



[have to convert the knowable boolean](https://youtu.be/j80xaF6Lhk8?t=01h44m54s)



[down to a simple boolean like that](https://youtu.be/j80xaF6Lhk8?t=01h44m56s)



[so effectively do the comparison there](https://youtu.be/j80xaF6Lhk8?t=01h45m01s)



[because c-sharp is not C we don't have](https://youtu.be/j80xaF6Lhk8?t=01h45m04s)



[that and the implicit conversion to bool](https://youtu.be/j80xaF6Lhk8?t=01h45m07s)



[so there is all of that](https://youtu.be/j80xaF6Lhk8?t=01h45m12s)



[okay don't know if I solve that last one](https://youtu.be/j80xaF6Lhk8?t=01h45m15s)



[let's look at this so maybe no we](https://youtu.be/j80xaF6Lhk8?t=01h45m18s)



[handled that one let's jump here so this](https://youtu.be/j80xaF6Lhk8?t=01h45m20s)



[is gonna be an interesting area of the](https://youtu.be/j80xaF6Lhk8?t=01h45m24s)



[code so largely yeah so let's see sorry](https://youtu.be/j80xaF6Lhk8?t=01h45m26s)



[switching my brain arraignment okay that](https://youtu.be/j80xaF6Lhk8?t=01h45m31s)



[makes sense I was questioning if](https://youtu.be/j80xaF6Lhk8?t=01h45m33s)



[changing this line 37 cause of the](https://youtu.be/j80xaF6Lhk8?t=01h45m35s)



[method try getting a treat](https://youtu.be/j80xaF6Lhk8?t=01h45m38s)



[garbage that's crazy though yeah in](https://youtu.be/j80xaF6Lhk8?t=01h45m40s)



[general we don't have as much returned](https://youtu.be/j80xaF6Lhk8?t=01h45m42s)



[garbage stuff in c-sharp I say as much](https://youtu.be/j80xaF6Lhk8?t=01h45m45s)



[because I've been doing a lot of stuff](https://youtu.be/j80xaF6Lhk8?t=01h45m48s)



[with pointers and unmanaged memory and](https://youtu.be/j80xaF6Lhk8?t=01h45m50s)



[yeah all of the problems with C then](https://youtu.be/j80xaF6Lhk8?t=01h45m52s)



[propagate right up into c-sharp it's](https://youtu.be/j80xaF6Lhk8?t=01h45m55s)



[wonderful so if you turn on unmanaged](https://youtu.be/j80xaF6Lhk8?t=01h45m57s)



[stuff you can shoot yourself in the foot](https://youtu.be/j80xaF6Lhk8?t=01h46m00s)



[all the same ways you can do it and C or](https://youtu.be/j80xaF6Lhk8?t=01h46m02s)



[at least most of the same ways it's](https://youtu.be/j80xaF6Lhk8?t=01h46m04s)



[exciting so the system command-line](https://youtu.be/j80xaF6Lhk8?t=01h46m07s)



[parsing largely follows a visitor](https://youtu.be/j80xaF6Lhk8?t=01h46m11s)



[pattern the problem with a visitor](https://youtu.be/j80xaF6Lhk8?t=01h46m14s)



[pattern is its several method change](https://youtu.be/j80xaF6Lhk8?t=01h46m16s)



[deep right and doesn't lend itself well](https://youtu.be/j80xaF6Lhk8?t=01h46m19s)



[to the the static analysis of the](https://youtu.be/j80xaF6Lhk8?t=01h46m23s)



[knowable reference types so I suspect](https://youtu.be/j80xaF6Lhk8?t=01h46m27s)



[what's going to happen in a lot of these](https://youtu.be/j80xaF6Lhk8?t=01h46m28s)



[cases is we're just going to use the](https://youtu.be/j80xaF6Lhk8?t=01h46m30s)



[trust me operator or try to remember](https://youtu.be/j80xaF6Lhk8?t=01h46m32s)



[what they call it no forgiveness](https://youtu.be/j80xaF6Lhk8?t=01h46m35s)



[operator I think is the official term](https://youtu.be/j80xaF6Lhk8?t=01h46m37s)



[right so I suspect that's what we're](https://youtu.be/j80xaF6Lhk8?t=01h46m41s)



[gonna run into so for example we have](https://youtu.be/j80xaF6Lhk8?t=01h46m46s)



[this case where it says visit write and](https://youtu.be/j80xaF6Lhk8?t=01h46m48s)



[visit takes in a non nullable node right](https://youtu.be/j80xaF6Lhk8?t=01h46m50s)



[but the problem is on operation we have](https://youtu.be/j80xaF6Lhk8?t=01h46m55s)



[a root command node right and root](https://youtu.be/j80xaF6Lhk8?t=01h46m59s)



[command node can theoretically be null](https://youtu.be/j80xaF6Lhk8?t=01h47m01s)



[all right so questions when could it be](https://youtu.be/j80xaF6Lhk8?t=01h47m03s)



[null](https://youtu.be/j80xaF6Lhk8?t=01h47m06s)



[well the simple case is when you first](https://youtu.be/j80xaF6Lhk8?t=01h47m06s)



[instead she ate parse operation right if](https://youtu.be/j80xaF6Lhk8?t=01h47m10s)



[you do parse operation at the end of](https://youtu.be/j80xaF6Lhk8?t=01h47m13s)



[this constructor nothing set this it's](https://youtu.be/j80xaF6Lhk8?t=01h47m16s)



[still null right so it's very possible](https://youtu.be/j80xaF6Lhk8?t=01h47m18s)



[to be null the problem being is this guy](https://youtu.be/j80xaF6Lhk8?t=01h47m21s)



[does get set if we come back here](https://youtu.be/j80xaF6Lhk8?t=01h47m23s)



[operation dot parse right so root](https://youtu.be/j80xaF6Lhk8?t=01h47m25s)



[command node gets parse root command](https://youtu.be/j80xaF6Lhk8?t=01h47m28s)



[node which is going to return a non null](https://youtu.be/j80xaF6Lhk8?t=01h47m30s)



[value right because it's guarantee it](https://youtu.be/j80xaF6Lhk8?t=01h47m33s)



[just news went up and ultimately returns](https://youtu.be/j80xaF6Lhk8?t=01h47m35s)



[it so it's always going to be non null](https://youtu.be/j80xaF6Lhk8?t=01h47m37s)



[so it will be non null after that method](https://youtu.be/j80xaF6Lhk8?t=01h47m39s)



[is called so in this case just tell the](https://youtu.be/j80xaF6Lhk8?t=01h47m42s)



[compiler hands off trust me all right](https://youtu.be/j80xaF6Lhk8?t=01h47m48s)



[because it has no idea that because we](https://youtu.be/j80xaF6Lhk8?t=01h47m50s)



[call parse](https://youtu.be/j80xaF6Lhk8?t=01h47m53s)



[that this property on this object](https://youtu.be/j80xaF6Lhk8?t=01h47m53s)



[magically got set right again the the](https://youtu.be/j80xaF6Lhk8?t=01h47m56s)



[static analysis is one level it doesn't](https://youtu.be/j80xaF6Lhk8?t=01h47m59s)



[go anything beyond what it can see here](https://youtu.be/j80xaF6Lhk8?t=01h48m02s)



[so okay next up did you do value for](https://youtu.be/j80xaF6Lhk8?t=01h48m04s)



[option I think this is another may be](https://youtu.be/j80xaF6Lhk8?t=01h48m12s)



[null case right because this is you've](https://youtu.be/j80xaF6Lhk8?t=01h48m15s)



[got a you've got a partial result so](https://youtu.be/j80xaF6Lhk8?t=01h48m18s)



[you've parsed the values from your](https://youtu.be/j80xaF6Lhk8?t=01h48m21s)



[command line and it's one of those hey](https://youtu.be/j80xaF6Lhk8?t=01h48m24s)



[you know I had a user name option right](https://youtu.be/j80xaF6Lhk8?t=01h48m26s)



[give me that string value so whether](https://youtu.be/j80xaF6Lhk8?t=01h48m29s)



[this could be no or not is based upon](https://youtu.be/j80xaF6Lhk8?t=01h48m31s)



[your t and so I think we just say return](https://youtu.be/j80xaF6Lhk8?t=01h48m33s)



[may be null](https://youtu.be/j80xaF6Lhk8?t=01h48m38s)



[right because we don't want to declare t](https://youtu.be/j80xaF6Lhk8?t=01h48m40s)



[with a question mark because if T was](https://youtu.be/j80xaF6Lhk8?t=01h48m42s)



[passed as an int we don't want to](https://youtu.be/j80xaF6Lhk8?t=01h48m44s)



[magically become nullable int we want](https://youtu.be/j80xaF6Lhk8?t=01h48m46s)



[this to be respectful of whatever the](https://youtu.be/j80xaF6Lhk8?t=01h48m48s)



[caller specified again schrödinger's](https://youtu.be/j80xaF6Lhk8?t=01h48m50s)



[generic it's both null and not null all](https://youtu.be/j80xaF6Lhk8?t=01h48m54s)



[at the same time because what we needed](https://youtu.be/j80xaF6Lhk8?t=01h48m56s)



[was to make C sharp a little bit more](https://youtu.be/j80xaF6Lhk8?t=01h49m00s)



[complicated okay so what do we got here](https://youtu.be/j80xaF6Lhk8?t=01h49m02s)



[so text to match is a nullable string](https://youtu.be/j80xaF6Lhk8?t=01h49m05s)



[which makes sense because it's](https://youtu.be/j80xaF6Lhk8?t=01h49m10s)



[initialized to null so it should be](https://youtu.be/j80xaF6Lhk8?t=01h49m12s)



[nullable this guy is a nominal return](https://youtu.be/j80xaF6Lhk8?t=01h49m14s)



[and this guy down here is matching so](https://youtu.be/j80xaF6Lhk8?t=01h49m18s)



[the question is is it possible to get to](https://youtu.be/j80xaF6Lhk8?t=01h49m22s)



[this return statement and text to match](https://youtu.be/j80xaF6Lhk8?t=01h49m25s)



[not to be set to something so the only](https://youtu.be/j80xaF6Lhk8?t=01h49m27s)



[setter is here which last token dot](https://youtu.be/j80xaF6Lhk8?t=01h49m31s)



[value would have to be not equal to null](https://youtu.be/j80xaF6Lhk8?t=01h49m37s)



[let's see raw input not equal to null so](https://youtu.be/j80xaF6Lhk8?t=01h49m41s)



[this gets weird right right out the gate](https://youtu.be/j80xaF6Lhk8?t=01h49m46s)



[because I see a not null explicit check](https://youtu.be/j80xaF6Lhk8?t=01h49m48s)



[all right followed by an is no lure](https://youtu.be/j80xaF6Lhk8?t=01h49m51s)



[whitespace check which make me](https://youtu.be/j80xaF6Lhk8?t=01h49m54s)



[immediately look for say the empty](https://youtu.be/j80xaF6Lhk8?t=01h49m57s)



[string case right if raw input is empty](https://youtu.be/j80xaF6Lhk8?t=01h49m59s)



[string well that's not null](https://youtu.be/j80xaF6Lhk8?t=01h50m02s)



[but I would fall into this case is that](https://youtu.be/j80xaF6Lhk8?t=01h50m05s)



[okay so more interesting is if raw input](https://youtu.be/j80xaF6Lhk8?t=01h50m10s)



[is null alright so for on put is null](https://youtu.be/j80xaF6Lhk8?t=01h50m13s)



[which it is a nullable string okay I](https://youtu.be/j80xaF6Lhk8?t=01h50m18s)



[just this one this bar I can't deal with](https://youtu.be/j80xaF6Lhk8?t=01h50m21s)



[that one needs to be specified so if raw](https://youtu.be/j80xaF6Lhk8?t=01h50m23s)



[input is null we fall into here we do](https://youtu.be/j80xaF6Lhk8?t=01h50m28s)



[some stuff right](https://youtu.be/j80xaF6Lhk8?t=01h50m32s)



[[Music]](https://youtu.be/j80xaF6Lhk8?t=01h50m34s)



[worst-case scenario raw input remains](https://youtu.be/j80xaF6Lhk8?t=01h50m37s)



[null position picks this so say raw](https://youtu.be/j80xaF6Lhk8?t=01h50m40s)



[input is empty string we fall into here](https://youtu.be/j80xaF6Lhk8?t=01h50m47s)



[position is null right so the initial](https://youtu.be/j80xaF6Lhk8?t=01h50m51s)



[call it ends position ends up being 0 we](https://youtu.be/j80xaF6Lhk8?t=01h50m55s)



[fall out we fall out raw input is no](https://youtu.be/j80xaF6Lhk8?t=01h50m57s)



[lure white space because we're](https://youtu.be/j80xaF6Lhk8?t=01h51m00s)



[pretending it's empty string for the](https://youtu.be/j80xaF6Lhk8?t=01h51m01s)



[moment source unmatched tokens any that](https://youtu.be/j80xaF6Lhk8?t=01h51m03s)



[will depend on what we parsed so it](https://youtu.be/j80xaF6Lhk8?t=01h51m06s)



[could be true or false which could](https://youtu.be/j80xaF6Lhk8?t=01h51m10s)



[actually let us fall into this case and](https://youtu.be/j80xaF6Lhk8?t=01h51m12s)



[this could be null so we've got at least](https://youtu.be/j80xaF6Lhk8?t=01h51m14s)



[one path through with it where it is](https://youtu.be/j80xaF6Lhk8?t=01h51m19s)



[very possible that this is no I think](https://youtu.be/j80xaF6Lhk8?t=01h51m21s)



[what I would like to do is this](https://youtu.be/j80xaF6Lhk8?t=01h51m24s)



[because this is the default return down](https://youtu.be/j80xaF6Lhk8?t=01h51m31s)



[here so I think we just know coal s and](https://youtu.be/j80xaF6Lhk8?t=01h51m33s)



[return empty string I think that's the](https://youtu.be/j80xaF6Lhk8?t=01h51m41s)



[easiest way okay](https://youtu.be/j80xaF6Lhk8?t=01h51m44s)



[so position here so is it possible to](https://youtu.be/j80xaF6Lhk8?t=01h51m46s)



[get here where position has yet to be](https://youtu.be/j80xaF6Lhk8?t=01h51m49s)



[set so position is a knowable int the](https://youtu.be/j80xaF6Lhk8?t=01h51m52s)



[easiest if case is raw input as null we](https://youtu.be/j80xaF6Lhk8?t=01h51m57s)



[fall into and we fall into here this](https://youtu.be/j80xaF6Lhk8?t=01h52m01s)



[becomes null if so if raw input is null](https://youtu.be/j80xaF6Lhk8?t=01h52m04s)



[and we fall into here we won't get into](https://youtu.be/j80xaF6Lhk8?t=01h52m10s)



[this else so that's not a way that's not](https://youtu.be/j80xaF6Lhk8?t=01h52m14s)



[possible](https://youtu.be/j80xaF6Lhk8?t=01h52m17s)



[so if we go into this else it's not](https://youtu.be/j80xaF6Lhk8?t=01h52m17s)



[possible to get down to here so that's](https://youtu.be/j80xaF6Lhk8?t=01h52m20s)



[fine so if we go into here is position](https://youtu.be/j80xaF6Lhk8?t=01h52m22s)



[set in all cases if position not equal](https://youtu.be/j80xaF6Lhk8?t=01h52m27s)



[to null that's not possible because we](https://youtu.be/j80xaF6Lhk8?t=01h52m32s)



[want to find the null case so we'd have](https://youtu.be/j80xaF6Lhk8?t=01h52m34s)



[to land here this would set it so I'm](https://youtu.be/j80xaF6Lhk8?t=01h52m36s)



[going to propose that this case is not](https://youtu.be/j80xaF6Lhk8?t=01h52m41s)



[possible and therefore we'll tell the](https://youtu.be/j80xaF6Lhk8?t=01h52m44s)



[compiler hands off this level of](https://youtu.be/j80xaF6Lhk8?t=01h52m46s)



[complexity though does make me pause a](https://youtu.be/j80xaF6Lhk8?t=01h52m51s)



[little bit it does sort of indicate that](https://youtu.be/j80xaF6Lhk8?t=01h52m53s)



[there might be some cleanup possible but](https://youtu.be/j80xaF6Lhk8?t=01h52m55s)



[right now no liberal reference types not](https://youtu.be/j80xaF6Lhk8?t=01h52m58s)



[refactoring not refactoring not](https://youtu.be/j80xaF6Lhk8?t=01h53m01s)



[refactoring resist the urge Kevin](https://youtu.be/j80xaF6Lhk8?t=01h53m03s)



[resists the urge](https://youtu.be/j80xaF6Lhk8?t=01h53m06s)



[okay so what do we got down here so](https://youtu.be/j80xaF6Lhk8?t=01h53m11s)



[we've got a enumerable of nullable](https://youtu.be/j80xaF6Lhk8?t=01h53m16s)



[strings trying to be set into a](https://youtu.be/j80xaF6Lhk8?t=01h53m21s)



[straight-up enumerable of strings so](https://youtu.be/j80xaF6Lhk8?t=01h53m22s)



[this guy here so get suggestions I](https://youtu.be/j80xaF6Lhk8?t=01h53m25s)



[believe is the kicker right this is one](https://youtu.be/j80xaF6Lhk8?t=01h53m29s)



[we modified earlier because we know that](https://youtu.be/j80xaF6Lhk8?t=01h53m31s)



[this can come in from the outside so](https://youtu.be/j80xaF6Lhk8?t=01h53m33s)



[implementers of this might only be on](https://youtu.be/j80xaF6Lhk8?t=01h53m35s)



[c-sharp seven they don't know about](https://youtu.be/j80xaF6Lhk8?t=01h53m37s)



[nullable types or noble reference type](https://youtu.be/j80xaF6Lhk8?t=01h53m39s)



[so they don't do it right and they kick](https://youtu.be/j80xaF6Lhk8?t=01h53m42s)



[back a null so the question then becomes](https://youtu.be/j80xaF6Lhk8?t=01h53m44s)



[if they kick back a null you need to](https://youtu.be/j80xaF6Lhk8?t=01h53m47s)



[iterate over this so the question is](https://youtu.be/j80xaF6Lhk8?t=01h53m55s)



[should this guy just be this and I think](https://youtu.be/j80xaF6Lhk8?t=01h53m57s)



[the answer is yes all right and I don't](https://youtu.be/j80xaF6Lhk8?t=01h54m01s)



[think it makes a difference to do this](https://youtu.be/j80xaF6Lhk8?t=01h54m05s)



[or not because array dot empty is a](https://youtu.be/j80xaF6Lhk8?t=01h54m07s)



[static reference okay glad to know I'm](https://youtu.be/j80xaF6Lhk8?t=01h54m10s)



[not on Thank You Raymond I appreciate it](https://youtu.be/j80xaF6Lhk8?t=01h54m15s)



[it at this hour I'm not always sure I](https://youtu.be/j80xaF6Lhk8?t=01h54m16s)



[can trust my own sanity so please please](https://youtu.be/j80xaF6Lhk8?t=01h54m19s)



[please if if you are following along and](https://youtu.be/j80xaF6Lhk8?t=01h54m22s)



[something doesn't make sense question me](https://youtu.be/j80xaF6Lhk8?t=01h54m24s)



[because there's a very real chance that](https://youtu.be/j80xaF6Lhk8?t=01h54m26s)



[I'm probably wrong so next question this](https://youtu.be/j80xaF6Lhk8?t=01h54m28s)



[guy here is unhappy because this guy](https://youtu.be/j80xaF6Lhk8?t=01h54m33s)



[here is being concatenated right so it's](https://youtu.be/j80xaF6Lhk8?t=01h54m39s)



[getting to be a knowable string in the](https://youtu.be/j80xaF6Lhk8?t=01h54m42s)



[return and so should this one also be](https://youtu.be/j80xaF6Lhk8?t=01h54m46s)



[knowable that is a very good question I](https://youtu.be/j80xaF6Lhk8?t=01h54m49s)



[think the answer is yes because we we](https://youtu.be/j80xaF6Lhk8?t=01h54m53s)



[know that this one can be and I think](https://youtu.be/j80xaF6Lhk8?t=01h54m55s)



[the very fact that were concatenated](https://youtu.be/j80xaF6Lhk8?t=01h55m00s)



[these together and this guy is already](https://youtu.be/j80xaF6Lhk8?t=01h55m01s)



[declared that way because he's also](https://youtu.be/j80xaF6Lhk8?t=01h55m05s)



[coming from get suggestions so yeah so](https://youtu.be/j80xaF6Lhk8?t=01h55m08s)



[this guy should be a noble string](https://youtu.be/j80xaF6Lhk8?t=01h55m09s)



[concatenated to nullable to enumerables](https://youtu.be/j80xaF6Lhk8?t=01h55m11s)



[of nillable strings together](https://youtu.be/j80xaF6Lhk8?t=01h55m14s)



[yeah tongue-tied okay next up](https://youtu.be/j80xaF6Lhk8?t=01h55m16s)



[and we did that one already so back to](https://youtu.be/j80xaF6Lhk8?t=01h55m21s)



[our visitor fun okay so this one we may](https://youtu.be/j80xaF6Lhk8?t=01h55m24s)



[just start at the top and work our way](https://youtu.be/j80xaF6Lhk8?t=01h55m29s)



[down because this one I think there's](https://youtu.be/j80xaF6Lhk8?t=01h55m31s)



[there's a bunch of them in here and](https://youtu.be/j80xaF6Lhk8?t=01h55m33s)



[again because this is a visitor pattern](https://youtu.be/j80xaF6Lhk8?t=01h55m35s)



[there's probably gonna be a lot of these](https://youtu.be/j80xaF6Lhk8?t=01h55m37s)



[cases where where it doesn't really make](https://youtu.be/j80xaF6Lhk8?t=01h55m39s)



[sense so the main problem child I can](https://youtu.be/j80xaF6Lhk8?t=01h55m42s)



[almost guarantee are going to be these](https://youtu.be/j80xaF6Lhk8?t=01h55m46s)



[two fields here right because once again](https://youtu.be/j80xaF6Lhk8?t=01h55m48s)



[these two fields start as null because](https://youtu.be/j80xaF6Lhk8?t=01h55m51s)



[when you initially call this guy's](https://youtu.be/j80xaF6Lhk8?t=01h55m54s)



[constructor at the end of the](https://youtu.be/j80xaF6Lhk8?t=01h55m56s)



[constructor](https://youtu.be/j80xaF6Lhk8?t=01h55m57s)



[nobody has set either of these fields](https://youtu.be/j80xaF6Lhk8?t=01h55m58s)



[which means they're no right but the](https://youtu.be/j80xaF6Lhk8?t=01h56m00s)



[moment we start visiting things right](https://youtu.be/j80xaF6Lhk8?t=01h56m04s)



[we're going to quickly start hitting](https://youtu.be/j80xaF6Lhk8?t=01h56m07s)



[those so you'll note syntax visitor down](https://youtu.be/j80xaF6Lhk8?t=01h56m10s)



[here he has the the visit method which](https://youtu.be/j80xaF6Lhk8?t=01h56m12s)



[then called visit internal which starts](https://youtu.be/j80xaF6Lhk8?t=01h56m15s)



[iterating and we've got all these](https://youtu.be/j80xaF6Lhk8?t=01h56m17s)



[virtual methods yada yada yada](https://youtu.be/j80xaF6Lhk8?t=01h56m19s)



[this guy overrides most of the ones that](https://youtu.be/j80xaF6Lhk8?t=01h56m22s)



[he cares about yeah so dumb and not some](https://youtu.be/j80xaF6Lhk8?t=01h56m25s)



[suggestion find him replace all string](https://youtu.be/j80xaF6Lhk8?t=01h56m29s)



[with string question marks so yeah so to](https://youtu.be/j80xaF6Lhk8?t=01h56m31s)



[answer the question raymond there are a](https://youtu.be/j80xaF6Lhk8?t=01h56m36s)



[number of ways i've seen people go about](https://youtu.be/j80xaF6Lhk8?t=01h56m38s)



[adding nillable reference types to a](https://youtu.be/j80xaF6Lhk8?t=01h56m41s)



[project one option is to not enable it](https://youtu.be/j80xaF6Lhk8?t=01h56m42s)



[project wide like I did here right and](https://youtu.be/j80xaF6Lhk8?t=01h56m48s)



[go file by file because you can also do](https://youtu.be/j80xaF6Lhk8?t=01h56m51s)



[the let's see not like that you can do](https://youtu.be/j80xaF6Lhk8?t=01h56m55s)



[pound nillable and then enable/disable](https://youtu.be/j80xaF6Lhk8?t=01h57m00s)



[or what does it restore what is it yeah](https://youtu.be/j80xaF6Lhk8?t=01h57m04s)



[restore so you can toggle it on and off](https://youtu.be/j80xaF6Lhk8?t=01h57m07s)



[specifically in individual source like](https://youtu.be/j80xaF6Lhk8?t=01h57m10s)



[one and a bit so I've seen people go](https://youtu.be/j80xaF6Lhk8?t=01h57m13s)



[through and turn it either on or off at](https://youtu.be/j80xaF6Lhk8?t=01h57m14s)



[the project level and then add this to](https://youtu.be/j80xaF6Lhk8?t=01h57m18s)



[all of their files one way or the other](https://youtu.be/j80xaF6Lhk8?t=01h57m20s)



[right that way they can go through file](https://youtu.be/j80xaF6Lhk8?t=01h57m21s)



[by file and turn it on blindly replacing](https://youtu.be/j80xaF6Lhk8?t=01h57m24s)



[string with string question mark I think](https://youtu.be/j80xaF6Lhk8?t=01h57m28s)



[would really really depend on](https://youtu.be/j80xaF6Lhk8?t=01h57m30s)



[the project that I'm in because I think](https://youtu.be/j80xaF6Lhk8?t=01h57m33s)



[in a lot of cases by doing that you](https://youtu.be/j80xaF6Lhk8?t=01h57m37s)



[start to lose the benefits of knowable](https://youtu.be/j80xaF6Lhk8?t=01h57m39s)



[reference types if you just make](https://youtu.be/j80xaF6Lhk8?t=01h57m41s)



[everything knowable I mean if](https://youtu.be/j80xaF6Lhk8?t=01h57m43s)



[everything's knowable you don't bother](https://youtu.be/j80xaF6Lhk8?t=01h57m45s)



[to turn on knowable reference types](https://youtu.be/j80xaF6Lhk8?t=01h57m47s)



[because the goal is to have things not](https://youtu.be/j80xaF6Lhk8?t=01h57m48s)



[know because most of the time on](https://youtu.be/j80xaF6Lhk8?t=01h57m51s)



[initialization like for example this](https://youtu.be/j80xaF6Lhk8?t=01h57m53s)



[unwashed oaken's right we're very](https://youtu.be/j80xaF6Lhk8?t=01h57m55s)



[explicitly setting it not null it's](https://youtu.be/j80xaF6Lhk8?t=01h57m57s)



[read-only we can make some good](https://youtu.be/j80xaF6Lhk8?t=01h57m59s)



[assumptions if somebody later checks](https://youtu.be/j80xaF6Lhk8?t=01h58m00s)



[this for know we should smack them say](https://youtu.be/j80xaF6Lhk8?t=01h58m02s)



[no not know we we've declared it that](https://youtu.be/j80xaF6Lhk8?t=01h58m05s)



[way](https://youtu.be/j80xaF6Lhk8?t=01h58m07s)



[so having that sort of extra syntax](https://youtu.be/j80xaF6Lhk8?t=01h58m07s)



[checking I think is worth it so I guess](https://youtu.be/j80xaF6Lhk8?t=01h58m10s)



[my only thought is yes that would work](https://youtu.be/j80xaF6Lhk8?t=01h58m12s)



[but I think you would lose a lot of the](https://youtu.be/j80xaF6Lhk8?t=01h58m14s)



[benefits with the blind replace I think](https://youtu.be/j80xaF6Lhk8?t=01h58m16s)



[the easiest thing to do is to turn it on](https://youtu.be/j80xaF6Lhk8?t=01h58m22s)



[and try to determine whether which way](https://youtu.be/j80xaF6Lhk8?t=01h58m24s)



[is going to be the least amount of work](https://youtu.be/j80xaF6Lhk8?t=01h58m30s)



[right of do I turn it on at the project](https://youtu.be/j80xaF6Lhk8?t=01h58m31s)



[level and disable it and go project and](https://youtu.be/j80xaF6Lhk8?t=01h58m34s)



[go file by file or do I turn it off at](https://youtu.be/j80xaF6Lhk8?t=01h58m36s)



[the project level and turn it on file by](https://youtu.be/j80xaF6Lhk8?t=01h58m41s)



[file until I get to a reasonable point](https://youtu.be/j80xaF6Lhk8?t=01h58m43s)



[right and then and then just find and](https://youtu.be/j80xaF6Lhk8?t=01h58m45s)



[replace the the pound no levels because](https://youtu.be/j80xaF6Lhk8?t=01h58m47s)



[not everybody can afford like especially](https://youtu.be/j80xaF6Lhk8?t=01h58m51s)



[in a really really big project going](https://youtu.be/j80xaF6Lhk8?t=01h58m53s)



[through and upgrading your entire](https://youtu.be/j80xaF6Lhk8?t=01h58m56s)



[project is a massive undertaking it's](https://youtu.be/j80xaF6Lhk8?t=01h58m57s)



[like this is this is a not a huge](https://youtu.be/j80xaF6Lhk8?t=01h59m00s)



[project right like it's it's it's big](https://youtu.be/j80xaF6Lhk8?t=01h59m03s)



[but not like this is not unreasonably](https://youtu.be/j80xaF6Lhk8?t=01h59m06s)



[big like this is something that like few](https://youtu.be/j80xaF6Lhk8?t=01h59m10s)



[evenings worth of work probably done](https://youtu.be/j80xaF6Lhk8?t=01h59m15s)



[right like I went through it in a few](https://youtu.be/j80xaF6Lhk8?t=01h59m17s)



[hours and and took this thing from a few](https://youtu.be/j80xaF6Lhk8?t=01h59m19s)



[hundred warnings to 50 without without](https://youtu.be/j80xaF6Lhk8?t=01h59m22s)



[really batting much of an eye at it it](https://youtu.be/j80xaF6Lhk8?t=01h59m25s)



[was that was all the easy cases so but](https://youtu.be/j80xaF6Lhk8?t=01h59m28s)



[again this is not what I would consider](https://youtu.be/j80xaF6Lhk8?t=01h59m30s)



[a large project like I've seen ones](https://youtu.be/j80xaF6Lhk8?t=01h59m32s)



[where there's you've got tens of](https://youtu.be/j80xaF6Lhk8?t=01h59m34s)



[thousands of files and it's just not](https://youtu.be/j80xaF6Lhk8?t=01h59m36s)



[reasonable to to bite it all off at once](https://youtu.be/j80xaF6Lhk8?t=01h59m38s)



[unless you've got somebody willing to](https://youtu.be/j80xaF6Lhk8?t=01h59m40s)



[invest the development time it's sort of](https://youtu.be/j80xaF6Lhk8?t=01h59m43s)



[a hard one to justify](https://youtu.be/j80xaF6Lhk8?t=01h59m45s)



[going at it all all at once okay I](https://youtu.be/j80xaF6Lhk8?t=01h59m47s)



[digress](https://youtu.be/j80xaF6Lhk8?t=01h59m52s)



[so we are on the hunt for the ones in](https://youtu.be/j80xaF6Lhk8?t=01h59m53s)



[here right and again it's likely those](https://youtu.be/j80xaF6Lhk8?t=01h59m56s)



[two fields that are going to be our](https://youtu.be/j80xaF6Lhk8?t=01h59m59s)



[problem child](https://youtu.be/j80xaF6Lhk8?t=02h00m03s)



[okay so visit command node right so we](https://youtu.be/j80xaF6Lhk8?t=02h00m03s)



[get into here innermost command result](https://youtu.be/j80xaF6Lhk8?t=02h00m08s)



[has the potential of being null all](https://youtu.be/j80xaF6Lhk8?t=02h00m13s)



[right so let's let's look at command](https://youtu.be/j80xaF6Lhk8?t=02h00m16s)



[results so parent could be no that's](https://youtu.be/j80xaF6Lhk8?t=02h00m18s)



[fine](https://youtu.be/j80xaF6Lhk8?t=02h00m21s)



[that's fine visit command node so here's](https://youtu.be/j80xaF6Lhk8?t=02h00m22s)



[the thing I don't think I don't think](https://youtu.be/j80xaF6Lhk8?t=02h00m26s)



[it's possible to get to visit command](https://youtu.be/j80xaF6Lhk8?t=02h00m31s)



[node without hitting visit route command](https://youtu.be/j80xaF6Lhk8?t=02h00m33s)



[node and I think we can confirm that](https://youtu.be/j80xaF6Lhk8?t=02h00m35s)



[here right so I suppose it technically](https://youtu.be/j80xaF6Lhk8?t=02h00m37s)



[is possible could I could I instantiate](https://youtu.be/j80xaF6Lhk8?t=02h00m43s)



[this up right and cause that to happen I](https://youtu.be/j80xaF6Lhk8?t=02h00m49s)



[mean I could always invoke well no these](https://youtu.be/j80xaF6Lhk8?t=02h00m54s)



[are internal classes yeah these are](https://youtu.be/j80xaF6Lhk8?t=02h00m57s)



[internal classes it's not I think the](https://youtu.be/j80xaF6Lhk8?t=02h01m01s)



[simple answer on this one is unless](https://youtu.be/j80xaF6Lhk8?t=02h01m03s)



[there's another bug this is not possible](https://youtu.be/j80xaF6Lhk8?t=02h01m07s)



[right because the only way to get here](https://youtu.be/j80xaF6Lhk8?t=02h01m10s)



[is to have an invalid object model](https://youtu.be/j80xaF6Lhk8?t=02h01m14s)



[generated by something else in the code](https://youtu.be/j80xaF6Lhk8?t=02h01m16s)



[yeah it's not worth this is not worth a](https://youtu.be/j80xaF6Lhk8?t=02h01m19s)



[null check I would disagree on that one](https://youtu.be/j80xaF6Lhk8?t=02h01m22s)



[okay so command result here so innermost](https://youtu.be/j80xaF6Lhk8?t=02h01m26s)



[command so command argument right and](https://youtu.be/j80xaF6Lhk8?t=02h01m29s)



[again this is another one of these cases](https://youtu.be/j80xaF6Lhk8?t=02h01m32s)



[where how do you get a command argument](https://youtu.be/j80xaF6Lhk8?t=02h01m33s)



[without having a command result not](https://youtu.be/j80xaF6Lhk8?t=02h01m37s)



[possible with outside of an outside of](https://youtu.be/j80xaF6Lhk8?t=02h01m40s)



[another bug all right and we've got](https://youtu.be/j80xaF6Lhk8?t=02h01m43s)



[enough stuff checking in what are you](https://youtu.be/j80xaF6Lhk8?t=02h01m45s)



[squawking about here reference](https://youtu.be/j80xaF6Lhk8?t=02h01m46s)



[comparison yeah](https://youtu.be/j80xaF6Lhk8?t=02h01m48s)



[I think it just wants explicit that's a](https://youtu.be/j80xaF6Lhk8?t=02h01m49s)



[resharper ism okay option node again you](https://youtu.be/j80xaF6Lhk8?t=02h01m54s)



[can't get to an option without having a](https://youtu.be/j80xaF6Lhk8?t=02h01m58s)



[command therefore that will be set let's](https://youtu.be/j80xaF6Lhk8?t=02h02m00s)



[see](https://youtu.be/j80xaF6Lhk8?t=02h02m05s)



[err list I should just pin this rather](https://youtu.be/j80xaF6Lhk8?t=02h02m06s)



[than up down up down up down up down](https://youtu.be/j80xaF6Lhk8?t=02h02m09s)



[f8 also works to jump in visit option](https://youtu.be/j80xaF6Lhk8?t=02h02m12s)



[argument you're gonna have to explain](https://youtu.be/j80xaF6Lhk8?t=02h02m16s)



[this to me if you have a second I'm not](https://youtu.be/j80xaF6Lhk8?t=02h02m20s)



[tracking how that's not possible hit](https://youtu.be/j80xaF6Lhk8?t=02h02m23s)



[these sub methods without having a](https://youtu.be/j80xaF6Lhk8?t=02h02m24s)



[command note instantiated no that is a](https://youtu.be/j80xaF6Lhk8?t=02h02m26s)



[great question Raymond so I am going to](https://youtu.be/j80xaF6Lhk8?t=02h02m28s)



[first do to do grab one of the wiki](https://youtu.be/j80xaF6Lhk8?t=02h02m35s)



[pages because I am NOT going to try and](https://youtu.be/j80xaF6Lhk8?t=02h02m41s)



[do this whoa that is big let's not be so](https://youtu.be/j80xaF6Lhk8?t=02h02m43s)



[big so on here syntax concepts in](https://youtu.be/j80xaF6Lhk8?t=02h02m47s)



[parsing so John has gone through and](https://youtu.be/j80xaF6Lhk8?t=02h02m52s)



[written out a lot of really nice](https://youtu.be/j80xaF6Lhk8?t=02h02m55s)



[documentation so if your here John thank](https://youtu.be/j80xaF6Lhk8?t=02h02m57s)



[you](https://youtu.be/j80xaF6Lhk8?t=02h02m59s)



[it's wonderful and I will drop this in](https://youtu.be/j80xaF6Lhk8?t=02h03m00s)



[the chat boom](https://youtu.be/j80xaF6Lhk8?t=02h03m03s)



[explaining all of these types the key](https://youtu.be/j80xaF6Lhk8?t=02h03m07s)



[thing to know about this is when you](https://youtu.be/j80xaF6Lhk8?t=02h03m11s)



[invoke something on the command line](https://youtu.be/j80xaF6Lhk8?t=02h03m14s)



[ultimately all of that stuff that you](https://youtu.be/j80xaF6Lhk8?t=02h03m16s)



[type like if you type in dir slash a](https://youtu.be/j80xaF6Lhk8?t=02h03m19s)



[write that slash a is ultimately an](https://youtu.be/j80xaF6Lhk8?t=02h03m22s)



[option for command that you executed dir](https://youtu.be/j80xaF6Lhk8?t=02h03m26s)



[was the root level command and the](https://youtu.be/j80xaF6Lhk8?t=02h03m29s)



[command itself has an option that /ar](https://youtu.be/j80xaF6Lhk8?t=02h03m31s)



[- - all or whatever right and so in](https://youtu.be/j80xaF6Lhk8?t=02h03m34s)



[order to get to the part where you're](https://youtu.be/j80xaF6Lhk8?t=02h03m39s)



[actually processing an option there](https://youtu.be/j80xaF6Lhk8?t=02h03m40s)



[always has to be a root level command if](https://youtu.be/j80xaF6Lhk8?t=02h03m43s)



[there's not a root level command your](https://youtu.be/j80xaF6Lhk8?t=02h03m45s)



[terminal won't invoke the command line](https://youtu.be/j80xaF6Lhk8?t=02h03m47s)



[app and you'll never get this far so](https://youtu.be/j80xaF6Lhk8?t=02h03m49s)



[that's the principle that I'm operating](https://youtu.be/j80xaF6Lhk8?t=02h03m51s)



[on is that the only way to get here is](https://youtu.be/j80xaF6Lhk8?t=02h03m53s)



[I'm making the sweeping assumption that](https://youtu.be/j80xaF6Lhk8?t=02h03m56s)



[if I'm inside of this code that my code](https://youtu.be/j80xaF6Lhk8?t=02h03m59s)



[was executed](https://youtu.be/j80xaF6Lhk8?t=02h04m01s)



[which it sounds obvious but it's but](https://youtu.be/j80xaF6Lhk8?t=02h04m02s)



[that is an assumption right the other](https://youtu.be/j80xaF6Lhk8?t=02h04m06s)



[thing is though technically possible](https://youtu.be/j80xaF6Lhk8?t=02h04m07s)



[because this is just a visitor pattern](https://youtu.be/j80xaF6Lhk8?t=02h04m11s)



[or does start visit stop right and it's](https://youtu.be/j80xaF6Lhk8?t=02h04m12s)



[just got this switch at first glance it](https://youtu.be/j80xaF6Lhk8?t=02h04m16s)



[looks like it's very easy to get to](https://youtu.be/j80xaF6Lhk8?t=02h04m19s)



[these other like option notes without](https://youtu.be/j80xaF6Lhk8?t=02h04m21s)



[ever hitting the root command node](https://youtu.be/j80xaF6Lhk8?t=02h04m23s)



[correct](https://youtu.be/j80xaF6Lhk8?t=02h04m26s)



[yeah the root level the root command in](https://youtu.be/j80xaF6Lhk8?t=02h04m27s)



[question is actually the command line](https://youtu.be/j80xaF6Lhk8?t=02h04m30s)



[command yes so it'll be unless you so](https://youtu.be/j80xaF6Lhk8?t=02h04m32s)



[you either have to specify one or it'll](https://youtu.be/j80xaF6Lhk8?t=02h04m34s)



[default to the name of your executable](https://youtu.be/j80xaF6Lhk8?t=02h04m38s)



[at least that's how this library defines](https://youtu.be/j80xaF6Lhk8?t=02h04m39s)



[it so in order to get that far we had to](https://youtu.be/j80xaF6Lhk8?t=02h04m42s)



[have hit in a root level command](https://youtu.be/j80xaF6Lhk8?t=02h04m49s)



[technically it is possible to pass a a](https://youtu.be/j80xaF6Lhk8?t=02h04m51s)



[weird syntax node tree that doesn't](https://youtu.be/j80xaF6Lhk8?t=02h04m53s)



[conform to that ordering right that is](https://youtu.be/j80xaF6Lhk8?t=02h04m56s)



[that is certainly possible the problem](https://youtu.be/j80xaF6Lhk8?t=02h04m58s)



[is is I couldn't even write a test to do](https://youtu.be/j80xaF6Lhk8?t=02h05m01s)



[that because these things are internal](https://youtu.be/j80xaF6Lhk8?t=02h05m03s)



[classes so unless I do something to](https://youtu.be/j80xaF6Lhk8?t=02h05m06s)



[expose these internals outside of my](https://youtu.be/j80xaF6Lhk8?t=02h05m09s)



[library I know that the internals of my](https://youtu.be/j80xaF6Lhk8?t=02h05m11s)



[library don't actually even allow that](https://youtu.be/j80xaF6Lhk8?t=02h05m14s)



[to happen so if you look at our unit](https://youtu.be/j80xaF6Lhk8?t=02h05m15s)



[test most of them just take in a command](https://youtu.be/j80xaF6Lhk8?t=02h05m19s)



[line invocation and they have done it](https://youtu.be/j80xaF6Lhk8?t=02h05m21s)



[just laughing my mic around and there's](https://youtu.be/j80xaF6Lhk8?t=02h05m22s)



[no way for me to write up a command line](https://youtu.be/j80xaF6Lhk8?t=02h05m27s)



[command that could bypass this right I](https://youtu.be/j80xaF6Lhk8?t=02h05m29s)



[would fail a bunch of other tests before](https://youtu.be/j80xaF6Lhk8?t=02h05m32s)



[I could get a structure that would](https://youtu.be/j80xaF6Lhk8?t=02h05m34s)



[actually fail this so that's the](https://youtu.be/j80xaF6Lhk8?t=02h05m35s)



[assumption that I'm making and that's](https://youtu.be/j80xaF6Lhk8?t=02h05m37s)



[how I'm how I'm acting on it and saying](https://youtu.be/j80xaF6Lhk8?t=02h05m39s)



[it's not possible to get to an options](https://youtu.be/j80xaF6Lhk8?t=02h05m41s)



[argument without having a command first](https://youtu.be/j80xaF6Lhk8?t=02h05m44s)



[so I'm making I'm making those](https://youtu.be/j80xaF6Lhk8?t=02h05m48s)



[assumptions and just turning these off](https://youtu.be/j80xaF6Lhk8?t=02h05m51s)



[the visitor pattern does not lend itself](https://youtu.be/j80xaF6Lhk8?t=02h05m52s)



[well to this knowable reference type](https://youtu.be/j80xaF6Lhk8?t=02h05m54s)



[stuff so that's a bit unfortunate](https://youtu.be/j80xaF6Lhk8?t=02h05m56s)



[there's we could probably get fancy with](https://youtu.be/j80xaF6Lhk8?t=02h06m00s)



[some of these things and rewrite it but](https://youtu.be/j80xaF6Lhk8?t=02h06m03s)



[it seems like more trouble than just](https://youtu.be/j80xaF6Lhk8?t=02h06m05s)



[telling the compiler hands off trust me](https://youtu.be/j80xaF6Lhk8?t=02h06m08s)



[I know better](https://youtu.be/j80xaF6Lhk8?t=02h06m10s)



[I am programmer hear me roar](https://youtu.be/j80xaF6Lhk8?t=02h06m10s)



[okay option result though so this one](https://youtu.be/j80xaF6Lhk8?t=02h06m14s)



[here this one here I think is possible](https://youtu.be/j80xaF6Lhk8?t=02h06m18s)



[right so from the command we're going to](https://youtu.be/j80xaF6Lhk8?t=02h06m22s)



[look at the commands children and we're](https://youtu.be/j80xaF6Lhk8?t=02h06m24s)



[gonna get the result for a given option](https://youtu.be/j80xaF6Lhk8?t=02h06m26s)



[yeah](https://youtu.be/j80xaF6Lhk8?t=02h06m30s)



[nothing has ever gone wrong with Kevin](https://youtu.be/j80xaF6Lhk8?t=02h06m31s)



[just going now it's 11 o'clock](https://youtu.be/j80xaF6Lhk8?t=02h06m32s)



[just do it so result four right so this](https://youtu.be/j80xaF6Lhk8?t=02h06m35s)



[one we very much know is possible to](https://youtu.be/j80xaF6Lhk8?t=02h06m38s)



[return all right because it can iterate](https://youtu.be/j80xaF6Lhk8?t=02h06m40s)



[over single or default default case is](https://youtu.be/j80xaF6Lhk8?t=02h06m42s)



[definitely annul so yeah so that one](https://youtu.be/j80xaF6Lhk8?t=02h06m45s)



[that one can happen so this guy pulls it](https://youtu.be/j80xaF6Lhk8?t=02h06m51s)



[out though it is so here's the here's](https://youtu.be/j80xaF6Lhk8?t=02h06m57s)



[the one thing though right like this](https://youtu.be/j80xaF6Lhk8?t=02h07m03s)



[says result for option right and it's](https://youtu.be/j80xaF6Lhk8?t=02h07m05s)



[passing this guy in how would we get](https://youtu.be/j80xaF6Lhk8?t=02h07m09s)



[here right like in order to build a test](https://youtu.be/j80xaF6Lhk8?t=02h07m15s)



[to cause this to occur I would have to](https://youtu.be/j80xaF6Lhk8?t=02h07m17s)



[have an argument node with a parent](https://youtu.be/j80xaF6Lhk8?t=02h07m20s)



[option and the the option would have to](https://youtu.be/j80xaF6Lhk8?t=02h07m23s)



[to be a child of the command but when I](https://youtu.be/j80xaF6Lhk8?t=02h07m33s)



[ask the command for the result for the](https://youtu.be/j80xaF6Lhk8?t=02h07m37s)



[option it would have to give me back a](https://youtu.be/j80xaF6Lhk8?t=02h07m39s)



[null is there an extra level to this no](https://youtu.be/j80xaF6Lhk8?t=02h07m41s)



[this is literally just iterating over](https://youtu.be/j80xaF6Lhk8?t=02h07m45s)



[items](https://youtu.be/j80xaF6Lhk8?t=02h07m47s)



[yeah I don't think this is possible](https://youtu.be/j80xaF6Lhk8?t=02h07m54s)



[either so this then asks for the](https://youtu.be/j80xaF6Lhk8?t=02h07m56s)



[argument which is possible because you](https://youtu.be/j80xaF6Lhk8?t=02h07m59s)



[can have one without it because](https://youtu.be/j80xaF6Lhk8?t=02h08m01s)



[arguments could be omitted in the case](https://youtu.be/j80xaF6Lhk8?t=02h08m04s)



[of defaults that is possible let's see](https://youtu.be/j80xaF6Lhk8?t=02h08m06s)



[here so if that is the case ok that](https://youtu.be/j80xaF6Lhk8?t=02h08m12s)



[handles that it's even later over here](https://youtu.be/j80xaF6Lhk8?t=02h08m21s)



[what time zone are you in Raymond](https://youtu.be/j80xaF6Lhk8?t=02h08m24s)



[Utah so let's see when I travel a Salt](https://youtu.be/j80xaF6Lhk8?t=02h08m33s)



[Lake that's one hour ahead I think two](https://youtu.be/j80xaF6Lhk8?t=02h08m37s)



[hours ahead is it central to mountain](https://youtu.be/j80xaF6Lhk8?t=02h08m40s)



[I trust my phone one hour okay so again](https://youtu.be/j80xaF6Lhk8?t=02h08m42s)



[stop not possible to get to this point](https://youtu.be/j80xaF6Lhk8?t=02h08m48s)



[without starting therefore we're gonna](https://youtu.be/j80xaF6Lhk8?t=02h08m50s)



[call it](https://youtu.be/j80xaF6Lhk8?t=02h08m53s)



[yeah Mountain standard one-hour know one](https://youtu.be/j80xaF6Lhk8?t=02h08m54s)



[of my clients that I work for is in or I](https://youtu.be/j80xaF6Lhk8?t=02h08m57s)



[should say just outside of Salt Lake so](https://youtu.be/j80xaF6Lhk8?t=02h09m01s)



[been over there a couple times but not](https://youtu.be/j80xaF6Lhk8?t=02h09m03s)



[likely not likely to travel much right](https://youtu.be/j80xaF6Lhk8?t=02h09m06s)



[now let's see innermost command validate](https://youtu.be/j80xaF6Lhk8?t=02h09m09s)



[command result I want to check this](https://youtu.be/j80xaF6Lhk8?t=02h09m14s)



[didn't see where it's invoked from yeah](https://youtu.be/j80xaF6Lhk8?t=02h09m15s)



[so after after a stop so this guy is not](https://youtu.be/j80xaF6Lhk8?t=02h09m18s)



[possible route command result again we](https://youtu.be/j80xaF6Lhk8?t=02h09m22s)



[would have to get here without a route](https://youtu.be/j80xaF6Lhk8?t=02h09m25s)



[command not possible and let's see here](https://youtu.be/j80xaF6Lhk8?t=02h09m27s)



[that one we just handled this one's fun](https://youtu.be/j80xaF6Lhk8?t=02h09m34s)



[already failure so we get a failure](https://youtu.be/j80xaF6Lhk8?t=02h09m38s)



[error message is nullable because it's](https://youtu.be/j80xaF6Lhk8?t=02h09m43s)



[possible to new up one of these guys](https://youtu.be/j80xaF6Lhk8?t=02h09m49s)



[without having it so is it possible to](https://youtu.be/j80xaF6Lhk8?t=02h09m51s)



[get into here and get a failure without](https://youtu.be/j80xaF6Lhk8?t=02h09m55s)



[a message alright so we have this guy](https://youtu.be/j80xaF6Lhk8?t=02h10m00s)



[returns non-null but his new error](https://youtu.be/j80xaF6Lhk8?t=02h10m09s)



[message is null](https://youtu.be/j80xaF6Lhk8?t=02h10m13s)



[so that's not well hey I don't like this](https://youtu.be/j80xaF6Lhk8?t=02h10m18s)



[right because technically so we allow](https://youtu.be/j80xaF6Lhk8?t=02h10m27s)



[these air messages to be injected right](https://youtu.be/j80xaF6Lhk8?t=02h10m37s)



[somebody could set these up so we don't](https://youtu.be/j80xaF6Lhk8?t=02h10m40s)



[have localizations setup yeah Megan](https://youtu.be/j80xaF6Lhk8?t=02h10m43s)



[flights are so cheap yeah I have a](https://youtu.be/j80xaF6Lhk8?t=02h10m51s)



[feeling my wife would have other](https://youtu.be/j80xaF6Lhk8?t=02h10m53s)



[thoughts if I said I was flying](https://youtu.be/j80xaF6Lhk8?t=02h10m54s)



[somewhere right about now](https://youtu.be/j80xaF6Lhk8?t=02h10m56s)



[oh cool yeah Raymond I'll hit you up](https://youtu.be/j80xaF6Lhk8?t=02h10m58s)



[last time I was down there I ended up](https://youtu.be/j80xaF6Lhk8?t=02h11m03s)



[hanging out just in the the airport at](https://youtu.be/j80xaF6Lhk8?t=02h11m05s)



[Salt Lake for like five or six hours](https://youtu.be/j80xaF6Lhk8?t=02h11m08s)



[because we got done early and I had](https://youtu.be/j80xaF6Lhk8?t=02h11m10s)



[nothing to do but yeah shoot me an email](https://youtu.be/j80xaF6Lhk8?t=02h11m13s)



[with your or I guess or hit me up on](https://youtu.be/j80xaF6Lhk8?t=02h11m18s)



[Gator with your contact info and I will](https://youtu.be/j80xaF6Lhk8?t=02h11m22s)



[let you know obviously it might be a](https://youtu.be/j80xaF6Lhk8?t=02h11m25s)



[while but yeah so back to this though](https://youtu.be/j80xaF6Lhk8?t=02h11m27s)



[right](https://youtu.be/j80xaF6Lhk8?t=02h11m31s)



[so validation messages is set up for](https://youtu.be/j80xaF6Lhk8?t=02h11m31s)



[localization with the idea being that](https://youtu.be/j80xaF6Lhk8?t=02h11m33s)



[you know if somebody wanted to go](https://youtu.be/j80xaF6Lhk8?t=02h11m36s)



[through and localize this for Spanish](https://youtu.be/j80xaF6Lhk8?t=02h11m37s)



[French whatever right it's it can be](https://youtu.be/j80xaF6Lhk8?t=02h11m39s)



[done right all of these messages are](https://youtu.be/j80xaF6Lhk8?t=02h11m42s)



[over idle so the only way](https://youtu.be/j80xaF6Lhk8?t=02h11m45s)



[I don't like this right because the it](https://youtu.be/j80xaF6Lhk8?t=02h11m57s)



[is the only way to do this to get a null](https://youtu.be/j80xaF6Lhk8?t=02h12m00s)



[in here would be to override the](https://youtu.be/j80xaF6Lhk8?t=02h12m03s)



[validation messages explicitly return a](https://youtu.be/j80xaF6Lhk8?t=02h12m07s)



[null and then it then it could happen](https://youtu.be/j80xaF6Lhk8?t=02h12m10s)



[right because then parse air comes in](https://youtu.be/j80xaF6Lhk8?t=02h12m15s)



[here right message comes in you know](https://youtu.be/j80xaF6Lhk8?t=02h12m17s)



[what I'm gonna propose that we do this](https://youtu.be/j80xaF6Lhk8?t=02h12m26s)



[tell the compiler hands off because if](https://youtu.be/j80xaF6Lhk8?t=02h12m29s)



[the null case does occur the person who](https://youtu.be/j80xaF6Lhk8?t=02h12m33s)



[did it is going to promptly get an](https://youtu.be/j80xaF6Lhk8?t=02h12m36s)



[argument exception not a no reference](https://youtu.be/j80xaF6Lhk8?t=02h12m37s)



[exception telling them that the value](https://youtu.be/j80xaF6Lhk8?t=02h12m40s)



[cannot be null or whitespace I think](https://youtu.be/j80xaF6Lhk8?t=02h12m42s)



[that makes sense](https://youtu.be/j80xaF6Lhk8?t=02h12m49s)



[I again technically possible on an](https://youtu.be/j80xaF6Lhk8?t=02h12m49s)



[outside chance like I could write the](https://youtu.be/j80xaF6Lhk8?t=02h12m53s)



[code to do it but you'd have to write](https://youtu.be/j80xaF6Lhk8?t=02h12m55s)



[the code to do it be in a c-sharp seven](https://youtu.be/j80xaF6Lhk8?t=02h12m59s)



[or a non knowable context so you](https://youtu.be/j80xaF6Lhk8?t=02h13m02s)



[wouldn't get warned about the null yeah](https://youtu.be/j80xaF6Lhk8?t=02h13m04s)



[it just it seems very very unlikely ok](https://youtu.be/j80xaF6Lhk8?t=02h13m07s)



[validate command handler let's see here](https://youtu.be/j80xaF6Lhk8?t=02h13m12s)



[did to do so this guy here this guy here](https://youtu.be/j80xaF6Lhk8?t=02h13m22s)



[this guy here great great great you'll](https://youtu.be/j80xaF6Lhk8?t=02h13m27s)



[note that it is somewhat intelligent](https://youtu.be/j80xaF6Lhk8?t=02h13m30s)



[excuse me in that I use this guy here to](https://youtu.be/j80xaF6Lhk8?t=02h13m31s)



[say not null and it knows that these](https://youtu.be/j80xaF6Lhk8?t=02h13m37s)



[guys are now also not know further down](https://youtu.be/j80xaF6Lhk8?t=02h13m39s)



[because if it was null this throws a no](https://youtu.be/j80xaF6Lhk8?t=02h13m41s)



[reference exception so huzzah okay again](https://youtu.be/j80xaF6Lhk8?t=02h13m43s)



[this is the same situation with the](https://youtu.be/j80xaF6Lhk8?t=02h13m48s)



[error message so I'm just going to turn](https://youtu.be/j80xaF6Lhk8?t=02h13m49s)



[it off it's technically possible highly](https://youtu.be/j80xaF6Lhk8?t=02h13m51s)



[unlikely](https://youtu.be/j80xaF6Lhk8?t=02h13m56s)



[this one is more interesting so let's](https://youtu.be/j80xaF6Lhk8?t=02h14m00s)



[see we've got an argument result and an](https://youtu.be/j80xaF6Lhk8?t=02h14m03s)



[argument result where the parent could](https://youtu.be/j80xaF6Lhk8?t=02h14m07s)



[possibly be null](https://youtu.be/j80xaF6Lhk8?t=02h14m10s)



[so how would you get an argument results](https://youtu.be/j80xaF6Lhk8?t=02h14m16s)



[let's look this so parent clearly can](https://youtu.be/j80xaF6Lhk8?t=02h14m25s)



[come in as null but on this guy's](https://youtu.be/j80xaF6Lhk8?t=02h14m30s)



[constructor again I'm noticing that the](https://youtu.be/j80xaF6Lhk8?t=02h14m33s)



[Constructors internal which means I can](https://youtu.be/j80xaF6Lhk8?t=02h14m35s)



[make certain assumptions about its usage](https://youtu.be/j80xaF6Lhk8?t=02h14m38s)



[most notably that no one outside is](https://youtu.be/j80xaF6Lhk8?t=02h14m41s)



[going to mess with it](https://youtu.be/j80xaF6Lhk8?t=02h14m44s)



[so there is this one down here on a](https://youtu.be/j80xaF6Lhk8?t=02h14m48s)



[convert right which would require this](https://youtu.be/j80xaF6Lhk8?t=02h14m52s)



[is inside of it so it would require an](https://youtu.be/j80xaF6Lhk8?t=02h14m58s)



[instance where my parent ought was](https://youtu.be/j80xaF6Lhk8?t=02h15m00s)



[already know so that's not as likely](https://youtu.be/j80xaF6Lhk8?t=02h15m02s)



[command results is this guy knowable](https://youtu.be/j80xaF6Lhk8?t=02h15m07s)



[technically yes but no because no](https://youtu.be/j80xaF6Lhk8?t=02h15m12s)



[there's that guy's non knowable option](https://youtu.be/j80xaF6Lhk8?t=02h15m16s)



[results non nullable see oh oh could not](https://youtu.be/j80xaF6Lhk8?t=02h15m19s)



[be null because we would have blown up](https://youtu.be/j80xaF6Lhk8?t=02h15m28s)



[there instead so those are all non null](https://youtu.be/j80xaF6Lhk8?t=02h15m29s)



[this is non Oh](https://youtu.be/j80xaF6Lhk8?t=02h15m34s)



[this appears to be the only place where](https://youtu.be/j80xaF6Lhk8?t=02h15m42s)



[it happens](https://youtu.be/j80xaF6Lhk8?t=02h15m46s)



[very clearly being passed in default](https://youtu.be/j80xaF6Lhk8?t=02h15m53s)



[value factory parent is null yeah cuz](https://youtu.be/j80xaF6Lhk8?t=02h15m59s)



[it's just looking up the default value](https://youtu.be/j80xaF6Lhk8?t=02h16m04s)



[that feels like an awkward API but again](https://youtu.be/j80xaF6Lhk8?t=02h16m06s)



[not here to fix API the key part is](https://youtu.be/j80xaF6Lhk8?t=02h16m09s)



[there is a technically away so the only](https://youtu.be/j80xaF6Lhk8?t=02h16m14s)



[use case where we instantiate it with a](https://youtu.be/j80xaF6Lhk8?t=02h16m20s)



[null parent](https://youtu.be/j80xaF6Lhk8?t=02h16m22s)



[is when we're getting the default value](https://youtu.be/j80xaF6Lhk8?t=02h16m31s)



[for it it's not possible to hit that as](https://youtu.be/j80xaF6Lhk8?t=02h16m34s)



[part of the person](https://youtu.be/j80xaF6Lhk8?t=02h16m38s)



[because it's not possible as part of the](https://youtu.be/j80xaF6Lhk8?t=02h16m43s)



[party I almost don't like doing it here](https://youtu.be/j80xaF6Lhk8?t=02h16m45s)



[only because though it's currently not](https://youtu.be/j80xaF6Lhk8?t=02h16m47s)



[possible](https://youtu.be/j80xaF6Lhk8?t=02h16m51s)



[somebody could change that in a very](https://youtu.be/j80xaF6Lhk8?t=02h16m51s)



[disparate area of the code and then it](https://youtu.be/j80xaF6Lhk8?t=02h16m54s)



[would be possible so yeah Megan so the](https://youtu.be/j80xaF6Lhk8?t=02h16m56s)



[answer is right now we're inside of the](https://youtu.be/j80xaF6Lhk8?t=02h17m05s)



[parse results visitor so this is](https://youtu.be/j80xaF6Lhk8?t=02h17m07s)



[somewhat domain knowledge of how the](https://youtu.be/j80xaF6Lhk8?t=02h17m10s)



[project is set up so this visitor is](https://youtu.be/j80xaF6Lhk8?t=02h17m12s)



[acting over all of the partial results](https://youtu.be/j80xaF6Lhk8?t=02h17m15s)



[and the only place when we look at the](https://youtu.be/j80xaF6Lhk8?t=02h17m19s)



[argue so this is argument result dot](https://youtu.be/j80xaF6Lhk8?t=02h17m24s)



[parent right and the only way to get in](https://youtu.be/j80xaF6Lhk8?t=02h17m27s)



[are the the parent to be null is to pass](https://youtu.be/j80xaF6Lhk8?t=02h17m30s)



[it through the argument results](https://youtu.be/j80xaF6Lhk8?t=02h17m33s)



[constructor and the only place where a](https://youtu.be/j80xaF6Lhk8?t=02h17m34s)



[null is possible to pass into the](https://youtu.be/j80xaF6Lhk8?t=02h17m38s)



[argument result constructor is this one](https://youtu.be/j80xaF6Lhk8?t=02h17m41s)



[here but this one here is used to](https://youtu.be/j80xaF6Lhk8?t=02h17m43s)



[retrieve the default value which is](https://youtu.be/j80xaF6Lhk8?t=02h17m47s)



[never going to be used as part of the](https://youtu.be/j80xaF6Lhk8?t=02h17m49s)



[parse results which is why it's not](https://youtu.be/j80xaF6Lhk8?t=02h17m53s)



[possible however I only know that](https://youtu.be/j80xaF6Lhk8?t=02h17m59s)



[because I dug through you know all what](https://youtu.be/j80xaF6Lhk8?t=02h18m01s)



[is this three five six references to the](https://youtu.be/j80xaF6Lhk8?t=02h18m05s)



[constructor to figure out all their](https://youtu.be/j80xaF6Lhk8?t=02h18m08s)



[usages so with the current six usages](https://youtu.be/j80xaF6Lhk8?t=02h18m09s)



[it's not possible I know that parent](https://youtu.be/j80xaF6Lhk8?t=02h18m13s)



[will always be set on every instance](https://youtu.be/j80xaF6Lhk8?t=02h18m15s)



[that makes it into here but only because](https://youtu.be/j80xaF6Lhk8?t=02h18m17s)



[I went through and looked at it it](https://youtu.be/j80xaF6Lhk8?t=02h18m21s)



[doesn't mean somebody couldn't just add](https://youtu.be/j80xaF6Lhk8?t=02h18m22s)



[another invocation of the constructor](https://youtu.be/j80xaF6Lhk8?t=02h18m24s)



[somewhere in parsing that past null is](https://youtu.be/j80xaF6Lhk8?t=02h18m26s)



[the parent and get away with it and](https://youtu.be/j80xaF6Lhk8?t=02h18m27s)



[that's why it's like so currently this](https://youtu.be/j80xaF6Lhk8?t=02h18m32s)



[would be valid but I cannot say that](https://youtu.be/j80xaF6Lhk8?t=02h18m35s)



[somebody wouldn't change that assumption](https://youtu.be/j80xaF6Lhk8?t=02h18m38s)



[that I'm making sometime in the future](https://youtu.be/j80xaF6Lhk8?t=02h18m40s)



[okay I think you just talked me out of](https://youtu.be/j80xaF6Lhk8?t=02h18m42s)



[it or I talked myself into it I just](https://youtu.be/j80xaF6Lhk8?t=02h18m44s)



[hate it because in in all of the cases](https://youtu.be/j80xaF6Lhk8?t=02h18m48s)



[that exist now parent will not be null](https://youtu.be/j80xaF6Lhk8?t=02h18m51s)



[here in all of the cases that exist now](https://youtu.be/j80xaF6Lhk8?t=02h18m53s)



[ah it feels like what I would rather do](https://youtu.be/j80xaF6Lhk8?t=02h18m57s)



[is so longer-term I think what would be](https://youtu.be/j80xaF6Lhk8?t=02h19m02s)



[potentially cleaner right so the other](https://youtu.be/j80xaF6Lhk8?t=02h19m06s)



[thing is I believe parent is internal to](https://youtu.be/j80xaF6Lhk8?t=02h19m09s)



[know it's public interesting](https://youtu.be/j80xaF6Lhk8?t=02h19m11s)



[I think longer-term what I would love to](https://youtu.be/j80xaF6Lhk8?t=02h19m14s)



[do is see about refactoring this such](https://youtu.be/j80xaF6Lhk8?t=02h19m16s)



[that parent didn't necessarily need to](https://youtu.be/j80xaF6Lhk8?t=02h19m18s)



[be here or make parent non knowable non](https://youtu.be/j80xaF6Lhk8?t=02h19m20s)



[no make parent not knowable that's what](https://youtu.be/j80xaF6Lhk8?t=02h19m24s)



[we're going for](https://youtu.be/j80xaF6Lhk8?t=02h19m28s)



[that way we don't have to deal with this](https://youtu.be/j80xaF6Lhk8?t=02h19m30s)



[yucky case right because the only reason](https://youtu.be/j80xaF6Lhk8?t=02h19m31s)



[it's knowable is because we've got this](https://youtu.be/j80xaF6Lhk8?t=02h19m33s)



[this stupid case here where this API](https://youtu.be/j80xaF6Lhk8?t=02h19m36s)



[wants to act on an argument result and](https://youtu.be/j80xaF6Lhk8?t=02h19m39s)



[so we have to create one and because](https://youtu.be/j80xaF6Lhk8?t=02h19m41s)



[we're just creating one willy-nilly we](https://youtu.be/j80xaF6Lhk8?t=02h19m45s)



[pass null for the parent right and then](https://youtu.be/j80xaF6Lhk8?t=02h19m48s)



[this guy goes and does a factory](https://youtu.be/j80xaF6Lhk8?t=02h19m52s)



[call-out which could be in a third party](https://youtu.be/j80xaF6Lhk8?t=02h19m54s)



[which is fine but it feels like the](https://youtu.be/j80xaF6Lhk8?t=02h19m56s)



[problem is this this API right like this](https://youtu.be/j80xaF6Lhk8?t=02h20m01s)



[if it wasn't trying to act on this](https://youtu.be/j80xaF6Lhk8?t=02h20m04s)



[result or there was something else or](https://youtu.be/j80xaF6Lhk8?t=02h20m07s)



[something right again this is not I am](https://youtu.be/j80xaF6Lhk8?t=02h20m10s)



[NOT refactoring I am NOT refactoring I'm](https://youtu.be/j80xaF6Lhk8?t=02h20m14s)



[resisting the urge to refactor okay](https://youtu.be/j80xaF6Lhk8?t=02h20m16s)



[error message again I'm just gonna say](https://youtu.be/j80xaF6Lhk8?t=02h20m19s)



[not possible not reasonably possible](https://youtu.be/j80xaF6Lhk8?t=02h20m21s)



[this guy populate default values I](https://youtu.be/j80xaF6Lhk8?t=02h20m24s)



[believe this is called only once at the](https://youtu.be/j80xaF6Lhk8?t=02h20m27s)



[very end yeah so this is only called](https://youtu.be/j80xaF6Lhk8?t=02h20m29s)



[once at the very end of it you sound](https://youtu.be/j80xaF6Lhk8?t=02h20m31s)



[like an addict I am NOT addicted to](https://youtu.be/j80xaF6Lhk8?t=02h20m35s)



[Mountain Dew](https://youtu.be/j80xaF6Lhk8?t=02h20m38s)



[I just consume it in copious amounts](https://youtu.be/j80xaF6Lhk8?t=02h20m38s)



[I will say it feels like the caffeine is](https://youtu.be/j80xaF6Lhk8?t=02h20m47s)



[slowly doing less and less for me with](https://youtu.be/j80xaF6Lhk8?t=02h20m49s)



[all of this stay-at-home thing I feel](https://youtu.be/j80xaF6Lhk8?t=02h20m52s)



[like I consume more caffeine when I'm at](https://youtu.be/j80xaF6Lhk8?t=02h20m54s)



[home than when I'm in the office I don't](https://youtu.be/j80xaF6Lhk8?t=02h20m56s)



[know if that's a good thing so recurse](https://youtu.be/j80xaF6Lhk8?t=02h21m00s)



[while not null so this this feels like](https://youtu.be/j80xaF6Lhk8?t=02h21m02s)



[something where if it's explicitly going](https://youtu.be/j80xaF6Lhk8?t=02h21m10s)



[to check it for null something like that](https://youtu.be/j80xaF6Lhk8?t=02h21m17s)



[I think right](https://youtu.be/j80xaF6Lhk8?t=02h21m24s)



[does that do it oh no because that](https://youtu.be/j80xaF6Lhk8?t=02h21m29s)



[doesn't actually change that I think](https://youtu.be/j80xaF6Lhk8?t=02h21m35s)



[what I want is nillable class I think I](https://youtu.be/j80xaF6Lhk8?t=02h21m40s)



[even want to go further than that right](https://youtu.be/j80xaF6Lhk8?t=02h21m48s)



[I think I want this](https://youtu.be/j80xaF6Lhk8?t=02h21m49s)



[because yield returns source so the](https://youtu.be/j80xaF6Lhk8?t=02h21m52s)



[assumption being that source is not null](https://youtu.be/j80xaF6Lhk8?t=02h21m58s)



[and](https://youtu.be/j80xaF6Lhk8?t=02h22m02s)



[so converting the two non knowable type](https://youtu.be/j80xaF6Lhk8?t=02h22m11s)



[okay so what have we done so the problem](https://youtu.be/j80xaF6Lhk8?t=02h22m13s)



[is is if we declare this is knowable so](https://youtu.be/j80xaF6Lhk8?t=02h22m16s)



[let's just do this if source is null](https://youtu.be/j80xaF6Lhk8?t=02h22m25s)



[yield break yeah Raymond so I I think my](https://youtu.be/j80xaF6Lhk8?t=02h22m33s)



[plan is going to be streaming Tuesday](https://youtu.be/j80xaF6Lhk8?t=02h22m40s)



[nights now the the Cova thing has](https://youtu.be/j80xaF6Lhk8?t=02h22m43s)



[screwed up my schedule so I was doing](https://youtu.be/j80xaF6Lhk8?t=02h22m46s)



[Thursday's I think I'm now doing](https://youtu.be/j80xaF6Lhk8?t=02h22m49s)



[Tuesday's I think it may not be every](https://youtu.be/j80xaF6Lhk8?t=02h22m50s)



[week it may be every other week](https://youtu.be/j80xaF6Lhk8?t=02h22m53s)



[I'm still trying to figure out my](https://youtu.be/j80xaF6Lhk8?t=02h22m54s)



[schedule and how it's gonna work so I](https://youtu.be/j80xaF6Lhk8?t=02h22m56s)



[think Tuesday ish nights I'll post it up](https://youtu.be/j80xaF6Lhk8?t=02h22m58s)



[on my Twitter but probably Tuesday](https://youtu.be/j80xaF6Lhk8?t=02h23m02s)



[nights is going to be the schedule I](https://youtu.be/j80xaF6Lhk8?t=02h23m11s)



[think help so](https://youtu.be/j80xaF6Lhk8?t=02h23m13s)



[yeah so I think we do this that way the](https://youtu.be/j80xaF6Lhk8?t=02h23m19s)



[enumerable can keep returning non](https://youtu.be/j80xaF6Lhk8?t=02h23m24s)



[knowable things this thing handles the](https://youtu.be/j80xaF6Lhk8?t=02h23m26s)



[null case right out the gate and then](https://youtu.be/j80xaF6Lhk8?t=02h23m28s)



[everyone gets to be happy I think I like](https://youtu.be/j80xaF6Lhk8?t=02h23m30s)



[that we're going with it okay so yeah](https://youtu.be/j80xaF6Lhk8?t=02h23m35s)



[you too Raymond have a good night](https://youtu.be/j80xaF6Lhk8?t=02h23m42s)



[I realize it's like 12:30 there I should](https://youtu.be/j80xaF6Lhk8?t=02h23m43s)



[probably be considering bed shortly but](https://youtu.be/j80xaF6Lhk8?t=02h23m47s)



[I feel I feel like I want to get this](https://youtu.be/j80xaF6Lhk8?t=02h23m49s)



[further there's just so much here okay I](https://youtu.be/j80xaF6Lhk8?t=02h23m52s)



[think I have covered all of these okay](https://youtu.be/j80xaF6Lhk8?t=02h23m56s)



[so that one's covered what do you](https://youtu.be/j80xaF6Lhk8?t=02h24m01s)



[command results see oh because you are](https://youtu.be/j80xaF6Lhk8?t=02h24m05s)



[technically non-null hmm if we change](https://youtu.be/j80xaF6Lhk8?t=02h24m09s)



[this ha ha I think we can do this though](https://youtu.be/j80xaF6Lhk8?t=02h24m16s)



[right because we know every value that](https://youtu.be/j80xaF6Lhk8?t=02h24m20s)



[we pass into this lambda will be non](https://youtu.be/j80xaF6Lhk8?t=02h24m25s)



[null yes that is definitely a myth have](https://youtu.be/j80xaF6Lhk8?t=02h24m27s)



[a good night Raymond yeah so that fixes](https://youtu.be/j80xaF6Lhk8?t=02h24m33s)



[that and then we don't have to propagate](https://youtu.be/j80xaF6Lhk8?t=02h24m37s)



[it okay that's a little cleaner that's a](https://youtu.be/j80xaF6Lhk8?t=02h24m38s)



[little happier they're fixed they're](https://youtu.be/j80xaF6Lhk8?t=02h24m43s)



[fixed they're fixed okay so a parse](https://youtu.be/j80xaF6Lhk8?t=02h24m47s)



[result and again this is one of those I](https://youtu.be/j80xaF6Lhk8?t=02h24m54s)



[know the only way to get here is to have](https://youtu.be/j80xaF6Lhk8?t=02h24m56s)



[these things already dwell hold on hold](https://youtu.be/j80xaF6Lhk8?t=02h25m02s)



[on hold on this guy is interesting](https://youtu.be/j80xaF6Lhk8?t=02h25m04s)



[could we get here we could very easily](https://youtu.be/j80xaF6Lhk8?t=02h25m09s)



[get here](https://youtu.be/j80xaF6Lhk8?t=02h25m16s)



[I could new up one of these guys well no](https://youtu.be/j80xaF6Lhk8?t=02h25m17s)



[like so mmm](https://youtu.be/j80xaF6Lhk8?t=02h25m25s)



[so I couldn't if this guy was nude up](https://youtu.be/j80xaF6Lhk8?t=02h25m27s)



[right so nothing in the constructor sets](https://youtu.be/j80xaF6Lhk8?t=02h25m29s)



[either these these guys and then call](https://youtu.be/j80xaF6Lhk8?t=02h25m32s)



[dot result right away that would](https://youtu.be/j80xaF6Lhk8?t=02h25m35s)



[certainly do it interesting so that I](https://youtu.be/j80xaF6Lhk8?t=02h25m39s)



[don't think it's fair to make that](https://youtu.be/j80xaF6Lhk8?t=02h25m49s)



[assumption but I think what is fair to](https://youtu.be/j80xaF6Lhk8?t=02h25m52s)



[do is throw new valid operation](https://youtu.be/j80xaF6Lhk8?t=02h25m56s)



[exception and I don't know what the](https://youtu.be/j80xaF6Lhk8?t=02h26m04s)



[message should be so yeah I'm sure](https://youtu.be/j80xaF6Lhk8?t=02h26m07s)



[somebody will have a strong opinion](https://youtu.be/j80xaF6Lhk8?t=02h26m16s)



[about what the message should be and I](https://youtu.be/j80xaF6Lhk8?t=02h26m17s)



[don't know what it is so there's that](https://youtu.be/j80xaF6Lhk8?t=02h26m19s)



[there's that okay](https://youtu.be/j80xaF6Lhk8?t=02h26m21s)



[clean some of these guys up](https://youtu.be/j80xaF6Lhk8?t=02h26m28s)



[okay so all argument results so let's](https://youtu.be/j80xaF6Lhk8?t=02h26m32s)



[let's look at this guy](https://youtu.be/j80xaF6Lhk8?t=02h26m35s)



[so where where are we at we are in a](https://youtu.be/j80xaF6Lhk8?t=02h26m37s)



[root command result right so once again](https://youtu.be/j80xaF6Lhk8?t=02h26m40s)



[we've got this case where we've got some](https://youtu.be/j80xaF6Lhk8?t=02h26m44s)



[fields we invoke the constructor](https://youtu.be/j80xaF6Lhk8?t=02h26m47s)



[they aren't set so clearly no right](https://youtu.be/j80xaF6Lhk8?t=02h26m49s)



[after the Constructors invoked okay so](https://youtu.be/j80xaF6Lhk8?t=02h26m53s)



[then we look at this add symbol to](https://youtu.be/j80xaF6Lhk8?t=02h26m57s)



[symbol map this guy gets invoked this](https://youtu.be/j80xaF6Lhk8?t=02h27m01s)



[indenting bothers me and these guys](https://youtu.be/j80xaF6Lhk8?t=02h27m07s)



[could be null so what](https://youtu.be/j80xaF6Lhk8?t=02h27m11s)



[ensure result maps are initialized is](https://youtu.be/j80xaF6Lhk8?t=02h27m19s)



[what sets them find results for I kind](https://youtu.be/j80xaF6Lhk8?t=02h27m22s)



[of think I just need to be calling this](https://youtu.be/j80xaF6Lhk8?t=02h27m31s)



[and then doing exclamation points](https://youtu.be/j80xaF6Lhk8?t=02h27m34s)



[because these ones were easy right like](https://youtu.be/j80xaF6Lhk8?t=02h27m35s)



[these guys all call ensure result maps](https://youtu.be/j80xaF6Lhk8?t=02h27m38s)



[are initialized great and so it's got an](https://youtu.be/j80xaF6Lhk8?t=02h27m40s)



[early return I think that's what we do I](https://youtu.be/j80xaF6Lhk8?t=02h27m47s)



[think we come down here we add this and](https://youtu.be/j80xaF6Lhk8?t=02h27m51s)



[then we just say you will not be no you](https://youtu.be/j80xaF6Lhk8?t=02h27m56s)



[will not be no you will not know and](https://youtu.be/j80xaF6Lhk8?t=02h28m01s)



[unit tests confirm I don't break](https://youtu.be/j80xaF6Lhk8?t=02h28m07s)



[anything by doing that excellent so](https://youtu.be/j80xaF6Lhk8?t=02h28m09s)



[carry on the merry way string extensions](https://youtu.be/j80xaF6Lhk8?t=02h28m13s)



[okay this one's going to be interesting](https://youtu.be/j80xaF6Lhk8?t=02h28m16s)



[so here we've got some really fun cases](https://youtu.be/j80xaF6Lhk8?t=02h28m18s)



[so shield your eyes it's going to get](https://youtu.be/j80xaF6Lhk8?t=02h28m22s)



[ugly so we have some some some methods](https://youtu.be/j80xaF6Lhk8?t=02h28m26s)



[in here all right and they're kind of](https://youtu.be/j80xaF6Lhk8?t=02h28m32s)



[bigger than you would normally want to](https://youtu.be/j80xaF6Lhk8?t=02h28m36s)



[write for example this method here](https://youtu.be/j80xaF6Lhk8?t=02h28m38s)



[tokenize which is sort of the big the](https://youtu.be/j80xaF6Lhk8?t=02h28m41s)



[big method right you get it you get some](https://youtu.be/j80xaF6Lhk8?t=02h28m44s)



[some random string array from your main](https://youtu.be/j80xaF6Lhk8?t=02h28m47s)



[method right and you've got to turn it](https://youtu.be/j80xaF6Lhk8?t=02h28m51s)



[into tokens and so it's got all kinds of](https://youtu.be/j80xaF6Lhk8?t=02h28m52s)



[rules and parsing and all kinds of](https://youtu.be/j80xaF6Lhk8?t=02h28m55s)



[magical stuff this is the sucky part of](https://youtu.be/j80xaF6Lhk8?t=02h28m58s)



[if you try to parse that string array](https://youtu.be/j80xaF6Lhk8?t=02h29m00s)



[yourself inside of your main all right](https://youtu.be/j80xaF6Lhk8?t=02h29m03s)



[to do it right requires a whole bunch of](https://youtu.be/j80xaF6Lhk8?t=02h29m05s)



[ugly alright so here here we get into a](https://youtu.be/j80xaF6Lhk8?t=02h29m07s)



[really weird situation because now we've](https://youtu.be/j80xaF6Lhk8?t=02h29m11s)



[got this guy here where the question is](https://youtu.be/j80xaF6Lhk8?t=02h29m15s)



[how do we decorate these these are local](https://youtu.be/j80xaF6Lhk8?t=02h29m18s)



[functions right now for example](https://youtu.be/j80xaF6Lhk8?t=02h29m21s)



[previously we had fun with things like](https://youtu.be/j80xaF6Lhk8?t=02h29m25s)



[maybe know when falls right](https://youtu.be/j80xaF6Lhk8?t=02h29m29s)



[the problem is is this won't even](https://youtu.be/j80xaF6Lhk8?t=02h29m33s)



[compile here because these are local](https://youtu.be/j80xaF6Lhk8?t=02h29m34s)



[functions and it is not legal to put](https://youtu.be/j80xaF6Lhk8?t=02h29m37s)



[attributes on local functions which is](https://youtu.be/j80xaF6Lhk8?t=02h29m41s)



[exciting](https://youtu.be/j80xaF6Lhk8?t=02h29m44s)



[so the solution that we have to solve](https://youtu.be/j80xaF6Lhk8?t=02h29m46s)



[this doesn't actually even work here](https://youtu.be/j80xaF6Lhk8?t=02h29m50s)



[which is great emphasis on the high](https://youtu.be/j80xaF6Lhk8?t=02h29m52s)



[level of sarcasm right so those don't](https://youtu.be/j80xaF6Lhk8?t=02h29m58s)



[work is there a reason that isn't](https://youtu.be/j80xaF6Lhk8?t=02h30m03s)



[allowed yes the the simple reason is](https://youtu.be/j80xaF6Lhk8?t=02h30m06s)



[when they implemented local functions it](https://youtu.be/j80xaF6Lhk8?t=02h30m08s)



[was not high enough on the priority list](https://youtu.be/j80xaF6Lhk8?t=02h30m11s)



[that it got punted the adding of](https://youtu.be/j80xaF6Lhk8?t=02h30m13s)



[attributes on local functions will](https://youtu.be/j80xaF6Lhk8?t=02h30m17s)



[likely make it into dotnet 5 so it was](https://youtu.be/j80xaF6Lhk8?t=02h30m18s)



[one of those was not high enough on the](https://youtu.be/j80xaF6Lhk8?t=02h30m23s)



[priority list local functions got](https://youtu.be/j80xaF6Lhk8?t=02h30m25s)



[introduced before nillable reference](https://youtu.be/j80xaF6Lhk8?t=02h30m28s)



[types and then no liberal reference](https://youtu.be/j80xaF6Lhk8?t=02h30m30s)



[types followed shortly thereafter so](https://youtu.be/j80xaF6Lhk8?t=02h30m33s)



[there's yeah one feature kind of stomped](https://youtu.be/j80xaF6Lhk8?t=02h30m35s)



[on another feature and they didn't all](https://youtu.be/j80xaF6Lhk8?t=02h30m42s)



[play together nicely](https://youtu.be/j80xaF6Lhk8?t=02h30m44s)



[so so that's fun so we have to figure](https://youtu.be/j80xaF6Lhk8?t=02h30m45s)



[out how we're going to do this because](https://youtu.be/j80xaF6Lhk8?t=02h30m48s)



[I'm curious what replacement can be](https://youtu.be/j80xaF6Lhk8?t=02h30m51s)



[because there's only two setters for it](https://youtu.be/j80xaF6Lhk8?t=02h30m54s)



[so and just to make this even more fun](https://youtu.be/j80xaF6Lhk8?t=02h30m57s)



[right because we've got a local function](https://youtu.be/j80xaF6Lhk8?t=02h31m00s)



[and inside of our local function we have](https://youtu.be/j80xaF6Lhk8?t=02h31m02s)



[two more local functions I don't want to](https://youtu.be/j80xaF6Lhk8?t=02h31m05s)



[know how deep this goes so I'm gonna](https://youtu.be/j80xaF6Lhk8?t=02h31m07s)



[collapse those so I don't have to look](https://youtu.be/j80xaF6Lhk8?t=02h31m09s)



[so we've already got that kind of fun to](https://youtu.be/j80xaF6Lhk8?t=02h31m10s)



[deal with right okay so first of all](https://youtu.be/j80xaF6Lhk8?t=02h31m14s)



[let's look at this this guy here clearly](https://youtu.be/j80xaF6Lhk8?t=02h31m18s)



[looks to be able so this is so this is](https://youtu.be/j80xaF6Lhk8?t=02h31m23s)



[another local function it's hard to tell](https://youtu.be/j80xaF6Lhk8?t=02h31m26s)



[but that little lamb' does the give away](https://youtu.be/j80xaF6Lhk8?t=02h31m29s)



[it's an expression bodied member as a](https://youtu.be/j80xaF6Lhk8?t=02h31m31s)



[local function the fact that I see a](https://youtu.be/j80xaF6Lhk8?t=02h31m33s)



[null inside of the ternary means I'm](https://youtu.be/j80xaF6Lhk8?t=02h31m36s)



[pretty confident I can do this](https://youtu.be/j80xaF6Lhk8?t=02h31m40s)



[so because if you're gonna explicitly](https://youtu.be/j80xaF6Lhk8?t=02h31m43s)



[return an OLE you deserve what you get](https://youtu.be/j80xaF6Lhk8?t=02h31m46s)



[okay so that guy there the fun part is](https://youtu.be/j80xaF6Lhk8?t=02h31m49s)



[because I don't see him being used here](https://youtu.be/j80xaF6Lhk8?t=02h31m53s)



[oh no that probably means he's used](https://youtu.be/j80xaF6Lhk8?t=02h31m56s)



[inside of one of these other ones oh he](https://youtu.be/j80xaF6Lhk8?t=02h31m59s)



[is oh he is so this is this is just](https://youtu.be/j80xaF6Lhk8?t=02h32m05s)



[going to get really weird right oh oh no](https://youtu.be/j80xaF6Lhk8?t=02h32m10s)



[oh no oh no no yeah so this this is this](https://youtu.be/j80xaF6Lhk8?t=02h32m16s)



[is going to be a whole new level of](https://youtu.be/j80xaF6Lhk8?t=02h32m21s)



[complex and weird so you know this is a](https://youtu.be/j80xaF6Lhk8?t=02h32m22s)



[local function but like a lambda](https://youtu.be/j80xaF6Lhk8?t=02h32m25s)



[delegate right local functions can](https://youtu.be/j80xaF6Lhk8?t=02h32m29s)



[capture local variables this local](https://youtu.be/j80xaF6Lhk8?t=02h32m31s)



[variable is not actually declared inside](https://youtu.be/j80xaF6Lhk8?t=02h32m34s)



[of this function it's declared all the](https://youtu.be/j80xaF6Lhk8?t=02h32m36s)



[way up in the main function and he's](https://youtu.be/j80xaF6Lhk8?t=02h32m39s)



[then acted on and used down in here sigh](https://youtu.be/j80xaF6Lhk8?t=02h32m44s)



[this is yeah again this is why you don't](https://youtu.be/j80xaF6Lhk8?t=02h32m53s)



[parse that string array yourself because](https://youtu.be/j80xaF6Lhk8?t=02h32m59s)



[it is fraught with peril and this would](https://youtu.be/j80xaF6Lhk8?t=02h33m02s)



[be the peril](https://youtu.be/j80xaF6Lhk8?t=02h33m05s)



[okay so we've got that](https://youtu.be/j80xaF6Lhk8?t=02h33m08s)



[but let's so the the two issues we still](https://youtu.be/j80xaF6Lhk8?t=02h33m11s)



[have though right is how to declare this](https://youtu.be/j80xaF6Lhk8?t=02h33m13s)



[because there's a chance this is going](https://youtu.be/j80xaF6Lhk8?t=02h33m15s)



[to be the answer right because that goes](https://youtu.be/j80xaF6Lhk8?t=02h33m18s)



[there try unbox this guy's already](https://youtu.be/j80xaF6Lhk8?t=02h33m20s)



[preemptively declared oh and this gets](https://youtu.be/j80xaF6Lhk8?t=02h33m23s)



[even more fun right because this name](https://youtu.be/j80xaF6Lhk8?t=02h33m27s)



[matches this name this variable hides](https://youtu.be/j80xaF6Lhk8?t=02h33m29s)



[this variable so it won't be captured](https://youtu.be/j80xaF6Lhk8?t=02h33m33s)



[because that's not going to confuse](https://youtu.be/j80xaF6Lhk8?t=02h33m35s)



[anybody this guy's clearly nullable I](https://youtu.be/j80xaF6Lhk8?t=02h33m38s)



[would love to set not nullable when but](https://youtu.be/j80xaF6Lhk8?t=02h33m40s)



[i don't but i can't set the attribute](https://youtu.be/j80xaF6Lhk8?t=02h33m44s)



[what are you squawking about this guy](https://youtu.be/j80xaF6Lhk8?t=02h33m50s)



[hides a variable oh yeah but that's okay](https://youtu.be/j80xaF6Lhk8?t=02h33m54s)



[I think the hiding is acceptable we](https://youtu.be/j80xaF6Lhk8?t=02h34m01s)



[might get away with something simple](https://youtu.be/j80xaF6Lhk8?t=02h34m04s)



[okay so now the question is can be](https://youtu.be/j80xaF6Lhk8?t=02h34m08s)



[unbundled right we just made you know](https://youtu.be/j80xaF6Lhk8?t=02h34m11s)



[about what is the fallout of that](https://youtu.be/j80xaF6Lhk8?t=02h34m13s)



[cambium bundle so var replacement right](https://youtu.be/j80xaF6Lhk8?t=02h34m18s)



[I think this needs to go like that](https://youtu.be/j80xaF6Lhk8?t=02h34m21s)



[arglist](https://youtu.be/j80xaF6Lhk8?t=02h34m29s)



[insert range I find it shocking that](https://youtu.be/j80xaF6Lhk8?t=02h34m30s)



[this thing knows that this isn't unhappy](https://youtu.be/j80xaF6Lhk8?t=02h34m36s)



[about that being null](https://youtu.be/j80xaF6Lhk8?t=02h34m43s)



[I find that shocking but it seems happy](https://youtu.be/j80xaF6Lhk8?t=02h34m49s)



[so I'm not going to not going to stress](https://youtu.be/j80xaF6Lhk8?t=02h34m55s)



[about it so there's that there's that](https://youtu.be/j80xaF6Lhk8?t=02h34m58s)



[there's that has raw alias potential](https://youtu.be/j80xaF6Lhk8?t=02h35m02s)



[route commands so where are we so this](https://youtu.be/j80xaF6Lhk8?t=02h35m08s)



[is clearly a knowable string we could](https://youtu.be/j80xaF6Lhk8?t=02h35m10s)



[easily get here with it still being null](https://youtu.be/j80xaF6Lhk8?t=02h35m15s)



[so the question is as raw alias wants a](https://youtu.be/j80xaF6Lhk8?t=02h35m17s)



[non nullable type go to implementation](https://youtu.be/j80xaF6Lhk8?t=02h35m22s)



[yup raw aliases](https://youtu.be/j80xaF6Lhk8?t=02h35m30s)



[oh this is interesting raw aliases could](https://youtu.be/j80xaF6Lhk8?t=02h35m40s)



[theoretically contain a null](https://youtu.be/j80xaF6Lhk8?t=02h35m46s)



[okay so this guy's cut so I think given](https://youtu.be/j80xaF6Lhk8?t=02h35m58s)



[that this guy is no propogation clearly](https://youtu.be/j80xaF6Lhk8?t=02h36m03s)



[a null is possible right which would](https://youtu.be/j80xaF6Lhk8?t=02h36m07s)



[mean that this guy if this were null](https://youtu.be/j80xaF6Lhk8?t=02h36m12s)



[this would get short-circuited and this](https://youtu.be/j80xaF6Lhk8?t=02h36m15s)



[would be null this would fall into here](https://youtu.be/j80xaF6Lhk8?t=02h36m18s)



[and throw which is why this exclamation](https://youtu.be/j80xaF6Lhk8?t=02h36m20s)



[point here it's valid because if this](https://youtu.be/j80xaF6Lhk8?t=02h36m23s)



[were null then we wouldn't ever get down](https://youtu.be/j80xaF6Lhk8?t=02h36m27s)



[to here does this mean this this guy is](https://youtu.be/j80xaF6Lhk8?t=02h36m31s)



[not null I'm trying to decide if this](https://youtu.be/j80xaF6Lhk8?t=02h36m38s)



[should be list of notable strings](https://youtu.be/j80xaF6Lhk8?t=02h36m42s)



[because if this were null it's not](https://youtu.be/j80xaF6Lhk8?t=02h36m47s)



[possible so I think this is fine right](https://youtu.be/j80xaF6Lhk8?t=02h36m51s)



[and it's not possible to get a null into](https://youtu.be/j80xaF6Lhk8?t=02h36m55s)



[here so declaration fine usage is a](https://youtu.be/j80xaF6Lhk8?t=02h36m56s)



[read-only list fine so no way for](https://youtu.be/j80xaF6Lhk8?t=02h37m03s)



[somebody to add a null in their find](https://youtu.be/j80xaF6Lhk8?t=02h37m06s)



[results this here we just evaluated and](https://youtu.be/j80xaF6Lhk8?t=02h37m09s)



[determined that the null will never make](https://youtu.be/j80xaF6Lhk8?t=02h37m13s)



[it to here by the time we get to here](https://youtu.be/j80xaF6Lhk8?t=02h37m14s)



[we're not null which means this guy here](https://youtu.be/j80xaF6Lhk8?t=02h37m16s)



[is has raw alias there's no point in](https://youtu.be/j80xaF6Lhk8?t=02h37m22s)



[making this a knowable stream because](https://youtu.be/j80xaF6Lhk8?t=02h37m25s)



[null will never be in here therefore](https://youtu.be/j80xaF6Lhk8?t=02h37m26s)



[this tracks which means if we go back](https://youtu.be/j80xaF6Lhk8?t=02h37m28s)



[all the way to how this started back up](https://youtu.be/j80xaF6Lhk8?t=02h37m32s)



[to here this if this is null](https://youtu.be/j80xaF6Lhk8?t=02h37m36s)



[though it won't blow up it doesn't make](https://youtu.be/j80xaF6Lhk8?t=02h37m41s)



[sense](https://youtu.be/j80xaF6Lhk8?t=02h37m44s)



[normalised root command so the question](https://youtu.be/j80xaF6Lhk8?t=02h37m48s)



[is what should we do what should we do](https://youtu.be/j80xaF6Lhk8?t=02h37m53s)



[if this is null](https://youtu.be/j80xaF6Lhk8?t=02h37m58s)



[has raw alias should we use that](https://youtu.be/j80xaF6Lhk8?t=02h38m00s)



[[Music]](https://youtu.be/j80xaF6Lhk8?t=02h38m15s)



[I think we I think we I think we no](https://youtu.be/j80xaF6Lhk8?t=02h38m21s)



[check this right so I think we do just](https://youtu.be/j80xaF6Lhk8?t=02h38m23s)



[do not equal to null I think we do that](https://youtu.be/j80xaF6Lhk8?t=02h38m34s)



[and just assert that it's not an old](https://youtu.be/j80xaF6Lhk8?t=02h38m38s)



[there and didn't break any test so good](https://youtu.be/j80xaF6Lhk8?t=02h38m41s)



[enough and we actually reached the end](https://youtu.be/j80xaF6Lhk8?t=02h38m45s)



[of the list](https://youtu.be/j80xaF6Lhk8?t=02h38m47s)



[now we hit compile and see what the](https://youtu.be/j80xaF6Lhk8?t=02h38m48s)



[fallout was we only changed a few](https://youtu.be/j80xaF6Lhk8?t=02h38m50s)



[hundred things what could have possibly](https://youtu.be/j80xaF6Lhk8?t=02h38m54s)



[gone wrong here get cracking tell me](https://youtu.be/j80xaF6Lhk8?t=02h38m55s)



[what's the over-under like 26 files](https://youtu.be/j80xaF6Lhk8?t=02h39m02s)



[changed that's not even that much let's](https://youtu.be/j80xaF6Lhk8?t=02h39m05s)



[see build succeeded](https://youtu.be/j80xaF6Lhk8?t=02h39m10s)



[oh we're just down to six I kind of want](https://youtu.be/j80xaF6Lhk8?t=02h39m12s)



[to keep going for the moment just](https://youtu.be/j80xaF6Lhk8?t=02h39m15s)



[because it feels like I can't okay is](https://youtu.be/j80xaF6Lhk8?t=02h39m18s)



[any alias in use let's look at this](https://youtu.be/j80xaF6Lhk8?t=02h39m21s)



[maybe know when false](https://youtu.be/j80xaF6Lhk8?t=02h39m30s)



[okay](https://youtu.be/j80xaF6Lhk8?t=02h39m38s)



[all right I think the kicker is we do do](https://youtu.be/j80xaF6Lhk8?t=02h39m43s)



[that here right and we do this here](https://youtu.be/j80xaF6Lhk8?t=02h39m45s)



[because this is the same case where it's](https://youtu.be/j80xaF6Lhk8?t=02h39m48s)



[unhappy here because this so actually I](https://youtu.be/j80xaF6Lhk8?t=02h39m50s)



[think maybe a better a better way to](https://youtu.be/j80xaF6Lhk8?t=02h39m55s)



[handle it it's like this right so we](https://youtu.be/j80xaF6Lhk8?t=02h39m56s)



[allow that guy to be knowable knowing](https://youtu.be/j80xaF6Lhk8?t=02h39m58s)



[that on true it will be set to a value](https://youtu.be/j80xaF6Lhk8?t=02h40m03s)



[which it knows but that doesn't really](https://youtu.be/j80xaF6Lhk8?t=02h40m07s)



[matter because it's only using it for a](https://youtu.be/j80xaF6Lhk8?t=02h40m09s)



[message which would you then ultimately](https://youtu.be/j80xaF6Lhk8?t=02h40m11s)



[just empty end up as an empty string not](https://youtu.be/j80xaF6Lhk8?t=02h40m12s)



[a no reference exception but this way we](https://youtu.be/j80xaF6Lhk8?t=02h40m15s)



[assert that we've got a good message](https://youtu.be/j80xaF6Lhk8?t=02h40m17s)



[okay so that handles two of them so I](https://youtu.be/j80xaF6Lhk8?t=02h40m19s)



[don't handle that let's look here get](https://youtu.be/j80xaF6Lhk8?t=02h40m22s)



[argument or default value type so I](https://youtu.be/j80xaF6Lhk8?t=02h40m26s)



[think](https://youtu.be/j80xaF6Lhk8?t=02h40m30s)



[I think this one just propagates up to](https://youtu.be/j80xaF6Lhk8?t=02h40m38s)



[here surprised I didn't catch that when](https://youtu.be/j80xaF6Lhk8?t=02h40m39s)



[I did that before](https://youtu.be/j80xaF6Lhk8?t=02h40m42s)



[yeah so air list let's see value for](https://youtu.be/j80xaF6Lhk8?t=02h40m50s)



[option this guy is a maybe null and on](https://youtu.be/j80xaF6Lhk8?t=02h40m56s)



[an object type no less certainly valid](https://youtu.be/j80xaF6Lhk8?t=02h41m02s)



[so we're gonna just propagate that](https://youtu.be/j80xaF6Lhk8?t=02h41m04s)



[forward and then did that go away or did](https://youtu.be/j80xaF6Lhk8?t=02h41m06s)



[it flag me again looks like it's fine](https://youtu.be/j80xaF6Lhk8?t=02h41m13s)



[sometimes it's a little delayed and I](https://youtu.be/j80xaF6Lhk8?t=02h41m18s)



[thought I saw it okay so get by alias](https://youtu.be/j80xaF6Lhk8?t=02h41m20s)



[can return a nullable symbol we're](https://youtu.be/j80xaF6Lhk8?t=02h41m23s)



[casting to an I command current command](https://youtu.be/j80xaF6Lhk8?t=02h41m30s)



[where are you declared you are clearly](https://youtu.be/j80xaF6Lhk8?t=02h41m34s)



[knowable](https://youtu.be/j80xaF6Lhk8?t=02h41m39s)



[this is assuming get by alias why do you](https://youtu.be/j80xaF6Lhk8?t=02h41m45s)



[assume that you are possible so symbol](https://youtu.be/j80xaF6Lhk8?t=02h41m51s)



[set there so you're either coming from](https://youtu.be/j80xaF6Lhk8?t=02h41m54s)



[the configuration set of all symbols so](https://youtu.be/j80xaF6Lhk8?t=02h41m59s)



[in a symbol here as a command or an](https://youtu.be/j80xaF6Lhk8?t=02h42m02s)



[option don't arguments may count as](https://youtu.be/j80xaF6Lhk8?t=02h42m04s)



[symbols - I don't remember but](https://youtu.be/j80xaF6Lhk8?t=02h42m11s)



[regardless it has multiple types but in](https://youtu.be/j80xaF6Lhk8?t=02h42m13s)



[this case we are explicitly hunting by a](https://youtu.be/j80xaF6Lhk8?t=02h42m16s)



[command we know our token is not of type](https://youtu.be/j80xaF6Lhk8?t=02h42m17s)



[option because we would have fallen into](https://youtu.be/j80xaF6Lhk8?t=02h42m23s)



[here so this is hunting out I'm guessing](https://youtu.be/j80xaF6Lhk8?t=02h42m27s)



[with all of these ifs we've fallen into](https://youtu.be/j80xaF6Lhk8?t=02h42m31s)



[the the token case if we know we're a](https://youtu.be/j80xaF6Lhk8?t=02h42m33s)



[command because that's the last possible](https://youtu.be/j80xaF6Lhk8?t=02h42m35s)



[choice it's tested everything else this](https://youtu.be/j80xaF6Lhk8?t=02h42m38s)



[guy tries to pull it from Arg which I'm](https://youtu.be/j80xaF6Lhk8?t=02h42m43s)



[guessing is whatever we're iterating](https://youtu.be/j80xaF6Lhk8?t=02h42m46s)



[over yeah so we're iterating over our](https://youtu.be/j80xaF6Lhk8?t=02h42m47s)



[argument stuff so that's the current one](https://youtu.be/j80xaF6Lhk8?t=02h42m50s)



[and it's trying to pull it by alias](https://youtu.be/j80xaF6Lhk8?t=02h42m51s)



[I'm wondering if](https://youtu.be/j80xaF6Lhk8?t=02h43m01s)



[see the problem is if I do this right](https://youtu.be/j80xaF6Lhk8?t=02h43m10s)



[and I let the the nullable go through](https://youtu.be/j80xaF6Lhk8?t=02h43m12s)



[that fixes this line but now I'm left to](https://youtu.be/j80xaF6Lhk8?t=02h43m15s)



[deal with this of what to do if it is](https://youtu.be/j80xaF6Lhk8?t=02h43m18s)



[null and I'm not entirely sure because I](https://youtu.be/j80xaF6Lhk8?t=02h43m21s)



[could I could then know propagate](https://youtu.be/j80xaF6Lhk8?t=02h43m28s)



[forward right and then this guy ends up](https://youtu.be/j80xaF6Lhk8?t=02h43m30s)



[is null which he's declared as non](https://youtu.be/j80xaF6Lhk8?t=02h43m34s)



[knowable which is now makes this more](https://youtu.be/j80xaF6Lhk8?t=02h43m39s)



[interesting right because now I have to](https://youtu.be/j80xaF6Lhk8?t=02h43m43s)



[deal with this](https://youtu.be/j80xaF6Lhk8?t=02h43m45s)



[I mean potentially no and then it's](https://youtu.be/j80xaF6Lhk8?t=02h43m46s)



[promptly used here to make another hash](https://youtu.be/j80xaF6Lhk8?t=02h43m48s)



[that's oh I don't like that that makes](https://youtu.be/j80xaF6Lhk8?t=02h43m50s)



[me unhappy but the question is what to](https://youtu.be/j80xaF6Lhk8?t=02h43m55s)



[do here](https://youtu.be/j80xaF6Lhk8?t=02h43m59s)



[I could exploit so the civil set in](https://youtu.be/j80xaF6Lhk8?t=02h44m03s)



[question get by alias so like we're](https://youtu.be/j80xaF6Lhk8?t=02h44m07s)



[already straight up assuming that we can](https://youtu.be/j80xaF6Lhk8?t=02h44m10s)



[convert to an I command and this code is](https://youtu.be/j80xaF6Lhk8?t=02h44m13s)



[already making the assumption that it](https://youtu.be/j80xaF6Lhk8?t=02h44m15s)



[will be there I think that is the](https://youtu.be/j80xaF6Lhk8?t=02h44m18s)



[assumption because given all of our fall](https://youtu.be/j80xaF6Lhk8?t=02h44m24s)



[backs here we know we aren't in any of](https://youtu.be/j80xaF6Lhk8?t=02h44m27s)



[these other cases and we have](https://youtu.be/j80xaF6Lhk8?t=02h44m29s)



[significantly tested all of this parsing](https://youtu.be/j80xaF6Lhk8?t=02h44m31s)



[code repeatedly so I'm a little less](https://youtu.be/j80xaF6Lhk8?t=02h44m34s)



[scared of it because we have a good unit](https://youtu.be/j80xaF6Lhk8?t=02h44m39s)



[test suite over that so your list okay](https://youtu.be/j80xaF6Lhk8?t=02h44m41s)



[there is now handled okay build come on](https://youtu.be/j80xaF6Lhk8?t=02h44m47s)



[no warnings no warnings yes](https://youtu.be/j80xaF6Lhk8?t=02h44m50s)



[I will take it okay yay thank you making](https://youtu.be/j80xaF6Lhk8?t=02h45m01s)



[awesome okay step one mild success](https://youtu.be/j80xaF6Lhk8?t=02h45m12s)



[commit immediately handling all billable](https://youtu.be/j80xaF6Lhk8?t=02h45m16s)



[reference type warnings in or project](https://youtu.be/j80xaF6Lhk8?t=02h45m26s)



[okay so commit changes there's all of](https://youtu.be/j80xaF6Lhk8?t=02h45m33s)



[that push okay so that gets a very large](https://youtu.be/j80xaF6Lhk8?t=02h45m38s)



[bit of stuff through trying to decide if](https://youtu.be/j80xaF6Lhk8?t=02h45m45s)



[I open up work in progress pull requests](https://youtu.be/j80xaF6Lhk8?t=02h45m48s)



[or if I wait there's still some](https://youtu.be/j80xaF6Lhk8?t=02h45m50s)



[outstanding items that need to be done](https://youtu.be/j80xaF6Lhk8?t=02h45m52s)



[right so like one of the changes that](https://youtu.be/j80xaF6Lhk8?t=02h45m54s)



[went in here was that CS proj change](https://youtu.be/j80xaF6Lhk8?t=02h45m56s)



[here right like where I just blindly](https://youtu.be/j80xaF6Lhk8?t=02h46m01s)



[whacked net four six two we probably](https://youtu.be/j80xaF6Lhk8?t=02h46m04s)



[shouldn't do that we should actually](https://youtu.be/j80xaF6Lhk8?t=02h46m06s)



[probably address it but it's also 1142](https://youtu.be/j80xaF6Lhk8?t=02h46m08s)



[so I'm trying to decide if I address it](https://youtu.be/j80xaF6Lhk8?t=02h46m16s)



[tonight or if I address it later and I](https://youtu.be/j80xaF6Lhk8?t=02h46m18s)



[think the answer is I stopped coding now](https://youtu.be/j80xaF6Lhk8?t=02h46m20s)



[and I address it later](https://youtu.be/j80xaF6Lhk8?t=02h46m22s)



[I think that's the solution I think that](https://youtu.be/j80xaF6Lhk8?t=02h46m24s)



[is the solution so but I think in the](https://youtu.be/j80xaF6Lhk8?t=02h46m30s)



[interest of getting feedback and having](https://youtu.be/j80xaF6Lhk8?t=02h46m35s)



[stuff get done refresh pull requests and](https://youtu.be/j80xaF6Lhk8?t=02h46m40s)



[I think what we're going to do we're](https://youtu.be/j80xaF6Lhk8?t=02h46m48s)



[gonna start this in](https://youtu.be/j80xaF6Lhk8?t=02h46m51s)



[c-sharp 8 millivolt reference types sure](https://youtu.be/j80xaF6Lhk8?t=02h46m56s)



[so this this way we can handle and we](https://youtu.be/j80xaF6Lhk8?t=02h47m08s)



[can open up and if people want to](https://youtu.be/j80xaF6Lhk8?t=02h47m14s)



[comment and have a discussion on how to](https://youtu.be/j80xaF6Lhk8?t=02h47m16s)



[handle this we can deal with this](https://youtu.be/j80xaF6Lhk8?t=02h47m18s)



[so because I think this thing actually](https://youtu.be/j80xaF6Lhk8?t=02h47m20s)



[has let me just check real quick on one](https://youtu.be/j80xaF6Lhk8?t=02h47m23s)



[of the other poll requests I think we](https://youtu.be/j80xaF6Lhk8?t=02h47m25s)



[have the the work-in-progress check yeah](https://youtu.be/j80xaF6Lhk8?t=02h47m28s)



[so if you do a pull request and you type](https://youtu.be/j80xaF6Lhk8?t=02h47m32s)



[WIP on it it won't let it merge so that](https://youtu.be/j80xaF6Lhk8?t=02h47m36s)



[will be convenient starting work on](https://youtu.be/j80xaF6Lhk8?t=02h47m41s)



[handling c-sharp 8 Nobile](https://youtu.be/j80xaF6Lhk8?t=02h47m47s)



[let's types current work only and let's](https://youtu.be/j80xaF6Lhk8?t=02h47m52s)



[see handles it in the core library](https://youtu.be/j80xaF6Lhk8?t=02h48m04s)



[outstanding to-do items so let's see](https://youtu.be/j80xaF6Lhk8?t=02h48m10s)



[here I'm gonna do a nice little](https://youtu.be/j80xaF6Lhk8?t=02h48m15s)



[checklist](https://youtu.be/j80xaF6Lhk8?t=02h48m16s)



[additionally include millivolt or](https://youtu.be/j80xaF6Lhk8?t=02h48m21s)



[reference type attributes to support net](https://youtu.be/j80xaF6Lhk8?t=02h48m30s)



[4 6 - let's see here](https://youtu.be/j80xaF6Lhk8?t=02h48m37s)



[confirm upgrade to net standard - one is](https://youtu.be/j80xaF6Lhk8?t=02h48m46s)



[acceptable we could additionally include](https://youtu.be/j80xaF6Lhk8?t=02h48m56s)



[well I guess this is not explicitly](https://youtu.be/j80xaF6Lhk8?t=02h49m08s)



[needed since we will already the routine](https://youtu.be/j80xaF6Lhk8?t=02h49m14s)



[attributes I'm trying to feel like there](https://youtu.be/j80xaF6Lhk8?t=02h49m24s)



[was one other to do that I had in here](https://youtu.be/j80xaF6Lhk8?t=02h49m28s)



[oh I don't know so this change here](https://youtu.be/j80xaF6Lhk8?t=02h49m31s)



[so the sea and all let's see you know](https://youtu.be/j80xaF6Lhk8?t=02h49m45s)



[possible null set of values on argument](https://youtu.be/j80xaF6Lhk8?t=02h49m59s)



[parity dot what was that thing I think](https://youtu.be/j80xaF6Lhk8?t=02h50m05s)



[it was argument type because it was the](https://youtu.be/j80xaF6Lhk8?t=02h50m10s)



[type thing typey typey typey the very](https://youtu.be/j80xaF6Lhk8?t=02h50m15s)



[first thing I broke type it's passed in](https://youtu.be/j80xaF6Lhk8?t=02h50m18s)



[here fine usage argument oh so it's](https://youtu.be/j80xaF6Lhk8?t=02h50m23s)



[argument dot argument type possible and](https://youtu.be/j80xaF6Lhk8?t=02h50m31s)



[we'll just do this this on let's see](https://youtu.be/j80xaF6Lhk8?t=02h50m37s)



[argument boom](https://youtu.be/j80xaF6Lhk8?t=02h50m44s)



[block it and I think I'm tuning it out](https://youtu.be/j80xaF6Lhk8?t=02h50m46s)



[it might have missed it did you want an](https://youtu.be/j80xaF6Lhk8?t=02h50m52s)



[error message for that throws mmm good](https://youtu.be/j80xaF6Lhk8?t=02h50m55s)



[question so the answer is possibly and I](https://youtu.be/j80xaF6Lhk8?t=02h51m00s)



[think you are correct so that was inside](https://youtu.be/j80xaF6Lhk8?t=02h51m07s)



[of the nope wrong project so what you](https://youtu.be/j80xaF6Lhk8?t=02h51m09s)



[get for having too many visuals to open](https://youtu.be/j80xaF6Lhk8?t=02h51m13s)



[so that was inside of the result](https://youtu.be/j80xaF6Lhk8?t=02h51m14s)



[property on first result visitor yeah so](https://youtu.be/j80xaF6Lhk8?t=02h51m17s)



[partially zone visitor dot result let's](https://youtu.be/j80xaF6Lhk8?t=02h51m25s)



[see parse results visitor that result](https://youtu.be/j80xaF6Lhk8?t=02h51m28s)



[currently rows valid operation exception](https://youtu.be/j80xaF6Lhk8?t=02h51m37s)



[should what should the air messages be](https://youtu.be/j80xaF6Lhk8?t=02h51m46s)



[for these that's that's a very valid to](https://youtu.be/j80xaF6Lhk8?t=02h51m57s)



[do Thank You Megan I'd forgotten that](https://youtu.be/j80xaF6Lhk8?t=02h52m01s)



[one I think I think the only other one](https://youtu.be/j80xaF6Lhk8?t=02h52m03s)



[was that error message explicit one](https://youtu.be/j80xaF6Lhk8?t=02h52m11s)



[right so the what was it error message](https://youtu.be/j80xaF6Lhk8?t=02h52m13s)



[right](https://youtu.be/j80xaF6Lhk8?t=02h52m18s)



[[Music]](https://youtu.be/j80xaF6Lhk8?t=02h52m23s)



[message on star though](https://youtu.be/j80xaF6Lhk8?t=02h52m28s)



[classes is declared as nullable because](https://youtu.be/j80xaF6Lhk8?t=02h52m39s)



[some localization augmentation could in](https://youtu.be/j80xaF6Lhk8?t=02h52m47s)



[theory return a null currently solicit](https://youtu.be/j80xaF6Lhk8?t=02h52m56s)



[the ignoring with null forgiveness](https://youtu.be/j80xaF6Lhk8?t=02h53m07s)



[operator](https://youtu.be/j80xaF6Lhk8?t=02h53m13s)



[I think that covers all of them and if](https://youtu.be/j80xaF6Lhk8?t=02h53m16s)



[I've missed them I'm sure somebody will](https://youtu.be/j80xaF6Lhk8?t=02h53m19s)



[happily hammer me in code review so yeah](https://youtu.be/j80xaF6Lhk8?t=02h53m20s)



[so create pull request and](https://youtu.be/j80xaF6Lhk8?t=02h53m29s)



[uh let's see here oh that's funny](https://youtu.be/j80xaF6Lhk8?t=02h53m38s)



[so John had left these comments on my](https://youtu.be/j80xaF6Lhk8?t=02h53m42s)



[branch beef like earlier today or](https://youtu.be/j80xaF6Lhk8?t=02h53m45s)



[yesterday after I had showed him my](https://youtu.be/j80xaF6Lhk8?t=02h53m49s)



[branch where I had started it](https://youtu.be/j80xaF6Lhk8?t=02h53m52s)



[apparently github is hip to the idea and](https://youtu.be/j80xaF6Lhk8?t=02h53m54s)



[we'll pull those comments over from the](https://youtu.be/j80xaF6Lhk8?t=02h53m56s)



[branch that's kinda slick but we I](https://youtu.be/j80xaF6Lhk8?t=02h53m58s)



[addressed all of those earlier so that](https://youtu.be/j80xaF6Lhk8?t=02h54m04s)



[is it so pull request eight five six if](https://youtu.be/j80xaF6Lhk8?t=02h54m06s)



[anyone wants to review and rip me apart](https://youtu.be/j80xaF6Lhk8?t=02h54m10s)



[yeah so there's all of that I do think](https://youtu.be/j80xaF6Lhk8?t=02h54m14s)



[that we will probably deal with that](https://youtu.be/j80xaF6Lhk8?t=02h54m18s)



[those attributes stuff I don't know if](https://youtu.be/j80xaF6Lhk8?t=02h54m21s)



[I'm gonna wait until next week to do](https://youtu.be/j80xaF6Lhk8?t=02h54m24s)



[this there may be another ad hoc stream](https://youtu.be/j80xaF6Lhk8?t=02h54m28s)



[where I do this or I might just do it so](https://youtu.be/j80xaF6Lhk8?t=02h54m30s)



[if people are interested in seeing more](https://youtu.be/j80xaF6Lhk8?t=02h54m34s)



[of this resolution stuff on how to](https://youtu.be/j80xaF6Lhk8?t=02h54m36s)



[finish this out I'm probably happy to go](https://youtu.be/j80xaF6Lhk8?t=02h54m38s)



[through and stream it but I think for](https://youtu.be/j80xaF6Lhk8?t=02h54m40s)



[now I am probably at my my evenings end](https://youtu.be/j80xaF6Lhk8?t=02h54m42s)



[so because I'm now like an hour longer](https://youtu.be/j80xaF6Lhk8?t=02h54m46s)



[than I normally would go so but thank](https://youtu.be/j80xaF6Lhk8?t=02h54m49s)



[you for hanging out Megan this whole](https://youtu.be/j80xaF6Lhk8?t=02h54m52s)



[time](https://youtu.be/j80xaF6Lhk8?t=02h54m53s)



[I assume you're doing well so far I](https://youtu.be/j80xaF6Lhk8?t=02h54m53s)



[think you you come up here in a month](https://youtu.be/j80xaF6Lhk8?t=02h54m57s)



[two months something like that is that](https://youtu.be/j80xaF6Lhk8?t=02h55m00s)



[true](https://youtu.be/j80xaF6Lhk8?t=02h55m03s)



[or possibly I've put you to sleep yeah](https://youtu.be/j80xaF6Lhk8?t=02h55m08s)



[mate cool oh it would have been cooler](https://youtu.be/j80xaF6Lhk8?t=02h55m12s)



[if it was May the fourth that's just the](https://youtu.be/j80xaF6Lhk8?t=02h55m18s)



[geek in me coming out oh but cool so the](https://youtu.be/j80xaF6Lhk8?t=02h55m22s)



[time becomes pretty mean Lia so when you](https://youtu.be/j80xaF6Lhk8?t=02h55m31s)



[don't leave your apartment for weeks](https://youtu.be/j80xaF6Lhk8?t=02h55m33s)



[yeah yeah oh you're finals on May the](https://youtu.be/j80xaF6Lhk8?t=02h55m35s)



[fourth yes yes hopefully whatever person](https://youtu.be/j80xaF6Lhk8?t=02h55m39s)



[is teaching that class takes full](https://youtu.be/j80xaF6Lhk8?t=02h55m44s)



[advantage of that awesome](https://youtu.be/j80xaF6Lhk8?t=02h55m45s)



[well cool yeah I I kind of feel the same](https://youtu.be/j80xaF6Lhk8?t=02h55m53s)



[way it's it feels like everybody's just](https://youtu.be/j80xaF6Lhk8?t=02h55m57s)



[locked in I spend a lot of time sitting](https://youtu.be/j80xaF6Lhk8?t=02h55m59s)



[on a computer because there's not a lot](https://youtu.be/j80xaF6Lhk8?t=02h56m01s)



[else to do so well cool thanks for](https://youtu.be/j80xaF6Lhk8?t=02h56m03s)



[hanging out the whole time look forward](https://youtu.be/j80xaF6Lhk8?t=02h56m08s)



[to seeing you up here shortly and I](https://youtu.be/j80xaF6Lhk8?t=02h56m09s)



[think I'm going to sign off and try and](https://youtu.be/j80xaF6Lhk8?t=02h56m12s)



[get stuff wrapped up so I can go to bed](https://youtu.be/j80xaF6Lhk8?t=02h56m16s)



[five hours of sleep is enough six hours](https://youtu.be/j80xaF6Lhk8?t=02h56m18s)



[of sleep yeah that should be good good](https://youtu.be/j80xaF6Lhk8?t=02h56m21s)



[great I got plenty of Mountain Dew so](https://youtu.be/j80xaF6Lhk8?t=02h56m23s)



[again Thank You Maegan have a good one](https://youtu.be/j80xaF6Lhk8?t=02h56m26s)



[we'll talk to you later](https://youtu.be/j80xaF6Lhk8?t=02h56m29s)



[you](https://youtu.be/j80xaF6Lhk8?t=02h56m39s)


