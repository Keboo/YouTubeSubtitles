[YouTube Video](https://youtu.be/8Hq1aqVfesg)


[okay welcome back everyone I apologize](https://youtu.be/8Hq1aqVfesg?t=00h02m43s)



[for my absence last week during all of](https://youtu.be/8Hq1aqVfesg?t=00h02m48s)



[my travels I was unable to find time to](https://youtu.be/8Hq1aqVfesg?t=00h02m51s)



[actually do any streaming did get some](https://youtu.be/8Hq1aqVfesg?t=00h02m53s)



[coding done but the internet was not as](https://youtu.be/8Hq1aqVfesg?t=00h02m55s)



[I would have liked so we are back today](https://youtu.be/8Hq1aqVfesg?t=00h02m59s)



[it's been apparently way too long since](https://youtu.be/8Hq1aqVfesg?t=00h03m02s)



[I've done much of the material design](https://youtu.be/8Hq1aqVfesg?t=00h03m05s)



[stuff so tonight is going to be a lot of](https://youtu.be/8Hq1aqVfesg?t=00h03m07s)



[catching up on pull requests and issues](https://youtu.be/8Hq1aqVfesg?t=00h03m09s)



[and kind of hammering away on the three](https://youtu.be/8Hq1aqVfesg?t=00h03m12s)



[one oh release I'd like to get it into a](https://youtu.be/8Hq1aqVfesg?t=00h03m15s)



[reasonably good state so that we can get](https://youtu.be/8Hq1aqVfesg?t=00h03m17s)



[that merged in and done so we will see](https://youtu.be/8Hq1aqVfesg?t=00h03m21s)



[how far we get so let's see here click](https://youtu.be/8Hq1aqVfesg?t=00h03m25s)



[the click and I go to that button and](https://youtu.be/8Hq1aqVfesg?t=00h03m31s)



[away we go I'm trying out a new dark](https://youtu.be/8Hq1aqVfesg?t=00h03m35s)



[theme for github so I think it's good](https://youtu.be/8Hq1aqVfesg?t=00h03m38s)



[enough I think it'll work so first pull](https://youtu.be/8Hq1aqVfesg?t=00h03m42s)



[request is an easy one this one is one](https://youtu.be/8Hq1aqVfesg?t=00h03m46s)



[that is automatically generated from our](https://youtu.be/8Hq1aqVfesg?t=00h03m49s)



[Azure pipelines so every night the](https://youtu.be/8Hq1aqVfesg?t=00h03m51s)



[pipeline kicks off goes and does its](https://youtu.be/8Hq1aqVfesg?t=00h03m53s)



[thing and notifies me of new icons that](https://youtu.be/8Hq1aqVfesg?t=00h03m55s)



[it's generated I usually just do a quick](https://youtu.be/8Hq1aqVfesg?t=00h03m58s)



[scan of it to see if it's deleting or](https://youtu.be/8Hq1aqVfesg?t=00h04m00s)



[reading or obsolete in any of the icons](https://youtu.be/8Hq1aqVfesg?t=00h04m03s)



[because that would be something worth](https://youtu.be/8Hq1aqVfesg?t=00h04m05s)



[noting in the release notes because](https://youtu.be/8Hq1aqVfesg?t=00h04m08s)



[that's technically a breaking change but](https://youtu.be/8Hq1aqVfesg?t=00h04m09s)



[in this case it's not so it's an easy](https://youtu.be/8Hq1aqVfesg?t=00h04m12s)



[one so mark it merge it and one done see](https://youtu.be/8Hq1aqVfesg?t=00h04m14s)



[there was one pull request done and I](https://youtu.be/8Hq1aqVfesg?t=00h04m21s)



[suppose yeah we can walk the branch it](https://youtu.be/8Hq1aqVfesg?t=00h04m24s)



[doesn't matter pipeline recreates the](https://youtu.be/8Hq1aqVfesg?t=00h04m25s)



[branch every night if it needs to anyway](https://youtu.be/8Hq1aqVfesg?t=00h04m27s)



[ok so let's figure out where we're at so](https://youtu.be/8Hq1aqVfesg?t=00h04m30s)



[add custom mode to color zone I think we](https://youtu.be/8Hq1aqVfesg?t=00h04m34s)



[looked at this before yes so this was](https://youtu.be/8Hq1aqVfesg?t=00h04m36s)



[one here yeah let's take a look at this](https://youtu.be/8Hq1aqVfesg?t=00h04m40s)



[one because this so the the bug in](https://youtu.be/8Hq1aqVfesg?t=00h04m44s)



[question here comes around the the usage](https://youtu.be/8Hq1aqVfesg?t=00h04m47s)



[of a group box so right now the group](https://youtu.be/8Hq1aqVfesg?t=00h04m49s)



[box header](https://youtu.be/8Hq1aqVfesg?t=00h04m52s)



[as an attached property that gives](https://youtu.be/8Hq1aqVfesg?t=00h04m54s)



[access to the color mode and I should](https://youtu.be/8Hq1aqVfesg?t=00h04m58s)



[say loose color mode because it didn't](https://youtu.be/8Hq1aqVfesg?t=00h05m01s)



[allow you to pick arbitrary colors it](https://youtu.be/8Hq1aqVfesg?t=00h05m03s)



[basically the enum that was exposed just](https://youtu.be/8Hq1aqVfesg?t=00h05m05s)



[gave you access to single theme colors](https://youtu.be/8Hq1aqVfesg?t=00h05m08s)



[and so this exposes it so you can pick](https://youtu.be/8Hq1aqVfesg?t=00h05m13s)



[whatever color you want so let's take a](https://youtu.be/8Hq1aqVfesg?t=00h05m15s)



[look sixteen eleven so I suppose I could](https://youtu.be/8Hq1aqVfesg?t=00h05m17s)



[have just read the text down here let's](https://youtu.be/8Hq1aqVfesg?t=00h05m20s)



[check this guy out and take a look](https://youtu.be/8Hq1aqVfesg?t=00h05m22s)



[because that I had initially reviewed it](https://youtu.be/8Hq1aqVfesg?t=00h05m24s)



[and there was some changes that went in](https://youtu.be/8Hq1aqVfesg?t=00h05m27s)



[and got made and yeah so let's see let's](https://youtu.be/8Hq1aqVfesg?t=00h05m29s)



[see how this goes so first and foremost](https://youtu.be/8Hq1aqVfesg?t=00h05m36s)



[we're just gonna fire this guy up and](https://youtu.be/8Hq1aqVfesg?t=00h05m39s)



[see that it works because I believe one](https://youtu.be/8Hq1aqVfesg?t=00h05m42s)



[of the requests was to add in an example](https://youtu.be/8Hq1aqVfesg?t=00h05m45s)



[into the demo app as part of the review](https://youtu.be/8Hq1aqVfesg?t=00h05m47s)



[you can't run the demo because of a](https://youtu.be/8Hq1aqVfesg?t=00h05m49s)



[runtime error this is interesting I kind](https://youtu.be/8Hq1aqVfesg?t=00h05m52s)



[of want to check this out in the sea](https://youtu.be/8Hq1aqVfesg?t=00h05m58s)



[because I think the demo app should be](https://youtu.be/8Hq1aqVfesg?t=00h06m00s)



[working in if it's not](https://youtu.be/8Hq1aqVfesg?t=00h06m03s)



[that'll be quickly up on the docket to](https://youtu.be/8Hq1aqVfesg?t=00h06m04s)



[get fixed tonight okay so that appeared](https://youtu.be/8Hq1aqVfesg?t=00h06m07s)



[to work this was another thing that got](https://youtu.be/8Hq1aqVfesg?t=00h06m11s)



[merged in that might might adjust some](https://youtu.be/8Hq1aqVfesg?t=00h06m13s)



[of the sizing that looks weird to me](https://youtu.be/8Hq1aqVfesg?t=00h06m16s)



[right](https://youtu.be/8Hq1aqVfesg?t=00h06m18s)



[I don't so the the addition of the](https://youtu.be/8Hq1aqVfesg?t=00h06m20s)



[search box isn't a bad thing](https://youtu.be/8Hq1aqVfesg?t=00h06m23s)



[see group boxes right boom I kind of](https://youtu.be/8Hq1aqVfesg?t=00h06m26s)



[want to adjust it so that when you open](https://youtu.be/8Hq1aqVfesg?t=00h06m29s)



[this focus automatically jumps into that](https://youtu.be/8Hq1aqVfesg?t=00h06m31s)



[text box and then maybe I'd also like to](https://youtu.be/8Hq1aqVfesg?t=00h06m33s)



[Center this guy up right other than that](https://youtu.be/8Hq1aqVfesg?t=00h06m36s)



[like the functionality that was that it](https://youtu.be/8Hq1aqVfesg?t=00h06m39s)



[worked great okay so custom header let's](https://youtu.be/8Hq1aqVfesg?t=00h06m40s)



[take a look at what this guy is so color](https://youtu.be/8Hq1aqVfesg?t=00h06m45s)



[zone assist mode custom background black](https://youtu.be/8Hq1aqVfesg?t=00h06m48s)



[foreground white cool so one this](https://youtu.be/8Hq1aqVfesg?t=00h06m50s)



[clearly appears to work because that is](https://youtu.be/8Hq1aqVfesg?t=00h06m57s)



[set up and that basically is as I would](https://youtu.be/8Hq1aqVfesg?t=00h07m01s)



[expect so let's take a little look here](https://youtu.be/8Hq1aqVfesg?t=00h07m04s)



[at](https://youtu.be/8Hq1aqVfesg?t=00h07m07s)



[what the implementation looks like since](https://youtu.be/8Hq1aqVfesg?t=00h07m08s)



[that's the next most important thing all](https://youtu.be/8Hq1aqVfesg?t=00h07m11s)



[right](https://youtu.be/8Hq1aqVfesg?t=00h07m13s)



[the thing is functional so to](https://youtu.be/8Hq1aqVfesg?t=00h07m14s)



[dudududududududu launches and works this](https://youtu.be/8Hq1aqVfesg?t=00h07m18s)



[is the one we saw so what was this](https://youtu.be/8Hq1aqVfesg?t=00h07m23s)



[change in here](https://youtu.be/8Hq1aqVfesg?t=00h07m25s)



[what was this oh there's a change in the](https://youtu.be/8Hq1aqVfesg?t=00h07m26s)



[color zone ooh that's interesting we've](https://youtu.be/8Hq1aqVfesg?t=00h07m28s)



[got two different spellings of color in](https://youtu.be/8Hq1aqVfesg?t=00h07m40s)



[here see the filter thing caught it use](https://youtu.be/8Hq1aqVfesg?t=00h07m42s)



[custom back foreground colors so this is](https://youtu.be/8Hq1aqVfesg?t=00h07m46s)



[fine all right that flows through and](https://youtu.be/8Hq1aqVfesg?t=00h07m52s)



[works okay so let's let's go back to](https://youtu.be/8Hq1aqVfesg?t=00h07m59s)



[here so okay so step one the color zone](https://youtu.be/8Hq1aqVfesg?t=00h08m04s)



[one has been reviewed the group box one](https://youtu.be/8Hq1aqVfesg?t=00h08m08s)



[has been reviewed great great great so](https://youtu.be/8Hq1aqVfesg?t=00h08m10s)



[we added a new one here and this guy](https://youtu.be/8Hq1aqVfesg?t=00h08m12s)



[here fixed some of the text great white](https://youtu.be/8Hq1aqVfesg?t=00h08m17s)



[space change white space change actually](https://youtu.be/8Hq1aqVfesg?t=00h08m20s)



[can we just hide white space changes](https://youtu.be/8Hq1aqVfesg?t=00h08m21s)



[apply and reload alright because most of](https://youtu.be/8Hq1aqVfesg?t=00h08m25s)



[the time I don't care about I don't care](https://youtu.be/8Hq1aqVfesg?t=00h08m28s)



[about white space changes unless they're](https://youtu.be/8Hq1aqVfesg?t=00h08m31s)



[egregious so okay so where we add so](https://youtu.be/8Hq1aqVfesg?t=00h08m33s)



[color zone assist this is the background](https://youtu.be/8Hq1aqVfesg?t=00h08m37s)



[property into here get set the key](https://youtu.be/8Hq1aqVfesg?t=00h08m40s)



[things to check her to make sure that](https://youtu.be/8Hq1aqVfesg?t=00h08m43s)



[the dependency property is properly](https://youtu.be/8Hq1aqVfesg?t=00h08m45s)



[assigned in here](https://youtu.be/8Hq1aqVfesg?t=00h08m48s)



[this guy is set up as inherits well](https://youtu.be/8Hq1aqVfesg?t=00h08m50s)



[double check I in general so this isn't](https://youtu.be/8Hq1aqVfesg?t=00h08m54s)



[necessarily a bad thing the only](https://youtu.be/8Hq1aqVfesg?t=00h08m56s)



[drawback is this could be performance](https://youtu.be/8Hq1aqVfesg?t=00h08m58s)



[implications if this thing has to](https://youtu.be/8Hq1aqVfesg?t=00h09m02s)



[propagate down because ones that inherit](https://youtu.be/8Hq1aqVfesg?t=00h09m03s)



[it obviously has to search the tree for](https://youtu.be/8Hq1aqVfesg?t=00h09m05s)



[versus just straight up but sometimes](https://youtu.be/8Hq1aqVfesg?t=00h09m08s)



[they are required to get things down](https://youtu.be/8Hq1aqVfesg?t=00h09m10s)



[okay you know that looks that looks fine](https://youtu.be/8Hq1aqVfesg?t=00h09m12s)



[to me I don't see anything the the](https://youtu.be/8Hq1aqVfesg?t=00h09m16s)



[parent type is set appropriately](https://youtu.be/8Hq1aqVfesg?t=00h09m19s)



[these types are set appropriately great](https://youtu.be/8Hq1aqVfesg?t=00h09m21s)



[let's see so we've got a new trigger set](https://youtu.be/8Hq1aqVfesg?t=00h09m24s)



[on mode custom and this is inside of the](https://youtu.be/8Hq1aqVfesg?t=00h09m27s)



[I believe this must be the group box](https://youtu.be/8Hq1aqVfesg?t=00h09m32s)



[template let's or is this the color zone](https://youtu.be/8Hq1aqVfesg?t=00h09m34s)



[one colour zone okay so when it's set to](https://youtu.be/8Hq1aqVfesg?t=00h09m37s)



[custom it goes and pulls from the color](https://youtu.be/8Hq1aqVfesg?t=00h09m45s)



[zone assist great wait how does group](https://youtu.be/8Hq1aqVfesg?t=00h09m49s)



[box oh because that wait I'm confused I](https://youtu.be/8Hq1aqVfesg?t=00h09m58s)



[expected to know I have to go look I'm](https://youtu.be/8Hq1aqVfesg?t=00h10m09s)



[curious how the group box was able to](https://youtu.be/8Hq1aqVfesg?t=00h10m13s)



[pick that up](https://youtu.be/8Hq1aqVfesg?t=00h10m15s)



[oh I bet you that's the key with the](https://youtu.be/8Hq1aqVfesg?t=00h10m16s)



[inherent alright if the property](https://youtu.be/8Hq1aqVfesg?t=00h10m21s)



[inherits down the group box could just](https://youtu.be/8Hq1aqVfesg?t=00h10m24s)



[magically pick it up let's take a look](https://youtu.be/8Hq1aqVfesg?t=00h10m26s)



[here and see cuz I'm bettin that's how](https://youtu.be/8Hq1aqVfesg?t=00h10m30s)



[it how it's doing it because the group](https://youtu.be/8Hq1aqVfesg?t=00h10m31s)



[box itself has a color zone here](https://youtu.be/8Hq1aqVfesg?t=00h10m34s)



[doo-doo-doo-doo-doo-doo-doo and because](https://youtu.be/8Hq1aqVfesg?t=00h10m41s)



[the the mode is propagated down](https://youtu.be/8Hq1aqVfesg?t=00h10m43s)



[that's interesting I am tempted to do](https://youtu.be/8Hq1aqVfesg?t=00h10m53s)



[something a little different though](https://youtu.be/8Hq1aqVfesg?t=00h10m56s)



[alright so this guy here let's let's](https://youtu.be/8Hq1aqVfesg?t=00h11m01s)



[take a quick look didn't see generic](https://youtu.be/8Hq1aqVfesg?t=00h11m05s)



[contains the color zone so let's go find](https://youtu.be/8Hq1aqVfesg?t=00h11m10s)



[this guy really want to that's something](https://youtu.be/8Hq1aqVfesg?t=00h11m13s)



[I should asked next time I talked to the](https://youtu.be/8Hq1aqVfesg?t=00h11m17s)



[zamel team I want to I want to be able](https://youtu.be/8Hq1aqVfesg?t=00h11m21s)



[to go control mo just like I do in](https://youtu.be/8Hq1aqVfesg?t=00h11m24s)



[c-sharp and collapse everything down to](https://youtu.be/8Hq1aqVfesg?t=00h11m26s)



[definitions that would be a wonderful](https://youtu.be/8Hq1aqVfesg?t=00h11m28s)



[feature in my mind okay but I digress](https://youtu.be/8Hq1aqVfesg?t=00h11m30s)



[the important part here is how this guy](https://youtu.be/8Hq1aqVfesg?t=00h11m34s)



[is set up so this guy is just looking](https://youtu.be/8Hq1aqVfesg?t=00h11m36s)



[for it on here directly I think what we](https://youtu.be/8Hq1aqVfesg?t=00h11m38s)



[do is we and this guy's using the color](https://youtu.be/8Hq1aqVfesg?t=00h11m43s)



[zone assist yeah to pick it up okay so I](https://youtu.be/8Hq1aqVfesg?t=00h11m45s)



[think we do the same thing in group box](https://youtu.be/8Hq1aqVfesg?t=00h11m50s)



[right because I think what I'd like to](https://youtu.be/8Hq1aqVfesg?t=00h11m51s)



[do is turn off the inherit so that it's](https://youtu.be/8Hq1aqVfesg?t=00h11m52s)



[not needed so this guy ends up looking](https://youtu.be/8Hq1aqVfesg?t=00h11m55s)



[something in akin to let's see color](https://youtu.be/8Hq1aqVfesg?t=00h12m00s)



[zone assist go ahead and include gets](https://youtu.be/8Hq1aqVfesg?t=00h12m03s)



[let's see this is going to need to be a](https://youtu.be/8Hq1aqVfesg?t=00h12m08s)



[relative source binding because it is](https://youtu.be/8Hq1aqVfesg?t=00h12m12s)



[using an attached property so it's](https://youtu.be/8Hq1aqVfesg?t=00h12m15s)



[basically the same as this right so the](https://youtu.be/8Hq1aqVfesg?t=00h12m18s)



[relative source of this of this color](https://youtu.be/8Hq1aqVfesg?t=00h12m20s)



[zone is going to go up to the templated](https://youtu.be/8Hq1aqVfesg?t=00h12m23s)



[parent which in this case will be the](https://youtu.be/8Hq1aqVfesg?t=00h12m25s)



[group box and we'll search the group box](https://youtu.be/8Hq1aqVfesg?t=00h12m26s)



[for the color zone assist background](https://youtu.be/8Hq1aqVfesg?t=00h12m29s)



[alright and then we'll do the same thing](https://youtu.be/8Hq1aqVfesg?t=00h12m33s)



[for the foreground](https://youtu.be/8Hq1aqVfesg?t=00h12m36s)



[and then I think what I'd like to do is](https://youtu.be/8Hq1aqVfesg?t=00h12m42s)



[jump over to these properties and not](https://youtu.be/8Hq1aqVfesg?t=00h12m45s)



[have it inherit all right because now it](https://youtu.be/8Hq1aqVfesg?t=00h12m50s)



[shouldn't inherit and it shouldn't need](https://youtu.be/8Hq1aqVfesg?t=00h12m56s)



[to because we're effectively propagating](https://youtu.be/8Hq1aqVfesg?t=00h12m59s)



[those things down into the two cases it](https://youtu.be/8Hq1aqVfesg?t=00h13m01s)



[doesn't mean there might be other cases](https://youtu.be/8Hq1aqVfesg?t=00h13m03s)



[where if somebody was hoping to set this](https://youtu.be/8Hq1aqVfesg?t=00h13m04s)



[at like the window level and have a](https://youtu.be/8Hq1aqVfesg?t=00h13m06s)



[propagate down into all of them that](https://youtu.be/8Hq1aqVfesg?t=00h13m08s)



[would break but this is an emergent](https://youtu.be/8Hq1aqVfesg?t=00h13m09s)



[Cline to take that approach if you want](https://youtu.be/8Hq1aqVfesg?t=00h13m14s)



[something to propagate all the way down](https://youtu.be/8Hq1aqVfesg?t=00h13m16s)



[like that a better approaches an](https://youtu.be/8Hq1aqVfesg?t=00h13m17s)



[implicit style targeting the color zone](https://youtu.be/8Hq1aqVfesg?t=00h13m19s)



[let's see so let's just check them all I](https://youtu.be/8Hq1aqVfesg?t=00h13m23s)



[want to really need to clean that up ok](https://youtu.be/8Hq1aqVfesg?t=00h13m28s)



[so this guy worked still great that's](https://youtu.be/8Hq1aqVfesg?t=00h13m30s)



[sort of as expected and then the group](https://youtu.be/8Hq1aqVfesg?t=00h13m33s)



[box is the one where it's most likely to](https://youtu.be/8Hq1aqVfesg?t=00h13m35s)



[break what that guy got populated I](https://youtu.be/8Hq1aqVfesg?t=00h13m37s)



[think I like that a little better a](https://youtu.be/8Hq1aqVfesg?t=00h13m39s)



[little simpler and we'll call it good so](https://youtu.be/8Hq1aqVfesg?t=00h13m42s)



[let's just take these changes see](https://youtu.be/8Hq1aqVfesg?t=00h13m47s)



[adjusting to avoid meeting properties to](https://youtu.be/8Hq1aqVfesg?t=00h13m52s)



[inherit great let's see so let's just](https://youtu.be/8Hq1aqVfesg?t=00h14m00s)



[double check our work here real quick](https://youtu.be/8Hq1aqVfesg?t=00h14m05s)



[so we added the two bindings color zone](https://youtu.be/8Hq1aqVfesg?t=00h14m07s)



[assist color so assist and it works](https://youtu.be/8Hq1aqVfesg?t=00h14m10s)



[to do so commit push and then that](https://youtu.be/8Hq1aqVfesg?t=00h14m16s)



[should we'll update our master from our](https://youtu.be/8Hq1aqVfesg?t=00h14m21s)



[other stuff and see you turn off that](https://youtu.be/8Hq1aqVfesg?t=00h14m25s)



[remote for the moment and we'll let the](https://youtu.be/8Hq1aqVfesg?t=00h14m30s)



[let the CI system run on that real quick](https://youtu.be/8Hq1aqVfesg?t=00h14m33s)



[and then I think this guy should be good](https://youtu.be/8Hq1aqVfesg?t=00h14m36s)



[to run all right so I expect to see](https://youtu.be/8Hq1aqVfesg?t=00h14m38s)



[[Music]](https://youtu.be/8Hq1aqVfesg?t=00h14m43s)



[expect to see one one build in progress](https://youtu.be/8Hq1aqVfesg?t=00h14m47s)



[and let's go give it the review yeah](https://youtu.be/8Hq1aqVfesg?t=00h14m52s)



[that's changed since we last looked at](https://youtu.be/8Hq1aqVfesg?t=00h14m58s)



[it that's changed since we last looked](https://youtu.be/8Hq1aqVfesg?t=00h15m00s)



[at it review changes approve submit okay](https://youtu.be/8Hq1aqVfesg?t=00h15m01s)



[so I just want to just so I don't](https://youtu.be/8Hq1aqVfesg?t=00h15m08s)



[accidentally shoot myself in the foot](https://youtu.be/8Hq1aqVfesg?t=00h15m10s)



[we're gonna wait for the CI system to](https://youtu.be/8Hq1aqVfesg?t=00h15m12s)



[finish textfield character counter this](https://youtu.be/8Hq1aqVfesg?t=00h15m14s)



[one's going to be bigger](https://youtu.be/8Hq1aqVfesg?t=00h15m18s)



[let's come back to that uh that one's](https://youtu.be/8Hq1aqVfesg?t=00h15m26s)



[still sort of a work in progress and I](https://youtu.be/8Hq1aqVfesg?t=00h15m29s)



[think I'm more interested in trying to](https://youtu.be/8Hq1aqVfesg?t=00h15m31s)



[get the three one o stuff merged in so](https://youtu.be/8Hq1aqVfesg?t=00h15m33s)



[let's see what was this to use material](https://youtu.be/8Hq1aqVfesg?t=00h15m42s)



[design paper brush on the combo boxes](https://youtu.be/8Hq1aqVfesg?t=00h15m48s)



[background one set](https://youtu.be/8Hq1aqVfesg?t=00h15m50s)



[yeah I remember doing this I'm not sure](https://youtu.be/8Hq1aqVfesg?t=00h15m59s)



[I'm very tempted to to merge this I'm](https://youtu.be/8Hq1aqVfesg?t=00h16m07s)



[just trying to decide how much of a](https://youtu.be/8Hq1aqVfesg?t=00h16m11s)



[breaking change this is right so this is](https://youtu.be/8Hq1aqVfesg?t=00h16m12s)



[where semantic versioning in this](https://youtu.be/8Hq1aqVfesg?t=00h16m15s)



[library gets a little weird because I've](https://youtu.be/8Hq1aqVfesg?t=00h16m17s)



[got the code API where it's fairly](https://youtu.be/8Hq1aqVfesg?t=00h16m20s)



[obvious when things are breaking changes](https://youtu.be/8Hq1aqVfesg?t=00h16m23s)



[or at least its objective but when](https://youtu.be/8Hq1aqVfesg?t=00h16m25s)



[there's visual breaking changes does](https://youtu.be/8Hq1aqVfesg?t=00h16m28s)



[that count right because this visually](https://youtu.be/8Hq1aqVfesg?t=00h16m30s)



[could break somebody's code if they](https://youtu.be/8Hq1aqVfesg?t=00h16m34s)



[update and they're relying on the old](https://youtu.be/8Hq1aqVfesg?t=00h16m36s)



[behavior](https://youtu.be/8Hq1aqVfesg?t=00h16m37s)



[I kind of doubt anyone is but that could](https://youtu.be/8Hq1aqVfesg?t=00h16m38s)



[be you know what I think we should do](https://youtu.be/8Hq1aqVfesg?t=00h16m44s)



[we're gonna just we're gonna just change](https://youtu.be/8Hq1aqVfesg?t=00h16m48s)



[up these items here right let's see this](https://youtu.be/8Hq1aqVfesg?t=00h16m53s)



[one's not being used so I'm just gonna](https://youtu.be/8Hq1aqVfesg?t=00h16m57s)



[get rid of this well hang on let's let's](https://youtu.be/8Hq1aqVfesg?t=00h16m59s)



[check it here right because I'm I'm](https://youtu.be/8Hq1aqVfesg?t=00h17m05s)



[somewhat tempted to see there's one](https://youtu.be/8Hq1aqVfesg?t=00h17m07s)



[closed item with this yeah I'm I'm](https://youtu.be/8Hq1aqVfesg?t=00h17m11s)



[thinking I'm just gonna whack when I get](https://youtu.be/8Hq1aqVfesg?t=00h17m16s)



[rid of this label because it doesn't get](https://youtu.be/8Hq1aqVfesg?t=00h17m18s)



[used enough and I think what I'm going](https://youtu.be/8Hq1aqVfesg?t=00h17m19s)



[to do is create two new labels so](https://youtu.be/8Hq1aqVfesg?t=00h17m22s)



[breaking change alright and I think](https://youtu.be/8Hq1aqVfesg?t=00h17m26s)



[let's pick a color that's orange might](https://youtu.be/8Hq1aqVfesg?t=00h17m29s)



[be nice I don't think we've got a good](https://youtu.be/8Hq1aqVfesg?t=00h17m33s)



[orange in there so breaking change so](https://youtu.be/8Hq1aqVfesg?t=00h17m34s)



[we'll create that let's put a](https://youtu.be/8Hq1aqVfesg?t=00h17m40s)



[description on here](https://youtu.be/8Hq1aqVfesg?t=00h17m43s)



[items with](https://youtu.be/8Hq1aqVfesg?t=00h17m45s)



[items here have braking API changes](https://youtu.be/8Hq1aqVfesg?t=00h17m50s)



[yeah we'll just](https://youtu.be/8Hq1aqVfesg?t=00h18m04s)



[okay then we're going to do another new](https://youtu.be/8Hq1aqVfesg?t=00h18m07s)



[label kind of want in this similar vein](https://youtu.be/8Hq1aqVfesg?t=00h18m09s)



[of that orange come on give me an orange](https://youtu.be/8Hq1aqVfesg?t=00h18m11s)



[I just pick one myself because what I'm](https://youtu.be/8Hq1aqVfesg?t=00h18m16s)



[looking to do is visual breaking change](https://youtu.be/8Hq1aqVfesg?t=00h18m23s)



[let's see items here affected the visual](https://youtu.be/8Hq1aqVfesg?t=00h18m30s)



[look of your app you require changes to](https://youtu.be/8Hq1aqVfesg?t=00h18m43s)



[look](https://youtu.be/8Hq1aqVfesg?t=00h19m05s)



[control](https://youtu.be/8Hq1aqVfesg?t=00h19m08s)



[maybe something like that right that way](https://youtu.be/8Hq1aqVfesg?t=00h19m10s)



[I think this is mostly just here for for](https://youtu.be/8Hq1aqVfesg?t=00h19m13s)



[my reference as we as we move things in](https://youtu.be/8Hq1aqVfesg?t=00h19m19s)



[because this again this isn't a breaking](https://youtu.be/8Hq1aqVfesg?t=00h19m23s)



[change but it's a a visual breaking](https://youtu.be/8Hq1aqVfesg?t=00h19m27s)



[change all right so there's and I think](https://youtu.be/8Hq1aqVfesg?t=00h19m31s)



[what I'm gonna do is I'm gonna just take](https://youtu.be/8Hq1aqVfesg?t=00h19m37s)



[this one in and we're going to accept it](https://youtu.be/8Hq1aqVfesg?t=00h19m39s)



[for now and I would really like it if](https://youtu.be/8Hq1aqVfesg?t=00h19m41s)



[anybody's able to play with the latest](https://youtu.be/8Hq1aqVfesg?t=00h19m45s)



[released let me know because this is](https://youtu.be/8Hq1aqVfesg?t=00h19m47s)



[again a visual breaking change and so if](https://youtu.be/8Hq1aqVfesg?t=00h19m50s)



[we need to pull this out and do](https://youtu.be/8Hq1aqVfesg?t=00h19m53s)



[something different I'd like to know and](https://youtu.be/8Hq1aqVfesg?t=00h19m55s)



[understand your use case so comment on](https://youtu.be/8Hq1aqVfesg?t=00h19m57s)



[1576 or message me in the git er chat](https://youtu.be/8Hq1aqVfesg?t=00h20m00s)



[either one of those was a great way to](https://youtu.be/8Hq1aqVfesg?t=00h20m04s)



[get a hold of me okay so there's that](https://youtu.be/8Hq1aqVfesg?t=00h20m05s)



[are you still going](https://youtu.be/8Hq1aqVfesg?t=00h20m08s)



[come on build hurry up and finish what](https://youtu.be/8Hq1aqVfesg?t=00h20m10s)



[is taking you so long](https://youtu.be/8Hq1aqVfesg?t=00h20m14s)



[were you just slow to get picked up no](https://youtu.be/8Hq1aqVfesg?t=00h20m15s)



[literally just finished okay great](https://youtu.be/8Hq1aqVfesg?t=00h20m21s)



[let's see comment and squash merge](https://youtu.be/8Hq1aqVfesg?t=00h20m36s)



[squash merge do another pull request](https://youtu.be/8Hq1aqVfesg?t=00h20m40s)



[down and let's see here what else what](https://youtu.be/8Hq1aqVfesg?t=00h20m48s)



[other pull requests are sitting in the](https://youtu.be/8Hq1aqVfesg?t=00h20m53s)



[the three one oh I do tend to favor I do](https://youtu.be/8Hq1aqVfesg?t=00h20m55s)



[tend to favor actually trying to work on](https://youtu.be/8Hq1aqVfesg?t=00h21m03s)



[the pull requests before user or before](https://youtu.be/8Hq1aqVfesg?t=00h21m05s)



[bug reports so unless anyone objects and](https://youtu.be/8Hq1aqVfesg?t=00h21m07s)



[says that some bug is a big issue for](https://youtu.be/8Hq1aqVfesg?t=00h21m11s)



[them so I don't think this is a to do so](https://youtu.be/8Hq1aqVfesg?t=00h21m14s)



[I think we may have accidentally just](https://youtu.be/8Hq1aqVfesg?t=00h21m21s)



[broken this right yeah yeah we just](https://youtu.be/8Hq1aqVfesg?t=00h21m22s)



[broke this so I can guarantee we just](https://youtu.be/8Hq1aqVfesg?t=00h21m28s)



[changed a bunch of files that this one's](https://youtu.be/8Hq1aqVfesg?t=00h21m31s)



[touching so let's take a look well](https://youtu.be/8Hq1aqVfesg?t=00h21m33s)



[actually let's let's just go see about](https://youtu.be/8Hq1aqVfesg?t=00h21m37s)



[doing this because this one's been open](https://youtu.be/8Hq1aqVfesg?t=00h21m39s)



[for a while so and it is something that](https://youtu.be/8Hq1aqVfesg?t=00h21m40s)



[I tagged for 3/1 oh so just because I](https://youtu.be/8Hq1aqVfesg?t=00h21m43s)



[tagged something in a particular](https://youtu.be/8Hq1aqVfesg?t=00h21m46s)



[milestone doesn't necessarily guarantee](https://youtu.be/8Hq1aqVfesg?t=00h21m47s)



[that it will go out in that milestone](https://youtu.be/8Hq1aqVfesg?t=00h21m49s)



[but it does guarantee that I'll look at](https://youtu.be/8Hq1aqVfesg?t=00h21m51s)



[it before releasing that milestone so](https://youtu.be/8Hq1aqVfesg?t=00h21m53s)



[start with this pull see I got too many](https://youtu.be/8Hq1aqVfesg?t=00h21m56s)



[branches too many branches too many](https://youtu.be/8Hq1aqVfesg?t=00h22m00s)



[branches too many branches delete delete](https://youtu.be/8Hq1aqVfesg?t=00h22m02s)



[delete delete delete delete delete oh I](https://youtu.be/8Hq1aqVfesg?t=00h22m05s)



[definitely want to fix this at some](https://youtu.be/8Hq1aqVfesg?t=00h22m12s)



[point did I have I thought I opened a](https://youtu.be/8Hq1aqVfesg?t=00h22m13s)



[pull request](https://youtu.be/8Hq1aqVfesg?t=00h22m17s)



[[Music]](https://youtu.be/8Hq1aqVfesg?t=00h22m19s)



[no interesting there must be an issue](https://youtu.be/8Hq1aqVfesg?t=00h22m22s)



[because I know there was something for](https://youtu.be/8Hq1aqVfesg?t=00h22m26s)



[that in the 3-1 Oh](https://youtu.be/8Hq1aqVfesg?t=00h22m27s)



[anyway 942 942 let's see here](https://youtu.be/8Hq1aqVfesg?t=00h22m29s)



[942 we're just gonna grab this guy yes](https://youtu.be/8Hq1aqVfesg?t=00h22m34s)



[take a look at him and then I think](https://youtu.be/8Hq1aqVfesg?t=00h22m38s)



[we'll probably just end up rebasing him](https://youtu.be/8Hq1aqVfesg?t=00h22m41s)



[right on sheesh okay so one why does it](https://youtu.be/8Hq1aqVfesg?t=00h22m43s)



[show pending changes Oh](https://youtu.be/8Hq1aqVfesg?t=00h22m49s)



[delete don't care about you at the](https://youtu.be/8Hq1aqVfesg?t=00h22m56s)



[moment](https://youtu.be/8Hq1aqVfesg?t=00h22m59s)



[oh you're probably locked in whatever](https://youtu.be/8Hq1aqVfesg?t=00h22m59s)



[okay so this guy's sitting over here](https://youtu.be/8Hq1aqVfesg?t=00h23m04s)



[let's rebase you right onto master](https://youtu.be/8Hq1aqVfesg?t=00h23m07s)



[okay and Visual Studio is losing its](https://youtu.be/8Hq1aqVfesg?t=00h23m14s)



[mind so we're just gonna shut it down](https://youtu.be/8Hq1aqVfesg?t=00h23m18s)



[yeah](https://youtu.be/8Hq1aqVfesg?t=00h23m19s)



[ignore all I understand I'm changing](https://youtu.be/8Hq1aqVfesg?t=00h23m20s)



[branches and bouncing around you don't](https://youtu.be/8Hq1aqVfesg?t=00h23m23s)



[like it when you don't like it when](https://youtu.be/8Hq1aqVfesg?t=00h23m25s)



[somebody takes all the stuff out from](https://youtu.be/8Hq1aqVfesg?t=00h23m27s)



[under you I got you okay back to what we](https://youtu.be/8Hq1aqVfesg?t=00h23m29s)



[were doing so we've got an old branch we](https://youtu.be/8Hq1aqVfesg?t=00h23m32s)



[know there's merge conflicts we're gonna](https://youtu.be/8Hq1aqVfesg?t=00h23m34s)



[rebase it onto master and then go from](https://youtu.be/8Hq1aqVfesg?t=00h23m35s)



[there okay so this guy here so this adds](https://youtu.be/8Hq1aqVfesg?t=00h23m39s)



[wonder why we added a tag regardless I](https://youtu.be/8Hq1aqVfesg?t=00h23m46s)



[think we just take both changes here it](https://youtu.be/8Hq1aqVfesg?t=00h23m49s)



[seems simple enough let's see we'll take](https://youtu.be/8Hq1aqVfesg?t=00h23m54s)



[that first and that second keep everyone](https://youtu.be/8Hq1aqVfesg?t=00h23m58s)



[in there happy great easy merge combo](https://youtu.be/8Hq1aqVfesg?t=00h24m03s)



[box pop up so this isn't really a](https://youtu.be/8Hq1aqVfesg?t=00h24m07s)



[different change right type default](https://youtu.be/8Hq1aqVfesg?t=00h24m12s)



[property dependency property register](https://youtu.be/8Hq1aqVfesg?t=00h24m17s)



[background this is just a whitespace](https://youtu.be/8Hq1aqVfesg?t=00h24m19s)



[formatting thing so that's not a big](https://youtu.be/8Hq1aqVfesg?t=00h24m21s)



[deal okay](https://youtu.be/8Hq1aqVfesg?t=00h24m24s)



[on property changed so what's going on](https://youtu.be/8Hq1aqVfesg?t=00h24m26s)



[here this guy is adding some loaded](https://youtu.be/8Hq1aqVfesg?t=00h24m29s)



[handlers loaded and unloaded inside of](https://youtu.be/8Hq1aqVfesg?t=00h24m31s)



[the constructor](https://youtu.be/8Hq1aqVfesg?t=00h24m33s)



[this thing is very very confused on](https://youtu.be/8Hq1aqVfesg?t=00h24m41s)



[where this code goes right so in this](https://youtu.be/8Hq1aqVfesg?t=00h24m44s)



[one here these items are inside of the](https://youtu.be/8Hq1aqVfesg?t=00h24m48s)



[Wow that is epic level confused these](https://youtu.be/8Hq1aqVfesg?t=00h24m54s)



[things are clearly up inside of the](https://youtu.be/8Hq1aqVfesg?t=00h25m00s)



[constructor but down here they are not I](https://youtu.be/8Hq1aqVfesg?t=00h25m04s)



[am curious why child changed handler so](https://youtu.be/8Hq1aqVfesg?t=00h25m11s)



[I think what we do is we take this and I](https://youtu.be/8Hq1aqVfesg?t=00h25m21s)



[think what I'm going to do is oh well it](https://youtu.be/8Hq1aqVfesg?t=00h25m25s)



[not let me it will let me edit down here](https://youtu.be/8Hq1aqVfesg?t=00h25m30s)



[but I really want to copy this alright I](https://youtu.be/8Hq1aqVfesg?t=00h25m33s)



[don't want to I'd really like to put](https://youtu.be/8Hq1aqVfesg?t=00h25m36s)



[that right here right let's just grab it](https://youtu.be/8Hq1aqVfesg?t=00h25m39s)



[off of let's just grab it right off of](https://youtu.be/8Hq1aqVfesg?t=00h25m45s)



[here get cracking I would like to be](https://youtu.be/8Hq1aqVfesg?t=00h25m52s)



[able to copy and paste your diff windows](https://youtu.be/8Hq1aqVfesg?t=00h25m55s)



[do not support it and it is a pain I](https://youtu.be/8Hq1aqVfesg?t=00h25m59s)



[should not have to jump out of the](https://youtu.be/8Hq1aqVfesg?t=00h26m01s)



[window to do this](https://youtu.be/8Hq1aqVfesg?t=00h26m03s)



[where is combo box pop-up](https://youtu.be/8Hq1aqVfesg?t=00h26m05s)



[exhales assists](https://youtu.be/8Hq1aqVfesg?t=00h26m13s)



[actually it looks like in the final](https://youtu.be/8Hq1aqVfesg?t=00h26m19s)



[result those things aren't even added](https://youtu.be/8Hq1aqVfesg?t=00h26m21s)



[right because I those things are not](https://youtu.be/8Hq1aqVfesg?t=00h26m23s)



[here so those get dropped in a later](https://youtu.be/8Hq1aqVfesg?t=00h26m26s)



[commit so I'm I'm not even going to](https://youtu.be/8Hq1aqVfesg?t=00h26m30s)



[stress about them so we'll come back to](https://youtu.be/8Hq1aqVfesg?t=00h26m31s)



[that in a minute](https://youtu.be/8Hq1aqVfesg?t=00h26m34s)



[continue our rebase](https://youtu.be/8Hq1aqVfesg?t=00h26m35s)



[text field assist so here we have an](https://youtu.be/8Hq1aqVfesg?t=00h26m39s)



[underlying brush and here we don't](https://youtu.be/8Hq1aqVfesg?t=00h26m43s)



[let me look and see here what let see](https://youtu.be/8Hq1aqVfesg?t=00h26m53s)



[textfield assist collapse collapse there](https://youtu.be/8Hq1aqVfesg?t=00h26m57s)



[is the addition of an underlying brush](https://youtu.be/8Hq1aqVfesg?t=00h27m04s)



[okay there we go where to go there we](https://youtu.be/8Hq1aqVfesg?t=00h27m06s)



[are](https://youtu.be/8Hq1aqVfesg?t=00h27m13s)



[so in this case I think we](https://youtu.be/8Hq1aqVfesg?t=00h27m13s)



[how do I](https://youtu.be/8Hq1aqVfesg?t=00h27m24s)



[oh I I take this right and that ends up](https://youtu.be/8Hq1aqVfesg?t=00h27m28s)



[with this controls the visibility Xbox](https://youtu.be/8Hq1aqVfesg?t=00h27m32s)



[field yeah great so we'll take that](https://youtu.be/8Hq1aqVfesg?t=00h27m35s)



[change there let's see here this has a](https://youtu.be/8Hq1aqVfesg?t=00h27m37s)



[cleanup a learning station material](https://youtu.be/8Hq1aqVfesg?t=00h27m45s)



[design themes this brings it down to](https://youtu.be/8Hq1aqVfesg?t=00h27m49s)



[just WPF I believe this is desirable](https://youtu.be/8Hq1aqVfesg?t=00h27m50s)



[let's see here this goes into their text](https://youtu.be/8Hq1aqVfesg?t=00h27m56s)



[field assist that makes sense](https://youtu.be/8Hq1aqVfesg?t=00h28m04s)



[this is changing the declaration there](https://youtu.be/8Hq1aqVfesg?t=00h28m14s)



[comma box pop up please](https://youtu.be/8Hq1aqVfesg?t=00h28m17s)



[wonder why it's unable to merge those I](https://youtu.be/8Hq1aqVfesg?t=00h28m18s)



[would have expected that to get to be](https://youtu.be/8Hq1aqVfesg?t=00h28m21s)



[able to figure that out](https://youtu.be/8Hq1aqVfesg?t=00h28m24s)



[okay so border brush WPA F text field](https://youtu.be/8Hq1aqVfesg?t=00h28m25s)



[assist underlined brush relative source](https://youtu.be/8Hq1aqVfesg?t=00h28m31s)



[self don't know why it can do that](https://youtu.be/8Hq1aqVfesg?t=00h28m34s)



[underlined so this is changing from W a](https://youtu.be/8Hq1aqVfesg?t=00h28m37s)



[quality coder welcome everyone thank you](https://youtu.be/8Hq1aqVfesg?t=00h28m48s)



[for coming in just so everybody is aware](https://youtu.be/8Hq1aqVfesg?t=00h28m52s)



[currently working on the material design](https://youtu.be/8Hq1aqVfesg?t=00h29m00s)



[in zamel project and just ultimately](https://youtu.be/8Hq1aqVfesg?t=00h29m03s)



[trying to catch up on being gone for a](https://youtu.be/8Hq1aqVfesg?t=00h29m08s)



[few weeks and trying to get pull request](https://youtu.be/8Hq1aqVfesg?t=00h29m13s)



[merged in currently struggling with a](https://youtu.be/8Hq1aqVfesg?t=00h29m16s)



[rebase because I'm a little confused as](https://youtu.be/8Hq1aqVfesg?t=00h29m21s)



[to the intent here but we're gonna we're](https://youtu.be/8Hq1aqVfesg?t=00h29m25s)



[gonna keep going with this hopefully](https://youtu.be/8Hq1aqVfesg?t=00h29m28s)



[there's only I think a few commits left](https://youtu.be/8Hq1aqVfesg?t=00h29m34s)



[in here so see how we'll see how this](https://youtu.be/8Hq1aqVfesg?t=00h29m37s)



[goes I don't think it's going to be too](https://youtu.be/8Hq1aqVfesg?t=00h29m41s)



[big of an issue material design](https://youtu.be/8Hq1aqVfesg?t=00h29m45s)



[subheading text blocks this is the demo](https://youtu.be/8Hq1aqVfesg?t=00h29m46s)



[app so I really don't care that much](https://youtu.be/8Hq1aqVfesg?t=00h29m51s)



[right let's see here](https://youtu.be/8Hq1aqVfesg?t=00h29m53s)



[Oh actually I do care I do care because](https://youtu.be/8Hq1aqVfesg?t=00h30m00s)



[this was a breaking change in the and](https://youtu.be/8Hq1aqVfesg?t=00h30m03s)



[the latest released where some of these](https://youtu.be/8Hq1aqVfesg?t=00h30m07s)



[styles got changed so I think we](https://youtu.be/8Hq1aqVfesg?t=00h30m09s)



[actually reject the static resource](https://youtu.be/8Hq1aqVfesg?t=00h30m11s)



[changes and keep keep the other ones in](https://youtu.be/8Hq1aqVfesg?t=00h30m14s)



[sometimes I really do hate merges these](https://youtu.be/8Hq1aqVfesg?t=00h30m23s)



[can things can be a huge pain in the](https://youtu.be/8Hq1aqVfesg?t=00h30m28s)



[butt so this has a stackpanel wrapping](https://youtu.be/8Hq1aqVfesg?t=00h30m30s)



[I'm not entirely sure I think I just](https://youtu.be/8Hq1aqVfesg?t=00h30m36s)



[take master on this right because](https://youtu.be/8Hq1aqVfesg?t=00h30m42s)



[there's nothing in here there's nothing](https://youtu.be/8Hq1aqVfesg?t=00h30m43s)



[in this particular section that should](https://youtu.be/8Hq1aqVfesg?t=00h30m50s)



[be changing so we're gonna take master](https://youtu.be/8Hq1aqVfesg?t=00h30m52s)



[because this isn't related to the pull](https://youtu.be/8Hq1aqVfesg?t=00h30m55s)



[request show me the sam'l field's 24:13](https://youtu.be/8Hq1aqVfesg?t=00h30m58s)



[and yeah I think we're just going to](https://youtu.be/8Hq1aqVfesg?t=00h31m03s)



[take these because these are just going](https://youtu.be/8Hq1aqVfesg?t=00h31m05s)



[to cause conflicts again I think I take](https://youtu.be/8Hq1aqVfesg?t=00h31m07s)



[master on these and I think once again I](https://youtu.be/8Hq1aqVfesg?t=00h31m11s)



[take master I'm gonna be a little](https://youtu.be/8Hq1aqVfesg?t=00h31m16s)



[shocked if this comes out and cancel](https://youtu.be/8Hq1aqVfesg?t=00h31m18s)



[what did I miss](https://youtu.be/8Hq1aqVfesg?t=00h31m24s)



[I picked one picked one oh these ones I](https://youtu.be/8Hq1aqVfesg?t=00h31m24s)



[didn't handle that one I missed okay](https://youtu.be/8Hq1aqVfesg?t=00h31m31s)



[check check check check check box check](https://youtu.be/8Hq1aqVfesg?t=00h31m34s)



[box safe continue rebase please be the](https://youtu.be/8Hq1aqVfesg?t=00h31m39s)



[last one okay so great only you know](https://youtu.be/8Hq1aqVfesg?t=00h31m43s)



[ninety nine and three that's not bad](https://youtu.be/8Hq1aqVfesg?t=00h31m48s)



[right](https://youtu.be/8Hq1aqVfesg?t=00h31m50s)



[that's not bad okay let's go and let's](https://youtu.be/8Hq1aqVfesg?t=00h31m50s)



[go and see how this works because](https://youtu.be/8Hq1aqVfesg?t=00h31m55s)



[ultimately in this case so back to what](https://youtu.be/8Hq1aqVfesg?t=00h31m56s)



[we started with right so the bug here is](https://youtu.be/8Hq1aqVfesg?t=00h31m59s)



[addressing the issue of combo boxes](https://youtu.be/8Hq1aqVfesg?t=00h32m03s)



[inside of the color zones alright so you](https://youtu.be/8Hq1aqVfesg?t=00h32m06s)



[have a color zone you open a combo box](https://youtu.be/8Hq1aqVfesg?t=00h32m08s)



[the background color looks horrible](https://youtu.be/8Hq1aqVfesg?t=00h32m12s)



[right and to some degree we address this](https://youtu.be/8Hq1aqVfesg?t=00h32m15s)



[with the other poll requests where we're](https://youtu.be/8Hq1aqVfesg?t=00h32m17s)



[using a theme brush for the pop up but](https://youtu.be/8Hq1aqVfesg?t=00h32m18s)



[this this goes through and I think if I](https://youtu.be/8Hq1aqVfesg?t=00h32m24s)



[remember this correctly let's see this](https://youtu.be/8Hq1aqVfesg?t=00h32m27s)



[does not change the border away from the](https://youtu.be/8Hq1aqVfesg?t=00h32m30s)



[primary mid brush yeah because the other](https://youtu.be/8Hq1aqVfesg?t=00h32m31s)



[one I believe just well this mean this](https://youtu.be/8Hq1aqVfesg?t=00h32m38s)



[maybe obsoleted we're gonna we're gonna](https://youtu.be/8Hq1aqVfesg?t=00h32m43s)



[relaunch this and find out because we](https://youtu.be/8Hq1aqVfesg?t=00h32m46s)



[may this may already be addressed](https://youtu.be/8Hq1aqVfesg?t=00h32m49s)



[and for those people who haven't been in](https://youtu.be/8Hq1aqVfesg?t=00h32m59s)



[here before I am perfectly happy to](https://youtu.be/8Hq1aqVfesg?t=00h33m02s)



[switch gears and take questions and work](https://youtu.be/8Hq1aqVfesg?t=00h33m05s)



[on stuff if people are interested](https://youtu.be/8Hq1aqVfesg?t=00h33m07s)



[otherwise I just continue on my merry](https://youtu.be/8Hq1aqVfesg?t=00h33m08s)



[way and continue banging away on my](https://youtu.be/8Hq1aqVfesg?t=00h33m11s)



[project so if people find it interesting](https://youtu.be/8Hq1aqVfesg?t=00h33m14s)



[great but if there is questions or](https://youtu.be/8Hq1aqVfesg?t=00h33m15s)



[whatnot I do tend to do a ton of c-sharp](https://youtu.be/8Hq1aqVfesg?t=00h33m18s)



[stuff a lot of zamel a lot of WPF but](https://youtu.be/8Hq1aqVfesg?t=00h33m21s)



[again always happy to take questions and](https://youtu.be/8Hq1aqVfesg?t=00h33m27s)



[change gears if there's something that](https://youtu.be/8Hq1aqVfesg?t=00h33m29s)



[actually interests somebody ok let's see](https://youtu.be/8Hq1aqVfesg?t=00h33m31s)



[let's go here and let's just we're just](https://youtu.be/8Hq1aqVfesg?t=00h33m36s)



[gonna fire it up I mean what are the](https://youtu.be/8Hq1aqVfesg?t=00h33m39s)



[chances that we botched something in a](https://youtu.be/8Hq1aqVfesg?t=00h33m40s)



[in emerg the answer is ridiculously high](https://youtu.be/8Hq1aqVfesg?t=00h33m41s)



[yeah so that'll do it so fields 27 is](https://youtu.be/8Hq1aqVfesg?t=00h33m48s)



[apparently duplicated over yeah so now](https://youtu.be/8Hq1aqVfesg?t=00h33m53s)



[we got to figure out what the heck I did](https://youtu.be/8Hq1aqVfesg?t=00h33m58s)



[wrong so simplest answer is Fields 28](https://youtu.be/8Hq1aqVfesg?t=00h34m00s)



[duplicated if I did the merge the chance](https://youtu.be/8Hq1aqVfesg?t=00h34m06s)



[would be about a hundred ten percent](https://youtu.be/8Hq1aqVfesg?t=00h34m11s)



[that I botched something I understand](https://youtu.be/8Hq1aqVfesg?t=00h34m13s)



[that feeling completely let's see yeah](https://youtu.be/8Hq1aqVfesg?t=00h34m15s)



[it's really unfortunate and I and I hate](https://youtu.be/8Hq1aqVfesg?t=00h34m23s)



[I hate doing it but there are times](https://youtu.be/8Hq1aqVfesg?t=00h34m25s)



[where you just kind of have to bite the](https://youtu.be/8Hq1aqVfesg?t=00h34m30s)



[bullet and decide you know what I want](https://youtu.be/8Hq1aqVfesg?t=00h34m31s)



[to get this merge so we're doing it now](https://youtu.be/8Hq1aqVfesg?t=00h34m34s)



[let's see fields 31 so at some point I'm](https://youtu.be/8Hq1aqVfesg?t=00h34m38s)



[going to go back to my zamel display or](https://youtu.be/8Hq1aqVfesg?t=00h34m42s)



[control and try and figure out](https://youtu.be/8Hq1aqVfesg?t=00h34m43s)



[I'd love to auto-generate these keys](https://youtu.be/8Hq1aqVfesg?t=00h34m46s)



[rather than making them fixed at compile](https://youtu.be/8Hq1aqVfesg?t=00h34m48s)



[time so for now that's ultimately what](https://youtu.be/8Hq1aqVfesg?t=00h34m51s)



[these these compile time errors are is](https://youtu.be/8Hq1aqVfesg?t=00h34m55s)



[duplicate key in your zamel go and](https://youtu.be/8Hq1aqVfesg?t=00h34m58s)



[change one of them all these are used](https://youtu.be/8Hq1aqVfesg?t=00h35m00s)



[for is it builds up a dictionary that's](https://youtu.be/8Hq1aqVfesg?t=00h35m03s)



[that just contains the string of this is](https://youtu.be/8Hq1aqVfesg?t=00h35m06s)



[Amal so that it can then look it up at](https://youtu.be/8Hq1aqVfesg?t=00h35m08s)



[runtime and display the corresponding](https://youtu.be/8Hq1aqVfesg?t=00h35m10s)



[because it's actually smiled li](https://youtu.be/8Hq1aqVfesg?t=00h35m13s)



[difficult to to display the](https://youtu.be/8Hq1aqVfesg?t=00h35m15s)



[corresponding zamel let's see I think 32](https://youtu.be/8Hq1aqVfesg?t=00h35m19s)



[is the magical number because if you](https://youtu.be/8Hq1aqVfesg?t=00h35m23s)



[want to take a sum zamel code and](https://youtu.be/8Hq1aqVfesg?t=00h35m26s)



[actually display it at runtime what](https://youtu.be/8Hq1aqVfesg?t=00h35m29s)



[didn't I just establish this was legit](https://youtu.be/8Hq1aqVfesg?t=00h35m34s)



[32 oh really](https://youtu.be/8Hq1aqVfesg?t=00h35m38s)



[00:35:49,359 --> 00:35:53,920](https://youtu.be/8Hq1aqVfesg?t=00h35m41s)

right


[file](https://youtu.be/8Hq1aqVfesg?t=00h35m51s)



[to do a joke cool nice to have you](https://youtu.be/8Hq1aqVfesg?t=00h35m53s)



[around](https://youtu.be/8Hq1aqVfesg?t=00h36m00s)



[so what were you guys working on quality](https://youtu.be/8Hq1aqVfesg?t=00h36m01s)



[coder](https://youtu.be/8Hq1aqVfesg?t=00h36m04s)



[I think this guy's lost its mind rebuild](https://youtu.be/8Hq1aqVfesg?t=00h36m13s)



[when in doubt clean and rebuild oh cool](https://youtu.be/8Hq1aqVfesg?t=00h36m18s)



[chat bot for twitch or discord or which](https://youtu.be/8Hq1aqVfesg?t=00h36m25s)



[one oh man this is okay so I think what](https://youtu.be/8Hq1aqVfesg?t=00h36m29s)



[I'm gonna do real quick is I've got this](https://youtu.be/8Hq1aqVfesg?t=00h36m36s)



[branch locally staged amend great fix](https://youtu.be/8Hq1aqVfesg?t=00h36m41s)



[that I kind of want to jump back to](https://youtu.be/8Hq1aqVfesg?t=00h36m46s)



[master and just confirm that this is](https://youtu.be/8Hq1aqVfesg?t=00h36m47s)



[legitimately still a bug right because](https://youtu.be/8Hq1aqVfesg?t=00h36m50s)



[something in the back of my mind is](https://youtu.be/8Hq1aqVfesg?t=00h36m53s)



[telling me that the last pull request we](https://youtu.be/8Hq1aqVfesg?t=00h36m55s)



[merged took care of this combo box issue](https://youtu.be/8Hq1aqVfesg?t=00h36m57s)



[we're going to see](https://youtu.be/8Hq1aqVfesg?t=00h36m59s)



[we're gonna see multi-platform chatbot](https://youtu.be/8Hq1aqVfesg?t=00h37m05s)



[each bot is a plug-in to the framework](https://youtu.be/8Hq1aqVfesg?t=00h37m11s)



[so it can run multiple BOTS at once but](https://youtu.be/8Hq1aqVfesg?t=00h37m14s)



[tonight it was on the twitch bot plugin](https://youtu.be/8Hq1aqVfesg?t=00h37m16s)



[cool that actually sounds uh pretty](https://youtu.be/8Hq1aqVfesg?t=00h37m19s)



[sweet I might go take a look at that](https://youtu.be/8Hq1aqVfesg?t=00h37m26s)



[let's see uh yeah I'm gonna go with it's](https://youtu.be/8Hq1aqVfesg?t=00h37m27s)



[lost its mind the the problem with my](https://youtu.be/8Hq1aqVfesg?t=00h37m34s)



[show me the sam'l plug-in is it runs](https://youtu.be/8Hq1aqVfesg?t=00h37m37s)



[inside of the MS build pipeline and](https://youtu.be/8Hq1aqVfesg?t=00h37m39s)



[because of that it occasionally because](https://youtu.be/8Hq1aqVfesg?t=00h37m43s)



[Visual Studio leaves the MS build](https://youtu.be/8Hq1aqVfesg?t=00h37m46s)



[process running it occasionally just has](https://youtu.be/8Hq1aqVfesg?t=00h37m48s)



[caching issues where it holds on to old](https://youtu.be/8Hq1aqVfesg?t=00h37m54s)



[versions of stuff when you're changing](https://youtu.be/8Hq1aqVfesg?t=00h37m57s)



[branches it's very frustrating I wish](https://youtu.be/8Hq1aqVfesg?t=00h37m59s)



[there was a way to do it you can](https://youtu.be/8Hq1aqVfesg?t=00h38m03s)



[technically go through and kill all your](https://youtu.be/8Hq1aqVfesg?t=00h38m04s)



[ms build processes and and then kick off](https://youtu.be/8Hq1aqVfesg?t=00h38m05s)



[a build but I find it's just quicker to](https://youtu.be/8Hq1aqVfesg?t=00h38m09s)



[close and relaunch Visual Studio so that](https://youtu.be/8Hq1aqVfesg?t=00h38m11s)



[is cool about the the chat box I'll go](https://youtu.be/8Hq1aqVfesg?t=00h38m16s)



[and take a look at it](https://youtu.be/8Hq1aqVfesg?t=00h38m17s)



[let's see](https://youtu.be/8Hq1aqVfesg?t=00h38m24s)



[ah so what is sam'l and how does it](https://youtu.be/8Hq1aqVfesg?t=00h38m33s)



[differ from XML so the answer is sam'l](https://youtu.be/8Hq1aqVfesg?t=00h38m37s)



[is XML it's a short version is it's a](https://youtu.be/8Hq1aqVfesg?t=00h38m40s)



[markup language for doing you eyes in](https://youtu.be/8Hq1aqVfesg?t=00h38m44s)



[this case we are doing WPF so for](https://youtu.be/8Hq1aqVfesg?t=00h38m49s)



[example the to do whereas main one so](https://youtu.be/8Hq1aqVfesg?t=00h38m53s)



[you end up declaring your UI something](https://youtu.be/8Hq1aqVfesg?t=00h38m57s)



[that looks like this so your top level](https://youtu.be/8Hq1aqVfesg?t=00h39m01s)



[element in XML is just a window you've](https://youtu.be/8Hq1aqVfesg?t=00h39m03s)



[got buttons](https://youtu.be/8Hq1aqVfesg?t=00h39m06s)



[you've got panels for layout that sort](https://youtu.be/8Hq1aqVfesg?t=00h39m07s)



[of thing to go through and do it it's](https://youtu.be/8Hq1aqVfesg?t=00h39m09s)



[big drawback is it's overly verbose a](https://youtu.be/8Hq1aqVfesg?t=00h39m11s)



[lot of people who really like what is](https://youtu.be/8Hq1aqVfesg?t=00h39m14s)



[going on a lot of people who really like](https://youtu.be/8Hq1aqVfesg?t=00h39m19s)



[web development will they squawk at the](https://youtu.be/8Hq1aqVfesg?t=00h39m21s)



[look of zamel because it really is big](https://youtu.be/8Hq1aqVfesg?t=00h39m26s)



[and for bose I'm weird and I like it but](https://youtu.be/8Hq1aqVfesg?t=00h39m30s)



[that's just me the imported project](https://youtu.be/8Hq1aqVfesg?t=00h39m34s)



[build show me was not found' confirm the](https://youtu.be/8Hq1aqVfesg?t=00h39m39s)



[expression in import what the heck is](https://youtu.be/8Hq1aqVfesg?t=00h39m42s)



[going on okay so let's take a look](https://youtu.be/8Hq1aqVfesg?t=00h39m45s)



[something something is off](https://youtu.be/8Hq1aqVfesg?t=00h39m49s)



[let's see buried underneath our packages](https://youtu.be/8Hq1aqVfesg?t=00h39m52s)



[file](https://youtu.be/8Hq1aqVfesg?t=00h39m57s)



[show me the sam'l I must build it's like](https://youtu.be/8Hq1aqVfesg?t=00h39m57s)



[it whacked a text file I can spell show](https://youtu.be/8Hq1aqVfesg?t=00h40m02s)



[SH see shown style I must build](https://youtu.be/8Hq1aqVfesg?t=00h40m09s)



[I don't blame you for shying away from](https://youtu.be/8Hq1aqVfesg?t=00h40m20s)



[the XML especially with stuff like Oh](https://youtu.be/8Hq1aqVfesg?t=00h40m22s)



[whiz dolls](https://youtu.be/8Hq1aqVfesg?t=00h40m27s)



[they kind of left a bad taste and a lot](https://youtu.be/8Hq1aqVfesg?t=00h40m28s)



[of people's mouth with overly verbose](https://youtu.be/8Hq1aqVfesg?t=00h40m31s)



[XML it is kind of yucky like I won't](https://youtu.be/8Hq1aqVfesg?t=00h40m33s)



[disagree with that though I was I would](https://youtu.be/8Hq1aqVfesg?t=00h40m37s)



[liken it a little more to sort of what](https://youtu.be/8Hq1aqVfesg?t=00h40m39s)



[you do with like HTML for laying out of](https://youtu.be/8Hq1aqVfesg?t=00h40m42s)



[a web page it's not too unlike that it's](https://youtu.be/8Hq1aqVfesg?t=00h40m44s)



[a lot more strict though in what you're](https://youtu.be/8Hq1aqVfesg?t=00h40m49s)



[allowed to do it's very it's very picky](https://youtu.be/8Hq1aqVfesg?t=00h40m51s)



[but it also gets compiled so you get a](https://youtu.be/8Hq1aqVfesg?t=00h40m54s)



[you get compiled time checking on it](https://youtu.be/8Hq1aqVfesg?t=00h40m57s)



[rather than you know runtime checks so](https://youtu.be/8Hq1aqVfesg?t=00h40m59s)



[we must build well I agree with you that](https://youtu.be/8Hq1aqVfesg?t=00h41m03s)



[it's missing but where the heck did it](https://youtu.be/8Hq1aqVfesg?t=00h41m07s)



[go it's just what okay I am very very](https://youtu.be/8Hq1aqVfesg?t=00h41m09s)



[confused by you pack it very very](https://youtu.be/8Hq1aqVfesg?t=00h41m18s)



[confused by you so when in doubt](https://youtu.be/8Hq1aqVfesg?t=00h41m21s)



[PowerShell window and manually run it so](https://youtu.be/8Hq1aqVfesg?t=00h41m25s)



[let's see here](https://youtu.be/8Hq1aqVfesg?t=00h41m28s)



[packet packet bootstrapper and I think](https://youtu.be/8Hq1aqVfesg?t=00h41m30s)



[it's restores the magical what the heck](https://youtu.be/8Hq1aqVfesg?t=00h41m34s)



[okay don't I don't recommend anyone do](https://youtu.be/8Hq1aqVfesg?t=00h41m44s)



[this ever get clean VFX so reset my repo](https://youtu.be/8Hq1aqVfesg?t=00h41m49s)



[back to a clean state wipe everything](https://youtu.be/8Hq1aqVfesg?t=00h41m59s)



[out that's not under source control](https://youtu.be/8Hq1aqVfesg?t=00h42m01s)



[little abusive and by little I mean](https://youtu.be/8Hq1aqVfesg?t=00h42m03s)



[horribly abusive but though I will say I](https://youtu.be/8Hq1aqVfesg?t=00h42m06s)



[do strongly prefer XHTML / HTML even](https://youtu.be/8Hq1aqVfesg?t=00h42m14s)



[though XHTML went away a while ago I](https://youtu.be/8Hq1aqVfesg?t=00h42m17s)



[prefer the must closure tag syntax over](https://youtu.be/8Hq1aqVfesg?t=00h42m19s)



[the lazy na I don't have to do that](https://youtu.be/8Hq1aqVfesg?t=00h42m23s)



[browser understands yes yes completely](https://youtu.be/8Hq1aqVfesg?t=00h42m25s)



[agree you you might actually not find](https://youtu.be/8Hq1aqVfesg?t=00h42m29s)



[sam'l to be that that different then](https://youtu.be/8Hq1aqVfesg?t=00h42m32s)



[again just because it's compiled its](https://youtu.be/8Hq1aqVfesg?t=00h42m36s)



[syntax rules are very strict and it](https://youtu.be/8Hq1aqVfesg?t=00h42m39s)



[doesn't allow for a lot of freedom in](https://youtu.be/8Hq1aqVfesg?t=00h42m43s)



[that regard so everything you declare](https://youtu.be/8Hq1aqVfesg?t=00h42m46s)



[will be closed or you will get whacked](https://youtu.be/8Hq1aqVfesg?t=00h42m49s)



[upside the head let's](https://youtu.be/8Hq1aqVfesg?t=00h42m51s)



[so at this point it should run I expect](https://youtu.be/8Hq1aqVfesg?t=00h42m58s)



[the first one will likely fail because](https://youtu.be/8Hq1aqVfesg?t=00h43m00s)



[the packet will will do the restore I](https://youtu.be/8Hq1aqVfesg?t=00h43m03s)



[keep debating about dropping packet and](https://youtu.be/8Hq1aqVfesg?t=00h43m06s)



[just doing everything as straight](https://youtu.be/8Hq1aqVfesg?t=00h43m09s)



[nougats only because there's better](https://youtu.be/8Hq1aqVfesg?t=00h43m10s)



[tooling support people are used to it](https://youtu.be/8Hq1aqVfesg?t=00h43m14s)



[but we do have a couple dependencies](https://youtu.be/8Hq1aqVfesg?t=00h43m17s)



[that are being pulled in is just](https://youtu.be/8Hq1aqVfesg?t=00h43m19s)



[straight source files off of github](https://youtu.be/8Hq1aqVfesg?t=00h43m20s)



[using packet so in that regard packet is](https://youtu.be/8Hq1aqVfesg?t=00h43m22s)



[kind of nice because it has more](https://youtu.be/8Hq1aqVfesg?t=00h43m25s)



[features you can pin things at a](https://youtu.be/8Hq1aqVfesg?t=00h43m27s)



[particular version okay so the whole](https://youtu.be/8Hq1aqVfesg?t=00h43m29s)



[point of this is in the color tool no](https://youtu.be/8Hq1aqVfesg?t=00h43m31s)



[not that one the color zone not the](https://youtu.be/8Hq1aqVfesg?t=00h43m34s)



[color tool this guy here we need we need](https://youtu.be/8Hq1aqVfesg?t=00h43m40s)



[to go through and add us some combo](https://youtu.be/8Hq1aqVfesg?t=00h43m44s)



[boxes do the next email yes yeah and in](https://youtu.be/8Hq1aqVfesg?t=00h43m47s)



[zamel you do get the nice self closing](https://youtu.be/8Hq1aqVfesg?t=00h43m56s)



[tags it and so it can get fairly nice I](https://youtu.be/8Hq1aqVfesg?t=00h43m58s)



[find it's intuitive to read I know I'm](https://youtu.be/8Hq1aqVfesg?t=00h44m04s)



[probably in a minority but like for](https://youtu.be/8Hq1aqVfesg?t=00h44m08s)



[example like the the toggle button here](https://youtu.be/8Hq1aqVfesg?t=00h44m12s)



[right you can go through it's one line](https://youtu.be/8Hq1aqVfesg?t=00h44m14s)



[of code it's a simple toggle button and](https://youtu.be/8Hq1aqVfesg?t=00h44m17s)



[away you go](https://youtu.be/8Hq1aqVfesg?t=00h44m19s)



[and then with this style in this library](https://youtu.be/8Hq1aqVfesg?t=00h44m20s)



[you end up getting something that](https://youtu.be/8Hq1aqVfesg?t=00h44m23s)



[ultimately gives you the nice little](https://youtu.be/8Hq1aqVfesg?t=00h44m25s)



[hamburger menu with the little animation](https://youtu.be/8Hq1aqVfesg?t=00h44m27s)



[and the spin and all the all the pretty](https://youtu.be/8Hq1aqVfesg?t=00h44m30s)



[jazz that goes along with that so let's](https://youtu.be/8Hq1aqVfesg?t=00h44m32s)



[see which one are we gonna pick on I](https://youtu.be/8Hq1aqVfesg?t=00h44m35s)



[think I want to go down a primary dark](https://youtu.be/8Hq1aqVfesg?t=00h44m36s)



[color zone](https://youtu.be/8Hq1aqVfesg?t=00h44m41s)



[so let's go down here primary mid](https://youtu.be/8Hq1aqVfesg?t=00h44m42s)



[primary dark so let's just drop](https://youtu.be/8Hq1aqVfesg?t=00h44m47s)



[something in here right so we'll do a](https://youtu.be/8Hq1aqVfesg?t=00h44m50s)



[combo box](https://youtu.be/8Hq1aqVfesg?t=00h44m52s)



[come a box item](https://youtu.be/8Hq1aqVfesg?t=00h44m56s)



[and if you can't type your life gets a](https://youtu.be/8Hq1aqVfesg?t=00h45m04s)



[lot harder](https://youtu.be/8Hq1aqVfesg?t=00h45m07s)



[a server-side programmer PHP and Python](https://youtu.be/8Hq1aqVfesg?t=00h45m14s)



[on my bread and butter interesting I](https://youtu.be/8Hq1aqVfesg?t=00h45m16s)



[understand the the Python but what why](https://youtu.be/8Hq1aqVfesg?t=00h45m19s)



[the PHP is that by choice or is there](https://youtu.be/8Hq1aqVfesg?t=00h45m21s)



[some sort of legacy system type thing I](https://youtu.be/8Hq1aqVfesg?t=00h45m24s)



[know some people really like the](https://youtu.be/8Hq1aqVfesg?t=00h45m27s)



[low-level PHP stuff but it always felt](https://youtu.be/8Hq1aqVfesg?t=00h45m29s)



[like I wanted a higher-level language](https://youtu.be/8Hq1aqVfesg?t=00h45m33s)



[when I used it okay so we got a combo](https://youtu.be/8Hq1aqVfesg?t=00h45m34s)



[box and that's ultimately the bug there](https://youtu.be/8Hq1aqVfesg?t=00h45m39s)



[right is inside of here this guy ends up](https://youtu.be/8Hq1aqVfesg?t=00h45m42s)



[okay so we do need it](https://youtu.be/8Hq1aqVfesg?t=00h45m50s)



[short version bug still exists I just](https://youtu.be/8Hq1aqVfesg?t=00h45m52s)



[like PHP doing it for almost 15 years](https://youtu.be/8Hq1aqVfesg?t=00h45m56s)



[okay I got you](https://youtu.be/8Hq1aqVfesg?t=00h45m58s)



[I do know that I've met several people](https://youtu.be/8Hq1aqVfesg?t=00h45m59s)



[who that's been their first language in](https://youtu.be/8Hq1aqVfesg?t=00h46m02s)



[first love and they definitely like to](https://youtu.be/8Hq1aqVfesg?t=00h46m06s)



[stick with it I'm biased and like my](https://youtu.be/8Hq1aqVfesg?t=00h46m08s)



[c-sharp a lot but again I'm I'm very](https://youtu.be/8Hq1aqVfesg?t=00h46m15s)



[much](https://youtu.be/8Hq1aqVfesg?t=00h46m21s)



[I go to c-sharp for just about](https://youtu.be/8Hq1aqVfesg?t=00h46m23s)



[everything until I have a reason not to](https://youtu.be/8Hq1aqVfesg?t=00h46m27s)



[okay so there was an underlying brush](https://youtu.be/8Hq1aqVfesg?t=00h46m29s)



[right so this underlying brush property](https://youtu.be/8Hq1aqVfesg?t=00h46m31s)



[underlying brush property what are you](https://youtu.be/8Hq1aqVfesg?t=00h46m35s)



[ambiguous reference so is there two of](https://youtu.be/8Hq1aqVfesg?t=00h46m38s)



[them in here](https://youtu.be/8Hq1aqVfesg?t=00h46m40s)



[underline highlight brush there are so](https://youtu.be/8Hq1aqVfesg?t=00h46m42s)



[we need to whack one of these](https://youtu.be/8Hq1aqVfesg?t=00h46m47s)



[first professional language was c-sharp](https://youtu.be/8Hq1aqVfesg?t=00h46m54s)



[during my internship then cold fusion](https://youtu.be/8Hq1aqVfesg?t=00h46m56s)



[and my first normal job then on to PHP](https://youtu.be/8Hq1aqVfesg?t=00h46m58s)



[after that I stuck with PHP interesting](https://youtu.be/8Hq1aqVfesg?t=00h46m59s)



[so if that was about 15 years ago I'm](https://youtu.be/8Hq1aqVfesg?t=00h47m04s)



[gonna go what that was like c-sharp is](https://youtu.be/8Hq1aqVfesg?t=00h47m07s)



[that like 102 oh I was gonna say I think](https://youtu.be/8Hq1aqVfesg?t=00h47m10s)



[that because I started with c-sharp I](https://youtu.be/8Hq1aqVfesg?t=00h47m16s)



[want to say 11 years ago and I think 300](https://youtu.be/8Hq1aqVfesg?t=00h47m20s)



[had just dropped if I'm remembering](https://youtu.be/8Hq1aqVfesg?t=00h47m23s)



[right](https://youtu.be/8Hq1aqVfesg?t=00h47m26s)



[a while back okay so that'll fix that](https://youtu.be/8Hq1aqVfesg?t=00h47m27s)



[that'll fix that that bug goes away](https://youtu.be/8Hq1aqVfesg?t=00h47m35s)



[I have to pop open the next Mountain Dew](https://youtu.be/8Hq1aqVfesg?t=00h47m43s)



[but it was the version before yeah I](https://youtu.be/8Hq1aqVfesg?t=00h47m53s)



[think you mean link so not X but Q yeah](https://youtu.be/8Hq1aqVfesg?t=00h47m56s)



[the in language query syntax which I](https://youtu.be/8Hq1aqVfesg?t=00h48m04s)



[believe that so link came I believe in](https://youtu.be/8Hq1aqVfesg?t=00h48m06s)



[three or three five I don't remember](https://youtu.be/8Hq1aqVfesg?t=00h48m10s)



[exactly which but yeah it would have](https://youtu.be/8Hq1aqVfesg?t=00h48m13s)



[been just before that so probably - oh](https://youtu.be/8Hq1aqVfesg?t=00h48m14s)



[then and I still have one more duplicate](https://youtu.be/8Hq1aqVfesg?t=00h48m16s)



[key of course I do](https://youtu.be/8Hq1aqVfesg?t=00h48m21s)



[35 be unduplicated please I'm wondering](https://youtu.be/8Hq1aqVfesg?t=00h48m22s)



[if I should change that error message to](https://youtu.be/8Hq1aqVfesg?t=00h48m29s)



[just print off all of the the keys there](https://youtu.be/8Hq1aqVfesg?t=00h48m30s)



[we go](https://youtu.be/8Hq1aqVfesg?t=00h48m33s)



[it compiles the first unit test has](https://youtu.be/8Hq1aqVfesg?t=00h48m34s)



[passed okay so let's see here now that I](https://youtu.be/8Hq1aqVfesg?t=00h48m38s)



[have this search box I really do want to](https://youtu.be/8Hq1aqVfesg?t=00h48m44s)



[go through and change change the way](https://youtu.be/8Hq1aqVfesg?t=00h48m45s)



[this works okay got a sworn this pull](https://youtu.be/8Hq1aqVfesg?t=00h48m48s)



[request had yeah](https://youtu.be/8Hq1aqVfesg?t=00h48m53s)



[I'm missing something oh here it is](https://youtu.be/8Hq1aqVfesg?t=00h48m59s)



[got it it's right here that's fine](https://youtu.be/8Hq1aqVfesg?t=00h49m03s)



[what's this toggle do not just a pretty](https://youtu.be/8Hq1aqVfesg?t=00h49m07s)



[toggle okay so that does look a lot](https://youtu.be/8Hq1aqVfesg?t=00h49m11s)



[better okay so let's let's take a look](https://youtu.be/8Hq1aqVfesg?t=00h49m16s)



[at what actually changed in this guy](https://youtu.be/8Hq1aqVfesg?t=00h49m19s)



[because I think this is probably an easy](https://youtu.be/8Hq1aqVfesg?t=00h49m21s)



[merge so there's the combo box in the UI](https://youtu.be/8Hq1aqVfesg?t=00h49m22s)



[great that's fine](https://youtu.be/8Hq1aqVfesg?t=00h49m26s)



[there's the let's see so this adds a](https://youtu.be/8Hq1aqVfesg?t=00h49m29s)



[combo box in the fields area with a](https://youtu.be/8Hq1aqVfesg?t=00h49m32s)



[color zone mode of inverted so let's go](https://youtu.be/8Hq1aqVfesg?t=00h49m34s)



[to the fields to do what's over here](https://youtu.be/8Hq1aqVfesg?t=00h49m37s)



[oh this is the problem we've got two](https://youtu.be/8Hq1aqVfesg?t=00h49m43s)



[things sitting on top of each other so](https://youtu.be/8Hq1aqVfesg?t=00h49m47s)



[probably need to clean that up and where](https://youtu.be/8Hq1aqVfesg?t=00h49m49s)



[the heck is this guy just looking for](https://youtu.be/8Hq1aqVfesg?t=00h49m52s)



[the OS hint company I work for is](https://youtu.be/8Hq1aqVfesg?t=00h49m55s)



[primarily a Microsoft shop TFS c-sharp](https://youtu.be/8Hq1aqVfesg?t=00h50m00s)



[Team Skype but they also allow Java and](https://youtu.be/8Hq1aqVfesg?t=00h50m02s)



[Python I refused to rekindle my](https://youtu.be/8Hq1aqVfesg?t=00h50m05s)



[knowledge of Microsoft programming](https://youtu.be/8Hq1aqVfesg?t=00h50m07s)



[languages well I can't say I completely](https://youtu.be/8Hq1aqVfesg?t=00h50m09s)



[blame you I work for primarily a](https://youtu.be/8Hq1aqVfesg?t=00h50m16s)



[Microsoft shop as well we're actually a](https://youtu.be/8Hq1aqVfesg?t=00h50m19s)



[Microsoft Partner and do a lot of](https://youtu.be/8Hq1aqVfesg?t=00h50m22s)



[consulting type gigs and whatnot but we](https://youtu.be/8Hq1aqVfesg?t=00h50m25s)



[have a few guys that are very much](https://youtu.be/8Hq1aqVfesg?t=00h50m29s)



[Python developers they like their AWS](https://youtu.be/8Hq1aqVfesg?t=00h50m31s)



[Python lambdas and all that jazz so they](https://youtu.be/8Hq1aqVfesg?t=00h50m34s)



[came from that world and we had clients](https://youtu.be/8Hq1aqVfesg?t=00h50m38s)



[that were needing it and so they were a](https://youtu.be/8Hq1aqVfesg?t=00h50m41s)



[wonderful fit so we do do a lot of](https://youtu.be/8Hq1aqVfesg?t=00h50m43s)



[c-sharp stuff but I can't say that](https://youtu.be/8Hq1aqVfesg?t=00h50m47s)



[that's all we do](https://youtu.be/8Hq1aqVfesg?t=00h50m50s)



[we definitely bounce around a little I](https://youtu.be/8Hq1aqVfesg?t=00h50m51s)



[am curious to check here real quick](https://youtu.be/8Hq1aqVfesg?t=00h50m54s)



[let's do the let's do the dark mode real](https://youtu.be/8Hq1aqVfesg?t=00h50m56s)



[fast and I want to look at that one more](https://youtu.be/8Hq1aqVfesg?t=00h50m59s)



[time it's bothering me that I don't see](https://youtu.be/8Hq1aqVfesg?t=00h51m02s)



[the cursor there too so this still works](https://youtu.be/8Hq1aqVfesg?t=00h51m06s)



[there](https://youtu.be/8Hq1aqVfesg?t=00h51m09s)



[that's kind of cool that that works I](https://youtu.be/8Hq1aqVfesg?t=00h51m11s)



[didn't realize that was actually gonna](https://youtu.be/8Hq1aqVfesg?t=00h51m13s)



[work sweet so let's check the color zone](https://youtu.be/8Hq1aqVfesg?t=00h51m14s)



[and make sure that that works there as](https://youtu.be/8Hq1aqVfesg?t=00h51m22s)



[well yeah so that's that's reasonable we](https://youtu.be/8Hq1aqVfesg?t=00h51m24s)



[still have that obnoxious issue I want](https://youtu.be/8Hq1aqVfesg?t=00h51m32s)



[to rework the combo box because of this](https://youtu.be/8Hq1aqVfesg?t=00h51m34s)



[stupid line basically layout rounding](https://youtu.be/8Hq1aqVfesg?t=00h51m36s)



[causes things to offset and round to a](https://youtu.be/8Hq1aqVfesg?t=00h51m42s)



[nearest pixel funniest parts of the](https://youtu.be/8Hq1aqVfesg?t=00h51m44s)



[whole thing as the language I use PHP](https://youtu.be/8Hq1aqVfesg?t=00h51m48s)



[and Python are not really known as](https://youtu.be/8Hq1aqVfesg?t=00h51m50s)



[strong object-oriented languages but I](https://youtu.be/8Hq1aqVfesg?t=00h51m52s)



[am Hopi to the core and I push my](https://youtu.be/8Hq1aqVfesg?t=00h51m56s)



[co-workers for solid style programming](https://youtu.be/8Hq1aqVfesg?t=00h52m00s)



[and everything else excellent excellent](https://youtu.be/8Hq1aqVfesg?t=00h52m02s)



[excellent that is wonderful to hear I](https://youtu.be/8Hq1aqVfesg?t=00h52m04s)



[teach at one of the local universities](https://youtu.be/8Hq1aqVfesg?t=00h52m07s)



[here and today's lesson was or I should](https://youtu.be/8Hq1aqVfesg?t=00h52m09s)



[say this week's lesson has been around](https://youtu.be/8Hq1aqVfesg?t=00h52m13s)



[the dependency inversion principle and](https://youtu.be/8Hq1aqVfesg?t=00h52m15s)



[what that means how to implement it the](https://youtu.be/8Hq1aqVfesg?t=00h52m19s)



[the topic today was all about just doing](https://youtu.be/8Hq1aqVfesg?t=00h52m25s)



[good interface design and and proper](https://youtu.be/8Hq1aqVfesg?t=00h52m28s)



[abstraction levels I see a lot of](https://youtu.be/8Hq1aqVfesg?t=00h52m32s)



[examples where people just do really](https://youtu.be/8Hq1aqVfesg?t=00h52m35s)



[really bad interface abstractions like I](https://youtu.be/8Hq1aqVfesg?t=00h52m36s)



[always I think the example I used in](https://youtu.be/8Hq1aqVfesg?t=00h52m41s)



[class today was like an interface of you](https://youtu.be/8Hq1aqVfesg?t=00h52m43s)



[know I read file where where it's very](https://youtu.be/8Hq1aqVfesg?t=00h52m46s)



[leaky in the the implementation just](https://youtu.be/8Hq1aqVfesg?t=00h52m50s)



[starts showing right through okay I](https://youtu.be/8Hq1aqVfesg?t=00h52m52s)



[think what I do is I just push my](https://youtu.be/8Hq1aqVfesg?t=00h52m56s)



[changes right the problem is those](https://youtu.be/8Hq1aqVfesg?t=00h52m58s)



[fields changes](https://youtu.be/8Hq1aqVfesg?t=00h53m03s)



[I'd like to look at those and see what's](https://youtu.be/8Hq1aqVfesg?t=00h53m07s)



[different what is the easiest way about](https://youtu.be/8Hq1aqVfesg?t=00h53m10s)



[this so I think what we do is this stage](https://youtu.be/8Hq1aqVfesg?t=00h53m14s)



[all amend am and sure grade and i think](https://youtu.be/8Hq1aqVfesg?t=00h53m18s)



[what i'm gonna do is create branch I'm](https://youtu.be/8Hq1aqVfesg?t=00h53m23s)



[just gonna cheat real quick and push](https://youtu.be/8Hq1aqVfesg?t=00h53m27s)



[this branch up I'll merge the other one](https://youtu.be/8Hq1aqVfesg?t=00h53m29s)



[but I think I'm gonna use this as a](https://youtu.be/8Hq1aqVfesg?t=00h53m31s)



[quick sanity check just so that I can go](https://youtu.be/8Hq1aqVfesg?t=00h53m33s)



[through and see what's changed a compare](https://youtu.be/8Hq1aqVfesg?t=00h53m36s)



[and pull requests because that's really](https://youtu.be/8Hq1aqVfesg?t=00h53m42s)



[what I'm looking to understand is what I](https://youtu.be/8Hq1aqVfesg?t=00h53m43s)



[what did I botch down here so the color](https://youtu.be/8Hq1aqVfesg?t=00h53m45s)



[zone one was fine and these fields were](https://youtu.be/8Hq1aqVfesg?t=00h53m49s)



[the problem areas alright so this line I](https://youtu.be/8Hq1aqVfesg?t=00h53m53s)



[want to fix this line is probably the](https://youtu.be/8Hq1aqVfesg?t=00h53m57s)



[area yeah so all of these changes are](https://youtu.be/8Hq1aqVfesg?t=00h54m01s)



[probably not worth keeping well but at](https://youtu.be/8Hq1aqVfesg?t=00h54m05s)



[least I've got a nice list now all right](https://youtu.be/8Hq1aqVfesg?t=00h54m10s)



[so let's just gonna set this guy to the](https://youtu.be/8Hq1aqVfesg?t=00h54m11s)



[side where I can keep an eye on it](https://youtu.be/8Hq1aqVfesg?t=00h54m14s)



[because I do want to go through and fix](https://youtu.be/8Hq1aqVfesg?t=00h54m16s)



[the display cool see you in a few okay](https://youtu.be/8Hq1aqVfesg?t=00h54m18s)



[so let's let's take a look at this](https://youtu.be/8Hq1aqVfesg?t=00h54m24s)



[actually we might just do it here this](https://youtu.be/8Hq1aqVfesg?t=00h54m27s)



[might be simpler okay so 2:38 I want to](https://youtu.be/8Hq1aqVfesg?t=00h54m29s)



[go back to 27](https://youtu.be/8Hq1aqVfesg?t=00h54m32s)



[okay so text fields text fields text](https://youtu.be/8Hq1aqVfesg?t=00h54m33s)



[fields 38 boom I want you to be at 27](https://youtu.be/8Hq1aqVfesg?t=00h54m36s)



[we'll deal with your conflict in a](https://youtu.be/8Hq1aqVfesg?t=00h54m43s)



[minute come back to you because you are](https://youtu.be/8Hq1aqVfesg?t=00h54m45s)



[probably an issue 307 needs to be a](https://youtu.be/8Hq1aqVfesg?t=00h54m51s)



[seven](https://youtu.be/8Hq1aqVfesg?t=00h54m55s)



[let's see 307 needs to be what is a](https://youtu.be/8Hq1aqVfesg?t=00h54m57s)



[seven needs to be a six](https://youtu.be/8Hq1aqVfesg?t=00h55m02s)



[I basically just want to revert all of](https://youtu.be/8Hq1aqVfesg?t=00h55m05s)



[these changes back and figure out where](https://youtu.be/8Hq1aqVfesg?t=00h55m07s)



[where this box needs to end up the](https://youtu.be/8Hq1aqVfesg?t=00h55m09s)



[unfortunate part is this view 304](https://youtu.be/8Hq1aqVfesg?t=00h55m12s)



[let's see 296 is the one I missed the](https://youtu.be/8Hq1aqVfesg?t=00h55m16s)



[unfortunate part is this view has gotten](https://youtu.be/8Hq1aqVfesg?t=00h55m21s)



[a little unwieldy 296 that's not right](https://youtu.be/8Hq1aqVfesg?t=00h55m23s)



[307 315 I'm reading it in the wrong way](https://youtu.be/8Hq1aqVfesg?t=00h55m29s)



[so it's basically too many things tied](https://youtu.be/8Hq1aqVfesg?t=00h55m34s)



[to very specific grids I'd love to](https://youtu.be/8Hq1aqVfesg?t=00h55m39s)



[refactor this and just nest like some](https://youtu.be/8Hq1aqVfesg?t=00h55m41s)



[stack panels so that not everything](https://youtu.be/8Hq1aqVfesg?t=00h55m43s)



[needs explicit row definitions like this](https://youtu.be/8Hq1aqVfesg?t=00h55m45s)



[because it gets it gets to be a big pain](https://youtu.be/8Hq1aqVfesg?t=00h55m48s)



[on the merges so 327 needs to be an 8](https://youtu.be/8Hq1aqVfesg?t=00h55m50s)



[maybe 27 needs to be an 8 yeah having](https://youtu.be/8Hq1aqVfesg?t=00h55m53s)



[everything in these individual grids](https://youtu.be/8Hq1aqVfesg?t=00h55m57s)



[just kind of gets to be a pain 343 343](https://youtu.be/8Hq1aqVfesg?t=00h55m59s)



[and I think that was that was great](https://youtu.be/8Hq1aqVfesg?t=00h56m04s)



[great okay so that fixes that that fixes](https://youtu.be/8Hq1aqVfesg?t=00h56m09s)



[that okay so now you my friend I need to](https://youtu.be/8Hq1aqVfesg?t=00h56m13s)



[figure out where you are let's just fire](https://youtu.be/8Hq1aqVfesg?t=00h56m17s)



[this up one of the other nice things is](https://youtu.be/8Hq1aqVfesg?t=00h56m19s)



[at least with WPF you can edit the zamel](https://youtu.be/8Hq1aqVfesg?t=00h56m22s)



[while the apps running and just watch](https://youtu.be/8Hq1aqVfesg?t=00h56m27s)



[the change happen I realized that's not](https://youtu.be/8Hq1aqVfesg?t=00h56m29s)



[a novel thing for web developers but for](https://youtu.be/8Hq1aqVfesg?t=00h56m31s)



[those of us who've been building apps](https://youtu.be/8Hq1aqVfesg?t=00h56m36s)



[for a while it was a godsend okay so](https://youtu.be/8Hq1aqVfesg?t=00h56m37s)



[what do we got going here so the](https://youtu.be/8Hq1aqVfesg?t=00h56m40s)



[floating password and our OS box are](https://youtu.be/8Hq1aqVfesg?t=00h56m43s)



[basically in the same bit and I think](https://youtu.be/8Hq1aqVfesg?t=00h56m46s)



[what I want to do is push the floating](https://youtu.be/8Hq1aqVfesg?t=00h56m50s)



[password over and this guy down maybe](https://youtu.be/8Hq1aqVfesg?t=00h56m57s)



[trying to decide what's what's easiest](https://youtu.be/8Hq1aqVfesg?t=00h57m02s)



[so this is going to be where are we I](https://youtu.be/8Hq1aqVfesg?t=00h57m04s)



[want the](https://youtu.be/8Hq1aqVfesg?t=00h57m08s)



[to 93 to 93 so this guy here and the](https://youtu.be/8Hq1aqVfesg?t=00h57m12s)



[floating password box just the guy on](https://youtu.be/8Hq1aqVfesg?t=00h57m18s)



[top of them are so this guy here grid](https://youtu.be/8Hq1aqVfesg?t=00h57m22s)



[rows 7 column zero why is](https://youtu.be/8Hq1aqVfesg?t=00h57m28s)



[row six why is row seven and row six](https://youtu.be/8Hq1aqVfesg?t=00h57m35s)



[conflicting with each other this seems](https://youtu.be/8Hq1aqVfesg?t=00h57m40s)



[something is very very off oh I bet you](https://youtu.be/8Hq1aqVfesg?t=00h57m44s)



[I know what it is I bet you there is a](https://youtu.be/8Hq1aqVfesg?t=00h57m49s)



[grid that doesn't have that many rows or](https://youtu.be/8Hq1aqVfesg?t=00h57m51s)



[columns alright cuz that would do it](https://youtu.be/8Hq1aqVfesg?t=00h57m53s)



[so we're collapse collapse and this is](https://youtu.be/8Hq1aqVfesg?t=00h57m57s)



[where zamel gets big and ugly and](https://youtu.be/8Hq1aqVfesg?t=00h58m03s)



[miserable and a lot of it has to do with](https://youtu.be/8Hq1aqVfesg?t=00h58m06s)



[this view itself just being unwieldy and](https://youtu.be/8Hq1aqVfesg?t=00h58m10s)



[really needing to be broken down into](https://youtu.be/8Hq1aqVfesg?t=00h58m12s)



[small individual controls because in](https://youtu.be/8Hq1aqVfesg?t=00h58m15s)



[general that's what you do to work](https://youtu.be/8Hq1aqVfesg?t=00h58m18s)



[around this problem is you you take each](https://youtu.be/8Hq1aqVfesg?t=00h58m20s)



[of these individual sections and break](https://youtu.be/8Hq1aqVfesg?t=00h58m23s)



[them into their own bits](https://youtu.be/8Hq1aqVfesg?t=00h58m25s)



[nope this thing has way too many row](https://youtu.be/8Hq1aqVfesg?t=00h58m28s)



[definitions okay](https://youtu.be/8Hq1aqVfesg?t=00h58m31s)



[I am making a bit of an assumption about](https://youtu.be/8Hq1aqVfesg?t=00h58m38s)



[which one this is let's jump back so](https://youtu.be/8Hq1aqVfesg?t=00h58m40s)



[floating hint password and foreground](https://youtu.be/8Hq1aqVfesg?t=00h58m46s)



[underscore green](https://youtu.be/8Hq1aqVfesg?t=00h58m51s)



[so this is definitely the guy on top](https://youtu.be/8Hq1aqVfesg?t=00h58m56s)



[right because we take him out](https://youtu.be/8Hq1aqVfesg?t=00h58m58s)



[still there](https://youtu.be/8Hq1aqVfesg?t=00h59m06s)



[interesting interesting interesting](https://youtu.be/8Hq1aqVfesg?t=00h59m09s)



[[Applause]](https://youtu.be/8Hq1aqVfesg?t=00h59m14s)



[a little confused as to what's going on](https://youtu.be/8Hq1aqVfesg?t=00h59m19s)



[okay so let's let's think this one](https://youtu.be/8Hq1aqVfesg?t=00h59m24s)



[through it real quick so we've got a](https://youtu.be/8Hq1aqVfesg?t=00h59m26s)



[grid row six grid column one grid row](https://youtu.be/8Hq1aqVfesg?t=00h59m27s)



[six column three so these are the two](https://youtu.be/8Hq1aqVfesg?t=00h59m35s)



[guys sitting side by side alright so](https://youtu.be/8Hq1aqVfesg?t=00h59m37s)



[let's go ahead and put this guy back](https://youtu.be/8Hq1aqVfesg?t=00h59m40s)



[that's so the question is this guy is](https://youtu.be/8Hq1aqVfesg?t=00h59m41s)



[sitting on top which means she's higher](https://youtu.be/8Hq1aqVfesg?t=00h59m45s)



[in the Z order six column one so here](https://youtu.be/8Hq1aqVfesg?t=00h59m48s)



[yeah so this is functionally the problem](https://youtu.be/8Hq1aqVfesg?t=00h59m53s)



[is really what we want to do is we just](https://youtu.be/8Hq1aqVfesg?t=00h59m55s)



[want to insert this guy do I want to](https://youtu.be/8Hq1aqVfesg?t=00h59m57s)



[bite off fixing these things right now I](https://youtu.be/8Hq1aqVfesg?t=01h00m01s)



[don't really want to don't really want](https://youtu.be/8Hq1aqVfesg?t=01h00m04s)



[to so let's let's look if we just push](https://youtu.be/8Hq1aqVfesg?t=01h00m08s)



[this guy down because this guy is just](https://youtu.be/8Hq1aqVfesg?t=01h00m11s)



[oh this is the whole parent grid yuck](https://youtu.be/8Hq1aqVfesg?t=01h00m15s)



[yuck yuck yuck yuck](https://youtu.be/8Hq1aqVfesg?t=01h00m18s)



[I think the solution is just going to be](https://youtu.be/8Hq1aqVfesg?t=01h00m27s)



[this alright because this largely](https://youtu.be/8Hq1aqVfesg?t=01h00m29s)



[duplicates this guy over here](https://youtu.be/8Hq1aqVfesg?t=01h00m33s)



[am I wrong is there anything special](https://youtu.be/8Hq1aqVfesg?t=01h00m38s)



[being set color zone assist mode](https://youtu.be/8Hq1aqVfesg?t=01h00m40s)



[inverted and it sets an underlying brush](https://youtu.be/8Hq1aqVfesg?t=01h00m43s)



[I don't know if we care right let's take](https://youtu.be/8Hq1aqVfesg?t=01h00m48s)



[let's take these guys here and go and](https://youtu.be/8Hq1aqVfesg?t=01h00m54s)



[place them on the other combo box and](https://youtu.be/8Hq1aqVfesg?t=01h00m57s)



[call it a day](https://youtu.be/8Hq1aqVfesg?t=01h00m58s)



[I think that's the way we're going to do](https://youtu.be/8Hq1aqVfesg?t=01h00m59s)



[it so one two three four let's see so](https://youtu.be/8Hq1aqVfesg?t=01h01m02s)



[column three maybe this one that's not](https://youtu.be/8Hq1aqVfesg?t=01h01m08s)



[it column three this one](https://youtu.be/8Hq1aqVfesg?t=01h01m13s)



[here and there we go so let's see here](https://youtu.be/8Hq1aqVfesg?t=01h01m20s)



[so this guy colors on inverted text](https://youtu.be/8Hq1aqVfesg?t=01h01m25s)



[underline brush right and then this guy](https://youtu.be/8Hq1aqVfesg?t=01h01m32s)



[goes away boom for some reason my edit](https://youtu.be/8Hq1aqVfesg?t=01h01m34s)



[and continue isn't making that up](https://youtu.be/8Hq1aqVfesg?t=01h01m40s)



[mildly disappointing but we're gonna](https://youtu.be/8Hq1aqVfesg?t=01h01m43s)



[take a take a look and see how this goes](https://youtu.be/8Hq1aqVfesg?t=01h01m46s)



[because if this works this seems like we](https://youtu.be/8Hq1aqVfesg?t=01h01m51s)



[can get this merged in and then have yet](https://youtu.be/8Hq1aqVfesg?t=01h01m54s)



[one more thing done](https://youtu.be/8Hq1aqVfesg?t=01h01m57s)



[oh that is interesting](https://youtu.be/8Hq1aqVfesg?t=01h02m04s)



[I wonder if that's intentional to have](https://youtu.be/8Hq1aqVfesg?t=01h02m14s)



[that light see-through fairly confident](https://youtu.be/8Hq1aqVfesg?t=01h02m16s)



[it's not only because the material](https://youtu.be/8Hq1aqVfesg?t=01h02m21s)



[design specification they abhor](https://youtu.be/8Hq1aqVfesg?t=01h02m27s)



[transparency well not completely a poor](https://youtu.be/8Hq1aqVfesg?t=01h02m29s)



[but it's usually avoided that](https://youtu.be/8Hq1aqVfesg?t=01h02m33s)



[ingredients everything is done with](https://youtu.be/8Hq1aqVfesg?t=01h02m35s)



[shadows and height I mean I kind of like](https://youtu.be/8Hq1aqVfesg?t=01h02m41s)



[the look of it but I think that that's](https://youtu.be/8Hq1aqVfesg?t=01h02m46s)



[probably problematic okay so I think now](https://youtu.be/8Hq1aqVfesg?t=01h02m48s)



[that we can get at this guy there's](https://youtu.be/8Hq1aqVfesg?t=01h02m53s)



[there's a bit of a bug to address here](https://youtu.be/8Hq1aqVfesg?t=01h02m54s)



[so I think that's the solution is we](https://youtu.be/8Hq1aqVfesg?t=01h02m58s)



[just move those attached properties over](https://youtu.be/8Hq1aqVfesg?t=01h02m59s)



[and everyone's happy](https://youtu.be/8Hq1aqVfesg?t=01h03m01s)



[so let's start with this if we go back](https://youtu.be/8Hq1aqVfesg?t=01h03m03s)



[to this branch we can work on here great](https://youtu.be/8Hq1aqVfesg?t=01h03m06s)



[okay so let's let's figure out where](https://youtu.be/8Hq1aqVfesg?t=01h03m11s)



[that guy is going from close close close](https://youtu.be/8Hq1aqVfesg?t=01h03m14s)



[close and okay so style for the combo](https://youtu.be/8Hq1aqVfesg?t=01h03m17s)



[box is down here you can kind of look at](https://youtu.be/8Hq1aqVfesg?t=01h03m24s)



[the changes that be going in because](https://youtu.be/8Hq1aqVfesg?t=01h03m28s)



[that's not it that's not a problem](https://youtu.be/8Hq1aqVfesg?t=01h03m31s)



[[Music]](https://youtu.be/8Hq1aqVfesg?t=01h03m34s)



[that's less of an issue](https://youtu.be/8Hq1aqVfesg?t=01h03m36s)



[welcome back just discovered that I've](https://youtu.be/8Hq1aqVfesg?t=01h03m40s)



[got a bug in my code so we're gonna see](https://youtu.be/8Hq1aqVfesg?t=01h03m45s)



[if we can figure out what what I did to](https://youtu.be/8Hq1aqVfesg?t=01h03m49s)



[break this because this allows what is](https://youtu.be/8Hq1aqVfesg?t=01h03m52s)



[this doing setter](https://youtu.be/8Hq1aqVfesg?t=01h03m58s)



[that's the attached property and then](https://youtu.be/8Hq1aqVfesg?t=01h04m03s)



[the the background to the attached](https://youtu.be/8Hq1aqVfesg?t=01h04m05s)



[property okay that's fine that is fine](https://youtu.be/8Hq1aqVfesg?t=01h04m08s)



[underlying brush gets set I'm more](https://youtu.be/8Hq1aqVfesg?t=01h04m14s)



[interested in this color mode and how](https://youtu.be/8Hq1aqVfesg?t=01h04m17s)



[this is being applied right because the](https://youtu.be/8Hq1aqVfesg?t=01h04m19s)



[inverted is ultimately what's causing](https://youtu.be/8Hq1aqVfesg?t=01h04m22s)



[the problem let's see so this guy comes](https://youtu.be/8Hq1aqVfesg?t=01h04m24s)



[through background is open true color](https://youtu.be/8Hq1aqVfesg?t=01h04m32s)



[mode standard so I am curious where the](https://youtu.be/8Hq1aqVfesg?t=01h04m40s)



[pop up is picking up because the pop up](https://youtu.be/8Hq1aqVfesg?t=01h04m43s)



[needs to pay attention to this this](https://youtu.be/8Hq1aqVfesg?t=01h04m47s)



[color zone mode just fine I'm just I'm](https://youtu.be/8Hq1aqVfesg?t=01h04m53s)



[not seeing the code to pick that up so](https://youtu.be/8Hq1aqVfesg?t=01h05m00s)



[it clearly picks up most of it Terral](https://youtu.be/8Hq1aqVfesg?t=01h05m03s)



[design light background](https://youtu.be/8Hq1aqVfesg?t=01h05m07s)



[so this is just setting the background](https://youtu.be/8Hq1aqVfesg?t=01h05m16s)



[property on the pop-up itself that's](https://youtu.be/8Hq1aqVfesg?t=01h05m18s)



[probably it](https://youtu.be/8Hq1aqVfesg?t=01h05m23s)



[I'm guessing and I say that only because](https://youtu.be/8Hq1aqVfesg?t=01h05m25s)



[I suspect what's happening let's fire](https://youtu.be/8Hq1aqVfesg?t=01h05m30s)



[this up and double-check but I believe](https://youtu.be/8Hq1aqVfesg?t=01h05m32s)



[what's happening is some of the brushes](https://youtu.be/8Hq1aqVfesg?t=01h05m34s)



[in an effort to dampen them have an](https://youtu.be/8Hq1aqVfesg?t=01h05m36s)



[alpha Channel set and so I suspect that](https://youtu.be/8Hq1aqVfesg?t=01h05m42s)



[that is why we're seeing this guy show](https://youtu.be/8Hq1aqVfesg?t=01h05m47s)



[through right](https://youtu.be/8Hq1aqVfesg?t=01h05m51s)



[I think that's visible underneath okay](https://youtu.be/8Hq1aqVfesg?t=01h05m52s)



[so let's fire up snoop and just confirm](https://youtu.be/8Hq1aqVfesg?t=01h05m54s)



[that that that is in fact in fact the](https://youtu.be/8Hq1aqVfesg?t=01h05m56s)



[case](https://youtu.be/8Hq1aqVfesg?t=01h06m00s)



[okay so snoop window here main window](https://youtu.be/8Hq1aqVfesg?t=01h06m01s)



[here snoop get out of my way for a](https://youtu.be/8Hq1aqVfesg?t=01h06m05s)



[minute pop you open navigate so I think](https://youtu.be/8Hq1aqVfesg?t=01h06m07s)



[if I just walk my way up to the pop-up](https://youtu.be/8Hq1aqVfesg?t=01h06m11s)



[and I'm only interested in looking at](https://youtu.be/8Hq1aqVfesg?t=01h06m14s)



[its background property let's see here](https://youtu.be/8Hq1aqVfesg?t=01h06m17s)



[where is it logical content control](https://youtu.be/8Hq1aqVfesg?t=01h06m21s)



[that's not it](https://youtu.be/8Hq1aqVfesg?t=01h06m30s)



[their material design body no no alpha](https://youtu.be/8Hq1aqVfesg?t=01h06m36s)



[Channel on it so why does this show if](https://youtu.be/8Hq1aqVfesg?t=01h06m42s)



[that has a solid background how is it](https://youtu.be/8Hq1aqVfesg?t=01h06m46s)



[that I'm seen through it how is it well](https://youtu.be/8Hq1aqVfesg?t=01h06m49s)



[hold on yeah this guy does have an alpha](https://youtu.be/8Hq1aqVfesg?t=01h06m58s)



[Channel DD it's just slow to update okay](https://youtu.be/8Hq1aqVfesg?t=01h07m01s)



[so there is an alpha channel being](https://youtu.be/8Hq1aqVfesg?t=01h07m03s)



[applied that is a bit unfortunate](https://youtu.be/8Hq1aqVfesg?t=01h07m06s)



[I'm not sure what I'm not sure the](https://youtu.be/8Hq1aqVfesg?t=01h07m20s)



[proper way to handle this because what](https://youtu.be/8Hq1aqVfesg?t=01h07m22s)



[should the background color be I think](https://youtu.be/8Hq1aqVfesg?t=01h07m24s)



[the answer is that this this is probably](https://youtu.be/8Hq1aqVfesg?t=01h07m28s)



[pointing out that we should be adjusting](https://youtu.be/8Hq1aqVfesg?t=01h07m31s)



[our template colors to not have that I](https://youtu.be/8Hq1aqVfesg?t=01h07m34s)



[think that's the that's the sort of the](https://youtu.be/8Hq1aqVfesg?t=01h07m45s)



[crux of the problem here so cuz this guy](https://youtu.be/8Hq1aqVfesg?t=01h07m49s)



[here has several triggers right and he's](https://youtu.be/8Hq1aqVfesg?t=01h07m51s)



[going through and setting it so in this](https://youtu.be/8Hq1aqVfesg?t=01h07m55s)



[case it's using the inverted one and so](https://youtu.be/8Hq1aqVfesg?t=01h07m58s)



[it's grabbing material designed body and](https://youtu.be/8Hq1aqVfesg?t=01h08m01s)



[I believe that's the one that's let's go](https://youtu.be/8Hq1aqVfesg?t=01h08m08s)



[and check the colors but I'm fairly](https://youtu.be/8Hq1aqVfesg?t=01h08m11s)



[confident that that's where that guy is](https://youtu.be/8Hq1aqVfesg?t=01h08m14s)



[coming from so not that let's see is it](https://youtu.be/8Hq1aqVfesg?t=01h08m15s)



[buried not in my themes why am i](https://youtu.be/8Hq1aqVfesg?t=01h08m22s)



[confused those are the enums](https://youtu.be/8Hq1aqVfesg?t=01h08m25s)



[it's the theme mix-ins right team](https://youtu.be/8Hq1aqVfesg?t=01h08m32s)



[assists yeah change theme where's the](https://youtu.be/8Hq1aqVfesg?t=01h08m38s)



[where's my set theme gets theme research](https://youtu.be/8Hq1aqVfesg?t=01h08m45s)



[dictionary change theme blah blah blah](https://youtu.be/8Hq1aqVfesg?t=01h08m48s)



[no where is the other one](https://youtu.be/8Hq1aqVfesg?t=01h08m55s)



[yeah create theme and I'm interested in](https://youtu.be/8Hq1aqVfesg?t=01h09m03s)



[the setters of this guy because the body](https://youtu.be/8Hq1aqVfesg?t=01h09m08s)



[property should show me where this guy](https://youtu.be/8Hq1aqVfesg?t=01h09m12s)



[gets set set solid color brush theme](https://youtu.be/8Hq1aqVfesg?t=01h09m15s)



[body yeah that's more like it](https://youtu.be/8Hq1aqVfesg?t=01h09m22s)



[and get theme set theme there is a](https://youtu.be/8Hq1aqVfesg?t=01h09m29s)



[method in here that I wrote at one point](https://youtu.be/8Hq1aqVfesg?t=01h09m35s)



[that has all of the default colors for](https://youtu.be/8Hq1aqVfesg?t=01h09m38s)



[the light and the dark theme which is](https://youtu.be/8Hq1aqVfesg?t=01h09m41s)



[ultimately what I'm hunting for and I'm](https://youtu.be/8Hq1aqVfesg?t=01h09m43s)



[I base theme one of you go to](https://youtu.be/8Hq1aqVfesg?t=01h09m54s)



[implementation light theme there we go](https://youtu.be/8Hq1aqVfesg?t=01h09m59s)



[yeah so there's the problem I'm willing](https://youtu.be/8Hq1aqVfesg?t=01h10m04s)



[to bet if I just toggle this over right](https://youtu.be/8Hq1aqVfesg?t=01h10m06s)



[and we can confirm this real quick that](https://youtu.be/8Hq1aqVfesg?t=01h10m08s)



[that will now take the the color all the](https://youtu.be/8Hq1aqVfesg?t=01h10m11s)



[way to black and we probably need to](https://youtu.be/8Hq1aqVfesg?t=01h10m18s)



[adjust these I don't know does anyone](https://youtu.be/8Hq1aqVfesg?t=01h10m22s)



[have a reasonable way of going to the](https://youtu.be/8Hq1aqVfesg?t=01h10m25s)



[I'm effectively looking for the RGB code](https://youtu.be/8Hq1aqVfesg?t=01h10m29s)



[for the lightish group black given an](https://youtu.be/8Hq1aqVfesg?t=01h10m31s)



[alpha channel one I basically want to](https://youtu.be/8Hq1aqVfesg?t=01h10m37s)



[convert an alpha RGB to a regular one on](https://youtu.be/8Hq1aqVfesg?t=01h10m39s)



[one's going twice I can probably find](https://youtu.be/8Hq1aqVfesg?t=01h10m46s)



[one here oh that did not fix it that is](https://youtu.be/8Hq1aqVfesg?t=01h10m47s)



[surprising to me which brush are you](https://youtu.be/8Hq1aqVfesg?t=01h10m54s)



[using](https://youtu.be/8Hq1aqVfesg?t=01h10m59s)



[that should have changed now I have to](https://youtu.be/8Hq1aqVfesg?t=01h11m04s)



[look again I'm just really confused](https://youtu.be/8Hq1aqVfesg?t=01h11m11s)



[unless it picked up stale data which I](https://youtu.be/8Hq1aqVfesg?t=01h11m15s)



[don't think it should have so I believe](https://youtu.be/8Hq1aqVfesg?t=01h11m18s)



[it was this border here is where we](https://youtu.be/8Hq1aqVfesg?t=01h11m23s)



[picked up the background let's see here](https://youtu.be/8Hq1aqVfesg?t=01h11m24s)



[do to do material design body parent](https://youtu.be/8Hq1aqVfesg?t=01h11m28s)



[template](https://youtu.be/8Hq1aqVfesg?t=01h11m31s)



[yeah it's still picking up material](https://youtu.be/8Hq1aqVfesg?t=01h11m38s)



[design body as is there a I guess I](https://youtu.be/8Hq1aqVfesg?t=01h11m41s)



[should look at how the theme is being](https://youtu.be/8Hq1aqVfesg?t=01h11m50s)



[set that could change it yep it's being](https://youtu.be/8Hq1aqVfesg?t=01h11m52s)



[done with the old colors not the new](https://youtu.be/8Hq1aqVfesg?t=01h11m57s)



[ones wants to remember to keep these](https://youtu.be/8Hq1aqVfesg?t=01h12m01s)



[things in sync see themes that's so](https://youtu.be/8Hq1aqVfesg?t=01h12m04s)



[sorry the assembly and material design](https://youtu.be/8Hq1aqVfesg?t=01h12m15s)



[themes WPF and no no thank you](https://youtu.be/8Hq1aqVfesg?t=01h12m18s)



[to use to the old one of themes and then](https://youtu.be/8Hq1aqVfesg?t=01h12m23s)



[the light theme in here so material](https://youtu.be/8Hq1aqVfesg?t=01h12m26s)



[design body this is the these are the](https://youtu.be/8Hq1aqVfesg?t=01h12m33s)



[values that need to be kept in sync with](https://youtu.be/8Hq1aqVfesg?t=01h12m38s)



[the C sharp ones](https://youtu.be/8Hq1aqVfesg?t=01h12m40s)



[well that worked aside from the fact](https://youtu.be/8Hq1aqVfesg?t=01h12m59s)



[that I was stupid about which direction](https://youtu.be/8Hq1aqVfesg?t=01h13m01s)



[to go making it fully transparent](https://youtu.be/8Hq1aqVfesg?t=01h13m07s)



[instead of fully opaque is a bit of a](https://youtu.be/8Hq1aqVfesg?t=01h13m13s)



[problem](https://youtu.be/8Hq1aqVfesg?t=01h13m15s)



[yeah I'm not entirely sure the the](https://youtu.be/8Hq1aqVfesg?t=01h13m18s)



[correct solution here fields I'm](https://youtu.be/8Hq1aqVfesg?t=01h13m21s)



[thinking what I'm going to do is push](https://youtu.be/8Hq1aqVfesg?t=01h13m30s)



[this change yeah so now it's actually](https://youtu.be/8Hq1aqVfesg?t=01h13m32s)



[opaque but now it's because of it it's](https://youtu.be/8Hq1aqVfesg?t=01h13m35s)



[also now hiding the the hover effect](https://youtu.be/8Hq1aqVfesg?t=01h13m40s)



[okay so I think we put that back the way](https://youtu.be/8Hq1aqVfesg?t=01h13m44s)



[it was we changed this guy here to go](https://youtu.be/8Hq1aqVfesg?t=01h13m48s)



[back to way the way he was and I think](https://youtu.be/8Hq1aqVfesg?t=01h13m54s)



[we're gonna just push these changes](https://youtu.be/8Hq1aqVfesg?t=01h13m59s)



[right so what is sitting here all of](https://youtu.be/8Hq1aqVfesg?t=01h14m00s)



[those changes so change amend men](https://youtu.be/8Hq1aqVfesg?t=01h14m06s)



[previous commit and forced push up the](https://youtu.be/8Hq1aqVfesg?t=01h14m09s)



[branch and I think what I'll do is I'll](https://youtu.be/8Hq1aqVfesg?t=01h14m12s)



[leave a comment on there and I think](https://youtu.be/8Hq1aqVfesg?t=01h14m15s)



[it's just gonna be a matter of trying to](https://youtu.be/8Hq1aqVfesg?t=01h14m19s)



[figure out what is the appropriate fix](https://youtu.be/8Hq1aqVfesg?t=01h14m20s)



[right because I don't know how to handle](https://youtu.be/8Hq1aqVfesg?t=01h14m22s)



[this case where it's trying to figure](https://youtu.be/8Hq1aqVfesg?t=01h14m26s)



[out the the correct background color](https://youtu.be/8Hq1aqVfesg?t=01h14m30s)



[Hayek's toll so working on the material](https://youtu.be/8Hq1aqVfesg?t=01h14m33s)



[design and zamel project so this guy](https://youtu.be/8Hq1aqVfesg?t=01h14m37s)



[here I'll drop a link in the chat if](https://youtu.be/8Hq1aqVfesg?t=01h14m41s)



[you're interested basically I've been](https://youtu.be/8Hq1aqVfesg?t=01h14m44s)



[absent from the project for a couple](https://youtu.be/8Hq1aqVfesg?t=01h14m47s)



[weeks and so I was trying to get a bunch](https://youtu.be/8Hq1aqVfesg?t=01h14m50s)



[of pull requests into good states and](https://youtu.be/8Hq1aqVfesg?t=01h14m51s)



[merged and cleaned up and I think I just](https://youtu.be/8Hq1aqVfesg?t=01h14m53s)



[came to the conclusion that one of these](https://youtu.be/8Hq1aqVfesg?t=01h14m57s)



[pull requests I can't reasonably merge](https://youtu.be/8Hq1aqVfesg?t=01h14m59s)



[there's not a there's not an obvious or](https://youtu.be/8Hq1aqVfesg?t=01h15m05s)



[a simple solution to the question of](https://youtu.be/8Hq1aqVfesg?t=01h15m10s)



[what how should it work so I think I'm](https://youtu.be/8Hq1aqVfesg?t=01h15m13s)



[gonna leave it sitting open for now and](https://youtu.be/8Hq1aqVfesg?t=01h15m15s)



[post a question and go from there](https://youtu.be/8Hq1aqVfesg?t=01h15m18s)



[I think is gonna be the way this works](https://youtu.be/8Hq1aqVfesg?t=01h15m20s)



[so let's see rebased and updated code](https://youtu.be/8Hq1aqVfesg?t=01h15m22s)



[latest library changes let's see in the](https://youtu.be/8Hq1aqVfesg?t=01h15m32s)



[demo app with the inverted combo box you](https://youtu.be/8Hq1aqVfesg?t=01h15m38s)



[will notice the background is](https://youtu.be/8Hq1aqVfesg?t=01h15m45s)



[transparent because of this theme brush](https://youtu.be/8Hq1aqVfesg?t=01h15m50s)



[not currently sure how to handle this](https://youtu.be/8Hq1aqVfesg?t=01h15m58s)



[case okay so we can go through I think](https://youtu.be/8Hq1aqVfesg?t=01h16m02s)



[the the ultimate solution that I'm](https://youtu.be/8Hq1aqVfesg?t=01h16m07s)



[probably reopen for requests did not](https://youtu.be/8Hq1aqVfesg?t=01h16m09s)



[mean to close it I I think ultimately](https://youtu.be/8Hq1aqVfesg?t=01h16m13s)



[what I'm what I'm probably going to do](https://youtu.be/8Hq1aqVfesg?t=01h16m17s)



[is try to go through all those theme](https://youtu.be/8Hq1aqVfesg?t=01h16m19s)



[colors and eliminate the alpha Channel](https://youtu.be/8Hq1aqVfesg?t=01h16m21s)



[and just convert them to the appropriate](https://youtu.be/8Hq1aqVfesg?t=01h16m23s)



[grey level because I the only time where](https://youtu.be/8Hq1aqVfesg?t=01h16m26s)



[the Alpha Channel actually matters is](https://youtu.be/8Hq1aqVfesg?t=01h16m29s)



[like the the hover effect in like the](https://youtu.be/8Hq1aqVfesg?t=01h16m32s)



[list boxes but we've been bit enough](https://youtu.be/8Hq1aqVfesg?t=01h16m35s)



[times with the merging of transparent](https://youtu.be/8Hq1aqVfesg?t=01h16m38s)



[colors that I'm I'm sort of tempted to](https://youtu.be/8Hq1aqVfesg?t=01h16m41s)



[go and just kill them all off all right](https://youtu.be/8Hq1aqVfesg?t=01h16m44s)



[let's see so I don't think this guy is](https://youtu.be/8Hq1aqVfesg?t=01h16m47s)



[gonna make it the filter chips are](https://youtu.be/8Hq1aqVfesg?t=01h16m51s)



[interesting not sure I want to tackle](https://youtu.be/8Hq1aqVfesg?t=01h16m53s)



[that one at the moment and that one's a](https://youtu.be/8Hq1aqVfesg?t=01h16m56s)



[bigger one so let's take a look at some](https://youtu.be/8Hq1aqVfesg?t=01h16m58s)



[of these issues right so if anyone has](https://youtu.be/8Hq1aqVfesg?t=01h16m59s)



[something that they think is a pet issue](https://youtu.be/8Hq1aqVfesg?t=01h17m02s)



[or something that they're wanting to](https://youtu.be/8Hq1aqVfesg?t=01h17m04s)



[look at let me know this one here I](https://youtu.be/8Hq1aqVfesg?t=01h17m06s)



[don't know if anyone's interested in](https://youtu.be/8Hq1aqVfesg?t=01h17m08s)



[jumping in on the library basically](https://youtu.be/8Hq1aqVfesg?t=01h17m10s)



[there's hey why didn't I make these](https://youtu.be/8Hq1aqVfesg?t=01h17m12s)



[check boxes that was the intent right](https://youtu.be/8Hq1aqVfesg?t=01h17m16s)



[preview what I'm what am i screwing up](https://youtu.be/8Hq1aqVfesg?t=01h17m19s)



[here](https://youtu.be/8Hq1aqVfesg?t=01h17m22s)



[these should be that oh I got the - on](https://youtu.be/8Hq1aqVfesg?t=01h17m24s)



[the wrong side that's what I did wrong](https://youtu.be/8Hq1aqVfesg?t=01h17m28s)



[well like these boom and preview there](https://youtu.be/8Hq1aqVfesg?t=01h17m30s)



[we go update comment basically the icons](https://youtu.be/8Hq1aqVfesg?t=01h17m35s)



[in this library are keyed with an enum](https://youtu.be/8Hq1aqVfesg?t=01h17m38s)



[that gets auto-generated so we've got a](https://youtu.be/8Hq1aqVfesg?t=01h17m40s)



[CI pipeline that goes and builds it up](https://youtu.be/8Hq1aqVfesg?t=01h17m43s)



[on a nightly basis and it would be nice](https://youtu.be/8Hq1aqVfesg?t=01h17m45s)



[to adjust the script so that our Enuma](https://youtu.be/8Hq1aqVfesg?t=01h17m49s)



[actually has a nun or sir with value](https://youtu.be/8Hq1aqVfesg?t=01h17m51s)



[that displays no icon so if somebody](https://youtu.be/8Hq1aqVfesg?t=01h17m53s)



[wanted to easily toggle it off there was](https://youtu.be/8Hq1aqVfesg?t=01h17m56s)



[an option to do that discovered we](https://youtu.be/8Hq1aqVfesg?t=01h17m58s)



[weren't generating that so I left it](https://youtu.be/8Hq1aqVfesg?t=01h18m01s)



[open as a good first issue and actually](https://youtu.be/8Hq1aqVfesg?t=01h18m03s)



[linked to the code where it needs to get](https://youtu.be/8Hq1aqVfesg?t=01h18m04s)



[changed](https://youtu.be/8Hq1aqVfesg?t=01h18m06s)



[so it's actually inside of this icon](https://youtu.be/8Hq1aqVfesg?t=01h18m06s)



[thing class that's doing the updating so](https://youtu.be/8Hq1aqVfesg?t=01h18m09s)



[specifically you know updating the enum](https://youtu.be/8Hq1aqVfesg?t=01h18m13s)



[and then it's just a matter of testing](https://youtu.be/8Hq1aqVfesg?t=01h18m15s)



[to make sure that the control handles](https://youtu.be/8Hq1aqVfesg?t=01h18m17s)



[the empty enum value so if somebody](https://youtu.be/8Hq1aqVfesg?t=01h18m18s)



[wants to tackle it she seems like a](https://youtu.be/8Hq1aqVfesg?t=01h18m21s)



[reasonably good first issue given that](https://youtu.be/8Hq1aqVfesg?t=01h18m23s)



[it's taken a few years before anyone's](https://youtu.be/8Hq1aqVfesg?t=01h18m25s)



[requested I'm suspecting it's not a big](https://youtu.be/8Hq1aqVfesg?t=01h18m28s)



[feature right just having an icon on](https://youtu.be/8Hq1aqVfesg?t=01h18m31s)



[your UI and then not displaying one](https://youtu.be/8Hq1aqVfesg?t=01h18m35s)



[seems like a little bit more of an edge](https://youtu.be/8Hq1aqVfesg?t=01h18m37s)



[case this one here I think was one of](https://youtu.be/8Hq1aqVfesg?t=01h18m39s)



[the ones that I wanted to take a look at](https://youtu.be/8Hq1aqVfesg?t=01h18m43s)



[so because he not only has logged the](https://youtu.be/8Hq1aqVfesg?t=01h18m45s)



[bug but he's actually gone through and](https://youtu.be/8Hq1aqVfesg?t=01h18m49s)



[it looks like identified the exact line](https://youtu.be/8Hq1aqVfesg?t=01h18m51s)



[for the fix so this is probably probably](https://youtu.be/8Hq1aqVfesg?t=01h18m54s)



[has to do with it so we're gonna let's](https://youtu.be/8Hq1aqVfesg?t=01h19m01s)



[see if we can tackle this one real quick](https://youtu.be/8Hq1aqVfesg?t=01h19m04s)



[let's see so ListView let's go back over](https://youtu.be/8Hq1aqVfesg?t=01h19m07s)



[here so let's get ourselves back on](https://youtu.be/8Hq1aqVfesg?t=01h19m10s)



[master and we'll go from there](https://youtu.be/8Hq1aqVfesg?t=01h19m12s)



[boom okay so step one reproduce the bug](https://youtu.be/8Hq1aqVfesg?t=01h19m15s)



[which shouldn't be hard given that he](https://youtu.be/8Hq1aqVfesg?t=01h19m19s)



[provided us with all of the zamel needed](https://youtu.be/8Hq1aqVfesg?t=01h19m22s)



[which is great i highly approve when](https://youtu.be/8Hq1aqVfesg?t=01h19m24s)



[people do this](https://youtu.be/8Hq1aqVfesg?t=01h19m28s)



[okay so let's find a list view and just](https://youtu.be/8Hq1aqVfesg?t=01h19m30s)



[swap one of these guys out this guy it's](https://youtu.be/8Hq1aqVfesg?t=01h19m33s)



[great you get to move owned it into my](https://youtu.be/8Hq1aqVfesg?t=01h19m36s)



[testbed for the moment so itemssource](https://youtu.be/8Hq1aqVfesg?t=01h19m39s)



[don't know if it really matters right](https://youtu.be/8Hq1aqVfesg?t=01h19m43s)



[actually let's do this real quick so](https://youtu.be/8Hq1aqVfesg?t=01h19m48s)



[this I'm gonna grab the ListView items](https://youtu.be/8Hq1aqVfesg?t=01h19m51s)



[from the content those on my clipboard](https://youtu.be/8Hq1aqVfesg?t=01h19m53s)



[and then we're just going to multi](https://youtu.be/8Hq1aqVfesg?t=01h19m56s)



[clipboard this guy into place so that](https://youtu.be/8Hq1aqVfesg?t=01h19m57s)



[button first take this off that button](https://youtu.be/8Hq1aqVfesg?t=01h20m01s)



[next drop it in okay so he has this](https://youtu.be/8Hq1aqVfesg?t=01h20m10s)



[let's just we'll have to call this but](https://youtu.be/8Hq1aqVfesg?t=01h20m17s)



[we're gonna bind them together so setter](https://youtu.be/8Hq1aqVfesg?t=01h20m22s)



[visibility collapsed based on the column](https://youtu.be/8Hq1aqVfesg?t=01h20m25s)



[view header so basically wants a list](https://youtu.be/8Hq1aqVfesg?t=01h20m28s)



[view wants to to hide the header and it](https://youtu.be/8Hq1aqVfesg?t=01h20m30s)



[should hide and it appears that our](https://youtu.be/8Hq1aqVfesg?t=01h20m33s)



[style does not allow that which is](https://youtu.be/8Hq1aqVfesg?t=01h20m35s)



[really unfortunate](https://youtu.be/8Hq1aqVfesg?t=01h20m38s)



[Oh mountain dew how I love thee okay](https://youtu.be/8Hq1aqVfesg?t=01h20m43s)



[list to do okay so that's disappointing](https://youtu.be/8Hq1aqVfesg?t=01h20m50s)



[because that apparently looks like it's](https://youtu.be/8Hq1aqVfesg?t=01h20m58s)



[working right so let's take this guy off](https://youtu.be/8Hq1aqVfesg?t=01h21m00s)



[oh it's still allocating the space for](https://youtu.be/8Hq1aqVfesg?t=01h21m11s)



[it that could be the problem so let's do](https://youtu.be/8Hq1aqVfesg?t=01h21m14s)



[let's do this let's see if I can set our](https://youtu.be/8Hq1aqVfesg?t=01h21m22s)



[property background you read be big be](https://youtu.be/8Hq1aqVfesg?t=01h21m26s)



[obvious okay](https://youtu.be/8Hq1aqVfesg?t=01h21m32s)



[don't see it](https://youtu.be/8Hq1aqVfesg?t=01h21m37s)



[let's just relaunch and make sure this](https://youtu.be/8Hq1aqVfesg?t=01h21m44s)



[guy shows up I'm not sure if this guy's](https://youtu.be/8Hq1aqVfesg?t=01h21m45s)



[overriding it or what the deal is grid](https://youtu.be/8Hq1aqVfesg?t=01h21m47s)



[view column header oh yeah it the the](https://youtu.be/8Hq1aqVfesg?t=01h21m50s)



[issue comment referenced padding and so](https://youtu.be/8Hq1aqVfesg?t=01h21m54s)



[I'm not nope nope nope nope nope bad](https://youtu.be/8Hq1aqVfesg?t=01h21m57s)



[Visual Studio no still no because this](https://youtu.be/8Hq1aqVfesg?t=01h22m03s)



[is generally how I would expect it to](https://youtu.be/8Hq1aqVfesg?t=01h22m11s)



[get done but yeah the backgrounds](https://youtu.be/8Hq1aqVfesg?t=01h22m13s)



[clearly not respected either and the](https://youtu.be/8Hq1aqVfesg?t=01h22m19s)



[fact that I get this cursor is a bit of](https://youtu.be/8Hq1aqVfesg?t=01h22m21s)



[an issue okay so let's go back to snoot](https://youtu.be/8Hq1aqVfesg?t=01h22m23s)



[because I want to be able to see what's](https://youtu.be/8Hq1aqVfesg?t=01h22m25s)



[actually there because on the issue he](https://youtu.be/8Hq1aqVfesg?t=01h22m27s)



[did comment that it looked like the this](https://youtu.be/8Hq1aqVfesg?t=01h22m31s)



[attached property the ListView item](https://youtu.be/8Hq1aqVfesg?t=01h22m37s)



[padding was getting applied to this](https://youtu.be/8Hq1aqVfesg?t=01h22m39s)



[rectangle](https://youtu.be/8Hq1aqVfesg?t=01h22m42s)



[would not shock me in the least it](https://youtu.be/8Hq1aqVfesg?t=01h22m45s)



[probably just means that this guy needs](https://youtu.be/8Hq1aqVfesg?t=01h22m47s)



[to be conditional and not just always](https://youtu.be/8Hq1aqVfesg?t=01h22m49s)



[blindly applied I'd be my first instinct](https://youtu.be/8Hq1aqVfesg?t=01h22m51s)



[but we'll see so let's see if we can](https://youtu.be/8Hq1aqVfesg?t=01h22m55s)



[pick this guy up so yeah definitely I](https://youtu.be/8Hq1aqVfesg?t=01h22m59s)



[had her there](https://youtu.be/8Hq1aqVfesg?t=01h23m02s)



[let's see so that's the whole one the](https://youtu.be/8Hq1aqVfesg?t=01h23m08s)



[dock panel scroll viewer scroll content](https://youtu.be/8Hq1aqVfesg?t=01h23m10s)



[okay so let's we're gonna leave this guy](https://youtu.be/8Hq1aqVfesg?t=01h23m14s)



[well let's do this](https://youtu.be/8Hq1aqVfesg?t=01h23m22s)



[take a look at it because I believe that](https://youtu.be/8Hq1aqVfesg?t=01h23m24s)



[Runk it down right but there's still](https://youtu.be/8Hq1aqVfesg?t=01h23m27s)



[some amount of size here specifically](https://youtu.be/8Hq1aqVfesg?t=01h23m31s)



[that's 17 I am a little curious as to](https://youtu.be/8Hq1aqVfesg?t=01h23m33s)



[where that's coming from](https://youtu.be/8Hq1aqVfesg?t=01h23m36s)



[let's see to do so where which one of](https://youtu.be/8Hq1aqVfesg?t=01h23m39s)



[you guys has Heights you do and you're](https://youtu.be/8Hq1aqVfesg?t=01h23m43s)



[the full thing right yep so let's figure](https://youtu.be/8Hq1aqVfesg?t=01h23m46s)



[out what's inside of you you've got a](https://youtu.be/8Hq1aqVfesg?t=01h23m49s)



[stack panel this header header header so](https://youtu.be/8Hq1aqVfesg?t=01h23m52s)



[all of those have 0 height really but](https://youtu.be/8Hq1aqVfesg?t=01h23m59s)



[you have Heights](https://youtu.be/8Hq1aqVfesg?t=01h24m05s)



[yeah so that guy there had our header](https://youtu.be/8Hq1aqVfesg?t=01h24m19s)



[header so if we zero out the padding](https://youtu.be/8Hq1aqVfesg?t=01h24m24s)



[let's just confirm this theory I would](https://youtu.be/8Hq1aqVfesg?t=01h24m27s)



[expect this guy to all go teeny mode](https://youtu.be/8Hq1aqVfesg?t=01h24m33s)



[right and](https://youtu.be/8Hq1aqVfesg?t=01h24m36s)



[let's see show me height - so the](https://youtu.be/8Hq1aqVfesg?t=01h24m47s)



[padding isn't fully responsible for it](https://youtu.be/8Hq1aqVfesg?t=01h24m53s)



[show me margin - that doesn't have](https://youtu.be/8Hq1aqVfesg?t=01h24m59s)



[because these are all just straight](https://youtu.be/8Hq1aqVfesg?t=01h25m05s)



[attached properties well the implication](https://youtu.be/8Hq1aqVfesg?t=01h25m07s)



[was that that would do it right the](https://youtu.be/8Hq1aqVfesg?t=01h25m10s)



[ListView but ultimately that has to get](https://youtu.be/8Hq1aqVfesg?t=01h25m14s)



[applied somewhere for to actually cause](https://youtu.be/8Hq1aqVfesg?t=01h25m18s)



[anything to change in size all right](https://youtu.be/8Hq1aqVfesg?t=01h25m25s)



[attached properties generally don't add](https://youtu.be/8Hq1aqVfesg?t=01h25m28s)



[anything directly as they probably](https://youtu.be/8Hq1aqVfesg?t=01h25m30s)



[shouldn't](https://youtu.be/8Hq1aqVfesg?t=01h25m34s)



[that dock panel has size that dock panel](https://youtu.be/8Hq1aqVfesg?t=01h25m38s)



[has sighs you guys are huge what's going](https://youtu.be/8Hq1aqVfesg?t=01h25m42s)



[on 32](https://youtu.be/8Hq1aqVfesg?t=01h25m45s)



[interesting okay well we at least know](https://youtu.be/8Hq1aqVfesg?t=01h25m53s)



[somewhat where to look](https://youtu.be/8Hq1aqVfesg?t=01h25m57s)



[let's go hunting now okay so the line in](https://youtu.be/8Hq1aqVfesg?t=01h25m59s)



[question that he had referenced was 45](https://youtu.be/8Hq1aqVfesg?t=01h26m02s)



[inside of the ListView so we'll start](https://youtu.be/8Hq1aqVfesg?t=01h26m07s)



[there let's see here so ListView 45 keep](https://youtu.be/8Hq1aqVfesg?t=01h26m09s)



[the width of the head of the same size](https://youtu.be/8Hq1aqVfesg?t=01h26m19s)



[as the scroll viewer so this guy here a](https://youtu.be/8Hq1aqVfesg?t=01h26m21s)



[rectangle with a margin and it's sitting](https://youtu.be/8Hq1aqVfesg?t=01h26m31s)



[alongside the scroll presenter inside of](https://youtu.be/8Hq1aqVfesg?t=01h26m34s)



[a stackpanel so where is this guy so](https://youtu.be/8Hq1aqVfesg?t=01h26m40s)



[there's the stack panel there's this guy](https://youtu.be/8Hq1aqVfesg?t=01h26m44s)



[look at that he's right so the the](https://youtu.be/8Hq1aqVfesg?t=01h26m53s)



[presenter does shrink down but this](https://youtu.be/8Hq1aqVfesg?t=01h26m57s)



[rectangles margin is keeping them alive](https://youtu.be/8Hq1aqVfesg?t=01h26m59s)



[okay](https://youtu.be/8Hq1aqVfesg?t=01h27m02s)



[so how do we go through and do this](https://youtu.be/8Hq1aqVfesg?t=01h27m03s)



[because ultimately we can't set this guy](https://youtu.be/8Hq1aqVfesg?t=01h27m11s)



[to be I don't want to just set the](https://youtu.be/8Hq1aqVfesg?t=01h27m14s)



[margin because how do I know if all the](https://youtu.be/8Hq1aqVfesg?t=01h27m21s)



[columns are collapsed right with the](https://youtu.be/8Hq1aqVfesg?t=01h27m26s)



[header scrollview of the same size as](https://youtu.be/8Hq1aqVfesg?t=01h27m31s)



[the list items yeah so this guy is](https://youtu.be/8Hq1aqVfesg?t=01h27m33s)



[basically just pushing it out all right](https://youtu.be/8Hq1aqVfesg?t=01h27m35s)



[otherwise the issue is this stack panel](https://youtu.be/8Hq1aqVfesg?t=01h27m38s)



[only gets as wide as it needs for the](https://youtu.be/8Hq1aqVfesg?t=01h27m40s)



[headers and this guy effectively just](https://youtu.be/8Hq1aqVfesg?t=01h27m42s)



[adds space I think what I do because](https://youtu.be/8Hq1aqVfesg?t=01h27m46s)



[this guy is only designed to go out to](https://youtu.be/8Hq1aqVfesg?t=01h27m52s)



[the width I don't need this margin to](https://youtu.be/8Hq1aqVfesg?t=01h27m54s)



[have any height only width so a simple](https://youtu.be/8Hq1aqVfesg?t=01h27m58s)



[solution could be just a straight value](https://youtu.be/8Hq1aqVfesg?t=01h28m04s)



[converter here right and trim off the](https://youtu.be/8Hq1aqVfesg?t=01h28m05s)



[height and only add the width](https://youtu.be/8Hq1aqVfesg?t=01h28m09s)



[yeah I like it I think that's probably](https://youtu.be/8Hq1aqVfesg?t=01h28m15s)



[the cleanest solution so let's go](https://youtu.be/8Hq1aqVfesg?t=01h28m18s)



[through and do that](https://youtu.be/8Hq1aqVfesg?t=01h28m20s)



[let's see converters let's see margin is](https://youtu.be/8Hq1aqVfesg?t=01h28m23s)



[a thickness so thickness about](https://youtu.be/8Hq1aqVfesg?t=01h28m30s)



[horizontal toll thickness converter](https://youtu.be/8Hq1aqVfesg?t=01h28m41s)



[ultimately I'm gonna make this guy](https://youtu.be/8Hq1aqVfesg?t=01h28m48s)



[internal so I because I don't want to](https://youtu.be/8Hq1aqVfesg?t=01h28m49s)



[necessarily add to my API surface if I](https://youtu.be/8Hq1aqVfesg?t=01h28m52s)



[don't have to so I value converter](https://youtu.be/8Hq1aqVfesg?t=01h28m55s)



[yes resharper I understand typing is](https://youtu.be/8Hq1aqVfesg?t=01h29m03s)



[hard I keep going back and forth on](https://youtu.be/8Hq1aqVfesg?t=01h29m06s)



[whether I should get rid of an uninstall](https://youtu.be/8Hq1aqVfesg?t=01h29m11s)



[you okay so we're gonna be a one-way](https://youtu.be/8Hq1aqVfesg?t=01h29m14s)



[converter stop debugging yes I](https://youtu.be/8Hq1aqVfesg?t=01h29m16s)



[understand we sharp or caused my thing](https://youtu.be/8Hq1aqVfesg?t=01h29m20s)



[to hang so let's see if value is](https://youtu.be/8Hq1aqVfesg?t=01h29m21s)



[thickness and then return new thickness](https://youtu.be/8Hq1aqVfesg?t=01h29m27s)



[with let's see the copy the left zero](https://youtu.be/8Hq1aqVfesg?t=01h29m38s)



[the top will copy the right and zero the](https://youtu.be/8Hq1aqVfesg?t=01h29m44s)



[bottom alright otherwise return see](https://youtu.be/8Hq1aqVfesg?t=01h29m50s)



[binding do nothing I think](https://youtu.be/8Hq1aqVfesg?t=01h29m56s)



[and we should probably yeah so that](https://youtu.be/8Hq1aqVfesg?t=01h30m02s)



[works there grab this come over to here](https://youtu.be/8Hq1aqVfesg?t=01h30m06s)



[and let's add it I think inside of the](https://youtu.be/8Hq1aqVfesg?t=01h30m09s)



[control template resources](https://youtu.be/8Hq1aqVfesg?t=01h30m13s)



[well okay so we got our converter](https://youtu.be/8Hq1aqVfesg?t=01h30m27s)



[everyone's happy](https://youtu.be/8Hq1aqVfesg?t=01h30m30s)



[just slap that sucker on there and I](https://youtu.be/8Hq1aqVfesg?t=01h30m32s)



[think then we get to be done](https://youtu.be/8Hq1aqVfesg?t=01h30m35s)



[Werder static resource paste and](https://youtu.be/8Hq1aqVfesg?t=01h30m37s)



[relaunch let's make sure it works](https://youtu.be/8Hq1aqVfesg?t=01h30m43s)



[- so back over to our list there we go](https://youtu.be/8Hq1aqVfesg?t=01h31m00s)



[and now it's hidden and if I come back](https://youtu.be/8Hq1aqVfesg?t=01h31m08s)



[over here and I take this off we now](https://youtu.be/8Hq1aqVfesg?t=01h31m10s)



[have our headers huzzah](https://youtu.be/8Hq1aqVfesg?t=01h31m16s)



[still bothers me background isn't](https://youtu.be/8Hq1aqVfesg?t=01h31m19s)



[implemented but that is not a bug we are](https://youtu.be/8Hq1aqVfesg?t=01h31m20s)



[attacking today or at least not right](https://youtu.be/8Hq1aqVfesg?t=01h31m23s)



[now so let's do this so you come here](https://youtu.be/8Hq1aqVfesg?t=01h31m25s)



[come here we don't need the demo app](https://youtu.be/8Hq1aqVfesg?t=01h31m29s)



[change discard change disk out change](https://youtu.be/8Hq1aqVfesg?t=01h31m31s)



[but boom](https://youtu.be/8Hq1aqVfesg?t=01h31m34s)



[fixes and I need my bug number now 1623](https://youtu.be/8Hq1aqVfesg?t=01h31m37s)



[1623 limiting the height of right](https://youtu.be/8Hq1aqVfesg?t=01h31m45s)



[tangled to zero to avoid keeping the](https://youtu.be/8Hq1aqVfesg?t=01h31m54s)



[headers visible](https://youtu.be/8Hq1aqVfesg?t=01h31m59s)



[they're so stage and branch fix 1623](https://youtu.be/8Hq1aqVfesg?t=01h32m04s)



[looks good great great commit push go](https://youtu.be/8Hq1aqVfesg?t=01h32m14s)



[one thing I really wish is that I'd love](https://youtu.be/8Hq1aqVfesg?t=01h32m21s)



[it if github implemented autocomplete](https://youtu.be/8Hq1aqVfesg?t=01h32m26s)



[like what exists in DevOps that would be](https://youtu.be/8Hq1aqVfesg?t=01h32m29s)



[a nice feature because there's a lot of](https://youtu.be/8Hq1aqVfesg?t=01h32m32s)



[times where I'm creating this pull](https://youtu.be/8Hq1aqVfesg?t=01h32m34s)



[request and as soon as the CI passes I I](https://youtu.be/8Hq1aqVfesg?t=01h32m35s)



[want it to go so let's see there's that](https://youtu.be/8Hq1aqVfesg?t=01h32m40s)



[there's that great great great should](https://youtu.be/8Hq1aqVfesg?t=01h32m43s)



[Auto reference the bug yep which it does](https://youtu.be/8Hq1aqVfesg?t=01h32m46s)



[and as soon as that runs that'll fix it](https://youtu.be/8Hq1aqVfesg?t=01h32m52s)



[okay so let's jump back here and let's](https://youtu.be/8Hq1aqVfesg?t=01h32m57s)



[take a look at what else we got what](https://youtu.be/8Hq1aqVfesg?t=01h33m00s)



[else we got faint mouse over effect on](https://youtu.be/8Hq1aqVfesg?t=01h33m04s)



[flat buttons](https://youtu.be/8Hq1aqVfesg?t=01h33m08s)



[let's take a look yeah so this was an](https://youtu.be/8Hq1aqVfesg?t=01h33m10s)



[issue that came into play because of a](https://youtu.be/8Hq1aqVfesg?t=01h33m15s)



[recent change we made so ultimately it](https://youtu.be/8Hq1aqVfesg?t=01h33m18s)



[was the change that went in for this so](https://youtu.be/8Hq1aqVfesg?t=01h33m22s)



[the material design Docs when we look at](https://youtu.be/8Hq1aqVfesg?t=01h33m28s)



[the flat buttons did where are they they](https://youtu.be/8Hq1aqVfesg?t=01h33m32s)



[have a different hover color actually](https://youtu.be/8Hq1aqVfesg?t=01h33m38s)



[this guy here should get labeled with](https://youtu.be/8Hq1aqVfesg?t=01h33m44s)



[our new visual breaking change all right](https://youtu.be/8Hq1aqVfesg?t=01h33m47s)



[so there's that this guy so like these](https://youtu.be/8Hq1aqVfesg?t=01h33m51s)



[are the flat buttons right they only](https://youtu.be/8Hq1aqVfesg?t=01h33m55s)



[show effectively the text and you'll](https://youtu.be/8Hq1aqVfesg?t=01h33m57s)



[note on the the click effects they](https://youtu.be/8Hq1aqVfesg?t=01h34m02s)



[actually use the primary color so in](https://youtu.be/8Hq1aqVfesg?t=01h34m05s)



[this case purple right and so that was](https://youtu.be/8Hq1aqVfesg?t=01h34m09s)



[the that was the intent with these](https://youtu.be/8Hq1aqVfesg?t=01h34m11s)



[things is to to actually meet that spec](https://youtu.be/8Hq1aqVfesg?t=01h34m13s)



[make it match the problem is is the spec](https://youtu.be/8Hq1aqVfesg?t=01h34m17s)



[doesn't really say what to do in dark](https://youtu.be/8Hq1aqVfesg?t=01h34m20s)



[theme which is problematic and I think](https://youtu.be/8Hq1aqVfesg?t=01h34m23s)



[that's where we ultimately need to to](https://youtu.be/8Hq1aqVfesg?t=01h34m28s)



[adjust this right so the change is here](https://youtu.be/8Hq1aqVfesg?t=01h34m31s)



[what to do because it set the feedback](https://youtu.be/8Hq1aqVfesg?t=01h34m35s)



[to primary humid brush and I'm wondering](https://youtu.be/8Hq1aqVfesg?t=01h34m38s)



[if that's not quite right I'm wondering](https://youtu.be/8Hq1aqVfesg?t=01h34m42s)



[if this might just be simplest to do](https://youtu.be/8Hq1aqVfesg?t=01h34m45s)



[this as the light brush and be done with](https://youtu.be/8Hq1aqVfesg?t=01h34m47s)



[it so I think we're gonna try that so](https://youtu.be/8Hq1aqVfesg?t=01h34m48s)



[let's see this is gonna be underneath](https://youtu.be/8Hq1aqVfesg?t=01h34m52s)



[button 9 138 yes - all please thanks](https://youtu.be/8Hq1aqVfesg?t=01h34m53s)



[great close close](https://youtu.be/8Hq1aqVfesg?t=01h35m01s)



[so let's go and look at button button](https://youtu.be/8Hq1aqVfesg?t=01h35m03s)



[button button 138 and it down down down](https://youtu.be/8Hq1aqVfesg?t=01h35m07s)



[down down oh no no down primary hue and](https://youtu.be/8Hq1aqVfesg?t=01h35m11s)



[let's just toggle this to light brush](https://youtu.be/8Hq1aqVfesg?t=01h35m13s)



[right cuz well let's leave it broken](https://youtu.be/8Hq1aqVfesg?t=01h35m15s)



[let's leave it broken and reproduce the](https://youtu.be/8Hq1aqVfesg?t=01h35m18s)



[issue real quick first just to make sure](https://youtu.be/8Hq1aqVfesg?t=01h35m20s)



[I'm clear on exactly what we're fixing](https://youtu.be/8Hq1aqVfesg?t=01h35m22s)



[I might need at some point spend a](https://youtu.be/8Hq1aqVfesg?t=01h35m33s)



[little time on my subtitles they're](https://youtu.be/8Hq1aqVfesg?t=01h35m35s)



[delaying a little more than I'd like but](https://youtu.be/8Hq1aqVfesg?t=01h35m36s)



[there's only so much I can do since I am](https://youtu.be/8Hq1aqVfesg?t=01h35m38s)



[forced to wait on cognitive services to](https://youtu.be/8Hq1aqVfesg?t=01h35m42s)



[do the processing in the cloud which is](https://youtu.be/8Hq1aqVfesg?t=01h35m44s)



[less than ideal but don't have much of](https://youtu.be/8Hq1aqVfesg?t=01h35m47s)



[an option okay so we're going to go dark](https://youtu.be/8Hq1aqVfesg?t=01h35m51s)



[mode first and then we're gonna go](https://youtu.be/8Hq1aqVfesg?t=01h35m53s)



[buttons and it's basically these guys](https://youtu.be/8Hq1aqVfesg?t=01h35m54s)



[here right and the the problem being](https://youtu.be/8Hq1aqVfesg?t=01h35m57s)



[that the ripple is fairly little](https://youtu.be/8Hq1aqVfesg?t=01h36m01s)



[difficult to see here I mean it is there](https://youtu.be/8Hq1aqVfesg?t=01h36m05s)



[but I do agree that it can be it is a](https://youtu.be/8Hq1aqVfesg?t=01h36m12s)



[lot lighter especially depending on the](https://youtu.be/8Hq1aqVfesg?t=01h36m15s)



[theme that you're in let's see let's](https://youtu.be/8Hq1aqVfesg?t=01h36m18s)



[just look at what that looks like in](https://youtu.be/8Hq1aqVfesg?t=01h36m21s)



[light to see what that contrast is yeah](https://youtu.be/8Hq1aqVfesg?t=01h36m23s)



[that is it is definitely more noticeable](https://youtu.be/8Hq1aqVfesg?t=01h36m29s)



[and the light theme so I think though I](https://youtu.be/8Hq1aqVfesg?t=01h36m32s)



[think the simplest fix that I can think](https://youtu.be/8Hq1aqVfesg?t=01h36m36s)



[is just this right so let's I'm gonna](https://youtu.be/8Hq1aqVfesg?t=01h36m39s)



[relaunch I just want to make darn sure](https://youtu.be/8Hq1aqVfesg?t=01h36m45s)



[that I pick up this change the Edit](https://youtu.be/8Hq1aqVfesg?t=01h36m47s)



[continue mostly works and I mostly trust](https://youtu.be/8Hq1aqVfesg?t=01h36m48s)



[it aside from when it doesn't work and](https://youtu.be/8Hq1aqVfesg?t=01h36m52s)



[then I stop trusting it because I'm](https://youtu.be/8Hq1aqVfesg?t=01h36m54s)



[thinking that if this if this works](https://youtu.be/8Hq1aqVfesg?t=01h36m59s)



[that's probably the simplest thing so](https://youtu.be/8Hq1aqVfesg?t=01h37m02s)



[let's let's start in light mode and just](https://youtu.be/8Hq1aqVfesg?t=01h37m04s)



[see how this how this guy goes so that's](https://youtu.be/8Hq1aqVfesg?t=01h37m07s)



[it's fairly good right there all right](https://youtu.be/8Hq1aqVfesg?t=01h37m12s)



[now let's flip over to dark mode](https://youtu.be/8Hq1aqVfesg?t=01h37m15s)



[see if I can tell a difference well that](https://youtu.be/8Hq1aqVfesg?t=01h37m22s)



[just doesn't feel I think that's better](https://youtu.be/8Hq1aqVfesg?t=01h37m26s)



[but man that is really hard to tale](https://youtu.be/8Hq1aqVfesg?t=01h37m30s)



[let's look at so](https://youtu.be/8Hq1aqVfesg?t=01h37m34s)



[there was this change down here as well](https://youtu.be/8Hq1aqVfesg?t=01h37m49s)



[and that could be why I'm missing it](https://youtu.be/8Hq1aqVfesg?t=01h37m51s)



[[Music]](https://youtu.be/8Hq1aqVfesg?t=01h37m54s)



[because this is effectively taking in](https://youtu.be/8Hq1aqVfesg?t=01h37m57s)



[that color and adjusting it and I'm](https://youtu.be/8Hq1aqVfesg?t=01h37m59s)



[wondering if that's the simplest fix](https://youtu.be/8Hq1aqVfesg?t=01h38m03s)



[right is because that's the other thing](https://youtu.be/8Hq1aqVfesg?t=01h38m06s)



[is the mouse over color is almost](https://youtu.be/8Hq1aqVfesg?t=01h38m13s)



[impossible to see let's see what that](https://youtu.be/8Hq1aqVfesg?t=01h38m19s)



[looks like in light theme let's see what](https://youtu.be/8Hq1aqVfesg?t=01h38m22s)



[that looks like cuz at least to my poor](https://youtu.be/8Hq1aqVfesg?t=01h38m25s)



[eyes I can't hardly see that Mouse over](https://youtu.be/8Hq1aqVfesg?t=01h38m28s)



[color so I'm wondering if that was the](https://youtu.be/8Hq1aqVfesg?t=01h38m31s)



[intent of doing this right because that](https://youtu.be/8Hq1aqVfesg?t=01h38m38s)



[is really faint](https://youtu.be/8Hq1aqVfesg?t=01h38m43s)



[let's see what where were those states](https://youtu.be/8Hq1aqVfesg?t=01h38m47s)



[what did it call for because ultimately](https://youtu.be/8Hq1aqVfesg?t=01h38m52s)



[the hover that is hard to tell](https://youtu.be/8Hq1aqVfesg?t=01h38m54s)



[yeah boy that is really hard to tell](https://youtu.be/8Hq1aqVfesg?t=01h39m08s)



[[Music]](https://youtu.be/8Hq1aqVfesg?t=01h39m12s)



[because okay so that one doesn't count](https://youtu.be/8Hq1aqVfesg?t=01h39m18s)



[these ones count though as ultimately](https://youtu.be/8Hq1aqVfesg?t=01h39m21s)



[these changes were around these buttons](https://youtu.be/8Hq1aqVfesg?t=01h39m24s)



[I think this one ultimately derives from](https://youtu.be/8Hq1aqVfesg?t=01h39m26s)



[it flat icon foreground button but I it](https://youtu.be/8Hq1aqVfesg?t=01h39m29s)



[looks like these guys outside of the](https://youtu.be/8Hq1aqVfesg?t=01h39m33s)



[ripple effect these guys have their own](https://youtu.be/8Hq1aqVfesg?t=01h39m35s)



[hover color okay so let's let's set you](https://youtu.be/8Hq1aqVfesg?t=01h39m38s)



[back to mid right and then this guy down](https://youtu.be/8Hq1aqVfesg?t=01h39m45s)



[where are you show me the change](https://youtu.be/8Hq1aqVfesg?t=01h39m51s)



[show me the change boom](https://youtu.be/8Hq1aqVfesg?t=01h39m57s)



[apparently I must have closed it let's](https://youtu.be/8Hq1aqVfesg?t=01h40m06s)



[see that close my pull request - and I](https://youtu.be/8Hq1aqVfesg?t=01h40m10s)



[am NOT doing well not doing well okay](https://youtu.be/8Hq1aqVfesg?t=01h40m16s)



[but I completed so squash merge](https://youtu.be/8Hq1aqVfesg?t=01h40m19s)



[confirmed squash merge this guy goes](https://youtu.be/8Hq1aqVfesg?t=01h40m23s)



[into there that fixes that delete my](https://youtu.be/8Hq1aqVfesg?t=01h40m26s)



[branch this bug goes in it's fixed](https://youtu.be/8Hq1aqVfesg?t=01h40m29s)



[huzzah okay yeah so it is](https://youtu.be/8Hq1aqVfesg?t=01h40m32s)



[that's the light background yeah and](https://youtu.be/8Hq1aqVfesg?t=01h40m50s)



[this is where that where it was before](https://youtu.be/8Hq1aqVfesg?t=01h40m54s)



[the change right so it showed up a lot](https://youtu.be/8Hq1aqVfesg?t=01h40m55s)



[better specifically in the dark theme](https://youtu.be/8Hq1aqVfesg?t=01h40m57s)



[this can lead to some clashes depending](https://youtu.be/8Hq1aqVfesg?t=01h41m04s)



[on the background color yeah](https://youtu.be/8Hq1aqVfesg?t=01h41m07s)



[and I think so I think this changing to](https://youtu.be/8Hq1aqVfesg?t=01h41m11s)



[be the mid brush is fine but the the](https://youtu.be/8Hq1aqVfesg?t=01h41m16s)



[ripple if you want to change it can be](https://youtu.be/8Hq1aqVfesg?t=01h41m19s)



[controlled by you right so depending on](https://youtu.be/8Hq1aqVfesg?t=01h41m21s)



[if there there's always the risk that](https://youtu.be/8Hq1aqVfesg?t=01h41m24s)



[somebody goes through and puts bad a bad](https://youtu.be/8Hq1aqVfesg?t=01h41m26s)



[color themes together and we don't](https://youtu.be/8Hq1aqVfesg?t=01h41m31s)



[restrict what color themes you can use](https://youtu.be/8Hq1aqVfesg?t=01h41m33s)



[so you are free to use poor color](https://youtu.be/8Hq1aqVfesg?t=01h41m35s)



[combinations if you want but if you want](https://youtu.be/8Hq1aqVfesg?t=01h41m39s)



[to change this the there is a feedback](https://youtu.be/8Hq1aqVfesg?t=01h41m42s)



[property so this ripple assist feedback](https://youtu.be/8Hq1aqVfesg?t=01h41m46s)



[you can set that to any brush you want](https://youtu.be/8Hq1aqVfesg?t=01h41m49s)



[and that will control the the the ripple](https://youtu.be/8Hq1aqVfesg?t=01h41m51s)



[color so if you want it to go back to](https://youtu.be/8Hq1aqVfesg?t=01h41m54s)



[the other one that is possible this guy](https://youtu.be/8Hq1aqVfesg?t=01h41m56s)



[here I am I'm really curious on how to](https://youtu.be/8Hq1aqVfesg?t=01h42m02s)



[on how to fix this right](https://youtu.be/8Hq1aqVfesg?t=01h42m07s)



[yeah flatten out line button in order to](https://youtu.be/8Hq1aqVfesg?t=01h42m13s)



[get it to match the docks which is which](https://youtu.be/8Hq1aqVfesg?t=01h42m16s)



[is what we want](https://youtu.be/8Hq1aqVfesg?t=01h42m19s)



[yeah so if you want to put it back you](https://youtu.be/8Hq1aqVfesg?t=01h42m26s)



[could go and grab this guy this flat](https://youtu.be/8Hq1aqVfesg?t=01h42m31s)



[button ripple this this brush probably](https://youtu.be/8Hq1aqVfesg?t=01h42m33s)



[needs to be deprecated out it's used in](https://youtu.be/8Hq1aqVfesg?t=01h42m35s)



[two places exactly for these flat](https://youtu.be/8Hq1aqVfesg?t=01h42m40s)



[buttons and then it's also used on the](https://youtu.be/8Hq1aqVfesg?t=01h42m43s)



[toolbar buttons themselves and after](https://youtu.be/8Hq1aqVfesg?t=01h42m44s)



[this change it's only used on the](https://youtu.be/8Hq1aqVfesg?t=01h42m47s)



[toolbar buttons I'm somewhat tempted to](https://youtu.be/8Hq1aqVfesg?t=01h42m49s)



[change this outright so 1 154 and 155](https://youtu.be/8Hq1aqVfesg?t=01h42m55s)



[let's look at that so this guy here kind](https://youtu.be/8Hq1aqVfesg?t=01h42m59s)



[of wondering just turn this opacity off](https://youtu.be/8Hq1aqVfesg?t=01h43m06s)



[for a moment all right let's let's take](https://youtu.be/8Hq1aqVfesg?t=01h43m08s)



[a look at this](https://youtu.be/8Hq1aqVfesg?t=01h43m11s)



[yeah so on the hover that's clearly too](https://youtu.be/8Hq1aqVfesg?t=01h43m15s)



[much so it needs something there](https://youtu.be/8Hq1aqVfesg?t=01h43m18s)



[I think I understand why it's so light](https://youtu.be/8Hq1aqVfesg?t=01h43m29s)



[now let's see turn it way down](https://youtu.be/8Hq1aqVfesg?t=01h43m32s)



[because this is really only here for the](https://youtu.be/8Hq1aqVfesg?t=01h43m42s)



[hover effect surprise the outline button](https://youtu.be/8Hq1aqVfesg?t=01h43m44s)



[isn't expected to have a hover that may](https://youtu.be/8Hq1aqVfesg?t=01h43m48s)



[be an additional bug let's see here](https://youtu.be/8Hq1aqVfesg?t=01h43m52s)



[where's the outline button flat flat](https://youtu.be/8Hq1aqVfesg?t=01h43m56s)



[flat text button text button so yeah so](https://youtu.be/8Hq1aqVfesg?t=01h43m59s)



[the hover hover is definitely there](https://youtu.be/8Hq1aqVfesg?t=01h44m04s)



[let's take a quick look here right so](https://youtu.be/8Hq1aqVfesg?t=01h44m07s)



[you just go here and no I want my color](https://youtu.be/8Hq1aqVfesg?t=01h44m14s)



[dropper right so I want to I want to](https://youtu.be/8Hq1aqVfesg?t=01h44m18s)



[look at this guy alright and then I come](https://youtu.be/8Hq1aqVfesg?t=01h44m25s)



[over here and I go paste okay so let's](https://youtu.be/8Hq1aqVfesg?t=01h44m32s)



[let's take a quick look so](https://youtu.be/8Hq1aqVfesg?t=01h44m36s)



[so the question is this is clearly the](https://youtu.be/8Hq1aqVfesg?t=01h44m43s)



[main color right and then color too is](https://youtu.be/8Hq1aqVfesg?t=01h44m45s)



[eyedropper this color and it colors](https://youtu.be/8Hq1aqVfesg?t=01h44m51s)



[so I'm mostly paying attention to the](https://youtu.be/8Hq1aqVfesg?t=01h45m08s)



[saturation here of 66 and a hue of 177](https://youtu.be/8Hq1aqVfesg?t=01h45m13s)



[because I suspect the hue is probably](https://youtu.be/8Hq1aqVfesg?t=01h45m18s)



[pretty close to this right saturation is](https://youtu.be/8Hq1aqVfesg?t=01h45m22s)



[205 so I think we end up needing to do](https://youtu.be/8Hq1aqVfesg?t=01h45m30s)



[some color conversions because](https://youtu.be/8Hq1aqVfesg?t=01h45m37s)



[ultimately it's going from 205 to 66 so](https://youtu.be/8Hq1aqVfesg?t=01h45m42s)



[it's roughly 25% I should say 25% less](https://youtu.be/8Hq1aqVfesg?t=01h45m45s)



[saturation okay](https://youtu.be/8Hq1aqVfesg?t=01h45m50s)



[my head is not in the mood to do a lot](https://youtu.be/8Hq1aqVfesg?t=01h46m02s)



[of math right now](https://youtu.be/8Hq1aqVfesg?t=01h46m04s)



[let's see let's just do let's do this](https://youtu.be/8Hq1aqVfesg?t=01h46m16s)



[right](https://youtu.be/8Hq1aqVfesg?t=01h46m21s)



[cancel when in doubt just copy and paste](https://youtu.be/8Hq1aqVfesg?t=01h46m23s)



[so let's see is this let's are you going](https://youtu.be/8Hq1aqVfesg?t=01h46m28s)



[to play nice with me so you grab the](https://youtu.be/8Hq1aqVfesg?t=01h46m36s)



[darkest one here maybe there edit colors](https://youtu.be/8Hq1aqVfesg?t=01h46m39s)



[so it's at 124 if we hold that it's a](https://youtu.be/8Hq1aqVfesg?t=01h46m43s)



[little more than a quarter of saturation](https://youtu.be/8Hq1aqVfesg?t=01h46m49s)



[and question is how close is this right](https://youtu.be/8Hq1aqVfesg?t=01h46m54s)



[eighty way above so I'm thinking the](https://youtu.be/8Hq1aqVfesg?t=01h46m58s)



[initial initial bits were probably](https://youtu.be/8Hq1aqVfesg?t=01h47m02s)



[closer to correct I'm guessing he did a](https://youtu.be/8Hq1aqVfesg?t=01h47m06s)



[lot more math on this than I did](https://youtu.be/8Hq1aqVfesg?t=01h47m09s)



[okay so then the question comes if that](https://youtu.be/8Hq1aqVfesg?t=01h47m16s)



[is true and this appears to be correct](https://youtu.be/8Hq1aqVfesg?t=01h47m19s)



[enough for the light theme how should we](https://youtu.be/8Hq1aqVfesg?t=01h47m23s)



[handle it in dark theme that is the](https://youtu.be/8Hq1aqVfesg?t=01h47m26s)



[question so my first thought is I whack](https://youtu.be/8Hq1aqVfesg?t=01h47m32s)



[this and I do this I don't think this](https://youtu.be/8Hq1aqVfesg?t=01h47m37s)



[will quite be enough](https://youtu.be/8Hq1aqVfesg?t=01h47m46s)



[I think this is going to be way overkill](https://youtu.be/8Hq1aqVfesg?t=01h47m47s)



[let's see here the other thing we could](https://youtu.be/8Hq1aqVfesg?t=01h48m02s)



[do is rather than just overriding this](https://youtu.be/8Hq1aqVfesg?t=01h48m06s)



[here and and hijacking it here at the](https://youtu.be/8Hq1aqVfesg?t=01h48m08s)



[resources we could go through and change](https://youtu.be/8Hq1aqVfesg?t=01h48m12s)



[out this resource I don't like that as](https://youtu.be/8Hq1aqVfesg?t=01h48m18s)



[much but that is an option yeah because](https://youtu.be/8Hq1aqVfesg?t=01h48m21s)



[that's](https://youtu.be/8Hq1aqVfesg?t=01h48m26s)



[this has a hover effect now I'm curious](https://youtu.be/8Hq1aqVfesg?t=01h48m32s)



[where that's coming from right so](https://youtu.be/8Hq1aqVfesg?t=01h48m38s)



[there's the flat button effect where is](https://youtu.be/8Hq1aqVfesg?t=01h48m41s)



[the outline let's see](https://youtu.be/8Hq1aqVfesg?t=01h48m43s)



[outline button this is based on flat](https://youtu.be/8Hq1aqVfesg?t=01h48m47s)



[button well that's a dupe so we can](https://youtu.be/8Hq1aqVfesg?t=01h48m51s)



[remove it so it has the same same thing](https://youtu.be/8Hq1aqVfesg?t=01h48m54s)



[here basically just read templated to](https://youtu.be/8Hq1aqVfesg?t=01h49m00s)



[look the same okay so fix one fix the](https://youtu.be/8Hq1aqVfesg?t=01h49m05s)



[other](https://youtu.be/8Hq1aqVfesg?t=01h49m09s)



[that's raised button word it word my](https://youtu.be/8Hq1aqVfesg?t=01h49m14s)



[flat button style go where did you go](https://youtu.be/8Hq1aqVfesg?t=01h49m16s)



[flat button style okay so how to handle](https://youtu.be/8Hq1aqVfesg?t=01h49m21s)



[this in dark mode because ultimately](https://youtu.be/8Hq1aqVfesg?t=01h49m28s)



[using the primary color is what's](https://youtu.be/8Hq1aqVfesg?t=01h49m33s)



[causing the problem that is a problem](https://youtu.be/8Hq1aqVfesg?t=01h49m36s)



[it's very much a problem](https://youtu.be/8Hq1aqVfesg?t=01h49m48s)



[and that could be why yeah because I one](https://youtu.be/8Hq1aqVfesg?t=01h49m56s)



[of those situations where I really do](https://youtu.be/8Hq1aqVfesg?t=01h50m03s)



[just want it to work right but I don't](https://youtu.be/8Hq1aqVfesg?t=01h50m05s)



[I'm trying to decide what is what is the](https://youtu.be/8Hq1aqVfesg?t=01h50m08s)



[appropriate color to go in here so in](https://youtu.be/8Hq1aqVfesg?t=01h50m11s)



[the case that you're in dark mode let's](https://youtu.be/8Hq1aqVfesg?t=01h50m13s)



[just let's just go and toggle that guy](https://youtu.be/8Hq1aqVfesg?t=01h50m16s)



[right so that guy flips and we come back](https://youtu.be/8Hq1aqVfesg?t=01h50m18s)



[to the buttons right cuz that's clearly](https://youtu.be/8Hq1aqVfesg?t=01h50m22s)



[not right but if we so let's see flat](https://youtu.be/8Hq1aqVfesg?t=01h50m27s)



[button so let's go back to mid alright](https://youtu.be/8Hq1aqVfesg?t=01h50m33s)



[which is where it was sitting and if we](https://youtu.be/8Hq1aqVfesg?t=01h50m41s)



[just play around with this right so like](https://youtu.be/8Hq1aqVfesg?t=01h50m44s)



[even that feels to light right](https://youtu.be/8Hq1aqVfesg?t=01h50m51s)



[I almost want to go through and](https://youtu.be/8Hq1aqVfesg?t=01h51m04s)



[and have some sort of converter on it](https://youtu.be/8Hq1aqVfesg?t=01h51m10s)



[again](https://youtu.be/8Hq1aqVfesg?t=01h51m13s)



[the problem is is my converter is based](https://youtu.be/8Hq1aqVfesg?t=01h51m14s)



[upon the background color that the](https://youtu.be/8Hq1aqVfesg?t=01h51m17s)



[buttons set on top of right which is not](https://youtu.be/8Hq1aqVfesg?t=01h51m19s)



[a great not a great effect](https://youtu.be/8Hq1aqVfesg?t=01h51m21s)



[so this sits here](https://youtu.be/8Hq1aqVfesg?t=01h51m32s)



[yeah because it really is just expected](https://youtu.be/8Hq1aqVfesg?t=01h51m40s)



[to be a nice light shade of it wondering](https://youtu.be/8Hq1aqVfesg?t=01h51m43s)



[if some of these theming ones have any](https://youtu.be/8Hq1aqVfesg?t=01h51m52s)



[have any good feedback on how to handle](https://youtu.be/8Hq1aqVfesg?t=01h51m56s)



[it](https://youtu.be/8Hq1aqVfesg?t=01h51m59s)



[typeface](https://youtu.be/8Hq1aqVfesg?t=01h52m07s)



[see this this is fine but this doesn't](https://youtu.be/8Hq1aqVfesg?t=01h52m15s)



[it just gives me the typography for it](https://youtu.be/8Hq1aqVfesg?t=01h52m20s)



[it doesn't tell me what people are doing](https://youtu.be/8Hq1aqVfesg?t=01h52m23s)



[for the the mouse-over effect to change](https://youtu.be/8Hq1aqVfesg?t=01h52m27s)



[it out](https://youtu.be/8Hq1aqVfesg?t=01h52m31s)



[because we could go through and change](https://youtu.be/8Hq1aqVfesg?t=01h52m40s)



[rather than because it's it's really](https://youtu.be/8Hq1aqVfesg?t=01h52m42s)



[just a matter of making sure that we're](https://youtu.be/8Hq1aqVfesg?t=01h52m45s)



[using the same hue so I'm just kind of](https://youtu.be/8Hq1aqVfesg?t=01h52m46s)



[kind of talking out loud right so for](https://youtu.be/8Hq1aqVfesg?t=01h52m49s)



[people who are less familiar with it hey](https://youtu.be/8Hq1aqVfesg?t=01h52m54s)



[paint there we go](https://youtu.be/8Hq1aqVfesg?t=01h52m58s)



[so most people are familiar with RGB](https://youtu.be/8Hq1aqVfesg?t=01h53m00s)



[color codes right but there are other](https://youtu.be/8Hq1aqVfesg?t=01h53m03s)



[color spaces and so HSL which is what](https://youtu.be/8Hq1aqVfesg?t=01h53m07s)



[this is showing here hue basically is a](https://youtu.be/8Hq1aqVfesg?t=01h53m12s)



[number representing the color so you've](https://youtu.be/8Hq1aqVfesg?t=01h53m14s)



[got colors for red blue green etc but](https://youtu.be/8Hq1aqVfesg?t=01h53m17s)



[the important part is hue basically](https://youtu.be/8Hq1aqVfesg?t=01h53m22s)



[walks through your color spectrum right](https://youtu.be/8Hq1aqVfesg?t=01h53m24s)



[and so colors that are close in hue](https://youtu.be/8Hq1aqVfesg?t=01h53m26s)



[we'll be visually close in color the](https://youtu.be/8Hq1aqVfesg?t=01h53m30s)



[saturation and luminosity refer to](https://youtu.be/8Hq1aqVfesg?t=01h53m34s)



[basically how much color is in there so](https://youtu.be/8Hq1aqVfesg?t=01h53m37s)



[sort of how light or how dark it is and](https://youtu.be/8Hq1aqVfesg?t=01h53m41s)



[or how bright it is and so it makes it a](https://youtu.be/8Hq1aqVfesg?t=01h53m44s)



[lot easier to determine distances](https://youtu.be/8Hq1aqVfesg?t=01h53m48s)



[between colors it's how you're able to](https://youtu.be/8Hq1aqVfesg?t=01h53m49s)



[draw out like in our color tool that we](https://youtu.be/8Hq1aqVfesg?t=01h53m51s)



[have to do if we jump over to custom](https://youtu.be/8Hq1aqVfesg?t=01h53m55s)



[you'll know this slider here right so](https://youtu.be/8Hq1aqVfesg?t=01h53m59s)



[you want to go through and build out](https://youtu.be/8Hq1aqVfesg?t=01h54m02s)



[this type of gradient this is basically](https://youtu.be/8Hq1aqVfesg?t=01h54m03s)



[a hue slider of showing you everything](https://youtu.be/8Hq1aqVfesg?t=01h54m06s)



[from one side to the other and you'll](https://youtu.be/8Hq1aqVfesg?t=01h54m10s)



[note on both ends red wraps around it so](https://youtu.be/8Hq1aqVfesg?t=01h54m12s)



[effectively a circle you'll see a lot of](https://youtu.be/8Hq1aqVfesg?t=01h54m15s)



[other various color Pickers that do](https://youtu.be/8Hq1aqVfesg?t=01h54m17s)



[similar things and then this guy this](https://youtu.be/8Hq1aqVfesg?t=01h54m19s)



[top bit here is basically luminosity on](https://youtu.be/8Hq1aqVfesg?t=01h54m23s)



[the y-axis and saturation on the x-axis](https://youtu.be/8Hq1aqVfesg?t=01h54m27s)



[so as you get more saturation and we](https://youtu.be/8Hq1aqVfesg?t=01h54m31s)



[further to the right you get a lot more](https://youtu.be/8Hq1aqVfesg?t=01h54m34s)



[in this case blue into your color versus](https://youtu.be/8Hq1aqVfesg?t=01h54m36s)



[a lot more white or as you move up](https://youtu.be/8Hq1aqVfesg?t=01h54m39s)



[versus down down you get a lot more](https://youtu.be/8Hq1aqVfesg?t=01h54m41s)



[black gets darker versus lighter up at](https://youtu.be/8Hq1aqVfesg?t=01h54m44s)



[the top so that's sort of in a nutshell](https://youtu.be/8Hq1aqVfesg?t=01h54m47s)



[how that works and I'm wondering](https://youtu.be/8Hq1aqVfesg?t=01h54m51s)



[for the purpose of doing this if that](https://youtu.be/8Hq1aqVfesg?t=01h54m53s)



[actually helps us right because right](https://youtu.be/8Hq1aqVfesg?t=01h54m56s)



[now what we're doing is we're taking the](https://youtu.be/8Hq1aqVfesg?t=01h54m59s)



[mid brush and we're just making it more](https://youtu.be/8Hq1aqVfesg?t=01h55m02s)



[transparent and I don't know if that's](https://youtu.be/8Hq1aqVfesg?t=01h55m04s)



[actually correct and I'm I'm almost](https://youtu.be/8Hq1aqVfesg?t=01h55m07s)



[thinking that what I really should do is](https://youtu.be/8Hq1aqVfesg?t=01h55m10s)



[take the light brush and make it lighter](https://youtu.be/8Hq1aqVfesg?t=01h55m12s)



[not more transparent but just lighter](https://youtu.be/8Hq1aqVfesg?t=01h55m15s)



[all right because when you add opacity](https://youtu.be/8Hq1aqVfesg?t=01h55m18s)



[to it it's very much affected by the](https://youtu.be/8Hq1aqVfesg?t=01h55m21s)



[color that's under it and I think there](https://youtu.be/8Hq1aqVfesg?t=01h55m24s)



[should be some opacity to it but I think](https://youtu.be/8Hq1aqVfesg?t=01h55m26s)



[it's probably a lot more opaque and](https://youtu.be/8Hq1aqVfesg?t=01h55m28s)



[maybe just a lighter a lighter color](https://youtu.be/8Hq1aqVfesg?t=01h55m31s)



[from your primary kind of what I'm](https://youtu.be/8Hq1aqVfesg?t=01h55m35s)



[thinking don't know if that really works](https://youtu.be/8Hq1aqVfesg?t=01h55m38s)



[well but that would be an interesting](https://youtu.be/8Hq1aqVfesg?t=01h55m41s)



[thing to try is to just lighten up the](https://youtu.be/8Hq1aqVfesg?t=01h55m45s)



[primary hue specifically the light brush](https://youtu.be/8Hq1aqVfesg?t=01h55m48s)



[maybe and then apply some amount of](https://youtu.be/8Hq1aqVfesg?t=01h55m52s)



[opacity to it to see how that works](https://youtu.be/8Hq1aqVfesg?t=01h55m55s)



[there is some built-in functionality](https://youtu.be/8Hq1aqVfesg?t=01h55m57s)



[that we added to the colors so inside of](https://youtu.be/8Hq1aqVfesg?t=01h56m00s)



[the color manipulation I believe where](https://youtu.be/8Hq1aqVfesg?t=01h56m04s)



[is this color color helper right so](https://youtu.be/8Hq1aqVfesg?t=01h56m09s)



[we've got we've got lighten and darken](https://youtu.be/8Hq1aqVfesg?t=01h56m12s)



[right and so you don't necessarily have](https://youtu.be/8Hq1aqVfesg?t=01h56m14s)



[to think too hard about if you want to](https://youtu.be/8Hq1aqVfesg?t=01h56m17s)



[do some adjustments of lightening or](https://youtu.be/8Hq1aqVfesg?t=01h56m21s)



[darkening up colors this will go through](https://youtu.be/8Hq1aqVfesg?t=01h56m23s)



[and handle some of that math for you of](https://youtu.be/8Hq1aqVfesg?t=01h56m27s)



[figuring out so this is going into yet](https://youtu.be/8Hq1aqVfesg?t=01h56m32s)



[another color space called lab rather](https://youtu.be/8Hq1aqVfesg?t=01h56m35s)



[than the HSL that we were using up I](https://youtu.be/8Hq1aqVfesg?t=01h56m38s)



[should say rather than the HSL which is](https://youtu.be/8Hq1aqVfesg?t=01h56m42s)



[being shown here so mspaint shows HSL](https://youtu.be/8Hq1aqVfesg?t=01h56m45s)



[and RGB but there are a lot more color](https://youtu.be/8Hq1aqVfesg?t=01h56m48s)



[spaces than what ms paint cares to show](https://youtu.be/8Hq1aqVfesg?t=01h56m52s)



[so we use all of these two basically](https://youtu.be/8Hq1aqVfesg?t=01h56m54s)



[when you give it a primary hue like in](https://youtu.be/8Hq1aqVfesg?t=01h56m57s)



[this case purple we use if you give us a](https://youtu.be/8Hq1aqVfesg?t=01h57m00s)



[mid color and don't specify](https://youtu.be/8Hq1aqVfesg?t=01h57m04s)



[light and dark we just shift the mid](https://youtu.be/8Hq1aqVfesg?t=01h57m07s)



[color dark or lighter by one and then](https://youtu.be/8Hq1aqVfesg?t=01h57m10s)



[call those the dark and light theme](https://youtu.be/8Hq1aqVfesg?t=01h57m14s)



[colors right so if you just give us a](https://youtu.be/8Hq1aqVfesg?t=01h57m15s)



[primary and an accent color we can](https://youtu.be/8Hq1aqVfesg?t=01h57m18s)



[generate out the rest or if somebody](https://youtu.be/8Hq1aqVfesg?t=01h57m20s)



[wants to get fancier with the theme](https://youtu.be/8Hq1aqVfesg?t=01h57m23s)



[colors you can go through and set all of](https://youtu.be/8Hq1aqVfesg?t=01h57m25s)



[these yourself if you want so with all](https://youtu.be/8Hq1aqVfesg?t=01h57m26s)



[of that said I think I'm slowly talking](https://youtu.be/8Hq1aqVfesg?t=01h57m30s)



[myself into the idea of wanting to go](https://youtu.be/8Hq1aqVfesg?t=01h57m33s)



[through and do less with opacity on this](https://youtu.be/8Hq1aqVfesg?t=01h57m37s)



[and more with just lightening a color](https://youtu.be/8Hq1aqVfesg?t=01h57m42s)



[because this is all about going here and](https://youtu.be/8Hq1aqVfesg?t=01h57m44s)



[so if all we did was lighten the color](https://youtu.be/8Hq1aqVfesg?t=01h57m48s)



[significantly that I think would go a it](https://youtu.be/8Hq1aqVfesg?t=01h57m51s)



[would then not be affected by whether we](https://youtu.be/8Hq1aqVfesg?t=01h57m56s)



[were in light or dark theme as much and](https://youtu.be/8Hq1aqVfesg?t=01h57m58s)



[it would show up closer to the same in](https://youtu.be/8Hq1aqVfesg?t=01h58m02s)



[both and I think that's probably what we](https://youtu.be/8Hq1aqVfesg?t=01h58m05s)



[want because I functionally the issue](https://youtu.be/8Hq1aqVfesg?t=01h58m07s)



[now is that the transparent color looks](https://youtu.be/8Hq1aqVfesg?t=01h58m09s)



[really good on white but because the the](https://youtu.be/8Hq1aqVfesg?t=01h58m12s)



[primary colors tend to be darker they do](https://youtu.be/8Hq1aqVfesg?t=01h58m15s)



[not look as good on a dark background](https://youtu.be/8Hq1aqVfesg?t=01h58m18s)



[versus a light background which is why](https://youtu.be/8Hq1aqVfesg?t=01h58m22s)



[I'm thinking I wanna I've talked myself](https://youtu.be/8Hq1aqVfesg?t=01h58m25s)



[into getting rid of the opacity I think](https://youtu.be/8Hq1aqVfesg?t=01h58m27s)



[that's probably what should happen is](https://youtu.be/8Hq1aqVfesg?t=01h58m33s)



[this should probably be swapped out and](https://youtu.be/8Hq1aqVfesg?t=01h58m36s)



[done a little a little differently so](https://youtu.be/8Hq1aqVfesg?t=01h58m38s)



[I'm gonna talk out loud for a moment cuz](https://youtu.be/8Hq1aqVfesg?t=01h58m43s)



[I don't think I I don't think I have](https://youtu.be/8Hq1aqVfesg?t=01h58m45s)



[time to actually fix it now but if](https://youtu.be/8Hq1aqVfesg?t=01h58m48s)



[somebody wants to take a stab at it](https://youtu.be/8Hq1aqVfesg?t=01h58m49s)



[without trying it what I'm what I'm](https://youtu.be/8Hq1aqVfesg?t=01h58m52s)



[thinking needs to happen is this is only](https://youtu.be/8Hq1aqVfesg?t=01h58m55s)



[here to hijack these dynamic resources](https://youtu.be/8Hq1aqVfesg?t=01h58m57s)



[right so these guys are just brushes](https://youtu.be/8Hq1aqVfesg?t=01h58m59s)



[that get resolved dynamically and this](https://youtu.be/8Hq1aqVfesg?t=01h59m06s)



[is hijacking it the only thing I don't](https://youtu.be/8Hq1aqVfesg?t=01h59m09s)



[like about this is this effectively](https://youtu.be/8Hq1aqVfesg?t=01h59m11s)



[makes it somewhat difficult for anyone](https://youtu.be/8Hq1aqVfesg?t=01h59m14s)



[else to go through and change it later](https://youtu.be/8Hq1aqVfesg?t=01h59m16s)



[what I almost want to do is go through](https://youtu.be/8Hq1aqVfesg?t=01h59m20s)



[and on the button assist class add a](https://youtu.be/8Hq1aqVfesg?t=01h59m22s)



[hover color hover brush or similar right](https://youtu.be/8Hq1aqVfesg?t=01h59m27s)



[and I think I want to default it to the](https://youtu.be/8Hq1aqVfesg?t=01h59m31s)



[primary humid brush with some opacity](https://youtu.be/8Hq1aqVfesg?t=01h59m35s)



[and some value convertor that lightens](https://youtu.be/8Hq1aqVfesg?t=01h59m41s)



[it up maybe maybe calls light and](https://youtu.be/8Hq1aqVfesg?t=01h59m45s)



[impasses a two or a three here for the](https://youtu.be/8Hq1aqVfesg?t=01h59m50s)



[amount to effectively shift it light or](https://youtu.be/8Hq1aqVfesg?t=01h59m52s)



[several shades I probably have to play](https://youtu.be/8Hq1aqVfesg?t=01h59m54s)



[with it to see what what looks close](https://youtu.be/8Hq1aqVfesg?t=01h59m56s)



[right because remember the the spec here](https://youtu.be/8Hq1aqVfesg?t=01h59m59s)



[that it shows for these buttons is not](https://youtu.be/8Hq1aqVfesg?t=02h00m02s)



[very dark at all all right like the](https://youtu.be/8Hq1aqVfesg?t=02h00m04s)



[hover effect is really really light this](https://youtu.be/8Hq1aqVfesg?t=02h00m07s)



[guy here right so this hover effect you](https://youtu.be/8Hq1aqVfesg?t=02h00m13s)



[can just barely see that purple over the](https://youtu.be/8Hq1aqVfesg?t=02h00m16s)



[top so we want it to be light but we](https://youtu.be/8Hq1aqVfesg?t=02h00m18s)



[don't want it to be invisible right](https://youtu.be/8Hq1aqVfesg?t=02h00m21s)



[there should be an obvious obvious](https://youtu.be/8Hq1aqVfesg?t=02h00m24s)



[indicator when your cursor gets over the](https://youtu.be/8Hq1aqVfesg?t=02h00m27s)



[top of it the idea is the user should](https://youtu.be/8Hq1aqVfesg?t=02h00m29s)



[know that it's something that they can](https://youtu.be/8Hq1aqVfesg?t=02h00m31s)



[click on and so you want it to to light](https://youtu.be/8Hq1aqVfesg?t=02h00m32s)



[up for them but I'm thinking that's](https://youtu.be/8Hq1aqVfesg?t=02h00m35s)



[probably the best solution is don't you](https://youtu.be/8Hq1aqVfesg?t=02h00m38s)



[don't rely on the opacity create an](https://youtu.be/8Hq1aqVfesg?t=02h00m41s)



[attached property on button assist and](https://youtu.be/8Hq1aqVfesg?t=02h00m46s)



[then rather than having this be dynamic](https://youtu.be/8Hq1aqVfesg?t=02h00m50s)



[resources here all right this then](https://youtu.be/8Hq1aqVfesg?t=02h00m53s)



[becomes a binding to that attached](https://youtu.be/8Hq1aqVfesg?t=02h00m57s)



[property and then the default value for](https://youtu.be/8Hq1aqVfesg?t=02h00m59s)



[that attached property gets set up here](https://youtu.be/8Hq1aqVfesg?t=02h01m05s)



[some of these that way it gives if](https://youtu.be/8Hq1aqVfesg?t=02h01m06s)



[somebody wants to go through and change](https://youtu.be/8Hq1aqVfesg?t=02h01m09s)



[that attached property they can and so](https://youtu.be/8Hq1aqVfesg?t=02h01m10s)



[again if people want to pick really bad](https://youtu.be/8Hq1aqVfesg?t=02h01m14s)



[colors and mix fuchsia and orange or](https://youtu.be/8Hq1aqVfesg?t=02h01m17s)



[something together they can do it but I](https://youtu.be/8Hq1aqVfesg?t=02h01m19s)



[don't recommend it and then it and then](https://youtu.be/8Hq1aqVfesg?t=02h01m21s)



[it should just work out of the box I](https://youtu.be/8Hq1aqVfesg?t=02h01m25s)



[think that's the solution that I'm I'm](https://youtu.be/8Hq1aqVfesg?t=02h01m26s)



[talking myself into](https://youtu.be/8Hq1aqVfesg?t=02h01m28s)



[I think that makes the most sense I may](https://youtu.be/8Hq1aqVfesg?t=02h01m31s)



[end up having to again I'd I don't know](https://youtu.be/8Hq1aqVfesg?t=02h01m36s)



[if I'm gonna get to it in the the near](https://youtu.be/8Hq1aqVfesg?t=02h01m38s)



[future but if I don't that might be a](https://youtu.be/8Hq1aqVfesg?t=02h01m40s)



[good topic for next week so I think I'm](https://youtu.be/8Hq1aqVfesg?t=02h01m42s)



[getting close to the end of my stream so](https://youtu.be/8Hq1aqVfesg?t=02h01m46s)



[I've had an early morning and I've got](https://youtu.be/8Hq1aqVfesg?t=02h01m49s)



[another early morning again tomorrow so](https://youtu.be/8Hq1aqVfesg?t=02h01m52s)



[I'm probably gonna cut it off here in](https://youtu.be/8Hq1aqVfesg?t=02h01m54s)



[just a minute thank you everyone for](https://youtu.be/8Hq1aqVfesg?t=02h01m57s)



[coming and dropping in](https://youtu.be/8Hq1aqVfesg?t=02h01m58s)



[thank you quality coder for the raid](https://youtu.be/8Hq1aqVfesg?t=02h01m59s)



[always nice to have more people in here](https://youtu.be/8Hq1aqVfesg?t=02h02m02s)



[and and for the chat so yeah if anybody](https://youtu.be/8Hq1aqVfesg?t=02h02m04s)



[is interested in helping out with this](https://youtu.be/8Hq1aqVfesg?t=02h02m08s)



[library I do really appreciate it](https://youtu.be/8Hq1aqVfesg?t=02h02m10s)



[there's been a lot of people that have](https://youtu.be/8Hq1aqVfesg?t=02h02m12s)



[contributed a lot recently to the](https://youtu.be/8Hq1aqVfesg?t=02h02m13s)



[material design project and I I cannot](https://youtu.be/8Hq1aqVfesg?t=02h02m16s)



[thank you enough this project would not](https://youtu.be/8Hq1aqVfesg?t=02h02m19s)



[be where it is without without help and](https://youtu.be/8Hq1aqVfesg?t=02h02m22s)



[so even if it's as simple as reviewing](https://youtu.be/8Hq1aqVfesg?t=02h02m25s)



[other people's pull requests or](https://youtu.be/8Hq1aqVfesg?t=02h02m27s)



[commenting on issues and giving feedback](https://youtu.be/8Hq1aqVfesg?t=02h02m29s)



[I really do appreciate all of that and](https://youtu.be/8Hq1aqVfesg?t=02h02m30s)



[it's it makes my life a lot easier and](https://youtu.be/8Hq1aqVfesg?t=02h02m33s)



[it certainly helps move the project](https://youtu.be/8Hq1aqVfesg?t=02h02m36s)



[forward so I think for now I am going to](https://youtu.be/8Hq1aqVfesg?t=02h02m38s)



[sign off apparently my subtitles have](https://youtu.be/8Hq1aqVfesg?t=02h02m42s)



[died yeah my subtitles have died awesome](https://youtu.be/8Hq1aqVfesg?t=02h02m47s)



[so I'm going to sign off for the night](https://youtu.be/8Hq1aqVfesg?t=02h02m51s)



[probably be back again next week at the](https://youtu.be/8Hq1aqVfesg?t=02h02m55s)



[usual time for me I keep toying around](https://youtu.be/8Hq1aqVfesg?t=02h02m58s)



[with maybe doing streams at different](https://youtu.be/8Hq1aqVfesg?t=02h03m01s)



[times or with other people if there are](https://youtu.be/8Hq1aqVfesg?t=02h03m03s)



[topics or anything that people are](https://youtu.be/8Hq1aqVfesg?t=02h03m05s)



[interested in please leave me a comment](https://youtu.be/8Hq1aqVfesg?t=02h03m08s)



[let me know that I have been looking for](https://youtu.be/8Hq1aqVfesg?t=02h03m11s)



[people who are interested in doing some](https://youtu.be/8Hq1aqVfesg?t=02h03m14s)



[pairing sessions whether it's on](https://youtu.be/8Hq1aqVfesg?t=02h03m15s)



[material design in zamel c-sharp or just](https://youtu.be/8Hq1aqVfesg?t=02h03m18s)



[something else that you're interested in](https://youtu.be/8Hq1aqVfesg?t=02h03m21s)



[I'm always happy to learn new things so](https://youtu.be/8Hq1aqVfesg?t=02h03m22s)



[if people are interested in doing](https://youtu.be/8Hq1aqVfesg?t=02h03m25s)



[pairing things I'm I'm happy to schedule](https://youtu.be/8Hq1aqVfesg?t=02h03m27s)



[it and get something going so I know](https://youtu.be/8Hq1aqVfesg?t=02h03m31s)



[Mike Kern we did some stuff if you go](https://youtu.be/8Hq1aqVfesg?t=02h03m33s)



[back to through the past videos in](https://youtu.be/8Hq1aqVfesg?t=02h03m37s)



[regards to doing some testing we were](https://youtu.be/8Hq1aqVfesg?t=02h03m39s)



[talking about potentially adding](https://youtu.be/8Hq1aqVfesg?t=02h03m41s)



[you i testing to material design in](https://youtu.be/8Hq1aqVfesg?t=02h03m44s)



[zamel just to kind of plug that in and](https://youtu.be/8Hq1aqVfesg?t=02h03m47s)



[see what what we could do with it](https://youtu.be/8Hq1aqVfesg?t=02h03m50s)



[and just kind of have some fun so that](https://youtu.be/8Hq1aqVfesg?t=02h03m53s)



[maybe coming up as well to if I can pin](https://youtu.be/8Hq1aqVfesg?t=02h03m55s)



[him down oh look subtitles cut back up](https://youtu.be/8Hq1aqVfesg?t=02h03m58s)



[alright so with that I'm going to sign](https://youtu.be/8Hq1aqVfesg?t=02h04m00s)



[off say thank you very much](https://youtu.be/8Hq1aqVfesg?t=02h04m03s)



[and happy coding](https://youtu.be/8Hq1aqVfesg?t=02h04m05s)



[you](https://youtu.be/8Hq1aqVfesg?t=02h04m15s)


