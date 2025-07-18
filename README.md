# EChargeFinder 🔌
<img width="1898" height="1003" alt="image" src="https://github.com/user-attachments/assets/ee63e8f2-bf06-47b6-b5f3-106b2d738019" />


**EChargeFinder** is a web & mobile-friendly tool designed to help users locate electric vehicle (EV) charging stations. It combines intuitive UI with robust backend services to present accurate, up-to-date information on charging points, including availability, connector types, pricing, and real-time status.

---

## 🚀 Features

- **Search by location**: Find charging stations near an entered address, GPS location, or map click.
- **Real-time availability**: Get live updates on station status—available, busy, offline.
- **Connector & power info**: Filter by connector type, power/fueling speed, and charger operator.
- **Multiplatform**: Responsive web UI ready for mobile; backend APIs support native app integration.

---

## 📦 Architecture

```
[Frontend (Web/Blazor)] ←→ [Backend API (ASP.NET)] ←→ [Database (TBD)]
                                ↓
                       [External Data Sources]
```

- **Frontend**: Interactive map interface (SwissTopo https://map.geo.admin.ch/).
- **Backend**: REST API handles geocoding, real-time status, route planning.
- **Database**: TBD
- **External APIs**: TBD

---

## 🧪 Usage

- **Search**: Enter city, ZIP code, or use the map to find nearby chargers.
- **Filter**: Use sidebar options to limit results by connector type, power, availability.
- **Plan a route**: Go to the “Route” tab, enter origin and destination, and receive recommended charging stops.
- **Submit a review**: Log in and rate a station based on conditions, pricing, and convenience.

---

## 📄 API Documentation

TBD

---

## 👥 Contributing

We welcome contributions! Please:

1. Fork the repo
2. Create a feature branch (`git checkout -b feat/your-feature`)
3. Add tests and documentation
4. Submit a pull request

Make sure to follow our code style and pass linting & test checks before submitting.

---

## 📝 License

This project is open-sourced under the **MIT License**. See the [`LICENSE`](LICENSE) file for details.

---

## 🎯 Roadmap

- 🔋 **Better route planning** (EV-specific, power-aware)
- 🌍 **Offline support** & progressive web app (PWA)
- ⭐ **Favorites** & charger bookmarking
- 📞 **Push notifications** for charger status changes

---

## 🙋‍♂️ Contact

Developed by **Silvano Mahir**.  
For questions or feedback, open an issue or pull request on GitHub.

---

### 🔧 Acknowledgments

- Uses data from **OpenChargeMap**, **ChargePoint**, and other public EV APIs.
- Icons & UI assets from **Font Awesome** and **Material UI**.
- Map visuals provided by **Mapbox**.
