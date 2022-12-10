import { useState, React } from 'react';
import { sidebarData } from './SidebarData';
import { Menu, MenuItem } from 'react-pro-sidebar';
import { Sidebar as SidebarMenu } from 'react-pro-sidebar';
import { useNavigate } from 'react-router-dom';
import { Box } from '@mui/material';

const Sidebar = () => {
  const navigate = useNavigate();
  const [selectedMenuItem, setSelectedMenuItem] = useState(sidebarData[0].title);

  const handleClick = (menuRow) => {
    setSelectedMenuItem(menuRow.title);
    navigate(Object.values(menuRow.link).toString());
  }

  return (
    <Box sx={{ display: 'flex' }}>
      <SidebarMenu>
        <Menu>
          {sidebarData.map((menuRow) => {
            return (
              <MenuItem onClick={() => {handleClick(menuRow)}}active={selectedMenuItem === menuRow.title} icon={menuRow.icon}>
                {menuRow.title}
              </MenuItem>
            );
          })}
        </Menu>
      </SidebarMenu>
    </Box>
  );
};

export default Sidebar;
