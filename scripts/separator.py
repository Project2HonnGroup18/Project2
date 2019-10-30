import json

original_file = "friend_publications.json"
destination_file = "Borrows.json"
seperated = []
count = 0
with open(original_file, "r") as file:
    text = file.read()
    friends = json.loads(text)
    for friend in friends:
        if "publications" in friend:
            for publication in friend["publications"]:
                count -= 1
                borrow = {"Id": count, "FriendId": friend["id"], "PublicationId": publication["id"], "BorrowDate": publication["borrow_date"], "ReturnDate": publication["return_date"]}
                seperated.append(borrow)

with open(destination_file, "w+") as file:
    file.write(json.dumps(seperated, indent=1))