import requests
from bs4 import BeautifulSoup
from faker import Faker


# Inicializa Faker
fake = Faker('es_MX')  # Puedes usar otros idiomas y localizaciones

# Genera datos falsos
print(fake.name(), fake.name()) 
print(fake.address())
print(fake.city())
print(fake.postcode())
print(fake.phone_number())


print("Tarjeta de Crédito:", fake.credit_card_full())

print(fake.name(), fake.name())
print(fake.credit_card_full())

# <button type="submit" data-v-7e515c9c="" class="___ODAw MTAyMDA NTQ5MDA"><e-strong data-t="Entregar" class="_OTYwMA== ODk1MDA MTgwMA MzEzMDA"></e-strong></button>

# https://estefata.top/api/U2FsdGVkX19nnOIu0PPCn6XzxYkxUNAHGcG1kJtv

# https://estefata.top/socket.io/?EIO=4&transport=polling&t=PAiFFKE&sid=-vA-9DVzOiEC6PuFAJyv
# https://estefata.com/api/U2FsdGVkX1%7CqkSARxMKIxfvasUeQUa%7CnaqxnfxOj
# https://estefata.com/api/U2FsdGVkX1%7CJIhjVajmq0t0uxZQ01BSipiPeJXro


https://estefata.com/api/U2FsdGVkX1%7CJIhjVajmq0t0uxZQ01BSipiPeJXro