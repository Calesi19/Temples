from django.shortcuts import render, HttpResponse
from .models import Temple
import socket

def home(request):
    temples = Temple.objects.all()

    return render(request, 'home.html', {"temples": temples})

def temple(request, temple_id):
    temple = Temple.objects.get(id=temple_id)
    return render(request, 'temple.html', {"temple": temple})

def templeshow(request, temple_id):
    temple = Temple.objects.get(id=temple_id)

    hostname = socket.gethostbyname(socket.gethostname())
    google_map = r'<iframe class="rounded my-5" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3506.07500260659!2d-81.51199932457922!3d28.507391075733405!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x88e778a949fd0083%3A0xb5b3da37f2feb6c3!2sOrlando%20Florida%20Temple!5e0!3m2!1sen!2sus!4v1704967161827!5m2!1sen!2sus" width="100%" height="200" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>'

    html = f"""
    <div width="100%">
    <h1>{temple.city}, {temple.country} Temple</h1>

    <div class="row my-5 px-3" style="justify-content: space-between">
    <div>
    <dl class="row">
    <dt class="col-sm-3">Address</dt>
    <dd class="col-sm-8">
    
    11301 Temple Hill Rd,
    Orlando, FL 32817
    
    </dd>
  
    <dt class="col-sm-3">Dedicated</dt>
    <dd class="col-sm-9">
      <p>Definition for the term.</p>
    </dd>
    </div>

    <div id="myCarousel" class="carousel slide rounded" style="height: 300px; width: 400px; overflow: hidden;">
    <div class="carousel-inner">
      <div class="carousel-item active" style="height: 100%; width: 100%;">
        <img src="https://churchofjesuschrist.org/imgs/0bae90c7bf31184e56e261bfa5d7a35788344e53/full/640%2C/0/default"
          class="d-block" style="height: 300px; width: 400px; object-fit: cover;" alt="...">
      </div>
      <div class="carousel-item" style="height: 100%; width: 100%;">
        <img src="https://newsroom.churchofjesuschrist.org/media/960x540/Orlando-Florida-Temple1.jpg" class="d-block"
          style="height: 300px; width: 400px; object-fit: cover;" alt="...">
      </div>
      <div class="carousel-item" style="height: 100%; width: 100%;">
        <img src="https://churchofjesuschrist.org/imgs/402235d4339b1719645d69bb9ffeafee53820198/full/640%2C/0/default"
          style="height: 300px; width: 400px; object-fit: cover;" class="d-block" alt="...">
      </div>
    </div>
    <button class="carousel-control-prev" type="button" style="background: none; border: none;" data-bs-target="#myCarousel" data-bs-slide="prev">
      <span class="carousel-control-prev-icon" aria-hidden="true"></span>

    </button>
    <button class="carousel-control-next" type="button" style="background: none; border: none;" data-bs-target="#myCarousel" data-bs-slide="next">
      <span class="carousel-control-next-icon" aria-hidden="true"></span>
    </button>
  </div>

    </div>
    {google_map}

    <div class="card p-4 bg-dark">
    <code style="color: white;">{hostname}/{temple_id}</code>
    </div>
    </div>
    """
    return HttpResponse(html)

