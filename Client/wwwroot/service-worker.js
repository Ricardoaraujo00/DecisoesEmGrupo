// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
self.addEventListener('fetch', () => { }) && !event.request.url.includes('/user')
    && !event.request.url.includes('/user/signin')
    && !event.request.url.includes('/WeatherForecast')
    && !event.request.url.includes('/fetchdata');
