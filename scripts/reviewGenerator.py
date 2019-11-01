import json
import random

borrows_filename = "Borrows.json"
reviews_filename = "Reviews.json"

review_percentage = 0.6
borrows = None
with open(borrows_filename, "r") as file:
    text = file.read()
    borrows = list(json.loads(text))

review_count = (int)(len(borrows) * review_percentage)
publications_to_review = random.sample(borrows, review_count)

reviews = []
for publication in publications_to_review:
    reviews.append({"Rating": random.randint(0,5), "FriendId": publication["FriendId"], "PublicationId": publication["PublicationId"]})

with open(reviews_filename, "w+") as file:
    file.write(json.dumps(reviews, indent=1))