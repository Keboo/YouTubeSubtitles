[YouTube Video](https://youtu.be/Stw0awYWzNo)



[hello everyone welcome back Uh we are](https://youtu.be/Stw0awYWzNo?t=00h00m02s)

[going to dive back in There's a bunch of](https://youtu.be/Stw0awYWzNo?t=00h00m04s)

[PRs and activity from the material](https://youtu.be/Stw0awYWzNo?t=00h00m05s)

[design project that came up uh the last](https://youtu.be/Stw0awYWzNo?t=00h00m07s)

[few days So we're going to get those](https://youtu.be/Stw0awYWzNo?t=00h00m09s)

[reviewed and merged in and then planning](https://youtu.be/Stw0awYWzNo?t=00h00m10s)

[on diving back into MSI work on Velopac](https://youtu.be/Stw0awYWzNo?t=00h00m13s)

[That is what I have been spending my my](https://youtu.be/Stw0awYWzNo?t=00h00m16s)

[nights working on Uh quick update for](https://youtu.be/Stw0awYWzNo?t=00h00m19s)

[anybody interested No stream next week](https://youtu.be/Stw0awYWzNo?t=00h00m21s)

[So I will be gone to the Microsoft MVP](https://youtu.be/Stw0awYWzNo?t=00h00m25s)

[conference Uh unfortunately there's a](https://youtu.be/Stw0awYWzNo?t=00h00m27s)

[good chance I won't be able to share](https://youtu.be/Stw0awYWzNo?t=00h00m30s)

[most of the information that um I learn](https://youtu.be/Stw0awYWzNo?t=00h00m31s)

[there Uh at least typically not until](https://youtu.be/Stw0awYWzNo?t=00h00m34s)

[after build Um usually the build](https://youtu.be/Stw0awYWzNo?t=00h00m37s)

[conference is when a lot of the big](https://youtu.be/Stw0awYWzNo?t=00h00m39s)

[updates and notifications and that kind](https://youtu.be/Stw0awYWzNo?t=00h00m41s)

[of stuff comes out So stay tuned but](https://youtu.be/Stw0awYWzNo?t=00h00m42s)

[there will probably be cool stuff that](https://youtu.be/Stw0awYWzNo?t=00h00m45s)

[comes in the next several months And on](https://youtu.be/Stw0awYWzNo?t=00h00m47s)

[that note if you haven't signed up for](https://youtu.be/Stw0awYWzNo?t=00h00m49s)

[Microsoft Build it is definitely](https://youtu.be/Stw0awYWzNo?t=00h00m50s)

[worthwhile Um they do online streaming](https://youtu.be/Stw0awYWzNo?t=00h00m52s)

[of most of the sessions Obviously you](https://youtu.be/Stw0awYWzNo?t=00h00m54s)

[can't take part in a lot of the um](https://youtu.be/Stw0awYWzNo?t=00h00m57s)

[in-person events but if you're just](https://youtu.be/Stw0awYWzNo?t=00h00m59s)

[interested in session content it is a](https://youtu.be/Stw0awYWzNo?t=00h01m01s)

[great thing to do Okay let's dive](https://youtu.be/Stw0awYWzNo?t=00h01m03s)

[in](https://youtu.be/Stw0awYWzNo?t=00h01m08s)

[So if I can find my](https://youtu.be/Stw0awYWzNo?t=00h01m10s)

[button we can So pull requests So](https://youtu.be/Stw0awYWzNo?t=00h01m13s)

[there's this one here Um and this issue](https://youtu.be/Stw0awYWzNo?t=00h01m16s)

[came up Uh so I saw J Booth log this](https://youtu.be/Stw0awYWzNo?t=00h01m20s)

[issue which it was pretty good analysis](https://youtu.be/Stw0awYWzNo?t=00h01m24s)

[Uh effectively this update attached](https://youtu.be/Stw0awYWzNo?t=00h01m26s)

[properties was firing fairly rapidly and](https://youtu.be/Stw0awYWzNo?t=00h01m29s)

[it looked like um that it uh was](https://youtu.be/Stw0awYWzNo?t=00h01m31s)

[potentially being hit from multiple](https://youtu.be/Stw0awYWzNo?t=00h01m36s)

[threads uh or at least being changed uh](https://youtu.be/Stw0awYWzNo?t=00h01m37s)

[midway through on an invocation And so](https://youtu.be/Stw0awYWzNo?t=00h01m41s)

[went through and opened a poll request](https://youtu.be/Stw0awYWzNo?t=00h01m44s)

[and I thought this poll request was a](https://youtu.be/Stw0awYWzNo?t=00h01m47s)

[beautiful example So I kind of wanted to](https://youtu.be/Stw0awYWzNo?t=00h01m50s)

[just showcase it for a moment So this is](https://youtu.be/Stw0awYWzNo?t=00h01m51s)

[a perfect example of what to do when you](https://youtu.be/Stw0awYWzNo?t=00h01m56s)

[are dealing with threading problems So](https://youtu.be/Stw0awYWzNo?t=00h01m58s)

[the the the obvious question is when you](https://youtu.be/Stw0awYWzNo?t=00h02m01s)

[see something like this right what the](https://youtu.be/Stw0awYWzNo?t=00h02m03s)

[what is the problem here and the issue](https://youtu.be/Stw0awYWzNo?t=00h02m06s)

[is when you have a property in C the](https://youtu.be/Stw0awYWzNo?t=00h02m09s)

[property getters are effectively method](https://youtu.be/Stw0awYWzNo?t=00h02m11s)

[calls right if you imagine you know just](https://youtu.be/Stw0awYWzNo?t=00h02m14s)

[a couple little friends on the end of](https://youtu.be/Stw0awYWzNo?t=00h02m16s)

[this uh observable object and then the](https://youtu.be/Stw0awYWzNo?t=00h02m18s)

[other one here that it kind of becomes a](https://youtu.be/Stw0awYWzNo?t=00h02m20s)

[little more obvious The idea is you're](https://youtu.be/Stw0awYWzNo?t=00h02m22s)

[invoking that getter method twice And](https://youtu.be/Stw0awYWzNo?t=00h02m24s)

[for things like auto properties they're](https://youtu.be/Stw0awYWzNo?t=00h02m28s)

[probably going to return you the same](https://youtu.be/Stw0awYWzNo?t=00h02m31s)

[thing every time probably the same](https://youtu.be/Stw0awYWzNo?t=00h02m32s)

[instance but they might not Something](https://youtu.be/Stw0awYWzNo?t=00h02m34s)

[could change that value such that the](https://youtu.be/Stw0awYWzNo?t=00h02m37s)

[getter returns a different uh value back](https://youtu.be/Stw0awYWzNo?t=00h02m39s)

[to you The same problem would occur if](https://youtu.be/Stw0awYWzNo?t=00h02m42s)

[this was a field right if you read that](https://youtu.be/Stw0awYWzNo?t=00h02m44s)

[field twice another thread could come in](https://youtu.be/Stw0awYWzNo?t=00h02m46s)

[and modify it out from under you such](https://youtu.be/Stw0awYWzNo?t=00h02m49s)

[that when you read it the next time it's](https://youtu.be/Stw0awYWzNo?t=00h02m51s)

[nice that you checked it for null but](https://youtu.be/Stw0awYWzNo?t=00h02m53s)

[the next time around you've got no](https://youtu.be/Stw0awYWzNo?t=00h02m55s)

[guarantee that it'll be non-null So the](https://youtu.be/Stw0awYWzNo?t=00h02m57s)

[the common trick here uh or technique I](https://youtu.be/Stw0awYWzNo?t=00h03m00s)

[guess is worth noting is at least in C](https://youtu.be/Stw0awYWzNo?t=00h03m04s)

[is to go with uh pattern matching Now it](https://youtu.be/Stw0awYWzNo?t=00h03m07s)

[doesn't have to be pattern matching the](https://youtu.be/Stw0awYWzNo?t=00h03m10s)

[the basic technique says invoke the](https://youtu.be/Stw0awYWzNo?t=00h03m12s)

[getter and uh cache the return value](https://youtu.be/Stw0awYWzNo?t=00h03m14s)

[from the getter in a local variable Now](https://youtu.be/Stw0awYWzNo?t=00h03m17s)

[pattern matching in C# just gives us a](https://youtu.be/Stw0awYWzNo?t=00h03m20s)

[way to do that in one line So that's](https://youtu.be/Stw0awYWzNo?t=00h03m22s)

[that's kind of convenient because we can](https://youtu.be/Stw0awYWzNo?t=00h03m24s)

[declare a local variable check it for](https://youtu.be/Stw0awYWzNo?t=00h03m25s)

[null and then drop and then drop inside](https://youtu.be/Stw0awYWzNo?t=00h03m28s)

[an if non-null So we can do all of that](https://youtu.be/Stw0awYWzNo?t=00h03m31s)

[in a single statement in C But the basic](https://youtu.be/Stw0awYWzNo?t=00h03m33s)

[premise is stored in a local variable](https://youtu.be/Stw0awYWzNo?t=00h03m36s)

[and the reason is because local](https://youtu.be/Stw0awYWzNo?t=00h03m37s)

[variables are thread safe by definition](https://youtu.be/Stw0awYWzNo?t=00h03m39s)

[That's pretty cool So if local variables](https://youtu.be/Stw0awYWzNo?t=00h03m41s)

[are thread safe by definition then it](https://youtu.be/Stw0awYWzNo?t=00h03m45s)

[means that now that we've checked this](https://youtu.be/Stw0awYWzNo?t=00h03m47s)

[guy for null all of these calls are](https://youtu.be/Stw0awYWzNo?t=00h03m49s)

[going to be safe because we've cached](https://youtu.be/Stw0awYWzNo?t=00h03m51s)

[this value Now it doesn't guard against](https://youtu.be/Stw0awYWzNo?t=00h03m54s)

[somebody mutating something about this](https://youtu.be/Stw0awYWzNo?t=00h03m56s)

[object but at least this instance of the](https://youtu.be/Stw0awYWzNo?t=00h03m58s)

[object we we guarantee is going to be uh](https://youtu.be/Stw0awYWzNo?t=00h04m00s)

[nonnull for the life of this if](https://youtu.be/Stw0awYWzNo?t=00h04m03s)

[condition So uh very simple easy change](https://youtu.be/Stw0awYWzNo?t=00h04m05s)

[I saw Nikolai already approved it](https://youtu.be/Stw0awYWzNo?t=00h04m08s)

[I just didn't merge it because I wanted](https://youtu.be/Stw0awYWzNo?t=00h04m11s)

[to show it off Um and so we are going to](https://youtu.be/Stw0awYWzNo?t=00h04m12s)

[bring that sucker in And I think](https://youtu.be/Stw0awYWzNo?t=00h04m17s)

[somebody already moved the issue into 53](https://youtu.be/Stw0awYWzNo?t=00h04m21s)

[Good good good good good good beautiful](https://youtu.be/Stw0awYWzNo?t=00h04m24s)

[beautiful beautiful beautiful beautiful](https://youtu.be/Stw0awYWzNo?t=00h04m26s)

[Okay perfect That one goes](https://youtu.be/Stw0awYWzNo?t=00h04m28s)

[there And then I've got my my T-Unit](https://youtu.be/Stw0awYWzNo?t=00h04m30s)

[stuff which the only thing here and the](https://youtu.be/Stw0awYWzNo?t=00h04m34s)

[only reason this didn't merge is all of](https://youtu.be/Stw0awYWzNo?t=00h04m36s)

[my async calls it the the analyzers are](https://youtu.be/Stw0awYWzNo?t=00h04m38s)

[wanting to flag uh and have me pass the](https://youtu.be/Stw0awYWzNo?t=00h04m41s)

[cancellation token through which is a](https://youtu.be/Stw0awYWzNo?t=00h04m44s)

[good thing to do and I appreciate that](https://youtu.be/Stw0awYWzNo?t=00h04m47s)

[it it has that but it means I have to](https://youtu.be/Stw0awYWzNo?t=00h04m48s)

[update a lot of different stuff Right so](https://youtu.be/Stw0awYWzNo?t=00h04m51s)

[this one here um and let's take a look](https://youtu.be/Stw0awYWzNo?t=00h04m54s)

[at this issue in question Right so um so](https://youtu.be/Stw0awYWzNo?t=00h04m56s)

[autosuggest box input text disappears](https://youtu.be/Stw0awYWzNo?t=00h05m02s)

[after](https://youtu.be/Stw0awYWzNo?t=00h05m04s)

[deselecting suggestion and pressing tab](https://youtu.be/Stw0awYWzNo?t=00h05m06s)

[enter Uh let's see if I intentionally](https://youtu.be/Stw0awYWzNo?t=00h05m09s)

[deselect an item using the updown arrow](https://youtu.be/Stw0awYWzNo?t=00h05m13s)

[keys So let me let me see here because](https://youtu.be/Stw0awYWzNo?t=00h05m16s)

[I'm curious if this is expected behavior](https://youtu.be/Stw0awYWzNo?t=00h05m18s)

[or not So we've got the dropown](https://youtu.be/Stw0awYWzNo?t=00h05m20s)

[open We intentionally deselect and then](https://youtu.be/Stw0awYWzNo?t=00h05m24s)

[press tab or enter The text disappears](https://youtu.be/Stw0awYWzNo?t=00h05m28s)

[Interesting](https://youtu.be/Stw0awYWzNo?t=00h05m31s)

[Trying to think what the expected](https://youtu.be/Stw0awYWzNo?t=00h05m37s)

[behavior is here because I think the](https://youtu.be/Stw0awYWzNo?t=00h05m39s)

[desired behavior is for it to more or](https://youtu.be/Stw0awYWzNo?t=00h05m41s)

[less mirror an editable combo](https://youtu.be/Stw0awYWzNo?t=00h05m44s)

[box in a lot of cases because the the](https://youtu.be/Stw0awYWzNo?t=00h05m48s)

[autosuggest box is designed to be](https://youtu.be/Stw0awYWzNo?t=00h05m52s)

[somewhat similar It's just because the](https://youtu.be/Stw0awYWzNo?t=00h05m54s)

[combo box doesn't have good matching](https://youtu.be/Stw0awYWzNo?t=00h05m56s)

[behavior](https://youtu.be/Stw0awYWzNo?t=00h05m59s)

[Um uh let's see If I intentionally](https://youtu.be/Stw0awYWzNo?t=00h06m01s)

[deselect an item using up down arrow](https://youtu.be/Stw0awYWzNo?t=00h06m03s)

[keys and then tab or enter text](https://youtu.be/Stw0awYWzNo?t=00h06m05s)

[disappears Okay so let's go in here](https://youtu.be/Stw0awYWzNo?t=00h06m07s)

[Let's see Uh currently users can know](https://youtu.be/Stw0awYWzNo?t=00h06m10s)

[the selected item using the up down](https://youtu.be/Stw0awYWzNo?t=00h06m13s)

[arrow keys I also tried to add a test](https://youtu.be/Stw0awYWzNo?t=00h06m15s)

[for this but I can't get it to work](https://youtu.be/Stw0awYWzNo?t=00h06m17s)

[Might be a me problem but couldn't](https://youtu.be/Stw0awYWzNo?t=00h06m18s)

[figure out how to access the item source](https://youtu.be/Stw0awYWzNo?t=00h06m20s)

[suggestions of the auto suggest box](https://youtu.be/Stw0awYWzNo?t=00h06m22s)

[Instead of the actual suggestion I got](https://youtu.be/Stw0awYWzNo?t=00h06m24s)

[back a list of characters saying](https://youtu.be/Stw0awYWzNo?t=00h06m26s)

[collection Well let's take a look This](https://youtu.be/Stw0awYWzNo?t=00h06m30s)

[this sounds like a very interesting](https://youtu.be/Stw0awYWzNo?t=00h06m32s)

[problem](https://youtu.be/Stw0awYWzNo?t=00h06m35s)

[Uh okay So this guy here is checking](https://youtu.be/Stw0awYWzNo?t=00h06m42s)

[the this this gives me a bit of pause](https://youtu.be/Stw0awYWzNo?t=00h06m50s)

[specifically](https://youtu.be/Stw0awYWzNo?t=00h06m54s)

[because this is this is trying to check](https://youtu.be/Stw0awYWzNo?t=00h06m56s)

[if we are at the last](https://youtu.be/Stw0awYWzNo?t=00h07m00s)

[item or not Right but the the only issue](https://youtu.be/Stw0awYWzNo?t=00h07m03s)

[with a line like this is this in order](https://youtu.be/Stw0awYWzNo?t=00h07m07s)

[to do count uh curly brace curly brace](https://youtu.be/Stw0awYWzNo?t=00h07m09s)

[This is the link count method and so in](https://youtu.be/Stw0awYWzNo?t=00h07m12s)

[order to count it it has to iterate](https://youtu.be/Stw0awYWzNo?t=00h07m15s)

[through the entire collection So as the](https://youtu.be/Stw0awYWzNo?t=00h07m17s)

[collection increases the performance of](https://youtu.be/Stw0awYWzNo?t=00h07m18s)

[this method goes down Now that's not](https://youtu.be/Stw0awYWzNo?t=00h07m21s)

[always true because it like count has](https://youtu.be/Stw0awYWzNo?t=00h07m23s)

[short circuits and link for things that](https://youtu.be/Stw0awYWzNo?t=00h07m26s)

[are like collection or list](https://youtu.be/Stw0awYWzNo?t=00h07m27s)

[based But in this case with the cast](https://youtu.be/Stw0awYWzNo?t=00h07m30s)

[object I kind of suspect we will lose](https://youtu.be/Stw0awYWzNo?t=00h07m33s)

[all of that Um](https://youtu.be/Stw0awYWzNo?t=00h07m36s)

[but make sure there's no more comments](https://youtu.be/Stw0awYWzNo?t=00h07m40s)

[down here Great Let's take a look at](https://youtu.be/Stw0awYWzNo?t=00h07m42s)

[this Let's take a look at this So](https://youtu.be/Stw0awYWzNo?t=00h07m45s)

[3815 We go here](https://youtu.be/Stw0awYWzNo?t=00h07m48s)

[Uh 3817 Did I just read that](https://youtu.be/Stw0awYWzNo?t=00h07m54s)

[wrong well this is the](https://youtu.be/Stw0awYWzNo?t=00h08m02s)

[issue Pull request is 3878 Okay Yes So](https://youtu.be/Stw0awYWzNo?t=00h08m04s)

[short version I can't read That's okay](https://youtu.be/Stw0awYWzNo?t=00h08m08s)

[Like boy I uh let's](https://youtu.be/Stw0awYWzNo?t=00h08m12s)

[see uh](https://youtu.be/Stw0awYWzNo?t=00h08m14s)

[checkout and then control shift E to](https://youtu.be/Stw0awYWzNo?t=00h08m19s)

[fire up my visual](https://youtu.be/Stw0awYWzNo?t=00h08m22s)

[studio Uh do not recover](https://youtu.be/Stw0awYWzNo?t=00h08m24s)

[My computer was chasing some very](https://youtu.be/Stw0awYWzNo?t=00h08m31s)

[interesting bugs today My my work](https://youtu.be/Stw0awYWzNo?t=00h08m34s)

[project involved tracking](https://youtu.be/Stw0awYWzNo?t=00h08m38s)

[down issues that uh were crashing the](https://youtu.be/Stw0awYWzNo?t=00h08m40s)

[the runtime So that was](https://youtu.be/Stw0awYWzNo?t=00h08m44s)

[exciting Short version unmanaged memory](https://youtu.be/Stw0awYWzNo?t=00h08m46s)

[sucks Well sucks to debug I'll put it](https://youtu.be/Stw0awYWzNo?t=00h08m50s)

[that way Pain in the neck Eventually](https://youtu.be/Stw0awYWzNo?t=00h08m53s)

[tracked it down after like four hours](https://youtu.be/Stw0awYWzNo?t=00h08m56s)

[but we got them Okay So let's take a](https://youtu.be/Stw0awYWzNo?t=00h08m58s)

[look here and see So this is auto](https://youtu.be/Stw0awYWzNo?t=00h09m02s)

[suggest box tests around](https://youtu.be/Stw0awYWzNo?t=00h09m05s)

[165 We'll start with the UI test Uh](https://youtu.be/Stw0awYWzNo?t=00h09m08s)

[autosuggest box text I assume it's](https://youtu.be/Stw0awYWzNo?t=00h09m11s)

[probably the last one or](https://youtu.be/Stw0awYWzNo?t=00h09m13s)

[thereabouts](https://youtu.be/Stw0awYWzNo?t=00h09m16s)

[Yep Okay So and then in](https://youtu.be/Stw0awYWzNo?t=00h09m18s)

[particular the issue came with I want to](https://youtu.be/Stw0awYWzNo?t=00h09m22s)

[look at that highlighted line uh where](https://youtu.be/Stw0awYWzNo?t=00h09m26s)

[it was getting the item source back and](https://youtu.be/Stw0awYWzNo?t=00h09m29s)

[this might be a case](https://youtu.be/Stw0awYWzNo?t=00h09m31s)

[where suggestion box get](https://youtu.be/Stw0awYWzNo?t=00h09m37s)

[suggestions Yeah So let's see here So we](https://youtu.be/Stw0awYWzNo?t=00h09m42s)

[have load user control autosuggest box](https://youtu.be/Stw0awYWzNo?t=00h09m44s)

[with template as autosuggest box which](https://youtu.be/Stw0awYWzNo?t=00h09m47s)

[is fine right so this is probably a user](https://youtu.be/Stw0awYWzNo?t=00h09m50s)

[controll or](https://youtu.be/Stw0awYWzNo?t=00h09m53s)

[similar Uh looks a heck of a lot like](https://youtu.be/Stw0awYWzNo?t=00h09m54s)

[it Where is it though is under](https://youtu.be/Stw0awYWzNo?t=00h09m59s)

[samples Yeah Okay So here's here's the](https://youtu.be/Stw0awYWzNo?t=00h10m03s)

[here's the ZAML we're working](https://youtu.be/Stw0awYWzNo?t=00h10m06s)

[with Okay So there's an auto suggest box](https://youtu.be/Stw0awYWzNo?t=00h10m08s)

[at the root Um there's some suggestions](https://youtu.be/Stw0awYWzNo?t=00h10m11s)

[and all of that jazz Great great great](https://youtu.be/Stw0awYWzNo?t=00h10m13s)

[great great Anything on the code behind](https://youtu.be/Stw0awYWzNo?t=00h10m15s)

[worth](https://youtu.be/Stw0awYWzNo?t=00h10m17s)

[noting not a ton](https://youtu.be/Stw0awYWzNo?t=00h10m19s)

[here Could update it to some new fancier](https://youtu.be/Stw0awYWzNo?t=00h10m22s)

[syntax but um nothing](https://youtu.be/Stw0awYWzNo?t=00h10m25s)

[major Okay Pulls the element to get the](https://youtu.be/Stw0awYWzNo?t=00h10m30s)

[popup Inside the popup pulls the list](https://youtu.be/Stw0awYWzNo?t=00h10m33s)

[box which is what um actually](https://youtu.be/Stw0awYWzNo?t=00h10m35s)

[displays Uh let's see He moves the](https://youtu.be/Stw0awYWzNo?t=00h10m38s)

[keyboard focus to the suggestion](https://youtu.be/Stw0awYWzNo?t=00h10m40s)

[box sends the input E to get it to pop](https://youtu.be/Stw0awYWzNo?t=00h10m43s)

[and then waits And then this here looks](https://youtu.be/Stw0awYWzNo?t=00h10m46s)

[like the line in question](https://youtu.be/Stw0awYWzNo?t=00h10m49s)

[um that was failing So this is calling](https://youtu.be/Stw0awYWzNo?t=00h10m51s)

[get](https://youtu.be/Stw0awYWzNo?t=00h10m55s)

[suggestions And what is this is a](https://youtu.be/Stw0awYWzNo?t=00h10m57s)

[generated](https://youtu.be/Stw0awYWzNo?t=00h11m00s)

[one This is kicking back an I](https://youtu.be/Stw0awYWzNo?t=00h11m02s)

[innumerable I'm kind of curious](https://youtu.be/Stw0awYWzNo?t=00h11m08s)

[So](https://youtu.be/Stw0awYWzNo?t=00h11m14s)

[uh I kind of want to just run this by](https://youtu.be/Stw0awYWzNo?t=00h11m18s)

[itself before I get too carried away and](https://youtu.be/Stw0awYWzNo?t=00h11m21s)

[just see what that comes back](https://youtu.be/Stw0awYWzNo?t=00h11m24s)

[with because I am I am worried that](https://youtu.be/Stw0awYWzNo?t=00h11m28s)

[we're getting an item of an item](https://youtu.be/Stw0awYWzNo?t=00h11m30s)

[here But this is the suggest box](https://youtu.be/Stw0awYWzNo?t=00h11m34s)

[The autosuggest box does have a](https://youtu.be/Stw0awYWzNo?t=00h11m40s)

[suggestions property And this might be](https://youtu.be/Stw0awYWzNo?t=00h11m42s)

[the kicker here is this is a non generic](https://youtu.be/Stw0awYWzNo?t=00h11m44s)

[innumerable I would have kind of](https://youtu.be/Stw0awYWzNo?t=00h11m50s)

[expected this to work](https://youtu.be/Stw0awYWzNo?t=00h11m52s)

[but find](https://youtu.be/Stw0awYWzNo?t=00h11m54s)

[out Uh the Mountain Dew the sweet nectar](https://youtu.be/Stw0awYWzNo?t=00h12m02s)

[of life Okay](https://youtu.be/Stw0awYWzNo?t=00h12m05s)

[Come on Build Compile Go Go Go Go](https://youtu.be/Stw0awYWzNo?t=00h12m11s)

[Go I think my computer is still](https://youtu.be/Stw0awYWzNo?t=00h12m15s)

[resisting after I subjected it to](https://youtu.be/Stw0awYWzNo?t=00h12m17s)

[massive memory load](https://youtu.be/Stw0awYWzNo?t=00h12m21s)

[earlier This is great Chasing a memory](https://youtu.be/Stw0awYWzNo?t=00h12m24s)

[leak that will just literally consume as](https://youtu.be/Stw0awYWzNo?t=00h12m26s)

[much RAM as you](https://youtu.be/Stw0awYWzNo?t=00h12m28s)

[have Okay so that got us to there](https://youtu.be/Stw0awYWzNo?t=00h12m30s)

[Oh so this is actually probably an](https://youtu.be/Stw0awYWzNo?t=00h12m39s)

[issue with the way Zaml test](https://youtu.be/Stw0awYWzNo?t=00h12m44s)

[genens It is blindly creating this](https://youtu.be/Stw0awYWzNo?t=00h12m50s)

[So the the problem here is ZAML](https://youtu.be/Stw0awYWzNo?t=00h12m58s)

[test has to effectively because there's](https://youtu.be/Stw0awYWzNo?t=00h13m03s)

[two processes running right there's the](https://youtu.be/Stw0awYWzNo?t=00h13m05s)

[WPF app that's being executed that](https://youtu.be/Stw0awYWzNo?t=00h13m07s)

[contains all the ZAML and then there's](https://youtu.be/Stw0awYWzNo?t=00h13m09s)

[your test app and these two have to talk](https://youtu.be/Stw0awYWzNo?t=00h13m11s)

[to each other because they are not the](https://youtu.be/Stw0awYWzNo?t=00h13m14s)

[same process they are different](https://youtu.be/Stw0awYWzNo?t=00h13m15s)

[processes that's the big](https://youtu.be/Stw0awYWzNo?t=00h13m17s)

[thing um and they kind of have to be](https://youtu.be/Stw0awYWzNo?t=00h13m20s)

[separate processes because WPF has like](https://youtu.be/Stw0awYWzNo?t=00h13m23s)

[app level startup stuff that you can't](https://youtu.be/Stw0awYWzNo?t=00h13m26s)

[reinitialize once you've started And so](https://youtu.be/Stw0awYWzNo?t=00h13m29s)

[that's how ZAML test works is it spins a](https://youtu.be/Stw0awYWzNo?t=00h13m32s)

[brand new WPF process That way it can](https://youtu.be/Stw0awYWzNo?t=00h13m35s)

[guarantee that it's starting in a fresh](https://youtu.be/Stw0awYWzNo?t=00h13m37s)

[state and then can manipulate stuff Now](https://youtu.be/Stw0awYWzNo?t=00h13m39s)

[that means that you have to be](https://youtu.be/Stw0awYWzNo?t=00h13m42s)

[intelligent about how you write your](https://youtu.be/Stw0awYWzNo?t=00h13m43s)

[test because you don't want to do that](https://youtu.be/Stw0awYWzNo?t=00h13m44s)

[on every test because that would be slow](https://youtu.be/Stw0awYWzNo?t=00h13m45s)

[But it it does mean that you you have](https://youtu.be/Stw0awYWzNo?t=00h13m47s)

[the ability to test an app fully uh up](https://youtu.be/Stw0awYWzNo?t=00h13m50s)

[and running Um so the issue here though](https://youtu.be/Stw0awYWzNo?t=00h13m53s)

[is I I strongly suspect that what is](https://youtu.be/Stw0awYWzNo?t=00h13m58s)

[happening is this guy](https://youtu.be/Stw0awYWzNo?t=00h14m02s)

[is tworing the class and that's what's](https://youtu.be/Stw0awYWzNo?t=00h14m05s)

[coming](https://youtu.be/Stw0awYWzNo?t=00h14m09s)

[back That is almost assuredly what is](https://youtu.be/Stw0awYWzNo?t=00h14m12s)

[happening Uh let's see here If we go up](https://youtu.be/Stw0awYWzNo?t=00h14m17s)

[the top Oh it is attaching the debugger](https://youtu.be/Stw0awYWzNo?t=00h14m22s)

[to the remote process So we can grab](https://youtu.be/Stw0awYWzNo?t=00h14m25s)

[this on the other](https://youtu.be/Stw0awYWzNo?t=00h14m28s)

[side That's kind of annoying though that](https://youtu.be/Stw0awYWzNo?t=00h14m34s)

[it's doing that How would we send that](https://youtu.be/Stw0awYWzNo?t=00h14m37s)

[back how would we send that back because](https://youtu.be/Stw0awYWzNo?t=00h14m40s)

[in this](https://youtu.be/Stw0awYWzNo?t=00h14m44s)

[case bot get suggestions count](https://youtu.be/Stw0awYWzNo?t=00h14m57s)

[non-generic](https://youtu.be/Stw0awYWzNo?t=00h15m00s)

[innumerable Yeah And this is this is](https://youtu.be/Stw0awYWzNo?t=00h15m04s)

[fine like this is not a horrible way of](https://youtu.be/Stw0awYWzNo?t=00h15m06s)

[doing it but](https://youtu.be/Stw0awYWzNo?t=00h15m08s)

[it's I think the easier option here is](https://youtu.be/Stw0awYWzNo?t=00h15m12s)

[to work around the the limitation](https://youtu.be/Stw0awYWzNo?t=00h15m15s)

[because if this is a collection view](https://youtu.be/Stw0awYWzNo?t=00h15m17s)

[there's no good way to serialize a](https://youtu.be/Stw0awYWzNo?t=00h15m21s)

[collection view that I'm aware of I mean](https://youtu.be/Stw0awYWzNo?t=00h15m23s)

[you you kind of can](https://youtu.be/Stw0awYWzNo?t=00h15m27s)

[but I'm trying to think of how I would](https://youtu.be/Stw0awYWzNo?t=00h15m32s)

[do that You you almost need to like at](https://youtu.be/Stw0awYWzNo?t=00h15m34s)

[some point ZAML test needs to be updated](https://youtu.be/Stw0awYWzNo?t=00h15m37s)

[with like fully remote](https://youtu.be/Stw0awYWzNo?t=00h15m39s)

[object rather than this serializing of](https://youtu.be/Stw0awYWzNo?t=00h15m42s)

[the objects back and forth because when](https://youtu.be/Stw0awYWzNo?t=00h15m44s)

[you retrieve a a value back with ZAML](https://youtu.be/Stw0awYWzNo?t=00h15m46s)

[test like this visual element is more or](https://youtu.be/Stw0awYWzNo?t=00h15m49s)

[less fully remote because when you're](https://youtu.be/Stw0awYWzNo?t=00h15m51s)

[acting on this it's not actually the](https://youtu.be/Stw0awYWzNo?t=00h15m53s)

[list box itself It's an object that when](https://youtu.be/Stw0awYWzNo?t=00h15m56s)

[you say for example call get suggestions](https://youtu.be/Stw0awYWzNo?t=00h15m59s)

[on it it makes a call back across to the](https://youtu.be/Stw0awYWzNo?t=00h16m02s)

[other process to say give me the](https://youtu.be/Stw0awYWzNo?t=00h16m05s)

[suggestions property And so it's it's](https://youtu.be/Stw0awYWzNo?t=00h16m07s)

[remoting all of those calls back and](https://youtu.be/Stw0awYWzNo?t=00h16m10s)

[forth But that does mean when you ask](https://youtu.be/Stw0awYWzNo?t=00h16m12s)

[for values it functionally has to](https://youtu.be/Stw0awYWzNo?t=00h16m14s)

[serialize them in order to get something](https://youtu.be/Stw0awYWzNo?t=00h16m16s)

[all the way all the way back which makes](https://youtu.be/Stw0awYWzNo?t=00h16m18s)

[it mildly more](https://youtu.be/Stw0awYWzNo?t=00h16m21s)

[uh difficult](https://youtu.be/Stw0awYWzNo?t=00h16m24s)

[Uh](https://youtu.be/Stw0awYWzNo?t=00h16m33s)

[yeah looking to see why I'm being pinged](https://youtu.be/Stw0awYWzNo?t=00h16m34s)

[Um okay So I think what we would do here](https://youtu.be/Stw0awYWzNo?t=00h16m37s)

[instead though is rather than going](https://youtu.be/Stw0awYWzNo?t=00h16m40s)

[after because this has a view](https://youtu.be/Stw0awYWzNo?t=00h16m43s)

[model and at the end of the day what we](https://youtu.be/Stw0awYWzNo?t=00h16m48s)

[really want is suggested](https://youtu.be/Stw0awYWzNo?t=00h16m51s)

[things right right So let's clean this](https://youtu.be/Stw0awYWzNo?t=00h16m54s)

[up And I I think we can go primary](https://youtu.be/Stw0awYWzNo?t=00h16m56s)

[constructor on that](https://youtu.be/Stw0awYWzNo?t=00h16m59s)

[guy We](https://youtu.be/Stw0awYWzNo?t=00h17m00s)

[can we can do collection](https://youtu.be/Stw0awYWzNo?t=00h17m02s)

[initializers We can do collection](https://youtu.be/Stw0awYWzNo?t=00h17m06s)

[initializers Collection initializers](https://youtu.be/Stw0awYWzNo?t=00h17m10s)

[which I I've really started to love in C](https://youtu.be/Stw0awYWzNo?t=00h17m12s)

[One of those things Took a little bit](https://youtu.be/Stw0awYWzNo?t=00h17m16s)

[but they they're slowly growing on](https://youtu.be/Stw0awYWzNo?t=00h17m17s)

[me](https://youtu.be/Stw0awYWzNo?t=00h17m19s)

[Um because I think that makes our](https://youtu.be/Stw0awYWzNo?t=00h17m23s)

[life a little](https://youtu.be/Stw0awYWzNo?t=00h17m27s)

[bit We will reach across to the](https://youtu.be/Stw0awYWzNo?t=00h17m33s)

[um the view model](https://youtu.be/Stw0awYWzNo?t=00h17m39s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=00h17m42s)

[Um I think what we're going to do](https://youtu.be/Stw0awYWzNo?t=00h17m43s)

[here give ourselves a nice injection](https://youtu.be/Stw0awYWzNo?t=00h17m48s)

[point to be able to invoke I](https://youtu.be/Stw0awYWzNo?t=00h17m51s)

[think because we could do something](https://youtu.be/Stw0awYWzNo?t=00h17m55s)

[like the](https://youtu.be/Stw0awYWzNo?t=00h17m58s)

[box](https://youtu.be/Stw0awYWzNo?t=00h18m03s)

[Uh how do I get myself to](https://youtu.be/Stw0awYWzNo?t=00h18m06s)

[a I get myself all the way to the view](https://youtu.be/Stw0awYWzNo?t=00h18m10s)

[model look through I thought we had some](https://youtu.be/Stw0awYWzNo?t=00h18m14s)

[samples in here of doing](https://youtu.be/Stw0awYWzNo?t=00h18m17s)

[such No](https://youtu.be/Stw0awYWzNo?t=00h18m23s)

[this you up too](https://youtu.be/Stw0awYWzNo?t=00h18m30s)

[Oh](https://youtu.be/Stw0awYWzNo?t=00h18m36s)

[yeah lots of chest bugs with template](https://youtu.be/Stw0awYWzNo?t=00h18m45s)

[Yeah I think on some of these we have](https://youtu.be/Stw0awYWzNo?t=00h18m50s)

[gone through and implemented](https://youtu.be/Stw0awYWzNo?t=00h18m54s)

[um callbacks to be able to get the data](https://youtu.be/Stw0awYWzNo?t=00h19m01s)

[that we](https://youtu.be/Stw0awYWzNo?t=00h19m04s)

[want](https://youtu.be/Stw0awYWzNo?t=00h19m05s)

[Um I think that probably makes our life](https://youtu.be/Stw0awYWzNo?t=00h19m09s)

[a little bit](https://youtu.be/Stw0awYWzNo?t=00h19m12s)

[easier Uh do](https://youtu.be/Stw0awYWzNo?t=00h19m16s)

[what how to go about grabbing this](https://youtu.be/Stw0awYWzNo?t=00h19m19s)

[because part of me is really tempted to](https://youtu.be/Stw0awYWzNo?t=00h19m23s)

[just Why is this an observable](https://youtu.be/Stw0awYWzNo?t=00h19m30s)

[collection if we always just assign to](https://youtu.be/Stw0awYWzNo?t=00h19m32s)

[it doesn't need to be an observable](https://youtu.be/Stw0awYWzNo?t=00h19m40s)

[collection if we're always just](https://youtu.be/Stw0awYWzNo?t=00h19m42s)

[assigning to it](https://youtu.be/Stw0awYWzNo?t=00h19m43s)

[I think where do we give](https://youtu.be/Stw0awYWzNo?t=00h19m49s)

[ourselves code behind these](https://youtu.be/Stw0awYWzNo?t=00h19m53s)

[stuff i'm wondering if we ever](https://youtu.be/Stw0awYWzNo?t=00h19m57s)

[use if we always just get it](https://youtu.be/Stw0awYWzNo?t=00h20m02s)

[indirectly Um let's let's try](https://youtu.be/Stw0awYWzNo?t=00h20m10s)

[the I wrote this library I should know](https://youtu.be/Stw0awYWzNo?t=00h20m15s)

[this Uh let's see I element I wonder if](https://youtu.be/Stw0awYWzNo?t=00h20m20s)

[we can get away with](https://youtu.be/Stw0awYWzNo?t=00h20m25s)

[this](https://youtu.be/Stw0awYWzNo?t=00h20m27s)

[Um we're going here](https://youtu.be/Stw0awYWzNo?t=00h20m30s)

[Uh new model gets a](https://youtu.be/Stw0awYWzNo?t=00h20m40s)

[weight](https://youtu.be/Stw0awYWzNo?t=00h20m44s)

[Um I wonder if I can get the view](https://youtu.be/Stw0awYWzNo?t=00h20m52s)

[model](https://youtu.be/Stw0awYWzNo?t=00h20m56s)

[back I think we can I think we](https://youtu.be/Stw0awYWzNo?t=00h20m58s)

[can The data context](https://youtu.be/Stw0awYWzNo?t=00h21m01s)

[Auto I wonder if I should try to do a](https://youtu.be/Stw0awYWzNo?t=00h21m18s)

[collection](https://youtu.be/Stw0awYWzNo?t=00h21m21s)

[view just serializes a list The problem](https://youtu.be/Stw0awYWzNo?t=00h21m22s)

[is is then you have to serialize the](https://youtu.be/Stw0awYWzNo?t=00h21m26s)

[view models in the list What are we](https://youtu.be/Stw0awYWzNo?t=00h21m27s)

[actually trying to do here](https://youtu.be/Stw0awYWzNo?t=00h21m30s)

[we just want the](https://youtu.be/Stw0awYWzNo?t=00h21m32s)

[count That's really what we're after is](https://youtu.be/Stw0awYWzNo?t=00h21m37s)

[the number of items in the](https://youtu.be/Stw0awYWzNo?t=00h21m40s)

[box Actually why can we not just get](https://youtu.be/Stw0awYWzNo?t=00h21m48s)

[that I collection](https://youtu.be/Stw0awYWzNo?t=00h21m53s)

[view TV](https://youtu.be/Stw0awYWzNo?t=00h21m57s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=00h22m04s)

[uh first](https://youtu.be/Stw0awYWzNo?t=00h22m13s)

[collection I think we can get away with](https://youtu.be/Stw0awYWzNo?t=00h22m17s)

[this And the what I'm so kind of what](https://youtu.be/Stw0awYWzNo?t=00h22m23s)

[I'm thinking is we should be able to get](https://youtu.be/Stw0awYWzNo?t=00h22m26s)

[property and then I should be able to](https://youtu.be/Stw0awYWzNo?t=00h22m31s)

[do item](https://youtu.be/Stw0awYWzNo?t=00h22m34s)

[source](https://youtu.be/Stw0awYWzNo?t=00h22m37s)

[source collection](https://youtu.be/Stw0awYWzNo?t=00h22m39s)

[I](https://youtu.be/Stw0awYWzNo?t=00h22m43s)

[think get property And what does this](https://youtu.be/Stw0awYWzNo?t=00h22m47s)

[give me](https://youtu.be/Stw0awYWzNo?t=00h22m50s)

[back i have to cast it in order to get](https://youtu.be/Stw0awYWzNo?t=00h22m52s)

[something useful from](https://youtu.be/Stw0awYWzNo?t=00h22m55s)

[it Can't remember if this because it](https://youtu.be/Stw0awYWzNo?t=00h23m09s)

[uses reflection to walk through the](https://youtu.be/Stw0awYWzNo?t=00h23m12s)

[properties So I think I can get away](https://youtu.be/Stw0awYWzNo?t=00h23m14s)

[with just arbitrarily invoking this this](https://youtu.be/Stw0awYWzNo?t=00h23m17s)

[way and getting it down to something a](https://youtu.be/Stw0awYWzNo?t=00h23m19s)

[little more](https://youtu.be/Stw0awYWzNo?t=00h23m21s)

[literal](https://youtu.be/Stw0awYWzNo?t=00h23m24s)

[Okay Oh](https://youtu.be/Stw0awYWzNo?t=00h23m32s)

[Um this is not going to work because I](https://youtu.be/Stw0awYWzNo?t=00h23m39s)

[typed the wrong thing in This needs to](https://youtu.be/Stw0awYWzNo?t=00h23m42s)

[be](https://youtu.be/Stw0awYWzNo?t=00h23m47s)

[suggestions because the implication here](https://youtu.be/Stw0awYWzNo?t=00h23m49s)

[is that suggestions](https://youtu.be/Stw0awYWzNo?t=00h23m52s)

[is well this thing is a](https://youtu.be/Stw0awYWzNo?t=00h23m56s)

[list So I should be able to just](https://youtu.be/Stw0awYWzNo?t=00h24m03s)

[do count on](https://youtu.be/Stw0awYWzNo?t=00h24m07s)

[it without so without worrying about](https://youtu.be/Stw0awYWzNo?t=00h24m09s)

[going to a collection view I should be](https://youtu.be/Stw0awYWzNo?t=00h24m12s)

[able to do that](https://youtu.be/Stw0awYWzNo?t=00h24m13s)

[So the question is can](https://youtu.be/Stw0awYWzNo?t=00h24m15s)

[I](https://youtu.be/Stw0awYWzNo?t=00h24m27s)

[no that no](https://youtu.be/Stw0awYWzNo?t=00h24m30s)

[workie probably](https://youtu.be/Stw0awYWzNo?t=00h24m33s)

[should could not find a property with](https://youtu.be/Stw0awYWzNo?t=00h24m35s)

[name suggestions count on autosuggest](https://youtu.be/Stw0awYWzNo?t=00h24m39s)

[box](https://youtu.be/Stw0awYWzNo?t=00h24m46s)

[Okay Get property](https://youtu.be/Stw0awYWzNo?t=00h25m00s)

[Can](https://youtu.be/Stw0awYWzNo?t=00h25m15s)

[I trying to remember where the call back](https://youtu.be/Stw0awYWzNo?t=00h25m18s)

[is](https://youtu.be/Stw0awYWzNo?t=00h25m20s)

[if I call get as I can try to send it as](https://youtu.be/Stw0awYWzNo?t=00h25m33s)

[something that might be serializable but](https://youtu.be/Stw0awYWzNo?t=00h25m36s)

[we're asking](https://youtu.be/Stw0awYWzNo?t=00h25m37s)

[for like I want to](https://youtu.be/Stw0awYWzNo?t=00h25m39s)

[not property Is there a way around this](https://youtu.be/Stw0awYWzNo?t=00h25m48s)

[it has overloads for dependency property](https://youtu.be/Stw0awYWzNo?t=00h26m00s)

[get](https://youtu.be/Stw0awYWzNo?t=00h26m02s)

[property I](https://youtu.be/Stw0awYWzNo?t=00h26m04s)

[value The type that contains the](https://youtu.be/Stw0awYWzNo?t=00h26m20s)

[property](https://youtu.be/Stw0awYWzNo?t=00h26m22s)

[Yeah that's going to be a problem](https://youtu.be/Stw0awYWzNo?t=00h26m31s)

[go about that Okay So how would we go](https://youtu.be/Stw0awYWzNo?t=00h27m26s)

[about doing let me just open sle test](https://youtu.be/Stw0awYWzNo?t=00h27m31s)

[real quick I not have it open](https://youtu.be/Stw0awYWzNo?t=00h27m33s)

[That's the](https://youtu.be/Stw0awYWzNo?t=00h27m46s)

[remote Let's go to](https://youtu.be/Stw0awYWzNo?t=00h27m51s)

[master Uh let's](https://youtu.be/Stw0awYWzNo?t=00h27m57s)

[see I want to be on remote](https://youtu.be/Stw0awYWzNo?t=00h28m00s)

[master And then let's open this guy](https://youtu.be/Stw0awYWzNo?t=00h28m05s)

[because I](https://youtu.be/Stw0awYWzNo?t=00h28m08s)

[I almost want get property to let me do](https://youtu.be/Stw0awYWzNo?t=00h28m11s)

[something a little more ingenious](https://youtu.be/Stw0awYWzNo?t=00h28m14s)

[Okay I want to look at my](https://youtu.be/Stw0awYWzNo?t=00h28m21s)

[tests and I](https://youtu.be/Stw0awYWzNo?t=00h28m23s)

[want let's see test](https://youtu.be/Stw0awYWzNo?t=00h28m32s)

[cleanup get element get element get](https://youtu.be/Stw0awYWzNo?t=00h28m35s)

[element my bad spelling](https://youtu.be/Stw0awYWzNo?t=00h28m42s)

[um](https://youtu.be/Stw0awYWzNo?t=00h28m45s)

[s reorder It's because get property I](https://youtu.be/Stw0awYWzNo?t=00h28m51s)

[don't know if I wrote specific test for](https://youtu.be/Stw0awYWzNo?t=00h28m55s)

[because it gets indirectly tested in so](https://youtu.be/Stw0awYWzNo?t=00h28m56s)

[many other cases](https://youtu.be/Stw0awYWzNo?t=00h28m59s)

[um](https://youtu.be/Stw0awYWzNo?t=00h29m05s)

[ordinance I'm somewhat tempted to just](https://youtu.be/Stw0awYWzNo?t=00h29m12s)

[add the](https://youtu.be/Stw0awYWzNo?t=00h29m15s)

[functionality Stop](https://youtu.be/Stw0awYWzNo?t=00h29m22s)

[it Stop helping me um visual element](https://youtu.be/Stw0awYWzNo?t=00h29m24s)

[because it's these converters that end](https://youtu.be/Stw0awYWzNo?t=00h29m28s)

[up doing](https://youtu.be/Stw0awYWzNo?t=00h29m30s)

[it and because there is no convert go to](https://youtu.be/Stw0awYWzNo?t=00h29m33s)

[implementation because there's no](https://youtu.be/Stw0awYWzNo?t=00h29m37s)

[converter for I list of generic view](https://youtu.be/Stw0awYWzNo?t=00h29m39s)

[model like that's not something that's](https://youtu.be/Stw0awYWzNo?t=00h29m41s)

[going to exist](https://youtu.be/Stw0awYWzNo?t=00h29m42s)

[um](https://youtu.be/Stw0awYWzNo?t=00h29m45s)

[uh let's find](https://youtu.be/Stw0awYWzNo?t=00h29m50s)

[element mode execution](https://youtu.be/Stw0awYWzNo?t=00h29m52s)

[It could remote execute a](https://youtu.be/Stw0awYWzNo?t=00h29m56s)

[method You know that might be the path](https://youtu.be/Stw0awYWzNo?t=00h30m07s)

[of least](https://youtu.be/Stw0awYWzNo?t=00h30m09s)

[resistance Go back here real quick I](https://youtu.be/Stw0awYWzNo?t=00h30m11s)

[wonder I think we have a sample of](https://youtu.be/Stw0awYWzNo?t=00h30m14s)

[this None](https://youtu.be/Stw0awYWzNo?t=00h30m18s)

[Oh that's clearly a real valuable one](https://youtu.be/Stw0awYWzNo?t=00h30m22s)

[then This is built for that Uh let's see](https://youtu.be/Stw0awYWzNo?t=00h30m25s)

[S Why do I not see anything leveraging](https://youtu.be/Stw0awYWzNo?t=00h30m38s)

[it okay big head out of the way](https://youtu.be/Stw0awYWzNo?t=00h30m42s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=00h30m47s)

[then validation v like there's all of](https://youtu.be/Stw0awYWzNo?t=00h30m49s)

[the stuff there Show me the](https://youtu.be/Stw0awYWzNo?t=00h30m52s)

[tests](https://youtu.be/Stw0awYWzNo?t=00h31m04s)

[Ah this this is the dirty trick This is](https://youtu.be/Stw0awYWzNo?t=00h31m08s)

[the dirty trick Okay Okay](https://youtu.be/Stw0awYWzNo?t=00h31m12s)

[Um let's](https://youtu.be/Stw0awYWzNo?t=00h31m19s)

[see static void](https://youtu.be/Stw0awYWzNo?t=00h31m21s)

[uh](https://youtu.be/Stw0awYWzNo?t=00h31m24s)

[get gestion out we can do list of](https://youtu.be/Stw0awYWzNo?t=00h31m27s)

[uh gestion](https://youtu.be/Stw0awYWzNo?t=00h31m35s)

[thing Yeah And then what we can do is we](https://youtu.be/Stw0awYWzNo?t=00h31m39s)

[can remote execute this guy So remote](https://youtu.be/Stw0awYWzNo?t=00h31m44s)

[execute is](https://youtu.be/Stw0awYWzNo?t=00h31m48s)

[a kind of a wacky](https://youtu.be/Stw0awYWzNo?t=00h31m50s)

[situation where you can remotely execute](https://youtu.be/Stw0awYWzNo?t=00h31m53s)

[a method and the other so this method](https://youtu.be/Stw0awYWzNo?t=00h31m57s)

[will execute in the uh in the context of](https://youtu.be/Stw0awYWzNo?t=00h32m02s)

[the other process So the WPF process but](https://youtu.be/Stw0awYWzNo?t=00h32m06s)

[you can declare the method in your](https://youtu.be/Stw0awYWzNo?t=00h32m09s)

[um in your test project We can go](https://youtu.be/Stw0awYWzNo?t=00h32m15s)

[autoest](https://youtu.be/Stw0awYWzNo?t=00h32m19s)

[box auto](https://youtu.be/Stw0awYWzNo?t=00h32m20s)

[suggest box and then we can](https://youtu.be/Stw0awYWzNo?t=00h32m22s)

[do autosuggest boxions.count](https://youtu.be/Stw0awYWzNo?t=00h32m27s)

[uh.length](https://youtu.be/Stw0awYWzNo?t=00h32m32s)

[length What is this oh this is the](https://youtu.be/Stw0awYWzNo?t=00h32m33s)

[innumerable](https://youtu.be/Stw0awYWzNo?t=00h32m36s)

[um well let's just do count](https://youtu.be/Stw0awYWzNo?t=00h32m39s)

[uh of](https://youtu.be/Stw0awYWzNo?t=00h32m43s)

[type object We'll do the slow way right](https://youtu.be/Stw0awYWzNo?t=00h32m45s)

[and then we are going to return](https://youtu.be/Stw0awYWzNo?t=00h32m49s)

[count Then this becomes an int And then](https://youtu.be/Stw0awYWzNo?t=00h32m53s)

[what we can do here](https://youtu.be/Stw0awYWzNo?t=00h32m57s)

[uh we'll do nullable int I](https://youtu.be/Stw0awYWzNo?t=00h33m00s)

[guess that's fine And then down here](https://youtu.be/Stw0awYWzNo?t=00h33m02s)

[what we can do](https://youtu.be/Stw0awYWzNo?t=00h33m05s)

[is we can do item count Get rid of](https://youtu.be/Stw0awYWzNo?t=00h33m07s)

[this right and we can](https://youtu.be/Stw0awYWzNo?t=00h33m13s)

[do int item count gets](https://youtu.be/Stw0awYWzNo?t=00h33m16s)

[uh suggest box remote](https://youtu.be/Stw0awYWzNo?t=00h33m21s)

[execute get suggestion](https://youtu.be/Stw0awYWzNo?t=00h33m25s)

[count](https://youtu.be/Stw0awYWzNo?t=00h33m32s)

[and that needs to be a noble end](https://youtu.be/Stw0awYWzNo?t=00h33m34s)

[Okay And actually what we'll do is we'll](https://youtu.be/Stw0awYWzNo?t=00h33m38s)

[just do this this comes back as null](https://youtu.be/Stw0awYWzNo?t=00h33m41s)

[We'll just do](https://youtu.be/Stw0awYWzNo?t=00h33m44s)

[that Okay So I think this works And](https://youtu.be/Stw0awYWzNo?t=00h33m45s)

[because we're debugging both processes](https://youtu.be/Stw0awYWzNo?t=00h33m48s)

[we're going to grab it here And I expect](https://youtu.be/Stw0awYWzNo?t=00h33m50s)

[to go bing bing bing and hit all three](https://youtu.be/Stw0awYWzNo?t=00h33m52s)

[break points We should hit this one then](https://youtu.be/Stw0awYWzNo?t=00h33m55s)

[this one then this](https://youtu.be/Stw0awYWzNo?t=00h33m58s)

[one There's that F5 There we go We get](https://youtu.be/Stw0awYWzNo?t=00h34m00s)

[the suggestion box We can access the](https://youtu.be/Stw0awYWzNo?t=00h34m05s)

[suggestions in real time We can get the](https://youtu.be/Stw0awYWzNo?t=00h34m06s)

[count](https://youtu.be/Stw0awYWzNo?t=00h34m09s)

[back And now we now we have the item](https://youtu.be/Stw0awYWzNo?t=00h34m10s)

[count to](https://youtu.be/Stw0awYWzNo?t=00h34m12s)

[four That's better Um okay So we'll](https://youtu.be/Stw0awYWzNo?t=00h34m14s)

[clean this up Clean this up I don't](https://youtu.be/Stw0awYWzNo?t=00h34m18s)

[think we need this or this or any of](https://youtu.be/Stw0awYWzNo?t=00h34m22s)

[this We don't need this anymore We don't](https://youtu.be/Stw0awYWzNo?t=00h34m24s)

[need this anymore](https://youtu.be/Stw0awYWzNo?t=00h34m27s)

[Now I think we can just blind run this](https://youtu.be/Stw0awYWzNo?t=00h34m30s)

[test and then we'll write up a nice](https://youtu.be/Stw0awYWzNo?t=00h34m35s)

[we'll write up a nice reply for](https://youtu.be/Stw0awYWzNo?t=00h34m39s)

[Corin's since this confused living](https://youtu.be/Stw0awYWzNo?t=00h34m43s)

[daylights out of me as](https://youtu.be/Stw0awYWzNo?t=00h34m46s)

[well Green test pass Yay Okay So I will](https://youtu.be/Stw0awYWzNo?t=00h34m50s)

[uh let's see](https://youtu.be/Stw0awYWzNo?t=00h34m57s)

[here Uh let's see what do we got Let me](https://youtu.be/Stw0awYWzNo?t=00h34m59s)

[back to the other side Okay So let's](https://youtu.be/Stw0awYWzNo?t=00h35m02s)

[look at the changes So we](https://youtu.be/Stw0awYWzNo?t=00h35m05s)

[have](https://youtu.be/Stw0awYWzNo?t=00h35m08s)

[cleanup I don't know that we need this](https://youtu.be/Stw0awYWzNo?t=00h35m12s)

[cleanup](https://youtu.be/Stw0awYWzNo?t=00h35m15s)

[here Don't necessarily need that cleanup](https://youtu.be/Stw0awYWzNo?t=00h35m16s)

[there This is what we need right](https://youtu.be/Stw0awYWzNo?t=00h35m19s)

[so and I think rather than pushing back](https://youtu.be/Stw0awYWzNo?t=00h35m22s)

[I'm going to go code](https://youtu.be/Stw0awYWzNo?t=00h35m26s)

[suggest Then we're going to send](https://youtu.be/Stw0awYWzNo?t=00h35m29s)

[it And so what that has done if we go](https://youtu.be/Stw0awYWzNo?t=00h35m32s)

[back to our ER](https://youtu.be/Stw0awYWzNo?t=00h35m37s)

[um and we're going to add a little more](https://youtu.be/Stw0awYWzNo?t=00h35m43s)

[context](https://youtu.be/Stw0awYWzNo?t=00h35m46s)

[here Okay So let's see So what](https://youtu.be/Stw0awYWzNo?t=00h35m50s)

[is happening is ZAML test runs two](https://youtu.be/Stw0awYWzNo?t=00h35m54s)

[processes One for the](https://youtu.be/Stw0awYWzNo?t=00h36m00s)

[tests and one for the WPF](https://youtu.be/Stw0awYWzNo?t=00h36m04s)

[app for all of the](https://youtu.be/Stw0awYWzNo?t=00h36m09s)

[dependency properties It](https://youtu.be/Stw0awYWzNo?t=00h36m13s)

[generates extension methods for](https://youtu.be/Stw0awYWzNo?t=00h36m17s)

[the getters and](https://youtu.be/Stw0awYWzNo?t=00h36m21s)

[setters](https://youtu.be/Stw0awYWzNo?t=00h36m24s)

[Uh however for the values to flow back](https://youtu.be/Stw0awYWzNo?t=00h36m26s)

[and forth uh from the](https://youtu.be/Stw0awYWzNo?t=00h36m33s)

[WPF process to](https://youtu.be/Stw0awYWzNo?t=00h36m38s)

[uh test process they must be sterilized](https://youtu.be/Stw0awYWzNo?t=00h36m41s)

[um is](https://youtu.be/Stw0awYWzNo?t=00h36m48s)

[uh fall back is to just](https://youtu.be/Stw0awYWzNo?t=00h36m52s)

[uh tworing the value](https://youtu.be/Stw0awYWzNo?t=00h36m58s)

[uh value which is why you](https://youtu.be/Stw0awYWzNo?t=00h37m02s)

[uh see that](https://youtu.be/Stw0awYWzNo?t=00h37m07s)

[result There](https://youtu.be/Stw0awYWzNo?t=00h37m09s)

[is a patch option](https://youtu.be/Stw0awYWzNo?t=00h37m13s)

[uh which lets you declare a method in](https://youtu.be/Stw0awYWzNo?t=00h37m22s)

[your](https://youtu.be/Stw0awYWzNo?t=00h37m28s)

[uh test code that will be executed from](https://youtu.be/Stw0awYWzNo?t=00h37m31s)

[the WPF process](https://youtu.be/Stw0awYWzNo?t=00h37m37s)

[as long as you make its return type](https://youtu.be/Stw0awYWzNo?t=00h37m41s)

[something that can](https://youtu.be/Stw0awYWzNo?t=00h37m47s)

[serialized and pass](https://youtu.be/Stw0awYWzNo?t=00h37m50s)

[back whatever you want](https://youtu.be/Stw0awYWzNo?t=00h37m53s)

[um the](https://youtu.be/Stw0awYWzNo?t=00h37m59s)

[suggestion flow I do this to get](https://youtu.be/Stw0awYWzNo?t=00h38m01s)

[uh count of the suggestions](https://youtu.be/Stw0awYWzNo?t=00h38m06s)

[um](https://youtu.be/Stw0awYWzNo?t=00h38m10s)

[by directly acting on the auto](https://youtu.be/Stw0awYWzNo?t=00h38m12s)

[suggest box Okay update comment There we](https://youtu.be/Stw0awYWzNo?t=00h38m18s)

[go So we'll let Corin run with that](https://youtu.be/Stw0awYWzNo?t=00h38m23s)

[which he'll probably knock it out of the](https://youtu.be/Stw0awYWzNo?t=00h38m26s)

[park Bippity boppity booya Okay now for](https://youtu.be/Stw0awYWzNo?t=00h38m27s)

[something a little different That](https://youtu.be/Stw0awYWzNo?t=00h38m30s)

[catches up on the material this time](https://youtu.be/Stw0awYWzNo?t=00h38m32s)

[That catches up Okay fellow pack Fellow](https://youtu.be/Stw0awYWzNo?t=00h38m35s)

[pack though Okay so there I streamed a](https://youtu.be/Stw0awYWzNo?t=00h38m37s)

[while back building MSIs for Velopac and](https://youtu.be/Stw0awYWzNo?t=00h38m41s)

[I kind of ran down a path and then I](https://youtu.be/Stw0awYWzNo?t=00h38m44s)

[dialed it back and I tried some other](https://youtu.be/Stw0awYWzNo?t=00h38m46s)

[stuff and I came back tried again You](https://youtu.be/Stw0awYWzNo?t=00h38m47s)

[can see I've got multiple MSI branches](https://youtu.be/Stw0awYWzNo?t=00h38m49s)

[This has not gone well But but now we](https://youtu.be/Stw0awYWzNo?t=00h38m51s)

[have something much closer to working So](https://youtu.be/Stw0awYWzNo?t=00h38m55s)

[close this down for a second And we're](https://youtu.be/Stw0awYWzNo?t=00h38m58s)

[going to switch](https://youtu.be/Stw0awYWzNo?t=00h39m00s)

[switch Where is it bellow pack I want](https://youtu.be/Stw0awYWzNo?t=00h39m03s)

[well I want two things I want Visual](https://youtu.be/Stw0awYWzNo?t=00h39m08s)

[Studio and then I want](https://youtu.be/Stw0awYWzNo?t=00h39m10s)

[code I want VS code open So currently](https://youtu.be/Stw0awYWzNo?t=00h39m14s)

[Git Kraken doesn't let you bind multiple](https://youtu.be/Stw0awYWzNo?t=00h39m19s)

[editors So my workaround is I just open](https://youtu.be/Stw0awYWzNo?t=00h39m21s)

[code from the terminal and VS uh Visual](https://youtu.be/Stw0awYWzNo?t=00h39m25s)

[Studio full I bind to my keyboard](https://youtu.be/Stw0awYWzNo?t=00h39m28s)

[shortcut So that's my that's my](https://youtu.be/Stw0awYWzNo?t=00h39m30s)

[workaround for the moment I want them to](https://youtu.be/Stw0awYWzNo?t=00h39m32s)

[it'd be really](https://youtu.be/Stw0awYWzNo?t=00h39m35s)

[cool Okay so here is the game](https://youtu.be/Stw0awYWzNo?t=00h39m36s)

[plan because it's an ugly game plan So I](https://youtu.be/Stw0awYWzNo?t=00h39m40s)

[have a whole lot of stuff in progress on](https://youtu.be/Stw0awYWzNo?t=00h39m44s)

[this MSI branch](https://youtu.be/Stw0awYWzNo?t=00h39m48s)

[So the plan we've gone round and round](https://youtu.be/Stw0awYWzNo?t=00h39m50s)

[on this but MSIs are a hard requirement](https://youtu.be/Stw0awYWzNo?t=00h39m53s)

[for a lot of companies that just don't](https://youtu.be/Stw0awYWzNo?t=00h39m58s)

[like exemplars Fine I get it Right they](https://youtu.be/Stw0awYWzNo?t=00h40m00s)

[aren't our preferred](https://youtu.be/Stw0awYWzNo?t=00h40m03s)

[option but they are somewhat necessary](https://youtu.be/Stw0awYWzNo?t=00h40m04s)

[And we'd previously done a bit of work](https://youtu.be/Stw0awYWzNo?t=00h40m08s)

[around making um the update process work](https://youtu.be/Stw0awYWzNo?t=00h40m11s)

[inside of protected directories And what](https://youtu.be/Stw0awYWzNo?t=00h40m15s)

[I mean by that is like your C col](https://youtu.be/Stw0awYWzNo?t=00h40m17s)

[program files That is a protected](https://youtu.be/Stw0awYWzNo?t=00h40m19s)

[directory that without a UAC prompt your](https://youtu.be/Stw0awYWzNo?t=00h40m21s)

[app is not going to be writing to that](https://youtu.be/Stw0awYWzNo?t=00h40m24s)

[folder at least by default in Windows](https://youtu.be/Stw0awYWzNo?t=00h40m27s)

[Right so that app is protected Um it has](https://youtu.be/Stw0awYWzNo?t=00h40m31s)

[been since I think Windows Vista long](https://youtu.be/Stw0awYWzNo?t=00h40m34s)

[bloody time Um and](https://youtu.be/Stw0awYWzNo?t=00h40m37s)

[so given that when we go to perform an](https://youtu.be/Stw0awYWzNo?t=00h40m40s)

[update what needs to happen is we need](https://youtu.be/Stw0awYWzNo?t=00h40m44s)

[to download the new package and then](https://youtu.be/Stw0awYWzNo?t=00h40m46s)

[there's a bootstrap or an update.exe](https://youtu.be/Stw0awYWzNo?t=00h40m50s)

[that lives inside of that package Now](https://youtu.be/Stw0awYWzNo?t=00h40m52s)

[when we go to install that we want to](https://youtu.be/Stw0awYWzNo?t=00h40m55s)

[use the new update.exe not the one](https://youtu.be/Stw0awYWzNo?t=00h40m58s)

[that's on disk We want to use the one](https://youtu.be/Stw0awYWzNo?t=00h41m00s)

[from the package That's very important](https://youtu.be/Stw0awYWzNo?t=00h41m02s)

[because when it is](https://youtu.be/Stw0awYWzNo?t=00h41m04s)

[uh pulled](https://youtu.be/Stw0awYWzNo?t=00h41m07s)

[down that update exe because in Windows](https://youtu.be/Stw0awYWzNo?t=00h41m10s)

[you cannot cannot delete yourself right](https://youtu.be/Stw0awYWzNo?t=00h41m13s)

[ironically you can rename your your file](https://youtu.be/Stw0awYWzNo?t=00h41m17s)

[but you can't delete yourself which is](https://youtu.be/Stw0awYWzNo?t=00h41m20s)

[kind of annoying so what we do is a bit](https://youtu.be/Stw0awYWzNo?t=00h41m22s)

[of a bait and switch right so when the](https://youtu.be/Stw0awYWzNo?t=00h41m25s)

[app wants to update it invokes the](https://youtu.be/Stw0awYWzNo?t=00h41m28s)

[update exe passes it in some information](https://youtu.be/Stw0awYWzNo?t=00h41m30s)

[about like its process and where the new](https://youtu.be/Stw0awYWzNo?t=00h41m33s)

[package is and whatnot Terminates itself](https://youtu.be/Stw0awYWzNo?t=00h41m34s)

[update exe goes I got you does the](https://youtu.be/Stw0awYWzNo?t=00h41m37s)

[update and then restarts the app Right](https://youtu.be/Stw0awYWzNo?t=00h41m40s)

[you need kind of that back and forth](https://youtu.be/Stw0awYWzNo?t=00h41m42s)

[communication That way uh one process](https://youtu.be/Stw0awYWzNo?t=00h41m44s)

[can gracefully terminate let the other](https://youtu.be/Stw0awYWzNo?t=00h41m47s)

[one replace it and then get started back](https://youtu.be/Stw0awYWzNo?t=00h41m50s)

[up So for MSIs that's the current game](https://youtu.be/Stw0awYWzNo?t=00h41m52s)

[plan is we are we're going to get in](https://youtu.be/Stw0awYWzNo?t=00h41m56s)

[something that can be used to install](https://youtu.be/Stw0awYWzNo?t=00h41m57s)

[all users has some basic UI](https://youtu.be/Stw0awYWzNo?t=00h41m59s)

[functionality We're going to be using](https://youtu.be/Stw0awYWzNo?t=00h42m02s)

[Wix 5 just because that's latest and we](https://youtu.be/Stw0awYWzNo?t=00h42m04s)

[looked at Wix 3 and that's what's](https://youtu.be/Stw0awYWzNo?t=00h42m07s)

[bundled in and there's still going to be](https://youtu.be/Stw0awYWzNo?t=00h42m09s)

[the MSI deployment tool that's out there](https://youtu.be/Stw0awYWzNo?t=00h42m10s)

[but it we're we're hiding it Like it](https://youtu.be/Stw0awYWzNo?t=00h42m14s)

[still is going to exist but we're going](https://youtu.be/Stw0awYWzNo?t=00h42m16s)

[to hide the options in the CLI Like it's](https://youtu.be/Stw0awYWzNo?t=00h42m18s)

[not preferred It's not recommended It's](https://youtu.be/Stw0awYWzNo?t=00h42m21s)

[there It's a hack and the only reason](https://youtu.be/Stw0awYWzNo?t=00h42m22s)

[we're leaving it there is because it](https://youtu.be/Stw0awYWzNo?t=00h42m25s)

[existed in Cloud Squirrel and we want to](https://youtu.be/Stw0awYWzNo?t=00h42m27s)

[make the migration path for people easy](https://youtu.be/Stw0awYWzNo?t=00h42m29s)

[And so if somebody's using it and wants](https://youtu.be/Stw0awYWzNo?t=00h42m31s)

[to keep using it you can turn the](https://youtu.be/Stw0awYWzNo?t=00h42m32s)

[command line switch on and keep getting](https://youtu.be/Stw0awYWzNo?t=00h42m34s)

[it We just don't recommend it This is](https://youtu.be/Stw0awYWzNo?t=00h42m36s)

[going to be the preferred option](https://youtu.be/Stw0awYWzNo?t=00h42m38s)

[So what have we done what have we done](https://youtu.be/Stw0awYWzNo?t=00h42m40s)

[so inside of here and actually I'm going](https://youtu.be/Stw0awYWzNo?t=00h42m44s)

[to do this in VS Code because I get](https://youtu.be/Stw0awYWzNo?t=00h42m46s)

[multiple](https://youtu.be/Stw0awYWzNo?t=00h42m47s)

[terminals Get Kraken only gives me one](https://youtu.be/Stw0awYWzNo?t=00h42m48s)

[terminal So we're going to we're going](https://youtu.be/Stw0awYWzNo?t=00h42m50s)

[to play in the area with multiple](https://youtu.be/Stw0awYWzNo?t=00h42m51s)

[terminals So if I go here so this is in](https://youtu.be/Stw0awYWzNo?t=00h42m52s)

[for anybody who wants to play along at](https://youtu.be/Stw0awYWzNo?t=00h42m55s)

[home Here's the Velopac repo public open](https://youtu.be/Stw0awYWzNo?t=00h42m57s)

[source It is it is free If you are](https://youtu.be/Stw0awYWzNo?t=00h43m01s)

[building if you are building a desktop](https://youtu.be/Stw0awYWzNo?t=00h43m04s)

[application of any kind in my opinion](https://youtu.be/Stw0awYWzNo?t=00h43m07s)

[this is](https://youtu.be/Stw0awYWzNo?t=00h43m10s)

[the the best way of building installers](https://youtu.be/Stw0awYWzNo?t=00h43m11s)

[and distributing like our goal is to be](https://youtu.be/Stw0awYWzNo?t=00h43m15s)

[fast and easy For that reason there may](https://youtu.be/Stw0awYWzNo?t=00h43m16s)

[be some like more esoteric features that](https://youtu.be/Stw0awYWzNo?t=00h43m19s)

[we go nah But there's there's a handful](https://youtu.be/Stw0awYWzNo?t=00h43m21s)

[of basic stuff that we kind of feel like](https://youtu.be/Stw0awYWzNo?t=00h43m24s)

[really should be in the box Basic basic](https://youtu.be/Stw0awYWzNo?t=00h43m25s)

[UI like being able to pick install](https://youtu.be/Stw0awYWzNo?t=00h43m28s)

[locations except ulas those kind of](https://youtu.be/Stw0awYWzNo?t=00h43m30s)

[thing Like that's kind](https://youtu.be/Stw0awYWzNo?t=00h43m31s)

[of standard like that should be in the](https://youtu.be/Stw0awYWzNo?t=00h43m33s)

[box Being able to install current user](https://youtu.be/Stw0awYWzNo?t=00h43m36s)

[or all users that should kind of be in](https://youtu.be/Stw0awYWzNo?t=00h43m38s)

[the box Um being able to install uh](https://youtu.be/Stw0awYWzNo?t=00h43m40s)

[services that should kind of be in the](https://youtu.be/Stw0awYWzNo?t=00h43m44s)

[box So um those types of things we're](https://youtu.be/Stw0awYWzNo?t=00h43m46s)

[building The services are going to be](https://youtu.be/Stw0awYWzNo?t=00h43m50s)

[coming soon but the MSI is a prerec for](https://youtu.be/Stw0awYWzNo?t=00h43m52s)

[that So we're we're trying to get that](https://youtu.be/Stw0awYWzNo?t=00h43m55s)

[in first So that'll be a follow on Okay](https://youtu.be/Stw0awYWzNo?t=00h43m56s)

[Now if I go here and I go CD samples and](https://youtu.be/Stw0awYWzNo?t=00h44m01s)

[I go CD that is tiny Let's make that](https://youtu.be/Stw0awYWzNo?t=00h44m05s)

[bigger A little bigger There we go And I](https://youtu.be/Stw0awYWzNo?t=00h44m08s)

[go CD or actually what is it uh](https://youtu.be/Stw0awYWzNo?t=00h44m10s)

[cd C Avalonia right so if I do this I've](https://youtu.be/Stw0awYWzNo?t=00h44m14s)

[got inside of my dev scripts there is](https://youtu.be/Stw0awYWzNo?t=00h44m19s)

[some lovely little scripts in here being](https://youtu.be/Stw0awYWzNo?t=00h44m22s)

[able to build and I can just build and](https://youtu.be/Stw0awYWzNo?t=00h44m24s)

[launch and if I go and look I believe](https://youtu.be/Stw0awYWzNo?t=00h44m26s)

[what I](https://youtu.be/Stw0awYWzNo?t=00h44m29s)

[have make sure that that I'm not telling](https://youtu.be/Stw0awYWzNo?t=00h44m30s)

[a lie yet](https://youtu.be/Stw0awYWzNo?t=00h44m33s)

[uh let's](https://youtu.be/Stw0awYWzNo?t=00h44m35s)

[see yeah if I go and look out in my](https://youtu.be/Stw0awYWzNo?t=00h44m36s)

[program files I've installed called this](https://youtu.be/Stw0awYWzNo?t=00h44m41s)

[from an](https://youtu.be/Stw0awYWzNo?t=00h44m44s)

[MSI So uh inside](https://youtu.be/Stw0awYWzNo?t=00h44m45s)

[of](https://youtu.be/Stw0awYWzNo?t=00h44m50s)

[actually floor](https://youtu.be/Stw0awYWzNo?t=00h44m52s)

[launch right so inside of this C#](https://youtu.be/Stw0awYWzNo?t=00h44m55s)

[Avalonia sample um I've got a publish](https://youtu.be/Stw0awYWzNo?t=00h44m57s)

[directory where we've compiled the app](https://youtu.be/Stw0awYWzNo?t=00h45m00s)

[and I've got a releases directory which](https://youtu.be/Stw0awYWzNo?t=00h45m02s)

[has been built out with a a 1.0](https://youtu.be/Stw0awYWzNo?t=00h45m04s)

[uh a 1.1 update and you'll note an](https://youtu.be/Stw0awYWzNo?t=00h45m07s)

[MSI Azah right so this was built Wix all](https://youtu.be/Stw0awYWzNo?t=00h45m11s)

[the things Um there's more to do It's if](https://youtu.be/Stw0awYWzNo?t=00h45m15s)

[you go poke at the code there's not a](https://youtu.be/Stw0awYWzNo?t=00h45m19s)

[ton there yet but more to come This was](https://youtu.be/Stw0awYWzNo?t=00h45m20s)

[this was getting it working And if we](https://youtu.be/Stw0awYWzNo?t=00h45m23s)

[launch this](https://youtu.be/Stw0awYWzNo?t=00h45m25s)

[app right and we'll launch it from the](https://youtu.be/Stw0awYWzNo?t=00h45m27s)

[bootstrapper That's all that's all this](https://youtu.be/Stw0awYWzNo?t=00h45m29s)

[one is You'll note this is a this is](https://youtu.be/Stw0awYWzNo?t=00h45m31s)

[tiny compared to the actual executable](https://youtu.be/Stw0awYWzNo?t=00h45m33s)

[but its purpose in life is just to push](https://youtu.be/Stw0awYWzNo?t=00h45m35s)

[through Um for anybody who plays with](https://youtu.be/Stw0awYWzNo?t=00h45m36s)

[our portable installer that's](https://youtu.be/Stw0awYWzNo?t=00h45m38s)

[effectively what this ends up](https://youtu.be/Stw0awYWzNo?t=00h45m40s)

[being Where is](https://youtu.be/Stw0awYWzNo?t=00h45m42s)

[it did I kill it i killed it Oh did it](https://youtu.be/Stw0awYWzNo?t=00h45m45s)

[does it have a dead in there](https://youtu.be/Stw0awYWzNo?t=00h45m51s)

[no Might have to check that](https://youtu.be/Stw0awYWzNo?t=00h45m53s)

[Uh what was it called is it called C no](https://youtu.be/Stw0awYWzNo?t=00h45m58s)

[Bologonia What what what is the What is](https://youtu.be/Stw0awYWzNo?t=00h46m02s)

[the ex called inside of](https://youtu.be/Stw0awYWzNo?t=00h46m04s)

[here there's the exact](https://youtu.be/Stw0awYWzNo?t=00h46m09s)

[C# Okay If this guy launches I hope](https://youtu.be/Stw0awYWzNo?t=00h46m12s)

[he's I don't think I broke him I broke](https://youtu.be/Stw0awYWzNo?t=00h46m16s)

[him that](https://youtu.be/Stw0awYWzNo?t=00h46m19s)

[bad Maybe I did break him that bad Uh](https://youtu.be/Stw0awYWzNo?t=00h46m22s)

[let's see Application](https://youtu.be/Stw0awYWzNo?t=00h46m25s)

[Checking to see if he's silently](https://youtu.be/Stw0awYWzNo?t=00h46m30s)

[crashing That would be](https://youtu.be/Stw0awYWzNo?t=00h46m32s)

[bad Oh look He is silently crashing](https://youtu.be/Stw0awYWzNo?t=00h46m35s)

[Lovely So in case you run into this](https://youtu.be/Stw0awYWzNo?t=00h46m39s)

[situation where your app doesn't launch](https://youtu.be/Stw0awYWzNo?t=00h46m42s)

[uh Windows event viewer Windows logs](https://youtu.be/Stw0awYWzNo?t=00h46m45s)

[application is a great place to](https://youtu.be/Stw0awYWzNo?t=00h46m47s)

[look Uh Velipac update.exe apply](https://youtu.be/Stw0awYWzNo?t=00h46m49s)

[Oh because we're in the middle of an](https://youtu.be/Stw0awYWzNo?t=00h46m55s)

[update It lost its mind and got confused](https://youtu.be/Stw0awYWzNo?t=00h46m58s)

[Okay Okay Okay We're going to back We're](https://youtu.be/Stw0awYWzNo?t=00h47m01s)

[going to back this sucker out Then we're](https://youtu.be/Stw0awYWzNo?t=00h47m03s)

[going to back this sucker out So if I go](https://youtu.be/Stw0awYWzNo?t=00h47m05s)

[add remove](https://youtu.be/Stw0awYWzNo?t=00h47m08s)

[programs](https://youtu.be/Stw0awYWzNo?t=00h47m09s)

[So beauty of](https://youtu.be/Stw0awYWzNo?t=00h47m12s)

[having beauty of having](https://youtu.be/Stw0awYWzNo?t=00h47m17s)

[a SI we can go uninstall](https://youtu.be/Stw0awYWzNo?t=00h47m20s)

[Uninstall It should back it out](https://youtu.be/Stw0awYWzNo?t=00h47m23s)

[And you'll note my my](https://youtu.be/Stw0awYWzNo?t=00h47m29s)

[file file gone MSI did its job Okay And](https://youtu.be/Stw0awYWzNo?t=00h47m31s)

[then we're going to go in our dev](https://youtu.be/Stw0awYWzNo?t=00h47m36s)

[scripts here And we are going to](https://youtu.be/Stw0awYWzNo?t=00h47m37s)

[actually clear](https://youtu.be/Stw0awYWzNo?t=00h47m40s)

[out Let's clear out our releases](https://youtu.be/Stw0awYWzNo?t=00h47m43s)

[completely And we're going to start over](https://youtu.be/Stw0awYWzNo?t=00h47m46s)

[from actually delete](https://youtu.be/Stw0awYWzNo?t=00h47m49s)

[permanently Permanently please Yeah](https://youtu.be/Stw0awYWzNo?t=00h47m53s)

[Thanks Uh let's see build](https://youtu.be/Stw0awYWzNo?t=00h47m55s)

[uh](https://youtu.be/Stw0awYWzNo?t=00h48m00s)

[build.bat1.0.0 Okay So this the nice](https://youtu.be/Stw0awYWzNo?t=00h48m02s)

[part here is this will recompile like](https://youtu.be/Stw0awYWzNo?t=00h48m05s)

[the the build scripts inside of the](https://youtu.be/Stw0awYWzNo?t=00h48m08s)

[Velopac repo They will recompile the](https://youtu.be/Stw0awYWzNo?t=00h48m09s)

[Rust stuff for you they will put it all](https://youtu.be/Stw0awYWzNo?t=00h48m12s)

[together in uh and package it up and](https://youtu.be/Stw0awYWzNo?t=00h48m14s)

[then it will build the um the client](https://youtu.be/Stw0awYWzNo?t=00h48m17s)

[libraries reference them inside the uh](https://youtu.be/Stw0awYWzNo?t=00h48m21s)

[demo app and then build the demo app](https://youtu.be/Stw0awYWzNo?t=00h48m24s)

[with a VPK pack So it does kind of all](https://youtu.be/Stw0awYWzNo?t=00h48m27s)

[the things and then it also sets the the](https://youtu.be/Stw0awYWzNo?t=00h48m30s)

[update apps It's it's mildly complicated](https://youtu.be/Stw0awYWzNo?t=00h48m34s)

[only because we wanted to make our lives](https://youtu.be/Stw0awYWzNo?t=00h48m37s)

[easy But the](https://youtu.be/Stw0awYWzNo?t=00h48m39s)

[um the update location uh where is it is](https://youtu.be/Stw0awYWzNo?t=00h48m42s)

[it in here um you'll note there's this](https://youtu.be/Stw0awYWzNo?t=00h48m46s)

[sample helper get releaser So this](https://youtu.be/Stw0awYWzNo?t=00h48m48s)

[sample helper here It's looking at an](https://youtu.be/Stw0awYWzNo?t=00h48m51s)

[assembly metadata attribute that we](https://youtu.be/Stw0awYWzNo?t=00h48m53s)

[genen And again this is just kind of](https://youtu.be/Stw0awYWzNo?t=00h48m55s)

[wackiness right but that attribute is](https://youtu.be/Stw0awYWzNo?t=00h48m57s)

[being built up by looking at where this](https://youtu.be/Stw0awYWzNo?t=00h49m01s)

[project is and pointing it to the](https://youtu.be/Stw0awYWzNo?t=00h49m05s)

[releases folder was kind of a clever](https://youtu.be/Stw0awYWzNo?t=00h49m07s)

[trick right you don't need to do this in](https://youtu.be/Stw0awYWzNo?t=00h49m10s)

[your own applications This is this is](https://youtu.be/Stw0awYWzNo?t=00h49m13s)

[one of those areas where we did it](https://youtu.be/Stw0awYWzNo?t=00h49m15s)

[because we wanted to make our demo apps](https://youtu.be/Stw0awYWzNo?t=00h49m17s)

[easy to demo and show off This is not](https://youtu.be/Stw0awYWzNo?t=00h49m19s)

[likely useful for anyone else This this](https://youtu.be/Stw0awYWzNo?t=00h49m22s)

[kind of structure right so all all](https://youtu.be/Stw0awYWzNo?t=00h49m26s)

[samples break down at some level just](https://youtu.be/Stw0awYWzNo?t=00h49m30s)

[like all analogies break down So this is](https://youtu.be/Stw0awYWzNo?t=00h49m32s)

[this is where these these ones break](https://youtu.be/Stw0awYWzNo?t=00h49m36s)

[down like feel free to leverage them for](https://youtu.be/Stw0awYWzNo?t=00h49m38s)

[how do I set up pack how do I do all](https://youtu.be/Stw0awYWzNo?t=00h49m40s)

[this stuff and you can see we've got](https://youtu.be/Stw0awYWzNo?t=00h49m42s)

[quite a bit here in terms of showing it](https://youtu.be/Stw0awYWzNo?t=00h49m44s)

[off Rust node WPF Windforms Uno Unity](https://youtu.be/Stw0awYWzNo?t=00h49m48s)

[Avalonia C++ Fluent32 Widgets](https://youtu.be/Stw0awYWzNo?t=00h49m53s)

[QT and if you don't see your](https://youtu.be/Stw0awYWzNo?t=00h49m57s)

[favorite pull](https://youtu.be/Stw0awYWzNo?t=00h50m00s)

[request All I'd ask is that you try to](https://youtu.be/Stw0awYWzNo?t=00h50m05s)

[make it kind of follow our same](https://youtu.be/Stw0awYWzNo?t=00h50m07s)

[structure but it it at least gets it](https://youtu.be/Stw0awYWzNo?t=00h50m09s)

[into that vicinity because we do want to](https://youtu.be/Stw0awYWzNo?t=00h50m12s)

[have good good sample apps when people](https://youtu.be/Stw0awYWzNo?t=00h50m14s)

[go "Hey does Velopac support insert](https://youtu.be/Stw0awYWzNo?t=00h50m16s)

[language of choice here?" We would like](https://youtu.be/Stw0awYWzNo?t=00h50m18s)

[the answer to be yes of course And here](https://youtu.be/Stw0awYWzNo?t=00h50m20s)

[is a sample Right that would be that's](https://youtu.be/Stw0awYWzNo?t=00h50m23s)

[the ideal answer right](https://youtu.be/Stw0awYWzNo?t=00h50m26s)

[because I think we built the windforms](https://youtu.be/Stw0awYWzNo?t=00h50m29s)

[one](https://youtu.be/Stw0awYWzNo?t=00h50m30s)

[on I think we built that as part of one](https://youtu.be/Stw0awYWzNo?t=00h50m31s)

[of our streams before I](https://youtu.be/Stw0awYWzNo?t=00h50m34s)

[think Yeah Yeah So generally you're](https://youtu.be/Stw0awYWzNo?t=00h50m38s)

[going to replace this little line here](https://youtu.be/Stw0awYWzNo?t=00h50m41s)

[with wherever you're hosting the stuff](https://youtu.be/Stw0awYWzNo?t=00h50m44s)

[Okay Great We have a](https://youtu.be/Stw0awYWzNo?t=00h50m47s)

[new file uh built right now Great Okay](https://youtu.be/Stw0awYWzNo?t=00h50m50s)

[Now we're going to](https://youtu.be/Stw0awYWzNo?t=00h50m57s)

[launch Should run the](https://youtu.be/Stw0awYWzNo?t=00h50m58s)

[MSI Okay And we don't have it launching](https://youtu.be/Stw0awYWzNo?t=00h51m01s)

[the app There there's there's a lot of](https://youtu.be/Stw0awYWzNo?t=00h51m05s)

[things I want to add to this MSI It's](https://youtu.be/Stw0awYWzNo?t=00h51m06s)

[not doing a lot yet Like there's no](https://youtu.be/Stw0awYWzNo?t=00h51m08s)

[shortcuts none of that stuff Okay Now](https://youtu.be/Stw0awYWzNo?t=00h51m09s)

[we're going to launch In theory the app](https://youtu.be/Stw0awYWzNo?t=00h51m11s)

[should fire up Not do anything crazy](https://youtu.be/Stw0awYWzNo?t=00h51m14s)

[on But in case it](https://youtu.be/Stw0awYWzNo?t=00h51m21s)

[does no I'm not seeing it So that's](https://youtu.be/Stw0awYWzNo?t=00h51m23s)

[that's not uh not a good](https://youtu.be/Stw0awYWzNo?t=00h51m26s)

[sign](https://youtu.be/Stw0awYWzNo?t=00h51m39s)

[update So it's hitting main Velopac app](https://youtu.be/Stw0awYWzNo?t=00h51m43s)

[run update.exe](https://youtu.be/Stw0awYWzNo?t=00h51m47s)

[apply Why did I'm confused okay I'm](https://youtu.be/Stw0awYWzNo?t=00h51m52s)

[confused as](https://youtu.be/Stw0awYWzNo?t=00h51m56s)

[to what I changed that got me into this](https://youtu.be/Stw0awYWzNo?t=00h51m57s)

[situation Uh do I have two copies of it](https://youtu.be/Stw0awYWzNo?t=00h52m01s)

[running looks like I do Okay So](https://youtu.be/Stw0awYWzNo?t=00h52m04s)

[let's get this guy open first of all and](https://youtu.be/Stw0awYWzNo?t=00h52m08s)

[then let's](https://youtu.be/Stw0awYWzNo?t=00h52m11s)

[go see because the update exe](https://youtu.be/Stw0awYWzNo?t=00h52m12s)

[apply is like right here So I'm I'm](https://youtu.be/Stw0awYWzNo?t=00h52m16s)

[curious](https://youtu.be/Stw0awYWzNo?t=00h52m20s)

[why the demo app is attempting to fire](https://youtu.be/Stw0awYWzNo?t=00h52m21s)

[that immediately Like I I know why it's](https://youtu.be/Stw0awYWzNo?t=00h52m25s)

[failing It's because it's in a protected](https://youtu.be/Stw0awYWzNo?t=00h52m28s)

[directory and I haven't handled that yet](https://youtu.be/Stw0awYWzNo?t=00h52m29s)

[I'm just curious as to why it thinks it](https://youtu.be/Stw0awYWzNo?t=00h52m32s)

[needs to call it right now Because if we](https://youtu.be/Stw0awYWzNo?t=00h52m34s)

[look here in the C# Avalonia one right](https://youtu.be/Stw0awYWzNo?t=00h52m38s)

[so we're coming in here We're getting](https://youtu.be/Stw0awYWzNo?t=00h52m41s)

[inpac buildac run right like if we look](https://youtu.be/Stw0awYWzNo?t=00h52m43s)

[at our stack trace from the event viewer](https://youtu.be/Stw0awYWzNo?t=00h52m45s)

[we can see we're in main Then we call](https://youtu.be/Stw0awYWzNo?t=00h52m48s)

[vellopac app run That's calling](https://youtu.be/Stw0awYWzNo?t=00h52m50s)

[update.exe apply right so down somewhere](https://youtu.be/Stw0awYWzNo?t=00h52m53s)

[in here we should see update exe apply](https://youtu.be/Stw0awYWzNo?t=00h52m57s)

[being](https://youtu.be/Stw0awYWzNo?t=00h53m00s)

[invoked Uh and there is a local update](https://youtu.be/Stw0awYWzNo?t=00h53m04s)

[We should install it first So this guy](https://youtu.be/Stw0awYWzNo?t=00h53m08s)

[here is coming](https://youtu.be/Stw0awYWzNo?t=00h53m13s)

[in](https://youtu.be/Stw0awYWzNo?t=00h53m21s)

[Uh oh yeah this should really be a try](https://youtu.be/Stw0awYWzNo?t=00h53m27s)

[try](https://youtu.be/Stw0awYWzNo?t=00h53m29s)

[get It's not a big deal because it's not](https://youtu.be/Stw0awYWzNo?t=00h53m30s)

[like the dictionary is going to be](https://youtu.be/Stw0awYWzNo?t=00h53m33s)

[changing](https://youtu.be/Stw0awYWzNo?t=00h53m34s)

[but a try get would save on duplicate](https://youtu.be/Stw0awYWzNo?t=00h53m37s)

[lookups So in order to get to this line](https://youtu.be/Stw0awYWzNo?t=00h53m39s)

[here we would have to be falling into](https://youtu.be/Stw0awYWzNo?t=00h53m44s)

[that Is there any other](https://youtu.be/Stw0awYWzNo?t=00h53m46s)

[calls no What are you complaining](https://youtu.be/Stw0awYWzNo?t=00h53m49s)

[about exit can be marked as static Okay](https://youtu.be/Stw0awYWzNo?t=00h53m55s)

[we'll make you static then](https://youtu.be/Stw0awYWzNo?t=00h53m58s)

[Um so we're we have to be hitting](https://youtu.be/Stw0awYWzNo?t=00h54m05s)

[here latest](https://youtu.be/Stw0awYWzNo?t=00h54m12s)

[local get latest local full](https://youtu.be/Stw0awYWzNo?t=00h54m17s)

[package](https://youtu.be/Stw0awYWzNo?t=00h54m20s)

[Oh I think I know what I did](https://youtu.be/Stw0awYWzNo?t=00h54m24s)

[Uh get local](https://youtu.be/Stw0awYWzNo?t=00h54m29s)

[packages](https://youtu.be/Stw0awYWzNo?t=00h54m36s)

[Yeah because this is looking for the](https://youtu.be/Stw0awYWzNo?t=00h54m38s)

[packages directory](https://youtu.be/Stw0awYWzNo?t=00h54m41s)

[Oh got myself in the foot Got myself in](https://youtu.be/Stw0awYWzNo?t=00h54m44s)

[the foot So this is one of those things](https://youtu.be/Stw0awYWzNo?t=00h54m47s)

[that's going to take some thinking So](https://youtu.be/Stw0awYWzNo?t=00h54m50s)

[here's the game plan right](https://youtu.be/Stw0awYWzNo?t=00h54m52s)

[you're installed in a protected](https://youtu.be/Stw0awYWzNo?t=00h54m54s)

[directory like program](https://youtu.be/Stw0awYWzNo?t=00h54m56s)

[files You detect that there is an update](https://youtu.be/Stw0awYWzNo?t=00h54m58s)

[available and you wish to download and](https://youtu.be/Stw0awYWzNo?t=00h55m00s)

[apply](https://youtu.be/Stw0awYWzNo?t=00h55m02s)

[it Previously what would happen is](https://youtu.be/Stw0awYWzNo?t=00h55m03s)

[Velopac would download that package in a](https://youtu.be/Stw0awYWzNo?t=00h55m06s)

[directory alongside your apps directory](https://youtu.be/Stw0awYWzNo?t=00h55m08s)

[called packages right is normally you](https://youtu.be/Stw0awYWzNo?t=00h55m11s)

[have normally what would happen is you'd](https://youtu.be/Stw0awYWzNo?t=00h55m15s)

[have this app here There's current and](https://youtu.be/Stw0awYWzNo?t=00h55m17s)

[then there'd often be a uh if we do new](https://youtu.be/Stw0awYWzNo?t=00h55m19s)

[folder right yeah I get it Packages](https://youtu.be/Stw0awYWzNo?t=00h55m22s)

[Normally it would download inside of](https://youtu.be/Stw0awYWzNo?t=00h55m26s)

[that directory The problem is you saw](https://youtu.be/Stw0awYWzNo?t=00h55m28s)

[that UAC prompt come through You](https://youtu.be/Stw0awYWzNo?t=00h55m30s)

[can't right you you can't like your](https://youtu.be/Stw0awYWzNo?t=00h55m33s)

[running app isn't going to have](https://youtu.be/Stw0awYWzNo?t=00h55m36s)

[permission to write to this folder Now](https://youtu.be/Stw0awYWzNo?t=00h55m38s)

[your app may set a manifest or something](https://youtu.be/Stw0awYWzNo?t=00h55m40s)

[that says "Oh I always have to run with](https://youtu.be/Stw0awYWzNo?t=00h55m42s)

[elevation or yada yada yada." Right that](https://youtu.be/Stw0awYWzNo?t=00h55m44s)

[would be fine right but we don't want to](https://youtu.be/Stw0awYWzNo?t=00h55m46s)

[put a requirement on people that in](https://youtu.be/Stw0awYWzNo?t=00h55m48s)

[order to use Velopax updater you have to](https://youtu.be/Stw0awYWzNo?t=00h55m50s)

[be running as admin That's dumb Right](https://youtu.be/Stw0awYWzNo?t=00h55m52s)

[now we are going to prompt the user for](https://youtu.be/Stw0awYWzNo?t=00h55m55s)

[UAC access to apply the update because](https://youtu.be/Stw0awYWzNo?t=00h55m57s)

[we we're trying to write into your](https://youtu.be/Stw0awYWzNo?t=00h56m00s)

[program files We're going to need access](https://youtu.be/Stw0awYWzNo?t=00h56m01s)

[at that point Like that's that's kind of](https://youtu.be/Stw0awYWzNo?t=00h56m03s)

[a given right you you run for most](https://youtu.be/Stw0awYWzNo?t=00h56m05s)

[installers like you get prompted with](https://youtu.be/Stw0awYWzNo?t=00h56m08s)

[UAC prompts when they're writing into](https://youtu.be/Stw0awYWzNo?t=00h56m10s)

[the protected directories right fine](https://youtu.be/Stw0awYWzNo?t=00h56m12s)

[The the reason this one's biting](https://youtu.be/Stw0awYWzNo?t=00h56m16s)

[me is because I did a little bit](https://youtu.be/Stw0awYWzNo?t=00h56m18s)

[of little bit of](https://youtu.be/Stw0awYWzNo?t=00h56m22s)

[work going to burn this to the ground](https://youtu.be/Stw0awYWzNo?t=00h56m25s)

[Hopefully there's nothing important](https://youtu.be/Stw0awYWzNo?t=00h56m27s)

[being written in my temp directory right](https://youtu.be/Stw0awYWzNo?t=00h56m28s)

[now So inside of my Windows Velopac](https://youtu.be/Stw0awYWzNo?t=00h56m30s)

[locator which is why I was noticing](https://youtu.be/Stw0awYWzNo?t=00h56m34s)

[this package is durr was the the key](https://youtu.be/Stw0awYWzNo?t=00h56m37s)

[thing I was hunting for is uh Windows](https://youtu.be/Stw0awYWzNo?t=00h56m40s)

[locator right so I did this thing down](https://youtu.be/Stw0awYWzNo?t=00h56m45s)

[here with this get packages dur And](https://youtu.be/Stw0awYWzNo?t=00h56m49s)

[specifically what I did is I said "Oh](https://youtu.be/Stw0awYWzNo?t=00h56m53s)

[well let's try to access the regular one](https://youtu.be/Stw0awYWzNo?t=00h56m56s)

[and if that throws an exception let's](https://youtu.be/Stw0awYWzNo?t=00h56m58s)

[try to go out to the temp directory and](https://youtu.be/Stw0awYWzNo?t=00h57m00s)

[let's try to look there instead." Right](https://youtu.be/Stw0awYWzNo?t=00h57m03s)

[that was the game](https://youtu.be/Stw0awYWzNo?t=00h57m06s)

[plan because since we aren't going to](https://youtu.be/Stw0awYWzNo?t=00h57m07s)

[have right access we need to go](https://youtu.be/Stw0awYWzNo?t=00h57m10s)

[somewhere where we will And the temp](https://youtu.be/Stw0awYWzNo?t=00h57m12s)

[directory is pretty safe That's where](https://youtu.be/Stw0awYWzNo?t=00h57m14s)

[the temp needs to go There may be some](https://youtu.be/Stw0awYWzNo?t=00h57m16s)

[arguments that it shouldn't be temp and](https://youtu.be/Stw0awYWzNo?t=00h57m18s)

[it should be app data or similar that](https://youtu.be/Stw0awYWzNo?t=00h57m20s)

[that is up for discussion Um but in the](https://youtu.be/Stw0awYWzNo?t=00h57m22s)

[interest of getting uh something working](https://youtu.be/Stw0awYWzNo?t=00h57m27s)

[and out the door first we're starting](https://youtu.be/Stw0awYWzNo?t=00h57m29s)

[here right if if you know of reasons and](https://youtu.be/Stw0awYWzNo?t=00h57m32s)

[want to advocate for one or the other](https://youtu.be/Stw0awYWzNo?t=00h57m35s)

[hit me up on Discord Um there's the the](https://youtu.be/Stw0awYWzNo?t=00h57m37s)

[Velop pack has a nice Discord channel](https://youtu.be/Stw0awYWzNo?t=00h57m40s)

[with quite a bit of activity in it feel](https://youtu.be/Stw0awYWzNo?t=00h57m42s)

[free to open an issue and we can](https://youtu.be/Stw0awYWzNo?t=00h57m44s)

[discuss So the the issue being that I](https://youtu.be/Stw0awYWzNo?t=00h57m47s)

[had run this previously and there](https://youtu.be/Stw0awYWzNo?t=00h57m51s)

[were I I think I just torched it now](https://youtu.be/Stw0awYWzNo?t=00h57m55s)

[there um there was an update sitting in](https://youtu.be/Stw0awYWzNo?t=00h57m58s)

[this temp directory that I had pre](https://youtu.be/Stw0awYWzNo?t=00h58m02s)

[downloaded and it was at 101](https://youtu.be/Stw0awYWzNo?t=00h58m04s)

[Now when I](https://youtu.be/Stw0awYWzNo?t=00h58m08s)

[launch actually should probably get rid](https://youtu.be/Stw0awYWzNo?t=00h58m12s)

[of this](https://youtu.be/Stw0awYWzNo?t=00h58m14s)

[uh because we're going to need to change](https://youtu.be/Stw0awYWzNo?t=00h58m16s)

[this check There we go This is what](https://youtu.be/Stw0awYWzNo?t=00h58m17s)

[we're looking for right we get So our](https://youtu.be/Stw0awYWzNo?t=00h58m19s)

[our sample app is not overly pretty but](https://youtu.be/Stw0awYWzNo?t=00h58m22s)

[it's designed to show off the update](https://youtu.be/Stw0awYWzNo?t=00h58m24s)

[process right so there's separate](https://youtu.be/Stw0awYWzNo?t=00h58m26s)

[buttons These correspond to different](https://youtu.be/Stw0awYWzNo?t=00h58m28s)

[methods on the update manager in your](https://youtu.be/Stw0awYWzNo?t=00h58m30s)

[app You get to choose when those methods](https://youtu.be/Stw0awYWzNo?t=00h58m32s)

[are invoked right that's you get to](https://youtu.be/Stw0awYWzNo?t=00h58m34s)

[decide what what makes most sense for](https://youtu.be/Stw0awYWzNo?t=00h58m37s)

[you But this is the this is the part](https://youtu.be/Stw0awYWzNo?t=00h58m39s)

[that we want to solve here right](https://youtu.be/Stw0awYWzNo?t=00h58m41s)

[um so these sort of permissions level](https://youtu.be/Stw0awYWzNo?t=00h58m45s)

[problems are what we are what we are](https://youtu.be/Stw0awYWzNo?t=00h58m49s)

[looking to do right because this is](https://youtu.be/Stw0awYWzNo?t=00h58m52s)

[writing into the the wrong directory now](https://youtu.be/Stw0awYWzNo?t=00h58m55s)

[Um and so if I kill this and relaunch](https://youtu.be/Stw0awYWzNo?t=00h58m59s)

[because I think it saw that packages](https://youtu.be/Stw0awYWzNo?t=00h59m03s)

[directory sitting there and I don't like](https://youtu.be/Stw0awYWzNo?t=00h59m05s)

[that right i want to change the check so](https://youtu.be/Stw0awYWzNo?t=00h59m06s)

[it looks for if it's](https://youtu.be/Stw0awYWzNo?t=00h59m09s)

[writable Right so you'll see here it](https://youtu.be/Stw0awYWzNo?t=00h59m12s)

[immediately flipped and it's now going](https://youtu.be/Stw0awYWzNo?t=00h59m14s)

[out to the um like it's it's subtle but](https://youtu.be/Stw0awYWzNo?t=00h59m16s)

[it's it's now changed its path to uh app](https://youtu.be/Stw0awYWzNo?t=00h59m20s)

[data local temp which is the default](https://youtu.be/Stw0awYWzNo?t=00h59m24s)

[temp directory on Windows right right to](https://youtu.be/Stw0awYWzNo?t=00h59m26s)

[reach across and do this And again it's](https://youtu.be/Stw0awYWzNo?t=00h59m28s)

[worth remembering this is kind of](https://youtu.be/Stw0awYWzNo?t=00h59m29s)

[Windows](https://youtu.be/Stw0awYWzNo?t=00h59m31s)

[specific right like yes you can get](https://youtu.be/Stw0awYWzNo?t=00h59m32s)

[yourself into this situation on other](https://youtu.be/Stw0awYWzNo?t=00h59m36s)

[platforms It's a little less common](https://youtu.be/Stw0awYWzNo?t=00h59m37s)

[right windows has made it very common](https://youtu.be/Stw0awYWzNo?t=00h59m40s)

[So and generate a new staging ID and](https://youtu.be/Stw0awYWzNo?t=00h59m43s)

[it's done all of the details So what I](https://youtu.be/Stw0awYWzNo?t=00h59m46s)

[would like to do first is instead of](https://youtu.be/Stw0awYWzNo?t=00h59m48s)

[this check here of all of this stuff is](https://youtu.be/Stw0awYWzNo?t=00h59m51s)

[we have a function](https://youtu.be/Stw0awYWzNo?t=00h59m55s)

[in our Rust code that checks if a thing](https://youtu.be/Stw0awYWzNo?t=00h59m58s)

[is writable And I](https://youtu.be/Stw0awYWzNo?t=01h00m01s)

[think I added one in here](https://youtu.be/Stw0awYWzNo?t=01h00m05s)

[too Did I add it is directory writable](https://youtu.be/Stw0awYWzNo?t=01h00m09s)

[yeah So this is the check I actually](https://youtu.be/Stw0awYWzNo?t=01h00m12s)

[want to make is I would like to do this](https://youtu.be/Stw0awYWzNo?t=01h00m15s)

[So this is actually a clever trick for](https://youtu.be/Stw0awYWzNo?t=01h00m19s)

[anyone who hasn't seen it Um in Windows](https://youtu.be/Stw0awYWzNo?t=01h00m21s)

[when you open a file stream you can have](https://youtu.be/Stw0awYWzNo?t=01h00m24s)

[this delete on close So you can open the](https://youtu.be/Stw0awYWzNo?t=01h00m26s)

[file stream use it as a file read right](https://youtu.be/Stw0awYWzNo?t=01h00m29s)

[in and out of it blah blah blah blah](https://youtu.be/Stw0awYWzNo?t=01h00m31s)

[blah but then it deletes when you close](https://youtu.be/Stw0awYWzNo?t=01h00m33s)

[that file stream So it's very convenient](https://youtu.be/Stw0awYWzNo?t=01h00m35s)

[for kind of having like a a temp scratch](https://youtu.be/Stw0awYWzNo?t=01h00m37s)

[area type thing And so in this case all](https://youtu.be/Stw0awYWzNo?t=01h00m39s)

[we're doing is we're just saying hey can](https://youtu.be/Stw0awYWzNo?t=01h00m42s)

[I write into this](https://youtu.be/Stw0awYWzNo?t=01h00m44s)

[directory like and that's all there is](https://youtu.be/Stw0awYWzNo?t=01h00m46s)

[And the names here are very much](https://youtu.be/Stw0awYWzNo?t=01h00m48s)

[indicative of what we had done because](https://youtu.be/Stw0awYWzNo?t=01h00m50s)

[we wrote this method originally in Rust](https://youtu.be/Stw0awYWzNo?t=01h00m53s)

[because we needed it inside of the setup](https://youtu.be/Stw0awYWzNo?t=01h00m55s)

[stuff But I I now want it in the client](https://youtu.be/Stw0awYWzNo?t=01h00m56s)

[app So I think rather than doing this I](https://youtu.be/Stw0awYWzNo?t=01h00m58s)

[think what we want to do is because root](https://youtu.be/Stw0awYWzNo?t=01h01m03s)

[a is going to](https://youtu.be/Stw0awYWzNo?t=01h01m05s)

[be this is going to be C windows app](https://youtu.be/Stw0awYWzNo?t=01h01m09s)

[thing So I think what I want to do is if](https://youtu.be/Stw0awYWzNo?t=01h01m12s)

[uh what is it path you let's see path](https://youtu.be/Stw0awYWzNo?t=01h01m16s)

[util because I'm talking about program](https://youtu.be/Stw0awYWzNo?t=01h01m23s)

[files but it's it's technically](https://youtu.be/Stw0awYWzNo?t=01h01m25s)

[plausible depending on what level of](https://youtu.be/Stw0awYWzNo?t=01h01m28s)

[customization we allow but because it's](https://youtu.be/Stw0awYWzNo?t=01h01m30s)

[an MSI somebody could always overwrite](https://youtu.be/Stw0awYWzNo?t=01h01m32s)

[it like it's possible somebody puts a it](https://youtu.be/Stw0awYWzNo?t=01h01m33s)

[in a different directory that's also not](https://youtu.be/Stw0awYWzNo?t=01h01m36s)

[writable so we just kind of want to](https://youtu.be/Stw0awYWzNo?t=01h01m37s)

[be happier with that](https://youtu.be/Stw0awYWzNo?t=01h01m40s)

[Um let's](https://youtu.be/Stw0awYWzNo?t=01h01m43s)

[see And I think what I what I actually](https://youtu.be/Stw0awYWzNo?t=01h01m46s)

[want to do is something along the lines](https://youtu.be/Stw0awYWzNo?t=01h01m50s)

[of](https://youtu.be/Stw0awYWzNo?t=01h01m52s)

[uh string get](https://youtu.be/Stw0awYWzNo?t=01h01m54s)

[uh](https://youtu.be/Stw0awYWzNo?t=01h01m58s)

[writable](https://youtu.be/Stw0awYWzNo?t=01h01m59s)

[directory And then I think what I want](https://youtu.be/Stw0awYWzNo?t=01h02m02s)

[to](https://youtu.be/Stw0awYWzNo?t=01h02m05s)

[do Yeah something You're getting close](https://youtu.be/Stw0awYWzNo?t=01h02m07s)

[Go pilot path util](https://youtu.be/Stw0awYWzNo?t=01h02m10s)

[um I innumerable](https://youtu.be/Stw0awYWzNo?t=01h02m16s)

[uh](https://youtu.be/Stw0awYWzNo?t=01h02m20s)

[string possible locations right so I](https://youtu.be/Stw0awYWzNo?t=01h02m23s)

[just want to do this and so I think what](https://youtu.be/Stw0awYWzNo?t=01h02m26s)

[I want to do here is then](https://youtu.be/Stw0awYWzNo?t=01h02m28s)

[uh return possible locations first or](https://youtu.be/Stw0awYWzNo?t=01h02m30s)

[default path is directory writable](https://youtu.be/Stw0awYWzNo?t=01h02m35s)

[I think this works I'm kind of wondering](https://youtu.be/Stw0awYWzNo?t=01h02m40s)

[if if I've if adding this local function](https://youtu.be/Stw0awYWzNo?t=01h02m42s)

[might be](https://youtu.be/Stw0awYWzNo?t=01h02m44s)

[overkill Maybe we don't do this Maybe](https://youtu.be/Stw0awYWzNo?t=01h02m48s)

[let's let's actually do a little more uh](https://youtu.be/Stw0awYWzNo?t=01h02m51s)

[string uh](https://youtu.be/Stw0awYWzNo?t=01h02m54s)

[possible](https://youtu.be/Stw0awYWzNo?t=01h02m57s)

[directories gets we're going to do root](https://youtu.be/Stw0awYWzNo?t=01h02m59s)

[a uh path get temp path I actually kind](https://youtu.be/Stw0awYWzNo?t=01h03m03s)

[of want to](https://youtu.be/Stw0awYWzNo?t=01h03m08s)

[do](https://youtu.be/Stw0awYWzNo?t=01h03m11s)

[this Uh let's see](https://youtu.be/Stw0awYWzNo?t=01h03m15s)

[here And](https://youtu.be/Stw0awYWzNo?t=01h03m23s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=01h03m27s)

[then Oh](https://youtu.be/Stw0awYWzNo?t=01h03m34s)

[Uh what](https://youtu.be/Stw0awYWzNo?t=01h03m43s)

[is I an idiot](https://youtu.be/Stw0awYWzNo?t=01h03m51s)

[why a little curious why this is failing](https://youtu.be/Stw0awYWzNo?t=01h03m54s)

[string](https://youtu.be/Stw0awYWzNo?t=01h03m58s)

[nullable Oh you want a nullable](https://youtu.be/Stw0awYWzNo?t=01h04m00s)

[string what's up Dlux how we](https://youtu.be/Stw0awYWzNo?t=01h04m04s)

[doing we are hopefully getting full MSI](https://youtu.be/Stw0awYWzNo?t=01h04m09s)

[support At least that's what I've been](https://youtu.be/Stw0awYWzNo?t=01h04m15s)

[spending my nights on What is your](https://youtu.be/Stw0awYWzNo?t=01h04m17s)

[problem](https://youtu.be/Stw0awYWzNo?t=01h04m22s)

[oh I don't have C 12 in here yet](https://youtu.be/Stw0awYWzNo?t=01h04m23s)

[Ah curse you](https://youtu.be/Stw0awYWzNo?t=01h04m27s)

[old Um](https://youtu.be/Stw0awYWzNo?t=01h04m33s)

[uh](https://youtu.be/Stw0awYWzNo?t=01h04m43s)

[we'll do we'll just do this Ding ding](https://youtu.be/Stw0awYWzNo?t=01h04m47s)

[ding ding ding ding There Uh Oh that](https://youtu.be/Stw0awYWzNo?t=01h04m50s)

[can't be static because it needs to](https://youtu.be/Stw0awYWzNo?t=01h04m53s)

[access this Okay there we go Okay so we](https://youtu.be/Stw0awYWzNo?t=01h04m54s)

[got that We got that And then we're](https://youtu.be/Stw0awYWzNo?t=01h04m56s)

[going to go with](https://youtu.be/Stw0awYWzNo?t=01h04m59s)

[um possible](https://youtu.be/Stw0awYWzNo?t=01h05m03s)

[directories where xx xn](https://youtu.be/Stw0awYWzNo?t=01h05m08s)

[null then you are unhappy because](https://youtu.be/Stw0awYWzNo?t=01h05m14s)

[uh let's see it wants a](https://youtu.be/Stw0awYWzNo?t=01h05m20s)

[string](https://youtu.be/Stw0awYWzNo?t=01h05m23s)

[and oh let's](https://youtu.be/Stw0awYWzNo?t=01h05m25s)

[I don't think this this function is not](https://youtu.be/Stw0awYWzNo?t=01h05m27s)

[providing me a lot of value anymore So](https://youtu.be/Stw0awYWzNo?t=01h05m30s)

[um](https://youtu.be/Stw0awYWzNo?t=01h05m37s)

[spring writable root get](https://youtu.be/Stw0awYWzNo?t=01h05m39s)

[springing something like that And then I](https://youtu.be/Stw0awYWzNo?t=01h05m43s)

[think what we're going to do is we're](https://youtu.be/Stw0awYWzNo?t=01h05m47s)

[just going to do this because I need to](https://youtu.be/Stw0awYWzNo?t=01h05m48s)

[be able to tell the compiler to shut up](https://youtu.be/Stw0awYWzNo?t=01h05m50s)

[because I know that X is non-null at](https://youtu.be/Stw0awYWzNo?t=01h05m53s)

[that point](https://youtu.be/Stw0awYWzNo?t=01h05m55s)

[because you know that](https://youtu.be/Stw0awYWzNo?t=01h05m57s)

[um but unfortunately the compiler can't](https://youtu.be/Stw0awYWzNo?t=01h06m00s)

[make that inference but you know what](https://youtu.be/Stw0awYWzNo?t=01h06m02s)

[I'm the developer here not](https://youtu.be/Stw0awYWzNo?t=01h06m04s)

[it okay so writable routt and then what](https://youtu.be/Stw0awYWzNo?t=01h06m06s)

[we're going to do is we're going to just](https://youtu.be/Stw0awYWzNo?t=01h06m09s)

[do there is a question should we create](https://youtu.be/Stw0awYWzNo?t=01h06m12s)

[if not](https://youtu.be/Stw0awYWzNo?t=01h06m16s)

[ex think we should](https://youtu.be/Stw0awYWzNo?t=01h06m20s)

[I think we we absolutely should](https://youtu.be/Stw0awYWzNo?t=01h06m27s)

[um is](https://youtu.be/Stw0awYWzNo?t=01h06m34s)

[writable path because I think what I](https://youtu.be/Stw0awYWzNo?t=01h06m39s)

[want to do is if uh directory](https://youtu.be/Stw0awYWzNo?t=01h06m43s)

[exists directory](https://youtu.be/Stw0awYWzNo?t=01h06m47s)

[path I think I want to wrap this sucker](https://youtu.be/Stw0awYWzNo?t=01h06m50s)

[up in a try catch because at the end of](https://youtu.be/Stw0awYWzNo?t=01h06m53s)

[the day I don't care about](https://youtu.be/Stw0awYWzNo?t=01h06m55s)

[errors um I really](https://youtu.be/Stw0awYWzNo?t=01h06m58s)

[don't Uh and I have got mismatched curly](https://youtu.be/Stw0awYWzNo?t=01h07m02s)

[braces all over the](https://youtu.be/Stw0awYWzNo?t=01h07m05s)

[place Yeah Yeah co-pilot thanks But you](https://youtu.be/Stw0awYWzNo?t=01h07m07s)

[naked other ones Okay And](https://youtu.be/Stw0awYWzNo?t=01h07m10s)

[then true So if we get all the way down](https://youtu.be/Stw0awYWzNo?t=01h07m15s)

[to here we're we're](https://youtu.be/Stw0awYWzNo?t=01h07m17s)

[good](https://youtu.be/Stw0awYWzNo?t=01h07m19s)

[Um I think what we want to do is](https://youtu.be/Stw0awYWzNo?t=01h07m22s)

[this Fine](https://youtu.be/Stw0awYWzNo?t=01h07m27s)

[And actually we could because we're](https://youtu.be/Stw0awYWzNo?t=01h07m30s)

[doing this as a function we can just](https://youtu.be/Stw0awYWzNo?t=01h07m32s)

[drop this drop this drop this we'll just](https://youtu.be/Stw0awYWzNo?t=01h07m34s)

[make this guy nullable Uh if directory](https://youtu.be/Stw0awYWzNo?t=01h07m37s)

[path is null return false right easy](https://youtu.be/Stw0awYWzNo?t=01h07m40s)

[done](https://youtu.be/Stw0awYWzNo?t=01h07m45s)

[Um so if it doesn't exist we are going](https://youtu.be/Stw0awYWzNo?t=01h07m46s)

[to directory create](https://youtu.be/Stw0awYWzNo?t=01h07m48s)

[it and then we will return uh](https://youtu.be/Stw0awYWzNo?t=01h07m53s)

[path uh util is directory](https://youtu.be/Stw0awYWzNo?t=01h07m58s)

[writable And this should all work like](https://youtu.be/Stw0awYWzNo?t=01h08m05s)

[and we should really never get into a](https://youtu.be/Stw0awYWzNo?t=01h08m08s)

[situation where root root app directory](https://youtu.be/Stw0awYWzNo?t=01h08m10s)

[doesn't exist But we could then add in](https://youtu.be/Stw0awYWzNo?t=01h08m12s)

[other possibilities down here later](https://youtu.be/Stw0awYWzNo?t=01h08m14s)

[Right so assuming we find one](https://youtu.be/Stw0awYWzNo?t=01h08m17s)

[um](https://youtu.be/Stw0awYWzNo?t=01h08m23s)

[if uh writable root der is null unable](https://youtu.be/Stw0awYWzNo?t=01h08m24s)

[to find writable root](https://youtu.be/Stw0awYWzNo?t=01h08m28s)

[directory](https://youtu.be/Stw0awYWzNo?t=01h08m32s)

[package That seems like a good warning](https://youtu.be/Stw0awYWzNo?t=01h08m34s)

[to](https://youtu.be/Stw0awYWzNo?t=01h08m37s)

[return Um we've done the create if not](https://youtu.be/Stw0awYWzNo?t=01h08m38s)

[exist](https://youtu.be/Stw0awYWzNo?t=01h08m42s)

[thing Uh well we've only done it on the](https://youtu.be/Stw0awYWzNo?t=01h08m49s)

[root So we actually want to do](https://youtu.be/Stw0awYWzNo?t=01h08m52s)

[this So we we want to do this](https://youtu.be/Stw0awYWzNo?t=01h08m56s)

[here And we want this to be writable](https://youtu.be/Stw0awYWzNo?t=01h09m00s)

[router Okay](https://youtu.be/Stw0awYWzNo?t=01h09m04s)

[And then I think I want to go with I](https://youtu.be/Stw0awYWzNo?t=01h09m10s)

[think I have a logger here don't I log](https://youtu.be/Stw0awYWzNo?t=01h09m12s)

[And I think I just want this to be trace](https://youtu.be/Stw0awYWzNo?t=01h09m15s)

[uh using writable root directory Boom](https://youtu.be/Stw0awYWzNo?t=01h09m18s)

[There That way we've get get good output](https://youtu.be/Stw0awYWzNo?t=01h09m22s)

[there This gets us the packages](https://youtu.be/Stw0awYWzNo?t=01h09m26s)

[directory We may need to move this out](https://youtu.be/Stw0awYWzNo?t=01h09m28s)

[into other areas But this will at least](https://youtu.be/Stw0awYWzNo?t=01h09m31s)

[get](https://youtu.be/Stw0awYWzNo?t=01h09m34s)

[us a good chunk of the way there because](https://youtu.be/Stw0awYWzNo?t=01h09m34s)

[this will also fix the other problem](https://youtu.be/Stw0awYWzNo?t=01h09m37s)

[where I created the packages directory](https://youtu.be/Stw0awYWzNo?t=01h09m38s)

[in program files because creating a](https://youtu.be/Stw0awYWzNo?t=01h09m40s)

[directory shouldn't magically make this](https://youtu.be/Stw0awYWzNo?t=01h09m42s)

[code fail because it'll get past the](https://youtu.be/Stw0awYWzNo?t=01h09m44s)

[exist but then it'll fail on](https://youtu.be/Stw0awYWzNo?t=01h09m46s)

[this Okay so that makes me feel better](https://youtu.be/Stw0awYWzNo?t=01h09m49s)

[there next problem that we have Right so](https://youtu.be/Stw0awYWzNo?t=01h09m53s)

[this technically all worked Um and if we](https://youtu.be/Stw0awYWzNo?t=01h09m56s)

[build and launch um actually let's let's](https://youtu.be/Stw0awYWzNo?t=01h09m59s)

[run a build So we have we have one more](https://youtu.be/Stw0awYWzNo?t=01h10m02s)

[out there right so I'm going to build](https://youtu.be/Stw0awYWzNo?t=01h10m05s)

[version](https://youtu.be/Stw0awYWzNo?t=01h10m06s)

[101 Will conveniently](https://youtu.be/Stw0awYWzNo?t=01h10m09s)

[contain the updated client with the](https://youtu.be/Stw0awYWzNo?t=01h10m12s)

[changes we just made to it 1.0 does not](https://youtu.be/Stw0awYWzNo?t=01h10m14s)

[have those client changes so it's still](https://youtu.be/Stw0awYWzNo?t=01h10m17s)

[going to be an idiot but that's okay Um](https://youtu.be/Stw0awYWzNo?t=01h10m19s)

[the next area that's going to be biting](https://youtu.be/Stw0awYWzNo?t=01h10m22s)

[us is going to be](https://youtu.be/Stw0awYWzNo?t=01h10m25s)

[the update manager](https://youtu.be/Stw0awYWzNo?t=01h10m29s)

[download Where did update manager](https://youtu.be/Stw0awYWzNo?t=01h10m35s)

[download go i thought I had it open Did](https://youtu.be/Stw0awYWzNo?t=01h10m37s)

[I uh let's see Don't need](https://youtu.be/Stw0awYWzNo?t=01h10m41s)

[you Don't need](https://youtu.be/Stw0awYWzNo?t=01h10m45s)

[you Must have closed it](https://youtu.be/Stw0awYWzNo?t=01h10m47s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=01h10m52s)

[Oh up the](https://youtu.be/Stw0awYWzNo?t=01h10m57s)

[using or in here And then let's go to](https://youtu.be/Stw0awYWzNo?t=01h11m00s)

[the other half of the partial there So](https://youtu.be/Stw0awYWzNo?t=01h11m02s)

[this guy here has a download something](https://youtu.be/Stw0awYWzNo?t=01h11m05s)

[Yeah this thing right download updates](https://youtu.be/Stw0awYWzNo?t=01h11m08s)

[So this guy here has a download update](https://youtu.be/Stw0awYWzNo?t=01h11m13s)

[And the first problem that we run into](https://youtu.be/Stw0awYWzNo?t=01h11m18s)

[is these types of things where they're](https://youtu.be/Stw0awYWzNo?t=01h11m21s)

[looking for they're they're looking to](https://youtu.be/Stw0awYWzNo?t=01h11m24s)

[acquire a lock which is fine right this](https://youtu.be/Stw0awYWzNo?t=01h11m26s)

[is using packages directory which is the](https://youtu.be/Stw0awYWzNo?t=01h11m29s)

[only one in the Windows locator that's](https://youtu.be/Stw0awYWzNo?t=01h11m32s)

[being overridden for this right so the](https://youtu.be/Stw0awYWzNo?t=01h11m34s)

[lo because and this is where I'm trying](https://youtu.be/Stw0awYWzNo?t=01h11m36s)

[to be a little cautious about what I](https://youtu.be/Stw0awYWzNo?t=01h11m38s)

[what I get carried away with and what I](https://youtu.be/Stw0awYWzNo?t=01h11m40s)

[don't because the Velopac locator API](https://youtu.be/Stw0awYWzNo?t=01h11m42s)

[somebody could write their own right](https://youtu.be/Stw0awYWzNo?t=01h11m45s)

[this is very possible be able to do And](https://youtu.be/Stw0awYWzNo?t=01h11m47s)

[this was an idea that we actually tossed](https://youtu.be/Stw0awYWzNo?t=01h11m50s)

[around for a little bit is well maybe if](https://youtu.be/Stw0awYWzNo?t=01h11m52s)

[they install into a protected directory](https://youtu.be/Stw0awYWzNo?t=01h11m54s)

[we'll just ship we'll just use a](https://youtu.be/Stw0awYWzNo?t=01h11m56s)

[different locator which is kind of a](https://youtu.be/Stw0awYWzNo?t=01h11m57s)

[possibility but I don't know that that](https://youtu.be/Stw0awYWzNo?t=01h12m02s)

[fixes the problem right it just shifts](https://youtu.be/Stw0awYWzNo?t=01h12m06s)

[it around a little bit and](https://youtu.be/Stw0awYWzNo?t=01h12m08s)

[so I'm looking to handle](https://youtu.be/Stw0awYWzNo?t=01h12m10s)

[the the calls in here that are](https://youtu.be/Stw0awYWzNo?t=01h12m13s)

[leveraging it because we've got app](https://youtu.be/Stw0awYWzNo?t=01h12m16s)

[content update exe path and all of these](https://youtu.be/Stw0awYWzNo?t=01h12m17s)

[and specifically the update](https://youtu.be/Stw0awYWzNo?t=01h12m20s)

[path Find my way back to it This guy in](https://youtu.be/Stw0awYWzNo?t=01h12m24s)

[here we get we'll get all the way](https://youtu.be/Stw0awYWzNo?t=01h12m28s)

[down to this guy here And this is what's](https://youtu.be/Stw0awYWzNo?t=01h12m31s)

[going to bite](https://youtu.be/Stw0awYWzNo?t=01h12m35s)

[us](https://youtu.be/Stw0awYWzNo?t=01h12m36s)

[Um that's](https://youtu.be/Stw0awYWzNo?t=01h12m41s)

[actually No it doesn't fix the problem I](https://youtu.be/Stw0awYWzNo?t=01h12m43s)

[was going to say I could swap out the](https://youtu.be/Stw0awYWzNo?t=01h12m46s)

[locator but that still doesn't fix the](https://youtu.be/Stw0awYWzNo?t=01h12m47s)

[issue because we've got this update exe](https://youtu.be/Stw0awYWzNo?t=01h12m48s)

[bytes Um](https://youtu.be/Stw0awYWzNo?t=01h12m52s)

[and let's look at the usages of this](https://youtu.be/Stw0awYWzNo?t=01h12m56s)

[path because ultimately what's looking](https://youtu.be/Stw0awYWzNo?t=01h12m59s)

[to happen is the the package itself when](https://youtu.be/Stw0awYWzNo?t=01h13m01s)

[it when it builds it up right so we've](https://youtu.be/Stw0awYWzNo?t=01h13m04s)

[got one 1.0 right so if we go and look](https://youtu.be/Stw0awYWzNo?t=01h13m06s)

[here this full package contains the app](https://youtu.be/Stw0awYWzNo?t=01h13m09s)

[plus the update.exe exe and a manifest](https://youtu.be/Stw0awYWzNo?t=01h13m14s)

[and some stuff right it's a zip file](https://youtu.be/Stw0awYWzNo?t=01h13m16s)

[with all the useful](https://youtu.be/Stw0awYWzNo?t=01h13m19s)

[bits](https://youtu.be/Stw0awYWzNo?t=01h13m20s)

[Um because update exe may have patches](https://youtu.be/Stw0awYWzNo?t=01h13m22s)

[and](https://youtu.be/Stw0awYWzNo?t=01h13m25s)

[similar and because we need to migrate](https://youtu.be/Stw0awYWzNo?t=01h13m26s)

[from cloud squirrel we want to use the](https://youtu.be/Stw0awYWzNo?t=01h13m28s)

[update.exe that's inside of that package](https://youtu.be/Stw0awYWzNo?t=01h13m30s)

[not necessarily the one that's on](https://youtu.be/Stw0awYWzNo?t=01h13m33s)

[disk Okay fine So be](https://youtu.be/Stw0awYWzNo?t=01h13m35s)

[it But update exe is what we need to run](https://youtu.be/Stw0awYWzNo?t=01h13m38s)

[elevated The problem is we need to get](https://youtu.be/Stw0awYWzNo?t=01h13m42s)

[that out onto disc And this guy here](https://youtu.be/Stw0awYWzNo?t=01h13m44s)

[needs](https://youtu.be/Stw0awYWzNo?t=01h13m47s)

[to needs to land somewhere](https://youtu.be/Stw0awYWzNo?t=01h13m48s)

[else Oo Izzy that is freezing cold We're](https://youtu.be/Stw0awYWzNo?t=01h13m53s)

[actually in your neck of the woods We](https://youtu.be/Stw0awYWzNo?t=01h13m57s)

[are We're doing more MSI stuff with Wix](https://youtu.be/Stw0awYWzNo?t=01h13m58s)

[ish Well we've got an MSI built and now](https://youtu.be/Stw0awYWzNo?t=01h14m01s)

[I need the rest of the the SDK to stop](https://youtu.be/Stw0awYWzNo?t=01h14m05s)

[falling over by making bad assumptions](https://youtu.be/Stw0awYWzNo?t=01h14m08s)

[about what directories are writable](https://youtu.be/Stw0awYWzNo?t=01h14m09s)

[So we're we're chasing](https://youtu.be/Stw0awYWzNo?t=01h14m13s)

[uh access](https://youtu.be/Stw0awYWzNo?t=01h14m15s)

[violations Um](https://youtu.be/Stw0awYWzNo?t=01h14m18s)

[okay So this guy here needs to and he's](https://youtu.be/Stw0awYWzNo?t=01h14m21s)

[already limited down to Windows So this](https://youtu.be/Stw0awYWzNo?t=01h14m25s)

[is only going to happen](https://youtu.be/Stw0awYWzNo?t=01h14m27s)

[here I](https://youtu.be/Stw0awYWzNo?t=01h14m30s)

[think Dang damn it I mean I I shouldn't](https://youtu.be/Stw0awYWzNo?t=01h14m36s)

[be complaining too much](https://youtu.be/Stw0awYWzNo?t=01h14m41s)

[but and I don't I don't know I don't](https://youtu.be/Stw0awYWzNo?t=01h14m43s)

[know the temperature of my current area](https://youtu.be/Stw0awYWzNo?t=01h14m45s)

[in](https://youtu.be/Stw0awYWzNo?t=01h14m47s)

[Celsius actually Here uh let's](https://youtu.be/Stw0awYWzNo?t=01h14m52s)

[go](https://youtu.be/Stw0awYWzNo?t=01h14m56s)

[Uh weather.com How cold is](https://youtu.be/Stw0awYWzNo?t=01h14m58s)

[it come on No No That's not where I want](https://youtu.be/Stw0awYWzNo?t=01h15m02s)

[to be I Nope Stop it Stop it](https://youtu.be/Stw0awYWzNo?t=01h15m05s)

[Go find](https://youtu.be/Stw0awYWzNo?t=01h15m10s)

[me How cold is](https://youtu.be/Stw0awYWzNo?t=01h15m11s)

[it well that's 44 but that's in](https://youtu.be/Stw0awYWzNo?t=01h15m14s)

[Fahrenheit So it's slightly](https://youtu.be/Stw0awYWzNo?t=01h15m17s)

[warmer How do I toggle my my](https://youtu.be/Stw0awYWzNo?t=01h15m20s)

[units i don't know how to toggle units](https://youtu.be/Stw0awYWzNo?t=01h15m25s)

[on here I'm 44 in](https://youtu.be/Stw0awYWzNo?t=01h15m27s)

[Fahrenheit which I don't know how close](https://youtu.be/Stw0awYWzNo?t=01h15m29s)

[that is to 8.7 degrees](https://youtu.be/Stw0awYWzNo?t=01h15m32s)

[C Must not be that far I'm guessing](https://youtu.be/Stw0awYWzNo?t=01h15m34s)

[Uh okay So here we kind of need to know](https://youtu.be/Stw0awYWzNo?t=01h15m38s)

[if the update exe path is](https://youtu.be/Stw0awYWzNo?t=01h15m43s)

[writable So](https://youtu.be/Stw0awYWzNo?t=01h15m49s)

[uh we could just handle it](https://youtu.be/Stw0awYWzNo?t=01h15m53s)

[directly Uh get directory name](https://youtu.be/Stw0awYWzNo?t=01h15m56s)

[update.exe](https://youtu.be/Stw0awYWzNo?t=01h16m02s)

[Um cuz this will extract but then we're](https://youtu.be/Stw0awYWzNo?t=01h16m08s)

[also going to need it because it gets](https://youtu.be/Stw0awYWzNo?t=01h16m11s)

[used here and then it also gets used in](https://youtu.be/Stw0awYWzNo?t=01h16m13s)

[the apply code](https://youtu.be/Stw0awYWzNo?t=01h16m16s)

[path I'm kind of wondering if I can](https://youtu.be/Stw0awYWzNo?t=01h16m22s)

[override it inside of the](https://youtu.be/Stw0awYWzNo?t=01h16m24s)

[locator and get away with that Um so](https://youtu.be/Stw0awYWzNo?t=01h16m26s)

[let's because there's only nine usages](https://youtu.be/Stw0awYWzNo?t=01h16m30s)

[right](https://youtu.be/Stw0awYWzNo?t=01h16m34s)

[so this possible update exe right](https://youtu.be/Stw0awYWzNo?t=01h16m36s)

[because it looks to pull it from poss](https://youtu.be/Stw0awYWzNo?t=01h16m40s)

[from multiple](https://youtu.be/Stw0awYWzNo?t=01h16m42s)

[locations Uh if it's not present we](https://youtu.be/Stw0awYWzNo?t=01h16m49s)

[search for a parent current or inapp](https://youtu.be/Stw0awYWzNo?t=01h16m51s)

[version directory which could maness](https://youtu.be/Stw0awYWzNo?t=01h16m53s)

[subdirectory](https://youtu.be/Stw0awYWzNo?t=01h16m56s)

[uh in an appver directory which does not](https://youtu.be/Stw0awYWzNo?t=01h16m59s)

[contain a SQL version which case we need](https://youtu.be/Stw0awYWzNo?t=01h17m01s)

[to in for a lot of info right so this](https://youtu.be/Stw0awYWzNo?t=01h17m03s)

[this is the this is the hacky](https://youtu.be/Stw0awYWzNo?t=01h17m06s)

[bits there is hacky bits in here because](https://youtu.be/Stw0awYWzNo?t=01h17m09s)

[I asked Kaylin about moving this and he](https://youtu.be/Stw0awYWzNo?t=01h17m12s)

[seemed real apprehensive because of all](https://youtu.be/Stw0awYWzNo?t=01h17m13s)

[of this stuff in here that](https://youtu.be/Stw0awYWzNo?t=01h17m15s)

[is](https://youtu.be/Stw0awYWzNo?t=01h17m19s)

[legacy so we might we might be able to](https://youtu.be/Stw0awYWzNo?t=01h17m20s)

[make some assumptions if we are in a](https://youtu.be/Stw0awYWzNo?t=01h17m23s)

[non-writable directory](https://youtu.be/Stw0awYWzNo?t=01h17m26s)

[But yeah](https://youtu.be/Stw0awYWzNo?t=01h17m28s)

[um this guy](https://youtu.be/Stw0awYWzNo?t=01h17m33s)

[here I'm kind of wondering if I can take](https://youtu.be/Stw0awYWzNo?t=01h17m38s)

[all of this and then do a directory](https://youtu.be/Stw0awYWzNo?t=01h17m41s)

[check on him Um that way this gets](https://youtu.be/Stw0awYWzNo?t=01h17m43s)

[overwritten at the right location](https://youtu.be/Stw0awYWzNo?t=01h17m48s)

[Um let me look in update manager](https://youtu.be/Stw0awYWzNo?t=01h17m51s)

[apply because I kind of want to see](https://youtu.be/Stw0awYWzNo?t=01h17m56s)

[um where this goes because this is](https://youtu.be/Stw0awYWzNo?t=01h18m01s)

[update exe blah blah blah blah blah blah](https://youtu.be/Stw0awYWzNo?t=01h18m04s)

[apply implementation How does it know](https://youtu.be/Stw0awYWzNo?t=01h18m07s)

[where it](https://youtu.be/Stw0awYWzNo?t=01h18m09s)

[is](https://youtu.be/Stw0awYWzNo?t=01h18m11s)

[uh this is the software engineers tool](https://youtu.be/Stw0awYWzNo?t=01h18m15s)

[of the week 22 millimeter hole saw drill](https://youtu.be/Stw0awYWzNo?t=01h18m18s)

[bit I I could potentially grant you IT](https://youtu.be/Stw0awYWzNo?t=01h18m24s)

[admin Like maybe it's it's an unusual](https://youtu.be/Stw0awYWzNo?t=01h18m29s)

[way to solve a software problem but I](https://youtu.be/Stw0awYWzNo?t=01h18m34s)

[I'm hoping it has to do something with](https://youtu.be/Stw0awYWzNo?t=01h18m37s)

[the hardware you code against Like I'm](https://youtu.be/Stw0awYWzNo?t=01h18m39s)

[hoping I'm hoping](https://youtu.be/Stw0awYWzNo?t=01h18m41s)

[like I've it's an unusual way to fix Oh](https://youtu.be/Stw0awYWzNo?t=01h18m43s)

[wait That's just a modern punch card](https://youtu.be/Stw0awYWzNo?t=01h18m47s)

[right maybe](https://youtu.be/Stw0awYWzNo?t=01h18m51s)

[possibly 22 mm hole though](https://youtu.be/Stw0awYWzNo?t=01h18m54s)

[That's a little big](https://youtu.be/Stw0awYWzNo?t=01h18m57s)

[like trying to](https://youtu.be/Stw0awYWzNo?t=01h19m01s)

[think](https://youtu.be/Stw0awYWzNo?t=01h19m04s)

[big or I don't know somewhere in that](https://youtu.be/Stw0awYWzNo?t=01h19m06s)

[vicinity Okay How does it](https://youtu.be/Stw0awYWzNo?t=01h19m09s)

[know it finds the packages start update](https://youtu.be/Stw0awYWzNo?t=01h19m13s)

[How does it know where the update exe is](https://youtu.be/Stw0awYWzNo?t=01h19m16s)

[located](https://youtu.be/Stw0awYWzNo?t=01h19m18s)

[aha There It uses it](https://youtu.be/Stw0awYWzNo?t=01h19m20s)

[there So if the locator were to](https://youtu.be/Stw0awYWzNo?t=01h19m26s)

[switch and update exe were to be](https://youtu.be/Stw0awYWzNo?t=01h19m30s)

[somewhere](https://youtu.be/Stw0awYWzNo?t=01h19m33s)

[else I'm surprised we're actually](https://youtu.be/Stw0awYWzNo?t=01h19m34s)

[looking it up](https://youtu.be/Stw0awYWzNo?t=01h19m37s)

[immediately Feels like something we](https://youtu.be/Stw0awYWzNo?t=01h19m40s)

[could look up later Okay](https://youtu.be/Stw0awYWzNo?t=01h19m42s)

[None of](https://youtu.be/Stw0awYWzNo?t=01h19m46s)

[those is there because there's that](https://youtu.be/Stw0awYWzNo?t=01h19m48s)

[there's that So it's used in the apply](https://youtu.be/Stw0awYWzNo?t=01h19m51s)

[It's used to get the directory name It](https://youtu.be/Stw0awYWzNo?t=01h19m53s)

[is used](https://youtu.be/Stw0awYWzNo?t=01h19m56s)

[here and it is](https://youtu.be/Stw0awYWzNo?t=01h19m59s)

[used here Download and apply delta](https://youtu.be/Stw0awYWzNo?t=01h20m02s)

[updates Right](https://youtu.be/Stw0awYWzNo?t=01h20m12s)

[How does the update exe path get used](https://youtu.be/Stw0awYWzNo?t=01h20m16s)

[for deltas that that gets weird Delta](https://youtu.be/Stw0awYWzNo?t=01h20m18s)

[update.exe But in all cases I want this](https://youtu.be/Stw0awYWzNo?t=01h20m22s)

[to be a writable](https://youtu.be/Stw0awYWzNo?t=01h20m27s)

[location Fairly confident I want this to](https://youtu.be/Stw0awYWzNo?t=01h20m29s)

[be a writable location Right Update exe](https://youtu.be/Stw0awYWzNo?t=01h20m31s)

[path process start info](https://youtu.be/Stw0awYWzNo?t=01h20m34s)

[patch and it call So it self-patches](https://youtu.be/Stw0awYWzNo?t=01h20m38s)

[itself](https://youtu.be/Stw0awYWzNo?t=01h20m41s)

[That's interesting How the heck does it](https://youtu.be/Stw0awYWzNo?t=01h20m43s)

[self-patch does it do the rename](https://youtu.be/Stw0awYWzNo?t=01h20m45s)

[trick how do you](https://youtu.be/Stw0awYWzNo?t=01h20m49s)

[work how do you work i am I am learning](https://youtu.be/Stw0awYWzNo?t=01h20m53s)

[so much Kaylin is somewhat brilliant at](https://youtu.be/Stw0awYWzNo?t=01h20m57s)

[this stuff Uh let's see Patch Show me](https://youtu.be/Stw0awYWzNo?t=01h21m00s)

[your patch](https://youtu.be/Stw0awYWzNo?t=01h21m04s)

[command Old file Patch file Output](https://youtu.be/Stw0awYWzNo?t=01h21m05s)

[file Oh so it literally it's it's no](https://youtu.be/Stw0awYWzNo?t=01h21m09s)

[more complicated than](https://youtu.be/Stw0awYWzNo?t=01h21m12s)

[that Okay that](https://youtu.be/Stw0awYWzNo?t=01h21m16s)

[is about as stupid simple as one could](https://youtu.be/Stw0awYWzNo?t=01h21m21s)

[be Okay so it literally takes old](https://youtu.be/Stw0awYWzNo?t=01h21m23s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=01h21m27s)

[new and literally just applies it And](https://youtu.be/Stw0awYWzNo?t=01h21m28s)

[this is all it is Base temp directory](https://youtu.be/Stw0awYWzNo?t=01h21m32s)

[App tempter Where is app tempter app](https://youtu.be/Stw0awYWzNo?t=01h21m36s)

[temp](https://youtu.be/Stw0awYWzNo?t=01h21m39s)

[directory](https://youtu.be/Stw0awYWzNo?t=01h21m40s)

[Ah the temporary directory for this](https://youtu.be/Stw0awYWzNo?t=01h21m42s)

[application Ah](https://youtu.be/Stw0awYWzNo?t=01h21m45s)

[oh oh oh I'm an idiot then because I](https://youtu.be/Stw0awYWzNo?t=01h21m48s)

[used Where does that get](https://youtu.be/Stw0awYWzNo?t=01h21m54s)

[set where is](https://youtu.be/Stw0awYWzNo?t=01h21m57s)

[that that down a level](https://youtu.be/Stw0awYWzNo?t=01h22m03s)

[Oh](https://youtu.be/Stw0awYWzNo?t=01h22m14s)

[Oh got it Yeah I've been making a box](https://youtu.be/Stw0awYWzNo?t=01h22m16s)

[Oh bought all my test harness bits in](https://youtu.be/Stw0awYWzNo?t=01h22m20s)

[hygien to build custom M5 image that in](https://youtu.be/Stw0awYWzNo?t=01h22m23s)

[order to do factory testing of our](https://youtu.be/Stw0awYWzNo?t=01h22m26s)

[actual units custom Yakto embedded Linux](https://youtu.be/Stw0awYWzNo?t=01h22m28s)

[OS For my next trick I need to automate](https://youtu.be/Stw0awYWzNo?t=01h22m31s)

[it](https://youtu.be/Stw0awYWzNo?t=01h22m34s)

[automate it all in many different CI/CD](https://youtu.be/Stw0awYWzNo?t=01h22m36s)

[systems as part companywide business](https://youtu.be/Stw0awYWzNo?t=01h22m38s)

[improvement](https://youtu.be/Stw0awYWzNo?t=01h22m41s)

[project That actually sounds kind of](https://youtu.be/Stw0awYWzNo?t=01h22m43s)

[fun Not going to lie that sounds kind of](https://youtu.be/Stw0awYWzNo?t=01h22m46s)

[fun This goes the temp goes inside of](https://youtu.be/Stw0awYWzNo?t=01h22m53s)

[the packages directory which I have](https://youtu.be/Stw0awYWzNo?t=01h22m56s)

[overridden to route somewhere](https://youtu.be/Stw0awYWzNo?t=01h23m01s)

[else So this works by](https://youtu.be/Stw0awYWzNo?t=01h23m04s)

[accident but it works the way I think I](https://youtu.be/Stw0awYWzNo?t=01h23m08s)

[want it to go because I was going to say](https://youtu.be/Stw0awYWzNo?t=01h23m11s)

[oh I'll just I'll change the way how I'm](https://youtu.be/Stw0awYWzNo?t=01h23m14s)

[looking at my packages directory to use](https://youtu.be/Stw0awYWzNo?t=01h23m16s)

[the the app temp directory but the app](https://youtu.be/Stw0awYWzNo?t=01h23m18s)

[temp directory requires the packages](https://youtu.be/Stw0awYWzNo?t=01h23m20s)

[directory So that's](https://youtu.be/Stw0awYWzNo?t=01h23m22s)

[exciting Okay so this is this is](https://youtu.be/Stw0awYWzNo?t=01h23m23s)

[probably still a good path to go](https://youtu.be/Stw0awYWzNo?t=01h23m25s)

[down But with all of that said that kind](https://youtu.be/Stw0awYWzNo?t=01h23m29s)

[of means that I can change up how we're](https://youtu.be/Stw0awYWzNo?t=01h23m32s)

[doing](https://youtu.be/Stw0awYWzNo?t=01h23m34s)

[our update EXE](https://youtu.be/Stw0awYWzNo?t=01h23m35s)

[path Okay So I think what we're going to](https://youtu.be/Stw0awYWzNo?t=01h23m38s)

[do here is I I](https://youtu.be/Stw0awYWzNo?t=01h23m40s)

[like I really like doing this as a lazy](https://youtu.be/Stw0awYWzNo?t=01h23m42s)

[because I don't I don't like doing all](https://youtu.be/Stw0awYWzNo?t=01h23m45s)

[of this work until we actually need](https://youtu.be/Stw0awYWzNo?t=01h23m47s)

[it because you shouldn't have to take a](https://youtu.be/Stw0awYWzNo?t=01h23m51s)

[a hit of us digging up all of](https://youtu.be/Stw0awYWzNo?t=01h23m55s)

[your stuff until it's actually needed Uh](https://youtu.be/Stw0awYWzNo?t=01h23m59s)

[update](https://youtu.be/Stw0awYWzNo?t=01h24m04s)

[exe path there We're going to do that](https://youtu.be/Stw0awYWzNo?t=01h24m06s)

[and then this is just going to](https://youtu.be/Stw0awYWzNo?t=01h24m10s)

[become like](https://youtu.be/Stw0awYWzNo?t=01h24m12s)

[this and then this will be update exe](https://youtu.be/Stw0awYWzNo?t=01h24m15s)

[path You will be happy to know Izzy](https://youtu.be/Stw0awYWzNo?t=01h24m18s)

[we're we're we're doing the MSI stuff](https://youtu.be/Stw0awYWzNo?t=01h24m20s)

[and uh Windows services are are on the](https://youtu.be/Stw0awYWzNo?t=01h24m22s)

[docket We've had a](https://youtu.be/Stw0awYWzNo?t=01h24m27s)

[uh had a number of people ask for it and](https://youtu.be/Stw0awYWzNo?t=01h24m30s)

[it's quickly becoming our most requested](https://youtu.be/Stw0awYWzNo?t=01h24m33s)

[thing](https://youtu.be/Stw0awYWzNo?t=01h24m35s)

[So you you you solved the most requested](https://youtu.be/Stw0awYWzNo?t=01h24m36s)

[thing and you were one of the](https://youtu.be/Stw0awYWzNo?t=01h24m39s)

[requesters Uh sadly this week has been](https://youtu.be/Stw0awYWzNo?t=01h24m45s)

[very slow Has been a taxi driver for the](https://youtu.be/Stw0awYWzNo?t=01h24m47s)

[family Last Saturday our family car](https://youtu.be/Stw0awYWzNo?t=01h24m49s)

[broke down Drove into the garage to get](https://youtu.be/Stw0awYWzNo?t=01h24m51s)

[looked](https://youtu.be/Stw0awYWzNo?t=01h24m53s)

[at Yeah that's actually going to be me](https://youtu.be/Stw0awYWzNo?t=01h24m54s)

[Um and I'll I'll I said this at the](https://youtu.be/Stw0awYWzNo?t=01h24m57s)

[beginning of the stream but I'll say it](https://youtu.be/Stw0awYWzNo?t=01h24m59s)

[again for everybody who's here Uh no](https://youtu.be/Stw0awYWzNo?t=01h25m00s)

[stream next week I will be gone to the](https://youtu.be/Stw0awYWzNo?t=01h25m03s)

[Microsoft MVP](https://youtu.be/Stw0awYWzNo?t=01h25m06s)

[summit Um unfortunately that also means](https://youtu.be/Stw0awYWzNo?t=01h25m08s)

[I probably will come back with lots of](https://youtu.be/Stw0awYWzNo?t=01h25m11s)

[cool information that I won't be able to](https://youtu.be/Stw0awYWzNo?t=01h25m14s)

[share So but if history holds true often](https://youtu.be/Stw0awYWzNo?t=01h25m15s)

[at the MVP summit a lot of what they](https://youtu.be/Stw0awYWzNo?t=01h25m21s)

[they do is kind of preview stuff that's](https://youtu.be/Stw0awYWzNo?t=01h25m23s)

[coming out at the build conference So if](https://youtu.be/Stw0awYWzNo?t=01h25m25s)

[you haven't signed up at least to watch](https://youtu.be/Stw0awYWzNo?t=01h25m28s)

[the session](https://youtu.be/Stw0awYWzNo?t=01h25m29s)

[information that would be a good one](https://youtu.be/Stw0awYWzNo?t=01h25m31s)

[there And pro tip if you uh follow any](https://youtu.be/Stw0awYWzNo?t=01h25m33s)

[Microsoft MVPs on like Twitter or](https://youtu.be/Stw0awYWzNo?t=01h25m37s)

[something just pay attention when they](https://youtu.be/Stw0awYWzNo?t=01h25m39s)

[say "Hey this session's going to be](https://youtu.be/Stw0awYWzNo?t=01h25m42s)

[awesome." You you you should](https://youtu.be/Stw0awYWzNo?t=01h25m44s)

[listen That That's my advice because](https://youtu.be/Stw0awYWzNo?t=01h25m47s)

[it's it's likely going to be a hey](https://youtu.be/Stw0awYWzNo?t=01h25m50s)

[there's going to be some cool](https://youtu.be/Stw0awYWzNo?t=01h25m52s)

[stuff Yeah Firewall config registry](https://youtu.be/Stw0awYWzNo?t=01h25m55s)

[stuffs etc Yeah So we'll see how far](https://youtu.be/Stw0awYWzNo?t=01h25m58s)

[things get We we um we punted on having](https://youtu.be/Stw0awYWzNo?t=01h26m02s)

[the the Wix stuff that we do be](https://youtu.be/Stw0awYWzNo?t=01h26m07s)

[extendable That may come back on the](https://youtu.be/Stw0awYWzNo?t=01h26m11s)

[docket depending on how much people need](https://youtu.be/Stw0awYWzNo?t=01h26m14s)

[but we've had enough places where it's](https://youtu.be/Stw0awYWzNo?t=01h26m17s)

[like an MSI installer being able to do](https://youtu.be/Stw0awYWzNo?t=01h26m20s)

[all users and then having some basic](https://youtu.be/Stw0awYWzNo?t=01h26m23s)

[level of UI customization and Windows](https://youtu.be/Stw0awYWzNo?t=01h26m26s)

[services those four things cover our](https://youtu.be/Stw0awYWzNo?t=01h26m28s)

[like that's like 90% of the requests](https://youtu.be/Stw0awYWzNo?t=01h26m31s)

[we're getting right now from what people](https://youtu.be/Stw0awYWzNo?t=01h26m34s)

[want So we're like well that's the top](https://youtu.be/Stw0awYWzNo?t=01h26m36s)

[stuff So we're going to try to kill it](https://youtu.be/Stw0awYWzNo?t=01h26m40s)

[all and and MSI is with Wix is kind of](https://youtu.be/Stw0awYWzNo?t=01h26m42s)

[step one into that direction because](https://youtu.be/Stw0awYWzNo?t=01h26m46s)

[once we're generating](https://youtu.be/Stw0awYWzNo?t=01h26m48s)

[um that it like adding more stuff into](https://youtu.be/Stw0awYWzNo?t=01h26m50s)

[it isn't that terribly difficult](https://youtu.be/Stw0awYWzNo?t=01h26m55s)

[The biggest discussion is going to](https://youtu.be/Stw0awYWzNo?t=01h26m58s)

[be how how to have people specify their](https://youtu.be/Stw0awYWzNo?t=01h27m01s)

[Windows service stuff because we want to](https://youtu.be/Stw0awYWzNo?t=01h27m04s)

[do it in a cross-platform friendly way](https://youtu.be/Stw0awYWzNo?t=01h27m06s)

[so that uh because we we don't want the](https://youtu.be/Stw0awYWzNo?t=01h27m09s)

[Windows services to just](https://youtu.be/Stw0awYWzNo?t=01h27m13s)

[be Windows because Mac also has services](https://youtu.be/Stw0awYWzNo?t=01h27m15s)

[and so we want some sort of kind of](https://youtu.be/Stw0awYWzNo?t=01h27m19s)

[centralized way for somebody to declare](https://youtu.be/Stw0awYWzNo?t=01h27m22s)

[their services because if you built it](https://youtu.be/Stw0awYWzNo?t=01h27m24s)

[in C in theory you could declare or](https://youtu.be/Stw0awYWzNo?t=01h27m26s)

[deploy into both places So we'd kind of](https://youtu.be/Stw0awYWzNo?t=01h27m28s)

[like one con you specify one config we](https://youtu.be/Stw0awYWzNo?t=01h27m31s)

[generate your crossplatform installers](https://youtu.be/Stw0awYWzNo?t=01h27m34s)

[and so you end up with a Windows service](https://youtu.be/Stw0awYWzNo?t=01h27m36s)

[in one and a Mac in Mac service in the](https://youtu.be/Stw0awYWzNo?t=01h27m38s)

[other That's kind of the the current](https://youtu.be/Stw0awYWzNo?t=01h27m40s)

[thinking Uh private string](https://youtu.be/Stw0awYWzNo?t=01h27m44s)

[uh get update exe path there And then](https://youtu.be/Stw0awYWzNo?t=01h27m48s)

[we're just going to put a whole bunch of](https://youtu.be/Stw0awYWzNo?t=01h27m52s)

[the code from up here](https://youtu.be/Stw0awYWzNo?t=01h27m53s)

[down](https://youtu.be/Stw0awYWzNo?t=01h27m56s)

[here](https://youtu.be/Stw0awYWzNo?t=01h27m58s)

[Um actually can we](https://youtu.be/Stw0awYWzNo?t=01h27m59s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=01h28m04s)

[um maybe there's](https://youtu.be/Stw0awYWzNo?t=01h28m11s)

[a is it servicesd that has a config file](https://youtu.be/Stw0awYWzNo?t=01h28m13s)

[as well that is the way because I'm](https://youtu.be/Stw0awYWzNo?t=01h28m17s)

[trying to remember how you specify them](https://youtu.be/Stw0awYWzNo?t=01h28m20s)

[on Mac I think it's like servicesd has a](https://youtu.be/Stw0awYWzNo?t=01h28m21s)

[config file but only a subset of the](https://youtu.be/Stw0awYWzNo?t=01h28m23s)

[options would be valid on Windows So we](https://youtu.be/Stw0awYWzNo?t=01h28m26s)

[may do something](https://youtu.be/Stw0awYWzNo?t=01h28m29s)

[that's similar to that because it's a](https://youtu.be/Stw0awYWzNo?t=01h28m31s)

[fairly simple](https://youtu.be/Stw0awYWzNo?t=01h28m33s)

[um Yeah systemd Yeah Um because I](https://youtu.be/Stw0awYWzNo?t=01h28m36s)

[because we were thinking of if we go](https://youtu.be/Stw0awYWzNo?t=01h28m40s)

[that route like the one risky part is if](https://youtu.be/Stw0awYWzNo?t=01h28m43s)

[you have a format like that that that](https://youtu.be/Stw0awYWzNo?t=01h28m46s)

[you don't fully support everything](https://youtu.be/Stw0awYWzNo?t=01h28m48s)

[people then you know well why don't you](https://youtu.be/Stw0awYWzNo?t=01h28m50s)

[support this why don't you support that](https://youtu.be/Stw0awYWzNo?t=01h28m51s)

[so it's like we may do something](https://youtu.be/Stw0awYWzNo?t=01h28m52s)

[similar and then work our way](https://youtu.be/Stw0awYWzNo?t=01h28m55s)

[in So](https://youtu.be/Stw0awYWzNo?t=01h28m58s)

[yeah Yeah an XML is a](https://youtu.be/Stw0awYWzNo?t=01h29m00s)

[possibility JSON might be a possibility](https://youtu.be/Stw0awYWzNo?t=01h29m03s)

[I don't like](https://youtu.be/Stw0awYWzNo?t=01h29m06s)

[em it doesn't feel good because we don't](https://youtu.be/Stw0awYWzNo?t=01h29m09s)

[need that much right for because we](https://youtu.be/Stw0awYWzNo?t=01h29m11s)

[don't intend to expose like the breadth](https://youtu.be/Stw0awYWzNo?t=01h29m14s)

[of services like we're more likely to](https://youtu.be/Stw0awYWzNo?t=01h29m16s)

[build in](https://youtu.be/Stw0awYWzNo?t=01h29m19s)

[customization option or](https://youtu.be/Stw0awYWzNo?t=01h29m21s)

[um things to give people access to be](https://youtu.be/Stw0awYWzNo?t=01h29m24s)

[able to inject into the generation](https://youtu.be/Stw0awYWzNo?t=01h29m27s)

[rather than expose every possible](https://youtu.be/Stw0awYWzNo?t=01h29m29s)

[property because you like we're going to](https://youtu.be/Stw0awYWzNo?t=01h29m31s)

[do the popular ones and then say at a](https://youtu.be/Stw0awYWzNo?t=01h29m35s)

[certain point kind of have to like](https://youtu.be/Stw0awYWzNo?t=01h29m37s)

[inject your own stuff because the the](https://youtu.be/Stw0awYWzNo?t=01h29m40s)

[amount of customization available will](https://youtu.be/Stw0awYWzNo?t=01h29m43s)

[vastly exceed what we want to expose in](https://youtu.be/Stw0awYWzNo?t=01h29m45s)

[our little](https://youtu.be/Stw0awYWzNo?t=01h29m47s)

[CLI So I am realizing part of the reason](https://youtu.be/Stw0awYWzNo?t=01h29m49s)

[for doing this](https://youtu.be/Stw0awYWzNo?t=01h29m52s)

[now Oh yuck So we may not be able to do](https://youtu.be/Stw0awYWzNo?t=01h30m00s)

[this as easy and as lazy as I was hoping](https://youtu.be/Stw0awYWzNo?t=01h30m03s)

[for Well in the interest of getting it](https://youtu.be/Stw0awYWzNo?t=01h30m07s)

[working let's scrap this for the moment](https://youtu.be/Stw0awYWzNo?t=01h30m09s)

[and let's let's do this though So](https://youtu.be/Stw0awYWzNo?t=01h30m12s)

[uh](https://youtu.be/Stw0awYWzNo?t=01h30m16s)

[if path get directory name update exe](https://youtu.be/Stw0awYWzNo?t=01h30m17s)

[path is](https://youtu.be/Stw0awYWzNo?t=01h30m23s)

[uh parent uh let's see update exe](https://youtu.be/Stw0awYWzNo?t=01h30m26s)

[directory right so we'll do that](https://youtu.be/Stw0awYWzNo?t=01h30m33s)

[Um and then we want to do](https://youtu.be/Stw0awYWzNo?t=01h30m36s)

[uh](https://youtu.be/Stw0awYWzNo?t=01h30m40s)

[and path util is directory](https://youtu.be/Stw0awYWzNo?t=01h30m41s)

[writable Right now we got to now we got](https://youtu.be/Stw0awYWzNo?t=01h30m47s)

[to adjust because this is this is the](https://youtu.be/Stw0awYWzNo?t=01h30m49s)

[failure case that we're running into Go](https://youtu.be/Stw0awYWzNo?t=01h30m52s)

[back up here for a moment](https://youtu.be/Stw0awYWzNo?t=01h30m55s)

[I may come back to try to to defer this](https://youtu.be/Stw0awYWzNo?t=01h30m57s)

[at a later point because I I do like the](https://youtu.be/Stw0awYWzNo?t=01h31m00s)

[idea of a lot of this work being](https://youtu.be/Stw0awYWzNo?t=01h31m03s)

[deferred because it's not really needed](https://youtu.be/Stw0awYWzNo?t=01h31m04s)

[Well problem is some of this is needed](https://youtu.be/Stw0awYWzNo?t=01h31m07s)

[early Some of it's](https://youtu.be/Stw0awYWzNo?t=01h31m10s)

[not Never worked on a Mac So next home](https://youtu.be/Stw0awYWzNo?t=01h31m15s)

[project is a buy one in about 10 years](https://youtu.be/Stw0awYWzNo?t=01h31m17s)

[when I've saved enough and deep dive](https://youtu.be/Stw0awYWzNo?t=01h31m20s)

[into the file system and see how it all](https://youtu.be/Stw0awYWzNo?t=01h31m21s)

[takes Yeah And that's the thing is I](https://youtu.be/Stw0awYWzNo?t=01h31m23s)

[don't Mac's not my daily driver but my](https://youtu.be/Stw0awYWzNo?t=01h31m25s)

[partner Kayn is much more familiar with](https://youtu.be/Stw0awYWzNo?t=01h31m28s)

[him and so I kind of let him](https://youtu.be/Stw0awYWzNo?t=01h31m30s)

[roll](https://youtu.be/Stw0awYWzNo?t=01h31m33s)

[Hey TGR](https://youtu.be/Stw0awYWzNo?t=01h31m34s)

[is going good We are attempting to get](https://youtu.be/Stw0awYWzNo?t=01h31m37s)

[Velopac to to play nice with protected](https://youtu.be/Stw0awYWzNo?t=01h31m42s)

[directories How you doing](https://youtu.be/Stw0awYWzNo?t=01h31m46s)

[tonight uh okay So if this fails I think](https://youtu.be/Stw0awYWzNo?t=01h31m48s)

[what we might just do is](https://youtu.be/Stw0awYWzNo?t=01h31m52s)

[uh Oh and I appreciate the follow](https://youtu.be/Stw0awYWzNo?t=01h31m57s)

[too Uh let's promote some of](https://youtu.be/Stw0awYWzNo?t=01h32m00s)

[these Well I don't really It's this that](https://youtu.be/Stw0awYWzNo?t=01h32m05s)

[I care](https://youtu.be/Stw0awYWzNo?t=01h32m08s)

[about So let's promote that to a to a](https://youtu.be/Stw0awYWzNo?t=01h32m10s)

[real boy method I think](https://youtu.be/Stw0awYWzNo?t=01h32m13s)

[uh private string](https://youtu.be/Stw0awYWzNo?t=01h32m16s)

[get temp app root uh](https://youtu.be/Stw0awYWzNo?t=01h32m20s)

[directory Actually I guess we can just](https://youtu.be/Stw0awYWzNo?t=01h32m27s)

[do this](https://youtu.be/Stw0awYWzNo?t=01h32m29s)

[like this because there's no reason this](https://youtu.be/Stw0awYWzNo?t=01h32m31s)

[doesn't have to be fancy I just need it](https://youtu.be/Stw0awYWzNo?t=01h32m35s)

[not there I need it somewhere where I](https://youtu.be/Stw0awYWzNo?t=01h32m37s)

[can use it](https://youtu.be/Stw0awYWzNo?t=01h32m40s)

[elsewhere](https://youtu.be/Stw0awYWzNo?t=01h32m42s)

[there Probably move that around later](https://youtu.be/Stw0awYWzNo?t=01h32m44s)

[Okay that gets me to there That gets me](https://youtu.be/Stw0awYWzNo?t=01h32m47s)

[to there So if that's not writable we're](https://youtu.be/Stw0awYWzNo?t=01h32m49s)

[gonna go with](https://youtu.be/Stw0awYWzNo?t=01h32m52s)

[uh let's see update exe path gets](https://youtu.be/Stw0awYWzNo?t=01h32m54s)

[uh path combined](https://youtu.be/Stw0awYWzNo?t=01h32m58s)

[uh temp app root directory](https://youtu.be/Stw0awYWzNo?t=01h33m01s)

[update.exe and I am](https://youtu.be/Stw0awYWzNo?t=01h33m08s)

[The only one that's giving me pause is](https://youtu.be/Stw0awYWzNo?t=01h33m16s)

[this one](https://youtu.be/Stw0awYWzNo?t=01h33m19s)

[here But this one I think apply I I just](https://youtu.be/Stw0awYWzNo?t=01h33m22s)

[want to make sure that it overwrites](https://youtu.be/Stw0awYWzNo?t=01h33m26s)

[before](https://youtu.be/Stw0awYWzNo?t=01h33m28s)

[it ddexe](https://youtu.be/Stw0awYWzNo?t=01h33m30s)

[path before it invokes And this isn't](https://youtu.be/Stw0awYWzNo?t=01h33m32s)

[process starting on it It's applying the](https://youtu.be/Stw0awYWzNo?t=01h33m35s)

[delta package to it That's fine Fine At](https://youtu.be/Stw0awYWzNo?t=01h33m37s)

[some point I'm going to be building a](https://youtu.be/Stw0awYWzNo?t=01h33m42s)

[flowchart of the whole installer updated](https://youtu.be/Stw0awYWzNo?t=01h33m44s)

[process One my own knowledge because I](https://youtu.be/Stw0awYWzNo?t=01h33m47s)

[keep getting my bits confused Um and uh](https://youtu.be/Stw0awYWzNo?t=01h33m50s)

[two because there's been enough](https://youtu.be/Stw0awYWzNo?t=01h33m55s)

[questions on it it would be nice if we](https://youtu.be/Stw0awYWzNo?t=01h33m57s)

[had a picture to look at rather than](https://youtu.be/Stw0awYWzNo?t=01h33m59s)

[telling people oh just go read the](https://youtu.be/Stw0awYWzNo?t=01h34m02s)

[source code because as somebody who](https://youtu.be/Stw0awYWzNo?t=01h34m04s)

[works on it even I get lost So you know](https://youtu.be/Stw0awYWzNo?t=01h34m06s)

[there's that Um okay So that I](https://youtu.be/Stw0awYWzNo?t=01h34m09s)

[think fixes](https://youtu.be/Stw0awYWzNo?t=01h34m13s)

[it Haven't run the update yet So let's](https://youtu.be/Stw0awYWzNo?t=01h34m16s)

[let's do this I am going to uninstall](https://youtu.be/Stw0awYWzNo?t=01h34m20s)

[this Hey find it Here you go Windows](https://youtu.be/Stw0awYWzNo?t=01h34m25s)

[Uninstall](https://youtu.be/Stw0awYWzNo?t=01h34m29s)

[Uninstall Good little MSI Do your job](https://youtu.be/Stw0awYWzNo?t=01h34m31s)

[Okay And then I am going to go back here](https://youtu.be/Stw0awYWzNo?t=01h34m35s)

[and I'm gonna once again blow away](https://youtu.be/Stw0awYWzNo?t=01h34m38s)

[everything so we can start over at](https://youtu.be/Stw0awYWzNo?t=01h34m41s)

[1.0 Not really critical that I do that](https://youtu.be/Stw0awYWzNo?t=01h34m45s)

[but it just my brain feels better when I](https://youtu.be/Stw0awYWzNo?t=01h34m47s)

[do it that way So](https://youtu.be/Stw0awYWzNo?t=01h34m50s)

[terminal is the open terminal shortcut I](https://youtu.be/Stw0awYWzNo?t=01h34m54s)

[just want to open the terminal](https://youtu.be/Stw0awYWzNo?t=01h34m57s)

[the button for it And I don't remember](https://youtu.be/Stw0awYWzNo?t=01h35m04s)

[what it](https://youtu.be/Stw0awYWzNo?t=01h35m06s)

[is Uh oh whatever Terminal](https://youtu.be/Stw0awYWzNo?t=01h35m07s)

[new Yeah I don't want a new one I just](https://youtu.be/Stw0awYWzNo?t=01h35m11s)

[wanted this guy back up Uh okay And so](https://youtu.be/Stw0awYWzNo?t=01h35m14s)

[we're going to go back to](https://youtu.be/Stw0awYWzNo?t=01h35m17s)

[1.0 Build all the](https://youtu.be/Stw0awYWzNo?t=01h35m18s)

[things Yeah I know Izzy I actually shot](https://youtu.be/Stw0awYWzNo?t=01h35m24s)

[myself in the foot the other day when I](https://youtu.be/Stw0awYWzNo?t=01h35m27s)

[was doing this](https://youtu.be/Stw0awYWzNo?t=01h35m29s)

[Um and I should I should go and look and](https://youtu.be/Stw0awYWzNo?t=01h35m32s)

[see if I have](https://youtu.be/Stw0awYWzNo?t=01h35m34s)

[it I have it](https://youtu.be/Stw0awYWzNo?t=01h35m36s)

[enabled I did I did make myself a very](https://youtu.be/Stw0awYWzNo?t=01h35m42s)

[problematic](https://youtu.be/Stw0awYWzNo?t=01h35m46s)

[state Don't have it](https://youtu.be/Stw0awYWzNo?t=01h35m48s)

[enabled For anybody who's interested you](https://youtu.be/Stw0awYWzNo?t=01h35m51s)

[Windows features Windows Sandbox I just](https://youtu.be/Stw0awYWzNo?t=01h35m53s)

[checked it by the way So](https://youtu.be/Stw0awYWzNo?t=01h35m56s)

[um I'm hesitant](https://youtu.be/Stw0awYWzNo?t=01h35m59s)

[to apply it now because most Windows](https://youtu.be/Stw0awYWzNo?t=01h36m02s)

[features require reboots and it's really](https://youtu.be/Stw0awYWzNo?t=01h36m05s)

[hard to stream a](https://youtu.be/Stw0awYWzNo?t=01h36m07s)

[reboot](https://youtu.be/Stw0awYWzNo?t=01h36m08s)

[That's small](https://youtu.be/Stw0awYWzNo?t=01h36m10s)

[problem Um and anybody who's potentially](https://youtu.be/Stw0awYWzNo?t=01h36m12s)

[not seen me on YouTube my automation](https://youtu.be/Stw0awYWzNo?t=01h36m15s)

[once again broke Google got a little](https://youtu.be/Stw0awYWzNo?t=01h36m17s)

[annoyed at my way of doing things and](https://youtu.be/Stw0awYWzNo?t=01h36m20s)

[blocked the account That's annoying not](https://youtu.be/Stw0awYWzNo?t=01h36m22s)

[my primary account that's hosting them](https://youtu.be/Stw0awYWzNo?t=01h36m26s)

[but the secondary account I was using](https://youtu.be/Stw0awYWzNo?t=01h36m27s)

[for automation So I have to find a way](https://youtu.be/Stw0awYWzNo?t=01h36m29s)

[of doing my automation or bite the](https://youtu.be/Stw0awYWzNo?t=01h36m33s)

[bullet and just manually do](https://youtu.be/Stw0awYWzNo?t=01h36m36s)

[it I'm a developer so you can guess](https://youtu.be/Stw0awYWzNo?t=01h36m40s)

[which one I'm likely to lean](https://youtu.be/Stw0awYWzNo?t=01h36m42s)

[towards Okay so happy new](https://youtu.be/Stw0awYWzNo?t=01h36m44s)

[MSI with now the new S It should have](https://youtu.be/Stw0awYWzNo?t=01h36m48s)

[the new SDK in it with all our our fresh](https://youtu.be/Stw0awYWzNo?t=01h36m52s)

[bits which is nice Then we come back](https://youtu.be/Stw0awYWzNo?t=01h36m55s)

[over](https://youtu.be/Stw0awYWzNo?t=01h36m59s)

[here Go refresh There we go](https://youtu.be/Stw0awYWzNo?t=01h37m00s)

[There](https://youtu.be/Stw0awYWzNo?t=01h37m04s)

[Uh yeah Also shot yourself on one of the](https://youtu.be/Stw0awYWzNo?t=01h37m09s)

[build servers Yeah like I had an install](https://youtu.be/Stw0awYWzNo?t=01h37m12s)

[go ary](https://youtu.be/Stw0awYWzNo?t=01h37m16s)

[Thankfully I knew what it was touching](https://youtu.be/Stw0awYWzNo?t=01h37m19s)

[and so I went and manually undid](https://youtu.be/Stw0awYWzNo?t=01h37m21s)

[everything but yuck Yeah it was kind of](https://youtu.be/Stw0awYWzNo?t=01h37m23s)

[a pain I was I was sitting there doing](https://youtu.be/Stw0awYWzNo?t=01h37m25s)

[that and I was like man I shouldn't be](https://youtu.be/Stw0awYWzNo?t=01h37m27s)

[doing it like this I technically my my](https://youtu.be/Stw0awYWzNo?t=01h37m30s)

[default setting was you know what I](https://youtu.be/Stw0awYWzNo?t=01h37m34s)

[should do i should I should be doing](https://youtu.be/Stw0awYWzNo?t=01h37m35s)

[this inside of a VM I should not be](https://youtu.be/Stw0awYWzNo?t=01h37m37s)

[doing this on my primary But it's okay](https://youtu.be/Stw0awYWzNo?t=01h37m39s)

[Like I wiped this system like three](https://youtu.be/Stw0awYWzNo?t=01h37m42s)

[months ago It's like I could reset it up](https://youtu.be/Stw0awYWzNo?t=01h37m43s)

[again I've got my Windgit scripts It](https://youtu.be/Stw0awYWzNo?t=01h37m46s)

[only takes like four or five hours Just](https://youtu.be/Stw0awYWzNo?t=01h37m49s)

[not what you want to do Okay Check for](https://youtu.be/Stw0awYWzNo?t=01h37m52s)

[updates](https://youtu.be/Stw0awYWzNo?t=01h37m56s)

[Okay I don't like that this doesn't log](https://youtu.be/Stw0awYWzNo?t=01h38m01s)

[out that it loaded from the temp](https://youtu.be/Stw0awYWzNo?t=01h38m05s)

[directory And I know that that's what it](https://youtu.be/Stw0awYWzNo?t=01h38m06s)

[did We might fix that Okay So that that](https://youtu.be/Stw0awYWzNo?t=01h38m08s)

[got us there Let's build version 101](https://youtu.be/Stw0awYWzNo?t=01h38m11s)

[because the goal here is to click all](https://youtu.be/Stw0awYWzNo?t=01h38m15s)

[the buttons and have it work That's the](https://youtu.be/Stw0awYWzNo?t=01h38m17s)

[goal And at least now the download](https://youtu.be/Stw0awYWzNo?t=01h38m21s)

[button should work which was not working](https://youtu.be/Stw0awYWzNo?t=01h38m24s)

[when we started So we can get the](https://youtu.be/Stw0awYWzNo?t=01h38m26s)

[download button working That'll be](https://youtu.be/Stw0awYWzNo?t=01h38m28s)

[pretty close And then the up the restart](https://youtu.be/Stw0awYWzNo?t=01h38m29s)

[and apply will be the next one](https://youtu.be/Stw0awYWzNo?t=01h38m32s)

[I'm hoping that all that just flows](https://youtu.be/Stw0awYWzNo?t=01h38m46s)

[really nicely and it works great Come](https://youtu.be/Stw0awYWzNo?t=01h38m48s)

[on And you'll note when you compile when](https://youtu.be/Stw0awYWzNo?t=01h38m52s)

[you do run the VPK pack with](https://youtu.be/Stw0awYWzNo?t=01h38m54s)

[the Oh this is actually a lie now Not](https://youtu.be/Stw0awYWzNo?t=01h38m58s)

[running net](https://youtu.be/Stw0awYWzNo?t=01h39m02s)

[build That's a lie](https://youtu.be/Stw0awYWzNo?t=01h39m04s)

[I killed the .NET build stuff Even](https://youtu.be/Stw0awYWzNo?t=01h39m07s)

[though Wix 5 really likes MS build stuff](https://youtu.be/Stw0awYWzNo?t=01h39m08s)

[I looked at what they were doing as part](https://youtu.be/Stw0awYWzNo?t=01h39m12s)

[of their MS build stuff and realized](https://youtu.be/Stw0awYWzNo?t=01h39m14s)

[that what I need and what their MS build](https://youtu.be/Stw0awYWzNo?t=01h39m16s)

[stuff offers uh I don't need any of it](https://youtu.be/Stw0awYWzNo?t=01h39m19s)

[And so I just scrapped it and went](https://youtu.be/Stw0awYWzNo?t=01h39m22s)

[straight to their XE](https://youtu.be/Stw0awYWzNo?t=01h39m24s)

[instead Uh some reason my thing was](https://youtu.be/Stw0awYWzNo?t=01h39m26s)

[writing a temp file in the system 32](https://youtu.be/Stw0awYWzNo?t=01h39m30s)

[Windows directory Then it did a](https://youtu.be/Stw0awYWzNo?t=01h39m31s)

[recursive delete while running an](https://youtu.be/Stw0awYWzNo?t=01h39m33s)

[elevated context](https://youtu.be/Stw0awYWzNo?t=01h39m34s)

[Oh that's that's not good That's very](https://youtu.be/Stw0awYWzNo?t=01h39m39s)

[bad That is very very](https://youtu.be/Stw0awYWzNo?t=01h39m43s)

[bad Once I I I once went through and did](https://youtu.be/Stw0awYWzNo?t=01h39m47s)

[the standard you know the rmst star what](https://youtu.be/Stw0awYWzNo?t=01h39m50s)

[what is it trying to remember in uh](https://youtu.be/Stw0awYWzNo?t=01h39m54s)

[PowerShell the equivalent of you know](https://youtu.be/Stw0awYWzNo?t=01h39m57s)

[nuke my entire C directory just to see](https://youtu.be/Stw0awYWzNo?t=01h39m59s)

[how far I could](https://youtu.be/Stw0awYWzNo?t=01h40m01s)

[get like it doesn't torch everything but](https://youtu.be/Stw0awYWzNo?t=01h40m03s)

[it definitely leaves your system in a](https://youtu.be/Stw0awYWzNo?t=01h40m06s)

[very very not okay state when it's all](https://youtu.be/Stw0awYWzNo?t=01h40m08s)

[said and done It so yeah don't recommend](https://youtu.be/Stw0awYWzNo?t=01h40m11s)

[it Okay so now if we check for](https://youtu.be/Stw0awYWzNo?t=01h40m14s)

[updates we found a new update Yay](https://youtu.be/Stw0awYWzNo?t=01h40m19s)

[Install the update or not install](https://youtu.be/Stw0awYWzNo?t=01h40m22s)

[download the](https://youtu.be/Stw0awYWzNo?t=01h40m24s)

[update Okay full release download](https://youtu.be/Stw0awYWzNo?t=01h40m26s)

[complete Package moved to temp Okay so](https://youtu.be/Stw0awYWzNo?t=01h40m29s)

[it did it did go to the correct temp](https://youtu.be/Stw0awYWzNo?t=01h40m32s)

[directory It built all of that out](https://youtu.be/Stw0awYWzNo?t=01h40m34s)

[Extracted the new update.exe inside of](https://youtu.be/Stw0awYWzNo?t=01h40m36s)

[this I kind of want to go look there](https://youtu.be/Stw0awYWzNo?t=01h40m39s)

[real](https://youtu.be/Stw0awYWzNo?t=01h40m41s)

[quick Right So if I go here pop my temp](https://youtu.be/Stw0awYWzNo?t=01h40m42s)

[I'm looking for Vellopac something or](https://youtu.be/Stw0awYWzNo?t=01h40m46s)

[another Uh there we go So there's our](https://youtu.be/Stw0awYWzNo?t=01h40m48s)

[package There's our beta ID](https://youtu.be/Stw0awYWzNo?t=01h40m53s)

[got It's concerning to me that I see the](https://youtu.be/Stw0awYWzNo?t=01h40m58s)

[lock file still](https://youtu.be/Stw0awYWzNo?t=01h41m00s)

[here because I kind of would have](https://youtu.be/Stw0awYWzNo?t=01h41m02s)

[expected the lock file to be cleaned](https://youtu.be/Stw0awYWzNo?t=01h41m05s)

[up Why did the lock file not get cleaned](https://youtu.be/Stw0awYWzNo?t=01h41m10s)

[up on the](https://youtu.be/Stw0awYWzNo?t=01h41m13s)

[download that that bothers me a little](https://youtu.be/Stw0awYWzNo?t=01h41m14s)

[bit Uh let's see here](https://youtu.be/Stw0awYWzNo?t=01h41m19s)

[Where is there where's that lock](https://youtu.be/Stw0awYWzNo?t=01h41m25s)

[file it acquires update](https://youtu.be/Stw0awYWzNo?t=01h41m31s)

[lock Lock](https://youtu.be/Stw0awYWzNo?t=01h41m37s)

[file](https://youtu.be/Stw0awYWzNo?t=01h41m44s)

[Yeah Uh am I missing something](https://youtu.be/Stw0awYWzNo?t=01h41m50s)

[obvious where is](https://youtu.be/Stw0awYWzNo?t=01h41m54s)

[it there's Vevelopac lock Wait was](https://youtu.be/Stw0awYWzNo?t=01h41m58s)

[that Yeah Velopac lock got](https://youtu.be/Stw0awYWzNo?t=01h42m02s)

[created two minutes ago Does lock file](https://youtu.be/Stw0awYWzNo?t=01h42m08s)

[not delete on dispose thought it did](https://youtu.be/Stw0awYWzNo?t=01h42m12s)

[It does not delete on](https://youtu.be/Stw0awYWzNo?t=01h42m23s)

[dispose Oh](https://youtu.be/Stw0awYWzNo?t=01h42m25s)

[wait Yes Some of for wait some for](https://youtu.be/Stw0awYWzNo?t=01h42m27s)

[delete I wonder why it doesn't](https://youtu.be/Stw0awYWzNo?t=01h42m31s)

[delete I wonder why it doesn't](https://youtu.be/Stw0awYWzNo?t=01h42m37s)

[delete Turns out one of our juniors made](https://youtu.be/Stw0awYWzNo?t=01h42m41s)

[a variable in a batch file that](https://youtu.be/Stw0awYWzNo?t=01h42m43s)

[essentially a typo for an environment](https://youtu.be/Stw0awYWzNo?t=01h42m45s)

[variable and the rest is](https://youtu.be/Stw0awYWzNo?t=01h42m47s)

[history Will never test anyone else's](https://youtu.be/Stw0awYWzNo?t=01h42m49s)

[work on build machines](https://youtu.be/Stw0awYWzNo?t=01h42m51s)

[again Ah yes Yes Well unless they're](https://youtu.be/Stw0awYWzNo?t=01h42m54s)

[unless they're virtualized build](https://youtu.be/Stw0awYWzNo?t=01h42m58s)

[machines I I I can I can allow it in](https://youtu.be/Stw0awYWzNo?t=01h42m59s)

[that situation where the cost of failure](https://youtu.be/Stw0awYWzNo?t=01h43m02s)

[is eh shoot it and spin a new](https://youtu.be/Stw0awYWzNo?t=01h43m04s)

[one But yes can certainly agree with](https://youtu.be/Stw0awYWzNo?t=01h43m09s)

[that](https://youtu.be/Stw0awYWzNo?t=01h43m12s)

[Okay so this this thing is not designed](https://youtu.be/Stw0awYWzNo?t=01h43m14s)

[to](https://youtu.be/Stw0awYWzNo?t=01h43m16s)

[delete I wonder if it should That's a](https://youtu.be/Stw0awYWzNo?t=01h43m17s)

[different problem That is not the](https://youtu.be/Stw0awYWzNo?t=01h43m20s)

[problem I am solving now Not chasing](https://youtu.be/Stw0awYWzNo?t=01h43m22s)

[rabbits I am focused I am](https://youtu.be/Stw0awYWzNo?t=01h43m24s)

[focused as I mean as focused as man can](https://youtu.be/Stw0awYWzNo?t=01h43m27s)

[be when he's drinking Mountain Dew late](https://youtu.be/Stw0awYWzNo?t=01h43m30s)

[at night Um](https://youtu.be/Stw0awYWzNo?t=01h43m31s)

[okay So that worked there Now the the](https://youtu.be/Stw0awYWzNo?t=01h43m34s)

[apply and restart This is where things](https://youtu.be/Stw0awYWzNo?t=01h43m38s)

[are going to also get hairy because this](https://youtu.be/Stw0awYWzNo?t=01h43m40s)

[guy going to call](https://youtu.be/Stw0awYWzNo?t=01h43m44s)

[apply That's the plan with my CI/CD](https://youtu.be/Stw0awYWzNo?t=01h43m49s)

[investigation](https://youtu.be/Stw0awYWzNo?t=01h43m52s)

[Sweet Yeah that I will say when you've](https://youtu.be/Stw0awYWzNo?t=01h43m53s)

[got a nice CI/CD system set up it feels](https://youtu.be/Stw0awYWzNo?t=01h43m56s)

[good Like I don't know I get this power](https://youtu.be/Stw0awYWzNo?t=01h44m00s)

[trip when I have all my little CICD](https://youtu.be/Stw0awYWzNo?t=01h44m03s)

[agents going and doing my bidding It's](https://youtu.be/Stw0awYWzNo?t=01h44m06s)

[like I've got my own little army all of](https://youtu.be/Stw0awYWzNo?t=01h44m08s)

[my minions and it feels nice That's](https://youtu.be/Stw0awYWzNo?t=01h44m11s)

[probably not the way to look at CI/CD](https://youtu.be/Stw0awYWzNo?t=01h44m14s)

[systems properly but it's it's how I](https://youtu.be/Stw0awYWzNo?t=01h44m16s)

[look at them It's like I've got my army](https://youtu.be/Stw0awYWzNo?t=01h44m18s)

[of little compute Go little army of](https://youtu.be/Stw0awYWzNo?t=01h44m20s)

[compute Um okay So this is actually](https://youtu.be/Stw0awYWzNo?t=01h44m22s)

[going to look in the packages directory](https://youtu.be/Stw0awYWzNo?t=01h44m26s)

[which will get the right](https://youtu.be/Stw0awYWzNo?t=01h44m28s)

[path I'm just curious how does it know](https://youtu.be/Stw0awYWzNo?t=01h44m31s)

[how do it know where the target](https://youtu.be/Stw0awYWzNo?t=01h44m35s)

[directory is because I'm worried that](https://youtu.be/Stw0awYWzNo?t=01h44m37s)

[it's going to infer the p the the apply](https://youtu.be/Stw0awYWzNo?t=01h44m38s)

[directory as the packages directory and](https://youtu.be/Stw0awYWzNo?t=01h44m41s)

[that okay let's go look at let's go look](https://youtu.be/Stw0awYWzNo?t=01h44m45s)

[at how apply works because I am I am](https://youtu.be/Stw0awYWzNo?t=01h44m48s)

[concerned that it is going to do the](https://youtu.be/Stw0awYWzNo?t=01h44m50s)

[wrong](https://youtu.be/Stw0awYWzNo?t=01h44m52s)

[thing and that I need to give it another](https://youtu.be/Stw0awYWzNo?t=01h44m53s)

[switch because I I have a strange](https://youtu.be/Stw0awYWzNo?t=01h44m56s)

[suspicion I need to give it another](https://youtu.be/Stw0awYWzNo?t=01h44m58s)

[switch okay because we've only got](https://youtu.be/Stw0awYWzNo?t=01h44m59s)

[package no restart wait because without](https://youtu.be/Stw0awYWzNo?t=01h45m02s)

[any direction it has no concept that it](https://youtu.be/Stw0awYWzNo?t=01h45m04s)

[needs to Go into program](https://youtu.be/Stw0awYWzNo?t=01h45m06s)

[files Yeah So](https://youtu.be/Stw0awYWzNo?t=01h45m09s)

[that's need to paint all my pies yellow](https://youtu.be/Stw0awYWzNo?t=01h45m11s)

[Yes And little little glasses and](https://youtu.be/Stw0awYWzNo?t=01h45m14s)

[preferably some little uh overalls That](https://youtu.be/Stw0awYWzNo?t=01h45m16s)

[would be that would be preferable And](https://youtu.be/Stw0awYWzNo?t=01h45m19s)

[then you must send pictures That will be](https://youtu.be/Stw0awYWzNo?t=01h45m21s)

[a requirement as](https://youtu.be/Stw0awYWzNo?t=01h45m23s)

[well Uh let's see here So apply because](https://youtu.be/Stw0awYWzNo?t=01h45m26s)

[I feel like this is going to absolutely](https://youtu.be/Stw0awYWzNo?t=01h45m30s)

[like there's no way this thing](https://youtu.be/Stw0awYWzNo?t=01h45m32s)

[knows Okay locator So it's using the](https://youtu.be/Stw0awYWzNo?t=01h45m35s)

[locator IM](https://youtu.be/Stw0awYWzNo?t=01h45m38s)

[update.exe right so](https://youtu.be/Stw0awYWzNo?t=01h45m40s)

[how if it is im update](https://youtu.be/Stw0awYWzNo?t=01h45m43s)

[exe path](https://youtu.be/Stw0awYWzNo?t=01h45m48s)

[uh grabs the parent create config](https://youtu.be/Stw0awYWzNo?t=01h45m52s)

[locator new from the config So it's](https://youtu.be/Stw0awYWzNo?t=01h45m55s)

[going to try to create Okay so this is](https://youtu.be/Stw0awYWzNo?t=01h45m57s)

[not going to work I need](https://youtu.be/Stw0awYWzNo?t=01h45m59s)

[it I need to land in this](https://youtu.be/Stw0awYWzNo?t=01h46m03s)

[case because I need it to not use its](https://youtu.be/Stw0awYWzNo?t=01h46m07s)

[current](https://youtu.be/Stw0awYWzNo?t=01h46m11s)

[location as the appropriate one I need](https://youtu.be/Stw0awYWzNo?t=01h46m13s)

[it to be](https://youtu.be/Stw0awYWzNo?t=01h46m18s)

[here Um who else uses this and what do](https://youtu.be/Stw0awYWzNo?t=01h46m19s)

[they](https://youtu.be/Stw0awYWzNo?t=01h46m24s)

[do so locator](https://youtu.be/Stw0awYWzNo?t=01h46m25s)

[This is just](https://youtu.be/Stw0awYWzNo?t=01h46m36s)

[test Looks like another test](https://youtu.be/Stw0awYWzNo?t=01h46m38s)

[Yeah I will say I have mixed opinions of](https://youtu.be/Stw0awYWzNo?t=01h46m42s)

[it but it's it's kind of interesting the](https://youtu.be/Stw0awYWzNo?t=01h46m44s)

[like I I I almost like the Rust way of](https://youtu.be/Stw0awYWzNo?t=01h46m48s)

[being able to put your tests right next](https://youtu.be/Stw0awYWzNo?t=01h46m51s)

[to the code that they test](https://youtu.be/Stw0awYWzNo?t=01h46m54s)

[Like if there was a C sharpie](https://youtu.be/Stw0awYWzNo?t=01h46m57s)

[way to put my code in like a partial of](https://youtu.be/Stw0awYWzNo?t=01h47m00s)

[the class that I wanted to](https://youtu.be/Stw0awYWzNo?t=01h47m05s)

[test and then I could compile it out](https://youtu.be/Stw0awYWzNo?t=01h47m07s)

[Like I feel like there's enough bits](https://youtu.be/Stw0awYWzNo?t=01h47m10s)

[there that somebody could probably build](https://youtu.be/Stw0awYWzNo?t=01h47m12s)

[a nice system around something like that](https://youtu.be/Stw0awYWzNo?t=01h47m14s)

[It feels like it feels kind of nice](https://youtu.be/Stw0awYWzNo?t=01h47m16s)

[because there's a lot of overhead that](https://youtu.be/Stw0awYWzNo?t=01h47m20s)

[goes in for being able to do](https://youtu.be/Stw0awYWzNo?t=01h47m21s)

[um testing and setting up test projects](https://youtu.be/Stw0awYWzNo?t=01h47m26s)

[and making sure everything's referenced](https://youtu.be/Stw0awYWzNo?t=01h47m28s)

[properly and oh well you're in the wrong](https://youtu.be/Stw0awYWzNo?t=01h47m30s)

[name space for that and oh your test](https://youtu.be/Stw0awYWzNo?t=01h47m31s)

[namespace should mirror your the class](https://youtu.be/Stw0awYWzNo?t=01h47m33s)

[under test It's like there's something](https://youtu.be/Stw0awYWzNo?t=01h47m35s)

[to be said about if I could just have a](https://youtu.be/Stw0awYWzNo?t=01h47m37s)

[partial and maybe if I named it you know](https://youtu.be/Stw0awYWzNo?t=01h47m40s)

[test.cs right and have an SDK that would](https://youtu.be/Stw0awYWzNo?t=01h47m43s)

[nicely nest the file for me Like it](https://youtu.be/Stw0awYWzNo?t=01h47m47s)

[feels like that's what I want It feels](https://youtu.be/Stw0awYWzNo?t=01h47m50s)

[like that's like that that feels nice to](https://youtu.be/Stw0awYWzNo?t=01h47m52s)

[me right and then I obviously I would](https://youtu.be/Stw0awYWzNo?t=01h47m55s)

[not want it compiled into my app when I](https://youtu.be/Stw0awYWzNo?t=01h47m58s)

[was actually running So I'd love to be](https://youtu.be/Stw0awYWzNo?t=01h48m00s)

[able to you know be able to do a build](https://youtu.be/Stw0awYWzNo?t=01h48m02s)

[you know d- no tests or maybe d-incclude](https://youtu.be/Stw0awYWzNo?t=01h48m04s)

[tests optin rather than opt out type](https://youtu.be/Stw0awYWzNo?t=01h48m08s)

[situation Okay so the repair dialogue is](https://youtu.be/Stw0awYWzNo?t=01h48m10s)

[the](https://youtu.be/Stw0awYWzNo?t=01h48m13s)

[only only thing that actually does it](https://youtu.be/Stw0awYWzNo?t=01h48m15s)

[where it picks the target](https://youtu.be/Stw0awYWzNo?t=01h48m20s)

[directory Autolocate app](https://youtu.be/Stw0awYWzNo?t=01h48m24s)

[manifest This is the only](https://youtu.be/Stw0awYWzNo?t=01h48m28s)

[one Root path Where did root path come](https://youtu.be/Stw0awYWzNo?t=01h48m32s)

[from show override repair dialogue](https://youtu.be/Stw0awYWzNo?t=01h48m37s)

[Well who invoked](https://youtu.be/Stw0awYWzNo?t=01h48m41s)

[you uh install](https://youtu.be/Stw0awYWzNo?t=01h48m43s)

[did root](https://youtu.be/Stw0awYWzNo?t=01h48m46s)

[path Uh root path](https://youtu.be/Stw0awYWzNo?t=01h48m49s)

[renamed But where did root path come](https://youtu.be/Stw0awYWzNo?t=01h48m55s)

[from install 2 Ah okay Okay I think this](https://youtu.be/Stw0awYWzNo?t=01h48m59s)

[is what we need So install 2 is an](https://youtu.be/Stw0awYWzNo?t=01h49m05s)

[option to the okay it's making more](https://youtu.be/Stw0awYWzNo?t=01h49m07s)

[sense now setup uh so this is something](https://youtu.be/Stw0awYWzNo?t=01h49m11s)

[that most people don't know about and so](https://youtu.be/Stw0awYWzNo?t=01h49m15s)

[don't abuse this knowledge of what I'm](https://youtu.be/Stw0awYWzNo?t=01h49m18s)

[about to share but the um the actual](https://youtu.be/Stw0awYWzNo?t=01h49m19s)

[setup exe that generates does have an](https://youtu.be/Stw0awYWzNo?t=01h49m24s)

[install to option that you can specify](https://youtu.be/Stw0awYWzNo?t=01h49m27s)

[to tell it where to go Oh new to Twitch](https://youtu.be/Stw0awYWzNo?t=01h49m29s)

[watching Thank you for the follow Unless](https://youtu.be/Stw0awYWzNo?t=01h49m33s)

[you're a bot in which case still thank](https://youtu.be/Stw0awYWzNo?t=01h49m36s)

[you](https://youtu.be/Stw0awYWzNo?t=01h49m38s)

[but little less thank you because you're](https://youtu.be/Stw0awYWzNo?t=01h49m39s)

[not real Um but if you are real thank](https://youtu.be/Stw0awYWzNo?t=01h49m42s)

[you So the the setup exe does have an](https://youtu.be/Stw0awYWzNo?t=01h49m44s)

[install to option available and so you](https://youtu.be/Stw0awYWzNo?t=01h49m47s)

[can technically take a Velopac setup.exe](https://youtu.be/Stw0awYWzNo?t=01h49m50s)

[pass the install in install to switch to](https://youtu.be/Stw0awYWzNo?t=01h49m53s)

[it and it'll install to a different](https://youtu.be/Stw0awYWzNo?t=01h49m55s)

[directory Now until my branch gets in](https://youtu.be/Stw0awYWzNo?t=01h49m57s)

[and merges just know that the rest of](https://youtu.be/Stw0awYWzNo?t=01h50m00s)

[the Velopac SDK does not handle](https://youtu.be/Stw0awYWzNo?t=01h50m02s)

[protected directories at all And you](https://youtu.be/Stw0awYWzNo?t=01h50m04s)

[will shoot yourself in the foot But](https://youtu.be/Stw0awYWzNo?t=01h50m07s)

[hypothetically if you said "Oh I don't](https://youtu.be/Stw0awYWzNo?t=01h50m08s)

[want to install to local app uh data I](https://youtu.be/Stw0awYWzNo?t=01h50m10s)

[want to install to you know desktop or](https://youtu.be/Stw0awYWzNo?t=01h50m13s)

[something." As long as it's a writable](https://youtu.be/Stw0awYWzNo?t=01h50m16s)

[directory everything should work just](https://youtu.be/Stw0awYWzNo?t=01h50m18s)

[fine So just be aware of that There's](https://youtu.be/Stw0awYWzNo?t=01h50m21s)

[there's some there's some interesting](https://youtu.be/Stw0awYWzNo?t=01h50m24s)

[stuff but I think what we want](https://youtu.be/Stw0awYWzNo?t=01h50m26s)

[is I want](https://youtu.be/Stw0awYWzNo?t=01h50m29s)

[this I want this but I want this on](https://youtu.be/Stw0awYWzNo?t=01h50m31s)

[update.exe Um because when we](https://youtu.be/Stw0awYWzNo?t=01h50m36s)

[launch](https://youtu.be/Stw0awYWzNo?t=01h50m40s)

[from the temp directory we are going to](https://youtu.be/Stw0awYWzNo?t=01h50m42s)

[need some way of telling it where the](https://youtu.be/Stw0awYWzNo?t=01h50m46s)

[target directory is And I can't have it](https://youtu.be/Stw0awYWzNo?t=01h50m49s)

[I can't have it just infer](https://youtu.be/Stw0awYWzNo?t=01h50m53s)

[uh installation](https://youtu.be/Stw0awYWzNo?t=01h50m57s)

[directory for the](https://youtu.be/Stw0awYWzNo?t=01h51m00s)

[application So we're only going to name](https://youtu.be/Stw0awYWzNo?t=01h51m02s)

[it install two because there's nice](https://youtu.be/Stw0awYWzNo?t=01h51m05s)

[symmetry with the other one and that](https://youtu.be/Stw0awYWzNo?t=01h51m06s)

[makes me feel better Um now we need to](https://youtu.be/Stw0awYWzNo?t=01h51m08s)

[come down here and the apply command](https://youtu.be/Stw0awYWzNo?t=01h51m12s)

[needs to pull that sucker](https://youtu.be/Stw0awYWzNo?t=01h51m16s)

[off Uh let's see here So we need to do](https://youtu.be/Stw0awYWzNo?t=01h51m18s)

[this Need to do](https://youtu.be/Stw0awYWzNo?t=01h51m22s)

[this Uh where did we put it in the](https://youtu.be/Stw0awYWzNo?t=01h51m24s)

[order](https://youtu.be/Stw0awYWzNo?t=01h51m29s)

[199 Uh I put it right after](https://youtu.be/Stw0awYWzNo?t=01h51m31s)

[package Uh that these aren't really in](https://youtu.be/Stw0awYWzNo?t=01h51m35s)

[order I guess Let's](https://youtu.be/Stw0awYWzNo?t=01h51m38s)

[see All](https://youtu.be/Stw0awYWzNo?t=01h51m41s)

[two Uh let's](https://youtu.be/Stw0awYWzNo?t=01h51m43s)

[see All two](https://youtu.be/Stw0awYWzNo?t=01h51m46s)

[That goes there This](https://youtu.be/Stw0awYWzNo?t=01h51m49s)

[goes all](https://youtu.be/Stw0awYWzNo?t=01h51m51s)

[too You should be very afraid I'm](https://youtu.be/Stw0awYWzNo?t=01h51m53s)

[actually slowly getting good at](https://youtu.be/Stw0awYWzNo?t=01h51m56s)

[rust Not great Don't even know if I'm](https://youtu.be/Stw0awYWzNo?t=01h51m59s)

[actually competent yet](https://youtu.be/Stw0awYWzNo?t=01h52m02s)

[but I'm getting to be dangerous I can](https://youtu.be/Stw0awYWzNo?t=01h52m06s)

[build things and I mildly know what I'm](https://youtu.be/Stw0awYWzNo?t=01h52m10s)

[doing Like I now roughly understand](https://youtu.be/Stw0awYWzNo?t=01h52m14s)

[syntax](https://youtu.be/Stw0awYWzNo?t=01h52m17s)

[So that's](https://youtu.be/Stw0awYWzNo?t=01h52m19s)

[exciting](https://youtu.be/Stw0awYWzNo?t=01h52m21s)

[Uh I'm wondering if now that I want to](https://youtu.be/Stw0awYWzNo?t=01h52m26s)

[rename this it's making me question](https://youtu.be/Stw0awYWzNo?t=01h52m29s)

[whether I've picked the right option](https://youtu.be/Stw0awYWzNo?t=01h52m30s)

[name Not my problem right now Not my](https://youtu.be/Stw0awYWzNo?t=01h52m32s)

[problem Not Okay So what we want to do](https://youtu.be/Stw0awYWzNo?t=01h52m34s)

[here](https://youtu.be/Stw0awYWzNo?t=01h52m38s)

[is let's see here the the turnary syntax](https://youtu.be/Stw0awYWzNo?t=01h52m39s)

[for this is I think](https://youtu.be/Stw0awYWzNo?t=01h52m44s)

[if no it's there's no there's none of](https://youtu.be/Stw0awYWzNo?t=01h52m48s)

[this](https://youtu.be/Stw0awYWzNo?t=01h52m51s)

[stuff](https://youtu.be/Stw0awYWzNo?t=01h52m52s)

[if some install to](https://youtu.be/Stw0awYWzNo?t=01h52m54s)

[then I want](https://youtu.be/Stw0awYWzNo?t=01h53m00s)

[this and I](https://youtu.be/Stw0awYWzNo?t=01h53m02s)

[want from specified root](https://youtu.be/Stw0awYWzNo?t=01h53m05s)

[dur oh there's a way to do this There's](https://youtu.be/Stw0awYWzNo?t=01h53m09s)

[a way to do this What is the What is the](https://youtu.be/Stw0awYWzNo?t=01h53m11s)

[turnary thingy on bobber i just saw this](https://youtu.be/Stw0awYWzNo?t=01h53m13s)

[the other day](https://youtu.be/Stw0awYWzNo?t=01h53m16s)

[Um Oh we need to add in](https://youtu.be/Stw0awYWzNo?t=01h53m20s)

[a two to option here](https://youtu.be/Stw0awYWzNo?t=01h53m24s)

[Uh](https://youtu.be/Stw0awYWzNo?t=01h53m27s)

[commas And then we should](https://youtu.be/Stw0awYWzNo?t=01h53m29s)

[probably probably add some tests into](https://youtu.be/Stw0awYWzNo?t=01h53m32s)

[here at some point as well to make sure](https://youtu.be/Stw0awYWzNo?t=01h53m36s)

[it passes properly Um we'll do that in a](https://youtu.be/Stw0awYWzNo?t=01h53m37s)

[moment once we get this thing actually](https://youtu.be/Stw0awYWzNo?t=01h53m40s)

[building Yeah So where where is it i](https://youtu.be/Stw0awYWzNo?t=01h53m43s)

[just I guess this is roughly what we](https://youtu.be/Stw0awYWzNo?t=01h53m50s)

[need to do The is none check](https://youtu.be/Stw0awYWzNo?t=01h53m53s)

[So if salt two is](https://youtu.be/Stw0awYWzNo?t=01h54m00s)

[none](https://youtu.be/Stw0awYWzNo?t=01h54m05s)

[then we're going to](https://youtu.be/Stw0awYWzNo?t=01h54m06s)

[do not this not this We're going to do](https://youtu.be/Stw0awYWzNo?t=01h54m09s)

[this](https://youtu.be/Stw0awYWzNo?t=01h54m14s)

[this Right Um that gets me to there Oh](https://youtu.be/Stw0awYWzNo?t=01h54m19s)

[and I don't do my C# brain is still](https://youtu.be/Stw0awYWzNo?t=01h54m23s)

[on do that](https://youtu.be/Stw0awYWzNo?t=01h54m27s)

[instead](https://youtu.be/Stw0awYWzNo?t=01h54m30s)

[That right](https://youtu.be/Stw0awYWzNo?t=01h54m32s)

[Um](https://youtu.be/Stw0awYWzNo?t=01h54m35s)

[else let locator](https://youtu.be/Stw0awYWzNo?t=01h54m37s)

[uh that is not correct We want to be and](https://youtu.be/Stw0awYWzNo?t=01h54m40s)

[then we want this to be](https://youtu.be/Stw0awYWzNo?t=01h54m43s)

[uh](https://youtu.be/Stw0awYWzNo?t=01h54m47s)

[lo location contacts from specified root](https://youtu.be/Stw0awYWzNo?t=01h54m48s)

[directory](https://youtu.be/Stw0awYWzNo?t=01h54m59s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=01h55m00s)

[Um yeah we don't like the unwrap option](https://youtu.be/Stw0awYWzNo?t=01h55m02s)

[And how do I do this this is why I feel](https://youtu.be/Stw0awYWzNo?t=01h55m06s)

[like I needed that turnary syntax What](https://youtu.be/Stw0awYWzNo?t=01h55m10s)

[was it it](https://youtu.be/Stw0awYWzNo?t=01h55m12s)

[was going to find it now because I know](https://youtu.be/Stw0awYWzNo?t=01h55m16s)

[there's a sample in here where I've done](https://youtu.be/Stw0awYWzNo?t=01h55m19s)

[where I've seen the turnary bits used](https://youtu.be/Stw0awYWzNo?t=01h55m21s)

[Um uh let's](https://youtu.be/Stw0awYWzNo?t=01h55m29s)

[see I guess match would work too because](https://youtu.be/Stw0awYWzNo?t=01h55m31s)

[m](https://youtu.be/Stw0awYWzNo?t=01h55m35s)

[Yeah Where was it wow Bothering me now](https://youtu.be/Stw0awYWzNo?t=01h55m37s)

[Bothering me that I can't think of](https://youtu.be/Stw0awYWzNo?t=01h55m41s)

[it because I'm trying I'm trying to](https://youtu.be/Stw0awYWzNo?t=01h55m44s)

[learn this So not efficient for coding](https://youtu.be/Stw0awYWzNo?t=01h55m47s)

[but much more efficient](https://youtu.be/Stw0awYWzNo?t=01h55m50s)

[Yes Let](https://youtu.be/Stw0awYWzNo?t=01h56m07s)

[uh](https://youtu.be/Stw0awYWzNo?t=01h56m11s)

[locator equals um](https://youtu.be/Stw0awYWzNo?t=01h56m13s)

[uh](https://youtu.be/Stw0awYWzNo?t=01h56m20s)

[L2 is](https://youtu.be/Stw0awYWzNo?t=01h56m22s)

[none](https://youtu.be/Stw0awYWzNo?t=01h56m25s)

[match like this is like I think this](https://youtu.be/Stw0awYWzNo?t=01h56m29s)

[works but](https://youtu.be/Stw0awYWzNo?t=01h56m32s)

[Um so that gets me to](https://youtu.be/Stw0awYWzNo?t=01h56m38s)

[there Uh what are you complaining about](https://youtu.be/Stw0awYWzNo?t=01h56m43s)

[that I'm unclear what I what is](https://youtu.be/Stw0awYWzNo?t=01h57m04s)

[different](https://youtu.be/Stw0awYWzNo?t=01h57m07s)

[Let thingy locator](https://youtu.be/Stw0awYWzNo?t=01h57m09s)

[equal](https://youtu.be/Stw0awYWzNo?t=01h57m24s)

[Um not correct What what but what am I](https://youtu.be/Stw0awYWzNo?t=01h57m35s)

[doing wrong here here When in doubt do](https://youtu.be/Stw0awYWzNo?t=01h57m38s)

[this Do](https://youtu.be/Stw0awYWzNo?t=01h57m43s)

[this I Let's](https://youtu.be/Stw0awYWzNo?t=01h57m45s)

[fix Oh I did it in the wrong](https://youtu.be/Stw0awYWzNo?t=01h57m55s)

[order Ah thank you](https://youtu.be/Stw0awYWzNo?t=01h57m58s)

[co-pilot Thank you](https://youtu.be/Stw0awYWzNo?t=01h58m01s)

[See okay now we have this problem](https://youtu.be/Stw0awYWzNo?t=01h58m04s)

[here Uh let's](https://youtu.be/Stw0awYWzNo?t=01h58m09s)

[see This](https://youtu.be/Stw0awYWzNo?t=01h58m12s)

[wants that Um but uh yeah that goes](https://youtu.be/Stw0awYWzNo?t=01h58m17s)

[there This goes](https://youtu.be/Stw0awYWzNo?t=01h58m23s)

[away Then this is](https://youtu.be/Stw0awYWzNo?t=01h58m26s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=01h58m30s)

[um sum No sum is a cool font This](https://youtu.be/Stw0awYWzNo?t=01h58m32s)

[is stall to is an option and I want to](https://youtu.be/Stw0awYWzNo?t=01h58m39s)

[get I want to pattern match install](https://youtu.be/Stw0awYWzNo?t=01h58m43s)

[Okay Okay Let's do uh](https://youtu.be/Stw0awYWzNo?t=01h58m49s)

[slashfix I want to pattern match](https://youtu.be/Stw0awYWzNo?t=01h58m52s)

[on](https://youtu.be/Stw0awYWzNo?t=01h58m58s)

[to that](https://youtu.be/Stw0awYWzNo?t=01h59m01s)

[when not done it](https://youtu.be/Stw0awYWzNo?t=01h59m05s)

[from](https://youtu.be/Stw0awYWzNo?t=01h59m12s)

[Okay Yeah like that Okay So you don't](https://youtu.be/Stw0awYWzNo?t=01h59m21s)

[call ah okay so this pattern matches the](https://youtu.be/Stw0awYWzNo?t=01h59m26s)

[actual option of path](https://youtu.be/Stw0awYWzNo?t=01h59m29s)

[buffer](https://youtu.be/Stw0awYWzNo?t=01h59m32s)

[Haha Some path buff this gives](https://youtu.be/Stw0awYWzNo?t=01h59m33s)

[Haha Okay See I](https://youtu.be/Stw0awYWzNo?t=01h59m38s)

[learning Thank you co-pilot You've been](https://youtu.be/Stw0awYWzNo?t=01h59m44s)

[a wonderful help Okay So this No you](https://youtu.be/Stw0awYWzNo?t=01h59m46s)

[haven't Mismatch type path buff](https://youtu.be/Stw0awYWzNo?t=01h59m51s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=02h00m03s)

[Uh assume that's the way to do](https://youtu.be/Stw0awYWzNo?t=02h00m08s)

[it Let me just check that](https://youtu.be/Stw0awYWzNo?t=02h00m11s)

[real that how package](https://youtu.be/Stw0awYWzNo?t=02h00m15s)

[This guy still takes](https://youtu.be/Stw0awYWzNo?t=02h00m23s)

[in package](https://youtu.be/Stw0awYWzNo?t=02h00m26s)

[here and then it](https://youtu.be/Stw0awYWzNo?t=02h00m31s)

[gets pulled](https://youtu.be/Stw0awYWzNo?t=02h00m36s)

[apart going to string instead That's not](https://youtu.be/Stw0awYWzNo?t=02h00m40s)

[quite as helpful as would hope Okay but](https://youtu.be/Stw0awYWzNo?t=02h00m44s)

[I think that still works](https://youtu.be/Stw0awYWzNo?t=02h00m48s)

[do wonder if I'm supposed](https://youtu.be/Stw0awYWzNo?t=02h00m54s)

[to I'm still I'm still trying to figure](https://youtu.be/Stw0awYWzNo?t=02h00m56s)

[out the borrower for the](https://youtu.be/Stw0awYWzNo?t=02h00m58s)

[memory That part I'm that part I](https://youtu.be/Stw0awYWzNo?t=02h01m00s)

[struggle](https://youtu.be/Stw0awYWzNo?t=02h01m02s)

[with because I have not fully oxidized](https://youtu.be/Stw0awYWzNo?t=02h01m04s)

[into my rusty syntax yet But this gets a](https://youtu.be/Stw0awYWzNo?t=02h01m07s)

[install to path which will then get a](https://youtu.be/Stw0awYWzNo?t=02h01m13s)

[different locator which then should have](https://youtu.be/Stw0awYWzNo?t=02h01m17s)

[the](https://youtu.be/Stw0awYWzNo?t=02h01m19s)

[apply apply the update](https://youtu.be/Stw0awYWzNo?t=02h01m20s)

[properly Okay So I](https://youtu.be/Stw0awYWzNo?t=02h01m27s)

[think it will just](https://youtu.be/Stw0awYWzNo?t=02h01m30s)

[work Who knows who knows so let's do](https://youtu.be/Stw0awYWzNo?t=02h01m34s)

[this Let's uninstall again Uninstall](https://youtu.be/Stw0awYWzNo?t=02h01m37s)

[again Then we're going to go](https://youtu.be/Stw0awYWzNo?t=02h01m39s)

[back Oh unhappy because it's running](https://youtu.be/Stw0awYWzNo?t=02h01m42s)

[Yeah](https://youtu.be/Stw0awYWzNo?t=02h01m46s)

[Uh yep There you go Have fun Nuke](https://youtu.be/Stw0awYWzNo?t=02h01m51s)

[it And then I would like to go up](https://youtu.be/Stw0awYWzNo?t=02h01m57s)

[here I'm going to blow away my release](https://youtu.be/Stw0awYWzNo?t=02h02m03s)

[of stuff Again I don't have to do this](https://youtu.be/Stw0awYWzNo?t=02h02m05s)

[So I could just keep incrementing my](https://youtu.be/Stw0awYWzNo?t=02h02m07s)

[version number but my brain likes](https://youtu.be/Stw0awYWzNo?t=02h02m08s)

[version](https://youtu.be/Stw0awYWzNo?t=02h02m10s)

[one So you know what we're going with it](https://youtu.be/Stw0awYWzNo?t=02h02m11s)

[Okay now we do this build version](https://youtu.be/Stw0awYWzNo?t=02h02m14s)

[one This will get us an updated Rust](https://youtu.be/Stw0awYWzNo?t=02h02m17s)

[package because you can see there some](https://youtu.be/Stw0awYWzNo?t=02h02m20s)

[point I need to figure out how to handle](https://youtu.be/Stw0awYWzNo?t=02h02m22s)

[this thing I don't fully understand the](https://youtu.be/Stw0awYWzNo?t=02h02m25s)

[warning I understand that it's](https://youtu.be/Stw0awYWzNo?t=02h02m29s)

[complaining about dead code but when I](https://youtu.be/Stw0awYWzNo?t=02h02m31s)

[remove it it shows in you So there's](https://youtu.be/Stw0awYWzNo?t=02h02m33s)

[something I am not grocking about how it](https://youtu.be/Stw0awYWzNo?t=02h02m34s)

[is detecting or I need to suppress it or](https://youtu.be/Stw0awYWzNo?t=02h02m37s)

[something So I'm ignoring it for now](https://youtu.be/Stw0awYWzNo?t=02h02m41s)

[because it's in a code path I don't care](https://youtu.be/Stw0awYWzNo?t=02h02m43s)

[about So but before the PR merges it](https://youtu.be/Stw0awYWzNo?t=02h02m45s)

[will](https://youtu.be/Stw0awYWzNo?t=02h02m48s)

[addressed I think our pipeline gets more](https://youtu.be/Stw0awYWzNo?t=02h02m50s)

[picky about](https://youtu.be/Stw0awYWzNo?t=02h02m53s)

[warnings which is probably a good way of](https://youtu.be/Stw0awYWzNo?t=02h02m54s)

[doing it Your pipelines in general](https://youtu.be/Stw0awYWzNo?t=02h02m57s)

[should be](https://youtu.be/Stw0awYWzNo?t=02h02m59s)

[as they they should they should force](https://youtu.be/Stw0awYWzNo?t=02h03m00s)

[everybody up to a particular](https://youtu.be/Stw0awYWzNo?t=02h03m02s)

[standard And it is okay sometimes to](https://youtu.be/Stw0awYWzNo?t=02h03m07s)

[lower that standard I'll point that](https://youtu.be/Stw0awYWzNo?t=02h03m10s)

[out Like oftentimes people are like "Oh](https://youtu.be/Stw0awYWzNo?t=02h03m12s)

[we want we don't want any PR to merge](https://youtu.be/Stw0awYWzNo?t=02h03m14s)

[unless all the tests pass." It's like](https://youtu.be/Stw0awYWzNo?t=02h03m16s)

["Well yeah but your test suite takes six](https://youtu.be/Stw0awYWzNo?t=02h03m17s)

[hours to run." That's a that's a nice](https://youtu.be/Stw0awYWzNo?t=02h03m19s)

[aspiration but if you also have the](https://youtu.be/Stw0awYWzNo?t=02h03m21s)

[aspiration of releasing quickly that's a](https://youtu.be/Stw0awYWzNo?t=02h03m24s)

[dumb](https://youtu.be/Stw0awYWzNo?t=02h03m26s)

[idea So there's some there's some give](https://youtu.be/Stw0awYWzNo?t=02h03m27s)

[and take and you have to prioritize](https://youtu.be/Stw0awYWzNo?t=02h03m32s)

[accordingly Okay so we got](https://youtu.be/Stw0awYWzNo?t=02h03m33s)

[that and then you should be empty if I](https://youtu.be/Stw0awYWzNo?t=02h03m36s)

[refresh](https://youtu.be/Stw0awYWzNo?t=02h03m40s)

[you Oh this is the temp directory Oh](https://youtu.be/Stw0awYWzNo?t=02h03m44s)

[that's a good point](https://youtu.be/Stw0awYWzNo?t=02h03m48s)

[We should probably have the MSI blow](https://youtu.be/Stw0awYWzNo?t=02h03m50s)

[away the temp directory on](https://youtu.be/Stw0awYWzNo?t=02h03m53s)

[uninstall Add that my](https://youtu.be/Stw0awYWzNo?t=02h03m57s)

[list](https://youtu.be/Stw0awYWzNo?t=02h04m03s)

[Uh](https://youtu.be/Stw0awYWzNo?t=02h04m08s)

[I temp directory](https://youtu.be/Stw0awYWzNo?t=02h04m11s)

[get all that Okay great great great](https://youtu.be/Stw0awYWzNo?t=02h04m25s)

[great great great great Um we are going](https://youtu.be/Stw0awYWzNo?t=02h04m27s)

[to blow away this temp directory because](https://youtu.be/Stw0awYWzNo?t=02h04m29s)

[I don't want anything](https://youtu.be/Stw0awYWzNo?t=02h04m31s)

[interfering Okay release 1.0](https://youtu.be/Stw0awYWzNo?t=02h04m35s)

[MSI Hit](https://youtu.be/Stw0awYWzNo?t=02h04m39s)

[launch](https://youtu.be/Stw0awYWzNo?t=02h04m41s)

[installs program files I should see a](https://youtu.be/Stw0awYWzNo?t=02h04m43s)

[Avalonia Yay And if you're wondering](https://youtu.be/Stw0awYWzNo?t=02h04m48s)

[what this little dotportable is that](https://youtu.be/Stw0awYWzNo?t=02h04m51s)

[right now the MSI is using the same](https://youtu.be/Stw0awYWzNo?t=02h04m53s)

[um package Like we we we've always been](https://youtu.be/Stw0awYWzNo?t=02h04m58s)

[building a portable package but now that](https://youtu.be/Stw0awYWzNo?t=02h05m01s)

[portable package represents the app](https://youtu.be/Stw0awYWzNo?t=02h05m04s)

[contents that that ship with the](https://youtu.be/Stw0awYWzNo?t=02h05m07s)

[MSI Oh that is a good question JC](https://youtu.be/Stw0awYWzNo?t=02h05m12s)

[So go and look at something really quick](https://youtu.be/Stw0awYWzNo?t=02h05m17s)

[before I answer that Before I'm before I](https://youtu.be/Stw0awYWzNo?t=02h05m20s)

[put my whole foot down my mouth Um](https://youtu.be/Stw0awYWzNo?t=02h05m22s)

[uh there's supposed to be](https://youtu.be/Stw0awYWzNo?t=02h05m30s)

[something put](https://youtu.be/Stw0awYWzNo?t=02h05m33s)

[out There's nothing there](https://youtu.be/Stw0awYWzNo?t=02h05m41s)

[So the short version is not good](https://youtu.be/Stw0awYWzNo?t=02h05m45s)

[Um yeah Uh so there there there's a](https://youtu.be/Stw0awYWzNo?t=02h05m54s)

[number of things that have gone on that](https://youtu.be/Stw0awYWzNo?t=02h05m59s)

[are not overly great](https://youtu.be/Stw0awYWzNo?t=02h06m03s)

[Um and a lot of it comes](https://youtu.be/Stw0awYWzNo?t=02h06m06s)

[to the the layoffs that have occurred at](https://youtu.be/Stw0awYWzNo?t=02h06m09s)

[Microsoft over the last like six to nine](https://youtu.be/Stw0awYWzNo?t=02h06m12s)

[months is there was a big kind of](https://youtu.be/Stw0awYWzNo?t=02h06m15s)

[shifting of of people around Some people](https://youtu.be/Stw0awYWzNo?t=02h06m18s)

[got laid off some people got moved on to](https://youtu.be/Stw0awYWzNo?t=02h06m21s)

[other teams](https://youtu.be/Stw0awYWzNo?t=02h06m23s)

[Everybody got bit by the AI bug Um](https://youtu.be/Stw0awYWzNo?t=02h06m25s)

[and that has significantly adversely](https://youtu.be/Stw0awYWzNo?t=02h06m29s)

[affected the system command line stuff](https://youtu.be/Stw0awYWzNo?t=02h06m33s)

[Now you shouldn't be like what's there](https://youtu.be/Stw0awYWzNo?t=02h06m35s)

[is not going to go away because like the](https://youtu.be/Stw0awYWzNo?t=02h06m39s)

[NET SDK is relying on it MS Build is](https://youtu.be/Stw0awYWzNo?t=02h06m42s)

[relying on it Like there there's no way](https://youtu.be/Stw0awYWzNo?t=02h06m45s)

[they can kill it because everything's on](https://youtu.be/Stw0awYWzNo?t=02h06m48s)

[it and they absolutely need to have that](https://youtu.be/Stw0awYWzNo?t=02h06m51s)

[because that kind of stuff is](https://youtu.be/Stw0awYWzNo?t=02h06m54s)

[critical](https://youtu.be/Stw0awYWzNo?t=02h06m57s)

[However they don't have a strong](https://youtu.be/Stw0awYWzNo?t=02h07m00s)

[motivating factor to keep pushing to](https://youtu.be/Stw0awYWzNo?t=02h07m03s)

[getting it all the way like released GA](https://youtu.be/Stw0awYWzNo?t=02h07m06s)

[type Nougat package](https://youtu.be/Stw0awYWzNo?t=02h07m09s)

[So I think that's is probably I sorry I](https://youtu.be/Stw0awYWzNo?t=02h07m12s)

[have a lot of extra information in my](https://youtu.be/Stw0awYWzNo?t=02h07m17s)

[head but I don't think it's public that](https://youtu.be/Stw0awYWzNo?t=02h07m18s)

[I'm allowed to share but I wouldn't](https://youtu.be/Stw0awYWzNo?t=02h07m20s)

[count on like a GA](https://youtu.be/Stw0awYWzNo?t=02h07m23s)

[update this year at](https://youtu.be/Stw0awYWzNo?t=02h07m26s)

[all That would be my my](https://youtu.be/Stw0awYWzNo?t=02h07m29s)

[recommendation So but it's like I said](https://youtu.be/Stw0awYWzNo?t=02h07m33s)

[it's not going anywhere It's it's](https://youtu.be/Stw0awYWzNo?t=02h07m36s)

[absolutely a critical piece Okay So new](https://youtu.be/Stw0awYWzNo?t=02h07m37s)

[beta ID like I like that it does that it](https://youtu.be/Stw0awYWzNo?t=02h07m41s)

[that it outputs where the new staging We](https://youtu.be/Stw0awYWzNo?t=02h07m45s)

[didn't we didn't fix that](https://youtu.be/Stw0awYWzNo?t=02h07m47s)

[Um let me go and look at where that's](https://youtu.be/Stw0awYWzNo?t=02h07m51s)

[writing out](https://youtu.be/Stw0awYWzNo?t=02h07m54s)

[to Uh where is that string](https://youtu.be/Stw0awYWzNo?t=02h08m01s)

[i am I blind or stupid um no stage](https://youtu.be/Stw0awYWzNo?t=02h08m14s)

[Oh no staging user ID there That one Um](https://youtu.be/Stw0awYWzNo?t=02h08m19s)

[uh I think what I want to do](https://youtu.be/Stw0awYWzNo?t=02h08m34s)

[from stage user ID file I want to I I](https://youtu.be/Stw0awYWzNo?t=02h08m39s)

[wanted to include the the file path on](https://youtu.be/Stw0awYWzNo?t=02h08m42s)

[there because that's that's kind of](https://youtu.be/Stw0awYWzNo?t=02h08m46s)

[important especially since the packages](https://youtu.be/Stw0awYWzNo?t=02h08m48s)

[directory we now have moving around a](https://youtu.be/Stw0awYWzNo?t=02h08m50s)

[little bit I it seems kind of important](https://youtu.be/Stw0awYWzNo?t=02h08m52s)

[that we not just throw that thing away](https://youtu.be/Stw0awYWzNo?t=02h08m54s)

[Uh okay So but that's not critical for](https://youtu.be/Stw0awYWzNo?t=02h08m58s)

[this Now we build a second update](https://youtu.be/Stw0awYWzNo?t=02h09m01s)

[package We've got 1.0 installed Produce](https://youtu.be/Stw0awYWzNo?t=02h09m03s)

[1.1 I could technically just roll back](https://youtu.be/Stw0awYWzNo?t=02h09m12s)

[the manifest and swap in files](https://youtu.be/Stw0awYWzNo?t=02h09m14s)

[Eh it's that each time I've been](https://youtu.be/Stw0awYWzNo?t=02h09m19s)

[changing something about the SDK or](https://youtu.be/Stw0awYWzNo?t=02h09m22s)

[similar So it's like probably worth it](https://youtu.be/Stw0awYWzNo?t=02h09m24s)

[So this update](https://youtu.be/Stw0awYWzNo?t=02h09m26s)

[works You should also get to see that](https://youtu.be/Stw0awYWzNo?t=02h09m28s)

[logging change as well](https://youtu.be/Stw0awYWzNo?t=02h09m30s)

[occur because the new version of the app](https://youtu.be/Stw0awYWzNo?t=02h09m33s)

[should have the new version of the](https://youtu.be/Stw0awYWzNo?t=02h09m36s)

[Velopac client library which has the](https://youtu.be/Stw0awYWzNo?t=02h09m38s)

[login change in it](https://youtu.be/Stw0awYWzNo?t=02h09m41s)

[setup](https://youtu.be/Stw0awYWzNo?t=02h09m50s)

[package Come on Go go go little](https://youtu.be/Stw0awYWzNo?t=02h09m58s)

[gadget Go go](https://youtu.be/Stw0awYWzNo?t=02h10m01s)

[go Because as soon as I get this built](https://youtu.be/Stw0awYWzNo?t=02h10m05s)

[I've got I've got some apps that need](https://youtu.be/Stw0awYWzNo?t=02h10m08s)

[this that absolutely need this MSI Okay](https://youtu.be/Stw0awYWzNo?t=02h10m10s)

[so we've got](https://youtu.be/Stw0awYWzNo?t=02h10m14s)

[that We check for updates Find the](https://youtu.be/Stw0awYWzNo?t=02h10m15s)

[update now](https://youtu.be/Stw0awYWzNo?t=02h10m18s)

[Um there are no local base package](https://youtu.be/Stw0awYWzNo?t=02h10m23s)

[available for this update That's](https://youtu.be/Stw0awYWzNo?t=02h10m26s)

[interesting No deltas could be applied](https://youtu.be/Stw0awYWzNo?t=02h10m28s)

[I'm going to add that to the list](https://youtu.be/Stw0awYWzNo?t=02h10m30s)

[Because the MSI doesn't install the base](https://youtu.be/Stw0awYWzNo?t=02h10m32s)

[package it can't apply updates](https://youtu.be/Stw0awYWzNo?t=02h10m36s)

[Um](https://youtu.be/Stw0awYWzNo?t=02h10m39s)

[install slide did I do that too okay So](https://youtu.be/Stw0awYWzNo?t=02h10m45s)

[that will be there We](https://youtu.be/Stw0awYWzNo?t=02h10m50s)

[download Okay So we have](https://youtu.be/Stw0awYWzNo?t=02h10m53s)

[updated cleaning up incomplete delta](https://youtu.be/Stw0awYWzNo?t=02h10m56s)

[packages from directory Good That all](https://youtu.be/Stw0awYWzNo?t=02h10m59s)

[looks](https://youtu.be/Stw0awYWzNo?t=02h11m02s)

[normal Restart and](https://youtu.be/Stw0awYWzNo?t=02h11m04s)

[apply I](https://youtu.be/Stw0awYWzNo?t=02h11m06s)

[think](https://youtu.be/Stw0awYWzNo?t=02h11m08s)

[crossing I don't know if it's going to](https://youtu.be/Stw0awYWzNo?t=02h11m12s)

[work](https://youtu.be/Stw0awYWzNo?t=02h11m15s)

[Um something tells me the answer is no](https://youtu.be/Stw0awYWzNo?t=02h11m18s)

[because that would make sense](https://youtu.be/Stw0awYWzNo?t=02h11m22s)

[Um let's check our log](https://youtu.be/Stw0awYWzNo?t=02h11m28s)

[file Okay So](https://youtu.be/Stw0awYWzNo?t=02h11m35s)

[uh uh why doesn't](https://youtu.be/Stw0awYWzNo?t=02h11m41s)

[uh copy full](https://youtu.be/Stw0awYWzNo?t=02h11m47s)

[name there okay](https://youtu.be/Stw0awYWzNo?t=02h11m49s)

[So app location Oh we didn't pass an app](https://youtu.be/Stw0awYWzNo?t=02h11m59s)

[location And so it's attempting to](https://youtu.be/Stw0awYWzNo?t=02h12m03s)

[locate the app mana Okay So we Okay so](https://youtu.be/Stw0awYWzNo?t=02h12m05s)

[we screwed up by we I mean I So we made](https://youtu.be/Stw0awYWzNo?t=02h12m07s)

[the new option on update.exe but then we](https://youtu.be/Stw0awYWzNo?t=02h12m13s)

[never passed anything to it That is a](https://youtu.be/Stw0awYWzNo?t=02h12m16s)

[problem Uh](https://youtu.be/Stw0awYWzNo?t=02h12m20s)

[okay New collection initializer](https://youtu.be/Stw0awYWzNo?t=02h12m23s)

[Yay I don't know that I like that any](https://youtu.be/Stw0awYWzNo?t=02h12m27s)

[better](https://youtu.be/Stw0awYWzNo?t=02h12m30s)

[Okay So what we need is](https://youtu.be/Stw0awYWzNo?t=02h12m31s)

[this start](https://youtu.be/Stw0awYWzNo?t=02h12m37s)

[call](https://youtu.be/Stw0awYWzNo?t=02h12m39s)

[Um that's not it Let's go to the other](https://youtu.be/Stw0awYWzNo?t=02h12m41s)

[one This](https://youtu.be/Stw0awYWzNo?t=02h12m46s)

[one You're in the past Do you have a](https://youtu.be/Stw0awYWzNo?t=02h12m49s)

[time machine yes Yes I do One of my one](https://youtu.be/Stw0awYWzNo?t=02h12m51s)

[of the perks](https://youtu.be/Stw0awYWzNo?t=02h12m55s)

[Okay So we need to know](https://youtu.be/Stw0awYWzNo?t=02h13m00s)

[uh let's](https://youtu.be/Stw0awYWzNo?t=02h13m07s)

[see We need to know](https://youtu.be/Stw0awYWzNo?t=02h13m09s)

[if if we need to pass a](https://youtu.be/Stw0awYWzNo?t=02h13m13s)

[thing Hey Sir Kitten Black thank you for](https://youtu.be/Stw0awYWzNo?t=02h13m18s)

[the follow I appreciate it Welcome We](https://youtu.be/Stw0awYWzNo?t=02h13m22s)

[are having fun with Velopac tonight or](https://youtu.be/Stw0awYWzNo?t=02h13m26s)

[at least I'm having fun and there are](https://youtu.be/Stw0awYWzNo?t=02h13m28s)

[other people along hopefully enjoying](https://youtu.be/Stw0awYWzNo?t=02h13m30s)

[themselves as](https://youtu.be/Stw0awYWzNo?t=02h13m32s)

[well Um okay So the question though is](https://youtu.be/Stw0awYWzNo?t=02h13m37s)

[how do I](https://youtu.be/Stw0awYWzNo?t=02h13m41s)

[know in the update manager if I need to](https://youtu.be/Stw0awYWzNo?t=02h13m42s)

[pass a different](https://youtu.be/Stw0awYWzNo?t=02h13m48s)

[location](https://youtu.be/Stw0awYWzNo?t=02h13m53s)

[uh no no See JC I think you wanted a](https://youtu.be/Stw0awYWzNo?t=02h14m00s)

[couple hours after the lottery that way](https://youtu.be/Stw0awYWzNo?t=02h14m03s)

[because you know that time machine goes](https://youtu.be/Stw0awYWzNo?t=02h14m05s)

[backwards right i think you want to go](https://youtu.be/Stw0awYWzNo?t=02h14m08s)

[past the announcement and then back to](https://youtu.be/Stw0awYWzNo?t=02h14m11s)

[it I think you get it a few hours before](https://youtu.be/Stw0awYWzNo?t=02h14m13s)

[that just makes it harder to](https://youtu.be/Stw0awYWzNo?t=02h14m16s)

[guess](https://youtu.be/Stw0awYWzNo?t=02h14m19s)

[Uh the question is how do I](https://youtu.be/Stw0awYWzNo?t=02h14m23s)

[know what is the trigger for knowing](https://youtu.be/Stw0awYWzNo?t=02h14m26s)

[whether I need to look somewhere else do](https://youtu.be/Stw0awYWzNo?t=02h14m29s)

[I care could I always just pass](https://youtu.be/Stw0awYWzNo?t=02h14m32s)

[the I could probably always pass the](https://youtu.be/Stw0awYWzNo?t=02h14m35s)

[look](https://youtu.be/Stw0awYWzNo?t=02h14m38s)

[That might be very very](https://youtu.be/Stw0awYWzNo?t=02h14m42s)

[reasonable](https://youtu.be/Stw0awYWzNo?t=02h14m46s)

[because I have the](https://youtu.be/Stw0awYWzNo?t=02h14m48s)

[locator and the](https://youtu.be/Stw0awYWzNo?t=02h14m50s)

[locator has the root app](https://youtu.be/Stw0awYWzNo?t=02h14m52s)

[directory and I think that's where I](https://youtu.be/Stw0awYWzNo?t=02h14m58s)

[want to install to](https://youtu.be/Stw0awYWzNo?t=02h15m00s)

[always I think that's what I always want](https://youtu.be/Stw0awYWzNo?t=02h15m05s)

[to](https://youtu.be/Stw0awYWzNo?t=02h15m09s)

[do So I think what I want to do is I](https://youtu.be/Stw0awYWzNo?t=02h15m10s)

[want to go here and I want to go](https://youtu.be/Stw0awYWzNo?t=02h15m14s)

[args So I'm going to spell it correctly](https://youtu.be/Stw0awYWzNo?t=02h15m17s)

[because that's important Uh and then](https://youtu.be/Stw0awYWzNo?t=02h15m19s)

[we're going to do dash install](https://youtu.be/Stw0awYWzNo?t=02h15m22s)

[to right And we are going to do](https://youtu.be/Stw0awYWzNo?t=02h15m25s)

[args Uh thank you co-pilot for that](https://youtu.be/Stw0awYWzNo?t=02h15m30s)

[lovely comment No I don't care about](https://youtu.be/Stw0awYWzNo?t=02h15m33s)

[that](https://youtu.be/Stw0awYWzNo?t=02h15m35s)

[Um that's what I](https://youtu.be/Stw0awYWzNo?t=02h15m40s)

[want I don't know why it](https://youtu.be/Stw0awYWzNo?t=02h15m47s)

[wouldn't going to require a metric ton](https://youtu.be/Stw0awYWzNo?t=02h15m52s)

[of](https://youtu.be/Stw0awYWzNo?t=02h15m55s)

[testing Conveniently we do actually have](https://youtu.be/Stw0awYWzNo?t=02h15m56s)

[several like full end to end tests](https://youtu.be/Stw0awYWzNo?t=02h16m00s)

[Well I think I can be reasonably](https://youtu.be/Stw0awYWzNo?t=02h16m03s)

[confident if they all pass that I](https://youtu.be/Stw0awYWzNo?t=02h16m06s)

[haven't broken anything too](https://youtu.be/Stw0awYWzNo?t=02h16m08s)

[badly Okay so I](https://youtu.be/Stw0awYWzNo?t=02h16m14s)

[need 1.0 again because paranoia has set](https://youtu.be/Stw0awYWzNo?t=02h16m17s)

[in We will blow this away We will](https://youtu.be/Stw0awYWzNo?t=02h16m21s)

[rebuild](https://youtu.be/Stw0awYWzNo?t=02h16m25s)

[1.0 and hopefully app location doesn't](https://youtu.be/Stw0awYWzNo?t=02h16m28s)

[show none](https://youtu.be/Stw0awYWzNo?t=02h16m30s)

[because that](https://youtu.be/Stw0awYWzNo?t=02h16m45s)

[should](https://youtu.be/Stw0awYWzNo?t=02h16m48s)

[Yeah because it gets the package and](https://youtu.be/Stw0awYWzNo?t=02h16m51s)

[then it'll get the the target app](https://youtu.be/Stw0awYWzNo?t=02h16m54s)

[location And I think it's okay to always](https://youtu.be/Stw0awYWzNo?t=02h16m55s)

[have it specify the target app location](https://youtu.be/Stw0awYWzNo?t=02h16m58s)

[Like I realize in a lot of cases it can](https://youtu.be/Stw0awYWzNo?t=02h17m00s)

[infer](https://youtu.be/Stw0awYWzNo?t=02h17m02s)

[it and I'm okay with it still inferring](https://youtu.be/Stw0awYWzNo?t=02h17m05s)

[it when it's not specified but I don't](https://youtu.be/Stw0awYWzNo?t=02h17m07s)

[know that there's any harm in the client](https://youtu.be/Stw0awYWzNo?t=02h17m09s)

[library always specifying](https://youtu.be/Stw0awYWzNo?t=02h17m12s)

[it I don't know that there's harm in](https://youtu.be/Stw0awYWzNo?t=02h17m16s)

[that because the client library knows](https://youtu.be/Stw0awYWzNo?t=02h17m19s)

[where the app is](https://youtu.be/Stw0awYWzNo?t=02h17m21s)

[at So it kind of makes more sense to me](https://youtu.be/Stw0awYWzNo?t=02h17m24s)

[that it should](https://youtu.be/Stw0awYWzNo?t=02h17m27s)

[pass that through rather than relying on](https://youtu.be/Stw0awYWzNo?t=02h17m30s)

[update EXE to be able to infer it Okay](https://youtu.be/Stw0awYWzNo?t=02h17m33s)

[So let's](https://youtu.be/Stw0awYWzNo?t=02h17m37s)

[make make good sense that we've got it](https://youtu.be/Stw0awYWzNo?t=02h17m38s)

[here Yeah we got that Got that Go ahead](https://youtu.be/Stw0awYWzNo?t=02h17m41s)

[and launch that while it's let's](https://youtu.be/Stw0awYWzNo?t=02h17m45s)

[thinking We're going to start the](https://youtu.be/Stw0awYWzNo?t=02h17m46s)

[build Uh let's see Where' we at where we](https://youtu.be/Stw0awYWzNo?t=02h17m49s)

[at oh we're crashing aren't we](https://youtu.be/Stw0awYWzNo?t=02h17m55s)

[the temp](https://youtu.be/Stw0awYWzNo?t=02h17m59s)

[directory Yeah I need to make uninstall](https://youtu.be/Stw0awYWzNo?t=02h18m04s)

[blow away that temp](https://youtu.be/Stw0awYWzNo?t=02h18m07s)

[directory That's been mildly problematic](https://youtu.be/Stw0awYWzNo?t=02h18m11s)

[Okay there we go No update yet because](https://youtu.be/Stw0awYWzNo?t=02h18m17s)

[our thing hasn't finished down](https://youtu.be/Stw0awYWzNo?t=02h18m20s)

[here Um let's see And I](https://youtu.be/Stw0awYWzNo?t=02h18m25s)

[think let me pull](https://youtu.be/Stw0awYWzNo?t=02h18m29s)

[the whole](https://youtu.be/Stw0awYWzNo?t=02h18m33s)

[uh](https://youtu.be/Stw0awYWzNo?t=02h18m36s)

[uh aside](https://youtu.be/Stw0awYWzNo?t=02h18m39s)

[the I think you can](https://youtu.be/Stw0awYWzNo?t=02h18m42s)

[do down here if I remember right API](https://youtu.be/Stw0awYWzNo?t=02h18m45s)

[reference No Uh let's just search I](https://youtu.be/Stw0awYWzNo?t=02h18m50s)

[think it's remover or remove directory I](https://youtu.be/Stw0awYWzNo?t=02h18m52s)

[think is what it's called](https://youtu.be/Stw0awYWzNo?t=02h18m55s)

[Uh or there is](https://youtu.be/Stw0awYWzNo?t=02h19m01s)

[a remove a folder on all contained files](https://youtu.be/Stw0awYWzNo?t=02h19m08s)

[and folders if the parent component is](https://youtu.be/Stw0awYWzNo?t=02h19m11s)

[selected for installation or](https://youtu.be/Stw0awYWzNo?t=02h19m13s)

[removal Yeah I think this is what we](https://youtu.be/Stw0awYWzNo?t=02h19m20s)

[want](https://youtu.be/Stw0awYWzNo?t=02h19m23s)

[Yeah I think this is what I want](https://youtu.be/Stw0awYWzNo?t=02h19m30s)

[here And then I want to feed it in the](https://youtu.be/Stw0awYWzNo?t=02h19m32s)

[the the temp directory that I'm](https://youtu.be/Stw0awYWzNo?t=02h19m36s)

[creating That way on uninstall it blows](https://youtu.be/Stw0awYWzNo?t=02h19m39s)

[away Okay So check for updates Found it](https://youtu.be/Stw0awYWzNo?t=02h19m42s)

[Great](https://youtu.be/Stw0awYWzNo?t=02h19m44s)

[Download Great Uh re uh let me go back](https://youtu.be/Stw0awYWzNo?t=02h19m46s)

[here real quick I'm just going to in a](https://youtu.be/Stw0awYWzNo?t=02h19m52s)

[effort to not hose my log file I'm just](https://youtu.be/Stw0awYWzNo?t=02h19m54s)

[going to clear it Then we're going to](https://youtu.be/Stw0awYWzNo?t=02h19m57s)

[restart and](https://youtu.be/Stw0awYWzNo?t=02h19m59s)

[apply and](https://youtu.be/Stw0awYWzNo?t=02h20m03s)

[hopefully app location is](https://youtu.be/Stw0awYWzNo?t=02h20m06s)

[set access is denied Okay so it went to](https://youtu.be/Stw0awYWzNo?t=02h20m11s)

[acquire the exclusive lock and didn't](https://youtu.be/Stw0awYWzNo?t=02h20m14s)

[elevate](https://youtu.be/Stw0awYWzNo?t=02h20m17s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=02h20m19s)

[Um](https://youtu.be/Stw0awYWzNo?t=02h20m21s)

[where in this process is it expecting to](https://youtu.be/Stw0awYWzNo?t=02h20m23s)

[elevate because it needs to be](https://youtu.be/Stw0awYWzNo?t=02h20m27s)

[sooner let's see apply because we wrote](https://youtu.be/Stw0awYWzNo?t=02h20m32s)

[the code I thought to](https://youtu.be/Stw0awYWzNo?t=02h20m35s)

[automatically oh so here's the problem](https://youtu.be/Stw0awYWzNo?t=02h20m37s)

[here this guy is the try get exclusive](https://youtu.be/Stw0awYWzNo?t=02h20m40s)

[lock but I think the up The elevation is](https://youtu.be/Stw0awYWzNo?t=02h20m45s)

[in here](https://youtu.be/Stw0awYWzNo?t=02h20m50s)

[somewhere](https://youtu.be/Stw0awYWzNo?t=02h20m54s)

[Um](https://youtu.be/Stw0awYWzNo?t=02h20m57s)

[here Yeah it's right here So apply](https://youtu.be/Stw0awYWzNo?t=02h21m00s)

[package implementation This is probably](https://youtu.be/Stw0awYWzNo?t=02h21m03s)

[not a bad thing to have but this is not](https://youtu.be/Stw0awYWzNo?t=02h21m06s)

[going to work](https://youtu.be/Stw0awYWzNo?t=02h21m10s)

[So because we are looking to acquire](https://youtu.be/Stw0awYWzNo?t=02h21m12s)

[that lock earlier we're going to need to](https://youtu.be/Stw0awYWzNo?t=02h21m15s)

[do it back over](https://youtu.be/Stw0awYWzNo?t=02h21m18s)

[here](https://youtu.be/Stw0awYWzNo?t=02h21m20s)

[Um and maybe the locator should do it](https://youtu.be/Stw0awYWzNo?t=02h21m22s)

[inside of](https://youtu.be/Stw0awYWzNo?t=02h21m25s)

[here Uh let's see Try acquire lock Okay](https://youtu.be/Stw0awYWzNo?t=02h21m28s)

[Lock So this](https://youtu.be/Stw0awYWzNo?t=02h21m32s)

[is this is where it is doing](https://youtu.be/Stw0awYWzNo?t=02h21m33s)

[uh access denied](https://youtu.be/Stw0awYWzNo?t=02h21m38s)

[I think what I want to](https://youtu.be/Stw0awYWzNo?t=02h21m47s)

[do how do I know if](https://youtu.be/Stw0awYWzNo?t=02h21m53s)

[I there's a we wrote a](https://youtu.be/Stw0awYWzNo?t=02h21m56s)

[method in](https://youtu.be/Stw0awYWzNo?t=02h22m00s)

[the shared](https://youtu.be/Stw0awYWzNo?t=02h22m02s)

[area that was](https://youtu.be/Stw0awYWzNo?t=02h22m05s)

[um is path](https://youtu.be/Stw0awYWzNo?t=02h22m09s)

[writable](https://youtu.be/Stw0awYWzNo?t=02h22m12s)

[Uh is](https://youtu.be/Stw0awYWzNo?t=02h22m14s)

[protected Uh let's see files to](https://youtu.be/Stw0awYWzNo?t=02h22m24s)

[include starr](https://youtu.be/Stw0awYWzNo?t=02h22m27s)

[RS Uh let's see here because the](https://youtu.be/Stw0awYWzNo?t=02h22m32s)

[implementation was just](https://youtu.be/Stw0awYWzNo?t=02h22m35s)

[this guy is local machine](https://youtu.be/Stw0awYWzNo?t=02h22m44s)

[install Don't know that that's what I](https://youtu.be/Stw0awYWzNo?t=02h22m47s)

[want to do though I really just want to](https://youtu.be/Stw0awYWzNo?t=02h22m49s)

[say if](https://youtu.be/Stw0awYWzNo?t=02h22m52s)

[it's if I like that quite as](https://youtu.be/Stw0awYWzNo?t=02h22m57s)

[much Um](https://youtu.be/Stw0awYWzNo?t=02h23m01s)

[uh](https://youtu.be/Stw0awYWzNo?t=02h23m14s)

[uh what is what we had it](https://youtu.be/Stw0awYWzNo?t=02h23m19s)

[uh directory writable This is what I](https://youtu.be/Stw0awYWzNo?t=02h23m27s)

[want](https://youtu.be/Stw0awYWzNo?t=02h23m30s)

[This is what I](https://youtu.be/Stw0awYWzNo?t=02h23m34s)

[want Um](https://youtu.be/Stw0awYWzNo?t=02h23m36s)

[here So what I want is this to](https://youtu.be/Stw0awYWzNo?t=02h23m39s)

[here Um the issue being this is not a](https://youtu.be/Stw0awYWzNo?t=02h23m46s)

[Windows only](https://youtu.be/Stw0awYWzNo?t=02h23m51s)

[thing Uh let's see here](https://youtu.be/Stw0awYWzNo?t=02h23m53s)

[Uh there is we can do the the pound iffy](https://youtu.be/Stw0awYWzNo?t=02h24m03s)

[stuff here if we](https://youtu.be/Stw0awYWzNo?t=02h24m07s)

[um that may be the path of least](https://youtu.be/Stw0awYWzNo?t=02h24m10s)

[distance I'm just looking at this](https://youtu.be/Stw0awYWzNo?t=02h24m25s)

[because I'm gonna need this](https://youtu.be/Stw0awYWzNo?t=02h24m28s)

[here I](https://youtu.be/Stw0awYWzNo?t=02h24m32s)

[need that at](https://youtu.be/Stw0awYWzNo?t=02h24m35s)

[least Oh wait Where am](https://youtu.be/Stw0awYWzNo?t=02h24m40s)

[I](https://youtu.be/Stw0awYWzNo?t=02h24m44s)

[oh Oh this might be the This might be](https://youtu.be/Stw0awYWzNo?t=02h24m49s)

[the wrong place Should it be up](https://youtu.be/Stw0awYWzNo?t=02h24m54s)

[here should it be up](https://youtu.be/Stw0awYWzNo?t=02h24m59s)

[here wonder if it should be](https://youtu.be/Stw0awYWzNo?t=02h25m06s)

[um might make slightly more sense up](https://youtu.be/Stw0awYWzNo?t=02h25m14s)

[here rather than down lower](https://youtu.be/Stw0awYWzNo?t=02h25m17s)

[And where is the conditional code for](https://youtu.be/Stw0awYWzNo?t=02h25m25s)

[Windows you do it like an attribute](https://youtu.be/Stw0awYWzNo?t=02h25m28s)

[thingy As you can see yeah this you do](https://youtu.be/Stw0awYWzNo?t=02h25m31s)

[this This used to turn on This is a this](https://youtu.be/Stw0awYWzNo?t=02h25m35s)

[is the rusty equivalent of a pound](https://youtu.be/Stw0awYWzNo?t=02h25m40s)

[if right and then you can do you know](https://youtu.be/Stw0awYWzNo?t=02h25m43s)

[Linux or whatever right but in our case](https://youtu.be/Stw0awYWzNo?t=02h25m46s)

[we're Windows We want to do this So on](https://youtu.be/Stw0awYWzNo?t=02h25m48s)

[Windows and I think what I want to do](https://youtu.be/Stw0awYWzNo?t=02h25m52s)

[is](https://youtu.be/Stw0awYWzNo?t=02h25m56s)

[locator get uh you're a](https://youtu.be/Stw0awYWzNo?t=02h25m58s)

[string I don't remember is this what do](https://youtu.be/Stw0awYWzNo?t=02h26m02s)

[you](https://youtu.be/Stw0awYWzNo?t=02h26m05s)

[take I want uh half buff](https://youtu.be/Stw0awYWzNo?t=02h26m08s)

[there](https://youtu.be/Stw0awYWzNo?t=02h26m15s)

[Um and this is pull on question mark I](https://youtu.be/Stw0awYWzNo?t=02h26m20s)

[think Good luck](https://youtu.be/Stw0awYWzNo?t=02h26m25s)

[Izzy Have a good day at the grindstone](https://youtu.be/Stw0awYWzNo?t=02h26m29s)

[Don't work too hard I will see you in](https://youtu.be/Stw0awYWzNo?t=02h26m31s)

[two](https://youtu.be/Stw0awYWzNo?t=02h26m33s)

[weeks I can count that](https://youtu.be/Stw0awYWzNo?t=02h26m34s)

[high Uh](https://youtu.be/Stw0awYWzNo?t=02h26m37s)

[locator root dur string what I want](https://youtu.be/Stw0awYWzNo?t=02h26m39s)

[Uh let's](https://youtu.be/Stw0awYWzNo?t=02h26m52s)

[see We want to go there I think I think](https://youtu.be/Stw0awYWzNo?t=02h26m55s)

[just doing it here is probably what we](https://youtu.be/Stw0awYWzNo?t=02h26m59s)

[want I](https://youtu.be/Stw0awYWzNo?t=02h27m02s)

[think rather than trying to do it in](https://youtu.be/Stw0awYWzNo?t=02h27m04s)

[here let's let's not do it inside of](https://youtu.be/Stw0awYWzNo?t=02h27m06s)

[the Yeah throw that far](https://youtu.be/Stw0awYWzNo?t=02h27m12s)

[away Thanks Izzy I will I will I well](https://youtu.be/Stw0awYWzNo?t=02h27m20s)

[I'll certainly try to have a good](https://youtu.be/Stw0awYWzNo?t=02h27m24s)

[trip](https://youtu.be/Stw0awYWzNo?t=02h27m27s)

[Uh says there's](https://youtu.be/Stw0awYWzNo?t=02h27m28s)

[red Why do I not see red cargo hurry](https://youtu.be/Stw0awYWzNo?t=02h27m31s)

[up Did I Yeah I was going to say don't](https://youtu.be/Stw0awYWzNo?t=02h27m36s)

[You're lying to me Okay So I think](https://youtu.be/Stw0awYWzNo?t=02h27m39s)

[that will get me there There is a bit of](https://youtu.be/Stw0awYWzNo?t=02h27m44s)

[a sweeping assumption here and that](https://youtu.be/Stw0awYWzNo?t=02h27m47s)

[the is going to be right](https://youtu.be/Stw0awYWzNo?t=02h27m52s)

[But not writable](https://youtu.be/Stw0awYWzNo?t=02h27m58s)

[like if it's not writable I actually](https://youtu.be/Stw0awYWzNo?t=02h28m02s)

[want to](https://youtu.be/Stw0awYWzNo?t=02h28m05s)

[uh](https://youtu.be/Stw0awYWzNo?t=02h28m09s)

[process where uh like I know there's](https://youtu.be/Stw0awYWzNo?t=02h28m12s)

[uh I want to run as](https://youtu.be/Stw0awYWzNo?t=02h28m20s)

[admin where is our call for](https://youtu.be/Stw0awYWzNo?t=02h28m23s)

[that process](https://youtu.be/Stw0awYWzNo?t=02h28m27s)

[elevated restart self as admin there we](https://youtu.be/Stw0awYWzNo?t=02h28m29s)

[So that is what I](https://youtu.be/Stw0awYWzNo?t=02h28m33s)

[want Yeah that's that is what I want So](https://youtu.be/Stw0awYWzNo?t=02h28m37s)

[um process is elevated We'll](https://youtu.be/Stw0awYWzNo?t=02h28m45s)

[bail else we](https://youtu.be/Stw0awYWzNo?t=02h28m48s)

[will relaunch self as admin Going to](https://youtu.be/Stw0awYWzNo?t=02h28m51s)

[need to build the args up for it](https://youtu.be/Stw0awYWzNo?t=02h28m54s)

[And this is actually a good place to do](https://youtu.be/Stw0awYWzNo?t=02h28m58s)

[it because we need we we're going to](https://youtu.be/Stw0awYWzNo?t=02h28m59s)

[need all these args](https://youtu.be/Stw0awYWzNo?t=02h29m01s)

[anyway be able to do](https://youtu.be/Stw0awYWzNo?t=02h29m03s)

[this Um and in this](https://youtu.be/Stw0awYWzNo?t=02h29m06s)

[case I don't think we panic here](https://youtu.be/Stw0awYWzNo?t=02h29m18s)

[but stop helping trying to type](https://youtu.be/Stw0awYWzNo?t=02h29m22s)

[This guy here we need to I know we've](https://youtu.be/Stw0awYWzNo?t=02h29m29s)

[got samples of where I've where we've](https://youtu.be/Stw0awYWzNo?t=02h29m32s)

[built these up before Relaunch self for](https://youtu.be/Stw0awYWzNo?t=02h29m34s)

[admin Yeah basically something that](https://youtu.be/Stw0awYWzNo?t=02h29m36s)

[looks kind of like this And then you](https://youtu.be/Stw0awYWzNo?t=02h29m39s)

[pass args](https://youtu.be/Stw0awYWzNo?t=02h29m42s)

[in](https://youtu.be/Stw0awYWzNo?t=02h29m45s)

[And so we do](https://youtu.be/Stw0awYWzNo?t=02h29m47s)

[this do something like args and then we](https://youtu.be/Stw0awYWzNo?t=02h29m49s)

[question mark which is the the rusty way](https://youtu.be/Stw0awYWzNo?t=02h29m54s)

[of saying uh throw exception on failure](https://youtu.be/Stw0awYWzNo?t=02h29m57s)

[Uh and then](https://youtu.be/Stw0awYWzNo?t=02h30m01s)

[uh](https://youtu.be/Stw0awYWzNo?t=02h30m06s)

[uh relaunched](https://youtu.be/Stw0awYWzNo?t=02h30m08s)

[administrator That'll work Okay So now](https://youtu.be/Stw0awYWzNo?t=02h30m21s)

[we just need the args](https://youtu.be/Stw0awYWzNo?t=02h30m23s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=02h30m25s)

[So](https://youtu.be/Stw0awYWzNo?t=02h30m27s)

[if I think what we can do here is we can](https://youtu.be/Stw0awYWzNo?t=02h30m32s)

[actually just go](https://youtu.be/Stw0awYWzNo?t=02h30m35s)

[But we just need to know what we were](https://youtu.be/Stw0awYWzNo?t=02h30m38s)

[specifying because that is equivalent of](https://youtu.be/Stw0awYWzNo?t=02h30m40s)

[here right So we know we are in the](https://youtu.be/Stw0awYWzNo?t=02h30m45s)

[apply](https://youtu.be/Stw0awYWzNo?t=02h30m48s)

[case to be there So the first thing we](https://youtu.be/Stw0awYWzNo?t=02h30m52s)

[want is args push](https://youtu.be/Stw0awYWzNo?t=02h30m55s)

[uh](https://youtu.be/Stw0awYWzNo?t=02h31m01s)

[apply and we want to get that in there](https://youtu.be/Stw0awYWzNo?t=02h31m02s)

[And then I think silent was being done](https://youtu.be/Stw0awYWzNo?t=02h31m05s)

[earlier See](https://youtu.be/Stw0awYWzNo?t=02h31m14s)

[here I do wonder if maybe it should even](https://youtu.be/Stw0awYWzNo?t=02h31m18s)

[be earlier than](https://youtu.be/Stw0awYWzNo?t=02h31m21s)

[that Well no Let's not get let's not get](https://youtu.be/Stw0awYWzNo?t=02h31m31s)

[too carried away because we need to know](https://youtu.be/Stw0awYWzNo?t=02h31m33s)

[the locator to get the target directory](https://youtu.be/Stw0awYWzNo?t=02h31m34s)

[to know if we need to elevate or not So](https://youtu.be/Stw0awYWzNo?t=02h31m36s)

[let's not get too carried away](https://youtu.be/Stw0awYWzNo?t=02h31m38s)

[Um silent is silent not passed further](https://youtu.be/Stw0awYWzNo?t=02h31m42s)

[down Where did silent get read from get](https://youtu.be/Stw0awYWzNo?t=02h31m47s)

[flag or false on](https://youtu.be/Stw0awYWzNo?t=02h31m50s)

[matches Silent is going to get dropped](https://youtu.be/Stw0awYWzNo?t=02h31m53s)

[in the current setup because we don't](https://youtu.be/Stw0awYWzNo?t=02h31m56s)

[include it](https://youtu.be/Stw0awYWzNo?t=02h31m59s)

[Um but we should be able to get it](https://youtu.be/Stw0awYWzNo?t=02h32m04s)

[because we have the matches here still I](https://youtu.be/Stw0awYWzNo?t=02h32m06s)

[think it's the same](https://youtu.be/Stw0awYWzNo?t=02h32m09s)

[matches Trying to look and see because](https://youtu.be/Stw0awYWzNo?t=02h32m11s)

[silent came from getting the flag or](https://youtu.be/Stw0awYWzNo?t=02h32m14s)

[false from this matches This matches](https://youtu.be/Stw0awYWzNo?t=02h32m18s)

[here gets](https://youtu.be/Stw0awYWzNo?t=02h32m21s)

[parsed into subcommand string subcomand](https://youtu.be/Stw0awYWzNo?t=02h32m23s)

[or](https://youtu.be/Stw0awYWzNo?t=02h32m27s)

[else don't know if this has it on here](https://youtu.be/Stw0awYWzNo?t=02h32m31s)

[or](https://youtu.be/Stw0awYWzNo?t=02h32m34s)

[not Um where else do we pass silent](https://youtu.be/Stw0awYWzNo?t=02h32m36s)

[where where does silent go to](https://youtu.be/Stw0awYWzNo?t=02h32m39s)

[dialogue set](https://youtu.be/Stw0awYWzNo?t=02h32m44s)

[silent and it gets written out and](https://youtu.be/Stw0awYWzNo?t=02h32m47s)

[that's literally the only place Okay](https://youtu.be/Stw0awYWzNo?t=02h32m50s)

[this something we can](https://youtu.be/Stw0awYWzNo?t=02h32m53s)

[read Uh yes get silent](https://youtu.be/Stw0awYWzNo?t=02h32m55s)

[Lovely Uh so if we come down here we can](https://youtu.be/Stw0awYWzNo?t=02h32m59s)

[do if](https://youtu.be/Stw0awYWzNo?t=02h33m04s)

[uh](https://youtu.be/Stw0awYWzNo?t=02h33m07s)

[dialogues get](https://youtu.be/Stw0awYWzNo?t=02h33m09s)

[silent args push silent](https://youtu.be/Stw0awYWzNo?t=02h33m10s)

[Okay](https://youtu.be/Stw0awYWzNo?t=02h33m14s)

[Um](https://youtu.be/Stw0awYWzNo?t=02h33m22s)

[string Okay That goes there That goes](https://youtu.be/Stw0awYWzNo?t=02h33m23s)

[there That goes there Right That's](https://youtu.be/Stw0awYWzNo?t=02h33m26s)

[roughly what we did all the way through](https://youtu.be/Stw0awYWzNo?t=02h33m28s)

[Okay Then after apply I think then we](https://youtu.be/Stw0awYWzNo?t=02h33m32s)

[come in all of the other options So we](https://youtu.be/Stw0awYWzNo?t=02h33m36s)

[have stall to is first](https://youtu.be/Stw0awYWzNo?t=02h33m39s)

[So uh if](https://youtu.be/Stw0awYWzNo?t=02h33m43s)

[uh install](https://youtu.be/Stw0awYWzNo?t=02h33m47s)

[to stop writing](https://youtu.be/Stw0awYWzNo?t=02h33m51s)

[uh is](https://youtu.be/Stw0awYWzNo?t=02h33m58s)

[some right uh let's see that how we](https://youtu.be/Stw0awYWzNo?t=02h34m01s)

[unwrap the path before all to two string](https://youtu.be/Stw0awYWzNo?t=02h34m05s)

[lossy two string](https://youtu.be/Stw0awYWzNo?t=02h34m09s)

[Okay Oh there This is the This is the](https://youtu.be/Stw0awYWzNo?t=02h34m19s)

[magical thingy mabobber That's what I](https://youtu.be/Stw0awYWzNo?t=02h34m23s)

[was looking for That's the pattern](https://youtu.be/Stw0awYWzNo?t=02h34m25s)

[matching syntax I knew I'd seen it](https://youtu.be/Stw0awYWzNo?t=02h34m27s)

[somewhere](https://youtu.be/Stw0awYWzNo?t=02h34m30s)

[There Uh let's](https://youtu.be/Stw0awYWzNo?t=02h34m34s)

[see Local variable](https://youtu.be/Stw0awYWzNo?t=02h34m36s)

[Hold on How is this](https://youtu.be/Stw0awYWzNo?t=02h34m51s)

[working](https://youtu.be/Stw0awYWzNo?t=02h35m07s)

[uh got it This thing should probably](https://youtu.be/Stw0awYWzNo?t=02h35m09s)

[have underscores in it Got it Got it Got](https://youtu.be/Stw0awYWzNo?t=02h35m13s)

[it Got it Got it Okay So we're going to](https://youtu.be/Stw0awYWzNo?t=02h35m16s)

[do that just for just to make them all](https://youtu.be/Stw0awYWzNo?t=02h35m17s)

[match Okay So that goes there That goes](https://youtu.be/Stw0awYWzNo?t=02h35m25s)

[there Goes](https://youtu.be/Stw0awYWzNo?t=02h35m28s)

[there Yep Then we come down here](https://youtu.be/Stw0awYWzNo?t=02h35m31s)

[that](https://youtu.be/Stw0awYWzNo?t=02h35m41s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=02h35m42s)

[um goes like that That goes like that](https://youtu.be/Stw0awYWzNo?t=02h35m50s)

[That goes like](https://youtu.be/Stw0awYWzNo?t=02h35m53s)

[that Okay Great That gets that going](https://youtu.be/Stw0awYWzNo?t=02h35m54s)

[Okay And then we](https://youtu.be/Stw0awYWzNo?t=02h35m58s)

[want package](https://youtu.be/Stw0awYWzNo?t=02h36m00s)

[So](https://youtu.be/Stw0awYWzNo?t=02h36m03s)

[if](https://youtu.be/Stw0awYWzNo?t=02h36m04s)

[let some](https://youtu.be/Stw0awYWzNo?t=02h36m06s)

[package do](https://youtu.be/Stw0awYWzNo?t=02h36m09s)

[that Okay](https://youtu.be/Stw0awYWzNo?t=02h36m18s)

[Then](https://youtu.be/Stw0awYWzNo?t=02h36m21s)

[waited So](https://youtu.be/Stw0awYWzNo?t=02h36m23s)

[if an operation wait I don't know what](https://youtu.be/Stw0awYWzNo?t=02h36m28s)

[to do with that There's an operation](https://youtu.be/Stw0awYWzNo?t=02h36m32s)

[wait the](https://youtu.be/Stw0awYWzNo?t=02h36m37s)

[pit](https://youtu.be/Stw0awYWzNo?t=02h36m39s)

[Um](https://youtu.be/Stw0awYWzNo?t=02h36m42s)

[wait So can I get that value back out of](https://youtu.be/Stw0awYWzNo?t=02h36m50s)

[it i think I](https://youtu.be/Stw0awYWzNo?t=02h36m56s)

[can Uh should install to have an](https://youtu.be/Stw0awYWzNo?t=02h37m00s)

[underscore and setup exe um not So the](https://youtu.be/Stw0awYWzNo?t=02h37m04s)

[only at present no Um there is an](https://youtu.be/Stw0awYWzNo?t=02h37m07s)

[argument to be made that readability the](https://youtu.be/Stw0awYWzNo?t=02h37m12s)

[answer is yes](https://youtu.be/Stw0awYWzNo?t=02h37m14s)

[though right now it's kind of one of](https://youtu.be/Stw0awYWzNo?t=02h37m18s)

[those hidden options that](https://youtu.be/Stw0awYWzNo?t=02h37m19s)

[I I don't expect people actually](https://youtu.be/Stw0awYWzNo?t=02h37m21s)

[leverage because there's a lot of the](https://youtu.be/Stw0awYWzNo?t=02h37m24s)

[um SDK that doesn't really support it at](https://youtu.be/Stw0awYWzNo?t=02h37m28s)

[the](https://youtu.be/Stw0awYWzNo?t=02h37m31s)

[moment So yes but no](https://youtu.be/Stw0awYWzNo?t=02h37m32s)

[Um there's that for the exe but that](https://youtu.be/Stw0awYWzNo?t=02h37m45s)

[doesn't handle the weight So](https://youtu.be/Stw0awYWzNo?t=02h37m49s)

[wait How do I get](https://youtu.be/Stw0awYWzNo?t=02h37m54s)

[out how do I get out](https://youtu.be/Stw0awYWzNo?t=02h38m00s)

[the problem is I've lost](https://youtu.be/Stw0awYWzNo?t=02h38m03s)

[the I've lost](https://youtu.be/Stw0awYWzNo?t=02h38m06s)

[the I've lost the pit on this Get](https://youtu.be/Stw0awYWzNo?t=02h38m13s)

[operation cuz I really want](https://youtu.be/Stw0awYWzNo?t=02h38m18s)

[Because I in this case we're just doing](https://youtu.be/Stw0awYWzNo?t=02h38m32s)

[weight pit What is the actual options up](https://youtu.be/Stw0awYWzNo?t=02h38m33s)

[at the top](https://youtu.be/Stw0awYWzNo?t=02h38m36s)

[allow you'll know this is this is](https://youtu.be/Stw0awYWzNo?t=02h38m41s)

[hidden](https://youtu.be/Stw0awYWzNo?t=02h38m44s)

[Um just wait and](https://youtu.be/Stw0awYWzNo?t=02h38m48s)

[wait How do I do this](https://youtu.be/Stw0awYWzNo?t=02h38m57s)

[well because if weight pit is](https://youtu.be/Stw0awYWzNo?t=02h39m02s)

[specified going to go that route](https://youtu.be/Stw0awYWzNo?t=02h39m05s)

[I think we can This is an enum though](https://youtu.be/Stw0awYWzNo?t=02h39m19s)

[Wait a minute Wait a minute Wait a](https://youtu.be/Stw0awYWzNo?t=02h39m22s)

[minute This is an](https://youtu.be/Stw0awYWzNo?t=02h39m24s)

[enum Oh this is what I want right here](https://youtu.be/Stw0awYWzNo?t=02h39m33s)

[This is what I want](https://youtu.be/Stw0awYWzNo?t=02h39m37s)

[I think what I want to do is](https://youtu.be/Stw0awYWzNo?t=02h39m43s)

[this if wait then we just want to throw](https://youtu.be/Stw0awYWzNo?t=02h39m46s)

[most of this](https://youtu.be/Stw0awYWzNo?t=02h39m51s)

[away because this then becomes arg push](https://youtu.be/Stw0awYWzNo?t=02h39m53s)

[weight id push to string co-pilot you're](https://youtu.be/Stw0awYWzNo?t=02h39m57s)

[you're on point What goes here co-pilot](https://youtu.be/Stw0awYWzNo?t=02h40m00s)

[here I'm gonna help](https://youtu.be/Stw0awYWzNo?t=02h40m04s)

[you Gonna get it](https://youtu.be/Stw0awYWzNo?t=02h40m08s)

[right](https://youtu.be/Stw0awYWzNo?t=02h40m11s)

[I'm](https://youtu.be/Stw0awYWzNo?t=02h40m13s)

[shocked I think it actually did it right](https://youtu.be/Stw0awYWzNo?t=02h40m15s)

[Um is](https://youtu.be/Stw0awYWzNo?t=02h40m19s)

[it](https://youtu.be/Stw0awYWzNo?t=02h40m21s)

[okay](https://youtu.be/Stw0awYWzNo?t=02h40m24s)

[okay that should forward Right We've got](https://youtu.be/Stw0awYWzNo?t=02h40m26s)

[restart Oh we didn't handle](https://youtu.be/Stw0awYWzNo?t=02h40m31s)

[restart Um where did](https://youtu.be/Stw0awYWzNo?t=02h40m35s)

[restart come](https://youtu.be/Stw0awYWzNo?t=02h40m39s)

[from really not handle](https://youtu.be/Stw0awYWzNo?t=02h40m42s)

[that okay What is](https://youtu.be/Stw0awYWzNo?t=02h40m45s)

[restart got it So it's only if restart](https://youtu.be/Stw0awYWzNo?t=02h40m52s)

[is false We specify d- no restart](https://youtu.be/Stw0awYWzNo?t=02h40m55s)

[Got it Okay So](https://youtu.be/Stw0awYWzNo?t=02h40m59s)

[uh seriously](https://youtu.be/Stw0awYWzNo?t=02h41m05s)

[co-pilot thank you Anything else you](https://youtu.be/Stw0awYWzNo?t=02h41m07s)

[want to help me with so we did the](https://youtu.be/Stw0awYWzNo?t=02h41m09s)

[weight we did the the package we did the](https://youtu.be/Stw0awYWzNo?t=02h41m12s)

[app](https://youtu.be/Stw0awYWzNo?t=02h41m17s)

[location which is the install 2 and we](https://youtu.be/Stw0awYWzNo?t=02h41m18s)

[did the event](https://youtu.be/Stw0awYWzNo?t=02h41m21s)

[args I think all of that works](https://youtu.be/Stw0awYWzNo?t=02h41m24s)

[because](https://youtu.be/Stw0awYWzNo?t=02h41m28s)

[this think matches what the lovely](https://youtu.be/Stw0awYWzNo?t=02h41m31s)

[co-pilot did for me](https://youtu.be/Stw0awYWzNo?t=02h41m34s)

[here Yeah](https://youtu.be/Stw0awYWzNo?t=02h41m36s)

[Okay And then this will early exit](https://youtu.be/Stw0awYWzNo?t=02h41m41s)

[because if the directory is not writable](https://youtu.be/Stw0awYWzNo?t=02h41m44s)

[we only have one](https://youtu.be/Stw0awYWzNo?t=02h41m47s)

[option Elevate as](https://youtu.be/Stw0awYWzNo?t=02h41m49s)

[admin or die So okay So I think that](https://youtu.be/Stw0awYWzNo?t=02h41m52s)

[gets us to there Let's go back](https://youtu.be/Stw0awYWzNo?t=02h41m58s)

[and rinse repeat](https://youtu.be/Stw0awYWzNo?t=02h42m02s)

[again Recycle](https://youtu.be/Stw0awYWzNo?t=02h42m07s)

[bin Build 1.0 And then I want to go](https://youtu.be/Stw0awYWzNo?t=02h42m10s)

[torch the temp](https://youtu.be/Stw0awYWzNo?t=02h42m13s)

[directory I don't want that to get in my](https://youtu.be/Stw0awYWzNo?t=02h42m15s)

[way as it has been And then I want to go](https://youtu.be/Stw0awYWzNo?t=02h42m17s)

[here and I want to](https://youtu.be/Stw0awYWzNo?t=02h42m21s)

[uninstall Some point we're going to go](https://youtu.be/Stw0awYWzNo?t=02h42m23s)

[through and get rid of](https://youtu.be/Stw0awYWzNo?t=02h42m25s)

[the I'll have the MSI actually remove](https://youtu.be/Stw0awYWzNo?t=02h42m28s)

[that temp directory from](https://youtu.be/Stw0awYWzNo?t=02h42m31s)

[too It shouldn't be terribly difficult](https://youtu.be/Stw0awYWzNo?t=02h42m35s)

[That is just in](https://youtu.be/Stw0awYWzNo?t=02h42m38s)

[the Windows](https://youtu.be/Stw0awYWzNo?t=02h42m39s)

[pack bit](https://youtu.be/Stw0awYWzNo?t=02h42m43s)

[Um cuz it's just down](https://youtu.be/Stw0awYWzNo?t=02h42m47s)

[here Yeah it's just](https://youtu.be/Stw0awYWzNo?t=02h42m51s)

[generating It's literally just](https://youtu.be/Stw0awYWzNo?t=02h42m57s)

[generating a Wix file and then sending](https://youtu.be/Stw0awYWzNo?t=02h42m58s)

[it That is](https://youtu.be/Stw0awYWzNo?t=02h43m01s)

[all That is all it is](https://youtu.be/Stw0awYWzNo?t=02h43m04s)

[doing Um this is a lie now](https://youtu.be/Stw0awYWzNo?t=02h43m07s)

[Yeah because I I fought with this for a](https://youtu.be/Stw0awYWzNo?t=02h43m17s)

[little bit and then realized that we can](https://youtu.be/Stw0awYWzNo?t=02h43m19s)

[literally just go straight at](https://youtu.be/Stw0awYWzNo?t=02h43m21s)

[Wix Call it a](https://youtu.be/Stw0awYWzNo?t=02h43m22s)

[day and everything just kind of](https://youtu.be/Stw0awYWzNo?t=02h43m27s)

[works Okay so there's](https://youtu.be/Stw0awYWzNo?t=02h43m31s)

[that install in the MSI Sorry I was](https://youtu.be/Stw0awYWzNo?t=02h43m35s)

[trying to drag the thing over and](https://youtu.be/Stw0awYWzNo?t=02h43m38s)

[then program file should have pack](https://youtu.be/Stw0awYWzNo?t=02h43m42s)

[abalonia launch the](https://youtu.be/Stw0awYWzNo?t=02h43m46s)

[bootstrapper and it launches We check](https://youtu.be/Stw0awYWzNo?t=02h43m50s)

[for updates There's nothing there as](https://youtu.be/Stw0awYWzNo?t=02h43m53s)

[expected](https://youtu.be/Stw0awYWzNo?t=02h43m55s)

[Start building one](https://youtu.be/Stw0awYWzNo?t=02h43m57s)

[One And hopefully this time around it](https://youtu.be/Stw0awYWzNo?t=02h44m08s)

[should](https://youtu.be/Stw0awYWzNo?t=02h44m13s)

[prompt It should prompt on the update](https://youtu.be/Stw0awYWzNo?t=02h44m19s)

[exe when it goes to invoke it for the](https://youtu.be/Stw0awYWzNo?t=02h44m22s)

[UAC prompt which is kind of hard for me](https://youtu.be/Stw0awYWzNo?t=02h44m24s)

[to stream](https://youtu.be/Stw0awYWzNo?t=02h44m26s)

[because does my screen black out when my](https://youtu.be/Stw0awYWzNo?t=02h44m28s)

[UAC prompts are popping up i don't know](https://youtu.be/Stw0awYWzNo?t=02h44m31s)

[Like I can't tell what's streaming](https://youtu.be/Stw0awYWzNo?t=02h44m35s)

[because it covers over](https://youtu.be/Stw0awYWzNo?t=02h44m36s)

[everything So I don't I've never](https://youtu.be/Stw0awYWzNo?t=02h44m38s)

[actually gone back and rewatched to look](https://youtu.be/Stw0awYWzNo?t=02h44m41s)

[and see how that actually renders](https://youtu.be/Stw0awYWzNo?t=02h44m43s)

[might have to do that because it feels](https://youtu.be/Stw0awYWzNo?t=02h44m46s)

[like](https://youtu.be/Stw0awYWzNo?t=02h44m50s)

[I I don't know I wonder if it actually](https://youtu.be/Stw0awYWzNo?t=02h44m53s)

[captures that because the UAC prompt is](https://youtu.be/Stw0awYWzNo?t=02h44m56s)

[like above](https://youtu.be/Stw0awYWzNo?t=02h44m58s)

[everything Come on Build Wix build You](https://youtu.be/Stw0awYWzNo?t=02h45m01s)

[are slow Okay Check for exe There we are](https://youtu.be/Stw0awYWzNo?t=02h45m05s)

[Download package Great Restart and apply](https://youtu.be/Stw0awYWzNo?t=02h45m10s)

[UAC prompt](https://youtu.be/Stw0awYWzNo?t=02h45m15s)

[Yes](https://youtu.be/Stw0awYWzNo?t=02h45m18s)

[Uh mildly concerned as to what just](https://youtu.be/Stw0awYWzNo?t=02h45m21s)

[happened but I think it](https://youtu.be/Stw0awYWzNo?t=02h45m25s)

[launched Uh I can see you Okay](https://youtu.be/Stw0awYWzNo?t=02h45m29s)

[Well so the one thing that is](https://youtu.be/Stw0awYWzNo?t=02h45m35s)

[immediately apparent to me is this this](https://youtu.be/Stw0awYWzNo?t=02h45m37s)

[log file here So this log file gets](https://youtu.be/Stw0awYWzNo?t=02h45m39s)

[created](https://youtu.be/Stw0awYWzNo?t=02h45m43s)

[um when](https://youtu.be/Stw0awYWzNo?t=02h45m46s)

[the uh when Vellopac](https://youtu.be/Stw0awYWzNo?t=02h45m47s)

[um is able to write to the applications](https://youtu.be/Stw0awYWzNo?t=02h45m51s)

[directory when it's unable to write to](https://youtu.be/Stw0awYWzNo?t=02h45m53s)

[the applications directory it falls back](https://youtu.be/Stw0awYWzNo?t=02h45m56s)

[and writes the one inside of temp So if](https://youtu.be/Stw0awYWzNo?t=02h45m58s)

[you just hunt vellopac.log](https://youtu.be/Stw0awYWzNo?t=02h46m01s)

[um you will find this file and it is](https://youtu.be/Stw0awYWzNo?t=02h46m04s)

[incredibly valuable um for figuring out](https://youtu.be/Stw0awYWzNo?t=02h46m06s)

[what's going on So this was our last one](https://youtu.be/Stw0awYWzNo?t=02h46m10s)

[right so 2345 is our our new startup one](https://youtu.be/Stw0awYWzNo?t=02h46m12s)

[So location command all this stuff](https://youtu.be/Stw0awYWzNo?t=02h46m16s)

[restart true pid package Boom Uh failed](https://youtu.be/Stw0awYWzNo?t=02h46m18s)

[to open directory for](https://youtu.be/Stw0awYWzNo?t=02h46m23s)

[writing right so which is good because](https://youtu.be/Stw0awYWzNo?t=02h46m25s)

[this is the directory test Access](https://youtu.be/Stw0awYWzNo?t=02h46m27s)

[denied right that's what we expect](https://youtu.be/Stw0awYWzNo?t=02h46m29s)

[Successfully relaunched as](https://youtu.be/Stw0awYWzNo?t=02h46m32s)

[administrator Starting Velopac updator](https://youtu.be/Stw0awYWzNo?t=02h46m34s)

[So this one went through again](https://youtu.be/Stw0awYWzNo?t=02h46m37s)

[Um I feel like I want to add a bit of](https://youtu.be/Stw0awYWzNo?t=02h46m40s)

[log here to say are we elevated but that](https://youtu.be/Stw0awYWzNo?t=02h46m43s)

[that will slow us down](https://youtu.be/Stw0awYWzNo?t=02h46m46s)

[unnecessarily But maybe if like the](https://youtu.be/Stw0awYWzNo?t=02h46m48s)

[verbosity is set high enough we do it or](https://youtu.be/Stw0awYWzNo?t=02h46m50s)

[something Uh let's see](https://youtu.be/Stw0awYWzNo?t=02h46m52s)

[Autolocating app](https://youtu.be/Stw0awYWzNo?t=02h46m54s)

[manifest package](https://youtu.be/Stw0awYWzNo?t=02h46m56s)

[directory failed to wait for process The](https://youtu.be/Stw0awYWzNo?t=02h46m59s)

[parameter is incorrect Continuing](https://youtu.be/Stw0awYWzNo?t=02h47m02s)

[Um this is interesting is like the](https://youtu.be/Stw0awYWzNo?t=02h47m08s)

[reason it probably failed to wait for](https://youtu.be/Stw0awYWzNo?t=02h47m10s)

[process is the source process was](https://youtu.be/Stw0awYWzNo?t=02h47m12s)

[already dead by that point because this](https://youtu.be/Stw0awYWzNo?t=02h47m14s)

[is the the process ID of the Avalonia](https://youtu.be/Stw0awYWzNo?t=02h47m17s)

[app Uh let's see Getting ready fly line](https://youtu.be/Stw0awYWzNo?t=02h47m20s)

[package 101 to current 1.0 Go checking](https://youtu.be/Stw0awYWzNo?t=02h47m24s)

[prerex hooks](https://youtu.be/Stw0awYWzNo?t=02h47m27s)

[success hook executed successfully](https://youtu.be/Stw0awYWzNo?t=02h47m30s)

[checking for running process package](https://youtu.be/Stw0awYWzNo?t=02h47m33s)

[applied about to](https://youtu.be/Stw0awYWzNo?t=02h47m37s)

[launch with arg](https://youtu.be/Stw0awYWzNo?t=02h47m42s)

[zero Um the parameter is](https://youtu.be/Stw0awYWzNo?t=02h47m45s)

[incorrect That's not real](https://youtu.be/Stw0awYWzNo?t=02h47m50s)

[helpful But we got real bloody](https://youtu.be/Stw0awYWzNo?t=02h47m54s)

[far down this](https://youtu.be/Stw0awYWzNo?t=02h47m57s)

[path That's That's pretty good Let](https://youtu.be/Stw0awYWzNo?t=02h48m00s)

[me Let me just manually launch the app](https://youtu.be/Stw0awYWzNo?t=02h48m06s)

[and see what it did](https://youtu.be/Stw0awYWzNo?t=02h48m09s)

[So despite the fact that it](https://youtu.be/Stw0awYWzNo?t=02h48m14s)

[says it failed to launch](https://youtu.be/Stw0awYWzNo?t=02h48m17s)

[um it actually](https://youtu.be/Stw0awYWzNo?t=02h48m23s)

[did it actually where where is it um it](https://youtu.be/Stw0awYWzNo?t=02h48m28s)

[actually did update to 101 So that much](https://youtu.be/Stw0awYWzNo?t=02h48m32s)

[is good So except for the restart it did](https://youtu.be/Stw0awYWzNo?t=02h48m34s)

[pretty good Uh material design zaml are](https://youtu.be/Stw0awYWzNo?t=02h48m37s)

[you dropping net 6 yes at some](https://youtu.be/Stw0awYWzNo?t=02h48m40s)

[point Um I'm not rushing to drop it only](https://youtu.be/Stw0awYWzNo?t=02h48m44s)

[because nothing is prompting me to do so](https://youtu.be/Stw0awYWzNo?t=02h48m48s)

[Um however the moment I run into issues](https://youtu.be/Stw0awYWzNo?t=02h48m52s)

[with like pipelines or similar because](https://youtu.be/Stw0awYWzNo?t=02h48m56s)

[the tooling stops being there and](https://youtu.be/Stw0awYWzNo?t=02h48m58s)

[supported I will probably kill it Um but](https://youtu.be/Stw0awYWzNo?t=02h49m01s)

[at present there's no there's nothing](https://youtu.be/Stw0awYWzNo?t=02h49m05s)

[immediately pushing me to drop net 6 so](https://youtu.be/Stw0awYWzNo?t=02h49m08s)

[I'm not doing so yet This is going to be](https://youtu.be/Stw0awYWzNo?t=02h49m11s)

[one of the weird things](https://youtu.be/Stw0awYWzNo?t=02h49m13s)

[with the way Microsoft is doing their](https://youtu.be/Stw0awYWzNo?t=02h49m15s)

[updates like I want to make sure it's](https://youtu.be/Stw0awYWzNo?t=02h49m18s)

[it's running](https://youtu.be/Stw0awYWzNo?t=02h49m21s)

[supported and I usually have had the](https://youtu.be/Stw0awYWzNo?t=02h49m22s)

[policy of I will support a framework as](https://youtu.be/Stw0awYWzNo?t=02h49m25s)

[long as Microsoft does um and then when](https://youtu.be/Stw0awYWzNo?t=02h49m28s)

[it uh drops out of support](https://youtu.be/Stw0awYWzNo?t=02h49m30s)

[um we'll see how things go Um there is](https://youtu.be/Stw0awYWzNo?t=02h49m34s)

[an](https://youtu.be/Stw0awYWzNo?t=02h49m38s)

[interesting show this off So Hero Devs](https://youtu.be/Stw0awYWzNo?t=02h49m40s)

[uh I believe they got their start with](https://youtu.be/Stw0awYWzNo?t=02h49m45s)

[Angular Um but if we look at their net](https://youtu.be/Stw0awYWzNo?t=02h49m48s)

[one um they they have what they call](https://youtu.be/Stw0awYWzNo?t=02h49m53s)

[their their never- ending support Um I](https://youtu.be/Stw0awYWzNo?t=02h49m56s)

[always see NES and I think of Nintendo](https://youtu.be/Stw0awYWzNo?t=02h50m00s)

[Entertainment System but you know that](https://youtu.be/Stw0awYWzNo?t=02h50m02s)

[could just be age Um but they've got](https://youtu.be/Stw0awYWzNo?t=02h50m04s)

[never-ending support for old versions](https://youtu.be/Stw0awYWzNo?t=02h50m07s)

[of.NET net which is which is interesting](https://youtu.be/Stw0awYWzNo?t=02h50m09s)

[right for people who maybe aren't ready](https://youtu.be/Stw0awYWzNo?t=02h50m13s)

[to do a migration or or can't for some](https://youtu.be/Stw0awYWzNo?t=02h50m16s)

[reason Um this is this is an interesting](https://youtu.be/Stw0awYWzNo?t=02h50m19s)

[alternative I'll put it that way Um yeah](https://youtu.be/Stw0awYWzNo?t=02h50m22s)

[potentially more to come on this front](https://youtu.be/Stw0awYWzNo?t=02h50m26s)

[at some](https://youtu.be/Stw0awYWzNo?t=02h50m28s)

[point So but it it is worth uh checking](https://youtu.be/Stw0awYWzNo?t=02h50m29s)

[them out Net is new to them They they've](https://youtu.be/Stw0awYWzNo?t=02h50m33s)

[I think most people probably know them](https://youtu.be/Stw0awYWzNo?t=02h50m36s)

[from their JavaScript frameworky stuff](https://youtu.be/Stw0awYWzNo?t=02h50m38s)

[Um but they are they're dipping their](https://youtu.be/Stw0awYWzNo?t=02h50m41s)

[toes into the .NET space with at least](https://youtu.be/Stw0awYWzNo?t=02h50m43s)

[.NET 6](https://youtu.be/Stw0awYWzNo?t=02h50m46s)

[support So yeah so not currently killing](https://youtu.be/Stw0awYWzNo?t=02h50m47s)

[it](https://youtu.be/Stw0awYWzNo?t=02h50m50s)

[but I would encourage people to look at](https://youtu.be/Stw0awYWzNo?t=02h50m51s)

[migration options Um because most of the](https://youtu.be/Stw0awYWzNo?t=02h50m54s)

[time if you're on net 6 the difference](https://youtu.be/Stw0awYWzNo?t=02h50m57s)

[between being on net 6 and net 8 is](https://youtu.be/Stw0awYWzNo?t=02h50m59s)

[changing the value in your project](https://youtu.be/Stw0awYWzNo?t=02h51m01s)

[files that easy](https://youtu.be/Stw0awYWzNo?t=02h51m04s)

[So I I realize there may be other](https://youtu.be/Stw0awYWzNo?t=02h51m07s)

[dependencies and things going into it](https://youtu.be/Stw0awYWzNo?t=02h51m10s)

[but if it's just like WPF material](https://youtu.be/Stw0awYWzNo?t=02h51m11s)

[design it's probably the difference](https://youtu.be/Stw0awYWzNo?t=02h51m14s)

[between a six and an eight ignoring](https://youtu.be/Stw0awYWzNo?t=02h51m16s)

[potential other dependencies and](https://youtu.be/Stw0awYWzNo?t=02h51m19s)

[pipelines and all the stuff that goes](https://youtu.be/Stw0awYWzNo?t=02h51m20s)

[along with that So ignoring that](https://youtu.be/Stw0awYWzNo?t=02h51m22s)

[stuff Okay let's find this about to](https://youtu.be/Stw0awYWzNo?t=02h51m26s)

[launch and figure out what the heck we](https://youtu.be/Stw0awYWzNo?t=02h51m29s)

[did](https://youtu.be/Stw0awYWzNo?t=02h51m31s)

[wrong I think we got real real](https://youtu.be/Stw0awYWzNo?t=02h51m32s)

[close Okay](https://youtu.be/Stw0awYWzNo?t=02h51m36s)

[so I assume we came through this start](https://youtu.be/Stw0awYWzNo?t=02h51m40s)

[package](https://youtu.be/Stw0awYWzNo?t=02h51m42s)

[Uh let's](https://youtu.be/Stw0awYWzNo?t=02h51m44s)

[see](https://youtu.be/Stw0awYWzNo?t=02h51m47s)

[string and args and working](https://youtu.be/Stw0awYWzNo?t=02h51m49s)

[directory And we've got three of those](https://youtu.be/Stw0awYWzNo?t=02h51m53s)

[logged Environment probably not relevant](https://youtu.be/Stw0awYWzNo?t=02h51m57s)

[and show window probably not relevant](https://youtu.be/Stw0awYWzNo?t=02h52m01s)

[Um so in our log](https://youtu.be/Stw0awYWzNo?t=02h52m04s)

[then because it did actually walk](https://youtu.be/Stw0awYWzNo?t=02h52m10s)

[through initializing Windows VP pack](https://youtu.be/Stw0awYWzNo?t=02h52m13s)

[locator update .exe and parent directory](https://youtu.be/Stw0awYWzNo?t=02h52m16s)

[locating valid manifest like it did all](https://youtu.be/Stw0awYWzNo?t=02h52m19s)

[the](https://youtu.be/Stw0awYWzNo?t=02h52m22s)

[things and then more](https://youtu.be/Stw0awYWzNo?t=02h52m23s)

[importantly like it even made a package](https://youtu.be/Stw0awYWzNo?t=02h52m26s)

[directory with a temp](https://youtu.be/Stw0awYWzNo?t=02h52m29s)

[directory It's got the lock file in](https://youtu.be/Stw0awYWzNo?t=02h52m31s)

[there Like it did all of the stuff that](https://youtu.be/Stw0awYWzNo?t=02h52m33s)

[it was looking to](https://youtu.be/Stw0awYWzNo?t=02h52m36s)

[do](https://youtu.be/Stw0awYWzNo?t=02h52m42s)

[Okay Was just](https://youtu.be/Stw0awYWzNo?t=02h52m45s)

[this package version applied](https://youtu.be/Stw0awYWzNo?t=02h52m48s)

[successfully about to launch So I want](https://youtu.be/Stw0awYWzNo?t=02h52m50s)

[to just make sure that this is in](https://youtu.be/Stw0awYWzNo?t=02h52m52s)

[fact our call stack](https://youtu.be/Stw0awYWzNo?t=02h52m55s)

[Um I would like to](https://youtu.be/Stw0awYWzNo?t=02h53m00s)

[find this](https://youtu.be/Stw0awYWzNo?t=02h53m03s)

[string Uh let's see](https://youtu.be/Stw0awYWzNo?t=02h53m10s)

[Apply Yeah So it's going to be in](https://youtu.be/Stw0awYWzNo?t=02h53m20s)

[here So package applied successfully if](https://youtu.be/Stw0awYWzNo?t=02h53m24s)

[restart start](https://youtu.be/Stw0awYWzNo?t=02h53m27s)

[package Yeah that works And so the](https://youtu.be/Stw0awYWzNo?t=02h53m31s)

[change here is going to be the](https://youtu.be/Stw0awYWzNo?t=02h53m34s)

[difference in the locator](https://youtu.be/Stw0awYWzNo?t=02h53m36s)

[Um and I wonder](https://youtu.be/Stw0awYWzNo?t=02h53m43s)

[if I wonder](https://youtu.be/Stw0awYWzNo?t=02h53m47s)

[if I'm wondering if this needed to be](https://youtu.be/Stw0awYWzNo?t=02h53m53s)

[escaped The parameter is incorrect Like](https://youtu.be/Stw0awYWzNo?t=02h54m01s)

[that is just not helpful](https://youtu.be/Stw0awYWzNo?t=02h54m04s)

[Um but I am I am wondering if that is](https://youtu.be/Stw0awYWzNo?t=02h54m07s)

[the kicker If that](https://youtu.be/Stw0awYWzNo?t=02h54m10s)

[guy does I don't quite know how to do](https://youtu.be/Stw0awYWzNo?t=02h54m14s)

[that](https://youtu.be/Stw0awYWzNo?t=02h54m22s)

[but let's see what this method's doing](https://youtu.be/Stw0awYWzNo?t=02h54m25s)

[run](https://youtu.be/Stw0awYWzNo?t=02h54m29s)

[process but gets an OS](https://youtu.be/Stw0awYWzNo?t=02h54m31s)

[string gets the .exe](https://youtu.be/Stw0awYWzNo?t=02h54m34s)

[name builds the](https://youtu.be/Stw0awYWzNo?t=02h54m38s)

[args end of the](https://youtu.be/Stw0awYWzNo?t=02h54m48s)

[day Where does where does this](https://youtu.be/Stw0awYWzNo?t=02h54m51s)

[go make command line Oh this scares](https://youtu.be/Stw0awYWzNo?t=02h54m55s)

[me A command](https://youtu.be/Stw0awYWzNo?t=02h54m59s)

[line Always quote the program name So](https://youtu.be/Stw0awYWzNo?t=02h55m05s)

[create process to avoid ambiguity when](https://youtu.be/Stw0awYWzNo?t=02h55m08s)

[the child process](https://youtu.be/Stw0awYWzNo?t=02h55m10s)

[parses We put quotes around arg zero](https://youtu.be/Stw0awYWzNo?t=02h55m22s)

[and then space push in the other](https://youtu.be/Stw0awYWzNo?t=02h55m28s)

[args See the problem is I see something](https://youtu.be/Stw0awYWzNo?t=02h55m40s)

[like this and I'm thinking it's](https://youtu.be/Stw0awYWzNo?t=02h55m43s)

[causing](https://youtu.be/Stw0awYWzNo?t=02h55m46s)

[extra escaping when it otherwise doesn't](https://youtu.be/Stw0awYWzNo?t=02h55m48s)

[need to](https://youtu.be/Stw0awYWzNo?t=02h55m51s)

[Right It's kind of what I'm](https://youtu.be/Stw0awYWzNo?t=02h55m58s)

[thinking because this guy](https://youtu.be/Stw0awYWzNo?t=02h56m01s)

[here is wrapped in single](https://youtu.be/Stw0awYWzNo?t=02h56m04s)

[quotes I think that implies that the](https://youtu.be/Stw0awYWzNo?t=02h56m11s)

[value already has quotes around](https://youtu.be/Stw0awYWzNo?t=02h56m14s)

[it And I am wondering](https://youtu.be/Stw0awYWzNo?t=02h56m19s)

[[Music]](https://youtu.be/Stw0awYWzNo?t=02h56m27s)

[um](https://youtu.be/Stw0awYWzNo?t=02h56m34s)

[encodewide Um let's see here](https://youtu.be/Stw0awYWzNo?t=02h56m40s)

[So I only want](https://youtu.be/Stw0awYWzNo?t=02h56m45s)

[to add](https://youtu.be/Stw0awYWzNo?t=02h56m48s)

[quote quotes if the string doesn't](https://youtu.be/Stw0awYWzNo?t=02h56m51s)

[already have them](https://youtu.be/Stw0awYWzNo?t=02h56m57s)

[I'm wondering if it added another set of](https://youtu.be/Stw0awYWzNo?t=02h57m00s)

[quotes](https://youtu.be/Stw0awYWzNo?t=02h57m14s)

[Um let uh RV](https://youtu.be/Stw0awYWzNo?t=02h57m21s)

[zero get](https://youtu.be/Stw0awYWzNo?t=02h57m26s)

[like I](https://youtu.be/Stw0awYWzNo?t=02h57m29s)

[think I'll see](https://youtu.be/Stw0awYWzNo?t=02h57m37s)

[um](https://youtu.be/Stw0awYWzNo?t=02h57m40s)

[if quit doing](https://youtu.be/Stw0awYWzNo?t=02h57m41s)

[it starts with and I want to do](https://youtu.be/Stw0awYWzNo?t=02h57m48s)

[the this](https://youtu.be/Stw0awYWzNo?t=02h57m51s)

[guy right i](https://youtu.be/Stw0awYWzNo?t=02h57m54s)

[think that's what I](https://youtu.be/Stw0awYWzNo?t=02h58m04s)

[want Format is](https://youtu.be/Stw0awYWzNo?t=02h58m07s)

[uh let's](https://youtu.be/Stw0awYWzNo?t=02h58m14s)

[see the trait](https://youtu.be/Stw0awYWzNo?t=02h58m15s)

[bound Oh so it it](https://youtu.be/Stw0awYWzNo?t=02h58m18s)

[wants more like that](https://youtu.be/Stw0awYWzNo?t=02h58m21s)

[Or actually I think it probably](https://youtu.be/Stw0awYWzNo?t=02h58m25s)

[wants](https://youtu.be/Stw0awYWzNo?t=02h58m28s)

[that Okay Copilot help me uh expects a](https://youtu.be/Stw0awYWzNo?t=02h58m37s)

[string or similar type but is a U8 to](https://youtu.be/Stw0awYWzNo?t=02h58m42s)

[fix](https://youtu.be/Stw0awYWzNo?t=02h58m46s)

[this bit of a bite literal No no no I](https://youtu.be/Stw0awYWzNo?t=02h58m51s)

[actually do want a bite](https://youtu.be/Stw0awYWzNo?t=02h58m55s)

[literal](https://youtu.be/Stw0awYWzNo?t=02h59m01s)

[Close Oh it is happy It's just slow Okay](https://youtu.be/Stw0awYWzNo?t=02h59m03s)

[Um](https://youtu.be/Stw0awYWzNo?t=02h59m09s)

[if ends](https://youtu.be/Stw0awYWzNo?t=02h59m10s)

[with then we'll push that in Thinking](https://youtu.be/Stw0awYWzNo?t=02h59m13s)

[that might be it](https://youtu.be/Stw0awYWzNo?t=02h59m16s)

[There](https://youtu.be/Stw0awYWzNo?t=02h59m17s)

[is based on the log I think it just](https://youtu.be/Stw0awYWzNo?t=02h59m23s)

[added an extra set of quotes where it](https://youtu.be/Stw0awYWzNo?t=02h59m27s)

[didn't](https://youtu.be/Stw0awYWzNo?t=02h59m29s)

[need Then let's look at](https://youtu.be/Stw0awYWzNo?t=02h59m31s)

[the directory](https://youtu.be/Stw0awYWzNo?t=02h59m35s)

[Uh where did that directory get](https://youtu.be/Stw0awYWzNo?t=02h59m39s)

[put working dur is that the only usage](https://youtu.be/Stw0awYWzNo?t=02h59m48s)

[of](https://youtu.be/Stw0awYWzNo?t=02h59m51s)

[it like](https://youtu.be/Stw0awYWzNo?t=03h00m00s)

[it Where do you get](https://youtu.be/Stw0awYWzNo?t=03h00m02s)

[used blind or](https://youtu.be/Stw0awYWzNo?t=03h00m06s)

[stupid ah you get used here on create](https://youtu.be/Stw0awYWzNo?t=03h00m08s)

[process So you're just pass through](https://youtu.be/Stw0awYWzNo?t=03h00m12s)

[You're probably okay but what do you](https://youtu.be/Stw0awYWzNo?t=03h00m14s)

[do i don't know what derpy](https://youtu.be/Stw0awYWzNo?t=03h00m18s)

[is I mean I know what derpy is but I](https://youtu.be/Stw0awYWzNo?t=03h00m21s)

[don't think that's the same as derpy](https://youtu.be/Stw0awYWzNo?t=03h00m24s)

[Um OS string ensure no](https://youtu.be/Stw0awYWzNo?t=03h00m27s)

[nulls This low-level stuff makes my head](https://youtu.be/Stw0awYWzNo?t=03h00m34s)

[hurt Okay let's give this a shot See if](https://youtu.be/Stw0awYWzNo?t=03h00m37s)

[my theory on the quotes is](https://youtu.be/Stw0awYWzNo?t=03h00m41s)

[correct I feel like making the the code](https://youtu.be/Stw0awYWzNo?t=03h00m49s)

[just handle both cases is probably](https://youtu.be/Stw0awYWzNo?t=03h00m52s)

[reasonable](https://youtu.be/Stw0awYWzNo?t=03h00m54s)

[probably I have I I spent a great deal](https://youtu.be/Stw0awYWzNo?t=03h00m57s)

[of time fighting](https://youtu.be/Stw0awYWzNo?t=03h01m00s)

[with command line argument stuff and](https://youtu.be/Stw0awYWzNo?t=03h01m03s)

[quoting and paths and oh dear](https://youtu.be/Stw0awYWzNo?t=03h01m06s)

[heavens I was convinced I had found a](https://youtu.be/Stw0awYWzNo?t=03h01m09s)

[rust bug for a while until I found out](https://youtu.be/Stw0awYWzNo?t=03h01m11s)

[that no it's a wind32 issue and rust is](https://youtu.be/Stw0awYWzNo?t=03h01m13s)

[just surfacing it so that made me feel](https://youtu.be/Stw0awYWzNo?t=03h01m17s)

[warm and fuzzy](https://youtu.be/Stw0awYWzNo?t=03h01m20s)

[Yeah very](https://youtu.be/Stw0awYWzNo?t=03h01m26s)

[very kind of want to put the the MSI](https://youtu.be/Stw0awYWzNo?t=03h01m29s)

[into its own separate thing because the](https://youtu.be/Stw0awYWzNo?t=03h01m34s)

[MSI and I may I may end up just seeing](https://youtu.be/Stw0awYWzNo?t=03h01m37s)

[how long it takes I may go split it out](https://youtu.be/Stw0awYWzNo?t=03h01m40s)

[because it doesn't need to be dependent](https://youtu.be/Stw0awYWzNo?t=03h01m42s)

[on the setup package The MSI is](https://youtu.be/Stw0awYWzNo?t=03h01m44s)

[dependent on the portable package So](https://youtu.be/Stw0awYWzNo?t=03h01m46s)

[once that's](https://youtu.be/Stw0awYWzNo?t=03h01m48s)

[done it can it can rock and roll Okay So](https://youtu.be/Stw0awYWzNo?t=03h01m49s)

[if I go back here and I](https://youtu.be/Stw0awYWzNo?t=03h01m53s)

[relaunch right so we've got](https://youtu.be/Stw0awYWzNo?t=03h01m58s)

[this and then we're going to check for](https://youtu.be/Stw0awYWzNo?t=03h02m01s)

[updates We can see that it did it it did](https://youtu.be/Stw0awYWzNo?t=03h02m05s)

[in fact load out and tell us where it](https://youtu.be/Stw0awYWzNo?t=03h02m09s)

[loaded the](https://youtu.be/Stw0awYWzNo?t=03h02m11s)

[uh the path from Interesting that it](https://youtu.be/Stw0awYWzNo?t=03h02m13s)

[string breaks](https://youtu.be/Stw0awYWzNo?t=03h02m17s)

[there huh kind of a weird string](https://youtu.be/Stw0awYWzNo?t=03h02m19s)

[wrapping](https://youtu.be/Stw0awYWzNo?t=03h02m22s)

[Um found the release](https://youtu.be/Stw0awYWzNo?t=03h02m24s)

[download](https://youtu.be/Stw0awYWzNo?t=03h02m38s)

[Okay So it actually did a delta package](https://youtu.be/Stw0awYWzNo?t=03h02m40s)

[update Hang on That means it did the](https://youtu.be/Stw0awYWzNo?t=03h02m44s)

[delta package update in the temp](https://youtu.be/Stw0awYWzNo?t=03h02m46s)

[directory](https://youtu.be/Stw0awYWzNo?t=03h02m48s)

[Oh that](https://youtu.be/Stw0awYWzNo?t=03h02m51s)

[that Oh that is](https://youtu.be/Stw0awYWzNo?t=03h02m57s)

[clever Ah that does make sense that it](https://youtu.be/Stw0awYWzNo?t=03h02m59s)

[would work that way So the delta](https://youtu.be/Stw0awYWzNo?t=03h03m02s)

[packages they're](https://youtu.be/Stw0awYWzNo?t=03h03m04s)

[small because it goes through and it it](https://youtu.be/Stw0awYWzNo?t=03h03m06s)

[builds up something similar to like a](https://youtu.be/Stw0awYWzNo?t=03h03m10s)

[git patch file but like that's not what](https://youtu.be/Stw0awYWzNo?t=03h03m11s)

[it's doing But this is just conceptually](https://youtu.be/Stw0awYWzNo?t=03h03m14s)

[right but it knows the the binary deltas](https://youtu.be/Stw0awYWzNo?t=03h03m16s)

[between files So the delta uh updates](https://youtu.be/Stw0awYWzNo?t=03h03m19s)

[are much smaller And because it had the](https://youtu.be/Stw0awYWzNo?t=03h03m22s)

[101 package down there it's able to](https://youtu.be/Stw0awYWzNo?t=03h03m25s)

[apply the delta to it and get it and get](https://youtu.be/Stw0awYWzNo?t=03h03m28s)

[that](https://youtu.be/Stw0awYWzNo?t=03h03m31s)

[1.0.1 package up to a](https://youtu.be/Stw0awYWzNo?t=03h03m32s)

[1.0.2](https://youtu.be/Stw0awYWzNo?t=03h03m35s)

[That package move to Yeah it updated Oh](https://youtu.be/Stw0awYWzNo?t=03h03m40s)

[that is okay So when I do restart and](https://youtu.be/Stw0awYWzNo?t=03h03m44s)

[apply what are you going to](https://youtu.be/Stw0awYWzNo?t=03h03m48s)

[do is applying the install It did UAC](https://youtu.be/Stw0awYWzNo?t=03h03m52s)

[prompt Did not launch the app It doesn't](https://youtu.be/Stw0awYWzNo?t=03h04m00s)

[appear Let's scroll down and see if we](https://youtu.be/Stw0awYWzNo?t=03h04m05s)

[see the same error](https://youtu.be/Stw0awYWzNo?t=03h04m07s)

[It's going to be the bottom](https://youtu.be/Stw0awYWzNo?t=03h04m16s)

[one about to launch parameters incorrect](https://youtu.be/Stw0awYWzNo?t=03h04m17s)

[Okay so we figure out](https://youtu.be/Stw0awYWzNo?t=03h04m20s)

[why like what is wrong with](https://youtu.be/Stw0awYWzNo?t=03h04m23s)

[this](https://youtu.be/Stw0awYWzNo?t=03h04m27s)

[Yucka Okay So short version is we got to](https://youtu.be/Stw0awYWzNo?t=03h04m29s)

[get](https://youtu.be/Stw0awYWzNo?t=03h04m32s)

[the we got to get the restarty bits](https://youtu.be/Stw0awYWzNo?t=03h04m36s)

[working](https://youtu.be/Stw0awYWzNo?t=03h04m39s)

[here But I](https://youtu.be/Stw0awYWzNo?t=03h04m41s)

[don't I also wonder if this is supposed](https://youtu.be/Stw0awYWzNo?t=03h04m44s)

[to look like this I don't know I don't](https://youtu.be/Stw0awYWzNo?t=03h04m47s)

[think so](https://youtu.be/Stw0awYWzNo?t=03h04m50s)

[may end up having to add more logging](https://youtu.be/Stw0awYWzNo?t=03h04m58s)

[into this to be able to track it down](https://youtu.be/Stw0awYWzNo?t=03h05m00s)

[because I don't see](https://youtu.be/Stw0awYWzNo?t=03h05m01s)

[it I don't see it We're going to commit](https://youtu.be/Stw0awYWzNo?t=03h05m03s)

[before too uh carried](https://youtu.be/Stw0awYWzNo?t=03h05m06s)

[away JC have a good day at work Thank](https://youtu.be/Stw0awYWzNo?t=03h05m09s)

[you for coming and hanging out Always](https://youtu.be/Stw0awYWzNo?t=03h05m11s)

[good to see](https://youtu.be/Stw0awYWzNo?t=03h05m13s)

[you We're all fine Those are just white](https://youtu.be/Stw0awYWzNo?t=03h05m18s)

[space cleanups](https://youtu.be/Stw0awYWzNo?t=03h05m20s)

[Um actually you know what let's](https://youtu.be/Stw0awYWzNo?t=03h05m25s)

[unstage unstage the process one because](https://youtu.be/Stw0awYWzNo?t=03h05m28s)

[I don't know that I actually want that](https://youtu.be/Stw0awYWzNo?t=03h05m31s)

[change Okay But I do want that](https://youtu.be/Stw0awYWzNo?t=03h05m34s)

[change I do](https://youtu.be/Stw0awYWzNo?t=03h05m38s)

[want this](https://youtu.be/Stw0awYWzNo?t=03h05m41s)

[change I do want this](https://youtu.be/Stw0awYWzNo?t=03h05m45s)

[change Maybe not those two lines](https://youtu.be/Stw0awYWzNo?t=03h05m48s)

[I do want](https://youtu.be/Stw0awYWzNo?t=03h05m53s)

[this I do the extra That's](https://youtu.be/Stw0awYWzNo?t=03h05m55s)

[fine Uh that's](https://youtu.be/Stw0awYWzNo?t=03h06m00s)

[fine That's just deleting dead](https://youtu.be/Stw0awYWzNo?t=03h06m05s)

[code](https://youtu.be/Stw0awYWzNo?t=03h06m09s)

[Okay Uh working](https://youtu.be/Stw0awYWzNo?t=03h06m10s)

[MSI updates Okay So the updates are now](https://youtu.be/Stw0awYWzNo?t=03h06m13s)

[working and flowing and happy and](https://youtu.be/Stw0awYWzNo?t=03h06m17s)

[moving](https://youtu.be/Stw0awYWzNo?t=03h06m22s)

[and we're going to rebase because I like](https://youtu.be/Stw0awYWzNo?t=03h06m24s)

[being on](https://youtu.be/Stw0awYWzNo?t=03h06m27s)

[latest](https://youtu.be/Stw0awYWzNo?t=03h06m29s)

[and is after midnight So we may call it](https://youtu.be/Stw0awYWzNo?t=03h06m31s)

[here for the night and see](https://youtu.be/Stw0awYWzNo?t=03h06m35s)

[that may reach out to to Kalin to have](https://youtu.be/Stw0awYWzNo?t=03h06m40s)

[him check my my stuff and](https://youtu.be/Stw0awYWzNo?t=03h06m43s)

[see Let's see Force push that](https://youtu.be/Stw0awYWzNo?t=03h06m46s)

[sucker You can see long string of](https://youtu.be/Stw0awYWzNo?t=03h06m51s)

[stuff But](https://youtu.be/Stw0awYWzNo?t=03h06m56s)

[um okay But this at least](https://youtu.be/Stw0awYWzNo?t=03h07m00s)

[gets something going So I think I may](https://youtu.be/Stw0awYWzNo?t=03h07m04s)

[call it](https://youtu.be/Stw0awYWzNo?t=03h07m07s)

[there Once again I do appreciate people](https://youtu.be/Stw0awYWzNo?t=03h07m09s)

[coming and hanging out Always like the](https://youtu.be/Stw0awYWzNo?t=03h07m11s)

[new follows Um again no stream next week](https://youtu.be/Stw0awYWzNo?t=03h07m12s)

[So I will be back on in two weeks from](https://youtu.be/Stw0awYWzNo?t=03h07m15s)

[today which is like April 3rd or 4th or](https://youtu.be/Stw0awYWzNo?t=03h07m18s)

[whatever whatever 14 days from now is](https://youtu.be/Stw0awYWzNo?t=03h07m21s)

[for you That's when you can expect to](https://youtu.be/Stw0awYWzNo?t=03h07m24s)

[see me But subtract a few hours Um and](https://youtu.be/Stw0awYWzNo?t=03h07m26s)

[then we will be back on Uh as always](https://youtu.be/Stw0awYWzNo?t=03h07m29s)

[like to tell everybody happy coding See](https://youtu.be/Stw0awYWzNo?t=03h07m32s)

[y'all next time](https://youtu.be/Stw0awYWzNo?t=03h07m34s)

