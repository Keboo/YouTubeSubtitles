[YouTube Video](https://youtu.be/AyB3yDuZRTo)



[hello everyone welcome back uh my plan](https://youtu.be/AyB3yDuZRTo?t=00h00m01s)

[tonight is to continue on with that](https://youtu.be/AyB3yDuZRTo?t=00h00m04s)

[multi-select preview that we started](https://youtu.be/AyB3yDuZRTo?t=00h00m06s)

[last time I've had a good hard long](https://youtu.be/AyB3yDuZRTo?t=00h00m07s)

[think about what we were doing might try](https://youtu.be/AyB3yDuZRTo?t=00h00m10s)

[a different direction we're gonna see](https://youtu.be/AyB3yDuZRTo?t=00h00m12s)

[where it goes I'm gonna do my best to](https://youtu.be/AyB3yDuZRTo?t=00h00m14s)

[not get as distracted as last week and](https://youtu.be/AyB3yDuZRTo?t=00h00m15s)

[probably end up getting as distracted as](https://youtu.be/AyB3yDuZRTo?t=00h00m17s)

[last week but first](https://youtu.be/AyB3yDuZRTo?t=00h00m19s)

[quick announcement](https://youtu.be/AyB3yDuZRTo?t=00h00m21s)

[um for anyone who is unaware get](https://youtu.be/AyB3yDuZRTo?t=00h00m23s)

[cracking puts on a conference every year](https://youtu.be/AyB3yDuZRTo?t=00h00m25s)

[git con you can think of this as not](https://youtu.be/AyB3yDuZRTo?t=00h00m27s)

[necessarily a conference on get or even](https://youtu.be/AyB3yDuZRTo?t=00h00m31s)

[get Kraken but on software development](https://youtu.be/AyB3yDuZRTo?t=00h00m33s)

[in general](https://youtu.be/AyB3yDuZRTo?t=00h00m35s)

[um they've got a couple keynote speakers](https://youtu.be/AyB3yDuZRTo?t=00h00m37s)

[that are going to be awesome](https://youtu.be/AyB3yDuZRTo?t=00h00m39s)

[um they haven't really announced a lot](https://youtu.be/AyB3yDuZRTo?t=00h00m42s)

[of the sessions or speakers yet but](https://youtu.be/AyB3yDuZRTo?t=00h00m44s)

[spoiler you might see my face](https://youtu.be/AyB3yDuZRTo?t=00h00m46s)

[so](https://youtu.be/AyB3yDuZRTo?t=00h00m49s)

[uh if you are interested check out](https://youtu.be/AyB3yDuZRTo?t=00h00m50s)

[getcon](https://youtu.be/AyB3yDuZRTo?t=00h00m53s)

[okay that's enough of that](https://youtu.be/AyB3yDuZRTo?t=00h00m54s)

[material design and xaml wherever they](https://youtu.be/AyB3yDuZRTo?t=00h00m57s)

[left off before](https://youtu.be/AyB3yDuZRTo?t=00h00m59s)

[we were building a multi-select review](https://youtu.be/AyB3yDuZRTo?t=00h01m01s)

[and as we learned last time the](https://youtu.be/AyB3yDuZRTo?t=00h01m03s)

[multi-select previews are hard they](https://youtu.be/AyB3yDuZRTo?t=00h01m07s)

[don't exist in WPF and so we took some](https://youtu.be/AyB3yDuZRTo?t=00h01m09s)

[inspiration from visual studio and went](https://youtu.be/AyB3yDuZRTo?t=00h01m11s)

[hang on officials](https://youtu.be/AyB3yDuZRTo?t=00h01m14s)

[Visual Studio has tree views this looks](https://youtu.be/AyB3yDuZRTo?t=00h01m16s)

[like a tree view this tree view supports](https://youtu.be/AyB3yDuZRTo?t=00h01m18s)

[multi-selection that's cool can I have](https://youtu.be/AyB3yDuZRTo?t=00h01m20s)

[multi-section and it turns out that the](https://youtu.be/AyB3yDuZRTo?t=00h01m22s)

[way that they actually implemented these](https://youtu.be/AyB3yDuZRTo?t=00h01m25s)

[is with a list View](https://youtu.be/AyB3yDuZRTo?t=00h01m26s)

[which gives a lot of nice things the the](https://youtu.be/AyB3yDuZRTo?t=00h01m29s)

[challenging part here is inside of the](https://youtu.be/AyB3yDuZRTo?t=00h01m31s)

[list view you basically are responsible](https://youtu.be/AyB3yDuZRTo?t=00h01m33s)

[for dealing with your own expanding](https://youtu.be/AyB3yDuZRTo?t=00h01m35s)

[collapse you're also responsible for](https://youtu.be/AyB3yDuZRTo?t=00h01m37s)

[your own indentation now you're not](https://youtu.be/AyB3yDuZRTo?t=00h01m40s)

[going to get any of that out of the box](https://youtu.be/AyB3yDuZRTo?t=00h01m41s)

[because listview doesn't provide that](https://youtu.be/AyB3yDuZRTo?t=00h01m43s)

[out of the box but if you want to](https://youtu.be/AyB3yDuZRTo?t=00h01m44s)

[implement like the column headers and](https://youtu.be/AyB3yDuZRTo?t=00h01m46s)

[whatnot that is a thing that can go in](https://youtu.be/AyB3yDuZRTo?t=00h01m48s)

[there](https://youtu.be/AyB3yDuZRTo?t=00h01m50s)

[and we had started down the path of okay](https://youtu.be/AyB3yDuZRTo?t=00h01m50s)

[well let's go with a list view but then](https://youtu.be/AyB3yDuZRTo?t=00h01m52s)

[let's re-implement a lot of the tree](https://youtu.be/AyB3yDuZRTo?t=00h01m54s)

[view items stuff and I was thinking](https://youtu.be/AyB3yDuZRTo?t=00h01m56s)

[about our approach last time and](https://youtu.be/AyB3yDuZRTo?t=00h01m59s)

[realized](https://youtu.be/AyB3yDuZRTo?t=00h02m01s)

[I don't like a good chunk of it](https://youtu.be/AyB3yDuZRTo?t=00h02m03s)

[now specifically the part I don't like](https://youtu.be/AyB3yDuZRTo?t=00h02m05s)

[is that this guy derived from headers](https://youtu.be/AyB3yDuZRTo?t=00h02m07s)

[items control and I I think this is what](https://youtu.be/AyB3yDuZRTo?t=00h02m10s)

[was biting us at the end of the the](https://youtu.be/AyB3yDuZRTo?t=00h02m12s)

[stream last time is we were trying to](https://youtu.be/AyB3yDuZRTo?t=00h02m13s)

[figure out how to do this selection and](https://youtu.be/AyB3yDuZRTo?t=00h02m15s)

[we got selection working but only at the](https://youtu.be/AyB3yDuZRTo?t=00h02m17s)

[top level](https://youtu.be/AyB3yDuZRTo?t=00h02m19s)

[which wasn't great that's not really](https://youtu.be/AyB3yDuZRTo?t=00h02m21s)

[what we want and I think at the end of](https://youtu.be/AyB3yDuZRTo?t=00h02m23s)

[the day and this is I I believe where we](https://youtu.be/AyB3yDuZRTo?t=00h02m25s)

[were headed is realizing that this](https://youtu.be/AyB3yDuZRTo?t=00h02m27s)

[headers collection is probably not what](https://youtu.be/AyB3yDuZRTo?t=00h02m29s)

[we want internally inside this we want a](https://youtu.be/AyB3yDuZRTo?t=00h02m31s)

[flat list that appropriately indents the](https://youtu.be/AyB3yDuZRTo?t=00h02m35s)

[items so I was going to back up](https://youtu.be/AyB3yDuZRTo?t=00h02m38s)

[a little bit from where we had gone and](https://youtu.be/AyB3yDuZRTo?t=00h02m40s)

[changed some of this up because I think](https://youtu.be/AyB3yDuZRTo?t=00h02m43s)

[if we do that we can deal with a lot of](https://youtu.be/AyB3yDuZRTo?t=00h02m45s)

[this stuff and I found a few more](https://youtu.be/AyB3yDuZRTo?t=00h02m49s)

[samples online where people had done](https://youtu.be/AyB3yDuZRTo?t=00h02m51s)

[tree views with list views and I kind of](https://youtu.be/AyB3yDuZRTo?t=00h02m52s)

[like them](https://youtu.be/AyB3yDuZRTo?t=00h02m55s)

[so I think what I'm going to do is I'm](https://youtu.be/AyB3yDuZRTo?t=00h02m56s)

[just going to pause this one here](https://youtu.be/AyB3yDuZRTo?t=00h02m58s)

[just let it sit for a second](https://youtu.be/AyB3yDuZRTo?t=00h03m01s)

[we're just going to make a new file and](https://youtu.be/AyB3yDuZRTo?t=00h03m03s)

[I I think uh](https://youtu.be/AyB3yDuZRTo?t=00h03m05s)

[so we're going to try this public class](https://youtu.be/AyB3yDuZRTo?t=00h03m09s)

[free](https://youtu.be/AyB3yDuZRTo?t=00h03m11s)

[list view because I think this is a](https://youtu.be/AyB3yDuZRTo?t=00h03m13s)

[little more clear as to what's going on](https://youtu.be/AyB3yDuZRTo?t=00h03m17s)

[we're going to just move you into your](https://youtu.be/AyB3yDuZRTo?t=00h03m20s)

[own file](https://youtu.be/AyB3yDuZRTo?t=00h03m21s)

[and we're gonna put we're gonna play](https://youtu.be/AyB3yDuZRTo?t=00h03m23s)

[over here because we're already on a](https://youtu.be/AyB3yDuZRTo?t=00h03m24s)

[branch we're already kind of doing our](https://youtu.be/AyB3yDuZRTo?t=00h03m25s)

[own thing](https://youtu.be/AyB3yDuZRTo?t=00h03m27s)

[public Class pre-list View item](https://youtu.be/AyB3yDuZRTo?t=00h03m28s)

[list view item because I think if we go](https://youtu.be/AyB3yDuZRTo?t=00h03m33s)

[this route and we focus instead on](https://youtu.be/AyB3yDuZRTo?t=00h03m36s)

[styling this up and doing the](https://youtu.be/AyB3yDuZRTo?t=00h03m38s)

[indentation and the expansion and](https://youtu.be/AyB3yDuZRTo?t=00h03m40s)

[magically building that out the rest of](https://youtu.be/AyB3yDuZRTo?t=00h03m42s)

[the stuff we get from list view for free](https://youtu.be/AyB3yDuZRTo?t=00h03m44s)

[probably worth considering](https://youtu.be/AyB3yDuZRTo?t=00h03m48s)

[okay so uh we do want to do effectively](https://youtu.be/AyB3yDuZRTo?t=00h03m50s)

[this thing here](https://youtu.be/AyB3yDuZRTo?t=00h03m55s)

[um and so we want this to be](https://youtu.be/AyB3yDuZRTo?t=00h03m58s)

[preview item and then we do want to do](https://youtu.be/AyB3yDuZRTo?t=00h04m00s)

[this override as well](https://youtu.be/AyB3yDuZRTo?t=00h04m04s)

[therefore we want this to be](https://youtu.be/AyB3yDuZRTo?t=00h04m09s)

[free list view item](https://youtu.be/AyB3yDuZRTo?t=00h04m12s)

[okay so this gets us part of the way](https://youtu.be/AyB3yDuZRTo?t=00h04m16s)

[there](https://youtu.be/AyB3yDuZRTo?t=00h04m18s)

[we'll just We'll add them to body both](https://youtu.be/AyB3yDuZRTo?t=00h04m19s)

[of them why not why not](https://youtu.be/AyB3yDuZRTo?t=00h04m21s)

[okay so that gets us there let's plug in](https://youtu.be/AyB3yDuZRTo?t=00h04m24s)

[a](https://youtu.be/AyB3yDuZRTo?t=00h04m29s)

[a little thing in the demo app so we can](https://youtu.be/AyB3yDuZRTo?t=00h04m31s)

[leverage it](https://youtu.be/AyB3yDuZRTo?t=00h04m34s)

[I kind of want to be able to use it and](https://youtu.be/AyB3yDuZRTo?t=00h04m36s)

[see it work so I'm going to just](https://youtu.be/AyB3yDuZRTo?t=00h04m38s)

[bring this comment down to here](https://youtu.be/AyB3yDuZRTo?t=00h04m41s)

[and bring this comment](https://youtu.be/AyB3yDuZRTo?t=00h04m44s)

[up to here](https://youtu.be/AyB3yDuZRTo?t=00h04m47s)

[and then what we're going to do is we're](https://youtu.be/AyB3yDuZRTo?t=00h04m50s)

[just going to leverage this thing here](https://youtu.be/AyB3yDuZRTo?t=00h04m51s)

[and we're going to just build this out](https://youtu.be/AyB3yDuZRTo?t=00h04m54s)

[so](https://youtu.be/AyB3yDuZRTo?t=00h04m56s)

[and then this will be](https://youtu.be/AyB3yDuZRTo?t=00h04m59s)

[I don't know why the](https://youtu.be/AyB3yDuZRTo?t=00h05m02s)

[yeah the comment starts there I don't](https://youtu.be/AyB3yDuZRTo?t=00h05m05s)

[know why the highlighting isn't picking](https://youtu.be/AyB3yDuZRTo?t=00h05m07s)

[it up okay oh it's probably because I'm](https://youtu.be/AyB3yDuZRTo?t=00h05m08s)

[in the middle of a debug session and it](https://youtu.be/AyB3yDuZRTo?t=00h05m10s)

[has no idea which end is up](https://youtu.be/AyB3yDuZRTo?t=00h05m11s)

[that's probably a pretty good reason uh](https://youtu.be/AyB3yDuZRTo?t=00h05m14s)

[let's see tree list View](https://youtu.be/AyB3yDuZRTo?t=00h05m16s)

[and then we're going to do something](https://youtu.be/AyB3yDuZRTo?t=00h05m20s)

[like uh item Source we're going to do](https://youtu.be/AyB3yDuZRTo?t=00h05m21s)

[the same binding we leveraged on the](https://youtu.be/AyB3yDuZRTo?t=00h05m25s)

[other one which was movies something](https://youtu.be/AyB3yDuZRTo?t=00h05m28s)

[movie categories](https://youtu.be/AyB3yDuZRTo?t=00h05m31s)

[boom and then we'll do a](https://youtu.be/AyB3yDuZRTo?t=00h05m33s)

[uh let's see material](https://youtu.be/AyB3yDuZRTo?t=00h05m36s)

[design](https://youtu.be/AyB3yDuZRTo?t=00h05m40s)

[tree list View](https://youtu.be/AyB3yDuZRTo?t=00h05m43s)

[okay copilot here's your time to shine](https://youtu.be/AyB3yDuZRTo?t=00h05m44s)

[uh that's pretty darn close](https://youtu.be/AyB3yDuZRTo?t=00h05m50s)

[oh pilot you're amazing you are freaking](https://youtu.be/AyB3yDuZRTo?t=00h05m56s)

[amazing okay we need to build because](https://youtu.be/AyB3yDuZRTo?t=00h05m59s)

[right now the treeless view lives in the](https://youtu.be/AyB3yDuZRTo?t=00h06m01s)

[the library and this is the demo app and](https://youtu.be/AyB3yDuZRTo?t=00h06m03s)

[the xaml designer is not hip when it](https://youtu.be/AyB3yDuZRTo?t=00h06m06s)

[doesn't know about things](https://youtu.be/AyB3yDuZRTo?t=00h06m09s)

[it gets very very confused and really](https://youtu.be/AyB3yDuZRTo?t=00h06m13s)

[wants you to recompile](https://youtu.be/AyB3yDuZRTo?t=00h06m15s)

[we'll recompile it's happier](https://youtu.be/AyB3yDuZRTo?t=00h06m17s)

[okay](https://youtu.be/AyB3yDuZRTo?t=00h06m20s)

[um I think that's gonna get us pretty](https://youtu.be/AyB3yDuZRTo?t=00h06m22s)

[close to what we wanted](https://youtu.be/AyB3yDuZRTo?t=00h06m24s)

[so let's start there and see see how](https://youtu.be/AyB3yDuZRTo?t=00h06m26s)

[close this is](https://youtu.be/AyB3yDuZRTo?t=00h06m29s)

[aside from the fact that there's no](https://youtu.be/AyB3yDuZRTo?t=00h06m35s)

[expansion](https://youtu.be/AyB3yDuZRTo?t=00h06m37s)

[we do have the selection stuff](https://youtu.be/AyB3yDuZRTo?t=00h06m39s)

[all of that's fine okay so let's set up](https://youtu.be/AyB3yDuZRTo?t=00h06m42s)

[let's set up some styling for this guy](https://youtu.be/AyB3yDuZRTo?t=00h06m45s)

[um and I](https://youtu.be/AyB3yDuZRTo?t=00h06m49s)

[think we're gonna still do it in the](https://youtu.be/AyB3yDuZRTo?t=00h06m50s)

[trees](https://youtu.be/AyB3yDuZRTo?t=00h06m52s)

[section here](https://youtu.be/AyB3yDuZRTo?t=00h06m54s)

[uh no not there down in the themes](https://youtu.be/AyB3yDuZRTo?t=00h06m55s)

[themes trees](https://youtu.be/AyB3yDuZRTo?t=00h07m00s)

[preview okay so we're gonna do something](https://youtu.be/AyB3yDuZRTo?t=00h07m04s)

[not too unlike this](https://youtu.be/AyB3yDuZRTo?t=00h07m09s)

[copy paste okay material design](https://youtu.be/AyB3yDuZRTo?t=00h07m12s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h07m19s)

[uh tree list View](https://youtu.be/AyB3yDuZRTo?t=00h07m21s)

[uh let's see WPF tree](https://youtu.be/AyB3yDuZRTo?t=00h07m24s)

[list View](https://youtu.be/AyB3yDuZRTo?t=00h07m28s)

[come up here](https://youtu.be/AyB3yDuZRTo?t=00h07m30s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=00h07m33s)

[three](https://youtu.be/AyB3yDuZRTo?t=00h07m37s)

[list view item](https://youtu.be/AyB3yDuZRTo?t=00h07m39s)

[I'm already liking](https://youtu.be/AyB3yDuZRTo?t=00h07m43s)

[I'm already liking the naming](https://youtu.be/AyB3yDuZRTo?t=00h07m46s)

[already liking this better than where we](https://youtu.be/AyB3yDuZRTo?t=00h07m48s)

[were going last time](https://youtu.be/AyB3yDuZRTo?t=00h07m50s)

[sometimes you just need a good long](https://youtu.be/AyB3yDuZRTo?t=00h07m51s)

[think](https://youtu.be/AyB3yDuZRTo?t=00h07m53s)

[uh okay so this is gonna get us](https://youtu.be/AyB3yDuZRTo?t=00h07m54s)

[okay so we gotta change up some data](https://youtu.be/AyB3yDuZRTo?t=00h07m59s)

[types in here and I saw a couple](https://youtu.be/AyB3yDuZRTo?t=00h08m01s)

[compilers](https://youtu.be/AyB3yDuZRTo?t=00h08m02s)

[just gonna scan this really quick](https://youtu.be/AyB3yDuZRTo?t=00h08m04s)

[I'm trying to decide how much how much](https://youtu.be/AyB3yDuZRTo?t=00h08m09s)

[we try to hide away the fact that it is](https://youtu.be/AyB3yDuZRTo?t=00h08m11s)

[not a](https://youtu.be/AyB3yDuZRTo?t=00h08m13s)

[that's not a real](https://youtu.be/AyB3yDuZRTo?t=00h08m16s)

[Tree View](https://youtu.be/AyB3yDuZRTo?t=00h08m19s)

[uh let's actually I want to unindent](https://youtu.be/AyB3yDuZRTo?t=00h08m21s)

[these](https://youtu.be/AyB3yDuZRTo?t=00h08m25s)

[and wrap you around](https://youtu.be/AyB3yDuZRTo?t=00h08m26s)

[okay](https://youtu.be/AyB3yDuZRTo?t=00h08m29s)

[uh uh header is not recognized](https://youtu.be/AyB3yDuZRTo?t=00h08m30s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h08m46s)

[uh content](https://youtu.be/AyB3yDuZRTo?t=00h08m48s)

[as items](https://youtu.be/AyB3yDuZRTo?t=00h08m54s)

[we might need to implement that](https://youtu.be/AyB3yDuZRTo?t=00h08m57s)

[I would rather add that item though](https://youtu.be/AyB3yDuZRTo?t=00h09m00s)

[um items panel](https://youtu.be/AyB3yDuZRTo?t=00h09m05s)

[we're going to need a handle](https://youtu.be/AyB3yDuZRTo?t=00h09m07s)

[but I I I and we may or may not actually](https://youtu.be/AyB3yDuZRTo?t=00h09m11s)

[need to handle items panel](https://youtu.be/AyB3yDuZRTo?t=00h09m14s)

[this is there may be a couple times](https://youtu.be/AyB3yDuZRTo?t=00h09m16s)

[where if somebody wants to re-template](https://youtu.be/AyB3yDuZRTo?t=00h09m18s)

[this they they really do need to](https://youtu.be/AyB3yDuZRTo?t=00h09m20s)

[focus on uh](https://youtu.be/AyB3yDuZRTo?t=00h09m24s)

[understanding how it's set up](https://youtu.be/AyB3yDuZRTo?t=00h09m26s)

[okay so that gets me to there](https://youtu.be/AyB3yDuZRTo?t=00h09m29s)

[that gets me to there that's probably](https://youtu.be/AyB3yDuZRTo?t=00h09m33s)

[close](https://youtu.be/AyB3yDuZRTo?t=00h09m36s)

[okay let's add in](https://youtu.be/AyB3yDuZRTo?t=00h09m37s)

[um default styling](https://youtu.be/AyB3yDuZRTo?t=00h09m41s)

[I think that's where we were doing it](https://youtu.be/AyB3yDuZRTo?t=00h09m46s)

[here yeah](https://youtu.be/AyB3yDuZRTo?t=00h09m47s)

[I wasn't thrilled about it but we're](https://youtu.be/AyB3yDuZRTo?t=00h09m49s)

[gonna](https://youtu.be/AyB3yDuZRTo?t=00h09m51s)

[we're gonna continue the thing that I'm](https://youtu.be/AyB3yDuZRTo?t=00h09m53s)

[not thrilled with because why not](https://youtu.be/AyB3yDuZRTo?t=00h09m54s)

[free list](https://youtu.be/AyB3yDuZRTo?t=00h09m57s)

[View](https://youtu.be/AyB3yDuZRTo?t=00h10m03s)

[uh let's see here tree](https://youtu.be/AyB3yDuZRTo?t=00h10m05s)

[list view item so these things here are](https://youtu.be/AyB3yDuZRTo?t=00h10m09s)

[implicit styles that when WPF is looking](https://youtu.be/AyB3yDuZRTo?t=00h10m12s)

[for](https://youtu.be/AyB3yDuZRTo?t=00h10m15s)

[the appropriate uh style for these](https://youtu.be/AyB3yDuZRTo?t=00h10m16s)

[controls it'll land on here and the](https://youtu.be/AyB3yDuZRTo?t=00h10m19s)

[Styles each Define the appropriate](https://youtu.be/AyB3yDuZRTo?t=00h10m21s)

[template](https://youtu.be/AyB3yDuZRTo?t=00h10m24s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h10m27s)

[uh tree this view item okay so that](https://youtu.be/AyB3yDuZRTo?t=00h10m28s)

[should just magically style the control](https://youtu.be/AyB3yDuZRTo?t=00h10m31s)

[up for us so it doesn't look all](https://youtu.be/AyB3yDuZRTo?t=00h10m34s)

[old school wpfe](https://youtu.be/AyB3yDuZRTo?t=00h10m36s)

[because as cool as the technology was in](https://youtu.be/AyB3yDuZRTo?t=00h10m40s)

[2005 we can do better](https://youtu.be/AyB3yDuZRTo?t=00h10m42s)

[okay](https://youtu.be/AyB3yDuZRTo?t=00h10m47s)

[I cannot bind](https://youtu.be/AyB3yDuZRTo?t=00h10m49s)

[uh uh no property named header](https://youtu.be/AyB3yDuZRTo?t=00h10m52s)

[got it so we messed up in here somewhere](https://youtu.be/AyB3yDuZRTo?t=00h10m58s)

[this we're at yeah](https://youtu.be/AyB3yDuZRTo?t=00h11m06s)

[content source](https://youtu.be/AyB3yDuZRTo?t=00h11m10s)

[content](https://youtu.be/AyB3yDuZRTo?t=00h11m12s)

[do we loop around yeah](https://youtu.be/AyB3yDuZRTo?t=00h11m21s)

[okay let's try that I think it was just](https://youtu.be/AyB3yDuZRTo?t=00h11m25s)

[that being the problem](https://youtu.be/AyB3yDuZRTo?t=00h11m28s)

[in reality this should probably end up](https://youtu.be/AyB3yDuZRTo?t=00h11m34s)

[in its own research dictionary but I](https://youtu.be/AyB3yDuZRTo?t=00h11m36s)

[kind of want to leave it here where I](https://youtu.be/AyB3yDuZRTo?t=00h11m38s)

[can easily leverage it](https://youtu.be/AyB3yDuZRTo?t=00h11m39s)

[uh let's see can only bind a style with](https://youtu.be/AyB3yDuZRTo?t=00h11m42s)

[a Target type oh so I didn't set](https://youtu.be/AyB3yDuZRTo?t=00h11m45s)

[uh the appropriate Target type on my](https://youtu.be/AyB3yDuZRTo?t=00h11m49s)

[styles](https://youtu.be/AyB3yDuZRTo?t=00h11m51s)

[all of these errors are effectively WPF](https://youtu.be/AyB3yDuZRTo?t=00h11m53s)

[saying what are you doing you [ __ ]](https://youtu.be/AyB3yDuZRTo?t=00h11m55s)

[uh let's see so it wasn't that one it](https://youtu.be/AyB3yDuZRTo?t=00h11m58s)

[was the next one down that I forgot to](https://youtu.be/AyB3yDuZRTo?t=00h12m00s)

[do](https://youtu.be/AyB3yDuZRTo?t=00h12m02s)

[tree list View](https://youtu.be/AyB3yDuZRTo?t=00h12m04s)

[huh](https://youtu.be/AyB3yDuZRTo?t=00h12m06s)

[what was the air again](https://youtu.be/AyB3yDuZRTo?t=00h12m14s)

[oh the control template](https://youtu.be/AyB3yDuZRTo?t=00h12m18s)

[uh it can only base this Talent](https://youtu.be/AyB3yDuZRTo?t=00h12m22s)

[well okay](https://youtu.be/AyB3yDuZRTo?t=00h12m26s)

[fix the bug we can see and then we'll](https://youtu.be/AyB3yDuZRTo?t=00h12m28s)

[deal with the one we can't see](https://youtu.be/AyB3yDuZRTo?t=00h12m30s)

[tree](https://youtu.be/AyB3yDuZRTo?t=00h12m33s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h12m36s)

[tree](https://youtu.be/AyB3yDuZRTo?t=00h12m42s)

[list View](https://youtu.be/AyB3yDuZRTo?t=00h12m44s)

[don't know why the intellisense wasn't](https://youtu.be/AyB3yDuZRTo?t=00h12m47s)

[helping me](https://youtu.be/AyB3yDuZRTo?t=00h12m49s)

[and then did I mess it up in the default](https://youtu.be/AyB3yDuZRTo?t=00h12m54s)

[somewhere](https://youtu.be/AyB3yDuZRTo?t=00h12m56s)

[tree this view to this View](https://youtu.be/AyB3yDuZRTo?t=00h12m59s)

[oh tree list View and then I pointed at](https://youtu.be/AyB3yDuZRTo?t=00h13m04s)

[the item](https://youtu.be/AyB3yDuZRTo?t=00h13m07s)

[as soon as I retrieve this view item](https://youtu.be/AyB3yDuZRTo?t=00h13m08s)

[okay](https://youtu.be/AyB3yDuZRTo?t=00h13m10s)

[that's probably the one that it was](https://youtu.be/AyB3yDuZRTo?t=00h13m11s)

[actually squawking about](https://youtu.be/AyB3yDuZRTo?t=00h13m13s)

[come on](https://youtu.be/AyB3yDuZRTo?t=00h13m21s)

[there we are](https://youtu.be/AyB3yDuZRTo?t=00h13m25s)

[Okay so we've got that much](https://youtu.be/AyB3yDuZRTo?t=00h13m27s)

[okay and this is where I think we](https://youtu.be/AyB3yDuZRTo?t=00h13m31s)

[actually then spend our time dealing](https://youtu.be/AyB3yDuZRTo?t=00h13m33s)

[with this is we want effectively this to](https://youtu.be/AyB3yDuZRTo?t=00h13m35s)

[start changing out and you know what I'm](https://youtu.be/AyB3yDuZRTo?t=00h13m39s)

[annoyed at that](https://youtu.be/AyB3yDuZRTo?t=00h13m40s)

[Hang on we're going to fix this](https://youtu.be/AyB3yDuZRTo?t=00h13m42s)

[foreground because it's bothering me](https://youtu.be/AyB3yDuZRTo?t=00h13m43s)

[already](https://youtu.be/AyB3yDuZRTo?t=00h13m45s)

[so why are you why are you foreground](https://youtu.be/AyB3yDuZRTo?t=00h13m47s)

[stupid](https://youtu.be/AyB3yDuZRTo?t=00h13m49s)

[okay so foreground black inherited chase](https://youtu.be/AyB3yDuZRTo?t=00h13m52s)

[the rabbit up the food chain](https://youtu.be/AyB3yDuZRTo?t=00h13m55s)

[inherited chase the rabbit up the food](https://youtu.be/AyB3yDuZRTo?t=00h13m57s)

[chain inherited](https://youtu.be/AyB3yDuZRTo?t=00h13m59s)

[inherited](https://youtu.be/AyB3yDuZRTo?t=00h14m01s)

[inherited](https://youtu.be/AyB3yDuZRTo?t=00h14m03s)

[inherited](https://youtu.be/AyB3yDuZRTo?t=00h14m05s)

[inherited](https://youtu.be/AyB3yDuZRTo?t=00h14m08s)

[true list view item](https://youtu.be/AyB3yDuZRTo?t=00h14m09s)

[binding path foreground relative Source](https://youtu.be/AyB3yDuZRTo?t=00h14m11s)

[find ancestor tree view look at that](https://youtu.be/AyB3yDuZRTo?t=00h14m14s)

[that thing's failing the binding's](https://youtu.be/AyB3yDuZRTo?t=00h14m17s)

[failing that's why we're getting black](https://youtu.be/AyB3yDuZRTo?t=00h14m19s)

[so inside of my tree list view item](https://youtu.be/AyB3yDuZRTo?t=00h14m21s)

[there is a foreground Setter and it is](https://youtu.be/AyB3yDuZRTo?t=00h14m23s)

[because I can see it's coming from the](https://youtu.be/AyB3yDuZRTo?t=00h14m26s)

[style](https://youtu.be/AyB3yDuZRTo?t=00h14m27s)

[and that be the problem so](https://youtu.be/AyB3yDuZRTo?t=00h14m29s)

[let's see my item foreground ancestor](https://youtu.be/AyB3yDuZRTo?t=00h14m34s)

[type](https://youtu.be/AyB3yDuZRTo?t=00h14m38s)

[look at that that is not going to do](https://youtu.be/AyB3yDuZRTo?t=00h14m38s)

[what we would like](https://youtu.be/AyB3yDuZRTo?t=00h14m41s)

[we do that](https://youtu.be/AyB3yDuZRTo?t=00h14m43s)

[and now that's your propagate down](https://youtu.be/AyB3yDuZRTo?t=00h14m46s)

[properly](https://youtu.be/AyB3yDuZRTo?t=00h14m47s)

[anyway hopefully now we get the right](https://youtu.be/AyB3yDuZRTo?t=00h14m55s)

[setup](https://youtu.be/AyB3yDuZRTo?t=00h14m57s)

[there we go okay so we got white](https://youtu.be/AyB3yDuZRTo?t=00h15m01s)

[okay so here's my thinking](https://youtu.be/AyB3yDuZRTo?t=00h15m04s)

[we're gonna have to do some magic at](https://youtu.be/AyB3yDuZRTo?t=00h15m07s)

[some point Something's Gonna Have to](https://youtu.be/AyB3yDuZRTo?t=00h15m09s)

[flatten this list now we either tell the](https://youtu.be/AyB3yDuZRTo?t=00h15m11s)

[caller you have to flatten it](https://youtu.be/AyB3yDuZRTo?t=00h15m13s)

[but then we have the question of how](https://youtu.be/AyB3yDuZRTo?t=00h15m16s)

[does the caller indicate hierarchy to us](https://youtu.be/AyB3yDuZRTo?t=00h15m18s)

[I kind of like the idea](https://youtu.be/AyB3yDuZRTo?t=00h15m21s)

[emphasis on kinda I I kind of like the](https://youtu.be/AyB3yDuZRTo?t=00h15m24s)

[idea of the caller interacting with this](https://youtu.be/AyB3yDuZRTo?t=00h15m28s)

[the same way they would](https://youtu.be/AyB3yDuZRTo?t=00h15m31s)

[with a tree view I mean with a](https://youtu.be/AyB3yDuZRTo?t=00h15m33s)

[hierarchical data template](https://youtu.be/AyB3yDuZRTo?t=00h15m35s)

[I think this is what I like](https://youtu.be/AyB3yDuZRTo?t=00h15m37s)

[so my thought is](https://youtu.be/AyB3yDuZRTo?t=00h15m41s)

[if internally](https://youtu.be/AyB3yDuZRTo?t=00h15m43s)

[we haven't so rather than letting item](https://youtu.be/AyB3yDuZRTo?t=00h15m46s)

[Source flow all the way in](https://youtu.be/AyB3yDuZRTo?t=00h15m48s)

[I'm wondering if we hijack it](https://youtu.be/AyB3yDuZRTo?t=00h15m50s)

[and internally we set the item source to](https://youtu.be/AyB3yDuZRTo?t=00h15m54s)

[something else](https://youtu.be/AyB3yDuZRTo?t=00h15m56s)

[we let this be a thing](https://youtu.be/AyB3yDuZRTo?t=00h15m57s)

[and then we go somewhere else with it I](https://youtu.be/AyB3yDuZRTo?t=00h16m03s)

[I'm wondering if that makes our life](https://youtu.be/AyB3yDuZRTo?t=00h16m06s)

[easier](https://youtu.be/AyB3yDuZRTo?t=00h16m08s)

[I guess the question is](https://youtu.be/AyB3yDuZRTo?t=00h16m12s)

[what is the right way of doing that](https://youtu.be/AyB3yDuZRTo?t=00h16m15s)

[I'm I'm wondering if that makes the most](https://youtu.be/AyB3yDuZRTo?t=00h16m27s)

[sense because if we are able to](https://youtu.be/AyB3yDuZRTo?t=00h16m30s)

[because we already know when the items](https://youtu.be/AyB3yDuZRTo?t=00h16m33s)

[are being created](https://youtu.be/AyB3yDuZRTo?t=00h16m36s)

[right like we we are building these](https://youtu.be/AyB3yDuZRTo?t=00h16m39s)

[things up](https://youtu.be/AyB3yDuZRTo?t=00h16m41s)

[we can do whatever we need to here](https://youtu.be/AyB3yDuZRTo?t=00h16m42s)

[and I'm thinking if we let this one here](https://youtu.be/AyB3yDuZRTo?t=00h16m50s)

[well how do I get it how do I override](https://youtu.be/AyB3yDuZRTo?t=00h16m56s)

[that item Source binding then in the](https://youtu.be/AyB3yDuZRTo?t=00h16m59s)

[middle right I can't just over it's not](https://youtu.be/AyB3yDuZRTo?t=00h17m01s)

[virtual is it](https://youtu.be/AyB3yDuZRTo?t=00h17m04s)

[no](https://youtu.be/AyB3yDuZRTo?t=00h17m08s)

[but everything related to it is so I can](https://youtu.be/AyB3yDuZRTo?t=00h17m11s)

[be easily notified when](https://youtu.be/AyB3yDuZRTo?t=00h17m14s)

[something around it changes](https://youtu.be/AyB3yDuZRTo?t=00h17m18s)

[and this is why I'm wondering if maybe](https://youtu.be/AyB3yDuZRTo?t=00h17m22s)

[it makes sense to](https://youtu.be/AyB3yDuZRTo?t=00h17m24s)

[we could tell the callers they just have](https://youtu.be/AyB3yDuZRTo?t=00h17m32s)

[to feed us a flat list but then how](https://youtu.be/AyB3yDuZRTo?t=00h17m34s)

[would we expect them to indicate](https://youtu.be/AyB3yDuZRTo?t=00h17m36s)

[hierarchy](https://youtu.be/AyB3yDuZRTo?t=00h17m37s)

[it seems really disgusting](https://youtu.be/AyB3yDuZRTo?t=00h17m40s)

[because at the end of the day you might](https://youtu.be/AyB3yDuZRTo?t=00h17m43s)

[want a different](https://youtu.be/AyB3yDuZRTo?t=00h17m45s)

[data template at the different levels](https://youtu.be/AyB3yDuZRTo?t=00h17m46s)

[which is exactly what the hierarchical](https://youtu.be/AyB3yDuZRTo?t=00h17m48s)

[data template gives you](https://youtu.be/AyB3yDuZRTo?t=00h17m50s)

[so](https://youtu.be/AyB3yDuZRTo?t=00h17m52s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h17m58s)

[let's let's let's play with this items](https://youtu.be/AyB3yDuZRTo?t=00h18m00s)

[uh container](https://youtu.be/AyB3yDuZRTo?t=00h18m03s)

[item container generator so this is the](https://youtu.be/AyB3yDuZRTo?t=00h18m08s)

[magical guy that does a lot of the work](https://youtu.be/AyB3yDuZRTo?t=00h18m10s)

[for us](https://youtu.be/AyB3yDuZRTo?t=00h18m13s)

[so](https://youtu.be/AyB3yDuZRTo?t=00h18m15s)

[this guy here doesn't have and is](https://youtu.be/AyB3yDuZRTo?t=00h18m16s)

[expanded so let's start there](https://youtu.be/AyB3yDuZRTo?t=00h18m18s)

[uh see](https://youtu.be/AyB3yDuZRTo?t=00h18m20s)

[we want a pool](https://youtu.be/AyB3yDuZRTo?t=00h18m26s)

[is](https://youtu.be/AyB3yDuZRTo?t=00h18m31s)

[expanded](https://youtu.be/AyB3yDuZRTo?t=00h18m33s)

[we want all the](https://youtu.be/AyB3yDuZRTo?t=00h18m35s)

[usual culprits and then](https://youtu.be/AyB3yDuZRTo?t=00h18m37s)

[uh let's see free in this view item](https://youtu.be/AyB3yDuZRTo?t=00h18m40s)

[and then we want a framework property](https://youtu.be/AyB3yDuZRTo?t=00h18m44s)

[metadata because we would like to](https://youtu.be/AyB3yDuZRTo?t=00h18m48s)

[override this so I'm going to default to](https://youtu.be/AyB3yDuZRTo?t=00h18m49s)

[false](https://youtu.be/AyB3yDuZRTo?t=00h18m52s)

[and we would like](https://youtu.be/AyB3yDuZRTo?t=00h18m53s)

[binds to a by default we probably want](https://youtu.be/AyB3yDuZRTo?t=00h19m00s)

[to let it know that it's going to change](https://youtu.be/AyB3yDuZRTo?t=00h19m03s)

[like measure and whatnot as well](https://youtu.be/AyB3yDuZRTo?t=00h19m04s)

[um but we're gonna do that start here](https://youtu.be/AyB3yDuZRTo?t=00h19m08s)

[start here so we at least know about it](https://youtu.be/AyB3yDuZRTo?t=00h19m11s)

[and then we would like just the item](https://youtu.be/AyB3yDuZRTo?t=00h19m14s)

[no this is the tree list view this is](https://youtu.be/AyB3yDuZRTo?t=00h19m20s)

[the item](https://youtu.be/AyB3yDuZRTo?t=00h19m23s)

[we would like to bind in this toggle](https://youtu.be/AyB3yDuZRTo?t=00h19m24s)

[button here](https://youtu.be/AyB3yDuZRTo?t=00h19m27s)

[uh yeah so he's now](https://youtu.be/AyB3yDuZRTo?t=00h19m30s)

[conveniently already bound to is](https://youtu.be/AyB3yDuZRTo?t=00h19m33s)

[expanded](https://youtu.be/AyB3yDuZRTo?t=00h19m35s)

[move you over okay and then I would also](https://youtu.be/AyB3yDuZRTo?t=00h19m40s)

[like to set up a callback](https://youtu.be/AyB3yDuZRTo?t=00h19m43s)

[I think](https://youtu.be/AyB3yDuZRTo?t=00h19m47s)

[on is expanded change](https://youtu.be/AyB3yDuZRTo?t=00h19m50s)

[so generate me a method](https://youtu.be/AyB3yDuZRTo?t=00h19m55s)

[and be an empty method](https://youtu.be/AyB3yDuZRTo?t=00h19m59s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=00h20m03s)

[I am calling the wrong overload here](https://youtu.be/AyB3yDuZRTo?t=00h20m07s)

[because I need](https://youtu.be/AyB3yDuZRTo?t=00h20m09s)

[default value framework property](https://youtu.be/AyB3yDuZRTo?t=00h20m12s)

[metadata options](https://youtu.be/AyB3yDuZRTo?t=00h20m14s)

[property changed callback what is your](https://youtu.be/AyB3yDuZRTo?t=00h20m16s)

[problem here](https://youtu.be/AyB3yDuZRTo?t=00h20m18s)

[uh yeah](https://youtu.be/AyB3yDuZRTo?t=00h20m25s)

[unchanged oh is this a course](https://youtu.be/AyB3yDuZRTo?t=00h20m27s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h20m30s)

[uh yeah so it's trying to hit the](https://youtu.be/AyB3yDuZRTo?t=00h20m33s)

[property chain](https://youtu.be/AyB3yDuZRTo?t=00h20m38s)

[call back](https://youtu.be/AyB3yDuZRTo?t=00h20m41s)

[let me what somebody will you show me](https://youtu.be/AyB3yDuZRTo?t=00h20m44s)

[what your problem is](https://youtu.be/AyB3yDuZRTo?t=00h20m46s)

[void oh so you generated me there were](https://youtu.be/AyB3yDuZRTo?t=00h20m57s)

[oh that's what happened](https://youtu.be/AyB3yDuZRTo?t=00h21m00s)

[it generated the wrong one uh because it](https://youtu.be/AyB3yDuZRTo?t=00h21m02s)

[didn't know which overload so it guessed](https://youtu.be/AyB3yDuZRTo?t=00h21m06s)

[and it guessed poorly](https://youtu.be/AyB3yDuZRTo?t=00h21m08s)

[excellent](https://youtu.be/AyB3yDuZRTo?t=00h21m10s)

[okay so let's not have any of this](https://youtu.be/AyB3yDuZRTo?t=00h21m12s)

[garbage boom okay so you go like that](https://youtu.be/AyB3yDuZRTo?t=00h21m14s)

[and then we don't need this](https://youtu.be/AyB3yDuZRTo?t=00h21m17s)

[compiler can figure it out based on the](https://youtu.be/AyB3yDuZRTo?t=00h21m19s)

[signature](https://youtu.be/AyB3yDuZRTo?t=00h21m21s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h21m22s)

[expanded](https://youtu.be/AyB3yDuZRTo?t=00h21m24s)

[expanded okay](https://youtu.be/AyB3yDuZRTo?t=00h21m27s)

[this is the part where when this changes](https://youtu.be/AyB3yDuZRTo?t=00h21m34s)

[we want to do something about this](https://youtu.be/AyB3yDuZRTo?t=00h21m37s)

[um let's have this guy just for now at](https://youtu.be/AyB3yDuZRTo?t=00h21m41s)

[least have a reference directly to his](https://youtu.be/AyB3yDuZRTo?t=00h21m44s)

[parent](https://youtu.be/AyB3yDuZRTo?t=00h21m46s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=00h21m47s)

[three list View](https://youtu.be/AyB3yDuZRTo?t=00h21m50s)

[we're gonna make you internal because I](https://youtu.be/AyB3yDuZRTo?t=00h21m56s)

[don't want](https://youtu.be/AyB3yDuZRTo?t=00h21m58s)

[other people abusing this uh](https://youtu.be/AyB3yDuZRTo?t=00h21m59s)

[uh free list View](https://youtu.be/AyB3yDuZRTo?t=00h22m03s)

[uh create and assigned property that](https://youtu.be/AyB3yDuZRTo?t=00h22m05s)

[sounds great](https://youtu.be/AyB3yDuZRTo?t=00h22m07s)

[uh nullable sounds great](https://youtu.be/AyB3yDuZRTo?t=00h22m09s)

[that's not what you put the question](https://youtu.be/AyB3yDuZRTo?t=00h22m13s)

[mark](https://youtu.be/AyB3yDuZRTo?t=00h22m14s)

[I was really confused](https://youtu.be/AyB3yDuZRTo?t=00h22m16s)

[okay so tree list view uh](https://youtu.be/AyB3yDuZRTo?t=00h22m19s)

[item](https://youtu.be/AyB3yDuZRTo?t=00h22m25s)

[expanded](https://youtu.be/AyB3yDuZRTo?t=00h22m27s)

[uh and let's do](https://youtu.be/AyB3yDuZRTo?t=00h22m31s)

[if D is treeless view item](https://youtu.be/AyB3yDuZRTo?t=00h22m34s)

[it should always be](https://youtu.be/AyB3yDuZRTo?t=00h22m38s)

[uh and then we're gonna do item](https://youtu.be/AyB3yDuZRTo?t=00h22m44s)

[what's your problem uh let's see](https://youtu.be/AyB3yDuZRTo?t=00h22m48s)

[oh item Dot](https://youtu.be/AyB3yDuZRTo?t=00h22m51s)

[it's probably not at least probably](https://youtu.be/AyB3yDuZRTo?t=00h22m59s)

[forward this through](https://youtu.be/AyB3yDuZRTo?t=00h23m00s)

[but that's okay yeah we're we're going](https://youtu.be/AyB3yDuZRTo?t=00h23m02s)

[quick and dirty](https://youtu.be/AyB3yDuZRTo?t=00h23m04s)

[make it work make it right make it fast](https://youtu.be/AyB3yDuZRTo?t=00h23m06s)

[I can see I am destined to not know how](https://youtu.be/AyB3yDuZRTo?t=00h23m13s)

[to spell this all night long](https://youtu.be/AyB3yDuZRTo?t=00h23m15s)

[so which is probably good that means](https://youtu.be/AyB3yDuZRTo?t=00h23m17s)

[people are watching my typing skill goes](https://youtu.be/AyB3yDuZRTo?t=00h23m19s)

[down when people watch](https://youtu.be/AyB3yDuZRTo?t=00h23m21s)

[uh okay](https://youtu.be/AyB3yDuZRTo?t=00h23m23s)

[something something to this effect and](https://youtu.be/AyB3yDuZRTo?t=00h23m24s)

[then in here what we'd like to do is we](https://youtu.be/AyB3yDuZRTo?t=00h23m27s)

[would like to grab it and know that uh](https://youtu.be/AyB3yDuZRTo?t=00h23m29s)

[and do something with adding our items](https://youtu.be/AyB3yDuZRTo?t=00h23m34s)

[uh and I think what we want to do here](https://youtu.be/AyB3yDuZRTo?t=00h23m37s)

[is we need a new value](https://youtu.be/AyB3yDuZRTo?t=00h23m39s)

[Hardcastle](https://youtu.be/AyB3yDuZRTo?t=00h23m41s)

[uh we'll rename this item expanded](https://youtu.be/AyB3yDuZRTo?t=00h23m44s)

[changed](https://youtu.be/AyB3yDuZRTo?t=00h23m48s)

[and we'll do something like pool is](https://youtu.be/AyB3yDuZRTo?t=00h23m50s)

[expanded](https://youtu.be/AyB3yDuZRTo?t=00h23m55s)

[something to that effect](https://youtu.be/AyB3yDuZRTo?t=00h23m57s)

[okay let's make sure at least this much](https://youtu.be/AyB3yDuZRTo?t=00h24m05s)

[works](https://youtu.be/AyB3yDuZRTo?t=00h24m06s)

[I'm going to start with just that break](https://youtu.be/AyB3yDuZRTo?t=00h24m08s)

[point](https://youtu.be/AyB3yDuZRTo?t=00h24m09s)

[because I'm thinking if we do something](https://youtu.be/AyB3yDuZRTo?t=00h24m16s)

[like this we can add additional](https://youtu.be/AyB3yDuZRTo?t=00h24m17s)

[properties](https://youtu.be/AyB3yDuZRTo?t=00h24m18s)

[to the tree list view item that's like](https://youtu.be/AyB3yDuZRTo?t=00h24m19s)

[level or whatever it's indented to so if](https://youtu.be/AyB3yDuZRTo?t=00h24m22s)

[I do this](https://youtu.be/AyB3yDuZRTo?t=00h24m25s)

[obviously it fails excellent I was](https://youtu.be/AyB3yDuZRTo?t=00h24m27s)

[worried it would work the first try](https://youtu.be/AyB3yDuZRTo?t=00h24m30s)

[okay so that there](https://youtu.be/AyB3yDuZRTo?t=00h24m34s)

[oh](https://youtu.be/AyB3yDuZRTo?t=00h24m40s)

[turns out you need to not be a [ __ ]](https://youtu.be/AyB3yDuZRTo?t=00h24m42s)

[and if you don't call the right](https://youtu.be/AyB3yDuZRTo?t=00h24m45s)

[Constructor it isn't going to work](https://youtu.be/AyB3yDuZRTo?t=00h24m46s)

[okay so let's try the let's try the](https://youtu.be/AyB3yDuZRTo?t=00h24m48s)

[Constructor that actually does what we](https://youtu.be/AyB3yDuZRTo?t=00h24m50s)

[want](https://youtu.be/AyB3yDuZRTo?t=00h24m52s)

[okay in reality I think we'll probably](https://youtu.be/AyB3yDuZRTo?t=00h25m07s)

[end up with like a routed event or](https://youtu.be/AyB3yDuZRTo?t=00h25m09s)

[something](https://youtu.be/AyB3yDuZRTo?t=00h25m11s)

[which I think is a little better anyway](https://youtu.be/AyB3yDuZRTo?t=00h25m12s)

[but that will be neither here nor there](https://youtu.be/AyB3yDuZRTo?t=00h25m13s)

[okay item expanded change is expanded](https://youtu.be/AyB3yDuZRTo?t=00h25m19s)

[true great](https://youtu.be/AyB3yDuZRTo?t=00h25m21s)

[and then if we go these expanded false](https://youtu.be/AyB3yDuZRTo?t=00h25m24s)

[we're in business](https://youtu.be/AyB3yDuZRTo?t=00h25m27s)

[okay so now the next thing we want to do](https://youtu.be/AyB3yDuZRTo?t=00h25m30s)

[is be able to get the so let's start](https://youtu.be/AyB3yDuZRTo?t=00h25m32s)

[with the true case is expanded](https://youtu.be/AyB3yDuZRTo?t=00h25m35s)

[right so now we want to do item](https://youtu.be/AyB3yDuZRTo?t=00h25m38s)

[container generator](https://youtu.be/AyB3yDuZRTo?t=00h25m42s)

[uh uh let's see because that's going to](https://youtu.be/AyB3yDuZRTo?t=00h25m45s)

[be the](https://youtu.be/AyB3yDuZRTo?t=00h25m47s)

[uh index from container](https://youtu.be/AyB3yDuZRTo?t=00h25m49s)

[so this will give us the index of the](https://youtu.be/AyB3yDuZRTo?t=00h25m53s)

[item in an RA and the important thing](https://youtu.be/AyB3yDuZRTo?t=00h25m57s)

[here is we want to find we want to use](https://youtu.be/AyB3yDuZRTo?t=00h25m59s)

[this to get the index rather than](https://youtu.be/AyB3yDuZRTo?t=00h26m02s)

[looking at like the bound data behind](https://youtu.be/AyB3yDuZRTo?t=00h26m04s)

[the scenes because that will fall apart](https://youtu.be/AyB3yDuZRTo?t=00h26m06s)

[if](https://youtu.be/AyB3yDuZRTo?t=00h26m08s)

[um hypothetically somebody puts the same](https://youtu.be/AyB3yDuZRTo?t=00h26m10s)

[instance of an object in the collection](https://youtu.be/AyB3yDuZRTo?t=00h26m11s)

[multiple times you can't just do index](https://youtu.be/AyB3yDuZRTo?t=00h26m13s)

[of and assume that the index is always](https://youtu.be/AyB3yDuZRTo?t=00h26m15s)

[going to be distinct if anyone here](https://youtu.be/AyB3yDuZRTo?t=00h26m17s)

[works for teleric take notes](https://youtu.be/AyB3yDuZRTo?t=00h26m19s)

[I'm not bitter](https://youtu.be/AyB3yDuZRTo?t=00h26m22s)

[um okay](https://youtu.be/AyB3yDuZRTo?t=00h26m24s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=00h26m27s)

[okay I just want to make sure we get the](https://youtu.be/AyB3yDuZRTo?t=00h26m33s)

[appropriate thing coming through this](https://youtu.be/AyB3yDuZRTo?t=00h26m35s)

[then we'll work on grabbing the items so](https://youtu.be/AyB3yDuZRTo?t=00h26m38s)

[let's see so this should give me a one](https://youtu.be/AyB3yDuZRTo?t=00h26m41s)

[Big Bang](https://youtu.be/AyB3yDuZRTo?t=00h26m44s)

[okay](https://youtu.be/AyB3yDuZRTo?t=00h26m46s)

[now we want to see if we can go through](https://youtu.be/AyB3yDuZRTo?t=00h26m48s)

[and get the](https://youtu.be/AyB3yDuZRTo?t=00h26m51s)

[uh item](https://youtu.be/AyB3yDuZRTo?t=00h26m53s)

[now how can we grab his template](https://youtu.be/AyB3yDuZRTo?t=00h26m56s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h27m01s)

[uh item](https://youtu.be/AyB3yDuZRTo?t=00h27m04s)

[because that's the item template](https://youtu.be/AyB3yDuZRTo?t=00h27m07s)

[selector](https://youtu.be/AyB3yDuZRTo?t=00h27m09s)

[um what I really really want to do I](https://youtu.be/AyB3yDuZRTo?t=00h27m13s)

[guess it doesn't matter](https://youtu.be/AyB3yDuZRTo?t=00h27m16s)

[well it does because it because at the](https://youtu.be/AyB3yDuZRTo?t=00h27m20s)

[end of the day what I kind of want to do](https://youtu.be/AyB3yDuZRTo?t=00h27m22s)

[is get a](https://youtu.be/AyB3yDuZRTo?t=00h27m24s)

[hierarchical data template template](https://youtu.be/AyB3yDuZRTo?t=00h27m25s)

[right so](https://youtu.be/AyB3yDuZRTo?t=00h27m28s)

[I go and check if it has a template](https://youtu.be/AyB3yDuZRTo?t=00h27m29s)

[and then down here](https://youtu.be/AyB3yDuZRTo?t=00h27m32s)

[I want to be able to get his underlying](https://youtu.be/AyB3yDuZRTo?t=00h27m38s)

[items and flatten the collection that's](https://youtu.be/AyB3yDuZRTo?t=00h27m41s)

[kind of what I'm thinking is that](https://youtu.be/AyB3yDuZRTo?t=00h27m45s)

[actually a good way of doing it](https://youtu.be/AyB3yDuZRTo?t=00h27m46s)

[is that a good way of doing it](https://youtu.be/AyB3yDuZRTo?t=00h27m49s)

[does that make sense or does it make](https://youtu.be/AyB3yDuZRTo?t=00h27m55s)

[sense for the caller to specify](https://youtu.be/AyB3yDuZRTo?t=00h27m57s)

[because if they feed us in a](https://youtu.be/AyB3yDuZRTo?t=00h28m01s)

[hierarchical data template there's a](https://youtu.be/AyB3yDuZRTo?t=00h28m04s)

[bunch of stuff that goes along with it](https://youtu.be/AyB3yDuZRTo?t=00h28m05s)

[because this will get me an item source](https://youtu.be/AyB3yDuZRTo?t=00h28m09s)

[binding](https://youtu.be/AyB3yDuZRTo?t=00h28m12s)

[which I've already got the item](https://youtu.be/AyB3yDuZRTo?t=00h28m14s)

[it gives me an item template and I can](https://youtu.be/AyB3yDuZRTo?t=00h28m21s)

[do all kinds of stuff with it](https://youtu.be/AyB3yDuZRTo?t=00h28m23s)

[because at that point I would want to](https://youtu.be/AyB3yDuZRTo?t=00h28m32s)

[flatten all of the rows from this thing](https://youtu.be/AyB3yDuZRTo?t=00h28m35s)

[into tree list view items](https://youtu.be/AyB3yDuZRTo?t=00h28m38s)

[let's go down to items control real](https://youtu.be/AyB3yDuZRTo?t=00h28m45s)

[quick](https://youtu.be/AyB3yDuZRTo?t=00h28m47s)

[what do you have](https://youtu.be/AyB3yDuZRTo?t=00h28m48s)

[what do you have](https://youtu.be/AyB3yDuZRTo?t=00h28m51s)

[because you know](https://youtu.be/AyB3yDuZRTo?t=00h28m57s)

[that's the items host](https://youtu.be/AyB3yDuZRTo?t=00h29m01s)

[I guess it's not really possible for](https://youtu.be/AyB3yDuZRTo?t=00h29m19s)

[someone to bind](https://youtu.be/AyB3yDuZRTo?t=00h29m22s)

[because if we let them bind to a flat](https://youtu.be/AyB3yDuZRTo?t=00h29m24s)

[list the color then has to specify the](https://youtu.be/AyB3yDuZRTo?t=00h29m25s)

[hierarchy](https://youtu.be/AyB3yDuZRTo?t=00h29m28s)

[and by hierarchy I mean we have to know](https://youtu.be/AyB3yDuZRTo?t=00h29m32s)

[hey the following items are are children](https://youtu.be/AyB3yDuZRTo?t=00h29m34s)

[of this other thing](https://youtu.be/AyB3yDuZRTo?t=00h29m37s)

[that really is a hierarchical data](https://youtu.be/AyB3yDuZRTo?t=00h29m39s)

[template](https://youtu.be/AyB3yDuZRTo?t=00h29m43s)

[still liking that a lot](https://youtu.be/AyB3yDuZRTo?t=00h29m45s)

[okay container](https://youtu.be/AyB3yDuZRTo?t=00h29m48s)

[but I am thinking that I want to](https://youtu.be/AyB3yDuZRTo?t=00h29m54s)

[override the](https://youtu.be/AyB3yDuZRTo?t=00h29m58s)

[the item source](https://youtu.be/AyB3yDuZRTo?t=00h30m08s)

[um item from index item control](https://youtu.be/AyB3yDuZRTo?t=00h30m13s)

[uh items panel item Source item string](https://youtu.be/AyB3yDuZRTo?t=00h30m18s)

[format template selector yeah because by](https://youtu.be/AyB3yDuZRTo?t=00h30m22s)

[building on this we can do a whole lot](https://youtu.be/AyB3yDuZRTo?t=00h30m24s)

[of work to make this](https://youtu.be/AyB3yDuZRTo?t=00h30m27s)

[yeah so let's let's go let's continue](https://youtu.be/AyB3yDuZRTo?t=00h30m39s)

[down this path because at the end of the](https://youtu.be/AyB3yDuZRTo?t=00h30m41s)

[day we want to find the appropriate](https://youtu.be/AyB3yDuZRTo?t=00h30m43s)

[template for a given item](https://youtu.be/AyB3yDuZRTo?t=00h30m45s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=00h30m51s)

[um](https://youtu.be/AyB3yDuZRTo?t=00h30m52s)

[kind of want to grab it here](https://youtu.be/AyB3yDuZRTo?t=00h30m54s)

[I want to see how we got to here](https://youtu.be/AyB3yDuZRTo?t=00h30m57s)

[and then walk backwards](https://youtu.be/AyB3yDuZRTo?t=00h31m02s)

[because I want to see where I can grab](https://youtu.be/AyB3yDuZRTo?t=00h31m05s)

[the template from](https://youtu.be/AyB3yDuZRTo?t=00h31m06s)

[because somebody is realizing this](https://youtu.be/AyB3yDuZRTo?t=00h31m09s)

[template](https://youtu.be/AyB3yDuZRTo?t=00h31m11s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=00h31m13s)

[generate next](https://youtu.be/AyB3yDuZRTo?t=00h31m17s)

[uh okay so git container for item an](https://youtu.be/AyB3yDuZRTo?t=00h31m24s)

[item in this case is going to be my](https://youtu.be/AyB3yDuZRTo?t=00h31m27s)

[you're not gonna play nice are you no](https://youtu.be/AyB3yDuZRTo?t=00h31m30s)

[um](https://youtu.be/AyB3yDuZRTo?t=00h31m34s)

[yeah item is its own container for](https://youtu.be/AyB3yDuZRTo?t=00h31m39s)

[override so let's we know it's going to](https://youtu.be/AyB3yDuZRTo?t=00h31m41s)

[call that first let's grab it there and](https://youtu.be/AyB3yDuZRTo?t=00h31m43s)

[confirm but I'm pretty sure](https://youtu.be/AyB3yDuZRTo?t=00h31m46s)

[item in this case is going to be our](https://youtu.be/AyB3yDuZRTo?t=00h31m49s)

[bound view model](https://youtu.be/AyB3yDuZRTo?t=00h31m51s)

[yes this is movie category](https://youtu.be/AyB3yDuZRTo?t=00h31m55s)

[so we do that we do that](https://youtu.be/AyB3yDuZRTo?t=00h31m58s)

[so how did it get](https://youtu.be/AyB3yDuZRTo?t=00h32m03s)

[so it got the dependency object back](https://youtu.be/AyB3yDuZRTo?t=00h32m15s)

[visual get parent blah blah blah blah](https://youtu.be/AyB3yDuZRTo?t=00h32m18s)

[blah](https://youtu.be/AyB3yDuZRTo?t=00h32m21s)

[that's going to go up the food chain to](https://youtu.be/AyB3yDuZRTo?t=00h32m22s)

[here](https://youtu.be/AyB3yDuZRTo?t=00h32m24s)

[it's going to get the dependency object](https://youtu.be/AyB3yDuZRTo?t=00h32m25s)

[depends the object.no link container to](https://youtu.be/AyB3yDuZRTo?t=00h32m27s)

[item](https://youtu.be/AyB3yDuZRTo?t=00h32m30s)

[Factory realize I'm wondering if it's](https://youtu.be/AyB3yDuZRTo?t=00h32m32s)

[one of these it's going to be in here](https://youtu.be/AyB3yDuZRTo?t=00h32m35s)

[somewhere](https://youtu.be/AyB3yDuZRTo?t=00h32m37s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h32m38s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h32m44s)

[uh yeah sure that's fine](https://youtu.be/AyB3yDuZRTo?t=00h32m45s)

[okay so dependency object is our](https://youtu.be/AyB3yDuZRTo?t=00h32m53s)

[oh](https://youtu.be/AyB3yDuZRTo?t=00h32m58s)

[disable breakpoint disable breakpoint](https://youtu.be/AyB3yDuZRTo?t=00h32m59s)

[continue](https://youtu.be/AyB3yDuZRTo?t=00h33m02s)

[uh re-enable breakpoints continue](https://youtu.be/AyB3yDuZRTo?t=00h33m06s)

[continue okay](https://youtu.be/AyB3yDuZRTo?t=00h33m10s)

[the dependency object is our tree list](https://youtu.be/AyB3yDuZRTo?t=00h33m13s)

[view item great](https://youtu.be/AyB3yDuZRTo?t=00h33m15s)

[our object is our movie category step on](https://youtu.be/AyB3yDuZRTo?t=00h33m16s)

[in](https://youtu.be/AyB3yDuZRTo?t=00h33m20s)

[okay so we clear item container set item](https://youtu.be/AyB3yDuZRTo?t=00h33m22s)

[container property](https://youtu.be/AyB3yDuZRTo?t=00h33m26s)

[so it just holds around it sets the data](https://youtu.be/AyB3yDuZRTo?t=00h33m28s)

[context in](https://youtu.be/AyB3yDuZRTo?t=00h33m31s)

[Factory realize](https://youtu.be/AyB3yDuZRTo?t=00h33m34s)

[uh this is going to be all the data](https://youtu.be/AyB3yDuZRTo?t=00h33m37s)

[virtualization bits isn't it](https://youtu.be/AyB3yDuZRTo?t=00h33m39s)

[I love the hard-coded 16.](https://youtu.be/AyB3yDuZRTo?t=00h33m43s)

[yeah so that's not quite what we're](https://youtu.be/AyB3yDuZRTo?t=00h33m47s)

[looking for set alternation index](https://youtu.be/AyB3yDuZRTo?t=00h33m50s)

[um so where did the data template come](https://youtu.be/AyB3yDuZRTo?t=00h33m59s)

[into play](https://youtu.be/AyB3yDuZRTo?t=00h34m02s)

[or did it even come into play](https://youtu.be/AyB3yDuZRTo?t=00h34m03s)

[it might not have come into play did it](https://youtu.be/AyB3yDuZRTo?t=00h34m07s)

[because hierarchical data template](https://youtu.be/AyB3yDuZRTo?t=00h34m10s)

[derives from](https://youtu.be/AyB3yDuZRTo?t=00h34m13s)

[data template](https://youtu.be/AyB3yDuZRTo?t=00h34m16s)

[doesn't it](https://youtu.be/AyB3yDuZRTo?t=00h34m18s)

[which it does so even though it's](https://youtu.be/AyB3yDuZRTo?t=00h34m21s)

[landing on it](https://youtu.be/AyB3yDuZRTo?t=00h34m25s)

[the end of the day it doesn't matter](https://youtu.be/AyB3yDuZRTo?t=00h34m28s)

[it doesn't matter because](https://youtu.be/AyB3yDuZRTo?t=00h34m37s)

[in our usage](https://youtu.be/AyB3yDuZRTo?t=00h34m41s)

[it's treating this like a regular data](https://youtu.be/AyB3yDuZRTo?t=00h34m45s)

[template and building this up here](https://youtu.be/AyB3yDuZRTo?t=00h34m47s)

[because it's getting Tree View item](https://youtu.be/AyB3yDuZRTo?t=00h34m54s)

[and setting the data template on it](https://youtu.be/AyB3yDuZRTo?t=00h34m58s)

[somewhere after the tribute item's been](https://youtu.be/AyB3yDuZRTo?t=00h35m00s)

[built](https://youtu.be/AyB3yDuZRTo?t=00h35m03s)

[and I wanted earlier than that no I'm](https://youtu.be/AyB3yDuZRTo?t=00h35m05s)

[okay with later](https://youtu.be/AyB3yDuZRTo?t=00h35m09s)

[because if I have the tree view item](https://youtu.be/AyB3yDuZRTo?t=00h35m10s)

[oh oh oh oh oh oh oh oh I'm an idiot I'm](https://youtu.be/AyB3yDuZRTo?t=00h35m15s)

[an idiot](https://youtu.be/AyB3yDuZRTo?t=00h35m19s)

[right okay so](https://youtu.be/AyB3yDuZRTo?t=00h35m21s)

[let's turn these off for a moment](https://youtu.be/AyB3yDuZRTo?t=00h35m24s)

[um](https://youtu.be/AyB3yDuZRTo?t=00h35m27s)

[if we catch it here we've already got](https://youtu.be/AyB3yDuZRTo?t=00h35m31s)

[the item we just check and see if he has](https://youtu.be/AyB3yDuZRTo?t=00h35m33s)

[it because it should be assigned onto](https://youtu.be/AyB3yDuZRTo?t=00h35m36s)

[here](https://youtu.be/AyB3yDuZRTo?t=00h35m38s)

[right](https://youtu.be/AyB3yDuZRTo?t=00h35m40s)

[you exist show me](https://youtu.be/AyB3yDuZRTo?t=00h35m44s)

[uh uh](https://youtu.be/AyB3yDuZRTo?t=00h35m47s)

[content template uh](https://youtu.be/AyB3yDuZRTo?t=00h35m51s)

[yeah so the data context is set](https://youtu.be/AyB3yDuZRTo?t=00h36m00s)

[what is your template](https://youtu.be/AyB3yDuZRTo?t=00h36m15s)

[child names](https://youtu.be/AyB3yDuZRTo?t=00h36m26s)

[so that's the control template](https://youtu.be/AyB3yDuZRTo?t=00h36m34s)

[template internal](https://youtu.be/AyB3yDuZRTo?t=00h36m37s)

[they're not a](https://youtu.be/AyB3yDuZRTo?t=00h36m41s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h36m48s)

[content template but content template](https://youtu.be/AyB3yDuZRTo?t=00h36m53s)

[was no](https://youtu.be/AyB3yDuZRTo?t=00h36m56s)

[when would but the content of here is](https://youtu.be/AyB3yDuZRTo?t=00h37m03s)

[assigned right](https://youtu.be/AyB3yDuZRTo?t=00h37m06s)

[content](https://youtu.be/AyB3yDuZRTo?t=00h37m11s)

[the content contains that and it is and](https://youtu.be/AyB3yDuZRTo?t=00h37m16s)

[it then looks up the template](https://youtu.be/AyB3yDuZRTo?t=00h37m20s)

[implicitly](https://youtu.be/AyB3yDuZRTo?t=00h37m23s)

[the problem is is I want to look at the](https://youtu.be/AyB3yDuZRTo?t=00h37m27s)

[template that got applied to the content](https://youtu.be/AyB3yDuZRTo?t=00h37m30s)

[but that's being applied somewhere else](https://youtu.be/AyB3yDuZRTo?t=00h37m33s)

[and that's being applied somewhere I](https://youtu.be/AyB3yDuZRTo?t=00h37m41s)

[won't know about](https://youtu.be/AyB3yDuZRTo?t=00h37m43s)

[uh content is item interesting](https://youtu.be/AyB3yDuZRTo?t=00h37m47s)

[so how do I get at it](https://youtu.be/AyB3yDuZRTo?t=00h37m52s)

[okay we're gonna bet we're gonna before](https://youtu.be/AyB3yDuZRTo?t=00h37m55s)

[before I get too carried away](https://youtu.be/AyB3yDuZRTo?t=00h37m57s)

[WPF preview](https://youtu.be/AyB3yDuZRTo?t=00h37m59s)

[let me just do that backwards list View](https://youtu.be/AyB3yDuZRTo?t=00h38m04s)

[as let's let's go take a little](https://youtu.be/AyB3yDuZRTo?t=00h38m07s)

[inspiration](https://youtu.be/AyB3yDuZRTo?t=00h38m10s)

[uh uh let's see](https://youtu.be/AyB3yDuZRTo?t=00h38m12s)

[yeah no we're not doing that uh](https://youtu.be/AyB3yDuZRTo?t=00h38m21s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h38m24s)

[yeah this is one that I've seen before](https://youtu.be/AyB3yDuZRTo?t=00h38m30s)

[this is effectively the same thing](https://youtu.be/AyB3yDuZRTo?t=00h38m33s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h38m36s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h38m45s)

[because this is kind of the ideas we](https://youtu.be/AyB3yDuZRTo?t=00h38m47s)

[derive from Tree View we override the](https://youtu.be/AyB3yDuZRTo?t=00h38m49s)

[container tree list item](https://youtu.be/AyB3yDuZRTo?t=00h38m51s)

[we do our own collection](https://youtu.be/AyB3yDuZRTo?t=00h38m53s)

[let's see insert ad doing doing the need](https://youtu.be/AyB3yDuZRTo?t=00h38m58s)

[fold there](https://youtu.be/AyB3yDuZRTo?t=00h39m01s)

[we create a tree node which stores it](https://youtu.be/AyB3yDuZRTo?t=00h39m07s)

[says selected is expanded yep yep yep](https://youtu.be/AyB3yDuZRTo?t=00h39m09s)

[show me your code](https://youtu.be/AyB3yDuZRTo?t=00h39m13s)

[show me your code](https://youtu.be/AyB3yDuZRTo?t=00h39m16s)

[file download](https://youtu.be/AyB3yDuZRTo?t=00h39m19s)

[excellent](https://youtu.be/AyB3yDuZRTo?t=00h39m21s)

[one moment](https://youtu.be/AyB3yDuZRTo?t=00h39m27s)

[while I get it](https://youtu.be/AyB3yDuZRTo?t=00h39m28s)

[not where it currently is](https://youtu.be/AyB3yDuZRTo?t=00h39m30s)

[comma correct](https://youtu.be/AyB3yDuZRTo?t=00h39m35s)

[okay](https://youtu.be/AyB3yDuZRTo?t=00h39m38s)

[so we're going to open this with](https://youtu.be/AyB3yDuZRTo?t=00h39m40s)

[we're gonna just open and code because](https://youtu.be/AyB3yDuZRTo?t=00h39m45s)

[I'm just looking at how old the solution](https://youtu.be/AyB3yDuZRTo?t=00h39m47s)

[file is](https://youtu.be/AyB3yDuZRTo?t=00h39m49s)

[we're not going to try](https://youtu.be/AyB3yDuZRTo?t=00h39m51s)

[we are not going to try so unit tests I](https://youtu.be/AyB3yDuZRTo?t=00h39m52s)

[approve](https://youtu.be/AyB3yDuZRTo?t=00h39m55s)

[tree](https://youtu.be/AyB3yDuZRTo?t=00h39m56s)

[all right so tree list](https://youtu.be/AyB3yDuZRTo?t=00h39m58s)

[I tree model](https://youtu.be/AyB3yDuZRTo?t=00h40m04s)

[yuck](https://youtu.be/AyB3yDuZRTo?t=00h40m07s)

[not a fan of this](https://youtu.be/AyB3yDuZRTo?t=00h40m11s)

[not a fan of that at all](https://youtu.be/AyB3yDuZRTo?t=00h40m14s)

[tree nodes](https://youtu.be/AyB3yDuZRTo?t=00h40m19s)

[pending Focus node selected nodes I mean](https://youtu.be/AyB3yDuZRTo?t=00h40m22s)

[this is kind of what I was thinking but](https://youtu.be/AyB3yDuZRTo?t=00h40m25s)

[yuck](https://youtu.be/AyB3yDuZRTo?t=00h40m27s)

[item container generator](https://youtu.be/AyB3yDuZRTo?t=00h40m28s)

[so on the so he watches the item](https://youtu.be/AyB3yDuZRTo?t=00h40m36s)

[container generator for status change to](https://youtu.be/AyB3yDuZRTo?t=00h40m39s)

[be able to call focus on it and use this](https://youtu.be/AyB3yDuZRTo?t=00h40m42s)

[as a cache](https://youtu.be/AyB3yDuZRTo?t=00h40m44s)

[okay prepare item](https://youtu.be/AyB3yDuZRTo?t=00h40m46s)

[do not like that item has to implement a](https://youtu.be/AyB3yDuZRTo?t=00h40m50s)

[particular tree node that seems very](https://youtu.be/AyB3yDuZRTo?t=00h40m53s)

[yucky to me this is one of the things](https://youtu.be/AyB3yDuZRTo?t=00h40m55s)

[that I really don't like is custom](https://youtu.be/AyB3yDuZRTo?t=00h40m57s)

[controls that make assumptions on mvvm](https://youtu.be/AyB3yDuZRTo?t=00h40m59s)

[and face types and oh you can bind](https://youtu.be/AyB3yDuZRTo?t=00h41m02s)

[anything you want in here as long as](https://youtu.be/AyB3yDuZRTo?t=00h41m05s)

[your type implements you know insert](https://youtu.be/AyB3yDuZRTo?t=00h41m06s)

[interface here or similar which that's](https://youtu.be/AyB3yDuZRTo?t=00h41m08s)

[always a possibility but what if you](https://youtu.be/AyB3yDuZRTo?t=00h41m11s)

[don't control the type then you have to](https://youtu.be/AyB3yDuZRTo?t=00h41m13s)

[wrap it blah blah it's just yucky](https://youtu.be/AyB3yDuZRTo?t=00h41m14s)

[don't like it](https://youtu.be/AyB3yDuZRTo?t=00h41m17s)

[um](https://youtu.be/AyB3yDuZRTo?t=00h41m19s)

[insert item it has to have its own](https://youtu.be/AyB3yDuZRTo?t=00h41m23s)

[property changed implementation children](https://youtu.be/AyB3yDuZRTo?t=00h41m25s)

[source which now needs to have it set up](https://youtu.be/AyB3yDuZRTo?t=00h41m28s)

[this](https://youtu.be/AyB3yDuZRTo?t=00h41m32s)

[is awkward](https://youtu.be/AyB3yDuZRTo?t=00h41m35s)

[yeah I mean this is kind of what I was](https://youtu.be/AyB3yDuZRTo?t=00h41m38s)

[going for but not](https://youtu.be/AyB3yDuZRTo?t=00h41m40s)

[not like I don't I I want to drop the](https://youtu.be/AyB3yDuZRTo?t=00h41m44s)

[tree node](https://youtu.be/AyB3yDuZRTo?t=00h41m47s)

[and so his way of working around is this](https://youtu.be/AyB3yDuZRTo?t=00h41m48s)

[I tree model to be able to know](https://youtu.be/AyB3yDuZRTo?t=00h41m51s)

[what children come from where](https://youtu.be/AyB3yDuZRTo?t=00h41m53s)

[level to indent converter which sure](https://youtu.be/AyB3yDuZRTo?t=00h41m57s)

[yeah we're gonna end up doing something](https://youtu.be/AyB3yDuZRTo?t=00h41m59s)

[similar to that](https://youtu.be/AyB3yDuZRTo?t=00h42m00s)

[that's fine](https://youtu.be/AyB3yDuZRTo?t=00h42m02s)

[does all that sure great](https://youtu.be/AyB3yDuZRTo?t=00h42m06s)

[um](https://youtu.be/AyB3yDuZRTo?t=00h42m10s)

[I mean it works but yuck](https://youtu.be/AyB3yDuZRTo?t=00h42m10s)

[yuck](https://youtu.be/AyB3yDuZRTo?t=00h42m13s)

[uh actually what was that one I didn't](https://youtu.be/AyB3yDuZRTo?t=00h42m15s)

[see it](https://youtu.be/AyB3yDuZRTo?t=00h42m17s)

[I have to behavior](https://youtu.be/AyB3yDuZRTo?t=00h42m20s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h42m22s)

[okay](https://youtu.be/AyB3yDuZRTo?t=00h42m26s)

[and it wouldn't be that bad to just](https://youtu.be/AyB3yDuZRTo?t=00h42m29s)

[document something along the lines of](https://youtu.be/AyB3yDuZRTo?t=00h42m31s)

[this is how you have to use it](https://youtu.be/AyB3yDuZRTo?t=00h42m34s)

[but I'd really kind of like it if it](https://youtu.be/AyB3yDuZRTo?t=00h42m38s)

[didn't just suck](https://youtu.be/AyB3yDuZRTo?t=00h42m40s)

[I'd like to be able to intelligently do](https://youtu.be/AyB3yDuZRTo?t=00h42m47s)

[something with it if](https://youtu.be/AyB3yDuZRTo?t=00h42m49s)

[it is a hierarchical data template](https://youtu.be/AyB3yDuZRTo?t=00h42m51s)

[how does treeview handle it](https://youtu.be/AyB3yDuZRTo?t=00h42m55s)

[since it must be doing something](https://youtu.be/AyB3yDuZRTo?t=00h43m00s)

[how do it know](https://youtu.be/AyB3yDuZRTo?t=00h43m03s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=00h43m07s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h43m16s)

[uh hierarchical](https://youtu.be/AyB3yDuZRTo?t=00h43m18s)

[really there's nothing in here it's all](https://youtu.be/AyB3yDuZRTo?t=00h43m20s)

[down in items control is what you're](https://youtu.be/AyB3yDuZRTo?t=00h43m23s)

[telling me](https://youtu.be/AyB3yDuZRTo?t=00h43m24s)

[no](https://youtu.be/AyB3yDuZRTo?t=00h43m29s)

[whoa huh](https://youtu.be/AyB3yDuZRTo?t=00h43m31s)

[how](https://youtu.be/AyB3yDuZRTo?t=00h43m34s)

[huh](https://youtu.be/AyB3yDuZRTo?t=00h43m36s)

[I'm confused](https://youtu.be/AyB3yDuZRTo?t=00h43m39s)

[how does it do it](https://youtu.be/AyB3yDuZRTo?t=00h43m41s)

[because we looked at selection but we](https://youtu.be/AyB3yDuZRTo?t=00h43m44s)

[didn't look at](https://youtu.be/AyB3yDuZRTo?t=00h43m46s)

[how it gets its values](https://youtu.be/AyB3yDuZRTo?t=00h43m48s)

[get container for item yeah](https://youtu.be/AyB3yDuZRTo?t=00h43m54s)

[an items changed](https://youtu.be/AyB3yDuZRTo?t=00h43m57s)

[how does it do the switch](https://youtu.be/AyB3yDuZRTo?t=00h44m03s)

[how is hierarchical data template](https://youtu.be/AyB3yDuZRTo?t=00h44m06s)

[implemented okay I know last time we](https://youtu.be/AyB3yDuZRTo?t=00h44m09s)

[opened up WPF](https://youtu.be/AyB3yDuZRTo?t=00h44m11s)

[or WPF solution](https://youtu.be/AyB3yDuZRTo?t=00h44m14s)

[why don't I see my WPF clone](https://youtu.be/AyB3yDuZRTo?t=00h44m18s)

[no I've got one I know I've got one I](https://youtu.be/AyB3yDuZRTo?t=00h44m21s)

[know we've cloned WPF](https://youtu.be/AyB3yDuZRTo?t=00h44m24s)

[where are you we're gonna go find out](https://youtu.be/AyB3yDuZRTo?t=00h44m26s)

[time to go Splunk the deep dark depths](https://youtu.be/AyB3yDuZRTo?t=00h44m29s)

[of WPF](https://youtu.be/AyB3yDuZRTo?t=00h44m33s)

[because I would love to understand how](https://youtu.be/AyB3yDuZRTo?t=00h44m36s)

[it gets there](https://youtu.be/AyB3yDuZRTo?t=00h44m39s)

[because it's going through the container](https://youtu.be/AyB3yDuZRTo?t=00h44m42s)

[generator](https://youtu.be/AyB3yDuZRTo?t=00h44m44s)

[but how does it know](https://youtu.be/AyB3yDuZRTo?t=00h44m45s)

[when you have a hierarchical data](https://youtu.be/AyB3yDuZRTo?t=00h44m49s)

[template](https://youtu.be/AyB3yDuZRTo?t=00h44m51s)

[is it trueview item that does something](https://youtu.be/AyB3yDuZRTo?t=00h44m54s)

[I wonder if it's Tree View item that](https://youtu.be/AyB3yDuZRTo?t=00h44m58s)

[does the magic](https://youtu.be/AyB3yDuZRTo?t=00h45m00s)

[maybe it's Tree View item that has the](https://youtu.be/AyB3yDuZRTo?t=00h45m06s)

[magic built into it](https://youtu.be/AyB3yDuZRTo?t=00h45m08s)

[or even headered items control](https://youtu.be/AyB3yDuZRTo?t=00h45m18s)

[foreign](https://youtu.be/AyB3yDuZRTo?t=00h45m29s)

[sizes](https://youtu.be/AyB3yDuZRTo?t=00h45m34s)

[items host](https://youtu.be/AyB3yDuZRTo?t=00h45m41s)

[hierarchical virtualization and scroll](https://youtu.be/AyB3yDuZRTo?t=00h45m43s)

[info](https://youtu.be/AyB3yDuZRTo?t=00h45m46s)

[what is this interface](https://youtu.be/AyB3yDuZRTo?t=00h45m54s)

[public interface constraints](https://youtu.be/AyB3yDuZRTo?t=00h45m57s)

[header desired size item desired sizes](https://youtu.be/AyB3yDuZRTo?t=00h46m00s)

[side size is a control item in device](https://youtu.be/AyB3yDuZRTo?t=00h46m05s)

[independent units and logical units](https://youtu.be/AyB3yDuZRTo?t=00h46m07s)

[items host](https://youtu.be/AyB3yDuZRTo?t=00h46m13s)

[see but this runs a muck of the](https://youtu.be/AyB3yDuZRTo?t=00h46m19s)

[I couldn't implement this interface](https://youtu.be/AyB3yDuZRTo?t=00h46m23s)

[because I](https://youtu.be/AyB3yDuZRTo?t=00h46m25s)

[I don't want it in this particular items](https://youtu.be/AyB3yDuZRTo?t=00h46m31s)

[host](https://youtu.be/AyB3yDuZRTo?t=00h46m34s)

[because I just kind of want to grab them](https://youtu.be/AyB3yDuZRTo?t=00h46m37s)

[so it's got to be here](https://youtu.be/AyB3yDuZRTo?t=00h46m42s)

[yeah it's gotta be in here](https://youtu.be/AyB3yDuZRTo?t=00h46m46s)

[let's just check headed items control](https://youtu.be/AyB3yDuZRTo?t=00h46m48s)

[our hierarchy](https://youtu.be/AyB3yDuZRTo?t=00h46m59s)

[header template](https://youtu.be/AyB3yDuZRTo?t=00h47m01s)

[ah](https://youtu.be/AyB3yDuZRTo?t=00h47m04s)

[there she is there she is headered items](https://youtu.be/AyB3yDuZRTo?t=00h47m07s)

[there it is](https://youtu.be/AyB3yDuZRTo?t=00h47m17s)

[there it is](https://youtu.be/AyB3yDuZRTo?t=00h47m22s)

[headered items control](https://youtu.be/AyB3yDuZRTo?t=00h47m28s)

[so because it derives from headered](https://youtu.be/AyB3yDuZRTo?t=00h47m32s)

[items control](https://youtu.be/AyB3yDuZRTo?t=00h47m34s)

[it then knows something about it](https://youtu.be/AyB3yDuZRTo?t=00h47m37s)

[the problem being we don't want to](https://youtu.be/AyB3yDuZRTo?t=00h47m43s)

[derive from header to items control](https://youtu.be/AyB3yDuZRTo?t=00h47m45s)

[ha ha](https://youtu.be/AyB3yDuZRTo?t=00h47m49s)

[okay okay](https://youtu.be/AyB3yDuZRTo?t=00h47m51s)

[prepared header to items control where](https://youtu.be/AyB3yDuZRTo?t=00h47m54s)

[are you invoked from](https://youtu.be/AyB3yDuZRTo?t=00h47m56s)

[well we've got WPF open let's just go](https://youtu.be/AyB3yDuZRTo?t=00h47m58s)

[look](https://youtu.be/AyB3yDuZRTo?t=00h48m01s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=00h48m02s)

[where headed items control that one show](https://youtu.be/AyB3yDuZRTo?t=00h48m04s)

[me your usages how many are there](https://youtu.be/AyB3yDuZRTo?t=00h48m07s)

[can't be that many right one excellent I](https://youtu.be/AyB3yDuZRTo?t=00h48m12s)

[heard one exactly](https://youtu.be/AyB3yDuZRTo?t=00h48m15s)

[repair container for item override so](https://youtu.be/AyB3yDuZRTo?t=00h48m20s)

[inside of here](https://youtu.be/AyB3yDuZRTo?t=00h48m22s)

[inside of here it casts the item to a](https://youtu.be/AyB3yDuZRTo?t=00h48m26s)

[headered items control because they](https://youtu.be/AyB3yDuZRTo?t=00h48m28s)

[didn't have pattern matching back when](https://youtu.be/AyB3yDuZRTo?t=00h48m30s)

[this existed](https://youtu.be/AyB3yDuZRTo?t=00h48m32s)

[this guy comes in here checks the item](https://youtu.be/AyB3yDuZRTo?t=00h48m33s)

[uh prepare hierarchy](https://youtu.be/AyB3yDuZRTo?t=00h48m38s)

[header is not logical](https://youtu.be/AyB3yDuZRTo?t=00h48m42s)

[repair hierarchy](https://youtu.be/AyB3yDuZRTo?t=00h48m47s)

[hierarchy takes the item](https://youtu.be/AyB3yDuZRTo?t=00h48m49s)

[looks at the header template](https://youtu.be/AyB3yDuZRTo?t=00h48m51s)

[and we would like to grab](https://youtu.be/AyB3yDuZRTo?t=00h48m56s)

[the template for our item](https://youtu.be/AyB3yDuZRTo?t=00h49m01s)

[that is functionally what we want if we](https://youtu.be/AyB3yDuZRTo?t=00h49m08s)

[would like to grab](https://youtu.be/AyB3yDuZRTo?t=00h49m11s)

[because they have header template here](https://youtu.be/AyB3yDuZRTo?t=00h49m17s)

[we want the same thing wait find](https://youtu.be/AyB3yDuZRTo?t=00h49m20s)

[template resource internal](https://youtu.be/AyB3yDuZRTo?t=00h49m24s)

[wait you're telling me there's a method](https://youtu.be/AyB3yDuZRTo?t=00h49m29s)

[for this](https://youtu.be/AyB3yDuZRTo?t=00h49m31s)

[searches for data](https://youtu.be/AyB3yDuZRTo?t=00h49m35s)

[well well well well well this is exactly](https://youtu.be/AyB3yDuZRTo?t=00h49m43s)

[what I want](https://youtu.be/AyB3yDuZRTo?t=00h49m46s)

[you jerk](https://youtu.be/AyB3yDuZRTo?t=00h49m54s)

[you jerk](https://youtu.be/AyB3yDuZRTo?t=00h49m58s)

[you have hidden it away](https://youtu.be/AyB3yDuZRTo?t=00h50m01s)

[is there not a way I can get to here](https://youtu.be/AyB3yDuZRTo?t=00h50m06s)

[I want to see if there's a way I can get](https://youtu.be/AyB3yDuZRTo?t=00h50m11s)

[to here](https://youtu.be/AyB3yDuZRTo?t=00h50m13s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h50m15s)

[um](https://youtu.be/AyB3yDuZRTo?t=00h50m16s)

[yuck man I want to find a way into this](https://youtu.be/AyB3yDuZRTo?t=00h50m18s)

[hang on](https://youtu.be/AyB3yDuZRTo?t=00h50m21s)

[repair hierarchy that's way too nested](https://youtu.be/AyB3yDuZRTo?t=00h50m24s)

[uh that's where we came from](https://youtu.be/AyB3yDuZRTo?t=00h50m27s)

[default selector](https://youtu.be/AyB3yDuZRTo?t=00h50m31s)

[default template selector where do you](https://youtu.be/AyB3yDuZRTo?t=00h50m36s)

[come from](https://youtu.be/AyB3yDuZRTo?t=00h50m39s)

[content presenter](https://youtu.be/AyB3yDuZRTo?t=00h50m41s)

[default selector so if I can get a hold](https://youtu.be/AyB3yDuZRTo?t=00h50m43s)

[of default selector](https://youtu.be/AyB3yDuZRTo?t=00h50m46s)

[I can use you where do you get applied](https://youtu.be/AyB3yDuZRTo?t=00h50m48s)

[where do you go](https://youtu.be/AyB3yDuZRTo?t=00h50m53s)

[uh static default template selector](https://youtu.be/AyB3yDuZRTo?t=00h50m57s)

[of course you're private](https://youtu.be/AyB3yDuZRTo?t=00h51m01s)

[you suck](https://youtu.be/AyB3yDuZRTo?t=00h51m02s)

[choose template](https://youtu.be/AyB3yDuZRTo?t=00h51m07s)

[got it okay so this guy here](https://youtu.be/AyB3yDuZRTo?t=00h51m11s)

[this looks like an entry point this](https://youtu.be/AyB3yDuZRTo?t=00h51m16s)

[looks like an entry point](https://youtu.be/AyB3yDuZRTo?t=00h51m19s)

[what are we inside of content presenter](https://youtu.be/AyB3yDuZRTo?t=00h51m21s)

[foreign](https://youtu.be/AyB3yDuZRTo?t=00h51m26s)

[so inside of content presenter we can](https://youtu.be/AyB3yDuZRTo?t=00h51m30s)

[we can get a hold of it](https://youtu.be/AyB3yDuZRTo?t=00h51m34s)

[so given a Content presenter that's](https://youtu.be/AyB3yDuZRTo?t=00h51m37s)

[added to the virtual tree](https://youtu.be/AyB3yDuZRTo?t=00h51m40s)

[we can find the](https://youtu.be/AyB3yDuZRTo?t=00h51m43s)

[we can find his template](https://youtu.be/AyB3yDuZRTo?t=00h51m49s)

[excellente](https://youtu.be/AyB3yDuZRTo?t=00h51m53s)

[okay okay so come back here](https://youtu.be/AyB3yDuZRTo?t=00h51m56s)

[continue yeah stop](https://youtu.be/AyB3yDuZRTo?t=00h51m59s)

[uh go ahead and kill that execution](https://youtu.be/AyB3yDuZRTo?t=00h52m02s)

[okay so we can get into here](https://youtu.be/AyB3yDuZRTo?t=00h52m07s)

[so let's kill this](https://youtu.be/AyB3yDuZRTo?t=00h52m10s)

[and I think what we want to do is we](https://youtu.be/AyB3yDuZRTo?t=00h52m12s)

[want to look at this from snoop's](https://youtu.be/AyB3yDuZRTo?t=00h52m14s)

[perspective because I think where we](https://youtu.be/AyB3yDuZRTo?t=00h52m16s)

[want to grab this is nested down a](https://youtu.be/AyB3yDuZRTo?t=00h52m18s)

[little bit](https://youtu.be/AyB3yDuZRTo?t=00h52m19s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h52m21s)

[okay](https://youtu.be/AyB3yDuZRTo?t=00h52m27s)

[because content presenter can do it](https://youtu.be/AyB3yDuZRTo?t=00h52m29s)

[content presenter exists inside of our](https://youtu.be/AyB3yDuZRTo?t=00h52m32s)

[code](https://youtu.be/AyB3yDuZRTo?t=00h52m35s)

[uh inside of](https://youtu.be/AyB3yDuZRTo?t=00h52m36s)

[well it's it's somewhat deeply nested](https://youtu.be/AyB3yDuZRTo?t=00h52m39s)

[but it's right here](https://youtu.be/AyB3yDuZRTo?t=00h52m42s)

[this is what I want to look at because](https://youtu.be/AyB3yDuZRTo?t=00h52m43s)

[I'm willing to bet I'm willing to bet if](https://youtu.be/AyB3yDuZRTo?t=00h52m45s)

[I look at the content presenter that is](https://youtu.be/AyB3yDuZRTo?t=00h52m47s)

[deeply nested inside of this guy he will](https://youtu.be/AyB3yDuZRTo?t=00h52m49s)

[have access to the data template that I](https://youtu.be/AyB3yDuZRTo?t=00h52m51s)

[seek](https://youtu.be/AyB3yDuZRTo?t=00h52m53s)

[that is the theory](https://youtu.be/AyB3yDuZRTo?t=00h52m56s)

[that's what we're operating under at the](https://youtu.be/AyB3yDuZRTo?t=00h52m58s)

[moment okay so if we come into here](https://youtu.be/AyB3yDuZRTo?t=00h52m59s)

[there's the content presenter](https://youtu.be/AyB3yDuZRTo?t=00h53m03s)

[show it to me](https://youtu.be/AyB3yDuZRTo?t=00h53m07s)

[the content presenter](https://youtu.be/AyB3yDuZRTo?t=00h53m20s)

[content template is null](https://youtu.be/AyB3yDuZRTo?t=00h53m23s)

[it's not just defaulting to](https://youtu.be/AyB3yDuZRTo?t=00h53m26s)

[right this isn't being dumb and doing](https://youtu.be/AyB3yDuZRTo?t=00h53m32s)

[something](https://youtu.be/AyB3yDuZRTo?t=00h53m34s)

[no 3232 so it is landing on ours but it](https://youtu.be/AyB3yDuZRTo?t=00h53m38s)

[doesn't show](https://youtu.be/AyB3yDuZRTo?t=00h53m42s)

[find](https://youtu.be/AyB3yDuZRTo?t=00h53m52s)

[so what does it do when it finds the](https://youtu.be/AyB3yDuZRTo?t=00h53m55s)

[data template](https://youtu.be/AyB3yDuZRTo?t=00h53m57s)

[uh uh](https://youtu.be/AyB3yDuZRTo?t=00h54m05s)

[find data template](https://youtu.be/AyB3yDuZRTo?t=00h54m08s)

[this guy what does it do with it](https://youtu.be/AyB3yDuZRTo?t=00h54m14s)

[finds the data template](https://youtu.be/AyB3yDuZRTo?t=00h54m19s)

[takes the den template this is a](https://youtu.be/AyB3yDuZRTo?t=00h54m22s)

[template selector](https://youtu.be/AyB3yDuZRTo?t=00h54m25s)

[and so we were following that through](https://youtu.be/AyB3yDuZRTo?t=00h54m27s)

[here](https://youtu.be/AyB3yDuZRTo?t=00h54m31s)

[and we want to find where the default](https://youtu.be/AyB3yDuZRTo?t=00h54m34s)

[template selector gets used](https://youtu.be/AyB3yDuZRTo?t=00h54m36s)

[default template selector is only used](https://youtu.be/AyB3yDuZRTo?t=00h54m39s)

[in one place to select the template](https://youtu.be/AyB3yDuZRTo?t=00h54m41s)

[comes into here to choose template](https://youtu.be/AyB3yDuZRTo?t=00h54m44s)

[choose template is virtual](https://youtu.be/AyB3yDuZRTo?t=00h54m47s)

[reevaluate template](https://youtu.be/AyB3yDuZRTo?t=00h54m54s)

[so the template should be so the](https://youtu.be/AyB3yDuZRTo?t=00h55m01s)

[template property should be getting](https://youtu.be/AyB3yDuZRTo?t=00h55m03s)

[applied](https://youtu.be/AyB3yDuZRTo?t=00h55m04s)

[to the content presenter if this is](https://youtu.be/AyB3yDuZRTo?t=00h55m07s)

[where we are hitting](https://youtu.be/AyB3yDuZRTo?t=00h55m09s)

[what I don't understand is when we look](https://youtu.be/AyB3yDuZRTo?t=00h55m14s)

[at this](https://youtu.be/AyB3yDuZRTo?t=00h55m17s)

[oh the template property isn't being](https://youtu.be/AyB3yDuZRTo?t=00h55m22s)

[shown here](https://youtu.be/AyB3yDuZRTo?t=00h55m24s)

[why aren't you being shown here there's](https://youtu.be/AyB3yDuZRTo?t=00h55m28s)

[templated parent](https://youtu.be/AyB3yDuZRTo?t=00h55m32s)

[content presenter template what do you](https://youtu.be/AyB3yDuZRTo?t=00h55m36s)

[you're private oh you](https://youtu.be/AyB3yDuZRTo?t=00h55m39s)

[ah](https://youtu.be/AyB3yDuZRTo?t=00h55m42s)

[you suck](https://youtu.be/AyB3yDuZRTo?t=00h55m45s)

[on template changed](https://youtu.be/AyB3yDuZRTo?t=00h55m50s)

[you you're all all the good stuff's](https://youtu.be/AyB3yDuZRTo?t=00h55m52s)

[internal](https://youtu.be/AyB3yDuZRTo?t=00h55m55s)

[all the good stuff's inter protected](https://youtu.be/AyB3yDuZRTo?t=00h55m56s)

[virtual](https://youtu.be/AyB3yDuZRTo?t=00h55m58s)

[man this is going to get abusive fast](https://youtu.be/AyB3yDuZRTo?t=00h56m05s)

[okay we're doing it](https://youtu.be/AyB3yDuZRTo?t=00h56m07s)

[we're doing it because I don't see](https://youtu.be/AyB3yDuZRTo?t=00h56m09s)

[another good way](https://youtu.be/AyB3yDuZRTo?t=00h56m12s)

[this is way too much work okay this is](https://youtu.be/AyB3yDuZRTo?t=00h56m14s)

[all about learning WPF tree list view](https://youtu.be/AyB3yDuZRTo?t=00h56m18s)

[item content is enter because you made](https://youtu.be/AyB3yDuZRTo?t=00h56m21s)

[everything internal](https://youtu.be/AyB3yDuZRTo?t=00h56m25s)

[very few paths in](https://youtu.be/AyB3yDuZRTo?t=00h56m28s)

[we may have found](https://youtu.be/AyB3yDuZRTo?t=00h56m31s)

[derived from content presenter and then](https://youtu.be/AyB3yDuZRTo?t=00h56m34s)

[we want to override template](https://youtu.be/AyB3yDuZRTo?t=00h56m37s)

[on content template changed](https://youtu.be/AyB3yDuZRTo?t=00h56m41s)

[was it](https://youtu.be/AyB3yDuZRTo?t=00h56m45s)

[I think it was content template changed](https://youtu.be/AyB3yDuZRTo?t=00h56m48s)

[is the one that we want](https://youtu.be/AyB3yDuZRTo?t=00h56m50s)

[I don't know that for a fact though I](https://youtu.be/AyB3yDuZRTo?t=00h56m51s)

[can't remember](https://youtu.be/AyB3yDuZRTo?t=00h56m53s)

[what body show me](https://youtu.be/AyB3yDuZRTo?t=00h56m55s)

[oh did I close where I was at probably](https://youtu.be/AyB3yDuZRTo?t=00h57m00s)

[okay well what we're going to do is](https://youtu.be/AyB3yDuZRTo?t=00h57m04s)

[we're just going to grab this sucker](https://youtu.be/AyB3yDuZRTo?t=00h57m06s)

[here](https://youtu.be/AyB3yDuZRTo?t=00h57m08s)

[override](https://youtu.be/AyB3yDuZRTo?t=00h57m09s)

[template](https://youtu.be/AyB3yDuZRTo?t=00h57m11s)

[on template chain](https://youtu.be/AyB3yDuZRTo?t=00h57m14s)

[I'm just going to grab them both and](https://youtu.be/AyB3yDuZRTo?t=00h57m16s)

[then we are going to see which one of](https://youtu.be/AyB3yDuZRTo?t=00h57m18s)

[you suckers fires with what I want](https://youtu.be/AyB3yDuZRTo?t=00h57m20s)

[and then I want to go here and then](https://youtu.be/AyB3yDuZRTo?t=00h57m23s)

[inside of my](https://youtu.be/AyB3yDuZRTo?t=00h57m26s)

[thing here I want to go with uh](https://youtu.be/AyB3yDuZRTo?t=00h57m29s)

[WPF](https://youtu.be/AyB3yDuZRTo?t=00h57m33s)

[boom](https://youtu.be/AyB3yDuZRTo?t=00h57m35s)

[now we hook it](https://youtu.be/AyB3yDuZRTo?t=00h57m39s)

[okay so if we swap out the content](https://youtu.be/AyB3yDuZRTo?t=00h57m43s)

[presenter inside of our tree view item](https://youtu.be/AyB3yDuZRTo?t=00h57m46s)

[template](https://youtu.be/AyB3yDuZRTo?t=00h57m48s)

[I think we can get a hold of](https://youtu.be/AyB3yDuZRTo?t=00h57m49s)

[the template as it comes in Old template](https://youtu.be/AyB3yDuZRTo?t=00h57m54s)

[hierarchical data template boo](https://youtu.be/AyB3yDuZRTo?t=00h57m58s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=00h58m01s)

[that's what I'm talking about](https://youtu.be/AyB3yDuZRTo?t=00h58m07s)

[there we go okay](https://youtu.be/AyB3yDuZRTo?t=00h58m16s)

[Okay so](https://youtu.be/AyB3yDuZRTo?t=00h58m18s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h58m20s)

[uh control](https://youtu.be/AyB3yDuZRTo?t=00h58m22s)

[uh what is it](https://youtu.be/AyB3yDuZRTo?t=00h58m26s)

[no template part that's what it is so uh](https://youtu.be/AyB3yDuZRTo?t=00h58m30s)

[name is going to be](https://youtu.be/AyB3yDuZRTo?t=00h58m35s)

[because we we want to Define what is a](https://youtu.be/AyB3yDuZRTo?t=00h58m37s)

[requirement for our template and in](https://youtu.be/AyB3yDuZRTo?t=00h58m40s)

[order for this thing to work we need](https://youtu.be/AyB3yDuZRTo?t=00h58m42s)

[that](https://youtu.be/AyB3yDuZRTo?t=00h58m44s)

[and we need it to be of type](https://youtu.be/AyB3yDuZRTo?t=00h58m45s)

[type of](https://youtu.be/AyB3yDuZRTo?t=00h58m48s)

[because we're going to be real specific](https://youtu.be/AyB3yDuZRTo?t=00h58m50s)

[here boom okay](https://youtu.be/AyB3yDuZRTo?t=00h58m52s)

[next thing we're going to do](https://youtu.be/AyB3yDuZRTo?t=00h58m54s)

[uh](https://youtu.be/AyB3yDuZRTo?t=00h58m56s)

[uh public](https://youtu.be/AyB3yDuZRTo?t=00h58m59s)

[data template template because you darn](https://youtu.be/AyB3yDuZRTo?t=00h59m00s)

[it made it hidden](https://youtu.be/AyB3yDuZRTo?t=00h59m04s)

[all right and that shouldn't be a](https://youtu.be/AyB3yDuZRTo?t=00h59m09s)

[problem](https://youtu.be/AyB3yDuZRTo?t=00h59m12s)

[and then](https://youtu.be/AyB3yDuZRTo?t=00h59m12s)

[template gets new template](https://youtu.be/AyB3yDuZRTo?t=00h59m14s)

[boom we'll let that we'll let the bass](https://youtu.be/AyB3yDuZRTo?t=00h59m17s)

[go through first there we go okay](https://youtu.be/AyB3yDuZRTo?t=00h59m19s)

[now we've got that now we've got that](https://youtu.be/AyB3yDuZRTo?t=00h59m23s)

[cached now we come down here we go](https://youtu.be/AyB3yDuZRTo?t=00h59m25s)

[override on apply template](https://youtu.be/AyB3yDuZRTo?t=00h59m28s)

[thank you very much](https://youtu.be/AyB3yDuZRTo?t=00h59m32s)

[and then we are going to say after this](https://youtu.be/AyB3yDuZRTo?t=00h59m35s)

[comes through we want to be](https://youtu.be/AyB3yDuZRTo?t=00h59m38s)

[thank you co-pilot](https://youtu.be/AyB3yDuZRTo?t=00h59m43s)

[that's not quite right but you're close](https://youtu.be/AyB3yDuZRTo?t=00h59m47s)

[enough](https://youtu.be/AyB3yDuZRTo?t=00h59m49s)

[um](https://youtu.be/AyB3yDuZRTo?t=00h59m51s)

[we want to be able to grab our](https://youtu.be/AyB3yDuZRTo?t=00h59m54s)

[uh content presenter and hold on to him](https://youtu.be/AyB3yDuZRTo?t=00h59m58s)

[so](https://youtu.be/AyB3yDuZRTo?t=01h00m01s)

[private](https://youtu.be/AyB3yDuZRTo?t=01h00m02s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h00m05s)

[let's see](https://youtu.be/AyB3yDuZRTo?t=01h00m09s)

[content uh](https://youtu.be/AyB3yDuZRTo?t=01h00m11s)

[we](https://youtu.be/AyB3yDuZRTo?t=01h00m14s)

[presenter wow okay Mountain Dew](https://youtu.be/AyB3yDuZRTo?t=01h00m16s)

[oh boy okay cannot type cannot spell](https://youtu.be/AyB3yDuZRTo?t=01h00m21s)

[uh we're gonna do this we're gonna say](https://youtu.be/AyB3yDuZRTo?t=01h00m26s)

[thank you you got pretty close copilot](https://youtu.be/AyB3yDuZRTo?t=01h00m29s)

[but no](https://youtu.be/AyB3yDuZRTo?t=01h00m31s)

[not quite what we were going for](https://youtu.be/AyB3yDuZRTo?t=01h00m32s)

[do that okay so now we've got our](https://youtu.be/AyB3yDuZRTo?t=01h00m36s)

[content presenter our content presenter](https://youtu.be/AyB3yDuZRTo?t=01h00m39s)

[will get us access](https://youtu.be/AyB3yDuZRTo?t=01h00m40s)

[to our data template our data template](https://youtu.be/AyB3yDuZRTo?t=01h00m44s)

[we can cast to a hierarchical data plate](https://youtu.be/AyB3yDuZRTo?t=01h00m47s)

[template which gives us our items that](https://youtu.be/AyB3yDuZRTo?t=01h00m49s)

[we can use to get our children yes](https://youtu.be/AyB3yDuZRTo?t=01h00m51s)

[this is what we](https://youtu.be/AyB3yDuZRTo?t=01h00m55s)

[this is what we want okay](https://youtu.be/AyB3yDuZRTo?t=01h00m56s)

[uh public uh](https://youtu.be/AyB3yDuZRTo?t=01h01m02s)

[uh I numerable of objects nullable](https://youtu.be/AyB3yDuZRTo?t=01h01m05s)

[because there's no guarantees of](https://youtu.be/AyB3yDuZRTo?t=01h01m10s)

[anything yet a child Oren](https://youtu.be/AyB3yDuZRTo?t=01h01m11s)

[Okay so](https://youtu.be/AyB3yDuZRTo?t=01h01m15s)

[prerequisites here if uh uh let's see](https://youtu.be/AyB3yDuZRTo?t=01h01m18s)

[here](https://youtu.be/AyB3yDuZRTo?t=01h01m22s)

[so we want content presenter is](https://youtu.be/AyB3yDuZRTo?t=01h01m23s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h01m27s)

[no copilot you are completely and](https://youtu.be/AyB3yDuZRTo?t=01h01m30s)

[utterly wrong go away](https://youtu.be/AyB3yDuZRTo?t=01h01m32s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h01m35s)

[and actually we don't even care about](https://youtu.be/AyB3yDuZRTo?t=01h01m37s)

[the content presenter what we really](https://youtu.be/AyB3yDuZRTo?t=01h01m39s)

[want to grab out of it is it's template](https://youtu.be/AyB3yDuZRTo?t=01h01m40s)

[property](https://youtu.be/AyB3yDuZRTo?t=01h01m43s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h01m44s)

[so for people who haven't seen this fund](https://youtu.be/AyB3yDuZRTo?t=01h01m51s)

[syntax so the double curly braces what](https://youtu.be/AyB3yDuZRTo?t=01h01m52s)

[people are getting more familiar with as](https://youtu.be/AyB3yDuZRTo?t=01h01m54s)

[being a null check because it's an empty](https://youtu.be/AyB3yDuZRTo?t=01h01m56s)

[property pattern and most people forget](https://youtu.be/AyB3yDuZRTo?t=01h01m58s)

[that property patterns are things so](https://youtu.be/AyB3yDuZRTo?t=01h02m00s)

[this says if the content presenter is](https://youtu.be/AyB3yDuZRTo?t=01h02m02s)

[not null because a property pattern must](https://youtu.be/AyB3yDuZRTo?t=01h02m05s)

[be a non-null value](https://youtu.be/AyB3yDuZRTo?t=01h02m07s)

[and it's template property is not null](https://youtu.be/AyB3yDuZRTo?t=01h02m09s)

[take the template property create a](https://youtu.be/AyB3yDuZRTo?t=01h02m13s)

[local variable called template and have](https://youtu.be/AyB3yDuZRTo?t=01h02m15s)

[the entire expression return true](https://youtu.be/AyB3yDuZRTo?t=01h02m17s)

[that's a lot of words for a few curly](https://youtu.be/AyB3yDuZRTo?t=01h02m19s)

[braces and it's wonderful and I love it](https://youtu.be/AyB3yDuZRTo?t=01h02m21s)

[okay uh if template is hierarchical data](https://youtu.be/AyB3yDuZRTo?t=01h02m24s)

[template](https://youtu.be/AyB3yDuZRTo?t=01h02m30s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h02m31s)

[we'll do that we'll upcast that](https://youtu.be/AyB3yDuZRTo?t=01h02m37s)

[actually](https://youtu.be/AyB3yDuZRTo?t=01h02m44s)

[do that instead](https://youtu.be/AyB3yDuZRTo?t=01h02m50s)

[there we go so if we've got a](https://youtu.be/AyB3yDuZRTo?t=01h02m52s)

[hierarchical data template](https://youtu.be/AyB3yDuZRTo?t=01h02m55s)

[uh uh template](https://youtu.be/AyB3yDuZRTo?t=01h02m57s)

[item source](https://youtu.be/AyB3yDuZRTo?t=01h03m01s)

[um I want to know how I evaluate you to](https://youtu.be/AyB3yDuZRTo?t=01h03m09s)

[get get your children because I think](https://youtu.be/AyB3yDuZRTo?t=01h03m11s)

[it's going to be something like](https://youtu.be/AyB3yDuZRTo?t=01h03m14s)

[template item source](https://youtu.be/AyB3yDuZRTo?t=01h03m16s)

[uh because this is a binding base](https://youtu.be/AyB3yDuZRTo?t=01h03m19s)

[provide value](https://youtu.be/AyB3yDuZRTo?t=01h03m22s)

[how do I get the service provider](https://youtu.be/AyB3yDuZRTo?t=01h03m26s)

[uh maybe null so what I heard is send](https://youtu.be/AyB3yDuZRTo?t=01h03m31s)

[Nolan](https://youtu.be/AyB3yDuZRTo?t=01h03m33s)

[item Source provide value](https://youtu.be/AyB3yDuZRTo?t=01h03m36s)

[see what happens here](https://youtu.be/AyB3yDuZRTo?t=01h03m41s)

[uh let's see return array dot empty](https://youtu.be/AyB3yDuZRTo?t=01h03m43s)

[okay so on expanded](https://youtu.be/AyB3yDuZRTo?t=01h03m51s)

[uh so we don't care about index yet but](https://youtu.be/AyB3yDuZRTo?t=01h03m55s)

[what we want to do is undo item get](https://youtu.be/AyB3yDuZRTo?t=01h03m59s)

[children](https://youtu.be/AyB3yDuZRTo?t=01h04m02s)

[right so](https://youtu.be/AyB3yDuZRTo?t=01h04m04s)

[our children](https://youtu.be/AyB3yDuZRTo?t=01h04m06s)

[uh and we're gonna we're gonna to list](https://youtu.be/AyB3yDuZRTo?t=01h04m09s)

[it just to force enumeration even though](https://youtu.be/AyB3yDuZRTo?t=01h04m11s)

[it's](https://youtu.be/AyB3yDuZRTo?t=01h04m13s)

[under the hood we don't care yet but](https://youtu.be/AyB3yDuZRTo?t=01h04m14s)

[I think then we can leverage this to be](https://youtu.be/AyB3yDuZRTo?t=01h04m18s)

[able to pull the children out](https://youtu.be/AyB3yDuZRTo?t=01h04m21s)

[insert them into our list and make this](https://youtu.be/AyB3yDuZRTo?t=01h04m23s)

[work now not all functionality of the](https://youtu.be/AyB3yDuZRTo?t=01h04m25s)

[hierarchical data template will function](https://youtu.be/AyB3yDuZRTo?t=01h04m28s)

[with this tree view but I think I'm okay](https://youtu.be/AyB3yDuZRTo?t=01h04m30s)

[with that](https://youtu.be/AyB3yDuZRTo?t=01h04m31s)

[because the end experience is that it](https://youtu.be/AyB3yDuZRTo?t=01h04m33s)

[just doesn't work and people file bugs](https://youtu.be/AyB3yDuZRTo?t=01h04m36s)

[and say hey the following property](https://youtu.be/AyB3yDuZRTo?t=01h04m39s)

[doesn't work and then](https://youtu.be/AyB3yDuZRTo?t=01h04m41s)

[we deal with it](https://youtu.be/AyB3yDuZRTo?t=01h04m43s)

[okay if we do this](https://youtu.be/AyB3yDuZRTo?t=01h04m48s)

[provide value gave me back a binding](https://youtu.be/AyB3yDuZRTo?t=01h04m51s)

[is that what I expect](https://youtu.be/AyB3yDuZRTo?t=01h05m01s)

[is that what I expect hang on did I](https://youtu.be/AyB3yDuZRTo?t=01h05m05s)

[item source](https://youtu.be/AyB3yDuZRTo?t=01h05m09s)

[I kind of thought when I did item Source](https://youtu.be/AyB3yDuZRTo?t=01h05m13s)

[dot I was getting The Binding already](https://youtu.be/AyB3yDuZRTo?t=01h05m16s)

[because what is this binding here item](https://youtu.be/AyB3yDuZRTo?t=01h05m22s)

[Source binding](https://youtu.be/AyB3yDuZRTo?t=01h05m24s)

[has a path that points at what](https://youtu.be/AyB3yDuZRTo?t=01h05m25s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h05m30s)

[path points at movies](https://youtu.be/AyB3yDuZRTo?t=01h05m31s)

[which is kind of what I expected so I'm](https://youtu.be/AyB3yDuZRTo?t=01h05m34s)

[a little surprised that children](https://youtu.be/AyB3yDuZRTo?t=01h05m36s)

[gave me a binding](https://youtu.be/AyB3yDuZRTo?t=01h05m39s)

[with a path that also it's](https://youtu.be/AyB3yDuZRTo?t=01h05m42s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h05m52s)

[stop it stop it don't help me don't help](https://youtu.be/AyB3yDuZRTo?t=01h05m57s)

[me](https://youtu.be/AyB3yDuZRTo?t=01h06m00s)

[gonna figure this out if I cast you in](https://youtu.be/AyB3yDuZRTo?t=01h06m01s)

[am I am I just stupid is there something](https://youtu.be/AyB3yDuZRTo?t=01h06m05s)

[else on here I should be aware of](https://youtu.be/AyB3yDuZRTo?t=01h06m07s)

[provide value yeah wait what is this](https://youtu.be/AyB3yDuZRTo?t=01h06m12s)

[extract double](https://youtu.be/AyB3yDuZRTo?t=01h06m15s)

[why do we have extract double as an](https://youtu.be/AyB3yDuZRTo?t=01h06m18s)

[extension method on object](https://youtu.be/AyB3yDuZRTo?t=01h06m20s)

[I wrote it 33 days ago](https://youtu.be/AyB3yDuZRTo?t=01h06m25s)

[that's not a good look for me](https://youtu.be/AyB3yDuZRTo?t=01h06m28s)

[at least it's internal deal with it](https://youtu.be/AyB3yDuZRTo?t=01h06m31s)

[later okay](https://youtu.be/AyB3yDuZRTo?t=01h06m33s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h06m35s)

[what is what is going on here](https://youtu.be/AyB3yDuZRTo?t=01h06m38s)

[uh let's see service provider blah blah](https://youtu.be/AyB3yDuZRTo?t=01h06m42s)

[blah creep binding expression blah blah](https://youtu.be/AyB3yDuZRTo?t=01h06m45s)

[blah](https://youtu.be/AyB3yDuZRTo?t=01h06m47s)

[look abstract](https://youtu.be/AyB3yDuZRTo?t=01h06m50s)

[yeah this is binding base though yeah I](https://youtu.be/AyB3yDuZRTo?t=01h06m54s)

[don't want to look at binding base I](https://youtu.be/AyB3yDuZRTo?t=01h06m57s)

[want to look at binding](https://youtu.be/AyB3yDuZRTo?t=01h06m58s)

[what am I doing wrong here](https://youtu.be/AyB3yDuZRTo?t=01h07m00s)

[what am I doing wrong there's gonna be](https://youtu.be/AyB3yDuZRTo?t=01h07m02s)

[an override in here and he's going to do](https://youtu.be/AyB3yDuZRTo?t=01h07m05s)

[something useful and it's that something](https://youtu.be/AyB3yDuZRTo?t=01h07m07s)

[useful that I would like](https://youtu.be/AyB3yDuZRTo?t=01h07m09s)

[to invoke](https://youtu.be/AyB3yDuZRTo?t=01h07m12s)

[uh name Scopes is a sink async States](https://youtu.be/AyB3yDuZRTo?t=01h07m16s)

[kind of don't like having to do The](https://youtu.be/AyB3yDuZRTo?t=01h07m22s)

[Binding directly but we kind of have to](https://youtu.be/AyB3yDuZRTo?t=01h07m24s)

[evaluate](https://youtu.be/AyB3yDuZRTo?t=01h07m27s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h07m30s)

[serialize look up do filter create](https://youtu.be/AyB3yDuZRTo?t=01h07m38s)

[binding expression](https://youtu.be/AyB3yDuZRTo?t=01h07m40s)

[initialize clone to turn Scopes okay](https://youtu.be/AyB3yDuZRTo?t=01h07m43s)

[somebody](https://youtu.be/AyB3yDuZRTo?t=01h07m45s)

[okay show me all your overrides that's](https://youtu.be/AyB3yDuZRTo?t=01h07m50s)

[all I want to see](https://youtu.be/AyB3yDuZRTo?t=01h07m52s)

[validation rules validation notify](https://youtu.be/AyB3yDuZRTo?t=01h07m54s)

[create binding expression override](https://youtu.be/AyB3yDuZRTo?t=01h07m56s)

[that could be it we're going to mark it](https://youtu.be/AyB3yDuZRTo?t=01h08m01s)

[and come back](https://youtu.be/AyB3yDuZRTo?t=01h08m03s)

[the validation create clone initialize](https://youtu.be/AyB3yDuZRTo?t=01h08m05s)

[clone](https://youtu.be/AyB3yDuZRTo?t=01h08m07s)

[yeah so we're going to go here](https://youtu.be/AyB3yDuZRTo?t=01h08m09s)

[what do you do](https://youtu.be/AyB3yDuZRTo?t=01h08m12s)

[finding expression](https://youtu.be/AyB3yDuZRTo?t=01h08m14s)

[create binding expression so what does](https://youtu.be/AyB3yDuZRTo?t=01h08m16s)

[that do](https://youtu.be/AyB3yDuZRTo?t=01h08m19s)

[create binding expression we are very](https://youtu.be/AyB3yDuZRTo?t=01h08m21s)

[very deep in this](https://youtu.be/AyB3yDuZRTo?t=01h08m24s)

[uh um](https://youtu.be/AyB3yDuZRTo?t=01h08m26s)

[okay all of this to get into here but](https://youtu.be/AyB3yDuZRTo?t=01h08m30s)

[none of that actually gets me back to](https://youtu.be/AyB3yDuZRTo?t=01h08m33s)

[what I want just just evaluating The](https://youtu.be/AyB3yDuZRTo?t=01h08m35s)

[Binding](https://youtu.be/AyB3yDuZRTo?t=01h08m38s)

[because ultimately when this thing comes](https://youtu.be/AyB3yDuZRTo?t=01h08m42s)

[in](https://youtu.be/AyB3yDuZRTo?t=01h08m44s)

[we want to provide value the same way](https://youtu.be/AyB3yDuZRTo?t=01h08m48s)

[that that thing is going to work](https://youtu.be/AyB3yDuZRTo?t=01h08m50s)

[which](https://youtu.be/AyB3yDuZRTo?t=01h09m03s)

[we could actually save ourselves a](https://youtu.be/AyB3yDuZRTo?t=01h09m11s)

[little trouble then](https://youtu.be/AyB3yDuZRTo?t=01h09m15s)

[because okay when I messed up and moved](https://youtu.be/AyB3yDuZRTo?t=01h09m20s)

[it separated these](https://youtu.be/AyB3yDuZRTo?t=01h09m23s)

[okay what if we what if we cheat a](https://youtu.be/AyB3yDuZRTo?t=01h09m26s)

[little bit](https://youtu.be/AyB3yDuZRTo?t=01h09m29s)

[because we know](https://youtu.be/AyB3yDuZRTo?t=01h09m31s)

[when this is occurring](https://youtu.be/AyB3yDuZRTo?t=01h09m37s)

[I am wondering if it makes sense for](https://youtu.be/AyB3yDuZRTo?t=01h09m47s)

[this thing here to accept](https://youtu.be/AyB3yDuZRTo?t=01h09m50s)

[and](https://youtu.be/AyB3yDuZRTo?t=01h09m54s)

[find the children because we can add a](https://youtu.be/AyB3yDuZRTo?t=01h09m56s)

[children property to it because isn't](https://youtu.be/AyB3yDuZRTo?t=01h09m59s)

[that what tree view item does](https://youtu.be/AyB3yDuZRTo?t=01h10m02s)

[because this guy relies on an item's](https://youtu.be/AyB3yDuZRTo?t=01h10m09s)

[control](https://youtu.be/AyB3yDuZRTo?t=01h10m12s)

[where is it content control items](https://youtu.be/AyB3yDuZRTo?t=01h10m14s)

[presenter](https://youtu.be/AyB3yDuZRTo?t=01h10m16s)

[but that is leveraging the](https://youtu.be/AyB3yDuZRTo?t=01h10m18s)

[interface so that it knows where to](https://youtu.be/AyB3yDuZRTo?t=01h10m22s)

[write it to](https://youtu.be/AyB3yDuZRTo?t=01h10m24s)

[we do not want to do that](https://youtu.be/AyB3yDuZRTo?t=01h10m26s)

[but we could do the data binding](https://youtu.be/AyB3yDuZRTo?t=01h10m30s)

[ourselves and allow the property to](https://youtu.be/AyB3yDuZRTo?t=01h10m33s)

[exist there](https://youtu.be/AyB3yDuZRTo?t=01h10m35s)

[because if the template comes in](https://youtu.be/AyB3yDuZRTo?t=01h10m36s)

[we have this guy here we can get the](https://youtu.be/AyB3yDuZRTo?t=01h10m46s)

[template](https://youtu.be/AyB3yDuZRTo?t=01h10m48s)

[once we have the template](https://youtu.be/AyB3yDuZRTo?t=01h10m49s)

[I'm just wondering if](https://youtu.be/AyB3yDuZRTo?t=01h10m55s)

[so if we do if new template is](https://youtu.be/AyB3yDuZRTo?t=01h10m58s)

[Oracle data template](https://youtu.be/AyB3yDuZRTo?t=01h11m03s)

[foreign](https://youtu.be/AyB3yDuZRTo?t=01h11m07s)

[item source](https://youtu.be/AyB3yDuZRTo?t=01h11m16s)

[and then we do something like this where](https://youtu.be/AyB3yDuZRTo?t=01h11m21s)

[we go](https://youtu.be/AyB3yDuZRTo?t=01h11m24s)

[uh prop](https://youtu.be/AyB3yDuZRTo?t=01h11m27s)

[EP](https://youtu.be/AyB3yDuZRTo?t=01h11m29s)

[uh I enumerable](https://youtu.be/AyB3yDuZRTo?t=01h11m32s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h11m35s)

[uh children I just botched that](https://youtu.be/AyB3yDuZRTo?t=01h11m39s)

[completely](https://youtu.be/AyB3yDuZRTo?t=01h11m42s)

[okay we're gonna go here](https://youtu.be/AyB3yDuZRTo?t=01h11m44s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h11m48s)

[uh we do this](https://youtu.be/AyB3yDuZRTo?t=01h11m50s)

[we do this this becomes a null](https://youtu.be/AyB3yDuZRTo?t=01h11m51s)

[uh this becomes big long name here](https://youtu.be/AyB3yDuZRTo?t=01h11m54s)

[uh let's see children property children](https://youtu.be/AyB3yDuZRTo?t=01h11m58s)

[property children property this become](https://youtu.be/AyB3yDuZRTo?t=01h12m00s)

[innumerable](https://youtu.be/AyB3yDuZRTo?t=01h12m02s)

[this becomes internal this becomes](https://youtu.be/AyB3yDuZRTo?t=01h12m04s)

[internal](https://youtu.be/AyB3yDuZRTo?t=01h12m07s)

[um I guess it really doesn't need to be](https://youtu.be/AyB3yDuZRTo?t=01h12m11s)

[internal but we're going to leave it](https://youtu.be/AyB3yDuZRTo?t=01h12m12s)

[that way for the moment](https://youtu.be/AyB3yDuZRTo?t=01h12m13s)

[and then](https://youtu.be/AyB3yDuZRTo?t=01h12m15s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h12m21s)

[this set binding](https://youtu.be/AyB3yDuZRTo?t=01h12m24s)

[and we do children property](https://youtu.be/AyB3yDuZRTo?t=01h12m27s)

[and we do](https://youtu.be/AyB3yDuZRTo?t=01h12m30s)

[um higher archaeal](https://youtu.be/AyB3yDuZRTo?t=01h12m33s)

[uh item source](https://youtu.be/AyB3yDuZRTo?t=01h12m35s)

[here uh what is it](https://youtu.be/AyB3yDuZRTo?t=01h12m49s)

[that binding](https://youtu.be/AyB3yDuZRTo?t=01h12m52s)

[well I guess what we can do is we can](https://youtu.be/AyB3yDuZRTo?t=01h12m54s)

[just do an else here](https://youtu.be/AyB3yDuZRTo?t=01h12m55s)

[no point in blindly setting if we don't](https://youtu.be/AyB3yDuZRTo?t=01h12m57s)

[need to](https://youtu.be/AyB3yDuZRTo?t=01h13m00s)

[uh set binding actually it's clear](https://youtu.be/AyB3yDuZRTo?t=01h13m02s)

[property isn't it clear value](https://youtu.be/AyB3yDuZRTo?t=01h13m05s)

[do that float away](https://youtu.be/AyB3yDuZRTo?t=01h13m13s)

[Okay so](https://youtu.be/AyB3yDuZRTo?t=01h13m16s)

[if we do that](https://youtu.be/AyB3yDuZRTo?t=01h13m19s)

[instead of all of this](https://youtu.be/AyB3yDuZRTo?t=01h13m22s)

[then when it comes time to get the](https://youtu.be/AyB3yDuZRTo?t=01h13m25s)

[children we don't query template we](https://youtu.be/AyB3yDuZRTo?t=01h13m26s)

[query children](https://youtu.be/AyB3yDuZRTo?t=01h13m28s)

[and we don't care what it is per se](https://youtu.be/AyB3yDuZRTo?t=01h13m30s)

[which means we really only care about](https://youtu.be/AyB3yDuZRTo?t=01h13m35s)

[the presenter now](https://youtu.be/AyB3yDuZRTo?t=01h13m36s)

[uh presenter and then we just blindly](https://youtu.be/AyB3yDuZRTo?t=01h13m38s)

[return uh presenter.children](https://youtu.be/AyB3yDuZRTo?t=01h13m40s)

[no coalesce to array.empty](https://youtu.be/AyB3yDuZRTo?t=01h13m44s)

[okay](https://youtu.be/AyB3yDuZRTo?t=01h13m52s)

[I guess we should probably](https://youtu.be/AyB3yDuZRTo?t=01h13m59s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h14m02s)

[uh oh JC just popped in to ask if the](https://youtu.be/AyB3yDuZRTo?t=01h14m05s)

[clear button on oh the stupid thing uh](https://youtu.be/AyB3yDuZRTo?t=01h14m09s)

[on a text box should be firing on](https://youtu.be/AyB3yDuZRTo?t=01h14m13s)

[property change text field assist](https://youtu.be/AyB3yDuZRTo?t=01h14m15s)

[dependency](https://youtu.be/AyB3yDuZRTo?t=01h14m17s)

[ooh](https://youtu.be/AyB3yDuZRTo?t=01h14m19s)

[that is a good question](https://youtu.be/AyB3yDuZRTo?t=01h14m23s)

[uh we can look](https://youtu.be/AyB3yDuZRTo?t=01h14m29s)

[text field assist](https://youtu.be/AyB3yDuZRTo?t=01h14m33s)

[uh let's see and it's going to be has](https://youtu.be/AyB3yDuZRTo?t=01h14m36s)

[clear button](https://youtu.be/AyB3yDuZRTo?t=01h14m39s)

[foreign](https://youtu.be/AyB3yDuZRTo?t=01h14m42s)

[the behavior is not in the attached](https://youtu.be/AyB3yDuZRTo?t=01h14m48s)

[property which means it's in the](https://youtu.be/AyB3yDuZRTo?t=01h14m51s)

[template](https://youtu.be/AyB3yDuZRTo?t=01h14m52s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=01h14m54s)

[so then I guess the question is which](https://youtu.be/AyB3yDuZRTo?t=01h14m58s)

[control are you using is that just a](https://youtu.be/AyB3yDuZRTo?t=01h14m59s)

[text box or which one](https://youtu.be/AyB3yDuZRTo?t=01h15m02s)

[um because has clear button](https://youtu.be/AyB3yDuZRTo?t=01h15m07s)

[uh text box](https://youtu.be/AyB3yDuZRTo?t=01h15m11s)

[doesn't demo doesn't and your app](https://youtu.be/AyB3yDuZRTo?t=01h15m13s)

[doesn't](https://youtu.be/AyB3yDuZRTo?t=01h15m16s)

[uh let's see here](https://youtu.be/AyB3yDuZRTo?t=01h15m21s)

[oh there's the](https://youtu.be/AyB3yDuZRTo?t=01h15m28s)

[hint](https://youtu.be/AyB3yDuZRTo?t=01h15m31s)

[as clear button](https://youtu.be/AyB3yDuZRTo?t=01h15m33s)

[uh part clear button](https://youtu.be/AyB3yDuZRTo?t=01h15m36s)

[clear command](https://youtu.be/AyB3yDuZRTo?t=01h15m39s)

[just follow this guy down](https://youtu.be/AyB3yDuZRTo?t=01h15m42s)

[so the text box should be setting the](https://youtu.be/AyB3yDuZRTo?t=01h15m48s)

[text property to null](https://youtu.be/AyB3yDuZRTo?t=01h15m52s)

[foreign](https://youtu.be/AyB3yDuZRTo?t=01h15m57s)

[let's we can check this real quick](https://youtu.be/AyB3yDuZRTo?t=01h16m00s)

[I would expect the text property](https://youtu.be/AyB3yDuZRTo?t=01h16m04s)

[uh what about what did I do here uh](https://youtu.be/AyB3yDuZRTo?t=01h16m08s)

[return no bang semicolon](https://youtu.be/AyB3yDuZRTo?t=01h16m11s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=01h16m15s)

[take a look](https://youtu.be/AyB3yDuZRTo?t=01h16m17s)

[uh and then other quick question which](https://youtu.be/AyB3yDuZRTo?t=01h16m22s)

[version of the library are you on](https://youtu.be/AyB3yDuZRTo?t=01h16m24s)

[I assume it's probably four nine](https://youtu.be/AyB3yDuZRTo?t=01h16m27s)

[okay so if we go to fields](https://youtu.be/AyB3yDuZRTo?t=01h16m35s)

[yeah four nine okay cool](https://youtu.be/AyB3yDuZRTo?t=01h16m39s)

[um so we'll take what I'm about to do](https://youtu.be/AyB3yDuZRTo?t=01h16m43s)

[with a bit of a grain of salt](https://youtu.be/AyB3yDuZRTo?t=01h16m45s)

[okay so that](https://youtu.be/AyB3yDuZRTo?t=01h16m48s)

[does in fact assign it there](https://youtu.be/AyB3yDuZRTo?t=01h16m50s)

[and cleared that out so let's go to the](https://youtu.be/AyB3yDuZRTo?t=01h16m54s)

[uh Fields screen and just see what's](https://youtu.be/AyB3yDuZRTo?t=01h17m00s)

[going on so the dependency property is](https://youtu.be/AyB3yDuZRTo?t=01h17m04s)

[being cleared out](https://youtu.be/AyB3yDuZRTo?t=01h17m08s)

[so if that isn't giving you](https://youtu.be/AyB3yDuZRTo?t=01h17m10s)

[because I assume you're watching for](https://youtu.be/AyB3yDuZRTo?t=01h17m15s)

[property changed on the text box itself](https://youtu.be/AyB3yDuZRTo?t=01h17m16s)

[or are you data bound to the text](https://youtu.be/AyB3yDuZRTo?t=01h17m19s)

[property](https://youtu.be/AyB3yDuZRTo?t=01h17m21s)

[see here](https://youtu.be/AyB3yDuZRTo?t=01h17m27s)

[as clear button](https://youtu.be/AyB3yDuZRTo?t=01h17m30s)

[uh let's see X name](https://youtu.be/AyB3yDuZRTo?t=01h17m36s)

[clear](https://youtu.be/AyB3yDuZRTo?t=01h17m39s)

[so if we go](https://youtu.be/AyB3yDuZRTo?t=01h17m45s)

[uh my view model using Community toolkit](https://youtu.be/AyB3yDuZRTo?t=01h17m50s)

[Okay so](https://youtu.be/AyB3yDuZRTo?t=01h17m53s)

[let's if that's the case let's data bind](https://youtu.be/AyB3yDuZRTo?t=01h17m55s)

[this guy](https://youtu.be/AyB3yDuZRTo?t=01h17m57s)

[so this is here](https://youtu.be/AyB3yDuZRTo?t=01h17m59s)

[uh let's see binding](https://youtu.be/AyB3yDuZRTo?t=01h18m02s)

[uh what's our data context do we have](https://youtu.be/AyB3yDuZRTo?t=01h18m06s)

[one](https://youtu.be/AyB3yDuZRTo?t=01h18m08s)

[do we do okay uh](https://youtu.be/AyB3yDuZRTo?t=01h18m09s)

[I'm just gonna bind to name](https://youtu.be/AyB3yDuZRTo?t=01h18m13s)

[uh binding](https://youtu.be/AyB3yDuZRTo?t=01h18m19s)

[name](https://youtu.be/AyB3yDuZRTo?t=01h18m21s)

[and then I expect to see that going](https://youtu.be/AyB3yDuZRTo?t=01h18m24s)

[through](https://youtu.be/AyB3yDuZRTo?t=01h18m27s)

[now I have a sinking suspicion it could](https://youtu.be/AyB3yDuZRTo?t=01h18m31s)

[be](https://youtu.be/AyB3yDuZRTo?t=01h18m33s)

[potentially Focus related](https://youtu.be/AyB3yDuZRTo?t=01h18m34s)

[but we'll we'll take a look here](https://youtu.be/AyB3yDuZRTo?t=01h18m38s)

[so if we go](https://youtu.be/AyB3yDuZRTo?t=01h18m42s)

[out of fields we go](https://youtu.be/AyB3yDuZRTo?t=01h18m44s)

[some value there](https://youtu.be/AyB3yDuZRTo?t=01h18m47s)

[tab then it sets the property](https://youtu.be/AyB3yDuZRTo?t=01h18m50s)

[and then if I click this](https://youtu.be/AyB3yDuZRTo?t=01h18m54s)

[we don't need that anymore](https://youtu.be/AyB3yDuZRTo?t=01h18m58s)

[oh it doesn't](https://youtu.be/AyB3yDuZRTo?t=01h19m02s)

[interesting](https://youtu.be/AyB3yDuZRTo?t=01h19m08s)

[wow okay](https://youtu.be/AyB3yDuZRTo?t=01h19m13s)

[that's](https://youtu.be/AyB3yDuZRTo?t=01h19m17s)

[ah okay](https://youtu.be/AyB3yDuZRTo?t=01h19m22s)

[um so let's let's so working Theory](https://youtu.be/AyB3yDuZRTo?t=01h19m25s)

[that the so the default update Source](https://youtu.be/AyB3yDuZRTo?t=01h19m30s)

[trigger on the binding is going to be](https://youtu.be/AyB3yDuZRTo?t=01h19m33s)

[lost Focus](https://youtu.be/AyB3yDuZRTo?t=01h19m35s)

[and I'm wondering if because of where](https://youtu.be/AyB3yDuZRTo?t=01h19m36s)

[the button is positioned in the template](https://youtu.be/AyB3yDuZRTo?t=01h19m39s)

[if that is](https://youtu.be/AyB3yDuZRTo?t=01h19m41s)

[the the source of what's going on kind](https://youtu.be/AyB3yDuZRTo?t=01h19m44s)

[of like how it didn't update the text in](https://youtu.be/AyB3yDuZRTo?t=01h19m47s)

[my backing field until I tabbed away and](https://youtu.be/AyB3yDuZRTo?t=01h19m50s)

[now I'm going to have to move this so](https://youtu.be/AyB3yDuZRTo?t=01h19m53s)

[that it doesn't if I do this](https://youtu.be/AyB3yDuZRTo?t=01h19m54s)

[click off](https://youtu.be/AyB3yDuZRTo?t=01h19m57s)

[put the binding back](https://youtu.be/AyB3yDuZRTo?t=01h19m59s)

[now if I click](https://youtu.be/AyB3yDuZRTo?t=01h20m01s)

[sets it immediately](https://youtu.be/AyB3yDuZRTo?t=01h20m03s)

[yeah](https://youtu.be/AyB3yDuZRTo?t=01h20m05s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h20m07s)

[I suspect what's biting you is the the](https://youtu.be/AyB3yDuZRTo?t=01h20m07s)

[fact that bindings default their update](https://youtu.be/AyB3yDuZRTo?t=01h20m11s)

[Source trigger to Lost Focus so I don't](https://youtu.be/AyB3yDuZRTo?t=01h20m13s)

[know if you had to jump yet JC or not](https://youtu.be/AyB3yDuZRTo?t=01h20m15s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h20m18s)

[if you change it to update Source](https://youtu.be/AyB3yDuZRTo?t=01h20m18s)

[trigger property changed that will be](https://youtu.be/AyB3yDuZRTo?t=01h20m21s)

[better if it's a text field that has a](https://youtu.be/AyB3yDuZRTo?t=01h20m24s)

[um a lot of activity like the user's](https://youtu.be/AyB3yDuZRTo?t=01h20m28s)

[typing a bunch in it you may also want](https://youtu.be/AyB3yDuZRTo?t=01h20m30s)

[to set a delay on it](https://youtu.be/AyB3yDuZRTo?t=01h20m32s)

[um just so that](https://youtu.be/AyB3yDuZRTo?t=01h20m34s)

[because if you do on property changed](https://youtu.be/AyB3yDuZRTo?t=01h20m36s)

[that binding is going to be firing on](https://youtu.be/AyB3yDuZRTo?t=01h20m38s)

[pretty much every keystroke](https://youtu.be/AyB3yDuZRTo?t=01h20m40s)

[and it's you probably want to wait for](https://youtu.be/AyB3yDuZRTo?t=01h20m42s)

[it to slow down a little before you](https://youtu.be/AyB3yDuZRTo?t=01h20m45s)

[update your view model so yeah I think](https://youtu.be/AyB3yDuZRTo?t=01h20m47s)

[if you do something like this that'll](https://youtu.be/AyB3yDuZRTo?t=01h20m49s)

[probably get you close to what you want](https://youtu.be/AyB3yDuZRTo?t=01h20m51s)

[it is an unusual behavior](https://youtu.be/AyB3yDuZRTo?t=01h20m53s)

[I just don't know if we can](https://youtu.be/AyB3yDuZRTo?t=01h20m57s)

[realistically fix it in the library](https://youtu.be/AyB3yDuZRTo?t=01h20m58s)

[since that's the default property of of](https://youtu.be/AyB3yDuZRTo?t=01h21m00s)

[binding](https://youtu.be/AyB3yDuZRTo?t=01h21m02s)

[but something to that effect](https://youtu.be/AyB3yDuZRTo?t=01h21m04s)

[and yes you're welcome](https://youtu.be/AyB3yDuZRTo?t=01h21m07s)

[so let's go back here and I just want to](https://youtu.be/AyB3yDuZRTo?t=01h21m10s)

[throw that away okay](https://youtu.be/AyB3yDuZRTo?t=01h21m12s)

[back to plunging the depths of WPF](https://youtu.be/AyB3yDuZRTo?t=01h21m14s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h21m18s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=01h21m21s)

[to do](https://youtu.be/AyB3yDuZRTo?t=01h21m22s)

[okay so we were going to do this](https://youtu.be/AyB3yDuZRTo?t=01h21m26s)

[maneuver here where we attempt to pull](https://youtu.be/AyB3yDuZRTo?t=01h21m29s)

[this out](https://youtu.be/AyB3yDuZRTo?t=01h21m31s)

[uh children as I numerable of object I'm](https://youtu.be/AyB3yDuZRTo?t=01h21m33s)

[actually wondering if it makes more](https://youtu.be/AyB3yDuZRTo?t=01h21m39s)

[sense she just declared children as I](https://youtu.be/AyB3yDuZRTo?t=01h21m40s)

[innumerable object the only reason so](https://youtu.be/AyB3yDuZRTo?t=01h21m43s)

[much stuff is declared in WPF land](https://youtu.be/AyB3yDuZRTo?t=01h21m45s)

[without generics is because generics](https://youtu.be/AyB3yDuZRTo?t=01h21m48s)

[came out](https://youtu.be/AyB3yDuZRTo?t=01h21m50s)

[shortly after WPF released so](https://youtu.be/AyB3yDuZRTo?t=01h21m51s)

[while they were developing WPF they](https://youtu.be/AyB3yDuZRTo?t=01h21m55s)

[didn't really have generics as a thing](https://youtu.be/AyB3yDuZRTo?t=01h21m58s)

[that they could Leverage](https://youtu.be/AyB3yDuZRTo?t=01h22m00s)

[so it's like well I can kind of get some](https://youtu.be/AyB3yDuZRTo?t=01h22m01s)

[supplies on that](https://youtu.be/AyB3yDuZRTo?t=01h22m04s)

[so that goes like that that goes like](https://youtu.be/AyB3yDuZRTo?t=01h22m06s)

[that that goes like that what is your](https://youtu.be/AyB3yDuZRTo?t=01h22m08s)

[problem here](https://youtu.be/AyB3yDuZRTo?t=01h22m09s)

[nullability of reference types don't](https://youtu.be/AyB3yDuZRTo?t=01h22m11s)

[match that's because you should have](https://youtu.be/AyB3yDuZRTo?t=01h22m13s)

[been object nullable technically you](https://youtu.be/AyB3yDuZRTo?t=01h22m15s)

[should be knowable as well](https://youtu.be/AyB3yDuZRTo?t=01h22m18s)

[that should be there](https://youtu.be/AyB3yDuZRTo?t=01h22m20s)

[okay](https://youtu.be/AyB3yDuZRTo?t=01h22m23s)

[see if this gets me](https://youtu.be/AyB3yDuZRTo?t=01h22m26s)

[my children](https://youtu.be/AyB3yDuZRTo?t=01h22m28s)

[so I can pull the children all of this](https://youtu.be/AyB3yDuZRTo?t=01h22m30s)

[work just because I don't want to make](https://youtu.be/AyB3yDuZRTo?t=01h22m32s)

[the user have to do something weird when](https://youtu.be/AyB3yDuZRTo?t=01h22m34s)

[they use this control](https://youtu.be/AyB3yDuZRTo?t=01h22m36s)

[oh hang on hang on I'm an idiot](https://youtu.be/AyB3yDuZRTo?t=01h22m41s)

[I'm an idiot and I did not update this](https://youtu.be/AyB3yDuZRTo?t=01h22m44s)

[properly](https://youtu.be/AyB3yDuZRTo?t=01h22m47s)

[okay let's try that again](https://youtu.be/AyB3yDuZRTo?t=01h22m49s)

[yeah the other one updated fine](https://youtu.be/AyB3yDuZRTo?t=01h22m54s)

[property metadata no okay cool](https://youtu.be/AyB3yDuZRTo?t=01h22m58s)

[there we go okay so if we do this](https://youtu.be/AyB3yDuZRTo?t=01h23m07s)

[do we get children](https://youtu.be/AyB3yDuZRTo?t=01h23m14s)

[got him](https://youtu.be/AyB3yDuZRTo?t=01h23m22s)

[yes](https://youtu.be/AyB3yDuZRTo?t=01h23m28s)

[yes yes](https://youtu.be/AyB3yDuZRTo?t=01h23m30s)

[okay okay happiness erupts](https://youtu.be/AyB3yDuZRTo?t=01h23m32s)

[my happiness erupts](https://youtu.be/AyB3yDuZRTo?t=01h23m37s)

[The Crowd Goes Wild everyone's excited](https://youtu.be/AyB3yDuZRTo?t=01h23m39s)

[okay okay okay](https://youtu.be/AyB3yDuZRTo?t=01h23m42s)

[first problem solved](https://youtu.be/AyB3yDuZRTo?t=01h23m45s)

[can we get the children answer yes yes](https://youtu.be/AyB3yDuZRTo?t=01h23m47s)

[yes](https://youtu.be/AyB3yDuZRTo?t=01h23m51s)

[we can get the children](https://youtu.be/AyB3yDuZRTo?t=01h23m52s)

[thank you bananatron I'm glad somebody](https://youtu.be/AyB3yDuZRTo?t=01h23m54s)

[shares my excitement sometimes I get](https://youtu.be/AyB3yDuZRTo?t=01h23m56s)

[overly excited about this okay so we can](https://youtu.be/AyB3yDuZRTo?t=01h23m58s)

[pull the children out](https://youtu.be/AyB3yDuZRTo?t=01h24m00s)

[okay once we get the children then we](https://youtu.be/AyB3yDuZRTo?t=01h24m02s)

[want to leverage this index and insert](https://youtu.be/AyB3yDuZRTo?t=01h24m06s)

[the children into the list at the](https://youtu.be/AyB3yDuZRTo?t=01h24m08s)

[appropriate Index right I'm going to](https://youtu.be/AyB3yDuZRTo?t=01h24m11s)

[settle for not worrying about the](https://youtu.be/AyB3yDuZRTo?t=01h24m14s)

[indentation just](https://youtu.be/AyB3yDuZRTo?t=01h24m15s)

[that's it that's all that's I will](https://youtu.be/AyB3yDuZRTo?t=01h24m18s)

[settle for that as success](https://youtu.be/AyB3yDuZRTo?t=01h24m20s)

[if to do that I think what we need to do](https://youtu.be/AyB3yDuZRTo?t=01h24m22s)

[is have an internal collection that we](https://youtu.be/AyB3yDuZRTo?t=01h24m26s)

[do the bindings to](https://youtu.be/AyB3yDuZRTo?t=01h24m30s)

[hey yes Justin Bieber](https://youtu.be/AyB3yDuZRTo?t=01h24m32s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h24m35s)

[so the](https://youtu.be/AyB3yDuZRTo?t=01h24m37s)

[problem being is I'd like to](https://youtu.be/AyB3yDuZRTo?t=01h24m40s)

[I'd like to expose up](https://youtu.be/AyB3yDuZRTo?t=01h24m44s)

[I'd like to expose I'd like to leave the](https://youtu.be/AyB3yDuZRTo?t=01h24m49s)

[item Source property as is](https://youtu.be/AyB3yDuZRTo?t=01h24m52s)

[because I'd like that to be there but I](https://youtu.be/AyB3yDuZRTo?t=01h24m58s)

[also want to](https://youtu.be/AyB3yDuZRTo?t=01h25m01s)

[what's the right way to do this](https://youtu.be/AyB3yDuZRTo?t=01h25m04s)

[because](https://youtu.be/AyB3yDuZRTo?t=01h25m09s)

[my public API I want to be](https://youtu.be/AyB3yDuZRTo?t=01h25m11s)

[that item source](https://youtu.be/AyB3yDuZRTo?t=01h25m15s)

[we could override the metadata](https://youtu.be/AyB3yDuZRTo?t=01h25m18s)

[and hijack a coalesce Handler](https://youtu.be/AyB3yDuZRTo?t=01h25m23s)

[the problem is is that cuts both ways](https://youtu.be/AyB3yDuZRTo?t=01h25m29s)

[or does it](https://youtu.be/AyB3yDuZRTo?t=01h25m34s)

[can we get away with](https://youtu.be/AyB3yDuZRTo?t=01h25m36s)

[not doing that and having a wrapper that](https://youtu.be/AyB3yDuZRTo?t=01h25m39s)

[can dynamically inject into the middle](https://youtu.be/AyB3yDuZRTo?t=01h25m42s)

[but knows which way it's being called](https://youtu.be/AyB3yDuZRTo?t=01h25m44s)

[from](https://youtu.be/AyB3yDuZRTo?t=01h25m47s)

[because we can override the item Source](https://youtu.be/AyB3yDuZRTo?t=01h25m49s)

[property and hook in to its property](https://youtu.be/AyB3yDuZRTo?t=01h25m52s)

[changes](https://youtu.be/AyB3yDuZRTo?t=01h25m55s)

[there is a coalesce function that you](https://youtu.be/AyB3yDuZRTo?t=01h25m58s)

[can use to massage data into the shape](https://youtu.be/AyB3yDuZRTo?t=01h26m01s)

[that you need it into and we could](https://youtu.be/AyB3yDuZRTo?t=01h26m04s)

[hijack that take whatever collection the](https://youtu.be/AyB3yDuZRTo?t=01h26m06s)

[user sends in wrap it in our own](https://youtu.be/AyB3yDuZRTo?t=01h26m08s)

[collection and send that through](https://youtu.be/AyB3yDuZRTo?t=01h26m10s)

[I think the problem though is then the](https://youtu.be/AyB3yDuZRTo?t=01h26m13s)

[user gets our collection sent back to](https://youtu.be/AyB3yDuZRTo?t=01h26m15s)

[them](https://youtu.be/AyB3yDuZRTo?t=01h26m17s)

[look I don't remember how that works](https://youtu.be/AyB3yDuZRTo?t=01h26m19s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h26m23s)

[uh prop](https://youtu.be/AyB3yDuZRTo?t=01h26m24s)

[PP](https://youtu.be/AyB3yDuZRTo?t=01h26m27s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h26m28s)

[observable collection](https://youtu.be/AyB3yDuZRTo?t=01h26m32s)

[of](https://youtu.be/AyB3yDuZRTo?t=01h26m35s)

[object](https://youtu.be/AyB3yDuZRTo?t=01h26m37s)

[right and so what I want to do is I want](https://youtu.be/AyB3yDuZRTo?t=01h26m39s)

[to look at this](https://youtu.be/AyB3yDuZRTo?t=01h26m42s)

[and I want to see property change](https://youtu.be/AyB3yDuZRTo?t=01h26m44s)

[callback](https://youtu.be/AyB3yDuZRTo?t=01h26m46s)

[I want to do null](https://youtu.be/AyB3yDuZRTo?t=01h26m48s)

[uh on Foo](https://youtu.be/AyB3yDuZRTo?t=01h26m51s)

[I want to look at generate method](https://youtu.be/AyB3yDuZRTo?t=01h26m54s)

[because this is the coalesce one](https://youtu.be/AyB3yDuZRTo?t=01h26m58s)

[and I don't remember](https://youtu.be/AyB3yDuZRTo?t=01h27m01s)

[if this](https://youtu.be/AyB3yDuZRTo?t=01h27m04s)

[if we do something here](https://youtu.be/AyB3yDuZRTo?t=01h27m11s)

[does that change it](https://youtu.be/AyB3yDuZRTo?t=01h27m15s)

[um I don't think it does](https://youtu.be/AyB3yDuZRTo?t=01h27m20s)

[like for example basically what they did](https://youtu.be/AyB3yDuZRTo?t=01h27m25s)

[here](https://youtu.be/AyB3yDuZRTo?t=01h27m28s)

[right so we want uh items control](https://youtu.be/AyB3yDuZRTo?t=01h27m29s)

[and we want the item Source property we](https://youtu.be/AyB3yDuZRTo?t=01h27m34s)

[want to override the metadata and we](https://youtu.be/AyB3yDuZRTo?t=01h27m38s)

[want to we want it to be us as the owner](https://youtu.be/AyB3yDuZRTo?t=01h27m40s)

[and rather than because this one here](https://youtu.be/AyB3yDuZRTo?t=01h27m44s)

[just slapped in a](https://youtu.be/AyB3yDuZRTo?t=01h27m47s)

[different selection mode do key in here](https://youtu.be/AyB3yDuZRTo?t=01h27m49s)

[and in our case we want](https://youtu.be/AyB3yDuZRTo?t=01h27m53s)

[still want to default of null](https://youtu.be/AyB3yDuZRTo?t=01h27m57s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h27m59s)

[uh we want to grab a](https://youtu.be/AyB3yDuZRTo?t=01h28m01s)

[so let's go and look what is what is how](https://youtu.be/AyB3yDuZRTo?t=01h28m04s)

[is this guy declared item Source](https://youtu.be/AyB3yDuZRTo?t=01h28m06s)

[property](https://youtu.be/AyB3yDuZRTo?t=01h28m08s)

[show me your declaration show me your](https://youtu.be/AyB3yDuZRTo?t=01h28m10s)

[declaration there we are](https://youtu.be/AyB3yDuZRTo?t=01h28m12s)

[register blah blah blah](https://youtu.be/AyB3yDuZRTo?t=01h28m13s)

[so you're not fancy at all](https://youtu.be/AyB3yDuZRTo?t=01h28m17s)

[on item Source changed](https://youtu.be/AyB3yDuZRTo?t=01h28m20s)

[oh I wonder if that's gonna bite me if I](https://youtu.be/AyB3yDuZRTo?t=01h28m26s)

[turn this off](https://youtu.be/AyB3yDuZRTo?t=01h28m28s)

[get binding expression](https://youtu.be/AyB3yDuZRTo?t=01h28m30s)

[yeah I think that's gonna bite me](https://youtu.be/AyB3yDuZRTo?t=01h28m40s)

[because if I override the metadata](https://youtu.be/AyB3yDuZRTo?t=01h28m42s)

[it's gonna lose access to this changed](https://youtu.be/AyB3yDuZRTo?t=01h28m46s)

[Handler](https://youtu.be/AyB3yDuZRTo?t=01h28m49s)

[that's an interesting problem](https://youtu.be/AyB3yDuZRTo?t=01h28m52s)

[it's a very interesting problem](https://youtu.be/AyB3yDuZRTo?t=01h28m55s)

[uh let's see item Source property](https://youtu.be/AyB3yDuZRTo?t=01h28m58s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h29m03s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h29m04s)

[validate value](https://youtu.be/AyB3yDuZRTo?t=01h29m07s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h29m11s)

[default metadata](https://youtu.be/AyB3yDuZRTo?t=01h29m16s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h29m21s)

[I guess we could wrap it](https://youtu.be/AyB3yDuZRTo?t=01h29m23s)

[we could wrap it up](https://youtu.be/AyB3yDuZRTo?t=01h29m26s)

[that'd work](https://youtu.be/AyB3yDuZRTo?t=01h29m28s)

[that would work](https://youtu.be/AyB3yDuZRTo?t=01h29m31s)

[and this is going to be the tackiest](https://youtu.be/AyB3yDuZRTo?t=01h29m33s)

[thing ever okay](https://youtu.be/AyB3yDuZRTo?t=01h29m34s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h29m37s)

[eternal](https://youtu.be/AyB3yDuZRTo?t=01h29m40s)

[uh item Source we're gonna we're gonna](https://youtu.be/AyB3yDuZRTo?t=01h29m41s)

[we're gonna go down this path for a](https://youtu.be/AyB3yDuZRTo?t=01h29m44s)

[moment because I I think this has](https://youtu.be/AyB3yDuZRTo?t=01h29m45s)

[potential](https://youtu.be/AyB3yDuZRTo?t=01h29m48s)

[and actually we don't need this as a](https://youtu.be/AyB3yDuZRTo?t=01h29m50s)

[dependency property](https://youtu.be/AyB3yDuZRTo?t=01h29m51s)

[in fact](https://youtu.be/AyB3yDuZRTo?t=01h29m54s)

[we we can just assign it so](https://youtu.be/AyB3yDuZRTo?t=01h29m57s)

[we can we can do this we can do it like](https://youtu.be/AyB3yDuZRTo?t=01h30m02s)

[that okay now there may be a question of](https://youtu.be/AyB3yDuZRTo?t=01h30m04s)

[do we want to allocate before we know we](https://youtu.be/AyB3yDuZRTo?t=01h30m07s)

[need it and yada yada but whatever](https://youtu.be/AyB3yDuZRTo?t=01h30m09s)

[so we can do this](https://youtu.be/AyB3yDuZRTo?t=01h30m11s)

[item Source property](https://youtu.be/AyB3yDuZRTo?t=01h30m14s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h30m17s)

[items control](https://youtu.be/AyB3yDuZRTo?t=01h30m19s)

[uh VAR metadata](https://youtu.be/AyB3yDuZRTo?t=01h30m22s)

[we can pull that sucker out](https://youtu.be/AyB3yDuZRTo?t=01h30m26s)

[and then we can do](https://youtu.be/AyB3yDuZRTo?t=01h30m29s)

[um are you able to](https://youtu.be/AyB3yDuZRTo?t=01h30m34s)

[thank goodness](https://youtu.be/AyB3yDuZRTo?t=01h30m38s)

[you didn't seal the crap out of](https://youtu.be/AyB3yDuZRTo?t=01h30m40s)

[everything Hallelujah](https://youtu.be/AyB3yDuZRTo?t=01h30m42s)

[and actually this thing didn't](https://youtu.be/AyB3yDuZRTo?t=01h30m44s)

[this thing didn't](https://youtu.be/AyB3yDuZRTo?t=01h30m49s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h30m51s)

[do anything fancy did it](https://youtu.be/AyB3yDuZRTo?t=01h30m53s)

[it's framework property metadata null](https://youtu.be/AyB3yDuZRTo?t=01h30m55s)

[callback okay](https://youtu.be/AyB3yDuZRTo?t=01h30m57s)

[um so if we do](https://youtu.be/AyB3yDuZRTo?t=01h30m59s)

[private class](https://youtu.be/AyB3yDuZRTo?t=01h31m02s)

[wrapping](https://youtu.be/AyB3yDuZRTo?t=01h31m04s)

[framework property](https://youtu.be/AyB3yDuZRTo?t=01h31m06s)

[uh metadata](https://youtu.be/AyB3yDuZRTo?t=01h31m09s)

[do this you will also derive from](https://youtu.be/AyB3yDuZRTo?t=01h31m12s)

[uh framework property metadata](https://youtu.be/AyB3yDuZRTo?t=01h31m18s)

[okay and then so we want this guy to go](https://youtu.be/AyB3yDuZRTo?t=01h31m23s)

[here and his first parameter is going to](https://youtu.be/AyB3yDuZRTo?t=01h31m25s)

[be metadata](https://youtu.be/AyB3yDuZRTo?t=01h31m28s)

[and then](https://youtu.be/AyB3yDuZRTo?t=01h31m30s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h31m33s)

[yeah and then we're just gonna have him](https://youtu.be/AyB3yDuZRTo?t=01h31m36s)

[take a call back](https://youtu.be/AyB3yDuZRTo?t=01h31m38s)

[the cpar](https://youtu.be/AyB3yDuZRTo?t=01h31m41s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h31m43s)

[we're gonna do this](https://youtu.be/AyB3yDuZRTo?t=01h31m49s)

[existing](https://youtu.be/AyB3yDuZRTo?t=01h31m52s)

[and then we will do a](https://youtu.be/AyB3yDuZRTo?t=01h31m53s)

[uh what is the what is the Callback on](https://youtu.be/AyB3yDuZRTo?t=01h31m57s)

[this guy called](https://youtu.be/AyB3yDuZRTo?t=01h31m59s)

[uh where's your Constructor I want your](https://youtu.be/AyB3yDuZRTo?t=01h32m01s)

[Constructor I want your Constructor uh](https://youtu.be/AyB3yDuZRTo?t=01h32m03s)

[property changed callback that's what I](https://youtu.be/AyB3yDuZRTo?t=01h32m05s)

[want I want one of those give me uh](https://youtu.be/AyB3yDuZRTo?t=01h32m06s)

[property changed](https://youtu.be/AyB3yDuZRTo?t=01h32m12s)

[all back](https://youtu.be/AyB3yDuZRTo?t=01h32m14s)

[and actually](https://youtu.be/AyB3yDuZRTo?t=01h32m19s)

[okay and so what we want to do here](https://youtu.be/AyB3yDuZRTo?t=01h32m24s)

[is we want to do](https://youtu.be/AyB3yDuZRTo?t=01h32m28s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h32m32s)

[I don't really want to memorize clone](https://youtu.be/AyB3yDuZRTo?t=01h32m40s)

[him](https://youtu.be/AyB3yDuZRTo?t=01h32m43s)

[actually I guess I don't even need a](https://youtu.be/AyB3yDuZRTo?t=01h32m48s)

[wrapping object do I](https://youtu.be/AyB3yDuZRTo?t=01h32m49s)

[if I just pull this guy out what I](https://youtu.be/AyB3yDuZRTo?t=01h32m52s)

[really want to do is set the](https://youtu.be/AyB3yDuZRTo?t=01h32m54s)

[uh property changed callback which is a](https://youtu.be/AyB3yDuZRTo?t=01h32m56s)

[get set](https://youtu.be/AyB3yDuZRTo?t=01h32m59s)

[and hijack so I don't need this](https://youtu.be/AyB3yDuZRTo?t=01h33m01s)

[I'm being done](https://youtu.be/AyB3yDuZRTo?t=01h33m05s)

[what I really want to do is I just want](https://youtu.be/AyB3yDuZRTo?t=01h33m07s)

[to say](https://youtu.be/AyB3yDuZRTo?t=01h33m09s)

[metadata boom](https://youtu.be/AyB3yDuZRTo?t=01h33m11s)

[all right so](https://youtu.be/AyB3yDuZRTo?t=01h33m13s)

[we just we want to come in here and we](https://youtu.be/AyB3yDuZRTo?t=01h33m15s)

[want metadata to be property change](https://youtu.be/AyB3yDuZRTo?t=01h33m17s)

[callback gets](https://youtu.be/AyB3yDuZRTo?t=01h33m20s)

[uh or actually let's cash the call back](https://youtu.be/AyB3yDuZRTo?t=01h33m23s)

[our previous callback gets uh metadata](https://youtu.be/AyB3yDuZRTo?t=01h33m26s)

[property change callback we're gonna](https://youtu.be/AyB3yDuZRTo?t=01h33m31s)

[just do a little delegate concatenation](https://youtu.be/AyB3yDuZRTo?t=01h33m34s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h33m37s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=01h33m40s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h33m42s)

[uh metadata](https://youtu.be/AyB3yDuZRTo?t=01h33m46s)

[property change callback](https://youtu.be/AyB3yDuZRTo?t=01h33m49s)

[gets](https://youtu.be/AyB3yDuZRTo?t=01h33m52s)

[you didn't just do it for me did you](https://youtu.be/AyB3yDuZRTo?t=01h34m02s)

[wow that is remarkably impressive](https://youtu.be/AyB3yDuZRTo?t=01h34m09s)

[Copilot](https://youtu.be/AyB3yDuZRTo?t=01h34m12s)

[you're wrong but that's remarkably](https://youtu.be/AyB3yDuZRTo?t=01h34m14s)

[impressive](https://youtu.be/AyB3yDuZRTo?t=01h34m16s)

[okay so uh](https://youtu.be/AyB3yDuZRTo?t=01h34m18s)

[uh private static void on item Source](https://youtu.be/AyB3yDuZRTo?t=01h34m21s)

[property on item Source changed](https://youtu.be/AyB3yDuZRTo?t=01h34m27s)

[tendency object](https://youtu.be/AyB3yDuZRTo?t=01h34m31s)

[uh oh](https://youtu.be/AyB3yDuZRTo?t=01h34m34s)

[dependency property changed event args e](https://youtu.be/AyB3yDuZRTo?t=01h34m36s)

[so we want this](https://youtu.be/AyB3yDuZRTo?t=01h34m42s)

[fit in this hole](https://youtu.be/AyB3yDuZRTo?t=01h34m45s)

[right](https://youtu.be/AyB3yDuZRTo?t=01h34m47s)

[that goes like that](https://youtu.be/AyB3yDuZRTo?t=01h34m49s)

[oh and we actually want to do this in](https://youtu.be/AyB3yDuZRTo?t=01h34m57s)

[the static Constructor too](https://youtu.be/AyB3yDuZRTo?t=01h34m59s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h35m02s)

[uh maybe let's see because we are going](https://youtu.be/AyB3yDuZRTo?t=01h35m05s)

[to be acting entirely on static members](https://youtu.be/AyB3yDuZRTo?t=01h35m07s)

[so](https://youtu.be/AyB3yDuZRTo?t=01h35m10s)

[I think if I remember right that's what](https://youtu.be/AyB3yDuZRTo?t=01h35m11s)

[we saw the list view do yeah static list](https://youtu.be/AyB3yDuZRTo?t=01h35m12s)

[View](https://youtu.be/AyB3yDuZRTo?t=01h35m15s)

[briefly uh what is default metadata](https://youtu.be/AyB3yDuZRTo?t=01h35m16s)

[great question so uh when you're](https://youtu.be/AyB3yDuZRTo?t=01h35m18s)

[declaring your dependency properties](https://youtu.be/AyB3yDuZRTo?t=01h35m21s)

[um kind of like we did down here](https://youtu.be/AyB3yDuZRTo?t=01h35m25s)

[when you do dependency property register](https://youtu.be/AyB3yDuZRTo?t=01h35m28s)

[you set up the](https://youtu.be/AyB3yDuZRTo?t=01h35m31s)

[um the metadata for it and oftentimes it](https://youtu.be/AyB3yDuZRTo?t=01h35m34s)

[looks something like this with you know](https://youtu.be/AyB3yDuZRTo?t=01h35m36s)

[property metadata specifying the default](https://youtu.be/AyB3yDuZRTo?t=01h35m37s)

[value of null something thereabouts so](https://youtu.be/AyB3yDuZRTo?t=01h35m39s)

[up here what we would like to do uh this](https://youtu.be/AyB3yDuZRTo?t=01h35m42s)

[is pulling the the default metadata that](https://youtu.be/AyB3yDuZRTo?t=01h35m46s)

[was created for this property](https://youtu.be/AyB3yDuZRTo?t=01h35m49s)

[then we're going to muck with it and](https://youtu.be/AyB3yDuZRTo?t=01h35m51s)

[then we're gonna override it](https://youtu.be/AyB3yDuZRTo?t=01h35m53s)

[that's the game plan](https://youtu.be/AyB3yDuZRTo?t=01h35m55s)

[which would be great](https://youtu.be/AyB3yDuZRTo?t=01h35m57s)

[because even though this metadata is](https://youtu.be/AyB3yDuZRTo?t=01h36m01s)

[stored statically you know uh you'll](https://youtu.be/AyB3yDuZRTo?t=01h36m04s)

[note that there is a owner type that](https://youtu.be/AyB3yDuZRTo?t=01h36m06s)

[goes along with this](https://youtu.be/AyB3yDuZRTo?t=01h36m08s)

[so inside of this dependency uh property](https://youtu.be/AyB3yDuZRTo?t=01h36m09s)

[hierarchy down in dependency object at](https://youtu.be/AyB3yDuZRTo?t=01h36m13s)

[the base level it's keeping track of](https://youtu.be/AyB3yDuZRTo?t=01h36m16s)

[these Source properties and owners](https://youtu.be/AyB3yDuZRTo?t=01h36m18s)

[so we can leverage this](https://youtu.be/AyB3yDuZRTo?t=01h36m21s)

[so that's why we want to change this guy](https://youtu.be/AyB3yDuZRTo?t=01h36m23s)

[and now I'm just trying to think of the](https://youtu.be/AyB3yDuZRTo?t=01h36m26s)

[proper way to](https://youtu.be/AyB3yDuZRTo?t=01h36m28s)

[hook this so that](https://youtu.be/AyB3yDuZRTo?t=01h36m29s)

[these go together](https://youtu.be/AyB3yDuZRTo?t=01h36m32s)

[I think what we want to do is yank this](https://youtu.be/AyB3yDuZRTo?t=01h36m35s)

[up to here to start with](https://youtu.be/AyB3yDuZRTo?t=01h36m36s)

[um and I am wondering if maybe I should](https://youtu.be/AyB3yDuZRTo?t=01h36m39s)

[do](https://youtu.be/AyB3yDuZRTo?t=01h36m42s)

[something more like this](https://youtu.be/AyB3yDuZRTo?t=01h36m45s)

[where I hook it](https://youtu.be/AyB3yDuZRTo?t=01h36m48s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h36m52s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h36m53s)

[like that](https://youtu.be/AyB3yDuZRTo?t=01h36m59s)

[and then we call](https://youtu.be/AyB3yDuZRTo?t=01h37m00s)

[a previous callback](https://youtu.be/AyB3yDuZRTo?t=01h37m03s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=01h37m05s)

[e and e](https://youtu.be/AyB3yDuZRTo?t=01h37m07s)

[no I just noticed that those letters](https://youtu.be/AyB3yDuZRTo?t=01h37m12s)

[come sequentially in the alphabet and](https://youtu.be/AyB3yDuZRTo?t=01h37m13s)

[part of me is now mildly concerned that](https://youtu.be/AyB3yDuZRTo?t=01h37m15s)

[that's the reason they picked those](https://youtu.be/AyB3yDuZRTo?t=01h37m17s)

[letters](https://youtu.be/AyB3yDuZRTo?t=01h37m19s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h37m20s)

[yeah no problem it's one of those cases](https://youtu.be/AyB3yDuZRTo?t=01h37m23s)

[that you really don't specify a lot of](https://youtu.be/AyB3yDuZRTo?t=01h37m25s)

[dependency properties unless you are](https://youtu.be/AyB3yDuZRTo?t=01h37m27s)

[building controls](https://youtu.be/AyB3yDuZRTo?t=01h37m29s)

[um in normally you consume dependency](https://youtu.be/AyB3yDuZRTo?t=01h37m31s)

[properties because they're on the](https://youtu.be/AyB3yDuZRTo?t=01h37m34s)

[controls that you're binding to](https://youtu.be/AyB3yDuZRTo?t=01h37m35s)

[because the the target of a binding](https://youtu.be/AyB3yDuZRTo?t=01h37m39s)

[needs to be a dependency property that's](https://youtu.be/AyB3yDuZRTo?t=01h37m41s)

[how a binding is able to work](https://youtu.be/AyB3yDuZRTo?t=01h37m43s)

[so you've you've certainly consumed them](https://youtu.be/AyB3yDuZRTo?t=01h37m45s)

[in just about any WPF application but](https://youtu.be/AyB3yDuZRTo?t=01h37m47s)

[usually only control authors concern](https://youtu.be/AyB3yDuZRTo?t=01h37m50s)

[themselves with actually creating them](https://youtu.be/AyB3yDuZRTo?t=01h37m53s)

[okay so this guy goes here](https://youtu.be/AyB3yDuZRTo?t=01h37m56s)

[and I think now we have a hijack](https://youtu.be/AyB3yDuZRTo?t=01h37m59s)

[where this goes through](https://youtu.be/AyB3yDuZRTo?t=01h38m03s)

[so we'll just we'll just grab the](https://youtu.be/AyB3yDuZRTo?t=01h38m06s)

[breakpoint here I want to make sure that](https://youtu.be/AyB3yDuZRTo?t=01h38m08s)

[when we fire this up we now grab the](https://youtu.be/AyB3yDuZRTo?t=01h38m09s)

[item source](https://youtu.be/AyB3yDuZRTo?t=01h38m12s)

[because if this if this works this might](https://youtu.be/AyB3yDuZRTo?t=01h38m17s)

[this might be a very clever trick](https://youtu.be/AyB3yDuZRTo?t=01h38m20s)

[I don't know if this works though is the](https://youtu.be/AyB3yDuZRTo?t=01h38m24s)

[problem so](https://youtu.be/AyB3yDuZRTo?t=01h38m26s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=01h38m28s)

[uh cannot change properties metadata](https://youtu.be/AyB3yDuZRTo?t=01h38m31s)

[after it's been associated with the](https://youtu.be/AyB3yDuZRTo?t=01h38m34s)

[property boom](https://youtu.be/AyB3yDuZRTo?t=01h38m36s)

[Okay so](https://youtu.be/AyB3yDuZRTo?t=01h38m41s)

[it doesn't like me mutating it](https://youtu.be/AyB3yDuZRTo?t=01h38m43s)

[fine then fine then I'll create a new](https://youtu.be/AyB3yDuZRTo?t=01h38m47s)

[one](https://youtu.be/AyB3yDuZRTo?t=01h38m50s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h38m52s)

[so this is going to be](https://youtu.be/AyB3yDuZRTo?t=01h38m56s)

[well let's do this](https://youtu.be/AyB3yDuZRTo?t=01h38m58s)

[default metadata](https://youtu.be/AyB3yDuZRTo?t=01h39m01s)

[noise](https://youtu.be/AyB3yDuZRTo?t=01h39m04s)

[uh framework property metadata](https://youtu.be/AyB3yDuZRTo?t=01h39m07s)

[metadata gets new there happy now happy](https://youtu.be/AyB3yDuZRTo?t=01h39m12s)

[we'll make a new one and I'll have to](https://youtu.be/AyB3yDuZRTo?t=01h39m16s)

[copy everything over to it](https://youtu.be/AyB3yDuZRTo?t=01h39m18s)

[it's default metadata](https://youtu.be/AyB3yDuZRTo?t=01h39m21s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h39m24s)

[wait why is this thing](https://youtu.be/AyB3yDuZRTo?t=01h39m28s)

[oh this isn't an assignable property is](https://youtu.be/AyB3yDuZRTo?t=01h39m30s)

[it oh it is but it's going to do the](https://youtu.be/AyB3yDuZRTo?t=01h39m32s)

[flags okay we don't actually care about](https://youtu.be/AyB3yDuZRTo?t=01h39m34s)

[those what we care about is default](https://youtu.be/AyB3yDuZRTo?t=01h39m35s)

[value](https://youtu.be/AyB3yDuZRTo?t=01h39m39s)

[default value](https://youtu.be/AyB3yDuZRTo?t=01h39m41s)

[we care about](https://youtu.be/AyB3yDuZRTo?t=01h39m44s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h39m47s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h39m50s)

[I wish there was a way to grab just the](https://youtu.be/AyB3yDuZRTo?t=01h39m54s)

[non-flagged ones](https://youtu.be/AyB3yDuZRTo?t=01h39m57s)

[okay](https://youtu.be/AyB3yDuZRTo?t=01h39m59s)

[default metadata](https://youtu.be/AyB3yDuZRTo?t=01h40m00s)

[oh because this thing is also](https://youtu.be/AyB3yDuZRTo?t=01h40m04s)

[just giving me property metadata members](https://youtu.be/AyB3yDuZRTo?t=01h40m06s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h40m11s)

[we can](https://youtu.be/AyB3yDuZRTo?t=01h40m12s)

[do this differently let's go into here](https://youtu.be/AyB3yDuZRTo?t=01h40m14s)

[because these are just writing flat](https://youtu.be/AyB3yDuZRTo?t=01h40m17s)

[these are reading and writing Flags](https://youtu.be/AyB3yDuZRTo?t=01h40m19s)

[and ultimately the flags are being set](https://youtu.be/AyB3yDuZRTo?t=01h40m21s)

[under the hood](https://youtu.be/AyB3yDuZRTo?t=01h40m24s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h40m27s)

[yeah I'm kind of tempted to just not](https://youtu.be/AyB3yDuZRTo?t=01h40m34s)

[care](https://youtu.be/AyB3yDuZRTo?t=01h40m36s)

[you know what in the interest of testing](https://youtu.be/AyB3yDuZRTo?t=01h40m37s)

[this](https://youtu.be/AyB3yDuZRTo?t=01h40m39s)

[what we're going to do is we're going to](https://youtu.be/AyB3yDuZRTo?t=01h40m40s)

[set default value and not worry about](https://youtu.be/AyB3yDuZRTo?t=01h40m41s)

[the rest because we don't care about the](https://youtu.be/AyB3yDuZRTo?t=01h40m42s)

[rest we know that that's the only one](https://youtu.be/AyB3yDuZRTo?t=01h40m44s)

[that matters and then this becomes](https://youtu.be/AyB3yDuZRTo?t=01h40m45s)

[default metadata](https://youtu.be/AyB3yDuZRTo?t=01h40m47s)

[and then metadata property change](https://youtu.be/AyB3yDuZRTo?t=01h40m51s)

[callback gets wired up and then we](https://youtu.be/AyB3yDuZRTo?t=01h40m53s)

[overwrite it that way okay](https://youtu.be/AyB3yDuZRTo?t=01h40m55s)

[something like that](https://youtu.be/AyB3yDuZRTo?t=01h40m57s)

[because we know under the hood all the](https://youtu.be/AyB3yDuZRTo?t=01h41m00s)

[places where this is being set](https://youtu.be/AyB3yDuZRTo?t=01h41m02s)

[and I'm not real concerned with WPF](https://youtu.be/AyB3yDuZRTo?t=01h41m06s)

[changing it out](https://youtu.be/AyB3yDuZRTo?t=01h41m09s)

[a risk factor I think we have](https://youtu.be/AyB3yDuZRTo?t=01h41m11s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=01h41m14s)

[default value does not match the type of](https://youtu.be/AyB3yDuZRTo?t=01h41m16s)

[property](https://youtu.be/AyB3yDuZRTo?t=01h41m19s)

[what](https://youtu.be/AyB3yDuZRTo?t=01h41m20s)

[oh uh yeah right uh](https://youtu.be/AyB3yDuZRTo?t=01h41m23s)

[right my bad](https://youtu.be/AyB3yDuZRTo?t=01h41m28s)

[okay come on](https://youtu.be/AyB3yDuZRTo?t=01h41m42s)

[to chess](https://youtu.be/AyB3yDuZRTo?t=01h41m45s)

[slow progress but progress](https://youtu.be/AyB3yDuZRTo?t=01h41m49s)

[okay so there's the tree list View](https://youtu.be/AyB3yDuZRTo?t=01h41m52s)

[we can grab the new property changed](https://youtu.be/AyB3yDuZRTo?t=01h41m55s)

[event arcs](https://youtu.be/AyB3yDuZRTo?t=01h41m57s)

[okay](https://youtu.be/AyB3yDuZRTo?t=01h42m02s)

[so I am curious](https://youtu.be/AyB3yDuZRTo?t=01h42m04s)

[I am very very curious](https://youtu.be/AyB3yDuZRTo?t=01h42m08s)

[uh if](https://youtu.be/AyB3yDuZRTo?t=01h42m12s)

[uh o is](https://youtu.be/AyB3yDuZRTo?t=01h42m15s)

[free list View](https://youtu.be/AyB3yDuZRTo?t=01h42m17s)

[realist View](https://youtu.be/AyB3yDuZRTo?t=01h42m20s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h42m23s)

[let's see](https://youtu.be/AyB3yDuZRTo?t=01h42m24s)

[tree list View](https://youtu.be/AyB3yDuZRTo?t=01h42m26s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h42m29s)

[uh uh let's see](https://youtu.be/AyB3yDuZRTo?t=01h42m32s)

[internal item Source uh](https://youtu.be/AyB3yDuZRTo?t=01h42m34s)

[clear](https://youtu.be/AyB3yDuZRTo?t=01h42m38s)

[and then](https://youtu.be/AyB3yDuZRTo?t=01h42m40s)

[yeah something like that thank you](https://youtu.be/AyB3yDuZRTo?t=01h42m45s)

[co-pilot](https://youtu.be/AyB3yDuZRTo?t=01h42m47s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h42m49s)

[that's creepily accurate](https://youtu.be/AyB3yDuZRTo?t=01h42m54s)

[something to that effect but now I'm](https://youtu.be/AyB3yDuZRTo?t=01h42m58s)

[wondering](https://youtu.be/AyB3yDuZRTo?t=01h43m01s)

[what does it do](https://youtu.be/AyB3yDuZRTo?t=01h43m02s)

[if I](https://youtu.be/AyB3yDuZRTo?t=01h43m07s)

[coalesce it](https://youtu.be/AyB3yDuZRTo?t=01h43m09s)

[does that uh](https://youtu.be/AyB3yDuZRTo?t=01h43m11s)

[or I'm sorry coerce it](https://youtu.be/AyB3yDuZRTo?t=01h43m14s)

[uh gets](https://youtu.be/AyB3yDuZRTo?t=01h43m17s)

[what happens if I return](https://youtu.be/AyB3yDuZRTo?t=01h43m26s)

[free list View](https://youtu.be/AyB3yDuZRTo?t=01h43m31s)

[d](https://youtu.be/AyB3yDuZRTo?t=01h43m34s)

[internal item source](https://youtu.be/AyB3yDuZRTo?t=01h43m36s)

[I just do that](https://youtu.be/AyB3yDuZRTo?t=01h43m38s)

[does that affect the data bound one](https://youtu.be/AyB3yDuZRTo?t=01h43m43s)

[or is that only going to propagate down](https://youtu.be/AyB3yDuZRTo?t=01h43m48s)

[so what we want to look at is movie](https://youtu.be/AyB3yDuZRTo?t=01h43m53s)

[categories](https://youtu.be/AyB3yDuZRTo?t=01h43m55s)

[and I want to make this a get set](https://youtu.be/AyB3yDuZRTo?t=01h43m58s)

[because I want to confirm](https://youtu.be/AyB3yDuZRTo?t=01h44m01s)

[that this doesn't change](https://youtu.be/AyB3yDuZRTo?t=01h44m07s)

[So Pro tip you'll note that I was able](https://youtu.be/AyB3yDuZRTo?t=01h44m12s)

[to set my break point right on the set](https://youtu.be/AyB3yDuZRTo?t=01h44m14s)

[uh or the get typically people think of](https://youtu.be/AyB3yDuZRTo?t=01h44m16s)

[clicking on this bar here for setting](https://youtu.be/AyB3yDuZRTo?t=01h44m19s)

[breakpoints you can actually set break](https://youtu.be/AyB3yDuZRTo?t=01h44m21s)

[points at a much more granular level](https://youtu.be/AyB3yDuZRTo?t=01h44m23s)

[because if you set click here this only](https://youtu.be/AyB3yDuZRTo?t=01h44m25s)

[um sets it per for the entire line but](https://youtu.be/AyB3yDuZRTo?t=01h44m30s)

[sometimes you want to get a lot finer](https://youtu.be/AyB3yDuZRTo?t=01h44m32s)

[down there if you put your cursor where](https://youtu.be/AyB3yDuZRTo?t=01h44m34s)

[you want it to be](https://youtu.be/AyB3yDuZRTo?t=01h44m36s)

[or your carrot and then hit the F9 key](https://youtu.be/AyB3yDuZRTo?t=01h44m38s)

[it'll set a breakpoint at a more](https://youtu.be/AyB3yDuZRTo?t=01h44m41s)

[granular level so for example if I click](https://youtu.be/AyB3yDuZRTo?t=01h44m43s)

[here](https://youtu.be/AyB3yDuZRTo?t=01h44m45s)

[I get a break point that covers that but](https://youtu.be/AyB3yDuZRTo?t=01h44m46s)

[if I put it on the set and hit F9 I get](https://youtu.be/AyB3yDuZRTo?t=01h44m48s)

[a breakpoint that just covers the setter](https://youtu.be/AyB3yDuZRTo?t=01h44m51s)

[okay so this Setter is coming from the](https://youtu.be/AyB3yDuZRTo?t=01h44m53s)

[Constructor we expect that](https://youtu.be/AyB3yDuZRTo?t=01h44m54s)

[okay we are returning item source](https://youtu.be/AyB3yDuZRTo?t=01h44m57s)

[and then what is e dot new value because](https://youtu.be/AyB3yDuZRTo?t=01h45m03s)

[we've](https://youtu.be/AyB3yDuZRTo?t=01h45m05s)

[okay the new value is now coalesce so](https://youtu.be/AyB3yDuZRTo?t=01h45m06s)

[it's now](https://youtu.be/AyB3yDuZRTo?t=01h45m08s)

[much smaller](https://youtu.be/AyB3yDuZRTo?t=01h45m10s)

[object reference not set to the instance](https://youtu.be/AyB3yDuZRTo?t=01h45m14s)

[of an object](https://youtu.be/AyB3yDuZRTo?t=01h45m16s)

[previous](https://youtu.be/AyB3yDuZRTo?t=01h45m21s)

[that's interesting](https://youtu.be/AyB3yDuZRTo?t=01h45m26s)

[I'm going to comment this out for the](https://youtu.be/AyB3yDuZRTo?t=01h45m30s)

[moment because I'm most interested in](https://youtu.be/AyB3yDuZRTo?t=01h45m33s)

[checking](https://youtu.be/AyB3yDuZRTo?t=01h45m36s)

[this and what this ends up doing](https://youtu.be/AyB3yDuZRTo?t=01h45m37s)

[because in the case of the item Source](https://youtu.be/AyB3yDuZRTo?t=01h45m47s)

[binding it's not something that](https://youtu.be/AyB3yDuZRTo?t=01h45m50s)

[anyone expects to be swapped out](https://youtu.be/AyB3yDuZRTo?t=01h45m54s)

[okay so now I want to look at this and](https://youtu.be/AyB3yDuZRTo?t=01h46m01s)

[see so I didn't see the setter called](https://youtu.be/AyB3yDuZRTo?t=01h46m04s)

[there](https://youtu.be/AyB3yDuZRTo?t=01h46m08s)

[but I'm wondering](https://youtu.be/AyB3yDuZRTo?t=01h46m10s)

[no so give me here so I want to see](https://youtu.be/AyB3yDuZRTo?t=01h46m13s)

[treeless View](https://youtu.be/AyB3yDuZRTo?t=01h46m16s)

[item Source right so the item source](https://youtu.be/AyB3yDuZRTo?t=01h46m19s)

[this thing is still bound to the](https://youtu.be/AyB3yDuZRTo?t=01h46m29s)

[oh did it clear the collection](https://youtu.be/AyB3yDuZRTo?t=01h46m34s)

[well that's bad](https://youtu.be/AyB3yDuZRTo?t=01h46m40s)

[moving categories no so it didn't clear](https://youtu.be/AyB3yDuZRTo?t=01h46m46s)

[the collection](https://youtu.be/AyB3yDuZRTo?t=01h46m49s)

[oh that's nice so it knows that the](https://youtu.be/AyB3yDuZRTo?t=01h46m53s)

[items made it in](https://youtu.be/AyB3yDuZRTo?t=01h46m56s)

[but it's a different instance on the](https://youtu.be/AyB3yDuZRTo?t=01h46m58s)

[item Source itself boys that can be](https://youtu.be/AyB3yDuZRTo?t=01h47m00s)

[confusing to all get out to people](https://youtu.be/AyB3yDuZRTo?t=01h47m03s)

[they assigned to the item Source](https://youtu.be/AyB3yDuZRTo?t=01h47m06s)

[property and they get something very](https://youtu.be/AyB3yDuZRTo?t=01h47m08s)

[very different](https://youtu.be/AyB3yDuZRTo?t=01h47m09s)

[that's kind of convenient though](https://youtu.be/AyB3yDuZRTo?t=01h47m13s)

[that's actually really really convenient](https://youtu.be/AyB3yDuZRTo?t=01h47m17s)

[okay](https://youtu.be/AyB3yDuZRTo?t=01h47m23s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h47m25s)

[so let's do it right here if D is](https://youtu.be/AyB3yDuZRTo?t=01h47m27s)

[pre-list View](https://youtu.be/AyB3yDuZRTo?t=01h47m31s)

[we're gonna clean this up a little bit](https://youtu.be/AyB3yDuZRTo?t=01h47m35s)

[uh Return base value so if](https://youtu.be/AyB3yDuZRTo?t=01h47m39s)

[if we aren't in happy case we're just](https://youtu.be/AyB3yDuZRTo?t=01h47m43s)

[gonna](https://youtu.be/AyB3yDuZRTo?t=01h47m45s)

[let the value float through and not not](https://youtu.be/AyB3yDuZRTo?t=01h47m46s)

[stress about it okay so here we're go if](https://youtu.be/AyB3yDuZRTo?t=01h47m48s)

[we find the guy we're gonna grab it but](https://youtu.be/AyB3yDuZRTo?t=01h47m52s)

[we want to do tree list view internal](https://youtu.be/AyB3yDuZRTo?t=01h47m54s)

[item Source clear](https://youtu.be/AyB3yDuZRTo?t=01h47m57s)

[and then](https://youtu.be/AyB3yDuZRTo?t=01h48m01s)

[have you copilot thank you that's](https://youtu.be/AyB3yDuZRTo?t=01h48m03s)

[exactly what I want](https://youtu.be/AyB3yDuZRTo?t=01h48m05s)

[so if we do it here](https://youtu.be/AyB3yDuZRTo?t=01h48m11s)

[and let's relaunch because I think what](https://youtu.be/AyB3yDuZRTo?t=01h48m15s)

[we can do is we can check](https://youtu.be/AyB3yDuZRTo?t=01h48m18s)

[I think snoopal I think Snoop will be](https://youtu.be/AyB3yDuZRTo?t=01h48m21s)

[hip to this it might not we'll see](https://youtu.be/AyB3yDuZRTo?t=01h48m23s)

[because what I'm hoping we can do then](https://youtu.be/AyB3yDuZRTo?t=01h48m30s)

[is inject straight into this](https://youtu.be/AyB3yDuZRTo?t=01h48m32s)

[Okay so we've got that we've got that](https://youtu.be/AyB3yDuZRTo?t=01h48m36s)

[okay so we're just going to keep going](https://youtu.be/AyB3yDuZRTo?t=01h48m39s)

[because I I think this is actually](https://youtu.be/AyB3yDuZRTo?t=01h48m41s)

[working](https://youtu.be/AyB3yDuZRTo?t=01h48m43s)

[I think](https://youtu.be/AyB3yDuZRTo?t=01h48m44s)

[mostly confident](https://youtu.be/AyB3yDuZRTo?t=01h48m46s)

[it's all 50 50. okay so we get the](https://youtu.be/AyB3yDuZRTo?t=01h48m48s)

[children](https://youtu.be/AyB3yDuZRTo?t=01h48m49s)

[we get the index and we do inter](https://youtu.be/AyB3yDuZRTo?t=01h48m51s)

[uh internal item source](https://youtu.be/AyB3yDuZRTo?t=01h48m55s)

[uh insert](https://youtu.be/AyB3yDuZRTo?t=01h49m00s)

[uh actually we're going to do this for](https://youtu.be/AyB3yDuZRTo?t=01h49m03s)

[INT I](https://youtu.be/AyB3yDuZRTo?t=01h49m06s)

[equal to index](https://youtu.be/AyB3yDuZRTo?t=01h49m07s)

[I less than](https://youtu.be/AyB3yDuZRTo?t=01h49m11s)

[uh children.length](https://youtu.be/AyB3yDuZRTo?t=01h49m14s)

[sorry count this is a list I plus plus](https://youtu.be/AyB3yDuZRTo?t=01h49m17s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h49m20s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h49m22s)

[internal item source](https://youtu.be/AyB3yDuZRTo?t=01h49m23s)

[insert I](https://youtu.be/AyB3yDuZRTo?t=01h49m26s)

[actually you know what we're going to go](https://youtu.be/AyB3yDuZRTo?t=01h49m33s)

[from zero I think that'll make our life](https://youtu.be/AyB3yDuZRTo?t=01h49m34s)

[easier and this can be I plus index](https://youtu.be/AyB3yDuZRTo?t=01h49m36s)

[we're gonna grab a children's sub I](https://youtu.be/AyB3yDuZRTo?t=01h49m40s)

[okay](https://youtu.be/AyB3yDuZRTo?t=01h49m46s)

[else](https://youtu.be/AyB3yDuZRTo?t=01h49m48s)

[and this is gonna be so slick if this](https://youtu.be/AyB3yDuZRTo?t=01h49m50s)

[works](https://youtu.be/AyB3yDuZRTo?t=01h49m52s)

[I'm gonna do this do this](https://youtu.be/AyB3yDuZRTo?t=01h49m56s)

[so if an item is collapsed](https://youtu.be/AyB3yDuZRTo?t=01h50m01s)

[we then want to do the same thing](https://youtu.be/AyB3yDuZRTo?t=01h50m06s)

[or int I](https://youtu.be/AyB3yDuZRTo?t=01h50m10s)

[remove at](https://youtu.be/AyB3yDuZRTo?t=01h50m12s)

[index plus one](https://youtu.be/AyB3yDuZRTo?t=01h50m17s)

[okay I probably have it off by one error](https://youtu.be/AyB3yDuZRTo?t=01h50m23s)

[in here somewhere](https://youtu.be/AyB3yDuZRTo?t=01h50m26s)

[if I don't have it off by one error](https://youtu.be/AyB3yDuZRTo?t=01h50m27s)

[somewhere I will be shocked](https://youtu.be/AyB3yDuZRTo?t=01h50m29s)

[however this is what I'm thinking we now](https://youtu.be/AyB3yDuZRTo?t=01h50m31s)

[have an internal observable collection](https://youtu.be/AyB3yDuZRTo?t=01h50m34s)

[we know when an item is being expanded](https://youtu.be/AyB3yDuZRTo?t=01h50m36s)

[we can grab the items children we can](https://youtu.be/AyB3yDuZRTo?t=01h50m38s)

[add it to that internal collection and](https://youtu.be/AyB3yDuZRTo?t=01h50m40s)

[bippity boppity](https://youtu.be/AyB3yDuZRTo?t=01h50m42s)

[it's wrong](https://youtu.be/AyB3yDuZRTo?t=01h50m48s)

[action's now down here rather than up](https://youtu.be/AyB3yDuZRTo?t=01h50m50s)

[here](https://youtu.be/AyB3yDuZRTo?t=01h50m52s)

[now if I Collapse it](https://youtu.be/AyB3yDuZRTo?t=01h50m57s)

[okay it's clearly wrong clearly wrong](https://youtu.be/AyB3yDuZRTo?t=01h51m02s)

[we're off by one right okay](https://youtu.be/AyB3yDuZRTo?t=01h51m04s)

[plus one](https://youtu.be/AyB3yDuZRTo?t=01h51m10s)

[we're gonna start with that we're gonna](https://youtu.be/AyB3yDuZRTo?t=01h51m12s)

[start with the insertion problem](https://youtu.be/AyB3yDuZRTo?t=01h51m13s)

[fix that](https://youtu.be/AyB3yDuZRTo?t=01h51m15s)

[[Laughter]](https://youtu.be/AyB3yDuZRTo?t=01h51m22s)

[it is working it is working](https://youtu.be/AyB3yDuZRTo?t=01h51m24s)

[I'm alive my little one](https://youtu.be/AyB3yDuZRTo?t=01h51m28s)

[and](https://youtu.be/AyB3yDuZRTo?t=01h51m31s)

[yeah](https://youtu.be/AyB3yDuZRTo?t=01h51m33s)

[yeah](https://youtu.be/AyB3yDuZRTo?t=01h51m35s)

[look at that it works](https://youtu.be/AyB3yDuZRTo?t=01h51m40s)

[and I have multi-select](https://youtu.be/AyB3yDuZRTo?t=01h51m45s)

[[Laughter]](https://youtu.be/AyB3yDuZRTo?t=01h51m49s)

[okay so obviously indentation is not](https://youtu.be/AyB3yDuZRTo?t=01h51m55s)

[working yet](https://youtu.be/AyB3yDuZRTo?t=01h51m58s)

[and the showing and the hiding of these](https://youtu.be/AyB3yDuZRTo?t=01h51m59s)

[arrows is not working because the](https://youtu.be/AyB3yDuZRTo?t=01h52m02s)

[typical Tree View interaction has a has](https://youtu.be/AyB3yDuZRTo?t=01h52m04s)

[items property and if something doesn't](https://youtu.be/AyB3yDuZRTo?t=01h52m07s)

[have children](https://youtu.be/AyB3yDuZRTo?t=01h52m10s)

[it then does not show that](https://youtu.be/AyB3yDuZRTo?t=01h52m12s)

[is the standardized Behavior](https://youtu.be/AyB3yDuZRTo?t=01h52m14s)

[we should re-implement that](https://youtu.be/AyB3yDuZRTo?t=01h52m17s)

[so happy](https://youtu.be/AyB3yDuZRTo?t=01h52m20s)

[so happy that works](https://youtu.be/AyB3yDuZRTo?t=01h52m22s)

[so happy that works that was a lot of](https://youtu.be/AyB3yDuZRTo?t=01h52m24s)

[hackiness in order to get](https://youtu.be/AyB3yDuZRTo?t=01h52m26s)

[inserting of three items I just want to](https://youtu.be/AyB3yDuZRTo?t=01h52m29s)

[confirm really quick that in in all of](https://youtu.be/AyB3yDuZRTo?t=01h52m31s)

[this adding of stuff that we haven't](https://youtu.be/AyB3yDuZRTo?t=01h52m35s)

[actually changed the underlying](https://youtu.be/AyB3yDuZRTo?t=01h52m37s)

[collection](https://youtu.be/AyB3yDuZRTo?t=01h52m40s)

[tree list view okay so up at the tree](https://youtu.be/AyB3yDuZRTo?t=01h52m44s)

[list view top level here's our movie](https://youtu.be/AyB3yDuZRTo?t=01h52m47s)

[categories observable collection if we](https://youtu.be/AyB3yDuZRTo?t=01h52m49s)

[open it up it only has two items in it](https://youtu.be/AyB3yDuZRTo?t=01h52m51s)

[yes](https://youtu.be/AyB3yDuZRTo?t=01h52m56s)

[okay how does this break](https://youtu.be/AyB3yDuZRTo?t=01h53m01s)

[this only breaks](https://youtu.be/AyB3yDuZRTo?t=01h53m06s)

[if something assigns to the items](https://youtu.be/AyB3yDuZRTo?t=01h53m09s)

[collection](https://youtu.be/AyB3yDuZRTo?t=01h53m13s)

[and somebody is using a two-way binding](https://youtu.be/AyB3yDuZRTo?t=01h53m14s)

[and expects to get that instance back](https://youtu.be/AyB3yDuZRTo?t=01h53m17s)

[and they're using this control](https://youtu.be/AyB3yDuZRTo?t=01h53m20s)

[that is sufficiently high enough of an](https://youtu.be/AyB3yDuZRTo?t=01h53m24s)

[edge case I don't think I'm going to](https://youtu.be/AyB3yDuZRTo?t=01h53m27s)

[stress about it](https://youtu.be/AyB3yDuZRTo?t=01h53m28s)

[I I don't think I'm gonna stress about](https://youtu.be/AyB3yDuZRTo?t=01h53m30s)

[it okay okay this makes me happy let's](https://youtu.be/AyB3yDuZRTo?t=01h53m32s)

[get rid of the stuff we aren't using](https://youtu.be/AyB3yDuZRTo?t=01h53m35s)

[let's clean up a little clean up here](https://youtu.be/AyB3yDuZRTo?t=01h53m36s)

[real quick](https://youtu.be/AyB3yDuZRTo?t=01h53m38s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h53m41s)

[and let's move this into its own](https://youtu.be/AyB3yDuZRTo?t=01h53m43s)

[function](https://youtu.be/AyB3yDuZRTo?t=01h53m46s)

[uh](https://youtu.be/AyB3yDuZRTo?t=01h53m48s)

[foreign](https://youtu.be/AyB3yDuZRTo?t=01h53m52s)

[so let's do](https://youtu.be/AyB3yDuZRTo?t=01h53m54s)

[no stop it stop it](https://youtu.be/AyB3yDuZRTo?t=01h53m57s)

[uh private static](https://youtu.be/AyB3yDuZRTo?t=01h54m00s)

[object](https://youtu.be/AyB3yDuZRTo?t=01h54m03s)

[the worse uh](https://youtu.be/AyB3yDuZRTo?t=01h54m05s)

[what are we doing uh](https://youtu.be/AyB3yDuZRTo?t=01h54m09s)

[items](https://youtu.be/AyB3yDuZRTo?t=01h54m12s)

[source](https://youtu.be/AyB3yDuZRTo?t=01h54m13s)

[dang you co-pilot you](https://youtu.be/AyB3yDuZRTo?t=01h54m19s)

[I mean yes](https://youtu.be/AyB3yDuZRTo?t=01h54m21s)

[thank you I realized you were smart](https://youtu.be/AyB3yDuZRTo?t=01h54m23s)

[enough to just do exactly what I did](https://youtu.be/AyB3yDuZRTo?t=01h54m25s)

[before but](https://youtu.be/AyB3yDuZRTo?t=01h54m26s)

[okay so this then comes up here and goes](https://youtu.be/AyB3yDuZRTo?t=01h54m30s)

[with](https://youtu.be/AyB3yDuZRTo?t=01h54m32s)

[okay there's also a potential bug if WPF](https://youtu.be/AyB3yDuZRTo?t=01h54m35s)

[changes something under the hood and](https://youtu.be/AyB3yDuZRTo?t=01h54m39s)

[blows away](https://youtu.be/AyB3yDuZRTo?t=01h54m41s)

[any of this stuff in theory we should](https://youtu.be/AyB3yDuZRTo?t=01h54m43s)

[probably be copying over more data but](https://youtu.be/AyB3yDuZRTo?t=01h54m45s)

[you know what for now we're just going](https://youtu.be/AyB3yDuZRTo?t=01h54m47s)

[to do this](https://youtu.be/AyB3yDuZRTo?t=01h54m49s)

[because we know that the Declaration of](https://youtu.be/AyB3yDuZRTo?t=01h54m52s)

[this doesn't add anything](https://youtu.be/AyB3yDuZRTo?t=01h54m54s)

[what is common dependency property](https://youtu.be/AyB3yDuZRTo?t=01h54m58s)

[huh](https://youtu.be/AyB3yDuZRTo?t=01h55m02s)

[no idea what that's used for](https://youtu.be/AyB3yDuZRTo?t=01h55m03s)

[um it's internal so I don't need to know](https://youtu.be/AyB3yDuZRTo?t=01h55m06s)

[okay so that goes like that that goes](https://youtu.be/AyB3yDuZRTo?t=01h55m07s)

[like that](https://youtu.be/AyB3yDuZRTo?t=01h55m10s)

[thus ends the world's most hackiest way](https://youtu.be/AyB3yDuZRTo?t=01h55m12s)

[of doing this and it so works okay so](https://youtu.be/AyB3yDuZRTo?t=01h55m15s)

[now we need to add in](https://youtu.be/AyB3yDuZRTo?t=01h55m19s)

[like has children and](https://youtu.be/AyB3yDuZRTo?t=01h55m22s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=01h55m25s)

[yeah don't need that we need to add](https://youtu.be/AyB3yDuZRTo?t=01h55m27s)

[children and level](https://youtu.be/AyB3yDuZRTo?t=01h55m30s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h55m32s)

[let's start with level because I think](https://youtu.be/AyB3yDuZRTo?t=01h55m33s)

[that will be the easiest so uh prop](https://youtu.be/AyB3yDuZRTo?t=01h55m36s)

[dependency](https://youtu.be/AyB3yDuZRTo?t=01h55m39s)

[uh let's see int](https://youtu.be/AyB3yDuZRTo?t=01h55m41s)

[is level the right word](https://youtu.be/AyB3yDuZRTo?t=01h55m45s)

[what do you call the nesting I guess](https://youtu.be/AyB3yDuZRTo?t=01h55m48s)

[level](https://youtu.be/AyB3yDuZRTo?t=01h55m51s)

[not sure I like it though](https://youtu.be/AyB3yDuZRTo?t=01h55m52s)

[uh 11 is not level so we're we're going](https://youtu.be/AyB3yDuZRTo?t=01h55m55s)

[to use the actual word not something I](https://youtu.be/AyB3yDuZRTo?t=01h55m58s)

[type up uh let's see and this is going](https://youtu.be/AyB3yDuZRTo?t=01h56m00s)

[to be](https://youtu.be/AyB3yDuZRTo?t=01h56m03s)

[this guy here default is zero](https://youtu.be/AyB3yDuZRTo?t=01h56m06s)

[maybe nesting level mode would be better](https://youtu.be/AyB3yDuZRTo?t=01h56m10s)

[nested level](https://youtu.be/AyB3yDuZRTo?t=01h56m12s)

[naming to be determined](https://youtu.be/AyB3yDuZRTo?t=01h56m15s)

[no promises we stick with this okay so](https://youtu.be/AyB3yDuZRTo?t=01h56m18s)

[this guy goes here](https://youtu.be/AyB3yDuZRTo?t=01h56m20s)

[and what we need to know is when we add](https://youtu.be/AyB3yDuZRTo?t=01h56m24s)

[an item in](https://youtu.be/AyB3yDuZRTo?t=01h56m28s)

[because we're just adding in effectively](https://youtu.be/AyB3yDuZRTo?t=01h56m32s)

[view model classes at this point](https://youtu.be/AyB3yDuZRTo?t=01h56m34s)

[we need to know what the level is when](https://youtu.be/AyB3yDuZRTo?t=01h56m38s)

[we create a](https://youtu.be/AyB3yDuZRTo?t=01h56m42s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=01h56m43s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h56m44s)

[uh when we create a container to know](https://youtu.be/AyB3yDuZRTo?t=01h56m46s)

[which one it needs to be at](https://youtu.be/AyB3yDuZRTo?t=01h56m50s)

[is item its own container do we want to](https://youtu.be/AyB3yDuZRTo?t=01h56m58s)

[change this up so that this](https://youtu.be/AyB3yDuZRTo?t=01h57m02s)

[respects level](https://youtu.be/AyB3yDuZRTo?t=01h57m05s)

[would require looking this thing up to](https://youtu.be/AyB3yDuZRTo?t=01h57m07s)

[know its level](https://youtu.be/AyB3yDuZRTo?t=01h57m10s)

[so how are we going to do this so if we](https://youtu.be/AyB3yDuZRTo?t=01h57m11s)

[look at the item](https://youtu.be/AyB3yDuZRTo?t=01h57m14s)

[we can look at the item we can know](https://youtu.be/AyB3yDuZRTo?t=01h57m17s)

[we know where it is we know when we](https://youtu.be/AyB3yDuZRTo?t=01h57m22s)

[expand it and we know the items that we](https://youtu.be/AyB3yDuZRTo?t=01h57m24s)

[add underneath it](https://youtu.be/AyB3yDuZRTo?t=01h57m27s)

[I think we almost have to keep track of](https://youtu.be/AyB3yDuZRTo?t=01h57m30s)

[Levels by index](https://youtu.be/AyB3yDuZRTo?t=01h57m34s)

[trying to think if there's a better way](https://youtu.be/AyB3yDuZRTo?t=01h57m38s)

[to do this](https://youtu.be/AyB3yDuZRTo?t=01h57m40s)

[I think](https://youtu.be/AyB3yDuZRTo?t=01h57m43s)

[I think we're gonna have to do something](https://youtu.be/AyB3yDuZRTo?t=01h57m48s)

[like that](https://youtu.be/AyB3yDuZRTo?t=01h57m50s)

[trying to decide if there's a better way](https://youtu.be/AyB3yDuZRTo?t=01h57m51s)

[I don't necessarily love it](https://youtu.be/AyB3yDuZRTo?t=01h57m58s)

[but it might be the the path of least](https://youtu.be/AyB3yDuZRTo?t=01h58m04s)

[resistance because somewhere we have to](https://youtu.be/AyB3yDuZRTo?t=01h58m06s)

[store](https://youtu.be/AyB3yDuZRTo?t=01h58m10s)

[when we because we know the index is](https://youtu.be/AyB3yDuZRTo?t=01h58m11s)

[under which we're inserting and removing](https://youtu.be/AyB3yDuZRTo?t=01h58m14s)

[and so we could control we we know](https://youtu.be/AyB3yDuZRTo?t=01h58m15s)

[basically](https://youtu.be/AyB3yDuZRTo?t=01h58m19s)

[think what we need is something that](https://youtu.be/AyB3yDuZRTo?t=01h58m20s)

[lives](https://youtu.be/AyB3yDuZRTo?t=01h58m22s)

[alongside internal item source](https://youtu.be/AyB3yDuZRTo?t=01h58m26s)

[and indicates the levels that go with it](https://youtu.be/AyB3yDuZRTo?t=01h58m29s)

[I almost](https://youtu.be/AyB3yDuZRTo?t=01h58m36s)

[I almost want to make something that](https://youtu.be/AyB3yDuZRTo?t=01h58m40s)

[derives from observable collection and](https://youtu.be/AyB3yDuZRTo?t=01h58m42s)

[shove it and keep it all self-contained](https://youtu.be/AyB3yDuZRTo?t=01h58m43s)

[in there](https://youtu.be/AyB3yDuZRTo?t=01h58m46s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h58m49s)

[this is private do your habits we don't](https://youtu.be/AyB3yDuZRTo?t=01h58m50s)

[want that public uh for now I think](https://youtu.be/AyB3yDuZRTo?t=01h58m52s)

[we're just gonna do list of int](https://youtu.be/AyB3yDuZRTo?t=01h58m55s)

[and we'll we'll we'll deal with that](https://youtu.be/AyB3yDuZRTo?t=01h58m57s)

[uh item](https://youtu.be/AyB3yDuZRTo?t=01h59m01s)

[levels](https://youtu.be/AyB3yDuZRTo?t=01h59m03s)

[um](https://youtu.be/AyB3yDuZRTo?t=01h59m11s)

[yeah so this guy here](https://youtu.be/AyB3yDuZRTo?t=01h59m19s)

[every time we insert an item we need to](https://youtu.be/AyB3yDuZRTo?t=01h59m23s)

[go through and](https://youtu.be/AyB3yDuZRTo?t=01h59m26s)

[this is why I kind of want to put](https://youtu.be/AyB3yDuZRTo?t=01h59m29s)

[my own rapper over this but](https://youtu.be/AyB3yDuZRTo?t=01h59m32s)

[um tree list View](https://youtu.be/AyB3yDuZRTo?t=01h59m36s)

[uh item levels](https://youtu.be/AyB3yDuZRTo?t=01h59m38s)

[clear](https://youtu.be/AyB3yDuZRTo?t=01h59m45s)

[and then](https://youtu.be/AyB3yDuZRTo?t=01h59m48s)

[copilot the fact that you did that is](https://youtu.be/AyB3yDuZRTo?t=01h59m52s)

[creepy okay copilot what am I thinking](https://youtu.be/AyB3yDuZRTo?t=01h59m54s)

[about doing right here](https://youtu.be/AyB3yDuZRTo?t=01h59m56s)

[[Laughter]](https://youtu.be/AyB3yDuZRTo?t=01h59m59s)

[oh](https://youtu.be/AyB3yDuZRTo?t=02h00m02s)

[copilot co-pilot copilot Copilot you are](https://youtu.be/AyB3yDuZRTo?t=02h00m05s)

[hysterical](https://youtu.be/AyB3yDuZRTo?t=02h00m09s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h00m11s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=02h00m12s)

[sorry I have to double check and make](https://youtu.be/AyB3yDuZRTo?t=02h00m20s)

[sure that this thing is actually](https://youtu.be/AyB3yDuZRTo?t=02h00m22s)

[doing what I expect so this is looking](https://youtu.be/AyB3yDuZRTo?t=02h00m24s)

[at the item at index](https://youtu.be/AyB3yDuZRTo?t=02h00m26s)

[adding one to it](https://youtu.be/AyB3yDuZRTo?t=02h00m29s)

[that's actually more clever than I had](https://youtu.be/AyB3yDuZRTo?t=02h00m33s)

[thought of okay copilot keep making me](https://youtu.be/AyB3yDuZRTo?t=02h00m35s)

[look dumb](https://youtu.be/AyB3yDuZRTo?t=02h00m38s)

[Kai](https://youtu.be/AyB3yDuZRTo?t=02h00m42s)

[so that works](https://youtu.be/AyB3yDuZRTo?t=02h00m47s)

[so I think then in order to have this](https://youtu.be/AyB3yDuZRTo?t=02h00m57s)

[level property work](https://youtu.be/AyB3yDuZRTo?t=02h00m59s)

[I'm wondering if it should be registered](https://youtu.be/AyB3yDuZRTo?t=02h01m08s)

[as read only](https://youtu.be/AyB3yDuZRTo?t=02h01m10s)

[the problem is so the issue being that](https://youtu.be/AyB3yDuZRTo?t=02h01m14s)

[when lists are virtualized the list view](https://youtu.be/AyB3yDuZRTo?t=02h01m17s)

[item will get reused](https://youtu.be/AyB3yDuZRTo?t=02h01m19s)

[um and so you'll have us so imagine](https://youtu.be/AyB3yDuZRTo?t=02h01m22s)

[you've got a list view with you know 10](https://youtu.be/AyB3yDuZRTo?t=02h01m24s)

[000 items in it you do not want to](https://youtu.be/AyB3yDuZRTo?t=02h01m26s)

[create 10 000 list view items wrapping](https://youtu.be/AyB3yDuZRTo?t=02h01m28s)

[all of that data that's a lot of objects](https://youtu.be/AyB3yDuZRTo?t=02h01m31s)

[and your UI will drag](https://youtu.be/AyB3yDuZRTo?t=02h01m33s)

[so with virtualization turned on what](https://youtu.be/AyB3yDuZRTo?t=02h01m35s)

[happens is it just gets enough list view](https://youtu.be/AyB3yDuZRTo?t=02h01m38s)

[items for the visible area](https://youtu.be/AyB3yDuZRTo?t=02h01m40s)

[and then as you scroll and you know one](https://youtu.be/AyB3yDuZRTo?t=02h01m42s)

[item goes off the top or the bottom it](https://youtu.be/AyB3yDuZRTo?t=02h01m46s)

[just grabs that item and moves it to the](https://youtu.be/AyB3yDuZRTo?t=02h01m47s)

[other side and gives it a new data](https://youtu.be/AyB3yDuZRTo?t=02h01m49s)

[context](https://youtu.be/AyB3yDuZRTo?t=02h01m51s)

[and in our case](https://youtu.be/AyB3yDuZRTo?t=02h01m55s)

[I think we can do it I because I'd kind](https://youtu.be/AyB3yDuZRTo?t=02h02m03s)

[of like to do it at a top level](https://youtu.be/AyB3yDuZRTo?t=02h02m05s)

[item](https://youtu.be/AyB3yDuZRTo?t=02h02m08s)

[container generator](https://youtu.be/AyB3yDuZRTo?t=02h02m11s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h02m18s)

[items changed](https://youtu.be/AyB3yDuZRTo?t=02h02m20s)

[to inform the layout that the items](https://youtu.be/AyB3yDuZRTo?t=02h02m23s)

[collection has changed I don't think](https://youtu.be/AyB3yDuZRTo?t=02h02m25s)

[this fires](https://youtu.be/AyB3yDuZRTo?t=02h02m27s)

[often enough for my purposes but let's](https://youtu.be/AyB3yDuZRTo?t=02h02m29s)

[look at it](https://youtu.be/AyB3yDuZRTo?t=02h02m32s)

[this would be kind of nice to do it at](https://youtu.be/AyB3yDuZRTo?t=02h02m33s)

[this level](https://youtu.be/AyB3yDuZRTo?t=02h02m35s)

[position action](https://youtu.be/AyB3yDuZRTo?t=02h02m37s)

[what is the value of action](https://youtu.be/AyB3yDuZRTo?t=02h02m40s)

[add remove replace](https://youtu.be/AyB3yDuZRTo?t=02h02m45s)

[move reset okay so this is just](https://youtu.be/AyB3yDuZRTo?t=02h02m48s)

[observable collection each stuff this](https://youtu.be/AyB3yDuZRTo?t=02h02m50s)

[might be good enough](https://youtu.be/AyB3yDuZRTo?t=02h02m53s)

[because what I'm thinking here is](https://youtu.be/AyB3yDuZRTo?t=02h02m55s)

[item count action position](https://youtu.be/AyB3yDuZRTo?t=02h03m02s)

[well but then I have to go back and look](https://youtu.be/AyB3yDuZRTo?t=02h03m08s)

[up the](https://youtu.be/AyB3yDuZRTo?t=02h03m11s)

[item](https://youtu.be/AyB3yDuZRTo?t=02h03m13s)

[probably harder than](https://youtu.be/AyB3yDuZRTo?t=02h03m15s)

[probably a lot harder than just watching](https://youtu.be/AyB3yDuZRTo?t=02h03m18s)

[it down here](https://youtu.be/AyB3yDuZRTo?t=02h03m20s)

[because down here what we can do so I](https://youtu.be/AyB3yDuZRTo?t=02h03m23s)

[don't want content print center down](https://youtu.be/AyB3yDuZRTo?t=02h03m25s)

[here what we can do is we can just](https://youtu.be/AyB3yDuZRTo?t=02h03m27s)

[override](https://youtu.be/AyB3yDuZRTo?t=02h03m29s)

[override on](https://youtu.be/AyB3yDuZRTo?t=02h03m31s)

[well but I can't watch the data context](https://youtu.be/AyB3yDuZRTo?t=02h03m37s)

[that runs into the same problem that I](https://youtu.be/AyB3yDuZRTo?t=02h03m40s)

[complained about teleric before because](https://youtu.be/AyB3yDuZRTo?t=02h03m42s)

[the somebody could put the same instance](https://youtu.be/AyB3yDuZRTo?t=02h03m44s)

[of an object into the collection twice](https://youtu.be/AyB3yDuZRTo?t=02h03m48s)

[and we don't and we still want it to](https://youtu.be/AyB3yDuZRTo?t=02h03m51s)

[work even if it's the exact same view](https://youtu.be/AyB3yDuZRTo?t=02h03m53s)

[model behind the scenes in fact let's go](https://youtu.be/AyB3yDuZRTo?t=02h03m55s)

[and do that](https://youtu.be/AyB3yDuZRTo?t=02h03m57s)

[on our demo just just to make sure that](https://youtu.be/AyB3yDuZRTo?t=02h03m59s)

[we don't](https://youtu.be/AyB3yDuZRTo?t=02h04m02s)

[botch this](https://youtu.be/AyB3yDuZRTo?t=02h04m04s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h04m05s)

[uh okay so I want the movies one](https://youtu.be/AyB3yDuZRTo?t=02h04m09s)

[movie categories](https://youtu.be/AyB3yDuZRTo?t=02h04m12s)

[so what we're going to do is we're going](https://youtu.be/AyB3yDuZRTo?t=02h04m15s)

[to go](https://youtu.be/AyB3yDuZRTo?t=02h04m17s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h04m18s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h04m20s)

[movie categories dot add](https://youtu.be/AyB3yDuZRTo?t=02h04m21s)

[movie categories Sub-Zero](https://youtu.be/AyB3yDuZRTo?t=02h04m24s)

[right this is this is the failure case](https://youtu.be/AyB3yDuZRTo?t=02h04m27s)

[that I didn't like about teleric](https://youtu.be/AyB3yDuZRTo?t=02h04m29s)

[is they do dumb stuff where if you slap](https://youtu.be/AyB3yDuZRTo?t=02h04m31s)

[the same instance into the collection](https://youtu.be/AyB3yDuZRTo?t=02h04m34s)

[multiple times](https://youtu.be/AyB3yDuZRTo?t=02h04m36s)

[because they rely on being able to index](https://youtu.be/AyB3yDuZRTo?t=02h04m37s)

[on the item problems occur don't do that](https://youtu.be/AyB3yDuZRTo?t=02h04m40s)

[let me first if you're a control author](https://youtu.be/AyB3yDuZRTo?t=02h04m45s)

[don't do that if you're building](https://youtu.be/AyB3yDuZRTo?t=02h04m47s)

[something for an app you can make all](https://youtu.be/AyB3yDuZRTo?t=02h04m48s)

[kinds of assumptions right so if I](https://youtu.be/AyB3yDuZRTo?t=02h04m50s)

[expand this](https://youtu.be/AyB3yDuZRTo?t=02h04m52s)

[and I expand this it works right it](https://youtu.be/AyB3yDuZRTo?t=02h04m54s)

[knows there's a difference between these](https://youtu.be/AyB3yDuZRTo?t=02h04m58s)

[it knows there's a difference Okay so](https://youtu.be/AyB3yDuZRTo?t=02h05m05s)

[okay we're just gonna leave that there](https://youtu.be/AyB3yDuZRTo?t=02h05m09s)

[for now to make sure to make sure that](https://youtu.be/AyB3yDuZRTo?t=02h05m11s)

[this works appropriately so if that's](https://youtu.be/AyB3yDuZRTo?t=02h05m12s)

[the case](https://youtu.be/AyB3yDuZRTo?t=02h05m15s)

[how do we assign the appropriate level](https://youtu.be/AyB3yDuZRTo?t=02h05m19s)

[I guess we do have to kind of watch the](https://youtu.be/AyB3yDuZRTo?t=02h05m25s)

[item container generator](https://youtu.be/AyB3yDuZRTo?t=02h05m27s)

[I guess we have I I guess we have to do](https://youtu.be/AyB3yDuZRTo?t=02h05m31s)

[that because we can't watch our item](https://youtu.be/AyB3yDuZRTo?t=02h05m34s)

[because it'll get reused we can't watch](https://youtu.be/AyB3yDuZRTo?t=02h05m37s)

[its data context because that's not good](https://youtu.be/AyB3yDuZRTo?t=02h05m39s)

[enough](https://youtu.be/AyB3yDuZRTo?t=02h05m41s)

[so I think we do have to watch this guy](https://youtu.be/AyB3yDuZRTo?t=02h05m45s)

[and this may we may fall apart on this](https://youtu.be/AyB3yDuZRTo?t=02h05m55s)

[but we're gonna we're gonna we're gonna](https://youtu.be/AyB3yDuZRTo?t=02h05m57s)

[work through it](https://youtu.be/AyB3yDuZRTo?t=02h05m58s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h06m00s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=02h06m00s)

[uh wait didn't I have an event args with](https://youtu.be/AyB3yDuZRTo?t=02h06m06s)

[like data](https://youtu.be/AyB3yDuZRTo?t=02h06m09s)

[a second ago](https://youtu.be/AyB3yDuZRTo?t=02h06m10s)

[oh there's items changed](https://youtu.be/AyB3yDuZRTo?t=02h06m18s)

[not status changed](https://youtu.be/AyB3yDuZRTo?t=02h06m21s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h06m25s)

[uh that may not be what I want uh how](https://youtu.be/AyB3yDuZRTo?t=02h06m29s)

[about base Dot](https://youtu.be/AyB3yDuZRTo?t=02h06m32s)

[item container](https://youtu.be/AyB3yDuZRTo?t=02h06m35s)

[should apply item container Style](https://youtu.be/AyB3yDuZRTo?t=02h06m42s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h06m46s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h06m47s)

[on item container style changed style](https://youtu.be/AyB3yDuZRTo?t=02h06m50s)

[selector is item owned container](https://youtu.be/AyB3yDuZRTo?t=02h06m54s)

[yeah so whether it should wrap in one or](https://youtu.be/AyB3yDuZRTo?t=02h06m59s)

[not and then](https://youtu.be/AyB3yDuZRTo?t=02h07m01s)

[his item own container override that's](https://youtu.be/AyB3yDuZRTo?t=02h07m03s)

[not what we want](https://youtu.be/AyB3yDuZRTo?t=02h07m06s)

[that's not what we want](https://youtu.be/AyB3yDuZRTo?t=02h07m11s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h07m16s)

[a container from element](https://youtu.be/AyB3yDuZRTo?t=02h07m25s)

[yeah that's not](https://youtu.be/AyB3yDuZRTo?t=02h07m34s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h07m40s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=02h07m42s)

[is item own container](https://youtu.be/AyB3yDuZRTo?t=02h07m43s)

[clear container for item override get](https://youtu.be/AyB3yDuZRTo?t=02h07m46s)

[container](https://youtu.be/AyB3yDuZRTo?t=02h07m49s)

[for item override](https://youtu.be/AyB3yDuZRTo?t=02h07m50s)

[that's what we did](https://youtu.be/AyB3yDuZRTo?t=02h07m53s)

[how do we get this guy how do we get](https://youtu.be/AyB3yDuZRTo?t=02h07m56s)

[this guy](https://youtu.be/AyB3yDuZRTo?t=02h07m58s)

[we'll find you](https://youtu.be/AyB3yDuZRTo?t=02h08m00s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h08m02s)

[they're from index](https://youtu.be/AyB3yDuZRTo?t=02h08m10s)

[index from container item items changed](https://youtu.be/AyB3yDuZRTo?t=02h08m18s)

[I think that's what we were watching and](https://youtu.be/AyB3yDuZRTo?t=02h08m25s)

[we're gonna we're gonna have to test](https://youtu.be/AyB3yDuZRTo?t=02h08m27s)

[this with virtualization to see if this](https://youtu.be/AyB3yDuZRTo?t=02h08m29s)

[actually works](https://youtu.be/AyB3yDuZRTo?t=02h08m31s)

[okay](https://youtu.be/AyB3yDuZRTo?t=02h08m32s)

[so this comes in here](https://youtu.be/AyB3yDuZRTo?t=02h08m33s)

[uh e Dot](https://youtu.be/AyB3yDuZRTo?t=02h08m36s)

[so we've got a position an item count](https://youtu.be/AyB3yDuZRTo?t=02h08m41s)

[and an action and I'm guessing](https://youtu.be/AyB3yDuZRTo?t=02h08m44s)

[item UI count gets the number of user](https://youtu.be/AyB3yDuZRTo?t=02h08m47s)

[interface items involved in the change](https://youtu.be/AyB3yDuZRTo?t=02h08m49s)

[that's useful](https://youtu.be/AyB3yDuZRTo?t=02h08m55s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h08m58s)

[uh okay so I think we end up doing a](https://youtu.be/AyB3yDuZRTo?t=02h08m59s)

[switch here](https://youtu.be/AyB3yDuZRTo?t=02h09m02s)

[on this guy and it's gonna suck because](https://youtu.be/AyB3yDuZRTo?t=02h09m03s)

[we have to write a bunch of them](https://youtu.be/AyB3yDuZRTo?t=02h09m06s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h09m10s)

[and so we'll start here because this](https://youtu.be/AyB3yDuZRTo?t=02h09m17s)

[will be the easy one](https://youtu.be/AyB3yDuZRTo?t=02h09m20s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h09m22s)

[and then we need to get access to](https://youtu.be/AyB3yDuZRTo?t=02h09m23s)

[let's see so if we go with item](https://youtu.be/AyB3yDuZRTo?t=02h09m29s)

[container generator](https://youtu.be/AyB3yDuZRTo?t=02h09m32s)

[uh container from index](https://youtu.be/AyB3yDuZRTo?t=02h09m34s)

[e dot position](https://youtu.be/AyB3yDuZRTo?t=02h09m37s)

[generator position that's not an INT](https://youtu.be/AyB3yDuZRTo?t=02h09m44s)

[index offset](https://youtu.be/AyB3yDuZRTo?t=02h09m48s)

[uh okay so gitster sets the index that](https://youtu.be/AyB3yDuZRTo?t=02h09m50s)

[is relatively to the generated](https://youtu.be/AyB3yDuZRTo?t=02h09m53s)

[ah](https://youtu.be/AyB3yDuZRTo?t=02h09m56s)

[I want](https://youtu.be/AyB3yDuZRTo?t=02h09m58s)

[wait what](https://youtu.be/AyB3yDuZRTo?t=02h10m04s)

[so](https://youtu.be/AyB3yDuZRTo?t=02h10m07s)

[there's relative to the the realized](https://youtu.be/AyB3yDuZRTo?t=02h10m08s)

[items that's not helpful to me](https://youtu.be/AyB3yDuZRTo?t=02h10m11s)

[gets or sets the offset that is relative](https://youtu.be/AyB3yDuZRTo?t=02h10m17s)

[to the ungenerated](https://youtu.be/AyB3yDuZRTo?t=02h10m20s)

[unrealized items](https://youtu.be/AyB3yDuZRTo?t=02h10m22s)

[near the indexed item](https://youtu.be/AyB3yDuZRTo?t=02h10m27s)

[huh](https://youtu.be/AyB3yDuZRTo?t=02h10m30s)

[how do I just get](https://youtu.be/AyB3yDuZRTo?t=02h10m32s)

[absolute position](https://youtu.be/AyB3yDuZRTo?t=02h10m34s)

[here well I'm I'm confused](https://youtu.be/AyB3yDuZRTo?t=02h10m37s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h10m41s)

[uh okay item changed event arcs the](https://youtu.be/AyB3yDuZRTo?t=02h10m43s)

[Googles need to answer this for me](https://youtu.be/AyB3yDuZRTo?t=02h10m46s)

[or co-pilot needs to write the code one](https://youtu.be/AyB3yDuZRTo?t=02h10m49s)

[of the two](https://youtu.be/AyB3yDuZRTo?t=02h10m51s)

[okay explain yourself](https://youtu.be/AyB3yDuZRTo?t=02h10m54s)

[uh item container generator interface](https://youtu.be/AyB3yDuZRTo?t=02h10m58s)

[yep yep we know all that](https://youtu.be/AyB3yDuZRTo?t=02h11m03s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h11m10s)

[remove all](https://youtu.be/AyB3yDuZRTo?t=02h11m15s)

[the generate generate position from](https://youtu.be/AyB3yDuZRTo?t=02h11m19s)

[get item](https://youtu.be/AyB3yDuZRTo?t=02h11m22s)

[oh hang on can we that's not what we](https://youtu.be/AyB3yDuZRTo?t=02h11m26s)

[want](https://youtu.be/AyB3yDuZRTo?t=02h11m29s)

[index from oh index from generator](https://youtu.be/AyB3yDuZRTo?t=02h11m30s)

[position](https://youtu.be/AyB3yDuZRTo?t=02h11m32s)

[that will get us oh so this thing takes](https://youtu.be/AyB3yDuZRTo?t=02h11m37s)

[in a generator position oh](https://youtu.be/AyB3yDuZRTo?t=02h11m39s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h11m42s)

[oh](https://youtu.be/AyB3yDuZRTo?t=02h11m44s)

[index from generator position okay so we](https://youtu.be/AyB3yDuZRTo?t=02h11m47s)

[can get we can do it that way so we can](https://youtu.be/AyB3yDuZRTo?t=02h11m49s)

[go](https://youtu.be/AyB3yDuZRTo?t=02h11m51s)

[and index gets uh item contained in](https://youtu.be/AyB3yDuZRTo?t=02h11m52s)

[uh index](https://youtu.be/AyB3yDuZRTo?t=02h11m56s)

[wait what](https://youtu.be/AyB3yDuZRTo?t=02h12m00s)

[am I in the wrong framework or something](https://youtu.be/AyB3yDuZRTo?t=02h12m03s)

[item container generator interface](https://youtu.be/AyB3yDuZRTo?t=02h12m08s)

[get item](https://youtu.be/AyB3yDuZRTo?t=02h12m12s)

[index from generator position](https://youtu.be/AyB3yDuZRTo?t=02h12m14s)

[index from generator position](https://youtu.be/AyB3yDuZRTo?t=02h12m17s)

[what is the type of my object](https://youtu.be/AyB3yDuZRTo?t=02h12m21s)

[oh it's not the interface](https://youtu.be/AyB3yDuZRTo?t=02h12m26s)

[did you explicitly implement it to make](https://youtu.be/AyB3yDuZRTo?t=02h12m34s)

[my life hard](https://youtu.be/AyB3yDuZRTo?t=02h12m37s)

[uh if you did I'm gonna be a little](https://youtu.be/AyB3yDuZRTo?t=02h12m41s)

[annoyed](https://youtu.be/AyB3yDuZRTo?t=02h12m43s)

[item container generator you did](https://youtu.be/AyB3yDuZRTo?t=02h12m45s)

[you explicitly implemented it](https://youtu.be/AyB3yDuZRTo?t=02h12m52s)

[jerks](https://youtu.be/AyB3yDuZRTo?t=02h12m55s)

[doesn't prevent me from calling it it](https://youtu.be/AyB3yDuZRTo?t=02h12m57s)

[just annoyed me](https://youtu.be/AyB3yDuZRTo?t=02h12m59s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h13m01s)

[now I'm looking to see if there's](https://youtu.be/AyB3yDuZRTo?t=02h13m04s)

[something even more fun to play with](https://youtu.be/AyB3yDuZRTo?t=02h13m05s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h13m08s)

[uh no](https://youtu.be/AyB3yDuZRTo?t=02h13m10s)

[yeah so I want index generator position](https://youtu.be/AyB3yDuZRTo?t=02h13m15s)

[is what I want](https://youtu.be/AyB3yDuZRTo?t=02h13m17s)

[and I'd like to do this maneuver](https://youtu.be/AyB3yDuZRTo?t=02h13m19s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=02h13m23s)

[uh we're gonna call it generator](https://youtu.be/AyB3yDuZRTo?t=02h13m27s)

[gets uh uh item container generator](https://youtu.be/AyB3yDuZRTo?t=02h13m32s)

[and now we can do](https://youtu.be/AyB3yDuZRTo?t=02h13m38s)

[uh generator uh](https://youtu.be/AyB3yDuZRTo?t=02h13m41s)

[index from generation position e dot](https://youtu.be/AyB3yDuZRTo?t=02h13m44s)

[position](https://youtu.be/AyB3yDuZRTo?t=02h13m47s)

[goodness uh container from index](https://youtu.be/AyB3yDuZRTo?t=02h13m49s)

[index](https://youtu.be/AyB3yDuZRTo?t=02h13m53s)

[uh if container from index is three list](https://youtu.be/AyB3yDuZRTo?t=02h13m55s)

[view item](https://youtu.be/AyB3yDuZRTo?t=02h14m00s)

[uh tree list view item](https://youtu.be/AyB3yDuZRTo?t=02h14m02s)

[then we will do tree list view item](https://youtu.be/AyB3yDuZRTo?t=02h14m06s)

[level gets](https://youtu.be/AyB3yDuZRTo?t=02h14m09s)

[that](https://youtu.be/AyB3yDuZRTo?t=02h14m13s)

[okay](https://youtu.be/AyB3yDuZRTo?t=02h14m15s)

[okay so that gets that gets us to there](https://youtu.be/AyB3yDuZRTo?t=02h14m19s)

[let's make sure this much at least works](https://youtu.be/AyB3yDuZRTo?t=02h14m22s)

[because if we can at least have the](https://youtu.be/AyB3yDuZRTo?t=02h14m31s)

[level property set even if the style](https://youtu.be/AyB3yDuZRTo?t=02h14m33s)

[isn't appropriately indenting it](https://youtu.be/AyB3yDuZRTo?t=02h14m35s)

[that's a simple thing to do](https://youtu.be/AyB3yDuZRTo?t=02h14m37s)

[right we can we can slap on some](https://youtu.be/AyB3yDuZRTo?t=02h14m40s)

[external margin or something we're going](https://youtu.be/AyB3yDuZRTo?t=02h14m42s)

[to expand this out we're going to come](https://youtu.be/AyB3yDuZRTo?t=02h14m44s)

[in here](https://youtu.be/AyB3yDuZRTo?t=02h14m46s)

[and we're just going to go and look at](https://youtu.be/AyB3yDuZRTo?t=02h14m47s)

[the items](https://youtu.be/AyB3yDuZRTo?t=02h14m49s)

[so action](https://youtu.be/AyB3yDuZRTo?t=02h14m51s)

[right so we come in here we go up to the](https://youtu.be/AyB3yDuZRTo?t=02h14m54s)

[uh the tree view item which is here](https://youtu.be/AyB3yDuZRTo?t=02h14m57s)

[and we go level](https://youtu.be/AyB3yDuZRTo?t=02h15m02s)

[zero okay great so action should be at](https://youtu.be/AyB3yDuZRTo?t=02h15m06s)

[level zero great Predator should be at](https://youtu.be/AyB3yDuZRTo?t=02h15m09s)

[level one](https://youtu.be/AyB3yDuZRTo?t=02h15m11s)

[it's not neither is that neither is that](https://youtu.be/AyB3yDuZRTo?t=02h15m12s)

[great none of this worked](https://youtu.be/AyB3yDuZRTo?t=02h15m15s)

[excellent excellent I was worried it](https://youtu.be/AyB3yDuZRTo?t=02h15m17s)

[might actually work that would have made](https://youtu.be/AyB3yDuZRTo?t=02h15m20s)

[it too easy](https://youtu.be/AyB3yDuZRTo?t=02h15m22s)

[so we're gonna figure out where we fell](https://youtu.be/AyB3yDuZRTo?t=02h15m24s)

[apart](https://youtu.be/AyB3yDuZRTo?t=02h15m26s)

[okay](https://youtu.be/AyB3yDuZRTo?t=02h15m29s)

[we got a reset call](https://youtu.be/AyB3yDuZRTo?t=02h15m31s)

[uh with a](https://youtu.be/AyB3yDuZRTo?t=02h15m35s)

[position of zero zero old position of](https://youtu.be/AyB3yDuZRTo?t=02h15m39s)

[unset](https://youtu.be/AyB3yDuZRTo?t=02h15m42s)

[I'm just gonna pin a couple of these](https://youtu.be/AyB3yDuZRTo?t=02h15m43s)

[values so that I can keep track of them](https://youtu.be/AyB3yDuZRTo?t=02h15m45s)

[okay go](https://youtu.be/AyB3yDuZRTo?t=02h15m48s)

[so we got one reset and then never again](https://youtu.be/AyB3yDuZRTo?t=02h15m51s)

[excellent](https://youtu.be/AyB3yDuZRTo?t=02h15m54s)

[hold on there's the ad](https://youtu.be/AyB3yDuZRTo?t=02h15m56s)

[on expansion it did know that it needed](https://youtu.be/AyB3yDuZRTo?t=02h16m00s)

[to add](https://youtu.be/AyB3yDuZRTo?t=02h16m02s)

[and the the Genera the edot position](https://youtu.be/AyB3yDuZRTo?t=02h16m05s)

[is index zero offset one](https://youtu.be/AyB3yDuZRTo?t=02h16m09s)

[which gave me an index of one](https://youtu.be/AyB3yDuZRTo?t=02h16m13s)

[and the get container for index](https://youtu.be/AyB3yDuZRTo?t=02h16m16s)

[this didn't return a tree list view item](https://youtu.be/AyB3yDuZRTo?t=02h16m23s)

[which surprises me](https://youtu.be/AyB3yDuZRTo?t=02h16m27s)

[let's check the return here](https://youtu.be/AyB3yDuZRTo?t=02h16m30s)

[so that guy did not return one](https://youtu.be/AyB3yDuZRTo?t=02h16m33s)

[despite the fact that he knows what's](https://youtu.be/AyB3yDuZRTo?t=02h16m38s)

[there](https://youtu.be/AyB3yDuZRTo?t=02h16m41s)

[um let's see](https://youtu.be/AyB3yDuZRTo?t=02h16m44s)

[wait how does](https://youtu.be/AyB3yDuZRTo?t=02h16m52s)

[what's this level property](https://youtu.be/AyB3yDuZRTo?t=02h16m56s)

[interesting](https://youtu.be/AyB3yDuZRTo?t=02h16m59s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h17m03s)

[status containers generated](https://youtu.be/AyB3yDuZRTo?t=02h17m04s)

[items read only](https://youtu.be/AyB3yDuZRTo?t=02h17m15s)

[what are you](https://youtu.be/AyB3yDuZRTo?t=02h17m25s)

[controls items container generator](https://youtu.be/AyB3yDuZRTo?t=02h17m28s)

[I'm curious](https://youtu.be/AyB3yDuZRTo?t=02h17m33s)

[rather than fighting with you can I just](https://youtu.be/AyB3yDuZRTo?t=02h17m36s)

[you're you're a strongly typed class](https://youtu.be/AyB3yDuZRTo?t=02h17m42s)

[that doesn't appear to have an easy](https://youtu.be/AyB3yDuZRTo?t=02h17m46s)

[assignment operator](https://youtu.be/AyB3yDuZRTo?t=02h17m48s)

[and you're a sealed class excellent](https://youtu.be/AyB3yDuZRTo?t=02h17m50s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h17m55s)

[I really really really want to know how](https://youtu.be/AyB3yDuZRTo?t=02h17m58s)

[to get access](https://youtu.be/AyB3yDuZRTo?t=02h18m01s)

[is this the right way of doing it](https://youtu.be/AyB3yDuZRTo?t=02h18m06s)

[I think the answer is yes](https://youtu.be/AyB3yDuZRTo?t=02h18m11s)

[in](https://youtu.be/AyB3yDuZRTo?t=02h18m16s)

[and I guess up here is item level set up](https://youtu.be/AyB3yDuZRTo?t=02h18m17s)

[appropriately](https://youtu.be/AyB3yDuZRTo?t=02h18m20s)

[so item levels isn't set properly either](https://youtu.be/AyB3yDuZRTo?t=02h18m22s)

[so it really doesn't matter the fact](https://youtu.be/AyB3yDuZRTo?t=02h18m27s)

[that we didn't get in here because we](https://youtu.be/AyB3yDuZRTo?t=02h18m28s)

[didn't set this up](https://youtu.be/AyB3yDuZRTo?t=02h18m30s)

[properly](https://youtu.be/AyB3yDuZRTo?t=02h18m32s)

[oh because we did these](https://youtu.be/AyB3yDuZRTo?t=02h18m37s)

[backwards](https://youtu.be/AyB3yDuZRTo?t=02h18m40s)

[okay so hold on hold on if that's the](https://youtu.be/AyB3yDuZRTo?t=02h18m45s)

[case](https://youtu.be/AyB3yDuZRTo?t=02h18m47s)

[you remove first](https://youtu.be/AyB3yDuZRTo?t=02h18m51s)

[this one doesn't matter whether you](https://youtu.be/AyB3yDuZRTo?t=02h18m54s)

[remove first or second so we're going to](https://youtu.be/AyB3yDuZRTo?t=02h18m55s)

[do them both first for consistency](https://youtu.be/AyB3yDuZRTo?t=02h18m57s)

[because now this should have](https://youtu.be/AyB3yDuZRTo?t=02h19m00s)

[just editing that items collection](https://youtu.be/AyB3yDuZRTo?t=02h19m04s)

[yeah I think that's fine](https://youtu.be/AyB3yDuZRTo?t=02h19m17s)

[okay generate position reset fine](https://youtu.be/AyB3yDuZRTo?t=02h19m25s)

[we expand](https://youtu.be/AyB3yDuZRTo?t=02h19m29s)

[comedy](https://youtu.be/AyB3yDuZRTo?t=02h19m31s)

[and we check the items levels this one](https://youtu.be/AyB3yDuZRTo?t=02h19m33s)

[has a five with a one in there which is](https://youtu.be/AyB3yDuZRTo?t=02h19m35s)

[exactly what we expect internal item](https://youtu.be/AyB3yDuZRTo?t=02h19m38s)

[Source has a five with that guy there](https://youtu.be/AyB3yDuZRTo?t=02h19m40s)

[that's what we expect](https://youtu.be/AyB3yDuZRTo?t=02h19m43s)

[now I don't think that changes the fact](https://youtu.be/AyB3yDuZRTo?t=02h19m45s)

[that](https://youtu.be/AyB3yDuZRTo?t=02h19m48s)

[item container generator didn't assign](https://youtu.be/AyB3yDuZRTo?t=02h19m49s)

[therefore it's not going to land on](https://youtu.be/AyB3yDuZRTo?t=02h19m54s)

[anything](https://youtu.be/AyB3yDuZRTo?t=02h19m56s)

[because it clearly hasn't generated this](https://youtu.be/AyB3yDuZRTo?t=02h20m00s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h20m05s)

[a host](https://youtu.be/AyB3yDuZRTo?t=02h20m07s)

[I'm just confused as to why it's not](https://youtu.be/AyB3yDuZRTo?t=02h20m09s)

[giving me back my container](https://youtu.be/AyB3yDuZRTo?t=02h20m11s)

[uh what is this items](https://youtu.be/AyB3yDuZRTo?t=02h20m15s)

[that's the items behind it](https://youtu.be/AyB3yDuZRTo?t=02h20m17s)

[EMS changed](https://youtu.be/AyB3yDuZRTo?t=02h20m21s)

[items internal](https://youtu.be/AyB3yDuZRTo?t=02h20m26s)

[map peer recyclable containers it's not](https://youtu.be/AyB3yDuZRTo?t=02h20m29s)

[recycling anything](https://youtu.be/AyB3yDuZRTo?t=02h20m32s)

[then](https://youtu.be/AyB3yDuZRTo?t=02h20m35s)

[does that mean all of these new ones are](https://youtu.be/AyB3yDuZRTo?t=02h20m37s)

[about to trigger here](https://youtu.be/AyB3yDuZRTo?t=02h20m39s)

[and here](https://youtu.be/AyB3yDuZRTo?t=02h20m43s)

[they are](https://youtu.be/AyB3yDuZRTo?t=02h20m48s)

[so that move okay so the movie objects](https://youtu.be/AyB3yDuZRTo?t=02h20m53s)

[coming in](https://youtu.be/AyB3yDuZRTo?t=02h20m56s)

[but we don't know](https://youtu.be/AyB3yDuZRTo?t=02h21m01s)

[because this guy here is doing on items](https://youtu.be/AyB3yDuZRTo?t=02h21m08s)

[changed](https://youtu.be/AyB3yDuZRTo?t=02h21m11s)

[because this guy is keeping track of](https://youtu.be/AyB3yDuZRTo?t=02h21m15s)

[that](https://youtu.be/AyB3yDuZRTo?t=02h21m17s)

[and he's got a massive switch doing all](https://youtu.be/AyB3yDuZRTo?t=02h21m20s)

[kinds of stuff](https://youtu.be/AyB3yDuZRTo?t=02h21m23s)

[but we could get in on this action too](https://youtu.be/AyB3yDuZRTo?t=02h21m29s)

[get is selected](https://youtu.be/AyB3yDuZRTo?t=02h21m34s)

[selector](https://youtu.be/AyB3yDuZRTo?t=02h21m38s)

[info get is selected so it's going to](https://youtu.be/AyB3yDuZRTo?t=02h21m41s)

[come in here](https://youtu.be/AyB3yDuZRTo?t=02h21m43s)

[it's looking to pull out this info](https://youtu.be/AyB3yDuZRTo?t=02h21m47s)

[where did that info come from](https://youtu.be/AyB3yDuZRTo?t=02h21m53s)

[info came from here](https://youtu.be/AyB3yDuZRTo?t=02h21m55s)

[git is selected](https://youtu.be/AyB3yDuZRTo?t=02h22m00s)

[so it looks for a container if the](https://youtu.be/AyB3yDuZRTo?t=02h22m04s)

[container has it](https://youtu.be/AyB3yDuZRTo?t=02h22m06s)

[selection changed is this something I](https://youtu.be/AyB3yDuZRTo?t=02h22m12s)

[can watch](https://youtu.be/AyB3yDuZRTo?t=02h22m16s)

[I don't think it I'm only bet it's not](https://youtu.be/AyB3yDuZRTo?t=02h22m19s)

[yeah this guy is that's just keeping](https://youtu.be/AyB3yDuZRTo?t=02h22m22s)

[track of the selection](https://youtu.be/AyB3yDuZRTo?t=02h22m25s)

[removes from selection adjust new](https://youtu.be/AyB3yDuZRTo?t=02h22m33s)

[containers](https://youtu.be/AyB3yDuZRTo?t=02h22m36s)

[but where does the container get added](https://youtu.be/AyB3yDuZRTo?t=02h22m40s)

[is what I'm missing](https://youtu.be/AyB3yDuZRTo?t=02h22m42s)

[so this has brought in items changed](https://youtu.be/AyB3yDuZRTo?t=02h22m44s)

[reset items algorithm great](https://youtu.be/AyB3yDuZRTo?t=02h22m48s)

[of course set items with value](https://youtu.be/AyB3yDuZRTo?t=02h22m53s)

[wow that's that's some heck of a bit](https://youtu.be/AyB3yDuZRTo?t=02h22m59s)

[wise operators](https://youtu.be/AyB3yDuZRTo?t=02h23m01s)

[if it's an addition check it if it's](https://youtu.be/AyB3yDuZRTo?t=02h23m04s)

[selected and select if it is](https://youtu.be/AyB3yDuZRTo?t=02h23m07s)

[so this is all on selection stuff but](https://youtu.be/AyB3yDuZRTo?t=02h23m14s)

[where do you actually well this is the](https://youtu.be/AyB3yDuZRTo?t=02h23m16s)

[selector that's why](https://youtu.be/AyB3yDuZRTo?t=02h23m19s)

[we're all the way down in selector](https://youtu.be/AyB3yDuZRTo?t=02h23m21s)

[list view on items changed](https://youtu.be/AyB3yDuZRTo?t=02h23m24s)

[something's weird so from there](https://youtu.be/AyB3yDuZRTo?t=02h23m34s)

[so this line is wrong it's actually](https://youtu.be/AyB3yDuZRTo?t=02h23m40s)

[calling base](https://youtu.be/AyB3yDuZRTo?t=02h23m42s)

[this base is the selector and selector](https://youtu.be/AyB3yDuZRTo?t=02h23m46s)

[is then doing this work](https://youtu.be/AyB3yDuZRTo?t=02h23m49s)

[to figure out if it is](https://youtu.be/AyB3yDuZRTo?t=02h23m51s)

[going in there](https://youtu.be/AyB3yDuZRTo?t=02h23m56s)

[uh let's see on view collection changed](https://youtu.be/AyB3yDuZRTo?t=02h24m01s)

[so we did there we raised the collection](https://youtu.be/AyB3yDuZRTo?t=02h24m11s)

[changed he's watching The Collection](https://youtu.be/AyB3yDuZRTo?t=02h24m14s)

[changed that propagates down into cross](https://youtu.be/AyB3yDuZRTo?t=02h24m16s)

[and the process collection change which](https://youtu.be/AyB3yDuZRTo?t=02h24m20s)

[goes into process collection change](https://youtu.be/AyB3yDuZRTo?t=02h24m23s)

[which comes in here it's going to notify](https://youtu.be/AyB3yDuZRTo?t=02h24m26s)

[comes up here on collection changed](https://youtu.be/AyB3yDuZRTo?t=02h24m30s)

[deliver event listen](https://youtu.be/AyB3yDuZRTo?t=02h24m33s)

[on view collection changed and validate](https://youtu.be/AyB3yDuZRTo?t=02h24m36s)

[innumerable wrapper](https://youtu.be/AyB3yDuZRTo?t=02h24m40s)

[I want to know where at what point it](https://youtu.be/AyB3yDuZRTo?t=02h24m47s)

[calls into](https://youtu.be/AyB3yDuZRTo?t=02h24m50s)

[into the items container generator to](https://youtu.be/AyB3yDuZRTo?t=02h24m55s)

[get new items](https://youtu.be/AyB3yDuZRTo?t=02h24m58s)

[or to assign it to an item](https://youtu.be/AyB3yDuZRTo?t=02h24m59s)

[because that's got to be in items](https://youtu.be/AyB3yDuZRTo?t=02h25m11s)

[collection right](https://youtu.be/AyB3yDuZRTo?t=02h25m14s)

[on view changed](https://youtu.be/AyB3yDuZRTo?t=02h25m16s)

[apply](https://youtu.be/AyB3yDuZRTo?t=02h25m21s)

[default style key](https://youtu.be/AyB3yDuZRTo?t=02h25m25s)

[uh what is this invoked](https://youtu.be/AyB3yDuZRTo?t=02h25m31s)

[show me that](https://youtu.be/AyB3yDuZRTo?t=02h25m35s)

[on view changed so that's not helpful to](https://youtu.be/AyB3yDuZRTo?t=02h25m38s)

[us because that's](https://youtu.be/AyB3yDuZRTo?t=02h25m40s)

[not something we are going to be](https://youtu.be/AyB3yDuZRTo?t=02h25m42s)

[leveraging](https://youtu.be/AyB3yDuZRTo?t=02h25m44s)

[uh uh item container refresh](https://youtu.be/AyB3yDuZRTo?t=02h25m46s)

[please don't be an internal member](https://youtu.be/AyB3yDuZRTo?t=02h25m50s)

[default style key](https://youtu.be/AyB3yDuZRTo?t=02h25m55s)

[items changed where do you do this](https://youtu.be/AyB3yDuZRTo?t=02h25m58s)

[repair container for item override](https://youtu.be/AyB3yDuZRTo?t=02h26m03s)

[oh](https://youtu.be/AyB3yDuZRTo?t=02h26m06s)

[we can do it right there](https://youtu.be/AyB3yDuZRTo?t=02h26m12s)

[yeah we can do it right okay oh oh oh](https://youtu.be/AyB3yDuZRTo?t=02h26m17s)

[this is easy Ben](https://youtu.be/AyB3yDuZRTo?t=02h26m20s)

[this is easy then okay okay okay](https://youtu.be/AyB3yDuZRTo?t=02h26m22s)

[uh close a bunch of stuff](https://youtu.be/AyB3yDuZRTo?t=02h26m26s)

[so we want](https://youtu.be/AyB3yDuZRTo?t=02h26m30s)

[this](https://youtu.be/AyB3yDuZRTo?t=02h26m32s)

[okay](https://youtu.be/AyB3yDuZRTo?t=02h26m35s)

[so this will give us our element this](https://youtu.be/AyB3yDuZRTo?t=02h26m36s)

[will also give us our individual items](https://youtu.be/AyB3yDuZRTo?t=02h26m39s)

[so if element is uh and we really should](https://youtu.be/AyB3yDuZRTo?t=02h26m41s)

[make this notable](https://youtu.be/AyB3yDuZRTo?t=02h26m45s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h26m47s)

[uh pre list view item](https://youtu.be/AyB3yDuZRTo?t=02h26m49s)

[previous View item](https://youtu.be/AyB3yDuZRTo?t=02h26m52s)

[at this point we should be able to get](https://youtu.be/AyB3yDuZRTo?t=02h26m55s)

[this guy's index so this should now be](https://youtu.be/AyB3yDuZRTo?t=02h26m58s)

[able to do](https://youtu.be/AyB3yDuZRTo?t=02h27m02s)

[uh this logic](https://youtu.be/AyB3yDuZRTo?t=02h27m04s)

[uh well](https://youtu.be/AyB3yDuZRTo?t=02h27m09s)

[no not that logic since we have the item](https://youtu.be/AyB3yDuZRTo?t=02h27m11s)

[we should be able to go uh index from](https://youtu.be/AyB3yDuZRTo?t=02h27m14s)

[container](https://youtu.be/AyB3yDuZRTo?t=02h27m17s)

[green list view item](https://youtu.be/AyB3yDuZRTo?t=02h27m18s)

[uh int index](https://youtu.be/AyB3yDuZRTo?t=02h27m20s)

[and then from here we should be able to](https://youtu.be/AyB3yDuZRTo?t=02h27m22s)

[leverage our](https://youtu.be/AyB3yDuZRTo?t=02h27m25s)

[levels thank you](https://youtu.be/AyB3yDuZRTo?t=02h27m27s)

[and assign it so that should do what we](https://youtu.be/AyB3yDuZRTo?t=02h27m30s)

[want and then we don't need this garbage](https://youtu.be/AyB3yDuZRTo?t=02h27m33s)

[anymore](https://youtu.be/AyB3yDuZRTo?t=02h27m34s)

[I like that better that](https://youtu.be/AyB3yDuZRTo?t=02h27m36s)

[yes because this should get invoked in](https://youtu.be/AyB3yDuZRTo?t=02h27m39s)

[data virtualization where it brings the](https://youtu.be/AyB3yDuZRTo?t=02h27m43s)

[container around from the side that it's](https://youtu.be/AyB3yDuZRTo?t=02h27m45s)

[scrolled off of to bring it around to](https://youtu.be/AyB3yDuZRTo?t=02h27m47s)

[the front this is where the item gets](https://youtu.be/AyB3yDuZRTo?t=02h27m49s)

[assigned and it's repopulated yes yes](https://youtu.be/AyB3yDuZRTo?t=02h27m51s)

[yes yes yes yes yes](https://youtu.be/AyB3yDuZRTo?t=02h27m53s)

[okay kill these break points because I](https://youtu.be/AyB3yDuZRTo?t=02h27m55s)

[don't want to pause every two seconds](https://youtu.be/AyB3yDuZRTo?t=02h27m56s)

[okay prepare container for override](https://youtu.be/AyB3yDuZRTo?t=02h28m00s)

[that's only going to hit four times I](https://youtu.be/AyB3yDuZRTo?t=02h28m02s)

[think](https://youtu.be/AyB3yDuZRTo?t=02h28m04s)

[we only have four items great](https://youtu.be/AyB3yDuZRTo?t=02h28m05s)

[oh we didn't call the base so we've](https://youtu.be/AyB3yDuZRTo?t=02h28m09s)

[broken all of our base assignments so](https://youtu.be/AyB3yDuZRTo?t=02h28m11s)

[that's](https://youtu.be/AyB3yDuZRTo?t=02h28m13s)

[nope nope nope nope nope not that that's](https://youtu.be/AyB3yDuZRTo?t=02h28m14s)

[not what we want to edit](https://youtu.be/AyB3yDuZRTo?t=02h28m17s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h28m20s)

[uh we want to be here so we want to call](https://youtu.be/AyB3yDuZRTo?t=02h28m21s)

[base](https://youtu.be/AyB3yDuZRTo?t=02h28m23s)

[uh prepare container for item override](https://youtu.be/AyB3yDuZRTo?t=02h28m25s)

[element](https://youtu.be/AyB3yDuZRTo?t=02h28m27s)

[item okay](https://youtu.be/AyB3yDuZRTo?t=02h28m28s)

[we want to do that I'm going to just](https://youtu.be/AyB3yDuZRTo?t=02h28m31s)

[launch this really quick](https://youtu.be/AyB3yDuZRTo?t=02h28m33s)

[and then I'll set my break point when we](https://youtu.be/AyB3yDuZRTo?t=02h28m39s)

[come back in here for selection](https://youtu.be/AyB3yDuZRTo?t=02h28m40s)

[and I think what I'm going to end up](https://youtu.be/AyB3yDuZRTo?t=02h28m46s)

[doing is that internal collection is](https://youtu.be/AyB3yDuZRTo?t=02h28m47s)

[probably not going to be uh](https://youtu.be/AyB3yDuZRTo?t=02h28m49s)

[I don't like having an observable](https://youtu.be/AyB3yDuZRTo?t=02h28m52s)

[collection and a list I have to keep in](https://youtu.be/AyB3yDuZRTo?t=02h28m54s)

[sync so I may create my own custom class](https://youtu.be/AyB3yDuZRTo?t=02h28m55s)

[and wrap them both up in there so if I](https://youtu.be/AyB3yDuZRTo?t=02h28m58s)

[do this](https://youtu.be/AyB3yDuZRTo?t=02h29m01s)

[item](https://youtu.be/AyB3yDuZRTo?t=02h29m03s)

[is a movie](https://youtu.be/AyB3yDuZRTo?t=02h29m04s)

[I'm guessing I'm going to get an index](https://youtu.be/AyB3yDuZRTo?t=02h29m07s)

[of two](https://youtu.be/AyB3yDuZRTo?t=02h29m09s)

[excellent item levels should be](https://youtu.be/AyB3yDuZRTo?t=02h29m10s)

[populated](https://youtu.be/AyB3yDuZRTo?t=02h29m13s)

[those two get a one](https://youtu.be/AyB3yDuZRTo?t=02h29m15s)

[okay because we got two Euro trips there](https://youtu.be/AyB3yDuZRTo?t=02h29m21s)

[and I'm gonna expand out this one](https://youtu.be/AyB3yDuZRTo?t=02h29m25s)

[okay we're gonna just disable breakpoint](https://youtu.be/AyB3yDuZRTo?t=02h29m28s)

[we're gonna just Snoop this guy to make](https://youtu.be/AyB3yDuZRTo?t=02h29m30s)

[sure that we got the values we expect](https://youtu.be/AyB3yDuZRTo?t=02h29m32s)

[and](https://youtu.be/AyB3yDuZRTo?t=02h29m37s)

[we go here we go here let's take a look](https://youtu.be/AyB3yDuZRTo?t=02h29m39s)

[at](https://youtu.be/AyB3yDuZRTo?t=02h29m42s)

[these](https://youtu.be/AyB3yDuZRTo?t=02h29m43s)

[okay so we're going to go up to the tree](https://youtu.be/AyB3yDuZRTo?t=02h29m46s)

[list view items](https://youtu.be/AyB3yDuZRTo?t=02h29m48s)

[all right we're going to set this to the](https://youtu.be/AyB3yDuZRTo?t=02h29m51s)

[side where we can watch the little red](https://youtu.be/AyB3yDuZRTo?t=02h29m52s)

[expansion we'll filter down to the level](https://youtu.be/AyB3yDuZRTo?t=02h29m53s)

[property okay so Action level zero good](https://youtu.be/AyB3yDuZRTo?t=02h29m55s)

[Predator level one](https://youtu.be/AyB3yDuZRTo?t=02h30m01s)

[alien level one](https://youtu.be/AyB3yDuZRTo?t=02h30m03s)

[Prometheus level one](https://youtu.be/AyB3yDuZRTo?t=02h30m05s)

[comedy level zero](https://youtu.be/AyB3yDuZRTo?t=02h30m08s)

[Euro trip level one Euro trip level one](https://youtu.be/AyB3yDuZRTo?t=02h30m10s)

[Action level zero](https://youtu.be/AyB3yDuZRTo?t=02h30m13s)

[okay okay we've got levels](https://youtu.be/AyB3yDuZRTo?t=02h30m17s)

[got levels](https://youtu.be/AyB3yDuZRTo?t=02h30m20s)

[Okay so](https://youtu.be/AyB3yDuZRTo?t=02h30m22s)

[now that we've got the appropriate](https://youtu.be/AyB3yDuZRTo?t=02h30m24s)

[property being set for us](https://youtu.be/AyB3yDuZRTo?t=02h30m26s)

[what we can do is we can come over to](https://youtu.be/AyB3yDuZRTo?t=02h30m29s)

[our style](https://youtu.be/AyB3yDuZRTo?t=02h30m32s)

[and nope not here I am in the wrong](https://youtu.be/AyB3yDuZRTo?t=02h30m34s)

[project](https://youtu.be/AyB3yDuZRTo?t=02h30m37s)

[we can come over here](https://youtu.be/AyB3yDuZRTo?t=02h30m40s)

[and on our](https://youtu.be/AyB3yDuZRTo?t=02h30m42s)

[tree list view item what we would like](https://youtu.be/AyB3yDuZRTo?t=02h30m46s)

[to do is we would like to inset the](https://youtu.be/AyB3yDuZRTo?t=02h30m49s)

[content a little bit](https://youtu.be/AyB3yDuZRTo?t=02h30m51s)

[based upon where it is so and we can we](https://youtu.be/AyB3yDuZRTo?t=02h30m53s)

[can play with this and Snoop real quick](https://youtu.be/AyB3yDuZRTo?t=02h30m57s)

[and see where we want to do this so for](https://youtu.be/AyB3yDuZRTo?t=02h30m58s)

[example predator](https://youtu.be/AyB3yDuZRTo?t=02h31m00s)

[right this guy here](https://youtu.be/AyB3yDuZRTo?t=02h31m01s)

[what I think we probably want to inset](https://youtu.be/AyB3yDuZRTo?t=02h31m04s)

[is the padding here](https://youtu.be/AyB3yDuZRTo?t=02h31m09s)

[so for example uh](https://youtu.be/AyB3yDuZRTo?t=02h31m13s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=02h31m15s)

[uh always padding not a thing](https://youtu.be/AyB3yDuZRTo?t=02h31m17s)

[is do we expect](https://youtu.be/AyB3yDuZRTo?t=02h31m21s)

[to be able to click outside of this](https://youtu.be/AyB3yDuZRTo?t=02h31m24s)

[for example does here](https://youtu.be/AyB3yDuZRTo?t=02h31m28s)

[so this one allows double click anywhere](https://youtu.be/AyB3yDuZRTo?t=02h31m33s)

[on the header to make it go](https://youtu.be/AyB3yDuZRTo?t=02h31m35s)

[but what do we expect I think we expect](https://youtu.be/AyB3yDuZRTo?t=02h31m38s)

[the entire content shifted over](https://youtu.be/AyB3yDuZRTo?t=02h31m42s)

[because we could even do](https://youtu.be/AyB3yDuZRTo?t=02h31m45s)

[on this grid we could even just do](https://youtu.be/AyB3yDuZRTo?t=02h31m48s)

[margin ten zero zero zero](https://youtu.be/AyB3yDuZRTo?t=02h31m50s)

[right and indent it an appropriate](https://youtu.be/AyB3yDuZRTo?t=02h31m53s)

[amount](https://youtu.be/AyB3yDuZRTo?t=02h31m55s)

[something like that](https://youtu.be/AyB3yDuZRTo?t=02h32m00s)

[I don't know what an appropriate amount](https://youtu.be/AyB3yDuZRTo?t=02h32m03s)

[is we probably have so I but I think I](https://youtu.be/AyB3yDuZRTo?t=02h32m05s)

[like let's just do the margin on](https://youtu.be/AyB3yDuZRTo?t=02h32m09s)

[the grid for the moment](https://youtu.be/AyB3yDuZRTo?t=02h32m12s)

[I think that's the path of least](https://youtu.be/AyB3yDuZRTo?t=02h32m14s)

[resistance](https://youtu.be/AyB3yDuZRTo?t=02h32m17s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h32m19s)

[so this grid here](https://youtu.be/AyB3yDuZRTo?t=02h32m21s)

[we want to margin him up based upon the](https://youtu.be/AyB3yDuZRTo?t=02h32m23s)

[level](https://youtu.be/AyB3yDuZRTo?t=02h32m27s)

[um and I wanted to look at](https://youtu.be/AyB3yDuZRTo?t=02h32m29s)

[what we were doing on Tree View item](https://youtu.be/AyB3yDuZRTo?t=02h32m34s)

[because that's going to be on the items](https://youtu.be/AyB3yDuZRTo?t=02h32m37s)

[control](https://youtu.be/AyB3yDuZRTo?t=02h32m40s)

[and how much she is in set](https://youtu.be/AyB3yDuZRTo?t=02h32m43s)

[16 it looks like](https://youtu.be/AyB3yDuZRTo?t=02h32m47s)

[I realize that's a negative 16 which is](https://youtu.be/AyB3yDuZRTo?t=02h32m52s)

[making me question my sanity a little](https://youtu.be/AyB3yDuZRTo?t=02h32m54s)

[bit](https://youtu.be/AyB3yDuZRTo?t=02h32m56s)

[I'm trying to look and see how this](https://youtu.be/AyB3yDuZRTo?t=02h33m00s)

[thing is structured](https://youtu.be/AyB3yDuZRTo?t=02h33m01s)

[so we've got a grid with three columns](https://youtu.be/AyB3yDuZRTo?t=02h33m04s)

[I assume the left one is for spacing so](https://youtu.be/AyB3yDuZRTo?t=02h33m10s)

[I'm looking for grid column zero](https://youtu.be/AyB3yDuZRTo?t=02h33m13s)

[figure out what might scale it](https://youtu.be/AyB3yDuZRTo?t=02h33m15s)

[I'm wondering if it's that scale host](https://youtu.be/AyB3yDuZRTo?t=02h33m22s)

[that does it for example when I'm](https://youtu.be/AyB3yDuZRTo?t=02h33m24s)

[looking at these](https://youtu.be/AyB3yDuZRTo?t=02h33m27s)

[you come over here](https://youtu.be/AyB3yDuZRTo?t=02h33m28s)

[all right where did my Snoop window go](https://youtu.be/AyB3yDuZRTo?t=02h33m31s)

[uh Tree View items](https://youtu.be/AyB3yDuZRTo?t=02h33m34s)

[so where is this guy yeah so the scale](https://youtu.be/AyB3yDuZRTo?t=02h33m40s)

[host is](https://youtu.be/AyB3yDuZRTo?t=02h33m43s)

[adjusted](https://youtu.be/AyB3yDuZRTo?t=02h33m45s)

[but I don't know which property so](https://youtu.be/AyB3yDuZRTo?t=02h33m47s)

[that's what it's using](https://youtu.be/AyB3yDuZRTo?t=02h33m49s)

[actual width so something on the scale](https://youtu.be/AyB3yDuZRTo?t=02h33m52s)

[host is being set](https://youtu.be/AyB3yDuZRTo?t=02h33m54s)

[which is then increasing the grid and](https://youtu.be/AyB3yDuZRTo?t=02h33m57s)

[moving it over](https://youtu.be/AyB3yDuZRTo?t=02h33m59s)

[how that is working so](https://youtu.be/AyB3yDuZRTo?t=02h34m01s)

[find scale host](https://youtu.be/AyB3yDuZRTo?t=02h34m04s)

[so the scale property is going from zero](https://youtu.be/AyB3yDuZRTo?t=02h34m15s)

[to one](https://youtu.be/AyB3yDuZRTo?t=02h34m19s)

[which is fine that will animate it but](https://youtu.be/AyB3yDuZRTo?t=02h34m20s)

[something else has to be setting a](https://youtu.be/AyB3yDuZRTo?t=02h34m23s)

[different property](https://youtu.be/AyB3yDuZRTo?t=02h34m25s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h34m28s)

[math multiplication](https://youtu.be/AyB3yDuZRTo?t=02h34m30s)

[got it so that's fine so that animates](https://youtu.be/AyB3yDuZRTo?t=02h34m36s)

[from zero to one and then the scale host](https://youtu.be/AyB3yDuZRTo?t=02h34m40s)

[has](https://youtu.be/AyB3yDuZRTo?t=02h34m43s)

[something being set](https://youtu.be/AyB3yDuZRTo?t=02h34m48s)

[um with this stack panel actual height](https://youtu.be/AyB3yDuZRTo?t=02h34m52s)

[binding](https://youtu.be/AyB3yDuZRTo?t=02h34m56s)

[that way the items measure their size](https://youtu.be/AyB3yDuZRTo?t=02h34m58s)

[and it expands appropriately which isn't](https://youtu.be/AyB3yDuZRTo?t=02h35m00s)

[really what we want to be doing we and](https://youtu.be/AyB3yDuZRTo?t=02h35m04s)

[that's not](https://youtu.be/AyB3yDuZRTo?t=02h35m07s)

[quite what we're after](https://youtu.be/AyB3yDuZRTo?t=02h35m08s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h35m13s)

[let's let's look a little more what else](https://youtu.be/AyB3yDuZRTo?t=02h35m15s)

[is offsetting this](https://youtu.be/AyB3yDuZRTo?t=02h35m18s)

[this is all about height and doing the](https://youtu.be/AyB3yDuZRTo?t=02h35m24s)

[scale because the scale is just being](https://youtu.be/AyB3yDuZRTo?t=02h35m27s)

[animated from zero to one](https://youtu.be/AyB3yDuZRTo?t=02h35m29s)

[there's got to be like a control](https://youtu.be/AyB3yDuZRTo?t=02h35m32s)

[template Trigger or something](https://youtu.be/AyB3yDuZRTo?t=02h35m34s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h35m41s)

[because there's an indent that's](https://youtu.be/AyB3yDuZRTo?t=02h35m47s)

[occurring and I'm wondering if it's that](https://youtu.be/AyB3yDuZRTo?t=02h35m48s)

[negative 16 in there](https://youtu.be/AyB3yDuZRTo?t=02h35m51s)

[let's just test that real quick](https://youtu.be/AyB3yDuZRTo?t=02h35m53s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h35m56s)

[I want to move you over where I can keep](https://youtu.be/AyB3yDuZRTo?t=02h35m57s)

[an eye on you](https://youtu.be/AyB3yDuZRTo?t=02h35m59s)

[so grid has the whole thing](https://youtu.be/AyB3yDuZRTo?t=02h36m01s)

[uh let's just do show grip lines](https://youtu.be/AyB3yDuZRTo?t=02h36m06s)

[show grid lines so that we can see where](https://youtu.be/AyB3yDuZRTo?t=02h36m09s)

[those things are](https://youtu.be/AyB3yDuZRTo?t=02h36m12s)

[scale host is there expanders there](https://youtu.be/AyB3yDuZRTo?t=02h36m14s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=02h36m26s)

[let's search for padding and margin](https://youtu.be/AyB3yDuZRTo?t=02h36m30s)

[properties](https://youtu.be/AyB3yDuZRTo?t=02h36m32s)

[those are all](https://youtu.be/AyB3yDuZRTo?t=02h36m35s)

[assist class](https://youtu.be/AyB3yDuZRTo?t=02h36m40s)

[adding is set to eight but I don't think](https://youtu.be/AyB3yDuZRTo?t=02h36m43s)

[that's actually the](https://youtu.be/AyB3yDuZRTo?t=02h36m45s)

[yeah that's not the root cause that's](https://youtu.be/AyB3yDuZRTo?t=02h36m48s)

[just giving space around it](https://youtu.be/AyB3yDuZRTo?t=02h36m50s)

[uh let's see expanders sitting in there](https://youtu.be/AyB3yDuZRTo?t=02h36m54s)

[toggle buttons sitting in there Mouse](https://youtu.be/AyB3yDuZRTo?t=02h36m56s)

[over border is only on the right](https://youtu.be/AyB3yDuZRTo?t=02h36m58s)

[selected border is only on the right](https://youtu.be/AyB3yDuZRTo?t=02h37m02s)

[content grid is only on the right](https://youtu.be/AyB3yDuZRTo?t=02h37m06s)

[additional content](https://youtu.be/AyB3yDuZRTo?t=02h37m08s)

[you're all collapsed](https://youtu.be/AyB3yDuZRTo?t=02h37m11s)

[it's got to be that scale host sizing](https://youtu.be/AyB3yDuZRTo?t=02h37m14s)

[that's doing it](https://youtu.be/AyB3yDuZRTo?t=02h37m17s)

[show me your width properties](https://youtu.be/AyB3yDuZRTo?t=02h37m20s)

[you've got an actual width of 32 based](https://youtu.be/AyB3yDuZRTo?t=02h37m22s)

[upon what](https://youtu.be/AyB3yDuZRTo?t=02h37m25s)

[what is this okay the scale host is](https://youtu.be/AyB3yDuZRTo?t=02h37m28s)

[doing something I'm not familiar with](https://youtu.be/AyB3yDuZRTo?t=02h37m31s)

[what are you what do you](https://youtu.be/AyB3yDuZRTo?t=02h37m33s)

[okay so you're doing basically nothing](https://youtu.be/AyB3yDuZRTo?t=02h37m35s)

[you are a container for a scale](https://youtu.be/AyB3yDuZRTo?t=02h37m39s)

[so show me your scale I guess](https://youtu.be/AyB3yDuZRTo?t=02h37m44s)

[your scale is zero but yet your actual](https://youtu.be/AyB3yDuZRTo?t=02h37m48s)

[width](https://youtu.be/AyB3yDuZRTo?t=02h37m52s)

[huh](https://youtu.be/AyB3yDuZRTo?t=02h37m59s)

[you've got a scale of zero but your](https://youtu.be/AyB3yDuZRTo?t=02h38m02s)

[actual width is 32.](https://youtu.be/AyB3yDuZRTo?t=02h38m05s)

[and your actual height is more or less](https://youtu.be/AyB3yDuZRTo?t=02h38m09s)

[the same](https://youtu.be/AyB3yDuZRTo?t=02h38m12s)

[oh is the indent simply coming by the](https://youtu.be/AyB3yDuZRTo?t=02h38m24s)

[virtue of](https://youtu.be/AyB3yDuZRTo?t=02h38m27s)

[this guy is shoved over into a different](https://youtu.be/AyB3yDuZRTo?t=02h38m30s)

[color of that](https://youtu.be/AyB3yDuZRTo?t=02h38m35s)

[that's what's going on this guy shoved](https://youtu.be/AyB3yDuZRTo?t=02h38m36s)

[over into the other column](https://youtu.be/AyB3yDuZRTo?t=02h38m38s)

[therefore what's actually doing the](https://youtu.be/AyB3yDuZRTo?t=02h38m42s)

[offset isn't the scale hose but the fact](https://youtu.be/AyB3yDuZRTo?t=02h38m44s)

[that this toggle button exists](https://youtu.be/AyB3yDuZRTo?t=02h38m47s)

[so this toggle button is what's holding](https://youtu.be/AyB3yDuZRTo?t=02h38m52s)

[this thing out](https://youtu.be/AyB3yDuZRTo?t=02h38m55s)

[so if you were](https://youtu.be/AyB3yDuZRTo?t=02h39m04s)

[zero](https://youtu.be/AyB3yDuZRTo?t=02h39m06s)

[yeah okay so the toggle button having a](https://youtu.be/AyB3yDuZRTo?t=02h39m08s)

[margin and a size is what's actually](https://youtu.be/AyB3yDuZRTo?t=02h39m11s)

[okay](https://youtu.be/AyB3yDuZRTo?t=02h39m13s)

[that's what's actually in setting it is](https://youtu.be/AyB3yDuZRTo?t=02h39m14s)

[the the size of the toggle button is](https://youtu.be/AyB3yDuZRTo?t=02h39m17s)

[causing it to be inset by x amount of](https://youtu.be/AyB3yDuZRTo?t=02h39m20s)

[space okay okay okay](https://youtu.be/AyB3yDuZRTo?t=02h39m23s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h39m28s)

[and how much exactly is that](https://youtu.be/AyB3yDuZRTo?t=02h39m32s)

[just hypothetical](https://youtu.be/AyB3yDuZRTo?t=02h39m37s)

[we go and look at this how wide is your](https://youtu.be/AyB3yDuZRTo?t=02h39m40s)

[first column](https://youtu.be/AyB3yDuZRTo?t=02h39m43s)

[32 I think 32 is probably a little too](https://youtu.be/AyB3yDuZRTo?t=02h39m46s)

[much but we we might](https://youtu.be/AyB3yDuZRTo?t=02h39m49s)

[we might give a configuration property](https://youtu.be/AyB3yDuZRTo?t=02h39m51s)

[or something on it okay so we want to](https://youtu.be/AyB3yDuZRTo?t=02h39m54s)

[multiply](https://youtu.be/AyB3yDuZRTo?t=02h39m57s)

[our offset by we'll say 32 for now to do](https://youtu.be/AyB3yDuZRTo?t=02h40m00s)

[the inset and we'll probably make it a](https://youtu.be/AyB3yDuZRTo?t=02h40m04s)

[configurable value](https://youtu.be/AyB3yDuZRTo?t=02h40m07s)

[at some point so let's look at this](https://youtu.be/AyB3yDuZRTo?t=02h40m09s)

[here we have](https://youtu.be/AyB3yDuZRTo?t=02h40m12s)

[all of this stuff](https://youtu.be/AyB3yDuZRTo?t=02h40m16s)

[and the way it gets in set is the parent](https://youtu.be/AyB3yDuZRTo?t=02h40m19s)

[is set but what we want to do is we want](https://youtu.be/AyB3yDuZRTo?t=02h40m22s)

[to do](https://youtu.be/AyB3yDuZRTo?t=02h40m25s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h40m26s)

[uh grid](https://youtu.be/AyB3yDuZRTo?t=02h40m30s)

[margin and I think we already have some](https://youtu.be/AyB3yDuZRTo?t=02h40m32s)

[converters already built in for this](https://youtu.be/AyB3yDuZRTo?t=02h40m35s)

[kind of stuff](https://youtu.be/AyB3yDuZRTo?t=02h40m37s)

[thickness](https://youtu.be/AyB3yDuZRTo?t=02h40m39s)

[thickness clone converter](https://youtu.be/AyB3yDuZRTo?t=02h40m42s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h40m47s)

[it's not quite what I want](https://youtu.be/AyB3yDuZRTo?t=02h40m53s)

[uh let's see circular brush we might](https://youtu.be/AyB3yDuZRTo?t=02h40m56s)

[have to build one real quick for it](https://youtu.be/AyB3yDuZRTo?t=02h40m59s)

[yeah I don't see this](https://youtu.be/AyB3yDuZRTo?t=02h41m10s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h41m12s)

[we're gonna do new class](https://youtu.be/AyB3yDuZRTo?t=02h41m13s)

[uh free list View](https://youtu.be/AyB3yDuZRTo?t=02h41m19s)

[indent](https://youtu.be/AyB3yDuZRTo?t=02h41m23s)

[inverter](https://youtu.be/AyB3yDuZRTo?t=02h41m25s)

[and do that we'll go ahead and leave](https://youtu.be/AyB3yDuZRTo?t=02h41m27s)

[this public so that other people can](https://youtu.be/AyB3yDuZRTo?t=02h41m30s)

[leverage it but we aren't going to](https://youtu.be/AyB3yDuZRTo?t=02h41m31s)

[expose it in the yaml](https://youtu.be/AyB3yDuZRTo?t=02h41m33s)

[uh let's see we do that we do that](https://youtu.be/AyB3yDuZRTo?t=02h41m35s)

[uh does it need to be a multi-value](https://youtu.be/AyB3yDuZRTo?t=02h41m41s)

[converter](https://youtu.be/AyB3yDuZRTo?t=02h41m44s)

[it probably should be a multi-value](https://youtu.be/AyB3yDuZRTo?t=02h41m51s)

[converter](https://youtu.be/AyB3yDuZRTo?t=02h41m54s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h41m56s)

[because I susp if we're going to make it](https://youtu.be/AyB3yDuZRTo?t=02h41m58s)

[a dependency property later on](https://youtu.be/AyB3yDuZRTo?t=02h42m00s)

[we are going to want to have](https://youtu.be/AyB3yDuZRTo?t=02h42m02s)

[uh two values that get brought in](https://youtu.be/AyB3yDuZRTo?t=02h42m07s)

[multiplied together and then](https://youtu.be/AyB3yDuZRTo?t=02h42m10s)

[so](https://youtu.be/AyB3yDuZRTo?t=02h42m16s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=02h42m16s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h42m18s)

[we're gonna clean up some of these](https://youtu.be/AyB3yDuZRTo?t=02h42m19s)

[buildability things here](https://youtu.be/AyB3yDuZRTo?t=02h42m21s)

[and one of these notability things here](https://youtu.be/AyB3yDuZRTo?t=02h42m24s)

[yeah yeah yeah I get it you're unhappy](https://youtu.be/AyB3yDuZRTo?t=02h42m27s)

[with me](https://youtu.be/AyB3yDuZRTo?t=02h42m29s)

[what did I I messed up](https://youtu.be/AyB3yDuZRTo?t=02h42m31s)

[I messed up somewhere I don't want to](https://youtu.be/AyB3yDuZRTo?t=02h42m33s)

[think too hard implement it for me](https://youtu.be/AyB3yDuZRTo?t=02h42m34s)

[thank you okay copilot I would like you](https://youtu.be/AyB3yDuZRTo?t=02h42m37s)

[to write the entire method for me go](https://youtu.be/AyB3yDuZRTo?t=02h42m39s)

[no okay well you suck](https://youtu.be/AyB3yDuZRTo?t=02h42m43s)

[ha I'm still a developer you're just an](https://youtu.be/AyB3yDuZRTo?t=02h42m46s)

[AI](https://youtu.be/AyB3yDuZRTo?t=02h42m49s)

[get on my level](https://youtu.be/AyB3yDuZRTo?t=02h42m50s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h42m53s)

[I know I'm Petty](https://youtu.be/AyB3yDuZRTo?t=02h42m55s)

[so if values is](https://youtu.be/AyB3yDuZRTo?t=02h42m57s)

[uh let's see int](https://youtu.be/AyB3yDuZRTo?t=02h43m01s)

[uh we'll call this](https://youtu.be/AyB3yDuZRTo?t=02h43m05s)

[size and](https://youtu.be/AyB3yDuZRTo?t=02h43m08s)

[uh uh level](https://youtu.be/AyB3yDuZRTo?t=02h43m10s)

[then return new uh thickness size times](https://youtu.be/AyB3yDuZRTo?t=02h43m16s)

[level zero zero zero uh](https://youtu.be/AyB3yDuZRTo?t=02h43m23s)

[uh return](https://youtu.be/AyB3yDuZRTo?t=02h43m27s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h43m29s)

[binding do nothing](https://youtu.be/AyB3yDuZRTo?t=02h43m31s)

[we don't get something we expect](https://youtu.be/AyB3yDuZRTo?t=02h43m34s)

[this should probably be a double rather](https://youtu.be/AyB3yDuZRTo?t=02h43m38s)

[than a int](https://youtu.be/AyB3yDuZRTo?t=02h43m41s)

[um and for those people who haven't seen](https://youtu.be/AyB3yDuZRTo?t=02h43m43s)

[this syntax this is list pattern](https://youtu.be/AyB3yDuZRTo?t=02h43m44s)

[matching somewhat newer in ye C sharp](https://youtu.be/AyB3yDuZRTo?t=02h43m46s)

[land](https://youtu.be/AyB3yDuZRTo?t=02h43m50s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h43m51s)

[it is pretty much gold](https://youtu.be/AyB3yDuZRTo?t=02h43m52s)

[um specifically for](https://youtu.be/AyB3yDuZRTo?t=02h43m58s)

[um value converters in WPF where you](https://youtu.be/AyB3yDuZRTo?t=02h44m01s)

[know there's an expected size of the](https://youtu.be/AyB3yDuZRTo?t=02h44m05s)

[array that you're that you're wanting](https://youtu.be/AyB3yDuZRTo?t=02h44m07s)

[that's pretty much where this one where](https://youtu.be/AyB3yDuZRTo?t=02h44m09s)

[this one works so if value is](https://youtu.be/AyB3yDuZRTo?t=02h44m12s)

[thickness](https://youtu.be/AyB3yDuZRTo?t=02h44m16s)

[thickness](https://youtu.be/AyB3yDuZRTo?t=02h44m18s)

[um binding nothing](https://youtu.be/AyB3yDuZRTo?t=02h44m21s)

[okay uh](https://youtu.be/AyB3yDuZRTo?t=02h44m24s)

[uh actually you know what this really](https://youtu.be/AyB3yDuZRTo?t=02h44m30s)

[shouldn't be going two-way Pro not](https://youtu.be/AyB3yDuZRTo?t=02h44m31s)

[implemented](https://youtu.be/AyB3yDuZRTo?t=02h44m34s)

[exception](https://youtu.be/AyB3yDuZRTo?t=02h44m36s)

[to](https://youtu.be/AyB3yDuZRTo?t=02h44m38s)

[don't use it that way okay so we'll take](https://youtu.be/AyB3yDuZRTo?t=02h44m39s)

[this and then we will go back over to](https://youtu.be/AyB3yDuZRTo?t=02h44m42s)

[our](https://youtu.be/AyB3yDuZRTo?t=02h44m45s)

[guy here](https://youtu.be/AyB3yDuZRTo?t=02h44m47s)

[we're gonna go](https://youtu.be/AyB3yDuZRTo?t=02h44m48s)

[troll template resources](https://youtu.be/AyB3yDuZRTo?t=02h44m50s)

[we're going to bring them in here](https://youtu.be/AyB3yDuZRTo?t=02h44m54s)

[uh x e](https://youtu.be/AyB3yDuZRTo?t=02h44m57s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h45m03s)

[see we've already got converters](https://youtu.be/AyB3yDuZRTo?t=02h45m06s)

[namespace referenced](https://youtu.be/AyB3yDuZRTo?t=02h45m07s)

[could be wrong](https://youtu.be/AyB3yDuZRTo?t=02h45m11s)

[stopped above oh we're in the middle of](https://youtu.be/AyB3yDuZRTo?t=02h45m13s)

[the debug session that's it's probably](https://youtu.be/AyB3yDuZRTo?t=02h45m15s)

[really confused do we have the](https://youtu.be/AyB3yDuZRTo?t=02h45m17s)

[converters namespace referenced](https://youtu.be/AyB3yDuZRTo?t=02h45m19s)

[we do](https://youtu.be/AyB3yDuZRTo?t=02h45m21s)

[okay so you should figure yourself out](https://youtu.be/AyB3yDuZRTo?t=02h45m25s)

[here in a moment](https://youtu.be/AyB3yDuZRTo?t=02h45m26s)

[and then we are going to slap on](https://youtu.be/AyB3yDuZRTo?t=02h45m30s)

[system index is not](https://youtu.be/AyB3yDuZRTo?t=02h45m33s)

[we don't have access to it](https://youtu.be/AyB3yDuZRTo?t=02h45m37s)

[oh we could shim it](https://youtu.be/AyB3yDuZRTo?t=02h45m40s)

[which version of.net is limiting me four](https://youtu.be/AyB3yDuZRTo?t=02h45m48s)

[six two](https://youtu.be/AyB3yDuZRTo?t=02h45m51s)

[do I shim it for 462 no we'll do it the](https://youtu.be/AyB3yDuZRTo?t=02h45m53s)

[hard way](https://youtu.be/AyB3yDuZRTo?t=02h45m57s)

[uh](https://youtu.be/AyB3yDuZRTo?t=02h45m59s)

[uh length](https://youtu.be/AyB3yDuZRTo?t=02h46m01s)

[uh equals two](https://youtu.be/AyB3yDuZRTo?t=02h46m03s)

[and value see this is why this is why](https://youtu.be/AyB3yDuZRTo?t=02h46m06s)

[property pattern matching isn't awesome](https://youtu.be/AyB3yDuZRTo?t=02h46m09s)

[double size](https://youtu.be/AyB3yDuZRTo?t=02h46m12s)

[because I didn't have to write all of](https://youtu.be/AyB3yDuZRTo?t=02h46m14s)

[this code](https://youtu.be/AyB3yDuZRTo?t=02h46m17s)

[so one is int](https://youtu.be/AyB3yDuZRTo?t=02h46m18s)

[uh level](https://youtu.be/AyB3yDuZRTo?t=02h46m21s)

[uh what happened here](https://youtu.be/AyB3yDuZRTo?t=02h46m28s)

[okay](https://youtu.be/AyB3yDuZRTo?t=02h46m33s)

[we'll do it that way we won't do the](https://youtu.be/AyB3yDuZRTo?t=02h46m36s)

[cool list pattern match](https://youtu.be/AyB3yDuZRTo?t=02h46m37s)

[okay close that close that](https://youtu.be/AyB3yDuZRTo?t=02h46m42s)

[okay](https://youtu.be/AyB3yDuZRTo?t=02h46m46s)

[push you down](https://youtu.be/AyB3yDuZRTo?t=02h46m49s)

[just want you to build thank you okay so](https://youtu.be/AyB3yDuZRTo?t=02h46m51s)

[now we do grid uh dot margin](https://youtu.be/AyB3yDuZRTo?t=02h46m53s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h47m00s)

[to do uh handle uh right to left](https://youtu.be/AyB3yDuZRTo?t=02h47m03s)

[uh let's see so this is then going to be](https://youtu.be/AyB3yDuZRTo?t=02h47m11s)

[a multi-binding](https://youtu.be/AyB3yDuZRTo?t=02h47m14s)

[with a converter](https://youtu.be/AyB3yDuZRTo?t=02h47m17s)

[that is a static resource](https://youtu.be/AyB3yDuZRTo?t=02h47m20s)

[boom that goes like that and then we do](https://youtu.be/AyB3yDuZRTo?t=02h47m28s)

[binding](https://youtu.be/AyB3yDuZRTo?t=02h47m31s)

[and let's see so the first value that we](https://youtu.be/AyB3yDuZRTo?t=02h47m33s)

[wanted in there was the size so](https://youtu.be/AyB3yDuZRTo?t=02h47m36s)

[uh let's see I think we can just do uh](https://youtu.be/AyB3yDuZRTo?t=02h47m41s)

[I want double but I want to](https://youtu.be/AyB3yDuZRTo?t=02h47m47s)

[double](https://youtu.be/AyB3yDuZRTo?t=02h47m51s)

[oh I think I actually have to do](https://youtu.be/AyB3yDuZRTo?t=02h47m55s)

[binding Source gets 16.](https://youtu.be/AyB3yDuZRTo?t=02h47m58s)

[and then binding uh let's see](https://youtu.be/AyB3yDuZRTo?t=02h48m04s)

[this one's going to end up being path](https://youtu.be/AyB3yDuZRTo?t=02h48m08s)

[level](https://youtu.be/AyB3yDuZRTo?t=02h48m11s)

[uh relative source](https://youtu.be/AyB3yDuZRTo?t=02h48m13s)

[relative source](https://youtu.be/AyB3yDuZRTo?t=02h48m17s)

[self](https://youtu.be/AyB3yDuZRTo?t=02h48m20s)

[oh actually I want to do a](https://youtu.be/AyB3yDuZRTo?t=02h48m26s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h48m29s)

[templated](https://youtu.be/AyB3yDuZRTo?t=02h48m31s)

[parent](https://youtu.be/AyB3yDuZRTo?t=02h48m33s)

[that's what I want](https://youtu.be/AyB3yDuZRTo?t=02h48m36s)

[okay let's see if it works](https://youtu.be/AyB3yDuZRTo?t=02h48m43s)

[okay so we expand](https://youtu.be/AyB3yDuZRTo?t=02h48m59s)

[did not get it indented so let's start](https://youtu.be/AyB3yDuZRTo?t=02h49m03s)

[here](https://youtu.be/AyB3yDuZRTo?t=02h49m06s)

[values](https://youtu.be/AyB3yDuZRTo?t=02h49m09s)

[oh we're getting a string 16.](https://youtu.be/AyB3yDuZRTo?t=02h49m12s)

[suck](https://youtu.be/AyB3yDuZRTo?t=02h49m16s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h49m18s)

[uh let's see](https://youtu.be/AyB3yDuZRTo?t=02h49m20s)

[uh what is the](https://youtu.be/AyB3yDuZRTo?t=02h49m24s)

[trying to remember how I declare a](https://youtu.be/AyB3yDuZRTo?t=02h49m29s)

[literal double](https://youtu.be/AyB3yDuZRTo?t=02h49m30s)

[I think I'm gonna end up doing something](https://youtu.be/AyB3yDuZRTo?t=02h49m32s)

[really ugly](https://youtu.be/AyB3yDuZRTo?t=02h49m34s)

[um you know what no no we're gonna not](https://youtu.be/AyB3yDuZRTo?t=02h49m37s)

[do this](https://youtu.be/AyB3yDuZRTo?t=02h49m40s)

[uh we are going to just because we want](https://youtu.be/AyB3yDuZRTo?t=02h49m41s)

[to we want it to exist eventually anyway](https://youtu.be/AyB3yDuZRTo?t=02h49m43s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h49m47s)

[prop DP](https://youtu.be/AyB3yDuZRTo?t=02h49m49s)

[uh let's see double](https://youtu.be/AyB3yDuZRTo?t=02h49m54s)

[uh indent](https://youtu.be/AyB3yDuZRTo?t=02h49m59s)

[level indent](https://youtu.be/AyB3yDuZRTo?t=02h50m04s)

[size](https://youtu.be/AyB3yDuZRTo?t=02h50m07s)

[Maybe](https://youtu.be/AyB3yDuZRTo?t=02h50m10s)

[again naming subject to change anyone is](https://youtu.be/AyB3yDuZRTo?t=02h50m12s)

[allowed to suggest better options](https://youtu.be/AyB3yDuZRTo?t=02h50m15s)

[um because I](https://youtu.be/AyB3yDuZRTo?t=02h50m18s)

[can't claim that I'm graded Amy okay so](https://youtu.be/AyB3yDuZRTo?t=02h50m21s)

[we're going to do that it's going to](https://youtu.be/AyB3yDuZRTo?t=02h50m24s)

[default to 16 and then we rather than](https://youtu.be/AyB3yDuZRTo?t=02h50m26s)

[futzing with figuring out declaring a](https://youtu.be/AyB3yDuZRTo?t=02h50m29s)

[static double and how that's going to](https://youtu.be/AyB3yDuZRTo?t=02h50m32s)

[work we are just going to do](https://youtu.be/AyB3yDuZRTo?t=02h50m35s)

[uh uh path](https://youtu.be/AyB3yDuZRTo?t=02h50m38s)

[and then relative source](https://youtu.be/AyB3yDuZRTo?t=02h50m41s)

[relative Source uh fine ancestor](https://youtu.be/AyB3yDuZRTo?t=02h50m45s)

[ancestor type is going to be](https://youtu.be/AyB3yDuZRTo?t=02h50m49s)

[X-Type WPF tree list View](https://youtu.be/AyB3yDuZRTo?t=02h50m54s)

[tree list](https://youtu.be/AyB3yDuZRTo?t=02h51m03s)

[View](https://youtu.be/AyB3yDuZRTo?t=02h51m06s)

[and why it's not showing up there](https://youtu.be/AyB3yDuZRTo?t=02h51m08s)

[and then I want whatever the heck I just](https://youtu.be/AyB3yDuZRTo?t=02h51m10s)

[named that property](https://youtu.be/AyB3yDuZRTo?t=02h51m13s)

[there okay let's try this again](https://youtu.be/AyB3yDuZRTo?t=02h51m18s)

[this time](https://youtu.be/AyB3yDuZRTo?t=02h51m23s)

[it should get a double and an it because](https://youtu.be/AyB3yDuZRTo?t=02h51m24s)

[those are the declared properties](https://youtu.be/AyB3yDuZRTo?t=02h51m28s)

[uh uh let's see the invocation on](https://youtu.be/AyB3yDuZRTo?t=02h51m37s)

[Constructor two](https://youtu.be/AyB3yDuZRTo?t=02h51m42s)

[default value type does not match the](https://youtu.be/AyB3yDuZRTo?t=02h51m45s)

[property of level indent size oh you](https://youtu.be/AyB3yDuZRTo?t=02h51m48s)

[suck](https://youtu.be/AyB3yDuZRTo?t=02h51m51s)

[because I type 16 doesn't so the](https://youtu.be/AyB3yDuZRTo?t=02h51m52s)

[property metadata again because generics](https://youtu.be/AyB3yDuZRTo?t=02h51m57s)

[weren't a thing its default value takes](https://youtu.be/AyB3yDuZRTo?t=02h51m59s)

[in an object and if you type in 16 by](https://youtu.be/AyB3yDuZRTo?t=02h52m01s)

[itself that's treated as an uh an](https://youtu.be/AyB3yDuZRTo?t=02h52m04s)

[integer literal](https://youtu.be/AyB3yDuZRTo?t=02h52m07s)

[which is not a double literal](https://youtu.be/AyB3yDuZRTo?t=02h52m09s)

[and then it gets unhappy that it's these](https://youtu.be/AyB3yDuZRTo?t=02h52m11s)

[type of double here and integer here](https://youtu.be/AyB3yDuZRTo?t=02h52m13s)

[okay I'm going to just turn this](https://youtu.be/AyB3yDuZRTo?t=02h52m18s)

[breakpoint off for a moment and we're](https://youtu.be/AyB3yDuZRTo?t=02h52m20s)

[going to see it work and it's going to](https://youtu.be/AyB3yDuZRTo?t=02h52m22s)

[be amazing that it works](https://youtu.be/AyB3yDuZRTo?t=02h52m23s)

[love it love it love it love it love it](https://youtu.be/AyB3yDuZRTo?t=02h52m29s)

[love it now we got to get rid of the](https://youtu.be/AyB3yDuZRTo?t=02h52m31s)

[the hides element thing](https://youtu.be/AyB3yDuZRTo?t=02h52m34s)

[and I'm not sure](https://youtu.be/AyB3yDuZRTo?t=02h52m38s)

[so open for debate here](https://youtu.be/AyB3yDuZRTo?t=02h52m43s)

[this](https://youtu.be/AyB3yDuZRTo?t=02h52m46s)

[selection](https://youtu.be/AyB3yDuZRTo?t=02h52m47s)

[starts here and doesn't go all the way](https://youtu.be/AyB3yDuZRTo?t=02h52m49s)

[across](https://youtu.be/AyB3yDuZRTo?t=02h52m51s)

[but for example things like the one in](https://youtu.be/AyB3yDuZRTo?t=02h52m53s)

[the solution Explorer the selection does](https://youtu.be/AyB3yDuZRTo?t=02h52m56s)

[go all the way across](https://youtu.be/AyB3yDuZRTo?t=02h52m58s)

[I don't know if there's a](https://youtu.be/AyB3yDuZRTo?t=02h53m02s)

[slip real quick](https://youtu.be/AyB3yDuZRTo?t=02h53m04s)

[material design](https://youtu.be/AyB3yDuZRTo?t=02h53m06s)

[I don't know if they actually Define](https://youtu.be/AyB3yDuZRTo?t=02h53m08s)

[this one](https://youtu.be/AyB3yDuZRTo?t=02h53m09s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h53m13s)

[this is probably I imagine this is going](https://youtu.be/AyB3yDuZRTo?t=02h53m17s)

[to be one of those areas where it's non](https://youtu.be/AyB3yDuZRTo?t=02h53m20s)

[obvious](https://youtu.be/AyB3yDuZRTo?t=02h53m24s)

[because we have to kind of infer it from](https://youtu.be/AyB3yDuZRTo?t=02h53m25s)

[other](https://youtu.be/AyB3yDuZRTo?t=02h53m28s)

[other controls to kind of guess](https://youtu.be/AyB3yDuZRTo?t=02h53m30s)

[like for example this this layout here](https://youtu.be/AyB3yDuZRTo?t=02h53m33s)

[is kind of a tree View and I guess their](https://youtu.be/AyB3yDuZRTo?t=02h53m36s)

[selection doesn't go all the way across](https://youtu.be/AyB3yDuZRTo?t=02h53m38s)

[so maybe maybe that makes sense](https://youtu.be/AyB3yDuZRTo?t=02h53m47s)

[maybe it makes sense Okay so](https://youtu.be/AyB3yDuZRTo?t=02h53m53s)

[we are going to do a couple things step](https://youtu.be/AyB3yDuZRTo?t=02h53m56s)

[one we are going to commit](https://youtu.be/AyB3yDuZRTo?t=02h53m59s)

[but we are also going to delete off](https://youtu.be/AyB3yDuZRTo?t=02h54m02s)

[our multi-select tree view thing that we](https://youtu.be/AyB3yDuZRTo?t=02h54m06s)

[were doing because I think we're](https://youtu.be/AyB3yDuZRTo?t=02h54m09s)

[scrapping that](https://youtu.be/AyB3yDuZRTo?t=02h54m10s)

[so multi-select review is out](https://youtu.be/AyB3yDuZRTo?t=02h54m13s)

[uh we have to stop debugging if we want](https://youtu.be/AyB3yDuZRTo?t=02h54m18s)

[to delete stuff so we're gonna we're](https://youtu.be/AyB3yDuZRTo?t=02h54m21s)

[gonna ax that](https://youtu.be/AyB3yDuZRTo?t=02h54m22s)

[we're gonna come back over into here](https://youtu.be/AyB3yDuZRTo?t=02h54m24s)

[we're going to come up to here](https://youtu.be/AyB3yDuZRTo?t=02h54m26s)

[we're just gonna go grab the](https://youtu.be/AyB3yDuZRTo?t=02h54m29s)

[multi-select tree view that style dead](https://youtu.be/AyB3yDuZRTo?t=02h54m30s)

[I assume this one goes with it](https://youtu.be/AyB3yDuZRTo?t=02h54m34s)

[once I select review item yeah this one](https://youtu.be/AyB3yDuZRTo?t=02h54m37s)

[goes with it okay so that that's dead](https://youtu.be/AyB3yDuZRTo?t=02h54m39s)

[that's dead that's dead we don't care](https://youtu.be/AyB3yDuZRTo?t=02h54m41s)

[that's a simple](https://youtu.be/AyB3yDuZRTo?t=02h54m45s)

[that's a simple thing](https://youtu.be/AyB3yDuZRTo?t=02h54m47s)

[now we will need to implement has item](https://youtu.be/AyB3yDuZRTo?t=02h54m50s)

[next or has items next](https://youtu.be/AyB3yDuZRTo?t=02h54m53s)

[um effectively](https://youtu.be/AyB3yDuZRTo?t=02h54m56s)

[yeah we'll also need to handle right to](https://youtu.be/AyB3yDuZRTo?t=02h54m59s)

[left](https://youtu.be/AyB3yDuZRTo?t=02h55m01s)

[that's a thing](https://youtu.be/AyB3yDuZRTo?t=02h55m02s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h55m04s)

[yeah because this this trigger here is](https://youtu.be/AyB3yDuZRTo?t=02h55m08s)

[is going to be the next one to be](https://youtu.be/AyB3yDuZRTo?t=02h55m10s)

[implemented is](https://youtu.be/AyB3yDuZRTo?t=02h55m12s)

[we need to have something on our item](https://youtu.be/AyB3yDuZRTo?t=02h55m14s)

[that has a has items property](https://youtu.be/AyB3yDuZRTo?t=02h55m17s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h55m22s)

[yeah and then we're gonna has no items](https://youtu.be/AyB3yDuZRTo?t=02h55m28s)

[expand or visibility so we'll wanna](https://youtu.be/AyB3yDuZRTo?t=02h55m30s)

[we'll wanna respect this other thing](https://youtu.be/AyB3yDuZRTo?t=02h55m32s)

[and then I think what we'll do is we'll](https://youtu.be/AyB3yDuZRTo?t=02h55m36s)

[probably end up moving these two Styles](https://youtu.be/AyB3yDuZRTo?t=02h55m38s)

[into their own xaml file](https://youtu.be/AyB3yDuZRTo?t=02h55m40s)

[more akin to how like the drawer host](https://youtu.be/AyB3yDuZRTo?t=02h55m45s)

[and dialog post are set up](https://youtu.be/AyB3yDuZRTo?t=02h55m47s)

[but then I think we will end up with](https://youtu.be/AyB3yDuZRTo?t=02h55m49s)

[something pretty close and then I don't](https://youtu.be/AyB3yDuZRTo?t=02h55m53s)

[think I'm going to bother to do it for](https://youtu.be/AyB3yDuZRTo?t=02h55m55s)

[the V1 release but in theory we could](https://youtu.be/AyB3yDuZRTo?t=02h55m56s)

[implement the column headers](https://youtu.be/AyB3yDuZRTo?t=02h55m59s)

[that way you could that way you could](https://youtu.be/AyB3yDuZRTo?t=02h56m02s)

[have the the test Explorer Behavior like](https://youtu.be/AyB3yDuZRTo?t=02h56m04s)

[this](https://youtu.be/AyB3yDuZRTo?t=02h56m06s)

[because this is a behavior that you get](https://youtu.be/AyB3yDuZRTo?t=02h56m07s)

[with list view with columns so because](https://youtu.be/AyB3yDuZRTo?t=02h56m09s)

[we're a list view it's a thing we can](https://youtu.be/AyB3yDuZRTo?t=02h56m12s)

[add](https://youtu.be/AyB3yDuZRTo?t=02h56m14s)

[so](https://youtu.be/AyB3yDuZRTo?t=02h56m17s)

[I don't think we're gonna do it now but](https://youtu.be/AyB3yDuZRTo?t=02h56m18s)

[I'm I'm much happier with where this is](https://youtu.be/AyB3yDuZRTo?t=02h56m20s)

[landing](https://youtu.be/AyB3yDuZRTo?t=02h56m23s)

[I think I think this makes me very very](https://youtu.be/AyB3yDuZRTo?t=02h56m24s)

[happy](https://youtu.be/AyB3yDuZRTo?t=02h56m27s)

[specifically the the ability to be able](https://youtu.be/AyB3yDuZRTo?t=02h56m30s)

[to](https://youtu.be/AyB3yDuZRTo?t=02h56m34s)

[to interact with this control the same](https://youtu.be/AyB3yDuZRTo?t=02h56m36s)

[way you would a regular Tree View](https://youtu.be/AyB3yDuZRTo?t=02h56m38s)

[with hierarchical data templates and](https://youtu.be/AyB3yDuZRTo?t=02h56m41s)

[data binding I do want to also test](https://youtu.be/AyB3yDuZRTo?t=02h56m44s)

[we're gonna kill this off I do want to](https://youtu.be/AyB3yDuZRTo?t=02h56m47s)

[also test putting in literal content as](https://youtu.be/AyB3yDuZRTo?t=02h56m49s)

[well and make sure that that works](https://youtu.be/AyB3yDuZRTo?t=02h56m52s)

[appropriately but I don't see any reason](https://youtu.be/AyB3yDuZRTo?t=02h56m53s)

[why it wouldn't](https://youtu.be/AyB3yDuZRTo?t=02h56m54s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h56m57s)

[we do have an interesting problem in](https://youtu.be/AyB3yDuZRTo?t=02h56m58s)

[that you can't actually Nest things](https://youtu.be/AyB3yDuZRTo?t=02h57m00s)

[you can't actually Nest things](https://youtu.be/AyB3yDuZRTo?t=02h57m06s)

[when would you want to do that when](https://youtu.be/AyB3yDuZRTo?t=02h57m09s)

[would you want literal content and](https://youtu.be/AyB3yDuZRTo?t=02h57m12s)

[actually care about this one](https://youtu.be/AyB3yDuZRTo?t=02h57m13s)

[I guess if you wanted literal content](https://youtu.be/AyB3yDuZRTo?t=02h57m19s)

[and multi-selection](https://youtu.be/AyB3yDuZRTo?t=02h57m21s)

[that would be the only time I could see](https://youtu.be/AyB3yDuZRTo?t=02h57m23s)

[somebody doing it](https://youtu.be/AyB3yDuZRTo?t=02h57m25s)

[so yeah this will be this will be an](https://youtu.be/AyB3yDuZRTo?t=02h57m29s)

[interesting control](https://youtu.be/AyB3yDuZRTo?t=02h57m32s)

[this will be an interesting control and](https://youtu.be/AyB3yDuZRTo?t=02h57m34s)

[it may make for a fun blog post I I may](https://youtu.be/AyB3yDuZRTo?t=02h57m36s)

[end up doing like a summary video at the](https://youtu.be/AyB3yDuZRTo?t=02h57m38s)

[very end or](https://youtu.be/AyB3yDuZRTo?t=02h57m40s)

[a write-up of hey here's all the things](https://youtu.be/AyB3yDuZRTo?t=02h57m42s)

[that we struggled with or yeah because](https://youtu.be/AyB3yDuZRTo?t=02h57m45s)

[future Kevin is not going to remember](https://youtu.be/AyB3yDuZRTo?t=02h57m50s)

[what current Kevin did here tonight](https://youtu.be/AyB3yDuZRTo?t=02h57m52s)

[oh commit commit commit commit](https://youtu.be/AyB3yDuZRTo?t=02h57m56s)

[uh let's just real quick check the](https://youtu.be/AyB3yDuZRTo?t=02h57m59s)

[changes there](https://youtu.be/AyB3yDuZRTo?t=02h58m01s)

[uh let's see working](https://youtu.be/AyB3yDuZRTo?t=02h58m05s)

[preview with](https://youtu.be/AyB3yDuZRTo?t=02h58m08s)

[multi selection and indentation](https://youtu.be/AyB3yDuZRTo?t=02h58m11s)

[sweet](https://youtu.be/AyB3yDuZRTo?t=02h58m18s)

[okay](https://youtu.be/AyB3yDuZRTo?t=02h58m20s)

[that's that is up if anybody if anybody](https://youtu.be/AyB3yDuZRTo?t=02h58m23s)

[feels overly eager and wants to help out](https://youtu.be/AyB3yDuZRTo?t=02h58m27s)

[with it I'm I am happy to accept PR's](https://youtu.be/AyB3yDuZRTo?t=02h58m29s)

[into this branch so feel free to play](https://youtu.be/AyB3yDuZRTo?t=02h58m32s)

[with it](https://youtu.be/AyB3yDuZRTo?t=02h58m35s)

[it is something forthcoming like I said](https://youtu.be/AyB3yDuZRTo?t=02h58m36s)

[last week I've got a](https://youtu.be/AyB3yDuZRTo?t=02h58m38s)

[uh a work project that I really want](https://youtu.be/AyB3yDuZRTo?t=02h58m40s)

[this for so I'm somewhat motivated to](https://youtu.be/AyB3yDuZRTo?t=02h58m43s)

[get it done because the current control](https://youtu.be/AyB3yDuZRTo?t=02h58m45s)

[we're using is crap and I am sick and](https://youtu.be/AyB3yDuZRTo?t=02h58m47s)

[tired of dealing with crap](https://youtu.be/AyB3yDuZRTo?t=02h58m50s)

[so but it is after midnight for me I'm a](https://youtu.be/AyB3yDuZRTo?t=02h58m51s)

[little tired the Mountain Dew's empty so](https://youtu.be/AyB3yDuZRTo?t=02h58m55s)

[that's probably an indication that](https://youtu.be/AyB3yDuZRTo?t=02h58m58s)

[coding should probably cease for tonight](https://youtu.be/AyB3yDuZRTo?t=02h59m00s)

[as always thank you everyone for coming](https://youtu.be/AyB3yDuZRTo?t=02h59m03s)

[and hanging out](https://youtu.be/AyB3yDuZRTo?t=02h59m04s)

[um check out getcon if you haven't](https://youtu.be/AyB3yDuZRTo?t=02h59m06s)

[already I highly recommend it](https://youtu.be/AyB3yDuZRTo?t=02h59m08s)

[let me see if I is it still on my it](https://youtu.be/AyB3yDuZRTo?t=02h59m12s)

[might still be on my Pace buffer](https://youtu.be/AyB3yDuZRTo?t=02h59m14s)

[um](https://youtu.be/AyB3yDuZRTo?t=02h59m19s)

[uh you have to spell it correctly in](https://youtu.be/AyB3yDuZRTo?t=02h59m24s)

[order to find it](https://youtu.be/AyB3yDuZRTo?t=02h59m26s)

[but if anybody is interested this will](https://youtu.be/AyB3yDuZRTo?t=02h59m28s)

[be](https://youtu.be/AyB3yDuZRTo?t=02h59m31s)

[wait](https://youtu.be/AyB3yDuZRTo?t=02h59m32s)

[that's not the right website](https://youtu.be/AyB3yDuZRTo?t=02h59m34s)

[it's 2022. uh](https://youtu.be/AyB3yDuZRTo?t=02h59m36s)

[[Music]](https://youtu.be/AyB3yDuZRTo?t=02h59m39s)

[uh yeah I just want](https://youtu.be/AyB3yDuZRTo?t=02h59m45s)

[getcon.com it's not rocket science there](https://youtu.be/AyB3yDuZRTo?t=02h59m47s)

[we go 2023 that's the right year](https://youtu.be/AyB3yDuZRTo?t=02h59m51s)

[so check it out](https://youtu.be/AyB3yDuZRTo?t=02h59m54s)

[um if you saw](https://youtu.be/AyB3yDuZRTo?t=02h59m57s)

