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

    hostname = socket.gethostname()

    google_map = r'<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3506.07500260659!2d-81.51199932457922!3d28.507391075733405!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x88e778a949fd0083%3A0xb5b3da37f2feb6c3!2sOrlando%20Florida%20Temple!5e0!3m2!1sen!2sus!4v1704967161827!5m2!1sen!2sus" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>'

    html = f"""
    <div>
    <h1>{temple.city}, {temple.country} Temple</h1> 
    {google_map}
    {hostname}
    </div>
    """
    return HttpResponse(html)

