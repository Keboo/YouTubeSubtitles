[YouTube Video](https://youtu.be/R1jehN-p2QA)


[[Music]](https://youtu.be/R1jehN-p2QA?t=00h00m18s)



[[Music]](https://youtu.be/R1jehN-p2QA?t=00h04m13s)



[okay good evening everyone um I am going](https://youtu.be/R1jehN-p2QA?t=00h04m26s)



[to apologize in advance I have been](https://youtu.be/R1jehN-p2QA?t=00h04m29s)



[fighting a cold all weekend and I'm](https://youtu.be/R1jehN-p2QA?t=00h04m31s)



[about 80% there tonight so we will see](https://youtu.be/R1jehN-p2QA?t=00h04m34s)



[how long this lasts but I've got tea and](https://youtu.be/R1jehN-p2QA?t=00h04m37s)



[I've got what looks like Mountain Dew](https://youtu.be/R1jehN-p2QA?t=00h04m40s)



[but it's actually just filled with water](https://youtu.be/R1jehN-p2QA?t=00h04m44s)



[right now so hopefully that's enough](https://youtu.be/R1jehN-p2QA?t=00h04m46s)



[between that and some meds that I've](https://youtu.be/R1jehN-p2QA?t=00h04m49s)



[been drinking today I am hoping to be](https://youtu.be/R1jehN-p2QA?t=00h04m50s)



[good enough to get through all of this](https://youtu.be/R1jehN-p2QA?t=00h04m53s)



[tonight so a couple things on the agenda](https://youtu.be/R1jehN-p2QA?t=00h04m55s)



[for tonight was going to go through and](https://youtu.be/R1jehN-p2QA?t=00h04m57s)



[show off some logic app stuff that I did](https://youtu.be/R1jehN-p2QA?t=00h05m00s)



[over the weekend while being horribly](https://youtu.be/R1jehN-p2QA?t=00h05m03s)



[sick so I apologize the quality of code](https://youtu.be/R1jehN-p2QA?t=00h05m05s)



[is probably down here somewhere but I](https://youtu.be/R1jehN-p2QA?t=00h05m09s)



[think the end result is kind of cool](https://youtu.be/R1jehN-p2QA?t=00h05m13s)



[figured I would show it off just so if](https://youtu.be/R1jehN-p2QA?t=00h05m15s)



[anybody else is curious how I'm doing](https://youtu.be/R1jehN-p2QA?t=00h05m18s)



[this you can see it too and then I was](https://youtu.be/R1jehN-p2QA?t=00h05m19s)



[going to dive back into the material](https://youtu.be/R1jehN-p2QA?t=00h05m22s)



[design and zamel stuff we've had a bunch](https://youtu.be/R1jehN-p2QA?t=00h05m24s)



[of pull requests open that I wanted to](https://youtu.be/R1jehN-p2QA?t=00h05m26s)



[get reviewed and then I'm trying to](https://youtu.be/R1jehN-p2QA?t=00h05m28s)



[snipe off as much as the three Oh stuff](https://youtu.be/R1jehN-p2QA?t=00h05m30s)



[and probably look at the MA Apps](https://youtu.be/R1jehN-p2QA?t=00h05m32s)



[integration library because right now it](https://youtu.be/R1jehN-p2QA?t=00h05m34s)



[is horribly broken and I think looking](https://youtu.be/R1jehN-p2QA?t=00h05m36s)



[over the remaining changes that they](https://youtu.be/R1jehN-p2QA?t=00h05m39s)



[have for - oh I think we I can probably](https://youtu.be/R1jehN-p2QA?t=00h05m41s)



[get most of it back up and working so](https://youtu.be/R1jehN-p2QA?t=00h05m43s)



[anybody on the preview nougats can start](https://youtu.be/R1jehN-p2QA?t=00h05m45s)



[working with that again so I apologize](https://youtu.be/R1jehN-p2QA?t=00h05m48s)



[for being broken for such a long time so](https://youtu.be/R1jehN-p2QA?t=00h05m50s)



[with that said let's dive in and have](https://youtu.be/R1jehN-p2QA?t=00h05m52s)



[some fun with some logic apps so on a](https://youtu.be/R1jehN-p2QA?t=00h05m54s)



[prior video I walk through what I was](https://youtu.be/R1jehN-p2QA?t=00h05m58s)



[doing with my my logic app so this one](https://youtu.be/R1jehN-p2QA?t=00h06m03s)



[here triggers whenever I upload a new](https://youtu.be/R1jehN-p2QA?t=00h06m05s)



[video to YouTube which every time one of](https://youtu.be/R1jehN-p2QA?t=00h06m09s)



[my streams ends usually the first thing](https://youtu.be/R1jehN-p2QA?t=00h06m11s)



[I do is I click export and then then](https://youtu.be/R1jehN-p2QA?t=00h06m13s)



[usually the next day I go through and](https://youtu.be/R1jehN-p2QA?t=00h06m16s)



[set up all of the metadata on YouTube](https://youtu.be/R1jehN-p2QA?t=00h06m17s)



[and hit flip the thing public right and](https://youtu.be/R1jehN-p2QA?t=00h06m19s)



[so flipping the thing public is what](https://youtu.be/R1jehN-p2QA?t=00h06m22s)



[ultimately triggers this off and then](https://youtu.be/R1jehN-p2QA?t=00h06m24s)



[there's two things that happen one this](https://youtu.be/R1jehN-p2QA?t=00h06m27s)



[guy comes down here and goes and](https://youtu.be/R1jehN-p2QA?t=00h06m29s)



[takes the the video ID and puts it in an](https://youtu.be/R1jehN-p2QA?t=00h06m32s)



[azure queue we're going to come back to](https://youtu.be/R1jehN-p2QA?t=00h06m35s)



[this one in just a minute there's all](https://youtu.be/R1jehN-p2QA?t=00h06m36s)



[the one I think I've mentioned before it](https://youtu.be/R1jehN-p2QA?t=00h06m38s)



[goes through builds up some messages](https://youtu.be/R1jehN-p2QA?t=00h06m41s)



[based on the contents of it set some](https://youtu.be/R1jehN-p2QA?t=00h06m43s)



[tags based on the contents fires off a](https://youtu.be/R1jehN-p2QA?t=00h06m46s)



[tweet so that I don't have to worry](https://youtu.be/R1jehN-p2QA?t=00h06m50s)



[about going out and actually tweeting](https://youtu.be/R1jehN-p2QA?t=00h06m52s)



[out that hey I've got a new video out](https://youtu.be/R1jehN-p2QA?t=00h06m53s)



[and then it sends me an email with](https://youtu.be/R1jehN-p2QA?t=00h06m54s)



[basically the same information that went](https://youtu.be/R1jehN-p2QA?t=00h06m57s)



[out to Twitter just so that I can if](https://youtu.be/R1jehN-p2QA?t=00h06m59s)



[anything goes wrong I'd like to be](https://youtu.be/R1jehN-p2QA?t=00h07m03s)



[notified so I can go and delete the](https://youtu.be/R1jehN-p2QA?t=00h07m04s)



[tweet if like this logic app Falls](https://youtu.be/R1jehN-p2QA?t=00h07m06s)



[horribly apart and tweet something I](https://youtu.be/R1jehN-p2QA?t=00h07m08s)



[didn't intend but this one over here is](https://youtu.be/R1jehN-p2QA?t=00h07m09s)



[what's more interesting so this goes and](https://youtu.be/R1jehN-p2QA?t=00h07m12s)



[puts the message out on a as your cue so](https://youtu.be/R1jehN-p2QA?t=00h07m14s)



[then what is an as your cue with ins](https://youtu.be/R1jehN-p2QA?t=00h07m18s)



[adjure there's a resource type called a](https://youtu.be/R1jehN-p2QA?t=00h07m22s)



[storage account and as the name implies](https://youtu.be/R1jehN-p2QA?t=00h07m24s)



[a storage account is a place where you](https://youtu.be/R1jehN-p2QA?t=00h07m27s)



[can store anything it's basically a](https://youtu.be/R1jehN-p2QA?t=00h07m28s)



[generic I need to put some data](https://youtu.be/R1jehN-p2QA?t=00h07m32s)



[somewhere and there's kind of four big](https://youtu.be/R1jehN-p2QA?t=00h07m33s)



[areas you've got containers which just](https://youtu.be/R1jehN-p2QA?t=00h07m40s)



[kind of hold arbitrary blobs of data you](https://youtu.be/R1jehN-p2QA?t=00h07m42s)



[can set up file shares there are tables](https://youtu.be/R1jehN-p2QA?t=00h07m45s)



[where you can put tabular data and then](https://youtu.be/R1jehN-p2QA?t=00h07m49s)



[there are queues and we're gonna look at](https://youtu.be/R1jehN-p2QA?t=00h07m51s)



[at least three of these but for now](https://youtu.be/R1jehN-p2QA?t=00h07m53s)



[let's take a look at the queues so this](https://youtu.be/R1jehN-p2QA?t=00h07m54s)



[guy here was dropping a message onto the](https://youtu.be/R1jehN-p2QA?t=00h07m57s)



[queue and the message text was literally](https://youtu.be/R1jehN-p2QA?t=00h08m00s)



[just the the YouTube video ID so when](https://youtu.be/R1jehN-p2QA?t=00h08m02s)



[looking at YouTube the video ID and we](https://youtu.be/R1jehN-p2QA?t=00h08m06s)



[can actually pop this up real quick](https://youtu.be/R1jehN-p2QA?t=00h08m10s)



[YouTube you calm so we'll just go and](https://youtu.be/R1jehN-p2QA?t=00h08m13s)



[look real quick so this guy redirects to](https://youtu.be/R1jehN-p2QA?t=00h08m18s)



[my channel](https://youtu.be/R1jehN-p2QA?t=00h08m20s)



[and if the Internet's are all happy so](https://youtu.be/R1jehN-p2QA?t=00h08m23s)



[for example last week's video the the ID](https://youtu.be/R1jehN-p2QA?t=00h08m26s)



[is this little bit right here so in this](https://youtu.be/R1jehN-p2QA?t=00h08m34s)



[case it's for you vcz bla bla bla bla](https://youtu.be/R1jehN-p2QA?t=00h08m37s)



[bla right so that's all that's all the](https://youtu.be/R1jehN-p2QA?t=00h08m40s)



[data that's getting dropped onto this](https://youtu.be/R1jehN-p2QA?t=00h08m42s)



[queue now on this queue go away video](https://youtu.be/R1jehN-p2QA?t=00h08m43s)



[why will you not disappear thank you so](https://youtu.be/R1jehN-p2QA?t=00h08m48s)



[putting a message on the queue is great](https://youtu.be/R1jehN-p2QA?t=00h08m53s)



[but something then has to take the](https://youtu.be/R1jehN-p2QA?t=00h08m54s)



[message off the queue and do some work](https://youtu.be/R1jehN-p2QA?t=00h08m56s)



[with it enter a second logic app so](https://youtu.be/R1jehN-p2QA?t=00h08m58s)



[we've got this one over here called the](https://youtu.be/R1jehN-p2QA?t=00h09m02s)



[YouTube processor and it's job is to](https://youtu.be/R1jehN-p2QA?t=00h09m04s)



[process things on the YouTube videos](https://youtu.be/R1jehN-p2QA?t=00h09m07s)



[queue so once it thinks about its life](https://youtu.be/R1jehN-p2QA?t=00h09m08s)



[for a moment](https://youtu.be/R1jehN-p2QA?t=00h09m13s)



[okay so the first thing it does is it](https://youtu.be/R1jehN-p2QA?t=00h09m16s)



[watches the queue every 10 minutes it's](https://youtu.be/R1jehN-p2QA?t=00h09m18s)



[basically just checking and saying hey](https://youtu.be/R1jehN-p2QA?t=00h09m21s)



[you got a new message you got a new](https://youtu.be/R1jehN-p2QA?t=00h09m22s)



[message you got a new message for the](https://youtu.be/R1jehN-p2QA?t=00h09m24s)



[purposes of doing this I don't really](https://youtu.be/R1jehN-p2QA?t=00h09m26s)



[care about a high level of accuracy so](https://youtu.be/R1jehN-p2QA?t=00h09m28s)



[10 minutes that's probably even more](https://youtu.be/R1jehN-p2QA?t=00h09m30s)



[often than it needs to pull I could turn](https://youtu.be/R1jehN-p2QA?t=00h09m32s)



[this down more but this seems slow](https://youtu.be/R1jehN-p2QA?t=00h09m34s)



[enough that it that it works fine goes](https://youtu.be/R1jehN-p2QA?t=00h09m36s)



[through and initializes a couple of](https://youtu.be/R1jehN-p2QA?t=00h09m39s)



[variables so it grabs the video ID from](https://youtu.be/R1jehN-p2QA?t=00h09m40s)



[the the text of the message that was on](https://youtu.be/R1jehN-p2QA?t=00h09m44s)



[the queue it initializes a couple](https://youtu.be/R1jehN-p2QA?t=00h09m46s)



[variables this partition key we'll get](https://youtu.be/R1jehN-p2QA?t=00h09m52s)



[back to you in just a minute](https://youtu.be/R1jehN-p2QA?t=00h09m55s)



[subtitle contents are empty that's just](https://youtu.be/R1jehN-p2QA?t=00h09m56s)



[a basically a new string variable where](https://youtu.be/R1jehN-p2QA?t=00h09m58s)



[we're gonna put stuff in a minute and](https://youtu.be/R1jehN-p2QA?t=00h10m00s)



[then we go through and we start working](https://youtu.be/R1jehN-p2QA?t=00h10m04s)



[with the Azure tables one of those other](https://youtu.be/R1jehN-p2QA?t=00h10m05s)



[ones from the storage account so in this](https://youtu.be/R1jehN-p2QA?t=00h10m08s)



[case we've got a YouTube's videos table](https://youtu.be/R1jehN-p2QA?t=00h10m09s)



[there's a partition key which in my case](https://youtu.be/R1jehN-p2QA?t=00h10m12s)



[that's not the partition key I'm just](https://youtu.be/R1jehN-p2QA?t=00h10m17s)



[hard coding now in general you should](https://youtu.be/R1jehN-p2QA?t=00h10m20s)



[probably break this partition key up and](https://youtu.be/R1jehN-p2QA?t=00h10m22s)



[separate it but I'm going to have so few](https://youtu.be/R1jehN-p2QA?t=00h10m25s)



[of these things at some point I should](https://youtu.be/R1jehN-p2QA?t=00h10m27s)



[probably do something better but for now](https://youtu.be/R1jehN-p2QA?t=00h10m31s)



[because I have so few rows that are](https://youtu.be/R1jehN-p2QA?t=00h10m35s)



[going into this table I don't really](https://youtu.be/R1jehN-p2QA?t=00h10m37s)



[need to partition them much and then a](https://youtu.be/R1jehN-p2QA?t=00h10m39s)



[key for the row which in my case is](https://youtu.be/R1jehN-p2QA?t=00h10m43s)



[going to be a video ID because YouTube](https://youtu.be/R1jehN-p2QA?t=00h10m45s)



[ensures that these IDs are unique so I](https://youtu.be/R1jehN-p2QA?t=00h10m47s)



[can guarantee I'll get nice uniqueness](https://youtu.be/R1jehN-p2QA?t=00h10m48s)



[there and then my entity which is just a](https://youtu.be/R1jehN-p2QA?t=00h10m50s)



[JSON object so in this case it's](https://youtu.be/R1jehN-p2QA?t=00h10m52s)



[actually doing an insert you can think](https://youtu.be/R1jehN-p2QA?t=00h10m55s)



[of it as insert it into a table with](https://youtu.be/R1jehN-p2QA?t=00h10m57s)



[effectively three columns we've got a](https://youtu.be/R1jehN-p2QA?t=00h11m00s)



[partition key a video ID E as the row](https://youtu.be/R1jehN-p2QA?t=00h11m01s)



[key and then I'm actually storing the](https://youtu.be/R1jehN-p2QA?t=00h11m04s)



[video ID again as a explicit column okay](https://youtu.be/R1jehN-p2QA?t=00h11m06s)



[and so this is an insert or a merge](https://youtu.be/R1jehN-p2QA?t=00h11m11s)



[entity so in general when a new video is](https://youtu.be/R1jehN-p2QA?t=00h11m13s)



[created this is probably always going to](https://youtu.be/R1jehN-p2QA?t=00h11m16s)



[be an insert but there's nothing](https://youtu.be/R1jehN-p2QA?t=00h11m17s)



[stopping me from going through if I need](https://youtu.be/R1jehN-p2QA?t=00h11m19s)



[to say reprocess a video just dumping](https://youtu.be/R1jehN-p2QA?t=00h11m21s)



[that message onto my cue and letting](https://youtu.be/R1jehN-p2QA?t=00h11m23s)



[this thing kick off and pick it up](https://youtu.be/R1jehN-p2QA?t=00h11m25s)



[so if I do end up needing to reprocess](https://youtu.be/R1jehN-p2QA?t=00h11m26s)



[something I can do so and so this'll](https://youtu.be/R1jehN-p2QA?t=00h11m29s)



[just merge the information in which all](https://youtu.be/R1jehN-p2QA?t=00h11m32s)



[of this should be duplicated in any way](https://youtu.be/R1jehN-p2QA?t=00h11m34s)



[this basically just ensures that the](https://youtu.be/R1jehN-p2QA?t=00h11m36s)



[data exists in the table okay we then](https://youtu.be/R1jehN-p2QA?t=00h11m38s)



[pull the entity back out of the table](https://youtu.be/R1jehN-p2QA?t=00h11m42s)



[and the only reason for doing this is in](https://youtu.be/R1jehN-p2QA?t=00h11m44s)



[the case where the entity already](https://youtu.be/R1jehN-p2QA?t=00h11m47s)



[existed in the table I want to actually](https://youtu.be/R1jehN-p2QA?t=00h11m48s)



[there's a few other columns in that](https://youtu.be/R1jehN-p2QA?t=00h11m51s)



[table that I want to pull from and so](https://youtu.be/R1jehN-p2QA?t=00h11m53s)



[this just pulls that updated entity back](https://youtu.be/R1jehN-p2QA?t=00h11m55s)



[out and then this takes that entity and](https://youtu.be/R1jehN-p2QA?t=00h11m57s)



[parses it and as you can see there is a](https://youtu.be/R1jehN-p2QA?t=00h12m02s)



[JSON schema here and so it's actually](https://youtu.be/R1jehN-p2QA?t=00h12m04s)



[looking for there several bits of data](https://youtu.be/R1jehN-p2QA?t=00h12m06s)



[the the interesting one that we're gonna](https://youtu.be/R1jehN-p2QA?t=00h12m09s)



[look at here is this subtitle blob URI](https://youtu.be/R1jehN-p2QA?t=00h12m11s)



[and then the video idea that we](https://youtu.be/R1jehN-p2QA?t=00h12m14s)



[populated at a playlist which is](https://youtu.be/R1jehN-p2QA?t=00h12m15s)



[currently unused okay we come down one](https://youtu.be/R1jehN-p2QA?t=00h12m17s)



[more thing we populate our blob path](https://youtu.be/R1jehN-p2QA?t=00h12m21s)



[from the blob URI out of there and then](https://youtu.be/R1jehN-p2QA?t=00h12m24s)



[this is where things get interesting is](https://youtu.be/R1jehN-p2QA?t=00h12m27s)



[we actually have some conditions here so](https://youtu.be/R1jehN-p2QA?t=00h12m28s)



[in this case it goes through and it's](https://youtu.be/R1jehN-p2QA?t=00h12m30s)



[basically doing is no lor empty check on](https://youtu.be/R1jehN-p2QA?t=00h12m32s)



[the blob path so it's saying if the blob](https://youtu.be/R1jehN-p2QA?t=00h12m34s)



[path is equal to null or the length of](https://youtu.be/R1jehN-p2QA?t=00h12m36s)



[the blob path is equal to zero so string](https://youtu.be/R1jehN-p2QA?t=00h12m39s)



[is no lor empty basically we're gonna do](https://youtu.be/R1jehN-p2QA?t=00h12m41s)



[one of two things so if we've already](https://youtu.be/R1jehN-p2QA?t=00h12m44s)



[got a blob path and actually let's real](https://youtu.be/R1jehN-p2QA?t=00h12m46s)



[quick before I get too carried away](https://youtu.be/R1jehN-p2QA?t=00h12m49s)



[let's jump back here and look at that](https://youtu.be/R1jehN-p2QA?t=00h12m50s)



[table that we were pulling from and I've](https://youtu.be/R1jehN-p2QA?t=00h12m52s)



[already jumped out too far back](https://youtu.be/R1jehN-p2QA?t=00h12m55s)



[so back into the storage account and](https://youtu.be/R1jehN-p2QA?t=00h12m58s)



[let's go look at that table since we](https://youtu.be/R1jehN-p2QA?t=00h13m01s)



[just showed what was there](https://youtu.be/R1jehN-p2QA?t=00h13m04s)



[Oh storage Explorer is the magical place](https://youtu.be/R1jehN-p2QA?t=00h13m05s)



[where you go so we can come over here](https://youtu.be/R1jehN-p2QA?t=00h13m09s)



[and look at the table you can pull up in](https://youtu.be/R1jehN-p2QA?t=00h13m12s)



[this table and we can take a look so](https://youtu.be/R1jehN-p2QA?t=00h13m14s)



[there's our partition key](https://youtu.be/R1jehN-p2QA?t=00h13m16s)



[I've already processed one video there's](https://youtu.be/R1jehN-p2QA?t=00h13m17s)



[a timestamp that you get on there](https://youtu.be/R1jehN-p2QA?t=00h13m19s)



[sub subtitle blob URI which is a](https://youtu.be/R1jehN-p2QA?t=00h13m22s)



[relative URI for it and then a video ID](https://youtu.be/R1jehN-p2QA?t=00h13m26s)



[okay so exactly the same type of stuff](https://youtu.be/R1jehN-p2QA?t=00h13m29s)



[that we already saw before okay back in](https://youtu.be/R1jehN-p2QA?t=00h13m32s)



[here so if it already has a blob path](https://youtu.be/R1jehN-p2QA?t=00h13m39s)



[it's going to go through and get the](https://youtu.be/R1jehN-p2QA?t=00h13m43s)



[blob contents out of blob storage so](https://youtu.be/R1jehN-p2QA?t=00h13m47s)



[it's going to go looking for this blob](https://youtu.be/R1jehN-p2QA?t=00h13m50s)



[path so you'll recall here this is the](https://youtu.be/R1jehN-p2QA?t=00h13m53s)



[blob path here so subtitle subtitles](https://youtu.be/R1jehN-p2QA?t=00h13m56s)



[slash video ID right so if we would go](https://youtu.be/R1jehN-p2QA?t=00h13m59s)



[through and look at my blob containers](https://youtu.be/R1jehN-p2QA?t=00h14m03s)



[you'll notice underneath here there is a](https://youtu.be/R1jehN-p2QA?t=00h14m05s)



[subtitles container and this contains a](https://youtu.be/R1jehN-p2QA?t=00h14m06s)



[bunch of blobs in this case there's one](https://youtu.be/R1jehN-p2QA?t=00h14m09s)



[here that is filled with all of my blob](https://youtu.be/R1jehN-p2QA?t=00h14m11s)



[data and we can pop this guy open and](https://youtu.be/R1jehN-p2QA?t=00h14m14s)



[this is just the raw subtitle track from](https://youtu.be/R1jehN-p2QA?t=00h14m17s)



[YouTube okay](https://youtu.be/R1jehN-p2QA?t=00h14m21s)



[so this guy just goes through pulls down](https://youtu.be/R1jehN-p2QA?t=00h14m23s)



[all of the](https://youtu.be/R1jehN-p2QA?t=00h14m26s)



[pulls the the subtitle text right out of](https://youtu.be/R1jehN-p2QA?t=00h14m30s)



[blob storage but what if this is a brand](https://youtu.be/R1jehN-p2QA?t=00h14m33s)



[new video and we don't have any of the](https://youtu.be/R1jehN-p2QA?t=00h14m35s)



[subtitles yet so this is where it gets](https://youtu.be/R1jehN-p2QA?t=00h14m37s)



[more interesting so it kicks off to an](https://youtu.be/R1jehN-p2QA?t=00h14m39s)



[azure function because why not make this](https://youtu.be/R1jehN-p2QA?t=00h14m41s)



[more complex right so I've got an azure](https://youtu.be/R1jehN-p2QA?t=00h14m44s)



[function that I've written that goes](https://youtu.be/R1jehN-p2QA?t=00h14m47s)



[through and let's pull that I had the](https://youtu.be/R1jehN-p2QA?t=00h14m50s)



[code up for it real quick I do it's just](https://youtu.be/R1jehN-p2QA?t=00h14m54s)



[on my other screen so in the same](https://youtu.be/R1jehN-p2QA?t=00h14m57s)



[repository where I'm keeping the](https://youtu.be/R1jehN-p2QA?t=00h15m01s)



[subtitles themselves and I will drop](https://youtu.be/R1jehN-p2QA?t=00h15m04s)



[that Chet that guy there also contains](https://youtu.be/R1jehN-p2QA?t=00h15m09s)



[the code for this so if we look at not](https://youtu.be/R1jehN-p2QA?t=00h15m13s)



[underneath subtitles subtitle converter](https://youtu.be/R1jehN-p2QA?t=00h15m16s)



[download subtitles this guy here](https://youtu.be/R1jehN-p2QA?t=00h15m19s)



[contains all of the code for going out](https://youtu.be/R1jehN-p2QA?t=00h15m23s)



[and creating an azure function that just](https://youtu.be/R1jehN-p2QA?t=00h15m26s)



[downloads the subtitle track so this](https://youtu.be/R1jehN-p2QA?t=00h15m29s)



[function takes in a request for the](https://youtu.be/R1jehN-p2QA?t=00h15m33s)



[video ID goes up creates a new YouTube](https://youtu.be/R1jehN-p2QA?t=00h15m35s)



[service and then pulls down the SRT](https://youtu.be/R1jehN-p2QA?t=00h15m40s)



[caption track for it so it just goes out](https://youtu.be/R1jehN-p2QA?t=00h15m43s)



[looks for it pulls it down so that's all](https://youtu.be/R1jehN-p2QA?t=00h15m45s)



[this does and then it just dumps the the](https://youtu.be/R1jehN-p2QA?t=00h15m48s)



[contents straight back out in a 200](https://youtu.be/R1jehN-p2QA?t=00h15m50s)



[response okay so I can do that in a](https://youtu.be/R1jehN-p2QA?t=00h15m52s)



[little bit](https://youtu.be/R1jehN-p2QA?t=00h15m57s)



[nothing nothing too fancy the hard part](https://youtu.be/R1jehN-p2QA?t=00h15m57s)



[here is just getting all of the the](https://youtu.be/R1jehN-p2QA?t=00h15m59s)



[Google auth stuff figured out which is](https://youtu.be/R1jehN-p2QA?t=00h16m02s)



[sort of a pain but the the key parts](https://youtu.be/R1jehN-p2QA?t=00h16m05s)



[there is all of the auth stuff is stored](https://youtu.be/R1jehN-p2QA?t=00h16m08s)



[in secret environment variables that are](https://youtu.be/R1jehN-p2QA?t=00h16m10s)



[then passed into the function itself](https://youtu.be/R1jehN-p2QA?t=00h16m13s)



[okay so this guy then on success it goes](https://youtu.be/R1jehN-p2QA?t=00h16m15s)



[through and sets the subtitle contents](https://youtu.be/R1jehN-p2QA?t=00h16m20s)



[this same variable that was declared up](https://youtu.be/R1jehN-p2QA?t=00h16m22s)



[here it gets set from the body of this](https://youtu.be/R1jehN-p2QA?t=00h16m24s)



[Azure function so same thing here this](https://youtu.be/R1jehN-p2QA?t=00h16m27s)



[guy was just setting it but from the](https://youtu.be/R1jehN-p2QA?t=00h16m30s)



[blob contents this thing then goes](https://youtu.be/R1jehN-p2QA?t=00h16m31s)



[through and creates a blob underneath](https://youtu.be/R1jehN-p2QA?t=00h16m33s)



[subtitles using the blob name of the](https://youtu.be/R1jehN-p2QA?t=00h16m36s)



[video ID and populating it from the](https://youtu.be/R1jehN-p2QA?t=00h16m38s)



[contents](https://youtu.be/R1jehN-p2QA?t=00h16m40s)



[this guy then goes to and sets the blob](https://youtu.be/R1jehN-p2QA?t=00h16m43s)



[path and then goes through and updates](https://youtu.be/R1jehN-p2QA?t=00h16m45s)



[our item in the table so same partition](https://youtu.be/R1jehN-p2QA?t=00h16m48s)



[keys same video ID but you'll notice now](https://youtu.be/R1jehN-p2QA?t=00h16m52s)



[the entity that I'm inserting or merging](https://youtu.be/R1jehN-p2QA?t=00h16m54s)



[also contains the subtitle blob URI and](https://youtu.be/R1jehN-p2QA?t=00h16m57s)



[that goes through there](https://youtu.be/R1jehN-p2QA?t=00h17m01s)



[finally if we've gotten this far down](https://youtu.be/R1jehN-p2QA?t=00h17m02s)



[either branch of this we go through and](https://youtu.be/R1jehN-p2QA?t=00h17m05s)



[delete the message off the cube so if](https://youtu.be/R1jehN-p2QA?t=00h17m07s)



[you know if you just act on the messages](https://youtu.be/R1jehN-p2QA?t=00h17m08s)



[from the queue it won't ever actually](https://youtu.be/R1jehN-p2QA?t=00h17m11s)



[remove the item from the queue and](https://youtu.be/R1jehN-p2QA?t=00h17m12s)



[you'll just keep spinning forever the](https://youtu.be/R1jehN-p2QA?t=00h17m14s)



[key thing here is you just need to pop](https://youtu.be/R1jehN-p2QA?t=00h17m16s)



[it off with the same cue name you get a](https://youtu.be/R1jehN-p2QA?t=00h17m18s)



[message ID and a pop receipt as long as](https://youtu.be/R1jehN-p2QA?t=00h17m20s)



[you pass those it'll then delete the](https://youtu.be/R1jehN-p2QA?t=00h17m23s)



[item from the queue but if any of this](https://youtu.be/R1jehN-p2QA?t=00h17m24s)



[stuff fails higher up I don't want to](https://youtu.be/R1jehN-p2QA?t=00h17m26s)



[actually delete it I want this thing to](https://youtu.be/R1jehN-p2QA?t=00h17m29s)



[keep basically circling until it gets](https://youtu.be/R1jehN-p2QA?t=00h17m30s)



[around to processing it the most likely](https://youtu.be/R1jehN-p2QA?t=00h17m33s)



[failure case is right in the download](https://youtu.be/R1jehN-p2QA?t=00h17m35s)



[subtitles YouTube has some rate limiting](https://youtu.be/R1jehN-p2QA?t=00h17m37s)



[every API call has an arbitrary units](https://youtu.be/R1jehN-p2QA?t=00h17m40s)



[cap and downloading subtitles is like](https://youtu.be/R1jehN-p2QA?t=00h17m43s)



[200 units and I think you only get](https://youtu.be/R1jehN-p2QA?t=00h17m46s)



[10,000 a day which is not too hard to](https://youtu.be/R1jehN-p2QA?t=00h17m48s)



[hit if you say pointed it like a whole](https://youtu.be/R1jehN-p2QA?t=00h17m50s)



[playlist of videos and say go you can](https://youtu.be/R1jehN-p2QA?t=00h17m53s)



[run out pretty fast which is part of the](https://youtu.be/R1jehN-p2QA?t=00h17m56s)



[reason for this whole caching of the](https://youtu.be/R1jehN-p2QA?t=00h17m59s)



[blob stuff so once I've downloaded the](https://youtu.be/R1jehN-p2QA?t=00h18m00s)



[subtitle track from YouTube I'm not](https://youtu.be/R1jehN-p2QA?t=00h18m02s)



[going to go back to YouTube and ask for](https://youtu.be/R1jehN-p2QA?t=00h18m04s)



[it again I'm just gonna use my cache](https://youtu.be/R1jehN-p2QA?t=00h18m06s)



[stuff and if I ever need to redownload](https://youtu.be/R1jehN-p2QA?t=00h18m07s)



[it from the cache I'll just blow away my](https://youtu.be/R1jehN-p2QA?t=00h18m09s)



[blob and delete the item out of my table](https://youtu.be/R1jehN-p2QA?t=00h18m12s)



[and away we go okay last but not least](https://youtu.be/R1jehN-p2QA?t=00h18m15s)



[now that we've done all of this work](https://youtu.be/R1jehN-p2QA?t=00h18m18s)



[we've gotten all of the we've gotten the](https://youtu.be/R1jehN-p2QA?t=00h18m20s)



[subtitle track cache cuz this whole this](https://youtu.be/R1jehN-p2QA?t=00h18m22s)



[whole mess here is all about downloading](https://youtu.be/R1jehN-p2QA?t=00h18m25s)



[the subtitle from YouTube and getting in](https://youtu.be/R1jehN-p2QA?t=00h18m28s)



[it and blob storage and updating my](https://youtu.be/R1jehN-p2QA?t=00h18m30s)



[table correctly that's all this logic](https://youtu.be/R1jehN-p2QA?t=00h18m32s)



[app has done so far and ultimately the](https://youtu.be/R1jehN-p2QA?t=00h18m34s)



[end goal is I want to get this subtitle](https://youtu.be/R1jehN-p2QA?t=00h18m36s)



[track converted into markdown with](https://youtu.be/R1jehN-p2QA?t=00h18m38s)



[hyperlinks back into my original video](https://youtu.be/R1jehN-p2QA?t=00h18m40s)



[so that I have a way of easily searching](https://youtu.be/R1jehN-p2QA?t=00h18m43s)



[through these videos when I'm looking](https://youtu.be/R1jehN-p2QA?t=00h18m46s)



[for content where it's one of those](https://youtu.be/R1jehN-p2QA?t=00h18m47s)



[somebody asks a questions like oh I know](https://youtu.be/R1jehN-p2QA?t=00h18m48s)



[I covered that and I was kind of talking](https://youtu.be/R1jehN-p2QA?t=00h18m50s)



[about this how do I find it](https://youtu.be/R1jehN-p2QA?t=00h18m52s)



[conveniently there's a wonderful website](https://youtu.be/R1jehN-p2QA?t=00h18m54s)



[that you can host markdown files in that](https://youtu.be/R1jehN-p2QA?t=00h18m55s)



[lets you search it's called github so](https://youtu.be/R1jehN-p2QA?t=00h18m57s)



[this is probably one of the most hack](https://youtu.be/R1jehN-p2QA?t=00h19m00s)



[tastic ways to get a file into github](https://youtu.be/R1jehN-p2QA?t=00h19m03s)



[and I am very open if people have other](https://youtu.be/R1jehN-p2QA?t=00h19m05s)



[suggestions but I this was the easiest](https://youtu.be/R1jehN-p2QA?t=00h19m07s)



[option I could think of so I have a](https://youtu.be/R1jehN-p2QA?t=00h19m10s)



[DevOps account with a release pipeline](https://youtu.be/R1jehN-p2QA?t=00h19m13s)



[and so this guy here invokes my release](https://youtu.be/R1jehN-p2QA?t=00h19m15s)



[pipeline and passes through a couple](https://youtu.be/R1jehN-p2QA?t=00h19m21s)



[parameters video ID and subtitle URI](https://youtu.be/R1jehN-p2QA?t=00h19m23s)



[basically pointing it at the blob path](https://youtu.be/R1jehN-p2QA?t=00h19m25s)



[so that it can download the blob from my](https://youtu.be/R1jehN-p2QA?t=00h19m29s)



[blob storage and then also giving it the](https://youtu.be/R1jehN-p2QA?t=00h19m32s)



[ID of the video](https://youtu.be/R1jehN-p2QA?t=00h19m35s)



[technically I could probably infer one](https://youtu.be/R1jehN-p2QA?t=00h19m36s)



[from the other but I didn't want to have](https://youtu.be/R1jehN-p2QA?t=00h19m38s)



[that type of coupling in there right so](https://youtu.be/R1jehN-p2QA?t=00h19m39s)



[what is the release pipeline do this](https://youtu.be/R1jehN-p2QA?t=00h19m43s)



[updates subtitles does two things](https://youtu.be/R1jehN-p2QA?t=00h19m45s)



[one it goes through and calls the](https://youtu.be/R1jehN-p2QA?t=00h19m47s)



[converter which is the code that is](https://youtu.be/R1jehN-p2QA?t=00h19m50s)



[inside boom this same repository if we](https://youtu.be/R1jehN-p2QA?t=00h19m52s)



[back up a couple levels and dive down](https://youtu.be/R1jehN-p2QA?t=00h19m59s)



[into subtitle converter there is a](https://youtu.be/R1jehN-p2QA?t=00h20m02s)



[little command line app this is the same](https://youtu.be/R1jehN-p2QA?t=00h20m05s)



[one that I showed off on a previous](https://youtu.be/R1jehN-p2QA?t=00h20m07s)



[stream but I updated it with a few more](https://youtu.be/R1jehN-p2QA?t=00h20m08s)



[parameters and probably need to clean a](https://youtu.be/R1jehN-p2QA?t=00h20m10s)



[bunch of it up because it's it's kind of](https://youtu.be/R1jehN-p2QA?t=00h20m12s)



[a mess now but the the two new](https://youtu.be/R1jehN-p2QA?t=00h20m14s)



[parameters are video ID and then to do](https://youtu.be/R1jehN-p2QA?t=00h20m16s)



[subtitle URI so both of these guys here](https://youtu.be/R1jehN-p2QA?t=00h20m22s)



[are the new ones and the the key part](https://youtu.be/R1jehN-p2QA?t=00h20m25s)



[here is if if these two guys are set it](https://youtu.be/R1jehN-p2QA?t=00h20m27s)



[short-circuits all of the extra youtubey](https://youtu.be/R1jehN-p2QA?t=00h20m30s)



[api calls doesn't bother with any of](https://youtu.be/R1jehN-p2QA?t=00h20m33s)



[that it downloads the subtitles from the](https://youtu.be/R1jehN-p2QA?t=00h20m35s)



[URI and then it goes through and pulls](https://youtu.be/R1jehN-p2QA?t=00h20m39s)



[out the the video information and then](https://youtu.be/R1jehN-p2QA?t=00h20m41s)



[just converts these guys into markdown](https://youtu.be/R1jehN-p2QA?t=00h20m46s)



[following the same pattern and the same](https://youtu.be/R1jehN-p2QA?t=00h20m50s)



[markdown convergence stuff they had](https://youtu.be/R1jehN-p2QA?t=00h20m52s)



[before so a little bit of refactor in](https://youtu.be/R1jehN-p2QA?t=00h20m53s)



[this code you can go read it if you're](https://youtu.be/R1jehN-p2QA?t=00h20m55s)



[interested just converts the SRT](https://youtu.be/R1jehN-p2QA?t=00h20m57s)



[subtitle stuff with a couple Reg X's](https://youtu.be/R1jehN-p2QA?t=00h20m59s)



[into pretty markdown](https://youtu.be/R1jehN-p2QA?t=00h21m01s)



[so that's step one step two then goes](https://youtu.be/R1jehN-p2QA?t=00h21m04s)



[through and just does a git commit and](https://youtu.be/R1jehN-p2QA?t=00h21m08s)



[push to the repository so then the end](https://youtu.be/R1jehN-p2QA?t=00h21m10s)



[result ends up looking like if we jump](https://youtu.be/R1jehN-p2QA?t=00h21m13s)



[back up to the top underneath the](https://youtu.be/R1jehN-p2QA?t=00h21m16s)



[subtitles folder I now start getting a](https://youtu.be/R1jehN-p2QA?t=00h21m21s)



[bunch of markdown files with the the](https://youtu.be/R1jehN-p2QA?t=00h21m24s)



[video ID that you can then click on and](https://youtu.be/R1jehN-p2QA?t=00h21m26s)



[the very first link is a link to the](https://youtu.be/R1jehN-p2QA?t=00h21m35s)



[video itself and then each of these](https://youtu.be/R1jehN-p2QA?t=00h21m38s)



[lines are segments in the YouTube video](https://youtu.be/R1jehN-p2QA?t=00h21m40s)



[they're usually about five seconds long](https://youtu.be/R1jehN-p2QA?t=00h21m43s)



[give or take a little bit and you can](https://youtu.be/R1jehN-p2QA?t=00h21m46s)



[see that some of the stuff like](https://youtu.be/R1jehN-p2QA?t=00h21m48s)



[Oktoberfest doesn't translate real well](https://youtu.be/R1jehN-p2QA?t=00h21m50s)



[so I've got thoughts and plans of ways](https://youtu.be/R1jehN-p2QA?t=00h21m54s)



[to improve this and do translations](https://youtu.be/R1jehN-p2QA?t=00h21m56s)



[using Azure cognitive services that'll](https://youtu.be/R1jehN-p2QA?t=00h21m59s)



[probably be a future one for now this is](https://youtu.be/R1jehN-p2QA?t=00h22m02s)



[just my my quick and dirty way of](https://youtu.be/R1jehN-p2QA?t=00h22m05s)



[searching for stuff my old subtitles](https://youtu.be/R1jehN-p2QA?t=00h22m06s)



[that I was hosting previously I were](https://youtu.be/R1jehN-p2QA?t=00h22m10s)



[dumped into a mdi-x and a system command](https://youtu.be/R1jehN-p2QA?t=00h22m13s)



[line one because that's where they were](https://youtu.be/R1jehN-p2QA?t=00h22m17s)



[at](https://youtu.be/R1jehN-p2QA?t=00h22m19s)



[but I'm thinking going forward I'm](https://youtu.be/R1jehN-p2QA?t=00h22m20s)



[probably just gonna dump everything into](https://youtu.be/R1jehN-p2QA?t=00h22m22s)



[one bucket because most of the time I](https://youtu.be/R1jehN-p2QA?t=00h22m23s)



[can't remember exactly what the primary](https://youtu.be/R1jehN-p2QA?t=00h22m25s)



[purpose of my stream was and so having](https://youtu.be/R1jehN-p2QA?t=00h22m27s)



[to search across both of these and](https://youtu.be/R1jehN-p2QA?t=00h22m29s)



[figure it out it's like NIT I'll just](https://youtu.be/R1jehN-p2QA?t=00h22m31s)



[dump them all in one so if anybody wants](https://youtu.be/R1jehN-p2QA?t=00h22m33s)



[to search my videos for some bit of](https://youtu.be/R1jehN-p2QA?t=00h22m36s)



[content I recommend just going to this](https://youtu.be/R1jehN-p2QA?t=00h22m38s)



[repository and and hunting for them so](https://youtu.be/R1jehN-p2QA?t=00h22m41s)



[yeah this is simply a repository for me](https://youtu.be/R1jehN-p2QA?t=00h22m44s)



[- ooh that's embarrassing let's just fix](https://youtu.be/R1jehN-p2QA?t=00h22m48s)



[that typo real quick](https://youtu.be/R1jehN-p2QA?t=00h22m52s)



[for me too door captions Wow](https://youtu.be/R1jehN-p2QA?t=00h22m53s)



[00:23:06,110 --> 00:23:10,220](https://youtu.be/R1jehN-p2QA?t=00h23m00s)

it's it's really bad like I said I've


[been fighting a cold](https://youtu.be/R1jehN-p2QA?t=00h23m09s)



[I can't be held responsible for my bad](https://youtu.be/R1jehN-p2QA?t=00h23m10s)



[spelling tonight okay so there's that](https://youtu.be/R1jehN-p2QA?t=00h23m11s)



[there's logic gaps they are totally cool](https://youtu.be/R1jehN-p2QA?t=00h23m14s)



[totally awesome and they are cheap too](https://youtu.be/R1jehN-p2QA?t=00h23m17s)



[so for anyone who's running an MSDN](https://youtu.be/R1jehN-p2QA?t=00h23m20s)



[subscription I don't know exactly what](https://youtu.be/R1jehN-p2QA?t=00h23m22s)



[the cost is on these logic apps have](https://youtu.be/R1jehN-p2QA?t=00h23m26s)



[been so far but I think it's under ten](https://youtu.be/R1jehN-p2QA?t=00h23m27s)



[cents so it is incredibly cheap to go](https://youtu.be/R1jehN-p2QA?t=00h23m29s)



[through and process these now obviously](https://youtu.be/R1jehN-p2QA?t=00h23m33s)



[if I start having this thing do a lot](https://youtu.be/R1jehN-p2QA?t=00h23m35s)



[more subtitle processing I'll be curious](https://youtu.be/R1jehN-p2QA?t=00h23m38s)



[what the the total runtime gets up to](https://youtu.be/R1jehN-p2QA?t=00h23m39s)



[because it's now moving a little bit](https://youtu.be/R1jehN-p2QA?t=00h23m42s)



[more data but the the storage and the](https://youtu.be/R1jehN-p2QA?t=00h23m43s)



[logic app processing is been miniscule](https://youtu.be/R1jehN-p2QA?t=00h23m46s)



[so very very much recommend this I think](https://youtu.be/R1jehN-p2QA?t=00h23m49s)



[these things are the coolest things ever](https://youtu.be/R1jehN-p2QA?t=00h23m55s)



[so but there is blob storage tables](https://youtu.be/R1jehN-p2QA?t=00h23m57s)



[queues and yeah all the cool stuff sweet](https://youtu.be/R1jehN-p2QA?t=00h24m02s)



[okay so now on to now on to material](https://youtu.be/R1jehN-p2QA?t=00h24m09s)



[design I got to remember exactly where](https://youtu.be/R1jehN-p2QA?t=00h24m14s)



[oh and if you are interested this is](https://youtu.be/R1jehN-p2QA?t=00h24m22s)



[what the the commit ends up looking like](https://youtu.be/R1jehN-p2QA?t=00h24m26s)



[I prefixed it with as your dev ops](https://youtu.be/R1jehN-p2QA?t=00h24m27s)



[automatic update of subtitles and it](https://youtu.be/R1jehN-p2QA?t=00h24m29s)



[added in a file for me so it just worked](https://youtu.be/R1jehN-p2QA?t=00h24m32s)



[huzzah okay](https://youtu.be/R1jehN-p2QA?t=00h24m37s)



[okay we will come back here and let's](https://youtu.be/R1jehN-p2QA?t=00h24m46s)



[let's get my master updated because](https://youtu.be/R1jehN-p2QA?t=00h24m48s)



[we've had several stuff that got merged](https://youtu.be/R1jehN-p2QA?t=00h24m53s)



[in so far](https://youtu.be/R1jehN-p2QA?t=00h24m55s)



[there's been a lot of pull requests so I](https://youtu.be/R1jehN-p2QA?t=00h24m56s)



[think there's a couple of these pull](https://youtu.be/R1jehN-p2QA?t=00h24m58s)



[requests I probably want to go back and](https://youtu.be/R1jehN-p2QA?t=00h25m00s)



[look at real quick and then then we'll](https://youtu.be/R1jehN-p2QA?t=00h25m01s)



[circle on to the MA app stuff I think](https://youtu.be/R1jehN-p2QA?t=00h25m04s)



[because there's some there's some good](https://youtu.be/R1jehN-p2QA?t=00h25m07s)



[stuff out here that should probably get](https://youtu.be/R1jehN-p2QA?t=00h25m11s)



[make themed Styles](https://youtu.be/R1jehN-p2QA?t=00h25m13s)



[linked to files oh this one this one](https://youtu.be/R1jehN-p2QA?t=00h25m15s)



[excites me](https://youtu.be/R1jehN-p2QA?t=00h25m18s)



[so there is a Azure DevOps pipeline that](https://youtu.be/R1jehN-p2QA?t=00h25m24s)



[triggers on every commit into master](https://youtu.be/R1jehN-p2QA?t=00h25m31s)



[that goes through and runs a PowerShell](https://youtu.be/R1jehN-p2QA?t=00h25m34s)



[script that updates this file right here](https://youtu.be/R1jehN-p2QA?t=00h25m38s)



[so underneath the wiki the control](https://youtu.be/R1jehN-p2QA?t=00h25m44s)



[styles list this file and this guy here](https://youtu.be/R1jehN-p2QA?t=00h25m47s)



[to do you'll notice there's this](https://youtu.be/R1jehN-p2QA?t=00h25m52s)



[auto-generated file do not edit because](https://youtu.be/R1jehN-p2QA?t=00h25m55s)



[if you edit this directly your change is](https://youtu.be/R1jehN-p2QA?t=00h25m57s)



[only going to live until the next commit](https://youtu.be/R1jehN-p2QA?t=00h25m59s)



[into master and then this thing gets](https://youtu.be/R1jehN-p2QA?t=00h26m02s)



[blown away every time so it's basically](https://youtu.be/R1jehN-p2QA?t=00h26m03s)



[doing a force push right over the top of](https://youtu.be/R1jehN-p2QA?t=00h26m06s)



[whatever's in there but as you can see](https://youtu.be/R1jehN-p2QA?t=00h26m08s)



[it goes through and generates out a](https://youtu.be/R1jehN-p2QA?t=00h26m10s)



[whole bunch of just showing off all of](https://youtu.be/R1jehN-p2QA?t=00h26m13s)



[the individual styles for everything](https://youtu.be/R1jehN-p2QA?t=00h26m16s)



[that is inside of the library so you can](https://youtu.be/R1jehN-p2QA?t=00h26m19s)



[see anything with this default style](https://youtu.be/R1jehN-p2QA?t=00h26m22s)



[means that there is an implicit style](https://youtu.be/R1jehN-p2QA?t=00h26m23s)



[targeting this type but this list is](https://youtu.be/R1jehN-p2QA?t=00h26m25s)



[nice but what what I was really hoping](https://youtu.be/R1jehN-p2QA?t=00h26m29s)



[for is to have this list ultimately](https://youtu.be/R1jehN-p2QA?t=00h26m32s)



[become a list of links that you can](https://youtu.be/R1jehN-p2QA?t=00h26m34s)



[click on and dive back into the source](https://youtu.be/R1jehN-p2QA?t=00h26m35s)



[code because sometimes seen the style](https://youtu.be/R1jehN-p2QA?t=00h26m37s)



[name is nice but actually being able to](https://youtu.be/R1jehN-p2QA?t=00h26m42s)



[look at the style code itself is even](https://youtu.be/R1jehN-p2QA?t=00h26m43s)



[better so that was the end goal of what](https://youtu.be/R1jehN-p2QA?t=00h26m45s)



[we were shooting for here so this guy](https://youtu.be/R1jehN-p2QA?t=00h26m48s)



[here so links to files containing the](https://youtu.be/R1jehN-p2QA?t=00h26m50s)



[style should work so this this one I](https://youtu.be/R1jehN-p2QA?t=00h26m55s)



[want to take a look at because this](https://youtu.be/R1jehN-p2QA?t=00h26m57s)



[looks cool](https://youtu.be/R1jehN-p2QA?t=00h26m58s)



[did you do so this grabs the latest hash](https://youtu.be/R1jehN-p2QA?t=00h26m59s)



[file path URL points it in link style](https://youtu.be/R1jehN-p2QA?t=00h27m06s)



[and theme oh this excites me a lot this](https://youtu.be/R1jehN-p2QA?t=00h27m10s)



[excites me a lot okay so let's go](https://youtu.be/R1jehN-p2QA?t=00h27m14s)



[through and let's just check out this](https://youtu.be/R1jehN-p2QA?t=00h27m16s)



[pull request so 1470 because this was](https://youtu.be/R1jehN-p2QA?t=00h27m18s)



[one I was hoping somebody would pick up](https://youtu.be/R1jehN-p2QA?t=00h27m21s)



[for me because I am I am not great with](https://youtu.be/R1jehN-p2QA?t=00h27m22s)



[PowerShell I use it and it's it's nice](https://youtu.be/R1jehN-p2QA?t=00h27m25s)



[and it's wonderful and I will not claim](https://youtu.be/R1jehN-p2QA?t=00h27m28s)



[to be an expert at all okay so we got](https://youtu.be/R1jehN-p2QA?t=00h27m30s)



[that guy open see I can kill and kill](https://youtu.be/R1jehN-p2QA?t=00h27m34s)



[you for money now let's flip you over to](https://youtu.be/R1jehN-p2QA?t=00h27m39s)



[design okay come on over here and let's](https://youtu.be/R1jehN-p2QA?t=00h27m43s)



[go and take a quick look so this guy](https://youtu.be/R1jehN-p2QA?t=00h27m47s)



[here is scripts and run and I'm pretty](https://youtu.be/R1jehN-p2QA?t=00h27m50s)



[sure if I remember correctly this script](https://youtu.be/R1jehN-p2QA?t=00h27m53s)



[doesn't take any parameters I think it's](https://youtu.be/R1jehN-p2QA?t=00h27m57s)



[just I think it just executes and](https://youtu.be/R1jehN-p2QA?t=00h27m59s)



[creates a file locally inside of here](https://youtu.be/R1jehN-p2QA?t=00h28m01s)



[let me just double check that](https://youtu.be/R1jehN-p2QA?t=00h28m02s)



[pretty sure that's the way it works oh](https://youtu.be/R1jehN-p2QA?t=00h28m06s)



[thank you release notes I'm sure you](https://youtu.be/R1jehN-p2QA?t=00h28m11s)



[have awesome stuff](https://youtu.be/R1jehN-p2QA?t=00h28m13s)



[Oh see so yeah it doesn't take any](https://youtu.be/R1jehN-p2QA?t=00h28m14s)



[parameters blah blah blah generate stuff](https://youtu.be/R1jehN-p2QA?t=00h28m19s)



[output file name generates right into](https://youtu.be/R1jehN-p2QA?t=00h28m22s)



[the little directory great perfect okay](https://youtu.be/R1jehN-p2QA?t=00h28m25s)



[so](https://youtu.be/R1jehN-p2QA?t=00h28m27s)



[that's execution doing stuff lots of](https://youtu.be/R1jehN-p2QA?t=00h28m34s)



[running](https://youtu.be/R1jehN-p2QA?t=00h28m37s)



[all right debug output is on by default](https://youtu.be/R1jehN-p2QA?t=00h28m42s)



[that's interesting](https://youtu.be/R1jehN-p2QA?t=00h28m45s)



[do-do-do-do-do-do](https://youtu.be/R1jehN-p2QA?t=00h28m50s)



[I assume it's generating yep great so](https://youtu.be/R1jehN-p2QA?t=00h28m52s)



[let's open this with vs code I have a](https://youtu.be/R1jehN-p2QA?t=00h28m58s)



[markdown viewer installed as one of my](https://youtu.be/R1jehN-p2QA?t=00h29m01s)



[extensions this should give us a nice](https://youtu.be/R1jehN-p2QA?t=00h29m04s)



[look of what this does great show me the](https://youtu.be/R1jehN-p2QA?t=00h29m07s)



[preview pane yeah I don't know why you](https://youtu.be/R1jehN-p2QA?t=00h29m10s)



[think remote WSL is needed for markdown](https://youtu.be/R1jehN-p2QA?t=00h29m13s)



[nope](https://youtu.be/R1jehN-p2QA?t=00h29m16s)



[go away cool so it doesn't do the link](https://youtu.be/R1jehN-p2QA?t=00h29m17s)



[on the default styles but it does do it](https://youtu.be/R1jehN-p2QA?t=00h29m24s)



[on all of the named ones](https://youtu.be/R1jehN-p2QA?t=00h29m26s)



[go ahead and open the link](https://youtu.be/R1jehN-p2QA?t=00h29m32s)



[sweet this gets pretty darn close so now](https://youtu.be/R1jehN-p2QA?t=00h29m40s)



[if we are able to strip out the we're](https://youtu.be/R1jehN-p2QA?t=00h29m47s)



[able to get the line numbers out of](https://youtu.be/R1jehN-p2QA?t=00h29m54s)



[where it's done the parsing I believe](https://youtu.be/R1jehN-p2QA?t=00h29m55s)



[it's just something like line 25 yeah so](https://youtu.be/R1jehN-p2QA?t=00h29m58s)



[it'd be great if we could do like line](https://youtu.be/R1jehN-p2QA?t=00h30m02s)



[25 through 30 right is that it's not the](https://youtu.be/R1jehN-p2QA?t=00h30m04s)



[syntax for it what is the when in doubt](https://youtu.be/R1jehN-p2QA?t=00h30m09s)



[just do it in the GUI Oh line 25 through](https://youtu.be/R1jehN-p2QA?t=00h30m13s)



[line 30 okay got it got it got it got it](https://youtu.be/R1jehN-p2QA?t=00h30m16s)



[got it got it cool I think we're gonna](https://youtu.be/R1jehN-p2QA?t=00h30m20s)



[merge this but I'm probably gonna leave](https://youtu.be/R1jehN-p2QA?t=00h30m26s)



[the ticket open because two things I](https://youtu.be/R1jehN-p2QA?t=00h30m29s)



[would love to see is one I would love to](https://youtu.be/R1jehN-p2QA?t=00h30m33s)



[see hyperlinks on the default style ones](https://youtu.be/R1jehN-p2QA?t=00h30m35s)



[as well and then I'd also love to see](https://youtu.be/R1jehN-p2QA?t=00h30m37s)



[these these hyperlinks have that line](https://youtu.be/R1jehN-p2QA?t=00h30m40s)



[number syntax and I believe I mean let](https://youtu.be/R1jehN-p2QA?t=00h30m44s)



[me just look this up well hang on I may](https://youtu.be/R1jehN-p2QA?t=00h30m46s)



[have done this already](https://youtu.be/R1jehN-p2QA?t=00h30m50s)



[let's go through and look](https://youtu.be/R1jehN-p2QA?t=00h30m52s)



[I think I did this at the 1380 1380](https://youtu.be/R1jehN-p2QA?t=00h30m54s)



[[Music]](https://youtu.be/R1jehN-p2QA?t=00h31m05s)



[I really wish github would let me like](https://youtu.be/R1jehN-p2QA?t=00h31m07s)



[it's linked these items together but it](https://youtu.be/R1jehN-p2QA?t=00h31m10s)



[doesn't it doesn't let it doesn't let me](https://youtu.be/R1jehN-p2QA?t=00h31m16s)



[click on it which is really kind of](https://youtu.be/R1jehN-p2QA?t=00h31m18s)



[frustrating 1380](https://youtu.be/R1jehN-p2QA?t=00h31m20s)



[yeah](https://youtu.be/R1jehN-p2QA?t=00h31m28s)



[so this has the information for the get](https://youtu.be/R1jehN-p2QA?t=00h31m31s)



[hash stuff yeah and this is the the line](https://youtu.be/R1jehN-p2QA?t=00h31m33s)



[number link oh and I guess we probably](https://youtu.be/R1jehN-p2QA?t=00h31m40s)



[it's probably difficult to get the](https://youtu.be/R1jehN-p2QA?t=00h31m42s)



[closing tag line number so if we could](https://youtu.be/R1jehN-p2QA?t=00h31m44s)



[at least get the starting tag line](https://youtu.be/R1jehN-p2QA?t=00h31m45s)



[number that would be nice yeah so this](https://youtu.be/R1jehN-p2QA?t=00h31m47s)



[gets this gets pretty close I believe](https://youtu.be/R1jehN-p2QA?t=00h31m52s)



[what you can do though is the parser for](https://youtu.be/R1jehN-p2QA?t=00h31m55s)



[the XML look at what this guy is using I](https://youtu.be/R1jehN-p2QA?t=00h31m59s)



[believe you can turn on getting line](https://youtu.be/R1jehN-p2QA?t=00h32m04s)



[numbers with it again I think the the](https://youtu.be/R1jehN-p2QA?t=00h32m07s)



[script appears to be just fine and this](https://youtu.be/R1jehN-p2QA?t=00h32m11s)



[is a significant improvement over where](https://youtu.be/R1jehN-p2QA?t=00h32m13s)



[it was so I think we're just going to](https://youtu.be/R1jehN-p2QA?t=00h32m15s)



[merge it but I think I'm gonna leave the](https://youtu.be/R1jehN-p2QA?t=00h32m17s)



[item open for it let's see get content](https://youtu.be/R1jehN-p2QA?t=00h32m18s)



[zammis string where is the xml person](https://youtu.be/R1jehN-p2QA?t=00h32m24s)



[clinking style sort by blah blah blah](https://youtu.be/R1jehN-p2QA?t=00h32m34s)



[blah](https://youtu.be/R1jehN-p2QA?t=00h32m38s)



[I'd output file set defaults](https://youtu.be/R1jehN-p2QA?t=00h32m41s)



[this just read Jack Cena](https://youtu.be/R1jehN-p2QA?t=00h32m51s)



[no it is pulling okay there we go say I](https://youtu.be/R1jehN-p2QA?t=00h33m03s)



[could have sworn there was XML parsing](https://youtu.be/R1jehN-p2QA?t=00h33m07s)



[let's look this up real quick our show](https://youtu.be/R1jehN-p2QA?t=00h33m11s)



[XML line numbers because I believe in](https://youtu.be/R1jehN-p2QA?t=00h33m15s)



[the XML parser there is a setting to be](https://youtu.be/R1jehN-p2QA?t=00h33m20s)



[able to go through and turn on showing](https://youtu.be/R1jehN-p2QA?t=00h33m22s)



[line numbers look at that looks like I](https://youtu.be/R1jehN-p2QA?t=00h33m25s)



[was searching for this before let's take](https://youtu.be/R1jehN-p2QA?t=00h33m27s)



[a quick peek of what there is](https://youtu.be/R1jehN-p2QA?t=00h33m31s)



[let's see did you do](https://youtu.be/R1jehN-p2QA?t=00h33m46s)



[for each](https://youtu.be/R1jehN-p2QA?t=00h33m56s)



[okay](https://youtu.be/R1jehN-p2QA?t=00h34m01s)



[this is just auto incrementing](https://youtu.be/R1jehN-p2QA?t=00h34m04s)



[I don't think that's quite what we're](https://youtu.be/R1jehN-p2QA?t=00h34m16s)



[after don't think that's quite what I](https://youtu.be/R1jehN-p2QA?t=00h34m18s)



[want](https://youtu.be/R1jehN-p2QA?t=00h34m22s)



[[Music]](https://youtu.be/R1jehN-p2QA?t=00h34m23s)



[let's see here](https://youtu.be/R1jehN-p2QA?t=00h34m25s)



[so what is this doing so move history](https://youtu.be/R1jehN-p2QA?t=00h34m35s)



[for each object new object power so](https://youtu.be/R1jehN-p2QA?t=00h34m39s)



[light on line under status time so this](https://youtu.be/R1jehN-p2QA?t=00h34m41s)



[is just iterating over a collection of](https://youtu.be/R1jehN-p2QA?t=00h34m46s)



[objects and in auto incrementing a value](https://youtu.be/R1jehN-p2QA?t=00h34m49s)



[for the line number](https://youtu.be/R1jehN-p2QA?t=00h34m52s)



[okay](https://youtu.be/R1jehN-p2QA?t=00h34m56s)



[here](https://youtu.be/R1jehN-p2QA?t=00h35m03s)



[and](https://youtu.be/R1jehN-p2QA?t=00h35m07s)



[this is getting close ish](https://youtu.be/R1jehN-p2QA?t=00h35m09s)



[it's just adding it why I feel like it's](https://youtu.be/R1jehN-p2QA?t=00h35m19s)



[missing the XML part of my query](https://youtu.be/R1jehN-p2QA?t=00h35m23s)



[did you do](https://youtu.be/R1jehN-p2QA?t=00h35m39s)



[I really there there is a way on the XML](https://youtu.be/R1jehN-p2QA?t=00h35m45s)



[parser and dotnet maybe that's the](https://youtu.be/R1jehN-p2QA?t=00h35m48s)



[kicker c-sharp XML credit line number is](https://youtu.be/R1jehN-p2QA?t=00h35m51s)



[probably what I'm thinking of this is](https://youtu.be/R1jehN-p2QA?t=00h35m57s)



[probably more akin to](https://youtu.be/R1jehN-p2QA?t=00h36m00s)



[let's see I XML line info blah blah blah](https://youtu.be/R1jehN-p2QA?t=00h36m07s)



[hablo chillage get a return line info](https://youtu.be/R1jehN-p2QA?t=00h36m25s)



[yeah because this is interesting](https://youtu.be/R1jehN-p2QA?t=00h36m28s)



[okay well I'm not gonna spend a whole](https://youtu.be/R1jehN-p2QA?t=00h36m36s)



[bunch of time digging on it](https://youtu.be/R1jehN-p2QA?t=00h36m38s)



[but regardless we're gonna take this](https://youtu.be/R1jehN-p2QA?t=00h36m39s)



[so let's see and you go into the 300](https://youtu.be/R1jehN-p2QA?t=00h36m51s)



[milestone because that's what we're](https://youtu.be/R1jehN-p2QA?t=00h36m55s)



[working on squash merge squash merge](https://youtu.be/R1jehN-p2QA?t=00h36m56s)



[that's done just refresh here and make](https://youtu.be/R1jehN-p2QA?t=00h37m09s)



[sure this is cleaned up this has been](https://youtu.be/R1jehN-p2QA?t=00h37m11s)



[partially completed](https://youtu.be/R1jehN-p2QA?t=00h37m19s)



[two more items that would be nice to add](https://youtu.be/R1jehN-p2QA?t=00h37m23s)



[default style](https://youtu.be/R1jehN-p2QA?t=00h37m34s)



[thanks to exact](https://youtu.be/R1jehN-p2QA?t=00h37m40s)



[numbers source](https://youtu.be/R1jehN-p2QA?t=00h37m44s)



[cool so if anyone wants to dig in to](https://youtu.be/R1jehN-p2QA?t=00h37m48s)



[that let me know that would be cool](https://youtu.be/R1jehN-p2QA?t=00h37m50s)



[again and hopefully with any luck after](https://youtu.be/R1jehN-p2QA?t=00h37m53s)



[that guy merges I want to leave this](https://youtu.be/R1jehN-p2QA?t=00h37m57s)



[open because in a little bit I should be](https://youtu.be/R1jehN-p2QA?t=00h38m00s)



[able to hit refresh and see the updated](https://youtu.be/R1jehN-p2QA?t=00h38m03s)



[bit there okay](https://youtu.be/R1jehN-p2QA?t=00h38m04s)



[next updated readme this is probably a](https://youtu.be/R1jehN-p2QA?t=00h38m07s)



[simple one not surprised and I](https://youtu.be/R1jehN-p2QA?t=00h38m10s)



[appreciate people who have given me this](https://youtu.be/R1jehN-p2QA?t=00h38m16s)



[let's see let's see](https://youtu.be/R1jehN-p2QA?t=00h38m18s)



[you'll need from 2017 to 2019](https://youtu.be/R1jehN-p2QA?t=00h38m21s)



[that looks really because this is one](https://youtu.be/R1jehN-p2QA?t=00h38m26s)



[big line that it just it won't show me](https://youtu.be/R1jehN-p2QA?t=00h38m32s)



[the diff looks like that's the only](https://youtu.be/R1jehN-p2QA?t=00h38m34s)



[change great](https://youtu.be/R1jehN-p2QA?t=00h38m36s)



[to do that the dude to do see good catch](https://youtu.be/R1jehN-p2QA?t=00h38m43s)



[not that milestones really matter on](https://youtu.be/R1jehN-p2QA?t=00h38m53s)



[readme changes but we'll take those as](https://youtu.be/R1jehN-p2QA?t=00h39m00s)



[well](https://youtu.be/R1jehN-p2QA?t=00h39m02s)



[again I appreciate everyone who helps](https://youtu.be/R1jehN-p2QA?t=00h39m03s)



[out with the documentation on this](https://youtu.be/R1jehN-p2QA?t=00h39m05s)



[because that is always one of the](https://youtu.be/R1jehN-p2QA?t=00h39m07s)



[hardest things to keep up to date ooh](https://youtu.be/R1jehN-p2QA?t=00h39m08s)



[icon update as your pipelines for those](https://youtu.be/R1jehN-p2QA?t=00h39m11s)



[who are unaware there is also an azure](https://youtu.be/R1jehN-p2QA?t=00h39m15s)



[pipeline that runs nightly it goes out](https://youtu.be/R1jehN-p2QA?t=00h39m17s)



[and downloads all of the latest icons](https://youtu.be/R1jehN-p2QA?t=00h39m20s)



[from the material design icon set so the](https://youtu.be/R1jehN-p2QA?t=00h39m22s)



[preview nougat packages should be no](https://youtu.be/R1jehN-p2QA?t=00h39m25s)



[more than about 24 hours off](https://youtu.be/R1jehN-p2QA?t=00h39m27s)



[I usually just double check to make sure](https://youtu.be/R1jehN-p2QA?t=00h39m30s)



[there aren't any breaking changes so for](https://youtu.be/R1jehN-p2QA?t=00h39m33s)



[example I see a deletion here for search](https://youtu.be/R1jehN-p2QA?t=00h39m36s)



[but I see that it was really just moved](https://youtu.be/R1jehN-p2QA?t=00h39m37s)



[down here there are technically probably](https://youtu.be/R1jehN-p2QA?t=00h39m39s)



[breaking changes as the material design](https://youtu.be/R1jehN-p2QA?t=00h39m43s)



[icon library changes the contents of](https://youtu.be/R1jehN-p2QA?t=00h39m45s)



[icons but that doesn't happen too often](https://youtu.be/R1jehN-p2QA?t=00h39m48s)



[but be aware I there's not a great way](https://youtu.be/R1jehN-p2QA?t=00h39m51s)



[for me to check for those because I do](https://youtu.be/R1jehN-p2QA?t=00h39m54s)



[not want to go through and if the look](https://youtu.be/R1jehN-p2QA?t=00h39m56s)



[of every single one of these icons on](https://youtu.be/R1jehN-p2QA?t=00h39m58s)



[every single request or even every](https://youtu.be/R1jehN-p2QA?t=00h39m59s)



[single release so I try to document when](https://youtu.be/R1jehN-p2QA?t=00h40m01s)



[there's breaking changes to the Inu for](https://youtu.be/R1jehN-p2QA?t=00h40m04s)



[the pack icon kind and then I just let](https://youtu.be/R1jehN-p2QA?t=00h40m06s)



[it go so if there are breaking changes](https://youtu.be/R1jehN-p2QA?t=00h40m09s)



[to you from this enum value those should](https://youtu.be/R1jehN-p2QA?t=00h40m13s)



[be in the release notes](https://youtu.be/R1jehN-p2QA?t=00h40m16s)



[let's see squash and merge](https://youtu.be/R1jehN-p2QA?t=00h40m18s)



[oh yeah we can delete the branch we](https://youtu.be/R1jehN-p2QA?t=00h40m21s)



[don't need it sitting out there great](https://youtu.be/R1jehN-p2QA?t=00h40m24s)



[just kill and pull request left and](https://youtu.be/R1jehN-p2QA?t=00h40m27s)



[right just keep going well let's just](https://youtu.be/R1jehN-p2QA?t=00h40m29s)



[keep going](https://youtu.be/R1jehN-p2QA?t=00h40m36s)



[let's see filter chips I think I looked](https://youtu.be/R1jehN-p2QA?t=00h40m38s)



[at this one before Magnus was working on](https://youtu.be/R1jehN-p2QA?t=00h40m40s)



[this and yeah I the if you're watching](https://youtu.be/R1jehN-p2QA?t=00h40m43s)



[this Magnus the the look of what you've](https://youtu.be/R1jehN-p2QA?t=00h40m48s)



[got so far looks great](https://youtu.be/R1jehN-p2QA?t=00h40m51s)



[I checked the source code everything I](https://youtu.be/R1jehN-p2QA?t=00h40m52s)



[see there looks fine all of my](https://youtu.be/R1jehN-p2QA?t=00h40m55s)



[outstanding items and comments on there](https://youtu.be/R1jehN-p2QA?t=00h40m57s)



[you've already indicated of what still](https://youtu.be/R1jehN-p2QA?t=00h40m59s)



[needs to be done so if you want any help](https://youtu.be/R1jehN-p2QA?t=00h41m01s)



[with this let me know happy to jump in](https://youtu.be/R1jehN-p2QA?t=00h41m05s)



[but overall looks like this is well on](https://youtu.be/R1jehN-p2QA?t=00h41m06s)



[its way okay let's see grab this guy up](https://youtu.be/R1jehN-p2QA?t=00h41m09s)



[here](https://youtu.be/R1jehN-p2QA?t=00h41m15s)



[so adding track background to switch](https://youtu.be/R1jehN-p2QA?t=00h41m15s)



[toggle this one's probably a simple one](https://youtu.be/R1jehN-p2QA?t=00h41m17s)



[let's go through and I think the easiest](https://youtu.be/R1jehN-p2QA?t=00h41m23s)



[way to do this is to just check it out](https://youtu.be/R1jehN-p2QA?t=00h41m28s)



[build and run so let's see PR 1460](https://youtu.be/R1jehN-p2QA?t=00h41m32s)



[poll requests 1460 yes](https://youtu.be/R1jehN-p2QA?t=00h41m38s)



[for anyone who is ever managing open](https://youtu.be/R1jehN-p2QA?t=00h41m50s)



[source projects and get cracking if you](https://youtu.be/R1jehN-p2QA?t=00h41m52s)



[go to check out a pull request and the](https://youtu.be/R1jehN-p2QA?t=00h41m54s)



[branch that it's coming from matches one](https://youtu.be/R1jehN-p2QA?t=00h41m55s)



[of your existing branches that's when](https://youtu.be/R1jehN-p2QA?t=00h41m57s)



[you get this prompt it's just saying](https://youtu.be/R1jehN-p2QA?t=00h41m59s)



[that it doesn't know what to create it](https://youtu.be/R1jehN-p2QA?t=00h42m00s)



[is worth knowing](https://youtu.be/R1jehN-p2QA?t=00h42m04s)



[especially as you start checking out](https://youtu.be/R1jehN-p2QA?t=00h42m05s)



[multiple pour requests every time you](https://youtu.be/R1jehN-p2QA?t=00h42m06s)



[click on one of these the little prompt](https://youtu.be/R1jehN-p2QA?t=00h42m08s)



[that came up at the beginning was](https://youtu.be/R1jehN-p2QA?t=00h42m10s)



[basically just asking and saying hey do](https://youtu.be/R1jehN-p2QA?t=00h42m11s)



[you want to add a remote to that](https://youtu.be/R1jehN-p2QA?t=00h42m13s)



[person's repository and check out the](https://youtu.be/R1jehN-p2QA?t=00h42m14s)



[branch it's like yes ish I kind of wish](https://youtu.be/R1jehN-p2QA?t=00h42m17s)



[there was an option for just check out](https://youtu.be/R1jehN-p2QA?t=00h42m23s)



[the current stuff without let's whack](https://youtu.be/R1jehN-p2QA?t=00h42m26s)



[this file quit showing up kind of wish](https://youtu.be/R1jehN-p2QA?t=00h42m28s)



[there was an option for check out branch](https://youtu.be/R1jehN-p2QA?t=00h42m31s)



[but do the shallow clone without adding](https://youtu.be/R1jehN-p2QA?t=00h42m33s)



[the remote because I really don't want](https://youtu.be/R1jehN-p2QA?t=00h42m36s)



[to attract some I guess sometimes I do](https://youtu.be/R1jehN-p2QA?t=00h42m38s)



[but it would be nice if I could just not](https://youtu.be/R1jehN-p2QA?t=00h42m40s)



[accumulate all of these remotes okay so](https://youtu.be/R1jehN-p2QA?t=00h42m43s)



[let's just fire off the demo and we'll](https://youtu.be/R1jehN-p2QA?t=00h42m47s)



[see where that goes Visual Studio](https://youtu.be/R1jehN-p2QA?t=00h42m50s)



[probably takes a moment well it figures](https://youtu.be/R1jehN-p2QA?t=00h42m51s)



[out what it did and I think this roughly](https://youtu.be/R1jehN-p2QA?t=00h42m53s)



[matches what what I expected from it so](https://youtu.be/R1jehN-p2QA?t=00h42m56s)



[under the toggle button assist switch](https://youtu.be/R1jehN-p2QA?t=00h43m00s)



[track background okay takes in a new](https://youtu.be/R1jehN-p2QA?t=00h43m04s)



[brush which is great which lets you](https://youtu.be/R1jehN-p2QA?t=00h43m08s)



[change the color](https://youtu.be/R1jehN-p2QA?t=00h43m11s)



[so this before let's see so it's](https://youtu.be/R1jehN-p2QA?t=00h43m14s)



[defaulting to primary hue light so let's](https://youtu.be/R1jehN-p2QA?t=00h43m17s)



[just verify that that's where it was](https://youtu.be/R1jehN-p2QA?t=00h43m21s)



[before so this is now defaulting to the](https://youtu.be/R1jehN-p2QA?t=00h43m22s)



[switch background so before it was](https://youtu.be/R1jehN-p2QA?t=00h43m30s)



[defaulting to that but only unchecked](https://youtu.be/R1jehN-p2QA?t=00h43m36s)



[I'm wondering is this correct pass](https://youtu.be/R1jehN-p2QA?t=00h43m40s)



[switch background this is this fill I'm](https://youtu.be/R1jehN-p2QA?t=00h43m44s)



[wondering if this should be all this](https://youtu.be/R1jehN-p2QA?t=00h43m47s)



[fill was black before](https://youtu.be/R1jehN-p2QA?t=00h43m51s)



[who does this mean I think this default](https://youtu.be/R1jehN-p2QA?t=00h43m56s)



[is wrong](https://youtu.be/R1jehN-p2QA?t=00h44m00s)



[I think this default should probably](https://youtu.be/R1jehN-p2QA?t=00h44m01s)



[change](https://youtu.be/R1jehN-p2QA?t=00h44m04s)



[yeah I'm thinking this default is](https://youtu.be/R1jehN-p2QA?t=00h44m09s)



[probably off because this means that the](https://youtu.be/R1jehN-p2QA?t=00h44m11s)



[background is going to be the primary](https://youtu.be/R1jehN-p2QA?t=00h44m14s)



[hue light brush for both checked and](https://youtu.be/R1jehN-p2QA?t=00h44m17s)



[unchecked and that is that is not](https://youtu.be/R1jehN-p2QA?t=00h44m20s)



[correct this looks this looks correct](https://youtu.be/R1jehN-p2QA?t=00h44m23s)



[because this is the way you can't use a](https://youtu.be/R1jehN-p2QA?t=00h44m29s)



[template binding at a to an attached](https://youtu.be/R1jehN-p2QA?t=00h44m31s)



[property you have to do the long binding](https://youtu.be/R1jehN-p2QA?t=00h44m35s)



[syntax with the relative source yeah](https://youtu.be/R1jehN-p2QA?t=00h44m38s)



[just this difference between this fill](https://youtu.be/R1jehN-p2QA?t=00h44m43s)



[here and this fill here I think is the](https://youtu.be/R1jehN-p2QA?t=00h44m45s)



[big the big kicker so we might just go](https://youtu.be/R1jehN-p2QA?t=00h44m52s)



[fix that real quick but let's see here](https://youtu.be/R1jehN-p2QA?t=00h44m56s)



[so this guy is properly defaulting to](https://youtu.be/R1jehN-p2QA?t=00h45m01s)



[black](https://youtu.be/R1jehN-p2QA?t=00h45m03s)



[I'm wondering if that's correct](https://youtu.be/R1jehN-p2QA?t=00h45m11s)



[I'm wondering if that's correct I think](https://youtu.be/R1jehN-p2QA?t=00h45m14s)



[that's actually what I put in the thing](https://youtu.be/R1jehN-p2QA?t=00h45m16s)



[that's what I put in the issue text see](https://youtu.be/R1jehN-p2QA?t=00h45m19s)



[1408 refresh](https://youtu.be/R1jehN-p2QA?t=00h45m21s)



[and let's go pull that issue up real](https://youtu.be/R1jehN-p2QA?t=00h45m26s)



[quick](https://youtu.be/R1jehN-p2QA?t=00h45m27s)



[so I think that's what I put in the](https://youtu.be/R1jehN-p2QA?t=00h45m32s)



[issue Texas for the thing to default but](https://youtu.be/R1jehN-p2QA?t=00h45m33s)



[the intention was for the default to be](https://youtu.be/R1jehN-p2QA?t=00h45m35s)



[set in the style and the style setters](https://youtu.be/R1jehN-p2QA?t=00h45m37s)



[not in the attached property come on run](https://youtu.be/R1jehN-p2QA?t=00h45m40s)



[I should go and look and see what the](https://youtu.be/R1jehN-p2QA?t=00h45m48s)



[trigger is for this it could be that the](https://youtu.be/R1jehN-p2QA?t=00h45m50s)



[the trigger on this guy is set late and](https://youtu.be/R1jehN-p2QA?t=00h45m52s)



[runs once a day](https://youtu.be/R1jehN-p2QA?t=00h45m55s)



[let's see add new attached property oh](https://youtu.be/R1jehN-p2QA?t=00h45m58s)



[it should default the black that's](https://youtu.be/R1jehN-p2QA?t=00h46m01s)



[exactly what I said that was dumb of me](https://youtu.be/R1jehN-p2QA?t=00h46m03s)



[this new do use this new attached](https://youtu.be/R1jehN-p2QA?t=00h46m07s)



[property in the fill for rectangle got](https://youtu.be/R1jehN-p2QA?t=00h46m12s)



[it](https://youtu.be/R1jehN-p2QA?t=00h46m19s)



[great](https://youtu.be/R1jehN-p2QA?t=00h46m22s)



[let's take a look let's take a look](https://youtu.be/R1jehN-p2QA?t=00h46m24s)



[come on I thought we said go come on](https://youtu.be/R1jehN-p2QA?t=00h46m28s)



[visual studio you can do it is there a](https://youtu.be/R1jehN-p2QA?t=00h46m32s)



[build area of some kind](https://youtu.be/R1jehN-p2QA?t=00h46m34s)



[detective package downgrade what is your](https://youtu.be/R1jehN-p2QA?t=00h46m37s)



[problem what is your problem now some](https://youtu.be/R1jehN-p2QA?t=00h46m41s)



[days you make my life hard power shell](https://youtu.be/R1jehN-p2QA?t=00h46m53s)



[window here packet](https://youtu.be/R1jehN-p2QA?t=00h46m58s)



[see I think it's install and then](https://youtu.be/R1jehN-p2QA?t=00h47m11s)



[restores what I need to get out of this](https://youtu.be/R1jehN-p2QA?t=00h47m13s)



[I was messing around moving stuff in](https://youtu.be/R1jehN-p2QA?t=00h47m15s)



[different branches and I think I left](https://youtu.be/R1jehN-p2QA?t=00h47m19s)



[myself in a not very bad state the other](https://youtu.be/R1jehN-p2QA?t=00h47m20s)



[option is get clean](https://youtu.be/R1jehN-p2QA?t=00h47m28s)



[to do see why do you think you are on a](https://youtu.be/R1jehN-p2QA?t=00h47m36s)



[preview version of c-sharp to do yeah](https://youtu.be/R1jehN-p2QA?t=00h47m42s)



[you shouldn't be on a preview version to](https://youtu.be/R1jehN-p2QA?t=00h47m49s)



[c-sharp anymore figure it out there you](https://youtu.be/R1jehN-p2QA?t=00h47m50s)



[go there you go](https://youtu.be/R1jehN-p2QA?t=00h47m55s)



[okay and that should have gotten us out](https://youtu.be/R1jehN-p2QA?t=00h48m04s)



[of that situation](https://youtu.be/R1jehN-p2QA?t=00h48m07s)



[doesn't worry me that I've got this many](https://youtu.be/R1jehN-p2QA?t=00h48m15s)



[airs cropping up and I guess not airs](https://youtu.be/R1jehN-p2QA?t=00h48m16s)



[warnings and the warnings off for a](https://youtu.be/R1jehN-p2QA?t=00h48m21s)



[minute detective package downgrade from](https://youtu.be/R1jehN-p2QA?t=00h48m24s)



[four six four six preview seven why do](https://youtu.be/R1jehN-p2QA?t=00h48m28s)



[you still think it's there pretty sure](https://youtu.be/R1jehN-p2QA?t=00h48m32s)



[we just said turn you off](https://youtu.be/R1jehN-p2QA?t=00h48m35s)



[okay clues just did this](https://youtu.be/R1jehN-p2QA?t=00h48m41s)



[shut down Visual Studio](https://youtu.be/R1jehN-p2QA?t=00h48m48s)



[don't have time to think about you get](https://youtu.be/R1jehN-p2QA?t=00h48m51s)



[clean dfx torch the earth so be very](https://youtu.be/R1jehN-p2QA?t=00h48m54s)



[careful with this command get clean](https://youtu.be/R1jehN-p2QA?t=00h49m00s)



[- dfx basically says reset my repository](https://youtu.be/R1jehN-p2QA?t=00h49m03s)



[into a clean checkout state so delete](https://youtu.be/R1jehN-p2QA?t=00h49m06s)



[all files that are not under source](https://youtu.be/R1jehN-p2QA?t=00h49m10s)



[control so this will whack your bin](https://youtu.be/R1jehN-p2QA?t=00h49m12s)



[directories your obj directories your](https://youtu.be/R1jehN-p2QA?t=00h49m14s)



[package directories all of those so](https://youtu.be/R1jehN-p2QA?t=00h49m16s)



[you'll note a ton of these things get](https://youtu.be/R1jehN-p2QA?t=00h49m19s)



[cleaned up right the convenient part is](https://youtu.be/R1jehN-p2QA?t=00h49m21s)



[it's a great way to get yourself back](https://youtu.be/R1jehN-p2QA?t=00h49m25s)



[into a working state if you've gone and](https://youtu.be/R1jehN-p2QA?t=00h49m27s)



[messed something up but also be aware](https://youtu.be/R1jehN-p2QA?t=00h49m30s)



[it's going to throw away all of your](https://youtu.be/R1jehN-p2QA?t=00h49m33s)



[pending work so use with caution make](https://youtu.be/R1jehN-p2QA?t=00h49m35s)



[sure all of your stuff is push to github](https://youtu.be/R1jehN-p2QA?t=00h49m40s)



[before you do anything crazy like run](https://youtu.be/R1jehN-p2QA?t=00h49m41s)



[that command okay](https://youtu.be/R1jehN-p2QA?t=00h49m45s)



[now hopefully you're a little less](https://youtu.be/R1jehN-p2QA?t=00h49m49s)



[unhappy with me because you'll notice it](https://youtu.be/R1jehN-p2QA?t=00h49m51s)



[whacked my dot vs directory so it's](https://youtu.be/R1jehN-p2QA?t=00h49m54s)



[forgotten how to collapse things because](https://youtu.be/R1jehN-p2QA?t=00h49m57s)



[reasons don't know why you still show](https://youtu.be/R1jehN-p2QA?t=00h50m00s)



[yellow triangles I'm hoping that's just](https://youtu.be/R1jehN-p2QA?t=00h50m10s)



[the restor that's not happened yet](https://youtu.be/R1jehN-p2QA?t=00h50m13s)



[because the packages directory was nuked](https://youtu.be/R1jehN-p2QA?t=00h50m16s)



[but it should rebuild and then packet](https://youtu.be/R1jehN-p2QA?t=00h50m19s)



[should do its thing as part of the build](https://youtu.be/R1jehN-p2QA?t=00h50m24s)



[process and restore everything and then](https://youtu.be/R1jehN-p2QA?t=00h50m25s)



[I suspect show me the zamel will](https://youtu.be/R1jehN-p2QA?t=00h50m29s)



[complain because this will be its](https://youtu.be/R1jehN-p2QA?t=00h50m31s)



[initial install so for those who haven't](https://youtu.be/R1jehN-p2QA?t=00h50m33s)



[heard me talk about it before our demo](https://youtu.be/R1jehN-p2QA?t=00h50m37s)



[app uses another library that I've](https://youtu.be/R1jehN-p2QA?t=00h50m39s)



[written called show me the sam'l you do](https://youtu.be/R1jehN-p2QA?t=00h50m41s)



[not need it I've seen a lot of people](https://youtu.be/R1jehN-p2QA?t=00h50m45s)



[copy the code out of the demo app and](https://youtu.be/R1jehN-p2QA?t=00h50m46s)



[just blindly paste it into their](https://youtu.be/R1jehN-p2QA?t=00h50m48s)



[applications so unless your application](https://youtu.be/R1jehN-p2QA?t=00h50m51s)



[very specifically needs to show people](https://youtu.be/R1jehN-p2QA?t=00h50m53s)



[the sam'l for a particular control you](https://youtu.be/R1jehN-p2QA?t=00h50m55s)



[don't need the library okay](https://youtu.be/R1jehN-p2QA?t=00h50m58s)



[it's only there as part of the demo app](https://youtu.be/R1jehN-p2QA?t=00h51m01s)



[to make it easy for people looking at](https://youtu.be/R1jehN-p2QA?t=00h51m03s)



[the material design controls to copy](https://youtu.be/R1jehN-p2QA?t=00h51m05s)



[that corresponding sam'l out and into](https://youtu.be/R1jehN-p2QA?t=00h51m07s)



[your own application so if you're going](https://youtu.be/R1jehN-p2QA?t=00h51m09s)



[through the demo app and you're like oh](https://youtu.be/R1jehN-p2QA?t=00h51m11s)



[that looks pretty I'd like that](https://youtu.be/R1jehN-p2QA?t=00h51m12s)



[well you click the little sam'l icon in](https://youtu.be/R1jehN-p2QA?t=00h51m14s)



[the bottom right hand corner of it and](https://youtu.be/R1jehN-p2QA?t=00h51m16s)



[it'll give you a little pop-up with all](https://youtu.be/R1jehN-p2QA?t=00h51m17s)



[of the text that you can copy out and](https://youtu.be/R1jehN-p2QA?t=00h51m19s)



[away you go so works great it's](https://youtu.be/R1jehN-p2QA?t=00h51m20s)



[wonderful the but if you're just copying](https://youtu.be/R1jehN-p2QA?t=00h51m23s)



[from the source code of the demo app you](https://youtu.be/R1jehN-p2QA?t=00h51m26s)



[can omit that you don't need it okay](https://youtu.be/R1jehN-p2QA?t=00h51m28s)



[just grab everything inside of it not](https://youtu.be/R1jehN-p2QA?t=00h51m29s)



[the control itself so just be aware of](https://youtu.be/R1jehN-p2QA?t=00h51m32s)



[that the the problem is is on a fresh](https://youtu.be/R1jehN-p2QA?t=00h51m36s)



[clone of the repository when you first](https://youtu.be/R1jehN-p2QA?t=00h51m39s)



[download that nougat package because of](https://youtu.be/R1jehN-p2QA?t=00h51m41s)



[the way packet works but the show me the](https://youtu.be/R1jehN-p2QA?t=00h51m45s)



[sam'l runs as part of the build pipeline](https://youtu.be/R1jehN-p2QA?t=00h51m49s)



[but if it's installed as part of the](https://youtu.be/R1jehN-p2QA?t=00h51m51s)



[pipeline it can't actually run on that](https://youtu.be/R1jehN-p2QA?t=00h51m53s)



[same initialization run so what it does](https://youtu.be/R1jehN-p2QA?t=00h51m57s)



[is it actually throws an error and says](https://youtu.be/R1jehN-p2QA?t=00h51m59s)



[please rebuild one more time so](https://youtu.be/R1jehN-p2QA?t=00h52m01s)



[hopefully that is the air that we just](https://youtu.be/R1jehN-p2QA?t=00h52m04s)



[got here](https://youtu.be/R1jehN-p2QA?t=00h52m06s)



[yeah show me the sam'l was added to the](https://youtu.be/R1jehN-p2QA?t=00h52m08s)



[material design demo project please](https://youtu.be/R1jehN-p2QA?t=00h52m11s)



[rebuild the project so as the as the](https://youtu.be/R1jehN-p2QA?t=00h52m12s)



[name implies the correct response is](https://youtu.be/R1jehN-p2QA?t=00h52m16s)



[rebuild one more time because once it's](https://youtu.be/R1jehN-p2QA?t=00h52m18s)



[downloaded then it'll be added as part](https://youtu.be/R1jehN-p2QA?t=00h52m21s)



[of the build pipeline and away you go](https://youtu.be/R1jehN-p2QA?t=00h52m23s)



[I am as best I know with my knowledge of](https://youtu.be/R1jehN-p2QA?t=00h52m25s)



[MS build there's not a way around this](https://youtu.be/R1jehN-p2QA?t=00h52m28s)



[problem just with the way packet works](https://youtu.be/R1jehN-p2QA?t=00h52m31s)



[injecting itself as part of the MS build](https://youtu.be/R1jehN-p2QA?t=00h52m36s)



[pipeline there's no good fix for this if](https://youtu.be/R1jehN-p2QA?t=00h52m38s)



[you add it as a new get packaged you can](https://youtu.be/R1jehN-p2QA?t=00h52m41s)



[get around it a little bit at least](https://youtu.be/R1jehN-p2QA?t=00h52m43s)



[within Visual Studio](https://youtu.be/R1jehN-p2QA?t=00h52m45s)



[because Visual Studio will do a new get](https://youtu.be/R1jehN-p2QA?t=00h52m47s)



[package restore before the build which](https://youtu.be/R1jehN-p2QA?t=00h52m48s)



[means it'll get picked up and won't](https://youtu.be/R1jehN-p2QA?t=00h52m51s)



[require a rebuild so if anyone has](https://youtu.be/R1jehN-p2QA?t=00h52m53s)



[suggestions I'm open to it but so far](https://youtu.be/R1jehN-p2QA?t=00h52m56s)



[that's the best I've got where it kicks](https://youtu.be/R1jehN-p2QA?t=00h52m59s)



[an air and tells you to rebuild it again](https://youtu.be/R1jehN-p2QA?t=00h53m00s)



[it's only the very first time on a clean](https://youtu.be/R1jehN-p2QA?t=00h53m02s)



[clone of the project where it has to](https://youtu.be/R1jehN-p2QA?t=00h53m04s)



[redownload the package so if the package](https://youtu.be/R1jehN-p2QA?t=00h53m06s)



[is already there you're good to go or if](https://youtu.be/R1jehN-p2QA?t=00h53m09s)



[you do something like me where you do a](https://youtu.be/R1jehN-p2QA?t=00h53m13s)



[get clean dfx where it blows away your](https://youtu.be/R1jehN-p2QA?t=00h53m15s)



[packages directory yeah it's gonna read](https://youtu.be/R1jehN-p2QA?t=00h53m18s)



[download it going to redownload it it](https://youtu.be/R1jehN-p2QA?t=00h53m19s)



[might grab it from the nougat cache I'm](https://youtu.be/R1jehN-p2QA?t=00h53m26s)



[not entirely sure on that one](https://youtu.be/R1jehN-p2QA?t=00h53m27s)



[I don't quite know how packet does its](https://youtu.be/R1jehN-p2QA?t=00h53m31s)



[new get resolution whether it always](https://youtu.be/R1jehN-p2QA?t=00h53m36s)



[goes to the web to download or whether](https://youtu.be/R1jehN-p2QA?t=00h53m38s)



[it will use the local cache](https://youtu.be/R1jehN-p2QA?t=00h53m41s)



[not tested that do come on bill bill](https://youtu.be/R1jehN-p2QA?t=00h53m47s)



[bill I just want to go and fix this so](https://youtu.be/R1jehN-p2QA?t=00h53m52s)



[we can merge some more pull requests and](https://youtu.be/R1jehN-p2QA?t=00h53m54s)



[a big THANK YOU to everybody who's been](https://youtu.be/R1jehN-p2QA?t=00h53m58s)



[doing pull requests for hack tober fest](https://youtu.be/R1jehN-p2QA?t=00h54m00s)



[it's been awesome to see all of the work](https://youtu.be/R1jehN-p2QA?t=00h54m02s)



[come in from everybody even on other](https://youtu.be/R1jehN-p2QA?t=00h54m05s)



[repositories that I manage I've been](https://youtu.be/R1jehN-p2QA?t=00h54m07s)



[seeing tons of pull requests come in](https://youtu.be/R1jehN-p2QA?t=00h54m09s)



[it's actually been kind of ridiculous](https://youtu.be/R1jehN-p2QA?t=00h54m11s)



[how how quick some issues have gotten](https://youtu.be/R1jehN-p2QA?t=00h54m13s)



[picked up](https://youtu.be/R1jehN-p2QA?t=00h54m18s)



[I was joking with a co-worker we filed](https://youtu.be/R1jehN-p2QA?t=00h54m19s)



[an issue it took 20 minutes for somebody](https://youtu.be/R1jehN-p2QA?t=00h54m23s)



[to find the issue clone fork and clone](https://youtu.be/R1jehN-p2QA?t=00h54m26s)



[the repository fix the issue and submit](https://youtu.be/R1jehN-p2QA?t=00h54m30s)



[a pull request](https://youtu.be/R1jehN-p2QA?t=00h54m32s)



[he was absolutely shocked it was 22](https://youtu.be/R1jehN-p2QA?t=00h54m33s)



[minutes from the time I opened the issue](https://youtu.be/R1jehN-p2QA?t=00h54m37s)



[to the time we received a pull request](https://youtu.be/R1jehN-p2QA?t=00h54m38s)



[it was amazing yeah well it wasn't](https://youtu.be/R1jehN-p2QA?t=00h54m40s)



[necessarily that big of an issue to fix](https://youtu.be/R1jehN-p2QA?t=00h54m44s)



[as Oktoberfest issues are designed to be](https://youtu.be/R1jehN-p2QA?t=00h54m46s)



[you know fairly confined and well](https://youtu.be/R1jehN-p2QA?t=00h54m48s)



[documented as far as what needs to be](https://youtu.be/R1jehN-p2QA?t=00h54m50s)



[done and it was it was an easy issue one](https://youtu.be/R1jehN-p2QA?t=00h54m51s)



[to fix but there's just the fact that](https://youtu.be/R1jehN-p2QA?t=00h54m55s)



[somebody picked it up and had it fixed](https://youtu.be/R1jehN-p2QA?t=00h54m56s)



[in 22 minutes was shocking so this bug](https://youtu.be/R1jehN-p2QA?t=00h54m58s)



[here with the the black on black text](https://youtu.be/R1jehN-p2QA?t=00h55m02s)



[that's only because this pull request is](https://youtu.be/R1jehN-p2QA?t=00h55m04s)



[a little bit older if it was based on](https://youtu.be/R1jehN-p2QA?t=00h55m06s)



[latest that would be fixed okay so let's](https://youtu.be/R1jehN-p2QA?t=00h55m08s)



[go here I believe it's in toggles](https://youtu.be/R1jehN-p2QA?t=00h55m12s)



[oh and this is the other bug](https://youtu.be/R1jehN-p2QA?t=00h55m19s)



[did you do the literature to do to do to](https://youtu.be/R1jehN-p2QA?t=00h55m25s)



[do to do to do to do doo doo doo doo doo](https://youtu.be/R1jehN-p2QA?t=00h55m28s)



[doo](https://youtu.be/R1jehN-p2QA?t=00h55m32s)



[that was the other bug that we probably](https://youtu.be/R1jehN-p2QA?t=00h55m33s)



[fix ok so first thing we're gonna do we](https://youtu.be/R1jehN-p2QA?t=00h55m36s)



[are going to take this guy I don't know](https://youtu.be/R1jehN-p2QA?t=00h55m40s)



[if I need these you actually change](https://youtu.be/R1jehN-p2QA?t=00h55m47s)



[anything or did you just update I think](https://youtu.be/R1jehN-p2QA?t=00h55m51s)



[you're just being a pill because of the](https://youtu.be/R1jehN-p2QA?t=00h55m54s)



[update so we're gonna close Visual](https://youtu.be/R1jehN-p2QA?t=00h55m56s)



[Studio real quick](https://youtu.be/R1jehN-p2QA?t=00h56m01s)



[I think visual studios can be unhappy I](https://youtu.be/R1jehN-p2QA?t=00h56m02s)



[think I'm just gonna take this pull](https://youtu.be/R1jehN-p2QA?t=00h56m04s)



[request and rebase it onto master](https://youtu.be/R1jehN-p2QA?t=00h56m05s)



[because I want to pick up those extra](https://youtu.be/R1jehN-p2QA?t=00h56m07s)



[fixes because I believe one of these](https://youtu.be/R1jehN-p2QA?t=00h56m10s)



[here](https://youtu.be/R1jehN-p2QA?t=00h56m16s)



[Levi](https://youtu.be/R1jehN-p2QA?t=00h56m22s)



[did I not fix it oh there this one this](https://youtu.be/R1jehN-p2QA?t=00h56m25s)



[is well so here's the binding redirect](https://youtu.be/R1jehN-p2QA?t=00h56m31s)



[but](https://youtu.be/R1jehN-p2QA?t=00h56m33s)



[I never so i updated the c-sharp code on](https://youtu.be/R1jehN-p2QA?t=00h56m39s)



[Avalon edit I updated the to the latest](https://youtu.be/R1jehN-p2QA?t=00h56m49s)



[stuff and I apparently never pulled in](https://youtu.be/R1jehN-p2QA?t=00h56m51s)



[that change let's let's fix all of this](https://youtu.be/R1jehN-p2QA?t=00h56m54s)



[real quick so Thank You Jasper for the](https://youtu.be/R1jehN-p2QA?t=00h57m00s)



[the binding redirect that was very](https://youtu.be/R1jehN-p2QA?t=00h57m03s)



[helpful](https://youtu.be/R1jehN-p2QA?t=00h57m05s)



[rebase this guy up on to master that'll](https://youtu.be/R1jehN-p2QA?t=00h57m06s)



[get us at least working okay that'll get](https://youtu.be/R1jehN-p2QA?t=00h57m08s)



[us working I want to circle back to that](https://youtu.be/R1jehN-p2QA?t=00h57m13s)



[show me the sam'l issue after this](https://youtu.be/R1jehN-p2QA?t=00h57m15s)



[because we should adjust that we](https://youtu.be/R1jehN-p2QA?t=00h57m17s)



[shouldn't need the binding redirect and](https://youtu.be/R1jehN-p2QA?t=00h57m19s)



[I think because of my local development](https://youtu.be/R1jehN-p2QA?t=00h57m23s)



[state I was just never hitting it that](https://youtu.be/R1jehN-p2QA?t=00h57m25s)



[is the problem when you are the Builder](https://youtu.be/R1jehN-p2QA?t=00h57m29s)



[of both libraries sometimes there are](https://youtu.be/R1jehN-p2QA?t=00h57m32s)



[extra states that if your CI system](https://youtu.be/R1jehN-p2QA?t=00h57m34s)



[doesn't catch it will never pick it up](https://youtu.be/R1jehN-p2QA?t=00h57m37s)



[it would be nice at some point if the](https://youtu.be/R1jehN-p2QA?t=00h57m40s)



[the appcenter distribution gets a little](https://youtu.be/R1jehN-p2QA?t=00h57m43s)



[bit nicer for like the live testing i](https://youtu.be/R1jehN-p2QA?t=00h57m46s)



[would love to build some UI tests and](https://youtu.be/R1jehN-p2QA?t=00h57m48s)



[run it through there but that is that is](https://youtu.be/R1jehN-p2QA?t=00h57m50s)



[wishing and dreaming that appcenter gets](https://youtu.be/R1jehN-p2QA?t=00h57m54s)



[to for WPF gets feature parity with the](https://youtu.be/R1jehN-p2QA?t=00h57m57s)



[mobile stuff so here's hoping](https://youtu.be/R1jehN-p2QA?t=00h57m59s)



[okay go-go-go recompile rerun now we](https://youtu.be/R1jehN-p2QA?t=00h58m09s)



[should be able to work that does](https://youtu.be/R1jehN-p2QA?t=00h58m17s)



[surprise me a little bit if this thing](https://youtu.be/R1jehN-p2QA?t=00h58m21s)



[was crashing like that](https://youtu.be/R1jehN-p2QA?t=00h58m23s)



[oh I think I saw some chatter between](https://youtu.be/R1jehN-p2QA?t=00h58m28s)



[this guy in Jasper where he had probably](https://youtu.be/R1jehN-p2QA?t=00h58m31s)



[just copied in the app config change to](https://youtu.be/R1jehN-p2QA?t=00h58m34s)



[his local deployment that's probably](https://youtu.be/R1jehN-p2QA?t=00h58m36s)



[what happened because I think he's the](https://youtu.be/R1jehN-p2QA?t=00h58m39s)



[first one who actually bumped into that](https://youtu.be/R1jehN-p2QA?t=00h58m42s)



[binding issue well the surprise that](https://youtu.be/R1jehN-p2QA?t=00h58m46s)



[took so long for it to be found might](https://youtu.be/R1jehN-p2QA?t=00h58m50s)



[need to do a post-mortem on that and](https://youtu.be/R1jehN-p2QA?t=00h58m54s)



[figure out exactly what the condition](https://youtu.be/R1jehN-p2QA?t=00h58m56s)



[was because ideally that's something I](https://youtu.be/R1jehN-p2QA?t=00h58m59s)



[would like for the test to actually](https://youtu.be/R1jehN-p2QA?t=00h59m02s)



[catch](https://youtu.be/R1jehN-p2QA?t=00h59m06s)



[I might have to write some basic happy](https://youtu.be/R1jehN-p2QA?t=00h59m12s)



[em tests or selenium based tests that](https://youtu.be/R1jehN-p2QA?t=00h59m16s)



[just go through and fire up the demo app](https://youtu.be/R1jehN-p2QA?t=00h59m19s)



[and just walk through all the pages and](https://youtu.be/R1jehN-p2QA?t=00h59m21s)



[verify that the app doesn't crash and](https://youtu.be/R1jehN-p2QA?t=00h59m22s)



[that would be that would catch at least](https://youtu.be/R1jehN-p2QA?t=00h59m26s)



[some of these errors the question then](https://youtu.be/R1jehN-p2QA?t=00h59m28s)



[is how to run them effectively I don't](https://youtu.be/R1jehN-p2QA?t=00h59m31s)



[know if I could run those inside of the](https://youtu.be/R1jehN-p2QA?t=00h59m36s)



[build pipeline so you know look Texas](https://youtu.be/R1jehN-p2QA?t=00h59m38s)



[right again huzzah okay back to our](https://youtu.be/R1jehN-p2QA?t=00h59m42s)



[toggles and more importantly let's look](https://youtu.be/R1jehN-p2QA?t=00h59m45s)



[back at this guy and figure out which of](https://youtu.be/R1jehN-p2QA?t=00h59m49s)



[the changes it was so let's see switch](https://youtu.be/R1jehN-p2QA?t=00h59m51s)



[toggle with track background so it's](https://youtu.be/R1jehN-p2QA?t=00h59m58s)



[probably the last one in the line but](https://youtu.be/R1jehN-p2QA?t=01h00m00s)



[it's got a tooltip great](https://youtu.be/R1jehN-p2QA?t=01h00m04s)



[so this gets us pretty close problem is](https://youtu.be/R1jehN-p2QA?t=01h00m14s)



[I don't see magnifier](https://youtu.be/R1jehN-p2QA?t=01h00m18s)



[now I mean that kind of works](https://youtu.be/R1jehN-p2QA?t=01h00m34s)



[well how is that](https://youtu.be/R1jehN-p2QA?t=01h00m41s)



[how is that not picking up that color](https://youtu.be/R1jehN-p2QA?t=01h00m47s)



[change when it's off its they're like no](https://youtu.be/R1jehN-p2QA?t=01h00m48s)



[pasty that's also set let's go and look](https://youtu.be/R1jehN-p2QA?t=01h00m52s)



[because I sort of expected given that](https://youtu.be/R1jehN-p2QA?t=01h00m56s)



[that brush was being hard-coded to the](https://youtu.be/R1jehN-p2QA?t=01h00m58s)



[the light brush in both cases that it](https://youtu.be/R1jehN-p2QA?t=01h01m00s)



[would get picked up on both of them so](https://youtu.be/R1jehN-p2QA?t=01h01m03s)



[let's see toggle toggle toggle toggle](https://youtu.be/R1jehN-p2QA?t=01h01m07s)



[button and let's just look real quick](https://youtu.be/R1jehN-p2QA?t=01h01m10s)



[the change was down around line 335](https://youtu.be/R1jehN-p2QA?t=01h01m13s)



[[Music]](https://youtu.be/R1jehN-p2QA?t=01h01m27s)



[okay so let's just let's let's](https://youtu.be/R1jehN-p2QA?t=01h01m32s)



[multi-line some of this stuff because](https://youtu.be/R1jehN-p2QA?t=01h01m34s)



[this is getting hard to look at collapse](https://youtu.be/R1jehN-p2QA?t=01h01m36s)



[you collapse you let's move some of this](https://youtu.be/R1jehN-p2QA?t=01h01m39s)



[stuff around so we can see what we're](https://youtu.be/R1jehN-p2QA?t=01h01m43s)



[doing this just needs to get moved](https://youtu.be/R1jehN-p2QA?t=01h01m44s)



[around moved around moved around moved](https://youtu.be/R1jehN-p2QA?t=01h01m47s)



[around if anybody is interested in](https://youtu.be/R1jehN-p2QA?t=01h01m49s)



[pulling in sam'l styler I would not mind](https://youtu.be/R1jehN-p2QA?t=01h01m53s)



[getting this set up so that we get a](https://youtu.be/R1jehN-p2QA?t=01h01m58s)



[very consistent format across all of our](https://youtu.be/R1jehN-p2QA?t=01h01m59s)



[sam'l files okay with that said this](https://youtu.be/R1jehN-p2QA?t=01h02m01s)



[feels like there's a trigger something](https://youtu.be/R1jehN-p2QA?t=01h02m07s)



[firing on it that's changing the state](https://youtu.be/R1jehN-p2QA?t=01h02m09s)



[so thumb holder this changes the](https://youtu.be/R1jehN-p2QA?t=01h02m12s)



[translation translation so it's not up](https://youtu.be/R1jehN-p2QA?t=01h02m17s)



[there that's not doing it it's got to be](https://youtu.be/R1jehN-p2QA?t=01h02m19s)



[a trigger so is checked change the fill](https://youtu.be/R1jehN-p2QA?t=01h02m24s)



[changes the foreground indentations off](https://youtu.be/R1jehN-p2QA?t=01h02m30s)



[there](https://youtu.be/R1jehN-p2QA?t=01h02m33s)



[this guy down here so this guy well this](https://youtu.be/R1jehN-p2QA?t=01h02m38s)



[is probably okay because this will give](https://youtu.be/R1jehN-p2QA?t=01h02m43s)



[it a very doled out black color](https://youtu.be/R1jehN-p2QA?t=01h02m46s)



[I think what we want to do](https://youtu.be/R1jehN-p2QA?t=01h02m53s)



[I'm still very confused as to why](https://youtu.be/R1jehN-p2QA?t=01h02m57s)



[this is supposed to be picking up the](https://youtu.be/R1jehN-p2QA?t=01h03m05s)



[background this is supposed to be](https://youtu.be/R1jehN-p2QA?t=01h03m06s)



[picking up the background why do I not](https://youtu.be/R1jehN-p2QA?t=01h03m08s)



[see the background changed here](https://youtu.be/R1jehN-p2QA?t=01h03m13s)



[something's not lining up with what I](https://youtu.be/R1jehN-p2QA?t=01h03m17s)



[expect because I would have expected](https://youtu.be/R1jehN-p2QA?t=01h03m18s)



[this to be the default and then when](https://youtu.be/R1jehN-p2QA?t=01h03m21s)



[this trigger fires on is checked is true](https://youtu.be/R1jehN-p2QA?t=01h03m26s)



[I would expect it to get set to the](https://youtu.be/R1jehN-p2QA?t=01h03m28s)



[exact same thing](https://youtu.be/R1jehN-p2QA?t=01h03m31s)



[track its tracks fill property gets set](https://youtu.be/R1jehN-p2QA?t=01h03m40s)



[for ground property Get Set fill](https://youtu.be/R1jehN-p2QA?t=01h03m45s)



[property get set](https://youtu.be/R1jehN-p2QA?t=01h03m48s)



[okay I am confused I do not understand](https://youtu.be/R1jehN-p2QA?t=01h03m53s)



[how okay everybody's favorite snoop](https://youtu.be/R1jehN-p2QA?t=01h03m56s)



[because I don't know I do not understand](https://youtu.be/R1jehN-p2QA?t=01h04m03s)



[how this is basically working](https://youtu.be/R1jehN-p2QA?t=01h04m05s)



[which which bothers me a little bit I I](https://youtu.be/R1jehN-p2QA?t=01h04m13s)



[do not like the fact that it appears to](https://youtu.be/R1jehN-p2QA?t=01h04m16s)



[be working despite the fact that the](https://youtu.be/R1jehN-p2QA?t=01h04m17s)



[code doesn't appear to be doing what I](https://youtu.be/R1jehN-p2QA?t=01h04m19s)



[expect okay so you sit over here you sit](https://youtu.be/R1jehN-p2QA?t=01h04m22s)



[over here so for example I want to dive](https://youtu.be/R1jehN-p2QA?t=01h04m27s)



[in right to here okay so there's my](https://youtu.be/R1jehN-p2QA?t=01h04m30s)



[thumb doing a decorator track](https://youtu.be/R1jehN-p2QA?t=01h04m35s)



[there's my track what's your fill](https://youtu.be/R1jehN-p2QA?t=01h04m39s)



[property look like deta air that's why](https://youtu.be/R1jehN-p2QA?t=01h04m43s)



[it's failing](https://youtu.be/R1jehN-p2QA?t=01h04m51s)



[can I get switch](https://youtu.be/R1jehN-p2QA?t=01h04m55s)



[invalid caste](https://youtu.be/R1jehN-p2QA?t=01h05m04s)



[which](https://youtu.be/R1jehN-p2QA?t=01h05m13s)



[unable to cast can I get through the](https://youtu.be/R1jehN-p2QA?t=01h05m19s)



[tight solid color brush from type string](https://youtu.be/R1jehN-p2QA?t=01h05m22s)



[something is something is amiss](https://youtu.be/R1jehN-p2QA?t=01h05m32s)



[look](https://youtu.be/R1jehN-p2QA?t=01h05m40s)



[solid color brush sonically brush so why](https://youtu.be/R1jehN-p2QA?t=01h05m53s)



[you think](https://youtu.be/R1jehN-p2QA?t=01h05m57s)



[oh because this is a ha ha ha ha ha ha](https://youtu.be/R1jehN-p2QA?t=01h06m04s)



[this should be this](https://youtu.be/R1jehN-p2QA?t=01h06m09s)



[that's the bug okay so this is what the](https://youtu.be/R1jehN-p2QA?t=01h06m18s)



[binding should have been but I think](https://youtu.be/R1jehN-p2QA?t=01h06m21s)



[this binding is wrong](https://youtu.be/R1jehN-p2QA?t=01h06m24s)



[so I think what we're going to do is](https://youtu.be/R1jehN-p2QA?t=01h06m30s)



[change this up a little bit because the](https://youtu.be/R1jehN-p2QA?t=01h06m32s)



[other thing I would like to do is turn](https://youtu.be/R1jehN-p2QA?t=01h06m34s)



[off this opacity and put it as part of](https://youtu.be/R1jehN-p2QA?t=01h06m38s)



[the put it as part of the brush color](https://youtu.be/R1jehN-p2QA?t=01h06m43s)



[you believe that's what we wanted to do](https://youtu.be/R1jehN-p2QA?t=01h06m53s)



[because if we make it as if we put it as](https://youtu.be/R1jehN-p2QA?t=01h06m55s)



[part of the brush color then that'll](https://youtu.be/R1jehN-p2QA?t=01h06m57s)



[allow people coming in to set this color](https://youtu.be/R1jehN-p2QA?t=01h06m58s)



[with anything they want rather than](https://youtu.be/R1jehN-p2QA?t=01h07m01s)



[being forced to take this color](https://youtu.be/R1jehN-p2QA?t=01h07m05s)



[wholesale](https://youtu.be/R1jehN-p2QA?t=01h07m08s)



[does make for an interesting use case](https://youtu.be/R1jehN-p2QA?t=01h07m13s)



[we'll get to that in a minute get to](https://youtu.be/R1jehN-p2QA?t=01h07m20s)



[that in a minute](https://youtu.be/R1jehN-p2QA?t=01h07m23s)



[do-do-do-do-do-do toggles Wow](https://youtu.be/R1jehN-p2QA?t=01h07m30s)



[part of me wants to alphabetize this](https://youtu.be/R1jehN-p2QA?t=01h07m32s)



[list see now now we're talking now this](https://youtu.be/R1jehN-p2QA?t=01h07m34s)



[is working the way I expect see see](https://youtu.be/R1jehN-p2QA?t=01h07m37s)



[that's now pink it's pink on both on and](https://youtu.be/R1jehN-p2QA?t=01h07m40s)



[off which isn't quite right](https://youtu.be/R1jehN-p2QA?t=01h07m45s)



[I'm fairly confident that the that was](https://youtu.be/R1jehN-p2QA?t=01h07m56s)



[not the behavior before let's just](https://youtu.be/R1jehN-p2QA?t=01h08m01s)



[confirm that](https://youtu.be/R1jehN-p2QA?t=01h08m04s)



[but it is so previously the code was we](https://youtu.be/R1jehN-p2QA?t=01h08m08s)



[can just reset this fill property](https://youtu.be/R1jehN-p2QA?t=01h08m16s)



[yeah because before it was defaulting to](https://youtu.be/R1jehN-p2QA?t=01h08m21s)



[black and then switching to the primary](https://youtu.be/R1jehN-p2QA?t=01h08m23s)



[hue light only unchecked](https://youtu.be/R1jehN-p2QA?t=01h08m30s)



[yeah so it was](https://youtu.be/R1jehN-p2QA?t=01h08m42s)



[black by default and then it flipped](https://youtu.be/R1jehN-p2QA?t=01h08m45s)



[over to the other one when it was said](https://youtu.be/R1jehN-p2QA?t=01h08m48s)



[okay let's figure out how to fix this](https://youtu.be/R1jehN-p2QA?t=01h08m58s)



[okay so this guy here](https://youtu.be/R1jehN-p2QA?t=01h09m00s)



[so on non checked](https://youtu.be/R1jehN-p2QA?t=01h09m07s)



[I'm wondering if maybe this should be](https://youtu.be/R1jehN-p2QA?t=01h09m17s)



[changed](https://youtu.be/R1jehN-p2QA?t=01h09m19s)



[I'm wondering if this should be changed](https://youtu.be/R1jehN-p2QA?t=01h09m30s)



[to be](https://youtu.be/R1jehN-p2QA?t=01h09m31s)



[they include checked and unchecked or](https://youtu.be/R1jehN-p2QA?t=01h09m41s)



[something](https://youtu.be/R1jehN-p2QA?t=01h09m46s)



[on content wondering if on might be the](https://youtu.be/R1jehN-p2QA?t=01h09m50s)



[better term track on background track](https://youtu.be/R1jehN-p2QA?t=01h09m54s)



[off background](https://youtu.be/R1jehN-p2QA?t=01h10m00s)



[how to do this correctly](https://youtu.be/R1jehN-p2QA?t=01h10m10s)



[if we have two separate brushes then it](https://youtu.be/R1jehN-p2QA?t=01h10m26s)



[makes our life easy because we can just](https://youtu.be/R1jehN-p2QA?t=01h10m28s)



[toggle between them](https://youtu.be/R1jehN-p2QA?t=01h10m29s)



[let's do it let's do it I I think rather](https://youtu.be/R1jehN-p2QA?t=01h10m36s)



[than fighting with this it's probably](https://youtu.be/R1jehN-p2QA?t=01h10m41s)



[switch track on background property](https://youtu.be/R1jehN-p2QA?t=01h10m44s)



[track on get switch tracks](https://youtu.be/R1jehN-p2QA?t=01h10m48s)



[on switch track on](https://youtu.be/R1jehN-p2QA?t=01h10m56s)



[format please Oh yuck](https://youtu.be/R1jehN-p2QA?t=01h11m08s)



[please don't do that hey hey know what I](https://youtu.be/R1jehN-p2QA?t=01h11m12s)



[told you to do know what I told you to](https://youtu.be/R1jehN-p2QA?t=01h11m15s)



[do](https://youtu.be/R1jehN-p2QA?t=01h11m17s)



[[Music]](https://youtu.be/R1jehN-p2QA?t=01h11m20s)



[I turned my whitespace back on I turned](https://youtu.be/R1jehN-p2QA?t=01h11m26s)



[it off while I was teaching and I really](https://youtu.be/R1jehN-p2QA?t=01h11m29s)



[like having whitespace turned on come on](https://youtu.be/R1jehN-p2QA?t=01h11m31s)



[Visual Studio](https://youtu.be/R1jehN-p2QA?t=01h11m36s)



[fine I know it's under this menu over](https://youtu.be/R1jehN-p2QA?t=01h11m39s)



[here it's something like advanced via](https://youtu.be/R1jehN-p2QA?t=01h11m41s)



[whitespace Thank You](https://youtu.be/R1jehN-p2QA?t=01h11m45s)



[default values](https://youtu.be/R1jehN-p2QA?t=01h11m49s)



[[Music]](https://youtu.be/R1jehN-p2QA?t=01h11m51s)



[unset' it's probably the best fact I](https://youtu.be/R1jehN-p2QA?t=01h11m57s)



[don't know if I even need that overload](https://youtu.be/R1jehN-p2QA?t=01h12m02s)



[yeah I think that's probably his track](https://youtu.be/R1jehN-p2QA?t=01h12m14s)



[on cetera](https://youtu.be/R1jehN-p2QA?t=01h12m22s)



[check](https://youtu.be/R1jehN-p2QA?t=01h12m27s)



[of](https://youtu.be/R1jehN-p2QA?t=01h12m31s)



[let's track off background track off](https://youtu.be/R1jehN-p2QA?t=01h12m33s)



[background track](https://youtu.be/R1jehN-p2QA?t=01h12m38s)



[Oh](https://youtu.be/R1jehN-p2QA?t=01h12m45s)



[I think that's better I think that's](https://youtu.be/R1jehN-p2QA?t=01h12m50s)



[better so let's come up back here switch](https://youtu.be/R1jehN-p2QA?t=01h12m52s)



[track on so that is the correct default](https://youtu.be/R1jehN-p2QA?t=01h12m54s)



[there this one here](https://youtu.be/R1jehN-p2QA?t=01h12m59s)



[off](https://youtu.be/R1jehN-p2QA?t=01h13m07s)



[are you black](https://youtu.be/R1jehN-p2QA?t=01h13m10s)



[so now here's the question](https://youtu.be/R1jehN-p2QA?t=01h13m16s)



[do I leave the opacity as part of the](https://youtu.be/R1jehN-p2QA?t=01h13m20s)



[rectangle that's hard-coded right here](https://youtu.be/R1jehN-p2QA?t=01h13m22s)



[so if you were to go through and](https://youtu.be/R1jehN-p2QA?t=01h13m27s)



[override one of these brushes comes off](https://youtu.be/R1jehN-p2QA?t=01h13m28s)



[and this becomes on](https://youtu.be/R1jehN-p2QA?t=01h13m33s)



[right](https://youtu.be/R1jehN-p2QA?t=01h13m43s)



[if this goes through like this how do I](https://youtu.be/R1jehN-p2QA?t=01h13m54s)



[because I either need to apply it here](https://youtu.be/R1jehN-p2QA?t=01h14m06s)



[do we have I just look there might](https://youtu.be/R1jehN-p2QA?t=01h14m11s)



[already be a converter for this](https://youtu.be/R1jehN-p2QA?t=01h14m14s)



[ooh](https://youtu.be/R1jehN-p2QA?t=01h14m32s)



[[Music]](https://youtu.be/R1jehN-p2QA?t=01h14m45s)



[because this one we could we could look](https://youtu.be/R1jehN-p2QA?t=01h14m52s)



[up in in hard code right so we can](https://youtu.be/R1jehN-p2QA?t=01h14m54s)



[figure out what 26 percent opacity is](https://youtu.be/R1jehN-p2QA?t=01h14m57s)



[and hex and then go through and just set](https://youtu.be/R1jehN-p2QA?t=01h15m01s)



[this thing to the appropriate no 0x I](https://youtu.be/R1jehN-p2QA?t=01h15m04s)



[don't know](https://youtu.be/R1jehN-p2QA?t=01h15m09s)



[20 0 0 0 0 0 right we could we could](https://youtu.be/R1jehN-p2QA?t=01h15m11s)



[effectively get this to black with some](https://youtu.be/R1jehN-p2QA?t=01h15m16s)



[level of pasty on it but that doesn't](https://youtu.be/R1jehN-p2QA?t=01h15m19s)



[fix this one because these are themed](https://youtu.be/R1jehN-p2QA?t=01h15m26s)



[resources and if we want to apply an](https://youtu.be/R1jehN-p2QA?t=01h15m27s)



[opacity here we then end up having to do](https://youtu.be/R1jehN-p2QA?t=01h15m29s)



[some sort of binding or this is the](https://youtu.be/R1jehN-p2QA?t=01h15m32s)



[source all right and then](https://youtu.be/R1jehN-p2QA?t=01h15m35s)



[Converter you know somewhat pasty](https://youtu.be/R1jehN-p2QA?t=01h15m40s)



[converter converter parameter you know](https://youtu.be/R1jehN-p2QA?t=01h15m44s)



[0.26 all right we end up doing something](https://youtu.be/R1jehN-p2QA?t=01h15m49s)



[like that we could even do the same](https://youtu.be/R1jehN-p2QA?t=01h15m52s)



[thing with the black just to make sure](https://youtu.be/R1jehN-p2QA?t=01h15m55s)



[everything everything's kosher do we](https://youtu.be/R1jehN-p2QA?t=01h15m56s)



[want to do that](https://youtu.be/R1jehN-p2QA?t=01h16m01s)



[I think I do I think I do let's we're](https://youtu.be/R1jehN-p2QA?t=01h16m04s)



[already going crazy let's let's just](https://youtu.be/R1jehN-p2QA?t=01h16m07s)



[keep going here](https://youtu.be/R1jehN-p2QA?t=01h16m09s)



[let's see brush round converter no](https://youtu.be/R1jehN-p2QA?t=01h16m10s)



[that's not quite what we want](https://youtu.be/R1jehN-p2QA?t=01h16m19s)



[rustic great in white space Nazi house](https://youtu.be/R1jehN-p2QA?t=01h16m21s)



[go through and change all those tabs out](https://youtu.be/R1jehN-p2QA?t=01h16m25s)



[because I can](https://youtu.be/R1jehN-p2QA?t=01h16m27s)



[she's trying to make sure that we don't](https://youtu.be/R1jehN-p2QA?t=01h16m33s)



[already have something usable for this](https://youtu.be/R1jehN-p2QA?t=01h16m34s)



[looks like the answer's no so new item](https://youtu.be/R1jehN-p2QA?t=01h16m39s)



[and you see](https://youtu.be/R1jehN-p2QA?t=01h16m43s)



[hey city rush converter](https://youtu.be/R1jehN-p2QA?t=01h16m53s)



[for those of you who are watching I do](https://youtu.be/R1jehN-p2QA?t=01h17m04s)



[have resharper turned off and I'm I'm](https://youtu.be/R1jehN-p2QA?t=01h17m05s)



[struggling a little bit](https://youtu.be/R1jehN-p2QA?t=01h17m08s)



[I mean Intelli code is good but it](https://youtu.be/R1jehN-p2QA?t=01h17m09s)



[doesn't quite it doesn't quite catch](https://youtu.be/R1jehN-p2QA?t=01h17m13s)



[everything that resharper does and it's](https://youtu.be/R1jehN-p2QA?t=01h17m18s)



[really hard to justify not having it but](https://youtu.be/R1jehN-p2QA?t=01h17m20s)



[man the speed of my visual studio is so](https://youtu.be/R1jehN-p2QA?t=01h17m22s)



[much better okay so we're gonna make](https://youtu.be/R1jehN-p2QA?t=01h17m25s)



[this an internal class because I don't](https://youtu.be/R1jehN-p2QA?t=01h17m28s)



[feel like making this public API](https://youtu.be/R1jehN-p2QA?t=01h17m30s)



[something for everyone to consume if](https://youtu.be/R1jehN-p2QA?t=01h17m32s)



[people find that unfortunate and you](https://youtu.be/R1jehN-p2QA?t=01h17m35s)



[really want it let me know I'm happy to](https://youtu.be/R1jehN-p2QA?t=01h17m37s)



[consider pull requests but I'm gonna](https://youtu.be/R1jehN-p2QA?t=01h17m39s)



[kind of write this in a little more of a](https://youtu.be/R1jehN-p2QA?t=01h17m40s)



[quick fashion](https://youtu.be/R1jehN-p2QA?t=01h17m43s)



[where rather than doing a bunch of error](https://youtu.be/R1jehN-p2QA?t=01h17m44s)



[checking so let's see if value is](https://youtu.be/R1jehN-p2QA?t=01h17m46s)



[well actually if I do color first this](https://youtu.be/R1jehN-p2QA?t=01h17m56s)



[will be easier value as color](https://youtu.be/R1jehN-p2QA?t=01h17m59s)



[which I think I can do this can't I](https://youtu.be/R1jehN-p2QA?t=01h18m12s)



[switch on value yeah I think we can do](https://youtu.be/R1jehN-p2QA?t=01h18m15s)



[this case value color](https://youtu.be/R1jehN-p2QA?t=01h18m19s)



[see](https://youtu.be/R1jehN-p2QA?t=01h18m26s)



[that's the right syntax isn't it](https://youtu.be/R1jehN-p2QA?t=01h18m29s)



[just drop it yeah that's what it is in](https://youtu.be/R1jehN-p2QA?t=01h18m33s)



[case solid color brush brush](https://youtu.be/R1jehN-p2QA?t=01h18m37s)



[well](https://youtu.be/R1jehN-p2QA?t=01h18m47s)



[let's see here](https://youtu.be/R1jehN-p2QA?t=01h18m52s)



[and it'll just break early the default](https://youtu.be/R1jehN-p2QA?t=01h19m01s)



[case will be returned binding do nothing](https://youtu.be/R1jehN-p2QA?t=01h19m04s)



[right so early exit we'll just bail out](https://youtu.be/R1jehN-p2QA?t=01h19m11s)



[so color get see in this case color gets](https://youtu.be/R1jehN-p2QA?t=01h19m15s)



[brush color and then a city gets hurt](https://youtu.be/R1jehN-p2QA?t=01h19m22s)



[change type](https://youtu.be/R1jehN-p2QA?t=01h19m34s)



[come on](https://youtu.be/R1jehN-p2QA?t=01h19m40s)



[oh right this is because I'm in a](https://youtu.be/R1jehN-p2QA?t=01h19m47s)



[convert method it's gonna be very](https://youtu.be/R1jehN-p2QA?t=01h19m50s)



[unhappy with me for that](https://youtu.be/R1jehN-p2QA?t=01h19m52s)



[okay so parameter type of double will be](https://youtu.be/R1jehN-p2QA?t=01h19m53s)



[intelligent culture info variant culture](https://youtu.be/R1jehN-p2QA?t=01h20m02s)



[it doesn't matter what language we're in](https://youtu.be/R1jehN-p2QA?t=01h20m10s)



[we're gonna expect a decimal place again](https://youtu.be/R1jehN-p2QA?t=01h20m13s)



[this should probably have a little bit](https://youtu.be/R1jehN-p2QA?t=01h20m26s)



[more air checking on it but given that](https://youtu.be/R1jehN-p2QA?t=01h20m27s)



[it's only gonna be used in this one](https://youtu.be/R1jehN-p2QA?t=01h20m29s)



[place and its internal a little less](https://youtu.be/R1jehN-p2QA?t=01h20m30s)



[concerned about it so let's see we need](https://youtu.be/R1jehN-p2QA?t=01h20m32s)



[to convert a percentage into hex so by](https://youtu.be/R1jehN-p2QA?t=01h20m36s)



[value gets to 55 times a city](https://youtu.be/R1jehN-p2QA?t=01h20m44s)



[Oh](https://youtu.be/R1jehN-p2QA?t=01h20m56s)



[alpha and then we want you to trim you](https://youtu.be/R1jehN-p2QA?t=01h21m00s)



[down to a bite that's going to end up](https://youtu.be/R1jehN-p2QA?t=01h21m04s)



[doing integer times double results into](https://youtu.be/R1jehN-p2QA?t=01h21m08s)



[double we know we're going to keep this](https://youtu.be/R1jehN-p2QA?t=01h21m12s)



[down as a percentage again this should](https://youtu.be/R1jehN-p2QA?t=01h21m14s)



[probably have error checking to make](https://youtu.be/R1jehN-p2QA?t=01h21m18s)



[sure it's between 0 and 1 and not bigger](https://youtu.be/R1jehN-p2QA?t=01h21m19s)



[or smaller etc etc bite alpha and then](https://youtu.be/R1jehN-p2QA?t=01h21m21s)



[we're going to return you solid color](https://youtu.be/R1jehN-p2QA?t=01h21m27s)



[brush and we're going to do color from a](https://youtu.be/R1jehN-p2QA?t=01h21m35s)



[RGB where alpha is now set there let's](https://youtu.be/R1jehN-p2QA?t=01h21m42s)



[see](https://youtu.be/R1jehN-p2QA?t=01h21m48s)



[color dot okay](https://youtu.be/R1jehN-p2QA?t=01h21m49s)



[so it's going to take in a percentage](https://youtu.be/R1jehN-p2QA?t=01h21m59s)



[for our opacity convert that to the](https://youtu.be/R1jehN-p2QA?t=01h22m02s)



[appropriate byte value we'll get our](https://youtu.be/R1jehN-p2QA?t=01h22m05s)



[color from the a RGB code shove that](https://youtu.be/R1jehN-p2QA?t=01h22m07s)



[into a new brush and away we go](https://youtu.be/R1jehN-p2QA?t=01h22m11s)



[great awesome we are cooking](https://youtu.be/R1jehN-p2QA?t=01h22m12s)



[let's see template resources well we've](https://youtu.be/R1jehN-p2QA?t=01h22m19s)



[already got resources here let's just](https://youtu.be/R1jehN-p2QA?t=01h22m21s)



[dump it in see](https://youtu.be/R1jehN-p2QA?t=01h22m23s)



[copypasta](https://youtu.be/R1jehN-p2QA?t=01h22m30s)



[copypasta](https://youtu.be/R1jehN-p2QA?t=01h22m33s)



[and](https://youtu.be/R1jehN-p2QA?t=01h22m36s)



[use converters great xkey it's that](https://youtu.be/R1jehN-p2QA?t=01h22m38s)



[I think what we do is we do oh we are](https://youtu.be/R1jehN-p2QA?t=01h22m47s)



[gonna need you at a higher level aren't](https://youtu.be/R1jehN-p2QA?t=01h22m51s)



[we how do you need you in the style](https://youtu.be/R1jehN-p2QA?t=01h22m52s)



[resources at least let's just keep you](https://youtu.be/R1jehN-p2QA?t=01h22m56s)



[well it's a little hesitant to pull it](https://youtu.be/R1jehN-p2QA?t=01h23m03s)



[outside because this is really designed](https://youtu.be/R1jehN-p2QA?t=01h23m06s)



[to just be used in here right now so](https://youtu.be/R1jehN-p2QA?t=01h23m08s)



[again if we if we end up needing it](https://youtu.be/R1jehN-p2QA?t=01h23m10s)



[elsewhere I'll probably clean that API](https://youtu.be/R1jehN-p2QA?t=01h23m12s)



[up to make it a little more resilient](https://youtu.be/R1jehN-p2QA?t=01h23m14s)



[see aesthetic resource use the brush](https://youtu.be/R1jehN-p2QA?t=01h23m16s)



[converter parameter 0 to 6 and](https://youtu.be/R1jehN-p2QA?t=01h23m20s)



[let's do the same thing here for the](https://youtu.be/R1jehN-p2QA?t=01h23m29s)



[black eye I think this is probably just](https://youtu.be/R1jehN-p2QA?t=01h23m31s)



[cleaner](https://youtu.be/R1jehN-p2QA?t=01h23m33s)



[let's see so source becomes rather than](https://youtu.be/R1jehN-p2QA?t=01h23m39s)



[dynamic resource ex](https://youtu.be/R1jehN-p2QA?t=01h23m43s)



[ecstatic](https://youtu.be/R1jehN-p2QA?t=01h23m49s)



[colors black](https://youtu.be/R1jehN-p2QA?t=01h23m51s)



[Oh](https://youtu.be/R1jehN-p2QA?t=01h23m57s)



[and too many closing braces](https://youtu.be/R1jehN-p2QA?t=01h23m59s)



[so that puts that there that puts that](https://youtu.be/R1jehN-p2QA?t=01h24m03s)



[there and now I no longer need this here](https://youtu.be/R1jehN-p2QA?t=01h24m05s)



[well that goes away now the last thing I](https://youtu.be/R1jehN-p2QA?t=01h24m11s)



[need to do](https://youtu.be/R1jehN-p2QA?t=01h24m16s)



[this is fine this is setting oh so we](https://youtu.be/R1jehN-p2QA?t=01h24m19s)



[could do well](https://youtu.be/R1jehN-p2QA?t=01h24m24s)



[grumble grumble grumble grumble grumble](https://youtu.be/R1jehN-p2QA?t=01h24m28s)



[grumble let's do that](https://youtu.be/R1jehN-p2QA?t=01h24m30s)



[because that that makes the math a](https://youtu.be/R1jehN-p2QA?t=01h24m40s)



[little bit easier no more doing here at](https://youtu.be/R1jehN-p2QA?t=01h24m42s)



[UB let's just set it on the brush itself](https://youtu.be/R1jehN-p2QA?t=01h24m48s)



[because I think that makes it a little](https://youtu.be/R1jehN-p2QA?t=01h24m51s)



[clearer what's happening](https://youtu.be/R1jehN-p2QA?t=01h24m53s)



[rather than doing math let the renderer](https://youtu.be/R1jehN-p2QA?t=01h25m00s)



[figure it out for us](https://youtu.be/R1jehN-p2QA?t=01h25m05s)



[so I'll still need the converter still](https://youtu.be/R1jehN-p2QA?t=01h25m08s)



[gonna create a new brush from it but](https://youtu.be/R1jehN-p2QA?t=01h25m11s)



[it's gonna be a brush with a Brita](https://youtu.be/R1jehN-p2QA?t=01h25m12s)



[pasady](https://youtu.be/R1jehN-p2QA?t=01h25m16s)



[that works there that works there this](https://youtu.be/R1jehN-p2QA?t=01h25m21s)



[guy's still hard coded to black but I](https://youtu.be/R1jehN-p2QA?t=01h25m26s)



[think this is okay because this is the](https://youtu.be/R1jehN-p2QA?t=01h25m27s)



[disabled color and I think this tracks](https://youtu.be/R1jehN-p2QA?t=01h25m30s)



[the one thing this doesn't do very](https://youtu.be/R1jehN-p2QA?t=01h25m32s)



[nicely and I might have to check it as I](https://youtu.be/R1jehN-p2QA?t=01h25m35s)



[suspect there's a problem between light](https://youtu.be/R1jehN-p2QA?t=01h25m38s)



[and dark themes just having a hard-coded](https://youtu.be/R1jehN-p2QA?t=01h25m39s)



[black with a particular value here that](https://youtu.be/R1jehN-p2QA?t=01h25m41s)



[usually doesn't end up working well but](https://youtu.be/R1jehN-p2QA?t=01h25m44s)



[that's a that's a bug for a different](https://youtu.be/R1jehN-p2QA?t=01h25m48s)



[name let's let's fire this guy up and](https://youtu.be/R1jehN-p2QA?t=01h25m50s)



[see how it works so I'd expect that on](https://youtu.be/R1jehN-p2QA?t=01h25m56s)



[all of the existing toggles I should now](https://youtu.be/R1jehN-p2QA?t=01h25m59s)



[work appropriately with the light color](https://youtu.be/R1jehN-p2QA?t=01h26m01s)



[brush and the black is what we should](https://youtu.be/R1jehN-p2QA?t=01h26m04s)



[see and then](https://youtu.be/R1jehN-p2QA?t=01h26m07s)



[now that this is working appropriately](https://youtu.be/R1jehN-p2QA?t=01h26m12s)



[and this is working appropriately syntax](https://youtu.be/R1jehN-p2QA?t=01h26m14s)



[error what did I do wrong](https://youtu.be/R1jehN-p2QA?t=01h26m19s)



[too many closing friends got it thank](https://youtu.be/R1jehN-p2QA?t=01h26m23s)



[you](https://youtu.be/R1jehN-p2QA?t=01h26m25s)



[dragon](https://youtu.be/R1jehN-p2QA?t=01h26m26s)



[part of me wishes that was real mountain](https://youtu.be/R1jehN-p2QA?t=01h26m37s)



[dew right now rather than just the water](https://youtu.be/R1jehN-p2QA?t=01h26m39s)



[Oh Mountain Dew I've misty](https://youtu.be/R1jehN-p2QA?t=01h26m42s)



[because if this gets in this will be a](https://youtu.be/R1jehN-p2QA?t=01h26m52s)



[nice nice little perk and I realize I've](https://youtu.be/R1jehN-p2QA?t=01h26m54s)



[now delayed on a the three oh release](https://youtu.be/R1jehN-p2QA?t=01h26m57s)



[for quite a while and I apologize to](https://youtu.be/R1jehN-p2QA?t=01h27m00s)



[everybody who's who's waiting on it](https://youtu.be/R1jehN-p2QA?t=01h27m02s)



[switched on the background of course it](https://youtu.be/R1jehN-p2QA?t=01h27m09s)



[doesn't exist](https://youtu.be/R1jehN-p2QA?t=01h27m11s)



[Oh background on background and actually](https://youtu.be/R1jehN-p2QA?t=01h27m12s)



[let's go one step further](https://youtu.be/R1jehN-p2QA?t=01h27m19s)



[let's make this a little more obvious so](https://youtu.be/R1jehN-p2QA?t=01h27m26s)



[red](https://youtu.be/R1jehN-p2QA?t=01h27m28s)



[Green](https://youtu.be/R1jehN-p2QA?t=01h27m31s)



[so I'll actually should do those in](https://youtu.be/R1jehN-p2QA?t=01h27m33s)



[Reverse Green should be on red should be](https://youtu.be/R1jehN-p2QA?t=01h27m35s)



[off just change this real quick](https://youtu.be/R1jehN-p2QA?t=01h27m39s)



[that'll make a little more sense I don't](https://youtu.be/R1jehN-p2QA?t=01h27m46s)



[care that it won't look right with all](https://youtu.be/R1jehN-p2QA?t=01h27m50s)



[the color themes the important part is](https://youtu.be/R1jehN-p2QA?t=01h27m51s)



[that this shows off how to do custom](https://youtu.be/R1jehN-p2QA?t=01h27m53s)



[track colors on the toggle switches](https://youtu.be/R1jehN-p2QA?t=01h27m55s)



[that's what matters and if people want](https://youtu.be/R1jehN-p2QA?t=01h27m57s)



[to go through and put the opacity in 26](https://youtu.be/R1jehN-p2QA?t=01h28m00s)



[percent that's the right answer at least](https://youtu.be/R1jehN-p2QA?t=01h28m03s)



[if you want to match the other ones](https://youtu.be/R1jehN-p2QA?t=01h28m05s)



[you're are free to adjust and change as](https://youtu.be/R1jehN-p2QA?t=01h28m06s)



[your heart desires but the the template](https://youtu.be/R1jehN-p2QA?t=01h28m09s)



[will no longer be prescribing it for you](https://youtu.be/R1jehN-p2QA?t=01h28m13s)



[you are now in control if you want to](https://youtu.be/R1jehN-p2QA?t=01h28m16s)



[set the brush's binding if dynamic](https://youtu.be/R1jehN-p2QA?t=01h28m18s)



[resource can only be set on the depend](https://youtu.be/R1jehN-p2QA?t=01h28m21s)



[co oh and there's the problem](https://youtu.be/R1jehN-p2QA?t=01h28m23s)



[right because I cannot set that like](https://youtu.be/R1jehN-p2QA?t=01h28m31s)



[that I did edit edit edit edit edit edit](https://youtu.be/R1jehN-p2QA?t=01h28m35s)



[at that](https://youtu.be/R1jehN-p2QA?t=01h28m42s)



[how to do this because I cannot actually](https://youtu.be/R1jehN-p2QA?t=01h28m47s)



[do a brush that way](https://youtu.be/R1jehN-p2QA?t=01h28m51s)



[I could abuse the tag property but I](https://youtu.be/R1jehN-p2QA?t=01h29m09s)



[don't really want to do it at the root](https://youtu.be/R1jehN-p2QA?t=01h29m11s)



[level control](https://youtu.be/R1jehN-p2QA?t=01h29m13s)



[I can move the converter down a level](https://youtu.be/R1jehN-p2QA?t=01h29m20s)



[but at that point it just applies at](https://youtu.be/R1jehN-p2QA?t=01h29m23s)



[that point it then just directly applies](https://youtu.be/R1jehN-p2QA?t=01h29m30s)



[to the rectangle I know might as well](https://youtu.be/R1jehN-p2QA?t=01h29m32s)



[just set it once and be done](https://youtu.be/R1jehN-p2QA?t=01h29m34s)



[what is the correct solution here](https://youtu.be/R1jehN-p2QA?t=01h29m44s)



[probably probably overthinking this](https://youtu.be/R1jehN-p2QA?t=01h29m49s)



[probably overthinking this let's let's](https://youtu.be/R1jehN-p2QA?t=01h29m56s)



[just do this so ignore everything I just](https://youtu.be/R1jehN-p2QA?t=01h29m58s)



[said about the control not prescribing](https://youtu.be/R1jehN-p2QA?t=01h30m02s)



[it out for you](https://youtu.be/R1jehN-p2QA?t=01h30m04s)



[we're gonna we're going to put it back](https://youtu.be/R1jehN-p2QA?t=01h30m09s)



[we're gonna put it back for now](https://youtu.be/R1jehN-p2QA?t=01h30m14s)



[[Music]](https://youtu.be/R1jehN-p2QA?t=01h30m17s)



[and actually I'm gonna put the opacity](https://youtu.be/R1jehN-p2QA?t=01h30m18s)



[right next to the brush to make it](https://youtu.be/R1jehN-p2QA?t=01h30m20s)



[really obvious six percent because there](https://youtu.be/R1jehN-p2QA?t=01h30m22s)



[is some other ones that I'm noticing up](https://youtu.be/R1jehN-p2QA?t=01h30m29s)



[here that are being toggled for the](https://youtu.be/R1jehN-p2QA?t=01h30m31s)



[ripple that are using them so that's](https://youtu.be/R1jehN-p2QA?t=01h30m35s)



[probably okay](https://youtu.be/R1jehN-p2QA?t=01h30m38s)



[question mark maybe okay](https://youtu.be/R1jehN-p2QA?t=01h30m42s)



[I think it's acceptable again if other](https://youtu.be/R1jehN-p2QA?t=01h30m44s)



[people have different opinions about](https://youtu.be/R1jehN-p2QA?t=01h30m48s)



[what about being able to control that](https://youtu.be/R1jehN-p2QA?t=01h30m49s)



[let me know I guess I wouldn't](https://youtu.be/R1jehN-p2QA?t=01h30m54s)



[necessarily be opposed to pulling this](https://youtu.be/R1jehN-p2QA?t=01h30m57s)



[out as its own attached property but I](https://youtu.be/R1jehN-p2QA?t=01h30m59s)



[think ultimately what people are looking](https://youtu.be/R1jehN-p2QA?t=01h31m03s)



[for is just being able to set that color](https://youtu.be/R1jehN-p2QA?t=01h31m05s)



[I'm not opposed to somebody revisiting](https://youtu.be/R1jehN-p2QA?t=01h31m12s)



[this and and cleaning up a little bit](https://youtu.be/R1jehN-p2QA?t=01h31m14s)



[better because it wouldn't be bad to](https://youtu.be/R1jehN-p2QA?t=01h31m16s)



[have this brush have the appropriate Oh](https://youtu.be/R1jehN-p2QA?t=01h31m19s)



[pasty applied to it how do you do that](https://youtu.be/R1jehN-p2QA?t=01h31m23s)



[when you've got a dynamic brush that you](https://youtu.be/R1jehN-p2QA?t=01h31m26s)



[want is the source but you want to](https://youtu.be/R1jehN-p2QA?t=01h31m29s)



[manipulate it slightly I mean normally](https://youtu.be/R1jehN-p2QA?t=01h31m30s)



[what I would do is I would apply the](https://youtu.be/R1jehN-p2QA?t=01h31m35s)



[dynamic resource onto like the tag](https://youtu.be/R1jehN-p2QA?t=01h31m38s)



[property and then I do a binding from](https://youtu.be/R1jehN-p2QA?t=01h31m39s)



[the tag property on to the fill property](https://youtu.be/R1jehN-p2QA?t=01h31m42s)



[with the converter specified in the](https://youtu.be/R1jehN-p2QA?t=01h31m45s)



[middle right that way the dynamic](https://youtu.be/R1jehN-p2QA?t=01h31m46s)



[resource updates one property and then](https://youtu.be/R1jehN-p2QA?t=01h31m49s)



[the converter runs as the go-between](https://youtu.be/R1jehN-p2QA?t=01h31m51s)



[between property a and the actual one](https://youtu.be/R1jehN-p2QA?t=01h31m53s)



[that I want the problem is if I set the](https://youtu.be/R1jehN-p2QA?t=01h31m56s)



[tag property here that's very unusual](https://youtu.be/R1jehN-p2QA?t=01h31m58s)



[behavior a better thing I think would be](https://youtu.be/R1jehN-p2QA?t=01h32m01s)



[to have an internal attached property](https://youtu.be/R1jehN-p2QA?t=01h32m05s)



[that that thing used but you still have](https://youtu.be/R1jehN-p2QA?t=01h32m08s)



[the problem of if the resource points to](https://youtu.be/R1jehN-p2QA?t=01h32m14s)



[the attached property that means it's](https://youtu.be/R1jehN-p2QA?t=01h32m18s)



[going through a converter there and it](https://youtu.be/R1jehN-p2QA?t=01h32m21s)



[doesn't allow somebody to override it is](https://youtu.be/R1jehN-p2QA?t=01h32m26s)



[yeah it's just kind of weird I the](https://youtu.be/R1jehN-p2QA?t=01h32m28s)



[letting somebody override it is making](https://youtu.be/R1jehN-p2QA?t=01h32m31s)



[it challenging okay so red green red](https://youtu.be/R1jehN-p2QA?t=01h32m33s)



[green these things switch that's the](https://youtu.be/R1jehN-p2QA?t=01h32m38s)



[purple purple gray purple grey excellent](https://youtu.be/R1jehN-p2QA?t=01h32m41s)



[that's a little better okay I like it](https://youtu.be/R1jehN-p2QA?t=01h32m46s)



[let's ship it so step one let's go into](https://youtu.be/R1jehN-p2QA?t=01h32m51s)



[lead or other don't need you don't need](https://youtu.be/R1jehN-p2QA?t=01h32m55s)



[you what's called the pasty brush](https://youtu.be/R1jehN-p2QA?t=01h32m59s)



[converter delete okay okay everybody's](https://youtu.be/R1jehN-p2QA?t=01h33m02s)



[favorite get tool get cracking or at](https://youtu.be/R1jehN-p2QA?t=01h33m07s)



[least my favorite get tool for those you](https://youtu.be/R1jehN-p2QA?t=01h33m10s)



[missed it last week I did a long stream](https://youtu.be/R1jehN-p2QA?t=01h33m13s)



[on the basics of get and using get](https://youtu.be/R1jehN-p2QA?t=01h33m16s)



[crackin for Oktoberfest so if anybody's](https://youtu.be/R1jehN-p2QA?t=01h33m19s)



[feeling like they want to up their game](https://youtu.be/R1jehN-p2QA?t=01h33m23s)



[a little bit with it go check it out](https://youtu.be/R1jehN-p2QA?t=01h33m29s)



[okay so there's that oh we can we can](https://youtu.be/R1jehN-p2QA?t=01h33m32s)



[eliminate these lines](https://youtu.be/R1jehN-p2QA?t=01h33m38s)



[come on discard discard](https://youtu.be/R1jehN-p2QA?t=01h33m43s)



[discard okay so there's those three](https://youtu.be/R1jehN-p2QA?t=01h33m49s)



[lines that's great go down here and take](https://youtu.be/R1jehN-p2QA?t=01h33m52s)



[a look](https://youtu.be/R1jehN-p2QA?t=01h33m57s)



[so this fixes the relative source on the](https://youtu.be/R1jehN-p2QA?t=01h33m58s)



[template binding added a second brush](https://youtu.be/R1jehN-p2QA?t=01h34m00s)



[with the opacity up flattened everything](https://youtu.be/R1jehN-p2QA?t=01h34m02s)



[out great](https://youtu.be/R1jehN-p2QA?t=01h34m06s)



[okay what's the change down here](https://youtu.be/R1jehN-p2QA?t=01h34m09s)



[assume just the binding property name](https://youtu.be/R1jehN-p2QA?t=01h34m13s)



[yep okay toggle button assist white](https://youtu.be/R1jehN-p2QA?t=01h34m18s)



[space clean up white space clean up](https://youtu.be/R1jehN-p2QA?t=01h34m23s)



[and then on](https://youtu.be/R1jehN-p2QA?t=01h34m30s)



[on and off great trying to decide if I](https://youtu.be/R1jehN-p2QA?t=01h34m37s)



[need this I don't think at a minimum I](https://youtu.be/R1jehN-p2QA?t=01h34m42s)



[don't want this in this commit so](https://youtu.be/R1jehN-p2QA?t=01h34m44s)



[let's see dating to have do brushes for](https://youtu.be/R1jehN-p2QA?t=01h34m51s)



[the background updated demo to reflect](https://youtu.be/R1jehN-p2QA?t=01h35m02s)



[change fixed](https://youtu.be/R1jehN-p2QA?t=01h35m09s)



[binding err on the off](https://youtu.be/R1jehN-p2QA?t=01h35m13s)



[great twit changes](https://youtu.be/R1jehN-p2QA?t=01h35m22s)



[and pushy pushy](https://youtu.be/R1jehN-p2QA?t=01h35m26s)



[force bush great one of the perks of](https://youtu.be/R1jehN-p2QA?t=01h35m32s)



[being the owner of the repo means I can](https://youtu.be/R1jehN-p2QA?t=01h35m40s)



[force push into other repositories when](https://youtu.be/R1jehN-p2QA?t=01h35m42s)



[people open pull requests which is great](https://youtu.be/R1jehN-p2QA?t=01h35m45s)



[wonderful wonderful wonderful ok](https://youtu.be/R1jehN-p2QA?t=01h35m48s)



[- dude - doodoo okay sorry just checking](https://youtu.be/R1jehN-p2QA?t=01h35m58s)



[some messages okay let's take a quick](https://youtu.be/R1jehN-p2QA?t=01h36m03s)



[look man I'm looking at the time and](https://youtu.be/R1jehN-p2QA?t=01h36m07s)



[thinking that the my app stuff might](https://youtu.be/R1jehN-p2QA?t=01h36m09s)



[have to wait and tell later that is a](https://youtu.be/R1jehN-p2QA?t=01h36m11s)



[bummer because I was really hoping to](https://youtu.be/R1jehN-p2QA?t=01h36m14s)



[get to it okay the thing that I do want](https://youtu.be/R1jehN-p2QA?t=01h36m15s)



[to look at because this other pull](https://youtu.be/R1jehN-p2QA?t=01h36m18s)



[request let me just make sure this this](https://youtu.be/R1jehN-p2QA?t=01h36m20s)



[guy should have cued up](https://youtu.be/R1jehN-p2QA?t=01h36m23s)



[I just want to make sure the CI system](https://youtu.be/R1jehN-p2QA?t=01h36m24s)



[passes and then and then this should be](https://youtu.be/R1jehN-p2QA?t=01h36m27s)



[good to go so but I'm going to wait](https://youtu.be/R1jehN-p2QA?t=01h36m34s)



[until CI system runs just to make sure I](https://youtu.be/R1jehN-p2QA?t=01h36m38s)



[didn't botch anything always good to](https://youtu.be/R1jehN-p2QA?t=01h36m41s)



[double check yourself okay](https://youtu.be/R1jehN-p2QA?t=01h36m44s)



[but I would like to go back and revisit](https://youtu.be/R1jehN-p2QA?t=01h36m46s)



[the issue here with the app config okay](https://youtu.be/R1jehN-p2QA?t=01h36m49s)



[so we added in these binding redirects](https://youtu.be/R1jehN-p2QA?t=01h36m57s)



[right let's turn this off I want to](https://youtu.be/R1jehN-p2QA?t=01h36m59s)



[rebuild and then I would like to verify](https://youtu.be/R1jehN-p2QA?t=01h37m06s)



[that I still hit the bug because I did](https://youtu.be/R1jehN-p2QA?t=01h37m09s)



[kick out an update to the show me the](https://youtu.be/R1jehN-p2QA?t=01h37m11s)



[sam'l library with all of the latest](https://youtu.be/R1jehN-p2QA?t=01h37m13s)



[stuff and I believe if we just update to](https://youtu.be/R1jehN-p2QA?t=01h37m15s)



[that nougat package everything should](https://youtu.be/R1jehN-p2QA?t=01h37m17s)



[work but that is a theory that that](https://youtu.be/R1jehN-p2QA?t=01h37m19s)



[needs to be proven](https://youtu.be/R1jehN-p2QA?t=01h37m24s)



[[Music]](https://youtu.be/R1jehN-p2QA?t=01h37m26s)



[let's go look up that](https://youtu.be/R1jehN-p2QA?t=01h37m32s)



[see here](https://youtu.be/R1jehN-p2QA?t=01h37m35s)



[you get dot-org](https://youtu.be/R1jehN-p2QA?t=01h37m37s)



[did you ever update](https://youtu.be/R1jehN-p2QA?t=01h37m47s)



[you didn't update him I have to go check](https://youtu.be/R1jehN-p2QA?t=01h37m50s)



[my pipeline to make sure you're still](https://youtu.be/R1jehN-p2QA?t=01h37m51s)



[running okay oh look at that we got](https://youtu.be/R1jehN-p2QA?t=01h37m52s)



[pretty hyperlinks we got pretty](https://youtu.be/R1jehN-p2QA?t=01h37m59s)



[hyperlinks yes pipelines are awesome](https://youtu.be/R1jehN-p2QA?t=01h38m01s)



[yeah if we can get these pointed at line](https://youtu.be/R1jehN-p2QA?t=01h38m12s)



[numbers that'll be slick](https://youtu.be/R1jehN-p2QA?t=01h38m15s)



[that'll be slick boom thank you very](https://youtu.be/R1jehN-p2QA?t=01h38m17s)



[much to whoever did that that is that is](https://youtu.be/R1jehN-p2QA?t=01h38m23s)



[a wonderful addition okay show me the](https://youtu.be/R1jehN-p2QA?t=01h38m26s)



[know specifically the Avalon edit but](https://youtu.be/R1jehN-p2QA?t=01h38m31s)



[all of these things my pipeline revs](https://youtu.be/R1jehN-p2QA?t=01h38m35s)



[them all together so this was published](https://youtu.be/R1jehN-p2QA?t=01h38m37s)



[nine days ago and I thought I had](https://youtu.be/R1jehN-p2QA?t=01h38m40s)



[updated it inside the library but](https://youtu.be/R1jehN-p2QA?t=01h38m42s)



[clearly I haven't so 110c i-71 I just](https://youtu.be/R1jehN-p2QA?t=01h38m44s)



[want to verify that this thing fails](https://youtu.be/R1jehN-p2QA?t=01h38m50s)



[first and then what we're gonna do is](https://youtu.be/R1jehN-p2QA?t=01h38m52s)



[we're gonna Rev the packet one because](https://youtu.be/R1jehN-p2QA?t=01h38m54s)



[these are all pointed at 70 which is one](https://youtu.be/R1jehN-p2QA?t=01h38m57s)



[build back](https://youtu.be/R1jehN-p2QA?t=01h38m59s)



[we will verify this still fails because](https://youtu.be/R1jehN-p2QA?t=01h39m02s)



[it's important to make sure that you're](https://youtu.be/R1jehN-p2QA?t=01h39m07s)



[in a failing state first and then we](https://youtu.be/R1jehN-p2QA?t=01h39m09s)



[will go through and Revit do the install](https://youtu.be/R1jehN-p2QA?t=01h39m12s)



[and verify that it fixes it because I](https://youtu.be/R1jehN-p2QA?t=01h39m16s)



[hate having to have those binding](https://youtu.be/R1jehN-p2QA?t=01h39m21s)



[redirects in there binding redirects are](https://youtu.be/R1jehN-p2QA?t=01h39m22s)



[almost always a hack boom okay perfect](https://youtu.be/R1jehN-p2QA?t=01h39m25s)



[so](https://youtu.be/R1jehN-p2QA?t=01h39m31s)



[well your case has occurred do this do](https://youtu.be/R1jehN-p2QA?t=01h39m34s)



[this do this save I believe we do I can](https://youtu.be/R1jehN-p2QA?t=01h39m39s)



[restore](https://youtu.be/R1jehN-p2QA?t=01h39m47s)



[it's install first](https://youtu.be/R1jehN-p2QA?t=01h39m50s)



[do](https://youtu.be/R1jehN-p2QA?t=01h39m53s)



[there we go so grab that okay so we're](https://youtu.be/R1jehN-p2QA?t=01h39m57s)



[gonna just close Visual Studio down and](https://youtu.be/R1jehN-p2QA?t=01h40m01s)



[relaunch only because msbuild keeps the](https://youtu.be/R1jehN-p2QA?t=01h40m05s)



[processes running as a performance](https://youtu.be/R1jehN-p2QA?t=01h40m09s)



[benefit the problem being is my](https://youtu.be/R1jehN-p2QA?t=01h40m11s)



[experience has been that with packet if](https://youtu.be/R1jehN-p2QA?t=01h40m14s)



[you go through and make changes to a new](https://youtu.be/R1jehN-p2QA?t=01h40m18s)



[get package that is used as the MS part](https://youtu.be/R1jehN-p2QA?t=01h40m24s)



[of the MS build pipeline it doesn't let](https://youtu.be/R1jehN-p2QA?t=01h40m26s)



[go with the file handles and so you can](https://youtu.be/R1jehN-p2QA?t=01h40m29s)



[end up running older versions of your ms](https://youtu.be/R1jehN-p2QA?t=01h40m31s)



[built tasks so in general whenever I](https://youtu.be/R1jehN-p2QA?t=01h40m34s)



[update it I try to just relaunch Visual](https://youtu.be/R1jehN-p2QA?t=01h40m36s)



[Studio or you can kill all your miss](https://youtu.be/R1jehN-p2QA?t=01h40m41s)



[build processes it it doesn't really](https://youtu.be/R1jehN-p2QA?t=01h40m42s)



[matter and it's not necessarily really a](https://youtu.be/R1jehN-p2QA?t=01h40m44s)



[bug](https://youtu.be/R1jehN-p2QA?t=01h40m48s)



[it's just sort of I guess an artifact of](https://youtu.be/R1jehN-p2QA?t=01h40m50s)



[the way the systems work it's](https://youtu.be/R1jehN-p2QA?t=01h40m52s)



[unfortunate and it's part of the reason](https://youtu.be/R1jehN-p2QA?t=01h40m55s)



[why Visual Studio does a a nougat](https://youtu.be/R1jehN-p2QA?t=01h40m57s)



[package restore before doing the build](https://youtu.be/R1jehN-p2QA?t=01h40m59s)



[to avoid those kind of race conditions](https://youtu.be/R1jehN-p2QA?t=01h41m01s)



[where a nougat package wants to add](https://youtu.be/R1jehN-p2QA?t=01h41m04s)



[itself to the MS build pipeline but the](https://youtu.be/R1jehN-p2QA?t=01h41m06s)



[MS build pipeline is what restored it so](https://youtu.be/R1jehN-p2QA?t=01h41m08s)



[it can't add this MS build and basically](https://youtu.be/R1jehN-p2QA?t=01h41m10s)



[does a full parse to figure out what](https://youtu.be/R1jehN-p2QA?t=01h41m13s)



[it's going to run and then runs it and](https://youtu.be/R1jehN-p2QA?t=01h41m15s)



[so if as part of running it goes to add](https://youtu.be/R1jehN-p2QA?t=01h41m16s)



[something well it's already built up its](https://youtu.be/R1jehN-p2QA?t=01h41m18s)



[plan of what it's going to do it's you](https://youtu.be/R1jehN-p2QA?t=01h41m20s)



[can't add to it at that point](https://youtu.be/R1jehN-p2QA?t=01h41m22s)



[okay so let's close these guys out close](https://youtu.be/R1jehN-p2QA?t=01h41m25s)



[close close and then we will if this](https://youtu.be/R1jehN-p2QA?t=01h41m28s)



[works we'll just check in these packet](https://youtu.be/R1jehN-p2QA?t=01h41m32s)



[changes so I just want to check my](https://youtu.be/R1jehN-p2QA?t=01h41m35s)



[dependencies and verify that this](https://youtu.be/R1jehN-p2QA?t=01h41m37s)



[actually does show packages little](https://youtu.be/R1jehN-p2QA?t=01h41m38s)



[bigger little bigger just want to see](https://youtu.be/R1jehN-p2QA?t=01h41m47s)



[that is not what I expected to see I](https://youtu.be/R1jehN-p2QA?t=01h41m49s)



[expect to see 71 there](https://youtu.be/R1jehN-p2QA?t=01h41m52s)



[so let's](https://youtu.be/R1jehN-p2QA?t=01h42m07s)



[rebuilt that should a package should](https://youtu.be/R1jehN-p2QA?t=01h42m09s)



[have updated all of that stuff and it](https://youtu.be/R1jehN-p2QA?t=01h42m12s)



[showed that it pulled in the information](https://youtu.be/R1jehN-p2QA?t=01h42m14s)



[so installing new get packages I'm](https://youtu.be/R1jehN-p2QA?t=01h42m16s)



[guessing Visual Studio must just be out](https://youtu.be/R1jehN-p2QA?t=01h42m22s)



[of its mind because I believe the issue](https://youtu.be/R1jehN-p2QA?t=01h42m24s)



[was that the Avalon edit version of show](https://youtu.be/R1jehN-p2QA?t=01h42m28s)



[me the zamel was incompatible with the](https://youtu.be/R1jehN-p2QA?t=01h42m31s)



[version of Avalon edit here believe that](https://youtu.be/R1jehN-p2QA?t=01h42m34s)



[was what was causing that issue we had a](https://youtu.be/R1jehN-p2QA?t=01h42m38s)



[dependency mismatch my new get versions](https://youtu.be/R1jehN-p2QA?t=01h42m42s)



[didn't stop the mismatch from occurring](https://youtu.be/R1jehN-p2QA?t=01h42m44s)



[and so then things went boom still](https://youtu.be/R1jehN-p2QA?t=01h42m47s)



[bothers me that these are still showing](https://youtu.be/R1jehN-p2QA?t=01h42m53s)



[70 not 71 especially after packet said](https://youtu.be/R1jehN-p2QA?t=01h42m55s)



[it updated them just just hypothetical](https://youtu.be/R1jehN-p2QA?t=01h43m00s)



[let's I just want to look I just want to](https://youtu.be/R1jehN-p2QA?t=01h43m04s)



[look here show me the sam'l Avalon](https://youtu.be/R1jehN-p2QA?t=01h43m07s)



[live](https://youtu.be/R1jehN-p2QA?t=01h43m14s)



[that's fine](https://youtu.be/R1jehN-p2QA?t=01h43m20s)



[version do you have here here's your new](https://youtu.be/R1jehN-p2QA?t=01h43m22s)



[is that the new you package here's the](https://youtu.be/R1jehN-p2QA?t=01h43m26s)



[new spec let's just look at the new spec](https://youtu.be/R1jehN-p2QA?t=01h43m28s)



[you claim to have downloaded and install](https://youtu.be/R1jehN-p2QA?t=01h43m32s)



[the version which version is it that](https://youtu.be/R1jehN-p2QA?t=01h43m35s)



[version right there ok then so then](https://youtu.be/R1jehN-p2QA?t=01h43m39s)



[where the heck are you getting your](https://youtu.be/R1jehN-p2QA?t=01h43m46s)



[references from properties tell me I](https://youtu.be/R1jehN-p2QA?t=01h43m48s)



[have an issue with my build](https://youtu.be/R1jehN-p2QA?t=01h43m56s)



[configuration](https://youtu.be/R1jehN-p2QA?t=01h43m57s)



[oh this is my new get package cash you](https://youtu.be/R1jehN-p2QA?t=01h44m02s)



[don't have](https://youtu.be/R1jehN-p2QA?t=01h44m06s)



[No](https://youtu.be/R1jehN-p2QA?t=01h44m09s)



[right there's no way you're set up with](https://youtu.be/R1jehN-p2QA?t=01h44m12s)



[an package config right](https://youtu.be/R1jehN-p2QA?t=01h44m16s)



[it's references](https://youtu.be/R1jehN-p2QA?t=01h44m21s)



[you don't have a packages config](https://youtu.be/R1jehN-p2QA?t=01h44m27s)



[let's look](https://youtu.be/R1jehN-p2QA?t=01h44m33s)



[I don't expect to see show me the sam'l](https://youtu.be/R1jehN-p2QA?t=01h44m37s)



[inside of this file](https://youtu.be/R1jehN-p2QA?t=01h44m40s)



[where's analemma spill bla bla bla](https://youtu.be/R1jehN-p2QA?t=01h44m56s)



[this is expected](https://youtu.be/R1jehN-p2QA?t=01h44m59s)



[I've got to believe this is a visual](https://youtu.be/R1jehN-p2QA?t=01h45m10s)



[studio UI bug well let's fire this up](https://youtu.be/R1jehN-p2QA?t=01h45m13s)



[and see what happens I have to believe](https://youtu.be/R1jehN-p2QA?t=01h45m17s)



[that this version that is showing me](https://youtu.be/R1jehN-p2QA?t=01h45m21s)



[here is a lie](https://youtu.be/R1jehN-p2QA?t=01h45m22s)



[because the fact that it shows that the](https://youtu.be/R1jehN-p2QA?t=01h45m27s)



[thing in the packages is set up](https://youtu.be/R1jehN-p2QA?t=01h45m29s)



[correctly](https://youtu.be/R1jehN-p2QA?t=01h45m32s)



[makes me really suspect of which version](https://youtu.be/R1jehN-p2QA?t=01h45m37s)



[is using okay so toggles](https://youtu.be/R1jehN-p2QA?t=01h45m39s)



[oh not looks](https://youtu.be/R1jehN-p2QA?t=01h45m49s)



[huh 601 78 okay something is something](https://youtu.be/R1jehN-p2QA?t=01h45m59s)



[is messed up and I'm not sure what](https://youtu.be/R1jehN-p2QA?t=01h46m04s)



[exactly it is](https://youtu.be/R1jehN-p2QA?t=01h46m08s)



[okay so let's let's look through this](https://youtu.be/R1jehN-p2QA?t=01h46m13s)



[again so this guy](https://youtu.be/R1jehN-p2QA?t=01h46m16s)



[I want to figure out where why are you](https://youtu.be/R1jehN-p2QA?t=01h46m20s)



[able to hold a reference from not](https://youtu.be/R1jehN-p2QA?t=01h46m25s)



[in fact this guy is able to pull a](https://youtu.be/R1jehN-p2QA?t=01h46m35s)



[reference from outside is a little](https://youtu.be/R1jehN-p2QA?t=01h46m36s)



[a little disconcerting because that](https://youtu.be/R1jehN-p2QA?t=01h46m44s)



[shouldn't be possible](https://youtu.be/R1jehN-p2QA?t=01h46m48s)



[so what hack it ends up doing is adding](https://youtu.be/R1jehN-p2QA?t=01h46m54s)



[in these extra targets files that it](https://youtu.be/R1jehN-p2QA?t=01h46m58s)



[generates which is how it's able to](https://youtu.be/R1jehN-p2QA?t=01h47m01s)



[inject as part of it the the pipeline](https://youtu.be/R1jehN-p2QA?t=01h47m04s)



[like for example the same as build one](https://youtu.be/R1jehN-p2QA?t=01h47m08s)



[is pointed in my packages directory it's](https://youtu.be/R1jehN-p2QA?t=01h47m09s)



[not looking anywhere else like that's](https://youtu.be/R1jehN-p2QA?t=01h47m15s)



[that's the one that's being loaded](https://youtu.be/R1jehN-p2QA?t=01h47m19s)



[this packet dot package](https://youtu.be/R1jehN-p2QA?t=01h47m25s)



[let's go look at this like what the heck](https://youtu.be/R1jehN-p2QA?t=01h47m29s)



[I have to believe Visual Studio is just](https://youtu.be/R1jehN-p2QA?t=01h47m34s)



[lying to be on the version that it's](https://youtu.be/R1jehN-p2QA?t=01h47m36s)



[that it's loading up hey there what's](https://youtu.be/R1jehN-p2QA?t=01h47m39s)



[new I've watched your kid Okubo channel](https://youtu.be/R1jehN-p2QA?t=01h47m44s)



[about your stream as your material](https://youtu.be/R1jehN-p2QA?t=01h47m47s)



[design keep up the good work I'm about](https://youtu.be/R1jehN-p2QA?t=01h47m49s)



[to to do design for your streaming cool](https://youtu.be/R1jehN-p2QA?t=01h47m51s)



[what type of designer you're working on](https://youtu.be/R1jehN-p2QA?t=01h48m05s)



[a WPF app or are you talking about like](https://youtu.be/R1jehN-p2QA?t=01h48m07s)



[actual I think I've seen you here before](https://youtu.be/R1jehN-p2QA?t=01h48m09s)



[any chance you're not a bot](https://youtu.be/R1jehN-p2QA?t=01h48m31s)



[let's see here](https://youtu.be/R1jehN-p2QA?t=01h48m39s)



[show me this is a whole bunch of stuff](https://youtu.be/R1jehN-p2QA?t=01h48m42s)



[and I don't recall what exactly where it](https://youtu.be/R1jehN-p2QA?t=01h48m48s)



[is so I'm not gonna spend a whole lot of](https://youtu.be/R1jehN-p2QA?t=01h48m52s)



[time here right next door](https://youtu.be/R1jehN-p2QA?t=01h48m54s)



[this actually it](https://youtu.be/R1jehN-p2QA?t=01h49m05s)



[like it files](https://youtu.be/R1jehN-p2QA?t=01h49m20s)



[I hit restore cashed](https://youtu.be/R1jehN-p2QA?t=01h49m23s)



[you](https://youtu.be/R1jehN-p2QA?t=01h49m30s)



[trying to remember where it is that it](https://youtu.be/R1jehN-p2QA?t=01h49m32s)



[generates it from](https://youtu.be/R1jehN-p2QA?t=01h49m34s)



[your store store - depends on or store](https://youtu.be/R1jehN-p2QA?t=01h49m42s)



[packages execute command do the packet e](https://youtu.be/R1jehN-p2QA?t=01h49m45s)



[things okay](https://youtu.be/R1jehN-p2QA?t=01h49m52s)



[there okay so](https://youtu.be/R1jehN-p2QA?t=01h50m19s)



[let's take a look I'm a little little](https://youtu.be/R1jehN-p2QA?t=01h50m29s)



[baffled at this as to why this isn't](https://youtu.be/R1jehN-p2QA?t=01h50m35s)



[getting updated](https://youtu.be/R1jehN-p2QA?t=01h50m39s)



[especially when packet claims that it is](https://youtu.be/R1jehN-p2QA?t=01h50m44s)



[doing the install](https://youtu.be/R1jehN-p2QA?t=01h50m48s)



[which makes me suspect that something is](https://youtu.be/R1jehN-p2QA?t=01h51m10s)



[amiss](https://youtu.be/R1jehN-p2QA?t=01h51m12s)



[no you are all set up appropriately](https://youtu.be/R1jehN-p2QA?t=01h51m17s)



[you are set up appropriately](https://youtu.be/R1jehN-p2QA?t=01h51m30s)



[you should look at why we have this](https://youtu.be/R1jehN-p2QA?t=01h51m47s)



[included I don't know what I don't know](https://youtu.be/R1jehN-p2QA?t=01h51m49s)



[what the dependency is that needs that](https://youtu.be/R1jehN-p2QA?t=01h51m51s)



[I am I'm baffled okay more Visual Studio](https://youtu.be/R1jehN-p2QA?t=01h52m01s)



[kick and restart because this is this is](https://youtu.be/R1jehN-p2QA?t=01h52m05s)



[really bothering me that it's not](https://youtu.be/R1jehN-p2QA?t=01h52m08s)



[updating](https://youtu.be/R1jehN-p2QA?t=01h52m09s)



[you know both on both target frameworks](https://youtu.be/R1jehN-p2QA?t=01h52m16s)



[something something is amiss I am going](https://youtu.be/R1jehN-p2QA?t=01h52m19s)



[to assume that this has to be a visual](https://youtu.be/R1jehN-p2QA?t=01h52m22s)



[studio visual studio / packet confusion](https://youtu.be/R1jehN-p2QA?t=01h52m24s)



[because I do not understand how it would](https://youtu.be/R1jehN-p2QA?t=01h52m36s)



[be picking it up from the nougat cache](https://youtu.be/R1jehN-p2QA?t=01h52m39s)



[I actually attempted to go blow away my](https://youtu.be/R1jehN-p2QA?t=01h52m49s)



[cash real quick if it still picks it up](https://youtu.be/R1jehN-p2QA?t=01h52m51s)



[from there I might go and do that](https://youtu.be/R1jehN-p2QA?t=01h52m54s)



[blowing away that cash is probably a](https://youtu.be/R1jehN-p2QA?t=01h52m56s)



[little abusive and will make my life](https://youtu.be/R1jehN-p2QA?t=01h53m00s)



[miserable tomorrow but help me now it](https://youtu.be/R1jehN-p2QA?t=01h53m02s)



[basically means all my Nuka packages are](https://youtu.be/R1jehN-p2QA?t=01h53m11s)



[going to get redownload it yet again](https://youtu.be/R1jehN-p2QA?t=01h53m14s)



[see it still is convinced that it needs](https://youtu.be/R1jehN-p2QA?t=01h53m22s)



[to pick up those packages](https://youtu.be/R1jehN-p2QA?t=01h53m24s)



[which tells me that either](https://youtu.be/R1jehN-p2QA?t=01h53m29s)



[and either](https://youtu.be/R1jehN-p2QA?t=01h53m37s)



[where do you think you're coming from](https://youtu.be/R1jehN-p2QA?t=01h53m40s)



[why and why are you okay with this](https://youtu.be/R1jehN-p2QA?t=01h53m42s)



[where are you getting this version from](https://youtu.be/R1jehN-p2QA?t=01h53m51s)



[you don't have a packages config to pull](https://youtu.be/R1jehN-p2QA?t=01h53m53s)



[from right](https://youtu.be/R1jehN-p2QA?t=01h53m56s)



[small files to make sure it didn't](https://youtu.be/R1jehN-p2QA?t=01h53m59s)



[generate something on me](https://youtu.be/R1jehN-p2QA?t=01h54m03s)



[you don't have a packages config](https://youtu.be/R1jehN-p2QA?t=01h54m05s)



[you're the new project type which means](https://youtu.be/R1jehN-p2QA?t=01h54m10s)



[you shouldn't have any package](https://youtu.be/R1jehN-p2QA?t=01h54m14s)



[references](https://youtu.be/R1jehN-p2QA?t=01h54m16s)



[you don't just correct](https://youtu.be/R1jehN-p2QA?t=01h54m18s)



[what is going on](https://youtu.be/R1jehN-p2QA?t=01h54m27s)



[Hecate restore targets](https://youtu.be/R1jehN-p2QA?t=01h54m34s)



[which means this guy looks too](https://youtu.be/R1jehN-p2QA?t=01h54m37s)



[here and looks to pull in here](https://youtu.be/R1jehN-p2QA?t=01h54m41s)



[this packet restore targets](https://youtu.be/R1jehN-p2QA?t=01h54m50s)



[this packet targets file pulls in what](https://youtu.be/R1jehN-p2QA?t=01h54m59s)



[and this build packet files packet](https://youtu.be/R1jehN-p2QA?t=01h55m03s)



[restore cashed packet lock file](https://youtu.be/R1jehN-p2QA?t=01h55m06s)



[I could eat see what is all of this](https://youtu.be/R1jehN-p2QA?t=01h55m13s)



[doing these are all just setting up](https://youtu.be/R1jehN-p2QA?t=01h55m15s)



[packet Exe path pack a command](https://youtu.be/R1jehN-p2QA?t=01h55m17s)



[bootstrapper command what I'm looking](https://youtu.be/R1jehN-p2QA?t=01h55m21s)



[for is an import it's using tasks get](https://youtu.be/R1jehN-p2QA?t=01h55m24s)



[file hash verify file - great great](https://youtu.be/R1jehN-p2QA?t=01h55m31s)



[where'd you do you have any outputs this](https://youtu.be/R1jehN-p2QA?t=01h55m38s)



[is the packet restore targets see turn](https://youtu.be/R1jehN-p2QA?t=01h55m43s)



[off some warnings regex some stuff great](https://youtu.be/R1jehN-p2QA?t=01h55m48s)



[great great packet restore warning](https://youtu.be/R1jehN-p2QA?t=01h55m52s)



[target frameworks we doing here target](https://youtu.be/R1jehN-p2QA?t=01h56m00s)



[frameworks I didn't pack it resolved](https://youtu.be/R1jehN-p2QA?t=01h56m05s)



[let's look at the target frameworks and](https://youtu.be/R1jehN-p2QA?t=01h56m14s)



[see what that gets used for so target](https://youtu.be/R1jehN-p2QA?t=01h56m16s)



[frameworks iterate over packet](https://youtu.be/R1jehN-p2QA?t=01h56m19s)



[intermediate output path I must build](https://youtu.be/R1jehN-p2QA?t=01h56m21s)



[path that seems like it could be by](https://youtu.be/R1jehN-p2QA?t=01h56m23s)



[teenis](https://youtu.be/R1jehN-p2QA?t=01h56m32s)



[if the intermediate path is set like](https://youtu.be/R1jehN-p2QA?t=01h56m35s)



[that](https://youtu.be/R1jehN-p2QA?t=01h56m37s)



[interesting okay](https://youtu.be/R1jehN-p2QA?t=01h56m44s)



[this guy restored all the stuff and once](https://youtu.be/R1jehN-p2QA?t=01h56m48s)



[again picked up the wrong one I'm going](https://youtu.be/R1jehN-p2QA?t=01h56m51s)



[to assume that the problem is in this](https://youtu.be/R1jehN-p2QA?t=01h56m53s)



[intermediate path and that I don't want](https://youtu.be/R1jehN-p2QA?t=01h56m55s)



[to think too hard](https://youtu.be/R1jehN-p2QA?t=01h57m01s)



[so get clean dfx just like earlier I'll](https://youtu.be/R1jehN-p2QA?t=01h57m02s)



[just whack it like a clean force a brand](https://youtu.be/R1jehN-p2QA?t=01h57m06s)



[new install because typically the](https://youtu.be/R1jehN-p2QA?t=01h57m10s)



[intermediate path on I must build is](https://youtu.be/R1jehN-p2QA?t=01h57m13s)



[referring to your bin obj directory or](https://youtu.be/R1jehN-p2QA?t=01h57m16s)



[I'm sorry not your bin obj your obj](https://youtu.be/R1jehN-p2QA?t=01h57m19s)



[directory underneath your project](https://youtu.be/R1jehN-p2QA?t=01h57m22s)



[structure packet install so if that's](https://youtu.be/R1jehN-p2QA?t=01h57m23s)



[the case this just walked all of them](https://youtu.be/R1jehN-p2QA?t=01h57m34s)



[so if it was holding on to something](https://youtu.be/R1jehN-p2QA?t=01h57m38s)



[because it it looked to me like packet](https://youtu.be/R1jehN-p2QA?t=01h57m40s)



[was creating a file in that directory](https://youtu.be/R1jehN-p2QA?t=01h57m42s)



[and was not detecting the change](https://youtu.be/R1jehN-p2QA?t=01h57m45s)



[store everyone's happy okay so now we'll](https://youtu.be/R1jehN-p2QA?t=01h57m54s)



[relaunch](https://youtu.be/R1jehN-p2QA?t=01h57m59s)



[make sure that this thing actually picks](https://youtu.be/R1jehN-p2QA?t=01h58m02s)



[up the change because I think I actually](https://youtu.be/R1jehN-p2QA?t=01h58m05s)



[fixed this problem in the latest version](https://youtu.be/R1jehN-p2QA?t=01h58m06s)



[has showed me the sample the problem is](https://youtu.be/R1jehN-p2QA?t=01h58m09s)



[is for some reason cannot get it to](https://youtu.be/R1jehN-p2QA?t=01h58m10s)



[install that](https://youtu.be/R1jehN-p2QA?t=01h58m13s)



[okay](https://youtu.be/R1jehN-p2QA?t=01h58m29s)



[let's see what this guy does again](https://youtu.be/R1jehN-p2QA?t=01h58m34s)



[under the dependencies it has two](https://youtu.be/R1jehN-p2QA?t=01h58m39s)



[bunches again go through and restore](https://youtu.be/R1jehN-p2QA?t=01h58m41s)



[just fine we expect that we're gonna](https://youtu.be/R1jehN-p2QA?t=01h58m44s)



[kick off the bill just to force pack it](https://youtu.be/R1jehN-p2QA?t=01h58m51s)



[to run again](https://youtu.be/R1jehN-p2QA?t=01h58m55s)



[cash package package](https://youtu.be/R1jehN-p2QA?t=01h59m07s)



[that's a little disconcerting](https://youtu.be/R1jehN-p2QA?t=01h59m12s)



[really don't like that](https://youtu.be/R1jehN-p2QA?t=01h59m25s)



[come on I'd like to end this on a good](https://youtu.be/R1jehN-p2QA?t=01h59m28s)



[note I like to end this on a good note](https://youtu.be/R1jehN-p2QA?t=01h59m29s)



[it's nice to get a bunch of stuff merged](https://youtu.be/R1jehN-p2QA?t=01h59m38s)



[and fixed but](https://youtu.be/R1jehN-p2QA?t=01h59m40s)



[I still have more stuff to do more stuff](https://youtu.be/R1jehN-p2QA?t=01h59m43s)



[needed and that should be the show me](https://youtu.be/R1jehN-p2QA?t=01h59m46s)



[the sam'l air come on show it to me](https://youtu.be/R1jehN-p2QA?t=01h59m50s)



[you know wanna show it to me okay fine](https://youtu.be/R1jehN-p2QA?t=01h59m57s)



[I'll rebuild](https://youtu.be/R1jehN-p2QA?t=01h59m59s)



[there we go now it's picking up packages](https://youtu.be/R1jehN-p2QA?t=02h00m03s)



[hey look at that now there's a 71 yeah](https://youtu.be/R1jehN-p2QA?t=02h00m06s)



[something was being held on to in one of](https://youtu.be/R1jehN-p2QA?t=02h00m10s)



[those directories and being cashed don't](https://youtu.be/R1jehN-p2QA?t=02h00m13s)



[know where don't know what not entirely](https://youtu.be/R1jehN-p2QA?t=02h00m16s)



[sure at some point I need to figure out](https://youtu.be/R1jehN-p2QA?t=02h00m19s)



[the actual answer so that I don't have](https://youtu.be/R1jehN-p2QA?t=02h00m21s)



[to just nucular option every time and](https://youtu.be/R1jehN-p2QA?t=02h00m23s)



[blow away the whole directory](https://youtu.be/R1jehN-p2QA?t=02h00m26s)



[we will see](https://youtu.be/R1jehN-p2QA?t=02h00m37s)



[oh come on rebuild rebuild you're built](https://youtu.be/R1jehN-p2QA?t=02h00m47s)



[so we can end on a happy note and make](https://youtu.be/R1jehN-p2QA?t=02h00m52s)



[me happy](https://youtu.be/R1jehN-p2QA?t=02h00m54s)



[and again I might go and review this](https://youtu.be/R1jehN-p2QA?t=02h01m03s)



[data set extensions I'm not entirely](https://youtu.be/R1jehN-p2QA?t=02h01m05s)



[sure what this is being used for be nice](https://youtu.be/R1jehN-p2QA?t=02h01m06s)



[to get it off of a preview build too I](https://youtu.be/R1jehN-p2QA?t=02h01m09s)



[don't think it's actually set up as a](https://youtu.be/R1jehN-p2QA?t=02h01m12s)



[pendency so it must just be something in](https://youtu.be/R1jehN-p2QA?t=02h01m15s)



[the demo app because I know it's not uh](https://youtu.be/R1jehN-p2QA?t=02h01m17s)



[I know it's not a dependency of the new](https://youtu.be/R1jehN-p2QA?t=02h01m21s)



[tip package so it has to be a demo app](https://youtu.be/R1jehN-p2QA?t=02h01m24s)



[thing I'm curious what in the demo app](https://youtu.be/R1jehN-p2QA?t=02h01m27s)



[that is needing it and specifically if](https://youtu.be/R1jehN-p2QA?t=02h01m30s)



[anything's needing it to be on that](https://youtu.be/R1jehN-p2QA?t=02h01m35s)



[preview release okay now we've got all](https://youtu.be/R1jehN-p2QA?t=02h01m37s)



[kinds of stuff now we're broken beyond](https://youtu.be/R1jehN-p2QA?t=02h01m42s)



[belief](https://youtu.be/R1jehN-p2QA?t=02h01m45s)



[great](https://youtu.be/R1jehN-p2QA?t=02h01m45s)



[now that you've restored](https://youtu.be/R1jehN-p2QA?t=02h01m51s)



[oh boy we've got a ton of warnings](https://youtu.be/R1jehN-p2QA?t=02h01m57s)



[you go through each of these and take a](https://youtu.be/R1jehN-p2QA?t=02h02m04s)



[look at them some of these though are](https://youtu.be/R1jehN-p2QA?t=02h02m06s)



[design time warnings and I don't](https://youtu.be/R1jehN-p2QA?t=02h02m08s)



[actually care to fix them](https://youtu.be/R1jehN-p2QA?t=02h02m10s)



[a lot of these the ones that are](https://youtu.be/R1jehN-p2QA?t=02h02m16s)



[specifically in like the my up stuff](https://youtu.be/R1jehN-p2QA?t=02h02m18s)



[not really a big deal for me right now](https://youtu.be/R1jehN-p2QA?t=02h02m24s)



[some of these warnings just look like](https://youtu.be/R1jehN-p2QA?t=02h02m31s)



[they're there because the base library](https://youtu.be/R1jehN-p2QA?t=02h02m33s)



[failed to compile so like color zone](https://youtu.be/R1jehN-p2QA?t=02h02m35s)



[doesn't exist well I'm pretty sure it](https://youtu.be/R1jehN-p2QA?t=02h02m40s)



[actually does I expect this number to go](https://youtu.be/R1jehN-p2QA?t=02h02m41s)



[down shortly huh rebuild get yourself](https://youtu.be/R1jehN-p2QA?t=02h02m45s)



[into a happy state](https://youtu.be/R1jehN-p2QA?t=02h02m50s)



[really want to prove that I actually](https://youtu.be/R1jehN-p2QA?t=02h02m54s)



[fixed the assembly issue](https://youtu.be/R1jehN-p2QA?t=02h02m56s)



[really would like to prove that](https://youtu.be/R1jehN-p2QA?t=02h03m02s)



[while we're waiting for that I kind of](https://youtu.be/R1jehN-p2QA?t=02h03m08s)



[want to just look at the you get package](https://youtu.be/R1jehN-p2QA?t=02h03m11s)



[and verify what the dependency version](https://youtu.be/R1jehN-p2QA?t=02h03m14s)



[range was I set so I very explicitly](https://youtu.be/R1jehN-p2QA?t=02h03m16s)



[went and checked it](https://youtu.be/R1jehN-p2QA?t=02h03m19s)



[I've won at it](https://youtu.be/R1jehN-p2QA?t=02h03m24s)



[less than 6 1 but greater than 5 9](https://youtu.be/R1jehN-p2QA?t=02h03m28s)



[this probably should have been greater](https://youtu.be/R1jehN-p2QA?t=02h03m36s)



[than or equal to six oh this should have](https://youtu.be/R1jehN-p2QA?t=02h03m37s)



[been an inclusive lower bound huh add](https://youtu.be/R1jehN-p2QA?t=02h03m41s)



[that to my list of things I should go](https://youtu.be/R1jehN-p2QA?t=02h03m46s)



[fix](https://youtu.be/R1jehN-p2QA?t=02h03m47s)



[but I believe Avalon edit is being](https://youtu.be/R1jehN-p2QA?t=02h03m48s)



[restored at 6o which is great](https://youtu.be/R1jehN-p2QA?t=02h03m52s)



[yes](https://youtu.be/R1jehN-p2QA?t=02h04m03s)



[okay](https://youtu.be/R1jehN-p2QA?t=02h04m08s)



[and once again because I cleared it it](https://youtu.be/R1jehN-p2QA?t=02h04m12s)



[forgot which end was up](https://youtu.be/R1jehN-p2QA?t=02h04m14s)



[all this just to prove that I don't need](https://youtu.be/R1jehN-p2QA?t=02h04m20s)



[a binding redirecting my appconfig](https://youtu.be/R1jehN-p2QA?t=02h04m22s)



[I'm pretty sure is fixed](https://youtu.be/R1jehN-p2QA?t=02h04m25s)



[sure](https://youtu.be/R1jehN-p2QA?t=02h04m37s)



[I went and revved all of the versions so](https://youtu.be/R1jehN-p2QA?t=02h04m40s)



[it should just work](https://youtu.be/R1jehN-p2QA?t=02h04m43s)



[let's meet our goals](https://youtu.be/R1jehN-p2QA?t=02h04m49s)



[we are fixed and working again great](https://youtu.be/R1jehN-p2QA?t=02h04m54s)



[we're just gonna check this guy right on](https://youtu.be/R1jehN-p2QA?t=02h04m58s)



[in let's see](https://youtu.be/R1jehN-p2QA?t=02h05m00s)



[updating show me the sam'l no longer](https://youtu.be/R1jehN-p2QA?t=02h05m06s)



[need finding redirect](https://youtu.be/R1jehN-p2QA?t=02h05m11s)



[commit and](https://youtu.be/R1jehN-p2QA?t=02h05m18s)



[yes push](https://youtu.be/R1jehN-p2QA?t=02h05m23s)



[probably shouldn't be pushing straight](https://youtu.be/R1jehN-p2QA?t=02h05m28s)



[to master I should probably pull](https://youtu.be/R1jehN-p2QA?t=02h05m29s)



[requests and let the build system do its](https://youtu.be/R1jehN-p2QA?t=02h05m31s)



[thing but yeah yeah yeah it's late and I](https://youtu.be/R1jehN-p2QA?t=02h05m33s)



[want to get this last pull request](https://youtu.be/R1jehN-p2QA?t=02h05m39s)



[merged in so where did that guy go you](https://youtu.be/R1jehN-p2QA?t=02h05m41s)



[are now](https://youtu.be/R1jehN-p2QA?t=02h05m46s)



[let's see thanks for the contribution](https://youtu.be/R1jehN-p2QA?t=02h05m50s)



[realized my initial directions wrong and](https://youtu.be/R1jehN-p2QA?t=02h05m54s)



[made some updates](https://youtu.be/R1jehN-p2QA?t=02h06m00s)



[but boom because that really was my](https://youtu.be/R1jehN-p2QA?t=02h06m05s)



[mistake on the initial stuff so three oh](https://youtu.be/R1jehN-p2QA?t=02h06m08s)



[great](https://youtu.be/R1jehN-p2QA?t=02h06m12s)



[squash merge squash merge and](https://youtu.be/R1jehN-p2QA?t=02h06m13s)



[c14 Oh a which i think is this one this](https://youtu.be/R1jehN-p2QA?t=02h06m17s)



[guy's already there](https://youtu.be/R1jehN-p2QA?t=02h06m20s)



[ding-ding-ding and](https://youtu.be/R1jehN-p2QA?t=02h06m22s)



[closed](https://youtu.be/R1jehN-p2QA?t=02h06m26s)



[that is all in and done now now we are a](https://youtu.be/R1jehN-p2QA?t=02h06m30s)



[little bit closer on the three oh stuff](https://youtu.be/R1jehN-p2QA?t=02h06m34s)



[so there's a couple issues in here that](https://youtu.be/R1jehN-p2QA?t=02h06m38s)



[may end up getting punted so there's a](https://youtu.be/R1jehN-p2QA?t=02h06m40s)



[few things in here about like this](https://youtu.be/R1jehN-p2QA?t=02h06m45s)



[pop-up box is closed after being opened](https://youtu.be/R1jehN-p2QA?t=02h06m49s)



[and I'm still trying to get good](https://youtu.be/R1jehN-p2QA?t=02h06m51s)



[reproduction for because I can't make it](https://youtu.be/R1jehN-p2QA?t=02h06m52s)



[happen I need to play around with it](https://youtu.be/R1jehN-p2QA?t=02h06m56s)



[more on my surface go just to see if](https://youtu.be/R1jehN-p2QA?t=02h06m59s)



[that triggers it because that would be](https://youtu.be/R1jehN-p2QA?t=02h07m01s)



[really helpful if I could actually get](https://youtu.be/R1jehN-p2QA?t=02h07m04s)



[this going but Magnus has put in a lot](https://youtu.be/R1jehN-p2QA?t=02h07m08s)



[of good debugging information to try and](https://youtu.be/R1jehN-p2QA?t=02h07m10s)



[help track it down and also this](https://youtu.be/R1jehN-p2QA?t=02h07m13s)



[disabled transition so Magnus if you're](https://youtu.be/R1jehN-p2QA?t=02h07m17s)



[watching this I'm curious if this](https://youtu.be/R1jehN-p2QA?t=02h07m19s)



[actually helped because I know we we](https://youtu.be/R1jehN-p2QA?t=02h07m21s)



[merge some changes in for this to see if](https://youtu.be/R1jehN-p2QA?t=02h07m23s)



[that actually if it ended up just being](https://youtu.be/R1jehN-p2QA?t=02h07m25s)



[a timing problem but that is worth worth](https://youtu.be/R1jehN-p2QA?t=02h07m27s)



[checking on so with that said I think](https://youtu.be/R1jehN-p2QA?t=02h07m34s)



[this guy is probably one of the top ones](https://youtu.be/R1jehN-p2QA?t=02h07m37s)



[and then getting the MA app stuff which](https://youtu.be/R1jehN-p2QA?t=02h07m41s)



[isn't reflected in here and I should](https://youtu.be/R1jehN-p2QA?t=02h07m44s)



[probably get an issue log for it but all](https://youtu.be/R1jehN-p2QA?t=02h07m45s)



[of the MA apps - Oh updates the the](https://youtu.be/R1jehN-p2QA?t=02h07m48s)



[integration library](https://youtu.be/R1jehN-p2QA?t=02h07m52s)



[not the demos not the web did you do](https://youtu.be/R1jehN-p2QA?t=02h07m56s)



[come on close this library here this guy](https://youtu.be/R1jehN-p2QA?t=02h08m01s)



[needs to be updated for mops - oh and](https://youtu.be/R1jehN-p2QA?t=02h08m05s)



[all of the brushes changed which isn't](https://youtu.be/R1jehN-p2QA?t=02h08m09s)



[too big of a hassle](https://youtu.be/R1jehN-p2QA?t=02h08m11s)



[they basically renamed all of their](https://youtu.be/R1jehN-p2QA?t=02h08m13s)



[brushes to follow a nice consistent](https://youtu.be/R1jehN-p2QA?t=02h08m15s)



[naming scheme which is great I approve](https://youtu.be/R1jehN-p2QA?t=02h08m17s)



[and the the problem is we just now need](https://youtu.be/R1jehN-p2QA?t=02h08m20s)



[to update all of our stuff to match the](https://youtu.be/R1jehN-p2QA?t=02h08m24s)



[new naming scheme so shouldn't be too](https://youtu.be/R1jehN-p2QA?t=02h08m26s)



[terribly difficult](https://youtu.be/R1jehN-p2QA?t=02h08m28s)



[would be nice to go through and get it](https://youtu.be/R1jehN-p2QA?t=02h08m29s)



[in but it is what it is for now so but](https://youtu.be/R1jehN-p2QA?t=02h08m31s)



[with that said it is about that two-hour](https://youtu.be/R1jehN-p2QA?t=02h08m37s)



[mark and I am I'm feeling the effects of](https://youtu.be/R1jehN-p2QA?t=02h08m39s)



[that cold from this weekend so with that](https://youtu.be/R1jehN-p2QA?t=02h08m43s)



[I am going to be signing off for the](https://youtu.be/R1jehN-p2QA?t=02h08m46s)



[night again if people have questions](https://youtu.be/R1jehN-p2QA?t=02h08m49s)


